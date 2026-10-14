using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ADODB
{
	// Token: 0x02000066 RID: 102
	[global::System.Runtime.InteropServices.Guid("00000567-0000-0010-8000-00AA006D2EA4")]
	[global::System.Runtime.InteropServices.TypeLibType(4608)]
	[global::System.Runtime.InteropServices.ComImport]
	public interface ADORecordConstruction
	{
		// Token: 0x17000113 RID: 275
		// (get) Token: 0x060002F2 RID: 754
		// (set) Token: 0x060002F3 RID: 755
		[global::System.Runtime.InteropServices.DispId(1610743808)]
		object Row { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IUnknown)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IUnknown)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000114 RID: 276
		// (set) Token: 0x060002F4 RID: 756
		[global::System.Runtime.InteropServices.DispId(1610743810)]
		object ParentRow { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IUnknown)] [param: global::System.Runtime.InteropServices.In] set; }
	}
}
