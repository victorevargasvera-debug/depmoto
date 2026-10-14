using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace custom_controls
{
	// Token: 0x02000084 RID: 132
	public class PieSlice : global::System.IDisposable, global::System.ICloneable
	{
		// Token: 0x0600057E RID: 1406 RVA: 0x00053740 File Offset: 0x00051940
		protected PieSlice()
		{
		}

		// Token: 0x0600057F RID: 1407 RVA: 0x00053774 File Offset: 0x00051974
		public PieSlice(float xBoundingRect, float yBoundingRect, float widthBoundingRect, float heightBoundingRect, float startAngle, float sweepAngle, global::System.Drawing.Color surfaceColor) : this(xBoundingRect, yBoundingRect, widthBoundingRect, heightBoundingRect, 0f, startAngle, sweepAngle, surfaceColor, global::custom_controls.ShadowStyle.NoShadow, global::custom_controls.EdgeColorType.NoEdge)
		{
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x0005379C File Offset: 0x0005199C
		public PieSlice(float xBoundingRect, float yBoundingRect, float widthBoundingRect, float heightBoundingRect, float sliceHeight, float startAngle, float sweepAngle, global::System.Drawing.Color aSurfaceColor, global::custom_controls.ShadowStyle aShadowStyle, global::custom_controls.EdgeColorType aEdgeColorType) : this()
		{
			this.e = startAngle;
			this.f = sweepAngle;
			this.g = aSurfaceColor;
			this.h = aShadowStyle;
			this.i = aEdgeColorType;
			global::System.Drawing.Color renderingColor = global::custom_controls.EdgeColor.GetRenderingColor(aEdgeColorType, this.g);
			this.o = new global::System.Drawing.Pen(renderingColor);
			this.o.LineJoin = global::System.Drawing.Drawing2D.LineJoin.Round;
			this.a(xBoundingRect, yBoundingRect, widthBoundingRect, heightBoundingRect, sliceHeight);
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x0005380C File Offset: 0x00051A0C
		public PieSlice(global::System.Drawing.RectangleF boundingRect, float sliceHeight, float startAngle, float sweepAngle, global::System.Drawing.Color surfaceColor, global::custom_controls.ShadowStyle shadowStyle, global::custom_controls.EdgeColorType edgeColorType) : this(boundingRect.X, boundingRect.Y, boundingRect.Width, boundingRect.Height, sliceHeight, startAngle, sweepAngle, surfaceColor, shadowStyle, edgeColorType)
		{
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x00053848 File Offset: 0x00051A48
		public PieSlice(float xBoundingRect, float yBoundingRect, float widthBoundingRect, float heightBoundingRect, float sliceHeight, float startAngle, float sweepAngle, global::System.Drawing.Color surfaceColor, global::custom_controls.ShadowStyle shadowStyle, global::custom_controls.EdgeColorType edgeColorType, float edgeLineWidth) : this(xBoundingRect, yBoundingRect, widthBoundingRect, heightBoundingRect, sliceHeight, startAngle, sweepAngle, surfaceColor, shadowStyle, edgeColorType)
		{
			this.o.Width = edgeLineWidth;
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x0005387C File Offset: 0x00051A7C
		public PieSlice(global::System.Drawing.Rectangle boundingRect, float sliceHeight, float startAngle, float sweepAngle, global::System.Drawing.Color surfaceColor, global::custom_controls.ShadowStyle shadowStyle, global::custom_controls.EdgeColorType edgeColorType, float edgeLineWidth) : this((float)boundingRect.X, (float)boundingRect.Y, (float)boundingRect.Width, (float)boundingRect.Height, sliceHeight, startAngle, sweepAngle, surfaceColor, shadowStyle, edgeColorType, edgeLineWidth)
		{
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x000538BC File Offset: 0x00051ABC
		~PieSlice()
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
			this.Dispose(false);
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x00053918 File Offset: 0x00051B18
		public void Dispose()
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
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x00053960 File Offset: 0x00051B60
		protected virtual void Dispose(bool disposing)
		{
			int num = 2;
			for (;;)
			{
				switch (num)
				{
				case 0:
					goto IL_3D;
				case 1:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_44;
					default:
						if (false)
						{
						}
						this.o.Dispose();
						this.DisposeBrushes();
						this.v.Dispose();
						this.w.Dispose();
						num = 0;
						continue;
					}
					break;
				case 3:
					num = 4;
					continue;
				case 4:
					if (true)
					{
					}
					if (disposing)
					{
						num = 1;
						continue;
					}
					goto IL_3D;
				case 5:
					return;
				}
				if (!this.y)
				{
					num = 3;
					continue;
				}
				break;
				IL_44:
				num = 5;
				continue;
				IL_3D:
				this.y = true;
				goto IL_44;
			}
		}

		// Token: 0x06000587 RID: 1415 RVA: 0x00053A38 File Offset: 0x00051C38
		public object Clone()
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
			return new global::custom_controls.PieSlice(this.BoundingRectangle, this.SliceHeight, this.StartAngle, this.SweepAngle, this.g, this.h, this.i);
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06000588 RID: 1416 RVA: 0x00053AA4 File Offset: 0x00051CA4
		public float StartAngle
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
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x06000589 RID: 1417 RVA: 0x00053AE8 File Offset: 0x00051CE8
		public float SweepAngle
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
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x0600058A RID: 1418 RVA: 0x00053B2C File Offset: 0x00051D2C
		public float EndAngle
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
				return (this.c + this.d) % 360f;
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x0600058B RID: 1419 RVA: 0x00053B7C File Offset: 0x00051D7C
		// (set) Token: 0x0600058C RID: 1420 RVA: 0x00053BC0 File Offset: 0x00051DC0
		public string Text
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
				return this.x;
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
				this.x = value;
			}
		}

		// Token: 0x0600058D RID: 1421 RVA: 0x00053C04 File Offset: 0x00051E04
		public void Draw(global::System.Drawing.Graphics graphics)
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
			this.a(graphics);
			this.b(graphics);
			this.d(graphics);
		}

		// Token: 0x0600058E RID: 1422 RVA: 0x00053C54 File Offset: 0x00051E54
		public bool Contains(global::System.Drawing.PointF point)
		{
			int num = 0;
			for (;;)
			{
				switch (num)
				{
				case 1:
					if (true)
					{
					}
					if (this.v.Contains(point))
					{
						num = 4;
						continue;
					}
					num = 7;
					continue;
				case 2:
					return true;
				case 3:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_C0;
					default:
						if (false)
						{
						}
						if (this.c(point))
						{
							num = 2;
							continue;
						}
						num = 1;
						continue;
					}
					break;
				case 4:
					return true;
				case 5:
					return true;
				case 6:
					return true;
				case 7:
					goto IL_C0;
				}
				if (this.e(point))
				{
					num = 5;
					continue;
				}
				num = 3;
				continue;
				IL_C0:
				if (!this.w.Contains(point))
				{
					return false;
				}
				num = 6;
			}
			return true;
		}

		// Token: 0x0600058F RID: 1423 RVA: 0x00053D40 File Offset: 0x00051F40
		public virtual global::System.Drawing.PointF GetTextPosition()
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
				if (this.SweepAngle < 180f)
				{
					float num = (this.r.X + this.t.X) / 2f;
					float num2 = (this.r.Y + this.t.Y) / 2f;
					float transformedAngle = (float)(global::System.Math.Atan2((double)(num2 - this.p.Y), (double)(num - this.p.X)) * 180.0 / 3.141592653589793);
					return this.PeripheralPoint(this.p.X, this.p.Y, this.a.Width / 3f, this.a.Height / 3f, this.GetActualAngle(transformedAngle));
				}
				break;
			}
			return this.PeripheralPoint(this.p.X, this.p.Y, this.a.Width / 3f, this.a.Height / 3f, this.GetActualAngle(this.StartAngle) + this.SweepAngle / 2f);
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000590 RID: 1424 RVA: 0x00053E9C File Offset: 0x0005209C
		// (set) Token: 0x06000591 RID: 1425 RVA: 0x00053EE0 File Offset: 0x000520E0
		internal global::System.Drawing.RectangleF BoundingRectangle
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
				return this.a;
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
				this.a = value;
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000592 RID: 1426 RVA: 0x00053F24 File Offset: 0x00052124
		// (set) Token: 0x06000593 RID: 1427 RVA: 0x00053F68 File Offset: 0x00052168
		internal float SliceHeight
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
				return this.b;
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
				this.b = value;
			}
		}

		// Token: 0x06000594 RID: 1428 RVA: 0x00053FAC File Offset: 0x000521AC
		internal void b(global::System.Drawing.Graphics A_0)
		{
			for (;;)
			{
				this.g(A_0);
				int num = 3;
				for (;;)
				{
					switch (num)
					{
					case 0:
						if (true)
						{
						}
						num = 2;
						continue;
					case 1:
						goto IL_89;
					case 2:
						if (this.StartAngle < 270f)
						{
							num = 4;
							continue;
						}
						goto IL_4E;
					case 3:
						if (this.StartAngle > 90f)
						{
							num = 0;
							continue;
						}
						goto IL_4E;
					case 4:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_CC;
						default:
							if (false)
							{
							}
							this.c(A_0);
							this.f(A_0);
							num = 1;
							continue;
						}
						break;
					case 5:
						goto IL_64;
					}
					break;
					IL_4E:
					this.f(A_0);
					this.c(A_0);
					num = 5;
				}
			}
			IL_64:
			IL_89:
			IL_CC:
			this.e(A_0);
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x0005408C File Offset: 0x0005228C
		internal global::custom_controls.PieSlice[] a(float A_0)
		{
			switch (0)
			{
			default:
			{
				int num = 3;
				for (;;)
				{
					switch (num)
					{
					case 0:
						num = 1;
						continue;
					case 1:
						if (this.EndAngle == A_0)
						{
							num = 2;
							continue;
						}
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_9B;
						}
						break;
					case 2:
						goto IL_83;
					}
					if (this.StartAngle == A_0)
					{
						break;
					}
					num = 0;
				}
				IL_44:
				return new global::custom_controls.PieSlice[]
				{
					(global::custom_controls.PieSlice)this.Clone()
				};
				IL_83:
				goto IL_44;
				IL_9B:
				if (false)
				{
				}
				if (true)
				{
				}
				this.TransformAngle(A_0);
				float actualAngle = this.GetActualAngle(this.StartAngle);
				float sweepAngle = (A_0 - actualAngle + 360f) % 360f;
				global::custom_controls.PieSlice pieSlice = new global::custom_controls.PieSlice(this.BoundingRectangle, this.SliceHeight, actualAngle, sweepAngle, this.g, this.h, this.i);
				pieSlice.a(true, false);
				sweepAngle = this.GetActualAngle(this.EndAngle) - A_0;
				global::custom_controls.PieSlice pieSlice2 = new global::custom_controls.PieSlice(this.BoundingRectangle, this.SliceHeight, A_0, sweepAngle, this.g, this.h, this.i);
				pieSlice2.a(false, true);
				return new global::custom_controls.PieSlice[]
				{
					pieSlice,
					pieSlice2
				};
			}
			}
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x000541E8 File Offset: 0x000523E8
		internal void b(float A_0, float A_1, float A_2, float A_3, float A_4)
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
			this.a(A_0, A_1, A_2, A_3, A_4);
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x00054230 File Offset: 0x00052430
		internal void f(global::System.Drawing.Graphics A_0)
		{
			int num = 0;
			for (;;)
			{
				switch (num)
				{
				case 1:
					num = 2;
					continue;
				case 2:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_41;
					default:
						if (false)
						{
						}
						if (this.StartAngle < 270f)
						{
							num = 3;
							continue;
						}
						goto IL_CF;
					}
					break;
				case 3:
					goto IL_A0;
				case 4:
					return;
				case 5:
					num = 6;
					continue;
				case 6:
					if (this.StartAngle > 90f)
					{
						num = 1;
						continue;
					}
					goto IL_CF;
				}
				goto IL_36;
				IL_41:
				num = 5;
				continue;
				IL_36:
				if (this.v != null)
				{
					goto IL_41;
				}
				return;
				IL_CF:
				this.v.Draw(A_0, this.o, this.j);
				num = 4;
			}
			IL_A0:
			if (true)
			{
			}
			this.v.Draw(A_0, this.o, this.l);
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x00054334 File Offset: 0x00052534
		internal void c(global::System.Drawing.Graphics A_0)
		{
			int num = 2;
			for (;;)
			{
				switch (num)
				{
				case 0:
					return;
				case 1:
					if (this.EndAngle > 90f)
					{
						num = 3;
						continue;
					}
					goto IL_C7;
				case 3:
					num = 6;
					continue;
				case 4:
					goto IL_A0;
				case 5:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						if (false)
						{
						}
						break;
					}
					num = 1;
					continue;
				case 6:
					if (this.EndAngle < 270f)
					{
						num = 4;
						continue;
					}
					goto IL_C7;
				}
				if (this.w != null)
				{
					num = 5;
					continue;
				}
				return;
				IL_C7:
				if (true)
				{
				}
				this.w.Draw(A_0, this.o, this.m);
				num = 0;
			}
			IL_A0:
			this.w.Draw(A_0, this.o, this.j);
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x00054438 File Offset: 0x00052638
		internal void e(global::System.Drawing.Graphics A_0)
		{
			switch (0)
			{
			default:
				if (true)
				{
				}
				for (;;)
				{
					global::custom_controls.PieSlice.a[] array = this.b();
					global::custom_controls.PieSlice.a[] array2 = array;
					int num = 0;
					int num2 = 1;
					for (;;)
					{
						switch (num2)
						{
						case 0:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_85;
							}
							goto Block_2;
						case 1:
							goto IL_45;
						case 2:
							goto IL_45;
						case 3:
							if (num >= array2.Length)
							{
								num2 = 0;
								continue;
							}
							goto IL_85;
						}
						break;
						IL_45:
						num2 = 3;
						continue;
						IL_85:
						global::custom_controls.PieSlice.a a = array2[num];
						this.DrawCylinderSurfaceSection(A_0, this.o, this.n, a.a(), a.d(), a.b(), a.c());
						num++;
						num2 = 2;
					}
				}
				Block_2:
				if (false)
				{
				}
				return;
			}
		}

		// Token: 0x0600059A RID: 1434 RVA: 0x0005451C File Offset: 0x0005271C
		internal void g(global::System.Drawing.Graphics A_0)
		{
			for (;;)
			{
				switch (0)
				{
				default:
					for (;;)
					{
						global::custom_controls.PieSlice.a[] array = this.a();
						global::custom_controls.PieSlice.a[] array2 = array;
						int num = 0;
						int num2 = 1;
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_55;
							case 1:
								goto IL_3D;
							case 2:
							{
								if (num >= array2.Length)
								{
									num2 = 0;
									continue;
								}
								global::custom_controls.PieSlice.a a = array2[num];
								this.DrawCylinderSurfaceSection(A_0, this.o, this.j, a.a(), a.d(), a.b(), a.c());
								num++;
								num2 = 3;
								continue;
							}
							case 3:
								goto IL_3D;
							}
							break;
							IL_3D:
							num2 = 2;
						}
					}
					IL_55:
					if (true)
					{
					}
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_CD;
					}
					break;
				}
			}
			IL_CD:
			if (false)
			{
			}
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x000545FC File Offset: 0x000527FC
		internal void a(global::System.Drawing.Graphics A_0)
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
			A_0.FillPie(this.j, this.a.X, this.a.Y + this.b, this.a.Width, this.a.Height, this.c, this.d);
			A_0.DrawPie(this.o, this.a.X, this.a.Y + this.b, this.a.Width, this.a.Height, this.c, this.d);
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x000546D0 File Offset: 0x000528D0
		internal void d(global::System.Drawing.Graphics A_0)
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
			A_0.FillPie(this.j, this.a.X, this.a.Y, this.a.Width, this.a.Height, this.c, this.d);
			A_0.DrawPie(this.o, this.a, this.c, this.d);
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x00054770 File Offset: 0x00052970
		internal global::System.Drawing.RectangleF d()
		{
			global::System.Drawing.RectangleF result;
			for (;;)
			{
				result = new global::System.Drawing.RectangleF(this.r.X, this.r.Y, 0f, 0f);
				int num = 1;
				for (;;)
				{
					switch (num)
					{
					case 0:
						if (this.c <= 90f)
						{
							num = 8;
							continue;
						}
						goto IL_29C;
					case 1:
						if (this.c != 0f)
						{
							num = 6;
							continue;
						}
						goto IL_176;
					case 2:
						if (this.c <= 180f)
						{
							num = 25;
							continue;
						}
						goto IL_26A;
					case 3:
						goto IL_29C;
					case 4:
						goto IL_2FD;
					case 5:
						if (this.c + this.d < 90f)
						{
							num = 3;
							continue;
						}
						goto IL_2FD;
					case 6:
						num = 17;
						continue;
					case 7:
						goto IL_1E1;
					case 8:
						if (true)
						{
						}
						num = 5;
						continue;
					case 9:
						goto IL_1DC;
					case 10:
						if (this.c + this.d < 270f)
						{
							num = 13;
							continue;
						}
						goto IL_1B9;
					case 11:
						goto IL_114;
					case 12:
						if (this.c <= 270f)
						{
							num = 15;
							continue;
						}
						goto IL_238;
					case 13:
						goto IL_238;
					case 14:
						goto IL_191;
					case 15:
						num = 10;
						continue;
					case 16:
						if (this.c + this.d < 180f)
						{
							num = 19;
							continue;
						}
						goto IL_C7;
					case 17:
						if (this.c + this.d >= 360f)
						{
							num = 24;
							continue;
						}
						goto IL_114;
					case 18:
						goto IL_C7;
					case 19:
						goto IL_26A;
					case 20:
						if (this.c + this.d >= 450f)
						{
							num = 4;
							continue;
						}
						goto IL_1E1;
					case 21:
						if (this.c + this.d >= 630f)
						{
							num = 22;
							continue;
						}
						goto IL_33E;
					case 22:
						goto IL_1B9;
					case 23:
						if (this.c + this.d >= 540f)
						{
							num = 18;
							continue;
						}
						goto IL_191;
					case 24:
						goto IL_176;
					case 25:
						num = 16;
						continue;
					}
					break;
					IL_C7:
					global::custom_controls.GraphicsUtil.IncludePointX(ref result, result.Left);
					num = 14;
					continue;
					IL_114:
					num = 0;
					continue;
					IL_176:
					global::custom_controls.GraphicsUtil.IncludePointX(ref result, result.Right);
					num = 11;
					continue;
					IL_191:
					num = 12;
					continue;
					IL_1B9:
					global::custom_controls.GraphicsUtil.IncludePointY(ref result, result.Top);
					num = 9;
					continue;
					IL_1E1:
					num = 2;
					continue;
					IL_238:
					num = 21;
					continue;
					IL_26A:
					num = 23;
					continue;
					IL_29C:
					num = 20;
					continue;
					IL_2FD:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_33E;
					default:
						if (false)
						{
						}
						global::custom_controls.GraphicsUtil.IncludePointY(ref result, result.Bottom + this.SliceHeight);
						num = 7;
						break;
					}
				}
			}
			IL_1DC:
			IL_33E:
			global::custom_controls.GraphicsUtil.IncludePoint(ref result, this.p);
			global::custom_controls.GraphicsUtil.IncludePoint(ref result, this.q);
			global::custom_controls.GraphicsUtil.IncludePoint(ref result, this.r);
			global::custom_controls.GraphicsUtil.IncludePoint(ref result, this.s);
			global::custom_controls.GraphicsUtil.IncludePoint(ref result, this.t);
			global::custom_controls.GraphicsUtil.IncludePoint(ref result, this.u);
			return result;
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x00054B0C File Offset: 0x00052D0C
		internal bool e(global::System.Drawing.PointF A_0)
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
			return this.a(A_0, this.a.X, this.a.Y, this.a.Width, this.a.Height, this.c, this.d);
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x00054B88 File Offset: 0x00052D88
		internal bool c(global::System.Drawing.PointF A_0)
		{
			switch (0)
			{
			default:
				for (;;)
				{
					global::custom_controls.PieSlice.a[] array = this.b();
					global::custom_controls.PieSlice.a[] array2 = array;
					int num = 0;
					int num2 = 2;
					for (;;)
					{
						IL_10:
						switch (num2)
						{
						case 0:
						{
							bool result;
							return result;
						}
						case 1:
						{
							bool result = true;
							num2 = 0;
							continue;
						}
						case 2:
							goto IL_4A;
						case 3:
							goto IL_63;
						case 4:
							goto IL_4A;
						case 5:
						{
							global::custom_controls.PieSlice.a a;
							while (this.a(A_0, a.a(), a.b(), a.c()))
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
									num2 = 1;
									goto IL_10;
								}
							}
							num++;
							num2 = 4;
							continue;
						}
						case 6:
						{
							if (num >= array2.Length)
							{
								num2 = 3;
								continue;
							}
							global::custom_controls.PieSlice.a a = array2[num];
							num2 = 5;
							continue;
						}
						}
						break;
						IL_4A:
						num2 = 6;
					}
				}
				IL_63:
				if (true)
				{
				}
				return false;
			}
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x00054C90 File Offset: 0x00052E90
		internal bool b(global::System.Drawing.PointF A_0)
		{
			if (this.b > 0f)
			{
				if (true)
				{
				}
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					return false;
				}
				if (false)
				{
				}
				return this.v.Contains(A_0);
			}
			return false;
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x00054CE8 File Offset: 0x00052EE8
		internal bool d(global::System.Drawing.PointF A_0)
		{
			if (true)
			{
			}
			if (this.b > 0f)
			{
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					return false;
				}
				if (false)
				{
				}
				return this.w.Contains(A_0);
			}
			return false;
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x00054D40 File Offset: 0x00052F40
		internal bool a(global::System.Drawing.PointF A_0)
		{
			if (this.b > 0f)
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
					return this.a(A_0, this.a.X, this.a.Y + this.b, this.a.Width, this.a.Height, this.c, this.d);
				}
			}
			return false;
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x00054DD4 File Offset: 0x00052FD4
		protected void CreateSurfaceBrushes(global::System.Drawing.Color surfaceColor, global::custom_controls.ShadowStyle shadowStyle)
		{
			switch (0)
			{
			default:
			{
				double num2;
				for (;;)
				{
					this.j = new global::System.Drawing.SolidBrush(surfaceColor);
					this.k = new global::System.Drawing.SolidBrush(global::custom_controls.ColorUtil.CreateColorWithCorrectedLightness(surfaceColor, global::custom_controls.ColorUtil.BrightnessEnhancementFactor1));
					int num = 7;
					for (;;)
					{
						switch (num)
						{
						case 0:
							goto IL_12A;
						case 1:
							num2 += 360.0;
							num = 0;
							continue;
						case 2:
							if (num2 < 0.0)
							{
								num = 6;
								continue;
							}
							goto IL_1C0;
						case 3:
							goto IL_7F;
						case 4:
							goto IL_124;
						case 5:
							if (num2 < 0.0)
							{
								num = 1;
								continue;
							}
							goto IL_12A;
						case 6:
							num2 += 360.0;
							num = 4;
							continue;
						case 7:
							switch (shadowStyle)
							{
							case global::custom_controls.ShadowStyle.NoShadow:
								goto IL_ED;
							case global::custom_controls.ShadowStyle.UniformShadow:
								goto IL_192;
							case global::custom_controls.ShadowStyle.GradualShadow:
								num2 = (double)(this.c - 180f - global::custom_controls.PieSlice.z);
								num = 5;
								continue;
							default:
								num = 3;
								continue;
							}
							break;
						}
						break;
						IL_12A:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							if (false)
							{
							}
							this.l = this.CreateBrushForSide(surfaceColor, num2);
							num2 = (double)(this.c + this.d - global::custom_controls.PieSlice.z);
							break;
						}
						num = 2;
					}
				}
				IL_7F:
				if (true)
				{
				}
				return;
				IL_ED:
				this.l = (this.m = (this.n = new global::System.Drawing.SolidBrush(surfaceColor)));
				return;
				IL_124:
				goto IL_1C0;
				IL_192:
				this.l = (this.m = (this.n = new global::System.Drawing.SolidBrush(global::custom_controls.ColorUtil.CreateColorWithCorrectedLightness(surfaceColor, -global::custom_controls.ColorUtil.BrightnessEnhancementFactor1))));
				return;
				IL_1C0:
				this.m = this.CreateBrushForSide(surfaceColor, num2);
				this.n = this.CreateBrushForPeriphery(surfaceColor);
				return;
			}
			}
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x00054FBC File Offset: 0x000531BC
		protected void DisposeBrushes()
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
			this.j.Dispose();
			this.l.Dispose();
			this.m.Dispose();
			this.n.Dispose();
			this.k.Dispose();
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x00055030 File Offset: 0x00053230
		protected global::System.Drawing.Brush CreateBrushForSide(global::System.Drawing.Color color, double angle)
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
			return new global::System.Drawing.SolidBrush(global::custom_controls.ColorUtil.CreateColorWithCorrectedLightness(color, -(float)((double)global::custom_controls.ColorUtil.BrightnessEnhancementFactor1 * (1.0 - 0.8 * global::System.Math.Cos(angle * 3.141592653589793 / 180.0)))));
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x000550B0 File Offset: 0x000532B0
		protected global::System.Drawing.Brush CreateBrushForPeriphery(global::System.Drawing.Color color)
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
			global::System.Drawing.Drawing2D.ColorBlend colorBlend = new global::System.Drawing.Drawing2D.ColorBlend();
			colorBlend.Colors = new global::System.Drawing.Color[]
			{
				global::custom_controls.ColorUtil.CreateColorWithCorrectedLightness(color, -global::custom_controls.ColorUtil.BrightnessEnhancementFactor1 / 2f),
				color,
				global::custom_controls.ColorUtil.CreateColorWithCorrectedLightness(color, -global::custom_controls.ColorUtil.BrightnessEnhancementFactor1)
			};
			colorBlend.Positions = new float[]
			{
				0f,
				0.1f,
				1f
			};
			return new global::System.Drawing.Drawing2D.LinearGradientBrush(this.a, global::System.Drawing.Color.Blue, global::System.Drawing.Color.White, global::System.Drawing.Drawing2D.LinearGradientMode.Horizontal)
			{
				InterpolationColors = colorBlend
			};
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x00055180 File Offset: 0x00053380
		protected void DrawCylinderSurfaceSection(global::System.Drawing.Graphics graphics, global::System.Drawing.Pen pen, global::System.Drawing.Brush brush, float startAngle, float endAngle, global::System.Drawing.PointF pointStart, global::System.Drawing.PointF pointEnd)
		{
			for (;;)
			{
				for (;;)
				{
					global::System.Drawing.Drawing2D.GraphicsPath path = this.a(startAngle, endAngle, pointStart, pointEnd);
					int num = 0;
					for (;;)
					{
						switch (num)
						{
						case 0:
							if (graphics != null)
							{
								num = 2;
								continue;
							}
							return;
						case 1:
							return;
						case 2:
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
								graphics.FillPath(brush, path);
								graphics.DrawPath(pen, path);
								num = 1;
								continue;
							}
							break;
						}
						break;
					}
				}
			}
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x00055210 File Offset: 0x00053410
		protected float TransformAngle(float angle)
		{
			if (true)
			{
			}
			switch ((1 == 1) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_A5;
			}
			if (false)
			{
			}
			double num = (double)this.a.Width * global::System.Math.Cos((double)angle * 3.141592653589793 / 180.0);
			double num2 = (double)this.a.Height * global::System.Math.Sin((double)angle * 3.141592653589793 / 180.0);
			float num3 = (float)(global::System.Math.Atan2(num2, num) * 180.0 / 3.141592653589793);
			if (num3 >= 0f)
			{
				return num3;
			}
			IL_A5:
			return num3 + 360f;
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x000552D0 File Offset: 0x000534D0
		protected float GetActualAngle(float transformedAngle)
		{
			float num3;
			switch ((1 == 1) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				if (true)
				{
				}
				if (false)
				{
				}
				double num = (double)this.a.Height * global::System.Math.Cos((double)transformedAngle * 3.141592653589793 / 180.0);
				double num2 = (double)this.a.Width * global::System.Math.Sin((double)transformedAngle * 3.141592653589793 / 180.0);
				num3 = (float)(global::System.Math.Atan2(num2, num) * 180.0 / 3.141592653589793);
				if (num3 >= 0f)
				{
					return num3;
				}
				break;
			}
			}
			return num3 + 360f;
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x00055390 File Offset: 0x00053590
		protected global::System.Drawing.PointF PeripheralPoint(float xCenter, float yCenter, float semiMajor, float semiMinor, float angleDegrees)
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
			double num = (double)angleDegrees * 3.141592653589793 / 180.0;
			return new global::System.Drawing.PointF(xCenter + (float)((double)semiMajor * global::System.Math.Cos(num)), yCenter + (float)((double)semiMinor * global::System.Math.Sin(num)));
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x00055404 File Offset: 0x00053604
		private void a(float A_0, float A_1, float A_2, float A_3, float A_4)
		{
			for (;;)
			{
				if (true)
				{
				}
				this.a = new global::System.Drawing.RectangleF(A_0, A_1, A_2, A_3);
				this.b = A_4;
				this.c = this.TransformAngle(this.e);
				this.d = this.f;
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
							goto IL_10E;
						default:
							if (false)
							{
							}
							this.d += 360f;
							num = 3;
							continue;
						}
						break;
					case 1:
						if (this.d < 0f)
						{
							num = 0;
							continue;
						}
						goto IL_11A;
					case 2:
						if (this.d % 180f != 0f)
						{
							num = 4;
							continue;
						}
						goto IL_BE;
					case 3:
						goto IL_BC;
					case 4:
						this.d = this.TransformAngle(this.e + this.f) - this.c;
						num = 5;
						continue;
					case 5:
						goto IL_10E;
					}
					break;
					IL_BE:
					num = 1;
					continue;
					IL_10E:
					goto IL_BE;
				}
			}
			IL_BC:
			IL_11A:
			this.CreateSurfaceBrushes(this.g, this.h);
			float xCenter = A_0 + A_2 / 2f;
			float num2 = A_1 + A_3 / 2f;
			this.p = new global::System.Drawing.PointF(xCenter, num2);
			this.q = new global::System.Drawing.PointF(xCenter, num2 + this.b);
			this.r = this.PeripheralPoint(xCenter, num2, A_2 / 2f, A_3 / 2f, this.e);
			this.s = new global::System.Drawing.PointF(this.r.X, this.r.Y + this.b);
			this.t = this.PeripheralPoint(xCenter, num2, A_2 / 2f, A_3 / 2f, this.e + this.f);
			this.u = new global::System.Drawing.PointF(this.t.X, this.t.Y + this.b);
			this.c();
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x00055618 File Offset: 0x00053818
		private void c()
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
			this.a(true, true);
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x0005565C File Offset: 0x0005385C
		private void a(bool A_0, bool A_1)
		{
			int num = 5;
			for (;;)
			{
				switch (num)
				{
				case 0:
					this.v = new global::custom_controls.Quadrilateral(this.p, this.r, this.s, this.q, this.d != 180f);
					num = 3;
					continue;
				case 1:
					if (A_1)
					{
						num = 2;
						continue;
					}
					goto IL_10A;
				case 2:
					goto IL_4B;
				case 3:
					goto IL_35;
				case 4:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_4B;
					default:
						if (false)
						{
						}
						goto IL_35;
					}
					break;
				}
				if (A_0)
				{
					num = 0;
					continue;
				}
				this.v = global::custom_controls.Quadrilateral.Empty;
				if (true)
				{
				}
				num = 4;
				continue;
				IL_35:
				num = 1;
			}
			IL_4B:
			this.w = new global::custom_controls.Quadrilateral(this.p, this.t, this.u, this.q, this.d != 180f);
			return;
			IL_10A:
			this.w = global::custom_controls.Quadrilateral.Empty;
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x00055780 File Offset: 0x00053980
		private global::custom_controls.PieSlice.a[] b()
		{
			switch (0)
			{
			default:
			{
				global::System.Collections.ArrayList arrayList;
				for (;;)
				{
					arrayList = new global::System.Collections.ArrayList();
					int num = 4;
					for (;;)
					{
						float num2;
						float a_;
						global::System.Drawing.PointF a_2;
						global::System.Drawing.PointF a_3;
						float a_4;
						global::System.Drawing.PointF a_5;
						switch (num)
						{
						case 0:
							goto IL_2A5;
						case 1:
							goto IL_227;
						case 2:
							goto IL_1BC;
						case 3:
							if (this.StartAngle < 180f)
							{
								num = 17;
								continue;
							}
							goto IL_1BC;
						case 4:
							if (this.d != 0f)
							{
								num = 12;
								continue;
							}
							goto IL_329;
						case 5:
							if (this.c >= 180f)
							{
								num = 7;
								continue;
							}
							goto IL_2A5;
						case 6:
							goto IL_1F8;
						case 7:
							num = 11;
							continue;
						case 8:
							goto IL_FB;
						case 9:
							if (num2 > 180f)
							{
								num = 14;
								continue;
							}
							goto IL_1F8;
						case 10:
							a_ = 180f;
							a_2.X = this.a.X;
							a_2.Y = this.p.Y;
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_1F3;
							default:
								if (false)
								{
								}
								num = 8;
								continue;
							}
							break;
						case 11:
							if (this.c + this.d > 360f)
							{
								num = 0;
								continue;
							}
							goto IL_329;
						case 12:
							num = 5;
							continue;
						case 13:
							goto IL_1F3;
						case 14:
							num2 = 180f;
							a_3.X = this.a.Left;
							a_3.Y = this.p.Y;
							num = 6;
							continue;
						case 15:
							if (this.c + this.d > 360f)
							{
								if (true)
								{
								}
								num = 13;
								continue;
							}
							goto IL_329;
						case 16:
							if (this.c + this.d > 180f)
							{
								num = 10;
								continue;
							}
							goto IL_FB;
						case 17:
							a_4 = this.c;
							a_5 = new global::System.Drawing.PointF(this.r.X, this.r.Y);
							a_ = this.EndAngle;
							a_2 = new global::System.Drawing.PointF(this.t.X, this.t.Y);
							num = 16;
							continue;
						}
						break;
						IL_FB:
						arrayList.Add(new global::custom_controls.PieSlice.a(a_4, a_, a_5, a_2));
						num = 2;
						continue;
						IL_1BC:
						num = 15;
						continue;
						IL_1F3:
						float a_6 = 0f;
						global::System.Drawing.PointF a_7 = new global::System.Drawing.PointF(this.a.Right, this.p.Y);
						num2 = this.EndAngle;
						a_3 = new global::System.Drawing.PointF(this.t.X, this.t.Y);
						num = 9;
						continue;
						IL_1F8:
						arrayList.Add(new global::custom_controls.PieSlice.a(a_6, num2, a_7, a_3));
						num = 1;
						continue;
						IL_2A5:
						num = 3;
					}
				}
				IL_227:
				IL_329:
				return (global::custom_controls.PieSlice.a[])arrayList.ToArray(typeof(global::custom_controls.PieSlice.a));
			}
			}
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x00055ACC File Offset: 0x00053CCC
		private global::custom_controls.PieSlice.a[] a()
		{
			switch (0)
			{
			default:
			{
				global::System.Collections.ArrayList arrayList;
				for (;;)
				{
					arrayList = new global::System.Collections.ArrayList();
					int num = 10;
					for (;;)
					{
						float num2;
						global::System.Drawing.PointF a_;
						float num3;
						global::System.Drawing.PointF a_2;
						switch (num)
						{
						case 0:
							if (num2 < 180f)
							{
								num = 2;
								continue;
							}
							goto IL_D0;
						case 1:
							goto IL_252;
						case 2:
							num2 = 180f;
							a_.X = this.a.Left;
							a_.Y = this.p.Y;
							num = 12;
							continue;
						case 3:
							if (this.c + this.d > 180f)
							{
								num = 13;
								continue;
							}
							goto IL_344;
						case 4:
							if (this.c < 360f)
							{
								num = 14;
								continue;
							}
							goto IL_344;
						case 5:
							if (num3 > 360f)
							{
								num = 16;
								continue;
							}
							goto IL_90;
						case 6:
							goto IL_2D5;
						case 7:
							num = 15;
							continue;
						case 8:
							if (true)
							{
							}
							num2 = 180f;
							a_ = new global::System.Drawing.PointF(this.a.Left, this.p.Y);
							num3 = this.EndAngle;
							a_2 = new global::System.Drawing.PointF(this.t.X, this.t.Y);
							arrayList.Add(new global::custom_controls.PieSlice.a(num2, num3, a_, a_2));
							num = 1;
							continue;
						case 9:
							if (this.c >= 0f)
							{
								num = 7;
								continue;
							}
							goto IL_2D5;
						case 10:
							if (this.d != 0f)
							{
								num = 11;
								continue;
							}
							goto IL_344;
						case 11:
							goto IL_8B;
						case 12:
							goto IL_D0;
						case 13:
							num2 = this.c;
							a_ = new global::System.Drawing.PointF(this.r.X, this.r.Y);
							num3 = this.c + this.d;
							a_2 = new global::System.Drawing.PointF(this.t.X, this.t.Y);
							num = 0;
							continue;
						case 14:
							num = 17;
							continue;
						case 15:
							if (this.c + this.d > 180f)
							{
								num = 6;
								continue;
							}
							goto IL_344;
						case 16:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_8B;
							default:
								if (false)
								{
								}
								num3 = 360f;
								a_2.X = this.a.Right;
								a_2.Y = this.p.Y;
								num = 18;
								continue;
							}
							break;
						case 17:
							if (this.c + this.d > 540f)
							{
								num = 8;
								continue;
							}
							goto IL_344;
						case 18:
							goto IL_90;
						}
						break;
						IL_8B:
						num = 9;
						continue;
						IL_90:
						arrayList.Add(new global::custom_controls.PieSlice.a(num2, num3, a_, a_2));
						num = 4;
						continue;
						IL_D0:
						num = 5;
						continue;
						IL_2D5:
						num = 3;
					}
				}
				IL_252:
				IL_344:
				return (global::custom_controls.PieSlice.a[])arrayList.ToArray(typeof(global::custom_controls.PieSlice.a));
			}
			}
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x00055E34 File Offset: 0x00054034
		private global::System.Drawing.Drawing2D.GraphicsPath a(float A_0, float A_1, global::System.Drawing.PointF A_2, global::System.Drawing.PointF A_3)
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
			global::System.Drawing.Drawing2D.GraphicsPath graphicsPath = new global::System.Drawing.Drawing2D.GraphicsPath();
			graphicsPath.AddArc(this.a, A_0, A_1 - A_0);
			graphicsPath.AddLine(A_3.X, A_3.Y, A_3.X, A_3.Y + this.b);
			graphicsPath.AddArc(this.a.X, this.a.Y + this.b, this.a.Width, this.a.Height, A_1, A_0 - A_1);
			graphicsPath.AddLine(A_2.X, A_2.Y + this.b, A_2.X, A_2.Y);
			return graphicsPath;
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x00055F18 File Offset: 0x00054118
		private bool a(global::System.Drawing.PointF A_0, float A_1, global::System.Drawing.PointF A_2, global::System.Drawing.PointF A_3)
		{
			if (this.b > 0f)
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
					return global::custom_controls.Quadrilateral.Contains(A_0, new global::System.Drawing.PointF[]
					{
						A_2,
						new global::System.Drawing.PointF(A_2.X, A_2.Y + this.b),
						new global::System.Drawing.PointF(A_3.X, A_3.Y + this.b),
						A_3
					});
				}
			}
			return false;
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x00055FDC File Offset: 0x000541DC
		private bool a(global::System.Drawing.PointF A_0, float A_1, float A_2, float A_3, float A_4, float A_5, float A_6)
		{
			switch (0)
			{
			default:
			{
				double num;
				double num2;
				double num3;
				for (;;)
				{
					num = (double)(A_0.X - A_1 - A_3 / 2f);
					num2 = (double)(A_0.Y - A_2 - A_4 / 2f);
					num3 = global::System.Math.Atan2(num2, num);
					int num4 = 2;
					for (;;)
					{
						double num5;
						switch (num4)
						{
						case 0:
							goto IL_9F;
						case 1:
							if (num5 + 360.0 <= (double)(A_5 + A_6))
							{
								num4 = 4;
								continue;
							}
							return false;
						case 2:
							if (true)
							{
							}
							if (num3 < 0.0)
							{
								num4 = 0;
								continue;
							}
							goto IL_132;
						case 3:
							if (A_5 + A_6 > 360f)
							{
								num4 = 8;
								continue;
							}
							return false;
						case 4:
							goto IL_CF;
						case 5:
							goto IL_16B;
						case 6:
							num4 = 10;
							continue;
						case 7:
							goto IL_132;
						case 8:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_9F;
							default:
								if (false)
								{
								}
								num4 = 1;
								continue;
							}
							break;
						case 9:
							if (num5 >= (double)A_5)
							{
								num4 = 6;
								continue;
							}
							goto IL_16B;
						case 10:
							if (num5 > (double)(A_5 + A_6))
							{
								num4 = 5;
								continue;
							}
							goto IL_118;
						}
						break;
						IL_9F:
						num3 += 6.283185307179586;
						num4 = 7;
						continue;
						IL_132:
						num5 = num3 * 180.0 / 3.141592653589793;
						num4 = 9;
						continue;
						IL_16B:
						num4 = 3;
					}
				}
				IL_CF:
				IL_118:
				double num6 = global::System.Math.Sqrt(num2 * num2 + num * num);
				return this.a(num3) > num6;
			}
			}
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x0005619C File Offset: 0x0005439C
		private double a(double A_0)
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
			double num = (double)(this.a.Width / 2f);
			double num2 = (double)(this.a.Height / 2f);
			double num3 = num * num;
			double num4 = num2 * num2;
			double num5 = global::System.Math.Cos(A_0);
			double num6 = global::System.Math.Sin(A_0);
			return num * num2 / global::System.Math.Sqrt(num4 * num5 * num5 + num3 * num6 * num6);
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x00056230 File Offset: 0x00054430
		// Note: this type is marked as 'beforefieldinit'.
		static PieSlice()
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
			global::custom_controls.PieSlice.z = 20f;
		}

		// Token: 0x04000420 RID: 1056
		private global::System.Drawing.RectangleF a;

		// Token: 0x04000421 RID: 1057
		private float b;

		// Token: 0x04000422 RID: 1058
		private float c;

		// Token: 0x04000423 RID: 1059
		private float d;

		// Token: 0x04000424 RID: 1060
		private float e;

		// Token: 0x04000425 RID: 1061
		private float f;

		// Token: 0x04000426 RID: 1062
		private global::System.Drawing.Color g = global::System.Drawing.Color.Empty;

		// Token: 0x04000427 RID: 1063
		private global::custom_controls.ShadowStyle h;

		// Token: 0x04000428 RID: 1064
		private global::custom_controls.EdgeColorType i;

		// Token: 0x04000429 RID: 1065
		private global::System.Drawing.Brush j;

		// Token: 0x0400042A RID: 1066
		private global::System.Drawing.Brush k;

		// Token: 0x0400042B RID: 1067
		private global::System.Drawing.Brush l;

		// Token: 0x0400042C RID: 1068
		private global::System.Drawing.Brush m;

		// Token: 0x0400042D RID: 1069
		private global::System.Drawing.Brush n;

		// Token: 0x0400042E RID: 1070
		private global::System.Drawing.Pen o;

		// Token: 0x0400042F RID: 1071
		private global::System.Drawing.PointF p;

		// Token: 0x04000430 RID: 1072
		private global::System.Drawing.PointF q;

		// Token: 0x04000431 RID: 1073
		private global::System.Drawing.PointF r;

		// Token: 0x04000432 RID: 1074
		private global::System.Drawing.PointF s;

		// Token: 0x04000433 RID: 1075
		private global::System.Drawing.PointF t;

		// Token: 0x04000434 RID: 1076
		private global::System.Drawing.PointF u;

		// Token: 0x04000435 RID: 1077
		private global::custom_controls.Quadrilateral v = global::custom_controls.Quadrilateral.Empty;

		// Token: 0x04000436 RID: 1078
		private global::custom_controls.Quadrilateral w = global::custom_controls.Quadrilateral.Empty;

		// Token: 0x04000437 RID: 1079
		private string x;

		// Token: 0x04000438 RID: 1080
		private bool y;

		// Token: 0x04000439 RID: 1081
		private static float z;

		// Token: 0x02000085 RID: 133
		private struct a
		{
			// Token: 0x060005B5 RID: 1461 RVA: 0x00056278 File Offset: 0x00054478
			public a(float A_0, float A_1, global::System.Drawing.PointF A_2, global::System.Drawing.PointF A_3)
			{
				this.a = A_0;
				this.b = A_1;
				this.c = A_2;
				this.d = A_3;
			}

			// Token: 0x060005B6 RID: 1462 RVA: 0x000562A4 File Offset: 0x000544A4
			public float a()
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
				return this.a;
			}

			// Token: 0x060005B7 RID: 1463 RVA: 0x000562E8 File Offset: 0x000544E8
			public float d()
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

			// Token: 0x060005B8 RID: 1464 RVA: 0x0005632C File Offset: 0x0005452C
			public global::System.Drawing.PointF b()
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
				return this.c;
			}

			// Token: 0x060005B9 RID: 1465 RVA: 0x00056370 File Offset: 0x00054570
			public global::System.Drawing.PointF c()
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

			// Token: 0x0400043A RID: 1082
			private float a;

			// Token: 0x0400043B RID: 1083
			private float b;

			// Token: 0x0400043C RID: 1084
			private global::System.Drawing.PointF c;

			// Token: 0x0400043D RID: 1085
			private global::System.Drawing.PointF d;
		}
	}
}
