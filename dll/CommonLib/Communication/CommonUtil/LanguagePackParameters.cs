using System;
using System.Collections.Generic;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000068 RID: 104
	[global::System.Serializable]
	public class LanguagePackParameters
	{
		// Token: 0x17000117 RID: 279
		// (get) Token: 0x060002FA RID: 762 RVA: 0x00007C84 File Offset: 0x00005E84
		// (set) Token: 0x060002FB RID: 763 RVA: 0x00007C8C File Offset: 0x00005E8C
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> Packs
		{
			get
			{
				return this._packs;
			}
			set
			{
				this._packs = value;
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x060002FC RID: 764 RVA: 0x00007C95 File Offset: 0x00005E95
		// (set) Token: 0x060002FD RID: 765 RVA: 0x00007C9D File Offset: 0x00005E9D
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> AllPacks
		{
			get
			{
				return this._allPacks;
			}
			set
			{
				this._allPacks = value;
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x060002FE RID: 766 RVA: 0x00007CA6 File Offset: 0x00005EA6
		// (set) Token: 0x060002FF RID: 767 RVA: 0x00007CAE File Offset: 0x00005EAE
		public string TargetFwFilePath
		{
			get
			{
				return this._toFwFilePathName;
			}
			set
			{
				this._toFwFilePathName = value;
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x06000300 RID: 768 RVA: 0x00007CB7 File Offset: 0x00005EB7
		// (set) Token: 0x06000301 RID: 769 RVA: 0x00007CBF File Offset: 0x00005EBF
		public string TargetSoftwareVersion
		{
			get
			{
				return this._swVerion;
			}
			set
			{
				this._swVerion = value;
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x06000302 RID: 770 RVA: 0x00007CC8 File Offset: 0x00005EC8
		// (set) Token: 0x06000303 RID: 771 RVA: 0x00007CD0 File Offset: 0x00005ED0
		public uint TargetModelType
		{
			get
			{
				return this._modelType;
			}
			set
			{
				this._modelType = value;
			}
		}

		// Token: 0x04000363 RID: 867
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> _packs;

		// Token: 0x04000364 RID: 868
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> _allPacks;

		// Token: 0x04000365 RID: 869
		private string _toFwFilePathName = string.Empty;

		// Token: 0x04000366 RID: 870
		private string _swVerion = string.Empty;

		// Token: 0x04000367 RID: 871
		private uint _modelType;
	}
}
