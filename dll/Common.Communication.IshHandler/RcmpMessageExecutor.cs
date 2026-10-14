using System;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.IshHandler
{
	// Token: 0x0200000F RID: 15
	public class RcmpMessageExecutor : global::Motorola.Common.Communication.MessageExecutorBase, global::System.IDisposable
	{
		// Token: 0x06000124 RID: 292 RVA: 0x000076D9 File Offset: 0x000058D9
		public RcmpMessageExecutor(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe commPipe)
		{
			base.CommPipe = commPipe;
		}

		// Token: 0x06000125 RID: 293 RVA: 0x000076E8 File Offset: 0x000058E8
		~RcmpMessageExecutor()
		{
			this.Dispose(false);
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00007718 File Offset: 0x00005918
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00007727 File Offset: 0x00005927
		protected virtual void Dispose(bool isDisposing)
		{
			if (!this.m_IsDisposed)
			{
				this.m_IsDisposed = true;
			}
		}

		// Token: 0x06000128 RID: 296 RVA: 0x0000773A File Offset: 0x0000593A
		protected override void validateSendBuffer(byte[] sendBuffer, int length)
		{
			if (length <= 0)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.BuildRcmpFail);
			}
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00007748 File Offset: 0x00005948
		protected override void preSendMessage(global::Motorola.Common.Communication.IMessage msg)
		{
			if (msg == null)
			{
				throw new global::System.ArgumentNullException("preSendASTRORcmpMessage");
			}
			if (msg.ReadTimeout == 0)
			{
				msg.ReadTimeout = 90000;
			}
		}

		// Token: 0x0400001A RID: 26
		private const int DefaultCommTimeout = 90000;

		// Token: 0x0400001B RID: 27
		private bool m_IsDisposed;
	}
}
