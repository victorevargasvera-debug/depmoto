using System;
using System.Runtime.Serialization;

namespace IACustomException
{
	// Token: 0x02000004 RID: 4
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class IACommonExceptionData
	{
		// Token: 0x0600000E RID: 14 RVA: 0x00002248 File Offset: 0x00000448
		public IACommonExceptionData(global::IACustomException.IACommonErrorCode errorCode, string[] Paramters)
		{
			this.ErrorCode = errorCode;
			this.Paramters = Paramters;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x0000225E File Offset: 0x0000045E
		public IACommonExceptionData(global::IACustomException.IACommonErrorCode errorCode)
		{
			this.ErrorCode = errorCode;
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000010 RID: 16 RVA: 0x0000226D File Offset: 0x0000046D
		// (set) Token: 0x06000011 RID: 17 RVA: 0x00002275 File Offset: 0x00000475
		[global::System.Runtime.Serialization.DataMember]
		public global::IACustomException.IACommonErrorCode ErrorCode { get; set; }

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000012 RID: 18 RVA: 0x0000227E File Offset: 0x0000047E
		// (set) Token: 0x06000013 RID: 19 RVA: 0x00002286 File Offset: 0x00000486
		[global::System.Runtime.Serialization.DataMember]
		public string[] Paramters { get; set; }
	}
}
