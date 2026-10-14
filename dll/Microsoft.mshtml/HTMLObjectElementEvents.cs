using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x02000B1D RID: 2845
	[global::System.Runtime.InteropServices.InterfaceType(2)]
	[global::System.Runtime.InteropServices.TypeLibType(4112)]
	[global::System.Runtime.InteropServices.Guid("3050F3C4-98B5-11CF-BB82-00AA00BDCE0B")]
	[global::System.Runtime.InteropServices.ComImport]
	public interface HTMLObjectElementEvents
	{
		// Token: 0x06012728 RID: 75560
		[global::System.Runtime.InteropServices.DispId(-2147418108)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		bool onbeforeupdate();

		// Token: 0x06012729 RID: 75561
		[global::System.Runtime.InteropServices.DispId(-2147418107)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void onafterupdate();

		// Token: 0x0601272A RID: 75562
		[global::System.Runtime.InteropServices.DispId(-2147418099)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		bool onerrorupdate();

		// Token: 0x0601272B RID: 75563
		[global::System.Runtime.InteropServices.DispId(-2147418106)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		bool onrowexit();

		// Token: 0x0601272C RID: 75564
		[global::System.Runtime.InteropServices.DispId(-2147418105)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void onrowenter();

		// Token: 0x0601272D RID: 75565
		[global::System.Runtime.InteropServices.DispId(-2147418098)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void ondatasetchanged();

		// Token: 0x0601272E RID: 75566
		[global::System.Runtime.InteropServices.DispId(-2147418097)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void ondataavailable();

		// Token: 0x0601272F RID: 75567
		[global::System.Runtime.InteropServices.DispId(-2147418096)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void ondatasetcomplete();

		// Token: 0x06012730 RID: 75568
		[global::System.Runtime.InteropServices.DispId(-2147418093)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		bool onerror();

		// Token: 0x06012731 RID: 75569
		[global::System.Runtime.InteropServices.DispId(-2147418080)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void onrowsdelete();

		// Token: 0x06012732 RID: 75570
		[global::System.Runtime.InteropServices.DispId(-2147418079)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void onrowsinserted();

		// Token: 0x06012733 RID: 75571
		[global::System.Runtime.InteropServices.DispId(-2147418078)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void oncellchange();

		// Token: 0x06012734 RID: 75572
		[global::System.Runtime.InteropServices.DispId(-2147418092)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void onreadystatechange();
	}
}
