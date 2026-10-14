using System;
using System.Xml.Serialization;

namespace Motorola.Common.Communication.TetraUtility
{
	// Token: 0x0200002C RID: 44
	[global::System.Serializable]
	public class FlashPackNamesRecord
	{
		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000186 RID: 390 RVA: 0x0000B356 File Offset: 0x00009556
		// (set) Token: 0x06000187 RID: 391 RVA: 0x0000B35E File Offset: 0x0000955E
		[global::System.Xml.Serialization.XmlAttribute("PackID")]
		public string PackID
		{
			get
			{
				return this._packID;
			}
			set
			{
				this._packID = value;
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000188 RID: 392 RVA: 0x0000B367 File Offset: 0x00009567
		// (set) Token: 0x06000189 RID: 393 RVA: 0x0000B36F File Offset: 0x0000956F
		[global::System.Xml.Serialization.XmlAttribute("PackName")]
		public string PackName
		{
			get
			{
				return this._packName;
			}
			set
			{
				this._packName = value;
			}
		}

		// Token: 0x040000B0 RID: 176
		private string _packID = string.Empty;

		// Token: 0x040000B1 RID: 177
		private string _packName = string.Empty;
	}
}
