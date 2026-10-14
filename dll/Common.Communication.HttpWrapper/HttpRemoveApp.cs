using System;
using System.Net.Http;

namespace Motorola.Common.Communication
{
	// Token: 0x02000015 RID: 21
	public class HttpRemoveApp : global::Motorola.Common.Communication.HttpMessageBase
	{
		// Token: 0x06000038 RID: 56 RVA: 0x000029A5 File Offset: 0x00000BA5
		public HttpRemoveApp(string appName) : base(global::System.Net.Http.HttpMethod.Post, "deleteAppInventory/" + appName)
		{
		}
	}
}
