using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x02000CC9 RID: 3273
	[global::System.Runtime.InteropServices.Guid("3050F699-98B5-11CF-BB82-00AA00BDCE0B")]
	[global::System.Runtime.InteropServices.InterfaceType(1)]
	[global::System.Runtime.InteropServices.ComImport]
	public interface ISelectionServicesListener
	{
		// Token: 0x06016308 RID: 90888
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void BeginSelectionUndo();

		// Token: 0x06016309 RID: 90889
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void EndSelectionUndo();

		// Token: 0x0601630A RID: 90890
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void OnSelectedElementExit([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IMarkupPointer pIElementStart, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IMarkupPointer pIElementEnd, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IMarkupPointer pIElementContentStart, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IMarkupPointer pIElementContentEnd);

		// Token: 0x0601630B RID: 90891
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void OnChangeType([global::System.Runtime.InteropServices.In] global::mshtml._SELECTION_TYPE eType, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.ISelectionServicesListener pIListener);

		// Token: 0x0601630C RID: 90892
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void GetTypeDetail([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] out string pTypeDetail);
	}
}
