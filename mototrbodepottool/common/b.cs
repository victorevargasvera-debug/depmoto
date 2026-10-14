using System;
using System.Drawing;
using System.Windows.Forms;

namespace common
{
	// Token: 0x02000005 RID: 5
	internal class b
	{
		// Token: 0x06000017 RID: 23 RVA: 0x000033D8 File Offset: 0x000023D8
		private b()
		{
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000033EC File Offset: 0x000023EC
		public static double a(global::System.Windows.Forms.Control A_0, bool A_1)
		{
			double result;
			for (;;)
			{
				result = 1.0;
				int num = 6;
				for (;;)
				{
					switch (num)
					{
					case 0:
						if (true)
						{
						}
						result = global::common.b.d;
						num = 1;
						continue;
					case 1:
						return result;
					case 2:
						return result;
					case 3:
						num = 7;
						continue;
					case 4:
						goto IL_EA;
					case 5:
						if (A_1)
						{
							num = 0;
							continue;
						}
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_4D;
						default:
							if (false)
							{
							}
							result = global::common.b.c;
							num = 2;
							continue;
						}
						break;
					case 6:
						if (global::common.b.a != 0f)
						{
							goto IL_4D;
						}
						goto IL_EA;
					case 7:
						if (global::common.b.b == 0f)
						{
							num = 4;
							continue;
						}
						goto IL_7C;
					case 8:
						goto IL_7C;
					}
					break;
					IL_4D:
					num = 3;
					continue;
					IL_7C:
					num = 5;
					continue;
					IL_EA:
					global::System.Drawing.Graphics graphics = A_0.CreateGraphics();
					global::common.b.a = graphics.DpiX;
					global::common.b.b = graphics.DpiY;
					global::common.b.c = (double)global::common.b.a / 96.0;
					global::common.b.d = (double)global::common.b.b / 96.0;
					graphics.Dispose();
					num = 8;
				}
			}
			return result;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00003544 File Offset: 0x00002544
		public static int a(global::System.Windows.Forms.Control A_0, int A_1, bool A_2)
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
			double num = global::common.b.a(A_0, A_2);
			return (int)((double)A_1 * num);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00003590 File Offset: 0x00002590
		public static void b(global::System.Windows.Forms.Control A_0)
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
			int x = global::common.b.a(A_0, A_0.Location.X, false);
			int y = global::common.b.a(A_0, A_0.Location.Y, true);
			A_0.Location = new global::System.Drawing.Point(x, y);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00003604 File Offset: 0x00002604
		public static void a(global::System.Windows.Forms.Control A_0)
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
			A_0.Width = global::common.b.a(A_0, A_0.Width, false);
			A_0.Height = global::common.b.a(A_0, A_0.Height, true);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00003668 File Offset: 0x00002668
		// Note: this type is marked as 'beforefieldinit'.
		static b()
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
			global::common.b.a = 0f;
			global::common.b.b = 0f;
			global::common.b.c = 1.0;
			global::common.b.d = 1.0;
		}

		// Token: 0x04000013 RID: 19
		private static float a;

		// Token: 0x04000014 RID: 20
		private static float b;

		// Token: 0x04000015 RID: 21
		private static double c;

		// Token: 0x04000016 RID: 22
		private static double d;
	}
}
