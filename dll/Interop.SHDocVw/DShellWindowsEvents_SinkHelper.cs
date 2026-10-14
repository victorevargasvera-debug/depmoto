using System;
using System.Runtime.InteropServices;

namespace SHDocVw
{
	// Token: 0x0200006E RID: 110
	[global::System.Runtime.InteropServices.ClassInterface(global::System.Runtime.InteropServices.ClassInterfaceType.None)]
	public sealed class DShellWindowsEvents_SinkHelper : global::SHDocVw.DShellWindowsEvents
	{
		// Token: 0x060005FB RID: 1531 RVA: 0x000029C8 File Offset: 0x000019C8
		public void WindowRevoked(int A_1)
		{
			if (this.m_WindowRevokedDelegate != null)
			{
				this.m_WindowRevokedDelegate(A_1);
				return;
			}
		}

		// Token: 0x060005FC RID: 1532 RVA: 0x000029F8 File Offset: 0x000019F8
		public void WindowRegistered(int A_1)
		{
			if (this.m_WindowRegisteredDelegate != null)
			{
				this.m_WindowRegisteredDelegate(A_1);
				return;
			}
		}

		// Token: 0x060005FD RID: 1533 RVA: 0x00002A28 File Offset: 0x00001A28
		internal DShellWindowsEvents_SinkHelper()
		{
			this.m_dwCookie = 0;
			this.m_WindowRevokedDelegate = null;
			this.m_WindowRegisteredDelegate = null;
		}

		// Token: 0x04000065 RID: 101
		public global::SHDocVw.DShellWindowsEvents_WindowRevokedEventHandler m_WindowRevokedDelegate;

		// Token: 0x04000066 RID: 102
		public global::SHDocVw.DShellWindowsEvents_WindowRegisteredEventHandler m_WindowRegisteredDelegate;

		// Token: 0x04000067 RID: 103
		public int m_dwCookie;
	}
}
