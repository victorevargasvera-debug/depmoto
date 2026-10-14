using System;
using System.Collections.Generic;
using System.Text;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.DeviceDiscovery;
using Motorola.Common.Communication.SequenceManager;
using Motorola.Common.Communication.TetraUtility;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x0200004E RID: 78
	public class GemstoneDataBoxFactory : global::Motorola.Common.Communication.CommunicationManager.PairedRadiosFactory
	{
		// Token: 0x060001BD RID: 445 RVA: 0x000087B8 File Offset: 0x000069B8
		public GemstoneDataBoxFactory(global::Motorola.Common.Communication.CommonUtil.IObserver observer)
		{
			this._observer = observer;
			base.PIDList = new string[]
			{
				"9011",
				"9012",
				"9013"
			};
		}

		// Token: 0x060001BE RID: 446 RVA: 0x000087F8 File Offset: 0x000069F8
		protected override bool MyCreateRadio(out global::System.Collections.Generic.List<global::Motorola.Common.Communication.IMotoDevice> radioList, global::System.Collections.Generic.List<global::Motorola.Common.Communication.IRadioProfile> profileList)
		{
			radioList = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.IMotoDevice>();
			bool result = false;
			if (profileList == null)
			{
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("FrodoDataBoxFactory.MyCreateRadio: The profileList is empty");
				return false;
			}
			string uniqueLocation = profileList[1].UniqueLocation;
			try
			{
				global::Motorola.Common.Communication.CommunicationManager.GemstoneDataBoxFactory.GemstoneDataBox gemstoneDataBox = new global::Motorola.Common.Communication.CommunicationManager.GemstoneDataBoxFactory.GemstoneDataBox();
				radioList = gemstoneDataBox.CreateRadio(profileList);
				foreach (global::Motorola.Common.Communication.IMotoDevice motoDevice in radioList)
				{
					if (global::Motorola.Common.Communication.CommunicationManager.CommunicationManagerClass.Instance.DiscoveryWorkMode == global::Motorola.Common.Communication.CommonUtil.WorkMode.Active)
					{
						motoDevice.SynPrepareDevice();
					}
				}
				result = (radioList.Count != 0);
			}
			catch (global::System.Exception e)
			{
				result = false;
				radioList = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.IMotoDevice>();
				foreach (global::Motorola.Common.Communication.IRadioProfile radioProfile in profileList)
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(e, (radioProfile as global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile).Path, "FrodoDataBoxFactory.CreateRadio: Got exception", new object[0]);
					global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(radioProfile.PhysicalLocation, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(e, "FrodoDataBox.CreateRadio: Got exception");
				}
			}
			return result;
		}

		// Token: 0x04000059 RID: 89
		private global::Motorola.Common.Communication.CommonUtil.IObserver _observer;

		// Token: 0x0200004F RID: 79
		private class GemstoneDataBox
		{
			// Token: 0x060001C0 RID: 448 RVA: 0x00008934 File Offset: 0x00006B34
			public global::System.Collections.Generic.List<global::Motorola.Common.Communication.IMotoDevice> CreateRadio(global::System.Collections.Generic.List<global::Motorola.Common.Communication.IRadioProfile> profileList)
			{
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.IMotoDevice> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.IMotoDevice>();
				if (profileList == null)
				{
					global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("FrodoDataBox.CreateRadio: The profileList is empty");
					return list;
				}
				global::Motorola.Common.Communication.CommunicationManager.TetraVComDevice tetraVComDevice = this.newOneTetraVComDevice();
				global::Motorola.Common.Communication.CommunicationManager.TetraVComDevice tetraVComDevice2 = this.newOneTetraVComDevice();
				this.OnAttach(profileList, tetraVComDevice, tetraVComDevice2);
				if (this._partOneRadioReady)
				{
					tetraVComDevice.ChangeRadioState(global::Motorola.Common.Communication.CommonUtil.RadioState.Attached);
					list.Add(tetraVComDevice);
				}
				if (this._partTwoRadioReady)
				{
					tetraVComDevice2.ChangeRadioState(global::Motorola.Common.Communication.CommonUtil.RadioState.Attached);
					list.Add(tetraVComDevice2);
				}
				return list;
			}

			// Token: 0x060001C1 RID: 449 RVA: 0x000089A8 File Offset: 0x00006BA8
			private void OnAttach(global::System.Collections.Generic.List<global::Motorola.Common.Communication.IRadioProfile> hwProfileList, global::Motorola.Common.Communication.CommunicationManager.TetraVComDevice partOneRadio, global::Motorola.Common.Communication.CommunicationManager.TetraVComDevice partTwoRadio)
			{
				partOneRadio.DeviceInfo.ConnectionInfo.ConnectionType = global::Motorola.Common.Communication.CommonUtil.ConnectionType.VCOM;
				partTwoRadio.DeviceInfo.ConnectionInfo.ConnectionType = global::Motorola.Common.Communication.CommonUtil.ConnectionType.VCOM;
				global::Motorola.Common.Communication.CommunicationManager.RadioCreatorUtility radioCreatorUtility = new global::Motorola.Common.Communication.CommunicationManager.RadioCreatorUtility();
				this._partOneRadioReady = false;
				this._partTwoRadioReady = false;
				string text = string.Empty;
				global::Motorola.Common.Communication.IRadioProfile radioProfile = null;
				global::Motorola.Common.Communication.IRadioProfile radioProfile2 = null;
				for (int i = 0; i < hwProfileList.Count; i++)
				{
					if ((hwProfileList[i] as global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile).TetraRadioType == global::Motorola.Common.Communication.CommonUtil.TetraRadioType.DATABOX_PORT1)
					{
						radioProfile = hwProfileList[i];
					}
					else if ((hwProfileList[i] as global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile).TetraRadioType == global::Motorola.Common.Communication.CommonUtil.TetraRadioType.DATABOX_PORT2)
					{
						radioProfile2 = hwProfileList[i];
					}
				}
				if (radioProfile.PID.Contains("9011"))
				{
					this._partOneRadioReady = radioCreatorUtility.CreateSingleFrodoRadio(partOneRadio, radioProfile);
					if (this._partOneRadioReady)
					{
						radioProfile.RadioId = global::System.Text.Encoding.ASCII.GetBytes(radioProfile.PhysicalLocation);
						partOneRadio.Profile = radioProfile;
						partOneRadio.DeviceInfo.RadioID = radioProfile.PhysicalLocation;
						partOneRadio.DeviceInfo.Family = global::Motorola.Common.Communication.CommonUtil.ProductFamily.FrodoAppRadio;
					}
					this._partTwoRadioReady = radioCreatorUtility.CreateSingleFrodoRadio(partTwoRadio, radioProfile2);
					if (this._partTwoRadioReady)
					{
						radioProfile2.RadioId = global::System.Text.Encoding.ASCII.GetBytes(radioProfile2.PhysicalLocation);
						partTwoRadio.Profile = radioProfile2;
						partTwoRadio.DeviceInfo.RadioID = radioProfile2.PhysicalLocation;
						partTwoRadio.DeviceInfo.Family = global::Motorola.Common.Communication.CommonUtil.ProductFamily.FrodoAppRadio;
						return;
					}
				}
				else
				{
					this._partOneRadioReady = radioCreatorUtility.CreateSingleGemstoneBMPRadio(partOneRadio, radioProfile);
					if (this._partOneRadioReady)
					{
						partOneRadio.Profile = radioProfile;
						partOneRadio.DeviceInfo.Family = global::Motorola.Common.Communication.CommonUtil.ProductFamily.GemstoneBMPAppRadio;
						text = partOneRadio.CpuID;
						if (!string.IsNullOrEmpty(text))
						{
							partOneRadio.DeviceInfo.RadioID = text;
							radioProfile.RadioId = global::System.Text.Encoding.ASCII.GetBytes(text);
						}
						else
						{
							partOneRadio.DeviceInfo.RadioID = radioProfile.PhysicalLocation;
							radioProfile.RadioId = global::System.Text.Encoding.ASCII.GetBytes(radioProfile.PhysicalLocation);
						}
					}
					this._partTwoRadioReady = radioCreatorUtility.CreateSingleGemstoneBMPRadio(partTwoRadio, radioProfile2);
					if (this._partTwoRadioReady)
					{
						partTwoRadio.Profile = radioProfile2;
						partTwoRadio.DeviceInfo.Family = global::Motorola.Common.Communication.CommonUtil.ProductFamily.GemstoneBMPAppRadio;
						text = partTwoRadio.CpuID;
						if (!string.IsNullOrEmpty(text))
						{
							partTwoRadio.DeviceInfo.RadioID = text;
							radioProfile2.RadioId = global::System.Text.Encoding.ASCII.GetBytes(text);
							return;
						}
						partTwoRadio.DeviceInfo.RadioID = radioProfile2.PhysicalLocation;
						radioProfile2.RadioId = global::System.Text.Encoding.ASCII.GetBytes(radioProfile2.PhysicalLocation);
					}
				}
			}

			// Token: 0x060001C2 RID: 450 RVA: 0x00008C20 File Offset: 0x00006E20
			private global::Motorola.Common.Communication.CommunicationManager.TetraVComDevice newOneTetraVComDevice()
			{
				return new global::Motorola.Common.Communication.CommunicationManager.TetraVComDevice();
			}

			// Token: 0x0400005A RID: 90
			private volatile bool _partOneRadioReady;

			// Token: 0x0400005B RID: 91
			private volatile bool _partTwoRadioReady;
		}
	}
}
