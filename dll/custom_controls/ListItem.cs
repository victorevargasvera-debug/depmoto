using System;

namespace custom_controls
{
	// Token: 0x02000063 RID: 99
	public struct ListItem
	{
		// Token: 0x06000423 RID: 1059 RVA: 0x00043A2C File Offset: 0x00041C2C
		public ListItem(string valueDisplay, string listId, string listLetId, string valueType)
		{
			this.a = valueDisplay;
			this.b = listId;
			this.c = listLetId;
			this.d = valueType;
			this.e = string.Empty;
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x00043A64 File Offset: 0x00041C64
		public ListItem(string valueDisplay, string listId, string listLetId, string valueType, string tagValue)
		{
			this.a = valueDisplay;
			this.b = listId;
			this.c = listLetId;
			this.d = valueType;
			this.e = tagValue;
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000425 RID: 1061 RVA: 0x00043A98 File Offset: 0x00041C98
		public string Display
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
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000426 RID: 1062 RVA: 0x00043ADC File Offset: 0x00041CDC
		public string Tag
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
				return this.e;
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000427 RID: 1063 RVA: 0x00043B20 File Offset: 0x00041D20
		public string ListID
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
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000428 RID: 1064 RVA: 0x00043B64 File Offset: 0x00041D64
		public string ListLetID
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
				return this.c;
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000429 RID: 1065 RVA: 0x00043BA8 File Offset: 0x00041DA8
		public string Type
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
				return this.d;
			}
		}

		// Token: 0x040002D1 RID: 721
		private string a;

		// Token: 0x040002D2 RID: 722
		private string b;

		// Token: 0x040002D3 RID: 723
		private string c;

		// Token: 0x040002D4 RID: 724
		private string d;

		// Token: 0x040002D5 RID: 725
		private string e;
	}
}
