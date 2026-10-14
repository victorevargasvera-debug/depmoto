using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using custom_controls.Properties;

namespace custom_controls
{
	// Token: 0x0200004B RID: 75
	public class CustomImageBox : global::System.Windows.Forms.UserControl
	{
		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06000354 RID: 852 RVA: 0x00039980 File Offset: 0x00037B80
		public global::System.Windows.Forms.Button SelectButton
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
				return this.n;
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000355 RID: 853 RVA: 0x000399C4 File Offset: 0x00037BC4
		public global::System.Windows.Forms.Button RemoveButton
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
				return this.o;
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000356 RID: 854 RVA: 0x00039A08 File Offset: 0x00037C08
		// (set) Token: 0x06000357 RID: 855 RVA: 0x00039A4C File Offset: 0x00037C4C
		public override global::System.Drawing.Font Font
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
				return base.Font;
			}
			set
			{
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
							this.n.Font = value;
							this.o.Font = value;
							base.Font = value;
							if (true)
							{
							}
							num = 2;
							continue;
						}
						break;
					case 2:
						return;
					}
					if (base.Font.Equals(value))
					{
						break;
					}
					num = 0;
				}
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000358 RID: 856 RVA: 0x00039AE4 File Offset: 0x00037CE4
		// (set) Token: 0x06000359 RID: 857 RVA: 0x00039B28 File Offset: 0x00037D28
		public string OpenFileDialogFilter
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
				switch (1 == 1)
				{
				}
				if (true)
				{
				}
				if (false)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x0600035A RID: 858 RVA: 0x00039B6C File Offset: 0x00037D6C
		// (set) Token: 0x0600035B RID: 859 RVA: 0x00039BB0 File Offset: 0x00037DB0
		public bool MatchModel
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
				return this.c;
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
				this.c = value;
			}
		}

		// Token: 0x14000011 RID: 17
		// (add) Token: 0x0600035C RID: 860 RVA: 0x00039BF4 File Offset: 0x00037DF4
		// (remove) Token: 0x0600035D RID: 861 RVA: 0x00039C8C File Offset: 0x00037E8C
		public event global::custom_controls.CustomImageBox.MatchRadioModel MatchRadio
		{
			add
			{
				for (;;)
				{
					IL_38:
					global::custom_controls.CustomImageBox.MatchRadioModel matchRadioModel = this.d;
					int num = 0;
					for (;;)
					{
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_78;
						default:
							if (true)
							{
							}
							if (false)
							{
							}
							switch (num)
							{
							case 0:
								goto IL_49;
							case 1:
								return;
							case 2:
								goto IL_78;
							}
							goto IL_38;
						}
						IL_49:
						global::custom_controls.CustomImageBox.MatchRadioModel matchRadioModel2 = matchRadioModel;
						global::custom_controls.CustomImageBox.MatchRadioModel value2 = (global::custom_controls.CustomImageBox.MatchRadioModel)global::System.Delegate.Combine(matchRadioModel2, value);
						matchRadioModel = global::System.Threading.Interlocked.CompareExchange<global::custom_controls.CustomImageBox.MatchRadioModel>(ref this.d, value2, matchRadioModel2);
						num = 2;
						continue;
						IL_78:
						if (matchRadioModel != matchRadioModel2)
						{
							goto IL_49;
						}
						num = 1;
					}
				}
			}
			remove
			{
				for (;;)
				{
					IL_30:
					global::custom_controls.CustomImageBox.MatchRadioModel matchRadioModel = this.d;
					int num = 2;
					for (;;)
					{
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_66;
						default:
							if (false)
							{
							}
							switch (num)
							{
							case 0:
								goto IL_66;
							case 1:
								return;
							case 2:
								goto IL_41;
							}
							goto IL_30;
						}
						IL_41:
						global::custom_controls.CustomImageBox.MatchRadioModel matchRadioModel2 = matchRadioModel;
						global::custom_controls.CustomImageBox.MatchRadioModel value2 = (global::custom_controls.CustomImageBox.MatchRadioModel)global::System.Delegate.Remove(matchRadioModel2, value);
						matchRadioModel = global::System.Threading.Interlocked.CompareExchange<global::custom_controls.CustomImageBox.MatchRadioModel>(ref this.d, value2, matchRadioModel2);
						num = 0;
						continue;
						IL_66:
						if (matchRadioModel != matchRadioModel2)
						{
							goto IL_41;
						}
						if (true)
						{
						}
						num = 1;
					}
				}
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x0600035E RID: 862 RVA: 0x00039D24 File Offset: 0x00037F24
		// (set) Token: 0x0600035F RID: 863 RVA: 0x00039D68 File Offset: 0x00037F68
		public string FileName
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
				return this.f;
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
				this.f = value;
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x06000360 RID: 864 RVA: 0x00039DAC File Offset: 0x00037FAC
		// (set) Token: 0x06000361 RID: 865 RVA: 0x00039DF0 File Offset: 0x00037FF0
		public bool FileLoading
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
				return this.g;
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
				this.g = value;
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000362 RID: 866 RVA: 0x00039E34 File Offset: 0x00038034
		// (set) Token: 0x06000363 RID: 867 RVA: 0x00039E78 File Offset: 0x00038078
		public global::System.Drawing.Imaging.PixelFormat ImagePixelFormat
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
				return this.h;
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
				this.h = value;
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06000364 RID: 868 RVA: 0x00039EBC File Offset: 0x000380BC
		// (set) Token: 0x06000365 RID: 869 RVA: 0x00039F00 File Offset: 0x00038100
		public global::custom_controls.CustomImageBox.ImageModelEnum ImageModel
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

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x06000366 RID: 870 RVA: 0x00039F44 File Offset: 0x00038144
		// (set) Token: 0x06000367 RID: 871 RVA: 0x00039F88 File Offset: 0x00038188
		public bool NoSignImage
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
				return this.j;
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
				this.j = value;
			}
		}

		// Token: 0x14000012 RID: 18
		// (add) Token: 0x06000368 RID: 872 RVA: 0x00039FCC File Offset: 0x000381CC
		// (remove) Token: 0x06000369 RID: 873 RVA: 0x0003A064 File Offset: 0x00038264
		public event global::custom_controls.CustomImageBox.ImageDataEvent ImageDataChanged
		{
			add
			{
				for (;;)
				{
					global::custom_controls.CustomImageBox.ImageDataEvent imageDataEvent = this.k;
					int num = 1;
					for (;;)
					{
						switch (num)
						{
						case 0:
						{
							global::custom_controls.CustomImageBox.ImageDataEvent imageDataEvent2;
							if (imageDataEvent == imageDataEvent2)
							{
								num = 2;
								continue;
							}
							goto IL_25;
						}
						case 1:
							goto IL_25;
						case 2:
							return;
						}
						break;
						IL_25:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
						{
							if (false)
							{
							}
							if (true)
							{
							}
							global::custom_controls.CustomImageBox.ImageDataEvent imageDataEvent2 = imageDataEvent;
							global::custom_controls.CustomImageBox.ImageDataEvent value2 = (global::custom_controls.CustomImageBox.ImageDataEvent)global::System.Delegate.Combine(imageDataEvent2, value);
							imageDataEvent = global::System.Threading.Interlocked.CompareExchange<global::custom_controls.CustomImageBox.ImageDataEvent>(ref this.k, value2, imageDataEvent2);
							break;
						}
						}
						num = 0;
					}
				}
			}
			remove
			{
				for (;;)
				{
					global::custom_controls.CustomImageBox.ImageDataEvent imageDataEvent = this.k;
					int num = 1;
					for (;;)
					{
						global::custom_controls.CustomImageBox.ImageDataEvent imageDataEvent2;
						switch (num)
						{
						case 0:
							return;
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
								goto IL_4B;
							}
							break;
						case 2:
							if (imageDataEvent == imageDataEvent2)
							{
								if (true)
								{
								}
								num = 0;
								continue;
							}
							goto IL_4B;
						}
						break;
						IL_4B:
						imageDataEvent2 = imageDataEvent;
						global::custom_controls.CustomImageBox.ImageDataEvent value2 = (global::custom_controls.CustomImageBox.ImageDataEvent)global::System.Delegate.Remove(imageDataEvent2, value);
						imageDataEvent = global::System.Threading.Interlocked.CompareExchange<global::custom_controls.CustomImageBox.ImageDataEvent>(ref this.k, value2, imageDataEvent2);
						num = 2;
					}
				}
			}
		}

		// Token: 0x0600036A RID: 874 RVA: 0x0003A0FC File Offset: 0x000382FC
		public CustomImageBox()
		{
			this.a();
			this.f = string.Empty;
			this.g = true;
			this.j = true;
			this.i = global::custom_controls.CustomImageBox.ImageModelEnum.BALI;
			this.h = global::System.Drawing.Imaging.PixelFormat.Format8bppIndexed;
			this.LoadNosignImage();
			this.g = false;
		}

		// Token: 0x0600036B RID: 875 RVA: 0x0003A158 File Offset: 0x00038358
		public bool FromFile(string filename)
		{
			int num = 1;
			for (;;)
			{
				global::System.IO.FileStream fileStream;
				switch (num)
				{
				case 0:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						return false;
					default:
						if (false)
						{
						}
						goto IL_ED;
					}
					break;
				case 1:
					if (true)
					{
					}
					break;
				case 2:
					try
					{
						bool result;
						for (;;)
						{
							string fileName = global::System.IO.Path.GetFileName(filename);
							num = 2;
							for (;;)
							{
								switch (num)
								{
								case 0:
									goto IL_A7;
								case 1:
									goto IL_B1;
								case 2:
									if (this.FromStream(fileStream, fileName))
									{
										num = 3;
										continue;
									}
									num = 1;
									continue;
								case 3:
									result = true;
									num = 0;
									continue;
								}
								break;
							}
						}
						IL_A7:
						return result;
						IL_B1:
						return false;
					}
					finally
					{
						num = 2;
						for (;;)
						{
							switch (num)
							{
							case 0:
								((global::System.IDisposable)fileStream).Dispose();
								num = 1;
								continue;
							case 1:
								goto IL_EA;
							}
							if (fileStream == null)
							{
								break;
							}
							num = 0;
						}
						IL_EA:;
					}
					goto IL_ED;
				}
				if (!string.IsNullOrEmpty(filename))
				{
					num = 0;
					continue;
				}
				break;
				IL_ED:
				fileStream = new global::System.IO.FileStream(filename, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read);
				num = 2;
			}
			return false;
		}

		// Token: 0x0600036C RID: 876 RVA: 0x0003A280 File Offset: 0x00038480
		public void SaveFile(string filename)
		{
			int num = 2;
			for (;;)
			{
				global::System.IO.MemoryStream memoryStream;
				switch (num)
				{
				case 0:
					goto IL_F5;
				case 1:
					goto IL_43;
					try
					{
						for (;;)
						{
							IL_43:
							memoryStream = new global::System.IO.MemoryStream(this.e);
							global::System.Drawing.Bitmap bitmap = new global::System.Drawing.Bitmap(memoryStream);
							try
							{
								memoryStream = null;
								bitmap.Save(filename);
							}
							finally
							{
								num = 1;
								for (;;)
								{
									switch (num)
									{
									case 0:
										((global::System.IDisposable)bitmap).Dispose();
										num = 2;
										continue;
									case 2:
										goto IL_9A;
									}
									if (bitmap == null)
									{
										break;
									}
									num = 0;
								}
								IL_9A:;
							}
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								goto IL_B3;
							}
						}
						IL_B3:
						if (false)
						{
						}
						return;
					}
					finally
					{
						num = 2;
						for (;;)
						{
							switch (num)
							{
							case 0:
								goto IL_F2;
							case 1:
								memoryStream.Dispose();
								num = 0;
								continue;
							}
							if (memoryStream == null)
							{
								break;
							}
							num = 1;
						}
						IL_F2:;
					}
					goto IL_F5;
				}
				if (this.m.Image != null)
				{
					num = 0;
					continue;
				}
				break;
				IL_F5:
				memoryStream = null;
				if (true)
				{
				}
				num = 1;
			}
		}

		// Token: 0x0600036D RID: 877 RVA: 0x0003A3B8 File Offset: 0x000385B8
		public bool FromStream(global::System.IO.Stream stream, string filename)
		{
			switch (0)
			{
			default:
			{
				int num = 21;
				for (;;)
				{
					global::System.Drawing.Image image;
					int num2;
					switch (num)
					{
					case 0:
						num = 6;
						continue;
					case 1:
						goto IL_290;
					case 2:
						if (this.d != null)
						{
							num = 24;
							continue;
						}
						return false;
					case 3:
					{
						global::custom_controls.CustomBitmap.StructBitmap structBitmap;
						if (structBitmap.Header.BitsPerPixel == 1)
						{
							num = 28;
							continue;
						}
						this.h = global::System.Drawing.Imaging.PixelFormat.Format16bppRgb565;
						this.e = new byte[stream.Length];
						stream.Seek(0L, global::System.IO.SeekOrigin.Begin);
						stream.Read(this.e, 0, (int)stream.Length);
						image = global::custom_controls.CustomImageBox.a(stream);
						this.m.Image = image;
						this.m.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
						num = 23;
						continue;
					}
					case 4:
						goto IL_2B8;
					case 5:
						goto IL_43E;
					case 6:
					{
						global::custom_controls.CustomBitmap.StructBitmap structBitmap;
						if (structBitmap.Palette.Palette[4] != 0)
						{
							num = 12;
							continue;
						}
						goto IL_43E;
					}
					case 7:
						if (this.k != null)
						{
							num = 22;
							continue;
						}
						return true;
					case 8:
						goto IL_2B8;
					case 9:
						goto IL_64B;
					case 10:
						if (!this.g)
						{
							num = 26;
							continue;
						}
						return true;
					case 11:
						this.f = filename;
						num = 14;
						continue;
					case 12:
						num2 = 0;
						num = 25;
						continue;
					case 13:
					{
						if (true)
						{
						}
						global::custom_controls.CustomBitmap.StructBitmap structBitmap;
						if (num2 >= structBitmap.Palette.Palette.Length)
						{
							num = 35;
							continue;
						}
						this.e[54 + num2] = (structBitmap.Palette.Palette[num2] ^ byte.MaxValue);
						num = 27;
						continue;
					}
					case 14:
					{
						global::custom_controls.CustomBitmap.StructBitmap structBitmap;
						if (structBitmap.Header.BitsPerPixel == 8)
						{
							num = 18;
							continue;
						}
						num = 3;
						continue;
					}
					case 15:
						if (this.d != null)
						{
							num = 32;
							continue;
						}
						goto IL_290;
					case 16:
						goto IL_59B;
					case 17:
						goto IL_4C8;
					case 18:
						this.h = global::System.Drawing.Imaging.PixelFormat.Format8bppIndexed;
						this.e = new byte[stream.Length];
						stream.Seek(0L, global::System.IO.SeekOrigin.Begin);
						stream.Read(this.e, 0, (int)stream.Length);
						image = global::System.Drawing.Image.FromStream(stream);
						this.m.Image = image;
						this.m.Width = this.m.Image.Width;
						this.m.Height = this.m.Image.Height;
						num = 8;
						continue;
					case 19:
						goto IL_4C8;
					case 20:
					{
						global::custom_controls.CustomBitmap.StructBitmap structBitmap;
						int num3;
						if (num3 >= structBitmap.Data.BitMapData.Length)
						{
							num = 5;
							continue;
						}
						this.e[structBitmap.Header.BitMapDataOffset + num3] = (structBitmap.Data.BitMapData[num3] ^ byte.MaxValue);
						num3++;
						num = 19;
						continue;
					}
					case 22:
						num = 10;
						continue;
					case 23:
						goto IL_2B8;
					case 24:
						this.d(this, 0, 0, 0, 0);
						num = 31;
						continue;
					case 25:
						goto IL_64B;
					case 26:
						this.k(this, new global::System.EventArgs());
						num = 36;
						continue;
					case 27:
						if (num2 > 2)
						{
							num = 34;
							continue;
						}
						goto IL_59B;
					case 28:
						this.h = global::System.Drawing.Imaging.PixelFormat.Format1bppIndexed;
						this.e = new byte[stream.Length];
						stream.Seek(0L, global::System.IO.SeekOrigin.Begin);
						stream.Read(this.e, 0, (int)stream.Length);
						num = 30;
						continue;
					case 29:
						num = 2;
						continue;
					case 30:
					{
						IL_572:
						global::custom_controls.CustomBitmap.StructBitmap structBitmap;
						if (structBitmap.Palette.Palette[0] != 255)
						{
							num = 0;
							continue;
						}
						goto IL_43E;
					}
					case 31:
						goto IL_20E;
					case 32:
					{
						global::custom_controls.CustomBitmap.StructBitmap structBitmap;
						this.d(this, (int)structBitmap.Header.BitsPerPixel, structBitmap.Palette.Palette.Length, structBitmap.Header.Width, structBitmap.Header.Height);
						num = 1;
						continue;
					}
					case 33:
						if (this.c)
						{
							num = 11;
							continue;
						}
						return false;
					case 34:
						this.e[54 + num2] = 0;
						num = 16;
						continue;
					case 35:
					{
						int num3 = 0;
						num = 17;
						continue;
					}
					case 36:
						return true;
					case 37:
					{
						global::custom_controls.CustomBitmap customBitmap = new global::custom_controls.CustomBitmap();
						global::custom_controls.CustomBitmap.StructBitmap structBitmap = default(global::custom_controls.CustomBitmap.StructBitmap);
						byte[] array = new byte[stream.Length];
						stream.Seek(0L, global::System.IO.SeekOrigin.Begin);
						stream.Read(array, 0, (int)stream.Length);
						num = 38;
						continue;
					}
					case 38:
					{
						global::custom_controls.CustomBitmap.StructBitmap structBitmap;
						global::custom_controls.CustomBitmap customBitmap;
						byte[] array;
						if (!customBitmap.ProcessBMP(ref structBitmap, array))
						{
							num = 29;
							continue;
						}
						num = 15;
						continue;
					}
					}
					if (stream != null)
					{
						num = 37;
						continue;
					}
					return false;
					IL_290:
					num = 33;
					continue;
					IL_2B8:
					this.o.Enabled = true;
					this.j = false;
					num = 7;
					continue;
					IL_43E:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_572;
					}
					if (false)
					{
					}
					image = global::System.Drawing.Image.FromStream(new global::System.IO.MemoryStream(this.e));
					this.m.Image = image;
					this.m.Width = this.m.Image.Width;
					this.m.Height = this.m.Image.Height;
					num = 4;
					continue;
					IL_4C8:
					num = 20;
					continue;
					IL_59B:
					num2++;
					num = 9;
					continue;
					IL_64B:
					num = 13;
				}
				IL_20E:
				return false;
			}
			}
		}

		// Token: 0x0600036E RID: 878 RVA: 0x0003AA4C File Offset: 0x00038C4C
		private static global::System.Drawing.Bitmap a(global::System.IO.Stream A_0)
		{
			for (;;)
			{
				switch (0)
				{
				default:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_24;
					}
					break;
				}
			}
			IL_24:
			if (false)
			{
			}
			global::System.Drawing.Bitmap bitmap = new global::System.Drawing.Bitmap(320, 240, global::System.Drawing.Imaging.PixelFormat.Format16bppRgb565);
			global::System.Drawing.Imaging.BitmapData bitmapData = bitmap.LockBits(new global::System.Drawing.Rectangle(0, 0, 320, 240), global::System.Drawing.Imaging.ImageLockMode.WriteOnly, global::System.Drawing.Imaging.PixelFormat.Format16bppRgb565);
			byte[] array = new byte[bitmapData.Height * bitmapData.Stride + 70];
			global::System.IO.BinaryReader binaryReader = new global::System.IO.BinaryReader(A_0);
			try
			{
				A_0.Seek(0L, global::System.IO.SeekOrigin.Begin);
				binaryReader.Read(array, 0, array.Length - 1);
			}
			finally
			{
				int num = 1;
				for (;;)
				{
					switch (num)
					{
					case 0:
						goto IL_E3;
					case 2:
						((global::System.IDisposable)binaryReader).Dispose();
						num = 0;
						continue;
					}
					if (true)
					{
					}
					if (binaryReader == null)
					{
						break;
					}
					num = 2;
				}
				IL_E3:;
			}
			array[30] = 0;
			global::System.Runtime.InteropServices.Marshal.Copy(array, 70, bitmapData.Scan0, array.Length - 70);
			bitmap.UnlockBits(bitmapData);
			bitmap.RotateFlip(global::System.Drawing.RotateFlipType.Rotate180FlipX);
			return bitmap;
		}

		// Token: 0x0600036F RID: 879 RVA: 0x0003AB78 File Offset: 0x00038D78
		public void SaveStream(ref global::System.IO.MemoryStream ms)
		{
			int num = 2;
			for (;;)
			{
				switch (num)
				{
				case 0:
					num = 1;
					continue;
				case 1:
					if (this.e.Length > 0)
					{
						num = 4;
						continue;
					}
					goto IL_B9;
				case 3:
					if (this.e != null)
					{
						num = 0;
						continue;
					}
					goto IL_B9;
				case 4:
					if (true)
					{
					}
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_08;
					}
					goto Block_2;
				case 5:
					num = 3;
					continue;
				}
				IL_28:
				if (!this.j)
				{
					num = 5;
					continue;
				}
				goto IL_B9;
				IL_08:
				goto IL_28;
			}
			Block_2:
			if (false)
			{
			}
			ms = new global::System.IO.MemoryStream(this.e);
			return;
			IL_B9:
			ms = new global::System.IO.MemoryStream();
		}

		// Token: 0x06000370 RID: 880 RVA: 0x0003AC48 File Offset: 0x00038E48
		public void LoadNosignImage()
		{
			int num = 0;
			for (;;)
			{
				switch (num)
				{
				case 1:
					if (this.i == global::custom_controls.CustomImageBox.ImageModelEnum.MALTA)
					{
						num = 10;
						continue;
					}
					this.m.Image = global::custom_controls.Properties.Resources.radio_splash_132x72_1bit;
					num = 2;
					continue;
				case 2:
					goto IL_61;
				case 3:
					num = 5;
					continue;
				case 4:
					goto IL_61;
				case 5:
					if (!this.g)
					{
						num = 8;
						continue;
					}
					return;
				case 6:
					if (this.i == global::custom_controls.CustomImageBox.ImageModelEnum.BELIZE)
					{
						num = 7;
						continue;
					}
					if (true)
					{
					}
					num = 1;
					continue;
				case 7:
					this.m.Image = global::custom_controls.Properties.Resources.radio_splash_132x90_8bit;
					num = 13;
					continue;
				case 8:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_133;
					default:
						if (false)
						{
						}
						this.k(this, new global::System.EventArgs());
						num = 11;
						continue;
					}
					break;
				case 9:
					this.m.Image = global::custom_controls.Properties.Resources.radio_splash_160x72_8bit;
					goto IL_133;
				case 10:
					this.m.Image = global::custom_controls.Properties.Resources.radio_splash_320x240_16bit;
					this.m.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
					num = 12;
					continue;
				case 11:
					return;
				case 12:
					goto IL_61;
				case 13:
					goto IL_61;
				case 14:
					if (this.k != null)
					{
						num = 3;
						continue;
					}
					return;
				}
				if (this.i == global::custom_controls.CustomImageBox.ImageModelEnum.BALI)
				{
					num = 9;
					continue;
				}
				num = 6;
				continue;
				IL_61:
				this.o.Enabled = false;
				this.j = true;
				num = 14;
				continue;
				IL_133:
				num = 4;
			}
		}

		// Token: 0x06000371 RID: 881 RVA: 0x0003AE2C File Offset: 0x0003902C
		protected override void OnResize(global::System.EventArgs e)
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
			base.OnResize(e);
			this.m.Location = new global::System.Drawing.Point(1, 1);
			this.n.Location = new global::System.Drawing.Point(this.m.Width + 4, 1);
			this.o.Location = new global::System.Drawing.Point(this.m.Width + 4, this.n.Height + 10 + 1);
		}

		// Token: 0x06000372 RID: 882 RVA: 0x0003AECC File Offset: 0x000390CC
		private void b(object A_0, global::System.EventArgs A_1)
		{
			if (true)
			{
			}
			global::System.Windows.Forms.OpenFileDialog openFileDialog = new global::System.Windows.Forms.OpenFileDialog();
			try
			{
				for (;;)
				{
					openFileDialog.InitialDirectory = global::System.Environment.GetFolderPath(global::System.Environment.SpecialFolder.Personal);
					openFileDialog.Filter = this.OpenFileDialogFilter;
					openFileDialog.FilterIndex = 1;
					openFileDialog.Multiselect = false;
					openFileDialog.RestoreDirectory = true;
					int num = 4;
					for (;;)
					{
						switch (num)
						{
						case 0:
							this.FromFile(openFileDialog.FileName);
							num = 3;
							continue;
						case 1:
							num = 2;
							continue;
						case 2:
							if (!string.IsNullOrEmpty(openFileDialog.FileName))
							{
								num = 0;
								continue;
							}
							goto IL_DD;
						case 3:
							goto IL_DD;
						case 4:
							if (global::System.Windows.Forms.DialogResult.OK != openFileDialog.ShowDialog())
							{
								goto IL_DD;
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
								num = 1;
								continue;
							}
							break;
						case 5:
							goto IL_E8;
						}
						break;
						IL_DD:
						num = 5;
					}
				}
				IL_E8:;
			}
			finally
			{
				int num = 2;
				for (;;)
				{
					switch (num)
					{
					case 0:
						goto IL_121;
					case 1:
						((global::System.IDisposable)openFileDialog).Dispose();
						num = 0;
						continue;
					}
					if (openFileDialog == null)
					{
						break;
					}
					num = 1;
				}
				IL_121:;
			}
		}

		// Token: 0x06000373 RID: 883 RVA: 0x0003B010 File Offset: 0x00039210
		private void a(object A_0, global::System.EventArgs A_1)
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
			this.LoadNosignImage();
		}

		// Token: 0x06000374 RID: 884 RVA: 0x0003B054 File Offset: 0x00039254
		public void SaveBinaryFile(string fileName)
		{
			switch (0)
			{
			default:
				for (;;)
				{
					global::System.IO.MemoryStream memoryStream = null;
					this.SaveStream(ref memoryStream);
					int num = 3;
					for (;;)
					{
						uint a_;
						byte[] array;
						switch (num)
						{
						case 0:
							a_ = 16U;
							num = 5;
							continue;
						case 1:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_81;
							default:
								if (false)
								{
								}
								if (this.i == global::custom_controls.CustomImageBox.ImageModelEnum.MALTA)
								{
									num = 0;
									continue;
								}
								a_ = 8U;
								num = 8;
								continue;
							}
							break;
						case 2:
							goto IL_95;
						case 3:
							if (memoryStream.Length == 0L)
							{
								num = 9;
								continue;
							}
							array = new byte[memoryStream.Length];
							memoryStream.Position = 0L;
							memoryStream.Read(array, 0, (int)memoryStream.Length);
							a_ = 8U;
							num = 4;
							continue;
						case 4:
							if (this.i == global::custom_controls.CustomImageBox.ImageModelEnum.BELIZELK)
							{
								num = 6;
								continue;
							}
							num = 1;
							continue;
						case 5:
							goto IL_6A;
						case 6:
							a_ = 1U;
							num = 7;
							continue;
						case 7:
							goto IL_6A;
						case 8:
							goto IL_6A;
						case 9:
							goto IL_65;
						}
						break;
						IL_81:
						if (true)
						{
						}
						num = 2;
						continue;
						IL_6A:
						byte[] array2 = global::custom_controls.j.a(a_).a(array);
						global::System.IO.FileStream fileStream = new global::System.IO.FileStream(fileName, global::System.IO.FileMode.Create, global::System.IO.FileAccess.Write);
						goto IL_81;
					}
				}
				IL_65:
				return;
				IL_95:
				try
				{
					byte[] array2;
					global::System.IO.FileStream fileStream;
					fileStream.Write(array2, 0, array2.Length);
					return;
				}
				finally
				{
					int num = 0;
					for (;;)
					{
						global::System.IO.FileStream fileStream;
						switch (num)
						{
						case 1:
							((global::System.IDisposable)fileStream).Dispose();
							num = 2;
							continue;
						case 2:
							goto IL_146;
						}
						if (fileStream == null)
						{
							break;
						}
						num = 1;
					}
					IL_146:;
				}
				return;
			}
		}

		// Token: 0x06000375 RID: 885 RVA: 0x0003B230 File Offset: 0x00039430
		public void LoadBinaryFile(string fileName)
		{
			switch (0)
			{
			default:
			{
				byte[] array = null;
				string empty = string.Empty;
				global::System.IO.FileStream fileStream = new global::System.IO.FileStream(fileName, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read);
				try
				{
					int num = 12;
					for (;;)
					{
						byte[] array2;
						uint a_;
						switch (num)
						{
						case 0:
							goto IL_25A;
						case 1:
							if (array2.Length > 0)
							{
								num = 15;
								continue;
							}
							goto IL_192;
						case 2:
							goto IL_1D2;
						case 3:
							a_ = 16U;
							num = 2;
							continue;
						case 4:
							goto IL_1D2;
						case 5:
							num = 11;
							continue;
						case 6:
							a_ = 1U;
							num = 4;
							continue;
						case 7:
							try
							{
								global::System.IO.MemoryStream memoryStream;
								this.FromStream(memoryStream, fileName);
								goto IL_192;
							}
							finally
							{
								num = 0;
								for (;;)
								{
									global::System.IO.MemoryStream memoryStream;
									switch (num)
									{
									case 1:
										switch ((1 == 1) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_F5;
										default:
											if (false)
											{
											}
											((global::System.IDisposable)memoryStream).Dispose();
											num = 2;
											continue;
										}
										break;
									case 2:
										goto IL_12C;
									}
									goto IL_F1;
									IL_F5:
									num = 1;
									continue;
									IL_F1:
									if (memoryStream != null)
									{
										goto IL_F5;
									}
									break;
								}
								IL_12C:;
							}
							goto IL_12F;
						case 8:
							if (array != null)
							{
								num = 9;
								continue;
							}
							goto IL_24E;
						case 9:
							a_ = 8U;
							num = 14;
							continue;
						case 10:
							goto IL_24E;
						case 11:
							goto IL_238;
						case 13:
							goto IL_1D2;
						case 14:
							if (this.i == global::custom_controls.CustomImageBox.ImageModelEnum.BELIZELK)
							{
								num = 6;
								continue;
							}
							num = 16;
							continue;
						case 15:
						{
							global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(array2);
							num = 7;
							continue;
						}
						case 16:
							if (this.i == global::custom_controls.CustomImageBox.ImageModelEnum.MALTA)
							{
								num = 3;
								continue;
							}
							a_ = 8U;
							if (true)
							{
							}
							num = 13;
							continue;
						}
						if (fileStream.Length == 0L)
						{
							num = 5;
							continue;
						}
						IL_12F:
						array = new byte[fileStream.Length];
						fileStream.Seek(0L, global::System.IO.SeekOrigin.Begin);
						fileStream.Read(array, 0, (int)fileStream.Length);
						num = 8;
						continue;
						IL_192:
						this.FileLoading = false;
						num = 10;
						continue;
						IL_1D2:
						array2 = global::custom_controls.j.a(a_).b(array);
						this.FileLoading = true;
						num = 1;
						continue;
						IL_24E:
						num = 0;
					}
					IL_238:
					IL_25A:;
				}
				finally
				{
					int num = 1;
					for (;;)
					{
						switch (num)
						{
						case 0:
							((global::System.IDisposable)fileStream).Dispose();
							num = 2;
							continue;
						case 2:
							goto IL_297;
						}
						if (fileStream == null)
						{
							break;
						}
						num = 0;
					}
					IL_297:;
				}
				return;
			}
			}
		}

		// Token: 0x06000376 RID: 886 RVA: 0x0003B50C File Offset: 0x0003970C
		protected override void Dispose(bool disposing)
		{
			int num = 0;
			for (;;)
			{
				switch (num)
				{
				case 1:
					num = 4;
					continue;
				case 2:
					goto IL_4C;
				case 3:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						if (false)
						{
						}
						this.l.Dispose();
						num = 2;
						continue;
					}
					break;
				case 4:
					if (this.l != null)
					{
						num = 3;
						continue;
					}
					goto IL_84;
				}
				if (true)
				{
				}
				if (!disposing)
				{
					break;
				}
				num = 1;
			}
			IL_4C:
			IL_84:
			base.Dispose(disposing);
		}

		// Token: 0x06000377 RID: 887 RVA: 0x0003B5B0 File Offset: 0x000397B0
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
			this.n = new global::System.Windows.Forms.Button();
			this.o = new global::System.Windows.Forms.Button();
			this.m = new global::System.Windows.Forms.PictureBox();
			((global::System.ComponentModel.ISupportInitialize)this.m).BeginInit();
			base.SuspendLayout();
			this.n.Location = new global::System.Drawing.Point(166, 1);
			this.n.Name = "SELECT";
			this.n.Size = new global::System.Drawing.Size(80, 23);
			this.n.AutoSize = true;
			this.n.AutoSizeMode = global::System.Windows.Forms.AutoSizeMode.GrowOnly;
			this.n.TabIndex = 0;
			this.n.Text = "Select...";
			this.n.UseVisualStyleBackColor = true;
			this.n.Click += this.b;
			this.o.Location = new global::System.Drawing.Point(166, 34);
			this.o.Name = "REMOVE";
			this.o.Size = new global::System.Drawing.Size(80, 23);
			this.o.AutoSize = true;
			this.o.AutoSizeMode = global::System.Windows.Forms.AutoSizeMode.GrowOnly;
			this.o.TabIndex = 1;
			this.o.Text = "Remove";
			this.o.UseVisualStyleBackColor = true;
			this.o.Click += this.a;
			this.m.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.m.Image = global::custom_controls.Properties.Resources.radio_splash_160x72_8bit;
			this.m.Location = new global::System.Drawing.Point(1, 1);
			this.m.Name = "IMAGE";
			this.m.Size = new global::System.Drawing.Size(160, 90);
			this.m.TabIndex = 0;
			this.m.TabStop = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add(this.o);
			base.Controls.Add(this.n);
			base.Controls.Add(this.m);
			base.Name = "CustomImageBox";
			base.Size = new global::System.Drawing.Size(300, 92);
			((global::System.ComponentModel.ISupportInitialize)this.m).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000273 RID: 627
		private const int a = 70;

		// Token: 0x04000274 RID: 628
		private string b = "Bitmap File (*.BMP)|*.BMP";

		// Token: 0x04000275 RID: 629
		private bool c;

		// Token: 0x04000276 RID: 630
		private global::custom_controls.CustomImageBox.MatchRadioModel d;

		// Token: 0x04000277 RID: 631
		private byte[] e;

		// Token: 0x04000278 RID: 632
		private string f;

		// Token: 0x04000279 RID: 633
		private bool g;

		// Token: 0x0400027A RID: 634
		private global::System.Drawing.Imaging.PixelFormat h;

		// Token: 0x0400027B RID: 635
		private global::custom_controls.CustomImageBox.ImageModelEnum i;

		// Token: 0x0400027C RID: 636
		private bool j;

		// Token: 0x0400027D RID: 637
		private global::custom_controls.CustomImageBox.ImageDataEvent k;

		// Token: 0x0400027E RID: 638
		private global::System.ComponentModel.IContainer l;

		// Token: 0x0400027F RID: 639
		private global::System.Windows.Forms.PictureBox m;

		// Token: 0x04000280 RID: 640
		private global::System.Windows.Forms.Button n;

		// Token: 0x04000281 RID: 641
		private global::System.Windows.Forms.Button o;

		// Token: 0x0200004C RID: 76
		// (Invoke) Token: 0x06000379 RID: 889
		public delegate void MatchRadioModel(object sender, int bitsPerPixel, int colorLength, int width, int height);

		// Token: 0x0200004D RID: 77
		public enum ImageModelEnum
		{
			// Token: 0x04000283 RID: 643
			BALI,
			// Token: 0x04000284 RID: 644
			BELIZE,
			// Token: 0x04000285 RID: 645
			BELIZELK,
			// Token: 0x04000286 RID: 646
			MALTA
		}

		// Token: 0x0200004E RID: 78
		// (Invoke) Token: 0x0600037D RID: 893
		public delegate void ImageDataEvent(object sender, global::System.EventArgs e);
	}
}
