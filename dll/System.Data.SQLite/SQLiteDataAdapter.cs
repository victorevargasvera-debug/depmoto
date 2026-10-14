using System;
using System.ComponentModel;
using System.Data.Common;

namespace System.Data.SQLite
{
	// Token: 0x02000033 RID: 51
	[global::System.ComponentModel.Designer("Microsoft.VSDesigner.Data.VS.SqlDataAdapterDesigner, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[global::System.ComponentModel.DefaultEvent("RowUpdated")]
	[global::System.ComponentModel.ToolboxItem("SQLite.Designer.SQLiteDataAdapterToolboxItem, SQLite.Designer, Version=1.0.89.0, Culture=neutral, PublicKeyToken=db937bc2d44ff139")]
	public sealed class SQLiteDataAdapter : global::System.Data.Common.DbDataAdapter
	{
		// Token: 0x0600029B RID: 667 RVA: 0x0001A5B0 File Offset: 0x000199B0
		public SQLiteDataAdapter()
		{
		}

		// Token: 0x0600029C RID: 668 RVA: 0x0001A5CC File Offset: 0x000199CC
		public SQLiteDataAdapter(global::System.Data.SQLite.SQLiteCommand cmd)
		{
			this.SelectCommand = cmd;
			this.disposeSelect = false;
		}

		// Token: 0x0600029D RID: 669 RVA: 0x0001A5F4 File Offset: 0x000199F4
		public SQLiteDataAdapter(string commandText, global::System.Data.SQLite.SQLiteConnection connection)
		{
			this.SelectCommand = new global::System.Data.SQLite.SQLiteCommand(commandText, connection);
		}

		// Token: 0x0600029E RID: 670 RVA: 0x0001A61C File Offset: 0x00019A1C
		public SQLiteDataAdapter(string commandText, string connectionString) : this(commandText, connectionString, false)
		{
		}

		// Token: 0x0600029F RID: 671 RVA: 0x0001A634 File Offset: 0x00019A34
		public SQLiteDataAdapter(string commandText, string connectionString, bool parseViaFramework)
		{
			global::System.Data.SQLite.SQLiteConnection connection = new global::System.Data.SQLite.SQLiteConnection(connectionString, parseViaFramework);
			this.SelectCommand = new global::System.Data.SQLite.SQLiteCommand(commandText, connection);
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x0001A664 File Offset: 0x00019A64
		private void CheckDisposed()
		{
			if (this.disposed)
			{
				throw new global::System.ObjectDisposedException(typeof(global::System.Data.SQLite.SQLiteDataAdapter).Name);
			}
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x0001A690 File Offset: 0x00019A90
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (!this.disposed && disposing)
				{
					if (this.disposeSelect && this.SelectCommand != null)
					{
						this.SelectCommand.Dispose();
						this.SelectCommand = null;
					}
					if (this.InsertCommand != null)
					{
						this.InsertCommand.Dispose();
						this.InsertCommand = null;
					}
					if (this.UpdateCommand != null)
					{
						this.UpdateCommand.Dispose();
						this.UpdateCommand = null;
					}
					if (this.DeleteCommand != null)
					{
						this.DeleteCommand.Dispose();
						this.DeleteCommand = null;
					}
				}
			}
			finally
			{
				base.Dispose(disposing);
				this.disposed = true;
			}
		}

		// Token: 0x1400000E RID: 14
		// (add) Token: 0x060002A2 RID: 674 RVA: 0x0001A748 File Offset: 0x00019B48
		// (remove) Token: 0x060002A3 RID: 675 RVA: 0x0001A7B4 File Offset: 0x00019BB4
		public event global::System.EventHandler<global::System.Data.Common.RowUpdatingEventArgs> RowUpdating
		{
			add
			{
				this.CheckDisposed();
				global::System.EventHandler<global::System.Data.Common.RowUpdatingEventArgs> eventHandler = (global::System.EventHandler<global::System.Data.Common.RowUpdatingEventArgs>)base.Events[global::System.Data.SQLite.SQLiteDataAdapter._updatingEventPH];
				if (eventHandler != null && value.Target is global::System.Data.Common.DbCommandBuilder)
				{
					global::System.EventHandler<global::System.Data.Common.RowUpdatingEventArgs> eventHandler2 = (global::System.EventHandler<global::System.Data.Common.RowUpdatingEventArgs>)global::System.Data.SQLite.SQLiteDataAdapter.FindBuilder(eventHandler);
					if (eventHandler2 != null)
					{
						base.Events.RemoveHandler(global::System.Data.SQLite.SQLiteDataAdapter._updatingEventPH, eventHandler2);
					}
				}
				base.Events.AddHandler(global::System.Data.SQLite.SQLiteDataAdapter._updatingEventPH, value);
			}
			remove
			{
				this.CheckDisposed();
				base.Events.RemoveHandler(global::System.Data.SQLite.SQLiteDataAdapter._updatingEventPH, value);
			}
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x0001A7D8 File Offset: 0x00019BD8
		internal static global::System.Delegate FindBuilder(global::System.MulticastDelegate mcd)
		{
			if (mcd != null)
			{
				global::System.Delegate[] invocationList = mcd.GetInvocationList();
				for (int i = 0; i < invocationList.Length; i++)
				{
					if (invocationList[i].Target is global::System.Data.Common.DbCommandBuilder)
					{
						return invocationList[i];
					}
				}
			}
			return null;
		}

		// Token: 0x1400000F RID: 15
		// (add) Token: 0x060002A5 RID: 677 RVA: 0x0001A814 File Offset: 0x00019C14
		// (remove) Token: 0x060002A6 RID: 678 RVA: 0x0001A838 File Offset: 0x00019C38
		public event global::System.EventHandler<global::System.Data.Common.RowUpdatedEventArgs> RowUpdated
		{
			add
			{
				this.CheckDisposed();
				base.Events.AddHandler(global::System.Data.SQLite.SQLiteDataAdapter._updatedEventPH, value);
			}
			remove
			{
				this.CheckDisposed();
				base.Events.RemoveHandler(global::System.Data.SQLite.SQLiteDataAdapter._updatedEventPH, value);
			}
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x0001A85C File Offset: 0x00019C5C
		protected override void OnRowUpdating(global::System.Data.Common.RowUpdatingEventArgs value)
		{
			global::System.EventHandler<global::System.Data.Common.RowUpdatingEventArgs> eventHandler = base.Events[global::System.Data.SQLite.SQLiteDataAdapter._updatingEventPH] as global::System.EventHandler<global::System.Data.Common.RowUpdatingEventArgs>;
			if (eventHandler != null)
			{
				eventHandler(this, value);
			}
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x0001A88C File Offset: 0x00019C8C
		protected override void OnRowUpdated(global::System.Data.Common.RowUpdatedEventArgs value)
		{
			global::System.EventHandler<global::System.Data.Common.RowUpdatedEventArgs> eventHandler = base.Events[global::System.Data.SQLite.SQLiteDataAdapter._updatedEventPH] as global::System.EventHandler<global::System.Data.Common.RowUpdatedEventArgs>;
			if (eventHandler != null)
			{
				eventHandler(this, value);
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060002A9 RID: 681 RVA: 0x0001A8BC File Offset: 0x00019CBC
		// (set) Token: 0x060002AA RID: 682 RVA: 0x0001A8DC File Offset: 0x00019CDC
		[global::System.ComponentModel.DefaultValue(null)]
		[global::System.ComponentModel.Editor("Microsoft.VSDesigner.Data.Design.DBCommandEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
		public new global::System.Data.SQLite.SQLiteCommand SelectCommand
		{
			get
			{
				this.CheckDisposed();
				return (global::System.Data.SQLite.SQLiteCommand)base.SelectCommand;
			}
			set
			{
				this.CheckDisposed();
				base.SelectCommand = value;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060002AB RID: 683 RVA: 0x0001A8F8 File Offset: 0x00019CF8
		// (set) Token: 0x060002AC RID: 684 RVA: 0x0001A918 File Offset: 0x00019D18
		[global::System.ComponentModel.Editor("Microsoft.VSDesigner.Data.Design.DBCommandEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
		[global::System.ComponentModel.DefaultValue(null)]
		public new global::System.Data.SQLite.SQLiteCommand InsertCommand
		{
			get
			{
				this.CheckDisposed();
				return (global::System.Data.SQLite.SQLiteCommand)base.InsertCommand;
			}
			set
			{
				this.CheckDisposed();
				base.InsertCommand = value;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060002AD RID: 685 RVA: 0x0001A934 File Offset: 0x00019D34
		// (set) Token: 0x060002AE RID: 686 RVA: 0x0001A954 File Offset: 0x00019D54
		[global::System.ComponentModel.Editor("Microsoft.VSDesigner.Data.Design.DBCommandEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
		[global::System.ComponentModel.DefaultValue(null)]
		public new global::System.Data.SQLite.SQLiteCommand UpdateCommand
		{
			get
			{
				this.CheckDisposed();
				return (global::System.Data.SQLite.SQLiteCommand)base.UpdateCommand;
			}
			set
			{
				this.CheckDisposed();
				base.UpdateCommand = value;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060002AF RID: 687 RVA: 0x0001A970 File Offset: 0x00019D70
		// (set) Token: 0x060002B0 RID: 688 RVA: 0x0001A990 File Offset: 0x00019D90
		[global::System.ComponentModel.DefaultValue(null)]
		[global::System.ComponentModel.Editor("Microsoft.VSDesigner.Data.Design.DBCommandEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
		public new global::System.Data.SQLite.SQLiteCommand DeleteCommand
		{
			get
			{
				this.CheckDisposed();
				return (global::System.Data.SQLite.SQLiteCommand)base.DeleteCommand;
			}
			set
			{
				this.CheckDisposed();
				base.DeleteCommand = value;
			}
		}

		// Token: 0x0400012E RID: 302
		private bool disposeSelect = true;

		// Token: 0x0400012F RID: 303
		private static object _updatingEventPH = new object();

		// Token: 0x04000130 RID: 304
		private static object _updatedEventPH = new object();

		// Token: 0x04000131 RID: 305
		private bool disposed;
	}
}
