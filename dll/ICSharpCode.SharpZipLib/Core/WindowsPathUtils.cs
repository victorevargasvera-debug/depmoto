using System;

namespace ICSharpCode.SharpZipLib.Core
{
	// Token: 0x0200001F RID: 31
	public abstract class WindowsPathUtils
	{
		// Token: 0x060000DF RID: 223 RVA: 0x0000797D File Offset: 0x0000697D
		internal WindowsPathUtils()
		{
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00007988 File Offset: 0x00006988
		public static string DropPathRoot(string path)
		{
			string text = path;
			if (path != null && path.Length > 0)
			{
				if (path[0] == '\\' || path[0] == '/')
				{
					if (path.Length > 1 && (path[1] == '\\' || path[1] == '/'))
					{
						int num = 2;
						int num2 = 2;
						while (num <= path.Length && ((path[num] != '\\' && path[num] != '/') || --num2 > 0))
						{
							num++;
						}
						num++;
						if (num < path.Length)
						{
							text = path.Substring(num);
						}
						else
						{
							text = "";
						}
					}
				}
				else if (path.Length > 1 && path[1] == ':')
				{
					int count = 2;
					if (path.Length > 2 && (path[2] == '\\' || path[2] == '/'))
					{
						count = 3;
					}
					text = text.Remove(0, count);
				}
			}
			return text;
		}
	}
}
