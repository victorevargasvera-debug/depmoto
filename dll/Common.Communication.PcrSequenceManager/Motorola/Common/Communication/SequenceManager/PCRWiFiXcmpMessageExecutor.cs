using System;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.SequenceManager
{
	// Token: 0x02000041 RID: 65
	public class PCRWiFiXcmpMessageExecutor : global::Motorola.Common.Communication.SequenceManager.PcrRcmpMessageExecutor
	{
		// Token: 0x060001FD RID: 509 RVA: 0x00011CE8 File Offset: 0x0000FEE8
		public PCRWiFiXcmpMessageExecutor(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe commPipe, int commTimeout) : base(commPipe, commTimeout)
		{
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00011CF8 File Offset: 0x0000FEF8
		protected override void preSendMessage(global::Motorola.Common.Communication.IMessage msg)
		{
			if (msg == null)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
			}
			if (this.CommTimeout > msg.ReadTimeout)
			{
				msg.ReadTimeout = this.CommTimeout;
			}
		}
	}
}
