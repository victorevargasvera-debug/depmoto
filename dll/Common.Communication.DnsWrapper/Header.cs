using System;

namespace Motorola.Common.Communication
{
	// Token: 0x02000004 RID: 4
	public class Header
	{
		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000010 RID: 16 RVA: 0x0000227D File Offset: 0x0000047D
		// (set) Token: 0x06000011 RID: 17 RVA: 0x00002285 File Offset: 0x00000485
		public ushort ID { get; set; }

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000012 RID: 18 RVA: 0x0000228E File Offset: 0x0000048E
		// (set) Token: 0x06000013 RID: 19 RVA: 0x00002296 File Offset: 0x00000496
		public byte QR { get; set; }

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000014 RID: 20 RVA: 0x0000229F File Offset: 0x0000049F
		// (set) Token: 0x06000015 RID: 21 RVA: 0x000022A7 File Offset: 0x000004A7
		public byte OPCODE { get; set; }

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000016 RID: 22 RVA: 0x000022B0 File Offset: 0x000004B0
		// (set) Token: 0x06000017 RID: 23 RVA: 0x000022B8 File Offset: 0x000004B8
		public byte AA { get; set; }

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000018 RID: 24 RVA: 0x000022C1 File Offset: 0x000004C1
		// (set) Token: 0x06000019 RID: 25 RVA: 0x000022C9 File Offset: 0x000004C9
		public byte TC { get; set; }

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600001A RID: 26 RVA: 0x000022D2 File Offset: 0x000004D2
		// (set) Token: 0x0600001B RID: 27 RVA: 0x000022DA File Offset: 0x000004DA
		public byte RD { get; set; }

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600001C RID: 28 RVA: 0x000022E3 File Offset: 0x000004E3
		// (set) Token: 0x0600001D RID: 29 RVA: 0x000022EB File Offset: 0x000004EB
		public byte RA { get; set; }

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600001E RID: 30 RVA: 0x000022F4 File Offset: 0x000004F4
		// (set) Token: 0x0600001F RID: 31 RVA: 0x000022FC File Offset: 0x000004FC
		public byte Z { get; set; }

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000020 RID: 32 RVA: 0x00002305 File Offset: 0x00000505
		// (set) Token: 0x06000021 RID: 33 RVA: 0x0000230D File Offset: 0x0000050D
		public byte RCODE { get; set; }

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000022 RID: 34 RVA: 0x00002316 File Offset: 0x00000516
		// (set) Token: 0x06000023 RID: 35 RVA: 0x0000231E File Offset: 0x0000051E
		public ushort QDCOUNT { get; set; }

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000024 RID: 36 RVA: 0x00002327 File Offset: 0x00000527
		// (set) Token: 0x06000025 RID: 37 RVA: 0x0000232F File Offset: 0x0000052F
		public ushort ANCOUNT { get; set; }

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000026 RID: 38 RVA: 0x00002338 File Offset: 0x00000538
		// (set) Token: 0x06000027 RID: 39 RVA: 0x00002340 File Offset: 0x00000540
		public ushort NSCOUNT { get; set; }

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000028 RID: 40 RVA: 0x00002349 File Offset: 0x00000549
		// (set) Token: 0x06000029 RID: 41 RVA: 0x00002351 File Offset: 0x00000551
		public ushort ARCOUNT { get; set; }
	}
}
