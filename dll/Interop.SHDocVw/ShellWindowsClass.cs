using System;
using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SHDocVw
{
	// Token: 0x0200004C RID: 76
	[global::System.Runtime.InteropServices.Guid("9BA05972-F6A8-11CF-A442-00A0C90A8F39")]
	[global::System.Reflection.DefaultMember("Item")]
	[global::System.Runtime.InteropServices.ComSourceInterfaces("SHDocVw.DShellWindowsEvents\0\0")]
	[global::System.Runtime.InteropServices.TypeLibType(2)]
	[global::System.Runtime.InteropServices.ClassInterface(0)]
	[global::System.Runtime.InteropServices.ComImport]
	public class ShellWindowsClass : global::SHDocVw.IShellWindows, global::SHDocVw.ShellWindows, global::SHDocVw.DShellWindowsEvents_Event, global::System.Collections.IEnumerable
	{
		// Token: 0x060004A1 RID: 1185
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public extern ShellWindowsClass();

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x060004A2 RID: 1186
		[global::System.Runtime.InteropServices.DispId(1610743808)]
		public virtual extern int Count { [global::System.Runtime.InteropServices.DispId(1610743808)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x060004A3 RID: 1187
		[global::System.Runtime.InteropServices.DispId(0)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)]
		public virtual extern object Item([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] object index);

		// Token: 0x060004A4 RID: 1188
		[global::System.Runtime.InteropServices.DispId(-4)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.CustomMarshaler, MarshalTypeRef = System.Runtime.InteropServices.CustomMarshalers.EnumeratorToEnumVariantMarshaler)]
		public virtual extern global::System.Collections.IEnumerator GetEnumerator();

		// Token: 0x060004A5 RID: 1189
		[global::System.Runtime.InteropServices.TypeLibFunc(64)]
		[global::System.Runtime.InteropServices.DispId(1610743811)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void Register([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] [global::System.Runtime.InteropServices.In] object pid, [global::System.Runtime.InteropServices.In] int HWND, [global::System.Runtime.InteropServices.In] int swClass, out int plCookie);

		// Token: 0x060004A6 RID: 1190
		[global::System.Runtime.InteropServices.TypeLibFunc(64)]
		[global::System.Runtime.InteropServices.DispId(1610743812)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void RegisterPending([global::System.Runtime.InteropServices.In] int lThreadId, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] ref object pvarloc, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] ref object pvarlocRoot, [global::System.Runtime.InteropServices.In] int swClass, out int plCookie);

		// Token: 0x060004A7 RID: 1191
		[global::System.Runtime.InteropServices.DispId(1610743813)]
		[global::System.Runtime.InteropServices.TypeLibFunc(64)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void Revoke([global::System.Runtime.InteropServices.In] int lCookie);

		// Token: 0x060004A8 RID: 1192
		[global::System.Runtime.InteropServices.DispId(1610743814)]
		[global::System.Runtime.InteropServices.TypeLibFunc(64)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void OnNavigate([global::System.Runtime.InteropServices.In] int lCookie, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] ref object pvarloc);

		// Token: 0x060004A9 RID: 1193
		[global::System.Runtime.InteropServices.DispId(1610743815)]
		[global::System.Runtime.InteropServices.TypeLibFunc(64)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void OnActivated([global::System.Runtime.InteropServices.In] int lCookie, [global::System.Runtime.InteropServices.In] bool fActive);

		// Token: 0x060004AA RID: 1194
		[global::System.Runtime.InteropServices.TypeLibFunc(64)]
		[global::System.Runtime.InteropServices.DispId(1610743816)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)]
		public virtual extern object FindWindowSW([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] ref object pvarloc, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] ref object pvarlocRoot, [global::System.Runtime.InteropServices.In] int swClass, out int pHWND, [global::System.Runtime.InteropServices.In] int swfwOptions);

		// Token: 0x060004AB RID: 1195
		[global::System.Runtime.InteropServices.DispId(1610743817)]
		[global::System.Runtime.InteropServices.TypeLibFunc(64)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void OnCreated([global::System.Runtime.InteropServices.In] int lCookie, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IUnknown)] [global::System.Runtime.InteropServices.In] object punk);

		// Token: 0x060004AC RID: 1196
		[global::System.Runtime.InteropServices.TypeLibFunc(64)]
		[global::System.Runtime.InteropServices.DispId(1610743818)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void ProcessAttachDetach([global::System.Runtime.InteropServices.In] bool fAttach);

		// Token: 0x140000F6 RID: 246
		// (add) Token: 0x060004AD RID: 1197
		// (remove) Token: 0x060004AE RID: 1198
		public virtual extern event global::SHDocVw.DShellWindowsEvents_WindowRegisteredEventHandler WindowRegistered;

		// Token: 0x140000F7 RID: 247
		// (add) Token: 0x060004AF RID: 1199
		// (remove) Token: 0x060004B0 RID: 1200
		public virtual extern event global::SHDocVw.DShellWindowsEvents_WindowRevokedEventHandler WindowRevoked;
	}
}
