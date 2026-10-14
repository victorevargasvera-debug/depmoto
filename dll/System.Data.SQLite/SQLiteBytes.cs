using System;
using System.Runtime.InteropServices;

namespace System.Data.SQLite
{
	// Token: 0x02000084 RID: 132
	internal static class SQLiteBytes
	{
		// Token: 0x06000562 RID: 1378 RVA: 0x00022514 File Offset: 0x00021914
		public static byte[] FromIntPtr(global::System.IntPtr pValue, int length)
		{
			if (pValue == global::System.IntPtr.Zero)
			{
				return null;
			}
			if (length == 0)
			{
				return new byte[0];
			}
			byte[] array = new byte[length];
			global::System.Runtime.InteropServices.Marshal.Copy(pValue, array, 0, length);
			return array;
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x0002254C File Offset: 0x0002194C
		public static global::System.IntPtr ToIntPtr(byte[] value)
		{
			if (value == null)
			{
				return global::System.IntPtr.Zero;
			}
			int num = value.Length;
			if (num == 0)
			{
				return global::System.IntPtr.Zero;
			}
			global::System.IntPtr intPtr = global::System.Data.SQLite.SQLiteMemory.Allocate(num);
			if (intPtr == global::System.IntPtr.Zero)
			{
				return global::System.IntPtr.Zero;
			}
			global::System.Runtime.InteropServices.Marshal.Copy(value, 0, intPtr, num);
			return intPtr;
		}
	}
}
