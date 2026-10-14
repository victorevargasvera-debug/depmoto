using System;
using System.Text;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x0200005F RID: 95
	public class RcmpVersionInformation : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x0600014E RID: 334 RVA: 0x00006806 File Offset: 0x00004A06
		public RcmpVersionInformation(global::Motorola.Common.Communication.Rcmp.VersionInfoType type) : this((byte)type)
		{
		}

		// Token: 0x0600014F RID: 335 RVA: 0x0000680F File Offset: 0x00004A0F
		private RcmpVersionInformation(byte type)
		{
			base.Opcode = 15;
			this.m_Type = type;
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000150 RID: 336 RVA: 0x00006826 File Offset: 0x00004A26
		public string VersionInformation
		{
			get
			{
				return this.m_VersionInformation;
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000151 RID: 337 RVA: 0x0000682E File Offset: 0x00004A2E
		private byte Type
		{
			get
			{
				return this.m_Type;
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000152 RID: 338 RVA: 0x00006836 File Offset: 0x00004A36
		public global::Motorola.Common.Communication.Rcmp.FlashSizeType FlashSizeType
		{
			get
			{
				if (this.m_Type == 109)
				{
					return (global::Motorola.Common.Communication.Rcmp.FlashSizeType)this.m_rawReply[0];
				}
				throw new global::System.NotSupportedException();
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000153 RID: 339 RVA: 0x00006850 File Offset: 0x00004A50
		public string FPGAVersionInformation
		{
			get
			{
				if (this.m_Type >= 176 && this.m_Type <= 181)
				{
					return string.Join(string.Empty, global::System.BitConverter.ToString(this.m_rawReply, 8).Split(new char[]
					{
						'-'
					}));
				}
				throw new global::System.InvalidOperationException();
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000154 RID: 340 RVA: 0x000068A5 File Offset: 0x00004AA5
		public bool IsDspCapabilityEnabled
		{
			get
			{
				if (this.m_Type == 17)
				{
					return (this.m_rawReply[0] & 1) == 1;
				}
				throw new global::System.InvalidOperationException();
			}
		}

		// Token: 0x06000155 RID: 341 RVA: 0x000068C4 File Offset: 0x00004AC4
		public bool IsDtpCapabilityEnabled()
		{
			if (this.m_Type == 19)
			{
				return (this.m_rawReply[0] & 1) == 1;
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidProperty);
		}

		// Token: 0x06000156 RID: 342 RVA: 0x000068E4 File Offset: 0x00004AE4
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			return global::Motorola.Common.Communication.RcmpCommon.ConstructBytes(buffer, offset, new object[]
			{
				base.Opcode,
				this.m_Type
			});
		}

		// Token: 0x06000157 RID: 343 RVA: 0x0000691C File Offset: 0x00004B1C
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			base.ReplyResult = global::Motorola.Common.Communication.RcmpCommon.CheckReplyHeader(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.RcmpCommon.RcmpReplyOpcodeFlag);
			if (base.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				this.m_rawReply = new byte[length - global::Motorola.Common.Communication.RcmpCommon.RcmpBasicReplyHeaderSize];
				global::System.Buffer.BlockCopy(replyBuffer, offset + global::Motorola.Common.Communication.RcmpCommon.RcmpBasicReplyHeaderSize, this.m_rawReply, 0, this.m_rawReply.Length);
				this.m_VersionInformation = global::System.Text.Encoding.ASCII.GetString(this.m_rawReply);
			}
		}

		// Token: 0x040001DE RID: 478
		private string m_VersionInformation;

		// Token: 0x040001DF RID: 479
		private byte[] m_rawReply;

		// Token: 0x040001E0 RID: 480
		private byte m_Type;
	}
}
