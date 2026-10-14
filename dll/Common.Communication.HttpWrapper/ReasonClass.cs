using System;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication
{
	// Token: 0x0200002C RID: 44
	[global::System.Runtime.Serialization.DataContract]
	public class ReasonClass
	{
		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600009E RID: 158 RVA: 0x00003394 File Offset: 0x00001594
		// (set) Token: 0x0600009F RID: 159 RVA: 0x0000339C File Offset: 0x0000159C
		[global::System.Runtime.Serialization.DataMember]
		public int code { get; set; }

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x000033A5 File Offset: 0x000015A5
		// (set) Token: 0x060000A1 RID: 161 RVA: 0x000033AD File Offset: 0x000015AD
		[global::System.Runtime.Serialization.DataMember]
		public string message { get; set; }

		// Token: 0x060000A2 RID: 162 RVA: 0x000033B6 File Offset: 0x000015B6
		public ReasonClass(int c, string msg)
		{
			this.code = c;
			this.message = msg;
		}
	}
}
