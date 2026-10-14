using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x02000030 RID: 48
	public class XcmpComponentTypeIdPair
	{
		// Token: 0x06000076 RID: 118 RVA: 0x00003E73 File Offset: 0x00002073
		public XcmpComponentTypeIdPair(ushort type, ushort id)
		{
			this.Type = type;
			this.ID = id;
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000077 RID: 119 RVA: 0x00003E89 File Offset: 0x00002089
		// (set) Token: 0x06000078 RID: 120 RVA: 0x00003E91 File Offset: 0x00002091
		internal ushort Type { get; private set; }

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000079 RID: 121 RVA: 0x00003E9A File Offset: 0x0000209A
		// (set) Token: 0x0600007A RID: 122 RVA: 0x00003EA2 File Offset: 0x000020A2
		internal ushort ID { get; private set; }
	}
}
