using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x02000839 RID: 2105
	[global::System.Runtime.InteropServices.ClassInterface(0)]
	[global::System.Runtime.InteropServices.ComSourceInterfaces("mshtml.DWebBridgeEvents\0\0")]
	[global::System.Runtime.InteropServices.Guid("AE24FDAE-03C6-11D1-8B76-0080C744F389")]
	[global::System.Runtime.InteropServices.TypeLibType(34)]
	[global::System.Runtime.InteropServices.ComImport]
	public class ScriptletClass : global::mshtml.IWebBridge, global::mshtml.Scriptlet, global::mshtml.DWebBridgeEvents_Event
	{
		// Token: 0x0600DEFA RID: 57082
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public extern ScriptletClass();

		// Token: 0x17004A0F RID: 18959
		// (get) Token: 0x0600DEFC RID: 57084
		// (set) Token: 0x0600DEFB RID: 57083
		[global::System.Runtime.InteropServices.DispId(1)]
		public virtual extern string url { [global::System.Runtime.InteropServices.DispId(1)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(1)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17004A10 RID: 18960
		// (get) Token: 0x0600DEFE RID: 57086
		// (set) Token: 0x0600DEFD RID: 57085
		[global::System.Runtime.InteropServices.DispId(2)]
		public virtual extern bool Scrollbar { [global::System.Runtime.InteropServices.DispId(2)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(2)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17004A11 RID: 18961
		// (get) Token: 0x0600DF00 RID: 57088
		// (set) Token: 0x0600DEFF RID: 57087
		[global::System.Runtime.InteropServices.DispId(3)]
		public virtual extern bool embed { [global::System.Runtime.InteropServices.DispId(3)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(3)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17004A12 RID: 18962
		// (get) Token: 0x0600DF01 RID: 57089
		[global::System.Runtime.InteropServices.DispId(1152)]
		public virtual extern object @event { [global::System.Runtime.InteropServices.DispId(1152)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x17004A13 RID: 18963
		// (get) Token: 0x0600DF02 RID: 57090
		[global::System.Runtime.InteropServices.DispId(-525)]
		public virtual extern int readyState { [global::System.Runtime.InteropServices.DispId(-525)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x0600DF03 RID: 57091
		[global::System.Runtime.InteropServices.DispId(-552)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void AboutBox();

		// Token: 0x14001AF5 RID: 6901
		// (add) Token: 0x0600DF04 RID: 57092
		// (remove) Token: 0x0600DF05 RID: 57093
		public virtual extern event global::mshtml.DWebBridgeEvents_onscriptleteventEventHandler onscriptletevent;

		// Token: 0x14001AF6 RID: 6902
		// (add) Token: 0x0600DF06 RID: 57094
		// (remove) Token: 0x0600DF07 RID: 57095
		public virtual extern event global::mshtml.DWebBridgeEvents_onreadystatechangeEventHandler onreadystatechange;

		// Token: 0x14001AF7 RID: 6903
		// (add) Token: 0x0600DF08 RID: 57096
		// (remove) Token: 0x0600DF09 RID: 57097
		public virtual extern event global::mshtml.DWebBridgeEvents_onclickEventHandler onclick;

		// Token: 0x14001AF8 RID: 6904
		// (add) Token: 0x0600DF0A RID: 57098
		// (remove) Token: 0x0600DF0B RID: 57099
		public virtual extern event global::mshtml.DWebBridgeEvents_ondblclickEventHandler ondblclick;

		// Token: 0x14001AF9 RID: 6905
		// (add) Token: 0x0600DF0C RID: 57100
		// (remove) Token: 0x0600DF0D RID: 57101
		public virtual extern event global::mshtml.DWebBridgeEvents_onkeydownEventHandler onkeydown;

		// Token: 0x14001AFA RID: 6906
		// (add) Token: 0x0600DF0E RID: 57102
		// (remove) Token: 0x0600DF0F RID: 57103
		public virtual extern event global::mshtml.DWebBridgeEvents_onkeyupEventHandler onkeyup;

		// Token: 0x14001AFB RID: 6907
		// (add) Token: 0x0600DF10 RID: 57104
		// (remove) Token: 0x0600DF11 RID: 57105
		public virtual extern event global::mshtml.DWebBridgeEvents_onkeypressEventHandler onkeypress;

		// Token: 0x14001AFC RID: 6908
		// (add) Token: 0x0600DF12 RID: 57106
		// (remove) Token: 0x0600DF13 RID: 57107
		public virtual extern event global::mshtml.DWebBridgeEvents_onmousedownEventHandler onmousedown;

		// Token: 0x14001AFD RID: 6909
		// (add) Token: 0x0600DF14 RID: 57108
		// (remove) Token: 0x0600DF15 RID: 57109
		public virtual extern event global::mshtml.DWebBridgeEvents_onmousemoveEventHandler onmousemove;

		// Token: 0x14001AFE RID: 6910
		// (add) Token: 0x0600DF16 RID: 57110
		// (remove) Token: 0x0600DF17 RID: 57111
		public virtual extern event global::mshtml.DWebBridgeEvents_onmouseupEventHandler onmouseup;
	}
}
