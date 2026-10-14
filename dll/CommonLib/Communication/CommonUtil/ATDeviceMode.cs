using System;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000063 RID: 99
	[global::System.Serializable]
	public class ATDeviceMode : global::System.ICloneable
	{
		// Token: 0x1700010C RID: 268
		// (get) Token: 0x060002DA RID: 730 RVA: 0x00007995 File Offset: 0x00005B95
		// (set) Token: 0x060002DB RID: 731 RVA: 0x0000799D File Offset: 0x00005B9D
		public global::Motorola.Common.Communication.CommonUtil.DeviceMode DevMode
		{
			get
			{
				return this._devMode;
			}
			set
			{
				this._devMode = value;
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x060002DC RID: 732 RVA: 0x000079A6 File Offset: 0x00005BA6
		// (set) Token: 0x060002DD RID: 733 RVA: 0x000079AE File Offset: 0x00005BAE
		public global::Motorola.Common.Communication.CommonUtil.CommRC OperationResult
		{
			get
			{
				return this._opResult;
			}
			set
			{
				this._opResult = value;
			}
		}

		// Token: 0x060002DE RID: 734 RVA: 0x000079B8 File Offset: 0x00005BB8
		public object Clone()
		{
			global::Motorola.Common.Communication.CommonUtil.ATDeviceMode atdeviceMode = base.MemberwiseClone() as global::Motorola.Common.Communication.CommonUtil.ATDeviceMode;
			atdeviceMode.DevMode = this.DevMode;
			atdeviceMode.OperationResult = this.OperationResult;
			return atdeviceMode;
		}

		// Token: 0x04000358 RID: 856
		private global::Motorola.Common.Communication.CommonUtil.DeviceMode _devMode = global::Motorola.Common.Communication.CommonUtil.DeviceMode.UNKNOWN;

		// Token: 0x04000359 RID: 857
		private global::Motorola.Common.Communication.CommonUtil.CommRC _opResult;
	}
}
