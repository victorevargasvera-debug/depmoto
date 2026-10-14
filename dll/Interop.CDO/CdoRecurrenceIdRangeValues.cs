using System;
using System.Runtime.InteropServices;

namespace CDO
{
	// Token: 0x0200002D RID: 45
	public abstract class CdoRecurrenceIdRangeValues
	{
		// Token: 0x04000235 RID: 565
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoNone = "None";

		// Token: 0x04000236 RID: 566
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoThisAndFuture = "ThisAndFuture";

		// Token: 0x04000237 RID: 567
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoThisAndPrior = "ThisAndPrior";
	}
}
