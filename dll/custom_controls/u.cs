using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;

namespace custom_controls
{
	// Token: 0x02000053 RID: 83
	internal class u : global::custom_controls.o
	{
		// Token: 0x06000389 RID: 905 RVA: 0x0003C7B4 File Offset: 0x0003A9B4
		public byte[] b(byte[] A_0)
		{
			switch (0)
			{
			default:
			{
				if (true)
				{
				}
				byte[] array = null;
				global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(A_0);
				try
				{
					for (;;)
					{
						byte[] array2 = new byte[4];
						memoryStream.Position = 2L;
						memoryStream.Read(array2, 0, 4);
						global::System.BitConverter.ToInt32(array2, 0);
						memoryStream.Position = 10L;
						memoryStream.Read(array2, 0, 4);
						int num = global::System.BitConverter.ToInt32(array2, 0);
						memoryStream.Position = 18L;
						memoryStream.Read(array2, 0, 4);
						int num2 = global::System.BitConverter.ToInt32(array2, 0);
						memoryStream.Position = 22L;
						memoryStream.Read(array2, 0, 4);
						int num3 = global::System.BitConverter.ToInt32(array2, 0);
						memoryStream.Position = 28L;
						memoryStream.Read(array2, 0, 2);
						global::System.BitConverter.ToInt32(array2, 0);
						int num4 = 2 * num2;
						int num5 = num4 * num3;
						byte[] array3 = new byte[num5];
						memoryStream.Position = (long)num;
						memoryStream.Read(array3, 0, num5);
						array = new byte[10 + num5];
						array[0] = 83;
						array[1] = 0;
						array[2] = 70;
						array[3] = 0;
						array[4] = (byte)(num2 << 16 >> 16);
						array[5] = (byte)(num2 << 8 >> 16);
						array[6] = (byte)(num3 << 16 >> 16);
						array[7] = (byte)(num3 << 8 >> 16);
						array[8] = (byte)(num2 << 16 >> 16);
						array[9] = (byte)(num2 << 8 >> 16);
						int num6 = num3 - 1;
						int num7 = 4;
						for (;;)
						{
							switch (num7)
							{
							case 0:
								num7 = 3;
								continue;
							case 1:
							{
								int num8;
								if (num8 >= num2 * 2)
								{
									num7 = 6;
									continue;
								}
								int num9;
								array[num9 * num4 + num8 + 10] = array3[num6 * num4 + num8];
								num8++;
								num7 = 2;
								continue;
							}
							case 2:
								goto IL_201;
							case 3:
								goto IL_232;
							case 4:
								goto IL_1B4;
							case 5:
							{
								if (num6 < 0)
								{
									num7 = 0;
									continue;
								}
								int num9 = num3 - num6 - 1;
								int num8 = 0;
								num7 = 7;
								continue;
							}
							case 6:
								num6--;
								num7 = 8;
								continue;
							case 7:
								goto IL_201;
							case 8:
								goto IL_1B4;
							}
							break;
							IL_1B4:
							num7 = 5;
							continue;
							IL_201:
							num7 = 1;
						}
					}
					IL_232:;
				}
				finally
				{
					int num7 = 1;
					for (;;)
					{
						switch (num7)
						{
						case 0:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								goto IL_285;
							}
							break;
						case 2:
							((global::System.IDisposable)memoryStream).Dispose();
							num7 = 0;
							continue;
						}
						if (memoryStream == null)
						{
							goto IL_28D;
						}
						num7 = 2;
					}
					IL_285:
					if (false)
					{
					}
					IL_28D:;
				}
				return array;
			}
			}
		}

		// Token: 0x0600038A RID: 906 RVA: 0x0003CA6C File Offset: 0x0003AC6C
		public byte[] a(byte[] A_0)
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
			int num = (int)global::System.BitConverter.ToInt16(A_0, 4);
			int num2 = (int)global::System.BitConverter.ToInt16(A_0, 6);
			byte[] array = null;
			global::System.Drawing.Bitmap bitmap = new global::System.Drawing.Bitmap(num, num2, global::System.Drawing.Imaging.PixelFormat.Format16bppRgb565);
			try
			{
				for (;;)
				{
					global::System.Drawing.Imaging.BitmapData bitmapData = bitmap.LockBits(new global::System.Drawing.Rectangle(0, 0, bitmap.Width, bitmap.Height), global::System.Drawing.Imaging.ImageLockMode.WriteOnly, bitmap.PixelFormat);
					int num3 = num * 2;
					byte[] array2 = new byte[A_0.Length - 10];
					int num4 = num2 - 1;
					int num5 = 9;
					for (;;)
					{
						int num6;
						switch (num5)
						{
						case 0:
							goto IL_1DB;
						case 1:
						{
							global::System.Runtime.InteropServices.Marshal.Copy(array2, 0, bitmapData.Scan0, array2.Length);
							bitmap.UnlockBits(bitmapData);
							global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
							num5 = 2;
							continue;
						}
						case 2:
							try
							{
								global::System.IO.MemoryStream memoryStream;
								bitmap.Save(memoryStream, global::System.Drawing.Imaging.ImageFormat.Bmp);
								memoryStream.Flush();
								array = new byte[memoryStream.Length];
								memoryStream.Seek(0L, global::System.IO.SeekOrigin.Begin);
								memoryStream.Read(array, 0, (int)memoryStream.Length);
								array[30] = 0;
								goto IL_223;
							}
							finally
							{
								num5 = 0;
								for (;;)
								{
									global::System.IO.MemoryStream memoryStream;
									switch (num5)
									{
									case 1:
										goto IL_180;
									case 2:
										((global::System.IDisposable)memoryStream).Dispose();
										num5 = 1;
										continue;
									}
									if (memoryStream == null)
									{
										break;
									}
									num5 = 2;
								}
								IL_180:;
							}
							goto IL_183;
							IL_223:
							num5 = 5;
							continue;
						case 3:
							if (num4 < 0)
							{
								num5 = 1;
								continue;
							}
							goto IL_183;
						case 4:
							goto IL_1FE;
						case 5:
							goto IL_22F;
						case 6:
							if (num6 >= num3)
							{
								num5 = 8;
								continue;
							}
							array2[num4 * num3 + num6] = A_0[num4 * num3 + num6 + 10];
							num6++;
							num5 = 0;
							continue;
						case 7:
							goto IL_1DB;
						case 8:
							num4--;
							num5 = 4;
							continue;
						case 9:
							goto IL_1FE;
						}
						break;
						IL_183:
						num6 = 0;
						num5 = 7;
						continue;
						IL_1DB:
						num5 = 6;
						continue;
						IL_1FE:
						num5 = 3;
					}
				}
				IL_22F:;
			}
			finally
			{
				int num5 = 1;
				for (;;)
				{
					switch (num5)
					{
					case 0:
						goto IL_26C;
					case 2:
						((global::System.IDisposable)bitmap).Dispose();
						num5 = 0;
						continue;
					}
					if (bitmap == null)
					{
						break;
					}
					num5 = 2;
				}
				IL_26C:;
			}
			return array;
		}

		// Token: 0x04000287 RID: 647
		private const int a = 2;

		// Token: 0x04000288 RID: 648
		private const int b = 10;
	}
}
