using System;

namespace AcpCryptoLib
{
	// Token: 0x02000009 RID: 9
	internal class AcpEncryptionHeader : global::AcpCryptoLib.AcpCryptoHeaderBase
	{
		// Token: 0x06000027 RID: 39 RVA: 0x000027DE File Offset: 0x000009DE
		internal AcpEncryptionHeader(byte[] encrytedData)
		{
			this.data = encrytedData;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000027ED File Offset: 0x000009ED
		internal AcpEncryptionHeader()
		{
			this.Create();
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000027FC File Offset: 0x000009FC
		private byte[] Encrypt(byte[] plainData)
		{
			global::AcpCryptoLib.AcpSmartNetAlgorithm acpSmartNetAlgorithm = new global::AcpCryptoLib.AcpSmartNetAlgorithm();
			return acpSmartNetAlgorithm.Encrypt(plainData);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002818 File Offset: 0x00000A18
		private byte[] Decrypt()
		{
			global::AcpCryptoLib.AcpSmartNetAlgorithm acpSmartNetAlgorithm = new global::AcpCryptoLib.AcpSmartNetAlgorithm();
			return acpSmartNetAlgorithm.Decrypt(this.data);
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600002B RID: 43 RVA: 0x00002837 File Offset: 0x00000A37
		internal override byte[] Data
		{
			get
			{
				return this.data;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600002C RID: 44 RVA: 0x00002840 File Offset: 0x00000A40
		internal override object Key
		{
			get
			{
				byte[] array = this.Decrypt();
				int saltLength = global::AcpCryptoLib.AcpRNGenerator.GetSaltLength(array);
				byte[] array2 = new byte[array.Length - saltLength];
				global::System.Array.Copy(array, saltLength, array2, 0, array2.Length);
				int[] keyIndexes = this.GetKeyIndexes(array);
				global::AcpCryptoLib.AcpKeyManager acpKeyManager = new global::AcpCryptoLib.AcpKeyManager();
				return acpKeyManager.GetKey(array2, keyIndexes);
			}
		}

		// Token: 0x0600002D RID: 45 RVA: 0x0000288C File Offset: 0x00000A8C
		private void Create()
		{
			byte[] array = global::AcpCryptoLib.AcpRNGenerator.GenerateSalt(32, 64);
			byte[] array2 = global::AcpCryptoLib.AcpRNGenerator.GenerateRandomBytes(64, 128);
			this.SaveKeyIndexes(array, array2.Length - 1);
			byte[] array3 = new byte[array.Length + array2.Length];
			global::System.Array.Copy(array, 0, array3, 0, array.Length);
			global::System.Array.Copy(array2, 0, array3, array.Length, array2.Length);
			this.data = this.Encrypt(array3);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000028F0 File Offset: 0x00000AF0
		private void SaveKeyIndexes(byte[] dest, int max)
		{
			int[] array = new int[4];
			for (int i = 0; i < 4; i++)
			{
				array[i] = global::AcpCryptoLib.AcpRNGenerator.GenerateRandomNumber(0, max);
				dest[7 + 4 * i] = (byte)((int)(dest[7 + 4 * i] & 252) | (array[i] & 3));
				dest[8 + 4 * i] = (byte)((int)(dest[8 + 4 * i] & 243) | (array[i] & 12));
				dest[9 + 4 * i] = (byte)((int)(dest[9 + 4 * i] & 207) | (array[i] & 48));
				dest[10 + 4 * i] = (byte)((int)(dest[10 + 4 * i] & 63) | (array[i] & 192));
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002994 File Offset: 0x00000B94
		private int[] GetKeyIndexes(byte[] src)
		{
			int[] array = new int[4];
			for (int i = 0; i < 4; i++)
			{
				array[i] = (int)((src[7 + 4 * i] & 3) | (src[8 + 4 * i] & 12) | (src[9 + 4 * i] & 48) | (src[10 + 4 * i] & 192));
			}
			return array;
		}

		// Token: 0x04000008 RID: 8
		private byte[] data;
	}
}
