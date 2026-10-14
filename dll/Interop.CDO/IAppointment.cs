using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ADODB;

namespace CDO
{
	// Token: 0x0200005B RID: 91
	[global::System.Runtime.InteropServices.Guid("CD000120-8B95-11D1-82DB-00C04FB1625D")]
	[global::System.Runtime.InteropServices.TypeLibType(4288)]
	[global::System.Runtime.InteropServices.ComImport]
	public interface IAppointment
	{
		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000186 RID: 390
		[global::System.Runtime.InteropServices.DispId(2)]
		global::CDO.IBodyParts Attachments { [global::System.Runtime.InteropServices.DispId(2)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000187 RID: 391
		[global::System.Runtime.InteropServices.DispId(3)]
		global::CDO.IAttendees Attendees { [global::System.Runtime.InteropServices.DispId(3)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000188 RID: 392
		// (set) Token: 0x06000189 RID: 393
		[global::System.Runtime.InteropServices.DispId(5)]
		string BusyStatus { [global::System.Runtime.InteropServices.DispId(5)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(5)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x0600018A RID: 394
		// (set) Token: 0x0600018B RID: 395
		[global::System.Runtime.InteropServices.DispId(6)]
		object Keywords { [global::System.Runtime.InteropServices.DispId(6)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(6)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x0600018C RID: 396
		// (set) Token: 0x0600018E RID: 398
		[global::System.Runtime.InteropServices.DispId(8)]
		global::CDO.Configuration Configuration { [global::System.Runtime.InteropServices.DispId(8)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; [global::System.Runtime.InteropServices.DispId(8)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x0600018F RID: 399
		// (set) Token: 0x06000190 RID: 400
		[global::System.Runtime.InteropServices.DispId(9)]
		string Contact { [global::System.Runtime.InteropServices.DispId(9)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(9)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000191 RID: 401
		// (set) Token: 0x06000192 RID: 402
		[global::System.Runtime.InteropServices.DispId(10)]
		string ContactURL { [global::System.Runtime.InteropServices.DispId(10)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(10)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06000193 RID: 403
		[global::System.Runtime.InteropServices.DispId(15)]
		global::CDO.IDataSource DataSource { [global::System.Runtime.InteropServices.DispId(15)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000194 RID: 404
		// (set) Token: 0x06000195 RID: 405
		[global::System.Runtime.InteropServices.DispId(18)]
		global::System.DateTime EndTime { [global::System.Runtime.InteropServices.DispId(18)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(18)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000196 RID: 406
		[global::System.Runtime.InteropServices.DispId(19)]
		global::CDO.IExceptions Exceptions { [global::System.Runtime.InteropServices.DispId(19)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000197 RID: 407
		// (set) Token: 0x06000198 RID: 408
		[global::System.Runtime.InteropServices.DispId(21)]
		int Duration { [global::System.Runtime.InteropServices.DispId(21)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(21)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x06000199 RID: 409
		[global::System.Runtime.InteropServices.DispId(22)]
		global::ADODB.Fields Fields { [global::System.Runtime.InteropServices.DispId(22)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x0600019A RID: 410
		// (set) Token: 0x0600019B RID: 411
		[global::System.Runtime.InteropServices.DispId(27)]
		string Location { [global::System.Runtime.InteropServices.DispId(27)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(27)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x0600019C RID: 412
		// (set) Token: 0x0600019D RID: 413
		[global::System.Runtime.InteropServices.DispId(28)]
		string LocationURL { [global::System.Runtime.InteropServices.DispId(28)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(28)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x0600019E RID: 414
		// (set) Token: 0x0600019F RID: 415
		[global::System.Runtime.InteropServices.DispId(34)]
		int Priority { [global::System.Runtime.InteropServices.DispId(34)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(34)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060001A0 RID: 416
		[global::System.Runtime.InteropServices.DispId(38)]
		global::System.DateTime ReplyTime { [global::System.Runtime.InteropServices.DispId(38)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060001A1 RID: 417
		// (set) Token: 0x060001A2 RID: 418
		[global::System.Runtime.InteropServices.DispId(39)]
		string Resources { [global::System.Runtime.InteropServices.DispId(39)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(39)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060001A3 RID: 419
		// (set) Token: 0x060001A4 RID: 420
		[global::System.Runtime.InteropServices.DispId(40)]
		bool ResponseRequested { [global::System.Runtime.InteropServices.DispId(40)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(40)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060001A5 RID: 421
		[global::System.Runtime.InteropServices.DispId(41)]
		global::CDO.IRecurrencePatterns RecurrencePatterns { [global::System.Runtime.InteropServices.DispId(41)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060001A6 RID: 422
		// (set) Token: 0x060001A7 RID: 423
		[global::System.Runtime.InteropServices.DispId(42)]
		int Sensitivity { [global::System.Runtime.InteropServices.DispId(42)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(42)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060001A8 RID: 424
		// (set) Token: 0x060001A9 RID: 425
		[global::System.Runtime.InteropServices.DispId(44)]
		global::System.DateTime StartTime { [global::System.Runtime.InteropServices.DispId(44)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(44)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060001AA RID: 426
		// (set) Token: 0x060001AB RID: 427
		[global::System.Runtime.InteropServices.DispId(45)]
		string MeetingStatus { [global::System.Runtime.InteropServices.DispId(45)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(45)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060001AC RID: 428
		// (set) Token: 0x060001AD RID: 429
		[global::System.Runtime.InteropServices.DispId(46)]
		string Subject { [global::System.Runtime.InteropServices.DispId(46)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(46)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060001AE RID: 430
		// (set) Token: 0x060001AF RID: 431
		[global::System.Runtime.InteropServices.DispId(48)]
		string Transparent { [global::System.Runtime.InteropServices.DispId(48)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(48)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060001B0 RID: 432
		[global::System.Runtime.InteropServices.DispId(52)]
		global::CDO.IBodyPart BodyPart { [global::System.Runtime.InteropServices.DispId(52)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060001B1 RID: 433
		// (set) Token: 0x060001B2 RID: 434
		[global::System.Runtime.InteropServices.DispId(54)]
		double GEOLatitude { [global::System.Runtime.InteropServices.DispId(54)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(54)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x060001B3 RID: 435
		// (set) Token: 0x060001B4 RID: 436
		[global::System.Runtime.InteropServices.DispId(55)]
		double GEOLongitude { [global::System.Runtime.InteropServices.DispId(55)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(55)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x060001B5 RID: 437
		// (set) Token: 0x060001B6 RID: 438
		[global::System.Runtime.InteropServices.DispId(56)]
		bool AllDayEvent { [global::System.Runtime.InteropServices.DispId(56)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(56)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x060001B7 RID: 439
		// (set) Token: 0x060001B8 RID: 440
		[global::System.Runtime.InteropServices.DispId(61)]
		string TextBody { [global::System.Runtime.InteropServices.DispId(61)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(61)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x060001B9 RID: 441
		// (set) Token: 0x060001BA RID: 442
		[global::System.Runtime.InteropServices.DispId(62)]
		string ResponseText { [global::System.Runtime.InteropServices.DispId(62)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(62)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x060001BB RID: 443
		[global::System.Runtime.InteropServices.DispId(201)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		global::CDO.CalendarMessage Accept();

		// Token: 0x060001BC RID: 444
		[global::System.Runtime.InteropServices.DispId(202)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		global::CDO.CalendarMessage AcceptTentative();

		// Token: 0x060001BD RID: 445
		[global::System.Runtime.InteropServices.DispId(203)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		global::CDO.CalendarMessage Cancel([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] string EmailList, [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] bool CleanupCalendar, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] string UserName, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] string Password);

		// Token: 0x060001BE RID: 446
		[global::System.Runtime.InteropServices.DispId(205)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		global::CDO.CalendarMessage CreateRequest();

		// Token: 0x060001BF RID: 447
		[global::System.Runtime.InteropServices.DispId(206)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		global::CDO.CalendarMessage Decline([global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] bool CleanupCalendar, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] string UserName, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] string Password);

		// Token: 0x060001C0 RID: 448
		[global::System.Runtime.InteropServices.DispId(211)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		global::CDO.CalendarMessage Invite([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string EmailList);

		// Token: 0x060001C1 RID: 449
		[global::System.Runtime.InteropServices.DispId(212)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		global::CDO.CalendarMessage Publish();

		// Token: 0x060001C2 RID: 450
		[global::System.Runtime.InteropServices.DispId(217)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		global::CDO.Appointment GetFirstInstance([global::System.Runtime.InteropServices.In] global::System.DateTime MinDate, [global::System.Runtime.InteropServices.In] global::System.DateTime MaxDate);

		// Token: 0x060001C3 RID: 451
		[global::System.Runtime.InteropServices.DispId(218)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		global::CDO.Appointment GetNextInstance();

		// Token: 0x060001C4 RID: 452
		[global::System.Runtime.InteropServices.DispId(219)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)]
		object GetInterface([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string Interface);

		// Token: 0x060001C5 RID: 453
		[global::System.Runtime.InteropServices.DispId(220)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		global::CDO.Appointment GetRecurringMaster([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] string CalendarLocation, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] string UserName, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] string Password);
	}
}
