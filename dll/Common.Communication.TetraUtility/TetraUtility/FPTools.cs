using System;
using System.Collections.Generic;
using System.IO;

namespace Motorola.Common.Communication.TetraUtility
{
	// Token: 0x02000015 RID: 21
	public static class FPTools
	{
		// Token: 0x060000CC RID: 204 RVA: 0x00006DCC File Offset: 0x00004FCC
		public static global::Motorola.Common.Communication.TetraUtility.Z19File LoadSoftwareFile(string fpPath)
		{
			global::Motorola.Common.Communication.TetraUtility.Z19File result = null;
			if (global::System.IO.File.Exists(fpPath))
			{
				result = new global::Motorola.Common.Communication.TetraUtility.Z19File(fpPath);
			}
			return result;
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000CD RID: 205 RVA: 0x00006DEC File Offset: 0x00004FEC
		public static string[] AllLanguages
		{
			get
			{
				global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
				foreach (global::Motorola.Common.Communication.TetraUtility.FlashPackNamesRecord flashPackNamesRecord in global::Motorola.Common.Communication.TetraUtility.CommConfigManager.Instance.FlashPackNamesTable.RecordsList)
				{
					if (flashPackNamesRecord.PackID.Contains("L"))
					{
						list.Add(flashPackNamesRecord.PackName);
					}
				}
				list.Sort();
				return list.ToArray();
			}
		}
	}
}
