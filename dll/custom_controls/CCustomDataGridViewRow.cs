using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace custom_controls
{
	// Token: 0x02000025 RID: 37
	[global::System.Serializable]
	public class CCustomDataGridViewRow : global::System.Windows.Forms.DataGridViewRow
	{
		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600011B RID: 283 RVA: 0x0001ABF8 File Offset: 0x00018DF8
		// (set) Token: 0x0600011C RID: 284 RVA: 0x0001AC3C File Offset: 0x00018E3C
		public string ID
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
				return this.ListId;
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
				this.ListId = value;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600011D RID: 285 RVA: 0x0001AC80 File Offset: 0x00018E80
		// (set) Token: 0x0600011E RID: 286 RVA: 0x0001ACC4 File Offset: 0x00018EC4
		public string SubID
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
				return this.ListLetId;
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
				this.ListLetId = value;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600011F RID: 287 RVA: 0x0001AD08 File Offset: 0x00018F08
		// (set) Token: 0x06000120 RID: 288 RVA: 0x0001AD4C File Offset: 0x00018F4C
		public string LetID
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
				return this.LetId;
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
				this.LetId = value;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000121 RID: 289 RVA: 0x0001AD90 File Offset: 0x00018F90
		// (set) Token: 0x06000122 RID: 290 RVA: 0x0001ADD4 File Offset: 0x00018FD4
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
				return this.rowType;
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
				this.rowType = value;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000123 RID: 291 RVA: 0x0001AE18 File Offset: 0x00019018
		// (set) Token: 0x06000124 RID: 292 RVA: 0x0001AE5C File Offset: 0x0001905C
		public global::System.Drawing.Image RowImage
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
				return this.img;
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
				this.img = value;
			}
		}

		// Token: 0x06000125 RID: 293 RVA: 0x0001AEA0 File Offset: 0x000190A0
		public CCustomDataGridViewRow()
		{
			this.ListId = global::System.Convert.ToString("-1", global::System.Globalization.CultureInfo.InvariantCulture);
			this.ListLetId = global::System.Convert.ToString("-1", global::System.Globalization.CultureInfo.InvariantCulture);
			this.LetId = global::System.Convert.ToString("-1", global::System.Globalization.CultureInfo.InvariantCulture);
			this.rowType = string.Empty;
			this.img = null;
		}

		// Token: 0x0400007F RID: 127
		private string ListId;

		// Token: 0x04000080 RID: 128
		private string ListLetId;

		// Token: 0x04000081 RID: 129
		private string rowType;

		// Token: 0x04000082 RID: 130
		private string LetId;

		// Token: 0x04000083 RID: 131
		private global::System.Drawing.Image img;
	}
}
