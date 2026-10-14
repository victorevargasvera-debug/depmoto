using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication
{
	// Token: 0x02000009 RID: 9
	public class HttpInstallCert : global::Motorola.Common.Communication.HttpMessageBase
	{
		// Token: 0x06000018 RID: 24 RVA: 0x00002358 File Offset: 0x00000558
		public HttpInstallCert(string certFullName, string name) : base(global::System.Net.Http.HttpMethod.Post, "certificate/installCACert/" + name)
		{
			global::System.IO.FileInfo fileInfo = new global::System.IO.FileInfo(certFullName);
			if (fileInfo.Exists)
			{
				global::System.IO.Stream content = new global::System.IO.FileStream(certFullName, global::System.IO.FileMode.Open);
				global::System.Net.Http.HttpContent httpContent = new global::System.Net.Http.StreamContent(content);
				httpContent.Headers.ContentType = new global::System.Net.Http.Headers.MediaTypeHeaderValue("application/octet-stream");
				base.RequestMessage.Content = httpContent;
				return;
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.FileIOAccessError, string.Format("{0} not exist", certFullName));
		}
	}
}
