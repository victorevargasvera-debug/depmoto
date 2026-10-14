using System;
using System.Windows.Forms;

namespace custom_controls
{
	// Token: 0x02000069 RID: 105
	public class CMenuItem : global::System.Windows.Forms.MenuItem
	{
		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000451 RID: 1105 RVA: 0x00045988 File Offset: 0x00043B88
		// (set) Token: 0x06000452 RID: 1106 RVA: 0x000459CC File Offset: 0x00043BCC
		public global::System.Windows.Forms.ToolBarButton LinkedToolbarButton
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

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000453 RID: 1107 RVA: 0x00045A10 File Offset: 0x00043C10
		// (set) Token: 0x06000454 RID: 1108 RVA: 0x00045A54 File Offset: 0x00043C54
		public new bool Enabled
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
				return base.Enabled;
			}
			set
			{
				for (;;)
				{
					base.Enabled = value;
					int num = 1;
					for (;;)
					{
						switch (num)
						{
						case 0:
							goto IL_4F;
						case 1:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_4F;
							default:
								if (false)
								{
								}
								if (this.a != null)
								{
									num = 0;
									continue;
								}
								return;
							}
							break;
						case 2:
							return;
						}
						break;
						IL_4F:
						this.a.Enabled = value;
						if (true)
						{
						}
						num = 2;
					}
				}
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06000455 RID: 1109 RVA: 0x00045ADC File Offset: 0x00043CDC
		// (set) Token: 0x06000456 RID: 1110 RVA: 0x00045B20 File Offset: 0x00043D20
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
				return this.b;
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
				this.b = value;
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000457 RID: 1111 RVA: 0x00045B64 File Offset: 0x00043D64
		// (set) Token: 0x06000458 RID: 1112 RVA: 0x00045BA8 File Offset: 0x00043DA8
		public bool CheckBoxMenu
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
				return this.c;
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
				this.c = value;
			}
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x00045BEC File Offset: 0x00043DEC
		public CMenuItem()
		{
			this.b = null;
			this.c = false;
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x00045C10 File Offset: 0x00043E10
		public void EnableItem()
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
			this.Enabled = true;
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x00045C54 File Offset: 0x00043E54
		public void DisableItem()
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
			this.Enabled = false;
		}

		// Token: 0x04000314 RID: 788
		private global::System.Windows.Forms.ToolBarButton a;

		// Token: 0x04000315 RID: 789
		private string b;

		// Token: 0x04000316 RID: 790
		private bool c;
	}
}
