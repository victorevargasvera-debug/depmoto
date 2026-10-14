using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ENCATENCOMPONENTLib
{
	// Token: 0x0200000E RID: 14
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::System.Runtime.InteropServices.Guid("F4A4A6BF-9516-4F24-8E5A-E2DA63EDB8E6")]
	[global::System.Runtime.InteropServices.TypeIdentifier]
	[global::System.Runtime.InteropServices.ComImport]
	public interface IEncaten
	{
		// Token: 0x0600007C RID: 124
		void _VtblGap1_3();

		// Token: 0x0600007D RID: 125
		[global::System.Runtime.InteropServices.DispId(4)]
		int extractCurrentFileToFile([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string bstrFilePathDestination);

		// Token: 0x0600007E RID: 126
		void _VtblGap2_19();

		// Token: 0x0600007F RID: 127
		[global::System.Runtime.InteropServices.DispId(24)]
		int getFilePackageEncryptionStatus(out bool bFilePackageEncryptionEnabled);

		// Token: 0x06000080 RID: 128
		void _VtblGap3_25();

		// Token: 0x06000081 RID: 129
		[global::System.Runtime.InteropServices.DispId(50)]
		int openAndGetFilePackage([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] string bstrFilePackagePath, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] string bstrPassword, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] out string bstrFileContentsData);
	}
}
