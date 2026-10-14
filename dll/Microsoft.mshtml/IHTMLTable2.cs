using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x020009F6 RID: 2550
	[global::System.Runtime.InteropServices.Guid("3050F4AD-98B5-11CF-BB82-00AA00BDCE0B")]
	[global::System.Runtime.InteropServices.TypeLibType(4160)]
	[global::System.Runtime.InteropServices.ComImport]
	public interface IHTMLTable2
	{
		// Token: 0x060103C1 RID: 66497
		[global::System.Runtime.InteropServices.DispId(1035)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void firstPage();

		// Token: 0x060103C2 RID: 66498
		[global::System.Runtime.InteropServices.DispId(1036)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void lastPage();

		// Token: 0x17005572 RID: 21874
		// (get) Token: 0x060103C3 RID: 66499
		[global::System.Runtime.InteropServices.DispId(1037)]
		global::mshtml.IHTMLElementCollection cells { [global::System.Runtime.InteropServices.DispId(1037)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x060103C4 RID: 66500
		[global::System.Runtime.InteropServices.DispId(1038)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)]
		object moveRow([global::System.Runtime.InteropServices.In] int indexFrom = -1, [global::System.Runtime.InteropServices.In] int indexTo = -1);
	}
}
