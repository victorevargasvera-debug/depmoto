using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace CDO
{
	// Token: 0x02000065 RID: 101
	[global::System.Runtime.InteropServices.Guid("CD000130-8B95-11D1-82DB-00C04FB1625D")]
	[global::System.Runtime.InteropServices.TypeLibType(4288)]
	[global::System.Runtime.InteropServices.ComImport]
	public interface ICalendarParts : global::System.Collections.IEnumerable
	{
		// Token: 0x170000F3 RID: 243
		[global::System.Runtime.InteropServices.DispId(0)]
		global::CDO.ICalendarPart this[int Index]
		{
			[global::System.Runtime.InteropServices.DispId(0)]
			[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
			[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
			get;
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000214 RID: 532
		[global::System.Runtime.InteropServices.DispId(1)]
		int Count { [global::System.Runtime.InteropServices.DispId(1)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000215 RID: 533
		[global::System.Runtime.InteropServices.DispId(2)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void Delete([global::System.Runtime.InteropServices.In] int Index);

		// Token: 0x06000216 RID: 534
		[global::System.Runtime.InteropServices.DispId(3)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void Add([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IUnknown)] [global::System.Runtime.InteropServices.In] object CalendarPart, [global::System.Runtime.InteropServices.In] global::CDO.CdoComponentType ComponentType);

		// Token: 0x06000217 RID: 535
		[global::System.Runtime.InteropServices.TypeLibFunc(1)]
		[global::System.Runtime.InteropServices.DispId(-4)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.CustomMarshaler, MarshalTypeRef = System.Runtime.InteropServices.CustomMarshalers.EnumeratorToEnumVariantMarshaler)]
		global::System.Collections.IEnumerator GetEnumerator();
	}
}
