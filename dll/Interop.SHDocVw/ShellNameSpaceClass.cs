using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SHDocVw
{
	// Token: 0x02000057 RID: 87
	[global::System.Runtime.InteropServices.ComSourceInterfaces("SHDocVw.DShellNameSpaceEvents\0\0")]
	[global::System.Runtime.InteropServices.TypeLibType(2)]
	[global::System.Runtime.InteropServices.ClassInterface(0)]
	[global::System.Runtime.InteropServices.Guid("55136805-B2DE-11D1-B9F2-00A0C98BC547")]
	[global::System.Runtime.InteropServices.ComImport]
	public class ShellNameSpaceClass : global::SHDocVw.IShellNameSpace, global::SHDocVw.ShellNameSpace, global::SHDocVw.DShellNameSpaceEvents_Event
	{
		// Token: 0x06000507 RID: 1287
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public extern ShellNameSpaceClass();

		// Token: 0x06000508 RID: 1288
		[global::System.Runtime.InteropServices.DispId(1)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void MoveSelectionUp();

		// Token: 0x06000509 RID: 1289
		[global::System.Runtime.InteropServices.DispId(2)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void MoveSelectionDown();

		// Token: 0x0600050A RID: 1290
		[global::System.Runtime.InteropServices.DispId(3)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void ResetSort();

		// Token: 0x0600050B RID: 1291
		[global::System.Runtime.InteropServices.DispId(4)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void NewFolder();

		// Token: 0x0600050C RID: 1292
		[global::System.Runtime.InteropServices.DispId(5)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void Synchronize();

		// Token: 0x0600050D RID: 1293
		[global::System.Runtime.InteropServices.DispId(6)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void Import();

		// Token: 0x0600050E RID: 1294
		[global::System.Runtime.InteropServices.DispId(7)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void Export();

		// Token: 0x0600050F RID: 1295
		[global::System.Runtime.InteropServices.DispId(8)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void InvokeContextMenuCommand([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string strCommand);

		// Token: 0x06000510 RID: 1296
		[global::System.Runtime.InteropServices.DispId(9)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void MoveSelectionTo();

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000511 RID: 1297
		[global::System.Runtime.InteropServices.DispId(10)]
		public virtual extern bool SubscriptionsEnabled { [global::System.Runtime.InteropServices.DispId(10)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000512 RID: 1298
		[global::System.Runtime.InteropServices.DispId(11)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern bool CreateSubscriptionForSelection();

		// Token: 0x06000513 RID: 1299
		[global::System.Runtime.InteropServices.DispId(12)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern bool DeleteSubscriptionForSelection();

		// Token: 0x06000514 RID: 1300
		[global::System.Runtime.InteropServices.DispId(13)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void SetRoot([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string bstrFullPath);

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000515 RID: 1301
		// (set) Token: 0x06000516 RID: 1302
		[global::System.Runtime.InteropServices.DispId(14)]
		public virtual extern int EnumOptions { [global::System.Runtime.InteropServices.DispId(14)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(14)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000517 RID: 1303
		// (set) Token: 0x06000518 RID: 1304
		[global::System.Runtime.InteropServices.DispId(15)]
		public virtual extern object SelectedItem { [global::System.Runtime.InteropServices.DispId(15)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; [global::System.Runtime.InteropServices.DispId(15)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06000519 RID: 1305
		// (set) Token: 0x0600051A RID: 1306
		[global::System.Runtime.InteropServices.DispId(16)]
		public virtual extern object Root { [global::System.Runtime.InteropServices.DispId(16)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(16)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x0600051B RID: 1307
		// (set) Token: 0x0600051C RID: 1308
		[global::System.Runtime.InteropServices.DispId(17)]
		public virtual extern int Depth { [global::System.Runtime.InteropServices.DispId(17)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(17)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x0600051D RID: 1309
		// (set) Token: 0x0600051E RID: 1310
		[global::System.Runtime.InteropServices.DispId(18)]
		public virtual extern uint Mode { [global::System.Runtime.InteropServices.DispId(18)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(18)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x0600051F RID: 1311
		// (set) Token: 0x06000520 RID: 1312
		[global::System.Runtime.InteropServices.DispId(19)]
		public virtual extern uint Flags { [global::System.Runtime.InteropServices.DispId(19)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(19)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000522 RID: 1314
		// (set) Token: 0x06000521 RID: 1313
		[global::System.Runtime.InteropServices.DispId(20)]
		public virtual extern uint TVFlags { [global::System.Runtime.InteropServices.DispId(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000523 RID: 1315
		// (set) Token: 0x06000524 RID: 1316
		[global::System.Runtime.InteropServices.DispId(21)]
		public virtual extern string Columns { [global::System.Runtime.InteropServices.DispId(21)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(21)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000525 RID: 1317
		[global::System.Runtime.InteropServices.DispId(22)]
		public virtual extern int CountViewTypes { [global::System.Runtime.InteropServices.DispId(22)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000526 RID: 1318
		[global::System.Runtime.InteropServices.DispId(23)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void SetViewType([global::System.Runtime.InteropServices.In] int iType);

		// Token: 0x06000527 RID: 1319
		[global::System.Runtime.InteropServices.DispId(24)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)]
		public virtual extern object SelectedItems();

		// Token: 0x06000528 RID: 1320
		[global::System.Runtime.InteropServices.DispId(25)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void Expand([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] object var, int iDepth);

		// Token: 0x06000529 RID: 1321
		[global::System.Runtime.InteropServices.DispId(26)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void UnselectAll();

		// Token: 0x140000FA RID: 250
		// (add) Token: 0x0600052A RID: 1322
		// (remove) Token: 0x0600052B RID: 1323
		public virtual extern event global::SHDocVw.DShellNameSpaceEvents_FavoritesSelectionChangeEventHandler FavoritesSelectionChange;

		// Token: 0x140000FB RID: 251
		// (add) Token: 0x0600052C RID: 1324
		// (remove) Token: 0x0600052D RID: 1325
		public virtual extern event global::SHDocVw.DShellNameSpaceEvents_SelectionChangeEventHandler SelectionChange;

		// Token: 0x140000FC RID: 252
		// (add) Token: 0x0600052E RID: 1326
		// (remove) Token: 0x0600052F RID: 1327
		public virtual extern event global::SHDocVw.DShellNameSpaceEvents_DoubleClickEventHandler DoubleClick;

		// Token: 0x140000FD RID: 253
		// (add) Token: 0x06000530 RID: 1328
		// (remove) Token: 0x06000531 RID: 1329
		public virtual extern event global::SHDocVw.DShellNameSpaceEvents_InitializedEventHandler Initialized;
	}
}
