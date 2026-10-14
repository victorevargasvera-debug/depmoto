using System;
using OpenSSL.Core;

namespace OpenSSL
{
	// Token: 0x02000024 RID: 36
	public class SslMethod : global::OpenSSL.Core.Base
	{
		// Token: 0x060000A7 RID: 167 RVA: 0x00003C1D File Offset: 0x00001E1D
		private SslMethod(global::System.IntPtr ptr, bool owner) : base(ptr, owner)
		{
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00003C27 File Offset: 0x00001E27
		protected override void OnDispose()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x040000D8 RID: 216
		public static global::OpenSSL.SslMethod SSLv2_method = new global::OpenSSL.SslMethod(global::OpenSSL.Core.Native.SSLv2_method(), false);

		// Token: 0x040000D9 RID: 217
		public static global::OpenSSL.SslMethod SSLv2_server_method = new global::OpenSSL.SslMethod(global::OpenSSL.Core.Native.SSLv2_server_method(), false);

		// Token: 0x040000DA RID: 218
		public static global::OpenSSL.SslMethod SSLv2_client_method = new global::OpenSSL.SslMethod(global::OpenSSL.Core.Native.SSLv2_client_method(), false);

		// Token: 0x040000DB RID: 219
		public static global::OpenSSL.SslMethod SSLv3_method = new global::OpenSSL.SslMethod(global::OpenSSL.Core.Native.SSLv3_method(), false);

		// Token: 0x040000DC RID: 220
		public static global::OpenSSL.SslMethod SSLv3_server_method = new global::OpenSSL.SslMethod(global::OpenSSL.Core.Native.SSLv3_server_method(), false);

		// Token: 0x040000DD RID: 221
		public static global::OpenSSL.SslMethod SSLv3_client_method = new global::OpenSSL.SslMethod(global::OpenSSL.Core.Native.SSLv3_client_method(), false);

		// Token: 0x040000DE RID: 222
		public static global::OpenSSL.SslMethod SSLv23_method = new global::OpenSSL.SslMethod(global::OpenSSL.Core.Native.SSLv23_method(), false);

		// Token: 0x040000DF RID: 223
		public static global::OpenSSL.SslMethod SSLv23_server_method = new global::OpenSSL.SslMethod(global::OpenSSL.Core.Native.SSLv23_server_method(), false);

		// Token: 0x040000E0 RID: 224
		public static global::OpenSSL.SslMethod SSLv23_client_method = new global::OpenSSL.SslMethod(global::OpenSSL.Core.Native.SSLv23_client_method(), false);

		// Token: 0x040000E1 RID: 225
		public static global::OpenSSL.SslMethod TLSv1_method = new global::OpenSSL.SslMethod(global::OpenSSL.Core.Native.TLSv1_method(), false);

		// Token: 0x040000E2 RID: 226
		public static global::OpenSSL.SslMethod TLSv1_server_method = new global::OpenSSL.SslMethod(global::OpenSSL.Core.Native.TLSv1_server_method(), false);

		// Token: 0x040000E3 RID: 227
		public static global::OpenSSL.SslMethod TLSv1_client_method = new global::OpenSSL.SslMethod(global::OpenSSL.Core.Native.TLSv1_client_method(), false);

		// Token: 0x040000E4 RID: 228
		public static global::OpenSSL.SslMethod DTLSv1_method = new global::OpenSSL.SslMethod(global::OpenSSL.Core.Native.DTLSv1_method(), false);

		// Token: 0x040000E5 RID: 229
		public static global::OpenSSL.SslMethod DTLSv1_server_method = new global::OpenSSL.SslMethod(global::OpenSSL.Core.Native.DTLSv1_server_method(), false);

		// Token: 0x040000E6 RID: 230
		public static global::OpenSSL.SslMethod DTLSv1_client_method = new global::OpenSSL.SslMethod(global::OpenSSL.Core.Native.DTLSv1_client_method(), false);
	}
}
