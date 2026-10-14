using System;
using System.Security.Cryptography;

namespace AcpCryptoLib
{
	// Token: 0x02000015 RID: 21
	internal class AcpRNGenerator
	{
		// Token: 0x06000054 RID: 84 RVA: 0x00003720 File Offset: 0x00001920
		internal AcpRNGenerator()
		{
			long ticks = global::System.DateTime.Now.Ticks;
			this.m_SNetRandomValue = (int)(ticks % 65536L);
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000056 RID: 86 RVA: 0x00003759 File Offset: 0x00001959
		// (set) Token: 0x06000055 RID: 85 RVA: 0x00003750 File Offset: 0x00001950
		internal int SNetRandomValue
		{
			get
			{
				return this.m_SNetRandomValue;
			}
			set
			{
				this.m_SNetRandomValue = value;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000057 RID: 87 RVA: 0x00003761 File Offset: 0x00001961
		internal int NextSNetRandomValue
		{
			get
			{
				this.m_SNetRandomValue = (this.m_SNetRandomValue * 25173 + 13849) % 256;
				return this.m_SNetRandomValue;
			}
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00003788 File Offset: 0x00001988
		internal static byte[] GenerateRandomBytes(int minLength, int maxLength)
		{
			int num = global::AcpCryptoLib.AcpRNGenerator.GenerateRandomNumber(minLength, maxLength);
			byte[] array = new byte[num];
			global::System.Security.Cryptography.RNGCryptoServiceProvider rngcryptoServiceProvider = new global::System.Security.Cryptography.RNGCryptoServiceProvider();
			rngcryptoServiceProvider.GetNonZeroBytes(array);
			return array;
		}

		// Token: 0x06000059 RID: 89 RVA: 0x000037B4 File Offset: 0x000019B4
		internal static int GenerateRandomNumber(int minValue, int maxValue)
		{
			byte[] array = new byte[4];
			global::System.Security.Cryptography.RNGCryptoServiceProvider rngcryptoServiceProvider = new global::System.Security.Cryptography.RNGCryptoServiceProvider();
			rngcryptoServiceProvider.GetBytes(array);
			int seed = (int)(array[0] & 127) << 24 | (int)array[1] << 16 | (int)array[2] << 8 | (int)array[3];
			global::System.Random random = new global::System.Random(seed);
			return random.Next(minValue, maxValue + 1);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00003804 File Offset: 0x00001A04
		internal static byte[] GenerateSalt(int minLen, int maxLen)
		{
			if (minLen < 4 || maxLen < 4)
			{
				throw new global::System.Exception("Invalid min Length");
			}
			if (minLen > maxLen)
			{
				throw new global::System.Exception("Min Length cannot be greater Maximum Length");
			}
			if (maxLen > 128)
			{
				throw new global::System.Exception("Invalid max Length");
			}
			int num;
			if (minLen == maxLen)
			{
				num = minLen;
			}
			else
			{
				num = global::AcpCryptoLib.AcpRNGenerator.GenerateRandomNumber(minLen, maxLen);
			}
			byte[] array = new byte[num];
			global::System.Security.Cryptography.RNGCryptoServiceProvider rngcryptoServiceProvider = new global::System.Security.Cryptography.RNGCryptoServiceProvider();
			rngcryptoServiceProvider.GetNonZeroBytes(array);
			array[0] = (byte)((int)(array[0] & 252) | (num & 3));
			array[1] = (byte)((int)(array[1] & 243) | (num & 12));
			array[2] = (byte)((int)(array[2] & 207) | (num & 48));
			array[3] = (byte)((int)(array[3] & 63) | (num & 192));
			return array;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x000038B4 File Offset: 0x00001AB4
		internal static int GetSaltLength(byte[] saltedData)
		{
			if (saltedData != null)
			{
				return (int)((saltedData[0] & 3) | (saltedData[1] & 12) | (saltedData[2] & 48) | (saltedData[3] & 192));
			}
			throw new global::System.Exception("Invalid Data");
		}

		// Token: 0x04000035 RID: 53
		private int m_SNetRandomValue;
	}
}
