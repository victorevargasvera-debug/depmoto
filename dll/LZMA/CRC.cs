using System;

namespace SevenZip
{
	// Token: 0x02000002 RID: 2
	internal class CRC
	{
		// Token: 0x06000001 RID: 1 RVA: 0x000020D0 File Offset: 0x000002D0
		static CRC()
		{
			for (uint num = 0U; num < 256U; num += 1U)
			{
				uint num2 = num;
				for (int i = 0; i < 8; i++)
				{
					if ((num2 & 1U) != 0U)
					{
						num2 = (num2 >> 1 ^ 3988292384U);
					}
					else
					{
						num2 >>= 1;
					}
				}
				global::SevenZip.CRC.Table[(int)((global::System.UIntPtr)num)] = num2;
			}
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002128 File Offset: 0x00000328
		public void Init()
		{
			this._value = uint.MaxValue;
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002131 File Offset: 0x00000331
		public void UpdateByte(byte b)
		{
			this._value = (global::SevenZip.CRC.Table[(int)((byte)this._value ^ b)] ^ this._value >> 8);
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002154 File Offset: 0x00000354
		public void Update(byte[] data, uint offset, uint size)
		{
			for (uint num = 0U; num < size; num += 1U)
			{
				this._value = (global::SevenZip.CRC.Table[(int)((byte)this._value ^ data[(int)((global::System.UIntPtr)(offset + num))])] ^ this._value >> 8);
			}
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002190 File Offset: 0x00000390
		public uint GetDigest()
		{
			return this._value ^ uint.MaxValue;
		}

		// Token: 0x06000006 RID: 6 RVA: 0x0000219C File Offset: 0x0000039C
		private static uint CalculateDigest(byte[] data, uint offset, uint size)
		{
			global::SevenZip.CRC crc = new global::SevenZip.CRC();
			crc.Update(data, offset, size);
			return crc.GetDigest();
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000021BE File Offset: 0x000003BE
		private static bool VerifyDigest(uint digest, byte[] data, uint offset, uint size)
		{
			return global::SevenZip.CRC.CalculateDigest(data, offset, size) == digest;
		}

		// Token: 0x04000001 RID: 1
		public static readonly uint[] Table = new uint[256];

		// Token: 0x04000002 RID: 2
		private uint _value = uint.MaxValue;
	}
}
