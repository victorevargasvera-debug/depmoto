using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace custom_controls
{
	// Token: 0x02000086 RID: 134
	public class Quadrilateral : global::System.IDisposable
	{
		// Token: 0x060005BA RID: 1466 RVA: 0x000563B4 File Offset: 0x000545B4
		protected Quadrilateral()
		{
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x000563D4 File Offset: 0x000545D4
		public Quadrilateral(global::System.Drawing.PointF point1, global::System.Drawing.PointF point2, global::System.Drawing.PointF point3, global::System.Drawing.PointF point4, bool toClose)
		{
			byte[] array = (byte[])global::custom_controls.Quadrilateral.c.Clone();
			if (toClose)
			{
				byte[] array2 = array;
				int num = 3;
				array2[num] |= 128;
			}
			this.a = new global::System.Drawing.Drawing2D.GraphicsPath(new global::System.Drawing.PointF[]
			{
				point1,
				point2,
				point3,
				point4
			}, array);
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x0005646C File Offset: 0x0005466C
		~Quadrilateral()
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

		// Token: 0x060005BD RID: 1469 RVA: 0x000564C8 File Offset: 0x000546C8
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

		// Token: 0x060005BE RID: 1470 RVA: 0x00056510 File Offset: 0x00054710
		protected virtual void Dispose(bool disposing)
		{
			int num = 0;
			for (;;)
			{
				switch (num)
				{
				case 1:
					goto IL_3A;
				case 2:
					if (true)
					{
					}
					if (disposing)
					{
						num = 4;
						continue;
					}
					goto IL_3A;
				case 3:
					goto IL_7C;
				case 4:
					this.a.Dispose();
					num = 1;
					continue;
				case 5:
					return;
				}
				if (!this.b)
				{
					num = 3;
					continue;
				}
				break;
				IL_3A:
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_7C:
					num = 2;
					break;
				default:
					if (false)
					{
					}
					this.b = true;
					num = 5;
					break;
				}
			}
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x000565C4 File Offset: 0x000547C4
		public void Draw(global::System.Drawing.Graphics graphics, global::System.Drawing.Pen pen, global::System.Drawing.Brush brush)
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
			graphics.FillPath(brush, this.a);
			graphics.DrawPath(pen, this.a);
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x0005661C File Offset: 0x0005481C
		public bool Contains(global::System.Drawing.PointF point)
		{
			int num = 1;
			for (;;)
			{
				switch (num)
				{
				case 0:
					num = 3;
					continue;
				case 2:
					goto IL_86;
				case 3:
					if (this.a.PathPoints.Length == 0)
					{
						num = 2;
						continue;
					}
					goto IL_88;
				}
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
					if (this.a.PointCount == 0)
					{
						return false;
					}
					break;
				}
				num = 0;
			}
			return false;
			IL_86:
			return false;
			IL_88:
			return global::custom_controls.Quadrilateral.Contains(point, this.a.PathPoints);
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x000566C4 File Offset: 0x000548C4
		public static bool Contains(global::System.Drawing.PointF point, global::System.Drawing.PointF[] cornerPoints)
		{
			int num;
			for (;;)
			{
				num = 0;
				int num2 = 1;
				int num3 = 0;
				for (;;)
				{
					switch (num3)
					{
					case 0:
						goto IL_118;
					case 1:
						goto IL_8C;
					case 2:
						num3 = 3;
						continue;
					case 3:
						if (global::custom_controls.Quadrilateral.a(point, cornerPoints[cornerPoints.Length - 1], cornerPoints[0]))
						{
							num3 = 7;
							continue;
						}
						goto IL_13C;
					case 4:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							if (false)
							{
							}
							num++;
							num3 = 1;
							continue;
						}
						break;
					case 5:
						if (num2 >= cornerPoints.Length)
						{
							num3 = 2;
							continue;
						}
						num3 = 6;
						continue;
					case 6:
						if (global::custom_controls.Quadrilateral.a(point, cornerPoints[num2], cornerPoints[num2 - 1]))
						{
							num3 = 4;
							continue;
						}
						goto IL_8C;
					case 7:
						if (true)
						{
						}
						num++;
						num3 = 9;
						continue;
					case 8:
						goto IL_118;
					case 9:
						goto IL_102;
					}
					break;
					IL_8C:
					num2++;
					num3 = 8;
					continue;
					IL_118:
					num3 = 5;
				}
			}
			IL_102:
			IL_13C:
			return num % 2 != 0;
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x00056818 File Offset: 0x00054A18
		private static bool a(global::System.Drawing.PointF A_0, global::System.Drawing.PointF A_1, global::System.Drawing.PointF A_2)
		{
			switch (0)
			{
			default:
			{
				float x;
				float y;
				float x2;
				float y2;
				for (;;)
				{
					x = A_2.X;
					y = A_2.Y;
					x2 = A_1.X;
					y2 = A_1.Y;
					int num = 6;
					for (;;)
					{
						switch (num)
						{
						case 0:
							if (x2 < A_0.X)
							{
								num = 4;
								continue;
							}
							goto IL_10F;
						case 1:
							goto IL_BD;
						case 2:
							num = 3;
							continue;
						case 3:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_10D;
							default:
								if (false)
								{
								}
								if (x2 < A_0.X)
								{
									num = 1;
									continue;
								}
								return false;
							}
							break;
						case 4:
							goto IL_10D;
						case 5:
							num = 0;
							continue;
						case 6:
							if (x < A_0.X)
							{
								num = 5;
								continue;
							}
							goto IL_BF;
						case 7:
							if (x >= A_0.X)
							{
								num = 2;
								continue;
							}
							return false;
						}
						break;
						IL_BF:
						if (true)
						{
						}
						num = 7;
						continue;
						IL_10D:
						goto IL_BF;
					}
				}
				IL_BD:
				IL_10F:
				float num2 = (y - y2) / (x - x2) * (A_0.X - x2) + y2;
				return num2 > A_0.Y;
			}
			}
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x00056958 File Offset: 0x00054B58
		// Note: this type is marked as 'beforefieldinit'.
		static Quadrilateral()
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
			global::custom_controls.Quadrilateral.c = new byte[]
			{
				0,
				1,
				1,
				129
			};
			global::custom_controls.Quadrilateral.Empty = new global::custom_controls.Quadrilateral();
		}

		// Token: 0x0400043E RID: 1086
		private global::System.Drawing.Drawing2D.GraphicsPath a = new global::System.Drawing.Drawing2D.GraphicsPath();

		// Token: 0x0400043F RID: 1087
		private bool b;

		// Token: 0x04000440 RID: 1088
		private static byte[] c;

		// Token: 0x04000441 RID: 1089
		public static readonly global::custom_controls.Quadrilateral Empty;
	}
}
