using System;

namespace AcpCryptoLib
{
	// Token: 0x02000008 RID: 8
	internal class AcpCryptoHeader : global::AcpCryptoLib.AcpCryptoHeaderBase
	{
		// Token: 0x0600001E RID: 30 RVA: 0x00002620 File Offset: 0x00000820
		internal AcpCryptoHeader(byte[] encrytedData)
		{
			this.data = encrytedData;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x0000262F File Offset: 0x0000082F
		internal AcpCryptoHeader()
		{
			this.Create();
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002640 File Offset: 0x00000840
		private byte[] Encrypt(byte[] plainData)
		{
			global::AcpCryptoLib.AcpSmartNetAlgorithm acpSmartNetAlgorithm = new global::AcpCryptoLib.AcpSmartNetAlgorithm();
			return acpSmartNetAlgorithm.Encrypt(plainData);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x0000265C File Offset: 0x0000085C
		private byte[] Decrypt()
		{
			global::AcpCryptoLib.AcpSmartNetAlgorithm acpSmartNetAlgorithm = new global::AcpCryptoLib.AcpSmartNetAlgorithm();
			return acpSmartNetAlgorithm.Decrypt(this.data);
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000022 RID: 34 RVA: 0x0000267B File Offset: 0x0000087B
		internal override byte[] Data
		{
			get
			{
				return this.data;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000023 RID: 35 RVA: 0x00002684 File Offset: 0x00000884
		internal override object Key
		{
			get
			{
				byte[] array = this.Decrypt();
				int saltLength = global::AcpCryptoLib.AcpRNGenerator.GetSaltLength(array);
				int passwordLength = this.GetPasswordLength(array);
				byte[] array2 = new byte[passwordLength];
				global::System.Array.Copy(array, saltLength, array2, 0, array2.Length);
				global::AcpCryptoLib.AcpKeyManager acpKeyManager = new global::AcpCryptoLib.AcpKeyManager();
				return acpKeyManager.GetKey(array2);
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000026CC File Offset: 0x000008CC
		private void Create()
		{
			byte[] array = global::AcpCryptoLib.AcpRNGenerator.GenerateSalt(16, 32);
			byte[] array2 = global::AcpCryptoLib.AcpRNGenerator.GenerateRandomBytes(8, 64);
			byte[] array3 = global::AcpCryptoLib.AcpRNGenerator.GenerateSalt(16, 32);
			this.SavePasswordLength(array, array2.Length);
			byte[] array4 = new byte[array.Length + array2.Length + array3.Length];
			global::System.Array.Copy(array, 0, array4, 0, array.Length);
			global::System.Array.Copy(array2, 0, array4, array.Length, array2.Length);
			global::System.Array.Copy(array3, 0, array4, array.Length + array2.Length, array3.Length);
			this.data = this.Encrypt(array4);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x0000274C File Offset: 0x0000094C
		private void SavePasswordLength(byte[] dest, int val)
		{
			dest[4] = (byte)((int)(dest[4] & 252) | (val & 3));
			dest[5] = (byte)((int)(dest[5] & 243) | (val & 12));
			dest[6] = (byte)((int)(dest[6] & 207) | (val & 48));
			dest[7] = (byte)((int)(dest[7] & 63) | (val & 192));
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000027A0 File Offset: 0x000009A0
		private int GetPasswordLength(byte[] plainData)
		{
			if (plainData != null)
			{
				return (int)((plainData[4] & 3) | (plainData[5] & 12) | (plainData[6] & 48) | (plainData[7] & 192));
			}
			throw new global::System.Exception("Invalid Data");
		}

		// Token: 0x04000007 RID: 7
		private byte[] data;
	}
}
