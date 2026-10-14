using System;
using Motorola.Common.Communication.CommonUtil;

namespace Motorola.Common.Communication.RUDP
{
	// Token: 0x0200000F RID: 15
	internal class SequenceNumberGenerator : global::Motorola.Common.Communication.CommonUtil.SingletonBase<global::Motorola.Common.Communication.RUDP.SequenceNumberGenerator>
	{
		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x000056E0 File Offset: 0x000038E0
		public ushort INIT_SENT
		{
			get
			{
				return (ushort)(this._randomGenerator.Next() % 65535);
			}
		}

		// Token: 0x04000068 RID: 104
		private const ushort SEQ_NUM_MIN = 0;

		// Token: 0x04000069 RID: 105
		private const ushort SEQ_NUM_MAX = 65535;

		// Token: 0x0400006A RID: 106
		private global::System.Random _randomGenerator = new global::System.Random();
	}
}
