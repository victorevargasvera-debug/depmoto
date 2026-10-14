using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ADODB;

namespace CDO
{
	// Token: 0x02000069 RID: 105
	[global::System.Runtime.InteropServices.TypeLibType(2)]
	[global::System.Runtime.InteropServices.Guid("CD00010E-8B95-11D1-82DB-00C04FB1625D")]
	[global::System.Runtime.InteropServices.ClassInterface(0)]
	[global::System.Runtime.InteropServices.ComImport]
	public class FolderClass : global::CDO.IFolder, global::CDO.Folder, global::CDO.IDataSource
	{
		// Token: 0x06000282 RID: 642
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public extern FolderClass();

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x06000283 RID: 643
		[global::System.Runtime.InteropServices.DispId(1)]
		public virtual extern string DisplayName { [global::System.Runtime.InteropServices.DispId(1)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x06000284 RID: 644
		// (set) Token: 0x06000286 RID: 646
		[global::System.Runtime.InteropServices.DispId(2)]
		public virtual extern global::CDO.Configuration Configuration { [global::System.Runtime.InteropServices.DispId(2)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; [global::System.Runtime.InteropServices.DispId(2)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x06000287 RID: 647
		[global::System.Runtime.InteropServices.DispId(3)]
		public virtual extern global::CDO.IDataSource DataSource { [global::System.Runtime.InteropServices.DispId(3)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x06000288 RID: 648
		[global::System.Runtime.InteropServices.DispId(5)]
		public virtual extern string EmailAddress { [global::System.Runtime.InteropServices.DispId(5)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x06000289 RID: 649
		[global::System.Runtime.InteropServices.DispId(6)]
		public virtual extern int UnreadItemCount { [global::System.Runtime.InteropServices.DispId(6)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x0600028A RID: 650
		[global::System.Runtime.InteropServices.DispId(7)]
		public virtual extern int VisibleCount { [global::System.Runtime.InteropServices.DispId(7)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x0600028B RID: 651
		[global::System.Runtime.InteropServices.DispId(8)]
		public virtual extern int ItemCount { [global::System.Runtime.InteropServices.DispId(8)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x0600028C RID: 652
		[global::System.Runtime.InteropServices.DispId(9)]
		public virtual extern bool HasSubFolders { [global::System.Runtime.InteropServices.DispId(9)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x0600028D RID: 653
		// (set) Token: 0x0600028E RID: 654
		[global::System.Runtime.InteropServices.DispId(12)]
		public virtual extern string Description { [global::System.Runtime.InteropServices.DispId(12)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(12)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x0600028F RID: 655
		[global::System.Runtime.InteropServices.DispId(13)]
		public virtual extern global::ADODB.Fields Fields { [global::System.Runtime.InteropServices.DispId(13)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x06000290 RID: 656
		// (set) Token: 0x06000291 RID: 657
		[global::System.Runtime.InteropServices.DispId(14)]
		public virtual extern string ContentClass { [global::System.Runtime.InteropServices.DispId(14)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(14)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x06000292 RID: 658
		[global::System.Runtime.InteropServices.DispId(15)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)]
		public virtual extern object GetInterface([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string Interface);

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x06000293 RID: 659
		public virtual extern string SourceClass { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06000294 RID: 660
		public virtual extern object Source { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IUnknown)] get; }

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x06000295 RID: 661
		// (set) Token: 0x06000296 RID: 662
		public virtual extern bool IsDirty { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06000297 RID: 663
		public virtual extern string SourceURL { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x06000298 RID: 664
		public virtual extern global::ADODB.Connection ActiveConnection { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x06000299 RID: 665
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void SaveToObject([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IUnknown)] [global::System.Runtime.InteropServices.In] object Source, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string InterfaceName);

		// Token: 0x0600029A RID: 666
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void OpenObject([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IUnknown)] [global::System.Runtime.InteropServices.In] object Source, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string InterfaceName);

		// Token: 0x0600029B RID: 667
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void SaveTo([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string SourceURL, [global::System.Runtime.CompilerServices.IDispatchConstant] [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] object ActiveConnection, [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] global::ADODB.ConnectModeEnum Mode, [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] global::ADODB.RecordCreateOptionsEnum CreateOptions, [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] global::ADODB.RecordOpenOptionsEnum Options, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] string UserName, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] string Password);

		// Token: 0x0600029C RID: 668
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void Open([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string SourceURL, [global::System.Runtime.CompilerServices.IDispatchConstant] [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] object ActiveConnection, [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] global::ADODB.ConnectModeEnum Mode, [global::System.Runtime.InteropServices.In] global::ADODB.RecordCreateOptionsEnum CreateOptions = global::ADODB.RecordCreateOptionsEnum.adFailIfNotExists, [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] global::ADODB.RecordOpenOptionsEnum Options, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] string UserName, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] string Password);

		// Token: 0x0600029D RID: 669
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void Save();

		// Token: 0x0600029E RID: 670
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void SaveToContainer([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string ContainerURL, [global::System.Runtime.CompilerServices.IDispatchConstant] [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] object ActiveConnection, [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] global::ADODB.ConnectModeEnum Mode, [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] global::ADODB.RecordCreateOptionsEnum CreateOptions, [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] global::ADODB.RecordOpenOptionsEnum Options, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] string UserName, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] string Password);
	}
}
