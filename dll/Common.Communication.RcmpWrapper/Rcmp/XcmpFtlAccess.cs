using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x02000016 RID: 22
	public class XcmpFtlAccess : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x06000038 RID: 56 RVA: 0x00002CDB File Offset: 0x00000EDB
		public XcmpFtlAccess(byte TransferType, ushort PartitionID, uint OptionFlag, uint StartID, uint EndID)
		{
			base.Opcode = 1092;
			this.m_xferType = TransferType;
			this.m_partID = PartitionID;
			this.m_optflg = OptionFlag;
			this.m_startID = StartID;
			this.m_endID = EndID;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002D14 File Offset: 0x00000F14
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			return global::Motorola.Common.Communication.RcmpCommon.ConstructBytes(buffer, offset, new object[]
			{
				base.Opcode,
				this.m_xferType,
				this.m_partID,
				this.m_optflg,
				this.m_startID,
				this.m_endID
			});
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002D84 File Offset: 0x00000F84
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			base.ReplyResult = global::Motorola.Common.Communication.RcmpCommon.CheckReplyHeader(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.RcmpCommon.RcmpReplyOpcodeFlag);
			if (base.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success && length >= global::Motorola.Common.Communication.RcmpCommon.RcmpBasicReplyHeaderSize + 17)
			{
				this.m_xferType = replyBuffer[offset + 3];
				this.m_partID = (ushort)((int)replyBuffer[offset + 5] | (int)replyBuffer[offset + 4] << 8);
				this.m_optflg = (uint)((int)replyBuffer[offset + 9] | (int)replyBuffer[offset + 8] << 8 | (int)replyBuffer[offset + 7] << 16 | (int)replyBuffer[offset + 6] << 24);
				this.m_startID = (uint)((int)replyBuffer[offset + 13] | (int)replyBuffer[offset + 12] << 8 | (int)replyBuffer[offset + 11] << 16 | (int)replyBuffer[offset + 10] << 24);
				this.m_endID = (uint)((int)replyBuffer[offset + 17] | (int)replyBuffer[offset + 16] << 8 | (int)replyBuffer[offset + 15] << 16 | (int)replyBuffer[offset + 14] << 24);
			}
		}

		// Token: 0x0400005B RID: 91
		private ushort m_partID;

		// Token: 0x0400005C RID: 92
		private uint m_optflg;

		// Token: 0x0400005D RID: 93
		private uint m_startID;

		// Token: 0x0400005E RID: 94
		private uint m_endID;

		// Token: 0x0400005F RID: 95
		private byte m_xferType;

		// Token: 0x02000017 RID: 23
		public enum TransferType : byte
		{
			// Token: 0x04000061 RID: 97
			Read,
			// Token: 0x04000062 RID: 98
			Write,
			// Token: 0x04000063 RID: 99
			Erase
		}
	}
}
