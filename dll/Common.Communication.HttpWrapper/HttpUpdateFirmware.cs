using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication
{
	// Token: 0x02000017 RID: 23
	public class HttpUpdateFirmware : global::Motorola.Common.Communication.HttpMessageBase
	{
		// Token: 0x0600003A RID: 58 RVA: 0x00002A08 File Offset: 0x00000C08
		public HttpUpdateFirmware(string fwFullName) : base(global::System.Net.Http.HttpMethod.Post, "deviceFirmware")
		{
			base.ReadTimeout = 3600000;
			if (global::System.IO.File.Exists(fwFullName))
			{
				global::System.IO.Stream content = new global::System.IO.FileStream(fwFullName, global::System.IO.FileMode.Open);
				global::System.Net.Http.HttpContent httpContent = new global::System.Net.Http.StreamContent(content);
				httpContent.Headers.ContentType = new global::System.Net.Http.Headers.MediaTypeHeaderValue("application/octet-stream");
				base.RequestMessage.Content = httpContent;
				return;
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.FileIOAccessError, string.Format("{0} not exist", fwFullName));
		}
	}
}
