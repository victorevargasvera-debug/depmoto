using System;
using System.Net.Http;
using System.Text;

namespace Motorola.Common.Communication
{
	// Token: 0x02000016 RID: 22
	public class HttpTerminateSession : global::Motorola.Common.Communication.HttpMessageBase
	{
		// Token: 0x06000039 RID: 57 RVA: 0x000029C0 File Offset: 0x00000BC0
		public HttpTerminateSession(int code, string msg) : base(global::System.Net.Http.HttpMethod.Post, "terminateSession")
		{
			global::Motorola.Common.Communication.TerminateSession jsonObj = new global::Motorola.Common.Communication.TerminateSession(new global::Motorola.Common.Communication.ReasonClass(code, msg));
			global::System.Net.Http.HttpContent content = new global::System.Net.Http.StringContent(global::Motorola.Common.Communication.JSONHelper.ToString(jsonObj), global::System.Text.Encoding.UTF8);
			base.RequestMessage.Content = content;
		}
	}
}
