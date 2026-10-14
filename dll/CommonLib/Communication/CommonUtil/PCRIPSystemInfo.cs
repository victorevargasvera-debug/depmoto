using System;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x0200003A RID: 58
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class PCRIPSystemInfo
	{
		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060001E0 RID: 480 RVA: 0x0000676D File Offset: 0x0000496D
		// (set) Token: 0x060001E1 RID: 481 RVA: 0x00006775 File Offset: 0x00004975
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.Common.Communication.CommonUtil.PCRIPSystemType SystemType { get; set; }

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060001E2 RID: 482 RVA: 0x0000677E File Offset: 0x0000497E
		// (set) Token: 0x060001E3 RID: 483 RVA: 0x00006786 File Offset: 0x00004986
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.Common.Communication.CommonUtil.RPLocalType LocalType { get; set; }

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060001E4 RID: 484 RVA: 0x0000678F File Offset: 0x0000498F
		// (set) Token: 0x060001E5 RID: 485 RVA: 0x00006797 File Offset: 0x00004997
		[global::System.Runtime.Serialization.DataMember]
		public byte[] AuthenticationKey { get; set; }

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060001E6 RID: 486 RVA: 0x000067A0 File Offset: 0x000049A0
		// (set) Token: 0x060001E7 RID: 487 RVA: 0x000067A8 File Offset: 0x000049A8
		[global::System.Runtime.Serialization.DataMember]
		public uint LocalID { get; set; }

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060001E8 RID: 488 RVA: 0x000067B1 File Offset: 0x000049B1
		// (set) Token: 0x060001E9 RID: 489 RVA: 0x000067B9 File Offset: 0x000049B9
		[global::System.Runtime.Serialization.DataMember]
		public uint LocalUDPPort { get; set; }

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060001EA RID: 490 RVA: 0x000067C2 File Offset: 0x000049C2
		// (set) Token: 0x060001EB RID: 491 RVA: 0x000067CA File Offset: 0x000049CA
		[global::System.Runtime.Serialization.DataMember]
		public uint LocalTCPPort { get; set; }

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060001EC RID: 492 RVA: 0x000067D3 File Offset: 0x000049D3
		// (set) Token: 0x060001ED RID: 493 RVA: 0x000067DB File Offset: 0x000049DB
		[global::System.Runtime.Serialization.DataMember]
		public uint MinTCPPort { get; set; }

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060001EE RID: 494 RVA: 0x000067E4 File Offset: 0x000049E4
		// (set) Token: 0x060001EF RID: 495 RVA: 0x000067EC File Offset: 0x000049EC
		[global::System.Runtime.Serialization.DataMember]
		public uint MaxTCPPort { get; set; }

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060001F0 RID: 496 RVA: 0x000067F5 File Offset: 0x000049F5
		// (set) Token: 0x060001F1 RID: 497 RVA: 0x000067FD File Offset: 0x000049FD
		[global::System.Runtime.Serialization.DataMember]
		public string RemoteHostNameOrAddress { get; set; }

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060001F2 RID: 498 RVA: 0x00006806 File Offset: 0x00004A06
		// (set) Token: 0x060001F3 RID: 499 RVA: 0x0000680E File Offset: 0x00004A0E
		[global::System.Runtime.Serialization.DataMember]
		public uint RemotePort { get; set; }

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060001F4 RID: 500 RVA: 0x00006817 File Offset: 0x00004A17
		// (set) Token: 0x060001F5 RID: 501 RVA: 0x0000681F File Offset: 0x00004A1F
		[global::System.Runtime.Serialization.DataMember]
		public string SystemAlias { get; set; }

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060001F6 RID: 502 RVA: 0x00006828 File Offset: 0x00004A28
		// (set) Token: 0x060001F7 RID: 503 RVA: 0x00006830 File Offset: 0x00004A30
		[global::System.Runtime.Serialization.DataMember]
		public uint DeviceVersion { get; set; }

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060001F8 RID: 504 RVA: 0x00006839 File Offset: 0x00004A39
		// (set) Token: 0x060001F9 RID: 505 RVA: 0x00006841 File Offset: 0x00004A41
		[global::System.Runtime.Serialization.DataMember]
		public uint NetworkID { get; set; }

		// Token: 0x060001FA RID: 506 RVA: 0x0000684A File Offset: 0x00004A4A
		public PCRIPSystemInfo()
		{
			this.SystemType = global::Motorola.Common.Communication.CommonUtil.PCRIPSystemType.DMR;
		}
	}
}
