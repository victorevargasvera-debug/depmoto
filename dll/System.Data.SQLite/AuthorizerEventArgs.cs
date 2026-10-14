using System;

namespace System.Data.SQLite
{
	// Token: 0x0200001E RID: 30
	public class AuthorizerEventArgs : global::System.EventArgs
	{
		// Token: 0x06000240 RID: 576 RVA: 0x00019178 File Offset: 0x00018578
		private AuthorizerEventArgs()
		{
			this.UserData = global::System.IntPtr.Zero;
			this.ActionCode = global::System.Data.SQLite.SQLiteAuthorizerActionCode.None;
			this.Argument1 = null;
			this.Argument2 = null;
			this.Database = null;
			this.Context = null;
			this.ReturnCode = global::System.Data.SQLite.SQLiteAuthorizerReturnCode.Ok;
		}

		// Token: 0x06000241 RID: 577 RVA: 0x000191C0 File Offset: 0x000185C0
		internal AuthorizerEventArgs(global::System.IntPtr pUserData, global::System.Data.SQLite.SQLiteAuthorizerActionCode actionCode, string argument1, string argument2, string database, string context, global::System.Data.SQLite.SQLiteAuthorizerReturnCode returnCode) : this()
		{
			this.UserData = pUserData;
			this.ActionCode = actionCode;
			this.Argument1 = argument1;
			this.Argument2 = argument2;
			this.Database = database;
			this.Context = context;
			this.ReturnCode = returnCode;
		}

		// Token: 0x040000B4 RID: 180
		public readonly global::System.IntPtr UserData;

		// Token: 0x040000B5 RID: 181
		public readonly global::System.Data.SQLite.SQLiteAuthorizerActionCode ActionCode;

		// Token: 0x040000B6 RID: 182
		public readonly string Argument1;

		// Token: 0x040000B7 RID: 183
		public readonly string Argument2;

		// Token: 0x040000B8 RID: 184
		public readonly string Database;

		// Token: 0x040000B9 RID: 185
		public readonly string Context;

		// Token: 0x040000BA RID: 186
		public global::System.Data.SQLite.SQLiteAuthorizerReturnCode ReturnCode;
	}
}
