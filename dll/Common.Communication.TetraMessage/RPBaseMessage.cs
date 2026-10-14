using System;
using System.Globalization;
using Motorola.Common.Communication.CommunicationPipe;

namespace Motorola.Common.Communication
{
	// Token: 0x02000011 RID: 17
	public abstract class RPBaseMessage : global::Motorola.Common.Communication.IMessage, global::System.IDisposable
	{
		// Token: 0x06000086 RID: 134 RVA: 0x0000487C File Offset: 0x00002A7C
		protected RPBaseMessage()
		{
			this._myOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.Undefined;
			this._myExecutor = new global::Motorola.Common.Communication.RPExecutor();
			this._hasReply = true;
			this._hasCommand = true;
			this.Disposed = false;
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000087 RID: 135 RVA: 0x000048C9 File Offset: 0x00002AC9
		// (set) Token: 0x06000088 RID: 136 RVA: 0x000048E0 File Offset: 0x00002AE0
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

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000089 RID: 137 RVA: 0x000048F6 File Offset: 0x00002AF6
		// (set) Token: 0x0600008A RID: 138 RVA: 0x000048FE File Offset: 0x00002AFE
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

		// Token: 0x0600008B RID: 139 RVA: 0x00004908 File Offset: 0x00002B08
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

		// Token: 0x0600008C RID: 140 RVA: 0x00004954 File Offset: 0x00002B54
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

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600008D RID: 141 RVA: 0x0000498C File Offset: 0x00002B8C
		// (set) Token: 0x0600008E RID: 142 RVA: 0x00004994 File Offset: 0x00002B94
		public global::Motorola.Common.Communication.TetraMsgOpResult OperationResult
		{
			get
			{
				return this._myOpResult;
			}
			set
			{
				this._myOpResult = value;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600008F RID: 143 RVA: 0x0000499D File Offset: 0x00002B9D
		// (set) Token: 0x06000090 RID: 144 RVA: 0x000049AA File Offset: 0x00002BAA
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

		// Token: 0x06000091 RID: 145
		public abstract void ExecuteMessage();

		// Token: 0x06000092 RID: 146 RVA: 0x000049B8 File Offset: 0x00002BB8
		protected virtual global::Motorola.Common.Communication.TetraMsgOpResult BuildCommandMessageInternal()
		{
			return global::Motorola.Common.Communication.TetraMsgOpResult.Undefined;
		}

		// Token: 0x06000093 RID: 147 RVA: 0x000049BC File Offset: 0x00002BBC
		protected virtual global::Motorola.Common.Communication.TetraMsgOpResult ParseReplyMessage(byte[] buffer)
		{
			return global::Motorola.Common.Communication.TetraMsgOpResult.Undefined;
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000094 RID: 148 RVA: 0x000049C0 File Offset: 0x00002BC0
		// (set) Token: 0x06000095 RID: 149 RVA: 0x000049C8 File Offset: 0x00002BC8
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

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000096 RID: 150 RVA: 0x000049D1 File Offset: 0x00002BD1
		// (set) Token: 0x06000097 RID: 151 RVA: 0x000049D9 File Offset: 0x00002BD9
		protected global::Motorola.Common.Communication.RPExecutor Executor
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

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000098 RID: 152 RVA: 0x000049E2 File Offset: 0x00002BE2
		// (set) Token: 0x06000099 RID: 153 RVA: 0x000049EA File Offset: 0x00002BEA
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

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600009A RID: 154 RVA: 0x000049F3 File Offset: 0x00002BF3
		// (set) Token: 0x0600009B RID: 155 RVA: 0x00004A0A File Offset: 0x00002C0A
		protected int WriteTimeout
		{
			get
			{
				if (this.TransportPipe != null)
				{
					return this._myExecutor.WriteTimeout;
				}
				return -1;
			}
			set
			{
				if (this.TransportPipe != null)
				{
					this._myExecutor.WriteTimeout = value;
				}
			}
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00004A20 File Offset: 0x00002C20
		protected global::Motorola.Common.Communication.TetraMsgOpResult GetMR55IndicationID(byte[] data, int offset, out string fetchedID)
		{
			string text = string.Empty;
			fetchedID = string.Empty;
			global::Motorola.Common.Communication.TetraMsgOpResult result = global::Motorola.Common.Communication.TetraMsgOpResult.Undefined;
			bool flag = true;
			if (data == null)
			{
				result = global::Motorola.Common.Communication.TetraMsgOpResult.RP_WRONG_PARAMETER;
				flag = false;
			}
			if (data.Length < 13 || offset < 0)
			{
				result = global::Motorola.Common.Communication.TetraMsgOpResult.RP_WRONG_PARAMETER;
				flag = false;
			}
			if (offset >= data.Length)
			{
				result = global::Motorola.Common.Communication.TetraMsgOpResult.RP_WRONG_PARAMETER;
				flag = false;
			}
			if (flag)
			{
				int i;
				for (i = 0; i < 7; i++)
				{
					byte b = data[offset + i];
					text += b.ToString("X2");
				}
				text += ((byte)(data[offset + i] >> 4)).ToString("X");
				fetchedID = text;
				result = global::Motorola.Common.Communication.TetraMsgOpResult.RP_SUCCESS;
			}
			return result;
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00004AB0 File Offset: 0x00002CB0
		protected global::Motorola.Common.Communication.TetraMsgOpResult GetMR56IndicationID(byte[] data, int offset, out string fetchedID)
		{
			string text = string.Empty;
			fetchedID = string.Empty;
			global::Motorola.Common.Communication.TetraMsgOpResult result = global::Motorola.Common.Communication.TetraMsgOpResult.Undefined;
			bool flag = true;
			if (data == null)
			{
				result = global::Motorola.Common.Communication.TetraMsgOpResult.RP_WRONG_PARAMETER;
				flag = false;
			}
			if (data.Length < 13 || offset < 0)
			{
				result = global::Motorola.Common.Communication.TetraMsgOpResult.RP_WRONG_PARAMETER;
				flag = false;
			}
			if (offset >= data.Length)
			{
				result = global::Motorola.Common.Communication.TetraMsgOpResult.RP_WRONG_PARAMETER;
				flag = false;
			}
			if (flag)
			{
				text += (data[offset] & 15).ToString("X2");
				for (int i = 1; i < 8; i++)
				{
					byte b = data[offset + i];
					text += b.ToString("X2");
				}
				text = text.Substring(1);
				fetchedID = text;
				result = global::Motorola.Common.Communication.TetraMsgOpResult.RP_SUCCESS;
			}
			return result;
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00004B48 File Offset: 0x00002D48
		protected global::Motorola.Common.Communication.TetraMsgOpResult GetSNFromIndicationID(byte[] data, int offset, out string fetchedID)
		{
			string empty = string.Empty;
			fetchedID = string.Empty;
			global::Motorola.Common.Communication.TetraMsgOpResult result = global::Motorola.Common.Communication.TetraMsgOpResult.Undefined;
			bool flag = true;
			if (data == null)
			{
				result = global::Motorola.Common.Communication.TetraMsgOpResult.RP_WRONG_PARAMETER;
				flag = false;
			}
			if (data.Length < 13 || offset < 0)
			{
				result = global::Motorola.Common.Communication.TetraMsgOpResult.RP_WRONG_PARAMETER;
				flag = false;
			}
			if (offset >= data.Length)
			{
				result = global::Motorola.Common.Communication.TetraMsgOpResult.RP_WRONG_PARAMETER;
				flag = false;
			}
			if (flag)
			{
				try
				{
					byte[] array = new byte[8];
					global::System.Array.Copy(data, offset, array, 0, array.Length);
					int num = (int)array[0] << 8 | (int)array[1];
					num = (num >> 1 & 4095);
					string text = string.Format("{0:X3}", num);
					int num2 = (int)array[1] << 8 | (int)array[2];
					num2 = (num2 >> 2 & 127);
					string text2 = global::System.Convert.ToChar(num2).ToString();
					int num3 = (int)array[2] << 8 | (int)array[3];
					num3 = (num3 >> 3 & 127);
					string text3 = global::System.Convert.ToChar(num3).ToString();
					int num4 = (int)array[3] << 8 | (int)array[4];
					num4 = (num4 >> 4 & 127);
					string text4 = global::System.Convert.ToChar(num4).ToString();
					string text5 = "";
					int num5 = (int)array[4] << 8 | (int)array[5];
					num5 = (num5 >> 5 & 127);
					text5 += global::System.Convert.ToChar(num5).ToString();
					num5 = ((int)array[5] << 8 | (int)array[6]);
					num5 = (num5 >> 6 & 127);
					text5 += global::System.Convert.ToChar(num5).ToString();
					num5 = ((int)array[6] << 8 | (int)array[7]);
					num5 = (num5 >> 7 & 127);
					text5 += global::System.Convert.ToChar(num5).ToString();
					num5 = (int)array[7] << 8;
					num5 = (num5 >> 8 & 127);
					text5 += global::System.Convert.ToChar(num5).ToString();
					fetchedID = string.Concat(new string[]
					{
						text,
						text2,
						text3,
						text4,
						text5
					});
					result = global::Motorola.Common.Communication.TetraMsgOpResult.RP_SUCCESS;
				}
				catch
				{
					result = global::Motorola.Common.Communication.TetraMsgOpResult.RP_WRONG_PARAMETER;
				}
			}
			return result;
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00004D5C File Offset: 0x00002F5C
		protected global::Motorola.Common.Communication.TetraMsgOpResult GetDieIDFromIndicationID(byte[] data, int offset, out string fetchedID)
		{
			string text = string.Empty;
			fetchedID = string.Empty;
			global::Motorola.Common.Communication.TetraMsgOpResult result = global::Motorola.Common.Communication.TetraMsgOpResult.Undefined;
			bool flag = true;
			if (data == null)
			{
				result = global::Motorola.Common.Communication.TetraMsgOpResult.RP_WRONG_PARAMETER;
				flag = false;
			}
			if (data.Length < 13 || offset < 0)
			{
				result = global::Motorola.Common.Communication.TetraMsgOpResult.RP_WRONG_PARAMETER;
				flag = false;
			}
			if (offset >= data.Length)
			{
				result = global::Motorola.Common.Communication.TetraMsgOpResult.RP_WRONG_PARAMETER;
				flag = false;
			}
			if (flag)
			{
				text += (data[offset] & 127).ToString("X2");
				for (int i = 1; i < 8; i++)
				{
					byte b = data[offset + i];
					text += b.ToString("X2");
				}
				fetchedID = text;
				result = global::Motorola.Common.Communication.TetraMsgOpResult.RP_SUCCESS;
			}
			return result;
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00004DEC File Offset: 0x00002FEC
		protected global::Motorola.Common.Communication.TetraMsgOpResult IsVaildID(byte[] data, int offset, out bool result)
		{
			string text = string.Empty;
			result = true;
			global::Motorola.Common.Communication.TetraMsgOpResult result2 = global::Motorola.Common.Communication.TetraMsgOpResult.Undefined;
			bool flag = true;
			if (data == null)
			{
				result2 = global::Motorola.Common.Communication.TetraMsgOpResult.RP_WRONG_PARAMETER;
				flag = false;
			}
			if (data.Length < 13 || offset < 0)
			{
				result2 = global::Motorola.Common.Communication.TetraMsgOpResult.RP_WRONG_PARAMETER;
				flag = false;
			}
			if (offset >= data.Length)
			{
				result2 = global::Motorola.Common.Communication.TetraMsgOpResult.RP_WRONG_PARAMETER;
				flag = false;
			}
			if (flag)
			{
				for (int i = offset; i < offset + (int)this.RP_TERMINAL_ID_LENGTH; i++)
				{
					byte b = data[i];
					text += b.ToString("X2", global::System.Globalization.CultureInfo.InvariantCulture);
				}
				if (text == this.RP_INVALID_ID)
				{
					result = false;
				}
				result2 = global::Motorola.Common.Communication.TetraMsgOpResult.RP_SUCCESS;
			}
			return result2;
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x00004E72 File Offset: 0x00003072
		// (set) Token: 0x060000A2 RID: 162 RVA: 0x00004E7A File Offset: 0x0000307A
		protected bool Disposed { get; set; }

		// Token: 0x060000A3 RID: 163 RVA: 0x00004E83 File Offset: 0x00003083
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00004E94 File Offset: 0x00003094
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

		// Token: 0x04000032 RID: 50
		private readonly ushort RP_TERMINAL_ID_LENGTH = 8;

		// Token: 0x04000033 RID: 51
		private readonly string RP_INVALID_ID = "FFFFFFFFFFFFFFFF";

		// Token: 0x04000034 RID: 52
		private bool _hasReply;

		// Token: 0x04000035 RID: 53
		private global::Motorola.Common.Communication.TetraMsgOpResult _myOpResult;

		// Token: 0x04000036 RID: 54
		private bool _hasCommand;

		// Token: 0x04000037 RID: 55
		private byte[] _myCommandBuffer;

		// Token: 0x04000038 RID: 56
		private global::Motorola.Common.Communication.RPExecutor _myExecutor;

		// Token: 0x04000039 RID: 57
		protected byte[] _myReplyMessageBuffer;
	}
}
