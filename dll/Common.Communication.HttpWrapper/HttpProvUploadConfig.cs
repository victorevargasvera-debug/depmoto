using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication
{
	// Token: 0x0200001F RID: 31
	public class HttpProvUploadConfig : global::Motorola.Common.Communication.HttpMessageBase
	{
		// Token: 0x0600004C RID: 76 RVA: 0x00002DE0 File Offset: 0x00000FE0
		public HttpProvUploadConfig(global::System.Collections.Generic.Dictionary<string, global::System.IO.Stream> configFiles) : base(global::System.Net.Http.HttpMethod.Post, "config")
		{
			global::System.Net.Http.MultipartFormDataContent multipartFormDataContent = new global::System.Net.Http.MultipartFormDataContent();
			foreach (global::System.Collections.Generic.KeyValuePair<string, global::System.IO.Stream> keyValuePair in configFiles)
			{
				string key = keyValuePair.Key;
				global::System.IO.Stream value = keyValuePair.Value;
				global::System.Net.Http.StreamContent streamContent = new global::System.Net.Http.StreamContent(value);
				streamContent.Headers.ContentType = new global::System.Net.Http.Headers.MediaTypeHeaderValue("application/octet-stream");
				string text = "\"" + key + "\"";
				multipartFormDataContent.Add(streamContent, text, text);
			}
			base.RequestMessage.Content = multipartFormDataContent;
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002E98 File Offset: 0x00001098
		protected override void HandleResponseStatusCode(global::System.Net.Http.HttpResponseMessage response)
		{
			global::System.Net.HttpStatusCode statusCode = response.StatusCode;
			if (statusCode <= (global::System.Net.HttpStatusCode)463)
			{
				switch (statusCode)
				{
				case (global::System.Net.HttpStatusCode)419:
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.HttpProvConfigFileRejected, "Configuration failed. Config service rejected invalid files.");
				case (global::System.Net.HttpStatusCode)420:
					break;
				case (global::System.Net.HttpStatusCode)421:
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.HttpProvConfigServiceBusy, "Configuration failed. Config service is busy.");
				default:
					switch (statusCode)
					{
					case (global::System.Net.HttpStatusCode)461:
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Http_LICENSE_TC_FAILURE, "TC license Operation failed.");
					case (global::System.Net.HttpStatusCode)462:
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Http_CONFIG_TC_FAILURE, "TC config update failed.");
					case (global::System.Net.HttpStatusCode)463:
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Http_CONNECT_TC_FAILURE, "Connect to TC failure.");
					}
					break;
				}
			}
			else
			{
				switch (statusCode)
				{
				case (global::System.Net.HttpStatusCode)471:
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Http_LICENSE_MNIS_FAILURE, "MNIS license operation failed.");
				case (global::System.Net.HttpStatusCode)472:
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Http_CONFIG_MNIS_FAILURE, "MNIS config update failed.");
				default:
					switch (statusCode)
					{
					case (global::System.Net.HttpStatusCode)481:
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Http_LICENSE_UEM_FAILURE, "UEM license operation failed.");
					case (global::System.Net.HttpStatusCode)482:
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Http_CONFIG_UEM_FAILURE, "UEM config update failed (FUTURE).");
					default:
						switch (statusCode)
						{
						case (global::System.Net.HttpStatusCode)491:
							throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Http_IP_CHANGE_FAILURE, "IP address change failed.");
						case (global::System.Net.HttpStatusCode)492:
							throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Http_NTP_CHANGE_FAILURE, "NTP address change failure.");
						}
						break;
					}
					break;
				}
			}
			base.HandleResponseStatusCode(response);
		}
	}
}
