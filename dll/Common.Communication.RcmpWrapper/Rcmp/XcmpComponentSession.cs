using System;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x0200002D RID: 45
	public class XcmpComponentSession : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x0600006C RID: 108 RVA: 0x00003B28 File Offset: 0x00001D28
		public XcmpComponentSession(ushort action, ushort sessionID, uint data)
		{
			base.Opcode = 271;
			this.m_actions = action;
			this.m_sessionID = sessionID;
			this.m_data = data;
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00003B50 File Offset: 0x00001D50
		public XcmpComponentSession(ushort action, ushort sessionID)
		{
			base.Opcode = 271;
			this.m_actions = action;
			this.m_sessionID = sessionID;
			this.m_data = 0U;
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600006E RID: 110 RVA: 0x00003B78 File Offset: 0x00001D78
		public ushort Action
		{
			get
			{
				return this.m_actions;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600006F RID: 111 RVA: 0x00003B80 File Offset: 0x00001D80
		public ushort SessionID
		{
			get
			{
				return this.m_sessionID;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000070 RID: 112 RVA: 0x00003B88 File Offset: 0x00001D88
		public ushort ReplySessionId
		{
			get
			{
				return this.replySessionId;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000071 RID: 113 RVA: 0x00003B90 File Offset: 0x00001D90
		public ushort CompletedActions
		{
			get
			{
				return this.completedActions;
			}
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00003B98 File Offset: 0x00001D98
		public static global::Motorola.Common.Communication.Rcmp.XcmpComponentSession DecodeCommandMessage(byte[] buffer, int start, int length)
		{
			object[] array = new object[3];
			int num = 0;
			array[0] = global::Motorola.Common.Communication.RcmpCommon.ushortObj;
			num += 2;
			array[1] = global::Motorola.Common.Communication.RcmpCommon.ushortObj;
			num += 2;
			array[2] = global::Motorola.Common.Communication.RcmpCommon.ushortObj;
			num += 2;
			if (num < length)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UnexpectedEndOfMsg);
			}
			global::Motorola.Common.Communication.RcmpCommon.DecodeBytes(buffer, start, num, array);
			global::Motorola.Common.Communication.Rcmp.XcmpComponentSession xcmpComponentSession = new global::Motorola.Common.Communication.Rcmp.XcmpComponentSession((ushort)array[1], (ushort)array[2]);
			if (xcmpComponentSession.Opcode != (ushort)array[0])
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UnexpectedRequestOpcode);
			}
			return xcmpComponentSession;
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00003C18 File Offset: 0x00001E18
		private byte[] BuildReplyMessage()
		{
			byte[] array = new byte[7];
			ushort num = 33039;
			global::Motorola.Common.Communication.RcmpCommon.ConstructBytes(array, 0, new object[]
			{
				num,
				0,
				this.m_actions,
				this.m_sessionID
			});
			return array;
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00003C74 File Offset: 0x00001E74
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			if ((this.m_actions & 2048) == 2048)
			{
				return global::Motorola.Common.Communication.RcmpCommon.ConstructBytes(buffer, offset, new object[]
				{
					base.Opcode,
					this.m_actions,
					this.m_sessionID,
					(ushort)this.m_data
				});
			}
			if ((this.m_actions & 32) != 32)
			{
				if (this.m_data == 0U)
				{
					return global::Motorola.Common.Communication.RcmpCommon.ConstructBytes(buffer, offset, new object[]
					{
						base.Opcode,
						this.m_actions,
						this.m_sessionID
					});
				}
				return global::Motorola.Common.Communication.RcmpCommon.ConstructBytes(buffer, offset, new object[]
				{
					base.Opcode,
					this.m_actions,
					this.m_sessionID,
					(ushort)this.m_data
				});
			}
			else
			{
				if ((this.m_actions & 64) == 64)
				{
					return global::Motorola.Common.Communication.RcmpCommon.ConstructBytes(buffer, offset, new object[]
					{
						base.Opcode,
						this.m_actions,
						this.m_sessionID,
						this.m_data
					});
				}
				return global::Motorola.Common.Communication.RcmpCommon.ConstructBytes(buffer, offset, new object[]
				{
					base.Opcode,
					this.m_actions,
					this.m_sessionID,
					(ushort)this.m_data
				});
			}
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00003E1C File Offset: 0x0000201C
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			base.ReplyResult = global::Motorola.Common.Communication.RcmpCommon.CheckReplyHeader(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.RcmpCommon.RcmpReplyOpcodeFlag);
			if (offset + 6 < replyBuffer.Length)
			{
				this.completedActions = (ushort)((int)replyBuffer[offset + 4] | (int)replyBuffer[offset + 3] << 8);
				this.replySessionId = (ushort)((int)replyBuffer[offset + 6] | (int)replyBuffer[offset + 5] << 8);
			}
		}

		// Token: 0x040000BB RID: 187
		public const ushort CommandOpcode = 271;

		// Token: 0x040000BC RID: 188
		public const ushort ReplyOpcode = 33039;

		// Token: 0x040000BD RID: 189
		private ushort completedActions;

		// Token: 0x040000BE RID: 190
		private ushort replySessionId;

		// Token: 0x040000BF RID: 191
		private ushort m_actions;

		// Token: 0x040000C0 RID: 192
		private ushort m_sessionID;

		// Token: 0x040000C1 RID: 193
		private uint m_data;

		// Token: 0x0200002E RID: 46
		[global::System.Flags]
		public enum Actions : ushort
		{
			// Token: 0x040000C3 RID: 195
			None = 0,
			// Token: 0x040000C4 RID: 196
			Reset = 1,
			// Token: 0x040000C5 RID: 197
			StartSession = 2,
			// Token: 0x040000C6 RID: 198
			Snapshot = 4,
			// Token: 0x040000C7 RID: 199
			ValidateCRC = 8,
			// Token: 0x040000C8 RID: 200
			UnpackFiles = 16,
			// Token: 0x040000C9 RID: 201
			Deploy = 32,
			// Token: 0x040000CA RID: 202
			DelayTOD = 64,
			// Token: 0x040000CB RID: 203
			SuppressPN = 128,
			// Token: 0x040000CC RID: 204
			Status = 256,
			// Token: 0x040000CD RID: 205
			ReadWrite = 512,
			// Token: 0x040000CE RID: 206
			CreateArchive = 1024,
			// Token: 0x040000CF RID: 207
			ProgrammingIndicator = 2048
		}

		// Token: 0x0200002F RID: 47
		[global::System.Flags]
		public enum SessionReplyResult : ushort
		{
			// Token: 0x040000D1 RID: 209
			Success = 0,
			// Token: 0x040000D2 RID: 210
			Failure = 1,
			// Token: 0x040000D3 RID: 211
			InvalidParameter = 4,
			// Token: 0x040000D4 RID: 212
			InvalidSessionID = 16,
			// Token: 0x040000D5 RID: 213
			InvalidArchive = 17
		}
	}
}
