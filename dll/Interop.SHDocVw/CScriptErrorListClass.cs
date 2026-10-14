using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SHDocVw
{
	// Token: 0x0200005F RID: 95
	[global::System.Runtime.InteropServices.Guid("EFD01300-160F-11D2-BB2E-00805FF7EFCA")]
	[global::System.Runtime.InteropServices.ClassInterface(0)]
	[global::System.Runtime.InteropServices.TypeLibType(18)]
	[global::System.Runtime.InteropServices.ComImport]
	public class CScriptErrorListClass : global::SHDocVw.IScriptErrorList, global::SHDocVw.CScriptErrorList
	{
		// Token: 0x06000550 RID: 1360
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public extern CScriptErrorListClass();

		// Token: 0x06000551 RID: 1361
		[global::System.Runtime.InteropServices.DispId(10)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void advanceError();

		// Token: 0x06000552 RID: 1362
		[global::System.Runtime.InteropServices.DispId(11)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void retreatError();

		// Token: 0x06000553 RID: 1363
		[global::System.Runtime.InteropServices.DispId(12)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern int canAdvanceError();

		// Token: 0x06000554 RID: 1364
		[global::System.Runtime.InteropServices.DispId(13)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern int canRetreatError();

		// Token: 0x06000555 RID: 1365
		[global::System.Runtime.InteropServices.DispId(14)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern int getErrorLine();

		// Token: 0x06000556 RID: 1366
		[global::System.Runtime.InteropServices.DispId(15)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern int getErrorChar();

		// Token: 0x06000557 RID: 1367
		[global::System.Runtime.InteropServices.DispId(16)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern int getErrorCode();

		// Token: 0x06000558 RID: 1368
		[global::System.Runtime.InteropServices.DispId(17)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public virtual extern string getErrorMsg();

		// Token: 0x06000559 RID: 1369
		[global::System.Runtime.InteropServices.DispId(18)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public virtual extern string getErrorUrl();

		// Token: 0x0600055A RID: 1370
		[global::System.Runtime.InteropServices.DispId(23)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern int getAlwaysShowLockState();

		// Token: 0x0600055B RID: 1371
		[global::System.Runtime.InteropServices.DispId(19)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern int getDetailsPaneOpen();

		// Token: 0x0600055C RID: 1372
		[global::System.Runtime.InteropServices.DispId(20)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void setDetailsPaneOpen(int fDetailsPaneOpen);

		// Token: 0x0600055D RID: 1373
		[global::System.Runtime.InteropServices.DispId(21)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern int getPerErrorDisplay();

		// Token: 0x0600055E RID: 1374
		[global::System.Runtime.InteropServices.DispId(22)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void setPerErrorDisplay(int fPerErrorDisplay);
	}
}
