using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ADODB;

namespace CDO
{
	// Token: 0x02000056 RID: 86
	[global::System.Runtime.InteropServices.ClassInterface(0)]
	[global::System.Runtime.InteropServices.TypeLibType(2)]
	[global::System.Runtime.InteropServices.Guid("CD000112-8B95-11D1-82DB-00C04FB1625D")]
	[global::System.Runtime.InteropServices.ComImport]
	public class ItemClass : global::CDO.IItem, global::CDO.Item, global::CDO.IDataSource
	{
		// Token: 0x060000EE RID: 238
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public extern ItemClass();

		// Token: 0x060000EF RID: 239
		[global::System.Runtime.InteropServices.DispId(1)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)]
		public virtual extern object GetInterface([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string Interface);

		// Token: 0x060000F0 RID: 240
		[global::System.Runtime.InteropServices.DispId(2)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::ADODB.Stream GetStream();

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060000F1 RID: 241
		[global::System.Runtime.InteropServices.DispId(3)]
		public virtual extern int ChildCount { [global::System.Runtime.InteropServices.DispId(3)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060000F2 RID: 242
		// (set) Token: 0x060000F4 RID: 244
		[global::System.Runtime.InteropServices.DispId(4)]
		public virtual extern global::CDO.Configuration Configuration { [global::System.Runtime.InteropServices.DispId(4)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; [global::System.Runtime.InteropServices.DispId(4)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060000F5 RID: 245
		// (set) Token: 0x060000F6 RID: 246
		[global::System.Runtime.InteropServices.DispId(5)]
		public virtual extern string ContentClass { [global::System.Runtime.InteropServices.DispId(5)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(5)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060000F7 RID: 247
		[global::System.Runtime.InteropServices.DispId(6)]
		public virtual extern global::System.DateTime CreationDate { [global::System.Runtime.InteropServices.DispId(6)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060000F8 RID: 248
		[global::System.Runtime.InteropServices.DispId(7)]
		public virtual extern global::CDO.IDataSource DataSource { [global::System.Runtime.InteropServices.DispId(7)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060000F9 RID: 249
		[global::System.Runtime.InteropServices.DispId(8)]
		public virtual extern string DisplayName { [global::System.Runtime.InteropServices.DispId(8)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060000FA RID: 250
		[global::System.Runtime.InteropServices.DispId(9)]
		public virtual extern global::ADODB.Fields Fields { [global::System.Runtime.InteropServices.DispId(9)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060000FB RID: 251
		[global::System.Runtime.InteropServices.DispId(10)]
		public virtual extern bool IsCollection { [global::System.Runtime.InteropServices.DispId(10)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060000FC RID: 252
		// (set) Token: 0x060000FD RID: 253
		[global::System.Runtime.InteropServices.DispId(11)]
		public virtual extern bool IsHidden { [global::System.Runtime.InteropServices.DispId(11)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(11)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060000FE RID: 254
		[global::System.Runtime.InteropServices.DispId(12)]
		public virtual extern bool IsStructuredDocument { [global::System.Runtime.InteropServices.DispId(12)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060000FF RID: 255
		[global::System.Runtime.InteropServices.DispId(13)]
		public virtual extern global::System.DateTime LastModified { [global::System.Runtime.InteropServices.DispId(13)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000100 RID: 256
		[global::System.Runtime.InteropServices.DispId(14)]
		public virtual extern int ObjectCount { [global::System.Runtime.InteropServices.DispId(14)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000101 RID: 257
		[global::System.Runtime.InteropServices.DispId(15)]
		public virtual extern string ParentURL { [global::System.Runtime.InteropServices.DispId(15)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000102 RID: 258
		[global::System.Runtime.InteropServices.DispId(16)]
		public virtual extern int VisibleCount { [global::System.Runtime.InteropServices.DispId(16)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000103 RID: 259
		public virtual extern string SourceClass { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000104 RID: 260
		public virtual extern object Source { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IUnknown)] get; }

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000105 RID: 261
		// (set) Token: 0x06000106 RID: 262
		public virtual extern bool IsDirty { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000107 RID: 263
		public virtual extern string SourceURL { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000108 RID: 264
		public virtual extern global::ADODB.Connection ActiveConnection { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x06000109 RID: 265
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void SaveToObject([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IUnknown)] [global::System.Runtime.InteropServices.In] object Source, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string InterfaceName);

		// Token: 0x0600010A RID: 266
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void OpenObject([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IUnknown)] [global::System.Runtime.InteropServices.In] object Source, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string InterfaceName);

		// Token: 0x0600010B RID: 267
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void SaveTo([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string SourceURL, [global::System.Runtime.CompilerServices.IDispatchConstant] [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] object ActiveConnection, [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] global::ADODB.ConnectModeEnum Mode, [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] global::ADODB.RecordCreateOptionsEnum CreateOptions, [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] global::ADODB.RecordOpenOptionsEnum Options, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] string UserName, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] string Password);

		// Token: 0x0600010C RID: 268
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void Open([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string SourceURL, [global::System.Runtime.CompilerServices.IDispatchConstant] [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] object ActiveConnection, [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] global::ADODB.ConnectModeEnum Mode, [global::System.Runtime.InteropServices.In] global::ADODB.RecordCreateOptionsEnum CreateOptions = global::ADODB.RecordCreateOptionsEnum.adFailIfNotExists, [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] global::ADODB.RecordOpenOptionsEnum Options, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] string UserName, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] string Password);

		// Token: 0x0600010D RID: 269
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void Save();

		// Token: 0x0600010E RID: 270
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void SaveToContainer([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string ContainerURL, [global::System.Runtime.CompilerServices.IDispatchConstant] [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] object ActiveConnection, [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] global::ADODB.ConnectModeEnum Mode, [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] global::ADODB.RecordCreateOptionsEnum CreateOptions, [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] global::ADODB.RecordOpenOptionsEnum Options, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] string UserName, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] string Password);
	}
}
