using System;
using System.IO;
using System.Security.Cryptography;
using System.Xml;

namespace AcpCryptoLib
{
	// Token: 0x0200000C RID: 12
	public class AcpXMLEncryptDecrypt : global::AcpCryptoLib.AcpCryptoBase, global::AcpCryptoLib.IAcpXMLEncryptDecrypt
	{
		// Token: 0x0600003A RID: 58 RVA: 0x00002C5C File Offset: 0x00000E5C
		public void EncryptXMLFile(string inputFileName, string outputFileName)
		{
			try
			{
				global::System.IO.FileStream fileStream = new global::System.IO.FileStream(inputFileName, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read);
				if (this.IsXMLValid(fileStream))
				{
					fileStream.Seek(0L, global::System.IO.SeekOrigin.Begin);
					byte[] array = new byte[fileStream.Length];
					fileStream.Read(array, 0, array.Length);
					global::System.IO.FileStream fileStream2 = new global::System.IO.FileStream(outputFileName, global::System.IO.FileMode.Create);
					global::AcpCryptoLib.AcpCryptoHeader acpCryptoHeader = new global::AcpCryptoLib.AcpCryptoHeader();
					fileStream2.Write(acpCryptoHeader.Data, 0, acpCryptoHeader.Data.Length);
					global::System.Security.Cryptography.SymmetricAlgorithm symmetricAlgorithm = (global::System.Security.Cryptography.SymmetricAlgorithm)acpCryptoHeader.Key;
					global::System.Security.Cryptography.ICryptoTransform transform = symmetricAlgorithm.CreateEncryptor();
					global::System.Security.Cryptography.CryptoStream cryptoStream = new global::System.Security.Cryptography.CryptoStream(fileStream2, transform, global::System.Security.Cryptography.CryptoStreamMode.Write);
					byte[] array2 = global::AcpCryptoLib.AcpRNGenerator.GenerateSalt(7, 128);
					cryptoStream.Write(array2, 0, array2.Length);
					cryptoStream.Write(array, 0, array.Length);
					cryptoStream.FlushFinalBlock();
					fileStream.Close();
					cryptoStream.Close();
					fileStream2.Close();
				}
			}
			catch (global::System.Exception ex)
			{
				throw new global::System.Exception("AcpXMLEncryptDecrypt.EncryptXMLFile - Exception: " + ex.Message);
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002D54 File Offset: 0x00000F54
		public void EncryptXMLDoc(global::System.Xml.XmlDocument doc, string outputFileName)
		{
			try
			{
				global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
				doc.Save(memoryStream);
				memoryStream.Seek(0L, global::System.IO.SeekOrigin.Begin);
				byte[] array = new byte[memoryStream.Length];
				memoryStream.Read(array, 0, array.Length);
				global::System.IO.FileStream fileStream = new global::System.IO.FileStream(outputFileName, global::System.IO.FileMode.Create);
				global::AcpCryptoLib.AcpCryptoHeader acpCryptoHeader = new global::AcpCryptoLib.AcpCryptoHeader();
				fileStream.Write(acpCryptoHeader.Data, 0, acpCryptoHeader.Data.Length);
				global::System.Security.Cryptography.SymmetricAlgorithm symmetricAlgorithm = (global::System.Security.Cryptography.SymmetricAlgorithm)acpCryptoHeader.Key;
				global::System.Security.Cryptography.ICryptoTransform transform = symmetricAlgorithm.CreateEncryptor();
				global::System.Security.Cryptography.CryptoStream cryptoStream = new global::System.Security.Cryptography.CryptoStream(fileStream, transform, global::System.Security.Cryptography.CryptoStreamMode.Write);
				byte[] array2 = global::AcpCryptoLib.AcpRNGenerator.GenerateSalt(7, 128);
				cryptoStream.Write(array2, 0, array2.Length);
				cryptoStream.Write(array, 0, array.Length);
				cryptoStream.FlushFinalBlock();
				memoryStream.Close();
				cryptoStream.Close();
				fileStream.Close();
			}
			catch (global::System.Exception ex)
			{
				throw new global::System.Exception("AcpXMLEncryptDecrypt.EncryptDoc - Exception: " + ex.Message);
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002E44 File Offset: 0x00001044
		public global::System.Xml.XmlDocument DecryptXMLFile(string inputFileName)
		{
			global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
			try
			{
				global::System.IO.FileStream fileStream = new global::System.IO.FileStream(inputFileName, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read);
				byte[] encrytedData = base.ExtractHeader(fileStream);
				global::AcpCryptoLib.AcpCryptoHeader acpCryptoHeader = new global::AcpCryptoLib.AcpCryptoHeader(encrytedData);
				global::System.Security.Cryptography.SymmetricAlgorithm symmetricAlgorithm = (global::System.Security.Cryptography.SymmetricAlgorithm)acpCryptoHeader.Key;
				global::System.Security.Cryptography.ICryptoTransform transform = symmetricAlgorithm.CreateDecryptor();
				global::System.Security.Cryptography.CryptoStream cryptoStream = new global::System.Security.Cryptography.CryptoStream(fileStream, transform, global::System.Security.Cryptography.CryptoStreamMode.Read);
				base.ExtractSalt(cryptoStream);
				xmlDocument.Load(cryptoStream);
				fileStream.Close();
				cryptoStream.Close();
			}
			catch (global::System.Exception ex)
			{
				throw new global::System.Exception("AcpXMLEncryptDecrypt.DecryptXMLFile - Exception: " + ex.Message);
			}
			return xmlDocument;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002EDC File Offset: 0x000010DC
		public global::System.Xml.XmlDocument DecryptXMLFile(global::System.IO.Stream inputStream)
		{
			global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
			try
			{
				byte[] encrytedData = base.ExtractHeader(inputStream);
				global::AcpCryptoLib.AcpCryptoHeader acpCryptoHeader = new global::AcpCryptoLib.AcpCryptoHeader(encrytedData);
				global::System.Security.Cryptography.SymmetricAlgorithm symmetricAlgorithm = (global::System.Security.Cryptography.SymmetricAlgorithm)acpCryptoHeader.Key;
				global::System.Security.Cryptography.ICryptoTransform transform = symmetricAlgorithm.CreateDecryptor();
				global::System.Security.Cryptography.CryptoStream cryptoStream = new global::System.Security.Cryptography.CryptoStream(inputStream, transform, global::System.Security.Cryptography.CryptoStreamMode.Read);
				base.ExtractSalt(cryptoStream);
				xmlDocument.Load(cryptoStream);
				inputStream.Close();
				cryptoStream.Close();
			}
			catch (global::System.Exception ex)
			{
				throw new global::System.Exception("AcpXMLEncryptDecrypt.DecryptXMLFile - Exception: " + ex.Message);
			}
			return xmlDocument;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002F68 File Offset: 0x00001168
		private bool IsXMLValid(global::System.IO.Stream stream)
		{
			bool result = true;
			if (stream == null)
			{
				result = false;
				throw new global::System.ArgumentNullException("Stream has a null reference.");
			}
			try
			{
				global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
				xmlDocument.Load(stream);
			}
			catch (global::System.Exception ex)
			{
				result = false;
				throw new global::System.Exception("Invalid XML Stream: " + ex.Message);
			}
			return result;
		}
	}
}
