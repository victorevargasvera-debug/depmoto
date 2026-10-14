using System;
using Motorola.Common.Communication.CommonUtil;

namespace Motorola.Common.Communication.DeviceDiscovery
{
	// Token: 0x02000019 RID: 25
	public abstract class RadioProfileBase : global::Motorola.Common.Communication.IRadioProfile
	{
		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000098 RID: 152 RVA: 0x000057DD File Offset: 0x000039DD
		// (set) Token: 0x06000099 RID: 153 RVA: 0x000057E5 File Offset: 0x000039E5
		public string PhysicalLocation
		{
			get
			{
				return this._physicalLocation;
			}
			set
			{
				this._physicalLocation = value;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600009A RID: 154 RVA: 0x000057EE File Offset: 0x000039EE
		// (set) Token: 0x0600009B RID: 155 RVA: 0x000057F6 File Offset: 0x000039F6
		public global::Motorola.Common.Communication.CommonUtil.DeviceMode DeviceMode
		{
			get
			{
				return this._deviceMode;
			}
			set
			{
				this._deviceMode = value;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600009C RID: 156 RVA: 0x000057FF File Offset: 0x000039FF
		// (set) Token: 0x0600009D RID: 157 RVA: 0x00005807 File Offset: 0x00003A07
		public string PID
		{
			get
			{
				return this._PID;
			}
			set
			{
				this._PID = value;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600009E RID: 158 RVA: 0x00005810 File Offset: 0x00003A10
		// (set) Token: 0x0600009F RID: 159 RVA: 0x00005818 File Offset: 0x00003A18
		public string VID
		{
			get
			{
				return this._VID;
			}
			set
			{
				this._VID = value;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x00005821 File Offset: 0x00003A21
		// (set) Token: 0x060000A1 RID: 161 RVA: 0x00005829 File Offset: 0x00003A29
		public string UniqueLocation
		{
			get
			{
				return this._uniqueLocation;
			}
			set
			{
				this._uniqueLocation = value;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x00005832 File Offset: 0x00003A32
		// (set) Token: 0x060000A3 RID: 163 RVA: 0x0000583A File Offset: 0x00003A3A
		public global::Motorola.Common.Communication.RadioType RadioType
		{
			get
			{
				return this._radioType;
			}
			set
			{
				this._radioType = value;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x00005843 File Offset: 0x00003A43
		// (set) Token: 0x060000A5 RID: 165 RVA: 0x0000584A File Offset: 0x00003A4A
		public virtual byte[] RadioId
		{
			get
			{
				throw new global::System.NotSupportedException();
			}
			set
			{
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x00005851 File Offset: 0x00003A51
		public virtual string RadioIdString
		{
			get
			{
				throw new global::System.NotSupportedException();
			}
		}

		// Token: 0x04000066 RID: 102
		private string _physicalLocation;

		// Token: 0x04000067 RID: 103
		private global::Motorola.Common.Communication.CommonUtil.DeviceMode _deviceMode = global::Motorola.Common.Communication.CommonUtil.DeviceMode.UNKNOWN;

		// Token: 0x04000068 RID: 104
		private string _PID;

		// Token: 0x04000069 RID: 105
		private string _VID;

		// Token: 0x0400006A RID: 106
		private string _uniqueLocation;

		// Token: 0x0400006B RID: 107
		private global::Motorola.Common.Communication.RadioType _radioType;
	}
}
