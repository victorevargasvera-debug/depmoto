using System;
using System.Collections.Generic;
using Motorola.Common.Communication.DeviceDiscovery;
using Motorola.Common.Communication.SequenceManager;
using Motorola.Common.Communication.TetraUtility;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x0200004D RID: 77
	public abstract class PairedRadiosFactory : global::Motorola.Common.Communication.IDeviceFactory
	{
		// Token: 0x060001B7 RID: 439 RVA: 0x0000870C File Offset: 0x0000690C
		public virtual bool CreateRadios(out global::System.Collections.Generic.List<global::Motorola.Common.Communication.IMotoDevice> radioList, global::System.Collections.Generic.List<global::Motorola.Common.Communication.IRadioProfile> profileList)
		{
			radioList = null;
			if (profileList == null)
			{
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("PairedRadiosFactory.CreateRadio: The profileList is empty");
				return false;
			}
			return profileList.Count == 2 && profileList[0] is global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile && profileList[1] is global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile && this.MyCreateRadio(out radioList, profileList);
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060001B8 RID: 440 RVA: 0x00008766 File Offset: 0x00006966
		// (set) Token: 0x060001B9 RID: 441 RVA: 0x0000876E File Offset: 0x0000696E
		public string[] PIDList { get; set; }

		// Token: 0x060001BA RID: 442 RVA: 0x00008778 File Offset: 0x00006978
		public virtual bool IsSupport(string productId)
		{
			foreach (string value in this.PIDList)
			{
				if (productId.Contains(value))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060001BB RID: 443
		protected abstract bool MyCreateRadio(out global::System.Collections.Generic.List<global::Motorola.Common.Communication.IMotoDevice> radioList, global::System.Collections.Generic.List<global::Motorola.Common.Communication.IRadioProfile> profileList);
	}
}
