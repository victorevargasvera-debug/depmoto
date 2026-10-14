using System;

namespace Motorola.Common.Communication
{
	// Token: 0x02000033 RID: 51
	public static class SBEPReplyCode
	{
		// Token: 0x04000088 RID: 136
		public const ushort READ_DATA_REPLY = 65408;

		// Token: 0x04000089 RID: 137
		public const ushort CHECKSUM_REPLY = 62337;

		// Token: 0x0400008A RID: 138
		public const ushort CONFIGURATION_REPLY = 62594;

		// Token: 0x0400008B RID: 139
		public const ushort STATUS_REPLY = 62851;

		// Token: 0x0400008C RID: 140
		public const ushort GOOD_WRITE_REPLY = 62596;

		// Token: 0x0400008D RID: 141
		public const ushort BAD_WRITE_REPLY = 62597;

		// Token: 0x0400008E RID: 142
		public const ushort UNSUPPORTED_OPCODE_REPLY = 61830;

		// Token: 0x0400008F RID: 143
		public const ushort EX_READ_DATA_REPLY = 65456;

		// Token: 0x04000090 RID: 144
		public const ushort EX_CHECKSUM_REPLY = 62385;

		// Token: 0x04000091 RID: 145
		public const ushort EX_STATUS_REPLY = 63155;

		// Token: 0x04000092 RID: 146
		public const ushort EX_GOOD_WRITE_REPLY = 62900;

		// Token: 0x04000093 RID: 147
		public const ushort EX_BAD_WRITE_REPLY = 62901;
	}
}
