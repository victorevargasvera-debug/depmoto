using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x02000C9A RID: 3226
	[global::System.Runtime.InteropServices.InterfaceType(1)]
	[global::System.Runtime.InteropServices.ComConversionLoss]
	[global::System.Runtime.InteropServices.Guid("08C0E040-62D1-11D1-9326-0060B067B86E")]
	[global::System.Runtime.InteropServices.ComImport]
	public interface IActiveIMMApp
	{
		// Token: 0x0601620B RID: 90635
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void AssociateContext([global::System.Runtime.InteropServices.ComAliasName("mshtml.wireHWND")] [global::System.Runtime.InteropServices.In] ref global::mshtml._RemotableHandle hWnd, [global::System.Runtime.InteropServices.In] uint hIME, out uint phPrev);

		// Token: 0x0601620C RID: 90636
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void ConfigureIMEA([global::System.Runtime.InteropServices.In] global::System.IntPtr hKL, [global::System.Runtime.InteropServices.ComAliasName("mshtml.wireHWND")] [global::System.Runtime.InteropServices.In] ref global::mshtml._RemotableHandle hWnd, [global::System.Runtime.InteropServices.In] uint dwMode, [global::System.Runtime.InteropServices.In] ref global::mshtml.__MIDL___MIDL_itf_mshtml_0250_0001 pData);

		// Token: 0x0601620D RID: 90637
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void ConfigureIMEW([global::System.Runtime.InteropServices.In] global::System.IntPtr hKL, [global::System.Runtime.InteropServices.ComAliasName("mshtml.wireHWND")] [global::System.Runtime.InteropServices.In] ref global::mshtml._RemotableHandle hWnd, [global::System.Runtime.InteropServices.In] uint dwMode, [global::System.Runtime.InteropServices.In] ref global::mshtml.__MIDL___MIDL_itf_mshtml_0250_0002 pData);

		// Token: 0x0601620E RID: 90638
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void CreateContext(out uint phIMC);

		// Token: 0x0601620F RID: 90639
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void DestroyContext([global::System.Runtime.InteropServices.In] uint hIME);

		// Token: 0x06016210 RID: 90640
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void EnumRegisterWordA([global::System.Runtime.InteropServices.In] global::System.IntPtr hKL, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPStr)] [global::System.Runtime.InteropServices.In] string szReading, [global::System.Runtime.InteropServices.In] uint dwStyle, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPStr)] [global::System.Runtime.InteropServices.In] string szRegister, [global::System.Runtime.InteropServices.In] global::System.IntPtr pData, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] out global::mshtml.IEnumRegisterWordA pEnum);

		// Token: 0x06016211 RID: 90641
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void EnumRegisterWordW([global::System.Runtime.InteropServices.In] global::System.IntPtr hKL, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPWStr)] [global::System.Runtime.InteropServices.In] string szReading, [global::System.Runtime.InteropServices.In] uint dwStyle, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPWStr)] [global::System.Runtime.InteropServices.In] string szRegister, [global::System.Runtime.InteropServices.In] global::System.IntPtr pData, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] out global::mshtml.IEnumRegisterWordW pEnum);

		// Token: 0x06016212 RID: 90642
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void EscapeA([global::System.Runtime.InteropServices.In] global::System.IntPtr hKL, [global::System.Runtime.InteropServices.In] uint hIMC, [global::System.Runtime.InteropServices.In] uint uEscape, [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Out] global::System.IntPtr pData, [global::System.Runtime.InteropServices.ComAliasName("mshtml.LONG_PTR")] out int plResult);

		// Token: 0x06016213 RID: 90643
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void EscapeW([global::System.Runtime.InteropServices.In] global::System.IntPtr hKL, [global::System.Runtime.InteropServices.In] uint hIMC, [global::System.Runtime.InteropServices.In] uint uEscape, [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Out] global::System.IntPtr pData, [global::System.Runtime.InteropServices.ComAliasName("mshtml.LONG_PTR")] out int plResult);

		// Token: 0x06016214 RID: 90644
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void GetCandidateListA([global::System.Runtime.InteropServices.In] uint hIMC, [global::System.Runtime.InteropServices.In] uint dwIndex, [global::System.Runtime.InteropServices.In] uint uBufLen, out global::mshtml.__MIDL___MIDL_itf_mshtml_0250_0007 pCandList, out uint puCopied);

		// Token: 0x06016215 RID: 90645
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void GetCandidateListW([global::System.Runtime.InteropServices.In] uint hIMC, [global::System.Runtime.InteropServices.In] uint dwIndex, [global::System.Runtime.InteropServices.In] uint uBufLen, out global::mshtml.__MIDL___MIDL_itf_mshtml_0250_0007 pCandList, out uint puCopied);

		// Token: 0x06016216 RID: 90646
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void GetCandidateListCountA([global::System.Runtime.InteropServices.In] uint hIMC, out uint pdwListSize, out uint pdwBufLen);

		// Token: 0x06016217 RID: 90647
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void GetCandidateListCountW([global::System.Runtime.InteropServices.In] uint hIMC, out uint pdwListSize, out uint pdwBufLen);

		// Token: 0x06016218 RID: 90648
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void GetCandidateWindow([global::System.Runtime.InteropServices.In] uint hIMC, [global::System.Runtime.InteropServices.In] uint dwIndex, out global::mshtml.__MIDL___MIDL_itf_mshtml_0250_0005 pCandidate);

		// Token: 0x06016219 RID: 90649
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void GetCompositionFontA([global::System.Runtime.InteropServices.In] uint hIMC, out global::mshtml.__MIDL___MIDL_itf_mshtml_0250_0003 plf);

		// Token: 0x0601621A RID: 90650
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void GetCompositionFontW([global::System.Runtime.InteropServices.In] uint hIMC, out global::mshtml.__MIDL___MIDL_itf_mshtml_0250_0004 plf);

		// Token: 0x0601621B RID: 90651
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void GetCompositionStringA([global::System.Runtime.InteropServices.In] uint hIMC, [global::System.Runtime.InteropServices.In] uint dwIndex, [global::System.Runtime.InteropServices.In] uint dwBufLen, out int plCopied, [global::System.Runtime.InteropServices.Out] global::System.IntPtr pBuf);

		// Token: 0x0601621C RID: 90652
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void GetCompositionStringW([global::System.Runtime.InteropServices.In] uint hIMC, [global::System.Runtime.InteropServices.In] uint dwIndex, [global::System.Runtime.InteropServices.In] uint dwBufLen, out int plCopied, [global::System.Runtime.InteropServices.Out] global::System.IntPtr pBuf);

		// Token: 0x0601621D RID: 90653
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void GetCompositionWindow([global::System.Runtime.InteropServices.In] uint hIMC, out global::mshtml.__MIDL___MIDL_itf_mshtml_0250_0006 pCompForm);

		// Token: 0x0601621E RID: 90654
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void GetContext([global::System.Runtime.InteropServices.ComAliasName("mshtml.wireHWND")] [global::System.Runtime.InteropServices.In] ref global::mshtml._RemotableHandle hWnd, out uint phIMC);

		// Token: 0x0601621F RID: 90655
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void GetConversionListA([global::System.Runtime.InteropServices.In] global::System.IntPtr hKL, [global::System.Runtime.InteropServices.In] uint hIMC, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPStr)] [global::System.Runtime.InteropServices.In] string pSrc, [global::System.Runtime.InteropServices.In] uint uBufLen, [global::System.Runtime.InteropServices.In] uint uFlag, out global::mshtml.__MIDL___MIDL_itf_mshtml_0250_0007 pDst, out uint puCopied);

		// Token: 0x06016220 RID: 90656
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void GetConversionListW([global::System.Runtime.InteropServices.In] global::System.IntPtr hKL, [global::System.Runtime.InteropServices.In] uint hIMC, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPWStr)] [global::System.Runtime.InteropServices.In] string pSrc, [global::System.Runtime.InteropServices.In] uint uBufLen, [global::System.Runtime.InteropServices.In] uint uFlag, out global::mshtml.__MIDL___MIDL_itf_mshtml_0250_0007 pDst, out uint puCopied);

		// Token: 0x06016221 RID: 90657
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void GetConversionStatus([global::System.Runtime.InteropServices.In] uint hIMC, out uint pfdwConversion, out uint pfdwSentence);

		// Token: 0x06016222 RID: 90658
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void GetDefaultIMEWnd([global::System.Runtime.InteropServices.ComAliasName("mshtml.wireHWND")] [global::System.Runtime.InteropServices.In] ref global::mshtml._RemotableHandle hWnd, [global::System.Runtime.InteropServices.ComAliasName("mshtml.wireHWND")] [global::System.Runtime.InteropServices.Out] global::System.IntPtr phDefWnd);

		// Token: 0x06016223 RID: 90659
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void GetDescriptionA([global::System.Runtime.InteropServices.In] global::System.IntPtr hKL, [global::System.Runtime.InteropServices.In] uint uBufLen, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPStr)] [global::System.Runtime.InteropServices.Out] string szDescription, out uint puCopied);

		// Token: 0x06016224 RID: 90660
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void GetDescriptionW([global::System.Runtime.InteropServices.In] global::System.IntPtr hKL, [global::System.Runtime.InteropServices.In] uint uBufLen, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPWStr)] [global::System.Runtime.InteropServices.Out] string szDescription, out uint puCopied);

		// Token: 0x06016225 RID: 90661
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void GetGuideLineA([global::System.Runtime.InteropServices.In] uint hIMC, [global::System.Runtime.InteropServices.In] uint dwIndex, [global::System.Runtime.InteropServices.In] uint dwBufLen, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPStr)] [global::System.Runtime.InteropServices.Out] string pBuf, out uint pdwResult);

		// Token: 0x06016226 RID: 90662
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void GetGuideLineW([global::System.Runtime.InteropServices.In] uint hIMC, [global::System.Runtime.InteropServices.In] uint dwIndex, [global::System.Runtime.InteropServices.In] uint dwBufLen, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPWStr)] [global::System.Runtime.InteropServices.Out] string pBuf, out uint pdwResult);

		// Token: 0x06016227 RID: 90663
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void GetIMEFileNameA([global::System.Runtime.InteropServices.In] global::System.IntPtr hKL, [global::System.Runtime.InteropServices.In] uint uBufLen, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPStr)] [global::System.Runtime.InteropServices.Out] string szFileName, out uint puCopied);

		// Token: 0x06016228 RID: 90664
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void GetIMEFileNameW([global::System.Runtime.InteropServices.In] global::System.IntPtr hKL, [global::System.Runtime.InteropServices.In] uint uBufLen, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPWStr)] [global::System.Runtime.InteropServices.Out] string szFileName, out uint puCopied);

		// Token: 0x06016229 RID: 90665
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void GetOpenStatus([global::System.Runtime.InteropServices.In] uint hIMC);

		// Token: 0x0601622A RID: 90666
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void GetProperty([global::System.Runtime.InteropServices.In] global::System.IntPtr hKL, [global::System.Runtime.InteropServices.In] uint fdwIndex, out uint pdwProperty);

		// Token: 0x0601622B RID: 90667
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void GetRegisterWordStyleA([global::System.Runtime.InteropServices.In] global::System.IntPtr hKL, [global::System.Runtime.InteropServices.In] uint nItem, out global::mshtml.__MIDL___MIDL_itf_mshtml_0250_0008 pStyleBuf, out uint puCopied);

		// Token: 0x0601622C RID: 90668
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void GetRegisterWordStyleW([global::System.Runtime.InteropServices.In] global::System.IntPtr hKL, [global::System.Runtime.InteropServices.In] uint nItem, out global::mshtml.__MIDL___MIDL_itf_mshtml_0250_0009 pStyleBuf, out uint puCopied);

		// Token: 0x0601622D RID: 90669
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void GetStatusWindowPos([global::System.Runtime.InteropServices.In] uint hIMC, out global::mshtml.tagPOINT pptPos);

		// Token: 0x0601622E RID: 90670
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void GetVirtualKey([global::System.Runtime.InteropServices.ComAliasName("mshtml.wireHWND")] [global::System.Runtime.InteropServices.In] ref global::mshtml._RemotableHandle hWnd, out uint puVirtualKey);

		// Token: 0x0601622F RID: 90671
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void InstallIMEA([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPStr)] [global::System.Runtime.InteropServices.In] string szIMEFileName, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPStr)] [global::System.Runtime.InteropServices.In] string szLayoutText, out global::System.IntPtr phKL);

		// Token: 0x06016230 RID: 90672
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void InstallIMEW([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPWStr)] [global::System.Runtime.InteropServices.In] string szIMEFileName, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPWStr)] [global::System.Runtime.InteropServices.In] string szLayoutText, out global::System.IntPtr phKL);

		// Token: 0x06016231 RID: 90673
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void IsIME([global::System.Runtime.InteropServices.In] global::System.IntPtr hKL);

		// Token: 0x06016232 RID: 90674
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void IsUIMessageA([global::System.Runtime.InteropServices.ComAliasName("mshtml.wireHWND")] [global::System.Runtime.InteropServices.In] ref global::mshtml._RemotableHandle hWndIME, [global::System.Runtime.InteropServices.In] uint msg, [global::System.Runtime.InteropServices.ComAliasName("mshtml.UINT_PTR")] [global::System.Runtime.InteropServices.In] uint wParam, [global::System.Runtime.InteropServices.ComAliasName("mshtml.LONG_PTR")] [global::System.Runtime.InteropServices.In] int lParam);

		// Token: 0x06016233 RID: 90675
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void IsUIMessageW([global::System.Runtime.InteropServices.ComAliasName("mshtml.wireHWND")] [global::System.Runtime.InteropServices.In] ref global::mshtml._RemotableHandle hWndIME, [global::System.Runtime.InteropServices.In] uint msg, [global::System.Runtime.InteropServices.ComAliasName("mshtml.UINT_PTR")] [global::System.Runtime.InteropServices.In] uint wParam, [global::System.Runtime.InteropServices.ComAliasName("mshtml.LONG_PTR")] [global::System.Runtime.InteropServices.In] int lParam);

		// Token: 0x06016234 RID: 90676
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void NotifyIME([global::System.Runtime.InteropServices.In] uint hIMC, [global::System.Runtime.InteropServices.In] uint dwAction, [global::System.Runtime.InteropServices.In] uint dwIndex, [global::System.Runtime.InteropServices.In] uint dwValue);

		// Token: 0x06016235 RID: 90677
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void RegisterWordA([global::System.Runtime.InteropServices.In] global::System.IntPtr hKL, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPStr)] [global::System.Runtime.InteropServices.In] string szReading, [global::System.Runtime.InteropServices.In] uint dwStyle, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPStr)] [global::System.Runtime.InteropServices.In] string szRegister);

		// Token: 0x06016236 RID: 90678
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void RegisterWordW([global::System.Runtime.InteropServices.In] global::System.IntPtr hKL, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPWStr)] [global::System.Runtime.InteropServices.In] string szReading, [global::System.Runtime.InteropServices.In] uint dwStyle, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPWStr)] [global::System.Runtime.InteropServices.In] string szRegister);

		// Token: 0x06016237 RID: 90679
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void ReleaseContext([global::System.Runtime.InteropServices.ComAliasName("mshtml.wireHWND")] [global::System.Runtime.InteropServices.In] ref global::mshtml._RemotableHandle hWnd, [global::System.Runtime.InteropServices.In] uint hIMC);

		// Token: 0x06016238 RID: 90680
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void SetCandidateWindow([global::System.Runtime.InteropServices.In] uint hIMC, [global::System.Runtime.InteropServices.In] ref global::mshtml.__MIDL___MIDL_itf_mshtml_0250_0005 pCandidate);

		// Token: 0x06016239 RID: 90681
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void SetCompositionFontA([global::System.Runtime.InteropServices.In] uint hIMC, [global::System.Runtime.InteropServices.In] ref global::mshtml.__MIDL___MIDL_itf_mshtml_0250_0003 plf);

		// Token: 0x0601623A RID: 90682
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void SetCompositionFontW([global::System.Runtime.InteropServices.In] uint hIMC, [global::System.Runtime.InteropServices.In] ref global::mshtml.__MIDL___MIDL_itf_mshtml_0250_0004 plf);

		// Token: 0x0601623B RID: 90683
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void SetCompositionStringA([global::System.Runtime.InteropServices.In] uint hIMC, [global::System.Runtime.InteropServices.In] uint dwIndex, [global::System.Runtime.InteropServices.In] global::System.IntPtr pComp, [global::System.Runtime.InteropServices.In] uint dwCompLen, [global::System.Runtime.InteropServices.In] global::System.IntPtr pRead, [global::System.Runtime.InteropServices.In] uint dwReadLen);

		// Token: 0x0601623C RID: 90684
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void SetCompositionStringW([global::System.Runtime.InteropServices.In] uint hIMC, [global::System.Runtime.InteropServices.In] uint dwIndex, [global::System.Runtime.InteropServices.In] global::System.IntPtr pComp, [global::System.Runtime.InteropServices.In] uint dwCompLen, [global::System.Runtime.InteropServices.In] global::System.IntPtr pRead, [global::System.Runtime.InteropServices.In] uint dwReadLen);

		// Token: 0x0601623D RID: 90685
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void SetCompositionWindow([global::System.Runtime.InteropServices.In] uint hIMC, [global::System.Runtime.InteropServices.In] ref global::mshtml.__MIDL___MIDL_itf_mshtml_0250_0006 pCompForm);

		// Token: 0x0601623E RID: 90686
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void SetConversionStatus([global::System.Runtime.InteropServices.In] uint hIMC, [global::System.Runtime.InteropServices.In] uint fdwConversion, [global::System.Runtime.InteropServices.In] uint fdwSentence);

		// Token: 0x0601623F RID: 90687
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void SetOpenStatus([global::System.Runtime.InteropServices.In] uint hIMC, [global::System.Runtime.InteropServices.In] int fOpen);

		// Token: 0x06016240 RID: 90688
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void SetStatusWindowPos([global::System.Runtime.InteropServices.In] uint hIMC, [global::System.Runtime.InteropServices.In] ref global::mshtml.tagPOINT pptPos);

		// Token: 0x06016241 RID: 90689
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void SimulateHotKey([global::System.Runtime.InteropServices.ComAliasName("mshtml.wireHWND")] [global::System.Runtime.InteropServices.In] ref global::mshtml._RemotableHandle hWnd, [global::System.Runtime.InteropServices.In] uint dwHotKeyID);

		// Token: 0x06016242 RID: 90690
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void UnregisterWordA([global::System.Runtime.InteropServices.In] global::System.IntPtr hKL, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPStr)] [global::System.Runtime.InteropServices.In] string szReading, [global::System.Runtime.InteropServices.In] uint dwStyle, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPStr)] [global::System.Runtime.InteropServices.In] string szUnregister);

		// Token: 0x06016243 RID: 90691
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void UnregisterWordW([global::System.Runtime.InteropServices.In] global::System.IntPtr hKL, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPWStr)] [global::System.Runtime.InteropServices.In] string szReading, [global::System.Runtime.InteropServices.In] uint dwStyle, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPWStr)] [global::System.Runtime.InteropServices.In] string szUnregister);

		// Token: 0x06016244 RID: 90692
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void Activate([global::System.Runtime.InteropServices.In] int fRestoreLayout);

		// Token: 0x06016245 RID: 90693
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void Deactivate();

		// Token: 0x06016246 RID: 90694
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void OnDefWindowProc([global::System.Runtime.InteropServices.ComAliasName("mshtml.wireHWND")] [global::System.Runtime.InteropServices.In] ref global::mshtml._RemotableHandle hWnd, [global::System.Runtime.InteropServices.In] uint msg, [global::System.Runtime.InteropServices.ComAliasName("mshtml.UINT_PTR")] [global::System.Runtime.InteropServices.In] uint wParam, [global::System.Runtime.InteropServices.ComAliasName("mshtml.LONG_PTR")] [global::System.Runtime.InteropServices.In] int lParam, [global::System.Runtime.InteropServices.ComAliasName("mshtml.LONG_PTR")] out int plResult);

		// Token: 0x06016247 RID: 90695
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void FilterClientWindows([global::System.Runtime.InteropServices.In] ref ushort aaClassList, [global::System.Runtime.InteropServices.In] uint uSize);

		// Token: 0x06016248 RID: 90696
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void GetCodePageA([global::System.Runtime.InteropServices.In] global::System.IntPtr hKL, out uint uCodePage);

		// Token: 0x06016249 RID: 90697
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void GetLangId([global::System.Runtime.InteropServices.In] global::System.IntPtr hKL, out ushort plid);

		// Token: 0x0601624A RID: 90698
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void AssociateContextEx([global::System.Runtime.InteropServices.ComAliasName("mshtml.wireHWND")] [global::System.Runtime.InteropServices.In] ref global::mshtml._RemotableHandle hWnd, [global::System.Runtime.InteropServices.In] uint hIMC, [global::System.Runtime.InteropServices.In] uint dwFlags);

		// Token: 0x0601624B RID: 90699
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void DisableIME([global::System.Runtime.InteropServices.In] uint idThread);

		// Token: 0x0601624C RID: 90700
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void GetImeMenuItemsA([global::System.Runtime.InteropServices.In] uint hIMC, [global::System.Runtime.InteropServices.In] uint dwFlags, [global::System.Runtime.InteropServices.In] uint dwType, [global::System.Runtime.InteropServices.In] ref global::mshtml.__MIDL___MIDL_itf_mshtml_0250_0010 pImeParentMenu, out global::mshtml.__MIDL___MIDL_itf_mshtml_0250_0010 pImeMenu, [global::System.Runtime.InteropServices.In] uint dwSize, out uint pdwResult);

		// Token: 0x0601624D RID: 90701
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void GetImeMenuItemsW([global::System.Runtime.InteropServices.In] uint hIMC, [global::System.Runtime.InteropServices.In] uint dwFlags, [global::System.Runtime.InteropServices.In] uint dwType, [global::System.Runtime.InteropServices.In] ref global::mshtml.__MIDL___MIDL_itf_mshtml_0250_0011 pImeParentMenu, out global::mshtml.__MIDL___MIDL_itf_mshtml_0250_0011 pImeMenu, [global::System.Runtime.InteropServices.In] uint dwSize, out uint pdwResult);

		// Token: 0x0601624E RID: 90702
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void EnumInputContext([global::System.Runtime.InteropServices.In] uint idThread, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] out global::mshtml.IEnumInputContext ppEnum);
	}
}
