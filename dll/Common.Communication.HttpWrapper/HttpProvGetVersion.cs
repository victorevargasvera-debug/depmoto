using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Motorola.Common.Communication
{
	// Token: 0x0200001D RID: 29
	public class HttpProvGetVersion : global::Motorola.Common.Communication.HttpMessageBase
	{
		// Token: 0x06000048 RID: 72 RVA: 0x00002CAC File Offset: 0x00000EAC
		public HttpProvGetVersion() : base(global::System.Net.Http.HttpMethod.Get, "version")
		{
			base.RequestMessage.Headers.Accept.Clear();
			base.RequestMessage.Headers.Accept.Add(new global::System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002D00 File Offset: 0x00000F00
		public override void HandleResponse(global::System.Net.Http.HttpResponseMessage response)
		{
			base.HandleResponse(response);
			string result = response.Content.ReadAsStringAsync().Result;
			this.VersionData = global::Motorola.Common.Communication.JSONHelper.Parse<global::Motorola.Common.Communication.ProvVersion>(result);
		}

		// Token: 0x04000030 RID: 48
		public global::Motorola.Common.Communication.ProvVersion VersionData;
	}
}
