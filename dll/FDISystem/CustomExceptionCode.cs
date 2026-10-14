using System;

namespace FDISystem
{
	// Token: 0x02000013 RID: 19
	internal enum CustomExceptionCode
	{
		// Token: 0x0400005D RID: 93
		Failure = 1,
		// Token: 0x0400005E RID: 94
		OutOfRam,
		// Token: 0x0400005F RID: 95
		ChecksumFailure,
		// Token: 0x04000060 RID: 96
		FlashFull,
		// Token: 0x04000061 RID: 97
		FDIFailure,
		// Token: 0x04000062 RID: 98
		Reclaiming,
		// Token: 0x04000063 RID: 99
		LogicalBlockBad,
		// Token: 0x04000064 RID: 100
		LogicalBlockDup,
		// Token: 0x04000065 RID: 101
		ElementError,
		// Token: 0x04000066 RID: 102
		FDIWarning,
		// Token: 0x04000067 RID: 103
		FileNoExist = 100,
		// Token: 0x04000068 RID: 104
		FileFlashFull,
		// Token: 0x04000069 RID: 105
		FileNotFound,
		// Token: 0x0400006A RID: 106
		FileSystemFailure,
		// Token: 0x0400006B RID: 107
		FileSystemWarning,
		// Token: 0x0400006C RID: 108
		BaseFileWarning,
		// Token: 0x0400006D RID: 109
		MaxFilesExceeded = 150,
		// Token: 0x0400006E RID: 110
		DirDuplicatedFile,
		// Token: 0x0400006F RID: 111
		DirNotFound,
		// Token: 0x04000070 RID: 112
		DirNotEmpty,
		// Token: 0x04000071 RID: 113
		MaxNestExceeded,
		// Token: 0x04000072 RID: 114
		CodeplugFailure = 201,
		// Token: 0x04000073 RID: 115
		CodeplugExceedBlockSize,
		// Token: 0x04000074 RID: 116
		OutOfTable = 250,
		// Token: 0x04000075 RID: 117
		AlreadyExists,
		// Token: 0x04000076 RID: 118
		TableFull,
		// Token: 0x04000077 RID: 119
		InvalidErrorCode = 998,
		// Token: 0x04000078 RID: 120
		DotFXException
	}
}
