using System;
using System.IO;
using System.Net.Sockets;
using System.Security;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.CustomException;
using VerifyUtility;

namespace Motorola.Common.Communication.CommunicationPipe
{
	// Token: 0x02000018 RID: 24
	public abstract class TcpCommPipe : global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe, global::System.IDisposable
	{
		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000147 RID: 327 RVA: 0x000059FE File Offset: 0x00003BFE
		// (set) Token: 0x06000148 RID: 328 RVA: 0x00005A06 File Offset: 0x00003C06
		public int ReceiveTimeout { get; set; }

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000149 RID: 329 RVA: 0x00005A0F File Offset: 0x00003C0F
		// (set) Token: 0x0600014A RID: 330 RVA: 0x00005A1A File Offset: 0x00003C1A
		internal bool needExtractHeader
		{
			private get
			{
				return this.PacketHeaderSize == 2;
			}
			set
			{
				if (!value)
				{
					this.PacketHeaderSize = 0;
					return;
				}
				this.PacketHeaderSize = 2;
			}
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00005A2E File Offset: 0x00003C2E
		static TcpCommPipe()
		{
			global::VerifyUtility.AssemblyValidator.IsCallerAuthorized();
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00005A36 File Offset: 0x00003C36
		public TcpCommPipe()
		{
			this.needExtractHeader = true;
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x0600014D RID: 333 RVA: 0x00005A5C File Offset: 0x00003C5C
		private bool Connected
		{
			get
			{
				return this.Client != null && this.Client.Connected;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x0600014E RID: 334 RVA: 0x00005A73 File Offset: 0x00003C73
		// (set) Token: 0x0600014F RID: 335 RVA: 0x00005A7B File Offset: 0x00003C7B
		protected global::System.Net.Sockets.TcpClient Client { get; set; }

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000150 RID: 336 RVA: 0x00005A84 File Offset: 0x00003C84
		// (set) Token: 0x06000151 RID: 337 RVA: 0x00005A8C File Offset: 0x00003C8C
		protected global::System.Net.Sockets.NetworkStream Stream { get; set; }

		// Token: 0x06000152 RID: 338 RVA: 0x00005A98 File Offset: 0x00003C98
		~TcpCommPipe()
		{
			this.Dispose(false);
		}

		// Token: 0x06000153 RID: 339
		public abstract void OpenPort(int timeout);

		// Token: 0x06000154 RID: 340 RVA: 0x00005AC8 File Offset: 0x00003CC8
		public virtual void ClosePort()
		{
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("TCP ClosePort!", new object[0]);
			if (this.Stream != null)
			{
				this.Stream.Dispose();
				this.Stream = null;
			}
			if (this.Client != null)
			{
				this.Client.Close();
				this.Client = null;
			}
			this.IsOpen = false;
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00005B28 File Offset: 0x00003D28
		public virtual void SendData(byte[] buffer, int start, int length)
		{
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.ValidateArrayStartLength<byte>(buffer, start, length);
			if (this.sendDataBuffer.Length < length + this.PacketHeaderSize)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentOutOfRange);
			}
			lock (this.sendDataBuffer.SyncRoot)
			{
				if (this.needExtractHeader)
				{
					this.sendDataBuffer[0] = (byte)(length >> 8);
					this.sendDataBuffer[1] = (byte)(length & 255);
				}
				global::System.Buffer.BlockCopy(buffer, start, this.sendDataBuffer, this.PacketHeaderSize, length);
				this.SendDataToBaseStream(this.sendDataBuffer, 0, length + this.PacketHeaderSize);
			}
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00005BD8 File Offset: 0x00003DD8
		public byte[] ReceiveData()
		{
			return this.ReceiveData(this.ReceiveTimeout);
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00005BE8 File Offset: 0x00003DE8
		public virtual byte[] ReceiveData(int timeout)
		{
			if (this.Stream != null && this.Stream.CanTimeout && timeout > 0)
			{
				this.Stream.ReadTimeout = timeout;
			}
			int num = 0;
			if (timeout > 0)
			{
				num = this.ReceiveTimeout;
				this.ReceiveTimeout = timeout;
			}
			byte[] array = null;
			int num2;
			if (this.needExtractHeader)
			{
				num2 = this.ReceivePacketSize();
			}
			else
			{
				num2 = this.AvailableReadBytesCount;
			}
			if (num2 > 0)
			{
				array = new byte[num2];
				this.ReceiveDataFromBaseStream(array, 0, num2);
			}
			if (num > 0)
			{
				this.ReceiveTimeout = num;
			}
			return array;
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00005C6B File Offset: 0x00003E6B
		public byte[] RequestData(byte[] buffer, int start, int length)
		{
			return this.RequestData(buffer, start, length, this.ReceiveTimeout);
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00005C7C File Offset: 0x00003E7C
		public byte[] RequestData(byte[] buffer, int start, int length, int timeout)
		{
			byte[] result = null;
			try
			{
				this.SendData(buffer, start, length);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Request Data(send) failed: " + ex.Message, new object[0]);
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Tx: Len={0} {1}", new object[]
				{
					length,
					global::Motorola.Common.Communication.CommonUtil.UtilityMethods.ToHexString(buffer, start, length, false)
				});
				throw;
			}
			try
			{
				result = this.ReceiveData(timeout);
			}
			catch (global::System.Exception ex2)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Request Data(receive) failed: " + ex2.Message, new object[0]);
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Tx: Len={0} {1}", new object[]
				{
					length,
					global::Motorola.Common.Communication.CommonUtil.UtilityMethods.ToHexString(buffer, start, length, false)
				});
				throw;
			}
			return result;
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00005D60 File Offset: 0x00003F60
		public int ReceiveData(byte[] buffer, int start)
		{
			return this.ReceiveData(buffer, start, this.ReceiveTimeout);
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00005D70 File Offset: 0x00003F70
		public virtual int ReceiveData(byte[] buffer, int start, int timeout)
		{
			if (buffer == null)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
			}
			if (this.Stream != null && this.Stream.CanTimeout && timeout > 0)
			{
				this.Stream.ReadTimeout = timeout;
			}
			int length;
			if (this.needExtractHeader)
			{
				length = this.ReceivePacketSize();
			}
			else
			{
				length = this.AvailableReadBytesCount;
			}
			return this.ReceiveDataFromBaseStream(buffer, start, length);
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00005DD0 File Offset: 0x00003FD0
		public virtual int ReceiveData(byte[] buffer, int start, int timeout, int expectedlength)
		{
			if (this.Stream != null && this.Stream.CanTimeout && timeout > 0)
			{
				this.Stream.ReadTimeout = timeout;
			}
			int num = 0;
			if (timeout > 0)
			{
				num = this.ReceiveTimeout;
				this.ReceiveTimeout = timeout;
			}
			int result = this.ReceiveDataFromBaseStream(buffer, start, expectedlength);
			if (num > 0)
			{
				this.ReceiveTimeout = num;
			}
			return result;
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00005E30 File Offset: 0x00004030
		public byte[] PeekData(int length, int timeOut)
		{
			byte[] result;
			try
			{
				byte[] array = new byte[length];
				this.Client.Client.ReceiveTimeout = timeOut;
				this.Client.Client.Receive(array, length, global::System.Net.Sockets.SocketFlags.Peek);
				result = array;
			}
			catch (global::System.ArgumentOutOfRangeException systemException)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentOutOfRange, systemException);
			}
			catch (global::System.Net.Sockets.SocketException systemException2)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipePeekFailure, systemException2);
			}
			catch (global::System.Security.SecurityException systemException3)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipePeekFailure, systemException3);
			}
			return result;
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x0600015E RID: 350 RVA: 0x00005EBC File Offset: 0x000040BC
		public virtual int AvailableReadBytesCount
		{
			get
			{
				return this.Client.Available;
			}
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00005ECC File Offset: 0x000040CC
		protected virtual void SendDataToBaseStream(byte[] buffer, int start, int length)
		{
			if (this.Stream == null)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeNotOpened);
			}
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.ValidateArrayStartLength<byte>(buffer, start, length);
			try
			{
				this.Stream.Write(buffer, start, length);
			}
			catch (global::System.IO.IOException systemException)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeWriteFailure, systemException);
			}
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00005F24 File Offset: 0x00004124
		protected virtual int ReceivePacketSize()
		{
			byte[] array = new byte[2];
			int num = this.ReceiveDataFromBaseStream(array, 0, array.Length);
			if (num > 0)
			{
				int num2 = (int)array[0] << 8;
				return num2 + (int)array[1];
			}
			return 0;
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00005F58 File Offset: 0x00004158
		protected virtual int ReceiveDataFromBaseStream(byte[] buffer, int start, int length)
		{
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.ValidateArrayStartLength<byte>(buffer, start, length);
			int num = start;
			try
			{
				for (;;)
				{
					int num2 = this.Stream.Read(buffer, num, length - num);
					if (num2 <= 0)
					{
						break;
					}
					num += num2;
					if (num >= length)
					{
						goto Block_3;
					}
				}
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeUnexpectedEndOfConnection);
				Block_3:;
			}
			catch (global::System.IO.IOException systemException)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeReadFailure, systemException);
			}
			catch (global::System.ArgumentOutOfRangeException systemException2)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentOutOfRange, systemException2);
			}
			return num;
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00005FD0 File Offset: 0x000041D0
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00005FDF File Offset: 0x000041DF
		protected virtual void Dispose(bool isDisposing)
		{
			if (!this.m_IsDisposed)
			{
				if (isDisposing)
				{
					this.ClosePort();
				}
				this.m_IsDisposed = true;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000164 RID: 356 RVA: 0x00005FF9 File Offset: 0x000041F9
		// (set) Token: 0x06000165 RID: 357 RVA: 0x00006001 File Offset: 0x00004201
		public virtual bool IsOpen { get; set; }

		// Token: 0x040000A3 RID: 163
		private const int MaxPacketSize = 25000;

		// Token: 0x040000A4 RID: 164
		private int PacketHeaderSize = 2;

		// Token: 0x040000A5 RID: 165
		private readonly byte[] sendDataBuffer = new byte[25000];

		// Token: 0x040000A6 RID: 166
		private bool m_IsDisposed;
	}
}
