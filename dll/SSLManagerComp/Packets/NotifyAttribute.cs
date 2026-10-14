using System;

namespace SSLMangrComp.Packets
{
	// Token: 0x02000030 RID: 48
	public class NotifyAttribute
	{
		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000177 RID: 375 RVA: 0x000076E0 File Offset: 0x000058E0
		// (set) Token: 0x06000178 RID: 376 RVA: 0x000076E8 File Offset: 0x000058E8
		public global::SSLMangrComp.Packets.AttributeTypes AttributeType { get; set; }

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000179 RID: 377 RVA: 0x000076F1 File Offset: 0x000058F1
		// (set) Token: 0x0600017A RID: 378 RVA: 0x000076F9 File Offset: 0x000058F9
		public string Attribute { get; set; }
	}
}
