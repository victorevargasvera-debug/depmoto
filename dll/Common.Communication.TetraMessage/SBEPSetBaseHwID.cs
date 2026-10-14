using System;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.TetraUtility;
using Motorola.Common.LogUtility;

namespace Motorola.Common.Communication
{
	// Token: 0x02000037 RID: 55
	public class SBEPSetBaseHwID : global::Motorola.Common.Communication.SBEPBaseWrite
	{
		// Token: 0x060001A7 RID: 423 RVA: 0x00008689 File Offset: 0x00006889
		public SBEPSetBaseHwID(ushort baseHwID)
		{
			this._myBaseHwID = baseHwID;
			base.InternalStartAddress = this.BASE_HW_ID_ADDRESS;
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x000086AB File Offset: 0x000068AB
		public SBEPSetBaseHwID(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transPipe, ushort baseHwID)
		{
			this._myBaseHwID = baseHwID;
			base.InternalStartAddress = this.BASE_HW_ID_ADDRESS;
			base.TransportPipe = transPipe;
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x000086D4 File Offset: 0x000068D4
		public SBEPSetBaseHwID()
		{
			this._myBaseHwID = 0;
			base.InternalStartAddress = this.BASE_HW_ID_ADDRESS;
		}

		// Token: 0x060001AA RID: 426 RVA: 0x000086F6 File Offset: 0x000068F6
		public SBEPSetBaseHwID(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transPipe)
		{
			this._myBaseHwID = 0;
			base.InternalStartAddress = this.BASE_HW_ID_ADDRESS;
			base.TransportPipe = transPipe;
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060001AB RID: 427 RVA: 0x0000871F File Offset: 0x0000691F
		// (set) Token: 0x060001AC RID: 428 RVA: 0x00008727 File Offset: 0x00006927
		public ushort BaseHwID
		{
			get
			{
				return this._myBaseHwID;
			}
			set
			{
				this._myBaseHwID = value;
			}
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00008730 File Offset: 0x00006930
		public override void ExecuteMessage()
		{
			global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel("SBEPProtocol.BaseHwID");
			base.OperationResult = this.BuildWriteMessageBuffer();
			if (base.OperationResult == global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS)
			{
				base.InternalDataToWrite = base.MyCommandBuffer;
				base.ExecuteMessage();
			}
			global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.SBEP_PERFORMANCE_LOGGER_NAME).Performance("SBEPProtocol.BaseHwID", "");
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00008788 File Offset: 0x00006988
		protected override global::Motorola.Common.Communication.TetraMsgOpResult BuildWriteMessageBuffer()
		{
			base.MyCommandBuffer = new byte[3];
			base.MyCommandBuffer[0] = 19;
			byte[] bytes = global::System.BitConverter.GetBytes(this._myBaseHwID);
			return global::Motorola.Common.Communication.SBEPCommon.ReverseBytesAndCopy(base.MyCommandBuffer, 1, bytes, 0, 2);
		}

		// Token: 0x060001AF RID: 431 RVA: 0x000087CB File Offset: 0x000069CB
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

		// Token: 0x040000A4 RID: 164
		private ushort _myBaseHwID;

		// Token: 0x040000A5 RID: 165
		private readonly uint BASE_HW_ID_ADDRESS = uint.MaxValue;
	}
}
