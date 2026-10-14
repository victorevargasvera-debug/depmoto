using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.SequenceManager;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x02000033 RID: 51
	[global::Motorola.Common.Communication.CommunicationManager.Initializer(global::Motorola.Common.Communication.CommonUtil.ConnectionType.Fudally, global::Motorola.Common.Communication.CommonUtil.ProductFamily.ParadiseRepeaterRadio, global::Motorola.Common.Communication.CommonUtil.RadioStorage.Any, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Flash)]
	internal class PcrBahamaDeviceUpdateBootSequencerManagerCreator : global::Motorola.Common.Communication.CommunicationManager.ISequenceManagerCreator
	{
		// Token: 0x0600015A RID: 346 RVA: 0x000075BC File Offset: 0x000057BC
		public global::Motorola.Common.Communication.ICpsSequenceManager Create(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe iCommPipe, global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter)
		{
			global::Motorola.Common.Communication.ICpsSequenceManager result;
			using (global::Motorola.Common.Communication.SequenceManager.PcrRcmpMessageExecutor pcrRcmpMessageExecutor = new global::Motorola.Common.Communication.SequenceManager.PcrRcmpMessageExecutor(iCommPipe, 20000))
			{
				global::Motorola.Common.Communication.ICpsSequenceManager cpsSequenceManager = new global::Motorola.Common.Communication.SequenceManager.PcrBahamaDeviceUpdateBootSequencer(pcrRcmpMessageExecutor, 1000);
				result = cpsSequenceManager;
			}
			return result;
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x0600015B RID: 347 RVA: 0x00007600 File Offset: 0x00005800
		public global::System.Type ExpectedType
		{
			get
			{
				return typeof(global::Motorola.Common.Communication.SequenceManager.PcrBahamaDeviceUpdateBootSequencer);
			}
		}
	}
}
