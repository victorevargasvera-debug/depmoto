using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SHDocVw
{
	// Token: 0x02000056 RID: 86
	[global::System.Runtime.InteropServices.Guid("E572D3C9-37BE-4AE2-825D-D521763E3108")]
	[global::System.Runtime.InteropServices.TypeLibType(4176)]
	[global::System.Runtime.InteropServices.ComImport]
	public interface IShellNameSpace : global::SHDocVw.IShellFavoritesNameSpace
	{
		// Token: 0x060004E5 RID: 1253
		[global::System.Runtime.InteropServices.DispId(1)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void MoveSelectionUp();

		// Token: 0x060004E6 RID: 1254
		[global::System.Runtime.InteropServices.DispId(2)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void MoveSelectionDown();

		// Token: 0x060004E7 RID: 1255
		[global::System.Runtime.InteropServices.DispId(3)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void ResetSort();

		// Token: 0x060004E8 RID: 1256
		[global::System.Runtime.InteropServices.DispId(4)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void NewFolder();

		// Token: 0x060004E9 RID: 1257
		[global::System.Runtime.InteropServices.DispId(5)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void Synchronize();

		// Token: 0x060004EA RID: 1258
		[global::System.Runtime.InteropServices.DispId(6)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void Import();

		// Token: 0x060004EB RID: 1259
		[global::System.Runtime.InteropServices.DispId(7)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void Export();

		// Token: 0x060004EC RID: 1260
		[global::System.Runtime.InteropServices.DispId(8)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void InvokeContextMenuCommand([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string strCommand);

		// Token: 0x060004ED RID: 1261
		[global::System.Runtime.InteropServices.DispId(9)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void MoveSelectionTo();

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x060004EE RID: 1262
		[global::System.Runtime.InteropServices.DispId(10)]
		bool SubscriptionsEnabled { [global::System.Runtime.InteropServices.DispId(10)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x060004EF RID: 1263
		[global::System.Runtime.InteropServices.DispId(11)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		bool CreateSubscriptionForSelection();

		// Token: 0x060004F0 RID: 1264
		[global::System.Runtime.InteropServices.DispId(12)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		bool DeleteSubscriptionForSelection();

		// Token: 0x060004F1 RID: 1265
		[global::System.Runtime.InteropServices.DispId(13)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void SetRoot([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string bstrFullPath);

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x060004F2 RID: 1266
		// (set) Token: 0x060004F3 RID: 1267
		[global::System.Runtime.InteropServices.DispId(14)]
		int EnumOptions { [global::System.Runtime.InteropServices.DispId(14)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(14)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x060004F4 RID: 1268
		// (set) Token: 0x060004F5 RID: 1269
		[global::System.Runtime.InteropServices.DispId(15)]
		object SelectedItem { [global::System.Runtime.InteropServices.DispId(15)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; [global::System.Runtime.InteropServices.DispId(15)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x060004F6 RID: 1270
		// (set) Token: 0x060004F7 RID: 1271
		[global::System.Runtime.InteropServices.DispId(16)]
		object Root { [global::System.Runtime.InteropServices.DispId(16)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(16)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x060004F8 RID: 1272
		// (set) Token: 0x060004F9 RID: 1273
		[global::System.Runtime.InteropServices.DispId(17)]
		int Depth { [global::System.Runtime.InteropServices.DispId(17)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(17)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x060004FA RID: 1274
		// (set) Token: 0x060004FB RID: 1275
		[global::System.Runtime.InteropServices.DispId(18)]
		uint Mode { [global::System.Runtime.InteropServices.DispId(18)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(18)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x060004FC RID: 1276
		// (set) Token: 0x060004FD RID: 1277
		[global::System.Runtime.InteropServices.DispId(19)]
		uint Flags { [global::System.Runtime.InteropServices.DispId(19)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(19)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x060004FF RID: 1279
		// (set) Token: 0x060004FE RID: 1278
		[global::System.Runtime.InteropServices.DispId(20)]
		uint TVFlags { [global::System.Runtime.InteropServices.DispId(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x06000500 RID: 1280
		// (set) Token: 0x06000501 RID: 1281
		[global::System.Runtime.InteropServices.DispId(21)]
		string Columns { [global::System.Runtime.InteropServices.DispId(21)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(21)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x06000502 RID: 1282
		[global::System.Runtime.InteropServices.DispId(22)]
		int CountViewTypes { [global::System.Runtime.InteropServices.DispId(22)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000503 RID: 1283
		[global::System.Runtime.InteropServices.DispId(23)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void SetViewType([global::System.Runtime.InteropServices.In] int iType);

		// Token: 0x06000504 RID: 1284
		[global::System.Runtime.InteropServices.DispId(24)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)]
		object SelectedItems();

		// Token: 0x06000505 RID: 1285
		[global::System.Runtime.InteropServices.DispId(25)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void Expand([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] object var, int iDepth);

		// Token: 0x06000506 RID: 1286
		[global::System.Runtime.InteropServices.DispId(26)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void UnselectAll();
	}
}
