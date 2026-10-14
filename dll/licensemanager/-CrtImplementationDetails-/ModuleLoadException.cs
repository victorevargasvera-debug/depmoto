using System;
using System.Runtime.Serialization;

namespace <CrtImplementationDetails>
{
	// Token: 0x0200022D RID: 557
	[global::System.Serializable]
	internal class ModuleLoadException : global::System.Exception
	{
		// Token: 0x06000232 RID: 562 RVA: 0x00006D9C File Offset: 0x0000619C
		protected ModuleLoadException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06000233 RID: 563 RVA: 0x00006D84 File Offset: 0x00006184
		public ModuleLoadException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x06000234 RID: 564 RVA: 0x00006D70 File Offset: 0x00006170
		public ModuleLoadException(string message) : base(message)
		{
		}

		// Token: 0x040002A2 RID: 674
		public const string Nested = "A nested exception occurred after the primary exception that caused the C++ module to fail to load.\n";
	}
}
