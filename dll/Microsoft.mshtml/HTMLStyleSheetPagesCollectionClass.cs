using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x02000144 RID: 324
	[global::System.Runtime.InteropServices.Guid("3050F7F1-98B5-11CF-BB82-00AA00BDCE0B")]
	[global::System.Runtime.InteropServices.ClassInterface(0)]
	[global::System.Reflection.DefaultMember("item")]
	[global::System.Runtime.InteropServices.TypeLibType(2)]
	[global::System.Runtime.InteropServices.ComImport]
	public class HTMLStyleSheetPagesCollectionClass : global::mshtml.IHTMLStyleSheetPagesCollection, global::mshtml.HTMLStyleSheetPagesCollection
	{
		// Token: 0x060013CA RID: 5066
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public extern HTMLStyleSheetPagesCollectionClass();

		// Token: 0x170008E2 RID: 2274
		// (get) Token: 0x060013CB RID: 5067
		[global::System.Runtime.InteropServices.DispId(1001)]
		public virtual extern int length { [global::System.Runtime.InteropServices.DispId(1001)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x060013CC RID: 5068
		[global::System.Runtime.InteropServices.DispId(0)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.HTMLStyleSheetPage item([global::System.Runtime.InteropServices.In] int index);
	}
}
