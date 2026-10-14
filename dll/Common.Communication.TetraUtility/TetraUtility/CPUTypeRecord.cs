using System;
using System.Xml.Serialization;

namespace Motorola.Common.Communication.TetraUtility
{
	// Token: 0x02000029 RID: 41
	[global::System.Serializable]
	public class CPUTypeRecord
	{
		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000151 RID: 337 RVA: 0x0000AE0F File Offset: 0x0000900F
		// (set) Token: 0x06000152 RID: 338 RVA: 0x0000AE17 File Offset: 0x00009017
		[global::System.Xml.Serialization.XmlAttribute("CPUType")]
		public global::Motorola.Common.Communication.TetraUtility.CPUType CPUType
		{
			get
			{
				return this._cpuType;
			}
			set
			{
				this._cpuType = value;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000153 RID: 339 RVA: 0x0000AE20 File Offset: 0x00009020
		// (set) Token: 0x06000154 RID: 340 RVA: 0x0000AE28 File Offset: 0x00009028
		[global::System.Xml.Serialization.XmlAttribute("ByteOrder")]
		public global::Motorola.Common.Communication.TetraUtility.ByteOrder ByteOrder
		{
			get
			{
				return this._byteOrder;
			}
			set
			{
				this._byteOrder = value;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000155 RID: 341 RVA: 0x0000AE31 File Offset: 0x00009031
		// (set) Token: 0x06000156 RID: 342 RVA: 0x0000AE39 File Offset: 0x00009039
		[global::System.Xml.Serialization.XmlAttribute("StartAddress")]
		public uint StartAddress
		{
			get
			{
				return this._startAddress;
			}
			set
			{
				this._startAddress = value;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000157 RID: 343 RVA: 0x0000AE42 File Offset: 0x00009042
		// (set) Token: 0x06000158 RID: 344 RVA: 0x0000AE4A File Offset: 0x0000904A
		[global::System.Xml.Serialization.XmlAttribute("PlatformList")]
		public string PlatformList
		{
			get
			{
				return this._platformList;
			}
			set
			{
				this._platformList = value;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000159 RID: 345 RVA: 0x0000AE53 File Offset: 0x00009053
		// (set) Token: 0x0600015A RID: 346 RVA: 0x0000AE5B File Offset: 0x0000905B
		[global::System.Xml.Serialization.XmlAttribute("ReleaseIDPtr")]
		public uint ReleaseIDPtr
		{
			get
			{
				return this._releaseIDPtr;
			}
			set
			{
				this._releaseIDPtr = value;
			}
		}

		// Token: 0x040000A5 RID: 165
		private global::Motorola.Common.Communication.TetraUtility.CPUType _cpuType;

		// Token: 0x040000A6 RID: 166
		private global::Motorola.Common.Communication.TetraUtility.ByteOrder _byteOrder = global::Motorola.Common.Communication.TetraUtility.ByteOrder.BigEndian;

		// Token: 0x040000A7 RID: 167
		private uint _startAddress;

		// Token: 0x040000A8 RID: 168
		private string _platformList = string.Empty;

		// Token: 0x040000A9 RID: 169
		private uint _releaseIDPtr;
	}
}
