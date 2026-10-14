using System;
using System.Text;

namespace OpenSSL.Core
{
	// Token: 0x0200004F RID: 79
	public struct OpenSslError
	{
		// Token: 0x06000394 RID: 916 RVA: 0x000059C9 File Offset: 0x00003BC9
		public OpenSslError(uint err)
		{
			this.err = err;
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000395 RID: 917 RVA: 0x000059D2 File Offset: 0x00003BD2
		public uint ErrorCode
		{
			get
			{
				return this.err;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000396 RID: 918 RVA: 0x000059DA File Offset: 0x00003BDA
		public string Library
		{
			get
			{
				return global::OpenSSL.Core.Native.PtrToStringAnsi(global::OpenSSL.Core.Native.ERR_lib_error_string(this.err), false);
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000397 RID: 919 RVA: 0x000059ED File Offset: 0x00003BED
		public string Reason
		{
			get
			{
				return global::OpenSSL.Core.Native.PtrToStringAnsi(global::OpenSSL.Core.Native.ERR_reason_error_string(this.err), false);
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000398 RID: 920 RVA: 0x00005A00 File Offset: 0x00003C00
		public string Function
		{
			get
			{
				return global::OpenSSL.Core.Native.PtrToStringAnsi(global::OpenSSL.Core.Native.ERR_func_error_string(this.err), false);
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000399 RID: 921 RVA: 0x00005A14 File Offset: 0x00003C14
		public string Message
		{
			get
			{
				byte[] array = new byte[1024];
				uint count = global::OpenSSL.Core.Native.ERR_error_string_n(this.err, array, array.Length);
				return global::System.Text.Encoding.ASCII.GetString(array, 0, (int)count);
			}
		}

		// Token: 0x04000230 RID: 560
		private uint err;
	}
}
