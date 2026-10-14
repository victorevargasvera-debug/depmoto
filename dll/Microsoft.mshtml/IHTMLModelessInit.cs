using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x02000CF3 RID: 3315
	[global::System.Runtime.InteropServices.TypeLibType(4160)]
	[global::System.Runtime.InteropServices.Guid("3050F5E4-98B5-11CF-BB82-00AA00BDCE0B")]
	[global::System.Runtime.InteropServices.ComImport]
	public interface IHTMLModelessInit
	{
		// Token: 0x170075D1 RID: 30161
		// (get) Token: 0x06016382 RID: 91010
		[global::System.Runtime.InteropServices.DispId(25000)]
		object parameters { [global::System.Runtime.InteropServices.DispId(25000)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; }

		// Token: 0x170075D2 RID: 30162
		// (get) Token: 0x06016383 RID: 91011
		[global::System.Runtime.InteropServices.DispId(25001)]
		object optionString { [global::System.Runtime.InteropServices.DispId(25001)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; }

		// Token: 0x170075D3 RID: 30163
		// (get) Token: 0x06016384 RID: 91012
		[global::System.Runtime.InteropServices.DispId(25006)]
		object moniker { [global::System.Runtime.InteropServices.DispId(25006)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IUnknown)] get; }

		// Token: 0x170075D4 RID: 30164
		// (get) Token: 0x06016385 RID: 91013
		[global::System.Runtime.InteropServices.DispId(25007)]
		object document { [global::System.Runtime.InteropServices.DispId(25007)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IUnknown)] get; }
	}
}
