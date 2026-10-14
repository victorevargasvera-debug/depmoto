using System;
using System.Runtime.InteropServices;

namespace CDO
{
	// Token: 0x0200002E RID: 46
	public abstract class CdoSMTPEnvelope
	{
		// Token: 0x04000238 RID: 568
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoArrivalTime = "http://schemas.microsoft.com/cdo/smtpenvelope/arrivaltime";

		// Token: 0x04000239 RID: 569
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoClientIPAddress = "http://schemas.microsoft.com/cdo/smtpenvelope/clientipaddress";

		// Token: 0x0400023A RID: 570
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoMessageStatus = "http://schemas.microsoft.com/cdo/smtpenvelope/messagestatus";

		// Token: 0x0400023B RID: 571
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoPickupFileName = "http://schemas.microsoft.com/cdo/smtpenvelope/pickupfilename";

		// Token: 0x0400023C RID: 572
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoRecipientList = "http://schemas.microsoft.com/cdo/smtpenvelope/recipientlist";

		// Token: 0x0400023D RID: 573
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoSenderEmailAddress = "http://schemas.microsoft.com/cdo/smtpenvelope/senderemailaddress";
	}
}
