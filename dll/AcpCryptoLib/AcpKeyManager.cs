using System;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;

namespace AcpCryptoLib
{
	// Token: 0x02000002 RID: 2
	internal class AcpKeyManager
	{
		// Token: 0x06000001 RID: 1 RVA: 0x000020D0 File Offset: 0x000002D0
		internal AcpKeyManager()
		{
			this.m_symmetricKey = new global::System.Security.Cryptography.RijndaelManaged();
			this.m_symmetricKey.Mode = global::System.Security.Cryptography.CipherMode.CBC;
			this.m_symmetricKey.Padding = global::System.Security.Cryptography.PaddingMode.PKCS7;
			this.m_symmetricKey.BlockSize = 128;
			this.m_symmetricKey.KeySize = 256;
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002134 File Offset: 0x00000334
		internal global::System.Security.Cryptography.SymmetricAlgorithm GetKey(byte[] passwdHint)
		{
			this.LoadKeyData();
			int[] array = (int[])this.GetIndexes(passwdHint);
			byte[] array2 = new byte[array.Length];
			for (int i = 0; i < array.Length; i++)
			{
				int num = array[i] % global::AcpCryptoLib.AcpCryptoDefs.randomFactors.Length;
				array2[i] = (byte)((int)this.m_keyData[array[i]] ^ (global::AcpCryptoLib.AcpCryptoDefs.randomFactors[num] + array[i]) % 256);
			}
			global::System.Security.Cryptography.PasswordDeriveBytes passwordDeriveBytes = new global::System.Security.Cryptography.PasswordDeriveBytes(array2, passwdHint, this.hashType, 10);
			this.m_symmetricKey.Key = passwordDeriveBytes.GetBytes(32);
			this.m_symmetricKey.IV = this.GetIV(passwdHint, true);
			return this.m_symmetricKey;
		}

		// Token: 0x06000003 RID: 3 RVA: 0x000021DC File Offset: 0x000003DC
		internal global::System.Security.Cryptography.SymmetricAlgorithm GetKey(byte[] passwdHint, int[] positions)
		{
			if (positions.Length != 4)
			{
				throw new global::System.Exception("Indexex Out Of Range");
			}
			global::AcpCryptoLib.AcpRNGenerator acpRNGenerator = new global::AcpCryptoLib.AcpRNGenerator();
			byte[] array = new byte[passwdHint.Length];
			for (int i = 0; i < passwdHint.Length; i++)
			{
				acpRNGenerator.SNetRandomValue = (int)passwdHint[positions[i % 3]];
				int nextSNetRandomValue = acpRNGenerator.NextSNetRandomValue;
				array[i] = (byte)((int)passwdHint[i] ^ nextSNetRandomValue);
			}
			global::System.Security.Cryptography.PasswordDeriveBytes passwordDeriveBytes = new global::System.Security.Cryptography.PasswordDeriveBytes(array, passwdHint, "SHA1", 10);
			this.m_symmetricKey.Key = passwordDeriveBytes.GetBytes(32);
			this.m_symmetricKey.IV = this.GetIV(array, false);
			return this.m_symmetricKey;
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002274 File Offset: 0x00000474
		private byte[] GetIV(byte[] data, bool fromDB)
		{
			byte[] array = new byte[16];
			if (fromDB)
			{
				int[] array2 = (int[])this.GetIndexes(data);
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = this.m_keyData[array2[array2.Length - 2 - i]];
				}
			}
			else
			{
				for (int j = 0; j < array.Length; j++)
				{
					array[j] = data[data.Length - 2 - j];
				}
			}
			return array;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000022D8 File Offset: 0x000004D8
		private void LoadKeyData()
		{
			try
			{
				global::System.IO.Stream manifestResourceStream = global::System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("AcpCryptoLib.Acpcrypto.def");
				global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter binaryFormatter = new global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
				this.m_keyData = (byte[])binaryFormatter.Deserialize(manifestResourceStream);
				manifestResourceStream.Close();
			}
			catch (global::System.Exception)
			{
			}
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002328 File Offset: 0x00000528
		private object GetIndexes(byte[] data)
		{
			int[] array = new int[20];
			int num = 0;
			global::System.Security.Cryptography.SHA1 sha = new global::System.Security.Cryptography.SHA1CryptoServiceProvider();
			byte[] array2 = sha.ComputeHash(data);
			for (int i = 0; i < array2.Length; i++)
			{
				num += (int)array2[i];
			}
			int num2 = num % 1024;
			for (int j = 0; j < array.Length; j++)
			{
				array[j] = (num2 * global::AcpCryptoLib.AcpCryptoDefs.randomFactors[j] + 25173) % 1024;
				num2 = array[j];
			}
			return array;
		}

		// Token: 0x04000001 RID: 1
		private global::System.Security.Cryptography.SymmetricAlgorithm m_symmetricKey;

		// Token: 0x04000002 RID: 2
		private string hashType = "SHA1";

		// Token: 0x04000003 RID: 3
		private byte[] m_keyData;
	}
}
