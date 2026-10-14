using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x02000C9D RID: 3229
	[global::System.Runtime.InteropServices.Guid("08C03412-F96B-11D0-A475-00AA006BCC59")]
	[global::System.Runtime.InteropServices.InterfaceType(1)]
	[global::System.Runtime.InteropServices.ComImport]
	public interface IEnumRegisterWordA
	{
		// Token: 0x0601624F RID: 90703
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void Clone([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] out global::mshtml.IEnumRegisterWordA ppEnum);

		// Token: 0x06016250 RID: 90704
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void Next([global::System.Runtime.InteropServices.In] uint ulCount, out global::mshtml.__MIDL___MIDL_itf_mshtml_0250_0001 rgRegisterWord, out uint pcFetched);

		// Token: 0x06016251 RID: 90705
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void reset();

		// Token: 0x06016252 RID: 90706
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void Skip([global::System.Runtime.InteropServices.In] uint ulCount);
	}
}
