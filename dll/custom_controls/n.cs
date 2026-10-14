using System;
using System.Drawing;

namespace custom_controls
{
	// Token: 0x02000060 RID: 96
	internal class n
	{
		// Token: 0x06000420 RID: 1056 RVA: 0x00043854 File Offset: 0x00041A54
		private n()
		{
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x00043868 File Offset: 0x00041A68
		public static global::System.Drawing.Size a(global::System.IntPtr A_0, global::System.Drawing.Font A_1, string A_2)
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
				switch (0)
				{
				}
				break;
			}
			global::System.Drawing.StringFormat stringFormat = new global::System.Drawing.StringFormat();
			global::System.Drawing.Size result;
			try
			{
				for (;;)
				{
					global::System.Drawing.RectangleF bounds = new global::System.Drawing.RectangleF(0f, 0f, 9999f, 9999f);
					global::System.Drawing.CharacterRange[] measurableCharacterRanges = new global::System.Drawing.CharacterRange[]
					{
						new global::System.Drawing.CharacterRange(0, A_2.Length)
					};
					global::System.Drawing.Region[] array = new global::System.Drawing.Region[1];
					stringFormat.SetMeasurableCharacterRanges(measurableCharacterRanges);
					global::System.Drawing.Graphics graphics = global::System.Drawing.Graphics.FromHwnd(A_0);
					array = graphics.MeasureCharacterRanges(A_2, A_1, bounds, stringFormat);
					int num = 0;
					for (;;)
					{
						switch (num)
						{
						case 0:
							if (array.Length > 0)
							{
								num = 1;
								continue;
							}
							result = bounds.Size.ToSize();
							num = 3;
							continue;
						case 1:
						{
							bounds = array[0].GetBounds(graphics);
							float num2 = A_1.SizeInPoints / 8.25f * 3f;
							result = new global::System.Drawing.Size((int)(bounds.Width + num2), (int)bounds.Height);
							num = 2;
							continue;
						}
						case 2:
							goto IL_123;
						case 3:
							goto IL_143;
						}
						break;
					}
				}
				IL_123:
				IL_143:;
			}
			finally
			{
				int num = 1;
				for (;;)
				{
					switch (num)
					{
					case 0:
						((global::System.IDisposable)stringFormat).Dispose();
						num = 2;
						continue;
					case 2:
						goto IL_180;
					}
					if (stringFormat == null)
					{
						break;
					}
					num = 0;
				}
				IL_180:;
			}
			return result;
		}
	}
}
