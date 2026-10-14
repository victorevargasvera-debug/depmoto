using System;
using System.Collections;
using System.Windows.Forms;

namespace mototrbodepottool
{
	// Token: 0x0200000E RID: 14
	public class b : global::System.Collections.IComparer
	{
		// Token: 0x06000093 RID: 147 RVA: 0x00015AF0 File Offset: 0x00014AF0
		public b()
		{
			this.a = 0;
			this.b = global::System.Windows.Forms.SortOrder.None;
			this.c = new global::System.Collections.CaseInsensitiveComparer();
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00015B1C File Offset: 0x00014B1C
		public int a(object A_0, object A_1)
		{
			switch (0)
			{
			default:
			{
				int num;
				for (;;)
				{
					global::System.Windows.Forms.ListViewItem listViewItem = (global::System.Windows.Forms.ListViewItem)A_0;
					global::System.Windows.Forms.ListViewItem listViewItem2 = (global::System.Windows.Forms.ListViewItem)A_1;
					num = this.c.Compare(listViewItem.SubItems[this.a].Text, listViewItem2.SubItems[this.a].Text);
					string text = listViewItem.SubItems[this.a].Text;
					string text2 = listViewItem2.SubItems[this.a].Text;
					int num2;
					bool flag = int.TryParse(text, out num2);
					int num3 = 13;
					for (;;)
					{
						switch (num3)
						{
						case 0:
							if (text.Length > text2.Length)
							{
								num3 = 3;
								continue;
							}
							text = "0" + text;
							num3 = 9;
							continue;
						case 1:
							if (global::System.Math.Abs(text.Length - text2.Length) == 0)
							{
								num3 = 8;
								continue;
							}
							num3 = 0;
							continue;
						case 2:
							goto IL_F0;
						case 3:
							text2 = "0" + text2;
							num3 = 12;
							continue;
						case 4:
							goto IL_1E2;
						case 5:
							if (this.b == global::System.Windows.Forms.SortOrder.Ascending)
							{
								num3 = 11;
								continue;
							}
							num3 = 6;
							continue;
						case 6:
							if (this.b == global::System.Windows.Forms.SortOrder.Descending)
							{
								num3 = 7;
								continue;
							}
							return 0;
						case 7:
							goto IL_173;
						case 8:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_F0;
							default:
								if (false)
								{
								}
								num = this.c.Compare(text, text2);
								num3 = 10;
								continue;
							}
							break;
						case 9:
							goto IL_1E2;
						case 10:
							if (true)
							{
							}
							goto IL_183;
						case 11:
							return num;
						case 12:
							goto IL_1E2;
						case 13:
							if (flag)
							{
								num3 = 2;
								continue;
							}
							goto IL_183;
						}
						break;
						IL_F0:
						num3 = 4;
						continue;
						IL_183:
						num3 = 5;
						continue;
						IL_1E2:
						num3 = 1;
					}
				}
				IL_173:
				return -num;
			}
			}
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00015D60 File Offset: 0x00014D60
		public void a(int A_0)
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
			this.a = A_0;
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00015DA4 File Offset: 0x00014DA4
		public int a()
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
			return this.a;
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00015DE8 File Offset: 0x00014DE8
		public void a(global::System.Windows.Forms.SortOrder A_0)
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
			this.b = A_0;
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00015E2C File Offset: 0x00014E2C
		public global::System.Windows.Forms.SortOrder b()
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
			return this.b;
		}

		// Token: 0x04000208 RID: 520
		private int a;

		// Token: 0x04000209 RID: 521
		private global::System.Windows.Forms.SortOrder b;

		// Token: 0x0400020A RID: 522
		private global::System.Collections.CaseInsensitiveComparer c;
	}
}
