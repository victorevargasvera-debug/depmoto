using System;
using System.Runtime.InteropServices;

namespace Motorola.Common.Communication.Security
{
	// Token: 0x02000002 RID: 2
	public class SecurityUtil
	{
		// Token: 0x060000A8 RID: 168 RVA: 0x00020A6C File Offset: 0x0001FE6C
		public unsafe static global::System.ValueType PtrToManagedClass<Motorola::Common::Communication::Security::AuthenticationMaterials>(void* ptr)
		{
			global::System.IntPtr ptr2 = new global::System.IntPtr(ptr);
			return (global::Motorola.Common.Communication.Security.AuthenticationMaterials)global::System.Runtime.InteropServices.Marshal.PtrToStructure(ptr2, typeof(global::Motorola.Common.Communication.Security.AuthenticationMaterials));
		}
	}
}
