using System;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x0200005D RID: 93
	[global::System.Serializable]
	public class RPStatusIndicationInfo : global::System.ICloneable
	{
		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x060002A3 RID: 675 RVA: 0x00007602 File Offset: 0x00005802
		// (set) Token: 0x060002A4 RID: 676 RVA: 0x0000760A File Offset: 0x0000580A
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

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x060002A5 RID: 677 RVA: 0x00007613 File Offset: 0x00005813
		// (set) Token: 0x060002A6 RID: 678 RVA: 0x0000761B File Offset: 0x0000581B
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

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x060002A7 RID: 679 RVA: 0x00007624 File Offset: 0x00005824
		// (set) Token: 0x060002A8 RID: 680 RVA: 0x0000762C File Offset: 0x0000582C
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

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x060002A9 RID: 681 RVA: 0x00007635 File Offset: 0x00005835
		// (set) Token: 0x060002AA RID: 682 RVA: 0x0000763D File Offset: 0x0000583D
		public global::Motorola.Common.Communication.CommonUtil.RPTerminalStatus Status
		{
			get
			{
				return this._status;
			}
			set
			{
				this._status = value;
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x060002AB RID: 683 RVA: 0x00007646 File Offset: 0x00005846
		// (set) Token: 0x060002AC RID: 684 RVA: 0x0000764E File Offset: 0x0000584E
		public string TerminalId
		{
			get
			{
				return this._terminalId;
			}
			set
			{
				this._terminalId = value;
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x060002AD RID: 685 RVA: 0x00007657 File Offset: 0x00005857
		// (set) Token: 0x060002AE RID: 686 RVA: 0x0000765F File Offset: 0x0000585F
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

		// Token: 0x060002AF RID: 687 RVA: 0x00007668 File Offset: 0x00005868
		public object Clone()
		{
			global::Motorola.Common.Communication.CommonUtil.RPStatusIndicationInfo rpstatusIndicationInfo = base.MemberwiseClone() as global::Motorola.Common.Communication.CommonUtil.RPStatusIndicationInfo;
			if (this.RawData != null)
			{
				rpstatusIndicationInfo.RawData = new byte[this.RawData.Length];
				global::System.Array.Copy(this.RawData, rpstatusIndicationInfo.RawData, this.RawData.Length);
			}
			rpstatusIndicationInfo.TermianlType = this.TermianlType;
			rpstatusIndicationInfo.DevMode = this.DevMode;
			rpstatusIndicationInfo.Status = this.Status;
			rpstatusIndicationInfo.TerminalId = this.TerminalId;
			rpstatusIndicationInfo.OperationResult = this.OperationResult;
			return rpstatusIndicationInfo;
		}

		// Token: 0x04000342 RID: 834
		private global::Motorola.Common.Communication.CommonUtil.RPTerminalType _termialType;

		// Token: 0x04000343 RID: 835
		private byte[] _rawData;

		// Token: 0x04000344 RID: 836
		private global::Motorola.Common.Communication.CommonUtil.DeviceMode _devMode = global::Motorola.Common.Communication.CommonUtil.DeviceMode.UNKNOWN;

		// Token: 0x04000345 RID: 837
		private global::Motorola.Common.Communication.CommonUtil.RPTerminalStatus _status = global::Motorola.Common.Communication.CommonUtil.RPTerminalStatus.RP_STATUS_UNKNOWN;

		// Token: 0x04000346 RID: 838
		private string _terminalId = string.Empty;

		// Token: 0x04000347 RID: 839
		private global::Motorola.Common.Communication.CommonUtil.CommRC _opResult;
	}
}
