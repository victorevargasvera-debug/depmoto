using System;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x0200000E RID: 14
	[global::System.Runtime.Serialization.DataContract]
	public enum ProgressStatus
	{
		// Token: 0x04000059 RID: 89
		[global::System.Runtime.Serialization.EnumMember]
		None,
		// Token: 0x0400005A RID: 90
		[global::System.Runtime.Serialization.EnumMember]
		ReadingCP,
		// Token: 0x0400005B RID: 91
		[global::System.Runtime.Serialization.EnumMember]
		ReadCPDone,
		// Token: 0x0400005C RID: 92
		[global::System.Runtime.Serialization.EnumMember]
		ReadingLLP,
		// Token: 0x0400005D RID: 93
		[global::System.Runtime.Serialization.EnumMember]
		ReadLLPDone,
		// Token: 0x0400005E RID: 94
		[global::System.Runtime.Serialization.EnumMember]
		WritingCP,
		// Token: 0x0400005F RID: 95
		[global::System.Runtime.Serialization.EnumMember]
		ErasingCP,
		// Token: 0x04000060 RID: 96
		[global::System.Runtime.Serialization.EnumMember]
		EraseCPDone,
		// Token: 0x04000061 RID: 97
		[global::System.Runtime.Serialization.EnumMember]
		WriteCPDone,
		// Token: 0x04000062 RID: 98
		[global::System.Runtime.Serialization.EnumMember]
		WritingLLP,
		// Token: 0x04000063 RID: 99
		[global::System.Runtime.Serialization.EnumMember]
		WriteLLPDone,
		// Token: 0x04000064 RID: 100
		[global::System.Runtime.Serialization.EnumMember]
		WritingLanguages,
		// Token: 0x04000065 RID: 101
		[global::System.Runtime.Serialization.EnumMember]
		WriteLanguagesDone,
		// Token: 0x04000066 RID: 102
		[global::System.Runtime.Serialization.EnumMember]
		WritingSoftware,
		// Token: 0x04000067 RID: 103
		[global::System.Runtime.Serialization.EnumMember]
		WriteSoftwareDone,
		// Token: 0x04000068 RID: 104
		[global::System.Runtime.Serialization.EnumMember]
		EraseFlash,
		// Token: 0x04000069 RID: 105
		[global::System.Runtime.Serialization.EnumMember]
		UpgradeFlashStrap,
		// Token: 0x0400006A RID: 106
		[global::System.Runtime.Serialization.EnumMember]
		UpgradeFDT,
		// Token: 0x0400006B RID: 107
		[global::System.Runtime.Serialization.EnumMember]
		ReadImage,
		// Token: 0x0400006C RID: 108
		[global::System.Runtime.Serialization.EnumMember]
		WriteImage,
		// Token: 0x0400006D RID: 109
		[global::System.Runtime.Serialization.EnumMember]
		UpgradeRadio,
		// Token: 0x0400006E RID: 110
		[global::System.Runtime.Serialization.EnumMember]
		UpgradeHost,
		// Token: 0x0400006F RID: 111
		[global::System.Runtime.Serialization.EnumMember]
		UpgradeDsp,
		// Token: 0x04000070 RID: 112
		[global::System.Runtime.Serialization.EnumMember]
		UpgradeMace,
		// Token: 0x04000071 RID: 113
		[global::System.Runtime.Serialization.EnumMember]
		UpgradeOptBrd,
		// Token: 0x04000072 RID: 114
		[global::System.Runtime.Serialization.EnumMember]
		UpgradeAccBrd,
		// Token: 0x04000073 RID: 115
		[global::System.Runtime.Serialization.EnumMember]
		UpgradePsdt,
		// Token: 0x04000074 RID: 116
		[global::System.Runtime.Serialization.EnumMember]
		BootCommitting,
		// Token: 0x04000075 RID: 117
		[global::System.Runtime.Serialization.EnumMember]
		BootCommittingDone,
		// Token: 0x04000076 RID: 118
		[global::System.Runtime.Serialization.EnumMember]
		ReadingBootData,
		// Token: 0x04000077 RID: 119
		[global::System.Runtime.Serialization.EnumMember]
		ReadingBootDataDone,
		// Token: 0x04000078 RID: 120
		[global::System.Runtime.Serialization.EnumMember]
		WritingBootData,
		// Token: 0x04000079 RID: 121
		[global::System.Runtime.Serialization.EnumMember]
		WritingBootDataDone,
		// Token: 0x0400007A RID: 122
		[global::System.Runtime.Serialization.EnumMember]
		PrepareData
	}
}
