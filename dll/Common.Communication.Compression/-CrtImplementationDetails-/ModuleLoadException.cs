using System;
using System.Runtime.Serialization;

namespace <CrtImplementationDetails>
{
	// Token: 0x02000012 RID: 18
	[global::System.Serializable]
	internal class ModuleLoadException : global::System.Exception
	{
		// Token: 0x06000070 RID: 112 RVA: 0x0000CA04 File Offset: 0x0000BE04
		protected ModuleLoadException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06000071 RID: 113 RVA: 0x0000C9EC File Offset: 0x0000BDEC
		public ModuleLoadException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x06000072 RID: 114 RVA: 0x0000C9D8 File Offset: 0x0000BDD8
		public ModuleLoadException(string message) : base(message)
		{
		}

		// Token: 0x04000041 RID: 65
		public const string Nested = "A nested exception occurred after the primary exception that caused the C++ module to fail to load.\n";
	}
}
