using System;
using System.Net.Http;

namespace Motorola.Common.Communication
{
	// Token: 0x02000006 RID: 6
	public class HttpDisableAllSysCert : global::Motorola.Common.Communication.HttpMessageBase
	{
		// Token: 0x06000011 RID: 17 RVA: 0x0000224B File Offset: 0x0000044B
		public HttpDisableAllSysCert() : base(global::System.Net.Http.HttpMethod.Post, "certificate/disableAllSystemCACerts")
		{
		}
	}
}
