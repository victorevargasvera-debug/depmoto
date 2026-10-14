using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Motorola.Common.CustomException;

// Token: 0x02000002 RID: 2
internal class CommonSecurity
{
	// Token: 0x06000001 RID: 1 RVA: 0x000020D0 File Offset: 0x000002D0
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
				salt = global::CommonSecurity.ComputeSalt(24U);
			}
			byte[] second = global::CommonSecurity.ComputeSHA256Hash(input, salt);
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

	// Token: 0x06000002 RID: 2 RVA: 0x000021AC File Offset: 0x000003AC
	private static byte[] ComputeSalt(uint length = 24U)
	{
		byte[] array = new byte[length];
		using (global::System.Security.Cryptography.RNGCryptoServiceProvider rngcryptoServiceProvider = new global::System.Security.Cryptography.RNGCryptoServiceProvider())
		{
			rngcryptoServiceProvider.GetBytes(array);
		}
		return array;
	}

	// Token: 0x06000003 RID: 3 RVA: 0x000021FC File Offset: 0x000003FC
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

	// Token: 0x06000004 RID: 4 RVA: 0x00002264 File Offset: 0x00000464
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

	// Token: 0x06000005 RID: 5 RVA: 0x000022C4 File Offset: 0x000004C4
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
			text2 = global::CommonSecurity.ComputeSHA256HashAlgorithm(sha, text2);
		}
		if (text2.Length > 12)
		{
			text2 = text2.Remove(11);
		}
		return text2;
	}

	// Token: 0x06000006 RID: 6 RVA: 0x00002500 File Offset: 0x00000700
	internal static bool isHiddenPwd(string testPwd, string serialNumber)
	{
		if (string.IsNullOrEmpty(serialNumber))
		{
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.COMMON_SECURITY_SERIAL_NUMBER_NULL);
		}
		bool result = false;
		global::System.DateTime date = global::System.DateTime.Now.Date;
		string a = global::CommonSecurity.CalculatePassword(date, serialNumber);
		if (a == testPwd)
		{
			result = true;
		}
		else
		{
			date = global::System.DateTime.Now.AddDays(-1.0);
			a = global::CommonSecurity.CalculatePassword(date, serialNumber);
			if (a == testPwd)
			{
				result = true;
			}
		}
		return result;
	}

	// Token: 0x04000001 RID: 1
	private const uint HASH_ALGORITHM_1 = 1U;

	// Token: 0x04000002 RID: 2
	private const uint HASH_SALT_LENGTH = 24U;
}
