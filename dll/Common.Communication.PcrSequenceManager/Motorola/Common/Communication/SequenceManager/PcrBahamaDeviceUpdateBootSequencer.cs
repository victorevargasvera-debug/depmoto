using System;

namespace Motorola.Common.Communication.SequenceManager
{
	// Token: 0x02000026 RID: 38
	public class PcrBahamaDeviceUpdateBootSequencer : global::Motorola.Common.Communication.SequenceManager.PcrFileSystemDeviceUpdateBootSequencer, global::Motorola.Common.Communication.IFlashSequenceManager
	{
		// Token: 0x06000104 RID: 260 RVA: 0x00009C39 File Offset: 0x00007E39
		public PcrBahamaDeviceUpdateBootSequencer(global::Motorola.Common.Communication.IMessageExecutor rcmpWrapper, int maxDataPayload) : base(rcmpWrapper, maxDataPayload)
		{
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00009C46 File Offset: 0x00007E46
		public override void PreWriteImages()
		{
			base.IOController.RadioUpdateControl(global::Motorola.Common.Communication.UpdateControlAction.UpdateStatus);
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00009C57 File Offset: 0x00007E57
		public override void AfterWriteImages()
		{
			base.IOController.RadioUpdateControl(global::Motorola.Common.Communication.UpdateControlAction.CommitUpdate);
		}
	}
}
