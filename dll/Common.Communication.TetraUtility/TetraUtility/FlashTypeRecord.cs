using System;
using System.Xml.Serialization;

namespace Motorola.Common.Communication.TetraUtility
{
	// Token: 0x0200002E RID: 46
	[global::System.Serializable]
	public class FlashTypeRecord
	{
		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000194 RID: 404 RVA: 0x0000B40E File Offset: 0x0000960E
		// (set) Token: 0x06000195 RID: 405 RVA: 0x0000B416 File Offset: 0x00009616
		[global::System.Xml.Serialization.XmlAttribute("FlashID")]
		public uint FlashID
		{
			get
			{
				return this._flashID;
			}
			set
			{
				this._flashID = value;
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000196 RID: 406 RVA: 0x0000B41F File Offset: 0x0000961F
		// (set) Token: 0x06000197 RID: 407 RVA: 0x0000B427 File Offset: 0x00009627
		[global::System.Xml.Serialization.XmlAttribute("VenderID")]
		public uint VenderID
		{
			get
			{
				return this._venderID;
			}
			set
			{
				this._venderID = value;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000198 RID: 408 RVA: 0x0000B430 File Offset: 0x00009630
		// (set) Token: 0x06000199 RID: 409 RVA: 0x0000B438 File Offset: 0x00009638
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

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x0600019A RID: 410 RVA: 0x0000B441 File Offset: 0x00009641
		// (set) Token: 0x0600019B RID: 411 RVA: 0x0000B449 File Offset: 0x00009649
		[global::System.Xml.Serialization.XmlAttribute("BlockSize")]
		public uint BlockSize
		{
			get
			{
				return this._blockSize;
			}
			set
			{
				this._blockSize = value;
			}
		}

		// Token: 0x040000B6 RID: 182
		private uint _flashID;

		// Token: 0x040000B7 RID: 183
		private uint _venderID;

		// Token: 0x040000B8 RID: 184
		private uint _blockSize;

		// Token: 0x040000B9 RID: 185
		private uint _size;
	}
}
