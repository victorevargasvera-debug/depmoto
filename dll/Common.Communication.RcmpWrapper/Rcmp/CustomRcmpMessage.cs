using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x02000051 RID: 81
	public class CustomRcmpMessage : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x06000123 RID: 291 RVA: 0x00005FE8 File Offset: 0x000041E8
		public CustomRcmpMessage(byte[] messageBuffer)
		{
			this.m_CommandBuffer = messageBuffer;
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000124 RID: 292 RVA: 0x00005FF7 File Offset: 0x000041F7
		// (set) Token: 0x06000125 RID: 293 RVA: 0x00005FFF File Offset: 0x000041FF
		private byte[] CommandBuffer
		{
			get
			{
				return this.m_CommandBuffer;
			}
			set
			{
				this.m_CommandBuffer = value;
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000126 RID: 294 RVA: 0x00006008 File Offset: 0x00004208
		public byte[] ReplyBuffer
		{
			get
			{
				return this.m_ReplyBuffer;
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000127 RID: 295 RVA: 0x00006010 File Offset: 0x00004210
		private new static global::Motorola.Common.Communication.RcmpReplyResult ReplyResult
		{
			get
			{
				throw new global::System.NotSupportedException("CustomRcmpMessage does not parse the reply.");
			}
		}

		// Token: 0x06000128 RID: 296 RVA: 0x0000601C File Offset: 0x0000421C
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			global::System.Array.Copy(this.m_CommandBuffer, 0, buffer, offset, this.m_CommandBuffer.Length);
			return this.m_CommandBuffer.Length;
		}

		// Token: 0x06000129 RID: 297 RVA: 0x0000603C File Offset: 0x0000423C
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			this.m_ReplyBuffer = new byte[length];
			global::System.Array.Copy(replyBuffer, offset, this.m_ReplyBuffer, 0, length);
		}

		// Token: 0x04000182 RID: 386
		private byte[] m_CommandBuffer;

		// Token: 0x04000183 RID: 387
		private byte[] m_ReplyBuffer;
	}
}
