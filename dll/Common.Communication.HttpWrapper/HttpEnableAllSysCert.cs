using System;
using System.Net.Http;

namespace Motorola.Common.Communication
{
	// Token: 0x02000008 RID: 8
	public class HttpEnableAllSysCert : global::Motorola.Common.Communication.HttpMessageBase
	{
		// Token: 0x06000017 RID: 23 RVA: 0x00002345 File Offset: 0x00000545
		public HttpEnableAllSysCert() : base(global::System.Net.Http.HttpMethod.Post, "certificate/enableAllSystemCACerts")
		{
		}
	}
}
