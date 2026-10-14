using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Security;
using System.Threading;

namespace <CrtImplementationDetails>
{
	// Token: 0x0200022F RID: 559
	internal class ModuleUninitializer : global::System.Collections.Stack
	{
		// Token: 0x0600023B RID: 571 RVA: 0x00006F14 File Offset: 0x00006314
		[global::System.Security.SecuritySafeCritical]
		internal void AddHandler(global::System.EventHandler handler)
		{
			bool flag = false;
			global::System.Runtime.CompilerServices.RuntimeHelpers.PrepareConstrainedRegions();
			try
			{
				global::System.Runtime.CompilerServices.RuntimeHelpers.PrepareConstrainedRegions();
				global::System.Threading.Monitor.Enter(global::<CrtImplementationDetails>.ModuleUninitializer.@lock, ref flag);
				global::System.Runtime.CompilerServices.RuntimeHelpers.PrepareDelegate(handler);
				this.Push(handler);
			}
			finally
			{
				if (flag)
				{
					global::System.Threading.Monitor.Exit(global::<CrtImplementationDetails>.ModuleUninitializer.@lock);
				}
			}
		}

		// Token: 0x0600023D RID: 573 RVA: 0x0000751C File Offset: 0x0000691C
		[global::System.Security.SecuritySafeCritical]
		private ModuleUninitializer()
		{
			global::System.EventHandler value = new global::System.EventHandler(this.SingletonDomainUnload);
			global::System.AppDomain.CurrentDomain.DomainUnload += value;
			global::System.AppDomain.CurrentDomain.ProcessExit += value;
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00006F74 File Offset: 0x00006374
		[global::System.Runtime.ConstrainedExecution.PrePrepareMethod]
		[global::System.Security.SecurityCritical]
		private void SingletonDomainUnload(object source, global::System.EventArgs arguments)
		{
			bool flag = false;
			global::System.Runtime.CompilerServices.RuntimeHelpers.PrepareConstrainedRegions();
			try
			{
				global::System.Runtime.CompilerServices.RuntimeHelpers.PrepareConstrainedRegions();
				global::System.Threading.Monitor.Enter(global::<CrtImplementationDetails>.ModuleUninitializer.@lock, ref flag);
				using (global::System.Collections.IEnumerator enumerator = this.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						((global::System.EventHandler)enumerator.Current)(source, arguments);
					}
				}
			}
			finally
			{
				if (flag)
				{
					global::System.Threading.Monitor.Exit(global::<CrtImplementationDetails>.ModuleUninitializer.@lock);
				}
			}
		}

		// Token: 0x040002A5 RID: 677
		private static object @lock = new object();

		// Token: 0x040002A6 RID: 678
		internal static global::<CrtImplementationDetails>.ModuleUninitializer _ModuleUninitializer = new global::<CrtImplementationDetails>.ModuleUninitializer();
	}
}
