using System;
using System.Collections;
using System.Text;
using System.Text.RegularExpressions;

namespace ICSharpCode.SharpZipLib.Core
{
	// Token: 0x0200001A RID: 26
	public class NameFilter : global::ICSharpCode.SharpZipLib.Core.IScanFilter
	{
		// Token: 0x060000BC RID: 188 RVA: 0x00007078 File Offset: 0x00006078
		public NameFilter(string filter)
		{
			this.filter_ = filter;
			this.inclusions_ = new global::System.Collections.ArrayList();
			this.exclusions_ = new global::System.Collections.ArrayList();
			this.Compile();
		}

		// Token: 0x060000BD RID: 189 RVA: 0x000070A4 File Offset: 0x000060A4
		public static bool IsValidExpression(string expression)
		{
			bool result = true;
			try
			{
				new global::System.Text.RegularExpressions.Regex(expression, global::System.Text.RegularExpressions.RegexOptions.IgnoreCase | global::System.Text.RegularExpressions.RegexOptions.Singleline);
			}
			catch (global::System.ArgumentException)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060000BE RID: 190 RVA: 0x000070D4 File Offset: 0x000060D4
		public static bool IsValidFilterExpression(string toTest)
		{
			if (toTest == null)
			{
				throw new global::System.ArgumentNullException("toTest");
			}
			bool result = true;
			try
			{
				string[] array = global::ICSharpCode.SharpZipLib.Core.NameFilter.SplitQuoted(toTest);
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i] != null && array[i].Length > 0)
					{
						string pattern;
						if (array[i][0] == '+')
						{
							pattern = array[i].Substring(1, array[i].Length - 1);
						}
						else if (array[i][0] == '-')
						{
							pattern = array[i].Substring(1, array[i].Length - 1);
						}
						else
						{
							pattern = array[i];
						}
						new global::System.Text.RegularExpressions.Regex(pattern, global::System.Text.RegularExpressions.RegexOptions.IgnoreCase | global::System.Text.RegularExpressions.RegexOptions.Singleline);
					}
				}
			}
			catch (global::System.ArgumentException)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00007184 File Offset: 0x00006184
		public static string[] SplitQuoted(string original)
		{
			char c = '\\';
			char[] array = new char[]
			{
				';'
			};
			global::System.Collections.ArrayList arrayList = new global::System.Collections.ArrayList();
			if (original != null && original.Length > 0)
			{
				int i = -1;
				global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
				while (i < original.Length)
				{
					i++;
					if (i >= original.Length)
					{
						arrayList.Add(stringBuilder.ToString());
					}
					else if (original[i] == c)
					{
						i++;
						if (i >= original.Length)
						{
							throw new global::System.ArgumentException("Missing terminating escape character", "original");
						}
						stringBuilder.Append(original[i]);
					}
					else if (global::System.Array.IndexOf<char>(array, original[i]) >= 0)
					{
						arrayList.Add(stringBuilder.ToString());
						stringBuilder.Length = 0;
					}
					else
					{
						stringBuilder.Append(original[i]);
					}
				}
			}
			return (string[])arrayList.ToArray(typeof(string));
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00007278 File Offset: 0x00006278
		public override string ToString()
		{
			return this.filter_;
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00007280 File Offset: 0x00006280
		public bool IsIncluded(string name)
		{
			bool result = false;
			if (this.inclusions_.Count == 0)
			{
				result = true;
			}
			else
			{
				foreach (object obj in this.inclusions_)
				{
					global::System.Text.RegularExpressions.Regex regex = (global::System.Text.RegularExpressions.Regex)obj;
					if (regex.IsMatch(name))
					{
						result = true;
						break;
					}
				}
			}
			return result;
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x000072F4 File Offset: 0x000062F4
		public bool IsExcluded(string name)
		{
			bool result = false;
			foreach (object obj in this.exclusions_)
			{
				global::System.Text.RegularExpressions.Regex regex = (global::System.Text.RegularExpressions.Regex)obj;
				if (regex.IsMatch(name))
				{
					result = true;
					break;
				}
			}
			return result;
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00007358 File Offset: 0x00006358
		public bool IsMatch(string name)
		{
			return this.IsIncluded(name) && !this.IsExcluded(name);
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00007370 File Offset: 0x00006370
		private void Compile()
		{
			if (this.filter_ == null)
			{
				return;
			}
			string[] array = global::ICSharpCode.SharpZipLib.Core.NameFilter.SplitQuoted(this.filter_);
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] != null && array[i].Length > 0)
				{
					bool flag = array[i][0] != '-';
					string pattern;
					if (array[i][0] == '+')
					{
						pattern = array[i].Substring(1, array[i].Length - 1);
					}
					else if (array[i][0] == '-')
					{
						pattern = array[i].Substring(1, array[i].Length - 1);
					}
					else
					{
						pattern = array[i];
					}
					if (flag)
					{
						this.inclusions_.Add(new global::System.Text.RegularExpressions.Regex(pattern, global::System.Text.RegularExpressions.RegexOptions.IgnoreCase | global::System.Text.RegularExpressions.RegexOptions.Compiled | global::System.Text.RegularExpressions.RegexOptions.Singleline));
					}
					else
					{
						this.exclusions_.Add(new global::System.Text.RegularExpressions.Regex(pattern, global::System.Text.RegularExpressions.RegexOptions.IgnoreCase | global::System.Text.RegularExpressions.RegexOptions.Compiled | global::System.Text.RegularExpressions.RegexOptions.Singleline));
					}
				}
			}
		}

		// Token: 0x0400007F RID: 127
		private string filter_;

		// Token: 0x04000080 RID: 128
		private global::System.Collections.ArrayList inclusions_;

		// Token: 0x04000081 RID: 129
		private global::System.Collections.ArrayList exclusions_;
	}
}
