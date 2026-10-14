using System;
using System.Globalization;
using System.IO;
using System.Net;
using System.Reflection;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.PCRRemoteProgramming;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x02000029 RID: 41
	[global::Motorola.Common.Communication.CommunicationManager.Initializer(global::Motorola.Common.Communication.CommonUtil.ConnectionType.LENetwork | global::Motorola.Common.Communication.CommonUtil.ConnectionType.DMR3Network, global::Motorola.Common.Communication.CommonUtil.ProductFamily.PCRRadio, global::Motorola.Common.Communication.CommonUtil.RadioStorage.Any, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Any)]
	internal class RPCommPipeCreator : global::Motorola.Common.Communication.CommunicationManager.ICommunicationPipeCreator
	{
		// Token: 0x06000136 RID: 310 RVA: 0x00007078 File Offset: 0x00005278
		public global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe Create(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			global::System.Net.IPAddress ipaddress = global::Motorola.Common.Communication.CommunicationManager.Utilities.GetIPAddress(deviceInfo);
			int num = global::Motorola.Common.Communication.PCRRemoteProgramming.TCPPortManager.Instance.GetAvailable();
			if (num == 0)
			{
				num = global::System.Convert.ToInt32(deviceInfo.ConnectionInfo.Location, global::System.Globalization.CultureInfo.InvariantCulture);
			}
			else if (num == -1)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerLocalPortConflict);
			}
			global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transport = this.newTcpListenerCommPipe(global::System.Net.IPAddress.Any, num, (int)global::Motorola.Common.Communication.PCRRemoteProgramming.PCRRPConstants.ACCEPT_RP_TIMEOUT);
			global::Motorola.Common.Communication.CommonUtil.AuthenticationInfo authenticationInfo = new global::Motorola.Common.Communication.CommonUtil.AuthenticationInfo();
			authenticationInfo.AuthType = global::Motorola.Common.Communication.CommonUtil.AuthenticationType.Certificate;
			string directoryName = global::System.IO.Path.GetDirectoryName(global::System.Reflection.Assembly.GetExecutingAssembly().Location);
			authenticationInfo.Certificate_File = global::System.IO.Path.Combine(directoryName, "Metadata", "PCR", global::Motorola.Common.Communication.PCRRemoteProgramming.PCRRPConstants.RetrieveASCIIString(global::Motorola.Common.Communication.PCRRemoteProgramming.PCRRPConstants.SSLCERT));
			authenticationInfo.PreSharedKey_Material = global::Motorola.Common.Communication.PCRRemoteProgramming.PCRRPConstants.RetrieveASCIIString(global::Motorola.Common.Communication.PCRRemoteProgramming.PCRRPConstants.SSLPSWD);
			return new global::Motorola.Common.Communication.CommunicationPipe.P2PCommPipe(transport, authenticationInfo, ipaddress, global::System.Convert.ToInt32(deviceInfo.RadioID, global::System.Globalization.CultureInfo.InvariantCulture), global::Motorola.Common.Communication.PCRRemoteProgramming.PCRRPConstants.RPReceiveTimeout, false);
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000137 RID: 311 RVA: 0x00007144 File Offset: 0x00005344
		public global::System.Type ExpectedType
		{
			get
			{
				return typeof(global::Motorola.Common.Communication.CommunicationPipe.P2PCommPipe);
			}
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00007150 File Offset: 0x00005350
		private global::Motorola.Common.Communication.CommunicationPipe.TcpListenerCommPipe newTcpListenerCommPipe(global::System.Net.IPAddress ipAddress, int portNumber, int receiveTimeout)
		{
			return new global::Motorola.Common.Communication.CommunicationPipe.TcpListenerCommPipe(ipAddress, portNumber, receiveTimeout);
		}
	}
}
