using System;
using System.IO;
using OpenSSL.Core;
using OpenSSL.Crypto;
using OpenSSL.X509;

namespace OpenSSL
{
	// Token: 0x02000067 RID: 103
	internal class SslStreamClient : global::OpenSSL.SslStreamBase
	{
		// Token: 0x0600046A RID: 1130 RVA: 0x00007D00 File Offset: 0x00005F00
		public SslStreamClient(global::System.IO.Stream stream, bool ownStream, string targetHost, global::OpenSSL.X509.X509List clientCertificates, global::OpenSSL.X509.X509Chain caCertificates, global::OpenSSL.SslProtocols enabledSslProtocols, global::OpenSSL.SslStrength sslStrength, bool checkCertificateRevocation, global::OpenSSL.RemoteCertificateValidationHandler remoteCallback, global::OpenSSL.LocalCertificateSelectionHandler localCallback, string cipherlist) : base(stream, ownStream)
		{
			this.targetHost = targetHost;
			this.clientCertificates = clientCertificates;
			this.caCertificates = caCertificates;
			this.checkCertificateRevocationStatus = this.checkCertificateRevocationStatus;
			this.remoteCertificateSelectionCallback = remoteCallback;
			this.localCertificateSelectionCallback = localCallback;
			this.internalCertificateSelectionCallback = new global::OpenSSL.ClientCertCallbackHandler(this.InternalClientCertificateSelectionCallback);
			this.InitializeClientContext(clientCertificates, enabledSslProtocols, sslStrength, checkCertificateRevocation, cipherlist);
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x00007D6C File Offset: 0x00005F6C
		protected void InitializeClientContext(global::OpenSSL.X509.X509List certificates, global::OpenSSL.SslProtocols enabledSslProtocols, global::OpenSSL.SslStrength sslStrength, bool checkCertificateRevocation, string cipherlist)
		{
			this.sslContext = new global::OpenSSL.SslContext(global::OpenSSL.SslMethod.SSLv23_client_method, null);
			if ((enabledSslProtocols & global::OpenSSL.SslProtocols.Ssl2) != global::OpenSSL.SslProtocols.Ssl2)
			{
				this.sslContext.Options |= global::OpenSSL.SslOptions.SSL_OP_NO_SSLv2;
			}
			if ((enabledSslProtocols & global::OpenSSL.SslProtocols.Ssl3) != global::OpenSSL.SslProtocols.Ssl3 && (enabledSslProtocols & global::OpenSSL.SslProtocols.Default) != global::OpenSSL.SslProtocols.Default)
			{
				this.sslContext.Options |= global::OpenSSL.SslOptions.SSL_OP_NO_SSLv3;
			}
			if ((enabledSslProtocols & global::OpenSSL.SslProtocols.Tls) != global::OpenSSL.SslProtocols.Tls && (enabledSslProtocols & global::OpenSSL.SslProtocols.Default) != global::OpenSSL.SslProtocols.Default)
			{
				this.sslContext.Options |= global::OpenSSL.SslOptions.SSL_OP_NO_TLSv1;
			}
			this.sslContext.Options |= global::OpenSSL.SslOptions.SSL_OP_ALLOW_UNSAFE_LEGACY_RENEGOTIATION;
			this.sslContext.Options |= global::OpenSSL.SslOptions.SSL_OP_NO_TICKET;
			this.sslContext.SetClientCertCallback(this.internalCertificateSelectionCallback);
			if (cipherlist != null)
			{
				this.sslContext.SetCipherList(cipherlist);
			}
			else
			{
				this.sslContext.SetCipherList(base.GetCipherString(false, enabledSslProtocols, sslStrength));
			}
			if (this.remoteCertificateSelectionCallback != null)
			{
				this.sslContext.SetVerify((global::OpenSSL.VerifyMode)3, this.remoteCertificateSelectionCallback);
			}
			if (this.caCertificates != null)
			{
				global::OpenSSL.X509.X509Store certificateStore = new global::OpenSSL.X509.X509Store(this.caCertificates);
				this.sslContext.SetCertificateStore(certificateStore);
			}
			this.read_bio = global::OpenSSL.Core.BIO.MemoryBuffer(false);
			this.write_bio = global::OpenSSL.Core.BIO.MemoryBuffer(false);
			this.ssl = new global::OpenSSL.Ssl(this.sslContext);
			this.ssl.SetBIO(this.read_bio, this.write_bio);
			this.read_bio.SetClose(global::OpenSSL.Core.BIO.CloseOption.Close);
			this.write_bio.SetClose(global::OpenSSL.Core.BIO.CloseOption.Close);
			this.ssl.SetConnectState();
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x00007EF8 File Offset: 0x000060F8
		protected internal override bool ProcessHandshake()
		{
			bool result = false;
			int num = 0;
			if (this.handShakeState == global::OpenSSL.HandshakeState.InProcess)
			{
				num = this.ssl.Connect();
			}
			else if (this.handShakeState == global::OpenSSL.HandshakeState.RenegotiateInProcess || this.handShakeState == global::OpenSSL.HandshakeState.Renegotiate)
			{
				this.handShakeState = global::OpenSSL.HandshakeState.RenegotiateInProcess;
				num = this.ssl.DoHandshake();
			}
			if (num <= 0)
			{
				global::OpenSSL.SslError error = this.ssl.GetError(num);
				if (error != global::OpenSSL.SslError.SSL_ERROR_WANT_READ && error != global::OpenSSL.SslError.SSL_ERROR_WANT_WRITE)
				{
					if (this.write_bio.BytesPending <= 0U)
					{
						throw new global::OpenSSL.Core.OpenSslException();
					}
					this.handshakeException = new global::OpenSSL.Core.OpenSslException();
				}
			}
			else
			{
				result = true;
			}
			return result;
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x00007F84 File Offset: 0x00006184
		public int InternalClientCertificateSelectionCallback(global::OpenSSL.Ssl ssl, out global::OpenSSL.X509.X509Certificate x509_cert, out global::OpenSSL.Crypto.CryptoKey key)
		{
			int result = 0;
			x509_cert = null;
			key = null;
			global::OpenSSL.Core.Stack<global::OpenSSL.X509.X509Name> calist = ssl.CAList;
			string[] array = new string[calist.Count];
			int num = 0;
			foreach (global::OpenSSL.X509.X509Name x509Name in calist)
			{
				array[num++] = x509Name.OneLine;
			}
			if (this.localCertificateSelectionCallback != null)
			{
				global::OpenSSL.X509.X509Certificate x509Certificate = this.localCertificateSelectionCallback(this, this.targetHost, this.clientCertificates, ssl.GetPeerCertificate(), array);
				if (x509Certificate != null && x509Certificate.HasPrivateKey)
				{
					x509_cert = x509Certificate;
					key = x509Certificate.PrivateKey;
					x509_cert.AddRef();
					key.AddRef();
					result = 1;
				}
			}
			return result;
		}

		// Token: 0x04000352 RID: 850
		private string targetHost;

		// Token: 0x04000353 RID: 851
		private global::OpenSSL.X509.X509List clientCertificates;

		// Token: 0x04000354 RID: 852
		private global::OpenSSL.X509.X509Chain caCertificates;

		// Token: 0x04000355 RID: 853
		protected global::OpenSSL.ClientCertCallbackHandler internalCertificateSelectionCallback;
	}
}
