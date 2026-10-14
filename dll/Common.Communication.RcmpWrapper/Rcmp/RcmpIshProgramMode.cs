using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x0200004F RID: 79
	public class RcmpIshProgramMode : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x17000066 RID: 102
		// (get) Token: 0x0600011E RID: 286 RVA: 0x00005F18 File Offset: 0x00004118
		private byte Action
		{
			get
			{
				return this.m_Action;
			}
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00005F20 File Offset: 0x00004120
		public RcmpIshProgramMode(byte action)
		{
			base.Opcode = 262;
			this.m_Action = action;
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00005F3A File Offset: 0x0000413A
		public RcmpIshProgramMode(byte action, byte[] optionalData) : this(action)
		{
			this.m_OptionalData = optionalData;
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00005F4C File Offset: 0x0000414C
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			if (this.m_OptionalData != null && this.m_OptionalData.Length > 0)
			{
				return global::Motorola.Common.Communication.RcmpCommon.ConstructBytes(buffer, offset, new object[]
				{
					base.Opcode,
					this.m_Action,
					this.m_OptionalData
				});
			}
			return global::Motorola.Common.Communication.RcmpCommon.ConstructBytes(buffer, offset, new object[]
			{
				base.Opcode,
				this.m_Action
			});
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00005FCC File Offset: 0x000041CC
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			base.ReplyResult = global::Motorola.Common.Communication.RcmpCommon.CheckReplyHeader(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.RcmpCommon.RcmpReplyOpcodeFlag);
		}

		// Token: 0x04000177 RID: 375
		private byte m_Action;

		// Token: 0x04000178 RID: 376
		private byte[] m_OptionalData;

		// Token: 0x02000050 RID: 80
		public enum Actions
		{
			// Token: 0x0400017A RID: 378
			EnterProgramMode,
			// Token: 0x0400017B RID: 379
			ExitWithRadioReset,
			// Token: 0x0400017C RID: 380
			EnterCloneMode,
			// Token: 0x0400017D RID: 381
			ExitWithoutRadioReset,
			// Token: 0x0400017E RID: 382
			EnterOtapWriteMode,
			// Token: 0x0400017F RID: 383
			EnterOtapReadMode,
			// Token: 0x04000180 RID: 384
			ExitOtapModeWithChecksum,
			// Token: 0x04000181 RID: 385
			EnterRemoteProgrammingMode
		}
	}
}
