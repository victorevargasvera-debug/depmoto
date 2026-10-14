using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace custom_controls
{
	// Token: 0x02000059 RID: 89
	internal class l : global::System.Windows.Forms.TextBox
	{
		// Token: 0x0600039E RID: 926 RVA: 0x0003D3FC File Offset: 0x0003B5FC
		public void a(global::custom_controls.b A_0)
		{
			for (;;)
			{
				IL_14:
				global::custom_controls.b b = this.p;
				if (true)
				{
				}
				int num = 2;
				for (;;)
				{
					global::custom_controls.b b2;
					switch (num)
					{
					case 0:
						goto IL_5E;
					case 1:
						if (b == b2)
						{
							num = 0;
							continue;
						}
						goto IL_2D;
					case 2:
						goto IL_2D;
					}
					goto IL_14;
					IL_2D:
					b2 = b;
					global::custom_controls.b value = (global::custom_controls.b)global::System.Delegate.Combine(b2, A_0);
					b = global::System.Threading.Interlocked.CompareExchange<global::custom_controls.b>(ref this.p, value, b2);
					num = 1;
				}
				IL_5E:
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				}
				break;
			}
			if (false)
			{
			}
		}

		// Token: 0x0600039F RID: 927 RVA: 0x0003D490 File Offset: 0x0003B690
		public void b(global::custom_controls.b A_0)
		{
			for (;;)
			{
				global::custom_controls.b b = this.p;
				if (true)
				{
				}
				int num = 2;
				for (;;)
				{
					global::custom_controls.b b2;
					switch (num)
					{
					case 0:
						if (b == b2)
						{
							num = 1;
							continue;
						}
						goto IL_37;
					case 1:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_54;
						default:
							goto IL_80;
						}
						break;
					case 2:
						goto IL_37;
					}
					break;
					IL_54:
					num = 0;
					continue;
					IL_37:
					b2 = b;
					global::custom_controls.b value = (global::custom_controls.b)global::System.Delegate.Remove(b2, A_0);
					b = global::System.Threading.Interlocked.CompareExchange<global::custom_controls.b>(ref this.p, value, b2);
					goto IL_54;
				}
			}
			IL_80:
			if (false)
			{
			}
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x0003D524 File Offset: 0x0003B724
		public void a(global::custom_controls.e A_0)
		{
			for (;;)
			{
				global::custom_controls.e e = this.q;
				int num = 1;
				for (;;)
				{
					global::custom_controls.e e2;
					switch (num)
					{
					case 0:
						if (e == e2)
						{
							num = 2;
							continue;
						}
						goto IL_2F;
					case 1:
						goto IL_2F;
					case 2:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_4C;
						default:
							goto IL_78;
						}
						break;
					}
					break;
					IL_4C:
					num = 0;
					continue;
					IL_2F:
					e2 = e;
					global::custom_controls.e value = (global::custom_controls.e)global::System.Delegate.Combine(e2, A_0);
					e = global::System.Threading.Interlocked.CompareExchange<global::custom_controls.e>(ref this.q, value, e2);
					goto IL_4C;
				}
			}
			IL_78:
			if (true)
			{
			}
			if (false)
			{
			}
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x0003D5B8 File Offset: 0x0003B7B8
		public void b(global::custom_controls.e A_0)
		{
			for (;;)
			{
				global::custom_controls.e e = this.q;
				int num = 2;
				for (;;)
				{
					switch (num)
					{
					case 0:
						return;
					case 1:
					{
						global::custom_controls.e e2;
						if (e == e2)
						{
							if (true)
							{
							}
							num = 0;
							continue;
						}
						goto IL_25;
					}
					case 2:
						goto IL_25;
					}
					break;
					IL_25:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						if (false)
						{
						}
						global::custom_controls.e e2 = e;
						global::custom_controls.e value = (global::custom_controls.e)global::System.Delegate.Remove(e2, A_0);
						e = global::System.Threading.Interlocked.CompareExchange<global::custom_controls.e>(ref this.q, value, e2);
						num = 1;
						break;
					}
					}
				}
			}
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x0003D650 File Offset: 0x0003B850
		public global::custom_controls.AddressType p()
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
			return this.r;
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x0003D694 File Offset: 0x0003B894
		public void a(global::custom_controls.AddressType A_0)
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
			this.r = A_0;
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x0003D6D8 File Offset: 0x0003B8D8
		public string x()
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
			return this.s;
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x0003D71C File Offset: 0x0003B91C
		public void a(string A_0)
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
			this.s = A_0;
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x0003D760 File Offset: 0x0003B960
		public bool d()
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
			return this.t;
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x0003D7A4 File Offset: 0x0003B9A4
		public void b(bool A_0)
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
			this.t = A_0;
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x0003D7E8 File Offset: 0x0003B9E8
		public bool e()
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
			return this.y;
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x0003D82C File Offset: 0x0003BA2C
		public void c(bool A_0)
		{
			int num = 2;
			for (;;)
			{
				switch (num)
				{
				case 0:
					goto IL_46;
				case 1:
					this.y = A_0;
					num = 0;
					continue;
				}
				if (true)
				{
				}
				if (this.y == A_0)
				{
					break;
				}
				num = 1;
			}
			IL_46:
			switch ((1 == 1) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_46;
			default:
				if (false)
				{
				}
				base.OnRightToLeftChanged(global::System.EventArgs.Empty);
				return;
			}
		}

		// Token: 0x060003AA RID: 938 RVA: 0x0003D8B4 File Offset: 0x0003BAB4
		protected virtual global::System.Windows.Forms.CreateParams g()
		{
			global::System.Windows.Forms.CreateParams createParams;
			for (;;)
			{
				createParams = base.CreateParams;
				int num = 2;
				for (;;)
				{
					switch (num)
					{
					case 0:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_6B;
						default:
							if (false)
							{
							}
							num = 4;
							continue;
						}
						break;
					case 1:
						return createParams;
					case 2:
						if (true)
						{
						}
						if (this.e())
						{
							num = 0;
							continue;
						}
						return createParams;
					case 3:
						goto IL_6B;
					case 4:
						if (!base.DesignMode)
						{
							num = 3;
							continue;
						}
						return createParams;
					}
					break;
					IL_6B:
					createParams.ExStyle |= 4194304;
					num = 1;
				}
			}
			return createParams;
		}

		// Token: 0x060003AB RID: 939 RVA: 0x0003D96C File Offset: 0x0003BB6C
		public int v()
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
			return this.u;
		}

		// Token: 0x060003AC RID: 940 RVA: 0x0003D9B0 File Offset: 0x0003BBB0
		public void b(int A_0)
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
			this.u = A_0;
		}

		// Token: 0x060003AD RID: 941 RVA: 0x0003D9F4 File Offset: 0x0003BBF4
		public bool f()
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
			return this.aa;
		}

		// Token: 0x060003AE RID: 942 RVA: 0x0003DA38 File Offset: 0x0003BC38
		public int w()
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
			return this.w;
		}

		// Token: 0x060003AF RID: 943 RVA: 0x0003DA7C File Offset: 0x0003BC7C
		public void a(int A_0)
		{
			int num = 2;
			for (;;)
			{
				switch (num)
				{
				case 0:
					this.w = this.x;
					num = 8;
					continue;
				case 1:
					goto IL_6D;
				case 3:
					goto IL_65;
				case 4:
					goto IL_65;
				case 5:
					this.w = 0;
					num = 4;
					continue;
				case 6:
					this.Text = this.w.ToString(global::System.Globalization.CultureInfo.InvariantCulture);
					num = 9;
					continue;
				case 7:
					if (A_0 > this.x)
					{
						num = 0;
						continue;
					}
					this.w = A_0;
					num = 3;
					continue;
				case 8:
					goto IL_65;
				case 9:
					return;
				}
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_6D:
					if (true)
					{
					}
					if (this.b() < this.w)
					{
						num = 6;
						continue;
					}
					return;
				default:
					if (false)
					{
					}
					if (A_0 < 0)
					{
						num = 5;
						continue;
					}
					num = 7;
					continue;
				}
				IL_65:
				num = 1;
			}
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x0003DBB0 File Offset: 0x0003BDB0
		public int t()
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
			return this.x;
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x0003DBF4 File Offset: 0x0003BDF4
		public void c(int A_0)
		{
			int num;
			switch ((1 == 1) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_A0:
				num = 4;
				break;
			default:
				if (false)
				{
				}
				num = 6;
				break;
			}
			for (;;)
			{
				switch (num)
				{
				case 0:
					goto IL_10E;
				case 1:
					if (this.b() > this.x)
					{
						num = 2;
						continue;
					}
					return;
				case 2:
					this.Text = this.x.ToString(global::System.Globalization.CultureInfo.InvariantCulture);
					num = 3;
					continue;
				case 3:
					goto IL_E4;
				case 4:
					goto IL_72;
				case 5:
					goto IL_72;
				case 6:
					if (true)
					{
					}
					break;
				case 7:
					goto IL_72;
				case 8:
					if (A_0 > 255)
					{
						num = 0;
						continue;
					}
					this.x = A_0;
					num = 7;
					continue;
				case 9:
					this.x = this.w;
					num = 5;
					continue;
				}
				if (A_0 < this.w)
				{
					num = 9;
					continue;
				}
				num = 8;
				continue;
				IL_72:
				num = 1;
			}
			IL_E4:
			return;
			IL_10E:
			this.x = 255;
			goto IL_A0;
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x0003DD28 File Offset: 0x0003BF28
		public bool u()
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
			return this.z;
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x0003DD6C File Offset: 0x0003BF6C
		public void d(bool A_0)
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
			this.z = A_0;
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x0003DDB0 File Offset: 0x0003BFB0
		public bool s()
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
			return string.IsNullOrEmpty(this.Text);
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x0003DDF8 File Offset: 0x0003BFF8
		public int q()
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
			return this.ab;
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x0003DE3C File Offset: 0x0003C03C
		public void d(int A_0)
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
			this.ab = A_0;
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x0003DE80 File Offset: 0x0003C080
		public void a(global::System.Drawing.Font A_0)
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
			this.Font = A_0;
			base.Size = this.c();
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x0003DED0 File Offset: 0x0003C0D0
		public void a(global::custom_controls.f A_0, global::custom_controls.k A_1)
		{
			for (;;)
			{
				base.Focus();
				int num = 1;
				for (;;)
				{
					switch (num)
					{
					case 0:
						if (A_0 == global::custom_controls.f.a)
						{
							num = 2;
							continue;
						}
						goto IL_94;
					case 1:
						if (true)
						{
						}
						if (A_1 != global::custom_controls.k.b)
						{
							num = 0;
							continue;
						}
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_7E;
						default:
							if (false)
							{
							}
							num = 3;
							continue;
						}
						break;
					case 2:
						goto IL_7E;
					case 3:
						goto IL_57;
					}
					break;
				}
			}
			IL_57:
			base.SelectionStart = 0;
			this.SelectionLength = this.TextLength;
			return;
			IL_7E:
			base.SelectionStart = 0;
			return;
			IL_94:
			base.SelectionStart = this.TextLength;
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x0003DF80 File Offset: 0x0003C180
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
			return this.b().ToString(global::System.Globalization.CultureInfo.InvariantCulture);
		}

		// Token: 0x060003BA RID: 954 RVA: 0x0003DFD0 File Offset: 0x0003C1D0
		public l()
		{
			this.a();
			this.AutoSize = false;
			base.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.MaxLength = 3;
			base.TabStop = true;
			base.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			base.Size = this.c();
			this.h = new global::System.Windows.Forms.ToolStripMenuItem();
			this.h.MergeIndex = 1;
			this.h.Click += this.d;
			this.h.Text = "&Undo";
			this.i = new global::System.Windows.Forms.ToolStripSeparator();
			this.i.MergeIndex = 2;
			this.j = new global::System.Windows.Forms.ToolStripMenuItem();
			this.j.MergeIndex = 3;
			this.j.ShortcutKeys = (global::System.Windows.Forms.Keys)131160;
			this.j.ShowShortcutKeys = false;
			this.j.Click += this.f;
			this.j.Text = "Cu&t";
			this.k = new global::System.Windows.Forms.ToolStripMenuItem();
			this.k.MergeIndex = 4;
			this.k.ShortcutKeys = (global::System.Windows.Forms.Keys)131139;
			this.k.ShowShortcutKeys = false;
			this.k.Click += this.b;
			this.k.Text = "&Copy";
			this.l = new global::System.Windows.Forms.ToolStripMenuItem();
			this.l.MergeIndex = 5;
			this.l.ShortcutKeys = (global::System.Windows.Forms.Keys)131158;
			this.l.ShowShortcutKeys = false;
			this.l.Click += this.e;
			this.l.Text = "&Paste";
			this.m = new global::System.Windows.Forms.ToolStripMenuItem();
			this.m.MergeIndex = 6;
			this.m.ShortcutKeys = global::System.Windows.Forms.Keys.Delete;
			this.m.ShowShortcutKeys = false;
			this.m.Click += this.g;
			this.m.Text = "&Delete";
			this.n = new global::System.Windows.Forms.ToolStripSeparator();
			this.n.MergeIndex = 7;
			this.o = new global::System.Windows.Forms.ToolStripMenuItem();
			this.o.MergeIndex = 8;
			this.o.ShortcutKeys = (global::System.Windows.Forms.Keys)131137;
			this.o.ShowShortcutKeys = false;
			this.o.Click += this.a;
			this.o.Text = "Select &All";
			this.ContextMenuStrip = new global::System.Windows.Forms.ContextMenuStrip();
			this.ContextMenuStrip.Items.Add(this.h);
			this.ContextMenuStrip.Items.Add(this.i);
			this.ContextMenuStrip.Items.Add(this.j);
			this.ContextMenuStrip.Items.Add(this.k);
			this.ContextMenuStrip.Items.Add(this.l);
			this.ContextMenuStrip.Items.Add(this.m);
			this.ContextMenuStrip.Opened += this.c;
			this.z = false;
			this.aa = false;
			this.ab = 0;
			this.t = false;
		}

		// Token: 0x060003BB RID: 955 RVA: 0x0003E320 File Offset: 0x0003C520
		protected override void OnKeyDown(global::System.Windows.Forms.KeyEventArgs e)
		{
			for (;;)
			{
				this.v = false;
				int num = 50;
				for (;;)
				{
					switch (num)
					{
					case 0:
						goto IL_1A5;
					case 1:
						if (this.SelectionLength == 0)
						{
							num = 23;
							continue;
						}
						goto IL_694;
					case 2:
						goto IL_1D0;
					case 3:
						num = 58;
						continue;
					case 4:
						this.v = true;
						if (true)
						{
						}
						num = 60;
						continue;
					case 5:
						goto IL_3D0;
					case 6:
						this.p(this.v(), global::custom_controls.f.a, global::custom_controls.k.b);
						num = 57;
						continue;
					case 7:
						num = 64;
						continue;
					case 8:
						if (e.KeyCode > global::System.Windows.Forms.Keys.NumPad9)
						{
							num = 2;
							continue;
						}
						goto IL_276;
					case 9:
						num = 32;
						continue;
					case 10:
						goto IL_547;
					case 11:
						if (this.SelectionLength == 0)
						{
							num = 26;
							continue;
						}
						goto IL_3D0;
					case 12:
						if (base.SelectionStart == this.Text.Length)
						{
							num = 56;
							continue;
						}
						goto IL_694;
					case 13:
						if (e.KeyCode != global::System.Windows.Forms.Keys.Right)
						{
							num = 3;
							continue;
						}
						goto IL_1A5;
					case 14:
						this.v = true;
						num = 47;
						continue;
					case 15:
						if (base.SelectionStart != 0)
						{
							num = 54;
							continue;
						}
						goto IL_547;
					case 16:
						if (!this.a(e))
						{
							num = 14;
							continue;
						}
						goto IL_276;
					case 17:
						if (e.KeyCode == global::System.Windows.Forms.Keys.Space)
						{
							num = 36;
							continue;
						}
						goto IL_547;
					case 18:
						num = 59;
						continue;
					case 19:
						if (this.p != null)
						{
							num = 22;
							continue;
						}
						goto IL_694;
					case 20:
						if (this.p != null)
						{
							num = 29;
							continue;
						}
						goto IL_3D0;
					case 21:
						this.p(this.v(), global::custom_controls.f.b, global::custom_controls.k.b);
						num = 5;
						continue;
					case 22:
						this.p(this.v(), global::custom_controls.f.a, global::custom_controls.k.a);
						num = 63;
						continue;
					case 23:
						num = 12;
						continue;
					case 24:
						if (!this.a(e))
						{
							num = 4;
							continue;
						}
						goto IL_276;
					case 25:
						if (e.Modifiers == global::System.Windows.Forms.Keys.Control)
						{
							num = 38;
							continue;
						}
						num = 11;
						continue;
					case 26:
						num = 43;
						continue;
					case 27:
						if (this.TextLength != 0)
						{
							num = 18;
							continue;
						}
						goto IL_547;
					case 28:
						num = 8;
						continue;
					case 29:
						this.p(this.v(), global::custom_controls.f.b, global::custom_controls.k.a);
						num = 35;
						continue;
					case 30:
						goto IL_163;
					case 31:
						goto IL_336;
					case 32:
						if (e.KeyCode != global::System.Windows.Forms.Keys.Up)
						{
							num = 34;
							continue;
						}
						goto IL_163;
					case 33:
						if (this.p != null)
						{
							num = 21;
							continue;
						}
						goto IL_3D0;
					case 34:
						num = 48;
						continue;
					case 35:
						goto IL_3D0;
					case 36:
						goto IL_463;
					case 37:
						num = 17;
						continue;
					case 38:
						num = 33;
						continue;
					case 39:
						num = 15;
						continue;
					case 40:
						goto IL_1B0;
					case 41:
						num = 24;
						continue;
					case 42:
						num = 20;
						continue;
					case 43:
						if (base.SelectionStart == 0)
						{
							num = 42;
							continue;
						}
						goto IL_3D0;
					case 44:
						this.p(this.v(), global::custom_controls.f.a, global::custom_controls.k.b);
						num = 10;
						continue;
					case 45:
						if (e.KeyCode >= global::System.Windows.Forms.Keys.D0)
						{
							num = 55;
							continue;
						}
						goto IL_336;
					case 46:
						if (e.KeyCode >= global::System.Windows.Forms.Keys.NumPad0)
						{
							num = 28;
							continue;
						}
						goto IL_1D0;
					case 47:
						goto IL_276;
					case 48:
						if (e.KeyCode == global::System.Windows.Forms.Keys.Back)
						{
							num = 30;
							continue;
						}
						goto IL_3D0;
					case 49:
						if (e.KeyCode > global::System.Windows.Forms.Keys.D9)
						{
							num = 31;
							continue;
						}
						goto IL_276;
					case 50:
						if (this.r == global::custom_controls.AddressType.MACADDRESS)
						{
							num = 41;
							continue;
						}
						num = 46;
						continue;
					case 51:
						if (this.p != null)
						{
							num = 6;
							continue;
						}
						goto IL_694;
					case 52:
						if (e.KeyCode != global::System.Windows.Forms.Keys.Left)
						{
							num = 9;
							continue;
						}
						goto IL_163;
					case 53:
						if (e.KeyCode != global::System.Windows.Forms.Keys.OemPeriod)
						{
							num = 7;
							continue;
						}
						goto IL_463;
					case 54:
						num = 61;
						continue;
					case 55:
						num = 49;
						continue;
					case 56:
						num = 19;
						continue;
					case 57:
						goto IL_2C0;
					case 58:
						if (e.KeyCode == global::System.Windows.Forms.Keys.Down)
						{
							num = 0;
							continue;
						}
						goto IL_694;
					case 59:
						if (this.SelectionLength == 0)
						{
							num = 39;
							continue;
						}
						goto IL_547;
					case 60:
						goto IL_276;
					case 61:
						if (this.p != null)
						{
							num = 44;
							continue;
						}
						goto IL_547;
					case 62:
						num = 51;
						continue;
					case 63:
						goto IL_2E4;
					case 64:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1B0;
						default:
							if (false)
							{
							}
							if (e.KeyCode != global::System.Windows.Forms.Keys.Decimal)
							{
								num = 37;
								continue;
							}
							goto IL_463;
						}
						break;
					}
					break;
					IL_163:
					num = 25;
					continue;
					IL_1A5:
					num = 40;
					continue;
					IL_1B0:
					if (e.Modifiers == global::System.Windows.Forms.Keys.Control)
					{
						num = 62;
						continue;
					}
					num = 1;
					continue;
					IL_1D0:
					num = 45;
					continue;
					IL_276:
					num = 53;
					continue;
					IL_336:
					num = 16;
					continue;
					IL_3D0:
					num = 13;
					continue;
					IL_463:
					num = 27;
					continue;
					IL_547:
					num = 52;
				}
			}
			IL_2C0:
			IL_2E4:
			IL_694:
			base.OnKeyDown(e);
		}

		// Token: 0x060003BC RID: 956 RVA: 0x0003E9C8 File Offset: 0x0003CBC8
		protected override void OnKeyPress(global::System.Windows.Forms.KeyPressEventArgs e)
		{
			int num;
			switch ((1 == 1) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_1FC:
				num = 2;
				break;
			default:
				if (false)
				{
				}
				switch (0)
				{
				default:
					num = 3;
					break;
				}
				break;
			}
			for (;;)
			{
				switch (num)
				{
				case 0:
				{
					bool flag = false;
					char c = char.ToUpper(e.KeyChar, global::System.Globalization.CultureInfo.InvariantCulture);
					global::System.Array array = this.s.ToCharArray();
					global::System.Collections.IEnumerator enumerator = array.GetEnumerator();
					num = 1;
					continue;
				}
				case 1:
					try
					{
						num = 4;
						for (;;)
						{
							switch (num)
							{
							case 0:
							{
								global::System.Collections.IEnumerator enumerator;
								if (!enumerator.MoveNext())
								{
									num = 3;
									continue;
								}
								char c2 = (char)enumerator.Current;
								num = 6;
								continue;
							}
							case 1:
								goto IL_144;
							case 2:
								goto IL_14D;
							case 3:
								goto IL_144;
							case 5:
							{
								bool flag = true;
								num = 1;
								continue;
							}
							case 6:
							{
								char c;
								char c2;
								if (c == c2)
								{
									num = 5;
									continue;
								}
								break;
							}
							}
							IL_127:
							num = 0;
							continue;
							goto IL_127;
							IL_144:
							num = 2;
						}
						IL_14D:
						goto IL_A1;
					}
					finally
					{
						for (;;)
						{
							global::System.Collections.IEnumerator enumerator;
							global::System.IDisposable disposable = enumerator as global::System.IDisposable;
							num = 0;
							for (;;)
							{
								switch (num)
								{
								case 0:
									if (disposable != null)
									{
										num = 2;
										continue;
									}
									goto IL_19A;
								case 1:
									goto IL_198;
								case 2:
									disposable.Dispose();
									num = 1;
									continue;
								}
								break;
							}
						}
						IL_198:
						IL_19A:;
					}
					goto IL_19B;
					IL_A1:
					num = 4;
					continue;
				case 2:
					goto IL_19B;
				case 3:
					if (true)
					{
					}
					break;
				case 4:
				{
					bool flag;
					if (!flag & this.v)
					{
						num = 6;
						continue;
					}
					goto IL_20A;
				}
				case 5:
					goto IL_1F4;
				case 6:
					e.Handled = true;
					num = 8;
					continue;
				case 7:
					goto IL_1AE;
				case 8:
					goto IL_9C;
				}
				if (this.r == global::custom_controls.AddressType.MACADDRESS)
				{
					num = 0;
					continue;
				}
				num = 5;
				continue;
				IL_19B:
				e.Handled = true;
				num = 7;
			}
			IL_9C:
			IL_1AE:
			goto IL_20A;
			IL_1F4:
			if (this.v)
			{
				goto IL_1FC;
			}
			IL_20A:
			base.OnKeyPress(e);
		}

		// Token: 0x060003BD RID: 957 RVA: 0x0003EBF8 File Offset: 0x0003CDF8
		protected override void OnLeave(global::System.EventArgs e)
		{
			switch (0)
			{
			default:
			{
				int num = 20;
				for (;;)
				{
					if (true)
					{
					}
					int num3;
					switch (num)
					{
					case 0:
						num = 3;
						continue;
					case 1:
						goto IL_27A;
					case 2:
						if (this.r == global::custom_controls.AddressType.MACADDRESS)
						{
							num = 22;
							continue;
						}
						num = 18;
						continue;
					case 3:
						goto IL_34B;
					case 4:
						goto IL_311;
					case 5:
					{
						long num2;
						this.Text = ((long)this.w() + (long)this.ab * num2).ToString(global::System.Globalization.CultureInfo.InvariantCulture);
						num = 9;
						continue;
					}
					case 6:
						if (num3 < this.w())
						{
							num = 10;
							continue;
						}
						this.Text = global::System.Convert.ToString(num3, global::System.Globalization.CultureInfo.InvariantCulture);
						num = 16;
						continue;
					case 7:
						if ((num3 - this.w()) % this.ab != 0)
						{
							num = 5;
							continue;
						}
						goto IL_34B;
					case 8:
						if (num3 > this.t())
						{
							num = 14;
							continue;
						}
						num = 6;
						continue;
					case 9:
						goto IL_34B;
					case 10:
						this.Text = this.w().ToString(global::System.Globalization.CultureInfo.InvariantCulture);
						num = 13;
						continue;
					case 11:
						this.Text = "0";
						num = 4;
						continue;
					case 12:
						if (this.t)
						{
							goto IL_2BE;
						}
						goto IL_1E7;
					case 13:
						goto IL_34B;
					case 14:
						this.Text = this.t().ToString(global::System.Globalization.CultureInfo.InvariantCulture);
						num = 23;
						continue;
					case 15:
						goto IL_2D4;
					case 16:
						if (this.ab > 0)
						{
							num = 21;
							continue;
						}
						goto IL_34B;
					case 17:
						if (this.Text.Length >= this.MaxLength)
						{
							num = 0;
							continue;
						}
						this.Text = "0" + this.Text;
						num = 24;
						continue;
					case 18:
						if (string.IsNullOrEmpty(this.Text))
						{
							num = 11;
							continue;
						}
						goto IL_311;
					case 19:
						num = 12;
						continue;
					case 21:
					{
						long num2 = (long)((num3 - this.w()) / this.ab);
						num = 7;
						continue;
					}
					case 22:
						num = 1;
						continue;
					case 23:
						goto IL_34B;
					case 24:
						goto IL_27A;
					}
					if (string.IsNullOrEmpty(this.Text))
					{
						num = 19;
						continue;
					}
					IL_1E7:
					num = 2;
					continue;
					IL_27A:
					num = 17;
					continue;
					IL_2BE:
					num = 15;
					continue;
					IL_34B:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_2BE;
					default:
						goto IL_361;
					}
					IL_311:
					num3 = int.Parse(this.Text, global::System.Globalization.CultureInfo.InvariantCulture);
					num = 8;
				}
				IL_2D4:
				this.Text = string.Empty;
				this.z = false;
				this.aa = false;
				base.OnLeave(e);
				return;
				IL_361:
				if (false)
				{
				}
				this.z = false;
				this.aa = false;
				base.OnLeave(e);
				return;
			}
			}
		}

		// Token: 0x060003BE RID: 958 RVA: 0x0003EF84 File Offset: 0x0003D184
		protected override void OnTextChanged(global::System.EventArgs e)
		{
			int selectionStart;
			for (;;)
			{
				selectionStart = base.SelectionStart;
				int num = 5;
				for (;;)
				{
					switch (num)
					{
					case 0:
						goto IL_1A7;
					case 1:
						if (this.Text.Length == this.MaxLength)
						{
							num = 4;
							continue;
						}
						goto IL_247;
					case 2:
						try
						{
							num = 2;
							for (;;)
							{
								int num2;
								switch (num)
								{
								case 0:
									goto IL_18C;
								case 1:
									goto IL_18C;
								case 3:
									goto IL_197;
								case 4:
									if (num2 > this.t())
									{
										num = 5;
										continue;
									}
									goto IL_18C;
								case 5:
									this.Text = this.t().ToString(global::System.Globalization.CultureInfo.InvariantCulture);
									num = 0;
									continue;
								case 6:
									this.Text = this.Text.ToUpper(global::System.Globalization.CultureInfo.InvariantCulture);
									num = 1;
									continue;
								}
								if (this.r == global::custom_controls.AddressType.MACADDRESS)
								{
									num = 6;
									continue;
								}
								num2 = int.Parse(this.Text, global::System.Globalization.CultureInfo.InvariantCulture);
								num = 4;
								continue;
								IL_18C:
								num = 3;
							}
							IL_197:
							goto IL_1FC;
						}
						catch (global::System.Exception)
						{
							this.Text = "";
							goto IL_1FC;
						}
						goto IL_1A7;
					case 3:
						if (this.Focused)
						{
							num = 0;
							continue;
						}
						goto IL_247;
					case 4:
						num = 3;
						continue;
					case 5:
						if (!this.s())
						{
							num = 2;
							continue;
						}
						goto IL_1FC;
					case 6:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							if (false)
							{
							}
							this.q(this.v(), this.Text);
							num = 9;
							continue;
						}
						break;
					case 7:
						if (this.p != null)
						{
							if (true)
							{
							}
							num = 8;
							continue;
						}
						goto IL_247;
					case 8:
						this.p(this.v(), global::custom_controls.f.a, global::custom_controls.k.b);
						num = 10;
						continue;
					case 9:
						goto IL_7C;
					case 10:
						goto IL_D3;
					case 11:
						if (this.q != null)
						{
							num = 6;
							continue;
						}
						goto IL_7C;
					}
					break;
					IL_7C:
					num = 1;
					continue;
					IL_1A7:
					num = 7;
					continue;
					IL_1FC:
					base.SelectionStart = this.TextLength;
					num = 11;
				}
			}
			IL_D3:
			IL_247:
			base.OnTextChanged(e);
			base.SelectionStart = selectionStart;
		}

		// Token: 0x060003BF RID: 959 RVA: 0x0003F1F8 File Offset: 0x0003D3F8
		protected override void OnValidating(global::System.ComponentModel.CancelEventArgs e)
		{
			switch ((1 == 1) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				if (false)
				{
				}
				int num = 1;
				for (;;)
				{
					switch (num)
					{
					case 0:
						num = 2;
						continue;
					case 1:
						if (true)
						{
						}
						break;
					case 2:
						if (this.b() < this.w())
						{
							num = 4;
							continue;
						}
						goto IL_A7;
					case 3:
						goto IL_85;
					case 4:
						this.Text = this.w().ToString(global::System.Globalization.CultureInfo.InvariantCulture);
						num = 3;
						continue;
					}
					if (this.s())
					{
						break;
					}
					num = 0;
				}
				break;
			}
			}
			IL_85:
			IL_A7:
			base.OnValidating(e);
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x0003F2B4 File Offset: 0x0003D4B4
		private global::System.Drawing.Size c()
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
			string a_ = new string('0', this.MaxLength);
			return global::custom_controls.n.a(base.Handle, this.Font, a_);
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x0003F310 File Offset: 0x0003D510
		private bool a(global::System.Windows.Forms.KeyEventArgs A_0)
		{
			int num = 11;
			for (;;)
			{
				switch (num)
				{
				case 0:
					num = 2;
					continue;
				case 1:
					goto IL_E6;
				case 2:
					if (A_0.KeyCode != global::System.Windows.Forms.Keys.V)
					{
						num = 3;
						continue;
					}
					return true;
				case 3:
					num = 4;
					continue;
				case 4:
					if (A_0.KeyCode == global::System.Windows.Forms.Keys.X)
					{
						num = 1;
						continue;
					}
					goto IL_110;
				case 5:
					num = 9;
					continue;
				case 6:
					if (A_0.KeyCode != global::System.Windows.Forms.Keys.C)
					{
						num = 0;
						continue;
					}
					return true;
				case 7:
					num = 6;
					continue;
				case 8:
					goto IL_C4;
				case 9:
					if (true)
					{
					}
					if (A_0.KeyCode == global::System.Windows.Forms.Keys.Delete)
					{
						num = 8;
						continue;
					}
					num = 10;
					continue;
				case 10:
					if (A_0.Modifiers == global::System.Windows.Forms.Keys.Control)
					{
						num = 7;
						continue;
					}
					goto IL_110;
				}
				goto IL_40;
				IL_49:
				num = 5;
				continue;
				IL_40:
				if (A_0.KeyCode != global::System.Windows.Forms.Keys.Back)
				{
					goto IL_49;
				}
				break;
				IL_110:
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_49;
				default:
					goto IL_126;
				}
			}
			return true;
			IL_C4:
			return true;
			IL_E6:
			return true;
			IL_126:
			if (false)
			{
			}
			return false;
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x0003F44C File Offset: 0x0003D64C
		private int b()
		{
			int result;
			try
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
				result = int.Parse(this.Text, global::System.Globalization.CultureInfo.InvariantCulture);
			}
			catch (global::System.Exception)
			{
				result = this.w();
			}
			return result;
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x0003F4B8 File Offset: 0x0003D6B8
		protected virtual void a(bool A_0)
		{
			if (true)
			{
			}
			int num = 4;
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
						if (false)
						{
						}
						num = 1;
						continue;
					}
					break;
				case 1:
					if (this.ac != null)
					{
						num = 3;
						continue;
					}
					goto IL_8E;
				case 2:
					goto IL_72;
				case 3:
					this.ac.Dispose();
					num = 2;
					continue;
				}
				if (!A_0)
				{
					break;
				}
				num = 0;
			}
			IL_72:
			IL_8E:
			base.Dispose(A_0);
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x0003F55C File Offset: 0x0003D75C
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
			base.Name = "CFieldControl";
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x0003F5A4 File Offset: 0x0003D7A4
		public void d(object A_0, global::System.EventArgs A_1)
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
			this.r();
			this.aa = true;
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x0003F5EC File Offset: 0x0003D7EC
		public void b(object A_0, global::System.EventArgs A_1)
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
			base.Copy();
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x0003F630 File Offset: 0x0003D830
		public void e(object A_0, global::System.EventArgs A_1)
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
			base.Paste();
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x0003F674 File Offset: 0x0003D874
		public void f(object A_0, global::System.EventArgs A_1)
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
			base.Cut();
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x0003F6B8 File Offset: 0x0003D8B8
		public void g(object A_0, global::System.EventArgs A_1)
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
			this.a(this);
		}

		// Token: 0x060003CA RID: 970 RVA: 0x0003F6FC File Offset: 0x0003D8FC
		public void a(object A_0)
		{
			try
			{
				for (;;)
				{
					global::custom_controls.l l = (global::custom_controls.l)A_0;
					int num = 0;
					for (;;)
					{
						switch (num)
						{
						case 0:
							if (!string.IsNullOrEmpty(l.SelectedText))
							{
								num = 8;
								continue;
							}
							num = 2;
							continue;
						case 1:
							goto IL_103;
						case 2:
							if (!string.IsNullOrEmpty(l.Text))
							{
								num = 5;
								continue;
							}
							goto IL_103;
						case 3:
							goto IL_101;
						case 4:
						{
							int selectionStart = l.SelectionStart;
							l.Text = l.Text.Remove(l.SelectionStart, 1);
							l.SelectionStart = selectionStart;
							num = 3;
							continue;
						}
						case 5:
							num = 7;
							continue;
						case 6:
							goto IL_10E;
						case 7:
							if (l.SelectionStart < l.Text.Length)
							{
								num = 4;
								continue;
							}
							goto IL_103;
						case 8:
							l.SelectedText = string.Empty;
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_101;
							default:
								if (false)
								{
								}
								num = 1;
								continue;
							}
							break;
						}
						break;
						IL_103:
						num = 6;
						continue;
						IL_101:
						goto IL_103;
					}
				}
				IL_10E:;
			}
			catch (global::System.Exception)
			{
			}
			if (true)
			{
			}
		}

		// Token: 0x060003CB RID: 971 RVA: 0x0003F84C File Offset: 0x0003DA4C
		public void r()
		{
			int num = 1;
			for (;;)
			{
				switch (num)
				{
				case 0:
					return;
				case 2:
					for (;;)
					{
						base.Undo();
						this.z = false;
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						}
						break;
					}
					IL_63:
					if (false)
					{
					}
					num = 0;
					continue;
					goto IL_63;
				}
				if (!this.z)
				{
					break;
				}
				if (true)
				{
				}
				num = 2;
			}
		}

		// Token: 0x060003CC RID: 972 RVA: 0x0003F8CC File Offset: 0x0003DACC
		public void a(object A_0, global::System.EventArgs A_1)
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
			base.SelectAll();
		}

		// Token: 0x060003CD RID: 973 RVA: 0x0003F910 File Offset: 0x0003DB10
		public void c(object A_0, global::System.EventArgs A_1)
		{
			for (;;)
			{
				base.Focus();
				int num = 7;
				for (;;)
				{
					string value;
					switch (num)
					{
					case 0:
						if (this.z)
						{
							num = 3;
							continue;
						}
						goto IL_186;
					case 1:
						this.l.Enabled = false;
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_4C;
						default:
							if (true)
							{
							}
							if (false)
							{
							}
							num = 2;
							continue;
						}
						break;
					case 2:
						goto IL_11E;
					case 3:
						goto IL_148;
					case 4:
						goto IL_11E;
					case 5:
						goto IL_14A;
					case 6:
						goto IL_14A;
					case 7:
						if (string.IsNullOrEmpty(this.SelectedText))
						{
							goto IL_4C;
						}
						this.j.Enabled = true;
						this.k.Enabled = true;
						this.m.Enabled = true;
						num = 5;
						continue;
					case 8:
						this.j.Enabled = false;
						this.k.Enabled = false;
						this.m.Enabled = false;
						num = 6;
						continue;
					case 9:
						if (string.IsNullOrEmpty(value))
						{
							num = 1;
							continue;
						}
						this.l.Enabled = true;
						num = 4;
						continue;
					}
					break;
					IL_4C:
					num = 8;
					continue;
					IL_11E:
					this.o.Enabled = true;
					num = 0;
					continue;
					IL_14A:
					value = (string)global::System.Windows.Forms.Clipboard.GetDataObject().GetData(global::System.Windows.Forms.DataFormats.UnicodeText, true);
					num = 9;
				}
			}
			IL_148:
			this.h.Enabled = true;
			return;
			IL_186:
			this.h.Enabled = false;
		}

		// Token: 0x04000291 RID: 657
		private const string a = "&Undo";

		// Token: 0x04000292 RID: 658
		private const string b = "Cu&t";

		// Token: 0x04000293 RID: 659
		private const string c = "&Copy";

		// Token: 0x04000294 RID: 660
		private const string d = "&Paste";

		// Token: 0x04000295 RID: 661
		private const string e = "&Delete";

		// Token: 0x04000296 RID: 662
		private const string f = "Select &All";

		// Token: 0x04000297 RID: 663
		public const int g = 4194304;

		// Token: 0x04000298 RID: 664
		public global::System.Windows.Forms.ToolStripMenuItem h;

		// Token: 0x04000299 RID: 665
		public global::System.Windows.Forms.ToolStripSeparator i;

		// Token: 0x0400029A RID: 666
		public global::System.Windows.Forms.ToolStripMenuItem j;

		// Token: 0x0400029B RID: 667
		public global::System.Windows.Forms.ToolStripMenuItem k;

		// Token: 0x0400029C RID: 668
		public global::System.Windows.Forms.ToolStripMenuItem l;

		// Token: 0x0400029D RID: 669
		public global::System.Windows.Forms.ToolStripMenuItem m;

		// Token: 0x0400029E RID: 670
		public global::System.Windows.Forms.ToolStripSeparator n;

		// Token: 0x0400029F RID: 671
		public global::System.Windows.Forms.ToolStripMenuItem o;

		// Token: 0x040002A0 RID: 672
		private global::custom_controls.b p;

		// Token: 0x040002A1 RID: 673
		private global::custom_controls.e q;

		// Token: 0x040002A2 RID: 674
		private global::custom_controls.AddressType r;

		// Token: 0x040002A3 RID: 675
		private string s;

		// Token: 0x040002A4 RID: 676
		private bool t;

		// Token: 0x040002A5 RID: 677
		private int u = -1;

		// Token: 0x040002A6 RID: 678
		private bool v;

		// Token: 0x040002A7 RID: 679
		private int w;

		// Token: 0x040002A8 RID: 680
		private int x = 255;

		// Token: 0x040002A9 RID: 681
		private bool y;

		// Token: 0x040002AA RID: 682
		private bool z;

		// Token: 0x040002AB RID: 683
		private bool aa;

		// Token: 0x040002AC RID: 684
		private int ab;

		// Token: 0x040002AD RID: 685
		private global::System.ComponentModel.Container ac;

		// Token: 0x0200005A RID: 90
		public enum a
		{
			// Token: 0x040002AF RID: 687
			a,
			// Token: 0x040002B0 RID: 688
			b = 255
		}
	}
}
