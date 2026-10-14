using System;
using System.Runtime.InteropServices;
using System.Text;
using OpenSSL.Core;

namespace OpenSSL.Crypto
{
	// Token: 0x02000037 RID: 55
	public class MessageDigest : global::OpenSSL.Core.Base
	{
		// Token: 0x0600012B RID: 299 RVA: 0x00004F8E File Offset: 0x0000318E
		internal MessageDigest(global::System.IntPtr ptr, bool owner) : base(ptr, owner)
		{
			this.raw = (global::OpenSSL.Crypto.MessageDigest.EVP_MD)global::System.Runtime.InteropServices.Marshal.PtrToStructure(this.ptr, typeof(global::OpenSSL.Crypto.MessageDigest.EVP_MD));
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00004FB8 File Offset: 0x000031B8
		public override void Print(global::OpenSSL.Core.BIO bio)
		{
			bio.Write("MessageDigest");
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00004FC5 File Offset: 0x000031C5
		protected override void OnDispose()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00004FCC File Offset: 0x000031CC
		public static global::OpenSSL.Crypto.MessageDigest CreateByName(string name)
		{
			byte[] bytes = global::System.Text.Encoding.ASCII.GetBytes(name);
			global::System.IntPtr intPtr = global::OpenSSL.Core.Native.EVP_get_digestbyname(bytes);
			if (intPtr == global::System.IntPtr.Zero)
			{
				return null;
			}
			return new global::OpenSSL.Crypto.MessageDigest(intPtr, false);
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600012F RID: 303 RVA: 0x00005002 File Offset: 0x00003202
		public static string[] AllNamesSorted
		{
			get
			{
				return new global::OpenSSL.Core.NameCollector(1, true).Result.ToArray();
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000130 RID: 304 RVA: 0x00005015 File Offset: 0x00003215
		public static string[] AllNames
		{
			get
			{
				return new global::OpenSSL.Core.NameCollector(1, false).Result.ToArray();
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000131 RID: 305 RVA: 0x00005028 File Offset: 0x00003228
		public int BlockSize
		{
			get
			{
				return this.raw.block_size;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000132 RID: 306 RVA: 0x00005035 File Offset: 0x00003235
		public int Size
		{
			get
			{
				return this.raw.md_size;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000133 RID: 307 RVA: 0x00005042 File Offset: 0x00003242
		public string LongName
		{
			get
			{
				return global::OpenSSL.Core.Native.PtrToStringAnsi(global::OpenSSL.Core.Native.OBJ_nid2ln(this.raw.type), false);
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000134 RID: 308 RVA: 0x0000505A File Offset: 0x0000325A
		public string Name
		{
			get
			{
				return global::OpenSSL.Core.Native.PtrToStringAnsi(global::OpenSSL.Core.Native.OBJ_nid2sn(this.raw.type), false);
			}
		}

		// Token: 0x04000172 RID: 370
		private global::OpenSSL.Crypto.MessageDigest.EVP_MD raw;

		// Token: 0x04000173 RID: 371
		public static global::OpenSSL.Crypto.MessageDigest Null = new global::OpenSSL.Crypto.MessageDigest(global::OpenSSL.Core.Native.EVP_md_null(), false);

		// Token: 0x04000174 RID: 372
		public static global::OpenSSL.Crypto.MessageDigest MD4 = new global::OpenSSL.Crypto.MessageDigest(global::OpenSSL.Core.Native.EVP_md4(), false);

		// Token: 0x04000175 RID: 373
		public static global::OpenSSL.Crypto.MessageDigest MD5 = new global::OpenSSL.Crypto.MessageDigest(global::OpenSSL.Core.Native.EVP_md5(), false);

		// Token: 0x04000176 RID: 374
		public static global::OpenSSL.Crypto.MessageDigest SHA = new global::OpenSSL.Crypto.MessageDigest(global::OpenSSL.Core.Native.EVP_sha(), false);

		// Token: 0x04000177 RID: 375
		public static global::OpenSSL.Crypto.MessageDigest SHA1 = new global::OpenSSL.Crypto.MessageDigest(global::OpenSSL.Core.Native.EVP_sha1(), false);

		// Token: 0x04000178 RID: 376
		public static global::OpenSSL.Crypto.MessageDigest SHA224 = new global::OpenSSL.Crypto.MessageDigest(global::OpenSSL.Core.Native.EVP_sha224(), false);

		// Token: 0x04000179 RID: 377
		public static global::OpenSSL.Crypto.MessageDigest SHA256 = new global::OpenSSL.Crypto.MessageDigest(global::OpenSSL.Core.Native.EVP_sha256(), false);

		// Token: 0x0400017A RID: 378
		public static global::OpenSSL.Crypto.MessageDigest SHA384 = new global::OpenSSL.Crypto.MessageDigest(global::OpenSSL.Core.Native.EVP_sha384(), false);

		// Token: 0x0400017B RID: 379
		public static global::OpenSSL.Crypto.MessageDigest SHA512 = new global::OpenSSL.Crypto.MessageDigest(global::OpenSSL.Core.Native.EVP_sha512(), false);

		// Token: 0x0400017C RID: 380
		public static global::OpenSSL.Crypto.MessageDigest DSS = new global::OpenSSL.Crypto.MessageDigest(global::OpenSSL.Core.Native.EVP_dss(), false);

		// Token: 0x0400017D RID: 381
		public static global::OpenSSL.Crypto.MessageDigest DSS1 = new global::OpenSSL.Crypto.MessageDigest(global::OpenSSL.Core.Native.EVP_dss1(), false);

		// Token: 0x0400017E RID: 382
		public static global::OpenSSL.Crypto.MessageDigest RipeMD160 = new global::OpenSSL.Crypto.MessageDigest(global::OpenSSL.Core.Native.EVP_ripemd160(), false);

		// Token: 0x02000038 RID: 56
		private struct EVP_MD
		{
			// Token: 0x0400017F RID: 383
			public int type;

			// Token: 0x04000180 RID: 384
			public int pkey_type;

			// Token: 0x04000181 RID: 385
			public int md_size;

			// Token: 0x04000182 RID: 386
			public uint flags;

			// Token: 0x04000183 RID: 387
			public global::System.IntPtr init;

			// Token: 0x04000184 RID: 388
			public global::System.IntPtr update;

			// Token: 0x04000185 RID: 389
			public global::System.IntPtr final;

			// Token: 0x04000186 RID: 390
			public global::System.IntPtr copy;

			// Token: 0x04000187 RID: 391
			public global::System.IntPtr cleanup;

			// Token: 0x04000188 RID: 392
			public global::System.IntPtr sign;

			// Token: 0x04000189 RID: 393
			public global::System.IntPtr verify;

			// Token: 0x0400018A RID: 394
			[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 5)]
			public int[] required_pkey_type;

			// Token: 0x0400018B RID: 395
			public int block_size;

			// Token: 0x0400018C RID: 396
			public int ctx_size;

			// Token: 0x0400018D RID: 397
			public global::System.IntPtr md_ctrl;
		}
	}
}
