using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x0200004C RID: 76
	[global::System.Runtime.InteropServices.Guid("3050F3CF-98B5-11CF-BB82-00AA00BDCE0B")]
	[global::System.Runtime.InteropServices.TypeLibType(4160)]
	[global::System.Runtime.InteropServices.ComImport]
	public interface IHTMLRuleStyle
	{
		// Token: 0x170000CE RID: 206
		// (get) Token: 0x0600019B RID: 411
		// (set) Token: 0x0600019A RID: 410
		[global::System.Runtime.InteropServices.DispId(-2147413094)]
		string fontFamily { [global::System.Runtime.InteropServices.DispId(-2147413094)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(-2147413094)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x0600019D RID: 413
		// (set) Token: 0x0600019C RID: 412
		[global::System.Runtime.InteropServices.DispId(-2147413088)]
		string fontStyle { [global::System.Runtime.InteropServices.DispId(-2147413088)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(-2147413088)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x0600019F RID: 415
		// (set) Token: 0x0600019E RID: 414
		[global::System.Runtime.InteropServices.DispId(-2147413087)]
		string fontVariant { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413087)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(-2147413087)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x060001A1 RID: 417
		// (set) Token: 0x060001A0 RID: 416
		[global::System.Runtime.InteropServices.DispId(-2147413085)]
		string fontWeight { [global::System.Runtime.InteropServices.DispId(-2147413085)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413085)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x060001A3 RID: 419
		// (set) Token: 0x060001A2 RID: 418
		[global::System.Runtime.InteropServices.DispId(-2147413093)]
		object fontSize { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413093)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147413093)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x060001A5 RID: 421
		// (set) Token: 0x060001A4 RID: 420
		[global::System.Runtime.InteropServices.DispId(-2147413071)]
		string font { [global::System.Runtime.InteropServices.TypeLibFunc(1044)] [global::System.Runtime.InteropServices.DispId(-2147413071)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.TypeLibFunc(1044)] [global::System.Runtime.InteropServices.DispId(-2147413071)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x060001A7 RID: 423
		// (set) Token: 0x060001A6 RID: 422
		[global::System.Runtime.InteropServices.DispId(-2147413110)]
		object color { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413110)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413110)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x060001A9 RID: 425
		// (set) Token: 0x060001A8 RID: 424
		[global::System.Runtime.InteropServices.DispId(-2147413080)]
		string background { [global::System.Runtime.InteropServices.DispId(-2147413080)] [global::System.Runtime.InteropServices.TypeLibFunc(1044)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.TypeLibFunc(1044)] [global::System.Runtime.InteropServices.DispId(-2147413080)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x060001AB RID: 427
		// (set) Token: 0x060001AA RID: 426
		[global::System.Runtime.InteropServices.DispId(-501)]
		object backgroundColor { [global::System.Runtime.InteropServices.DispId(-501)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-501)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x060001AD RID: 429
		// (set) Token: 0x060001AC RID: 428
		[global::System.Runtime.InteropServices.DispId(-2147413111)]
		string backgroundImage { [global::System.Runtime.InteropServices.DispId(-2147413111)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413111)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x060001AF RID: 431
		// (set) Token: 0x060001AE RID: 430
		[global::System.Runtime.InteropServices.DispId(-2147413068)]
		string backgroundRepeat { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413068)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413068)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x060001B1 RID: 433
		// (set) Token: 0x060001B0 RID: 432
		[global::System.Runtime.InteropServices.DispId(-2147413067)]
		string backgroundAttachment { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413067)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413067)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x060001B3 RID: 435
		// (set) Token: 0x060001B2 RID: 434
		[global::System.Runtime.InteropServices.DispId(-2147413066)]
		string backgroundPosition { [global::System.Runtime.InteropServices.DispId(-2147413066)] [global::System.Runtime.InteropServices.TypeLibFunc(1044)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(-2147413066)] [global::System.Runtime.InteropServices.TypeLibFunc(1044)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x060001B5 RID: 437
		// (set) Token: 0x060001B4 RID: 436
		[global::System.Runtime.InteropServices.DispId(-2147413079)]
		object backgroundPositionX { [global::System.Runtime.InteropServices.DispId(-2147413079)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413079)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x060001B7 RID: 439
		// (set) Token: 0x060001B6 RID: 438
		[global::System.Runtime.InteropServices.DispId(-2147413078)]
		object backgroundPositionY { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413078)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413078)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x060001B9 RID: 441
		// (set) Token: 0x060001B8 RID: 440
		[global::System.Runtime.InteropServices.DispId(-2147413065)]
		object wordSpacing { [global::System.Runtime.InteropServices.DispId(-2147413065)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147413065)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x060001BB RID: 443
		// (set) Token: 0x060001BA RID: 442
		[global::System.Runtime.InteropServices.DispId(-2147413104)]
		object letterSpacing { [global::System.Runtime.InteropServices.DispId(-2147413104)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147413104)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x060001BD RID: 445
		// (set) Token: 0x060001BC RID: 444
		[global::System.Runtime.InteropServices.DispId(-2147413077)]
		string textDecoration { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413077)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413077)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x060001BF RID: 447
		// (set) Token: 0x060001BE RID: 446
		[global::System.Runtime.InteropServices.DispId(-2147413089)]
		bool textDecorationNone { [global::System.Runtime.InteropServices.DispId(-2147413089)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413089)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x060001C1 RID: 449
		// (set) Token: 0x060001C0 RID: 448
		[global::System.Runtime.InteropServices.DispId(-2147413091)]
		bool textDecorationUnderline { [global::System.Runtime.InteropServices.DispId(-2147413091)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413091)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x060001C3 RID: 451
		// (set) Token: 0x060001C2 RID: 450
		[global::System.Runtime.InteropServices.DispId(-2147413043)]
		bool textDecorationOverline { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413043)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(-2147413043)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x060001C5 RID: 453
		// (set) Token: 0x060001C4 RID: 452
		[global::System.Runtime.InteropServices.DispId(-2147413092)]
		bool textDecorationLineThrough { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413092)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413092)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x060001C7 RID: 455
		// (set) Token: 0x060001C6 RID: 454
		[global::System.Runtime.InteropServices.DispId(-2147413090)]
		bool textDecorationBlink { [global::System.Runtime.InteropServices.DispId(-2147413090)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(-2147413090)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x060001C9 RID: 457
		// (set) Token: 0x060001C8 RID: 456
		[global::System.Runtime.InteropServices.DispId(-2147413064)]
		object verticalAlign { [global::System.Runtime.InteropServices.DispId(-2147413064)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147413064)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x060001CB RID: 459
		// (set) Token: 0x060001CA RID: 458
		[global::System.Runtime.InteropServices.DispId(-2147413108)]
		string textTransform { [global::System.Runtime.InteropServices.DispId(-2147413108)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413108)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x060001CD RID: 461
		// (set) Token: 0x060001CC RID: 460
		[global::System.Runtime.InteropServices.DispId(-2147418040)]
		string textAlign { [global::System.Runtime.InteropServices.DispId(-2147418040)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(-2147418040)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x060001CF RID: 463
		// (set) Token: 0x060001CE RID: 462
		[global::System.Runtime.InteropServices.DispId(-2147413105)]
		object textIndent { [global::System.Runtime.InteropServices.DispId(-2147413105)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147413105)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x060001D1 RID: 465
		// (set) Token: 0x060001D0 RID: 464
		[global::System.Runtime.InteropServices.DispId(-2147413106)]
		object lineHeight { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413106)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413106)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x060001D3 RID: 467
		// (set) Token: 0x060001D2 RID: 466
		[global::System.Runtime.InteropServices.DispId(-2147413075)]
		object marginTop { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413075)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413075)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x060001D5 RID: 469
		// (set) Token: 0x060001D4 RID: 468
		[global::System.Runtime.InteropServices.DispId(-2147413074)]
		object marginRight { [global::System.Runtime.InteropServices.DispId(-2147413074)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413074)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x060001D7 RID: 471
		// (set) Token: 0x060001D6 RID: 470
		[global::System.Runtime.InteropServices.DispId(-2147413073)]
		object marginBottom { [global::System.Runtime.InteropServices.DispId(-2147413073)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147413073)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x060001D9 RID: 473
		// (set) Token: 0x060001D8 RID: 472
		[global::System.Runtime.InteropServices.DispId(-2147413072)]
		object marginLeft { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413072)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413072)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x060001DB RID: 475
		// (set) Token: 0x060001DA RID: 474
		[global::System.Runtime.InteropServices.DispId(-2147413076)]
		string margin { [global::System.Runtime.InteropServices.DispId(-2147413076)] [global::System.Runtime.InteropServices.TypeLibFunc(1044)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.TypeLibFunc(1044)] [global::System.Runtime.InteropServices.DispId(-2147413076)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x060001DD RID: 477
		// (set) Token: 0x060001DC RID: 476
		[global::System.Runtime.InteropServices.DispId(-2147413100)]
		object paddingTop { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413100)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147413100)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x060001DF RID: 479
		// (set) Token: 0x060001DE RID: 478
		[global::System.Runtime.InteropServices.DispId(-2147413099)]
		object paddingRight { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413099)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413099)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x060001E1 RID: 481
		// (set) Token: 0x060001E0 RID: 480
		[global::System.Runtime.InteropServices.DispId(-2147413098)]
		object paddingBottom { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413098)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413098)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x060001E3 RID: 483
		// (set) Token: 0x060001E2 RID: 482
		[global::System.Runtime.InteropServices.DispId(-2147413097)]
		object paddingLeft { [global::System.Runtime.InteropServices.DispId(-2147413097)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147413097)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x060001E5 RID: 485
		// (set) Token: 0x060001E4 RID: 484
		[global::System.Runtime.InteropServices.DispId(-2147413101)]
		string padding { [global::System.Runtime.InteropServices.TypeLibFunc(1044)] [global::System.Runtime.InteropServices.DispId(-2147413101)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(-2147413101)] [global::System.Runtime.InteropServices.TypeLibFunc(1044)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x060001E7 RID: 487
		// (set) Token: 0x060001E6 RID: 486
		[global::System.Runtime.InteropServices.DispId(-2147413063)]
		string border { [global::System.Runtime.InteropServices.DispId(-2147413063)] [global::System.Runtime.InteropServices.TypeLibFunc(1044)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.TypeLibFunc(1044)] [global::System.Runtime.InteropServices.DispId(-2147413063)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x060001E9 RID: 489
		// (set) Token: 0x060001E8 RID: 488
		[global::System.Runtime.InteropServices.DispId(-2147413062)]
		string borderTop { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413062)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(-2147413062)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x060001EB RID: 491
		// (set) Token: 0x060001EA RID: 490
		[global::System.Runtime.InteropServices.DispId(-2147413061)]
		string borderRight { [global::System.Runtime.InteropServices.DispId(-2147413061)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(-2147413061)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x060001ED RID: 493
		// (set) Token: 0x060001EC RID: 492
		[global::System.Runtime.InteropServices.DispId(-2147413060)]
		string borderBottom { [global::System.Runtime.InteropServices.DispId(-2147413060)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(-2147413060)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x060001EF RID: 495
		// (set) Token: 0x060001EE RID: 494
		[global::System.Runtime.InteropServices.DispId(-2147413059)]
		string borderLeft { [global::System.Runtime.InteropServices.DispId(-2147413059)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(-2147413059)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x060001F1 RID: 497
		// (set) Token: 0x060001F0 RID: 496
		[global::System.Runtime.InteropServices.DispId(-2147413058)]
		string borderColor { [global::System.Runtime.InteropServices.DispId(-2147413058)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(-2147413058)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x060001F3 RID: 499
		// (set) Token: 0x060001F2 RID: 498
		[global::System.Runtime.InteropServices.DispId(-2147413057)]
		object borderTopColor { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413057)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413057)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x060001F5 RID: 501
		// (set) Token: 0x060001F4 RID: 500
		[global::System.Runtime.InteropServices.DispId(-2147413056)]
		object borderRightColor { [global::System.Runtime.InteropServices.DispId(-2147413056)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413056)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x060001F7 RID: 503
		// (set) Token: 0x060001F6 RID: 502
		[global::System.Runtime.InteropServices.DispId(-2147413055)]
		object borderBottomColor { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413055)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413055)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x060001F9 RID: 505
		// (set) Token: 0x060001F8 RID: 504
		[global::System.Runtime.InteropServices.DispId(-2147413054)]
		object borderLeftColor { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413054)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147413054)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x060001FB RID: 507
		// (set) Token: 0x060001FA RID: 506
		[global::System.Runtime.InteropServices.DispId(-2147413053)]
		string borderWidth { [global::System.Runtime.InteropServices.DispId(-2147413053)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413053)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x060001FD RID: 509
		// (set) Token: 0x060001FC RID: 508
		[global::System.Runtime.InteropServices.DispId(-2147413052)]
		object borderTopWidth { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413052)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413052)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x060001FF RID: 511
		// (set) Token: 0x060001FE RID: 510
		[global::System.Runtime.InteropServices.DispId(-2147413051)]
		object borderRightWidth { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413051)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147413051)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x06000201 RID: 513
		// (set) Token: 0x06000200 RID: 512
		[global::System.Runtime.InteropServices.DispId(-2147413050)]
		object borderBottomWidth { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413050)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413050)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x06000203 RID: 515
		// (set) Token: 0x06000202 RID: 514
		[global::System.Runtime.InteropServices.DispId(-2147413049)]
		object borderLeftWidth { [global::System.Runtime.InteropServices.DispId(-2147413049)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147413049)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x06000205 RID: 517
		// (set) Token: 0x06000204 RID: 516
		[global::System.Runtime.InteropServices.DispId(-2147413048)]
		string borderStyle { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413048)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(-2147413048)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x06000207 RID: 519
		// (set) Token: 0x06000206 RID: 518
		[global::System.Runtime.InteropServices.DispId(-2147413047)]
		string borderTopStyle { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413047)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413047)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x06000209 RID: 521
		// (set) Token: 0x06000208 RID: 520
		[global::System.Runtime.InteropServices.DispId(-2147413046)]
		string borderRightStyle { [global::System.Runtime.InteropServices.DispId(-2147413046)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(-2147413046)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x0600020B RID: 523
		// (set) Token: 0x0600020A RID: 522
		[global::System.Runtime.InteropServices.DispId(-2147413045)]
		string borderBottomStyle { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413045)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413045)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x0600020D RID: 525
		// (set) Token: 0x0600020C RID: 524
		[global::System.Runtime.InteropServices.DispId(-2147413044)]
		string borderLeftStyle { [global::System.Runtime.InteropServices.DispId(-2147413044)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413044)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x0600020F RID: 527
		// (set) Token: 0x0600020E RID: 526
		[global::System.Runtime.InteropServices.DispId(-2147418107)]
		object width { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147418107)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147418107)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x06000211 RID: 529
		// (set) Token: 0x06000210 RID: 528
		[global::System.Runtime.InteropServices.DispId(-2147418106)]
		object height { [global::System.Runtime.InteropServices.DispId(-2147418106)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147418106)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x06000213 RID: 531
		// (set) Token: 0x06000212 RID: 530
		[global::System.Runtime.InteropServices.DispId(-2147413042)]
		string styleFloat { [global::System.Runtime.InteropServices.DispId(-2147413042)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413042)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x06000215 RID: 533
		// (set) Token: 0x06000214 RID: 532
		[global::System.Runtime.InteropServices.DispId(-2147413096)]
		string clear { [global::System.Runtime.InteropServices.DispId(-2147413096)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(-2147413096)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x06000217 RID: 535
		// (set) Token: 0x06000216 RID: 534
		[global::System.Runtime.InteropServices.DispId(-2147413041)]
		string display { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413041)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(-2147413041)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x06000219 RID: 537
		// (set) Token: 0x06000218 RID: 536
		[global::System.Runtime.InteropServices.DispId(-2147413032)]
		string visibility { [global::System.Runtime.InteropServices.DispId(-2147413032)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413032)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x0600021B RID: 539
		// (set) Token: 0x0600021A RID: 538
		[global::System.Runtime.InteropServices.DispId(-2147413040)]
		string listStyleType { [global::System.Runtime.InteropServices.DispId(-2147413040)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(-2147413040)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x0600021D RID: 541
		// (set) Token: 0x0600021C RID: 540
		[global::System.Runtime.InteropServices.DispId(-2147413039)]
		string listStylePosition { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413039)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413039)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x0600021F RID: 543
		// (set) Token: 0x0600021E RID: 542
		[global::System.Runtime.InteropServices.DispId(-2147413038)]
		string listStyleImage { [global::System.Runtime.InteropServices.DispId(-2147413038)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413038)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x06000221 RID: 545
		// (set) Token: 0x06000220 RID: 544
		[global::System.Runtime.InteropServices.DispId(-2147413037)]
		string listStyle { [global::System.Runtime.InteropServices.TypeLibFunc(1044)] [global::System.Runtime.InteropServices.DispId(-2147413037)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.TypeLibFunc(1044)] [global::System.Runtime.InteropServices.DispId(-2147413037)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x06000223 RID: 547
		// (set) Token: 0x06000222 RID: 546
		[global::System.Runtime.InteropServices.DispId(-2147413036)]
		string whiteSpace { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413036)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(-2147413036)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x06000225 RID: 549
		// (set) Token: 0x06000224 RID: 548
		[global::System.Runtime.InteropServices.DispId(-2147418108)]
		object top { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147418108)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-2147418108)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x06000227 RID: 551
		// (set) Token: 0x06000226 RID: 550
		[global::System.Runtime.InteropServices.DispId(-2147418109)]
		object left { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147418109)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147418109)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000228 RID: 552
		[global::System.Runtime.InteropServices.DispId(-2147413022)]
		string position { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413022)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x0600022A RID: 554
		// (set) Token: 0x06000229 RID: 553
		[global::System.Runtime.InteropServices.DispId(-2147413021)]
		object zIndex { [global::System.Runtime.InteropServices.DispId(-2147413021)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413021)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x0600022C RID: 556
		// (set) Token: 0x0600022B RID: 555
		[global::System.Runtime.InteropServices.DispId(-2147413102)]
		string overflow { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413102)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413102)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x0600022E RID: 558
		// (set) Token: 0x0600022D RID: 557
		[global::System.Runtime.InteropServices.DispId(-2147413035)]
		string pageBreakBefore { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413035)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413035)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x06000230 RID: 560
		// (set) Token: 0x0600022F RID: 559
		[global::System.Runtime.InteropServices.DispId(-2147413034)]
		string pageBreakAfter { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413034)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(-2147413034)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x06000232 RID: 562
		// (set) Token: 0x06000231 RID: 561
		[global::System.Runtime.InteropServices.DispId(-2147413013)]
		string cssText { [global::System.Runtime.InteropServices.TypeLibFunc(1044)] [global::System.Runtime.InteropServices.DispId(-2147413013)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(-2147413013)] [global::System.Runtime.InteropServices.TypeLibFunc(1044)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x06000234 RID: 564
		// (set) Token: 0x06000233 RID: 563
		[global::System.Runtime.InteropServices.DispId(-2147413010)]
		string cursor { [global::System.Runtime.InteropServices.DispId(-2147413010)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413010)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000236 RID: 566
		// (set) Token: 0x06000235 RID: 565
		[global::System.Runtime.InteropServices.DispId(-2147413020)]
		string clip { [global::System.Runtime.InteropServices.DispId(-2147413020)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(-2147413020)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000238 RID: 568
		// (set) Token: 0x06000237 RID: 567
		[global::System.Runtime.InteropServices.DispId(-2147413030)]
		string filter { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413030)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(-2147413030)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x06000239 RID: 569
		[global::System.Runtime.InteropServices.DispId(-2147417611)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void setAttribute([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string strAttributeName, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] object AttributeValue, [global::System.Runtime.InteropServices.In] int lFlags = 1);

		// Token: 0x0600023A RID: 570
		[global::System.Runtime.InteropServices.DispId(-2147417610)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)]
		object getAttribute([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string strAttributeName, [global::System.Runtime.InteropServices.In] int lFlags = 0);

		// Token: 0x0600023B RID: 571
		[global::System.Runtime.InteropServices.DispId(-2147417609)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		bool removeAttribute([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string strAttributeName, [global::System.Runtime.InteropServices.In] int lFlags = 1);
	}
}
