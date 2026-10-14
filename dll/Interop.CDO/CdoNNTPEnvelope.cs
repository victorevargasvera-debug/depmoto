using System;
using System.Runtime.InteropServices;

namespace CDO
{
	// Token: 0x0200002B RID: 43
	public abstract class CdoNNTPEnvelope
	{
		// Token: 0x04000232 RID: 562
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoNewsgroupList = "http://schemas.microsoft.com/cdo/nntpenvelope/newsgrouplist";

		// Token: 0x04000233 RID: 563
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoNNTPProcessing = "http://schemas.microsoft.com/cdo/nntpenvelope/nntpprocessing";
	}
}
