using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ADODB;

namespace CDO
{
	// Token: 0x02000035 RID: 53
	[global::System.Runtime.InteropServices.TypeLibType(4288)]
	[global::System.Runtime.InteropServices.Guid("CD000020-8B95-11D1-82DB-00C04FB1625D")]
	[global::System.Runtime.InteropServices.ComImport]
	public interface IMessage
	{
		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600002F RID: 47
		// (set) Token: 0x06000030 RID: 48
		[global::System.Runtime.InteropServices.DispId(101)]
		string BCC { [global::System.Runtime.InteropServices.DispId(101)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(101)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000031 RID: 49
		// (set) Token: 0x06000032 RID: 50
		[global::System.Runtime.InteropServices.DispId(103)]
		string CC { [global::System.Runtime.InteropServices.DispId(103)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(103)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000033 RID: 51
		// (set) Token: 0x06000034 RID: 52
		[global::System.Runtime.InteropServices.DispId(105)]
		string FollowUpTo { [global::System.Runtime.InteropServices.DispId(105)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(105)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000035 RID: 53
		// (set) Token: 0x06000036 RID: 54
		[global::System.Runtime.InteropServices.DispId(106)]
		string From { [global::System.Runtime.InteropServices.DispId(106)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(106)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000037 RID: 55
		// (set) Token: 0x06000038 RID: 56
		[global::System.Runtime.InteropServices.DispId(107)]
		string Keywords { [global::System.Runtime.InteropServices.DispId(107)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(107)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000039 RID: 57
		// (set) Token: 0x0600003A RID: 58
		[global::System.Runtime.InteropServices.DispId(110)]
		bool MimeFormatted { [global::System.Runtime.InteropServices.DispId(110)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(110)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600003B RID: 59
		// (set) Token: 0x0600003C RID: 60
		[global::System.Runtime.InteropServices.DispId(111)]
		string Newsgroups { [global::System.Runtime.InteropServices.DispId(111)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(111)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600003D RID: 61
		// (set) Token: 0x0600003E RID: 62
		[global::System.Runtime.InteropServices.DispId(112)]
		string Organization { [global::System.Runtime.InteropServices.DispId(112)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(112)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600003F RID: 63
		[global::System.Runtime.InteropServices.DispId(114)]
		global::System.DateTime ReceivedTime { [global::System.Runtime.InteropServices.DispId(114)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000040 RID: 64
		// (set) Token: 0x06000041 RID: 65
		[global::System.Runtime.InteropServices.DispId(115)]
		string ReplyTo { [global::System.Runtime.InteropServices.DispId(115)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(115)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000042 RID: 66
		// (set) Token: 0x06000043 RID: 67
		[global::System.Runtime.InteropServices.DispId(116)]
		global::CDO.CdoDSNOptions DSNOptions { [global::System.Runtime.InteropServices.DispId(116)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(116)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000044 RID: 68
		[global::System.Runtime.InteropServices.DispId(119)]
		global::System.DateTime SentOn { [global::System.Runtime.InteropServices.DispId(119)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000045 RID: 69
		// (set) Token: 0x06000046 RID: 70
		[global::System.Runtime.InteropServices.DispId(120)]
		string Subject { [global::System.Runtime.InteropServices.DispId(120)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(120)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000047 RID: 71
		// (set) Token: 0x06000048 RID: 72
		[global::System.Runtime.InteropServices.DispId(121)]
		string To { [global::System.Runtime.InteropServices.DispId(121)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(121)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000049 RID: 73
		// (set) Token: 0x0600004A RID: 74
		[global::System.Runtime.InteropServices.DispId(123)]
		string TextBody { [global::System.Runtime.InteropServices.DispId(123)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(123)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600004B RID: 75
		// (set) Token: 0x0600004C RID: 76
		[global::System.Runtime.InteropServices.DispId(124)]
		string HTMLBody { [global::System.Runtime.InteropServices.DispId(124)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(124)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600004D RID: 77
		[global::System.Runtime.InteropServices.DispId(125)]
		global::CDO.IBodyParts Attachments { [global::System.Runtime.InteropServices.DispId(125)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600004E RID: 78
		// (set) Token: 0x0600004F RID: 79
		[global::System.Runtime.InteropServices.DispId(126)]
		string Sender { [global::System.Runtime.InteropServices.DispId(126)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(126)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000050 RID: 80
		// (set) Token: 0x06000052 RID: 82
		[global::System.Runtime.InteropServices.DispId(127)]
		global::CDO.Configuration Configuration { [global::System.Runtime.InteropServices.DispId(127)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; [global::System.Runtime.InteropServices.DispId(127)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000053 RID: 83
		// (set) Token: 0x06000054 RID: 84
		[global::System.Runtime.InteropServices.DispId(128)]
		bool AutoGenerateTextBody { [global::System.Runtime.InteropServices.DispId(128)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(128)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000055 RID: 85
		[global::System.Runtime.InteropServices.DispId(129)]
		global::ADODB.Fields EnvelopeFields { [global::System.Runtime.InteropServices.DispId(129)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000056 RID: 86
		[global::System.Runtime.InteropServices.DispId(130)]
		global::CDO.IBodyPart TextBodyPart { [global::System.Runtime.InteropServices.DispId(130)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000057 RID: 87
		[global::System.Runtime.InteropServices.DispId(131)]
		global::CDO.IBodyPart HTMLBodyPart { [global::System.Runtime.InteropServices.DispId(131)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000058 RID: 88
		[global::System.Runtime.InteropServices.DispId(132)]
		global::CDO.IBodyPart BodyPart { [global::System.Runtime.InteropServices.DispId(132)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000059 RID: 89
		[global::System.Runtime.InteropServices.DispId(133)]
		global::CDO.IDataSource DataSource { [global::System.Runtime.InteropServices.DispId(133)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x0600005A RID: 90
		[global::System.Runtime.InteropServices.DispId(134)]
		global::ADODB.Fields Fields { [global::System.Runtime.InteropServices.DispId(134)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600005B RID: 91
		// (set) Token: 0x0600005C RID: 92
		[global::System.Runtime.InteropServices.DispId(135)]
		bool MDNRequested { [global::System.Runtime.InteropServices.DispId(135)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(135)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x0600005D RID: 93
		[global::System.Runtime.InteropServices.DispId(150)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		global::CDO.IBodyPart AddRelatedBodyPart([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string URL, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string Reference, [global::System.Runtime.InteropServices.In] global::CDO.CdoReferenceType ReferenceType, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] string UserName, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] string Password);

		// Token: 0x0600005E RID: 94
		[global::System.Runtime.InteropServices.DispId(151)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		global::CDO.IBodyPart AddAttachment([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string URL, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] string UserName, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] string Password);

		// Token: 0x0600005F RID: 95
		[global::System.Runtime.InteropServices.DispId(152)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void CreateMHTMLBody([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string URL, [global::System.Runtime.InteropServices.In] global::CDO.CdoMHTMLFlags Flags = global::CDO.CdoMHTMLFlags.cdoSuppressNone, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] string UserName, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] string Password);

		// Token: 0x06000060 RID: 96
		[global::System.Runtime.InteropServices.DispId(153)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		global::CDO.IMessage Forward();

		// Token: 0x06000061 RID: 97
		[global::System.Runtime.InteropServices.DispId(154)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void Post();

		// Token: 0x06000062 RID: 98
		[global::System.Runtime.InteropServices.DispId(155)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		global::CDO.IMessage PostReply();

		// Token: 0x06000063 RID: 99
		[global::System.Runtime.InteropServices.DispId(156)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		global::CDO.IMessage Reply();

		// Token: 0x06000064 RID: 100
		[global::System.Runtime.InteropServices.DispId(157)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		global::CDO.IMessage ReplyAll();

		// Token: 0x06000065 RID: 101
		[global::System.Runtime.InteropServices.DispId(158)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void Send();

		// Token: 0x06000066 RID: 102
		[global::System.Runtime.InteropServices.DispId(159)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		global::ADODB.Stream GetStream();

		// Token: 0x06000067 RID: 103
		[global::System.Runtime.InteropServices.DispId(160)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)]
		object GetInterface([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string Interface);
	}
}
