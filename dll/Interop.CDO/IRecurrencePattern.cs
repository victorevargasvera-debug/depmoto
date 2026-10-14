using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace CDO
{
	// Token: 0x02000061 RID: 97
	[global::System.Runtime.InteropServices.Guid("CD000123-8B95-11D1-82DB-00C04FB1625D")]
	[global::System.Runtime.InteropServices.TypeLibType(4288)]
	[global::System.Runtime.InteropServices.ComImport]
	public interface IRecurrencePattern
	{
		// Token: 0x170000DA RID: 218
		// (get) Token: 0x060001EB RID: 491
		// (set) Token: 0x060001EC RID: 492
		[global::System.Runtime.InteropServices.DispId(1)]
		int Interval { [global::System.Runtime.InteropServices.DispId(1)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(1)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x060001ED RID: 493
		// (set) Token: 0x060001EE RID: 494
		[global::System.Runtime.InteropServices.DispId(2)]
		int Instances { [global::System.Runtime.InteropServices.DispId(2)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(2)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x060001EF RID: 495
		// (set) Token: 0x060001F0 RID: 496
		[global::System.Runtime.InteropServices.DispId(3)]
		global::CDO.CdoFrequency Frequency { [global::System.Runtime.InteropServices.DispId(3)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(3)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x060001F1 RID: 497
		// (set) Token: 0x060001F2 RID: 498
		[global::System.Runtime.InteropServices.DispId(4)]
		global::System.DateTime PatternEndDate { [global::System.Runtime.InteropServices.DispId(4)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(4)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x060001F3 RID: 499
		[global::System.Runtime.InteropServices.DispId(6)]
		string Type { [global::System.Runtime.InteropServices.DispId(6)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x060001F4 RID: 500
		// (set) Token: 0x060001F5 RID: 501
		[global::System.Runtime.InteropServices.DispId(7)]
		global::CDO.CdoPatternEndType EndType { [global::System.Runtime.InteropServices.DispId(7)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(7)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x060001F6 RID: 502
		// (set) Token: 0x060001F7 RID: 503
		[global::System.Runtime.InteropServices.DispId(8)]
		global::CDO.CdoDayOfWeek FirstDayOfWeek { [global::System.Runtime.InteropServices.DispId(8)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(8)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x060001F8 RID: 504
		[global::System.Runtime.InteropServices.DispId(9)]
		global::CDO.IIntegers DaysOfMonth { [global::System.Runtime.InteropServices.DispId(9)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x060001F9 RID: 505
		[global::System.Runtime.InteropServices.DispId(10)]
		global::CDO.IIntegers DaysOfWeek { [global::System.Runtime.InteropServices.DispId(10)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x060001FA RID: 506
		[global::System.Runtime.InteropServices.DispId(11)]
		global::CDO.IIntegers DaysOfYear { [global::System.Runtime.InteropServices.DispId(11)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x060001FB RID: 507
		[global::System.Runtime.InteropServices.DispId(12)]
		global::CDO.IIntegers SecondsOfMinute { [global::System.Runtime.InteropServices.DispId(12)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x060001FC RID: 508
		[global::System.Runtime.InteropServices.DispId(13)]
		global::CDO.IIntegers MinutesOfHour { [global::System.Runtime.InteropServices.DispId(13)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x060001FD RID: 509
		[global::System.Runtime.InteropServices.DispId(14)]
		global::CDO.IIntegers HoursOfDay { [global::System.Runtime.InteropServices.DispId(14)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x060001FE RID: 510
		[global::System.Runtime.InteropServices.DispId(15)]
		global::CDO.IVariants WeekDays { [global::System.Runtime.InteropServices.DispId(15)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x060001FF RID: 511
		[global::System.Runtime.InteropServices.DispId(16)]
		global::CDO.IIntegers WeeksOfYear { [global::System.Runtime.InteropServices.DispId(16)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000200 RID: 512
		[global::System.Runtime.InteropServices.DispId(17)]
		global::CDO.IIntegers MonthsOfYear { [global::System.Runtime.InteropServices.DispId(17)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000201 RID: 513
		[global::System.Runtime.InteropServices.DispId(18)]
		global::CDO.IIntegers ByPosition { [global::System.Runtime.InteropServices.DispId(18)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }
	}
}
