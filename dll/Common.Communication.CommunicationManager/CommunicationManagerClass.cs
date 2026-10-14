using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe.Fudally;
using Motorola.Common.Communication.DeviceDiscovery;
using Motorola.Common.Communication.PCRRemoteProgramming;
using Motorola.Common.Communication.TetraUtility;
using Motorola.Common.CustomException;
using SSLMangrComp;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x02000019 RID: 25
	public class CommunicationManagerClass : global::Motorola.Common.Communication.CommunicationManager.DeviceEventHandler, global::Motorola.Common.Communication.CommonUtil.IObserver, global::System.IDisposable
	{
		// Token: 0x060000A6 RID: 166 RVA: 0x00003D84 File Offset: 0x00001F84
		private CommunicationManagerClass()
		{
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x00003DE5 File Offset: 0x00001FE5
		public static global::Motorola.Common.Communication.CommunicationManager.CommunicationManagerClass Instance
		{
			get
			{
				return global::Motorola.Common.Communication.CommunicationManager.CommunicationManagerClass.CommManager;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x00003DEC File Offset: 0x00001FEC
		public global::SSLMangrComp.ConnectionManagerWatcher PNManager
		{
			get
			{
				return this._connManager;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x00003DF4 File Offset: 0x00001FF4
		internal global::Motorola.Common.Communication.CommonUtil.WorkMode DiscoveryWorkMode
		{
			get
			{
				return this._workMode;
			}
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00003DFC File Offset: 0x00001FFC
		public void Start(int deviceFamilySet, global::Motorola.Common.Communication.CommonUtil.WorkMode workMode)
		{
			if (!this.isStart)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("+++++++++++++++  CCC Service has begun  ++++++++++++++++", new object[0]);
				this._workMode = workMode;
				this._deviceFamilySet = deviceFamilySet;
				if (deviceFamilySet == 32512)
				{
					global::Motorola.Common.Communication.CommunicationManager.MotoDeviceDetector.Instance.OrginalDeviceAttached += this.TetraOrginalDevAttached;
					global::Motorola.Common.Communication.CommunicationManager.MotoDeviceDetector.Instance.DeviceChanged += this.TetraDeviceChanged;
				}
				global::Motorola.Common.Communication.CommunicationManager.MotoDeviceDetector.Instance.Start(deviceFamilySet);
				this.isStart = true;
				return;
			}
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("+++++++++++++++  Trying to start CCC multiple times  ++++++++++++++++", new object[0]);
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00003E90 File Offset: 0x00002090
		public void Stop()
		{
			if (this.isStart)
			{
				global::Motorola.Common.Communication.CommunicationManager.MotoDeviceDetector.Instance.Stop();
				this.isStart = false;
			}
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00003EAB File Offset: 0x000020AB
		private global::Motorola.Common.Communication.CommonUtil.DeviceInfo GetDeviceInfo(string deviceID)
		{
			return this.FindMotoDevice(deviceID).DeviceInfo;
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00003EB9 File Offset: 0x000020B9
		private global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo GetExtendedDeviceInfo(string deviceID)
		{
			return this.FindMotoDevice(deviceID).ReadExtendedDeviceInfo();
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000AE RID: 174 RVA: 0x00003EC8 File Offset: 0x000020C8
		internal global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo> DeviceInfoList
		{
			get
			{
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo>();
				lock (this.SyncRoot)
				{
					foreach (global::Motorola.Common.Communication.IMotoDevice motoDevice in this.MotoDeviceCacheCollection.Values)
					{
						if (motoDevice.DeviceInfo != null && (motoDevice.DeviceInfo.Family & (global::Motorola.Common.Communication.CommonUtil.ProductFamily)this._deviceFamilySet) != global::Motorola.Common.Communication.CommonUtil.ProductFamily.None)
						{
							list.Add(motoDevice.DeviceInfo);
						}
					}
				}
				return list;
			}
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00003F74 File Offset: 0x00002174
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo> GetDevicesList(int _deviceFamilySet, int _deviceConnectionType)
		{
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo>();
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.IMotoDevice> list2 = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.IMotoDevice>();
			lock (this.SyncRoot)
			{
				foreach (global::Motorola.Common.Communication.IMotoDevice motoDevice in this.MotoDeviceCacheCollection.Values)
				{
					if (motoDevice.DeviceInfo != null && (motoDevice.DeviceInfo.Family & (global::Motorola.Common.Communication.CommonUtil.ProductFamily)_deviceFamilySet) != global::Motorola.Common.Communication.CommonUtil.ProductFamily.None && (motoDevice.DeviceInfo.ConnectionInfo.ConnectionType & (global::Motorola.Common.Communication.CommonUtil.ConnectionType)_deviceConnectionType) != global::Motorola.Common.Communication.CommonUtil.ConnectionType.None)
					{
						list2.Add(motoDevice);
					}
				}
			}
			if (this.DiscoveryWorkMode == global::Motorola.Common.Communication.CommonUtil.WorkMode.Lazy)
			{
				foreach (global::Motorola.Common.Communication.IMotoDevice motoDevice2 in list2)
				{
					motoDevice2.Prefetch();
				}
			}
			long ticks = global::System.DateTime.Now.Ticks;
			int num = global::Motorola.Common.Communication.CommunicationManager.CommunicationManagerClass.WAIT_FOR_RADIO_READY_BASE_TIMEOUT + list2.Count * 2000;
			int num2 = num;
			foreach (global::Motorola.Common.Communication.IMotoDevice motoDevice3 in list2)
			{
				if (motoDevice3.WaitForReady(num2))
				{
					list.Add(motoDevice3.DeviceInfo);
				}
				int num3 = (int)((global::System.DateTime.Now.Ticks - ticks) / 10000L);
				num2 = num - num3;
				if (num2 < 0)
				{
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("ListConnectedDevices timeouted", new object[0]);
					num2 = 0;
				}
				int wait_FOR_RADIO_READY_BASE_TIMEOUT = global::Motorola.Common.Communication.CommunicationManager.CommunicationManagerClass.WAIT_FOR_RADIO_READY_BASE_TIMEOUT;
			}
			return list;
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00004138 File Offset: 0x00002338
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo> GetDevicesList(int _deviceFamilySet, int _deviceConnectionType, string serialNumber)
		{
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo>();
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.IMotoDevice> list2 = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.IMotoDevice>();
			lock (this.SyncRoot)
			{
				foreach (global::Motorola.Common.Communication.IMotoDevice motoDevice in this.MotoDeviceCacheCollection.Values)
				{
					if (motoDevice.DeviceInfo != null && (motoDevice.DeviceInfo.Family & (global::Motorola.Common.Communication.CommonUtil.ProductFamily)_deviceFamilySet) != global::Motorola.Common.Communication.CommonUtil.ProductFamily.None && (motoDevice.DeviceInfo.ConnectionInfo.ConnectionType & (global::Motorola.Common.Communication.CommonUtil.ConnectionType)_deviceConnectionType) != global::Motorola.Common.Communication.CommonUtil.ConnectionType.None)
					{
						list2.Add(motoDevice);
					}
				}
			}
			if (this.DiscoveryWorkMode == global::Motorola.Common.Communication.CommonUtil.WorkMode.Lazy)
			{
				foreach (global::Motorola.Common.Communication.IMotoDevice motoDevice2 in list2)
				{
					motoDevice2.Prefetch();
				}
			}
			foreach (global::Motorola.Common.Communication.IMotoDevice motoDevice3 in list2)
			{
				if (motoDevice3.WaitForReady(0) && motoDevice3.DeviceInfo != null && (motoDevice3.DeviceInfo.SerialNumber == serialNumber || motoDevice3.DeviceInfo.SerialNumber == global::System.Convert.ToBase64String(global::System.Text.Encoding.ASCII.GetBytes(serialNumber))))
				{
					list.Add(motoDevice3.DeviceInfo);
				}
			}
			return list;
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x000042CC File Offset: 0x000024CC
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo> RefreshDeviceInfoList(global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo> deviceInfoList)
		{
			foreach (global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo in deviceInfoList)
			{
			}
			return deviceInfoList;
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00004314 File Offset: 0x00002514
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo> CheckForDevice(int _deviceFamilySet, int _deviceConnectionType, string serialNumber)
		{
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo> result = null;
			try
			{
				if (_deviceConnectionType == 128)
				{
					return null;
				}
				if (_deviceConnectionType == 8 || _deviceConnectionType == 512)
				{
					return this.ListConnectedDevices(_deviceFamilySet, _deviceConnectionType);
				}
				result = global::Motorola.Common.Communication.CommunicationManager.CommunicationManagerClass.Instance.GetDevicesList(_deviceFamilySet, _deviceConnectionType, serialNumber);
			}
			catch (global::Motorola.Common.CustomException.CommonException)
			{
				throw;
			}
			catch (global::System.Exception systemException)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.GenericError, systemException);
			}
			return result;
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00004384 File Offset: 0x00002584
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo> ListConnectedDevices(int _deviceFamilySet, int _deviceConnectionType)
		{
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo>();
			try
			{
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo> list2;
				if (_deviceConnectionType == 128)
				{
					list2 = global::Motorola.Common.Communication.CommunicationManager.CommunicationManagerClass.Instance.GetBootDevicesList();
				}
				else if (_deviceConnectionType == 1024)
				{
					list2 = global::Motorola.Common.Communication.CommunicationManager.CommunicationManagerClass.Instance.ScanVirtualDevices();
				}
				else if (_deviceConnectionType == 8 || _deviceConnectionType == 512)
				{
					list2 = global::Motorola.Common.Communication.PCRRemoteProgramming.LEDeviceManager.Instance.GetRemoteDevicesList();
					if (list2.Count == 0)
					{
						list2 = global::Motorola.Common.Communication.CommunicationManager.CommunicationManagerClass.Instance.GetDevicesList(_deviceFamilySet, _deviceConnectionType);
					}
				}
				else
				{
					list2 = global::Motorola.Common.Communication.CommunicationManager.CommunicationManagerClass.Instance.GetDevicesList(_deviceFamilySet, _deviceConnectionType);
				}
				if (list2 != null)
				{
					foreach (global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo in list2)
					{
						if ((deviceInfo.Family & (global::Motorola.Common.Communication.CommonUtil.ProductFamily)_deviceFamilySet) != global::Motorola.Common.Communication.CommonUtil.ProductFamily.None && (deviceInfo.ConnectionInfo.ConnectionType & (global::Motorola.Common.Communication.CommonUtil.ConnectionType)_deviceConnectionType) != global::Motorola.Common.Communication.CommonUtil.ConnectionType.None)
						{
							list.Add(deviceInfo);
						}
					}
				}
			}
			catch (global::Motorola.Common.CustomException.CommonException)
			{
				throw;
			}
			catch (global::System.Exception systemException)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.GenericError, systemException);
			}
			return list;
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00004484 File Offset: 0x00002684
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo> ScanVirtualDevices()
		{
			return global::Motorola.Common.Communication.CommunicationManager.MotoDeviceDetector.Instance.ScanVirtualDevices();
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00004490 File Offset: 0x00002690
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo> GetBootDevicesList()
		{
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo>();
			global::System.Collections.Generic.List<string> list2 = global::Motorola.Common.Communication.CommunicationPipe.Fudally.FudallyUSBPort.ListConnectedDevices();
			this.MotoBootModeDeviceCacheCollection.Clear();
			foreach (string deviceInstance in list2)
			{
				global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo = new global::Motorola.Common.Communication.CommonUtil.DeviceInfo();
				deviceInfo.ConnectionInfo = new global::Motorola.Common.Communication.CommonUtil.ConnectionInfo
				{
					ConnectionType = global::Motorola.Common.Communication.CommonUtil.ConnectionType.Fudally,
					DeviceInstance = deviceInstance
				};
				deviceInfo.RadioState = global::Motorola.Common.Communication.CommonUtil.RadioState.Ready;
				deviceInfo.Family = global::Motorola.Common.Communication.CommonUtil.ProductFamily.PCRRadio;
				deviceInfo.RadioID = global::Motorola.Common.Communication.CommonUtil.ProductFamily.PCRRadio + "_" + deviceInfo.ConnectionInfo.DeviceInstance;
				if (!this.MotoBootModeDeviceCacheCollection.ContainsKey(deviceInfo.RadioID))
				{
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Boot mode Device " + deviceInfo.RadioID + " added!", new object[0]);
					global::Motorola.Common.Communication.CommunicationManager.MotoDevice motoDevice = global::Motorola.Common.Communication.CommunicationManager.CommunicationManagerClass.newMotoDevice(deviceInfo, null);
					motoDevice.radioState = global::Motorola.Common.Communication.CommonUtil.RadioState.Ready;
					this.MotoBootModeDeviceCacheCollection[deviceInfo.RadioID] = motoDevice;
					list.Add(deviceInfo);
				}
			}
			return list;
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x000045BC File Offset: 0x000027BC
		internal void AddBlindPushDevice(global::Motorola.Common.Communication.IMotoDevice device)
		{
			if (device != null && device.DeviceInfo != null)
			{
				lock (this.SyncRoot)
				{
					if (!this.MotoDeviceBlindPushCollection.ContainsKey(device.DeviceInfo.RadioID))
					{
						global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Blind push Device " + device.DeviceInfo.RadioID + " added!", new object[0]);
						this.MotoDeviceBlindPushCollection[device.DeviceInfo.RadioID] = device;
					}
				}
			}
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00004744 File Offset: 0x00002944
		public void AddDevice(global::Motorola.Common.Communication.IMotoDevice device)
		{
			if (device != null && device.DeviceInfo != null && !string.IsNullOrEmpty(device.DeviceInfo.RadioID))
			{
				lock (this.SyncRoot)
				{
					if (device is global::Motorola.Common.Communication.CommunicationManager.PBBDevice)
					{
						if (this.MotoDeviceCacheCollection.ContainsKey(device.DeviceInfo.RadioID) && this.MotoDeviceCacheCollection[device.DeviceInfo.RadioID] is global::Motorola.Common.Communication.CommunicationManager.PBBDevice)
						{
							global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile udpradioProfile = (this.MotoDeviceCacheCollection[device.DeviceInfo.RadioID] as global::Motorola.Common.Communication.CommunicationManager.PBBDevice).RadioProfile as global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile;
							global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile udpradioProfile2 = (device as global::Motorola.Common.Communication.CommunicationManager.PBBDevice).RadioProfile as global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile;
							if (udpradioProfile.DeviceConnectionMode == udpradioProfile2.DeviceConnectionMode)
							{
								if (udpradioProfile.IPAddress != udpradioProfile2.IPAddress)
								{
									(this.MotoDeviceCacheCollection[device.DeviceInfo.RadioID] as global::Motorola.Common.Communication.CommunicationManager.PBBDevice).RemoveFromCacheCollection();
									this.MotoDeviceCacheCollection[device.DeviceInfo.RadioID] = device;
								}
								else
								{
									(device as global::Motorola.Common.Communication.CommunicationManager.PBBDevice).RemoveFromCacheCollection();
								}
							}
							else if (udpradioProfile.DeviceConnectionMode == global::Motorola.Common.Communication.DeviceDiscovery.UDPDeviceConnectionMode.Wireless && udpradioProfile2.DeviceConnectionMode == global::Motorola.Common.Communication.DeviceDiscovery.UDPDeviceConnectionMode.Wired)
							{
								this.MotoDeviceCacheCollection[device.DeviceInfo.RadioID] = device;
							}
						}
						if (this.MotoDeviceCacheCollection.Count((global::System.Collections.Generic.KeyValuePair<string, global::Motorola.Common.Communication.IMotoDevice> x) => x.Value is global::Motorola.Common.Communication.CommunicationManager.PBBDevice && (x.Value as global::Motorola.Common.Communication.CommunicationManager.PBBDevice).RadioProfile.IPAddress == (device as global::Motorola.Common.Communication.CommunicationManager.PBBDevice).RadioProfile.IPAddress && x.Key != (device as global::Motorola.Common.Communication.CommunicationManager.PBBDevice).DeviceInfo.RadioID) > 0)
						{
							(this.MotoDeviceCacheCollection.First((global::System.Collections.Generic.KeyValuePair<string, global::Motorola.Common.Communication.IMotoDevice> x) => x.Value is global::Motorola.Common.Communication.CommunicationManager.PBBDevice && (x.Value as global::Motorola.Common.Communication.CommunicationManager.PBBDevice).RadioProfile.IPAddress == (device as global::Motorola.Common.Communication.CommunicationManager.PBBDevice).RadioProfile.IPAddress && x.Key != (device as global::Motorola.Common.Communication.CommunicationManager.PBBDevice).DeviceInfo.RadioID).Value as global::Motorola.Common.Communication.CommunicationManager.PBBDevice).Detach();
						}
					}
					else if (device is global::Motorola.Common.Communication.CommunicationManager.PBBWiFiDevice && this.MotoDeviceCacheCollection.ContainsKey(device.DeviceInfo.RadioID))
					{
						(device as global::Motorola.Common.Communication.CommunicationManager.PBBWiFiDevice).StopTimer();
					}
					if (!this.MotoDeviceCacheCollection.ContainsKey(device.DeviceInfo.RadioID))
					{
						global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Device " + device.DeviceInfo.RadioID + " added!", new object[0]);
						this.MotoDeviceCacheCollection[device.DeviceInfo.RadioID] = device;
						if (device.DeviceInfo.RadioState == global::Motorola.Common.Communication.CommonUtil.RadioState.Ready)
						{
							this.NotifyDeviceConnected(device.DeviceInfo);
						}
					}
				}
			}
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00004A54 File Offset: 0x00002C54
		internal void RemoveDevice(string deviceID)
		{
			if (!string.IsNullOrEmpty(deviceID))
			{
				lock (this.SyncRoot)
				{
					if (this.MotoDeviceCacheCollection.ContainsKey(deviceID))
					{
						global::Motorola.Common.Communication.IMotoDevice motoDevice = this.MotoDeviceCacheCollection[deviceID];
						global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Device " + deviceID + " removed!", new object[0]);
						this.MotoDeviceCacheCollection.Remove(deviceID);
						if ((motoDevice.radioState == global::Motorola.Common.Communication.CommonUtil.RadioState.Ready || motoDevice.radioState == global::Motorola.Common.Communication.CommonUtil.RadioState.Busy || motoDevice.radioState == global::Motorola.Common.Communication.CommonUtil.RadioState.Removing) && motoDevice.DeviceInfo != null)
						{
							this.NotifyDeviceLost(motoDevice.DeviceInfo);
						}
						motoDevice.radioState = global::Motorola.Common.Communication.CommonUtil.RadioState.Detached;
					}
				}
			}
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00004B18 File Offset: 0x00002D18
		public void ReDetectDevice(string deviceID)
		{
			global::Motorola.Common.Communication.IMotoDevice motoDevice = null;
			if (!string.IsNullOrEmpty(deviceID))
			{
				lock (this.SyncRoot)
				{
					if (this.MotoDeviceCacheCollection.ContainsKey(deviceID))
					{
						motoDevice = this.MotoDeviceCacheCollection[deviceID];
						global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Device " + deviceID + " reDetected!", new object[0]);
						if ((motoDevice.radioState == global::Motorola.Common.Communication.CommonUtil.RadioState.Ready || motoDevice.radioState == global::Motorola.Common.Communication.CommonUtil.RadioState.Busy) && motoDevice.DeviceInfo != null)
						{
							this.NotifyDeviceLost(motoDevice.DeviceInfo);
						}
						motoDevice.radioState = global::Motorola.Common.Communication.CommonUtil.RadioState.Attached;
					}
				}
				if (global::Motorola.Common.Communication.CommunicationManager.CommunicationManagerClass.Instance.DiscoveryWorkMode == global::Motorola.Common.Communication.CommonUtil.WorkMode.Active && motoDevice != null)
				{
					motoDevice.Prefetch();
				}
			}
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00004BDC File Offset: 0x00002DDC
		public void RemoveNonPlugPlayDevice(string deviceID)
		{
			if (!string.IsNullOrEmpty(deviceID))
			{
				lock (this.SyncRoot)
				{
					if (this.MotoDeviceBlindPushCollection.ContainsKey(deviceID))
					{
						global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Blind push Device " + deviceID + " removed!", new object[0]);
						this.MotoDeviceBlindPushCollection.Remove(deviceID);
					}
					else if (this.MotoBootModeDeviceCacheCollection.ContainsKey(deviceID))
					{
						global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Boot mode Device " + deviceID + " removed!", new object[0]);
						this.MotoBootModeDeviceCacheCollection.Remove(deviceID);
					}
				}
			}
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00004C9C File Offset: 0x00002E9C
		public global::Motorola.Common.Communication.IMotoDevice GetDevice(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			string managedRadioId = this.GetManagedRadioId(deviceInfo);
			global::Motorola.Common.Communication.IMotoDevice motoDevice = global::Motorola.Common.Communication.CommunicationManager.CommunicationManagerClass.Instance.GetDevice(managedRadioId);
			if (deviceInfo != null && deviceInfo.ConnectionInfo != null && deviceInfo.ConnectionInfo.ConnectionType == global::Motorola.Common.Communication.CommonUtil.ConnectionType.Fudally && motoDevice != null && motoDevice.DeviceInfo != null && motoDevice.DeviceInfo.Family == global::Motorola.Common.Communication.CommonUtil.ProductFamily.PCRRadio && deviceInfo.Family != global::Motorola.Common.Communication.CommonUtil.ProductFamily.None && (global::Motorola.Common.Communication.CommonUtil.ProductFamily.PCRRadio & deviceInfo.Family) == deviceInfo.Family)
			{
				motoDevice.DeviceInfo.Family = deviceInfo.Family;
			}
			try
			{
				if (motoDevice == null)
				{
					if (deviceInfo.ConnectionInfo.ConnectionType == global::Motorola.Common.Communication.CommonUtil.ConnectionType.Otap || deviceInfo.ConnectionInfo.ConnectionType == global::Motorola.Common.Communication.CommonUtil.ConnectionType.Bluetooth || deviceInfo.ConnectionInfo.ConnectionType == global::Motorola.Common.Communication.CommonUtil.ConnectionType.LENetwork || deviceInfo.ConnectionInfo.ConnectionType == global::Motorola.Common.Communication.CommonUtil.ConnectionType.Provisioning || deviceInfo.ConnectionInfo.ConnectionType == global::Motorola.Common.Communication.CommonUtil.ConnectionType.DMR3Network || deviceInfo.ConnectionInfo.ConnectionType == global::Motorola.Common.Communication.CommonUtil.ConnectionType.WIFI)
					{
						deviceInfo.RadioID = managedRadioId;
						motoDevice = global::Motorola.Common.Communication.CommunicationManager.BlindPushDeviceFactory.CreateRadio(deviceInfo);
					}
					else
					{
						if (deviceInfo.ConnectionInfo.ConnectionType != global::Motorola.Common.Communication.CommonUtil.ConnectionType.RS232)
						{
							throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerDeviceNotFound);
						}
						deviceInfo.RadioID = managedRadioId;
						motoDevice = global::Motorola.Common.Communication.CommunicationManager.RS232ConnectionDeviceFactory.CreateRadio(deviceInfo);
					}
				}
				else if (deviceInfo.ConnectionInfo != null && (deviceInfo.ConnectionInfo.ConnectionType == global::Motorola.Common.Communication.CommonUtil.ConnectionType.LENetwork || deviceInfo.ConnectionInfo.ConnectionType == global::Motorola.Common.Communication.CommonUtil.ConnectionType.DMR3Network) && deviceInfo.ConnectionInfo.AuthInfo != null)
				{
					motoDevice.DeviceInfo.ConnectionInfo.AuthInfo.PreSharedKey_ID = deviceInfo.ConnectionInfo.AuthInfo.PreSharedKey_ID;
					motoDevice.DeviceInfo.ConnectionInfo.AuthInfo.PreSharedKey_Material = deviceInfo.ConnectionInfo.AuthInfo.PreSharedKey_Material;
				}
			}
			catch (global::Motorola.Common.CustomException.CommonException ex)
			{
				if (ex.ErrorCode != global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_RadioIsBusy && motoDevice != null)
				{
					motoDevice.FreeDeviceStatuse(false);
					global::Motorola.Common.Communication.CommunicationManager.CommunicationManagerClass.Instance.RemoveNonPlugPlayDevice(managedRadioId);
				}
				throw;
			}
			return motoDevice;
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00004E8C File Offset: 0x0000308C
		public global::Motorola.Common.Communication.IMotoDevice GetDevice(string deviceID)
		{
			if (!string.IsNullOrEmpty(deviceID))
			{
				lock (this.SyncRoot)
				{
					if (this.MotoDeviceCacheCollection.ContainsKey(deviceID))
					{
						return this.MotoDeviceCacheCollection[deviceID];
					}
					if (this.MotoDeviceBlindPushCollection.ContainsKey(deviceID))
					{
						return this.MotoDeviceBlindPushCollection[deviceID];
					}
					if (this.MotoBootModeDeviceCacheCollection.ContainsKey(deviceID))
					{
						return this.MotoBootModeDeviceCacheCollection[deviceID];
					}
				}
			}
			return null;
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00004F28 File Offset: 0x00003128
		private global::Motorola.Common.Communication.IMotoDevice FindMotoDevice(string deviceID)
		{
			global::Motorola.Common.Communication.IMotoDevice device = this.GetDevice(deviceID);
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(device, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerDeviceNotFound);
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(device.DeviceInfo, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerNullDeviceInfo);
			return device;
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00004F5C File Offset: 0x0000315C
		public void Notify(object anObject)
		{
			global::Motorola.Common.Communication.IMotoDevice motoDevice = anObject as global::Motorola.Common.Communication.IMotoDevice;
			if (motoDevice.DeviceInfo.RadioState == global::Motorola.Common.Communication.CommonUtil.RadioState.Ready)
			{
				this.pendingForListConnectedDevices.Set();
				if (motoDevice is global::Motorola.Common.Communication.CommunicationManager.PBBDevice)
				{
					this.AddDevice(motoDevice);
				}
				else
				{
					this.NotifyDeviceConnected(motoDevice.DeviceInfo);
				}
			}
			motoDevice.UnRegister(this);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00004FAE File Offset: 0x000031AE
		private void NotifyDeviceConnected(global::Motorola.Common.Communication.CommonUtil.DeviceInfo devInfo)
		{
			if ((this._deviceFamilySet & (int)devInfo.Family) != 0)
			{
				this.OnDeviceConnected(devInfo.Copy());
			}
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00004FCB File Offset: 0x000031CB
		private void NotifyDeviceLost(global::Motorola.Common.Communication.CommonUtil.DeviceInfo devInfo)
		{
			if ((this._deviceFamilySet & (int)devInfo.Family) != 0)
			{
				this.OnDeviceLost(devInfo.Copy());
			}
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00004FE8 File Offset: 0x000031E8
		public string GetManagedRadioId(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			if (!string.IsNullOrEmpty(deviceInfo.RadioID))
			{
				return deviceInfo.RadioID;
			}
			global::Motorola.Common.Communication.CommunicationManager.CommunicationManagerClass.ValidateDeviceInfo(deviceInfo);
			if (deviceInfo.ConnectionInfo.ConnectionType == global::Motorola.Common.Communication.CommonUtil.ConnectionType.Otap || deviceInfo.ConnectionInfo.ConnectionType == global::Motorola.Common.Communication.CommonUtil.ConnectionType.Bluetooth || deviceInfo.ConnectionInfo.ConnectionType == global::Motorola.Common.Communication.CommonUtil.ConnectionType.Provisioning || deviceInfo.ConnectionInfo.ConnectionType == global::Motorola.Common.Communication.CommonUtil.ConnectionType.WIFI)
			{
				return deviceInfo.Family.ToString() + "_" + deviceInfo.ConnectionInfo.UniqueAddress;
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerUnsupportConnectionInfo);
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00005080 File Offset: 0x00003280
		private static void ValidateDeviceInfo(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			if (deviceInfo == null)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerNullDeviceInfo);
			}
			if (deviceInfo.Family == global::Motorola.Common.Communication.CommonUtil.ProductFamily.None || deviceInfo.Family == global::Motorola.Common.Communication.CommonUtil.ProductFamily.Any)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerUnknownDeviceFamily);
			}
			if (deviceInfo.ConnectionInfo == null)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerNullConnectionInfo);
			}
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x000050CE File Offset: 0x000032CE
		public void UpdatePasswords(global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.AuthenticationInfo> passwords)
		{
			global::Motorola.Common.Communication.DeviceDiscovery.UDPDeviceManager.Instance.UpdatePasswords(passwords);
			global::Motorola.Common.Communication.CommonUtil.SingletonBase<global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector>.Instance().UpdatePasswords(passwords);
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00005118 File Offset: 0x00003318
		public void DetachDevice(string serialnumber)
		{
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.IMotoDevice> list = (from m in this.MotoDeviceCacheCollection
			where m.Value.DeviceInfo.SerialNumber == serialnumber
			select m.Value).ToList<global::Motorola.Common.Communication.IMotoDevice>();
			foreach (global::Motorola.Common.Communication.IMotoDevice motoDevice in list)
			{
				if (motoDevice is global::Motorola.Common.Communication.CommunicationManager.PBBDevice)
				{
					global::Motorola.Common.Communication.DeviceDiscovery.UDPDeviceManager.Instance.DetachDevice(serialnumber);
				}
				else if (motoDevice is global::Motorola.Common.Communication.CommunicationManager.PBBWiFiDevice)
				{
					global::Motorola.Common.Communication.CommonUtil.SingletonBase<global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector>.Instance().DetachDevice((motoDevice as global::Motorola.Common.Communication.CommunicationManager.PBBWiFiDevice).RadioProfile.RadioIdString);
				}
			}
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x000051E8 File Offset: 0x000033E8
		private void TetraDeviceChanged(object sender, global::Motorola.Common.Communication.DeviceDiscovery.DeviceMsgEventArgs args)
		{
			this.RespondDeviceChanged(sender, args, false);
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x000051F3 File Offset: 0x000033F3
		private void TetraOrginalDevAttached(object sender, global::Motorola.Common.Communication.DeviceDiscovery.DeviceMsgEventArgs args)
		{
			this.RespondDeviceChanged(sender, args, true);
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00005200 File Offset: 0x00003400
		private void RespondDeviceChanged(object sender, global::Motorola.Common.Communication.DeviceDiscovery.DeviceMsgEventArgs args, bool originalDevAttached)
		{
			if (args.RadioInfoSet.Count != 0)
			{
				global::Motorola.Common.Communication.IRadioProfile radioProfile = args.RadioInfoSet[0] as global::Motorola.Common.Communication.IRadioProfile;
				if (radioProfile != null && radioProfile.RadioType == global::Motorola.Common.Communication.RadioType.TETRA)
				{
					global::System.Collections.Generic.List<global::Motorola.Common.Communication.TetraUtility.TetraPnPMsg> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.TetraUtility.TetraPnPMsg>();
					for (int i = 0; i < args.RadioInfoSet.Count; i++)
					{
						global::Motorola.Common.Communication.TetraUtility.TetraPnPMsg tetraPnPMsg = new global::Motorola.Common.Communication.TetraUtility.TetraPnPMsg();
						if (args.PnPAction == global::Motorola.Common.Communication.DeviceDiscovery.DevPnPAction.DeviceAttached)
						{
							tetraPnPMsg.PnPType = global::Motorola.Common.Communication.TetraUtility.TetraPnPMsg.DevPnPAction.DeviceAttached;
						}
						else
						{
							tetraPnPMsg.PnPType = global::Motorola.Common.Communication.TetraUtility.TetraPnPMsg.DevPnPAction.DeviceDetached;
						}
						tetraPnPMsg.PhysicalLocation = (args.RadioInfoSet[i] as global::Motorola.Common.Communication.IRadioProfile).PhysicalLocation;
						tetraPnPMsg.PortNumber = (args.RadioInfoSet[i] as global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile).Path;
						tetraPnPMsg.DevMode = (args.RadioInfoSet[i] as global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile).DeviceMode;
						tetraPnPMsg.RadioId = (args.RadioInfoSet[i] as global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile).RadioIdString;
						tetraPnPMsg.RadioType = (args.RadioInfoSet[i] as global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile).TetraRadioType;
						tetraPnPMsg.IsOriginalPnP = originalDevAttached;
						tetraPnPMsg.PID = (args.RadioInfoSet[i] as global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile).PID;
						tetraPnPMsg.UniqueLocation = (args.RadioInfoSet[i] as global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile).UniqueLocation;
						list.Add(tetraPnPMsg);
					}
					global::Motorola.Common.Communication.TetraUtility.TetraPnPMonitor.Instance.ReceivePnPMsg(list);
				}
			}
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x0000535F File Offset: 0x0000355F
		public bool ContainWiFiDevice(string radioID)
		{
			return this.MotoDeviceCacheCollection.ContainsKey(radioID);
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x0000536D File Offset: 0x0000356D
		public bool AttachDevice(global::Motorola.Common.Communication.IRadioProfile radioProf)
		{
			return global::Motorola.Common.Communication.CommunicationManager.MotoDeviceDetector.Instance.AttachDevice(radioProf);
		}

		// Token: 0x060000CA RID: 202 RVA: 0x0000537A File Offset: 0x0000357A
		public bool DetachDevice(global::Motorola.Common.Communication.IRadioProfile radioProf)
		{
			return global::Motorola.Common.Communication.CommunicationManager.MotoDeviceDetector.Instance.DetachDevice(radioProf);
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00005387 File Offset: 0x00003587
		protected virtual void Dispose(bool disposing)
		{
			if (disposing && this.pendingForListConnectedDevices != null)
			{
				this.pendingForListConnectedDevices.Dispose();
			}
		}

		// Token: 0x060000CC RID: 204 RVA: 0x0000539F File Offset: 0x0000359F
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x060000CD RID: 205 RVA: 0x000053AE File Offset: 0x000035AE
		private static global::Motorola.Common.Communication.CommunicationManager.MotoDevice newMotoDevice(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.DeviceDiscovery.RNDISRadioProfile radioProfile)
		{
			return new global::Motorola.Common.Communication.CommunicationManager.MotoDevice(deviceInfo, radioProfile);
		}

		// Token: 0x04000014 RID: 20
		private object SyncRoot = new object();

		// Token: 0x04000015 RID: 21
		private global::System.Collections.Generic.Dictionary<string, global::Motorola.Common.Communication.IMotoDevice> MotoDeviceCacheCollection = new global::System.Collections.Generic.Dictionary<string, global::Motorola.Common.Communication.IMotoDevice>();

		// Token: 0x04000016 RID: 22
		private global::System.Collections.Generic.Dictionary<string, global::Motorola.Common.Communication.IMotoDevice> MotoDeviceBlindPushCollection = new global::System.Collections.Generic.Dictionary<string, global::Motorola.Common.Communication.IMotoDevice>();

		// Token: 0x04000017 RID: 23
		private global::System.Collections.Generic.Dictionary<string, global::Motorola.Common.Communication.IMotoDevice> MotoBootModeDeviceCacheCollection = new global::System.Collections.Generic.Dictionary<string, global::Motorola.Common.Communication.IMotoDevice>();

		// Token: 0x04000018 RID: 24
		private global::SSLMangrComp.ConnectionManagerWatcher _connManager = new global::SSLMangrComp.ConnectionManagerWatcher();

		// Token: 0x04000019 RID: 25
		private static global::Motorola.Common.Communication.CommunicationManager.CommunicationManagerClass CommManager = new global::Motorola.Common.Communication.CommunicationManager.CommunicationManagerClass();

		// Token: 0x0400001A RID: 26
		private global::System.Threading.AutoResetEvent pendingForListConnectedDevices = new global::System.Threading.AutoResetEvent(false);

		// Token: 0x0400001B RID: 27
		private static int WAIT_FOR_RADIO_READY_BASE_TIMEOUT = 30000;

		// Token: 0x0400001C RID: 28
		private global::Motorola.Common.Communication.CommonUtil.WorkMode _workMode;

		// Token: 0x0400001D RID: 29
		private int _deviceFamilySet = 65535;

		// Token: 0x0400001E RID: 30
		private bool isStart;
	}
}
