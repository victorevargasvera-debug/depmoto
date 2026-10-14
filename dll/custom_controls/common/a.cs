using System;
using System.Drawing;
using System.Windows.Forms;

namespace common
{
	// Token: 0x02000003 RID: 3
	internal class a
	{
		// Token: 0x06000004 RID: 4 RVA: 0x00002120 File Offset: 0x00000320
		private a()
		{
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002134 File Offset: 0x00000334
		public static double a(global::System.Windows.Forms.Control A_0, bool A_1)
		{
			double result;
			for (;;)
			{
				result = 1.0;
				int num = 7;
				for (;;)
				{
					switch (num)
					{
					case 0:
						if (A_1)
						{
							num = 4;
							continue;
						}
						result = global::common.a.c;
						num = 1;
						continue;
					case 1:
						return result;
					case 2:
						if (global::common.a.b == 0f)
						{
							num = 6;
							continue;
						}
						goto IL_98;
					case 3:
						goto IL_98;
					case 4:
						result = global::common.a.d;
						num = 5;
						continue;
					case 5:
						return result;
					case 6:
						goto IL_EA;
					case 7:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							return result;
						default:
							if (false)
							{
							}
							if (true)
							{
							}
							if (global::common.a.a != 0f)
							{
								num = 8;
								continue;
							}
							goto IL_EA;
						}
						break;
					case 8:
						num = 2;
						continue;
					}
					break;
					IL_98:
					num = 0;
					continue;
					IL_EA:
					global::System.Drawing.Graphics graphics = A_0.CreateGraphics();
					global::common.a.a = graphics.DpiX;
					global::common.a.b = graphics.DpiY;
					global::common.a.c = (double)global::common.a.a / 96.0;
					global::common.a.d = (double)global::common.a.b / 96.0;
					graphics.Dispose();
					num = 3;
				}
			}
			return result;
		}

		// Token: 0x06000006 RID: 6 RVA: 0x0000228C File Offset: 0x0000048C
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
			double num = global::common.a.a(A_0, A_2);
			return (int)((double)A_1 * num);
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000022D8 File Offset: 0x000004D8
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
			int x = global::common.a.a(A_0, A_0.Location.X, false);
			int y = global::common.a.a(A_0, A_0.Location.Y, true);
			A_0.Location = new global::System.Drawing.Point(x, y);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x0000234C File Offset: 0x0000054C
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
			A_0.Width = global::common.a.a(A_0, A_0.Width, false);
			A_0.Height = global::common.a.a(A_0, A_0.Height, true);
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000023B0 File Offset: 0x000005B0
		// Note: this type is marked as 'beforefieldinit'.
		static a()
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
			global::common.a.a = 0f;
			global::common.a.b = 0f;
			global::common.a.c = 1.0;
			global::common.a.d = 1.0;
		}

		// Token: 0x04000003 RID: 3
		private static float a;

		// Token: 0x04000004 RID: 4
		private static float b;

		// Token: 0x04000005 RID: 5
		private static double c;

		// Token: 0x04000006 RID: 6
		private static double d;
	}
}
