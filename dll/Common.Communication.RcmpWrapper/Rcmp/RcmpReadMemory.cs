using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x02000028 RID: 40
	public class RcmpReadMemory : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600005E RID: 94 RVA: 0x000038D1 File Offset: 0x00001AD1
		private uint Address
		{
			get
			{
				return this.address;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600005F RID: 95 RVA: 0x000038D9 File Offset: 0x00001AD9
		public byte[] ByteData
		{
			get
			{
				return this.byteData;
			}
		}

		// Token: 0x06000060 RID: 96 RVA: 0x000038E1 File Offset: 0x00001AE1
		public RcmpReadMemory(uint address, ushort byteCount)
		{
			base.Opcode = 513;
			this.address = address;
			this.byteCount = byteCount;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00003904 File Offset: 0x00001B04
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			return global::Motorola.Common.Communication.RcmpCommon.ConstructBytes(buffer, offset, new object[]
			{
				base.Opcode,
				this.address,
				this.byteCount
			});
		}

		// Token: 0x06000062 RID: 98 RVA: 0x0000394C File Offset: 0x00001B4C
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			base.ReplyResult = global::Motorola.Common.Communication.RcmpCommon.CheckReplyHeader(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.RcmpCommon.RcmpReplyOpcodeFlag);
			if (base.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				object[] array = new object[]
				{
					global::Motorola.Common.Communication.RcmpCommon.uintObj,
					global::Motorola.Common.Communication.RcmpCommon.ushortObj,
					global::Motorola.Common.Communication.RcmpCommon.byteArrayObj
				};
				global::Motorola.Common.Communication.RcmpCommon.DecodeBytes(replyBuffer, offset + global::Motorola.Common.Communication.RcmpCommon.RcmpBasicReplyHeaderSize, length - global::Motorola.Common.Communication.RcmpCommon.RcmpBasicReplyHeaderSize, array);
				this.address = (uint)array[0];
				this.byteCount = (ushort)array[1];
				this.byteData = (byte[])array[2];
				if (this.byteData.Length != (int)this.byteCount)
				{
					throw new global::System.ArgumentOutOfRangeException("byteCount", "data size is not equal to byteCount");
				}
			}
		}

		// Token: 0x040000B2 RID: 178
		private uint address;

		// Token: 0x040000B3 RID: 179
		private ushort byteCount;

		// Token: 0x040000B4 RID: 180
		private byte[] byteData;
	}
}
