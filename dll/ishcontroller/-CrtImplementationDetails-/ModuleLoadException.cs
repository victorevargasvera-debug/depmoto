using System;
using System.Runtime.Serialization;

namespace <CrtImplementationDetails>
{
	// Token: 0x02000097 RID: 151
	[global::System.Serializable]
	internal class ModuleLoadException : global::System.Exception
	{
		// Token: 0x0600019B RID: 411 RVA: 0x00005564 File Offset: 0x00004964
		protected ModuleLoadException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600019C RID: 412 RVA: 0x0000554C File Offset: 0x0000494C
		public ModuleLoadException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00005538 File Offset: 0x00004938
		public ModuleLoadException(string message) : base(message)
		{
		}

		// Token: 0x040000D3 RID: 211
		public const string Nested = "A nested exception occurred after the primary exception that caused the C++ module to fail to load.\n";
	}
}
