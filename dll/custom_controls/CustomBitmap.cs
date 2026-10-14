using System;

namespace custom_controls
{
	// Token: 0x02000046 RID: 70
	public class CustomBitmap
	{
		// Token: 0x06000351 RID: 849 RVA: 0x000393C8 File Offset: 0x000375C8
		public bool ProcessBMP(ref global::custom_controls.CustomBitmap.StructBitmap sbmp, byte[] bytesFile)
		{
			switch (0)
			{
			default:
			{
				byte[] array3;
				for (;;)
				{
					IL_3F:
					byte[] array = new byte[2];
					byte[] array2 = new byte[4];
					array[0] = bytesFile[0];
					array[1] = bytesFile[1];
					sbmp.Header.Identifier = this.a(array);
					for (;;)
					{
						int num = 1;
						for (;;)
						{
							switch (num)
							{
							case 0:
							{
								sbmp.Palette.Palette = array3;
								int num2 = 0;
								array3 = new byte[sbmp.Header.FileSize - sbmp.Header.BitMapDataOffset];
								int num3 = sbmp.Header.BitMapDataOffset;
								if (true)
								{
								}
								num = 9;
								continue;
							}
							case 1:
							{
								if (!sbmp.Header.Identifier.Equals("BM"))
								{
									num = 2;
									continue;
								}
								array2[0] = bytesFile[2];
								array2[1] = bytesFile[3];
								array2[2] = bytesFile[4];
								array2[3] = bytesFile[5];
								sbmp.Header.FileSize = this.b(array2);
								array2[0] = bytesFile[10];
								array2[1] = bytesFile[11];
								array2[2] = bytesFile[12];
								array2[3] = bytesFile[13];
								sbmp.Header.BitMapDataOffset = this.b(array2);
								array2[0] = bytesFile[14];
								array2[1] = bytesFile[15];
								array2[2] = bytesFile[16];
								array2[3] = bytesFile[17];
								sbmp.Header.BitMapHeaderSize = this.b(array2);
								array2[0] = bytesFile[18];
								array2[1] = bytesFile[19];
								array2[2] = bytesFile[20];
								array2[3] = bytesFile[21];
								sbmp.Header.Width = this.b(array2);
								array2[0] = bytesFile[22];
								array2[1] = bytesFile[23];
								array2[2] = bytesFile[24];
								array2[3] = bytesFile[25];
								sbmp.Header.Height = this.b(array2);
								array[0] = bytesFile[26];
								array[1] = bytesFile[27];
								sbmp.Header.Planes = (short)this.b(array);
								array[0] = bytesFile[28];
								array[1] = bytesFile[29];
								sbmp.Header.BitsPerPixel = (short)this.b(array);
								array2[0] = bytesFile[30];
								array2[1] = bytesFile[31];
								array2[2] = bytesFile[32];
								array2[3] = bytesFile[33];
								sbmp.Header.Compression = this.b(array2);
								array2[0] = bytesFile[34];
								array2[1] = bytesFile[35];
								array2[2] = bytesFile[36];
								array2[3] = bytesFile[37];
								sbmp.Header.BitMapDataSize = this.b(array2);
								array2[0] = bytesFile[38];
								array2[1] = bytesFile[39];
								array2[2] = bytesFile[40];
								array2[3] = bytesFile[41];
								sbmp.Header.HResolution = this.b(array2);
								array2[0] = bytesFile[42];
								array2[1] = bytesFile[43];
								array2[2] = bytesFile[44];
								array2[3] = bytesFile[45];
								sbmp.Header.VResolution = this.b(array2);
								array2[0] = bytesFile[46];
								array2[1] = bytesFile[47];
								array2[2] = bytesFile[48];
								array2[3] = bytesFile[49];
								sbmp.Header.Colors = this.b(array2);
								array2[0] = bytesFile[50];
								array2[1] = bytesFile[51];
								array2[2] = bytesFile[52];
								array2[3] = bytesFile[53];
								sbmp.Header.ImportantColors = this.b(array2);
								int num2 = 0;
								array3 = new byte[sbmp.Header.BitMapDataOffset - 54];
								int num4 = 54;
								num = 8;
								continue;
							}
							case 2:
								return false;
							case 3:
							{
								int num4;
								if (num4 >= sbmp.Header.BitMapDataOffset)
								{
									num = 0;
									continue;
								}
								int num2;
								array3[num2] = bytesFile[num4];
								num2++;
								num4++;
								num = 5;
								continue;
							}
							case 4:
								goto IL_38C;
							case 5:
								goto IL_F0;
							case 6:
							{
								int num3;
								if (num3 >= sbmp.Header.FileSize)
								{
									num = 7;
									continue;
								}
								int num2;
								array3[num2] = bytesFile[num3];
								num2++;
								num3++;
								num = 4;
								continue;
							}
							case 7:
								goto IL_3B3;
							case 8:
								goto IL_F0;
							case 9:
								goto IL_38C;
							}
							goto IL_3F;
							IL_F0:
							num = 3;
							continue;
							IL_38C:
							num = 6;
						}
						IL_3B3:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_3C9;
						}
					}
				}
				return false;
				IL_3C9:
				if (false)
				{
				}
				sbmp.Data.BitMapData = array3;
				return true;
			}
			}
		}

		// Token: 0x06000352 RID: 850 RVA: 0x000397F8 File Offset: 0x000379F8
		private int b(byte[] A_0)
		{
			int num;
			for (;;)
			{
				num = 0;
				int num2 = A_0.Length - 1;
				int num3 = 6;
				for (;;)
				{
					switch (num3)
					{
					case 0:
					{
						int num4 = (int)global::System.Math.Pow(256.0, (double)num2);
						num += (int)A_0[num2] * num4;
						num3 = 4;
						continue;
					}
					case 1:
						if (A_0[num2] != 0)
						{
							num3 = 0;
							continue;
						}
						goto IL_42;
					case 2:
						goto IL_99;
					case 3:
						if (num2 >= 0)
						{
							num3 = 1;
							continue;
						}
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							if (false)
							{
							}
							num3 = 5;
							continue;
						}
						break;
					case 4:
						goto IL_42;
					case 5:
						return num;
					case 6:
						goto IL_99;
					}
					break;
					IL_42:
					num2--;
					if (true)
					{
					}
					num3 = 2;
					continue;
					IL_99:
					num3 = 3;
				}
			}
			return num;
		}

		// Token: 0x06000353 RID: 851 RVA: 0x000398D8 File Offset: 0x00037AD8
		private string a(byte[] A_0)
		{
			string text;
			for (;;)
			{
				text = string.Empty;
				int num = 0;
				int num2 = 2;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						return text;
					case 1:
						if (num >= A_0.Length)
						{
							num2 = 0;
							continue;
						}
						text += global::System.Convert.ToChar((int)A_0[num]).ToString();
						num++;
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_28;
						}
						if (true)
						{
						}
						if (false)
						{
						}
						num2 = 3;
						continue;
					case 2:
						goto IL_28;
					case 3:
						goto IL_2A;
					}
					break;
					IL_2A:
					num2 = 1;
					continue;
					IL_28:
					goto IL_2A;
				}
			}
			return text;
		}

		// Token: 0x02000047 RID: 71
		public struct StructBitmap
		{
			// Token: 0x0400025F RID: 607
			public global::custom_controls.CustomBitmap.BMPHeader Header;

			// Token: 0x04000260 RID: 608
			public global::custom_controls.CustomBitmap.BMPPalette Palette;

			// Token: 0x04000261 RID: 609
			public global::custom_controls.CustomBitmap.BMPData Data;
		}

		// Token: 0x02000048 RID: 72
		public struct BMPHeader
		{
			// Token: 0x04000262 RID: 610
			public string Identifier;

			// Token: 0x04000263 RID: 611
			public int FileSize;

			// Token: 0x04000264 RID: 612
			public byte[] Reserved;

			// Token: 0x04000265 RID: 613
			public int BitMapDataOffset;

			// Token: 0x04000266 RID: 614
			public int BitMapHeaderSize;

			// Token: 0x04000267 RID: 615
			public int Width;

			// Token: 0x04000268 RID: 616
			public int Height;

			// Token: 0x04000269 RID: 617
			public short Planes;

			// Token: 0x0400026A RID: 618
			public short BitsPerPixel;

			// Token: 0x0400026B RID: 619
			public int Compression;

			// Token: 0x0400026C RID: 620
			public int BitMapDataSize;

			// Token: 0x0400026D RID: 621
			public int HResolution;

			// Token: 0x0400026E RID: 622
			public int VResolution;

			// Token: 0x0400026F RID: 623
			public int Colors;

			// Token: 0x04000270 RID: 624
			public int ImportantColors;
		}

		// Token: 0x02000049 RID: 73
		public struct BMPPalette
		{
			// Token: 0x04000271 RID: 625
			public byte[] Palette;
		}

		// Token: 0x0200004A RID: 74
		public struct BMPData
		{
			// Token: 0x04000272 RID: 626
			public byte[] BitMapData;
		}
	}
}
