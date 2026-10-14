using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x02000CB1 RID: 3249
	[global::System.Runtime.InteropServices.InterfaceType(1)]
	[global::System.Runtime.InteropServices.Guid("3050F7E2-98B5-11CF-BB82-00AA00BDCE0B")]
	[global::System.Runtime.InteropServices.ComImport]
	public interface ILineInfo
	{
		// Token: 0x1700759A RID: 30106
		// (get) Token: 0x06016282 RID: 90754
		[global::System.Runtime.InteropServices.DispId(1001)]
		int x { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700759B RID: 30107
		// (get) Token: 0x06016283 RID: 90755
		[global::System.Runtime.InteropServices.DispId(1002)]
		int baseLine { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700759C RID: 30108
		// (get) Token: 0x06016284 RID: 90756
		[global::System.Runtime.InteropServices.DispId(1003)]
		int textDescent { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700759D RID: 30109
		// (get) Token: 0x06016285 RID: 90757
		[global::System.Runtime.InteropServices.DispId(1004)]
		int textHeight { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700759E RID: 30110
		// (get) Token: 0x06016286 RID: 90758
		[global::System.Runtime.InteropServices.DispId(1005)]
		int lineDirection { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }
	}
}
