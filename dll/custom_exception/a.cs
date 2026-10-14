using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Text;

namespace custom_exception
{
	// Token: 0x02000006 RID: 6
	internal class a
	{
		// Token: 0x06000032 RID: 50 RVA: 0x000033AC File Offset: 0x000023AC
		public a()
		{
			this.b();
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000033E0 File Offset: 0x000023E0
		public a(string A_0)
		{
			this.j = A_0;
			this.b();
		}

		// Token: 0x06000034 RID: 52 RVA: 0x0000341C File Offset: 0x0000241C
		protected virtual void c()
		{
			try
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
				this.a();
			}
			finally
			{
				base.Finalize();
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00003478 File Offset: 0x00002478
		public void b(string A_0, global::System.Exception A_1, global::System.Exception A_2)
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
			bool a_ = true;
			this.a(A_0, A_1, A_2, a_);
		}

		// Token: 0x06000036 RID: 54 RVA: 0x000034C0 File Offset: 0x000024C0
		public void b(string A_0, global::System.Exception A_1, global::System.Exception A_2, bool A_3)
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
			this.a(A_0, A_1, A_2, A_3);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00003508 File Offset: 0x00002508
		private void b()
		{
			switch (0)
			{
			default:
			{
				int num = 3;
				for (;;)
				{
					switch (num)
					{
					case 0:
						goto IL_1F5;
					case 1:
						try
						{
							for (;;)
							{
								IL_AC:
								string text = global::System.Diagnostics.Process.GetCurrentProcess().MainModule.ModuleName.Replace(".exe", "");
								string str = string.Empty;
								for (;;)
								{
									IL_D1:
									num = 0;
									for (;;)
									{
										switch (num)
										{
										case 0:
											if (text.Equals("Cruncher.PCRCommandCPS", global::System.StringComparison.OrdinalIgnoreCase))
											{
												if (true)
												{
												}
												num = 4;
												continue;
											}
											str = global::System.Environment.GetFolderPath(global::System.Environment.SpecialFolder.ApplicationData, global::System.Environment.SpecialFolderOption.DoNotVerify);
											this.j = this.a(str + "\\Motorola");
											num = 2;
											continue;
										case 1:
											goto IL_19E;
										case 2:
											goto IL_176;
										case 3:
											switch ((1 == 1) ? 1 : 0)
											{
											case 0:
											case 2:
												goto IL_D1;
											default:
												if (false)
												{
												}
												goto IL_176;
											}
											break;
										case 4:
											str = global::System.Environment.GetFolderPath(global::System.Environment.SpecialFolder.CommonApplicationData);
											this.j = this.a(str + "\\Motorola\\PCRCMDCPS");
											num = 3;
											continue;
										}
										goto IL_AC;
										IL_176:
										this.j = this.j + "\\" + text + ".tbl";
										num = 1;
									}
								}
							}
							IL_19E:
							goto IL_4F;
						}
						catch
						{
							string fileName = global::System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName;
							string str2 = fileName.Substring(0, fileName.LastIndexOf('\\'));
							this.j = str2 + "\\cps.tbl";
							this.j = this.j.Replace("\\\\", "\\");
							goto IL_4F;
						}
						goto IL_1F5;
					case 2:
						return;
					case 4:
						if (!global::custom_exception.a.i.Exists)
						{
							num = 0;
							continue;
						}
						return;
					}
					if (string.IsNullOrEmpty(this.j))
					{
						num = 1;
						continue;
					}
					IL_4F:
					global::custom_exception.a.i = new global::System.IO.FileInfo(this.j);
					num = 4;
					continue;
					IL_1F5:
					global::custom_exception.a.i.Create().Close();
					num = 2;
				}
				return;
			}
			}
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00003744 File Offset: 0x00002744
		private string a(string A_0)
		{
			int num = 2;
			for (;;)
			{
				switch (num)
				{
				case 0:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						return A_0;
					default:
						if (false)
						{
						}
						global::System.IO.Directory.CreateDirectory(A_0);
						num = 1;
						continue;
					}
					break;
				case 1:
					return A_0;
				}
				if (true)
				{
				}
				if (global::System.IO.Directory.Exists(A_0))
				{
					break;
				}
				num = 0;
			}
			return A_0;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x000037C0 File Offset: 0x000027C0
		private void a(string A_0, global::System.Exception A_1, global::System.Exception A_2)
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
			bool a_ = true;
			this.a(A_0, A_1, A_2, a_);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00003808 File Offset: 0x00002808
		private void a(string A_0, global::System.Exception A_1, global::System.Exception A_2, bool A_3)
		{
			try
			{
				switch (0)
				{
				default:
				{
					int num = 0;
					for (;;)
					{
						global::System.Exception ex;
						string text;
						global::System.Exception ex2;
						switch (num)
						{
						case 1:
							if (ex != null)
							{
								num = 27;
								continue;
							}
							goto IL_33F;
						case 2:
							goto IL_33F;
						case 3:
							goto IL_373;
						case 4:
							text += this.a(A_1);
							ex2 = A_1;
							ex = A_1.GetBaseException();
							num = 16;
							continue;
						case 5:
							goto IL_FC;
						case 6:
							goto IL_359;
						case 7:
							goto IL_31F;
						case 8:
							if (this.f.Count > 0)
							{
								num = 22;
								continue;
							}
							goto IL_FC;
						case 9:
							num = 19;
							continue;
						case 10:
							if (A_3)
							{
								num = 21;
								continue;
							}
							goto IL_359;
						case 11:
							goto IL_18C;
						case 12:
							num = 18;
							continue;
						case 13:
							if (A_1 != null)
							{
								num = 4;
								continue;
							}
							goto IL_1A9;
						case 14:
							goto IL_25A;
						case 15:
							if (ex2 == ex)
							{
								num = 2;
								continue;
							}
							text += this.a(ex);
							ex2 = ex;
							ex = ex.GetBaseException();
							num = 7;
							continue;
						case 16:
							goto IL_31F;
						case 17:
							A_0 = this.g + "\r\n" + A_0;
							num = 14;
							continue;
						case 18:
							if (ex2 == ex)
							{
								num = 26;
								continue;
							}
							text += this.a(ex);
							ex2 = ex;
							ex = ex.InnerException;
							num = 11;
							continue;
						case 19:
							if (this.h == A_1)
							{
								num = 20;
								continue;
							}
							goto IL_25A;
						case 20:
							goto IL_161;
						case 21:
							this.a();
							num = 6;
							continue;
						case 22:
							this.f.RemoveAt(this.f.Count - 1);
							if (true)
							{
							}
							num = 5;
							continue;
						case 23:
							if (!string.IsNullOrEmpty(this.g))
							{
								num = 17;
								continue;
							}
							goto IL_25A;
						case 24:
							goto IL_18C;
						case 25:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_161;
							default:
								if (false)
								{
								}
								goto IL_1A9;
							}
							break;
						case 26:
							goto IL_129;
						case 27:
							num = 15;
							continue;
						case 28:
							if (ex != null)
							{
								num = 12;
								continue;
							}
							goto IL_129;
						}
						if (this.h != null)
						{
							num = 9;
							continue;
						}
						goto IL_25A;
						IL_FC:
						num = 23;
						continue;
						IL_129:
						text += this.a(A_2);
						num = 25;
						continue;
						IL_161:
						num = 8;
						continue;
						IL_18C:
						num = 28;
						continue;
						IL_1A9:
						this.f.Add(text);
						num = 10;
						continue;
						IL_25A:
						text = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "\r\n*****[{0}]******\r\n{1}\r\n", new object[]
						{
							global::System.DateTime.Now,
							A_0
						});
						num = 13;
						continue;
						IL_31F:
						num = 1;
						continue;
						IL_33F:
						ex2 = A_1;
						ex = A_1.InnerException;
						num = 24;
						continue;
						IL_359:
						this.g = A_0;
						this.h = A_1;
						num = 3;
					}
					IL_373:
					break;
				}
				}
			}
			catch (global::System.Exception)
			{
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00003BB4 File Offset: 0x00002BB4
		private string a(global::System.Exception A_0)
		{
			string result;
			for (;;)
			{
				IL_00:
				switch (0)
				{
				default:
					if (true)
					{
					}
					for (;;)
					{
						result = string.Empty;
						int num = 1;
						for (;;)
						{
							switch (num)
							{
							case 0:
								return result;
							case 1:
								if (A_0 == null)
								{
									num = 0;
									continue;
								}
								num = 3;
								continue;
							case 2:
							{
								global::custom_exception.CCustomException ex = A_0 as global::custom_exception.CCustomException;
								result = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "----{0} {1}\t{2}------\r\nSource: {3}\r\n{4}\r\n", new object[]
								{
									ex.ErrorID,
									global::custom_exception.CCustomException.MapErrorIdToString((int)ex.ErrorID),
									ex.exMessage,
									ex.exSource,
									this.a(ex.exStackTrace, 10)
								});
								num = 5;
								continue;
							}
							case 3:
								if (A_0.GetType().ToString() == global::custom_exception.CCustomException.CLASS_NAME)
								{
									num = 2;
									continue;
								}
								result = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "----{0}-----\r\nSource: {1}\r\n{2}\r\n", new object[]
								{
									A_0.Message,
									A_0.Source,
									this.a(A_0.StackTrace, 10)
								});
								switch ((1 == 1) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_00;
								default:
									if (false)
									{
									}
									num = 4;
									continue;
								}
								break;
							case 4:
								return result;
							case 5:
								return result;
							}
							break;
						}
					}
					break;
				}
			}
			return result;
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00003D30 File Offset: 0x00002D30
		private string a(string A_0, int A_1)
		{
			int num = 10;
			for (;;)
			{
				string result;
				switch (num)
				{
				case 0:
				{
					int num2;
					if (num2 < A_1)
					{
						if (true)
						{
						}
						num = 1;
						continue;
					}
					goto IL_5D;
				}
				case 1:
					num = 5;
					continue;
				case 2:
					goto IL_7C;
				case 3:
				{
					int num2;
					num2++;
					num = 2;
					continue;
				}
				case 4:
					goto IL_5D;
				case 5:
				{
					int num3;
					if (num3 + 1 >= A_0.Length)
					{
						num = 4;
						continue;
					}
					num3 = A_0.IndexOf("\r\n", num3 + 1, global::System.StringComparison.Ordinal);
					num = 9;
					continue;
				}
				case 6:
					return result;
				case 7:
					result = A_0;
					num = 12;
					continue;
				case 8:
					goto IL_7C;
				case 9:
				{
					int num3;
					if (num3 >= 0)
					{
						num = 3;
						continue;
					}
					goto IL_5D;
				}
				case 11:
					goto IL_58;
				case 12:
					return result;
				case 13:
				{
					int num2;
					if (num2 < A_1)
					{
						num = 7;
						continue;
					}
					int num3;
					result = A_0.Substring(0, num3);
					num = 6;
					continue;
				}
				}
				if (string.IsNullOrEmpty(A_0))
				{
					num = 11;
					continue;
				}
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
					int num2 = 0;
					int num3 = 0;
					num = 8;
					continue;
				}
				}
				IL_63:
				num = 13;
				continue;
				IL_5D:
				result = string.Empty;
				goto IL_63;
				IL_7C:
				num = 0;
			}
			IL_58:
			return string.Empty;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00003EAC File Offset: 0x00002EAC
		private void a()
		{
			switch (0)
			{
			default:
			{
				int num = 2;
				for (;;)
				{
					if (true)
					{
					}
					global::System.IO.MemoryStream memoryStream;
					switch (num)
					{
					case 0:
						goto IL_16B;
					case 1:
						try
						{
							try
							{
								using (global::System.Collections.Generic.List<string>.Enumerator enumerator = this.f.GetEnumerator())
								{
									num = 4;
									for (;;)
									{
										switch (num)
										{
										case 0:
										{
											if (!enumerator.MoveNext())
											{
												num = 2;
												continue;
											}
											string s = enumerator.Current;
											byte[] bytes = global::System.Text.Encoding.Unicode.GetBytes(s);
											memoryStream.Write(bytes, 0, bytes.Length);
											num = 3;
											continue;
										}
										case 1:
											goto IL_E3;
										case 2:
											num = 1;
											continue;
										}
										IL_93:
										num = 0;
										continue;
										goto IL_93;
									}
									IL_E3:;
								}
								this.a(global::custom_exception.a.i, memoryStream);
								this.f.Clear();
							}
							catch (global::System.Exception)
							{
							}
							return;
						}
						finally
						{
							num = 1;
							for (;;)
							{
								switch (num)
								{
								case 0:
									for (;;)
									{
										((global::System.IDisposable)memoryStream).Dispose();
										switch ((1 == 1) ? 1 : 0)
										{
										case 0:
										case 2:
											break;
										default:
											goto IL_159;
										}
									}
									IL_159:
									if (false)
									{
									}
									num = 2;
									continue;
								case 2:
									goto IL_168;
								}
								if (memoryStream == null)
								{
									break;
								}
								num = 0;
							}
							IL_168:;
						}
						goto IL_16B;
					}
					if (this.f.Count > 0)
					{
						num = 0;
						continue;
					}
					break;
					IL_16B:
					memoryStream = new global::System.IO.MemoryStream();
					num = 1;
				}
				return;
			}
			}
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00004064 File Offset: 0x00003064
		private byte[] a(global::System.IO.FileInfo A_0)
		{
			switch (0)
			{
			default:
			{
				byte[] result;
				for (;;)
				{
					result = new byte[0];
					if (true)
					{
					}
					int num = 2;
					for (;;)
					{
						global::System.IO.MemoryStream memoryStream;
						switch (num)
						{
						case 0:
							try
							{
								global::System.IO.FileStream fileStream = null;
								try
								{
									fileStream = A_0.OpenRead();
									global::System.IO.Compression.GZipStream gzipStream = new global::System.IO.Compression.GZipStream(fileStream, global::System.IO.Compression.CompressionMode.Decompress);
									try
									{
										fileStream = null;
										try
										{
											switch ((1 == 1) ? 1 : 0)
											{
											case 0:
											case 2:
												IL_EA:
												memoryStream.Write(this.k, 0, this.l);
												num = 0;
												break;
											default:
												if (false)
												{
												}
												num = 2;
												break;
											}
											for (;;)
											{
												int num2;
												switch (num)
												{
												case 1:
													num = 3;
													continue;
												case 3:
													goto IL_111;
												case 4:
													if (num2 <= 0)
													{
														num = 1;
														continue;
													}
													goto IL_EA;
												}
												IL_B6:
												num2 = (this.l = gzipStream.Read(this.k, 0, 2048));
												num = 4;
												continue;
												goto IL_B6;
											}
											IL_111:;
										}
										catch (global::System.Exception)
										{
										}
									}
									finally
									{
										num = 2;
										for (;;)
										{
											switch (num)
											{
											case 0:
												((global::System.IDisposable)gzipStream).Dispose();
												num = 1;
												continue;
											case 1:
												goto IL_153;
											}
											if (gzipStream == null)
											{
												break;
											}
											num = 0;
										}
										IL_153:;
									}
								}
								finally
								{
									num = 2;
									for (;;)
									{
										switch (num)
										{
										case 0:
											goto IL_193;
										case 1:
											fileStream.Dispose();
											num = 0;
											continue;
										}
										if (fileStream == null)
										{
											break;
										}
										num = 1;
									}
									IL_193:;
								}
								return memoryStream.ToArray();
							}
							finally
							{
								num = 0;
								for (;;)
								{
									switch (num)
									{
									case 1:
										((global::System.IDisposable)memoryStream).Dispose();
										num = 2;
										continue;
									case 2:
										goto IL_1DA;
									}
									if (memoryStream == null)
									{
										break;
									}
									num = 1;
								}
								IL_1DA:;
							}
							goto IL_1DD;
						case 1:
							return result;
						case 2:
							if (A_0 == null)
							{
								num = 1;
								continue;
							}
							goto IL_1DD;
						}
						break;
						IL_1DD:
						memoryStream = new global::System.IO.MemoryStream();
						num = 0;
					}
				}
				return result;
			}
			}
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000042CC File Offset: 0x000032CC
		private void a(global::System.IO.FileInfo A_0, global::System.IO.MemoryStream A_1)
		{
			switch (0)
			{
			default:
			{
				int num = 5;
				for (;;)
				{
					global::System.IO.FileStream fileStream;
					switch (num)
					{
					case 0:
						if (!A_0.Exists)
						{
							num = 1;
							continue;
						}
						goto IL_221;
					case 1:
						goto IL_1E2;
					case 2:
						return;
					case 3:
						goto IL_221;
					case 4:
						try
						{
							fileStream = A_0.Create();
							global::System.IO.Compression.GZipStream gzipStream = new global::System.IO.Compression.GZipStream(fileStream, global::System.IO.Compression.CompressionMode.Compress);
							try
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
									fileStream = null;
									try
									{
										for (;;)
										{
											this.m = 2;
											num = 1;
											for (;;)
											{
												switch (num)
												{
												case 0:
													goto IL_15A;
												case 1:
													goto IL_124;
												case 2:
												{
													int num2 = this.l = A_1.Read(this.k, 0, 2048);
													num = 5;
													continue;
												}
												case 3:
													goto IL_14E;
												case 4:
													if (this.m < 1048576)
													{
														num = 2;
														continue;
													}
													goto IL_14E;
												case 5:
												{
													int num2;
													if (num2 <= 0)
													{
														num = 3;
														continue;
													}
													gzipStream.Write(this.k, 0, this.l);
													this.m += this.l;
													num = 6;
													continue;
												}
												case 6:
													goto IL_124;
												}
												break;
												IL_124:
												num = 4;
												continue;
												IL_14E:
												num = 0;
											}
										}
										IL_15A:;
									}
									catch (global::System.Exception)
									{
									}
									break;
								}
							}
							finally
							{
								num = 1;
								for (;;)
								{
									switch (num)
									{
									case 0:
										((global::System.IDisposable)gzipStream).Dispose();
										num = 2;
										continue;
									case 2:
										goto IL_19C;
									}
									if (gzipStream == null)
									{
										break;
									}
									num = 0;
								}
								IL_19C:;
							}
							goto IL_25B;
						}
						finally
						{
							num = 2;
							for (;;)
							{
								switch (num)
								{
								case 0:
									fileStream.Dispose();
									num = 1;
									continue;
								case 1:
									goto IL_1DF;
								}
								if (fileStream == null)
								{
									break;
								}
								num = 0;
							}
							IL_1DF:;
						}
						goto IL_1E2;
					}
					if (A_0 == null)
					{
						num = 2;
						continue;
					}
					num = 0;
					continue;
					IL_1E2:
					if (true)
					{
					}
					this.b();
					num = 3;
					continue;
					IL_221:
					byte[] array = this.a(A_0);
					A_1.Seek(0L, global::System.IO.SeekOrigin.End);
					A_1.Write(array, 0, array.Length);
					A_1.Seek(0L, global::System.IO.SeekOrigin.Begin);
					fileStream = null;
					num = 4;
				}
				return;
				IL_25B:
				A_1.Close();
				return;
			}
			}
		}

		// Token: 0x040006EE RID: 1774
		private const int a = 10;

		// Token: 0x040006EF RID: 1775
		private const string b = "Cruncher.PCRCommandCPS";

		// Token: 0x040006F0 RID: 1776
		private const int c = 1048576;

		// Token: 0x040006F1 RID: 1777
		private const int d = 2048;

		// Token: 0x040006F2 RID: 1778
		private const int e = 2047;

		// Token: 0x040006F3 RID: 1779
		private global::System.Collections.Generic.List<string> f = new global::System.Collections.Generic.List<string>();

		// Token: 0x040006F4 RID: 1780
		private string g;

		// Token: 0x040006F5 RID: 1781
		private global::System.Exception h;

		// Token: 0x040006F6 RID: 1782
		private static global::System.IO.FileInfo i;

		// Token: 0x040006F7 RID: 1783
		private string j;

		// Token: 0x040006F8 RID: 1784
		private byte[] k = new byte[2048];

		// Token: 0x040006F9 RID: 1785
		private int l;

		// Token: 0x040006FA RID: 1786
		private int m;
	}
}
