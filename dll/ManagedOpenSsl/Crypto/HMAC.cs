using System;
using System.Runtime.InteropServices;
using OpenSSL.Core;

namespace OpenSSL.Crypto
{
	// Token: 0x02000034 RID: 52
	public class HMAC : global::OpenSSL.Core.Base
	{
		// Token: 0x0600011D RID: 285 RVA: 0x00004D5E File Offset: 0x00002F5E
		public HMAC() : base(global::System.IntPtr.Zero, true)
		{
			this.ptr = global::OpenSSL.Core.Native.OPENSSL_malloc(global::System.Runtime.InteropServices.Marshal.SizeOf(typeof(global::OpenSSL.Crypto.HMAC.HMAC_CTX)));
			global::OpenSSL.Core.Native.HMAC_CTX_init(this.ptr);
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00004D94 File Offset: 0x00002F94
		public static byte[] Digest(global::OpenSSL.Crypto.MessageDigest digest, byte[] key, byte[] data)
		{
			byte[] array = new byte[digest.Size];
			uint num = 64U;
			global::OpenSSL.Core.Native.HMAC(digest.Handle, key, key.Length, data, data.Length, array, ref num);
			return array;
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00004DC8 File Offset: 0x00002FC8
		public void Init(byte[] key, global::OpenSSL.Crypto.MessageDigest digest)
		{
			global::OpenSSL.Core.Native.HMAC_Init_ex(this.ptr, key, key.Length, digest.Handle, global::System.IntPtr.Zero);
			this.digest_size = digest.Size;
			this.initialized = true;
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00004DF7 File Offset: 0x00002FF7
		public void Update(byte[] data)
		{
			if (!this.initialized)
			{
				throw new global::System.Exception("Failed to call Initialize before calling Update");
			}
			global::OpenSSL.Core.Native.HMAC_Update(this.ptr, data, data.Length);
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00004E1C File Offset: 0x0000301C
		public void Update(byte[] data, int offset, int count)
		{
			if (!this.initialized)
			{
				throw new global::System.Exception("Failed to call Initialize before calling Update");
			}
			if (data == null)
			{
				throw new global::System.ArgumentNullException("data");
			}
			if (count <= 0)
			{
				throw new global::System.ArgumentException("count must be greater than 0");
			}
			if (offset < 0)
			{
				throw new global::System.ArgumentException("offset must be 0 or greater");
			}
			if (data.Length < count - offset)
			{
				throw new global::System.ArgumentException("invalid length specified.  Count is greater than buffer length.");
			}
			global::System.ArraySegment<byte> arraySegment = new global::System.ArraySegment<byte>(data, offset, count);
			global::OpenSSL.Core.Native.HMAC_Update(this.ptr, arraySegment.Array, arraySegment.Count);
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00004EA0 File Offset: 0x000030A0
		public byte[] DigestFinal()
		{
			if (!this.initialized)
			{
				throw new global::System.Exception("Failed to call Initialize before calling DigestFinal");
			}
			byte[] array = new byte[this.digest_size];
			uint num = 64U;
			global::OpenSSL.Core.Native.HMAC_Final(this.ptr, array, ref num);
			return array;
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00004EDE File Offset: 0x000030DE
		protected override void OnDispose()
		{
			global::OpenSSL.Core.Native.HMAC_CTX_cleanup(this.ptr);
			global::OpenSSL.Core.Native.OPENSSL_free(this.ptr);
		}

		// Token: 0x04000168 RID: 360
		private bool initialized;

		// Token: 0x04000169 RID: 361
		private int digest_size;

		// Token: 0x02000035 RID: 53
		private struct HMAC_CTX
		{
			// Token: 0x0400016A RID: 362
			private global::System.IntPtr md;

			// Token: 0x0400016B RID: 363
			private global::OpenSSL.Crypto.EVP_MD_CTX md_ctx;

			// Token: 0x0400016C RID: 364
			private global::OpenSSL.Crypto.EVP_MD_CTX i_ctx;

			// Token: 0x0400016D RID: 365
			private global::OpenSSL.Crypto.EVP_MD_CTX o_ctx;

			// Token: 0x0400016E RID: 366
			private uint key_length;

			// Token: 0x0400016F RID: 367
			[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 128)]
			private byte[] key;
		}
	}
}
