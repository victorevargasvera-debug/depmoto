using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Pba;

namespace Common.Communication.Simulator
{
	// Token: 0x0200000C RID: 12
	public class VirtualDeviceManager
	{
		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600006D RID: 109 RVA: 0x00002FB4 File Offset: 0x000011B4
		public static global::Common.Communication.Simulator.VirtualDeviceManager Instance
		{
			get
			{
				lock (global::Common.Communication.Simulator.VirtualDeviceManager._criSec)
				{
					if (global::Common.Communication.Simulator.VirtualDeviceManager._instance == null)
					{
						global::Common.Communication.Simulator.VirtualDeviceManager._instance = new global::Common.Communication.Simulator.VirtualDeviceManager();
					}
				}
				return global::Common.Communication.Simulator.VirtualDeviceManager._instance;
			}
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00003004 File Offset: 0x00001204
		private static string GetFilePath()
		{
			string result = string.Empty;
			if (global::System.Reflection.Assembly.GetEntryAssembly() == null)
			{
				result = global::System.IO.Path.GetDirectoryName(global::System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\VirtualRadios\\DeviceTypeList.xml";
			}
			else
			{
				result = global::Common.Communication.Simulator.VRDefinitions.VirtualDeviceFolder + "\\DeviceTypeList.xml";
			}
			return result;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00003054 File Offset: 0x00001254
		private VirtualDeviceManager()
		{
			this._deviceListDic = new global::System.Collections.Generic.Dictionary<global::Motorola.Common.Communication.CommonUtil.ConnectionType, global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.DeviceInfo, global::Motorola.Common.Communication.Pba.PbaObject>>>
			{
				{
					global::Motorola.Common.Communication.CommonUtil.ConnectionType.LENetwork,
					new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.DeviceInfo, global::Motorola.Common.Communication.Pba.PbaObject>>()
				},
				{
					global::Motorola.Common.Communication.CommonUtil.ConnectionType.Otap,
					new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.DeviceInfo, global::Motorola.Common.Communication.Pba.PbaObject>>()
				}
			};
			this._devTypeMap = null;
			this.Init();
		}

		// Token: 0x06000070 RID: 112 RVA: 0x0000309C File Offset: 0x0000129C
		private void Init()
		{
			try
			{
				this._devTypeMap = global::Common.Communication.Simulator.DeviceTypeMap.LoadFromFile();
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Failed to load device map list, error: {0}", new object[]
				{
					ex.Message
				});
			}
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00003110 File Offset: 0x00001310
		public global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.DeviceInfo, global::Motorola.Common.Communication.Pba.PbaObject>> GetBufferedDevices(global::Motorola.Common.Communication.CommonUtil.ConnectionType connType, string serialNumber)
		{
			global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.DeviceInfo, global::Motorola.Common.Communication.Pba.PbaObject>> list = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.DeviceInfo, global::Motorola.Common.Communication.Pba.PbaObject>>();
			lock (global::Common.Communication.Simulator.VirtualDeviceManager._criSec)
			{
				if (this._deviceListDic.ContainsKey(connType))
				{
					global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.DeviceInfo, global::Motorola.Common.Communication.Pba.PbaObject>> enumerable = from device in this._deviceListDic[connType]
					where string.Equals(serialNumber, device.Key.SerialNumber, global::System.StringComparison.Ordinal)
					select device;
					foreach (global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.DeviceInfo, global::Motorola.Common.Communication.Pba.PbaObject> item in enumerable)
					{
						list.Add(item);
					}
				}
			}
			return list;
		}

		// Token: 0x06000072 RID: 114 RVA: 0x000031D8 File Offset: 0x000013D8
		public void DetachDevice(global::Motorola.Common.Communication.CommonUtil.ConnectionType connType, string serialNumber)
		{
		}

		// Token: 0x06000073 RID: 115 RVA: 0x000031DC File Offset: 0x000013DC
		public void CorrectAndBufferDevice(global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.DeviceInfo, global::Motorola.Common.Communication.Pba.PbaObject> device)
		{
			if (this._devTypeMap == null)
			{
				return;
			}
			if (this._devTypeMap.DeviceTypeList.ContainsKey(device.Key.SerialNumber))
			{
				device.Key.ConnectionInfo.ConnectionType = this._devTypeMap.DeviceTypeList[device.Key.SerialNumber].ConnType;
				device.Key.RadioID = this._devTypeMap.DeviceTypeList[device.Key.SerialNumber].RadioID.ToString();
			}
			if (this._deviceListDic.ContainsKey(device.Key.ConnectionInfo.ConnectionType))
			{
				this._deviceListDic[device.Key.ConnectionInfo.ConnectionType].Add(device);
			}
		}

		// Token: 0x04000018 RID: 24
		private static global::Common.Communication.Simulator.VirtualDeviceManager _instance = null;

		// Token: 0x04000019 RID: 25
		private static object _criSec = new object();

		// Token: 0x0400001A RID: 26
		private global::System.Collections.Generic.Dictionary<global::Motorola.Common.Communication.CommonUtil.ConnectionType, global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.DeviceInfo, global::Motorola.Common.Communication.Pba.PbaObject>>> _deviceListDic;

		// Token: 0x0400001B RID: 27
		private global::Common.Communication.Simulator.DeviceTypeMap _devTypeMap;
	}
}
