using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Motorola.Common.Communication.Pba
{
	// Token: 0x0200000A RID: 10
	[global::System.Serializable]
	public class FileSet
	{
		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000026 RID: 38 RVA: 0x00002333 File Offset: 0x00000533
		// (set) Token: 0x06000027 RID: 39 RVA: 0x0000233B File Offset: 0x0000053B
		[global::System.Xml.Serialization.XmlAttribute("Name")]
		public string Name { get; set; }

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000028 RID: 40 RVA: 0x00002344 File Offset: 0x00000544
		// (set) Token: 0x06000029 RID: 41 RVA: 0x0000234C File Offset: 0x0000054C
		[global::System.Xml.Serialization.XmlElement("FileList")]
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem> FileItemsList { get; set; }

		// Token: 0x0600002A RID: 42 RVA: 0x00002355 File Offset: 0x00000555
		public FileSet()
		{
			this.FileItemsList = null;
			this.Name = null;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x0000236B File Offset: 0x0000056B
		public FileSet(string name)
		{
			this.FileItemsList = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem>();
			this.Name = name;
		}
	}
}
