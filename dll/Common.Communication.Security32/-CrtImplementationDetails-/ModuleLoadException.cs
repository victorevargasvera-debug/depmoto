using System;
using System.Runtime.Serialization;

namespace <CrtImplementationDetails>
{
	// Token: 0x0200002C RID: 44
	[global::System.Serializable]
	internal class ModuleLoadException : global::System.Exception
	{
		// Token: 0x060000DF RID: 223 RVA: 0x00021D10 File Offset: 0x00021110
		protected ModuleLoadException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00021CF8 File Offset: 0x000210F8
		public ModuleLoadException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00021CE4 File Offset: 0x000210E4
		public ModuleLoadException(string message) : base(message)
		{
		}

		// Token: 0x04000087 RID: 135
		public const string Nested = "A nested exception occurred after the primary exception that caused the C++ module to fail to load.\n";
	}
}
