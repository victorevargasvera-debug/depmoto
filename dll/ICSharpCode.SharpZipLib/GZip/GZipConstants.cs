using System;

namespace ICSharpCode.SharpZipLib.GZip
{
	// Token: 0x02000025 RID: 37
	public sealed class GZipConstants
	{
		// Token: 0x06000103 RID: 259 RVA: 0x00007F48 File Offset: 0x00006F48
		private GZipConstants()
		{
		}

		// Token: 0x0400008B RID: 139
		public const int GZIP_MAGIC = 8075;

		// Token: 0x0400008C RID: 140
		public const int FTEXT = 1;

		// Token: 0x0400008D RID: 141
		public const int FHCRC = 2;

		// Token: 0x0400008E RID: 142
		public const int FEXTRA = 4;

		// Token: 0x0400008F RID: 143
		public const int FNAME = 8;

		// Token: 0x04000090 RID: 144
		public const int FCOMMENT = 16;
	}
}
