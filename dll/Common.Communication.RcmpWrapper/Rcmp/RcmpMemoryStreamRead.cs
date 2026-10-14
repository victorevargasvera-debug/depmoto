using System;
using System.Text;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x02000026 RID: 38
	public class RcmpMemoryStreamRead : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000057 RID: 87 RVA: 0x00003718 File Offset: 0x00001918
		private uint SizeOfDataBlock
		{
			get
			{
				return this.sizeOfDataBlock;
			}
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00003720 File Offset: 0x00001920
		public RcmpMemoryStreamRead(string fileID)
		{
			base.Opcode = 1088;
			this.fileID = global::System.Text.Encoding.ASCII.GetBytes(fileID);
			if (this.fileID.Length > 4)
			{
				throw new global::System.ArgumentException("File ID is longer than " + 4 + " bytes");
			}
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00003778 File Offset: 0x00001978
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			return global::Motorola.Common.Communication.RcmpCommon.ConstructBytes(buffer, offset, new object[]
			{
				base.Opcode,
				this.fileID
			});
		}

		// Token: 0x0600005A RID: 90 RVA: 0x000037AC File Offset: 0x000019AC
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			base.ReplyResult = global::Motorola.Common.Communication.RcmpCommon.CheckReplyHeader(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.RcmpCommon.RcmpReplyOpcodeFlag);
			if (base.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				object[] array = new object[]
				{
					new byte[4],
					global::Motorola.Common.Communication.RcmpCommon.uintObj
				};
				global::Motorola.Common.Communication.RcmpCommon.DecodeBytes(replyBuffer, offset + global::Motorola.Common.Communication.RcmpCommon.RcmpBasicReplyHeaderSize, length - global::Motorola.Common.Communication.RcmpCommon.RcmpBasicReplyHeaderSize, array);
				this.sizeOfDataBlock = (uint)array[1];
			}
		}

		// Token: 0x040000AC RID: 172
		private const int MaxFileIDLength = 4;

		// Token: 0x040000AD RID: 173
		private uint sizeOfDataBlock;

		// Token: 0x040000AE RID: 174
		private byte[] fileID;
	}
}
