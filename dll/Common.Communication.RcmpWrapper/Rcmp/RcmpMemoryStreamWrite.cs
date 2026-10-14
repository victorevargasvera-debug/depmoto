using System;
using System.Text;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x02000027 RID: 39
	public class RcmpMemoryStreamWrite : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x0600005B RID: 91 RVA: 0x00003818 File Offset: 0x00001A18
		public RcmpMemoryStreamWrite(string fileID, uint sizeOfDataBlock)
		{
			base.Opcode = 1089;
			this.fileID = global::System.Text.Encoding.ASCII.GetBytes(fileID);
			if (this.fileID.Length > 4)
			{
				throw new global::System.ArgumentException("File ID is longer than " + 4 + " bytes");
			}
			this.sizeOfDataBlock = sizeOfDataBlock;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00003874 File Offset: 0x00001A74
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			return global::Motorola.Common.Communication.RcmpCommon.ConstructBytes(buffer, offset, new object[]
			{
				base.Opcode,
				this.fileID,
				this.sizeOfDataBlock
			});
		}

		// Token: 0x0600005D RID: 93 RVA: 0x000038B5 File Offset: 0x00001AB5
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			base.ReplyResult = global::Motorola.Common.Communication.RcmpCommon.CheckReplyHeader(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.RcmpCommon.RcmpReplyOpcodeFlag);
		}

		// Token: 0x040000AF RID: 175
		private const int MaxFileIDLength = 4;

		// Token: 0x040000B0 RID: 176
		private uint sizeOfDataBlock;

		// Token: 0x040000B1 RID: 177
		private byte[] fileID;
	}
}
