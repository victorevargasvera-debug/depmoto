using System;
using System.Collections;
using Motorola.Common.Communication.CommonUtil;

namespace CommunicationController
{
	// Token: 0x0200000A RID: 10
	public interface ISerialTransportController
	{
		// Token: 0x0600001A RID: 26
		void OpenController();

		// Token: 0x0600001B RID: 27
		void CloseController();

		// Token: 0x0600001C RID: 28
		global::CommunicationController.ISerialTransportController GetPointer();

		// Token: 0x0600001D RID: 29
		void Open(string strIPaddress, uint uiProtocolType, uint uiProtocolPortNumber, out uint uiHandle);

		// Token: 0x0600001E RID: 30
		void CloseRemote(uint uiHandle);

		// Token: 0x0600001F RID: 31
		void Listen(uint uiProtocolType, uint uiProtocolPortNumber, string certificate, string pswd);

		// Token: 0x06000020 RID: 32
		void Accept(out uint uiHandle, uint peerID, uint Timeout, global::Motorola.Common.Communication.CommonUtil.RadioOperation operationType);

		// Token: 0x06000021 RID: 33
		void Close(uint uiHandle);

		// Token: 0x06000022 RID: 34
		void ListConnectedDevices(out global::System.Collections.ArrayList alDeviceList);

		// Token: 0x06000023 RID: 35
		void ReadBlocking(uint uiHandle, byte[] readBuffer, uint bytesRequested, out uint bytesReturned, uint timeout);

		// Token: 0x06000024 RID: 36
		void WriteBlocking(uint uiHandle, byte[] writeBuffer, uint numberOfBytes);

		// Token: 0x06000025 RID: 37
		bool ValidateRemotePassword(uint uiHandle, string userName, string password);

		// Token: 0x17000008 RID: 8
		global::CommunicationController.CSerialTransportController.STCConnection this[uint uiHandle]
		{
			get;
		}
	}
}
