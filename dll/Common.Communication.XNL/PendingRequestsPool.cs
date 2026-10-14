using System;
using System.Collections.Generic;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication
{
	// Token: 0x02000003 RID: 3
	internal class PendingRequestsPool : global::System.IDisposable
	{
		// Token: 0x06000011 RID: 17 RVA: 0x000021F0 File Offset: 0x000003F0
		~PendingRequestsPool()
		{
			this.Dispose(false);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002220 File Offset: 0x00000420
		public void Add(global::Motorola.Common.Communication.XnlPacket request)
		{
			lock (this.sync)
			{
				if (!this.pool.ContainsKey(request.transactionID))
				{
					global::Motorola.Common.Communication.PendingRequest pendingRequest = null;
					try
					{
						pendingRequest = new global::Motorola.Common.Communication.PendingRequest(request);
						global::Motorola.Common.Communication.XnlTrace.WriteLine("Pending request " + request.ToString() + " added!");
						this.pool.Add(pendingRequest.TransactionID, pendingRequest);
						pendingRequest = null;
					}
					finally
					{
						if (pendingRequest != null)
						{
							pendingRequest.Dispose();
						}
					}
				}
			}
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000022BC File Offset: 0x000004BC
		public void Remove(ushort id)
		{
			lock (this.sync)
			{
				if (this.pool.ContainsKey(id))
				{
					global::Motorola.Common.Communication.PendingRequest pendingRequest = this.pool[id];
					this.pool.Remove(id);
					pendingRequest.Dispose();
					global::Motorola.Common.Communication.XnlTrace.WriteLine("Pending request " + id + " removed!");
				}
			}
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002340 File Offset: 0x00000540
		public void ResponseReceived(global::Motorola.Common.Communication.XnlPacket response)
		{
			lock (this.sync)
			{
				global::Motorola.Common.Communication.XnlTrace.WriteLine("Pending request recieve response:  " + response.ToString());
				global::Motorola.Common.Communication.PendingRequest pendingRequest = this.Get(response.transactionID);
				if (pendingRequest != null && pendingRequest.ResponsePacket == null)
				{
					pendingRequest.ResponsePacket = response;
					global::Motorola.Common.Communication.XnlTrace.WriteLine("Pending request recieve response set: " + response.ToString());
					pendingRequest.ResponseWaitHandle.Set();
				}
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000023D0 File Offset: 0x000005D0
		public void RequestAckReceived(global::Motorola.Common.Communication.XnlPacket ack)
		{
			lock (this.sync)
			{
				global::Motorola.Common.Communication.XnlTrace.WriteLine("Pending request recieve request ack:  " + ack.ToString());
				global::Motorola.Common.Communication.PendingRequest pendingRequest = this.Get(ack.transactionID);
				if (pendingRequest != null && pendingRequest.RequestAckPacket == null && pendingRequest.RequestPacket.protocolID == global::Motorola.Common.Communication.XnlProtocol.Xcmp && pendingRequest.RequestPacket.sourceAddress == ack.destinationAddr)
				{
					global::Motorola.Common.Communication.XnlTrace.WriteLine("Pending request recieve request ack set:  " + ack.ToString());
					pendingRequest.RequestAckPacket = ack;
					if (!pendingRequest.RequestAckWaitHandle.Set())
					{
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationXnlOSFailure);
					}
				}
			}
		}

		// Token: 0x06000016 RID: 22 RVA: 0x0000248C File Offset: 0x0000068C
		public global::Motorola.Common.Communication.XnlPacket GetResponse(ushort requireTransitionID, int timeout)
		{
			global::Motorola.Common.Communication.PendingRequest pendingRequest = null;
			lock (this.sync)
			{
				global::Motorola.Common.Communication.XnlTrace.WriteLine("Main thread getResponse:  " + requireTransitionID);
				pendingRequest = this.Get(requireTransitionID);
				if (pendingRequest == null)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationXnlInvalidTransactionID);
				}
			}
			global::Motorola.Common.Communication.XnlPacket result = null;
			if (pendingRequest.ResponseWaitHandle.WaitOne(timeout) && pendingRequest.ResponsePacket != null)
			{
				result = pendingRequest.ResponsePacket;
				this.Remove(requireTransitionID);
			}
			return result;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x0000251C File Offset: 0x0000071C
		public global::Motorola.Common.Communication.XnlPacket GetRequestAck(ushort requireTransitionID, int timeout)
		{
			global::Motorola.Common.Communication.PendingRequest pendingRequest = null;
			lock (this.sync)
			{
				global::Motorola.Common.Communication.XnlTrace.WriteLine("Main thread GetRequestAck:  " + requireTransitionID);
				pendingRequest = this.Get(requireTransitionID);
				if (pendingRequest == null)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationXnlInvalidTransactionID);
				}
			}
			global::Motorola.Common.Communication.XnlPacket result = null;
			if (pendingRequest.RequestAckWaitHandle.WaitOne(timeout) && pendingRequest.RequestAckPacket != null)
			{
				global::Motorola.Common.Communication.XnlTrace.WriteLine("Main thread GetRequestAck done!:  " + pendingRequest.RequestAckPacket.ToString());
				result = pendingRequest.RequestAckPacket;
			}
			return result;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000025C0 File Offset: 0x000007C0
		private void Clear()
		{
			lock (this.sync)
			{
				foreach (global::Motorola.Common.Communication.PendingRequest pendingRequest in this.pool.Values)
				{
					pendingRequest.Dispose();
				}
				this.pool.Clear();
			}
		}

		// Token: 0x06000019 RID: 25 RVA: 0x0000264C File Offset: 0x0000084C
		private global::Motorola.Common.Communication.PendingRequest Get(ushort id)
		{
			global::Motorola.Common.Communication.PendingRequest result;
			lock (this.sync)
			{
				if (this.pool.ContainsKey(id))
				{
					result = this.pool[id];
				}
				else
				{
					result = null;
				}
			}
			return result;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000026A8 File Offset: 0x000008A8
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000026B7 File Offset: 0x000008B7
		private void Dispose(bool disposing)
		{
			if (!this.disposed)
			{
				if (disposing)
				{
					this.Clear();
				}
				this.disposed = true;
			}
		}

		// Token: 0x04000007 RID: 7
		private global::System.Collections.Generic.Dictionary<ushort, global::Motorola.Common.Communication.PendingRequest> pool = new global::System.Collections.Generic.Dictionary<ushort, global::Motorola.Common.Communication.PendingRequest>();

		// Token: 0x04000008 RID: 8
		private object sync = new object();

		// Token: 0x04000009 RID: 9
		private bool disposed;
	}
}
