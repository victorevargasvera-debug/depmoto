using System;

namespace Motorola.Common.Communication.CommonFile
{
	// Token: 0x02000004 RID: 4
	internal static class CommFileConstants
	{
		// Token: 0x04000005 RID: 5
		public const byte HeaderVerLength = 1;

		// Token: 0x04000006 RID: 6
		public const byte LevelLength = 1;

		// Token: 0x04000007 RID: 7
		public const byte HeaderLength = 3;

		// Token: 0x04000008 RID: 8
		public const byte Crc32Length = 4;

		// Token: 0x04000009 RID: 9
		public const byte IshTypeLength = 2;

		// Token: 0x0400000A RID: 10
		public const byte IshIDLength = 2;

		// Token: 0x0400000B RID: 11
		public const byte CounterLength = 4;

		// Token: 0x0400000C RID: 12
		public const byte ItemLength = 2;

		// Token: 0x0400000D RID: 13
		public const byte CommonFileVersion = 16;

		// Token: 0x0400000E RID: 14
		public const byte PartIdLength = 2;

		// Token: 0x0400000F RID: 15
		public const byte PartIdMarkerLength = 2;

		// Token: 0x04000010 RID: 16
		public const ushort PartIdMarker = 65535;
	}
}
