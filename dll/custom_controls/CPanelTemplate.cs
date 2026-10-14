using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace custom_controls
{
	// Token: 0x0200007D RID: 125
	public class CPanelTemplate : global::System.Windows.Forms.Panel
	{
		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x060004F4 RID: 1268 RVA: 0x0004DF00 File Offset: 0x0004C100
		// (set) Token: 0x060004F5 RID: 1269 RVA: 0x0004DF44 File Offset: 0x0004C144
		[global::System.ComponentModel.Browsable(true)]
		[global::System.ComponentModel.Category("Appearance")]
		[global::System.ComponentModel.DefaultValue(false)]
		[global::System.ComponentModel.Localizable(true)]
		[global::System.ComponentModel.Description("Change to the right-to-left layout.")]
		public bool Right2Left
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
				return this.j;
			}
			set
			{
				int num = 2;
				for (;;)
				{
					switch (num)
					{
					case 0:
						this.j = value;
						num = 1;
						continue;
					case 1:
						goto IL_52;
					}
					goto IL_26;
					IL_37:
					num = 0;
					continue;
					IL_26:
					if (true)
					{
					}
					if (this.j != value)
					{
						goto IL_37;
					}
					IL_52:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_37;
					default:
						goto IL_68;
					}
				}
				IL_68:
				if (false)
				{
				}
				base.OnRightToLeftChanged(global::System.EventArgs.Empty);
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x060004F6 RID: 1270 RVA: 0x0004DFCC File Offset: 0x0004C1CC
		protected override global::System.Windows.Forms.CreateParams CreateParams
		{
			get
			{
				global::System.Windows.Forms.CreateParams createParams;
				for (;;)
				{
					int num;
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_61:
						num = 4;
						break;
					default:
						if (false)
						{
						}
						createParams = base.CreateParams;
						num = 1;
						break;
					}
					for (;;)
					{
						switch (num)
						{
						case 0:
							createParams.ExStyle = (createParams.ExStyle | 4194304 | 1048576);
							num = 3;
							continue;
						case 1:
							if (this.Right2Left)
							{
								num = 2;
								continue;
							}
							return createParams;
						case 2:
							goto IL_61;
						case 3:
							return createParams;
						case 4:
							if (true)
							{
							}
							if (!base.DesignMode)
							{
								num = 0;
								continue;
							}
							return createParams;
						}
						break;
					}
				}
				return createParams;
			}
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x0004E08C File Offset: 0x0004C28C
		public CPanelTemplate()
		{
			this.LocationX = 0;
			this.LocationY = 0;
			this.vBoxCount = 0;
			this.hBoxCount = 0;
			this.processNeeded = false;
			this.j = false;
			this.isSpinFocus = false;
			this.spacer = 0;
			this.offset = 0;
			this.a();
			this.SetFont();
			this.deleOnMouseActivate = null;
			base.SetStyle(global::System.Windows.Forms.ControlStyles.DoubleBuffer, true);
			base.SetStyle(global::System.Windows.Forms.ControlStyles.AllPaintingInWmPaint, true);
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x0004E10C File Offset: 0x0004C30C
		protected override void WndProc(ref global::System.Windows.Forms.Message msg)
		{
			try
			{
				switch (0)
				{
				default:
				{
					int num = 13;
					for (;;)
					{
						global::custom_controls.CPanelTemplate.a structure;
						int msg2;
						global::custom_controls.CPanelTemplate.a structure2;
						switch (num)
						{
						case 0:
							if (structure.f > structure.d)
							{
								num = 14;
								continue;
							}
							goto IL_21E;
						case 1:
							goto IL_449;
						case 2:
							num = 16;
							continue;
						case 3:
						{
							global::System.Windows.Forms.ScrollEventType scrollEventType;
							if (scrollEventType == global::System.Windows.Forms.ScrollEventType.ThumbTrack)
							{
								num = 32;
								continue;
							}
							goto IL_4D8;
						}
						case 4:
							goto IL_194;
						case 5:
							goto IL_59D;
						case 6:
							num = 41;
							continue;
						case 7:
							goto IL_59D;
						case 8:
							num = 43;
							continue;
						case 9:
							num = 30;
							continue;
						case 10:
							num = 15;
							continue;
						case 11:
							if (msg2 != 33)
							{
								num = 20;
								continue;
							}
							num = 4;
							continue;
						case 12:
							goto IL_21E;
						case 14:
							structure.f = structure.d;
							num = 25;
							continue;
						case 15:
							if (structure2.f != structure2.g)
							{
								num = 39;
								continue;
							}
							goto IL_206;
						case 16:
							base.WndProc(ref msg);
							num = 5;
							continue;
						case 17:
							if (structure.f < structure.c)
							{
								num = 26;
								continue;
							}
							num = 0;
							continue;
						case 18:
							if (structure2.f < structure2.c)
							{
								num = 35;
								continue;
							}
							num = 36;
							continue;
						case 19:
							structure2.f = structure2.d;
							num = 33;
							continue;
						case 20:
							num = 40;
							continue;
						case 21:
							goto IL_59D;
						case 22:
							num = 17;
							continue;
						case 23:
							goto IL_59D;
						case 24:
							goto IL_59D;
						case 25:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_194;
							default:
								if (false)
								{
								}
								goto IL_21E;
							}
							break;
						case 26:
							structure.f = structure.c;
							num = 12;
							continue;
						case 27:
							if (this.isSpinFocus)
							{
								num = 6;
								continue;
							}
							base.WndProc(ref msg);
							num = 7;
							continue;
						case 28:
							goto IL_5A9;
						case 29:
							goto IL_332;
						case 30:
							goto IL_31C;
						case 31:
							goto IL_4D8;
						case 32:
							num = 38;
							continue;
						case 33:
							goto IL_449;
						case 34:
							this.deleOnMouseActivate();
							num = 29;
							continue;
						case 35:
							structure2.f = structure2.c;
							num = 1;
							continue;
						case 36:
							if (structure2.f > structure2.d)
							{
								num = 19;
								continue;
							}
							goto IL_449;
						case 37:
							goto IL_206;
						case 38:
							if (structure.f != structure.g)
							{
								num = 22;
								continue;
							}
							goto IL_4D8;
						case 39:
							num = 18;
							continue;
						case 40:
							switch (msg2)
							{
							case 276:
							{
								structure = default(global::custom_controls.CPanelTemplate.a);
								structure.b = 23;
								structure.a = global::System.Runtime.InteropServices.Marshal.SizeOf<global::custom_controls.CPanelTemplate.a>(structure);
								global::custom_controls.CPanelTemplate.GetScrollInfo(msg.HWnd, 0, ref structure);
								global::System.Windows.Forms.ScrollEventType scrollEventType = this.a(msg.WParam);
								num = 3;
								continue;
							}
							case 277:
							{
								structure2 = default(global::custom_controls.CPanelTemplate.a);
								structure2.b = 23;
								structure2.a = global::System.Runtime.InteropServices.Marshal.SizeOf<global::custom_controls.CPanelTemplate.a>(structure2);
								global::custom_controls.CPanelTemplate.GetScrollInfo(msg.HWnd, 1, ref structure2);
								global::System.Windows.Forms.ScrollEventType scrollEventType2 = this.a(msg.WParam);
								num = 42;
								continue;
							}
							default:
								num = 8;
								continue;
							}
							break;
						case 41:
							goto IL_4A1;
						case 42:
						{
							global::System.Windows.Forms.ScrollEventType scrollEventType2;
							if (scrollEventType2 == global::System.Windows.Forms.ScrollEventType.ThumbTrack)
							{
								num = 10;
								continue;
							}
							goto IL_206;
						}
						case 43:
							if (msg2 != 522)
							{
								num = 2;
								continue;
							}
							num = 27;
							continue;
						}
						if (msg.HWnd != base.Handle)
						{
							num = 9;
							continue;
						}
						msg2 = msg.Msg;
						num = 11;
						continue;
						IL_194:
						if (this.deleOnMouseActivate != null)
						{
							num = 34;
							continue;
						}
						goto IL_332;
						IL_206:
						base.WndProc(ref msg);
						num = 21;
						continue;
						IL_21E:
						structure.f = structure.g;
						global::custom_controls.CPanelTemplate.SetScrollInfo(base.Handle, 0, ref structure, true);
						base.SetDisplayRectLocation(-structure.f, base.AutoScrollPosition.Y);
						num = 31;
						continue;
						IL_332:
						base.WndProc(ref msg);
						num = 24;
						continue;
						IL_449:
						structure2.f = structure2.g;
						global::custom_controls.CPanelTemplate.SetScrollInfo(base.Handle, 1, ref structure2, true);
						base.SetDisplayRectLocation(base.AutoScrollPosition.X, -structure2.f);
						num = 37;
						continue;
						IL_4D8:
						base.WndProc(ref msg);
						num = 23;
						continue;
						IL_59D:
						num = 28;
					}
					IL_31C:
					IL_4A1:
					IL_5A9:
					break;
				}
				}
			}
			catch (global::System.Exception)
			{
				base.WndProc(ref msg);
			}
			if (true)
			{
			}
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x0004E6FC File Offset: 0x0004C8FC
		protected void SetFont()
		{
			int num = 1;
			for (;;)
			{
				switch (num)
				{
				case 0:
					goto IL_91;
				case 1:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						if (false)
						{
						}
						break;
					}
					break;
				case 2:
					if (0f != global::custom_controls.CPanelTemplate.FONT_SIZE)
					{
						num = 0;
						continue;
					}
					goto IL_93;
				case 3:
					if (true)
					{
					}
					num = 2;
					continue;
				}
				if (global::custom_controls.CPanelTemplate.FONT_FAMILY == null)
				{
					goto IL_93;
				}
				num = 3;
			}
			IL_91:
			this.Font = new global::System.Drawing.Font(global::custom_controls.CPanelTemplate.FONT_FAMILY, global::custom_controls.CPanelTemplate.FONT_SIZE);
			return;
			IL_93:
			this.Font = new global::System.Drawing.Font("Arial Unicode MS", 8.25f);
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x0004E7B4 File Offset: 0x0004C9B4
		public static void SetFontProperties(string fontFamily, float fontSize, float topicFontSize, float titleFontSize)
		{
			int num = 1;
			for (;;)
			{
				switch (num)
				{
				case 0:
					num = 2;
					continue;
				case 2:
					if (!fontFamily.Equals(string.Empty))
					{
						num = 3;
						continue;
					}
					goto IL_E3;
				case 3:
					num = 9;
					continue;
				case 4:
					global::custom_controls.CPanelTemplate.FONT_FAMILY = fontFamily;
					global::custom_controls.CPanelTemplate.FONT_SIZE = fontSize;
					num = 8;
					continue;
				case 5:
					if (topicFontSize > 0f)
					{
						num = 10;
						continue;
					}
					goto IL_122;
				case 6:
					goto IL_67;
				case 7:
					if (titleFontSize > 0f)
					{
						num = 6;
						continue;
					}
					goto IL_122;
				case 8:
					goto IL_85;
				case 9:
					if (0f != fontSize)
					{
						num = 4;
						continue;
					}
					goto IL_E3;
				case 10:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_85;
					default:
						if (false)
						{
						}
						num = 7;
						continue;
					}
					break;
				}
				if (fontFamily != null)
				{
					num = 0;
					continue;
				}
				IL_E3:
				num = 5;
				continue;
				IL_85:
				goto IL_E3;
			}
			IL_67:
			if (true)
			{
			}
			global::custom_controls.CPanelTemplate.TOPIC_FONT_SIZE = topicFontSize;
			global::custom_controls.CPanelTemplate.TITLE_FONT_SIZE = titleFontSize;
			return;
			IL_122:
			global::custom_controls.CPanelTemplate.TOPIC_FONT_SIZE = 12f;
			global::custom_controls.CPanelTemplate.TITLE_FONT_SIZE = 16f;
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x0004E8F8 File Offset: 0x0004CAF8
		protected override void Dispose(bool disposing)
		{
			int num = 3;
			for (;;)
			{
				switch (num)
				{
				case 0:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_4C;
					default:
						if (false)
						{
						}
						this.k.Dispose();
						num = 4;
						continue;
					}
					break;
				case 1:
					num = 2;
					continue;
				case 2:
					if (this.k != null)
					{
						num = 0;
						continue;
					}
					goto IL_8E;
				case 4:
					goto IL_4C;
				}
				if (!disposing)
				{
					break;
				}
				if (true)
				{
				}
				num = 1;
			}
			IL_4C:
			IL_8E:
			base.Dispose(disposing);
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x0004E99C File Offset: 0x0004CB9C
		protected override global::System.Drawing.Point ScrollToControl(global::System.Windows.Forms.Control activeControl)
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
			return base.AutoScrollPosition;
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x0004E9E0 File Offset: 0x0004CBE0
		private void a()
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
			this.k = new global::System.ComponentModel.Container();
		}

		// Token: 0x060004FE RID: 1278
		[global::System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
		private static extern int GetScrollInfo(global::System.IntPtr A_0, int A_1, ref global::custom_controls.CPanelTemplate.a A_2);

		// Token: 0x060004FF RID: 1279
		[global::System.Runtime.InteropServices.DllImport("User32")]
		private static extern bool SetScrollInfo(global::System.IntPtr A_0, int A_1, ref global::custom_controls.CPanelTemplate.a A_2, bool A_3);

		// Token: 0x06000500 RID: 1280 RVA: 0x0004EA28 File Offset: 0x0004CC28
		private int a(global::System.Windows.Forms.ScrollEventType A_0)
		{
			int num;
			switch ((1 == 1) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_EF:
				num = 3;
				break;
			default:
				if (false)
				{
				}
				goto IL_54;
			}
			int result;
			for (;;)
			{
				IL_1E:
				switch (num)
				{
				case 0:
					return result;
				case 1:
					goto IL_118;
				case 2:
					goto IL_BD;
				case 3:
					goto IL_FA;
				case 4:
					num = 7;
					continue;
				case 5:
					goto IL_AB;
				case 6:
					goto IL_CF;
				case 7:
					goto IL_EB;
				case 8:
					return result;
				case 9:
					goto IL_109;
				case 10:
					goto IL_DE;
				case 11:
					switch (A_0)
					{
					case global::System.Windows.Forms.ScrollEventType.SmallDecrement:
						result = 0;
						num = 6;
						continue;
					case global::System.Windows.Forms.ScrollEventType.SmallIncrement:
						result = 1;
						num = 8;
						continue;
					case global::System.Windows.Forms.ScrollEventType.LargeDecrement:
						result = 2;
						num = 1;
						continue;
					case global::System.Windows.Forms.ScrollEventType.LargeIncrement:
						result = 3;
						num = 0;
						continue;
					case global::System.Windows.Forms.ScrollEventType.ThumbPosition:
						result = 4;
						num = 10;
						continue;
					case global::System.Windows.Forms.ScrollEventType.ThumbTrack:
						result = 5;
						num = 2;
						continue;
					case global::System.Windows.Forms.ScrollEventType.First:
						goto IL_ED;
					case global::System.Windows.Forms.ScrollEventType.Last:
						result = 7;
						num = 5;
						continue;
					case global::System.Windows.Forms.ScrollEventType.EndScroll:
						result = 8;
						num = 9;
						continue;
					default:
						num = 4;
						continue;
					}
					break;
				}
				goto IL_54;
			}
			IL_AB:
			IL_BD:
			IL_CF:
			IL_DE:
			IL_EB:
			return result;
			IL_ED:
			result = 6;
			goto IL_EF;
			IL_FA:
			IL_109:
			return result;
			IL_118:
			if (true)
			{
			}
			return result;
			IL_54:
			result = -1;
			num = 11;
			goto IL_1E;
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x0004EB78 File Offset: 0x0004CD78
		private global::System.Windows.Forms.ScrollEventType a(global::System.IntPtr A_0)
		{
			global::System.Windows.Forms.ScrollEventType result;
			for (;;)
			{
				if (true)
				{
				}
				result = global::System.Windows.Forms.ScrollEventType.SmallDecrement;
				int num = global::custom_controls.CPanelTemplate.a((int)A_0);
				int num2 = 7;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						return result;
					case 1:
						return result;
					case 2:
						return result;
					case 3:
						return result;
					case 4:
						return result;
					case 5:
						num2 = 8;
						continue;
					case 6:
						return result;
					case 7:
						switch (num)
						{
						case 0:
							result = global::System.Windows.Forms.ScrollEventType.SmallDecrement;
							num2 = 10;
							continue;
						case 1:
							result = global::System.Windows.Forms.ScrollEventType.SmallIncrement;
							num2 = 6;
							continue;
						case 2:
							result = global::System.Windows.Forms.ScrollEventType.LargeDecrement;
							num2 = 11;
							continue;
						case 3:
							result = global::System.Windows.Forms.ScrollEventType.LargeIncrement;
							num2 = 4;
							continue;
						case 4:
							result = global::System.Windows.Forms.ScrollEventType.ThumbPosition;
							num2 = 0;
							continue;
						case 5:
							result = global::System.Windows.Forms.ScrollEventType.ThumbTrack;
							num2 = 2;
							continue;
						case 6:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								if (false)
								{
								}
								result = global::System.Windows.Forms.ScrollEventType.First;
								num2 = 9;
								continue;
							}
							break;
						case 7:
							result = global::System.Windows.Forms.ScrollEventType.Last;
							break;
						case 8:
							result = global::System.Windows.Forms.ScrollEventType.EndScroll;
							num2 = 3;
							continue;
						default:
							num2 = 5;
							continue;
						}
						num2 = 1;
						continue;
					case 8:
						result = global::System.Windows.Forms.ScrollEventType.EndScroll;
						num2 = 12;
						continue;
					case 9:
						return result;
					case 10:
						return result;
					case 11:
						return result;
					case 12:
						return result;
					}
					break;
				}
			}
			return result;
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x0004ECEC File Offset: 0x0004CEEC
		private static int b(int A_0)
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
				if (((long)A_0 & (long)((ulong)-2147483648)) == (long)((ulong)-2147483648))
				{
					return A_0 >> 16;
				}
				break;
			}
			return A_0 >> 16 & 65535;
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x0004ED4C File Offset: 0x0004CF4C
		private static int a(int A_0)
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

		// Token: 0x040003D6 RID: 982
		private const int a = 4194304;

		// Token: 0x040003D7 RID: 983
		private const int b = 1048576;

		// Token: 0x040003D8 RID: 984
		private const int c = 522;

		// Token: 0x040003D9 RID: 985
		private const int d = 277;

		// Token: 0x040003DA RID: 986
		private const int e = 33;

		// Token: 0x040003DB RID: 987
		private const string f = "Arial Unicode MS";

		// Token: 0x040003DC RID: 988
		private const float g = 8.25f;

		// Token: 0x040003DD RID: 989
		private const float h = 12f;

		// Token: 0x040003DE RID: 990
		private const float i = 16f;

		// Token: 0x040003DF RID: 991
		public int LocationX;

		// Token: 0x040003E0 RID: 992
		public int LocationY;

		// Token: 0x040003E1 RID: 993
		public int vBoxCount;

		// Token: 0x040003E2 RID: 994
		public int hBoxCount;

		// Token: 0x040003E3 RID: 995
		public bool processNeeded;

		// Token: 0x040003E4 RID: 996
		private bool j;

		// Token: 0x040003E5 RID: 997
		public int spacer;

		// Token: 0x040003E6 RID: 998
		public int offset;

		// Token: 0x040003E7 RID: 999
		public bool isSpinFocus;

		// Token: 0x040003E8 RID: 1000
		public global::custom_controls.CPanelTemplate.DeleOnMouseActivate deleOnMouseActivate;

		// Token: 0x040003E9 RID: 1001
		public static string FONT_FAMILY;

		// Token: 0x040003EA RID: 1002
		public static float FONT_SIZE;

		// Token: 0x040003EB RID: 1003
		public static float TOPIC_FONT_SIZE;

		// Token: 0x040003EC RID: 1004
		public static float TITLE_FONT_SIZE;

		// Token: 0x040003ED RID: 1005
		private global::System.ComponentModel.Container k;

		// Token: 0x0200007E RID: 126
		// (Invoke) Token: 0x06000505 RID: 1285
		public delegate void DeleOnMouseActivate();

		// Token: 0x0200007F RID: 127
		private struct a
		{
			// Token: 0x040003EE RID: 1006
			public int a;

			// Token: 0x040003EF RID: 1007
			public int b;

			// Token: 0x040003F0 RID: 1008
			public int c;

			// Token: 0x040003F1 RID: 1009
			public int d;

			// Token: 0x040003F2 RID: 1010
			public int e;

			// Token: 0x040003F3 RID: 1011
			public int f;

			// Token: 0x040003F4 RID: 1012
			public int g;
		}
	}
}
