using System;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.IshHandler;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x02000016 RID: 22
	internal class newRcmpMessageExecutor
	{
		// Token: 0x06000097 RID: 151 RVA: 0x00003CFD File Offset: 0x00001EFD
		public static global::Motorola.Common.Communication.IshHandler.RcmpMessageExecutor newRMessageExecutor(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe commPipe)
		{
			return new global::Motorola.Common.Communication.IshHandler.RcmpMessageExecutor(commPipe);
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00003D05 File Offset: 0x00001F05
		public static global::Motorola.Common.Communication.AstroOtapRcmpMessageExecutor newAstroOtapRMessageExecutor(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe commPipe, int inactivityTimeout)
		{
			return new global::Motorola.Common.Communication.AstroOtapRcmpMessageExecutor(commPipe, inactivityTimeout);
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00003D0E File Offset: 0x00001F0E
		public static global::Motorola.Common.Communication.AstroWiFiRcmpMessageExecutor newAstroWiFiRMessageExecutor(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe commPipe, int inactivityTimeout)
		{
			return new global::Motorola.Common.Communication.AstroWiFiRcmpMessageExecutor(commPipe, inactivityTimeout);
		}
	}
}
