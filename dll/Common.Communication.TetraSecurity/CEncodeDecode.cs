using System;
using System.Security.Cryptography;

namespace Motorola.Common.Communication.TetraSecurity
{
	// Token: 0x02000008 RID: 8
	internal class CEncodeDecode : global::Motorola.Common.Communication.TetraSecurity.ISecure, global::System.IDisposable
	{
		// Token: 0x06000043 RID: 67 RVA: 0x00003B44 File Offset: 0x00002B44
		public CEncodeDecode()
		{
			try
			{
				this.encode = new global::Motorola.Common.Communication.TetraSecurity.CEncode();
				this.decode = new global::Motorola.Common.Communication.TetraSecurity.CDecode();
				this.cryptoService = new global::System.Security.Cryptography.TripleDESCryptoServiceProvider();
			}
			catch
			{
				global::Motorola.Common.Communication.TetraSecurity.CSecureException ex = new global::Motorola.Common.Communication.TetraSecurity.CSecureException(2385U, "Secure", base.GetType().ToString() + ", CEncodeDecode", global::System.Environment.StackTrace.ToString());
				throw ex;
			}
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00003BBC File Offset: 0x00002BBC
		public void EncryptFile(byte[] bufferIn, ref byte[] bufferOut, byte[] key, byte[] IV)
		{
			this.encode.EncryptFile(bufferIn, ref bufferOut, this.cryptoService, key, IV);
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00003BD4 File Offset: 0x00002BD4
		public void EncryptFile_Old(byte[] bufferIn, ref byte[] bufferOut, byte[] key, byte[] IV)
		{
			this.encode.EncryptFile_Old(bufferIn, ref bufferOut, this.cryptoService, key, IV);
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00003BEC File Offset: 0x00002BEC
		public void DecryptFile(byte[] bufferIn, ref byte[] bufferOut, byte[] key, byte[] IV)
		{
			this.decode.DecryptFile(bufferIn, ref bufferOut, this.cryptoService, key, IV);
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00003C04 File Offset: 0x00002C04
		public void DecryptFile_Old(byte[] bufferIn, ref byte[] bufferOut, byte[] key, byte[] IV)
		{
			this.decode.DecryptFile_Old(bufferIn, ref bufferOut, this.cryptoService, key, IV);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00003C1C File Offset: 0x00002C1C
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00003C2C File Offset: 0x00002C2C
		protected virtual void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (this.cryptoService != null)
				{
					this.cryptoService.Clear();
				}
				if (this.encode != null)
				{
					this.encode.Dispose();
					this.encode = null;
				}
				if (this.decode != null)
				{
					this.decode.Dispose();
					this.decode = null;
				}
			}
		}

		// Token: 0x04000448 RID: 1096
		private global::Motorola.Common.Communication.TetraSecurity.CEncode encode;

		// Token: 0x04000449 RID: 1097
		private global::Motorola.Common.Communication.TetraSecurity.CDecode decode;

		// Token: 0x0400044A RID: 1098
		private global::System.Security.Cryptography.TripleDESCryptoServiceProvider cryptoService;
	}
}
