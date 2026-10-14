using System;
using System.Runtime.InteropServices;

namespace SHDocVw
{
	// Token: 0x0200006C RID: 108
	[global::System.Runtime.InteropServices.ClassInterface(global::System.Runtime.InteropServices.ClassInterfaceType.None)]
	public sealed class DShellNameSpaceEvents_SinkHelper : global::SHDocVw.DShellNameSpaceEvents
	{
		// Token: 0x060005EA RID: 1514 RVA: 0x00002050 File Offset: 0x00001050
		public void Initialized()
		{
			if (this.m_InitializedDelegate != null)
			{
				this.m_InitializedDelegate();
				return;
			}
		}

		// Token: 0x060005EB RID: 1515 RVA: 0x0000207C File Offset: 0x0000107C
		public void DoubleClick()
		{
			if (this.m_DoubleClickDelegate != null)
			{
				this.m_DoubleClickDelegate();
				return;
			}
		}

		// Token: 0x060005EC RID: 1516 RVA: 0x000020A8 File Offset: 0x000010A8
		public void SelectionChange()
		{
			if (this.m_SelectionChangeDelegate != null)
			{
				this.m_SelectionChangeDelegate();
				return;
			}
		}

		// Token: 0x060005ED RID: 1517 RVA: 0x000020D4 File Offset: 0x000010D4
		public void FavoritesSelectionChange(int A_1, int A_2, string A_3, string A_4, int A_5, string A_6, int A_7)
		{
			if (this.m_FavoritesSelectionChangeDelegate != null)
			{
				this.m_FavoritesSelectionChangeDelegate(A_1, A_2, A_3, A_4, A_5, A_6, A_7);
				return;
			}
		}

		// Token: 0x060005EE RID: 1518 RVA: 0x0000211C File Offset: 0x0000111C
		internal DShellNameSpaceEvents_SinkHelper()
		{
			this.m_dwCookie = 0;
			this.m_InitializedDelegate = null;
			this.m_DoubleClickDelegate = null;
			this.m_SelectionChangeDelegate = null;
			this.m_FavoritesSelectionChangeDelegate = null;
		}

		// Token: 0x0400005D RID: 93
		public global::SHDocVw.DShellNameSpaceEvents_InitializedEventHandler m_InitializedDelegate;

		// Token: 0x0400005E RID: 94
		public global::SHDocVw.DShellNameSpaceEvents_DoubleClickEventHandler m_DoubleClickDelegate;

		// Token: 0x0400005F RID: 95
		public global::SHDocVw.DShellNameSpaceEvents_SelectionChangeEventHandler m_SelectionChangeDelegate;

		// Token: 0x04000060 RID: 96
		public global::SHDocVw.DShellNameSpaceEvents_FavoritesSelectionChangeEventHandler m_FavoritesSelectionChangeDelegate;

		// Token: 0x04000061 RID: 97
		public int m_dwCookie;
	}
}
