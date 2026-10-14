using System;
using System.Runtime.InteropServices;

namespace CDO
{
	// Token: 0x02000025 RID: 37
	public abstract class CdoHTTPMail
	{
		// Token: 0x040001C6 RID: 454
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoAttachmentFilename = "urn:schemas:httpmail:attachmentfilename";

		// Token: 0x040001C7 RID: 455
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoBcc = "urn:schemas:httpmail:bcc";

		// Token: 0x040001C8 RID: 456
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoCalendarFolderURL = "urn:schemas:httpmail:calendar";

		// Token: 0x040001C9 RID: 457
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoCc = "urn:schemas:httpmail:cc";

		// Token: 0x040001CA RID: 458
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoContactFolderURL = "urn:schemas:httpmail:contacts";

		// Token: 0x040001CB RID: 459
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoContentDispositionType = "urn:schemas:httpmail:content-disposition-type";

		// Token: 0x040001CC RID: 460
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoContentMediaType = "urn:schemas:httpmail:content-media-type";

		// Token: 0x040001CD RID: 461
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoDate = "urn:schemas:httpmail:date";

		// Token: 0x040001CE RID: 462
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoDateReceived = "urn:schemas:httpmail:datereceived";

		// Token: 0x040001CF RID: 463
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoDeletedItems = "urn:schemas:httpmail:deleteditems";

		// Token: 0x040001D0 RID: 464
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoFrom = "urn:schemas:httpmail:from";

		// Token: 0x040001D1 RID: 465
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoHasAttachment = "urn:schemas:httpmail:hasattachment";

		// Token: 0x040001D2 RID: 466
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoHTMLDescription = "urn:schemas:httpmail:htmldescription";

		// Token: 0x040001D3 RID: 467
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoImportance = "urn:schemas:httpmail:importance";

		// Token: 0x040001D4 RID: 468
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoInbox = "urn:schemas:httpmail:inbox";

		// Token: 0x040001D5 RID: 469
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoJournal = "urn:schemas:httpmail:journal";

		// Token: 0x040001D6 RID: 470
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoMsgFolderRoot = "urn:schemas:httpmail:msgfolderroot";

		// Token: 0x040001D7 RID: 471
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoNormalizedSubject = "urn:schemas:httpmail:normalizedsubject";

		// Token: 0x040001D8 RID: 472
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoNotes = "urn:schemas:httpmail:notes";

		// Token: 0x040001D9 RID: 473
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoOutbox = "urn:schemas:httpmail:outbox";

		// Token: 0x040001DA RID: 474
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoPriority = "urn:schemas:httpmail:priority";

		// Token: 0x040001DB RID: 475
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoRead = "urn:schemas:httpmail:read";

		// Token: 0x040001DC RID: 476
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoReplyTo = "urn:schemas:httpmail:reply-to";

		// Token: 0x040001DD RID: 477
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoSender = "urn:schemas:httpmail:sender";

		// Token: 0x040001DE RID: 478
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoSendMsg = "urn:schemas:httpmail:sendmsg";

		// Token: 0x040001DF RID: 479
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoSentItems = "urn:schemas:httpmail:sentitems";

		// Token: 0x040001E0 RID: 480
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoSpecial = "urn:schemas:httpmail:special";

		// Token: 0x040001E1 RID: 481
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoSubject = "urn:schemas:httpmail:subject";

		// Token: 0x040001E2 RID: 482
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoSubmitted = "urn:schemas:httpmail:submitted";

		// Token: 0x040001E3 RID: 483
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoTasks = "urn:schemas:httpmail:tasks";

		// Token: 0x040001E4 RID: 484
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoTextDescription = "urn:schemas:httpmail:textdescription";

		// Token: 0x040001E5 RID: 485
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoThreadTopic = "urn:schemas:httpmail:thread-topic";

		// Token: 0x040001E6 RID: 486
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoTo = "urn:schemas:httpmail:to";

		// Token: 0x040001E7 RID: 487
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoUnreadCount = "urn:schemas:httpmail:unreadcount";
	}
}
