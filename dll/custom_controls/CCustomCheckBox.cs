using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace custom_controls
{
	// Token: 0x02000009 RID: 9
	public class CCustomCheckBox : global::System.Windows.Forms.CheckBox
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000020 RID: 32 RVA: 0x000058DC File Offset: 0x00003ADC
		// (set) Token: 0x06000021 RID: 33 RVA: 0x00005920 File Offset: 0x00003B20
		public string ResourceId
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
						return;
					case 1:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_69;
						default:
							if (false)
							{
							}
							if (true)
							{
							}
							break;
						}
						break;
					case 2:
						this.d = value;
						goto IL_69;
					}
					if (this.d != value)
					{
						num = 2;
						continue;
					}
					break;
					IL_69:
					num = 0;
				}
			}
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000059A0 File Offset: 0x00003BA0
		public CCustomCheckBox(global::System.ComponentModel.IContainer container)
		{
			container.Add(this);
			this.a();
			this.d = string.Empty;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000059CC File Offset: 0x00003BCC
		public CCustomCheckBox()
		{
			this.a();
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000059E8 File Offset: 0x00003BE8
		protected override void Dispose(bool disposing)
		{
			int num = 2;
			for (;;)
			{
				switch (num)
				{
				case 0:
					goto IL_4E;
				case 1:
					this.c.Dispose();
					num = 0;
					continue;
				case 3:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_31;
					default:
						if (false)
						{
						}
						if (true)
						{
						}
						if (this.c != null)
						{
							num = 1;
							continue;
						}
						goto IL_91;
					}
					break;
				case 4:
					num = 3;
					continue;
				}
				goto IL_2E;
				IL_31:
				num = 4;
				continue;
				IL_2E:
				if (disposing)
				{
					goto IL_31;
				}
				break;
			}
			IL_4E:
			IL_91:
			base.Dispose(disposing);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00005A90 File Offset: 0x00003C90
		protected override void OnPaint(global::System.Windows.Forms.PaintEventArgs e)
		{
			switch (0)
			{
			default:
				for (;;)
				{
					global::System.Drawing.Rectangle clientRectangle = base.ClientRectangle;
					global::System.Drawing.Rectangle rectangle = clientRectangle;
					global::System.Drawing.Graphics graphics = e.Graphics;
					base.OnPaint(e);
					int num = 23;
					for (;;)
					{
						int width;
						int x;
						int y;
						switch (num)
						{
						case 0:
						{
							global::System.Drawing.ContentAlignment checkAlign;
							if (checkAlign != global::System.Drawing.ContentAlignment.BottomRight)
							{
								num = 4;
								continue;
							}
							x = clientRectangle.Right - width - 1;
							y = clientRectangle.Bottom - width;
							num = 7;
							continue;
						}
						case 1:
							num = 2;
							continue;
						case 2:
						{
							global::System.Drawing.ContentAlignment checkAlign;
							if (checkAlign != global::System.Drawing.ContentAlignment.MiddleLeft)
							{
								num = 6;
								continue;
							}
							x = clientRectangle.Left;
							y = (clientRectangle.Height - width) / 2;
							num = 32;
							continue;
						}
						case 3:
							goto IL_25C;
						case 4:
							num = 29;
							continue;
						case 5:
						{
							global::System.Drawing.ContentAlignment checkAlign;
							if (checkAlign != global::System.Drawing.ContentAlignment.MiddleRight)
							{
								num = 13;
								continue;
							}
							x = clientRectangle.Right - width - 1;
							y = (clientRectangle.Height - width) / 2;
							num = 20;
							continue;
						}
						case 6:
							num = 18;
							continue;
						case 7:
							goto IL_25C;
						case 8:
							goto IL_25C;
						case 9:
							num = 31;
							continue;
						case 10:
						{
							global::System.Drawing.ContentAlignment checkAlign;
							if (checkAlign != global::System.Drawing.ContentAlignment.BottomCenter)
							{
								num = 26;
								continue;
							}
							x = (int)global::System.Math.Floor((double)clientRectangle.Width / 2.0 - (double)(width / 2)) - 1;
							y = clientRectangle.Bottom - width;
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_25A;
							default:
								if (false)
								{
								}
								num = 16;
								continue;
							}
							break;
						}
						case 11:
							num = 17;
							continue;
						case 12:
						{
							global::System.Drawing.ContentAlignment checkAlign;
							if (checkAlign != global::System.Drawing.ContentAlignment.BottomLeft)
							{
								num = 11;
								continue;
							}
							x = clientRectangle.Left;
							y = clientRectangle.Bottom - width;
							num = 27;
							continue;
						}
						case 13:
							num = 12;
							continue;
						case 14:
						{
							global::System.Drawing.ContentAlignment checkAlign;
							if (checkAlign <= global::System.Drawing.ContentAlignment.BottomLeft)
							{
								num = 28;
								continue;
							}
							if (true)
							{
							}
							num = 10;
							continue;
						}
						case 15:
							goto IL_25C;
						case 16:
							goto IL_25C;
						case 17:
							goto IL_25C;
						case 18:
						{
							global::System.Drawing.ContentAlignment checkAlign;
							if (checkAlign != global::System.Drawing.ContentAlignment.MiddleCenter)
							{
								num = 24;
								continue;
							}
							x = (int)global::System.Math.Floor((double)(clientRectangle.Right - clientRectangle.Left) / 2.0 - (double)(width / 2)) - 1;
							y = (clientRectangle.Height - width) / 2;
							num = 15;
							continue;
						}
						case 19:
							return;
						case 20:
							goto IL_25C;
						case 21:
						{
							x = 0;
							y = 0;
							width = global::System.Windows.Forms.SystemInformation.MenuCheckSize.Width;
							global::System.Drawing.ContentAlignment checkAlign = base.CheckAlign;
							num = 25;
							continue;
						}
						case 22:
							goto IL_25A;
						case 23:
							if (this.Focused)
							{
								num = 21;
								continue;
							}
							return;
						case 24:
							num = 8;
							continue;
						case 25:
						{
							global::System.Drawing.ContentAlignment checkAlign;
							if (checkAlign <= global::System.Drawing.ContentAlignment.MiddleCenter)
							{
								num = 9;
								continue;
							}
							num = 14;
							continue;
						}
						case 26:
							num = 0;
							continue;
						case 27:
							goto IL_25C;
						case 28:
							num = 5;
							continue;
						case 29:
							goto IL_25C;
						case 30:
							goto IL_25C;
						case 31:
						{
							global::System.Drawing.ContentAlignment checkAlign;
							switch (checkAlign)
							{
							case global::System.Drawing.ContentAlignment.TopLeft:
								x = clientRectangle.Left;
								y = clientRectangle.Top + 2;
								num = 30;
								continue;
							case global::System.Drawing.ContentAlignment.TopCenter:
								x = (int)global::System.Math.Floor((double)clientRectangle.Width / 2.0 - (double)(width / 2)) - 1;
								y = clientRectangle.Top + 2;
								num = 22;
								continue;
							case (global::System.Drawing.ContentAlignment)3:
								goto IL_25C;
							case global::System.Drawing.ContentAlignment.TopRight:
								x = clientRectangle.Right - width - 1;
								y = clientRectangle.Top + 2;
								num = 3;
								continue;
							default:
								num = 1;
								continue;
							}
							break;
						}
						case 32:
							goto IL_25C;
						}
						break;
						IL_25C:
						rectangle = new global::System.Drawing.Rectangle(x, y, width, width);
						global::System.Windows.Forms.ControlPaint.DrawFocusRectangle(e.Graphics, rectangle);
						num = 19;
						continue;
						IL_25A:
						goto IL_25C;
					}
				}
				return;
			}
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00005F34 File Offset: 0x00004134
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
			this.c = new global::System.ComponentModel.Container();
		}

		// Token: 0x04000034 RID: 52
		private const int a = 2;

		// Token: 0x04000035 RID: 53
		private const int b = 1;

		// Token: 0x04000036 RID: 54
		private global::System.ComponentModel.Container c;

		// Token: 0x04000037 RID: 55
		private string d;
	}
}
