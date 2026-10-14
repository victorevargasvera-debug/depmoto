using System;
using System.Globalization;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication
{
	// Token: 0x02000018 RID: 24
	[global::System.Runtime.Serialization.DataContract]
	public class RadioParams
	{
		// Token: 0x17000016 RID: 22
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x000089CE File Offset: 0x00006BCE
		// (set) Token: 0x060000F8 RID: 248 RVA: 0x000089D6 File Offset: 0x00006BD6
		internal string DefaultGatewayNetworkAttachmentValue
		{
			get
			{
				return this.m_DefaultGatewayNetworkAttachmentValue;
			}
			set
			{
				this.m_DefaultGatewayNetworkAttachmentValue = value;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x000089DF File Offset: 0x00006BDF
		// (set) Token: 0x060000FA RID: 250 RVA: 0x000089E7 File Offset: 0x00006BE7
		internal string SerialNumber
		{
			get
			{
				return this.m_SerialNumber;
			}
			set
			{
				this.m_SerialNumber = value;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x060000FB RID: 251 RVA: 0x000089F0 File Offset: 0x00006BF0
		// (set) Token: 0x060000FC RID: 252 RVA: 0x000089F8 File Offset: 0x00006BF8
		internal byte[] ESerialNumber
		{
			get
			{
				return this.m_ESerialNumber;
			}
			set
			{
				this.m_ESerialNumber = value;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x060000FD RID: 253 RVA: 0x00008A01 File Offset: 0x00006C01
		// (set) Token: 0x060000FE RID: 254 RVA: 0x00008A09 File Offset: 0x00006C09
		internal string ModelNumber
		{
			get
			{
				return this.m_ModelNumber;
			}
			set
			{
				this.m_ModelNumber = value;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060000FF RID: 255 RVA: 0x00008A12 File Offset: 0x00006C12
		// (set) Token: 0x06000100 RID: 256 RVA: 0x00008A1A File Offset: 0x00006C1A
		internal global::System.Guid Uuid
		{
			get
			{
				return this.m_Uuid;
			}
			set
			{
				this.m_Uuid = value;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000101 RID: 257 RVA: 0x00008A23 File Offset: 0x00006C23
		// (set) Token: 0x06000102 RID: 258 RVA: 0x00008A2B File Offset: 0x00006C2B
		internal string BBFBundleVersion
		{
			get
			{
				return this.m_bbfBundleVersion;
			}
			set
			{
				this.m_bbfBundleVersion = value;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000103 RID: 259 RVA: 0x00008A34 File Offset: 0x00006C34
		// (set) Token: 0x06000104 RID: 260 RVA: 0x00008A3C File Offset: 0x00006C3C
		internal string HostVersion
		{
			get
			{
				return this.m_HostVersion;
			}
			set
			{
				this.m_HostVersion = value;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000105 RID: 261 RVA: 0x00008A45 File Offset: 0x00006C45
		// (set) Token: 0x06000106 RID: 262 RVA: 0x00008A4D File Offset: 0x00006C4D
		internal string DspVersion
		{
			get
			{
				return this.m_DspVersion;
			}
			set
			{
				this.m_DspVersion = value;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000107 RID: 263 RVA: 0x00008A56 File Offset: 0x00006C56
		// (set) Token: 0x06000108 RID: 264 RVA: 0x00008A5E File Offset: 0x00006C5E
		internal string PsdtVersion
		{
			get
			{
				return this.m_PsdtVersion;
			}
			set
			{
				this.m_PsdtVersion = value;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000109 RID: 265 RVA: 0x00008A67 File Offset: 0x00006C67
		// (set) Token: 0x0600010A RID: 266 RVA: 0x00008A6F File Offset: 0x00006C6F
		internal string BootAppVersion
		{
			get
			{
				return this.m_BootAppVersion;
			}
			set
			{
				this.m_BootAppVersion = value;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600010B RID: 267 RVA: 0x00008A78 File Offset: 0x00006C78
		// (set) Token: 0x0600010C RID: 268 RVA: 0x00008A80 File Offset: 0x00006C80
		internal string TuneVersion
		{
			get
			{
				return this.m_TuneVersion;
			}
			set
			{
				this.m_TuneVersion = value;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600010D RID: 269 RVA: 0x00008A89 File Offset: 0x00006C89
		// (set) Token: 0x0600010E RID: 270 RVA: 0x00008A91 File Offset: 0x00006C91
		public string CodeplugVersion
		{
			get
			{
				return this.m_CodeplugVersion;
			}
			internal set
			{
				this.m_CodeplugVersion = value;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600010F RID: 271 RVA: 0x00008A9A File Offset: 0x00006C9A
		// (set) Token: 0x06000110 RID: 272 RVA: 0x00008AA2 File Offset: 0x00006CA2
		internal string OptBoardName
		{
			get
			{
				return this.m_OptBrdName;
			}
			set
			{
				this.m_OptBrdName = value;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000111 RID: 273 RVA: 0x00008AAB File Offset: 0x00006CAB
		// (set) Token: 0x06000112 RID: 274 RVA: 0x00008AB3 File Offset: 0x00006CB3
		internal string OptBrdHardwareType
		{
			get
			{
				return this.m_OptBrdHwType;
			}
			set
			{
				this.m_OptBrdHwType = value;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000113 RID: 275 RVA: 0x00008ABC File Offset: 0x00006CBC
		// (set) Token: 0x06000114 RID: 276 RVA: 0x00008AC4 File Offset: 0x00006CC4
		internal string OptBrdHwHostVersion
		{
			get
			{
				return this.m_OptBrdHwHostVersion;
			}
			set
			{
				this.m_OptBrdHwHostVersion = value;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000115 RID: 277 RVA: 0x00008ACD File Offset: 0x00006CCD
		// (set) Token: 0x06000116 RID: 278 RVA: 0x00008AD5 File Offset: 0x00006CD5
		internal string OptBrdFlashImageVersion
		{
			get
			{
				return this.m_OptBrdFlashImageVersion;
			}
			set
			{
				this.m_OptBrdFlashImageVersion = value;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000117 RID: 279 RVA: 0x00008ADE File Offset: 0x00006CDE
		// (set) Token: 0x06000118 RID: 280 RVA: 0x00008AE6 File Offset: 0x00006CE6
		internal string OptBrdFlashImageType
		{
			get
			{
				return this.m_OptBrdFlashImageType;
			}
			set
			{
				this.m_OptBrdFlashImageType = value;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000119 RID: 281 RVA: 0x00008AEF File Offset: 0x00006CEF
		// (set) Token: 0x0600011A RID: 282 RVA: 0x00008AF7 File Offset: 0x00006CF7
		internal bool OptBrdHwNotPresentFlag
		{
			get
			{
				return this.m_OptBrdHwNotPresentFlag;
			}
			set
			{
				this.m_OptBrdHwNotPresentFlag = value;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600011B RID: 283 RVA: 0x00008B00 File Offset: 0x00006D00
		// (set) Token: 0x0600011C RID: 284 RVA: 0x00008B08 File Offset: 0x00006D08
		internal string ConBrdHardwareType
		{
			get
			{
				return this.m_ConBrdHwType;
			}
			set
			{
				this.m_ConBrdHwType = value;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600011D RID: 285 RVA: 0x00008B11 File Offset: 0x00006D11
		// (set) Token: 0x0600011E RID: 286 RVA: 0x00008B19 File Offset: 0x00006D19
		internal string ConBrdHwHostVersion
		{
			get
			{
				return this.m_ConBrdHwHostVersion;
			}
			set
			{
				this.m_ConBrdHwHostVersion = value;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600011F RID: 287 RVA: 0x00008B22 File Offset: 0x00006D22
		// (set) Token: 0x06000120 RID: 288 RVA: 0x00008B2A File Offset: 0x00006D2A
		internal string MaceFlashVersion
		{
			get
			{
				return this.m_MaceFlashVersion;
			}
			set
			{
				this.m_MaceFlashVersion = value;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000121 RID: 289 RVA: 0x00008B33 File Offset: 0x00006D33
		// (set) Token: 0x06000122 RID: 290 RVA: 0x00008B3B File Offset: 0x00006D3B
		internal string MaceHardwareType
		{
			get
			{
				return this.m_MaceHardwareType;
			}
			set
			{
				this.m_MaceHardwareType = value;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000123 RID: 291 RVA: 0x00008B44 File Offset: 0x00006D44
		// (set) Token: 0x06000124 RID: 292 RVA: 0x00008B4C File Offset: 0x00006D4C
		internal string MaceHardwareVersion
		{
			get
			{
				return this.m_MaceHardwareVersion;
			}
			set
			{
				this.m_MaceHardwareVersion = value;
			}
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00008B58 File Offset: 0x00006D58
		public override string ToString()
		{
			return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "RadioParams(SerialNumber:{0}, ModelNumber:{1}, UUID:{2}, HostVersion:{3}, DspVersion:{4}, CodeplugVersion:0x{5})", new object[]
			{
				this.SerialNumber,
				this.ModelNumber,
				this.Uuid,
				this.HostVersion,
				this.DspVersion,
				this.CodeplugVersion
			});
		}

		// Token: 0x04000083 RID: 131
		[global::System.Runtime.Serialization.DataMember]
		private string m_SerialNumber;

		// Token: 0x04000084 RID: 132
		[global::System.Runtime.Serialization.DataMember]
		private byte[] m_ESerialNumber;

		// Token: 0x04000085 RID: 133
		[global::System.Runtime.Serialization.DataMember]
		private string m_ModelNumber;

		// Token: 0x04000086 RID: 134
		[global::System.Runtime.Serialization.DataMember]
		private global::System.Guid m_Uuid;

		// Token: 0x04000087 RID: 135
		[global::System.Runtime.Serialization.DataMember]
		private string m_bbfBundleVersion;

		// Token: 0x04000088 RID: 136
		[global::System.Runtime.Serialization.DataMember]
		private string m_HostVersion;

		// Token: 0x04000089 RID: 137
		[global::System.Runtime.Serialization.DataMember]
		private string m_DspVersion;

		// Token: 0x0400008A RID: 138
		[global::System.Runtime.Serialization.DataMember]
		private string m_CodeplugVersion;

		// Token: 0x0400008B RID: 139
		[global::System.Runtime.Serialization.DataMember]
		private string m_PsdtVersion;

		// Token: 0x0400008C RID: 140
		[global::System.Runtime.Serialization.DataMember]
		private string m_BootAppVersion;

		// Token: 0x0400008D RID: 141
		[global::System.Runtime.Serialization.DataMember]
		private string m_TuneVersion;

		// Token: 0x0400008E RID: 142
		[global::System.Runtime.Serialization.DataMember]
		private string m_OptBrdName;

		// Token: 0x0400008F RID: 143
		[global::System.Runtime.Serialization.DataMember]
		private string m_OptBrdHwType;

		// Token: 0x04000090 RID: 144
		[global::System.Runtime.Serialization.DataMember]
		private string m_OptBrdHwHostVersion;

		// Token: 0x04000091 RID: 145
		[global::System.Runtime.Serialization.DataMember]
		private string m_OptBrdFlashImageVersion;

		// Token: 0x04000092 RID: 146
		[global::System.Runtime.Serialization.DataMember]
		private string m_OptBrdFlashImageType;

		// Token: 0x04000093 RID: 147
		[global::System.Runtime.Serialization.DataMember]
		private bool m_OptBrdHwNotPresentFlag;

		// Token: 0x04000094 RID: 148
		[global::System.Runtime.Serialization.DataMember]
		private string m_ConBrdHwType;

		// Token: 0x04000095 RID: 149
		[global::System.Runtime.Serialization.DataMember]
		private string m_ConBrdHwHostVersion;

		// Token: 0x04000096 RID: 150
		private string m_MaceFlashVersion;

		// Token: 0x04000097 RID: 151
		private string m_MaceHardwareType;

		// Token: 0x04000098 RID: 152
		private string m_MaceHardwareVersion;

		// Token: 0x04000099 RID: 153
		private string m_DefaultGatewayNetworkAttachmentValue;
	}
}
