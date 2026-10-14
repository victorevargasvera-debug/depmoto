using System;
using System.Collections.Generic;
using System.Linq;
using VerifyUtility;

namespace Motorola.Common.Communication.CommunicationPipe
{
	// Token: 0x02000009 RID: 9
	public class MultiPipeCommPipe : global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe, global::System.IDisposable
	{
		// Token: 0x06000037 RID: 55 RVA: 0x00002AC4 File Offset: 0x00000CC4
		static MultiPipeCommPipe()
		{
			global::VerifyUtility.AssemblyValidator.IsCallerAuthorized();
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002ACC File Offset: 0x00000CCC
		public MultiPipeCommPipe()
		{
			this.pipeMap = new global::System.Collections.Generic.Dictionary<int, global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe>();
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002ADF File Offset: 0x00000CDF
		public void MapPipe(int id, global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe pipe)
		{
			if (pipe == null)
			{
				if (this.pipeMap.ContainsKey(id))
				{
					this.pipeMap.Remove(id);
					return;
				}
			}
			else
			{
				this.pipeMap.Add(id, pipe);
			}
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002B10 File Offset: 0x00000D10
		public global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe GetPipe(int id)
		{
			global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe result = null;
			if (this.pipeMap.ContainsKey(id))
			{
				result = this.pipeMap[id];
			}
			return result;
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002B3B File Offset: 0x00000D3B
		public global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<int, global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe>> GetAllPipes()
		{
			return this.pipeMap.ToList<global::System.Collections.Generic.KeyValuePair<int, global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe>>();
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600003C RID: 60 RVA: 0x00002B48 File Offset: 0x00000D48
		// (set) Token: 0x0600003D RID: 61 RVA: 0x00002B50 File Offset: 0x00000D50
		public int ReceiveTimeout { get; set; }

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600003E RID: 62 RVA: 0x00002B59 File Offset: 0x00000D59
		// (set) Token: 0x0600003F RID: 63 RVA: 0x00002B61 File Offset: 0x00000D61
		public bool IsOpen { get; set; }

		// Token: 0x06000040 RID: 64 RVA: 0x00002B6A File Offset: 0x00000D6A
		public void OpenPort(int timeout)
		{
			this.IsOpen = true;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002B73 File Offset: 0x00000D73
		public void ClosePort()
		{
			this.IsOpen = false;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002B7C File Offset: 0x00000D7C
		public void SendData(byte[] buffer, int start, int length)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002B83 File Offset: 0x00000D83
		public byte[] ReceiveData()
		{
			return this.ReceiveData(this.ReceiveTimeout);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002B91 File Offset: 0x00000D91
		public byte[] ReceiveData(int timeout)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002B98 File Offset: 0x00000D98
		public int ReceiveData(byte[] buffer, int start)
		{
			return this.ReceiveData(buffer, start, this.ReceiveTimeout);
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002BA8 File Offset: 0x00000DA8
		public int ReceiveData(byte[] buffer, int start, int timeout)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002BAF File Offset: 0x00000DAF
		public int ReceiveData(byte[] buffer, int start, int timeout, int expectedlength)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002BB6 File Offset: 0x00000DB6
		public byte[] RequestData(byte[] buffer, int start, int length)
		{
			return this.RequestData(buffer, start, length, this.ReceiveTimeout);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002BC7 File Offset: 0x00000DC7
		public byte[] RequestData(byte[] buffer, int start, int length, int timeout)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002BCE File Offset: 0x00000DCE
		public byte[] PeekData(int length, int timeOut)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600004B RID: 75 RVA: 0x00002BD5 File Offset: 0x00000DD5
		public int AvailableReadBytesCount
		{
			get
			{
				throw new global::System.NotSupportedException();
			}
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002BDC File Offset: 0x00000DDC
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002BEC File Offset: 0x00000DEC
		protected virtual void Dispose(bool isDisposing)
		{
			if (!this.m_IsDisposed)
			{
				if (isDisposing)
				{
					foreach (global::System.Collections.Generic.KeyValuePair<int, global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe> keyValuePair in this.GetAllPipes())
					{
						global::System.IDisposable disposable = keyValuePair.Value as global::System.IDisposable;
						if (disposable != null)
						{
							disposable.Dispose();
						}
					}
					this.ClosePort();
				}
				this.m_IsDisposed = true;
			}
		}

		// Token: 0x0400002F RID: 47
		private global::System.Collections.Generic.Dictionary<int, global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe> pipeMap;

		// Token: 0x04000030 RID: 48
		private bool m_IsDisposed;
	}
}
