using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Pba;

namespace Motorola.Common.Communication
{
	// Token: 0x0200000A RID: 10
	public class AstroManagedOtapFileSeqManager : global::Motorola.Common.Communication.AstroOtapFileSeqManager
	{
		// Token: 0x06000092 RID: 146 RVA: 0x00005B0A File Offset: 0x00003D0A
		public AstroManagedOtapFileSeqManager(global::Motorola.Common.Communication.AstroOtapRcmpMessageExecutor rcmpWrapper, int inactivityTimer, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter) : base(rcmpWrapper, inactivityTimer, sessionParameter)
		{
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00005B15 File Offset: 0x00003D15
		public override global::Motorola.Common.Communication.Pba.PbaObject ReadDevice(global::Motorola.Common.Communication.Pba.PbaObject referencePba, ushort sessionID)
		{
			return base.ManagedReadDevice(referencePba, sessionID);
		}
	}
}
