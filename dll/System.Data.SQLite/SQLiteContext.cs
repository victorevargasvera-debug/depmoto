using System;

namespace System.Data.SQLite
{
	// Token: 0x02000075 RID: 117
	public sealed class SQLiteContext : global::System.Data.SQLite.ISQLiteNativeHandle
	{
		// Token: 0x060004D2 RID: 1234 RVA: 0x0002133C File Offset: 0x0002073C
		internal SQLiteContext(global::System.IntPtr pContext)
		{
			this.pContext = pContext;
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060004D3 RID: 1235 RVA: 0x00021358 File Offset: 0x00020758
		public global::System.IntPtr NativeHandle
		{
			get
			{
				return this.pContext;
			}
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x0002136C File Offset: 0x0002076C
		public void SetNull()
		{
			if (this.pContext == global::System.IntPtr.Zero)
			{
				throw new global::System.InvalidOperationException();
			}
			global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_result_null(this.pContext);
		}

		// Token: 0x060004D5 RID: 1237 RVA: 0x0002139C File Offset: 0x0002079C
		public void SetDouble(double value)
		{
			if (this.pContext == global::System.IntPtr.Zero)
			{
				throw new global::System.InvalidOperationException();
			}
			global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_result_double(this.pContext, value);
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x000213D0 File Offset: 0x000207D0
		public void SetInt(int value)
		{
			if (this.pContext == global::System.IntPtr.Zero)
			{
				throw new global::System.InvalidOperationException();
			}
			global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_result_int(this.pContext, value);
		}

		// Token: 0x060004D7 RID: 1239 RVA: 0x00021404 File Offset: 0x00020804
		public void SetInt64(long value)
		{
			if (this.pContext == global::System.IntPtr.Zero)
			{
				throw new global::System.InvalidOperationException();
			}
			global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_result_int64(this.pContext, value);
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x00021438 File Offset: 0x00020838
		public void SetString(string value)
		{
			if (this.pContext == global::System.IntPtr.Zero)
			{
				throw new global::System.InvalidOperationException();
			}
			byte[] utf8BytesFromString = global::System.Data.SQLite.SQLiteString.GetUtf8BytesFromString(value);
			if (utf8BytesFromString == null)
			{
				throw new global::System.ArgumentNullException("value");
			}
			global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_result_text(this.pContext, utf8BytesFromString, utf8BytesFromString.Length, (global::System.IntPtr)(-1));
		}

		// Token: 0x060004D9 RID: 1241 RVA: 0x00021488 File Offset: 0x00020888
		public void SetError(string value)
		{
			if (this.pContext == global::System.IntPtr.Zero)
			{
				throw new global::System.InvalidOperationException();
			}
			byte[] utf8BytesFromString = global::System.Data.SQLite.SQLiteString.GetUtf8BytesFromString(value);
			if (utf8BytesFromString == null)
			{
				throw new global::System.ArgumentNullException("value");
			}
			global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_result_error(this.pContext, utf8BytesFromString, utf8BytesFromString.Length);
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x000214D4 File Offset: 0x000208D4
		public void SetErrorCode(global::System.Data.SQLite.SQLiteErrorCode value)
		{
			if (this.pContext == global::System.IntPtr.Zero)
			{
				throw new global::System.InvalidOperationException();
			}
			global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_result_error_code(this.pContext, value);
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x00021508 File Offset: 0x00020908
		public void SetErrorTooBig()
		{
			if (this.pContext == global::System.IntPtr.Zero)
			{
				throw new global::System.InvalidOperationException();
			}
			global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_result_error_toobig(this.pContext);
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x00021538 File Offset: 0x00020938
		public void SetErrorNoMemory()
		{
			if (this.pContext == global::System.IntPtr.Zero)
			{
				throw new global::System.InvalidOperationException();
			}
			global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_result_error_nomem(this.pContext);
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x00021568 File Offset: 0x00020968
		public void SetBlob(byte[] value)
		{
			if (this.pContext == global::System.IntPtr.Zero)
			{
				throw new global::System.InvalidOperationException();
			}
			if (value == null)
			{
				throw new global::System.ArgumentNullException("value");
			}
			global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_result_blob(this.pContext, value, value.Length, (global::System.IntPtr)(-1));
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x000215B0 File Offset: 0x000209B0
		public void SetZeroBlob(int value)
		{
			if (this.pContext == global::System.IntPtr.Zero)
			{
				throw new global::System.InvalidOperationException();
			}
			global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_result_zeroblob(this.pContext, value);
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x000215E4 File Offset: 0x000209E4
		public void SetValue(global::System.Data.SQLite.SQLiteValue value)
		{
			if (this.pContext == global::System.IntPtr.Zero)
			{
				throw new global::System.InvalidOperationException();
			}
			if (value == null)
			{
				throw new global::System.ArgumentNullException("value");
			}
			global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_result_value(this.pContext, value.NativeHandle);
		}

		// Token: 0x040001F6 RID: 502
		private global::System.IntPtr pContext;
	}
}
