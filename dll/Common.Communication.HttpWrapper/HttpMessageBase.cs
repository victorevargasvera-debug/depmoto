using System;
using System.Net;
using System.Net.Http;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication
{
	// Token: 0x02000005 RID: 5
	public class HttpMessageBase : global::Motorola.Common.Communication.BaseMessage
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000006 RID: 6 RVA: 0x00002194 File Offset: 0x00000394
		// (set) Token: 0x06000007 RID: 7 RVA: 0x0000219C File Offset: 0x0000039C
		public global::System.Net.Http.HttpRequestMessage RequestMessage { get; private set; }

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000008 RID: 8 RVA: 0x000021A5 File Offset: 0x000003A5
		// (set) Token: 0x06000009 RID: 9 RVA: 0x000021AD File Offset: 0x000003AD
		public global::System.Net.Http.HttpResponseMessage ResponseMessage { get; private set; }

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000A RID: 10 RVA: 0x000021B6 File Offset: 0x000003B6
		public global::System.Net.HttpStatusCode ResultCode
		{
			get
			{
				return this.ResponseMessage.StatusCode;
			}
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000021C3 File Offset: 0x000003C3
		protected HttpMessageBase(global::System.Net.Http.HttpMethod method, global::System.Uri relativePath)
		{
			this.RequestMessage = new global::System.Net.Http.HttpRequestMessage(method, relativePath);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000021D8 File Offset: 0x000003D8
		protected HttpMessageBase(global::System.Net.Http.HttpMethod method, string relativePath)
		{
			this.RequestMessage = new global::System.Net.Http.HttpRequestMessage(method, relativePath);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000021ED File Offset: 0x000003ED
		public override int BuildCommandMessage(byte[] sendBuffer)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000021F4 File Offset: 0x000003F4
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			base._myReplyBuffer = new byte[length];
			global::System.Array.Copy(replyBuffer, 0, base._myReplyBuffer, offset, length);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002211 File Offset: 0x00000411
		public virtual void HandleResponse(global::System.Net.Http.HttpResponseMessage response)
		{
			this.ResponseMessage = response;
			this.HandleResponseStatusCode(response);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002221 File Offset: 0x00000421
		protected virtual void HandleResponseStatusCode(global::System.Net.Http.HttpResponseMessage response)
		{
			if (!response.IsSuccessStatusCode)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.HttpReplyUnexpectedStatus, "Unexpected HTTP response status code: " + (int)response.StatusCode);
			}
		}
	}
}
