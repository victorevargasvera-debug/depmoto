using System;
using System.Collections;

namespace Motorola.Common.Communication.DeviceDiscovery
{
	// Token: 0x0200000B RID: 11
	public class DeviceMsgEventArgs : global::System.EventArgs, global::System.ICloneable
	{
		// Token: 0x0600004D RID: 77 RVA: 0x00002D1C File Offset: 0x00000F1C
		public DeviceMsgEventArgs()
		{
			this._deviceAction = global::Motorola.Common.Communication.DeviceDiscovery.DevPnPAction.DeviceStatusUnknow;
			this._radioInfoList = new global::System.Collections.ArrayList();
			this._radioInfoList.Clear();
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600004E RID: 78 RVA: 0x00002D41 File Offset: 0x00000F41
		// (set) Token: 0x0600004F RID: 79 RVA: 0x00002D49 File Offset: 0x00000F49
		public global::Motorola.Common.Communication.DeviceDiscovery.DevPnPAction PnPAction
		{
			get
			{
				return this._deviceAction;
			}
			set
			{
				this._deviceAction = value;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000050 RID: 80 RVA: 0x00002D52 File Offset: 0x00000F52
		public global::System.Collections.ArrayList RadioInfoSet
		{
			get
			{
				return this._radioInfoList;
			}
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002D5C File Offset: 0x00000F5C
		public object Clone()
		{
			return base.MemberwiseClone() as global::Motorola.Common.Communication.DeviceDiscovery.DeviceMsgEventArgs;
		}

		// Token: 0x04000024 RID: 36
		private global::Motorola.Common.Communication.DeviceDiscovery.DevPnPAction _deviceAction;

		// Token: 0x04000025 RID: 37
		private global::System.Collections.ArrayList _radioInfoList;
	}
}
