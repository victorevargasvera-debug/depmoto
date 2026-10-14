using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Reflection;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.PCRRemoteProgramming;
using Motorola.Common.Communication.Security;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.CommunicationPipe
{
	// Token: 0x0200000B RID: 11
	public class P2PCommPipe : global::Motorola.Common.Communication.CommunicationPipe.CommPipeChains
	{
		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000070 RID: 112 RVA: 0x00002F9F File Offset: 0x0000119F
		// (set) Token: 0x06000071 RID: 113 RVA: 0x00002FA7 File Offset: 0x000011A7
		public global::Motorola.Common.Communication.CommonUtil.AuthenticationInfo AuthenticationInfo
		{
			get
			{
				return this.authenticationInfo;
			}
			private set
			{
				this.authenticationInfo = value;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000072 RID: 114 RVA: 0x00002FB0 File Offset: 0x000011B0
		// (set) Token: 0x06000073 RID: 115 RVA: 0x00002FB8 File Offset: 0x000011B8
		private global::System.Net.IPAddress m_RemoteIPAddress { get; set; }

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000074 RID: 116 RVA: 0x00002FC1 File Offset: 0x000011C1
		// (set) Token: 0x06000075 RID: 117 RVA: 0x00002FC9 File Offset: 0x000011C9
		private int m_RemotePortNum { get; set; }

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000076 RID: 118 RVA: 0x00002FD2 File Offset: 0x000011D2
		// (set) Token: 0x06000077 RID: 119 RVA: 0x00002FDA File Offset: 0x000011DA
		public bool Validated
		{
			private get
			{
				return this.validated;
			}
			set
			{
				this.validated = value;
			}
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00002FE4 File Offset: 0x000011E4
		public P2PCommPipe(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transport, global::Motorola.Common.Communication.CommonUtil.AuthenticationInfo authInfo, global::System.Net.IPAddress RemoteIPAddress, int TargetPeerID, int receiveTimeout, bool isInRPMode = false) : base(transport)
		{
			this.m_RemoteIPAddress = RemoteIPAddress;
			this.m_TargetPeerID = TargetPeerID;
			this.IsInRPMode = isInRPMode;
			this.authenticationInfo = authInfo;
			this.tcpListenerCommPipe = (transport as global::Motorola.Common.Communication.CommunicationPipe.TcpListenerCommPipe);
			this.tcpListenerCommPipe.needExtractHeader = false;
			this.tcpListenerCommPipe.ReceiveTimeout = receiveTimeout;
			base.ReceiveTimeout = receiveTimeout;
			this.m_LocalTcpPort = this.tcpListenerCommPipe.LocalPortNumber;
			this.authMaterials = new global::Motorola.Common.Communication.Security.AuthenticationMaterials(global::Motorola.Common.Communication.Security.SecurityEndpointMode.SERVER, this.authenticationInfo.Certificate_File, this.authenticationInfo.PreSharedKey_Material);
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000079 RID: 121 RVA: 0x00003096 File Offset: 0x00001296
		public int LocalPortNum
		{
			get
			{
				return this.m_LocalTcpPort;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600007A RID: 122 RVA: 0x0000309E File Offset: 0x0000129E
		public global::System.Net.IPAddress RemoteIPAddress
		{
			get
			{
				return this.m_RemoteIPAddress;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600007B RID: 123 RVA: 0x000030A6 File Offset: 0x000012A6
		public int TargetPeerID
		{
			get
			{
				return this.m_TargetPeerID;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600007C RID: 124 RVA: 0x000030AE File Offset: 0x000012AE
		private uint TransportHandle
		{
			get
			{
				return this.m_handleToST;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600007D RID: 125 RVA: 0x000030B6 File Offset: 0x000012B6
		private global::System.IntPtr TransportPointer
		{
			get
			{
				return global::System.IntPtr.Zero;
			}
		}

		// Token: 0x0600007E RID: 126 RVA: 0x000030C0 File Offset: 0x000012C0
		public override void OpenPort(int timeout)
		{
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.Security.AuthenticationMaterials> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Security.AuthenticationMaterials>();
			this.securityLayer = new global::Motorola.Common.Communication.Security.SecurityLayer(base._lowerTransport);
			this.tcpListenerCommPipe.Listen();
			this.returnFromProxy = global::Motorola.Common.Communication.PCRRemoteProgramming.PCRRPConstants.ProxyResponse.SUCCESS_TLSv10;
			try
			{
				if (!this.IsInRPMode)
				{
					this.returnFromProxy = (global::Motorola.Common.Communication.PCRRemoteProgramming.PCRRPConstants.ProxyResponse)global::Motorola.Common.Communication.PCRRemoteProgramming.LEDeviceManager.Instance.SendProxyConnectRequest((uint)this.m_TargetPeerID, global::System.Net.IPAddress.Any.ToString(), (uint)this.tcpListenerCommPipe.LocalPortNumber, global::Motorola.Common.Communication.PCRRemoteProgramming.PCRRPConstants.PROXY_TCP);
				}
			}
			catch (global::System.Exception)
			{
				base.ClosePort();
				throw;
			}
			if (this.returnFromProxy == global::Motorola.Common.Communication.PCRRemoteProgramming.PCRRPConstants.ProxyResponse.SUCCESS_TLSv12)
			{
				this.securityLayer.SettlsvID(2);
				string directoryName = global::System.IO.Path.GetDirectoryName(global::System.Reflection.Assembly.GetExecutingAssembly().Location);
				this.authenticationInfo.Certificate_File = global::System.IO.Path.Combine(directoryName, "Metadata", "PCR", global::Motorola.Common.Communication.PCRRemoteProgramming.PCRRPConstants.RetrieveASCIIString(global::Motorola.Common.Communication.PCRRemoteProgramming.PCRRPConstants.SSLCERTFTX));
				this.authenticationInfo.PreSharedKey_Material = global::Motorola.Common.Communication.PCRRemoteProgramming.PCRRPConstants.RetrieveASCIIString(global::Motorola.Common.Communication.PCRRemoteProgramming.PCRRPConstants.SSLPSWDFTX);
				this.authMaterials = new global::Motorola.Common.Communication.Security.AuthenticationMaterials(global::Motorola.Common.Communication.Security.SecurityEndpointMode.SERVER, this.authenticationInfo.Certificate_File, this.authenticationInfo.PreSharedKey_Material);
			}
			list.Add(this.authMaterials);
			if (!this.securityLayer.Initialize(list))
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Security_OpenSSL_Initialize_Failed);
			}
			this.OpenPort();
			try
			{
				this.securityLayer.Accept();
			}
			catch (global::System.Exception systemException)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeOpenFailure, systemException);
			}
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00003220 File Offset: 0x00001420
		private void OpenPort()
		{
			try
			{
				if (this.returnFromProxy != global::Motorola.Common.Communication.PCRRemoteProgramming.PCRRPConstants.ProxyResponse.SUCCESS_TLSv10 && this.returnFromProxy != global::Motorola.Common.Communication.PCRRemoteProgramming.PCRRPConstants.ProxyResponse.SUCCESS_TLSv12)
				{
					global::Motorola.Common.CustomException.CommonException ex = null;
					switch (this.returnFromProxy)
					{
					case global::Motorola.Common.Communication.PCRRemoteProgramming.PCRRPConstants.ProxyResponse.COMMAND_NOT_SUPPORTED:
						ex = new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.PCR_RP_REMOTE_COMMAND_NOT_SUPPORTED);
						break;
					case global::Motorola.Common.Communication.PCRRemoteProgramming.PCRRPConstants.ProxyResponse.BUSY:
						ex = new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.PCR_RP_REMOTE_OPERATION_BUSY);
						break;
					case global::Motorola.Common.Communication.PCRRemoteProgramming.PCRRPConstants.ProxyResponse.SERVICE_NOT_SUPPORTED:
						ex = new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.PCR_RP_REMOTE_SERVICE_NOT_SUPPORTED);
						break;
					case global::Motorola.Common.Communication.PCRRemoteProgramming.PCRRPConstants.ProxyResponse.RRP_NOT_ENABLED:
						ex = new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.PCR_RP_REMOTE_OPERATION_DISABLED);
						break;
					}
					throw ex;
				}
				uint timeout = global::Motorola.Common.Communication.PCRRemoteProgramming.PCRRPConstants.ACCEPT_TIMEOUT;
				if (this.IsInRPMode)
				{
					timeout = global::Motorola.Common.Communication.PCRRemoteProgramming.PCRRPConstants.ACCEPT_RP_TIMEOUT;
				}
				this.tcpListenerCommPipe.Accept((int)timeout);
				base.IsOpen = true;
			}
			catch (global::Motorola.Common.CustomException.CommonException)
			{
				base.ClosePort();
				throw;
			}
			catch (global::System.Exception systemException)
			{
				base.ClosePort();
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeOpenFailure, systemException);
			}
		}

		// Token: 0x06000080 RID: 128 RVA: 0x000032FC File Offset: 0x000014FC
		private void SendDataToBaseStream(byte[] buffer, int start, int length)
		{
			byte[] array = buffer;
			if (length > global::Motorola.Common.Communication.CommunicationPipe.P2PCommPipe.P2P_COMM_PIPE_SEND_BLOCK_SIZE)
			{
				array = new byte[global::Motorola.Common.Communication.CommunicationPipe.P2PCommPipe.P2P_COMM_PIPE_SEND_BLOCK_SIZE];
			}
			try
			{
				int num = 0;
				while (length - num > 0)
				{
					int num2 = (length - num > global::Motorola.Common.Communication.CommunicationPipe.P2PCommPipe.P2P_COMM_PIPE_SEND_BLOCK_SIZE) ? global::Motorola.Common.Communication.CommunicationPipe.P2PCommPipe.P2P_COMM_PIPE_SEND_BLOCK_SIZE : (length - num);
					if (length > global::Motorola.Common.Communication.CommunicationPipe.P2PCommPipe.P2P_COMM_PIPE_SEND_BLOCK_SIZE)
					{
						global::System.Array.Copy(buffer, start + num, array, 0, num2);
					}
					int num3 = this.securityLayer.SendData(array, num2);
					if (num3 != num2)
					{
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Security_OpenSSL_Send_Failed);
					}
					num += num2;
				}
			}
			catch (global::System.Exception)
			{
				throw;
			}
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00003388 File Offset: 0x00001588
		private int ReceiveDataFromBaseStream(byte[] buffer, int start, int length)
		{
			int num = 0;
			try
			{
				for (;;)
				{
					int num2 = length - num;
					if (num2 > global::Motorola.Common.Communication.CommunicationPipe.P2PCommPipe.P2P_COMM_PIPE_READ_BUFFER_SIZE)
					{
						num2 = global::Motorola.Common.Communication.CommunicationPipe.P2PCommPipe.P2P_COMM_PIPE_READ_BUFFER_SIZE;
					}
					this.tcpListenerCommPipe.ReceiveTimeout = base.ReceiveTimeout;
					int num3 = this.securityLayer.ReceiveData(this.ReadBuffer, num2);
					if (num3 <= 0)
					{
						break;
					}
					global::System.Array.Copy(this.ReadBuffer, 0, buffer, start + num, num3);
					num += num3;
					if (num >= length)
					{
						goto Block_4;
					}
				}
				return 0;
				Block_4:;
			}
			catch (global::System.IO.IOException systemException)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeReadFailure, systemException);
			}
			catch (global::System.ArgumentOutOfRangeException systemException2)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentOutOfRange, systemException2);
			}
			return num;
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000082 RID: 130 RVA: 0x0000342C File Offset: 0x0000162C
		// (set) Token: 0x06000083 RID: 131 RVA: 0x00003434 File Offset: 0x00001634
		public bool IsInHugeMode
		{
			private get
			{
				return this.isInHugeMode;
			}
			set
			{
				this.isInHugeMode = value;
				if (this.isInHugeMode)
				{
					this.WriteBuffer = new byte[global::Motorola.Common.Communication.CommunicationPipe.P2PCommPipe.P2P_COMM_PIPE_SEND_BLOCK_SIZE_HUGE];
					return;
				}
				this.WriteBuffer = new byte[global::Motorola.Common.Communication.CommunicationPipe.P2PCommPipe.P2P_COMM_PIPE_SEND_BLOCK_SIZE];
			}
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00003468 File Offset: 0x00001668
		public override void SendData(byte[] buffer, int start, int length)
		{
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.ValidateArrayStartLength<byte>(buffer, start, length);
			if (this.IsInRPMode && this.Validated)
			{
				this.SendDataToBaseStream(buffer, start, length);
				return;
			}
			lock (this.WriteBuffer.SyncRoot)
			{
				this.WriteBuffer[0] = (byte)(length >> 8);
				this.WriteBuffer[1] = (byte)(length & 255);
				global::System.Buffer.BlockCopy(buffer, start, this.WriteBuffer, 2, length);
				this.SendDataToBaseStream(this.WriteBuffer, 0, length + 2);
			}
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00003504 File Offset: 0x00001704
		public override byte[] ReceiveData(int timeout)
		{
			int num = 0;
			if (timeout > 0)
			{
				num = base.ReceiveTimeout;
				base.ReceiveTimeout = timeout;
			}
			int num2 = 2;
			uint num3 = 0U;
			byte[] array = null;
			if (this.IsInRPMode && this.Validated)
			{
				num2 = 5;
			}
			byte[] array2 = new byte[num2];
			int num4 = this.ReceiveDataFromBaseStream(array2, 0, array2.Length);
			if (num4 > 0)
			{
				if (this.IsInRPMode && this.Validated)
				{
					num3 = global::Motorola.Common.Communication.XnlPacket.ReadDwordFromBytes(array2, 1);
				}
				else
				{
					num3 = (uint)global::Motorola.Common.Communication.XnlPacket.ReadWordFromBytes(array2, 0);
				}
			}
			if (num3 > 0U)
			{
				if (this.IsInRPMode && this.Validated)
				{
					array = new byte[(ulong)num3 + (ulong)((long)num2)];
					global::System.Array.Copy(array2, array, array2.Length);
					this.ReceiveDataFromBaseStream(array, num2, (int)num3);
				}
				else
				{
					array = new byte[num3];
					this.ReceiveDataFromBaseStream(array, 0, (int)num3);
				}
			}
			if (num > 0)
			{
				base.ReceiveTimeout = num;
			}
			return array;
		}

		// Token: 0x06000086 RID: 134 RVA: 0x000035D8 File Offset: 0x000017D8
		public override int ReceiveData(byte[] buffer, int start, int timeout, int expectedlength)
		{
			int num = 0;
			if (timeout > 0)
			{
				num = base.ReceiveTimeout;
				base.ReceiveTimeout = timeout;
			}
			if (timeout == -1)
			{
				num = base.ReceiveTimeout;
				base.ReceiveTimeout = int.MaxValue;
			}
			int result = 0;
			if (expectedlength > 0)
			{
				result = this.ReceiveDataFromBaseStream(buffer, start, expectedlength);
			}
			if (num > 0)
			{
				base.ReceiveTimeout = num;
			}
			return result;
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000087 RID: 135 RVA: 0x0000362D File Offset: 0x0000182D
		public override int AvailableReadBytesCount
		{
			get
			{
				return this.tcpListenerCommPipe.AvailableReadBytesCount;
			}
		}

		// Token: 0x06000088 RID: 136 RVA: 0x0000363A File Offset: 0x0000183A
		public override byte[] RequestData(byte[] buffer, int start, int length, int timeout)
		{
			this.SendData(buffer, start, length);
			return this.ReceiveData(timeout);
		}

		// Token: 0x06000089 RID: 137 RVA: 0x0000364D File Offset: 0x0000184D
		public override void ClosePort()
		{
			if (!base.IsOpen)
			{
				return;
			}
			if (this.securityLayer != null)
			{
				this.securityLayer.Uninitialize();
				base.ClosePort();
				base.IsOpen = false;
				return;
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Security_OpenSSL_Uninitialize);
		}

		// Token: 0x04000038 RID: 56
		private static readonly int P2P_COMM_PIPE_READ_BUFFER_SIZE = 4096;

		// Token: 0x04000039 RID: 57
		private static readonly int P2P_COMM_PIPE_SEND_BLOCK_SIZE = 1200;

		// Token: 0x0400003A RID: 58
		private static readonly int P2P_COMM_PIPE_SEND_BLOCK_SIZE_HUGE = 65535;

		// Token: 0x0400003B RID: 59
		private global::Motorola.Common.Communication.Security.SecurityLayer securityLayer;

		// Token: 0x0400003C RID: 60
		private global::Motorola.Common.Communication.CommonUtil.AuthenticationInfo authenticationInfo;

		// Token: 0x0400003D RID: 61
		private global::Motorola.Common.Communication.CommunicationPipe.TcpListenerCommPipe tcpListenerCommPipe;

		// Token: 0x0400003E RID: 62
		private int m_LocalTcpPort;

		// Token: 0x0400003F RID: 63
		private int m_TargetPeerID;

		// Token: 0x04000040 RID: 64
		private uint m_handleToST;

		// Token: 0x04000041 RID: 65
		private byte[] ReadBuffer = new byte[global::Motorola.Common.Communication.CommunicationPipe.P2PCommPipe.P2P_COMM_PIPE_READ_BUFFER_SIZE];

		// Token: 0x04000042 RID: 66
		private byte[] WriteBuffer = new byte[global::Motorola.Common.Communication.CommunicationPipe.P2PCommPipe.P2P_COMM_PIPE_SEND_BLOCK_SIZE];

		// Token: 0x04000043 RID: 67
		private bool IsInRPMode;

		// Token: 0x04000044 RID: 68
		private bool validated;

		// Token: 0x04000045 RID: 69
		private global::Motorola.Common.Communication.Security.AuthenticationMaterials authMaterials;

		// Token: 0x04000046 RID: 70
		private global::Motorola.Common.Communication.PCRRemoteProgramming.PCRRPConstants.ProxyResponse returnFromProxy;

		// Token: 0x04000047 RID: 71
		private bool isInHugeMode;
	}
}
