using System;
using System.Runtime.InteropServices;
using System.Text;

namespace System.Data.SQLite
{
	// Token: 0x02000083 RID: 131
	internal static class SQLiteString
	{
		// Token: 0x06000559 RID: 1369 RVA: 0x0002231C File Offset: 0x0002171C
		public static byte[] GetUtf8BytesFromString(string value)
		{
			if (value == null)
			{
				return null;
			}
			return global::System.Data.SQLite.SQLiteString.Utf8Encoding.GetBytes(value);
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x0002233C File Offset: 0x0002173C
		public static string GetStringFromUtf8Bytes(byte[] bytes)
		{
			if (bytes == null)
			{
				return null;
			}
			return global::System.Data.SQLite.SQLiteString.Utf8Encoding.GetString(bytes);
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x0002235C File Offset: 0x0002175C
		public static int ProbeForUtf8ByteLength(global::System.IntPtr pValue, int limit)
		{
			int num = 0;
			if (pValue != global::System.IntPtr.Zero && limit > 0)
			{
				while (global::System.Runtime.InteropServices.Marshal.ReadByte(pValue, num) != 0 && num < limit)
				{
					num++;
				}
			}
			return num;
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x00022390 File Offset: 0x00021790
		public static string StringFromUtf8IntPtr(global::System.IntPtr pValue)
		{
			return global::System.Data.SQLite.SQLiteString.StringFromUtf8IntPtr(pValue, global::System.Data.SQLite.SQLiteString.ProbeForUtf8ByteLength(pValue, global::System.Data.SQLite.SQLiteString.ThirtyBits));
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x000223B0 File Offset: 0x000217B0
		public static string StringFromUtf8IntPtr(global::System.IntPtr pValue, int length)
		{
			if (pValue == global::System.IntPtr.Zero)
			{
				return null;
			}
			if (length > 0)
			{
				byte[] array = new byte[length];
				global::System.Runtime.InteropServices.Marshal.Copy(pValue, array, 0, length);
				return global::System.Data.SQLite.SQLiteString.GetStringFromUtf8Bytes(array);
			}
			return string.Empty;
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x000223EC File Offset: 0x000217EC
		public static global::System.IntPtr Utf8IntPtrFromString(string value)
		{
			if (value == null)
			{
				return global::System.IntPtr.Zero;
			}
			global::System.IntPtr intPtr = global::System.IntPtr.Zero;
			byte[] utf8BytesFromString = global::System.Data.SQLite.SQLiteString.GetUtf8BytesFromString(value);
			if (utf8BytesFromString == null)
			{
				return global::System.IntPtr.Zero;
			}
			int num = utf8BytesFromString.Length;
			intPtr = global::System.Data.SQLite.SQLiteMemory.Allocate(num + 1);
			if (intPtr == global::System.IntPtr.Zero)
			{
				return global::System.IntPtr.Zero;
			}
			global::System.Runtime.InteropServices.Marshal.Copy(utf8BytesFromString, 0, intPtr, num);
			global::System.Runtime.InteropServices.Marshal.WriteByte(intPtr, num, 0);
			return intPtr;
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x0002244C File Offset: 0x0002184C
		public static string[] StringArrayFromUtf8SizeAndIntPtr(int argc, global::System.IntPtr argv)
		{
			if (argc < 0)
			{
				return null;
			}
			if (argv == global::System.IntPtr.Zero)
			{
				return null;
			}
			string[] array = new string[argc];
			int i = 0;
			int num = 0;
			while (i < array.Length)
			{
				global::System.IntPtr intPtr = global::System.Data.SQLite.SQLiteMarshal.ReadIntPtr(argv, num);
				array[i] = ((intPtr != global::System.IntPtr.Zero) ? global::System.Data.SQLite.SQLiteString.StringFromUtf8IntPtr(intPtr) : null);
				i++;
				num += global::System.IntPtr.Size;
			}
			return array;
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x000224B0 File Offset: 0x000218B0
		public static global::System.IntPtr[] Utf8IntPtrArrayFromStringArray(string[] values)
		{
			if (values == null)
			{
				return null;
			}
			global::System.IntPtr[] array = new global::System.IntPtr[values.Length];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = global::System.Data.SQLite.SQLiteString.Utf8IntPtrFromString(values[i]);
			}
			return array;
		}

		// Token: 0x04000223 RID: 547
		private static int ThirtyBits = 1073741823;

		// Token: 0x04000224 RID: 548
		private static readonly global::System.Text.Encoding Utf8Encoding = global::System.Text.Encoding.UTF8;
	}
}
