using System;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000064 RID: 100
	[global::System.Serializable]
	public class ATEmergencyStatus : global::System.ICloneable
	{
		// Token: 0x1700010E RID: 270
		// (get) Token: 0x060002E0 RID: 736 RVA: 0x000079F9 File Offset: 0x00005BF9
		// (set) Token: 0x060002E1 RID: 737 RVA: 0x00007A01 File Offset: 0x00005C01
		public bool InEmergency
		{
			get
			{
				return this._bInEmergency;
			}
			set
			{
				this._bInEmergency = value;
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x060002E2 RID: 738 RVA: 0x00007A0A File Offset: 0x00005C0A
		// (set) Token: 0x060002E3 RID: 739 RVA: 0x00007A12 File Offset: 0x00005C12
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

		// Token: 0x060002E4 RID: 740 RVA: 0x00007A1C File Offset: 0x00005C1C
		public object Clone()
		{
			global::Motorola.Common.Communication.CommonUtil.ATEmergencyStatus atemergencyStatus = base.MemberwiseClone() as global::Motorola.Common.Communication.CommonUtil.ATEmergencyStatus;
			atemergencyStatus.InEmergency = this.InEmergency;
			atemergencyStatus.OperationResult = this.OperationResult;
			return atemergencyStatus;
		}

		// Token: 0x0400035A RID: 858
		private bool _bInEmergency;

		// Token: 0x0400035B RID: 859
		private global::Motorola.Common.Communication.CommonUtil.CommRC _opResult;
	}
}
