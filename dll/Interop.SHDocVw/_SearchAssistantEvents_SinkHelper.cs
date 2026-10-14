using System;
using System.Runtime.InteropServices;

namespace SHDocVw
{
	// Token: 0x02000072 RID: 114
	[global::System.Runtime.InteropServices.ClassInterface(global::System.Runtime.InteropServices.ClassInterfaceType.None)]
	public sealed class _SearchAssistantEvents_SinkHelper : global::SHDocVw._SearchAssistantEvents
	{
		// Token: 0x0600063E RID: 1598 RVA: 0x00005094 File Offset: 0x00004094
		public void OnNewSearch()
		{
			if (this.m_OnNewSearchDelegate != null)
			{
				this.m_OnNewSearchDelegate();
				return;
			}
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x000050C0 File Offset: 0x000040C0
		public void OnNextMenuSelect(int A_1)
		{
			if (this.m_OnNextMenuSelectDelegate != null)
			{
				this.m_OnNextMenuSelectDelegate(A_1);
				return;
			}
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x000050F0 File Offset: 0x000040F0
		internal _SearchAssistantEvents_SinkHelper()
		{
			this.m_dwCookie = 0;
			this.m_OnNewSearchDelegate = null;
			this.m_OnNextMenuSelectDelegate = null;
		}

		// Token: 0x04000080 RID: 128
		public global::SHDocVw._SearchAssistantEvents_OnNewSearchEventHandler m_OnNewSearchDelegate;

		// Token: 0x04000081 RID: 129
		public global::SHDocVw._SearchAssistantEvents_OnNextMenuSelectEventHandler m_OnNextMenuSelectDelegate;

		// Token: 0x04000082 RID: 130
		public int m_dwCookie;
	}
}
