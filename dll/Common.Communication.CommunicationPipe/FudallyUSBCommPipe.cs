using System;
using System.Threading;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe.Fudally;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.CommunicationPipe
{
	// Token: 0x02000005 RID: 5
	public class FudallyUSBCommPipe : global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe, global::System.IDisposable
	{
		// Token: 0x06000014 RID: 20 RVA: 0x00002245 File Offset: 0x00000445
		public FudallyUSBCommPipe(string pathName)
		{
			if (string.IsNullOrEmpty(pathName))
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
			}
			this.path = pathName;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002280 File Offset: 0x00000480
		~FudallyUSBCommPipe()
		{
			this.Dispose(false);
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000016 RID: 22 RVA: 0x000022B0 File Offset: 0x000004B0
		// (set) Token: 0x06000017 RID: 23 RVA: 0x000022B7 File Offset: 0x000004B7
		public int ReceiveTimeout
		{
			get
			{
				return 1500;
			}
			set
			{
				this.ReceiveTimeout = 1500;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000018 RID: 24 RVA: 0x000022C4 File Offset: 0x000004C4
		// (set) Token: 0x06000019 RID: 25 RVA: 0x000022CC File Offset: 0x000004CC
		public bool IsOpen { get; set; }

		// Token: 0x0600001A RID: 26 RVA: 0x000022D8 File Offset: 0x000004D8
		public void OpenPort(int timeout)
		{
			if (this.port != null)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeAlreadyOpened);
			}
			try
			{
				this.port = new global::Motorola.Common.Communication.CommunicationPipe.Fudally.FudallyUSBPort();
				if (!this.port.Open(this.path))
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeOpenFailure);
				}
			}
			catch (global::Motorola.Common.CustomException.CommonException)
			{
				throw;
			}
			catch (global::System.Exception)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeOpenFailure);
			}
			this.IsOpen = true;
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002358 File Offset: 0x00000558
		public void ClosePort()
		{
			if (this.port != null)
			{
				this.port.Close();
				this.port = null;
			}
			this.IsOpen = false;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x0000237C File Offset: 0x0000057C
		public void SendData(byte[] buffer, int start, int length)
		{
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(this.port, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeNotOpened);
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(buffer, global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
			if (length <= 0)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgument);
			}
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.ValidateArrayStartLength<byte>(buffer, start, length);
			int num = length + 5;
			if (this.sendDataBuffer.Length < num)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentOutOfRange);
			}
			byte[] array = global::Motorola.Common.Communication.CommunicationPipe.FudallyUSBCommPipe.CreateSBEPPacket(buffer, length);
			int num2 = 3;
			while (num2-- > 0)
			{
				try
				{
					int i = 0;
					byte[] array2 = new byte[num];
					global::System.Array.Copy(array, array2, array.Length);
					while (i < num)
					{
						uint num3 = (uint)(array2.Length + 13);
						int num4 = this.port.Write(array2, 2500U + num3 + 50U);
						if (num4 <= 0)
						{
							if (num4 == -2)
							{
								throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeWriteTimeout);
							}
							throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeWriteFailure);
						}
						else
						{
							i += num4;
							global::System.Array.Clear(array2, 0, array2.Length);
							int num5 = num - i;
							if (num5 > 0)
							{
								global::System.Array.Copy(array, i, array2, 0, num5);
							}
						}
					}
					break;
				}
				catch (global::System.Exception ex)
				{
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Fudally Send Data failed", new object[0]);
					if (num2 == 0)
					{
						if (ex is global::Motorola.Common.CustomException.CommonException)
						{
							throw;
						}
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeWriteFailure, ex);
					}
					else
					{
						global::System.Threading.Thread.Sleep(1000);
					}
				}
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600001D RID: 29 RVA: 0x000024C0 File Offset: 0x000006C0
		public int AvailableReadBytesCount
		{
			get
			{
				throw new global::System.NotSupportedException();
			}
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000024C7 File Offset: 0x000006C7
		public byte[] ReceiveData()
		{
			return this.ReceiveData(this.ReceiveTimeout);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000024D8 File Offset: 0x000006D8
		public byte[] ReceiveData(int timeout)
		{
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(this.port, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeNotOpened);
			byte[] result;
			try
			{
				byte[] array = new byte[1500];
				int num = 0;
				int dataLength = this.GetDataLength(ref array, ref num, timeout);
				if (array == null || num <= 0)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeReadFailure);
				}
				if (num > 1500)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeReceivedDataLengthGreaterThanExpectedLength);
				}
				int num2 = dataLength + 4;
				byte[] array2 = new byte[num];
				global::System.Array.Copy(array, array2, num);
				byte[] array3 = new byte[dataLength - 1];
				if (num < num2)
				{
					byte[] array4 = this.RxData(array2, array3, 0, timeout, num2);
					if (array4 == null)
					{
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeReadFailure);
					}
					int num3 = array4.Length;
					if (num3 + 5 > 1500)
					{
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeReceivedDataLengthGreaterThanExpectedLength);
					}
					result = array4;
				}
				else
				{
					global::System.Array.Copy(array2, 4, array3, 0, dataLength - 1);
					result = array3;
				}
			}
			catch (global::Motorola.Common.CustomException.CommonException systemException)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeReceiveDataFailure, systemException);
			}
			return result;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x000025CC File Offset: 0x000007CC
		public int ReceiveData(byte[] buffer, int start)
		{
			return this.ReceiveData(buffer, start, this.ReceiveTimeout);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000025DC File Offset: 0x000007DC
		public int ReceiveData(byte[] buffer, int start, int timeout)
		{
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(this.port, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeNotOpened);
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(buffer, global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
			int result;
			try
			{
				byte[] array = new byte[1500];
				int num = 0;
				int dataLength = this.GetDataLength(ref array, ref num, timeout);
				if (array == null || num <= 0 || num > 1500)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeReadFailure);
				}
				global::Motorola.Common.Communication.CommonUtil.UtilityMethods.ValidateArrayStartLength<byte>(buffer, start, dataLength - 1);
				int num2 = dataLength + 4;
				byte[] array2 = new byte[num];
				global::System.Array.Copy(array, array2, num);
				if (num < num2)
				{
					byte[] array3 = this.RxData(array2, buffer, start, timeout, num2);
					if (array3 == null)
					{
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeReadFailure);
					}
					int num3 = array3.Length;
					if (num3 + 5 > 1500)
					{
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeReceivedDataLengthGreaterThanExpectedLength);
					}
					result = num3;
				}
				else
				{
					global::System.Array.Copy(array2, 4, buffer, start, dataLength - 1);
					result = dataLength - 1;
				}
			}
			catch (global::Motorola.Common.CustomException.CommonException systemException)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeReceiveDataFailure, systemException);
			}
			return result;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000026CC File Offset: 0x000008CC
		public int ReceiveData(byte[] buffer, int start, int timeout, int expectedlength)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000026D3 File Offset: 0x000008D3
		public byte[] RequestData(byte[] buffer, int start, int length)
		{
			return this.RequestData(buffer, start, length, this.ReceiveTimeout);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000026E4 File Offset: 0x000008E4
		public byte[] RequestData(byte[] buffer, int start, int length, int timeout)
		{
			this.SendData(buffer, start, length);
			return this.ReceiveData(timeout);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000026F7 File Offset: 0x000008F7
		public byte[] PeekData(int length, int timeOut)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002700 File Offset: 0x00000900
		private static byte[] CreateSBEPPacket(byte[] data, int len)
		{
			byte[] array = new byte[len + 5];
			global::System.Array.Copy(data, 0, array, 4, len);
			len++;
			array[0] = byte.MaxValue;
			array[1] = 49;
			array[2] = (byte)(len >> 8 & 255);
			array[3] = (byte)(len & 255);
			byte b = 0;
			for (int i = 0; i < len + 4 - 1; i++)
			{
				b += array[i];
			}
			array[len + 4 - 1] = (b ^ byte.MaxValue);
			return array;
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002774 File Offset: 0x00000974
		private int GetDataLength(ref byte[] databuffer, ref int bytesRead, int timeout)
		{
			byte[] array = new byte[4];
			int num = this.port.Read(databuffer, (uint)timeout);
			if (databuffer == null || num <= 0)
			{
				if (num == -2)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeReadTimeout);
				}
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeReadFailure);
			}
			else
			{
				global::System.Array.Copy(databuffer, array, 4);
				if (num < array.Length)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeInvalidPacketHeader);
				}
				bytesRead = num;
				return ((int)array[2] << 8) + (int)array[3];
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000027E4 File Offset: 0x000009E4
		private byte[] RxData(byte[] dataRecieved, byte[] buffer, int start, int timeout, int PacketSize)
		{
			int num = dataRecieved.Length;
			int num2 = dataRecieved.Length;
			int i = PacketSize - num;
			byte[] array = new byte[1500];
			while (i > 0)
			{
				num = this.port.Read(array, (uint)timeout);
				if (array == null || num <= 0)
				{
					if (num == -2)
					{
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeReadTimeout);
					}
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeReadFailure);
				}
				else
				{
					global::System.Array.Copy(array, 0, dataRecieved, num2, num);
					global::System.Array.Clear(array, 0, array.Length);
					num2 += num;
					i -= num;
				}
			}
			if (num2 <= 0 || dataRecieved == null || num2 < PacketSize)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeReadFailure);
			}
			global::System.Array.Copy(dataRecieved, 4, buffer, start, num2 - 5);
			byte[] array2 = new byte[num2 - 5];
			global::System.Array.Copy(dataRecieved, 4, array2, 0, num2 - 5);
			return array2;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002898 File Offset: 0x00000A98
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000028A7 File Offset: 0x00000AA7
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

		// Token: 0x04000012 RID: 18
		private const int MAXREADPACKETSIZE = 906;

		// Token: 0x04000013 RID: 19
		private const int MAXWRITEPACKETSIZE = 907;

		// Token: 0x04000014 RID: 20
		private const int ERASE_TIMEOUT_PER_64K = 1200;

		// Token: 0x04000015 RID: 21
		private const int ERASE_TIMEOUT_CONSTANT = 3200;

		// Token: 0x04000016 RID: 22
		private const int CONST_TIMEOUT_TIME = 1500;

		// Token: 0x04000017 RID: 23
		private const int WRITE_TIMEOUT_CONSTANT = 2500;

		// Token: 0x04000018 RID: 24
		private const int MaxPacketSize = 1500;

		// Token: 0x04000019 RID: 25
		private string path = string.Empty;

		// Token: 0x0400001A RID: 26
		private global::Motorola.Common.Communication.CommunicationPipe.Fudally.FudallyUSBPort port;

		// Token: 0x0400001B RID: 27
		private readonly byte[] sendDataBuffer = new byte[1500];

		// Token: 0x0400001C RID: 28
		private bool m_IsDisposed;
	}
}
