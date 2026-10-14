using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Motorola.Common.CommonLib
{
	// Token: 0x0200001E RID: 30
	public class EnDecryptStreamHelper : global::System.IDisposable
	{
		// Token: 0x060000AF RID: 175 RVA: 0x00003600 File Offset: 0x00001800
		private EnDecryptStreamHelper()
		{
			this.cmCrypto = new global::System.Security.Cryptography.RijndaelManaged();
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x00003613 File Offset: 0x00001813
		public static global::Motorola.Common.CommonLib.EnDecryptStreamHelper Instance
		{
			get
			{
				if (global::Motorola.Common.CommonLib.EnDecryptStreamHelper.instance == null)
				{
					global::Motorola.Common.CommonLib.EnDecryptStreamHelper.instance = new global::Motorola.Common.CommonLib.EnDecryptStreamHelper();
				}
				return global::Motorola.Common.CommonLib.EnDecryptStreamHelper.instance;
			}
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x0000362C File Offset: 0x0000182C
		public global::System.IO.Stream CreateEncryptStream(string id, global::System.IO.Stream nonEncryptStream)
		{
			byte[] key = this.GetKey(id);
			return new global::System.Security.Cryptography.CryptoStream(nonEncryptStream, this.cmCrypto.CreateEncryptor(key, key), global::System.Security.Cryptography.CryptoStreamMode.Write);
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00003655 File Offset: 0x00001855
		private global::System.IO.Stream CreateEncryptStream(global::System.IO.Stream nonEncryptStream)
		{
			return this.CreateEncryptStream("{F05EECA8-6D69-4079-94F2-516473BF57A2}", nonEncryptStream);
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00003664 File Offset: 0x00001864
		public global::System.IO.Stream CreateDecryptStream(string id, global::System.IO.Stream encryptedStream)
		{
			byte[] key = this.GetKey(id);
			return new global::System.Security.Cryptography.CryptoStream(encryptedStream, this.cmCrypto.CreateDecryptor(key, key), global::System.Security.Cryptography.CryptoStreamMode.Read);
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x0000368D File Offset: 0x0000188D
		private global::System.IO.Stream CreateDecryptStream(global::System.IO.Stream encryptedStream)
		{
			return this.CreateDecryptStream("{F05EECA8-6D69-4079-94F2-516473BF57A2}", encryptedStream);
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x0000369C File Offset: 0x0000189C
		private byte[] GetKey(string id)
		{
			byte[] bytes = new global::System.Text.UnicodeEncoding().GetBytes("{E88707E6-353F-46F3-8021-C4597593FA48}-" + id);
			int num = 16;
			byte[] array = new byte[num];
			array.Initialize();
			for (int i = 0; i < bytes.Length; i++)
			{
				int num2 = i % num;
				array[num2] = (array[num2] + bytes[i] & byte.MaxValue);
			}
			return array;
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x000036F8 File Offset: 0x000018F8
		private bool VerifyHeader(ref global::System.IO.Stream stream)
		{
			byte[] array = new byte[global::Motorola.Common.CommonLib.EnDecryptStreamHelper.HeaderBuffer.Length];
			stream.Read(array, 0, array.Length);
			return global::Motorola.Common.CommonLib.EnDecryptStreamHelper.GetString(array).Equals("{F2B1CF7F-1F5B-406F-B7B9-D3FD76231055}");
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00003734 File Offset: 0x00001934
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Reliability", "CA2000:DisposeObjectsBeforeLosingScope")]
		public global::System.IO.Stream CreateCryptoFlStream(string path, global::System.IO.FileAccess access)
		{
			global::System.IO.Stream stream = null;
			switch (access)
			{
			case global::System.IO.FileAccess.Read:
			{
				global::System.IO.FileMode mode = global::System.IO.FileMode.Open;
				global::System.IO.FileShare share = global::System.IO.FileShare.Read;
				global::System.IO.FileStream fileStream = new global::System.IO.FileStream(path, mode, access, share);
				if (fileStream.Length >= 80L)
				{
					global::System.IO.Stream stream2 = this.CreateDecryptStream(fileStream);
					if (!this.VerifyHeader(ref stream2))
					{
						try
						{
							fileStream.Close();
						}
						catch
						{
						}
						stream = new global::System.IO.FileStream(path, mode, access, share);
					}
					else
					{
						stream = stream2;
					}
				}
				break;
			}
			case global::System.IO.FileAccess.Write:
			{
				global::System.IO.FileMode mode2 = global::System.IO.FileMode.Create;
				global::System.IO.FileShare fileShare = global::System.IO.FileShare.None;
				global::System.IO.FileStream fileStream = this.createFileStream(path, mode2, access, fileShare);
				stream = this.CreateEncryptStream(fileStream);
				global::Motorola.Common.CommonLib.EnDecryptStreamHelper.AddHead(stream);
				break;
			}
			default:
				throw new global::System.Exception("Doesn't support the FileAccess value.");
			}
			return stream;
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x000037E4 File Offset: 0x000019E4
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Reliability", "CA2000:DisposeObjectsBeforeLosingScope")]
		public global::System.IO.Stream CreateCryptoFlStream(global::System.IO.Stream content, bool decrypt = true)
		{
			global::System.IO.Stream stream = null;
			if (decrypt)
			{
				if (content.Length >= 80L)
				{
					global::System.IO.Stream stream2 = this.CreateDecryptStream(content);
					if (!this.VerifyHeader(ref stream2))
					{
						stream = content;
					}
					else
					{
						stream = stream2;
					}
				}
			}
			else
			{
				stream = this.CreateEncryptStream(content);
				global::Motorola.Common.CommonLib.EnDecryptStreamHelper.AddHead(stream);
			}
			return stream;
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x0000382A File Offset: 0x00001A2A
		private static void AddHead(global::System.IO.Stream tempOutputStream)
		{
			tempOutputStream.Write(global::Motorola.Common.CommonLib.EnDecryptStreamHelper.HeaderBuffer, 0, global::Motorola.Common.CommonLib.EnDecryptStreamHelper.HeaderBuffer.Length);
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00003840 File Offset: 0x00001A40
		public byte[] Zip_then_Encrypt_ByteArray(byte[] inputByteArray)
		{
			byte[] buffer = global::Motorola.Common.CommonLib.EnDecryptStreamHelper.ZipByteArray(inputByteArray);
			byte[] result = null;
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(buffer))
			{
				using (global::System.IO.MemoryStream memoryStream2 = new global::System.IO.MemoryStream())
				{
					global::System.IO.Stream stream2;
					global::System.IO.Stream stream = stream2 = this.CreateEncryptStream(memoryStream2);
					try
					{
						global::Motorola.Common.CommonLib.EnDecryptStreamHelper.AddHead(stream);
						memoryStream.CopyTo(stream);
					}
					finally
					{
						if (stream2 != null)
						{
							((global::System.IDisposable)stream2).Dispose();
						}
					}
					result = memoryStream2.ToArray();
				}
			}
			return result;
		}

		// Token: 0x060000BB RID: 187 RVA: 0x000038D8 File Offset: 0x00001AD8
		public byte[] Decrypt_then_UnZip_ByteArray(byte[] inputByteArray)
		{
			byte[] array = null;
			if (inputByteArray.Length < 80)
			{
				array = inputByteArray;
			}
			else
			{
				using (global::System.IO.Stream stream = new global::System.IO.MemoryStream(inputByteArray))
				{
					global::System.IO.Stream sourceStream = this.CreateDecryptStream(stream);
					if (!this.VerifyHeader(ref sourceStream))
					{
						array = inputByteArray;
					}
					else
					{
						array = this.GetBytesFromStream(sourceStream);
						array = global::Motorola.Common.CommonLib.EnDecryptStreamHelper.UnZipByteArray(array);
					}
				}
			}
			return array;
		}

		// Token: 0x060000BC RID: 188 RVA: 0x0000393C File Offset: 0x00001B3C
		private static byte[] ZipByteArray(byte[] inputByteArray)
		{
			byte[] result = null;
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(inputByteArray))
			{
				using (global::System.IO.MemoryStream memoryStream2 = new global::System.IO.MemoryStream())
				{
					using (global::System.IO.Compression.DeflateStream deflateStream = new global::System.IO.Compression.DeflateStream(memoryStream2, global::System.IO.Compression.CompressionLevel.Fastest, true))
					{
						memoryStream.CopyTo(deflateStream);
					}
					result = memoryStream2.ToArray();
				}
			}
			return result;
		}

		// Token: 0x060000BD RID: 189 RVA: 0x000039BC File Offset: 0x00001BBC
		private static byte[] UnZipByteArray(byte[] outputByteArray)
		{
			byte[] result = null;
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream())
			{
				using (global::System.IO.MemoryStream memoryStream2 = new global::System.IO.MemoryStream(outputByteArray))
				{
					using (global::System.IO.Compression.DeflateStream deflateStream = new global::System.IO.Compression.DeflateStream(memoryStream2, global::System.IO.Compression.CompressionMode.Decompress, true))
					{
						deflateStream.CopyTo(memoryStream);
					}
				}
				result = memoryStream.ToArray();
			}
			return result;
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00003A3C File Offset: 0x00001C3C
		private global::System.IO.FileStream createFileStream(string path, global::System.IO.FileMode mode, global::System.IO.FileAccess access, global::System.IO.FileShare fileShare)
		{
			return new global::System.IO.FileStream(path, mode, access, fileShare);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00003A48 File Offset: 0x00001C48
		public byte[] GetBytesFromStream(global::System.IO.Stream sourceStream, global::System.Text.Encoding encoding)
		{
			byte[] array = new byte[0];
			using (global::System.IO.BinaryReader binaryReader = new global::System.IO.BinaryReader(sourceStream, encoding))
			{
				int count = 41943040;
				byte[] second;
				while ((second = binaryReader.ReadBytes(count)).Length > 0)
				{
					array = array.Concat(second).ToArray<byte>();
				}
			}
			return array;
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00003AA8 File Offset: 0x00001CA8
		public byte[] GetBytesFromStream(global::System.IO.Stream sourceStream)
		{
			return this.GetBytesFromStream(sourceStream, global::System.Text.Encoding.UTF8);
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00003AB8 File Offset: 0x00001CB8
		private void WriteBytesToStream(global::System.IO.Stream targetFileStream, byte[] buffer)
		{
			using (new global::System.IO.BinaryWriter(targetFileStream))
			{
				targetFileStream.Write(buffer, 0, buffer.Length);
			}
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00003AF4 File Offset: 0x00001CF4
		public bool IsEncryptedByMe(string filePath)
		{
			bool result;
			using (global::System.IO.Stream stream = new global::System.IO.FileStream(filePath, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read, global::System.IO.FileShare.Read))
			{
				if (stream.Length < 80L)
				{
					result = false;
				}
				else
				{
					global::System.IO.Stream stream2 = this.CreateDecryptStream(stream);
					if (!this.VerifyHeader(ref stream2))
					{
						result = false;
					}
					else
					{
						result = true;
					}
				}
			}
			return result;
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00003B50 File Offset: 0x00001D50
		private void EncryptFileToFile(string sourcePath, string targetPath)
		{
			using (global::System.IO.Stream stream = global::Motorola.Common.CommonLib.EnDecryptStreamHelper.Instance.CreateCryptoFlStream(sourcePath, global::System.IO.FileAccess.Read))
			{
				using (global::System.IO.Stream stream2 = global::Motorola.Common.CommonLib.EnDecryptStreamHelper.Instance.CreateCryptoFlStream(targetPath, global::System.IO.FileAccess.Write))
				{
					byte[] array = new byte[1048576];
					int count;
					while ((count = stream.Read(array, 0, array.Length)) > 0)
					{
						stream2.Write(array, 0, count);
					}
				}
			}
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00003BD4 File Offset: 0x00001DD4
		public void DecryptFileToFile(string sourcePath, string targetPath)
		{
			using (global::System.IO.Stream stream = global::Motorola.Common.CommonLib.EnDecryptStreamHelper.Instance.CreateCryptoFlStream(sourcePath, global::System.IO.FileAccess.Read))
			{
				using (global::System.IO.Stream stream2 = new global::System.IO.FileStream(targetPath, global::System.IO.FileMode.Create, global::System.IO.FileAccess.Write))
				{
					byte[] array = new byte[10485760];
					int count;
					while ((count = stream.Read(array, 0, array.Length)) > 0)
					{
						stream2.Write(array, 0, count);
					}
				}
			}
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00003C54 File Offset: 0x00001E54
		private static byte[] GetBytes(string str)
		{
			byte[] array = new byte[str.Length * 2];
			global::System.Buffer.BlockCopy(str.ToCharArray(), 0, array, 0, array.Length);
			return array;
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00003C84 File Offset: 0x00001E84
		private static string GetString(byte[] bytes)
		{
			char[] array = new char[bytes.Length / 2];
			global::System.Buffer.BlockCopy(bytes, 0, array, 0, bytes.Length);
			return new string(array);
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00003CAE File Offset: 0x00001EAE
		public void Dispose()
		{
			this.Dispose(true);
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00003CB7 File Offset: 0x00001EB7
		protected virtual void Dispose(bool disposing)
		{
			this.cmCrypto.Dispose();
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00003CC8 File Offset: 0x00001EC8
		~EnDecryptStreamHelper()
		{
			this.Dispose(false);
		}

		// Token: 0x040000E4 RID: 228
		private const string CrytoKey = "{E88707E6-353F-46F3-8021-C4597593FA48}";

		// Token: 0x040000E5 RID: 229
		private const int keySize = 128;

		// Token: 0x040000E6 RID: 230
		private const string defaultID = "{F05EECA8-6D69-4079-94F2-516473BF57A2}";

		// Token: 0x040000E7 RID: 231
		private const string Header = "{F2B1CF7F-1F5B-406F-B7B9-D3FD76231055}";

		// Token: 0x040000E8 RID: 232
		private static global::Motorola.Common.CommonLib.EnDecryptStreamHelper instance;

		// Token: 0x040000E9 RID: 233
		private global::System.Security.Cryptography.RijndaelManaged cmCrypto;

		// Token: 0x040000EA RID: 234
		private static byte[] HeaderBuffer = global::Motorola.Common.CommonLib.EnDecryptStreamHelper.GetBytes("{F2B1CF7F-1F5B-406F-B7B9-D3FD76231055}");
	}
}
