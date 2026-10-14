using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace custom_controls
{
	// Token: 0x02000093 RID: 147
	public class ListViewTemplate : global::System.Windows.Forms.ListView
	{
		// Token: 0x06000603 RID: 1539 RVA: 0x0005AB1C File Offset: 0x00058D1C
		public ListViewTemplate()
		{
			this.IsLastColumAutoSize = false;
		}

		// Token: 0x06000604 RID: 1540 RVA: 0x0005AB38 File Offset: 0x00058D38
		protected override void Dispose(bool disposing)
		{
			int num = 1;
			for (;;)
			{
				switch (num)
				{
				case 0:
					num = 3;
					continue;
				case 2:
					goto IL_8F;
				case 3:
					if (this.c != null)
					{
						num = 2;
						continue;
					}
					goto IL_91;
				case 4:
					goto IL_72;
				}
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_8F:
					this.c.Dispose();
					num = 4;
					continue;
				}
				if (true)
				{
				}
				if (false)
				{
				}
				if (!disposing)
				{
					break;
				}
				num = 0;
			}
			IL_72:
			IL_91:
			base.Dispose(disposing);
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x06000605 RID: 1541 RVA: 0x0005ABE0 File Offset: 0x00058DE0
		// (set) Token: 0x06000606 RID: 1542 RVA: 0x0005AC24 File Offset: 0x00058E24
		[global::System.ComponentModel.DefaultValue(false)]
		[global::System.ComponentModel.Category("Appearance")]
		[global::System.ComponentModel.Description("Change to the right-to-left layout.")]
		[global::System.ComponentModel.Browsable(true)]
		[global::System.ComponentModel.Localizable(true)]
		public bool Mirrored
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
			set
			{
				int num = 1;
				for (;;)
				{
					switch (num)
					{
					case 0:
						goto IL_39;
					case 2:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_39;
						default:
							goto IL_5E;
						}
						break;
					}
					if (this.d != value)
					{
						num = 0;
						continue;
					}
					goto IL_6E;
					IL_39:
					this.d = value;
					num = 2;
				}
				IL_5E:
				if (true)
				{
				}
				if (false)
				{
				}
				IL_6E:
				base.OnRightToLeftChanged(global::System.EventArgs.Empty);
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x06000607 RID: 1543 RVA: 0x0005ACAC File Offset: 0x00058EAC
		protected override global::System.Windows.Forms.CreateParams CreateParams
		{
			get
			{
				global::System.Windows.Forms.CreateParams createParams;
				for (;;)
				{
					createParams = base.CreateParams;
					int num = 0;
					for (;;)
					{
						switch (num)
						{
						case 0:
							if (!this.Mirrored)
							{
								return createParams;
							}
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								if (false)
								{
								}
								num = 1;
								continue;
							}
							break;
						case 1:
							createParams.ExStyle |= 4194304;
							if (true)
							{
							}
							num = 2;
							continue;
						case 2:
							return createParams;
						}
						break;
					}
				}
				return createParams;
			}
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x0005AD3C File Offset: 0x00058F3C
		protected override void WndProc(ref global::System.Windows.Forms.Message m)
		{
			int num = 7;
			for (;;)
			{
				switch (num)
				{
				case 0:
				{
					int msg;
					if (msg == 15)
					{
						if (true)
						{
						}
						num = 5;
						continue;
					}
					goto IL_108;
				}
				case 1:
					num = 3;
					continue;
				case 2:
					goto IL_DC;
				case 3:
					if (base.Columns.Count > 0)
					{
						num = 2;
						continue;
					}
					goto IL_108;
				case 4:
				{
					int msg = m.Msg;
					num = 0;
					continue;
				}
				case 5:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_DC;
					default:
						if (false)
						{
						}
						num = 8;
						continue;
					}
					break;
				case 6:
					goto IL_106;
				case 8:
					if (base.View == global::System.Windows.Forms.View.Details)
					{
						num = 1;
						continue;
					}
					goto IL_108;
				}
				if (this.IsLastColumAutoSize)
				{
					num = 4;
					continue;
				}
				break;
				IL_DC:
				base.Columns[base.Columns.Count - 1].Width = -2;
				num = 6;
			}
			IL_106:
			IL_108:
			base.WndProc(ref m);
		}

		// Token: 0x040004A4 RID: 1188
		public const int WS_EX_LAYOUTRTL = 4194304;

		// Token: 0x040004A5 RID: 1189
		public const int WS_EX_NOINHERITLAYOUT = 1048576;

		// Token: 0x040004A6 RID: 1190
		private const int a = 15;

		// Token: 0x040004A7 RID: 1191
		private const int b = -2;

		// Token: 0x040004A8 RID: 1192
		private global::System.ComponentModel.Container c;

		// Token: 0x040004A9 RID: 1193
		private bool d;

		// Token: 0x040004AA RID: 1194
		public bool IsLastColumAutoSize;
	}
}
