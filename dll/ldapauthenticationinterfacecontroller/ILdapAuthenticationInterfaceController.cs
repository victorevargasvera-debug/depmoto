using System;

namespace LdapAuthenticationInterfaceController
{
	// Token: 0x02000005 RID: 5
	public interface ILdapAuthenticationInterfaceController
	{
		// Token: 0x06000008 RID: 8
		void Open();

		// Token: 0x06000009 RID: 9
		void Close();

		// Token: 0x0600000A RID: 10
		void VerifyUserLogin(string strUserName, string strPassword);

		// Token: 0x0600000B RID: 11
		void IsUserConnected();

		// Token: 0x0600000C RID: 12
		void IsMotorolaUser();

		// Token: 0x0600000D RID: 13
		bool IsOpen();
	}
}
