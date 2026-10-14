using System;
using System.Runtime.InteropServices;

namespace CDO
{
	// Token: 0x02000023 RID: 35
	public abstract class CdoEncodingType
	{
		// Token: 0x040001BA RID: 442
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdo7bit = "7bit";

		// Token: 0x040001BB RID: 443
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdo8bit = "8bit";

		// Token: 0x040001BC RID: 444
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoBase64 = "base64";

		// Token: 0x040001BD RID: 445
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoBinary = "binary";

		// Token: 0x040001BE RID: 446
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoMacBinHex40 = "mac-binhex40";

		// Token: 0x040001BF RID: 447
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoQuotedPrintable = "quoted-printable";

		// Token: 0x040001C0 RID: 448
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoUuencode = "uuencode";
	}
}
