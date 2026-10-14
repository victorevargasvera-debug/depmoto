using System;
using System.Runtime.InteropServices;
using OpenSSL.Core;
using OpenSSL.Crypto;

namespace OpenSSL.X509
{
	// Token: 0x02000078 RID: 120
	public class X509Certificate : global::OpenSSL.Core.BaseCopyableRef<global::OpenSSL.X509.X509Certificate>, global::System.IComparable<global::OpenSSL.X509.X509Certificate>, global::OpenSSL.Core.IStackable
	{
		// Token: 0x060004F8 RID: 1272 RVA: 0x000091F1 File Offset: 0x000073F1
		internal X509Certificate(global::OpenSSL.Core.IStack stack, global::System.IntPtr ptr) : base(ptr, true)
		{
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x000091FB File Offset: 0x000073FB
		internal X509Certificate(global::System.IntPtr ptr, bool owner) : base(ptr, owner)
		{
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x00009205 File Offset: 0x00007405
		public X509Certificate() : base(global::OpenSSL.Core.Native.ExpectNonNull(global::OpenSSL.Core.Native.X509_new()), true)
		{
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x00009218 File Offset: 0x00007418
		public X509Certificate(global::OpenSSL.Core.BIO bio) : base(global::OpenSSL.Core.Native.ExpectNonNull(global::OpenSSL.Core.Native.PEM_read_bio_X509(bio.Handle, global::System.IntPtr.Zero, null, global::System.IntPtr.Zero)), true)
		{
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x0000923C File Offset: 0x0000743C
		public static global::OpenSSL.X509.X509Certificate FromDER(global::OpenSSL.Core.BIO bio)
		{
			global::System.IntPtr zero = global::System.IntPtr.Zero;
			global::System.IntPtr ptr = global::OpenSSL.Core.Native.ExpectNonNull(global::OpenSSL.Core.Native.d2i_X509_bio(bio.Handle, ref zero));
			return new global::OpenSSL.X509.X509Certificate(ptr, true);
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x0000926C File Offset: 0x0000746C
		public static global::OpenSSL.X509.X509Certificate FromPKCS7_PEM(global::OpenSSL.Core.BIO bio)
		{
			global::OpenSSL.X509.PKCS7 pkcs = global::OpenSSL.X509.PKCS7.FromPEM(bio);
			global::OpenSSL.X509.X509Chain certificates = pkcs.Certificates;
			if (certificates != null && certificates.Count > 0)
			{
				return new global::OpenSSL.X509.X509Certificate(certificates[0].Handle, false);
			}
			throw new global::OpenSSL.Core.OpenSslException();
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x000092AC File Offset: 0x000074AC
		public static global::OpenSSL.X509.X509Certificate FromPKCS7_DER(global::OpenSSL.Core.BIO bio)
		{
			global::OpenSSL.X509.PKCS7 pkcs = global::OpenSSL.X509.PKCS7.FromDER(bio);
			global::OpenSSL.X509.X509Chain certificates = pkcs.Certificates;
			if (certificates != null && certificates.Count > 0)
			{
				return new global::OpenSSL.X509.X509Certificate(certificates[0].Handle, false);
			}
			return null;
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x000092E8 File Offset: 0x000074E8
		public static global::OpenSSL.X509.X509Certificate FromPKCS12(global::OpenSSL.Core.BIO bio, string password)
		{
			global::OpenSSL.X509.X509Certificate certificate;
			using (global::OpenSSL.X509.PKCS12 pkcs = new global::OpenSSL.X509.PKCS12(bio, password))
			{
				certificate = pkcs.Certificate;
			}
			return certificate;
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x00009324 File Offset: 0x00007524
		public X509Certificate(int serial, global::OpenSSL.X509.X509Name subject, global::OpenSSL.X509.X509Name issuer, global::OpenSSL.Crypto.CryptoKey pubkey, global::System.DateTime start, global::System.DateTime end) : this()
		{
			this.Version = 2;
			this.SerialNumber = serial;
			this.Subject = subject;
			this.Issuer = issuer;
			this.PublicKey = pubkey;
			this.NotBefore = start;
			this.NotAfter = end;
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x06000501 RID: 1281 RVA: 0x00009360 File Offset: 0x00007560
		private global::OpenSSL.X509.X509Certificate.X509 Raw
		{
			get
			{
				return (global::OpenSSL.X509.X509Certificate.X509)global::System.Runtime.InteropServices.Marshal.PtrToStructure(this.ptr, typeof(global::OpenSSL.X509.X509Certificate.X509));
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x06000502 RID: 1282 RVA: 0x0000937C File Offset: 0x0000757C
		private global::OpenSSL.X509.X509Certificate.X509_CINF RawCertInfo
		{
			get
			{
				return (global::OpenSSL.X509.X509Certificate.X509_CINF)global::System.Runtime.InteropServices.Marshal.PtrToStructure(this.Raw.cert_info, typeof(global::OpenSSL.X509.X509Certificate.X509_CINF));
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000503 RID: 1283 RVA: 0x0000939D File Offset: 0x0000759D
		private global::OpenSSL.X509.X509Certificate.X509_VAL RawValidity
		{
			get
			{
				return (global::OpenSSL.X509.X509Certificate.X509_VAL)global::System.Runtime.InteropServices.Marshal.PtrToStructure(this.RawCertInfo.validity, typeof(global::OpenSSL.X509.X509Certificate.X509_VAL));
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x06000504 RID: 1284 RVA: 0x000093C0 File Offset: 0x000075C0
		// (set) Token: 0x06000505 RID: 1285 RVA: 0x000093ED File Offset: 0x000075ED
		public global::OpenSSL.X509.X509Name Subject
		{
			get
			{
				global::System.IntPtr ptr = global::OpenSSL.Core.Native.ExpectNonNull(global::OpenSSL.Core.Native.X509_get_subject_name(this.ptr));
				global::OpenSSL.X509.X509Name x509Name = new global::OpenSSL.X509.X509Name(ptr, true);
				x509Name.AddRef();
				return x509Name;
			}
			set
			{
				global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.X509_set_subject_name(this.ptr, value.Handle));
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x06000506 RID: 1286 RVA: 0x00009408 File Offset: 0x00007608
		// (set) Token: 0x06000507 RID: 1287 RVA: 0x00009435 File Offset: 0x00007635
		public global::OpenSSL.X509.X509Name Issuer
		{
			get
			{
				global::System.IntPtr ptr = global::OpenSSL.Core.Native.ExpectNonNull(global::OpenSSL.Core.Native.X509_get_issuer_name(this.ptr));
				global::OpenSSL.X509.X509Name x509Name = new global::OpenSSL.X509.X509Name(ptr, true);
				x509Name.AddRef();
				return x509Name;
			}
			set
			{
				global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.X509_set_issuer_name(this.ptr, value.Handle));
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000508 RID: 1288 RVA: 0x0000944E File Offset: 0x0000764E
		// (set) Token: 0x06000509 RID: 1289 RVA: 0x00009460 File Offset: 0x00007660
		public int SerialNumber
		{
			get
			{
				return global::OpenSSL.Core.Asn1Integer.ToInt32(global::OpenSSL.Core.Native.X509_get_serialNumber(this.ptr));
			}
			set
			{
				using (global::OpenSSL.Core.Asn1Integer asn1Integer = new global::OpenSSL.Core.Asn1Integer(value))
				{
					global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.X509_set_serialNumber(this.ptr, asn1Integer.Handle));
				}
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x0600050A RID: 1290 RVA: 0x000094A8 File Offset: 0x000076A8
		// (set) Token: 0x0600050B RID: 1291 RVA: 0x000094BC File Offset: 0x000076BC
		public global::System.DateTime NotBefore
		{
			get
			{
				return global::OpenSSL.Core.Asn1DateTime.ToDateTime(this.RawValidity.notBefore);
			}
			set
			{
				using (global::OpenSSL.Core.Asn1DateTime asn1DateTime = new global::OpenSSL.Core.Asn1DateTime(value))
				{
					global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.X509_set_notBefore(this.ptr, asn1DateTime.Handle));
				}
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x0600050C RID: 1292 RVA: 0x00009504 File Offset: 0x00007704
		// (set) Token: 0x0600050D RID: 1293 RVA: 0x00009518 File Offset: 0x00007718
		public global::System.DateTime NotAfter
		{
			get
			{
				return global::OpenSSL.Core.Asn1DateTime.ToDateTime(this.RawValidity.notAfter);
			}
			set
			{
				using (global::OpenSSL.Core.Asn1DateTime asn1DateTime = new global::OpenSSL.Core.Asn1DateTime(value))
				{
					global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.X509_set_notAfter(this.ptr, asn1DateTime.Handle));
				}
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x0600050E RID: 1294 RVA: 0x00009560 File Offset: 0x00007760
		// (set) Token: 0x0600050F RID: 1295 RVA: 0x00009572 File Offset: 0x00007772
		public int Version
		{
			get
			{
				return global::OpenSSL.Core.Native.ASN1_INTEGER_get(this.RawCertInfo.version);
			}
			set
			{
				global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.X509_set_version(this.ptr, value));
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000510 RID: 1296 RVA: 0x00009588 File Offset: 0x00007788
		// (set) Token: 0x06000511 RID: 1297 RVA: 0x000095AD File Offset: 0x000077AD
		public global::OpenSSL.Crypto.CryptoKey PublicKey
		{
			get
			{
				global::System.IntPtr ptr = global::OpenSSL.Core.Native.ExpectNonNull(global::OpenSSL.Core.Native.X509_get_pubkey(this.ptr));
				return new global::OpenSSL.Crypto.CryptoKey(ptr, true);
			}
			set
			{
				global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.X509_set_pubkey(this.ptr, value.Handle));
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000512 RID: 1298 RVA: 0x000095C6 File Offset: 0x000077C6
		public bool HasPrivateKey
		{
			get
			{
				return this.privateKey != null;
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000513 RID: 1299 RVA: 0x000095D4 File Offset: 0x000077D4
		// (set) Token: 0x06000514 RID: 1300 RVA: 0x000095E1 File Offset: 0x000077E1
		public global::OpenSSL.Crypto.CryptoKey PrivateKey
		{
			get
			{
				return this.privateKey.CopyRef();
			}
			set
			{
				if (this.CheckPrivateKey(value))
				{
					this.privateKey = value.CopyRef();
					return;
				}
				throw new global::System.ArgumentException("Private key doesn't correspond to the this certificate");
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000515 RID: 1301 RVA: 0x00009604 File Offset: 0x00007804
		public string PEM
		{
			get
			{
				string result;
				using (global::OpenSSL.Core.BIO bio = global::OpenSSL.Core.BIO.MemoryBuffer())
				{
					this.Write(bio);
					result = bio.ReadString();
				}
				return result;
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000516 RID: 1302 RVA: 0x00009644 File Offset: 0x00007844
		public byte[] DER
		{
			get
			{
				byte[] array;
				using (global::OpenSSL.Core.BIO bio = global::OpenSSL.Core.BIO.MemoryBuffer())
				{
					this.Write_DER(bio);
					array = bio.ReadBytes((int)bio.NumberWritten).Array;
				}
				return array;
			}
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x00009690 File Offset: 0x00007890
		public void Sign(global::OpenSSL.Crypto.CryptoKey pkey, global::OpenSSL.Crypto.MessageDigest digest)
		{
			if (global::OpenSSL.Core.Native.X509_sign(this.ptr, pkey.Handle, digest.Handle) == 0)
			{
				throw new global::OpenSSL.Core.OpenSslException();
			}
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x000096B1 File Offset: 0x000078B1
		public bool CheckPrivateKey(global::OpenSSL.Crypto.CryptoKey pkey)
		{
			return global::OpenSSL.Core.Native.X509_check_private_key(this.ptr, pkey.Handle) == 1;
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x000096C7 File Offset: 0x000078C7
		public bool CheckTrust(int id, int flags)
		{
			return global::OpenSSL.Core.Native.X509_check_trust(this.ptr, id, flags) == 1;
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x000096DC File Offset: 0x000078DC
		public bool Verify(global::OpenSSL.Crypto.CryptoKey pkey)
		{
			int num = global::OpenSSL.Core.Native.X509_verify(this.ptr, pkey.Handle);
			if (num < 0)
			{
				throw new global::OpenSSL.Core.OpenSslException();
			}
			return num == 1;
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x0000970C File Offset: 0x0000790C
		public global::System.ArraySegment<byte> Digest(global::System.IntPtr type, byte[] digest)
		{
			uint count = (uint)digest.Length;
			global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.X509_digest(this.ptr, type, digest, ref count));
			return new global::System.ArraySegment<byte>(digest, 0, (int)count);
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x0000973C File Offset: 0x0000793C
		public global::System.ArraySegment<byte> DigestPublicKey(global::System.IntPtr type, byte[] digest)
		{
			uint count = (uint)digest.Length;
			global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.X509_pubkey_digest(this.ptr, type, digest, ref count));
			return new global::System.ArraySegment<byte>(digest, 0, (int)count);
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x0000976A File Offset: 0x0000796A
		public void Write(global::OpenSSL.Core.BIO bio)
		{
			global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.PEM_write_bio_X509(bio.Handle, this.ptr));
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x00009783 File Offset: 0x00007983
		public void Write_DER(global::OpenSSL.Core.BIO bio)
		{
			global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.i2d_X509_bio(bio.Handle, this.ptr));
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x0000979C File Offset: 0x0000799C
		public override void Print(global::OpenSSL.Core.BIO bio)
		{
			global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.X509_print(bio.Handle, this.ptr));
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x000097B5 File Offset: 0x000079B5
		public global::OpenSSL.X509.X509Request CreateRequest(global::OpenSSL.Crypto.CryptoKey pkey, global::OpenSSL.Crypto.MessageDigest digest)
		{
			return new global::OpenSSL.X509.X509Request(global::OpenSSL.Core.Native.ExpectNonNull(global::OpenSSL.Core.Native.X509_to_X509_REQ(this.ptr, pkey.Handle, digest.Handle)), true);
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x000097D9 File Offset: 0x000079D9
		public void AddExtension(global::OpenSSL.X509.X509Extension ext)
		{
			global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.X509_add_ext(this.ptr, ext.Handle, -1));
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x000097F3 File Offset: 0x000079F3
		public void AddExtension(string name, byte[] value, int crit, uint flags)
		{
			global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.X509_add1_ext_i2d(this.ptr, global::OpenSSL.Core.Native.TextToNID(name), value, crit, flags));
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000523 RID: 1315 RVA: 0x00009810 File Offset: 0x00007A10
		public global::OpenSSL.Core.Stack<global::OpenSSL.X509.X509Extension> Extensions
		{
			get
			{
				if (this.RawCertInfo.extensions != global::System.IntPtr.Zero)
				{
					return new global::OpenSSL.Core.Stack<global::OpenSSL.X509.X509Extension>(this.RawCertInfo.extensions, false);
				}
				return null;
			}
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x0000983C File Offset: 0x00007A3C
		public void AddExtensions(global::OpenSSL.Core.Stack<global::OpenSSL.X509.X509Extension> sk_ext)
		{
			foreach (global::OpenSSL.X509.X509Extension ext in sk_ext)
			{
				this.AddExtension(ext);
			}
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x00009884 File Offset: 0x00007A84
		protected override void OnDispose()
		{
			try
			{
				global::OpenSSL.Core.Native.X509_free(this.ptr);
			}
			catch (global::System.Exception)
			{
			}
			if (this.privateKey != null)
			{
				this.privateKey.Dispose();
				this.privateKey = null;
			}
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x000098CC File Offset: 0x00007ACC
		public override bool Equals(object obj)
		{
			global::OpenSSL.X509.X509Certificate x509Certificate = obj as global::OpenSSL.X509.X509Certificate;
			return x509Certificate != null && this.CompareTo(x509Certificate) == 0;
		}

		// Token: 0x06000527 RID: 1319 RVA: 0x000098EF File Offset: 0x00007AEF
		public override int GetHashCode()
		{
			return this.Issuer.OneLine.GetHashCode() ^ this.SerialNumber;
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000528 RID: 1320 RVA: 0x00009908 File Offset: 0x00007B08
		internal override global::OpenSSL.Core.CryptoLockTypes LockType
		{
			get
			{
				return global::OpenSSL.Core.CryptoLockTypes.CRYPTO_LOCK_X509;
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000529 RID: 1321 RVA: 0x0000990B File Offset: 0x00007B0B
		internal override global::System.Type RawReferenceType
		{
			get
			{
				return typeof(global::OpenSSL.X509.X509Certificate.X509);
			}
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x00009917 File Offset: 0x00007B17
		public int CompareTo(global::OpenSSL.X509.X509Certificate other)
		{
			return global::OpenSSL.Core.Native.X509_cmp(this.ptr, other.ptr);
		}

		// Token: 0x040003BF RID: 959
		private global::OpenSSL.Crypto.CryptoKey privateKey;

		// Token: 0x02000079 RID: 121
		private struct X509_VAL
		{
			// Token: 0x040003C0 RID: 960
			public global::System.IntPtr notBefore;

			// Token: 0x040003C1 RID: 961
			public global::System.IntPtr notAfter;
		}

		// Token: 0x0200007A RID: 122
		private struct X509_CINF
		{
			// Token: 0x040003C2 RID: 962
			public global::System.IntPtr version;

			// Token: 0x040003C3 RID: 963
			public global::System.IntPtr serialNumber;

			// Token: 0x040003C4 RID: 964
			public global::System.IntPtr signature;

			// Token: 0x040003C5 RID: 965
			public global::System.IntPtr issuer;

			// Token: 0x040003C6 RID: 966
			public global::System.IntPtr validity;

			// Token: 0x040003C7 RID: 967
			public global::System.IntPtr subject;

			// Token: 0x040003C8 RID: 968
			public global::System.IntPtr key;

			// Token: 0x040003C9 RID: 969
			public global::System.IntPtr issuerUID;

			// Token: 0x040003CA RID: 970
			public global::System.IntPtr subjectUID;

			// Token: 0x040003CB RID: 971
			public global::System.IntPtr extensions;

			// Token: 0x040003CC RID: 972
			public global::System.IntPtr enc_enc;

			// Token: 0x040003CD RID: 973
			public int enc_len;

			// Token: 0x040003CE RID: 974
			public int enc_modified;
		}

		// Token: 0x0200007B RID: 123
		private struct X509
		{
			// Token: 0x040003CF RID: 975
			public global::System.IntPtr cert_info;

			// Token: 0x040003D0 RID: 976
			public global::System.IntPtr sig_alg;

			// Token: 0x040003D1 RID: 977
			public global::System.IntPtr signature;

			// Token: 0x040003D2 RID: 978
			public int valid;

			// Token: 0x040003D3 RID: 979
			public int references;

			// Token: 0x040003D4 RID: 980
			public global::System.IntPtr name;

			// Token: 0x040003D5 RID: 981
			public global::System.IntPtr ex_data_sk;

			// Token: 0x040003D6 RID: 982
			public int ex_data_dummy;

			// Token: 0x040003D7 RID: 983
			public int ex_pathlen;

			// Token: 0x040003D8 RID: 984
			public int ex_pcpathlen;

			// Token: 0x040003D9 RID: 985
			public uint ex_flags;

			// Token: 0x040003DA RID: 986
			public uint ex_kusage;

			// Token: 0x040003DB RID: 987
			public uint ex_xkusage;

			// Token: 0x040003DC RID: 988
			public uint ex_nscert;

			// Token: 0x040003DD RID: 989
			public global::System.IntPtr skid;

			// Token: 0x040003DE RID: 990
			public global::System.IntPtr akid;

			// Token: 0x040003DF RID: 991
			public global::System.IntPtr policy_cache;

			// Token: 0x040003E0 RID: 992
			public global::System.IntPtr crldp;

			// Token: 0x040003E1 RID: 993
			public global::System.IntPtr altname;

			// Token: 0x040003E2 RID: 994
			public global::System.IntPtr nc;

			// Token: 0x040003E3 RID: 995
			public global::System.IntPtr rfc3779_addr;

			// Token: 0x040003E4 RID: 996
			public global::System.IntPtr rfc3779_asid;

			// Token: 0x040003E5 RID: 997
			[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 20)]
			public byte[] sha1_hash;

			// Token: 0x040003E6 RID: 998
			public global::System.IntPtr aux;
		}
	}
}
