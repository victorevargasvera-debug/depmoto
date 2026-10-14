using System;
using System.Globalization;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Motorola.Common.Communication
{
	// Token: 0x02000003 RID: 3
	internal class AESCryptoUtil
	{
		// Token: 0x06000005 RID: 5 RVA: 0x000020D0 File Offset: 0x000002D0
		public static string AESEncryptWithDefKey(string plainPwd)
		{
			return global::Motorola.Common.Communication.AESCryptoUtil.AESEncrypt(plainPwd, global::Motorola.Common.Communication.AESCryptoUtil.CIPHER_DEF_KEY);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000020DD File Offset: 0x000002DD
		public static string AESDecryptWithDefKey(string encryptedPwd)
		{
			return global::Motorola.Common.Communication.AESCryptoUtil.AESDecrypt(encryptedPwd, global::Motorola.Common.Communication.AESCryptoUtil.CIPHER_DEF_KEY);
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000020EC File Offset: 0x000002EC
		public static string AESEncrypt(string plainPwd, byte[] cipherKeyBytes)
		{
			if (plainPwd.Length > 24)
			{
				throw new global::Motorola.Common.Communication.EncryptionDecrytionFailedException();
			}
			if (cipherKeyBytes.Length != 8)
			{
				throw new global::Motorola.Common.Communication.EncryptionDecrytionFailedException();
			}
			string text = string.Empty;
			byte[] bytes = global::System.Text.Encoding.Unicode.GetBytes(plainPwd);
			byte[] array = new byte[(int)global::Motorola.Common.Communication.AESCryptoUtil.AES_KEY_LENGTH];
			byte[] array2 = new byte[(int)(global::Motorola.Common.Communication.AESCryptoUtil.AES_KEY_LENGTH * 3)];
			byte[] array3 = new byte[(int)(global::Motorola.Common.Communication.AESCryptoUtil.AES_KEY_LENGTH * 3)];
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i] = global::Motorola.Common.Communication.AESCryptoUtil.PADDING;
			}
			for (int j = 0; j < bytes.Length; j++)
			{
				array2[j] = bytes[j];
			}
			for (int k = 0; k < cipherKeyBytes.Length; k++)
			{
				array[k] = cipherKeyBytes[k];
			}
			global::System.Array.Copy(global::Motorola.Common.Communication.AESCryptoUtil.CIPHER_KEY_APPENDIX, 0, array, 8, 8);
			if (!global::Motorola.Common.Communication.NativeMethods.encrypt_function(array, array2, array3))
			{
				throw new global::Motorola.Common.Communication.EncryptionDecrytionFailedException();
			}
			foreach (byte b in array3)
			{
				text += string.Format("{0:X2}", b);
			}
			return text;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000021FC File Offset: 0x000003FC
		public static string AESDecrypt(string encryptedPwd, byte[] cipherKeyBytes)
		{
			if (encryptedPwd.Length != 96)
			{
				throw new global::Motorola.Common.Communication.EncryptionDecrytionFailedException();
			}
			if (cipherKeyBytes.Length != 8)
			{
				throw new global::Motorola.Common.Communication.EncryptionDecrytionFailedException();
			}
			byte[] array = new byte[(int)global::Motorola.Common.Communication.AESCryptoUtil.AES_KEY_LENGTH];
			byte[] array2 = new byte[(int)(global::Motorola.Common.Communication.AESCryptoUtil.AES_KEY_LENGTH * 3)];
			byte[] encryptedPwd2 = global::Motorola.Common.Communication.AESCryptoUtil.HexString2Bytes(encryptedPwd);
			for (int i = 0; i < cipherKeyBytes.Length; i++)
			{
				array[i] = cipherKeyBytes[i];
			}
			global::System.Array.Copy(global::Motorola.Common.Communication.AESCryptoUtil.CIPHER_KEY_APPENDIX, 0, array, 8, 8);
			if (!global::Motorola.Common.Communication.NativeMethods.decrypt_function(array, encryptedPwd2, array2))
			{
				throw new global::Motorola.Common.Communication.EncryptionDecrytionFailedException();
			}
			string @string = global::System.Text.Encoding.Unicode.GetString(array2);
			return global::Motorola.Common.Communication.AESCryptoUtil.TrimEnd(@string);
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002294 File Offset: 0x00000494
		public static string AESEncryptWithDefKey_ForWiFiPassword(string plainPwd)
		{
			return global::Motorola.Common.Communication.AESCryptoUtil.AESEncrypt_Ex(plainPwd, global::Motorola.Common.Communication.AESCryptoUtil.CIPHER_DEF_KEY, 0, 4);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000022A3 File Offset: 0x000004A3
		public static string AESDecryptWithDefKey_ForWiFiPassword(string encryptedPwd)
		{
			return global::Motorola.Common.Communication.AESCryptoUtil.AESDecrypt_Ex(encryptedPwd, global::Motorola.Common.Communication.AESCryptoUtil.CIPHER_DEF_KEY, 0, 4);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000022B4 File Offset: 0x000004B4
		public static string AESEncrypt_Ex(string plainPwd, byte[] cipherKeyBytes, int encoding, int block_num)
		{
			string text = string.Empty;
			byte[] array = null;
			if (encoding == 0)
			{
				array = global::System.Text.Encoding.ASCII.GetBytes(plainPwd);
			}
			else if (encoding == 1)
			{
				array = global::System.Text.Encoding.Unicode.GetBytes(plainPwd);
			}
			byte[] array2 = new byte[(int)global::Motorola.Common.Communication.AESCryptoUtil.AES_KEY_LENGTH];
			byte[] array3 = new byte[(int)global::Motorola.Common.Communication.AESCryptoUtil.AES_KEY_LENGTH * block_num];
			byte[] array4 = new byte[(int)global::Motorola.Common.Communication.AESCryptoUtil.AES_KEY_LENGTH * block_num];
			for (int i = 0; i < array3.Length; i++)
			{
				array3[i] = global::Motorola.Common.Communication.AESCryptoUtil.PADDING;
			}
			for (int j = 0; j < array.Length; j++)
			{
				array3[j] = array[j];
			}
			for (int k = 0; k < cipherKeyBytes.Length; k++)
			{
				array2[k] = cipherKeyBytes[k];
			}
			global::System.Array.Copy(global::Motorola.Common.Communication.AESCryptoUtil.CIPHER_KEY_APPENDIX, 0, array2, 8, 8);
			if (!global::Motorola.Common.Communication.NativeMethods.encrypt_function_ex(array2, array3, array4, block_num))
			{
				throw new global::Motorola.Common.Communication.EncryptionDecrytionFailedException();
			}
			foreach (byte b in array4)
			{
				text += string.Format("{0:X2}", b);
			}
			return text;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000023C0 File Offset: 0x000005C0
		public static string AESDecrypt_Ex(string encryptedPwd, byte[] cipherKeyBytes, int encoding, int block_num)
		{
			string strPassedIn = string.Empty;
			byte[] array = new byte[(int)global::Motorola.Common.Communication.AESCryptoUtil.AES_KEY_LENGTH];
			byte[] array2 = new byte[(int)global::Motorola.Common.Communication.AESCryptoUtil.AES_KEY_LENGTH * block_num];
			byte[] encryptedPwd2 = global::Motorola.Common.Communication.AESCryptoUtil.HexString2Bytes(encryptedPwd);
			for (int i = 0; i < cipherKeyBytes.Length; i++)
			{
				array[i] = cipherKeyBytes[i];
			}
			global::System.Array.Copy(global::Motorola.Common.Communication.AESCryptoUtil.CIPHER_KEY_APPENDIX, 0, array, 8, 8);
			if (!global::Motorola.Common.Communication.NativeMethods.decrypt_function_ex(array, encryptedPwd2, array2, block_num))
			{
				throw new global::Motorola.Common.Communication.EncryptionDecrytionFailedException();
			}
			if (encoding == 0)
			{
				strPassedIn = global::System.Text.Encoding.ASCII.GetString(array2);
			}
			else if (encoding == 1)
			{
				strPassedIn = global::System.Text.Encoding.Unicode.GetString(array2);
			}
			return global::Motorola.Common.Communication.AESCryptoUtil.TrimEnd(strPassedIn);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002458 File Offset: 0x00000658
		public static string HEXString(byte[] bytes)
		{
			string text = string.Empty;
			foreach (byte b in bytes)
			{
				string str = string.Format("{0:X}", (b & 240) >> 4);
				string str2 = string.Format("{0:X}", (int)(b & 15));
				text = text + str + str2;
			}
			return text;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000024C0 File Offset: 0x000006C0
		public static byte[] HexString2Bytes(string hexString)
		{
			byte[] array = new byte[hexString.Length / 2];
			for (int i = 0; i < hexString.Length; i++)
			{
				array[i / 2] = byte.Parse(hexString.Substring(i, 2), global::System.Globalization.NumberStyles.HexNumber);
				i++;
			}
			return array;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002508 File Offset: 0x00000708
		private static byte[] ASCII2BigEndianUnicodeBytes(byte[] asiiBytes)
		{
			byte[] array = new byte[asiiBytes.Length * 2];
			for (int i = 0; i < asiiBytes.Length; i++)
			{
				array[i * 2] = 0;
				array[i * 2 + 1] = asiiBytes[i];
			}
			return array;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002540 File Offset: 0x00000740
		private static byte[] BigEndianUnicode2ASCIIBytes(byte[] bigEndianUnicodeBytes)
		{
			byte[] array = new byte[bigEndianUnicodeBytes.Length / 2];
			for (int i = 0; i < bigEndianUnicodeBytes.Length; i++)
			{
				array[i / 2] = bigEndianUnicodeBytes[i + 1];
				i++;
			}
			return array;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002578 File Offset: 0x00000778
		private static string TrimEnd(string strPassedIn)
		{
			int num = strPassedIn.IndexOf('\0');
			if (num == 0)
			{
				strPassedIn = "";
			}
			else if (num > 0)
			{
				strPassedIn = strPassedIn.Substring(0, num);
			}
			return strPassedIn;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000025A8 File Offset: 0x000007A8
		private static string EncryptWithDefaultKey(string plainText)
		{
			byte[] bytes = global::System.Text.Encoding.ASCII.GetBytes(plainText);
			byte[] asiiBytes = global::Motorola.Common.Communication.AESCryptoUtil.Encrypt(bytes, global::Motorola.Common.Communication.AESCryptoUtil.DefKey, global::Motorola.Common.Communication.AESCryptoUtil.DefIV);
			byte[] bytes2 = global::Motorola.Common.Communication.AESCryptoUtil.ASCII2BigEndianUnicodeBytes(asiiBytes);
			return global::System.Text.Encoding.BigEndianUnicode.GetString(bytes2);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000025E4 File Offset: 0x000007E4
		private static string DecryptWithDefaultKey(string cipherText)
		{
			byte[] bytes = global::System.Text.Encoding.BigEndianUnicode.GetBytes(cipherText);
			byte[] cipher_Text = global::Motorola.Common.Communication.AESCryptoUtil.BigEndianUnicode2ASCIIBytes(bytes);
			byte[] bytes2 = global::Motorola.Common.Communication.AESCryptoUtil.Decrypt(cipher_Text, global::Motorola.Common.Communication.AESCryptoUtil.DefKey, global::Motorola.Common.Communication.AESCryptoUtil.DefIV);
			return global::System.Text.Encoding.ASCII.GetString(bytes2);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002620 File Offset: 0x00000820
		private static string Encrypt(string plainText, string key)
		{
			byte[] bytes = global::System.Text.Encoding.ASCII.GetBytes(plainText);
			byte[] asiiBytes = global::Motorola.Common.Communication.AESCryptoUtil.Encrypt(bytes, global::System.Text.Encoding.ASCII.GetBytes(key), global::Motorola.Common.Communication.AESCryptoUtil.DefIV);
			byte[] bytes2 = global::Motorola.Common.Communication.AESCryptoUtil.ASCII2BigEndianUnicodeBytes(asiiBytes);
			return global::System.Text.Encoding.BigEndianUnicode.GetString(bytes2);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002664 File Offset: 0x00000864
		private static string Decrypt(string cipherText, string key)
		{
			byte[] bytes = global::System.Text.Encoding.BigEndianUnicode.GetBytes(cipherText);
			byte[] cipher_Text = global::Motorola.Common.Communication.AESCryptoUtil.BigEndianUnicode2ASCIIBytes(bytes);
			byte[] bytes2 = global::Motorola.Common.Communication.AESCryptoUtil.Decrypt(cipher_Text, global::System.Text.Encoding.ASCII.GetBytes(key), global::Motorola.Common.Communication.AESCryptoUtil.DefIV);
			return global::System.Text.Encoding.ASCII.GetString(bytes2);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000026A8 File Offset: 0x000008A8
		private static byte[] Encrypt(byte[] plain_Bytes, byte[] Key, byte[] IV)
		{
			byte[] result = null;
			global::System.Security.Cryptography.RijndaelManaged rijndaelManaged = null;
			try
			{
				rijndaelManaged = new global::System.Security.Cryptography.RijndaelManaged();
				rijndaelManaged.KeySize = 128;
				rijndaelManaged.BlockSize = 128;
				rijndaelManaged.Key = Key;
				rijndaelManaged.IV = IV;
				using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream())
				{
					global::System.Security.Cryptography.ICryptoTransform transform = rijndaelManaged.CreateEncryptor(rijndaelManaged.Key, rijndaelManaged.IV);
					using (global::System.Security.Cryptography.CryptoStream cryptoStream = new global::System.Security.Cryptography.CryptoStream(memoryStream, transform, global::System.Security.Cryptography.CryptoStreamMode.Write))
					{
						cryptoStream.Write(plain_Bytes, 0, plain_Bytes.Length);
						result = memoryStream.ToArray();
					}
				}
				rijndaelManaged.Dispose();
				rijndaelManaged = null;
			}
			catch (global::System.Exception)
			{
				throw;
			}
			finally
			{
				if (rijndaelManaged != null)
				{
					rijndaelManaged.Dispose();
					rijndaelManaged.Clear();
				}
			}
			return result;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x0000278C File Offset: 0x0000098C
		private static byte[] Decrypt(byte[] Cipher_Text, byte[] Key, byte[] IV)
		{
			global::System.Security.Cryptography.RijndaelManaged rijndaelManaged = null;
			byte[] result;
			try
			{
				rijndaelManaged = new global::System.Security.Cryptography.RijndaelManaged();
				rijndaelManaged.KeySize = 128;
				rijndaelManaged.BlockSize = 128;
				rijndaelManaged.Key = Key;
				rijndaelManaged.IV = IV;
				using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream())
				{
					global::System.Security.Cryptography.ICryptoTransform transform = rijndaelManaged.CreateDecryptor(rijndaelManaged.Key, rijndaelManaged.IV);
					global::System.Security.Cryptography.CryptoStream cryptoStream = new global::System.Security.Cryptography.CryptoStream(memoryStream, transform, global::System.Security.Cryptography.CryptoStreamMode.Write);
					cryptoStream.Write(Cipher_Text, 0, Cipher_Text.Length);
					cryptoStream.Close();
					result = memoryStream.ToArray();
				}
			}
			catch (global::System.Exception)
			{
				throw;
			}
			finally
			{
				if (rijndaelManaged != null)
				{
					rijndaelManaged.Dispose();
					rijndaelManaged.Clear();
				}
			}
			return result;
		}

		// Token: 0x04000001 RID: 1
		public static readonly byte[] CIPHER_DEF_KEY = new byte[]
		{
			65,
			66,
			67,
			68,
			49,
			50,
			51,
			52
		};

		// Token: 0x04000002 RID: 2
		private static readonly byte[] CIPHER_KEY_APPENDIX = new byte[]
		{
			77,
			111,
			116,
			45,
			83,
			111,
			108,
			115
		};

		// Token: 0x04000003 RID: 3
		private static readonly byte PADDING = 0;

		// Token: 0x04000004 RID: 4
		private static readonly byte AES_KEY_LENGTH = 16;

		// Token: 0x04000005 RID: 5
		private static byte[] DefIV = new byte[]
		{
			byte.MaxValue,
			byte.MaxValue,
			byte.MaxValue,
			byte.MaxValue,
			byte.MaxValue,
			byte.MaxValue,
			byte.MaxValue,
			byte.MaxValue,
			byte.MaxValue,
			byte.MaxValue,
			byte.MaxValue,
			byte.MaxValue,
			byte.MaxValue,
			byte.MaxValue,
			byte.MaxValue,
			byte.MaxValue
		};

		// Token: 0x04000006 RID: 6
		private static byte[] DefKey = new byte[]
		{
			147,
			139,
			37,
			218,
			206,
			157,
			180,
			241,
			240,
			190,
			76,
			50,
			147,
			223,
			44,
			41
		};
	}
}
