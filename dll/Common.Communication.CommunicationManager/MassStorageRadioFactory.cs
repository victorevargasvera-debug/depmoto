using System;
using System.Text;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.DeviceDiscovery;
using Motorola.Common.Communication.SequenceManager;
using Motorola.Common.Communication.TetraUtility;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x02000052 RID: 82
	public class MassStorageRadioFactory : global::Motorola.Common.Communication.CommunicationManager.SingleRadioFactory
	{
		// Token: 0x060001CE RID: 462 RVA: 0x00009030 File Offset: 0x00007230
		public MassStorageRadioFactory(global::Motorola.Common.Communication.CommonUtil.IObserver observer)
		{
			this._observer = observer;
			base.PIDList = new string[]
			{
				"MASS_STORAGE_RADIO"
			};
		}

		// Token: 0x060001CF RID: 463 RVA: 0x00009060 File Offset: 0x00007260
		private global::Motorola.Common.Communication.CommunicationManager.TetraVComDevice newOneTetraVComDevice()
		{
			return new global::Motorola.Common.Communication.CommunicationManager.TetraVComDevice();
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x00009068 File Offset: 0x00007268
		protected override bool MyCreateRadio(out global::Motorola.Common.Communication.IMotoDevice radio, global::Motorola.Common.Communication.IRadioProfile hwProfile)
		{
			radio = null;
			bool result = false;
			if (hwProfile == null)
			{
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("MassStorageRadioFactory.MyCreateRadio: The hwProfile is empty");
				return false;
			}
			if (!(hwProfile is global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile))
			{
				return false;
			}
			try
			{
				global::Motorola.Common.Communication.CommunicationManager.TetraVComDevice tetraVComDevice = this.newOneTetraVComDevice();
				tetraVComDevice.DeviceInfo.ConnectionInfo.ConnectionType = global::Motorola.Common.Communication.CommonUtil.ConnectionType.VCOM;
				tetraVComDevice.DeviceInfo.Family = global::Motorola.Common.Communication.CommonUtil.ProductFamily.GemstoneBMPMassStorageRadio;
				global::Motorola.Common.Communication.CommunicationManager.RadioCreatorUtility radioCreatorUtility = new global::Motorola.Common.Communication.CommunicationManager.RadioCreatorUtility();
				bool flag = radioCreatorUtility.CreateMassStorageRadio(tetraVComDevice, hwProfile);
				if (flag)
				{
					tetraVComDevice.ChangeRadioState(global::Motorola.Common.Communication.CommonUtil.RadioState.Attached);
					tetraVComDevice.Profile = hwProfile;
					string cpuID = tetraVComDevice.CpuID;
					if (string.IsNullOrEmpty(cpuID))
					{
						tetraVComDevice.DeviceInfo.RadioID = hwProfile.PhysicalLocation;
						hwProfile.RadioId = global::System.Text.Encoding.ASCII.GetBytes(hwProfile.PhysicalLocation);
					}
					else
					{
						tetraVComDevice.DeviceInfo.RadioID = tetraVComDevice.CpuID;
						hwProfile.RadioId = global::System.Text.Encoding.ASCII.GetBytes(tetraVComDevice.CpuID);
					}
					radio = tetraVComDevice;
				}
				else
				{
					radio = null;
				}
				if (radio != null && global::Motorola.Common.Communication.CommunicationManager.CommunicationManagerClass.Instance.DiscoveryWorkMode == global::Motorola.Common.Communication.CommonUtil.WorkMode.Active)
				{
					radio.SynPrepareDevice();
				}
				result = (radio != null);
			}
			catch (global::System.Exception e)
			{
				radio = null;
				result = false;
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(hwProfile.PhysicalLocation, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(e, "GemstoneBMPRadioFactory.CreateRadio: Got exception");
			}
			return result;
		}

		// Token: 0x04000064 RID: 100
		private global::Motorola.Common.Communication.CommonUtil.IObserver _observer;
	}
}
