using System;
using System.Runtime.InteropServices;

namespace CDO
{
	// Token: 0x02000028 RID: 40
	public abstract class CdoMeetingStatusValues
	{
		// Token: 0x0400021E RID: 542
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoMeetingStatusCancelled = "Cancelled";

		// Token: 0x0400021F RID: 543
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoMeetingStatusConfirmed = "Confirmed";

		// Token: 0x04000220 RID: 544
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoMeetingStatusTentative = "Tentative";
	}
}
