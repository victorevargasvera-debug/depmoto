using System;
using System.Net.Sockets;
using IACustomException;
using OpenSSL;
using OpenSSL.Crypto;
using OpenSSL.X509;
using SSLMangrComp.Packets;

namespace SSLMangrComp.ConnectionLayer
{
	// Token: 0x02000011 RID: 17
	internal class TLSWorker : global::SSLMangrComp.ConnectionLayer.IServerWorker
	{
		// Token: 0x1400000D RID: 13
		// (add) Token: 0x0600007F RID: 127 RVA: 0x00004460 File Offset: 0x00002660
		// (remove) Token: 0x06000080 RID: 128 RVA: 0x00004498 File Offset: 0x00002698
		public event global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle ReadPacketReceived;

		// Token: 0x1400000E RID: 14
		// (add) Token: 0x06000081 RID: 129 RVA: 0x000044D0 File Offset: 0x000026D0
		// (remove) Token: 0x06000082 RID: 130 RVA: 0x00004508 File Offset: 0x00002708
		public event global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle ErrorReceived;

		// Token: 0x06000083 RID: 131 RVA: 0x00004560 File Offset: 0x00002760
		public TLSWorker(global::SSLMangrComp.SecureServerConfiguration serverConfig, global::OpenSSL.X509.X509Certificate certificate, global::OpenSSL.X509.X509Chain certificateChain, global::OpenSSL.Crypto.DH dhparams, global::System.Net.Sockets.TcpClient client)
		{
			this.serverConfiguration = serverConfig;
			this.cert = certificate;
			this.caChain = certificateChain;
			this.dh = dhparams;
			this.tcpClient = client;
		}

		// Token: 0x06000084 RID: 132 RVA: 0x000045B0 File Offset: 0x000027B0
		public void Read()
		{
			global::SSLMangrComp.ErrorReport error = default(global::SSLMangrComp.ErrorReport);
			string str = base.GetType().ToString();
			str += ":Read";
			byte[] array = new byte[1024];
			global::SSLMangrComp.ConnectionLayer.MessageBuffer messageBuffer = new global::SSLMangrComp.ConnectionLayer.MessageBuffer(2048);
			int num = 10000;
			global::OpenSSL.SslStream sslStream = new global::OpenSSL.SslStream(this.tcpClient.GetStream(), false, new global::OpenSSL.RemoteCertificateValidationHandler(global::SSLMangrComp.ConnectionLayer.TLSServerWatcher.ValidateRemoteCert), new global::OpenSSL.LocalCertificateSelectionHandler(global::SSLMangrComp.ConnectionLayer.TLSServerWatcher.clientCertificateSelectionCallback));
			if (!this.AuthenticateClient(sslStream))
			{
				global::SSLMangrComp.Packets.Notify notify = new global::SSLMangrComp.Packets.Notify(this.errNotifyPacket, 2);
				notify.MessageID = byte.MaxValue;
				notify.IsPacketRecived = true;
				this.ReadPacketReceived(notify);
				return;
			}
			try
			{
				if (this.IsAuthenticated(sslStream))
				{
					num = 10000;
					while (num > 0 && !this.signalClose)
					{
						try
						{
							num = sslStream.Read(array, 0, array.Length);
						}
						catch (global::System.Exception)
						{
							num = 0;
						}
						if (num <= 0)
						{
							break;
						}
						messageBuffer.Add(array, num);
						byte[] reliableNotifyMessage;
						while ((reliableNotifyMessage = messageBuffer.GetReliableNotifyMessage()) != null)
						{
							if (this.ReadPacketReceived != null)
							{
								global::SSLMangrComp.Packets.PacketBase packet = global::SSLMangrComp.Packets.PacketFactory.GetPacket(reliableNotifyMessage, 2);
								packet.IsPacketRecived = true;
								this.ReadPacketReceived(packet);
							}
						}
					}
					sslStream.Close();
					this.tcpClient.Close();
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
				this.tcpClient.Close();
			}
			catch (global::System.Exception)
			{
				error.ErrCat = 300U;
				error.ErrorID = 1070U;
				if (this.ErrorReceived != null)
				{
					this.ErrorReceived(error);
				}
				this.tcpClient.Close();
			}
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00004790 File Offset: 0x00002990
		public void Close()
		{
			if (this.tcpClient != null)
			{
				if (this.tcpClient.Connected && this.tcpClient.Available > 0)
				{
					this.signalClose = true;
					return;
				}
				if (this.tcpClient.Connected)
				{
					this.tcpClient.GetStream().Close();
				}
			}
		}

		// Token: 0x06000086 RID: 134 RVA: 0x000047E8 File Offset: 0x000029E8
		private bool AuthenticateClient(global::OpenSSL.SslStream sslStream)
		{
			string str = base.GetType().ToString();
			str += ":Listen";
			bool result;
			try
			{
				if (this.serverConfiguration != null)
				{
					if (this.serverConfiguration.CipherSuites != string.Empty)
					{
						sslStream.SetCipherList(this.serverConfiguration.CipherSuites);
					}
					if (this.caChain != null && this.cert != null)
					{
						sslStream.AuthenticateAsServer(this.cert, true, this.caChain, global::OpenSSL.SslProtocols.Tls, global::OpenSSL.SslStrength.High, false, this.dh);
					}
				}
				result = true;
			}
			catch (global::IACustomException.IACommonException)
			{
				this.tcpClient.Close();
				result = false;
			}
			catch (global::System.Exception)
			{
				this.tcpClient.Close();
				result = false;
			}
			return result;
		}

		// Token: 0x06000087 RID: 135 RVA: 0x000048AC File Offset: 0x00002AAC
		private bool IsAuthenticated(global::OpenSSL.SslStream sslStream)
		{
			global::SSLMangrComp.ErrorReport error = default(global::SSLMangrComp.ErrorReport);
			string str = base.GetType().ToString();
			str += ":Listen";
			if (this.serverConfiguration != null)
			{
				if (!sslStream.IsMutuallyAuthenticated)
				{
					error.ErrorID = 1074U;
					error.ErrCat = 300U;
					if (this.ErrorReceived != null)
					{
						this.ErrorReceived(error);
					}
					return false;
				}
				if (sslStream.SslProtocol != global::OpenSSL.SslProtocols.Tls)
				{
					error.ErrorID = 1070U;
					error.ErrCat = 300U;
					if (this.ErrorReceived != null)
					{
						this.ErrorReceived(error);
					}
					return false;
				}
				if (sslStream.CipherStrength < 256)
				{
					error.ErrCat = 300U;
					error.ErrorID = 1075U;
					if (this.ErrorReceived != null)
					{
						this.ErrorReceived(error);
					}
					return false;
				}
			}
			return true;
		}

		// Token: 0x0400003D RID: 61
		private global::SSLMangrComp.SecureServerConfiguration serverConfiguration;

		// Token: 0x0400003E RID: 62
		private global::OpenSSL.X509.X509Certificate cert;

		// Token: 0x0400003F RID: 63
		private global::OpenSSL.X509.X509Chain caChain;

		// Token: 0x04000040 RID: 64
		private global::OpenSSL.Crypto.DH dh;

		// Token: 0x04000041 RID: 65
		private global::System.Net.Sockets.TcpClient tcpClient;

		// Token: 0x04000042 RID: 66
		private bool signalClose;

		// Token: 0x04000045 RID: 69
		public byte[] errNotifyPacket = new byte[]
		{
			28,
			0,
			4,
			1,
			0,
			3,
			1,
			2,
			1,
			4,
			0,
			174,
			209,
			127,
			10,
			6,
			49,
			0,
			49,
			0,
			49,
			0,
			2,
			2,
			48,
			0,
			14,
			2,
			48,
			0
		};
	}
}
