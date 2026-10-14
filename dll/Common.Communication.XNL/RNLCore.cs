using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication
{
	// Token: 0x02000017 RID: 23
	internal class RNLCore : global::Motorola.Common.Communication.NLCore
	{
		// Token: 0x0600005F RID: 95 RVA: 0x000038FE File Offset: 0x00001AFE
		public RNLCore()
		{
			this.needAck = false;
		}

		// Token: 0x06000060 RID: 96 RVA: 0x0000390D File Offset: 0x00001B0D
		public void RegisterBroadcastMessageListener(global::Motorola.Common.Communication.RnlBroadcastMessageEventHandler broadcastDataMessageReceived)
		{
			this.BroadcastDataMessageReceived = broadcastDataMessageReceived;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00003918 File Offset: 0x00001B18
		public override void Connect(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe communicationPipe)
		{
			this.aborted = false;
			this.stopped = true;
			this.communicationPipe = communicationPipe;
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(communicationPipe, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationXnlNotInitialized);
			if (!this.communicationPipe.IsOpen)
			{
				this.communicationPipe.OpenPort(2000);
			}
			global::Motorola.Common.Communication.XnlTrace.WriteLine("NL Connected!");
			this.stopped = false;
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00003974 File Offset: 0x00001B74
		public override ushort SendDataMessage(byte[] buffer, int bufferLength)
		{
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(this.communicationPipe, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationXnlNotInitialized);
			global::Motorola.Common.Communication.XnlPacket xnlPacket = null;
			xnlPacket = new global::Motorola.Common.Communication.XnlPacket(global::Motorola.Common.Communication.NLProtocolType.Rnl);
			xnlPacket.payloadLength = (uint)bufferLength;
			xnlPacket.opcode = 0;
			xnlPacket.payload = new byte[bufferLength];
			global::System.Buffer.BlockCopy(buffer, 0, xnlPacket.payload, 0, bufferLength);
			xnlPacket.transactionID = ushort.MaxValue;
			this.pendingRequestsPool.Add(xnlPacket);
			int i = 0;
			try
			{
				while (i < 3)
				{
					try
					{
						this.SendDataMessage(xnlPacket);
						break;
					}
					catch (global::Motorola.Common.CustomException.CommonException)
					{
						i++;
						if (i == 3)
						{
							throw;
						}
					}
				}
			}
			catch (global::Motorola.Common.CustomException.CommonException)
			{
				throw;
			}
			return xnlPacket.transactionID;
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00003A20 File Offset: 0x00001C20
		public override ushort SendBroadcastDataMessage(byte[] buffer, int bufferLength)
		{
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(this.communicationPipe, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationXnlNotInitialized);
			global::Motorola.Common.Communication.XnlPacket xnlPacket = null;
			xnlPacket = new global::Motorola.Common.Communication.XnlPacket(global::Motorola.Common.Communication.NLProtocolType.Rnl);
			xnlPacket.payloadLength = (uint)bufferLength;
			xnlPacket.opcode = 16;
			xnlPacket.payload = new byte[bufferLength];
			global::System.Buffer.BlockCopy(buffer, 0, xnlPacket.payload, 0, bufferLength);
			xnlPacket.transactionID = 65534;
			int i = 0;
			try
			{
				while (i < 3)
				{
					try
					{
						this.SendDataMessage(xnlPacket);
						break;
					}
					catch (global::Motorola.Common.CustomException.CommonException)
					{
						i++;
						if (i == 3)
						{
							throw;
						}
					}
				}
			}
			catch (global::Motorola.Common.CustomException.CommonException)
			{
				throw;
			}
			return xnlPacket.transactionID;
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00003AC0 File Offset: 0x00001CC0
		protected override void SendDataMessage(global::Motorola.Common.Communication.XnlPacket packet)
		{
			this.SendToDevice(packet);
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00003ACC File Offset: 0x00001CCC
		public override byte[] ReceiveDataMessage(ushort requireTransitionID, int timeout)
		{
			int i = 0;
			global::Motorola.Common.Communication.XnlPacket xnlPacket = null;
			while (i < 3)
			{
				try
				{
					xnlPacket = base.ReceiveDataMessageResponse(requireTransitionID, timeout);
					break;
				}
				catch (global::Motorola.Common.CustomException.CommonException)
				{
					i++;
					if (i == 3)
					{
						throw;
					}
				}
			}
			int payloadLength = (int)xnlPacket.payloadLength;
			byte[] array = new byte[payloadLength];
			global::System.Buffer.BlockCopy(xnlPacket.payload, 0, array, 0, payloadLength);
			return array;
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00003B2C File Offset: 0x00001D2C
		protected override void ReceiveMasterStatusBroadcast()
		{
			global::Motorola.Common.Communication.XnlPacket xnlPacket = new global::Motorola.Common.Communication.XnlPacket(global::Motorola.Common.Communication.NLProtocolType.Rnl);
			try
			{
				while (xnlPacket == null || xnlPacket.opcode != 16)
				{
					xnlPacket = this.ReadFromDevice(500);
				}
			}
			catch (global::Motorola.Common.CustomException.CommonException systemException)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationXnlNoMasterBroadcast, systemException);
			}
			if (xnlPacket.protocolID != global::Motorola.Common.Communication.XnlProtocol.XnlControl)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationXnlReceiveMessageFailure);
			}
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00003C38 File Offset: 0x00001E38
		public override void StartAsyncReceiveDataPackets(int timeout)
		{
			global::Motorola.Common.Communication.NLCore.ReceiveDataDelegate receiveDataDelegate = delegate(int recieveTimeout)
			{
				global::Motorola.Common.Communication.XnlTrace.WriteLine("StartAsyncReceiveDataPackets");
				while (!this.stopped)
				{
					if (this.IsListening() && this.communicationPipe.AvailableReadBytesCount >= 12)
					{
						try
						{
							global::Motorola.Common.Communication.XnlPacket xnlPacket = this.ReadFromDevice(timeout);
							if (xnlPacket != null)
							{
								this.DispatchMessage(xnlPacket);
							}
						}
						catch (global::System.Exception ex)
						{
							global::Motorola.Common.Communication.XnlTrace.WriteLine(ex.Message);
						}
					}
					this.pollerWaitHandle.WaitOne(timeout);
				}
			};
			this.receiveAsyncResult = receiveDataDelegate.BeginInvoke(timeout, null, null);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00003C7C File Offset: 0x00001E7C
		protected override void SendToDevice(global::Motorola.Common.Communication.XnlPacket xnlPacket)
		{
			if (this.aborted)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationXnlConnectionAbort);
			}
			byte[] array = xnlPacket.ToBytes();
			global::Motorola.Common.Communication.XnlTrace.WriteLine("Communication Pipe Send:" + xnlPacket.ToString());
			this.communicationPipe.SendData(array, 0, array.Length);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00003CC8 File Offset: 0x00001EC8
		protected override global::Motorola.Common.Communication.XnlPacket ReadFromDevice(int timeOut)
		{
			if (this.aborted)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationXnlConnectionAbort);
			}
			byte[] array = new byte[5];
			int num = this.communicationPipe.ReceiveData(array, 0, timeOut, 5);
			if (num != 5)
			{
				return null;
			}
			global::Motorola.Common.Communication.XnlPacket xnlPacket = new global::Motorola.Common.Communication.XnlPacket(global::Motorola.Common.Communication.NLProtocolType.Rnl);
			xnlPacket.ReadHeaderFromBytes(array);
			int payloadLength = (int)xnlPacket.payloadLength;
			if (payloadLength > 0)
			{
				byte[] array2 = new byte[payloadLength];
				int num2 = this.communicationPipe.ReceiveData(array2, 0, -1, payloadLength);
				if (num2 == payloadLength)
				{
					xnlPacket.ReadBodyFromBytes(array2);
					global::Motorola.Common.Communication.XnlTrace.WriteLine("Communication Pipe Receive: " + xnlPacket.ToString());
					return xnlPacket;
				}
			}
			return null;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00003D60 File Offset: 0x00001F60
		protected override void DispatchMessage(global::Motorola.Common.Communication.XnlPacket packet)
		{
			global::Motorola.Common.Communication.RnlOpcodes rnlOpcodes = (global::Motorola.Common.Communication.RnlOpcodes)packet.opcode;
			switch (rnlOpcodes)
			{
			case global::Motorola.Common.Communication.RnlOpcodes.DataMessage:
				break;
			case global::Motorola.Common.Communication.RnlOpcodes.DataMessageReply:
				global::Motorola.Common.Communication.XnlTrace.WriteLine("Receive Thread - DispatchMessage: DataMessage Recieved: " + packet.ToString());
				this.pendingRequestsPool.ResponseReceived(packet);
				return;
			default:
				if (rnlOpcodes != global::Motorola.Common.Communication.RnlOpcodes.BroadcastMessage)
				{
					return;
				}
				global::Motorola.Common.Communication.XnlTrace.WriteLine("Receive Thread - DispatchMessage: BroadcastMessage Recieved: " + packet.ToString());
				this.ReceiveBroadcastDataMessage(packet);
				break;
			}
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00003DC8 File Offset: 0x00001FC8
		private void ReceiveBroadcastDataMessage(global::Motorola.Common.Communication.XnlPacket packet)
		{
			if (this.BroadcastDataMessageReceived != null)
			{
				global::Motorola.Common.Communication.RnlBrdcstMsgEventArgs rnlBrdcstMsgEventArgs = new global::Motorola.Common.Communication.RnlBrdcstMsgEventArgs();
				rnlBrdcstMsgEventArgs.packet = packet;
				this.BroadcastDataMessageReceived(null, rnlBrdcstMsgEventArgs);
			}
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00003DF7 File Offset: 0x00001FF7
		private bool IsListening()
		{
			return this.BroadcastDataMessageReceived != null;
		}

		// Token: 0x04000077 RID: 119
		private global::Motorola.Common.Communication.RnlBroadcastMessageEventHandler BroadcastDataMessageReceived;
	}
}
