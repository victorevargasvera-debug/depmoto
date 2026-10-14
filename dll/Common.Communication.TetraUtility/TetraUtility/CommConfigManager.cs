using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;

namespace Motorola.Common.Communication.TetraUtility
{
	// Token: 0x02000027 RID: 39
	public class CommConfigManager
	{
		// Token: 0x06000138 RID: 312 RVA: 0x0000A904 File Offset: 0x00008B04
		private CommConfigManager()
		{
			this._configDir = global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.CommConfigDir;
			if (string.IsNullOrEmpty(this._configDir))
			{
				throw new global::System.Exception("Meta-data not init!");
			}
			this._hwIDTable = global::Motorola.Common.Communication.TetraUtility.XMLConfig<global::Motorola.Common.Communication.TetraUtility.HwIDRecord>.LoadFile(global::System.IO.Path.Combine(this._configDir, "HwIDConfig.xml"));
			this._flashTypeConfigTable = global::Motorola.Common.Communication.TetraUtility.XMLConfig<global::Motorola.Common.Communication.TetraUtility.FlashTypeRecord>.LoadFile(global::System.IO.Path.Combine(this._configDir, "FlashConfig.xml"));
			this._memMapConfigTable = global::Motorola.Common.Communication.TetraUtility.XMLConfig<global::Motorola.Common.Communication.TetraUtility.MemMapRecord>.LoadFile(global::System.IO.Path.Combine(this._configDir, "MemMapConfig.xml"));
			this._flashPackNamesTable = global::Motorola.Common.Communication.TetraUtility.XMLConfig<global::Motorola.Common.Communication.TetraUtility.FlashPackNamesRecord>.LoadFile(global::System.IO.Path.Combine(this._configDir, "FlashPackNamesConfig.xml"));
			this._cpuTypeConfigTable = global::Motorola.Common.Communication.TetraUtility.XMLConfig<global::Motorola.Common.Communication.TetraUtility.CPUTypeRecord>.LoadFile(global::System.IO.Path.Combine(this._configDir, "CPUTypeConfig.xml"));
			this._fdiVersionMapConfigTable = global::Motorola.Common.Communication.TetraUtility.XMLConfig<global::Motorola.Common.Communication.TetraUtility.FDIVersionMapRecord>.LoadFile(global::System.IO.Path.Combine(this._configDir, "FDIVersionMapConfig.xml"));
			this._flashstrapVersionMapConfigTable = global::Motorola.Common.Communication.TetraUtility.XMLConfig<global::Motorola.Common.Communication.TetraUtility.FlashstrapVersionMapRecord>.LoadFile(global::System.IO.Path.Combine(this._configDir, "FlashstrapVersionMapConfig.xml"));
			this._memMapVersionMapConfigTable = global::Motorola.Common.Communication.TetraUtility.XMLConfig<global::Motorola.Common.Communication.TetraUtility.MemMapVersionMapRecord>.LoadFile(global::System.IO.Path.Combine(this._configDir, "MemMapVersionMapConfig.xml"));
			this._modelHwIDMapConfigTable = global::Motorola.Common.Communication.TetraUtility.XMLConfig<global::Motorola.Common.Communication.TetraUtility.ModelHwIDMapRecord>.LoadFile(global::System.IO.Path.Combine(this._configDir, "ModelHwIDMapConfig.xml"));
			this._releaseIDTypeTable = global::Motorola.Common.Communication.TetraUtility.XMLConfig<global::Motorola.Common.Communication.TetraUtility.ReleaseIDTypeRecord>.LoadFile(global::System.IO.Path.Combine(this._configDir, "ReleaseIDTypeConfig.xml"));
			global::System.Xml.XmlDocument modelTableXmlDoc = this.GetModelTableXmlDoc();
			this._modelInfoList = this.BuildModelInfor(modelTableXmlDoc);
			this._groupInfoList = this.BuildGroupInfor(modelTableXmlDoc);
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000139 RID: 313 RVA: 0x0000AA74 File Offset: 0x00008C74
		public static global::Motorola.Common.Communication.TetraUtility.CommConfigManager Instance
		{
			get
			{
				global::Motorola.Common.Communication.TetraUtility.CommConfigManager instance;
				lock (global::Motorola.Common.Communication.TetraUtility.CommConfigManager.accessControl)
				{
					if (global::Motorola.Common.Communication.TetraUtility.CommConfigManager._instance == null)
					{
						global::Motorola.Common.Communication.TetraUtility.CommConfigManager._instance = new global::Motorola.Common.Communication.TetraUtility.CommConfigManager();
					}
					instance = global::Motorola.Common.Communication.TetraUtility.CommConfigManager._instance;
				}
				return instance;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x0600013A RID: 314 RVA: 0x0000AAC8 File Offset: 0x00008CC8
		public global::Motorola.Common.Communication.TetraUtility.XMLConfig<global::Motorola.Common.Communication.TetraUtility.HwIDRecord> HwIDTable
		{
			get
			{
				return this._hwIDTable;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x0600013B RID: 315 RVA: 0x0000AAD0 File Offset: 0x00008CD0
		public global::Motorola.Common.Communication.TetraUtility.XMLConfig<global::Motorola.Common.Communication.TetraUtility.FlashTypeRecord> FlashTypeConfigTable
		{
			get
			{
				return this._flashTypeConfigTable;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600013C RID: 316 RVA: 0x0000AAD8 File Offset: 0x00008CD8
		public global::Motorola.Common.Communication.TetraUtility.XMLConfig<global::Motorola.Common.Communication.TetraUtility.MemMapRecord> MemMapConfigTable
		{
			get
			{
				return this._memMapConfigTable;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600013D RID: 317 RVA: 0x0000AAE0 File Offset: 0x00008CE0
		public global::Motorola.Common.Communication.TetraUtility.XMLConfig<global::Motorola.Common.Communication.TetraUtility.FlashPackNamesRecord> FlashPackNamesTable
		{
			get
			{
				return this._flashPackNamesTable;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x0600013E RID: 318 RVA: 0x0000AAE8 File Offset: 0x00008CE8
		public global::Motorola.Common.Communication.TetraUtility.XMLConfig<global::Motorola.Common.Communication.TetraUtility.CPUTypeRecord> CpuTypeConfigTable
		{
			get
			{
				return this._cpuTypeConfigTable;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x0600013F RID: 319 RVA: 0x0000AAF0 File Offset: 0x00008CF0
		public global::Motorola.Common.Communication.TetraUtility.XMLConfig<global::Motorola.Common.Communication.TetraUtility.FDIVersionMapRecord> FdiVersionMapConfigTable
		{
			get
			{
				return this._fdiVersionMapConfigTable;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000140 RID: 320 RVA: 0x0000AAF8 File Offset: 0x00008CF8
		public global::Motorola.Common.Communication.TetraUtility.XMLConfig<global::Motorola.Common.Communication.TetraUtility.FlashstrapVersionMapRecord> FlashstrapVersionMapConfigTable
		{
			get
			{
				return this._flashstrapVersionMapConfigTable;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000141 RID: 321 RVA: 0x0000AB00 File Offset: 0x00008D00
		public global::Motorola.Common.Communication.TetraUtility.XMLConfig<global::Motorola.Common.Communication.TetraUtility.MemMapVersionMapRecord> MemMapVersionMapConfigTable
		{
			get
			{
				return this._memMapVersionMapConfigTable;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000142 RID: 322 RVA: 0x0000AB08 File Offset: 0x00008D08
		public global::Motorola.Common.Communication.TetraUtility.XMLConfig<global::Motorola.Common.Communication.TetraUtility.ModelHwIDMapRecord> ModelHwIDMapConfigTable
		{
			get
			{
				return this._modelHwIDMapConfigTable;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000143 RID: 323 RVA: 0x0000AB10 File Offset: 0x00008D10
		public global::Motorola.Common.Communication.TetraUtility.XMLConfig<global::Motorola.Common.Communication.TetraUtility.ReleaseIDTypeRecord> ReleaseIDTypeTable
		{
			get
			{
				return this._releaseIDTypeTable;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000144 RID: 324 RVA: 0x0000AB18 File Offset: 0x00008D18
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.TetraUtility.TetraRadioModelInfo> ModelInfoList
		{
			get
			{
				return this._modelInfoList;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000145 RID: 325 RVA: 0x0000AB20 File Offset: 0x00008D20
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.TetraUtility.TetraProductGroupInfo> GroupInfoList
		{
			get
			{
				return this._groupInfoList;
			}
		}

		// Token: 0x06000146 RID: 326 RVA: 0x0000AB50 File Offset: 0x00008D50
		public global::Motorola.Common.Communication.TetraUtility.TetraRadioModelInfo GetModel(int modelType)
		{
			return (from rc in this._modelInfoList
			where rc.ModelType == modelType
			select rc.Clone() as global::Motorola.Common.Communication.TetraUtility.TetraRadioModelInfo).FirstOrDefault<global::Motorola.Common.Communication.TetraUtility.TetraRadioModelInfo>();
		}

		// Token: 0x06000147 RID: 327 RVA: 0x0000ABD0 File Offset: 0x00008DD0
		public global::Motorola.Common.Communication.TetraUtility.TetraRadioModelInfo GetModel(string uniqueModelNumber)
		{
			return (from rc in this._modelInfoList
			where rc.UniqueModelNumber == uniqueModelNumber
			select rc.Clone() as global::Motorola.Common.Communication.TetraUtility.TetraRadioModelInfo).FirstOrDefault<global::Motorola.Common.Communication.TetraUtility.TetraRadioModelInfo>();
		}

		// Token: 0x06000148 RID: 328 RVA: 0x0000AC28 File Offset: 0x00008E28
		public global::Motorola.Common.Communication.TetraUtility.TetraRadioModelInfo GetModel(string modelNumber, string regionType)
		{
			string uniqueModelNumber = string.Empty;
			if (regionType != "ccc")
			{
				uniqueModelNumber = modelNumber + regionType.ToLowerInvariant();
			}
			else
			{
				uniqueModelNumber = modelNumber;
			}
			return this.GetModel(uniqueModelNumber);
		}

		// Token: 0x06000149 RID: 329 RVA: 0x0000AC88 File Offset: 0x00008E88
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.TetraUtility.TetraProductGroupInfo> GetProductLineRecordList(string productLine)
		{
			return (from rc in this._groupInfoList
			where rc.ProductLine == productLine
			select rc.Clone() as global::Motorola.Common.Communication.TetraUtility.TetraProductGroupInfo).ToList<global::Motorola.Common.Communication.TetraUtility.TetraProductGroupInfo>();
		}

		// Token: 0x0600014A RID: 330 RVA: 0x0000ACE0 File Offset: 0x00008EE0
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.TetraUtility.TetraProductGroupInfo> BuildGroupInfor(global::System.Xml.XmlDocument xDoc)
		{
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.TetraUtility.TetraProductGroupInfo> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.TetraUtility.TetraProductGroupInfo>();
			global::System.Xml.XmlElement xmlElement = xDoc.DocumentElement["Model_Group"];
			foreach (object obj in xmlElement)
			{
				global::System.Xml.XmlElement xmlElement2 = (global::System.Xml.XmlElement)obj;
				if (xmlElement2 != null)
				{
					global::Motorola.Common.Communication.TetraUtility.TetraProductGroupInfo item = new global::Motorola.Common.Communication.TetraUtility.TetraProductGroupInfo(xmlElement2);
					list.Add(item);
				}
			}
			return list;
		}

		// Token: 0x0600014B RID: 331 RVA: 0x0000AD60 File Offset: 0x00008F60
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.TetraUtility.TetraRadioModelInfo> BuildModelInfor(global::System.Xml.XmlDocument xDoc)
		{
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.TetraUtility.TetraRadioModelInfo> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.TetraUtility.TetraRadioModelInfo>();
			global::System.Xml.XmlElement xmlElement = xDoc.DocumentElement["Model_Table"];
			foreach (object obj in xmlElement)
			{
				global::System.Xml.XmlElement xmlElement2 = (global::System.Xml.XmlElement)obj;
				if (xmlElement2 != null)
				{
					global::Motorola.Common.Communication.TetraUtility.TetraRadioModelInfo item = new global::Motorola.Common.Communication.TetraUtility.TetraRadioModelInfo(xmlElement2);
					list.Add(item);
				}
			}
			return list;
		}

		// Token: 0x0600014C RID: 332 RVA: 0x0000ADE0 File Offset: 0x00008FE0
		private global::System.Xml.XmlDocument GetModelTableXmlDoc()
		{
			string fileName = global::System.IO.Path.Combine(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.ModelTableDir, "model_table.xml");
			return global::Motorola.Common.Communication.TetraUtility.CryptAndZipUtilty.LoadXmlWhenDebugOrUnmixDecompressXml(fileName);
		}

		// Token: 0x0400008D RID: 141
		private global::Motorola.Common.Communication.TetraUtility.XMLConfig<global::Motorola.Common.Communication.TetraUtility.HwIDRecord> _hwIDTable;

		// Token: 0x0400008E RID: 142
		private global::Motorola.Common.Communication.TetraUtility.XMLConfig<global::Motorola.Common.Communication.TetraUtility.FlashTypeRecord> _flashTypeConfigTable;

		// Token: 0x0400008F RID: 143
		private global::Motorola.Common.Communication.TetraUtility.XMLConfig<global::Motorola.Common.Communication.TetraUtility.MemMapRecord> _memMapConfigTable;

		// Token: 0x04000090 RID: 144
		private global::Motorola.Common.Communication.TetraUtility.XMLConfig<global::Motorola.Common.Communication.TetraUtility.FlashPackNamesRecord> _flashPackNamesTable;

		// Token: 0x04000091 RID: 145
		private global::Motorola.Common.Communication.TetraUtility.XMLConfig<global::Motorola.Common.Communication.TetraUtility.CPUTypeRecord> _cpuTypeConfigTable;

		// Token: 0x04000092 RID: 146
		private global::Motorola.Common.Communication.TetraUtility.XMLConfig<global::Motorola.Common.Communication.TetraUtility.FDIVersionMapRecord> _fdiVersionMapConfigTable;

		// Token: 0x04000093 RID: 147
		private global::Motorola.Common.Communication.TetraUtility.XMLConfig<global::Motorola.Common.Communication.TetraUtility.FlashstrapVersionMapRecord> _flashstrapVersionMapConfigTable;

		// Token: 0x04000094 RID: 148
		private global::Motorola.Common.Communication.TetraUtility.XMLConfig<global::Motorola.Common.Communication.TetraUtility.MemMapVersionMapRecord> _memMapVersionMapConfigTable;

		// Token: 0x04000095 RID: 149
		private global::Motorola.Common.Communication.TetraUtility.XMLConfig<global::Motorola.Common.Communication.TetraUtility.ModelHwIDMapRecord> _modelHwIDMapConfigTable;

		// Token: 0x04000096 RID: 150
		private global::Motorola.Common.Communication.TetraUtility.XMLConfig<global::Motorola.Common.Communication.TetraUtility.ReleaseIDTypeRecord> _releaseIDTypeTable;

		// Token: 0x04000097 RID: 151
		private static object accessControl = new object();

		// Token: 0x04000098 RID: 152
		private static global::Motorola.Common.Communication.TetraUtility.CommConfigManager _instance;

		// Token: 0x04000099 RID: 153
		private string _configDir = string.Empty;

		// Token: 0x0400009A RID: 154
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.TetraUtility.TetraRadioModelInfo> _modelInfoList;

		// Token: 0x0400009B RID: 155
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.TetraUtility.TetraProductGroupInfo> _groupInfoList;
	}
}
