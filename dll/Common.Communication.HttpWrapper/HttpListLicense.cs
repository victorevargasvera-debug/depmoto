using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace Motorola.Common.Communication
{
	// Token: 0x0200000E RID: 14
	public class HttpListLicense : global::Motorola.Common.Communication.HttpMessageBase
	{
		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000024 RID: 36 RVA: 0x000025AD File Offset: 0x000007AD
		// (set) Token: 0x06000025 RID: 37 RVA: 0x000025B5 File Offset: 0x000007B5
		public global::Motorola.Common.Communication.LicenseInventory ResponseData { get; set; }

		// Token: 0x06000026 RID: 38 RVA: 0x000025C0 File Offset: 0x000007C0
		public HttpListLicense() : base(global::System.Net.Http.HttpMethod.Get, "licenseInventory")
		{
			base.RequestMessage.Headers.Accept.Clear();
			base.RequestMessage.Headers.Accept.Add(new global::System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002614 File Offset: 0x00000814
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			base.DecodeReplyMessage(replyBuffer, offset, length);
			string @string = global::System.Text.Encoding.UTF8.GetString(base._myReplyBuffer, offset, length);
			this.ResponseData = global::Motorola.Common.Communication.JSONHelper.Parse<global::Motorola.Common.Communication.LicenseInventory>(@string);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x0000264C File Offset: 0x0000084C
		public override void HandleResponse(global::System.Net.Http.HttpResponseMessage response)
		{
			base.HandleResponse(response);
			string result = response.Content.ReadAsStringAsync().Result;
			this.ResponseData = global::Motorola.Common.Communication.JSONHelper.Parse<global::Motorola.Common.Communication.LicenseInventory>(result);
		}
	}
}
