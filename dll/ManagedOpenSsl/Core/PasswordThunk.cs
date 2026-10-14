using System;
using System.Runtime.InteropServices;
using System.Text;

namespace OpenSSL.Core
{
	// Token: 0x02000053 RID: 83
	internal class PasswordThunk
	{
		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060003A5 RID: 933 RVA: 0x00005B3B File Offset: 0x00003D3B
		public global::OpenSSL.Core.Native.pem_password_cb Callback
		{
			get
			{
				if (this.OnPassword == null)
				{
					return null;
				}
				return new global::OpenSSL.Core.Native.pem_password_cb(this.OnPasswordThunk);
			}
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x00005B53 File Offset: 0x00003D53
		public PasswordThunk(global::OpenSSL.Core.PasswordHandler client, object arg)
		{
			this.OnPassword = client;
			this.arg = arg;
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x00005B6C File Offset: 0x00003D6C
		internal int OnPasswordThunk(global::System.IntPtr buf, int size, int rwflag, global::System.IntPtr userdata)
		{
			int result;
			try
			{
				string s = this.OnPassword(rwflag != 0, this.arg);
				byte[] bytes = global::System.Text.Encoding.ASCII.GetBytes(s);
				int num = bytes.Length;
				if (num > size)
				{
					num = size;
				}
				global::System.Runtime.InteropServices.Marshal.Copy(bytes, 0, buf, num);
				result = num;
			}
			catch (global::System.Exception ex)
			{
				global::System.Console.WriteLine(ex.Message);
				result = -1;
			}
			return result;
		}

		// Token: 0x04000233 RID: 563
		private global::OpenSSL.Core.PasswordHandler OnPassword;

		// Token: 0x04000234 RID: 564
		private object arg;
	}
}
