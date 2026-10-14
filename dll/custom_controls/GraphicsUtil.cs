using System;
using System.Drawing;

namespace custom_controls
{
	// Token: 0x02000080 RID: 128
	public struct GraphicsUtil
	{
		// Token: 0x06000508 RID: 1288 RVA: 0x0004ED90 File Offset: 0x0004CF90
		public static void IncludePoint(ref global::System.Drawing.RectangleF rect, global::System.Drawing.PointF pointToInclude)
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
			global::custom_controls.GraphicsUtil.IncludePointX(ref rect, pointToInclude.X);
			global::custom_controls.GraphicsUtil.IncludePointY(ref rect, pointToInclude.Y);
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x0004EDE8 File Offset: 0x0004CFE8
		public static void IncludePointX(ref global::System.Drawing.RectangleF rect, float xToInclude)
		{
			int num = 2;
			for (;;)
			{
				switch (num)
				{
				case 0:
					goto IL_88;
				case 1:
					rect.Width = xToInclude - rect.X;
					num = 0;
					continue;
				case 3:
					goto IL_35;
				case 4:
					if (xToInclude > rect.Right)
					{
						num = 1;
						continue;
					}
					goto IL_88;
				}
				if (xToInclude < rect.X)
				{
					num = 3;
					continue;
				}
				IL_57:
				num = 4;
				continue;
				IL_88:
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_57;
				default:
					goto IL_9E;
				}
			}
			IL_35:
			if (true)
			{
			}
			rect.Width = rect.Right - xToInclude;
			rect.X = xToInclude;
			return;
			IL_9E:
			if (false)
			{
			}
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x0004EEA4 File Offset: 0x0004D0A4
		public static void IncludePointY(ref global::System.Drawing.RectangleF rect, float yToInclude)
		{
			int num = 4;
			for (;;)
			{
				switch (num)
				{
				case 0:
					goto IL_51;
				case 1:
					if (yToInclude > rect.Bottom)
					{
						if (true)
						{
						}
						num = 3;
						continue;
					}
					return;
				case 2:
					return;
				case 3:
					rect.Height = yToInclude - rect.Y;
					num = 2;
					continue;
				}
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					return;
				default:
					if (false)
					{
					}
					if (yToInclude < rect.Y)
					{
						num = 0;
					}
					else
					{
						num = 1;
					}
					break;
				}
			}
			IL_51:
			rect.Height = rect.Bottom - yToInclude;
			rect.Y = yToInclude;
		}
	}
}
