using System;

namespace FDISystem
{
	// Token: 0x02000014 RID: 20
	[global::System.Flags]
	[global::System.Serializable]
	public enum FDIErrorCodes
	{
		// Token: 0x0400007A RID: 122
		None = 0,
		// Token: 0x0400007B RID: 123
		Failure = 1,
		// Token: 0x0400007C RID: 124
		OutOfRam = 2,
		// Token: 0x0400007D RID: 125
		ChecksumFailure = 4,
		// Token: 0x0400007E RID: 126
		FlashFull = 8,
		// Token: 0x0400007F RID: 127
		FDIFailure = 16,
		// Token: 0x04000080 RID: 128
		Reclaiming = 32,
		// Token: 0x04000081 RID: 129
		LogicalBlockBad = 64,
		// Token: 0x04000082 RID: 130
		LogicalBlockDup = 128,
		// Token: 0x04000083 RID: 131
		ElementError = 256,
		// Token: 0x04000084 RID: 132
		FDIWarning = 512,
		// Token: 0x04000085 RID: 133
		CodeplugFailure = 1024,
		// Token: 0x04000086 RID: 134
		CodeplugExceedBlockSize = 1025,
		// Token: 0x04000087 RID: 135
		FileNoExist = 2048,
		// Token: 0x04000088 RID: 136
		FileFlashFull = 4096,
		// Token: 0x04000089 RID: 137
		FileNotFound = 8192,
		// Token: 0x0400008A RID: 138
		FileSystemFailure = 16384,
		// Token: 0x0400008B RID: 139
		FileSystemWarning = 32768,
		// Token: 0x0400008C RID: 140
		BaseFileWarning = 65536,
		// Token: 0x0400008D RID: 141
		MaxFilesExceeded = 131072,
		// Token: 0x0400008E RID: 142
		DirDuplicatedFile = 262144,
		// Token: 0x0400008F RID: 143
		DirNotFound = 524288,
		// Token: 0x04000090 RID: 144
		DirNotEmpty = 1048576,
		// Token: 0x04000091 RID: 145
		MaxNestExceeded = 2097152,
		// Token: 0x04000092 RID: 146
		OutOfTable = 4194304,
		// Token: 0x04000093 RID: 147
		AlreadyExists = 8388608,
		// Token: 0x04000094 RID: 148
		TableFull = 16777216
	}
}
