using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Motorola.Common.Communication.CommonUtil;

namespace Common.Communication.Simulator
{
	// Token: 0x0200000D RID: 13
	public class VirtualLeManager
	{
		// Token: 0x06000075 RID: 117 RVA: 0x000032C6 File Offset: 0x000014C6
		private VirtualLeManager()
		{
			this._LEDevices = global::Common.Communication.Simulator.VirtualLEDevices.LoadFromFile();
		}

		// Token: 0x06000076 RID: 118 RVA: 0x000032DC File Offset: 0x000014DC
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

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000077 RID: 119 RVA: 0x0000332C File Offset: 0x0000152C
		public static global::Common.Communication.Simulator.VirtualLeManager Instance
		{
			get
			{
				lock (global::Common.Communication.Simulator.VirtualLeManager._criSec)
				{
					if (global::Common.Communication.Simulator.VirtualLeManager._instance == null)
					{
						global::Common.Communication.Simulator.VirtualLeManager._instance = new global::Common.Communication.Simulator.VirtualLeManager();
					}
				}
				return global::Common.Communication.Simulator.VirtualLeManager._instance;
			}
		}

		// Token: 0x06000078 RID: 120 RVA: 0x0000337C File Offset: 0x0000157C
		private void OnOpenLE(global::Common.Communication.Simulator.LESystemDevicesInfo leDevsInfo)
		{
			global::System.Threading.Thread.Sleep(50);
			foreach (string serialNumber in leDevsInfo.DeviceIdList)
			{
				global::Motorola.Common.Communication.CommonUtil.SingletonBase<global::Common.Communication.Simulator.VirtualDeviceDetector>.Instance().AttachDevice(global::Motorola.Common.Communication.CommonUtil.ConnectionType.LENetwork, serialNumber);
			}
		}

		// Token: 0x06000079 RID: 121 RVA: 0x000033DC File Offset: 0x000015DC
		private void OnCloseLE(global::Common.Communication.Simulator.LESystemDevicesInfo leDevsInfo)
		{
			foreach (string serialNumber in leDevsInfo.DeviceIdList)
			{
				global::Motorola.Common.Communication.CommonUtil.SingletonBase<global::Common.Communication.Simulator.VirtualDeviceDetector>.Instance().DetachDevice(global::Motorola.Common.Communication.CommonUtil.ConnectionType.LENetwork, serialNumber);
			}
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00003450 File Offset: 0x00001650
		public bool CloseVirtualLE(global::Motorola.Common.Communication.CommonUtil.PCRIPSystemInfo leInfo)
		{
			bool result = false;
			lock (global::Common.Communication.Simulator.VirtualLeManager._criSec)
			{
				if (this._LEDevices != null)
				{
					using (global::System.Collections.Generic.List<global::Common.Communication.Simulator.LESystemDevicesInfo>.Enumerator enumerator = this._LEDevices.LESysDeviceList.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							global::Common.Communication.Simulator.LESystemDevicesInfo le = enumerator.Current;
							if (leInfo == le.LESystem)
							{
								result = true;
								global::System.Threading.Tasks.Task.Factory.StartNew(delegate()
								{
									this.OnCloseLE(le);
								});
								break;
							}
						}
					}
				}
			}
			return result;
		}

		// Token: 0x0600007B RID: 123 RVA: 0x0000351C File Offset: 0x0000171C
		private static bool LeInfoMatched(global::Motorola.Common.Communication.CommonUtil.PCRIPSystemInfo source, global::Motorola.Common.Communication.CommonUtil.PCRIPSystemInfo target)
		{
			if (source.AuthenticationKey.Length != target.AuthenticationKey.Length)
			{
				return false;
			}
			for (int i = 0; i < source.AuthenticationKey.Length; i++)
			{
				if (source.AuthenticationKey[i] != target.AuthenticationKey[i])
				{
					return false;
				}
			}
			return source.LocalType == target.LocalType && !(source.RemoteHostNameOrAddress != target.RemoteHostNameOrAddress) && source.RemotePort == target.RemotePort && !(source.SystemAlias != target.SystemAlias);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x000035CC File Offset: 0x000017CC
		public bool OpenVirtualLE(global::Motorola.Common.Communication.CommonUtil.PCRIPSystemInfo leInfo)
		{
			bool result = false;
			lock (global::Common.Communication.Simulator.VirtualLeManager._criSec)
			{
				if (this._LEDevices != null)
				{
					using (global::System.Collections.Generic.List<global::Common.Communication.Simulator.LESystemDevicesInfo>.Enumerator enumerator = this._LEDevices.LESysDeviceList.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							global::Common.Communication.Simulator.LESystemDevicesInfo le = enumerator.Current;
							if (global::Common.Communication.Simulator.VirtualLeManager.LeInfoMatched(leInfo, le.LESystem))
							{
								result = true;
								global::System.Threading.Tasks.Task.Factory.StartNew(delegate()
								{
									this.OnOpenLE(le);
								});
								break;
							}
						}
					}
				}
			}
			return result;
		}

		// Token: 0x0400001C RID: 28
		private static global::Common.Communication.Simulator.VirtualLeManager _instance = null;

		// Token: 0x0400001D RID: 29
		private static object _criSec = new object();

		// Token: 0x0400001E RID: 30
		private global::Common.Communication.Simulator.VirtualLEDevices _LEDevices;
	}
}
