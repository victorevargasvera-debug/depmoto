using System;
using System.Net;
using System.Net.Sockets;
using IACustomException;
using OpenSSL;
using OpenSSL.Core;
using OpenSSL.X509;
using SSLMangrComp.Connectors;

namespace SSLMangrComp.ConnectionLayer
{
	// Token: 0x0200001F RID: 31
	internal class TLSClientConnector : global::SSLMangrComp.Connectors.IClientConnector
	{
		// Token: 0x060000F7 RID: 247 RVA: 0x00005D54 File Offset: 0x00003F54
		public void Connect(global::System.Net.IPAddress pnIPAddress, int portNumber)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00005D5C File Offset: 0x00003F5C
		public void Connect(global::System.Net.IPAddress pnIPAddress, int portNumber, global::SSLMangrComp.SecureClientConfiguration clientConfig)
		{
			if (this.sslStream != null)
			{
				return;
			}
			string text = base.GetType().ToString();
			text += ":Connect";
			try
			{
				global::OpenSSL.X509.X509Certificate x509Certificate = null;
				global::OpenSSL.X509.X509List x509List = new global::OpenSSL.X509.X509List();
				if (clientConfig.CACertificate != null && clientConfig.CACertificate != string.Empty)
				{
					x509Certificate = global::OpenSSL.X509.X509Certificate.FromDER(new global::OpenSSL.Core.BIO(global::System.Convert.FromBase64String(clientConfig.CACertificate)));
				}
				if (clientConfig.ClientCertificate != null && clientConfig.ClientKeyPassphrase != null && clientConfig.ClientCertificate != string.Empty && clientConfig.ClientKeyPassphrase != string.Empty)
				{
					global::OpenSSL.X509.X509Certificate item = global::OpenSSL.X509.X509Certificate.FromPKCS12(new global::OpenSSL.Core.BIO(global::System.Convert.FromBase64String(clientConfig.ClientCertificate)), clientConfig.ClientKeyPassphrase);
					x509List.Add(item);
				}
				global::SSLMangrComp.ConnectionLayer.TLSClientConnector.client = new global::System.Net.Sockets.TcpClient(pnIPAddress.ToString(), portNumber);
				this.sslStream = new global::OpenSSL.SslStream(global::SSLMangrComp.ConnectionLayer.TLSClientConnector.client.GetStream(), false, new global::OpenSSL.RemoteCertificateValidationHandler(this.ValidateRemoteCert), new global::OpenSSL.LocalCertificateSelectionHandler(this.clientCertificateSelectionCallback));
				this.sslStream.SetCipherList(clientConfig.CipherSuites);
				this.sslStream.AuthenticateAsClient(pnIPAddress.ToString(), x509List, new global::OpenSSL.X509.X509Chain(x509Certificate.PEM), global::OpenSSL.SslProtocols.Tls, global::OpenSSL.SslStrength.All, false);
				if (!this.sslStream.IsMutuallyAuthenticated)
				{
					this.ShutdownClient();
					throw new global::IACustomException.IACommonException(global::IACustomException.IACommonErrorCode.SSL_PE_MutualAuthenticationFail)
					{
						Source = text
					};
				}
				if (this.sslStream.SslProtocol != global::OpenSSL.SslProtocols.Tls)
				{
					this.ShutdownClient();
					throw new global::IACustomException.IACommonException(global::IACustomException.IACommonErrorCode.SSL_PE_TLSProtocolFailed)
					{
						Source = text
					};
				}
				if (this.sslStream.CipherStrength < 256)
				{
					this.ShutdownClient();
					throw new global::IACustomException.IACommonException(global::IACustomException.IACommonErrorCode.SSL_PE_CipherStrengthFail)
					{
						Source = text
					};
				}
				if (this.sslStream.CipherAlgorithm != global::OpenSSL.CipherAlgorithmType.Aes256)
				{
					this.ShutdownClient();
					throw new global::IACustomException.IACommonException(global::IACustomException.IACommonErrorCode.SSL_PE_AESCipherFail)
					{
						Source = text
					};
				}
			}
			catch (global::IACustomException.IACommonException ex)
			{
				throw ex;
			}
			catch (global::System.Exception systemException)
			{
				this.ShutdownClient();
				throw new global::IACustomException.IACommonException(global::IACustomException.IACommonErrorCode.SSL_LE_UnableToOpenSocket, systemException);
			}
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00005F8C File Offset: 0x0000418C
		public void ShutdownClient()
		{
			if (this.sslStream != null)
			{
				this.sslStream = null;
			}
			if (global::SSLMangrComp.ConnectionLayer.TLSClientConnector.client != null)
			{
				global::SSLMangrComp.ConnectionLayer.TLSClientConnector.client.Close();
			}
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00005FB0 File Offset: 0x000041B0
		public void WriteData(byte[] dataToWrite)
		{
			if (this.sslStream != null)
			{
				this.sslStream.Write(dataToWrite, 0, dataToWrite.Length);
				return;
			}
			string text = base.GetType().ToString();
			text += ":WriteData";
			throw new global::IACustomException.IACommonException(global::IACustomException.IACommonErrorCode.SSL_MessageCouldNotBeParsed)
			{
				Source = text
			};
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00006004 File Offset: 0x00004204
		public bool ValidateRemoteCert(object obj, global::OpenSSL.X509.X509Certificate cert, global::OpenSSL.X509.X509Chain chain, int depth, global::OpenSSL.VerifyResult result)
		{
			bool flag = false;
			string text = base.GetType().ToString();
			text += ":ValidateRemoteCert";
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
					throw new global::IACustomException.IACommonException(global::IACustomException.IACommonErrorCode.SSL_CE_CertificateNotYetActive)
					{
						Source = text
					};
				case global::OpenSSL.VerifyResult.X509_V_ERR_CERT_HAS_EXPIRED:
				case global::OpenSSL.VerifyResult.X509_V_ERR_ERROR_IN_CERT_NOT_AFTER_FIELD:
					throw new global::IACustomException.IACommonException(global::IACustomException.IACommonErrorCode.SSL_CE_CertificateExpired)
					{
						Source = text
					};
				case global::OpenSSL.VerifyResult.X509_V_ERR_CRL_NOT_YET_VALID:
				case global::OpenSSL.VerifyResult.X509_V_ERR_CRL_HAS_EXPIRED:
				case global::OpenSSL.VerifyResult.X509_V_ERR_ERROR_IN_CRL_LAST_UPDATE_FIELD:
				case global::OpenSSL.VerifyResult.X509_V_ERR_ERROR_IN_CRL_NEXT_UPDATE_FIELD:
				case global::OpenSSL.VerifyResult.X509_V_ERR_OUT_OF_MEM:
					return flag;
				case global::OpenSSL.VerifyResult.X509_V_ERR_DEPTH_ZERO_SELF_SIGNED_CERT:
					flag = this.CheckCert(cert, chain);
					if (!flag)
					{
						throw new global::IACustomException.IACommonException(global::IACustomException.IACommonErrorCode.SSL_CE_CertificateNotSigned)
						{
							Source = text
						};
					}
					return flag;
				case global::OpenSSL.VerifyResult.X509_V_ERR_SELF_SIGNED_CERT_IN_CHAIN:
					flag = this.CheckCert(cert, chain);
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
			flag = this.CheckCert(cert, chain);
			if (!flag && depth != 0)
			{
				flag = true;
			}
			return flag;
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00006100 File Offset: 0x00004300
		public global::OpenSSL.X509.X509Certificate clientCertificateSelectionCallback(object sender, string targetHost, global::OpenSSL.X509.X509List localCerts, global::OpenSSL.X509.X509Certificate remoteCert, string[] acceptableIssuers)
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

		// Token: 0x060000FD RID: 253 RVA: 0x00006188 File Offset: 0x00004388
		public bool CheckCert(global::OpenSSL.X509.X509Certificate cert, global::OpenSSL.X509.X509Chain chain)
		{
			bool result = false;
			if (cert != null && chain != null)
			{
				foreach (global::OpenSSL.X509.X509Certificate x509Certificate in chain)
				{
					if (cert == x509Certificate)
					{
						result = true;
						break;
					}
				}
			}
			return result;
		}

		// Token: 0x0400007D RID: 125
		private static global::System.Net.Sockets.TcpClient client;

		// Token: 0x0400007E RID: 126
		private global::OpenSSL.SslStream sslStream;
	}
}
