using System;
using Motorola.Common.Communication.CommunicationPipe;

namespace Motorola.Common.Communication
{
	// Token: 0x0200000D RID: 13
	public interface IMessageExecutor
	{
		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000068 RID: 104
		// (set) Token: 0x06000069 RID: 105
		global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe CommPipe { get; set; }

		// Token: 0x0600006A RID: 106
		void Setup();

		// Token: 0x0600006B RID: 107
		void TearDown();

		// Token: 0x0600006C RID: 108
		void SendAndReceiveMessage(global::Motorola.Common.Communication.IMessage msg);

		// Token: 0x0600006D RID: 109
		void SetRxTimeoutTimer(int timeout);
	}
}
