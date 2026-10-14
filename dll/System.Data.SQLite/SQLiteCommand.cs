using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Diagnostics;

namespace System.Data.SQLite
{
	// Token: 0x0200000E RID: 14
	[global::System.ComponentModel.ToolboxItem(true)]
	[global::System.ComponentModel.Designer("SQLite.Designer.SQLiteCommandDesigner, SQLite.Designer, Version=1.0.89.0, Culture=neutral, PublicKeyToken=db937bc2d44ff139")]
	public sealed class SQLiteCommand : global::System.Data.Common.DbCommand, global::System.ICloneable
	{
		// Token: 0x06000137 RID: 311 RVA: 0x000121C4 File Offset: 0x000115C4
		public SQLiteCommand() : this(null, null)
		{
		}

		// Token: 0x06000138 RID: 312 RVA: 0x000121DC File Offset: 0x000115DC
		public SQLiteCommand(string commandText) : this(commandText, null, null)
		{
		}

		// Token: 0x06000139 RID: 313 RVA: 0x000121F4 File Offset: 0x000115F4
		public SQLiteCommand(string commandText, global::System.Data.SQLite.SQLiteConnection connection) : this(commandText, connection, null)
		{
		}

		// Token: 0x0600013A RID: 314 RVA: 0x0001220C File Offset: 0x0001160C
		public SQLiteCommand(global::System.Data.SQLite.SQLiteConnection connection) : this(null, connection, null)
		{
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00012224 File Offset: 0x00011624
		private SQLiteCommand(global::System.Data.SQLite.SQLiteCommand source) : this(source.CommandText, source.Connection, source.Transaction)
		{
			this.CommandTimeout = source.CommandTimeout;
			this.DesignTimeVisible = source.DesignTimeVisible;
			this.UpdatedRowSource = source.UpdatedRowSource;
			foreach (object obj in source._parameterCollection)
			{
				global::System.Data.SQLite.SQLiteParameter sqliteParameter = (global::System.Data.SQLite.SQLiteParameter)obj;
				this.Parameters.Add(sqliteParameter.Clone());
			}
		}

		// Token: 0x0600013C RID: 316 RVA: 0x000122D0 File Offset: 0x000116D0
		public SQLiteCommand(string commandText, global::System.Data.SQLite.SQLiteConnection connection, global::System.Data.SQLite.SQLiteTransaction transaction)
		{
			this._commandTimeout = 30;
			this._parameterCollection = new global::System.Data.SQLite.SQLiteParameterCollection(this);
			this._designTimeVisible = true;
			this._updateRowSource = global::System.Data.UpdateRowSource.None;
			if (commandText != null)
			{
				this.CommandText = commandText;
			}
			if (connection != null)
			{
				this.DbConnection = connection;
				this._commandTimeout = connection.DefaultTimeout;
			}
			if (transaction != null)
			{
				this.Transaction = transaction;
			}
			global::System.Data.SQLite.SQLiteConnection.OnChanged(connection, new global::System.Data.SQLite.ConnectionEventArgs(global::System.Data.SQLite.SQLiteConnectionEventType.NewCommand, null, transaction, this, null, null, null, null));
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00012344 File Offset: 0x00011744
		[global::System.Diagnostics.Conditional("CHECK_STATE")]
		internal static void Check(global::System.Data.SQLite.SQLiteCommand command)
		{
			if (command == null)
			{
				throw new global::System.ArgumentNullException("command");
			}
			command.CheckDisposed();
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00012368 File Offset: 0x00011768
		private void CheckDisposed()
		{
			if (this.disposed)
			{
				throw new global::System.ObjectDisposedException(typeof(global::System.Data.SQLite.SQLiteCommand).Name);
			}
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00012394 File Offset: 0x00011794
		protected override void Dispose(bool disposing)
		{
			bool flag = false;
			try
			{
				if (!this.disposed && disposing)
				{
					global::System.Data.SQLite.SQLiteDataReader sqliteDataReader = null;
					if (this._activeReader != null)
					{
						try
						{
							sqliteDataReader = (this._activeReader.Target as global::System.Data.SQLite.SQLiteDataReader);
						}
						catch (global::System.InvalidOperationException)
						{
						}
					}
					if (sqliteDataReader != null)
					{
						sqliteDataReader._disposeCommand = true;
						this._activeReader = null;
						flag = true;
					}
					else
					{
						this.Connection = null;
						this._parameterCollection.Clear();
						this._commandText = null;
					}
				}
			}
			finally
			{
				if (!flag)
				{
					base.Dispose(disposing);
					this.disposed = true;
				}
			}
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00012444 File Offset: 0x00011844
		internal static global::System.Data.SQLite.SQLiteConnectionFlags GetFlags(global::System.Data.SQLite.SQLiteCommand command)
		{
			try
			{
				if (command != null)
				{
					global::System.Data.SQLite.SQLiteConnection cnn = command._cnn;
					if (cnn != null)
					{
						return cnn.Flags;
					}
				}
			}
			catch (global::System.ObjectDisposedException)
			{
			}
			return global::System.Data.SQLite.SQLiteConnectionFlags.Default;
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00012490 File Offset: 0x00011890
		private void DisposeStatements()
		{
			if (this._statementList == null)
			{
				return;
			}
			int count = this._statementList.Count;
			for (int i = 0; i < count; i++)
			{
				global::System.Data.SQLite.SQLiteStatement sqliteStatement = this._statementList[i];
				if (sqliteStatement != null)
				{
					sqliteStatement.Dispose();
				}
			}
			this._statementList = null;
		}

		// Token: 0x06000142 RID: 322 RVA: 0x000124DC File Offset: 0x000118DC
		internal void ClearCommands()
		{
			if (this._activeReader != null)
			{
				global::System.Data.SQLite.SQLiteDataReader sqliteDataReader = null;
				try
				{
					sqliteDataReader = (this._activeReader.Target as global::System.Data.SQLite.SQLiteDataReader);
				}
				catch (global::System.InvalidOperationException)
				{
				}
				if (sqliteDataReader != null)
				{
					sqliteDataReader.Close();
				}
				this._activeReader = null;
			}
			this.DisposeStatements();
			this._parameterCollection.Unbind();
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00012548 File Offset: 0x00011948
		internal global::System.Data.SQLite.SQLiteStatement BuildNextCommand()
		{
			global::System.Data.SQLite.SQLiteStatement sqliteStatement = null;
			global::System.Data.SQLite.SQLiteStatement result;
			try
			{
				if (this._cnn != null && this._cnn._sql != null)
				{
					if (this._statementList == null)
					{
						this._remainingText = this._commandText;
					}
					sqliteStatement = this._cnn._sql.Prepare(this._cnn, this._remainingText, (this._statementList == null) ? null : this._statementList[this._statementList.Count - 1], (uint)(this._commandTimeout * 1000), out this._remainingText);
					if (sqliteStatement != null)
					{
						sqliteStatement._command = this;
						if (this._statementList == null)
						{
							this._statementList = new global::System.Collections.Generic.List<global::System.Data.SQLite.SQLiteStatement>();
						}
						this._statementList.Add(sqliteStatement);
						this._parameterCollection.MapParameters(sqliteStatement);
						sqliteStatement.BindParameters();
					}
				}
				result = sqliteStatement;
			}
			catch (global::System.Exception)
			{
				if (sqliteStatement != null)
				{
					if (this._statementList != null && this._statementList.Contains(sqliteStatement))
					{
						this._statementList.Remove(sqliteStatement);
					}
					sqliteStatement.Dispose();
				}
				this._remainingText = null;
				throw;
			}
			return result;
		}

		// Token: 0x06000144 RID: 324 RVA: 0x0001266C File Offset: 0x00011A6C
		internal global::System.Data.SQLite.SQLiteStatement GetStatement(int index)
		{
			if (this._statementList == null)
			{
				return this.BuildNextCommand();
			}
			if (index != this._statementList.Count)
			{
				global::System.Data.SQLite.SQLiteStatement sqliteStatement = this._statementList[index];
				sqliteStatement.BindParameters();
				return sqliteStatement;
			}
			if (!string.IsNullOrEmpty(this._remainingText))
			{
				return this.BuildNextCommand();
			}
			return null;
		}

		// Token: 0x06000145 RID: 325 RVA: 0x000126C0 File Offset: 0x00011AC0
		public override void Cancel()
		{
			this.CheckDisposed();
			if (this._activeReader != null)
			{
				global::System.Data.SQLite.SQLiteDataReader sqliteDataReader = this._activeReader.Target as global::System.Data.SQLite.SQLiteDataReader;
				if (sqliteDataReader != null)
				{
					sqliteDataReader.Cancel();
				}
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000146 RID: 326 RVA: 0x000126F8 File Offset: 0x00011AF8
		// (set) Token: 0x06000147 RID: 327 RVA: 0x00012714 File Offset: 0x00011B14
		[global::System.ComponentModel.Editor("Microsoft.VSDesigner.Data.SQL.Design.SqlCommandTextEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
		[global::System.ComponentModel.DefaultValue("")]
		[global::System.ComponentModel.RefreshProperties(global::System.ComponentModel.RefreshProperties.All)]
		public override string CommandText
		{
			get
			{
				this.CheckDisposed();
				return this._commandText;
			}
			set
			{
				this.CheckDisposed();
				if (this._commandText == value)
				{
					return;
				}
				if (this._activeReader != null && this._activeReader.IsAlive)
				{
					throw new global::System.InvalidOperationException("Cannot set CommandText while a DataReader is active");
				}
				this.ClearCommands();
				this._commandText = value;
				global::System.Data.SQLite.SQLiteConnection cnn = this._cnn;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000148 RID: 328 RVA: 0x0001276C File Offset: 0x00011B6C
		// (set) Token: 0x06000149 RID: 329 RVA: 0x00012788 File Offset: 0x00011B88
		[global::System.ComponentModel.DefaultValue(30)]
		public override int CommandTimeout
		{
			get
			{
				this.CheckDisposed();
				return this._commandTimeout;
			}
			set
			{
				this.CheckDisposed();
				this._commandTimeout = value;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600014A RID: 330 RVA: 0x000127A4 File Offset: 0x00011BA4
		// (set) Token: 0x0600014B RID: 331 RVA: 0x000127B8 File Offset: 0x00011BB8
		[global::System.ComponentModel.RefreshProperties(global::System.ComponentModel.RefreshProperties.All)]
		[global::System.ComponentModel.DefaultValue(global::System.Data.CommandType.Text)]
		public override global::System.Data.CommandType CommandType
		{
			get
			{
				this.CheckDisposed();
				return global::System.Data.CommandType.Text;
			}
			set
			{
				this.CheckDisposed();
				if (value != global::System.Data.CommandType.Text)
				{
					throw new global::System.NotSupportedException();
				}
			}
		}

		// Token: 0x0600014C RID: 332 RVA: 0x000127D8 File Offset: 0x00011BD8
		protected override global::System.Data.Common.DbParameter CreateDbParameter()
		{
			return this.CreateParameter();
		}

		// Token: 0x0600014D RID: 333 RVA: 0x000127EC File Offset: 0x00011BEC
		public new global::System.Data.SQLite.SQLiteParameter CreateParameter()
		{
			this.CheckDisposed();
			return new global::System.Data.SQLite.SQLiteParameter();
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600014E RID: 334 RVA: 0x00012804 File Offset: 0x00011C04
		// (set) Token: 0x0600014F RID: 335 RVA: 0x00012820 File Offset: 0x00011C20
		[global::System.ComponentModel.Editor("Microsoft.VSDesigner.Data.Design.DbConnectionEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
		[global::System.ComponentModel.DefaultValue(null)]
		public new global::System.Data.SQLite.SQLiteConnection Connection
		{
			get
			{
				this.CheckDisposed();
				return this._cnn;
			}
			set
			{
				this.CheckDisposed();
				if (this._activeReader != null && this._activeReader.IsAlive)
				{
					throw new global::System.InvalidOperationException("Cannot set Connection while a DataReader is active");
				}
				if (this._cnn != null)
				{
					this.ClearCommands();
				}
				this._cnn = value;
				if (this._cnn != null)
				{
					this._version = this._cnn._version;
				}
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000150 RID: 336 RVA: 0x00012884 File Offset: 0x00011C84
		// (set) Token: 0x06000151 RID: 337 RVA: 0x00012898 File Offset: 0x00011C98
		protected override global::System.Data.Common.DbConnection DbConnection
		{
			get
			{
				return this.Connection;
			}
			set
			{
				this.Connection = (global::System.Data.SQLite.SQLiteConnection)value;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000152 RID: 338 RVA: 0x000128B4 File Offset: 0x00011CB4
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
		public new global::System.Data.SQLite.SQLiteParameterCollection Parameters
		{
			get
			{
				this.CheckDisposed();
				return this._parameterCollection;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000153 RID: 339 RVA: 0x000128D0 File Offset: 0x00011CD0
		protected override global::System.Data.Common.DbParameterCollection DbParameterCollection
		{
			get
			{
				return this.Parameters;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000154 RID: 340 RVA: 0x000128E4 File Offset: 0x00011CE4
		// (set) Token: 0x06000155 RID: 341 RVA: 0x00012900 File Offset: 0x00011D00
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public new global::System.Data.SQLite.SQLiteTransaction Transaction
		{
			get
			{
				this.CheckDisposed();
				return this._transaction;
			}
			set
			{
				this.CheckDisposed();
				if (this._cnn == null)
				{
					if (value != null)
					{
						this.Connection = value.Connection;
					}
					this._transaction = value;
					return;
				}
				if (this._activeReader != null && this._activeReader.IsAlive)
				{
					throw new global::System.InvalidOperationException("Cannot set Transaction while a DataReader is active");
				}
				if (value != null && value._cnn != this._cnn)
				{
					throw new global::System.ArgumentException("Transaction is not associated with the command's connection");
				}
				this._transaction = value;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000156 RID: 342 RVA: 0x00012978 File Offset: 0x00011D78
		// (set) Token: 0x06000157 RID: 343 RVA: 0x0001298C File Offset: 0x00011D8C
		protected override global::System.Data.Common.DbTransaction DbTransaction
		{
			get
			{
				return this.Transaction;
			}
			set
			{
				this.Transaction = (global::System.Data.SQLite.SQLiteTransaction)value;
			}
		}

		// Token: 0x06000158 RID: 344 RVA: 0x000129A8 File Offset: 0x00011DA8
		private void InitializeForReader()
		{
			if (this._activeReader != null && this._activeReader.IsAlive)
			{
				throw new global::System.InvalidOperationException("DataReader already active on this command");
			}
			if (this._cnn == null)
			{
				throw new global::System.InvalidOperationException("No connection associated with this command");
			}
			if (this._cnn.State != global::System.Data.ConnectionState.Open)
			{
				throw new global::System.InvalidOperationException("Database is not open");
			}
			if (this._cnn._version != this._version)
			{
				this._version = this._cnn._version;
				this.ClearCommands();
			}
			this._parameterCollection.MapParameters(null);
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00012A38 File Offset: 0x00011E38
		protected override global::System.Data.Common.DbDataReader ExecuteDbDataReader(global::System.Data.CommandBehavior behavior)
		{
			return this.ExecuteReader(behavior);
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00012A4C File Offset: 0x00011E4C
		public static object Execute(string commandText, global::System.Data.SQLite.SQLiteExecuteType executeType, string connectionString, params object[] args)
		{
			return global::System.Data.SQLite.SQLiteCommand.Execute(commandText, executeType, global::System.Data.CommandBehavior.Default, connectionString, args);
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00012A64 File Offset: 0x00011E64
		public static object Execute(string commandText, global::System.Data.SQLite.SQLiteExecuteType executeType, global::System.Data.CommandBehavior commandBehavior, string connectionString, params object[] args)
		{
			if (connectionString == null)
			{
				connectionString = global::System.Data.SQLite.SQLiteCommand.DefaultConnectionString;
			}
			using (global::System.Data.SQLite.SQLiteConnection sqliteConnection = new global::System.Data.SQLite.SQLiteConnection(connectionString))
			{
				sqliteConnection.Open();
				using (global::System.Data.SQLite.SQLiteCommand sqliteCommand = sqliteConnection.CreateCommand())
				{
					sqliteCommand.CommandText = commandText;
					if (args != null)
					{
						foreach (object obj in args)
						{
							if (obj is global::System.Data.SQLite.SQLiteParameter)
							{
								sqliteCommand.Parameters.Add((global::System.Data.SQLite.SQLiteParameter)obj);
							}
							else
							{
								sqliteCommand.Parameters.Add(new global::System.Data.SQLite.SQLiteParameter(global::System.Data.DbType.Object, obj));
							}
						}
					}
					switch (executeType)
					{
					case global::System.Data.SQLite.SQLiteExecuteType.NonQuery:
						return sqliteCommand.ExecuteNonQuery(commandBehavior);
					case global::System.Data.SQLite.SQLiteExecuteType.Scalar:
						return sqliteCommand.ExecuteScalar(commandBehavior);
					case global::System.Data.SQLite.SQLiteExecuteType.Reader:
						return sqliteCommand.ExecuteReader(commandBehavior);
					}
				}
			}
			return null;
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00012B74 File Offset: 0x00011F74
		public new global::System.Data.SQLite.SQLiteDataReader ExecuteReader(global::System.Data.CommandBehavior behavior)
		{
			this.CheckDisposed();
			this.InitializeForReader();
			global::System.Data.SQLite.SQLiteDataReader sqliteDataReader = new global::System.Data.SQLite.SQLiteDataReader(this, behavior);
			this._activeReader = new global::System.WeakReference(sqliteDataReader, false);
			return sqliteDataReader;
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00012BA4 File Offset: 0x00011FA4
		public new global::System.Data.SQLite.SQLiteDataReader ExecuteReader()
		{
			this.CheckDisposed();
			return this.ExecuteReader(global::System.Data.CommandBehavior.Default);
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00012BC0 File Offset: 0x00011FC0
		internal void ClearDataReader()
		{
			this._activeReader = null;
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00012BD4 File Offset: 0x00011FD4
		public override int ExecuteNonQuery()
		{
			this.CheckDisposed();
			return this.ExecuteNonQuery(global::System.Data.CommandBehavior.Default);
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00012BF0 File Offset: 0x00011FF0
		public int ExecuteNonQuery(global::System.Data.CommandBehavior behavior)
		{
			this.CheckDisposed();
			int recordsAffected;
			using (global::System.Data.SQLite.SQLiteDataReader sqliteDataReader = this.ExecuteReader(behavior | global::System.Data.CommandBehavior.SingleRow | global::System.Data.CommandBehavior.SingleResult))
			{
				while (sqliteDataReader.NextResult())
				{
				}
				recordsAffected = sqliteDataReader.RecordsAffected;
			}
			return recordsAffected;
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00012C48 File Offset: 0x00012048
		public override object ExecuteScalar()
		{
			this.CheckDisposed();
			return this.ExecuteScalar(global::System.Data.CommandBehavior.Default);
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00012C64 File Offset: 0x00012064
		public object ExecuteScalar(global::System.Data.CommandBehavior behavior)
		{
			this.CheckDisposed();
			using (global::System.Data.SQLite.SQLiteDataReader sqliteDataReader = this.ExecuteReader(behavior | global::System.Data.CommandBehavior.SingleRow | global::System.Data.CommandBehavior.SingleResult))
			{
				if (sqliteDataReader.Read())
				{
					return sqliteDataReader[0];
				}
			}
			return null;
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00012CC0 File Offset: 0x000120C0
		public override void Prepare()
		{
			this.CheckDisposed();
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000164 RID: 356 RVA: 0x00012CD4 File Offset: 0x000120D4
		// (set) Token: 0x06000165 RID: 357 RVA: 0x00012CF0 File Offset: 0x000120F0
		[global::System.ComponentModel.DefaultValue(global::System.Data.UpdateRowSource.None)]
		public override global::System.Data.UpdateRowSource UpdatedRowSource
		{
			get
			{
				this.CheckDisposed();
				return this._updateRowSource;
			}
			set
			{
				this.CheckDisposed();
				this._updateRowSource = value;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000166 RID: 358 RVA: 0x00012D0C File Offset: 0x0001210C
		// (set) Token: 0x06000167 RID: 359 RVA: 0x00012D28 File Offset: 0x00012128
		[global::System.ComponentModel.DesignOnly(true)]
		[global::System.ComponentModel.DefaultValue(true)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool DesignTimeVisible
		{
			get
			{
				this.CheckDisposed();
				return this._designTimeVisible;
			}
			set
			{
				this.CheckDisposed();
				this._designTimeVisible = value;
				global::System.ComponentModel.TypeDescriptor.Refresh(this);
			}
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00012D48 File Offset: 0x00012148
		public object Clone()
		{
			this.CheckDisposed();
			return new global::System.Data.SQLite.SQLiteCommand(this);
		}

		// Token: 0x0400005A RID: 90
		private static readonly string DefaultConnectionString = "Data Source=:memory:;";

		// Token: 0x0400005B RID: 91
		private string _commandText;

		// Token: 0x0400005C RID: 92
		private global::System.Data.SQLite.SQLiteConnection _cnn;

		// Token: 0x0400005D RID: 93
		private long _version;

		// Token: 0x0400005E RID: 94
		private global::System.WeakReference _activeReader;

		// Token: 0x0400005F RID: 95
		internal int _commandTimeout;

		// Token: 0x04000060 RID: 96
		private bool _designTimeVisible;

		// Token: 0x04000061 RID: 97
		private global::System.Data.UpdateRowSource _updateRowSource;

		// Token: 0x04000062 RID: 98
		private global::System.Data.SQLite.SQLiteParameterCollection _parameterCollection;

		// Token: 0x04000063 RID: 99
		internal global::System.Collections.Generic.List<global::System.Data.SQLite.SQLiteStatement> _statementList;

		// Token: 0x04000064 RID: 100
		internal string _remainingText;

		// Token: 0x04000065 RID: 101
		private global::System.Data.SQLite.SQLiteTransaction _transaction;

		// Token: 0x04000066 RID: 102
		private bool disposed;
	}
}
