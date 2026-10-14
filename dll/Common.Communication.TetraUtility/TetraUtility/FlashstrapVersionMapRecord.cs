using System;
using System.Xml.Serialization;

namespace Motorola.Common.Communication.TetraUtility
{
	// Token: 0x0200002D RID: 45
	[global::System.Serializable]
	public class FlashstrapVersionMapRecord
	{
		// Token: 0x17000066 RID: 102
		// (get) Token: 0x0600018B RID: 395 RVA: 0x0000B396 File Offset: 0x00009596
		// (set) Token: 0x0600018C RID: 396 RVA: 0x0000B39E File Offset: 0x0000959E
		[global::System.Xml.Serialization.XmlAttribute("ModelNumber")]
		public string ModelNumber
		{
			get
			{
				return this._modelNumber;
			}
			set
			{
				this._modelNumber = value;
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x0600018D RID: 397 RVA: 0x0000B3A7 File Offset: 0x000095A7
		// (set) Token: 0x0600018E RID: 398 RVA: 0x0000B3AF File Offset: 0x000095AF
		[global::System.Xml.Serialization.XmlAttribute("CPRange")]
		public string CPRange
		{
			get
			{
				return this._cpRange;
			}
			set
			{
				this._cpRange = value;
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x0600018F RID: 399 RVA: 0x0000B3B8 File Offset: 0x000095B8
		// (set) Token: 0x06000190 RID: 400 RVA: 0x0000B3C0 File Offset: 0x000095C0
		[global::System.Xml.Serialization.XmlAttribute("FlashstrapName")]
		public string FlashstrapName
		{
			get
			{
				return this._flashstrapName;
			}
			set
			{
				this._flashstrapName = value;
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000191 RID: 401 RVA: 0x0000B3C9 File Offset: 0x000095C9
		// (set) Token: 0x06000192 RID: 402 RVA: 0x0000B3D1 File Offset: 0x000095D1
		[global::System.Xml.Serialization.XmlAttribute("HardwareId")]
		public string HardwareId
		{
			get
			{
				return this._hardwareId;
			}
			set
			{
				this._hardwareId = value;
			}
		}

		// Token: 0x040000B2 RID: 178
		private string _modelNumber = string.Empty;

		// Token: 0x040000B3 RID: 179
		private string _cpRange = string.Empty;

		// Token: 0x040000B4 RID: 180
		private string _flashstrapName = string.Empty;

		// Token: 0x040000B5 RID: 181
		private string _hardwareId = string.Empty;
	}
}
