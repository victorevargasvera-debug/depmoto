using System;
using System.IO;

namespace Motorola.Common.Communication
{
	// Token: 0x02000007 RID: 7
	public class RecordA : global::Motorola.Common.Communication.ResourceRecord
	{
		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000042 RID: 66 RVA: 0x00002423 File Offset: 0x00000623
		// (set) Token: 0x06000043 RID: 67 RVA: 0x0000242B File Offset: 0x0000062B
		public string IP { get; set; }

		// Token: 0x06000044 RID: 68 RVA: 0x00002434 File Offset: 0x00000634
		public override void Serialize(global::System.IO.Stream stream)
		{
		}
	}
}
