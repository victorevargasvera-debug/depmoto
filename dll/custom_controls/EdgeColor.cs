using System;
using System.Drawing;

namespace custom_controls
{
	// Token: 0x02000089 RID: 137
	public struct EdgeColor
	{
		// Token: 0x060005C4 RID: 1476 RVA: 0x000569B4 File Offset: 0x00054BB4
		public static global::System.Drawing.Color GetRenderingColor(global::custom_controls.EdgeColorType edgeColorType, global::System.Drawing.Color color)
		{
			int num = 6;
			float correctionFactor;
			for (;;)
			{
				global::custom_controls.EdgeColorType edgeColorType2;
				switch (num)
				{
				case 0:
					num = 9;
					continue;
				case 1:
					goto IL_6F;
				case 2:
					goto IL_63;
				case 3:
					goto IL_FE;
				case 4:
					goto IL_129;
				case 5:
					goto IL_176;
				case 7:
					num = 5;
					continue;
				case 8:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_167;
					}
					if (false)
					{
					}
					switch (edgeColorType2)
					{
					case global::custom_controls.EdgeColorType.NoEdge:
						goto IL_12B;
					case global::custom_controls.EdgeColorType.SystemColor:
						goto IL_131;
					case global::custom_controls.EdgeColorType.SurfaceColor:
						return color;
					case global::custom_controls.EdgeColorType.DarkerThanSurface:
						correctionFactor = -global::custom_controls.ColorUtil.BrightnessEnhancementFactor1;
						num = 4;
						continue;
					case global::custom_controls.EdgeColorType.DarkerDarkerThanSurface:
						correctionFactor = -global::custom_controls.ColorUtil.BrightnessEnhancementFactor2;
						num = 2;
						continue;
					case global::custom_controls.EdgeColorType.LighterThanSurface:
						correctionFactor = global::custom_controls.ColorUtil.BrightnessEnhancementFactor1;
						num = 10;
						continue;
					case global::custom_controls.EdgeColorType.LighterLighterThanSurface:
						correctionFactor = global::custom_controls.ColorUtil.BrightnessEnhancementFactor2;
						num = 11;
						continue;
					case global::custom_controls.EdgeColorType.Contrast:
					case global::custom_controls.EdgeColorType.EnhancedContrast:
						goto IL_178;
					case global::custom_controls.EdgeColorType.FullContrast:
						goto IL_68;
					default:
						num = 7;
						continue;
					}
					break;
				case 9:
					if (edgeColorType == global::custom_controls.EdgeColorType.EnhancedContrast)
					{
						num = 3;
						continue;
					}
					goto IL_6F;
				case 10:
					goto IL_167;
				case 11:
					goto IL_FC;
				}
				if (edgeColorType != global::custom_controls.EdgeColorType.Contrast)
				{
					num = 0;
					continue;
				}
				goto IL_FE;
				IL_6F:
				correctionFactor = 0f;
				edgeColorType2 = edgeColorType;
				if (true)
				{
				}
				num = 8;
				continue;
				IL_FE:
				edgeColorType = global::custom_controls.EdgeColor.a(color, edgeColorType);
				num = 1;
			}
			IL_63:
			goto IL_178;
			IL_68:
			return global::custom_controls.EdgeColor.a(color);
			IL_FC:
			IL_129:
			goto IL_178;
			IL_12B:
			return global::System.Drawing.Color.Transparent;
			IL_131:
			return global::System.Drawing.SystemColors.WindowText;
			IL_167:
			IL_176:
			IL_178:
			return global::custom_controls.ColorUtil.CreateColorWithCorrectedLightness(color, correctionFactor);
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x00056B40 File Offset: 0x00054D40
		private static global::custom_controls.EdgeColorType a(global::System.Drawing.Color A_0, global::custom_controls.EdgeColorType A_1)
		{
			int num;
			switch ((1 == 1) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_6C:
				if (A_1 != global::custom_controls.EdgeColorType.Contrast)
				{
					return global::custom_controls.EdgeColorType.LighterLighterThanSurface;
				}
				num = 3;
				break;
			default:
				if (false)
				{
				}
				num = 4;
				break;
			}
			for (;;)
			{
				switch (num)
				{
				case 0:
					goto IL_6C;
				case 1:
					return global::custom_controls.EdgeColorType.DarkerThanSurface;
				case 2:
					if (A_1 == global::custom_controls.EdgeColorType.Contrast)
					{
						num = 1;
						continue;
					}
					return global::custom_controls.EdgeColorType.DarkerDarkerThanSurface;
				case 3:
					return global::custom_controls.EdgeColorType.LighterThanSurface;
				case 5:
					num = 2;
					continue;
				}
				if (true)
				{
				}
				if (A_0.GetBrightness() > global::custom_controls.EdgeColor.a)
				{
					num = 5;
				}
				else
				{
					num = 0;
				}
			}
			return global::custom_controls.EdgeColorType.LighterThanSurface;
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x00056BF0 File Offset: 0x00054DF0
		private static global::System.Drawing.Color a(global::System.Drawing.Color A_0)
		{
			if (A_0.GetBrightness() <= global::custom_controls.EdgeColor.a)
			{
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_0E;
				}
				if (true)
				{
				}
				if (false)
				{
				}
				return global::System.Drawing.Color.White;
			}
			IL_0E:
			return global::System.Drawing.Color.Black;
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x00056C48 File Offset: 0x00054E48
		// Note: this type is marked as 'beforefieldinit'.
		static EdgeColor()
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
			global::custom_controls.EdgeColor.a = 0.4f;
		}

		// Token: 0x04000451 RID: 1105
		private static readonly float a;
	}
}
