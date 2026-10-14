using System;
using System.IO;
using System.IO.Compression;
using System.Security.Cryptography;
using System.Text;

namespace Motorola.Common.Communication.TetraSecurity
{
	// Token: 0x02000004 RID: 4
	public static class CryptAndZip
	{
		// Token: 0x0600001C RID: 28 RVA: 0x000024DC File Offset: 0x000014DC
		public static bool CompressMixFile(byte[] bufferIn, ref byte[] bufferOut, bool compressed, byte[] key, byte[] IV)
		{
			byte[] bufferIn2 = new byte[0];
			if (compressed)
			{
				global::Motorola.Common.Communication.TetraSecurity.CryptAndZip.CompressFile(bufferIn, ref bufferIn2);
			}
			else
			{
				bufferIn2 = bufferIn;
			}
			return global::Motorola.Common.Communication.TetraSecurity.CryptAndZip.MixFile(bufferIn2, ref bufferOut, key, IV);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x0000250C File Offset: 0x0000150C
		public static bool CompressMixFile(string sourceFile, string targetFile, bool compressed, byte[] key, byte[] IV)
		{
			string text = global::Motorola.Common.Communication.TetraSecurity.CryptAndZip.GetTMPFileName(targetFile);
			if (compressed)
			{
				global::Motorola.Common.Communication.TetraSecurity.CryptAndZip.CompressFile(sourceFile, text);
			}
			else
			{
				text = sourceFile;
			}
			bool result = global::Motorola.Common.Communication.TetraSecurity.CryptAndZip.MixFile(text, targetFile, key, IV);
			if (!text.Equals(sourceFile))
			{
				global::Motorola.Common.Communication.TetraSecurity.CryptAndZip.SafeDeleteFile(text);
			}
			return result;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x0000254C File Offset: 0x0000154C
		public static void UnmixDecompressFile(byte[] bufferIn, ref byte[] bufferOut, bool compressed, byte[] key, byte[] IV)
		{
			byte[] array = new byte[0];
			if (global::Motorola.Common.Communication.TetraSecurity.CryptAndZip.UnMixFile(bufferIn, ref array, key, IV))
			{
				if (compressed)
				{
					global::Motorola.Common.Communication.TetraSecurity.CryptAndZip.DecompressFile(array, ref bufferOut);
					return;
				}
				bufferOut = array;
			}
		}

		// Token: 0x0600001F RID: 31 RVA: 0x0000257C File Offset: 0x0000157C
		public static void UnmixDecompressFile(string sourceFile, string targetFile, bool compressed, byte[] key, byte[] IV)
		{
			string tmpfileName = global::Motorola.Common.Communication.TetraSecurity.CryptAndZip.GetTMPFileName(targetFile);
			if (global::Motorola.Common.Communication.TetraSecurity.CryptAndZip.UnmixFile(sourceFile, tmpfileName, key, IV))
			{
				if (compressed)
				{
					global::Motorola.Common.Communication.TetraSecurity.CryptAndZip.DecompressFile(tmpfileName, targetFile);
				}
				else
				{
					global::Motorola.Common.Communication.TetraSecurity.CryptAndZip.RemoveFile(tmpfileName, targetFile);
				}
			}
			global::Motorola.Common.Communication.TetraSecurity.CryptAndZip.SafeDeleteFile(tmpfileName);
		}

		// Token: 0x06000020 RID: 32 RVA: 0x000025B8 File Offset: 0x000015B8
		private static void CompressFile(byte[] bufferIn, ref byte[] bufferOut)
		{
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream())
			{
				using (global::System.IO.Compression.GZipStream gzipStream = new global::System.IO.Compression.GZipStream(memoryStream, global::System.IO.Compression.CompressionMode.Compress, true))
				{
					gzipStream.Write(bufferIn, 0, bufferIn.Length);
				}
				memoryStream.Seek(0L, global::System.IO.SeekOrigin.Begin);
				bufferOut = memoryStream.ToArray();
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002628 File Offset: 0x00001628
		private static void DecompressFile(byte[] bufferIn, ref byte[] bufferOut)
		{
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(bufferIn))
			{
				using (global::System.IO.Compression.GZipStream gzipStream = new global::System.IO.Compression.GZipStream(memoryStream, global::System.IO.Compression.CompressionMode.Decompress, true))
				{
					byte[] sourceArray = null;
					int num = global::Motorola.Common.Communication.TetraSecurity.CryptAndZip.DecompressFromStream(gzipStream, (int)memoryStream.Length * 10, out sourceArray);
					bufferOut = new byte[num];
					global::System.Array.Copy(sourceArray, bufferOut, num);
				}
			}
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000026A0 File Offset: 0x000016A0
		private static void CompressFile(string sourceFile, string destFile)
		{
			global::Motorola.Common.Communication.TetraSecurity.CryptAndZip.CompressDecompressFile(sourceFile, destFile, global::System.IO.Compression.CompressionMode.Compress);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000026AA File Offset: 0x000016AA
		private static void DecompressFile(string sourceFile, string destFile)
		{
			global::Motorola.Common.Communication.TetraSecurity.CryptAndZip.CompressDecompressFile(sourceFile, destFile, global::System.IO.Compression.CompressionMode.Decompress);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000026B4 File Offset: 0x000016B4
		private static bool MixFile(string sourceFile, string targetFile, byte[] key, byte[] IV)
		{
			bool result = false;
			string tmpfileName = global::Motorola.Common.Communication.TetraSecurity.CryptAndZip.GetTMPFileName(targetFile);
			using (global::System.IO.FileStream fileStream = new global::System.IO.FileStream(sourceFile, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read, global::System.IO.FileShare.Read))
			{
				using (global::System.IO.FileStream fileStream2 = new global::System.IO.FileStream(tmpfileName, global::System.IO.FileMode.Create, global::System.IO.FileAccess.Write, global::System.IO.FileShare.Write))
				{
					result = global::Motorola.Common.Communication.TetraSecurity.CryptAndZip.MixFile<global::System.IO.FileStream>(fileStream, fileStream2, key, IV);
				}
			}
			global::Motorola.Common.Communication.TetraSecurity.CryptAndZip.RemoveFile(tmpfileName, targetFile);
			return result;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002724 File Offset: 0x00001724
		private static bool UnmixFile(string sourceFile, string targetFile, byte[] key, byte[] IV)
		{
			bool result = false;
			string tmpfileName = global::Motorola.Common.Communication.TetraSecurity.CryptAndZip.GetTMPFileName(targetFile);
			using (global::System.IO.FileStream fileStream = new global::System.IO.FileStream(sourceFile, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read, global::System.IO.FileShare.Read))
			{
				using (global::System.IO.FileStream fileStream2 = new global::System.IO.FileStream(tmpfileName, global::System.IO.FileMode.Create, global::System.IO.FileAccess.Write, global::System.IO.FileShare.Write))
				{
					result = global::Motorola.Common.Communication.TetraSecurity.CryptAndZip.UnmixFile<global::System.IO.FileStream>(fileStream, fileStream2, key, IV);
				}
			}
			global::Motorola.Common.Communication.TetraSecurity.CryptAndZip.RemoveFile(tmpfileName, targetFile);
			return result;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002794 File Offset: 0x00001794
		private static bool MixFile(byte[] bufferIn, ref byte[] bufferOut, byte[] key, byte[] IV)
		{
			bool flag = false;
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(bufferIn))
			{
				using (global::System.IO.MemoryStream memoryStream2 = new global::System.IO.MemoryStream())
				{
					flag = global::Motorola.Common.Communication.TetraSecurity.CryptAndZip.MixFile<global::System.IO.MemoryStream>(memoryStream, memoryStream2, key, IV);
					if (flag)
					{
						bufferOut = memoryStream2.ToArray();
					}
				}
			}
			return flag;
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000027FC File Offset: 0x000017FC
		private static bool UnMixFile(byte[] bufferIn, ref byte[] bufferOut, byte[] key, byte[] IV)
		{
			bool flag = false;
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(bufferIn))
			{
				using (global::System.IO.MemoryStream memoryStream2 = new global::System.IO.MemoryStream())
				{
					flag = global::Motorola.Common.Communication.TetraSecurity.CryptAndZip.UnmixFile<global::System.IO.MemoryStream>(memoryStream, memoryStream2, key, IV);
					if (flag)
					{
						bufferOut = memoryStream2.ToArray();
					}
				}
			}
			return flag;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002864 File Offset: 0x00001864
		private static bool MixBlock(byte[] bufferIn, ref byte[] bufferOut, byte[] key, byte[] IV)
		{
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(bufferIn))
			{
				using (global::Motorola.Common.Communication.TetraSecurity.CEncodeDecode cencodeDecode = new global::Motorola.Common.Communication.TetraSecurity.CEncodeDecode())
				{
					byte[] array = new byte[memoryStream.Length];
					memoryStream.Seek(0L, global::System.IO.SeekOrigin.Begin);
					memoryStream.Read(array, 0, array.Length);
					cencodeDecode.EncryptFile(array, ref bufferOut, key, IV);
				}
			}
			return true;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000028E4 File Offset: 0x000018E4
		private static void UnmixBlock(byte[] bufferIn, ref byte[] bufferOut, byte[] key, byte[] IV)
		{
			using (global::Motorola.Common.Communication.TetraSecurity.CEncodeDecode cencodeDecode = new global::Motorola.Common.Communication.TetraSecurity.CEncodeDecode())
			{
				cencodeDecode.DecryptFile(bufferIn, ref bufferOut, key, IV);
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002920 File Offset: 0x00001920
		private static void UnmixBlock_Old(byte[] bufferIn, ref byte[] bufferOut, byte[] key, byte[] IV)
		{
			using (global::Motorola.Common.Communication.TetraSecurity.CEncodeDecode cencodeDecode = new global::Motorola.Common.Communication.TetraSecurity.CEncodeDecode())
			{
				cencodeDecode.DecryptFile_Old(bufferIn, ref bufferOut, key, IV);
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x0000295C File Offset: 0x0000195C
		private static void CompressDecompressFile(string sourceFile, string destFile, global::System.IO.Compression.CompressionMode mode)
		{
			string tmpfileName = global::Motorola.Common.Communication.TetraSecurity.CryptAndZip.GetTMPFileName(destFile);
			using (global::System.IO.FileStream fileStream = new global::System.IO.FileStream(sourceFile, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read, global::System.IO.FileShare.Read))
			{
				byte[] array = new byte[fileStream.Length];
				byte[] array2 = new byte[0];
				fileStream.Read(array, 0, array.Length);
				switch (mode)
				{
				case global::System.IO.Compression.CompressionMode.Decompress:
					global::Motorola.Common.Communication.TetraSecurity.CryptAndZip.DecompressFile(array, ref array2);
					break;
				case global::System.IO.Compression.CompressionMode.Compress:
					global::Motorola.Common.Communication.TetraSecurity.CryptAndZip.CompressFile(array, ref array2);
					break;
				}
				using (global::System.IO.FileStream fileStream2 = new global::System.IO.FileStream(tmpfileName, global::System.IO.FileMode.Create, global::System.IO.FileAccess.Write, global::System.IO.FileShare.Write))
				{
					fileStream2.Write(array2, 0, array2.Length);
				}
			}
			global::Motorola.Common.Communication.TetraSecurity.CryptAndZip.RemoveFile(tmpfileName, destFile);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002A14 File Offset: 0x00001A14
		private static bool MixFile<T>(T plainStream, T cryptyStream, byte[] key, byte[] IV)
		{
			global::System.IO.Stream stream = plainStream as global::System.IO.Stream;
			global::System.IO.Stream stream2 = cryptyStream as global::System.IO.Stream;
			if (stream == null || stream2 == null)
			{
				return false;
			}
			int num = 0;
			byte[] array = new byte[524288];
			byte[] array2 = new byte[524296];
			try
			{
				bool flag = true;
				while ((long)num < stream.Length + 64L)
				{
					int num2;
					if (flag)
					{
						global::System.Array.Copy(global::System.BitConverter.GetBytes(stream.Length), array, 4);
						num2 = stream.Read(array, 64, array.Length - 64);
						num2 += 64;
						flag = false;
					}
					else
					{
						num2 = stream.Read(array, 0, array.Length);
					}
					if (num2 != array.Length)
					{
						global::System.Array.Resize<byte>(ref array, num2);
					}
					global::Motorola.Common.Communication.TetraSecurity.CryptAndZip.MixBlock(array, ref array2, key, IV);
					stream2.Write(array2, 0, array2.Length);
					num += num2;
				}
			}
			catch (global::System.Exception)
			{
				throw;
			}
			return true;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002AF4 File Offset: 0x00001AF4
		private static bool UnmixFile<T>(T cryptStream, T plainStream, byte[] key, byte[] IV)
		{
			global::System.IO.Stream stream = cryptStream as global::System.IO.Stream;
			global::System.IO.Stream stream2 = plainStream as global::System.IO.Stream;
			if (stream2 == null || stream == null)
			{
				return false;
			}
			int num = 0;
			byte[] array = new byte[524296];
			byte[] array2 = new byte[524296];
			int num2 = stream.Read(array, 0, array.Length);
			if (524296 != num2)
			{
				global::System.Array.Resize<byte>(ref array, num2);
			}
			int num3 = 0;
			bool flag = global::Motorola.Common.Communication.TetraSecurity.CryptAndZip.IsNewCryptFormat((int)stream.Length, array, key, IV, ref array2, ref num, ref num3);
			int i = num3;
			if (flag)
			{
				try
				{
					int num4 = global::System.Math.Min(524224, i);
					i -= num4;
					stream2.Write(array2, 64, num4);
					while (i > 0)
					{
						num2 = stream.Read(array, 0, array.Length);
						if (524296 != num2)
						{
							global::System.Array.Resize<byte>(ref array, num2);
						}
						global::Motorola.Common.Communication.TetraSecurity.CryptAndZip.UnmixBlock(array, ref array2, key, IV);
						num4 = global::System.Math.Min(524288, i);
						i -= num4;
						stream2.Write(array2, 0, num4);
					}
				}
				catch
				{
					throw;
				}
			}
			if (!flag)
			{
				stream.Seek(0L, global::System.IO.SeekOrigin.Begin);
				stream2.Seek(0L, global::System.IO.SeekOrigin.Begin);
				try
				{
					array = new byte[stream.Length];
					if (array.Length != stream.Read(array, 0, array.Length))
					{
						throw new global::System.Exception("Error happened when read file!");
					}
					array2 = new byte[0];
					global::Motorola.Common.Communication.TetraSecurity.CryptAndZip.UnmixBlock_Old(array, ref array2, key, IV);
					stream2.Write(array2, 0, array2.Length);
				}
				catch (global::System.Exception)
				{
					throw;
				}
			}
			return true;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002C78 File Offset: 0x00001C78
		private static string GetTMPFileName(string refName)
		{
			string text = string.Empty;
			int num = 0;
			for (;;)
			{
				text = string.Concat(new object[]
				{
					refName,
					num,
					".tmp",
					global::System.IO.Path.GetExtension(refName)
				});
				if (!global::System.IO.File.Exists(text))
				{
					break;
				}
				num++;
			}
			return text;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002CC8 File Offset: 0x00001CC8
		private static bool IsNewCryptFormat(int fileLength, byte[] firstBuffer, byte[] key, byte[] IV, ref byte[] firstBlockBuffer, ref int readedBytesLength, ref int nFilePlainLength)
		{
			try
			{
				global::Motorola.Common.Communication.TetraSecurity.CryptAndZip.UnmixBlock(firstBuffer, ref firstBlockBuffer, key, IV);
			}
			catch
			{
				return false;
			}
			byte[] array = new byte[4];
			global::System.Array.Copy(firstBlockBuffer, array, 4);
			int num = global::System.BitConverter.ToInt32(array, 0);
			readedBytesLength = firstBuffer.Length;
			nFilePlainLength = num;
			int num2 = (num + 64) / 524288 * 8;
			return num + 64 + num2 < fileLength && num + 64 + num2 + 8 >= fileLength;
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002D40 File Offset: 0x00001D40
		private static void SafeDeleteFile(string fileName)
		{
			if (global::System.IO.File.Exists(fileName))
			{
				global::System.IO.File.Delete(fileName);
			}
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002D50 File Offset: 0x00001D50
		private static void RemoveFile(string oldFileName, string newFileName)
		{
			if (global::System.IO.File.Exists(oldFileName))
			{
				if (global::System.IO.File.Exists(newFileName))
				{
					global::System.IO.File.Delete(newFileName);
				}
				global::System.IO.File.Move(oldFileName, newFileName);
				global::System.IO.File.Delete(oldFileName);
			}
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002D78 File Offset: 0x00001D78
		private static int DecompressFromStream(global::System.IO.Stream stream, int length, out byte[] buffer)
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

		// Token: 0x06000033 RID: 51 RVA: 0x00002DDC File Offset: 0x00001DDC
		public static byte[] EncryptData(byte[] data, byte[] desKey, byte[] desIV)
		{
			byte[] result = null;
			global::System.IO.MemoryStream memoryStream = null;
			global::System.Security.Cryptography.TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = null;
			global::System.Security.Cryptography.CryptoStream cryptoStream = null;
			bool flag = false;
			try
			{
				if (data == null || desKey == null || desIV == null)
				{
					global::Motorola.Common.Communication.TetraSecurity.CSecureException ex = new global::Motorola.Common.Communication.TetraSecurity.CSecureException(2388U, "Secure", "EncryptData", global::System.Environment.StackTrace.ToString());
					throw ex;
				}
				memoryStream = new global::System.IO.MemoryStream();
				tripleDESCryptoServiceProvider = new global::System.Security.Cryptography.TripleDESCryptoServiceProvider();
				cryptoStream = new global::System.Security.Cryptography.CryptoStream(memoryStream, tripleDESCryptoServiceProvider.CreateEncryptor(desKey, desIV), global::System.Security.Cryptography.CryptoStreamMode.Write);
				cryptoStream.Write(data, 0, data.Length);
				cryptoStream.Close();
				result = memoryStream.ToArray();
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
				if (tripleDESCryptoServiceProvider != null)
				{
					tripleDESCryptoServiceProvider.Dispose();
				}
				if (cryptoStream != null && !flag)
				{
					cryptoStream.Close();
				}
				if (memoryStream != null)
				{
					memoryStream.Close();
				}
			}
			return result;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002EE0 File Offset: 0x00001EE0
		public static byte[] DecryptData(byte[] data, byte[] desKey, byte[] desIV)
		{
			byte[] result = null;
			global::System.IO.MemoryStream memoryStream = null;
			global::System.Security.Cryptography.TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = null;
			global::System.Security.Cryptography.CryptoStream cryptoStream = null;
			bool flag = false;
			try
			{
				if (data == null || desKey == null || desIV == null)
				{
					global::Motorola.Common.Communication.TetraSecurity.CSecureException ex = new global::Motorola.Common.Communication.TetraSecurity.CSecureException(2388U, "Secure", "DecryptData", global::System.Environment.StackTrace.ToString());
					throw ex;
				}
				memoryStream = new global::System.IO.MemoryStream();
				tripleDESCryptoServiceProvider = new global::System.Security.Cryptography.TripleDESCryptoServiceProvider();
				cryptoStream = new global::System.Security.Cryptography.CryptoStream(memoryStream, tripleDESCryptoServiceProvider.CreateDecryptor(desKey, desIV), global::System.Security.Cryptography.CryptoStreamMode.Write);
				cryptoStream.Write(data, 0, data.Length);
				cryptoStream.Close();
				flag = true;
				result = memoryStream.ToArray();
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
			finally
			{
				if (tripleDESCryptoServiceProvider != null)
				{
					tripleDESCryptoServiceProvider.Dispose();
				}
				if (cryptoStream != null && !flag)
				{
					cryptoStream.Close();
				}
				if (memoryStream != null)
				{
					memoryStream.Close();
				}
			}
			return result;
		}

		// Token: 0x0400042E RID: 1070
		private const int PlainTexBlockSize = 524288;

		// Token: 0x0400042F RID: 1071
		private const int CryptMoreThanPlainSize = 8;

		// Token: 0x04000430 RID: 1072
		private const int CryptTextBlockSize = 524296;

		// Token: 0x04000431 RID: 1073
		private const string TmpFileName = ".tmp";

		// Token: 0x04000432 RID: 1074
		private const int HeaderBytesLen = 64;

		// Token: 0x04000433 RID: 1075
		private const int FileLengthBytesLen = 4;

		// Token: 0x04000434 RID: 1076
		public static byte[] S19EncryptionHeader = global::System.Text.Encoding.ASCII.GetBytes("RecordHeader");
	}
}
