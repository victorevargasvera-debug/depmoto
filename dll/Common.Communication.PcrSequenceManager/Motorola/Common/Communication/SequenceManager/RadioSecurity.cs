using System;

namespace Motorola.Common.Communication.SequenceManager
{
	// Token: 0x0200004B RID: 75
	internal class RadioSecurity
	{
		// Token: 0x0600026E RID: 622 RVA: 0x0001679F File Offset: 0x0001499F
		private RadioSecurity()
		{
		}

		// Token: 0x0600026F RID: 623 RVA: 0x000167AC File Offset: 0x000149AC
		public static byte[] EncryptRadioKey(byte[] radioKey)
		{
			int num = 32;
			byte[] array = new byte[num];
			uint num2 = 1374194977U;
			for (int i = 0; i < num; i++)
			{
				byte b = radioKey[i];
				for (int j = 7; j > 0; j--)
				{
					int num3 = (int)((num2 >> 9 & 1U) ^ (uint)(radioKey[num - i - 1] >> j & 1));
					num2 = (num2 << 1) + (uint)num3;
					b ^= (byte)(num3 << j);
				}
				array[i] = b;
			}
			return array;
		}
	}
}
