using System;

namespace Motorola.Common.Communication.TetraUtility
{
	// Token: 0x02000017 RID: 23
	public static class ByteOrderOp
	{
		// Token: 0x060000CE RID: 206 RVA: 0x00006E74 File Offset: 0x00005074
		public static void ReverseBytesRaw(ref uint value)
		{
			byte[] bytes = global::System.BitConverter.GetBytes(value);
			uint num = 0U;
			value = (uint)((int)bytes[(int)((global::System.UIntPtr)num)] << 24 | (int)bytes[(int)((global::System.UIntPtr)(num + 1U))] << 16 | (int)bytes[(int)((global::System.UIntPtr)(num + 2U))] << 8 | (int)bytes[(int)((global::System.UIntPtr)(num + 3U))]);
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00006EB0 File Offset: 0x000050B0
		public static void ReverseBytesRaw(ref ushort value)
		{
			byte[] bytes = global::System.BitConverter.GetBytes(value);
			uint num = 0U;
			value = (ushort)((int)bytes[(int)((global::System.UIntPtr)num)] << 8 | (int)bytes[(int)((global::System.UIntPtr)(num + 1U))]);
		}
	}
}
