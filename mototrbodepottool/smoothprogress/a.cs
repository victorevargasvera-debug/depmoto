using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace smoothprogress
{
	// Token: 0x02000004 RID: 4
	public class a : global::System.Windows.Forms.UserControl
	{
		// Token: 0x0600000B RID: 11 RVA: 0x00002B40 File Offset: 0x00001B40
		public a()
		{
			this.a();
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002B64 File Offset: 0x00001B64
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
			base.Invalidate();
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002BA8 File Offset: 0x00001BA8
		protected override void OnPaint(global::System.Windows.Forms.PaintEventArgs e)
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
			global::System.Drawing.Graphics graphics = e.Graphics;
			global::System.Drawing.SolidBrush solidBrush = new global::System.Drawing.SolidBrush(global::System.Drawing.SystemColors.ActiveCaption);
			float num = (float)(this.c - this.a) / (float)(this.b - this.a);
			global::System.Drawing.Rectangle clientRectangle = base.ClientRectangle;
			clientRectangle.Width = (int)((float)clientRectangle.Width * num);
			graphics.FillRectangle(solidBrush, clientRectangle);
			this.a(graphics);
			solidBrush.Dispose();
			graphics.Dispose();
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002C48 File Offset: 0x00001C48
		public int c()
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
			return this.a;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002C8C File Offset: 0x00001C8C
		public void a(int A_0)
		{
			int num = 3;
			for (;;)
			{
				switch (num)
				{
				case 0:
					this.c = this.a;
					goto IL_A0;
				case 1:
					if (A_0 > this.b)
					{
						num = 2;
						continue;
					}
					goto IL_45;
				case 2:
					this.a = A_0;
					this.a = A_0;
					num = 5;
					continue;
				case 4:
					this.a = 0;
					num = 8;
					continue;
				case 5:
					goto IL_45;
				case 6:
					if (this.c < this.a)
					{
						num = 0;
						continue;
					}
					goto IL_102;
				case 7:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_A0;
					default:
						goto IL_C1;
					}
					break;
				case 8:
					goto IL_C9;
				}
				if (A_0 < 0)
				{
					num = 4;
					continue;
				}
				goto IL_C9;
				IL_45:
				num = 6;
				continue;
				IL_A0:
				num = 7;
				continue;
				IL_C9:
				if (true)
				{
				}
				num = 1;
			}
			IL_C1:
			if (false)
			{
			}
			IL_102:
			base.Invalidate();
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002DA4 File Offset: 0x00001DA4
		public int b()
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

		// Token: 0x06000011 RID: 17 RVA: 0x00002DE8 File Offset: 0x00001DE8
		public void b(int A_0)
		{
			int num = 5;
			for (;;)
			{
				switch (num)
				{
				case 0:
					this.a = A_0;
					num = 3;
					continue;
				case 1:
					if (this.c > this.b)
					{
						goto IL_9C;
					}
					goto IL_BD;
				case 2:
					if (true)
					{
					}
					this.c = this.b;
					num = 4;
					continue;
				case 3:
					goto IL_7F;
				case 4:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_9C;
					default:
						goto IL_77;
					}
					break;
				}
				if (A_0 < this.a)
				{
					num = 0;
					continue;
				}
				IL_7F:
				this.b = A_0;
				num = 1;
				continue;
				IL_9C:
				num = 2;
			}
			IL_77:
			if (false)
			{
			}
			IL_BD:
			base.Invalidate();
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002EB8 File Offset: 0x00001EB8
		public int d()
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

		// Token: 0x06000013 RID: 19 RVA: 0x00002EFC File Offset: 0x00001EFC
		public void c(int A_0)
		{
			switch (0)
			{
			default:
			{
				global::System.Drawing.Rectangle rc;
				for (;;)
				{
					int num = this.c;
					int num2 = 3;
					for (;;)
					{
						global::System.Drawing.Rectangle clientRectangle;
						global::System.Drawing.Rectangle clientRectangle2;
						switch (num2)
						{
						case 0:
							goto IL_20B;
						case 1:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_68;
							}
							if (false)
							{
							}
							goto IL_6D;
						case 2:
							if (clientRectangle.Width > clientRectangle2.Width)
							{
								num2 = 6;
								continue;
							}
							rc.X = clientRectangle.Size.Width;
							rc.Width = clientRectangle2.Width - clientRectangle.Width;
							if (true)
							{
							}
							num2 = 8;
							continue;
						case 3:
							if (A_0 < this.a)
							{
								num2 = 5;
								continue;
							}
							num2 = 9;
							continue;
						case 4:
							goto IL_6D;
						case 5:
							goto IL_68;
						case 6:
							rc.X = clientRectangle2.Size.Width;
							rc.Width = clientRectangle.Width - clientRectangle2.Width;
							num2 = 0;
							continue;
						case 7:
							goto IL_6D;
						case 8:
							goto IL_18A;
						case 9:
							if (A_0 > this.b)
							{
								num2 = 10;
								continue;
							}
							this.c = A_0;
							num2 = 4;
							continue;
						case 10:
							this.c = this.b;
							num2 = 7;
							continue;
						}
						break;
						IL_68:
						this.c = this.a;
						num2 = 1;
						continue;
						IL_6D:
						clientRectangle = base.ClientRectangle;
						clientRectangle2 = base.ClientRectangle;
						float num3 = (float)(this.c - this.a) / (float)(this.b - this.a);
						clientRectangle.Width = (int)((float)clientRectangle.Width * num3);
						num3 = (float)(num - this.a) / (float)(this.b - this.a);
						clientRectangle2.Width = (int)((float)clientRectangle2.Width * num3);
						rc = default(global::System.Drawing.Rectangle);
						num2 = 2;
					}
				}
				IL_18A:
				IL_20B:
				rc.Height = base.Height;
				base.Invalidate(rc);
				return;
			}
			}
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00003148 File Offset: 0x00002148
		private void a(global::System.Drawing.Graphics A_0)
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
			int num = (int)global::System.Drawing.Pens.White.Width;
			A_0.DrawLine(global::System.Drawing.Pens.DarkGray, new global::System.Drawing.Point(base.ClientRectangle.Left, base.ClientRectangle.Top), new global::System.Drawing.Point(base.ClientRectangle.Width - num, base.ClientRectangle.Top));
			A_0.DrawLine(global::System.Drawing.Pens.DarkGray, new global::System.Drawing.Point(base.ClientRectangle.Left, base.ClientRectangle.Top), new global::System.Drawing.Point(base.ClientRectangle.Left, base.ClientRectangle.Height - num));
			A_0.DrawLine(global::System.Drawing.Pens.White, new global::System.Drawing.Point(base.ClientRectangle.Left, base.ClientRectangle.Height - num), new global::System.Drawing.Point(base.ClientRectangle.Width - num, base.ClientRectangle.Height - num));
			A_0.DrawLine(global::System.Drawing.Pens.White, new global::System.Drawing.Point(base.ClientRectangle.Width - num, base.ClientRectangle.Top), new global::System.Drawing.Point(base.ClientRectangle.Width - num, base.ClientRectangle.Height - num));
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000032E0 File Offset: 0x000022E0
		protected override void Dispose(bool disposing)
		{
			int num = 2;
			for (;;)
			{
				switch (num)
				{
				case 0:
					goto IL_6A;
				case 1:
					num = 3;
					continue;
				case 3:
					if (true)
					{
					}
					if (this.d != null)
					{
						num = 4;
						continue;
					}
					goto IL_91;
				case 4:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					}
					if (false)
					{
					}
					this.d.Dispose();
					num = 0;
					continue;
				}
				if (!disposing)
				{
					break;
				}
				num = 1;
			}
			IL_6A:
			IL_91:
			base.Dispose(disposing);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00003388 File Offset: 0x00002388
		private void a()
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
			this.d = new global::System.ComponentModel.Container();
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		}

		// Token: 0x0400000F RID: 15
		private int a;

		// Token: 0x04000010 RID: 16
		private int b = 100;

		// Token: 0x04000011 RID: 17
		private int c;

		// Token: 0x04000012 RID: 18
		private global::System.ComponentModel.IContainer d;
	}
}
