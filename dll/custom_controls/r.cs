using System;
using System.Runtime.InteropServices;

namespace custom_controls
{
	// Token: 0x020000A8 RID: 168
	internal class r
	{
		// Token: 0x06000733 RID: 1843
		[global::System.Runtime.InteropServices.DllImport("user32.dll")]
		public static extern global::System.IntPtr GetWindowRect(global::System.IntPtr A_0, ref global::custom_controls.r.c A_1);

		// Token: 0x06000734 RID: 1844
		[global::System.Runtime.InteropServices.DllImport("user32.dll")]
		public static extern global::System.IntPtr GetMenuItemID(global::System.IntPtr A_0, int A_1);

		// Token: 0x06000735 RID: 1845
		[global::System.Runtime.InteropServices.DllImport("User32.Dll")]
		public static extern int TrackPopupMenuEx(global::System.IntPtr A_0, uint A_1, int A_2, int A_3, global::System.IntPtr A_4, global::System.IntPtr A_5);

		// Token: 0x06000736 RID: 1846 RVA: 0x00067550 File Offset: 0x00065750
		public static int b(int A_0)
		{
			while (((long)A_0 & (long)((ulong)-2147483648)) == (long)((ulong)-2147483648))
			{
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
					return A_0 >> 16;
				}
			}
			return A_0 >> 16 & 65535;
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x000675B0 File Offset: 0x000657B0
		public static int a(int A_0)
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
			return A_0 & 65535;
		}

		// Token: 0x0400052F RID: 1327
		public const int a = 256;

		// Token: 0x04000530 RID: 1328
		public const int b = 260;

		// Token: 0x04000531 RID: 1329
		public const int c = 528;

		// Token: 0x04000532 RID: 1330
		public const int d = 516;

		// Token: 0x04000533 RID: 1331
		public const int e = 123;

		// Token: 0x04000534 RID: 1332
		public const int f = 43;

		// Token: 0x04000535 RID: 1333
		public const int g = 44;

		// Token: 0x04000536 RID: 1334
		public const uint h = 256U;

		// Token: 0x04000537 RID: 1335
		public const int i = 2;

		// Token: 0x020000A9 RID: 169
		public struct c
		{
			// Token: 0x04000538 RID: 1336
			public int a;

			// Token: 0x04000539 RID: 1337
			public int b;

			// Token: 0x0400053A RID: 1338
			public int c;

			// Token: 0x0400053B RID: 1339
			public int d;
		}

		// Token: 0x020000AA RID: 170
		public struct a
		{
			// Token: 0x0400053C RID: 1340
			public int a;

			// Token: 0x0400053D RID: 1341
			public int b;

			// Token: 0x0400053E RID: 1342
			public int c;

			// Token: 0x0400053F RID: 1343
			public int d;

			// Token: 0x04000540 RID: 1344
			public int e;

			// Token: 0x04000541 RID: 1345
			public global::System.IntPtr f;
		}

		// Token: 0x020000AB RID: 171
		[global::System.Runtime.InteropServices.StructLayout(global::System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = global::System.Runtime.InteropServices.CharSet.Auto)]
		public struct b
		{
			// Token: 0x04000542 RID: 1346
			public int a;

			// Token: 0x04000543 RID: 1347
			public int b;

			// Token: 0x04000544 RID: 1348
			public int c;

			// Token: 0x04000545 RID: 1349
			public int d;

			// Token: 0x04000546 RID: 1350
			public int e;

			// Token: 0x04000547 RID: 1351
			public global::System.IntPtr f;

			// Token: 0x04000548 RID: 1352
			public global::System.IntPtr g;

			// Token: 0x04000549 RID: 1353
			public global::custom_controls.r.c h;

			// Token: 0x0400054A RID: 1354
			public global::System.IntPtr i;
		}

		// Token: 0x020000AC RID: 172
		public enum d
		{
			// Token: 0x0400054C RID: 1356
			a = 1,
			// Token: 0x0400054D RID: 1357
			b = 16
		}
	}
}
