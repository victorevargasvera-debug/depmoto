using System;
using System.Runtime.Serialization;

namespace <CrtImplementationDetails>
{
	// Token: 0x020000D8 RID: 216
	[global::System.Serializable]
	internal class ModuleLoadException : global::System.Exception
	{
		// Token: 0x06000060 RID: 96 RVA: 0x00001A74 File Offset: 0x00000E74
		protected ModuleLoadException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00001A5C File Offset: 0x00000E5C
		public ModuleLoadException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00001A48 File Offset: 0x00000E48
		public ModuleLoadException(string message) : base(message)
		{
		}

		// Token: 0x040000F7 RID: 247
		public const string Nested = "A nested exception occurred after the primary exception that caused the C++ module to fail to load.\n";
	}
}
