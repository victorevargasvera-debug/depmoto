using System;
using System.Runtime.InteropServices;

namespace CDO
{
	// Token: 0x02000076 RID: 118
	[global::System.Runtime.InteropServices.TypeLibType(global::System.Runtime.InteropServices.TypeLibTypeFlags.FHidden)]
	[global::System.Runtime.InteropServices.ClassInterface(global::System.Runtime.InteropServices.ClassInterfaceType.None)]
	public sealed class ISMTPOnArrival_SinkHelper : global::CDO.ISMTPOnArrival
	{
		// Token: 0x060003AB RID: 939 RVA: 0x00002050 File Offset: 0x00001050
		public void OnArrival(global::CDO.IMessage A_1, ref global::CDO.CdoEventStatus A_2)
		{
			if (this.m_OnArrivalDelegate != null)
			{
				this.m_OnArrivalDelegate(A_1, ref A_2);
				return;
			}
		}

		// Token: 0x060003AC RID: 940 RVA: 0x00002084 File Offset: 0x00001084
		internal ISMTPOnArrival_SinkHelper()
		{
			this.m_dwCookie = 0;
			this.m_OnArrivalDelegate = null;
		}

		// Token: 0x04000279 RID: 633
		public global::CDO.ISMTPOnArrival_OnArrivalEventHandler m_OnArrivalDelegate;

		// Token: 0x0400027A RID: 634
		public int m_dwCookie;
	}
}
