using System;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.IshHandler;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.SequenceManager
{
	// Token: 0x02000040 RID: 64
	public class PcrRcmpMessageExecutor : global::Motorola.Common.Communication.IshHandler.RcmpMessageExecutor
	{
		// Token: 0x060001F9 RID: 505 RVA: 0x00011C38 File Offset: 0x0000FE38
		public PcrRcmpMessageExecutor(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe commPipe, int commTimeout) : base(commPipe)
		{
			this.CommTimeout = commTimeout;
			this.SpecialTimeout = false;
		}

		// Token: 0x060001FA RID: 506 RVA: 0x00011C54 File Offset: 0x0000FE54
		protected override void preSendMessage(global::Motorola.Common.Communication.IMessage msg)
		{
			if (msg == null)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
			}
			if (this.SpecialTimeout)
			{
				msg.ReadTimeout = this.CommTimeout;
			}
			else if (msg.ReadTimeout < this.CommTimeout)
			{
				msg.ReadTimeout = this.CommTimeout;
			}
		}

		// Token: 0x060001FB RID: 507 RVA: 0x00011CB8 File Offset: 0x0000FEB8
		protected override void validateSendBuffer(byte[] sendBuffer, int length)
		{
			if (length <= 0)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.BuildRcmpFail);
			}
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00011CD7 File Offset: 0x0000FED7
		internal void SetMessageTimeout(int newTimeout)
		{
			this.CommTimeout = newTimeout;
			this.SpecialTimeout = true;
		}

		// Token: 0x04000161 RID: 353
		private bool SpecialTimeout;

		// Token: 0x04000162 RID: 354
		protected int CommTimeout;
	}
}
