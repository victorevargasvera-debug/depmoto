using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ADODB
{
	// Token: 0x0200006B RID: 107
	[global::System.Runtime.InteropServices.ClassInterface(0)]
	[global::System.Runtime.InteropServices.TypeLibType(6)]
	[global::System.Runtime.InteropServices.ComSourceInterfaces("ADODB.RecordsetEvents\0\0")]
	[global::System.Reflection.DefaultMember("Fields")]
	[global::System.Runtime.InteropServices.Guid("00000535-0000-0010-8000-00AA006D2EA4")]
	[global::System.Runtime.InteropServices.ComImport]
	public class RecordsetClass : global::ADODB._Recordset, global::ADODB.Recordset, global::ADODB.RecordsetEvents_Event
	{
		// Token: 0x06000313 RID: 787
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public extern RecordsetClass();

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06000314 RID: 788
		[global::System.Runtime.InteropServices.DispId(500)]
		public virtual extern global::ADODB.Properties Properties { [global::System.Runtime.InteropServices.DispId(500)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.CustomMarshaler, MarshalTypeRef = ADODB.PropertiesToInternalPropertiesMarshaler)] get; }

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06000315 RID: 789
		// (set) Token: 0x06000316 RID: 790
		[global::System.Runtime.InteropServices.DispId(1000)]
		public virtual extern global::ADODB.PositionEnum AbsolutePosition { [global::System.Runtime.InteropServices.DispId(1000)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(1000)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000319 RID: 793
		// (set) Token: 0x06000317 RID: 791
		[global::System.Runtime.InteropServices.DispId(1001)]
		public virtual extern object ActiveConnection { [global::System.Runtime.InteropServices.DispId(1001)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(1001)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x0600031A RID: 794
		[global::System.Runtime.InteropServices.DispId(1002)]
		public virtual extern bool BOF { [global::System.Runtime.InteropServices.DispId(1002)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x0600031B RID: 795
		// (set) Token: 0x0600031C RID: 796
		[global::System.Runtime.InteropServices.DispId(1003)]
		public virtual extern object Bookmark { [global::System.Runtime.InteropServices.DispId(1003)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(1003)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x0600031D RID: 797
		// (set) Token: 0x0600031E RID: 798
		[global::System.Runtime.InteropServices.DispId(1004)]
		public virtual extern int CacheSize { [global::System.Runtime.InteropServices.DispId(1004)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(1004)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x0600031F RID: 799
		// (set) Token: 0x06000320 RID: 800
		[global::System.Runtime.InteropServices.DispId(1005)]
		public virtual extern global::ADODB.CursorTypeEnum CursorType { [global::System.Runtime.InteropServices.DispId(1005)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(1005)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x06000321 RID: 801
		[global::System.Runtime.InteropServices.DispId(1006)]
		public virtual extern bool EOF { [global::System.Runtime.InteropServices.DispId(1006)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x06000322 RID: 802
		[global::System.Runtime.InteropServices.DispId(0)]
		[global::System.Runtime.CompilerServices.IndexerName("Fields")]
		public virtual extern global::ADODB.Fields Fields { [global::System.Runtime.InteropServices.DispId(0)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.CustomMarshaler, MarshalTypeRef = ADODB.FieldsToInternalFieldsMarshaler)] get; }

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x06000323 RID: 803
		// (set) Token: 0x06000324 RID: 804
		[global::System.Runtime.InteropServices.DispId(1008)]
		public virtual extern global::ADODB.LockTypeEnum LockType { [global::System.Runtime.InteropServices.DispId(1008)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(1008)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x06000325 RID: 805
		// (set) Token: 0x06000326 RID: 806
		[global::System.Runtime.InteropServices.DispId(1009)]
		[global::System.Runtime.InteropServices.ComAliasName("ADODB.ADO_LONGPTR")]
		public virtual extern int MaxRecords { [global::System.Runtime.InteropServices.DispId(1009)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.ComAliasName("ADODB.ADO_LONGPTR")] get; [global::System.Runtime.InteropServices.DispId(1009)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.ComAliasName("ADODB.ADO_LONGPTR")] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000327 RID: 807
		[global::System.Runtime.InteropServices.ComAliasName("ADODB.ADO_LONGPTR")]
		[global::System.Runtime.InteropServices.DispId(1010)]
		public virtual extern int RecordCount { [global::System.Runtime.InteropServices.DispId(1010)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.ComAliasName("ADODB.ADO_LONGPTR")] get; }

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x0600032A RID: 810
		// (set) Token: 0x06000328 RID: 808
		[global::System.Runtime.InteropServices.DispId(1011)]
		public virtual extern object Source { [global::System.Runtime.InteropServices.DispId(1011)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(1011)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x0600032B RID: 811
		[global::System.Runtime.InteropServices.DispId(1012)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void AddNew([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] object FieldList, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] object Values);

		// Token: 0x0600032C RID: 812
		[global::System.Runtime.InteropServices.DispId(1013)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void CancelUpdate();

		// Token: 0x0600032D RID: 813
		[global::System.Runtime.InteropServices.DispId(1014)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void Close();

		// Token: 0x0600032E RID: 814
		[global::System.Runtime.InteropServices.DispId(1015)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void Delete([global::System.Runtime.InteropServices.In] global::ADODB.AffectEnum AffectRecords = global::ADODB.AffectEnum.adAffectCurrent);

		// Token: 0x0600032F RID: 815
		[global::System.Runtime.InteropServices.DispId(1016)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)]
		public virtual extern object GetRows([global::System.Runtime.InteropServices.In] int Rows = -1, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] object Start, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] object Fields);

		// Token: 0x06000330 RID: 816
		[global::System.Runtime.InteropServices.DispId(1017)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void Move([global::System.Runtime.InteropServices.ComAliasName("ADODB.ADO_LONGPTR")] [global::System.Runtime.InteropServices.In] int NumRecords, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] object Start);

		// Token: 0x06000331 RID: 817
		[global::System.Runtime.InteropServices.DispId(1018)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void MoveNext();

		// Token: 0x06000332 RID: 818
		[global::System.Runtime.InteropServices.DispId(1019)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void MovePrevious();

		// Token: 0x06000333 RID: 819
		[global::System.Runtime.InteropServices.DispId(1020)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void MoveFirst();

		// Token: 0x06000334 RID: 820
		[global::System.Runtime.InteropServices.DispId(1021)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void MoveLast();

		// Token: 0x06000335 RID: 821
		[global::System.Runtime.InteropServices.DispId(1022)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void Open([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] object Source, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] object ActiveConnection, [global::System.Runtime.InteropServices.In] global::ADODB.CursorTypeEnum CursorType = global::ADODB.CursorTypeEnum.adOpenUnspecified, [global::System.Runtime.InteropServices.In] global::ADODB.LockTypeEnum LockType = global::ADODB.LockTypeEnum.adLockUnspecified, [global::System.Runtime.InteropServices.In] int Options = -1);

		// Token: 0x06000336 RID: 822
		[global::System.Runtime.InteropServices.DispId(1023)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void Requery([global::System.Runtime.InteropServices.In] int Options = -1);

		// Token: 0x06000337 RID: 823
		[global::System.Runtime.InteropServices.DispId(1610809378)]
		[global::System.Runtime.InteropServices.TypeLibFunc(64)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void _xResync([global::System.Runtime.InteropServices.In] global::ADODB.AffectEnum AffectRecords = global::ADODB.AffectEnum.adAffectAll);

		// Token: 0x06000338 RID: 824
		[global::System.Runtime.InteropServices.DispId(1025)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void Update([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] object Fields, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] object Values);

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x06000339 RID: 825
		// (set) Token: 0x0600033A RID: 826
		[global::System.Runtime.InteropServices.DispId(1047)]
		public virtual extern global::ADODB.PositionEnum AbsolutePage { [global::System.Runtime.InteropServices.DispId(1047)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(1047)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x0600033B RID: 827
		[global::System.Runtime.InteropServices.DispId(1026)]
		public virtual extern global::ADODB.EditModeEnum EditMode { [global::System.Runtime.InteropServices.DispId(1026)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x0600033C RID: 828
		// (set) Token: 0x0600033D RID: 829
		[global::System.Runtime.InteropServices.DispId(1030)]
		public virtual extern object Filter { [global::System.Runtime.InteropServices.DispId(1030)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(1030)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x0600033E RID: 830
		[global::System.Runtime.InteropServices.ComAliasName("ADODB.ADO_LONGPTR")]
		[global::System.Runtime.InteropServices.DispId(1050)]
		public virtual extern int PageCount { [global::System.Runtime.InteropServices.DispId(1050)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.ComAliasName("ADODB.ADO_LONGPTR")] get; }

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x0600033F RID: 831
		// (set) Token: 0x06000340 RID: 832
		[global::System.Runtime.InteropServices.DispId(1048)]
		public virtual extern int PageSize { [global::System.Runtime.InteropServices.DispId(1048)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(1048)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06000341 RID: 833
		// (set) Token: 0x06000342 RID: 834
		[global::System.Runtime.InteropServices.DispId(1031)]
		public virtual extern string Sort { [global::System.Runtime.InteropServices.DispId(1031)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(1031)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x06000343 RID: 835
		[global::System.Runtime.InteropServices.DispId(1029)]
		public virtual extern int Status { [global::System.Runtime.InteropServices.DispId(1029)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x06000344 RID: 836
		[global::System.Runtime.InteropServices.DispId(1054)]
		public virtual extern int State { [global::System.Runtime.InteropServices.DispId(1054)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000345 RID: 837
		[global::System.Runtime.InteropServices.TypeLibFunc(64)]
		[global::System.Runtime.InteropServices.DispId(1610809392)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::ADODB.Recordset _xClone();

		// Token: 0x06000346 RID: 838
		[global::System.Runtime.InteropServices.DispId(1035)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void UpdateBatch([global::System.Runtime.InteropServices.In] global::ADODB.AffectEnum AffectRecords = global::ADODB.AffectEnum.adAffectAll);

		// Token: 0x06000347 RID: 839
		[global::System.Runtime.InteropServices.DispId(1049)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void CancelBatch([global::System.Runtime.InteropServices.In] global::ADODB.AffectEnum AffectRecords = global::ADODB.AffectEnum.adAffectAll);

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x06000348 RID: 840
		// (set) Token: 0x06000349 RID: 841
		[global::System.Runtime.InteropServices.DispId(1051)]
		public virtual extern global::ADODB.CursorLocationEnum CursorLocation { [global::System.Runtime.InteropServices.DispId(1051)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(1051)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x0600034A RID: 842
		[global::System.Runtime.InteropServices.DispId(1052)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::ADODB.Recordset NextRecordset([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.Optional] out object RecordsAffected);

		// Token: 0x0600034B RID: 843
		[global::System.Runtime.InteropServices.DispId(1036)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern bool Supports([global::System.Runtime.InteropServices.In] global::ADODB.CursorOptionEnum CursorOptions);

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x0600034C RID: 844
		// (set) Token: 0x0600034D RID: 845
		[global::System.Runtime.InteropServices.DispId(-8)]
		public virtual extern object Collect { [global::System.Runtime.InteropServices.TypeLibFunc(64)] [global::System.Runtime.InteropServices.DispId(-8)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-8)] [global::System.Runtime.InteropServices.TypeLibFunc(64)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x0600034E RID: 846
		// (set) Token: 0x0600034F RID: 847
		[global::System.Runtime.InteropServices.DispId(1053)]
		public virtual extern global::ADODB.MarshalOptionsEnum MarshalOptions { [global::System.Runtime.InteropServices.DispId(1053)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(1053)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x06000350 RID: 848
		[global::System.Runtime.InteropServices.DispId(1058)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void Find([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string Criteria, [global::System.Runtime.InteropServices.ComAliasName("ADODB.ADO_LONGPTR")] [global::System.Runtime.InteropServices.In] int SkipRecords = 0, [global::System.Runtime.InteropServices.In] global::ADODB.SearchDirectionEnum SearchDirection = global::ADODB.SearchDirectionEnum.adSearchForward, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] object Start);

		// Token: 0x06000351 RID: 849
		[global::System.Runtime.InteropServices.DispId(1055)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void Cancel();

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x06000352 RID: 850
		// (set) Token: 0x06000353 RID: 851
		[global::System.Runtime.InteropServices.DispId(1056)]
		public virtual extern object DataSource { [global::System.Runtime.InteropServices.DispId(1056)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IUnknown)] get; [global::System.Runtime.InteropServices.DispId(1056)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IUnknown)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x06000354 RID: 852
		[global::System.Runtime.InteropServices.TypeLibFunc(64)]
		[global::System.Runtime.InteropServices.DispId(1610874883)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void _xSave([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string FileName = "", [global::System.Runtime.InteropServices.In] global::ADODB.PersistFormatEnum PersistFormat = global::ADODB.PersistFormatEnum.adPersistADTG);

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x06000355 RID: 853
		[global::System.Runtime.InteropServices.DispId(1061)]
		public virtual extern object ActiveCommand { [global::System.Runtime.InteropServices.DispId(1061)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x06000357 RID: 855
		// (set) Token: 0x06000356 RID: 854
		[global::System.Runtime.InteropServices.DispId(1063)]
		public virtual extern bool StayInSync { [global::System.Runtime.InteropServices.DispId(1063)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(1063)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x06000358 RID: 856
		[global::System.Runtime.InteropServices.DispId(1062)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public virtual extern string GetString([global::System.Runtime.InteropServices.In] global::ADODB.StringFormatEnum StringFormat = global::ADODB.StringFormatEnum.adClipString, [global::System.Runtime.InteropServices.In] int NumRows = -1, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string ColumnDelimeter = "", [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string RowDelimeter = "", [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string NullExpr = "");

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x06000359 RID: 857
		// (set) Token: 0x0600035A RID: 858
		[global::System.Runtime.InteropServices.DispId(1064)]
		public virtual extern string DataMember { [global::System.Runtime.InteropServices.DispId(1064)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(1064)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x0600035B RID: 859
		[global::System.Runtime.InteropServices.DispId(1065)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern global::ADODB.CompareEnum CompareBookmarks([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] object Bookmark1, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] object Bookmark2);

		// Token: 0x0600035C RID: 860
		[global::System.Runtime.InteropServices.DispId(1034)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::ADODB.Recordset Clone([global::System.Runtime.InteropServices.In] global::ADODB.LockTypeEnum LockType = global::ADODB.LockTypeEnum.adLockUnspecified);

		// Token: 0x0600035D RID: 861
		[global::System.Runtime.InteropServices.DispId(1024)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void Resync([global::System.Runtime.InteropServices.In] global::ADODB.AffectEnum AffectRecords = global::ADODB.AffectEnum.adAffectAll, [global::System.Runtime.InteropServices.In] global::ADODB.ResyncEnum ResyncValues = global::ADODB.ResyncEnum.adResyncAllValues);

		// Token: 0x0600035E RID: 862
		[global::System.Runtime.InteropServices.DispId(1066)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void Seek([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] object KeyValues, [global::System.Runtime.InteropServices.In] global::ADODB.SeekEnum SeekOption = global::ADODB.SeekEnum.adSeekFirstEQ);

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x06000360 RID: 864
		// (set) Token: 0x0600035F RID: 863
		[global::System.Runtime.InteropServices.DispId(1067)]
		public virtual extern string Index { [global::System.Runtime.InteropServices.DispId(1067)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(1067)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x06000361 RID: 865
		[global::System.Runtime.InteropServices.DispId(1057)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void Save([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] object Destination, [global::System.Runtime.InteropServices.In] global::ADODB.PersistFormatEnum PersistFormat = global::ADODB.PersistFormatEnum.adPersistADTG);

		// Token: 0x14000013 RID: 19
		// (add) Token: 0x06000362 RID: 866
		// (remove) Token: 0x06000363 RID: 867
		public virtual extern event global::ADODB.RecordsetEvents_WillChangeFieldEventHandler WillChangeField;

		// Token: 0x14000014 RID: 20
		// (add) Token: 0x06000364 RID: 868
		// (remove) Token: 0x06000365 RID: 869
		public virtual extern event global::ADODB.RecordsetEvents_FieldChangeCompleteEventHandler FieldChangeComplete;

		// Token: 0x14000015 RID: 21
		// (add) Token: 0x06000366 RID: 870
		// (remove) Token: 0x06000367 RID: 871
		public virtual extern event global::ADODB.RecordsetEvents_WillChangeRecordEventHandler WillChangeRecord;

		// Token: 0x14000016 RID: 22
		// (add) Token: 0x06000368 RID: 872
		// (remove) Token: 0x06000369 RID: 873
		public virtual extern event global::ADODB.RecordsetEvents_RecordChangeCompleteEventHandler RecordChangeComplete;

		// Token: 0x14000017 RID: 23
		// (add) Token: 0x0600036A RID: 874
		// (remove) Token: 0x0600036B RID: 875
		public virtual extern event global::ADODB.RecordsetEvents_WillChangeRecordsetEventHandler WillChangeRecordset;

		// Token: 0x14000018 RID: 24
		// (add) Token: 0x0600036C RID: 876
		// (remove) Token: 0x0600036D RID: 877
		public virtual extern event global::ADODB.RecordsetEvents_RecordsetChangeCompleteEventHandler RecordsetChangeComplete;

		// Token: 0x14000019 RID: 25
		// (add) Token: 0x0600036E RID: 878
		// (remove) Token: 0x0600036F RID: 879
		public virtual extern event global::ADODB.RecordsetEvents_WillMoveEventHandler WillMove;

		// Token: 0x1400001A RID: 26
		// (add) Token: 0x06000370 RID: 880
		// (remove) Token: 0x06000371 RID: 881
		public virtual extern event global::ADODB.RecordsetEvents_MoveCompleteEventHandler MoveComplete;

		// Token: 0x1400001B RID: 27
		// (add) Token: 0x06000372 RID: 882
		// (remove) Token: 0x06000373 RID: 883
		public virtual extern event global::ADODB.RecordsetEvents_EndOfRecordsetEventHandler EndOfRecordset;

		// Token: 0x1400001C RID: 28
		// (add) Token: 0x06000374 RID: 884
		// (remove) Token: 0x06000375 RID: 885
		public virtual extern event global::ADODB.RecordsetEvents_FetchProgressEventHandler FetchProgress;

		// Token: 0x1400001D RID: 29
		// (add) Token: 0x06000376 RID: 886
		// (remove) Token: 0x06000377 RID: 887
		public virtual extern event global::ADODB.RecordsetEvents_FetchCompleteEventHandler FetchComplete;
	}
}
