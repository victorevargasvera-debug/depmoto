using System;
using System.Collections.Generic;
using System.Text;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Pba;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication
{
	// Token: 0x0200000C RID: 12
	internal class CodeplugParseHelper
	{
		// Token: 0x0600009E RID: 158 RVA: 0x00005D0C File Offset: 0x00003F0C
		public static bool ReadEncryptPasswordFlag(global::Motorola.Common.Communication.Pba.PbaObject pba)
		{
			global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplugInIshItemCollection = pba.GetCodeplugInIshItemCollection();
			bool result = false;
			if (codeplugInIshItemCollection.Count > 0)
			{
				foreach (global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair in codeplugInIshItemCollection)
				{
					if (keyValuePair.Key.IshType == 903)
					{
						int num = keyValuePair.Value.Data.Length;
						global::Motorola.Common.Communication.CodeplugParseHelper.CalcuateCRC16(keyValuePair.Value.Data, 1, num - 3);
						int num2 = 1;
						int num3 = (int)(keyValuePair.Value.Data[num2] & 1);
						result = (num3 != 0);
						break;
					}
				}
			}
			return result;
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00005DD4 File Offset: 0x00003FD4
		public static string ReadEncryptPassword(global::Motorola.Common.Communication.Pba.PbaObject pba)
		{
			global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplugInIshItemCollection = pba.GetCodeplugInIshItemCollection();
			string result = string.Empty;
			foreach (global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair in codeplugInIshItemCollection)
			{
				if (keyValuePair.Key.IshType == 1150)
				{
					int num = keyValuePair.Value.Data.Length;
					global::Motorola.Common.Communication.CodeplugParseHelper.CalcuateCRC16(keyValuePair.Value.Data, 1, num - 3);
					int sourceIndex = 1;
					int num2 = 48;
					byte[] array = new byte[num2];
					global::System.Array.Copy(keyValuePair.Value.Data, sourceIndex, array, 0, num2);
					result = global::Motorola.Common.Communication.AESCryptoUtil.HEXString(array);
					break;
				}
			}
			return result;
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00005EA8 File Offset: 0x000040A8
		public static string ReadClearPassword(global::Motorola.Common.Communication.Pba.PbaObject pba)
		{
			global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplugInIshItemCollection = pba.GetCodeplugInIshItemCollection();
			string text = string.Empty;
			foreach (global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair in codeplugInIshItemCollection)
			{
				if (keyValuePair.Key.IshType == 1028)
				{
					int num = keyValuePair.Value.Data.Length;
					global::Motorola.Common.Communication.CodeplugParseHelper.CalcuateCRC16(keyValuePair.Value.Data, 1, num - 3);
					int sourceIndex = 103;
					int num2 = 34;
					byte[] array = new byte[num2];
					global::System.Array.Copy(keyValuePair.Value.Data, sourceIndex, array, 0, num2);
					text = global::Motorola.Common.Communication.AESCryptoUtil.HEXString(array);
					sourceIndex = 155;
					byte[] array2 = new byte[num2];
					global::System.Array.Copy(keyValuePair.Value.Data, sourceIndex, array2, 0, num2);
					text += global::Motorola.Common.Communication.AESCryptoUtil.HEXString(array2);
					break;
				}
			}
			return text;
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00005FBC File Offset: 0x000041BC
		public static void UpdateWiFiEncryptPassword(global::Motorola.Common.Communication.Pba.PbaObject pba, byte[] decryptKey, byte[] encryptKey)
		{
			string text = string.Empty;
			int num = 99;
			global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplugInIshItemCollection = pba.GetCodeplugInIshItemCollection();
			foreach (global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair in codeplugInIshItemCollection)
			{
				if (keyValuePair.Key.IshType == 1160 || keyValuePair.Key.IshType == 3676)
				{
					int num2 = keyValuePair.Value.Data.Length;
					global::Motorola.Common.Communication.CodeplugParseHelper.CalcuateCRC16(keyValuePair.Value.Data, 0, num2 - 2);
					int num3;
					int num4;
					if (keyValuePair.Key.IshType == 1160)
					{
						num3 = 19;
						num = ((int)keyValuePair.Value.Data[1] << 8) + (int)keyValuePair.Value.Data[2];
						num4 = ((int)keyValuePair.Value.Data[11] << 8) + (int)keyValuePair.Value.Data[12];
					}
					else
					{
						num3 = 7;
						num4 = ((int)keyValuePair.Value.Data[1] << 8) + (int)keyValuePair.Value.Data[2];
					}
					byte[] array = new byte[64];
					string text2 = string.Empty;
					string hexString = string.Empty;
					for (int i = 0; i < num4; i++)
					{
						global::System.Array.Clear(array, 0, 64);
						global::System.Array.Copy(keyValuePair.Value.Data, num3 + i * num, array, 0, 64);
						text = global::Motorola.Common.Communication.AESCryptoUtil.HEXString(array);
						bool flag = true;
						foreach (char c in text)
						{
							if (c != '0')
							{
								flag = false;
								break;
							}
						}
						if (flag)
						{
							text2 = string.Empty;
						}
						else
						{
							text2 = global::Motorola.Common.Communication.AESCryptoUtil.AESDecrypt_Ex(text, decryptKey, 0, 4);
						}
						if (!global::Motorola.Common.Communication.CodeplugParseHelper.IsValidASCIIPwdString(text2, 63))
						{
							text2 = string.Empty;
						}
						hexString = global::Motorola.Common.Communication.AESCryptoUtil.AESEncrypt_Ex(text2, encryptKey, 0, 4);
						byte[] array2 = global::Motorola.Common.Communication.AESCryptoUtil.HexString2Bytes(hexString);
						if (array2.Length != 64)
						{
							throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentOutOfRange);
						}
						global::System.Array.Copy(array2, 0, keyValuePair.Value.Data, num3 + i * num, 64);
					}
					byte[] data = keyValuePair.Value.Data;
					global::Motorola.Common.Communication.CodeplugParseHelper.UpdateIshItemCRC(ref data, 0, num2 - 2);
				}
			}
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00006248 File Offset: 0x00004448
		public static void UpdateExternalDataModemEncryptPassword(global::Motorola.Common.Communication.Pba.PbaObject pba, byte[] decryptKey, byte[] encryptKey)
		{
			string text = string.Empty;
			global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplugInIshItemCollection = pba.GetCodeplugInIshItemCollection();
			foreach (global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair in codeplugInIshItemCollection)
			{
				if (keyValuePair.Key.IshType == 1027)
				{
					string text2 = string.Empty;
					string text3 = string.Empty;
					int num = keyValuePair.Value.Data.Length;
					if (num < 430)
					{
						break;
					}
					global::Motorola.Common.Communication.CodeplugParseHelper.CalcuateCRC16(keyValuePair.Value.Data, 1, num - 3);
					int num2 = 396;
					int num3 = 33;
					byte[] array = new byte[num3];
					global::System.Array.Copy(keyValuePair.Value.Data, num2, array, 0, num3);
					text = global::Motorola.Common.Communication.AESCryptoUtil.HEXString(array);
					bool flag = true;
					foreach (char c in text)
					{
						if (c != '0')
						{
							flag = false;
							break;
						}
					}
					if (flag)
					{
						text2 = "12345";
					}
					else
					{
						text2 = global::Motorola.Common.Communication.AESCryptoUtil.AESDecrypt_Ex(text, decryptKey, 0, 3);
					}
					if (!global::Motorola.Common.Communication.CodeplugParseHelper.IsValidASCIIPwdString(text2, 32))
					{
						text2 = "12345";
					}
					text3 = global::Motorola.Common.Communication.AESCryptoUtil.AESEncrypt_Ex(text2, encryptKey, 0, 3);
					text3 = text3.Substring(0, 66);
					byte[] sourceArray = global::Motorola.Common.Communication.AESCryptoUtil.HexString2Bytes(text3);
					global::System.Array.Copy(sourceArray, 0, keyValuePair.Value.Data, num2, num3);
					byte[] data = keyValuePair.Value.Data;
					global::Motorola.Common.Communication.CodeplugParseHelper.UpdateIshItemCRC(ref data, 1, num - 3);
					break;
				}
			}
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00006400 File Offset: 0x00004600
		private static bool IsValidASCIIPwdString(string pwd, int length)
		{
			if (pwd.Length > length)
			{
				return false;
			}
			foreach (char c in pwd)
			{
				if (c > '~' || c < ' ')
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00006444 File Offset: 0x00004644
		public static bool IsPINPSWBlockExist(global::Motorola.Common.Communication.Pba.PbaObject pba)
		{
			bool result = false;
			global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplugInIshItemCollection = pba.GetCodeplugInIshItemCollection();
			string empty = string.Empty;
			foreach (global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair in codeplugInIshItemCollection)
			{
				if (keyValuePair.Key.IshType == 1150)
				{
					result = true;
					break;
				}
			}
			return result;
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x000064B0 File Offset: 0x000046B0
		public static void WriteEncryptPassword(global::Motorola.Common.Communication.Pba.PbaObject pbaToWrite, string encryptedPwd)
		{
			global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplugInIshItemCollection = pbaToWrite.GetCodeplugInIshItemCollection();
			string empty = string.Empty;
			foreach (global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair in codeplugInIshItemCollection)
			{
				if (keyValuePair.Key.IshType == 1150)
				{
					int destinationIndex = 1;
					int num = 48;
					int num2 = keyValuePair.Value.Data.Length;
					global::Motorola.Common.Communication.CodeplugParseHelper.CalcuateCRC16(keyValuePair.Value.Data, 1, num2 - 3);
					byte[] array = global::Motorola.Common.Communication.AESCryptoUtil.HexString2Bytes(encryptedPwd);
					if (array.Length != num)
					{
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentOutOfRange);
					}
					global::System.Array.Copy(array, 0, keyValuePair.Value.Data, destinationIndex, num);
					byte[] data = keyValuePair.Value.Data;
					global::Motorola.Common.Communication.CodeplugParseHelper.UpdateIshItemCRC(ref data, 1, num2 - 3);
					break;
				}
			}
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x000065A8 File Offset: 0x000047A8
		public static void WriteClearPassword(global::Motorola.Common.Communication.Pba.PbaObject pbaToWrite, string targetPwdHead, string targetPwdTail)
		{
			global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplugInIshItemCollection = pbaToWrite.GetCodeplugInIshItemCollection();
			string empty = string.Empty;
			foreach (global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair in codeplugInIshItemCollection)
			{
				if (keyValuePair.Key.IshType == 1028)
				{
					int destinationIndex = 103;
					int destinationIndex2 = 155;
					int num = keyValuePair.Value.Data.Length;
					global::Motorola.Common.Communication.CodeplugParseHelper.CalcuateCRC16(keyValuePair.Value.Data, 1, num - 3);
					byte[] bytes = global::System.Text.Encoding.BigEndianUnicode.GetBytes(targetPwdHead);
					byte[] bytes2 = global::System.Text.Encoding.BigEndianUnicode.GetBytes(targetPwdTail);
					if (bytes.Length > 8 || bytes2.Length > 34)
					{
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentOutOfRange);
					}
					global::System.Array.Copy(bytes, 0, keyValuePair.Value.Data, destinationIndex, bytes.Length);
					global::System.Array.Copy(bytes2, 0, keyValuePair.Value.Data, destinationIndex2, bytes2.Length);
					byte[] data = keyValuePair.Value.Data;
					global::Motorola.Common.Communication.CodeplugParseHelper.UpdateIshItemCRC(ref data, 1, num - 3);
					break;
				}
			}
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x000066E0 File Offset: 0x000048E0
		private static void ReadClearPassword(global::Motorola.Common.Communication.Pba.PbaObject pba, out string head, out string tail)
		{
			global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplugInIshItemCollection = pba.GetCodeplugInIshItemCollection();
			head = string.Empty;
			tail = string.Empty;
			foreach (global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair in codeplugInIshItemCollection)
			{
				if (keyValuePair.Key.IshType == 1028)
				{
					int sourceIndex = 103;
					int sourceIndex2 = 155;
					int num = keyValuePair.Value.Data.Length;
					global::Motorola.Common.Communication.CodeplugParseHelper.CalcuateCRC16(keyValuePair.Value.Data, 1, num - 3);
					byte[] array = new byte[global::Motorola.Common.Communication.CodeplugParseHelper.CLEAR_PASSWORD_LEN];
					byte[] array2 = new byte[global::Motorola.Common.Communication.CodeplugParseHelper.CLEAR_PASSWORD_LEN];
					global::System.Array.Copy(keyValuePair.Value.Data, sourceIndex, array, 0, array.Length);
					global::System.Array.Copy(keyValuePair.Value.Data, sourceIndex2, array2, 0, array2.Length);
					string @string = global::System.Text.Encoding.BigEndianUnicode.GetString(array);
					char[] trimChars = new char[1];
					head = @string.TrimEnd(trimChars);
					string string2 = global::System.Text.Encoding.BigEndianUnicode.GetString(array2);
					char[] trimChars2 = new char[1];
					tail = string2.TrimEnd(trimChars2);
					break;
				}
			}
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00006824 File Offset: 0x00004A24
		private static void UpdateIshItemCRC(ref byte[] data, int start, int length)
		{
			int num = data.Length;
			ushort num2 = global::Motorola.Common.Communication.CodeplugParseHelper.CalcuateCRC16(data, start, length);
			data[num - 2] = (byte)(num2 >> 8);
			data[num - 1] = (byte)num2;
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00006854 File Offset: 0x00004A54
		private static ushort CalcuateCRC16(byte[] data, int start, int length)
		{
			uint num = 0U;
			num = (uint)global::Motorola.Common.Communication.RcmpBaseMessage.CalculateCRC16(ref num, data, start, length);
			return (ushort)num;
		}

		// Token: 0x04000021 RID: 33
		private static int CLEAR_PASSWORD_LEN = 34;
	}
}
