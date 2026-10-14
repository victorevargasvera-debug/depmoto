using System;
using System.Drawing;
using System.Windows.Forms;

namespace custom_controls
{
	// Token: 0x02000090 RID: 144
	internal class c : global::System.Windows.Forms.UserControl
	{
		// Token: 0x060005F4 RID: 1524 RVA: 0x00059AC4 File Offset: 0x00057CC4
		public c(global::System.Windows.Forms.DockStyle A_0)
		{
			this.Dock = global::custom_controls.CSearch.GetControlDockStyle(A_0);
			base.Size = new global::System.Drawing.Size(4, 4);
			this.h = new global::System.Drawing.Rectangle(new global::System.Drawing.Point(0, 0), new global::System.Drawing.Size(0, 0));
			base.SetStyle(global::System.Windows.Forms.ControlStyles.DoubleBuffer, true);
			base.SetStyle(global::System.Windows.Forms.ControlStyles.AllPaintingInWmPaint, true);
			base.TabStop = false;
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x00059B28 File Offset: 0x00057D28
		protected virtual void b(global::System.Windows.Forms.MouseEventArgs A_0)
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
			this.d = (this.e = (this.g = base.PointToScreen(new global::System.Drawing.Point(A_0.X, A_0.Y))));
			this.f = base.Parent.ClientSize;
			base.OnMouseDown(A_0);
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x00059BAC File Offset: 0x00057DAC
		protected override void OnMouseMove(global::System.Windows.Forms.MouseEventArgs e)
		{
			try
			{
				switch (0)
				{
				default:
					for (;;)
					{
						base.Parent.SuspendLayout();
						base.SuspendLayout();
						int num = 16;
						for (;;)
						{
							global::System.Drawing.Rectangle rectangle;
							global::System.Drawing.Graphics graphics;
							global::System.Drawing.SolidBrush solidBrush;
							switch (num)
							{
							case 0:
								goto IL_46A;
							case 1:
								if (base.Capture)
								{
									num = 5;
									continue;
								}
								goto IL_446;
							case 2:
								if (rectangle.Bottom < this.e.Y)
								{
									num = 13;
									continue;
								}
								goto IL_31A;
							case 3:
								this.e = this.g;
								num = 4;
								continue;
							case 4:
								if (this.e.Y < rectangle.Bottom)
								{
									num = 6;
									continue;
								}
								goto IL_414;
							case 5:
							{
								global::System.Drawing.Size clientSize = base.ClientSize;
								rectangle = base.Parent.RectangleToScreen(base.Parent.ClientRectangle);
								global::System.Drawing.Point point = base.PointToScreen(new global::System.Drawing.Point(e.X, e.Y));
								this.e = point;
								num = 10;
								continue;
							}
							case 6:
								goto IL_40F;
							case 7:
							{
								global::System.Drawing.Point point;
								if (point.Y >= rectangle.Y + rectangle.Height)
								{
									num = 8;
									continue;
								}
								this.g = point;
								num = 19;
								continue;
							}
							case 8:
								this.e.Y = rectangle.Y + rectangle.Height - 10;
								this.g = this.e;
								num = 15;
								continue;
							case 9:
								if (this.Dock == global::System.Windows.Forms.DockStyle.Bottom)
								{
									num = 20;
									continue;
								}
								this.Cursor = global::System.Windows.Forms.Cursors.VSplit;
								num = 17;
								continue;
							case 10:
							{
								global::System.Drawing.Point point;
								if (point.Y <= global::custom_controls.CSearch.TopPosition)
								{
									num = 3;
									continue;
								}
								num = 7;
								continue;
							}
							case 11:
								num = 9;
								continue;
							case 12:
								goto IL_31A;
							case 13:
								goto IL_414;
							case 14:
								goto IL_2F5;
							case 15:
								switch ((1 == 1) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_40F;
								default:
									if (false)
									{
									}
									goto IL_31A;
								}
								break;
							case 16:
								if (this.Dock != global::System.Windows.Forms.DockStyle.Top)
								{
									num = 11;
									continue;
								}
								goto IL_23E;
							case 17:
								goto IL_2F5;
							case 18:
								try
								{
									global::System.Drawing.Point[] array = new global::System.Drawing.Point[2];
									global::System.Drawing.Point[] array2 = new global::System.Drawing.Point[2];
									global::System.Drawing.Rectangle rect = default(global::System.Drawing.Rectangle);
									array2[1].Y = (array2[0].Y = this.e.Y);
									global::System.Drawing.Size clientSize;
									array[1].X = (array2[1].X = clientSize.Width);
									rect.Width = clientSize.Width;
									rect.Height = clientSize.Height - 2;
									rect.X = 0;
									rect.Y = 1;
									graphics.DrawLine(global::custom_controls.CSearch.LightPen, array[0], array[1]);
									graphics.DrawLine(global::custom_controls.CSearch.DarkPen, array2[0], array2[1]);
									graphics.FillRectangle(solidBrush, rect);
									goto IL_2AD;
								}
								finally
								{
									num = 2;
									for (;;)
									{
										switch (num)
										{
										case 0:
											((global::System.IDisposable)solidBrush).Dispose();
											num = 1;
											continue;
										case 1:
											goto IL_23B;
										}
										if (solidBrush == null)
										{
											break;
										}
										num = 0;
									}
									IL_23B:;
								}
								goto IL_23E;
								IL_2AD:
								graphics.Dispose();
								num = 21;
								continue;
							case 19:
								goto IL_31A;
							case 20:
								if (true)
								{
								}
								goto IL_23E;
							case 21:
								goto IL_446;
							}
							break;
							IL_23E:
							this.Cursor = global::System.Windows.Forms.Cursors.HSplit;
							num = 14;
							continue;
							IL_2F5:
							num = 1;
							continue;
							IL_31A:
							graphics = base.CreateGraphics();
							solidBrush = new global::System.Drawing.SolidBrush(global::System.Drawing.Color.Gray);
							num = 18;
							continue;
							IL_40F:
							num = 2;
							continue;
							IL_414:
							this.e.Y = rectangle.Bottom - 10;
							this.g = this.e;
							num = 12;
							continue;
							IL_446:
							base.OnMouseMove(e);
							base.ResumeLayout();
							base.Parent.ResumeLayout();
							num = 0;
						}
					}
					IL_46A:
					break;
				}
			}
			catch (global::System.Exception)
			{
			}
		}

		// Token: 0x060005F7 RID: 1527 RVA: 0x0005A068 File Offset: 0x00058268
		protected override void OnMouseUp(global::System.Windows.Forms.MouseEventArgs e)
		{
			try
			{
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				this.a(e);
				base.OnMouseUp(e);
			}
			catch (global::System.Exception)
			{
			}
			if (true)
			{
			}
		}

		// Token: 0x060005F8 RID: 1528 RVA: 0x0005A0C8 File Offset: 0x000582C8
		protected override void OnPaint(global::System.Windows.Forms.PaintEventArgs pe)
		{
			try
			{
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				base.Parent.SuspendLayout();
				this.a(pe);
				base.OnPaint(pe);
				base.Parent.ResumeLayout();
			}
			catch (global::System.Exception)
			{
			}
			if (true)
			{
			}
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x0005A13C File Offset: 0x0005833C
		private void a(global::System.Windows.Forms.MouseEventArgs A_0)
		{
			int num = 2;
			for (;;)
			{
				int num2;
				int num3;
				switch (num)
				{
				case 0:
					num = 5;
					continue;
				case 1:
					num = 3;
					continue;
				case 3:
					if (this.Dock == global::System.Windows.Forms.DockStyle.Bottom)
					{
						num = 8;
						continue;
					}
					base.Parent.ClientSize = new global::System.Drawing.Size(this.f.Width + num2, this.f.Height);
					num = 7;
					continue;
				case 4:
					if (this.Dock != global::System.Windows.Forms.DockStyle.Top)
					{
						num = 1;
						continue;
					}
					goto IL_68;
				case 5:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1CD;
					default:
						if (false)
						{
						}
						if (this.Dock == global::System.Windows.Forms.DockStyle.Left)
						{
							num = 15;
							continue;
						}
						goto IL_B8;
					}
					break;
				case 6:
					return;
				case 7:
					goto IL_1D2;
				case 8:
					goto IL_1CD;
				case 9:
					num = 12;
					continue;
				case 10:
					if (this.Dock != global::System.Windows.Forms.DockStyle.Top)
					{
						num = 0;
						continue;
					}
					goto IL_1EA;
				case 11:
					if (true)
					{
					}
					num2 = this.e.X - this.d.X;
					num3 = this.e.Y - this.d.Y;
					num = 10;
					continue;
				case 12:
					if (this.d != this.e)
					{
						num = 11;
						continue;
					}
					goto IL_1D2;
				case 13:
					goto IL_B8;
				case 14:
					goto IL_1D2;
				case 15:
					goto IL_1EA;
				}
				if (base.Capture)
				{
					num = 9;
					continue;
				}
				break;
				IL_68:
				base.Parent.Top = base.Parent.Top + num3;
				base.Parent.ClientSize = new global::System.Drawing.Size(this.f.Width, this.f.Height + num3);
				num = 14;
				continue;
				IL_1CD:
				goto IL_68;
				IL_B8:
				num = 4;
				continue;
				IL_1D2:
				base.Parent.Refresh();
				num = 6;
				continue;
				IL_1EA:
				num2 = -num2;
				num3 = -num3;
				num = 13;
			}
		}

		// Token: 0x060005FA RID: 1530 RVA: 0x0005A38C File Offset: 0x0005858C
		private void a(global::System.Windows.Forms.PaintEventArgs A_0)
		{
			switch (0)
			{
			default:
			{
				global::System.Drawing.Point[] array;
				global::System.Drawing.Point[] array2;
				global::System.Drawing.Rectangle rect;
				for (;;)
				{
					array = new global::System.Drawing.Point[2];
					array2 = new global::System.Drawing.Point[2];
					rect = default(global::System.Drawing.Rectangle);
					global::System.Drawing.Size clientSize = base.ClientSize;
					int num = 4;
					for (;;)
					{
						switch (num)
						{
						case 0:
							goto IL_23A;
						case 1:
							goto IL_11C;
						case 2:
							goto IL_1A5;
						case 3:
							goto IL_1A0;
						case 4:
							if (this.Dock != global::System.Windows.Forms.DockStyle.Top)
							{
								num = 8;
								continue;
							}
							goto IL_1A5;
						case 5:
							if (this.Dock == global::System.Windows.Forms.DockStyle.Right)
							{
								num = 1;
								continue;
							}
							goto IL_23F;
						case 6:
							if (true)
							{
							}
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_23A;
							default:
								if (false)
								{
								}
								num = 5;
								continue;
							}
							break;
						case 7:
							if (this.Dock == global::System.Windows.Forms.DockStyle.Bottom)
							{
								num = 2;
								continue;
							}
							num = 9;
							continue;
						case 8:
							num = 7;
							continue;
						case 9:
							if (this.Dock != global::System.Windows.Forms.DockStyle.Left)
							{
								num = 6;
								continue;
							}
							goto IL_11C;
						}
						break;
						IL_11C:
						array2[1].X = (array2[0].X = clientSize.Width - 1);
						array[1].Y = (array2[1].Y = clientSize.Height);
						rect.Width = clientSize.Width - 2;
						rect.Height = clientSize.Height;
						rect.X = 1;
						rect.Y = 0;
						num = 3;
						continue;
						IL_1A5:
						array2[1].Y = (array2[0].Y = clientSize.Height - 1);
						array[1].X = (array2[1].X = clientSize.Width);
						rect.Width = clientSize.Width;
						rect.Height = clientSize.Height - 2;
						rect.X = 0;
						rect.Y = 1;
						A_0.Graphics.FillRectangle(global::custom_controls.CSearch.PlainBrush, rect);
						num = 0;
					}
				}
				IL_1A0:
				IL_23A:
				IL_23F:
				A_0.Graphics.DrawLine(global::custom_controls.CSearch.LightPen, array[0], array[1]);
				A_0.Graphics.DrawLine(global::custom_controls.CSearch.DarkPen, array2[0], array2[1]);
				A_0.Graphics.FillRectangle(global::custom_controls.CSearch.PlainBrush, rect);
				return;
			}
			}
		}

		// Token: 0x04000495 RID: 1173
		private const int a = 4;

		// Token: 0x04000496 RID: 1174
		private const int b = 350;

		// Token: 0x04000497 RID: 1175
		private const int c = 10;

		// Token: 0x04000498 RID: 1176
		private global::System.Drawing.Point d;

		// Token: 0x04000499 RID: 1177
		private global::System.Drawing.Point e;

		// Token: 0x0400049A RID: 1178
		private global::System.Drawing.Size f;

		// Token: 0x0400049B RID: 1179
		private global::System.Drawing.Point g;

		// Token: 0x0400049C RID: 1180
		private global::System.Drawing.Rectangle h;
	}
}
