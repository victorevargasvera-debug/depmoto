using System;
using System.Runtime.InteropServices;

namespace CDO
{
	// Token: 0x0200002F RID: 47
	public abstract class CdoTransparentValues
	{
		// Token: 0x0400023E RID: 574
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoOpaque = "Opaque";

		// Token: 0x0400023F RID: 575
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoTransparent = "Transparent";
	}
}
