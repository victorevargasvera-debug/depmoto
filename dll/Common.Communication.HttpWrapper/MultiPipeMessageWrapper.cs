using System;

namespace Motorola.Common.Communication
{
	// Token: 0x02000019 RID: 25
	public class MultiPipeMessageWrapper : global::Motorola.Common.Communication.BaseMessage
	{
		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600003C RID: 60 RVA: 0x00002AE4 File Offset: 0x00000CE4
		// (set) Token: 0x0600003D RID: 61 RVA: 0x00002AEC File Offset: 0x00000CEC
		public int ExecutorID { get; private set; }

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600003E RID: 62 RVA: 0x00002AF5 File Offset: 0x00000CF5
		// (set) Token: 0x0600003F RID: 63 RVA: 0x00002AFD File Offset: 0x00000CFD
		public global::Motorola.Common.Communication.IMessage Message { get; private set; }

		// Token: 0x06000040 RID: 64 RVA: 0x00002B06 File Offset: 0x00000D06
		public MultiPipeMessageWrapper(int executorID, global::Motorola.Common.Communication.IMessage wrappedMessage)
		{
			this.ExecutorID = executorID;
			this.Message = wrappedMessage;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002B1C File Offset: 0x00000D1C
		public override int BuildCommandMessage(byte[] sendBuffer)
		{
			return this.Message.BuildCommandMessage(sendBuffer);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002B2A File Offset: 0x00000D2A
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			this.Message.DecodeReplyMessage(replyBuffer, offset, length);
		}
	}
}
