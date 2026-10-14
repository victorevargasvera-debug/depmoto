using System;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication
{
	// Token: 0x02000020 RID: 32
	[global::System.Runtime.Serialization.DataContract]
	public class App
	{
		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600004E RID: 78 RVA: 0x00002FE1 File Offset: 0x000011E1
		// (set) Token: 0x0600004F RID: 79 RVA: 0x00002FE9 File Offset: 0x000011E9
		[global::System.Runtime.Serialization.DataMember]
		public string appName { get; set; }

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000050 RID: 80 RVA: 0x00002FF2 File Offset: 0x000011F2
		// (set) Token: 0x06000051 RID: 81 RVA: 0x00002FFA File Offset: 0x000011FA
		[global::System.Runtime.Serialization.DataMember]
		public string appLabel { get; set; }

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000052 RID: 82 RVA: 0x00003003 File Offset: 0x00001203
		// (set) Token: 0x06000053 RID: 83 RVA: 0x0000300B File Offset: 0x0000120B
		[global::System.Runtime.Serialization.DataMember]
		public int versionCode { get; set; }

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000054 RID: 84 RVA: 0x00003014 File Offset: 0x00001214
		// (set) Token: 0x06000055 RID: 85 RVA: 0x0000301C File Offset: 0x0000121C
		[global::System.Runtime.Serialization.DataMember]
		public string versionName { get; set; }

		// Token: 0x06000056 RID: 86 RVA: 0x00003025 File Offset: 0x00001225
		public App(string name, string label, int code, string vname)
		{
			this.appName = name;
			this.appLabel = label;
			this.versionCode = code;
			this.versionName = vname;
		}
	}
}
