using System;
using System.Collections.Generic;

namespace System.Data.SQLite
{
	// Token: 0x02000037 RID: 55
	internal static class SQLiteDefineConstants
	{
		// Token: 0x060002E7 RID: 743 RVA: 0x0001C738 File Offset: 0x0001BB38
		// Note: this type is marked as 'beforefieldinit'.
		static SQLiteDefineConstants()
		{
			string[] array = new string[12];
			array[0] = "INTEROP_CODEC";
			array[1] = "INTEROP_EXTENSION_FUNCTIONS";
			array[2] = "INTEROP_VIRTUAL_TABLE";
			array[3] = "NET_40";
			array[4] = "PRELOAD_NATIVE_LIBRARY";
			array[5] = "THROW_ON_DISPOSED";
			array[6] = "TRACE";
			array[7] = "TRACE_PRELOAD";
			array[8] = "TRACE_WARNING";
			array[9] = "USE_PREPARE_V2";
			array[10] = "WINDOWS";
			global::System.Data.SQLite.SQLiteDefineConstants.OptionList = new global::System.Collections.Generic.List<string>(array);
		}

		// Token: 0x04000144 RID: 324
		public static readonly global::System.Collections.Generic.IList<string> OptionList;
	}
}
