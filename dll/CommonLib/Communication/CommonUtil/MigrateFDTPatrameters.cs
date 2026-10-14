using System;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x0200005F RID: 95
	[global::System.Serializable]
	public class MigrateFDTPatrameters : global::System.ICloneable
	{
		// Token: 0x17000101 RID: 257
		// (get) Token: 0x060002BD RID: 701 RVA: 0x000077DC File Offset: 0x000059DC
		// (set) Token: 0x060002BE RID: 702 RVA: 0x000077E4 File Offset: 0x000059E4
		public string SrcCPVersion
		{
			get
			{
				return this._srcCPVer;
			}
			set
			{
				this._srcCPVer = value;
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x060002BF RID: 703 RVA: 0x000077ED File Offset: 0x000059ED
		// (set) Token: 0x060002C0 RID: 704 RVA: 0x000077F5 File Offset: 0x000059F5
		public string DstCPVersion
		{
			get
			{
				return this._dstCPVer;
			}
			set
			{
				this._dstCPVer = value;
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x060002C1 RID: 705 RVA: 0x000077FE File Offset: 0x000059FE
		// (set) Token: 0x060002C2 RID: 706 RVA: 0x00007806 File Offset: 0x00005A06
		public ushort SrcModelType
		{
			get
			{
				return this._srcModelType;
			}
			set
			{
				this._srcModelType = value;
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x060002C3 RID: 707 RVA: 0x0000780F File Offset: 0x00005A0F
		// (set) Token: 0x060002C4 RID: 708 RVA: 0x00007817 File Offset: 0x00005A17
		public ushort DstModelType
		{
			get
			{
				return this._dstModelType;
			}
			set
			{
				this._dstModelType = value;
			}
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x00007820 File Offset: 0x00005A20
		public object Clone()
		{
			global::Motorola.Common.Communication.CommonUtil.MigrateFDTPatrameters migrateFDTPatrameters = base.MemberwiseClone() as global::Motorola.Common.Communication.CommonUtil.MigrateFDTPatrameters;
			migrateFDTPatrameters.SrcCPVersion = this.SrcCPVersion;
			migrateFDTPatrameters.DstCPVersion = this.DstCPVersion;
			migrateFDTPatrameters.SrcModelType = this.SrcModelType;
			migrateFDTPatrameters.DstModelType = this.DstModelType;
			return migrateFDTPatrameters;
		}

		// Token: 0x0400034D RID: 845
		private string _srcCPVer = string.Empty;

		// Token: 0x0400034E RID: 846
		private string _dstCPVer = string.Empty;

		// Token: 0x0400034F RID: 847
		private ushort _srcModelType;

		// Token: 0x04000350 RID: 848
		private ushort _dstModelType;
	}
}
