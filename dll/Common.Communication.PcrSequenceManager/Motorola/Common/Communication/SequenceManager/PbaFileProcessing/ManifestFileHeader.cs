using System;
using System.Linq;

namespace Motorola.Common.Communication.SequenceManager.PbaFileProcessing
{
	// Token: 0x0200001A RID: 26
	internal class ManifestFileHeader : global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.IManifestItem
	{
		// Token: 0x17000009 RID: 9
		// (set) Token: 0x0600005A RID: 90 RVA: 0x000045B0 File Offset: 0x000027B0
		public uint ObjectNum
		{
			set
			{
				this.objNum = value;
			}
		}

		// Token: 0x0600005B RID: 91 RVA: 0x000045BA File Offset: 0x000027BA
		public void WriteToStream(global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.ManifestFileWriter writer)
		{
			writer.Write("headerversion", this.headerVersion.ToArray<char>());
			writer.Write("objectnum", this.objNum);
		}

		// Token: 0x0400007F RID: 127
		private string headerVersion = "0100";

		// Token: 0x04000080 RID: 128
		private uint objNum = 0U;
	}
}
