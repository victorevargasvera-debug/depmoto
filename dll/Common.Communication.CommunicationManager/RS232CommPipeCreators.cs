using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.TetraUtility;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x02000048 RID: 72
	[global::Motorola.Common.Communication.CommunicationManager.Initializer(global::Motorola.Common.Communication.CommonUtil.ConnectionType.RS232, global::Motorola.Common.Communication.CommonUtil.ProductFamily.TetraRadio, global::Motorola.Common.Communication.CommonUtil.RadioStorage.Any, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Any)]
	internal class RS232CommPipeCreators : global::Motorola.Common.Communication.CommunicationManager.ICommunicationPipeCreator
	{
		// Token: 0x0600019F RID: 415 RVA: 0x00007EB0 File Offset: 0x000060B0
		public global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe Create(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			global::Motorola.Common.Communication.CommonUtil.TetraDeviceInfo tetraDeviceInfo = deviceInfo as global::Motorola.Common.Communication.CommonUtil.TetraDeviceInfo;
			return this.newTetraCommPipe(tetraDeviceInfo.ConnectionInfo.Location, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.BAUDRATE_9600, tetraDeviceInfo.Location, false, tetraDeviceInfo.UsbHubInstance, tetraDeviceInfo.UsbHubPortNumber);
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060001A0 RID: 416 RVA: 0x00007EED File Offset: 0x000060ED
		public global::System.Type ExpectedType
		{
			get
			{
				return typeof(global::Motorola.Common.Communication.CommunicationPipe.TetraCommPipe);
			}
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00007EF9 File Offset: 0x000060F9
		private global::Motorola.Common.Communication.CommunicationPipe.TetraCommPipe newTetraCommPipe(string portName, int baudRate, string location4Log, bool isReliable, string usbHubInstance, uint usbHubPortNum)
		{
			return new global::Motorola.Common.Communication.CommunicationPipe.TetraCommPipe(portName, baudRate, location4Log, isReliable, usbHubInstance, usbHubPortNum);
		}
	}
}
