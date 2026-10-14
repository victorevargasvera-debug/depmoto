using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Security.Cryptography;
using System.Xml;
using Motorola.Common.Communication.Pba;

namespace Motorola.Common.Communication.SequenceManager
{
	// Token: 0x02000032 RID: 50
	internal class PcrFileSystemUpdateFile
	{
		// Token: 0x06000198 RID: 408 RVA: 0x0000F9BF File Offset: 0x0000DBBF
		private PcrFileSystemUpdateFile()
		{
		}

		// Token: 0x06000199 RID: 409 RVA: 0x0000F9CA File Offset: 0x0000DBCA
		private PcrFileSystemUpdateFile(global::Motorola.Common.Communication.Pba.PcrFileSystemMemoryImage radioImage, global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem> files)
		{
		}

		// Token: 0x0600019A RID: 410 RVA: 0x0000F9D8 File Offset: 0x0000DBD8
		public static global::System.Xml.XmlDocument CreateUpdateFileXml(global::Motorola.Common.Communication.Pba.PcrFileSystemMemoryImage image, global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem> filesInFolder)
		{
			filesInFolder.Sort(new global::System.Comparison<global::Motorola.Common.Communication.Pba.FileItem>(global::Motorola.Common.Communication.SequenceManager.PcrFileSystemUpdateFile.SortFilesByFileName));
			global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
			xmlDocument.LoadXml("<?xml version=\"1.0\" encoding=\"UTF-8\"?><root></root>");
			global::System.Xml.XmlElement xmlElement = xmlDocument.CreateElement("Partition");
			string value = "FileSystem";
			switch (image.FileType)
			{
			case global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.FILESYSTEM:
				value = "FileSystem";
				break;
			case global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.FTL:
				value = "FTL";
				break;
			case global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.NAND:
				value = "RawNAND";
				break;
			}
			xmlElement.SetAttribute("Type", value);
			foreach (global::Motorola.Common.Communication.Pba.FileItem fileItem in filesInFolder)
			{
				global::System.Xml.XmlElement xmlElement2 = xmlDocument.CreateElement("Payload");
				string text = global::System.BitConverter.ToString(fileItem.FileContent);
				text = text.Replace("-", "");
				xmlElement2.InnerText = text;
				xmlElement2.SetAttribute("ID", "0x" + image.PartitionId.ToString("x4", global::System.Globalization.CultureInfo.InvariantCulture));
				xmlElement2.SetAttribute("OptionFlags", "0x" + image.OptionFlag.ToString("x8", global::System.Globalization.CultureInfo.InvariantCulture));
				xmlElement2.SetAttribute("Path", fileItem.FilePath.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
				xmlElement2.SetAttribute("Size", "0x" + fileItem.FileSize.ToString("x4", global::System.Globalization.CultureInfo.InvariantCulture));
				string md = global::Motorola.Common.Communication.SequenceManager.PcrFileSystemUpdateFile.GetMd5(fileItem.FileContent);
				xmlElement2.SetAttribute("MD5_CheckSUM", md);
				xmlElement.AppendChild(xmlElement2);
			}
			xmlDocument.DocumentElement.AppendChild(xmlElement);
			return xmlDocument;
		}

		// Token: 0x0600019B RID: 411 RVA: 0x0000FBD8 File Offset: 0x0000DDD8
		public static string GetMd5(byte[] value)
		{
			string text = string.Empty;
			using (global::System.Security.Cryptography.MD5CryptoServiceProvider md5CryptoServiceProvider = new global::System.Security.Cryptography.MD5CryptoServiceProvider())
			{
				text = global::System.BitConverter.ToString(md5CryptoServiceProvider.ComputeHash(value));
				text = text.Replace("-", "");
			}
			return text.ToLowerInvariant();
		}

		// Token: 0x0600019C RID: 412 RVA: 0x0000FC40 File Offset: 0x0000DE40
		private static int SortFilesByFileName(global::Motorola.Common.Communication.Pba.FileItem x, global::Motorola.Common.Communication.Pba.FileItem y)
		{
			string fileNameWithoutExtension = global::System.IO.Path.GetFileNameWithoutExtension(x.FilePath);
			string fileNameWithoutExtension2 = global::System.IO.Path.GetFileNameWithoutExtension(y.FilePath);
			ushort num = global::System.Convert.ToUInt16(fileNameWithoutExtension, 16);
			ushort num2 = global::System.Convert.ToUInt16(fileNameWithoutExtension2, 16);
			int result;
			if (num == num2)
			{
				int num3 = 0;
				result = num3;
			}
			else if (num > num2)
			{
				int num3 = 1;
				result = num3;
			}
			else
			{
				int num3 = -1;
				result = num3;
			}
			return result;
		}

		// Token: 0x040000C3 RID: 195
		private const string XMLHEADER = "<?xml version=\"1.0\" encoding=\"UTF-8\"?><root></root>";

		// Token: 0x040000C4 RID: 196
		private const string HEXZERO = "0x00000000";

		// Token: 0x040000C5 RID: 197
		private const string HEXPREFIX = "0x";

		// Token: 0x040000C6 RID: 198
		private const string HEX4FORMAT = "x4";

		// Token: 0x040000C7 RID: 199
		private const string HEX8FORMAT = "x8";

		// Token: 0x040000C8 RID: 200
		public const string FTL = "FTL";

		// Token: 0x040000C9 RID: 201
		private const string SIZE = "Size";

		// Token: 0x040000CA RID: 202
		private const string ROOT = "root";

		// Token: 0x040000CB RID: 203
		public const string MD5CHECKSUM = "MD5_CheckSUM";

		// Token: 0x040000CC RID: 204
		public const string PARTITION = "Partition";

		// Token: 0x040000CD RID: 205
		public const string FILESYSTEM = "FileSystem";

		// Token: 0x040000CE RID: 206
		public const string RAWNAND = "RawNAND";

		// Token: 0x040000CF RID: 207
		public const string TYPE = "Type";

		// Token: 0x040000D0 RID: 208
		public const string PAYLOAD = "Payload";

		// Token: 0x040000D1 RID: 209
		public const string ID = "ID";

		// Token: 0x040000D2 RID: 210
		public const string OPTIONFLAGS = "OptionFlags";

		// Token: 0x040000D3 RID: 211
		public const string PATH = "Path";

		// Token: 0x040000D4 RID: 212
		private const string NANDPAYLOADPATH = "//Partition[@Type='RawNAND']/Payload";

		// Token: 0x040000D5 RID: 213
		private const string FTLPAYLOADPATH = "//Partition[@Type='FTL']/Payload";

		// Token: 0x040000D6 RID: 214
		private const string FILEPAYLOADPATH = "//Partition[@Type='FileSystem']/Payload";

		// Token: 0x040000D7 RID: 215
		public const string PARTITION_STARTID = "Start_ID";

		// Token: 0x040000D8 RID: 216
		public const string PARTITION_ENDID = "End_ID";
	}
}
