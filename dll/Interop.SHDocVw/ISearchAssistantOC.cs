using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SHDocVw
{
	// Token: 0x02000063 RID: 99
	[global::System.Runtime.InteropServices.Guid("72423E8F-8011-11D2-BE79-00A0C9A83DA1")]
	[global::System.Runtime.InteropServices.TypeLibType(4176)]
	[global::System.Runtime.InteropServices.ComImport]
	public interface ISearchAssistantOC
	{
		// Token: 0x06000566 RID: 1382
		[global::System.Runtime.InteropServices.DispId(1)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void AddNextMenuItem([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string bstrText, [global::System.Runtime.InteropServices.In] int idItem);

		// Token: 0x06000567 RID: 1383
		[global::System.Runtime.InteropServices.DispId(2)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void SetDefaultSearchUrl([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string bstrUrl);

		// Token: 0x06000568 RID: 1384
		[global::System.Runtime.InteropServices.DispId(3)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void NavigateToDefaultSearch();

		// Token: 0x06000569 RID: 1385
		[global::System.Runtime.InteropServices.DispId(4)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		bool IsRestricted([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string bstrGuid);

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x0600056A RID: 1386
		[global::System.Runtime.InteropServices.DispId(5)]
		bool ShellFeaturesEnabled { [global::System.Runtime.InteropServices.DispId(5)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x0600056B RID: 1387
		[global::System.Runtime.InteropServices.DispId(6)]
		bool SearchAssistantDefault { [global::System.Runtime.InteropServices.DispId(6)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x0600056C RID: 1388
		[global::System.Runtime.InteropServices.DispId(7)]
		global::SHDocVw.ISearches Searches { [global::System.Runtime.InteropServices.DispId(7)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x0600056D RID: 1389
		[global::System.Runtime.InteropServices.DispId(8)]
		bool InWebFolder { [global::System.Runtime.InteropServices.DispId(8)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x0600056E RID: 1390
		[global::System.Runtime.InteropServices.DispId(9)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void PutProperty([global::System.Runtime.InteropServices.In] bool bPerLocale, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string bstrName, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string bstrValue);

		// Token: 0x0600056F RID: 1391
		[global::System.Runtime.InteropServices.DispId(10)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		string GetProperty([global::System.Runtime.InteropServices.In] bool bPerLocale, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string bstrName);

		// Token: 0x17000128 RID: 296
		// (set) Token: 0x06000570 RID: 1392
		[global::System.Runtime.InteropServices.DispId(11)]
		bool EventHandled { [global::System.Runtime.InteropServices.DispId(11)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x06000571 RID: 1393
		[global::System.Runtime.InteropServices.DispId(12)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void ResetNextMenu();

		// Token: 0x06000572 RID: 1394
		[global::System.Runtime.InteropServices.DispId(13)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void FindOnWeb();

		// Token: 0x06000573 RID: 1395
		[global::System.Runtime.InteropServices.DispId(14)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void FindFilesOrFolders();

		// Token: 0x06000574 RID: 1396
		[global::System.Runtime.InteropServices.DispId(15)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void FindComputer();

		// Token: 0x06000575 RID: 1397
		[global::System.Runtime.InteropServices.DispId(16)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void FindPrinter();

		// Token: 0x06000576 RID: 1398
		[global::System.Runtime.InteropServices.DispId(17)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void FindPeople();

		// Token: 0x06000577 RID: 1399
		[global::System.Runtime.InteropServices.DispId(18)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		string GetSearchAssistantURL([global::System.Runtime.InteropServices.In] bool bSubstitute, [global::System.Runtime.InteropServices.In] bool bCustomize);

		// Token: 0x06000578 RID: 1400
		[global::System.Runtime.InteropServices.DispId(19)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void NotifySearchSettingsChanged();

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x0600057A RID: 1402
		// (set) Token: 0x06000579 RID: 1401
		[global::System.Runtime.InteropServices.DispId(20)]
		string ASProvider { [global::System.Runtime.InteropServices.DispId(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x0600057C RID: 1404
		// (set) Token: 0x0600057B RID: 1403
		[global::System.Runtime.InteropServices.DispId(21)]
		int ASSetting { [global::System.Runtime.InteropServices.DispId(21)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(21)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x0600057D RID: 1405
		[global::System.Runtime.InteropServices.DispId(22)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void NETDetectNextNavigate();

		// Token: 0x0600057E RID: 1406
		[global::System.Runtime.InteropServices.DispId(23)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void PutFindText([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string FindText);

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x0600057F RID: 1407
		[global::System.Runtime.InteropServices.DispId(24)]
		int Version { [global::System.Runtime.InteropServices.DispId(24)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000580 RID: 1408
		[global::System.Runtime.InteropServices.DispId(25)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		string EncodeString([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string bstrValue, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string bstrCharSet, [global::System.Runtime.InteropServices.In] bool bUseUTF8);
	}
}
