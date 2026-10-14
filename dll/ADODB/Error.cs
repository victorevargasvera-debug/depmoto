using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ADODB
{
	// Token: 0x0200003C RID: 60
	[global::System.Reflection.DefaultMember("Description")]
	[global::System.Runtime.InteropServices.TypeLibType(4288)]
	[global::System.Runtime.InteropServices.Guid("00000500-0000-0010-8000-00AA006D2EA4")]
	[global::System.Runtime.InteropServices.ComImport]
	public interface Error
	{
		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000014 RID: 20
		[global::System.Runtime.InteropServices.DispId(1)]
		int Number { [global::System.Runtime.InteropServices.DispId(1)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000015 RID: 21
		[global::System.Runtime.InteropServices.DispId(2)]
		string Source { [global::System.Runtime.InteropServices.DispId(2)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000016 RID: 22
		[global::System.Runtime.InteropServices.DispId(0)]
		[global::System.Runtime.CompilerServices.IndexerName("Description")]
		string Description { [global::System.Runtime.InteropServices.DispId(0)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000017 RID: 23
		[global::System.Runtime.InteropServices.DispId(3)]
		string HelpFile { [global::System.Runtime.InteropServices.DispId(3)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000018 RID: 24
		[global::System.Runtime.InteropServices.DispId(4)]
		int HelpContext { [global::System.Runtime.InteropServices.DispId(4)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000019 RID: 25
		[global::System.Runtime.InteropServices.DispId(5)]
		string SQLState { [global::System.Runtime.InteropServices.DispId(5)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600001A RID: 26
		[global::System.Runtime.InteropServices.DispId(6)]
		int NativeError { [global::System.Runtime.InteropServices.DispId(6)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }
	}
}
