using System;
using System.Collections.Generic;
using Motorola.Common.Communication.SequenceManager;
using Motorola.Common.Communication.TetraUtility;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x02000049 RID: 73
	public abstract class SingleRadioFactory : global::Motorola.Common.Communication.IDeviceFactory
	{
		// Token: 0x060001A3 RID: 419 RVA: 0x00007F14 File Offset: 0x00006114
		public virtual bool CreateRadios(out global::System.Collections.Generic.List<global::Motorola.Common.Communication.IMotoDevice> radioList, global::System.Collections.Generic.List<global::Motorola.Common.Communication.IRadioProfile> profileList)
		{
			radioList = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.IMotoDevice>();
			if (profileList == null)
			{
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("SingleRadioFactory.CreateRadio: The profileList is empty");
				return false;
			}
			if (profileList.Count != 1)
			{
				return false;
			}
			global::Motorola.Common.Communication.IMotoDevice motoDevice;
			bool result = this.MyCreateRadio(out motoDevice, profileList[0]);
			if (motoDevice != null)
			{
				radioList.Add(motoDevice);
			}
			return result;
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060001A4 RID: 420 RVA: 0x00007F68 File Offset: 0x00006168
		// (set) Token: 0x060001A5 RID: 421 RVA: 0x00007F70 File Offset: 0x00006170
		public string[] PIDList { get; set; }

		// Token: 0x060001A6 RID: 422 RVA: 0x00007F7C File Offset: 0x0000617C
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

		// Token: 0x060001A7 RID: 423
		protected abstract bool MyCreateRadio(out global::Motorola.Common.Communication.IMotoDevice radio, global::Motorola.Common.Communication.IRadioProfile hwProfile);
	}
}
