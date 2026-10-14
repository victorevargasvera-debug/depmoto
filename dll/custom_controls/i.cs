using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace custom_controls
{
	// Token: 0x02000052 RID: 82
	internal class i : global::custom_controls.o
	{
		// Token: 0x06000386 RID: 902 RVA: 0x0003BF5C File Offset: 0x0003A15C
		public byte[] b(byte[] A_0)
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
					byte[] array4 = new byte[num - 54];
					memoryStream.Position = 54L;
					memoryStream.Read(array4, 0, num - 54);
					int num8 = 512;
					array = new byte[11 + num8 * 3 + num6];
					array[0] = global::System.Convert.ToByte(num4);
					array[1] = (byte)(num8 << 16 >> 16);
					array[2] = (byte)(num8 << 8 >> 16);
					int num9 = 0;
					int num10 = 12;
					for (;;)
					{
						switch (num10)
						{
						case 0:
						{
							int num11;
							if (num11 < 0)
							{
								num10 = 6;
								continue;
							}
							int num12 = num3 - num11 - 1;
							int num13 = 0;
							num10 = 10;
							continue;
						}
						case 1:
						{
							int num14;
							if (num14 >= array4.Length)
							{
								num10 = 14;
								continue;
							}
							array[11 + num8 + num6 + num14] = array4[num14];
							num14++;
							num10 = 9;
							continue;
						}
						case 2:
							goto IL_2B1;
						case 3:
						{
							int num11;
							num11--;
							num10 = 7;
							continue;
						}
						case 4:
						{
							if (num9 >= array4.Length / 4)
							{
								num10 = 16;
								continue;
							}
							int num15 = (int)array4[num9 * 4 + 2];
							int num16 = (int)array4[num9 * 4 + 1];
							int num17 = (int)array4[num9 * 4];
							int num18 = (int)((double)num15 * 31.0 / 255.0 + 0.5) << 11 | (int)((double)num16 * 63.0 / 255.0 + 0.5) << 5 | (int)((double)num17 * 31.0 / 255.0 + 0.5);
							array[2 * num9 + 3] = (byte)(num18 << 8 >> 16);
							array[2 * num9 + 4] = (byte)(num18 << 16 >> 16);
							num9++;
							num10 = 11;
							continue;
						}
						case 5:
							goto IL_2D0;
						case 6:
						{
							int num14 = 0;
							num10 = 5;
							continue;
						}
						case 7:
							goto IL_2B1;
						case 8:
							goto IL_461;
						case 9:
							goto IL_2D0;
						case 10:
							goto IL_2F8;
						case 11:
							goto IL_287;
						case 12:
							goto IL_287;
						case 13:
							goto IL_2F8;
						case 14:
							num10 = 8;
							continue;
						case 15:
						{
							int num13;
							int num19;
							if (num13 >= num19)
							{
								num10 = 3;
								continue;
							}
							int num11;
							int num12;
							array[num12 * num19 + num13 + 11 + num8] = array3[num11 * num19 + num13];
							num13++;
							num10 = 13;
							continue;
						}
						case 16:
						{
							array[3 + num8] = 83;
							array[4 + num8] = 70;
							array[5 + num8] = (byte)(num2 << 16 >> 16);
							array[6 + num8] = (byte)(num2 << 8 >> 16);
							array[7 + num8] = (byte)(num3 << 16 >> 16);
							array[8 + num8] = (byte)(num3 << 8 >> 16);
							array[9 + num8] = (byte)(num2 << 16 >> 16);
							array[10 + num8] = (byte)(num2 << 8 >> 16);
							int num19 = num2 + num7;
							int num11 = num3 - 1;
							num10 = 2;
							continue;
						}
						}
						break;
						IL_287:
						num10 = 4;
						continue;
						IL_2B1:
						num10 = 0;
						continue;
						IL_2D0:
						num10 = 1;
						continue;
						IL_2F8:
						num10 = 15;
					}
				}
				IL_461:;
			}
			finally
			{
				int num10 = 2;
				for (;;)
				{
					switch (num10)
					{
					case 0:
						((global::System.IDisposable)memoryStream).Dispose();
						num10 = 1;
						continue;
					case 1:
						goto IL_49E;
					}
					if (memoryStream == null)
					{
						break;
					}
					num10 = 0;
				}
				IL_49E:;
			}
			return array;
		}

		// Token: 0x06000387 RID: 903 RVA: 0x0003C428 File Offset: 0x0003A628
		public byte[] a(byte[] A_0)
		{
			byte[] array3;
			for (;;)
			{
				switch (0)
				{
				default:
				{
					byte[] array = new byte[0];
					byte[] array2 = new byte[0];
					array3 = null;
					global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
					try
					{
						int num = (int)global::System.Convert.ToInt16(((int)A_0[2] << 8) + (int)A_0[1]);
						int num2 = (int)global::System.Convert.ToInt16(((int)A_0[num + 6] << 8) + (int)A_0[num + 5]);
						int num3 = (int)global::System.Convert.ToInt16(((int)A_0[num + 8] << 8) + (int)A_0[num + 7]);
						global::System.Drawing.Bitmap bitmap = new global::System.Drawing.Bitmap(num2, num3, global::System.Drawing.Imaging.PixelFormat.Format8bppIndexed);
						try
						{
							for (;;)
							{
								bitmap.Save(memoryStream, global::System.Drawing.Imaging.ImageFormat.Bmp);
								memoryStream.Flush();
								array2 = new byte[A_0.Length - (num * 3 + 11)];
								int num4 = (A_0.Length - (num * 3 + 11)) / num3;
								int num5 = num4 - num2;
								int num6 = num2 + num5;
								int num7 = num3 - 1;
								int num8 = 2;
								for (;;)
								{
									switch (num8)
									{
									case 0:
										memoryStream.Position = 54L;
										memoryStream.Write(array, 0, array.Length);
										memoryStream.Position = (long)(54 + array.Length);
										memoryStream.Write(array2, 0, array2.Length);
										memoryStream.Flush();
										array3 = new byte[memoryStream.Length];
										memoryStream.Seek(0L, global::System.IO.SeekOrigin.Begin);
										memoryStream.Read(array3, 0, (int)memoryStream.Length);
										num8 = 1;
										continue;
									case 1:
										goto IL_283;
									case 2:
										goto IL_1CB;
									case 3:
										goto IL_156;
									case 4:
									{
										int num9;
										if (num9 >= array.Length)
										{
											num8 = 0;
											continue;
										}
										array[num9] = A_0[A_0.Length - array.Length + num9];
										num9++;
										num8 = 8;
										continue;
									}
									case 5:
										goto IL_1ED;
									case 6:
										goto IL_1CB;
									case 7:
										num7--;
										num8 = 6;
										continue;
									case 8:
										goto IL_156;
									case 9:
									{
										if (num7 < 0)
										{
											num8 = 10;
											continue;
										}
										int num10 = num3 - num7 - 1;
										int num11 = 0;
										num8 = 12;
										continue;
									}
									case 10:
									{
										array = new byte[num * 2];
										int num9 = 0;
										num8 = 3;
										continue;
									}
									case 11:
									{
										int num11;
										if (num11 >= num6)
										{
											num8 = 7;
											continue;
										}
										int num10;
										array2[num10 * num6 + num11] = A_0[num7 * num6 + num11 + num + 11];
										num11++;
										num8 = 5;
										continue;
									}
									case 12:
										goto IL_1ED;
									}
									break;
									IL_156:
									num8 = 4;
									continue;
									IL_1CB:
									num8 = 9;
									continue;
									IL_1ED:
									num8 = 11;
								}
							}
							IL_283:;
						}
						finally
						{
							int num8 = 1;
							for (;;)
							{
								switch (num8)
								{
								case 0:
									goto IL_2C2;
								case 2:
									((global::System.IDisposable)bitmap).Dispose();
									num8 = 0;
									continue;
								}
								if (bitmap == null)
								{
									break;
								}
								num8 = 2;
							}
							IL_2C2:;
						}
						if (true)
						{
						}
					}
					finally
					{
						int num8 = 0;
						for (;;)
						{
							switch (num8)
							{
							case 1:
								((global::System.IDisposable)memoryStream).Dispose();
								num8 = 2;
								continue;
							case 2:
								goto IL_30C;
							}
							if (memoryStream == null)
							{
								break;
							}
							num8 = 1;
						}
						IL_30C:;
					}
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_325;
					}
					break;
				}
				}
			}
			IL_325:
			if (false)
			{
			}
			return array3;
		}
	}
}
