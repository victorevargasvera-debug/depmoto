using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Motorola.Common.CommonLib;
using Motorola.Common.Communication;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.DeviceDiscovery;
using Motorola.Common.Communication.Pba;

namespace Common.Communication.Simulator
{
	// Token: 0x02000006 RID: 6
	public class VirtualDeviceDetector : global::Motorola.Common.Communication.CommonUtil.SingletonBase<global::Common.Communication.Simulator.VirtualDeviceDetector>, global::Motorola.Common.Communication.DeviceDiscovery.IDeviceDetector
	{
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000A RID: 10 RVA: 0x000022A6 File Offset: 0x000004A6
		public global::Motorola.Common.Communication.DeviceDiscovery.DeviceDetectorType DetectorType
		{
			get
			{
				return global::Motorola.Common.Communication.DeviceDiscovery.DeviceDetectorType.VirtualDeviceDetector;
			}
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000022B0 File Offset: 0x000004B0
		private string GetVRDirectoryPath()
		{
			string result = string.Empty;
			try
			{
				result = global::Common.Communication.Simulator.VRDefinitions.VirtualDeviceFolder;
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Get virtual folder failed, error message:", new object[]
				{
					ex
				});
				result = global::System.IO.Path.GetDirectoryName(global::System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\VirtualRadios";
			}
			return result;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x0000231C File Offset: 0x0000051C
		public bool Start()
		{
			try
			{
				this.VRPath = this.GetVRDirectoryPath();
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteInfo("Virtual radio path: {0}", new object[]
				{
					this.VRPath
				});
				if (!global::System.IO.Directory.Exists(this.VRPath))
				{
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteInfo("Not found VR path", new object[0]);
					return true;
				}
				this.InitEnv();
				global::System.Threading.Tasks.Task.Run<global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo>>(() => this.ScanVirtualDevices());
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Catch error on VR starting, message {0}", new object[]
				{
					ex
				});
			}
			return true;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000023D0 File Offset: 0x000005D0
		public void Stop()
		{
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x0600000E RID: 14 RVA: 0x000023D4 File Offset: 0x000005D4
		// (remove) Token: 0x0600000F RID: 15 RVA: 0x0000240C File Offset: 0x0000060C
		public event global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler deviceAttached;

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000010 RID: 16 RVA: 0x00002444 File Offset: 0x00000644
		// (remove) Token: 0x06000011 RID: 17 RVA: 0x0000247C File Offset: 0x0000067C
		public event global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler deviceDetached;

		// Token: 0x06000012 RID: 18 RVA: 0x000024B1 File Offset: 0x000006B1
		public bool DeviceChanged(global::Motorola.Common.Communication.DeviceDiscovery.OriginalPnPMsg pnpMsg)
		{
			return true;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000024B4 File Offset: 0x000006B4
		private void InitEnv()
		{
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000024C4 File Offset: 0x000006C4
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo> ScanVirtualDevices()
		{
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo>();
			if (!global::System.IO.Directory.Exists(this.VRPath))
			{
				return list;
			}
			foreach (string path in global::System.IO.Directory.EnumerateFiles(this.VRPath, "*.xpba"))
			{
				global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.DeviceInfo, global::Motorola.Common.Communication.Pba.PbaObject>? keyValuePair = this.ReadXpba(path);
				if (keyValuePair != null)
				{
					this.AttachDevice(keyValuePair.Value, false, false);
					list.Add(keyValuePair.Value.Key);
				}
			}
			return list;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002564 File Offset: 0x00000764
		private global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.DeviceInfo, global::Motorola.Common.Communication.Pba.PbaObject>? ReadXpba(string path)
		{
			byte[] array = global::System.IO.File.ReadAllBytes(path);
			if (array != null && array.Length > 0)
			{
				byte[] destinationArray = new byte[4];
				global::System.Array.Copy(array, destinationArray, 4);
				if (global::Motorola.Common.CommonLib.CombineTool.IsPbaPlus_enhanced(array))
				{
					global::System.Collections.Generic.List<byte[]> list = global::Motorola.Common.CommonLib.CombineTool.Decode(array);
					return new global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.DeviceInfo, global::Motorola.Common.Communication.Pba.PbaObject>?(new global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.DeviceInfo, global::Motorola.Common.Communication.Pba.PbaObject>((global::Motorola.Common.Communication.CommonUtil.DeviceInfo)global::Motorola.Common.CommonLib.CombineTool.ByteArrayToObject(list[1]), global::Motorola.Common.Communication.Pba.PbaObject.DeserializeFromBytes(list[0], false)));
				}
			}
			return null;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000025D4 File Offset: 0x000007D4
		public bool AttachDevice(global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.DeviceInfo, global::Motorola.Common.Communication.Pba.PbaObject> device, bool forceAttach, bool keepRadioID = false)
		{
			global::Motorola.Common.Communication.CommonUtil.DeviceInfo key = device.Key;
			global::Motorola.Common.Communication.Pba.PbaObject value = device.Value;
			if (key.ConnectionInfo == null)
			{
				key.ConnectionInfo = new global::Motorola.Common.Communication.CommonUtil.ConnectionInfo();
			}
			key.ConnectionInfo.ConnectionType = global::Motorola.Common.Communication.CommonUtil.ConnectionType.NetAdapter;
			if (!keepRadioID)
			{
				key.RadioID = this.VirtualRadioIDPrefix + global::System.Convert.ToString(this.VirtualRadioCounter++);
			}
			global::Common.Communication.Simulator.VirtualDeviceManager.Instance.CorrectAndBufferDevice(device);
			global::Motorola.Common.Communication.IRadioProfile radioProfile = new global::Common.Communication.Simulator.VirtualRadioProfile
			{
				Device = device,
				RadioID = key.RadioID
			};
			if (key is global::Motorola.Common.Communication.CommonUtil.PBBDeviceInfo)
			{
				radioProfile.PID = "_PBB_VirtualDevice";
				radioProfile.RadioType = global::Motorola.Common.Communication.RadioType.PBB;
			}
			else if (key is global::Motorola.Common.Communication.CommonUtil.AstroDeviceInfo)
			{
				if (key.Family == global::Motorola.Common.Communication.CommonUtil.ProductFamily.DenaliRadio)
				{
					radioProfile.PID = "_PBB_VirtualDevice";
					radioProfile.RadioType = global::Motorola.Common.Communication.RadioType.PBB;
					key.SerialNumber = global::System.Text.Encoding.ASCII.GetString(global::System.Convert.FromBase64String(key.SerialNumber));
				}
				else
				{
					radioProfile.PID = "99999";
					radioProfile.RadioType = global::Motorola.Common.Communication.RadioType.ASTRO;
				}
			}
			else
			{
				if (!(key is global::Motorola.Common.Communication.CommonUtil.PCRDeviceInfo))
				{
					throw new global::System.Exception("Unsupported device type!!");
				}
				radioProfile.PID = "99998";
				radioProfile.RadioType = global::Motorola.Common.Communication.RadioType.PCR;
				if (key.Family == global::Motorola.Common.Communication.CommonUtil.ProductFamily.MNIS)
				{
					key.RadioID = key.SerialNumber;
					(radioProfile as global::Common.Communication.Simulator.VirtualRadioProfile).RadioID = key.SerialNumber;
					key.ConnectionInfo.ConnectionType = global::Motorola.Common.Communication.CommonUtil.ConnectionType.Provisioning;
				}
				else
				{
					((global::Motorola.Common.Communication.CommonUtil.PCRDeviceInfo)key).DeviceWorkMode = global::Motorola.Common.Communication.CommonUtil.RRPWorkMode.NonDMR3;
				}
			}
			if (forceAttach || (!global::Motorola.Common.Communication.CommonUtil.BasicFunctions.IsOtapDevice(device.Key) && !global::Motorola.Common.Communication.CommonUtil.BasicFunctions.IsRRPDevice(device.Key)))
			{
				global::Motorola.Common.Communication.DeviceDiscovery.DeviceMsgEventArgs deviceMsgEventArgs = new global::Motorola.Common.Communication.DeviceDiscovery.DeviceMsgEventArgs();
				deviceMsgEventArgs.PnPAction = global::Motorola.Common.Communication.DeviceDiscovery.DevPnPAction.DeviceAttached;
				deviceMsgEventArgs.RadioInfoSet.Add(radioProfile);
				if (this.deviceAttached != null)
				{
					this.deviceAttached(this, deviceMsgEventArgs);
				}
			}
			return false;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x0000279C File Offset: 0x0000099C
		public void AttachDevice(global::Motorola.Common.Communication.CommonUtil.ConnectionType connType, string serialNumber)
		{
			global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.DeviceInfo, global::Motorola.Common.Communication.Pba.PbaObject>> bufferedDevices = global::Common.Communication.Simulator.VirtualDeviceManager.Instance.GetBufferedDevices(connType, serialNumber);
			if (bufferedDevices.Count > 0)
			{
				this.AttachDevice(bufferedDevices[0], true, false);
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000027CF File Offset: 0x000009CF
		public void DetachDevice(global::Motorola.Common.Communication.CommonUtil.ConnectionType connType, string serialNumber)
		{
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000027D4 File Offset: 0x000009D4
		public bool DetachDevice(global::Motorola.Common.Communication.IRadioProfile radioProf)
		{
			global::Motorola.Common.Communication.DeviceDiscovery.DeviceMsgEventArgs deviceMsgEventArgs = new global::Motorola.Common.Communication.DeviceDiscovery.DeviceMsgEventArgs();
			deviceMsgEventArgs.PnPAction = global::Motorola.Common.Communication.DeviceDiscovery.DevPnPAction.DeviceDetached;
			deviceMsgEventArgs.RadioInfoSet.Add(radioProf);
			if (this.deviceDetached != null)
			{
				this.deviceDetached(this, deviceMsgEventArgs);
			}
			return true;
		}

		// Token: 0x04000004 RID: 4
		private const string pbaIndicator = "PBA+";

		// Token: 0x04000005 RID: 5
		private int VirtualRadioCounter;

		// Token: 0x04000006 RID: 6
		private string VirtualRadioIDPrefix = "VR_";

		// Token: 0x04000007 RID: 7
		private string VRPath = string.Empty;
	}
}
