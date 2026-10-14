using System;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000014 RID: 20
	public interface IObservable
	{
		// Token: 0x06000053 RID: 83
		void Register(global::Motorola.Common.Communication.CommonUtil.IObserver anObserver);

		// Token: 0x06000054 RID: 84
		void UnRegister(global::Motorola.Common.Communication.CommonUtil.IObserver anObserver);
	}
}
