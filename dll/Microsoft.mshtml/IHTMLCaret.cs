using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x02000CAF RID: 3247
	[global::System.Runtime.InteropServices.InterfaceType(1)]
	[global::System.Runtime.InteropServices.Guid("3050F604-98B5-11CF-BB82-00AA00BDCE0B")]
	[global::System.Runtime.InteropServices.ComImport]
	public interface IHTMLCaret
	{
		// Token: 0x06016263 RID: 90723
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void MoveCaretToPointer([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IDisplayPointer pDispPointer, [global::System.Runtime.InteropServices.In] int fScrollIntoView, [global::System.Runtime.InteropServices.In] global::mshtml._CARET_DIRECTION eDir);

		// Token: 0x06016264 RID: 90724
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void MoveCaretToPointerEx([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IDisplayPointer pDispPointer, [global::System.Runtime.InteropServices.In] int fVisible, [global::System.Runtime.InteropServices.In] int fScrollIntoView, [global::System.Runtime.InteropServices.In] global::mshtml._CARET_DIRECTION eDir);

		// Token: 0x06016265 RID: 90725
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void MoveMarkupPointerToCaret([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IMarkupPointer pIMarkupPointer);

		// Token: 0x06016266 RID: 90726
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void MoveDisplayPointerToCaret([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IDisplayPointer pDispPointer);

		// Token: 0x06016267 RID: 90727
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void IsVisible(out int pIsVisible);

		// Token: 0x06016268 RID: 90728
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void Show([global::System.Runtime.InteropServices.In] int fScrollIntoView);

		// Token: 0x06016269 RID: 90729
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void Hide();

		// Token: 0x0601626A RID: 90730
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void InsertText([global::System.Runtime.InteropServices.In] ref ushort pText, [global::System.Runtime.InteropServices.In] int lLen);

		// Token: 0x0601626B RID: 90731
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void scrollIntoView();

		// Token: 0x0601626C RID: 90732
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void GetLocation(out global::mshtml.tagPOINT pPoint, [global::System.Runtime.InteropServices.In] int fTranslate);

		// Token: 0x0601626D RID: 90733
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void GetCaretDirection(out global::mshtml._CARET_DIRECTION peDir);

		// Token: 0x0601626E RID: 90734
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void SetCaretDirection([global::System.Runtime.InteropServices.In] global::mshtml._CARET_DIRECTION eDir);
	}
}
