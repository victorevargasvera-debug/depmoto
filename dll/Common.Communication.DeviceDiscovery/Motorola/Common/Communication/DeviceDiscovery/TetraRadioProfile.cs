using System;
using System.Text;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.TetraUtility;

namespace Motorola.Common.Communication.DeviceDiscovery
{
	// Token: 0x02000023 RID: 35
	public class TetraRadioProfile : global::Motorola.Common.Communication.DeviceDiscovery.RadioProfileBase
	{
		// Token: 0x06000109 RID: 265 RVA: 0x00006D24 File Offset: 0x00004F24
		public TetraRadioProfile()
		{
			base.RadioType = global::Motorola.Common.Communication.RadioType.TETRA;
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600010A RID: 266 RVA: 0x00006D9F File Offset: 0x00004F9F
		// (set) Token: 0x0600010B RID: 267 RVA: 0x00006DA7 File Offset: 0x00004FA7
		public global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile PairNGCHProfile { get; set; }

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600010C RID: 268 RVA: 0x00006DB0 File Offset: 0x00004FB0
		// (set) Token: 0x0600010D RID: 269 RVA: 0x00006DB8 File Offset: 0x00004FB8
		public string DeviceName { get; set; }

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600010E RID: 270 RVA: 0x00006DC1 File Offset: 0x00004FC1
		// (set) Token: 0x0600010F RID: 271 RVA: 0x00006DC9 File Offset: 0x00004FC9
		public string DeviceInstanceID { get; set; }

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000110 RID: 272 RVA: 0x00006DD2 File Offset: 0x00004FD2
		// (set) Token: 0x06000111 RID: 273 RVA: 0x00006DDA File Offset: 0x00004FDA
		public uint InstanceId { get; set; }

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000112 RID: 274 RVA: 0x00006DE3 File Offset: 0x00004FE3
		// (set) Token: 0x06000113 RID: 275 RVA: 0x00006DEB File Offset: 0x00004FEB
		public string ParentDeviceInstanceID { get; set; }

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000114 RID: 276 RVA: 0x00006DF4 File Offset: 0x00004FF4
		// (set) Token: 0x06000115 RID: 277 RVA: 0x00006DFC File Offset: 0x00004FFC
		public string Path { get; set; }

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000116 RID: 278 RVA: 0x00006E05 File Offset: 0x00005005
		// (set) Token: 0x06000117 RID: 279 RVA: 0x00006E0D File Offset: 0x0000500D
		public uint DevInstanceNum { get; set; }

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000118 RID: 280 RVA: 0x00006E16 File Offset: 0x00005016
		// (set) Token: 0x06000119 RID: 281 RVA: 0x00006E1E File Offset: 0x0000501E
		public uint ParentDevInstanceNum { get; set; }

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x0600011A RID: 282 RVA: 0x00006E27 File Offset: 0x00005027
		// (set) Token: 0x0600011B RID: 283 RVA: 0x00006E2F File Offset: 0x0000502F
		public global::Motorola.Common.Communication.CommonUtil.ActiveTransRadioType PairedActiveRadioType { get; set; }

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x0600011C RID: 284 RVA: 0x00006E38 File Offset: 0x00005038
		// (set) Token: 0x0600011D RID: 285 RVA: 0x00006E40 File Offset: 0x00005040
		public override byte[] RadioId
		{
			get
			{
				return this._radioId;
			}
			set
			{
				this._radioId = value;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x0600011E RID: 286 RVA: 0x00006E4C File Offset: 0x0000504C
		public override string RadioIdString
		{
			get
			{
				string result = string.Empty;
				if (this.RadioId != null)
				{
					result = global::System.Text.Encoding.ASCII.GetString(this.RadioId);
				}
				return result;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x0600011F RID: 287 RVA: 0x00006E79 File Offset: 0x00005079
		// (set) Token: 0x06000120 RID: 288 RVA: 0x00006E81 File Offset: 0x00005081
		public uint cpAddress
		{
			get
			{
				return this._cpAddress;
			}
			set
			{
				this._cpAddress = value;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000121 RID: 289 RVA: 0x00006E8A File Offset: 0x0000508A
		// (set) Token: 0x06000122 RID: 290 RVA: 0x00006E92 File Offset: 0x00005092
		public uint cpSize
		{
			get
			{
				return this._cpSize;
			}
			set
			{
				this._cpSize = value;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000123 RID: 291 RVA: 0x00006E9B File Offset: 0x0000509B
		// (set) Token: 0x06000124 RID: 292 RVA: 0x00006EA3 File Offset: 0x000050A3
		public uint blockSize
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

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000125 RID: 293 RVA: 0x00006EAC File Offset: 0x000050AC
		// (set) Token: 0x06000126 RID: 294 RVA: 0x00006EB4 File Offset: 0x000050B4
		public uint HomeMNC
		{
			get
			{
				return this._HomeMNC;
			}
			set
			{
				this._HomeMNC = value;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000127 RID: 295 RVA: 0x00006EBD File Offset: 0x000050BD
		// (set) Token: 0x06000128 RID: 296 RVA: 0x00006EC5 File Offset: 0x000050C5
		public uint HomeMCC
		{
			get
			{
				return this._HomeMCC;
			}
			set
			{
				this._HomeMCC = value;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000129 RID: 297 RVA: 0x00006ECE File Offset: 0x000050CE
		// (set) Token: 0x0600012A RID: 298 RVA: 0x00006ED6 File Offset: 0x000050D6
		public uint HwID
		{
			get
			{
				return this._HwID;
			}
			set
			{
				this._HwID = value;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x0600012B RID: 299 RVA: 0x00006EDF File Offset: 0x000050DF
		// (set) Token: 0x0600012C RID: 300 RVA: 0x00006EE7 File Offset: 0x000050E7
		public string TEI
		{
			get
			{
				return this._TEI;
			}
			set
			{
				this._TEI = value;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x0600012D RID: 301 RVA: 0x00006EF0 File Offset: 0x000050F0
		// (set) Token: 0x0600012E RID: 302 RVA: 0x00006EF8 File Offset: 0x000050F8
		public byte[] CpuID
		{
			get
			{
				return this._CpuID;
			}
			set
			{
				this._CpuID = value;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x0600012F RID: 303 RVA: 0x00006F01 File Offset: 0x00005101
		// (set) Token: 0x06000130 RID: 304 RVA: 0x00006F09 File Offset: 0x00005109
		public uint FlashID
		{
			get
			{
				return this._FlashID;
			}
			set
			{
				this._FlashID = value;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000131 RID: 305 RVA: 0x00006F12 File Offset: 0x00005112
		// (set) Token: 0x06000132 RID: 306 RVA: 0x00006F1A File Offset: 0x0000511A
		public uint FlashVendorID
		{
			get
			{
				return this._FlashVendorID;
			}
			set
			{
				this._FlashVendorID = value;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000133 RID: 307 RVA: 0x00006F23 File Offset: 0x00005123
		// (set) Token: 0x06000134 RID: 308 RVA: 0x00006F2B File Offset: 0x0000512B
		public uint cpVersion
		{
			get
			{
				return this._cpVersion;
			}
			set
			{
				this._cpVersion = value;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000135 RID: 309 RVA: 0x00006F34 File Offset: 0x00005134
		// (set) Token: 0x06000136 RID: 310 RVA: 0x00006F3C File Offset: 0x0000513C
		public string radioVersion
		{
			get
			{
				return this._radioVersion;
			}
			set
			{
				this._radioVersion = value;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000137 RID: 311 RVA: 0x00006F45 File Offset: 0x00005145
		// (set) Token: 0x06000138 RID: 312 RVA: 0x00006F4D File Offset: 0x0000514D
		public uint modelType
		{
			get
			{
				return this._modelType;
			}
			set
			{
				this._modelType = value;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000139 RID: 313 RVA: 0x00006F56 File Offset: 0x00005156
		// (set) Token: 0x0600013A RID: 314 RVA: 0x00006F5E File Offset: 0x0000515E
		public int Issi
		{
			get
			{
				return this._Issi;
			}
			set
			{
				this._Issi = value;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x0600013B RID: 315 RVA: 0x00006F67 File Offset: 0x00005167
		// (set) Token: 0x0600013C RID: 316 RVA: 0x00006F6F File Offset: 0x0000516F
		public string CpuType { get; set; }

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x0600013D RID: 317 RVA: 0x00006F78 File Offset: 0x00005178
		// (set) Token: 0x0600013E RID: 318 RVA: 0x00006F80 File Offset: 0x00005180
		public global::Motorola.Common.Communication.TetraUtility.HwPlatform HwPlatform
		{
			get
			{
				return this._HwPlatform;
			}
			set
			{
				this._HwPlatform = value;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x0600013F RID: 319 RVA: 0x00006F89 File Offset: 0x00005189
		// (set) Token: 0x06000140 RID: 320 RVA: 0x00006F91 File Offset: 0x00005191
		public global::Motorola.Common.Communication.TetraUtility.FDIVersion FDIVx
		{
			get
			{
				return this._FDIVx;
			}
			set
			{
				this._FDIVx = value;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000141 RID: 321 RVA: 0x00006F9A File Offset: 0x0000519A
		// (set) Token: 0x06000142 RID: 322 RVA: 0x00006FA2 File Offset: 0x000051A2
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

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000143 RID: 323 RVA: 0x00006FAB File Offset: 0x000051AB
		// (set) Token: 0x06000144 RID: 324 RVA: 0x00006FB3 File Offset: 0x000051B3
		public global::Motorola.Common.Communication.TetraUtility.NGCHDeviceComponent NGCHDevicePart
		{
			get
			{
				return this._NGCHDevicePart;
			}
			set
			{
				this._NGCHDevicePart = value;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000145 RID: 325 RVA: 0x00006FBC File Offset: 0x000051BC
		// (set) Token: 0x06000146 RID: 326 RVA: 0x00006FC4 File Offset: 0x000051C4
		public global::Motorola.Common.Communication.CommonUtil.TetraRadioType TetraRadioType
		{
			get
			{
				return this._tetraRadioType;
			}
			set
			{
				this._tetraRadioType = value;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000147 RID: 327 RVA: 0x00006FCD File Offset: 0x000051CD
		// (set) Token: 0x06000148 RID: 328 RVA: 0x00006FD5 File Offset: 0x000051D5
		public uint CompositeDeviceNumber
		{
			get
			{
				return this._CompositeDeviceNumber;
			}
			set
			{
				this._CompositeDeviceNumber = value;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000149 RID: 329 RVA: 0x00006FDE File Offset: 0x000051DE
		// (set) Token: 0x0600014A RID: 330 RVA: 0x00006FE6 File Offset: 0x000051E6
		public string ModelNumber { get; set; }

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x0600014B RID: 331 RVA: 0x00006FEF File Offset: 0x000051EF
		// (set) Token: 0x0600014C RID: 332 RVA: 0x00006FF7 File Offset: 0x000051F7
		public string UniqueModelNumber { get; set; }

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x0600014D RID: 333 RVA: 0x00007000 File Offset: 0x00005200
		// (set) Token: 0x0600014E RID: 334 RVA: 0x00007008 File Offset: 0x00005208
		public string SerialNumber { get; set; }

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x0600014F RID: 335 RVA: 0x00007011 File Offset: 0x00005211
		// (set) Token: 0x06000150 RID: 336 RVA: 0x00007019 File Offset: 0x00005219
		public global::Motorola.Common.Communication.CommonUtil.FrodoDataBoxComponent FrodoDataBoxPart
		{
			get
			{
				return this._FrodoDataBoxPart;
			}
			set
			{
				this._FrodoDataBoxPart = value;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000151 RID: 337 RVA: 0x00007022 File Offset: 0x00005222
		// (set) Token: 0x06000152 RID: 338 RVA: 0x0000702A File Offset: 0x0000522A
		public string DefaultFwPath { get; set; }

		// Token: 0x06000153 RID: 339 RVA: 0x00007033 File Offset: 0x00005233
		public void SetPairProfile(global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile profile)
		{
			this.PairNGCHProfile = profile;
			profile.PairNGCHProfile = this;
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000154 RID: 340 RVA: 0x00007043 File Offset: 0x00005243
		// (set) Token: 0x06000155 RID: 341 RVA: 0x0000704B File Offset: 0x0000524B
		public string USBHubInstance
		{
			get
			{
				return this._USBHubInstance;
			}
			set
			{
				this._USBHubInstance = value;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000156 RID: 342 RVA: 0x00007054 File Offset: 0x00005254
		// (set) Token: 0x06000157 RID: 343 RVA: 0x0000705C File Offset: 0x0000525C
		public uint USBHubPortNumber
		{
			get
			{
				return this._USBHubPortNumber;
			}
			set
			{
				this._USBHubPortNumber = value;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000158 RID: 344 RVA: 0x00007065 File Offset: 0x00005265
		// (set) Token: 0x06000159 RID: 345 RVA: 0x0000706D File Offset: 0x0000526D
		public uint USBDataEPMaxTransSize
		{
			get
			{
				return this._dataEPTransMaxSize;
			}
			set
			{
				this._dataEPTransMaxSize = value;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x0600015A RID: 346 RVA: 0x00007076 File Offset: 0x00005276
		// (set) Token: 0x0600015B RID: 347 RVA: 0x0000707E File Offset: 0x0000527E
		public bool PreAttached
		{
			get
			{
				return this._preAttached;
			}
			set
			{
				this._preAttached = value;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x0600015C RID: 348 RVA: 0x00007087 File Offset: 0x00005287
		// (set) Token: 0x0600015D RID: 349 RVA: 0x0000708F File Offset: 0x0000528F
		public string TetraUID
		{
			get
			{
				return this._tetraUID;
			}
			set
			{
				this._tetraUID = value;
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x0600015E RID: 350 RVA: 0x00007098 File Offset: 0x00005298
		// (set) Token: 0x0600015F RID: 351 RVA: 0x000070A0 File Offset: 0x000052A0
		public bool HardwareIdIsValid
		{
			get
			{
				return this._hwIdIsValid;
			}
			set
			{
				this._hwIdIsValid = value;
			}
		}

		// Token: 0x06000160 RID: 352 RVA: 0x000070AC File Offset: 0x000052AC
		private string ConvertByteArray2HexString(byte[] byteArr)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			foreach (byte b in byteArr)
			{
				stringBuilder.AppendFormat("{0:X2}", b);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0400009D RID: 157
		private uint _cpAddress;

		// Token: 0x0400009E RID: 158
		private uint _cpSize;

		// Token: 0x0400009F RID: 159
		private uint _blockSize;

		// Token: 0x040000A0 RID: 160
		private uint _HomeMNC;

		// Token: 0x040000A1 RID: 161
		private uint _HomeMCC;

		// Token: 0x040000A2 RID: 162
		private uint _HwID;

		// Token: 0x040000A3 RID: 163
		private string _TEI = string.Empty;

		// Token: 0x040000A4 RID: 164
		private byte[] _CpuID;

		// Token: 0x040000A5 RID: 165
		private uint _FlashID;

		// Token: 0x040000A6 RID: 166
		private uint _FlashVendorID;

		// Token: 0x040000A7 RID: 167
		private uint _cpVersion;

		// Token: 0x040000A8 RID: 168
		private string _radioVersion = string.Empty;

		// Token: 0x040000A9 RID: 169
		private uint _modelType;

		// Token: 0x040000AA RID: 170
		private int _Issi = -1;

		// Token: 0x040000AB RID: 171
		private global::Motorola.Common.Communication.CommonUtil.FrodoDataBoxComponent _FrodoDataBoxPart = global::Motorola.Common.Communication.CommonUtil.FrodoDataBoxComponent.UnKnown;

		// Token: 0x040000AC RID: 172
		private global::Motorola.Common.Communication.TetraUtility.HwPlatform _HwPlatform = global::Motorola.Common.Communication.TetraUtility.HwPlatform.LEGACY;

		// Token: 0x040000AD RID: 173
		private global::Motorola.Common.Communication.TetraUtility.FDIVersion _FDIVx = global::Motorola.Common.Communication.TetraUtility.FDIVersion.V5x;

		// Token: 0x040000AE RID: 174
		private global::Motorola.Common.Communication.TetraUtility.ByteOrder _byteOrder = global::Motorola.Common.Communication.TetraUtility.ByteOrder.UnInitialized;

		// Token: 0x040000AF RID: 175
		private global::Motorola.Common.Communication.TetraUtility.NGCHDeviceComponent _NGCHDevicePart = global::Motorola.Common.Communication.TetraUtility.NGCHDeviceComponent.UnKnown;

		// Token: 0x040000B0 RID: 176
		private global::Motorola.Common.Communication.CommonUtil.TetraRadioType _tetraRadioType;

		// Token: 0x040000B1 RID: 177
		private uint _CompositeDeviceNumber;

		// Token: 0x040000B2 RID: 178
		private string _USBHubInstance = string.Empty;

		// Token: 0x040000B3 RID: 179
		private uint _USBHubPortNumber;

		// Token: 0x040000B4 RID: 180
		private uint _dataEPTransMaxSize;

		// Token: 0x040000B5 RID: 181
		private string _defaultFwPaht = string.Empty;

		// Token: 0x040000B6 RID: 182
		private bool _preAttached;

		// Token: 0x040000B7 RID: 183
		private string _tetraUID = string.Empty;

		// Token: 0x040000B8 RID: 184
		private byte[] _radioId;

		// Token: 0x040000B9 RID: 185
		private bool _hwIdIsValid;
	}
}
