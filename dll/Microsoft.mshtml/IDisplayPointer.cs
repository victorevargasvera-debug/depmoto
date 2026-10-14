using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x02000CB0 RID: 3248
	[global::System.Runtime.InteropServices.Guid("3050F69E-98B5-11CF-BB82-00AA00BDCE0B")]
	[global::System.Runtime.InteropServices.InterfaceType(1)]
	[global::System.Runtime.InteropServices.ComImport]
	public interface IDisplayPointer
	{
		// Token: 0x0601626F RID: 90735
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void moveToPoint([global::System.Runtime.InteropServices.In] global::mshtml.tagPOINT ptPoint, [global::System.Runtime.InteropServices.In] global::mshtml._COORD_SYSTEM eCoordSystem, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLElement pElementContext, [global::System.Runtime.InteropServices.In] uint dwHitTestOptions, out uint pdwHitTestResults);

		// Token: 0x06016270 RID: 90736
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void MoveUnit([global::System.Runtime.InteropServices.In] global::mshtml._DISPLAY_MOVEUNIT eMoveUnit, [global::System.Runtime.InteropServices.In] int lXPos);

		// Token: 0x06016271 RID: 90737
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void PositionMarkupPointer([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IMarkupPointer pMarkupPointer);

		// Token: 0x06016272 RID: 90738
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void MoveToPointer([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IDisplayPointer pDispPointer);

		// Token: 0x06016273 RID: 90739
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void SetPointerGravity([global::System.Runtime.InteropServices.In] global::mshtml._POINTER_GRAVITY eGravity);

		// Token: 0x06016274 RID: 90740
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void GetPointerGravity(out global::mshtml._POINTER_GRAVITY peGravity);

		// Token: 0x06016275 RID: 90741
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void SetDisplayGravity([global::System.Runtime.InteropServices.In] global::mshtml._DISPLAY_GRAVITY eGravity);

		// Token: 0x06016276 RID: 90742
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void GetDisplayGravity(out global::mshtml._DISPLAY_GRAVITY peGravity);

		// Token: 0x06016277 RID: 90743
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void IsPositioned(out int pfPositioned);

		// Token: 0x06016278 RID: 90744
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void Unposition();

		// Token: 0x06016279 RID: 90745
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void IsEqualTo([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IDisplayPointer pDispPointer, out int pfIsEqual);

		// Token: 0x0601627A RID: 90746
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void IsLeftOf([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IDisplayPointer pDispPointer, out int pfIsLeftOf);

		// Token: 0x0601627B RID: 90747
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void IsRightOf([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IDisplayPointer pDispPointer, out int pfIsRightOf);

		// Token: 0x0601627C RID: 90748
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void IsAtBOL(out int pfBOL);

		// Token: 0x0601627D RID: 90749
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void MoveToMarkupPointer([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IMarkupPointer pPointer, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IDisplayPointer pDispLineContext);

		// Token: 0x0601627E RID: 90750
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void scrollIntoView();

		// Token: 0x0601627F RID: 90751
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void GetLineInfo([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] out global::mshtml.ILineInfo ppLineInfo);

		// Token: 0x06016280 RID: 90752
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void GetFlowElement([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] out global::mshtml.IHTMLElement ppLayoutElement);

		// Token: 0x06016281 RID: 90753
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void QueryBreaks(out uint pdwBreaks);
	}
}
