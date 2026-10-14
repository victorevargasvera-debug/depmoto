using System;
using System.Xml.Serialization;
using Motorola.Common.Communication.CommonUtil;

namespace Motorola.Common.Communication.TetraUtility
{
	// Token: 0x0200002F RID: 47
	[global::System.Serializable]
	public class HwIDRecord
	{
		// Token: 0x1700006E RID: 110
		// (get) Token: 0x0600019D RID: 413 RVA: 0x0000B45A File Offset: 0x0000965A
		// (set) Token: 0x0600019E RID: 414 RVA: 0x0000B462 File Offset: 0x00009662
		[global::System.Xml.Serialization.XmlAttribute("HwID")]
		public uint HwID
		{
			get
			{
				return this._hwID;
			}
			set
			{
				this._hwID = value;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x0600019F RID: 415 RVA: 0x0000B46B File Offset: 0x0000966B
		// (set) Token: 0x060001A0 RID: 416 RVA: 0x0000B473 File Offset: 0x00009673
		[global::System.Xml.Serialization.XmlAttribute("BaseHwID")]
		public uint BaseHwID
		{
			get
			{
				return this._baseHwID;
			}
			set
			{
				this._baseHwID = value;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060001A1 RID: 417 RVA: 0x0000B47C File Offset: 0x0000967C
		// (set) Token: 0x060001A2 RID: 418 RVA: 0x0000B484 File Offset: 0x00009684
		[global::System.Xml.Serialization.XmlAttribute("CPUType")]
		public global::Motorola.Common.Communication.TetraUtility.CPUType CPUType
		{
			get
			{
				return this._cpuType;
			}
			set
			{
				this._cpuType = value;
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060001A3 RID: 419 RVA: 0x0000B48D File Offset: 0x0000968D
		// (set) Token: 0x060001A4 RID: 420 RVA: 0x0000B495 File Offset: 0x00009695
		[global::System.Xml.Serialization.XmlAttribute("ProductType")]
		public global::Motorola.Common.Communication.CommonUtil.GemstoneRadioType ProductType
		{
			get
			{
				return this._productType;
			}
			set
			{
				this._productType = value;
			}
		}

		// Token: 0x040000BA RID: 186
		private uint _hwID;

		// Token: 0x040000BB RID: 187
		private uint _baseHwID;

		// Token: 0x040000BC RID: 188
		private global::Motorola.Common.Communication.TetraUtility.CPUType _cpuType;

		// Token: 0x040000BD RID: 189
		private global::Motorola.Common.Communication.CommonUtil.GemstoneRadioType _productType;
	}
}
