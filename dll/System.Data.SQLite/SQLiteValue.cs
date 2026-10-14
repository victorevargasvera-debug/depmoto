using System;

namespace System.Data.SQLite
{
	// Token: 0x02000076 RID: 118
	public sealed class SQLiteValue : global::System.Data.SQLite.ISQLiteNativeHandle
	{
		// Token: 0x060004E0 RID: 1248 RVA: 0x00021628 File Offset: 0x00020A28
		private SQLiteValue(global::System.IntPtr pValue)
		{
			this.pValue = pValue;
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x00021644 File Offset: 0x00020A44
		private void PreventNativeAccess()
		{
			this.pValue = global::System.IntPtr.Zero;
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x0002165C File Offset: 0x00020A5C
		internal static global::System.Data.SQLite.SQLiteValue[] ArrayFromSizeAndIntPtr(int argc, global::System.IntPtr argv)
		{
			if (argc < 0)
			{
				return null;
			}
			if (argv == global::System.IntPtr.Zero)
			{
				return null;
			}
			global::System.Data.SQLite.SQLiteValue[] array = new global::System.Data.SQLite.SQLiteValue[argc];
			int i = 0;
			int num = 0;
			while (i < array.Length)
			{
				global::System.IntPtr value = global::System.Data.SQLite.SQLiteMarshal.ReadIntPtr(argv, num);
				array[i] = ((value != global::System.IntPtr.Zero) ? new global::System.Data.SQLite.SQLiteValue(value) : null);
				i++;
				num += global::System.IntPtr.Size;
			}
			return array;
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060004E3 RID: 1251 RVA: 0x000216C0 File Offset: 0x00020AC0
		public global::System.IntPtr NativeHandle
		{
			get
			{
				return this.pValue;
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060004E4 RID: 1252 RVA: 0x000216D4 File Offset: 0x00020AD4
		public bool Persisted
		{
			get
			{
				return this.persisted;
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060004E5 RID: 1253 RVA: 0x000216E8 File Offset: 0x00020AE8
		public object Value
		{
			get
			{
				if (!this.persisted)
				{
					throw new global::System.InvalidOperationException("value was not persisted");
				}
				return this.value;
			}
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x00021710 File Offset: 0x00020B10
		public global::System.Data.SQLite.TypeAffinity GetTypeAffinity()
		{
			if (this.pValue == global::System.IntPtr.Zero)
			{
				return global::System.Data.SQLite.TypeAffinity.None;
			}
			return global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_value_type(this.pValue);
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x00021740 File Offset: 0x00020B40
		public int GetBytes()
		{
			if (this.pValue == global::System.IntPtr.Zero)
			{
				return 0;
			}
			return global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_value_bytes(this.pValue);
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x0002176C File Offset: 0x00020B6C
		public int GetInt()
		{
			if (this.pValue == global::System.IntPtr.Zero)
			{
				return 0;
			}
			return global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_value_int(this.pValue);
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x00021798 File Offset: 0x00020B98
		public long GetInt64()
		{
			if (this.pValue == global::System.IntPtr.Zero)
			{
				return 0L;
			}
			return global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_value_int64(this.pValue);
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x000217C8 File Offset: 0x00020BC8
		public double GetDouble()
		{
			if (this.pValue == global::System.IntPtr.Zero)
			{
				return 0.0;
			}
			return global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_value_double(this.pValue);
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x000217FC File Offset: 0x00020BFC
		public string GetString()
		{
			if (this.pValue == global::System.IntPtr.Zero)
			{
				return null;
			}
			return global::System.Data.SQLite.SQLiteString.StringFromUtf8IntPtr(this.pValue, this.GetBytes());
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x00021830 File Offset: 0x00020C30
		public byte[] GetBlob()
		{
			if (this.pValue == global::System.IntPtr.Zero)
			{
				return null;
			}
			return global::System.Data.SQLite.SQLiteBytes.FromIntPtr(this.pValue, this.GetBytes());
		}

		// Token: 0x060004ED RID: 1261 RVA: 0x00021864 File Offset: 0x00020C64
		public bool Persist()
		{
			switch (this.GetTypeAffinity())
			{
			case global::System.Data.SQLite.TypeAffinity.Uninitialized:
				this.value = null;
				this.PreventNativeAccess();
				return this.persisted = true;
			case global::System.Data.SQLite.TypeAffinity.Int64:
				this.value = this.GetInt64();
				this.PreventNativeAccess();
				return this.persisted = true;
			case global::System.Data.SQLite.TypeAffinity.Double:
				this.value = this.GetDouble();
				this.PreventNativeAccess();
				return this.persisted = true;
			case global::System.Data.SQLite.TypeAffinity.Text:
				this.value = this.GetString();
				this.PreventNativeAccess();
				return this.persisted = true;
			case global::System.Data.SQLite.TypeAffinity.Blob:
				this.value = this.GetBytes();
				this.PreventNativeAccess();
				return this.persisted = true;
			case global::System.Data.SQLite.TypeAffinity.Null:
				this.value = global::System.DBNull.Value;
				this.PreventNativeAccess();
				return this.persisted = true;
			default:
				return false;
			}
		}

		// Token: 0x040001F7 RID: 503
		private global::System.IntPtr pValue;

		// Token: 0x040001F8 RID: 504
		private bool persisted;

		// Token: 0x040001F9 RID: 505
		private object value;
	}
}
