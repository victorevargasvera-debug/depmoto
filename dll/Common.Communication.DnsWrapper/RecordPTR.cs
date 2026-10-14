using System;
using System.IO;
using System.Text;

namespace Motorola.Common.Communication
{
	// Token: 0x0200000A RID: 10
	public class RecordPTR : global::Motorola.Common.Communication.ResourceRecord
	{
		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000053 RID: 83 RVA: 0x000024A5 File Offset: 0x000006A5
		// (set) Token: 0x06000054 RID: 84 RVA: 0x000024AD File Offset: 0x000006AD
		public string DomainName { get; set; }

		// Token: 0x06000055 RID: 85 RVA: 0x000024B8 File Offset: 0x000006B8
		public override void Serialize(global::System.IO.Stream stream)
		{
			byte[] bytes = global::System.Text.Encoding.ASCII.GetBytes(base.NAME);
			stream.Write(bytes, 0, bytes.Length);
		}
	}
}
