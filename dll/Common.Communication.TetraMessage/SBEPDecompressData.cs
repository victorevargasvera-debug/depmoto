using System;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.TetraUtility;
using Motorola.Common.LogUtility;

namespace Motorola.Common.Communication
{
	// Token: 0x02000022 RID: 34
	public class SBEPDecompressData : global::Motorola.Common.Communication.SBEPBaseWrite
	{
		// Token: 0x0600012E RID: 302 RVA: 0x00006D14 File Offset: 0x00004F14
		public SBEPDecompressData(bool bDecompress)
		{
			this._needDecompress = bDecompress;
			base.InternalStartAddress = this.DECOMPRESS_START_ADDRESS;
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00006D36 File Offset: 0x00004F36
		public SBEPDecompressData(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transPipe, bool bDecompress)
		{
			this._needDecompress = bDecompress;
			base.InternalStartAddress = this.DECOMPRESS_START_ADDRESS;
			base.TransportPipe = transPipe;
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00006D5F File Offset: 0x00004F5F
		public SBEPDecompressData()
		{
			this._needDecompress = false;
			base.InternalStartAddress = this.DECOMPRESS_START_ADDRESS;
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00006D81 File Offset: 0x00004F81
		public SBEPDecompressData(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transPipe)
		{
			this._needDecompress = false;
			base.InternalStartAddress = this.DECOMPRESS_START_ADDRESS;
			base.TransportPipe = transPipe;
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000132 RID: 306 RVA: 0x00006DAA File Offset: 0x00004FAA
		// (set) Token: 0x06000133 RID: 307 RVA: 0x00006DB2 File Offset: 0x00004FB2
		public bool Decompress
		{
			get
			{
				return this._needDecompress;
			}
			set
			{
				this._needDecompress = value;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000134 RID: 308 RVA: 0x00006DBB File Offset: 0x00004FBB
		public uint StartAddress
		{
			get
			{
				return base.InternalStartAddress;
			}
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00006DC4 File Offset: 0x00004FC4
		public override void ExecuteMessage()
		{
			global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel("SBEPProtocol.DecompressData");
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
			global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.SBEP_PERFORMANCE_LOGGER_NAME).Performance("SBEPProtocol.DecompressData", "");
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00006E22 File Offset: 0x00005022
		protected override global::Motorola.Common.Communication.TetraMsgOpResult BuildWriteMessageBuffer()
		{
			base.MyCommandBuffer = new byte[2];
			base.MyCommandBuffer[0] = 16;
			base.MyCommandBuffer[1] = (this._needDecompress ? 2 : 0);
			return global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS;
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00006E4F File Offset: 0x0000504F
		protected override global::Motorola.Common.Communication.TetraMsgOpResult BaseBuildCommandMessage()
		{
			this.BuildWriteMessageBuffer();
			base.InternalDataToWrite = base.MyCommandBuffer;
			return base.BaseBuildCommandMessage();
		}

		// Token: 0x04000060 RID: 96
		private bool _needDecompress;

		// Token: 0x04000061 RID: 97
		private readonly uint DECOMPRESS_START_ADDRESS = uint.MaxValue;
	}
}
