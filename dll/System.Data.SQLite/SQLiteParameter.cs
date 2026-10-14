using System;
using System.ComponentModel;
using System.Data.Common;

namespace System.Data.SQLite
{
	// Token: 0x0200004D RID: 77
	public sealed class SQLiteParameter : global::System.Data.Common.DbParameter, global::System.ICloneable
	{
		// Token: 0x06000372 RID: 882 RVA: 0x0001F5D8 File Offset: 0x0001E9D8
		public SQLiteParameter() : this(null, (global::System.Data.DbType)(-1), 0, null, global::System.Data.DataRowVersion.Current)
		{
		}

		// Token: 0x06000373 RID: 883 RVA: 0x0001F5F4 File Offset: 0x0001E9F4
		public SQLiteParameter(string parameterName) : this(parameterName, (global::System.Data.DbType)(-1), 0, null, global::System.Data.DataRowVersion.Current)
		{
		}

		// Token: 0x06000374 RID: 884 RVA: 0x0001F610 File Offset: 0x0001EA10
		public SQLiteParameter(string parameterName, object value) : this(parameterName, (global::System.Data.DbType)(-1), 0, null, global::System.Data.DataRowVersion.Current)
		{
			this.Value = value;
		}

		// Token: 0x06000375 RID: 885 RVA: 0x0001F634 File Offset: 0x0001EA34
		public SQLiteParameter(string parameterName, global::System.Data.DbType dbType) : this(parameterName, dbType, 0, null, global::System.Data.DataRowVersion.Current)
		{
		}

		// Token: 0x06000376 RID: 886 RVA: 0x0001F650 File Offset: 0x0001EA50
		public SQLiteParameter(string parameterName, global::System.Data.DbType dbType, string sourceColumn) : this(parameterName, dbType, 0, sourceColumn, global::System.Data.DataRowVersion.Current)
		{
		}

		// Token: 0x06000377 RID: 887 RVA: 0x0001F66C File Offset: 0x0001EA6C
		public SQLiteParameter(string parameterName, global::System.Data.DbType dbType, string sourceColumn, global::System.Data.DataRowVersion rowVersion) : this(parameterName, dbType, 0, sourceColumn, rowVersion)
		{
		}

		// Token: 0x06000378 RID: 888 RVA: 0x0001F688 File Offset: 0x0001EA88
		public SQLiteParameter(global::System.Data.DbType dbType) : this(null, dbType, 0, null, global::System.Data.DataRowVersion.Current)
		{
		}

		// Token: 0x06000379 RID: 889 RVA: 0x0001F6A4 File Offset: 0x0001EAA4
		public SQLiteParameter(global::System.Data.DbType dbType, object value) : this(null, dbType, 0, null, global::System.Data.DataRowVersion.Current)
		{
			this.Value = value;
		}

		// Token: 0x0600037A RID: 890 RVA: 0x0001F6C8 File Offset: 0x0001EAC8
		public SQLiteParameter(global::System.Data.DbType dbType, string sourceColumn) : this(null, dbType, 0, sourceColumn, global::System.Data.DataRowVersion.Current)
		{
		}

		// Token: 0x0600037B RID: 891 RVA: 0x0001F6E4 File Offset: 0x0001EAE4
		public SQLiteParameter(global::System.Data.DbType dbType, string sourceColumn, global::System.Data.DataRowVersion rowVersion) : this(null, dbType, 0, sourceColumn, rowVersion)
		{
		}

		// Token: 0x0600037C RID: 892 RVA: 0x0001F6FC File Offset: 0x0001EAFC
		public SQLiteParameter(string parameterName, global::System.Data.DbType parameterType, int parameterSize) : this(parameterName, parameterType, parameterSize, null, global::System.Data.DataRowVersion.Current)
		{
		}

		// Token: 0x0600037D RID: 893 RVA: 0x0001F718 File Offset: 0x0001EB18
		public SQLiteParameter(string parameterName, global::System.Data.DbType parameterType, int parameterSize, string sourceColumn) : this(parameterName, parameterType, parameterSize, sourceColumn, global::System.Data.DataRowVersion.Current)
		{
		}

		// Token: 0x0600037E RID: 894 RVA: 0x0001F738 File Offset: 0x0001EB38
		public SQLiteParameter(string parameterName, global::System.Data.DbType parameterType, int parameterSize, string sourceColumn, global::System.Data.DataRowVersion rowVersion)
		{
			this._parameterName = parameterName;
			this._dbType = (int)parameterType;
			this._sourceColumn = sourceColumn;
			this._rowVersion = rowVersion;
			this._dataSize = parameterSize;
			this._nullable = true;
		}

		// Token: 0x0600037F RID: 895 RVA: 0x0001F778 File Offset: 0x0001EB78
		private SQLiteParameter(global::System.Data.SQLite.SQLiteParameter source) : this(source.ParameterName, (global::System.Data.DbType)source._dbType, 0, source.Direction, source.IsNullable, 0, 0, source.SourceColumn, source.SourceVersion, source.Value)
		{
			this._nullMapping = source._nullMapping;
		}

		// Token: 0x06000380 RID: 896 RVA: 0x0001F7C4 File Offset: 0x0001EBC4
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		public SQLiteParameter(string parameterName, global::System.Data.DbType parameterType, int parameterSize, global::System.Data.ParameterDirection direction, bool isNullable, byte precision, byte scale, string sourceColumn, global::System.Data.DataRowVersion rowVersion, object value) : this(parameterName, parameterType, parameterSize, sourceColumn, rowVersion)
		{
			this.Direction = direction;
			this.IsNullable = isNullable;
			this.Value = value;
		}

		// Token: 0x06000381 RID: 897 RVA: 0x0001F7F8 File Offset: 0x0001EBF8
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		public SQLiteParameter(string parameterName, global::System.Data.DbType parameterType, int parameterSize, global::System.Data.ParameterDirection direction, byte precision, byte scale, string sourceColumn, global::System.Data.DataRowVersion rowVersion, bool sourceColumnNullMapping, object value) : this(parameterName, parameterType, parameterSize, sourceColumn, rowVersion)
		{
			this.Direction = direction;
			this.SourceColumnNullMapping = sourceColumnNullMapping;
			this.Value = value;
		}

		// Token: 0x06000382 RID: 898 RVA: 0x0001F82C File Offset: 0x0001EC2C
		public SQLiteParameter(global::System.Data.DbType parameterType, int parameterSize) : this(null, parameterType, parameterSize, null, global::System.Data.DataRowVersion.Current)
		{
		}

		// Token: 0x06000383 RID: 899 RVA: 0x0001F848 File Offset: 0x0001EC48
		public SQLiteParameter(global::System.Data.DbType parameterType, int parameterSize, string sourceColumn) : this(null, parameterType, parameterSize, sourceColumn, global::System.Data.DataRowVersion.Current)
		{
		}

		// Token: 0x06000384 RID: 900 RVA: 0x0001F864 File Offset: 0x0001EC64
		public SQLiteParameter(global::System.Data.DbType parameterType, int parameterSize, string sourceColumn, global::System.Data.DataRowVersion rowVersion) : this(null, parameterType, parameterSize, sourceColumn, rowVersion)
		{
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000385 RID: 901 RVA: 0x0001F880 File Offset: 0x0001EC80
		// (set) Token: 0x06000386 RID: 902 RVA: 0x0001F894 File Offset: 0x0001EC94
		public override bool IsNullable
		{
			get
			{
				return this._nullable;
			}
			set
			{
				this._nullable = value;
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000387 RID: 903 RVA: 0x0001F8A8 File Offset: 0x0001ECA8
		// (set) Token: 0x06000388 RID: 904 RVA: 0x0001F8F0 File Offset: 0x0001ECF0
		[global::System.Data.Common.DbProviderSpecificTypeProperty(true)]
		[global::System.ComponentModel.RefreshProperties(global::System.ComponentModel.RefreshProperties.All)]
		public override global::System.Data.DbType DbType
		{
			get
			{
				if (this._dbType != -1)
				{
					return (global::System.Data.DbType)this._dbType;
				}
				if (this._objValue != null && this._objValue != global::System.DBNull.Value)
				{
					return global::System.Data.SQLite.SQLiteConvert.TypeToDbType(this._objValue.GetType());
				}
				return global::System.Data.DbType.String;
			}
			set
			{
				this._dbType = (int)value;
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000389 RID: 905 RVA: 0x0001F904 File Offset: 0x0001ED04
		// (set) Token: 0x0600038A RID: 906 RVA: 0x0001F914 File Offset: 0x0001ED14
		public override global::System.Data.ParameterDirection Direction
		{
			get
			{
				return global::System.Data.ParameterDirection.Input;
			}
			set
			{
				if (value != global::System.Data.ParameterDirection.Input)
				{
					throw new global::System.NotSupportedException();
				}
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x0600038B RID: 907 RVA: 0x0001F92C File Offset: 0x0001ED2C
		// (set) Token: 0x0600038C RID: 908 RVA: 0x0001F940 File Offset: 0x0001ED40
		public override string ParameterName
		{
			get
			{
				return this._parameterName;
			}
			set
			{
				this._parameterName = value;
			}
		}

		// Token: 0x0600038D RID: 909 RVA: 0x0001F954 File Offset: 0x0001ED54
		public override void ResetDbType()
		{
			this._dbType = -1;
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x0600038E RID: 910 RVA: 0x0001F968 File Offset: 0x0001ED68
		// (set) Token: 0x0600038F RID: 911 RVA: 0x0001F97C File Offset: 0x0001ED7C
		[global::System.ComponentModel.DefaultValue(0)]
		public override int Size
		{
			get
			{
				return this._dataSize;
			}
			set
			{
				this._dataSize = value;
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000390 RID: 912 RVA: 0x0001F990 File Offset: 0x0001ED90
		// (set) Token: 0x06000391 RID: 913 RVA: 0x0001F9A4 File Offset: 0x0001EDA4
		public override string SourceColumn
		{
			get
			{
				return this._sourceColumn;
			}
			set
			{
				this._sourceColumn = value;
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000392 RID: 914 RVA: 0x0001F9B8 File Offset: 0x0001EDB8
		// (set) Token: 0x06000393 RID: 915 RVA: 0x0001F9CC File Offset: 0x0001EDCC
		public override bool SourceColumnNullMapping
		{
			get
			{
				return this._nullMapping;
			}
			set
			{
				this._nullMapping = value;
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000394 RID: 916 RVA: 0x0001F9E0 File Offset: 0x0001EDE0
		// (set) Token: 0x06000395 RID: 917 RVA: 0x0001F9F4 File Offset: 0x0001EDF4
		public override global::System.Data.DataRowVersion SourceVersion
		{
			get
			{
				return this._rowVersion;
			}
			set
			{
				this._rowVersion = value;
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000396 RID: 918 RVA: 0x0001FA08 File Offset: 0x0001EE08
		// (set) Token: 0x06000397 RID: 919 RVA: 0x0001FA1C File Offset: 0x0001EE1C
		[global::System.ComponentModel.TypeConverter(typeof(global::System.ComponentModel.StringConverter))]
		[global::System.ComponentModel.RefreshProperties(global::System.ComponentModel.RefreshProperties.All)]
		public override object Value
		{
			get
			{
				return this._objValue;
			}
			set
			{
				this._objValue = value;
				if (this._dbType == -1 && this._objValue != null && this._objValue != global::System.DBNull.Value)
				{
					this._dbType = (int)global::System.Data.SQLite.SQLiteConvert.TypeToDbType(this._objValue.GetType());
				}
			}
		}

		// Token: 0x06000398 RID: 920 RVA: 0x0001FA64 File Offset: 0x0001EE64
		public object Clone()
		{
			return new global::System.Data.SQLite.SQLiteParameter(this);
		}

		// Token: 0x040001B0 RID: 432
		internal int _dbType;

		// Token: 0x040001B1 RID: 433
		private global::System.Data.DataRowVersion _rowVersion;

		// Token: 0x040001B2 RID: 434
		private object _objValue;

		// Token: 0x040001B3 RID: 435
		private string _sourceColumn;

		// Token: 0x040001B4 RID: 436
		private string _parameterName;

		// Token: 0x040001B5 RID: 437
		private int _dataSize;

		// Token: 0x040001B6 RID: 438
		private bool _nullable;

		// Token: 0x040001B7 RID: 439
		private bool _nullMapping;
	}
}
