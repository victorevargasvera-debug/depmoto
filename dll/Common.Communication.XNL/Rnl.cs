using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication
{
	// Token: 0x02000007 RID: 7
	public class Rnl : global::Motorola.Common.Communication.Xnl
	{
		// Token: 0x06000030 RID: 48 RVA: 0x000029F4 File Offset: 0x00000BF4
		public override void Connect(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe communicationPipe)
		{
			lock (this.StateMutex)
			{
				global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(communicationPipe, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationXnlInvalidArgument);
				if (this.connctionState == global::Motorola.Common.Communication.ConnectionState.Connected)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationXnlAlreadyConnected);
				}
				this.nlCore = new global::Motorola.Common.Communication.RNLCore();
				this.nlCore.Connect(communicationPipe);
				this.nlCore.StartAsyncReceiveDataPackets(global::Motorola.Common.Communication.NLConstants.BroadcastPollPeriod);
				this.connctionState = global::Motorola.Common.Communication.ConnectionState.Connected;
			}
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002A7C File Offset: 0x00000C7C
		public override void Disconnect()
		{
			bool aborted = this.connctionState == global::Motorola.Common.Communication.ConnectionState.NotConnected;
			global::Motorola.Common.Communication.XnlTrace.WriteLine(global::System.DateTime.Now.ToLongTimeString() + ": Start Disconnecting...");
			this.nlCore.Disconnect(aborted);
			lock (this.StateMutex)
			{
				this.nlCore.Dispose();
				this.nlCore = null;
				this.connctionState = global::Motorola.Common.Communication.ConnectionState.NotConnected;
			}
			global::Motorola.Common.Communication.XnlTrace.WriteLine(global::System.DateTime.Now.ToLongTimeString() + ": Disconnected!");
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002B24 File Offset: 0x00000D24
		public override ushort SendDataMessage(byte[] buffer, int bufferLength)
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

		// Token: 0x06000033 RID: 51 RVA: 0x00002B9C File Offset: 0x00000D9C
		public override ushort SendBroadcastDataMessage(byte[] buffer, int bufferLength)
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
				result = this.nlCore.SendBroadcastDataMessage(buffer, bufferLength);
			}
			return result;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002C14 File Offset: 0x00000E14
		public override byte[] ReceiveDataMessage(int timeout, ushort rnlTransactionID)
		{
			byte[] result;
			lock (this.StateMutex)
			{
				if (this.connctionState == global::Motorola.Common.Communication.ConnectionState.NotConnected)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationXnlNotConnected);
				}
				result = this.nlCore.ReceiveDataMessage(rnlTransactionID, timeout);
			}
			return result;
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002C74 File Offset: 0x00000E74
		public void RegisterBroadcastMessageListener(global::Motorola.Common.Communication.RnlBroadcastMessageEventHandler broadcastDataMessageReceived)
		{
			this.BroadcastDataMessageReceived = broadcastDataMessageReceived;
			(this.nlCore as global::Motorola.Common.Communication.RNLCore).RegisterBroadcastMessageListener(this.BroadcastDataMessageReceived);
		}

		// Token: 0x0400000F RID: 15
		private global::Motorola.Common.Communication.RnlBroadcastMessageEventHandler BroadcastDataMessageReceived;
	}
}
