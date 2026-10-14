using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ADODB
{
	// Token: 0x02000061 RID: 97
	[global::System.Runtime.InteropServices.Guid("00000560-0000-0010-8000-00AA006D2EA4")]
	[global::System.Runtime.InteropServices.ClassInterface(0)]
	[global::System.Reflection.DefaultMember("Fields")]
	[global::System.Runtime.InteropServices.TypeLibType(6)]
	[global::System.Runtime.InteropServices.ComImport]
	public class RecordClass : global::ADODB._Record, global::ADODB.Record
	{
		// Token: 0x060002A8 RID: 680
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public extern RecordClass();

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x060002A9 RID: 681
		[global::System.Runtime.InteropServices.DispId(500)]
		public virtual extern global::ADODB.Properties Properties { [global::System.Runtime.InteropServices.DispId(500)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.CustomMarshaler, MarshalTypeRef = ADODB.PropertiesToInternalPropertiesMarshaler)] get; }

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x060002AA RID: 682
		// (set) Token: 0x060002AC RID: 684
		[global::System.Runtime.InteropServices.DispId(1)]
		public virtual extern object ActiveConnection { [global::System.Runtime.InteropServices.DispId(1)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(1)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x060002AD RID: 685
		[global::System.Runtime.InteropServices.DispId(2)]
		public virtual extern global::ADODB.ObjectStateEnum State { [global::System.Runtime.InteropServices.DispId(2)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x060002AE RID: 686
		// (set) Token: 0x060002B0 RID: 688
		[global::System.Runtime.InteropServices.DispId(3)]
		public virtual extern object Source { [global::System.Runtime.InteropServices.DispId(3)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(3)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x060002B1 RID: 689
		// (set) Token: 0x060002B2 RID: 690
		[global::System.Runtime.InteropServices.DispId(4)]
		public virtual extern global::ADODB.ConnectModeEnum Mode { [global::System.Runtime.InteropServices.DispId(4)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(4)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x060002B3 RID: 691
		[global::System.Runtime.InteropServices.DispId(5)]
		public virtual extern string ParentURL { [global::System.Runtime.InteropServices.DispId(5)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x060002B4 RID: 692
		[global::System.Runtime.InteropServices.DispId(6)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public virtual extern string MoveRecord([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string Source = "", [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string Destination = "", [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string UserName = "", [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string Password = "", [global::System.Runtime.InteropServices.In] global::ADODB.MoveRecordOptionsEnum Options = global::ADODB.MoveRecordOptionsEnum.adMoveUnspecified, [global::System.Runtime.InteropServices.In] bool Async = false);

		// Token: 0x060002B5 RID: 693
		[global::System.Runtime.InteropServices.DispId(7)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public virtual extern string CopyRecord([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string Source = "", [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string Destination = "", [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string UserName = "", [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string Password = "", [global::System.Runtime.InteropServices.In] global::ADODB.CopyRecordOptionsEnum Options = global::ADODB.CopyRecordOptionsEnum.adCopyUnspecified, [global::System.Runtime.InteropServices.In] bool Async = false);

		// Token: 0x060002B6 RID: 694
		[global::System.Runtime.InteropServices.DispId(8)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void DeleteRecord([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string Source = "", [global::System.Runtime.InteropServices.In] bool Async = false);

		// Token: 0x060002B7 RID: 695
		[global::System.Runtime.InteropServices.DispId(9)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void Open([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] object Source, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] object ActiveConnection, [global::System.Runtime.InteropServices.In] global::ADODB.ConnectModeEnum Mode = global::ADODB.ConnectModeEnum.adModeUnknown, [global::System.Runtime.InteropServices.In] global::ADODB.RecordCreateOptionsEnum CreateOptions = global::ADODB.RecordCreateOptionsEnum.adFailIfNotExists, [global::System.Runtime.InteropServices.In] global::ADODB.RecordOpenOptionsEnum Options = global::ADODB.RecordOpenOptionsEnum.adOpenRecordUnspecified, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string UserName = "", [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string Password = "");

		// Token: 0x060002B8 RID: 696
		[global::System.Runtime.InteropServices.DispId(10)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void Close();

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x060002B9 RID: 697
		[global::System.Runtime.InteropServices.DispId(0)]
		[global::System.Runtime.CompilerServices.IndexerName("Fields")]
		public virtual extern global::ADODB.Fields Fields { [global::System.Runtime.InteropServices.DispId(0)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.CustomMarshaler, MarshalTypeRef = ADODB.FieldsToInternalFieldsMarshaler)] get; }

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x060002BA RID: 698
		[global::System.Runtime.InteropServices.DispId(11)]
		public virtual extern global::ADODB.RecordTypeEnum RecordType { [global::System.Runtime.InteropServices.DispId(11)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x060002BB RID: 699
		[global::System.Runtime.InteropServices.DispId(12)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::ADODB.Recordset GetChildren();

		// Token: 0x060002BC RID: 700
		[global::System.Runtime.InteropServices.DispId(13)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void Cancel();
	}
}
