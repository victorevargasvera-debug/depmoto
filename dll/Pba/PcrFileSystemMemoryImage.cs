using System;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.Pba
{
	// Token: 0x0200000E RID: 14
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class PcrFileSystemMemoryImage : global::Motorola.Common.Communication.Pba.RadioImage
	{
		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000049 RID: 73 RVA: 0x000024C1 File Offset: 0x000006C1
		// (set) Token: 0x0600004A RID: 74 RVA: 0x000024C9 File Offset: 0x000006C9
		[global::System.Runtime.Serialization.DataMember]
		public int PartitionId { get; set; }

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600004B RID: 75 RVA: 0x000024D2 File Offset: 0x000006D2
		// (set) Token: 0x0600004C RID: 76 RVA: 0x000024DA File Offset: 0x000006DA
		[global::System.Runtime.Serialization.DataMember]
		public uint StartId { get; set; }

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600004D RID: 77 RVA: 0x000024E3 File Offset: 0x000006E3
		// (set) Token: 0x0600004E RID: 78 RVA: 0x000024EB File Offset: 0x000006EB
		[global::System.Runtime.Serialization.DataMember]
		public uint EndId { get; set; }

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600004F RID: 79 RVA: 0x000024F4 File Offset: 0x000006F4
		// (set) Token: 0x06000050 RID: 80 RVA: 0x000024FC File Offset: 0x000006FC
		[global::System.Runtime.Serialization.DataMember]
		public uint OptionFlag { get; set; }

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000051 RID: 81 RVA: 0x00002505 File Offset: 0x00000705
		// (set) Token: 0x06000052 RID: 82 RVA: 0x0000250D File Offset: 0x0000070D
		[global::System.Runtime.Serialization.DataMember]
		public bool IsDirectory { get; set; }

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000053 RID: 83 RVA: 0x00002516 File Offset: 0x00000716
		// (set) Token: 0x06000054 RID: 84 RVA: 0x0000251E File Offset: 0x0000071E
		[global::System.Runtime.Serialization.DataMember]
		public string RadioPathName { get; set; }

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000055 RID: 85 RVA: 0x00002527 File Offset: 0x00000727
		// (set) Token: 0x06000056 RID: 86 RVA: 0x0000252F File Offset: 0x0000072F
		[global::System.Runtime.Serialization.DataMember]
		public long FileSize { get; set; }

		// Token: 0x06000057 RID: 87 RVA: 0x00002538 File Offset: 0x00000738
		public PcrFileSystemMemoryImage()
		{
			base.FilePath = null;
			base.FileType = global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.Unknown;
			this.PartitionId = 0;
			this.StartId = 0U;
			this.EndId = 0U;
			this.OptionFlag = 0U;
			this.IsDirectory = false;
			this.RadioPathName = null;
			this.FileSize = 0L;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x0000258C File Offset: 0x0000078C
		public PcrFileSystemMemoryImage(global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType fileType, string filePath, int partitionId, uint startId, uint endId, uint optionFlag, bool isDirectory, string radioPathName, long fileSize)
		{
			base.FileType = fileType;
			base.FilePath = filePath;
			this.PartitionId = partitionId;
			this.StartId = startId;
			this.EndId = endId;
			this.OptionFlag = optionFlag;
			this.IsDirectory = isDirectory;
			this.RadioPathName = radioPathName;
			this.FileSize = fileSize;
		}
	}
}
