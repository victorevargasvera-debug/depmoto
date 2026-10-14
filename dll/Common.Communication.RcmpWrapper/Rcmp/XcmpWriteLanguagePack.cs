using System;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x0200007C RID: 124
	public class XcmpWriteLanguagePack : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x060001CD RID: 461 RVA: 0x00008A8C File Offset: 0x00006C8C
		public XcmpWriteLanguagePack(global::Motorola.Common.Communication.Rcmp.LanguagePackControlOperation operation, string languagePackID, byte[] languagePackPayloadUnit, bool bigEndianForPackID = false)
		{
			if ((operation == global::Motorola.Common.Communication.Rcmp.LanguagePackControlOperation.AddLanguagePackStart && string.IsNullOrEmpty(languagePackID)) || (operation == global::Motorola.Common.Communication.Rcmp.LanguagePackControlOperation.AddLanguagePackUnit && languagePackPayloadUnit == null))
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgument);
			}
			base.Opcode = 43;
			this.operation = operation;
			this.languagePackID = languagePackID;
			this.languagePackPayloadUnit = languagePackPayloadUnit;
			this.bigEndianForPackID = bigEndianForPackID;
			base.ReadTimeout = 50000;
		}

		// Token: 0x060001CE RID: 462 RVA: 0x00008AE8 File Offset: 0x00006CE8
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			if (this.operation == global::Motorola.Common.Communication.Rcmp.LanguagePackControlOperation.AddLanguagePackStart)
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
			if (this.operation == global::Motorola.Common.Communication.Rcmp.LanguagePackControlOperation.AddLanguagePackEnd)
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

		// Token: 0x060001CF RID: 463 RVA: 0x00008BDF File Offset: 0x00006DDF
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			base.ReplyResult = global::Motorola.Common.Communication.RcmpCommon.CheckReplyHeader(replyBuffer, offset, base.Opcode | 32768);
		}

		// Token: 0x0400027A RID: 634
		private global::Motorola.Common.Communication.Rcmp.LanguagePackControlOperation operation;

		// Token: 0x0400027B RID: 635
		private string languagePackID;

		// Token: 0x0400027C RID: 636
		private byte[] languagePackPayloadUnit;

		// Token: 0x0400027D RID: 637
		private bool bigEndianForPackID;
	}
}
