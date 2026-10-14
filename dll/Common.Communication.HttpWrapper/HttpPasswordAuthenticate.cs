using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace Motorola.Common.Communication
{
	// Token: 0x02000013 RID: 19
	public class HttpPasswordAuthenticate : global::Motorola.Common.Communication.HttpMessageBase
	{
		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600002E RID: 46 RVA: 0x000027ED File Offset: 0x000009ED
		// (set) Token: 0x0600002F RID: 47 RVA: 0x000027F5 File Offset: 0x000009F5
		public global::Motorola.Common.Communication.DeviceInventory ResponseData { get; set; }

		// Token: 0x06000030 RID: 48 RVA: 0x00002800 File Offset: 0x00000A00
		public HttpPasswordAuthenticate(string password) : base(global::System.Net.Http.HttpMethod.Post, "password")
		{
			global::System.Net.Http.HttpContent content = new global::System.Net.Http.StringContent(password, global::System.Text.Encoding.UTF8);
			base.RequestMessage.Content = content;
			base.RequestMessage.Headers.Accept.Clear();
			base.RequestMessage.Headers.Accept.Add(new global::System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
		}

		// Token: 0x06000031 RID: 49 RVA: 0x0000286C File Offset: 0x00000A6C
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			base.DecodeReplyMessage(replyBuffer, offset, length);
			string @string = global::System.Text.Encoding.UTF8.GetString(base._myReplyBuffer, offset, length);
			this.ResponseData = global::Motorola.Common.Communication.JSONHelper.Parse<global::Motorola.Common.Communication.DeviceInventory>(@string);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000028A4 File Offset: 0x00000AA4
		public override void HandleResponse(global::System.Net.Http.HttpResponseMessage response)
		{
			base.HandleResponse(response);
			string result = response.Content.ReadAsStringAsync().Result;
			this.ResponseData = global::Motorola.Common.Communication.JSONHelper.Parse<global::Motorola.Common.Communication.DeviceInventory>(result);
		}
	}
}
