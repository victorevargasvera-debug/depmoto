using System;

namespace custom_controls
{
	// Token: 0x02000065 RID: 101
	public class CListBoxItem
	{
		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000435 RID: 1077 RVA: 0x0004471C File Offset: 0x0004291C
		// (set) Token: 0x06000436 RID: 1078 RVA: 0x00044760 File Offset: 0x00042960
		public global::custom_controls.ListItem Item
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

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000437 RID: 1079 RVA: 0x000447A4 File Offset: 0x000429A4
		// (set) Token: 0x06000438 RID: 1080 RVA: 0x000447E8 File Offset: 0x000429E8
		public int ImageIndex
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

		// Token: 0x06000439 RID: 1081 RVA: 0x0004482C File Offset: 0x00042A2C
		public CListBoxItem(global::custom_controls.ListItem itemBase, int index)
		{
			this.a = itemBase;
			this.b = index;
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x00044850 File Offset: 0x00042A50
		public override string ToString()
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
			return this.a.Display;
		}

		// Token: 0x040002D9 RID: 729
		private global::custom_controls.ListItem a;

		// Token: 0x040002DA RID: 730
		private int b;
	}
}
