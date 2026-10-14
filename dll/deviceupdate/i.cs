using System;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using custom_exception;

// Token: 0x02000011 RID: 17
internal class i
{
	// Token: 0x06000089 RID: 137 RVA: 0x00017340 File Offset: 0x00016340
	public static void a(string A_0, global::i.b A_1, ref string A_2)
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
					int num3 = 7;
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
							if (num2 != -1)
							{
								num3 = 2;
								continue;
							}
							goto IL_6E;
						case 1:
							goto IL_2CF;
						case 2:
							goto IL_2EE;
						case 3:
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
										goto IL_1B7;
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
								IL_1B7:;
							}
							goto IL_1BA;
							IL_139:
							global::System.IO.FileStream fileStream = new global::System.IO.FileStream(A_0 + str, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read, global::System.IO.FileShare.Read);
							num3 = 6;
							continue;
						}
						case 4:
							goto IL_370;
						case 5:
						{
							byte[] value;
							string text;
							try
							{
								value = rsacryptoServiceProvider.SignHash(rgbHash, null);
								text = rsacryptoServiceProvider.ToXmlString(false);
								goto IL_2F3;
							}
							finally
							{
								num3 = 2;
								for (;;)
								{
									switch (num3)
									{
									case 0:
										goto IL_115;
									case 1:
										((global::System.IDisposable)rsacryptoServiceProvider).Dispose();
										num3 = 0;
										continue;
									}
									if (rsacryptoServiceProvider == null)
									{
										break;
									}
									num3 = 1;
								}
								IL_115:;
							}
							goto IL_118;
							IL_2F3:
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
							num3 = 4;
							continue;
						}
						case 6:
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
											goto IL_24F;
										case 1:
											switch ((1 == 1) ? 1 : 0)
											{
											case 0:
											case 2:
												goto IL_24F;
											default:
												if (false)
												{
												}
												goto IL_251;
											}
											break;
										case 2:
										{
											int num6;
											if ((num6 = fileStream.Read(array, num5, num4 - num5)) <= 0)
											{
												num3 = 3;
												continue;
											}
											num5 += num6;
											num3 = 0;
											continue;
										}
										case 3:
											num3 = 4;
											continue;
										case 4:
											goto IL_28A;
										}
										break;
										IL_251:
										num3 = 2;
										continue;
										IL_24F:
										goto IL_251;
									}
								}
								IL_28A:
								goto IL_1BA;
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
										goto IL_2CC;
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
								IL_2CC:;
							}
							goto IL_2CF;
						case 7:
							if (num != -1)
							{
								num3 = 1;
								continue;
							}
							goto IL_6E;
						}
						break;
						IL_6E:
						str = global::i.ab[(int)((global::System.UIntPtr)A_1)];
						string text6 = global::i.ac[(int)((global::System.UIntPtr)A_1)];
						byte[] bytes2 = global::System.Convert.FromBase64String(text6 + "==");
						text6 = global::System.Text.Encoding.ASCII.GetString(bytes2);
						rgbHash = null;
						sha1Managed = new global::System.Security.Cryptography.SHA1Managed();
						num3 = 3;
						continue;
						IL_1BA:
						global::System.Security.Cryptography.X509Certificates.X509Certificate2 x509Certificate = new global::System.Security.Cryptography.X509Certificates.X509Certificate2(array, text6, global::System.Security.Cryptography.X509Certificates.X509KeyStorageFlags.MachineKeySet);
						rsacryptoServiceProvider = (global::System.Security.Cryptography.RSACryptoServiceProvider)x509Certificate.PrivateKey;
						num3 = 5;
						continue;
						IL_2CF:
						num3 = 0;
					}
				}
				IL_118:
				global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(1838U, "Secure", "ApplySignature", global::System.Environment.StackTrace.ToString());
				throw ex;
				IL_2EE:
				goto IL_118;
				IL_370:
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

	// Token: 0x0600008A RID: 138 RVA: 0x00017794 File Offset: 0x00016794
	public static global::i.c a(global::i.b A_0, ref string A_1)
	{
		switch (0)
		{
		default:
		{
			global::i.c result = global::i.c.b;
			try
			{
				for (;;)
				{
					int num = A_1.IndexOf("<SIGNATURE>", global::System.StringComparison.Ordinal);
					int num2 = A_1.IndexOf("</SIGNATURE>", global::System.StringComparison.Ordinal);
					int num3 = 10;
					for (;;)
					{
						switch (num3)
						{
						case 0:
						{
							global::System.Security.Cryptography.RSACryptoServiceProvider rsacryptoServiceProvider = new global::System.Security.Cryptography.RSACryptoServiceProvider();
							num3 = 2;
							continue;
						}
						case 1:
							if (num2 != -1)
							{
								num3 = 4;
								continue;
							}
							goto IL_33F;
						case 2:
							try
							{
								for (;;)
								{
									global::System.Security.Cryptography.RSACryptoServiceProvider rsacryptoServiceProvider;
									string xmlString;
									rsacryptoServiceProvider.FromXmlString(xmlString);
									num3 = 1;
									for (;;)
									{
										switch (num3)
										{
										case 0:
											goto IL_1ED;
										case 1:
										{
											byte[] rgbHash;
											byte[] array;
											if (rsacryptoServiceProvider.VerifyHash(rgbHash, null, array))
											{
												num3 = 4;
												continue;
											}
											result = global::i.c.a;
											num3 = 2;
											continue;
										}
										case 2:
											goto IL_1E4;
										case 3:
											goto IL_1E4;
										case 4:
											result = global::i.c.c;
											num3 = 3;
											continue;
										}
										break;
										IL_1E4:
										num3 = 0;
									}
								}
								IL_1ED:
								goto IL_33F;
							}
							finally
							{
								num3 = 0;
								for (;;)
								{
									global::System.Security.Cryptography.RSACryptoServiceProvider rsacryptoServiceProvider;
									switch (num3)
									{
									case 1:
										((global::System.IDisposable)rsacryptoServiceProvider).Dispose();
										num3 = 2;
										continue;
									case 2:
										goto IL_22F;
									}
									if (rsacryptoServiceProvider == null)
									{
										break;
									}
									num3 = 1;
								}
								IL_22F:;
							}
							goto IL_232;
						case 3:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_232;
							default:
							{
								if (false)
								{
								}
								try
								{
									global::System.Text.UnicodeEncoding unicodeEncoding = new global::System.Text.UnicodeEncoding();
									byte[] bytes = unicodeEncoding.GetBytes(A_1);
									global::System.Security.Cryptography.SHA1Managed sha1Managed;
									byte[] rgbHash = sha1Managed.ComputeHash(bytes);
								}
								finally
								{
									num3 = 1;
									for (;;)
									{
										global::System.Security.Cryptography.SHA1Managed sha1Managed;
										switch (num3)
										{
										case 0:
											((global::System.IDisposable)sha1Managed).Dispose();
											num3 = 2;
											continue;
										case 2:
											goto IL_318;
										}
										if (sha1Managed == null)
										{
											break;
										}
										num3 = 0;
									}
									IL_318:;
								}
								string text;
								byte[] array = new byte[text.Length / 2];
								int num4 = 0;
								num3 = 11;
								continue;
							}
							}
							break;
						case 4:
						{
							int num5 = A_1.IndexOf("<DIGEST>", global::System.StringComparison.Ordinal);
							int num6 = A_1.IndexOf("</DIGEST>", global::System.StringComparison.Ordinal);
							int num7 = num5 + "<DIGEST>".Length;
							int length = num6 - num7;
							string text = A_1.Substring(num7, length);
							num7 = num6 + "</DIGEST>".Length;
							length = num2 - num7;
							string xmlString = A_1.Substring(num7, length);
							num3 = 9;
							continue;
						}
						case 5:
							num3 = 1;
							continue;
						case 6:
							goto IL_34B;
						case 7:
							goto IL_232;
						case 8:
							goto IL_12E;
						case 9:
						{
							string xmlString;
							if (xmlString != global::i.ad[(int)((global::System.UIntPtr)A_0)])
							{
								num3 = 8;
								continue;
							}
							A_1 = A_1.Remove(num);
							byte[] rgbHash = null;
							global::System.Security.Cryptography.SHA1Managed sha1Managed = new global::System.Security.Cryptography.SHA1Managed();
							num3 = 3;
							continue;
						}
						case 10:
							if (num != -1)
							{
								num3 = 5;
								continue;
							}
							goto IL_33F;
						case 11:
							goto IL_232;
						case 12:
						{
							byte[] array;
							int num4;
							if (num4 >= array.Length)
							{
								num3 = 0;
								continue;
							}
							string text;
							array[num4] = global::System.Convert.ToByte(text.Substring(num4 * 2, 2), 16);
							num4++;
							num3 = 7;
							continue;
						}
						}
						break;
						IL_232:
						num3 = 12;
						continue;
						IL_33F:
						num3 = 6;
					}
				}
				IL_12E:
				global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(1836U, "Secure", "VerifySignature", global::System.Environment.StackTrace.ToString());
				throw ex;
				IL_34B:;
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

	// Token: 0x0600008B RID: 139 RVA: 0x00017BAC File Offset: 0x00016BAC
	public static void b(string A_0, string A_1, bool A_2, global::i.a A_3)
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
						goto IL_2AE;
					case 1:
					{
						if (!global::System.IO.File.Exists(global::System.IO.Path.GetFullPath(A_0)))
						{
							num = 0;
							continue;
						}
						string str;
						string str2;
						global::i.a(A_3, out str, out str2);
						global::System.Security.Cryptography.RijndaelManaged rijndaelManaged = new global::System.Security.Cryptography.RijndaelManaged();
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_2B0;
						default:
							if (false)
							{
							}
							num = 3;
							continue;
						}
						break;
					}
					case 2:
						goto IL_225;
					case 3:
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
										num = 0;
										for (;;)
										{
											switch (num)
											{
											case 1:
												goto IL_185;
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
										IL_185:;
									}
									global::i.a(array, ref array2, A_2, rijndaelManaged.CreateEncryptor());
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
									goto IL_202;
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
							IL_202:;
						}
						goto IL_205;
					case 5:
						goto IL_205;
					case 6:
						goto IL_2BC;
					case 7:
						if (string.IsNullOrEmpty(A_1))
						{
							num = 2;
							continue;
						}
						num = 1;
						continue;
					}
					if (!string.IsNullOrEmpty(A_0))
					{
						num = 5;
						continue;
					}
					break;
					IL_205:
					num = 7;
					continue;
					IL_2B0:
					num = 6;
				}
				IL_56:
				global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(2388U, "Secure", "EncryptFile", global::System.Environment.StackTrace.ToString());
				throw ex;
				IL_225:
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

	// Token: 0x0600008C RID: 140 RVA: 0x00017F4C File Offset: 0x00016F4C
	public static void b(byte[] A_0, ref byte[] A_1, bool A_2, global::i.a A_3)
	{
		try
		{
			switch (0)
			{
			default:
			{
				string str;
				string str2;
				global::i.a(A_3, out str, out str2);
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
					global::i.a(array, ref A_1, A_2, rijndaelManaged.CreateEncryptor());
				}
				finally
				{
					int num = 0;
					for (;;)
					{
						switch (num)
						{
						case 1:
							goto IL_C8;
						case 2:
							((global::System.IDisposable)rijndaelManaged).Dispose();
							num = 1;
							continue;
						}
						goto IL_A9;
						IL_AC:
						num = 2;
						continue;
						IL_A9:
						if (rijndaelManaged != null)
						{
							goto IL_AC;
						}
						IL_C8:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_AC;
						default:
							goto IL_DE;
						}
					}
					IL_DE:
					if (false)
					{
					}
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
				if (true)
				{
				}
				ex.Source = 2393U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex.Source;
			}
			global::custom_exception.CCustomException.Rethrow(ex);
		}
	}

	// Token: 0x0600008D RID: 141 RVA: 0x000180C0 File Offset: 0x000170C0
	public static void b(string A_0, ref string A_1, bool A_2, global::i.a A_3)
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
						if (!global::System.IO.File.Exists(global::System.IO.Path.GetFullPath(A_0)))
						{
							num = 5;
							continue;
						}
						goto IL_1B9;
					case 2:
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
										goto IL_152;
									}
									if (fileStream == null)
									{
										break;
									}
									num = 1;
								}
								IL_152:;
							}
							global::i.a(array, ref bytes, A_2, rijndaelManaged.CreateEncryptor());
							A_1 = global::System.Text.Encoding.UTF8.GetString(bytes);
							goto IL_1FC;
						}
						finally
						{
							num = 1;
							for (;;)
							{
								switch (num)
								{
								case 0:
									((global::System.IDisposable)rijndaelManaged).Dispose();
									num = 2;
									continue;
								case 2:
									goto IL_1B6;
								}
								if (rijndaelManaged == null)
								{
									break;
								}
								num = 0;
							}
							IL_1B6:;
						}
						goto IL_1B9;
						IL_1FC:
						num = 4;
						continue;
					case 3:
						goto IL_49;
					case 4:
						goto IL_208;
					case 5:
						goto IL_6D;
					}
					if (string.IsNullOrEmpty(A_0))
					{
						num = 3;
						continue;
					}
					num = 1;
					continue;
					IL_1B9:
					global::i.a(A_3, out str, out str2);
					rijndaelManaged = new global::System.Security.Cryptography.RijndaelManaged();
					num = 2;
				}
				IL_49:
				global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(2388U, "Secure", "EncryptFile", global::System.Environment.StackTrace.ToString());
				throw ex;
				IL_6D:
				global::custom_exception.CCustomException ex2 = new global::custom_exception.CCustomException(2392U, "Secure", "EncryptFile", global::System.Environment.StackTrace.ToString());
				throw ex2;
				IL_208:
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
				goto IL_247;
			}
			IL_21A:
			ex3.Source = 2393U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex3.Source;
			IL_247:
			switch ((1 == 1) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_21A;
			default:
				if (false)
				{
				}
				global::custom_exception.CCustomException.Rethrow(ex3);
				break;
			}
		}
		if (true)
		{
		}
	}

	// Token: 0x0600008E RID: 142 RVA: 0x000183B0 File Offset: 0x000173B0
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
								goto IL_D1;
							case 1:
								try
								{
									array = new byte[fileStream.Length];
									fileStream.Read(array, 0, array.Length);
									goto IL_11F;
								}
								finally
								{
									num = 1;
									for (;;)
									{
										switch (num)
										{
										case 0:
											goto IL_CE;
										case 2:
											((global::System.IDisposable)fileStream).Dispose();
											num = 0;
											continue;
										}
										if (fileStream == null)
										{
											break;
										}
										num = 2;
									}
									IL_CE:;
								}
								goto Block_4;
							case 2:
								goto IL_152;
							}
							break;
							IL_11F:
							global::i.a(array, ref array2, A_2, tripleDESCryptoServiceProvider.CreateEncryptor());
							global::System.IO.FileStream fileStream2 = new global::System.IO.FileStream(A_1, global::System.IO.FileMode.Create, global::System.IO.FileAccess.Write);
							num = 0;
							continue;
							Block_4:
							try
							{
								IL_D1:
								fileStream2.Write(array2, 0, array2.Length);
								goto IL_146;
							}
							finally
							{
								num = 1;
								for (;;)
								{
									switch (num)
									{
									case 0:
										goto IL_11C;
									case 2:
										((global::System.IDisposable)fileStream2).Dispose();
										num = 0;
										continue;
									}
									if (fileStream2 == null)
									{
										break;
									}
									num = 2;
								}
								IL_11C:;
							}
							goto IL_11F;
							IL_146:
							num = 2;
						}
					}
					IL_152:;
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
							goto IL_18F;
						}
						if (tripleDESCryptoServiceProvider == null)
						{
							break;
						}
						num = 0;
					}
					IL_18F:;
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
				goto IL_1D1;
			}
			IL_1A2:
			ex.Source = 2393U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex.Source;
			IL_1D1:
			switch ((1 == 1) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_1A2;
			default:
				if (false)
				{
				}
				global::custom_exception.CCustomException.Rethrow(ex);
				break;
			}
		}
	}

	// Token: 0x0600008F RID: 143 RVA: 0x0001863C File Offset: 0x0001763C
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
					int num = 2;
					for (;;)
					{
						switch (num)
						{
						case 0:
							if (A_1 != null)
							{
								num = 5;
								continue;
							}
							goto IL_164;
						case 1:
							try
							{
								num = 0;
								for (;;)
								{
									switch (num)
									{
									case 2:
										goto IL_11F;
									case 3:
									{
										global::System.Security.Cryptography.CryptoStream cryptoStream;
										cryptoStream.FlushFinalBlock();
										global::System.IO.MemoryStream memoryStream;
										A_1 = memoryStream.ToArray();
										num = 2;
										continue;
									}
									case 4:
									{
										long num2;
										long num3;
										if (num2 >= num3)
										{
											num = 3;
											continue;
										}
										global::System.IO.MemoryStream memoryStream2;
										byte[] buffer;
										int num4 = memoryStream2.Read(buffer, 0, 1024);
										global::System.Security.Cryptography.CryptoStream cryptoStream;
										cryptoStream.Write(buffer, 0, num4);
										num2 += (long)num4;
										num = 1;
										continue;
									}
									}
									IL_ED:
									num = 4;
									continue;
									goto IL_ED;
								}
								IL_11F:
								goto IL_24F;
							}
							finally
							{
								num = 1;
								for (;;)
								{
									global::System.Security.Cryptography.CryptoStream cryptoStream;
									switch (num)
									{
									case 0:
										goto IL_161;
									case 2:
										((global::System.IDisposable)cryptoStream).Dispose();
										num = 0;
										continue;
									}
									if (cryptoStream == null)
									{
										break;
									}
									num = 2;
								}
								IL_161:;
							}
							goto IL_164;
							IL_24F:
							num = 7;
							continue;
						case 3:
						{
							if (tripleDESCryptoServiceProvider == null)
							{
								num = 6;
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
							global::System.IO.MemoryStream memoryStream2 = new global::System.IO.MemoryStream(array);
							global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
							memoryStream.SetLength((long)array.Length);
							global::System.Security.Cryptography.CryptoStream cryptoStream = new global::System.Security.Cryptography.CryptoStream(memoryStream, tripleDESCryptoServiceProvider.CreateEncryptor(), global::System.Security.Cryptography.CryptoStreamMode.Write);
							num = 1;
							continue;
						}
						case 4:
							num = 0;
							continue;
						case 5:
							num = 3;
							continue;
						case 6:
							goto IL_24A;
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
					if (!global::custom_exception.CCustomException.CheckErrorIDExsists(ex3))
					{
						ex3.Source = 2389U.ToString() + "|" + ex3.Source;
					}
					global::custom_exception.CCustomException.Rethrow(ex3);
				}
			}
			finally
			{
				int num = 2;
				for (;;)
				{
					switch (num)
					{
					case 0:
						goto IL_2F9;
					case 1:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							if (false)
							{
							}
							((global::System.IDisposable)tripleDESCryptoServiceProvider).Dispose();
							break;
						}
						num = 0;
						continue;
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

	// Token: 0x06000090 RID: 144 RVA: 0x000189AC File Offset: 0x000179AC
	public static void a(string A_0, string A_1, bool A_2, global::i.a A_3)
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
					switch (num)
					{
					case 0:
						goto IL_243;
					case 1:
						goto IL_2BE;
					case 2:
						if (string.IsNullOrEmpty(A_1))
						{
							num = 0;
							continue;
						}
						num = 4;
						continue;
					case 3:
						goto IL_223;
					case 4:
					{
						if (!global::System.IO.File.Exists(global::System.IO.Path.GetFullPath(A_0)))
						{
							num = 6;
							continue;
						}
						string str;
						string str2;
						global::i.a(A_3, out str, out str2);
						global::System.Security.Cryptography.RijndaelManaged rijndaelManaged = new global::System.Security.Cryptography.RijndaelManaged();
						num = 7;
						continue;
					}
					case 6:
						goto IL_2B0;
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
								num = 1;
								for (;;)
								{
									global::System.IO.FileStream fileStream2;
									switch (num)
									{
									case 0:
										try
										{
											fileStream2.Write(array2, 0, array2.Length);
											goto IL_1D2;
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
										IL_1D2:
										num = 2;
										continue;
									case 1:
										goto IL_128;
									case 2:
										goto IL_1DE;
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
												goto IL_1A1;
											case 2:
												goto IL_18F;
											}
											switch ((1 == 1) ? 1 : 0)
											{
											case 0:
											case 2:
												IL_18F:
												((global::System.IDisposable)fileStream).Dispose();
												num = 0;
												break;
											default:
												if (false)
												{
												}
												if (fileStream == null)
												{
													goto IL_1A3;
												}
												num = 2;
												break;
											}
										}
										IL_1A1:
										IL_1A3:;
									}
									global::i.a(array, ref array2, A_2, A_3, rijndaelManaged.CreateDecryptor());
									fileStream2 = new global::System.IO.FileStream(A_1, global::System.IO.FileMode.OpenOrCreate, global::System.IO.FileAccess.Write);
									num = 0;
								}
							}
							IL_1DE:
							goto IL_2B2;
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
									goto IL_220;
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
							IL_220:;
						}
						goto IL_223;
						IL_2B2:
						num = 1;
						continue;
					}
					if (!string.IsNullOrEmpty(A_0))
					{
						num = 3;
						continue;
					}
					break;
					IL_223:
					num = 2;
				}
				IL_56:
				global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(2388U, "Secure", "DecryptFile", global::System.Environment.StackTrace.ToString());
				throw ex;
				IL_243:
				goto IL_56;
				IL_2B0:
				global::custom_exception.CCustomException ex2 = new global::custom_exception.CCustomException(2392U, "Secure", "DecryptFile", global::System.Environment.StackTrace.ToString());
				throw ex2;
				IL_2BE:
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

	// Token: 0x06000091 RID: 145 RVA: 0x00018D50 File Offset: 0x00017D50
	public static void a(byte[] A_0, ref byte[] A_1, bool A_2, global::i.a A_3)
	{
		try
		{
			switch (0)
			{
			default:
			{
				string str;
				string str2;
				global::i.a(A_3, out str, out str2);
				global::System.Security.Cryptography.RijndaelManaged rijndaelManaged = new global::System.Security.Cryptography.RijndaelManaged();
				try
				{
					rijndaelManaged.Key = global::System.Convert.FromBase64String(str + "=");
					rijndaelManaged.IV = global::System.Convert.FromBase64String(str2 + "==");
					global::i.a(A_0, ref A_1, A_2, A_3, rijndaelManaged.CreateDecryptor());
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
							goto IL_99;
						}
						if (rijndaelManaged == null)
						{
							break;
						}
						num = 0;
					}
					IL_99:;
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
				goto IL_D7;
			}
			IL_AA:
			ex.Source = 2394U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex.Source;
			IL_D7:
			switch ((1 == 1) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_AA;
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

	// Token: 0x06000092 RID: 146 RVA: 0x00018E94 File Offset: 0x00017E94
	public static void a(string A_0, ref string A_1, bool A_2, global::i.a A_3)
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
					global::System.Security.Cryptography.RijndaelManaged rijndaelManaged;
					string str;
					string str2;
					switch (num)
					{
					case 0:
						goto IL_49;
					case 2:
						if (!global::System.IO.File.Exists(global::System.IO.Path.GetFullPath(A_0)))
						{
							num = 5;
							continue;
						}
						goto IL_1B3;
					case 3:
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
							global::System.Text.Encoding encoding = global::i.a(array, ref bytes, A_2, A_3, rijndaelManaged.CreateDecryptor());
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
										goto IL_182;
									default:
										goto IL_1AA;
									}
									break;
								case 2:
									goto IL_182;
								}
								if (rijndaelManaged != null)
								{
									num = 2;
									continue;
								}
								goto IL_1B2;
								IL_182:
								((global::System.IDisposable)rijndaelManaged).Dispose();
								num = 0;
							}
							IL_1AA:
							if (false)
							{
							}
							IL_1B2:;
						}
						goto IL_1B3;
						IL_1F6:
						num = 4;
						continue;
					case 4:
						goto IL_202;
					case 5:
						goto IL_6D;
					}
					if (string.IsNullOrEmpty(A_0))
					{
						num = 0;
						continue;
					}
					num = 2;
					continue;
					IL_1B3:
					global::i.a(A_3, out str, out str2);
					rijndaelManaged = new global::System.Security.Cryptography.RijndaelManaged();
					num = 3;
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

	// Token: 0x06000093 RID: 147 RVA: 0x00019164 File Offset: 0x00018164
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
						goto IL_21B;
					case 1:
						goto IL_1FB;
					case 3:
					{
						if (!global::System.IO.File.Exists(global::System.IO.Path.GetFullPath(A_0)))
						{
							num = 4;
							continue;
						}
						global::System.Security.Cryptography.TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new global::System.Security.Cryptography.TripleDESCryptoServiceProvider();
						num = 7;
						continue;
					}
					case 4:
						goto IL_27D;
					case 5:
						goto IL_28B;
					case 6:
						if (string.IsNullOrEmpty(A_1))
						{
							num = 0;
							continue;
						}
						num = 3;
						continue;
					case 7:
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
													goto IL_120;
												case 2:
													((global::System.IDisposable)fileStream2).Dispose();
													num = 0;
													continue;
												}
												if (fileStream2 == null)
												{
													break;
												}
												num = 2;
											}
											IL_120:;
										}
										goto Block_7;
										IL_1AC:
										num = 1;
										continue;
									case 1:
										goto IL_1B8;
									case 2:
										goto IL_123;
									}
									break;
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
									global::i.a(array, ref array2, A_2, global::i.a.a, tripleDESCryptoServiceProvider.CreateDecryptor());
									fileStream2 = new global::System.IO.FileStream(A_1, global::System.IO.FileMode.OpenOrCreate, global::System.IO.FileAccess.Write);
									num = 0;
								}
							}
							IL_1B8:
							goto IL_27F;
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
									goto IL_1F8;
								}
								if (tripleDESCryptoServiceProvider == null)
								{
									break;
								}
								num = 1;
							}
							IL_1F8:;
						}
						goto IL_1FB;
						IL_27F:
						num = 5;
						continue;
					}
					if (!string.IsNullOrEmpty(A_0))
					{
						num = 1;
						continue;
					}
					break;
					IL_1FB:
					num = 6;
				}
				IL_56:
				global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(2388U, "Secure", "DecryptFile", global::System.Environment.StackTrace.ToString());
				throw ex;
				IL_21B:
				goto IL_56;
				IL_27D:
				global::custom_exception.CCustomException ex2 = new global::custom_exception.CCustomException(2392U, "Secure", "DecryptFile", global::System.Environment.StackTrace.ToString());
				throw ex2;
				IL_28B:
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
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					if (false)
					{
					}
					if (true)
					{
					}
					ex3.Source = 2394U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex3.Source;
					break;
				}
			}
			global::custom_exception.CCustomException.Rethrow(ex3);
		}
	}

	// Token: 0x06000094 RID: 148 RVA: 0x000194F0 File Offset: 0x000184F0
	public static void a(byte[] A_0, ref byte[] A_1, bool A_2)
	{
		try
		{
			global::System.Security.Cryptography.TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new global::System.Security.Cryptography.TripleDESCryptoServiceProvider();
			try
			{
				tripleDESCryptoServiceProvider.Key = global::System.Text.Encoding.ASCII.GetBytes("HAVNCPSLTDTUNERAIRTRACER");
				tripleDESCryptoServiceProvider.IV = global::System.Text.Encoding.ASCII.GetBytes("VEDKDJSP");
				global::i.a(A_0, ref A_1, A_2, global::i.a.a, tripleDESCryptoServiceProvider.CreateDecryptor());
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
							((global::System.IDisposable)tripleDESCryptoServiceProvider).Dispose();
							num = 2;
							continue;
						}
						break;
					case 2:
						goto IL_97;
					}
					if (tripleDESCryptoServiceProvider == null)
					{
						break;
					}
					num = 0;
				}
				IL_97:;
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

	// Token: 0x06000095 RID: 149 RVA: 0x00019614 File Offset: 0x00018614
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
					global::System.Text.Encoding encoding = global::i.a(array, ref bytes, A_2, global::i.a.a, tripleDESCryptoServiceProvider.CreateDecryptor());
					A_1 = encoding.GetString(bytes);
				}
				finally
				{
					int num = 1;
					for (;;)
					{
						switch (num)
						{
						case 0:
							goto IL_11D;
						case 2:
							goto IL_10E;
						}
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							IL_10E:
							((global::System.IDisposable)tripleDESCryptoServiceProvider).Dispose();
							num = 0;
							break;
						default:
							if (false)
							{
							}
							if (tripleDESCryptoServiceProvider == null)
							{
								goto IL_11F;
							}
							num = 2;
							break;
						}
					}
					IL_11D:
					IL_11F:;
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

	// Token: 0x06000096 RID: 150 RVA: 0x00019800 File Offset: 0x00018800
	private static void a(byte[] A_0, ref byte[] A_1, bool A_2, global::System.Security.Cryptography.ICryptoTransform A_3)
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
					global::System.IO.MemoryStream memoryStream2;
					switch (num)
					{
					case 0:
						if (A_0.Length <= 0)
						{
							num = 4;
							continue;
						}
						goto IL_219;
					case 2:
						goto IL_25C;
					case 3:
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
							A_0 = memoryStream.ToArray();
							goto IL_164;
						}
						finally
						{
							num = 2;
							for (;;)
							{
								global::System.IO.MemoryStream memoryStream;
								switch (num)
								{
								case 0:
									goto IL_216;
								case 1:
									((global::System.IDisposable)memoryStream).Dispose();
									num = 0;
									continue;
								}
								if (memoryStream == null)
								{
									break;
								}
								num = 1;
							}
							IL_216:;
						}
						goto IL_219;
					case 4:
						goto IL_15F;
					case 5:
					{
						global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
						num = 3;
						continue;
					}
					case 6:
						goto IL_13E;
					case 7:
						try
						{
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
											goto IL_F0;
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
									IL_F0:;
								}
								break;
							}
							}
							A_1 = memoryStream2.ToArray();
							goto IL_250;
						}
						finally
						{
							num = 0;
							for (;;)
							{
								switch (num)
								{
								case 1:
									((global::System.IDisposable)memoryStream2).Dispose();
									num = 2;
									continue;
								case 2:
									goto IL_13B;
								}
								if (memoryStream2 == null)
								{
									break;
								}
								num = 1;
							}
							IL_13B:;
						}
						goto IL_13E;
						IL_250:
						num = 2;
						continue;
					case 8:
						if (A_2)
						{
							num = 5;
							continue;
						}
						goto IL_164;
					}
					if (A_0 != null)
					{
						num = 6;
						continue;
					}
					break;
					IL_13E:
					num = 0;
					continue;
					IL_164:
					memoryStream2 = new global::System.IO.MemoryStream();
					num = 7;
					continue;
					IL_219:
					num = 8;
				}
				IL_55:
				global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(2388U, "Secure", "EncryptFile", global::System.Environment.StackTrace.ToString());
				throw ex;
				IL_15F:
				goto IL_55;
				IL_25C:
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

	// Token: 0x06000097 RID: 151 RVA: 0x00019B58 File Offset: 0x00018B58
	private static global::System.Text.Encoding a(byte[] A_0, ref byte[] A_1, bool A_2, global::i.a A_3, global::System.Security.Cryptography.ICryptoTransform A_4)
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
				int num = 7;
				for (;;)
				{
					byte[] array;
					global::System.IO.MemoryStream memoryStream;
					byte b;
					switch (num)
					{
					case 0:
						goto IL_B4;
					case 1:
						num = 18;
						continue;
					case 2:
						if (A_2)
						{
							num = 19;
							continue;
						}
						goto IL_366;
					case 3:
						goto IL_5F9;
					case 4:
						if (array[1].Equals(187))
						{
							num = 1;
							continue;
						}
						goto IL_59D;
					case 5:
						A_1 = new byte[array.Length - 2];
						global::System.Array.Copy(array, 2, A_1, 0, array.Length - 2);
						encoding = new global::System.Text.UnicodeEncoding();
						global::i.a(ref A_1, encoding);
						num = 12;
						continue;
					case 6:
						goto IL_538;
					case 8:
						goto IL_2FC;
					case 9:
						goto IL_605;
					case 10:
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
										((global::System.IDisposable)cryptoStream).Dispose();
										num = 1;
										continue;
									case 1:
										goto IL_4F2;
									}
									if (cryptoStream == null)
									{
										break;
									}
									num = 0;
								}
								IL_4F2:;
							}
							goto IL_346;
						}
						finally
						{
							num = 1;
							for (;;)
							{
								switch (num)
								{
								case 0:
									memoryStream.Dispose();
									num = 2;
									continue;
								case 2:
									goto IL_535;
								}
								if (memoryStream == null)
								{
									break;
								}
								num = 0;
							}
							IL_535:;
						}
						goto IL_538;
						IL_346:
						num = 2;
						continue;
					case 11:
						if (b != 239)
						{
							num = 6;
							continue;
						}
						num = 4;
						continue;
					case 12:
						goto IL_5F9;
					case 13:
						goto IL_5F9;
					case 14:
						switch (b)
						{
						case 254:
							num = 15;
							continue;
						case 255:
							num = 16;
							continue;
						default:
							num = 24;
							continue;
						}
						break;
					case 15:
						if (array[1].Equals(255))
						{
							num = 5;
							continue;
						}
						goto IL_B9;
					case 16:
						if (array[1].Equals(254))
						{
							num = 26;
							continue;
						}
						goto IL_DC;
					case 17:
						if (A_3 == global::i.a.e)
						{
							num = 25;
							continue;
						}
						encoding = new global::System.Text.UTF8Encoding();
						num = 23;
						continue;
					case 18:
						if (array[2].Equals(191))
						{
							num = 20;
							continue;
						}
						goto IL_59D;
					case 19:
						try
						{
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
										num = 3;
										for (;;)
										{
											switch (num)
											{
											case 0:
												array = memoryStream2.ToArray();
												num = 1;
												continue;
											case 1:
												goto IL_1F9;
											case 2:
											{
												int count;
												if ((count = gzipStream.Read(array2, 0, array2.Length)) <= 0)
												{
													num = 0;
													continue;
												}
												memoryStream2.Write(array2, 0, count);
												num = 4;
												continue;
											}
											case 3:
												goto IL_1A9;
											case 4:
												goto IL_1A9;
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
											goto IL_238;
										case 2:
											((global::System.IDisposable)memoryStream2).Dispose();
											num = 0;
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
								num = 1;
								for (;;)
								{
									switch (num)
									{
									case 0:
										goto IL_27A;
									case 2:
										((global::System.IDisposable)gzipStream).Dispose();
										num = 0;
										continue;
									}
									if (gzipStream == null)
									{
										break;
									}
									num = 2;
								}
								IL_27A:;
							}
							goto IL_366;
						}
						finally
						{
							num = 1;
							for (;;)
							{
								switch (num)
								{
								case 0:
									memoryStream.Dispose();
									num = 2;
									continue;
								case 2:
									goto IL_2BD;
								}
								if (memoryStream == null)
								{
									break;
								}
								num = 0;
							}
							IL_2BD:;
						}
						goto IL_2C0;
					case 20:
						A_1 = new byte[array.Length - 3];
						global::System.Array.Copy(array, 3, A_1, 0, array.Length - 3);
						encoding = new global::System.Text.UTF8Encoding();
						global::i.a(ref A_1, encoding);
						num = 22;
						continue;
					case 21:
						goto IL_2C0;
					case 22:
						goto IL_5F9;
					case 23:
						goto IL_2FC;
					case 24:
						num = 21;
						continue;
					case 25:
						encoding = global::System.Text.Encoding.GetEncoding(1252);
						num = 8;
						continue;
					case 26:
						A_1 = new byte[array.Length - 2];
						global::System.Array.Copy(array, 2, A_1, 0, array.Length - 2);
						encoding = new global::System.Text.UnicodeEncoding();
						global::i.a(ref A_1, encoding);
						num = 3;
						continue;
					}
					if (A_0 == null)
					{
						num = 0;
						continue;
					}
					array = new byte[A_0.Length];
					memoryStream = null;
					num = 10;
					continue;
					IL_2C0:
					A_1 = new byte[array.Length];
					global::System.Array.Copy(array, 0, A_1, 0, array.Length);
					num = 17;
					continue;
					IL_2FC:
					global::i.a(ref A_1, encoding);
					num = 13;
					continue;
					IL_366:
					b = array[0];
					num = 11;
					continue;
					IL_538:
					num = 14;
					continue;
					IL_5F9:
					num = 9;
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
				IL_59D:
				global::custom_exception.CCustomException ex4 = new global::custom_exception.CCustomException(2391U, "Secure", "DecryptFile", global::System.Environment.StackTrace.ToString());
				throw ex4;
				IL_605:;
			}
			catch (global::custom_exception.CCustomException)
			{
				throw;
			}
			catch (global::System.Exception ex5)
			{
				if (global::custom_exception.CCustomException.CheckErrorIDExsists(ex5))
				{
					goto IL_644;
				}
				IL_617:
				ex5.Source = 2394U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex5.Source;
				IL_644:
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_617;
				default:
					if (false)
					{
					}
					global::custom_exception.CCustomException.Rethrow(ex5);
					break;
				}
			}
			return encoding;
		}
		}
	}

	// Token: 0x06000098 RID: 152 RVA: 0x0001A27C File Offset: 0x0001927C
	public static void a(string A_0, ref uint A_1, ref byte[] A_2)
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
					if (true)
					{
					}
					num = 3;
					continue;
				}
				break;
			case 2:
				goto IL_9E;
			case 3:
				if (A_0.Length % 2 != 0)
				{
					num = 2;
					continue;
				}
				goto IL_A0;
			}
			if (string.IsNullOrEmpty(A_0))
			{
				goto IL_A0;
			}
			num = 0;
		}
		IL_9E:
		global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(2388U, "Secure", "ExtractHashHeader", global::System.Environment.StackTrace.ToString());
		throw ex;
		IL_A0:
		A_1 = global::i.a(A_0);
		A_2 = global::i.a(A_0, A_1);
	}

	// Token: 0x06000099 RID: 153 RVA: 0x0001A33C File Offset: 0x0001933C
	private static uint a(string A_0)
	{
		int num = 0;
		for (;;)
		{
			switch (num)
			{
			case 1:
				goto IL_9E;
			case 2:
				if (A_0.Length % 2 != 0)
				{
					if (true)
					{
					}
					num = 1;
					continue;
				}
				goto IL_A0;
			case 3:
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				default:
					if (false)
					{
					}
					num = 2;
					continue;
				}
				break;
			}
			if (string.IsNullOrEmpty(A_0))
			{
				goto IL_A0;
			}
			num = 3;
		}
		IL_9E:
		global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(2388U, "Secure", "ExtractAlgorithmID", global::System.Environment.StackTrace.ToString());
		throw ex;
		IL_A0:
		string text = A_0.Substring(0, 8);
		return uint.Parse(text, global::System.Globalization.NumberStyles.HexNumber, global::System.Globalization.CultureInfo.InvariantCulture);
	}

	// Token: 0x0600009A RID: 154 RVA: 0x0001A404 File Offset: 0x00019404
	private static byte[] a(string A_0, uint A_1)
	{
		switch (0)
		{
		default:
		{
			int num = 11;
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
					num = 8;
					continue;
				}
				case 1:
					goto IL_72;
				case 2:
					if ((long)A_0.Length >= 56L)
					{
						num = 10;
						continue;
					}
					return array;
				case 3:
					num = 7;
					continue;
				case 4:
					goto IL_10A;
				case 5:
					if (A_1 == 1U)
					{
						num = 12;
						continue;
					}
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1B8;
					default:
						goto IL_15B;
					}
					break;
				case 6:
					if (A_0.Length % 2 != 0)
					{
						num = 4;
						continue;
					}
					goto IL_1AD;
				case 7:
					goto IL_E0;
				case 8:
					goto IL_72;
				case 9:
					num = 6;
					continue;
				case 10:
				{
					array = new byte[24];
					int num2 = 0;
					num = 1;
					continue;
				}
				case 12:
					num = 2;
					continue;
				}
				if (!string.IsNullOrEmpty(A_0))
				{
					if (true)
					{
					}
					num = 9;
					continue;
				}
				goto IL_1AD;
				IL_72:
				num = 0;
				continue;
				IL_1B8:
				num = 5;
				continue;
				IL_1AD:
				array = null;
				text = string.Empty;
				goto IL_1B8;
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

	// Token: 0x0600009B RID: 155 RVA: 0x0001A5EC File Offset: 0x000195EC
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
					ex.Source = 2390U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex.Source;
					break;
				}
			}
			global::custom_exception.CCustomException.Rethrow(ex);
		}
	}

	// Token: 0x0600009C RID: 156 RVA: 0x0001A698 File Offset: 0x00019698
	private static void a(global::i.a A_0, out string A_1, out string A_2)
	{
		while (A_0 == global::i.a.e)
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
				if (false)
				{
				}
				A_1 = global::i.z[(int)((global::System.UIntPtr)1)];
				A_2 = global::i.aa[(int)((global::System.UIntPtr)1)];
				return;
			}
		}
		A_1 = global::i.z[(int)((global::System.UIntPtr)A_0)];
		A_2 = global::i.aa[(int)((global::System.UIntPtr)A_0)];
	}

	// Token: 0x0600009E RID: 158 RVA: 0x0001A71C File Offset: 0x0001971C
	// Note: this type is marked as 'beforefieldinit'.
	static i()
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
		global::i.z = new string[]
		{
			"RmFAUjxmbWpLNmkqUUVWfUhoQ1Usd1BOP0ZpLVg7USQ",
			"P1Ixd3swKE54MzUwOXhwWHtEVjM0biNLY1lNKzNRdnI",
			"MntwRDhWSDxHM0Eod0YlWz5ddTxZemlVUz4zbmprOGY"
		};
		global::i.aa = new string[]
		{
			"czp8KVtQfVU/bj9BbVBnIw",
			"Qlg3VSxAJW5dOjM5cHJIMw",
			"QTlhOFZ9cnY1JTE1a1Y2RQ"
		};
		global::i.ab = new string[]
		{
			"mototrbocps",
			"predefined"
		};
		global::i.ac = new string[]
		{
			"enE3biVqPUx8KnA5M3lvUQ",
			"KlIkejNiMl8tJSN0RGtjMQ"
		};
		global::i.ad = new string[]
		{
			"<RSAKeyValue><Modulus>5AaKT6Hvh9+QrPWr5wugcqFjZWe54yW4/2sn6KAHKIrvvpD7J2x+elfDTry9DEx0U5dplG0SAtMNlXNV4PXU72Ze/yoeD/gfsGBGlmhpVCxkd0WvfSnSl5xe/WcCVJnyrjIQjRI47Aok7H3tjtshvq/LLKUtWxpxy4iGupbtv20=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>",
			"<RSAKeyValue><Modulus>qZzUh3GihbzdI7wJxcIzvLX7X/7sTUSgjnmByopoISoAyFz+5rWpat+vGXswVaUAWK6htcWW2iGdDlyERK/U5jme2IB91CFjk9bSsmVx5RF3oTzNmxAh/cQ7qAwEi/3ffu+SzFSaZlZJ+1kKSwoM/qvVPXQjaYmu1F4YYD1k430=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>"
		};
	}

	// Token: 0x0400005A RID: 90
	private const int a = 0;

	// Token: 0x0400005B RID: 91
	public const int b = 3;

	// Token: 0x0400005C RID: 92
	private const int c = 2;

	// Token: 0x0400005D RID: 93
	private const int d = 1024;

	// Token: 0x0400005E RID: 94
	public const byte e = 239;

	// Token: 0x0400005F RID: 95
	public const byte f = 187;

	// Token: 0x04000060 RID: 96
	public const byte g = 191;

	// Token: 0x04000061 RID: 97
	private const byte h = 254;

	// Token: 0x04000062 RID: 98
	private const byte i = 255;

	// Token: 0x04000063 RID: 99
	private const byte j = 255;

	// Token: 0x04000064 RID: 100
	private const byte k = 254;

	// Token: 0x04000065 RID: 101
	private const string l = "|";

	// Token: 0x04000066 RID: 102
	private const string m = "Secure";

	// Token: 0x04000067 RID: 103
	private const string n = ", ";

	// Token: 0x04000068 RID: 104
	private const char o = '\0';

	// Token: 0x04000069 RID: 105
	private const string p = "<SIGNATURE>";

	// Token: 0x0400006A RID: 106
	private const string q = "</SIGNATURE>";

	// Token: 0x0400006B RID: 107
	private const string r = "<VERSION>";

	// Token: 0x0400006C RID: 108
	private const string s = "</VERSION>";

	// Token: 0x0400006D RID: 109
	private const string t = "1.0";

	// Token: 0x0400006E RID: 110
	private const string u = "<DIGEST>";

	// Token: 0x0400006F RID: 111
	private const string v = "</DIGEST>";

	// Token: 0x04000070 RID: 112
	public const uint w = 4U;

	// Token: 0x04000071 RID: 113
	public const uint x = 1U;

	// Token: 0x04000072 RID: 114
	public const uint y = 24U;

	// Token: 0x04000073 RID: 115
	private static string[] z;

	// Token: 0x04000074 RID: 116
	private static string[] aa;

	// Token: 0x04000075 RID: 117
	private static string[] ab;

	// Token: 0x04000076 RID: 118
	private static string[] ac;

	// Token: 0x04000077 RID: 119
	private static string[] ad;

	// Token: 0x02000012 RID: 18
	public enum a
	{
		// Token: 0x04000079 RID: 121
		a = -1,
		// Token: 0x0400007A RID: 122
		b,
		// Token: 0x0400007B RID: 123
		c,
		// Token: 0x0400007C RID: 124
		d,
		// Token: 0x0400007D RID: 125
		e = 25
	}

	// Token: 0x02000013 RID: 19
	public enum b
	{
		// Token: 0x0400007F RID: 127
		a,
		// Token: 0x04000080 RID: 128
		b
	}

	// Token: 0x02000014 RID: 20
	public enum c
	{
		// Token: 0x04000082 RID: 130
		a,
		// Token: 0x04000083 RID: 131
		b,
		// Token: 0x04000084 RID: 132
		c
	}
}
