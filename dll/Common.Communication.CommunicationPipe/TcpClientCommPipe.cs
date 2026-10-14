using System;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Security;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.TetraUtility;
using Motorola.Common.CustomException;
using VerifyUtility;

namespace Motorola.Common.Communication.CommunicationPipe
{
	// Token: 0x02000019 RID: 25
	public class TcpClientCommPipe : global::Motorola.Common.Communication.CommunicationPipe.TcpCommPipe
	{
		// Token: 0x06000166 RID: 358 RVA: 0x0000600A File Offset: 0x0000420A
		static TcpClientCommPipe()
		{
			global::VerifyUtility.AssemblyValidator.IsCallerAuthorized();
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00006012 File Offset: 0x00004212
		public TcpClientCommPipe(global::System.Net.IPAddress ipAddress, int portNumber, int receiveTimeout, bool noDelay)
		{
			if (portNumber < 0 || portNumber > 65535)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentOutOfRange);
			}
			this.m_IPAddress = ipAddress;
			this.m_PortNumber = portNumber;
			this.m_NoDelay = noDelay;
			base.ReceiveTimeout = receiveTimeout;
		}

		// Token: 0x06000168 RID: 360 RVA: 0x0000604A File Offset: 0x0000424A
		public TcpClientCommPipe(global::System.Net.IPAddress ipAddress, int portNumber, bool noDelay) : this(ipAddress, portNumber, 2000, noDelay)
		{
		}

		// Token: 0x06000169 RID: 361 RVA: 0x0000605C File Offset: 0x0000425C
		public override void OpenPort(int timeout)
		{
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(string.Concat(new object[]
			{
				"TCP OpenPort: ",
				this.m_IPAddress,
				":",
				this.m_PortNumber
			}), new object[0]);
			if (base.Client != null || base.Stream != null)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeAlreadyOpened);
			}
			base.Client = new global::System.Net.Sockets.TcpClient();
			base.Client.NoDelay = this.m_NoDelay;
			if (timeout <= 0)
			{
				timeout = 15000;
			}
			try
			{
				global::System.IAsyncResult asyncResult = base.Client.BeginConnect(this.m_IPAddress, this.m_PortNumber, null, null);
				while (timeout > 0)
				{
					if (asyncResult.AsyncWaitHandle.WaitOne(5000))
					{
						base.Client.EndConnect(asyncResult);
						break;
					}
					timeout -= 5000;
					if (timeout <= 0)
					{
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeOpenTimeout);
					}
					global::System.Diagnostics.Trace.WriteLine("The connection is timeouted, try one more time...");
				}
			}
			catch (global::System.Net.Sockets.SocketException systemException)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeOpenFailure, systemException);
			}
			catch (global::System.Security.SecurityException systemException2)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeOpenFailure, systemException2);
			}
			int num = 90;
			if (!global::Motorola.Common.Communication.TetraUtility.WinAPIWrapper.SetSockOpt(base.Client.Client.Handle, 6, 5, ref num))
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Set TCP_MAXRT failed.", new object[0]);
			}
			base.Stream = base.Client.GetStream();
			this.IsOpen = true;
		}

		// Token: 0x040000AB RID: 171
		private const int TCP_MAXRT = 5;

		// Token: 0x040000AC RID: 172
		private const int IPPROTO_TCP = 6;

		// Token: 0x040000AD RID: 173
		private global::System.Net.IPAddress m_IPAddress;

		// Token: 0x040000AE RID: 174
		private int m_PortNumber;

		// Token: 0x040000AF RID: 175
		private bool m_NoDelay;
	}
}
