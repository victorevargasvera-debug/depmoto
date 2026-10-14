using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x02000CC0 RID: 3264
	[global::System.Runtime.InteropServices.InterfaceType(1)]
	[global::System.Runtime.InteropServices.Guid("3050F682-98B5-11CF-BB82-00AA00BDCE0B")]
	[global::System.Runtime.InteropServices.ComImport]
	public interface IMarkupServices2 : global::mshtml.IMarkupServices
	{
		// Token: 0x060162CA RID: 90826
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void CreateMarkupPointer([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] out global::mshtml.IMarkupPointer ppPointer);

		// Token: 0x060162CB RID: 90827
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void CreateMarkupContainer([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] out global::mshtml.IMarkupContainer ppMarkupContainer);

		// Token: 0x060162CC RID: 90828
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void createElement([global::System.Runtime.InteropServices.In] global::mshtml._ELEMENT_TAG_ID tagID, [global::System.Runtime.InteropServices.In] ref ushort pchAttributes, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] out global::mshtml.IHTMLElement ppElement);

		// Token: 0x060162CD RID: 90829
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void CloneElement([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLElement pElemCloneThis, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] out global::mshtml.IHTMLElement ppElementTheClone);

		// Token: 0x060162CE RID: 90830
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void InsertElement([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLElement pElementInsert, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IMarkupPointer pPointerStart, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IMarkupPointer pPointerFinish);

		// Token: 0x060162CF RID: 90831
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void RemoveElement([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLElement pElementRemove);

		// Token: 0x060162D0 RID: 90832
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void remove([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IMarkupPointer pPointerStart, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IMarkupPointer pPointerFinish);

		// Token: 0x060162D1 RID: 90833
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void Copy([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IMarkupPointer pPointerSourceStart, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IMarkupPointer pPointerSourceFinish, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IMarkupPointer pPointerTarget);

		// Token: 0x060162D2 RID: 90834
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void move([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IMarkupPointer pPointerSourceStart, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IMarkupPointer pPointerSourceFinish, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IMarkupPointer pPointerTarget);

		// Token: 0x060162D3 RID: 90835
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void InsertText([global::System.Runtime.InteropServices.In] ref ushort pchText, [global::System.Runtime.InteropServices.In] int cch, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IMarkupPointer pPointerTarget);

		// Token: 0x060162D4 RID: 90836
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void ParseString([global::System.Runtime.InteropServices.In] ref ushort pchHTML, [global::System.Runtime.InteropServices.In] uint dwFlags, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] out global::mshtml.IMarkupContainer ppContainerResult, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IMarkupPointer ppPointerStart, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IMarkupPointer ppPointerFinish);

		// Token: 0x060162D5 RID: 90837
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void ParseGlobal([global::System.Runtime.InteropServices.ComAliasName("mshtml.wireHGLOBAL")] [global::System.Runtime.InteropServices.In] ref global::mshtml._userHGLOBAL hglobalHTML, [global::System.Runtime.InteropServices.In] uint dwFlags, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] out global::mshtml.IMarkupContainer ppContainerResult, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IMarkupPointer pPointerStart, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IMarkupPointer pPointerFinish);

		// Token: 0x060162D6 RID: 90838
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void IsScopedElement([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLElement pElement, out int pfScoped);

		// Token: 0x060162D7 RID: 90839
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void GetElementTagId([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLElement pElement, out global::mshtml._ELEMENT_TAG_ID ptagId);

		// Token: 0x060162D8 RID: 90840
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void GetTagIDForName([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string bstrName, out global::mshtml._ELEMENT_TAG_ID ptagId);

		// Token: 0x060162D9 RID: 90841
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void GetNameForTagID([global::System.Runtime.InteropServices.In] global::mshtml._ELEMENT_TAG_ID tagID, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] out string pbstrName);

		// Token: 0x060162DA RID: 90842
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void MovePointersToRange([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLTxtRange pIRange, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IMarkupPointer pPointerStart, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IMarkupPointer pPointerFinish);

		// Token: 0x060162DB RID: 90843
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void MoveRangeToPointers([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IMarkupPointer pPointerStart, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IMarkupPointer pPointerFinish, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLTxtRange pIRange);

		// Token: 0x060162DC RID: 90844
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void BeginUndoUnit([global::System.Runtime.InteropServices.In] ref ushort pchTitle);

		// Token: 0x060162DD RID: 90845
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void EndUndoUnit();

		// Token: 0x060162DE RID: 90846
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void ParseGlobalEx([global::System.Runtime.InteropServices.ComAliasName("mshtml.wireHGLOBAL")] [global::System.Runtime.InteropServices.In] ref global::mshtml._userHGLOBAL hglobalHTML, [global::System.Runtime.InteropServices.In] uint dwFlags, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IMarkupContainer pContext, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] out global::mshtml.IMarkupContainer ppContainerResult, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IMarkupPointer pPointerStart, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IMarkupPointer pPointerFinish);

		// Token: 0x060162DF RID: 90847
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void ValidateElements([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IMarkupPointer pPointerStart, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IMarkupPointer pPointerFinish, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IMarkupPointer pPointerTarget, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Out] global::mshtml.IMarkupPointer pPointerStatus, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] out global::mshtml.IHTMLElement ppElemFailBottom, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] out global::mshtml.IHTMLElement ppElemFailTop);

		// Token: 0x060162E0 RID: 90848
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void SaveSegmentsToClipboard([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.ISegmentList pSegmentList, [global::System.Runtime.InteropServices.In] uint dwFlags);
	}
}
