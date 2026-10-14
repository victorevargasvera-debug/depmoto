using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Pba;

namespace Motorola.Common.Communication
{
	// Token: 0x02000008 RID: 8
	public class AstroManagedFileSeqManager : global::Motorola.Common.Communication.AstroFileSeqManager, global::Motorola.Common.Communication.IDepotSequenceManager
	{
		// Token: 0x0600008A RID: 138 RVA: 0x000058DC File Offset: 0x00003ADC
		public AstroManagedFileSeqManager(global::Motorola.Common.Communication.IMessageExecutor rcmpWrapper, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter) : base(rcmpWrapper, sessionParameter)
		{
		}

		// Token: 0x0600008B RID: 139 RVA: 0x000058E6 File Offset: 0x00003AE6
		public override global::Motorola.Common.Communication.Pba.PbaObject ReadDevice(global::Motorola.Common.Communication.Pba.PbaObject referencePba, ushort sessionID)
		{
			return base.ManagedReadDevice(referencePba, sessionID);
		}
	}
}
