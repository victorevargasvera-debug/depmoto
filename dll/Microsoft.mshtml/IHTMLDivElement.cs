using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x020004B7 RID: 1207
	[global::System.Runtime.InteropServices.Guid("3050F200-98B5-11CF-BB82-00AA00BDCE0B")]
	[global::System.Runtime.InteropServices.TypeLibType(4160)]
	[global::System.Runtime.InteropServices.ComImport]
	public interface IHTMLDivElement
	{
		// Token: 0x17001ECC RID: 7884
		// (get) Token: 0x06005CB7 RID: 23735
		// (set) Token: 0x06005CB6 RID: 23734
		[global::System.Runtime.InteropServices.DispId(-2147418040)]
		string align { [global::System.Runtime.InteropServices.DispId(-2147418040)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(-2147418040)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17001ECD RID: 7885
		// (get) Token: 0x06005CB9 RID: 23737
		// (set) Token: 0x06005CB8 RID: 23736
		[global::System.Runtime.InteropServices.DispId(-2147413107)]
		bool noWrap { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413107)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413107)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }
	}
}
