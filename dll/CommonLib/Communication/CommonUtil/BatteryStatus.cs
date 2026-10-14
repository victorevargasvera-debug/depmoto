using System;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000061 RID: 97
	[global::System.Serializable]
	public class BatteryStatus : global::System.ICloneable
	{
		// Token: 0x17000107 RID: 263
		// (get) Token: 0x060002CC RID: 716 RVA: 0x000078B2 File Offset: 0x00005AB2
		// (set) Token: 0x060002CD RID: 717 RVA: 0x000078BA File Offset: 0x00005ABA
		public int BCS
		{
			get
			{
				return this._bcs;
			}
			set
			{
				this._bcs = value;
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x060002CE RID: 718 RVA: 0x000078C3 File Offset: 0x00005AC3
		// (set) Token: 0x060002CF RID: 719 RVA: 0x000078CB File Offset: 0x00005ACB
		public int BCL
		{
			get
			{
				return this._bcl;
			}
			set
			{
				this._bcl = value;
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x060002D0 RID: 720 RVA: 0x000078D4 File Offset: 0x00005AD4
		// (set) Token: 0x060002D1 RID: 721 RVA: 0x000078DC File Offset: 0x00005ADC
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

		// Token: 0x060002D2 RID: 722 RVA: 0x000078E8 File Offset: 0x00005AE8
		public object Clone()
		{
			global::Motorola.Common.Communication.CommonUtil.BatteryStatus batteryStatus = base.MemberwiseClone() as global::Motorola.Common.Communication.CommonUtil.BatteryStatus;
			batteryStatus.BCS = this.BCS;
			batteryStatus.BCL = this.BCL;
			batteryStatus.OperationResult = this.OperationResult;
			return batteryStatus;
		}

		// Token: 0x04000353 RID: 851
		private int _bcs;

		// Token: 0x04000354 RID: 852
		private int _bcl;

		// Token: 0x04000355 RID: 853
		private global::Motorola.Common.Communication.CommonUtil.CommRC _opResult;
	}
}
