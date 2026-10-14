using System;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000065 RID: 101
	[global::System.Serializable]
	public class ATRadioManuInfo : global::System.ICloneable
	{
		// Token: 0x17000110 RID: 272
		// (get) Token: 0x060002E6 RID: 742 RVA: 0x00007A56 File Offset: 0x00005C56
		// (set) Token: 0x060002E7 RID: 743 RVA: 0x00007A5E File Offset: 0x00005C5E
		public global::Motorola.Common.Communication.CommonUtil.RadioManuInfo RadioATInfo
		{
			get
			{
				return this._info;
			}
			set
			{
				this._info = value;
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x060002E8 RID: 744 RVA: 0x00007A67 File Offset: 0x00005C67
		// (set) Token: 0x060002E9 RID: 745 RVA: 0x00007A6F File Offset: 0x00005C6F
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

		// Token: 0x060002EA RID: 746 RVA: 0x00007A78 File Offset: 0x00005C78
		public object Clone()
		{
			global::Motorola.Common.Communication.CommonUtil.ATRadioManuInfo atradioManuInfo = base.MemberwiseClone() as global::Motorola.Common.Communication.CommonUtil.ATRadioManuInfo;
			if (this.RadioATInfo != null)
			{
				atradioManuInfo.RadioATInfo = new global::Motorola.Common.Communication.CommonUtil.RadioManuInfo();
				atradioManuInfo.RadioATInfo.chVer = this.RadioATInfo.chVer;
				atradioManuInfo.RadioATInfo.cpuID = this.RadioATInfo.cpuID;
				atradioManuInfo.RadioATInfo.GSSI = this.RadioATInfo.GSSI;
				atradioManuInfo.RadioATInfo.ISSI = this.RadioATInfo.ISSI;
				atradioManuInfo.RadioATInfo.Manufacturer = this.RadioATInfo.Manufacturer;
				atradioManuInfo.RadioATInfo.ModelType = this.RadioATInfo.ModelType;
				atradioManuInfo.RadioATInfo.OPTA = this.RadioATInfo.OPTA;
				atradioManuInfo.RadioATInfo.swVer = this.RadioATInfo.swVer;
				atradioManuInfo.RadioATInfo.TEI = this.RadioATInfo.TEI;
			}
			atradioManuInfo.OperationResult = this.OperationResult;
			return atradioManuInfo;
		}

		// Token: 0x0400035C RID: 860
		private global::Motorola.Common.Communication.CommonUtil.RadioManuInfo _info;

		// Token: 0x0400035D RID: 861
		private global::Motorola.Common.Communication.CommonUtil.CommRC _opResult;
	}
}
