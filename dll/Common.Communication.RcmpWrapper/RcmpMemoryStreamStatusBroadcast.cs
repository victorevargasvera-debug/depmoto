using System;
using System.Text;

namespace Motorola.Common.Communication
{
	// Token: 0x02000005 RID: 5
	public class RcmpMemoryStreamStatusBroadcast : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000010 RID: 16 RVA: 0x0000249C File Offset: 0x0000069C
		public global::Motorola.Common.Communication.MemoryStreamStatus Status
		{
			get
			{
				return this.status;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000011 RID: 17 RVA: 0x000024A4 File Offset: 0x000006A4
		public int Progress
		{
			get
			{
				return (int)this.progress;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000012 RID: 18 RVA: 0x000024AC File Offset: 0x000006AC
		public string FILEID
		{
			get
			{
				return global::System.Text.Encoding.ASCII.GetString(this.fileID);
			}
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000024C0 File Offset: 0x000006C0
		public RcmpMemoryStreamStatusBroadcast(string fID)
		{
			base.Opcode = 13378;
			this.fileID = global::System.Text.Encoding.ASCII.GetBytes(fID);
			if (this.fileID.Length > 4)
			{
				throw new global::System.ArgumentException("File ID is longer than " + 4 + " bytes");
			}
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002515 File Offset: 0x00000715
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			return 0;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002518 File Offset: 0x00000718
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			global::Motorola.Common.Communication.RcmpCommon.CheckReplyHeader(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.RcmpCommon.RcmpReplyOpcodeFlag);
			base.ReplyResult = global::Motorola.Common.Communication.RcmpReplyResult.Success;
			if (base.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				object[] array = new object[]
				{
					global::Motorola.Common.Communication.RcmpCommon.byteObj,
					new byte[4],
					global::Motorola.Common.Communication.RcmpCommon.byteObj
				};
				global::Motorola.Common.Communication.RcmpCommon.DecodeBytes(replyBuffer, offset + 2, length - 2, array);
				this.status = (global::Motorola.Common.Communication.MemoryStreamStatus)array[0];
				this.fileID = (byte[])array[1];
				this.progress = (byte)array[2];
			}
		}

		// Token: 0x0400000E RID: 14
		private const int MaxFileIDLength = 4;

		// Token: 0x0400000F RID: 15
		public static readonly double FLASH_PROGRESS_PROPORTION = 0.2;

		// Token: 0x04000010 RID: 16
		private global::Motorola.Common.Communication.MemoryStreamStatus status;

		// Token: 0x04000011 RID: 17
		private byte progress;

		// Token: 0x04000012 RID: 18
		private byte[] fileID;
	}
}
