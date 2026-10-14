using System;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000015 RID: 21
	public class SingletonBase<T> where T : class, new()
	{
		// Token: 0x06000055 RID: 85 RVA: 0x000035BC File Offset: 0x000017BC
		public static T Instance()
		{
			lock (global::Motorola.Common.Communication.CommonUtil.SingletonBase<T>.locker)
			{
				if (global::Motorola.Common.Communication.CommonUtil.SingletonBase<T>._singleton == null)
				{
					global::Motorola.Common.Communication.CommonUtil.SingletonBase<T>._singleton = global::System.Activator.CreateInstance<T>();
				}
			}
			return global::Motorola.Common.Communication.CommonUtil.SingletonBase<T>._singleton;
		}

		// Token: 0x04000046 RID: 70
		private static object locker = new object();

		// Token: 0x04000047 RID: 71
		private static T _singleton;
	}
}
