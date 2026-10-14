using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x02000CF1 RID: 3313
	[global::System.Runtime.InteropServices.TypeLibType(4160)]
	[global::System.Runtime.InteropServices.Guid("3050F5E0-98B5-11CF-BB82-00AA00BDCE0B")]
	[global::System.Runtime.InteropServices.ComImport]
	public interface IHTMLDialog2
	{
		// Token: 0x170075CD RID: 30157
		// (get) Token: 0x0601637B RID: 91003
		// (set) Token: 0x0601637A RID: 91002
		[global::System.Runtime.InteropServices.DispId(25014)]
		string status { [global::System.Runtime.InteropServices.TypeLibFunc(64)] [global::System.Runtime.InteropServices.DispId(25014)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.TypeLibFunc(64)] [global::System.Runtime.InteropServices.DispId(25014)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170075CE RID: 30158
		// (get) Token: 0x0601637D RID: 91005
		// (set) Token: 0x0601637C RID: 91004
		[global::System.Runtime.InteropServices.DispId(25015)]
		string resizable { [global::System.Runtime.InteropServices.DispId(25015)] [global::System.Runtime.InteropServices.TypeLibFunc(64)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.TypeLibFunc(64)] [global::System.Runtime.InteropServices.DispId(25015)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }
	}
}
