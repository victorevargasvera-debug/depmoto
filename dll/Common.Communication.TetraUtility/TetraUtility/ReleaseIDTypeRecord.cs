using System;
using System.Xml.Serialization;

namespace Motorola.Common.Communication.TetraUtility
{
	// Token: 0x02000035 RID: 53
	[global::System.Serializable]
	public class ReleaseIDTypeRecord
	{
		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060001BC RID: 444 RVA: 0x0000B58B File Offset: 0x0000978B
		// (set) Token: 0x060001BD RID: 445 RVA: 0x0000B593 File Offset: 0x00009793
		[global::System.Xml.Serialization.XmlAttribute("Model")]
		public string Model
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

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060001BE RID: 446 RVA: 0x0000B59C File Offset: 0x0000979C
		// (set) Token: 0x060001BF RID: 447 RVA: 0x0000B5A4 File Offset: 0x000097A4
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

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060001C0 RID: 448 RVA: 0x0000B5AD File Offset: 0x000097AD
		// (set) Token: 0x060001C1 RID: 449 RVA: 0x0000B5B5 File Offset: 0x000097B5
		[global::System.Xml.Serialization.XmlAttribute("ReleaseIDType")]
		public global::Motorola.Common.Communication.TetraUtility.ReleaseIDType ReleaseIDType
		{
			get
			{
				return this._resType;
			}
			set
			{
				this._resType = value;
			}
		}

		// Token: 0x040000CC RID: 204
		private string _modelNumber = string.Empty;

		// Token: 0x040000CD RID: 205
		private string _cpRange = string.Empty;

		// Token: 0x040000CE RID: 206
		private global::Motorola.Common.Communication.TetraUtility.ReleaseIDType _resType;
	}
}
