using System;
using System.Text;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.DeviceDiscovery;
using Motorola.Common.Communication.SequenceManager;
using Motorola.Common.Communication.TetraUtility;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x0200004A RID: 74
	public class FrodoRadioFactory : global::Motorola.Common.Communication.CommunicationManager.SingleRadioFactory
	{
		// Token: 0x060001A9 RID: 425 RVA: 0x00007FBC File Offset: 0x000061BC
		public FrodoRadioFactory(global::Motorola.Common.Communication.CommonUtil.IObserver observer)
		{
			base.PIDList = new string[]
			{
				"9010",
				"9011"
			};
			this._observer = observer;
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00007FF4 File Offset: 0x000061F4
		protected override bool MyCreateRadio(out global::Motorola.Common.Communication.IMotoDevice radio, global::Motorola.Common.Communication.IRadioProfile hwProfile)
		{
			bool result = false;
			radio = null;
			if (hwProfile == null)
			{
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("LegacyRadioFactory.MyCreateRadio: The hwProfile is empty");
				return false;
			}
			if (!(hwProfile is global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile))
			{
				return false;
			}
			try
			{
				global::Motorola.Common.Communication.CommunicationManager.FrodoRadioFactory.SingleFrodoRadioCreator singleFrodoRadioCreator = new global::Motorola.Common.Communication.CommunicationManager.FrodoRadioFactory.SingleFrodoRadioCreator();
				radio = singleFrodoRadioCreator.CreateRadio(hwProfile);
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
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(e, (hwProfile as global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile).Path, "FrodoRadioFactory.CreateRadio: Got exception", new object[0]);
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(hwProfile.PhysicalLocation, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(e, "FrodoRadioFactory.CreateRadio: Got exception");
			}
			return result;
		}

		// Token: 0x04000055 RID: 85
		private global::Motorola.Common.Communication.CommonUtil.IObserver _observer;

		// Token: 0x0200004B RID: 75
		private class SingleFrodoRadioCreator
		{
			// Token: 0x060001AC RID: 428 RVA: 0x000080B4 File Offset: 0x000062B4
			public global::Motorola.Common.Communication.IMotoDevice CreateRadio(global::Motorola.Common.Communication.IRadioProfile hwProfile)
			{
				global::Motorola.Common.Communication.IMotoDevice result = null;
				if (hwProfile == null)
				{
					global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("SingleFrodoRadioCreator.CreateRadio: The hwProfile is empty");
					return result;
				}
				global::Motorola.Common.Communication.CommunicationManager.TetraVComDevice tetraVComDevice = this.newOneTetraVComDevice();
				this.OnAttach(hwProfile, tetraVComDevice);
				if (this._radioReady)
				{
					hwProfile.RadioId = global::System.Text.Encoding.ASCII.GetBytes(hwProfile.PhysicalLocation);
					tetraVComDevice.Profile = hwProfile;
					tetraVComDevice.DeviceInfo.RadioID = hwProfile.PhysicalLocation;
					tetraVComDevice.ChangeRadioState(global::Motorola.Common.Communication.CommonUtil.RadioState.Attached);
					if (tetraVComDevice.Profile.DeviceMode == global::Motorola.Common.Communication.CommonUtil.DeviceMode.NORMAL)
					{
						tetraVComDevice.DeviceInfo.Family = global::Motorola.Common.Communication.CommonUtil.ProductFamily.FrodoAppRadio;
					}
					else if (tetraVComDevice.Profile.DeviceMode == global::Motorola.Common.Communication.CommonUtil.DeviceMode.KERNEL)
					{
						tetraVComDevice.DeviceInfo.Family = global::Motorola.Common.Communication.CommonUtil.ProductFamily.FrodoProgRadio;
					}
					result = tetraVComDevice;
				}
				return result;
			}

			// Token: 0x060001AD RID: 429 RVA: 0x0000816C File Offset: 0x0000636C
			private void OnAttach(global::Motorola.Common.Communication.IRadioProfile hwProfile, global::Motorola.Common.Communication.CommunicationManager.TetraVComDevice radio)
			{
				global::Motorola.Common.Communication.CommunicationManager.RadioCreatorUtility radioCreatorUtility = new global::Motorola.Common.Communication.CommunicationManager.RadioCreatorUtility();
				radio.DeviceInfo.ConnectionInfo.ConnectionType = global::Motorola.Common.Communication.CommonUtil.ConnectionType.VCOM;
				this._radioReady = radioCreatorUtility.CreateSingleFrodoRadio(radio, hwProfile);
			}

			// Token: 0x060001AE RID: 430 RVA: 0x000081A0 File Offset: 0x000063A0
			private global::Motorola.Common.Communication.CommunicationManager.TetraVComDevice newOneTetraVComDevice()
			{
				return new global::Motorola.Common.Communication.CommunicationManager.TetraVComDevice();
			}

			// Token: 0x04000056 RID: 86
			private volatile bool _radioReady;
		}
	}
}
