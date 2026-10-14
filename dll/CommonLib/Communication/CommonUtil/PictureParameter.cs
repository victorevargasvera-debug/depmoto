using System;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000067 RID: 103
	[global::System.Serializable]
	public class PictureParameter : global::System.ICloneable
	{
		// Token: 0x17000114 RID: 276
		// (get) Token: 0x060002F2 RID: 754 RVA: 0x00007BF4 File Offset: 0x00005DF4
		// (set) Token: 0x060002F3 RID: 755 RVA: 0x00007BFC File Offset: 0x00005DFC
		public string FolderPath
		{
			get
			{
				return this._folderPath;
			}
			set
			{
				this._folderPath = value;
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x060002F4 RID: 756 RVA: 0x00007C05 File Offset: 0x00005E05
		// (set) Token: 0x060002F5 RID: 757 RVA: 0x00007C0D File Offset: 0x00005E0D
		public string ArchiveFile
		{
			get
			{
				return this._archiveFile;
			}
			set
			{
				this._archiveFile = value;
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x060002F6 RID: 758 RVA: 0x00007C16 File Offset: 0x00005E16
		// (set) Token: 0x060002F7 RID: 759 RVA: 0x00007C1E File Offset: 0x00005E1E
		public bool bFlag
		{
			get
			{
				return this._bFlag;
			}
			set
			{
				this._bFlag = value;
			}
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x00007C28 File Offset: 0x00005E28
		public object Clone()
		{
			global::Motorola.Common.Communication.CommonUtil.PictureParameter pictureParameter = base.MemberwiseClone() as global::Motorola.Common.Communication.CommonUtil.PictureParameter;
			pictureParameter.FolderPath = this.FolderPath;
			pictureParameter.ArchiveFile = this.ArchiveFile;
			pictureParameter.bFlag = this.bFlag;
			return pictureParameter;
		}

		// Token: 0x04000360 RID: 864
		private string _folderPath = string.Empty;

		// Token: 0x04000361 RID: 865
		private string _archiveFile = string.Empty;

		// Token: 0x04000362 RID: 866
		private bool _bFlag;
	}
}
