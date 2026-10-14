using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace CDO
{
	// Token: 0x02000060 RID: 96
	[global::System.Runtime.InteropServices.TypeLibType(4288)]
	[global::System.Runtime.InteropServices.Guid("CD00012C-8B95-11D1-82DB-00C04FB1625D")]
	[global::System.Runtime.InteropServices.ComImport]
	public interface IRecurrencePatterns : global::System.Collections.IEnumerable
	{
		// Token: 0x170000D8 RID: 216
		[global::System.Runtime.InteropServices.DispId(0)]
		global::CDO.IRecurrencePattern this[int Index]
		{
			[global::System.Runtime.InteropServices.DispId(0)]
			[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
			[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
			get;
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x060001E7 RID: 487
		[global::System.Runtime.InteropServices.DispId(1)]
		int Count { [global::System.Runtime.InteropServices.DispId(1)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x060001E8 RID: 488
		[global::System.Runtime.InteropServices.DispId(2)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void Delete([global::System.Runtime.InteropServices.In] int Index);

		// Token: 0x060001E9 RID: 489
		[global::System.Runtime.InteropServices.DispId(3)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		global::CDO.IRecurrencePattern Add([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string Type);

		// Token: 0x060001EA RID: 490
		[global::System.Runtime.InteropServices.DispId(-4)]
		[global::System.Runtime.InteropServices.TypeLibFunc(1)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.CustomMarshaler, MarshalTypeRef = System.Runtime.InteropServices.CustomMarshalers.EnumeratorToEnumVariantMarshaler)]
		global::System.Collections.IEnumerator GetEnumerator();
	}
}
