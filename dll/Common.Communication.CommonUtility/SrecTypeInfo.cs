using System;

namespace Motorola.Common.Communication
{
	// Token: 0x0200000C RID: 12
	internal static class SrecTypeInfo
	{
		// Token: 0x06000025 RID: 37 RVA: 0x00002690 File Offset: 0x00000890
		public static int GetAddressSize(global::Motorola.Common.Communication.SrecType srecType)
		{
			int result;
			if (srecType != global::Motorola.Common.Communication.SrecType.S0)
			{
				if (srecType != global::Motorola.Common.Communication.SrecType.S3)
				{
					if (srecType != global::Motorola.Common.Communication.SrecType.S7)
					{
						throw new global::System.NotImplementedException();
					}
					result = 4;
				}
				else
				{
					result = 4;
				}
			}
			else
			{
				result = 2;
			}
			return result;
		}
	}
}
