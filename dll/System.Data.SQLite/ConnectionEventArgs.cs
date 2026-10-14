using System;
using System.Runtime.InteropServices;

namespace System.Data.SQLite
{
	// Token: 0x02000010 RID: 16
	public class ConnectionEventArgs : global::System.EventArgs
	{
		// Token: 0x0600018B RID: 395 RVA: 0x000133C8 File Offset: 0x000127C8
		internal ConnectionEventArgs(global::System.Data.SQLite.SQLiteConnectionEventType eventType, global::System.Data.StateChangeEventArgs eventArgs, global::System.Data.IDbTransaction transaction, global::System.Data.IDbCommand command, global::System.Data.IDataReader dataReader, global::System.Runtime.InteropServices.CriticalHandle criticalHandle, string text, object data)
		{
			this.EventType = eventType;
			this.EventArgs = eventArgs;
			this.Transaction = transaction;
			this.Command = command;
			this.DataReader = dataReader;
			this.CriticalHandle = criticalHandle;
			this.Text = text;
			this.Data = data;
		}

		// Token: 0x04000068 RID: 104
		public readonly global::System.Data.SQLite.SQLiteConnectionEventType EventType;

		// Token: 0x04000069 RID: 105
		public readonly global::System.Data.StateChangeEventArgs EventArgs;

		// Token: 0x0400006A RID: 106
		public readonly global::System.Data.IDbTransaction Transaction;

		// Token: 0x0400006B RID: 107
		public readonly global::System.Data.IDbCommand Command;

		// Token: 0x0400006C RID: 108
		public readonly global::System.Data.IDataReader DataReader;

		// Token: 0x0400006D RID: 109
		public readonly global::System.Runtime.InteropServices.CriticalHandle CriticalHandle;

		// Token: 0x0400006E RID: 110
		public readonly string Text;

		// Token: 0x0400006F RID: 111
		public readonly object Data;
	}
}
