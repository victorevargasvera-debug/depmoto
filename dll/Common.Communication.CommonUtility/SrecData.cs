using System;

namespace Motorola.Common.Communication
{
	// Token: 0x02000009 RID: 9
	public sealed class SrecData
	{
		// Token: 0x06000013 RID: 19 RVA: 0x00002408 File Offset: 0x00000608
		public SrecData(uint length, uint address, byte[] dataArr, global::Motorola.Common.Communication.SrecType type)
		{
			this.dataLen = length;
			this.address = address;
			this.data = new byte[length];
			this.type = type;
			if (dataArr != null)
			{
				global::System.Array.Copy(dataArr, this.data, (long)((ulong)length));
			}
			else
			{
				this.data = null;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000014 RID: 20 RVA: 0x00002468 File Offset: 0x00000668
		public uint DataLen
		{
			get
			{
				return this.dataLen;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000015 RID: 21 RVA: 0x00002480 File Offset: 0x00000680
		public uint Address
		{
			get
			{
				return this.address;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000016 RID: 22 RVA: 0x00002498 File Offset: 0x00000698
		public global::Motorola.Common.Communication.SrecType Type
		{
			get
			{
				return this.type;
			}
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000024B0 File Offset: 0x000006B0
		public byte[] GetData()
		{
			return this.data;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000024C8 File Offset: 0x000006C8
		private void Clear()
		{
			this.data = null;
		}

		// Token: 0x04000019 RID: 25
		private uint dataLen;

		// Token: 0x0400001A RID: 26
		private uint address;

		// Token: 0x0400001B RID: 27
		private byte[] data;

		// Token: 0x0400001C RID: 28
		private global::Motorola.Common.Communication.SrecType type;
	}
}
