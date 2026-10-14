using System;
using System.Text;

namespace Motorola.Common.Communication
{
	// Token: 0x02000006 RID: 6
	public class RcmpMemoryStreamWriteBroadcast : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000017 RID: 23 RVA: 0x000025B0 File Offset: 0x000007B0
		private uint NumOfDataBlock
		{
			get
			{
				return this.numOfDataBlock;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000018 RID: 24 RVA: 0x000025B8 File Offset: 0x000007B8
		private byte[] DataBlock
		{
			get
			{
				return this.data;
			}
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000025C0 File Offset: 0x000007C0
		public RcmpMemoryStreamWriteBroadcast(string fileID, uint numOfDataBlk, byte[] dataBlk)
		{
			base.Opcode = 46145;
			this.fileID = global::System.Text.Encoding.ASCII.GetBytes(fileID);
			if (this.fileID.Length > 4)
			{
				throw new global::System.ArgumentException("File ID is longer than " + 4 + " bytes");
			}
			this.numOfDataBlock = numOfDataBlk;
			this.data = dataBlk;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002624 File Offset: 0x00000824
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			base.ReplyResult = global::Motorola.Common.Communication.RcmpReplyResult.Success;
			return global::Motorola.Common.Communication.RcmpCommon.ConstructBytes(buffer, offset, new object[]
			{
				base.Opcode,
				this.fileID,
				this.numOfDataBlock,
				this.data
			});
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002675 File Offset: 0x00000875
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
		}

		// Token: 0x04000013 RID: 19
		private const int MaxFileIDLength = 4;

		// Token: 0x04000014 RID: 20
		private byte[] fileID;

		// Token: 0x04000015 RID: 21
		private byte[] data;

		// Token: 0x04000016 RID: 22
		private uint numOfDataBlock;
	}
}
