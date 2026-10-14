using System;
using System.Xml.Serialization;

namespace Motorola.Common.Communication.TetraUtility
{
	// Token: 0x0200002B RID: 43
	[global::System.Serializable]
	public class FDIVersionMapRecord
	{
		// Token: 0x17000061 RID: 97
		// (get) Token: 0x0600017F RID: 383 RVA: 0x0000B2FE File Offset: 0x000094FE
		// (set) Token: 0x06000180 RID: 384 RVA: 0x0000B306 File Offset: 0x00009506
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

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000181 RID: 385 RVA: 0x0000B30F File Offset: 0x0000950F
		// (set) Token: 0x06000182 RID: 386 RVA: 0x0000B317 File Offset: 0x00009517
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

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000183 RID: 387 RVA: 0x0000B320 File Offset: 0x00009520
		// (set) Token: 0x06000184 RID: 388 RVA: 0x0000B328 File Offset: 0x00009528
		[global::System.Xml.Serialization.XmlAttribute("FdiVersion")]
		public global::Motorola.Common.Communication.TetraUtility.FDIVersion FDIVersion
		{
			get
			{
				return this._fdiVersion;
			}
			set
			{
				this._fdiVersion = value;
			}
		}

		// Token: 0x040000AD RID: 173
		private string _modelNumber = string.Empty;

		// Token: 0x040000AE RID: 174
		private string _cpRange = string.Empty;

		// Token: 0x040000AF RID: 175
		private global::Motorola.Common.Communication.TetraUtility.FDIVersion _fdiVersion = global::Motorola.Common.Communication.TetraUtility.FDIVersion.V5x;
	}
}
