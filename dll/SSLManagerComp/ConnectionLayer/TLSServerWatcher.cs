using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using OpenSSL;
using OpenSSL.Core;
using OpenSSL.Crypto;
using OpenSSL.X509;
using SSLMangrComp.Packets;

namespace SSLMangrComp.ConnectionLayer
{
	// Token: 0x02000010 RID: 16
	internal class TLSServerWatcher : global::SSLMangrComp.ConnectionLayer.ServerBase, global::SSLMangrComp.ConnectionLayer.IServerWatcher
	{
		// Token: 0x1400000B RID: 11
		// (add) Token: 0x06000070 RID: 112 RVA: 0x00003DB4 File Offset: 0x00001FB4
		// (remove) Token: 0x06000071 RID: 113 RVA: 0x00003DEC File Offset: 0x00001FEC
		private event global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle PacketRecived;

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x06000072 RID: 114 RVA: 0x00003E24 File Offset: 0x00002024
		// (remove) Token: 0x06000073 RID: 115 RVA: 0x00003E5C File Offset: 0x0000205C
		private event global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle ErrorReceived;

		// Token: 0x06000075 RID: 117 RVA: 0x00003E9C File Offset: 0x0000209C
		public void StartListener(global::SSLMangrComp.PNConnectionInfo connInfo)
		{
			this.m_LMode = global::SSLMangrComp.Packets.SubscriptionType.Secure;
			this.serverConfiguration = connInfo.TLSServerConfig;
			base.ShutdownServer();
			this._lsnrThread = new global::System.Threading.Thread(new global::System.Threading.ThreadStart(this.Listen));
			this._lsnrThread.Start();
			global::System.Threading.Thread.Sleep(500);
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00003EF0 File Offset: 0x000020F0
		private void Listen()
		{
			global::SSLMangrComp.ErrorReport error = default(global::SSLMangrComp.ErrorReport);
			string str = base.GetType().ToString();
			str += ":Listen";
			try
			{
				lock (this.m_listenLock)
				{
					this.m_stop = false;
					this.m_listener = new global::System.Net.Sockets.TcpListener(global::System.Net.IPAddress.Any, 0);
					this.m_listener.Start(500);
					this.SetupSecureServer();
					while (!this.m_stop)
					{
						global::System.Net.Sockets.TcpClient client = this.m_listener.AcceptTcpClient();
						global::System.Threading.Thread.Sleep(500);
						global::SSLMangrComp.ConnectionLayer.TLSWorker tlsworker = new global::SSLMangrComp.ConnectionLayer.TLSWorker(this.serverConfiguration, this.cert, this.caChain, this.dh, client);
						tlsworker.ReadPacketReceived += this.OnWorkerPacket;
						global::System.Threading.Thread thread = new global::System.Threading.Thread(new global::System.Threading.ThreadStart(tlsworker.Read));
						thread.Start();
						this.readWorkers.Add(tlsworker);
					}
				}
			}
			catch (global::System.Exception ex)
			{
				if (ex is global::System.Net.Sockets.SocketException)
				{
					global::System.Net.Sockets.SocketException ex2 = (global::System.Net.Sockets.SocketException)ex;
					if (ex2.ErrorCode == 10004)
					{
						return;
					}
				}
				error.ErrCat = 200U;
				error.ErrorID = 1069U;
				if (this.ErrorReceived != null)
				{
					this.ErrorReceived(error);
				}
				base.ShutdownServer();
			}
		}

		// Token: 0x06000077 RID: 119 RVA: 0x0000405C File Offset: 0x0000225C
		private void SetupSecureServer()
		{
			string str = base.GetType().ToString();
			str += ":Listen";
			if (this.m_LMode == global::SSLMangrComp.Packets.SubscriptionType.Secure && this.serverConfiguration != null)
			{
				if (this.serverConfiguration.ClientCertificate != null && this.serverConfiguration.ClientKeyPassphrase != null && this.serverConfiguration.ClientCertificate != string.Empty && this.serverConfiguration.ClientKeyPassphrase != string.Empty)
				{
					this.cert = global::OpenSSL.X509.X509Certificate.FromPKCS12(new global::OpenSSL.Core.BIO(global::System.Convert.FromBase64String(this.serverConfiguration.ClientCertificate)), this.serverConfiguration.ClientKeyPassphrase);
					global::OpenSSL.X509.X509List x509List = new global::OpenSSL.X509.X509List();
					x509List.Add(this.cert);
				}
				if (this.serverConfiguration.CACertificate != null && this.serverConfiguration.CACertificate != string.Empty)
				{
					this.caChain = new global::OpenSSL.X509.X509Chain(global::OpenSSL.X509.X509Certificate.FromDER(new global::OpenSSL.Core.BIO(global::System.Convert.FromBase64String(this.serverConfiguration.CACertificate))).PEM);
				}
				if (this.serverConfiguration.DHParameters != null)
				{
					this.dh = global::OpenSSL.Crypto.DH.FromParametersPEM(new global::OpenSSL.Core.BIO(this.serverConfiguration.DHParameters));
				}
			}
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00004192 File Offset: 0x00002392
		public void RegisterIncomingPacketHandler(global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle hdl)
		{
			this.PacketRecived += hdl;
		}

		// Token: 0x06000079 RID: 121 RVA: 0x0000419B File Offset: 0x0000239B
		public void RegisterIncomingErrorHandler(global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle hdl)
		{
			this.ErrorReceived += hdl;
		}

		// Token: 0x0600007A RID: 122 RVA: 0x000041A4 File Offset: 0x000023A4
		public static global::OpenSSL.X509.X509Certificate clientCertificateSelectionCallback(object sender, string targetHost, global::OpenSSL.X509.X509List localCerts, global::OpenSSL.X509.X509Certificate remoteCert, string[] acceptableIssuers)
		{
			global::OpenSSL.X509.X509Certificate result = null;
			for (int i = 0; i < acceptableIssuers.GetLength(0); i++)
			{
				global::OpenSSL.X509.X509Name x509Name = new global::OpenSSL.X509.X509Name(acceptableIssuers[i]);
				foreach (global::OpenSSL.X509.X509Certificate x509Certificate in localCerts)
				{
					if (x509Certificate.Issuer.CompareTo(x509Name) == 0)
					{
						result = x509Certificate;
						break;
					}
					x509Certificate.Dispose();
				}
				x509Name.Dispose();
			}
			return result;
		}

		// Token: 0x0600007B RID: 123 RVA: 0x0000422C File Offset: 0x0000242C
		public static bool ValidateRemoteCert(object obj, global::OpenSSL.X509.X509Certificate cert, global::OpenSSL.X509.X509Chain chain, int depth, global::OpenSSL.VerifyResult result)
		{
			bool flag = false;
			global::SSLMangrComp.ErrorReport error = default(global::SSLMangrComp.ErrorReport);
			global::SSLMangrComp.ConnectionLayer.TLSServerWatcher tlsserverWatcher = new global::SSLMangrComp.ConnectionLayer.TLSServerWatcher();
			switch (result)
			{
			case global::OpenSSL.VerifyResult.X509_V_OK:
				return true;
			case (global::OpenSSL.VerifyResult)1:
				return flag;
			case global::OpenSSL.VerifyResult.X509_V_ERR_UNABLE_TO_GET_ISSUER_CERT:
				break;
			default:
				switch (result)
				{
				case global::OpenSSL.VerifyResult.X509_V_ERR_CERT_NOT_YET_VALID:
				case global::OpenSSL.VerifyResult.X509_V_ERR_ERROR_IN_CERT_NOT_BEFORE_FIELD:
					error.ErrCat = 400U;
					error.ErrorID = 1081U;
					if (tlsserverWatcher.ErrorReceived != null)
					{
						tlsserverWatcher.ErrorReceived(error);
					}
					return false;
				case global::OpenSSL.VerifyResult.X509_V_ERR_CERT_HAS_EXPIRED:
				case global::OpenSSL.VerifyResult.X509_V_ERR_ERROR_IN_CERT_NOT_AFTER_FIELD:
					error.ErrCat = 400U;
					error.ErrorID = 1080U;
					if (tlsserverWatcher.ErrorReceived != null)
					{
						tlsserverWatcher.ErrorReceived(error);
					}
					return false;
				case global::OpenSSL.VerifyResult.X509_V_ERR_CRL_NOT_YET_VALID:
				case global::OpenSSL.VerifyResult.X509_V_ERR_CRL_HAS_EXPIRED:
				case global::OpenSSL.VerifyResult.X509_V_ERR_ERROR_IN_CRL_LAST_UPDATE_FIELD:
				case global::OpenSSL.VerifyResult.X509_V_ERR_ERROR_IN_CRL_NEXT_UPDATE_FIELD:
				case global::OpenSSL.VerifyResult.X509_V_ERR_OUT_OF_MEM:
					return flag;
				case global::OpenSSL.VerifyResult.X509_V_ERR_DEPTH_ZERO_SELF_SIGNED_CERT:
					flag = global::SSLMangrComp.ConnectionLayer.TLSServerWatcher.CheckCert(cert, chain);
					if (flag)
					{
						return flag;
					}
					error.ErrCat = 400U;
					error.ErrorID = 1087U;
					if (tlsserverWatcher.ErrorReceived != null)
					{
						tlsserverWatcher.ErrorReceived(error);
						return flag;
					}
					return flag;
				case global::OpenSSL.VerifyResult.X509_V_ERR_SELF_SIGNED_CERT_IN_CHAIN:
					flag = global::SSLMangrComp.ConnectionLayer.TLSServerWatcher.CheckCert(cert, chain);
					if (!flag && depth != 0)
					{
						return true;
					}
					return flag;
				case global::OpenSSL.VerifyResult.X509_V_ERR_UNABLE_TO_GET_ISSUER_CERT_LOCALLY:
				case global::OpenSSL.VerifyResult.X509_V_ERR_UNABLE_TO_VERIFY_LEAF_SIGNATURE:
					break;
				default:
					if (result != global::OpenSSL.VerifyResult.X509_V_ERR_CERT_UNTRUSTED)
					{
						return flag;
					}
					break;
				}
				break;
			}
			flag = global::SSLMangrComp.ConnectionLayer.TLSServerWatcher.CheckCert(cert, chain);
			if (!flag && depth != 0)
			{
				flag = true;
			}
			return flag;
		}

		// Token: 0x0600007C RID: 124 RVA: 0x0000436C File Offset: 0x0000256C
		private static bool CheckCert(global::OpenSSL.X509.X509Certificate cert, global::OpenSSL.X509.X509Chain chain)
		{
			if (cert == null || chain == null)
			{
				return false;
			}
			foreach (global::OpenSSL.X509.X509Certificate x509Certificate in chain)
			{
				if (cert == x509Certificate)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600007D RID: 125 RVA: 0x000043C0 File Offset: 0x000025C0
		protected void OnWorkerPacket(global::SSLMangrComp.Packets.PacketBase packet)
		{
			lock (this.packetLock)
			{
				if (this.PacketRecived != null)
				{
					this.PacketRecived(packet);
				}
			}
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00004410 File Offset: 0x00002610
		protected void OnErrorReceived(global::SSLMangrComp.ErrorReport error)
		{
			lock (this.errorLock)
			{
				if (this.ErrorReceived != null)
				{
					this.ErrorReceived(error);
				}
			}
		}

		// Token: 0x04000037 RID: 55
		private global::OpenSSL.X509.X509Certificate cert;

		// Token: 0x04000038 RID: 56
		private global::OpenSSL.X509.X509Chain caChain;

		// Token: 0x04000039 RID: 57
		private global::OpenSSL.Crypto.DH dh;

		// Token: 0x0400003A RID: 58
		private global::SSLMangrComp.SecureServerConfiguration serverConfiguration;
	}
}
