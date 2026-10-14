using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Pba;

namespace Motorola.Common.Communication
{
	// Token: 0x02000009 RID: 9
	public interface ICpsSequenceManagerHelper
	{
		// Token: 0x0600003C RID: 60
		global::Motorola.Common.Communication.Pba.PbaObject ReadDevice(global::Motorola.Common.Communication.Pba.PbaObject referencePba, ushort sessionID);

		// Token: 0x0600003D RID: 61
		global::Motorola.Common.Communication.Pba.PbaObject WriteDevice(global::Motorola.Common.Communication.Pba.PbaObject pbaObject, ushort sessionID);

		// Token: 0x0600003E RID: 62
		void OpenSession(ushort sessionID, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation);

		// Token: 0x0600003F RID: 63
		void CloseSession(ushort sessionID, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation, bool pendingDeploy);
	}
}
