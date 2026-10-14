using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.SequenceManager;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x02000030 RID: 48
	[global::Motorola.Common.Communication.CommunicationManager.Initializer(global::Motorola.Common.Communication.CommonUtil.ConnectionType.Otap, (global::Motorola.Common.Communication.CommonUtil.ProductFamily)24, global::Motorola.Common.Communication.CommonUtil.RadioStorage.Any, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Any)]
	internal class PcrOtapCpsSequenceManagerCreator : global::Motorola.Common.Communication.CommunicationManager.ISequenceManagerCreator
	{
		// Token: 0x06000151 RID: 337 RVA: 0x000074EC File Offset: 0x000056EC
		public global::Motorola.Common.Communication.ICpsSequenceManager Create(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe iCommPipe, global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter)
		{
			global::Motorola.Common.Communication.SequenceManager.PcrRcmpMessageExecutor messageExecutor = global::Motorola.Common.Communication.CommunicationManager.newMessageExecutor.newPRMessageExecutor(iCommPipe, 15000);
			return new global::Motorola.Common.Communication.SequenceManager.PcrOtapCpsSequenceManager(messageExecutor, 1973);
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000152 RID: 338 RVA: 0x00007512 File Offset: 0x00005712
		public global::System.Type ExpectedType
		{
			get
			{
				return typeof(global::Motorola.Common.Communication.SequenceManager.PcrOtapCpsSequenceManager);
			}
		}
	}
}
