using System;
using System.IO;
using System.Net;
using System.Reflection;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.PCRRemoteProgramming;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x02000027 RID: 39
	[global::Motorola.Common.Communication.CommunicationManager.Initializer(global::Motorola.Common.Communication.CommonUtil.ConnectionType.NetAdapter, global::Motorola.Common.Communication.CommonUtil.ProductFamily.PCRRadio, global::Motorola.Common.Communication.CommonUtil.RadioStorage.Any, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Create | global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read | global::Motorola.Common.Communication.CommonUtil.RadioOperation.Program)]
	[global::Motorola.Common.Communication.CommunicationManager.Initializer(global::Motorola.Common.Communication.CommonUtil.ConnectionType.Bluetooth, (global::Motorola.Common.Communication.CommonUtil.ProductFamily)24, global::Motorola.Common.Communication.CommonUtil.RadioStorage.Any, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Create | global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read | global::Motorola.Common.Communication.CommonUtil.RadioOperation.Program)]
	[global::Motorola.Common.Communication.CommunicationManager.Initializer(global::Motorola.Common.Communication.CommonUtil.ConnectionType.WIFI, global::Motorola.Common.Communication.CommonUtil.ProductFamily.ParadiseRadio, global::Motorola.Common.Communication.CommonUtil.RadioStorage.Any, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Create | global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read | global::Motorola.Common.Communication.CommonUtil.RadioOperation.Program | global::Motorola.Common.Communication.CommonUtil.RadioOperation.Flash)]
	[global::Motorola.Common.Communication.CommunicationManager.Initializer(global::Motorola.Common.Communication.CommonUtil.ConnectionType.NetAdapter, (global::Motorola.Common.Communication.CommonUtil.ProductFamily)56, global::Motorola.Common.Communication.CommonUtil.RadioStorage.Any, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Flash | global::Motorola.Common.Communication.CommonUtil.RadioOperation.DepotFlash)]
	internal class XnlCommPipeCreator : global::Motorola.Common.Communication.CommunicationManager.ICommunicationPipeCreator
	{
		// Token: 0x0600012D RID: 301 RVA: 0x00006E9C File Offset: 0x0000509C
		public global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe Create(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			global::System.Net.IPAddress ipaddress = global::Motorola.Common.Communication.CommunicationManager.Utilities.GetIPAddress(deviceInfo);
			global::System.Net.IPAddress objA = global::System.Net.IPAddress.Parse("0.0.0.0");
			global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe commPipe;
			if (2 == deviceInfo.SecurityCapability)
			{
				global::Motorola.Common.Communication.CommonUtil.AuthenticationInfo authenticationInfo = new global::Motorola.Common.Communication.CommonUtil.AuthenticationInfo();
				string directoryName = global::System.IO.Path.GetDirectoryName(global::System.Reflection.Assembly.GetExecutingAssembly().Location);
				authenticationInfo.AuthType = global::Motorola.Common.Communication.CommonUtil.AuthenticationType.Certificate;
				authenticationInfo.StreType = global::Motorola.Common.Communication.CommonUtil.StreamType.TcpStream;
				authenticationInfo.Certificate_File = global::System.IO.Path.Combine(directoryName, "Metadata", "PCR", global::Motorola.Common.Communication.PCRRemoteProgramming.PCRRPConstants.RetrieveASCIIString(global::Motorola.Common.Communication.PCRRemoteProgramming.PCRRPConstants.SSLCERT_FILE));
				authenticationInfo.Public_Key = global::System.IO.Path.Combine(directoryName, "Metadata", "PCR", global::Motorola.Common.Communication.PCRRemoteProgramming.PCRRPConstants.RetrieveASCIIString(global::Motorola.Common.Communication.PCRRemoteProgramming.PCRRPConstants.SSLKEY_FILE));
				authenticationInfo.PreSharedKey_Material = global::Motorola.Common.Communication.PCRRemoteProgramming.PCRRPConstants.RetrieveASCIIString(global::Motorola.Common.Communication.PCRRemoteProgramming.PCRRPConstants.SSLKEY_PSWD);
				global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transport;
				if (deviceInfo.ConnectionInfo != null && deviceInfo.ConnectionInfo.ConnectionType == global::Motorola.Common.Communication.CommonUtil.ConnectionType.WIFI)
				{
					transport = this.newTcpClientCommPipe(ipaddress, global::Motorola.Common.Communication.CommunicationManager.Constants.PcrRadioWifiPort, true);
				}
				else if (object.Equals(objA, deviceInfo.secureConnectionInfo.RadioIP))
				{
					transport = this.newTcpClientCommPipe(ipaddress, (int)deviceInfo.secureConnectionInfo.RadioPort, true);
				}
				else
				{
					transport = this.newTcpClientCommPipe(deviceInfo.secureConnectionInfo.RadioIP, (int)deviceInfo.secureConnectionInfo.RadioPort, true);
				}
				global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe communicationPipe = new global::Motorola.Common.Communication.CommunicationPipe.SecureUpgradeCommPipe(transport, authenticationInfo, (int)deviceInfo.SecurityCapability);
				commPipe = communicationPipe;
			}
			else
			{
				global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe communicationPipe2 = this.newTcpClientCommPipe(ipaddress, global::Motorola.Common.Communication.CommunicationManager.Utilities.GetPort(deviceInfo), true);
				commPipe = communicationPipe2;
			}
			global::Motorola.Common.Communication.CommunicationPipe.NLCommPipe nlcommPipe = this.newNLCommPipe(commPipe, global::Motorola.Common.Communication.CommunicationPipe.Constants.NLOptions.XNL_TRANSPORT);
			if (deviceInfo.ConnectionInfo != null && deviceInfo.ConnectionInfo.ConnectionType == global::Motorola.Common.Communication.CommonUtil.ConnectionType.WIFI)
			{
				nlcommPipe.SetBroadcastPollPeriod(1000);
			}
			return nlcommPipe;
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600012E RID: 302 RVA: 0x00007009 File Offset: 0x00005209
		public global::System.Type ExpectedType
		{
			get
			{
				return typeof(global::Motorola.Common.Communication.CommunicationPipe.NLCommPipe);
			}
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00007015 File Offset: 0x00005215
		private global::Motorola.Common.Communication.CommunicationPipe.TcpClientCommPipe newTcpClientCommPipe(global::System.Net.IPAddress ipAddress, int portNumber, bool noDelay)
		{
			return new global::Motorola.Common.Communication.CommunicationPipe.TcpClientCommPipe(ipAddress, portNumber, noDelay);
		}

		// Token: 0x06000130 RID: 304 RVA: 0x0000701F File Offset: 0x0000521F
		private global::Motorola.Common.Communication.CommunicationPipe.NLCommPipe newNLCommPipe(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe commPipe, global::Motorola.Common.Communication.CommunicationPipe.Constants.NLOptions Options)
		{
			return new global::Motorola.Common.Communication.CommunicationPipe.NLCommPipe(commPipe, Options, 100, 100, 400, 50);
		}
	}
}
