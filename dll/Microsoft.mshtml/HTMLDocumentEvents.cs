using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x020007E0 RID: 2016
	[global::System.Runtime.InteropServices.TypeLibType(4112)]
	[global::System.Runtime.InteropServices.InterfaceType(2)]
	[global::System.Runtime.InteropServices.Guid("3050F260-98B5-11CF-BB82-00AA00BDCE0B")]
	[global::System.Runtime.InteropServices.ComImport]
	public interface HTMLDocumentEvents
	{
		// Token: 0x0600DA40 RID: 55872
		[global::System.Runtime.InteropServices.DispId(-2147418102)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		bool onhelp();

		// Token: 0x0600DA41 RID: 55873
		[global::System.Runtime.InteropServices.DispId(-600)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		bool onclick();

		// Token: 0x0600DA42 RID: 55874
		[global::System.Runtime.InteropServices.DispId(-601)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		bool ondblclick();

		// Token: 0x0600DA43 RID: 55875
		[global::System.Runtime.InteropServices.DispId(-602)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void onkeydown();

		// Token: 0x0600DA44 RID: 55876
		[global::System.Runtime.InteropServices.DispId(-604)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void onkeyup();

		// Token: 0x0600DA45 RID: 55877
		[global::System.Runtime.InteropServices.DispId(-603)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		bool onkeypress();

		// Token: 0x0600DA46 RID: 55878
		[global::System.Runtime.InteropServices.DispId(-605)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void onmousedown();

		// Token: 0x0600DA47 RID: 55879
		[global::System.Runtime.InteropServices.DispId(-606)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void onmousemove();

		// Token: 0x0600DA48 RID: 55880
		[global::System.Runtime.InteropServices.DispId(-607)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void onmouseup();

		// Token: 0x0600DA49 RID: 55881
		[global::System.Runtime.InteropServices.DispId(-2147418103)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void onmouseout();

		// Token: 0x0600DA4A RID: 55882
		[global::System.Runtime.InteropServices.DispId(-2147418104)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void onmouseover();

		// Token: 0x0600DA4B RID: 55883
		[global::System.Runtime.InteropServices.DispId(-609)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void onreadystatechange();

		// Token: 0x0600DA4C RID: 55884
		[global::System.Runtime.InteropServices.DispId(-2147418108)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		bool onbeforeupdate();

		// Token: 0x0600DA4D RID: 55885
		[global::System.Runtime.InteropServices.DispId(-2147418107)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void onafterupdate();

		// Token: 0x0600DA4E RID: 55886
		[global::System.Runtime.InteropServices.DispId(-2147418106)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		bool onrowexit();

		// Token: 0x0600DA4F RID: 55887
		[global::System.Runtime.InteropServices.DispId(-2147418105)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void onrowenter();

		// Token: 0x0600DA50 RID: 55888
		[global::System.Runtime.InteropServices.DispId(-2147418101)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		bool ondragstart();

		// Token: 0x0600DA51 RID: 55889
		[global::System.Runtime.InteropServices.DispId(-2147418100)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		bool onselectstart();

		// Token: 0x0600DA52 RID: 55890
		[global::System.Runtime.InteropServices.DispId(-2147418099)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		bool onerrorupdate();

		// Token: 0x0600DA53 RID: 55891
		[global::System.Runtime.InteropServices.DispId(1023)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		bool oncontextmenu();

		// Token: 0x0600DA54 RID: 55892
		[global::System.Runtime.InteropServices.DispId(1026)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		bool onstop();

		// Token: 0x0600DA55 RID: 55893
		[global::System.Runtime.InteropServices.DispId(-2147418080)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void onrowsdelete();

		// Token: 0x0600DA56 RID: 55894
		[global::System.Runtime.InteropServices.DispId(-2147418079)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void onrowsinserted();

		// Token: 0x0600DA57 RID: 55895
		[global::System.Runtime.InteropServices.DispId(-2147418078)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void oncellchange();

		// Token: 0x0600DA58 RID: 55896
		[global::System.Runtime.InteropServices.DispId(-2147418093)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void onpropertychange();

		// Token: 0x0600DA59 RID: 55897
		[global::System.Runtime.InteropServices.DispId(-2147418098)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void ondatasetchanged();

		// Token: 0x0600DA5A RID: 55898
		[global::System.Runtime.InteropServices.DispId(-2147418097)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void ondataavailable();

		// Token: 0x0600DA5B RID: 55899
		[global::System.Runtime.InteropServices.DispId(-2147418096)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void ondatasetcomplete();

		// Token: 0x0600DA5C RID: 55900
		[global::System.Runtime.InteropServices.DispId(1027)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void onbeforeeditfocus();

		// Token: 0x0600DA5D RID: 55901
		[global::System.Runtime.InteropServices.DispId(1037)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void onselectionchange();

		// Token: 0x0600DA5E RID: 55902
		[global::System.Runtime.InteropServices.DispId(1036)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		bool oncontrolselect();

		// Token: 0x0600DA5F RID: 55903
		[global::System.Runtime.InteropServices.DispId(1033)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		bool onmousewheel();

		// Token: 0x0600DA60 RID: 55904
		[global::System.Runtime.InteropServices.DispId(1048)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void onfocusin();

		// Token: 0x0600DA61 RID: 55905
		[global::System.Runtime.InteropServices.DispId(1049)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void onfocusout();

		// Token: 0x0600DA62 RID: 55906
		[global::System.Runtime.InteropServices.DispId(1044)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void onactivate();

		// Token: 0x0600DA63 RID: 55907
		[global::System.Runtime.InteropServices.DispId(1045)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void ondeactivate();

		// Token: 0x0600DA64 RID: 55908
		[global::System.Runtime.InteropServices.DispId(1047)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		bool onbeforeactivate();

		// Token: 0x0600DA65 RID: 55909
		[global::System.Runtime.InteropServices.DispId(1034)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		bool onbeforedeactivate();
	}
}
