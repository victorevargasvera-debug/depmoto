using System;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.SequenceManager
{
	// Token: 0x02000042 RID: 66
	public class PCRRPRcmpMessageExecutor : global::Motorola.Common.Communication.SequenceManager.PcrRcmpMessageExecutor
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x060001FF RID: 511 RVA: 0x00011D40 File Offset: 0x0000FF40
		// (remove) Token: 0x06000200 RID: 512 RVA: 0x00011D7C File Offset: 0x0000FF7C
		public event global::Motorola.Common.Communication.RnlBroadcastMessageEventHandler BroadcastDataMessageReceived;

		// Token: 0x06000201 RID: 513 RVA: 0x00011DB8 File Offset: 0x0000FFB8
		public PCRRPRcmpMessageExecutor(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe commPipe, int commTimeout) : base(commPipe, commTimeout)
		{
			base.sendBuffer = new byte[global::Motorola.Common.Communication.SequenceManager.PCRRPRcmpMessageExecutor.PCR_RP_SEND_BUFFER_SIZE];
		}

		// Token: 0x06000202 RID: 514 RVA: 0x00011DD8 File Offset: 0x0000FFD8
		internal void ListenOnBroadcastMessage()
		{
			global::Motorola.Common.Communication.CommunicationPipe.NLCommPipe nlcommPipe = base.CommPipe as global::Motorola.Common.Communication.CommunicationPipe.NLCommPipe;
			nlcommPipe.RegisterBroadcastMessageListener(new global::Motorola.Common.Communication.RnlBroadcastMessageEventHandler(this.ProcessBroadcastMessage));
		}

		// Token: 0x06000203 RID: 515 RVA: 0x00011E08 File Offset: 0x00010008
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

		// Token: 0x06000204 RID: 516 RVA: 0x00011E50 File Offset: 0x00010050
		private void ProcessBroadcastMessage(object sender, global::Motorola.Common.Communication.RnlBrdcstMsgEventArgs e)
		{
			if (this.BroadcastDataMessageReceived != null)
			{
				this.BroadcastDataMessageReceived(sender, e);
			}
		}

		// Token: 0x04000163 RID: 355
		private static readonly int PCR_RP_SEND_BUFFER_SIZE = 52428800;
	}
}
