using System;
using System.IO;
using System.IO.Compression;
using System.Security.Cryptography;
using System.Text;

namespace Motorola.Common.CommonLib
{
	// Token: 0x0200001D RID: 29
	public class MetaDataEnDecryptHelper : global::System.IDisposable
	{
		// Token: 0x060000A4 RID: 164 RVA: 0x0000300B File Offset: 0x0000120B
		private MetaDataEnDecryptHelper()
		{
			this.cryptoService = new global::System.Security.Cryptography.RijndaelManaged();
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x00003034 File Offset: 0x00001234
		public static global::Motorola.Common.CommonLib.MetaDataEnDecryptHelper Instance
		{
			get
			{
				if (global::Motorola.Common.CommonLib.MetaDataEnDecryptHelper.instance == null)
				{
					global::Motorola.Common.CommonLib.MetaDataEnDecryptHelper.instance = new global::Motorola.Common.CommonLib.MetaDataEnDecryptHelper();
				}
				return global::Motorola.Common.CommonLib.MetaDataEnDecryptHelper.instance;
			}
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x0000304C File Offset: 0x0000124C
		public void EncryptFileToFile(string filePath, string outputFileName, bool compress)
		{
			try
			{
				if (!string.IsNullOrEmpty(filePath) && !string.IsNullOrEmpty(outputFileName))
				{
					if (global::System.IO.File.Exists(global::System.IO.Path.GetFullPath(filePath)))
					{
						this.cryptoService.Key = global::System.Convert.FromBase64String(this.KEY + "=");
						this.cryptoService.IV = global::System.Convert.FromBase64String(this.IV + "==");
						byte[] array = null;
						byte[] array2 = null;
						using (global::System.IO.FileStream fileStream = new global::System.IO.FileStream(filePath, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read))
						{
							array = new byte[fileStream.Length];
							fileStream.Read(array, 0, array.Length);
						}
						this.EncryptByteArray(array, ref array2, compress, this.cryptoService.CreateEncryptor());
						using (global::System.IO.FileStream fileStream2 = new global::System.IO.FileStream(outputFileName, global::System.IO.FileMode.Create, global::System.IO.FileAccess.Write))
						{
							fileStream2.Write(array2, 0, array2.Length);
						}
					}
				}
			}
			catch
			{
				throw new global::System.Exception("Encryption failed.");
			}
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00003160 File Offset: 0x00001360
		private void EncryptByteArray(byte[] bufferIn, ref byte[] bufferOut, bool compress, global::System.Security.Cryptography.ICryptoTransform transform)
		{
			if (bufferIn == null || bufferIn.Length <= 0)
			{
				return;
			}
			if (compress)
			{
				using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream())
				{
					using (global::System.IO.Compression.GZipStream gzipStream = new global::System.IO.Compression.GZipStream(memoryStream, global::System.IO.Compression.CompressionMode.Compress, true))
					{
						gzipStream.Write(bufferIn, 0, bufferIn.Length);
					}
					bufferIn = memoryStream.ToArray();
				}
			}
			using (global::System.IO.MemoryStream memoryStream2 = new global::System.IO.MemoryStream())
			{
				using (global::System.Security.Cryptography.CryptoStream cryptoStream = new global::System.Security.Cryptography.CryptoStream(memoryStream2, transform, global::System.Security.Cryptography.CryptoStreamMode.Write))
				{
					cryptoStream.Write(bufferIn, 0, bufferIn.Length);
					cryptoStream.FlushFinalBlock();
				}
				bufferOut = memoryStream2.ToArray();
			}
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x0000322C File Offset: 0x0000142C
		public global::System.IO.Stream DecryptStreamToStream(global::System.IO.Stream stream, bool decompress)
		{
			global::System.IO.Stream result;
			try
			{
				if (stream == null)
				{
					result = null;
				}
				else
				{
					this.cryptoService.Key = global::System.Convert.FromBase64String(this.KEY + "=");
					this.cryptoService.IV = global::System.Convert.FromBase64String(this.IV + "==");
					byte[] buffer = null;
					byte[] array = new byte[stream.Length];
					stream.Read(array, 0, array.Length);
					stream.Seek(0L, global::System.IO.SeekOrigin.Begin);
					this.DecryptByteArray(array, ref buffer, decompress, this.cryptoService.CreateDecryptor());
					global::System.IO.Stream stream2 = new global::System.IO.MemoryStream(buffer);
					result = stream2;
				}
			}
			catch
			{
				throw new global::System.Exception("Decryption failed.");
			}
			return result;
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x000032E8 File Offset: 0x000014E8
		public global::System.IO.Stream DecryptFileToStream(string filePath, bool decompress)
		{
			global::System.IO.Stream result;
			try
			{
				using (global::System.IO.Stream stream = new global::System.IO.FileStream(filePath, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read))
				{
					result = this.DecryptStreamToStream(stream, decompress);
				}
			}
			catch (global::System.IO.IOException)
			{
				throw new global::System.Exception("Open file failed.");
			}
			catch
			{
				throw new global::System.Exception("Decryption failed.");
			}
			return result;
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00003354 File Offset: 0x00001554
		private global::System.Text.Encoding DecryptByteArray(byte[] byteIn, ref byte[] byteOut, bool decompress, global::System.Security.Cryptography.ICryptoTransform transform)
		{
			global::System.Text.Encoding encoding = null;
			byte[] array = new byte[byteIn.Length];
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(byteIn))
			{
				using (global::System.Security.Cryptography.CryptoStream cryptoStream = new global::System.Security.Cryptography.CryptoStream(memoryStream, transform, global::System.Security.Cryptography.CryptoStreamMode.Read))
				{
					cryptoStream.Read(array, 0, array.Length);
				}
			}
			if (decompress)
			{
				using (global::System.IO.MemoryStream memoryStream2 = new global::System.IO.MemoryStream(array))
				{
					using (global::System.IO.Compression.GZipStream gzipStream = new global::System.IO.Compression.GZipStream(memoryStream2, global::System.IO.Compression.CompressionMode.Decompress, false))
					{
						byte[] array2 = new byte[4096];
						using (global::System.IO.MemoryStream memoryStream3 = new global::System.IO.MemoryStream())
						{
							int count;
							while ((count = gzipStream.Read(array2, 0, array2.Length)) > 0)
							{
								memoryStream3.Write(array2, 0, count);
							}
							array = memoryStream3.ToArray();
						}
					}
				}
			}
			byte b = array[0];
			if (b != 239)
			{
				switch (b)
				{
				case 254:
					if (array[1].Equals(255))
					{
						byteOut = new byte[array.Length - 2];
						global::System.Array.Copy(array, 2, byteOut, 0, array.Length - 2);
						encoding = new global::System.Text.UnicodeEncoding();
						this.RemoveTrailing(ref byteOut, encoding);
					}
					break;
				case 255:
					if (array[1].Equals(254))
					{
						byteOut = new byte[array.Length - 2];
						global::System.Array.Copy(array, 2, byteOut, 0, array.Length - 2);
						encoding = new global::System.Text.UnicodeEncoding();
						this.RemoveTrailing(ref byteOut, encoding);
					}
					break;
				default:
					byteOut = new byte[array.Length];
					global::System.Array.Copy(array, 0, byteOut, 0, array.Length);
					encoding = new global::System.Text.UTF8Encoding();
					this.RemoveTrailing(ref byteOut, encoding);
					break;
				}
			}
			else if (array[1].Equals(187) && array[2].Equals(191))
			{
				byteOut = new byte[array.Length - 3];
				global::System.Array.Copy(array, 3, byteOut, 0, array.Length - 3);
				encoding = new global::System.Text.UTF8Encoding();
				this.RemoveTrailing(ref byteOut, encoding);
			}
			return encoding;
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00003588 File Offset: 0x00001788
		private void RemoveTrailing(ref byte[] buffer, global::System.Text.Encoding encType)
		{
			string text = encType.GetString(buffer);
			string text2 = text;
			char[] trimChars = new char[1];
			text = text2.TrimEnd(trimChars);
			buffer = encType.GetBytes(text);
		}

		// Token: 0x060000AC RID: 172 RVA: 0x000035B6 File Offset: 0x000017B6
		public void Dispose()
		{
			this.Dispose(true);
		}

		// Token: 0x060000AD RID: 173 RVA: 0x000035BF File Offset: 0x000017BF
		protected virtual void Dispose(bool disposing)
		{
			this.cryptoService.Dispose();
		}

		// Token: 0x060000AE RID: 174 RVA: 0x000035D0 File Offset: 0x000017D0
		~MetaDataEnDecryptHelper()
		{
			this.Dispose(false);
		}

		// Token: 0x040000D4 RID: 212
		private const byte UTF8_BOM1 = 239;

		// Token: 0x040000D5 RID: 213
		private const byte UTF8_BOM2 = 187;

		// Token: 0x040000D6 RID: 214
		private const byte UTF8_BOM3 = 191;

		// Token: 0x040000D7 RID: 215
		private const byte UTF16_BE_BOM1 = 254;

		// Token: 0x040000D8 RID: 216
		private const byte UTF16_BE_BOM2 = 255;

		// Token: 0x040000D9 RID: 217
		private const byte UTF16_LE_BOM1 = 255;

		// Token: 0x040000DA RID: 218
		private const byte UTF16_LE_BOM2 = 254;

		// Token: 0x040000DB RID: 219
		private const int UTF8_BOM_SIZE = 3;

		// Token: 0x040000DC RID: 220
		private const int UTF16_BOM_SIZE = 2;

		// Token: 0x040000DD RID: 221
		private const int READ_SIZE = 1024;

		// Token: 0x040000DE RID: 222
		private const int ZERO = 0;

		// Token: 0x040000DF RID: 223
		private const char NULL_CHAR = '\0';

		// Token: 0x040000E0 RID: 224
		private static global::Motorola.Common.CommonLib.MetaDataEnDecryptHelper instance;

		// Token: 0x040000E1 RID: 225
		private global::System.Security.Cryptography.RijndaelManaged cryptoService;

		// Token: 0x040000E2 RID: 226
		private string KEY = "RmFAUjxmbWpLNmkqUUVWfUhoQ1Usd1BOP0ZpLVg7USQ";

		// Token: 0x040000E3 RID: 227
		private string IV = "czp8KVtQfVU/bj9BbVBnIw";
	}
}
