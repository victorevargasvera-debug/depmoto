using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x02000020 RID: 32
	[global::Motorola.Common.Communication.CommunicationManager.Initializer(global::Motorola.Common.Communication.CommonUtil.ConnectionType.WIFI, (global::Motorola.Common.Communication.CommonUtil.ProductFamily)32896, global::Motorola.Common.Communication.CommonUtil.RadioStorage.Any, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Any)]
	[global::Motorola.Common.Communication.CommunicationManager.Initializer(global::Motorola.Common.Communication.CommonUtil.ConnectionType.NetAdapter, (global::Motorola.Common.Communication.CommonUtil.ProductFamily)32896, global::Motorola.Common.Communication.CommonUtil.RadioStorage.Any, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Any)]
	internal class PBBHttpCommPipeCreator : global::Motorola.Common.Communication.CommunicationManager.ICommunicationPipeCreator
	{
		// Token: 0x060000FC RID: 252 RVA: 0x00005E2C File Offset: 0x0000402C
		public global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe Create(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			string uniqueAddress = deviceInfo.ConnectionInfo.UniqueAddress;
			string url = this.https_Prefix + uniqueAddress + ":8443/" + this.https_ReletiveUrl;
			return this.newHttpCommPipe(url);
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000FD RID: 253 RVA: 0x00005E64 File Offset: 0x00004064
		public global::System.Type ExpectedType
		{
			get
			{
				return typeof(global::Motorola.Common.Communication.CommunicationPipe.HttpCommPipe);
			}
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00005E70 File Offset: 0x00004070
		private global::Motorola.Common.Communication.CommunicationPipe.HttpCommPipe newHttpCommPipe(string url)
		{
			return new global::Motorola.Common.Communication.CommunicationPipe.HttpCommPipe(url);
		}

		// Token: 0x0400003A RID: 58
		private readonly string https_Prefix = "https://";

		// Token: 0x0400003B RID: 59
		private readonly string https_ReletiveUrl = "pbbrm/v2/";
	}
}
