using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x02000CDB RID: 3291
	[global::System.Runtime.InteropServices.ClassInterface(0)]
	[global::System.Runtime.InteropServices.TypeLibType(2)]
	[global::System.Runtime.InteropServices.Guid("3050F6B9-98B5-11CF-BB82-00AA00BDCE0B")]
	[global::System.Reflection.DefaultMember("item")]
	[global::System.Runtime.InteropServices.ComImport]
	public class HTMLNamespaceCollectionClass : global::mshtml.IHTMLNamespaceCollection, global::mshtml.HTMLNamespaceCollection
	{
		// Token: 0x06016351 RID: 90961
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public extern HTMLNamespaceCollectionClass();

		// Token: 0x170075C4 RID: 30148
		// (get) Token: 0x06016352 RID: 90962
		[global::System.Runtime.InteropServices.DispId(1000)]
		public virtual extern int length { [global::System.Runtime.InteropServices.DispId(1000)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x06016353 RID: 90963
		[global::System.Runtime.InteropServices.DispId(0)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)]
		public virtual extern object item([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] object index);

		// Token: 0x06016354 RID: 90964
		[global::System.Runtime.InteropServices.DispId(1001)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)]
		public virtual extern object add([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string bstrNamespace, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string bstrUrn, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] object implementationUrl);
	}
}
