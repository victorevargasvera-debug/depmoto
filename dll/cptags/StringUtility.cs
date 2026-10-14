using System;
using System.IO;

namespace constants
{
	// Token: 0x0200000A RID: 10
	public class StringUtility
	{
		// Token: 0x0600000C RID: 12 RVA: 0x0000377C File Offset: 0x0000197C
		public static bool ValidateExtension(string fileName, params string[] expectedExtensions)
		{
			bool flag;
			for (;;)
			{
				switch (0)
				{
				default:
					flag = false;
					try
					{
						int num = 13;
						for (;;)
						{
							string extension;
							string value;
							switch (num)
							{
							case 0:
							{
								string text;
								if (!text.StartsWith(".", global::System.StringComparison.Ordinal))
								{
									num = 4;
									continue;
								}
								goto IL_C1;
							}
							case 1:
								goto IL_C1;
							case 2:
							{
								int num2;
								num2++;
								if (true)
								{
								}
								num = 10;
								continue;
							}
							case 3:
							{
								extension = global::System.IO.Path.GetExtension(fileName);
								int num2 = 0;
								num = 5;
								continue;
							}
							case 4:
							{
								string text;
								value = "." + text;
								num = 1;
								continue;
							}
							case 5:
								goto IL_E7;
							case 6:
								goto IL_162;
							case 7:
								if (!flag)
								{
									num = 2;
									continue;
								}
								goto IL_156;
							case 8:
								if (expectedExtensions.Length > 0)
								{
									num = 3;
									continue;
								}
								goto IL_156;
							case 9:
								num = 8;
								continue;
							case 10:
								goto IL_E7;
							case 11:
								goto IL_156;
							case 12:
							{
								int num2;
								if (num2 >= expectedExtensions.Length)
								{
									num = 11;
									continue;
								}
								string text = expectedExtensions[num2];
								value = text;
								num = 0;
								continue;
							}
							}
							if (expectedExtensions != null)
							{
								num = 9;
								continue;
							}
							goto IL_156;
							IL_C1:
							flag = extension.Equals(value, global::System.StringComparison.OrdinalIgnoreCase);
							num = 7;
							continue;
							IL_E7:
							num = 12;
							continue;
							IL_156:
							num = 6;
						}
						IL_162:;
					}
					catch
					{
						flag = false;
					}
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_17F;
					}
					break;
				}
			}
			IL_17F:
			if (false)
			{
			}
			return flag;
		}
	}
}
