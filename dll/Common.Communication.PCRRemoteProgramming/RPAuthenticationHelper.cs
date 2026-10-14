using System;
using System.Collections;

namespace Motorola.Common.Communication.PCRRemoteProgramming
{
	// Token: 0x02000010 RID: 16
	internal class RPAuthenticationHelper
	{
		// Token: 0x0600003A RID: 58 RVA: 0x000032D0 File Offset: 0x000014D0
		public static void AddTCPHeader(byte[] input, out byte[] output)
		{
			ushort num = (ushort)input.Length;
			output = new byte[2 + input.Length];
			output[0] = (byte)((uint)(num & 65280) >> 8);
			output[1] = (byte)(num & 255);
			int num2 = 2;
			for (int i = 0; i < input.Length; i++)
			{
				output[num2] = input[i];
				num2++;
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00003324 File Offset: 0x00001524
		public static global::System.Collections.ArrayList CvtUnicodeString2ByteArrayList(string guiValue)
		{
			global::System.Collections.ArrayList arrayList = new global::System.Collections.ArrayList();
			int length = guiValue.Length;
			for (int i = 0; i < length; i++)
			{
				int num = (int)guiValue[i];
				for (int j = 1; j >= 0; j--)
				{
					int num2 = num / (int)global::System.Math.Pow((double)global::Motorola.Common.Communication.PCRRemoteProgramming.PCRRPConstants.UINT_256, (double)j);
					num -= num2 * (int)global::System.Math.Pow((double)global::Motorola.Common.Communication.PCRRemoteProgramming.PCRRPConstants.UINT_256, (double)j);
					arrayList.Add((byte)num2);
				}
			}
			return arrayList;
		}
	}
}
