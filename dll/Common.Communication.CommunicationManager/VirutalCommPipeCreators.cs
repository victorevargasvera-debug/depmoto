using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.TetraUtility;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x02000047 RID: 71
	[global::Motorola.Common.Communication.CommunicationManager.Initializer(global::Motorola.Common.Communication.CommonUtil.ConnectionType.VCOM, global::Motorola.Common.Communication.CommonUtil.ProductFamily.TetraRadio, global::Motorola.Common.Communication.CommonUtil.RadioStorage.Any, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Any)]
	internal class VirutalCommPipeCreators : global::Motorola.Common.Communication.CommunicationManager.ICommunicationPipeCreator
	{
		// Token: 0x0600019B RID: 411 RVA: 0x00007E44 File Offset: 0x00006044
		public global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe Create(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			bool needCheckAckOnUSB = false;
			global::Motorola.Common.Communication.CommonUtil.TetraDeviceInfo tetraDeviceInfo = deviceInfo as global::Motorola.Common.Communication.CommonUtil.TetraDeviceInfo;
			if (global::Motorola.Common.Communication.TetraUtility.TetraUtil.NeedCheckUSBAck)
			{
				needCheckAckOnUSB = true;
			}
			return this.newTetraCommPipe(tetraDeviceInfo.ConnectionInfo.Location, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.BAUDRATE_9600, tetraDeviceInfo.Location, tetraDeviceInfo.UsbHubInstance, tetraDeviceInfo.UsbHubPortNumber, needCheckAckOnUSB);
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x0600019C RID: 412 RVA: 0x00007E8C File Offset: 0x0000608C
		public global::System.Type ExpectedType
		{
			get
			{
				return typeof(global::Motorola.Common.Communication.CommunicationPipe.TetraCommPipe);
			}
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00007E98 File Offset: 0x00006098
		private global::Motorola.Common.Communication.CommunicationPipe.TetraCommPipe newTetraCommPipe(string portName, int baudRate, string location4Log, string usbHubInstance, uint usbHubPortNum, bool needCheckAckOnUSB)
		{
			return new global::Motorola.Common.Communication.CommunicationPipe.TetraCommPipe(portName, baudRate, location4Log, usbHubInstance, usbHubPortNum, needCheckAckOnUSB);
		}
	}
}
