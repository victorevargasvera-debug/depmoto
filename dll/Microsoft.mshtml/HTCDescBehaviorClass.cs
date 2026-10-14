using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x020000B2 RID: 178
	[global::System.Runtime.InteropServices.ClassInterface(0)]
	[global::System.Runtime.InteropServices.TypeLibType(2)]
	[global::System.Runtime.InteropServices.Guid("3050F5DD-98B5-11CF-BB82-00AA00BDCE0B")]
	[global::System.Runtime.InteropServices.ComImport]
	public class HTCDescBehaviorClass : global::mshtml.DispHTCDescBehavior, global::mshtml.HTCDescBehavior, global::mshtml.IHTCDescBehavior
	{
		// Token: 0x06000DA1 RID: 3489
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public extern HTCDescBehaviorClass();

		// Token: 0x17000748 RID: 1864
		// (get) Token: 0x06000DA2 RID: 3490
		[global::System.Runtime.InteropServices.DispId(-2147417612)]
		public virtual extern string urn { [global::System.Runtime.InteropServices.DispId(-2147417612)] [global::System.Runtime.InteropServices.TypeLibFunc(4)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x17000749 RID: 1865
		// (get) Token: 0x06000DA3 RID: 3491
		[global::System.Runtime.InteropServices.DispId(-2147417611)]
		public virtual extern string name { [global::System.Runtime.InteropServices.TypeLibFunc(4)] [global::System.Runtime.InteropServices.DispId(-2147417611)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x1700074A RID: 1866
		// (get) Token: 0x06000DA4 RID: 3492
		public virtual extern string IHTCDescBehavior_urn { [global::System.Runtime.InteropServices.TypeLibFunc(4)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x1700074B RID: 1867
		// (get) Token: 0x06000DA5 RID: 3493
		public virtual extern string IHTCDescBehavior_name { [global::System.Runtime.InteropServices.TypeLibFunc(4)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }
	}
}
