using System;
using System.Collections.Generic;
using System.Linq;
using Motorola.Common.Communication.CommonUtil;

namespace Motorola.Common.Communication.DeviceDiscovery
{
	// Token: 0x02000024 RID: 36
	public class UDPDeviceManager
	{
		// Token: 0x06000161 RID: 353 RVA: 0x000070F2 File Offset: 0x000052F2
		private UDPDeviceManager()
		{
			this._profileCacheCollection = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile>();
			this._passwords = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.AuthenticationInfo>();
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000162 RID: 354 RVA: 0x00007110 File Offset: 0x00005310
		public static global::Motorola.Common.Communication.DeviceDiscovery.UDPDeviceManager Instance
		{
			get
			{
				if (global::Motorola.Common.Communication.DeviceDiscovery.UDPDeviceManager._instance == null)
				{
					global::Motorola.Common.Communication.DeviceDiscovery.UDPDeviceManager._instance = new global::Motorola.Common.Communication.DeviceDiscovery.UDPDeviceManager();
				}
				return global::Motorola.Common.Communication.DeviceDiscovery.UDPDeviceManager._instance;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000163 RID: 355 RVA: 0x00007128 File Offset: 0x00005328
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.AuthenticationInfo> Passwords
		{
			get
			{
				return this._passwords;
			}
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00007130 File Offset: 0x00005330
		public void UpdatePasswords(global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.AuthenticationInfo> psws)
		{
			this._passwords.Clear();
			this._passwords.AddRange(psws);
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00007178 File Offset: 0x00005378
		public bool AddProfile(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile profile)
		{
			if (this._profileCacheCollection.Count((global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile m) => m.IPAddress == profile.IPAddress && string.IsNullOrEmpty(m.UniqueIndendifier)) == 0)
			{
				this._profileCacheCollection.Add(profile);
				return true;
			}
			return false;
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00007208 File Offset: 0x00005408
		public global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile GetByDomainName(string domain)
		{
			if (this._profileCacheCollection.Count((global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile m) => m.DomainName == domain && m.DeviceConnectionMode == global::Motorola.Common.Communication.DeviceDiscovery.UDPDeviceConnectionMode.Wireless) > 0)
			{
				return this._profileCacheCollection.First((global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile m) => m.DomainName == domain && m.DeviceConnectionMode == global::Motorola.Common.Communication.DeviceDiscovery.UDPDeviceConnectionMode.Wireless);
			}
			return null;
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00007270 File Offset: 0x00005470
		public bool ContainsProfile(string id)
		{
			return this._profileCacheCollection.Count((global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile m) => m.UniqueIndendifier == id) > 0;
		}

		// Token: 0x06000168 RID: 360 RVA: 0x000072F4 File Offset: 0x000054F4
		public void Remove(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile profile)
		{
			this._profileCacheCollection.Remove(profile);
			if (profile.DeviceConnectionMode == global::Motorola.Common.Communication.DeviceDiscovery.UDPDeviceConnectionMode.Wired)
			{
				if (this._profileCacheCollection.Count((global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile m) => m.DeviceConnectionMode == global::Motorola.Common.Communication.DeviceDiscovery.UDPDeviceConnectionMode.Wireless && m.UniqueIndendifier == profile.UniqueIndendifier) > 0)
				{
					global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile udpradioProfile = this._profileCacheCollection.First((global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile m) => m.DeviceConnectionMode == global::Motorola.Common.Communication.DeviceDiscovery.UDPDeviceConnectionMode.Wireless && m.UniqueIndendifier == profile.UniqueIndendifier);
					udpradioProfile.UniqueIndendifier = null;
					udpradioProfile.HostDetector.OnDeviceAdd(udpradioProfile);
				}
			}
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00007381 File Offset: 0x00005581
		public void DetachDevice(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile profile)
		{
			profile.HostDetector.OnDeviceRemove(profile);
			this.Remove(profile);
		}

		// Token: 0x0600016A RID: 362 RVA: 0x000073D8 File Offset: 0x000055D8
		public void DetachDevice(string identifier)
		{
			if (this._profileCacheCollection.Count((global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile m) => m.UniqueIndendifier == identifier) > 0)
			{
				global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile udpradioProfile = this._profileCacheCollection.First((global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile m) => m.UniqueIndendifier == identifier);
				udpradioProfile.HostDetector.OnDeviceRemove(udpradioProfile);
				this._profileCacheCollection.RemoveAll((global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile m) => m.UniqueIndendifier == identifier);
			}
		}

		// Token: 0x040000C8 RID: 200
		private static global::Motorola.Common.Communication.DeviceDiscovery.UDPDeviceManager _instance;

		// Token: 0x040000C9 RID: 201
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile> _profileCacheCollection;

		// Token: 0x040000CA RID: 202
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.AuthenticationInfo> _passwords;
	}
}
