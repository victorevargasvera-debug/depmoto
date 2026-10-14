using System;
using System.Runtime.InteropServices;

namespace CDO
{
	// Token: 0x02000024 RID: 36
	public abstract class CdoExchange
	{
		// Token: 0x040001C1 RID: 449
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoAltRecipient = "http://schemas.microsoft.com/exchange/altrecipient";

		// Token: 0x040001C2 RID: 450
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoCompanies = "http://schemas.microsoft.com/exchange/companies";

		// Token: 0x040001C3 RID: 451
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoFolderSize = "http://schemas.microsoft.com/exchange/foldersize";

		// Token: 0x040001C4 RID: 452
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoHardLinkList = "http://schemas.microsoft.com/exchange/hardlinklist";

		// Token: 0x040001C5 RID: 453
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoSensitivity = "http://schemas.microsoft.com/exchange/sensitivity";
	}
}
