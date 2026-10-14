using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Motorola.Common.Communication.Pba
{
	// Token: 0x02000013 RID: 19
	[global::System.Serializable]
	public class FileItem
	{
		// Token: 0x06000086 RID: 134 RVA: 0x0000285C File Offset: 0x00000A5C
		public FileItem()
		{
			this.PartionID = 0;
			this.FilePath = string.Empty;
			this.FileSize = 0;
			this.FileContent = null;
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00002884 File Offset: 0x00000A84
		public FileItem(ushort partionID, string filePath, int fileSize, byte[] fileContent, string uri = null, string name = null)
		{
			this.PartionID = partionID;
			this.FilePath = filePath;
			this.FileSize = fileSize;
			this.FileContent = fileContent;
			this.URI = uri;
			this.Name = name;
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000088 RID: 136 RVA: 0x000028B9 File Offset: 0x00000AB9
		// (set) Token: 0x06000089 RID: 137 RVA: 0x000028C1 File Offset: 0x00000AC1
		[global::System.Xml.Serialization.XmlAttribute("PartionID")]
		public ushort PartionID { get; set; }

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600008A RID: 138 RVA: 0x000028CA File Offset: 0x00000ACA
		// (set) Token: 0x0600008B RID: 139 RVA: 0x000028D2 File Offset: 0x00000AD2
		[global::System.Xml.Serialization.XmlAttribute("SizeInBytes")]
		public int FileSize { get; set; }

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600008C RID: 140 RVA: 0x000028DB File Offset: 0x00000ADB
		// (set) Token: 0x0600008D RID: 141 RVA: 0x000028E3 File Offset: 0x00000AE3
		[global::System.Xml.Serialization.XmlAttribute("Path")]
		public string FilePath { get; set; }

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600008E RID: 142 RVA: 0x000028EC File Offset: 0x00000AEC
		// (set) Token: 0x0600008F RID: 143 RVA: 0x000028F4 File Offset: 0x00000AF4
		[global::System.Xml.Serialization.XmlElement("Content")]
		public byte[] FileContent { get; set; }

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000090 RID: 144 RVA: 0x000028FD File Offset: 0x00000AFD
		// (set) Token: 0x06000091 RID: 145 RVA: 0x00002905 File Offset: 0x00000B05
		[global::System.Xml.Serialization.XmlAttribute("Name")]
		public string Name { get; set; }

		// Token: 0x0400006F RID: 111
		[global::System.Xml.Serialization.XmlAttribute("URI")]
		[global::System.Runtime.Serialization.OptionalField]
		public string URI;
	}
}
