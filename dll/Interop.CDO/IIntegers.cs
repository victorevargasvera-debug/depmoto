using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace CDO
{
	// Token: 0x02000062 RID: 98
	[global::System.Runtime.InteropServices.TypeLibType(4288)]
	[global::System.Runtime.InteropServices.Guid("CD00012E-8B95-11D1-82DB-00C04FB1625D")]
	[global::System.Runtime.InteropServices.ComImport]
	public interface IIntegers : global::System.Collections.IEnumerable
	{
		// Token: 0x170000EB RID: 235
		[global::System.Runtime.InteropServices.DispId(0)]
		int this[int Index]
		{
			[global::System.Runtime.InteropServices.DispId(0)]
			[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
			get;
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000203 RID: 515
		[global::System.Runtime.InteropServices.DispId(1)]
		int Count { [global::System.Runtime.InteropServices.DispId(1)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000204 RID: 516
		[global::System.Runtime.InteropServices.DispId(2)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void Delete([global::System.Runtime.InteropServices.In] ref int Value);

		// Token: 0x06000205 RID: 517
		[global::System.Runtime.InteropServices.DispId(3)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void Add([global::System.Runtime.InteropServices.In] int NewValue);

		// Token: 0x06000206 RID: 518
		[global::System.Runtime.InteropServices.TypeLibFunc(1)]
		[global::System.Runtime.InteropServices.DispId(-4)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.CustomMarshaler, MarshalTypeRef = System.Runtime.InteropServices.CustomMarshalers.EnumeratorToEnumVariantMarshaler)]
		global::System.Collections.IEnumerator GetEnumerator();
	}
}
