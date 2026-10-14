using System;
using System.Collections.Generic;

namespace Motorola.Common.Communication
{
	// Token: 0x02000006 RID: 6
	public abstract class DeviceFactoryBase : global::Motorola.Common.Communication.IDeviceFactory
	{
		// Token: 0x06000021 RID: 33 RVA: 0x000021A0 File Offset: 0x000003A0
		public virtual bool CreateRadios(out global::System.Collections.Generic.List<global::Motorola.Common.Communication.IMotoDevice> radioList, global::System.Collections.Generic.List<global::Motorola.Common.Communication.IRadioProfile> hwProfileList)
		{
			radioList = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.IMotoDevice>();
			if (hwProfileList.Count != 1 && hwProfileList.Count != 2)
			{
				return false;
			}
			bool flag = false;
			foreach (global::Motorola.Common.Communication.IRadioProfile hwProfile in hwProfileList)
			{
				global::Motorola.Common.Communication.IMotoDevice motoDevice;
				flag = this.CreateRadio(out motoDevice, hwProfile);
				if (!flag)
				{
					break;
				}
				if (motoDevice != null)
				{
					radioList.Add(motoDevice);
				}
			}
			return flag;
		}

		// Token: 0x06000022 RID: 34
		protected abstract bool CreateRadio(out global::Motorola.Common.Communication.IMotoDevice radio, global::Motorola.Common.Communication.IRadioProfile hwProfile);

		// Token: 0x06000023 RID: 35 RVA: 0x00002220 File Offset: 0x00000420
		public virtual bool IsSupport(string productId)
		{
			foreach (string value in this.PIDList)
			{
				if (productId.Equals(value))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000024 RID: 36 RVA: 0x00002256 File Offset: 0x00000456
		// (set) Token: 0x06000025 RID: 37 RVA: 0x0000225E File Offset: 0x0000045E
		public string[] PIDList { get; set; }
	}
}
