using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace Motorola.Common.Communication
{
	// Token: 0x02000014 RID: 20
	public class HttpReadDeviceInventory : global::Motorola.Common.Communication.HttpMessageBase
	{
		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000033 RID: 51 RVA: 0x000028D5 File Offset: 0x00000AD5
		// (set) Token: 0x06000034 RID: 52 RVA: 0x000028DD File Offset: 0x00000ADD
		public global::Motorola.Common.Communication.DeviceInventory ResponseData { get; set; }

		// Token: 0x06000035 RID: 53 RVA: 0x000028E8 File Offset: 0x00000AE8
		public HttpReadDeviceInventory() : base(global::System.Net.Http.HttpMethod.Get, "deviceInventory")
		{
			base.RequestMessage.Headers.Accept.Clear();
			base.RequestMessage.Headers.Accept.Add(new global::System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
		}

		// Token: 0x06000036 RID: 54 RVA: 0x0000293C File Offset: 0x00000B3C
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			base.DecodeReplyMessage(replyBuffer, offset, length);
			string @string = global::System.Text.Encoding.UTF8.GetString(base._myReplyBuffer, offset, length);
			this.ResponseData = global::Motorola.Common.Communication.JSONHelper.Parse<global::Motorola.Common.Communication.DeviceInventory>(@string);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002974 File Offset: 0x00000B74
		public override void HandleResponse(global::System.Net.Http.HttpResponseMessage response)
		{
			base.HandleResponse(response);
			string result = response.Content.ReadAsStringAsync().Result;
			this.ResponseData = global::Motorola.Common.Communication.JSONHelper.Parse<global::Motorola.Common.Communication.DeviceInventory>(result);
		}
	}
}
