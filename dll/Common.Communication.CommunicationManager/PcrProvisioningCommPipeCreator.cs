using System;
using System.Net;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x0200002C RID: 44
	[global::Motorola.Common.Communication.CommunicationManager.Initializer(global::Motorola.Common.Communication.CommonUtil.ConnectionType.Provisioning, global::Motorola.Common.Communication.CommonUtil.ProductFamily.PCRRadio, global::Motorola.Common.Communication.CommonUtil.RadioStorage.Any, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Any)]
	internal class PcrProvisioningCommPipeCreator : global::Motorola.Common.Communication.CommunicationManager.ICommunicationPipeCreator
	{
		// Token: 0x06000142 RID: 322 RVA: 0x00007240 File Offset: 0x00005440
		public global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe Create(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			global::System.Net.IPAddress ip = global::System.Net.IPAddress.Parse(deviceInfo.ConnectionInfo.UniqueAddress);
			string url = this.GenerateUrl(ip);
			return this.newHttpCommPipe(url);
		}

		// Token: 0x06000143 RID: 323 RVA: 0x0000726D File Offset: 0x0000546D
		private string GenerateUrl(global::System.Net.IPAddress ip)
		{
			return string.Format("https://{0}:{1}", ip, 35000);
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000144 RID: 324 RVA: 0x00007284 File Offset: 0x00005484
		public global::System.Type ExpectedType
		{
			get
			{
				return typeof(global::Motorola.Common.Communication.CommunicationPipe.HttpCommPipe);
			}
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00007290 File Offset: 0x00005490
		private global::Motorola.Common.Communication.CommunicationPipe.HttpCommPipe newHttpCommPipe(string url)
		{
			return new global::Motorola.Common.Communication.CommunicationPipe.HttpCommPipe(url);
		}
	}
}
