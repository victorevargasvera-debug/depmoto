using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x0200000C RID: 12
	internal interface ISequenceManagerCreator
	{
		// Token: 0x0600007A RID: 122
		global::Motorola.Common.Communication.ICpsSequenceManager Create(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe iCommPipe, global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter);

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600007B RID: 123
		global::System.Type ExpectedType { get; }
	}
}
