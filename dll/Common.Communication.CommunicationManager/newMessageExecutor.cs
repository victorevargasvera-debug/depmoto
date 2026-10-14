using System;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.SequenceManager;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x0200003E RID: 62
	internal class newMessageExecutor
	{
		// Token: 0x0600017B RID: 379 RVA: 0x000078F5 File Offset: 0x00005AF5
		public static global::Motorola.Common.Communication.SequenceManager.PcrRcmpMessageExecutor newPRMessageExecutor(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe iCommPipe, int Timeout)
		{
			return new global::Motorola.Common.Communication.SequenceManager.PcrRcmpMessageExecutor(iCommPipe, Timeout);
		}

		// Token: 0x0600017C RID: 380 RVA: 0x000078FE File Offset: 0x00005AFE
		public static global::Motorola.Common.Communication.SequenceManager.PCRRPRcmpMessageExecutor newPCRRPRMessageExecutor(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe iCommPipe, int Timeout)
		{
			return new global::Motorola.Common.Communication.SequenceManager.PCRRPRcmpMessageExecutor(iCommPipe, Timeout);
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00007907 File Offset: 0x00005B07
		public static global::Motorola.Common.Communication.SequenceManager.PcrRcmpMessageExecutor newWiFiMessageExecutor(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe iCommPipe, int Timeout)
		{
			return new global::Motorola.Common.Communication.SequenceManager.PCRWiFiXcmpMessageExecutor(iCommPipe, Timeout);
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00007910 File Offset: 0x00005B10
		public static global::Motorola.Common.Communication.HttpMessageExecutor newHttpMessageExecutor(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe iCommPipe)
		{
			return new global::Motorola.Common.Communication.HttpMessageExecutor(iCommPipe);
		}
	}
}
