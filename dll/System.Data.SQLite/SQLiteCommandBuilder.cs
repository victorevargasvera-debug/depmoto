using System;
using System.ComponentModel;
using System.Data.Common;
using System.Globalization;

namespace System.Data.SQLite
{
	// Token: 0x0200000F RID: 15
	public sealed class SQLiteCommandBuilder : global::System.Data.Common.DbCommandBuilder
	{
		// Token: 0x0600016A RID: 362 RVA: 0x00012D7C File Offset: 0x0001217C
		public SQLiteCommandBuilder() : this(null)
		{
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00012D90 File Offset: 0x00012190
		public SQLiteCommandBuilder(global::System.Data.SQLite.SQLiteDataAdapter adp)
		{
			this.QuotePrefix = "[";
			this.QuoteSuffix = "]";
			this.DataAdapter = adp;
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00012DC0 File Offset: 0x000121C0
		private void CheckDisposed()
		{
			if (this.disposed)
			{
				throw new global::System.ObjectDisposedException(typeof(global::System.Data.SQLite.SQLiteCommandBuilder).Name);
			}
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00012DEC File Offset: 0x000121EC
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

		// Token: 0x0600016E RID: 366 RVA: 0x00012E30 File Offset: 0x00012230
		protected override void ApplyParameterInfo(global::System.Data.Common.DbParameter parameter, global::System.Data.DataRow row, global::System.Data.StatementType statementType, bool whereClause)
		{
			global::System.Data.SQLite.SQLiteParameter sqliteParameter = (global::System.Data.SQLite.SQLiteParameter)parameter;
			sqliteParameter.DbType = (global::System.Data.DbType)row[global::System.Data.Common.SchemaTableColumn.ProviderType];
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00012E5C File Offset: 0x0001225C
		protected override string GetParameterName(string parameterName)
		{
			return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "@{0}", new object[]
			{
				parameterName
			});
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00012E84 File Offset: 0x00012284
		protected override string GetParameterName(int parameterOrdinal)
		{
			return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "@param{0}", new object[]
			{
				parameterOrdinal
			});
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00012EB4 File Offset: 0x000122B4
		protected override string GetParameterPlaceholder(int parameterOrdinal)
		{
			return this.GetParameterName(parameterOrdinal);
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00012EC8 File Offset: 0x000122C8
		protected override void SetRowUpdatingHandler(global::System.Data.Common.DbDataAdapter adapter)
		{
			if (adapter == base.DataAdapter)
			{
				((global::System.Data.SQLite.SQLiteDataAdapter)adapter).RowUpdating -= this.RowUpdatingEventHandler;
				return;
			}
			((global::System.Data.SQLite.SQLiteDataAdapter)adapter).RowUpdating += this.RowUpdatingEventHandler;
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00012F10 File Offset: 0x00012310
		private void RowUpdatingEventHandler(object sender, global::System.Data.Common.RowUpdatingEventArgs e)
		{
			base.RowUpdatingHandler(e);
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000174 RID: 372 RVA: 0x00012F24 File Offset: 0x00012324
		// (set) Token: 0x06000175 RID: 373 RVA: 0x00012F44 File Offset: 0x00012344
		public new global::System.Data.SQLite.SQLiteDataAdapter DataAdapter
		{
			get
			{
				this.CheckDisposed();
				return (global::System.Data.SQLite.SQLiteDataAdapter)base.DataAdapter;
			}
			set
			{
				this.CheckDisposed();
				base.DataAdapter = value;
			}
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00012F60 File Offset: 0x00012360
		public new global::System.Data.SQLite.SQLiteCommand GetDeleteCommand()
		{
			this.CheckDisposed();
			return (global::System.Data.SQLite.SQLiteCommand)base.GetDeleteCommand();
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00012F80 File Offset: 0x00012380
		public new global::System.Data.SQLite.SQLiteCommand GetDeleteCommand(bool useColumnsForParameterNames)
		{
			this.CheckDisposed();
			return (global::System.Data.SQLite.SQLiteCommand)base.GetDeleteCommand(useColumnsForParameterNames);
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00012FA0 File Offset: 0x000123A0
		public new global::System.Data.SQLite.SQLiteCommand GetUpdateCommand()
		{
			this.CheckDisposed();
			return (global::System.Data.SQLite.SQLiteCommand)base.GetUpdateCommand();
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00012FC0 File Offset: 0x000123C0
		public new global::System.Data.SQLite.SQLiteCommand GetUpdateCommand(bool useColumnsForParameterNames)
		{
			this.CheckDisposed();
			return (global::System.Data.SQLite.SQLiteCommand)base.GetUpdateCommand(useColumnsForParameterNames);
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00012FE0 File Offset: 0x000123E0
		public new global::System.Data.SQLite.SQLiteCommand GetInsertCommand()
		{
			this.CheckDisposed();
			return (global::System.Data.SQLite.SQLiteCommand)base.GetInsertCommand();
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00013000 File Offset: 0x00012400
		public new global::System.Data.SQLite.SQLiteCommand GetInsertCommand(bool useColumnsForParameterNames)
		{
			this.CheckDisposed();
			return (global::System.Data.SQLite.SQLiteCommand)base.GetInsertCommand(useColumnsForParameterNames);
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600017C RID: 380 RVA: 0x00013020 File Offset: 0x00012420
		// (set) Token: 0x0600017D RID: 381 RVA: 0x0001303C File Offset: 0x0001243C
		[global::System.ComponentModel.Browsable(false)]
		public override global::System.Data.Common.CatalogLocation CatalogLocation
		{
			get
			{
				this.CheckDisposed();
				return base.CatalogLocation;
			}
			set
			{
				this.CheckDisposed();
				base.CatalogLocation = value;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600017E RID: 382 RVA: 0x00013058 File Offset: 0x00012458
		// (set) Token: 0x0600017F RID: 383 RVA: 0x00013074 File Offset: 0x00012474
		[global::System.ComponentModel.Browsable(false)]
		public override string CatalogSeparator
		{
			get
			{
				this.CheckDisposed();
				return base.CatalogSeparator;
			}
			set
			{
				this.CheckDisposed();
				base.CatalogSeparator = value;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000180 RID: 384 RVA: 0x00013090 File Offset: 0x00012490
		// (set) Token: 0x06000181 RID: 385 RVA: 0x000130AC File Offset: 0x000124AC
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DefaultValue("[")]
		public override string QuotePrefix
		{
			get
			{
				this.CheckDisposed();
				return base.QuotePrefix;
			}
			set
			{
				this.CheckDisposed();
				base.QuotePrefix = value;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000182 RID: 386 RVA: 0x000130C8 File Offset: 0x000124C8
		// (set) Token: 0x06000183 RID: 387 RVA: 0x000130E4 File Offset: 0x000124E4
		[global::System.ComponentModel.Browsable(false)]
		public override string QuoteSuffix
		{
			get
			{
				this.CheckDisposed();
				return base.QuoteSuffix;
			}
			set
			{
				this.CheckDisposed();
				base.QuoteSuffix = value;
			}
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00013100 File Offset: 0x00012500
		public override string QuoteIdentifier(string unquotedIdentifier)
		{
			this.CheckDisposed();
			if (string.IsNullOrEmpty(this.QuotePrefix) || string.IsNullOrEmpty(this.QuoteSuffix) || string.IsNullOrEmpty(unquotedIdentifier))
			{
				return unquotedIdentifier;
			}
			return this.QuotePrefix + unquotedIdentifier.Replace(this.QuoteSuffix, this.QuoteSuffix + this.QuoteSuffix) + this.QuoteSuffix;
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00013168 File Offset: 0x00012568
		public override string UnquoteIdentifier(string quotedIdentifier)
		{
			this.CheckDisposed();
			if (string.IsNullOrEmpty(this.QuotePrefix) || string.IsNullOrEmpty(this.QuoteSuffix) || string.IsNullOrEmpty(quotedIdentifier))
			{
				return quotedIdentifier;
			}
			if (!quotedIdentifier.StartsWith(this.QuotePrefix, global::System.StringComparison.OrdinalIgnoreCase) || !quotedIdentifier.EndsWith(this.QuoteSuffix, global::System.StringComparison.OrdinalIgnoreCase))
			{
				return quotedIdentifier;
			}
			return quotedIdentifier.Substring(this.QuotePrefix.Length, quotedIdentifier.Length - (this.QuotePrefix.Length + this.QuoteSuffix.Length)).Replace(this.QuoteSuffix + this.QuoteSuffix, this.QuoteSuffix);
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000186 RID: 390 RVA: 0x0001320C File Offset: 0x0001260C
		// (set) Token: 0x06000187 RID: 391 RVA: 0x00013228 File Offset: 0x00012628
		[global::System.ComponentModel.Browsable(false)]
		public override string SchemaSeparator
		{
			get
			{
				this.CheckDisposed();
				return base.SchemaSeparator;
			}
			set
			{
				this.CheckDisposed();
				base.SchemaSeparator = value;
			}
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00013244 File Offset: 0x00012644
		protected override global::System.Data.DataTable GetSchemaTable(global::System.Data.Common.DbCommand sourceCommand)
		{
			global::System.Data.DataTable result;
			using (global::System.Data.IDataReader dataReader = sourceCommand.ExecuteReader(global::System.Data.CommandBehavior.SchemaOnly | global::System.Data.CommandBehavior.KeyInfo))
			{
				global::System.Data.DataTable schemaTable = dataReader.GetSchemaTable();
				if (this.HasSchemaPrimaryKey(schemaTable))
				{
					this.ResetIsUniqueSchemaColumn(schemaTable);
				}
				result = schemaTable;
			}
			return result;
		}

		// Token: 0x06000189 RID: 393 RVA: 0x0001329C File Offset: 0x0001269C
		private bool HasSchemaPrimaryKey(global::System.Data.DataTable schema)
		{
			global::System.Data.DataColumn column = schema.Columns[global::System.Data.Common.SchemaTableColumn.IsKey];
			foreach (object obj in schema.Rows)
			{
				global::System.Data.DataRow dataRow = (global::System.Data.DataRow)obj;
				if ((bool)dataRow[column])
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00013324 File Offset: 0x00012724
		private void ResetIsUniqueSchemaColumn(global::System.Data.DataTable schema)
		{
			global::System.Data.DataColumn column = schema.Columns[global::System.Data.Common.SchemaTableColumn.IsUnique];
			global::System.Data.DataColumn column2 = schema.Columns[global::System.Data.Common.SchemaTableColumn.IsKey];
			foreach (object obj in schema.Rows)
			{
				global::System.Data.DataRow dataRow = (global::System.Data.DataRow)obj;
				if (!(bool)dataRow[column2])
				{
					dataRow[column] = false;
				}
			}
			schema.AcceptChanges();
		}

		// Token: 0x04000067 RID: 103
		private bool disposed;
	}
}
