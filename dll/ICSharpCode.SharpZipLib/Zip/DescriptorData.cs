using System;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x02000075 RID: 117
	public class DescriptorData
	{
		// Token: 0x170000FB RID: 251
		// (get) Token: 0x06000468 RID: 1128 RVA: 0x00015B2E File Offset: 0x00014B2E
		// (set) Token: 0x06000469 RID: 1129 RVA: 0x00015B36 File Offset: 0x00014B36
		public long CompressedSize
		{
			get
			{
				return this.compressedSize;
			}
			set
			{
				this.compressedSize = value;
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x0600046A RID: 1130 RVA: 0x00015B3F File Offset: 0x00014B3F
		// (set) Token: 0x0600046B RID: 1131 RVA: 0x00015B47 File Offset: 0x00014B47
		public long Size
		{
			get
			{
				return this.size;
			}
			set
			{
				this.size = value;
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x0600046C RID: 1132 RVA: 0x00015B50 File Offset: 0x00014B50
		// (set) Token: 0x0600046D RID: 1133 RVA: 0x00015B58 File Offset: 0x00014B58
		public long Crc
		{
			get
			{
				return this.crc;
			}
			set
			{
				this.crc = (value & (long)((ulong)-1));
			}
		}

		// Token: 0x040002D1 RID: 721
		private long size;

		// Token: 0x040002D2 RID: 722
		private long compressedSize;

		// Token: 0x040002D3 RID: 723
		private long crc;
	}
}
