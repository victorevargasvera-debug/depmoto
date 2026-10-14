using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ADODB;

namespace CDO
{
	// Token: 0x0200005F RID: 95
	[global::System.Runtime.InteropServices.Guid("CD000124-8B95-11D1-82DB-00C04FB1625D")]
	[global::System.Runtime.InteropServices.TypeLibType(4288)]
	[global::System.Runtime.InteropServices.ComImport]
	public interface IException
	{
		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x060001DC RID: 476
		[global::System.Runtime.InteropServices.DispId(1)]
		string Type { [global::System.Runtime.InteropServices.DispId(1)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x060001DD RID: 477
		// (set) Token: 0x060001DE RID: 478
		[global::System.Runtime.InteropServices.DispId(2)]
		string RecurrenceIDRange { [global::System.Runtime.InteropServices.DispId(2)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(2)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x060001DF RID: 479
		// (set) Token: 0x060001E0 RID: 480
		[global::System.Runtime.InteropServices.DispId(3)]
		global::System.DateTime RecurrenceID { [global::System.Runtime.InteropServices.DispId(3)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(3)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x060001E1 RID: 481
		// (set) Token: 0x060001E2 RID: 482
		[global::System.Runtime.InteropServices.DispId(4)]
		global::System.DateTime StartTime { [global::System.Runtime.InteropServices.DispId(4)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(4)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x060001E3 RID: 483
		// (set) Token: 0x060001E4 RID: 484
		[global::System.Runtime.InteropServices.DispId(5)]
		global::System.DateTime EndTime { [global::System.Runtime.InteropServices.DispId(5)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(5)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x060001E5 RID: 485
		[global::System.Runtime.InteropServices.DispId(101)]
		global::ADODB.Fields Fields { [global::System.Runtime.InteropServices.DispId(101)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }
	}
}
