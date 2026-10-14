using System;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.TetraUtility;
using Motorola.Common.LogUtility;

namespace Motorola.Common.Communication
{
	// Token: 0x0200001D RID: 29
	public class SBEPCheckSum : global::Motorola.Common.Communication.SBEPBaseCheckSum
	{
		// Token: 0x0600010F RID: 271 RVA: 0x000068FA File Offset: 0x00004AFA
		public SBEPCheckSum(uint startAddress, ushort length)
		{
			this.StartAddress = startAddress;
			this.CalculateLength = (uint)length;
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00006910 File Offset: 0x00004B10
		public SBEPCheckSum(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transPipe, uint startAddress, ushort length)
		{
			this.StartAddress = startAddress;
			this.CalculateLength = (uint)length;
			base.TransportPipe = transPipe;
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000111 RID: 273 RVA: 0x0000692D File Offset: 0x00004B2D
		// (set) Token: 0x06000112 RID: 274 RVA: 0x00006935 File Offset: 0x00004B35
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

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000113 RID: 275 RVA: 0x0000693E File Offset: 0x00004B3E
		public ushort CheckSum
		{
			get
			{
				return base.InternalCheckSum;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000114 RID: 276 RVA: 0x00006946 File Offset: 0x00004B46
		// (set) Token: 0x06000115 RID: 277 RVA: 0x0000694E File Offset: 0x00004B4E
		public uint CalculateLength
		{
			get
			{
				return base.InternalCalculateLength;
			}
			set
			{
				base.InternalCalculateLength = value;
			}
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00006957 File Offset: 0x00004B57
		public override void ExecuteMessage()
		{
			global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel("SBEPProtocol.CheckSum");
			base.ExecuteMessage();
			global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.SBEP_PERFORMANCE_LOGGER_NAME).Performance("SBEPProtocol.CheckSum", "");
		}
	}
}
