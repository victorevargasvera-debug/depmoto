using System;
using System.Runtime.Serialization;

namespace <CrtImplementationDetails>
{
	// Token: 0x02000065 RID: 101
	[global::System.Serializable]
	internal class ModuleLoadException : global::System.Exception
	{
		// Token: 0x06000135 RID: 309 RVA: 0x00005FBC File Offset: 0x000053BC
		protected ModuleLoadException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00005FA4 File Offset: 0x000053A4
		public ModuleLoadException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00005F90 File Offset: 0x00005390
		public ModuleLoadException(string message) : base(message)
		{
		}

		// Token: 0x040000BB RID: 187
		public const string Nested = "A nested exception occurred after the primary exception that caused the C++ module to fail to load.\n";
	}
}
