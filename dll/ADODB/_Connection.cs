using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ADODB
{
	// Token: 0x0200003F RID: 63
	[global::System.Runtime.InteropServices.Guid("00000550-0000-0010-8000-00AA006D2EA4")]
	[global::System.Runtime.InteropServices.TypeLibType(4160)]
	[global::System.Reflection.DefaultMember("ConnectionString")]
	[global::System.Runtime.InteropServices.ComImport]
	public interface _Connection : global::ADODB.Connection15
	{
		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000031 RID: 49
		[global::System.Runtime.InteropServices.DispId(500)]
		global::ADODB.Properties Properties { [global::System.Runtime.InteropServices.DispId(500)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.CustomMarshaler, MarshalTypeRef = ADODB.PropertiesToInternalPropertiesMarshaler)] get; }

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000032 RID: 50
		// (set) Token: 0x06000033 RID: 51
		[global::System.Runtime.InteropServices.DispId(0)]
		[global::System.Runtime.CompilerServices.IndexerName("ConnectionString")]
		string ConnectionString { [global::System.Runtime.InteropServices.DispId(0)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(0)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000034 RID: 52
		// (set) Token: 0x06000035 RID: 53
		[global::System.Runtime.InteropServices.DispId(2)]
		int CommandTimeout { [global::System.Runtime.InteropServices.DispId(2)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(2)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000036 RID: 54
		// (set) Token: 0x06000037 RID: 55
		[global::System.Runtime.InteropServices.DispId(3)]
		int ConnectionTimeout { [global::System.Runtime.InteropServices.DispId(3)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(3)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000038 RID: 56
		[global::System.Runtime.InteropServices.DispId(4)]
		string Version { [global::System.Runtime.InteropServices.DispId(4)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x06000039 RID: 57
		[global::System.Runtime.InteropServices.DispId(5)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void Close();

		// Token: 0x0600003A RID: 58
		[global::System.Runtime.InteropServices.DispId(6)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		global::ADODB.Recordset Execute([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string CommandText, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.Optional] out object RecordsAffected, [global::System.Runtime.InteropServices.In] int Options = -1);

		// Token: 0x0600003B RID: 59
		[global::System.Runtime.InteropServices.DispId(7)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		int BeginTrans();

		// Token: 0x0600003C RID: 60
		[global::System.Runtime.InteropServices.DispId(8)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void CommitTrans();

		// Token: 0x0600003D RID: 61
		[global::System.Runtime.InteropServices.DispId(9)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void RollbackTrans();

		// Token: 0x0600003E RID: 62
		[global::System.Runtime.InteropServices.DispId(10)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void Open([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string ConnectionString = "", [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string UserID = "", [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string Password = "", [global::System.Runtime.InteropServices.In] int Options = -1);

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600003F RID: 63
		[global::System.Runtime.InteropServices.DispId(11)]
		global::ADODB.Errors Errors { [global::System.Runtime.InteropServices.DispId(11)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.CustomMarshaler, MarshalTypeRef = ADODB.ErrorsToInternalErrorsMarshaler)] get; }

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000040 RID: 64
		// (set) Token: 0x06000041 RID: 65
		[global::System.Runtime.InteropServices.DispId(12)]
		string DefaultDatabase { [global::System.Runtime.InteropServices.DispId(12)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(12)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000042 RID: 66
		// (set) Token: 0x06000043 RID: 67
		[global::System.Runtime.InteropServices.DispId(13)]
		global::ADODB.IsolationLevelEnum IsolationLevel { [global::System.Runtime.InteropServices.DispId(13)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(13)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000044 RID: 68
		// (set) Token: 0x06000045 RID: 69
		[global::System.Runtime.InteropServices.DispId(14)]
		int Attributes { [global::System.Runtime.InteropServices.DispId(14)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(14)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000046 RID: 70
		// (set) Token: 0x06000047 RID: 71
		[global::System.Runtime.InteropServices.DispId(15)]
		global::ADODB.CursorLocationEnum CursorLocation { [global::System.Runtime.InteropServices.DispId(15)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(15)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000048 RID: 72
		// (set) Token: 0x06000049 RID: 73
		[global::System.Runtime.InteropServices.DispId(16)]
		global::ADODB.ConnectModeEnum Mode { [global::System.Runtime.InteropServices.DispId(16)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(16)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600004A RID: 74
		// (set) Token: 0x0600004B RID: 75
		[global::System.Runtime.InteropServices.DispId(17)]
		string Provider { [global::System.Runtime.InteropServices.DispId(17)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(17)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600004C RID: 76
		[global::System.Runtime.InteropServices.DispId(18)]
		int State { [global::System.Runtime.InteropServices.DispId(18)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x0600004D RID: 77
		[global::System.Runtime.InteropServices.DispId(19)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		global::ADODB.Recordset OpenSchema([global::System.Runtime.InteropServices.In] global::ADODB.SchemaEnum Schema, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] object Restrictions, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] object SchemaID);

		// Token: 0x0600004E RID: 78
		[global::System.Runtime.InteropServices.DispId(21)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void Cancel();
	}
}
