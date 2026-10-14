using System;
using System.Text;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication
{
	// Token: 0x02000003 RID: 3
	public class RcmpMemoryStreamReadBroadcast : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000B RID: 11 RVA: 0x0000239F File Offset: 0x0000059F
		private uint SizeOfDataBlock
		{
			get
			{
				return this.sizeOfDataBlock;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000C RID: 12 RVA: 0x000023A7 File Offset: 0x000005A7
		public byte[] DataBlock
		{
			get
			{
				return this.data;
			}
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000023B0 File Offset: 0x000005B0
		public RcmpMemoryStreamReadBroadcast(string fileID)
		{
			base.Opcode = 13376;
			this.fileID = global::System.Text.Encoding.ASCII.GetBytes(fileID);
			if (this.fileID.Length > 4)
			{
				throw new global::System.ArgumentException("File ID is longer than " + 4 + " bytes");
			}
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002405 File Offset: 0x00000605
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			return 0;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002408 File Offset: 0x00000608
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			global::Motorola.Common.Communication.RcmpCommon.CheckReplyHeader(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.RcmpCommon.RcmpReplyOpcodeFlag);
			base.ReplyResult = global::Motorola.Common.Communication.RcmpReplyResult.Success;
			if (base.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				object[] array = new object[]
				{
					new byte[4],
					global::Motorola.Common.Communication.RcmpCommon.uintObj,
					global::Motorola.Common.Communication.RcmpCommon.byteArrayObj
				};
				global::Motorola.Common.Communication.RcmpCommon.DecodeBytes(replyBuffer, offset + 2, length - 2, array);
				this.sizeOfDataBlock = (uint)array[1];
				this.data = (byte[])array[2];
				if ((long)this.data.Length != (long)((ulong)this.sizeOfDataBlock))
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidRcmpBroadcastMsgSize);
				}
			}
		}

		// Token: 0x04000004 RID: 4
		private const int MaxFileIDLength = 4;

		// Token: 0x04000005 RID: 5
		private byte[] fileID;

		// Token: 0x04000006 RID: 6
		private byte[] data;

		// Token: 0x04000007 RID: 7
		private uint sizeOfDataBlock;
	}
}
