using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace Motorola.Common.Communication
{
	// Token: 0x0200000D RID: 13
	public class HttpListApp : global::Motorola.Common.Communication.HttpMessageBase
	{
		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600001F RID: 31 RVA: 0x000024DF File Offset: 0x000006DF
		// (set) Token: 0x06000020 RID: 32 RVA: 0x000024E7 File Offset: 0x000006E7
		public global::Motorola.Common.Communication.AppInventory ResponseData { get; set; }

		// Token: 0x06000021 RID: 33 RVA: 0x000024F0 File Offset: 0x000006F0
		public HttpListApp() : base(global::System.Net.Http.HttpMethod.Get, "appInventory")
		{
			base.RequestMessage.Headers.Accept.Clear();
			base.RequestMessage.Headers.Accept.Add(new global::System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002544 File Offset: 0x00000744
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			base.DecodeReplyMessage(replyBuffer, offset, length);
			string @string = global::System.Text.Encoding.UTF8.GetString(base._myReplyBuffer, offset, length);
			this.ResponseData = global::Motorola.Common.Communication.JSONHelper.Parse<global::Motorola.Common.Communication.AppInventory>(@string);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x0000257C File Offset: 0x0000077C
		public override void HandleResponse(global::System.Net.Http.HttpResponseMessage response)
		{
			base.HandleResponse(response);
			string result = response.Content.ReadAsStringAsync().Result;
			this.ResponseData = global::Motorola.Common.Communication.JSONHelper.Parse<global::Motorola.Common.Communication.AppInventory>(result);
		}
	}
}
