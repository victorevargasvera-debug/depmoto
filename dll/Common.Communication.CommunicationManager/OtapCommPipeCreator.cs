using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Reflection;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x0200002B RID: 43
	[global::Motorola.Common.Communication.CommunicationManager.Initializer(global::Motorola.Common.Communication.CommonUtil.ConnectionType.Otap, (global::Motorola.Common.Communication.CommonUtil.ProductFamily)24, global::Motorola.Common.Communication.CommonUtil.RadioStorage.Any, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Create | global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read | global::Motorola.Common.Communication.CommonUtil.RadioOperation.Program)]
	internal class OtapCommPipeCreator : global::Motorola.Common.Communication.CommunicationManager.ICommunicationPipeCreator
	{
		// Token: 0x0600013E RID: 318 RVA: 0x000071A4 File Offset: 0x000053A4
		public global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe Create(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.AuthenticationInfo> authInfoList = null;
			if (deviceInfo.ConnectionInfo != null && deviceInfo.ConnectionInfo.AuthInfoList != null)
			{
				authInfoList = deviceInfo.ConnectionInfo.AuthInfoList;
			}
			global::System.Net.IPAddress ipaddress = global::Motorola.Common.Communication.CommunicationManager.Utilities.GetIPAddress(deviceInfo);
			string directoryName = global::System.IO.Path.GetDirectoryName(global::System.Reflection.Assembly.GetExecutingAssembly().Location);
			string configFilePath = global::System.IO.Path.Combine(directoryName, "Metadata", "RUDP", "RUDPConfigParameters.xml");
			global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transport = this.newRUDPCommPipe(ipaddress, global::Motorola.Common.Communication.CommunicationManager.Constants.RadioOtapPort, configFilePath, 5000);
			return new global::Motorola.Common.Communication.CommunicationPipe.SecureCommPipe(transport, authInfoList);
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x0600013F RID: 319 RVA: 0x0000721D File Offset: 0x0000541D
		public global::System.Type ExpectedType
		{
			get
			{
				return typeof(global::Motorola.Common.Communication.CommunicationPipe.SecureCommPipe);
			}
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00007229 File Offset: 0x00005429
		private global::Motorola.Common.Communication.CommunicationPipe.RUDPCommPipe newRUDPCommPipe(global::System.Net.IPAddress ipAddress, int portNumber, string configFilePath, int receiveTimeout = 5000)
		{
			return new global::Motorola.Common.Communication.CommunicationPipe.RUDPCommPipe(ipAddress, portNumber, configFilePath, receiveTimeout);
		}
	}
}
