using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x02000015 RID: 21
	public class XcmpDeleteTTSLanguagePack : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x06000035 RID: 53 RVA: 0x00002C2D File Offset: 0x00000E2D
		public XcmpDeleteTTSLanguagePack(string languagePackID, bool bigEndianForPackID = false)
		{
			if (languagePackID == null)
			{
				languagePackID = string.Empty;
			}
			base.Opcode = 43;
			this.languagePackID = languagePackID;
			this.bigEndianForPackID = bigEndianForPackID;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002C58 File Offset: 0x00000E58
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			byte[] array = new byte[16];
			global::System.Array.Clear(array, 0, array.Length);
			global::Motorola.Common.Communication.RcmpCommon.ConstructUCS2StringToBytes(this.languagePackID, array, 0, this.bigEndianForPackID);
			return global::Motorola.Common.Communication.RcmpCommon.ConstructBytes(buffer, offset, new object[]
			{
				base.Opcode,
				48,
				array,
				0
			});
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002CBF File Offset: 0x00000EBF
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			base.ReplyResult = global::Motorola.Common.Communication.RcmpCommon.CheckReplyHeader(replyBuffer, offset, base.Opcode | 32768);
		}

		// Token: 0x04000059 RID: 89
		private string languagePackID;

		// Token: 0x0400005A RID: 90
		private bool bigEndianForPackID;
	}
}
