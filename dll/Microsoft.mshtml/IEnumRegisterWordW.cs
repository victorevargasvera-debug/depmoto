using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x02000C9E RID: 3230
	[global::System.Runtime.InteropServices.InterfaceType(1)]
	[global::System.Runtime.InteropServices.Guid("4955DD31-B159-11D0-8FCF-00AA006BCC59")]
	[global::System.Runtime.InteropServices.ComImport]
	public interface IEnumRegisterWordW
	{
		// Token: 0x06016253 RID: 90707
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void Clone([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] out global::mshtml.IEnumRegisterWordW ppEnum);

		// Token: 0x06016254 RID: 90708
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void Next([global::System.Runtime.InteropServices.In] uint ulCount, out global::mshtml.__MIDL___MIDL_itf_mshtml_0250_0002 rgRegisterWord, out uint pcFetched);

		// Token: 0x06016255 RID: 90709
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void reset();

		// Token: 0x06016256 RID: 90710
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void Skip([global::System.Runtime.InteropServices.In] uint ulCount);
	}
}
