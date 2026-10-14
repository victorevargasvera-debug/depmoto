using System;
using System.Text;

namespace Motorola.Common.Communication.TetraUtility
{
	// Token: 0x02000006 RID: 6
	public static class CodepageUtil
	{
		// Token: 0x06000023 RID: 35 RVA: 0x0000498F File Offset: 0x00002B8F
		public static global::System.Text.Encoding GetEncoding(int codepage)
		{
			if (codepage == 9999)
			{
				if (global::Motorola.Common.Communication.TetraUtility.CodepageUtil._russianEncoding == null)
				{
					global::Motorola.Common.Communication.TetraUtility.CodepageUtil._russianEncoding = new global::Motorola.Common.Communication.TetraUtility.TetraRussianEncoding();
				}
				return global::Motorola.Common.Communication.TetraUtility.CodepageUtil._russianEncoding;
			}
			return global::System.Text.Encoding.GetEncoding(codepage);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000049B8 File Offset: 0x00002BB8
		public static bool IsLatin1Char(char c)
		{
			byte[] bytes = global::Motorola.Common.Communication.TetraUtility.CodepageUtil.GetEncoding(1252).GetBytes(c.ToString());
			if (bytes.Length != 1)
			{
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException("Invalid char: " + c.ToString());
			}
			string @string = global::Motorola.Common.Communication.TetraUtility.CodepageUtil.GetEncoding(1252).GetString(bytes);
			return !(@string != new string(c, 1)) && (bytes[0] < 127 || bytes[0] > 159) && (bytes[0] < 0 || bytes[0] > 31);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00004A3C File Offset: 0x00002C3C
		public static bool IsLatin1String(string s)
		{
			if (string.IsNullOrEmpty(s))
			{
				return true;
			}
			foreach (char c in s.ToCharArray())
			{
				if (!global::Motorola.Common.Communication.TetraUtility.CodepageUtil.IsLatin1Char(c))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0400000F RID: 15
		private static global::System.Text.Encoding _russianEncoding;
	}
}
