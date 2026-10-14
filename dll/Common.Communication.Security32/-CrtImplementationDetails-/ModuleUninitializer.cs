using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Security;
using System.Threading;

namespace <CrtImplementationDetails>
{
	// Token: 0x0200002E RID: 46
	internal class ModuleUninitializer : global::System.Collections.Stack
	{
		// Token: 0x060000E8 RID: 232 RVA: 0x00021E88 File Offset: 0x00021288
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

		// Token: 0x060000EA RID: 234 RVA: 0x00022444 File Offset: 0x00021844
		[global::System.Security.SecuritySafeCritical]
		private ModuleUninitializer()
		{
			global::System.EventHandler value = new global::System.EventHandler(this.SingletonDomainUnload);
			global::System.AppDomain.CurrentDomain.DomainUnload += value;
			global::System.AppDomain.CurrentDomain.ProcessExit += value;
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00021EE8 File Offset: 0x000212E8
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

		// Token: 0x0400008A RID: 138
		private static object @lock = new object();

		// Token: 0x0400008B RID: 139
		internal static global::<CrtImplementationDetails>.ModuleUninitializer _ModuleUninitializer = new global::<CrtImplementationDetails>.ModuleUninitializer();
	}
}
