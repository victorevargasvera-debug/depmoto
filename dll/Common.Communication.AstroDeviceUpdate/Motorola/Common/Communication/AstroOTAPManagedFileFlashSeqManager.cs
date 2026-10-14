using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Pba;

namespace Motorola.Common.Communication
{
	// Token: 0x02000006 RID: 6
	public class AstroOTAPManagedFileFlashSeqManager : global::Motorola.Common.Communication.AstroOTAPFileFlashSeqManager
	{
		// Token: 0x06000045 RID: 69 RVA: 0x00003CE9 File Offset: 0x00001EE9
		public AstroOTAPManagedFileFlashSeqManager(global::Motorola.Common.Communication.AstroOtapRcmpMessageExecutor rcmpWrapper, int inactivityTimer, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter) : base(rcmpWrapper, inactivityTimer, sessionParameter)
		{
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00003CF4 File Offset: 0x00001EF4
		public override global::Motorola.Common.Communication.Pba.PbaObject WriteDevice(global::Motorola.Common.Communication.Pba.PbaObject writePBA, ushort sessionID, string pcrNewPassword)
		{
			if (base.ProgressIndicator != null)
			{
				base.ProgressIndicator.SetCurrentScope(0, 7);
			}
			base.UpdatePINPasswordBeforeWrite(writePBA);
			base.UpdateWiFiPasswordBeforeWrite(writePBA);
			base.UpdateExternalDataModemPasswordBeforeWrite(writePBA);
			base.WriteDevice(writePBA, sessionID, null);
			return writePBA;
		}
	}
}
