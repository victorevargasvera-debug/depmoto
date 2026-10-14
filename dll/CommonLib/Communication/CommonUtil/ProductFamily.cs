using System;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x0200000C RID: 12
	[global::System.Runtime.Serialization.DataContract]
	public enum ProductFamily
	{
		// Token: 0x04000039 RID: 57
		[global::System.Runtime.Serialization.EnumMember]
		None,
		// Token: 0x0400003A RID: 58
		[global::System.Runtime.Serialization.EnumMember]
		AstroRadio,
		// Token: 0x0400003B RID: 59
		[global::System.Runtime.Serialization.EnumMember]
		MatrixRadio,
		// Token: 0x0400003C RID: 60
		[global::System.Runtime.Serialization.EnumMember]
		PhoenixRadio = 4,
		// Token: 0x0400003D RID: 61
		[global::System.Runtime.Serialization.EnumMember]
		ParadiseRadio = 8,
		// Token: 0x0400003E RID: 62
		[global::System.Runtime.Serialization.EnumMember]
		ParadiseLightRadio = 16,
		// Token: 0x0400003F RID: 63
		[global::System.Runtime.Serialization.EnumMember]
		ParadiseRepeaterRadio = 32,
		// Token: 0x04000040 RID: 64
		[global::System.Runtime.Serialization.EnumMember]
		MatrixRepeaterRadio = 64,
		// Token: 0x04000041 RID: 65
		[global::System.Runtime.Serialization.EnumMember]
		PCRRadio = 196734,
		// Token: 0x04000042 RID: 66
		[global::System.Runtime.Serialization.EnumMember]
		PBBRadio = 128,
		// Token: 0x04000043 RID: 67
		[global::System.Runtime.Serialization.EnumMember]
		LegacyProgRadio = 256,
		// Token: 0x04000044 RID: 68
		[global::System.Runtime.Serialization.EnumMember]
		LegacyAppRadio = 512,
		// Token: 0x04000045 RID: 69
		[global::System.Runtime.Serialization.EnumMember]
		FrodoProgRadio = 1024,
		// Token: 0x04000046 RID: 70
		[global::System.Runtime.Serialization.EnumMember]
		FrodoAppRadio = 2048,
		// Token: 0x04000047 RID: 71
		[global::System.Runtime.Serialization.EnumMember]
		GemstoneBMPProgRadio = 4096,
		// Token: 0x04000048 RID: 72
		[global::System.Runtime.Serialization.EnumMember]
		GemstoneBMPAppRadio = 8192,
		// Token: 0x04000049 RID: 73
		[global::System.Runtime.Serialization.EnumMember]
		GemstoneBMPMassStorageRadio = 16384,
		// Token: 0x0400004A RID: 74
		[global::System.Runtime.Serialization.EnumMember]
		TetraRadio = 32512,
		// Token: 0x0400004B RID: 75
		[global::System.Runtime.Serialization.EnumMember]
		DenaliRadio = 32768,
		// Token: 0x0400004C RID: 76
		[global::System.Runtime.Serialization.EnumMember]
		DMR3Controller = 65536,
		// Token: 0x0400004D RID: 77
		[global::System.Runtime.Serialization.EnumMember]
		MNIS = 131072,
		// Token: 0x0400004E RID: 78
		[global::System.Runtime.Serialization.EnumMember]
		Any = 65535
	}
}
