using System;
using System.Collections.Generic;

namespace System.Data.SQLite
{
	// Token: 0x02000089 RID: 137
	public class SQLiteModuleNoop : global::System.Data.SQLite.SQLiteModule
	{
		// Token: 0x060005F1 RID: 1521 RVA: 0x00024908 File Offset: 0x00023D08
		public SQLiteModuleNoop(string name) : base(name)
		{
			this.resultCodes = new global::System.Collections.Generic.Dictionary<string, global::System.Data.SQLite.SQLiteErrorCode>();
		}

		// Token: 0x060005F2 RID: 1522 RVA: 0x00024928 File Offset: 0x00023D28
		protected virtual global::System.Data.SQLite.SQLiteErrorCode GetDefaultResultCode()
		{
			return global::System.Data.SQLite.SQLiteErrorCode.Ok;
		}

		// Token: 0x060005F3 RID: 1523 RVA: 0x00024938 File Offset: 0x00023D38
		protected virtual bool ResultCodeToEofResult(global::System.Data.SQLite.SQLiteErrorCode resultCode)
		{
			return resultCode != global::System.Data.SQLite.SQLiteErrorCode.Ok;
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x0002494C File Offset: 0x00023D4C
		protected virtual bool ResultCodeToFindFunctionResult(global::System.Data.SQLite.SQLiteErrorCode resultCode)
		{
			return resultCode == global::System.Data.SQLite.SQLiteErrorCode.Ok;
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x00024960 File Offset: 0x00023D60
		protected virtual global::System.Data.SQLite.SQLiteErrorCode GetMethodResultCode(string methodName)
		{
			if (methodName == null || this.resultCodes == null)
			{
				return this.GetDefaultResultCode();
			}
			global::System.Data.SQLite.SQLiteErrorCode result;
			if (this.resultCodes != null && this.resultCodes.TryGetValue(methodName, out result))
			{
				return result;
			}
			return this.GetDefaultResultCode();
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x000249A0 File Offset: 0x00023DA0
		protected virtual bool SetMethodResultCode(string methodName, global::System.Data.SQLite.SQLiteErrorCode resultCode)
		{
			if (methodName == null || this.resultCodes == null)
			{
				return false;
			}
			this.resultCodes[methodName] = resultCode;
			return true;
		}

		// Token: 0x060005F7 RID: 1527 RVA: 0x000249C8 File Offset: 0x00023DC8
		public override global::System.Data.SQLite.SQLiteErrorCode Create(global::System.Data.SQLite.SQLiteConnection connection, global::System.IntPtr pClientData, string[] arguments, ref global::System.Data.SQLite.SQLiteVirtualTable table, ref string error)
		{
			this.CheckDisposed();
			return this.GetMethodResultCode("Create");
		}

		// Token: 0x060005F8 RID: 1528 RVA: 0x000249E8 File Offset: 0x00023DE8
		public override global::System.Data.SQLite.SQLiteErrorCode Connect(global::System.Data.SQLite.SQLiteConnection connection, global::System.IntPtr pClientData, string[] arguments, ref global::System.Data.SQLite.SQLiteVirtualTable table, ref string error)
		{
			this.CheckDisposed();
			return this.GetMethodResultCode("Connect");
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x00024A08 File Offset: 0x00023E08
		public override global::System.Data.SQLite.SQLiteErrorCode BestIndex(global::System.Data.SQLite.SQLiteVirtualTable table, global::System.Data.SQLite.SQLiteIndex index)
		{
			this.CheckDisposed();
			return this.GetMethodResultCode("BestIndex");
		}

		// Token: 0x060005FA RID: 1530 RVA: 0x00024A28 File Offset: 0x00023E28
		public override global::System.Data.SQLite.SQLiteErrorCode Disconnect(global::System.Data.SQLite.SQLiteVirtualTable table)
		{
			this.CheckDisposed();
			return this.GetMethodResultCode("Disconnect");
		}

		// Token: 0x060005FB RID: 1531 RVA: 0x00024A48 File Offset: 0x00023E48
		public override global::System.Data.SQLite.SQLiteErrorCode Destroy(global::System.Data.SQLite.SQLiteVirtualTable table)
		{
			this.CheckDisposed();
			return this.GetMethodResultCode("Destroy");
		}

		// Token: 0x060005FC RID: 1532 RVA: 0x00024A68 File Offset: 0x00023E68
		public override global::System.Data.SQLite.SQLiteErrorCode Open(global::System.Data.SQLite.SQLiteVirtualTable table, ref global::System.Data.SQLite.SQLiteVirtualTableCursor cursor)
		{
			this.CheckDisposed();
			return this.GetMethodResultCode("Open");
		}

		// Token: 0x060005FD RID: 1533 RVA: 0x00024A88 File Offset: 0x00023E88
		public override global::System.Data.SQLite.SQLiteErrorCode Close(global::System.Data.SQLite.SQLiteVirtualTableCursor cursor)
		{
			this.CheckDisposed();
			return this.GetMethodResultCode("Close");
		}

		// Token: 0x060005FE RID: 1534 RVA: 0x00024AA8 File Offset: 0x00023EA8
		public override global::System.Data.SQLite.SQLiteErrorCode Filter(global::System.Data.SQLite.SQLiteVirtualTableCursor cursor, int indexNumber, string indexString, global::System.Data.SQLite.SQLiteValue[] values)
		{
			this.CheckDisposed();
			return this.GetMethodResultCode("Filter");
		}

		// Token: 0x060005FF RID: 1535 RVA: 0x00024AC8 File Offset: 0x00023EC8
		public override global::System.Data.SQLite.SQLiteErrorCode Next(global::System.Data.SQLite.SQLiteVirtualTableCursor cursor)
		{
			this.CheckDisposed();
			return this.GetMethodResultCode("Next");
		}

		// Token: 0x06000600 RID: 1536 RVA: 0x00024AE8 File Offset: 0x00023EE8
		public override bool Eof(global::System.Data.SQLite.SQLiteVirtualTableCursor cursor)
		{
			this.CheckDisposed();
			return this.ResultCodeToEofResult(this.GetMethodResultCode("Eof"));
		}

		// Token: 0x06000601 RID: 1537 RVA: 0x00024B0C File Offset: 0x00023F0C
		public override global::System.Data.SQLite.SQLiteErrorCode Column(global::System.Data.SQLite.SQLiteVirtualTableCursor cursor, global::System.Data.SQLite.SQLiteContext context, int index)
		{
			this.CheckDisposed();
			return this.GetMethodResultCode("Column");
		}

		// Token: 0x06000602 RID: 1538 RVA: 0x00024B2C File Offset: 0x00023F2C
		public override global::System.Data.SQLite.SQLiteErrorCode RowId(global::System.Data.SQLite.SQLiteVirtualTableCursor cursor, ref long rowId)
		{
			this.CheckDisposed();
			return this.GetMethodResultCode("RowId");
		}

		// Token: 0x06000603 RID: 1539 RVA: 0x00024B4C File Offset: 0x00023F4C
		public override global::System.Data.SQLite.SQLiteErrorCode Update(global::System.Data.SQLite.SQLiteVirtualTable table, global::System.Data.SQLite.SQLiteValue[] values, ref long rowId)
		{
			this.CheckDisposed();
			return this.GetMethodResultCode("Update");
		}

		// Token: 0x06000604 RID: 1540 RVA: 0x00024B6C File Offset: 0x00023F6C
		public override global::System.Data.SQLite.SQLiteErrorCode Begin(global::System.Data.SQLite.SQLiteVirtualTable table)
		{
			this.CheckDisposed();
			return this.GetMethodResultCode("Begin");
		}

		// Token: 0x06000605 RID: 1541 RVA: 0x00024B8C File Offset: 0x00023F8C
		public override global::System.Data.SQLite.SQLiteErrorCode Sync(global::System.Data.SQLite.SQLiteVirtualTable table)
		{
			this.CheckDisposed();
			return this.GetMethodResultCode("Sync");
		}

		// Token: 0x06000606 RID: 1542 RVA: 0x00024BAC File Offset: 0x00023FAC
		public override global::System.Data.SQLite.SQLiteErrorCode Commit(global::System.Data.SQLite.SQLiteVirtualTable table)
		{
			this.CheckDisposed();
			return this.GetMethodResultCode("Commit");
		}

		// Token: 0x06000607 RID: 1543 RVA: 0x00024BCC File Offset: 0x00023FCC
		public override global::System.Data.SQLite.SQLiteErrorCode Rollback(global::System.Data.SQLite.SQLiteVirtualTable table)
		{
			this.CheckDisposed();
			return this.GetMethodResultCode("Rollback");
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x00024BEC File Offset: 0x00023FEC
		public override bool FindFunction(global::System.Data.SQLite.SQLiteVirtualTable table, int argumentCount, string name, ref global::System.Data.SQLite.SQLiteFunction function, ref global::System.IntPtr pClientData)
		{
			this.CheckDisposed();
			return this.ResultCodeToFindFunctionResult(this.GetMethodResultCode("FindFunction"));
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x00024C10 File Offset: 0x00024010
		public override global::System.Data.SQLite.SQLiteErrorCode Rename(global::System.Data.SQLite.SQLiteVirtualTable table, string newName)
		{
			this.CheckDisposed();
			return this.GetMethodResultCode("Rename");
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x00024C30 File Offset: 0x00024030
		public override global::System.Data.SQLite.SQLiteErrorCode Savepoint(global::System.Data.SQLite.SQLiteVirtualTable table, int savepoint)
		{
			this.CheckDisposed();
			return this.GetMethodResultCode("Savepoint");
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x00024C50 File Offset: 0x00024050
		public override global::System.Data.SQLite.SQLiteErrorCode Release(global::System.Data.SQLite.SQLiteVirtualTable table, int savepoint)
		{
			this.CheckDisposed();
			return this.GetMethodResultCode("Release");
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x00024C70 File Offset: 0x00024070
		public override global::System.Data.SQLite.SQLiteErrorCode RollbackTo(global::System.Data.SQLite.SQLiteVirtualTable table, int savepoint)
		{
			this.CheckDisposed();
			return this.GetMethodResultCode("RollbackTo");
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x00024C90 File Offset: 0x00024090
		private void CheckDisposed()
		{
			if (this.disposed)
			{
				throw new global::System.ObjectDisposedException(typeof(global::System.Data.SQLite.SQLiteModuleNoop).Name);
			}
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x00024CBC File Offset: 0x000240BC
		protected override void Dispose(bool disposing)
		{
			try
			{
				bool flag = this.disposed;
			}
			finally
			{
				base.Dispose(disposing);
				this.disposed = true;
			}
		}

		// Token: 0x04000238 RID: 568
		private global::System.Collections.Generic.Dictionary<string, global::System.Data.SQLite.SQLiteErrorCode> resultCodes;

		// Token: 0x04000239 RID: 569
		private bool disposed;
	}
}
