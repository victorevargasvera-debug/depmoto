using System;

namespace Motorola.Common.Communication.SequenceManager
{
	// Token: 0x02000027 RID: 39
	public class PcrBahamaDeviceUpdateBootDepotSequencer : global::Motorola.Common.Communication.SequenceManager.PcrBahamaDeviceUpdateBootSequencer
	{
		// Token: 0x06000107 RID: 263 RVA: 0x00009C68 File Offset: 0x00007E68
		public PcrBahamaDeviceUpdateBootDepotSequencer(global::Motorola.Common.Communication.IMessageExecutor rcmpWrapper, int maxDataPayload) : base(rcmpWrapper, maxDataPayload)
		{
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00009C75 File Offset: 0x00007E75
		public override void AfterWriteImages()
		{
			base.IOController.RadioUpdateControl(global::Motorola.Common.Communication.UpdateControlAction.OverwriteActivePartition);
		}
	}
}
