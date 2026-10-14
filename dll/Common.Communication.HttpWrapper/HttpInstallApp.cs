using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication
{
	// Token: 0x02000011 RID: 17
	public class HttpInstallApp : global::Motorola.Common.Communication.HttpMessageBase
	{
		// Token: 0x06000029 RID: 41 RVA: 0x00002680 File Offset: 0x00000880
		public HttpInstallApp(string appFullName, string name) : base(global::System.Net.Http.HttpMethod.Post, "appInventory/" + name)
		{
			global::System.IO.FileInfo fileInfo = new global::System.IO.FileInfo(appFullName);
			if (fileInfo.Exists)
			{
				global::System.IO.Stream content = new global::System.IO.FileStream(appFullName, global::System.IO.FileMode.Open);
				global::System.Net.Http.HttpContent httpContent = new global::System.Net.Http.StreamContent(content);
				httpContent.Headers.ContentType = new global::System.Net.Http.Headers.MediaTypeHeaderValue("application/octet-stream");
				base.RequestMessage.Content = httpContent;
				return;
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.FileIOAccessError, string.Format("{0} not exist", appFullName));
		}
	}
}
