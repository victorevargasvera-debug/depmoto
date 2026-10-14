using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x0200013E RID: 318
	[global::System.Reflection.DefaultMember("item")]
	[global::System.Runtime.InteropServices.ClassInterface(0)]
	[global::System.Runtime.InteropServices.Guid("3050F3CD-98B5-11CF-BB82-00AA00BDCE0B")]
	[global::System.Runtime.InteropServices.TypeLibType(2)]
	[global::System.Runtime.InteropServices.ComImport]
	public class HTMLStyleSheetRulesCollectionClass : global::mshtml.IHTMLStyleSheetRulesCollection, global::mshtml.HTMLStyleSheetRulesCollection
	{
		// Token: 0x060013C0 RID: 5056
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public extern HTMLStyleSheetRulesCollectionClass();

		// Token: 0x170008DC RID: 2268
		// (get) Token: 0x060013C1 RID: 5057
		[global::System.Runtime.InteropServices.DispId(1001)]
		public virtual extern int length { [global::System.Runtime.InteropServices.DispId(1001)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x060013C2 RID: 5058
		[global::System.Runtime.InteropServices.DispId(0)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.HTMLStyleSheetRule item([global::System.Runtime.InteropServices.In] int index);
	}
}
