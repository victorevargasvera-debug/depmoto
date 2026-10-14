using System;
using System.Runtime.InteropServices;

namespace CDO
{
	// Token: 0x0200007C RID: 124
	[global::System.Runtime.InteropServices.TypeLibType(global::System.Runtime.InteropServices.TypeLibTypeFlags.FHidden)]
	[global::System.Runtime.InteropServices.ClassInterface(global::System.Runtime.InteropServices.ClassInterfaceType.None)]
	public sealed class INNTPOnPost_SinkHelper : global::CDO.INNTPOnPost
	{
		// Token: 0x060003C3 RID: 963 RVA: 0x00002CBC File Offset: 0x00001CBC
		public void OnPost(global::CDO.IMessage A_1, ref global::CDO.CdoEventStatus A_2)
		{
			if (this.m_OnPostDelegate != null)
			{
				this.m_OnPostDelegate(A_1, ref A_2);
				return;
			}
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x00002CF0 File Offset: 0x00001CF0
		internal INNTPOnPost_SinkHelper()
		{
			this.m_dwCookie = 0;
			this.m_OnPostDelegate = null;
		}

		// Token: 0x04000288 RID: 648
		public global::CDO.INNTPOnPost_OnPostEventHandler m_OnPostDelegate;

		// Token: 0x04000289 RID: 649
		public int m_dwCookie;
	}
}
