using System;
using System.Threading;

namespace Motorola.Common.Communication
{
	// Token: 0x0200001A RID: 26
	public static class AutoReleasedSemaphore
	{
		// Token: 0x0400009A RID: 154
		public static global::System.Threading.Semaphore addUpgradeJobSem = new global::System.Threading.Semaphore(4, 4);
	}
}
