using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication
{
	// Token: 0x02000015 RID: 21
	public abstract class MessageExecutorBase : global::Motorola.Common.Communication.IMessageExecutor
	{
		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000EA RID: 234 RVA: 0x000023A3 File Offset: 0x000005A3
		// (set) Token: 0x060000EB RID: 235 RVA: 0x000023AB File Offset: 0x000005AB
		protected byte[] sendBuffer
		{
			get
			{
				return this._sendBuffer;
			}
			set
			{
				this._sendBuffer = value;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000EC RID: 236 RVA: 0x000023B4 File Offset: 0x000005B4
		// (set) Token: 0x060000ED RID: 237 RVA: 0x000023BC File Offset: 0x000005BC
		protected byte[] receiveBuffer
		{
			get
			{
				return this._receiveBuffer;
			}
			set
			{
				this._receiveBuffer = value;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000EE RID: 238 RVA: 0x000023C5 File Offset: 0x000005C5
		// (set) Token: 0x060000EF RID: 239 RVA: 0x000023CD File Offset: 0x000005CD
		public global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe CommPipe
		{
			get
			{
				return this._commPipe;
			}
			set
			{
				this._commPipe = value;
			}
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x000023D6 File Offset: 0x000005D6
		protected virtual void preSendMessage(global::Motorola.Common.Communication.IMessage msg)
		{
			if (msg == null)
			{
				throw new global::System.ArgumentNullException("preSendMessage");
			}
		}

		// Token: 0x060000F1 RID: 241
		protected abstract void validateSendBuffer(byte[] sendBuffer, int length);

		// Token: 0x060000F2 RID: 242 RVA: 0x000023E8 File Offset: 0x000005E8
		public virtual void SendAndReceiveMessage(global::Motorola.Common.Communication.IMessage msg)
		{
			this.preSendMessage(msg);
			int num = msg.BuildCommandMessage(this.sendBuffer);
			this.validateSendBuffer(this.sendBuffer, num);
			this.Execute(num, msg);
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00002420 File Offset: 0x00000620
		protected virtual void Execute(int sendLength, global::Motorola.Common.Communication.IMessage msg)
		{
			if (msg.hasReply)
			{
				lock (this.sendBuffer.SyncRoot)
				{
					this.receiveBuffer = this._commPipe.RequestData(this.sendBuffer, 0, sendLength, msg.ReadTimeout);
					if (this.receiveBuffer != null)
					{
						msg.DecodeReplyMessage(this.receiveBuffer, 0, this.receiveBuffer.Length);
						return;
					}
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Rx: Len={0} or failed", new object[]
					{
						0
					});
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeReadFailure);
				}
			}
			lock (this.sendBuffer.SyncRoot)
			{
				this._commPipe.SendData(this.sendBuffer, 0, sendLength);
			}
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00002518 File Offset: 0x00000718
		public virtual void Setup()
		{
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x0000251A File Offset: 0x0000071A
		public virtual void TearDown()
		{
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x0000251C File Offset: 0x0000071C
		public void SetRxTimeoutTimer(int timeout)
		{
			this._commPipe.ReceiveTimeout = timeout;
		}

		// Token: 0x04000014 RID: 20
		private global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe _commPipe;

		// Token: 0x04000015 RID: 21
		private byte[] _sendBuffer = new byte[65535];

		// Token: 0x04000016 RID: 22
		private byte[] _receiveBuffer;
	}
}
