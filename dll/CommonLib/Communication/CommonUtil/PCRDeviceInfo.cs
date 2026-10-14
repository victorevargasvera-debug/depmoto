using System;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x0200002C RID: 44
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class PCRDeviceInfo : global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo
	{
		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000146 RID: 326 RVA: 0x00004F6F File Offset: 0x0000316F
		// (set) Token: 0x06000147 RID: 327 RVA: 0x00004F77 File Offset: 0x00003177
		[global::System.Runtime.Serialization.DataMember]
		public string UUID { get; set; }

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000148 RID: 328 RVA: 0x00004F80 File Offset: 0x00003180
		// (set) Token: 0x06000149 RID: 329 RVA: 0x00004F88 File Offset: 0x00003188
		[global::System.Runtime.Serialization.DataMember]
		public bool Is32MPlatform { get; set; }

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x0600014A RID: 330 RVA: 0x00004F91 File Offset: 0x00003191
		// (set) Token: 0x0600014B RID: 331 RVA: 0x00004F99 File Offset: 0x00003199
		[global::System.Runtime.Serialization.DataMember]
		public string BootloaderVersion { get; set; }

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x0600014C RID: 332 RVA: 0x00004FA2 File Offset: 0x000031A2
		// (set) Token: 0x0600014D RID: 333 RVA: 0x00004FAA File Offset: 0x000031AA
		[global::System.Runtime.Serialization.DataMember]
		public string L3BootloaderVersion { get; set; }

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x0600014E RID: 334 RVA: 0x00004FB3 File Offset: 0x000031B3
		// (set) Token: 0x0600014F RID: 335 RVA: 0x00004FBB File Offset: 0x000031BB
		[global::System.Runtime.Serialization.DataMember]
		public string ConfigurationVersion { get; set; }

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000150 RID: 336 RVA: 0x00004FC4 File Offset: 0x000031C4
		// (set) Token: 0x06000151 RID: 337 RVA: 0x00004FCC File Offset: 0x000031CC
		[global::System.Runtime.Serialization.DataMember]
		public string KernelVersion { get; set; }

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000152 RID: 338 RVA: 0x00004FD5 File Offset: 0x000031D5
		// (set) Token: 0x06000153 RID: 339 RVA: 0x00004FDD File Offset: 0x000031DD
		[global::System.Runtime.Serialization.DataMember]
		public string MacAddress { get; set; }

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000154 RID: 340 RVA: 0x00004FE6 File Offset: 0x000031E6
		// (set) Token: 0x06000155 RID: 341 RVA: 0x00004FEE File Offset: 0x000031EE
		[global::System.Runtime.Serialization.DataMember]
		public string MacAddressPort1 { get; set; }

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000156 RID: 342 RVA: 0x00004FF7 File Offset: 0x000031F7
		// (set) Token: 0x06000157 RID: 343 RVA: 0x00004FFF File Offset: 0x000031FF
		[global::System.Runtime.Serialization.DataMember]
		public string MacAddressPort2 { get; set; }

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000158 RID: 344 RVA: 0x00005008 File Offset: 0x00003208
		// (set) Token: 0x06000159 RID: 345 RVA: 0x00005010 File Offset: 0x00003210
		[global::System.Runtime.Serialization.DataMember]
		public string MacAddressWIFIPort1 { get; set; }

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x0600015A RID: 346 RVA: 0x00005019 File Offset: 0x00003219
		// (set) Token: 0x0600015B RID: 347 RVA: 0x00005021 File Offset: 0x00003221
		[global::System.Runtime.Serialization.DataMember]
		public string MacAddressWIFIPort2 { get; set; }

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x0600015C RID: 348 RVA: 0x0000502A File Offset: 0x0000322A
		// (set) Token: 0x0600015D RID: 349 RVA: 0x00005032 File Offset: 0x00003232
		[global::System.Runtime.Serialization.DataMember]
		public string PsdtVersion { get; set; }

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x0600015E RID: 350 RVA: 0x0000503B File Offset: 0x0000323B
		// (set) Token: 0x0600015F RID: 351 RVA: 0x00005043 File Offset: 0x00003243
		[global::System.Runtime.Serialization.DataMember]
		public int AvailableLPSpace { get; set; }

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000160 RID: 352 RVA: 0x0000504C File Offset: 0x0000324C
		// (set) Token: 0x06000161 RID: 353 RVA: 0x00005054 File Offset: 0x00003254
		[global::System.Runtime.Serialization.DataMember]
		public int AvailableMemory { get; set; }

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000162 RID: 354 RVA: 0x0000505D File Offset: 0x0000325D
		// (set) Token: 0x06000163 RID: 355 RVA: 0x00005065 File Offset: 0x00003265
		[global::System.Runtime.Serialization.DataMember]
		public byte Region { get; set; }

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000164 RID: 356 RVA: 0x0000506E File Offset: 0x0000326E
		// (set) Token: 0x06000165 RID: 357 RVA: 0x00005076 File Offset: 0x00003276
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.Common.Communication.CommonUtil.FpgaInfo FpgaInfo { get; set; }

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000166 RID: 358 RVA: 0x0000507F File Offset: 0x0000327F
		// (set) Token: 0x06000167 RID: 359 RVA: 0x00005087 File Offset: 0x00003287
		[global::System.Runtime.Serialization.DataMember]
		public bool IsDualBoard { get; set; }

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000168 RID: 360 RVA: 0x00005090 File Offset: 0x00003290
		// (set) Token: 0x06000169 RID: 361 RVA: 0x00005098 File Offset: 0x00003298
		[global::System.Runtime.Serialization.DataMember]
		public string RemoteSerialNumber { get; set; }

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x0600016A RID: 362 RVA: 0x000050A1 File Offset: 0x000032A1
		// (set) Token: 0x0600016B RID: 363 RVA: 0x000050A9 File Offset: 0x000032A9
		[global::System.Runtime.Serialization.DataMember]
		public bool Master { get; set; }

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x0600016C RID: 364 RVA: 0x000050B2 File Offset: 0x000032B2
		// (set) Token: 0x0600016D RID: 365 RVA: 0x000050BA File Offset: 0x000032BA
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.Common.Communication.CommonUtil.PasswordStatus PasswordStatus { get; set; }

		// Token: 0x04000131 RID: 305
		[global::System.Runtime.Serialization.OptionalField]
		[global::System.Runtime.Serialization.DataMember]
		public bool IsDSPEnabled = true;

		// Token: 0x04000132 RID: 306
		[global::System.Runtime.Serialization.OptionalField]
		[global::System.Runtime.Serialization.DataMember]
		public bool IsDTPEnabled;

		// Token: 0x04000133 RID: 307
		[global::System.Runtime.Serialization.OptionalField]
		[global::System.Runtime.Serialization.DataMember]
		public string VoterID = string.Empty;

		// Token: 0x04000134 RID: 308
		[global::System.Runtime.Serialization.DataMember]
		[global::System.Runtime.Serialization.OptionalField]
		public string PhysicalSerialNumber;

		// Token: 0x04000135 RID: 309
		[global::System.Runtime.Serialization.OptionalField]
		[global::System.Runtime.Serialization.DataMember]
		public string BrickTXSerialNumber;

		// Token: 0x04000136 RID: 310
		[global::System.Runtime.Serialization.DataMember]
		[global::System.Runtime.Serialization.OptionalField]
		public string BrickRXSerialNumber;

		// Token: 0x04000137 RID: 311
		[global::System.Runtime.Serialization.OptionalField]
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.Common.Communication.CommonUtil.RRPWorkMode DeviceWorkMode;

		// Token: 0x04000138 RID: 312
		[global::System.Runtime.Serialization.OptionalField]
		[global::System.Runtime.Serialization.DataMember]
		public string FreqTypeOfAndros = string.Empty;
	}
}
