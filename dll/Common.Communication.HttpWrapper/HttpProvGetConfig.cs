using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Motorola.Common.Communication
{
	// Token: 0x0200001E RID: 30
	public class HttpProvGetConfig : global::Motorola.Common.Communication.HttpMessageBase
	{
		// Token: 0x0600004A RID: 74 RVA: 0x00002D34 File Offset: 0x00000F34
		public HttpProvGetConfig(string fileTag) : base(global::System.Net.Http.HttpMethod.Get, "config")
		{
			base.RequestMessage.Headers.Accept.Clear();
			base.RequestMessage.Headers.Accept.Add(new global::System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/octet-stream"));
			string str = global::System.Uri.EscapeDataString(fileTag);
			string str2 = "?FileTag=" + str;
			string uriString = base.RequestMessage.RequestUri.OriginalString + str2;
			base.RequestMessage.RequestUri = new global::System.Uri(uriString);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002DC0 File Offset: 0x00000FC0
		public override void HandleResponse(global::System.Net.Http.HttpResponseMessage response)
		{
			base.HandleResponse(response);
			this.ConfigFileData = response.Content.ReadAsByteArrayAsync().Result;
		}

		// Token: 0x04000031 RID: 49
		private byte[] ConfigFileData;
	}
}
