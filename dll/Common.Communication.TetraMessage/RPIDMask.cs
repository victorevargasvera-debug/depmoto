using System;

namespace Motorola.Common.Communication
{
	// Token: 0x02000049 RID: 73
	public static class RPIDMask
	{
		// Token: 0x1700006D RID: 109
		// (get) Token: 0x0600021A RID: 538 RVA: 0x00009958 File Offset: 0x00007B58
		// (set) Token: 0x0600021B RID: 539 RVA: 0x0000995F File Offset: 0x00007B5F
		public static byte RP_ID_SCHEME_MASK
		{
			get
			{
				return global::Motorola.Common.Communication.RPIDMask._RP_ID_SCHEME_MASK;
			}
			set
			{
				global::Motorola.Common.Communication.RPIDMask._RP_ID_SCHEME_MASK = value;
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x0600021C RID: 540 RVA: 0x00009967 File Offset: 0x00007B67
		// (set) Token: 0x0600021D RID: 541 RVA: 0x0000996E File Offset: 0x00007B6E
		public static byte RP_TEI_5_5_MASK
		{
			get
			{
				return global::Motorola.Common.Communication.RPIDMask._RP_TEI_5_5_MASK;
			}
			set
			{
				global::Motorola.Common.Communication.RPIDMask._RP_TEI_5_5_MASK = value;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x0600021E RID: 542 RVA: 0x00009976 File Offset: 0x00007B76
		// (set) Token: 0x0600021F RID: 543 RVA: 0x0000997D File Offset: 0x00007B7D
		public static byte RP_TEI_5_6_MASK
		{
			get
			{
				return global::Motorola.Common.Communication.RPIDMask._RP_TEI_5_6_MASK;
			}
			set
			{
				global::Motorola.Common.Communication.RPIDMask._RP_TEI_5_6_MASK = value;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000220 RID: 544 RVA: 0x00009985 File Offset: 0x00007B85
		// (set) Token: 0x06000221 RID: 545 RVA: 0x0000998C File Offset: 0x00007B8C
		public static byte RP_SERIAL_NUMBER_MASK
		{
			get
			{
				return global::Motorola.Common.Communication.RPIDMask._RP_SERIAL_NUMBER_MASK;
			}
			set
			{
				global::Motorola.Common.Communication.RPIDMask._RP_SERIAL_NUMBER_MASK = value;
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000222 RID: 546 RVA: 0x00009994 File Offset: 0x00007B94
		// (set) Token: 0x06000223 RID: 547 RVA: 0x0000999B File Offset: 0x00007B9B
		public static byte RP_DIE_ID_MASK
		{
			get
			{
				return global::Motorola.Common.Communication.RPIDMask._RP_DIE_ID_MASK;
			}
			set
			{
				global::Motorola.Common.Communication.RPIDMask._RP_DIE_ID_MASK = value;
			}
		}

		// Token: 0x040000D3 RID: 211
		private static byte _RP_ID_SCHEME_MASK = 224;

		// Token: 0x040000D4 RID: 212
		private static byte _RP_TEI_5_5_MASK = 0;

		// Token: 0x040000D5 RID: 213
		private static byte _RP_TEI_5_6_MASK = 32;

		// Token: 0x040000D6 RID: 214
		private static byte _RP_SERIAL_NUMBER_MASK = 64;

		// Token: 0x040000D7 RID: 215
		private static byte _RP_DIE_ID_MASK = 128;
	}
}
