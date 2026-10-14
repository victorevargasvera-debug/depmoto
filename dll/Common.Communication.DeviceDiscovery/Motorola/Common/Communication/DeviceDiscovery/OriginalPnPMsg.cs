using System;

namespace Motorola.Common.Communication.DeviceDiscovery
{
	// Token: 0x02000008 RID: 8
	public class OriginalPnPMsg
	{
		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600003F RID: 63 RVA: 0x00002CA6 File Offset: 0x00000EA6
		// (set) Token: 0x06000040 RID: 64 RVA: 0x00002CAE File Offset: 0x00000EAE
		public bool isSimulated
		{
			get
			{
				return this._isSimulated;
			}
			set
			{
				this._isSimulated = value;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000041 RID: 65 RVA: 0x00002CB7 File Offset: 0x00000EB7
		// (set) Token: 0x06000042 RID: 66 RVA: 0x00002CBF File Offset: 0x00000EBF
		public bool isPreAttached
		{
			get
			{
				return this._isPreAttached;
			}
			set
			{
				this._isPreAttached = value;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000043 RID: 67 RVA: 0x00002CC8 File Offset: 0x00000EC8
		// (set) Token: 0x06000044 RID: 68 RVA: 0x00002CD0 File Offset: 0x00000ED0
		public global::Motorola.Common.Communication.DeviceDiscovery.DevPnPAction m_DeviceAction
		{
			internal get
			{
				return this._m_DeviceAction;
			}
			set
			{
				this._m_DeviceAction = value;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000045 RID: 69 RVA: 0x00002CD9 File Offset: 0x00000ED9
		// (set) Token: 0x06000046 RID: 70 RVA: 0x00002CE1 File Offset: 0x00000EE1
		public string sDeviceName
		{
			internal get
			{
				return this._sDeviceName;
			}
			set
			{
				this._sDeviceName = value;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000047 RID: 71 RVA: 0x00002CEA File Offset: 0x00000EEA
		// (set) Token: 0x06000048 RID: 72 RVA: 0x00002CF2 File Offset: 0x00000EF2
		public global::Motorola.Common.Communication.IRadioProfile radioProfile
		{
			internal get
			{
				return this._radioProfile;
			}
			set
			{
				this._radioProfile = value;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000049 RID: 73 RVA: 0x00002CFB File Offset: 0x00000EFB
		// (set) Token: 0x0600004A RID: 74 RVA: 0x00002D03 File Offset: 0x00000F03
		public bool isVolume
		{
			get
			{
				return this._isVolume;
			}
			set
			{
				this._isVolume = value;
			}
		}

		// Token: 0x04000019 RID: 25
		private bool _isSimulated;

		// Token: 0x0400001A RID: 26
		private bool _isPreAttached;

		// Token: 0x0400001B RID: 27
		private global::Motorola.Common.Communication.DeviceDiscovery.DevPnPAction _m_DeviceAction;

		// Token: 0x0400001C RID: 28
		private string _sDeviceName;

		// Token: 0x0400001D RID: 29
		private global::Motorola.Common.Communication.IRadioProfile _radioProfile;

		// Token: 0x0400001E RID: 30
		private bool _isVolume;
	}
}
