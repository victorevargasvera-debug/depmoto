using System;
using System.Runtime.Serialization;

namespace Motorola.Common.CustomException
{
	// Token: 0x02000006 RID: 6
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class CommonExceptionData
	{
		// Token: 0x06000016 RID: 22 RVA: 0x00002347 File Offset: 0x00000547
		public CommonExceptionData(global::Motorola.Common.CustomException.CommonErrorCode errorCode, string[] Paramters)
		{
			this.ErrorCode = errorCode;
			this.Paramters = Paramters;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x0000235D File Offset: 0x0000055D
		public CommonExceptionData(global::Motorola.Common.CustomException.CommonErrorCode errorCode)
		{
			this.ErrorCode = errorCode;
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000018 RID: 24 RVA: 0x0000236C File Offset: 0x0000056C
		// (set) Token: 0x06000019 RID: 25 RVA: 0x00002374 File Offset: 0x00000574
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.Common.CustomException.CommonErrorCode ErrorCode { get; set; }

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600001A RID: 26 RVA: 0x0000237D File Offset: 0x0000057D
		// (set) Token: 0x0600001B RID: 27 RVA: 0x00002385 File Offset: 0x00000585
		[global::System.Runtime.Serialization.DataMember]
		public string[] Paramters { get; set; }
	}
}
