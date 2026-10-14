using System;
using System.Runtime.InteropServices;

namespace CDO
{
	// Token: 0x02000027 RID: 39
	public abstract class CdoMailHeader
	{
		// Token: 0x040001FB RID: 507
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoApproved = "urn:schemas:mailheader:approved";

		// Token: 0x040001FC RID: 508
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoComment = "urn:schemas:mailheader:comment";

		// Token: 0x040001FD RID: 509
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoContentBase = "urn:schemas:mailheader:content-base";

		// Token: 0x040001FE RID: 510
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoContentDescription = "urn:schemas:mailheader:content-description";

		// Token: 0x040001FF RID: 511
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoContentDisposition = "urn:schemas:mailheader:content-disposition";

		// Token: 0x04000200 RID: 512
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoContentId = "urn:schemas:mailheader:content-id";

		// Token: 0x04000201 RID: 513
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoContentLanguage = "urn:schemas:mailheader:content-language";

		// Token: 0x04000202 RID: 514
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoContentLocation = "urn:schemas:mailheader:content-location";

		// Token: 0x04000203 RID: 515
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoContentTransferEncoding = "urn:schemas:mailheader:content-transfer-encoding";

		// Token: 0x04000204 RID: 516
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoContentType = "urn:schemas:mailheader:content-type";

		// Token: 0x04000205 RID: 517
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoControl = "urn:schemas:mailheader:control";

		// Token: 0x04000206 RID: 518
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoDisposition = "urn:schemas:mailheader:disposition";

		// Token: 0x04000207 RID: 519
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoDispositionNotificationTo = "urn:schemas:mailheader:disposition-notification-to";

		// Token: 0x04000208 RID: 520
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoDistribution = "urn:schemas:mailheader:distribution";

		// Token: 0x04000209 RID: 521
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoExpires = "urn:schemas:mailheader:expires";

		// Token: 0x0400020A RID: 522
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoFollowupTo = "urn:schemas:mailheader:followup-to";

		// Token: 0x0400020B RID: 523
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoInReplyTo = "urn:schemas:mailheader:in-reply-to";

		// Token: 0x0400020C RID: 524
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoLines = "urn:schemas:mailheader:lines";

		// Token: 0x0400020D RID: 525
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoMessageId = "urn:schemas:mailheader:message-id";

		// Token: 0x0400020E RID: 526
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoMIMEVersion = "urn:schemas:mailheader:mime-version";

		// Token: 0x0400020F RID: 527
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoNewsgroups = "urn:schemas:mailheader:newsgroups";

		// Token: 0x04000210 RID: 528
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoOrganization = "urn:schemas:mailheader:organization";

		// Token: 0x04000211 RID: 529
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoOriginalRecipient = "urn:schemas:mailheader:original-recipient";

		// Token: 0x04000212 RID: 530
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoPath = "urn:schemas:mailheader:path";

		// Token: 0x04000213 RID: 531
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoPostingVersion = "urn:schemas:mailheader:posting-version";

		// Token: 0x04000214 RID: 532
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoReceived = "urn:schemas:mailheader:received";

		// Token: 0x04000215 RID: 533
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoReferences = "urn:schemas:mailheader:references";

		// Token: 0x04000216 RID: 534
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoRelayVersion = "urn:schemas:mailheader:relay-version";

		// Token: 0x04000217 RID: 535
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoReturnPath = "urn:schemas:mailheader:return-path";

		// Token: 0x04000218 RID: 536
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoReturnReceiptTo = "urn:schemas:mailheader:return-receipt-to";

		// Token: 0x04000219 RID: 537
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoSummary = "urn:schemas:mailheader:summary";

		// Token: 0x0400021A RID: 538
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoThreadIndex = "urn:schemas:mailheader:thread-index";

		// Token: 0x0400021B RID: 539
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoXMailer = "urn:schemas:mailheader:x-mailer";

		// Token: 0x0400021C RID: 540
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoXref = "urn:schemas:mailheader:xref";

		// Token: 0x0400021D RID: 541
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoXUnsent = "urn:schemas:mailheader:x-unsent";
	}
}
