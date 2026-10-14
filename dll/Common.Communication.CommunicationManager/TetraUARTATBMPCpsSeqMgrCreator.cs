using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.SequenceManager;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x02000063 RID: 99
	[global::Motorola.Common.Communication.CommunicationManager.Initializer(global::Motorola.Common.Communication.CommonUtil.ConnectionType.RS232, global::Motorola.Common.Communication.CommonUtil.ProductFamily.GemstoneBMPAppRadio, global::Motorola.Common.Communication.CommonUtil.RadioStorage.Any, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Any)]
	internal class TetraUARTATBMPCpsSeqMgrCreator : global::Motorola.Common.Communication.CommunicationManager.ISequenceManagerCreator
	{
		// Token: 0x0600024C RID: 588 RVA: 0x0000C2A4 File Offset: 0x0000A4A4
		public global::Motorola.Common.Communication.ICpsSequenceManager Create(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe iCommPipe, global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter)
		{
			return this.newTetraBMPATSeqManager(iCommPipe, deviceInfo);
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x0600024D RID: 589 RVA: 0x0000C2BB File Offset: 0x0000A4BB
		public global::System.Type ExpectedType
		{
			get
			{
				return typeof(global::Motorola.Common.Communication.SequenceManager.TetraBMPATSeqManager);
			}
		}

		// Token: 0x0600024E RID: 590 RVA: 0x0000C2C7 File Offset: 0x0000A4C7
		private global::Motorola.Common.Communication.SequenceManager.TetraBMPATSeqManager newTetraBMPATSeqManager(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transport, global::Motorola.Common.Communication.CommonUtil.DeviceInfo devInfo)
		{
			return new global::Motorola.Common.Communication.SequenceManager.TetraBMPATSeqManager(transport, devInfo);
		}
	}
}
