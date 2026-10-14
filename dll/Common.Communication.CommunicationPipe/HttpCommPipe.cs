using System;
using System.Globalization;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Motorola.Common.CustomException;
using VerifyUtility;

namespace Motorola.Common.Communication.CommunicationPipe
{
	// Token: 0x0200000A RID: 10
	public class HttpCommPipe : global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe, global::System.IDisposable
	{
		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600004E RID: 78 RVA: 0x00002C68 File Offset: 0x00000E68
		// (set) Token: 0x0600004F RID: 79 RVA: 0x00002C75 File Offset: 0x00000E75
		public bool UseCookies
		{
			get
			{
				return this.clientHandler.UseCookies;
			}
			set
			{
				this.clientHandler.UseCookies = value;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000050 RID: 80 RVA: 0x00002C83 File Offset: 0x00000E83
		public global::System.Uri RootUrl
		{
			get
			{
				return this.client.BaseAddress;
			}
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002C90 File Offset: 0x00000E90
		static HttpCommPipe()
		{
			global::VerifyUtility.AssemblyValidator.IsCallerAuthorized();
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002C98 File Offset: 0x00000E98
		public HttpCommPipe(string rootUrl)
		{
			this.clientHandler = new global::System.Net.Http.WebRequestHandler();
			this.client = new global::System.Net.Http.HttpClient(this.clientHandler);
			this.client.Timeout = new global::System.TimeSpan(1, 0, 0);
			this.client.DefaultRequestHeaders.ExpectContinue = new bool?(false);
			this.clientHandler.UseCookies = true;
			this.clientHandler.CookieContainer = new global::System.Net.CookieContainer();
			this.clientHandler.ServerCertificateValidationCallback = new global::System.Net.Security.RemoteCertificateValidationCallback(this.ValidateServerCertificate);
			this.SetRootUrl(rootUrl);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002D2A File Offset: 0x00000F2A
		public HttpCommPipe(global::System.Uri rootUrl) : this(rootUrl.ToString())
		{
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002D38 File Offset: 0x00000F38
		private void SetRootUrl(string rootUrl)
		{
			if (!rootUrl.EndsWith("/", global::System.StringComparison.Ordinal))
			{
				rootUrl += "/";
			}
			this.client.BaseAddress = new global::System.Uri(rootUrl);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002D66 File Offset: 0x00000F66
		public void ClearCookies()
		{
			this.clientHandler.CookieContainer = new global::System.Net.CookieContainer();
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00002D78 File Offset: 0x00000F78
		public void ForceBasicAuthenticationCredentials(string userName, string password)
		{
			string parameter = global::Motorola.Common.Communication.CommunicationPipe.HttpCommPipe.EncodeCredentialsToBasic(userName, password);
			this.client.DefaultRequestHeaders.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue("Basic", parameter);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00002DA8 File Offset: 0x00000FA8
		public void ClearBasicAuthenticationCredentials()
		{
			this.client.DefaultRequestHeaders.Authorization = null;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00002DBC File Offset: 0x00000FBC
		private static string EncodeCredentialsToBasic(string username, string password)
		{
			string s = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "{0}:{1}", new object[]
			{
				username,
				password
			});
			byte[] bytes = global::System.Text.Encoding.ASCII.GetBytes(s);
			return global::System.Convert.ToBase64String(bytes);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002DFB File Offset: 0x00000FFB
		public void AddClientCertificate(global::System.Security.Cryptography.X509Certificates.X509Certificate cert)
		{
			this.clientHandler.ClientCertificates.Add(cert);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00002E0F File Offset: 0x0000100F
		public void UseManualCertificates(bool useManual)
		{
			if (useManual)
			{
				this.clientHandler.ClientCertificateOptions = global::System.Net.Http.ClientCertificateOption.Manual;
				return;
			}
			this.clientHandler.ClientCertificateOptions = global::System.Net.Http.ClientCertificateOption.Automatic;
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600005B RID: 91 RVA: 0x00002E2D File Offset: 0x0000102D
		// (set) Token: 0x0600005C RID: 92 RVA: 0x00002E35 File Offset: 0x00001035
		public int ReceiveTimeout { get; set; }

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600005D RID: 93 RVA: 0x00002E3E File Offset: 0x0000103E
		// (set) Token: 0x0600005E RID: 94 RVA: 0x00002E46 File Offset: 0x00001046
		public bool IsOpen { get; set; }

		// Token: 0x0600005F RID: 95 RVA: 0x00002E4F File Offset: 0x0000104F
		public void OpenPort(int timeout)
		{
			this.IsOpen = true;
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00002E58 File Offset: 0x00001058
		public void ClosePort()
		{
			this.IsOpen = false;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00002E61 File Offset: 0x00001061
		public void SendData(byte[] buffer, int start, int length)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00002E68 File Offset: 0x00001068
		public byte[] ReceiveData()
		{
			return this.ReceiveData(this.ReceiveTimeout);
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00002E76 File Offset: 0x00001076
		public byte[] ReceiveData(int timeout)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00002E7D File Offset: 0x0000107D
		public int ReceiveData(byte[] buffer, int start)
		{
			return this.ReceiveData(buffer, start, this.ReceiveTimeout);
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00002E8D File Offset: 0x0000108D
		public int ReceiveData(byte[] buffer, int start, int timeout)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00002E94 File Offset: 0x00001094
		public int ReceiveData(byte[] buffer, int start, int timeout, int expectedlength)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00002E9B File Offset: 0x0000109B
		public byte[] RequestData(byte[] buffer, int start, int length)
		{
			return this.RequestData(buffer, start, length, this.ReceiveTimeout);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00002EAC File Offset: 0x000010AC
		public byte[] RequestData(byte[] buffer, int start, int length, int timeout)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00002EB4 File Offset: 0x000010B4
		public global::System.Net.Http.HttpResponseMessage RequestData(global::System.Net.Http.HttpRequestMessage request, int timeout)
		{
			global::System.Threading.CancellationTokenSource cancellationTokenSource = this.newOneCancellationTokenSource();
			global::System.Threading.Tasks.Task<global::System.Net.Http.HttpResponseMessage> task = this.client.SendAsync(request, cancellationTokenSource.Token);
			bool flag = false;
			try
			{
				flag = task.Wait(timeout);
			}
			catch (global::System.AggregateException ex)
			{
				task.Dispose();
				cancellationTokenSource.Dispose();
				throw ex.InnerException;
			}
			if (flag)
			{
				global::System.Net.Http.HttpResponseMessage result = task.Result;
				task.Dispose();
				cancellationTokenSource.Dispose();
				return result;
			}
			cancellationTokenSource.Cancel();
			task.Dispose();
			cancellationTokenSource.Dispose();
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.HttpRequestTimeout, "HttpCommPipe RequestData timeout");
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00002F48 File Offset: 0x00001148
		public byte[] PeekData(int length, int timeOut)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600006B RID: 107 RVA: 0x00002F4F File Offset: 0x0000114F
		public int AvailableReadBytesCount
		{
			get
			{
				throw new global::System.NotSupportedException();
			}
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00002F56 File Offset: 0x00001156
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00002F65 File Offset: 0x00001165
		protected virtual void Dispose(bool isDisposing)
		{
			if (!this.m_IsDisposed)
			{
				if (isDisposing)
				{
					this.ClosePort();
					this.clientHandler.Dispose();
					this.client.Dispose();
				}
				this.m_IsDisposed = true;
			}
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00002F95 File Offset: 0x00001195
		private bool ValidateServerCertificate(object sender, global::System.Security.Cryptography.X509Certificates.X509Certificate certificate, global::System.Security.Cryptography.X509Certificates.X509Chain chain, global::System.Net.Security.SslPolicyErrors errors)
		{
			return true;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00002F98 File Offset: 0x00001198
		private global::System.Threading.CancellationTokenSource newOneCancellationTokenSource()
		{
			return new global::System.Threading.CancellationTokenSource();
		}

		// Token: 0x04000033 RID: 51
		private global::System.Net.Http.HttpClient client;

		// Token: 0x04000034 RID: 52
		private global::System.Net.Http.WebRequestHandler clientHandler;

		// Token: 0x04000035 RID: 53
		private bool m_IsDisposed;
	}
}
