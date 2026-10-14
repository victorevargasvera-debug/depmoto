using System;
using custom_exception;

namespace LdapAuthenticationInterfaceController
{
	// Token: 0x02000008 RID: 8
	public class CCustomExceptionHandler : global::custom_exception.CCustomException
	{
		// Token: 0x0600001C RID: 28 RVA: 0x000026B0 File Offset: 0x000016B0
		public static global::custom_exception.CCustomException CreateException(uint ErrorID, string ClassName, string FunctionName, string Trace)
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
			return new global::custom_exception.CCustomException(ErrorID, "LdapAuthenticationInterfaceController", ClassName + ", " + FunctionName, Trace);
		}
	}
}
