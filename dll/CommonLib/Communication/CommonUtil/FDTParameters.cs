using System;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x0200005E RID: 94
	[global::System.Serializable]
	public class FDTParameters : global::System.ICloneable
	{
		// Token: 0x170000FC RID: 252
		// (get) Token: 0x060002B1 RID: 689 RVA: 0x00007713 File Offset: 0x00005913
		// (set) Token: 0x060002B2 RID: 690 RVA: 0x0000771B File Offset: 0x0000591B
		public global::Motorola.Common.Communication.CommonUtil.FDTType Type
		{
			get
			{
				return this._type;
			}
			set
			{
				this._type = value;
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x060002B3 RID: 691 RVA: 0x00007724 File Offset: 0x00005924
		// (set) Token: 0x060002B4 RID: 692 RVA: 0x0000772C File Offset: 0x0000592C
		public string Version
		{
			get
			{
				return this._version;
			}
			set
			{
				this._version = value;
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x060002B5 RID: 693 RVA: 0x00007735 File Offset: 0x00005935
		// (set) Token: 0x060002B6 RID: 694 RVA: 0x0000773D File Offset: 0x0000593D
		public ushort ModelType
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

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x060002B7 RID: 695 RVA: 0x00007746 File Offset: 0x00005946
		// (set) Token: 0x060002B8 RID: 696 RVA: 0x0000774E File Offset: 0x0000594E
		public string Info
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

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x060002B9 RID: 697 RVA: 0x00007757 File Offset: 0x00005957
		// (set) Token: 0x060002BA RID: 698 RVA: 0x0000775F File Offset: 0x0000595F
		public bool FixFDTError
		{
			get
			{
				return this._fixFDTError;
			}
			set
			{
				this._fixFDTError = value;
			}
		}

		// Token: 0x060002BB RID: 699 RVA: 0x00007768 File Offset: 0x00005968
		public object Clone()
		{
			global::Motorola.Common.Communication.CommonUtil.FDTParameters fdtparameters = base.MemberwiseClone() as global::Motorola.Common.Communication.CommonUtil.FDTParameters;
			fdtparameters.Type = this.Type;
			fdtparameters.Version = this.Version;
			fdtparameters.Info = this.Info;
			fdtparameters.FixFDTError = this.FixFDTError;
			fdtparameters.ModelType = this.ModelType;
			return fdtparameters;
		}

		// Token: 0x04000348 RID: 840
		private global::Motorola.Common.Communication.CommonUtil.FDTType _type;

		// Token: 0x04000349 RID: 841
		private string _version = string.Empty;

		// Token: 0x0400034A RID: 842
		private ushort _modelType;

		// Token: 0x0400034B RID: 843
		private string _info = string.Empty;

		// Token: 0x0400034C RID: 844
		private bool _fixFDTError;
	}
}
