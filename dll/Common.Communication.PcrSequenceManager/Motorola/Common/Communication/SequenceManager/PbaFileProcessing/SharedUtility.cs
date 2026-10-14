using System;
using System.IO;
using Motorola.Common.Communication.CommonUtility;

namespace Motorola.Common.Communication.SequenceManager.PbaFileProcessing
{
	// Token: 0x0200001E RID: 30
	internal class SharedUtility
	{
		// Token: 0x06000087 RID: 135 RVA: 0x00004DB4 File Offset: 0x00002FB4
		public static string GetTempFolder()
		{
			string text = global::System.IO.Path.Combine(global::Motorola.Common.Communication.CommonUtility.GlobalConstansts.StorageFolder, global::System.Guid.NewGuid().ToString());
			if (!global::System.IO.Directory.Exists(text))
			{
				global::System.IO.Directory.CreateDirectory(text);
			}
			return text;
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00004DF8 File Offset: 0x00002FF8
		public static void DeletTempFolder(string folder)
		{
			if (global::System.IO.Directory.Exists(folder))
			{
				global::System.IO.Directory.Delete(folder, true);
			}
		}
	}
}
