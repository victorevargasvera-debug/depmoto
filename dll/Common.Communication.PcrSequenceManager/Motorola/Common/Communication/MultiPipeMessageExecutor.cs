using System;
using System.Collections.Generic;
using System.Linq;
using Motorola.Common.Communication.CommunicationPipe;

namespace Motorola.Common.Communication
{
	// Token: 0x0200000E RID: 14
	public class MultiPipeMessageExecutor : global::Motorola.Common.Communication.MessageExecutorBase, global::System.IDisposable
	{
		// Token: 0x06000042 RID: 66 RVA: 0x00003E20 File Offset: 0x00002020
		public MultiPipeMessageExecutor(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe commPipe)
		{
			base.CommPipe = commPipe;
			global::Motorola.Common.Communication.CommunicationPipe.MultiPipeCommPipe multiPipeCommPipe = base.CommPipe as global::Motorola.Common.Communication.CommunicationPipe.MultiPipeCommPipe;
			if (multiPipeCommPipe == null)
			{
				throw new global::System.ArgumentException("MultiPipeMessageExecutor requires MultiPipeCommPipe as a communication pipe.");
			}
			this.messageExecutorMap = new global::System.Collections.Generic.Dictionary<int, global::Motorola.Common.Communication.IMessageExecutor>();
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00003E6C File Offset: 0x0000206C
		~MultiPipeMessageExecutor()
		{
			this.Dispose(false);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00003EA0 File Offset: 0x000020A0
		public void AddExecutor(int id, global::Motorola.Common.Communication.IMessageExecutor executor)
		{
			if (executor == null)
			{
				if (this.messageExecutorMap.ContainsKey(id))
				{
					this.messageExecutorMap.Remove(id);
				}
			}
			else
			{
				this.messageExecutorMap.Add(id, executor);
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00003EF0 File Offset: 0x000020F0
		public global::Motorola.Common.Communication.IMessageExecutor GetExecutor(int id)
		{
			global::Motorola.Common.Communication.IMessageExecutor result = null;
			if (this.messageExecutorMap.ContainsKey(id))
			{
				result = this.messageExecutorMap[id];
			}
			return result;
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00003F28 File Offset: 0x00002128
		public global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<int, global::Motorola.Common.Communication.IMessageExecutor>> GetAllExecutors()
		{
			return this.messageExecutorMap.ToList<global::System.Collections.Generic.KeyValuePair<int, global::Motorola.Common.Communication.IMessageExecutor>>();
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00003F45 File Offset: 0x00002145
		public override void SendAndReceiveMessage(global::Motorola.Common.Communication.IMessage msg)
		{
			this.preSendMessage(msg);
			this.Execute(0, msg);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00003F59 File Offset: 0x00002159
		protected override void validateSendBuffer(byte[] sendBuffer, int length)
		{
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00003F5C File Offset: 0x0000215C
		protected override void Execute(int sendLength, global::Motorola.Common.Communication.IMessage msg)
		{
			global::Motorola.Common.Communication.MultiPipeMessageWrapper multiPipeMessageWrapper = msg as global::Motorola.Common.Communication.MultiPipeMessageWrapper;
			int executorID = multiPipeMessageWrapper.ExecutorID;
			global::Motorola.Common.Communication.IMessage message = multiPipeMessageWrapper.Message;
			global::Motorola.Common.Communication.IMessageExecutor messageExecutor = this.messageExecutorMap[executorID];
			messageExecutor.SendAndReceiveMessage(message);
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00003F94 File Offset: 0x00002194
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00003FA8 File Offset: 0x000021A8
		protected virtual void Dispose(bool isDisposing)
		{
			if (!this.m_IsDisposed)
			{
				if (isDisposing)
				{
				}
				this.m_IsDisposed = true;
			}
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00003FD4 File Offset: 0x000021D4
		protected override void preSendMessage(global::Motorola.Common.Communication.IMessage msg)
		{
			if (msg == null)
			{
				throw new global::System.ArgumentNullException("preSendMessage");
			}
		}

		// Token: 0x0400005A RID: 90
		private global::System.Collections.Generic.Dictionary<int, global::Motorola.Common.Communication.IMessageExecutor> messageExecutorMap;

		// Token: 0x0400005B RID: 91
		private bool m_IsDisposed;
	}
}
