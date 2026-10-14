using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Security;
using System.Threading;

namespace <CrtImplementationDetails>
{
	// Token: 0x020000C1 RID: 193
	internal class ModuleUninitializer : global::System.Collections.Stack
	{
		// Token: 0x0600026D RID: 621 RVA: 0x0000DAB4 File Offset: 0x0000CEB4
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

		// Token: 0x0600026F RID: 623 RVA: 0x0000E0BC File Offset: 0x0000D4BC
		[global::System.Security.SecuritySafeCritical]
		private ModuleUninitializer()
		{
			global::System.EventHandler value = new global::System.EventHandler(this.SingletonDomainUnload);
			global::System.AppDomain.CurrentDomain.DomainUnload += value;
			global::System.AppDomain.CurrentDomain.ProcessExit += value;
		}

		// Token: 0x06000270 RID: 624 RVA: 0x0000DB14 File Offset: 0x0000CF14
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

		// Token: 0x040000A4 RID: 164
		private static object @lock = new object();

		// Token: 0x040000A5 RID: 165
		internal static global::<CrtImplementationDetails>.ModuleUninitializer _ModuleUninitializer = new global::<CrtImplementationDetails>.ModuleUninitializer();
	}
}
