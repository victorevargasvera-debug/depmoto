using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Security;
using OpenSSL.Core;
using OpenSSL.Crypto;
using OpenSSL.X509;

namespace OpenSSL
{
	// Token: 0x0200006F RID: 111
	public class SslStream : global::System.Net.Security.AuthenticatedStream
	{
		// Token: 0x06000497 RID: 1175 RVA: 0x000084B8 File Offset: 0x000066B8
		public SslStream(global::System.IO.Stream stream) : this(stream, false)
		{
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x000084C2 File Offset: 0x000066C2
		public SslStream(global::System.IO.Stream stream, bool leaveInnerStreamOpen)
		{
			this.dhParams = new global::System.Collections.Generic.Dictionary<int, global::OpenSSL.Core.BIO>();
			base..ctor(stream, leaveInnerStreamOpen);
			this.remoteCertificateValidationCallback = null;
			this.localCertificateSelectionCallback = null;
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x000084E5 File Offset: 0x000066E5
		public SslStream(global::System.IO.Stream stream, bool leaveInnerStreamOpen, global::OpenSSL.RemoteCertificateValidationHandler remote_callback) : this(stream, leaveInnerStreamOpen, remote_callback, null)
		{
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x000084F1 File Offset: 0x000066F1
		public SslStream(global::System.IO.Stream stream, bool leaveInnerStreamOpen, global::OpenSSL.RemoteCertificateValidationHandler remote_callback, global::OpenSSL.LocalCertificateSelectionHandler local_callback)
		{
			this.dhParams = new global::System.Collections.Generic.Dictionary<int, global::OpenSSL.Core.BIO>();
			base..ctor(stream, leaveInnerStreamOpen);
			this.remoteCertificateValidationCallback = remote_callback;
			this.localCertificateSelectionCallback = local_callback;
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x0600049B RID: 1179 RVA: 0x00008515 File Offset: 0x00006715
		public override bool IsAuthenticated
		{
			get
			{
				return this.sslStream != null;
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x0600049C RID: 1180 RVA: 0x00008523 File Offset: 0x00006723
		public override bool IsEncrypted
		{
			get
			{
				return this.IsAuthenticated;
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x0600049D RID: 1181 RVA: 0x0000852B File Offset: 0x0000672B
		public override bool IsMutuallyAuthenticated
		{
			get
			{
				return this.IsAuthenticated && (this.IsServer ? (this.sslStream.RemoteCertificate != null) : (this.sslStream.LocalCertificate != null));
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x0600049E RID: 1182 RVA: 0x00008566 File Offset: 0x00006766
		public override bool IsServer
		{
			get
			{
				return this.sslStream is global::OpenSSL.SslStreamServer;
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x0600049F RID: 1183 RVA: 0x00008576 File Offset: 0x00006776
		public override bool IsSigned
		{
			get
			{
				return this.IsAuthenticated;
			}
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x0000857E File Offset: 0x0000677E
		public void SetCipherList(string list)
		{
			this.cipherList = list;
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060004A1 RID: 1185 RVA: 0x00008587 File Offset: 0x00006787
		public override bool CanRead
		{
			get
			{
				return base.InnerStream.CanRead;
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060004A2 RID: 1186 RVA: 0x00008594 File Offset: 0x00006794
		public override bool CanSeek
		{
			get
			{
				return base.InnerStream.CanSeek;
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060004A3 RID: 1187 RVA: 0x000085A1 File Offset: 0x000067A1
		public override bool CanWrite
		{
			get
			{
				return base.InnerStream.CanWrite;
			}
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x000085AE File Offset: 0x000067AE
		public override void Flush()
		{
			base.InnerStream.Flush();
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060004A5 RID: 1189 RVA: 0x000085BB File Offset: 0x000067BB
		public override long Length
		{
			get
			{
				return base.InnerStream.Length;
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060004A6 RID: 1190 RVA: 0x000085C8 File Offset: 0x000067C8
		// (set) Token: 0x060004A7 RID: 1191 RVA: 0x000085D5 File Offset: 0x000067D5
		public override long Position
		{
			get
			{
				return base.InnerStream.Position;
			}
			set
			{
				throw new global::System.NotSupportedException();
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060004A8 RID: 1192 RVA: 0x000085DC File Offset: 0x000067DC
		// (set) Token: 0x060004A9 RID: 1193 RVA: 0x000085E9 File Offset: 0x000067E9
		public override int ReadTimeout
		{
			get
			{
				return base.InnerStream.ReadTimeout;
			}
			set
			{
				base.InnerStream.ReadTimeout = value;
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060004AA RID: 1194 RVA: 0x000085F7 File Offset: 0x000067F7
		// (set) Token: 0x060004AB RID: 1195 RVA: 0x00008604 File Offset: 0x00006804
		public override int WriteTimeout
		{
			get
			{
				return base.InnerStream.WriteTimeout;
			}
			set
			{
				base.InnerStream.WriteTimeout = value;
			}
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x00008612 File Offset: 0x00006812
		public override int Read(byte[] buffer, int offset, int count)
		{
			return this.EndRead(this.BeginRead(buffer, offset, count, null, null));
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x00008625 File Offset: 0x00006825
		public override global::System.IAsyncResult BeginRead(byte[] buffer, int offset, int count, global::System.AsyncCallback asyncCallback, object asyncState)
		{
			this.TestConnectionIsValid();
			return this.sslStream.BeginRead(buffer, offset, count, asyncCallback, asyncState);
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x0000863F File Offset: 0x0000683F
		public override int EndRead(global::System.IAsyncResult asyncResult)
		{
			this.TestConnectionIsValid();
			return this.sslStream.EndRead(asyncResult);
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x00008653 File Offset: 0x00006853
		public override long Seek(long offset, global::System.IO.SeekOrigin origin)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x0000865A File Offset: 0x0000685A
		public override void SetLength(long value)
		{
			base.InnerStream.SetLength(value);
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x00008668 File Offset: 0x00006868
		public override void Write(byte[] buffer, int offset, int count)
		{
			this.TestConnectionIsValid();
			this.EndWrite(this.BeginWrite(buffer, offset, count, null, null));
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x00008681 File Offset: 0x00006881
		public override global::System.IAsyncResult BeginWrite(byte[] buffer, int offset, int count, global::System.AsyncCallback asyncCallback, object asyncState)
		{
			this.TestConnectionIsValid();
			return this.sslStream.BeginWrite(buffer, offset, count, asyncCallback, asyncState);
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x0000869B File Offset: 0x0000689B
		public override void EndWrite(global::System.IAsyncResult asyncResult)
		{
			this.TestConnectionIsValid();
			this.sslStream.EndWrite(asyncResult);
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x000086AF File Offset: 0x000068AF
		public override void Close()
		{
			this.TestConnectionIsValid();
			base.Close();
			this.sslStream.Close();
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060004B5 RID: 1205 RVA: 0x000086C8 File Offset: 0x000068C8
		public bool CheckCertificateRevocationStatus
		{
			get
			{
				return this.IsAuthenticated && this.sslStream.CheckCertificateRevocationStatus;
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060004B6 RID: 1206 RVA: 0x000086DF File Offset: 0x000068DF
		public global::OpenSSL.CipherAlgorithmType CipherAlgorithm
		{
			get
			{
				if (!this.IsAuthenticated)
				{
					return global::OpenSSL.CipherAlgorithmType.None;
				}
				return this.sslStream.CipherAlgorithm;
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060004B7 RID: 1207 RVA: 0x000086F6 File Offset: 0x000068F6
		public int CipherStrength
		{
			get
			{
				if (!this.IsAuthenticated)
				{
					return 0;
				}
				return this.sslStream.CipherStrength;
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060004B8 RID: 1208 RVA: 0x0000870D File Offset: 0x0000690D
		public global::OpenSSL.HashAlgorithmType HashAlgorithm
		{
			get
			{
				if (!this.IsAuthenticated)
				{
					return global::OpenSSL.HashAlgorithmType.None;
				}
				return this.sslStream.HashAlgorithm;
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060004B9 RID: 1209 RVA: 0x00008724 File Offset: 0x00006924
		public int HashStrength
		{
			get
			{
				if (!this.IsAuthenticated)
				{
					return 0;
				}
				return this.sslStream.HashStrength;
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060004BA RID: 1210 RVA: 0x0000873B File Offset: 0x0000693B
		public global::OpenSSL.ExchangeAlgorithmType KeyExchangeAlgorithm
		{
			get
			{
				if (!this.IsAuthenticated)
				{
					return global::OpenSSL.ExchangeAlgorithmType.None;
				}
				return this.sslStream.KeyExchangeAlgorithm;
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060004BB RID: 1211 RVA: 0x00008752 File Offset: 0x00006952
		public int KeyExchangeStrength
		{
			get
			{
				if (!this.IsAuthenticated)
				{
					return 0;
				}
				return this.sslStream.KeyExchangeStrength;
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060004BC RID: 1212 RVA: 0x00008769 File Offset: 0x00006969
		public global::OpenSSL.X509.X509Certificate LocalCertificate
		{
			get
			{
				if (!this.IsAuthenticated)
				{
					return null;
				}
				return this.sslStream.LocalCertificate;
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060004BD RID: 1213 RVA: 0x00008780 File Offset: 0x00006980
		public virtual global::OpenSSL.X509.X509Certificate RemoteCertificate
		{
			get
			{
				if (!this.IsAuthenticated)
				{
					return null;
				}
				return this.sslStream.RemoteCertificate;
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060004BE RID: 1214 RVA: 0x00008797 File Offset: 0x00006997
		public global::OpenSSL.SslProtocols SslProtocol
		{
			get
			{
				if (!this.IsAuthenticated)
				{
					return global::OpenSSL.SslProtocols.None;
				}
				return this.sslStream.SslProtocol;
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060004BF RID: 1215 RVA: 0x000087AE File Offset: 0x000069AE
		public global::System.Collections.Generic.List<string> CipherList
		{
			get
			{
				return this.sslStream.CipherList;
			}
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x000087BB File Offset: 0x000069BB
		public virtual void AuthenticateAsClient(string targetHost)
		{
			this.AuthenticateAsClient(targetHost, null, null, global::OpenSSL.SslProtocols.Default, global::OpenSSL.SslStrength.Medium, false);
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x000087CC File Offset: 0x000069CC
		public virtual void AuthenticateAsClient(string targetHost, global::OpenSSL.X509.X509List certificates, global::OpenSSL.X509.X509Chain caCertificates, global::OpenSSL.SslProtocols enabledSslProtocols, global::OpenSSL.SslStrength sslStrength, bool checkCertificateRevocation)
		{
			this.EndAuthenticateAsClient(this.BeginAuthenticateAsClient(targetHost, certificates, caCertificates, enabledSslProtocols, sslStrength, checkCertificateRevocation, null, null));
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x000087F0 File Offset: 0x000069F0
		public virtual global::System.IAsyncResult BeginAuthenticateAsClient(string targetHost, global::System.AsyncCallback asyncCallback, object asyncState)
		{
			return this.BeginAuthenticateAsClient(targetHost, null, null, global::OpenSSL.SslProtocols.Default, global::OpenSSL.SslStrength.Medium, false, asyncCallback, asyncState);
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x0000880C File Offset: 0x00006A0C
		public virtual global::System.IAsyncResult BeginAuthenticateAsClient(string targetHost, global::OpenSSL.X509.X509List clientCertificates, global::OpenSSL.X509.X509Chain caCertificates, global::OpenSSL.SslProtocols enabledSslProtocols, global::OpenSSL.SslStrength sslStrength, bool checkCertificateRevocation, global::System.AsyncCallback asyncCallback, object asyncState)
		{
			if (this.IsAuthenticated)
			{
				throw new global::System.InvalidOperationException("SslStream is already authenticated");
			}
			global::OpenSSL.SslStreamClient sslStreamClient = new global::OpenSSL.SslStreamClient(base.InnerStream, false, targetHost, clientCertificates, caCertificates, enabledSslProtocols, sslStrength, checkCertificateRevocation, this.remoteCertificateValidationCallback, this.localCertificateSelectionCallback, this.cipherList);
			this.sslStream = sslStreamClient;
			return this.BeginWrite(new byte[0], 0, 0, asyncCallback, asyncState);
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x0000886D File Offset: 0x00006A6D
		public virtual void EndAuthenticateAsClient(global::System.IAsyncResult ar)
		{
			this.TestConnectionIsValid();
			this.EndWrite(ar);
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x0000887C File Offset: 0x00006A7C
		public virtual void AuthenticateAsServer(global::OpenSSL.X509.X509Certificate serverCertificate)
		{
			this.AuthenticateAsServer(serverCertificate, false, null, global::OpenSSL.SslProtocols.Default, global::OpenSSL.SslStrength.Medium, false, null);
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x0000888C File Offset: 0x00006A8C
		public virtual void AuthenticateAsServer(global::OpenSSL.X509.X509Certificate serverCertificate, bool clientCertificateRequired, global::OpenSSL.X509.X509Chain caCertificates, global::OpenSSL.SslProtocols enabledSslProtocols, global::OpenSSL.SslStrength sslStrength, bool checkCertificateRevocation, global::OpenSSL.Crypto.DH dh)
		{
			this.EndAuthenticateAsServer(this.BeginAuthenticateAsServer(serverCertificate, clientCertificateRequired, caCertificates, enabledSslProtocols, sslStrength, checkCertificateRevocation, null, null, dh));
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x000088B4 File Offset: 0x00006AB4
		public virtual global::System.IAsyncResult BeginAuthenticateAsServer(global::OpenSSL.X509.X509Certificate serverCertificate, global::System.AsyncCallback asyncCallback, object asyncState)
		{
			return this.BeginAuthenticateAsServer(serverCertificate, false, null, global::OpenSSL.SslProtocols.Default, global::OpenSSL.SslStrength.Medium, false, asyncCallback, asyncState, null);
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x000088D4 File Offset: 0x00006AD4
		public virtual global::System.IAsyncResult BeginAuthenticateAsServer(global::OpenSSL.X509.X509Certificate serverCertificate, bool clientCertificateRequired, global::OpenSSL.X509.X509Chain caCerts, global::OpenSSL.SslProtocols enabledSslProtocols, global::OpenSSL.SslStrength sslStrength, bool checkCertificateRevocation, global::System.AsyncCallback asyncCallback, object asyncState, global::OpenSSL.Crypto.DH dh)
		{
			if (this.IsAuthenticated)
			{
				throw new global::System.InvalidOperationException("SslStream is already authenticated");
			}
			global::OpenSSL.SslStreamServer sslStreamServer = new global::OpenSSL.SslStreamServer(base.InnerStream, false, serverCertificate, clientCertificateRequired, caCerts, enabledSslProtocols, sslStrength, checkCertificateRevocation, this.remoteCertificateValidationCallback, dh, this.cipherList);
			this.sslStream = sslStreamServer;
			return this.BeginRead(new byte[0], 0, 0, asyncCallback, asyncState);
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x00008931 File Offset: 0x00006B31
		public virtual void EndAuthenticateAsServer(global::System.IAsyncResult ar)
		{
			this.TestConnectionIsValid();
			this.EndRead(ar);
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x00008941 File Offset: 0x00006B41
		public void Renegotiate()
		{
			this.TestConnectionIsValid();
			this.EndRenegotiate(this.BeginRenegotiate(null, null));
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x00008958 File Offset: 0x00006B58
		public global::System.IAsyncResult BeginRenegotiate(global::System.AsyncCallback callback, object state)
		{
			this.TestConnectionIsValid();
			this.sslStream.Renegotiate();
			if (this.sslStream is global::OpenSSL.SslStreamClient)
			{
				return this.BeginWrite(new byte[0], 0, 0, callback, state);
			}
			return this.BeginRead(new byte[0], 0, 0, callback, state);
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x000089A4 File Offset: 0x00006BA4
		public void EndRenegotiate(global::System.IAsyncResult asyncResult)
		{
			this.TestConnectionIsValid();
			if (this.sslStream is global::OpenSSL.SslStreamClient)
			{
				this.EndWrite(asyncResult);
				return;
			}
			this.EndRead(asyncResult);
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x000089C9 File Offset: 0x00006BC9
		private void TestConnectionIsValid()
		{
			if (this.sslStream == null)
			{
				throw new global::System.InvalidOperationException("SslStream has not been authenticated");
			}
		}

		// Token: 0x040003AC RID: 940
		private global::System.Collections.Generic.Dictionary<int, global::OpenSSL.Core.BIO> dhParams;

		// Token: 0x040003AD RID: 941
		private string cipherList;

		// Token: 0x040003AE RID: 942
		private global::OpenSSL.SslStreamBase sslStream;

		// Token: 0x040003AF RID: 943
		internal global::OpenSSL.RemoteCertificateValidationHandler remoteCertificateValidationCallback;

		// Token: 0x040003B0 RID: 944
		internal global::OpenSSL.LocalCertificateSelectionHandler localCertificateSelectionCallback;

		// Token: 0x040003B1 RID: 945
		internal bool m_bCheckCertRevocationStatus;
	}
}
