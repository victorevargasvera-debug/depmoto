using System;
using System.Net;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x02000026 RID: 38
	[global::Motorola.Common.Communication.CommunicationManager.Initializer(global::Motorola.Common.Communication.CommonUtil.ConnectionType.WIFI, global::Motorola.Common.Communication.CommonUtil.ProductFamily.ParadiseRadio, global::Motorola.Common.Communication.CommonUtil.RadioStorage.Any, global::Motorola.Common.Communication.CommonUtil.RadioOperation.ChargingFeature)]
	[global::Motorola.Common.Communication.CommunicationManager.Initializer(global::Motorola.Common.Communication.CommonUtil.ConnectionType.NetAdapter, (global::Motorola.Common.Communication.CommonUtil.ProductFamily)122, global::Motorola.Common.Communication.CommonUtil.RadioStorage.Any, global::Motorola.Common.Communication.CommonUtil.RadioOperation.ChargingFeature)]
	internal class UdpCommPipeCreator : global::Motorola.Common.Communication.CommunicationManager.ICommunicationPipeCreator
	{
		// Token: 0x06000129 RID: 297 RVA: 0x00006E54 File Offset: 0x00005054
		public global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe Create(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			global::System.Net.IPAddress ipaddress = global::Motorola.Common.Communication.CommunicationManager.Utilities.GetIPAddress(deviceInfo);
			int fxPPort = global::Motorola.Common.Communication.CommunicationManager.Utilities.GetFxPPort(deviceInfo);
			return this.newUdpCommPipe(fxPPort, global::Motorola.Common.Communication.CommunicationManager.Constants.RadioFxpPort, ipaddress);
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600012A RID: 298 RVA: 0x00006E7C File Offset: 0x0000507C
		public global::System.Type ExpectedType
		{
			get
			{
				return typeof(global::Motorola.Common.Communication.CommunicationPipe.UdpCommPipe);
			}
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00006E88 File Offset: 0x00005088
		private global::Motorola.Common.Communication.CommunicationPipe.UdpCommPipe newUdpCommPipe(int localPortNumber, int remotePortNumber, global::System.Net.IPAddress remoteIPAddress)
		{
			return new global::Motorola.Common.Communication.CommunicationPipe.UdpCommPipe(localPortNumber, remotePortNumber, remoteIPAddress);
		}
	}
}
