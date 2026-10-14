using System;
using System.Net.Http;
using System.Text;

namespace Motorola.Common.Communication
{
	// Token: 0x0200000C RID: 12
	public class HttpFactoryReset : global::Motorola.Common.Communication.HttpMessageBase
	{
		// Token: 0x0600001E RID: 30 RVA: 0x00002498 File Offset: 0x00000698
		public HttpFactoryReset(int code, string msg) : base(global::System.Net.Http.HttpMethod.Post, "factoryReset")
		{
			global::Motorola.Common.Communication.FactoryReset jsonObj = new global::Motorola.Common.Communication.FactoryReset(new global::Motorola.Common.Communication.ReasonClass(code, msg));
			global::System.Net.Http.HttpContent content = new global::System.Net.Http.StringContent(global::Motorola.Common.Communication.JSONHelper.ToString(jsonObj), global::System.Text.Encoding.UTF8);
			base.RequestMessage.Content = content;
		}
	}
}
