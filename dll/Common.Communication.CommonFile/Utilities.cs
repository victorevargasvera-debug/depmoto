using System;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.CommonFile
{
	// Token: 0x02000007 RID: 7
	internal class Utilities
	{
		// Token: 0x0600000A RID: 10 RVA: 0x000025B5 File Offset: 0x000007B5
		private Utilities()
		{
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000025BD File Offset: 0x000007BD
		public static ushort ToUInt16(byte[] data, int startIndex)
		{
			if (startIndex + 2 > data.Length)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentOutOfRange);
			}
			return (ushort)((int)data[startIndex + 1] << 8 | (int)data[startIndex]);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000025DA File Offset: 0x000007DA
		public static uint ToUInt32(byte[] data, int startIndex)
		{
			if (startIndex + 4 > data.Length)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentOutOfRange);
			}
			return (uint)((int)data[startIndex + 3] << 24 | (int)data[startIndex + 2] << 16 | (int)data[startIndex + 1] << 8 | (int)data[startIndex]);
		}
	}
}
