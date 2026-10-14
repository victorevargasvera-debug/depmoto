using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x020007BF RID: 1983
	[global::System.Runtime.InteropServices.ClassInterface(0)]
	[global::System.Runtime.InteropServices.Guid("3050F35D-98B5-11CF-BB82-00AA00BDCE0B")]
	[global::System.Runtime.InteropServices.TypeLibType(2)]
	[global::System.Runtime.InteropServices.ComImport]
	public class HTMLScreenClass : global::mshtml.DispHTMLScreen, global::mshtml.HTMLScreen, global::mshtml.IHTMLScreen, global::mshtml.IHTMLScreen2
	{
		// Token: 0x0600D755 RID: 55125
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public extern HTMLScreenClass();

		// Token: 0x170047B1 RID: 18353
		// (get) Token: 0x0600D756 RID: 55126
		[global::System.Runtime.InteropServices.DispId(1001)]
		public virtual extern int colorDepth { [global::System.Runtime.InteropServices.DispId(1001)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170047B2 RID: 18354
		// (get) Token: 0x0600D758 RID: 55128
		// (set) Token: 0x0600D757 RID: 55127
		[global::System.Runtime.InteropServices.DispId(1002)]
		public virtual extern int bufferDepth { [global::System.Runtime.InteropServices.DispId(1002)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(1002)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] set; }

		// Token: 0x170047B3 RID: 18355
		// (get) Token: 0x0600D759 RID: 55129
		[global::System.Runtime.InteropServices.DispId(1003)]
		public virtual extern int width { [global::System.Runtime.InteropServices.DispId(1003)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170047B4 RID: 18356
		// (get) Token: 0x0600D75A RID: 55130
		[global::System.Runtime.InteropServices.DispId(1004)]
		public virtual extern int height { [global::System.Runtime.InteropServices.DispId(1004)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170047B5 RID: 18357
		// (get) Token: 0x0600D75C RID: 55132
		// (set) Token: 0x0600D75B RID: 55131
		[global::System.Runtime.InteropServices.DispId(1005)]
		public virtual extern int updateInterval { [global::System.Runtime.InteropServices.DispId(1005)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(1005)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] set; }

		// Token: 0x170047B6 RID: 18358
		// (get) Token: 0x0600D75D RID: 55133
		[global::System.Runtime.InteropServices.DispId(1006)]
		public virtual extern int availHeight { [global::System.Runtime.InteropServices.DispId(1006)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170047B7 RID: 18359
		// (get) Token: 0x0600D75E RID: 55134
		[global::System.Runtime.InteropServices.DispId(1007)]
		public virtual extern int availWidth { [global::System.Runtime.InteropServices.DispId(1007)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170047B8 RID: 18360
		// (get) Token: 0x0600D75F RID: 55135
		[global::System.Runtime.InteropServices.DispId(1008)]
		public virtual extern bool fontSmoothingEnabled { [global::System.Runtime.InteropServices.DispId(1008)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170047B9 RID: 18361
		// (get) Token: 0x0600D760 RID: 55136
		[global::System.Runtime.InteropServices.DispId(1009)]
		public virtual extern int logicalXDPI { [global::System.Runtime.InteropServices.DispId(1009)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170047BA RID: 18362
		// (get) Token: 0x0600D761 RID: 55137
		[global::System.Runtime.InteropServices.DispId(1010)]
		public virtual extern int logicalYDPI { [global::System.Runtime.InteropServices.DispId(1010)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170047BB RID: 18363
		// (get) Token: 0x0600D762 RID: 55138
		[global::System.Runtime.InteropServices.DispId(1011)]
		public virtual extern int deviceXDPI { [global::System.Runtime.InteropServices.DispId(1011)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170047BC RID: 18364
		// (get) Token: 0x0600D763 RID: 55139
		[global::System.Runtime.InteropServices.DispId(1012)]
		public virtual extern int deviceYDPI { [global::System.Runtime.InteropServices.DispId(1012)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170047BD RID: 18365
		// (get) Token: 0x0600D764 RID: 55140
		public virtual extern int IHTMLScreen_colorDepth { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170047BE RID: 18366
		// (get) Token: 0x0600D766 RID: 55142
		// (set) Token: 0x0600D765 RID: 55141
		public virtual extern int IHTMLScreen_bufferDepth { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170047BF RID: 18367
		// (get) Token: 0x0600D767 RID: 55143
		public virtual extern int IHTMLScreen_width { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170047C0 RID: 18368
		// (get) Token: 0x0600D768 RID: 55144
		public virtual extern int IHTMLScreen_height { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170047C1 RID: 18369
		// (get) Token: 0x0600D76A RID: 55146
		// (set) Token: 0x0600D769 RID: 55145
		public virtual extern int IHTMLScreen_updateInterval { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170047C2 RID: 18370
		// (get) Token: 0x0600D76B RID: 55147
		public virtual extern int IHTMLScreen_availHeight { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170047C3 RID: 18371
		// (get) Token: 0x0600D76C RID: 55148
		public virtual extern int IHTMLScreen_availWidth { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170047C4 RID: 18372
		// (get) Token: 0x0600D76D RID: 55149
		public virtual extern bool IHTMLScreen_fontSmoothingEnabled { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170047C5 RID: 18373
		// (get) Token: 0x0600D76E RID: 55150
		public virtual extern int IHTMLScreen2_logicalXDPI { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170047C6 RID: 18374
		// (get) Token: 0x0600D76F RID: 55151
		public virtual extern int IHTMLScreen2_logicalYDPI { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170047C7 RID: 18375
		// (get) Token: 0x0600D770 RID: 55152
		public virtual extern int IHTMLScreen2_deviceXDPI { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170047C8 RID: 18376
		// (get) Token: 0x0600D771 RID: 55153
		public virtual extern int IHTMLScreen2_deviceYDPI { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }
	}
}
