using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SHDocVw
{
	// Token: 0x02000066 RID: 102
	[global::System.Runtime.InteropServices.Guid("1611FDDA-445B-11D2-85DE-00C04FA35C89")]
	[global::System.Runtime.InteropServices.InterfaceType(2)]
	[global::System.Runtime.InteropServices.TypeLibType(4112)]
	[global::System.Runtime.InteropServices.ComImport]
	public interface _SearchAssistantEvents
	{
		// Token: 0x060005BC RID: 1468
		[global::System.Runtime.InteropServices.DispId(1)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void OnNextMenuSelect([global::System.Runtime.InteropServices.In] int idItem);

		// Token: 0x060005BD RID: 1469
		[global::System.Runtime.InteropServices.DispId(2)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void OnNewSearch();
	}
}
