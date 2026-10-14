using System;
using System.Runtime.InteropServices;

namespace CDO
{
	// Token: 0x0200002A RID: 42
	public abstract class CdoNamespace
	{
		// Token: 0x04000229 RID: 553
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoNSCalendar = "urn:schemas:calendar:";

		// Token: 0x0400022A RID: 554
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoNSConfiguration = "http://schemas.microsoft.com/cdo/configuration/";

		// Token: 0x0400022B RID: 555
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoNSContacts = "urn:schemas:contacts:";

		// Token: 0x0400022C RID: 556
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoNSDAV = "DAV:";

		// Token: 0x0400022D RID: 557
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoNSHTTPMail = "urn:schemas:httpmail:";

		// Token: 0x0400022E RID: 558
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoNSMailHeader = "urn:schemas:mailheader:";

		// Token: 0x0400022F RID: 559
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoNSNNTPEnvelope = "http://schemas.microsoft.com/cdo/nntpenvelope/";

		// Token: 0x04000230 RID: 560
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoNSSMTPEnvelope = "http://schemas.microsoft.com/cdo/smtpenvelope/";

		// Token: 0x04000231 RID: 561
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoNSVCAL = "urn:schemas:vcal:";
	}
}
