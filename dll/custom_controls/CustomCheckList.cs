using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using common;

namespace custom_controls
{
	// Token: 0x0200000A RID: 10
	public class CustomCheckList : global::System.Windows.Forms.ListView
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000027 RID: 39 RVA: 0x00005F7C File Offset: 0x0000417C
		// (remove) Token: 0x06000028 RID: 40 RVA: 0x00006010 File Offset: 0x00004210
		public event global::custom_controls.CustomCheckList.ColumnStateEvent ColumnStateChanged
		{
			add
			{
				for (;;)
				{
					global::custom_controls.CustomCheckList.ColumnStateEvent columnStateEvent = this.h;
					if (true)
					{
					}
					int num = 0;
					for (;;)
					{
						global::custom_controls.CustomCheckList.ColumnStateEvent columnStateEvent2;
						switch (num)
						{
						case 0:
							goto IL_37;
						case 1:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								return;
							default:
								if (false)
								{
								}
								if (columnStateEvent == columnStateEvent2)
								{
									num = 2;
									continue;
								}
								goto IL_37;
							}
							break;
						case 2:
							return;
						}
						break;
						IL_37:
						columnStateEvent2 = columnStateEvent;
						global::custom_controls.CustomCheckList.ColumnStateEvent value2 = (global::custom_controls.CustomCheckList.ColumnStateEvent)global::System.Delegate.Combine(columnStateEvent2, value);
						columnStateEvent = global::System.Threading.Interlocked.CompareExchange<global::custom_controls.CustomCheckList.ColumnStateEvent>(ref this.h, value2, columnStateEvent2);
						num = 1;
					}
				}
			}
			remove
			{
				int num;
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_70:
					num = 0;
					break;
				default:
					if (false)
					{
					}
					goto IL_42;
				}
				global::custom_controls.CustomCheckList.ColumnStateEvent columnStateEvent;
				global::custom_controls.CustomCheckList.ColumnStateEvent columnStateEvent2;
				for (;;)
				{
					IL_28:
					if (true)
					{
					}
					switch (num)
					{
					case 0:
						if (columnStateEvent == columnStateEvent2)
						{
							num = 2;
							continue;
						}
						goto IL_53;
					case 1:
						goto IL_51;
					case 2:
						return;
					}
					goto IL_42;
				}
				IL_51:
				IL_53:
				columnStateEvent2 = columnStateEvent;
				global::custom_controls.CustomCheckList.ColumnStateEvent value2 = (global::custom_controls.CustomCheckList.ColumnStateEvent)global::System.Delegate.Remove(columnStateEvent2, value);
				columnStateEvent = global::System.Threading.Interlocked.CompareExchange<global::custom_controls.CustomCheckList.ColumnStateEvent>(ref this.h, value2, columnStateEvent2);
				goto IL_70;
				IL_42:
				columnStateEvent = this.h;
				num = 1;
				goto IL_28;
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000060A4 File Offset: 0x000042A4
		public CustomCheckList()
		{
			this.a();
			this.BackColor = global::System.Drawing.SystemColors.Control;
			base.Scrollable = false;
			base.OwnerDraw = true;
			base.View = global::System.Windows.Forms.View.Details;
			base.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			base.EnabledChanged -= this.a;
			base.EnabledChanged += this.a;
			this.g = 0;
			this.f = -1;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00006120 File Offset: 0x00004320
		protected override void Dispose(bool disposing)
		{
			for (;;)
			{
				IL_00:
				int num = 3;
				for (;;)
				{
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_00;
					default:
						if (false)
						{
						}
						switch (num)
						{
						case 0:
							num = 1;
							continue;
						case 1:
							if (true)
							{
							}
							if (this.b != null)
							{
								num = 2;
								continue;
							}
							goto IL_91;
						case 2:
							this.b.Dispose();
							num = 4;
							continue;
						case 4:
							goto IL_6A;
						}
						if (!disposing)
						{
							goto IL_91;
						}
						num = 0;
						break;
					}
				}
			}
			IL_6A:
			IL_91:
			base.Dispose(disposing);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000061C8 File Offset: 0x000043C8
		private void a()
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
			this.b = new global::System.ComponentModel.Container();
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600002C RID: 44 RVA: 0x00006210 File Offset: 0x00004410
		// (set) Token: 0x0600002D RID: 45 RVA: 0x00006254 File Offset: 0x00004454
		public int ColumnSize
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
				return this.g;
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
				this.g = value;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600002E RID: 46 RVA: 0x00006298 File Offset: 0x00004498
		// (set) Token: 0x0600002F RID: 47 RVA: 0x000062DC File Offset: 0x000044DC
		public bool LockColumnSize
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
				switch (1 == 1)
				{
				}
				if (true)
				{
				}
				if (false)
				{
				}
				this.d = value;
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00006320 File Offset: 0x00004520
		protected override void OnCreateControl()
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
			base.OnCreateControl();
			this.c = new global::custom_controls.CustomCheckList.b(this);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00006370 File Offset: 0x00004570
		protected override void OnGotFocus(global::System.EventArgs e)
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
			base.OnGotFocus(e);
			this.f = 0;
			this.Refresh();
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000063C0 File Offset: 0x000045C0
		protected override void OnLostFocus(global::System.EventArgs e)
		{
			if (true)
			{
			}
			switch (1 == 1)
			{
			}
			if (false)
			{
			}
			base.OnGotFocus(e);
			this.f = -1;
			this.Refresh();
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00006410 File Offset: 0x00004610
		private void a(object A_0, global::System.EventArgs A_1)
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
			this.Refresh();
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00006454 File Offset: 0x00004654
		protected override void OnKeyDown(global::System.Windows.Forms.KeyEventArgs e)
		{
			switch (0)
			{
			default:
			{
				int num = 20;
				for (;;)
				{
					bool flag;
					global::System.Windows.Forms.Keys keyCode;
					switch (num)
					{
					case 0:
						goto IL_2EF;
					case 1:
						goto IL_31E;
					case 2:
						this.e[this.f] = ((this.e[this.f] == 0) ? 1 : 0);
						flag = true;
						num = 0;
						continue;
					case 3:
						goto IL_2EF;
					case 4:
						if (flag)
						{
							num = 18;
							continue;
						}
						goto IL_320;
					case 5:
						switch (keyCode)
						{
						case global::System.Windows.Forms.Keys.Space:
							num = 22;
							continue;
						case global::System.Windows.Forms.Keys.Prior:
						case global::System.Windows.Forms.Keys.Next:
							goto IL_2EF;
						case global::System.Windows.Forms.Keys.End:
							this.f = base.Columns.Count - 1;
							flag = true;
							num = 6;
							continue;
						case global::System.Windows.Forms.Keys.Home:
							this.f = 0;
							flag = true;
							num = 3;
							continue;
						case global::System.Windows.Forms.Keys.Left:
						case global::System.Windows.Forms.Keys.Up:
							num = 16;
							continue;
						case global::System.Windows.Forms.Keys.Right:
						case global::System.Windows.Forms.Keys.Down:
							goto IL_18F;
						default:
							if (true)
							{
							}
							num = 14;
							continue;
						}
						break;
					case 6:
						goto IL_2EF;
					case 7:
						num = 2;
						continue;
					case 8:
						if (e.Modifiers == global::System.Windows.Forms.Keys.Control)
						{
							num = 19;
							continue;
						}
						goto IL_E6;
					case 9:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_18F;
						default:
							if (false)
							{
							}
							num = 17;
							continue;
						}
						break;
					case 10:
						this.f = ((this.f < base.Columns.Count - 1) ? (++this.f) : this.f);
						flag = true;
						num = 12;
						continue;
					case 11:
						goto IL_DC;
					case 12:
						goto IL_2EF;
					case 13:
						goto IL_2EF;
					case 14:
						num = 13;
						continue;
					case 15:
						goto IL_2EF;
					case 16:
						this.f = ((this.f > 0) ? (--this.f) : this.f);
						flag = true;
						num = 15;
						continue;
					case 17:
						if (base.Columns.Count >= 0)
						{
							num = 7;
							continue;
						}
						goto IL_2EF;
					case 18:
						this.Refresh();
						num = 1;
						continue;
					case 19:
						num = 21;
						continue;
					case 21:
						if (this.d)
						{
							num = 11;
							continue;
						}
						goto IL_E6;
					case 22:
						if (this.f < base.Columns.Count)
						{
							num = 9;
							continue;
						}
						goto IL_2EF;
					case 23:
						num = 8;
						continue;
					}
					if (e.KeyValue == 107)
					{
						num = 23;
						continue;
					}
					IL_E6:
					flag = false;
					keyCode = e.KeyCode;
					num = 5;
					continue;
					IL_18F:
					num = 10;
					continue;
					IL_2EF:
					num = 4;
				}
				IL_DC:
				e.Handled = true;
				return;
				IL_31E:
				IL_320:
				base.OnKeyDown(e);
				return;
			}
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00006788 File Offset: 0x00004988
		protected override void OnDrawColumnHeader(global::System.Windows.Forms.DrawListViewColumnHeaderEventArgs e)
		{
			switch (0)
			{
			default:
			{
				int num;
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_138:
					num = 3;
					break;
				default:
					if (false)
					{
					}
					goto IL_57;
				}
				global::System.Drawing.Graphics graphics;
				global::System.Drawing.Rectangle bounds;
				global::System.Drawing.Color a_;
				global::System.Drawing.Color grayText;
				global::System.Drawing.Color white;
				for (;;)
				{
					IL_2C:
					switch (num)
					{
					case 0:
						goto IL_B1;
					case 1:
						return;
					case 2:
						if (!base.Enabled)
						{
							num = 4;
							continue;
						}
						goto IL_B1;
					case 3:
						global::System.Windows.Forms.ControlPaint.DrawFocusRectangle(graphics, bounds);
						num = 1;
						continue;
					case 4:
						a_ = global::System.Drawing.SystemColors.GrayText;
						num = 0;
						continue;
					case 5:
						if (this.e[e.ColumnIndex] == 1)
						{
							if (true)
							{
							}
							num = 7;
							continue;
						}
						goto IL_191;
					case 6:
						goto IL_191;
					case 7:
						a_ = global::System.Drawing.Color.FromArgb(0, 170, 240);
						num = 6;
						continue;
					case 8:
						goto IL_127;
					}
					goto IL_57;
					IL_B1:
					this.a(graphics, bounds, a_, grayText, white, 0.35f, true, global::System.Drawing.Drawing2D.LinearGradientMode.Vertical);
					global::System.Windows.Forms.TextFormatFlags formatFlags = this.GetFormatFlags(e.Header.TextAlign);
					global::System.Drawing.Rectangle bounds2 = new global::System.Drawing.Rectangle(bounds.X, bounds.Y, bounds.Width, bounds.Height);
					global::System.Windows.Forms.TextRenderer.DrawText(graphics, e.Header.Text, e.Font, bounds2, e.ForeColor, formatFlags);
					num = 8;
					continue;
					IL_191:
					num = 2;
				}
				IL_127:
				if (e.ColumnIndex == this.f)
				{
					goto IL_138;
				}
				return;
				IL_57:
				base.OnDrawColumnHeader(e);
				graphics = e.Graphics;
				bounds = e.Bounds;
				a_ = global::System.Drawing.SystemColors.Control;
				grayText = global::System.Drawing.SystemColors.GrayText;
				white = global::System.Drawing.Color.White;
				num = 5;
				goto IL_2C;
			}
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00006958 File Offset: 0x00004B58
		protected global::System.Windows.Forms.TextFormatFlags GetFormatFlags(global::System.Windows.Forms.HorizontalAlignment align)
		{
			global::System.Windows.Forms.TextFormatFlags textFormatFlags;
			for (;;)
			{
				textFormatFlags = (global::System.Windows.Forms.TextFormatFlags.EndEllipsis | global::System.Windows.Forms.TextFormatFlags.VerticalCenter);
				int num = 3;
				for (;;)
				{
					switch (num)
					{
					case 0:
						return textFormatFlags;
					case 1:
						if (true)
						{
						}
						goto IL_9C;
					case 2:
						return textFormatFlags;
					case 3:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_9C;
						default:
							if (false)
							{
							}
							switch (align)
							{
							case global::System.Windows.Forms.HorizontalAlignment.Left:
								textFormatFlags = textFormatFlags;
								num = 0;
								continue;
							case global::System.Windows.Forms.HorizontalAlignment.Right:
								textFormatFlags |= global::System.Windows.Forms.TextFormatFlags.Right;
								num = 4;
								continue;
							case global::System.Windows.Forms.HorizontalAlignment.Center:
								textFormatFlags |= global::System.Windows.Forms.TextFormatFlags.HorizontalCenter;
								num = 2;
								continue;
							default:
								num = 1;
								continue;
							}
							break;
						}
						break;
					case 4:
						return textFormatFlags;
					case 5:
						return textFormatFlags;
					}
					break;
					IL_9C:
					num = 5;
				}
			}
			return textFormatFlags;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00006A20 File Offset: 0x00004C20
		internal void a(global::System.Drawing.Graphics A_0, global::System.Drawing.Rectangle A_1, global::System.Drawing.Color A_2, global::System.Drawing.Color A_3, global::System.Drawing.Color A_4, float A_5, bool A_6, global::System.Drawing.Drawing2D.LinearGradientMode A_7)
		{
			switch (0)
			{
			default:
				for (;;)
				{
					IL_0E:
					int num = 9;
					for (;;)
					{
						if (true)
						{
						}
						global::System.Drawing.Rectangle rect;
						global::System.Drawing.Pen pen2;
						global::System.Drawing.Drawing2D.LinearGradientBrush linearGradientBrush;
						global::System.Drawing.SolidBrush solidBrush;
						switch (num)
						{
						case 0:
							goto IL_19E;
						case 1:
							try
							{
								global::System.Drawing.Pen pen;
								A_0.DrawRectangle(pen, A_1);
								goto IL_E8;
							}
							finally
							{
								num = 1;
								for (;;)
								{
									global::System.Drawing.Pen pen;
									switch (num)
									{
									case 0:
										goto IL_3E0;
									case 2:
										((global::System.IDisposable)pen).Dispose();
										num = 0;
										continue;
									}
									if (pen == null)
									{
										break;
									}
									num = 2;
								}
								IL_3E0:;
							}
							return;
						case 2:
							rect.Height = (int)((float)rect.Height * A_5);
							num = 0;
							continue;
						case 3:
							try
							{
								A_0.DrawRectangle(pen2, A_1);
								return;
							}
							finally
							{
								num = 1;
								for (;;)
								{
									switch (num)
									{
									case 0:
										goto IL_19B;
									case 2:
										((global::System.IDisposable)pen2).Dispose();
										num = 0;
										continue;
									}
									if (pen2 == null)
									{
										break;
									}
									num = 2;
								}
								IL_19B:;
							}
							goto IL_19E;
						case 4:
							if (A_7 == global::System.Drawing.Drawing2D.LinearGradientMode.Vertical)
							{
								num = 2;
								continue;
							}
							rect.Width = (int)((float)A_1.Width * A_5);
							num = 10;
							continue;
						case 5:
							try
							{
								global::System.Drawing.Color[] colors = new global::System.Drawing.Color[]
								{
									this.a(A_2, 0, 35, 24, 9),
									this.a(A_2, 0, 13, 8, 3),
									A_2,
									this.a(A_2, 0, 68, 69, 54)
								};
								linearGradientBrush.InterpolationColors = new global::System.Drawing.Drawing2D.ColorBlend
								{
									Positions = new float[]
									{
										0f,
										A_5,
										A_5 + 0.05f,
										1f
									},
									Colors = colors
								};
								A_0.FillRectangle(linearGradientBrush, A_1);
								goto IL_1CC;
							}
							finally
							{
								num = 2;
								for (;;)
								{
									switch (num)
									{
									case 0:
										goto IL_34A;
									case 1:
										((global::System.IDisposable)linearGradientBrush).Dispose();
										num = 0;
										continue;
									}
									if (linearGradientBrush == null)
									{
										break;
									}
									num = 1;
								}
								IL_34A:;
							}
							goto IL_34D;
							IL_1CC:
							num = 13;
							continue;
						case 6:
							goto IL_108;
						case 7:
							try
							{
								A_0.FillRectangle(solidBrush, rect);
								goto IL_12C;
							}
							finally
							{
								num = 0;
								for (;;)
								{
									switch (num)
									{
									case 1:
										goto IL_E5;
									case 2:
										((global::System.IDisposable)solidBrush).Dispose();
										num = 1;
										continue;
									}
									if (solidBrush == null)
									{
										break;
									}
									num = 2;
								}
								IL_E5:;
							}
							goto IL_E8;
						case 8:
							if (A_6)
							{
								num = 14;
								continue;
							}
							return;
						case 10:
							goto IL_19E;
						case 11:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_0E;
							default:
								if (false)
								{
								}
								A_1.Width--;
								A_1.Height--;
								num = 6;
								continue;
							}
							break;
						case 12:
							goto IL_34D;
						case 13:
							if (A_2.A > 80)
							{
								num = 12;
								continue;
							}
							goto IL_12C;
						case 14:
						{
							global::System.Drawing.Pen pen = new global::System.Drawing.Pen(A_3);
							num = 1;
							continue;
						}
						}
						if (A_6)
						{
							num = 11;
							continue;
						}
						goto IL_108;
						IL_E8:
						A_1.Inflate(-1, -1);
						pen2 = new global::System.Drawing.Pen(A_4);
						num = 3;
						continue;
						IL_108:
						linearGradientBrush = new global::System.Drawing.Drawing2D.LinearGradientBrush(A_1, global::System.Drawing.Color.Transparent, global::System.Drawing.Color.Transparent, A_7);
						num = 5;
						continue;
						IL_12C:
						num = 8;
						continue;
						IL_19E:
						solidBrush = new global::System.Drawing.SolidBrush(global::System.Drawing.Color.FromArgb(80, 255, 255, 255));
						num = 7;
						continue;
						IL_34D:
						rect = A_1;
						num = 4;
					}
				}
				return;
			}
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00006E44 File Offset: 0x00005044
		private global::System.Drawing.Color a(global::System.Drawing.Color A_0, int A_1, int A_2, int A_3, int A_4)
		{
			switch (0)
			{
			default:
				for (;;)
				{
					int num = (int)A_0.A;
					int r = (int)A_0.R;
					int num2 = (int)A_0.G;
					int num3 = (int)A_0.B;
					int num4 = 5;
					for (;;)
					{
						switch (num4)
						{
						case 0:
							goto IL_167;
						case 1:
							A_2 = 255;
							num4 = 15;
							continue;
						case 2:
							if (A_2 + r > 255)
							{
								if (true)
								{
								}
								num4 = 1;
								continue;
							}
							A_2 += r;
							num4 = 10;
							continue;
						case 3:
							goto IL_17F;
						case 4:
							goto IL_116;
						case 5:
							if (A_1 + num <= 255)
							{
								A_1 += num;
								num4 = 8;
								continue;
							}
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_13C;
							default:
								if (false)
								{
								}
								num4 = 12;
								continue;
							}
							break;
						case 6:
							if (A_3 + num2 > 255)
							{
								num4 = 13;
								continue;
							}
							A_3 += num2;
							num4 = 7;
							continue;
						case 7:
							goto IL_130;
						case 8:
							goto IL_17F;
						case 9:
							A_4 = 255;
							num4 = 4;
							continue;
						case 10:
							goto IL_C8;
						case 11:
							goto IL_13C;
						case 12:
							A_1 = 255;
							num4 = 3;
							continue;
						case 13:
							A_3 = 255;
							num4 = 14;
							continue;
						case 14:
							goto IL_130;
						case 15:
							goto IL_C8;
						}
						break;
						IL_C8:
						num4 = 6;
						continue;
						IL_130:
						num4 = 11;
						continue;
						IL_13C:
						if (A_4 + num3 > 255)
						{
							num4 = 9;
							continue;
						}
						A_4 += num3;
						num4 = 0;
						continue;
						IL_17F:
						num4 = 2;
					}
				}
				IL_116:
				IL_167:
				return global::System.Drawing.Color.FromArgb(A_1, A_2, A_3, A_4);
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00007044 File Offset: 0x00005244
		protected override void OnColumnClick(global::System.Windows.Forms.ColumnClickEventArgs e)
		{
			int num;
			switch ((1 == 1) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_B6:
				num = 1;
				break;
			case 1:
				goto IL_20;
			default:
				goto IL_20;
			}
			for (;;)
			{
				IL_28:
				switch (num)
				{
				case 0:
					goto IL_8E;
				case 1:
					this.h(this, new global::System.EventArgs());
					num = 0;
					continue;
				case 2:
					this.e[e.Column] = ((this.e[e.Column] == 0) ? 1 : 0);
					this.f = e.Column;
					this.Refresh();
					num = 3;
					continue;
				case 3:
					goto IL_AE;
				}
				goto IL_3E;
			}
			IL_8E:
			return;
			IL_AE:
			if (this.h != null)
			{
				goto IL_B6;
			}
			return;
			IL_20:
			if (false)
			{
			}
			IL_3E:
			base.OnColumnClick(e);
			if (true)
			{
			}
			num = 2;
			goto IL_28;
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00007118 File Offset: 0x00005318
		protected override void WndProc(ref global::System.Windows.Forms.Message message)
		{
			switch (0)
			{
			default:
				for (;;)
				{
					bool flag = true;
					int msg = message.Msg;
					int num = 1;
					for (;;)
					{
						switch (num)
						{
						case 0:
						{
							int num2;
							if (num2 == -306)
							{
								num = 6;
								continue;
							}
							goto IL_69;
						}
						case 1:
							if (msg == 78)
							{
								num = 8;
								continue;
							}
							goto IL_69;
						case 2:
							if (flag)
							{
								num = 11;
								continue;
							}
							goto IL_167;
						case 3:
							goto IL_69;
						case 4:
							if (this.d)
							{
								num = 10;
								continue;
							}
							goto IL_69;
						case 5:
							goto IL_11E;
						case 6:
							goto IL_83;
						case 7:
							num = 0;
							continue;
						case 8:
						{
							int num2 = ((global::custom_controls.CustomCheckList.c)message.GetLParam(typeof(global::custom_controls.CustomCheckList.c))).c;
							num = 9;
							continue;
						}
						case 9:
						{
							int num2;
							if (num2 != -326)
							{
								num = 7;
								continue;
							}
							goto IL_83;
						}
						case 10:
							message.Result = (global::System.IntPtr)1;
							flag = false;
							num = 3;
							continue;
						case 11:
							for (;;)
							{
								base.WndProc(ref message);
								switch ((1 == 1) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									goto IL_10C;
								}
							}
							IL_10C:
							if (false)
							{
							}
							num = 5;
							continue;
						}
						break;
						IL_69:
						num = 2;
						continue;
						IL_83:
						num = 4;
					}
				}
				IL_11E:
				IL_167:
				if (true)
				{
				}
				return;
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00007294 File Offset: 0x00005494
		public void SetColumn(int iStart, int iCount)
		{
			int num = 5;
			for (;;)
			{
				switch (num)
				{
				case 0:
					base.Height -= 2;
					num = 3;
					continue;
				case 1:
					goto IL_45;
				case 2:
				{
					this.g = iCount;
					this.e = new byte[iCount];
					base.Items.Clear();
					base.Columns.Clear();
					base.Height = 22;
					int height = global::common.a.a(this, base.Height, true);
					base.Height = height;
					base.Width = base.Height * iCount;
					int num2 = iStart;
					num = 1;
					continue;
				}
				case 3:
					return;
				case 4:
				{
					int num2;
					if (num2 < iCount + iStart)
					{
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							if (false)
							{
							}
							base.Columns.Add(num2.ToString(global::System.Globalization.NumberFormatInfo.InvariantInfo), base.Height, global::System.Windows.Forms.HorizontalAlignment.Center);
							num2++;
							num = 6;
							continue;
						}
					}
					num = 0;
					continue;
				}
				case 6:
					goto IL_45;
				}
				if (true)
				{
				}
				if (iCount > 0)
				{
					num = 2;
					continue;
				}
				break;
				IL_45:
				num = 4;
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x000073D8 File Offset: 0x000055D8
		public int GetColumnsCount()
		{
			if (base.Columns != null)
			{
				for (;;)
				{
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_20;
					}
				}
				IL_20:
				if (true)
				{
				}
				if (false)
				{
				}
				return base.Columns.Count;
			}
			return 0;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x0000742C File Offset: 0x0000562C
		public void SetColState(int iCol, int iState)
		{
			int num = 3;
			for (;;)
			{
				switch (num)
				{
				case 0:
					if (iCol < this.e.Length)
					{
						num = 1;
						continue;
					}
					return;
				case 1:
					num = 2;
					continue;
				case 2:
					this.e[iCol] = ((iState > 0) ? 1 : 0);
					if (true)
					{
					}
					num = 5;
					continue;
				case 4:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_45;
					default:
						if (false)
						{
						}
						num = 0;
						continue;
					}
					break;
				case 5:
					return;
				case 6:
					goto IL_45;
				case 7:
					if (iCol >= 0)
					{
						num = 4;
						continue;
					}
					return;
				}
				if (this.e != null)
				{
					num = 6;
					continue;
				}
				break;
				IL_45:
				num = 7;
			}
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00007514 File Offset: 0x00005714
		public int GetColState(int iCol)
		{
			int num = 2;
			for (;;)
			{
				switch (num)
				{
				case 0:
					if (iCol < this.e.Length)
					{
						num = 1;
						continue;
					}
					return 0;
				case 1:
					goto IL_80;
				case 2:
					if (true)
					{
					}
					break;
				case 3:
					num = 0;
					continue;
				}
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				}
				if (false)
				{
				}
				if (iCol < 0)
				{
					return 0;
				}
				num = 3;
			}
			IL_80:
			return (int)this.e[iCol];
		}

		// Token: 0x04000038 RID: 56
		private const int a = 22;

		// Token: 0x04000039 RID: 57
		private global::System.ComponentModel.IContainer b;

		// Token: 0x0400003A RID: 58
		private global::custom_controls.CustomCheckList.b c;

		// Token: 0x0400003B RID: 59
		private bool d = true;

		// Token: 0x0400003C RID: 60
		private byte[] e;

		// Token: 0x0400003D RID: 61
		private int f;

		// Token: 0x0400003E RID: 62
		private int g;

		// Token: 0x0400003F RID: 63
		private global::custom_controls.CustomCheckList.ColumnStateEvent h;

		// Token: 0x0200000B RID: 11
		// (Invoke) Token: 0x06000040 RID: 64
		public delegate void ColumnStateEvent(object sender, global::System.EventArgs e);

		// Token: 0x0200000C RID: 12
		private struct c
		{
			// Token: 0x04000040 RID: 64
			public global::System.IntPtr a;

			// Token: 0x04000041 RID: 65
			public int b;

			// Token: 0x04000042 RID: 66
			public int c;
		}

		// Token: 0x0200000D RID: 13
		private class b : global::System.Windows.Forms.NativeWindow
		{
			// Token: 0x06000043 RID: 67 RVA: 0x000075A4 File Offset: 0x000057A4
			public b(global::custom_controls.CustomCheckList A_0)
			{
				this.a = A_0;
				global::System.IntPtr handle = global::custom_controls.CustomCheckList.a.SendMessage(A_0.Handle, 4127, global::System.IntPtr.Zero, global::System.IntPtr.Zero);
				base.AssignHandle(handle);
			}

			// Token: 0x06000044 RID: 68 RVA: 0x000075E0 File Offset: 0x000057E0
			protected virtual void a(ref global::System.Windows.Forms.Message A_0)
			{
				for (;;)
				{
					bool flag = true;
					int msg = A_0.Msg;
					int num = 3;
					for (;;)
					{
						switch (num)
						{
						case 0:
							base.WndProc(ref A_0);
							num = 6;
							continue;
						case 1:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_C7;
							default:
								if (false)
								{
								}
								A_0.Result = (global::System.IntPtr)1;
								flag = false;
								num = 5;
								continue;
							}
							break;
						case 2:
							goto IL_E8;
						case 3:
							if (msg != 32)
							{
								num = 8;
								continue;
							}
							goto IL_E8;
						case 4:
							if (this.a.LockColumnSize)
							{
								num = 1;
								continue;
							}
							goto IL_5D;
						case 5:
							goto IL_5D;
						case 6:
							return;
						case 7:
							if (flag)
							{
								num = 0;
								continue;
							}
							return;
						case 8:
							num = 9;
							continue;
						case 9:
							if (msg == 515)
							{
								goto IL_C7;
							}
							goto IL_5D;
						}
						break;
						IL_5D:
						if (true)
						{
						}
						num = 7;
						continue;
						IL_C7:
						num = 2;
						continue;
						IL_E8:
						num = 4;
					}
				}
			}

			// Token: 0x04000043 RID: 67
			private global::custom_controls.CustomCheckList a;
		}

		// Token: 0x0200000E RID: 14
		internal static class a
		{
			// Token: 0x06000045 RID: 69
			[global::System.Runtime.InteropServices.DllImport("User32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Auto, SetLastError = true)]
			public static extern global::System.IntPtr SendMessage(global::System.IntPtr A_0, int A_1, global::System.IntPtr A_2, global::System.IntPtr A_3);
		}
	}
}
