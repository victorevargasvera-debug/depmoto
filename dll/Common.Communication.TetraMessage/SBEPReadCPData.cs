using System;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.TetraUtility;
using Motorola.Common.LogUtility;

namespace Motorola.Common.Communication
{
	// Token: 0x0200002F RID: 47
	public class SBEPReadCPData : global::Motorola.Common.Communication.SBEPBaseRead
	{
		// Token: 0x0600017B RID: 379 RVA: 0x00008132 File Offset: 0x00006332
		public SBEPReadCPData(ushort size)
		{
			base.InternalStartAddress = this.READ_CP_DATA_ADDRESS;
			base.ExpectedReadLength = size;
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00008158 File Offset: 0x00006358
		public SBEPReadCPData()
		{
			base.InternalStartAddress = this.READ_CP_DATA_ADDRESS;
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00008177 File Offset: 0x00006377
		public SBEPReadCPData(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transPipe, ushort size)
		{
			base.InternalStartAddress = this.READ_CP_DATA_ADDRESS;
			base.ExpectedReadLength = size;
			base.TransportPipe = transPipe;
		}

		// Token: 0x0600017E RID: 382 RVA: 0x000081A4 File Offset: 0x000063A4
		public SBEPReadCPData(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transPipe)
		{
			base.TransportPipe = transPipe;
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x0600017F RID: 383 RVA: 0x000081BE File Offset: 0x000063BE
		// (set) Token: 0x06000180 RID: 384 RVA: 0x000081C6 File Offset: 0x000063C6
		public ushort Size
		{
			get
			{
				return base.ExpectedReadLength;
			}
			set
			{
				base.ExpectedReadLength = value;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000181 RID: 385 RVA: 0x000081CF File Offset: 0x000063CF
		public byte[] Data
		{
			get
			{
				return base.ReceivedData;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000182 RID: 386 RVA: 0x000081D7 File Offset: 0x000063D7
		// (set) Token: 0x06000183 RID: 387 RVA: 0x000081DF File Offset: 0x000063DF
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

		// Token: 0x06000184 RID: 388 RVA: 0x000081E8 File Offset: 0x000063E8
		public override void ExecuteMessage()
		{
			global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel("SBEPProtocol.ReadData");
			base.ExecuteMessage();
			global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.SBEP_PERFORMANCE_LOGGER_NAME).Performance("SBEPProtocol.ReadData", "");
		}

		// Token: 0x04000084 RID: 132
		private readonly uint READ_CP_DATA_ADDRESS = 4294967069U;
	}
}
