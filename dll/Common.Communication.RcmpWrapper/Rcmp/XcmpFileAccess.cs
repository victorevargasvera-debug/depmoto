using System;
using System.Text;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x02000066 RID: 102
	public class XcmpFileAccess : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000178 RID: 376 RVA: 0x000070A3 File Offset: 0x000052A3
		// (set) Token: 0x06000179 RID: 377 RVA: 0x000070B0 File Offset: 0x000052B0
		private string PathName
		{
			get
			{
				return this.m_pathName.ToString();
			}
			set
			{
				this.m_pathName = new global::System.Text.StringBuilder(value);
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x0600017A RID: 378 RVA: 0x000070BE File Offset: 0x000052BE
		public uint FileSize
		{
			get
			{
				return this.m_fileSz;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x0600017B RID: 379 RVA: 0x000070C6 File Offset: 0x000052C6
		private uint PathLength
		{
			get
			{
				return (uint)this.m_pathLen;
			}
		}

		// Token: 0x0600017C RID: 380 RVA: 0x000070D0 File Offset: 0x000052D0
		public XcmpFileAccess(ushort PartitionID, byte TransferType, uint OptionFlag, uint FileOffset, uint FileSize, ushort PathLength, string Path)
		{
			base.Opcode = 1093;
			this.m_xferType = TransferType;
			this.m_partID = PartitionID;
			this.m_optflg = OptionFlag;
			this.m_fileSz = FileSize;
			this.m_fileOffset = FileOffset;
			this.m_pathLen = PathLength;
			this.m_pathName = new global::System.Text.StringBuilder(Path);
			this.m_pathName.Append('\0');
			this.m_pathLen += 1;
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00007144 File Offset: 0x00005344
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			byte[] bytes = global::System.Text.Encoding.UTF8.GetBytes(this.m_pathName.ToString());
			this.m_pathLen = (ushort)bytes.Length;
			return global::Motorola.Common.Communication.RcmpCommon.ConstructBytes(buffer, offset, new object[]
			{
				base.Opcode,
				this.m_xferType,
				this.m_partID,
				this.m_optflg,
				this.m_fileSz,
				this.m_fileOffset,
				this.m_pathLen,
				bytes
			});
		}

		// Token: 0x0600017E RID: 382 RVA: 0x000071E8 File Offset: 0x000053E8
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			base.ReplyResult = global::Motorola.Common.Communication.RcmpCommon.CheckReplyHeader(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.RcmpCommon.RcmpReplyOpcodeFlag);
			if (base.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success && length >= global::Motorola.Common.Communication.RcmpCommon.RcmpBasicReplyHeaderSize + 17)
			{
				this.m_xferType = replyBuffer[offset + 3];
				this.m_partID = (ushort)((int)replyBuffer[offset + 5] | (int)replyBuffer[offset + 4] << 8);
				this.m_optflg = (uint)((int)replyBuffer[offset + 9] | (int)replyBuffer[offset + 8] << 8 | (int)replyBuffer[offset + 7] << 16 | (int)replyBuffer[offset + 6] << 24);
				this.m_fileSz = (uint)((int)replyBuffer[offset + 13] | (int)replyBuffer[offset + 12] << 8 | (int)replyBuffer[offset + 11] << 16 | (int)replyBuffer[offset + 10] << 24);
				this.m_fileOffset = (uint)((int)replyBuffer[offset + 17] | (int)replyBuffer[offset + 16] << 8 | (int)replyBuffer[offset + 15] << 16 | (int)replyBuffer[offset + 14] << 24);
				this.m_pathLen = (ushort)((int)replyBuffer[offset + 19] | (int)replyBuffer[offset + 18] << 8);
				this.m_pathName = new global::System.Text.StringBuilder(global::System.Text.Encoding.UTF8.GetString(replyBuffer, offset + 20, (int)this.m_pathLen));
			}
		}

		// Token: 0x040001FD RID: 509
		private uint m_fileSz;

		// Token: 0x040001FE RID: 510
		private uint m_fileOffset;

		// Token: 0x040001FF RID: 511
		private uint m_optflg;

		// Token: 0x04000200 RID: 512
		private ushort m_pathLen;

		// Token: 0x04000201 RID: 513
		private ushort m_partID;

		// Token: 0x04000202 RID: 514
		private global::System.Text.StringBuilder m_pathName;

		// Token: 0x04000203 RID: 515
		private byte m_xferType;

		// Token: 0x02000067 RID: 103
		public enum TransferType : byte
		{
			// Token: 0x04000205 RID: 517
			Read,
			// Token: 0x04000206 RID: 518
			Write,
			// Token: 0x04000207 RID: 519
			Erase,
			// Token: 0x04000208 RID: 520
			ReadFileList,
			// Token: 0x04000209 RID: 521
			ReadFileLength,
			// Token: 0x0400020A RID: 522
			CreateFile,
			// Token: 0x0400020B RID: 523
			GetFileCRC,
			// Token: 0x0400020C RID: 524
			GetFreeSpace
		}
	}
}
