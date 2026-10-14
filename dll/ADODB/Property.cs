using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ADODB
{
	// Token: 0x0200003B RID: 59
	[global::System.Runtime.InteropServices.TypeLibType(4288)]
	[global::System.Runtime.InteropServices.Guid("00000503-0000-0010-8000-00AA006D2EA4")]
	[global::System.Reflection.DefaultMember("Value")]
	[global::System.Runtime.InteropServices.ComImport]
	public interface Property
	{
		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000E RID: 14
		// (set) Token: 0x0600000F RID: 15
		[global::System.Runtime.InteropServices.DispId(0)]
		[global::System.Runtime.CompilerServices.IndexerName("Value")]
		object Value { [global::System.Runtime.InteropServices.DispId(0)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(0)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000010 RID: 16
		[global::System.Runtime.InteropServices.DispId(1610743810)]
		string Name { [global::System.Runtime.InteropServices.DispId(1610743810)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000011 RID: 17
		[global::System.Runtime.InteropServices.DispId(1610743811)]
		global::ADODB.DataTypeEnum Type { [global::System.Runtime.InteropServices.DispId(1610743811)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000012 RID: 18
		// (set) Token: 0x06000013 RID: 19
		[global::System.Runtime.InteropServices.DispId(1610743812)]
		int Attributes { [global::System.Runtime.InteropServices.DispId(1610743812)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(1610743812)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }
	}
}
