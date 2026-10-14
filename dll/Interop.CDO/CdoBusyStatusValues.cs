using System;
using System.Runtime.InteropServices;

namespace CDO
{
	// Token: 0x0200001C RID: 28
	public abstract class CdoBusyStatusValues
	{
		// Token: 0x040000CB RID: 203
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoBusy = "Busy";

		// Token: 0x040000CC RID: 204
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoFree = "Free";

		// Token: 0x040000CD RID: 205
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoOOF = "OOF";

		// Token: 0x040000CE RID: 206
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoTentative = "Tentative";
	}
}
