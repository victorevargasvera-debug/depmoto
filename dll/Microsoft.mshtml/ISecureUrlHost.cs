using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x02000CBB RID: 3259
	[global::System.Runtime.InteropServices.Guid("C81984C4-74C8-11D2-BAA9-00C04FC2040E")]
	[global::System.Runtime.InteropServices.InterfaceType(1)]
	[global::System.Runtime.InteropServices.ComImport]
	public interface ISecureUrlHost
	{
		// Token: 0x060162B5 RID: 90805
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void ValidateSecureUrl(out int pfAllow, [global::System.Runtime.InteropServices.In] ref ushort pchUrlInQuestion, [global::System.Runtime.InteropServices.In] uint dwFlags);
	}
}
