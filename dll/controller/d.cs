using System;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using custom_exception;

// Token: 0x02000003 RID: 3
internal class d
{
	// Token: 0x06000004 RID: 4 RVA: 0x0000211C File Offset: 0x0000111C
	public static void a(string A_0, global::d.a A_1, ref string A_2)
	{
		try
		{
			switch (0)
			{
			default:
			{
				for (;;)
				{
					int num = A_2.IndexOf("<SIGNATURE>", global::System.StringComparison.Ordinal);
					int num2 = A_2.IndexOf("</SIGNATURE>", global::System.StringComparison.Ordinal);
					int num3 = 0;
					for (;;)
					{
						global::System.Security.Cryptography.SHA1Managed sha1Managed;
						byte[] rgbHash;
						string str;
						global::System.Security.Cryptography.RSACryptoServiceProvider rsacryptoServiceProvider;
						byte[] array;
						switch (num3)
						{
						case 0:
							if (num != -1)
							{
								num3 = 7;
								continue;
							}
							goto IL_6E;
						case 1:
							goto IL_2EB;
						case 2:
						{
							try
							{
								global::System.Text.UnicodeEncoding unicodeEncoding = new global::System.Text.UnicodeEncoding();
								byte[] bytes = unicodeEncoding.GetBytes(A_2);
								rgbHash = sha1Managed.ComputeHash(bytes);
								goto IL_155;
							}
							finally
							{
								num3 = 2;
								for (;;)
								{
									switch (num3)
									{
									case 0:
										goto IL_1D3;
									case 1:
										((global::System.IDisposable)sha1Managed).Dispose();
										num3 = 0;
										continue;
									}
									if (sha1Managed == null)
									{
										break;
									}
									num3 = 1;
								}
								IL_1D3:;
							}
							goto IL_1D6;
							IL_155:
							global::System.IO.FileStream fileStream = new global::System.IO.FileStream(A_0 + str, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read, global::System.IO.FileShare.Read);
							num3 = 6;
							continue;
						}
						case 3:
							goto IL_36D;
						case 4:
						{
							byte[] value;
							string text;
							try
							{
								value = rsacryptoServiceProvider.SignHash(rgbHash, null);
								text = rsacryptoServiceProvider.ToXmlString(false);
								goto IL_2F0;
							}
							finally
							{
								num3 = 0;
								for (;;)
								{
									switch (num3)
									{
									case 1:
										goto IL_131;
									case 2:
										((global::System.IDisposable)rsacryptoServiceProvider).Dispose();
										num3 = 1;
										continue;
									}
									if (rsacryptoServiceProvider == null)
									{
										break;
									}
									num3 = 2;
								}
								IL_131:;
							}
							goto IL_134;
							IL_2F0:
							string text2 = global::System.BitConverter.ToString(value);
							string text3 = "<VERSION>1.0</VERSION>";
							string text4 = "<DIGEST>" + text2.Replace("-", "") + "</DIGEST>";
							string text5 = A_2;
							A_2 = string.Concat(new string[]
							{
								text5,
								"<SIGNATURE>",
								text3,
								text4,
								text,
								"</SIGNATURE>"
							});
							num3 = 3;
							continue;
						}
						case 5:
							if (num2 != -1)
							{
								num3 = 1;
								continue;
							}
							goto IL_6E;
						case 6:
							try
							{
								for (;;)
								{
									global::System.IO.FileStream fileStream;
									int num4 = (int)fileStream.Length;
									array = new byte[num4];
									int num5 = 0;
									num3 = 2;
									for (;;)
									{
										switch (num3)
										{
										case 0:
											goto IL_287;
										case 1:
											goto IL_251;
										case 2:
											goto IL_251;
										case 3:
											num3 = 0;
											continue;
										case 4:
										{
											int num6;
											if ((num6 = fileStream.Read(array, num5, num4 - num5)) <= 0)
											{
												num3 = 3;
												continue;
											}
											num5 += num6;
											num3 = 1;
											continue;
										}
										}
										break;
										IL_251:
										num3 = 4;
									}
								}
								IL_287:
								goto IL_1D6;
							}
							finally
							{
								num3 = 0;
								for (;;)
								{
									global::System.IO.FileStream fileStream;
									switch (num3)
									{
									case 1:
										goto IL_2C9;
									case 2:
										((global::System.IDisposable)fileStream).Dispose();
										num3 = 1;
										continue;
									}
									if (fileStream == null)
									{
										break;
									}
									num3 = 2;
								}
								IL_2C9:;
							}
							goto IL_2CC;
						case 7:
							goto IL_2CC;
						}
						break;
						IL_6E:
						str = global::d.ab[(int)((global::System.UIntPtr)A_1)];
						string text6 = global::d.ac[(int)((global::System.UIntPtr)A_1)];
						byte[] bytes2 = global::System.Convert.FromBase64String(text6 + "==");
						text6 = global::System.Text.Encoding.ASCII.GetString(bytes2);
						rgbHash = null;
						sha1Managed = new global::System.Security.Cryptography.SHA1Managed();
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							if (false)
							{
							}
							num3 = 2;
							continue;
						}
						IL_1D6:
						global::System.Security.Cryptography.X509Certificates.X509Certificate2 x509Certificate = new global::System.Security.Cryptography.X509Certificates.X509Certificate2(array, text6, global::System.Security.Cryptography.X509Certificates.X509KeyStorageFlags.MachineKeySet);
						rsacryptoServiceProvider = (global::System.Security.Cryptography.RSACryptoServiceProvider)x509Certificate.PrivateKey;
						num3 = 4;
						continue;
						IL_2CC:
						num3 = 5;
					}
				}
				IL_134:
				global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(1838U, "Secure", "ApplySignature", global::System.Environment.StackTrace.ToString());
				throw ex;
				IL_2EB:
				goto IL_134;
				IL_36D:
				break;
			}
			}
		}
		catch (global::custom_exception.CCustomException)
		{
			throw;
		}
		catch (global::System.Exception ex2)
		{
			if (!global::custom_exception.CCustomException.CheckErrorIDExsists(ex2))
			{
				ex2.Source = 1837U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex2.Source;
			}
			if (true)
			{
			}
			global::custom_exception.CCustomException.Rethrow(ex2);
		}
	}

	// Token: 0x06000005 RID: 5 RVA: 0x0000256C File Offset: 0x0000156C
	public static global::d.b a(global::d.a A_0, ref string A_1)
	{
		switch (0)
		{
		default:
		{
			global::d.b result = global::d.b.b;
			try
			{
				for (;;)
				{
					int num = A_1.IndexOf("<SIGNATURE>", global::System.StringComparison.Ordinal);
					int num2 = A_1.IndexOf("</SIGNATURE>", global::System.StringComparison.Ordinal);
					int num3 = 12;
					for (;;)
					{
						switch (num3)
						{
						case 0:
							goto IL_23C;
						case 1:
						{
							try
							{
								global::System.Text.UnicodeEncoding unicodeEncoding = new global::System.Text.UnicodeEncoding();
								byte[] bytes = unicodeEncoding.GetBytes(A_1);
								global::System.Security.Cryptography.SHA1Managed sha1Managed;
								byte[] rgbHash = sha1Managed.ComputeHash(bytes);
							}
							finally
							{
								num3 = 2;
								for (;;)
								{
									global::System.Security.Cryptography.SHA1Managed sha1Managed;
									switch (num3)
									{
									case 0:
										((global::System.IDisposable)sha1Managed).Dispose();
										num3 = 1;
										continue;
									case 1:
										goto IL_322;
									}
									if (sha1Managed == null)
									{
										break;
									}
									num3 = 0;
								}
								IL_322:;
							}
							string text;
							byte[] array = new byte[text.Length / 2];
							int num4 = 0;
							num3 = 6;
							continue;
						}
						case 2:
							try
							{
								for (;;)
								{
									global::System.Security.Cryptography.RSACryptoServiceProvider rsacryptoServiceProvider;
									string xmlString;
									rsacryptoServiceProvider.FromXmlString(xmlString);
									num3 = 2;
									for (;;)
									{
										switch (num3)
										{
										case 0:
											result = global::d.b.c;
											num3 = 4;
											continue;
										case 1:
											goto IL_1F7;
										case 2:
										{
											byte[] rgbHash;
											byte[] array;
											if (rsacryptoServiceProvider.VerifyHash(rgbHash, null, array))
											{
												num3 = 0;
												continue;
											}
											result = global::d.b.a;
											num3 = 3;
											continue;
										}
										case 3:
											goto IL_1EE;
										case 4:
											goto IL_1EE;
										}
										break;
										IL_1EE:
										num3 = 1;
									}
								}
								IL_1F7:
								goto IL_349;
							}
							finally
							{
								num3 = 1;
								for (;;)
								{
									global::System.Security.Cryptography.RSACryptoServiceProvider rsacryptoServiceProvider;
									switch (num3)
									{
									case 0:
										goto IL_239;
									case 2:
										((global::System.IDisposable)rsacryptoServiceProvider).Dispose();
										num3 = 0;
										continue;
									}
									if (rsacryptoServiceProvider == null)
									{
										break;
									}
									num3 = 2;
								}
								IL_239:;
							}
							goto IL_23C;
						case 3:
							num3 = 4;
							continue;
						case 4:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_10C;
							default:
								if (false)
								{
								}
								if (num2 != -1)
								{
									num3 = 7;
									continue;
								}
								goto IL_349;
							}
							break;
						case 5:
							goto IL_355;
						case 6:
							goto IL_23C;
						case 7:
						{
							int num5 = A_1.IndexOf("<DIGEST>", global::System.StringComparison.Ordinal);
							int num6 = A_1.IndexOf("</DIGEST>", global::System.StringComparison.Ordinal);
							int num7 = num5 + "<DIGEST>".Length;
							int length = num6 - num7;
							string text = A_1.Substring(num7, length);
							num7 = num6 + "</DIGEST>".Length;
							length = num2 - num7;
							string xmlString = A_1.Substring(num7, length);
							goto IL_10C;
						}
						case 8:
						{
							byte[] array;
							int num4;
							if (num4 >= array.Length)
							{
								num3 = 10;
								continue;
							}
							string text;
							array[num4] = global::System.Convert.ToByte(text.Substring(num4 * 2, 2), 16);
							num4++;
							num3 = 0;
							continue;
						}
						case 9:
							goto IL_138;
						case 10:
						{
							global::System.Security.Cryptography.RSACryptoServiceProvider rsacryptoServiceProvider = new global::System.Security.Cryptography.RSACryptoServiceProvider();
							num3 = 2;
							continue;
						}
						case 11:
						{
							string xmlString;
							if (xmlString != global::d.ad[(int)((global::System.UIntPtr)A_0)])
							{
								num3 = 9;
								continue;
							}
							A_1 = A_1.Remove(num);
							byte[] rgbHash = null;
							global::System.Security.Cryptography.SHA1Managed sha1Managed = new global::System.Security.Cryptography.SHA1Managed();
							num3 = 1;
							continue;
						}
						case 12:
							if (num != -1)
							{
								num3 = 3;
								continue;
							}
							goto IL_349;
						}
						break;
						IL_10C:
						num3 = 11;
						continue;
						IL_23C:
						num3 = 8;
						continue;
						IL_349:
						num3 = 5;
					}
				}
				IL_138:
				global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(1836U, "Secure", "VerifySignature", global::System.Environment.StackTrace.ToString());
				throw ex;
				IL_355:;
			}
			catch (global::custom_exception.CCustomException)
			{
				throw;
			}
			catch (global::System.Exception ex2)
			{
				if (!global::custom_exception.CCustomException.CheckErrorIDExsists(ex2))
				{
					ex2.Source = 1837U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex2.Source;
				}
				global::custom_exception.CCustomException.Rethrow(ex2);
			}
			if (true)
			{
			}
			return result;
		}
		}
	}

	// Token: 0x06000006 RID: 6 RVA: 0x00002984 File Offset: 0x00001984
	public static void b(string A_0, string A_1, bool A_2, global::d.c A_3)
	{
		try
		{
			switch (0)
			{
			default:
			{
				int num = 2;
				for (;;)
				{
					switch (num)
					{
					case 0:
						if (string.IsNullOrEmpty(A_1))
						{
							num = 6;
							continue;
						}
						num = 5;
						continue;
					case 1:
						goto IL_2BC;
					case 3:
						goto IL_2AE;
					case 4:
						try
						{
							for (;;)
							{
								IL_A8:
								global::System.Security.Cryptography.RijndaelManaged rijndaelManaged;
								string str;
								rijndaelManaged.Key = global::System.Convert.FromBase64String(str + "=");
								string str2;
								rijndaelManaged.IV = global::System.Convert.FromBase64String(str2 + "==");
								byte[] array = null;
								byte[] array2 = null;
								global::System.IO.FileStream fileStream = new global::System.IO.FileStream(A_0, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read);
								for (;;)
								{
									IL_E6:
									num = 1;
									for (;;)
									{
										switch ((1 == 1) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_E6;
										default:
										{
											if (false)
											{
											}
											global::System.IO.FileStream fileStream2;
											switch (num)
											{
											case 0:
												goto IL_1DC;
											case 1:
												goto IL_144;
											case 2:
												try
												{
													fileStream2.Write(array2, 0, array2.Length);
													goto IL_1D0;
												}
												finally
												{
													num = 2;
													for (;;)
													{
														switch (num)
														{
														case 0:
															((global::System.IDisposable)fileStream2).Dispose();
															num = 1;
															continue;
														case 1:
															goto IL_141;
														}
														if (fileStream2 == null)
														{
															break;
														}
														num = 0;
													}
													IL_141:;
												}
												goto Block_7;
												IL_1D0:
												num = 0;
												continue;
											}
											goto IL_A8;
											Block_7:
											try
											{
												IL_144:
												array = new byte[fileStream.Length];
												fileStream.Read(array, 0, array.Length);
											}
											finally
											{
												num = 2;
												for (;;)
												{
													switch (num)
													{
													case 0:
														goto IL_1A1;
													case 1:
														((global::System.IDisposable)fileStream).Dispose();
														num = 0;
														continue;
													}
													if (fileStream == null)
													{
														break;
													}
													num = 1;
												}
												IL_1A1:;
											}
											global::d.a(array, ref array2, A_2, rijndaelManaged.CreateEncryptor());
											fileStream2 = new global::System.IO.FileStream(A_1, global::System.IO.FileMode.Create, global::System.IO.FileAccess.Write);
											num = 2;
											break;
										}
										}
									}
								}
							}
							IL_1DC:
							goto IL_2B0;
						}
						finally
						{
							num = 2;
							for (;;)
							{
								global::System.Security.Cryptography.RijndaelManaged rijndaelManaged;
								switch (num)
								{
								case 0:
									goto IL_21E;
								case 1:
									((global::System.IDisposable)rijndaelManaged).Dispose();
									num = 0;
									continue;
								}
								if (rijndaelManaged == null)
								{
									break;
								}
								num = 1;
							}
							IL_21E:;
						}
						goto IL_221;
						IL_2B0:
						num = 1;
						continue;
					case 5:
					{
						if (!global::System.IO.File.Exists(global::System.IO.Path.GetFullPath(A_0)))
						{
							num = 3;
							continue;
						}
						string str;
						string str2;
						global::d.a(A_3, out str, out str2);
						global::System.Security.Cryptography.RijndaelManaged rijndaelManaged = new global::System.Security.Cryptography.RijndaelManaged();
						num = 4;
						continue;
					}
					case 6:
						goto IL_241;
					case 7:
						goto IL_221;
					}
					if (!string.IsNullOrEmpty(A_0))
					{
						num = 7;
						continue;
					}
					break;
					IL_221:
					num = 0;
				}
				IL_56:
				global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(2388U, "Secure", "EncryptFile", global::System.Environment.StackTrace.ToString());
				throw ex;
				IL_241:
				goto IL_56;
				IL_2AE:
				global::custom_exception.CCustomException ex2 = new global::custom_exception.CCustomException(2392U, "Secure", "EncryptFile", global::System.Environment.StackTrace.ToString());
				throw ex2;
				IL_2BC:
				break;
			}
			}
		}
		catch (global::custom_exception.CCustomException)
		{
			throw;
		}
		catch (global::System.Exception ex3)
		{
			if (!global::custom_exception.CCustomException.CheckErrorIDExsists(ex3))
			{
				if (true)
				{
				}
				ex3.Source = 2393U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex3.Source;
			}
			global::custom_exception.CCustomException.Rethrow(ex3);
		}
	}

	// Token: 0x06000007 RID: 7 RVA: 0x00002D24 File Offset: 0x00001D24
	public static void b(byte[] A_0, ref byte[] A_1, bool A_2, global::d.c A_3)
	{
		try
		{
			switch (0)
			{
			default:
			{
				string str;
				string str2;
				global::d.a(A_3, out str, out str2);
				global::System.Security.Cryptography.RijndaelManaged rijndaelManaged = new global::System.Security.Cryptography.RijndaelManaged();
				try
				{
					rijndaelManaged.Key = global::System.Convert.FromBase64String(str + "=");
					rijndaelManaged.IV = global::System.Convert.FromBase64String(str2 + "==");
					byte[] array = new byte[A_0.Length + 3];
					array[0] = 239;
					array[1] = 187;
					array[2] = 191;
					global::System.Array.Copy(A_0, 0, array, 3, A_0.Length);
					global::d.a(array, ref A_1, A_2, rijndaelManaged.CreateEncryptor());
				}
				finally
				{
					int num = 2;
					for (;;)
					{
						switch (num)
						{
						case 0:
							((global::System.IDisposable)rijndaelManaged).Dispose();
							num = 1;
							continue;
						case 1:
							goto IL_C6;
						}
						if (rijndaelManaged == null)
						{
							break;
						}
						num = 0;
					}
					IL_C6:;
				}
				break;
			}
			}
		}
		catch (global::custom_exception.CCustomException)
		{
			throw;
		}
		catch (global::System.Exception ex)
		{
			if (global::custom_exception.CCustomException.CheckErrorIDExsists(ex))
			{
				goto IL_110;
			}
			if (true)
			{
			}
			IL_E3:
			ex.Source = 2393U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex.Source;
			IL_110:
			switch ((1 == 1) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_E3;
			default:
				if (false)
				{
				}
				global::custom_exception.CCustomException.Rethrow(ex);
				break;
			}
		}
	}

	// Token: 0x06000008 RID: 8 RVA: 0x00002E98 File Offset: 0x00001E98
	public static void b(string A_0, ref string A_1, bool A_2, global::d.c A_3)
	{
		try
		{
			int num;
			switch ((1 == 1) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_1E6:
				num = 4;
				break;
			default:
				if (false)
				{
				}
				switch (0)
				{
				default:
					num = 1;
					break;
				}
				break;
			}
			global::System.Security.Cryptography.RijndaelManaged rijndaelManaged;
			string str;
			string str2;
			for (;;)
			{
				switch (num)
				{
				case 0:
					if (!global::System.IO.File.Exists(global::System.IO.Path.GetFullPath(A_0)))
					{
						num = 3;
						continue;
					}
					goto IL_1D5;
				case 2:
					goto IL_224;
				case 3:
					goto IL_89;
				case 4:
					try
					{
						rijndaelManaged.Key = global::System.Convert.FromBase64String(str + "=");
						rijndaelManaged.IV = global::System.Convert.FromBase64String(str2 + "==");
						byte[] array = null;
						byte[] bytes = null;
						global::System.IO.FileStream fileStream = new global::System.IO.FileStream(A_0, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read);
						try
						{
							array = new byte[fileStream.Length + 3L];
							array[0] = 239;
							array[1] = 187;
							array[2] = 191;
							fileStream.Read(array, 3, (int)fileStream.Length);
						}
						finally
						{
							num = 2;
							for (;;)
							{
								switch (num)
								{
								case 0:
									goto IL_16E;
								case 1:
									((global::System.IDisposable)fileStream).Dispose();
									num = 0;
									continue;
								}
								if (fileStream == null)
								{
									break;
								}
								num = 1;
							}
							IL_16E:;
						}
						global::d.a(array, ref bytes, A_2, rijndaelManaged.CreateEncryptor());
						A_1 = global::System.Text.Encoding.UTF8.GetString(bytes);
						goto IL_218;
					}
					finally
					{
						num = 0;
						for (;;)
						{
							switch (num)
							{
							case 1:
								((global::System.IDisposable)rijndaelManaged).Dispose();
								num = 2;
								continue;
							case 2:
								goto IL_1D2;
							}
							if (rijndaelManaged == null)
							{
								break;
							}
							num = 1;
						}
						IL_1D2:;
					}
					goto IL_1D5;
					IL_218:
					num = 2;
					continue;
				case 5:
					goto IL_65;
				}
				if (string.IsNullOrEmpty(A_0))
				{
					num = 5;
				}
				else
				{
					num = 0;
				}
			}
			IL_65:
			global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(2388U, "Secure", "EncryptFile", global::System.Environment.StackTrace.ToString());
			throw ex;
			IL_89:
			global::custom_exception.CCustomException ex2 = new global::custom_exception.CCustomException(2392U, "Secure", "EncryptFile", global::System.Environment.StackTrace.ToString());
			throw ex2;
			IL_1D5:
			global::d.a(A_3, out str, out str2);
			rijndaelManaged = new global::System.Security.Cryptography.RijndaelManaged();
			goto IL_1E6;
			IL_224:;
		}
		catch (global::custom_exception.CCustomException)
		{
			throw;
		}
		catch (global::System.Exception ex3)
		{
			if (!global::custom_exception.CCustomException.CheckErrorIDExsists(ex3))
			{
				ex3.Source = 2393U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex3.Source;
			}
			global::custom_exception.CCustomException.Rethrow(ex3);
		}
		if (true)
		{
		}
	}

	// Token: 0x06000009 RID: 9 RVA: 0x00003188 File Offset: 0x00002188
	public static void b(string A_0, string A_1, bool A_2)
	{
		try
		{
			switch (0)
			{
			default:
			{
				if (true)
				{
				}
				global::System.Security.Cryptography.TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new global::System.Security.Cryptography.TripleDESCryptoServiceProvider();
				try
				{
					for (;;)
					{
						tripleDESCryptoServiceProvider.Key = global::System.Text.Encoding.ASCII.GetBytes("HAVNCPSLTDTUNERAIRTRACER");
						tripleDESCryptoServiceProvider.IV = global::System.Text.Encoding.ASCII.GetBytes("VEDKDJSP");
						byte[] array = null;
						byte[] array2 = null;
						global::System.IO.FileStream fileStream = new global::System.IO.FileStream(A_0, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read);
						int num = 1;
						for (;;)
						{
							switch (num)
							{
							case 0:
								goto IL_16E;
							case 1:
								try
								{
									array = new byte[fileStream.Length];
									fileStream.Read(array, 0, array.Length);
									goto IL_13B;
								}
								finally
								{
									for (;;)
									{
										IL_93:
										num = 2;
										for (;;)
										{
											switch (num)
											{
											case 0:
												goto IL_EA;
											case 1:
												((global::System.IDisposable)fileStream).Dispose();
												num = 0;
												continue;
											}
											if (fileStream == null)
											{
												goto IL_EC;
											}
											switch ((1 == 1) ? 1 : 0)
											{
											case 0:
											case 2:
												goto IL_93;
											default:
												if (false)
												{
												}
												num = 1;
												break;
											}
										}
									}
									IL_EA:
									IL_EC:;
								}
								goto Block_4;
							case 2:
								goto IL_ED;
							}
							break;
							IL_13B:
							global::d.a(array, ref array2, A_2, tripleDESCryptoServiceProvider.CreateEncryptor());
							global::System.IO.FileStream fileStream2 = new global::System.IO.FileStream(A_1, global::System.IO.FileMode.Create, global::System.IO.FileAccess.Write);
							num = 2;
							continue;
							Block_4:
							try
							{
								IL_ED:
								fileStream2.Write(array2, 0, array2.Length);
								goto IL_162;
							}
							finally
							{
								num = 1;
								for (;;)
								{
									switch (num)
									{
									case 0:
										((global::System.IDisposable)fileStream2).Dispose();
										num = 2;
										continue;
									case 2:
										goto IL_138;
									}
									if (fileStream2 == null)
									{
										break;
									}
									num = 0;
								}
								IL_138:;
							}
							goto IL_13B;
							IL_162:
							num = 0;
						}
					}
					IL_16E:;
				}
				finally
				{
					int num = 0;
					for (;;)
					{
						switch (num)
						{
						case 1:
							((global::System.IDisposable)tripleDESCryptoServiceProvider).Dispose();
							num = 2;
							continue;
						case 2:
							goto IL_1AB;
						}
						if (tripleDESCryptoServiceProvider == null)
						{
							break;
						}
						num = 1;
					}
					IL_1AB:;
				}
				break;
			}
			}
		}
		catch (global::custom_exception.CCustomException)
		{
			throw;
		}
		catch (global::System.Exception ex)
		{
			if (!global::custom_exception.CCustomException.CheckErrorIDExsists(ex))
			{
				ex.Source = 2393U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex.Source;
			}
			global::custom_exception.CCustomException.Rethrow(ex);
		}
	}

	// Token: 0x0600000A RID: 10 RVA: 0x00003414 File Offset: 0x00002414
	public static void a(byte[] A_0, ref byte[] A_1)
	{
		switch (0)
		{
		default:
		{
			if (true)
			{
			}
			global::System.Security.Cryptography.TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new global::System.Security.Cryptography.TripleDESCryptoServiceProvider();
			try
			{
				tripleDESCryptoServiceProvider.Key = global::System.Text.Encoding.ASCII.GetBytes("HAVNCPSLTDTUNERAIRTRACER");
				tripleDESCryptoServiceProvider.IV = global::System.Text.Encoding.ASCII.GetBytes("VEDKDJSP");
				try
				{
					int num = 5;
					for (;;)
					{
						switch (num)
						{
						case 0:
						{
							if (tripleDESCryptoServiceProvider == null)
							{
								num = 3;
								continue;
							}
							long num2 = 0L;
							long num3 = (long)(A_0.Length + 3);
							byte[] buffer = new byte[1024];
							byte[] array = new byte[num3];
							array[0] = 239;
							array[1] = 187;
							array[2] = 191;
							global::System.Array.Copy(A_0, 0, array, 3, A_0.Length);
							global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(array);
							global::System.IO.MemoryStream memoryStream2 = new global::System.IO.MemoryStream();
							memoryStream2.SetLength((long)array.Length);
							global::System.Security.Cryptography.CryptoStream cryptoStream = new global::System.Security.Cryptography.CryptoStream(memoryStream2, tripleDESCryptoServiceProvider.CreateEncryptor(), global::System.Security.Cryptography.CryptoStreamMode.Write);
							num = 1;
							continue;
						}
						case 1:
							try
							{
								num = 1;
								for (;;)
								{
									switch (num)
									{
									case 0:
									{
										global::System.Security.Cryptography.CryptoStream cryptoStream;
										cryptoStream.FlushFinalBlock();
										global::System.IO.MemoryStream memoryStream2;
										A_1 = memoryStream2.ToArray();
										num = 2;
										continue;
									}
									case 2:
										goto IL_11F;
									case 3:
									{
										long num2;
										long num3;
										if (num2 >= num3)
										{
											num = 0;
											continue;
										}
										byte[] buffer;
										global::System.IO.MemoryStream memoryStream;
										int num4 = memoryStream.Read(buffer, 0, 1024);
										global::System.Security.Cryptography.CryptoStream cryptoStream;
										cryptoStream.Write(buffer, 0, num4);
										num2 += (long)num4;
										num = 4;
										continue;
									}
									}
									IL_ED:
									num = 3;
									continue;
									goto IL_ED;
								}
								IL_11F:
								goto IL_24F;
							}
							finally
							{
								num = 0;
								for (;;)
								{
									global::System.Security.Cryptography.CryptoStream cryptoStream;
									switch (num)
									{
									case 1:
										((global::System.IDisposable)cryptoStream).Dispose();
										num = 2;
										continue;
									case 2:
										goto IL_161;
									}
									if (cryptoStream == null)
									{
										break;
									}
									num = 1;
								}
								IL_161:;
							}
							goto IL_164;
							IL_24F:
							num = 7;
							continue;
						case 2:
							num = 0;
							continue;
						case 3:
							goto IL_24A;
						case 4:
							num = 6;
							continue;
						case 6:
							if (A_1 != null)
							{
								num = 2;
								continue;
							}
							goto IL_164;
						case 7:
							goto IL_25B;
						}
						if (A_0 == null)
						{
							break;
						}
						num = 4;
					}
					IL_164:
					global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(2388U, "Secure", ", EncryptFile", global::System.Environment.StackTrace.ToString());
					throw ex;
					IL_24A:
					goto IL_164;
					IL_25B:;
				}
				catch (global::custom_exception.CCustomException ex2)
				{
					throw ex2;
				}
				catch (global::System.Exception ex3)
				{
					if (global::custom_exception.CCustomException.CheckErrorIDExsists(ex3))
					{
						goto IL_297;
					}
					IL_26D:
					ex3.Source = 2389U.ToString() + "|" + ex3.Source;
					IL_297:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_26D;
					default:
						if (false)
						{
						}
						global::custom_exception.CCustomException.Rethrow(ex3);
						break;
					}
				}
			}
			finally
			{
				int num = 0;
				for (;;)
				{
					switch (num)
					{
					case 1:
						((global::System.IDisposable)tripleDESCryptoServiceProvider).Dispose();
						num = 2;
						continue;
					case 2:
						goto IL_2F9;
					}
					if (tripleDESCryptoServiceProvider == null)
					{
						break;
					}
					num = 1;
				}
				IL_2F9:;
			}
			return;
		}
		}
	}

	// Token: 0x0600000B RID: 11 RVA: 0x00003784 File Offset: 0x00002784
	public static void a(string A_0, string A_1, bool A_2, global::d.c A_3)
	{
		try
		{
			switch (0)
			{
			default:
			{
				int num = 4;
				for (;;)
				{
					switch (num)
					{
					case 0:
						if (string.IsNullOrEmpty(A_1))
						{
							num = 3;
							continue;
						}
						num = 2;
						continue;
					case 1:
						goto IL_207;
					case 2:
					{
						if (!global::System.IO.File.Exists(global::System.IO.Path.GetFullPath(A_0)))
						{
							num = 6;
							continue;
						}
						string str;
						string str2;
						global::d.a(A_3, out str, out str2);
						global::System.Security.Cryptography.RijndaelManaged rijndaelManaged = new global::System.Security.Cryptography.RijndaelManaged();
						num = 7;
						continue;
					}
					case 3:
						goto IL_227;
					case 5:
						goto IL_2A2;
					case 6:
						goto IL_294;
					case 7:
						try
						{
							for (;;)
							{
								string str;
								global::System.Security.Cryptography.RijndaelManaged rijndaelManaged;
								rijndaelManaged.Key = global::System.Convert.FromBase64String(str + "=");
								string str2;
								rijndaelManaged.IV = global::System.Convert.FromBase64String(str2 + "==");
								byte[] array = null;
								byte[] array2 = null;
								global::System.IO.FileStream fileStream = new global::System.IO.FileStream(A_0, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read);
								num = 2;
								for (;;)
								{
									global::System.IO.FileStream fileStream2;
									switch (num)
									{
									case 0:
										goto IL_1C2;
									case 1:
										try
										{
											fileStream2.Write(array2, 0, array2.Length);
											goto IL_1B6;
										}
										finally
										{
											num = 0;
											for (;;)
											{
												switch (num)
												{
												case 1:
													goto IL_125;
												case 2:
													((global::System.IDisposable)fileStream2).Dispose();
													num = 1;
													continue;
												}
												if (fileStream2 == null)
												{
													break;
												}
												num = 2;
											}
											IL_125:;
										}
										goto Block_7;
										IL_1B6:
										num = 0;
										continue;
									case 2:
										goto IL_128;
									}
									break;
									Block_7:
									try
									{
										IL_128:
										array = new byte[fileStream.Length];
										fileStream.Read(array, 0, array.Length);
									}
									finally
									{
										num = 0;
										for (;;)
										{
											switch (num)
											{
											case 1:
												((global::System.IDisposable)fileStream).Dispose();
												num = 2;
												continue;
											case 2:
												goto IL_185;
											}
											if (fileStream == null)
											{
												break;
											}
											num = 1;
										}
										IL_185:;
									}
									global::d.a(array, ref array2, A_2, A_3, rijndaelManaged.CreateDecryptor());
									fileStream2 = new global::System.IO.FileStream(A_1, global::System.IO.FileMode.OpenOrCreate, global::System.IO.FileAccess.Write);
									num = 1;
								}
							}
							IL_1C2:
							goto IL_296;
						}
						finally
						{
							num = 1;
							for (;;)
							{
								global::System.Security.Cryptography.RijndaelManaged rijndaelManaged;
								switch (num)
								{
								case 0:
									((global::System.IDisposable)rijndaelManaged).Dispose();
									num = 2;
									continue;
								case 2:
									goto IL_204;
								}
								if (rijndaelManaged == null)
								{
									break;
								}
								num = 0;
							}
							IL_204:;
						}
						goto IL_207;
						IL_296:
						num = 5;
						continue;
					}
					if (!string.IsNullOrEmpty(A_0))
					{
						num = 1;
						continue;
					}
					break;
					IL_207:
					num = 0;
				}
				IL_56:
				global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(2388U, "Secure", "DecryptFile", global::System.Environment.StackTrace.ToString());
				throw ex;
				IL_227:
				goto IL_56;
				IL_294:
				global::custom_exception.CCustomException ex2 = new global::custom_exception.CCustomException(2392U, "Secure", "DecryptFile", global::System.Environment.StackTrace.ToString());
				throw ex2;
				IL_2A2:
				break;
			}
			}
		}
		catch (global::custom_exception.CCustomException)
		{
			throw;
		}
		catch (global::System.Exception ex3)
		{
			if (global::custom_exception.CCustomException.CheckErrorIDExsists(ex3))
			{
				goto IL_2E9;
			}
			IL_2B2:
			if (true)
			{
			}
			ex3.Source = 2394U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex3.Source;
			IL_2E9:
			switch ((1 == 1) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_2B2;
			default:
				if (false)
				{
				}
				global::custom_exception.CCustomException.Rethrow(ex3);
				break;
			}
		}
	}

	// Token: 0x0600000C RID: 12 RVA: 0x00003B28 File Offset: 0x00002B28
	public static void a(byte[] A_0, ref byte[] A_1, bool A_2, global::d.c A_3)
	{
		try
		{
			switch (0)
			{
			default:
			{
				string str;
				string str2;
				global::d.a(A_3, out str, out str2);
				global::System.Security.Cryptography.RijndaelManaged rijndaelManaged = new global::System.Security.Cryptography.RijndaelManaged();
				try
				{
					rijndaelManaged.Key = global::System.Convert.FromBase64String(str + "=");
					rijndaelManaged.IV = global::System.Convert.FromBase64String(str2 + "==");
					global::d.a(A_0, ref A_1, A_2, A_3, rijndaelManaged.CreateDecryptor());
				}
				finally
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
								continue;
							default:
								if (false)
								{
								}
								((global::System.IDisposable)rijndaelManaged).Dispose();
								num = 2;
								continue;
							}
							break;
						case 2:
							goto IL_B5;
						}
						if (rijndaelManaged == null)
						{
							break;
						}
						num = 0;
					}
					IL_B5:;
				}
				break;
			}
			}
		}
		catch (global::custom_exception.CCustomException)
		{
			throw;
		}
		catch (global::System.Exception ex)
		{
			if (!global::custom_exception.CCustomException.CheckErrorIDExsists(ex))
			{
				ex.Source = 2394U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex.Source;
			}
			global::custom_exception.CCustomException.Rethrow(ex);
		}
		if (true)
		{
		}
	}

	// Token: 0x0600000D RID: 13 RVA: 0x00003C6C File Offset: 0x00002C6C
	public static void a(string A_0, ref string A_1, bool A_2, global::d.c A_3)
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
					global::System.Security.Cryptography.RijndaelManaged rijndaelManaged;
					string str;
					string str2;
					switch (num)
					{
					case 1:
						try
						{
							byte[] array;
							byte[] bytes;
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
								rijndaelManaged.Key = global::System.Convert.FromBase64String(str + "=");
								rijndaelManaged.IV = global::System.Convert.FromBase64String(str2 + "==");
								array = null;
								bytes = null;
								global::System.IO.FileStream fileStream = new global::System.IO.FileStream(A_0, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read);
								try
								{
									array = new byte[fileStream.Length];
									fileStream.Read(array, 0, array.Length);
								}
								finally
								{
									num = 0;
									for (;;)
									{
										switch (num)
										{
										case 1:
											goto IL_14C;
										case 2:
											((global::System.IDisposable)fileStream).Dispose();
											num = 1;
											continue;
										}
										if (fileStream == null)
										{
											break;
										}
										num = 2;
									}
									IL_14C:;
								}
								break;
							}
							}
							global::System.Text.Encoding encoding = global::d.a(array, ref bytes, A_2, A_3, rijndaelManaged.CreateDecryptor());
							A_1 = encoding.GetString(bytes);
							goto IL_1F6;
						}
						finally
						{
							num = 0;
							for (;;)
							{
								switch (num)
								{
								case 1:
									((global::System.IDisposable)rijndaelManaged).Dispose();
									num = 2;
									continue;
								case 2:
									goto IL_1B0;
								}
								if (rijndaelManaged == null)
								{
									break;
								}
								num = 1;
							}
							IL_1B0:;
						}
						goto IL_1B3;
						IL_1F6:
						num = 4;
						continue;
					case 2:
						if (!global::System.IO.File.Exists(global::System.IO.Path.GetFullPath(A_0)))
						{
							num = 5;
							continue;
						}
						goto IL_1B3;
					case 3:
						goto IL_49;
					case 4:
						goto IL_202;
					case 5:
						goto IL_6D;
					}
					if (string.IsNullOrEmpty(A_0))
					{
						num = 3;
						continue;
					}
					num = 2;
					continue;
					IL_1B3:
					global::d.a(A_3, out str, out str2);
					rijndaelManaged = new global::System.Security.Cryptography.RijndaelManaged();
					num = 1;
				}
				IL_49:
				global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(2388U, "Secure", "DecryptFile", global::System.Environment.StackTrace.ToString());
				throw ex;
				IL_6D:
				global::custom_exception.CCustomException ex2 = new global::custom_exception.CCustomException(2392U, "Secure", "DecryptFile", global::System.Environment.StackTrace.ToString());
				throw ex2;
				IL_202:
				break;
			}
			}
		}
		catch (global::custom_exception.CCustomException)
		{
			throw;
		}
		catch (global::System.Exception ex3)
		{
			if (!global::custom_exception.CCustomException.CheckErrorIDExsists(ex3))
			{
				if (true)
				{
				}
				ex3.Source = 2394U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex3.Source;
			}
			global::custom_exception.CCustomException.Rethrow(ex3);
		}
	}

	// Token: 0x0600000E RID: 14 RVA: 0x00003F3C File Offset: 0x00002F3C
	public static void a(string A_0, string A_1, bool A_2)
	{
		try
		{
			switch (0)
			{
			default:
			{
				int num = 7;
				for (;;)
				{
					switch (num)
					{
					case 0:
						goto IL_299;
					case 1:
						goto IL_237;
					case 2:
						goto IL_217;
					case 3:
						if (string.IsNullOrEmpty(A_1))
						{
							num = 1;
							continue;
						}
						num = 6;
						continue;
					case 4:
						try
						{
							for (;;)
							{
								IL_8C:
								global::System.Security.Cryptography.TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider;
								tripleDESCryptoServiceProvider.Key = global::System.Text.Encoding.ASCII.GetBytes("HAVNCPSLTDTUNERAIRTRACER");
								tripleDESCryptoServiceProvider.IV = global::System.Text.Encoding.ASCII.GetBytes("VEDKDJSP");
								byte[] array = null;
								byte[] array2 = null;
								global::System.IO.FileStream fileStream = new global::System.IO.FileStream(A_0, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read);
								num = 2;
								for (;;)
								{
									global::System.IO.FileStream fileStream2;
									switch (num)
									{
									case 0:
										goto IL_1B8;
									case 1:
										try
										{
											fileStream2.Write(array2, 0, array2.Length);
											goto IL_1AC;
										}
										finally
										{
											num = 1;
											for (;;)
											{
												switch (num)
												{
												case 0:
													((global::System.IDisposable)fileStream2).Dispose();
													num = 2;
													continue;
												case 2:
													goto IL_120;
												}
												if (fileStream2 == null)
												{
													break;
												}
												num = 0;
											}
											IL_120:;
										}
										goto Block_7;
										IL_1AC:
										num = 0;
										continue;
									case 2:
										goto IL_123;
									}
									goto IL_8C;
									Block_7:
									try
									{
										IL_123:
										array = new byte[fileStream.Length];
										fileStream.Read(array, 0, array.Length);
									}
									finally
									{
										num = 2;
										for (;;)
										{
											switch (num)
											{
											case 0:
												goto IL_17D;
											case 1:
												((global::System.IDisposable)fileStream).Dispose();
												num = 0;
												continue;
											}
											if (fileStream == null)
											{
												break;
											}
											num = 1;
										}
										IL_17D:;
									}
									global::d.a(array, ref array2, A_2, global::d.c.a, tripleDESCryptoServiceProvider.CreateDecryptor());
									fileStream2 = new global::System.IO.FileStream(A_1, global::System.IO.FileMode.OpenOrCreate, global::System.IO.FileAccess.Write);
									num = 1;
								}
								IL_1B8:
								switch ((1 == 1) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									goto IL_1CE;
								}
							}
							IL_1CE:
							if (false)
							{
							}
							goto IL_29B;
						}
						finally
						{
							num = 1;
							for (;;)
							{
								global::System.Security.Cryptography.TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider;
								switch (num)
								{
								case 0:
									((global::System.IDisposable)tripleDESCryptoServiceProvider).Dispose();
									num = 2;
									continue;
								case 2:
									goto IL_214;
								}
								if (tripleDESCryptoServiceProvider == null)
								{
									break;
								}
								num = 0;
							}
							IL_214:;
						}
						goto IL_217;
						IL_29B:
						num = 5;
						continue;
					case 5:
						goto IL_2A7;
					case 6:
					{
						if (!global::System.IO.File.Exists(global::System.IO.Path.GetFullPath(A_0)))
						{
							num = 0;
							continue;
						}
						global::System.Security.Cryptography.TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new global::System.Security.Cryptography.TripleDESCryptoServiceProvider();
						num = 4;
						continue;
					}
					}
					if (!string.IsNullOrEmpty(A_0))
					{
						num = 2;
						continue;
					}
					break;
					IL_217:
					num = 3;
				}
				IL_56:
				global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(2388U, "Secure", "DecryptFile", global::System.Environment.StackTrace.ToString());
				throw ex;
				IL_237:
				goto IL_56;
				IL_299:
				global::custom_exception.CCustomException ex2 = new global::custom_exception.CCustomException(2392U, "Secure", "DecryptFile", global::System.Environment.StackTrace.ToString());
				throw ex2;
				IL_2A7:
				break;
			}
			}
		}
		catch (global::custom_exception.CCustomException)
		{
			throw;
		}
		catch (global::System.Exception ex3)
		{
			if (!global::custom_exception.CCustomException.CheckErrorIDExsists(ex3))
			{
				ex3.Source = 2394U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex3.Source;
			}
			if (true)
			{
			}
			global::custom_exception.CCustomException.Rethrow(ex3);
		}
	}

	// Token: 0x0600000F RID: 15 RVA: 0x000042C8 File Offset: 0x000032C8
	public static void a(byte[] A_0, ref byte[] A_1, bool A_2)
	{
		try
		{
			global::System.Security.Cryptography.TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new global::System.Security.Cryptography.TripleDESCryptoServiceProvider();
			try
			{
				tripleDESCryptoServiceProvider.Key = global::System.Text.Encoding.ASCII.GetBytes("HAVNCPSLTDTUNERAIRTRACER");
				tripleDESCryptoServiceProvider.IV = global::System.Text.Encoding.ASCII.GetBytes("VEDKDJSP");
				global::d.a(A_0, ref A_1, A_2, global::d.c.a, tripleDESCryptoServiceProvider.CreateDecryptor());
			}
			finally
			{
				int num = 2;
				for (;;)
				{
					switch (num)
					{
					case 0:
						((global::System.IDisposable)tripleDESCryptoServiceProvider).Dispose();
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_99;
						default:
							if (false)
							{
							}
							num = 1;
							continue;
						}
						break;
					case 1:
						goto IL_97;
					}
					if (tripleDESCryptoServiceProvider == null)
					{
						break;
					}
					num = 0;
				}
				IL_97:
				IL_99:;
			}
			if (true)
			{
			}
		}
		catch (global::custom_exception.CCustomException)
		{
			throw;
		}
		catch (global::System.Exception ex)
		{
			if (!global::custom_exception.CCustomException.CheckErrorIDExsists(ex))
			{
				ex.Source = 2394U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex.Source;
			}
			global::custom_exception.CCustomException.Rethrow(ex);
		}
	}

	// Token: 0x06000010 RID: 16 RVA: 0x000043EC File Offset: 0x000033EC
	public static void a(string A_0, ref string A_1, bool A_2)
	{
		try
		{
			switch (0)
			{
			default:
			{
				global::System.Security.Cryptography.TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new global::System.Security.Cryptography.TripleDESCryptoServiceProvider();
				try
				{
					tripleDESCryptoServiceProvider.Key = global::System.Text.Encoding.ASCII.GetBytes("HAVNCPSLTDTUNERAIRTRACER");
					tripleDESCryptoServiceProvider.IV = global::System.Text.Encoding.ASCII.GetBytes("VEDKDJSP");
					byte[] array = null;
					byte[] bytes = null;
					global::System.IO.FileStream fileStream = new global::System.IO.FileStream(A_0, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read);
					try
					{
						array = new byte[fileStream.Length];
						fileStream.Read(array, 0, array.Length);
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
								goto IL_A5;
							}
							if (fileStream == null)
							{
								break;
							}
							num = 0;
						}
						IL_A5:;
					}
					global::System.Text.Encoding encoding = global::d.a(array, ref bytes, A_2, global::d.c.a, tripleDESCryptoServiceProvider.CreateDecryptor());
					A_1 = encoding.GetString(bytes);
				}
				finally
				{
					int num = 2;
					for (;;)
					{
						switch (num)
						{
						case 0:
							goto IL_101;
						case 1:
							((global::System.IDisposable)tripleDESCryptoServiceProvider).Dispose();
							num = 0;
							continue;
						}
						if (tripleDESCryptoServiceProvider == null)
						{
							break;
						}
						num = 1;
					}
					IL_101:;
				}
				break;
			}
			}
		}
		catch (global::custom_exception.CCustomException)
		{
			throw;
		}
		catch (global::System.Exception ex)
		{
			if (global::custom_exception.CCustomException.CheckErrorIDExsists(ex))
			{
				goto IL_143;
			}
			IL_116:
			ex.Source = 2394U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex.Source;
			IL_143:
			switch ((1 == 1) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_116;
			default:
				if (false)
				{
				}
				global::custom_exception.CCustomException.Rethrow(ex);
				break;
			}
		}
		if (true)
		{
		}
	}

	// Token: 0x06000011 RID: 17 RVA: 0x000045D8 File Offset: 0x000035D8
	private static void a(byte[] A_0, ref byte[] A_1, bool A_2, global::System.Security.Cryptography.ICryptoTransform A_3)
	{
		try
		{
			switch (0)
			{
			default:
			{
				int num = 5;
				for (;;)
				{
					global::System.IO.MemoryStream memoryStream2;
					switch (num)
					{
					case 0:
						if (A_2)
						{
							num = 2;
							continue;
						}
						goto IL_148;
					case 1:
						goto IL_25F;
					case 2:
					{
						global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
						num = 6;
						continue;
					}
					case 3:
						goto IL_122;
					case 4:
						goto IL_143;
					case 6:
						try
						{
							global::System.IO.MemoryStream memoryStream;
							global::System.IO.Compression.GZipStream gzipStream = new global::System.IO.Compression.GZipStream(memoryStream, global::System.IO.Compression.CompressionMode.Compress, true);
							try
							{
								gzipStream.Write(A_0, 0, A_0.Length);
							}
							finally
							{
								num = 2;
								for (;;)
								{
									switch (num)
									{
									case 0:
										goto IL_1CE;
									case 1:
										((global::System.IDisposable)gzipStream).Dispose();
										goto IL_1C5;
									}
									switch ((1 == 1) ? 1 : 0)
									{
									case 0:
									case 2:
										IL_1C5:
										num = 0;
										break;
									default:
										if (false)
										{
										}
										if (gzipStream == null)
										{
											goto IL_1D0;
										}
										num = 1;
										break;
									}
								}
								IL_1CE:
								IL_1D0:;
							}
							A_0 = memoryStream.ToArray();
							goto IL_148;
						}
						finally
						{
							num = 1;
							for (;;)
							{
								global::System.IO.MemoryStream memoryStream;
								switch (num)
								{
								case 0:
									goto IL_219;
								case 2:
									((global::System.IDisposable)memoryStream).Dispose();
									num = 0;
									continue;
								}
								if (memoryStream == null)
								{
									break;
								}
								num = 2;
							}
							IL_219:;
						}
						goto IL_21C;
					case 7:
						try
						{
							global::System.Security.Cryptography.CryptoStream cryptoStream = new global::System.Security.Cryptography.CryptoStream(memoryStream2, A_3, global::System.Security.Cryptography.CryptoStreamMode.Write);
							try
							{
								cryptoStream.Write(A_0, 0, A_0.Length);
								cryptoStream.FlushFinalBlock();
							}
							finally
							{
								num = 2;
								for (;;)
								{
									switch (num)
									{
									case 0:
										((global::System.IDisposable)cryptoStream).Dispose();
										num = 1;
										continue;
									case 1:
										goto IL_D4;
									}
									if (cryptoStream == null)
									{
										break;
									}
									num = 0;
								}
								IL_D4:;
							}
							A_1 = memoryStream2.ToArray();
							goto IL_253;
						}
						finally
						{
							num = 2;
							for (;;)
							{
								switch (num)
								{
								case 0:
									goto IL_11F;
								case 1:
									((global::System.IDisposable)memoryStream2).Dispose();
									num = 0;
									continue;
								}
								if (memoryStream2 == null)
								{
									break;
								}
								num = 1;
							}
							IL_11F:;
						}
						goto IL_122;
						IL_253:
						num = 1;
						continue;
					case 8:
						if (A_0.Length <= 0)
						{
							num = 4;
							continue;
						}
						goto IL_21C;
					}
					if (A_0 != null)
					{
						num = 3;
						continue;
					}
					break;
					IL_122:
					num = 8;
					continue;
					IL_148:
					memoryStream2 = new global::System.IO.MemoryStream();
					num = 7;
					continue;
					IL_21C:
					num = 0;
				}
				IL_55:
				global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(2388U, "Secure", "EncryptFile", global::System.Environment.StackTrace.ToString());
				throw ex;
				IL_143:
				goto IL_55;
				IL_25F:
				break;
			}
			}
		}
		catch (global::custom_exception.CCustomException)
		{
			throw;
		}
		catch (global::System.Exception ex2)
		{
			if (!global::custom_exception.CCustomException.CheckErrorIDExsists(ex2))
			{
				ex2.Source = 2393U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex2.Source;
			}
			global::custom_exception.CCustomException.Rethrow(ex2);
		}
		if (true)
		{
		}
	}

	// Token: 0x06000012 RID: 18 RVA: 0x00004934 File Offset: 0x00003934
	private static global::System.Text.Encoding a(byte[] A_0, ref byte[] A_1, bool A_2, global::d.c A_3, global::System.Security.Cryptography.ICryptoTransform A_4)
	{
		switch (0)
		{
		default:
		{
			if (true)
			{
			}
			global::System.Text.Encoding encoding = null;
			try
			{
				int num = 22;
				for (;;)
				{
					byte[] array;
					byte b;
					global::System.IO.MemoryStream memoryStream;
					switch (num)
					{
					case 0:
						goto IL_615;
					case 1:
						goto IL_615;
					case 2:
						A_1 = new byte[array.Length - 3];
						global::System.Array.Copy(array, 3, A_1, 0, array.Length - 3);
						encoding = new global::System.Text.UTF8Encoding();
						global::d.a(ref A_1, encoding);
						num = 3;
						continue;
					case 3:
						goto IL_615;
					case 4:
						A_1 = new byte[array.Length - 2];
						global::System.Array.Copy(array, 2, A_1, 0, array.Length - 2);
						encoding = new global::System.Text.UnicodeEncoding();
						global::d.a(ref A_1, encoding);
						num = 20;
						continue;
					case 5:
						num = 26;
						continue;
					case 6:
						goto IL_621;
					case 7:
						if (array[1].Equals(187))
						{
							num = 5;
							continue;
						}
						goto IL_5B9;
					case 8:
						num = 23;
						continue;
					case 9:
						encoding = global::System.Text.Encoding.GetEncoding(1252);
						num = 15;
						continue;
					case 10:
						if (b != 239)
						{
							num = 14;
							continue;
						}
						num = 7;
						continue;
					case 11:
						switch (b)
						{
						case 254:
							num = 25;
							continue;
						case 255:
							num = 19;
							continue;
						default:
							num = 8;
							continue;
						}
						break;
					case 12:
						goto IL_154;
						try
						{
							for (;;)
							{
								IL_154:
								memoryStream = new global::System.IO.MemoryStream(array);
								global::System.IO.Compression.GZipStream gzipStream = new global::System.IO.Compression.GZipStream(memoryStream, global::System.IO.Compression.CompressionMode.Decompress, false);
								try
								{
									memoryStream = null;
									byte[] array2 = new byte[4096];
									global::System.IO.MemoryStream memoryStream2 = new global::System.IO.MemoryStream();
									try
									{
										for (;;)
										{
											num = 2;
											for (;;)
											{
												switch (num)
												{
												case 0:
													goto IL_1F9;
												case 1:
												{
													int count;
													if ((count = gzipStream.Read(array2, 0, array2.Length)) <= 0)
													{
														num = 4;
														continue;
													}
													memoryStream2.Write(array2, 0, count);
													num = 3;
													continue;
												}
												case 2:
													goto IL_1A9;
												case 3:
													goto IL_1A9;
												case 4:
													array = memoryStream2.ToArray();
													num = 0;
													continue;
												}
												break;
												IL_1A9:
												num = 1;
											}
										}
										IL_1F9:;
									}
									finally
									{
										num = 0;
										for (;;)
										{
											switch (num)
											{
											case 1:
												goto IL_238;
											case 2:
												((global::System.IDisposable)memoryStream2).Dispose();
												num = 1;
												continue;
											}
											if (memoryStream2 == null)
											{
												break;
											}
											num = 2;
										}
										IL_238:;
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
											goto IL_27A;
										}
										if (gzipStream == null)
										{
											break;
										}
										num = 0;
									}
									IL_27A:;
								}
								switch ((1 == 1) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									goto IL_293;
								}
							}
							IL_293:
							if (false)
							{
							}
							goto IL_382;
						}
						finally
						{
							num = 0;
							for (;;)
							{
								switch (num)
								{
								case 1:
									memoryStream.Dispose();
									num = 2;
									continue;
								case 2:
									goto IL_2D9;
								}
								if (memoryStream == null)
								{
									break;
								}
								num = 1;
							}
							IL_2D9:;
						}
						goto IL_2DC;
					case 13:
						try
						{
							memoryStream = new global::System.IO.MemoryStream(A_0);
							global::System.Security.Cryptography.CryptoStream cryptoStream = new global::System.Security.Cryptography.CryptoStream(memoryStream, A_4, global::System.Security.Cryptography.CryptoStreamMode.Read);
							try
							{
								memoryStream = null;
								cryptoStream.Read(array, 0, array.Length);
							}
							finally
							{
								num = 2;
								for (;;)
								{
									switch (num)
									{
									case 0:
										goto IL_50E;
									case 1:
										((global::System.IDisposable)cryptoStream).Dispose();
										num = 0;
										continue;
									}
									if (cryptoStream == null)
									{
										break;
									}
									num = 1;
								}
								IL_50E:;
							}
							goto IL_362;
						}
						finally
						{
							num = 0;
							for (;;)
							{
								switch (num)
								{
								case 1:
									goto IL_551;
								case 2:
									memoryStream.Dispose();
									num = 1;
									continue;
								}
								if (memoryStream == null)
								{
									break;
								}
								num = 2;
							}
							IL_551:;
						}
						goto IL_554;
						IL_362:
						num = 24;
						continue;
					case 14:
						goto IL_554;
					case 15:
						goto IL_318;
					case 16:
						goto IL_318;
					case 17:
						if (A_3 == global::d.c.e)
						{
							num = 9;
							continue;
						}
						encoding = new global::System.Text.UTF8Encoding();
						num = 16;
						continue;
					case 18:
						goto IL_B4;
					case 19:
						if (array[1].Equals(254))
						{
							num = 21;
							continue;
						}
						goto IL_DC;
					case 20:
						goto IL_615;
					case 21:
						A_1 = new byte[array.Length - 2];
						global::System.Array.Copy(array, 2, A_1, 0, array.Length - 2);
						encoding = new global::System.Text.UnicodeEncoding();
						global::d.a(ref A_1, encoding);
						num = 0;
						continue;
					case 23:
						goto IL_2DC;
					case 24:
						if (A_2)
						{
							num = 12;
							continue;
						}
						goto IL_382;
					case 25:
						if (array[1].Equals(255))
						{
							num = 4;
							continue;
						}
						goto IL_B9;
					case 26:
						if (array[2].Equals(191))
						{
							num = 2;
							continue;
						}
						goto IL_5B9;
					}
					if (A_0 == null)
					{
						num = 18;
						continue;
					}
					array = new byte[A_0.Length];
					memoryStream = null;
					num = 13;
					continue;
					IL_2DC:
					A_1 = new byte[array.Length];
					global::System.Array.Copy(array, 0, A_1, 0, array.Length);
					num = 17;
					continue;
					IL_318:
					global::d.a(ref A_1, encoding);
					num = 1;
					continue;
					IL_382:
					b = array[0];
					num = 10;
					continue;
					IL_554:
					num = 11;
					continue;
					IL_615:
					num = 6;
				}
				IL_B4:
				global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(2388U, "Secure", "DecryptFile", global::System.Environment.StackTrace.ToString());
				throw ex;
				IL_B9:
				global::custom_exception.CCustomException ex2 = new global::custom_exception.CCustomException(2391U, "Secure", "DecryptFile", global::System.Environment.StackTrace.ToString());
				throw ex2;
				IL_DC:
				global::custom_exception.CCustomException ex3 = new global::custom_exception.CCustomException(2391U, "Secure", "DecryptFile", global::System.Environment.StackTrace.ToString());
				throw ex3;
				IL_5B9:
				global::custom_exception.CCustomException ex4 = new global::custom_exception.CCustomException(2391U, "Secure", "DecryptFile", global::System.Environment.StackTrace.ToString());
				throw ex4;
				IL_621:;
			}
			catch (global::custom_exception.CCustomException)
			{
				throw;
			}
			catch (global::System.Exception ex5)
			{
				if (!global::custom_exception.CCustomException.CheckErrorIDExsists(ex5))
				{
					ex5.Source = 2394U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex5.Source;
				}
				global::custom_exception.CCustomException.Rethrow(ex5);
			}
			return encoding;
		}
		}
	}

	// Token: 0x06000013 RID: 19 RVA: 0x00005058 File Offset: 0x00004058
	public static void a(string A_0, ref uint A_1, ref byte[] A_2)
	{
		int num;
		switch ((1 == 1) ? 1 : 0)
		{
		case 0:
		case 2:
			IL_89:
			if (A_0.Length % 2 == 0)
			{
				goto IL_9D;
			}
			num = 2;
			break;
		default:
			if (false)
			{
			}
			num = 1;
			break;
		}
		for (;;)
		{
			switch (num)
			{
			case 0:
				goto IL_89;
			case 2:
				goto IL_9B;
			case 3:
				if (true)
				{
				}
				num = 0;
				continue;
			}
			if (string.IsNullOrEmpty(A_0))
			{
				goto IL_9D;
			}
			num = 3;
		}
		IL_9B:
		global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(2388U, "Secure", "ExtractHashHeader", global::System.Environment.StackTrace.ToString());
		throw ex;
		IL_9D:
		A_1 = global::d.a(A_0);
		A_2 = global::d.a(A_0, A_1);
	}

	// Token: 0x06000014 RID: 20 RVA: 0x00005114 File Offset: 0x00004114
	private static uint a(string A_0)
	{
		int num;
		switch ((1 == 1) ? 1 : 0)
		{
		case 0:
		case 2:
			IL_81:
			if (A_0.Length % 2 == 0)
			{
				goto IL_9D;
			}
			if (true)
			{
			}
			num = 3;
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
			switch (num)
			{
			case 0:
				num = 1;
				continue;
			case 1:
				goto IL_81;
			case 3:
				goto IL_9B;
			}
			if (string.IsNullOrEmpty(A_0))
			{
				goto IL_9D;
			}
			num = 0;
		}
		IL_9B:
		global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(2388U, "Secure", "ExtractAlgorithmID", global::System.Environment.StackTrace.ToString());
		throw ex;
		IL_9D:
		string text = A_0.Substring(0, 8);
		return uint.Parse(text, global::System.Globalization.NumberStyles.HexNumber, global::System.Globalization.CultureInfo.InvariantCulture);
	}

	// Token: 0x06000015 RID: 21 RVA: 0x000051DC File Offset: 0x000041DC
	private static byte[] a(string A_0, uint A_1)
	{
		switch (0)
		{
		default:
		{
			int num = 9;
			byte[] array;
			for (;;)
			{
				string text;
				switch (num)
				{
				case 0:
				{
					int num2;
					if ((long)num2 >= 24L)
					{
						num = 3;
						continue;
					}
					text = A_0.Substring((int)((4L + (long)num2) * 2L), 2);
					array[num2] = byte.Parse(text, global::System.Globalization.NumberStyles.HexNumber, global::System.Globalization.CultureInfo.InvariantCulture);
					num2++;
					num = 4;
					continue;
				}
				case 1:
					for (;;)
					{
						array = new byte[24];
						int num2 = 0;
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_B4;
						}
					}
					IL_B4:
					if (false)
					{
					}
					num = 12;
					continue;
				case 2:
					goto IL_11F;
				case 3:
					num = 6;
					continue;
				case 4:
					goto IL_75;
				case 5:
					if (A_1 == 1U)
					{
						num = 8;
						continue;
					}
					goto IL_15A;
				case 6:
					goto IL_F5;
				case 7:
					if (A_0.Length % 2 != 0)
					{
						num = 2;
						continue;
					}
					goto IL_1A6;
				case 8:
					num = 11;
					continue;
				case 10:
					num = 7;
					continue;
				case 11:
					if ((long)A_0.Length >= 56L)
					{
						num = 1;
						continue;
					}
					return array;
				case 12:
					goto IL_75;
				}
				if (!string.IsNullOrEmpty(A_0))
				{
					if (true)
					{
					}
					num = 10;
					continue;
				}
				goto IL_1A6;
				IL_75:
				num = 0;
				continue;
				IL_1A6:
				array = null;
				text = string.Empty;
				num = 5;
			}
			IL_F5:
			return array;
			IL_11F:
			global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(2388U, "Secure", "ExtractSalt", global::System.Environment.StackTrace.ToString());
			throw ex;
			IL_15A:
			global::custom_exception.CCustomException ex2 = new global::custom_exception.CCustomException(2908U, "Secure", "ExtractSalt", global::System.Environment.StackTrace.ToString());
			throw ex2;
		}
		}
	}

	// Token: 0x06000016 RID: 22 RVA: 0x000053C4 File Offset: 0x000043C4
	private static void a(ref byte[] A_0, global::System.Text.Encoding A_1)
	{
		try
		{
			if (true)
			{
			}
			string text = A_1.GetString(A_0);
			string text2 = text;
			char[] trimChars = new char[1];
			text = text2.TrimEnd(trimChars);
			A_0 = A_1.GetBytes(text);
		}
		catch (global::System.Exception ex)
		{
			if (global::custom_exception.CCustomException.CheckErrorIDExsists(ex))
			{
				goto IL_60;
			}
			IL_34:
			ex.Source = 2390U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex.Source;
			IL_60:
			switch ((1 == 1) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_34;
			default:
				if (false)
				{
				}
				global::custom_exception.CCustomException.Rethrow(ex);
				break;
			}
		}
	}

	// Token: 0x06000017 RID: 23 RVA: 0x00005470 File Offset: 0x00004470
	private static void a(global::d.c A_0, out string A_1, out string A_2)
	{
		if (A_0 == global::d.c.e)
		{
			for (;;)
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
					goto IL_31;
				}
			}
			IL_31:
			if (false)
			{
			}
			A_1 = global::d.z[(int)((global::System.UIntPtr)1)];
			A_2 = global::d.aa[(int)((global::System.UIntPtr)1)];
			return;
		}
		A_1 = global::d.z[(int)((global::System.UIntPtr)A_0)];
		A_2 = global::d.aa[(int)((global::System.UIntPtr)A_0)];
	}

	// Token: 0x06000019 RID: 25 RVA: 0x000054F4 File Offset: 0x000044F4
	// Note: this type is marked as 'beforefieldinit'.
	static d()
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
		global::d.z = new string[]
		{
			"RmFAUjxmbWpLNmkqUUVWfUhoQ1Usd1BOP0ZpLVg7USQ",
			"P1Ixd3swKE54MzUwOXhwWHtEVjM0biNLY1lNKzNRdnI",
			"MntwRDhWSDxHM0Eod0YlWz5ddTxZemlVUz4zbmprOGY"
		};
		global::d.aa = new string[]
		{
			"czp8KVtQfVU/bj9BbVBnIw",
			"Qlg3VSxAJW5dOjM5cHJIMw",
			"QTlhOFZ9cnY1JTE1a1Y2RQ"
		};
		global::d.ab = new string[]
		{
			"mototrbocps",
			"predefined"
		};
		global::d.ac = new string[]
		{
			"enE3biVqPUx8KnA5M3lvUQ",
			"KlIkejNiMl8tJSN0RGtjMQ"
		};
		global::d.ad = new string[]
		{
			"<RSAKeyValue><Modulus>5AaKT6Hvh9+QrPWr5wugcqFjZWe54yW4/2sn6KAHKIrvvpD7J2x+elfDTry9DEx0U5dplG0SAtMNlXNV4PXU72Ze/yoeD/gfsGBGlmhpVCxkd0WvfSnSl5xe/WcCVJnyrjIQjRI47Aok7H3tjtshvq/LLKUtWxpxy4iGupbtv20=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>",
			"<RSAKeyValue><Modulus>qZzUh3GihbzdI7wJxcIzvLX7X/7sTUSgjnmByopoISoAyFz+5rWpat+vGXswVaUAWK6htcWW2iGdDlyERK/U5jme2IB91CFjk9bSsmVx5RF3oTzNmxAh/cQ7qAwEi/3ffu+SzFSaZlZJ+1kKSwoM/qvVPXQjaYmu1F4YYD1k430=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>"
		};
	}

	// Token: 0x04000003 RID: 3
	private const int a = 0;

	// Token: 0x04000004 RID: 4
	public const int b = 3;

	// Token: 0x04000005 RID: 5
	private const int c = 2;

	// Token: 0x04000006 RID: 6
	private const int d = 1024;

	// Token: 0x04000007 RID: 7
	public const byte e = 239;

	// Token: 0x04000008 RID: 8
	public const byte f = 187;

	// Token: 0x04000009 RID: 9
	public const byte g = 191;

	// Token: 0x0400000A RID: 10
	private const byte h = 254;

	// Token: 0x0400000B RID: 11
	private const byte i = 255;

	// Token: 0x0400000C RID: 12
	private const byte j = 255;

	// Token: 0x0400000D RID: 13
	private const byte k = 254;

	// Token: 0x0400000E RID: 14
	private const string l = "|";

	// Token: 0x0400000F RID: 15
	private const string m = "Secure";

	// Token: 0x04000010 RID: 16
	private const string n = ", ";

	// Token: 0x04000011 RID: 17
	private const char o = '\0';

	// Token: 0x04000012 RID: 18
	private const string p = "<SIGNATURE>";

	// Token: 0x04000013 RID: 19
	private const string q = "</SIGNATURE>";

	// Token: 0x04000014 RID: 20
	private const string r = "<VERSION>";

	// Token: 0x04000015 RID: 21
	private const string s = "</VERSION>";

	// Token: 0x04000016 RID: 22
	private const string t = "1.0";

	// Token: 0x04000017 RID: 23
	private const string u = "<DIGEST>";

	// Token: 0x04000018 RID: 24
	private const string v = "</DIGEST>";

	// Token: 0x04000019 RID: 25
	public const uint w = 4U;

	// Token: 0x0400001A RID: 26
	public const uint x = 1U;

	// Token: 0x0400001B RID: 27
	public const uint y = 24U;

	// Token: 0x0400001C RID: 28
	private static string[] z;

	// Token: 0x0400001D RID: 29
	private static string[] aa;

	// Token: 0x0400001E RID: 30
	private static string[] ab;

	// Token: 0x0400001F RID: 31
	private static string[] ac;

	// Token: 0x04000020 RID: 32
	private static string[] ad;

	// Token: 0x02000010 RID: 16
	public enum c
	{
		// Token: 0x040000EF RID: 239
		a = -1,
		// Token: 0x040000F0 RID: 240
		b,
		// Token: 0x040000F1 RID: 241
		c,
		// Token: 0x040000F2 RID: 242
		d,
		// Token: 0x040000F3 RID: 243
		e = 25
	}

	// Token: 0x02000011 RID: 17
	public enum a
	{
		// Token: 0x040000F5 RID: 245
		a,
		// Token: 0x040000F6 RID: 246
		b
	}

	// Token: 0x02000012 RID: 18
	public enum b
	{
		// Token: 0x040000F8 RID: 248
		a,
		// Token: 0x040000F9 RID: 249
		b,
		// Token: 0x040000FA RID: 250
		c
	}
}
