using System;
using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SHDocVw
{
	// Token: 0x0200004B RID: 75
	[global::System.Runtime.InteropServices.TypeLibType(4160)]
	[global::System.Reflection.DefaultMember("Item")]
	[global::System.Runtime.InteropServices.Guid("85CB6900-4D95-11CF-960C-0080C7F4EE85")]
	[global::System.Runtime.InteropServices.ComImport]
	public interface IShellWindows : global::System.Collections.IEnumerable
	{
		// Token: 0x17000108 RID: 264
		// (get) Token: 0x06000496 RID: 1174
		[global::System.Runtime.InteropServices.DispId(1610743808)]
		int Count { [global::System.Runtime.InteropServices.DispId(1610743808)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000497 RID: 1175
		[global::System.Runtime.InteropServices.DispId(0)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)]
		object Item([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] object index);

		// Token: 0x06000498 RID: 1176
		[global::System.Runtime.InteropServices.DispId(-4)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.CustomMarshaler, MarshalTypeRef = System.Runtime.InteropServices.CustomMarshalers.EnumeratorToEnumVariantMarshaler)]
		global::System.Collections.IEnumerator GetEnumerator();

		// Token: 0x06000499 RID: 1177
		[global::System.Runtime.InteropServices.DispId(1610743811)]
		[global::System.Runtime.InteropServices.TypeLibFunc(64)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void Register([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] [global::System.Runtime.InteropServices.In] object pid, [global::System.Runtime.InteropServices.In] int HWND, [global::System.Runtime.InteropServices.In] int swClass, out int plCookie);

		// Token: 0x0600049A RID: 1178
		[global::System.Runtime.InteropServices.TypeLibFunc(64)]
		[global::System.Runtime.InteropServices.DispId(1610743812)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void RegisterPending([global::System.Runtime.InteropServices.In] int lThreadId, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] ref object pvarloc, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] ref object pvarlocRoot, [global::System.Runtime.InteropServices.In] int swClass, out int plCookie);

		// Token: 0x0600049B RID: 1179
		[global::System.Runtime.InteropServices.TypeLibFunc(64)]
		[global::System.Runtime.InteropServices.DispId(1610743813)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void Revoke([global::System.Runtime.InteropServices.In] int lCookie);

		// Token: 0x0600049C RID: 1180
		[global::System.Runtime.InteropServices.TypeLibFunc(64)]
		[global::System.Runtime.InteropServices.DispId(1610743814)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void OnNavigate([global::System.Runtime.InteropServices.In] int lCookie, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] ref object pvarloc);

		// Token: 0x0600049D RID: 1181
		[global::System.Runtime.InteropServices.TypeLibFunc(64)]
		[global::System.Runtime.InteropServices.DispId(1610743815)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void OnActivated([global::System.Runtime.InteropServices.In] int lCookie, [global::System.Runtime.InteropServices.In] bool fActive);

		// Token: 0x0600049E RID: 1182
		[global::System.Runtime.InteropServices.TypeLibFunc(64)]
		[global::System.Runtime.InteropServices.DispId(1610743816)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)]
		object FindWindowSW([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] ref object pvarloc, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] ref object pvarlocRoot, [global::System.Runtime.InteropServices.In] int swClass, out int pHWND, [global::System.Runtime.InteropServices.In] int swfwOptions);

		// Token: 0x0600049F RID: 1183
		[global::System.Runtime.InteropServices.DispId(1610743817)]
		[global::System.Runtime.InteropServices.TypeLibFunc(64)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void OnCreated([global::System.Runtime.InteropServices.In] int lCookie, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IUnknown)] [global::System.Runtime.InteropServices.In] object punk);

		// Token: 0x060004A0 RID: 1184
		[global::System.Runtime.InteropServices.DispId(1610743818)]
		[global::System.Runtime.InteropServices.TypeLibFunc(64)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void ProcessAttachDetach([global::System.Runtime.InteropServices.In] bool fAttach);
	}
}
