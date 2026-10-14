using System;
using System.IO;
using System.Security.Cryptography;

namespace AcpCryptoLib
{
	// Token: 0x02000013 RID: 19
	public class AcpEncryptDecrypt : global::AcpCryptoLib.AcpCryptoBase, global::AcpCryptoLib.IAcpEncryptDecrypt
	{
		// Token: 0x0600004B RID: 75 RVA: 0x000031D8 File Offset: 0x000013D8
		public byte[] Encrypt(byte[] plainData)
		{
			if (plainData == null)
			{
				throw new global::System.ArgumentNullException("Input data is a null reference.");
			}
			global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
			global::AcpCryptoLib.AcpEncryptionHeader acpEncryptionHeader = new global::AcpCryptoLib.AcpEncryptionHeader();
			memoryStream.Write(acpEncryptionHeader.Data, 0, acpEncryptionHeader.Data.Length);
			global::System.Security.Cryptography.SymmetricAlgorithm symmetricAlgorithm = (global::System.Security.Cryptography.SymmetricAlgorithm)acpEncryptionHeader.Key;
			global::System.Security.Cryptography.ICryptoTransform transform = symmetricAlgorithm.CreateEncryptor();
			global::System.Security.Cryptography.CryptoStream cryptoStream = new global::System.Security.Cryptography.CryptoStream(memoryStream, transform, global::System.Security.Cryptography.CryptoStreamMode.Write);
			byte[] array = global::AcpCryptoLib.AcpRNGenerator.GenerateSalt(7, 128);
			cryptoStream.Write(array, 0, array.Length);
			cryptoStream.Write(plainData, 0, plainData.Length);
			cryptoStream.FlushFinalBlock();
			byte[] result = memoryStream.ToArray();
			memoryStream.Close();
			cryptoStream.Close();
			return result;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00003278 File Offset: 0x00001478
		public byte[] Decrypt(byte[] encryptedData)
		{
			if (encryptedData == null)
			{
				throw new global::System.ArgumentNullException("Input data is a null reference.");
			}
			byte[] array = null;
			byte[] array2 = new byte[encryptedData.Length];
			try
			{
				global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(encryptedData);
				byte[] encrytedData = base.ExtractHeader(memoryStream);
				global::AcpCryptoLib.AcpEncryptionHeader acpEncryptionHeader = new global::AcpCryptoLib.AcpEncryptionHeader(encrytedData);
				global::System.Security.Cryptography.SymmetricAlgorithm symmetricAlgorithm = (global::System.Security.Cryptography.SymmetricAlgorithm)acpEncryptionHeader.Key;
				global::System.Security.Cryptography.ICryptoTransform transform = symmetricAlgorithm.CreateDecryptor();
				global::System.Security.Cryptography.CryptoStream cryptoStream = new global::System.Security.Cryptography.CryptoStream(memoryStream, transform, global::System.Security.Cryptography.CryptoStreamMode.Read);
				base.ExtractSalt(cryptoStream);
				int num = cryptoStream.Read(array2, 0, array2.Length);
				cryptoStream.Close();
				memoryStream.Close();
				array = new byte[num];
				global::System.Array.Copy(array2, 0, array, 0, array.Length);
			}
			catch (global::System.Exception ex)
			{
				throw new global::System.Exception("AcpEncryptDecrypt.Decrypt - Exception: " + ex.Message);
			}
			return array;
		}
	}
}
