using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Motorola.Common.CommonLib;

namespace Motorola.Common.Communication.SequenceManager.PbaFileProcessing
{
	// Token: 0x0200001D RID: 29
	internal class OBUtility
	{
		// Token: 0x06000083 RID: 131 RVA: 0x00004BF0 File Offset: 0x00002DF0
		internal static global::System.Collections.Generic.List<string> UnpackOBFiles(string obFilePath, string targetFolder)
		{
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
			targetFolder = global::System.IO.Path.Combine(targetFolder, "ob");
			if (!global::System.IO.Directory.Exists(targetFolder))
			{
				global::System.IO.Directory.CreateDirectory(targetFolder);
			}
			if (!string.IsNullOrEmpty(obFilePath))
			{
				string text = obFilePath + ".zip";
				using (global::System.IO.Stream stream = global::Motorola.Common.CommonLib.EnDecryptStreamHelper.Instance.CreateCryptoFlStream(obFilePath, global::System.IO.FileAccess.Read))
				{
					using (global::System.IO.FileStream fileStream = new global::System.IO.FileStream(text, global::System.IO.FileMode.Create, global::System.IO.FileAccess.Write))
					{
						stream.CopyTo(fileStream);
					}
					global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.ZipFileUtility.Unzip(text, targetFolder);
					try
					{
						global::System.IO.File.Delete(text);
					}
					catch
					{
					}
				}
			}
			global::System.Collections.Generic.IEnumerable<string> enumerable = global::System.IO.Directory.EnumerateFiles(targetFolder);
			foreach (string text2 in enumerable)
			{
				if (string.Compare(global::System.IO.Path.GetFileName(text2), global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.OBUtility.OBManifest, global::System.StringComparison.OrdinalIgnoreCase) != 0)
				{
					list.Add(text2);
				}
				else
				{
					try
					{
						global::System.IO.File.Delete(text2);
					}
					catch
					{
					}
				}
			}
			return list;
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00004D6C File Offset: 0x00002F6C
		private static void RemoveRMHeader(string filename)
		{
			byte[] source = global::System.IO.File.ReadAllBytes(filename);
			global::System.IO.File.WriteAllBytes(filename, source.Skip(global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.OBUtility.OBFileHeaderLength).ToArray<byte>());
		}

		// Token: 0x04000090 RID: 144
		private static string OBManifest = "Manifest.xml";

		// Token: 0x04000091 RID: 145
		private static int OBFileHeaderLength = 61;
	}
}
