using System;
using System.Runtime.CompilerServices;

namespace std
{
	// Token: 0x02000062 RID: 98
	[global::System.Runtime.CompilerServices.NativeCppClass]
	[global::System.Runtime.CompilerServices.UnsafeValueType]
	internal struct basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>
	{
		// Token: 0x0600021E RID: 542 RVA: 0x00003F9C File Offset: 0x0000339C
		public unsafe static void <MarshalCopy>(global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* A_0, global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* A_1)
		{
			global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.{ctor}(A_0, A_1);
		}

		// Token: 0x0600021F RID: 543 RVA: 0x00003D9C File Offset: 0x0000319C
		public unsafe static void <MarshalDestroy>(global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* A_0)
		{
			global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.{dtor}(A_0);
		}
	}
}
