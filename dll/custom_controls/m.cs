using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace custom_controls
{
	// Token: 0x02000051 RID: 81
	internal class m : global::custom_controls.o
	{
		// Token: 0x06000383 RID: 899 RVA: 0x0003B8EC File Offset: 0x00039AEC
		public byte[] b(byte[] A_0)
		{
			switch (0)
			{
			default:
			{
				if (true)
				{
				}
				byte[] array = new byte[0];
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
						int num4 = global::System.BitConverter.ToInt32(array2, 0);
						int num5 = (num4 * num2 + 31) / 32 * 4;
						int num6 = num5 * num3;
						int num7 = num5 - num2;
						byte[] array3 = new byte[num6];
						memoryStream.Position = (long)num;
						memoryStream.Read(array3, 0, num6);
						int num8 = num2 / 8;
						int num9 = 3;
						for (;;)
						{
							int num10;
							int num13;
							switch (num9)
							{
							case 0:
								num10--;
								num9 = 10;
								continue;
							case 1:
								goto IL_1FF;
							case 2:
								goto IL_15D;
							case 3:
								if (num2 % 8 > 0)
								{
									goto IL_14C;
								}
								goto IL_15D;
							case 4:
								num8++;
								num9 = 2;
								continue;
							case 5:
							{
								if (num10 < 0)
								{
									num9 = 7;
									continue;
								}
								int num11 = num3 - num10 - 1;
								int num12 = 0;
								num9 = 1;
								continue;
							}
							case 6:
								goto IL_21F;
							case 7:
								num9 = 8;
								continue;
							case 8:
								goto IL_2B1;
							case 9:
								goto IL_1FF;
							case 10:
								goto IL_21F;
							case 11:
							{
								int num12;
								if (num12 >= num8)
								{
									num9 = 0;
									continue;
								}
								switch ((1 == 1) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_14C;
								default:
								{
									if (false)
									{
									}
									int num11;
									array[num11 * num8 + num12 + 8] = array3[num10 * num13 + num12];
									num12++;
									num9 = 9;
									continue;
								}
								}
								break;
							}
							}
							break;
							IL_14C:
							num9 = 4;
							continue;
							IL_15D:
							array = new byte[8 + num3 * num8];
							array[0] = 83;
							array[1] = 70;
							array[2] = (byte)(num2 << 16 >> 16);
							array[3] = (byte)(num2 << 8 >> 16);
							array[4] = (byte)(num3 << 16 >> 16);
							array[5] = (byte)(num3 << 8 >> 16);
							array[6] = (byte)(num8 << 16 >> 16);
							array[7] = (byte)(num8 << 8 >> 16);
							num13 = num2 + num7;
							num10 = num3 - 1;
							num9 = 6;
							continue;
							IL_1FF:
							num9 = 11;
							continue;
							IL_21F:
							num9 = 5;
						}
					}
					IL_2B1:;
				}
				finally
				{
					int num9 = 1;
					for (;;)
					{
						switch (num9)
						{
						case 0:
							goto IL_2EE;
						case 2:
							((global::System.IDisposable)memoryStream).Dispose();
							num9 = 0;
							continue;
						}
						if (memoryStream == null)
						{
							break;
						}
						num9 = 2;
					}
					IL_2EE:;
				}
				return array;
			}
			}
		}

		// Token: 0x06000384 RID: 900 RVA: 0x0003BC08 File Offset: 0x00039E08
		public byte[] a(byte[] A_0)
		{
			switch (0)
			{
			default:
			{
				if (true)
				{
				}
				byte[] array = new byte[0];
				byte[] array2 = new byte[0];
				byte[] array3 = null;
				global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
				try
				{
					int width = (int)global::System.Convert.ToInt16(((int)A_0[3] << 8) + (int)A_0[2]);
					int num = (int)global::System.Convert.ToInt16(((int)A_0[5] << 8) + (int)A_0[4]);
					global::System.Drawing.Bitmap bitmap = new global::System.Drawing.Bitmap(width, num, global::System.Drawing.Imaging.PixelFormat.Format1bppIndexed);
					try
					{
						for (;;)
						{
							bitmap.Save(memoryStream, global::System.Drawing.Imaging.ImageFormat.Bmp);
							memoryStream.Flush();
							array = new byte[8];
							int num2 = 0;
							int num3 = 3;
							for (;;)
							{
								switch (num3)
								{
								case 0:
									goto IL_10F;
								case 1:
									goto IL_D3;
								case 2:
									memoryStream.Position = 54L;
									memoryStream.Write(array, 0, array.Length);
									memoryStream.Position = (long)(54 + array.Length);
									memoryStream.Write(array2, 0, array2.Length);
									memoryStream.Flush();
									array3 = new byte[memoryStream.Length];
									memoryStream.Seek(0L, global::System.IO.SeekOrigin.Begin);
									memoryStream.Read(array3, 0, (int)memoryStream.Length);
									num3 = 6;
									continue;
								case 3:
									goto IL_D3;
								case 4:
								{
									int num4;
									num4--;
									num3 = 8;
									continue;
								}
								case 5:
									goto IL_EF;
								case 6:
									goto IL_25C;
								case 7:
								{
									int num5;
									int num6;
									if (num5 >= num6)
									{
										num3 = 4;
										continue;
									}
									int num4;
									int num7;
									int num8;
									array2[num7 * num8 + num5] = A_0[num4 * num6 + num5 + 8];
									num5++;
									num3 = 9;
									continue;
								}
								case 8:
									goto IL_10F;
								case 9:
									goto IL_EF;
								case 10:
								{
									int num6 = (A_0.Length - 5) / num;
									int num8 = (int)(memoryStream.Length - 62L) / num;
									array2 = new byte[memoryStream.Length - 62L];
									int num4 = num - 1;
									num3 = 0;
									continue;
								}
								case 11:
									if (num2 >= 3)
									{
										num3 = 10;
										continue;
									}
									array[num2] = byte.MaxValue;
									num2++;
									num3 = 1;
									continue;
								case 12:
								{
									int num4;
									if (num4 < 0)
									{
										num3 = 2;
										continue;
									}
									int num7 = num - num4 - 1;
									int num5 = 0;
									num3 = 5;
									continue;
								}
								}
								break;
								IL_D3:
								num3 = 11;
								continue;
								IL_EF:
								num3 = 7;
								continue;
								IL_10F:
								num3 = 12;
							}
						}
						IL_25C:;
					}
					finally
					{
						int num3 = 1;
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
								switch (num3)
								{
								case 0:
									goto IL_2B7;
								case 2:
									((global::System.IDisposable)bitmap).Dispose();
									num3 = 0;
									continue;
								}
								break;
							}
							if (bitmap == null)
							{
								break;
							}
							num3 = 2;
						}
						IL_2B7:;
					}
				}
				finally
				{
					int num3 = 0;
					for (;;)
					{
						switch (num3)
						{
						case 1:
							((global::System.IDisposable)memoryStream).Dispose();
							num3 = 2;
							continue;
						case 2:
							goto IL_2F9;
						}
						if (memoryStream == null)
						{
							break;
						}
						num3 = 1;
					}
					IL_2F9:;
				}
				return array3;
			}
			}
		}
	}
}
