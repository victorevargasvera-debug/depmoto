using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using Motorola.Common.Communication.CommonUtil;

namespace Motorola.Common.Communication.TetraUtility
{
	// Token: 0x02000039 RID: 57
	[global::System.Serializable]
	public class XMLConfig<T>
	{
		// Token: 0x060001EA RID: 490 RVA: 0x0000B904 File Offset: 0x00009B04
		public static global::Motorola.Common.Communication.TetraUtility.XMLConfig<T> LoadFile(string filePath)
		{
			global::Motorola.Common.Communication.TetraUtility.XMLConfig<T> result;
			try
			{
				global::Motorola.Common.Communication.TetraUtility.XMLConfig<T> xmlconfig = null;
				string xmlTextWhenDebugOrUnmixDecompressXml = global::Motorola.Common.Communication.TetraUtility.CryptAndZipUtilty.GetXmlTextWhenDebugOrUnmixDecompressXml(filePath);
				using (global::System.IO.StringReader stringReader = new global::System.IO.StringReader(xmlTextWhenDebugOrUnmixDecompressXml))
				{
					global::System.Xml.Serialization.XmlSerializer xmlSerializer = new global::System.Xml.Serialization.XmlSerializer(typeof(global::Motorola.Common.Communication.TetraUtility.XMLConfig<T>));
					xmlconfig = (xmlSerializer.Deserialize(stringReader) as global::Motorola.Common.Communication.TetraUtility.XMLConfig<T>);
				}
				result = xmlconfig;
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Exception: {0}; Message: {1}", new object[]
				{
					ex,
					"XMLConfig.LoadFile: Can't load the XMLConfig file"
				});
				result = new global::Motorola.Common.Communication.TetraUtility.XMLConfig<T>();
			}
			return result;
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060001EB RID: 491 RVA: 0x0000B9A0 File Offset: 0x00009BA0
		// (set) Token: 0x060001EC RID: 492 RVA: 0x0000B9A8 File Offset: 0x00009BA8
		public global::System.Collections.Generic.List<T> RecordsList
		{
			get
			{
				return this._recordsList;
			}
			set
			{
				this._recordsList = value;
			}
		}

		// Token: 0x040000DD RID: 221
		private global::System.Collections.Generic.List<T> _recordsList = new global::System.Collections.Generic.List<T>();
	}
}
