using System;

namespace Motorola.Common.Communication
{
	// Token: 0x0200000D RID: 13
	public sealed class SrecLine
	{
		// Token: 0x06000026 RID: 38 RVA: 0x000026C1 File Offset: 0x000008C1
		public SrecLine(global::Motorola.Common.Communication.SrecType type, byte length, uint address, byte[] data, byte checksum)
		{
			this.type = type;
			this.recordLen = length;
			this.address = address;
			this.checksum = checksum;
			this.data = data;
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000027 RID: 39 RVA: 0x000026F4 File Offset: 0x000008F4
		public global::Motorola.Common.Communication.SrecType Type
		{
			get
			{
				return this.type;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000028 RID: 40 RVA: 0x0000270C File Offset: 0x0000090C
		internal byte RecordLen
		{
			get
			{
				return this.recordLen;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000029 RID: 41 RVA: 0x00002724 File Offset: 0x00000924
		public uint Address
		{
			get
			{
				return this.address;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600002A RID: 42 RVA: 0x0000273C File Offset: 0x0000093C
		private byte Checksum
		{
			get
			{
				return this.checksum;
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002754 File Offset: 0x00000954
		internal byte[] GetData()
		{
			return this.data;
		}

		// Token: 0x04000026 RID: 38
		private global::Motorola.Common.Communication.SrecType type;

		// Token: 0x04000027 RID: 39
		private byte recordLen;

		// Token: 0x04000028 RID: 40
		private uint address;

		// Token: 0x04000029 RID: 41
		private byte[] data;

		// Token: 0x0400002A RID: 42
		private byte checksum;
	}
}
