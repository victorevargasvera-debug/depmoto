using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SHDocVw
{
	// Token: 0x02000065 RID: 101
	[global::System.Runtime.InteropServices.TypeLibType(4176)]
	[global::System.Runtime.InteropServices.Guid("72423E8F-8011-11D2-BE79-00A0C9A83DA3")]
	[global::System.Runtime.InteropServices.ComImport]
	public interface ISearchAssistantOC3 : global::SHDocVw.ISearchAssistantOC2
	{
		// Token: 0x0600059D RID: 1437
		[global::System.Runtime.InteropServices.DispId(1)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void AddNextMenuItem([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string bstrText, [global::System.Runtime.InteropServices.In] int idItem);

		// Token: 0x0600059E RID: 1438
		[global::System.Runtime.InteropServices.DispId(2)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void SetDefaultSearchUrl([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string bstrUrl);

		// Token: 0x0600059F RID: 1439
		[global::System.Runtime.InteropServices.DispId(3)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void NavigateToDefaultSearch();

		// Token: 0x060005A0 RID: 1440
		[global::System.Runtime.InteropServices.DispId(4)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		bool IsRestricted([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string bstrGuid);

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x060005A1 RID: 1441
		[global::System.Runtime.InteropServices.DispId(5)]
		bool ShellFeaturesEnabled { [global::System.Runtime.InteropServices.DispId(5)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x060005A2 RID: 1442
		[global::System.Runtime.InteropServices.DispId(6)]
		bool SearchAssistantDefault { [global::System.Runtime.InteropServices.DispId(6)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x060005A3 RID: 1443
		[global::System.Runtime.InteropServices.DispId(7)]
		global::SHDocVw.ISearches Searches { [global::System.Runtime.InteropServices.DispId(7)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x060005A4 RID: 1444
		[global::System.Runtime.InteropServices.DispId(8)]
		bool InWebFolder { [global::System.Runtime.InteropServices.DispId(8)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x060005A5 RID: 1445
		[global::System.Runtime.InteropServices.DispId(9)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void PutProperty([global::System.Runtime.InteropServices.In] bool bPerLocale, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string bstrName, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string bstrValue);

		// Token: 0x060005A6 RID: 1446
		[global::System.Runtime.InteropServices.DispId(10)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		string GetProperty([global::System.Runtime.InteropServices.In] bool bPerLocale, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string bstrName);

		// Token: 0x17000139 RID: 313
		// (set) Token: 0x060005A7 RID: 1447
		[global::System.Runtime.InteropServices.DispId(11)]
		bool EventHandled { [global::System.Runtime.InteropServices.DispId(11)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x060005A8 RID: 1448
		[global::System.Runtime.InteropServices.DispId(12)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void ResetNextMenu();

		// Token: 0x060005A9 RID: 1449
		[global::System.Runtime.InteropServices.DispId(13)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void FindOnWeb();

		// Token: 0x060005AA RID: 1450
		[global::System.Runtime.InteropServices.DispId(14)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void FindFilesOrFolders();

		// Token: 0x060005AB RID: 1451
		[global::System.Runtime.InteropServices.DispId(15)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void FindComputer();

		// Token: 0x060005AC RID: 1452
		[global::System.Runtime.InteropServices.DispId(16)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void FindPrinter();

		// Token: 0x060005AD RID: 1453
		[global::System.Runtime.InteropServices.DispId(17)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void FindPeople();

		// Token: 0x060005AE RID: 1454
		[global::System.Runtime.InteropServices.DispId(18)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		string GetSearchAssistantURL([global::System.Runtime.InteropServices.In] bool bSubstitute, [global::System.Runtime.InteropServices.In] bool bCustomize);

		// Token: 0x060005AF RID: 1455
		[global::System.Runtime.InteropServices.DispId(19)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void NotifySearchSettingsChanged();

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x060005B1 RID: 1457
		// (set) Token: 0x060005B0 RID: 1456
		[global::System.Runtime.InteropServices.DispId(20)]
		string ASProvider { [global::System.Runtime.InteropServices.DispId(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x060005B3 RID: 1459
		// (set) Token: 0x060005B2 RID: 1458
		[global::System.Runtime.InteropServices.DispId(21)]
		int ASSetting { [global::System.Runtime.InteropServices.DispId(21)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(21)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x060005B4 RID: 1460
		[global::System.Runtime.InteropServices.DispId(22)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void NETDetectNextNavigate();

		// Token: 0x060005B5 RID: 1461
		[global::System.Runtime.InteropServices.DispId(23)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void PutFindText([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string FindText);

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x060005B6 RID: 1462
		[global::System.Runtime.InteropServices.DispId(24)]
		int Version { [global::System.Runtime.InteropServices.DispId(24)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x060005B7 RID: 1463
		[global::System.Runtime.InteropServices.DispId(25)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		string EncodeString([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string bstrValue, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string bstrCharSet, [global::System.Runtime.InteropServices.In] bool bUseUTF8);

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x060005B8 RID: 1464
		[global::System.Runtime.InteropServices.DispId(26)]
		bool ShowFindPrinter { [global::System.Runtime.InteropServices.DispId(26)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x060005B9 RID: 1465
		[global::System.Runtime.InteropServices.DispId(27)]
		bool SearchCompanionAvailable { [global::System.Runtime.InteropServices.DispId(27)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x060005BB RID: 1467
		// (set) Token: 0x060005BA RID: 1466
		[global::System.Runtime.InteropServices.DispId(28)]
		bool UseSearchCompanion { [global::System.Runtime.InteropServices.DispId(28)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(28)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }
	}
}
