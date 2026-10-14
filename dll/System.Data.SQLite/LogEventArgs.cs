using System;

namespace System.Data.SQLite
{
	// Token: 0x02000049 RID: 73
	public class LogEventArgs : global::System.EventArgs
	{
		// Token: 0x0600035A RID: 858 RVA: 0x0001EF5C File Offset: 0x0001E35C
		internal LogEventArgs(global::System.IntPtr pUserData, object errorCode, string message, object data)
		{
			this.ErrorCode = errorCode;
			this.Message = message;
			this.Data = data;
		}

		// Token: 0x0400019D RID: 413
		public readonly object ErrorCode;

		// Token: 0x0400019E RID: 414
		public readonly string Message;

		// Token: 0x0400019F RID: 415
		public readonly object Data;
	}
}
