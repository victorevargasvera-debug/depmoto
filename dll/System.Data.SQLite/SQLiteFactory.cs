using System;
using System.Data.Common;
using System.Globalization;
using System.Reflection;
using System.Security.Permissions;

namespace System.Data.SQLite
{
	// Token: 0x0200003A RID: 58
	public sealed class SQLiteFactory : global::System.Data.Common.DbProviderFactory, global::System.IDisposable, global::System.IServiceProvider
	{
		// Token: 0x060002F3 RID: 755 RVA: 0x0001C918 File Offset: 0x0001BD18
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x0001C934 File Offset: 0x0001BD34
		private void CheckDisposed()
		{
			if (this.disposed)
			{
				throw new global::System.ObjectDisposedException(typeof(global::System.Data.SQLite.SQLiteFactory).Name);
			}
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x0001C960 File Offset: 0x0001BD60
		private void Dispose(bool disposing)
		{
			if (!this.disposed)
			{
				this.disposed = true;
			}
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x0001C97C File Offset: 0x0001BD7C
		~SQLiteFactory()
		{
			this.Dispose(false);
		}

		// Token: 0x14000010 RID: 16
		// (add) Token: 0x060002F7 RID: 759 RVA: 0x0001C9B8 File Offset: 0x0001BDB8
		// (remove) Token: 0x060002F8 RID: 760 RVA: 0x0001C9D4 File Offset: 0x0001BDD4
		public event global::System.Data.SQLite.SQLiteLogEventHandler Log
		{
			add
			{
				this.CheckDisposed();
				global::System.Data.SQLite.SQLiteLog.Log += value;
			}
			remove
			{
				this.CheckDisposed();
				global::System.Data.SQLite.SQLiteLog.Log -= value;
			}
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x0001C9F0 File Offset: 0x0001BDF0
		public override global::System.Data.Common.DbCommand CreateCommand()
		{
			this.CheckDisposed();
			return new global::System.Data.SQLite.SQLiteCommand();
		}

		// Token: 0x060002FA RID: 762 RVA: 0x0001CA08 File Offset: 0x0001BE08
		public override global::System.Data.Common.DbCommandBuilder CreateCommandBuilder()
		{
			this.CheckDisposed();
			return new global::System.Data.SQLite.SQLiteCommandBuilder();
		}

		// Token: 0x060002FB RID: 763 RVA: 0x0001CA20 File Offset: 0x0001BE20
		public override global::System.Data.Common.DbConnection CreateConnection()
		{
			this.CheckDisposed();
			return new global::System.Data.SQLite.SQLiteConnection();
		}

		// Token: 0x060002FC RID: 764 RVA: 0x0001CA38 File Offset: 0x0001BE38
		public override global::System.Data.Common.DbConnectionStringBuilder CreateConnectionStringBuilder()
		{
			this.CheckDisposed();
			return new global::System.Data.SQLite.SQLiteConnectionStringBuilder();
		}

		// Token: 0x060002FD RID: 765 RVA: 0x0001CA50 File Offset: 0x0001BE50
		public override global::System.Data.Common.DbDataAdapter CreateDataAdapter()
		{
			this.CheckDisposed();
			return new global::System.Data.SQLite.SQLiteDataAdapter();
		}

		// Token: 0x060002FE RID: 766 RVA: 0x0001CA68 File Offset: 0x0001BE68
		public override global::System.Data.Common.DbParameter CreateParameter()
		{
			this.CheckDisposed();
			return new global::System.Data.SQLite.SQLiteParameter();
		}

		// Token: 0x060002FF RID: 767 RVA: 0x0001CA80 File Offset: 0x0001BE80
		static SQLiteFactory()
		{
			global::System.Data.SQLite.SQLiteLog.Initialize();
			string text = "4.0.0.0";
			global::System.Data.SQLite.SQLiteFactory._dbProviderServicesType = global::System.Type.GetType(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "System.Data.Common.DbProviderServices, System.Data.Entity, Version={0}, Culture=neutral, PublicKeyToken=b77a5c561934e089", new object[]
			{
				text
			}), false);
		}

		// Token: 0x06000300 RID: 768 RVA: 0x0001CAC8 File Offset: 0x0001BEC8
		object global::System.IServiceProvider.GetService(global::System.Type serviceType)
		{
			if (serviceType == typeof(global::System.Data.SQLite.ISQLiteSchemaExtensions) || (global::System.Data.SQLite.SQLiteFactory._dbProviderServicesType != null && serviceType == global::System.Data.SQLite.SQLiteFactory._dbProviderServicesType))
			{
				return this.GetSQLiteProviderServicesInstance();
			}
			return null;
		}

		// Token: 0x06000301 RID: 769 RVA: 0x0001CB0C File Offset: 0x0001BF0C
		[global::System.Security.Permissions.ReflectionPermission(global::System.Security.Permissions.SecurityAction.Assert, MemberAccess = true)]
		private object GetSQLiteProviderServicesInstance()
		{
			if (global::System.Data.SQLite.SQLiteFactory._sqliteServices == null)
			{
				global::System.Version version = base.GetType().Assembly.GetName().Version;
				global::System.Type type = global::System.Type.GetType(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "System.Data.SQLite.SQLiteProviderServices, System.Data.SQLite.Linq, Version={0}, Culture=neutral, PublicKeyToken=db937bc2d44ff139", new object[]
				{
					version
				}), false);
				if (type != null)
				{
					global::System.Reflection.FieldInfo field = type.GetField("Instance", global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Static | global::System.Reflection.BindingFlags.NonPublic);
					global::System.Data.SQLite.SQLiteFactory._sqliteServices = field.GetValue(null);
				}
			}
			return global::System.Data.SQLite.SQLiteFactory._sqliteServices;
		}

		// Token: 0x04000167 RID: 359
		private bool disposed;

		// Token: 0x04000168 RID: 360
		public static readonly global::System.Data.SQLite.SQLiteFactory Instance = new global::System.Data.SQLite.SQLiteFactory();

		// Token: 0x04000169 RID: 361
		private static global::System.Type _dbProviderServicesType;

		// Token: 0x0400016A RID: 362
		private static object _sqliteServices;
	}
}
