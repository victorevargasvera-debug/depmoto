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
	// Token: 0x0200000F RID: 15
	internal class TLSClientWatcher : global::SSLMangrComp.Connectors.IClientWatcher
	{
		// Token: 0x06000069 RID: 105 RVA: 0x00003924 File Offset: 0x00001B24
		public void Connect(global::SSLMangrComp.PNConnectionInfo connInfo)
		{
			global::System.Net.IPAddress pnIp = connInfo.PNConnectionConfig.PnIp;
			int pnPort = connInfo.PNConnectionConfig.PnPort;
			this.clientConfig = connInfo.TLSClientConfig;
			if (this.sslStream != null)
			{
				return;
			}
			try
			{
				global::OpenSSL.X509.X509Certificate x509Certificate = null;
				global::OpenSSL.X509.X509List x509List = new global::OpenSSL.X509.X509List();
				if (this.clientConfig.CACertificate != null && this.clientConfig.CACertificate != string.Empty)
				{
					x509Certificate = global::OpenSSL.X509.X509Certificate.FromDER(new global::OpenSSL.Core.BIO(global::System.Convert.FromBase64String(this.clientConfig.CACertificate)));
				}
				if (this.clientConfig.ClientCertificate != null && this.clientConfig.ClientKeyPassphrase != null && this.clientConfig.ClientCertificate != string.Empty && this.clientConfig.ClientKeyPassphrase != string.Empty)
				{
					global::OpenSSL.X509.X509Certificate item = global::OpenSSL.X509.X509Certificate.FromPKCS12(new global::OpenSSL.Core.BIO(global::System.Convert.FromBase64String(this.clientConfig.ClientCertificate)), this.clientConfig.ClientKeyPassphrase);
					x509List.Add(item);
				}
				global::SSLMangrComp.ConnectionLayer.TLSClientWatcher.client = new global::System.Net.Sockets.TcpClient(pnIp.ToString(), pnPort);
				this.sslStream = new global::OpenSSL.SslStream(global::SSLMangrComp.ConnectionLayer.TLSClientWatcher.client.GetStream(), false, new global::OpenSSL.RemoteCertificateValidationHandler(this.ValidateRemoteCert), new global::OpenSSL.LocalCertificateSelectionHandler(this.clientCertificateSelectionCallback));
				this.sslStream.SetCipherList(this.clientConfig.CipherSuites);
				this.sslStream.AuthenticateAsClient(pnIp.ToString(), x509List, new global::OpenSSL.X509.X509Chain(x509Certificate.PEM), global::OpenSSL.SslProtocols.Tls, global::OpenSSL.SslStrength.All, false);
				if (!this.sslStream.IsMutuallyAuthenticated)
				{
					this.ShutdownClient();
					global::IACustomException.IACommonException ex = new global::IACustomException.IACommonException(global::IACustomException.IACommonErrorCode.SSL_PE_MutualAuthenticationFail);
					throw ex;
				}
				if (this.sslStream.SslProtocol != global::OpenSSL.SslProtocols.Tls)
				{
					this.ShutdownClient();
					global::IACustomException.IACommonException ex2 = new global::IACustomException.IACommonException(global::IACustomException.IACommonErrorCode.SSL_PE_TLSProtocolFailed);
					throw ex2;
				}
				if (this.sslStream.CipherStrength < 256)
				{
					this.ShutdownClient();
					global::IACustomException.IACommonException ex3 = new global::IACustomException.IACommonException(global::IACustomException.IACommonErrorCode.SSL_PE_CipherStrengthFail);
					throw ex3;
				}
				if (this.sslStream.CipherAlgorithm != global::OpenSSL.CipherAlgorithmType.Aes256)
				{
					this.ShutdownClient();
					global::IACustomException.IACommonException ex4 = new global::IACustomException.IACommonException(global::IACustomException.IACommonErrorCode.SSL_PE_AESCipherFail);
					throw ex4;
				}
			}
			catch (global::IACustomException.IACommonException ex5)
			{
				throw ex5;
			}
			catch (global::System.Exception systemException)
			{
				this.ShutdownClient();
				throw new global::IACustomException.IACommonException(global::IACustomException.IACommonErrorCode.SSL_LE_UnableToOpenSocket, systemException);
			}
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00003B74 File Offset: 0x00001D74
		public void ShutdownClient()
		{
			try
			{
				if (this.sslStream != null)
				{
					this.sslStream = null;
				}
				if (global::SSLMangrComp.ConnectionLayer.TLSClientWatcher.client != null)
				{
					global::SSLMangrComp.ConnectionLayer.TLSClientWatcher.client.Close();
				}
			}
			catch
			{
			}
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00003BB8 File Offset: 0x00001DB8
		public void WriteData(byte[] dataToWrite)
		{
			if (this.sslStream != null)
			{
				try
				{
					this.sslStream.Write(dataToWrite, 0, dataToWrite.Length);
					return;
				}
				catch (global::System.Exception systemException)
				{
					throw new global::IACustomException.IACommonException(global::IACustomException.IACommonErrorCode.SSL_PE_UDPDataSendFail, systemException);
				}
			}
			throw new global::IACustomException.IACommonException(global::IACustomException.IACommonErrorCode.SSL_PE_UDPDataSendFail);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00003C08 File Offset: 0x00001E08
		public bool ValidateRemoteCert(object obj, global::OpenSSL.X509.X509Certificate cert, global::OpenSSL.X509.X509Chain chain, int depth, global::OpenSSL.VerifyResult result)
		{
			bool flag = false;
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
				{
					global::IACustomException.IACommonException ex = new global::IACustomException.IACommonException(global::IACustomException.IACommonErrorCode.SSL_CE_CertificateNotYetActive);
					throw ex;
				}
				case global::OpenSSL.VerifyResult.X509_V_ERR_CERT_HAS_EXPIRED:
				case global::OpenSSL.VerifyResult.X509_V_ERR_ERROR_IN_CERT_NOT_AFTER_FIELD:
				{
					global::IACustomException.IACommonException ex2 = new global::IACustomException.IACommonException(global::IACustomException.IACommonErrorCode.SSL_CE_CertificateExpired);
					throw ex2;
				}
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
						global::IACustomException.IACommonException ex3 = new global::IACustomException.IACommonException(global::IACustomException.IACommonErrorCode.SSL_CE_CertificateNotSigned);
						throw ex3;
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

		// Token: 0x0600006D RID: 109 RVA: 0x00003CD4 File Offset: 0x00001ED4
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

		// Token: 0x0600006E RID: 110 RVA: 0x00003D5C File Offset: 0x00001F5C
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

		// Token: 0x04000034 RID: 52
		private static global::System.Net.Sockets.TcpClient client;

		// Token: 0x04000035 RID: 53
		private global::OpenSSL.SslStream sslStream;

		// Token: 0x04000036 RID: 54
		private global::SSLMangrComp.SecureClientConfiguration clientConfig;
	}
}
