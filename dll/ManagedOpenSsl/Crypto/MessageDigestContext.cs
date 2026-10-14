using System;
using OpenSSL.Core;

namespace OpenSSL.Crypto
{
	// Token: 0x0200003A RID: 58
	public class MessageDigestContext : global::OpenSSL.Core.Base
	{
		// Token: 0x06000136 RID: 310 RVA: 0x00005141 File Offset: 0x00003341
		public MessageDigestContext(global::OpenSSL.Core.BIO bio) : base(global::OpenSSL.Core.Native.ExpectNonNull(global::OpenSSL.Core.Native.BIO_get_md_ctx(bio.Handle)), false)
		{
			this.md = new global::OpenSSL.Crypto.MessageDigest(global::OpenSSL.Core.Native.ExpectNonNull(global::OpenSSL.Core.Native.BIO_get_md(bio.Handle)), false);
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00005176 File Offset: 0x00003376
		public MessageDigestContext(global::OpenSSL.Crypto.MessageDigest md) : base(global::OpenSSL.Core.Native.EVP_MD_CTX_create(), true)
		{
			global::OpenSSL.Core.Native.EVP_MD_CTX_init(this.ptr);
			this.md = md;
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00005196 File Offset: 0x00003396
		public override void Print(global::OpenSSL.Core.BIO bio)
		{
			bio.Write("MessageDigestContext: " + this.md.LongName);
		}

		// Token: 0x06000139 RID: 313 RVA: 0x000051B4 File Offset: 0x000033B4
		public byte[] Digest(byte[] msg)
		{
			byte[] array = new byte[this.md.Size];
			uint num = (uint)array.Length;
			global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.EVP_DigestInit_ex(this.ptr, this.md.Handle, global::System.IntPtr.Zero));
			global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.EVP_DigestUpdate(this.ptr, msg, (uint)msg.Length));
			global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.EVP_DigestFinal_ex(this.ptr, array, ref num));
			return array;
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00005221 File Offset: 0x00003421
		public void Init()
		{
			global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.EVP_DigestInit_ex(this.ptr, this.md.Handle, global::System.IntPtr.Zero));
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00005244 File Offset: 0x00003444
		public void Update(byte[] msg)
		{
			global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.EVP_DigestUpdate(this.ptr, msg, (uint)msg.Length));
		}

		// Token: 0x0600013C RID: 316 RVA: 0x0000525C File Offset: 0x0000345C
		public byte[] DigestFinal()
		{
			byte[] array = new byte[this.md.Size];
			uint num = (uint)array.Length;
			global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.EVP_DigestFinal_ex(this.ptr, array, ref num));
			return array;
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00005294 File Offset: 0x00003494
		public byte[] SignFinal(global::OpenSSL.Crypto.CryptoKey pkey)
		{
			int size = this.md.Size;
			byte[] array = new byte[pkey.Size];
			uint num = (uint)array.Length;
			global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.EVP_SignFinal(this.ptr, array, ref num, pkey.Handle));
			return array;
		}

		// Token: 0x0600013E RID: 318 RVA: 0x000052D8 File Offset: 0x000034D8
		public bool VerifyFinal(byte[] sig, global::OpenSSL.Crypto.CryptoKey pkey)
		{
			int num = global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.EVP_VerifyFinal(this.ptr, sig, (uint)sig.Length, pkey.Handle));
			return num == 1;
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00005304 File Offset: 0x00003504
		public byte[] Sign(byte[] msg, global::OpenSSL.Crypto.CryptoKey pkey)
		{
			byte[] array = new byte[pkey.Size];
			uint num = (uint)array.Length;
			global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.EVP_DigestInit_ex(this.ptr, this.md.Handle, global::System.IntPtr.Zero));
			global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.EVP_DigestUpdate(this.ptr, msg, (uint)msg.Length));
			global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.EVP_SignFinal(this.ptr, array, ref num, pkey.Handle));
			byte[] array2 = new byte[num];
			global::System.Buffer.BlockCopy(array, 0, array2, 0, (int)num);
			return array2;
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00005384 File Offset: 0x00003584
		public static byte[] Sign(global::OpenSSL.Crypto.MessageDigest md, global::OpenSSL.Core.BIO bio, global::OpenSSL.Crypto.CryptoKey pkey)
		{
			global::OpenSSL.Core.BIO bio2 = global::OpenSSL.Core.BIO.MessageDigest(md);
			bio2.Push(bio);
			while (bio2.ReadBytes(4096).Count != 0)
			{
			}
			global::OpenSSL.Crypto.MessageDigestContext messageDigestContext = new global::OpenSSL.Crypto.MessageDigestContext(bio2);
			byte[] array = new byte[pkey.Size];
			uint num = (uint)array.Length;
			global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.EVP_SignFinal(messageDigestContext.Handle, array, ref num, pkey.Handle));
			byte[] array2 = new byte[num];
			global::System.Buffer.BlockCopy(array, 0, array2, 0, (int)num);
			return array2;
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00005400 File Offset: 0x00003600
		public bool Verify(byte[] msg, byte[] sig, global::OpenSSL.Crypto.CryptoKey pkey)
		{
			global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.EVP_DigestInit_ex(this.ptr, this.md.Handle, global::System.IntPtr.Zero));
			global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.EVP_DigestUpdate(this.ptr, msg, (uint)msg.Length));
			int num = global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.EVP_VerifyFinal(this.ptr, sig, (uint)sig.Length, pkey.Handle));
			return num == 1;
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00005464 File Offset: 0x00003664
		public static bool Verify(global::OpenSSL.Crypto.MessageDigest md, global::OpenSSL.Core.BIO bio, byte[] sig, global::OpenSSL.Crypto.CryptoKey pkey)
		{
			global::OpenSSL.Core.BIO bio2 = global::OpenSSL.Core.BIO.MessageDigest(md);
			bio2.Push(bio);
			while (bio2.ReadBytes(4096).Count != 0)
			{
			}
			global::OpenSSL.Crypto.MessageDigestContext messageDigestContext = new global::OpenSSL.Crypto.MessageDigestContext(bio2);
			int num = global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.EVP_VerifyFinal(messageDigestContext.Handle, sig, (uint)sig.Length, pkey.Handle));
			return num == 1;
		}

		// Token: 0x06000143 RID: 323 RVA: 0x000054BA File Offset: 0x000036BA
		protected override void OnDispose()
		{
			global::OpenSSL.Core.Native.EVP_MD_CTX_cleanup(this.ptr);
			global::OpenSSL.Core.Native.EVP_MD_CTX_destroy(this.ptr);
		}

		// Token: 0x04000194 RID: 404
		private global::OpenSSL.Crypto.MessageDigest md;
	}
}
