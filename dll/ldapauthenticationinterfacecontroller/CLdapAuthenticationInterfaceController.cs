using System;
using custom_exception;

namespace LdapAuthenticationInterfaceController
{
	// Token: 0x02000006 RID: 6
	public class CLdapAuthenticationInterfaceController : global::LdapAuthenticationInterfaceController.ILdapAuthenticationInterfaceController
	{
		// Token: 0x0600000E RID: 14 RVA: 0x000021BC File Offset: 0x000011BC
		public CLdapAuthenticationInterfaceController()
		{
			this.a = false;
			this.b = 0U;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000021E0 File Offset: 0x000011E0
		public bool IsOpen()
		{
			switch (1 == 1)
			{
			}
			if (true)
			{
			}
			if (false)
			{
			}
			return this.a;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002224 File Offset: 0x00001224
		public void Open()
		{
			int num = 0;
			uint num2;
			for (;;)
			{
				switch (num)
				{
				case 1:
					goto IL_AE;
				case 2:
					if (num2 != 0U)
					{
						num = 1;
						continue;
					}
					goto IL_B1;
				case 3:
					goto IL_38;
				}
				if (this.a)
				{
					if (true)
					{
					}
					num = 3;
				}
				else
				{
					num2 = global::LdapAuthenticationInterfaceController.a.a(out this.b);
					num = 2;
				}
			}
			IL_38:
			switch ((1 == 1) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_60:
				global::custom_exception.CCustomException ex = global::LdapAuthenticationInterfaceController.CCustomExceptionHandler.CreateException(num2 & 65535U, base.GetType().ToString(), "Open", global::System.Environment.StackTrace.ToString());
				throw ex;
			}
			default:
				if (false)
				{
				}
				return;
			}
			IL_AE:
			goto IL_60;
			IL_B1:
			this.a = true;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000022EC File Offset: 0x000012EC
		public void Close()
		{
			int num = 0;
			uint num2;
			for (;;)
			{
				switch (num)
				{
				case 1:
					if (num2 != 0U)
					{
						if (true)
						{
						}
						num = 2;
						continue;
					}
					return;
				case 2:
					goto IL_B5;
				case 3:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_81;
					default:
						goto IL_46;
					}
					break;
				}
				if (!this.a)
				{
					num = 3;
					continue;
				}
				IL_81:
				num2 = global::LdapAuthenticationInterfaceController.a.a(this.b);
				this.a = false;
				num = 1;
			}
			IL_46:
			if (false)
			{
			}
			global::custom_exception.CCustomException ex = global::LdapAuthenticationInterfaceController.CCustomExceptionHandler.CreateException(1361U, base.GetType().ToString(), "Close", global::System.Environment.StackTrace.ToString());
			throw ex;
			IL_B5:
			global::custom_exception.CCustomException ex2 = global::LdapAuthenticationInterfaceController.CCustomExceptionHandler.CreateException(num2 & 65535U, base.GetType().ToString(), "Close", global::System.Environment.StackTrace.ToString());
			throw ex2;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000023D8 File Offset: 0x000013D8
		public void IsUserConnected()
		{
			int num = 2;
			uint num2;
			for (;;)
			{
				switch (num)
				{
				case 0:
					goto IL_30;
				case 1:
					if (num2 != 0U)
					{
						num = 3;
						continue;
					}
					return;
				case 3:
					goto IL_A9;
				}
				if (this.a)
				{
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						if (false)
						{
						}
						num2 = global::LdapAuthenticationInterfaceController.a.IsUserConnected(this.b);
						num = 1;
						continue;
					}
				}
				num = 0;
			}
			IL_30:
			global::custom_exception.CCustomException ex = global::LdapAuthenticationInterfaceController.CCustomExceptionHandler.CreateException(1361U, base.GetType().ToString(), "IsUserConnected", global::System.Environment.StackTrace.ToString());
			throw ex;
			IL_A9:
			if (true)
			{
			}
			global::custom_exception.CCustomException ex2 = global::LdapAuthenticationInterfaceController.CCustomExceptionHandler.CreateException(num2 & 65535U, base.GetType().ToString(), "IsUserConnected", global::System.Environment.StackTrace.ToString());
			throw ex2;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000024C0 File Offset: 0x000014C0
		public void VerifyUserLogin(string strUserName, string strPassword)
		{
			int num = 0;
			uint num2;
			for (;;)
			{
				switch (num)
				{
				case 1:
					goto IL_4C;
				case 2:
					if (num2 != 0U)
					{
						num = 3;
						continue;
					}
					return;
				case 3:
					goto IL_B0;
				}
				if (!this.a)
				{
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_B2;
					default:
						if (false)
						{
						}
						num = 1;
						break;
					}
				}
				else
				{
					num2 = global::LdapAuthenticationInterfaceController.a.VerifyUserLogin(this.b, strUserName, strPassword);
					if (true)
					{
					}
					num = 2;
				}
			}
			IL_4C:
			goto IL_B2;
			IL_B0:
			global::custom_exception.CCustomException ex = global::LdapAuthenticationInterfaceController.CCustomExceptionHandler.CreateException(num2 & 65535U, base.GetType().ToString(), "VerifyUserLogin", global::System.Environment.StackTrace.ToString());
			throw ex;
			IL_B2:
			global::custom_exception.CCustomException ex2 = global::LdapAuthenticationInterfaceController.CCustomExceptionHandler.CreateException(1361U, base.GetType().ToString(), "VerifyUserLogin", global::System.Environment.StackTrace.ToString());
			throw ex2;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000025A8 File Offset: 0x000015A8
		public void IsMotorolaUser()
		{
			int num = 3;
			uint num2;
			for (;;)
			{
				switch (num)
				{
				case 0:
					goto IL_8C;
				case 1:
					goto IL_42;
				case 2:
					if (num2 != 0U)
					{
						num = 0;
						continue;
					}
					goto IL_B5;
				}
				if (!this.a)
				{
					if (true)
					{
					}
					num = 1;
				}
				else
				{
					num2 = global::LdapAuthenticationInterfaceController.a.IsMotorolaUser(this.b);
					num = 2;
				}
			}
			IL_42:
			goto IL_8E;
			IL_8C:
			global::custom_exception.CCustomException ex = global::LdapAuthenticationInterfaceController.CCustomExceptionHandler.CreateException(num2 & 65535U, base.GetType().ToString(), "IsMotorolaUser", global::System.Environment.StackTrace.ToString());
			throw ex;
			IL_8E:
			global::custom_exception.CCustomException ex2 = global::LdapAuthenticationInterfaceController.CCustomExceptionHandler.CreateException(1361U, base.GetType().ToString(), "IsMotorolaUser", global::System.Environment.StackTrace.ToString());
			throw ex2;
			IL_B5:
			switch ((1 == 1) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_8E;
			default:
				if (false)
				{
				}
				return;
			}
		}

		// Token: 0x04000006 RID: 6
		private bool a;

		// Token: 0x04000007 RID: 7
		private uint b;
	}
}
