using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.SequenceManager;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x02000032 RID: 50
	[global::Motorola.Common.Communication.CommunicationManager.Initializer(global::Motorola.Common.Communication.CommonUtil.ConnectionType.Fudally, global::Motorola.Common.Communication.CommonUtil.ProductFamily.ParadiseRadio, global::Motorola.Common.Communication.CommonUtil.RadioStorage.Any, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Flash | global::Motorola.Common.Communication.CommonUtil.RadioOperation.DepotFlash)]
	internal class PcrFileSystemDeviceUpdateBootSequenceManagerCreator : global::Motorola.Common.Communication.CommunicationManager.ISequenceManagerCreator
	{
		// Token: 0x06000157 RID: 343 RVA: 0x00007564 File Offset: 0x00005764
		public global::Motorola.Common.Communication.ICpsSequenceManager Create(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe iCommPipe, global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter)
		{
			global::Motorola.Common.Communication.ICpsSequenceManager result;
			using (global::Motorola.Common.Communication.SequenceManager.PcrRcmpMessageExecutor pcrRcmpMessageExecutor = new global::Motorola.Common.Communication.SequenceManager.PcrRcmpMessageExecutor(iCommPipe, 20000))
			{
				global::Motorola.Common.Communication.ICpsSequenceManager cpsSequenceManager = new global::Motorola.Common.Communication.SequenceManager.PcrFileSystemDeviceUpdateBootSequencer(pcrRcmpMessageExecutor, 1000);
				result = cpsSequenceManager;
			}
			return result;
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000158 RID: 344 RVA: 0x000075A8 File Offset: 0x000057A8
		public global::System.Type ExpectedType
		{
			get
			{
				return typeof(global::Motorola.Common.Communication.SequenceManager.PcrFileSystemDeviceUpdateBootSequencer);
			}
		}
	}
}
