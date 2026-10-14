using System;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.TetraUtility;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication
{
	// Token: 0x02000015 RID: 21
	public abstract class SBEPBaseMessage : global::Motorola.Common.Communication.IMessage
	{
		// Token: 0x060000C7 RID: 199 RVA: 0x000055FD File Offset: 0x000037FD
		protected SBEPBaseMessage()
		{
			this._myOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.Undefined;
			this._myOpFlag = 1U;
			this._bAddCheckSum = true;
			this._myExecutor = new global::Motorola.Common.Communication.SbepMessageExecutor();
			this._bHasReply = true;
			this.Disposed = false;
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x00005634 File Offset: 0x00003834
		// (set) Token: 0x060000C9 RID: 201 RVA: 0x0000563C File Offset: 0x0000383C
		public int ReadTimeout
		{
			get
			{
				return this._readTimeout;
			}
			set
			{
				this._readTimeout = value;
				if (this.TransportPipe != null)
				{
					this.TransportPipe.ReceiveTimeout = this._readTimeout;
				}
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000CA RID: 202 RVA: 0x0000565E File Offset: 0x0000385E
		// (set) Token: 0x060000CB RID: 203 RVA: 0x00005666 File Offset: 0x00003866
		public bool hasReply
		{
			get
			{
				return this._bHasReply;
			}
			set
			{
				this._bHasReply = value;
			}
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00005670 File Offset: 0x00003870
		public virtual int BuildCommandMessage(byte[] sendBuffer)
		{
			global::Motorola.Common.Communication.TetraMsgOpResult tetraMsgOpResult = this.BaseBuildCommandMessage();
			if (tetraMsgOpResult != global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS || this._myCommandBuffer == null || this._myCommandBuffer.Length <= 0)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CCCSbepBuildBufferFail);
			}
			sendBuffer = new byte[this._myCommandBuffer.Length];
			global::System.Array.Copy(this._myCommandBuffer, sendBuffer, this._myCommandBuffer.Length);
			return this._myCommandBuffer.Length;
		}

		// Token: 0x060000CD RID: 205 RVA: 0x000056D4 File Offset: 0x000038D4
		public virtual void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			if (length <= 0 || offset < 0)
			{
				return;
			}
			this._myReplyMessageBuffer = new byte[length];
			global::System.Array.Copy(replyBuffer, offset, this._myReplyMessageBuffer, 0, length);
			ushort uOpCode = 0;
			global::Motorola.Common.Communication.TetraMsgOpResult tetraMsgOpResult = global::Motorola.Common.Communication.SBEPCommon.Get_uOpCode(this._myReplyMessageBuffer, out uOpCode);
			if (tetraMsgOpResult == global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS)
			{
				tetraMsgOpResult = this.ParseReplyMessage(this._myReplyMessageBuffer, uOpCode);
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000CE RID: 206 RVA: 0x00005727 File Offset: 0x00003927
		// (set) Token: 0x060000CF RID: 207 RVA: 0x0000572F File Offset: 0x0000392F
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

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x00005738 File Offset: 0x00003938
		// (set) Token: 0x060000D1 RID: 209 RVA: 0x00005745 File Offset: 0x00003945
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

		// Token: 0x060000D2 RID: 210
		public abstract void ExecuteMessage();

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x00005753 File Offset: 0x00003953
		// (set) Token: 0x060000D4 RID: 212 RVA: 0x0000575B File Offset: 0x0000395B
		public bool AddCheckSum
		{
			get
			{
				return this._bAddCheckSum;
			}
			set
			{
				this._bAddCheckSum = value;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000D5 RID: 213 RVA: 0x00005764 File Offset: 0x00003964
		// (set) Token: 0x060000D6 RID: 214 RVA: 0x0000576C File Offset: 0x0000396C
		public uint OperationFlag
		{
			get
			{
				return this._myOpFlag;
			}
			set
			{
				this._myOpFlag = value;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x00005775 File Offset: 0x00003975
		protected global::Motorola.Common.Communication.SbepMessageExecutor Executor
		{
			get
			{
				return this._myExecutor;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x0000577D File Offset: 0x0000397D
		// (set) Token: 0x060000D9 RID: 217 RVA: 0x00005785 File Offset: 0x00003985
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

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000DA RID: 218 RVA: 0x0000578E File Offset: 0x0000398E
		// (set) Token: 0x060000DB RID: 219 RVA: 0x00005796 File Offset: 0x00003996
		protected byte[] InternalDataToWrite
		{
			get
			{
				return this._myWriteDataBuffer;
			}
			set
			{
				this._myWriteDataBuffer = value;
			}
		}

		// Token: 0x060000DC RID: 220 RVA: 0x0000579F File Offset: 0x0000399F
		protected virtual global::Motorola.Common.Communication.TetraMsgOpResult BaseBuildCommandMessage()
		{
			return global::Motorola.Common.Communication.TetraMsgOpResult.Undefined;
		}

		// Token: 0x060000DD RID: 221 RVA: 0x000057A3 File Offset: 0x000039A3
		protected virtual global::Motorola.Common.Communication.TetraMsgOpResult ParseReplyMessage(byte[] buffer, ushort uOpCode)
		{
			return global::Motorola.Common.Communication.TetraMsgOpResult.Undefined;
		}

		// Token: 0x060000DE RID: 222 RVA: 0x000057A8 File Offset: 0x000039A8
		protected void LogStatusInformation(string moduleName)
		{
			global::Motorola.Common.Communication.SBEPStatus sbepstatus = new global::Motorola.Common.Communication.SBEPStatus();
			sbepstatus.TransportPipe = this.TransportPipe;
			sbepstatus.ExecuteMessage();
			if (sbepstatus.OperationResult == global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS)
			{
				string log = moduleName + string.Format(" got failed result, the current status code of the device is: 0x{0:x2}", sbepstatus.Status);
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo((this.Executor.CommPipe as global::Motorola.Common.Communication.CommunicationPipe.TetraCommPipe).PortName, log);
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000DF RID: 223 RVA: 0x0000580D File Offset: 0x00003A0D
		// (set) Token: 0x060000E0 RID: 224 RVA: 0x00005815 File Offset: 0x00003A15
		protected bool Disposed { get; set; }

		// Token: 0x04000046 RID: 70
		private global::Motorola.Common.Communication.TetraMsgOpResult _myOpResult;

		// Token: 0x04000047 RID: 71
		private uint _myOpFlag;

		// Token: 0x04000048 RID: 72
		private global::Motorola.Common.Communication.SbepMessageExecutor _myExecutor;

		// Token: 0x04000049 RID: 73
		private int _readTimeout;

		// Token: 0x0400004A RID: 74
		private bool _bHasReply;

		// Token: 0x0400004B RID: 75
		private bool _bAddCheckSum;

		// Token: 0x0400004C RID: 76
		private byte[] _myCommandBuffer;

		// Token: 0x0400004D RID: 77
		private byte[] _myWriteDataBuffer;

		// Token: 0x0400004E RID: 78
		protected byte[] _myReplyMessageBuffer;
	}
}
