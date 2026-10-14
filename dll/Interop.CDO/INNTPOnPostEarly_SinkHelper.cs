using System;
using System.Runtime.InteropServices;

namespace CDO
{
	// Token: 0x02000078 RID: 120
	[global::System.Runtime.InteropServices.TypeLibType(global::System.Runtime.InteropServices.TypeLibTypeFlags.FHidden)]
	[global::System.Runtime.InteropServices.ClassInterface(global::System.Runtime.InteropServices.ClassInterfaceType.None)]
	public sealed class INNTPOnPostEarly_SinkHelper : global::CDO.INNTPOnPostEarly
	{
		// Token: 0x060003B3 RID: 947 RVA: 0x00002474 File Offset: 0x00001474
		public void OnPostEarly(global::CDO.IMessage A_1, ref global::CDO.CdoEventStatus A_2)
		{
			if (this.m_OnPostEarlyDelegate != null)
			{
				this.m_OnPostEarlyDelegate(A_1, ref A_2);
				return;
			}
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x000024A8 File Offset: 0x000014A8
		internal INNTPOnPostEarly_SinkHelper()
		{
			this.m_dwCookie = 0;
			this.m_OnPostEarlyDelegate = null;
		}

		// Token: 0x0400027E RID: 638
		public global::CDO.INNTPOnPostEarly_OnPostEarlyEventHandler m_OnPostEarlyDelegate;

		// Token: 0x0400027F RID: 639
		public int m_dwCookie;
	}
}
