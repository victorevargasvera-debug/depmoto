using System;
using System.Collections.Generic;
using System.IO;

namespace Motorola.Common.Communication
{
	// Token: 0x0200000B RID: 11
	public class RecordTXT : global::Motorola.Common.Communication.ResourceRecord
	{
		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000057 RID: 87 RVA: 0x000024E9 File Offset: 0x000006E9
		// (set) Token: 0x06000058 RID: 88 RVA: 0x000024F1 File Offset: 0x000006F1
		public global::System.Collections.Generic.Dictionary<string, string> Txts { get; set; }

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000059 RID: 89 RVA: 0x000024FA File Offset: 0x000006FA
		// (set) Token: 0x0600005A RID: 90 RVA: 0x00002502 File Offset: 0x00000702
		public byte TxtLength { get; set; }

		// Token: 0x0600005B RID: 91 RVA: 0x0000250B File Offset: 0x0000070B
		public RecordTXT()
		{
			this.Txts = new global::System.Collections.Generic.Dictionary<string, string>();
		}

		// Token: 0x0600005C RID: 92 RVA: 0x0000251E File Offset: 0x0000071E
		public override void Serialize(global::System.IO.Stream stream)
		{
		}
	}
}
