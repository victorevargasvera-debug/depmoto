using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Motorola.Common.Communication
{
	// Token: 0x02000007 RID: 7
	public class HttpDownloadFileCollection : global::Motorola.Common.Communication.HttpMessageBase
	{
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000012 RID: 18 RVA: 0x0000225D File Offset: 0x0000045D
		// (set) Token: 0x06000013 RID: 19 RVA: 0x00002265 File Offset: 0x00000465
		public byte[] ResponseData { get; set; }

		// Token: 0x06000014 RID: 20 RVA: 0x00002270 File Offset: 0x00000470
		public HttpDownloadFileCollection() : base(global::System.Net.Http.HttpMethod.Get, "fileCollection")
		{
			base.RequestMessage.Headers.Accept.Clear();
			base.RequestMessage.Headers.Accept.Add(new global::System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/octet-stream"));
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000022C4 File Offset: 0x000004C4
		public HttpDownloadFileCollection(string fileName) : base(global::System.Net.Http.HttpMethod.Get, "fileCollection/" + fileName)
		{
			base.ReadTimeout = 1800000;
			base.RequestMessage.Headers.Accept.Clear();
			base.RequestMessage.Headers.Accept.Add(new global::System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/octet-stream"));
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002326 File Offset: 0x00000526
		public override void HandleResponse(global::System.Net.Http.HttpResponseMessage response)
		{
			base.HandleResponse(response);
			this.ResponseData = response.Content.ReadAsByteArrayAsync().Result;
		}
	}
}
