using System;
using System.IO;
using System.Security.Cryptography;
using System.Xml;
using System.Xml.Linq;
using Motorola.Common.Communication.TetraSecurity;

namespace Motorola.Common.Communication.TetraUtility
{
	// Token: 0x0200000C RID: 12
	public static class CryptAndZipUtilty
	{
		// Token: 0x0600004E RID: 78 RVA: 0x000055D4 File Offset: 0x000037D4
		public static global::System.Xml.XmlDocument LoadXmlWhenDebugOrUnmixDecompressXml(string fileName)
		{
			global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
			string xmlTextWhenDebugOrUnmixDecompressXml = global::Motorola.Common.Communication.TetraUtility.CryptAndZipUtilty.GetXmlTextWhenDebugOrUnmixDecompressXml(fileName);
			xmlDocument.LoadXml(xmlTextWhenDebugOrUnmixDecompressXml);
			return xmlDocument;
		}

		// Token: 0x0600004F RID: 79 RVA: 0x000055F8 File Offset: 0x000037F8
		public static global::System.Xml.Linq.XDocument LoadXmlWhenDebugOrUnmixDecompressXmlIntoXDocument(string fileName)
		{
			string xmlTextWhenDebugOrUnmixDecompressXml = global::Motorola.Common.Communication.TetraUtility.CryptAndZipUtilty.GetXmlTextWhenDebugOrUnmixDecompressXml(fileName);
			return global::System.Xml.Linq.XDocument.Parse(xmlTextWhenDebugOrUnmixDecompressXml);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00005612 File Offset: 0x00003812
		public static string GetXmlTextWhenDebugOrUnmixDecompressXml(string fileName)
		{
			return global::Motorola.Common.Communication.TetraUtility.CryptAndZipUtilty.UnmixDecompressFile2XmlStr(fileName);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x0000561A File Offset: 0x0000381A
		public static void SaveXmlAndCompressMixWhenNotDebug(global::System.Xml.XmlDocument xmlDoc, string fileName)
		{
			xmlDoc.Save(fileName);
			global::Motorola.Common.Communication.TetraSecurity.CryptAndZip.CompressMixFile(fileName, fileName, true, global::Motorola.Common.Communication.TetraUtility.CryptAndZipUtilty.DefOne, global::Motorola.Common.Communication.TetraUtility.CryptAndZipUtilty.DefTwo);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00005638 File Offset: 0x00003838
		public static void SaveXmlAndCompressMix(global::System.Xml.XmlDocument xmlDoc, string fileName)
		{
			string directoryName = global::System.IO.Path.GetDirectoryName(fileName);
			if (!global::System.IO.Directory.Exists(directoryName) && !string.IsNullOrEmpty(directoryName))
			{
				global::System.IO.Directory.CreateDirectory(directoryName);
			}
			xmlDoc.Save(fileName);
			global::Motorola.Common.Communication.TetraSecurity.CryptAndZip.CompressMixFile(fileName, fileName, true, global::Motorola.Common.Communication.TetraUtility.CryptAndZipUtilty.DefOne, global::Motorola.Common.Communication.TetraUtility.CryptAndZipUtilty.DefTwo);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00005680 File Offset: 0x00003880
		public static string UnmixDecompressFile2XmlStr(string fileName)
		{
			string result;
			using (global::System.IO.FileStream fileStream = new global::System.IO.FileStream(fileName, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read))
			{
				byte[] array = new byte[fileStream.Length];
				fileStream.Read(array, 0, array.Length);
				byte[] buffer = new byte[0];
				global::Motorola.Common.Communication.TetraSecurity.CryptAndZip.UnmixDecompressFile(array, ref buffer, true, global::Motorola.Common.Communication.TetraUtility.CryptAndZipUtilty.DefOne, global::Motorola.Common.Communication.TetraUtility.CryptAndZipUtilty.DefTwo);
				using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(buffer))
				{
					global::System.IO.StreamReader streamReader = new global::System.IO.StreamReader(memoryStream);
					result = streamReader.ReadToEnd();
				}
			}
			return result;
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00005718 File Offset: 0x00003918
		public static void UnmixDecompressBuffer2Buffer(byte[] bufferIn, out byte[] bufferOut)
		{
			bufferOut = new byte[0];
			global::Motorola.Common.Communication.TetraSecurity.CryptAndZip.UnmixDecompressFile(bufferIn, ref bufferOut, true, global::Motorola.Common.Communication.TetraUtility.CryptAndZipUtilty.DefOne, global::Motorola.Common.Communication.TetraUtility.CryptAndZipUtilty.DefTwo);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00005734 File Offset: 0x00003934
		public static bool IsXmlFile(string file)
		{
			try
			{
				using (global::System.IO.StreamReader streamReader = new global::System.IO.StreamReader(file))
				{
					while (!streamReader.EndOfStream)
					{
						string text = streamReader.ReadLine().Trim();
						if (!string.IsNullOrEmpty(text))
						{
							if (text.StartsWith("<?xml", global::System.StringComparison.Ordinal))
							{
								return true;
							}
							return false;
						}
					}
				}
			}
			catch
			{
				return false;
			}
			return false;
		}

		// Token: 0x06000056 RID: 86 RVA: 0x000057B0 File Offset: 0x000039B0
		public static byte[] GetSHA256(string userPassword)
		{
			return global::Motorola.Common.Communication.TetraUtility.CryptAndZipUtilty.GetSHA256(global::Motorola.Common.Communication.TetraUtility.CodepageUtil.GetEncoding(1252).GetBytes(userPassword));
		}

		// Token: 0x06000057 RID: 87 RVA: 0x000057C8 File Offset: 0x000039C8
		public static byte[] GetSHA256(byte[] userPasswordByte)
		{
			byte[] result;
			using (global::System.Security.Cryptography.SHA256 sha = global::System.Security.Cryptography.SHA256.Create())
			{
				result = sha.ComputeHash(userPasswordByte);
			}
			return result;
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000058 RID: 88 RVA: 0x00005800 File Offset: 0x00003A00
		private static byte[] DefOne
		{
			get
			{
				return global::Motorola.Common.Communication.TetraUtility.StrangeName.DefOne;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000059 RID: 89 RVA: 0x00005807 File Offset: 0x00003A07
		private static byte[] DefTwo
		{
			get
			{
				return global::Motorola.Common.Communication.TetraUtility.StrangeName.DefTwo;
			}
		}
	}
}
