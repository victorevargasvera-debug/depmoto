using System;
using System.IO;
using System.Security.Cryptography;

namespace Motorola.Common.Communication.TetraSecurity
{
	// Token: 0x02000005 RID: 5
	public class CDecode : global::System.IDisposable
	{
		// Token: 0x06000036 RID: 54 RVA: 0x00003000 File Offset: 0x00002000
		public CDecode()
		{
			try
			{
				this.bIn = new byte[1024];
				this.rdlen = 0L;
			}
			catch
			{
				global::Motorola.Common.Communication.TetraSecurity.CSecureException ex = new global::Motorola.Common.Communication.TetraSecurity.CSecureException(2387U, "Secure", base.GetType().ToString() + ", CDecode", global::System.Environment.StackTrace.ToString());
				throw ex;
			}
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00003070 File Offset: 0x00002070
		private static int ReadAllBytesFromStream(global::System.IO.Stream stream, int length, out byte[] buffer)
		{
			buffer = new byte[length];
			int num = 0;
			int num2 = 0;
			for (;;)
			{
				int num3 = stream.Read(buffer, num, 100);
				if (num3 == 0)
				{
					break;
				}
				num += num3;
				num2 += num3;
				if (num2 + 100 >= length)
				{
					byte[] array = new byte[length];
					global::System.Array.Copy(buffer, array, length);
					buffer = new byte[length * 2];
					global::System.Array.Copy(array, buffer, length);
					length *= 2;
				}
			}
			return num2;
		}

		// Token: 0x06000038 RID: 56 RVA: 0x000030D4 File Offset: 0x000020D4
		public void DecryptFile_Old(byte[] byteInput, ref byte[] byteOutput, global::System.Security.Cryptography.TripleDESCryptoServiceProvider cryptoService, byte[] key, byte[] IV)
		{
			try
			{
				if (byteInput == null || cryptoService == null || key == null || IV == null)
				{
					global::Motorola.Common.Communication.TetraSecurity.CSecureException ex = new global::Motorola.Common.Communication.TetraSecurity.CSecureException(2388U, "Secure", base.GetType().ToString() + ", DecryptFile", global::System.Environment.StackTrace.ToString());
					throw ex;
				}
				if (byteOutput == null)
				{
					byteOutput = new byte[0];
				}
				this.rdlen = (long)(this.length = 0);
				this.totalLength = (long)byteInput.Length;
				cryptoService.Key = key;
				cryptoService.IV = IV;
				this.bufferIn = new global::System.IO.MemoryStream(byteInput);
				this.bufferOut = new global::System.IO.MemoryStream();
				this.bufferOut.SetLength(this.bufferIn.Length);
				this.cryptoStream = new global::System.Security.Cryptography.CryptoStream(this.bufferOut, cryptoService.CreateDecryptor(), global::System.Security.Cryptography.CryptoStreamMode.Write);
				while (this.rdlen < this.totalLength)
				{
					this.length = this.bufferIn.Read(this.bIn, 0, 1024);
					this.cryptoStream.Write(this.bIn, 0, this.length);
					this.rdlen += (long)this.length;
				}
				this.cryptoStream.FlushFinalBlock();
				byteInput = this.bufferOut.ToArray();
				byte b = byteInput[0];
				if (b != 239)
				{
					switch (b)
					{
					case 254:
						if (!byteInput[1].Equals(255))
						{
							global::Motorola.Common.Communication.TetraSecurity.CSecureException ex2 = new global::Motorola.Common.Communication.TetraSecurity.CSecureException(2391U, "Secure", base.GetType().ToString() + ", DecryptFile", global::System.Environment.StackTrace.ToString());
							throw ex2;
						}
						byteOutput = new byte[byteInput.Length - 2];
						global::System.Array.Copy(byteInput, 2, byteOutput, 0, byteInput.Length - 2);
						break;
					case 255:
						if (!byteInput[1].Equals(254))
						{
							global::Motorola.Common.Communication.TetraSecurity.CSecureException ex3 = new global::Motorola.Common.Communication.TetraSecurity.CSecureException(2391U, "Secure", base.GetType().ToString() + ", DecryptFile", global::System.Environment.StackTrace.ToString());
							throw ex3;
						}
						byteOutput = new byte[byteInput.Length - 2];
						global::System.Array.Copy(byteInput, 2, byteOutput, 0, byteInput.Length - 2);
						break;
					default:
						byteOutput = new byte[byteInput.Length];
						global::System.Array.Copy(byteInput, 0, byteOutput, 0, byteInput.Length);
						break;
					}
				}
				else
				{
					if (!byteInput[1].Equals(187) || !byteInput[2].Equals(191))
					{
						global::Motorola.Common.Communication.TetraSecurity.CSecureException ex4 = new global::Motorola.Common.Communication.TetraSecurity.CSecureException(2391U, "Secure", base.GetType().ToString() + ", DecryptFile", global::System.Environment.StackTrace.ToString());
						throw ex4;
					}
					if (byteOutput.Length != byteInput.Length - 3)
					{
						global::System.Array.Resize<byte>(ref byteOutput, byteInput.Length - 3);
					}
					global::System.Array.Copy(byteInput, 3, byteOutput, 0, byteInput.Length - 3);
				}
			}
			catch (global::Motorola.Common.Communication.TetraSecurity.CSecureException)
			{
				throw;
			}
			catch (global::System.Exception ex5)
			{
				if (!global::Motorola.Common.Communication.TetraSecurity.CSecureException.CheckErrorIDExsists(ex5))
				{
					ex5.Source = 2390U.ToString() + "|" + ex5.Source;
				}
				global::Motorola.Common.Communication.TetraSecurity.CSecureException.Rethrow(ex5);
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00003408 File Offset: 0x00002408
		public void DecryptFile(byte[] byteInput, ref byte[] byteOutput, global::System.Security.Cryptography.TripleDESCryptoServiceProvider cryptoService, byte[] key, byte[] IV)
		{
			try
			{
				if (byteInput == null || cryptoService == null || key == null || IV == null)
				{
					global::Motorola.Common.Communication.TetraSecurity.CSecureException ex = new global::Motorola.Common.Communication.TetraSecurity.CSecureException(2388U, "Secure", base.GetType().ToString() + ", DecryptFile", global::System.Environment.StackTrace.ToString());
					throw ex;
				}
				this.rdlen = (long)(this.length = 0);
				this.totalLength = (long)byteInput.Length;
				cryptoService.Key = key;
				cryptoService.IV = IV;
				this.bufferIn = new global::System.IO.MemoryStream(byteInput);
				this.bufferOut = new global::System.IO.MemoryStream();
				this.bufferOut.SetLength(this.bufferIn.Length);
				this.cryptoStream = new global::System.Security.Cryptography.CryptoStream(this.bufferOut, cryptoService.CreateDecryptor(), global::System.Security.Cryptography.CryptoStreamMode.Write);
				while (this.rdlen < this.totalLength)
				{
					this.length = this.bufferIn.Read(this.bIn, 0, 1024);
					this.cryptoStream.Write(this.bIn, 0, this.length);
					this.rdlen += (long)this.length;
				}
				this.cryptoStream.FlushFinalBlock();
				byteInput = this.bufferOut.ToArray();
				if (byteOutput == null)
				{
					byteOutput = new byte[0];
				}
				if (byteOutput.Length != byteInput.Length)
				{
					global::System.Array.Resize<byte>(ref byteOutput, byteInput.Length);
				}
				global::System.Array.Copy(byteInput, 0, byteOutput, 0, byteInput.Length);
			}
			catch (global::Motorola.Common.Communication.TetraSecurity.CSecureException)
			{
				throw;
			}
			catch (global::System.Exception ex2)
			{
				if (!global::Motorola.Common.Communication.TetraSecurity.CSecureException.CheckErrorIDExsists(ex2))
				{
					ex2.Source = 2390U.ToString() + "|" + ex2.Source;
				}
				global::Motorola.Common.Communication.TetraSecurity.CSecureException.Rethrow(ex2);
			}
		}

		// Token: 0x0600003A RID: 58 RVA: 0x000035D0 File Offset: 0x000025D0
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x000035E0 File Offset: 0x000025E0
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

		// Token: 0x04000435 RID: 1077
		private global::System.IO.FileStream fileIn;

		// Token: 0x04000436 RID: 1078
		private global::System.IO.FileStream fileOut;

		// Token: 0x04000437 RID: 1079
		private global::System.IO.MemoryStream bufferIn;

		// Token: 0x04000438 RID: 1080
		private global::System.IO.MemoryStream bufferOut;

		// Token: 0x04000439 RID: 1081
		private global::System.Security.Cryptography.CryptoStream cryptoStream;

		// Token: 0x0400043A RID: 1082
		private byte[] bIn;

		// Token: 0x0400043B RID: 1083
		private long rdlen;

		// Token: 0x0400043C RID: 1084
		private long totalLength;

		// Token: 0x0400043D RID: 1085
		private int length;
	}
}
