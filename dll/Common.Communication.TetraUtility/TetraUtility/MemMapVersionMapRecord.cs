using System;
using System.Xml.Serialization;

namespace Motorola.Common.Communication.TetraUtility
{
	// Token: 0x02000032 RID: 50
	[global::System.Serializable]
	public class MemMapVersionMapRecord
	{
		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060001B0 RID: 432 RVA: 0x0000B505 File Offset: 0x00009705
		// (set) Token: 0x060001B1 RID: 433 RVA: 0x0000B50D File Offset: 0x0000970D
		[global::System.Xml.Serialization.XmlAttribute("ModelNumber")]
		public string ModelNumber
		{
			get
			{
				return this._modelNumber;
			}
			set
			{
				this._modelNumber = value;
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060001B2 RID: 434 RVA: 0x0000B516 File Offset: 0x00009716
		// (set) Token: 0x060001B3 RID: 435 RVA: 0x0000B51E File Offset: 0x0000971E
		[global::System.Xml.Serialization.XmlAttribute("CPRange")]
		public string CPRange
		{
			get
			{
				return this._cpRange;
			}
			set
			{
				this._cpRange = value;
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060001B4 RID: 436 RVA: 0x0000B527 File Offset: 0x00009727
		// (set) Token: 0x060001B5 RID: 437 RVA: 0x0000B52F File Offset: 0x0000972F
		[global::System.Xml.Serialization.XmlAttribute("MemMapID")]
		public string MemMapID
		{
			get
			{
				return this._memMapID;
			}
			set
			{
				this._memMapID = value;
			}
		}

		// Token: 0x040000C2 RID: 194
		private string _modelNumber = string.Empty;

		// Token: 0x040000C3 RID: 195
		private string _cpRange = string.Empty;

		// Token: 0x040000C4 RID: 196
		private string _memMapID = string.Empty;
	}
}
