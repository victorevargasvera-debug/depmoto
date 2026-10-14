using System;
using System.IO;
using System.Text;
using OpenSSL.Core;
using OpenSSL.Crypto;
using OpenSSL.X509;

namespace OpenSSL
{
	// Token: 0x02000071 RID: 113
	internal class SslStreamServer : global::OpenSSL.SslStreamBase
	{
		// Token: 0x060004CF RID: 1231 RVA: 0x000089E8 File Offset: 0x00006BE8
		public SslStreamServer(global::System.IO.Stream stream, bool ownStream, global::OpenSSL.X509.X509Certificate serverCertificate, bool clientCertificateRequired, global::OpenSSL.X509.X509Chain caCerts, global::OpenSSL.SslProtocols enabledSslProtocols, global::OpenSSL.SslStrength sslStrength, bool checkCertificateRevocation, global::OpenSSL.RemoteCertificateValidationHandler remote_callback, global::OpenSSL.Crypto.DH dh, string cipherlist) : base(stream, ownStream)
		{
			this.checkCertificateRevocationStatus = checkCertificateRevocation;
			this.remoteCertificateSelectionCallback = remote_callback;
			this.InitializeServerContext(serverCertificate, clientCertificateRequired, caCerts, enabledSslProtocols, sslStrength, checkCertificateRevocation, dh, cipherlist);
			this.ssl = new global::OpenSSL.Ssl(this.sslContext);
			this.read_bio = global::OpenSSL.Core.BIO.MemoryBuffer(false);
			this.write_bio = global::OpenSSL.Core.BIO.MemoryBuffer(false);
			this.ssl.SetBIO(this.read_bio, this.write_bio);
			this.read_bio.SetClose(global::OpenSSL.Core.BIO.CloseOption.Close);
			this.write_bio.SetClose(global::OpenSSL.Core.BIO.CloseOption.Close);
			this.ssl.SetAcceptState();
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x00008A88 File Offset: 0x00006C88
		protected internal override bool ProcessHandshake()
		{
			bool result = false;
			int num = 0;
			if (this.handShakeState == global::OpenSSL.HandshakeState.InProcess)
			{
				num = this.ssl.Accept();
			}
			else if (this.handShakeState == global::OpenSSL.HandshakeState.RenegotiateInProcess)
			{
				num = this.ssl.DoHandshake();
			}
			else if (this.handShakeState == global::OpenSSL.HandshakeState.Renegotiate)
			{
				num = this.ssl.DoHandshake();
				this.ssl.State = 8192;
				this.handShakeState = global::OpenSSL.HandshakeState.RenegotiateInProcess;
			}
			global::OpenSSL.SslError error = this.ssl.GetError(num);
			if (error == global::OpenSSL.SslError.SSL_ERROR_WANT_READ || error == global::OpenSSL.SslError.SSL_ERROR_WANT_WRITE || error == global::OpenSSL.SslError.SSL_ERROR_NONE)
			{
				if (num == 1)
				{
					result = true;
				}
			}
			else
			{
				if (this.write_bio.BytesPending <= 0U)
				{
					throw new global::OpenSSL.Core.OpenSslException();
				}
				this.handshakeException = new global::OpenSSL.Core.OpenSslException();
			}
			return result;
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x00008B38 File Offset: 0x00006D38
		private void InitializeServerContext(global::OpenSSL.X509.X509Certificate serverCertificate, bool clientCertificateRequired, global::OpenSSL.X509.X509Chain caCerts, global::OpenSSL.SslProtocols enabledSslProtocols, global::OpenSSL.SslStrength sslStrength, bool checkCertificateRevocation, global::OpenSSL.Crypto.DH dh, string cipherlist)
		{
			if (serverCertificate == null)
			{
				throw new global::System.ArgumentNullException("serverCertificate", "Server certificate cannot be null");
			}
			if (!serverCertificate.HasPrivateKey)
			{
				throw new global::System.ArgumentException("Server certificate must have a private key", "serverCertificate");
			}
			this.sslContext = new global::OpenSSL.SslContext(global::OpenSSL.SslMethod.SSLv23_server_method, dh);
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
			this.sslContext.Mode = global::OpenSSL.SslMode.SSL_MODE_AUTO_RETRY;
			this.sslContext.Options = global::OpenSSL.SslOptions.SSL_OP_ALL;
			if (clientCertificateRequired)
			{
				this.sslContext.SetVerify((global::OpenSSL.VerifyMode)3, this.remoteCertificateSelectionCallback);
			}
			else
			{
				this.sslContext.SetVerify(global::OpenSSL.VerifyMode.SSL_VERIFY_NONE, null);
			}
			this.sslContext.SetVerifyDepth(10);
			if (caCerts != null)
			{
				global::OpenSSL.X509.X509Store certificateStore = new global::OpenSSL.X509.X509Store(caCerts, false);
				this.sslContext.SetCertificateStore(certificateStore);
				global::OpenSSL.Core.Stack<global::OpenSSL.X509.X509Name> stack = new global::OpenSSL.Core.Stack<global::OpenSSL.X509.X509Name>();
				foreach (global::OpenSSL.X509.X509Certificate x509Certificate in caCerts)
				{
					global::OpenSSL.X509.X509Name subject = x509Certificate.Subject;
					stack.Add(subject);
				}
				this.sslContext.CAList = stack;
			}
			if (cipherlist != null)
			{
				this.sslContext.SetCipherList(cipherlist);
			}
			else
			{
				this.sslContext.SetCipherList(base.GetCipherString(false, enabledSslProtocols, sslStrength));
			}
			this.sslContext.UseCertificate(serverCertificate);
			this.sslContext.UsePrivateKey(serverCertificate.PrivateKey);
			this.sslContext.SetSessionIdContext(global::System.Text.Encoding.ASCII.GetBytes(global::System.AppDomain.CurrentDomain.FriendlyName));
		}
	}
}
