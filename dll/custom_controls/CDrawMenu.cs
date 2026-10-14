using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace custom_controls
{
	// Token: 0x02000067 RID: 103
	public class CDrawMenu
	{
		// Token: 0x06000440 RID: 1088 RVA: 0x00044B50 File Offset: 0x00042D50
		public CDrawMenu(global::System.Windows.Forms.MenuItem mnuItem, global::System.Drawing.Graphics graphics)
		{
			this.o = null;
			this.p = null;
			this.l = global::System.Windows.Forms.SystemInformation.SmallIconSize.Width;
			this.m = global::System.Windows.Forms.SystemInformation.SmallIconSize.Height;
			this.n = global::System.Windows.Forms.SystemInformation.SmallIconSize.Width;
			this.o = mnuItem;
			this.p = graphics;
			this.SetFont();
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x00044BC0 File Offset: 0x00042DC0
		public bool HasShortcut()
		{
			if (this.o.ShowShortcut)
			{
				if (true)
				{
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
					return this.o.Shortcut != global::System.Windows.Forms.Shortcut.None;
				}
			}
			return false;
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x00044C20 File Offset: 0x00042E20
		public bool IsSeperator()
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
			return this.o.Text == "-";
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x00044C70 File Offset: 0x00042E70
		public bool IsTopLevel()
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
			return this.o.Parent is global::System.Windows.Forms.MainMenu;
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000444 RID: 1092 RVA: 0x00044CC0 File Offset: 0x00042EC0
		public string ShortcutText
		{
			get
			{
				int num = 3;
				for (;;)
				{
					switch (num)
					{
					case 0:
						goto IL_C9;
					case 1:
						if (this.o.Shortcut != global::System.Windows.Forms.Shortcut.None)
						{
							if (true)
							{
							}
							num = 0;
							continue;
						}
						goto IL_CE;
					case 2:
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
					}
					if (!this.o.ShowShortcut)
					{
						goto IL_CE;
					}
					num = 2;
				}
				IL_C9:
				global::System.Windows.Forms.Keys shortcut = (global::System.Windows.Forms.Keys)this.o.Shortcut;
				return global::System.Convert.ToChar(global::System.Windows.Forms.Keys.Tab) + global::System.ComponentModel.TypeDescriptor.GetConverter(shortcut.GetType()).ConvertToString(shortcut);
				IL_CE:
				return null;
			}
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x00044D9C File Offset: 0x00042F9C
		public int CalcHeight()
		{
			int num = 3;
			for (;;)
			{
				switch (num)
				{
				case 0:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_55;
					}
					break;
				case 1:
					if (this.q.Height > global::System.Windows.Forms.SystemInformation.SmallIconSize.Height)
					{
						num = 2;
						continue;
					}
					goto IL_AE;
				case 2:
					goto IL_AA;
				}
				if (this.o.Text == "-")
				{
					num = 0;
				}
				else
				{
					if (true)
					{
					}
					num = 1;
				}
			}
			IL_55:
			if (false)
			{
			}
			return 8;
			IL_AA:
			return this.q.Height + 2;
			IL_AE:
			return global::System.Windows.Forms.SystemInformation.SmallIconSize.Height + 2;
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x00044E68 File Offset: 0x00043068
		public int CalcWidth()
		{
			switch (0)
			{
			default:
			{
				if (true)
				{
				}
				global::System.Drawing.StringFormat stringFormat = new global::System.Drawing.StringFormat();
				int result;
				try
				{
					for (;;)
					{
						stringFormat.HotkeyPrefix = global::System.Drawing.Text.HotkeyPrefix.Show;
						int num = (int)this.p.MeasureString(this.o.Text, this.q, 1000, stringFormat).Width;
						int num2 = (int)this.p.MeasureString(this.ShortcutText, this.q, 1000, stringFormat).Width;
						int num3 = 6;
						for (;;)
						{
							switch (num3)
							{
							case 0:
								goto IL_D9;
							case 1:
								result = this.n + num + 20 + num2;
								num3 = 3;
								continue;
							case 2:
								if (this.o.Checked)
								{
									num3 = 1;
									continue;
								}
								result = num + 20 + num2;
								num3 = 4;
								continue;
							case 3:
								goto IL_F8;
							case 4:
								goto IL_137;
							case 5:
								result = num;
								num3 = 0;
								continue;
							case 6:
								if (this.IsTopLevel())
								{
									num3 = 5;
									continue;
								}
								num3 = 2;
								continue;
							}
							break;
						}
					}
					IL_D9:
					IL_F8:
					IL_137:;
				}
				finally
				{
					int num3 = 1;
					for (;;)
					{
						switch (num3)
						{
						case 0:
							goto IL_190;
						case 1:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_181;
							default:
								if (false)
								{
								}
								break;
							}
							break;
						case 2:
							goto IL_181;
						}
						if (stringFormat != null)
						{
							num3 = 2;
							continue;
						}
						break;
						IL_181:
						((global::System.IDisposable)stringFormat).Dispose();
						num3 = 0;
					}
					IL_190:;
				}
				return result;
			}
			}
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x00045028 File Offset: 0x00043228
		public void DrawMenu(global::System.Drawing.Rectangle bounds, bool selected, bool isCheckBoxMenu, global::System.Windows.Forms.ImageList il)
		{
			for (;;)
			{
				this.a(bounds, selected, isCheckBoxMenu);
				if (true)
				{
				}
				int num = 2;
				for (;;)
				{
					switch (num)
					{
					case 0:
						IL_4C:
						this.a(bounds, il, selected);
						num = 1;
						continue;
					case 1:
						goto IL_62;
					case 2:
						if (this.o.Checked)
						{
							num = 0;
							continue;
						}
						goto IL_62;
					}
					break;
					IL_62:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_4C;
					default:
						goto IL_78;
					}
				}
			}
			IL_78:
			if (false)
			{
			}
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x000450B4 File Offset: 0x000432B4
		public void DrawBackground(global::System.Drawing.Rectangle bounds, bool selected)
		{
			if (!selected)
			{
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					if (true)
					{
					}
					if (false)
					{
					}
					this.p.FillRectangle(global::System.Drawing.SystemBrushes.Menu, bounds);
					return;
				}
			}
			this.p.FillRectangle(global::System.Drawing.SystemBrushes.Highlight, bounds);
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x00045118 File Offset: 0x00043318
		public void DrawSeperator(global::System.Drawing.Rectangle bounds)
		{
			switch ((1 == 1) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				if (true)
				{
				}
				if (false)
				{
				}
				switch (0)
				{
				}
				break;
			}
			global::System.Drawing.Pen pen = new global::System.Drawing.Pen(global::System.Drawing.SystemColors.ControlDark);
			try
			{
				int left = bounds.Left;
				int x = left + bounds.Width;
				int num = bounds.Top + bounds.Height / 2;
				this.p.DrawLine(pen, left, num, x, num);
			}
			finally
			{
				int num2 = 2;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						((global::System.IDisposable)pen).Dispose();
						num2 = 1;
						continue;
					case 1:
						goto IL_BA;
					}
					if (pen == null)
					{
						break;
					}
					num2 = 0;
				}
				IL_BA:;
			}
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x000451F4 File Offset: 0x000433F4
		private void a(global::System.Drawing.Rectangle A_0, bool A_1, bool A_2)
		{
			switch (0)
			{
			default:
				for (;;)
				{
					global::System.Drawing.SolidBrush solidBrush = null;
					int num = 12;
					for (;;)
					{
						global::System.Drawing.StringFormat stringFormat;
						global::System.Drawing.StringFormat stringFormat2;
						switch (num)
						{
						case 0:
							return;
						case 1:
							if (this.IsTopLevel())
							{
								num = 14;
								continue;
							}
							goto IL_9C;
						case 2:
							if (true)
							{
							}
							goto IL_9C;
						case 3:
							solidBrush = new global::System.Drawing.SolidBrush(global::System.Drawing.SystemColors.HighlightText);
							num = 9;
							continue;
						case 4:
							try
							{
								for (;;)
								{
									stringFormat.HotkeyPrefix = global::System.Drawing.Text.HotkeyPrefix.Show;
									num = 1;
									for (;;)
									{
										switch (num)
										{
										case 0:
											goto IL_36B;
										case 1:
											if (A_2)
											{
												num = 4;
												continue;
											}
											this.p.DrawString(this.o.Text, this.q, solidBrush, (float)A_0.Left, (float)(A_0.Top + (A_0.Height - this.q.Height) / 2), stringFormat);
											num = 2;
											continue;
										case 2:
											goto IL_36B;
										case 3:
											goto IL_377;
										case 4:
											this.p.DrawString(this.o.Text, this.q, solidBrush, (float)(A_0.Left + this.n), (float)(A_0.Top + (A_0.Height - this.q.Height) / 2), stringFormat);
											num = 0;
											continue;
										}
										break;
										IL_36B:
										num = 3;
									}
								}
								IL_377:
								goto IL_B0;
							}
							finally
							{
								num = 2;
								for (;;)
								{
									switch (num)
									{
									case 0:
										goto IL_3B7;
									case 1:
										((global::System.IDisposable)stringFormat).Dispose();
										num = 0;
										continue;
									}
									if (stringFormat == null)
									{
										break;
									}
									num = 1;
								}
								IL_3B7:;
							}
							return;
							IL_B0:
							num = 1;
							continue;
						case 5:
							if (solidBrush != null)
							{
								num = 7;
								continue;
							}
							return;
						case 6:
							goto IL_258;
						case 7:
							goto IL_1D8;
						case 8:
							goto IL_258;
						case 9:
							goto IL_258;
						case 10:
							if (A_1)
							{
								num = 3;
								continue;
							}
							solidBrush = new global::System.Drawing.SolidBrush(global::System.Drawing.SystemColors.MenuText);
							num = 6;
							continue;
						case 11:
							try
							{
								stringFormat2.HotkeyPrefix = global::System.Drawing.Text.HotkeyPrefix.Show;
								stringFormat2.FormatFlags |= global::System.Drawing.StringFormatFlags.DirectionRightToLeft;
								float width = this.p.MeasureString(this.ShortcutText, this.q, 1000, stringFormat2).Width;
								this.p.DrawString(this.ShortcutText, this.q, solidBrush, (float)(A_0.Width - 15), (float)(A_0.Top + (A_0.Height - this.q.Height) / 2), stringFormat2);
								goto IL_208;
							}
							finally
							{
								num = 0;
								for (;;)
								{
									switch (num)
									{
									case 1:
										goto IL_1D5;
									case 2:
										((global::System.IDisposable)stringFormat2).Dispose();
										num = 1;
										continue;
									}
									if (stringFormat2 == null)
									{
										break;
									}
									num = 2;
								}
								IL_1D5:;
							}
							goto IL_1D8;
						case 12:
							if (!this.o.Enabled)
							{
								num = 15;
								continue;
							}
							num = 10;
							continue;
						case 13:
							if (!this.HasShortcut())
							{
								num = 2;
								continue;
							}
							goto IL_208;
						case 14:
							num = 13;
							continue;
						case 15:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_25E;
							default:
								if (false)
								{
								}
								solidBrush = new global::System.Drawing.SolidBrush(global::System.Drawing.SystemColors.GrayText);
								num = 8;
								continue;
							}
							break;
						}
						break;
						IL_9C:
						stringFormat2 = new global::System.Drawing.StringFormat();
						num = 11;
						continue;
						IL_1D8:
						solidBrush.Dispose();
						num = 0;
						continue;
						IL_208:
						num = 5;
						continue;
						IL_25E:
						num = 4;
						continue;
						IL_258:
						stringFormat = new global::System.Drawing.StringFormat();
						goto IL_25E;
					}
				}
				return;
			}
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x000455D8 File Offset: 0x000437D8
		private void a(global::System.Drawing.Rectangle A_0, global::System.Windows.Forms.ImageList A_1, bool A_2)
		{
			global::System.Drawing.Image a_;
			for (;;)
			{
				a_ = null;
				int num = 4;
				for (;;)
				{
					if (true)
					{
					}
					switch (num)
					{
					case 0:
						if (A_2)
						{
							goto IL_B7;
						}
						a_ = A_1.Images[22];
						num = 2;
						continue;
					case 1:
						goto IL_DD;
					case 2:
						goto IL_70;
					case 3:
						goto IL_A7;
					case 4:
						if (this.o.Checked)
						{
							num = 6;
							continue;
						}
						a_ = A_1.Images[21];
						num = 1;
						continue;
					case 5:
						a_ = A_1.Images[23];
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_B7;
						default:
							if (false)
							{
							}
							num = 3;
							continue;
						}
						break;
					case 6:
						num = 0;
						continue;
					}
					break;
					IL_B7:
					num = 5;
				}
			}
			IL_70:
			IL_A7:
			IL_DD:
			this.a(a_, A_0);
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x000456CC File Offset: 0x000438CC
		private void b(global::System.Drawing.Image A_0, global::System.Drawing.Rectangle A_1)
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
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x00045708 File Offset: 0x00043908
		private void a(global::System.Drawing.Image A_0, global::System.Drawing.Rectangle A_1)
		{
			switch ((1 == 1) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_3B;
			}
			if (true)
			{
			}
			if (false)
			{
			}
			if (!this.o.Enabled)
			{
				global::System.Windows.Forms.ControlPaint.DrawImageDisabled(this.p, A_0, A_1.Left + 1, A_1.Top + (A_1.Height - this.m) / 2, global::System.Drawing.SystemColors.Menu);
				return;
			}
			IL_3B:
			this.p.DrawImage(A_0, A_1.Left + 1, A_1.Top + (A_1.Height - this.m) / 2, this.l, this.m);
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x000457C0 File Offset: 0x000439C0
		protected void SetFont()
		{
			for (;;)
			{
				int num = 3;
				for (;;)
				{
					switch (num)
					{
					case 0:
						if (global::custom_controls.CDrawMenu.FONT_FAMILY.Length > 0)
						{
							num = 2;
							continue;
						}
						goto IL_C3;
					case 1:
						if (0f != global::custom_controls.CDrawMenu.FONT_SIZE)
						{
							num = 4;
							continue;
						}
						goto IL_C3;
					case 2:
						num = 1;
						continue;
					case 4:
						goto IL_80;
					case 5:
						if (true)
						{
						}
						num = 0;
						continue;
					}
					if (global::custom_controls.CDrawMenu.FONT_FAMILY == null)
					{
						goto IL_C3;
					}
					num = 5;
				}
				IL_80:
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_96;
				}
			}
			IL_96:
			if (false)
			{
			}
			this.q = new global::System.Drawing.Font(global::custom_controls.CDrawMenu.FONT_FAMILY, global::custom_controls.CDrawMenu.FONT_SIZE);
			return;
			IL_C3:
			this.q = new global::System.Drawing.Font("Arial Unicode MS", 8f);
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x000458A8 File Offset: 0x00043AA8
		public static void SetFontProperties(string fontFamily, float fontSize)
		{
			int num = 0;
			for (;;)
			{
				switch (num)
				{
				case 1:
					if (fontFamily.Length > 0)
					{
						num = 4;
						continue;
					}
					return;
				case 2:
					num = 1;
					continue;
				case 3:
					global::custom_controls.CDrawMenu.FONT_FAMILY = fontFamily;
					global::custom_controls.CDrawMenu.FONT_SIZE = fontSize;
					num = 5;
					continue;
				case 4:
					num = 6;
					continue;
				case 5:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_88;
					default:
						goto IL_66;
					}
					break;
				case 6:
					goto IL_88;
				}
				if (fontFamily != null)
				{
					num = 2;
					continue;
				}
				return;
				IL_88:
				if (0f == fontSize)
				{
					return;
				}
				num = 3;
			}
			IL_66:
			if (true)
			{
			}
			if (false)
			{
			}
		}

		// Token: 0x040002DC RID: 732
		private const int a = 8;

		// Token: 0x040002DD RID: 733
		private const int b = 1;

		// Token: 0x040002DE RID: 734
		private const int c = 2;

		// Token: 0x040002DF RID: 735
		private const int d = 15;

		// Token: 0x040002E0 RID: 736
		private const int e = 20;

		// Token: 0x040002E1 RID: 737
		private const int f = 15;

		// Token: 0x040002E2 RID: 738
		private const int g = 21;

		// Token: 0x040002E3 RID: 739
		private const int h = 22;

		// Token: 0x040002E4 RID: 740
		private const int i = 23;

		// Token: 0x040002E5 RID: 741
		private const string j = "Arial Unicode MS";

		// Token: 0x040002E6 RID: 742
		private const float k = 8f;

		// Token: 0x040002E7 RID: 743
		private int l;

		// Token: 0x040002E8 RID: 744
		private int m;

		// Token: 0x040002E9 RID: 745
		private int n;

		// Token: 0x040002EA RID: 746
		private global::System.Windows.Forms.MenuItem o;

		// Token: 0x040002EB RID: 747
		private global::System.Drawing.Graphics p;

		// Token: 0x040002EC RID: 748
		private global::System.Drawing.Font q;

		// Token: 0x040002ED RID: 749
		public static string FONT_FAMILY;

		// Token: 0x040002EE RID: 750
		public static float FONT_SIZE;
	}
}
