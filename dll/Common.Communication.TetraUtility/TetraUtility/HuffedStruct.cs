using System;

namespace Motorola.Common.Communication.TetraUtility
{
	// Token: 0x0200001C RID: 28
	public struct HuffedStruct
	{
		// Token: 0x0400006B RID: 107
		public unsafe byte* pHuffPromptDataTable;

		// Token: 0x0400006C RID: 108
		public unsafe byte* pHuffDecodeTable;

		// Token: 0x0400006D RID: 109
		public unsafe byte* pHuffOffsetTable;

		// Token: 0x0400006E RID: 110
		public uint nHuffPromptDataTableSize;

		// Token: 0x0400006F RID: 111
		public uint nHuffDecodeTableSize;

		// Token: 0x04000070 RID: 112
		public uint nHuffOffsetTableSize;
	}
}
