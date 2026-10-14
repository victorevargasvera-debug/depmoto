using System;
using System.Runtime.CompilerServices;

namespace std
{
	// Token: 0x02000030 RID: 48
	[global::System.Runtime.CompilerServices.NativeCppClass]
	[global::System.Runtime.CompilerServices.UnsafeValueType]
	internal struct basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>
	{
		// Token: 0x06000125 RID: 293 RVA: 0x00003850 File Offset: 0x00002C50
		public unsafe static void <MarshalCopy>(global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* A_0, global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* A_1)
		{
			*(int*)(A_0 + 16 / sizeof(global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>)) = 0;
			*(int*)(A_0 + 20 / sizeof(global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>)) = 0;
			global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>._Tidy(A_0, false, 0U);
			global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.assign(A_0, A_1, 0U, uint.MaxValue);
		}

		// Token: 0x06000126 RID: 294 RVA: 0x000033D8 File Offset: 0x000027D8
		public unsafe static void <MarshalDestroy>(global::std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>* A_0)
		{
			global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>._Tidy(A_0, true, 0U);
		}
	}
}
