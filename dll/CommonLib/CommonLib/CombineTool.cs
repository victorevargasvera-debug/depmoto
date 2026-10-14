using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using Motorola.Common.Communication.CommonUtil;

namespace Motorola.Common.CommonLib
{
	// Token: 0x02000005 RID: 5
	public class CombineTool
	{
		// Token: 0x0600000E RID: 14 RVA: 0x00002140 File Offset: 0x00000340
		public static byte[] Encode(string pbaFullPath, object deviceInfo)
		{
			byte[] array = null;
			byte[] array2 = null;
			global::System.IO.Stream stream = null;
			global::System.IO.Stream stream2 = null;
			global::System.IO.BinaryReader binaryReader = null;
			global::System.IO.BinaryReader binaryReader2 = null;
			try
			{
				stream = global::Motorola.Common.CommonLib.EnDecryptStreamHelper.Instance.CreateCryptoFlStream(pbaFullPath, global::System.IO.FileAccess.Read);
				stream2 = new global::System.IO.MemoryStream();
				global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter binaryFormatter = new global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
				binaryFormatter.Serialize(stream2, deviceInfo);
				binaryReader = new global::System.IO.BinaryReader(stream);
				binaryReader2 = new global::System.IO.BinaryReader(stream2);
				binaryReader2.BaseStream.Position = 0L;
				array = global::Motorola.Common.CommonLib.EnDecryptStreamHelper.Instance.GetBytesFromStream(stream, global::System.Text.Encoding.UTF8);
				array2 = binaryReader2.ReadBytes((int)binaryReader2.BaseStream.Length);
				binaryReader2.Read(array2, 0, (int)binaryReader2.BaseStream.Length);
			}
			finally
			{
				if (binaryReader != null)
				{
					binaryReader.Close();
					stream = null;
				}
				if (binaryReader2 != null)
				{
					binaryReader2.Close();
					stream2 = null;
				}
				if (stream != null)
				{
					stream.Close();
				}
				if (stream2 != null)
				{
					stream2.Close();
				}
			}
			byte[] inputByteArray = global::Motorola.Common.CommonLib.CombineTool.CombineArray<byte>(new byte[][]
			{
				global::Motorola.Common.CommonLib.CombineTool._magicHeader,
				global::Motorola.Common.CommonLib.CombineTool._version,
				global::System.BitConverter.GetBytes(array.Length),
				array,
				global::System.BitConverter.GetBytes(array2.Length),
				array2
			});
			byte[] content = global::Motorola.Common.CommonLib.EnDecryptStreamHelper.Instance.Zip_then_Encrypt_ByteArray(inputByteArray);
			return global::Motorola.Common.Communication.CommonUtil.CopyRightHandler.Instance.AddCopyRightHeader(content);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x0000227C File Offset: 0x0000047C
		public static byte[] Encode(string pbaFullPath, string deviceInfoFullPath)
		{
			if (!global::System.IO.File.Exists(pbaFullPath))
			{
				throw new global::System.ApplicationException();
			}
			if (!global::System.IO.File.Exists(deviceInfoFullPath))
			{
				throw new global::System.ApplicationException();
			}
			byte[] result;
			using (global::System.IO.Stream stream = global::Motorola.Common.CommonLib.EnDecryptStreamHelper.Instance.CreateCryptoFlStream(pbaFullPath, global::System.IO.FileAccess.Read))
			{
				using (global::System.IO.Stream stream2 = global::Motorola.Common.CommonLib.EnDecryptStreamHelper.Instance.CreateCryptoFlStream(deviceInfoFullPath, global::System.IO.FileAccess.Read))
				{
					byte[] bytesFromStream = global::Motorola.Common.CommonLib.EnDecryptStreamHelper.Instance.GetBytesFromStream(stream, global::System.Text.Encoding.UTF8);
					byte[] bytesFromStream2 = global::Motorola.Common.CommonLib.EnDecryptStreamHelper.Instance.GetBytesFromStream(stream2, global::System.Text.Encoding.ASCII);
					byte[] inputByteArray = global::Motorola.Common.CommonLib.CombineTool.CombineArray<byte>(new byte[][]
					{
						global::Motorola.Common.CommonLib.CombineTool._magicHeader,
						global::Motorola.Common.CommonLib.CombineTool._version,
						global::System.BitConverter.GetBytes(bytesFromStream.Length),
						bytesFromStream,
						global::System.BitConverter.GetBytes(bytesFromStream2.Length),
						bytesFromStream2
					});
					byte[] content = global::Motorola.Common.CommonLib.EnDecryptStreamHelper.Instance.Zip_then_Encrypt_ByteArray(inputByteArray);
					byte[] array = global::Motorola.Common.Communication.CommonUtil.CopyRightHandler.Instance.AddCopyRightHeader(content);
					result = array;
				}
			}
			return result;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x0000237C File Offset: 0x0000057C
		public static byte[] Encode(byte[] pbaBytes, object deviceInfo)
		{
			global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter binaryFormatter = new global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
			byte[] result;
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream())
			{
				binaryFormatter.Serialize(memoryStream, deviceInfo);
				byte[] array = memoryStream.ToArray();
				byte[] inputByteArray = global::Motorola.Common.CommonLib.CombineTool.CombineArray<byte>(new byte[][]
				{
					global::Motorola.Common.CommonLib.CombineTool._magicHeader,
					global::Motorola.Common.CommonLib.CombineTool._version,
					global::System.BitConverter.GetBytes(pbaBytes.Length),
					pbaBytes,
					global::System.BitConverter.GetBytes(array.Length),
					array
				});
				byte[] content = global::Motorola.Common.CommonLib.EnDecryptStreamHelper.Instance.Zip_then_Encrypt_ByteArray(inputByteArray);
				byte[] array2 = global::Motorola.Common.Communication.CommonUtil.CopyRightHandler.Instance.AddCopyRightHeader(content);
				result = array2;
			}
			return result;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002428 File Offset: 0x00000628
		public static byte[] Encode(byte[] pbaBytes, byte[] deviceInfo)
		{
			byte[] inputByteArray = global::Motorola.Common.CommonLib.CombineTool.CombineArray<byte>(new byte[][]
			{
				global::Motorola.Common.CommonLib.CombineTool._magicHeader,
				global::Motorola.Common.CommonLib.CombineTool._version,
				global::System.BitConverter.GetBytes(pbaBytes.Length),
				pbaBytes,
				global::System.BitConverter.GetBytes(deviceInfo.Length),
				deviceInfo
			});
			byte[] content = global::Motorola.Common.CommonLib.EnDecryptStreamHelper.Instance.Zip_then_Encrypt_ByteArray(inputByteArray);
			return global::Motorola.Common.Communication.CommonUtil.CopyRightHandler.Instance.AddCopyRightHeader(content);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x0000248C File Offset: 0x0000068C
		public static bool IsPbaPlus_enhanced(byte[] combinedData)
		{
			byte[] inputByteArray = global::Motorola.Common.Communication.CommonUtil.CopyRightHandler.Instance.RemoveCopyRightHeader(combinedData);
			byte[] data = global::Motorola.Common.CommonLib.EnDecryptStreamHelper.Instance.Decrypt_then_UnZip_ByteArray(inputByteArray);
			return global::Motorola.Common.CommonLib.CombineTool.IsPbaPlus(data);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000024B8 File Offset: 0x000006B8
		public static global::System.Collections.Generic.List<byte[]> Decode(byte[] combinedData)
		{
			byte[] inputByteArray = global::Motorola.Common.Communication.CommonUtil.CopyRightHandler.Instance.RemoveCopyRightHeader(combinedData);
			byte[] array = global::Motorola.Common.CommonLib.EnDecryptStreamHelper.Instance.Decrypt_then_UnZip_ByteArray(inputByteArray);
			global::System.Collections.Generic.List<byte[]> result = null;
			if (global::Motorola.Common.CommonLib.CombineTool.IsPbaPlus(array))
			{
				global::System.IO.MemoryStream memoryStream = null;
				global::System.IO.BinaryReader binaryReader = null;
				global::System.IO.MemoryStream memoryStream2 = null;
				global::System.IO.BinaryReader binaryReader2 = null;
				try
				{
					memoryStream = new global::System.IO.MemoryStream(array, 12, global::System.BitConverter.ToInt32(array, global::Motorola.Common.CommonLib.CombineTool._magicHeader.Length + global::Motorola.Common.CommonLib.CombineTool._version.Length));
					binaryReader = new global::System.IO.BinaryReader(memoryStream);
					memoryStream2 = new global::System.IO.MemoryStream(array, 16 + global::System.BitConverter.ToInt32(array, global::Motorola.Common.CommonLib.CombineTool._magicHeader.Length + global::Motorola.Common.CommonLib.CombineTool._version.Length), global::System.BitConverter.ToInt32(array, global::Motorola.Common.CommonLib.CombineTool._magicHeader.Length + global::Motorola.Common.CommonLib.CombineTool._version.Length + 4 + (int)binaryReader.BaseStream.Length));
					binaryReader2 = new global::System.IO.BinaryReader(memoryStream2);
					return new global::System.Collections.Generic.List<byte[]>(2)
					{
						binaryReader.ReadBytes((int)binaryReader.BaseStream.Length),
						binaryReader2.ReadBytes((int)binaryReader2.BaseStream.Length)
					};
				}
				finally
				{
					if (binaryReader != null)
					{
						binaryReader.Close();
						memoryStream = null;
					}
					if (binaryReader2 != null)
					{
						binaryReader2.Close();
						memoryStream2 = null;
					}
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
			result = new global::System.Collections.Generic.List<byte[]>(2)
			{
				array,
				new byte[0]
			};
			return result;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002610 File Offset: 0x00000810
		public static object ByteArrayToObject(byte[] _ByteArray)
		{
			try
			{
				using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(_ByteArray))
				{
					global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter binaryFormatter = new global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
					memoryStream.Position = 0L;
					return binaryFormatter.Deserialize(memoryStream);
				}
			}
			catch (global::System.Exception)
			{
			}
			return null;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002670 File Offset: 0x00000870
		private static T[] CombineArray<T>(params T[][] arrays)
		{
			T[] array = new T[arrays.Sum((T[] a) => a.Length)];
			int num = 0;
			foreach (T[] array2 in arrays)
			{
				global::System.Buffer.BlockCopy(array2, 0, array, num, array2.Length);
				num += array2.Length;
			}
			return array;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000026C4 File Offset: 0x000008C4
		private static bool IsPbaPlus(byte[] data)
		{
			bool result = true;
			for (int i = 0; i <= 3; i++)
			{
				if (data[i] != global::Motorola.Common.CommonLib.CombineTool._magicHeader[i])
				{
					result = false;
				}
			}
			return result;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000026F0 File Offset: 0x000008F0
		public static byte[] WrapEZC(byte[] pbaData)
		{
			if (global::Motorola.Common.CommonLib.CombineTool.IsPbaPlus(pbaData))
			{
				byte[] content = global::Motorola.Common.CommonLib.EnDecryptStreamHelper.Instance.Zip_then_Encrypt_ByteArray(pbaData);
				return global::Motorola.Common.Communication.CommonUtil.CopyRightHandler.Instance.AddCopyRightHeader(content);
			}
			return pbaData;
		}

		// Token: 0x0400000F RID: 15
		private static byte[] _magicHeader = new byte[]
		{
			global::System.Convert.ToByte('P'),
			global::System.Convert.ToByte('B'),
			global::System.Convert.ToByte('A'),
			global::System.Convert.ToByte('+')
		};

		// Token: 0x04000010 RID: 16
		private static byte[] _version = new byte[]
		{
			global::System.Convert.ToByte(0),
			global::System.Convert.ToByte(0),
			global::System.Convert.ToByte(0),
			global::System.Convert.ToByte(1)
		};
	}
}
