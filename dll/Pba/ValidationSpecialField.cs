using System;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.Pba
{
	// Token: 0x0200002D RID: 45
	[global::System.Serializable]
	public class ValidationSpecialField
	{
		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060001A9 RID: 425 RVA: 0x000060C1 File Offset: 0x000042C1
		// (set) Token: 0x060001AA RID: 426 RVA: 0x000060C9 File Offset: 0x000042C9
		[global::System.Xml.Serialization.XmlAttribute("Value")]
		public string Value { get; set; }

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060001AB RID: 427 RVA: 0x000060D2 File Offset: 0x000042D2
		// (set) Token: 0x060001AC RID: 428 RVA: 0x000060DA File Offset: 0x000042DA
		[global::System.Xml.Serialization.XmlAttribute("ValidationMethod")]
		public global::Motorola.Common.Communication.Pba.SpecialValidationMethod SpecialValidationMethod { get; set; }

		// Token: 0x060001AD RID: 429 RVA: 0x000060E3 File Offset: 0x000042E3
		public ValidationSpecialField()
		{
			this.Value = null;
			this.SpecialValidationMethod = global::Motorola.Common.Communication.Pba.SpecialValidationMethod.PCRCodeplugPassword;
		}

		// Token: 0x060001AE RID: 430 RVA: 0x000060F9 File Offset: 0x000042F9
		public ValidationSpecialField(string value, global::Motorola.Common.Communication.Pba.SpecialValidationMethod specialValidationMethod)
		{
			this.Value = value;
			this.SpecialValidationMethod = specialValidationMethod;
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00006110 File Offset: 0x00004310
		public static global::Motorola.Common.Communication.Pba.ValidationField RetrieveValidationInfoFrinString(string value)
		{
			global::Motorola.Common.Communication.Pba.ValidationField validationField = null;
			global::System.Xml.Serialization.XmlSerializer xmlSerializer = new global::System.Xml.Serialization.XmlSerializer(typeof(global::Motorola.Common.Communication.Pba.ValidationField));
			if (string.IsNullOrEmpty(value))
			{
				return validationField;
			}
			global::Motorola.Common.Communication.Pba.ValidationField result;
			using (global::System.IO.TextReader textReader = new global::System.IO.StringReader(value))
			{
				validationField = (xmlSerializer.Deserialize(textReader) as global::Motorola.Common.Communication.Pba.ValidationField);
				result = validationField;
			}
			return result;
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x0000616C File Offset: 0x0000436C
		public static string SerializeValidationInfoToString(global::Motorola.Common.Communication.Pba.ValidationField info)
		{
			global::System.Xml.Serialization.XmlSerializer xmlSerializer = new global::System.Xml.Serialization.XmlSerializer(typeof(global::Motorola.Common.Communication.Pba.ValidationField));
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			using (global::System.Xml.XmlWriter xmlWriter = global::System.Xml.XmlWriter.Create(stringBuilder))
			{
				xmlSerializer.Serialize(xmlWriter, info);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x04000128 RID: 296
		[global::System.Runtime.Serialization.OptionalField]
		[global::System.Xml.Serialization.XmlAttribute("ErrorToThrow")]
		public global::Motorola.Common.CustomException.CommonErrorCode ErrorToThrow;
	}
}
