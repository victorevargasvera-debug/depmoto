using System;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x02000065 RID: 101
	public class XcmpDeleteLanguagePack : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x06000175 RID: 373 RVA: 0x00006FE7 File Offset: 0x000051E7
		public XcmpDeleteLanguagePack(string languagePackID, bool bigEndianForPackID = false)
		{
			if (string.IsNullOrEmpty(languagePackID))
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgument);
			}
			base.Opcode = 43;
			this.languagePackID = languagePackID;
			this.bigEndianForPackID = bigEndianForPackID;
			base.ReadTimeout = 50000;
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00007020 File Offset: 0x00005220
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			byte[] array = new byte[16];
			global::System.Array.Clear(array, 0, array.Length);
			global::Motorola.Common.Communication.RcmpCommon.ConstructUCS2StringToBytes(this.languagePackID, array, 0, this.bigEndianForPackID);
			return global::Motorola.Common.Communication.RcmpCommon.ConstructBytes(buffer, offset, new object[]
			{
				base.Opcode,
				16,
				array,
				0
			});
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00007087 File Offset: 0x00005287
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			base.ReplyResult = global::Motorola.Common.Communication.RcmpCommon.CheckReplyHeader(replyBuffer, offset, base.Opcode | 32768);
		}

		// Token: 0x040001FB RID: 507
		private string languagePackID;

		// Token: 0x040001FC RID: 508
		private bool bigEndianForPackID;
	}
}
