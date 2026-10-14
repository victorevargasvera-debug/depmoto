using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SHDocVw
{
	// Token: 0x02000062 RID: 98
	[global::System.Runtime.InteropServices.TypeLibType(4176)]
	[global::System.Runtime.InteropServices.Guid("47C922A2-3DD5-11D2-BF8B-00C04FB93661")]
	[global::System.Runtime.InteropServices.ComImport]
	public interface ISearches : global::System.Collections.IEnumerable
	{
		// Token: 0x17000122 RID: 290
		// (get) Token: 0x06000562 RID: 1378
		[global::System.Runtime.InteropServices.DispId(1610743808)]
		int Count { [global::System.Runtime.InteropServices.DispId(1610743808)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06000563 RID: 1379
		[global::System.Runtime.InteropServices.DispId(1610743809)]
		string Default { [global::System.Runtime.InteropServices.DispId(1610743809)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x06000564 RID: 1380
		[global::System.Runtime.InteropServices.DispId(1610743810)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		global::SHDocVw.ISearch Item([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] object index);

		// Token: 0x06000565 RID: 1381
		[global::System.Runtime.InteropServices.DispId(-4)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.CustomMarshaler, MarshalTypeRef = System.Runtime.InteropServices.CustomMarshalers.EnumeratorToEnumVariantMarshaler)]
		global::System.Collections.IEnumerator GetEnumerator();
	}
}
