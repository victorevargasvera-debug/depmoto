using System;
using System.Runtime.InteropServices;

namespace CDO
{
	// Token: 0x0200001F RID: 31
	public abstract class CdoConfiguration
	{
		// Token: 0x0400010F RID: 271
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoActiveConnection = "http://schemas.microsoft.com/cdo/configuration/activeconnection";

		// Token: 0x04000110 RID: 272
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoAutoPromoteBodyParts = "http://schemas.microsoft.com/cdo/configuration/autopromotebodyparts";

		// Token: 0x04000111 RID: 273
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoFlushBuffersOnWrite = "http://schemas.microsoft.com/cdo/configuration/flushbuffersonwrite";

		// Token: 0x04000112 RID: 274
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoHTTPCookies = "http://schemas.microsoft.com/cdo/configuration/httpcookies";

		// Token: 0x04000113 RID: 275
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoLanguageCode = "http://schemas.microsoft.com/cdo/configuration/languagecode";

		// Token: 0x04000114 RID: 276
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoMailboxURL = "http://schemas.microsoft.com/cdo/configuration/mailboxurl";

		// Token: 0x04000115 RID: 277
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoNNTPAccountName = "http://schemas.microsoft.com/cdo/configuration/nntpaccountname";

		// Token: 0x04000116 RID: 278
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoNNTPAuthenticate = "http://schemas.microsoft.com/cdo/configuration/nntpauthenticate";

		// Token: 0x04000117 RID: 279
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoNNTPConnectionTimeout = "http://schemas.microsoft.com/cdo/configuration/nntpconnectiontimeout";

		// Token: 0x04000118 RID: 280
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoNNTPServer = "http://schemas.microsoft.com/cdo/configuration/nntpserver";

		// Token: 0x04000119 RID: 281
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoNNTPServerPickupDirectory = "http://schemas.microsoft.com/cdo/configuration/nntpserverpickupdirectory";

		// Token: 0x0400011A RID: 282
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoNNTPServerPort = "http://schemas.microsoft.com/cdo/configuration/nntpserverport";

		// Token: 0x0400011B RID: 283
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoNNTPUseSSL = "http://schemas.microsoft.com/cdo/configuration/nntpusessl";

		// Token: 0x0400011C RID: 284
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoPostEmailAddress = "http://schemas.microsoft.com/cdo/configuration/postemailaddress";

		// Token: 0x0400011D RID: 285
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoPostPassword = "http://schemas.microsoft.com/cdo/configuration/postpassword";

		// Token: 0x0400011E RID: 286
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoPostUserName = "http://schemas.microsoft.com/cdo/configuration/postusername";

		// Token: 0x0400011F RID: 287
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoPostUserReplyEmailAddress = "http://schemas.microsoft.com/cdo/configuration/postuserreplyemailaddress";

		// Token: 0x04000120 RID: 288
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoPostUsingMethod = "http://schemas.microsoft.com/cdo/configuration/postusing";

		// Token: 0x04000121 RID: 289
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoSaveSentItems = "http://schemas.microsoft.com/cdo/configuration/savesentitems";

		// Token: 0x04000122 RID: 290
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoSendEmailAddress = "http://schemas.microsoft.com/cdo/configuration/sendemailaddress";

		// Token: 0x04000123 RID: 291
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoSendPassword = "http://schemas.microsoft.com/cdo/configuration/sendpassword";

		// Token: 0x04000124 RID: 292
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoSendUserName = "http://schemas.microsoft.com/cdo/configuration/sendusername";

		// Token: 0x04000125 RID: 293
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoSendUserReplyEmailAddress = "http://schemas.microsoft.com/cdo/configuration/senduserreplyemailaddress";

		// Token: 0x04000126 RID: 294
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoSendUsingMethod = "http://schemas.microsoft.com/cdo/configuration/sendusing";

		// Token: 0x04000127 RID: 295
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoSMTPAccountName = "http://schemas.microsoft.com/cdo/configuration/smtpaccountname";

		// Token: 0x04000128 RID: 296
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoSMTPAuthenticate = "http://schemas.microsoft.com/cdo/configuration/smtpauthenticate";

		// Token: 0x04000129 RID: 297
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoSMTPConnectionTimeout = "http://schemas.microsoft.com/cdo/configuration/smtpconnectiontimeout";

		// Token: 0x0400012A RID: 298
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoSMTPServer = "http://schemas.microsoft.com/cdo/configuration/smtpserver";

		// Token: 0x0400012B RID: 299
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoSMTPServerPickupDirectory = "http://schemas.microsoft.com/cdo/configuration/smtpserverpickupdirectory";

		// Token: 0x0400012C RID: 300
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoSMTPServerPort = "http://schemas.microsoft.com/cdo/configuration/smtpserverport";

		// Token: 0x0400012D RID: 301
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoSMTPUseSSL = "http://schemas.microsoft.com/cdo/configuration/smtpusessl";

		// Token: 0x0400012E RID: 302
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoURLGetLatestVersion = "http://schemas.microsoft.com/cdo/configuration/urlgetlatestversion";

		// Token: 0x0400012F RID: 303
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoURLProxyBypass = "http://schemas.microsoft.com/cdo/configuration/urlproxybypass";

		// Token: 0x04000130 RID: 304
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoURLProxyServer = "http://schemas.microsoft.com/cdo/configuration/urlproxyserver";

		// Token: 0x04000131 RID: 305
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoURLSource = "http://schemas.microsoft.com/cdo/configuration/urlsource";

		// Token: 0x04000132 RID: 306
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoUseMessageResponseText = "http://schemas.microsoft.com/cdo/configuration/usemessageresponsetext";
	}
}
