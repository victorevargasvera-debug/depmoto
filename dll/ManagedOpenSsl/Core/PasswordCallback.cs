using System;

namespace OpenSSL.Core
{
	// Token: 0x02000052 RID: 82
	public class PasswordCallback
	{
		// Token: 0x060003A3 RID: 931 RVA: 0x00005B24 File Offset: 0x00003D24
		public PasswordCallback(string password)
		{
			this.password = password;
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x00005B33 File Offset: 0x00003D33
		public string OnPassword(bool verify, object userdata)
		{
			return this.password;
		}

		// Token: 0x04000232 RID: 562
		private string password;
	}
}
