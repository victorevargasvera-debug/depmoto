using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.Pba
{
	// Token: 0x0200002A RID: 42
	[global::System.Serializable]
	public class ValidationInfo
	{
		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060001A0 RID: 416 RVA: 0x00006013 File Offset: 0x00004213
		// (set) Token: 0x060001A1 RID: 417 RVA: 0x0000601B File Offset: 0x0000421B
		[global::System.Xml.Serialization.XmlAttribute("ID")]
		public string ID { get; set; }

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060001A2 RID: 418 RVA: 0x00006024 File Offset: 0x00004224
		// (set) Token: 0x060001A3 RID: 419 RVA: 0x0000602C File Offset: 0x0000422C
		[global::System.Xml.Serialization.XmlAttribute("Value")]
		public string Value { get; set; }

		// Token: 0x060001A4 RID: 420 RVA: 0x00006035 File Offset: 0x00004235
		public ValidationInfo()
		{
			this.ID = string.Empty;
			this.Value = string.Empty;
			this.ValidationMethod = global::Motorola.Common.Communication.Pba.ValidationMethod.Equal;
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x0000605A File Offset: 0x0000425A
		public ValidationInfo(string id, string value)
		{
			this.ID = id;
			this.Value = value;
			this.ValidationMethod = global::Motorola.Common.Communication.Pba.ValidationMethod.Equal;
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00006077 File Offset: 0x00004277
		public ValidationInfo(string id, string value, global::Motorola.Common.Communication.Pba.ValidationMethod validationMethod)
		{
			this.ID = id;
			this.Value = value;
			this.ValidationMethod = validationMethod;
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00006094 File Offset: 0x00004294
		public ValidationInfo(string id, string value, global::Motorola.Common.Communication.Pba.ValidationMethod validationMethod, global::Motorola.Common.CustomException.CommonErrorCode errorToThrow)
		{
			this.ID = id;
			this.Value = value;
			this.ValidationMethod = validationMethod;
			this.ErrorToThrow = errorToThrow;
		}

		// Token: 0x0400011B RID: 283
		[global::System.Runtime.Serialization.OptionalField]
		[global::System.Xml.Serialization.XmlAttribute("ValidationMethod")]
		public global::Motorola.Common.Communication.Pba.ValidationMethod ValidationMethod;

		// Token: 0x0400011C RID: 284
		[global::System.Xml.Serialization.XmlAttribute("ErrorToThrow")]
		[global::System.Runtime.Serialization.OptionalField]
		public global::Motorola.Common.CustomException.CommonErrorCode ErrorToThrow;
	}
}
