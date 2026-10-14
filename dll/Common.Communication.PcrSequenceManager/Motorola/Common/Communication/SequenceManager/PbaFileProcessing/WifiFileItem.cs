using System;

namespace Motorola.Common.Communication.SequenceManager.PbaFileProcessing
{
	// Token: 0x0200001F RID: 31
	internal class WifiFileItem
	{
		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600008A RID: 138 RVA: 0x00004E28 File Offset: 0x00003028
		// (set) Token: 0x0600008B RID: 139 RVA: 0x00004E3F File Offset: 0x0000303F
		internal string FileName { get; set; }

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600008C RID: 140 RVA: 0x00004E48 File Offset: 0x00003048
		// (set) Token: 0x0600008D RID: 141 RVA: 0x00004E5F File Offset: 0x0000305F
		internal string LocalFilePath { get; set; }
	}
}
