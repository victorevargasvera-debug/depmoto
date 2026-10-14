using System;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x02000025 RID: 37
	public class FpgaOperation : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x06000054 RID: 84 RVA: 0x00003661 File Offset: 0x00001861
		public FpgaOperation(global::Motorola.Common.Communication.Rcmp.FPGAOperationType operation, global::Motorola.Common.Communication.Rcmp.FpgaOperationID fpgaID)
		{
			base.Opcode = 520;
			this.operation = (byte)(operation | (global::Motorola.Common.Communication.Rcmp.FPGAOperationType)fpgaID);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00003680 File Offset: 0x00001880
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			return global::Motorola.Common.Communication.RcmpCommon.ConstructBytes(buffer, offset, new object[]
			{
				base.Opcode,
				this.operation
			});
		}

		// Token: 0x06000056 RID: 86 RVA: 0x000036B8 File Offset: 0x000018B8
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			base.ReplyResult = global::Motorola.Common.Communication.RcmpCommon.CheckReplyHeader(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.RcmpCommon.RcmpReplyOpcodeFlag);
			offset += global::Motorola.Common.Communication.RcmpCommon.RcmpBasicReplyHeaderSize;
			if (base.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success || (base.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.LockSequenceFailure && this.operation == 64))
			{
				byte b = replyBuffer[offset];
				if (b != this.operation)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.GenericError);
				}
			}
		}

		// Token: 0x040000AB RID: 171
		private byte operation;
	}
}
