using System;
using System.Drawing;

namespace custom_controls
{
	// Token: 0x0200008A RID: 138
	public struct ColorUtil
	{
		// Token: 0x060005C8 RID: 1480 RVA: 0x00056C90 File Offset: 0x00054E90
		public static global::System.Drawing.Color CreateColorWithCorrectedLightness(global::System.Drawing.Color color, float correctionFactor)
		{
			int num = 1;
			float num2;
			float num3;
			float num4;
			for (;;)
			{
				switch (num)
				{
				case 0:
					if (correctionFactor < 0f)
					{
						num = 4;
						continue;
					}
					num2 = (255f - num2) * correctionFactor + num2;
					num3 = (255f - num3) * correctionFactor + num3;
					num4 = (255f - num4) * correctionFactor + num4;
					num = 3;
					continue;
				case 2:
					goto IL_62;
				case 3:
					goto IL_FC;
				case 4:
					correctionFactor = 1f + correctionFactor;
					num2 *= correctionFactor;
					num3 *= correctionFactor;
					num4 *= correctionFactor;
					num = 2;
					continue;
				case 5:
					goto IL_38;
				}
				if (correctionFactor == 0f)
				{
					num = 5;
				}
				else
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
						num2 = (float)color.R;
						num3 = (float)color.G;
						num4 = (float)color.B;
						break;
					}
					num = 0;
				}
			}
			IL_38:
			if (true)
			{
			}
			return color;
			IL_62:
			IL_FC:
			return global::System.Drawing.Color.FromArgb((int)color.A, (int)num2, (int)num3, (int)num4);
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x00056DB0 File Offset: 0x00054FB0
		// Note: this type is marked as 'beforefieldinit'.
		static ColorUtil()
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
			global::custom_controls.ColorUtil.BrightnessEnhancementFactor1 = 0.3f;
			global::custom_controls.ColorUtil.BrightnessEnhancementFactor2 = 0.5f;
		}

		// Token: 0x04000452 RID: 1106
		public static readonly float BrightnessEnhancementFactor1;

		// Token: 0x04000453 RID: 1107
		public static readonly float BrightnessEnhancementFactor2;
	}
}
