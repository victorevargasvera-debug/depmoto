using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x0200006B RID: 107
	public static class UtilityMethods
	{
		// Token: 0x0600031B RID: 795 RVA: 0x00007FDC File Offset: 0x000061DC
		public static string ToHexString(byte[] buffer, int start, int length, bool trim = true)
		{
			if (buffer == null)
			{
				return string.Empty;
			}
			if (buffer.Length < start + length)
			{
				throw new global::System.ArgumentOutOfRangeException("buffer", "buffer size is less than (start + length)");
			}
			if (length > 200 && trim)
			{
				length = 200;
			}
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(length * 2);
			for (int i = start; i < start + length; i++)
			{
				stringBuilder.Append(global::Motorola.Common.Communication.CommonUtil.UtilityMethods.NibbleToHex[buffer[i] >> 4]);
				stringBuilder.Append(global::Motorola.Common.Communication.CommonUtil.UtilityMethods.NibbleToHex[(int)(buffer[i] & 15)]);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0600031C RID: 796 RVA: 0x00008060 File Offset: 0x00006260
		public static byte[] HexString2ByteArray(string hex)
		{
			int length = hex.Length;
			byte[] array = new byte[length / 2];
			for (int i = 0; i < length; i += 2)
			{
				array[i / 2] = global::System.Convert.ToByte(hex.Substring(i, 2), 16);
			}
			return array;
		}

		// Token: 0x0600031D RID: 797 RVA: 0x000080A0 File Offset: 0x000062A0
		public static int CompareBytes(byte[] a, byte[] b)
		{
			if (a == null)
			{
				throw new global::System.ArgumentNullException("a");
			}
			if (b == null)
			{
				throw new global::System.ArgumentNullException("b");
			}
			if (a == b)
			{
				return 0;
			}
			int num = 0;
			int num2 = global::System.Math.Min(a.Length, b.Length);
			int num3 = 0;
			while (num3 == 0 && num < num2)
			{
				num3 = (int)(a[num] - b[num]);
				num++;
			}
			if (a.Length == b.Length)
			{
				return num3;
			}
			return a.Length - b.Length;
		}

		// Token: 0x0600031E RID: 798 RVA: 0x00008105 File Offset: 0x00006305
		public static void CheckIfParameterIsNull(object parameter, global::Motorola.Common.CustomException.CommonErrorCode commonErrorCode)
		{
			if (parameter == null)
			{
				throw new global::Motorola.Common.CustomException.CommonException(commonErrorCode);
			}
		}

		// Token: 0x0600031F RID: 799 RVA: 0x00008111 File Offset: 0x00006311
		public static void CheckIfParameterIsZero(int parameter, global::Motorola.Common.CustomException.CommonErrorCode commonErrorCode)
		{
			if (parameter == 0)
			{
				throw new global::Motorola.Common.CustomException.CommonException(commonErrorCode);
			}
		}

		// Token: 0x06000320 RID: 800 RVA: 0x0000811D File Offset: 0x0000631D
		public static void CheckIfParameterIsFalse(bool parameter, global::Motorola.Common.CustomException.CommonErrorCode commonErrorCode)
		{
			if (!parameter)
			{
				throw new global::Motorola.Common.CustomException.CommonException(commonErrorCode);
			}
		}

		// Token: 0x06000321 RID: 801 RVA: 0x00008129 File Offset: 0x00006329
		public static void CheckIfParameterIsNotNull(object parameter, global::Motorola.Common.CustomException.CommonErrorCode commonErrorCode)
		{
			if (parameter != null)
			{
				throw new global::Motorola.Common.CustomException.CommonException(commonErrorCode);
			}
		}

		// Token: 0x06000322 RID: 802 RVA: 0x00008135 File Offset: 0x00006335
		public static void CheckIfThreadIsAlive(global::System.Threading.Thread workThread, global::Motorola.Common.CustomException.CommonErrorCode commonErrorCode)
		{
			if (!workThread.IsAlive)
			{
				throw new global::Motorola.Common.CustomException.CommonException(commonErrorCode);
			}
		}

		// Token: 0x06000323 RID: 803 RVA: 0x00008146 File Offset: 0x00006346
		public static void CheckIfParameterIsTrue(bool parameter, global::Motorola.Common.CustomException.CommonErrorCode commonErrorCode)
		{
			if (parameter)
			{
				throw new global::Motorola.Common.CustomException.CommonException(commonErrorCode);
			}
		}

		// Token: 0x06000324 RID: 804 RVA: 0x00008152 File Offset: 0x00006352
		public static void ValidateArrayStartLength<T>(T[] array, int start, int length)
		{
			if (array == null)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
			}
			if (array.Length <= 0 || start < 0 || length < 0 || array.Length < start + length)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentOutOfRange);
			}
		}

		// Token: 0x06000325 RID: 805 RVA: 0x0000817C File Offset: 0x0000637C
		public static bool CheckIfParadiseTuningPathFixupVersions(string ver)
		{
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
			list.Add("1000");
			list.Add("1001");
			ver = ver.Substring(0, 4);
			return list.Contains(ver);
		}

		// Token: 0x06000326 RID: 806 RVA: 0x000081BC File Offset: 0x000063BC
		public static string ReadTuningVersionForParadise(byte[] itemdata)
		{
			string text = string.Empty;
			try
			{
				if (itemdata.Length > 4)
				{
					for (int i = 1; i < 4; i++)
					{
						text += global::System.Convert.ToString(itemdata[i], 16).PadLeft(2, '0');
					}
				}
			}
			catch
			{
			}
			return text;
		}

		// Token: 0x04000370 RID: 880
		public const int TUNING_VERSION_ISH_TYPE = 26896;

		// Token: 0x04000371 RID: 881
		public const int TUNING_VERSION_BYTEOFFSET = 1;

		// Token: 0x04000372 RID: 882
		public const int TUNING_VERSION_BYTELENGTH = 3;

		// Token: 0x04000373 RID: 883
		public const string TUNING_PATH_ISSUE_VERSION1 = "1000";

		// Token: 0x04000374 RID: 884
		public const string TUNING_PATH_ISSUE_VERSION2 = "1001";

		// Token: 0x04000375 RID: 885
		private static readonly char[] NibbleToHex = new char[]
		{
			'0',
			'1',
			'2',
			'3',
			'4',
			'5',
			'6',
			'7',
			'8',
			'9',
			'A',
			'B',
			'C',
			'D',
			'E',
			'F'
		};
	}
}
