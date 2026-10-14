using System;

namespace Motorola.Common.Communication
{
	// Token: 0x02000073 RID: 115
	public class XcmpRadioUpdateControl : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x060001A1 RID: 417 RVA: 0x00007FC2 File Offset: 0x000061C2
		public XcmpRadioUpdateControl(global::Motorola.Common.Communication.UpdateControlAction action)
		{
			base.Opcode = 268;
			this.m_Action = action;
			this.m_Value = byte.MaxValue;
			this.m_Type = byte.MaxValue;
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00007FF2 File Offset: 0x000061F2
		public XcmpRadioUpdateControl(global::Motorola.Common.Communication.UpdateControlAction action, byte type)
		{
			base.Opcode = 268;
			this.m_Action = action;
			this.m_Type = type;
			this.m_Value = byte.MaxValue;
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060001A3 RID: 419 RVA: 0x0000801E File Offset: 0x0000621E
		public byte Value
		{
			get
			{
				return this.m_Value;
			}
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00008028 File Offset: 0x00006228
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			if (this.m_Type != 255)
			{
				return global::Motorola.Common.Communication.RcmpCommon.ConstructBytes(buffer, offset, new object[]
				{
					base.Opcode,
					(byte)this.m_Action,
					this.m_Type
				});
			}
			return global::Motorola.Common.Communication.RcmpCommon.ConstructBytes(buffer, offset, new object[]
			{
				base.Opcode,
				(byte)this.m_Action
			});
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x000080A8 File Offset: 0x000062A8
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			base.ReplyResult = global::Motorola.Common.Communication.RcmpCommon.CheckReplyHeader(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.RcmpCommon.RcmpReplyOpcodeFlag);
			if (base.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success && length == global::Motorola.Common.Communication.RcmpCommon.RcmpBasicReplyHeaderSize + 2)
			{
				object[] array = new object[]
				{
					global::Motorola.Common.Communication.RcmpCommon.byteObj,
					global::Motorola.Common.Communication.RcmpCommon.byteObj
				};
				global::Motorola.Common.Communication.RcmpCommon.DecodeBytes(replyBuffer, offset + global::Motorola.Common.Communication.RcmpCommon.RcmpBasicReplyHeaderSize, length - global::Motorola.Common.Communication.RcmpCommon.RcmpBasicReplyHeaderSize, array);
				this.m_Action = (global::Motorola.Common.Communication.UpdateControlAction)array[0];
				this.m_Value = (byte)array[1];
			}
		}

		// Token: 0x04000256 RID: 598
		private global::Motorola.Common.Communication.UpdateControlAction m_Action;

		// Token: 0x04000257 RID: 599
		private byte m_Value;

		// Token: 0x04000258 RID: 600
		private byte m_Type;
	}
}
