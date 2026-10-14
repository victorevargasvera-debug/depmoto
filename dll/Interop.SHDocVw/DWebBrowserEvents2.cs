using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SHDocVw
{
	// Token: 0x0200000C RID: 12
	[global::System.Runtime.InteropServices.InterfaceType(2)]
	[global::System.Runtime.InteropServices.Guid("34A715A0-6587-11D0-924A-0020AFC7AC4D")]
	[global::System.Runtime.InteropServices.TypeLibType(4112)]
	[global::System.Runtime.InteropServices.ComImport]
	public interface DWebBrowserEvents2
	{
		// Token: 0x06000098 RID: 152
		[global::System.Runtime.InteropServices.DispId(102)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void StatusTextChange([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string Text);

		// Token: 0x06000099 RID: 153
		[global::System.Runtime.InteropServices.DispId(108)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void ProgressChange([global::System.Runtime.InteropServices.In] int Progress, [global::System.Runtime.InteropServices.In] int ProgressMax);

		// Token: 0x0600009A RID: 154
		[global::System.Runtime.InteropServices.DispId(105)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void CommandStateChange([global::System.Runtime.InteropServices.In] int Command, [global::System.Runtime.InteropServices.In] bool Enable);

		// Token: 0x0600009B RID: 155
		[global::System.Runtime.InteropServices.DispId(106)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void DownloadBegin();

		// Token: 0x0600009C RID: 156
		[global::System.Runtime.InteropServices.DispId(104)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void DownloadComplete();

		// Token: 0x0600009D RID: 157
		[global::System.Runtime.InteropServices.DispId(113)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void TitleChange([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string Text);

		// Token: 0x0600009E RID: 158
		[global::System.Runtime.InteropServices.DispId(112)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void PropertyChange([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string szProperty);

		// Token: 0x0600009F RID: 159
		[global::System.Runtime.InteropServices.DispId(250)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void BeforeNavigate2([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] [global::System.Runtime.InteropServices.In] object pDisp, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] ref object URL, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] ref object Flags, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] ref object TargetFrameName, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] ref object PostData, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] ref object Headers, [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Out] ref bool Cancel);

		// Token: 0x060000A0 RID: 160
		[global::System.Runtime.InteropServices.DispId(251)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void NewWindow2([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Out] ref object ppDisp, [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Out] ref bool Cancel);

		// Token: 0x060000A1 RID: 161
		[global::System.Runtime.InteropServices.DispId(252)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void NavigateComplete2([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] [global::System.Runtime.InteropServices.In] object pDisp, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] ref object URL);

		// Token: 0x060000A2 RID: 162
		[global::System.Runtime.InteropServices.DispId(259)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void DocumentComplete([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] [global::System.Runtime.InteropServices.In] object pDisp, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] ref object URL);

		// Token: 0x060000A3 RID: 163
		[global::System.Runtime.InteropServices.DispId(253)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void OnQuit();

		// Token: 0x060000A4 RID: 164
		[global::System.Runtime.InteropServices.DispId(254)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void OnVisible([global::System.Runtime.InteropServices.In] bool Visible);

		// Token: 0x060000A5 RID: 165
		[global::System.Runtime.InteropServices.DispId(255)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void OnToolBar([global::System.Runtime.InteropServices.In] bool ToolBar);

		// Token: 0x060000A6 RID: 166
		[global::System.Runtime.InteropServices.DispId(256)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void OnMenuBar([global::System.Runtime.InteropServices.In] bool MenuBar);

		// Token: 0x060000A7 RID: 167
		[global::System.Runtime.InteropServices.DispId(257)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void OnStatusBar([global::System.Runtime.InteropServices.In] bool StatusBar);

		// Token: 0x060000A8 RID: 168
		[global::System.Runtime.InteropServices.DispId(258)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void OnFullScreen([global::System.Runtime.InteropServices.In] bool FullScreen);

		// Token: 0x060000A9 RID: 169
		[global::System.Runtime.InteropServices.DispId(260)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void OnTheaterMode([global::System.Runtime.InteropServices.In] bool TheaterMode);

		// Token: 0x060000AA RID: 170
		[global::System.Runtime.InteropServices.DispId(262)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void WindowSetResizable([global::System.Runtime.InteropServices.In] bool Resizable);

		// Token: 0x060000AB RID: 171
		[global::System.Runtime.InteropServices.DispId(264)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void WindowSetLeft([global::System.Runtime.InteropServices.In] int Left);

		// Token: 0x060000AC RID: 172
		[global::System.Runtime.InteropServices.DispId(265)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void WindowSetTop([global::System.Runtime.InteropServices.In] int Top);

		// Token: 0x060000AD RID: 173
		[global::System.Runtime.InteropServices.DispId(266)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void WindowSetWidth([global::System.Runtime.InteropServices.In] int Width);

		// Token: 0x060000AE RID: 174
		[global::System.Runtime.InteropServices.DispId(267)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void WindowSetHeight([global::System.Runtime.InteropServices.In] int Height);

		// Token: 0x060000AF RID: 175
		[global::System.Runtime.InteropServices.DispId(263)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void WindowClosing([global::System.Runtime.InteropServices.In] bool IsChildWindow, [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Out] ref bool Cancel);

		// Token: 0x060000B0 RID: 176
		[global::System.Runtime.InteropServices.DispId(268)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void ClientToHostWindow([global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Out] ref int CX, [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Out] ref int CY);

		// Token: 0x060000B1 RID: 177
		[global::System.Runtime.InteropServices.DispId(269)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void SetSecureLockIcon([global::System.Runtime.InteropServices.In] int SecureLockIcon);

		// Token: 0x060000B2 RID: 178
		[global::System.Runtime.InteropServices.DispId(270)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void FileDownload([global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Out] ref bool Cancel);

		// Token: 0x060000B3 RID: 179
		[global::System.Runtime.InteropServices.DispId(271)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void NavigateError([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] [global::System.Runtime.InteropServices.In] object pDisp, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] ref object URL, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] ref object Frame, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] ref object StatusCode, [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Out] ref bool Cancel);

		// Token: 0x060000B4 RID: 180
		[global::System.Runtime.InteropServices.DispId(225)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void PrintTemplateInstantiation([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] [global::System.Runtime.InteropServices.In] object pDisp);

		// Token: 0x060000B5 RID: 181
		[global::System.Runtime.InteropServices.DispId(226)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void PrintTemplateTeardown([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] [global::System.Runtime.InteropServices.In] object pDisp);

		// Token: 0x060000B6 RID: 182
		[global::System.Runtime.InteropServices.DispId(227)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void UpdatePageStatus([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] [global::System.Runtime.InteropServices.In] object pDisp, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] ref object nPage, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] ref object fDone);

		// Token: 0x060000B7 RID: 183
		[global::System.Runtime.InteropServices.DispId(272)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void PrivacyImpactedStateChange([global::System.Runtime.InteropServices.In] bool bImpacted);
	}
}
