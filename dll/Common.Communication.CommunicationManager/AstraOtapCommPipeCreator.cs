using System;
using System.Globalization;
using System.Net;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x02000004 RID: 4
	[global::Motorola.Common.Communication.CommunicationManager.Initializer(global::Motorola.Common.Communication.CommonUtil.ConnectionType.Otap, global::Motorola.Common.Communication.CommonUtil.ProductFamily.AstroRadio, global::Motorola.Common.Communication.CommonUtil.RadioStorage.Any, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Any)]
	internal class AstraOtapCommPipeCreator : global::Motorola.Common.Communication.CommunicationManager.ICommunicationPipeCreator
	{
		// Token: 0x06000006 RID: 6 RVA: 0x00002104 File Offset: 0x00000304
		[global::Motorola.Common.Communication.CommunicationManager.Initializer(global::Motorola.Common.Communication.CommonUtil.ConnectionType.Otap, global::Motorola.Common.Communication.CommonUtil.ProductFamily.AstroRadio, global::Motorola.Common.Communication.CommonUtil.RadioStorage.Any, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Any)]
		public global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe Create(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			global::System.Net.IPAddress ipaddress = global::Motorola.Common.Communication.CommunicationManager.Utilities.GetIPAddress(deviceInfo);
			int portNumber = global::Motorola.Common.Communication.CommunicationManager.Constants.AstroRadioOtapPort;
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

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000007 RID: 7 RVA: 0x0000216C File Offset: 0x0000036C
		public global::System.Type ExpectedType
		{
			get
			{
				return typeof(global::Motorola.Common.Communication.CommunicationPipe.TcpClientCommPipe);
			}
		}
	}
}
