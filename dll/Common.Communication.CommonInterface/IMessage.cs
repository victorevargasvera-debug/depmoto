using System;

namespace Motorola.Common.Communication
{
	// Token: 0x02000002 RID: 2
	public interface IMessage
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000001 RID: 1
		// (set) Token: 0x06000002 RID: 2
		int ReadTimeout { get; set; }

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000003 RID: 3
		// (set) Token: 0x06000004 RID: 4
		bool hasReply { get; set; }

		// Token: 0x06000005 RID: 5
		int BuildCommandMessage(byte[] sendBuffer);

		// Token: 0x06000006 RID: 6
		void DecodeReplyMessage(byte[] replyBuffer, int offset, int length);
	}
}
