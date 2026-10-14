using System;
using System.Text;

namespace Motorola.Common.Communication.TetraUtility
{
	// Token: 0x02000003 RID: 3
	public static class CodepageDef
	{
		// Token: 0x06000017 RID: 23 RVA: 0x000022F8 File Offset: 0x000004F8
		public static char? GetRussianChar(byte b)
		{
			if (b < 0 || (int)b > global::Motorola.Common.Communication.TetraUtility.CodepageDef.TetraRussianCodepageTable.Length)
			{
				return null;
			}
			string @string = global::System.Text.Encoding.Unicode.GetString(global::System.BitConverter.GetBytes(global::Motorola.Common.Communication.TetraUtility.CodepageDef.TetraRussianCodepageTable[(int)b].Code));
			if (@string.Length != 1)
			{
				return null;
			}
			return new char?(@string.ToCharArray()[0]);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x0000235C File Offset: 0x0000055C
		public static byte? GetRussianByte(char c)
		{
			ushort num = global::System.BitConverter.ToUInt16(global::System.Text.Encoding.Unicode.GetBytes(new string(c, 1)), 0);
			for (int i = 0; i < global::Motorola.Common.Communication.TetraUtility.CodepageDef.TetraRussianCodepageTable.Length; i++)
			{
				global::Motorola.Common.Communication.TetraUtility.CodeAllowPair codeAllowPair = global::Motorola.Common.Communication.TetraUtility.CodepageDef.TetraRussianCodepageTable[i];
				if (codeAllowPair.Code == num && codeAllowPair.IsInputable)
				{
					return new byte?((byte)i);
				}
			}
			return null;
		}

		// Token: 0x04000008 RID: 8
		public const int WINDOWS_1252 = 1252;

		// Token: 0x04000009 RID: 9
		public const int TETRA_SINGLE_BYTE_RUSSIAN = 9999;

		// Token: 0x0400000A RID: 10
		public const int BIG_ENDIAN_UNICODE = 1201;

		// Token: 0x0400000B RID: 11
		internal static global::Motorola.Common.Communication.TetraUtility.CodeAllowPair[] TetraRussianCodepageTable = new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair[]
		{
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 0,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 1,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 2,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 3,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 4,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 5,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 6,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 7,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 8,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 9,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 10,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 11,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 12,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 13,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 14,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 15,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 16,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 17,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 18,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 19,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 20,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 191,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 161,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 23,
				IsInputable = false
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 24,
				IsInputable = false
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 25,
				IsInputable = false
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 26,
				IsInputable = false
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 262,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 321,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 346,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 379,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 9646,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 32,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 33,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 34,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 35,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 36,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 37,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 38,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 39,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 40,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 41,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 42,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 43,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 44,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 45,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 46,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 47,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 48,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 49,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 50,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 51,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 52,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 53,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 54,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 55,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 56,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 57,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 58,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 59,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 60,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 61,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 62,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 63,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 64,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 65,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 66,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 67,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 68,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 69,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 70,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 71,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 72,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 73,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 74,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 75,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 76,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 77,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 78,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 79,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 80,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 81,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 82,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 83,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 84,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 85,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 86,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 87,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 88,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 89,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 90,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 91,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 92,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 93,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 94,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 95,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 96,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 97,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 98,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 99,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 100,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 101,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 102,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 103,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 104,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 105,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 106,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 107,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 108,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 109,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 110,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 111,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 112,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 113,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 114,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 115,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 116,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 117,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 118,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 119,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 120,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 121,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 122,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 123,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 124,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 125,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 126,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 127,
				IsInputable = false
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 1040,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 1041,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 1042,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 1043,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 1044,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 1045,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 1046,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 1047,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 1048,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 1049,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 1050,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 1051,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 1052,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 1053,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 1054,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 1055,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 1056,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 1057,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 1058,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 1059,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 1060,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 1061,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 1062,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 1063,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 1064,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 1065,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 1066,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 1067,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 1068,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 1069,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 1070,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 1071,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 258,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 260,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 262,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 268,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 270,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 282,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 280,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 286,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 287,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 305,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 304,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 322,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 323,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 327,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 336,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 344,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 346,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 350,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 351,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 352,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 354,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 356,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 366,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 368,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 377,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 379,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 381,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 378,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 261,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 281,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 322,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 324,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 192,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 193,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 194,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 195,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 196,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 197,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 198,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 199,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 200,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 201,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 202,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 203,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 204,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 205,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 206,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 207,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 208,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 209,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 210,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 211,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 212,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 213,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 214,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 215,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 216,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 217,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 218,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 219,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 220,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 221,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 222,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 223,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 224,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 225,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 226,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 227,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 228,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 229,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 230,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 231,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 232,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 233,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 234,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 235,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 236,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 237,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 238,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 239,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 240,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 241,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 242,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 243,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 244,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 245,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 246,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 247,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 248,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 249,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 250,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 251,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 252,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 253,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 254,
				IsInputable = true
			},
			new global::Motorola.Common.Communication.TetraUtility.CodeAllowPair
			{
				Code = 255,
				IsInputable = true
			}
		};
	}
}
