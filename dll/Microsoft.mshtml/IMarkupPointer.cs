using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x02000C95 RID: 3221
	[global::System.Runtime.InteropServices.InterfaceType(1)]
	[global::System.Runtime.InteropServices.Guid("3050F49F-98B5-11CF-BB82-00AA00BDCE0B")]
	[global::System.Runtime.InteropServices.ComImport]
	public interface IMarkupPointer
	{
		// Token: 0x060161EC RID: 90604
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void OwningDoc([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] out global::mshtml.IHTMLDocument2 ppDoc);

		// Token: 0x060161ED RID: 90605
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void Gravity(out global::mshtml._POINTER_GRAVITY pGravity);

		// Token: 0x060161EE RID: 90606
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void SetGravity([global::System.Runtime.InteropServices.In] global::mshtml._POINTER_GRAVITY Gravity);

		// Token: 0x060161EF RID: 90607
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void Cling(out int pfCling);

		// Token: 0x060161F0 RID: 90608
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void SetCling([global::System.Runtime.InteropServices.In] int fCLing);

		// Token: 0x060161F1 RID: 90609
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void Unposition();

		// Token: 0x060161F2 RID: 90610
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void IsPositioned(out int pfPositioned);

		// Token: 0x060161F3 RID: 90611
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void GetContainer([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] out global::mshtml.IMarkupContainer ppContainer);

		// Token: 0x060161F4 RID: 90612
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void MoveAdjacentToElement([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLElement pElement, [global::System.Runtime.InteropServices.In] global::mshtml._ELEMENT_ADJACENCY eAdj);

		// Token: 0x060161F5 RID: 90613
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void MoveToPointer([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IMarkupPointer pPointer);

		// Token: 0x060161F6 RID: 90614
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void MoveToContainer([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IMarkupContainer pContainer, [global::System.Runtime.InteropServices.In] int fAtStart);

		// Token: 0x060161F7 RID: 90615
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void left([global::System.Runtime.InteropServices.In] int fMove, out global::mshtml._MARKUP_CONTEXT_TYPE pContext, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] out global::mshtml.IHTMLElement ppElement, [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Out] ref int pcch, out ushort pchText);

		// Token: 0x060161F8 RID: 90616
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void right([global::System.Runtime.InteropServices.In] int fMove, out global::mshtml._MARKUP_CONTEXT_TYPE pContext, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] out global::mshtml.IHTMLElement ppElement, [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Out] ref int pcch, out ushort pchText);

		// Token: 0x060161F9 RID: 90617
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void CurrentScope([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] out global::mshtml.IHTMLElement ppElemCurrent);

		// Token: 0x060161FA RID: 90618
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void IsLeftOf([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IMarkupPointer pPointerThat, out int pfResult);

		// Token: 0x060161FB RID: 90619
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void IsLeftOfOrEqualTo([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IMarkupPointer pPointerThat, out int pfResult);

		// Token: 0x060161FC RID: 90620
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void IsRightOf([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IMarkupPointer pPointerThat, out int pfResult);

		// Token: 0x060161FD RID: 90621
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void IsRightOfOrEqualTo([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IMarkupPointer pPointerThat, out int pfResult);

		// Token: 0x060161FE RID: 90622
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void IsEqualTo([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IMarkupPointer pPointerThat, out int pfAreEqual);

		// Token: 0x060161FF RID: 90623
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void MoveUnit([global::System.Runtime.InteropServices.In] global::mshtml._MOVEUNIT_ACTION muAction);

		// Token: 0x06016200 RID: 90624
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void findText([global::System.Runtime.InteropServices.In] ref ushort pchFindText, [global::System.Runtime.InteropServices.In] uint dwFlags, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IMarkupPointer pIEndMatch, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IMarkupPointer pIEndSearch);
	}
}
