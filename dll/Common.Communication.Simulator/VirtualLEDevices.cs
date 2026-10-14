using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization;
using System.Xml;

namespace Common.Communication.Simulator
{
	// Token: 0x02000003 RID: 3
	[global::System.Serializable]
	public class VirtualLEDevices
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000002 RID: 2 RVA: 0x000020EE File Offset: 0x000002EE
		public global::System.Collections.Generic.List<global::Common.Communication.Simulator.LESystemDevicesInfo> LESysDeviceList
		{
			get
			{
				return this._leSysDeviceList;
			}
		}

		// Token: 0x06000003 RID: 3 RVA: 0x000020F6 File Offset: 0x000002F6
		public VirtualLEDevices()
		{
			this._leSysDeviceList = new global::System.Collections.Generic.List<global::Common.Communication.Simulator.LESystemDevicesInfo>();
		}

		// Token: 0x06000004 RID: 4 RVA: 0x0000210C File Offset: 0x0000030C
		private static string GetFilePath()
		{
			string result = string.Empty;
			if (global::System.Reflection.Assembly.GetEntryAssembly() == null)
			{
				result = global::System.IO.Path.GetDirectoryName(global::System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\VirtualRadios\\LESystemList.xml";
			}
			else
			{
				result = global::Common.Communication.Simulator.VRDefinitions.VirtualDeviceFolder + "\\LESystemList.xml";
			}
			return result;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x0000215C File Offset: 0x0000035C
		public static global::Common.Communication.Simulator.VirtualLEDevices LoadFromFile()
		{
			global::System.Runtime.Serialization.DataContractSerializer dataContractSerializer = new global::System.Runtime.Serialization.DataContractSerializer(typeof(global::Common.Communication.Simulator.VirtualLEDevices));
			global::Common.Communication.Simulator.VirtualLEDevices result = null;
			string filePath = global::Common.Communication.Simulator.VirtualLEDevices.GetFilePath();
			if (global::System.IO.File.Exists(filePath))
			{
				using (global::System.Xml.XmlReader xmlReader = global::System.Xml.XmlReader.Create(filePath))
				{
					using (global::System.Xml.XmlDictionaryReader xmlDictionaryReader = global::System.Xml.XmlDictionaryReader.CreateDictionaryReader(xmlReader))
					{
						result = (dataContractSerializer.ReadObject(xmlDictionaryReader) as global::Common.Communication.Simulator.VirtualLEDevices);
					}
				}
				global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
				xmlDocument.Load(filePath);
				xmlDocument.Save(filePath);
			}
			return result;
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000021F4 File Offset: 0x000003F4
		public void SaveToFile()
		{
			global::System.Runtime.Serialization.DataContractSerializer dataContractSerializer = new global::System.Runtime.Serialization.DataContractSerializer(typeof(global::Common.Communication.Simulator.VirtualLEDevices));
			string filePath = global::Common.Communication.Simulator.VirtualLEDevices.GetFilePath();
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

		// Token: 0x04000003 RID: 3
		private global::System.Collections.Generic.List<global::Common.Communication.Simulator.LESystemDevicesInfo> _leSysDeviceList;
	}
}
