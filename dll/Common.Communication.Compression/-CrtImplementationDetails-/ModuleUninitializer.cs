using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Security;
using System.Threading;

namespace <CrtImplementationDetails>
{
	// Token: 0x02000014 RID: 20
	internal class ModuleUninitializer : global::System.Collections.Stack
	{
		// Token: 0x06000079 RID: 121 RVA: 0x0000CB7C File Offset: 0x0000BF7C
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

		// Token: 0x0600007B RID: 123 RVA: 0x0000D184 File Offset: 0x0000C584
		[global::System.Security.SecuritySafeCritical]
		private ModuleUninitializer()
		{
			global::System.EventHandler value = new global::System.EventHandler(this.SingletonDomainUnload);
			global::System.AppDomain.CurrentDomain.DomainUnload += value;
			global::System.AppDomain.CurrentDomain.ProcessExit += value;
		}

		// Token: 0x0600007C RID: 124 RVA: 0x0000CBDC File Offset: 0x0000BFDC
		[global::System.Security.SecurityCritical]
		[global::System.Runtime.ConstrainedExecution.PrePrepareMethod]
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

		// Token: 0x04000044 RID: 68
		private static object @lock = new object();

		// Token: 0x04000045 RID: 69
		internal static global::<CrtImplementationDetails>.ModuleUninitializer _ModuleUninitializer = new global::<CrtImplementationDetails>.ModuleUninitializer();
	}
}
