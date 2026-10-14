using System;
using System.Collections.Generic;
using System.IO;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Security;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.CommunicationPipe
{
	// Token: 0x0200000E RID: 14
	public class SecureUpgradeCommPipe : global::Motorola.Common.Communication.CommunicationPipe.CommPipeChains
	{
		// Token: 0x060000A6 RID: 166 RVA: 0x00003C2C File Offset: 0x00001E2C
		public SecureUpgradeCommPipe(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transport, global::Motorola.Common.Communication.CommonUtil.AuthenticationInfo authInfoList, int tlsvID) : base(transport)
		{
			this.authenticationInfo = authInfoList;
			this.tcpClientCommPipe = (transport as global::Motorola.Common.Communication.CommunicationPipe.TcpClientCommPipe);
			this.tcpClientCommPipe.needExtractHeader = false;
			this.tlsvID = tlsvID;
			this.authMaterials = new global::Motorola.Common.Communication.Security.AuthenticationMaterials(global::Motorola.Common.Communication.Security.SecurityEndpointMode.CLIENT, (int)this.authenticationInfo.AuthType, (int)this.authenticationInfo.StreType, this.authenticationInfo.Certificate_File, this.authenticationInfo.Public_Key, this.authenticationInfo.PreSharedKey_Material);
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00003CCC File Offset: 0x00001ECC
		public override void OpenPort(int timeout)
		{
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.Security.AuthenticationMaterials> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Security.AuthenticationMaterials>();
			list.Add(this.authMaterials);
			this.securityLayer = new global::Motorola.Common.Communication.Security.SecurityLayer(base._lowerTransport);
			this.securityLayer.SettlsvID(this.tlsvID);
			if (!this.securityLayer.Initialize(list))
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Security_OpenSSL_Initialize_Failed);
			}
			try
			{
				base.OpenPort(timeout);
				int num = this.securityLayer.Connect(4);
				if (num <= 0)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Security_OpenSSL_Handshake_Failed);
				}
			}
			catch
			{
				throw;
			}
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00003D60 File Offset: 0x00001F60
		private void SendDataToBaseStream(byte[] buffer, int start, int length)
		{
			byte[] array = buffer;
			if (length > global::Motorola.Common.Communication.CommunicationPipe.SecureUpgradeCommPipe.SEC_COMM_PIPE_SEND_BLOCK_SIZE)
			{
				array = new byte[global::Motorola.Common.Communication.CommunicationPipe.SecureUpgradeCommPipe.SEC_COMM_PIPE_SEND_BLOCK_SIZE];
			}
			try
			{
				int num = 0;
				while (length - num > 0)
				{
					int num2 = (length - num > global::Motorola.Common.Communication.CommunicationPipe.SecureUpgradeCommPipe.SEC_COMM_PIPE_SEND_BLOCK_SIZE) ? global::Motorola.Common.Communication.CommunicationPipe.SecureUpgradeCommPipe.SEC_COMM_PIPE_SEND_BLOCK_SIZE : (length - num);
					if (length > global::Motorola.Common.Communication.CommunicationPipe.SecureUpgradeCommPipe.SEC_COMM_PIPE_SEND_BLOCK_SIZE)
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
			catch
			{
				throw;
			}
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00003DEC File Offset: 0x00001FEC
		public override void SendData(byte[] buffer, int start, int length)
		{
			lock (this.WriteBuffer.SyncRoot)
			{
				this.WriteBuffer[0] = (byte)(length >> 8);
				this.WriteBuffer[1] = (byte)(length & 255);
				global::System.Buffer.BlockCopy(buffer, start, this.WriteBuffer, 2, length);
				this.SendDataToBaseStream(this.WriteBuffer, 0, length + 2);
			}
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00003E68 File Offset: 0x00002068
		private int ReceiveDataFromBaseStream(byte[] buffer, int start, int length)
		{
			int num = 0;
			try
			{
				for (;;)
				{
					int num2 = length - num;
					if (num2 > global::Motorola.Common.Communication.CommunicationPipe.SecureUpgradeCommPipe.SEC_COMM_PIPE_READ_BUFFER_SIZE)
					{
						num2 = global::Motorola.Common.Communication.CommunicationPipe.SecureUpgradeCommPipe.SEC_COMM_PIPE_READ_BUFFER_SIZE;
					}
					this.tcpClientCommPipe.ReceiveTimeout = base.ReceiveTimeout;
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

		// Token: 0x060000AB RID: 171 RVA: 0x00003F0C File Offset: 0x0000210C
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
			byte[] array2 = new byte[num2];
			int num4 = this.ReceiveDataFromBaseStream(array2, 0, array2.Length);
			if (num4 > 0)
			{
				num3 = (uint)((uint)array2[0] << 8);
				num3 += (uint)array2[1];
			}
			if (num3 > 0U)
			{
				array = new byte[num3];
				this.ReceiveDataFromBaseStream(array, 0, (int)num3);
			}
			if (num > 0)
			{
				base.ReceiveTimeout = num;
			}
			return array;
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00003F82 File Offset: 0x00002182
		public override byte[] RequestData(byte[] buffer, int start, int length, int timeout)
		{
			this.SendData(buffer, start, length);
			return this.ReceiveData();
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00003F94 File Offset: 0x00002194
		public override void ClosePort()
		{
			if (this.securityLayer != null)
			{
				try
				{
					base.ClosePort();
				}
				catch (global::System.Exception ex)
				{
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Closed with exception: {0} ", new object[]
					{
						ex.ToString()
					});
				}
				finally
				{
					this.securityLayer = null;
				}
			}
		}

		// Token: 0x0400005A RID: 90
		private global::Motorola.Common.Communication.CommunicationPipe.TcpClientCommPipe tcpClientCommPipe;

		// Token: 0x0400005B RID: 91
		private global::Motorola.Common.Communication.Security.SecurityLayer securityLayer;

		// Token: 0x0400005C RID: 92
		private global::Motorola.Common.Communication.CommonUtil.AuthenticationInfo authenticationInfo;

		// Token: 0x0400005D RID: 93
		private static readonly int SEC_COMM_PIPE_READ_BUFFER_SIZE = 12288;

		// Token: 0x0400005E RID: 94
		private static readonly int SEC_COMM_PIPE_SEND_BLOCK_SIZE = 12288;

		// Token: 0x0400005F RID: 95
		private byte[] ReadBuffer = new byte[global::Motorola.Common.Communication.CommunicationPipe.SecureUpgradeCommPipe.SEC_COMM_PIPE_READ_BUFFER_SIZE];

		// Token: 0x04000060 RID: 96
		private byte[] WriteBuffer = new byte[global::Motorola.Common.Communication.CommunicationPipe.SecureUpgradeCommPipe.SEC_COMM_PIPE_SEND_BLOCK_SIZE];

		// Token: 0x04000061 RID: 97
		private global::Motorola.Common.Communication.Security.AuthenticationMaterials authMaterials;

		// Token: 0x04000062 RID: 98
		private int tlsvID;
	}
}
