using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SHDocVw
{
	// Token: 0x02000055 RID: 85
	[global::System.Runtime.InteropServices.TypeLibType(4176)]
	[global::System.Runtime.InteropServices.Guid("55136804-B2DE-11D1-B9F2-00A0C98BC547")]
	[global::System.Runtime.InteropServices.ComImport]
	public interface IShellFavoritesNameSpace
	{
		// Token: 0x060004D8 RID: 1240
		[global::System.Runtime.InteropServices.DispId(1)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void MoveSelectionUp();

		// Token: 0x060004D9 RID: 1241
		[global::System.Runtime.InteropServices.DispId(2)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void MoveSelectionDown();

		// Token: 0x060004DA RID: 1242
		[global::System.Runtime.InteropServices.DispId(3)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void ResetSort();

		// Token: 0x060004DB RID: 1243
		[global::System.Runtime.InteropServices.DispId(4)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void NewFolder();

		// Token: 0x060004DC RID: 1244
		[global::System.Runtime.InteropServices.DispId(5)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void Synchronize();

		// Token: 0x060004DD RID: 1245
		[global::System.Runtime.InteropServices.DispId(6)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void Import();

		// Token: 0x060004DE RID: 1246
		[global::System.Runtime.InteropServices.DispId(7)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void Export();

		// Token: 0x060004DF RID: 1247
		[global::System.Runtime.InteropServices.DispId(8)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void InvokeContextMenuCommand([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string strCommand);

		// Token: 0x060004E0 RID: 1248
		[global::System.Runtime.InteropServices.DispId(9)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void MoveSelectionTo();

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x060004E1 RID: 1249
		[global::System.Runtime.InteropServices.DispId(10)]
		bool SubscriptionsEnabled { [global::System.Runtime.InteropServices.DispId(10)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x060004E2 RID: 1250
		[global::System.Runtime.InteropServices.DispId(11)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		bool CreateSubscriptionForSelection();

		// Token: 0x060004E3 RID: 1251
		[global::System.Runtime.InteropServices.DispId(12)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		bool DeleteSubscriptionForSelection();

		// Token: 0x060004E4 RID: 1252
		[global::System.Runtime.InteropServices.DispId(13)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void SetRoot([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string bstrFullPath);
	}
}
