using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ADODB;

namespace CDO
{
	// Token: 0x02000074 RID: 116
	[global::System.Runtime.InteropServices.TypeLibType(4288)]
	[global::System.Runtime.InteropServices.Guid("CD000139-8B95-11D1-82DB-00C04FB1625D")]
	[global::System.Runtime.InteropServices.ComImport]
	public interface IAddressee
	{
		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x06000397 RID: 919
		[global::System.Runtime.InteropServices.DispId(1)]
		global::ADODB.Fields Fields { [global::System.Runtime.InteropServices.DispId(1)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x06000398 RID: 920
		// (set) Token: 0x0600039A RID: 922
		[global::System.Runtime.InteropServices.DispId(2)]
		global::CDO.Configuration Configuration { [global::System.Runtime.InteropServices.DispId(2)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; [global::System.Runtime.InteropServices.DispId(2)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x0600039B RID: 923
		// (set) Token: 0x0600039C RID: 924
		[global::System.Runtime.InteropServices.DispId(3)]
		string DisplayName { [global::System.Runtime.InteropServices.DispId(3)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(3)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x0600039D RID: 925
		// (set) Token: 0x0600039E RID: 926
		[global::System.Runtime.InteropServices.DispId(4)]
		string EmailAddress { [global::System.Runtime.InteropServices.DispId(4)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(4)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x0600039F RID: 927
		[global::System.Runtime.InteropServices.DispId(5)]
		global::CDO.IDataSource DataSource { [global::System.Runtime.InteropServices.DispId(5)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x060003A0 RID: 928
		[global::System.Runtime.InteropServices.DispId(6)]
		string DirURL { [global::System.Runtime.InteropServices.DispId(6)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x060003A1 RID: 929
		// (set) Token: 0x060003A2 RID: 930
		[global::System.Runtime.InteropServices.DispId(7)]
		global::CDO.CdoResolvedStatus ResolvedStatus { [global::System.Runtime.InteropServices.DispId(7)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(7)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x060003A3 RID: 931
		[global::System.Runtime.InteropServices.DispId(8)]
		string ContentClass { [global::System.Runtime.InteropServices.DispId(8)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x060003A4 RID: 932
		[global::System.Runtime.InteropServices.DispId(9)]
		global::CDO.IAddressees AmbiguousNames { [global::System.Runtime.InteropServices.DispId(9)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x060003A5 RID: 933
		[global::System.Runtime.InteropServices.DispId(10)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)]
		object GetInterface([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string Interface);

		// Token: 0x060003A6 RID: 934
		[global::System.Runtime.InteropServices.DispId(11)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		string GetFreeBusy([global::System.Runtime.InteropServices.In] global::System.DateTime StartTime, [global::System.Runtime.InteropServices.In] global::System.DateTime EndTime, [global::System.Runtime.InteropServices.In] int Interval, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] string HTTPHost, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] string VRoot, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] string UserName, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] string Password);

		// Token: 0x060003A7 RID: 935
		[global::System.Runtime.InteropServices.DispId(12)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		bool CheckName([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string Directory, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] string UserName, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] string Password);
	}
}
