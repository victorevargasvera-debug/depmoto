using System;

namespace Motorola.Common.Communication.SequenceManager
{
	// Token: 0x02000029 RID: 41
	public class PcrDeviceUpdateFileDepotSequencer : global::Motorola.Common.Communication.SequenceManager.PcrDeviceUpdateFileSequencer
	{
		// Token: 0x06000115 RID: 277 RVA: 0x0000AD0E File Offset: 0x00008F0E
		public PcrDeviceUpdateFileDepotSequencer(global::Motorola.Common.Communication.IMessageExecutor rcmpWrapper, int maxDataPayload) : base(rcmpWrapper, maxDataPayload)
		{
		}

		// Token: 0x06000116 RID: 278 RVA: 0x0000AD1B File Offset: 0x00008F1B
		protected override void AfterWriteImages()
		{
			base.IOController.RadioUpdateControl(global::Motorola.Common.Communication.UpdateControlAction.OverwriteActivePartition);
		}
	}
}
