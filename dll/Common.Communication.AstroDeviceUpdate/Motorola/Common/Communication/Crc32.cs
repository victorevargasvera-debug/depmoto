using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace Motorola.Common.Communication
{
	// Token: 0x0200000A RID: 10
	public sealed class Crc32 : global::System.Security.Cryptography.HashAlgorithm
	{
		// Token: 0x06000061 RID: 97 RVA: 0x0000475A File Offset: 0x0000295A
		public Crc32() : this(3988292384U, uint.MaxValue)
		{
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00004768 File Offset: 0x00002968
		public Crc32(uint polynomial, uint seed)
		{
			this.table = global::Motorola.Common.Communication.Crc32.InitializeTable(polynomial);
			this.hash = seed;
			this.seed = seed;
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00004797 File Offset: 0x00002997
		public override void Initialize()
		{
			this.hash = this.seed;
		}

		// Token: 0x06000064 RID: 100 RVA: 0x000047A5 File Offset: 0x000029A5
		protected override void HashCore(byte[] buffer, int start, int length)
		{
			this.hash = global::Motorola.Common.Communication.Crc32.CalculateHash(this.table, this.hash, buffer, start, length);
		}

		// Token: 0x06000065 RID: 101 RVA: 0x000047C4 File Offset: 0x000029C4
		protected override byte[] HashFinal()
		{
			byte[] array = global::Motorola.Common.Communication.Crc32.UInt32ToBigEndianBytes(~this.hash);
			this.HashValue = array;
			return array;
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000066 RID: 102 RVA: 0x000047E6 File Offset: 0x000029E6
		public override int HashSize
		{
			get
			{
				return 32;
			}
		}

		// Token: 0x06000067 RID: 103 RVA: 0x000047EA File Offset: 0x000029EA
		public static uint Compute(byte[] buffer)
		{
			return global::Motorola.Common.Communication.Crc32.Compute(uint.MaxValue, buffer);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x000047F3 File Offset: 0x000029F3
		public static uint Compute(uint seed, byte[] buffer)
		{
			return global::Motorola.Common.Communication.Crc32.Compute(3988292384U, seed, buffer);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00004801 File Offset: 0x00002A01
		public static uint Compute(uint polynomial, uint seed, byte[] buffer)
		{
			return ~global::Motorola.Common.Communication.Crc32.CalculateHash(global::Motorola.Common.Communication.Crc32.InitializeTable(polynomial), seed, buffer, 0, buffer.Length);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00004818 File Offset: 0x00002A18
		private static uint[] InitializeTable(uint polynomial)
		{
			if (polynomial == 3988292384U && global::Motorola.Common.Communication.Crc32.defaultTable != null)
			{
				return global::Motorola.Common.Communication.Crc32.defaultTable;
			}
			uint[] array = new uint[256];
			for (int i = 0; i < 256; i++)
			{
				uint num = (uint)i;
				for (int j = 0; j < 8; j++)
				{
					if ((num & 1U) == 1U)
					{
						num = (num >> 1 ^ polynomial);
					}
					else
					{
						num >>= 1;
					}
				}
				array[i] = num;
			}
			if (polynomial == 3988292384U)
			{
				global::Motorola.Common.Communication.Crc32.defaultTable = array;
			}
			return array;
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00004888 File Offset: 0x00002A88
		private static uint CalculateHash(uint[] table, uint seed, global::System.Collections.Generic.IList<byte> buffer, int start, int size)
		{
			uint num = seed;
			for (int i = start; i < size - start; i++)
			{
				num = (num >> 8 ^ table[(int)((global::System.UIntPtr)((uint)buffer[i] ^ (num & 255U)))]);
			}
			return num;
		}

		// Token: 0x0600006C RID: 108 RVA: 0x000048C0 File Offset: 0x00002AC0
		private static byte[] UInt32ToBigEndianBytes(uint uint32)
		{
			return global::System.BitConverter.GetBytes(uint32);
		}

		// Token: 0x04000045 RID: 69
		public const uint DefaultPolynomial = 3988292384U;

		// Token: 0x04000046 RID: 70
		public const uint DefaultSeed = 4294967295U;

		// Token: 0x04000047 RID: 71
		private static uint[] defaultTable;

		// Token: 0x04000048 RID: 72
		private readonly uint seed;

		// Token: 0x04000049 RID: 73
		private readonly uint[] table;

		// Token: 0x0400004A RID: 74
		private uint hash;
	}
}
