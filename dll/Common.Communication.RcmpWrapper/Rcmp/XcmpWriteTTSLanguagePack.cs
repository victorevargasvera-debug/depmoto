using System;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x0200007E RID: 126
	public class XcmpWriteTTSLanguagePack : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x060001D0 RID: 464 RVA: 0x00008BFC File Offset: 0x00006DFC
		public XcmpWriteTTSLanguagePack(global::Motorola.Common.Communication.Rcmp.TTSLanguagePackControlOperation operation, string languagePackID, byte[] languagePackPayloadUnit, bool bigEndianForPackID = false)
		{
			if ((operation == global::Motorola.Common.Communication.Rcmp.TTSLanguagePackControlOperation.AddTTSLanguagePackStart && string.IsNullOrEmpty(languagePackID)) || (operation == global::Motorola.Common.Communication.Rcmp.TTSLanguagePackControlOperation.AddTTSLanguagePackUnit && languagePackPayloadUnit == null))
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgument);
			}
			base.Opcode = 43;
			this.operation = operation;
			this.languagePackID = languagePackID;
			this.languagePackPayloadUnit = languagePackPayloadUnit;
			this.bigEndianForPackID = bigEndianForPackID;
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00008C50 File Offset: 0x00006E50
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			if (this.operation == global::Motorola.Common.Communication.Rcmp.TTSLanguagePackControlOperation.AddTTSLanguagePackStart)
			{
				byte[] array = new byte[16];
				global::System.Array.Clear(array, 0, array.Length);
				global::Motorola.Common.Communication.RcmpCommon.ConstructUCS2StringToBytes(this.languagePackID, array, 0, this.bigEndianForPackID);
				return global::Motorola.Common.Communication.RcmpCommon.ConstructBytes(buffer, offset, new object[]
				{
					base.Opcode,
					(byte)this.operation,
					array,
					0
				});
			}
			if (this.operation == global::Motorola.Common.Communication.Rcmp.TTSLanguagePackControlOperation.AddTTSLanguagePackEnd)
			{
				return global::Motorola.Common.Communication.RcmpCommon.ConstructBytes(buffer, offset, new object[]
				{
					base.Opcode,
					(byte)this.operation,
					0
				});
			}
			return global::Motorola.Common.Communication.RcmpCommon.ConstructBytes(buffer, offset, new object[]
			{
				base.Opcode,
				(byte)this.operation,
				(ushort)this.languagePackPayloadUnit.Length,
				this.languagePackPayloadUnit
			});
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00008D4A File Offset: 0x00006F4A
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			base.ReplyResult = global::Motorola.Common.Communication.RcmpCommon.CheckReplyHeader(replyBuffer, offset, base.Opcode | 32768);
		}

		// Token: 0x04000284 RID: 644
		private global::Motorola.Common.Communication.Rcmp.TTSLanguagePackControlOperation operation;

		// Token: 0x04000285 RID: 645
		private string languagePackID;

		// Token: 0x04000286 RID: 646
		private byte[] languagePackPayloadUnit;

		// Token: 0x04000287 RID: 647
		private bool bigEndianForPackID;
	}
}
