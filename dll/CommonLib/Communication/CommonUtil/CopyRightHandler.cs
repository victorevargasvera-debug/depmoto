using System;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000008 RID: 8
	public class CopyRightHandler
	{
		// Token: 0x06000032 RID: 50 RVA: 0x000028A4 File Offset: 0x00000AA4
		private CopyRightHandler()
		{
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000033 RID: 51 RVA: 0x000028AC File Offset: 0x00000AAC
		public static global::Motorola.Common.Communication.CommonUtil.CopyRightHandler Instance
		{
			get
			{
				if (global::Motorola.Common.Communication.CommonUtil.CopyRightHandler.instance == null)
				{
					global::Motorola.Common.Communication.CommonUtil.CopyRightHandler.instance = new global::Motorola.Common.Communication.CommonUtil.CopyRightHandler();
				}
				return global::Motorola.Common.Communication.CommonUtil.CopyRightHandler.instance;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000034 RID: 52 RVA: 0x000028C4 File Offset: 0x00000AC4
		private string CopyRightString
		{
			get
			{
				return string.Format(global::System.Globalization.CultureInfo.CurrentCulture, "Copyright (c) {0} Motorola Solutions, Inc. All Rights Reserved ", new object[]
				{
					global::System.DateTime.Now.Year.ToString(global::System.Globalization.CultureInfo.InvariantCulture)
				});
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002908 File Offset: 0x00000B08
		public byte[] AddCopyRightHeader(byte[] content)
		{
			byte[] result = content;
			if (!this.HasCopyRightHeader(content))
			{
				result = global::Motorola.Common.Communication.CommonUtil.CopyRightHandler.CombineArray<byte>(new byte[][]
				{
					global::System.Text.Encoding.UTF8.GetBytes(this.CopyRightString),
					content
				});
			}
			return result;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002948 File Offset: 0x00000B48
		public byte[] RemoveCopyRightHeader(byte[] combinedData)
		{
			byte[] array;
			byte[] result;
			if (this.HasCopyRightHeader(combinedData, out array))
			{
				result = combinedData.Skip(array.Length).ToArray<byte>();
			}
			else
			{
				result = combinedData;
			}
			return result;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002974 File Offset: 0x00000B74
		public bool HasCopyRightHeader(byte[] content)
		{
			byte[] array;
			return this.HasCopyRightHeader(content, out array);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x0000298C File Offset: 0x00000B8C
		public bool HasCopyRightHeader(string strContent)
		{
			string text;
			return this.HasCopyRightHeader(strContent, out text);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x000029AC File Offset: 0x00000BAC
		private static T[] CombineArray<T>(params T[][] arrays)
		{
			T[] array = new T[arrays.Sum((T[] a) => a.Length)];
			int num = 0;
			foreach (T[] array2 in arrays)
			{
				global::System.Buffer.BlockCopy(array2, 0, array, num, array2.Length);
				num += array2.Length;
			}
			return array;
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002A00 File Offset: 0x00000C00
		private bool HasCopyRightHeader(byte[] content, out byte[] byteArray_CopyRightHeader)
		{
			int count = (content.Length > 70) ? 70 : content.Length;
			string @string = global::System.Text.Encoding.UTF8.GetString(content, 0, count);
			string s;
			bool result = this.HasCopyRightHeader(@string, out s);
			byteArray_CopyRightHeader = global::System.Text.Encoding.UTF8.GetBytes(s);
			return result;
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002A44 File Offset: 0x00000C44
		private bool HasCopyRightHeader(string strContent, out string strCopyRightHeader)
		{
			if (!string.IsNullOrEmpty(strContent))
			{
				global::System.Text.RegularExpressions.Regex regex = new global::System.Text.RegularExpressions.Regex("^Copyright \\(c\\) \\d+ Motorola Solutions, Inc\\. All Rights Reserved ", global::System.Text.RegularExpressions.RegexOptions.Compiled);
				global::System.Text.RegularExpressions.Match match = regex.Match(strContent);
				if (match.Success)
				{
					strCopyRightHeader = match.Value;
					return true;
				}
			}
			strCopyRightHeader = string.Empty;
			return false;
		}

		// Token: 0x0400001C RID: 28
		private const string pattern = "^Copyright \\(c\\) \\d+ Motorola Solutions, Inc\\. All Rights Reserved ";

		// Token: 0x0400001D RID: 29
		private const int ExpectedByteLength_MaxLimitation = 70;

		// Token: 0x0400001E RID: 30
		private static global::Motorola.Common.Communication.CommonUtil.CopyRightHandler instance;
	}
}
