using System;
using System.Runtime.InteropServices;

namespace LdapAuthenticationInterfaceController
{
	// Token: 0x02000007 RID: 7
	internal class a
	{
		// Token: 0x06000015 RID: 21
		[global::System.Runtime.InteropServices.DllImport("ldapauthenticationinterfaceadapter.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "OpenRL")]
		public static extern uint a(out uint A_0);

		// Token: 0x06000016 RID: 22
		[global::System.Runtime.InteropServices.DllImport("ldapauthenticationinterfaceadapter.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "CloseRL")]
		public static extern uint a(uint A_0);

		// Token: 0x06000017 RID: 23
		[global::System.Runtime.InteropServices.DllImport("ldapauthenticationinterfaceadapter.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern uint VerifyUserLogin(uint A_0, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] string A_1, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] string A_2);

		// Token: 0x06000018 RID: 24
		[global::System.Runtime.InteropServices.DllImport("ldapauthenticationinterfaceadapter.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern uint IsUserConnected(uint A_0);

		// Token: 0x06000019 RID: 25
		[global::System.Runtime.InteropServices.DllImport("ldapauthenticationinterfaceadapter.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern uint IsMotorolaUser(uint A_0);
	}
}
