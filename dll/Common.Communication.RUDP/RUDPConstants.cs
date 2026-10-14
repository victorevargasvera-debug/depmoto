using System;

namespace Motorola.Common.Communication.RUDP
{
	// Token: 0x02000013 RID: 19
	internal static class RUDPConstants
	{
		// Token: 0x04000084 RID: 132
		public static readonly ushort DEFAULT_SEQ_ACK_NUM = 0;

		// Token: 0x04000085 RID: 133
		public static readonly byte RUDP_HEADER_LEN = 6;

		// Token: 0x04000086 RID: 134
		private static readonly byte IP_OPTIONS_LEN = 0;

		// Token: 0x04000087 RID: 135
		private static readonly byte IP_HEADER_LEN = 20 + global::Motorola.Common.Communication.RUDP.RUDPConstants.IP_OPTIONS_LEN;

		// Token: 0x04000088 RID: 136
		private static readonly byte UDP_HEADER_LEN = 8;

		// Token: 0x04000089 RID: 137
		public static readonly byte ALL_HEADERS_LEN = global::Motorola.Common.Communication.RUDP.RUDPConstants.IP_HEADER_LEN + global::Motorola.Common.Communication.RUDP.RUDPConstants.UDP_HEADER_LEN + global::Motorola.Common.Communication.RUDP.RUDPConstants.RUDP_HEADER_LEN;

		// Token: 0x0400008A RID: 138
		private static readonly ushort RUDP_MIN_FRG_SIZE = (ushort)(global::Motorola.Common.Communication.RUDP.RUDPConstants.IP_HEADER_LEN + global::Motorola.Common.Communication.RUDP.RUDPConstants.UDP_HEADER_LEN + global::Motorola.Common.Communication.RUDP.RUDPConstants.RUDP_HEADER_LEN);

		// Token: 0x0400008B RID: 139
		public static readonly ushort RUDP_MAX_FRG_SIZE = 1024;

		// Token: 0x0400008C RID: 140
		public static readonly ushort RUDP_SEND_BUFF_SIZE = 20480;

		// Token: 0x0400008D RID: 141
		public static readonly ushort RUDP_RECV_BUFF_SIZE = ushort.MaxValue;

		// Token: 0x0400008E RID: 142
		public static readonly byte RUDP_HD_SYN_MASK = 128;

		// Token: 0x0400008F RID: 143
		public static readonly byte RUDP_HD_ACK_MASK = 64;

		// Token: 0x04000090 RID: 144
		public static readonly byte RUDP_HD_EAK_MASK = 32;

		// Token: 0x04000091 RID: 145
		public static readonly byte RUDP_HD_RST_MASK = 16;

		// Token: 0x04000092 RID: 146
		public static readonly byte RUDP_HD_NUL_MASK = 8;

		// Token: 0x04000093 RID: 147
		public static readonly byte RUDP_HD_FRG_MASK = 4;

		// Token: 0x04000094 RID: 148
		public static readonly byte RUDP_HD_VER_MASK = 3;

		// Token: 0x04000095 RID: 149
		public static readonly byte RUDP_PL_SYN_SDM_MASK = 128;

		// Token: 0x04000096 RID: 150
		public static readonly byte RUDP_HEADER_VER = 0;

		// Token: 0x04000097 RID: 151
		public static readonly byte RUDP_PL_SYN_SECTION_LEN = 6;

		// Token: 0x04000098 RID: 152
		public static readonly byte RUDP_PL_SESSION_PARAMS_SECTION_LEN = 6;

		// Token: 0x04000099 RID: 153
		public static readonly int RUDP_DEFAULT_SLIDING_WIN_SIZE = 1;

		// Token: 0x0400009A RID: 154
		public static readonly int RUDP_TIMER_UNIT = 1000;
	}
}
