using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ADODB;

namespace CDO
{
	// Token: 0x02000058 RID: 88
	[global::System.Runtime.InteropServices.Guid("CD000126-8B95-11D1-82DB-00C04FB1625D")]
	[global::System.Runtime.InteropServices.TypeLibType(4288)]
	[global::System.Runtime.InteropServices.ComImport]
	public interface IItem
	{
		// Token: 0x0600010F RID: 271
		[global::System.Runtime.InteropServices.DispId(1)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)]
		object GetInterface([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string Interface);

		// Token: 0x06000110 RID: 272
		[global::System.Runtime.InteropServices.DispId(2)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		global::ADODB.Stream GetStream();

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000111 RID: 273
		[global::System.Runtime.InteropServices.DispId(3)]
		int ChildCount { [global::System.Runtime.InteropServices.DispId(3)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000112 RID: 274
		// (set) Token: 0x06000114 RID: 276
		[global::System.Runtime.InteropServices.DispId(4)]
		global::CDO.Configuration Configuration { [global::System.Runtime.InteropServices.DispId(4)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; [global::System.Runtime.InteropServices.DispId(4)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000115 RID: 277
		// (set) Token: 0x06000116 RID: 278
		[global::System.Runtime.InteropServices.DispId(5)]
		string ContentClass { [global::System.Runtime.InteropServices.DispId(5)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(5)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000117 RID: 279
		[global::System.Runtime.InteropServices.DispId(6)]
		global::System.DateTime CreationDate { [global::System.Runtime.InteropServices.DispId(6)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000118 RID: 280
		[global::System.Runtime.InteropServices.DispId(7)]
		global::CDO.IDataSource DataSource { [global::System.Runtime.InteropServices.DispId(7)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000119 RID: 281
		[global::System.Runtime.InteropServices.DispId(8)]
		string DisplayName { [global::System.Runtime.InteropServices.DispId(8)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x0600011A RID: 282
		[global::System.Runtime.InteropServices.DispId(9)]
		global::ADODB.Fields Fields { [global::System.Runtime.InteropServices.DispId(9)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x0600011B RID: 283
		[global::System.Runtime.InteropServices.DispId(10)]
		bool IsCollection { [global::System.Runtime.InteropServices.DispId(10)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x0600011C RID: 284
		// (set) Token: 0x0600011D RID: 285
		[global::System.Runtime.InteropServices.DispId(11)]
		bool IsHidden { [global::System.Runtime.InteropServices.DispId(11)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(11)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x0600011E RID: 286
		[global::System.Runtime.InteropServices.DispId(12)]
		bool IsStructuredDocument { [global::System.Runtime.InteropServices.DispId(12)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x0600011F RID: 287
		[global::System.Runtime.InteropServices.DispId(13)]
		global::System.DateTime LastModified { [global::System.Runtime.InteropServices.DispId(13)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000120 RID: 288
		[global::System.Runtime.InteropServices.DispId(14)]
		int ObjectCount { [global::System.Runtime.InteropServices.DispId(14)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000121 RID: 289
		[global::System.Runtime.InteropServices.DispId(15)]
		string ParentURL { [global::System.Runtime.InteropServices.DispId(15)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000122 RID: 290
		[global::System.Runtime.InteropServices.DispId(16)]
		int VisibleCount { [global::System.Runtime.InteropServices.DispId(16)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }
	}
}
