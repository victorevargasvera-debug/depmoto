using System;
using System.Collections;
using System.Collections.Generic;

namespace Motorola.Common.Communication
{
	// Token: 0x0200000A RID: 10
	public class SrecDataCollection : global::System.Collections.Generic.ICollection<global::Motorola.Common.Communication.SrecData>, global::System.Collections.Generic.IEnumerable<global::Motorola.Common.Communication.SrecData>, global::System.Collections.IEnumerable
	{
		// Token: 0x06000019 RID: 25 RVA: 0x000024D2 File Offset: 0x000006D2
		internal SrecDataCollection()
		{
			this.list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.SrecData>();
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000024E8 File Offset: 0x000006E8
		public void Add(global::Motorola.Common.Communication.SrecData item)
		{
			if (item == null)
			{
				throw new global::System.ArgumentNullException("item");
			}
			this.list.Add(item);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x0000251A File Offset: 0x0000071A
		public void Clear()
		{
			this.list.Clear();
		}

		// Token: 0x0600001C RID: 28 RVA: 0x0000252C File Offset: 0x0000072C
		public bool Contains(global::Motorola.Common.Communication.SrecData item)
		{
			if (item == null)
			{
				throw new global::System.ArgumentNullException("item");
			}
			return this.list.Contains(item);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002561 File Offset: 0x00000761
		public void CopyTo(global::Motorola.Common.Communication.SrecData[] array, int arrayIndex)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600001E RID: 30 RVA: 0x0000256C File Offset: 0x0000076C
		public int Count
		{
			get
			{
				return this.list.Count;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600001F RID: 31 RVA: 0x0000258C File Offset: 0x0000078C
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x000025A0 File Offset: 0x000007A0
		public bool Remove(global::Motorola.Common.Communication.SrecData item)
		{
			if (item == null)
			{
				throw new global::System.ArgumentNullException("item");
			}
			return this.list.Remove(item);
		}

		// Token: 0x17000009 RID: 9
		public global::Motorola.Common.Communication.SrecData this[int index]
		{
			get
			{
				return this.list[index];
			}
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000025F8 File Offset: 0x000007F8
		internal void Insert(int index, global::Motorola.Common.Communication.SrecData item)
		{
			if (item == null)
			{
				throw new global::System.ArgumentNullException("item");
			}
			if (index < 0 || index > this.list.Count)
			{
				throw new global::System.ArgumentOutOfRangeException("index");
			}
			this.list.Insert(index, item);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002654 File Offset: 0x00000854
		public global::System.Collections.Generic.IEnumerator<global::Motorola.Common.Communication.SrecData> GetEnumerator()
		{
			return this.list.GetEnumerator();
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002678 File Offset: 0x00000878
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x0400001D RID: 29
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.SrecData> list;
	}
}
