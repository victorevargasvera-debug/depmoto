using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Motorola.Common.Communication
{
	// Token: 0x0200001C RID: 28
	public class HttpProvGetCfs : global::Motorola.Common.Communication.HttpMessageBase
	{
		// Token: 0x06000046 RID: 70 RVA: 0x00002C1C File Offset: 0x00000E1C
		public HttpProvGetCfs() : base(global::System.Net.Http.HttpMethod.Get, "cfs_hardware_id")
		{
			base.RequestMessage.Headers.Accept.Clear();
			base.RequestMessage.Headers.Accept.Add(new global::System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("text/html"));
			base.RequestMessage.Headers.Accept.Add(new global::System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("text/plain"));
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002C8C File Offset: 0x00000E8C
		public override void HandleResponse(global::System.Net.Http.HttpResponseMessage response)
		{
			base.HandleResponse(response);
			this.CFSHardwareID = response.Content.ReadAsStringAsync().Result;
		}

		// Token: 0x0400002F RID: 47
		public string CFSHardwareID;
	}
}
