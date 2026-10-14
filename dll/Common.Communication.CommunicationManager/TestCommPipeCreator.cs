using System;
using System.Net;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x02000028 RID: 40
	internal class TestCommPipeCreator : global::Motorola.Common.Communication.CommunicationManager.ICommunicationPipeCreator
	{
		// Token: 0x06000132 RID: 306 RVA: 0x0000703C File Offset: 0x0000523C
		public global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe Create(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			global::System.Net.IPAddress ipaddress = global::Motorola.Common.Communication.CommunicationManager.Utilities.GetIPAddress(deviceInfo);
			return this.newTestCommPipe(ipaddress, global::Motorola.Common.Communication.CommunicationManager.Constants.RadioTCPPort, true);
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000133 RID: 307 RVA: 0x0000705D File Offset: 0x0000525D
		public global::System.Type ExpectedType
		{
			get
			{
				return typeof(global::Motorola.Common.Communication.CommunicationPipe.TestCommPipe);
			}
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00007069 File Offset: 0x00005269
		private global::Motorola.Common.Communication.CommunicationPipe.TestCommPipe newTestCommPipe(global::System.Net.IPAddress ipAddress, int portNumber, bool noDelay)
		{
			return new global::Motorola.Common.Communication.CommunicationPipe.TestCommPipe();
		}
	}
}
