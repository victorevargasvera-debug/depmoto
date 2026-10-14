using System;
using System.Xml.Serialization;

namespace Motorola.Common.Communication.TetraUtility
{
	// Token: 0x02000033 RID: 51
	[global::System.Serializable]
	public class ModelHwIDMapRecord
	{
		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060001B7 RID: 439 RVA: 0x0000B561 File Offset: 0x00009761
		// (set) Token: 0x060001B8 RID: 440 RVA: 0x0000B569 File Offset: 0x00009769
		[global::System.Xml.Serialization.XmlAttribute("CommonModelNumber")]
		public string CommonModelNumber { get; set; }

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060001B9 RID: 441 RVA: 0x0000B572 File Offset: 0x00009772
		// (set) Token: 0x060001BA RID: 442 RVA: 0x0000B57A File Offset: 0x0000977A
		[global::System.Xml.Serialization.XmlAttribute("HwIDList")]
		public string HwIDList { get; set; }
	}
}
