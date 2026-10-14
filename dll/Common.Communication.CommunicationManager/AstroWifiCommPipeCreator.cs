using System;
using System.Globalization;
using System.Net;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x02000005 RID: 5
	[global::Motorola.Common.Communication.CommunicationManager.Initializer(global::Motorola.Common.Communication.CommonUtil.ConnectionType.WIFI, global::Motorola.Common.Communication.CommonUtil.ProductFamily.AstroRadio, global::Motorola.Common.Communication.CommonUtil.RadioStorage.Any, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Any)]
	internal class AstroWifiCommPipeCreator : global::Motorola.Common.Communication.CommunicationManager.ICommunicationPipeCreator
	{
		// Token: 0x06000009 RID: 9 RVA: 0x00002180 File Offset: 0x00000380
		public global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe Create(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			global::System.Net.IPAddress ipaddress = global::Motorola.Common.Communication.CommunicationManager.Utilities.GetIPAddress(deviceInfo);
			int portNumber = global::Motorola.Common.Communication.CommunicationManager.Constants.AstroRadioWifiPort;
			if (deviceInfo.ConnectionInfo != null && !string.IsNullOrEmpty(deviceInfo.ConnectionInfo.Location))
			{
				try
				{
					portNumber = global::System.Convert.ToInt32(deviceInfo.ConnectionInfo.Location, global::System.Globalization.CultureInfo.InvariantCulture);
				}
				catch
				{
				}
			}
			return global::Motorola.Common.Communication.CommunicationManager.newTcpClientCommPipe.newTCCommPipe(ipaddress, portNumber, false);
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000A RID: 10 RVA: 0x000021E8 File Offset: 0x000003E8
		public global::System.Type ExpectedType
		{
			get
			{
				return typeof(global::Motorola.Common.Communication.CommunicationPipe.TcpClientCommPipe);
			}
		}
	}
}
