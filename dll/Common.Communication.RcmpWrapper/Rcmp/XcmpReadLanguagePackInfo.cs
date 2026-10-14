using System;
using System.Collections.Generic;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x0200006B RID: 107
	public class XcmpReadLanguagePackInfo : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000183 RID: 387 RVA: 0x00007492 File Offset: 0x00005692
		// (set) Token: 0x06000184 RID: 388 RVA: 0x0000749A File Offset: 0x0000569A
		public uint AvailableSpace { get; private set; }

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000185 RID: 389 RVA: 0x000074A3 File Offset: 0x000056A3
		// (set) Token: 0x06000186 RID: 390 RVA: 0x000074AB File Offset: 0x000056AB
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.Rcmp.LanguagePackInfo> LanguagePackInfo { get; private set; }

		// Token: 0x06000187 RID: 391 RVA: 0x000074B4 File Offset: 0x000056B4
		public XcmpReadLanguagePackInfo(global::Motorola.Common.Communication.Rcmp.ReadLanguagePackInfoOperation operation, string queryLanguangePackID = null)
		{
			if (operation == global::Motorola.Common.Communication.Rcmp.ReadLanguagePackInfoOperation.SingleLanguagePack && string.IsNullOrEmpty(queryLanguangePackID))
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgument);
			}
			base.Opcode = 44;
			this.operation = operation;
			this.queryLanguagePackID = queryLanguangePackID;
		}

		// Token: 0x06000188 RID: 392 RVA: 0x000074E4 File Offset: 0x000056E4
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			if (string.IsNullOrEmpty(this.queryLanguagePackID))
			{
				return global::Motorola.Common.Communication.RcmpCommon.ConstructBytes(buffer, offset, new object[]
				{
					base.Opcode,
					(byte)this.operation
				});
			}
			byte[] array = new byte[16];
			global::Motorola.Common.Communication.RcmpCommon.ConstructUCS2StringToBytes(this.queryLanguagePackID, array, 0, false);
			return global::Motorola.Common.Communication.RcmpCommon.ConstructBytes(buffer, offset, new object[]
			{
				base.Opcode,
				(byte)this.operation,
				array
			});
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00007570 File Offset: 0x00005770
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			base.ReplyResult = global::Motorola.Common.Communication.RcmpCommon.CheckReplyHeader(replyBuffer, offset, base.Opcode | 32768);
			offset += global::Motorola.Common.Communication.RcmpCommon.RcmpBasicReplyHeaderSize;
			if (base.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				this.decodeLanguagePackInfo(replyBuffer, offset, length);
			}
		}

		// Token: 0x0600018A RID: 394 RVA: 0x000075A8 File Offset: 0x000057A8
		private void decodeLanguagePackInfo(byte[] replyBuffer, int offset, int length)
		{
			this.AvailableSpace = global::Motorola.Common.Communication.RcmpCommon.DecodeBytesToUInt32(replyBuffer, offset);
			offset += 4;
			int num = (int)replyBuffer[offset];
			offset++;
			this.LanguagePackInfo = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Rcmp.LanguagePackInfo>(num);
			for (int i = 0; i < num; i++)
			{
				if (this.operation == global::Motorola.Common.Communication.Rcmp.ReadLanguagePackInfoOperation.AllTTSLanguagePack)
				{
					this.decodeTTSLanguagePackStructure(replyBuffer, ref offset, length);
				}
				else
				{
					this.decodeLanguagePackStructure(replyBuffer, ref offset, length);
				}
			}
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00007608 File Offset: 0x00005808
		private void decodeTTSLanguagePackStructure(byte[] replyBuffer, ref int offset, int length)
		{
			global::Motorola.Common.Communication.Rcmp.LanguagePackInfo languagePackInfo = new global::Motorola.Common.Communication.Rcmp.LanguagePackInfo();
			byte b = replyBuffer[offset];
			offset++;
			languagePackInfo.PackID = global::Motorola.Common.Communication.RcmpCommon.DecodeBytesToUCS2String(replyBuffer, offset, 16);
			offset += 16;
			languagePackInfo.MajorVersion = global::Motorola.Common.Communication.RcmpCommon.DecodeBytesToUInt32(replyBuffer, offset);
			offset += 4;
			languagePackInfo.MinorVersion = global::Motorola.Common.Communication.RcmpCommon.DecodeBytesToUInt32(replyBuffer, offset);
			offset += 4;
			languagePackInfo.Size = global::Motorola.Common.Communication.RcmpCommon.DecodeBytesToUInt32(replyBuffer, offset);
			offset += 4;
			languagePackInfo.TTSLanguageCode = global::Motorola.Common.Communication.RcmpCommon.DecodeBytesToUCS2String(replyBuffer, offset, 12);
			offset += 12;
			languagePackInfo.TTSVoiceGender = replyBuffer[offset];
			offset++;
			languagePackInfo.TTSSpeakerNameSize = (uint)replyBuffer[offset];
			offset++;
			int ttsspeakerNameSize = (int)languagePackInfo.TTSSpeakerNameSize;
			languagePackInfo.TTSSpeakerName = global::Motorola.Common.Communication.RcmpCommon.DecodeBytesToUCS2String(replyBuffer, offset, ttsspeakerNameSize);
			offset += ttsspeakerNameSize;
			languagePackInfo.TTSNameSize = (uint)replyBuffer[offset];
			offset++;
			int ttsnameSize = (int)languagePackInfo.TTSNameSize;
			languagePackInfo.Name = global::Motorola.Common.Communication.RcmpCommon.DecodeBytesToUCS2String(replyBuffer, offset, ttsnameSize);
			offset += ttsnameSize;
			this.LanguagePackInfo.Add(languagePackInfo);
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00007704 File Offset: 0x00005904
		private void decodeLanguagePackStructure(byte[] replyBuffer, ref int offset, int length)
		{
			global::Motorola.Common.Communication.Rcmp.LanguagePackInfo languagePackInfo = new global::Motorola.Common.Communication.Rcmp.LanguagePackInfo();
			int num = (int)replyBuffer[offset];
			offset++;
			languagePackInfo.PackID = global::Motorola.Common.Communication.RcmpCommon.DecodeBytesToUCS2String(replyBuffer, offset, 16);
			offset += 16;
			languagePackInfo.MajorVersion = global::Motorola.Common.Communication.RcmpCommon.DecodeBytesToUInt32(replyBuffer, offset);
			offset += 4;
			languagePackInfo.MinorVersion = global::Motorola.Common.Communication.RcmpCommon.DecodeBytesToUInt32(replyBuffer, offset);
			offset += 4;
			languagePackInfo.Size = global::Motorola.Common.Communication.RcmpCommon.DecodeBytesToUInt32(replyBuffer, offset);
			offset += 4;
			int num2 = num - 29;
			languagePackInfo.Name = global::Motorola.Common.Communication.RcmpCommon.DecodeBytesToUCS2String(replyBuffer, offset, num2);
			offset += num2;
			this.LanguagePackInfo.Add(languagePackInfo);
		}

		// Token: 0x0400021A RID: 538
		private global::Motorola.Common.Communication.Rcmp.ReadLanguagePackInfoOperation operation;

		// Token: 0x0400021B RID: 539
		private string queryLanguagePackID;
	}
}
