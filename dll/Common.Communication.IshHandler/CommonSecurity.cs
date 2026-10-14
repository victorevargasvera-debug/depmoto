using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.IshHandler
{
	// Token: 0x02000007 RID: 7
	internal class CommonSecurity
	{
		// Token: 0x0600003C RID: 60 RVA: 0x00003D54 File Offset: 0x00001F54
		public static string ComputeHash(string input, byte[] salt = null, uint algorithm = 1U)
		{
			if (string.IsNullOrEmpty(input))
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
			}
			if (algorithm == 1U)
			{
				byte[] bytes = global::System.BitConverter.GetBytes(1U);
				if (global::System.BitConverter.IsLittleEndian)
				{
					global::System.Array.Reverse(bytes);
				}
				if (salt == null)
				{
					salt = global::Motorola.Common.Communication.IshHandler.CommonSecurity.ComputeSalt(24U);
				}
				byte[] second = global::Motorola.Common.Communication.IshHandler.CommonSecurity.ComputeSHA256Hash(input, salt);
				global::System.Collections.Generic.IEnumerable<byte> source = bytes.Concat(salt).Concat(second);
				byte[] array = source.ToArray<byte>();
				global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
				for (int i = 0; i < array.Length; i++)
				{
					stringBuilder.Append(array[i].ToString("X2"));
				}
				return stringBuilder.ToString();
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgument);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00003DF8 File Offset: 0x00001FF8
		private static byte[] ComputeSalt(uint length = 24U)
		{
			byte[] array = new byte[length];
			using (global::System.Security.Cryptography.RNGCryptoServiceProvider rngcryptoServiceProvider = new global::System.Security.Cryptography.RNGCryptoServiceProvider())
			{
				rngcryptoServiceProvider.GetBytes(array);
			}
			return array;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00003E38 File Offset: 0x00002038
		private static byte[] ComputeSHA256Hash(string input, byte[] salt)
		{
			global::System.Collections.Generic.IEnumerable<byte> source = salt.Concat(global::System.Text.Encoding.UTF8.GetBytes(input));
			byte[] buffer = source.ToArray<byte>();
			byte[] result = null;
			using (global::System.Security.Cryptography.SHA256 sha = global::System.Security.Cryptography.SHA256.Create())
			{
				result = sha.ComputeHash(buffer);
			}
			return result;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00003E8C File Offset: 0x0000208C
		private static string ComputeSHA256HashAlgorithm(global::System.Security.Cryptography.SHA256 Sha256Hash, string input)
		{
			byte[] array = Sha256Hash.ComputeHash(global::System.Text.Encoding.UTF8.GetBytes(input));
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			for (int i = 0; i < array.Length; i++)
			{
				stringBuilder.Append(array[i].ToString("x2"));
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00003EE0 File Offset: 0x000020E0
		private static string CalculatePassword(global::System.DateTime date, string serialNumber)
		{
			int day = date.Day;
			int month = date.Month;
			int year = date.Year;
			string s = "auEoifgpRieeIjropz1rWo4532Dkwrpw32Fkgper";
			string text = string.Empty;
			string text2 = string.Empty;
			int num = day + month;
			global::System.Text.ASCIIEncoding asciiencoding = new global::System.Text.ASCIIEncoding();
			byte[] bytes = asciiencoding.GetBytes(s);
			byte[] bytes2 = asciiencoding.GetBytes(date.ToString("ddMMyyyy"));
			int length = bytes2.GetLength(0);
			short num2 = 0;
			while ((int)num2 < length)
			{
				if (num >= 40)
				{
					num = day;
				}
				byte b = bytes[num++] ^ bytes2[(int)num2];
				if (b > 32 && b < 127)
				{
					if (b == 48 || b == 49 || b == 73 || b == 79 || b == 108 || b == 111)
					{
						text += 'x';
					}
					else
					{
						text += (char)b;
					}
				}
				num2 += 1;
			}
			byte[] bytes3 = asciiencoding.GetBytes(text);
			int num3 = bytes3.Length;
			for (int i = num3 - 1; i >= 0; i--)
			{
				if (num3 < 6)
				{
					if (i == num3 - 2)
					{
						char c = (char)bytes2[3];
						text2 += c;
					}
					if (i == num3 - 1)
					{
						char c = (char)bytes2[2];
						text2 += c;
					}
				}
				text2 += (char)bytes3[i];
			}
			text2 = serialNumber + text2;
			using (global::System.Security.Cryptography.SHA256 sha = global::System.Security.Cryptography.SHA256.Create())
			{
				text2 = global::Motorola.Common.Communication.IshHandler.CommonSecurity.ComputeSHA256HashAlgorithm(sha, text2);
			}
			if (text2.Length > 12)
			{
				text2 = text2.Remove(11);
			}
			return text2;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00004094 File Offset: 0x00002294
		internal static bool isHiddenPwd(string testPwd, string serialNumber)
		{
			if (string.IsNullOrEmpty(serialNumber))
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.COMMON_SECURITY_SERIAL_NUMBER_NULL);
			}
			bool result = false;
			global::System.DateTime date = global::System.DateTime.Now.Date;
			string a = global::Motorola.Common.Communication.IshHandler.CommonSecurity.CalculatePassword(date, serialNumber);
			if (a == testPwd)
			{
				result = true;
			}
			else
			{
				date = global::System.DateTime.Now.AddDays(-1.0);
				a = global::Motorola.Common.Communication.IshHandler.CommonSecurity.CalculatePassword(date, serialNumber);
				if (a == testPwd)
				{
					result = true;
				}
			}
			return result;
		}

		// Token: 0x04000009 RID: 9
		private const uint HASH_ALGORITHM_1 = 1U;

		// Token: 0x0400000A RID: 10
		private const uint HASH_SALT_LENGTH = 24U;
	}
}
