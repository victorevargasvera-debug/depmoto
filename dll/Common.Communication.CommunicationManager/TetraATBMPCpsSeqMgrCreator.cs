using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.SequenceManager;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x0200005D RID: 93
	[global::Motorola.Common.Communication.CommunicationManager.Initializer(global::Motorola.Common.Communication.CommonUtil.ConnectionType.VCOM, global::Motorola.Common.Communication.CommonUtil.ProductFamily.GemstoneBMPAppRadio, global::Motorola.Common.Communication.CommonUtil.RadioStorage.Any, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Any)]
	internal class TetraATBMPCpsSeqMgrCreator : global::Motorola.Common.Communication.CommunicationManager.ISequenceManagerCreator
	{
		// Token: 0x06000234 RID: 564 RVA: 0x0000C16C File Offset: 0x0000A36C
		public global::Motorola.Common.Communication.ICpsSequenceManager Create(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe iCommPipe, global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter)
		{
			return this.newTetraBMPATSeqManager(iCommPipe, deviceInfo);
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000235 RID: 565 RVA: 0x0000C183 File Offset: 0x0000A383
		public global::System.Type ExpectedType
		{
			get
			{
				return typeof(global::Motorola.Common.Communication.SequenceManager.TetraBMPATSeqManager);
			}
		}

		// Token: 0x06000236 RID: 566 RVA: 0x0000C18F File Offset: 0x0000A38F
		private global::Motorola.Common.Communication.SequenceManager.TetraBMPATSeqManager newTetraBMPATSeqManager(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transport, global::Motorola.Common.Communication.CommonUtil.DeviceInfo devInfo)
		{
			return new global::Motorola.Common.Communication.SequenceManager.TetraBMPATSeqManager(transport, devInfo);
		}
	}
}
