using System;
using System.Collections.Generic;
using System.Diagnostics;
using Common.Communication.Simulator;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.DeviceDiscovery;
using Motorola.Common.Communication.PCRRemoteProgramming;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x02000024 RID: 36
	internal class MotoDeviceDetector
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000115 RID: 277 RVA: 0x000065DC File Offset: 0x000047DC
		// (remove) Token: 0x06000116 RID: 278 RVA: 0x00006614 File Offset: 0x00004814
		public event global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler DeviceChanged;

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000117 RID: 279 RVA: 0x0000664C File Offset: 0x0000484C
		// (remove) Token: 0x06000118 RID: 280 RVA: 0x00006684 File Offset: 0x00004884
		public event global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler OrginalDeviceAttached;

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000119 RID: 281 RVA: 0x000066B9 File Offset: 0x000048B9
		public static global::Motorola.Common.Communication.CommunicationManager.MotoDeviceDetector Instance
		{
			get
			{
				return global::Motorola.Common.Communication.CommunicationManager.MotoDeviceDetector._self;
			}
		}

		// Token: 0x0600011A RID: 282 RVA: 0x000066C0 File Offset: 0x000048C0
		public void Start(int deviceFamilySet)
		{
			lock (this.detectorLocker)
			{
				this._deviceFamilySet = deviceFamilySet;
				this.InitRadioFactory();
				foreach (global::Motorola.Common.Communication.DeviceDiscovery.IDeviceDetector deviceDetector in this.deviceDetectorList)
				{
					deviceDetector.deviceAttached += this.DeviceAttached;
					deviceDetector.deviceDetached += this.DeviceDetached;
					if (!deviceDetector.Start())
					{
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerDeviceDetectorStartFailure);
					}
				}
			}
		}

		// Token: 0x0600011B RID: 283 RVA: 0x0000677C File Offset: 0x0000497C
		public void Stop()
		{
			lock (this.detectorLocker)
			{
				foreach (global::Motorola.Common.Communication.DeviceDiscovery.IDeviceDetector deviceDetector in this.deviceDetectorList)
				{
					deviceDetector.deviceAttached -= this.DeviceAttached;
					deviceDetector.deviceDetached -= this.DeviceDetached;
					deviceDetector.Stop();
				}
			}
		}

		// Token: 0x0600011C RID: 284 RVA: 0x0000681C File Offset: 0x00004A1C
		private void InitRadioFactory()
		{
			if ((this._deviceFamilySet & 32512) != 0)
			{
				this.deviceDetectorList.Add(new global::Motorola.Common.Communication.DeviceDiscovery.VCOMDetector());
				this.radioFactoryList.Add(new global::Motorola.Common.Communication.CommunicationManager.LegacyRadioFactory(global::Motorola.Common.Communication.CommunicationManager.CommunicationManagerClass.Instance));
				this.radioFactoryList.Add(new global::Motorola.Common.Communication.CommunicationManager.NGCHPairedRadiosFactory(global::Motorola.Common.Communication.CommunicationManager.CommunicationManagerClass.Instance));
				this.radioFactoryList.Add(new global::Motorola.Common.Communication.CommunicationManager.FrodoRadioFactory(global::Motorola.Common.Communication.CommunicationManager.CommunicationManagerClass.Instance));
				this.radioFactoryList.Add(new global::Motorola.Common.Communication.CommunicationManager.GemstoneDataBoxFactory(global::Motorola.Common.Communication.CommunicationManager.CommunicationManagerClass.Instance));
				this.radioFactoryList.Add(new global::Motorola.Common.Communication.CommunicationManager.GemstoneBMPRadioFactory(global::Motorola.Common.Communication.CommunicationManager.CommunicationManagerClass.Instance));
				this.radioFactoryList.Add(new global::Motorola.Common.Communication.CommunicationManager.MassStorageRadioFactory(global::Motorola.Common.Communication.CommunicationManager.CommunicationManagerClass.Instance));
			}
			if ((this._deviceFamilySet & 1) != 0 || (this._deviceFamilySet & 196734) != 0)
			{
				this.deviceDetectorList.Add(new global::Motorola.Common.Communication.DeviceDiscovery.RNDISDetector());
			}
			if (global::Motorola.Common.Communication.CommunicationManager.CommunicationManagerClass.Instance.DiscoveryWorkMode == global::Motorola.Common.Communication.CommonUtil.WorkMode.Active && ((this._deviceFamilySet & 1) != 0 || (this._deviceFamilySet & 128) != 0 || (this._deviceFamilySet & 8) != 0))
			{
				this.deviceDetectorList.Add(global::Motorola.Common.Communication.CommonUtil.SingletonBase<global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector>.Instance());
			}
			if ((this._deviceFamilySet & 1) != 0)
			{
				this.radioFactoryList.Add(new global::Motorola.Common.Communication.CommunicationManager.AstroRadioFactory(global::Motorola.Common.Communication.CommunicationManager.CommunicationManagerClass.Instance));
				this.radioFactoryList.Add(new global::Motorola.Common.Communication.CommunicationManager.AstroWiFiRadioFactory(global::Motorola.Common.Communication.CommunicationManager.CommunicationManagerClass.Instance));
			}
			if ((this._deviceFamilySet & 196734) != 0)
			{
				this.deviceDetectorList.Add(global::Motorola.Common.Communication.CommonUtil.SingletonBase<global::Motorola.Common.Communication.PCRRemoteProgramming.PCRRemoteDeviceDetector>.Instance());
				this.radioFactoryList.Add(new global::Motorola.Common.Communication.CommunicationManager.PCRRadioFactory(global::Motorola.Common.Communication.CommunicationManager.CommunicationManagerClass.Instance));
				this.radioFactoryList.Add(new global::Motorola.Common.Communication.CommunicationManager.PCRRemoteDeviceFactory(global::Motorola.Common.Communication.CommunicationManager.CommunicationManagerClass.Instance));
				this.radioFactoryList.Add(new global::Motorola.Common.Communication.CommunicationManager.PCRWiFiRadioFactory(global::Motorola.Common.Communication.CommunicationManager.CommunicationManagerClass.Instance));
			}
			if ((this._deviceFamilySet & 128) != 0)
			{
				this.deviceDetectorList.Add(global::Motorola.Common.Communication.CommonUtil.SingletonBase<global::Motorola.Common.Communication.DeviceDiscovery.PBBDetector>.Instance());
				this.radioFactoryList.Add(new global::Motorola.Common.Communication.CommunicationManager.PBBRadioFactory(global::Motorola.Common.Communication.CommunicationManager.CommunicationManagerClass.Instance));
				this.radioFactoryList.Add(new global::Motorola.Common.Communication.CommunicationManager.PBBWiFiRadioFactory(global::Motorola.Common.Communication.CommunicationManager.CommunicationManagerClass.Instance));
			}
			this.deviceDetectorList.Add(global::Motorola.Common.Communication.CommonUtil.SingletonBase<global::Common.Communication.Simulator.VirtualDeviceDetector>.Instance());
			this.radioFactoryList.Add(new global::Common.Communication.Simulator.VirtualDeviceFactory());
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00006A28 File Offset: 0x00004C28
		private void DeviceDetached(object sender, global::Motorola.Common.Communication.DeviceDiscovery.DeviceMsgEventArgs e)
		{
			global::System.Diagnostics.Trace.WriteLine("DeviceDetached: Received An Detaching Message!");
			if (this.DeviceChanged != null)
			{
				this.DeviceChanged(this, e);
			}
			foreach (object obj in e.RadioInfoSet)
			{
				global::Motorola.Common.Communication.IRadioProfile radioProfile = (global::Motorola.Common.Communication.IRadioProfile)obj;
				global::Motorola.Common.Communication.CommunicationManager.CommunicationManagerClass.Instance.RemoveDevice(radioProfile.RadioIdString);
			}
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00006AAC File Offset: 0x00004CAC
		private void DeviceAttached(object sender, global::Motorola.Common.Communication.DeviceDiscovery.DeviceMsgEventArgs e)
		{
			global::System.Diagnostics.Trace.WriteLine("DeviceAttached: Received An Attaching Message!");
			if (this.OrginalDeviceAttached != null)
			{
				this.OrginalDeviceAttached(this, e);
			}
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.IRadioProfile> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.IRadioProfile>();
			for (int i = 0; i < e.RadioInfoSet.Count; i++)
			{
				list.Add(e.RadioInfoSet[i] as global::Motorola.Common.Communication.IRadioProfile);
			}
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.IMotoDevice> list2 = null;
			if (this.CreateDevice(out list2, list))
			{
				if (list2 != null)
				{
					for (int j = 0; j < list2.Count; j++)
					{
						global::Motorola.Common.Communication.CommunicationManager.CommunicationManagerClass.Instance.AddDevice(list2[j]);
						global::Motorola.Common.Communication.RadioType radioType = (e.RadioInfoSet[0] as global::Motorola.Common.Communication.IRadioProfile).RadioType;
						if (radioType != global::Motorola.Common.Communication.RadioType.TETRA)
						{
							e.RadioInfoSet[j] = list2[j].DeviceInfo.Copy();
						}
						if (this.DeviceChanged != null)
						{
							this.DeviceChanged(this, e);
						}
					}
					return;
				}
			}
			else
			{
				int count = list.Count;
				for (int k = 0; k < count; k++)
				{
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("MotoDeviceDetector::DeviceAttachedHandler Failed.", new object[0]);
				}
			}
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00006BC0 File Offset: 0x00004DC0
		private bool CreateDevice(out global::System.Collections.Generic.List<global::Motorola.Common.Communication.IMotoDevice> radioList, global::System.Collections.Generic.List<global::Motorola.Common.Communication.IRadioProfile> hwProfileList)
		{
			radioList = null;
			if (hwProfileList != null)
			{
				string pid = hwProfileList[0].PID;
				foreach (global::Motorola.Common.Communication.IDeviceFactory deviceFactory in this.radioFactoryList)
				{
					if (deviceFactory.IsSupport(pid) && deviceFactory.CreateRadios(out radioList, hwProfileList))
					{
						return true;
					}
				}
				return false;
			}
			return false;
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00006C3C File Offset: 0x00004E3C
		public bool AttachDevice(global::Motorola.Common.Communication.IRadioProfile radioProf)
		{
			global::Motorola.Common.Communication.DeviceDiscovery.OriginalPnPMsg originalPnPMsg = new global::Motorola.Common.Communication.DeviceDiscovery.OriginalPnPMsg();
			originalPnPMsg.m_DeviceAction = global::Motorola.Common.Communication.DeviceDiscovery.DevPnPAction.DeviceAttached;
			originalPnPMsg.sDeviceName = string.Empty;
			originalPnPMsg.radioProfile = radioProf;
			foreach (global::Motorola.Common.Communication.DeviceDiscovery.IDeviceDetector deviceDetector in this.deviceDetectorList)
			{
				if (deviceDetector.DeviceChanged(originalPnPMsg))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00006CB8 File Offset: 0x00004EB8
		public bool DetachDevice(global::Motorola.Common.Communication.IRadioProfile radioProf)
		{
			global::Motorola.Common.Communication.DeviceDiscovery.OriginalPnPMsg originalPnPMsg = new global::Motorola.Common.Communication.DeviceDiscovery.OriginalPnPMsg();
			originalPnPMsg.m_DeviceAction = global::Motorola.Common.Communication.DeviceDiscovery.DevPnPAction.DeviceAttached;
			originalPnPMsg.sDeviceName = string.Empty;
			originalPnPMsg.radioProfile = radioProf;
			foreach (global::Motorola.Common.Communication.DeviceDiscovery.IDeviceDetector deviceDetector in this.deviceDetectorList)
			{
				if (deviceDetector.DeviceChanged(originalPnPMsg))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00006D34 File Offset: 0x00004F34
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo> ScanVirtualDevices()
		{
			return global::Motorola.Common.Communication.CommonUtil.SingletonBase<global::Common.Communication.Simulator.VirtualDeviceDetector>.Instance().ScanVirtualDevices();
		}

		// Token: 0x04000042 RID: 66
		private static global::Motorola.Common.Communication.CommunicationManager.MotoDeviceDetector _self = new global::Motorola.Common.Communication.CommunicationManager.MotoDeviceDetector();

		// Token: 0x04000043 RID: 67
		private object detectorLocker = new object();

		// Token: 0x04000044 RID: 68
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.IDeviceFactory> radioFactoryList = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.IDeviceFactory>();

		// Token: 0x04000045 RID: 69
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.DeviceDiscovery.IDeviceDetector> deviceDetectorList = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.DeviceDiscovery.IDeviceDetector>();

		// Token: 0x04000048 RID: 72
		private int _deviceFamilySet;
	}
}
