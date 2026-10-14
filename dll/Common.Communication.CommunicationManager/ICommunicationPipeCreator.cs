using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x02000002 RID: 2
	internal interface ICommunicationPipeCreator
	{
		// Token: 0x06000001 RID: 1
		global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe Create(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo);

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000002 RID: 2
		global::System.Type ExpectedType { get; }
	}
}
