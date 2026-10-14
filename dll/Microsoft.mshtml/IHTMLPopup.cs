using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x02000CF8 RID: 3320
	[global::System.Runtime.InteropServices.Guid("3050F666-98B5-11CF-BB82-00AA00BDCE0B")]
	[global::System.Runtime.InteropServices.TypeLibType(4160)]
	[global::System.Runtime.InteropServices.ComImport]
	public interface IHTMLPopup
	{
		// Token: 0x0601639A RID: 91034
		[global::System.Runtime.InteropServices.DispId(27001)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void Show([global::System.Runtime.InteropServices.In] int x, [global::System.Runtime.InteropServices.In] int y, [global::System.Runtime.InteropServices.In] int w, [global::System.Runtime.InteropServices.In] int h, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] ref object pElement);

		// Token: 0x0601639B RID: 91035
		[global::System.Runtime.InteropServices.DispId(27002)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void Hide();

		// Token: 0x170075E0 RID: 30176
		// (get) Token: 0x0601639C RID: 91036
		[global::System.Runtime.InteropServices.DispId(27003)]
		global::mshtml.IHTMLDocument document { [global::System.Runtime.InteropServices.DispId(27003)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x170075E1 RID: 30177
		// (get) Token: 0x0601639D RID: 91037
		[global::System.Runtime.InteropServices.DispId(27004)]
		bool isOpen { [global::System.Runtime.InteropServices.DispId(27004)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }
	}
}
