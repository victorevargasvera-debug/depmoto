using System;
using System.Net.Http;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication
{
	// Token: 0x02000004 RID: 4
	public class HttpMessageExecutor : global::Motorola.Common.Communication.MessageExecutorBase, global::System.IDisposable
	{
		// Token: 0x06000047 RID: 71 RVA: 0x000046DC File Offset: 0x000028DC
		public HttpMessageExecutor(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe commPipe)
		{
			base.CommPipe = commPipe;
		}

		// Token: 0x06000048 RID: 72 RVA: 0x000046EC File Offset: 0x000028EC
		~HttpMessageExecutor()
		{
			this.Dispose(false);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x0000471C File Offset: 0x0000291C
		public override void SendAndReceiveMessage(global::Motorola.Common.Communication.IMessage msg)
		{
			this.preSendMessage(msg);
			this.Execute(0, msg);
		}

		// Token: 0x0600004A RID: 74 RVA: 0x0000472D File Offset: 0x0000292D
		protected override void validateSendBuffer(byte[] sendBuffer, int length)
		{
			if (length < 0)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.BuildRcmpFail);
			}
		}

		// Token: 0x0600004B RID: 75 RVA: 0x0000473C File Offset: 0x0000293C
		protected override void Execute(int sendLength, global::Motorola.Common.Communication.IMessage msg)
		{
			global::Motorola.Common.Communication.CommunicationPipe.HttpCommPipe httpCommPipe = base.CommPipe as global::Motorola.Common.Communication.CommunicationPipe.HttpCommPipe;
			global::Motorola.Common.Communication.HttpMessageBase httpMessageBase = msg as global::Motorola.Common.Communication.HttpMessageBase;
			if (httpMessageBase == null)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeOpenFailure);
			}
			lock (base.sendBuffer.SyncRoot)
			{
				global::System.Net.Http.HttpRequestMessage requestMessage = httpMessageBase.RequestMessage;
				global::System.Net.Http.HttpResponseMessage response = httpCommPipe.RequestData(requestMessage, httpMessageBase.ReadTimeout);
				httpMessageBase.HandleResponse(response);
			}
		}

		// Token: 0x0600004C RID: 76 RVA: 0x000047BC File Offset: 0x000029BC
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x0600004D RID: 77 RVA: 0x000047CB File Offset: 0x000029CB
		protected virtual void Dispose(bool isDisposing)
		{
			if (!this.m_IsDisposed)
			{
				this.m_IsDisposed = true;
			}
		}

		// Token: 0x0600004E RID: 78 RVA: 0x000047DE File Offset: 0x000029DE
		protected override void preSendMessage(global::Motorola.Common.Communication.IMessage msg)
		{
			if (msg == null)
			{
				throw new global::System.ArgumentNullException("preSendhttpMessage");
			}
			if (msg.ReadTimeout == 0)
			{
				msg.ReadTimeout = 900000;
			}
		}

		// Token: 0x04000026 RID: 38
		private const int DefaultCommTimeout = 900000;

		// Token: 0x04000027 RID: 39
		private bool m_IsDisposed;
	}
}
