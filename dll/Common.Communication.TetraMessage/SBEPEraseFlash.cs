using System;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.TetraUtility;
using Motorola.Common.LogUtility;

namespace Motorola.Common.Communication
{
	// Token: 0x02000023 RID: 35
	public class SBEPEraseFlash : global::Motorola.Common.Communication.SBEPBaseErase
	{
		// Token: 0x06000138 RID: 312 RVA: 0x00006E6A File Offset: 0x0000506A
		public SBEPEraseFlash()
		{
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00006E7D File Offset: 0x0000507D
		public SBEPEraseFlash(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transPipe)
		{
			base.TransportPipe = transPipe;
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x0600013A RID: 314 RVA: 0x00006E97 File Offset: 0x00005097
		public uint AddressInfo
		{
			get
			{
				return base.InternalAddressInfo;
			}
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00006EA0 File Offset: 0x000050A0
		public override void ExecuteMessage()
		{
			global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel("SBEPProtocol.EraseFlash");
			global::Motorola.Common.Communication.CommunicationPipe.TetraCommPipe tetraCommPipe = base.TransportPipe as global::Motorola.Common.Communication.CommunicationPipe.TetraCommPipe;
			int readTimeout = tetraCommPipe.ReadTimeout;
			int writeTimeout = tetraCommPipe.WriteTimeout;
			tetraCommPipe.ReadTimeout = this.ERASE_FLASH_TIMEOUT;
			tetraCommPipe.WriteTimeout = this.ERASE_FLASH_TIMEOUT;
			try
			{
				base.ExecuteMessage();
			}
			catch (global::System.Exception)
			{
				throw;
			}
			finally
			{
				tetraCommPipe.ReadTimeout = readTimeout;
				tetraCommPipe.WriteTimeout = writeTimeout;
			}
			global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.SBEP_PERFORMANCE_LOGGER_NAME).Performance("SBEPProtocol.EraseFlash", "");
		}

		// Token: 0x04000062 RID: 98
		private readonly int ERASE_FLASH_TIMEOUT = 180000;
	}
}
