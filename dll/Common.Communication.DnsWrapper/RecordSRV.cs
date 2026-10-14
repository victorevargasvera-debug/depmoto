using System;
using System.IO;

namespace Motorola.Common.Communication
{
	// Token: 0x02000009 RID: 9
	public class RecordSRV : global::Motorola.Common.Communication.ResourceRecord
	{
		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000049 RID: 73 RVA: 0x00002457 File Offset: 0x00000657
		// (set) Token: 0x0600004A RID: 74 RVA: 0x0000245F File Offset: 0x0000065F
		public ushort Priority { get; set; }

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600004B RID: 75 RVA: 0x00002468 File Offset: 0x00000668
		// (set) Token: 0x0600004C RID: 76 RVA: 0x00002470 File Offset: 0x00000670
		public ushort Weight { get; set; }

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600004D RID: 77 RVA: 0x00002479 File Offset: 0x00000679
		// (set) Token: 0x0600004E RID: 78 RVA: 0x00002481 File Offset: 0x00000681
		public ushort Port { get; set; }

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600004F RID: 79 RVA: 0x0000248A File Offset: 0x0000068A
		// (set) Token: 0x06000050 RID: 80 RVA: 0x00002492 File Offset: 0x00000692
		public string Target { get; set; }

		// Token: 0x06000051 RID: 81 RVA: 0x0000249B File Offset: 0x0000069B
		public override void Serialize(global::System.IO.Stream stream)
		{
		}
	}
}
