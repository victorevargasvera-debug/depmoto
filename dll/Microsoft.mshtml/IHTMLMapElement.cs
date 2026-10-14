using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x020008CF RID: 2255
	[global::System.Runtime.InteropServices.Guid("3050F266-98B5-11CF-BB82-00AA00BDCE0B")]
	[global::System.Runtime.InteropServices.TypeLibType(4160)]
	[global::System.Runtime.InteropServices.ComImport]
	public interface IHTMLMapElement
	{
		// Token: 0x17004BC1 RID: 19393
		// (get) Token: 0x0600E612 RID: 58898
		[global::System.Runtime.InteropServices.DispId(1002)]
		global::mshtml.IHTMLAreasCollection areas { [global::System.Runtime.InteropServices.DispId(1002)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x17004BC2 RID: 19394
		// (get) Token: 0x0600E614 RID: 58900
		// (set) Token: 0x0600E613 RID: 58899
		[global::System.Runtime.InteropServices.DispId(-2147418112)]
		string name { [global::System.Runtime.InteropServices.DispId(-2147418112)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(-2147418112)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }
	}
}
