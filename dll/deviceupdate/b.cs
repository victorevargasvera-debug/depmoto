using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Motorola.Common.CustomException;

// Token: 0x02000003 RID: 3
internal class b
{
	// Token: 0x06000004 RID: 4 RVA: 0x0000211C File Offset: 0x0000111C
	public static string a(string A_0, byte[] A_1 = null, uint A_2 = 1U)
	{
		switch (0)
		{
		default:
		{
			int num = 6;
			global::System.Text.StringBuilder stringBuilder;
			for (;;)
			{
				byte[] bytes;
				byte[] array;
				switch (num)
				{
				case 0:
					goto IL_121;
				case 1:
					if (A_2 == 1U)
					{
						num = 4;
						continue;
					}
					goto IL_6F;
				case 2:
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
						stringBuilder = new global::System.Text.StringBuilder();
						int num2 = 0;
						num = 0;
						continue;
					}
					}
					break;
				case 3:
					goto IL_197;
				case 4:
					bytes = global::System.BitConverter.GetBytes(1U);
					num = 9;
					continue;
				case 5:
					goto IL_6D;
				case 7:
					if (A_1 == null)
					{
						num = 14;
						continue;
					}
					goto IL_197;
				case 8:
					goto IL_121;
				case 9:
					if (global::System.BitConverter.IsLittleEndian)
					{
						num = 10;
						continue;
					}
					goto IL_145;
				case 10:
					global::System.Array.Reverse(bytes);
					num = 12;
					continue;
				case 11:
				{
					int num2;
					if (num2 >= array.Length)
					{
						num = 13;
						continue;
					}
					stringBuilder.Append(array[num2].ToString("X2"));
					num2++;
					num = 8;
					continue;
				}
				case 12:
					goto IL_145;
				case 13:
					goto IL_140;
				case 14:
					A_1 = global::b.a(24U);
					num = 3;
					continue;
				}
				IL_5C:
				if (string.IsNullOrEmpty(A_0))
				{
					num = 5;
					continue;
				}
				array = null;
				if (true)
				{
				}
				num = 1;
				continue;
				goto IL_5C;
				IL_121:
				num = 11;
				continue;
				IL_145:
				num = 7;
				continue;
				IL_197:
				byte[] second = global::b.a(A_0, A_1);
				global::System.Collections.Generic.IEnumerable<byte> source = bytes.Concat(A_1).Concat(second);
				array = source.ToArray<byte>();
				num = 2;
			}
			IL_6D:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
			IL_6F:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgument);
			IL_140:
			return stringBuilder.ToString();
		}
		}
	}

	// Token: 0x06000005 RID: 5 RVA: 0x0000230C File Offset: 0x0000130C
	private static byte[] a(uint A_0 = 24U)
	{
		byte[] array = new byte[A_0];
		global::System.Security.Cryptography.RNGCryptoServiceProvider rngcryptoServiceProvider = new global::System.Security.Cryptography.RNGCryptoServiceProvider();
		try
		{
			if (true)
			{
			}
			rngcryptoServiceProvider.GetBytes(array);
		}
		finally
		{
			int num = 0;
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
						break;
					}
					break;
				case 1:
					((global::System.IDisposable)rngcryptoServiceProvider).Dispose();
					num = 2;
					continue;
				case 2:
					goto IL_74;
				}
				if (rngcryptoServiceProvider == null)
				{
					break;
				}
				num = 1;
			}
			IL_74:;
		}
		return array;
	}

	// Token: 0x06000006 RID: 6 RVA: 0x000023AC File Offset: 0x000013AC
	private static byte[] a(string A_0, byte[] A_1)
	{
		switch (0)
		{
		default:
		{
			global::System.Collections.Generic.IEnumerable<byte> source = A_1.Concat(global::System.Text.Encoding.UTF8.GetBytes(A_0));
			byte[] buffer = source.ToArray<byte>();
			byte[] result = null;
			global::System.Security.Cryptography.SHA256 sha = global::System.Security.Cryptography.SHA256.Create();
			try
			{
				result = sha.ComputeHash(buffer);
			}
			finally
			{
				int num = 2;
				for (;;)
				{
					switch (num)
					{
					case 0:
						goto IL_92;
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
							((global::System.IDisposable)sha).Dispose();
							break;
						}
						num = 0;
						continue;
					}
					if (sha == null)
					{
						break;
					}
					num = 1;
				}
				IL_92:;
			}
			if (true)
			{
			}
			return result;
		}
		}
	}

	// Token: 0x06000007 RID: 7 RVA: 0x00002474 File Offset: 0x00001474
	private static string a(global::System.Security.Cryptography.SHA256 A_0, string A_1)
	{
		global::System.Text.StringBuilder stringBuilder;
		for (;;)
		{
			for (;;)
			{
				byte[] array = A_0.ComputeHash(global::System.Text.Encoding.UTF8.GetBytes(A_1));
				stringBuilder = new global::System.Text.StringBuilder();
				int num = 0;
				int num2 = 0;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_3C;
					case 1:
						goto IL_52;
					case 2:
						if (num >= array.Length)
						{
							num2 = 1;
							continue;
						}
						stringBuilder.Append(array[num].ToString("x2"));
						num++;
						if (true)
						{
						}
						num2 = 3;
						continue;
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
							goto IL_3C;
						}
						break;
					}
					break;
					IL_3C:
					num2 = 2;
				}
			}
		}
		IL_52:
		return stringBuilder.ToString();
	}

	// Token: 0x06000008 RID: 8 RVA: 0x00002530 File Offset: 0x00001530
	private static string a(global::System.DateTime A_0, string A_1)
	{
		switch (0)
		{
		default:
		{
			string text2;
			for (;;)
			{
				int day = A_0.Day;
				int month = A_0.Month;
				int year = A_0.Year;
				string s = "auEoifgpRieeIjropz1rWo4532Dkwrpw32Fkgper";
				string text = string.Empty;
				text2 = string.Empty;
				int num = day + month;
				global::System.Text.ASCIIEncoding asciiencoding = new global::System.Text.ASCIIEncoding();
				byte[] bytes = asciiencoding.GetBytes(s);
				byte[] bytes2 = asciiencoding.GetBytes(A_0.ToString("ddMMyyyy"));
				int length = bytes2.GetLength(0);
				short num2 = 0;
				int num3 = 8;
				for (;;)
				{
					byte[] bytes3;
					int num5;
					byte b;
					switch (num3)
					{
					case 0:
						num3 = 30;
						continue;
					case 1:
						goto IL_415;
					case 2:
						goto IL_455;
					case 3:
					{
						bytes3 = asciiencoding.GetBytes(text);
						int num4 = bytes3.Length;
						num5 = num4 - 1;
						num3 = 35;
						continue;
					}
					case 4:
						num3 = 32;
						continue;
					case 5:
						if (b != 108)
						{
							num3 = 9;
							continue;
						}
						goto IL_2F2;
					case 6:
						if ((int)num2 >= length)
						{
							num3 = 3;
							continue;
						}
						num3 = 15;
						continue;
					case 7:
						if (b < 127)
						{
							num3 = 34;
							continue;
						}
						goto IL_415;
					case 8:
						goto IL_216;
					case 9:
						num3 = 31;
						continue;
					case 10:
						return text2;
					case 11:
						goto IL_415;
					case 12:
						try
						{
							global::System.Security.Cryptography.SHA256 sha;
							text2 = global::b.a(sha, text2);
							goto IL_4B1;
						}
						finally
						{
							num3 = 1;
							for (;;)
							{
								global::System.Security.Cryptography.SHA256 sha;
								switch (num3)
								{
								case 0:
									((global::System.IDisposable)sha).Dispose();
									goto IL_2CA;
								case 2:
									goto IL_2D3;
								}
								switch ((1 == 1) ? 1 : 0)
								{
								case 0:
								case 2:
									IL_2CA:
									num3 = 2;
									break;
								default:
									if (false)
									{
									}
									if (sha == null)
									{
										goto IL_2D5;
									}
									num3 = 0;
									break;
								}
							}
							IL_2D3:
							IL_2D5:;
						}
						goto IL_2D6;
						IL_4B1:
						num3 = 38;
						continue;
					case 13:
						num3 = 7;
						continue;
					case 14:
						goto IL_132;
					case 15:
						if (num >= 40)
						{
							num3 = 25;
							continue;
						}
						goto IL_455;
					case 16:
						goto IL_216;
					case 17:
					{
						char c = (char)bytes2[3];
						text2 += c;
						num3 = 14;
						continue;
					}
					case 18:
					{
						int num4;
						if (num4 < 6)
						{
							num3 = 23;
							continue;
						}
						goto IL_3D2;
					}
					case 19:
					{
						int num4;
						if (num5 == num4 - 2)
						{
							num3 = 17;
							continue;
						}
						goto IL_132;
					}
					case 20:
						num3 = 22;
						continue;
					case 21:
						if (b != 48)
						{
							num3 = 0;
							continue;
						}
						goto IL_2F2;
					case 22:
						if (true)
						{
						}
						if (b != 73)
						{
							num3 = 4;
							continue;
						}
						goto IL_2F2;
					case 23:
						num3 = 19;
						continue;
					case 24:
						goto IL_3AD;
					case 25:
						num = day;
						num3 = 2;
						continue;
					case 26:
					{
						int num4;
						if (num5 == num4 - 1)
						{
							num3 = 36;
							continue;
						}
						goto IL_3D2;
					}
					case 27:
						if (num5 < 0)
						{
							num3 = 40;
							continue;
						}
						num3 = 18;
						continue;
					case 28:
						goto IL_2D6;
					case 29:
						goto IL_2F2;
					case 30:
						if (b != 49)
						{
							num3 = 20;
							continue;
						}
						goto IL_2F2;
					case 31:
						if (b == 111)
						{
							num3 = 29;
							continue;
						}
						text += (char)b;
						num3 = 11;
						continue;
					case 32:
						if (b != 79)
						{
							num3 = 39;
							continue;
						}
						goto IL_2F2;
					case 33:
						goto IL_3D2;
					case 34:
						num3 = 21;
						continue;
					case 35:
						goto IL_3AD;
					case 36:
					{
						char c = (char)bytes2[2];
						text2 += c;
						num3 = 33;
						continue;
					}
					case 37:
						if (b > 32)
						{
							num3 = 13;
							continue;
						}
						goto IL_415;
					case 38:
						if (text2.Length > 12)
						{
							num3 = 28;
							continue;
						}
						return text2;
					case 39:
						num3 = 5;
						continue;
					case 40:
					{
						text2 = A_1 + text2;
						global::System.Security.Cryptography.SHA256 sha = global::System.Security.Cryptography.SHA256.Create();
						num3 = 12;
						continue;
					}
					}
					break;
					IL_132:
					num3 = 26;
					continue;
					IL_216:
					num3 = 6;
					continue;
					IL_2D6:
					text2 = text2.Remove(11);
					num3 = 10;
					continue;
					IL_2F2:
					text += 'x';
					num3 = 1;
					continue;
					IL_3AD:
					num3 = 27;
					continue;
					IL_3D2:
					text2 += (char)bytes3[num5];
					num5--;
					num3 = 24;
					continue;
					IL_415:
					num2 += 1;
					num3 = 16;
					continue;
					IL_455:
					b = (bytes[num++] ^ bytes2[(int)num2]);
					num3 = 37;
				}
			}
			return text2;
		}
		}
	}

	// Token: 0x06000009 RID: 9 RVA: 0x00002A88 File Offset: 0x00001A88
	internal static bool a(string A_0, string A_1)
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
					goto IL_54;
				case 1:
				{
					bool result;
					return result;
				}
				case 2:
				{
					bool result = true;
					num = 1;
					continue;
				}
				case 3:
				{
					string text;
					if (text == A_0)
					{
						num = 6;
						continue;
					}
					if (true)
					{
					}
					global::System.DateTime a_ = global::System.DateTime.Now.AddDays(-1.0);
					text = global::b.a(a_, A_1);
					goto IL_7E;
				}
				case 5:
				{
					string text;
					if (text == A_0)
					{
						num = 2;
						continue;
					}
					bool result;
					return result;
				}
				case 6:
				{
					bool result = true;
					num = 7;
					continue;
				}
				case 7:
				{
					bool result;
					return result;
				}
				}
				if (string.IsNullOrEmpty(A_1))
				{
					num = 0;
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
					bool result = false;
					global::System.DateTime a_ = global::System.DateTime.Now.Date;
					string text = global::b.a(a_, A_1);
					num = 3;
					continue;
				}
				}
				IL_7E:
				num = 5;
			}
			IL_54:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.COMMON_SECURITY_SERIAL_NUMBER_NULL);
		}
		}
	}

	// Token: 0x04000003 RID: 3
	private const uint a = 1U;

	// Token: 0x04000004 RID: 4
	private const uint b = 24U;
}
