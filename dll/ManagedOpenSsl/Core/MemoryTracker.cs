using System;

namespace OpenSSL.Core
{
	// Token: 0x02000013 RID: 19
	public class MemoryTracker
	{
		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000081 RID: 129 RVA: 0x0000311E File Offset: 0x0000131E
		public static int Leaked
		{
			get
			{
				return global::OpenSSL.Core.MemoryTracker.leaked;
			}
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00003125 File Offset: 0x00001325
		public static void Start()
		{
			global::OpenSSL.Core.MemoryTracker.leaked = 0;
			global::OpenSSL.Core.CryptoUtil.MallocDebugInit();
			global::OpenSSL.Core.CryptoUtil.SetDebugOptions(global::OpenSSL.Core.DebugOptions.All);
			global::OpenSSL.Core.CryptoUtil.SetMemoryCheck(global::OpenSSL.Core.MemoryCheck.On);
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00003140 File Offset: 0x00001340
		public static void Finish()
		{
			global::System.GC.Collect();
			global::System.GC.WaitForPendingFinalizers();
			global::System.GC.Collect();
			global::OpenSSL.Core.CryptoUtil.Cleanup();
			global::OpenSSL.Core.CryptoUtil.RemoveState(0U);
			global::OpenSSL.Core.CryptoUtil.SetMemoryCheck(global::OpenSSL.Core.MemoryCheck.Off);
			global::OpenSSL.Core.CryptoUtil.CheckMemoryLeaks(new global::OpenSSL.Core.CryptoUtil.MemoryLeakHandler(global::OpenSSL.Core.MemoryTracker.OnMemoryLeak));
			if (global::OpenSSL.Core.MemoryTracker.leaked > 0)
			{
				global::System.Console.WriteLine("Leaked total bytes: {0}", global::OpenSSL.Core.MemoryTracker.leaked);
			}
		}

		// Token: 0x06000084 RID: 132 RVA: 0x0000319C File Offset: 0x0000139C
		private static void OnMemoryLeak(uint order, global::System.IntPtr file, int line, int num_bytes, global::System.IntPtr addr)
		{
			string text;
			if (file != global::System.IntPtr.Zero)
			{
				text = global::OpenSSL.Core.Native.PtrToStringAnsi(file, false);
			}
			else
			{
				text = "<null>";
			}
			global::System.Console.WriteLine("[{0}] file: {1} line: {2} bytes: {3}", new object[]
			{
				order,
				text,
				line,
				num_bytes
			});
			global::OpenSSL.Core.MemoryTracker.leaked += num_bytes;
		}

		// Token: 0x04000022 RID: 34
		private static int leaked;
	}
}
