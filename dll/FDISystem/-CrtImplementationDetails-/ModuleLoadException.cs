using System;
using System.Runtime.Serialization;

namespace <CrtImplementationDetails>
{
	// Token: 0x020000BF RID: 191
	[global::System.Serializable]
	internal class ModuleLoadException : global::System.Exception
	{
		// Token: 0x06000264 RID: 612 RVA: 0x0000D93C File Offset: 0x0000CD3C
		protected ModuleLoadException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06000265 RID: 613 RVA: 0x0000D924 File Offset: 0x0000CD24
		public ModuleLoadException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x06000266 RID: 614 RVA: 0x0000D910 File Offset: 0x0000CD10
		public ModuleLoadException(string message) : base(message)
		{
		}

		// Token: 0x040000A1 RID: 161
		public const string Nested = "A nested exception occurred after the primary exception that caused the C++ module to fail to load.\n";
	}
}
