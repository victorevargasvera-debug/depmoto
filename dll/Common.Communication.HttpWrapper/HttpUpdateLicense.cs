using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication
{
	// Token: 0x02000018 RID: 24
	public class HttpUpdateLicense : global::Motorola.Common.Communication.HttpMessageBase
	{
		// Token: 0x0600003B RID: 59 RVA: 0x00002A7C File Offset: 0x00000C7C
		public HttpUpdateLicense(string licFullName) : base(global::System.Net.Http.HttpMethod.Post, "licenseInventory")
		{
			if (global::System.IO.File.Exists(licFullName))
			{
				global::System.IO.Stream content = new global::System.IO.FileStream(licFullName, global::System.IO.FileMode.Open);
				global::System.Net.Http.HttpContent httpContent = new global::System.Net.Http.StreamContent(content);
				httpContent.Headers.ContentType = new global::System.Net.Http.Headers.MediaTypeHeaderValue("application/octet-stream");
				base.RequestMessage.Content = httpContent;
				return;
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.FileIOAccessError, string.Format("{0} not exist", licFullName));
		}
	}
}
