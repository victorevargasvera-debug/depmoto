using System;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x0200005B RID: 91
	[global::System.Serializable]
	public class RPVersionInfo : global::System.ICloneable
	{
		// Token: 0x0600027B RID: 635 RVA: 0x0000731C File Offset: 0x0000551C
		public RPVersionInfo()
		{
			this._protocolVer = global::Motorola.Common.Communication.CommonUtil.RPProtocolVersion.RP_VER_UNKNOWN;
			this._terminalType = global::Motorola.Common.Communication.CommonUtil.RPTerminalType.RP_UNKNOWN_TYPE;
			this._portableCPChanged = false;
			this._mobileCHCPChanged = false;
			this._mobileTransCPChanged = false;
			this._portableFwVer = 0;
			this._mobileCHFwVer = 0;
			this._mobileTransFwVer = 0;
			this._opResult = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess;
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x0600027C RID: 636 RVA: 0x0000736E File Offset: 0x0000556E
		// (set) Token: 0x0600027D RID: 637 RVA: 0x00007376 File Offset: 0x00005576
		public global::Motorola.Common.Communication.CommonUtil.RPProtocolVersion ProtocolVersion
		{
			get
			{
				return this._protocolVer;
			}
			set
			{
				this._protocolVer = value;
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x0600027E RID: 638 RVA: 0x0000737F File Offset: 0x0000557F
		// (set) Token: 0x0600027F RID: 639 RVA: 0x00007387 File Offset: 0x00005587
		public global::Motorola.Common.Communication.CommonUtil.RPTerminalType TerminalType
		{
			get
			{
				return this._terminalType;
			}
			set
			{
				this._terminalType = value;
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x06000280 RID: 640 RVA: 0x00007390 File Offset: 0x00005590
		// (set) Token: 0x06000281 RID: 641 RVA: 0x00007398 File Offset: 0x00005598
		public bool PortableCPChanged
		{
			get
			{
				return this._portableCPChanged;
			}
			set
			{
				this._portableCPChanged = value;
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000282 RID: 642 RVA: 0x000073A1 File Offset: 0x000055A1
		// (set) Token: 0x06000283 RID: 643 RVA: 0x000073A9 File Offset: 0x000055A9
		public bool MobileControlHeadCPChanged
		{
			get
			{
				return this._mobileCHCPChanged;
			}
			set
			{
				this._mobileCHCPChanged = value;
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000284 RID: 644 RVA: 0x000073B2 File Offset: 0x000055B2
		// (set) Token: 0x06000285 RID: 645 RVA: 0x000073BA File Offset: 0x000055BA
		public bool MobileTransCPChanged
		{
			get
			{
				return this._mobileTransCPChanged;
			}
			set
			{
				this._mobileTransCPChanged = value;
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000286 RID: 646 RVA: 0x000073C3 File Offset: 0x000055C3
		// (set) Token: 0x06000287 RID: 647 RVA: 0x000073CB File Offset: 0x000055CB
		public ushort PortableFwVersion
		{
			get
			{
				return this._portableFwVer;
			}
			set
			{
				this._portableFwVer = value;
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000288 RID: 648 RVA: 0x000073D4 File Offset: 0x000055D4
		// (set) Token: 0x06000289 RID: 649 RVA: 0x000073DC File Offset: 0x000055DC
		public ushort MobileControlHeadFwVersion
		{
			get
			{
				return this._mobileCHFwVer;
			}
			set
			{
				this._mobileCHFwVer = value;
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x0600028A RID: 650 RVA: 0x000073E5 File Offset: 0x000055E5
		// (set) Token: 0x0600028B RID: 651 RVA: 0x000073ED File Offset: 0x000055ED
		public ushort MobileTransFwVersion
		{
			get
			{
				return this._mobileTransFwVer;
			}
			set
			{
				this._mobileTransFwVer = value;
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x0600028C RID: 652 RVA: 0x000073F6 File Offset: 0x000055F6
		// (set) Token: 0x0600028D RID: 653 RVA: 0x000073FE File Offset: 0x000055FE
		public byte[] FlashPacket
		{
			get
			{
				return this._falshPacket;
			}
			set
			{
				this._falshPacket = value;
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x0600028E RID: 654 RVA: 0x00007407 File Offset: 0x00005607
		// (set) Token: 0x0600028F RID: 655 RVA: 0x0000740F File Offset: 0x0000560F
		public int FlashPacketNumber
		{
			get
			{
				return this._flashPacketNum;
			}
			set
			{
				this._flashPacketNum = value;
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000290 RID: 656 RVA: 0x00007418 File Offset: 0x00005618
		// (set) Token: 0x06000291 RID: 657 RVA: 0x00007420 File Offset: 0x00005620
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

		// Token: 0x06000292 RID: 658 RVA: 0x0000742C File Offset: 0x0000562C
		public object Clone()
		{
			global::Motorola.Common.Communication.CommonUtil.RPVersionInfo rpversionInfo = base.MemberwiseClone() as global::Motorola.Common.Communication.CommonUtil.RPVersionInfo;
			if (this.FlashPacket != null)
			{
				rpversionInfo.FlashPacket = new byte[this.FlashPacket.Length];
				global::System.Array.Copy(this.FlashPacket, rpversionInfo.FlashPacket, this.FlashPacket.Length);
			}
			rpversionInfo.FlashPacketNumber = this.FlashPacketNumber;
			rpversionInfo.MobileTransFwVersion = this.MobileTransFwVersion;
			rpversionInfo.MobileControlHeadFwVersion = this.MobileControlHeadFwVersion;
			rpversionInfo.PortableFwVersion = this.PortableFwVersion;
			rpversionInfo.MobileTransCPChanged = this.MobileTransCPChanged;
			rpversionInfo.MobileControlHeadCPChanged = this.MobileControlHeadCPChanged;
			rpversionInfo.PortableCPChanged = this.PortableCPChanged;
			rpversionInfo.TerminalType = this.TerminalType;
			rpversionInfo.ProtocolVersion = this.ProtocolVersion;
			rpversionInfo.OperationResult = this.OperationResult;
			return rpversionInfo;
		}

		// Token: 0x04000330 RID: 816
		private global::Motorola.Common.Communication.CommonUtil.RPProtocolVersion _protocolVer;

		// Token: 0x04000331 RID: 817
		private global::Motorola.Common.Communication.CommonUtil.RPTerminalType _terminalType;

		// Token: 0x04000332 RID: 818
		private bool _portableCPChanged;

		// Token: 0x04000333 RID: 819
		private bool _mobileCHCPChanged;

		// Token: 0x04000334 RID: 820
		private bool _mobileTransCPChanged;

		// Token: 0x04000335 RID: 821
		private ushort _portableFwVer;

		// Token: 0x04000336 RID: 822
		private ushort _mobileCHFwVer;

		// Token: 0x04000337 RID: 823
		private ushort _mobileTransFwVer;

		// Token: 0x04000338 RID: 824
		private byte[] _falshPacket;

		// Token: 0x04000339 RID: 825
		private int _flashPacketNum;

		// Token: 0x0400033A RID: 826
		private global::Motorola.Common.Communication.CommonUtil.CommRC _opResult;
	}
}
