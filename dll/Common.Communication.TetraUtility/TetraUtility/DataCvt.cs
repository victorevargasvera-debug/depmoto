using System;
using System.Text;

namespace Motorola.Common.Communication.TetraUtility
{
	// Token: 0x02000086 RID: 134
	public static class DataCvt
	{
		// Token: 0x06000338 RID: 824 RVA: 0x00011138 File Offset: 0x0000F338
		public static string GetString(object val)
		{
			string result = string.Empty;
			if (val != null)
			{
				global::System.Array array = val as global::System.Array;
				if (array != null)
				{
					result = global::Motorola.Common.Communication.TetraUtility.DataCvt.GetArrayString(array);
				}
				else
				{
					result = val.ToString();
				}
			}
			return result;
		}

		// Token: 0x06000339 RID: 825 RVA: 0x0001116C File Offset: 0x0000F36C
		public static bool IsArrayEquals(global::System.Array array1, global::System.Array array2)
		{
			if (!object.ReferenceEquals(array1.GetType(), array2.GetType()))
			{
				return false;
			}
			if (array1.GetLength(0) != array2.GetLength(0))
			{
				return false;
			}
			for (int i = 0; i < array1.GetLength(0); i++)
			{
				object value = array1.GetValue(i);
				object value2 = array2.GetValue(i);
				if (value == null && value2 == null)
				{
					return true;
				}
				if ((value == null && value2 != null) || (value != null && value2 == null))
				{
					return false;
				}
				if (!value.Equals(value2))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600033A RID: 826 RVA: 0x000111E4 File Offset: 0x0000F3E4
		public static uint HexStringToDec(string sHex)
		{
			uint num = 0U;
			int length = sHex.Length;
			for (int i = 0; i < length; i++)
			{
				uint num2 = (uint)global::Motorola.Common.Communication.TetraUtility.DataCvt.HexCharToInt(global::System.Convert.ToChar(sHex.Substring(i, 1)));
				num += num2 * global::System.Convert.ToUInt32(global::System.Math.Pow(16.0, (double)(length - 1 - i)));
			}
			return num;
		}

		// Token: 0x0600033B RID: 827 RVA: 0x00011238 File Offset: 0x0000F438
		public static string ConvertDecToHexString(ulong ulVal, int length)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			ulong num = ulVal;
			int num2 = 1;
			do
			{
				int num3 = (int)global::System.Math.Pow(16.0, (double)num2);
				int iInt = (int)num % num3;
				char value = global::Motorola.Common.Communication.TetraUtility.DataCvt.IntToHexChar(iInt);
				stringBuilder.Insert(0, value);
				num /= (ulong)((long)num3);
			}
			while (num != 0UL);
			for (int i = 0; i < length - stringBuilder.ToString().Length; i++)
			{
				stringBuilder.Insert(0, '0');
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0600033C RID: 828 RVA: 0x000112B0 File Offset: 0x0000F4B0
		public static void ConvertHexStringToByteArray(string shex, out byte[] bDB)
		{
			bDB = new byte[shex.Length / 2];
			for (int i = 0; i < shex.Length / 2; i++)
			{
				string sHex = shex.Substring(i * 2, 2);
				byte b;
				global::Motorola.Common.Communication.TetraUtility.DataCvt.CvtHexstringToAByte(sHex, out b);
				bDB[i] = b;
			}
		}

		// Token: 0x0600033D RID: 829 RVA: 0x000112F8 File Offset: 0x0000F4F8
		public static string ConvertByteArrayToHexString(byte[] bBCD)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			try
			{
				for (int i = 0; i < bBCD.Length; i++)
				{
					int num = (int)(bBCD[i] / 16);
					char c = global::Motorola.Common.Communication.TetraUtility.DataCvt.IntToHexChar(num);
					int iInt = (int)bBCD[i] - num * 16;
					char c2 = global::Motorola.Common.Communication.TetraUtility.DataCvt.IntToHexChar(iInt);
					stringBuilder.Append(c.ToString()).Append(c2.ToString());
				}
			}
			catch
			{
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException("error");
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0600033E RID: 830 RVA: 0x00011378 File Offset: 0x0000F578
		public static void ConvertNum2ByteArray(object value, byte[] legacyArray)
		{
			byte[] bytes = global::System.BitConverter.GetBytes(global::System.Convert.ToInt64(value));
			if (global::System.BitConverter.IsLittleEndian)
			{
				global::System.Array.Reverse(bytes);
			}
			global::Motorola.Common.Communication.TetraUtility.DataCvt.CopyArray(legacyArray, bytes);
		}

		// Token: 0x0600033F RID: 831 RVA: 0x000113A8 File Offset: 0x0000F5A8
		public static object ConvertByteArray2Num(byte[] byteArray, global::System.Type legacyType)
		{
			byteArray = (byteArray.Clone() as byte[]);
			if (global::System.BitConverter.IsLittleEndian)
			{
				global::System.Array.Reverse(byteArray);
			}
			if (legacyType == typeof(byte))
			{
				if (byteArray.Length == 0)
				{
					return 0;
				}
				return byteArray[byteArray.Length - 1];
			}
			else if (legacyType == typeof(sbyte))
			{
				if (byteArray.Length == 0)
				{
					return 0;
				}
				return (sbyte)byteArray[byteArray.Length - 1];
			}
			else
			{
				if (legacyType == typeof(short))
				{
					int startIndex = (byteArray.Length <= 2) ? 0 : (byteArray.Length - 2);
					return global::System.BitConverter.ToInt16(byteArray, startIndex);
				}
				if (legacyType == typeof(ushort))
				{
					int startIndex2 = (byteArray.Length <= 2) ? 0 : (byteArray.Length - 2);
					return global::System.BitConverter.ToUInt16(byteArray, startIndex2);
				}
				if (legacyType == typeof(int))
				{
					int startIndex3 = (byteArray.Length <= 4) ? 0 : (byteArray.Length - 4);
					return global::System.BitConverter.ToInt32(byteArray, startIndex3);
				}
				if (legacyType == typeof(uint))
				{
					int startIndex4 = (byteArray.Length <= 4) ? 0 : (byteArray.Length - 4);
					return global::System.BitConverter.ToUInt32(byteArray, startIndex4);
				}
				if (legacyType == typeof(long))
				{
					int startIndex5 = (byteArray.Length <= 8) ? 0 : (byteArray.Length - 8);
					return global::System.BitConverter.ToInt64(byteArray, startIndex5);
				}
				if (legacyType == typeof(ulong))
				{
					int startIndex6 = (byteArray.Length <= 8) ? 0 : (byteArray.Length - 8);
					return global::System.BitConverter.ToUInt64(byteArray, startIndex6);
				}
				return null;
			}
		}

		// Token: 0x06000340 RID: 832 RVA: 0x0001153F File Offset: 0x0000F73F
		private static void CopyArray(byte[] destArray, byte[] sourceArray)
		{
			if (sourceArray.Length == 0)
			{
				return;
			}
			if (destArray.Length > sourceArray.Length)
			{
				global::System.Array.Copy(sourceArray, 0, destArray, 0, sourceArray.Length);
				return;
			}
			global::System.Array.Copy(sourceArray, sourceArray.Length - destArray.Length, destArray, 0, destArray.Length);
		}

		// Token: 0x06000341 RID: 833 RVA: 0x00011570 File Offset: 0x0000F770
		private static string GetArrayString(global::System.Array array)
		{
			byte[] array2 = array as byte[];
			if (array2 != null)
			{
				return "0X" + global::Motorola.Common.Communication.TetraUtility.DataCvt.ConvertByteArrayToHexString(array2);
			}
			string text = "{";
			foreach (object obj in array)
			{
				global::System.Array array3 = obj as global::System.Array;
				if (array3 != null)
				{
					text += global::Motorola.Common.Communication.TetraUtility.DataCvt.GetArrayString(array3);
				}
				else
				{
					text += obj.ToString();
				}
				text += ',';
			}
			text += "}";
			return text;
		}

		// Token: 0x06000342 RID: 834 RVA: 0x00011624 File Offset: 0x0000F824
		private static int HexCharToInt(char cHex)
		{
			char c = global::System.Convert.ToChar(cHex.ToString().ToUpperInvariant());
			int result;
			if (char.IsDigit(c))
			{
				result = (int)global::System.Convert.ToInt16(c.ToString());
			}
			else if (cHex >= 'A' && cHex <= 'F')
			{
				int num = (int)global::System.Convert.ToInt16(cHex);
				result = num - 65 + 10;
			}
			else
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x06000343 RID: 835 RVA: 0x00011678 File Offset: 0x0000F878
		private static char IntToHexChar(int iInt)
		{
			char result = '\0';
			try
			{
				if (iInt > 15 || iInt < 0)
				{
					iInt = 0;
				}
				if (iInt >= 0 && iInt <= 9)
				{
					result = iInt.ToString()[0];
				}
				else
				{
					int num = 65;
					num = num + iInt - 10;
					result = global::System.Convert.ToChar(num);
				}
			}
			catch
			{
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException("Data Convert error");
			}
			return result;
		}

		// Token: 0x06000344 RID: 836 RVA: 0x000116DC File Offset: 0x0000F8DC
		private static void CvtHexstringToAByte(string sHex, out byte byteValue)
		{
			int num = 0;
			try
			{
				int length = sHex.Length;
				int i = length - 1;
				while (i >= 0)
				{
					char c = sHex[i];
					if (!c.Equals('X') && !c.Equals('x'))
					{
						char c2 = c;
						int num2;
						switch (c2)
						{
						case 'A':
							goto IL_85;
						case 'B':
							goto IL_8A;
						case 'C':
							goto IL_8F;
						case 'D':
							goto IL_94;
						case 'E':
							goto IL_99;
						case 'F':
							goto IL_9E;
						default:
							switch (c2)
							{
							case 'a':
								goto IL_85;
							case 'b':
								goto IL_8A;
							case 'c':
								goto IL_8F;
							case 'd':
								goto IL_94;
							case 'e':
								goto IL_99;
							case 'f':
								goto IL_9E;
							default:
								num2 = (int)(c - '0');
								break;
							}
							break;
						}
						IL_A9:
						num += (int)global::System.Math.Pow(16.0, (double)(length - i - 1)) * num2;
						i--;
						continue;
						IL_85:
						num2 = 10;
						goto IL_A9;
						IL_8A:
						num2 = 11;
						goto IL_A9;
						IL_8F:
						num2 = 12;
						goto IL_A9;
						IL_94:
						num2 = 13;
						goto IL_A9;
						IL_99:
						num2 = 14;
						goto IL_A9;
						IL_9E:
						num2 = 15;
						goto IL_A9;
					}
					break;
				}
			}
			catch
			{
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException("Data Convert error");
			}
			byteValue = (byte)num;
		}

		// Token: 0x06000345 RID: 837 RVA: 0x000117DC File Offset: 0x0000F9DC
		public static int CvtByteArray2Integer(byte[] uiCPValue, bool bBigEndian)
		{
			int num = 0;
			try
			{
				int num2 = uiCPValue.Length;
				if (bBigEndian)
				{
					for (int i = 0; i < num2; i++)
					{
						int num3 = (int)uiCPValue[i];
						num += (int)global::System.Math.Pow(256.0, (double)(num2 - i - 1)) * num3;
					}
				}
				else
				{
					for (int j = num2 - 1; j >= 0; j--)
					{
						int num4 = (int)uiCPValue[j];
						num += (int)global::System.Math.Pow(256.0, (double)j) * num4;
					}
				}
			}
			catch
			{
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException("Data Convert error");
			}
			return num;
		}

		// Token: 0x06000346 RID: 838 RVA: 0x00011870 File Offset: 0x0000FA70
		public static byte[] CvtInt2ByteArray(int iCPValue, int iLength, bool bBigEndian)
		{
			byte[] array = new byte[iLength];
			checked
			{
				try
				{
					for (int i = iLength - 1; i >= 0; i--)
					{
						int num;
						if (bBigEndian)
						{
							num = iCPValue / (int)global::System.Math.Pow(256.0, (double)i);
							iCPValue -= num * (int)global::System.Math.Pow(256.0, (double)i);
						}
						else
						{
							num = iCPValue - iCPValue / 256 * 256;
							iCPValue /= 256;
						}
						array[iLength - 1 - i] = (byte)num;
					}
				}
				catch
				{
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException("Data Convert error");
				}
				return array;
			}
		}

		// Token: 0x06000347 RID: 839 RVA: 0x00011908 File Offset: 0x0000FB08
		public static byte[] CvtULong2ByteArray(ulong lCPValue, int iLength, bool bBigEndian)
		{
			byte[] array = new byte[iLength];
			checked
			{
				try
				{
					for (int i = iLength - 1; i >= 0; i--)
					{
						ulong num;
						if (bBigEndian)
						{
							num = lCPValue / (ulong)global::System.Math.Pow(256.0, (double)i);
							lCPValue -= num * (ulong)global::System.Math.Pow(256.0, (double)i);
						}
						else
						{
							num = lCPValue - lCPValue / 256UL * 256UL;
							lCPValue /= 256UL;
						}
						array[iLength - 1 - i] = (byte)num;
					}
				}
				catch
				{
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException("Data Convert error");
				}
				return array;
			}
		}

		// Token: 0x06000348 RID: 840 RVA: 0x000119A4 File Offset: 0x0000FBA4
		public static ulong CvtByteArray2UInt64(byte[] uiCPValue, bool bBigEndian)
		{
			ulong num = 0UL;
			try
			{
				int num2 = uiCPValue.Length;
				if (bBigEndian)
				{
					for (int i = 0; i < num2; i++)
					{
						ulong num3 = (ulong)uiCPValue[i];
						num += (ulong)global::System.Math.Pow(256.0, (double)(num2 - i - 1)) * num3;
					}
				}
				else
				{
					for (int j = num2 - 1; j >= 0; j--)
					{
						ulong num4 = (ulong)uiCPValue[j];
						num += (ulong)global::System.Math.Pow(256.0, (double)j) * num4;
					}
				}
			}
			catch
			{
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException("Data Convert error");
			}
			return num;
		}

		// Token: 0x06000349 RID: 841 RVA: 0x00011A38 File Offset: 0x0000FC38
		public static string CvtByteArray2String(byte[] arCPValue)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Remove(0, stringBuilder.Length);
			int num = 0;
			while (num < arCPValue.Length && arCPValue[num] != 0)
			{
				char value = (char)arCPValue[num];
				stringBuilder.Append(value);
				num++;
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0600034A RID: 842 RVA: 0x00011A80 File Offset: 0x0000FC80
		public static byte[] CvtString2ByteArray(string sGUIValue, int iLength)
		{
			byte[] array = new byte[iLength];
			for (int i = 0; i < iLength; i++)
			{
				char c;
				if (i < sGUIValue.Length)
				{
					c = sGUIValue[i];
				}
				else
				{
					c = '\0';
				}
				array[i] = (byte)c;
			}
			return array;
		}

		// Token: 0x0600034B RID: 843 RVA: 0x00011ABC File Offset: 0x0000FCBC
		public static byte[] CvtBCD2ByteArray(string sBCDText, int iLength)
		{
			byte[] array = new byte[iLength];
			checked
			{
				try
				{
					int num = sBCDText.Length;
					for (int i = num; i < 2 * iLength; i++)
					{
						sBCDText += "0";
					}
					num = 2 * iLength;
					byte b = 0;
					for (int j = iLength - 1; j >= 0; j--)
					{
						global::Motorola.Common.Communication.TetraUtility.DataCvt.CvtHexstringToAByte(sBCDText.Substring(num - j * 2 - 2, 2), out b);
						array[iLength - 1 - j] = b;
					}
				}
				catch
				{
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException("Data Convert error");
				}
				return array;
			}
		}

		// Token: 0x0600034C RID: 844 RVA: 0x00011B48 File Offset: 0x0000FD48
		public static string CvtByteArray2BCD(byte[] bBCD)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Remove(0, stringBuilder.Length);
			try
			{
				for (int i = 0; i < bBCD.Length; i++)
				{
					int num = (int)(bBCD[i] / 16);
					char c = global::Motorola.Common.Communication.TetraUtility.DataCvt.IntToHexChar(num);
					int iInt = (int)bBCD[i] - num * 16;
					char c2 = global::Motorola.Common.Communication.TetraUtility.DataCvt.IntToHexChar(iInt);
					stringBuilder.Append(c.ToString());
					stringBuilder.Append(c2.ToString());
				}
			}
			catch
			{
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException("Data Convert error");
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0400040D RID: 1037
		private const string STR_0 = "0";

		// Token: 0x0400040E RID: 1038
		private const string STR_1 = "1";

		// Token: 0x0400040F RID: 1039
		private const string STR_F = "F";

		// Token: 0x04000410 RID: 1040
		private const char CHAR_A_UPPER = 'A';

		// Token: 0x04000411 RID: 1041
		private const char CHAR_B_UPPER = 'B';

		// Token: 0x04000412 RID: 1042
		private const char CHAR_C_UPPER = 'C';

		// Token: 0x04000413 RID: 1043
		private const char CHAR_D_UPPER = 'D';

		// Token: 0x04000414 RID: 1044
		private const char CHAR_E_UPPER = 'E';

		// Token: 0x04000415 RID: 1045
		private const char CHAR_F_UPPER = 'F';

		// Token: 0x04000416 RID: 1046
		private const char CHAR_A_LOWER = 'a';

		// Token: 0x04000417 RID: 1047
		private const char CHAR_B_LOWER = 'b';

		// Token: 0x04000418 RID: 1048
		private const char CHAR_C_LOWER = 'c';

		// Token: 0x04000419 RID: 1049
		private const char CHAR_D_LOWER = 'd';

		// Token: 0x0400041A RID: 1050
		private const char CHAR_E_LOWER = 'e';

		// Token: 0x0400041B RID: 1051
		private const char CHAR_F_LOWER = 'f';

		// Token: 0x0400041C RID: 1052
		private const char CHAR_X_UPPER = 'X';

		// Token: 0x0400041D RID: 1053
		private const char CHAR_X_LOWER = 'x';

		// Token: 0x0400041E RID: 1054
		private const char CHAR_0 = '0';

		// Token: 0x0400041F RID: 1055
		private const int DECIMAL = 10;

		// Token: 0x04000420 RID: 1056
		private const int OCTAL = 8;

		// Token: 0x04000421 RID: 1057
		private const int UINT_256 = 256;
	}
}
