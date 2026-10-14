using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Pba;

namespace Motorola.Common.Communication
{
	// Token: 0x02000004 RID: 4
	public class AstroManagedFileFlashSequenceManager : global::Motorola.Common.Communication.AstroFileFlashSequenceManager
	{
		// Token: 0x0600003D RID: 61 RVA: 0x00003A9A File Offset: 0x00001C9A
		public AstroManagedFileFlashSequenceManager(global::Motorola.Common.Communication.IMessageExecutor rcmpWrapper, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter) : base(rcmpWrapper, sessionParameter)
		{
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00003AA4 File Offset: 0x00001CA4
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
