using System;
using Motorola.Common.Communication.CommonUtil;

namespace Motorola.Common.Communication
{
	// Token: 0x02000010 RID: 16
	public interface IRadioProfile
	{
		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060000B7 RID: 183
		// (set) Token: 0x060000B8 RID: 184
		byte[] RadioId { get; set; }

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060000B9 RID: 185
		string RadioIdString { get; }

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000BA RID: 186
		// (set) Token: 0x060000BB RID: 187
		string PhysicalLocation { get; set; }

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000BC RID: 188
		// (set) Token: 0x060000BD RID: 189
		global::Motorola.Common.Communication.CommonUtil.DeviceMode DeviceMode { get; set; }

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000BE RID: 190
		// (set) Token: 0x060000BF RID: 191
		string PID { get; set; }

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000C0 RID: 192
		// (set) Token: 0x060000C1 RID: 193
		string VID { get; set; }

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000C2 RID: 194
		// (set) Token: 0x060000C3 RID: 195
		string UniqueLocation { get; set; }

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000C4 RID: 196
		// (set) Token: 0x060000C5 RID: 197
		global::Motorola.Common.Communication.RadioType RadioType { get; set; }
	}
}
