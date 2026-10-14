using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication
{
	// Token: 0x02000006 RID: 6
	public class Xnl : global::System.IDisposable
	{
		// Token: 0x06000023 RID: 35 RVA: 0x000026EA File Offset: 0x000008EA
		public Xnl()
		{
			this.nlCore = null;
			this.StateMutex = new object();
			this.connctionState = global::Motorola.Common.Communication.ConnectionState.NotConnected;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002718 File Offset: 0x00000918
		public virtual void Connect(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe communicationPipe)
		{
			lock (this.StateMutex)
			{
				global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(communicationPipe, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationXnlInvalidArgument);
				if (this.connctionState == global::Motorola.Common.Communication.ConnectionState.Connected)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationXnlAlreadyConnected);
				}
				this.nlCore = new global::Motorola.Common.Communication.NLCore();
				this.nlCore.Connect(communicationPipe);
				this.nlCore.StartAsyncReceiveDataPackets(this.BroadcastPollPeriod);
				this.connctionState = global::Motorola.Common.Communication.ConnectionState.Connected;
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000027A0 File Offset: 0x000009A0
		public virtual void Disconnect()
		{
			bool aborted = this.connctionState == global::Motorola.Common.Communication.ConnectionState.NotConnected;
			global::Motorola.Common.Communication.XnlTrace.WriteLine(global::System.DateTime.Now.ToLongTimeString() + ": Start Disconnecting...");
			if (this.nlCore != null)
			{
				this.nlCore.Disconnect(aborted);
				lock (this.StateMutex)
				{
					this.Dispose();
					this.connctionState = global::Motorola.Common.Communication.ConnectionState.NotConnected;
				}
			}
			global::Motorola.Common.Communication.XnlTrace.WriteLine(global::System.DateTime.Now.ToLongTimeString() + ": Disconnected!");
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002844 File Offset: 0x00000A44
		public virtual ushort SendDataMessage(byte[] buffer, int bufferLength)
		{
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(buffer, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationXnlInvalidArgument);
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsZero(bufferLength, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationXnlInvalidArgument);
			ushort result = 0;
			lock (this.StateMutex)
			{
				if (this.connctionState == global::Motorola.Common.Communication.ConnectionState.NotConnected)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationXnlNotConnected);
				}
				result = this.nlCore.SendDataMessage(buffer, bufferLength);
			}
			return result;
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000028BC File Offset: 0x00000ABC
		public virtual ushort SendBroadcastDataMessage(byte[] buffer, int bufferLength)
		{
			return 0;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000028C0 File Offset: 0x00000AC0
		public virtual byte[] ReceiveDataMessage(int timeout, ushort xnlTransactionID)
		{
			byte[] result;
			lock (this.StateMutex)
			{
				if (this.connctionState == global::Motorola.Common.Communication.ConnectionState.NotConnected)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationXnlNotConnected);
				}
				result = this.nlCore.ReceiveDataMessage(xnlTransactionID, timeout);
			}
			return result;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002920 File Offset: 0x00000B20
		public bool IsDualBoard()
		{
			bool isDualBoard;
			lock (this.StateMutex)
			{
				isDualBoard = this.nlCore.IsDualBoard;
			}
			return isDualBoard;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002968 File Offset: 0x00000B68
		public void SetTargetBoard(global::Motorola.Common.Communication.TargetBoard targetBoard)
		{
			lock (this.StateMutex)
			{
				this.nlCore.SetTarget(targetBoard);
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000029B0 File Offset: 0x00000BB0
		public static void SetTimer(int defaultTimeout, int additionAckTimeout)
		{
			global::Motorola.Common.Communication.NLConstants.DefaultTimeout = defaultTimeout;
			global::Motorola.Common.Communication.NLConstants.AdditionalAckTimeout = additionAckTimeout;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000029BE File Offset: 0x00000BBE
		public void SetBroadcastPollPeriod(int brdcastPollTimer)
		{
			this.BroadcastPollPeriod = brdcastPollTimer;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000029C7 File Offset: 0x00000BC7
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000029D6 File Offset: 0x00000BD6
		protected virtual void Dispose(bool disposing)
		{
			if (this.nlCore != null)
			{
				this.nlCore.Dispose();
			}
		}

		// Token: 0x0400000B RID: 11
		internal global::Motorola.Common.Communication.NLCore nlCore;

		// Token: 0x0400000C RID: 12
		protected global::Motorola.Common.Communication.ConnectionState connctionState;

		// Token: 0x0400000D RID: 13
		private int BroadcastPollPeriod = global::Motorola.Common.Communication.NLConstants.BroadcastPollPeriod;

		// Token: 0x0400000E RID: 14
		protected object StateMutex;
	}
}
