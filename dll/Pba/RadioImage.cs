using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Motorola.Common.Communication.Pba
{
	// Token: 0x02000005 RID: 5
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Xml.Serialization.XmlInclude(typeof(global::Motorola.Common.Communication.Pba.AstroMemoryImage))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.Common.Communication.Pba.PcrMemoryImage))]
	[global::System.Xml.Serialization.XmlInclude(typeof(global::Motorola.Common.Communication.Pba.TetraMemoryImage))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.Common.Communication.Pba.AstroMemoryImage))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.Common.Communication.Pba.PcrFileSystemMemoryImage))]
	[global::System.Xml.Serialization.XmlInclude(typeof(global::Motorola.Common.Communication.Pba.PcrMemoryImage))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.Common.Communication.Pba.TetraMemoryImage))]
	[global::System.Xml.Serialization.XmlInclude(typeof(global::Motorola.Common.Communication.Pba.PcrFileSystemMemoryImage))]
	[global::System.Serializable]
	public class RadioImage
	{
		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600000F RID: 15 RVA: 0x0000217E File Offset: 0x0000037E
		// (set) Token: 0x06000010 RID: 16 RVA: 0x00002186 File Offset: 0x00000386
		[global::System.Runtime.Serialization.DataMember]
		public string FilePath { get; set; }

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000011 RID: 17 RVA: 0x0000218F File Offset: 0x0000038F
		// (set) Token: 0x06000012 RID: 18 RVA: 0x00002197 File Offset: 0x00000397
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType FileType { get; set; }

		// Token: 0x06000013 RID: 19 RVA: 0x000021A0 File Offset: 0x000003A0
		public RadioImage()
		{
			this.FilePath = null;
			this.FileType = global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.Unknown;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000021B6 File Offset: 0x000003B6
		public RadioImage(global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType fileType, string filePath)
		{
			this.FilePath = filePath;
			this.FileType = fileType;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000021E4 File Offset: 0x000003E4
		public static global::Motorola.Common.Communication.Pba.RadioImage GetImageFromList(global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage> radioImages, global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType fileType)
		{
			return radioImages.Find((global::Motorola.Common.Communication.Pba.RadioImage ri) => ri.FileType == fileType);
		}

		// Token: 0x0400000E RID: 14
		[global::System.Runtime.Serialization.DataMember]
		[global::System.Runtime.Serialization.OptionalField]
		public byte[] fileData;

		// Token: 0x02000006 RID: 6
		[global::System.Runtime.Serialization.DataContract]
		public enum UpdateFileType
		{
			// Token: 0x04000012 RID: 18
			[global::System.Runtime.Serialization.EnumMember]
			Unknown,
			// Token: 0x04000013 RID: 19
			[global::System.Runtime.Serialization.EnumMember]
			ACCY,
			// Token: 0x04000014 RID: 20
			[global::System.Runtime.Serialization.EnumMember]
			BOOT,
			// Token: 0x04000015 RID: 21
			[global::System.Runtime.Serialization.EnumMember]
			CPG_APP,
			// Token: 0x04000016 RID: 22
			[global::System.Runtime.Serialization.EnumMember]
			DSP,
			// Token: 0x04000017 RID: 23
			[global::System.Runtime.Serialization.EnumMember]
			FLASHSTP,
			// Token: 0x04000018 RID: 24
			[global::System.Runtime.Serialization.EnumMember]
			HOST,
			// Token: 0x04000019 RID: 25
			[global::System.Runtime.Serialization.EnumMember]
			MACE,
			// Token: 0x0400001A RID: 26
			[global::System.Runtime.Serialization.EnumMember]
			OPTION,
			// Token: 0x0400001B RID: 27
			[global::System.Runtime.Serialization.EnumMember]
			PSDT,
			// Token: 0x0400001C RID: 28
			[global::System.Runtime.Serialization.EnumMember]
			SEC,
			// Token: 0x0400001D RID: 29
			[global::System.Runtime.Serialization.EnumMember]
			TUNE,
			// Token: 0x0400001E RID: 30
			[global::System.Runtime.Serialization.EnumMember]
			UCL,
			// Token: 0x0400001F RID: 31
			[global::System.Runtime.Serialization.EnumMember]
			TARGET_VERSION,
			// Token: 0x04000020 RID: 32
			[global::System.Runtime.Serialization.EnumMember]
			CONTROLLER_FPGA,
			// Token: 0x04000021 RID: 33
			[global::System.Runtime.Serialization.EnumMember]
			WIRELINE_FPGA,
			// Token: 0x04000022 RID: 34
			[global::System.Runtime.Serialization.EnumMember]
			FILESYSTEM,
			// Token: 0x04000023 RID: 35
			[global::System.Runtime.Serialization.EnumMember]
			FTL,
			// Token: 0x04000024 RID: 36
			[global::System.Runtime.Serialization.EnumMember]
			NAND,
			// Token: 0x04000025 RID: 37
			[global::System.Runtime.Serialization.EnumMember]
			CP_CFS,
			// Token: 0x04000026 RID: 38
			[global::System.Runtime.Serialization.EnumMember]
			CONFIGURATION,
			// Token: 0x04000027 RID: 39
			[global::System.Runtime.Serialization.EnumMember]
			KERNEL,
			// Token: 0x04000028 RID: 40
			[global::System.Runtime.Serialization.EnumMember]
			L2,
			// Token: 0x04000029 RID: 41
			[global::System.Runtime.Serialization.EnumMember]
			L3,
			// Token: 0x0400002A RID: 42
			[global::System.Runtime.Serialization.EnumMember]
			RFS,
			// Token: 0x0400002B RID: 43
			[global::System.Runtime.Serialization.EnumMember]
			APP,
			// Token: 0x0400002C RID: 44
			[global::System.Runtime.Serialization.EnumMember]
			APP_UTILITIES,
			// Token: 0x0400002D RID: 45
			[global::System.Runtime.Serialization.EnumMember]
			PARTITION_TABLE,
			// Token: 0x0400002E RID: 46
			[global::System.Runtime.Serialization.EnumMember]
			CONTROL_HEAD,
			// Token: 0x0400002F RID: 47
			[global::System.Runtime.Serialization.EnumMember]
			BLUETOOTH_GPS,
			// Token: 0x04000030 RID: 48
			[global::System.Runtime.Serialization.EnumMember]
			DATA_IMAGE,
			// Token: 0x04000031 RID: 49
			[global::System.Runtime.Serialization.EnumMember]
			FILE_CHANGE_LIST,
			// Token: 0x04000032 RID: 50
			[global::System.Runtime.Serialization.EnumMember]
			GLOBAL_MARKER,
			// Token: 0x04000033 RID: 51
			[global::System.Runtime.Serialization.EnumMember]
			FTL_APPSECCFS,
			// Token: 0x04000034 RID: 52
			[global::System.Runtime.Serialization.EnumMember]
			FTL_TUNING,
			// Token: 0x04000035 RID: 53
			[global::System.Runtime.Serialization.EnumMember]
			CPG_UDP,
			// Token: 0x04000036 RID: 54
			[global::System.Runtime.Serialization.EnumMember]
			FLASHTOFILESYSTEM,
			// Token: 0x04000037 RID: 55
			[global::System.Runtime.Serialization.EnumMember]
			SCRIPT_PRE_INIT = 38,
			// Token: 0x04000038 RID: 56
			[global::System.Runtime.Serialization.EnumMember]
			SCRIPT_INIT,
			// Token: 0x04000039 RID: 57
			[global::System.Runtime.Serialization.EnumMember]
			SCRIPT_RC,
			// Token: 0x0400003A RID: 58
			[global::System.Runtime.Serialization.EnumMember]
			SCRIPT_UPGRADE,
			// Token: 0x0400003B RID: 59
			[global::System.Runtime.Serialization.EnumMember]
			DTP_FIRMWARE,
			// Token: 0x0400003C RID: 60
			[global::System.Runtime.Serialization.EnumMember]
			FRU_PA,
			// Token: 0x0400003D RID: 61
			[global::System.Runtime.Serialization.EnumMember]
			FRU_PSU,
			// Token: 0x0400003E RID: 62
			[global::System.Runtime.Serialization.EnumMember]
			FRU_FP,
			// Token: 0x0400003F RID: 63
			[global::System.Runtime.Serialization.EnumMember]
			SCRIPT_OVERWRITE,
			// Token: 0x04000040 RID: 64
			[global::System.Runtime.Serialization.EnumMember]
			PSMARKER
		}
	}
}
