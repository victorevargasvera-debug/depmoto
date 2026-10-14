using System;
using System.Threading;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.CustomException;
using XnlAuthenticationDotNet;

namespace Motorola.Common.Communication
{
	// Token: 0x02000014 RID: 20
	internal class NLCore : global::System.IDisposable
	{
		// Token: 0x06000039 RID: 57 RVA: 0x00002CE0 File Offset: 0x00000EE0
		public NLCore()
		{
			this.NLType = global::Motorola.Common.Communication.NLProtocolType.Xnl;
			this.communicationPipe = null;
			this.xnlMasterAddress = 0;
			this.xnlDeviceAddress = 0;
			this.xnlLogicalAddress = 0;
			this.xnlTargetAddress = this.xnlMasterAddress;
			this.xnlRepeaterRxAddress = 0;
			this.xnlFlag = 0;
			this.tempXnlAddress = 0;
			this.transactionID = 255;
			this.encryptedValue = null;
			this.pendingRequestsPool = new global::Motorola.Common.Communication.PendingRequestsPool();
			this.isDualBoard = false;
			this.stopped = true;
			this.pollerWaitHandle = new global::System.Threading.AutoResetEvent(false);
			this.receiveAsyncResult = null;
			this.needAck = true;
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002D88 File Offset: 0x00000F88
		~NLCore()
		{
			this.Dispose(false);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002DB8 File Offset: 0x00000FB8
		public virtual void Connect(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe communicationPipe)
		{
			this.aborted = false;
			this.stopped = true;
			this.communicationPipe = communicationPipe;
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(communicationPipe, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationXnlNotInitialized);
			if (!this.communicationPipe.IsOpen)
			{
				this.communicationPipe.OpenPort(2000);
			}
			try
			{
				this.ReceiveMasterStatusBroadcast();
			}
			catch (global::Motorola.Common.CustomException.CommonException)
			{
				global::Motorola.Common.Communication.NLCore.MultiTry(new global::Motorola.Common.Communication.NLCore.processDelegate(this.SendDeviceMasterQuery), new global::Motorola.Common.Communication.NLCore.processDelegate(this.ReceiveMasterStatusBroadcast));
			}
			global::Motorola.Common.Communication.NLCore.MultiTry(new global::Motorola.Common.Communication.NLCore.processDelegate(this.SendAuthenticationKeyRequest), new global::Motorola.Common.Communication.NLCore.processDelegate(this.ReceiveAuthenticationKeyReply));
			global::Motorola.Common.Communication.NLCore.MultiTry(new global::Motorola.Common.Communication.NLCore.processDelegate(this.SendConnectionRequest), new global::Motorola.Common.Communication.NLCore.processDelegate(this.ReceiveConnectionReply));
			global::Motorola.Common.Communication.NLCore.MultiTry(new global::Motorola.Common.Communication.NLCore.processDelegate(this.DeviceInitialize));
			global::Motorola.Common.Communication.XnlTrace.WriteLine("NL Connected!");
			this.stopped = false;
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002E98 File Offset: 0x00001098
		public void Disconnect(bool aborted)
		{
			this.aborted = aborted;
			this.stopped = true;
			if (this.receiveAsyncResult != null)
			{
				this.receiveAsyncResult.AsyncWaitHandle.WaitOne(5000);
				this.receiveAsyncResult = null;
			}
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002ED0 File Offset: 0x000010D0
		public virtual ushort SendDataMessage(byte[] buffer, int bufferLength)
		{
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(this.communicationPipe, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationXnlNotInitialized);
			global::Motorola.Common.Communication.XnlPacket xnlPacket = null;
			this.UpdateTransactionID();
			this.UpdateXnlFlag();
			xnlPacket = new global::Motorola.Common.Communication.XnlPacket(global::Motorola.Common.Communication.NLProtocolType.Xnl);
			global::Motorola.Common.Communication.XnlPacket xnlPacket2 = xnlPacket;
			xnlPacket2.payloadLength = (uint)((ushort)bufferLength);
			xnlPacket2.payload = new byte[bufferLength];
			global::System.Buffer.BlockCopy(buffer, 0, xnlPacket.payload, 0, bufferLength);
			xnlPacket2.opcode = 11;
			xnlPacket2.protocolID = global::Motorola.Common.Communication.XnlProtocol.Xcmp;
			xnlPacket2.xnlFlags = this.xnlFlag;
			xnlPacket2.destinationAddr = this.xnlTargetAddress;
			xnlPacket2.sourceAddress = this.xnlDeviceAddress;
			xnlPacket2.transactionID = this.transactionID;
			this.pendingRequestsPool.Add(xnlPacket2);
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
				this.pendingRequestsPool.Remove(this.transactionID);
				throw;
			}
			return xnlPacket.transactionID;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002FC8 File Offset: 0x000011C8
		public virtual ushort SendBroadcastDataMessage(byte[] buffer, int bufferLength)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002FD0 File Offset: 0x000011D0
		protected virtual void SendDataMessage(global::Motorola.Common.Communication.XnlPacket packet)
		{
			this.SendToDevice(packet);
			if (this.NLType == global::Motorola.Common.Communication.NLProtocolType.Xnl && this.needAck && this.pendingRequestsPool.GetRequestAck(packet.transactionID, global::Motorola.Common.Communication.NLConstants.DefaultTimeout + global::Motorola.Common.Communication.NLConstants.AdditionalAckTimeout + 2000) == null)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationDataMessageAckTimeout);
			}
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00003024 File Offset: 0x00001224
		public virtual byte[] ReceiveDataMessage(ushort requireTransitionID, int timeout)
		{
			int i = 0;
			global::Motorola.Common.Communication.XnlPacket xnlPacket = null;
			while (i < 3)
			{
				try
				{
					xnlPacket = this.ReceiveDataMessageResponse(requireTransitionID, timeout);
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

		// Token: 0x06000041 RID: 65 RVA: 0x00003084 File Offset: 0x00001284
		protected global::Motorola.Common.Communication.XnlPacket ReceiveDataMessageResponse(ushort requireTransitionID, int timeout)
		{
			global::Motorola.Common.Communication.XnlPacket response = this.pendingRequestsPool.GetResponse(requireTransitionID, timeout);
			if (response == null)
			{
				global::Motorola.Common.Communication.XnlTrace.WriteLine("CommonErrorCode.CommunicationXnlReceiveMessageTimeout for packetID: " + requireTransitionID);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationXnlReceiveMessageTimeout);
			}
			return response;
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000042 RID: 66 RVA: 0x000030C3 File Offset: 0x000012C3
		public bool IsDualBoard
		{
			get
			{
				return this.isDualBoard;
			}
		}

		// Token: 0x06000043 RID: 67 RVA: 0x000030CB File Offset: 0x000012CB
		public void SetTarget(global::Motorola.Common.Communication.TargetBoard targetBoard)
		{
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsFalse(this.isDualBoard, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationXnlNotDualBoard);
			if (targetBoard == global::Motorola.Common.Communication.TargetBoard.XnlTargetTX)
			{
				this.xnlTargetAddress = this.xnlMasterAddress;
				return;
			}
			this.xnlTargetAddress = this.xnlRepeaterRxAddress;
		}

		// Token: 0x06000044 RID: 68 RVA: 0x000031AC File Offset: 0x000013AC
		public virtual void StartAsyncReceiveDataPackets(int timeout)
		{
			global::Motorola.Common.Communication.NLCore.ReceiveDataDelegate receiveDataDelegate = delegate(int recieveTimeout)
			{
				global::Motorola.Common.Communication.XnlTrace.WriteLine("StartAsyncReceiveDataPackets");
				while (!this.stopped)
				{
					if (this.communicationPipe.AvailableReadBytesCount >= 12)
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
							global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("StartAsyncReceiveDataPackets " + ex.Message, new object[0]);
						}
					}
					this.pollerWaitHandle.WaitOne(global::Motorola.Common.Communication.NLConstants.BroadcastPollWaitTimeout);
				}
			};
			this.receiveAsyncResult = receiveDataDelegate.BeginInvoke(timeout, null, null);
		}

		// Token: 0x06000045 RID: 69 RVA: 0x000031F0 File Offset: 0x000013F0
		protected virtual void DispatchMessage(global::Motorola.Common.Communication.XnlPacket packet)
		{
			global::Motorola.Common.Communication.XnlOpcodes opcode = (global::Motorola.Common.Communication.XnlOpcodes)packet.opcode;
			if (opcode != global::Motorola.Common.Communication.XnlOpcodes.MasterStatusBroadcast)
			{
				switch (opcode)
				{
				case global::Motorola.Common.Communication.XnlOpcodes.DeviceSysMapBroadcast:
				case global::Motorola.Common.Communication.XnlOpcodes.DeviceResetMessage:
					break;
				case global::Motorola.Common.Communication.XnlOpcodes.DataMessage:
					if (!this.CheckDeviceInitStatusBroadcast(packet))
					{
						global::Motorola.Common.Communication.XnlTrace.WriteLine("Receive Thread - DispatchMessage: DataMessage Recieved: " + packet.ToString());
						this.pendingRequestsPool.ResponseReceived(packet);
						return;
					}
					break;
				case global::Motorola.Common.Communication.XnlOpcodes.DataMessageAck:
					this.pendingRequestsPool.RequestAckReceived(packet);
					return;
				default:
					return;
				}
			}
			else
			{
				this.xnlMasterAddress = packet.sourceAddress;
				this.xnlTargetAddress = this.xnlMasterAddress;
			}
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00003274 File Offset: 0x00001474
		private bool CheckDeviceInitStatusBroadcast(global::Motorola.Common.Communication.XnlPacket packet)
		{
			if (packet.payloadLength >= 2U)
			{
				int num = (int)packet.payload[0] * 256 + (int)packet.payload[1];
				if (num == 46080)
				{
					this.CheckDualBoard(packet);
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000047 RID: 71 RVA: 0x000032B8 File Offset: 0x000014B8
		private global::Motorola.Common.Communication.DeviceInitType CheckDualBoard(global::Motorola.Common.Communication.XnlPacket packet)
		{
			global::Motorola.Common.Communication.DeviceInitType result;
			global::Motorola.Common.Communication.DeviceType deviceType;
			global::Motorola.Common.Communication.XnlPacket.DecodeDeviceInitStatusBroadcastPacket(packet, out result, out deviceType);
			if (packet.sourceAddress != this.xnlMasterAddress && (deviceType == global::Motorola.Common.Communication.DeviceType.RFTransceiver || deviceType == global::Motorola.Common.Communication.DeviceType.Vrs))
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Dual board device detected.", new object[0]);
				this.isDualBoard = true;
				this.xnlRepeaterRxAddress = packet.sourceAddress;
			}
			return result;
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00003310 File Offset: 0x00001510
		private void SendDeviceMasterQuery()
		{
			global::Motorola.Common.Communication.XnlPacket deviceMasterQueryPacket = global::Motorola.Common.Communication.XnlPacket.GetDeviceMasterQueryPacket();
			this.SendToDevice(deviceMasterQueryPacket);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x0000332C File Offset: 0x0000152C
		protected virtual void ReceiveMasterStatusBroadcast()
		{
			global::Motorola.Common.Communication.XnlPacket xnlPacket = new global::Motorola.Common.Communication.XnlPacket(global::Motorola.Common.Communication.NLProtocolType.Xnl);
			try
			{
				while (xnlPacket == null || xnlPacket.opcode != 2)
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
			this.xnlMasterAddress = xnlPacket.sourceAddress;
			this.xnlTargetAddress = this.xnlMasterAddress;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x000033A4 File Offset: 0x000015A4
		private void SendAuthenticationKeyRequest()
		{
			global::Motorola.Common.Communication.XnlPacket deviceAuthKeyRequestPacket = global::Motorola.Common.Communication.XnlPacket.GetDeviceAuthKeyRequestPacket(this.xnlMasterAddress);
			this.SendToDevice(deviceAuthKeyRequestPacket);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x000033C4 File Offset: 0x000015C4
		private void ReceiveAuthenticationKeyReply()
		{
			global::Motorola.Common.Communication.XnlPacket xnlPacket = new global::Motorola.Common.Communication.XnlPacket(global::Motorola.Common.Communication.NLProtocolType.Xnl);
			try
			{
				while (xnlPacket == null || xnlPacket.opcode != 5 || xnlPacket.destinationAddr != this.xnlDeviceAddress || xnlPacket.sourceAddress != this.xnlMasterAddress)
				{
					xnlPacket = this.ReadFromDevice(global::Motorola.Common.Communication.NLConstants.DefaultTimeout);
				}
			}
			catch (global::Motorola.Common.CustomException.CommonException systemException)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationXnlAuthenticationRequestFailure, systemException);
			}
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsTrue(xnlPacket.protocolID != global::Motorola.Common.Communication.XnlProtocol.XnlControl, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationXnlReceiveMessageFailure);
			this.tempXnlAddress = (ushort)((int)xnlPacket.payload[0] * 256 + (int)xnlPacket.payload[1]);
			byte[] array = new byte[8];
			global::System.Buffer.BlockCopy(xnlPacket.payload, 2, array, 0, 8);
			this.encryptedValue = global::XnlAuthenticationDotNet.XnlAuthentication.EncryptAuthKey(array);
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00003484 File Offset: 0x00001684
		private void SendConnectionRequest()
		{
			global::Motorola.Common.Communication.XnlPacket deviceConnRequestPacket = global::Motorola.Common.Communication.XnlPacket.GetDeviceConnRequestPacket(this.xnlMasterAddress, this.tempXnlAddress, 0, 10, 0, this.encryptedValue);
			this.SendToDevice(deviceConnRequestPacket);
		}

		// Token: 0x0600004D RID: 77 RVA: 0x000034B4 File Offset: 0x000016B4
		private void ReceiveConnectionReply()
		{
			global::Motorola.Common.Communication.XnlPacket xnlPacket = new global::Motorola.Common.Communication.XnlPacket(global::Motorola.Common.Communication.NLProtocolType.Xnl);
			try
			{
				while (xnlPacket == null || xnlPacket.opcode != 7 || xnlPacket.destinationAddr != this.tempXnlAddress || xnlPacket.sourceAddress != this.xnlMasterAddress)
				{
					xnlPacket = this.ReadFromDevice(global::Motorola.Common.Communication.NLConstants.DefaultTimeout);
				}
			}
			catch (global::Motorola.Common.CustomException.CommonException systemException)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationXnlConnectionRequestFailure, systemException);
			}
			byte b;
			byte[] authenticationValue;
			global::Motorola.Common.Communication.XnlPacket.DecodeDeviceConnReplyPacket(xnlPacket, out b, out this.transactionIdBase, out this.xnlDeviceAddress, out this.xnlLogicalAddress, out authenticationValue);
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsTrue(b != 1, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationXnlConnectFailure);
			this.needAck = ((xnlPacket.xnlFlags & global::Motorola.Common.Communication.NLConstants.ConnectionRequestNeedAckXnlFlags) == 0);
			bool parameter = global::XnlAuthenticationDotNet.XnlAuthentication.ValidateEncryptedAuthKey(authenticationValue, this.encryptedValue);
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsFalse(parameter, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationXnlAuthenticationFailure);
			this.encryptedValue.Initialize();
			this.encryptedValue = null;
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00003590 File Offset: 0x00001790
		private void DeviceInitialize()
		{
			global::Motorola.Common.Communication.XnlPacket xnlPacket = new global::Motorola.Common.Communication.XnlPacket(global::Motorola.Common.Communication.NLProtocolType.Xnl);
			int num = 0;
			try
			{
				for (;;)
				{
					if (xnlPacket != null && xnlPacket.opcode == 11 && xnlPacket.protocolID == global::Motorola.Common.Communication.XnlProtocol.Xcmp && num == 46080)
					{
						global::Motorola.Common.Communication.DeviceInitType deviceInitType = this.CheckDualBoard(xnlPacket);
						if (deviceInitType == global::Motorola.Common.Communication.DeviceInitType.DeviceInitStatus)
						{
							this.UpdateXnlFlag();
							ushort num2 = xnlPacket.transactionID;
							global::Motorola.Common.Communication.XnlPacket deviceInitStatusBroadcastPacket = global::Motorola.Common.Communication.XnlPacket.GetDeviceInitStatusBroadcastPacket(this.xnlMasterAddress, this.xnlDeviceAddress, num2);
							this.SendToDevice(deviceInitStatusBroadcastPacket);
						}
						else if (deviceInitType == global::Motorola.Common.Communication.DeviceInitType.DeviceInitComplete)
						{
							break;
						}
						num = 0;
					}
					else
					{
						xnlPacket = this.ReadFromDevice(1000);
						if (xnlPacket != null && xnlPacket.payloadLength >= 2U)
						{
							num = (int)xnlPacket.payload[0] * 256 + (int)xnlPacket.payload[1];
						}
					}
				}
			}
			catch (global::Motorola.Common.CustomException.CommonException systemException)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationXnlConnectionInitFailure, systemException);
			}
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00003658 File Offset: 0x00001858
		protected virtual void SendToDevice(global::Motorola.Common.Communication.XnlPacket xnlPacket)
		{
			if (this.aborted)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationXnlConnectionAbort);
			}
			byte[] array = xnlPacket.ToBytes();
			lock (this.pipeLock)
			{
				global::Motorola.Common.Communication.XnlTrace.WriteLine("Communication Pipe Send:" + xnlPacket.ToString());
				this.communicationPipe.SendData(array, 0, array.Length);
			}
		}

		// Token: 0x06000050 RID: 80 RVA: 0x000036D4 File Offset: 0x000018D4
		protected virtual global::Motorola.Common.Communication.XnlPacket ReadFromDevice(int timeOut)
		{
			if (this.aborted)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationXnlConnectionAbort);
			}
			global::Motorola.Common.Communication.XnlPacket xnlPacket = null;
			lock (this.pipeLock)
			{
				byte[] array = this.communicationPipe.ReceiveData(timeOut);
				if (array != null)
				{
					xnlPacket = new global::Motorola.Common.Communication.XnlPacket(global::Motorola.Common.Communication.NLProtocolType.Xnl);
					xnlPacket.ReadFromBytes(array);
					global::Motorola.Common.Communication.XnlTrace.WriteLine("Communication Pipe Receive: " + xnlPacket.ToString());
					if (xnlPacket.opcode == 11 && this.needAck)
					{
						global::Motorola.Common.Communication.XnlPacket dataAckPacket = global::Motorola.Common.Communication.XnlPacket.GetDataAckPacket(xnlPacket);
						this.SendToDevice(dataAckPacket);
					}
				}
			}
			return xnlPacket;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x0000377C File Offset: 0x0000197C
		private void UpdateXnlFlag()
		{
			this.xnlFlag += 1;
			if (this.xnlFlag >= 7)
			{
				this.xnlFlag = 0;
			}
		}

		// Token: 0x06000052 RID: 82 RVA: 0x000037A0 File Offset: 0x000019A0
		private void UpdateTransactionID()
		{
			this.transactionIDCounter += 1;
			if (this.transactionIDCounter >= 255)
			{
				this.transactionIDCounter = 0;
			}
			this.transactionID = (ushort)((int)this.transactionIdBase * 256 + (int)this.transactionIDCounter);
			if (this.transactionID == 0)
			{
				this.transactionIDCounter += 1;
			}
			this.transactionID = (ushort)((int)this.transactionIdBase * 256 + (int)this.transactionIDCounter);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x0000381C File Offset: 0x00001A1C
		private static void MultiTry(global::Motorola.Common.Communication.NLCore.processDelegate processFunction)
		{
			int i = 0;
			while (i < 3)
			{
				try
				{
					processFunction();
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

		// Token: 0x06000054 RID: 84 RVA: 0x00003858 File Offset: 0x00001A58
		private static void MultiTry(global::Motorola.Common.Communication.NLCore.processDelegate sendDelegate, global::Motorola.Common.Communication.NLCore.processDelegate receiveDelegate)
		{
			int i = 0;
			while (i < 3)
			{
				try
				{
					sendDelegate();
					receiveDelegate();
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

		// Token: 0x06000055 RID: 85 RVA: 0x00003898 File Offset: 0x00001A98
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x06000056 RID: 86 RVA: 0x000038A8 File Offset: 0x00001AA8
		private void Dispose(bool disposing)
		{
			if (!this.disposed)
			{
				this.Disconnect(false);
				if (disposing)
				{
					if (this.communicationPipe != null)
					{
						this.communicationPipe.ClosePort();
						this.communicationPipe = null;
					}
					this.pendingRequestsPool.Dispose();
					this.pollerWaitHandle.Dispose();
				}
				this.disposed = true;
			}
		}

		// Token: 0x04000061 RID: 97
		private global::Motorola.Common.Communication.NLProtocolType NLType;

		// Token: 0x04000062 RID: 98
		private bool disposed;

		// Token: 0x04000063 RID: 99
		protected global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe communicationPipe;

		// Token: 0x04000064 RID: 100
		protected bool stopped;

		// Token: 0x04000065 RID: 101
		protected bool aborted;

		// Token: 0x04000066 RID: 102
		private byte transactionIdBase;

		// Token: 0x04000067 RID: 103
		private byte transactionIDCounter;

		// Token: 0x04000068 RID: 104
		private ushort transactionID;

		// Token: 0x04000069 RID: 105
		private ushort xnlMasterAddress;

		// Token: 0x0400006A RID: 106
		private ushort xnlTargetAddress;

		// Token: 0x0400006B RID: 107
		private ushort xnlDeviceAddress;

		// Token: 0x0400006C RID: 108
		private ushort xnlLogicalAddress;

		// Token: 0x0400006D RID: 109
		private ushort tempXnlAddress;

		// Token: 0x0400006E RID: 110
		private ushort xnlRepeaterRxAddress;

		// Token: 0x0400006F RID: 111
		protected bool needAck;

		// Token: 0x04000070 RID: 112
		protected global::Motorola.Common.Communication.PendingRequestsPool pendingRequestsPool;

		// Token: 0x04000071 RID: 113
		protected global::System.IAsyncResult receiveAsyncResult;

		// Token: 0x04000072 RID: 114
		protected global::System.Threading.AutoResetEvent pollerWaitHandle;

		// Token: 0x04000073 RID: 115
		private byte xnlFlag;

		// Token: 0x04000074 RID: 116
		private bool isDualBoard;

		// Token: 0x04000075 RID: 117
		private object pipeLock = new object();

		// Token: 0x04000076 RID: 118
		private byte[] encryptedValue;

		// Token: 0x02000015 RID: 21
		// (Invoke) Token: 0x06000058 RID: 88
		protected delegate void ReceiveDataDelegate(int timeout);

		// Token: 0x02000016 RID: 22
		// (Invoke) Token: 0x0600005C RID: 92
		private delegate void processDelegate();
	}
}
