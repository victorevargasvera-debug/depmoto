using System;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication
{
	// Token: 0x02000022 RID: 34
	[global::System.Runtime.Serialization.DataContract]
	public class InnerInventory
	{
		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600005A RID: 90 RVA: 0x0000306E File Offset: 0x0000126E
		// (set) Token: 0x0600005B RID: 91 RVA: 0x00003076 File Offset: 0x00001276
		[global::System.Runtime.Serialization.DataMember]
		public string serialNumber { get; set; }

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600005C RID: 92 RVA: 0x0000307F File Offset: 0x0000127F
		// (set) Token: 0x0600005D RID: 93 RVA: 0x00003087 File Offset: 0x00001287
		[global::System.Runtime.Serialization.DataMember]
		public string manufacturer { get; set; }

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600005E RID: 94 RVA: 0x00003090 File Offset: 0x00001290
		// (set) Token: 0x0600005F RID: 95 RVA: 0x00003098 File Offset: 0x00001298
		[global::System.Runtime.Serialization.DataMember]
		public string model { get; set; }

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000060 RID: 96 RVA: 0x000030A1 File Offset: 0x000012A1
		// (set) Token: 0x06000061 RID: 97 RVA: 0x000030A9 File Offset: 0x000012A9
		[global::System.Runtime.Serialization.DataMember]
		public string imei { get; set; }

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000062 RID: 98 RVA: 0x000030B2 File Offset: 0x000012B2
		// (set) Token: 0x06000063 RID: 99 RVA: 0x000030BA File Offset: 0x000012BA
		[global::System.Runtime.Serialization.DataMember]
		public string fwVersion { get; set; }

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000064 RID: 100 RVA: 0x000030C3 File Offset: 0x000012C3
		// (set) Token: 0x06000065 RID: 101 RVA: 0x000030CB File Offset: 0x000012CB
		[global::System.Runtime.Serialization.DataMember]
		public int inactivityTimer { get; set; }

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000066 RID: 102 RVA: 0x000030D4 File Offset: 0x000012D4
		// (set) Token: 0x06000067 RID: 103 RVA: 0x000030DC File Offset: 0x000012DC
		[global::System.Runtime.Serialization.DataMember]
		public string staged { get; set; }

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000068 RID: 104 RVA: 0x000030E5 File Offset: 0x000012E5
		// (set) Token: 0x06000069 RID: 105 RVA: 0x000030ED File Offset: 0x000012ED
		[global::System.Runtime.Serialization.DataMember]
		public string rmVersion { get; set; }

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600006A RID: 106 RVA: 0x000030F6 File Offset: 0x000012F6
		// (set) Token: 0x0600006B RID: 107 RVA: 0x000030FE File Offset: 0x000012FE
		[global::System.Runtime.Serialization.DataMember]
		public string lastPackage { get; set; }

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600006C RID: 108 RVA: 0x00003107 File Offset: 0x00001307
		// (set) Token: 0x0600006D RID: 109 RVA: 0x0000310F File Offset: 0x0000130F
		[global::System.Runtime.Serialization.DataMember]
		public string certificates { get; set; }

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600006E RID: 110 RVA: 0x00003118 File Offset: 0x00001318
		// (set) Token: 0x0600006F RID: 111 RVA: 0x00003120 File Offset: 0x00001320
		[global::System.Runtime.Serialization.DataMember]
		public int resultCode { get; set; }

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000070 RID: 112 RVA: 0x00003129 File Offset: 0x00001329
		// (set) Token: 0x06000071 RID: 113 RVA: 0x00003131 File Offset: 0x00001331
		[global::System.Runtime.Serialization.DataMember]
		public string bpModelNumber { get; set; }

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000072 RID: 114 RVA: 0x0000313A File Offset: 0x0000133A
		// (set) Token: 0x06000073 RID: 115 RVA: 0x00003142 File Offset: 0x00001342
		[global::System.Runtime.Serialization.DataMember]
		public string bpCodeplugVersion { get; set; }

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000074 RID: 116 RVA: 0x0000314B File Offset: 0x0000134B
		// (set) Token: 0x06000075 RID: 117 RVA: 0x00003153 File Offset: 0x00001353
		[global::System.Runtime.Serialization.DataMember]
		public string bpHostFwVersion { get; set; }

		// Token: 0x06000076 RID: 118 RVA: 0x0000315C File Offset: 0x0000135C
		public InnerInventory(string serialNo, string manufacturer, string model, string imei, string fwVersion, int timer, string staged, string ver, string package, string certi, int result, string modelNumber, string cpversion, string bpversion)
		{
			this.serialNumber = serialNo;
			this.manufacturer = manufacturer;
			this.model = model;
			this.imei = imei;
			this.fwVersion = fwVersion;
			this.inactivityTimer = timer;
			this.staged = staged;
			this.rmVersion = ver;
			this.lastPackage = package;
			this.certificates = certi;
			this.resultCode = result;
			this.bpModelNumber = modelNumber;
			this.bpCodeplugVersion = cpversion;
			this.bpHostFwVersion = bpversion;
		}
	}
}
