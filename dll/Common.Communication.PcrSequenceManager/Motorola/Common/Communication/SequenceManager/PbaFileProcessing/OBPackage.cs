using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Motorola.Common.CommonLib;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Pba;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.SequenceManager.PbaFileProcessing
{
	// Token: 0x02000010 RID: 16
	public class OBPackage : global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.IOBPackage
	{
		// Token: 0x0600004E RID: 78 RVA: 0x0000404C File Offset: 0x0000224C
		public global::System.Collections.Generic.IEnumerable<global::Motorola.Common.Communication.Pba.FileItem> GetFlashFiles(string zipFile)
		{
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem>();
			string empty = string.Empty;
			try
			{
				global::System.Collections.Generic.IEnumerable<global::Motorola.Common.Communication.Pba.FileItem> enumerable = null;
				using (global::System.IO.Stream stream = global::Motorola.Common.CommonLib.EnDecryptStreamHelper.Instance.CreateCryptoFlStream(zipFile, global::System.IO.FileAccess.Read))
				{
					enumerable = global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.ZipFileUtility.ExtractStreamFromZip(stream);
					stream.Close();
				}
				if (null != enumerable)
				{
					global::Motorola.Common.Communication.Pba.FileItem fileItem = enumerable.SingleOrDefault((global::Motorola.Common.Communication.Pba.FileItem a) => a.Name.EndsWith("Manifest.xml", global::System.StringComparison.OrdinalIgnoreCase));
					if (null != fileItem)
					{
						global::Motorola.Common.Communication.CommonUtil.OBManifest obmanifest = new global::Motorola.Common.Communication.CommonUtil.OBManifest(fileItem.FileContent);
						if (obmanifest != null && null != obmanifest.components)
						{
							using (global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.componet>.Enumerator enumerator = obmanifest.components.GetEnumerator())
							{
								while (enumerator.MoveNext())
								{
									global::Motorola.Common.Communication.CommonUtil.componet c = enumerator.Current;
									global::Motorola.Common.Communication.Pba.FileItem fileItem2 = new global::Motorola.Common.Communication.Pba.FileItem();
									global::Motorola.Common.Communication.Pba.FileItem fileItem3 = enumerable.SingleOrDefault((global::Motorola.Common.Communication.Pba.FileItem a) => a.Name.EndsWith(c.fileName, global::System.StringComparison.OrdinalIgnoreCase));
									fileItem2.FileContent = fileItem3.FileContent;
									fileItem2.FileSize = fileItem3.FileSize;
									fileItem2.PartionID = 0;
									fileItem2.FilePath = c.targetDir + c.fileName;
									list.Add(fileItem2);
								}
							}
						}
					}
				}
			}
			catch (global::System.Exception systemException)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Pcr_GetOBPackFilesFail, systemException);
			}
			return list;
		}
	}
}
