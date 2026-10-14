using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000041 RID: 65
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class TetraDeviceInfo : global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo, global::System.ICloneable
	{
		// Token: 0x0600020E RID: 526 RVA: 0x00006AD8 File Offset: 0x00004CD8
		public TetraDeviceInfo()
		{
			base.ConnectionInfo = new global::Motorola.Common.Communication.CommonUtil.ConnectionInfo();
			base.ConnectionInfo.AuthInfo = new global::Motorola.Common.Communication.CommonUtil.AuthenticationInfo();
			this.HwConfigList = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.HwConfigSection>();
			this.HwID = 0U;
			this.CpuID = string.Empty;
			this.TEI = string.Empty;
			base.ModelNumber = string.Empty;
			this.Issi = -1;
			this.HomeMCC = -1;
			this.HomeMCC = -1;
			base.CodeplugVersion = string.Empty;
			base.SoftwareVersion = string.Empty;
			this.PartionHealthState = -1;
			this.RpVerInfo = null;
			base.UseCompress = true;
			base.Family = global::Motorola.Common.Communication.CommonUtil.ProductFamily.TetraRadio;
			this.UsbHubPortNumber = 0U;
			this.UsbHubInstance = string.Empty;
			this.BMPRadioFPSlots = new uint[this.FLASHPACK_SLOTS_NUMBER];
			this.BMPRadioFPInfo = null;
			this.PreAttached = false;
			this.ARP = null;
			this.ForceErase = false;
			this.IsCodeplugAuthenticationEnabled = false;
			this.BatteryLevel = 0;
			this.PowerStatus = global::Motorola.Common.Communication.CommonUtil.PowerSupplyStatus.UN_DEFINED;
			this.HardwareIdIsValid = false;
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x0600020F RID: 527 RVA: 0x00006BF5 File Offset: 0x00004DF5
		// (set) Token: 0x06000210 RID: 528 RVA: 0x00006BFD File Offset: 0x00004DFD
		[global::System.Runtime.Serialization.DataMember]
		public string Location { get; set; }

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000211 RID: 529 RVA: 0x00006C06 File Offset: 0x00004E06
		// (set) Token: 0x06000212 RID: 530 RVA: 0x00006C0E File Offset: 0x00004E0E
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.Common.Communication.CommonUtil.DeviceMode DeviceMode { get; set; }

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000213 RID: 531 RVA: 0x00006C17 File Offset: 0x00004E17
		// (set) Token: 0x06000214 RID: 532 RVA: 0x00006C1F File Offset: 0x00004E1F
		[global::System.Runtime.Serialization.DataMember]
		public string CpuID { get; set; }

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000215 RID: 533 RVA: 0x00006C28 File Offset: 0x00004E28
		// (set) Token: 0x06000216 RID: 534 RVA: 0x00006C30 File Offset: 0x00004E30
		[global::System.Runtime.Serialization.DataMember]
		public string TEI { get; set; }

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x06000217 RID: 535 RVA: 0x00006C39 File Offset: 0x00004E39
		// (set) Token: 0x06000218 RID: 536 RVA: 0x00006C41 File Offset: 0x00004E41
		[global::System.Runtime.Serialization.DataMember]
		public uint HwID { get; set; }

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000219 RID: 537 RVA: 0x00006C4A File Offset: 0x00004E4A
		// (set) Token: 0x0600021A RID: 538 RVA: 0x00006C52 File Offset: 0x00004E52
		[global::System.Runtime.Serialization.DataMember]
		public int HomeMCC { get; set; }

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x0600021B RID: 539 RVA: 0x00006C5B File Offset: 0x00004E5B
		// (set) Token: 0x0600021C RID: 540 RVA: 0x00006C63 File Offset: 0x00004E63
		[global::System.Runtime.Serialization.DataMember]
		public int HomeMNC { get; set; }

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x0600021D RID: 541 RVA: 0x00006C6C File Offset: 0x00004E6C
		// (set) Token: 0x0600021E RID: 542 RVA: 0x00006C74 File Offset: 0x00004E74
		[global::System.Runtime.Serialization.DataMember]
		public string CpuType { get; set; }

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x0600021F RID: 543 RVA: 0x00006C7D File Offset: 0x00004E7D
		// (set) Token: 0x06000220 RID: 544 RVA: 0x00006C85 File Offset: 0x00004E85
		[global::System.Runtime.Serialization.DataMember]
		public int PartionHealthState { get; set; }

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x06000221 RID: 545 RVA: 0x00006C8E File Offset: 0x00004E8E
		// (set) Token: 0x06000222 RID: 546 RVA: 0x00006C96 File Offset: 0x00004E96
		[global::System.Runtime.Serialization.DataMember]
		public string CompositeDeviceLocation { get; set; }

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x06000223 RID: 547 RVA: 0x00006C9F File Offset: 0x00004E9F
		// (set) Token: 0x06000224 RID: 548 RVA: 0x00006CA7 File Offset: 0x00004EA7
		[global::System.Runtime.Serialization.DataMember]
		public uint FlashID { get; set; }

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000225 RID: 549 RVA: 0x00006CB0 File Offset: 0x00004EB0
		// (set) Token: 0x06000226 RID: 550 RVA: 0x00006CB8 File Offset: 0x00004EB8
		[global::System.Runtime.Serialization.DataMember]
		public uint FlashVID { get; set; }

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x06000227 RID: 551 RVA: 0x00006CC1 File Offset: 0x00004EC1
		// (set) Token: 0x06000228 RID: 552 RVA: 0x00006CC9 File Offset: 0x00004EC9
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.Common.Communication.CommonUtil.TetraRadioType RadioType { get; set; }

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x06000229 RID: 553 RVA: 0x00006CD2 File Offset: 0x00004ED2
		// (set) Token: 0x0600022A RID: 554 RVA: 0x00006CDA File Offset: 0x00004EDA
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.HwConfigSection> HwConfigList { get; set; }

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x0600022B RID: 555 RVA: 0x00006CE3 File Offset: 0x00004EE3
		// (set) Token: 0x0600022C RID: 556 RVA: 0x00006CEB File Offset: 0x00004EEB
		[global::System.Runtime.Serialization.DataMember]
		public uint DevInstanceNum { get; set; }

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x0600022D RID: 557 RVA: 0x00006CF4 File Offset: 0x00004EF4
		// (set) Token: 0x0600022E RID: 558 RVA: 0x00006CFC File Offset: 0x00004EFC
		[global::System.Runtime.Serialization.DataMember]
		public uint ParentDevInstanceNum { get; set; }

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x0600022F RID: 559 RVA: 0x00006D05 File Offset: 0x00004F05
		// (set) Token: 0x06000230 RID: 560 RVA: 0x00006D0D File Offset: 0x00004F0D
		[global::System.Runtime.Serialization.DataMember]
		public string PID { get; set; }

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000231 RID: 561 RVA: 0x00006D16 File Offset: 0x00004F16
		// (set) Token: 0x06000232 RID: 562 RVA: 0x00006D1E File Offset: 0x00004F1E
		[global::System.Runtime.Serialization.DataMember]
		public string VID { get; set; }

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000233 RID: 563 RVA: 0x00006D27 File Offset: 0x00004F27
		// (set) Token: 0x06000234 RID: 564 RVA: 0x00006D2F File Offset: 0x00004F2F
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.Common.Communication.CommonUtil.ActiveTransRadioType ActiveTransRadioType { get; set; }

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000235 RID: 565 RVA: 0x00006D38 File Offset: 0x00004F38
		// (set) Token: 0x06000236 RID: 566 RVA: 0x00006D40 File Offset: 0x00004F40
		[global::System.Runtime.Serialization.DataMember]
		public int Issi { get; set; }

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000237 RID: 567 RVA: 0x00006D49 File Offset: 0x00004F49
		// (set) Token: 0x06000238 RID: 568 RVA: 0x00006D51 File Offset: 0x00004F51
		[global::System.Runtime.Serialization.DataMember]
		public byte[] ARP { get; set; }

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000239 RID: 569 RVA: 0x00006D5A File Offset: 0x00004F5A
		// (set) Token: 0x0600023A RID: 570 RVA: 0x00006D62 File Offset: 0x00004F62
		[global::System.Runtime.Serialization.DataMember]
		public byte[] DUP { get; set; }

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x0600023B RID: 571 RVA: 0x00006D6B File Offset: 0x00004F6B
		// (set) Token: 0x0600023C RID: 572 RVA: 0x00006D73 File Offset: 0x00004F73
		[global::System.Runtime.Serialization.DataMember]
		public bool IsCodeplugAuthenticationEnabled { get; set; }

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x0600023D RID: 573 RVA: 0x00006D7C File Offset: 0x00004F7C
		// (set) Token: 0x0600023E RID: 574 RVA: 0x00006D84 File Offset: 0x00004F84
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.Common.Communication.CommonUtil.RPVersionInfo RpVerInfo { get; set; }

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x0600023F RID: 575 RVA: 0x00006D8D File Offset: 0x00004F8D
		// (set) Token: 0x06000240 RID: 576 RVA: 0x00006D95 File Offset: 0x00004F95
		[global::System.Runtime.Serialization.DataMember]
		public uint UsbHubPortNumber { get; set; }

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000241 RID: 577 RVA: 0x00006D9E File Offset: 0x00004F9E
		// (set) Token: 0x06000242 RID: 578 RVA: 0x00006DA6 File Offset: 0x00004FA6
		[global::System.Runtime.Serialization.DataMember]
		public string UsbHubInstance { get; set; }

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000243 RID: 579 RVA: 0x00006DAF File Offset: 0x00004FAF
		// (set) Token: 0x06000244 RID: 580 RVA: 0x00006DB7 File Offset: 0x00004FB7
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.Common.Communication.CommonUtil.RadioFPInfo BMPRadioFPInfo { get; set; }

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000245 RID: 581 RVA: 0x00006DC0 File Offset: 0x00004FC0
		// (set) Token: 0x06000246 RID: 582 RVA: 0x00006DC8 File Offset: 0x00004FC8
		[global::System.Runtime.Serialization.DataMember]
		public uint[] BMPRadioFPSlots { get; set; }

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000247 RID: 583 RVA: 0x00006DD1 File Offset: 0x00004FD1
		// (set) Token: 0x06000248 RID: 584 RVA: 0x00006DD9 File Offset: 0x00004FD9
		[global::System.Runtime.Serialization.DataMember]
		public bool PreAttached { get; set; }

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000249 RID: 585 RVA: 0x00006DE2 File Offset: 0x00004FE2
		// (set) Token: 0x0600024A RID: 586 RVA: 0x00006DEA File Offset: 0x00004FEA
		[global::System.Runtime.Serialization.DataMember]
		public bool ForceErase { get; set; }

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x0600024B RID: 587 RVA: 0x00006DF3 File Offset: 0x00004FF3
		// (set) Token: 0x0600024C RID: 588 RVA: 0x00006DFB File Offset: 0x00004FFB
		[global::System.Runtime.Serialization.DataMember]
		public int BatteryLevel { get; set; }

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x0600024D RID: 589 RVA: 0x00006E04 File Offset: 0x00005004
		// (set) Token: 0x0600024E RID: 590 RVA: 0x00006E0C File Offset: 0x0000500C
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.Common.Communication.CommonUtil.PowerSupplyStatus PowerStatus { get; set; }

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x0600024F RID: 591 RVA: 0x00006E15 File Offset: 0x00005015
		// (set) Token: 0x06000250 RID: 592 RVA: 0x00006E1D File Offset: 0x0000501D
		[global::System.Runtime.Serialization.DataMember]
		public bool HardwareIdIsValid { get; set; }

		// Token: 0x06000251 RID: 593 RVA: 0x00006E28 File Offset: 0x00005028
		public object Clone()
		{
			global::Motorola.Common.Communication.CommonUtil.TetraDeviceInfo tetraDeviceInfo = base.MemberwiseClone() as global::Motorola.Common.Communication.CommonUtil.TetraDeviceInfo;
			tetraDeviceInfo.RadioID = this.RadioID;
			tetraDeviceInfo.Location = this.Location;
			tetraDeviceInfo.DeviceMode = this.DeviceMode;
			tetraDeviceInfo.CpuID = this.CpuID;
			tetraDeviceInfo.TEI = this.TEI;
			tetraDeviceInfo.HwID = this.HwID;
			tetraDeviceInfo.HomeMCC = this.HomeMCC;
			tetraDeviceInfo.HomeMNC = this.HomeMNC;
			tetraDeviceInfo.CpuType = this.CpuType;
			tetraDeviceInfo.PartionHealthState = this.PartionHealthState;
			tetraDeviceInfo.CompositeDeviceLocation = this.CompositeDeviceLocation;
			tetraDeviceInfo.FlashID = this.FlashID;
			tetraDeviceInfo.FlashVID = this.FlashVID;
			tetraDeviceInfo.RadioType = this.RadioType;
			tetraDeviceInfo.HwConfigList = this.HwConfigList;
			tetraDeviceInfo.DevInstanceNum = this.DevInstanceNum;
			tetraDeviceInfo.ParentDevInstanceNum = this.ParentDevInstanceNum;
			tetraDeviceInfo.PID = this.PID;
			tetraDeviceInfo.VID = this.VID;
			tetraDeviceInfo.ActiveTransRadioType = this.ActiveTransRadioType;
			tetraDeviceInfo.Issi = this.Issi;
			tetraDeviceInfo.RpVerInfo = this.RpVerInfo;
			tetraDeviceInfo.ConnectionInfo.ConnectionType = base.ConnectionInfo.ConnectionType;
			tetraDeviceInfo.ConnectionInfo.Location = base.ConnectionInfo.Location;
			tetraDeviceInfo.ConnectionInfo.UniqueAddress = base.ConnectionInfo.UniqueAddress;
			tetraDeviceInfo.ConnectionInfo.SessionID = base.ConnectionInfo.SessionID;
			tetraDeviceInfo.ConnectionInfo.InactivityTimeout = base.ConnectionInfo.InactivityTimeout;
			tetraDeviceInfo.ConnectionInfo.AuthInfo.AuthType = base.ConnectionInfo.AuthInfo.AuthType;
			tetraDeviceInfo.ConnectionInfo.AuthInfo.Certificate_File = base.ConnectionInfo.AuthInfo.Certificate_File;
			tetraDeviceInfo.ConnectionInfo.AuthInfo.PreSharedKey_ID = base.ConnectionInfo.AuthInfo.PreSharedKey_ID;
			tetraDeviceInfo.ConnectionInfo.AuthInfo.PreSharedKey_Material = base.ConnectionInfo.AuthInfo.PreSharedKey_Material;
			tetraDeviceInfo.ConnectionInfo.DeviceInstance = base.ConnectionInfo.DeviceInstance;
			tetraDeviceInfo.Family = base.Family;
			tetraDeviceInfo.RadioState = base.RadioState;
			tetraDeviceInfo.RadioStorage = base.RadioStorage;
			tetraDeviceInfo.RadioID = this.RadioID;
			tetraDeviceInfo.ModelNumber = base.ModelNumber;
			tetraDeviceInfo.SerialNumber = base.SerialNumber;
			tetraDeviceInfo.CodeplugVersion = base.CodeplugVersion;
			tetraDeviceInfo.SoftwareVersion = base.SoftwareVersion;
			tetraDeviceInfo.UseCompress = base.UseCompress;
			tetraDeviceInfo.UsbHubInstance = this.UsbHubInstance;
			tetraDeviceInfo.UsbHubPortNumber = this.UsbHubPortNumber;
			tetraDeviceInfo.PreAttached = this.PreAttached;
			tetraDeviceInfo.OperationId = base.OperationId;
			tetraDeviceInfo.ForceErase = this.ForceErase;
			tetraDeviceInfo.ARP = this.ARP;
			tetraDeviceInfo.DUP = this.DUP;
			tetraDeviceInfo.IsCodeplugAuthenticationEnabled = this.IsCodeplugAuthenticationEnabled;
			tetraDeviceInfo.BatteryLevel = this.BatteryLevel;
			tetraDeviceInfo.PowerStatus = this.PowerStatus;
			tetraDeviceInfo.HardwareIdIsValid = this.HardwareIdIsValid;
			return tetraDeviceInfo;
		}

		// Token: 0x040001CB RID: 459
		private string _radioID = string.Empty;

		// Token: 0x040001CC RID: 460
		private int FLASHPACK_SLOTS_NUMBER = 128;
	}
}
