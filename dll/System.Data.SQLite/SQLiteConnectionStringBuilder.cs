using System;
using System.Collections;
using System.ComponentModel;
using System.Data.Common;
using System.Globalization;
using System.Reflection;

namespace System.Data.SQLite
{
	// Token: 0x02000026 RID: 38
	[global::System.ComponentModel.DefaultProperty("DataSource")]
	[global::System.Reflection.DefaultMember("Item")]
	public sealed class SQLiteConnectionStringBuilder : global::System.Data.Common.DbConnectionStringBuilder
	{
		// Token: 0x06000254 RID: 596 RVA: 0x00019980 File Offset: 0x00018D80
		public SQLiteConnectionStringBuilder()
		{
			this.Initialize(null);
		}

		// Token: 0x06000255 RID: 597 RVA: 0x0001999C File Offset: 0x00018D9C
		public SQLiteConnectionStringBuilder(string connectionString)
		{
			this.Initialize(connectionString);
		}

		// Token: 0x06000256 RID: 598 RVA: 0x000199B8 File Offset: 0x00018DB8
		private void Initialize(string cnnString)
		{
			this._properties = new global::System.Collections.Hashtable(global::System.StringComparer.OrdinalIgnoreCase);
			try
			{
				base.GetProperties(this._properties);
			}
			catch (global::System.NotImplementedException)
			{
				this.FallbackGetProperties(this._properties);
			}
			if (!string.IsNullOrEmpty(cnnString))
			{
				base.ConnectionString = cnnString;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000257 RID: 599 RVA: 0x00019A20 File Offset: 0x00018E20
		// (set) Token: 0x06000258 RID: 600 RVA: 0x00019A48 File Offset: 0x00018E48
		[global::System.ComponentModel.Browsable(true)]
		[global::System.ComponentModel.DefaultValue(3)]
		public int Version
		{
			get
			{
				object value;
				this.TryGetValue("version", out value);
				return global::System.Convert.ToInt32(value, global::System.Globalization.CultureInfo.CurrentCulture);
			}
			set
			{
				if (value != 3)
				{
					throw new global::System.NotSupportedException();
				}
				this["version"] = value;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000259 RID: 601 RVA: 0x00019A70 File Offset: 0x00018E70
		// (set) Token: 0x0600025A RID: 602 RVA: 0x00019AB4 File Offset: 0x00018EB4
		[global::System.ComponentModel.DefaultValue(global::System.Data.SQLite.SynchronizationModes.Normal)]
		[global::System.ComponentModel.Browsable(true)]
		[global::System.ComponentModel.DisplayName("Synchronous")]
		public global::System.Data.SQLite.SynchronizationModes SyncMode
		{
			get
			{
				object obj;
				this.TryGetValue("synchronous", out obj);
				if (obj is string)
				{
					return (global::System.Data.SQLite.SynchronizationModes)global::System.ComponentModel.TypeDescriptor.GetConverter(typeof(global::System.Data.SQLite.SynchronizationModes)).ConvertFrom(obj);
				}
				return (global::System.Data.SQLite.SynchronizationModes)obj;
			}
			set
			{
				this["synchronous"] = value;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x0600025B RID: 603 RVA: 0x00019AD4 File Offset: 0x00018ED4
		// (set) Token: 0x0600025C RID: 604 RVA: 0x00019AF8 File Offset: 0x00018EF8
		[global::System.ComponentModel.DefaultValue(false)]
		[global::System.ComponentModel.Browsable(true)]
		public bool UseUTF16Encoding
		{
			get
			{
				object source;
				this.TryGetValue("useutf16encoding", out source);
				return global::System.Data.SQLite.SQLiteConvert.ToBoolean(source);
			}
			set
			{
				this["useutf16encoding"] = value;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x0600025D RID: 605 RVA: 0x00019B18 File Offset: 0x00018F18
		// (set) Token: 0x0600025E RID: 606 RVA: 0x00019B3C File Offset: 0x00018F3C
		[global::System.ComponentModel.Browsable(true)]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool Pooling
		{
			get
			{
				object source;
				this.TryGetValue("pooling", out source);
				return global::System.Data.SQLite.SQLiteConvert.ToBoolean(source);
			}
			set
			{
				this["pooling"] = value;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x0600025F RID: 607 RVA: 0x00019B5C File Offset: 0x00018F5C
		// (set) Token: 0x06000260 RID: 608 RVA: 0x00019B80 File Offset: 0x00018F80
		[global::System.ComponentModel.Browsable(true)]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool BinaryGUID
		{
			get
			{
				object source;
				this.TryGetValue("binaryguid", out source);
				return global::System.Data.SQLite.SQLiteConvert.ToBoolean(source);
			}
			set
			{
				this["binaryguid"] = value;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000261 RID: 609 RVA: 0x00019BA0 File Offset: 0x00018FA0
		// (set) Token: 0x06000262 RID: 610 RVA: 0x00019BC4 File Offset: 0x00018FC4
		[global::System.ComponentModel.DefaultValue("")]
		[global::System.ComponentModel.Browsable(true)]
		[global::System.ComponentModel.DisplayName("Data Source")]
		public string DataSource
		{
			get
			{
				object obj;
				this.TryGetValue("data source", out obj);
				return obj.ToString();
			}
			set
			{
				this["data source"] = value;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000263 RID: 611 RVA: 0x00019BE0 File Offset: 0x00018FE0
		// (set) Token: 0x06000264 RID: 612 RVA: 0x00019C04 File Offset: 0x00019004
		[global::System.ComponentModel.Browsable(false)]
		public string Uri
		{
			get
			{
				object obj;
				this.TryGetValue("uri", out obj);
				return obj.ToString();
			}
			set
			{
				this["uri"] = value;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000265 RID: 613 RVA: 0x00019C20 File Offset: 0x00019020
		// (set) Token: 0x06000266 RID: 614 RVA: 0x00019C44 File Offset: 0x00019044
		[global::System.ComponentModel.Browsable(false)]
		public string FullUri
		{
			get
			{
				object obj;
				this.TryGetValue("fulluri", out obj);
				return obj.ToString();
			}
			set
			{
				this["fulluri"] = value;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000267 RID: 615 RVA: 0x00019C60 File Offset: 0x00019060
		// (set) Token: 0x06000268 RID: 616 RVA: 0x00019C88 File Offset: 0x00019088
		[global::System.ComponentModel.DefaultValue(30)]
		[global::System.ComponentModel.DisplayName("Default Timeout")]
		[global::System.ComponentModel.Browsable(true)]
		public int DefaultTimeout
		{
			get
			{
				object value;
				this.TryGetValue("default timeout", out value);
				return global::System.Convert.ToInt32(value, global::System.Globalization.CultureInfo.CurrentCulture);
			}
			set
			{
				this["default timeout"] = value;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000269 RID: 617 RVA: 0x00019CA8 File Offset: 0x000190A8
		// (set) Token: 0x0600026A RID: 618 RVA: 0x00019CCC File Offset: 0x000190CC
		[global::System.ComponentModel.DefaultValue(true)]
		[global::System.ComponentModel.Browsable(true)]
		public bool Enlist
		{
			get
			{
				object source;
				this.TryGetValue("enlist", out source);
				return global::System.Data.SQLite.SQLiteConvert.ToBoolean(source);
			}
			set
			{
				this["enlist"] = value;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x0600026B RID: 619 RVA: 0x00019CEC File Offset: 0x000190EC
		// (set) Token: 0x0600026C RID: 620 RVA: 0x00019D10 File Offset: 0x00019110
		[global::System.ComponentModel.Browsable(true)]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool FailIfMissing
		{
			get
			{
				object source;
				this.TryGetValue("failifmissing", out source);
				return global::System.Data.SQLite.SQLiteConvert.ToBoolean(source);
			}
			set
			{
				this["failifmissing"] = value;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x0600026D RID: 621 RVA: 0x00019D30 File Offset: 0x00019130
		// (set) Token: 0x0600026E RID: 622 RVA: 0x00019D54 File Offset: 0x00019154
		[global::System.ComponentModel.DefaultValue(false)]
		[global::System.ComponentModel.DisplayName("Legacy Format")]
		[global::System.ComponentModel.Browsable(true)]
		public bool LegacyFormat
		{
			get
			{
				object source;
				this.TryGetValue("legacy format", out source);
				return global::System.Data.SQLite.SQLiteConvert.ToBoolean(source);
			}
			set
			{
				this["legacy format"] = value;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x0600026F RID: 623 RVA: 0x00019D74 File Offset: 0x00019174
		// (set) Token: 0x06000270 RID: 624 RVA: 0x00019D98 File Offset: 0x00019198
		[global::System.ComponentModel.DisplayName("Read Only")]
		[global::System.ComponentModel.Browsable(true)]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool ReadOnly
		{
			get
			{
				object source;
				this.TryGetValue("read only", out source);
				return global::System.Data.SQLite.SQLiteConvert.ToBoolean(source);
			}
			set
			{
				this["read only"] = value;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000271 RID: 625 RVA: 0x00019DB8 File Offset: 0x000191B8
		// (set) Token: 0x06000272 RID: 626 RVA: 0x00019DDC File Offset: 0x000191DC
		[global::System.ComponentModel.Browsable(true)]
		[global::System.ComponentModel.DefaultValue("")]
		[global::System.ComponentModel.PasswordPropertyText(true)]
		public string Password
		{
			get
			{
				object obj;
				this.TryGetValue("password", out obj);
				return obj.ToString();
			}
			set
			{
				this["password"] = value;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000273 RID: 627 RVA: 0x00019DF8 File Offset: 0x000191F8
		// (set) Token: 0x06000274 RID: 628 RVA: 0x00019E34 File Offset: 0x00019234
		[global::System.ComponentModel.DefaultValue(null)]
		[global::System.ComponentModel.PasswordPropertyText(true)]
		[global::System.ComponentModel.Browsable(true)]
		public byte[] HexPassword
		{
			get
			{
				object obj;
				if (this.TryGetValue("hexpassword", out obj))
				{
					if (obj is string)
					{
						return global::System.Data.SQLite.SQLiteConnection.FromHexString((string)obj);
					}
					if (obj != null)
					{
						return (byte[])obj;
					}
				}
				return null;
			}
			set
			{
				this["hexpassword"] = global::System.Data.SQLite.SQLiteConnection.ToHexString(value);
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000275 RID: 629 RVA: 0x00019E54 File Offset: 0x00019254
		// (set) Token: 0x06000276 RID: 630 RVA: 0x00019E7C File Offset: 0x0001927C
		[global::System.ComponentModel.DisplayName("Page Size")]
		[global::System.ComponentModel.DefaultValue(1024)]
		[global::System.ComponentModel.Browsable(true)]
		public int PageSize
		{
			get
			{
				object value;
				this.TryGetValue("page size", out value);
				return global::System.Convert.ToInt32(value, global::System.Globalization.CultureInfo.CurrentCulture);
			}
			set
			{
				this["page size"] = value;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000277 RID: 631 RVA: 0x00019E9C File Offset: 0x0001929C
		// (set) Token: 0x06000278 RID: 632 RVA: 0x00019EC4 File Offset: 0x000192C4
		[global::System.ComponentModel.Browsable(true)]
		[global::System.ComponentModel.DefaultValue(0)]
		[global::System.ComponentModel.DisplayName("Max Page Count")]
		public int MaxPageCount
		{
			get
			{
				object value;
				this.TryGetValue("max page count", out value);
				return global::System.Convert.ToInt32(value, global::System.Globalization.CultureInfo.CurrentCulture);
			}
			set
			{
				this["max page count"] = value;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000279 RID: 633 RVA: 0x00019EE4 File Offset: 0x000192E4
		// (set) Token: 0x0600027A RID: 634 RVA: 0x00019F0C File Offset: 0x0001930C
		[global::System.ComponentModel.DisplayName("Cache Size")]
		[global::System.ComponentModel.Browsable(true)]
		[global::System.ComponentModel.DefaultValue(2000)]
		public int CacheSize
		{
			get
			{
				object value;
				this.TryGetValue("cache size", out value);
				return global::System.Convert.ToInt32(value, global::System.Globalization.CultureInfo.CurrentCulture);
			}
			set
			{
				this["cache size"] = value;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x0600027B RID: 635 RVA: 0x00019F2C File Offset: 0x0001932C
		// (set) Token: 0x0600027C RID: 636 RVA: 0x00019F78 File Offset: 0x00019378
		[global::System.ComponentModel.Browsable(true)]
		[global::System.ComponentModel.DefaultValue(global::System.Data.SQLite.SQLiteDateFormats.ISO8601)]
		public global::System.Data.SQLite.SQLiteDateFormats DateTimeFormat
		{
			get
			{
				object obj;
				if (this.TryGetValue("datetimeformat", out obj))
				{
					if (obj is global::System.Data.SQLite.SQLiteDateFormats)
					{
						return (global::System.Data.SQLite.SQLiteDateFormats)obj;
					}
					if (obj != null)
					{
						return (global::System.Data.SQLite.SQLiteDateFormats)global::System.ComponentModel.TypeDescriptor.GetConverter(typeof(global::System.Data.SQLite.SQLiteDateFormats)).ConvertFrom(obj);
					}
				}
				return global::System.Data.SQLite.SQLiteDateFormats.ISO8601;
			}
			set
			{
				this["datetimeformat"] = value;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x0600027D RID: 637 RVA: 0x00019F98 File Offset: 0x00019398
		// (set) Token: 0x0600027E RID: 638 RVA: 0x00019FE4 File Offset: 0x000193E4
		[global::System.ComponentModel.Browsable(true)]
		[global::System.ComponentModel.DefaultValue(global::System.DateTimeKind.Unspecified)]
		public global::System.DateTimeKind DateTimeKind
		{
			get
			{
				object obj;
				if (this.TryGetValue("datetimekind", out obj))
				{
					if (obj is global::System.DateTimeKind)
					{
						return (global::System.DateTimeKind)obj;
					}
					if (obj != null)
					{
						return (global::System.DateTimeKind)global::System.ComponentModel.TypeDescriptor.GetConverter(typeof(global::System.DateTimeKind)).ConvertFrom(obj);
					}
				}
				return global::System.DateTimeKind.Unspecified;
			}
			set
			{
				this["datetimekind"] = value;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x0600027F RID: 639 RVA: 0x0001A004 File Offset: 0x00019404
		// (set) Token: 0x06000280 RID: 640 RVA: 0x0001A03C File Offset: 0x0001943C
		[global::System.ComponentModel.Browsable(true)]
		[global::System.ComponentModel.DefaultValue(null)]
		public string DateTimeFormatString
		{
			get
			{
				object obj;
				if (this.TryGetValue("datetimeformatstring", out obj))
				{
					if (obj is string)
					{
						return (string)obj;
					}
					if (obj != null)
					{
						return obj.ToString();
					}
				}
				return null;
			}
			set
			{
				this["datetimeformatstring"] = value;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000281 RID: 641 RVA: 0x0001A058 File Offset: 0x00019458
		// (set) Token: 0x06000282 RID: 642 RVA: 0x0001A090 File Offset: 0x00019490
		[global::System.ComponentModel.DefaultValue("sqlite_default_schema")]
		[global::System.ComponentModel.Browsable(true)]
		public string BaseSchemaName
		{
			get
			{
				object obj;
				if (this.TryGetValue("baseschemaname", out obj))
				{
					if (obj is string)
					{
						return (string)obj;
					}
					if (obj != null)
					{
						return obj.ToString();
					}
				}
				return null;
			}
			set
			{
				this["baseschemaname"] = value;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000283 RID: 643 RVA: 0x0001A0AC File Offset: 0x000194AC
		// (set) Token: 0x06000284 RID: 644 RVA: 0x0001A0F0 File Offset: 0x000194F0
		[global::System.ComponentModel.DefaultValue(global::System.Data.SQLite.SQLiteJournalModeEnum.Default)]
		[global::System.ComponentModel.Browsable(true)]
		[global::System.ComponentModel.DisplayName("Journal Mode")]
		public global::System.Data.SQLite.SQLiteJournalModeEnum JournalMode
		{
			get
			{
				object obj;
				this.TryGetValue("journal mode", out obj);
				if (obj is string)
				{
					return (global::System.Data.SQLite.SQLiteJournalModeEnum)global::System.ComponentModel.TypeDescriptor.GetConverter(typeof(global::System.Data.SQLite.SQLiteJournalModeEnum)).ConvertFrom(obj);
				}
				return (global::System.Data.SQLite.SQLiteJournalModeEnum)obj;
			}
			set
			{
				this["journal mode"] = value;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000285 RID: 645 RVA: 0x0001A110 File Offset: 0x00019510
		// (set) Token: 0x06000286 RID: 646 RVA: 0x0001A154 File Offset: 0x00019554
		[global::System.ComponentModel.Browsable(true)]
		[global::System.ComponentModel.DisplayName("Default Isolation Level")]
		[global::System.ComponentModel.DefaultValue(global::System.Data.IsolationLevel.Serializable)]
		public global::System.Data.IsolationLevel DefaultIsolationLevel
		{
			get
			{
				object obj;
				this.TryGetValue("default isolationlevel", out obj);
				if (obj is string)
				{
					return (global::System.Data.IsolationLevel)global::System.ComponentModel.TypeDescriptor.GetConverter(typeof(global::System.Data.IsolationLevel)).ConvertFrom(obj);
				}
				return (global::System.Data.IsolationLevel)obj;
			}
			set
			{
				this["default isolationlevel"] = value;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000287 RID: 647 RVA: 0x0001A174 File Offset: 0x00019574
		// (set) Token: 0x06000288 RID: 648 RVA: 0x0001A198 File Offset: 0x00019598
		[global::System.ComponentModel.Browsable(true)]
		[global::System.ComponentModel.DisplayName("Foreign Keys")]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool ForeignKeys
		{
			get
			{
				object source;
				this.TryGetValue("foreign keys", out source);
				return global::System.Data.SQLite.SQLiteConvert.ToBoolean(source);
			}
			set
			{
				this["foreign keys"] = value;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000289 RID: 649 RVA: 0x0001A1B8 File Offset: 0x000195B8
		// (set) Token: 0x0600028A RID: 650 RVA: 0x0001A208 File Offset: 0x00019608
		[global::System.ComponentModel.DefaultValue(global::System.Data.SQLite.SQLiteConnectionFlags.Default)]
		[global::System.ComponentModel.Browsable(true)]
		public global::System.Data.SQLite.SQLiteConnectionFlags Flags
		{
			get
			{
				object obj;
				if (this.TryGetValue("flags", out obj))
				{
					if (obj is global::System.Data.SQLite.SQLiteConnectionFlags)
					{
						return (global::System.Data.SQLite.SQLiteConnectionFlags)obj;
					}
					if (obj != null)
					{
						return (global::System.Data.SQLite.SQLiteConnectionFlags)global::System.ComponentModel.TypeDescriptor.GetConverter(typeof(global::System.Data.SQLite.SQLiteConnectionFlags)).ConvertFrom(obj);
					}
				}
				return global::System.Data.SQLite.SQLiteConnectionFlags.Default;
			}
			set
			{
				this["flags"] = value;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600028B RID: 651 RVA: 0x0001A228 File Offset: 0x00019628
		// (set) Token: 0x0600028C RID: 652 RVA: 0x0001A24C File Offset: 0x0001964C
		[global::System.ComponentModel.DisplayName("SetDefaults")]
		[global::System.ComponentModel.Browsable(true)]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool SetDefaults
		{
			get
			{
				object source;
				this.TryGetValue("setdefaults", out source);
				return global::System.Data.SQLite.SQLiteConvert.ToBoolean(source);
			}
			set
			{
				this["setdefaults"] = value;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600028D RID: 653 RVA: 0x0001A26C File Offset: 0x0001966C
		// (set) Token: 0x0600028E RID: 654 RVA: 0x0001A290 File Offset: 0x00019690
		[global::System.ComponentModel.Browsable(true)]
		[global::System.ComponentModel.DisplayName("ToFullPath")]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool ToFullPath
		{
			get
			{
				object source;
				this.TryGetValue("tofullpath", out source);
				return global::System.Data.SQLite.SQLiteConvert.ToBoolean(source);
			}
			set
			{
				this["tofullpath"] = value;
			}
		}

		// Token: 0x0600028F RID: 655 RVA: 0x0001A2B0 File Offset: 0x000196B0
		public override bool TryGetValue(string keyword, out object value)
		{
			bool flag = base.TryGetValue(keyword, out value);
			if (!this._properties.ContainsKey(keyword))
			{
				return flag;
			}
			global::System.ComponentModel.PropertyDescriptor propertyDescriptor = this._properties[keyword] as global::System.ComponentModel.PropertyDescriptor;
			if (propertyDescriptor == null)
			{
				return flag;
			}
			if (flag)
			{
				if (propertyDescriptor.PropertyType == typeof(bool))
				{
					value = global::System.Data.SQLite.SQLiteConvert.ToBoolean(value);
				}
				else if (propertyDescriptor.PropertyType != typeof(byte[]))
				{
					value = global::System.ComponentModel.TypeDescriptor.GetConverter(propertyDescriptor.PropertyType).ConvertFrom(value);
				}
			}
			else
			{
				global::System.ComponentModel.DefaultValueAttribute defaultValueAttribute = propertyDescriptor.Attributes[typeof(global::System.ComponentModel.DefaultValueAttribute)] as global::System.ComponentModel.DefaultValueAttribute;
				if (defaultValueAttribute != null)
				{
					value = defaultValueAttribute.Value;
					flag = true;
				}
			}
			return flag;
		}

		// Token: 0x06000290 RID: 656 RVA: 0x0001A370 File Offset: 0x00019770
		private void FallbackGetProperties(global::System.Collections.Hashtable propertyList)
		{
			foreach (object obj in global::System.ComponentModel.TypeDescriptor.GetProperties(this, true))
			{
				global::System.ComponentModel.PropertyDescriptor propertyDescriptor = (global::System.ComponentModel.PropertyDescriptor)obj;
				if (propertyDescriptor.Name != "ConnectionString" && !propertyList.ContainsKey(propertyDescriptor.DisplayName))
				{
					propertyList.Add(propertyDescriptor.DisplayName, propertyDescriptor);
				}
			}
		}

		// Token: 0x040000CE RID: 206
		private global::System.Collections.Hashtable _properties;
	}
}
