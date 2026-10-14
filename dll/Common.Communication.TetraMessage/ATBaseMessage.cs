using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Motorola.Common.Communication.CommunicationPipe;

namespace Motorola.Common.Communication
{
	// Token: 0x02000002 RID: 2
	public abstract class ATBaseMessage : global::Motorola.Common.Communication.IMessage, global::System.IDisposable
	{
		// Token: 0x06000001 RID: 1 RVA: 0x000020D8 File Offset: 0x000002D8
		protected ATBaseMessage()
		{
			this._myOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.Undefined;
			this._myExecutor = new global::Motorola.Common.Communication.ATExecutor();
			this._hasCommand = true;
			this._hasReply = true;
			this.Disposed = false;
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000002 RID: 2 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x06000003 RID: 3 RVA: 0x00002141 File Offset: 0x00000341
		public int ReadTimeout
		{
			get
			{
				if (this.TransportPipe != null)
				{
					return this.TransportPipe.ReceiveTimeout;
				}
				return -1;
			}
			set
			{
				if (this.TransportPipe != null)
				{
					this.TransportPipe.ReceiveTimeout = value;
				}
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000004 RID: 4 RVA: 0x00002157 File Offset: 0x00000357
		// (set) Token: 0x06000005 RID: 5 RVA: 0x0000215F File Offset: 0x0000035F
		public bool hasReply
		{
			get
			{
				return this._hasReply;
			}
			set
			{
				this._hasReply = value;
			}
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002168 File Offset: 0x00000368
		public int BuildCommandMessage(byte[] sendBuffer)
		{
			this.BuildCommandMessageInternal();
			if (this._hasCommand)
			{
				sendBuffer = new byte[this._myCommandBuffer.Length];
				global::System.Array.Copy(this._myCommandBuffer, sendBuffer, this._myCommandBuffer.Length);
				return this._myCommandBuffer.Length;
			}
			sendBuffer = null;
			return 0;
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000021B4 File Offset: 0x000003B4
		public void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			if (length <= 0 || offset < 0)
			{
				return;
			}
			this._myReplyMessageBuffer = new byte[length];
			global::System.Array.Copy(replyBuffer, offset, this._myReplyMessageBuffer, 0, length);
			this._myOpResult = this.ParseReplyMessage(this._myReplyMessageBuffer);
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000008 RID: 8 RVA: 0x000021EC File Offset: 0x000003EC
		// (set) Token: 0x06000009 RID: 9 RVA: 0x000021F4 File Offset: 0x000003F4
		public global::Motorola.Common.Communication.TetraMsgOpResult OperationResult
		{
			get
			{
				return this._myOpResult;
			}
			protected set
			{
				this._myOpResult = value;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000A RID: 10 RVA: 0x000021FD File Offset: 0x000003FD
		// (set) Token: 0x0600000B RID: 11 RVA: 0x0000220A File Offset: 0x0000040A
		public global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe TransportPipe
		{
			get
			{
				return this._myExecutor.CommPipe;
			}
			set
			{
				this._myExecutor.CommPipe = value;
			}
		}

		// Token: 0x0600000C RID: 12
		public abstract void ExecuteMessage();

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000D RID: 13 RVA: 0x00002218 File Offset: 0x00000418
		// (set) Token: 0x0600000E RID: 14 RVA: 0x00002225 File Offset: 0x00000425
		protected int WriteTimeout
		{
			get
			{
				return this._myExecutor.WriteTimeout;
			}
			set
			{
				this._myExecutor.WriteTimeout = value;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000F RID: 15 RVA: 0x00002233 File Offset: 0x00000433
		// (set) Token: 0x06000010 RID: 16 RVA: 0x0000223B File Offset: 0x0000043B
		protected bool HasCommand
		{
			get
			{
				return this._hasCommand;
			}
			set
			{
				this._hasCommand = value;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000011 RID: 17 RVA: 0x00002244 File Offset: 0x00000444
		// (set) Token: 0x06000012 RID: 18 RVA: 0x0000224C File Offset: 0x0000044C
		protected global::Motorola.Common.Communication.ATExecutor Executor
		{
			get
			{
				return this._myExecutor;
			}
			set
			{
				this._myExecutor = value;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000013 RID: 19 RVA: 0x00002255 File Offset: 0x00000455
		// (set) Token: 0x06000014 RID: 20 RVA: 0x0000225D File Offset: 0x0000045D
		protected byte[] MyCommandBuffer
		{
			get
			{
				return this._myCommandBuffer;
			}
			set
			{
				this._myCommandBuffer = value;
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002266 File Offset: 0x00000466
		protected virtual global::Motorola.Common.Communication.TetraMsgOpResult BuildCommandMessageInternal()
		{
			return global::Motorola.Common.Communication.TetraMsgOpResult.Undefined;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x0000226A File Offset: 0x0000046A
		protected virtual global::Motorola.Common.Communication.TetraMsgOpResult ParseReplyMessage(byte[] buffer)
		{
			return global::Motorola.Common.Communication.TetraMsgOpResult.Undefined;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002270 File Offset: 0x00000470
		protected global::Motorola.Common.Communication.TetraMsgOpResult GetErrorReason(string replyStr)
		{
			global::System.Text.RegularExpressions.Regex regex = new global::System.Text.RegularExpressions.Regex("<CR><LF>\\+CME ERROR: ([0-9]*)<CR><LF>");
			global::System.Text.RegularExpressions.Match match = regex.Match(replyStr);
			global::Motorola.Common.Communication.TetraMsgOpResult result;
			if (match.Success && match.Groups.Count == 2)
			{
				string text = match.Groups[1].ToString();
				string key;
				switch (key = text)
				{
				case "3":
					return global::Motorola.Common.Communication.TetraMsgOpResult.AT_DEVICE_BUSY;
				case "11":
					return global::Motorola.Common.Communication.TetraMsgOpResult.AT_PASSWORD_REQUIRED;
				case "16":
					return global::Motorola.Common.Communication.TetraMsgOpResult.AT_WRONG_PASSWORD;
				case "33":
				case "34":
				case "35":
					return global::Motorola.Common.Communication.TetraMsgOpResult.AT_WRONG_PARAMETER;
				case "511":
					return global::Motorola.Common.Communication.TetraMsgOpResult.AT_PASSWORD_REQUIRED;
				case "520":
					return global::Motorola.Common.Communication.TetraMsgOpResult.AT_LOW_BATTERY;
				case "521":
					return global::Motorola.Common.Communication.TetraMsgOpResult.AT_MS_IN_EMERGENCY;
				}
				result = global::Motorola.Common.Communication.TetraMsgOpResult.AT_GENERAL_ERROR;
			}
			else
			{
				result = global::Motorola.Common.Communication.TetraMsgOpResult.AT_PARSE_REPLY_ERROR;
			}
			return result;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000023B8 File Offset: 0x000005B8
		protected global::Motorola.Common.Communication.TetraMsgOpResult GetErrorReason(byte[] replyData)
		{
			bool flag = true;
			string text = string.Empty;
			global::Motorola.Common.Communication.TetraMsgOpResult result = global::Motorola.Common.Communication.TetraMsgOpResult.AT_GENERAL_ERROR;
			if (replyData == null || replyData.Length == 0)
			{
				flag = false;
			}
			if (flag)
			{
				text = this.MsgDataToString(replyData);
				if (string.IsNullOrEmpty(text))
				{
					flag = false;
				}
			}
			if (flag)
			{
				result = this.GetErrorReason(text);
			}
			return result;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000023FC File Offset: 0x000005FC
		protected bool IsATCommandOK(byte[] replyData)
		{
			if (replyData == null)
			{
				return false;
			}
			if (replyData.Length != this.AT_REPLY_OK.Length)
			{
				string replyStr = this.MsgDataToString(replyData);
				return this.IsATCommandOK(replyStr);
			}
			for (int i = 0; i < replyData.Length; i++)
			{
				if (replyData[i] != this.AT_REPLY_OK[i])
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x0000244C File Offset: 0x0000064C
		protected bool IsATCommandOK(string replyStr)
		{
			if (string.IsNullOrEmpty(replyStr))
			{
				return false;
			}
			string value = "<CR><LF>OK<CR><LF>";
			return replyStr.IndexOf(value, global::System.StringComparison.Ordinal) != -1;
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002478 File Offset: 0x00000678
		protected byte[] StringToMsgData(string msgStr)
		{
			global::System.Collections.Generic.List<byte> list = new global::System.Collections.Generic.List<byte>();
			int i = 0;
			while (i < msgStr.Length)
			{
				char c = msgStr[i];
				if (c == '<')
				{
					int num = msgStr.IndexOf('>', i + 1);
					if (num == -1)
					{
						return null;
					}
					string tag = msgStr.Substring(i, num - i + 1);
					list.Add(this.SpecialTagToByte(tag));
					i = num + 1;
				}
				else if (c == ' ' || c == '_')
				{
					list.Add(32);
					i++;
				}
				else
				{
					list.Add((byte)c);
					i++;
				}
			}
			return list.ToArray();
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002504 File Offset: 0x00000704
		protected string MsgDataToString(byte[] data)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			int i = 0;
			while (i < data.Length)
			{
				byte b = data[i];
				byte b2 = b;
				if (b2 <= 13)
				{
					switch (b2)
					{
					case 8:
						stringBuilder.Append("<BS>");
						break;
					case 9:
						goto IL_A7;
					case 10:
						stringBuilder.Append("<LF>");
						break;
					default:
						if (b2 != 13)
						{
							goto IL_A7;
						}
						stringBuilder.Append("<CR>");
						break;
					}
				}
				else
				{
					switch (b2)
					{
					case 26:
						stringBuilder.Append("<EOF>");
						break;
					case 27:
						stringBuilder.Append("<ESC>");
						break;
					default:
						if (b2 != 32)
						{
							goto IL_A7;
						}
						stringBuilder.Append(" ");
						break;
					}
				}
				IL_B4:
				i++;
				continue;
				IL_A7:
				stringBuilder.Append(global::System.Convert.ToChar(b));
				goto IL_B4;
			}
			return stringBuilder.ToString();
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600001D RID: 29 RVA: 0x000025D8 File Offset: 0x000007D8
		// (set) Token: 0x0600001E RID: 30 RVA: 0x000025E0 File Offset: 0x000007E0
		protected bool Disposed { get; set; }

		// Token: 0x0600001F RID: 31 RVA: 0x000025EC File Offset: 0x000007EC
		private byte SpecialTagToByte(string tag)
		{
			byte result = 0;
			switch (tag)
			{
			case "<CR>":
				result = 13;
				break;
			case "<LF>":
				result = 10;
				break;
			case "<EOF>":
				result = 26;
				break;
			case "<ESC>":
				result = 27;
				break;
			case "<BS>":
				result = 8;
				break;
			case "<_>":
				result = 32;
				break;
			}
			return result;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x000026AE File Offset: 0x000008AE
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000026C0 File Offset: 0x000008C0
		protected virtual void Dispose(bool disposing)
		{
			if (this.Disposed)
			{
				return;
			}
			try
			{
				if (disposing)
				{
					this._myExecutor.Dispose();
				}
			}
			finally
			{
				this.Disposed = true;
			}
		}

		// Token: 0x04000001 RID: 1
		private const byte LF = 10;

		// Token: 0x04000002 RID: 2
		private const byte EOF = 26;

		// Token: 0x04000003 RID: 3
		private const byte ESC = 27;

		// Token: 0x04000004 RID: 4
		private const byte BS = 8;

		// Token: 0x04000005 RID: 5
		private const byte SPACE = 32;

		// Token: 0x04000006 RID: 6
		protected const byte CR = 13;

		// Token: 0x04000007 RID: 7
		private readonly byte[] AT_REPLY_OK = new byte[]
		{
			13,
			10,
			79,
			75,
			13,
			10
		};

		// Token: 0x04000008 RID: 8
		private bool _hasCommand;

		// Token: 0x04000009 RID: 9
		private bool _hasReply;

		// Token: 0x0400000A RID: 10
		private global::Motorola.Common.Communication.ATExecutor _myExecutor;

		// Token: 0x0400000B RID: 11
		private byte[] _myCommandBuffer;

		// Token: 0x0400000C RID: 12
		private global::Motorola.Common.Communication.TetraMsgOpResult _myOpResult;

		// Token: 0x0400000D RID: 13
		protected byte[] _myReplyMessageBuffer;
	}
}
