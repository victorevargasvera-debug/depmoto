using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.RUDP.Helper;
using Motorola.Common.Communication.RUDP.States;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.RUDP
{
	// Token: 0x02000008 RID: 8
	internal class RUDPConnection
	{
		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000029 RID: 41 RVA: 0x000027B7 File Offset: 0x000009B7
		// (set) Token: 0x0600002A RID: 42 RVA: 0x000027BF File Offset: 0x000009BF
		public ushort INIT_SENT_SEQN
		{
			get
			{
				return this._INIT_SENT_SEQN;
			}
			private set
			{
				this._INIT_SENT_SEQN = value;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600002B RID: 43 RVA: 0x000027C8 File Offset: 0x000009C8
		// (set) Token: 0x0600002C RID: 44 RVA: 0x000027D0 File Offset: 0x000009D0
		public ushort LAST_SENT_SEQN
		{
			get
			{
				return this._LAST_SENT_SEQN;
			}
			set
			{
				this._LAST_SENT_SEQN = value;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600002D RID: 45 RVA: 0x000027D9 File Offset: 0x000009D9
		// (set) Token: 0x0600002E RID: 46 RVA: 0x000027E1 File Offset: 0x000009E1
		public ushort NEXT_SENT_SEQN
		{
			get
			{
				return this._NEXT_SENT_SEQN;
			}
			set
			{
				this._NEXT_SENT_SEQN = value;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600002F RID: 47 RVA: 0x000027EA File Offset: 0x000009EA
		// (set) Token: 0x06000030 RID: 48 RVA: 0x000027F2 File Offset: 0x000009F2
		public ushort INIT_RCVD_SEQN
		{
			private get
			{
				return this._INIT_RCVD_SEQN;
			}
			set
			{
				this._INIT_RCVD_SEQN = value;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000031 RID: 49 RVA: 0x000027FB File Offset: 0x000009FB
		// (set) Token: 0x06000032 RID: 50 RVA: 0x00002803 File Offset: 0x00000A03
		public ushort LAST_RCVD_SEQN
		{
			get
			{
				return this._LAST_RCVD_SEQN;
			}
			set
			{
				this._LAST_RCVD_SEQN = value;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000033 RID: 51 RVA: 0x0000280C File Offset: 0x00000A0C
		// (set) Token: 0x06000034 RID: 52 RVA: 0x00002814 File Offset: 0x00000A14
		public int LAST_SENT_TIME
		{
			get
			{
				return this._LAST_SENT_TIME;
			}
			set
			{
				this._LAST_SENT_TIME = value;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000035 RID: 53 RVA: 0x0000281D File Offset: 0x00000A1D
		// (set) Token: 0x06000036 RID: 54 RVA: 0x00002825 File Offset: 0x00000A25
		public global::Motorola.Common.Communication.RUDP.RUDPPacket LAST_SENT_PACKET
		{
			get
			{
				return this._LAST_SENT_PACKET;
			}
			set
			{
				this._LAST_SENT_PACKET = value;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000037 RID: 55 RVA: 0x0000282E File Offset: 0x00000A2E
		public global::Motorola.Common.Communication.RUDP.RUDPSockState SockState
		{
			get
			{
				return this._state.SockState;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000038 RID: 56 RVA: 0x0000283B File Offset: 0x00000A3B
		// (set) Token: 0x06000039 RID: 57 RVA: 0x00002843 File Offset: 0x00000A43
		public int SendTimeout
		{
			get
			{
				return this._sendTimeout;
			}
			set
			{
				this._sendTimeout = value;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600003A RID: 58 RVA: 0x0000284C File Offset: 0x00000A4C
		// (set) Token: 0x0600003B RID: 59 RVA: 0x00002854 File Offset: 0x00000A54
		public int ReceiveTimeout
		{
			get
			{
				return this._receiveTimeout;
			}
			set
			{
				this._receiveTimeout = value;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600003C RID: 60 RVA: 0x0000285D File Offset: 0x00000A5D
		// (set) Token: 0x0600003D RID: 61 RVA: 0x00002865 File Offset: 0x00000A65
		public int OpenTimeout
		{
			get
			{
				return this._openTimeout;
			}
			set
			{
				this._openTimeout = value;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600003E RID: 62 RVA: 0x0000286E File Offset: 0x00000A6E
		// (set) Token: 0x0600003F RID: 63 RVA: 0x00002876 File Offset: 0x00000A76
		public int CloseTimeout
		{
			get
			{
				return this._closeTimeout;
			}
			set
			{
				this._closeTimeout = value;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000040 RID: 64 RVA: 0x0000287F File Offset: 0x00000A7F
		private global::System.Net.IPAddress IP
		{
			get
			{
				return this._ipAddress;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000041 RID: 65 RVA: 0x00002887 File Offset: 0x00000A87
		private int Port
		{
			get
			{
				return this._port;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000042 RID: 66 RVA: 0x0000288F File Offset: 0x00000A8F
		private global::System.Net.EndPoint RemoteEndPoint
		{
			get
			{
				return this.remoteEndpoint;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000043 RID: 67 RVA: 0x00002897 File Offset: 0x00000A97
		private int RxRemainingSize
		{
			get
			{
				return this.RxBuffer.Length - this.RxCursor;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000044 RID: 68 RVA: 0x000028A8 File Offset: 0x00000AA8
		private global::Motorola.Common.Communication.RUDP.RUDPSocket Socket
		{
			get
			{
				return this._socket;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000045 RID: 69 RVA: 0x000028B0 File Offset: 0x00000AB0
		public global::Motorola.Common.Communication.RUDP.RUDPConfigParams ConfigParams
		{
			get
			{
				return this._rudpConfigParams;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000046 RID: 70 RVA: 0x000028B8 File Offset: 0x00000AB8
		internal global::Motorola.Common.Communication.RUDP.Helper.RUDPBenchmark Benchmark
		{
			get
			{
				return this._benchmark;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000047 RID: 71 RVA: 0x000028C0 File Offset: 0x00000AC0
		internal global::Motorola.Common.Communication.RUDP.Helper.AsynchronousResult<object[], global::Motorola.Common.Communication.RUDP.RUDPReplyResult> ConnectAsyncResult
		{
			get
			{
				return this._connectAsyncResult;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000048 RID: 72 RVA: 0x000028C8 File Offset: 0x00000AC8
		internal global::Motorola.Common.Communication.RUDP.Helper.AsynchronousResult<object[], global::Motorola.Common.Communication.RUDP.RUDPReplyResult> CloseAsyncResult
		{
			get
			{
				return this._closeAsyncResult;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000049 RID: 73 RVA: 0x000028D0 File Offset: 0x00000AD0
		public int MAX_PACKET_DATA_SIZE
		{
			get
			{
				return this._rudpConfigParams.SynNegociateParameters.maximal_fragment_size - (int)global::Motorola.Common.Communication.RUDP.RUDPConstants.ALL_HEADERS_LEN;
			}
		}

		// Token: 0x0600004A RID: 74 RVA: 0x000028E8 File Offset: 0x00000AE8
		private void AddIncomingUserData(global::Motorola.Common.Communication.RUDP.RUDPUserDataPacket packet)
		{
			this._incomingUserDatasLock.EnterWriteLock();
			try
			{
				this._incomingUserDataList.Add(packet);
			}
			finally
			{
				this._incomingUserDatasLock.ExitWriteLock();
			}
		}

		// Token: 0x0600004B RID: 75 RVA: 0x0000292C File Offset: 0x00000B2C
		private void InsertIncomingUserData(global::Motorola.Common.Communication.RUDP.RUDPUserDataPacket packet)
		{
			this._incomingUserDatasLock.EnterWriteLock();
			try
			{
				this._incomingUserDataList.Insert(0, packet);
			}
			finally
			{
				this._incomingUserDatasLock.ExitWriteLock();
			}
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002970 File Offset: 0x00000B70
		private void RemoveIncomingUserData(global::Motorola.Common.Communication.RUDP.RUDPUserDataPacket packet)
		{
			this._incomingUserDatasLock.EnterWriteLock();
			try
			{
				this._incomingUserDataList.Remove(packet);
			}
			finally
			{
				this._incomingUserDatasLock.ExitWriteLock();
			}
		}

		// Token: 0x0600004D RID: 77 RVA: 0x000029B4 File Offset: 0x00000BB4
		private global::Motorola.Common.Communication.RUDP.RUDPUserDataPacket GetAvaialableIncomingUserData()
		{
			global::Motorola.Common.Communication.RUDP.RUDPUserDataPacket rudpuserDataPacket = null;
			this._incomingUserDatasLock.EnterWriteLock();
			try
			{
				if (this._incomingUserDataList.Count > 0)
				{
					rudpuserDataPacket = this._incomingUserDataList[0];
					if (!rudpuserDataPacket.IsIntegratedPacket)
					{
						global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Unintegrated UserData??", new object[0]);
						return null;
					}
					this._incomingUserDataList.Remove(rudpuserDataPacket);
				}
			}
			finally
			{
				this._incomingUserDatasLock.ExitWriteLock();
			}
			return rudpuserDataPacket;
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00002A38 File Offset: 0x00000C38
		private void AddOutgoingUserData(global::Motorola.Common.Communication.RUDP.RUDPUserDataPacket packet)
		{
			this._outgoingUserDatasLock.EnterWriteLock();
			try
			{
				this._outgoingUserDataList.Add(packet);
			}
			finally
			{
				this._outgoingUserDatasLock.ExitWriteLock();
			}
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002A7C File Offset: 0x00000C7C
		public void RemoveOutgoingUserData(global::Motorola.Common.Communication.RUDP.RUDPUserDataPacket packet)
		{
			this._outgoingUserDatasLock.EnterWriteLock();
			try
			{
				this._outgoingUserDataList.Remove(packet);
			}
			finally
			{
				this._outgoingUserDatasLock.ExitWriteLock();
			}
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00002AC0 File Offset: 0x00000CC0
		public RUDPConnection(global::Motorola.Common.Communication.RUDP.RUDPSocket socket)
		{
			this._state = global::Motorola.Common.Communication.RUDP.States.RUDPCloseState.Instance();
			this._socket = socket;
			this._rudpConfigParams = new global::Motorola.Common.Communication.RUDP.RUDPConfigParams();
			this._rudpTimerCtrl = new global::Motorola.Common.Communication.RUDP.RUDPTimerController();
			this._rudpFlowControl = new global::Motorola.Common.Communication.RUDP.RUDPFlowControl(this, this._rudpConfigParams, this._rudpTimerCtrl);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002BC8 File Offset: 0x00000DC8
		public int RUDPSendTo(global::Motorola.Common.Communication.RUDP.RUDPPacket packet)
		{
			int result = 0;
			lock (this.TxBuffer)
			{
				int num = packet.Serialize(this.TxBuffer, 0);
				result = this.UDPSendTo(this.TxBuffer, 0, num);
				this.Benchmark.RUDP_SENT_BYTES += num;
				this.Benchmark.RUDP_SENT_PACKETS++;
				this._rudpFlowControl.ResetInactivityTimer();
			}
			this.LAST_SENT_PACKET = packet;
			return result;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002C60 File Offset: 0x00000E60
		private int RUDPReceiveFrom(ref global::Motorola.Common.Communication.RUDP.RUDPPacket packet)
		{
			int num = 0;
			lock (this.RxBuffer)
			{
				num = this.UDPReceiveFrom(this.RxBuffer, 0, this.RxBuffer.Length);
				packet.Deserialize(this.RxBuffer, 0, num);
			}
			return num;
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002CC4 File Offset: 0x00000EC4
		public global::System.IAsyncResult BeginConnect(global::System.Net.IPAddress ipAddr, int port, global::System.AsyncCallback callback, object state)
		{
			this._connectAsyncResult = new global::Motorola.Common.Communication.RUDP.Helper.AsynchronousResult<object[], global::Motorola.Common.Communication.RUDP.RUDPReplyResult>(new global::Motorola.Common.Communication.RUDP.Helper.AsynchronousResult<object[], global::Motorola.Common.Communication.RUDP.RUDPReplyResult>.SynFunc<object[], global::Motorola.Common.Communication.RUDP.RUDPReplyResult>(this.Connect), new object[]
			{
				ipAddr,
				port
			}, callback, state);
			this._connectAsyncResult.FireExecution();
			return this._connectAsyncResult;
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002D14 File Offset: 0x00000F14
		public global::Motorola.Common.Communication.RUDP.RUDPReplyResult EndConnect(global::System.IAsyncResult result)
		{
			global::Motorola.Common.Communication.RUDP.Helper.AsynchronousResult<object[], global::Motorola.Common.Communication.RUDP.RUDPReplyResult> asynchronousResult = (global::Motorola.Common.Communication.RUDP.Helper.AsynchronousResult<object[], global::Motorola.Common.Communication.RUDP.RUDPReplyResult>)result;
			global::Motorola.Common.Communication.RUDP.RUDPReplyResult rudpreplyResult = asynchronousResult.FetchResultsFromAsyncOperation(this._rudpConfigParams.ConnectivityParameters.OpenTimeout);
			if (!asynchronousResult.IsCompleted)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("RUDP: Connection timeouted! OpenTimeout={0}", new object[]
				{
					this._rudpConfigParams.ConnectivityParameters.OpenTimeout
				});
				return global::Motorola.Common.Communication.RUDP.RUDPReplyResult.RUDPReply_ConnectFail;
			}
			if (rudpreplyResult == global::Motorola.Common.Communication.RUDP.RUDPReplyResult.RUDPReply_Success)
			{
				this._benchmark.StartWatch();
			}
			this._connectAsyncResult = null;
			return rudpreplyResult;
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002D8E File Offset: 0x00000F8E
		public global::System.IAsyncResult BeginClose(global::System.AsyncCallback callback, object state)
		{
			this._closeAsyncResult = new global::Motorola.Common.Communication.RUDP.Helper.AsynchronousResult<object[], global::Motorola.Common.Communication.RUDP.RUDPReplyResult>(new global::Motorola.Common.Communication.RUDP.Helper.AsynchronousResult<object[], global::Motorola.Common.Communication.RUDP.RUDPReplyResult>.SynFunc<object[], global::Motorola.Common.Communication.RUDP.RUDPReplyResult>(this.Close), new object[0], callback, state);
			this._closeAsyncResult.FireExecution();
			return this._closeAsyncResult;
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00002DC0 File Offset: 0x00000FC0
		public global::Motorola.Common.Communication.RUDP.RUDPReplyResult EndClose(global::System.IAsyncResult result)
		{
			global::Motorola.Common.Communication.RUDP.Helper.AsynchronousResult<object[], global::Motorola.Common.Communication.RUDP.RUDPReplyResult> asynchronousResult = (global::Motorola.Common.Communication.RUDP.Helper.AsynchronousResult<object[], global::Motorola.Common.Communication.RUDP.RUDPReplyResult>)result;
			global::Motorola.Common.Communication.RUDP.RUDPReplyResult rudpreplyResult = asynchronousResult.FetchResultsFromAsyncOperation(this._rudpConfigParams.ConnectivityParameters.CloseTimeout);
			if (!asynchronousResult.IsCompleted)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("RUDP: Close timeouted! CloseTimeout={0}", new object[]
				{
					this._rudpConfigParams.ConnectivityParameters.CloseTimeout
				});
			}
			if (rudpreplyResult == global::Motorola.Common.Communication.RUDP.RUDPReplyResult.RUDPReply_Success)
			{
				this._benchmark.StopWatch();
			}
			this._closeAsyncResult = null;
			return rudpreplyResult;
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00002E38 File Offset: 0x00001038
		public global::System.IAsyncResult BeginSend(byte[] buffer, int offset, int size, global::System.AsyncCallback callback, object state)
		{
			this._sendAsyncResult = new global::Motorola.Common.Communication.RUDP.Helper.AsynchronousResult<object[], int>(new global::Motorola.Common.Communication.RUDP.Helper.AsynchronousResult<object[], int>.SynFunc<object[], int>(this.Send), new object[]
			{
				buffer,
				offset,
				size
			}, callback, state);
			this._sendAsyncResult.FireExecution();
			return this._sendAsyncResult;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00002E90 File Offset: 0x00001090
		public int EndSend(global::System.IAsyncResult result)
		{
			global::Motorola.Common.Communication.RUDP.Helper.AsynchronousResult<object[], int> asynchronousResult = (global::Motorola.Common.Communication.RUDP.Helper.AsynchronousResult<object[], int>)result;
			int result2 = asynchronousResult.FetchResultsFromAsyncOperation(0);
			this._sendAsyncResult = null;
			return result2;
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002EB4 File Offset: 0x000010B4
		public global::System.IAsyncResult BeginReceive(byte[] buffer, int offset, int size, global::System.AsyncCallback callback, object state)
		{
			lock (this._receiveAsyncLock)
			{
				this._receiveAsyncResult = new global::Motorola.Common.Communication.RUDP.Helper.AsynchronousResult<object[], object>(new global::Motorola.Common.Communication.RUDP.Helper.AsynchronousResult<object[], object>.SynFunc<object[], object>(this.Receive), new object[]
				{
					buffer,
					offset,
					size,
					false
				}, callback, state);
				this._receiveAsyncResult.FireExecution();
			}
			return this._receiveAsyncResult;
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00002F44 File Offset: 0x00001144
		public global::System.IAsyncResult BeginReceive(global::System.AsyncCallback callback, object state)
		{
			lock (this._receiveAsyncLock)
			{
				this._receiveAsyncResult = new global::Motorola.Common.Communication.RUDP.Helper.AsynchronousResult<object[], object>(new global::Motorola.Common.Communication.RUDP.Helper.AsynchronousResult<object[], object>.SynFunc<object[], object>(this.Receive), new object[]
				{
					this.RxBuffer,
					this.RxCursor,
					this.RxBuffer.Length,
					true
				}, callback, state);
				this._receiveAsyncResult.FireExecution();
			}
			return this._receiveAsyncResult;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00002FE0 File Offset: 0x000011E0
		public object EndReceive(global::System.IAsyncResult result)
		{
			global::Motorola.Common.Communication.RUDP.Helper.AsynchronousResult<object[], object> asynchronousResult = (global::Motorola.Common.Communication.RUDP.Helper.AsynchronousResult<object[], object>)result;
			object result2 = asynchronousResult.FetchResultsFromAsyncOperation(this.ReceiveTimeout);
			lock (this._receiveAsyncLock)
			{
				this._receiveAsyncResult = null;
				this.RxCursor = 0;
			}
			return result2;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00003040 File Offset: 0x00001240
		public global::Motorola.Common.Communication.RUDP.RUDPReplyResult SetRUDPSocketOpt(global::Motorola.Common.Communication.RUDP.RUDPConfigParams configParams)
		{
			this._rudpConfigParams = configParams;
			this._openTimeout = configParams.ConnectivityParameters.OpenTimeout;
			this._sendTimeout = configParams.ConnectivityParameters.SendTimeout;
			this._receiveTimeout = configParams.ConnectivityParameters.ReceiveTimeout;
			this._closeTimeout = configParams.ConnectivityParameters.CloseTimeout;
			this._rudpFlowControl.SetConfigParams(configParams);
			return global::Motorola.Common.Communication.RUDP.RUDPReplyResult.RUDPReply_Success;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x000030A8 File Offset: 0x000012A8
		private global::Motorola.Common.Communication.RUDP.RUDPReplyResult Connect(object[] args, global::System.IAsyncResult ar)
		{
			global::Motorola.Common.Communication.RUDP.RUDPReplyResult rudpreplyResult = global::Motorola.Common.Communication.RUDP.RUDPReplyResult.RUDPReply_ConnectFail;
			try
			{
				this.INIT_SENT_SEQN = global::Motorola.Common.Communication.CommonUtil.SingletonBase<global::Motorola.Common.Communication.RUDP.SequenceNumberGenerator>.Instance().INIT_SENT;
				this.NEXT_SENT_SEQN = this.INIT_SENT_SEQN + 1;
				this._rudpTimerCtrl.Start();
				this._ipAddress = (global::System.Net.IPAddress)args[0];
				this._port = (int)args[1];
				this.remoteEndpoint = new global::System.Net.IPEndPoint(this._ipAddress, this._port);
				bool flag = this.ActiveOpen();
				if (flag)
				{
					rudpreplyResult = global::Motorola.Common.Communication.RUDP.RUDPReplyResult.RUDPReply_Success;
					this._rudpFlowControl.StartInactivityTimer();
				}
				else
				{
					rudpreplyResult = global::Motorola.Common.Communication.RUDP.RUDPReplyResult.RUDPReply_ConnectFail;
					this.ConnectAsyncResult.SetAsFailed(rudpreplyResult);
					this._rudpTimerCtrl.Stop();
				}
			}
			catch (global::System.Exception)
			{
				rudpreplyResult = global::Motorola.Common.Communication.RUDP.RUDPReplyResult.RUDPReply_ConnectFail;
				this._rudpTimerCtrl.Stop();
			}
			return rudpreplyResult;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x0000316C File Offset: 0x0000136C
		private int Send(object[] args, global::System.IAsyncResult ar)
		{
			byte[] array = (byte[])args[0];
			int num = (int)args[1];
			int num2 = (int)args[2];
			int result = 0;
			if (array == null || array.Length == 0 || array.Length - num < num2)
			{
				return result;
			}
			this.Benchmark.APP_SENT_BYTES += num2;
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.RUDP.RUDPPacket> list = global::Motorola.Common.Communication.RUDP.RUDPPacketHelper.MakeDataPackets(this, array, num, num2);
			this.AddOutgoingUserData(new global::Motorola.Common.Communication.RUDP.RUDPUserDataPacket(list, this)
			{
				AsyncResult = ar
			});
			this.Benchmark.APP_SENT_PACKETS += list.Count;
			return this._rudpFlowControl.Send(list);
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00003208 File Offset: 0x00001408
		private object Receive(object[] args, global::System.IAsyncResult ar)
		{
			byte[] array = (byte[])args[0];
			int num = (int)args[1];
			int size = (int)args[2];
			bool flag = (bool)args[3];
			int num2 = 0;
			object obj = null;
			lock (this._receiveAsyncLock)
			{
				global::Motorola.Common.Communication.RUDP.RUDPUserDataPacket avaialableIncomingUserData = this.GetAvaialableIncomingUserData();
				if (avaialableIncomingUserData == null)
				{
					return num2;
				}
				obj = num2;
				num2 = avaialableIncomingUserData.Serialze(array, num, size);
				if (flag)
				{
					byte[] array2 = new byte[num2];
					global::System.Array.Copy(array, num, array2, 0, num2);
					obj = array2;
				}
				if (this._receiveAsyncResult != null)
				{
					this._receiveAsyncResult.SetAsCompleted(obj);
					this.Benchmark.APP_RCVD_BYTES += num2;
					this.Benchmark.APP_RCVD_PACKETS++;
				}
				else
				{
					this.InsertIncomingUserData(avaialableIncomingUserData);
				}
			}
			return obj;
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00003308 File Offset: 0x00001508
		private global::Motorola.Common.Communication.RUDP.RUDPReplyResult Close(object[] args, global::System.IAsyncResult ar)
		{
			global::Motorola.Common.Communication.RUDP.RUDPReplyResult result = global::Motorola.Common.Communication.RUDP.RUDPReplyResult.RUDPReply_Success;
			try
			{
				this.Close();
				this.SetCloseWaitTimer();
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("RUDP Close Error: {0}", new object[]
				{
					ex.ToString()
				});
				result = global::Motorola.Common.Communication.RUDP.RUDPReplyResult.RUDPReply_CloseFail;
			}
			return result;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x0000335C File Offset: 0x0000155C
		public global::System.IAsyncResult BeginReceiveFrom()
		{
			return this.BeginReceiveFrom(new global::System.AsyncCallback(global::Motorola.Common.Communication.RUDP.RUDPConnection.OnEndReceive));
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00003370 File Offset: 0x00001570
		private global::System.IAsyncResult BeginReceiveFrom(global::System.AsyncCallback callback)
		{
			return this._rawSocket.BeginReceiveFrom(this.RxSegmentBuffer, 0, (int)global::Motorola.Common.Communication.RUDP.RUDPConstants.RUDP_MAX_FRG_SIZE, global::System.Net.Sockets.SocketFlags.None, ref this.remoteEndpoint, callback, this);
		}

		// Token: 0x06000063 RID: 99 RVA: 0x000033A0 File Offset: 0x000015A0
		private int EndReceiveFrom(global::System.IAsyncResult result, ref global::System.Net.EndPoint endPoint)
		{
			int num = this._rawSocket.EndReceiveFrom(result, ref endPoint);
			if (num > 0)
			{
				this.Benchmark.RUDP_RCVD_BYTES += num;
				this.Benchmark.RUDP_RCVD_PACKETS++;
				this._rudpFlowControl.ResetInactivityTimer();
			}
			return num;
		}

		// Token: 0x06000064 RID: 100 RVA: 0x000033F4 File Offset: 0x000015F4
		private static void OnEndReceive(global::System.IAsyncResult result)
		{
			global::Motorola.Common.Communication.RUDP.RUDPConnection rudpconnection = (global::Motorola.Common.Communication.RUDP.RUDPConnection)result.AsyncState;
			global::System.Net.EndPoint remoteEndPoint = rudpconnection.RemoteEndPoint;
			global::System.Net.EndPoint endPoint = new global::System.Net.IPEndPoint(global::System.Net.IPAddress.Any, 0);
			int num = -1;
			try
			{
				num = rudpconnection.EndReceiveFrom(result, ref endPoint);
			}
			catch (global::System.Net.Sockets.SocketException ex)
			{
				if (ex.SocketErrorCode == global::System.Net.Sockets.SocketError.OperationAborted)
				{
					rudpconnection.BeginReceiveFrom(new global::System.AsyncCallback(global::Motorola.Common.Communication.RUDP.RUDPConnection.OnEndReceive));
					return;
				}
				if (ex.SocketErrorCode == global::System.Net.Sockets.SocketError.ConnectionReset)
				{
					rudpconnection.BeginReceiveFrom(new global::System.AsyncCallback(global::Motorola.Common.Communication.RUDP.RUDPConnection.OnEndReceive));
					return;
				}
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("RUDP Async End Rx Error: {0} ", new object[]
				{
					ex.SocketErrorCode
				});
				return;
			}
			if (num >= (int)global::Motorola.Common.Communication.RUDP.RUDPConstants.RUDP_HEADER_LEN && remoteEndPoint.ToString() == endPoint.ToString())
			{
				try
				{
					rudpconnection.Receive(num);
				}
				catch (global::System.Exception ex2)
				{
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("RUDP: Fatal error occured - {0}", new object[]
					{
						ex2.Message
					});
				}
			}
			rudpconnection.BeginReceiveFrom(new global::System.AsyncCallback(global::Motorola.Common.Communication.RUDP.RUDPConnection.OnEndReceive));
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00003524 File Offset: 0x00001724
		private int UDPSendTo(byte[] buffer, int offset, int size)
		{
			if (!this.CheckForOperation())
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RUDP_ConnectionIPPortInvalid);
			}
			return this._rawSocket.SendTo(buffer, offset, size, global::System.Net.Sockets.SocketFlags.None, this.remoteEndpoint);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x0000355C File Offset: 0x0000175C
		private int UDPReceiveFrom(byte[] buffer, int offset, int size)
		{
			if (!this.CheckForOperation())
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RUDP_ConnectionIPPortInvalid);
			}
			return this._rawSocket.ReceiveFrom(buffer, offset, size, global::System.Net.Sockets.SocketFlags.None, ref this.remoteEndpoint);
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00003593 File Offset: 0x00001793
		private bool CheckForOperation()
		{
			return this.Port != 0;
		}

		// Token: 0x06000068 RID: 104 RVA: 0x000035A0 File Offset: 0x000017A0
		private void Receive(int size)
		{
			global::Motorola.Common.Communication.RUDP.RUDPPacket rudppacket = global::Motorola.Common.Communication.RUDP.RUDPConnection.newRUDPPacket(true);
			rudppacket.Deserialize(this.RxSegmentBuffer, 0, size);
			this._rudpFlowControl.Receive(rudppacket);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x000035D0 File Offset: 0x000017D0
		public int SendWithBlockingMode(global::Motorola.Common.Communication.RUDP.RUDPPacket packet)
		{
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.RUDP.RUDPPacket> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.RUDP.RUDPPacket>();
			list.Add(packet);
			this._rudpFlowControl.Send(list);
			return 0;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x000035FC File Offset: 0x000017FC
		public void CheckForIntegratedUserData()
		{
			global::Motorola.Common.Communication.RUDP.RUDPUserDataPacket rudpuserDataPacket = this._rudpFlowControl.CheckForIntegratedIncomingPacket();
			if (rudpuserDataPacket != null)
			{
				this.AddIncomingUserData(rudpuserDataPacket);
				if (this._receiveAsyncResult != null && !this._receiveAsyncResult.IsCompleted)
				{
					this._receiveAsyncResult.Execute();
				}
			}
		}

		// Token: 0x0600006B RID: 107 RVA: 0x0000363F File Offset: 0x0000183F
		public static void InstallDelayACKTimers(global::Motorola.Common.Communication.RUDP.RUDPPacket packet)
		{
			global::Motorola.Common.Communication.RUDP.RUDPFlowControl.InstallReceiveTimers(packet);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00003647 File Offset: 0x00001847
		public void SetCloseWaitTimer()
		{
			this._rudpFlowControl.StartCloseWaitTimer();
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00003654 File Offset: 0x00001854
		public void AddIncomingPacket(global::Motorola.Common.Communication.RUDP.RUDPPacket packet)
		{
			this._rudpFlowControl.AddIncomingPacket(packet);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00003662 File Offset: 0x00001862
		public void InactivityTimout()
		{
			this.Close(null, null);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00003670 File Offset: 0x00001870
		public void CloseWaitTimerCallback(object state)
		{
			if (this.SockState == global::Motorola.Common.Communication.RUDP.RUDPSockState.CLOSE_WAIT)
			{
				this._rudpTimerCtrl.Stop();
				this.Clean();
				this.ChangeState(global::Motorola.Common.Communication.RUDP.States.RUDPCloseState.Instance());
				if (this._connectAsyncResult != null && !this._connectAsyncResult.IsCompleted)
				{
					this._connectAsyncResult.SetAsFailed(global::Motorola.Common.Communication.RUDP.RUDPReplyResult.RUDPReply_ConnectFail);
				}
				if (this._sendAsyncResult != null && !this._sendAsyncResult.IsCompleted)
				{
					this._sendAsyncResult.SetAsFailed(0);
				}
				if (this._receiveAsyncResult != null && !this._receiveAsyncResult.IsCompleted)
				{
					this._receiveAsyncResult.SetAsFailed(null);
				}
				if (this._closeAsyncResult != null)
				{
					this._closeAsyncResult.SetAsCompleted(global::Motorola.Common.Communication.RUDP.RUDPReplyResult.RUDPReply_Success);
				}
			}
		}

		// Token: 0x06000070 RID: 112 RVA: 0x0000371C File Offset: 0x0000191C
		private void Clean()
		{
			this._incomingUserDatasLock.EnterWriteLock();
			this._outgoingUserDatasLock.EnterWriteLock();
			try
			{
				this._incomingUserDataList.Clear();
				this._outgoingUserDataList.Clear();
			}
			finally
			{
				this._incomingUserDatasLock.ExitWriteLock();
				this._outgoingUserDatasLock.ExitWriteLock();
			}
			this._rudpFlowControl.Clean();
		}

		// Token: 0x06000071 RID: 113 RVA: 0x0000378C File Offset: 0x0000198C
		public void SendACK(global::Motorola.Common.Communication.RUDP.RUDPPacket unackedPacket)
		{
			this._rudpFlowControl.SendACK(unackedPacket);
		}

		// Token: 0x06000072 RID: 114 RVA: 0x0000379A File Offset: 0x0000199A
		private bool ActiveOpen()
		{
			return this._state.ActiveOpen(this);
		}

		// Token: 0x06000073 RID: 115 RVA: 0x000037A8 File Offset: 0x000019A8
		private void PassiveOpen()
		{
			this._state.PassiveOpen(this);
		}

		// Token: 0x06000074 RID: 116 RVA: 0x000037B8 File Offset: 0x000019B8
		private void Close()
		{
			this._state.Close(this);
			try
			{
				this._rawSocket.Shutdown();
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Raw Socket Shutdown error: " + ex.Message, new object[0]);
			}
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00003814 File Offset: 0x00001A14
		private void Synchronize()
		{
			this._state.Synchronize(this);
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00003822 File Offset: 0x00001A22
		private void Acknowledge()
		{
			this._state.Acknowledge(this);
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00003830 File Offset: 0x00001A30
		public int Send(global::Motorola.Common.Communication.RUDP.RUDPPacket packet)
		{
			return this._state.Send(this, packet);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x0000384E File Offset: 0x00001A4E
		public void Receive(global::Motorola.Common.Communication.RUDP.RUDPPacket packet)
		{
			this._state.Receive(this, packet);
		}

		// Token: 0x06000079 RID: 121 RVA: 0x0000385D File Offset: 0x00001A5D
		public void ChangeState(global::Motorola.Common.Communication.RUDP.States.IRUDPState state)
		{
			this._state = state;
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00003866 File Offset: 0x00001A66
		private static global::Motorola.Common.Communication.RUDP.RUDPPacket newRUDPPacket(bool syn)
		{
			return new global::Motorola.Common.Communication.RUDP.RUDPPacket(syn);
		}

		// Token: 0x04000021 RID: 33
		private ushort _INIT_SENT_SEQN = global::Motorola.Common.Communication.RUDP.RUDPConstants.DEFAULT_SEQ_ACK_NUM;

		// Token: 0x04000022 RID: 34
		private ushort _LAST_SENT_SEQN = global::Motorola.Common.Communication.RUDP.RUDPConstants.DEFAULT_SEQ_ACK_NUM;

		// Token: 0x04000023 RID: 35
		private ushort _NEXT_SENT_SEQN = global::Motorola.Common.Communication.RUDP.RUDPConstants.DEFAULT_SEQ_ACK_NUM;

		// Token: 0x04000024 RID: 36
		private ushort _INIT_RCVD_SEQN = global::Motorola.Common.Communication.RUDP.RUDPConstants.DEFAULT_SEQ_ACK_NUM;

		// Token: 0x04000025 RID: 37
		private ushort _LAST_RCVD_SEQN = global::Motorola.Common.Communication.RUDP.RUDPConstants.DEFAULT_SEQ_ACK_NUM;

		// Token: 0x04000026 RID: 38
		private int _LAST_SENT_TIME;

		// Token: 0x04000027 RID: 39
		private global::Motorola.Common.Communication.RUDP.RUDPPacket _LAST_SENT_PACKET;

		// Token: 0x04000028 RID: 40
		private global::Motorola.Common.Communication.RUDP.RUDPTimerController _rudpTimerCtrl;

		// Token: 0x04000029 RID: 41
		private global::Motorola.Common.Communication.RUDP.RUDPConfigParams _rudpConfigParams;

		// Token: 0x0400002A RID: 42
		private global::Motorola.Common.Communication.RUDP.RUDPFlowControl _rudpFlowControl;

		// Token: 0x0400002B RID: 43
		private byte[] RxBuffer = new byte[(int)global::Motorola.Common.Communication.RUDP.RUDPConstants.RUDP_RECV_BUFF_SIZE];

		// Token: 0x0400002C RID: 44
		private int RxCursor;

		// Token: 0x0400002D RID: 45
		private byte[] TxBuffer = new byte[(int)global::Motorola.Common.Communication.RUDP.RUDPConstants.RUDP_MAX_FRG_SIZE];

		// Token: 0x0400002E RID: 46
		private byte[] RxSegmentBuffer = new byte[(int)global::Motorola.Common.Communication.RUDP.RUDPConstants.RUDP_MAX_FRG_SIZE];

		// Token: 0x0400002F RID: 47
		private global::Motorola.Common.Communication.RUDP.RawSocketWrapper _rawSocket = new global::Motorola.Common.Communication.RUDP.RawSocketWrapper();

		// Token: 0x04000030 RID: 48
		private global::Motorola.Common.Communication.RUDP.Helper.AsynchronousResult<object[], global::Motorola.Common.Communication.RUDP.RUDPReplyResult> _connectAsyncResult;

		// Token: 0x04000031 RID: 49
		private global::Motorola.Common.Communication.RUDP.Helper.AsynchronousResult<object[], global::Motorola.Common.Communication.RUDP.RUDPReplyResult> _closeAsyncResult;

		// Token: 0x04000032 RID: 50
		private global::Motorola.Common.Communication.RUDP.Helper.AsynchronousResult<object[], object> _receiveAsyncResult;

		// Token: 0x04000033 RID: 51
		private global::Motorola.Common.Communication.RUDP.Helper.AsynchronousResult<object[], int> _sendAsyncResult;

		// Token: 0x04000034 RID: 52
		private object _receiveAsyncLock = new object();

		// Token: 0x04000035 RID: 53
		private global::System.Threading.ReaderWriterLockSlim _incomingUserDatasLock = new global::System.Threading.ReaderWriterLockSlim();

		// Token: 0x04000036 RID: 54
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.RUDP.RUDPUserDataPacket> _incomingUserDataList = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.RUDP.RUDPUserDataPacket>();

		// Token: 0x04000037 RID: 55
		private global::System.Threading.ReaderWriterLockSlim _outgoingUserDatasLock = new global::System.Threading.ReaderWriterLockSlim();

		// Token: 0x04000038 RID: 56
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.RUDP.RUDPUserDataPacket> _outgoingUserDataList = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.RUDP.RUDPUserDataPacket>();

		// Token: 0x04000039 RID: 57
		private global::Motorola.Common.Communication.RUDP.Helper.RUDPBenchmark _benchmark = new global::Motorola.Common.Communication.RUDP.Helper.RUDPBenchmark();

		// Token: 0x0400003A RID: 58
		private int _sendTimeout;

		// Token: 0x0400003B RID: 59
		private int _receiveTimeout;

		// Token: 0x0400003C RID: 60
		private int _openTimeout;

		// Token: 0x0400003D RID: 61
		private int _closeTimeout;

		// Token: 0x0400003E RID: 62
		private global::Motorola.Common.Communication.RUDP.States.IRUDPState _state;

		// Token: 0x0400003F RID: 63
		private global::Motorola.Common.Communication.RUDP.RUDPSocket _socket;

		// Token: 0x04000040 RID: 64
		private global::System.Net.IPAddress _ipAddress;

		// Token: 0x04000041 RID: 65
		private int _port;

		// Token: 0x04000042 RID: 66
		private global::System.Net.EndPoint remoteEndpoint;
	}
}
