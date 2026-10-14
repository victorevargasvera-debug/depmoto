using System;

namespace Motorola.Common.Communication.TetraUtility
{
	// Token: 0x0200001B RID: 27
	public struct HuffedStructCS
	{
		// Token: 0x04000064 RID: 100
		public byte[] huffData;

		// Token: 0x04000065 RID: 101
		public uint huffPromptDataPtr;

		// Token: 0x04000066 RID: 102
		public uint huffDecodeTablePtr;

		// Token: 0x04000067 RID: 103
		public uint huffOffsetTablePtr;

		// Token: 0x04000068 RID: 104
		public uint huffPromptDataTableSize;

		// Token: 0x04000069 RID: 105
		public uint huffDecodeTableSize;

		// Token: 0x0400006A RID: 106
		public uint huffOffsetTableSize;
	}
}
