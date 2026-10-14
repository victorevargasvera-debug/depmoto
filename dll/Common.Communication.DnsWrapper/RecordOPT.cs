using System;

namespace Motorola.Common.Communication
{
	// Token: 0x0200000C RID: 12
	public class RecordOPT : global::Motorola.Common.Communication.ResourceRecord
	{
		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600005D RID: 93 RVA: 0x00002520 File Offset: 0x00000720
		// (set) Token: 0x0600005E RID: 94 RVA: 0x00002528 File Offset: 0x00000728
		public ushort UDPPayloadSize { get; set; }

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600005F RID: 95 RVA: 0x00002531 File Offset: 0x00000731
		// (set) Token: 0x06000060 RID: 96 RVA: 0x00002539 File Offset: 0x00000739
		public byte CacheFlush { get; set; }

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000061 RID: 97 RVA: 0x00002542 File Offset: 0x00000742
		// (set) Token: 0x06000062 RID: 98 RVA: 0x0000254A File Offset: 0x0000074A
		public byte ExtendedRCODE { get; set; }

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000063 RID: 99 RVA: 0x00002553 File Offset: 0x00000753
		// (set) Token: 0x06000064 RID: 100 RVA: 0x0000255B File Offset: 0x0000075B
		public byte EDNS0Version { get; set; }

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000065 RID: 101 RVA: 0x00002564 File Offset: 0x00000764
		// (set) Token: 0x06000066 RID: 102 RVA: 0x0000256C File Offset: 0x0000076C
		public ushort Z { get; set; }
	}
}
