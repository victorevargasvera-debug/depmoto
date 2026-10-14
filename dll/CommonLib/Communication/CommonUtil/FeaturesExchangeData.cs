using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x0200001F RID: 31
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Xml.Serialization.XmlType("F")]
	[global::System.Serializable]
	public class FeaturesExchangeData
	{
		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000CB RID: 203 RVA: 0x00003D09 File Offset: 0x00001F09
		// (set) Token: 0x060000CC RID: 204 RVA: 0x00003D11 File Offset: 0x00001F11
		[global::System.Runtime.Serialization.DataMember]
		[global::System.Xml.Serialization.XmlElement("X")]
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DataBlockItem> XmlBufferInput { get; set; }

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000CD RID: 205 RVA: 0x00003D1A File Offset: 0x00001F1A
		// (set) Token: 0x060000CE RID: 206 RVA: 0x00003D22 File Offset: 0x00001F22
		[global::System.Runtime.Serialization.DataMember]
		[global::System.Xml.Serialization.XmlElement("I")]
		public global::System.Collections.Generic.List<byte[]> FeatureCodeIDs { get; set; }

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000CF RID: 207 RVA: 0x00003D2B File Offset: 0x00001F2B
		// (set) Token: 0x060000D0 RID: 208 RVA: 0x00003D33 File Offset: 0x00001F33
		[global::System.Xml.Serialization.XmlElement("N")]
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.List<int> FeatureNames { get; set; }

		// Token: 0x060000D1 RID: 209 RVA: 0x00003D3C File Offset: 0x00001F3C
		public FeaturesExchangeData()
		{
			this.XmlBufferInput = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DataBlockItem>();
			this.FeatureCodeIDs = new global::System.Collections.Generic.List<byte[]>();
			this.FeatureNames = new global::System.Collections.Generic.List<int>();
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00003D68 File Offset: 0x00001F68
		public string SerializeToXml()
		{
			global::System.Xml.Serialization.XmlSerializer xmlSerializer = new global::System.Xml.Serialization.XmlSerializer(base.GetType());
			string result;
			using (global::System.IO.StringWriter stringWriter = new global::System.IO.StringWriter(global::System.Globalization.CultureInfo.InvariantCulture))
			{
				xmlSerializer.Serialize(stringWriter, this);
				result = stringWriter.ToString();
			}
			return result;
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00003DB8 File Offset: 0x00001FB8
		public static global::Motorola.Common.Communication.CommonUtil.FeaturesExchangeData DeserializeFromXml(string xmlInput)
		{
			global::System.Xml.Serialization.XmlSerializer xmlSerializer = new global::System.Xml.Serialization.XmlSerializer(typeof(global::Motorola.Common.Communication.CommonUtil.FeaturesExchangeData));
			global::Motorola.Common.Communication.CommonUtil.FeaturesExchangeData result;
			using (global::System.IO.StringReader stringReader = new global::System.IO.StringReader(xmlInput))
			{
				result = (global::Motorola.Common.Communication.CommonUtil.FeaturesExchangeData)xmlSerializer.Deserialize(stringReader);
			}
			return result;
		}
	}
}
