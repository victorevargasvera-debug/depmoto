using System;
using System.Collections.Generic;
using System.Linq;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Security;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.CommunicationPipe
{
	// Token: 0x0200000D RID: 13
	public class SecureCommPipe : global::Motorola.Common.Communication.CommunicationPipe.CommPipeChains
	{
		// Token: 0x0600009F RID: 159 RVA: 0x000039B4 File Offset: 0x00001BB4
		public SecureCommPipe(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transport, global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.AuthenticationInfo> authInfoList) : base(transport)
		{
			if (authInfoList != null)
			{
				this.authenticationInfoList = authInfoList;
				return;
			}
			this.authenticationInfoList = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.AuthenticationInfo>();
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x000039E4 File Offset: 0x00001BE4
		public override void OpenPort(int timeout)
		{
			this.securityLayer = new global::Motorola.Common.Communication.Security.SecurityLayer(base._lowerTransport);
			if (!this.securityLayer.Initialize(global::Motorola.Common.Communication.CommunicationPipe.SecureCommPipe.ConvertAuthInfo(this.authenticationInfoList)))
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Security_OpenSSL_Initialize_Failed);
			}
			try
			{
				base.OpenPort(timeout);
				int num = this.securityLayer.Connect(3);
				if (num <= 0)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Security_OpenSSL_Handshake_Failed);
				}
			}
			catch (global::System.Exception)
			{
				this.ClosePort();
				throw;
			}
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00003A68 File Offset: 0x00001C68
		public override void SendData(byte[] buffer, int start, int length)
		{
			byte[] array;
			if (start > 0)
			{
				array = new byte[length];
				global::System.Array.Copy(buffer, start, array, 0, length);
			}
			else
			{
				array = buffer;
			}
			if (this.securityLayer == null)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Security_OpenSSL_Uninitialize);
			}
			int num = this.securityLayer.SendData(array, length);
			if (num != length)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Security_OpenSSL_Send_Failed);
			}
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00003AC0 File Offset: 0x00001CC0
		public override byte[] ReceiveData()
		{
			if (this.securityLayer == null)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Security_OpenSSL_Uninitialize);
			}
			int num = this.securityLayer.ReceiveData(this.rx_buffer, 5120);
			if (num <= 0 || num > 5120)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Security_OpenSSL_Receive_Failed);
			}
			return this.rx_buffer.Take(num).ToArray<byte>();
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00003B1F File Offset: 0x00001D1F
		public override byte[] RequestData(byte[] buffer, int start, int length, int timeout)
		{
			this.SendData(buffer, start, length);
			return this.ReceiveData();
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00003B30 File Offset: 0x00001D30
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

		// Token: 0x060000A5 RID: 165 RVA: 0x00003B98 File Offset: 0x00001D98
		private static global::System.Collections.Generic.List<global::Motorola.Common.Communication.Security.AuthenticationMaterials> ConvertAuthInfo(global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.AuthenticationInfo> authInfoList)
		{
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.Security.AuthenticationMaterials> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Security.AuthenticationMaterials>();
			foreach (global::Motorola.Common.Communication.CommonUtil.AuthenticationInfo authenticationInfo in authInfoList)
			{
				global::Motorola.Common.Communication.Security.AuthenticationMaterials item;
				if (authenticationInfo != null && authenticationInfo.AuthType == global::Motorola.Common.Communication.CommonUtil.AuthenticationType.PreSharedKey)
				{
					item = new global::Motorola.Common.Communication.Security.AuthenticationMaterials(global::Motorola.Common.Communication.Security.SecurityEndpointMode.CLIENT, authenticationInfo.PreSharedKey_ID, "de315f6ab3" + authenticationInfo.PreSharedKey_Material);
				}
				else
				{
					item = new global::Motorola.Common.Communication.Security.AuthenticationMaterials(global::Motorola.Common.Communication.Security.SecurityEndpointMode.CLIENT, "KEY1", "de315f6ab30000000000");
				}
				list.Add(item);
			}
			return list;
		}

		// Token: 0x04000053 RID: 83
		private const int RX_BUF_LEN = 5120;

		// Token: 0x04000054 RID: 84
		private const string Default_Key_Id = "KEY1";

		// Token: 0x04000055 RID: 85
		private const string Default_Key_Value = "de315f6ab30000000000";

		// Token: 0x04000056 RID: 86
		private const string Application_Key_Value = "de315f6ab3";

		// Token: 0x04000057 RID: 87
		private global::Motorola.Common.Communication.Security.SecurityLayer securityLayer;

		// Token: 0x04000058 RID: 88
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.AuthenticationInfo> authenticationInfoList;

		// Token: 0x04000059 RID: 89
		private byte[] rx_buffer = new byte[5120];
	}
}
