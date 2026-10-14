using System;
using System.IO;
using System.Security.Cryptography;

namespace Motorola.Common.Communication.TetraSecurity
{
	// Token: 0x02000006 RID: 6
	public class CEncode : global::System.IDisposable
	{
		// Token: 0x0600003C RID: 60 RVA: 0x00003678 File Offset: 0x00002678
		public CEncode()
		{
			try
			{
				this.bIn = new byte[1024];
				this.rdlen = 0L;
			}
			catch
			{
				global::Motorola.Common.Communication.TetraSecurity.CSecureException ex = new global::Motorola.Common.Communication.TetraSecurity.CSecureException(2386U, "Secure", base.GetType().ToString() + ", CEncode", global::System.Environment.StackTrace.ToString());
				throw ex;
			}
		}

		// Token: 0x0600003D RID: 61 RVA: 0x000036E8 File Offset: 0x000026E8
		public void EncryptFile(byte[] bufferInputput, ref byte[] bufferOutput, global::System.Security.Cryptography.TripleDESCryptoServiceProvider cryptoService, byte[] key, byte[] IV)
		{
			global::System.IO.MemoryStream memoryStream = null;
			global::System.IO.MemoryStream memoryStream2 = null;
			try
			{
				if (bufferInputput == null || bufferOutput == null || cryptoService == null || key == null || IV == null)
				{
					global::Motorola.Common.Communication.TetraSecurity.CSecureException ex = new global::Motorola.Common.Communication.TetraSecurity.CSecureException(2388U, "Secure", base.GetType().ToString() + ", EncryptFile", global::System.Environment.StackTrace.ToString());
					throw ex;
				}
				this.rdlen = (long)(this.length = 0);
				this.totalLen = (long)bufferInputput.Length;
				cryptoService.Key = key;
				cryptoService.IV = IV;
				memoryStream = new global::System.IO.MemoryStream(bufferInputput);
				memoryStream2 = new global::System.IO.MemoryStream();
				memoryStream2.SetLength((long)bufferInputput.Length);
				this.cryptoStream = new global::System.Security.Cryptography.CryptoStream(memoryStream2, cryptoService.CreateEncryptor(), global::System.Security.Cryptography.CryptoStreamMode.Write);
				while (this.rdlen < this.totalLen)
				{
					this.length = memoryStream.Read(this.bIn, 0, 1024);
					this.cryptoStream.Write(this.bIn, 0, this.length);
					this.rdlen += (long)this.length;
				}
				this.cryptoStream.FlushFinalBlock();
				bufferOutput = memoryStream2.ToArray();
			}
			catch (global::Motorola.Common.Communication.TetraSecurity.CSecureException)
			{
				throw;
			}
			catch (global::System.Exception ex2)
			{
				if (!global::Motorola.Common.Communication.TetraSecurity.CSecureException.CheckErrorIDExsists(ex2))
				{
					ex2.Source = 2389U.ToString() + "|" + ex2.Source;
				}
				global::Motorola.Common.Communication.TetraSecurity.CSecureException.Rethrow(ex2);
			}
			finally
			{
				if (memoryStream != null)
				{
					memoryStream.Close();
				}
				if (memoryStream2 != null)
				{
					memoryStream2.Close();
				}
			}
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00003898 File Offset: 0x00002898
		public void EncryptFile_Old(byte[] bufferInput, ref byte[] bufferOutput, global::System.Security.Cryptography.TripleDESCryptoServiceProvider cryptoService, byte[] key, byte[] IV)
		{
			global::System.IO.MemoryStream memoryStream = null;
			global::System.IO.MemoryStream memoryStream2 = null;
			try
			{
				if (bufferInput == null || bufferOutput == null || cryptoService == null || key == null || IV == null)
				{
					global::Motorola.Common.Communication.TetraSecurity.CSecureException ex = new global::Motorola.Common.Communication.TetraSecurity.CSecureException(2388U, "Secure", base.GetType().ToString() + ", EncryptFile", global::System.Environment.StackTrace.ToString());
					throw ex;
				}
				this.rdlen = (long)(this.length = 0);
				this.totalLen = (long)(bufferInput.Length + 3);
				cryptoService.Key = key;
				cryptoService.IV = IV;
				this.byteIn = new byte[this.totalLen];
				this.byteIn[0] = 239;
				this.byteIn[1] = 187;
				this.byteIn[2] = 191;
				global::System.Array.Copy(bufferInput, 0, this.byteIn, 3, bufferInput.Length);
				memoryStream = new global::System.IO.MemoryStream(this.byteIn);
				memoryStream2 = new global::System.IO.MemoryStream();
				memoryStream2.SetLength((long)this.byteIn.Length);
				this.cryptoStream = new global::System.Security.Cryptography.CryptoStream(memoryStream2, cryptoService.CreateEncryptor(), global::System.Security.Cryptography.CryptoStreamMode.Write);
				while (this.rdlen < this.totalLen)
				{
					this.length = memoryStream.Read(this.bIn, 0, 1024);
					this.cryptoStream.Write(this.bIn, 0, this.length);
					this.rdlen += (long)this.length;
				}
				this.cryptoStream.FlushFinalBlock();
				bufferOutput = memoryStream2.ToArray();
			}
			catch (global::Motorola.Common.Communication.TetraSecurity.CSecureException)
			{
				throw;
			}
			catch (global::System.Exception ex2)
			{
				if (!global::Motorola.Common.Communication.TetraSecurity.CSecureException.CheckErrorIDExsists(ex2))
				{
					ex2.Source = 2389U.ToString() + "|" + ex2.Source;
				}
				global::Motorola.Common.Communication.TetraSecurity.CSecureException.Rethrow(ex2);
			}
			finally
			{
				if (memoryStream != null)
				{
					memoryStream.Close();
				}
				if (memoryStream2 != null)
				{
					memoryStream2.Close();
				}
			}
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00003A9C File Offset: 0x00002A9C
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00003AAC File Offset: 0x00002AAC
		protected virtual void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (this.fileIn != null)
				{
					this.fileIn.Dispose();
					this.fileIn = null;
				}
				if (this.fileOut != null)
				{
					this.fileOut.Dispose();
					this.fileOut = null;
				}
				if (this.bufferIn != null)
				{
					this.bufferIn.Dispose();
					this.bufferIn = null;
				}
				if (this.bufferOut != null)
				{
					this.bufferOut.Dispose();
					this.bufferOut = null;
				}
				if (this.cryptoStream != null)
				{
					this.cryptoStream.Dispose();
					this.cryptoStream = null;
				}
			}
		}

		// Token: 0x0400043E RID: 1086
		private global::System.IO.FileStream fileIn;

		// Token: 0x0400043F RID: 1087
		private global::System.IO.FileStream fileOut;

		// Token: 0x04000440 RID: 1088
		private global::System.IO.MemoryStream bufferIn;

		// Token: 0x04000441 RID: 1089
		private global::System.IO.MemoryStream bufferOut;

		// Token: 0x04000442 RID: 1090
		private global::System.Security.Cryptography.CryptoStream cryptoStream;

		// Token: 0x04000443 RID: 1091
		private byte[] byteIn;

		// Token: 0x04000444 RID: 1092
		private byte[] bIn;

		// Token: 0x04000445 RID: 1093
		private long rdlen;

		// Token: 0x04000446 RID: 1094
		private long totalLen;

		// Token: 0x04000447 RID: 1095
		private int length;
	}
}
