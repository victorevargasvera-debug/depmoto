using System;

namespace Motorola.Common.Communication
{
	// Token: 0x02000019 RID: 25
	internal class RadioSecurity
	{
		// Token: 0x06000127 RID: 295 RVA: 0x00008BBF File Offset: 0x00006DBF
		private RadioSecurity()
		{
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00008BC8 File Offset: 0x00006DC8
		public static byte[] EncryptRadioKey(byte[] radioKey)
		{
			int num = 32;
			byte[] array = new byte[num];
			uint num2 = 2260377433U;
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
