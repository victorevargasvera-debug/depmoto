using System;

namespace custom_controls
{
	// Token: 0x0200004F RID: 79
	internal static class j
	{
		// Token: 0x06000380 RID: 896 RVA: 0x0003B82C File Offset: 0x00039A2C
		public static global::custom_controls.o a(uint A_0)
		{
			int num = 5;
			for (;;)
			{
				switch (num)
				{
				case 0:
					goto IL_53;
				case 1:
					goto IL_34;
				case 2:
					goto IL_A7;
				case 3:
					if (A_0 == 8U)
					{
						num = 2;
						continue;
					}
					num = 4;
					continue;
				case 4:
					if (A_0 == 16U)
					{
						num = 0;
						continue;
					}
					goto IL_A9;
				}
				if (A_0 == 1U)
				{
					num = 1;
				}
				else
				{
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_53;
					}
					if (false)
					{
					}
					num = 3;
				}
			}
			IL_34:
			if (true)
			{
			}
			return new global::custom_controls.m();
			IL_53:
			return new global::custom_controls.u();
			IL_A7:
			return new global::custom_controls.i();
			IL_A9:
			throw new global::System.ApplicationException("Unsupported bitPerPixel.");
		}
	}
}
