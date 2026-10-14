using System;

namespace OpenSSL.Core
{
	// Token: 0x0200003D RID: 61
	public class ThreadInitialization
	{
		// Token: 0x06000146 RID: 326 RVA: 0x000054E2 File Offset: 0x000036E2
		public static void InitializeThreads()
		{
			global::OpenSSL.Core.Native.InitializeThreads();
		}

		// Token: 0x06000147 RID: 327 RVA: 0x000054E9 File Offset: 0x000036E9
		public static void UninitializeThreads()
		{
			global::OpenSSL.Core.Native.UninitializeThreads();
		}
	}
}
