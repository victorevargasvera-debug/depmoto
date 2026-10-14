using System;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x0200004D RID: 77
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class RadioManuInfo
	{
		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000263 RID: 611 RVA: 0x000071E2 File Offset: 0x000053E2
		// (set) Token: 0x06000264 RID: 612 RVA: 0x000071EA File Offset: 0x000053EA
		public string Manufacturer
		{
			get
			{
				return this._manufacturer;
			}
			set
			{
				this._manufacturer = value;
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000265 RID: 613 RVA: 0x000071F3 File Offset: 0x000053F3
		// (set) Token: 0x06000266 RID: 614 RVA: 0x000071FB File Offset: 0x000053FB
		public string ModelType
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

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06000267 RID: 615 RVA: 0x00007204 File Offset: 0x00005404
		// (set) Token: 0x06000268 RID: 616 RVA: 0x0000720C File Offset: 0x0000540C
		public string TEI
		{
			get
			{
				return this._tEI;
			}
			set
			{
				this._tEI = value;
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000269 RID: 617 RVA: 0x00007215 File Offset: 0x00005415
		// (set) Token: 0x0600026A RID: 618 RVA: 0x0000721D File Offset: 0x0000541D
		public string ISSI
		{
			get
			{
				return this._iSSI;
			}
			set
			{
				this._iSSI = value;
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x0600026B RID: 619 RVA: 0x00007226 File Offset: 0x00005426
		// (set) Token: 0x0600026C RID: 620 RVA: 0x0000722E File Offset: 0x0000542E
		public string GSSI
		{
			get
			{
				return this._gSSI;
			}
			set
			{
				this._gSSI = value;
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x0600026D RID: 621 RVA: 0x00007237 File Offset: 0x00005437
		// (set) Token: 0x0600026E RID: 622 RVA: 0x0000723F File Offset: 0x0000543F
		public string swVer
		{
			get
			{
				return this._swVer;
			}
			set
			{
				this._swVer = value;
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x0600026F RID: 623 RVA: 0x00007248 File Offset: 0x00005448
		// (set) Token: 0x06000270 RID: 624 RVA: 0x00007250 File Offset: 0x00005450
		public string chVer
		{
			get
			{
				return this._chVer;
			}
			set
			{
				this._chVer = value;
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000271 RID: 625 RVA: 0x00007259 File Offset: 0x00005459
		// (set) Token: 0x06000272 RID: 626 RVA: 0x00007261 File Offset: 0x00005461
		public string OPTA
		{
			get
			{
				return this._oPTA;
			}
			set
			{
				this._oPTA = value;
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06000273 RID: 627 RVA: 0x0000726A File Offset: 0x0000546A
		// (set) Token: 0x06000274 RID: 628 RVA: 0x00007272 File Offset: 0x00005472
		public string cpuID
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

		// Token: 0x04000235 RID: 565
		private string _manufacturer = string.Empty;

		// Token: 0x04000236 RID: 566
		private string _modelType = string.Empty;

		// Token: 0x04000237 RID: 567
		private string _tEI = string.Empty;

		// Token: 0x04000238 RID: 568
		private string _iSSI = string.Empty;

		// Token: 0x04000239 RID: 569
		private string _gSSI = string.Empty;

		// Token: 0x0400023A RID: 570
		private string _swVer = string.Empty;

		// Token: 0x0400023B RID: 571
		private string _chVer = string.Empty;

		// Token: 0x0400023C RID: 572
		private string _oPTA = string.Empty;

		// Token: 0x0400023D RID: 573
		private string _cpuID = string.Empty;
	}
}
