using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using custom_controls;
using custom_exception;
using resource_handler;
using smoothprogress;

namespace mototrbodepottool
{
	// Token: 0x02000016 RID: 22
	public partial class CProgressBar : CFormTemplate
	{
		// Token: 0x060000B8 RID: 184 RVA: 0x000178D4 File Offset: 0x000168D4
		public CProgressBar(CResourceHandler A_0, bool A_1, int A_2)
		{
			this.b();
			try
			{
				this.m.Visible = true;
				this.p.Visible = true;
				this.r.Visible = true;
				base.Mirrored = A_1;
				this.m.a(0);
				this.m.b(A_2);
				this.m.c(0);
				this.j = A_0;
				this.r.Image = (Image)A_0.GetObject("ICON_WARNING_24");
				this.i = A_0.GetString(this.n.Name);
				this.k = new CFrmTitleBarHndl();
				if (this.k == null)
				{
					CCustomException ex = CustomExceptionHandler.a(1646U, base.GetType().ToString(), "CProgressBar", Environment.StackTrace);
					throw ex;
				}
				this.Text = this.j.GetString("DLG_PROGIND");
			}
			catch (CCustomException ex2)
			{
				throw ex2;
			}
			catch (Exception ex3)
			{
				if (CCustomException.CheckErrorIDExsists(ex3))
				{
					CCustomException.Rethrow(ex3);
				}
				else
				{
					ex3.Source = 1700U.ToString(CultureInfo.InvariantCulture) + "| " + ex3.Source;
					CCustomException.Rethrow(ex3);
				}
			}
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00017A2C File Offset: 0x00016A2C
		public CProgressBar(CResourceHandler A_0, bool A_1, int A_2, bool A_3) : this(A_0, A_1, A_2)
		{
			this.n.Visible = A_3;
			this.m.Visible = A_3;
			this.s.Visible = !A_3;
			this.u.Visible = !A_3;
			this.t.Visible = !A_3;
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00017A8C File Offset: 0x00016A8C
		public void b(int A_0)
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
				if (!base.InvokeRequired)
				{
					this.m.b(A_0);
					this.m.c(this.m.c());
					this.n.Text = string.Empty;
					return;
				}
				break;
			}
			CProgressBar.b method = new CProgressBar.b(this.b);
			base.Invoke(method, new object[]
			{
				A_0
			});
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00017B2C File Offset: 0x00016B2C
		protected virtual void a(bool A_0)
		{
			int num = 2;
			for (;;)
			{
				switch (num)
				{
				case 0:
					goto IL_68;
				case 1:
					num = 4;
					continue;
				case 3:
					this.v.Dispose();
					goto IL_60;
				case 4:
					if (this.v != null)
					{
						num = 3;
						continue;
					}
					goto IL_91;
				}
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_60:
					num = 0;
					break;
				default:
					if (true)
					{
					}
					if (false)
					{
					}
					if (!A_0)
					{
						goto IL_91;
					}
					num = 1;
					break;
				}
			}
			IL_68:
			IL_91:
			base.Dispose(A_0);
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00017BD4 File Offset: 0x00016BD4
		protected virtual bool a(ref Message A_0, Keys A_1)
		{
			int num = 2;
			for (;;)
			{
				switch (num)
				{
				case 0:
					if (A_1 == (Keys)262259)
					{
						num = 3;
						continue;
					}
					goto IL_AD;
				case 1:
					if (A_0.Msg != 260)
					{
						goto IL_AD;
					}
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_35;
					default:
						if (true)
						{
						}
						if (false)
						{
						}
						num = 4;
						continue;
					}
					break;
				case 3:
					return true;
				case 4:
					goto IL_41;
				case 5:
					num = 1;
					continue;
				}
				goto IL_28;
				IL_35:
				num = 5;
				continue;
				IL_28:
				if (A_0.Msg != 256)
				{
					goto IL_35;
				}
				IL_41:
				num = 0;
			}
			return true;
			IL_AD:
			return base.ProcessCmdKey(ref A_0, A_1);
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00017C98 File Offset: 0x00016C98
		private void b()
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
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(CProgressBar));
			this.o = new Label();
			this.n = new Label();
			this.p = new Label();
			this.r = new PictureBox();
			this.s = new PictureBox();
			this.t = new PictureBox();
			this.u = new PictureBox();
			this.m = new smoothprogress.a();
			((ISupportInitialize)this.r).BeginInit();
			((ISupportInitialize)this.s).BeginInit();
			((ISupportInitialize)this.t).BeginInit();
			((ISupportInitialize)this.u).BeginInit();
			base.SuspendLayout();
			this.o.Location = new Point(10, 9);
			this.o.Name = "LBL_DISPLAYTEXT";
			this.o.Size = new Size(382, 16);
			this.o.TabIndex = 1;
			this.o.TextAlign = ContentAlignment.MiddleLeft;
			this.n.ForeColor = SystemColors.ControlText;
			this.n.Location = new Point(10, 70);
			this.n.Name = "LBL_PERCENTCOMP";
			this.n.Size = new Size(382, 18);
			this.n.TabIndex = 3;
			this.n.TextAlign = ContentAlignment.BottomCenter;
			this.p.Location = new Point(40, 30);
			this.p.Name = "LBL_WARN_TEXT";
			this.p.Size = new Size(351, 38);
			this.p.TabIndex = 2;
			this.p.TextAlign = ContentAlignment.MiddleLeft;
			this.r.Location = new Point(13, 37);
			this.r.Name = "pictureBox1";
			this.r.Size = new Size(25, 25);
			this.r.TabIndex = 4;
			this.r.TabStop = false;
			this.s.Image = (Image)componentResourceManager.GetObject("pictBar.Image");
			this.s.Location = new Point(84, 90);
			this.s.Name = "pictBar";
			this.s.Size = new Size(224, 8);
			this.s.SizeMode = PictureBoxSizeMode.StretchImage;
			this.s.TabIndex = 10;
			this.s.TabStop = false;
			this.s.Visible = false;
			this.t.Image = (Image)componentResourceManager.GetObject("pictRepeater.Image");
			this.t.Location = new Point(302, 62);
			this.t.Name = "pictRepeater";
			this.t.Size = new Size(63, 59);
			this.t.SizeMode = PictureBoxSizeMode.StretchImage;
			this.t.TabIndex = 9;
			this.t.TabStop = false;
			this.t.Visible = false;
			this.u.Image = (Image)componentResourceManager.GetObject("pictComp.Image");
			this.u.Location = new Point(37, 62);
			this.u.Name = "pictComp";
			this.u.Size = new Size(58, 59);
			this.u.SizeMode = PictureBoxSizeMode.StretchImage;
			this.u.TabIndex = 8;
			this.u.TabStop = false;
			this.u.Visible = false;
			this.m.Cursor = Cursors.Arrow;
			this.m.Location = new Point(10, 92);
			this.m.b(100);
			this.m.a(0);
			this.m.Name = "progressBar1";
			this.m.Size = new Size(382, 24);
			this.m.TabIndex = 0;
			this.m.c(0);
			this.AutoScaleBaseSize = new Size(5, 15);
			base.ClientSize = new Size(402, 124);
			base.Controls.Add(this.s);
			base.Controls.Add(this.t);
			base.Controls.Add(this.u);
			base.Controls.Add(this.r);
			base.Controls.Add(this.p);
			base.Controls.Add(this.o);
			base.Controls.Add(this.m);
			base.Controls.Add(this.n);
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "CProgressBar";
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterParent;
			this.Text = "";
			base.Closed += this.b;
			((ISupportInitialize)this.r).EndInit();
			((ISupportInitialize)this.s).EndInit();
			((ISupportInitialize)this.t).EndInit();
			((ISupportInitialize)this.u).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00018208 File Offset: 0x00017208
		public void a(int A_0)
		{
			try
			{
				switch (0)
				{
				default:
				{
					int num = 4;
					for (;;)
					{
						switch (num)
						{
						case 0:
							goto IL_1AD;
						case 1:
							goto IL_1B9;
						case 2:
							if (this.m.b() > 0)
							{
								num = 9;
								continue;
							}
							goto IL_1AD;
						case 3:
						{
							CProgressBar.b method = new CProgressBar.b(this.a);
							base.Invoke(method, new object[]
							{
								A_0
							});
							num = 0;
							continue;
						}
						case 5:
							goto IL_7E;
						case 6:
							this.m.c(this.m.b());
							goto IL_BC;
						case 7:
						{
							if (this.m.d() + A_0 > this.m.b())
							{
								num = 6;
								continue;
							}
							smoothprogress.a a = this.m;
							a.c(a.d() + A_0);
							num = 5;
							continue;
						}
						case 8:
							goto IL_7E;
						case 9:
						{
							int num2 = this.m.d() * 100 / this.m.b();
							this.n.Text = num2.ToString() + this.i;
							num = 10;
							continue;
						}
						case 10:
							goto IL_1AD;
						}
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							IL_BC:
							num = 8;
							continue;
						default:
							if (false)
							{
							}
							if (base.InvokeRequired)
							{
								num = 3;
								continue;
							}
							this.Cursor = Cursors.WaitCursor;
							num = 7;
							continue;
						}
						IL_7E:
						num = 2;
						continue;
						IL_1AD:
						num = 1;
					}
					IL_1B9:
					break;
				}
				}
			}
			catch (Exception ex)
			{
				this.Cursor = Cursors.Default;
				ex.Source = 1745U.ToString(CultureInfo.InvariantCulture) + "| " + ex.Source;
				CCustomException.Rethrow(ex);
			}
			if (true)
			{
			}
		}

		// Token: 0x060000BF RID: 191 RVA: 0x0001843C File Offset: 0x0001743C
		public void a(string A_0)
		{
			if (!base.InvokeRequired)
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
					this.o.Text = this.j.GetString(A_0);
					this.p.Text = this.j.GetString("LBL_PRG_WARN_TEXT");
					return;
				}
			}
			if (true)
			{
			}
			CProgressBar.a method = new CProgressBar.a(this.a);
			base.Invoke(method, new object[]
			{
				A_0
			});
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x000184D8 File Offset: 0x000174D8
		protected virtual void a(EventArgs A_0)
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
			this.a();
			base.OnLoad(A_0);
			this.q = new Timer();
			this.q.Interval = 2000;
			this.q.Tick += this.a;
			this.q.Start();
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00018560 File Offset: 0x00017560
		private void a()
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
			this.k.DisableCloseButton(this);
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x000185A8 File Offset: 0x000175A8
		private void b(object A_0, EventArgs A_1)
		{
			for (;;)
			{
				if (true)
				{
				}
				this.Cursor = Cursors.Default;
				Cursor.Current = Cursors.Default;
				this.q.Stop();
				int num = 1;
				for (;;)
				{
					switch (num)
					{
					case 0:
						goto IL_70;
					case 1:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_70;
						default:
							if (false)
							{
							}
							if (this.m != null)
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
					IL_70:
					this.m = null;
					num = 2;
				}
			}
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00018648 File Offset: 0x00017648
		private void a(object A_0, EventArgs A_1)
		{
			if (!this.p.Visible)
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
					if (true)
					{
					}
					this.r.Show();
					this.p.Show();
					this.q.Interval = 2000;
					return;
				}
			}
			this.r.Hide();
			this.p.Hide();
			this.q.Interval = 300;
		}

		// Token: 0x04000246 RID: 582
		private const int a = 0;

		// Token: 0x04000247 RID: 583
		private const int b = 100;

		// Token: 0x04000248 RID: 584
		private const int c = 256;

		// Token: 0x04000249 RID: 585
		private const int d = 260;

		// Token: 0x0400024A RID: 586
		private const string e = "DLG_PROGIND";

		// Token: 0x0400024B RID: 587
		private const string h = "LBL_PRG_WARN_TEXT";

		// Token: 0x0400024C RID: 588
		private string i;

		// Token: 0x0400024D RID: 589
		private CResourceHandler j;

		// Token: 0x0400024E RID: 590
		private CFrmTitleBarHndl k;

		// Token: 0x0400024F RID: 591
		private smoothprogress.a m;

		// Token: 0x04000250 RID: 592
		private Label n;

		// Token: 0x04000251 RID: 593
		private Label o;

		// Token: 0x04000252 RID: 594
		private Label p;

		// Token: 0x04000253 RID: 595
		private Timer q;

		// Token: 0x04000254 RID: 596
		private PictureBox r;

		// Token: 0x04000255 RID: 597
		private PictureBox s;

		// Token: 0x04000256 RID: 598
		private PictureBox t;

		// Token: 0x04000257 RID: 599
		private PictureBox u;

		// Token: 0x04000258 RID: 600
		private IContainer v;

		// Token: 0x02000017 RID: 23
		// (Invoke) Token: 0x060000C5 RID: 197
		public delegate void a(string A_0);

		// Token: 0x02000018 RID: 24
		// (Invoke) Token: 0x060000C9 RID: 201
		public delegate void b(int A_0);
	}
}
