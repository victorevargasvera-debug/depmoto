using System;
using System.Xml.Serialization;

namespace Motorola.Common.Communication.TetraUtility
{
	// Token: 0x02000031 RID: 49
	[global::System.Serializable]
	public class MemMapUnit
	{
		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060001AB RID: 427 RVA: 0x0000B4DB File Offset: 0x000096DB
		// (set) Token: 0x060001AC RID: 428 RVA: 0x0000B4E3 File Offset: 0x000096E3
		[global::System.Xml.Serialization.XmlAttribute("Address")]
		public uint Address
		{
			get
			{
				return this._address;
			}
			set
			{
				this._address = value;
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060001AD RID: 429 RVA: 0x0000B4EC File Offset: 0x000096EC
		// (set) Token: 0x060001AE RID: 430 RVA: 0x0000B4F4 File Offset: 0x000096F4
		[global::System.Xml.Serialization.XmlAttribute("Size")]
		public uint Size
		{
			get
			{
				return this._size;
			}
			set
			{
				this._size = value;
			}
		}

		// Token: 0x040000C0 RID: 192
		private uint _address;

		// Token: 0x040000C1 RID: 193
		private uint _size;
	}
}
