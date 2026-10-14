using System;

namespace Motorola.Common.Communication
{
	// Token: 0x02000003 RID: 3
	public abstract class BaseMessage : global::Motorola.Common.Communication.IMessage
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000007 RID: 7 RVA: 0x000020D0 File Offset: 0x000002D0
		// (set) Token: 0x06000008 RID: 8 RVA: 0x000020D8 File Offset: 0x000002D8
		protected byte[] _myCommandBuffer
		{
			get
			{
				return this.myCommandBuffer;
			}
			set
			{
				this.myCommandBuffer = value;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000009 RID: 9 RVA: 0x000020E1 File Offset: 0x000002E1
		// (set) Token: 0x0600000A RID: 10 RVA: 0x000020E9 File Offset: 0x000002E9
		protected byte[] _myReplyBuffer
		{
			get
			{
				return this.myReplyBuffer;
			}
			set
			{
				this.myReplyBuffer = value;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000B RID: 11 RVA: 0x000020F2 File Offset: 0x000002F2
		// (set) Token: 0x0600000C RID: 12 RVA: 0x000020FA File Offset: 0x000002FA
		protected byte[] _myWriteDataBuffer
		{
			get
			{
				return this.myWriteDataBuffer;
			}
			set
			{
				this.myWriteDataBuffer = value;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000D RID: 13 RVA: 0x00002103 File Offset: 0x00000303
		// (set) Token: 0x0600000E RID: 14 RVA: 0x0000210B File Offset: 0x0000030B
		public bool hasReply
		{
			get
			{
				return this._hasReply;
			}
			set
			{
				this._hasReply = value;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600000F RID: 15 RVA: 0x00002114 File Offset: 0x00000314
		// (set) Token: 0x06000010 RID: 16 RVA: 0x0000211C File Offset: 0x0000031C
		public int ReadTimeout
		{
			get
			{
				return this._readTimeout;
			}
			set
			{
				this._readTimeout = value;
			}
		}

		// Token: 0x06000011 RID: 17
		public abstract int BuildCommandMessage(byte[] sendBuffer);

		// Token: 0x06000012 RID: 18
		public abstract void DecodeReplyMessage(byte[] replyBuffer, int offset, int length);

		// Token: 0x04000001 RID: 1
		private int _readTimeout;

		// Token: 0x04000002 RID: 2
		private byte[] myCommandBuffer;

		// Token: 0x04000003 RID: 3
		private byte[] myReplyBuffer;

		// Token: 0x04000004 RID: 4
		private byte[] myWriteDataBuffer;

		// Token: 0x04000005 RID: 5
		private bool _hasReply = true;
	}
}
