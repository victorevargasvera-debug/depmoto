using System;

namespace Motorola.Common.Communication
{
	// Token: 0x02000047 RID: 71
	public static class RPConstants
	{
		// Token: 0x040000C8 RID: 200
		public const int REJECTION_VERIFY_THRESHOLD = 13;

		// Token: 0x040000C9 RID: 201
		public const int RP_MSG_ID_LOCATION = 3;

		// Token: 0x040000CA RID: 202
		public const byte RP_MESSAGE_TYPE = 0;

		// Token: 0x040000CB RID: 203
		public const int RP_MESSAGE_CONTENT_START_INDEX = 4;

		// Token: 0x040000CC RID: 204
		public const string RP_INVALID_ID = "FFFFFFFFFFFFFFFF";

		// Token: 0x040000CD RID: 205
		public const int RP_VERSION_NUMBER_OF_FLASH_PACK_BUFFER_SIZE = 16;

		// Token: 0x040000CE RID: 206
		public const int RP_VERSION_NUMBER_OF_FLASH_PACKS_MAX = 20;

		// Token: 0x040000CF RID: 207
		public const int RP_VERSION_REQUEST_CONFIRM_MIN_NUMBER = 14;
	}
}
