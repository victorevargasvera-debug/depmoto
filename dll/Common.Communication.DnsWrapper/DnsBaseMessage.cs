using System;
using System.Collections.Generic;

namespace Motorola.Common.Communication
{
	// Token: 0x0200000D RID: 13
	public class DnsBaseMessage : global::Motorola.Common.Communication.BaseMessage
	{
		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000068 RID: 104 RVA: 0x0000257D File Offset: 0x0000077D
		// (set) Token: 0x06000069 RID: 105 RVA: 0x00002585 File Offset: 0x00000785
		public global::Motorola.Common.Communication.Header Header { get; set; }

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600006A RID: 106 RVA: 0x0000258E File Offset: 0x0000078E
		// (set) Token: 0x0600006B RID: 107 RVA: 0x00002596 File Offset: 0x00000796
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.Question> Questions { get; set; }

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x0600006C RID: 108 RVA: 0x0000259F File Offset: 0x0000079F
		// (set) Token: 0x0600006D RID: 109 RVA: 0x000025A7 File Offset: 0x000007A7
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.ResourceRecord> Answers { get; set; }

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600006E RID: 110 RVA: 0x000025B0 File Offset: 0x000007B0
		// (set) Token: 0x0600006F RID: 111 RVA: 0x000025B8 File Offset: 0x000007B8
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.ResourceRecord> Authorities { get; set; }

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000070 RID: 112 RVA: 0x000025C1 File Offset: 0x000007C1
		// (set) Token: 0x06000071 RID: 113 RVA: 0x000025C9 File Offset: 0x000007C9
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.ResourceRecord> Additionals { get; set; }

		// Token: 0x06000072 RID: 114 RVA: 0x000025D2 File Offset: 0x000007D2
		public override int BuildCommandMessage(byte[] sendBuffer)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000073 RID: 115 RVA: 0x000025D9 File Offset: 0x000007D9
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			throw new global::System.NotImplementedException();
		}
	}
}
