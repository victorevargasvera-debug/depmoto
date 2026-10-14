using System;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using custom_exception;

// Token: 0x02000004 RID: 4
internal class a
{
	// Token: 0x0600000A RID: 10 RVA: 0x0000241C File Offset: 0x0000061C
	public static void a(string A_0, global::a.b A_1, ref string A_2)
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
					int num3 = 1;
					for (;;)
					{
						global::System.Security.Cryptography.SHA1Managed sha1Managed;
						byte[] rgbHash;
						string str;
						global::System.Security.Cryptography.RSACryptoServiceProvider rsacryptoServiceProvider;
						byte[] value;
						string text;
						byte[] array;
						switch (num3)
						{
						case 0:
							goto IL_36D;
						case 1:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_2F0;
							default:
								if (false)
								{
								}
								if (num != -1)
								{
									num3 = 4;
									continue;
								}
								goto IL_8A;
							}
							break;
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
								num3 = 1;
								for (;;)
								{
									switch (num3)
									{
									case 0:
										((global::System.IDisposable)sha1Managed).Dispose();
										num3 = 2;
										continue;
									case 2:
										goto IL_1D3;
									}
									if (sha1Managed == null)
									{
										break;
									}
									num3 = 0;
								}
								IL_1D3:;
							}
							goto IL_1D6;
							IL_155:
							global::System.IO.FileStream fileStream = new global::System.IO.FileStream(A_0 + str, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read, global::System.IO.FileShare.Read);
							num3 = 5;
							continue;
						}
						case 3:
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
										((global::System.IDisposable)rsacryptoServiceProvider).Dispose();
										num3 = 2;
										continue;
									case 2:
										goto IL_131;
									}
									if (rsacryptoServiceProvider == null)
									{
										break;
									}
									num3 = 1;
								}
								IL_131:;
							}
							goto IL_134;
						case 4:
							goto IL_2CC;
						case 5:
							try
							{
								for (;;)
								{
									global::System.IO.FileStream fileStream;
									int num4 = (int)fileStream.Length;
									array = new byte[num4];
									int num5 = 0;
									num3 = 3;
									for (;;)
									{
										switch (num3)
										{
										case 0:
											goto IL_287;
										case 1:
											goto IL_251;
										case 2:
											num3 = 0;
											continue;
										case 3:
											goto IL_251;
										case 4:
										{
											int num6;
											if ((num6 = fileStream.Read(array, num5, num4 - num5)) <= 0)
											{
												num3 = 2;
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
						case 6:
							goto IL_2EB;
						case 7:
							if (num2 != -1)
							{
								num3 = 6;
								continue;
							}
							goto IL_8A;
						}
						break;
						IL_8A:
						str = global::a.ab[(int)((global::System.UIntPtr)A_1)];
						string text2 = global::a.ac[(int)((global::System.UIntPtr)A_1)];
						byte[] bytes2 = global::System.Convert.FromBase64String(text2 + "==");
						text2 = global::System.Text.Encoding.ASCII.GetString(bytes2);
						rgbHash = null;
						sha1Managed = new global::System.Security.Cryptography.SHA1Managed();
						num3 = 2;
						continue;
						IL_1D6:
						global::System.Security.Cryptography.X509Certificates.X509Certificate2 x509Certificate = new global::System.Security.Cryptography.X509Certificates.X509Certificate2(array, text2, global::System.Security.Cryptography.X509Certificates.X509KeyStorageFlags.MachineKeySet);
						rsacryptoServiceProvider = (global::System.Security.Cryptography.RSACryptoServiceProvider)x509Certificate.PrivateKey;
						num3 = 3;
						continue;
						IL_2CC:
						num3 = 7;
						continue;
						IL_2F0:
						string text3 = global::System.BitConverter.ToString(value);
						string text4 = "<VERSION>1.0</VERSION>";
						string text5 = "<DIGEST>" + text3.Replace("-", "") + "</DIGEST>";
						string text6 = A_2;
						A_2 = string.Concat(new string[]
						{
							text6,
							"<SIGNATURE>",
							text4,
							text5,
							text,
							"</SIGNATURE>"
						});
						num3 = 0;
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

	// Token: 0x0600000B RID: 11 RVA: 0x0000286C File Offset: 0x00000A6C
	public static global::a.a a(global::a.b A_0, ref string A_1)
	{
		switch (0)
		{
		default:
		{
			global::a.a result = global::a.a.b;
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
						{
							global::System.Security.Cryptography.RSACryptoServiceProvider rsacryptoServiceProvider = new global::System.Security.Cryptography.RSACryptoServiceProvider();
							num3 = 8;
							continue;
						}
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
							num3 = 5;
							continue;
						}
						case 2:
							goto IL_23C;
						case 3:
							goto IL_138;
						case 4:
						{
							string xmlString;
							if (xmlString != global::a.ad[(int)((global::System.UIntPtr)A_0)])
							{
								num3 = 3;
								continue;
							}
							A_1 = A_1.Remove(num);
							byte[] rgbHash = null;
							global::System.Security.Cryptography.SHA1Managed sha1Managed = new global::System.Security.Cryptography.SHA1Managed();
							num3 = 1;
							continue;
						}
						case 5:
							goto IL_23C;
						case 6:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_292;
							default:
							{
								if (false)
								{
								}
								int num5 = A_1.IndexOf("<DIGEST>", global::System.StringComparison.Ordinal);
								int num6 = A_1.IndexOf("</DIGEST>", global::System.StringComparison.Ordinal);
								int num7 = num5 + "<DIGEST>".Length;
								int length = num6 - num7;
								string text = A_1.Substring(num7, length);
								num7 = num6 + "</DIGEST>".Length;
								length = num2 - num7;
								string xmlString = A_1.Substring(num7, length);
								num3 = 4;
								continue;
							}
							}
							break;
						case 7:
							num3 = 11;
							continue;
						case 8:
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
											byte[] rgbHash;
											byte[] array;
											if (rsacryptoServiceProvider.VerifyHash(rgbHash, null, array))
											{
												num3 = 3;
												continue;
											}
											result = global::a.a.a;
											num3 = 1;
											continue;
										}
										case 1:
											goto IL_1EE;
										case 2:
											goto IL_1F7;
										case 3:
											result = global::a.a.c;
											num3 = 4;
											continue;
										case 4:
											goto IL_1EE;
										}
										break;
										IL_1EE:
										num3 = 2;
									}
								}
								IL_1F7:
								goto IL_349;
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
										goto IL_239;
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
								IL_239:;
							}
							goto IL_23C;
						case 9:
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
							num3 = 2;
							continue;
						}
						case 10:
							goto IL_355;
						case 11:
							goto IL_292;
						case 12:
							if (num != -1)
							{
								num3 = 7;
								continue;
							}
							goto IL_349;
						}
						break;
						IL_23C:
						num3 = 9;
						continue;
						IL_292:
						if (num2 != -1)
						{
							num3 = 6;
							continue;
						}
						IL_349:
						num3 = 10;
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

	// Token: 0x0600000C RID: 12 RVA: 0x00002C84 File Offset: 0x00000E84
	public static void b(string A_0, string A_1, bool A_2, global::a.c A_3)
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
					switch (num)
					{
					case 0:
						if (string.IsNullOrEmpty(A_1))
						{
							num = 5;
							continue;
						}
						num = 7;
						continue;
					case 1:
						goto IL_2A0;
					case 2:
						goto IL_205;
					case 4:
						goto IL_292;
					case 5:
						goto IL_225;
					case 6:
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
										goto IL_1C0;
									case 1:
										try
										{
											fileStream2.Write(array2, 0, array2.Length);
											goto IL_1B4;
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
										IL_1B4:
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
									global::a.a(array, ref array2, A_2, rijndaelManaged.CreateEncryptor());
									fileStream2 = new global::System.IO.FileStream(A_1, global::System.IO.FileMode.Create, global::System.IO.FileAccess.Write);
									num = 1;
								}
							}
							IL_1C0:
							goto IL_294;
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
						IL_294:
						num = 1;
						continue;
					case 7:
					{
						if (!global::System.IO.File.Exists(global::System.IO.Path.GetFullPath(A_0)))
						{
							num = 4;
							continue;
						}
						string str;
						string str2;
						global::a.a(A_3, out str, out str2);
						global::System.Security.Cryptography.RijndaelManaged rijndaelManaged = new global::System.Security.Cryptography.RijndaelManaged();
						num = 6;
						continue;
					}
					}
					if (!string.IsNullOrEmpty(A_0))
					{
						num = 2;
						continue;
					}
					break;
					IL_205:
					num = 0;
				}
				IL_56:
				global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(2388U, "Secure", "EncryptFile", global::System.Environment.StackTrace.ToString());
				throw ex;
				IL_225:
				goto IL_56;
				IL_292:
				global::custom_exception.CCustomException ex2 = new global::custom_exception.CCustomException(2392U, "Secure", "EncryptFile", global::System.Environment.StackTrace.ToString());
				throw ex2;
				IL_2A0:
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
					if (true)
					{
					}
					if (false)
					{
					}
					ex3.Source = 2393U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex3.Source;
					break;
				}
			}
			global::custom_exception.CCustomException.Rethrow(ex3);
		}
	}

	// Token: 0x0600000D RID: 13 RVA: 0x00003024 File Offset: 0x00001224
	public static void b(byte[] A_0, ref byte[] A_1, bool A_2, global::a.c A_3)
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
			global::a.a(A_3, out str, out str2);
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
				global::a.a(array, ref A_1, A_2, rijndaelManaged.CreateEncryptor());
			}
			finally
			{
				int num = 0;
				for (;;)
				{
					switch (num)
					{
					case 1:
						goto IL_E2;
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
				IL_E2:;
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

	// Token: 0x0600000E RID: 14 RVA: 0x00003198 File Offset: 0x00001398
	public static void b(string A_0, ref string A_1, bool A_2, global::a.c A_3)
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
					global::System.Security.Cryptography.RijndaelManaged rijndaelManaged;
					string str;
					string str2;
					switch (num)
					{
					case 0:
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
										goto IL_152;
									}
									if (fileStream == null)
									{
										break;
									}
									num = 0;
								}
								IL_152:;
							}
							global::a.a(array, ref bytes, A_2, rijndaelManaged.CreateEncryptor());
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
						num = 2;
						continue;
					case 1:
						goto IL_49;
					case 2:
						goto IL_208;
					case 3:
						goto IL_6D;
					case 5:
						if (!global::System.IO.File.Exists(global::System.IO.Path.GetFullPath(A_0)))
						{
							num = 3;
							continue;
						}
						goto IL_1B9;
					}
					if (string.IsNullOrEmpty(A_0))
					{
						num = 1;
						continue;
					}
					num = 5;
					continue;
					IL_1B9:
					global::a.a(A_3, out str, out str2);
					rijndaelManaged = new global::System.Security.Cryptography.RijndaelManaged();
					num = 0;
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
					ex3.Source = 2393U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex3.Source;
					break;
				}
			}
			global::custom_exception.CCustomException.Rethrow(ex3);
		}
		if (true)
		{
		}
	}

	// Token: 0x0600000F RID: 15 RVA: 0x00003488 File Offset: 0x00001688
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
				goto IL_1E;
				try
				{
					for (;;)
					{
						IL_1E:
						for (;;)
						{
							tripleDESCryptoServiceProvider.Key = global::System.Text.Encoding.ASCII.GetBytes("HAVNCPSLTDTUNERAIRTRACER");
							tripleDESCryptoServiceProvider.IV = global::System.Text.Encoding.ASCII.GetBytes("VEDKDJSP");
							byte[] array = null;
							byte[] array2 = null;
							global::System.IO.FileStream fileStream = new global::System.IO.FileStream(A_0, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read);
							int num = 0;
							for (;;)
							{
								switch (num)
								{
								case 0:
									try
									{
										array = new byte[fileStream.Length];
										fileStream.Read(array, 0, array.Length);
										goto IL_122;
									}
									finally
									{
										num = 0;
										for (;;)
										{
											switch (num)
											{
											case 1:
												goto IL_CE;
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
										IL_CE:;
									}
									goto Block_4;
								case 1:
									goto IL_D1;
								case 2:
									goto IL_174;
								}
								break;
								IL_122:
								global::a.a(array, ref array2, A_2, tripleDESCryptoServiceProvider.CreateEncryptor());
								global::System.IO.FileStream fileStream2 = new global::System.IO.FileStream(A_1, global::System.IO.FileMode.Create, global::System.IO.FileAccess.Write);
								switch ((1 == 1) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_1E;
								default:
									if (false)
									{
									}
									num = 1;
									continue;
								}
								Block_4:
								try
								{
									IL_D1:
									fileStream2.Write(array2, 0, array2.Length);
									goto IL_168;
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
											goto IL_11F;
										}
										if (fileStream2 == null)
										{
											break;
										}
										num = 0;
									}
									IL_11F:;
								}
								goto IL_122;
								IL_168:
								num = 2;
							}
						}
					}
					IL_174:;
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
							goto IL_1B1;
						}
						if (tripleDESCryptoServiceProvider == null)
						{
							break;
						}
						num = 1;
					}
					IL_1B1:;
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

	// Token: 0x06000010 RID: 16 RVA: 0x00003718 File Offset: 0x00001918
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
					int num = 7;
					for (;;)
					{
						switch (num)
						{
						case 0:
							num = 4;
							continue;
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
										global::System.IO.MemoryStream memoryStream;
										A_1 = memoryStream.ToArray();
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
										global::System.IO.MemoryStream memoryStream2;
										byte[] buffer;
										int num4 = memoryStream2.Read(buffer, 0, 1024);
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
								goto IL_26B;
							}
							finally
							{
								num = 0;
								for (;;)
								{
									switch (num)
									{
									case 1:
										goto IL_17D;
									case 2:
										goto IL_16D;
									}
									global::System.Security.Cryptography.CryptoStream cryptoStream;
									if (cryptoStream == null)
									{
										break;
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
										num = 2;
										continue;
									}
									IL_16D:
									((global::System.IDisposable)cryptoStream).Dispose();
									num = 1;
								}
								IL_17D:;
							}
							goto IL_180;
							IL_26B:
							num = 6;
							continue;
						case 2:
							if (A_1 != null)
							{
								num = 0;
								continue;
							}
							goto IL_180;
						case 3:
							num = 2;
							continue;
						case 4:
						{
							if (tripleDESCryptoServiceProvider == null)
							{
								num = 5;
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
						case 5:
							goto IL_266;
						case 6:
							goto IL_277;
						}
						if (A_0 == null)
						{
							break;
						}
						num = 3;
					}
					IL_180:
					global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(2388U, "Secure", ", EncryptFile", global::System.Environment.StackTrace.ToString());
					throw ex;
					IL_266:
					goto IL_180;
					IL_277:;
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

	// Token: 0x06000011 RID: 17 RVA: 0x00003A88 File Offset: 0x00001C88
	public static void a(string A_0, string A_1, bool A_2, global::a.c A_3)
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
											goto IL_1B6;
										}
										finally
										{
											num = 1;
											for (;;)
											{
												switch (num)
												{
												case 0:
													goto IL_125;
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
											IL_125:;
										}
										goto Block_7;
										IL_1B6:
										num = 1;
										continue;
									case 1:
										goto IL_1C2;
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
									global::a.a(array, ref array2, A_2, A_3, rijndaelManaged.CreateDecryptor());
									fileStream2 = new global::System.IO.FileStream(A_1, global::System.IO.FileMode.OpenOrCreate, global::System.IO.FileAccess.Write);
									num = 0;
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
						num = 1;
						continue;
					case 1:
						goto IL_2A2;
					case 2:
						goto IL_227;
					case 3:
					{
						if (!global::System.IO.File.Exists(global::System.IO.Path.GetFullPath(A_0)))
						{
							num = 6;
							continue;
						}
						string str;
						string str2;
						global::a.a(A_3, out str, out str2);
						global::System.Security.Cryptography.RijndaelManaged rijndaelManaged = new global::System.Security.Cryptography.RijndaelManaged();
						num = 0;
						continue;
					}
					case 4:
						goto IL_207;
					case 5:
						if (string.IsNullOrEmpty(A_1))
						{
							num = 2;
							continue;
						}
						num = 3;
						continue;
					case 6:
						goto IL_294;
					}
					if (!string.IsNullOrEmpty(A_0))
					{
						num = 4;
						continue;
					}
					break;
					IL_207:
					num = 5;
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
			if (true)
			{
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

	// Token: 0x06000012 RID: 18 RVA: 0x00003E2C File Offset: 0x0000202C
	public static void a(byte[] A_0, ref byte[] A_1, bool A_2, global::a.c A_3)
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
				default:
				{
					string str;
					string str2;
					global::a.a(A_3, out str, out str2);
					global::System.Security.Cryptography.RijndaelManaged rijndaelManaged = new global::System.Security.Cryptography.RijndaelManaged();
					try
					{
						rijndaelManaged.Key = global::System.Convert.FromBase64String(str + "=");
						rijndaelManaged.IV = global::System.Convert.FromBase64String(str2 + "==");
						global::a.a(A_0, ref A_1, A_2, A_3, rijndaelManaged.CreateDecryptor());
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
					break;
				}
				}
				break;
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

	// Token: 0x06000013 RID: 19 RVA: 0x00003F70 File Offset: 0x00002170
	public static void a(string A_0, ref string A_1, bool A_2, global::a.c A_3)
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
							num = 2;
							continue;
						}
						goto IL_1B3;
					case 2:
						goto IL_6D;
					case 3:
						goto IL_49;
					case 4:
						goto IL_202;
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
										goto IL_130;
									}
									if (fileStream == null)
									{
										break;
									}
									num = 1;
								}
								IL_130:;
							}
							global::System.Text.Encoding encoding = global::a.a(array, ref bytes, A_2, A_3, rijndaelManaged.CreateDecryptor());
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
								IL_175:
								switch ((1 == 1) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_175;
								default:
									if (false)
									{
									}
									if (rijndaelManaged == null)
									{
										goto IL_1B2;
									}
									num = 1;
									break;
								}
							}
							IL_1B0:
							IL_1B2:;
						}
						goto IL_1B3;
						IL_1F6:
						num = 4;
						continue;
					}
					if (string.IsNullOrEmpty(A_0))
					{
						num = 3;
						continue;
					}
					num = 1;
					continue;
					IL_1B3:
					global::a.a(A_3, out str, out str2);
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
				if (true)
				{
				}
				ex3.Source = 2394U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex3.Source;
			}
			global::custom_exception.CCustomException.Rethrow(ex3);
		}
	}

	// Token: 0x06000014 RID: 20 RVA: 0x00004240 File Offset: 0x00002440
	public static void a(string A_0, string A_1, bool A_2)
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
					switch (num)
					{
					case 0:
					{
						if (!global::System.IO.File.Exists(global::System.IO.Path.GetFullPath(A_0)))
						{
							num = 6;
							continue;
						}
						global::System.Security.Cryptography.TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new global::System.Security.Cryptography.TripleDESCryptoServiceProvider();
						num = 5;
						continue;
					}
					case 1:
						goto IL_217;
					case 2:
						if (string.IsNullOrEmpty(A_1))
						{
							num = 4;
							continue;
						}
						num = 0;
						continue;
					case 4:
						goto IL_237;
					case 5:
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
										goto IL_13F;
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
													switch ((1 == 1) ? 1 : 0)
													{
													case 0:
													case 2:
														goto IL_105;
													default:
														if (false)
														{
														}
														((global::System.IDisposable)fileStream2).Dispose();
														num = 2;
														continue;
													}
													break;
												case 2:
													goto IL_13C;
												}
												goto IL_101;
												IL_105:
												num = 1;
												continue;
												IL_101:
												if (fileStream2 != null)
												{
													goto IL_105;
												}
												break;
											}
											IL_13C:;
										}
										goto Block_7;
										IL_1C8:
										num = 1;
										continue;
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
												goto IL_199;
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
										IL_199:;
									}
									global::a.a(array, ref array2, A_2, global::a.c.a, tripleDESCryptoServiceProvider.CreateDecryptor());
									fileStream2 = new global::System.IO.FileStream(A_1, global::System.IO.FileMode.OpenOrCreate, global::System.IO.FileAccess.Write);
									num = 2;
								}
							}
							IL_1D4:
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
						num = 7;
						continue;
					case 6:
						goto IL_299;
					case 7:
						goto IL_2A7;
					}
					if (!string.IsNullOrEmpty(A_0))
					{
						num = 1;
						continue;
					}
					break;
					IL_217:
					num = 2;
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

	// Token: 0x06000015 RID: 21 RVA: 0x000045CC File Offset: 0x000027CC
	public static void a(byte[] A_0, ref byte[] A_1, bool A_2)
	{
		try
		{
			global::System.Security.Cryptography.TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new global::System.Security.Cryptography.TripleDESCryptoServiceProvider();
			try
			{
				tripleDESCryptoServiceProvider.Key = global::System.Text.Encoding.ASCII.GetBytes("HAVNCPSLTDTUNERAIRTRACER");
				tripleDESCryptoServiceProvider.IV = global::System.Text.Encoding.ASCII.GetBytes("VEDKDJSP");
				global::a.a(A_0, ref A_1, A_2, global::a.c.a, tripleDESCryptoServiceProvider.CreateDecryptor());
			}
			finally
			{
				int num = 2;
				for (;;)
				{
					switch (num)
					{
					case 0:
						goto IL_7B;
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
				IL_7B:;
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
			if (global::custom_exception.CCustomException.CheckErrorIDExsists(ex))
			{
				goto IL_C0;
			}
			IL_96:
			ex.Source = 2394U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex.Source;
			IL_C0:
			switch ((1 == 1) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_96;
			default:
				if (false)
				{
				}
				global::custom_exception.CCustomException.Rethrow(ex);
				break;
			}
		}
	}

	// Token: 0x06000016 RID: 22 RVA: 0x000046F0 File Offset: 0x000028F0
	public static void a(string A_0, ref string A_1, bool A_2)
	{
		try
		{
			switch (0)
			{
			default:
			{
				global::System.Security.Cryptography.TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new global::System.Security.Cryptography.TripleDESCryptoServiceProvider();
				goto IL_16;
				try
				{
					byte[] array;
					byte[] bytes;
					for (;;)
					{
						IL_16:
						tripleDESCryptoServiceProvider.Key = global::System.Text.Encoding.ASCII.GetBytes("HAVNCPSLTDTUNERAIRTRACER");
						tripleDESCryptoServiceProvider.IV = global::System.Text.Encoding.ASCII.GetBytes("VEDKDJSP");
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
							int num = 1;
							for (;;)
							{
								switch (num)
								{
								case 0:
									goto IL_A5;
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
							IL_A5:;
						}
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_BE;
						}
					}
					IL_BE:
					if (false)
					{
					}
					global::System.Text.Encoding encoding = global::a.a(array, ref bytes, A_2, global::a.c.a, tripleDESCryptoServiceProvider.CreateDecryptor());
					A_1 = encoding.GetString(bytes);
				}
				finally
				{
					int num = 0;
					for (;;)
					{
						switch (num)
						{
						case 1:
							goto IL_11D;
						case 2:
							((global::System.IDisposable)tripleDESCryptoServiceProvider).Dispose();
							num = 1;
							continue;
						}
						if (tripleDESCryptoServiceProvider == null)
						{
							break;
						}
						num = 2;
					}
					IL_11D:;
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

	// Token: 0x06000017 RID: 23 RVA: 0x000048DC File Offset: 0x00002ADC
	private static void a(byte[] A_0, ref byte[] A_1, bool A_2, global::System.Security.Cryptography.ICryptoTransform A_3)
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
					global::System.IO.MemoryStream memoryStream2;
					switch (num)
					{
					case 0:
					{
						global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
						num = 7;
						continue;
					}
					case 1:
						if (A_2)
						{
							num = 0;
							continue;
						}
						goto IL_164;
					case 3:
						goto IL_25C;
					case 4:
						goto IL_76;
						try
						{
							for (;;)
							{
								IL_76:
								global::System.Security.Cryptography.CryptoStream cryptoStream = new global::System.Security.Cryptography.CryptoStream(memoryStream2, A_3, global::System.Security.Cryptography.CryptoStreamMode.Write);
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
											((global::System.IDisposable)cryptoStream).Dispose();
											num = 2;
											continue;
										case 2:
											goto IL_D4;
										}
										if (cryptoStream == null)
										{
											break;
										}
										num = 1;
									}
									IL_D4:;
								}
								switch ((1 == 1) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									goto IL_ED;
								}
							}
							IL_ED:
							if (false)
							{
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
						num = 3;
						continue;
					case 5:
						goto IL_15F;
					case 6:
						goto IL_13E;
					case 7:
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
							num = 1;
							for (;;)
							{
								global::System.IO.MemoryStream memoryStream;
								switch (num)
								{
								case 0:
									((global::System.IDisposable)memoryStream).Dispose();
									num = 2;
									continue;
								case 2:
									goto IL_216;
								}
								if (memoryStream == null)
								{
									break;
								}
								num = 0;
							}
							IL_216:;
						}
						goto IL_219;
					case 8:
						if (A_0.Length <= 0)
						{
							num = 5;
							continue;
						}
						goto IL_219;
					}
					if (A_0 != null)
					{
						num = 6;
						continue;
					}
					break;
					IL_13E:
					num = 8;
					continue;
					IL_164:
					memoryStream2 = new global::System.IO.MemoryStream();
					num = 4;
					continue;
					IL_219:
					num = 1;
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

	// Token: 0x06000018 RID: 24 RVA: 0x00004C34 File Offset: 0x00002E34
	private static global::System.Text.Encoding a(byte[] A_0, ref byte[] A_1, bool A_2, global::a.c A_3, global::System.Security.Cryptography.ICryptoTransform A_4)
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
				int num = 18;
				for (;;)
				{
					byte[] array;
					global::System.IO.MemoryStream memoryStream;
					byte b;
					switch (num)
					{
					case 0:
						A_1 = new byte[array.Length - 2];
						global::System.Array.Copy(array, 2, A_1, 0, array.Length - 2);
						encoding = new global::System.Text.UnicodeEncoding();
						global::a.a(ref A_1, encoding);
						num = 26;
						continue;
					case 1:
						if (array[1].Equals(187))
						{
							num = 2;
							continue;
						}
						goto IL_5B5;
					case 2:
						num = 24;
						continue;
					case 3:
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
										goto IL_50A;
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
								IL_50A:;
							}
							goto IL_35E;
						}
						finally
						{
							num = 0;
							for (;;)
							{
								switch (num)
								{
								case 1:
									goto IL_54D;
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
							IL_54D:;
						}
						goto IL_550;
						IL_35E:
						num = 6;
						continue;
					case 4:
						goto IL_550;
					case 5:
						switch (b)
						{
						case 254:
							num = 11;
							continue;
						case 255:
							num = 25;
							continue;
						default:
							num = 7;
							continue;
						}
						break;
					case 6:
						if (A_2)
						{
							num = 16;
							continue;
						}
						goto IL_37E;
					case 7:
						num = 15;
						continue;
					case 8:
						goto IL_611;
					case 9:
						if (b != 239)
						{
							num = 4;
							continue;
						}
						num = 1;
						continue;
					case 10:
						encoding = global::System.Text.Encoding.GetEncoding(1252);
						num = 14;
						continue;
					case 11:
						if (array[1].Equals(255))
						{
							num = 0;
							continue;
						}
						goto IL_AF;
					case 12:
						A_1 = new byte[array.Length - 3];
						global::System.Array.Copy(array, 3, A_1, 0, array.Length - 3);
						encoding = new global::System.Text.UTF8Encoding();
						global::a.a(ref A_1, encoding);
						num = 8;
						continue;
					case 13:
						goto IL_611;
					case 14:
						goto IL_314;
					case 15:
						goto IL_2D8;
					case 16:
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
										IL_191:
										switch ((1 == 1) ? 1 : 0)
										{
										case 0:
										case 2:
											IL_1FD:
											array = memoryStream2.ToArray();
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
											{
												int count;
												if ((count = gzipStream.Read(array2, 0, array2.Length)) <= 0)
												{
													num = 3;
													continue;
												}
												memoryStream2.Write(array2, 0, count);
												num = 4;
												continue;
											}
											case 1:
												goto IL_1BB;
											case 2:
												goto IL_211;
											case 3:
												goto IL_1E1;
											case 4:
												goto IL_1BB;
											}
											goto IL_191;
											IL_1BB:
											num = 0;
										}
										IL_1E1:
										goto IL_1FD;
									}
									IL_211:;
								}
								finally
								{
									num = 1;
									for (;;)
									{
										switch (num)
										{
										case 0:
											goto IL_250;
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
									IL_250:;
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
										goto IL_292;
									}
									if (gzipStream == null)
									{
										break;
									}
									num = 0;
								}
								IL_292:;
							}
							goto IL_37E;
						}
						finally
						{
							num = 2;
							for (;;)
							{
								switch (num)
								{
								case 0:
									memoryStream.Dispose();
									num = 1;
									continue;
								case 1:
									goto IL_2D5;
								}
								if (memoryStream == null)
								{
									break;
								}
								num = 0;
							}
							IL_2D5:;
						}
						goto IL_2D8;
					case 17:
						goto IL_61D;
					case 19:
						goto IL_AA;
					case 20:
						if (A_3 == global::a.c.e)
						{
							num = 10;
							continue;
						}
						encoding = new global::System.Text.UTF8Encoding();
						num = 23;
						continue;
					case 21:
						A_1 = new byte[array.Length - 2];
						global::System.Array.Copy(array, 2, A_1, 0, array.Length - 2);
						encoding = new global::System.Text.UnicodeEncoding();
						global::a.a(ref A_1, encoding);
						num = 22;
						continue;
					case 22:
						goto IL_611;
					case 23:
						goto IL_314;
					case 24:
						if (array[2].Equals(191))
						{
							num = 12;
							continue;
						}
						goto IL_5B5;
					case 25:
						if (array[1].Equals(254))
						{
							num = 21;
							continue;
						}
						goto IL_D2;
					case 26:
						goto IL_611;
					}
					if (A_0 == null)
					{
						num = 19;
						continue;
					}
					array = new byte[A_0.Length];
					memoryStream = null;
					num = 3;
					continue;
					IL_2D8:
					A_1 = new byte[array.Length];
					global::System.Array.Copy(array, 0, A_1, 0, array.Length);
					num = 20;
					continue;
					IL_314:
					global::a.a(ref A_1, encoding);
					num = 13;
					continue;
					IL_37E:
					b = array[0];
					num = 9;
					continue;
					IL_550:
					num = 5;
					continue;
					IL_611:
					num = 17;
				}
				IL_AA:
				global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(2388U, "Secure", "DecryptFile", global::System.Environment.StackTrace.ToString());
				throw ex;
				IL_AF:
				global::custom_exception.CCustomException ex2 = new global::custom_exception.CCustomException(2391U, "Secure", "DecryptFile", global::System.Environment.StackTrace.ToString());
				throw ex2;
				IL_D2:
				global::custom_exception.CCustomException ex3 = new global::custom_exception.CCustomException(2391U, "Secure", "DecryptFile", global::System.Environment.StackTrace.ToString());
				throw ex3;
				IL_5B5:
				global::custom_exception.CCustomException ex4 = new global::custom_exception.CCustomException(2391U, "Secure", "DecryptFile", global::System.Environment.StackTrace.ToString());
				throw ex4;
				IL_61D:;
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

	// Token: 0x06000019 RID: 25 RVA: 0x00005360 File Offset: 0x00003560
	public static void a(string A_0, ref uint A_1, ref byte[] A_2)
	{
		int num = 3;
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
			case 2:
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
					num = 0;
					continue;
				}
				break;
			}
			IL_20:
			if (!string.IsNullOrEmpty(A_0))
			{
				num = 2;
				continue;
			}
			goto IL_A0;
			goto IL_20;
		}
		IL_9E:
		global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(2388U, "Secure", "ExtractHashHeader", global::System.Environment.StackTrace.ToString());
		throw ex;
		IL_A0:
		A_1 = global::a.a(A_0);
		A_2 = global::a.a(A_0, A_1);
	}

	// Token: 0x0600001A RID: 26 RVA: 0x00005420 File Offset: 0x00003620
	private static uint a(string A_0)
	{
		int num;
		switch ((1 == 1) ? 1 : 0)
		{
		case 0:
		case 2:
			IL_79:
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
			switch (num)
			{
			case 0:
				if (A_0.Length % 2 != 0)
				{
					if (true)
					{
					}
					num = 1;
					continue;
				}
				goto IL_9D;
			case 1:
				goto IL_9B;
			case 3:
				goto IL_56;
			}
			if (string.IsNullOrEmpty(A_0))
			{
				goto IL_9D;
			}
			num = 3;
		}
		IL_56:
		goto IL_79;
		IL_9B:
		global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(2388U, "Secure", "ExtractAlgorithmID", global::System.Environment.StackTrace.ToString());
		throw ex;
		IL_9D:
		string text = A_0.Substring(0, 8);
		return uint.Parse(text, global::System.Globalization.NumberStyles.HexNumber, global::System.Globalization.CultureInfo.InvariantCulture);
	}

	// Token: 0x0600001B RID: 27 RVA: 0x000054E8 File Offset: 0x000036E8
	private static byte[] a(string A_0, uint A_1)
	{
		switch (0)
		{
		default:
		{
			int num = 12;
			byte[] array;
			for (;;)
			{
				string text;
				switch (num)
				{
				case 0:
					goto IL_72;
				case 1:
					goto IL_D3;
				case 2:
					if ((long)A_0.Length >= 56L)
					{
						num = 6;
						continue;
					}
					return array;
				case 3:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_199;
					default:
						if (false)
						{
						}
						num = 2;
						continue;
					}
					break;
				case 4:
					goto IL_72;
				case 5:
					num = 11;
					continue;
				case 6:
				{
					array = new byte[24];
					int num2 = 0;
					num = 4;
					continue;
				}
				case 7:
					goto IL_FD;
				case 8:
					num = 1;
					continue;
				case 9:
				{
					int num2;
					if ((long)num2 >= 24L)
					{
						num = 8;
						continue;
					}
					text = A_0.Substring((int)((4L + (long)num2) * 2L), 2);
					array[num2] = byte.Parse(text, global::System.Globalization.NumberStyles.HexNumber, global::System.Globalization.CultureInfo.InvariantCulture);
					num2++;
					num = 0;
					continue;
				}
				case 10:
					if (A_1 == 1U)
					{
						num = 3;
						continue;
					}
					goto IL_138;
				case 11:
					if (A_0.Length % 2 != 0)
					{
						num = 7;
						continue;
					}
					goto IL_18E;
				}
				if (!string.IsNullOrEmpty(A_0))
				{
					if (true)
					{
					}
					num = 5;
					continue;
				}
				goto IL_18E;
				IL_72:
				num = 9;
				continue;
				IL_199:
				num = 10;
				continue;
				IL_18E:
				array = null;
				text = string.Empty;
				goto IL_199;
			}
			IL_D3:
			return array;
			IL_FD:
			global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(2388U, "Secure", "ExtractSalt", global::System.Environment.StackTrace.ToString());
			throw ex;
			IL_138:
			global::custom_exception.CCustomException ex2 = new global::custom_exception.CCustomException(2908U, "Secure", "ExtractSalt", global::System.Environment.StackTrace.ToString());
			throw ex2;
		}
		}
	}

	// Token: 0x0600001C RID: 28 RVA: 0x000056CC File Offset: 0x000038CC
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

	// Token: 0x0600001D RID: 29 RVA: 0x00005778 File Offset: 0x00003978
	private static void a(global::a.c A_0, out string A_1, out string A_2)
	{
		if (A_0 == global::a.c.e)
		{
			if (true)
			{
			}
		}
		else
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
				A_1 = global::a.z[(int)((global::System.UIntPtr)A_0)];
				A_2 = global::a.aa[(int)((global::System.UIntPtr)A_0)];
				return;
			}
		}
		A_1 = global::a.z[(int)((global::System.UIntPtr)1)];
		A_2 = global::a.aa[(int)((global::System.UIntPtr)1)];
	}

	// Token: 0x0600001F RID: 31 RVA: 0x000057FC File Offset: 0x000039FC
	// Note: this type is marked as 'beforefieldinit'.
	static a()
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
		global::a.z = new string[]
		{
			"RmFAUjxmbWpLNmkqUUVWfUhoQ1Usd1BOP0ZpLVg7USQ",
			"P1Ixd3swKE54MzUwOXhwWHtEVjM0biNLY1lNKzNRdnI",
			"MntwRDhWSDxHM0Eod0YlWz5ddTxZemlVUz4zbmprOGY"
		};
		global::a.aa = new string[]
		{
			"czp8KVtQfVU/bj9BbVBnIw",
			"Qlg3VSxAJW5dOjM5cHJIMw",
			"QTlhOFZ9cnY1JTE1a1Y2RQ"
		};
		global::a.ab = new string[]
		{
			"mototrbocps",
			"predefined"
		};
		global::a.ac = new string[]
		{
			"enE3biVqPUx8KnA5M3lvUQ",
			"KlIkejNiMl8tJSN0RGtjMQ"
		};
		global::a.ad = new string[]
		{
			"<RSAKeyValue><Modulus>5AaKT6Hvh9+QrPWr5wugcqFjZWe54yW4/2sn6KAHKIrvvpD7J2x+elfDTry9DEx0U5dplG0SAtMNlXNV4PXU72Ze/yoeD/gfsGBGlmhpVCxkd0WvfSnSl5xe/WcCVJnyrjIQjRI47Aok7H3tjtshvq/LLKUtWxpxy4iGupbtv20=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>",
			"<RSAKeyValue><Modulus>qZzUh3GihbzdI7wJxcIzvLX7X/7sTUSgjnmByopoISoAyFz+5rWpat+vGXswVaUAWK6htcWW2iGdDlyERK/U5jme2IB91CFjk9bSsmVx5RF3oTzNmxAh/cQ7qAwEi/3ffu+SzFSaZlZJ+1kKSwoM/qvVPXQjaYmu1F4YYD1k430=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>"
		};
	}

	// Token: 0x04000007 RID: 7
	private const int a = 0;

	// Token: 0x04000008 RID: 8
	public const int b = 3;

	// Token: 0x04000009 RID: 9
	private const int c = 2;

	// Token: 0x0400000A RID: 10
	private const int d = 1024;

	// Token: 0x0400000B RID: 11
	public const byte e = 239;

	// Token: 0x0400000C RID: 12
	public const byte f = 187;

	// Token: 0x0400000D RID: 13
	public const byte g = 191;

	// Token: 0x0400000E RID: 14
	private const byte h = 254;

	// Token: 0x0400000F RID: 15
	private const byte i = 255;

	// Token: 0x04000010 RID: 16
	private const byte j = 255;

	// Token: 0x04000011 RID: 17
	private const byte k = 254;

	// Token: 0x04000012 RID: 18
	private const string l = "|";

	// Token: 0x04000013 RID: 19
	private const string m = "Secure";

	// Token: 0x04000014 RID: 20
	private const string n = ", ";

	// Token: 0x04000015 RID: 21
	private const char o = '\0';

	// Token: 0x04000016 RID: 22
	private const string p = "<SIGNATURE>";

	// Token: 0x04000017 RID: 23
	private const string q = "</SIGNATURE>";

	// Token: 0x04000018 RID: 24
	private const string r = "<VERSION>";

	// Token: 0x04000019 RID: 25
	private const string s = "</VERSION>";

	// Token: 0x0400001A RID: 26
	private const string t = "1.0";

	// Token: 0x0400001B RID: 27
	private const string u = "<DIGEST>";

	// Token: 0x0400001C RID: 28
	private const string v = "</DIGEST>";

	// Token: 0x0400001D RID: 29
	public const uint w = 4U;

	// Token: 0x0400001E RID: 30
	public const uint x = 1U;

	// Token: 0x0400001F RID: 31
	public const uint y = 24U;

	// Token: 0x04000020 RID: 32
	private static string[] z;

	// Token: 0x04000021 RID: 33
	private static string[] aa;

	// Token: 0x04000022 RID: 34
	private static string[] ab;

	// Token: 0x04000023 RID: 35
	private static string[] ac;

	// Token: 0x04000024 RID: 36
	private static string[] ad;

	// Token: 0x02000005 RID: 5
	public enum c
	{
		// Token: 0x04000026 RID: 38
		a = -1,
		// Token: 0x04000027 RID: 39
		b,
		// Token: 0x04000028 RID: 40
		c,
		// Token: 0x04000029 RID: 41
		d,
		// Token: 0x0400002A RID: 42
		e = 25
	}

	// Token: 0x02000006 RID: 6
	public enum b
	{
		// Token: 0x0400002C RID: 44
		a,
		// Token: 0x0400002D RID: 45
		b
	}

	// Token: 0x02000007 RID: 7
	public enum a
	{
		// Token: 0x0400002F RID: 47
		a,
		// Token: 0x04000030 RID: 48
		b,
		// Token: 0x04000031 RID: 49
		c
	}
}
