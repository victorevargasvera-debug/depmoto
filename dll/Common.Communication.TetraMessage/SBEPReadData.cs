using System;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.TetraUtility;
using Motorola.Common.LogUtility;

namespace Motorola.Common.Communication
{
	// Token: 0x02000030 RID: 48
	public class SBEPReadData : global::Motorola.Common.Communication.SBEPBaseRead
	{
		// Token: 0x06000185 RID: 389 RVA: 0x00008213 File Offset: 0x00006413
		public SBEPReadData(uint startAddress, ushort expectedLength)
		{
			base.InternalStartAddress = startAddress;
			base.ExpectedReadLength = expectedLength;
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00008229 File Offset: 0x00006429
		public SBEPReadData()
		{
			base.InternalStartAddress = 0U;
			base.ExpectedReadLength = 0;
		}

		// Token: 0x06000187 RID: 391 RVA: 0x0000823F File Offset: 0x0000643F
		public SBEPReadData(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transPipe, uint startAddress, ushort expectedLength)
		{
			base.InternalStartAddress = startAddress;
			base.ExpectedReadLength = expectedLength;
			base.TransportPipe = transPipe;
		}

		// Token: 0x06000188 RID: 392 RVA: 0x0000825C File Offset: 0x0000645C
		public SBEPReadData(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transPipe)
		{
			base.InternalStartAddress = 0U;
			base.ExpectedReadLength = 0;
			base.TransportPipe = transPipe;
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000189 RID: 393 RVA: 0x00008279 File Offset: 0x00006479
		// (set) Token: 0x0600018A RID: 394 RVA: 0x00008281 File Offset: 0x00006481
		public uint StartAddress
		{
			get
			{
				return base.InternalStartAddress;
			}
			set
			{
				base.InternalStartAddress = value;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x0600018B RID: 395 RVA: 0x0000828A File Offset: 0x0000648A
		public new byte[] ReceivedData
		{
			get
			{
				return base.ReceivedData;
			}
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00008292 File Offset: 0x00006492
		public override void ExecuteMessage()
		{
			global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel("SBEPProtocol.ReadData");
			base.ExecuteMessage();
			global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.SBEP_PERFORMANCE_LOGGER_NAME).Performance("SBEPProtocol.ReadData", "");
		}
	}
}
