using System;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.TetraUtility;
using Motorola.Common.LogUtility;

namespace Motorola.Common.Communication
{
	// Token: 0x02000020 RID: 32
	public class SBEPCompressReadData : global::Motorola.Common.Communication.SBEPBaseWrite
	{
		// Token: 0x0600011F RID: 287 RVA: 0x00006B6A File Offset: 0x00004D6A
		public SBEPCompressReadData(bool bCompress)
		{
			this._needCompress = bCompress;
			base.InternalStartAddress = this.COMPRESS_START_ADDRESS;
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00006B8C File Offset: 0x00004D8C
		public SBEPCompressReadData()
		{
			this._needCompress = false;
			base.InternalStartAddress = this.COMPRESS_START_ADDRESS;
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00006BAE File Offset: 0x00004DAE
		public SBEPCompressReadData(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transPipe, bool bCompress)
		{
			this._needCompress = bCompress;
			base.InternalStartAddress = this.COMPRESS_START_ADDRESS;
			base.TransportPipe = transPipe;
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00006BD7 File Offset: 0x00004DD7
		public SBEPCompressReadData(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transPipe)
		{
			this._needCompress = false;
			base.InternalStartAddress = this.COMPRESS_START_ADDRESS;
			base.TransportPipe = transPipe;
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000123 RID: 291 RVA: 0x00006C00 File Offset: 0x00004E00
		// (set) Token: 0x06000124 RID: 292 RVA: 0x00006C08 File Offset: 0x00004E08
		public bool UseCompress
		{
			get
			{
				return this._needCompress;
			}
			set
			{
				this._needCompress = value;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000125 RID: 293 RVA: 0x00006C11 File Offset: 0x00004E11
		public uint StartAddress
		{
			get
			{
				return base.InternalStartAddress;
			}
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00006C1C File Offset: 0x00004E1C
		public override void ExecuteMessage()
		{
			global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel("SBEPProtocol.CompressReadData");
			bool flag = true;
			base.OperationResult = this.BuildWriteMessageBuffer();
			if (base.OperationResult != global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS)
			{
				flag = false;
			}
			if (flag)
			{
				base.InternalDataToWrite = base.MyCommandBuffer;
				base.ExecuteMessage();
			}
			global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.SBEP_PERFORMANCE_LOGGER_NAME).Performance("SBEPProtocol.CompressReadData", "");
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00006C7A File Offset: 0x00004E7A
		protected override global::Motorola.Common.Communication.TetraMsgOpResult BuildWriteMessageBuffer()
		{
			base.MyCommandBuffer = new byte[2];
			base.MyCommandBuffer[0] = 23;
			base.MyCommandBuffer[1] = (this._needCompress ? 2 : 0);
			return global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS;
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00006CA7 File Offset: 0x00004EA7
		protected override global::Motorola.Common.Communication.TetraMsgOpResult BaseBuildCommandMessage()
		{
			this.BuildWriteMessageBuffer();
			base.InternalDataToWrite = base.MyCommandBuffer;
			return base.BaseBuildCommandMessage();
		}

		// Token: 0x0400005E RID: 94
		private bool _needCompress;

		// Token: 0x0400005F RID: 95
		private readonly uint COMPRESS_START_ADDRESS = uint.MaxValue;
	}
}
