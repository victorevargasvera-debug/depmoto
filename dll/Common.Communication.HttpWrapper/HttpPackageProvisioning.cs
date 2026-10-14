using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication
{
	// Token: 0x02000012 RID: 18
	public class HttpPackageProvisioning : global::Motorola.Common.Communication.HttpMessageBase
	{
		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600002A RID: 42 RVA: 0x000026F5 File Offset: 0x000008F5
		// (set) Token: 0x0600002B RID: 43 RVA: 0x000026FD File Offset: 0x000008FD
		public global::Motorola.Common.Communication.FileCollection ResponseData { get; set; }

		// Token: 0x0600002C RID: 44 RVA: 0x00002708 File Offset: 0x00000908
		public HttpPackageProvisioning(string provisioningPackageFullName, bool? needReboot = null) : base(global::System.Net.Http.HttpMethod.Post, "packageFile")
		{
			base.ReadTimeout = 3600000;
			if (!global::System.IO.File.Exists(provisioningPackageFullName))
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.FileIOAccessError, string.Format("{0} not exist", provisioningPackageFullName));
			}
			global::System.IO.Stream content = new global::System.IO.FileStream(provisioningPackageFullName, global::System.IO.FileMode.Open);
			global::System.Net.Http.HttpContent httpContent = new global::System.Net.Http.StreamContent(content);
			httpContent.Headers.ContentType = new global::System.Net.Http.Headers.MediaTypeHeaderValue("application/octet-stream");
			base.RequestMessage.Content = httpContent;
			if (needReboot ?? false)
			{
				base.RequestMessage.Headers.ConnectionClose = new bool?(true);
				return;
			}
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000027AC File Offset: 0x000009AC
		public override void HandleResponse(global::System.Net.Http.HttpResponseMessage response)
		{
			base.HandleResponse(response);
			string result = response.Content.ReadAsStringAsync().Result;
			if (string.IsNullOrEmpty(result))
			{
				this.ResponseData = null;
				return;
			}
			this.ResponseData = global::Motorola.Common.Communication.JSONHelper.Parse<global::Motorola.Common.Communication.FileCollection>(result);
		}
	}
}
