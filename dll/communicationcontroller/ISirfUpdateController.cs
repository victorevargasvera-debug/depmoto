using System;

namespace CommunicationController
{
	// Token: 0x0200000C RID: 12
	public interface ISirfUpdateController
	{
		// Token: 0x0600005A RID: 90
		void FlashDeviceWithBuffer(ref byte[] alDataList, long lDataLen, string strIPAddress);

		// Token: 0x0600005B RID: 91
		void FlashDeviceWithFile(string strFileName, string strIPAddress);
	}
}
