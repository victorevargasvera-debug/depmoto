using System;
using System.Collections;
using System.Windows.Forms;

namespace custom_controls
{
	// Token: 0x0200008F RID: 143
	public class CListViewSorter : global::System.Collections.IComparer
	{
		// Token: 0x17000123 RID: 291
		// (get) Token: 0x060005EE RID: 1518 RVA: 0x00059848 File Offset: 0x00057A48
		// (set) Token: 0x060005EF RID: 1519 RVA: 0x0005988C File Offset: 0x00057A8C
		public int ByColumn
		{
			get
			{
				switch (1 == 1)
				{
				}
				if (true)
				{
				}
				if (false)
				{
				}
				return this.a;
			}
			set
			{
				switch (1 == 1)
				{
				}
				if (true)
				{
				}
				if (false)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x060005F0 RID: 1520 RVA: 0x000598D0 File Offset: 0x00057AD0
		// (set) Token: 0x060005F1 RID: 1521 RVA: 0x00059914 File Offset: 0x00057B14
		public int LastSort
		{
			get
			{
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				if (true)
				{
				}
				return this.b;
			}
			set
			{
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				if (true)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x060005F2 RID: 1522 RVA: 0x00059958 File Offset: 0x00057B58
		public int Compare(object x, object y)
		{
			switch (0)
			{
			default:
			{
				int num = 3;
				int result;
				for (;;)
				{
					switch (num)
					{
					case 0:
						goto IL_6F;
					case 1:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_8F;
						default:
							goto IL_C2;
						}
						break;
					case 2:
						return 0;
					case 4:
						goto IL_8A;
					case 5:
					{
						if (!(y is global::System.Windows.Forms.ListViewItem))
						{
							num = 1;
							continue;
						}
						global::System.Windows.Forms.ListViewItem listViewItem = y as global::System.Windows.Forms.ListViewItem;
						string text = listViewItem.SubItems[this.ByColumn].Text;
						global::System.Windows.Forms.ListViewItem listViewItem2 = x as global::System.Windows.Forms.ListViewItem;
						string text2 = listViewItem2.SubItems[this.ByColumn].Text;
						num = 7;
						continue;
					}
					case 6:
					{
						string text;
						string text2;
						result = string.Compare(text, text2);
						num = 0;
						continue;
					}
					case 7:
					{
						global::System.Windows.Forms.ListViewItem listViewItem;
						if (listViewItem.ListView.Sorting == global::System.Windows.Forms.SortOrder.Ascending)
						{
							num = 6;
							continue;
						}
						string text;
						string text2;
						result = string.Compare(text2, text);
						num = 4;
						continue;
					}
					}
					if (!(x is global::System.Windows.Forms.ListViewItem))
					{
						num = 2;
						continue;
					}
					IL_8F:
					num = 5;
				}
				return 0;
				IL_6F:
				IL_8A:
				goto IL_13D;
				IL_C2:
				if (true)
				{
				}
				if (false)
				{
				}
				return 0;
				IL_13D:
				this.LastSort = this.ByColumn;
				return result;
			}
			}
		}

		// Token: 0x04000493 RID: 1171
		private int a;

		// Token: 0x04000494 RID: 1172
		private int b;
	}
}
