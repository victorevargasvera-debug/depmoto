using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Globalization;

namespace System.Data.SQLite
{
	// Token: 0x0200004E RID: 78
	[global::System.ComponentModel.ListBindable(false)]
	[global::System.ComponentModel.Editor("Microsoft.VSDesigner.Data.Design.DBParametersEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	public sealed class SQLiteParameterCollection : global::System.Data.Common.DbParameterCollection
	{
		// Token: 0x06000399 RID: 921 RVA: 0x0001FA7C File Offset: 0x0001EE7C
		internal SQLiteParameterCollection(global::System.Data.SQLite.SQLiteCommand cmd)
		{
			this._command = cmd;
			this._parameterList = new global::System.Collections.Generic.List<global::System.Data.SQLite.SQLiteParameter>();
			this._unboundFlag = true;
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x0600039A RID: 922 RVA: 0x0001FAA8 File Offset: 0x0001EEA8
		public override bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x0600039B RID: 923 RVA: 0x0001FAB8 File Offset: 0x0001EEB8
		public override bool IsFixedSize
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x0600039C RID: 924 RVA: 0x0001FAC8 File Offset: 0x0001EEC8
		public override bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x0600039D RID: 925 RVA: 0x0001FAD8 File Offset: 0x0001EED8
		public override object SyncRoot
		{
			get
			{
				return null;
			}
		}

		// Token: 0x0600039E RID: 926 RVA: 0x0001FAE8 File Offset: 0x0001EEE8
		public override global::System.Collections.IEnumerator GetEnumerator()
		{
			return this._parameterList.GetEnumerator();
		}

		// Token: 0x0600039F RID: 927 RVA: 0x0001FB08 File Offset: 0x0001EF08
		public global::System.Data.SQLite.SQLiteParameter Add(string parameterName, global::System.Data.DbType parameterType, int parameterSize, string sourceColumn)
		{
			global::System.Data.SQLite.SQLiteParameter sqliteParameter = new global::System.Data.SQLite.SQLiteParameter(parameterName, parameterType, parameterSize, sourceColumn);
			this.Add(sqliteParameter);
			return sqliteParameter;
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x0001FB2C File Offset: 0x0001EF2C
		public global::System.Data.SQLite.SQLiteParameter Add(string parameterName, global::System.Data.DbType parameterType, int parameterSize)
		{
			global::System.Data.SQLite.SQLiteParameter sqliteParameter = new global::System.Data.SQLite.SQLiteParameter(parameterName, parameterType, parameterSize);
			this.Add(sqliteParameter);
			return sqliteParameter;
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x0001FB4C File Offset: 0x0001EF4C
		public global::System.Data.SQLite.SQLiteParameter Add(string parameterName, global::System.Data.DbType parameterType)
		{
			global::System.Data.SQLite.SQLiteParameter sqliteParameter = new global::System.Data.SQLite.SQLiteParameter(parameterName, parameterType);
			this.Add(sqliteParameter);
			return sqliteParameter;
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x0001FB6C File Offset: 0x0001EF6C
		public int Add(global::System.Data.SQLite.SQLiteParameter parameter)
		{
			int num = -1;
			if (!string.IsNullOrEmpty(parameter.ParameterName))
			{
				num = this.IndexOf(parameter.ParameterName);
			}
			if (num == -1)
			{
				num = this._parameterList.Count;
				this._parameterList.Add(parameter);
			}
			this.SetParameter(num, parameter);
			return num;
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x0001FBBC File Offset: 0x0001EFBC
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override int Add(object value)
		{
			return this.Add((global::System.Data.SQLite.SQLiteParameter)value);
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x0001FBD8 File Offset: 0x0001EFD8
		public global::System.Data.SQLite.SQLiteParameter AddWithValue(string parameterName, object value)
		{
			global::System.Data.SQLite.SQLiteParameter sqliteParameter = new global::System.Data.SQLite.SQLiteParameter(parameterName, value);
			this.Add(sqliteParameter);
			return sqliteParameter;
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x0001FBF8 File Offset: 0x0001EFF8
		public void AddRange(global::System.Data.SQLite.SQLiteParameter[] values)
		{
			int num = values.Length;
			for (int i = 0; i < num; i++)
			{
				this.Add(values[i]);
			}
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x0001FC20 File Offset: 0x0001F020
		public override void AddRange(global::System.Array values)
		{
			int length = values.Length;
			for (int i = 0; i < length; i++)
			{
				this.Add((global::System.Data.SQLite.SQLiteParameter)values.GetValue(i));
			}
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x0001FC54 File Offset: 0x0001F054
		public override void Clear()
		{
			this._unboundFlag = true;
			this._parameterList.Clear();
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x0001FC74 File Offset: 0x0001F074
		public override bool Contains(string parameterName)
		{
			return this.IndexOf(parameterName) != -1;
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x0001FC90 File Offset: 0x0001F090
		public override bool Contains(object value)
		{
			return this._parameterList.Contains((global::System.Data.SQLite.SQLiteParameter)value);
		}

		// Token: 0x060003AA RID: 938 RVA: 0x0001FCB0 File Offset: 0x0001F0B0
		public override void CopyTo(global::System.Array array, int index)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060003AB RID: 939 RVA: 0x0001FCC4 File Offset: 0x0001F0C4
		public override int Count
		{
			get
			{
				return this._parameterList.Count;
			}
		}

		// Token: 0x17000082 RID: 130
		public global::System.Data.SQLite.SQLiteParameter this[string parameterName]
		{
			get
			{
				return (global::System.Data.SQLite.SQLiteParameter)this.GetParameter(parameterName);
			}
			set
			{
				this.SetParameter(parameterName, value);
			}
		}

		// Token: 0x17000083 RID: 131
		public global::System.Data.SQLite.SQLiteParameter this[int index]
		{
			get
			{
				return (global::System.Data.SQLite.SQLiteParameter)this.GetParameter(index);
			}
			set
			{
				this.SetParameter(index, value);
			}
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x0001FD44 File Offset: 0x0001F144
		protected override global::System.Data.Common.DbParameter GetParameter(string parameterName)
		{
			return this.GetParameter(this.IndexOf(parameterName));
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x0001FD60 File Offset: 0x0001F160
		protected override global::System.Data.Common.DbParameter GetParameter(int index)
		{
			return this._parameterList[index];
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x0001FD7C File Offset: 0x0001F17C
		public override int IndexOf(string parameterName)
		{
			int count = this._parameterList.Count;
			for (int i = 0; i < count; i++)
			{
				if (string.Compare(parameterName, this._parameterList[i].ParameterName, global::System.StringComparison.OrdinalIgnoreCase) == 0)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x0001FDC0 File Offset: 0x0001F1C0
		public override int IndexOf(object value)
		{
			return this._parameterList.IndexOf((global::System.Data.SQLite.SQLiteParameter)value);
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x0001FDE0 File Offset: 0x0001F1E0
		public override void Insert(int index, object value)
		{
			this._unboundFlag = true;
			this._parameterList.Insert(index, (global::System.Data.SQLite.SQLiteParameter)value);
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x0001FE08 File Offset: 0x0001F208
		public override void Remove(object value)
		{
			this._unboundFlag = true;
			this._parameterList.Remove((global::System.Data.SQLite.SQLiteParameter)value);
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x0001FE30 File Offset: 0x0001F230
		public override void RemoveAt(string parameterName)
		{
			this.RemoveAt(this.IndexOf(parameterName));
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x0001FE4C File Offset: 0x0001F24C
		public override void RemoveAt(int index)
		{
			this._unboundFlag = true;
			this._parameterList.RemoveAt(index);
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x0001FE6C File Offset: 0x0001F26C
		protected override void SetParameter(string parameterName, global::System.Data.Common.DbParameter value)
		{
			this.SetParameter(this.IndexOf(parameterName), value);
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x0001FE88 File Offset: 0x0001F288
		protected override void SetParameter(int index, global::System.Data.Common.DbParameter value)
		{
			this._unboundFlag = true;
			this._parameterList[index] = (global::System.Data.SQLite.SQLiteParameter)value;
		}

		// Token: 0x060003BA RID: 954 RVA: 0x0001FEB0 File Offset: 0x0001F2B0
		internal void Unbind()
		{
			this._unboundFlag = true;
		}

		// Token: 0x060003BB RID: 955 RVA: 0x0001FEC4 File Offset: 0x0001F2C4
		internal void MapParameters(global::System.Data.SQLite.SQLiteStatement activeStatement)
		{
			if (!this._unboundFlag || this._parameterList.Count == 0 || this._command._statementList == null)
			{
				return;
			}
			int num = 0;
			int num2 = -1;
			foreach (global::System.Data.SQLite.SQLiteParameter sqliteParameter in this._parameterList)
			{
				num2++;
				string text = sqliteParameter.ParameterName;
				if (text == null)
				{
					text = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, ";{0}", new object[]
					{
						num
					});
					num++;
				}
				bool flag = false;
				int num3;
				if (activeStatement == null)
				{
					num3 = this._command._statementList.Count;
				}
				else
				{
					num3 = 1;
				}
				global::System.Data.SQLite.SQLiteStatement sqliteStatement = activeStatement;
				for (int i = 0; i < num3; i++)
				{
					flag = false;
					if (sqliteStatement == null)
					{
						sqliteStatement = this._command._statementList[i];
					}
					if (sqliteStatement._paramNames != null && sqliteStatement.MapParameter(text, sqliteParameter))
					{
						flag = true;
					}
					sqliteStatement = null;
				}
				if (!flag)
				{
					text = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, ";{0}", new object[]
					{
						num2
					});
					sqliteStatement = activeStatement;
					for (int i = 0; i < num3; i++)
					{
						if (sqliteStatement == null)
						{
							sqliteStatement = this._command._statementList[i];
						}
						if (sqliteStatement._paramNames == null || sqliteStatement.MapParameter(text, sqliteParameter))
						{
						}
						sqliteStatement = null;
					}
				}
			}
			if (activeStatement == null)
			{
				this._unboundFlag = false;
			}
		}

		// Token: 0x040001B8 RID: 440
		private global::System.Data.SQLite.SQLiteCommand _command;

		// Token: 0x040001B9 RID: 441
		private global::System.Collections.Generic.List<global::System.Data.SQLite.SQLiteParameter> _parameterList;

		// Token: 0x040001BA RID: 442
		private bool _unboundFlag;
	}
}
