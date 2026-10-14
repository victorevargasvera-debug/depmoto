using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ADODB
{
	// Token: 0x02000054 RID: 84
	[global::System.Reflection.DefaultMember("ConnectionString")]
	[global::System.Runtime.InteropServices.ClassInterface(0)]
	[global::System.Runtime.InteropServices.Guid("00000514-0000-0010-8000-00AA006D2EA4")]
	[global::System.Runtime.InteropServices.TypeLibType(6)]
	[global::System.Runtime.InteropServices.ComSourceInterfaces("ADODB.ConnectionEvents\0\0")]
	[global::System.Runtime.InteropServices.ComImport]
	public class ConnectionClass : global::ADODB._Connection, global::ADODB.Connection, global::ADODB.ConnectionEvents_Event
	{
		// Token: 0x0600023F RID: 575
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public extern ConnectionClass();

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x06000240 RID: 576
		[global::System.Runtime.InteropServices.DispId(500)]
		public virtual extern global::ADODB.Properties Properties { [global::System.Runtime.InteropServices.DispId(500)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.CustomMarshaler, MarshalTypeRef = ADODB.PropertiesToInternalPropertiesMarshaler)] get; }

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000241 RID: 577
		// (set) Token: 0x06000242 RID: 578
		[global::System.Runtime.InteropServices.DispId(0)]
		[global::System.Runtime.CompilerServices.IndexerName("ConnectionString")]
		public virtual extern string ConnectionString { [global::System.Runtime.InteropServices.DispId(0)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(0)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000243 RID: 579
		// (set) Token: 0x06000244 RID: 580
		[global::System.Runtime.InteropServices.DispId(2)]
		public virtual extern int CommandTimeout { [global::System.Runtime.InteropServices.DispId(2)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(2)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000245 RID: 581
		// (set) Token: 0x06000246 RID: 582
		[global::System.Runtime.InteropServices.DispId(3)]
		public virtual extern int ConnectionTimeout { [global::System.Runtime.InteropServices.DispId(3)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(3)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000247 RID: 583
		[global::System.Runtime.InteropServices.DispId(4)]
		public virtual extern string Version { [global::System.Runtime.InteropServices.DispId(4)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x06000248 RID: 584
		[global::System.Runtime.InteropServices.DispId(5)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void Close();

		// Token: 0x06000249 RID: 585
		[global::System.Runtime.InteropServices.DispId(6)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::ADODB.Recordset Execute([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string CommandText, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.Optional] out object RecordsAffected, [global::System.Runtime.InteropServices.In] int Options = -1);

		// Token: 0x0600024A RID: 586
		[global::System.Runtime.InteropServices.DispId(7)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern int BeginTrans();

		// Token: 0x0600024B RID: 587
		[global::System.Runtime.InteropServices.DispId(8)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void CommitTrans();

		// Token: 0x0600024C RID: 588
		[global::System.Runtime.InteropServices.DispId(9)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void RollbackTrans();

		// Token: 0x0600024D RID: 589
		[global::System.Runtime.InteropServices.DispId(10)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void Open([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string ConnectionString = "", [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string UserID = "", [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string Password = "", [global::System.Runtime.InteropServices.In] int Options = -1);

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x0600024E RID: 590
		[global::System.Runtime.InteropServices.DispId(11)]
		public virtual extern global::ADODB.Errors Errors { [global::System.Runtime.InteropServices.DispId(11)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.CustomMarshaler, MarshalTypeRef = ADODB.ErrorsToInternalErrorsMarshaler)] get; }

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x0600024F RID: 591
		// (set) Token: 0x06000250 RID: 592
		[global::System.Runtime.InteropServices.DispId(12)]
		public virtual extern string DefaultDatabase { [global::System.Runtime.InteropServices.DispId(12)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(12)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000251 RID: 593
		// (set) Token: 0x06000252 RID: 594
		[global::System.Runtime.InteropServices.DispId(13)]
		public virtual extern global::ADODB.IsolationLevelEnum IsolationLevel { [global::System.Runtime.InteropServices.DispId(13)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(13)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000253 RID: 595
		// (set) Token: 0x06000254 RID: 596
		[global::System.Runtime.InteropServices.DispId(14)]
		public virtual extern int Attributes { [global::System.Runtime.InteropServices.DispId(14)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(14)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x06000255 RID: 597
		// (set) Token: 0x06000256 RID: 598
		[global::System.Runtime.InteropServices.DispId(15)]
		public virtual extern global::ADODB.CursorLocationEnum CursorLocation { [global::System.Runtime.InteropServices.DispId(15)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(15)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x06000257 RID: 599
		// (set) Token: 0x06000258 RID: 600
		[global::System.Runtime.InteropServices.DispId(16)]
		public virtual extern global::ADODB.ConnectModeEnum Mode { [global::System.Runtime.InteropServices.DispId(16)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(16)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000259 RID: 601
		// (set) Token: 0x0600025A RID: 602
		[global::System.Runtime.InteropServices.DispId(17)]
		public virtual extern string Provider { [global::System.Runtime.InteropServices.DispId(17)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(17)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x0600025B RID: 603
		[global::System.Runtime.InteropServices.DispId(18)]
		public virtual extern int State { [global::System.Runtime.InteropServices.DispId(18)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x0600025C RID: 604
		[global::System.Runtime.InteropServices.DispId(19)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::ADODB.Recordset OpenSchema([global::System.Runtime.InteropServices.In] global::ADODB.SchemaEnum Schema, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] object Restrictions, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] object SchemaID);

		// Token: 0x0600025D RID: 605
		[global::System.Runtime.InteropServices.DispId(21)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void Cancel();

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x0600025E RID: 606
		// (remove) Token: 0x0600025F RID: 607
		public virtual extern event global::ADODB.ConnectionEvents_InfoMessageEventHandler InfoMessage;

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000260 RID: 608
		// (remove) Token: 0x06000261 RID: 609
		public virtual extern event global::ADODB.ConnectionEvents_BeginTransCompleteEventHandler BeginTransComplete;

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000262 RID: 610
		// (remove) Token: 0x06000263 RID: 611
		public virtual extern event global::ADODB.ConnectionEvents_CommitTransCompleteEventHandler CommitTransComplete;

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06000264 RID: 612
		// (remove) Token: 0x06000265 RID: 613
		public virtual extern event global::ADODB.ConnectionEvents_RollbackTransCompleteEventHandler RollbackTransComplete;

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x06000266 RID: 614
		// (remove) Token: 0x06000267 RID: 615
		public virtual extern event global::ADODB.ConnectionEvents_WillExecuteEventHandler WillExecute;

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x06000268 RID: 616
		// (remove) Token: 0x06000269 RID: 617
		public virtual extern event global::ADODB.ConnectionEvents_ExecuteCompleteEventHandler ExecuteComplete;

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x0600026A RID: 618
		// (remove) Token: 0x0600026B RID: 619
		public virtual extern event global::ADODB.ConnectionEvents_WillConnectEventHandler WillConnect;

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x0600026C RID: 620
		// (remove) Token: 0x0600026D RID: 621
		public virtual extern event global::ADODB.ConnectionEvents_ConnectCompleteEventHandler ConnectComplete;

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x0600026E RID: 622
		// (remove) Token: 0x0600026F RID: 623
		public virtual extern event global::ADODB.ConnectionEvents_DisconnectEventHandler Disconnect;
	}
}
