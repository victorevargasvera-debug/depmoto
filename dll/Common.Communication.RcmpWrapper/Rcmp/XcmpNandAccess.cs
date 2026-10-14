using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x0200001C RID: 28
	public class XcmpNandAccess : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x06000046 RID: 70 RVA: 0x00003134 File Offset: 0x00001334
		public XcmpNandAccess(byte TransferType, ushort PartitionID, uint OptionFlag, uint StartID, uint EndID)
		{
			base.Opcode = 1091;
			this.m_xferType = TransferType;
			this.m_partID = PartitionID;
			this.m_optflg = OptionFlag;
			this.m_startID = StartID;
			this.m_endID = EndID;
		}

		// Token: 0x06000047 RID: 71 RVA: 0x0000316C File Offset: 0x0000136C
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

		// Token: 0x06000048 RID: 72 RVA: 0x000031DC File Offset: 0x000013DC
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

		// Token: 0x0400008A RID: 138
		private ushort m_partID;

		// Token: 0x0400008B RID: 139
		private uint m_optflg;

		// Token: 0x0400008C RID: 140
		private uint m_startID;

		// Token: 0x0400008D RID: 141
		private uint m_endID;

		// Token: 0x0400008E RID: 142
		private byte m_xferType;

		// Token: 0x0200001D RID: 29
		public enum TransferType : byte
		{
			// Token: 0x04000090 RID: 144
			Read,
			// Token: 0x04000091 RID: 145
			Write,
			// Token: 0x04000092 RID: 146
			Erase,
			// Token: 0x04000093 RID: 147
			Format
		}
	}
}
