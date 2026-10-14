using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Security;
using System.Threading;

namespace <CrtImplementationDetails>
{
	// Token: 0x02000099 RID: 153
	internal class ModuleUninitializer : global::System.Collections.Stack
	{
		// Token: 0x060001A4 RID: 420 RVA: 0x000056DC File Offset: 0x00004ADC
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

		// Token: 0x060001A6 RID: 422 RVA: 0x00005CBC File Offset: 0x000050BC
		[global::System.Security.SecuritySafeCritical]
		private ModuleUninitializer()
		{
			global::System.EventHandler value = new global::System.EventHandler(this.SingletonDomainUnload);
			global::System.AppDomain.CurrentDomain.DomainUnload += value;
			global::System.AppDomain.CurrentDomain.ProcessExit += value;
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x0000573C File Offset: 0x00004B3C
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

		// Token: 0x040000D6 RID: 214
		private static object @lock = new object();

		// Token: 0x040000D7 RID: 215
		internal static global::<CrtImplementationDetails>.ModuleUninitializer _ModuleUninitializer = new global::<CrtImplementationDetails>.ModuleUninitializer();
	}
}
