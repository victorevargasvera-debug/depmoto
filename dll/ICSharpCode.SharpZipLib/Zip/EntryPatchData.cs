using System;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x02000076 RID: 118
	internal class EntryPatchData
	{
		// Token: 0x170000FE RID: 254
		// (get) Token: 0x0600046F RID: 1135 RVA: 0x00015B6C File Offset: 0x00014B6C
		// (set) Token: 0x06000470 RID: 1136 RVA: 0x00015B74 File Offset: 0x00014B74
		public long SizePatchOffset
		{
			get
			{
				return this.sizePatchOffset_;
			}
			set
			{
				this.sizePatchOffset_ = value;
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x06000471 RID: 1137 RVA: 0x00015B7D File Offset: 0x00014B7D
		// (set) Token: 0x06000472 RID: 1138 RVA: 0x00015B85 File Offset: 0x00014B85
		public long CrcPatchOffset
		{
			get
			{
				return this.crcPatchOffset_;
			}
			set
			{
				this.crcPatchOffset_ = value;
			}
		}

		// Token: 0x040002D4 RID: 724
		private long sizePatchOffset_;

		// Token: 0x040002D5 RID: 725
		private long crcPatchOffset_;
	}
}
