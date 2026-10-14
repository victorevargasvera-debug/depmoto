using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SHDocVw
{
	// Token: 0x02000067 RID: 103
	[global::System.Runtime.InteropServices.ComSourceInterfaces("SHDocVw._SearchAssistantEvents\0\0")]
	[global::System.Runtime.InteropServices.TypeLibType(18)]
	[global::System.Runtime.InteropServices.Guid("B45FF030-4447-11D2-85DE-00C04FA35C89")]
	[global::System.Runtime.InteropServices.ClassInterface(0)]
	[global::System.Runtime.InteropServices.ComImport]
	public class SearchAssistantOCClass : global::SHDocVw.ISearchAssistantOC3, global::SHDocVw.SearchAssistantOC, global::SHDocVw._SearchAssistantEvents_Event
	{
		// Token: 0x060005BE RID: 1470
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public extern SearchAssistantOCClass();

		// Token: 0x060005BF RID: 1471
		[global::System.Runtime.InteropServices.DispId(1)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void AddNextMenuItem([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string bstrText, [global::System.Runtime.InteropServices.In] int idItem);

		// Token: 0x060005C0 RID: 1472
		[global::System.Runtime.InteropServices.DispId(2)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void SetDefaultSearchUrl([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string bstrUrl);

		// Token: 0x060005C1 RID: 1473
		[global::System.Runtime.InteropServices.DispId(3)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void NavigateToDefaultSearch();

		// Token: 0x060005C2 RID: 1474
		[global::System.Runtime.InteropServices.DispId(4)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern bool IsRestricted([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string bstrGuid);

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x060005C3 RID: 1475
		[global::System.Runtime.InteropServices.DispId(5)]
		public virtual extern bool ShellFeaturesEnabled { [global::System.Runtime.InteropServices.DispId(5)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x060005C4 RID: 1476
		[global::System.Runtime.InteropServices.DispId(6)]
		public virtual extern bool SearchAssistantDefault { [global::System.Runtime.InteropServices.DispId(6)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x060005C5 RID: 1477
		[global::System.Runtime.InteropServices.DispId(7)]
		public virtual extern global::SHDocVw.ISearches Searches { [global::System.Runtime.InteropServices.DispId(7)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x060005C6 RID: 1478
		[global::System.Runtime.InteropServices.DispId(8)]
		public virtual extern bool InWebFolder { [global::System.Runtime.InteropServices.DispId(8)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x060005C7 RID: 1479
		[global::System.Runtime.InteropServices.DispId(9)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void PutProperty([global::System.Runtime.InteropServices.In] bool bPerLocale, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string bstrName, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string bstrValue);

		// Token: 0x060005C8 RID: 1480
		[global::System.Runtime.InteropServices.DispId(10)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public virtual extern string GetProperty([global::System.Runtime.InteropServices.In] bool bPerLocale, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string bstrName);

		// Token: 0x17000144 RID: 324
		// (set) Token: 0x060005C9 RID: 1481
		[global::System.Runtime.InteropServices.DispId(11)]
		public virtual extern bool EventHandled { [global::System.Runtime.InteropServices.DispId(11)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x060005CA RID: 1482
		[global::System.Runtime.InteropServices.DispId(12)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void ResetNextMenu();

		// Token: 0x060005CB RID: 1483
		[global::System.Runtime.InteropServices.DispId(13)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void FindOnWeb();

		// Token: 0x060005CC RID: 1484
		[global::System.Runtime.InteropServices.DispId(14)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void FindFilesOrFolders();

		// Token: 0x060005CD RID: 1485
		[global::System.Runtime.InteropServices.DispId(15)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void FindComputer();

		// Token: 0x060005CE RID: 1486
		[global::System.Runtime.InteropServices.DispId(16)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void FindPrinter();

		// Token: 0x060005CF RID: 1487
		[global::System.Runtime.InteropServices.DispId(17)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void FindPeople();

		// Token: 0x060005D0 RID: 1488
		[global::System.Runtime.InteropServices.DispId(18)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public virtual extern string GetSearchAssistantURL([global::System.Runtime.InteropServices.In] bool bSubstitute, [global::System.Runtime.InteropServices.In] bool bCustomize);

		// Token: 0x060005D1 RID: 1489
		[global::System.Runtime.InteropServices.DispId(19)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void NotifySearchSettingsChanged();

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x060005D3 RID: 1491
		// (set) Token: 0x060005D2 RID: 1490
		[global::System.Runtime.InteropServices.DispId(20)]
		public virtual extern string ASProvider { [global::System.Runtime.InteropServices.DispId(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x060005D5 RID: 1493
		// (set) Token: 0x060005D4 RID: 1492
		[global::System.Runtime.InteropServices.DispId(21)]
		public virtual extern int ASSetting { [global::System.Runtime.InteropServices.DispId(21)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(21)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x060005D6 RID: 1494
		[global::System.Runtime.InteropServices.DispId(22)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void NETDetectNextNavigate();

		// Token: 0x060005D7 RID: 1495
		[global::System.Runtime.InteropServices.DispId(23)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void PutFindText([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string FindText);

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x060005D8 RID: 1496
		[global::System.Runtime.InteropServices.DispId(24)]
		public virtual extern int Version { [global::System.Runtime.InteropServices.DispId(24)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x060005D9 RID: 1497
		[global::System.Runtime.InteropServices.DispId(25)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public virtual extern string EncodeString([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string bstrValue, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string bstrCharSet, [global::System.Runtime.InteropServices.In] bool bUseUTF8);

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x060005DA RID: 1498
		[global::System.Runtime.InteropServices.DispId(26)]
		public virtual extern bool ShowFindPrinter { [global::System.Runtime.InteropServices.DispId(26)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x060005DB RID: 1499
		[global::System.Runtime.InteropServices.DispId(27)]
		public virtual extern bool SearchCompanionAvailable { [global::System.Runtime.InteropServices.DispId(27)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x060005DD RID: 1501
		// (set) Token: 0x060005DC RID: 1500
		[global::System.Runtime.InteropServices.DispId(28)]
		public virtual extern bool UseSearchCompanion { [global::System.Runtime.InteropServices.DispId(28)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(28)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x14000102 RID: 258
		// (add) Token: 0x060005DE RID: 1502
		// (remove) Token: 0x060005DF RID: 1503
		public virtual extern event global::SHDocVw._SearchAssistantEvents_OnNextMenuSelectEventHandler OnNextMenuSelect;

		// Token: 0x14000103 RID: 259
		// (add) Token: 0x060005E0 RID: 1504
		// (remove) Token: 0x060005E1 RID: 1505
		public virtual extern event global::SHDocVw._SearchAssistantEvents_OnNewSearchEventHandler OnNewSearch;
	}
}
