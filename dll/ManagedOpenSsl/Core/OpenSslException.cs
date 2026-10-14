using System;
using System.Collections.Generic;
using System.Text;

namespace OpenSSL.Core
{
	// Token: 0x02000050 RID: 80
	public class OpenSslException : global::System.Exception
	{
		// Token: 0x0600039A RID: 922 RVA: 0x00005A49 File Offset: 0x00003C49
		private OpenSslException(global::System.Collections.Generic.List<global::OpenSSL.Core.OpenSslError> context) : base(global::OpenSSL.Core.OpenSslException.GetErrorMessage(context))
		{
			this.errors = context;
		}

		// Token: 0x0600039B RID: 923 RVA: 0x00005A69 File Offset: 0x00003C69
		public OpenSslException() : this(global::OpenSSL.Core.OpenSslException.GetCurrentContext())
		{
		}

		// Token: 0x0600039C RID: 924 RVA: 0x00005A78 File Offset: 0x00003C78
		private static global::System.Collections.Generic.List<global::OpenSSL.Core.OpenSslError> GetCurrentContext()
		{
			global::System.Collections.Generic.List<global::OpenSSL.Core.OpenSslError> list = new global::System.Collections.Generic.List<global::OpenSSL.Core.OpenSslError>();
			for (;;)
			{
				uint num = global::OpenSSL.Core.Native.ERR_get_error();
				if (num == 0U)
				{
					break;
				}
				list.Add(new global::OpenSSL.Core.OpenSslError(num));
			}
			return list;
		}

		// Token: 0x0600039D RID: 925 RVA: 0x00005AA4 File Offset: 0x00003CA4
		private static string GetErrorMessage(global::System.Collections.Generic.List<global::OpenSSL.Core.OpenSslError> context)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			bool flag = true;
			foreach (global::OpenSSL.Core.OpenSslError openSslError in context)
			{
				if (flag)
				{
					flag = false;
				}
				else
				{
					stringBuilder.Append("\n");
				}
				stringBuilder.Append(openSslError.Message);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x0600039E RID: 926 RVA: 0x00005B1C File Offset: 0x00003D1C
		public global::System.Collections.Generic.List<global::OpenSSL.Core.OpenSslError> Errors
		{
			get
			{
				return this.errors;
			}
		}

		// Token: 0x04000231 RID: 561
		private global::System.Collections.Generic.List<global::OpenSSL.Core.OpenSslError> errors = new global::System.Collections.Generic.List<global::OpenSSL.Core.OpenSslError>();
	}
}
