using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization;
using System.Xml;

namespace Common.Communication.Simulator
{
	// Token: 0x0200000B RID: 11
	[global::System.Serializable]
	public class DeviceTypeMap
	{
		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000067 RID: 103 RVA: 0x00002E37 File Offset: 0x00001037
		// (set) Token: 0x06000068 RID: 104 RVA: 0x00002E3F File Offset: 0x0000103F
		public global::System.Collections.Generic.Dictionary<string, global::Common.Communication.Simulator.DeviceIDInfo> DeviceTypeList { get; set; }

		// Token: 0x06000069 RID: 105 RVA: 0x00002E48 File Offset: 0x00001048
		public DeviceTypeMap()
		{
			this.DeviceTypeList = new global::System.Collections.Generic.Dictionary<string, global::Common.Communication.Simulator.DeviceIDInfo>();
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00002E5C File Offset: 0x0000105C
		public static global::Common.Communication.Simulator.DeviceTypeMap LoadFromFile()
		{
			global::System.Runtime.Serialization.DataContractSerializer dataContractSerializer = new global::System.Runtime.Serialization.DataContractSerializer(typeof(global::Common.Communication.Simulator.DeviceTypeMap));
			global::Common.Communication.Simulator.DeviceTypeMap result = null;
			string filePath = global::Common.Communication.Simulator.DeviceTypeMap.GetFilePath();
			if (global::System.IO.File.Exists(filePath))
			{
				using (global::System.Xml.XmlReader xmlReader = global::System.Xml.XmlReader.Create(filePath))
				{
					using (global::System.Xml.XmlDictionaryReader xmlDictionaryReader = global::System.Xml.XmlDictionaryReader.CreateDictionaryReader(xmlReader))
					{
						result = (dataContractSerializer.ReadObject(xmlDictionaryReader) as global::Common.Communication.Simulator.DeviceTypeMap);
					}
				}
			}
			return result;
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00002EE0 File Offset: 0x000010E0
		private static string GetFilePath()
		{
			string result = string.Empty;
			if (global::System.Reflection.Assembly.GetEntryAssembly() == null)
			{
				result = global::System.IO.Path.GetDirectoryName(global::System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\VirtualRadios\\DeviceTypeList.xml";
			}
			else
			{
				result = global::Common.Communication.Simulator.VRDefinitions.VirtualDeviceFolder + "\\DeviceTypeList.xml";
			}
			return result;
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00002F30 File Offset: 0x00001130
		public void SaveToFile()
		{
			global::System.Runtime.Serialization.DataContractSerializer dataContractSerializer = new global::System.Runtime.Serialization.DataContractSerializer(typeof(global::Common.Communication.Simulator.DeviceTypeMap));
			string filePath = global::Common.Communication.Simulator.DeviceTypeMap.GetFilePath();
			using (global::System.Xml.XmlWriter xmlWriter = global::System.Xml.XmlWriter.Create(filePath))
			{
				using (global::System.Xml.XmlDictionaryWriter xmlDictionaryWriter = global::System.Xml.XmlDictionaryWriter.CreateDictionaryWriter(xmlWriter))
				{
					dataContractSerializer.WriteObject(xmlDictionaryWriter, this);
				}
			}
			global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
			xmlDocument.Load(filePath);
			xmlDocument.Save(filePath);
		}
	}
}
