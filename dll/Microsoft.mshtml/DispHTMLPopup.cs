using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x02000CF9 RID: 3321
	[global::System.Runtime.InteropServices.InterfaceType(2)]
	[global::System.Runtime.InteropServices.Guid("3050F589-98B5-11CF-BB82-00AA00BDCE0B")]
	[global::System.Runtime.InteropServices.TypeLibType(4112)]
	[global::System.Runtime.InteropServices.ComImport]
	public interface DispHTMLPopup
	{
		// Token: 0x0601639E RID: 91038
		[global::System.Runtime.InteropServices.DispId(27001)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void Show([global::System.Runtime.InteropServices.In] int x, [global::System.Runtime.InteropServices.In] int y, [global::System.Runtime.InteropServices.In] int w, [global::System.Runtime.InteropServices.In] int h, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] ref object pElement);

		// Token: 0x0601639F RID: 91039
		[global::System.Runtime.InteropServices.DispId(27002)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void Hide();

		// Token: 0x170075E2 RID: 30178
		// (get) Token: 0x060163A0 RID: 91040
		[global::System.Runtime.InteropServices.DispId(27003)]
		global::mshtml.IHTMLDocument document { [global::System.Runtime.InteropServices.DispId(27003)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x170075E3 RID: 30179
		// (get) Token: 0x060163A1 RID: 91041
		[global::System.Runtime.InteropServices.DispId(27004)]
		bool isOpen { [global::System.Runtime.InteropServices.DispId(27004)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }
	}
}
