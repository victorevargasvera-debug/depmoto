using System;
using System.Runtime.InteropServices;

namespace CDO
{
	// Token: 0x02000022 RID: 34
	public abstract class CdoDAV
	{
		// Token: 0x0400019B RID: 411
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoAbstract = "DAV:abstract";

		// Token: 0x0400019C RID: 412
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoChildCount = "DAV:childcount";

		// Token: 0x0400019D RID: 413
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoContentClass = "DAV:contentclass";

		// Token: 0x0400019E RID: 414
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoCreationDate = "DAV:creationdate";

		// Token: 0x0400019F RID: 415
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoDAVComment = "DAV:comment";

		// Token: 0x040001A0 RID: 416
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoDefaultDocument = "DAV:defaultdocument";

		// Token: 0x040001A1 RID: 417
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoDisplayName = "DAV:displayname";

		// Token: 0x040001A2 RID: 418
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoGetContentLanguage = "DAV:getcontentlanguage";

		// Token: 0x040001A3 RID: 419
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoGetContentLength = "DAV:getcontentlength";

		// Token: 0x040001A4 RID: 420
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoGetContentType = "DAV:getcontenttype";

		// Token: 0x040001A5 RID: 421
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoGetEtag = "DAV:getetag";

		// Token: 0x040001A6 RID: 422
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoGetLastModified = "DAV:getlastmodified";

		// Token: 0x040001A7 RID: 423
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoHasChildren = "DAV:haschildren";

		// Token: 0x040001A8 RID: 424
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoHasSubs = "DAV:hassubs";

		// Token: 0x040001A9 RID: 425
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoHref = "DAV:href";

		// Token: 0x040001AA RID: 426
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoId = "DAV:id";

		// Token: 0x040001AB RID: 427
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoIsCollection = "DAV:iscollection";

		// Token: 0x040001AC RID: 428
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoIsFolder = "DAV:isfolder";

		// Token: 0x040001AD RID: 429
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoIsHidden = "DAV:ishidden";

		// Token: 0x040001AE RID: 430
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoIsRoot = "DAV:isroot";

		// Token: 0x040001AF RID: 431
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoIsStructuredDocument = "DAV:isstructureddocument";

		// Token: 0x040001B0 RID: 432
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoLastAccessed = "DAV:lastaccessed";

		// Token: 0x040001B1 RID: 433
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoLastModified = "DAV:lastmodified";

		// Token: 0x040001B2 RID: 434
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoLockDiscovery = "DAV:lockdiscovery";

		// Token: 0x040001B3 RID: 435
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoNoSubs = "DAV:nosubs";

		// Token: 0x040001B4 RID: 436
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoObjectCount = "DAV:objectcount";

		// Token: 0x040001B5 RID: 437
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoParentName = "DAV:parentname";

		// Token: 0x040001B6 RID: 438
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoResourceType = "DAV:resourcetype";

		// Token: 0x040001B7 RID: 439
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoSupportedLock = "DAV:supportedlock";

		// Token: 0x040001B8 RID: 440
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoUID = "DAV:uid";

		// Token: 0x040001B9 RID: 441
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoVisibleCount = "DAV:visiblecount";
	}
}
