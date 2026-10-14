using System;
using System.Runtime.InteropServices;

namespace System.Data.SQLite
{
	// Token: 0x0200007D RID: 125
	public sealed class SQLiteIndex
	{
		// Token: 0x06000503 RID: 1283 RVA: 0x00021B9C File Offset: 0x00020F9C
		internal SQLiteIndex(int nConstraint, int nOrderBy)
		{
			this.inputs = new global::System.Data.SQLite.SQLiteIndexInputs(nConstraint, nOrderBy);
			this.outputs = new global::System.Data.SQLite.SQLiteIndexOutputs(nConstraint);
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x00021BC8 File Offset: 0x00020FC8
		internal static void FromIntPtr(global::System.IntPtr pIndex, ref global::System.Data.SQLite.SQLiteIndex index)
		{
			if (pIndex == global::System.IntPtr.Zero)
			{
				return;
			}
			int offset = 0;
			int num = global::System.Data.SQLite.SQLiteMarshal.ReadInt32(pIndex, offset);
			offset = global::System.Data.SQLite.SQLiteMarshal.NextOffsetOf(offset, 4, global::System.IntPtr.Size);
			global::System.IntPtr pointer = global::System.Data.SQLite.SQLiteMarshal.ReadIntPtr(pIndex, offset);
			offset = global::System.Data.SQLite.SQLiteMarshal.NextOffsetOf(offset, global::System.IntPtr.Size, 4);
			int num2 = global::System.Data.SQLite.SQLiteMarshal.ReadInt32(pIndex, offset);
			offset = global::System.Data.SQLite.SQLiteMarshal.NextOffsetOf(offset, 4, global::System.IntPtr.Size);
			global::System.IntPtr pointer2 = global::System.Data.SQLite.SQLiteMarshal.ReadIntPtr(pIndex, offset);
			index = new global::System.Data.SQLite.SQLiteIndex(num, num2);
			global::System.Type typeFromHandle = typeof(global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_index_constraint);
			int num3 = global::System.Runtime.InteropServices.Marshal.SizeOf(typeFromHandle);
			for (int i = 0; i < num; i++)
			{
				global::System.IntPtr ptr = global::System.Data.SQLite.SQLiteMarshal.IntPtrForOffset(pointer, i * num3);
				global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_index_constraint constraint = (global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_index_constraint)global::System.Runtime.InteropServices.Marshal.PtrToStructure(ptr, typeFromHandle);
				index.Inputs.Constraints[i] = new global::System.Data.SQLite.SQLiteIndexConstraint(constraint);
			}
			global::System.Type typeFromHandle2 = typeof(global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_index_orderby);
			int num4 = global::System.Runtime.InteropServices.Marshal.SizeOf(typeFromHandle2);
			for (int j = 0; j < num2; j++)
			{
				global::System.IntPtr ptr2 = global::System.Data.SQLite.SQLiteMarshal.IntPtrForOffset(pointer2, j * num4);
				global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_index_orderby orderBy = (global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_index_orderby)global::System.Runtime.InteropServices.Marshal.PtrToStructure(ptr2, typeFromHandle2);
				index.Inputs.OrderBys[j] = new global::System.Data.SQLite.SQLiteIndexOrderBy(orderBy);
			}
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x00021CE0 File Offset: 0x000210E0
		internal static void ToIntPtr(global::System.Data.SQLite.SQLiteIndex index, global::System.IntPtr pIndex)
		{
			if (index == null || index.Inputs == null || index.Inputs.Constraints == null || index.Outputs == null || index.Outputs.ConstraintUsages == null)
			{
				return;
			}
			if (pIndex == global::System.IntPtr.Zero)
			{
				return;
			}
			int offset = 0;
			int num = global::System.Data.SQLite.SQLiteMarshal.ReadInt32(pIndex, offset);
			if (num != index.Inputs.Constraints.Length)
			{
				return;
			}
			if (num != index.Outputs.ConstraintUsages.Length)
			{
				return;
			}
			offset = global::System.Data.SQLite.SQLiteMarshal.NextOffsetOf(offset, 4, global::System.IntPtr.Size);
			offset = global::System.Data.SQLite.SQLiteMarshal.NextOffsetOf(offset, global::System.IntPtr.Size, 4);
			offset = global::System.Data.SQLite.SQLiteMarshal.NextOffsetOf(offset, 4, global::System.IntPtr.Size);
			offset = global::System.Data.SQLite.SQLiteMarshal.NextOffsetOf(offset, global::System.IntPtr.Size, 4);
			global::System.IntPtr pointer = global::System.Data.SQLite.SQLiteMarshal.ReadIntPtr(pIndex, offset);
			int num2 = global::System.Runtime.InteropServices.Marshal.SizeOf(typeof(global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_index_constraint_usage));
			for (int i = 0; i < num; i++)
			{
				global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_index_constraint_usage sqlite3_index_constraint_usage = new global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_index_constraint_usage(index.Outputs.ConstraintUsages[i]);
				global::System.Runtime.InteropServices.Marshal.StructureToPtr(sqlite3_index_constraint_usage, global::System.Data.SQLite.SQLiteMarshal.IntPtrForOffset(pointer, i * num2), false);
			}
			offset = global::System.Data.SQLite.SQLiteMarshal.NextOffsetOf(offset, global::System.IntPtr.Size, 4);
			global::System.Data.SQLite.SQLiteMarshal.WriteInt32(pIndex, offset, index.Outputs.IndexNumber);
			offset = global::System.Data.SQLite.SQLiteMarshal.NextOffsetOf(offset, 4, global::System.IntPtr.Size);
			global::System.Data.SQLite.SQLiteMarshal.WriteIntPtr(pIndex, offset, global::System.Data.SQLite.SQLiteString.Utf8IntPtrFromString(index.Outputs.IndexString));
			offset = global::System.Data.SQLite.SQLiteMarshal.NextOffsetOf(offset, global::System.IntPtr.Size, 4);
			global::System.Data.SQLite.SQLiteMarshal.WriteInt32(pIndex, offset, 1);
			offset = global::System.Data.SQLite.SQLiteMarshal.NextOffsetOf(offset, 4, 4);
			global::System.Data.SQLite.SQLiteMarshal.WriteInt32(pIndex, offset, index.Outputs.OrderByConsumed);
			offset = global::System.Data.SQLite.SQLiteMarshal.NextOffsetOf(offset, 4, 8);
			global::System.Data.SQLite.SQLiteMarshal.WriteDouble(pIndex, offset, index.Outputs.EstimatedCost.GetValueOrDefault());
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000506 RID: 1286 RVA: 0x00021E74 File Offset: 0x00021274
		public global::System.Data.SQLite.SQLiteIndexInputs Inputs
		{
			get
			{
				return this.inputs;
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000507 RID: 1287 RVA: 0x00021E88 File Offset: 0x00021288
		public global::System.Data.SQLite.SQLiteIndexOutputs Outputs
		{
			get
			{
				return this.outputs;
			}
		}

		// Token: 0x04000211 RID: 529
		internal static readonly double DefaultEstimatedCost = double.MaxValue;

		// Token: 0x04000212 RID: 530
		private global::System.Data.SQLite.SQLiteIndexInputs inputs;

		// Token: 0x04000213 RID: 531
		private global::System.Data.SQLite.SQLiteIndexOutputs outputs;
	}
}
