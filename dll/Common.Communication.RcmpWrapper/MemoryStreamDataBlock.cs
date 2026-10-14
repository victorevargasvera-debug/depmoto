using System;

namespace Motorola.Common.Communication
{
	// Token: 0x02000007 RID: 7
	public class MemoryStreamDataBlock
	{
		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600001C RID: 28 RVA: 0x00002677 File Offset: 0x00000877
		// (set) Token: 0x0600001D RID: 29 RVA: 0x0000267F File Offset: 0x0000087F
		private uint StartAddress { get; set; }

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600001E RID: 30 RVA: 0x00002688 File Offset: 0x00000888
		// (set) Token: 0x0600001F RID: 31 RVA: 0x00002690 File Offset: 0x00000890
		private uint DataBlockSize { get; set; }

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000020 RID: 32 RVA: 0x00002699 File Offset: 0x00000899
		// (set) Token: 0x06000021 RID: 33 RVA: 0x000026A1 File Offset: 0x000008A1
		private byte[] Data { get; set; }

		// Token: 0x06000022 RID: 34 RVA: 0x000026AA File Offset: 0x000008AA
		public MemoryStreamDataBlock(uint StartAddr, uint DataBlkSize, byte[] data)
		{
			this.StartAddress = StartAddr;
			this.DataBlockSize = DataBlkSize;
			this.Data = data;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000026C8 File Offset: 0x000008C8
		public int Pack(byte[] buffer, int offset)
		{
			return global::Motorola.Common.Communication.RcmpCommon.ConstructBytes(buffer, offset, new object[]
			{
				this.StartAddress,
				this.DataBlockSize,
				this.Data
			});
		}

		// Token: 0x04000017 RID: 23
		public static readonly int DataBlockHdrSize = 8;
	}
}
