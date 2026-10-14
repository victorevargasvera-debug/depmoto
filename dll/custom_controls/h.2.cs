using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace custom_controls
{
	// Token: 0x02000054 RID: 84
	internal class h : global::System.Windows.Forms.Control
	{
		// Token: 0x0600038C RID: 908 RVA: 0x0003CD3C File Offset: 0x0003AF3C
		public bool c()
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

		// Token: 0x0600038D RID: 909 RVA: 0x0003CD80 File Offset: 0x0003AF80
		public void b(bool A_0)
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
			this.b = A_0;
			base.Invalidate();
		}

		// Token: 0x0600038E RID: 910 RVA: 0x0003CDC8 File Offset: 0x0003AFC8
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
			base.Size = this.b();
		}

		// Token: 0x0600038F RID: 911 RVA: 0x0003CE18 File Offset: 0x0003B018
		public override string ToString()
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
			return this.Text;
		}

		// Token: 0x06000390 RID: 912 RVA: 0x0003CE5C File Offset: 0x0003B05C
		public h()
		{
			this.a();
			this.Font = global::System.Windows.Forms.Control.DefaultFont;
			base.TabStop = false;
			this.Text = ".";
			base.Size = this.b();
			base.SetStyle(global::System.Windows.Forms.ControlStyles.DoubleBuffer, true);
			base.SetStyle(global::System.Windows.Forms.ControlStyles.UserPaint, true);
			base.SetStyle(global::System.Windows.Forms.ControlStyles.AllPaintingInWmPaint, true);
		}

		// Token: 0x06000391 RID: 913 RVA: 0x0003CEC0 File Offset: 0x0003B0C0
		protected virtual void a(global::System.EventArgs A_0)
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
			base.Size = this.b();
			base.Invalidate();
		}

		// Token: 0x06000392 RID: 914 RVA: 0x0003CF10 File Offset: 0x0003B110
		private global::System.Drawing.Size b()
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
			return global::custom_controls.n.a(base.Handle, this.Font, this.Text);
		}

		// Token: 0x06000393 RID: 915 RVA: 0x0003CF64 File Offset: 0x0003B164
		protected virtual void a(global::System.Windows.Forms.PaintEventArgs A_0)
		{
			switch (0)
			{
			default:
				for (;;)
				{
					global::System.Drawing.SolidBrush solidBrush = null;
					global::System.Drawing.SolidBrush solidBrush2 = null;
					int num = 11;
					for (;;)
					{
						global::System.Drawing.Color foreColor;
						global::System.Drawing.StringFormat stringFormat;
						switch (num)
						{
						case 0:
							goto IL_1B8;
						case 1:
							goto IL_1B8;
						case 2:
							goto IL_204;
						case 3:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_288;
							default:
								if (true)
								{
								}
								if (false)
								{
								}
								goto IL_1E1;
							}
							break;
						case 4:
							solidBrush = new global::System.Drawing.SolidBrush(global::System.Drawing.Color.FromKnownColor(global::System.Drawing.KnownColor.Control));
							num = 9;
							continue;
						case 5:
						{
							global::System.Drawing.Color backColor;
							if (backColor.ToKnownColor() == global::System.Drawing.KnownColor.Window)
							{
								num = 10;
								continue;
							}
							solidBrush = new global::System.Drawing.SolidBrush(this.BackColor);
							solidBrush2 = new global::System.Drawing.SolidBrush(this.ForeColor);
							num = 7;
							continue;
						}
						case 6:
							solidBrush.Dispose();
							goto IL_288;
						case 7:
							goto IL_1B8;
						case 8:
							num = 14;
							continue;
						case 9:
							goto IL_204;
						case 10:
							solidBrush = new global::System.Drawing.SolidBrush(global::System.Drawing.Color.FromKnownColor(global::System.Drawing.KnownColor.Control));
							solidBrush2 = new global::System.Drawing.SolidBrush(global::System.Drawing.Color.FromKnownColor(global::System.Drawing.KnownColor.WindowText));
							num = 1;
							continue;
						case 11:
						{
							if (base.Enabled)
							{
								num = 8;
								continue;
							}
							global::System.Drawing.Color backColor2 = this.BackColor;
							num = 16;
							continue;
						}
						case 12:
							if (solidBrush != null)
							{
								num = 6;
								continue;
							}
							return;
						case 13:
							return;
						case 14:
							if (this.c())
							{
								num = 21;
								continue;
							}
							solidBrush = new global::System.Drawing.SolidBrush(this.BackColor);
							solidBrush2 = new global::System.Drawing.SolidBrush(this.ForeColor);
							num = 20;
							continue;
						case 15:
							if (foreColor.ToKnownColor() == global::System.Drawing.KnownColor.Control)
							{
								num = 17;
								continue;
							}
							solidBrush2 = new global::System.Drawing.SolidBrush(global::System.Drawing.Color.FromKnownColor(global::System.Drawing.KnownColor.InactiveCaption));
							num = 0;
							continue;
						case 16:
						{
							global::System.Drawing.Color backColor2;
							if (backColor2.ToKnownColor() == global::System.Drawing.KnownColor.Window)
							{
								num = 4;
								continue;
							}
							solidBrush = new global::System.Drawing.SolidBrush(this.BackColor);
							num = 2;
							continue;
						}
						case 17:
							goto IL_10E;
						case 18:
							if (solidBrush2 != null)
							{
								num = 22;
								continue;
							}
							goto IL_1E1;
						case 19:
							try
							{
								stringFormat.Alignment = global::System.Drawing.StringAlignment.Center;
								A_0.Graphics.DrawString(this.Text, this.Font, solidBrush2, base.ClientRectangle, stringFormat);
								goto IL_25F;
							}
							finally
							{
								num = 0;
								for (;;)
								{
									switch (num)
									{
									case 1:
										((global::System.IDisposable)stringFormat).Dispose();
										num = 2;
										continue;
									case 2:
										goto IL_10B;
									}
									if (stringFormat == null)
									{
										break;
									}
									num = 1;
								}
								IL_10B:;
							}
							goto IL_10E;
							IL_25F:
							num = 18;
							continue;
						case 20:
							goto IL_1B8;
						case 21:
						{
							global::System.Drawing.Color backColor = this.BackColor;
							num = 5;
							continue;
						}
						case 22:
							solidBrush2.Dispose();
							num = 3;
							continue;
						case 23:
							goto IL_1B8;
						}
						break;
						IL_10E:
						solidBrush2 = new global::System.Drawing.SolidBrush(this.ForeColor);
						num = 23;
						continue;
						IL_1B8:
						A_0.Graphics.FillRectangle(solidBrush, base.ClientRectangle);
						stringFormat = new global::System.Drawing.StringFormat();
						num = 19;
						continue;
						IL_1E1:
						num = 12;
						continue;
						IL_204:
						foreColor = this.ForeColor;
						num = 15;
						continue;
						IL_288:
						num = 13;
					}
				}
				return;
			}
		}

		// Token: 0x06000394 RID: 916 RVA: 0x0003D300 File Offset: 0x0003B500
		protected virtual void a(bool A_0)
		{
			int num = 2;
			for (;;)
			{
				switch (num)
				{
				case 0:
					if (this.a != null)
					{
						num = 4;
						continue;
					}
					goto IL_91;
				case 1:
					num = 0;
					continue;
				case 3:
					goto IL_68;
				case 4:
					this.a.Dispose();
					if (true)
					{
					}
					num = 3;
					continue;
				}
				if (!A_0)
				{
					break;
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
					break;
				}
			}
			IL_68:
			IL_91:
			base.Dispose(A_0);
		}

		// Token: 0x06000395 RID: 917 RVA: 0x0003D3A8 File Offset: 0x0003B5A8
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
			base.Name = "CDotControl";
			base.Size = new global::System.Drawing.Size(8, 17);
		}

		// Token: 0x04000289 RID: 649
		private global::System.ComponentModel.Container a;

		// Token: 0x0400028A RID: 650
		private bool b;
	}
}
