using System;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x0200005C RID: 92
	[global::System.Serializable]
	public class RPTerminalIDInfo : global::System.ICloneable
	{
		// Token: 0x170000EF RID: 239
		// (get) Token: 0x06000293 RID: 659 RVA: 0x000074F2 File Offset: 0x000056F2
		// (set) Token: 0x06000294 RID: 660 RVA: 0x000074FA File Offset: 0x000056FA
		public string CpuID
		{
			get
			{
				return this._cpuID;
			}
			set
			{
				this._cpuID = value;
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x06000295 RID: 661 RVA: 0x00007503 File Offset: 0x00005703
		// (set) Token: 0x06000296 RID: 662 RVA: 0x0000750B File Offset: 0x0000570B
		public string PairedCpuID
		{
			get
			{
				return this._pairedCpuID;
			}
			set
			{
				this._pairedCpuID = value;
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000297 RID: 663 RVA: 0x00007514 File Offset: 0x00005714
		// (set) Token: 0x06000298 RID: 664 RVA: 0x0000751C File Offset: 0x0000571C
		public string ChSN
		{
			get
			{
				return this._chSN;
			}
			set
			{
				this._chSN = value;
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06000299 RID: 665 RVA: 0x00007525 File Offset: 0x00005725
		// (set) Token: 0x0600029A RID: 666 RVA: 0x0000752D File Offset: 0x0000572D
		public string ChDieID
		{
			get
			{
				return this._chDieID;
			}
			set
			{
				this._chDieID = value;
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x0600029B RID: 667 RVA: 0x00007536 File Offset: 0x00005736
		// (set) Token: 0x0600029C RID: 668 RVA: 0x0000753E File Offset: 0x0000573E
		public global::Motorola.Common.Communication.CommonUtil.RPTerminalType TermianlType
		{
			get
			{
				return this._termialType;
			}
			set
			{
				this._termialType = value;
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x0600029D RID: 669 RVA: 0x00007547 File Offset: 0x00005747
		// (set) Token: 0x0600029E RID: 670 RVA: 0x0000754F File Offset: 0x0000574F
		public byte[] RawData
		{
			get
			{
				return this._rawData;
			}
			set
			{
				this._rawData = value;
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x0600029F RID: 671 RVA: 0x00007558 File Offset: 0x00005758
		// (set) Token: 0x060002A0 RID: 672 RVA: 0x00007560 File Offset: 0x00005760
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

		// Token: 0x060002A1 RID: 673 RVA: 0x0000756C File Offset: 0x0000576C
		public object Clone()
		{
			global::Motorola.Common.Communication.CommonUtil.RPTerminalIDInfo rpterminalIDInfo = base.MemberwiseClone() as global::Motorola.Common.Communication.CommonUtil.RPTerminalIDInfo;
			rpterminalIDInfo.CpuID = this.CpuID;
			rpterminalIDInfo.PairedCpuID = this.PairedCpuID;
			rpterminalIDInfo.ChDieID = this.ChDieID;
			rpterminalIDInfo.ChSN = this.ChSN;
			rpterminalIDInfo.TermianlType = this.TermianlType;
			rpterminalIDInfo.RawData = this.RawData;
			return rpterminalIDInfo;
		}

		// Token: 0x0400033B RID: 827
		private string _cpuID = string.Empty;

		// Token: 0x0400033C RID: 828
		private string _pairedCpuID = string.Empty;

		// Token: 0x0400033D RID: 829
		private string _chSN = string.Empty;

		// Token: 0x0400033E RID: 830
		private string _chDieID = string.Empty;

		// Token: 0x0400033F RID: 831
		private global::Motorola.Common.Communication.CommonUtil.RPTerminalType _termialType;

		// Token: 0x04000340 RID: 832
		private byte[] _rawData;

		// Token: 0x04000341 RID: 833
		private global::Motorola.Common.Communication.CommonUtil.CommRC _opResult;
	}
}
