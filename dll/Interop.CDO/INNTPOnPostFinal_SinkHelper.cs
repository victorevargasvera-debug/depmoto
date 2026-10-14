using System;
using System.Runtime.InteropServices;

namespace CDO
{
	// Token: 0x0200007A RID: 122
	[global::System.Runtime.InteropServices.ClassInterface(global::System.Runtime.InteropServices.ClassInterfaceType.None)]
	[global::System.Runtime.InteropServices.TypeLibType(global::System.Runtime.InteropServices.TypeLibTypeFlags.FHidden)]
	public sealed class INNTPOnPostFinal_SinkHelper : global::CDO.INNTPOnPostFinal
	{
		// Token: 0x060003BB RID: 955 RVA: 0x00002898 File Offset: 0x00001898
		public void OnPostFinal(global::CDO.IMessage A_1, ref global::CDO.CdoEventStatus A_2)
		{
			if (this.m_OnPostFinalDelegate != null)
			{
				this.m_OnPostFinalDelegate(A_1, ref A_2);
				return;
			}
		}

		// Token: 0x060003BC RID: 956 RVA: 0x000028CC File Offset: 0x000018CC
		internal INNTPOnPostFinal_SinkHelper()
		{
			this.m_dwCookie = 0;
			this.m_OnPostFinalDelegate = null;
		}

		// Token: 0x04000283 RID: 643
		public global::CDO.INNTPOnPostFinal_OnPostFinalEventHandler m_OnPostFinalDelegate;

		// Token: 0x04000284 RID: 644
		public int m_dwCookie;
	}
}
