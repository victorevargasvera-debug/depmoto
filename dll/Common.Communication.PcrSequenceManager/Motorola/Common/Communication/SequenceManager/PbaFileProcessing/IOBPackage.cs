using System;
using System.Collections.Generic;
using Motorola.Common.Communication.Pba;

namespace Motorola.Common.Communication.SequenceManager.PbaFileProcessing
{
	// Token: 0x0200000F RID: 15
	internal interface IOBPackage
	{
		// Token: 0x0600004D RID: 77
		global::System.Collections.Generic.IEnumerable<global::Motorola.Common.Communication.Pba.FileItem> GetFlashFiles(string zipFile);
	}
}
