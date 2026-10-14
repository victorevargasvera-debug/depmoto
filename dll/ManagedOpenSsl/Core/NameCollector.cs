using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenSSL.Core
{
	// Token: 0x0200004D RID: 77
	internal class NameCollector
	{
		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000391 RID: 913 RVA: 0x00005932 File Offset: 0x00003B32
		public global::System.Collections.Generic.List<string> Result
		{
			get
			{
				return this.list;
			}
		}

		// Token: 0x06000392 RID: 914 RVA: 0x0000593C File Offset: 0x00003B3C
		public NameCollector(int type, bool isSorted)
		{
			if (isSorted)
			{
				global::OpenSSL.Core.Native.OBJ_NAME_do_all_sorted(type, new global::OpenSSL.Core.Native.ObjectNameHandler(this.OnObjectName), global::System.IntPtr.Zero);
				return;
			}
			global::OpenSSL.Core.Native.OBJ_NAME_do_all(type, new global::OpenSSL.Core.Native.ObjectNameHandler(this.OnObjectName), global::System.IntPtr.Zero);
		}

		// Token: 0x06000393 RID: 915 RVA: 0x0000598C File Offset: 0x00003B8C
		private void OnObjectName(global::System.IntPtr ptr, global::System.IntPtr arg)
		{
			string item = global::OpenSSL.Core.Native.PtrToStringAnsi(((global::OpenSSL.Core.NameCollector.OBJ_NAME)global::System.Runtime.InteropServices.Marshal.PtrToStructure(ptr, typeof(global::OpenSSL.Core.NameCollector.OBJ_NAME))).name, false);
			this.list.Add(item);
		}

		// Token: 0x0400022B RID: 555
		private global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();

		// Token: 0x0200004E RID: 78
		private struct OBJ_NAME
		{
			// Token: 0x0400022C RID: 556
			public int type;

			// Token: 0x0400022D RID: 557
			public int alias;

			// Token: 0x0400022E RID: 558
			public global::System.IntPtr name;

			// Token: 0x0400022F RID: 559
			public global::System.IntPtr data;
		}
	}
}
