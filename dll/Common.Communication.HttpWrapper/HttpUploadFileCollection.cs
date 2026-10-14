using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication
{
	// Token: 0x0200000B RID: 11
	public class HttpUploadFileCollection : global::Motorola.Common.Communication.HttpMessageBase
	{
		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600001A RID: 26 RVA: 0x000023DF File Offset: 0x000005DF
		// (set) Token: 0x0600001B RID: 27 RVA: 0x000023E7 File Offset: 0x000005E7
		public global::Motorola.Common.Communication.FileCollection ResponseData { get; set; }

		// Token: 0x0600001C RID: 28 RVA: 0x000023F0 File Offset: 0x000005F0
		public HttpUploadFileCollection(string manifestFileName) : base(global::System.Net.Http.HttpMethod.Post, "fileCollection")
		{
			base.ReadTimeout = 1800000;
			if (global::System.IO.File.Exists(manifestFileName))
			{
				global::System.IO.Stream content = new global::System.IO.FileStream(manifestFileName, global::System.IO.FileMode.Open);
				global::System.Net.Http.HttpContent httpContent = new global::System.Net.Http.StreamContent(content);
				httpContent.Headers.ContentType = new global::System.Net.Http.Headers.MediaTypeHeaderValue("application/xml");
				base.RequestMessage.Content = httpContent;
				return;
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.FileIOAccessError, string.Format("{0} not exist", manifestFileName));
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002464 File Offset: 0x00000664
		public override void HandleResponse(global::System.Net.Http.HttpResponseMessage response)
		{
			base.HandleResponse(response);
			string result = response.Content.ReadAsStringAsync().Result;
			this.ResponseData = global::Motorola.Common.Communication.JSONHelper.Parse<global::Motorola.Common.Communication.FileCollection>(result);
		}
	}
}
