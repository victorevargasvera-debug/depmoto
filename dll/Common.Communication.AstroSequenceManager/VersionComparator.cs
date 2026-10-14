using System;
using System.Collections;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication
{
	// Token: 0x0200001B RID: 27
	internal class VersionComparator : global::System.Collections.IComparer
	{
		// Token: 0x0600012A RID: 298 RVA: 0x00008C4C File Offset: 0x00006E4C
		internal static int CompareVersions(string version1, string version2)
		{
			int num = 0;
			if (version1 == null && version2 == null)
			{
				return 0;
			}
			if (version1 == null || version1 == string.Empty)
			{
				return -1;
			}
			if (version2 == null || version2 == string.Empty)
			{
				return 1;
			}
			if (version1.Length < 6 || version2.Length < 6)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ValidateInfosFailure);
			}
			string text = version1.ToLowerInvariant();
			string text2 = version2.ToLowerInvariant();
			text = text.Replace(".", "");
			text2 = text2.Replace(".", "");
			if (text != text2)
			{
				char c = text[0];
				char c2 = text2[0];
				text = text.Remove(0, 1);
				text2 = text2.Remove(0, 1);
				num = string.Compare(text, text2, global::System.StringComparison.Ordinal);
				if (num == 0)
				{
					if (c < c2)
					{
						num = -1;
					}
					else if (c > c2)
					{
						num = 1;
					}
				}
			}
			return num;
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00008D21 File Offset: 0x00006F21
		public int Compare(object x, object y)
		{
			return global::Motorola.Common.Communication.VersionComparator.CompareVersions((string)x, (string)y);
		}
	}
}
