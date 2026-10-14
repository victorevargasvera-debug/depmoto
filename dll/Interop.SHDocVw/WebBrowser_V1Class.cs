using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SHDocVw
{
	// Token: 0x0200000D RID: 13
	[global::System.Runtime.InteropServices.ClassInterface(0)]
	[global::System.Runtime.InteropServices.ComSourceInterfaces("SHDocVw.DWebBrowserEvents\0SHDocVw.DWebBrowserEvents2\0\0")]
	[global::System.Runtime.InteropServices.TypeLibType(34)]
	[global::System.Runtime.InteropServices.Guid("EAB22AC3-30C1-11CF-A7EB-0000C05BAE0B")]
	[global::System.Runtime.InteropServices.ComImport]
	public class WebBrowser_V1Class : global::SHDocVw.IWebBrowser, global::SHDocVw.WebBrowser_V1, global::SHDocVw.DWebBrowserEvents_Event, global::SHDocVw.IWebBrowser2, global::SHDocVw.DWebBrowserEvents2_Event
	{
		// Token: 0x060000B8 RID: 184
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public extern WebBrowser_V1Class();

		// Token: 0x060000B9 RID: 185
		[global::System.Runtime.InteropServices.DispId(100)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void GoBack();

		// Token: 0x060000BA RID: 186
		[global::System.Runtime.InteropServices.DispId(101)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void GoForward();

		// Token: 0x060000BB RID: 187
		[global::System.Runtime.InteropServices.DispId(102)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void GoHome();

		// Token: 0x060000BC RID: 188
		[global::System.Runtime.InteropServices.DispId(103)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void GoSearch();

		// Token: 0x060000BD RID: 189
		[global::System.Runtime.InteropServices.DispId(104)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void Navigate([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string URL, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object Flags, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object TargetFrameName, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object PostData, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object Headers);

		// Token: 0x060000BE RID: 190
		[global::System.Runtime.InteropServices.DispId(-550)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void Refresh();

		// Token: 0x060000BF RID: 191
		[global::System.Runtime.InteropServices.DispId(105)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void Refresh2([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object Level);

		// Token: 0x060000C0 RID: 192
		[global::System.Runtime.InteropServices.DispId(106)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void Stop();

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000C1 RID: 193
		[global::System.Runtime.InteropServices.DispId(200)]
		public virtual extern object Application { [global::System.Runtime.InteropServices.DispId(200)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000C2 RID: 194
		[global::System.Runtime.InteropServices.DispId(201)]
		public virtual extern object Parent { [global::System.Runtime.InteropServices.DispId(201)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000C3 RID: 195
		[global::System.Runtime.InteropServices.DispId(202)]
		public virtual extern object Container { [global::System.Runtime.InteropServices.DispId(202)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000C4 RID: 196
		[global::System.Runtime.InteropServices.DispId(203)]
		public virtual extern object Document { [global::System.Runtime.InteropServices.DispId(203)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000C5 RID: 197
		[global::System.Runtime.InteropServices.DispId(204)]
		public virtual extern bool TopLevelContainer { [global::System.Runtime.InteropServices.DispId(204)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000C6 RID: 198
		[global::System.Runtime.InteropServices.DispId(205)]
		public virtual extern string Type { [global::System.Runtime.InteropServices.DispId(205)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000C7 RID: 199
		// (set) Token: 0x060000C8 RID: 200
		[global::System.Runtime.InteropServices.DispId(206)]
		public virtual extern int Left { [global::System.Runtime.InteropServices.DispId(206)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(206)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000C9 RID: 201
		// (set) Token: 0x060000CA RID: 202
		[global::System.Runtime.InteropServices.DispId(207)]
		public virtual extern int Top { [global::System.Runtime.InteropServices.DispId(207)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(207)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000CB RID: 203
		// (set) Token: 0x060000CC RID: 204
		[global::System.Runtime.InteropServices.DispId(208)]
		public virtual extern int Width { [global::System.Runtime.InteropServices.DispId(208)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(208)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060000CD RID: 205
		// (set) Token: 0x060000CE RID: 206
		[global::System.Runtime.InteropServices.DispId(209)]
		public virtual extern int Height { [global::System.Runtime.InteropServices.DispId(209)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(209)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060000CF RID: 207
		[global::System.Runtime.InteropServices.DispId(210)]
		public virtual extern string LocationName { [global::System.Runtime.InteropServices.DispId(210)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060000D0 RID: 208
		[global::System.Runtime.InteropServices.DispId(211)]
		public virtual extern string LocationURL { [global::System.Runtime.InteropServices.DispId(211)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060000D1 RID: 209
		[global::System.Runtime.InteropServices.DispId(212)]
		public virtual extern bool Busy { [global::System.Runtime.InteropServices.DispId(212)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x060000D2 RID: 210
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IWebBrowser2_GoBack();

		// Token: 0x060000D3 RID: 211
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IWebBrowser2_GoForward();

		// Token: 0x060000D4 RID: 212
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IWebBrowser2_GoHome();

		// Token: 0x060000D5 RID: 213
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IWebBrowser2_GoSearch();

		// Token: 0x060000D6 RID: 214
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IWebBrowser2_Navigate([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string URL, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object Flags, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object TargetFrameName, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object PostData, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object Headers);

		// Token: 0x060000D7 RID: 215
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IWebBrowser2_Refresh();

		// Token: 0x060000D8 RID: 216
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IWebBrowser2_Refresh2([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object Level);

		// Token: 0x060000D9 RID: 217
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void IWebBrowser2_Stop();

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060000DA RID: 218
		public virtual extern object IWebBrowser2_Application { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060000DB RID: 219
		public virtual extern object IWebBrowser2_Parent { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060000DC RID: 220
		public virtual extern object IWebBrowser2_Container { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060000DD RID: 221
		public virtual extern object IWebBrowser2_Document { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060000DE RID: 222
		public virtual extern bool IWebBrowser2_TopLevelContainer { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060000DF RID: 223
		public virtual extern string IWebBrowser2_Type { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060000E0 RID: 224
		// (set) Token: 0x060000E1 RID: 225
		public virtual extern int IWebBrowser2_Left { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060000E2 RID: 226
		// (set) Token: 0x060000E3 RID: 227
		public virtual extern int IWebBrowser2_Top { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060000E4 RID: 228
		// (set) Token: 0x060000E5 RID: 229
		public virtual extern int IWebBrowser2_Width { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060000E6 RID: 230
		// (set) Token: 0x060000E7 RID: 231
		public virtual extern int IWebBrowser2_Height { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060000E8 RID: 232
		public virtual extern string IWebBrowser2_LocationName { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060000E9 RID: 233
		public virtual extern string IWebBrowser2_LocationURL { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060000EA RID: 234
		public virtual extern bool IWebBrowser2_Busy { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x060000EB RID: 235
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void Quit();

		// Token: 0x060000EC RID: 236
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void ClientToWindow([global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Out] ref int pcx, [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Out] ref int pcy);

		// Token: 0x060000ED RID: 237
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void PutProperty([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string Property, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] object vtValue);

		// Token: 0x060000EE RID: 238
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)]
		public virtual extern object GetProperty([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string Property);

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060000EF RID: 239
		public virtual extern string Name { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060000F0 RID: 240
		public virtual extern int HWND { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060000F1 RID: 241
		public virtual extern string FullName { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060000F2 RID: 242
		public virtual extern string Path { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060000F3 RID: 243
		// (set) Token: 0x060000F4 RID: 244
		public virtual extern bool Visible { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060000F5 RID: 245
		// (set) Token: 0x060000F6 RID: 246
		public virtual extern bool StatusBar { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060000F7 RID: 247
		// (set) Token: 0x060000F8 RID: 248
		public virtual extern string StatusText { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060000F9 RID: 249
		// (set) Token: 0x060000FA RID: 250
		public virtual extern int ToolBar { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060000FB RID: 251
		// (set) Token: 0x060000FC RID: 252
		public virtual extern bool MenuBar { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060000FD RID: 253
		// (set) Token: 0x060000FE RID: 254
		public virtual extern bool FullScreen { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x060000FF RID: 255
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void Navigate2([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] ref object URL, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object Flags, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object TargetFrameName, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object PostData, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object Headers);

		// Token: 0x06000100 RID: 256
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern global::SHDocVw.OLECMDF QueryStatusWB([global::System.Runtime.InteropServices.In] global::SHDocVw.OLECMDID cmdID);

		// Token: 0x06000101 RID: 257
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void ExecWB([global::System.Runtime.InteropServices.In] global::SHDocVw.OLECMDID cmdID, [global::System.Runtime.InteropServices.In] global::SHDocVw.OLECMDEXECOPT cmdexecopt, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object pvaIn, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Out] [global::System.Runtime.InteropServices.Optional] ref object pvaOut);

		// Token: 0x06000102 RID: 258
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void ShowBrowserBar([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] ref object pvaClsid, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object pvarShow, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object pvarSize);

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000103 RID: 259
		public virtual extern global::SHDocVw.tagREADYSTATE ReadyState { [global::System.Runtime.InteropServices.TypeLibFunc(4)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000104 RID: 260
		// (set) Token: 0x06000105 RID: 261
		public virtual extern bool Offline { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000106 RID: 262
		// (set) Token: 0x06000107 RID: 263
		public virtual extern bool Silent { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000108 RID: 264
		// (set) Token: 0x06000109 RID: 265
		public virtual extern bool RegisterAsBrowser { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600010A RID: 266
		// (set) Token: 0x0600010B RID: 267
		public virtual extern bool RegisterAsDropTarget { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x0600010C RID: 268
		// (set) Token: 0x0600010D RID: 269
		public virtual extern bool TheaterMode { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x0600010E RID: 270
		// (set) Token: 0x0600010F RID: 271
		public virtual extern bool AddressBar { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000110 RID: 272
		// (set) Token: 0x06000111 RID: 273
		public virtual extern bool Resizable { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000112 RID: 274
		// (remove) Token: 0x06000113 RID: 275
		public virtual extern event global::SHDocVw.DWebBrowserEvents_BeforeNavigateEventHandler BeforeNavigate;

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000114 RID: 276
		// (remove) Token: 0x06000115 RID: 277
		public virtual extern event global::SHDocVw.DWebBrowserEvents_NavigateCompleteEventHandler NavigateComplete;

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000116 RID: 278
		// (remove) Token: 0x06000117 RID: 279
		public virtual extern event global::SHDocVw.DWebBrowserEvents_StatusTextChangeEventHandler StatusTextChange;

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06000118 RID: 280
		// (remove) Token: 0x06000119 RID: 281
		public virtual extern event global::SHDocVw.DWebBrowserEvents_ProgressChangeEventHandler ProgressChange;

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x0600011A RID: 282
		// (remove) Token: 0x0600011B RID: 283
		public virtual extern event global::SHDocVw.DWebBrowserEvents_DownloadCompleteEventHandler DownloadComplete;

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x0600011C RID: 284
		// (remove) Token: 0x0600011D RID: 285
		public virtual extern event global::SHDocVw.DWebBrowserEvents_CommandStateChangeEventHandler CommandStateChange;

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x0600011E RID: 286
		// (remove) Token: 0x0600011F RID: 287
		public virtual extern event global::SHDocVw.DWebBrowserEvents_DownloadBeginEventHandler DownloadBegin;

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x06000120 RID: 288
		// (remove) Token: 0x06000121 RID: 289
		public virtual extern event global::SHDocVw.DWebBrowserEvents_NewWindowEventHandler NewWindow;

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x06000122 RID: 290
		// (remove) Token: 0x06000123 RID: 291
		public virtual extern event global::SHDocVw.DWebBrowserEvents_TitleChangeEventHandler TitleChange;

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x06000124 RID: 292
		// (remove) Token: 0x06000125 RID: 293
		public virtual extern event global::SHDocVw.DWebBrowserEvents_FrameBeforeNavigateEventHandler FrameBeforeNavigate;

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x06000126 RID: 294
		// (remove) Token: 0x06000127 RID: 295
		public virtual extern event global::SHDocVw.DWebBrowserEvents_FrameNavigateCompleteEventHandler FrameNavigateComplete;

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x06000128 RID: 296
		// (remove) Token: 0x06000129 RID: 297
		public virtual extern event global::SHDocVw.DWebBrowserEvents_FrameNewWindowEventHandler FrameNewWindow;

		// Token: 0x1400000D RID: 13
		// (add) Token: 0x0600012A RID: 298
		// (remove) Token: 0x0600012B RID: 299
		public virtual extern event global::SHDocVw.DWebBrowserEvents_QuitEventHandler DWebBrowserEvents_Event_Quit;

		// Token: 0x1400000E RID: 14
		// (add) Token: 0x0600012C RID: 300
		// (remove) Token: 0x0600012D RID: 301
		public virtual extern event global::SHDocVw.DWebBrowserEvents_WindowMoveEventHandler WindowMove;

		// Token: 0x1400000F RID: 15
		// (add) Token: 0x0600012E RID: 302
		// (remove) Token: 0x0600012F RID: 303
		public virtual extern event global::SHDocVw.DWebBrowserEvents_WindowResizeEventHandler WindowResize;

		// Token: 0x14000010 RID: 16
		// (add) Token: 0x06000130 RID: 304
		// (remove) Token: 0x06000131 RID: 305
		public virtual extern event global::SHDocVw.DWebBrowserEvents_WindowActivateEventHandler WindowActivate;

		// Token: 0x14000011 RID: 17
		// (add) Token: 0x06000132 RID: 306
		// (remove) Token: 0x06000133 RID: 307
		public virtual extern event global::SHDocVw.DWebBrowserEvents_PropertyChangeEventHandler PropertyChange;

		// Token: 0x14000012 RID: 18
		// (add) Token: 0x06000134 RID: 308
		// (remove) Token: 0x06000135 RID: 309
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_StatusTextChangeEventHandler DWebBrowserEvents2_Event_StatusTextChange;

		// Token: 0x14000013 RID: 19
		// (add) Token: 0x06000136 RID: 310
		// (remove) Token: 0x06000137 RID: 311
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_ProgressChangeEventHandler DWebBrowserEvents2_Event_ProgressChange;

		// Token: 0x14000014 RID: 20
		// (add) Token: 0x06000138 RID: 312
		// (remove) Token: 0x06000139 RID: 313
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_CommandStateChangeEventHandler DWebBrowserEvents2_Event_CommandStateChange;

		// Token: 0x14000015 RID: 21
		// (add) Token: 0x0600013A RID: 314
		// (remove) Token: 0x0600013B RID: 315
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_DownloadBeginEventHandler DWebBrowserEvents2_Event_DownloadBegin;

		// Token: 0x14000016 RID: 22
		// (add) Token: 0x0600013C RID: 316
		// (remove) Token: 0x0600013D RID: 317
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_DownloadCompleteEventHandler DWebBrowserEvents2_Event_DownloadComplete;

		// Token: 0x14000017 RID: 23
		// (add) Token: 0x0600013E RID: 318
		// (remove) Token: 0x0600013F RID: 319
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_TitleChangeEventHandler DWebBrowserEvents2_Event_TitleChange;

		// Token: 0x14000018 RID: 24
		// (add) Token: 0x06000140 RID: 320
		// (remove) Token: 0x06000141 RID: 321
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_PropertyChangeEventHandler DWebBrowserEvents2_Event_PropertyChange;

		// Token: 0x14000019 RID: 25
		// (add) Token: 0x06000142 RID: 322
		// (remove) Token: 0x06000143 RID: 323
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_BeforeNavigate2EventHandler BeforeNavigate2;

		// Token: 0x1400001A RID: 26
		// (add) Token: 0x06000144 RID: 324
		// (remove) Token: 0x06000145 RID: 325
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_NewWindow2EventHandler NewWindow2;

		// Token: 0x1400001B RID: 27
		// (add) Token: 0x06000146 RID: 326
		// (remove) Token: 0x06000147 RID: 327
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_NavigateComplete2EventHandler NavigateComplete2;

		// Token: 0x1400001C RID: 28
		// (add) Token: 0x06000148 RID: 328
		// (remove) Token: 0x06000149 RID: 329
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_DocumentCompleteEventHandler DocumentComplete;

		// Token: 0x1400001D RID: 29
		// (add) Token: 0x0600014A RID: 330
		// (remove) Token: 0x0600014B RID: 331
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_OnQuitEventHandler OnQuit;

		// Token: 0x1400001E RID: 30
		// (add) Token: 0x0600014C RID: 332
		// (remove) Token: 0x0600014D RID: 333
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_OnVisibleEventHandler OnVisible;

		// Token: 0x1400001F RID: 31
		// (add) Token: 0x0600014E RID: 334
		// (remove) Token: 0x0600014F RID: 335
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_OnToolBarEventHandler OnToolBar;

		// Token: 0x14000020 RID: 32
		// (add) Token: 0x06000150 RID: 336
		// (remove) Token: 0x06000151 RID: 337
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_OnMenuBarEventHandler OnMenuBar;

		// Token: 0x14000021 RID: 33
		// (add) Token: 0x06000152 RID: 338
		// (remove) Token: 0x06000153 RID: 339
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_OnStatusBarEventHandler OnStatusBar;

		// Token: 0x14000022 RID: 34
		// (add) Token: 0x06000154 RID: 340
		// (remove) Token: 0x06000155 RID: 341
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_OnFullScreenEventHandler OnFullScreen;

		// Token: 0x14000023 RID: 35
		// (add) Token: 0x06000156 RID: 342
		// (remove) Token: 0x06000157 RID: 343
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_OnTheaterModeEventHandler OnTheaterMode;

		// Token: 0x14000024 RID: 36
		// (add) Token: 0x06000158 RID: 344
		// (remove) Token: 0x06000159 RID: 345
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_WindowSetResizableEventHandler WindowSetResizable;

		// Token: 0x14000025 RID: 37
		// (add) Token: 0x0600015A RID: 346
		// (remove) Token: 0x0600015B RID: 347
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_WindowSetLeftEventHandler WindowSetLeft;

		// Token: 0x14000026 RID: 38
		// (add) Token: 0x0600015C RID: 348
		// (remove) Token: 0x0600015D RID: 349
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_WindowSetTopEventHandler WindowSetTop;

		// Token: 0x14000027 RID: 39
		// (add) Token: 0x0600015E RID: 350
		// (remove) Token: 0x0600015F RID: 351
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_WindowSetWidthEventHandler WindowSetWidth;

		// Token: 0x14000028 RID: 40
		// (add) Token: 0x06000160 RID: 352
		// (remove) Token: 0x06000161 RID: 353
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_WindowSetHeightEventHandler WindowSetHeight;

		// Token: 0x14000029 RID: 41
		// (add) Token: 0x06000162 RID: 354
		// (remove) Token: 0x06000163 RID: 355
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_WindowClosingEventHandler WindowClosing;

		// Token: 0x1400002A RID: 42
		// (add) Token: 0x06000164 RID: 356
		// (remove) Token: 0x06000165 RID: 357
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_ClientToHostWindowEventHandler ClientToHostWindow;

		// Token: 0x1400002B RID: 43
		// (add) Token: 0x06000166 RID: 358
		// (remove) Token: 0x06000167 RID: 359
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_SetSecureLockIconEventHandler SetSecureLockIcon;

		// Token: 0x1400002C RID: 44
		// (add) Token: 0x06000168 RID: 360
		// (remove) Token: 0x06000169 RID: 361
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_FileDownloadEventHandler FileDownload;

		// Token: 0x1400002D RID: 45
		// (add) Token: 0x0600016A RID: 362
		// (remove) Token: 0x0600016B RID: 363
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_NavigateErrorEventHandler NavigateError;

		// Token: 0x1400002E RID: 46
		// (add) Token: 0x0600016C RID: 364
		// (remove) Token: 0x0600016D RID: 365
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_PrintTemplateInstantiationEventHandler PrintTemplateInstantiation;

		// Token: 0x1400002F RID: 47
		// (add) Token: 0x0600016E RID: 366
		// (remove) Token: 0x0600016F RID: 367
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_PrintTemplateTeardownEventHandler PrintTemplateTeardown;

		// Token: 0x14000030 RID: 48
		// (add) Token: 0x06000170 RID: 368
		// (remove) Token: 0x06000171 RID: 369
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_UpdatePageStatusEventHandler UpdatePageStatus;

		// Token: 0x14000031 RID: 49
		// (add) Token: 0x06000172 RID: 370
		// (remove) Token: 0x06000173 RID: 371
		public virtual extern event global::SHDocVw.DWebBrowserEvents2_PrivacyImpactedStateChangeEventHandler PrivacyImpactedStateChange;
	}
}
