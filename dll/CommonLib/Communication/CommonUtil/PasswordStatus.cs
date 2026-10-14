using System;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x0200002B RID: 43
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class PasswordStatus
	{
		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000139 RID: 313 RVA: 0x00004F01 File Offset: 0x00003101
		// (set) Token: 0x0600013A RID: 314 RVA: 0x00004F09 File Offset: 0x00003109
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.Common.Communication.CommonUtil.PasswordPolicy Policy { get; set; }

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x0600013B RID: 315 RVA: 0x00004F12 File Offset: 0x00003112
		// (set) Token: 0x0600013C RID: 316 RVA: 0x00004F1A File Offset: 0x0000311A
		[global::System.Runtime.Serialization.DataMember]
		public uint AlgorithmID { get; set; }

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600013D RID: 317 RVA: 0x00004F23 File Offset: 0x00003123
		// (set) Token: 0x0600013E RID: 318 RVA: 0x00004F2B File Offset: 0x0000312B
		[global::System.Runtime.Serialization.DataMember]
		public byte[] Salt { get; set; }

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x0600013F RID: 319 RVA: 0x00004F34 File Offset: 0x00003134
		// (set) Token: 0x06000140 RID: 320 RVA: 0x00004F3C File Offset: 0x0000313C
		[global::System.Runtime.Serialization.DataMember]
		public byte ConfigurationLocked { get; set; }

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000141 RID: 321 RVA: 0x00004F45 File Offset: 0x00003145
		// (set) Token: 0x06000142 RID: 322 RVA: 0x00004F4D File Offset: 0x0000314D
		[global::System.Runtime.Serialization.DataMember]
		public byte RemainingAttempts { get; set; }

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000143 RID: 323 RVA: 0x00004F56 File Offset: 0x00003156
		// (set) Token: 0x06000144 RID: 324 RVA: 0x00004F5E File Offset: 0x0000315E
		[global::System.Runtime.Serialization.DataMember]
		public bool IsPasswordValidationSuccess { get; set; }
	}
}
