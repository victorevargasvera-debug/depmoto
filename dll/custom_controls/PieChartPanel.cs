using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Windows.Forms;

namespace custom_controls
{
	// Token: 0x02000083 RID: 131
	public class PieChartPanel : global::System.Windows.Forms.Panel
	{
		// Token: 0x06000558 RID: 1368 RVA: 0x00052470 File Offset: 0x00050670
		public PieChartPanel()
		{
			float[] array = new float[1];
			this.j = array;
			this.m = global::custom_controls.ShadowStyle.GradualShadow;
			this.n = global::custom_controls.EdgeColorType.SystemColor;
			this.o = 1f;
			this.q = -1;
			base..ctor();
			base.SetStyle(global::System.Windows.Forms.ControlStyles.UserPaint, true);
			base.SetStyle(global::System.Windows.Forms.ControlStyles.AllPaintingInWmPaint, true);
			base.SetStyle(global::System.Windows.Forms.ControlStyles.DoubleBuffer, true);
			base.SetStyle(global::System.Windows.Forms.ControlStyles.ResizeRedraw, true);
			this.r = new global::System.Windows.Forms.ToolTip();
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x0600055A RID: 1370 RVA: 0x00052530 File Offset: 0x00050730
		// (set) Token: 0x06000559 RID: 1369 RVA: 0x000524E8 File Offset: 0x000506E8
		public float LeftMargin
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
				base.Invalidate();
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x0600055C RID: 1372 RVA: 0x000525BC File Offset: 0x000507BC
		// (set) Token: 0x0600055B RID: 1371 RVA: 0x00052574 File Offset: 0x00050774
		public float RightMargin
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
				return this.d;
			}
			set
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
				this.d = value;
				base.Invalidate();
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x0600055E RID: 1374 RVA: 0x00052648 File Offset: 0x00050848
		// (set) Token: 0x0600055D RID: 1373 RVA: 0x00052600 File Offset: 0x00050800
		public float TopMargin
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
				base.Invalidate();
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x06000560 RID: 1376 RVA: 0x000526D4 File Offset: 0x000508D4
		// (set) Token: 0x0600055F RID: 1375 RVA: 0x0005268C File Offset: 0x0005088C
		public float BottomMargin
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
				return this.e;
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
				this.e = value;
				base.Invalidate();
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x06000562 RID: 1378 RVA: 0x00052760 File Offset: 0x00050960
		// (set) Token: 0x06000561 RID: 1377 RVA: 0x00052718 File Offset: 0x00050918
		public bool FitChart
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
				return this.f;
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
				this.f = value;
				base.Invalidate();
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x06000564 RID: 1380 RVA: 0x000527EC File Offset: 0x000509EC
		// (set) Token: 0x06000563 RID: 1379 RVA: 0x000527A4 File Offset: 0x000509A4
		public decimal[] Values
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
				if (true)
				{
				}
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				this.g = value;
				base.Invalidate();
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x06000566 RID: 1382 RVA: 0x00052878 File Offset: 0x00050A78
		// (set) Token: 0x06000565 RID: 1381 RVA: 0x00052830 File Offset: 0x00050A30
		public global::System.Drawing.Color[] Colors
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
				return this.h;
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
				this.h = value;
				base.Invalidate();
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000568 RID: 1384 RVA: 0x00052904 File Offset: 0x00050B04
		// (set) Token: 0x06000567 RID: 1383 RVA: 0x000528BC File Offset: 0x00050ABC
		public float[] SliceRelativeDisplacements
		{
			get
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
				return this.j;
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
				this.j = value;
				base.Invalidate();
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x0600056A RID: 1386 RVA: 0x0005298C File Offset: 0x00050B8C
		// (set) Token: 0x06000569 RID: 1385 RVA: 0x00052948 File Offset: 0x00050B48
		public string[] ToolTips
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
				return this.l;
			}
			set
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
				this.l = value;
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x0600056C RID: 1388 RVA: 0x00052A14 File Offset: 0x00050C14
		// (set) Token: 0x0600056B RID: 1387 RVA: 0x000529D0 File Offset: 0x00050BD0
		public string[] Texts
		{
			get
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
				return this.k;
			}
			set
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
				this.k = value;
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x0600056E RID: 1390 RVA: 0x00052AA0 File Offset: 0x00050CA0
		// (set) Token: 0x0600056D RID: 1389 RVA: 0x00052A58 File Offset: 0x00050C58
		public float SliceRelativeHeight
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
				return this.i;
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
				this.i = value;
				base.Invalidate();
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x06000570 RID: 1392 RVA: 0x00052B2C File Offset: 0x00050D2C
		// (set) Token: 0x0600056F RID: 1391 RVA: 0x00052AE4 File Offset: 0x00050CE4
		public global::custom_controls.ShadowStyle ShadowStyle
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
				return this.m;
			}
			set
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
				this.m = value;
				base.Invalidate();
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x06000572 RID: 1394 RVA: 0x00052BB8 File Offset: 0x00050DB8
		// (set) Token: 0x06000571 RID: 1393 RVA: 0x00052B70 File Offset: 0x00050D70
		public global::custom_controls.EdgeColorType EdgeColorType
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
				return this.n;
			}
			set
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
				this.n = value;
				base.Invalidate();
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000574 RID: 1396 RVA: 0x00052C44 File Offset: 0x00050E44
		// (set) Token: 0x06000573 RID: 1395 RVA: 0x00052BFC File Offset: 0x00050DFC
		public float EdgeLineWidth
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
				return this.o;
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
				this.o = value;
				base.Invalidate();
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000576 RID: 1398 RVA: 0x00052CD0 File Offset: 0x00050ED0
		// (set) Token: 0x06000575 RID: 1397 RVA: 0x00052C88 File Offset: 0x00050E88
		public float InitialAngle
		{
			get
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
				return this.p;
			}
			set
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
				this.p = value;
				base.Invalidate();
			}
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x00052D14 File Offset: 0x00050F14
		protected override void OnPaint(global::System.Windows.Forms.PaintEventArgs args)
		{
			for (;;)
			{
				IL_00:
				if (true)
				{
				}
				for (;;)
				{
					base.OnPaint(args);
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_00;
					}
					if (false)
					{
					}
					int num = 0;
					for (;;)
					{
						switch (num)
						{
						case 0:
							if (this.HasAnyValue)
							{
								num = 2;
								continue;
							}
							return;
						case 1:
							return;
						case 2:
							this.DoDraw(args.Graphics);
							num = 1;
							continue;
						}
						break;
					}
				}
			}
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x00052D9C File Offset: 0x00050F9C
		protected void DoDraw(global::System.Drawing.Graphics graphics)
		{
			try
			{
				switch (0)
				{
				default:
				{
					int num = 1;
					for (;;)
					{
						float num2;
						float num3;
						switch (num)
						{
						case 0:
							if (this.a != null)
							{
								num = 17;
								continue;
							}
							goto IL_1BE;
						case 2:
							goto IL_1E3;
						case 3:
							if (num2 <= 0f)
							{
								num = 12;
								continue;
							}
							num = 0;
							continue;
						case 4:
							goto IL_2B1;
						case 5:
							num = 15;
							continue;
						case 6:
							if (this.h.Length > 0)
							{
								num = 13;
								continue;
							}
							goto IL_162;
						case 7:
							goto IL_1E3;
						case 8:
							num = 6;
							continue;
						case 9:
							num = 3;
							continue;
						case 10:
							goto IL_37C;
						case 11:
							if (num3 > 0f)
							{
								num = 9;
								continue;
							}
							goto IL_2A5;
						case 12:
							goto IL_2A5;
						case 13:
							this.a = new global::custom_controls.PieChart3D(this.b, this.c, num3, num2, this.g, this.h, this.i, this.k);
							num = 7;
							continue;
						case 14:
							goto IL_1BE;
						case 15:
							if (graphics != null)
							{
								num = 19;
								continue;
							}
							goto IL_370;
						case 16:
							num = 20;
							continue;
						case 17:
							this.a.Dispose();
							num = 14;
							continue;
						case 18:
							goto IL_370;
						case 19:
							graphics.SmoothingMode = global::System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
							num3 = (float)base.ClientSize.Width - this.b - this.d;
							num2 = (float)base.ClientSize.Height - this.c - this.e;
							num = 11;
							continue;
						case 20:
							if (this.g.Length > 0)
							{
								num = 5;
								continue;
							}
							goto IL_370;
						case 21:
							if (this.h != null)
							{
								num = 8;
								continue;
							}
							goto IL_162;
						}
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_37C;
						default:
							if (false)
							{
							}
							if (this.g != null)
							{
								num = 16;
								continue;
							}
							goto IL_370;
						}
						IL_162:
						this.a = new global::custom_controls.PieChart3D(this.b, this.c, num3, num2, this.g, this.i, this.k);
						num = 2;
						continue;
						IL_1BE:
						num = 21;
						continue;
						IL_1E3:
						this.a.FitToBoundingRectangle = this.f;
						this.a.InitialAngle = this.p;
						this.a.SliceRelativeDisplacements = this.j;
						this.a.EdgeColorType = this.n;
						this.a.EdgeLineWidth = this.o;
						this.a.ShadowStyle = this.m;
						this.a.HighlightedIndex = this.q;
						this.a.Draw(graphics);
						this.a.Font = this.Font;
						this.a.ForeColor = this.ForeColor;
						this.a.PlaceTexts(graphics);
						num = 18;
						continue;
						IL_2A5:
						num = 4;
						continue;
						IL_370:
						num = 10;
					}
					IL_2B1:
					IL_37C:
					break;
				}
				}
			}
			catch
			{
			}
			if (true)
			{
			}
		}

		// Token: 0x06000579 RID: 1401 RVA: 0x00053158 File Offset: 0x00051358
		protected override void OnMouseEnter(global::System.EventArgs e)
		{
			try
			{
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				base.OnMouseEnter(e);
				this.s = this.r.AutoPopDelay;
				this.r.AutoPopDelay = 32767;
			}
			catch
			{
			}
			if (true)
			{
			}
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x000531D0 File Offset: 0x000513D0
		protected override void OnMouseLeave(global::System.EventArgs e)
		{
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
				base.OnMouseLeave(e);
				this.r.RemoveAll();
				this.r.AutoPopDelay = this.s;
				this.q = -1;
				this.Refresh();
			}
			catch
			{
			}
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x00053250 File Offset: 0x00051450
		protected override void OnMouseMove(global::System.Windows.Forms.MouseEventArgs e)
		{
			try
			{
				for (;;)
				{
					base.OnMouseMove(e);
					int num = 1;
					for (;;)
					{
						switch (num)
						{
						case 0:
						{
							int num2;
							if (num2 != this.q)
							{
								num = 13;
								continue;
							}
							goto IL_1C6;
						}
						case 1:
							if (this.a != null)
							{
								num = 4;
								continue;
							}
							goto IL_275;
						case 2:
							if (this.g == null)
							{
								goto IL_275;
							}
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_1D1;
							default:
								if (false)
								{
								}
								num = 17;
								continue;
							}
							break;
						case 3:
							num = 14;
							continue;
						case 4:
							num = 2;
							continue;
						case 5:
						{
							if (true)
							{
							}
							int num2 = this.a.FindPieSliceUnderPoint(new global::System.Drawing.PointF((float)e.X, (float)e.Y));
							num = 0;
							continue;
						}
						case 6:
							goto IL_174;
						case 7:
							goto IL_280;
						case 8:
							goto IL_1D1;
						case 9:
							goto IL_275;
						case 10:
							goto IL_275;
						case 11:
							if (this.l != null)
							{
								num = 15;
								continue;
							}
							goto IL_174;
						case 12:
							if (this.l.Length > this.q)
							{
								num = 3;
								continue;
							}
							goto IL_174;
						case 13:
						{
							int num2;
							this.q = num2;
							this.Refresh();
							num = 18;
							continue;
						}
						case 14:
							if (this.l[this.q].Length == 0)
							{
								num = 6;
								continue;
							}
							this.r.SetToolTip(this, this.l[this.q]);
							num = 10;
							continue;
						case 15:
							num = 12;
							continue;
						case 16:
							if (this.g.Length > 0)
							{
								num = 5;
								continue;
							}
							goto IL_275;
						case 17:
							num = 16;
							continue;
						case 18:
							goto IL_1C6;
						case 19:
							goto IL_275;
						case 20:
							num = 11;
							continue;
						}
						break;
						IL_174:
						this.r.SetToolTip(this, this.g[this.q].ToString(global::System.Globalization.NumberFormatInfo.CurrentInfo));
						num = 19;
						continue;
						IL_1D1:
						if (this.q != -1)
						{
							num = 20;
							continue;
						}
						this.r.RemoveAll();
						num = 9;
						continue;
						IL_1C6:
						num = 8;
						continue;
						IL_275:
						num = 7;
					}
				}
				IL_280:;
			}
			catch
			{
			}
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x00053508 File Offset: 0x00051708
		protected override void Dispose(bool disposing)
		{
			if (!this.t)
			{
				try
				{
					int num = 3;
					for (;;)
					{
						switch (num)
						{
						case 0:
							if (this.r != null)
							{
								num = 6;
								continue;
							}
							goto IL_B2;
						case 1:
							if (this.a != null)
							{
								num = 5;
								continue;
							}
							goto IL_92;
						case 2:
							IL_7B:
							goto IL_B2;
						case 4:
							goto IL_E0;
						case 5:
							this.a.Dispose();
							num = 8;
							continue;
						case 6:
							this.r.Dispose();
							num = 2;
							continue;
						case 7:
							num = 1;
							continue;
						case 8:
							goto IL_92;
						}
						if (disposing)
						{
							num = 7;
							continue;
						}
						goto IL_B2;
						IL_92:
						num = 0;
						continue;
						IL_B2:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_7B;
						default:
							if (false)
							{
							}
							this.t = true;
							num = 4;
							break;
						}
					}
					IL_E0:;
				}
				finally
				{
					base.Dispose(disposing);
				}
			}
			if (true)
			{
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x0600057D RID: 1405 RVA: 0x00053624 File Offset: 0x00051824
		private bool HasAnyValue
		{
			get
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
						IL_100:
						num = 7;
						break;
					default:
						if (false)
						{
						}
						if (true)
						{
						}
						num = 3;
						break;
					}
					for (;;)
					{
						int num2;
						decimal[] array;
						switch (num)
						{
						case 0:
						{
							decimal d;
							if (d != 0m)
							{
								goto IL_100;
							}
							num2++;
							num = 4;
							continue;
						}
						case 1:
						{
							bool result;
							return result;
						}
						case 2:
							return false;
						case 4:
							goto IL_B9;
						case 5:
						{
							if (num2 >= array.Length)
							{
								num = 8;
								continue;
							}
							decimal d = array[num2];
							num = 0;
							continue;
						}
						case 6:
							goto IL_B9;
						case 7:
						{
							bool result = true;
							num = 1;
							continue;
						}
						case 8:
							return false;
						}
						if (this.g == null)
						{
							num = 2;
							continue;
						}
						array = this.g;
						num2 = 0;
						num = 6;
						continue;
						IL_B9:
						num = 5;
					}
					return false;
				}
				}
			}
		}

		// Token: 0x0400040C RID: 1036
		private global::custom_controls.PieChart3D a;

		// Token: 0x0400040D RID: 1037
		private float b;

		// Token: 0x0400040E RID: 1038
		private float c;

		// Token: 0x0400040F RID: 1039
		private float d;

		// Token: 0x04000410 RID: 1040
		private float e;

		// Token: 0x04000411 RID: 1041
		private bool f;

		// Token: 0x04000412 RID: 1042
		private decimal[] g;

		// Token: 0x04000413 RID: 1043
		private global::System.Drawing.Color[] h;

		// Token: 0x04000414 RID: 1044
		private float i;

		// Token: 0x04000415 RID: 1045
		private float[] j;

		// Token: 0x04000416 RID: 1046
		private string[] k;

		// Token: 0x04000417 RID: 1047
		private string[] l;

		// Token: 0x04000418 RID: 1048
		private global::custom_controls.ShadowStyle m;

		// Token: 0x04000419 RID: 1049
		private global::custom_controls.EdgeColorType n;

		// Token: 0x0400041A RID: 1050
		private float o;

		// Token: 0x0400041B RID: 1051
		private float p;

		// Token: 0x0400041C RID: 1052
		private int q;

		// Token: 0x0400041D RID: 1053
		private global::System.Windows.Forms.ToolTip r;

		// Token: 0x0400041E RID: 1054
		private int s;

		// Token: 0x0400041F RID: 1055
		private bool t;
	}
}
