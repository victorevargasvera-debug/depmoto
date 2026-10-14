using System;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using custom_exception;

// Token: 0x02000003 RID: 3
internal class j
{
	// Token: 0x06000004 RID: 4 RVA: 0x0000211C File Offset: 0x0000111C
	public static void a(string A_0, global::j.a A_1, ref string A_2)
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
					int num3 = 6;
					for (;;)
					{
						global::System.Security.Cryptography.RSACryptoServiceProvider rsacryptoServiceProvider;
						byte[] rgbHash;
						byte[] array;
						global::System.Security.Cryptography.SHA1Managed sha1Managed;
						string str;
						switch (num3)
						{
						case 0:
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
								num3 = 1;
								for (;;)
								{
									switch (num3)
									{
									case 0:
										((global::System.IDisposable)rsacryptoServiceProvider).Dispose();
										num3 = 2;
										continue;
									case 2:
										goto IL_115;
									}
									if (rsacryptoServiceProvider == null)
									{
										break;
									}
									num3 = 0;
								}
								IL_115:;
							}
							goto IL_118;
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
						case 1:
							try
							{
								for (;;)
								{
									global::System.IO.FileStream fileStream;
									int num4 = (int)fileStream.Length;
									array = new byte[num4];
									int num5 = 0;
									num3 = 1;
									for (;;)
									{
										switch (num3)
										{
										case 0:
											num3 = 3;
											continue;
										case 1:
											goto IL_251;
										case 2:
											goto IL_251;
										case 3:
											goto IL_287;
										case 4:
										{
											int num6;
											if ((num6 = fileStream.Read(array, num5, num4 - num5)) <= 0)
											{
												num3 = 0;
												continue;
											}
											num5 += num6;
											num3 = 2;
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
								num3 = 2;
								for (;;)
								{
									global::System.IO.FileStream fileStream;
									switch (num3)
									{
									case 0:
										((global::System.IDisposable)fileStream).Dispose();
										num3 = 1;
										continue;
									case 1:
										goto IL_2C9;
									}
									if (fileStream == null)
									{
										break;
									}
									num3 = 0;
								}
								IL_2C9:;
							}
							goto IL_2CC;
						case 2:
							goto IL_2CC;
						case 3:
							goto IL_36D;
						case 4:
							if (num2 != -1)
							{
								num3 = 5;
								continue;
							}
							goto IL_6E;
						case 5:
							goto IL_2EB;
						case 6:
							if (num != -1)
							{
								num3 = 2;
								continue;
							}
							goto IL_6E;
						case 7:
						{
							try
							{
								global::System.Text.UnicodeEncoding unicodeEncoding = new global::System.Text.UnicodeEncoding();
								byte[] bytes = unicodeEncoding.GetBytes(A_2);
								rgbHash = sha1Managed.ComputeHash(bytes);
								goto IL_139;
							}
							finally
							{
								num3 = 2;
								for (;;)
								{
									switch (num3)
									{
									case 0:
										switch ((1 == 1) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_1A7;
										default:
											goto IL_1CD;
										}
										break;
									case 1:
										goto IL_1A7;
									}
									if (sha1Managed != null)
									{
										num3 = 1;
										continue;
									}
									goto IL_1D5;
									IL_1A7:
									((global::System.IDisposable)sha1Managed).Dispose();
									num3 = 0;
								}
								IL_1CD:
								if (false)
								{
								}
								IL_1D5:;
							}
							goto IL_1D6;
							IL_139:
							global::System.IO.FileStream fileStream = new global::System.IO.FileStream(A_0 + str, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read, global::System.IO.FileShare.Read);
							num3 = 1;
							continue;
						}
						}
						break;
						IL_6E:
						str = global::j.ab[(int)((global::System.UIntPtr)A_1)];
						string text6 = global::j.ac[(int)((global::System.UIntPtr)A_1)];
						byte[] bytes2 = global::System.Convert.FromBase64String(text6 + "==");
						text6 = global::System.Text.Encoding.ASCII.GetString(bytes2);
						rgbHash = null;
						sha1Managed = new global::System.Security.Cryptography.SHA1Managed();
						num3 = 7;
						continue;
						IL_1D6:
						global::System.Security.Cryptography.X509Certificates.X509Certificate2 x509Certificate = new global::System.Security.Cryptography.X509Certificates.X509Certificate2(array, text6, global::System.Security.Cryptography.X509Certificates.X509KeyStorageFlags.MachineKeySet);
						rsacryptoServiceProvider = (global::System.Security.Cryptography.RSACryptoServiceProvider)x509Certificate.PrivateKey;
						num3 = 0;
						continue;
						IL_2CC:
						num3 = 4;
					}
				}
				IL_118:
				global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(1838U, "Secure", "ApplySignature", global::System.Environment.StackTrace.ToString());
				throw ex;
				IL_2EB:
				goto IL_118;
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
	public static global::j.c a(global::j.a A_0, ref string A_1)
	{
		switch (0)
		{
		default:
		{
			global::j.c result = global::j.c.b;
			try
			{
				for (;;)
				{
					int num = A_1.IndexOf("<SIGNATURE>", global::System.StringComparison.Ordinal);
					int num2 = A_1.IndexOf("</SIGNATURE>", global::System.StringComparison.Ordinal);
					int num3 = 4;
					for (;;)
					{
						switch (num3)
						{
						case 0:
						{
							int num4;
							byte[] array;
							if (num4 >= array.Length)
							{
								num3 = 3;
								continue;
							}
							string text;
							array[num4] = global::System.Convert.ToByte(text.Substring(num4 * 2, 2), 16);
							num4++;
							num3 = 8;
							continue;
						}
						case 1:
							if (num2 != -1)
							{
								num3 = 10;
								continue;
							}
							goto IL_342;
						case 2:
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
								num3 = 0;
								for (;;)
								{
									global::System.Security.Cryptography.SHA1Managed sha1Managed;
									switch (num3)
									{
									case 1:
										((global::System.IDisposable)sha1Managed).Dispose();
										num3 = 2;
										continue;
									case 2:
										goto IL_31B;
									}
									if (sha1Managed == null)
									{
										break;
									}
									num3 = 1;
								}
								IL_31B:;
							}
							string text;
							byte[] array = new byte[text.Length / 2];
							int num4 = 0;
							num3 = 9;
							continue;
						}
						case 3:
						{
							global::System.Security.Cryptography.RSACryptoServiceProvider rsacryptoServiceProvider = new global::System.Security.Cryptography.RSACryptoServiceProvider();
							num3 = 11;
							continue;
						}
						case 4:
							if (num != -1)
							{
								num3 = 5;
								continue;
							}
							goto IL_342;
						case 5:
							num3 = 1;
							continue;
						case 6:
							goto IL_12E;
						case 7:
						{
							string xmlString;
							if (xmlString != global::j.ad[(int)((global::System.UIntPtr)A_0)])
							{
								num3 = 6;
								continue;
							}
							A_1 = A_1.Remove(num);
							byte[] rgbHash = null;
							global::System.Security.Cryptography.SHA1Managed sha1Managed = new global::System.Security.Cryptography.SHA1Managed();
							num3 = 2;
							continue;
						}
						case 8:
							goto IL_251;
						case 9:
							goto IL_251;
						case 10:
						{
							int num5 = A_1.IndexOf("<DIGEST>", global::System.StringComparison.Ordinal);
							int num6 = A_1.IndexOf("</DIGEST>", global::System.StringComparison.Ordinal);
							int num7 = num5 + "<DIGEST>".Length;
							int length = num6 - num7;
							string text = A_1.Substring(num7, length);
							num7 = num6 + "</DIGEST>".Length;
							length = num2 - num7;
							string xmlString = A_1.Substring(num7, length);
							num3 = 7;
							continue;
						}
						case 11:
							try
							{
								for (;;)
								{
									global::System.Security.Cryptography.RSACryptoServiceProvider rsacryptoServiceProvider;
									string xmlString;
									rsacryptoServiceProvider.FromXmlString(xmlString);
									num3 = 0;
									for (;;)
									{
										switch (num3)
										{
										case 0:
										{
											byte[] array;
											byte[] rgbHash;
											if (rsacryptoServiceProvider.VerifyHash(rgbHash, null, array))
											{
												num3 = 3;
												continue;
											}
											result = global::j.c.a;
											num3 = 2;
											continue;
										}
										case 1:
											goto IL_200;
										case 2:
											switch ((1 == 1) ? 1 : 0)
											{
											case 0:
											case 2:
												goto IL_200;
											default:
												if (false)
												{
												}
												goto IL_200;
											}
											break;
										case 3:
											result = global::j.c.c;
											num3 = 1;
											continue;
										case 4:
											goto IL_20C;
										}
										break;
										IL_200:
										num3 = 4;
									}
								}
								IL_20C:
								goto IL_342;
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
										goto IL_24E;
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
								IL_24E:;
							}
							goto IL_251;
						case 12:
							goto IL_34E;
						}
						break;
						IL_251:
						num3 = 0;
						continue;
						IL_342:
						num3 = 12;
					}
				}
				IL_12E:
				global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(1836U, "Secure", "VerifySignature", global::System.Environment.StackTrace.ToString());
				throw ex;
				IL_34E:;
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

	// Token: 0x06000006 RID: 6 RVA: 0x00002988 File Offset: 0x00001988
	public static void b(string A_0, string A_1, bool A_2, global::j.b A_3)
	{
		try
		{
			switch (0)
			{
			default:
			{
				int num = 1;
				for (;;)
				{
					switch (num)
					{
					case 0:
						try
						{
							for (;;)
							{
								global::System.Security.Cryptography.RijndaelManaged rijndaelManaged;
								string str;
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
										try
										{
											fileStream2.Write(array2, 0, array2.Length);
											goto IL_1B4;
										}
										finally
										{
											num = 2;
											for (;;)
											{
												switch (num)
												{
												case 0:
													goto IL_125;
												case 1:
													((global::System.IDisposable)fileStream2).Dispose();
													num = 0;
													continue;
												}
												if (fileStream2 == null)
												{
													break;
												}
												num = 1;
											}
											IL_125:;
										}
										goto Block_7;
										IL_1B4:
										num = 1;
										continue;
									case 1:
										goto IL_1C0;
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
										num = 1;
										for (;;)
										{
											switch (num)
											{
											case 0:
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
											num = 0;
										}
										IL_185:;
									}
									global::j.a(array, ref array2, A_2, rijndaelManaged.CreateEncryptor());
									fileStream2 = new global::System.IO.FileStream(A_1, global::System.IO.FileMode.Create, global::System.IO.FileAccess.Write);
									num = 0;
								}
							}
							IL_1C0:
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
									((global::System.IDisposable)rijndaelManaged).Dispose();
									num = 1;
									continue;
								case 1:
									switch ((1 == 1) ? 1 : 0)
									{
									case 0:
									case 2:
										continue;
									default:
										goto IL_218;
									}
									break;
								}
								if (rijndaelManaged == null)
								{
									goto IL_220;
								}
								num = 0;
							}
							IL_218:
							if (false)
							{
							}
							IL_220:;
						}
						goto IL_221;
						IL_2B0:
						num = 3;
						continue;
					case 2:
						if (string.IsNullOrEmpty(A_1))
						{
							num = 5;
							continue;
						}
						num = 4;
						continue;
					case 3:
						goto IL_2BC;
					case 4:
					{
						if (!global::System.IO.File.Exists(global::System.IO.Path.GetFullPath(A_0)))
						{
							num = 7;
							continue;
						}
						string str;
						string str2;
						global::j.a(A_3, out str, out str2);
						global::System.Security.Cryptography.RijndaelManaged rijndaelManaged = new global::System.Security.Cryptography.RijndaelManaged();
						num = 0;
						continue;
					}
					case 5:
						goto IL_241;
					case 6:
						goto IL_221;
					case 7:
						goto IL_2AE;
					}
					if (!string.IsNullOrEmpty(A_0))
					{
						num = 6;
						continue;
					}
					break;
					IL_221:
					num = 2;
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

	// Token: 0x06000007 RID: 7 RVA: 0x00002D28 File Offset: 0x00001D28
	public static void b(byte[] A_0, ref byte[] A_1, bool A_2, global::j.b A_3)
	{
		try
		{
			switch (0)
			{
			default:
			{
				string str;
				string str2;
				global::j.a(A_3, out str, out str2);
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
					global::j.a(array, ref A_1, A_2, rijndaelManaged.CreateEncryptor());
				}
				finally
				{
					int num = 1;
					for (;;)
					{
						switch (num)
						{
						case 0:
							goto IL_C6;
						case 2:
							((global::System.IDisposable)rijndaelManaged).Dispose();
							num = 0;
							continue;
						}
						if (rijndaelManaged == null)
						{
							break;
						}
						num = 2;
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
			IL_D9:
			if (true)
			{
			}
			ex.Source = 2393U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex.Source;
			IL_110:
			switch ((1 == 1) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_D9;
			default:
				if (false)
				{
				}
				global::custom_exception.CCustomException.Rethrow(ex);
				break;
			}
		}
	}

	// Token: 0x06000008 RID: 8 RVA: 0x00002E9C File Offset: 0x00001E9C
	public static void b(string A_0, ref string A_1, bool A_2, global::j.b A_3)
	{
		try
		{
			for (;;)
			{
				switch (0)
				{
				default:
				{
					int num = 1;
					for (;;)
					{
						global::System.Security.Cryptography.RijndaelManaged rijndaelManaged;
						string str;
						string str2;
						switch (num)
						{
						case 0:
							goto IL_6D;
						case 2:
							if (!global::System.IO.File.Exists(global::System.IO.Path.GetFullPath(A_0)))
							{
								num = 0;
								continue;
							}
							goto IL_1B9;
						case 3:
							goto IL_49;
						case 4:
							goto IL_208;
						case 5:
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
											goto IL_152;
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
									IL_152:;
								}
								global::j.a(array, ref bytes, A_2, rijndaelManaged.CreateEncryptor());
								A_1 = global::System.Text.Encoding.UTF8.GetString(bytes);
								goto IL_1FC;
							}
							finally
							{
								num = 0;
								for (;;)
								{
									switch (num)
									{
									case 1:
										goto IL_1B6;
									case 2:
										((global::System.IDisposable)rijndaelManaged).Dispose();
										num = 1;
										continue;
									}
									if (rijndaelManaged == null)
									{
										break;
									}
									num = 2;
								}
								IL_1B6:;
							}
							goto IL_1B9;
							IL_1FC:
							num = 4;
							continue;
						}
						if (string.IsNullOrEmpty(A_0))
						{
							num = 3;
							continue;
						}
						num = 2;
						continue;
						IL_1B9:
						global::j.a(A_3, out str, out str2);
						rijndaelManaged = new global::System.Security.Cryptography.RijndaelManaged();
						num = 5;
					}
					IL_208:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_21E;
					}
					break;
				}
				}
			}
			IL_49:
			global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(2388U, "Secure", "EncryptFile", global::System.Environment.StackTrace.ToString());
			throw ex;
			IL_6D:
			global::custom_exception.CCustomException ex2 = new global::custom_exception.CCustomException(2392U, "Secure", "EncryptFile", global::System.Environment.StackTrace.ToString());
			throw ex2;
			IL_21E:
			if (false)
			{
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
				ex3.Source = 2393U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex3.Source;
			}
			global::custom_exception.CCustomException.Rethrow(ex3);
		}
		if (true)
		{
		}
	}

	// Token: 0x06000009 RID: 9 RVA: 0x0000318C File Offset: 0x0000218C
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
						int num;
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							IL_160:
							goto IL_ED;
						default:
							if (false)
							{
							}
							num = 0;
							break;
						}
						IL_20:
						switch (num)
						{
						case 0:
							try
							{
								array = new byte[fileStream.Length];
								fileStream.Read(array, 0, array.Length);
								goto IL_13B;
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
										goto IL_EA;
									}
									if (fileStream == null)
									{
										break;
									}
									num = 1;
								}
								IL_EA:;
							}
							goto Block_4;
						case 1:
							goto IL_16E;
						case 2:
							goto IL_160;
						}
						continue;
						IL_13B:
						global::j.a(array, ref array2, A_2, tripleDESCryptoServiceProvider.CreateEncryptor());
						global::System.IO.FileStream fileStream2 = new global::System.IO.FileStream(A_1, global::System.IO.FileMode.Create, global::System.IO.FileAccess.Write);
						num = 2;
						goto IL_20;
						Block_4:
						try
						{
							IL_ED:
							fileStream2.Write(array2, 0, array2.Length);
							goto IL_162;
						}
						finally
						{
							num = 0;
							for (;;)
							{
								switch (num)
								{
								case 1:
									goto IL_138;
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
							IL_138:;
						}
						goto IL_13B;
						IL_162:
						num = 1;
						goto IL_20;
					}
					IL_16E:;
				}
				finally
				{
					int num = 1;
					for (;;)
					{
						switch (num)
						{
						case 0:
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
						num = 0;
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

	// Token: 0x0600000A RID: 10 RVA: 0x00003418 File Offset: 0x00002418
	public static void a(byte[] A_0, ref byte[] A_1)
	{
		switch (0)
		{
		default:
			for (;;)
			{
				global::System.Security.Cryptography.TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new global::System.Security.Cryptography.TripleDESCryptoServiceProvider();
				try
				{
					tripleDESCryptoServiceProvider.Key = global::System.Text.Encoding.ASCII.GetBytes("HAVNCPSLTDTUNERAIRTRACER");
					tripleDESCryptoServiceProvider.IV = global::System.Text.Encoding.ASCII.GetBytes("VEDKDJSP");
					try
					{
						int num = 7;
						for (;;)
						{
							switch (num)
							{
							case 0:
								goto IL_240;
							case 1:
								if (A_1 != null)
								{
									num = 3;
									continue;
								}
								goto IL_152;
							case 2:
								goto IL_251;
							case 3:
								num = 5;
								continue;
							case 4:
								try
								{
									num = 4;
									for (;;)
									{
										switch (num)
										{
										case 0:
											goto IL_10D;
										case 1:
										{
											long num2;
											long num3;
											if (num2 >= num3)
											{
												num = 2;
												continue;
											}
											global::System.IO.MemoryStream memoryStream;
											byte[] buffer;
											int num4 = memoryStream.Read(buffer, 0, 1024);
											global::System.Security.Cryptography.CryptoStream cryptoStream;
											cryptoStream.Write(buffer, 0, num4);
											num2 += (long)num4;
											num = 3;
											continue;
										}
										case 2:
										{
											global::System.Security.Cryptography.CryptoStream cryptoStream;
											cryptoStream.FlushFinalBlock();
											global::System.IO.MemoryStream memoryStream2;
											A_1 = memoryStream2.ToArray();
											num = 0;
											continue;
										}
										}
										IL_DB:
										num = 1;
										continue;
										goto IL_DB;
									}
									IL_10D:
									goto IL_245;
								}
								finally
								{
									num = 2;
									for (;;)
									{
										global::System.Security.Cryptography.CryptoStream cryptoStream;
										switch (num)
										{
										case 0:
											goto IL_14F;
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
									IL_14F:;
								}
								goto IL_152;
								IL_245:
								num = 2;
								continue;
							case 5:
							{
								if (tripleDESCryptoServiceProvider == null)
								{
									num = 0;
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
								num = 4;
								continue;
							}
							case 6:
								if (true)
								{
								}
								num = 1;
								continue;
							}
							if (A_0 == null)
							{
								break;
							}
							num = 6;
						}
						IL_152:
						global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(2388U, "Secure", ", EncryptFile", global::System.Environment.StackTrace.ToString());
						throw ex;
						IL_240:
						goto IL_152;
						IL_251:;
					}
					catch (global::custom_exception.CCustomException ex2)
					{
						throw ex2;
					}
					catch (global::System.Exception ex3)
					{
						if (!global::custom_exception.CCustomException.CheckErrorIDExsists(ex3))
						{
							ex3.Source = 2389U.ToString() + "|" + ex3.Source;
						}
						global::custom_exception.CCustomException.Rethrow(ex3);
					}
				}
				finally
				{
					int num = 1;
					for (;;)
					{
						switch (num)
						{
						case 0:
							goto IL_2D3;
						case 2:
							((global::System.IDisposable)tripleDESCryptoServiceProvider).Dispose();
							num = 0;
							continue;
						}
						if (tripleDESCryptoServiceProvider == null)
						{
							break;
						}
						num = 2;
					}
					IL_2D3:;
				}
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_2F6;
				}
			}
			IL_2F6:
			if (false)
			{
			}
			return;
		}
	}

	// Token: 0x0600000B RID: 11 RVA: 0x00003788 File Offset: 0x00002788
	public static void a(string A_0, string A_1, bool A_2, global::j.b A_3)
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
						goto IL_227;
					case 1:
						goto IL_29C;
					case 2:
						try
						{
							for (;;)
							{
								global::System.Security.Cryptography.RijndaelManaged rijndaelManaged;
								string str;
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
										num = 1;
										for (;;)
										{
											switch (num)
											{
											case 0:
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
											num = 0;
										}
										IL_185:;
									}
									global::j.a(array, ref array2, A_2, A_3, rijndaelManaged.CreateDecryptor());
									fileStream2 = new global::System.IO.FileStream(A_1, global::System.IO.FileMode.OpenOrCreate, global::System.IO.FileAccess.Write);
									num = 1;
								}
							}
							IL_1C2:
							goto IL_29E;
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
									goto IL_204;
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
							IL_204:;
						}
						goto IL_207;
						IL_29E:
						num = 4;
						continue;
					case 3:
						if (string.IsNullOrEmpty(A_1))
						{
							num = 0;
							continue;
						}
						num = 5;
						continue;
					case 4:
						goto IL_2AA;
					case 5:
					{
						if (true)
						{
						}
						if (!global::System.IO.File.Exists(global::System.IO.Path.GetFullPath(A_0)))
						{
							num = 1;
							continue;
						}
						string str;
						string str2;
						global::j.a(A_3, out str, out str2);
						global::System.Security.Cryptography.RijndaelManaged rijndaelManaged = new global::System.Security.Cryptography.RijndaelManaged();
						num = 2;
						continue;
					}
					case 6:
						goto IL_207;
					}
					if (!string.IsNullOrEmpty(A_0))
					{
						num = 6;
						continue;
					}
					break;
					IL_207:
					num = 3;
				}
				IL_56:
				global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(2388U, "Secure", "DecryptFile", global::System.Environment.StackTrace.ToString());
				throw ex;
				IL_227:
				goto IL_56;
				IL_29C:
				global::custom_exception.CCustomException ex2 = new global::custom_exception.CCustomException(2392U, "Secure", "DecryptFile", global::System.Environment.StackTrace.ToString());
				throw ex2;
				IL_2AA:
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
			IL_2BC:
			ex3.Source = 2394U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex3.Source;
			IL_2E9:
			switch ((1 == 1) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_2BC;
			default:
				if (false)
				{
				}
				global::custom_exception.CCustomException.Rethrow(ex3);
				break;
			}
		}
	}

	// Token: 0x0600000C RID: 12 RVA: 0x00003B2C File Offset: 0x00002B2C
	public static void a(byte[] A_0, ref byte[] A_1, bool A_2, global::j.b A_3)
	{
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
				switch (0)
				{
				}
				break;
			}
			string str;
			string str2;
			global::j.a(A_3, out str, out str2);
			global::System.Security.Cryptography.RijndaelManaged rijndaelManaged = new global::System.Security.Cryptography.RijndaelManaged();
			try
			{
				rijndaelManaged.Key = global::System.Convert.FromBase64String(str + "=");
				rijndaelManaged.IV = global::System.Convert.FromBase64String(str2 + "==");
				global::j.a(A_0, ref A_1, A_2, A_3, rijndaelManaged.CreateDecryptor());
			}
			finally
			{
				int num = 0;
				for (;;)
				{
					switch (num)
					{
					case 1:
						goto IL_B5;
					case 2:
						((global::System.IDisposable)rijndaelManaged).Dispose();
						num = 1;
						continue;
					}
					if (rijndaelManaged == null)
					{
						break;
					}
					num = 2;
				}
				IL_B5:;
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
				if (true)
				{
				}
				ex.Source = 2394U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex.Source;
			}
			global::custom_exception.CCustomException.Rethrow(ex);
		}
	}

	// Token: 0x0600000D RID: 13 RVA: 0x00003C70 File Offset: 0x00002C70
	public static void a(string A_0, ref string A_1, bool A_2, global::j.b A_3)
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
						goto IL_6D;
					case 2:
						goto IL_202;
					case 3:
						goto IL_49;
					case 4:
						if (!global::System.IO.File.Exists(global::System.IO.Path.GetFullPath(A_0)))
						{
							num = 1;
							continue;
						}
						goto IL_1B3;
					case 5:
						try
						{
							rijndaelManaged.Key = global::System.Convert.FromBase64String(str + "=");
							rijndaelManaged.IV = global::System.Convert.FromBase64String(str2 + "==");
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
										goto IL_130;
									}
									if (fileStream == null)
									{
										break;
									}
									num = 0;
								}
								IL_130:;
							}
							global::System.Text.Encoding encoding = global::j.a(array, ref bytes, A_2, A_3, rijndaelManaged.CreateDecryptor());
							A_1 = encoding.GetString(bytes);
							goto IL_1F6;
						}
						finally
						{
							num = 1;
							for (;;)
							{
								switch (num)
								{
								case 0:
									switch ((1 == 1) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_1B2;
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
									goto IL_1B0;
								}
								if (rijndaelManaged == null)
								{
									break;
								}
								num = 0;
							}
							IL_1B0:
							IL_1B2:;
						}
						goto IL_1B3;
						IL_1F6:
						num = 2;
						continue;
					}
					if (string.IsNullOrEmpty(A_0))
					{
						num = 3;
						continue;
					}
					num = 4;
					continue;
					IL_1B3:
					global::j.a(A_3, out str, out str2);
					rijndaelManaged = new global::System.Security.Cryptography.RijndaelManaged();
					num = 5;
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
				ex3.Source = 2394U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex3.Source;
			}
			if (true)
			{
			}
			global::custom_exception.CCustomException.Rethrow(ex3);
		}
	}

	// Token: 0x0600000E RID: 14 RVA: 0x00003F40 File Offset: 0x00002F40
	public static void a(string A_0, string A_1, bool A_2)
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
							num = 1;
							continue;
						}
						if (true)
						{
						}
						num = 3;
						continue;
					case 1:
						goto IL_237;
					case 3:
					{
						if (!global::System.IO.File.Exists(global::System.IO.Path.GetFullPath(A_0)))
						{
							num = 7;
							continue;
						}
						global::System.Security.Cryptography.TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new global::System.Security.Cryptography.TripleDESCryptoServiceProvider();
						num = 6;
						continue;
					}
					case 4:
						goto IL_217;
					case 5:
						goto IL_2AF;
					case 6:
						try
						{
							for (;;)
							{
								global::System.Security.Cryptography.TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider;
								tripleDESCryptoServiceProvider.Key = global::System.Text.Encoding.ASCII.GetBytes("HAVNCPSLTDTUNERAIRTRACER");
								tripleDESCryptoServiceProvider.IV = global::System.Text.Encoding.ASCII.GetBytes("VEDKDJSP");
								byte[] array = null;
								byte[] array2 = null;
								global::System.IO.FileStream fileStream = new global::System.IO.FileStream(A_0, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read);
								num = 0;
								for (;;)
								{
									global::System.IO.FileStream fileStream2;
									switch (num)
									{
									case 0:
										switch ((1 == 1) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_1C8;
										default:
											if (false)
											{
											}
											goto IL_13F;
										}
										break;
									case 1:
										goto IL_1D4;
									case 2:
										try
										{
											fileStream2.Write(array2, 0, array2.Length);
											goto IL_1C8;
										}
										finally
										{
											num = 0;
											for (;;)
											{
												switch (num)
												{
												case 1:
													goto IL_13C;
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
											IL_13C:;
										}
										goto Block_7;
									}
									break;
									Block_7:
									try
									{
										IL_13F:
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
												((global::System.IDisposable)fileStream).Dispose();
												num = 1;
												continue;
											case 1:
												goto IL_199;
											}
											if (fileStream == null)
											{
												break;
											}
											num = 0;
										}
										IL_199:;
									}
									global::j.a(array, ref array2, A_2, global::j.b.a, tripleDESCryptoServiceProvider.CreateDecryptor());
									fileStream2 = new global::System.IO.FileStream(A_1, global::System.IO.FileMode.OpenOrCreate, global::System.IO.FileAccess.Write);
									num = 2;
									continue;
									IL_1C8:
									num = 1;
								}
							}
							IL_1D4:
							goto IL_2A3;
						}
						finally
						{
							num = 0;
							for (;;)
							{
								global::System.Security.Cryptography.TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider;
								switch (num)
								{
								case 1:
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
								num = 1;
							}
							IL_214:;
						}
						goto IL_217;
						IL_2A3:
						num = 5;
						continue;
					case 7:
						goto IL_2A1;
					}
					if (!string.IsNullOrEmpty(A_0))
					{
						num = 4;
						continue;
					}
					break;
					IL_217:
					num = 0;
				}
				IL_56:
				global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(2388U, "Secure", "DecryptFile", global::System.Environment.StackTrace.ToString());
				throw ex;
				IL_237:
				goto IL_56;
				IL_2A1:
				global::custom_exception.CCustomException ex2 = new global::custom_exception.CCustomException(2392U, "Secure", "DecryptFile", global::System.Environment.StackTrace.ToString());
				throw ex2;
				IL_2AF:
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
			global::custom_exception.CCustomException.Rethrow(ex3);
		}
	}

	// Token: 0x0600000F RID: 15 RVA: 0x000042CC File Offset: 0x000032CC
	public static void a(byte[] A_0, ref byte[] A_1, bool A_2)
	{
		try
		{
			global::System.Security.Cryptography.TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new global::System.Security.Cryptography.TripleDESCryptoServiceProvider();
			try
			{
				tripleDESCryptoServiceProvider.Key = global::System.Text.Encoding.ASCII.GetBytes("HAVNCPSLTDTUNERAIRTRACER");
				tripleDESCryptoServiceProvider.IV = global::System.Text.Encoding.ASCII.GetBytes("VEDKDJSP");
				global::j.a(A_0, ref A_1, A_2, global::j.b.a, tripleDESCryptoServiceProvider.CreateDecryptor());
			}
			finally
			{
				int num = 1;
				for (;;)
				{
					switch (num)
					{
					case 0:
						goto IL_7B;
					case 2:
						((global::System.IDisposable)tripleDESCryptoServiceProvider).Dispose();
						num = 0;
						continue;
					}
					if (tripleDESCryptoServiceProvider == null)
					{
						break;
					}
					num = 2;
				}
				IL_7B:;
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
				goto IL_B8;
			}
			IL_8E:
			ex.Source = 2394U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex.Source;
			IL_B8:
			switch ((1 == 1) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_8E;
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

	// Token: 0x06000010 RID: 16 RVA: 0x000043F0 File Offset: 0x000033F0
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
						int num = 0;
						for (;;)
						{
							switch (num)
							{
							case 1:
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
							num = 1;
						}
						IL_A5:;
					}
					global::System.Text.Encoding encoding = global::j.a(array, ref bytes, A_2, global::j.b.a, tripleDESCryptoServiceProvider.CreateDecryptor());
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
			if (!global::custom_exception.CCustomException.CheckErrorIDExsists(ex))
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
					ex.Source = 2394U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex.Source;
					break;
				}
			}
			global::custom_exception.CCustomException.Rethrow(ex);
		}
		if (true)
		{
		}
	}

	// Token: 0x06000011 RID: 17 RVA: 0x000045DC File Offset: 0x000035DC
	private static void a(byte[] A_0, ref byte[] A_1, bool A_2, global::System.Security.Cryptography.ICryptoTransform A_3)
	{
		try
		{
			switch (0)
			{
			default:
			{
				int num = 3;
				for (;;)
				{
					global::System.IO.MemoryStream memoryStream;
					switch (num)
					{
					case 0:
						try
						{
							global::System.Security.Cryptography.CryptoStream cryptoStream = new global::System.Security.Cryptography.CryptoStream(memoryStream, A_3, global::System.Security.Cryptography.CryptoStreamMode.Write);
							try
							{
								cryptoStream.Write(A_0, 0, A_0.Length);
								cryptoStream.FlushFinalBlock();
							}
							finally
							{
								num = 0;
								for (;;)
								{
									switch (num)
									{
									case 1:
										goto IL_D4;
									case 2:
										((global::System.IDisposable)cryptoStream).Dispose();
										num = 1;
										continue;
									}
									if (cryptoStream == null)
									{
										break;
									}
									num = 2;
								}
								IL_D4:;
							}
							A_1 = memoryStream.ToArray();
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
									((global::System.IDisposable)memoryStream).Dispose();
									num = 1;
									continue;
								case 1:
									goto IL_11F;
								}
								if (memoryStream == null)
								{
									break;
								}
								num = 0;
							}
							IL_11F:;
						}
						goto IL_122;
						IL_253:
						num = 4;
						continue;
					case 1:
						try
						{
							global::System.IO.MemoryStream memoryStream2;
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
								global::System.IO.Compression.GZipStream gzipStream = new global::System.IO.Compression.GZipStream(memoryStream2, global::System.IO.Compression.CompressionMode.Compress, true);
								try
								{
									gzipStream.Write(A_0, 0, A_0.Length);
								}
								finally
								{
									num = 0;
									for (;;)
									{
										switch (num)
										{
										case 1:
											((global::System.IDisposable)gzipStream).Dispose();
											num = 2;
											continue;
										case 2:
											goto IL_1CE;
										}
										if (gzipStream == null)
										{
											break;
										}
										num = 1;
									}
									IL_1CE:;
								}
								break;
							}
							}
							A_0 = memoryStream2.ToArray();
							goto IL_148;
						}
						finally
						{
							num = 0;
							for (;;)
							{
								global::System.IO.MemoryStream memoryStream2;
								switch (num)
								{
								case 1:
									((global::System.IDisposable)memoryStream2).Dispose();
									num = 2;
									continue;
								case 2:
									goto IL_219;
								}
								if (memoryStream2 == null)
								{
									break;
								}
								num = 1;
							}
							IL_219:;
						}
						goto IL_21C;
					case 2:
						if (A_0.Length <= 0)
						{
							num = 6;
							continue;
						}
						goto IL_21C;
					case 4:
						goto IL_25F;
					case 5:
						if (A_2)
						{
							num = 7;
							continue;
						}
						goto IL_148;
					case 6:
						goto IL_143;
					case 7:
					{
						global::System.IO.MemoryStream memoryStream2 = new global::System.IO.MemoryStream();
						num = 1;
						continue;
					}
					case 8:
						goto IL_122;
					}
					if (A_0 != null)
					{
						num = 8;
						continue;
					}
					break;
					IL_122:
					num = 2;
					continue;
					IL_148:
					memoryStream = new global::System.IO.MemoryStream();
					num = 0;
					continue;
					IL_21C:
					num = 5;
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
			if (true)
			{
			}
			global::custom_exception.CCustomException.Rethrow(ex2);
		}
	}

	// Token: 0x06000012 RID: 18 RVA: 0x00004938 File Offset: 0x00003938
	private static global::System.Text.Encoding a(byte[] A_0, ref byte[] A_1, bool A_2, global::j.b A_3, global::System.Security.Cryptography.ICryptoTransform A_4)
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
				int num = 17;
				for (;;)
				{
					byte[] array;
					global::System.IO.MemoryStream memoryStream;
					byte b;
					switch (num)
					{
					case 0:
						goto IL_615;
					case 1:
						num = 16;
						continue;
					case 2:
						goto IL_B4;
					case 3:
						A_1 = new byte[array.Length - 2];
						global::System.Array.Copy(array, 2, A_1, 0, array.Length - 2);
						encoding = new global::System.Text.UnicodeEncoding();
						global::j.a(ref A_1, encoding);
						num = 26;
						continue;
					case 4:
						A_1 = new byte[array.Length - 3];
						global::System.Array.Copy(array, 3, A_1, 0, array.Length - 3);
						encoding = new global::System.Text.UTF8Encoding();
						global::j.a(ref A_1, encoding);
						num = 24;
						continue;
					case 5:
						goto IL_554;
					case 6:
						goto IL_318;
					case 7:
						goto IL_621;
					case 8:
						A_1 = new byte[array.Length - 2];
						global::System.Array.Copy(array, 2, A_1, 0, array.Length - 2);
						encoding = new global::System.Text.UnicodeEncoding();
						global::j.a(ref A_1, encoding);
						num = 0;
						continue;
					case 9:
						if (array[1].Equals(254))
						{
							num = 8;
							continue;
						}
						goto IL_DC;
					case 10:
						goto IL_615;
					case 11:
						encoding = global::System.Text.Encoding.GetEncoding(1252);
						num = 6;
						continue;
					case 12:
						if (array[2].Equals(191))
						{
							num = 4;
							continue;
						}
						goto IL_5B9;
					case 13:
						if (A_3 == global::j.b.e)
						{
							num = 11;
							continue;
						}
						encoding = new global::System.Text.UTF8Encoding();
						num = 20;
						continue;
					case 14:
						if (array[1].Equals(255))
						{
							num = 3;
							continue;
						}
						goto IL_B9;
					case 15:
						if (array[1].Equals(187))
						{
							num = 21;
							continue;
						}
						goto IL_5B9;
					case 16:
						goto IL_2DC;
					case 18:
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
								num = 0;
								for (;;)
								{
									switch (num)
									{
									case 1:
										goto IL_50E;
									case 2:
										((global::System.IDisposable)cryptoStream).Dispose();
										num = 1;
										continue;
									}
									if (cryptoStream == null)
									{
										break;
									}
									num = 2;
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
									memoryStream.Dispose();
									num = 2;
									continue;
								case 2:
									goto IL_551;
								}
								if (memoryStream == null)
								{
									break;
								}
								num = 1;
							}
							IL_551:;
						}
						goto IL_554;
						IL_362:
						num = 25;
						continue;
					case 19:
						switch (b)
						{
						case 254:
							num = 14;
							continue;
						case 255:
							num = 9;
							continue;
						default:
							num = 1;
							continue;
						}
						break;
					case 20:
						goto IL_318;
					case 21:
						num = 12;
						continue;
					case 22:
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
											num = 1;
											for (;;)
											{
												switch (num)
												{
												case 0:
													goto IL_1A9;
												case 1:
													goto IL_1A9;
												case 2:
												{
													int count;
													if ((count = gzipStream.Read(array2, 0, array2.Length)) <= 0)
													{
														num = 4;
														continue;
													}
													memoryStream2.Write(array2, 0, count);
													num = 0;
													continue;
												}
												case 3:
													goto IL_1F9;
												case 4:
													array = memoryStream2.ToArray();
													num = 3;
													continue;
												}
												break;
												IL_1A9:
												num = 2;
											}
										}
										IL_1F9:;
									}
									finally
									{
										num = 1;
										for (;;)
										{
											switch (num)
											{
											case 0:
												((global::System.IDisposable)memoryStream2).Dispose();
												num = 2;
												continue;
											case 2:
												goto IL_238;
											}
											if (memoryStream2 == null)
											{
												break;
											}
											num = 0;
										}
										IL_238:;
									}
								}
								finally
								{
									num = 0;
									for (;;)
									{
										switch (num)
										{
										case 1:
											((global::System.IDisposable)gzipStream).Dispose();
											num = 2;
											continue;
										case 2:
											goto IL_27A;
										}
										if (gzipStream == null)
										{
											break;
										}
										num = 1;
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
							num = 2;
							for (;;)
							{
								switch (num)
								{
								case 0:
									goto IL_2D9;
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
							IL_2D9:;
						}
						goto IL_2DC;
					case 23:
						if (b != 239)
						{
							num = 5;
							continue;
						}
						num = 15;
						continue;
					case 24:
						goto IL_615;
					case 25:
						if (A_2)
						{
							num = 22;
							continue;
						}
						goto IL_382;
					case 26:
						goto IL_615;
					}
					if (A_0 == null)
					{
						num = 2;
						continue;
					}
					array = new byte[A_0.Length];
					memoryStream = null;
					num = 18;
					continue;
					IL_2DC:
					A_1 = new byte[array.Length];
					global::System.Array.Copy(array, 0, A_1, 0, array.Length);
					num = 13;
					continue;
					IL_318:
					global::j.a(ref A_1, encoding);
					num = 10;
					continue;
					IL_382:
					b = array[0];
					num = 23;
					continue;
					IL_554:
					num = 19;
					continue;
					IL_615:
					num = 7;
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

	// Token: 0x06000013 RID: 19 RVA: 0x0000505C File Offset: 0x0000405C
	public static void a(string A_0, ref uint A_1, ref byte[] A_2)
	{
		if (true)
		{
		}
		int num = 2;
		for (;;)
		{
			switch (num)
			{
			case 0:
				if (A_0.Length % 2 != 0)
				{
					num = 1;
					continue;
				}
				goto IL_A0;
			case 1:
				goto IL_9E;
			case 3:
				num = 0;
				continue;
			}
			if (string.IsNullOrEmpty(A_0))
			{
				goto IL_A0;
			}
			switch ((1 == 1) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_60;
			default:
				if (false)
				{
				}
				num = 3;
				break;
			}
		}
		IL_60:
		global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(2388U, "Secure", "ExtractHashHeader", global::System.Environment.StackTrace.ToString());
		throw ex;
		IL_9E:
		goto IL_60;
		IL_A0:
		A_1 = global::j.a(A_0);
		A_2 = global::j.a(A_0, A_1);
	}

	// Token: 0x06000014 RID: 20 RVA: 0x0000511C File Offset: 0x0000411C
	private static uint a(string A_0)
	{
		int num = 3;
		for (;;)
		{
			switch (num)
			{
			case 0:
				num = 1;
				continue;
			case 1:
				if (A_0.Length % 2 != 0)
				{
					num = 2;
					continue;
				}
				goto IL_A0;
			case 2:
				goto IL_9E;
			}
			if (string.IsNullOrEmpty(A_0))
			{
				goto IL_A0;
			}
			switch ((1 == 1) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_58;
			default:
				if (false)
				{
				}
				num = 0;
				break;
			}
		}
		IL_58:
		if (true)
		{
		}
		global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(2388U, "Secure", "ExtractAlgorithmID", global::System.Environment.StackTrace.ToString());
		throw ex;
		IL_9E:
		goto IL_58;
		IL_A0:
		string text = A_0.Substring(0, 8);
		return uint.Parse(text, global::System.Globalization.NumberStyles.HexNumber, global::System.Globalization.CultureInfo.InvariantCulture);
	}

	// Token: 0x06000015 RID: 21 RVA: 0x000051E4 File Offset: 0x000041E4
	private static byte[] a(string A_0, uint A_1)
	{
		switch (0)
		{
		default:
		{
			int num = 1;
			byte[] array;
			for (;;)
			{
				string text;
				switch (num)
				{
				case 0:
				{
					array = new byte[24];
					int num2 = 0;
					num = 4;
					continue;
				}
				case 2:
					num = 9;
					continue;
				case 3:
					goto IL_10A;
				case 4:
					goto IL_6A;
				case 5:
				{
					int num2;
					if ((long)num2 >= 24L)
					{
						if (true)
						{
						}
						num = 6;
						continue;
					}
					text = A_0.Substring((int)((4L + (long)num2) * 2L), 2);
					array[num2] = byte.Parse(text, global::System.Globalization.NumberStyles.HexNumber, global::System.Globalization.CultureInfo.InvariantCulture);
					num2++;
					num = 11;
					continue;
				}
				case 6:
					num = 12;
					continue;
				case 7:
					num = 8;
					continue;
				case 8:
					if ((long)A_0.Length >= 56L)
					{
						num = 0;
						continue;
					}
					return array;
				case 9:
					if (A_0.Length % 2 != 0)
					{
						num = 3;
						continue;
					}
					goto IL_1AD;
				case 10:
					if (A_1 == 1U)
					{
						num = 7;
						continue;
					}
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_15B;
					}
					break;
				case 11:
					goto IL_6A;
				case 12:
					goto IL_E0;
				}
				if (!string.IsNullOrEmpty(A_0))
				{
					num = 2;
					continue;
				}
				goto IL_1AD;
				IL_6A:
				num = 5;
				continue;
				IL_1AD:
				array = null;
				text = string.Empty;
				num = 10;
			}
			IL_E0:
			return array;
			IL_10A:
			global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(2388U, "Secure", "ExtractSalt", global::System.Environment.StackTrace.ToString());
			throw ex;
			IL_15B:
			if (false)
			{
			}
			global::custom_exception.CCustomException ex2 = new global::custom_exception.CCustomException(2908U, "Secure", "ExtractSalt", global::System.Environment.StackTrace.ToString());
			throw ex2;
		}
		}
	}

	// Token: 0x06000016 RID: 22 RVA: 0x000053CC File Offset: 0x000043CC
	private static void a(ref byte[] A_0, global::System.Text.Encoding A_1)
	{
		try
		{
			string text = A_1.GetString(A_0);
			string text2 = text;
			char[] trimChars = new char[1];
			text = text2.TrimEnd(trimChars);
			A_0 = A_1.GetBytes(text);
		}
		catch (global::System.Exception ex)
		{
			if (!global::custom_exception.CCustomException.CheckErrorIDExsists(ex))
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
					ex.Source = 2390U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex.Source;
					break;
				}
			}
			global::custom_exception.CCustomException.Rethrow(ex);
		}
	}

	// Token: 0x06000017 RID: 23 RVA: 0x00005478 File Offset: 0x00004478
	private static void a(global::j.b A_0, out string A_1, out string A_2)
	{
		if (A_0 == global::j.b.e)
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
			A_1 = global::j.z[(int)((global::System.UIntPtr)1)];
			A_2 = global::j.aa[(int)((global::System.UIntPtr)1)];
			return;
		}
		A_1 = global::j.z[(int)((global::System.UIntPtr)A_0)];
		A_2 = global::j.aa[(int)((global::System.UIntPtr)A_0)];
	}

	// Token: 0x06000019 RID: 25 RVA: 0x000054FC File Offset: 0x000044FC
	// Note: this type is marked as 'beforefieldinit'.
	static j()
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
		global::j.z = new string[]
		{
			"RmFAUjxmbWpLNmkqUUVWfUhoQ1Usd1BOP0ZpLVg7USQ",
			"P1Ixd3swKE54MzUwOXhwWHtEVjM0biNLY1lNKzNRdnI",
			"MntwRDhWSDxHM0Eod0YlWz5ddTxZemlVUz4zbmprOGY"
		};
		global::j.aa = new string[]
		{
			"czp8KVtQfVU/bj9BbVBnIw",
			"Qlg3VSxAJW5dOjM5cHJIMw",
			"QTlhOFZ9cnY1JTE1a1Y2RQ"
		};
		global::j.ab = new string[]
		{
			"mototrbocps",
			"predefined"
		};
		global::j.ac = new string[]
		{
			"enE3biVqPUx8KnA5M3lvUQ",
			"KlIkejNiMl8tJSN0RGtjMQ"
		};
		global::j.ad = new string[]
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

	// Token: 0x0200001C RID: 28
	public enum b
	{
		// Token: 0x04000196 RID: 406
		a = -1,
		// Token: 0x04000197 RID: 407
		b,
		// Token: 0x04000198 RID: 408
		c,
		// Token: 0x04000199 RID: 409
		d,
		// Token: 0x0400019A RID: 410
		e = 25
	}

	// Token: 0x0200001D RID: 29
	public enum a
	{
		// Token: 0x0400019C RID: 412
		a,
		// Token: 0x0400019D RID: 413
		b
	}

	// Token: 0x0200001E RID: 30
	public enum c
	{
		// Token: 0x0400019F RID: 415
		a,
		// Token: 0x040001A0 RID: 416
		b,
		// Token: 0x040001A1 RID: 417
		c
	}
}
