using System;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.TetraUtility;
using Motorola.Common.LogUtility;

namespace Motorola.Common.Communication
{
	// Token: 0x02000039 RID: 57
	public class SBEPSetEraseRange : global::Motorola.Common.Communication.SBEPBaseWrite
	{
		// Token: 0x060001B5 RID: 437 RVA: 0x000088EE File Offset: 0x00006AEE
		public SBEPSetEraseRange(uint beginAddress, uint endAddress)
		{
			this._myBeginAddress = beginAddress;
			this._myEndAddress = endAddress;
			base.InternalStartAddress = this.START_ADDRESS;
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00008917 File Offset: 0x00006B17
		public SBEPSetEraseRange(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transPipe, uint beginAddress, uint endAddress)
		{
			this._myBeginAddress = beginAddress;
			this._myEndAddress = endAddress;
			base.InternalStartAddress = this.START_ADDRESS;
			base.TransportPipe = transPipe;
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00008947 File Offset: 0x00006B47
		public SBEPSetEraseRange()
		{
			this._myBeginAddress = 0U;
			this._myEndAddress = 0U;
			base.InternalStartAddress = this.START_ADDRESS;
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00008970 File Offset: 0x00006B70
		public SBEPSetEraseRange(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transPipe)
		{
			this._myBeginAddress = 0U;
			this._myEndAddress = 0U;
			base.InternalStartAddress = this.START_ADDRESS;
			base.TransportPipe = transPipe;
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060001B9 RID: 441 RVA: 0x000089A0 File Offset: 0x00006BA0
		// (set) Token: 0x060001BA RID: 442 RVA: 0x000089A8 File Offset: 0x00006BA8
		public uint BeginAddress
		{
			get
			{
				return this._myBeginAddress;
			}
			set
			{
				this._myBeginAddress = value;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060001BB RID: 443 RVA: 0x000089B1 File Offset: 0x00006BB1
		// (set) Token: 0x060001BC RID: 444 RVA: 0x000089B9 File Offset: 0x00006BB9
		public uint EndAddress
		{
			get
			{
				return this._myEndAddress;
			}
			set
			{
				this._myEndAddress = value;
			}
		}

		// Token: 0x060001BD RID: 445 RVA: 0x000089C4 File Offset: 0x00006BC4
		public override void ExecuteMessage()
		{
			global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel("SBEPProtocol.SetEraseRange");
			base.OperationResult = this.BuildWriteMessageBuffer();
			if (base.OperationResult == global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS)
			{
				base.InternalDataToWrite = base.MyCommandBuffer;
				base.ExecuteMessage();
			}
			global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.SBEP_PERFORMANCE_LOGGER_NAME).Performance("SBEPProtocol.SetEraseRange", "");
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00008A1C File Offset: 0x00006C1C
		protected override global::Motorola.Common.Communication.TetraMsgOpResult BuildWriteMessageBuffer()
		{
			bool flag = true;
			if (this._myEndAddress > this._myBeginAddress)
			{
				this._myEndAddress -= 1U;
			}
			byte[] array = new byte[8];
			array[0] = 8;
			byte[] bytes = global::System.BitConverter.GetBytes(this._myBeginAddress);
			global::Motorola.Common.Communication.TetraMsgOpResult tetraMsgOpResult = global::Motorola.Common.Communication.SBEPCommon.ReverseBytesAndCopy(array, 1, bytes, 0, 4);
			if (tetraMsgOpResult != global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS)
			{
				flag = false;
			}
			if (flag)
			{
				bytes = global::System.BitConverter.GetBytes(this._myEndAddress);
				tetraMsgOpResult = global::Motorola.Common.Communication.SBEPCommon.ReverseBytesAndCopy(array, 4, bytes, 0, 4);
				if (tetraMsgOpResult != global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS)
				{
					flag = false;
				}
			}
			if (flag)
			{
				base.MyCommandBuffer = new byte[7];
				global::System.Array.Copy(array, base.MyCommandBuffer, 7);
			}
			base.OperationResult = tetraMsgOpResult;
			return tetraMsgOpResult;
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00008AB6 File Offset: 0x00006CB6
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

		// Token: 0x040000A8 RID: 168
		private uint _myBeginAddress;

		// Token: 0x040000A9 RID: 169
		private uint _myEndAddress;

		// Token: 0x040000AA RID: 170
		private readonly uint START_ADDRESS = uint.MaxValue;
	}
}
