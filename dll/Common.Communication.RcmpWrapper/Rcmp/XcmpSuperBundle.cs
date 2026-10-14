using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x02000076 RID: 118
	public class XcmpSuperBundle : global::Motorola.Common.Communication.RcmpBaseMessage, global::Motorola.Common.Communication.ISuperBundlerMessage
	{
		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060001AB RID: 427 RVA: 0x000082A3 File Offset: 0x000064A3
		private int NumberOfReplies
		{
			get
			{
				return this.m_NumberOfReplies;
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060001AC RID: 428 RVA: 0x000082AB File Offset: 0x000064AB
		private bool ContinueIfFail
		{
			get
			{
				return this.m_ContinueIfFail;
			}
		}

		// Token: 0x060001AD RID: 429 RVA: 0x000082B3 File Offset: 0x000064B3
		public XcmpSuperBundle(bool continueIfFail)
		{
			this.m_ContinueIfFail = continueIfFail;
			base.Opcode = 46;
		}

		// Token: 0x060001AE RID: 430 RVA: 0x000082D5 File Offset: 0x000064D5
		public bool AddRcmpMessage(global::Motorola.Common.Communication.RcmpBaseMessage rcmpMessage)
		{
			if (rcmpMessage == null)
			{
				return false;
			}
			this.m_RcmpMessages.Add(rcmpMessage);
			return true;
		}

		// Token: 0x17000096 RID: 150
		public global::Motorola.Common.Communication.RcmpBaseMessage this[int index]
		{
			get
			{
				return this.m_RcmpMessages[index];
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060001B0 RID: 432 RVA: 0x000082F7 File Offset: 0x000064F7
		public int ChildCount
		{
			get
			{
				return this.m_RcmpMessages.Count;
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060001B1 RID: 433 RVA: 0x00008304 File Offset: 0x00006504
		// (set) Token: 0x060001B2 RID: 434 RVA: 0x0000830C File Offset: 0x0000650C
		private global::Motorola.Common.Communication.RcmpReplyResult mReplyResult
		{
			get
			{
				return base.ReplyResult;
			}
			set
			{
				base.ReplyResult = value;
			}
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x00008318 File Offset: 0x00006518
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			int num = 4;
			if (buffer.Length < offset + num)
			{
				throw new global::System.ArgumentException("buffer.Length should be at least larger than offset + 4");
			}
			buffer[offset] = (byte)(base.Opcode >> 8);
			buffer[offset + 1] = (byte)(base.Opcode & 255);
			buffer[offset + 2] = (byte)this.m_RcmpMessages.Count;
			buffer[offset + 3] = (this.m_ContinueIfFail ? 1 : 0);
			int num2 = offset + 4;
			for (int i = 0; i < this.m_RcmpMessages.Count; i++)
			{
				int num3 = this.m_RcmpMessages[i].BuildCommandMessage(buffer, num2 + 2);
				buffer[num2] = (byte)(num3 / 256 & 255);
				buffer[num2 + 1] = (byte)(num3 & 255);
				num2 += 2 + num3;
				num += 2 + num3;
			}
			base._myCommandBuffer = buffer;
			return num;
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x000083E0 File Offset: 0x000065E0
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			if (replyBuffer.Length < offset + length)
			{
				throw new global::System.ArgumentOutOfRangeException("buffer", "buffer size is smaller than (offset + length)");
			}
			ushort num = (ushort)((int)replyBuffer[offset] * 256 + (int)replyBuffer[offset + 1]);
			ushort num2 = base.Opcode | global::Motorola.Common.Communication.RcmpCommon.RcmpReplyOpcodeFlag;
			if (num != num2)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidReplyOpcode);
			}
			byte mReplyResult = replyBuffer[offset + 2];
			try
			{
				this.mReplyResult = (global::Motorola.Common.Communication.RcmpReplyResult)mReplyResult;
			}
			catch (global::System.ArgumentException)
			{
				this.mReplyResult = global::Motorola.Common.Communication.RcmpReplyResult.Undefined;
			}
			if (this.mReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.OpcodeNotSupported && length == 3)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.SuperBundleNotSupported);
			}
			this.m_NumberOfReplies = (int)replyBuffer[offset + 3];
			int num3 = offset + 4;
			for (int i = 0; i < this.m_NumberOfReplies; i++)
			{
				int num4 = (int)replyBuffer[num3] * 256 + (int)replyBuffer[num3 + 1];
				this.m_RcmpMessages[i].DecodeReplyMessage(replyBuffer, num3 + 2, num4);
				num3 += 2 + num4;
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060001B5 RID: 437 RVA: 0x000084C8 File Offset: 0x000066C8
		public int MaxMessageSize
		{
			get
			{
				int num = global::Motorola.Common.Communication.Rcmp.XcmpSuperBundle.HeaderSize;
				foreach (global::Motorola.Common.Communication.RcmpBaseMessage rcmpBaseMessage in this.m_RcmpMessages)
				{
					num += 2 + ((global::Motorola.Common.Communication.ISuperBundlerMessage)rcmpBaseMessage).MaxMessageSize;
				}
				return num;
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060001B6 RID: 438 RVA: 0x0000852C File Offset: 0x0000672C
		public static int HeaderSize
		{
			get
			{
				return 4;
			}
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00008530 File Offset: 0x00006730
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.AppendFormat(global::System.Globalization.CultureInfo.InvariantCulture, "{0}(ContinueIfFail={1},ChildCount={2},NumberOfReplies={3},ReplyResult={4})\n", new object[]
			{
				base.GetType().Name,
				this.ContinueIfFail,
				this.ChildCount,
				this.NumberOfReplies,
				this.mReplyResult
			});
			foreach (global::Motorola.Common.Communication.RcmpBaseMessage rcmpBaseMessage in this.m_RcmpMessages)
			{
				stringBuilder.Append('\t');
				stringBuilder.AppendLine(rcmpBaseMessage.ToString());
			}
			return stringBuilder.ToString();
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00008600 File Offset: 0x00006800
		public override ushort CalculateMessageCRC16(ref uint checksum, byte[] inputData, int start, int length)
		{
			int num = (int)inputData[2];
			int num2 = start + 4;
			for (int i = 0; i < num; i++)
			{
				int num3 = (int)inputData[num2] * 256 + (int)inputData[num2 + 1];
				base.CalculateMessageCRC16(ref checksum, inputData, num2 + 2, num3);
				num2 += 2 + num3;
				if (num2 > start + length)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.MessageCRC16CalculateOverflow);
				}
			}
			return (ushort)checksum;
		}

		// Token: 0x04000260 RID: 608
		private bool m_ContinueIfFail;

		// Token: 0x04000261 RID: 609
		private int m_NumberOfReplies;

		// Token: 0x04000262 RID: 610
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.RcmpBaseMessage> m_RcmpMessages = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.RcmpBaseMessage>();
	}
}
