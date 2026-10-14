using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x0200006F RID: 111
	public class XcmpISHDeleteType : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000196 RID: 406 RVA: 0x00007CA2 File Offset: 0x00005EA2
		private byte Partition
		{
			get
			{
				return this.m_Partition;
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000197 RID: 407 RVA: 0x00007CAA File Offset: 0x00005EAA
		private ushort StartType
		{
			get
			{
				return this.m_StartType;
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000198 RID: 408 RVA: 0x00007CB2 File Offset: 0x00005EB2
		private ushort EndType
		{
			get
			{
				return this.m_EndType;
			}
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00007CBA File Offset: 0x00005EBA
		public XcmpISHDeleteType(byte partition, ushort startType, ushort endType)
		{
			base.Opcode = 259;
			this.m_Partition = partition;
			this.m_StartType = startType;
			this.m_EndType = endType;
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00007CE4 File Offset: 0x00005EE4
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			return global::Motorola.Common.Communication.RcmpCommon.ConstructBytes(buffer, offset, new object[]
			{
				base.Opcode,
				this.m_Partition,
				this.m_StartType,
				this.m_EndType
			});
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00007D38 File Offset: 0x00005F38
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			base.ReplyResult = global::Motorola.Common.Communication.RcmpCommon.CheckReplyHeader(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.RcmpCommon.RcmpReplyOpcodeFlag);
			if (length > global::Motorola.Common.Communication.RcmpCommon.RcmpBasicReplyHeaderSize)
			{
				object[] array = new object[6];
				array[0] = global::Motorola.Common.Communication.RcmpCommon.byteObj;
				array[1] = global::Motorola.Common.Communication.RcmpCommon.ushortObj;
				array[2] = global::Motorola.Common.Communication.RcmpCommon.ushortObj;
				global::Motorola.Common.Communication.RcmpCommon.DecodeBytes(replyBuffer, offset + global::Motorola.Common.Communication.RcmpCommon.RcmpBasicReplyHeaderSize, length - global::Motorola.Common.Communication.RcmpCommon.RcmpBasicReplyHeaderSize, array);
				this.m_Partition = (byte)array[0];
				this.m_StartType = (ushort)array[1];
				this.m_EndType = (ushort)array[2];
			}
		}

		// Token: 0x04000230 RID: 560
		private byte m_Partition;

		// Token: 0x04000231 RID: 561
		private ushort m_StartType;

		// Token: 0x04000232 RID: 562
		private ushort m_EndType;
	}
}
