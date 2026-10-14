using System;
using System.Collections.Generic;

namespace Motorola.Common.Communication
{
	// Token: 0x02000005 RID: 5
	public interface IDeviceFactory
	{
		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600001D RID: 29
		// (set) Token: 0x0600001E RID: 30
		string[] PIDList { get; set; }

		// Token: 0x0600001F RID: 31
		bool CreateRadios(out global::System.Collections.Generic.List<global::Motorola.Common.Communication.IMotoDevice> radioList, global::System.Collections.Generic.List<global::Motorola.Common.Communication.IRadioProfile> hwProfileList);

		// Token: 0x06000020 RID: 32
		bool IsSupport(string productId);
	}
}
