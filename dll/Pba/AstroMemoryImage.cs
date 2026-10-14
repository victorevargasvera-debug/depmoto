using System;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.Pba
{
	// Token: 0x02000007 RID: 7
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class AstroMemoryImage : global::Motorola.Common.Communication.Pba.RadioImage
	{
		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000016 RID: 22 RVA: 0x00002212 File Offset: 0x00000412
		// (set) Token: 0x06000017 RID: 23 RVA: 0x0000221A File Offset: 0x0000041A
		[global::System.Runtime.Serialization.DataMember]
		public string ComponentName { get; set; }

		// Token: 0x06000018 RID: 24 RVA: 0x00002223 File Offset: 0x00000423
		public AstroMemoryImage()
		{
			base.FilePath = null;
			base.FileType = global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.Unknown;
			this.ComponentName = null;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002240 File Offset: 0x00000440
		public AstroMemoryImage(global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType fileType, string filePath, string componentName)
		{
			base.FilePath = filePath;
			base.FileType = fileType;
			this.ComponentName = componentName;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x0000225D File Offset: 0x0000045D
		public AstroMemoryImage(global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType fileType, string filePath)
		{
			base.FilePath = filePath;
			base.FileType = fileType;
			this.ComponentName = null;
		}
	}
}
