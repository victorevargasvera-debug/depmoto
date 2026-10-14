using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace custom_controls
{
	// Token: 0x02000081 RID: 129
	public class PieChart3D : global::System.IDisposable
	{
		// Token: 0x0600050B RID: 1291 RVA: 0x0004EF64 File Offset: 0x0004D164
		protected PieChart3D()
		{
			float[] array = new float[1];
			this.n = array;
			this.o = global::custom_controls.EdgeColorType.SystemColor;
			this.p = 1f;
			this.r = true;
			this.s = -1;
			base..ctor();
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x0004F0B0 File Offset: 0x0004D2B0
		public PieChart3D(float aXBoundingRect, float aYBoundingRect, float aWidthBoundingRect, float aHeightBoundingRect, decimal[] aValues) : this()
		{
			this.a = aXBoundingRect;
			this.b = aYBoundingRect;
			this.c = aWidthBoundingRect;
			this.d = aHeightBoundingRect;
			this.Values = aValues;
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x0004F0E8 File Offset: 0x0004D2E8
		public PieChart3D(float xBoundingRect, float yBoundingRect, float widthBoundingRect, float heightBoundingRect, decimal[] values, float sliceRelativeHeight) : this(xBoundingRect, yBoundingRect, widthBoundingRect, heightBoundingRect, values)
		{
			this.e = sliceRelativeHeight;
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x0004F10C File Offset: 0x0004D30C
		public PieChart3D(global::System.Drawing.RectangleF boundingRectangle, decimal[] values, float sliceRelativeHeight) : this(boundingRectangle.X, boundingRectangle.Y, boundingRectangle.Width, boundingRectangle.Height, values, sliceRelativeHeight)
		{
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x0004F140 File Offset: 0x0004D340
		public PieChart3D(float xBoundingRect, float yBoundingRect, float widthBoundingRect, float heightBoundingRect, decimal[] values, global::System.Drawing.Color[] aSliceColors, float sliceRelativeHeight) : this(xBoundingRect, yBoundingRect, widthBoundingRect, heightBoundingRect, values, sliceRelativeHeight)
		{
			this.j = aSliceColors;
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x0004F164 File Offset: 0x0004D364
		public PieChart3D(global::System.Drawing.RectangleF boundingRectangle, decimal[] values, global::System.Drawing.Color[] aSliceColors, float sliceRelativeHeight) : this(boundingRectangle, values, sliceRelativeHeight)
		{
			this.j = aSliceColors;
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x0004F182 File Offset: 0x0004D382
		public PieChart3D(float xBoundingRect, float yBoundingRect, float widthBoundingRect, float heightBoundingRect, decimal[] values, global::System.Drawing.Color[] sliceColors, float sliceRelativeHeight, string[] texts) : this(xBoundingRect, yBoundingRect, widthBoundingRect, heightBoundingRect, values, sliceColors, sliceRelativeHeight)
		{
			this.k = texts;
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x0004F1A0 File Offset: 0x0004D3A0
		public PieChart3D(float xBoundingRect, float yBoundingRect, float widthBoundingRect, float heightBoundingRect, decimal[] values, float sliceRelativeHeight, string[] texts) : this(xBoundingRect, yBoundingRect, widthBoundingRect, heightBoundingRect, values, sliceRelativeHeight)
		{
			this.k = texts;
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x0004F1C4 File Offset: 0x0004D3C4
		~PieChart3D()
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

		// Token: 0x06000514 RID: 1300 RVA: 0x0004F220 File Offset: 0x0004D420
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

		// Token: 0x06000515 RID: 1301 RVA: 0x0004F268 File Offset: 0x0004D468
		protected virtual void Dispose(bool disposing)
		{
			int num = 4;
			for (;;)
			{
				int num2;
				global::custom_controls.PieSlice[] array;
				switch (num)
				{
				case 0:
					goto IL_9C;
				case 1:
				{
					if (num2 >= array.Length)
					{
						num = 7;
						continue;
					}
					global::custom_controls.PieSlice pieSlice = array[num2];
					pieSlice.Dispose();
					num2++;
					num = 5;
					continue;
				}
				case 2:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_9C;
					default:
						goto IL_C6;
					}
					break;
				case 3:
					num = 8;
					continue;
				case 5:
					goto IL_53;
				case 6:
					goto IL_53;
				case 7:
					goto IL_9E;
				case 8:
					if (disposing)
					{
						num = 0;
						continue;
					}
					goto IL_9E;
				}
				if (!this.t)
				{
					num = 3;
					continue;
				}
				return;
				IL_53:
				num = 1;
				continue;
				IL_9C:
				array = this.g;
				num2 = 0;
				num = 6;
				continue;
				IL_9E:
				this.t = true;
				num = 2;
			}
			IL_C6:
			if (false)
			{
			}
			if (true)
			{
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000517 RID: 1303 RVA: 0x0004F3A8 File Offset: 0x0004D5A8
		// (set) Token: 0x06000516 RID: 1302 RVA: 0x0004F364 File Offset: 0x0004D564
		public decimal[] Values
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
				return this.i;
			}
			set
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
				this.i = value;
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000519 RID: 1305 RVA: 0x0004F430 File Offset: 0x0004D630
		// (set) Token: 0x06000518 RID: 1304 RVA: 0x0004F3EC File Offset: 0x0004D5EC
		public global::System.Drawing.Color[] Colors
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
				switch (1 == 1)
				{
				}
				if (true)
				{
				}
				if (false)
				{
				}
				this.j = value;
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x0600051B RID: 1307 RVA: 0x0004F4B8 File Offset: 0x0004D6B8
		// (set) Token: 0x0600051A RID: 1306 RVA: 0x0004F474 File Offset: 0x0004D674
		public string[] Texts
		{
			get
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
				return this.k;
			}
			set
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
				this.k = value;
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x0600051C RID: 1308 RVA: 0x0004F4FC File Offset: 0x0004D6FC
		// (set) Token: 0x0600051D RID: 1309 RVA: 0x0004F540 File Offset: 0x0004D740
		public global::System.Drawing.Font Font
		{
			get
			{
				if (true)
				{
				}
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				return this.l;
			}
			set
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
				this.l = value;
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x0600051E RID: 1310 RVA: 0x0004F584 File Offset: 0x0004D784
		// (set) Token: 0x0600051F RID: 1311 RVA: 0x0004F5C8 File Offset: 0x0004D7C8
		public global::System.Drawing.Color ForeColor
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
				return this.m;
			}
			set
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
				this.m = value;
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x06000521 RID: 1313 RVA: 0x0004F650 File Offset: 0x0004D850
		// (set) Token: 0x06000520 RID: 1312 RVA: 0x0004F60C File Offset: 0x0004D80C
		public global::custom_controls.EdgeColorType EdgeColorType
		{
			get
			{
				if (true)
				{
				}
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				return this.o;
			}
			set
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
				this.o = value;
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000523 RID: 1315 RVA: 0x0004F6D8 File Offset: 0x0004D8D8
		// (set) Token: 0x06000522 RID: 1314 RVA: 0x0004F694 File Offset: 0x0004D894
		public float EdgeLineWidth
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
				return this.p;
			}
			set
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
				this.p = value;
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06000525 RID: 1317 RVA: 0x0004F760 File Offset: 0x0004D960
		// (set) Token: 0x06000524 RID: 1316 RVA: 0x0004F71C File Offset: 0x0004D91C
		public float SliceRelativeHeight
		{
			get
			{
				if (true)
				{
				}
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				return this.e;
			}
			set
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
				this.e = value;
			}
		}

		// Token: 0x170000F3 RID: 243
		// (set) Token: 0x06000526 RID: 1318 RVA: 0x0004F7A4 File Offset: 0x0004D9A4
		public float SliceRelativeDisplacement
		{
			set
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
				this.n = new float[]
				{
					value
				};
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000528 RID: 1320 RVA: 0x0004F838 File Offset: 0x0004DA38
		// (set) Token: 0x06000527 RID: 1319 RVA: 0x0004F7F4 File Offset: 0x0004D9F4
		public float[] SliceRelativeDisplacements
		{
			get
			{
				if (true)
				{
				}
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				return this.n;
			}
			set
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
				this.n = value;
			}
		}

		// Token: 0x170000F5 RID: 245
		// (set) Token: 0x06000529 RID: 1321 RVA: 0x0004F87C File Offset: 0x0004DA7C
		public global::System.Drawing.SizeF ChartSize
		{
			set
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
				this.c = value.Width;
				this.d = value.Height;
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x0600052A RID: 1322 RVA: 0x0004F8D4 File Offset: 0x0004DAD4
		// (set) Token: 0x0600052B RID: 1323 RVA: 0x0004F918 File Offset: 0x0004DB18
		public float Width
		{
			get
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
				return this.c;
			}
			set
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
				this.c = value;
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x0600052C RID: 1324 RVA: 0x0004F95C File Offset: 0x0004DB5C
		// (set) Token: 0x0600052D RID: 1325 RVA: 0x0004F9A0 File Offset: 0x0004DBA0
		public float Height
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
				return this.d;
			}
			set
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
				this.d = value;
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x0600052E RID: 1326 RVA: 0x0004F9E4 File Offset: 0x0004DBE4
		public float Top
		{
			get
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
				return this.b;
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x0600052F RID: 1327 RVA: 0x0004FA28 File Offset: 0x0004DC28
		public float Bottom
		{
			get
			{
				if (true)
				{
				}
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				return this.b + this.d;
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x06000530 RID: 1328 RVA: 0x0004FA70 File Offset: 0x0004DC70
		public float Left
		{
			get
			{
				if (true)
				{
				}
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				return this.a;
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x06000531 RID: 1329 RVA: 0x0004FAB4 File Offset: 0x0004DCB4
		public float Right
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
				return this.a + this.c;
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06000532 RID: 1330 RVA: 0x0004FAFC File Offset: 0x0004DCFC
		// (set) Token: 0x06000533 RID: 1331 RVA: 0x0004FB40 File Offset: 0x0004DD40
		public float X
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
				return this.a;
			}
			set
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
				this.a = value;
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x06000534 RID: 1332 RVA: 0x0004FB84 File Offset: 0x0004DD84
		// (set) Token: 0x06000535 RID: 1333 RVA: 0x0004FBC8 File Offset: 0x0004DDC8
		public float Y
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
				return this.b;
			}
			set
			{
				if (true)
				{
				}
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x06000537 RID: 1335 RVA: 0x0004FC50 File Offset: 0x0004DE50
		// (set) Token: 0x06000536 RID: 1334 RVA: 0x0004FC0C File Offset: 0x0004DE0C
		public global::custom_controls.ShadowStyle ShadowStyle
		{
			get
			{
				if (true)
				{
				}
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				return this.q;
			}
			set
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
				this.q = value;
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x06000539 RID: 1337 RVA: 0x0004FCD8 File Offset: 0x0004DED8
		// (set) Token: 0x06000538 RID: 1336 RVA: 0x0004FC94 File Offset: 0x0004DE94
		public bool FitToBoundingRectangle
		{
			get
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
				return this.r;
			}
			set
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
				this.r = value;
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x0600053B RID: 1339 RVA: 0x0004FDB4 File Offset: 0x0004DFB4
		// (set) Token: 0x0600053A RID: 1338 RVA: 0x0004FD1C File Offset: 0x0004DF1C
		public float InitialAngle
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
				return this.f;
			}
			set
			{
				for (;;)
				{
					for (;;)
					{
						if (true)
						{
						}
						this.f = value % 360f;
						int num = 1;
						for (;;)
						{
							switch (num)
							{
							case 0:
								switch ((1 == 1) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									if (false)
									{
									}
									this.f += 360f;
									num = 2;
									continue;
								}
								break;
							case 1:
								if (this.f < 0f)
								{
									num = 0;
									continue;
								}
								return;
							case 2:
								return;
							}
							break;
						}
					}
				}
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x0600053D RID: 1341 RVA: 0x0004FE3C File Offset: 0x0004E03C
		// (set) Token: 0x0600053C RID: 1340 RVA: 0x0004FDF8 File Offset: 0x0004DFF8
		public int HighlightedIndex
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
				return this.s;
			}
			set
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
				this.s = value;
			}
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x0004FE80 File Offset: 0x0004E080
		public void Draw(global::System.Drawing.Graphics graphics)
		{
			for (;;)
			{
				this.InitializePieSlices();
				int num = 2;
				for (;;)
				{
					switch (num)
					{
					case 0:
						this.DrawSliceSides(graphics);
						num = 4;
						continue;
					case 1:
						if (this.e > 0f)
						{
							num = 0;
							continue;
						}
						goto IL_C6;
					case 2:
						if (this.r)
						{
							num = 5;
							continue;
						}
						goto IL_51;
					case 3:
						goto IL_51;
					case 4:
						goto IL_4F;
					case 5:
					{
						global::System.Drawing.RectangleF fittingRectangle = this.GetFittingRectangle();
						this.ReadjustSlices(fittingRectangle);
						num = 3;
						continue;
					}
					}
					break;
					IL_51:
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
						this.DrawBottoms(graphics);
						num = 1;
						break;
					}
				}
			}
			IL_4F:
			IL_C6:
			this.DrawTops(graphics);
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x0004FF5C File Offset: 0x0004E15C
		public virtual void PlaceTexts(global::System.Drawing.Graphics graphics)
		{
			switch ((1 == 1) ? 1 : 0)
			{
			case 0:
			case 2:
				return;
			}
			if (false)
			{
			}
			if (true)
			{
			}
			switch (0)
			{
			default:
			{
				global::System.Drawing.StringFormat stringFormat = new global::System.Drawing.StringFormat();
				try
				{
					stringFormat.Alignment = global::System.Drawing.StringAlignment.Center;
					stringFormat.LineAlignment = global::System.Drawing.StringAlignment.Center;
					global::System.Drawing.Brush brush = new global::System.Drawing.SolidBrush(this.m);
					try
					{
						for (;;)
						{
							global::custom_controls.PieSlice[] array = this.g;
							int num = 0;
							int num2 = 5;
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::custom_controls.PieSlice pieSlice;
									if (pieSlice.Text.Length > 0)
									{
										num2 = 4;
										continue;
									}
									goto IL_C9;
								}
								case 1:
								{
									if (num >= array.Length)
									{
										num2 = 3;
										continue;
									}
									global::custom_controls.PieSlice pieSlice = array[num];
									num2 = 6;
									continue;
								}
								case 2:
									goto IL_C9;
								case 3:
									num2 = 9;
									continue;
								case 4:
								{
									global::custom_controls.PieSlice pieSlice;
									global::System.Drawing.PointF textPosition = pieSlice.GetTextPosition();
									graphics.DrawString(pieSlice.Text, this.l, brush, textPosition, stringFormat);
									num2 = 2;
									continue;
								}
								case 5:
									goto IL_DA;
								case 6:
								{
									global::custom_controls.PieSlice pieSlice;
									if (pieSlice.Text != null)
									{
										num2 = 8;
										continue;
									}
									goto IL_C9;
								}
								case 7:
									goto IL_DA;
								case 8:
									num2 = 0;
									continue;
								case 9:
									goto IL_15A;
								}
								break;
								IL_C9:
								num++;
								num2 = 7;
								continue;
								IL_DA:
								num2 = 1;
							}
						}
						IL_15A:;
					}
					finally
					{
						int num2 = 2;
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_197;
							case 1:
								((global::System.IDisposable)brush).Dispose();
								num2 = 0;
								continue;
							}
							if (brush == null)
							{
								break;
							}
							num2 = 1;
						}
						IL_197:;
					}
				}
				finally
				{
					int num2 = 0;
					for (;;)
					{
						switch (num2)
						{
						case 1:
							((global::System.IDisposable)stringFormat).Dispose();
							num2 = 2;
							continue;
						case 2:
							goto IL_1D7;
						}
						if (stringFormat == null)
						{
							break;
						}
						num2 = 1;
					}
					IL_1D7:;
				}
				break;
			}
			}
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x00050178 File Offset: 0x0004E378
		public int FindPieSliceUnderPoint(global::System.Drawing.PointF point)
		{
			switch (0)
			{
			default:
			{
				int num;
				int num5;
				int num6;
				for (;;)
				{
					num = 0;
					int num2 = 32;
					for (;;)
					{
						global::custom_controls.PieSlice[] array;
						global::System.Collections.ArrayList arrayList;
						global::custom_controls.PieSlice[] array2;
						int num9;
						int num10;
						switch (num2)
						{
						case 0:
						{
							int num3;
							if (num3 < 0)
							{
								num2 = 39;
								continue;
							}
							global::custom_controls.PieSlice pieSlice = array[num3];
							num2 = 31;
							continue;
						}
						case 1:
						{
							int num4 = this.a(array);
							int num3 = num4;
							num2 = 10;
							continue;
						}
						case 2:
							num5 = 0;
							num2 = 7;
							continue;
						case 3:
						{
							global::custom_controls.PieSlice pieSlice2;
							if (pieSlice2.b(point))
							{
								num2 = 38;
								continue;
							}
							int num3;
							num3++;
							num2 = 35;
							continue;
						}
						case 4:
							goto IL_312;
						case 5:
							goto IL_1E3;
						case 6:
							if (num6 < 0)
							{
								num2 = 2;
								continue;
							}
							goto IL_5CD;
						case 7:
							goto IL_1E3;
						case 8:
							num2 = 9;
							continue;
						case 9:
							if (num6 < 0)
							{
								num2 = 1;
								continue;
							}
							goto IL_477;
						case 10:
							goto IL_513;
						case 11:
						{
							int num3;
							if (num3 >= array.Length)
							{
								num2 = 24;
								continue;
							}
							global::custom_controls.PieSlice pieSlice2 = array[num3];
							num2 = 3;
							continue;
						}
						case 12:
							if (num6 > -1)
							{
								num2 = 43;
								continue;
							}
							return -1;
						case 13:
						{
							global::custom_controls.PieSlice pieSlice3;
							if (pieSlice3.e(point))
							{
								num2 = 4;
								continue;
							}
							num++;
							num2 = 16;
							continue;
						}
						case 14:
							goto IL_3B5;
						case 15:
						{
							float num7;
							float num8;
							if (num7 < num8)
							{
								num2 = 47;
								continue;
							}
							num2 = 46;
							continue;
						}
						case 16:
							goto IL_4C6;
						case 17:
							arrayList = new global::System.Collections.ArrayList(this.g);
							array2 = this.g[0].a(270f);
							num2 = 40;
							continue;
						case 18:
						{
							int num3;
							num6 = num3;
							num2 = 27;
							continue;
						}
						case 19:
							if (array2[0].SweepAngle > 0f)
							{
								num2 = 44;
								continue;
							}
							goto IL_129;
						case 20:
							goto IL_2CE;
						case 21:
							goto IL_3DF;
						case 22:
						{
							global::custom_controls.PieSlice pieSlice4;
							if (pieSlice4.c(point))
							{
								num2 = 36;
								continue;
							}
							goto IL_43C;
						}
						case 23:
						{
							if (num9 > num10)
							{
								num2 = 8;
								continue;
							}
							global::custom_controls.PieSlice pieSlice5 = array[num10];
							float num8 = 270f - pieSlice5.StartAngle;
							global::custom_controls.PieSlice pieSlice4 = array[num9];
							float num7 = (pieSlice4.EndAngle + 90f) % 360f;
							num2 = 15;
							continue;
						}
						case 24:
							goto IL_41A;
						case 25:
						{
							global::custom_controls.PieSlice pieSlice6;
							if (pieSlice6.a(point))
							{
								num2 = 14;
								continue;
							}
							num5++;
							num2 = 5;
							continue;
						}
						case 26:
							goto IL_3DF;
						case 27:
							goto IL_477;
						case 28:
							goto IL_3BA;
						case 29:
						{
							if (num >= this.g.Length)
							{
								num2 = 17;
								continue;
							}
							global::custom_controls.PieSlice pieSlice3 = this.g[num];
							num2 = 13;
							continue;
						}
						case 30:
							goto IL_3BA;
						case 31:
						{
							global::custom_controls.PieSlice pieSlice;
							if (pieSlice.d(point))
							{
								num2 = 18;
								continue;
							}
							int num3;
							num3--;
							num2 = 30;
							continue;
						}
						case 32:
							goto IL_4C6;
						case 33:
							goto IL_129;
						case 34:
							if (num6 < 0)
							{
								num2 = 37;
								continue;
							}
							goto IL_477;
						case 35:
							goto IL_513;
						case 36:
							num6 = num9;
							num2 = 45;
							continue;
						case 37:
						{
							int num4;
							int num3 = num4;
							num2 = 28;
							continue;
						}
						case 38:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_19B;
							default:
							{
								if (false)
								{
								}
								int num3;
								num6 = num3;
								num2 = 50;
								continue;
							}
							}
							break;
						case 39:
							goto IL_477;
						case 40:
							goto IL_19B;
						case 41:
							goto IL_5CD;
						case 42:
							arrayList[0] = array2[1];
							num2 = 19;
							continue;
						case 43:
							goto IL_5EA;
						case 44:
							if (true)
							{
							}
							arrayList.Add(array2[0]);
							num2 = 33;
							continue;
						case 45:
							goto IL_43C;
						case 46:
						{
							global::custom_controls.PieSlice pieSlice5;
							if (pieSlice5.c(point))
							{
								num2 = 49;
								continue;
							}
							goto IL_2CE;
						}
						case 47:
							num2 = 22;
							continue;
						case 48:
						{
							if (num5 >= this.g.Length)
							{
								num2 = 41;
								continue;
							}
							global::custom_controls.PieSlice pieSlice6 = this.g[num5];
							num2 = 25;
							continue;
						}
						case 49:
							num6 = num10;
							num2 = 20;
							continue;
						case 50:
							goto IL_41A;
						case 51:
							goto IL_3DF;
						}
						break;
						IL_129:
						array = (global::custom_controls.PieSlice[])arrayList.ToArray(typeof(global::custom_controls.PieSlice));
						num6 = -1;
						num9 = 0;
						num10 = array.Length - 1;
						num2 = 51;
						continue;
						IL_19B:
						if (array2.Length > 1)
						{
							num2 = 42;
							continue;
						}
						goto IL_129;
						IL_1E3:
						num2 = 48;
						continue;
						IL_2CE:
						num10--;
						num2 = 26;
						continue;
						IL_3BA:
						num2 = 0;
						continue;
						IL_3DF:
						num2 = 23;
						continue;
						IL_41A:
						num2 = 34;
						continue;
						IL_43C:
						num9++;
						num2 = 21;
						continue;
						IL_477:
						num2 = 6;
						continue;
						IL_4C6:
						num2 = 29;
						continue;
						IL_513:
						num2 = 11;
						continue;
						IL_5CD:
						num2 = 12;
					}
				}
				IL_312:
				return (int)this.h[num];
				IL_3B5:
				return (int)this.h[num5];
				IL_5EA:
				num6 %= this.h.Count;
				return (int)this.h[num6];
			}
			}
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x000507A4 File Offset: 0x0004E9A4
		private int a(global::custom_controls.PieSlice[] A_0)
		{
			int num;
			for (;;)
			{
				num = 0;
				int num2 = 0;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_AE;
					case 1:
					{
						global::custom_controls.PieSlice pieSlice;
						if (pieSlice.StartAngle <= 450f)
						{
							num2 = 4;
							continue;
						}
						goto IL_121;
					}
					case 2:
						goto IL_15D;
					case 3:
					{
						if (num >= A_0.Length)
						{
							num2 = 5;
							continue;
						}
						global::custom_controls.PieSlice pieSlice = A_0[num];
						num2 = 13;
						continue;
					}
					case 4:
						if (true)
						{
						}
						num2 = 6;
						continue;
					case 5:
						return -1;
					case 6:
					{
						global::custom_controls.PieSlice pieSlice;
						if (pieSlice.StartAngle + pieSlice.SweepAngle >= 450f)
						{
							num2 = 12;
							continue;
						}
						goto IL_121;
					}
					case 7:
						num2 = 11;
						continue;
					case 8:
						num2 = 1;
						continue;
					case 9:
					{
						global::custom_controls.PieSlice pieSlice;
						if (pieSlice.StartAngle + pieSlice.SweepAngle > 360f)
						{
							num2 = 8;
							continue;
						}
						goto IL_121;
					}
					case 10:
						goto IL_AE;
					case 11:
					{
						global::custom_controls.PieSlice pieSlice;
						if (pieSlice.StartAngle + pieSlice.SweepAngle < 90f)
						{
							num2 = 2;
							continue;
						}
						return num;
					}
					case 12:
						goto IL_7D;
					case 13:
					{
						global::custom_controls.PieSlice pieSlice;
						if (pieSlice.StartAngle <= 90f)
						{
							goto IL_111;
						}
						goto IL_15D;
					}
					}
					break;
					IL_AE:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_111:
						num2 = 7;
						continue;
					default:
						if (false)
						{
						}
						num2 = 3;
						continue;
					}
					IL_121:
					num++;
					num2 = 10;
					continue;
					IL_15D:
					num2 = 9;
				}
			}
			return num;
			IL_7D:
			return num;
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x0005093C File Offset: 0x0004EB3C
		protected global::System.Drawing.RectangleF GetFittingRectangle()
		{
			global::System.Drawing.RectangleF result;
			switch ((1 == 1) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				if (false)
				{
				}
				for (;;)
				{
					if (true)
					{
					}
					result = this.g[0].d();
					int num = 1;
					int num2 = 1;
					for (;;)
					{
						switch (num2)
						{
						case 0:
							if (num >= this.g.Length)
							{
								num2 = 3;
								continue;
							}
							result = global::System.Drawing.RectangleF.Union(result, this.g[num].d());
							num++;
							num2 = 2;
							continue;
						case 1:
							goto IL_56;
						case 2:
							goto IL_56;
						case 3:
							goto IL_7B;
						}
						break;
						IL_56:
						num2 = 0;
					}
				}
				IL_7B:
				break;
			}
			return result;
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x000509EC File Offset: 0x0004EBEC
		protected void ReadjustSlices(global::System.Drawing.RectangleF newBoundingRectangle)
		{
			switch (0)
			{
			default:
				for (;;)
				{
					IL_27:
					float num = this.c / newBoundingRectangle.Width;
					float num2 = this.d / newBoundingRectangle.Height;
					float num3 = newBoundingRectangle.X - this.a;
					float num4 = newBoundingRectangle.Y - this.b;
					global::custom_controls.PieSlice[] array = this.g;
					int num5 = 0;
					for (;;)
					{
						IL_6E:
						int num6 = 1;
						for (;;)
						{
							switch (num6)
							{
							case 0:
								return;
							case 1:
								goto IL_79;
							case 2:
							{
								if (num5 >= array.Length)
								{
									num6 = 0;
									continue;
								}
								global::custom_controls.PieSlice pieSlice = array[num5];
								float a_ = pieSlice.BoundingRectangle.X - num3;
								float a_2 = pieSlice.BoundingRectangle.Y - num4;
								float a_3 = pieSlice.BoundingRectangle.Width * num;
								float a_4 = pieSlice.BoundingRectangle.Height * num2;
								float a_5 = pieSlice.SliceHeight * num2;
								pieSlice.b(a_, a_2, a_3, a_4, a_5);
								num5++;
								num6 = 3;
								continue;
							}
							case 3:
								switch ((1 == 1) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_6E;
								default:
									if (true)
									{
									}
									if (false)
									{
									}
									goto IL_79;
								}
								break;
							}
							goto IL_27;
							IL_79:
							num6 = 2;
						}
					}
				}
				return;
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x06000544 RID: 1348 RVA: 0x00050B50 File Offset: 0x0004ED50
		protected float LargestDisplacement
		{
			get
			{
				float num;
				for (;;)
				{
					num = 0f;
					int num2 = 0;
					int num3 = 0;
					for (;;)
					{
						switch (num3)
						{
						case 0:
							goto IL_3E;
						case 1:
							if (true)
							{
							}
							num = this.n[num2];
							num3 = 6;
							continue;
						case 2:
							goto IL_74;
						case 3:
							return num;
						case 4:
							if (num2 < this.n.Length)
							{
								num3 = 8;
								continue;
							}
							return num;
						case 5:
							goto IL_3E;
						case 6:
							goto IL_5E;
						case 7:
							if (num2 < this.i.Length)
							{
								num3 = 2;
								continue;
							}
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_74;
							default:
								if (false)
								{
								}
								num3 = 3;
								continue;
							}
							break;
						case 8:
							num3 = 7;
							continue;
						}
						break;
						IL_3E:
						num3 = 4;
						continue;
						IL_5E:
						num2++;
						num3 = 5;
						continue;
						IL_74:
						if (this.n[num2] <= num)
						{
							goto IL_5E;
						}
						num3 = 1;
					}
				}
				return num;
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x06000545 RID: 1349 RVA: 0x00050C54 File Offset: 0x0004EE54
		protected global::System.Drawing.SizeF TopEllipseSize
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
				float num = 1f + this.LargestDisplacement;
				float width = this.c / num;
				float height = this.d / num * (1f - this.e);
				return new global::System.Drawing.SizeF(width, height);
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x06000546 RID: 1350 RVA: 0x00050CC4 File Offset: 0x0004EEC4
		protected global::System.Drawing.SizeF LargestDisplacementEllipseSize
		{
			get
			{
				if (true)
				{
				}
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				float largestDisplacement = this.LargestDisplacement;
				float width = this.TopEllipseSize.Width * largestDisplacement;
				float height = this.TopEllipseSize.Height * largestDisplacement;
				return new global::System.Drawing.SizeF(width, height);
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x06000547 RID: 1351 RVA: 0x00050D30 File Offset: 0x0004EF30
		protected float PieHeight
		{
			get
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
				return this.d / (1f + this.LargestDisplacement) * this.e;
			}
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x00050D88 File Offset: 0x0004EF88
		protected virtual void InitializePieSlices()
		{
			switch (0)
			{
			default:
			{
				global::System.Collections.ArrayList arrayList;
				for (;;)
				{
					double num = 0.0;
					decimal[] array = this.i;
					int num2 = 0;
					int num3 = 27;
					for (;;)
					{
						double num4;
						double num5;
						int num6;
						int num9;
						int num10;
						global::custom_controls.PieSlice pieSlice;
						switch (num3)
						{
						case 0:
							goto IL_29B;
						case 1:
							goto IL_222;
						case 2:
							if (num4 + num5 <= 270.0)
							{
								num3 = 1;
								continue;
							}
							goto IL_57A;
						case 3:
							if (num6 >= this.j.Length)
							{
								num3 = 17;
								continue;
							}
							goto IL_15B;
						case 4:
							goto IL_2E3;
						case 5:
							goto IL_2E3;
						case 6:
							if (num4 > 360.0)
							{
								num3 = 15;
								continue;
							}
							goto IL_20E;
						case 7:
							goto IL_1E8;
						case 8:
							if (num4 + num5 > 630.0)
							{
								num3 = 23;
								continue;
							}
							goto IL_4F5;
						case 9:
						{
							if (num2 >= array.Length)
							{
								num3 = 16;
								continue;
							}
							decimal value = array[num2];
							num += (double)value;
							num2++;
							num3 = 31;
							continue;
						}
						case 10:
							num3 = 28;
							continue;
						case 11:
						{
							int num7;
							int num8;
							if (num7 < num8)
							{
								num3 = 34;
								continue;
							}
							goto IL_5D8;
						}
						case 12:
							if (num9 <= -1)
							{
								num3 = 10;
								continue;
							}
							goto IL_57A;
						case 13:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_343;
							default:
								goto IL_2D8;
							}
							break;
						case 14:
							goto IL_5D8;
						case 15:
							num4 -= 360.0;
							num3 = 20;
							continue;
						case 16:
						{
							global::System.Drawing.SizeF topEllipseSize = this.TopEllipseSize;
							global::System.Drawing.SizeF largestDisplacementEllipseSize = this.LargestDisplacementEllipseSize;
							int num8 = this.n.Length - 1;
							float largestDisplacement = this.LargestDisplacement;
							arrayList = new global::System.Collections.ArrayList();
							this.h.Clear();
							num6 = 0;
							num9 = -1;
							int num7 = 0;
							num4 = (double)this.f;
							num10 = 0;
							num3 = 26;
							continue;
						}
						case 17:
							num6 = 0;
							num3 = 30;
							continue;
						case 18:
						{
							if (true)
							{
							}
							float num11;
							if (num11 > 0f)
							{
								num3 = 21;
								continue;
							}
							goto IL_24F;
						}
						case 19:
							if (num4 >= 270.0)
							{
								num3 = 22;
								continue;
							}
							goto IL_4F5;
						case 20:
							goto IL_20E;
						case 21:
						{
							int num7;
							global::System.Drawing.SizeF sliceDisplacement = this.GetSliceDisplacement((float)(num4 + num5 / 2.0), this.n[num7]);
							float num11 = sliceDisplacement.Width;
							float num12 = sliceDisplacement.Height;
							num3 = 24;
							continue;
						}
						case 22:
							num3 = 8;
							continue;
						case 23:
							goto IL_57A;
						case 24:
							goto IL_24F;
						case 25:
						{
							if (num10 == this.s)
							{
								num3 = 33;
								continue;
							}
							global::System.Drawing.SizeF topEllipseSize;
							global::System.Drawing.SizeF largestDisplacementEllipseSize;
							float num11;
							float num12;
							pieSlice = this.CreatePieSlice(this.a + largestDisplacementEllipseSize.Width / 2f + num11, this.b + largestDisplacementEllipseSize.Height / 2f + num12, topEllipseSize.Width, topEllipseSize.Height, this.PieHeight, (float)(num4 % 360.0), (float)num5, this.j[num6], this.q, this.o, this.p);
							num3 = 4;
							continue;
						}
						case 26:
							goto IL_29B;
						case 27:
							goto IL_5B0;
						case 28:
							if (num4 <= 270.0)
							{
								num3 = 35;
								continue;
							}
							goto IL_222;
						case 29:
							goto IL_1E8;
						case 30:
							goto IL_15B;
						case 31:
							goto IL_343;
						case 32:
						{
							if (num10 >= this.i.Length)
							{
								num3 = 13;
								continue;
							}
							decimal value2 = this.i[num10];
							num5 = (double)value2 / num * 360.0;
							int num7;
							float num11 = this.n[num7];
							float num12 = this.n[num7];
							num3 = 18;
							continue;
						}
						case 33:
						{
							global::System.Drawing.SizeF topEllipseSize;
							global::System.Drawing.SizeF largestDisplacementEllipseSize;
							float num11;
							float num12;
							pieSlice = this.CreatePieSliceHighlighted(this.a + largestDisplacementEllipseSize.Width / 2f + num11, this.b + largestDisplacementEllipseSize.Height / 2f + num12, topEllipseSize.Width, topEllipseSize.Height, this.PieHeight, (float)(num4 % 360.0), (float)num5, this.j[num6], this.q, this.o, this.p);
							num3 = 5;
							continue;
						}
						case 34:
						{
							int num7;
							num7++;
							num3 = 14;
							continue;
						}
						case 35:
							num3 = 2;
							continue;
						}
						break;
						IL_15B:
						num4 += num5;
						num3 = 6;
						continue;
						IL_1E8:
						num3 = 11;
						continue;
						IL_20E:
						num10++;
						num3 = 0;
						continue;
						IL_222:
						num3 = 19;
						continue;
						IL_24F:
						pieSlice = null;
						num3 = 25;
						continue;
						IL_29B:
						num3 = 32;
						continue;
						IL_2E3:
						pieSlice.Text = this.k[num10];
						num3 = 12;
						continue;
						IL_4F5:
						arrayList.Add(pieSlice);
						this.h.Add(num10);
						num3 = 7;
						continue;
						IL_57A:
						num9++;
						arrayList.Insert(num9, pieSlice);
						this.h.Insert(num9, num10);
						num3 = 29;
						continue;
						IL_5B0:
						num3 = 9;
						continue;
						IL_343:
						goto IL_5B0;
						IL_5D8:
						num6++;
						num3 = 3;
					}
				}
				IL_2D8:
				if (false)
				{
				}
				this.g = (global::custom_controls.PieSlice[])arrayList.ToArray(typeof(global::custom_controls.PieSlice));
				return;
			}
			}
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x000513BC File Offset: 0x0004F5BC
		protected virtual global::custom_controls.PieSlice CreatePieSlice(float boundingRectLeft, float boundingRectTop, float boundingRectWidth, float boundingRectHeight, float sliceHeight, float startAngle, float sweepAngle, global::System.Drawing.Color color, global::custom_controls.ShadowStyle shadowStyle, global::custom_controls.EdgeColorType edgeColorType, float edgeLineWidth)
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
			return new global::custom_controls.PieSlice(boundingRectLeft, boundingRectTop, boundingRectWidth, boundingRectHeight, sliceHeight, startAngle % 360f, sweepAngle, color, shadowStyle, edgeColorType, edgeLineWidth);
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x00051418 File Offset: 0x0004F618
		protected virtual global::custom_controls.PieSlice CreatePieSliceHighlighted(float boundingRectLeft, float boundingRectTop, float boundingRectWidth, float boundingRectHeight, float sliceHeight, float startAngle, float sweepAngle, global::System.Drawing.Color color, global::custom_controls.ShadowStyle shadowStyle, global::custom_controls.EdgeColorType edgeColorType, float edgeLineWidth)
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
			global::System.Drawing.Color surfaceColor = global::custom_controls.ColorUtil.CreateColorWithCorrectedLightness(color, global::custom_controls.ColorUtil.BrightnessEnhancementFactor1);
			return new global::custom_controls.PieSlice(boundingRectLeft, boundingRectTop, boundingRectWidth, boundingRectHeight, sliceHeight, startAngle % 360f, sweepAngle, surfaceColor, shadowStyle, edgeColorType, edgeLineWidth);
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x00051480 File Offset: 0x0004F680
		protected global::System.Drawing.SizeF GetSliceDisplacement(float angle, float displacementFactor)
		{
			for (;;)
			{
				if (true)
				{
				}
				if (displacementFactor == 0f)
				{
					break;
				}
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_38;
				}
			}
			return global::System.Drawing.SizeF.Empty;
			IL_38:
			if (false)
			{
			}
			float width = (float)((double)(this.TopEllipseSize.Width * displacementFactor / 2f) * global::System.Math.Cos((double)angle * 3.141592653589793 / 180.0));
			float height = (float)((double)(this.TopEllipseSize.Height * displacementFactor / 2f) * global::System.Math.Sin((double)angle * 3.141592653589793 / 180.0));
			return new global::System.Drawing.SizeF(width, height);
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x0005153C File Offset: 0x0004F73C
		protected void DrawSliceSides(global::System.Drawing.Graphics graphics)
		{
			switch (0)
			{
			default:
			{
				global::System.Collections.ArrayList arrayList;
				int num5;
				global::custom_controls.PieSlice pieSlice3;
				for (;;)
				{
					arrayList = new global::System.Collections.ArrayList(this.g);
					int num = 35;
					for (;;)
					{
						float num2;
						float num3;
						global::custom_controls.PieSlice[] array;
						global::custom_controls.PieSlice pieSlice;
						int num4;
						switch (num)
						{
						case 0:
							if (num2 < 0f)
							{
								num = 16;
								continue;
							}
							goto IL_1EC;
						case 1:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_506;
							default:
								if (true)
								{
								}
								if (false)
								{
								}
								if (num2 <= 180f)
								{
									num = 3;
									continue;
								}
								goto IL_4EE;
							}
							break;
						case 2:
							num = 33;
							continue;
						case 3:
							num = 0;
							continue;
						case 4:
							goto IL_30D;
						case 5:
							goto IL_312;
						case 6:
							goto IL_430;
						case 7:
							goto IL_456;
						case 8:
							goto IL_2EC;
						case 9:
							if (num3 >= num2)
							{
								num = 14;
								continue;
							}
							num = 34;
							continue;
						case 10:
							goto IL_2EC;
						case 11:
							if (this.g[0].StartAngle < 90f)
							{
								num = 36;
								continue;
							}
							goto IL_258;
						case 12:
							arrayList.Add(array[0]);
							num = 18;
							continue;
						case 13:
							if (this.g[0].StartAngle + this.g[0].SweepAngle > 270f)
							{
								num = 5;
								continue;
							}
							goto IL_258;
						case 14:
							pieSlice.b(graphics);
							num4++;
							num = 10;
							continue;
						case 15:
							if (this.g[0].StartAngle + this.g[0].SweepAngle > 450f)
							{
								num = 26;
								continue;
							}
							goto IL_147;
						case 16:
							goto IL_4EE;
						case 17:
							goto IL_3B3;
						case 18:
							goto IL_258;
						case 19:
							num = 21;
							continue;
						case 20:
							goto IL_258;
						case 21:
							if (this.g[0].StartAngle + this.g[0].SweepAngle <= 450f)
							{
								num = 17;
								continue;
							}
							goto IL_312;
						case 22:
						{
							global::custom_controls.PieSlice[] array2;
							if (array2[1].SweepAngle > 0f)
							{
								num = 28;
								continue;
							}
							goto IL_258;
						}
						case 23:
						{
							if (num4 >= num5)
							{
								num = 4;
								continue;
							}
							global::custom_controls.PieSlice pieSlice2 = (global::custom_controls.PieSlice)arrayList[num5];
							num2 = pieSlice2.StartAngle - 90f;
							num = 1;
							continue;
						}
						case 24:
							if (num3 <= 180f)
							{
								num = 25;
								continue;
							}
							goto IL_456;
						case 25:
							num = 27;
							continue;
						case 26:
						{
							pieSlice3 = (global::custom_controls.PieSlice)arrayList[0];
							global::custom_controls.PieSlice[] array2 = pieSlice3.a(0f);
							arrayList[0] = array2[0];
							num = 22;
							continue;
						}
						case 27:
							if (num3 < 0f)
							{
								num = 7;
								continue;
							}
							goto IL_430;
						case 28:
						{
							global::custom_controls.PieSlice[] array2;
							arrayList.Insert(1, array2[1]);
							num = 20;
							continue;
						}
						case 29:
							if (array[1].SweepAngle > 0f)
							{
								num = 12;
								continue;
							}
							goto IL_258;
						case 30:
							goto IL_506;
						case 31:
							goto IL_2EC;
						case 32:
							goto IL_1EC;
						case 33:
							if (this.g[0].StartAngle <= 270f)
							{
								num = 30;
								continue;
							}
							goto IL_147;
						case 34:
							if (num3 < num2)
							{
								num = 37;
								continue;
							}
							goto IL_2EC;
						case 35:
							if (this.g[0].StartAngle > 90f)
							{
								num = 2;
								continue;
							}
							goto IL_147;
						case 36:
							num = 13;
							continue;
						case 37:
						{
							global::custom_controls.PieSlice pieSlice2;
							pieSlice2.b(graphics);
							num5--;
							num = 8;
							continue;
						}
						case 38:
							if (this.g[0].StartAngle > 270f)
							{
								num = 19;
								continue;
							}
							goto IL_3B3;
						}
						break;
						IL_147:
						num = 38;
						continue;
						IL_1EC:
						pieSlice = (global::custom_controls.PieSlice)arrayList[num4];
						num3 = (450f - pieSlice.EndAngle) % 360f;
						num = 24;
						continue;
						IL_258:
						pieSlice3 = (global::custom_controls.PieSlice)arrayList[0];
						pieSlice3.b(graphics);
						num4 = 1;
						num5 = arrayList.Count - 1;
						num = 31;
						continue;
						IL_2EC:
						num = 23;
						continue;
						IL_312:
						pieSlice3 = (global::custom_controls.PieSlice)arrayList[0];
						array = pieSlice3.a(180f);
						arrayList[0] = array[1];
						num = 29;
						continue;
						IL_3B3:
						num = 11;
						continue;
						IL_430:
						num = 9;
						continue;
						IL_456:
						num3 = 0f;
						num = 6;
						continue;
						IL_4EE:
						num2 = 0f;
						num = 32;
						continue;
						IL_506:
						num = 15;
					}
				}
				IL_30D:
				pieSlice3 = (global::custom_controls.PieSlice)arrayList[num5];
				pieSlice3.b(graphics);
				return;
			}
			}
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x00051AA8 File Offset: 0x0004FCA8
		protected void DrawBottoms(global::System.Drawing.Graphics graphics)
		{
			for (;;)
			{
				IL_3E:
				global::custom_controls.PieSlice[] array = this.g;
				int num = 0;
				int num2 = 1;
				for (;;)
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
						switch (num2)
						{
						case 0:
							return;
						case 1:
							goto IL_51;
						case 2:
							if (num >= array.Length)
							{
								num2 = 0;
								continue;
							}
							goto IL_69;
						case 3:
							goto IL_51;
						}
						goto IL_3E;
						IL_51:
						num2 = 2;
						continue;
					}
					IL_69:
					if (true)
					{
					}
					global::custom_controls.PieSlice pieSlice = array[num];
					pieSlice.a(graphics);
					num++;
					num2 = 3;
				}
			}
		}

		// Token: 0x0600054E RID: 1358 RVA: 0x00051B44 File Offset: 0x0004FD44
		protected void DrawTops(global::System.Drawing.Graphics graphics)
		{
			if (true)
			{
			}
			for (;;)
			{
				global::custom_controls.PieSlice[] array = this.g;
				int num = 0;
				int num2 = 1;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_59;
					case 1:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
							if (false)
							{
							}
							goto IL_59;
						}
						break;
					case 2:
					{
						if (num >= array.Length)
						{
							num2 = 3;
							continue;
						}
						global::custom_controls.PieSlice pieSlice = array[num];
						pieSlice.d(graphics);
						num++;
						num2 = 0;
						continue;
					}
					case 3:
						return;
					}
					break;
					IL_59:
					num2 = 2;
				}
			}
		}

		// Token: 0x0600054F RID: 1359 RVA: 0x00051BDC File Offset: 0x0004FDDC
		private bool a(float[] A_0)
		{
			for (;;)
			{
				switch (0)
				{
				default:
					for (;;)
					{
						int num = 0;
						int num2 = 0;
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_4C;
							case 1:
							{
								if (num >= A_0.Length)
								{
									num2 = 2;
									continue;
								}
								float a_ = A_0[num];
								if (true)
								{
								}
								num2 = 4;
								continue;
							}
							case 2:
								goto IL_64;
							case 3:
								goto IL_4C;
							case 4:
							{
								float a_;
								if (!this.a(a_))
								{
									num2 = 6;
									continue;
								}
								num++;
								num2 = 3;
								continue;
							}
							case 5:
							{
								bool result;
								return result;
							}
							case 6:
							{
								bool result = false;
								num2 = 5;
								continue;
							}
							}
							break;
							IL_4C:
							num2 = 1;
						}
					}
					IL_64:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_B8;
					}
					break;
				}
			}
			IL_B8:
			if (false)
			{
			}
			return true;
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x00051CBC File Offset: 0x0004FEBC
		private bool a(float A_0)
		{
			if (A_0 < 0f)
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
					return false;
				}
			}
			return A_0 <= 1f;
		}

		// Token: 0x040003F5 RID: 1013
		private float a;

		// Token: 0x040003F6 RID: 1014
		private float b;

		// Token: 0x040003F7 RID: 1015
		private float c;

		// Token: 0x040003F8 RID: 1016
		private float d;

		// Token: 0x040003F9 RID: 1017
		private float e;

		// Token: 0x040003FA RID: 1018
		private float f;

		// Token: 0x040003FB RID: 1019
		private global::custom_controls.PieSlice[] g;

		// Token: 0x040003FC RID: 1020
		private global::System.Collections.ArrayList h = new global::System.Collections.ArrayList();

		// Token: 0x040003FD RID: 1021
		private decimal[] i = new decimal[0];

		// Token: 0x040003FE RID: 1022
		private global::System.Drawing.Color[] j = new global::System.Drawing.Color[]
		{
			global::System.Drawing.Color.Red,
			global::System.Drawing.Color.Green,
			global::System.Drawing.Color.Blue,
			global::System.Drawing.Color.Yellow,
			global::System.Drawing.Color.Purple,
			global::System.Drawing.Color.Olive,
			global::System.Drawing.Color.Navy,
			global::System.Drawing.Color.Aqua,
			global::System.Drawing.Color.Lime,
			global::System.Drawing.Color.Maroon,
			global::System.Drawing.Color.Teal,
			global::System.Drawing.Color.Fuchsia
		};

		// Token: 0x040003FF RID: 1023
		private string[] k;

		// Token: 0x04000400 RID: 1024
		private global::System.Drawing.Font l = global::System.Windows.Forms.Control.DefaultFont;

		// Token: 0x04000401 RID: 1025
		private global::System.Drawing.Color m = global::System.Drawing.SystemColors.WindowText;

		// Token: 0x04000402 RID: 1026
		private float[] n;

		// Token: 0x04000403 RID: 1027
		private global::custom_controls.EdgeColorType o;

		// Token: 0x04000404 RID: 1028
		private float p;

		// Token: 0x04000405 RID: 1029
		private global::custom_controls.ShadowStyle q;

		// Token: 0x04000406 RID: 1030
		private bool r;

		// Token: 0x04000407 RID: 1031
		private int s;

		// Token: 0x04000408 RID: 1032
		private bool t;
	}
}
