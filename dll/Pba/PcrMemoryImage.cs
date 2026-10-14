using System;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.Pba
{
	// Token: 0x02000010 RID: 16
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class PcrMemoryImage : global::Motorola.Common.Communication.Pba.RadioImage
	{
		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000066 RID: 102 RVA: 0x0000268A File Offset: 0x0000088A
		// (set) Token: 0x06000067 RID: 103 RVA: 0x00002692 File Offset: 0x00000892
		[global::System.Runtime.Serialization.DataMember]
		public int StartAddress { get; set; }

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000068 RID: 104 RVA: 0x0000269B File Offset: 0x0000089B
		// (set) Token: 0x06000069 RID: 105 RVA: 0x000026A3 File Offset: 0x000008A3
		[global::System.Runtime.Serialization.DataMember]
		public int EndAddress { get; set; }

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600006A RID: 106 RVA: 0x000026AC File Offset: 0x000008AC
		// (set) Token: 0x0600006B RID: 107 RVA: 0x000026B4 File Offset: 0x000008B4
		[global::System.Runtime.Serialization.DataMember]
		public bool RemoteImage { get; set; }

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x0600006C RID: 108 RVA: 0x000026BD File Offset: 0x000008BD
		// (set) Token: 0x0600006D RID: 109 RVA: 0x000026C5 File Offset: 0x000008C5
		[global::System.Runtime.Serialization.DataMember]
		public int ImageSize { get; set; }

		// Token: 0x0600006E RID: 110 RVA: 0x000026CE File Offset: 0x000008CE
		public PcrMemoryImage()
		{
			base.FilePath = null;
			base.FileType = global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.Unknown;
			this.StartAddress = 0;
			this.EndAddress = 0;
			this.RemoteImage = false;
			this.ImageSize = 0;
		}
	}
}
