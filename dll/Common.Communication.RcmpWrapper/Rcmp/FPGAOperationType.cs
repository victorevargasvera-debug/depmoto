using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x02000022 RID: 34
	[global::System.Flags]
	public enum FPGAOperationType : byte
	{
		// Token: 0x040000A1 RID: 161
		Reconfigure = 0,
		// Token: 0x040000A2 RID: 162
		Erase = 32,
		// Token: 0x040000A3 RID: 163
		EraseStatus = 64
	}
}
