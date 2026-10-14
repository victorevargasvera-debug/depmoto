using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Motorola.Common.Communication.TetraUtility
{
	// Token: 0x02000036 RID: 54
	[global::System.Xml.Serialization.XmlRoot("Dictionary")]
	[global::System.Serializable]
	public class SerializableDictionary<TKey, TValue> : global::System.Collections.Generic.Dictionary<TKey, TValue>, global::System.Xml.Serialization.IXmlSerializable
	{
		// Token: 0x060001C3 RID: 451 RVA: 0x0000B5DC File Offset: 0x000097DC
		public SerializableDictionary()
		{
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x0000B5E4 File Offset: 0x000097E4
		protected SerializableDictionary(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x0000B5EE File Offset: 0x000097EE
		public global::System.Xml.Schema.XmlSchema GetSchema()
		{
			return null;
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x0000B5F4 File Offset: 0x000097F4
		public void ReadXml(global::System.Xml.XmlReader reader)
		{
			global::System.Xml.Serialization.XmlSerializer xmlSerializer = new global::System.Xml.Serialization.XmlSerializer(typeof(TKey));
			global::System.Xml.Serialization.XmlSerializer xmlSerializer2 = new global::System.Xml.Serialization.XmlSerializer(typeof(TValue));
			bool isEmptyElement = reader.IsEmptyElement;
			reader.Read();
			if (isEmptyElement)
			{
				return;
			}
			while (reader.NodeType != global::System.Xml.XmlNodeType.EndElement)
			{
				reader.ReadStartElement("Item");
				reader.ReadStartElement("Key");
				TKey key = (TKey)((object)xmlSerializer.Deserialize(reader));
				reader.ReadEndElement();
				reader.ReadStartElement("Value");
				TValue value = (TValue)((object)xmlSerializer2.Deserialize(reader));
				reader.ReadEndElement();
				base.Add(key, value);
				reader.ReadEndElement();
				reader.MoveToContent();
			}
			reader.ReadEndElement();
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x0000B6A4 File Offset: 0x000098A4
		public void WriteXml(global::System.Xml.XmlWriter writer)
		{
			global::System.Xml.Serialization.XmlSerializer xmlSerializer = new global::System.Xml.Serialization.XmlSerializer(typeof(TKey));
			global::System.Xml.Serialization.XmlSerializer xmlSerializer2 = new global::System.Xml.Serialization.XmlSerializer(typeof(TValue));
			foreach (TKey tkey in base.Keys)
			{
				writer.WriteStartElement("Item");
				writer.WriteStartElement("Key");
				xmlSerializer.Serialize(writer, tkey);
				writer.WriteEndElement();
				writer.WriteStartElement("Value");
				TValue tvalue = base[tkey];
				xmlSerializer2.Serialize(writer, tvalue);
				writer.WriteEndElement();
				writer.WriteEndElement();
			}
		}
	}
}
