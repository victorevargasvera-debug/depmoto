using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x02000838 RID: 2104
	[global::System.Runtime.InteropServices.Guid("A5170870-0CF8-11D1-8B91-0080C744F389")]
	[global::System.Runtime.InteropServices.TypeLibType(4160)]
	[global::System.Runtime.InteropServices.ComImport]
	public interface IWBScriptControl
	{
		// Token: 0x0600DEEE RID: 57070
		[global::System.Runtime.InteropServices.DispId(1)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void raiseEvent([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string name, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] object eventData);

		// Token: 0x0600DEEF RID: 57071
		[global::System.Runtime.InteropServices.DispId(2)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void bubbleEvent();

		// Token: 0x0600DEF0 RID: 57072
		[global::System.Runtime.InteropServices.DispId(3)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void setContextMenu([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] object menuItemPairs);

		// Token: 0x17004A09 RID: 18953
		// (get) Token: 0x0600DEF2 RID: 57074
		// (set) Token: 0x0600DEF1 RID: 57073
		[global::System.Runtime.InteropServices.DispId(4)]
		bool selectableContent { [global::System.Runtime.InteropServices.DispId(4)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(4)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17004A0A RID: 18954
		// (get) Token: 0x0600DEF3 RID: 57075
		[global::System.Runtime.InteropServices.DispId(5)]
		bool frozen { [global::System.Runtime.InteropServices.DispId(5)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17004A0B RID: 18955
		// (get) Token: 0x0600DEF5 RID: 57077
		// (set) Token: 0x0600DEF4 RID: 57076
		[global::System.Runtime.InteropServices.DispId(7)]
		bool Scrollbar { [global::System.Runtime.InteropServices.DispId(7)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(7)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17004A0C RID: 18956
		// (get) Token: 0x0600DEF6 RID: 57078
		[global::System.Runtime.InteropServices.DispId(8)]
		string version { [global::System.Runtime.InteropServices.DispId(8)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x17004A0D RID: 18957
		// (get) Token: 0x0600DEF7 RID: 57079
		[global::System.Runtime.InteropServices.DispId(9)]
		bool visibility { [global::System.Runtime.InteropServices.DispId(9)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17004A0E RID: 18958
		// (get) Token: 0x0600DEF9 RID: 57081
		// (set) Token: 0x0600DEF8 RID: 57080
		[global::System.Runtime.InteropServices.DispId(10)]
		object onvisibilitychange { [global::System.Runtime.InteropServices.DispId(10)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(10)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }
	}
}
