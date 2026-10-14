using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Motorola.Common.Communication
{
	// Token: 0x0200001A RID: 26
	public class HttpProvGetSerialNumber : global::Motorola.Common.Communication.HttpMessageBase
	{
		// Token: 0x06000043 RID: 67 RVA: 0x00002B3C File Offset: 0x00000D3C
		public HttpProvGetSerialNumber() : base(global::System.Net.Http.HttpMethod.Get, "serial")
		{
			base.RequestMessage.Headers.Accept.Clear();
			base.RequestMessage.Headers.Accept.Add(new global::System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("text/html"));
			base.RequestMessage.Headers.Accept.Add(new global::System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("text/plain"));
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002BAC File Offset: 0x00000DAC
		public override void HandleResponse(global::System.Net.Http.HttpResponseMessage response)
		{
			base.HandleResponse(response);
			this.SerialNumber = response.Content.ReadAsStringAsync().Result;
		}

		// Token: 0x0400002E RID: 46
		public string SerialNumber;
	}
}
