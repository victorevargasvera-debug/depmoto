using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x0200002A RID: 42
	[global::Motorola.Common.Communication.CommunicationManager.Initializer(global::Motorola.Common.Communication.CommonUtil.ConnectionType.Fudally, global::Motorola.Common.Communication.CommonUtil.ProductFamily.PCRRadio, global::Motorola.Common.Communication.CommonUtil.RadioStorage.Any, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Flash | global::Motorola.Common.Communication.CommonUtil.RadioOperation.DepotFlash)]
	internal class FlashzapCommPipeCreator : global::Motorola.Common.Communication.CommunicationManager.ICommunicationPipeCreator
	{
		// Token: 0x0600013A RID: 314 RVA: 0x00007164 File Offset: 0x00005364
		public global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe Create(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			string deviceInstance = deviceInfo.ConnectionInfo.DeviceInstance;
			return this.newFudallyUSBCommPipe(deviceInstance);
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x0600013B RID: 315 RVA: 0x00007186 File Offset: 0x00005386
		public global::System.Type ExpectedType
		{
			get
			{
				return typeof(global::Motorola.Common.Communication.CommunicationPipe.FudallyUSBCommPipe);
			}
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00007192 File Offset: 0x00005392
		private global::Motorola.Common.Communication.CommunicationPipe.FudallyUSBCommPipe newFudallyUSBCommPipe(string pathName)
		{
			return new global::Motorola.Common.Communication.CommunicationPipe.FudallyUSBCommPipe(pathName);
		}
	}
}
