using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;

namespace Motorola.Common.Communication
{
	// Token: 0x02000004 RID: 4
	public class CommunicationSession
	{
		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000014 RID: 20 RVA: 0x00002134 File Offset: 0x00000334
		// (set) Token: 0x06000015 RID: 21 RVA: 0x0000213C File Offset: 0x0000033C
		public ushort ID { get; private set; }

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000016 RID: 22 RVA: 0x00002145 File Offset: 0x00000345
		// (set) Token: 0x06000017 RID: 23 RVA: 0x0000214D File Offset: 0x0000034D
		public global::Motorola.Common.Communication.CommonUtil.RadioOperation OperationType { get; set; }

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000018 RID: 24 RVA: 0x00002156 File Offset: 0x00000356
		// (set) Token: 0x06000019 RID: 25 RVA: 0x0000215E File Offset: 0x0000035E
		public global::Motorola.Common.Communication.ICpsSequenceManager SequenceManager { get; set; }

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600001A RID: 26 RVA: 0x00002167 File Offset: 0x00000367
		// (set) Token: 0x0600001B RID: 27 RVA: 0x0000216F File Offset: 0x0000036F
		public global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe CommunicationPipe { get; private set; }

		// Token: 0x0600001C RID: 28 RVA: 0x00002178 File Offset: 0x00000378
		public CommunicationSession(ushort sessionID, global::Motorola.Common.Communication.CommonUtil.RadioOperation operationType, global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe communicationPipe, global::Motorola.Common.Communication.ICpsSequenceManager sequenceManager)
		{
			this.ID = sessionID;
			this.CommunicationPipe = communicationPipe;
			this.SequenceManager = sequenceManager;
			this.OperationType = operationType;
		}
	}
}
