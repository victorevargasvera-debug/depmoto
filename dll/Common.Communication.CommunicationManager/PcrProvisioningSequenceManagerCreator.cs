using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.PCRRemoteProgramming;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x0200003D RID: 61
	[global::Motorola.Common.Communication.CommunicationManager.Initializer(global::Motorola.Common.Communication.CommonUtil.ConnectionType.Provisioning, global::Motorola.Common.Communication.CommonUtil.ProductFamily.PCRRadio, global::Motorola.Common.Communication.CommonUtil.RadioStorage.Any, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Any)]
	internal class PcrProvisioningSequenceManagerCreator : global::Motorola.Common.Communication.CommunicationManager.ISequenceManagerCreator
	{
		// Token: 0x06000178 RID: 376 RVA: 0x000078A4 File Offset: 0x00005AA4
		public global::Motorola.Common.Communication.ICpsSequenceManager Create(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe iCommPipe, global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter)
		{
			global::Motorola.Common.Communication.CommunicationPipe.HttpCommPipe httpCommPipe = iCommPipe as global::Motorola.Common.Communication.CommunicationPipe.HttpCommPipe;
			httpCommPipe.ForceBasicAuthenticationCredentials(global::Motorola.Common.Communication.PCRRemoteProgramming.PCRRPConstants.RetrieveASCIIString("Y3Bzcm0x"), global::Motorola.Common.Communication.PCRRemoteProgramming.PCRRPConstants.RetrieveASCIIString("NFBlUUFzcE11SlN0"));
			global::Motorola.Common.Communication.HttpMessageExecutor executor = global::Motorola.Common.Communication.CommunicationManager.newMessageExecutor.newHttpMessageExecutor(httpCommPipe);
			return new global::Motorola.Common.Communication.PcrProvisioningSequenceManager(executor);
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000179 RID: 377 RVA: 0x000078E1 File Offset: 0x00005AE1
		public global::System.Type ExpectedType
		{
			get
			{
				return typeof(global::Motorola.Common.Communication.PcrProvisioningSequenceManager);
			}
		}

		// Token: 0x0400004C RID: 76
		private const string username = "Y3Bzcm0x";

		// Token: 0x0400004D RID: 77
		private const string password = "NFBlUUFzcE11SlN0";
	}
}
