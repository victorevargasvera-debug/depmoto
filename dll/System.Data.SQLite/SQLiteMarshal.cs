using System;
using System.Runtime.InteropServices;

namespace System.Data.SQLite
{
	// Token: 0x02000085 RID: 133
	internal static class SQLiteMarshal
	{
		// Token: 0x06000564 RID: 1380 RVA: 0x00022594 File Offset: 0x00021994
		public static global::System.IntPtr IntPtrForOffset(global::System.IntPtr pointer, int offset)
		{
			return new global::System.IntPtr(pointer.ToInt64() + (long)offset);
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x000225B0 File Offset: 0x000219B0
		public static int RoundUp(int size, int alignment)
		{
			int num = alignment - 1;
			return size + num & ~num;
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x000225C8 File Offset: 0x000219C8
		public static int NextOffsetOf(int offset, int size, int alignment)
		{
			return global::System.Data.SQLite.SQLiteMarshal.RoundUp(offset + size, alignment);
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x000225E0 File Offset: 0x000219E0
		public static int ReadInt32(global::System.IntPtr pointer, int offset)
		{
			return global::System.Runtime.InteropServices.Marshal.ReadInt32(pointer, offset);
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x000225F4 File Offset: 0x000219F4
		public static double ReadDouble(global::System.IntPtr pointer, int offset)
		{
			return global::System.BitConverter.Int64BitsToDouble(global::System.Runtime.InteropServices.Marshal.ReadInt64(pointer, offset));
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x00022610 File Offset: 0x00021A10
		public static global::System.IntPtr ReadIntPtr(global::System.IntPtr pointer, int offset)
		{
			return global::System.Runtime.InteropServices.Marshal.ReadIntPtr(pointer, offset);
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x00022624 File Offset: 0x00021A24
		public static void WriteInt32(global::System.IntPtr pointer, int offset, int value)
		{
			global::System.Runtime.InteropServices.Marshal.WriteInt32(pointer, offset, value);
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x0002263C File Offset: 0x00021A3C
		public static void WriteDouble(global::System.IntPtr pointer, int offset, double value)
		{
			global::System.Runtime.InteropServices.Marshal.WriteInt64(pointer, offset, global::System.BitConverter.DoubleToInt64Bits(value));
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x00022658 File Offset: 0x00021A58
		public static void WriteIntPtr(global::System.IntPtr pointer, int offset, global::System.IntPtr value)
		{
			global::System.Runtime.InteropServices.Marshal.WriteIntPtr(pointer, offset, value);
		}
	}
}
