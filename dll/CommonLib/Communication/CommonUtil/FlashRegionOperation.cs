using System;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000069 RID: 105
	[global::System.Serializable]
	public class FlashRegionOperation : global::System.ICloneable
	{
		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000305 RID: 773 RVA: 0x00007CF7 File Offset: 0x00005EF7
		// (set) Token: 0x06000306 RID: 774 RVA: 0x00007CFF File Offset: 0x00005EFF
		public global::Motorola.Common.Communication.CommonUtil.GemstoneFlashType RegionType
		{
			get
			{
				return this._regionType;
			}
			set
			{
				this._regionType = value;
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000307 RID: 775 RVA: 0x00007D08 File Offset: 0x00005F08
		// (set) Token: 0x06000308 RID: 776 RVA: 0x00007D10 File Offset: 0x00005F10
		public global::Motorola.Common.Communication.CommonUtil.FlashOperationType OperationType
		{
			get
			{
				return this._opType;
			}
			set
			{
				this._opType = value;
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000309 RID: 777 RVA: 0x00007D19 File Offset: 0x00005F19
		// (set) Token: 0x0600030A RID: 778 RVA: 0x00007D21 File Offset: 0x00005F21
		public bool OperationResult
		{
			get
			{
				return this._bOK;
			}
			set
			{
				this._bOK = value;
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x0600030B RID: 779 RVA: 0x00007D2A File Offset: 0x00005F2A
		// (set) Token: 0x0600030C RID: 780 RVA: 0x00007D32 File Offset: 0x00005F32
		public string FilePathForOperation
		{
			get
			{
				return this._filePath;
			}
			set
			{
				this._filePath = value;
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x0600030D RID: 781 RVA: 0x00007D3B File Offset: 0x00005F3B
		// (set) Token: 0x0600030E RID: 782 RVA: 0x00007D43 File Offset: 0x00005F43
		public global::Motorola.Common.Communication.CommonUtil.CommRC ErrorReason
		{
			get
			{
				return this._rcCode;
			}
			set
			{
				this._rcCode = value;
			}
		}

		// Token: 0x0600030F RID: 783 RVA: 0x00007D4C File Offset: 0x00005F4C
		public object Clone()
		{
			global::Motorola.Common.Communication.CommonUtil.FlashRegionOperation flashRegionOperation = base.MemberwiseClone() as global::Motorola.Common.Communication.CommonUtil.FlashRegionOperation;
			flashRegionOperation.OperationType = this.OperationType;
			flashRegionOperation.OperationResult = this.OperationResult;
			flashRegionOperation.FilePathForOperation = this.FilePathForOperation;
			flashRegionOperation.RegionType = this.RegionType;
			flashRegionOperation.ErrorReason = this.ErrorReason;
			return flashRegionOperation;
		}

		// Token: 0x04000368 RID: 872
		private global::Motorola.Common.Communication.CommonUtil.FlashOperationType _opType = global::Motorola.Common.Communication.CommonUtil.FlashOperationType.NONE;

		// Token: 0x04000369 RID: 873
		private string _filePath = string.Empty;

		// Token: 0x0400036A RID: 874
		private bool _bOK = true;

		// Token: 0x0400036B RID: 875
		private global::Motorola.Common.Communication.CommonUtil.GemstoneFlashType _regionType = global::Motorola.Common.Communication.CommonUtil.GemstoneFlashType.UNKNOWN;

		// Token: 0x0400036C RID: 876
		private global::Motorola.Common.Communication.CommonUtil.CommRC _rcCode;
	}
}
