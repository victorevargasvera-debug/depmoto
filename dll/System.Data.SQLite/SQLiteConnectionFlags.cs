using System;

namespace System.Data.SQLite
{
	// Token: 0x0200000C RID: 12
	[global::System.Flags]
	public enum SQLiteConnectionFlags
	{
		// Token: 0x04000036 RID: 54
		None = 0,
		// Token: 0x04000037 RID: 55
		LogPrepare = 1,
		// Token: 0x04000038 RID: 56
		LogPreBind = 2,
		// Token: 0x04000039 RID: 57
		LogBind = 4,
		// Token: 0x0400003A RID: 58
		LogCallbackException = 8,
		// Token: 0x0400003B RID: 59
		LogBackup = 16,
		// Token: 0x0400003C RID: 60
		NoExtensionFunctions = 32,
		// Token: 0x0400003D RID: 61
		BindUInt32AsInt64 = 64,
		// Token: 0x0400003E RID: 62
		BindAllAsText = 128,
		// Token: 0x0400003F RID: 63
		GetAllAsText = 256,
		// Token: 0x04000040 RID: 64
		NoLoadExtension = 512,
		// Token: 0x04000041 RID: 65
		NoCreateModule = 1024,
		// Token: 0x04000042 RID: 66
		NoBindFunctions = 2048,
		// Token: 0x04000043 RID: 67
		NoLogModule = 4096,
		// Token: 0x04000044 RID: 68
		LogModuleError = 8192,
		// Token: 0x04000045 RID: 69
		LogModuleException = 16384,
		// Token: 0x04000046 RID: 70
		BindAndGetAllAsText = 384,
		// Token: 0x04000047 RID: 71
		LogAll = 24607,
		// Token: 0x04000048 RID: 72
		Default = 16392
	}
}
