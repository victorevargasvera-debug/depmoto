using System;
using Motorola.Common.Communication.Pba;

namespace Motorola.Common.Communication.SequenceManager
{
	// Token: 0x02000044 RID: 68
	public class PCRRMRPFileSequenceManager : global::Motorola.Common.Communication.SequenceManager.PCRRPFileSequenceManager
	{
		// Token: 0x06000215 RID: 533 RVA: 0x000124AE File Offset: 0x000106AE
		public PCRRMRPFileSequenceManager(global::Motorola.Common.Communication.SequenceManager.PCRRPRcmpMessageExecutor messageExecutor, int maxDataPayload) : base(messageExecutor, maxDataPayload)
		{
		}

		// Token: 0x06000216 RID: 534 RVA: 0x000124BC File Offset: 0x000106BC
		public override global::Motorola.Common.Communication.Pba.PbaObject WriteDevice(global::Motorola.Common.Communication.Pba.PbaObject writePBA, ushort sessionID, string pcrNewPassword)
		{
			global::Motorola.Common.Communication.Pba.PackedRadioData packedRadioData = null;
			if (base.IsWiredUpgradableFamily(base.ProductFamily.Family))
			{
				if (base.ProgressIndicator != null)
				{
					base.ProgressIndicator.SetCurrentScope(0, 40);
				}
				packedRadioData = base.SyncCodeplug(writePBA);
				if (base.ProgressIndicator != null)
				{
					base.ProgressIndicator.SetCurrentScope(41, 100);
				}
			}
			global::Motorola.Common.Communication.Pba.PbaObject pbaObject = base.WriteDevice(writePBA, sessionID, null);
			if (packedRadioData != null)
			{
				pbaObject.CodeplugData = packedRadioData;
			}
			return pbaObject;
		}
	}
}
