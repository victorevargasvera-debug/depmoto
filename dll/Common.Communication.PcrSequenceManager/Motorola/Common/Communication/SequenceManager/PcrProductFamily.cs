using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Xml;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Pba;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.SequenceManager
{
	// Token: 0x0200003D RID: 61
	internal class PcrProductFamily
	{
		// Token: 0x060001E2 RID: 482 RVA: 0x0001129C File Offset: 0x0000F49C
		public static global::Motorola.Common.Communication.SequenceManager.PcrProductFamily GetPcrProductFamily(string uuid)
		{
			if (string.IsNullOrWhiteSpace(uuid))
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgument);
			}
			global::Motorola.Common.Communication.SequenceManager.PcrProductFamily result;
			lock (global::Motorola.Common.Communication.SequenceManager.PcrProductFamily.SyncRoot)
			{
				if (!global::Motorola.Common.Communication.SequenceManager.PcrProductFamily.PcrProductFamilies.ContainsKey(uuid))
				{
					global::Motorola.Common.Communication.SequenceManager.PcrProductFamily pcrProductFamily = new global::Motorola.Common.Communication.SequenceManager.PcrProductFamily(uuid);
					global::Motorola.Common.Communication.SequenceManager.PcrProductFamily.PcrProductFamilies.Add(uuid, pcrProductFamily);
					result = pcrProductFamily;
				}
				else
				{
					result = global::Motorola.Common.Communication.SequenceManager.PcrProductFamily.PcrProductFamilies[uuid];
				}
			}
			return result;
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x0001132C File Offset: 0x0000F52C
		public global::Motorola.Common.Communication.SequenceManager.DeviceType GetDeviceType(string modelNumber)
		{
			global::Motorola.Common.Communication.SequenceManager.DeviceType deviceType = global::Motorola.Common.Communication.SequenceManager.DeviceType.Unknown;
			foreach (global::Motorola.Common.Communication.SequenceManager.ModelType modelType in this.Models)
			{
				if (modelType.Regex.IsMatch(modelNumber))
				{
					deviceType = modelType.DeviceType;
					break;
				}
			}
			if (deviceType == global::Motorola.Common.Communication.SequenceManager.DeviceType.Unknown)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Pcr_UnknownDeviceType);
			}
			return deviceType;
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x000113C4 File Offset: 0x0000F5C4
		public bool IsInfoSupported(global::Motorola.Common.Communication.SequenceManager.DeviceInfoField infoField, global::Motorola.Common.Communication.SequenceManager.DeviceType deviceType, string codeplugVersion)
		{
			bool result;
			if (!this.DeviceInfoDependencies.ContainsKey(infoField))
			{
				result = true;
			}
			else
			{
				global::Motorola.Common.Communication.SequenceManager.DeviceInfoDependency deviceInfoDependency = new global::Motorola.Common.Communication.SequenceManager.DeviceInfoDependency(codeplugVersion, deviceType);
				global::Motorola.Common.Communication.SequenceManager.DeviceInfoDependency other = this.DeviceInfoDependencies[infoField];
				result = deviceInfoDependency.Match(other);
			}
			return result;
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x00011408 File Offset: 0x0000F608
		public bool IsBahamaModel(string uuid)
		{
			return string.Equals(uuid, "AF5DAB63F4FC4926BB9000A6F18AF3DC", global::System.StringComparison.OrdinalIgnoreCase);
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x00011434 File Offset: 0x0000F634
		private PcrProductFamily(string uuid)
		{
			try
			{
				using (global::System.IO.Stream manifestResourceStream = global::System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("Motorola.Common.Communication.SequenceManager.PcrProductFamilyMetadata.xml"))
				{
					global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
					xmlDocument.Load(manifestResourceStream);
					string xpath = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "./ProductFamily[UuidList/Uuid = '{0}']", new object[]
					{
						uuid
					});
					global::System.Xml.XmlNode xmlNode = xmlDocument.DocumentElement.SelectSingleNode(xpath);
					this.Family = (global::Motorola.Common.Communication.CommonUtil.ProductFamily)global::System.Enum.Parse(typeof(global::Motorola.Common.Communication.CommonUtil.ProductFamily), xmlNode.Attributes["name"].Value);
					global::System.Xml.XmlNodeList xmlNodeList = xmlNode.SelectNodes("./ReadPartitions/Partition");
					this.ReadPartitions = new global::System.Collections.Generic.List<byte>(xmlNodeList.Count);
					foreach (object obj in xmlNodeList)
					{
						global::System.Xml.XmlNode xmlNode2 = (global::System.Xml.XmlNode)obj;
						byte item = byte.Parse(xmlNode2.Attributes["value"].Value, global::System.Globalization.CultureInfo.InvariantCulture);
						this.ReadPartitions.Add(item);
					}
					global::System.Xml.XmlNodeList xmlNodeList2 = xmlNode.SelectNodes("./WritePartitions/Partition");
					this.WritePartitions = new global::System.Collections.Generic.List<byte>(xmlNodeList2.Count);
					foreach (object obj2 in xmlNodeList2)
					{
						global::System.Xml.XmlNode xmlNode2 = (global::System.Xml.XmlNode)obj2;
						byte item = byte.Parse(xmlNode2.Attributes["value"].Value, global::System.Globalization.CultureInfo.InvariantCulture);
						this.WritePartitions.Add(item);
					}
					global::System.Xml.XmlNodeList xmlNodeList3 = xmlNode.SelectNodes("./ReadFileList/Dir");
					this.ReadFileLists = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem>();
					foreach (object obj3 in xmlNodeList3)
					{
						global::System.Xml.XmlNode xmlNode2 = (global::System.Xml.XmlNode)obj3;
						global::Motorola.Common.Communication.Pba.FileItem item2 = new global::Motorola.Common.Communication.Pba.FileItem(ushort.Parse(xmlNode2.Attributes["partition"].Value, global::System.Globalization.CultureInfo.InvariantCulture), xmlNode2.Attributes["path"].Value, 0, null, null, null);
						this.ReadFileLists.Add(item2);
					}
					global::System.Xml.XmlNodeList xmlNodeList4 = xmlNode.SelectNodes("./ReadFileList/File");
					this.ReadFiles = new global::System.Collections.Generic.Dictionary<string, global::Motorola.Common.Communication.Pba.FileItem>();
					foreach (object obj4 in xmlNodeList4)
					{
						global::System.Xml.XmlNode xmlNode2 = (global::System.Xml.XmlNode)obj4;
						global::Motorola.Common.Communication.Pba.FileItem value = new global::Motorola.Common.Communication.Pba.FileItem(ushort.Parse(xmlNode2.Attributes["partition"].Value, global::System.Globalization.CultureInfo.InvariantCulture), xmlNode2.Attributes["path"].Value, 0, null, null, null);
						this.ReadFiles.Add(xmlNode2.Attributes["name"].Value, value);
					}
					global::System.Xml.XmlNodeList xmlNodeList5 = xmlNode.SelectNodes("./DeviceInfoDependencies/Info");
					this.DeviceInfoDependencies = new global::System.Collections.Generic.Dictionary<global::Motorola.Common.Communication.SequenceManager.DeviceInfoField, global::Motorola.Common.Communication.SequenceManager.DeviceInfoDependency>(xmlNodeList5.Count);
					foreach (object obj5 in xmlNodeList5)
					{
						global::System.Xml.XmlNode xmlNode2 = (global::System.Xml.XmlNode)obj5;
						global::Motorola.Common.Communication.SequenceManager.DeviceInfoField key = (global::Motorola.Common.Communication.SequenceManager.DeviceInfoField)global::System.Enum.Parse(typeof(global::Motorola.Common.Communication.SequenceManager.DeviceInfoField), xmlNode2.Attributes["name"].Value);
						global::System.Xml.XmlAttribute xmlAttribute = xmlNode2.Attributes["CodeplugVersion"];
						string codeplugVersion = string.Empty;
						if (xmlAttribute != null)
						{
							codeplugVersion = xmlAttribute.Value;
						}
						xmlAttribute = xmlNode2.Attributes["Model"];
						global::Motorola.Common.Communication.SequenceManager.DeviceType deviceType = global::Motorola.Common.Communication.SequenceManager.DeviceType.Any;
						if (xmlAttribute != null && !string.IsNullOrWhiteSpace(xmlAttribute.Value))
						{
							deviceType = global::Motorola.Common.Communication.SequenceManager.DeviceType.Unknown;
							string[] array = xmlAttribute.Value.Split(new char[]
							{
								';'
							});
							foreach (string text in array)
							{
								string value2 = text.Trim();
								if (!string.IsNullOrEmpty(value2))
								{
									deviceType |= (global::Motorola.Common.Communication.SequenceManager.DeviceType)global::System.Enum.Parse(typeof(global::Motorola.Common.Communication.SequenceManager.DeviceType), value2);
								}
							}
						}
						global::Motorola.Common.Communication.SequenceManager.DeviceInfoDependency value3 = new global::Motorola.Common.Communication.SequenceManager.DeviceInfoDependency(codeplugVersion, deviceType);
						this.DeviceInfoDependencies.Add(key, value3);
					}
					global::System.Xml.XmlNodeList xmlNodeList6 = xmlNode.SelectNodes("./DeviceTypes/Model");
					this.Models = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.SequenceManager.ModelType>(xmlNodeList6.Count);
					foreach (object obj6 in xmlNodeList6)
					{
						global::System.Xml.XmlNode xmlNode2 = (global::System.Xml.XmlNode)obj6;
						global::Motorola.Common.Communication.SequenceManager.ModelType modelType = new global::Motorola.Common.Communication.SequenceManager.ModelType();
						global::System.Text.RegularExpressions.Regex regex = new global::System.Text.RegularExpressions.Regex(xmlNode2.Attributes["regex"].Value);
						modelType.DeviceType = (global::Motorola.Common.Communication.SequenceManager.DeviceType)global::System.Enum.Parse(typeof(global::Motorola.Common.Communication.SequenceManager.DeviceType), xmlNode2.Attributes["type"].Value);
						modelType.Regex = regex;
						this.Models.Add(modelType);
					}
					this.UUID = uuid;
				}
			}
			catch (global::System.Exception systemException)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidProductFamilyMetadata, systemException);
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060001E7 RID: 487 RVA: 0x00011ADC File Offset: 0x0000FCDC
		// (set) Token: 0x060001E8 RID: 488 RVA: 0x00011AF3 File Offset: 0x0000FCF3
		public global::System.Collections.Generic.Dictionary<string, global::Motorola.Common.Communication.Pba.FileItem> ReadFiles { get; private set; }

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060001E9 RID: 489 RVA: 0x00011AFC File Offset: 0x0000FCFC
		// (set) Token: 0x060001EA RID: 490 RVA: 0x00011B13 File Offset: 0x0000FD13
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem> ReadFileLists { get; private set; }

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060001EB RID: 491 RVA: 0x00011B1C File Offset: 0x0000FD1C
		// (set) Token: 0x060001EC RID: 492 RVA: 0x00011B33 File Offset: 0x0000FD33
		public global::System.Collections.Generic.List<byte> ReadPartitions { get; private set; }

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060001ED RID: 493 RVA: 0x00011B3C File Offset: 0x0000FD3C
		// (set) Token: 0x060001EE RID: 494 RVA: 0x00011B53 File Offset: 0x0000FD53
		public global::System.Collections.Generic.List<byte> WritePartitions { get; private set; }

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060001EF RID: 495 RVA: 0x00011B5C File Offset: 0x0000FD5C
		// (set) Token: 0x060001F0 RID: 496 RVA: 0x00011B73 File Offset: 0x0000FD73
		public global::Motorola.Common.Communication.CommonUtil.ProductFamily Family { get; private set; }

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060001F1 RID: 497 RVA: 0x00011B7C File Offset: 0x0000FD7C
		// (set) Token: 0x060001F2 RID: 498 RVA: 0x00011B93 File Offset: 0x0000FD93
		private global::System.Collections.Generic.Dictionary<global::Motorola.Common.Communication.SequenceManager.DeviceInfoField, global::Motorola.Common.Communication.SequenceManager.DeviceInfoDependency> DeviceInfoDependencies { get; set; }

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060001F3 RID: 499 RVA: 0x00011B9C File Offset: 0x0000FD9C
		// (set) Token: 0x060001F4 RID: 500 RVA: 0x00011BB3 File Offset: 0x0000FDB3
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.SequenceManager.ModelType> Models { get; set; }

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060001F5 RID: 501 RVA: 0x00011BBC File Offset: 0x0000FDBC
		// (set) Token: 0x060001F6 RID: 502 RVA: 0x00011BD3 File Offset: 0x0000FDD3
		public string UUID { get; private set; }

		// Token: 0x04000118 RID: 280
		private static global::System.Collections.Generic.Dictionary<string, global::Motorola.Common.Communication.SequenceManager.PcrProductFamily> PcrProductFamilies = new global::System.Collections.Generic.Dictionary<string, global::Motorola.Common.Communication.SequenceManager.PcrProductFamily>();

		// Token: 0x04000119 RID: 281
		private static object SyncRoot = new object();
	}
}
