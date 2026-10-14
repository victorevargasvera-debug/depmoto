using System;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x02000CA6 RID: 3238
	[global::System.Runtime.InteropServices.ComConversionLoss]
	[global::System.Runtime.InteropServices.StructLayout(global::System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 4)]
	public struct __MIDL___MIDL_itf_mshtml_0250_0010
	{
		// Token: 0x040003D4 RID: 980
		public uint cbSize;

		// Token: 0x040003D5 RID: 981
		public uint fType;

		// Token: 0x040003D6 RID: 982
		public uint fState;

		// Token: 0x040003D7 RID: 983
		public uint wID;

		// Token: 0x040003D8 RID: 984
		[global::System.Runtime.InteropServices.ComConversionLoss]
		[global::System.Runtime.InteropServices.ComAliasName("mshtml.wireHBITMAP")]
		public global::System.IntPtr hbmpChecked;

		// Token: 0x040003D9 RID: 985
		[global::System.Runtime.InteropServices.ComConversionLoss]
		[global::System.Runtime.InteropServices.ComAliasName("mshtml.wireHBITMAP")]
		public global::System.IntPtr hbmpUnchecked;

		// Token: 0x040003DA RID: 986
		public uint dwItemData;

		// Token: 0x040003DB RID: 987
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 80)]
		public byte[] szString;

		// Token: 0x040003DC RID: 988
		[global::System.Runtime.InteropServices.ComConversionLoss]
		[global::System.Runtime.InteropServices.ComAliasName("mshtml.wireHBITMAP")]
		public global::System.IntPtr hbmpItem;
	}
}
