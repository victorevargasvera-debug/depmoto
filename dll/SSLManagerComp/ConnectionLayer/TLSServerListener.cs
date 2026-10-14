using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using IACustomException;
using OpenSSL;
using OpenSSL.Core;
using OpenSSL.Crypto;
using OpenSSL.X509;
using SSLMangrComp.Packets;

namespace SSLMangrComp.ConnectionLayer
{
	// Token: 0x02000007 RID: 7
	internal class TLSServerListener : global::SSLMangrComp.ConnectionLayer.IServerListener
	{
		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000025 RID: 37 RVA: 0x00002664 File Offset: 0x00000864
		// (remove) Token: 0x06000026 RID: 38 RVA: 0x0000269C File Offset: 0x0000089C
		public event global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle PacketRecived;

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06000027 RID: 39 RVA: 0x000026D4 File Offset: 0x000008D4
		// (remove) Token: 0x06000028 RID: 40 RVA: 0x0000270C File Offset: 0x0000090C
		public event global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle ErrorReceived;

		// Token: 0x06000029 RID: 41 RVA: 0x00002744 File Offset: 0x00000944
		public void StartListner(global::System.Net.IPAddress pnIPAddress, global::SSLMangrComp.SecureServerConfiguration secureServerConfig, global::SSLMangrComp.Packets.SubscriptionType LMode)
		{
			this.m_pnIPAddress = pnIPAddress;
			this.serverConfiguration = secureServerConfig;
			this.m_LMode = LMode;
			this.ShutdownServer();
			this.m_lsnrThread = new global::System.Threading.Thread(new global::System.Threading.ThreadStart(this.Listen));
			this.m_lsnrThread.Start();
			global::System.Threading.Thread.Sleep(500);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002798 File Offset: 0x00000998
		public void StartListner(int port)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000027A0 File Offset: 0x000009A0
		private void Listen()
		{
			global::OpenSSL.X509.X509Certificate x509Certificate = null;
			global::OpenSSL.X509.X509Chain x509Chain = null;
			global::OpenSSL.Crypto.DH dh = null;
			global::SSLMangrComp.ErrorReport error = default(global::SSLMangrComp.ErrorReport);
			string str = base.GetType().ToString();
			str += ":Listen";
			try
			{
				lock (this.m_listenLock)
				{
					this.m_stop = false;
					this.m_listener = new global::System.Net.Sockets.TcpListener(global::System.Net.IPAddress.Any, 0);
					this.m_listener.Start(5);
					if (this.m_LMode == global::SSLMangrComp.Packets.SubscriptionType.Secure && this.serverConfiguration != null)
					{
						if (this.serverConfiguration.ClientCertificate != null && this.serverConfiguration.ClientKeyPassphrase != null && this.serverConfiguration.ClientCertificate != string.Empty && this.serverConfiguration.ClientKeyPassphrase != string.Empty)
						{
							x509Certificate = global::OpenSSL.X509.X509Certificate.FromPKCS12(new global::OpenSSL.Core.BIO(global::System.Convert.FromBase64String(this.serverConfiguration.ClientCertificate)), this.serverConfiguration.ClientKeyPassphrase);
							global::OpenSSL.X509.X509List x509List = new global::OpenSSL.X509.X509List();
							x509List.Add(x509Certificate);
						}
						if (this.serverConfiguration.CACertificate != null && this.serverConfiguration.CACertificate != string.Empty)
						{
							x509Chain = new global::OpenSSL.X509.X509Chain(global::OpenSSL.X509.X509Certificate.FromDER(new global::OpenSSL.Core.BIO(global::System.Convert.FromBase64String(this.serverConfiguration.CACertificate))).PEM);
						}
						if (this.serverConfiguration.DHParameters != null)
						{
							dh = global::OpenSSL.Crypto.DH.FromParametersPEM(new global::OpenSSL.Core.BIO(this.serverConfiguration.DHParameters));
						}
					}
					byte[] array = new byte[1024];
					global::SSLMangrComp.ConnectionLayer.MessageBuffer messageBuffer = new global::SSLMangrComp.ConnectionLayer.MessageBuffer(2048);
					int num = 10000;
					while (!this.m_stop)
					{
						this.m_client = this.m_listener.AcceptTcpClient();
						this.m_sslStream = new global::OpenSSL.SslStream(this.m_client.GetStream(), false, new global::OpenSSL.RemoteCertificateValidationHandler(global::SSLMangrComp.ConnectionLayer.TLSServerListener.ValidateRemoteCert), new global::OpenSSL.LocalCertificateSelectionHandler(global::SSLMangrComp.ConnectionLayer.TLSServerListener.clientCertificateSelectionCallback));
						if (this.m_LMode == global::SSLMangrComp.Packets.SubscriptionType.Secure && this.serverConfiguration != null)
						{
							if (this.serverConfiguration.CipherSuites != string.Empty)
							{
								this.m_sslStream.SetCipherList(this.serverConfiguration.CipherSuites);
							}
							if (x509Chain != null && x509Certificate != null)
							{
								this.m_sslStream.AuthenticateAsServer(x509Certificate, true, x509Chain, global::OpenSSL.SslProtocols.Tls, global::OpenSSL.SslStrength.High, false, dh);
							}
						}
						try
						{
							if (this.m_LMode == global::SSLMangrComp.Packets.SubscriptionType.Secure && this.serverConfiguration != null)
							{
								if (!this.m_sslStream.IsMutuallyAuthenticated)
								{
									error.ErrorID = 1074U;
									error.ErrCat = 300U;
									if (this.ErrorReceived != null)
									{
										this.ErrorReceived(error);
									}
									this.ShutdownServer();
									break;
								}
								if (this.m_sslStream.SslProtocol != global::OpenSSL.SslProtocols.Tls)
								{
									error.ErrorID = 1070U;
									error.ErrCat = 300U;
									if (this.ErrorReceived != null)
									{
										this.ErrorReceived(error);
									}
									this.ShutdownServer();
									break;
								}
								if (this.m_sslStream.CipherStrength < 256)
								{
									error.ErrCat = 300U;
									error.ErrorID = 1075U;
									if (this.ErrorReceived != null)
									{
										this.ErrorReceived(error);
									}
									this.ShutdownServer();
									break;
								}
							}
							num = 10000;
							while (!this.m_stop && num > 0)
							{
								try
								{
									num = this.m_sslStream.Read(array, 0, array.Length);
								}
								catch (global::System.Exception)
								{
									num = 0;
								}
								if (num > 0)
								{
									messageBuffer.Add(array, num);
									byte[] reliableNotifyMessage;
									while ((reliableNotifyMessage = messageBuffer.GetReliableNotifyMessage()) != null)
									{
										if (this.PacketRecived != null)
										{
											global::SSLMangrComp.Packets.PacketBase packet = global::SSLMangrComp.Packets.PacketFactory.GetPacket(reliableNotifyMessage, 2);
											packet.IsPacketRecived = true;
											this.PacketRecived(packet);
											break;
										}
									}
								}
								else
								{
									this.m_sslStream.Close();
								}
							}
						}
						catch (global::IACustomException.IACommonException)
						{
							error.ErrCat = 300U;
							error.ErrorID = 1070U;
							if (this.ErrorReceived != null)
							{
								this.ErrorReceived(error);
							}
							this.ShutdownServer();
						}
						catch (global::System.Exception)
						{
							error.ErrCat = 300U;
							error.ErrorID = 1070U;
							if (this.ErrorReceived != null)
							{
								this.ErrorReceived(error);
							}
							this.ShutdownServer();
						}
					}
				}
			}
			catch (global::System.Exception)
			{
				error.ErrCat = 200U;
				error.ErrorID = 1069U;
				if (this.ErrorReceived != null)
				{
					this.ErrorReceived(error);
				}
				this.ShutdownServer();
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002C70 File Offset: 0x00000E70
		public bool IsServerRunning()
		{
			return !this.m_stop;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002C7C File Offset: 0x00000E7C
		public void ShutdownServer()
		{
			lock (this.m_shutdownLock)
			{
				if (this.IsServerRunning())
				{
					this.m_stop = true;
					if (this.m_sslStream != null)
					{
						this.m_sslStream.Close();
					}
					if (this.m_client != null)
					{
						this.m_client.Close();
					}
					if (this.m_listener != null)
					{
						this.m_listener.Stop();
					}
					this.m_lsnrThread = null;
				}
			}
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002D08 File Offset: 0x00000F08
		public int getPortNumber()
		{
			if (!this.IsServerRunning())
			{
				return 0;
			}
			if (!(this.m_listener.LocalEndpoint is global::System.Net.IPEndPoint))
			{
				return 0;
			}
			return ((global::System.Net.IPEndPoint)this.m_listener.LocalEndpoint).Port;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002D3D File Offset: 0x00000F3D
		public void RegisterIncomingPacketHandler(global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle hdl)
		{
			this.PacketRecived += hdl;
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002D46 File Offset: 0x00000F46
		public void RegisterIncomingErrorHandler(global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle hdl)
		{
			this.ErrorReceived += hdl;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002D50 File Offset: 0x00000F50
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

		// Token: 0x06000032 RID: 50 RVA: 0x00002DD8 File Offset: 0x00000FD8
		private static bool ValidateRemoteCert(object obj, global::OpenSSL.X509.X509Certificate cert, global::OpenSSL.X509.X509Chain chain, int depth, global::OpenSSL.VerifyResult result)
		{
			bool flag = false;
			global::SSLMangrComp.ErrorReport error = default(global::SSLMangrComp.ErrorReport);
			global::SSLMangrComp.ConnectionLayer.TLSServerListener tlsserverListener = new global::SSLMangrComp.ConnectionLayer.TLSServerListener();
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
					if (tlsserverListener.ErrorReceived != null)
					{
						tlsserverListener.ErrorReceived(error);
					}
					return false;
				case global::OpenSSL.VerifyResult.X509_V_ERR_CERT_HAS_EXPIRED:
				case global::OpenSSL.VerifyResult.X509_V_ERR_ERROR_IN_CERT_NOT_AFTER_FIELD:
					error.ErrCat = 400U;
					error.ErrorID = 1080U;
					if (tlsserverListener.ErrorReceived != null)
					{
						tlsserverListener.ErrorReceived(error);
					}
					return false;
				case global::OpenSSL.VerifyResult.X509_V_ERR_CRL_NOT_YET_VALID:
				case global::OpenSSL.VerifyResult.X509_V_ERR_CRL_HAS_EXPIRED:
				case global::OpenSSL.VerifyResult.X509_V_ERR_ERROR_IN_CRL_LAST_UPDATE_FIELD:
				case global::OpenSSL.VerifyResult.X509_V_ERR_ERROR_IN_CRL_NEXT_UPDATE_FIELD:
				case global::OpenSSL.VerifyResult.X509_V_ERR_OUT_OF_MEM:
					return flag;
				case global::OpenSSL.VerifyResult.X509_V_ERR_DEPTH_ZERO_SELF_SIGNED_CERT:
					flag = global::SSLMangrComp.ConnectionLayer.TLSServerListener.CheckCert(cert, chain);
					if (flag)
					{
						return flag;
					}
					error.ErrCat = 400U;
					error.ErrorID = 1087U;
					if (tlsserverListener.ErrorReceived != null)
					{
						tlsserverListener.ErrorReceived(error);
						return flag;
					}
					return flag;
				case global::OpenSSL.VerifyResult.X509_V_ERR_SELF_SIGNED_CERT_IN_CHAIN:
					flag = global::SSLMangrComp.ConnectionLayer.TLSServerListener.CheckCert(cert, chain);
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
			flag = global::SSLMangrComp.ConnectionLayer.TLSServerListener.CheckCert(cert, chain);
			if (!flag && depth != 0)
			{
				flag = true;
			}
			return flag;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002F18 File Offset: 0x00001118
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

		// Token: 0x0400000D RID: 13
		private bool m_stop = true;

		// Token: 0x0400000E RID: 14
		private global::System.Threading.Thread m_lsnrThread;

		// Token: 0x0400000F RID: 15
		private global::System.Net.Sockets.TcpListener m_listener;

		// Token: 0x04000010 RID: 16
		private global::System.Net.Sockets.TcpClient m_client;

		// Token: 0x04000011 RID: 17
		private global::OpenSSL.SslStream m_sslStream;

		// Token: 0x04000012 RID: 18
		private global::SSLMangrComp.SecureServerConfiguration serverConfiguration;

		// Token: 0x04000013 RID: 19
		private global::System.Net.IPAddress m_pnIPAddress;

		// Token: 0x04000014 RID: 20
		private global::SSLMangrComp.Packets.SubscriptionType m_LMode;

		// Token: 0x04000015 RID: 21
		private object m_shutdownLock = new object();

		// Token: 0x04000016 RID: 22
		private object m_listenLock = new object();
	}
}
