using System;
using System.Net.Http;

namespace Motorola.Common.Communication
{
	// Token: 0x0200000A RID: 10
	public class HttpUninstallAllCert : global::Motorola.Common.Communication.HttpMessageBase
	{
		// Token: 0x06000019 RID: 25 RVA: 0x000023CD File Offset: 0x000005CD
		public HttpUninstallAllCert() : base(global::System.Net.Http.HttpMethod.Post, "certificate/uninstallAllCACerts")
		{
		}
	}
}
