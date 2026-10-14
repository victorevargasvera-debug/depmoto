using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x02000CE8 RID: 3304
	[global::System.Runtime.InteropServices.Guid("3050F6DF-98B5-11CF-BB82-00AA00BDCE0B")]
	[global::System.Runtime.InteropServices.InterfaceType(1)]
	[global::System.Runtime.InteropServices.ComImport]
	public interface IHTMLPainterEventInfo
	{
		// Token: 0x06016360 RID: 90976
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void GetEventInfoFlags(out int plEventInfoFlags);

		// Token: 0x06016361 RID: 90977
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void GetEventTarget([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] ref global::mshtml.IHTMLElement ppElement);

		// Token: 0x06016362 RID: 90978
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void SetCursor([global::System.Runtime.InteropServices.In] int lPartID);

		// Token: 0x06016363 RID: 90979
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void StringFromPartID([global::System.Runtime.InteropServices.In] int lPartID, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] out string pbstrPart);
	}
}
