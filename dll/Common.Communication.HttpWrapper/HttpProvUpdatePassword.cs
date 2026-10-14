using System;
using System.Collections.Generic;
using System.Net.Http;

namespace Motorola.Common.Communication
{
	// Token: 0x0200001B RID: 27
	public class HttpProvUpdatePassword : global::Motorola.Common.Communication.HttpMessageBase
	{
		// Token: 0x06000045 RID: 69 RVA: 0x00002BCC File Offset: 0x00000DCC
		public HttpProvUpdatePassword(string password) : base(global::System.Net.Http.HttpMethod.Put, "updateuser")
		{
			global::System.Net.Http.HttpContent content = new global::System.Net.Http.FormUrlEncodedContent(new global::System.Collections.Generic.KeyValuePair<string, string>[]
			{
				new global::System.Collections.Generic.KeyValuePair<string, string>("password", password)
			});
			base.RequestMessage.Content = content;
		}
	}
}
