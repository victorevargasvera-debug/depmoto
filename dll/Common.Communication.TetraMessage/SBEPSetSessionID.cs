using System;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.TetraUtility;
using Motorola.Common.LogUtility;

namespace Motorola.Common.Communication
{
	// Token: 0x0200003E RID: 62
	public class SBEPSetSessionID : global::Motorola.Common.Communication.SBEPBaseWrite
	{
		// Token: 0x060001DD RID: 477 RVA: 0x00008F86 File Offset: 0x00007186
		public SBEPSetSessionID()
		{
			base.InternalStartAddress = this.SESSION_ID_START_ADDRESS;
			this._mySessionID = 0U;
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00008FB0 File Offset: 0x000071B0
		public SBEPSetSessionID(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transPipe)
		{
			base.InternalStartAddress = this.SESSION_ID_START_ADDRESS;
			this._mySessionID = 0U;
			base.TransportPipe = transPipe;
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00008FE1 File Offset: 0x000071E1
		public SBEPSetSessionID(uint sessionID)
		{
			base.InternalStartAddress = this.SESSION_ID_START_ADDRESS;
			this._mySessionID = sessionID;
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x0000900B File Offset: 0x0000720B
		public SBEPSetSessionID(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transPipe, uint sessionID)
		{
			base.InternalStartAddress = this.SESSION_ID_START_ADDRESS;
			this._mySessionID = sessionID;
			base.TransportPipe = transPipe;
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060001E1 RID: 481 RVA: 0x0000903C File Offset: 0x0000723C
		// (set) Token: 0x060001E2 RID: 482 RVA: 0x00009044 File Offset: 0x00007244
		public uint SessionID
		{
			get
			{
				return this._mySessionID;
			}
			set
			{
				this._mySessionID = value;
			}
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x00009050 File Offset: 0x00007250
		public override void ExecuteMessage()
		{
			global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel("SBEPProtocol.SetSessionID");
			bool flag = true;
			global::Motorola.Common.Communication.TetraMsgOpResult tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.Undefined;
			base.OperationResult = this.BuildWriteMessageBuffer();
			if (tetraMsgOpResult != global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS)
			{
				flag = false;
			}
			if (flag)
			{
				base.InternalDataToWrite = base.MyCommandBuffer;
				base.ExecuteMessage();
			}
			global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.SBEP_PERFORMANCE_LOGGER_NAME).Performance("SBEPProtocol.SetSessionID", "");
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x000090AC File Offset: 0x000072AC
		protected override global::Motorola.Common.Communication.TetraMsgOpResult BuildWriteMessageBuffer()
		{
			bool flag = true;
			base.MyCommandBuffer = new byte[this.MESSAGE_LENGTH];
			base.MyCommandBuffer[0] = 26;
			byte[] bytes = global::System.BitConverter.GetBytes(this._mySessionID);
			global::Motorola.Common.Communication.TetraMsgOpResult tetraMsgOpResult = global::Motorola.Common.Communication.SBEPCommon.ReverseBytesAndCopy(base.MyCommandBuffer, 1, bytes, 0, 4);
			if (tetraMsgOpResult != global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS)
			{
				flag = false;
			}
			if (flag)
			{
				for (int i = 5; i < base.MyCommandBuffer.Length; i++)
				{
					base.MyCommandBuffer[i] = 0;
				}
			}
			return tetraMsgOpResult;
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x0000911C File Offset: 0x0000731C
		protected override global::Motorola.Common.Communication.TetraMsgOpResult BaseBuildCommandMessage()
		{
			base.OperationResult = this.BuildWriteMessageBuffer();
			if (base.OperationResult == global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS)
			{
				base.InternalDataToWrite = base.MyCommandBuffer;
				return base.BaseBuildCommandMessage();
			}
			return base.OperationResult;
		}

		// Token: 0x040000B7 RID: 183
		private uint _mySessionID;

		// Token: 0x040000B8 RID: 184
		private readonly uint MESSAGE_LENGTH = 9U;

		// Token: 0x040000B9 RID: 185
		private readonly uint SESSION_ID_START_ADDRESS = uint.MaxValue;
	}
}
