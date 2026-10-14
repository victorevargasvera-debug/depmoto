using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x02000CFA RID: 3322
	[global::System.Runtime.InteropServices.ClassInterface(0)]
	[global::System.Runtime.InteropServices.Guid("3050F667-98B5-11CF-BB82-00AA00BDCE0B")]
	[global::System.Runtime.InteropServices.TypeLibType(2)]
	[global::System.Runtime.InteropServices.ComImport]
	public class HTMLPopupClass : global::mshtml.DispHTMLPopup, global::mshtml.HTMLPopup, global::mshtml.IHTMLPopup
	{
		// Token: 0x060163A2 RID: 91042
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public extern HTMLPopupClass();

		// Token: 0x060163A3 RID: 91043
		[global::System.Runtime.InteropServices.DispId(27001)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void Show([global::System.Runtime.InteropServices.In] int x, [global::System.Runtime.InteropServices.In] int y, [global::System.Runtime.InteropServices.In] int w, [global::System.Runtime.InteropServices.In] int h, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] ref object pElement);

		// Token: 0x060163A4 RID: 91044
		[global::System.Runtime.InteropServices.DispId(27002)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void Hide();

		// Token: 0x170075E4 RID: 30180
		// (get) Token: 0x060163A5 RID: 91045
		[global::System.Runtime.InteropServices.DispId(27003)]
		public virtual extern global::mshtml.IHTMLDocument document { [global::System.Runtime.InteropServices.DispId(27003)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x170075E5 RID: 30181
		// (get) Token: 0x060163A6 RID: 91046
		[global::System.Runtime.InteropServices.DispId(27004)]
		public virtual extern bool isOpen { [global::System.Runtime.InteropServices.DispId(27004)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x060163A7 RID: 91047
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IHTMLPopup_Show([global::System.Runtime.InteropServices.In] int x, [global::System.Runtime.InteropServices.In] int y, [global::System.Runtime.InteropServices.In] int w, [global::System.Runtime.InteropServices.In] int h, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] ref object pElement);

		// Token: 0x060163A8 RID: 91048
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IHTMLPopup_Hide();

		// Token: 0x170075E6 RID: 30182
		// (get) Token: 0x060163A9 RID: 91049
		public virtual extern global::mshtml.IHTMLDocument IHTMLPopup_document { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x170075E7 RID: 30183
		// (get) Token: 0x060163AA RID: 91050
		public virtual extern bool IHTMLPopup_isOpen { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }
	}
}
