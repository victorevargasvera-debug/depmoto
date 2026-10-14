using System;
using custom_exception;

namespace RegistryAccess
{
	// Token: 0x0200000F RID: 15
	[global::System.Serializable]
	public class CCustomExceptionHandler : global::custom_exception.CCustomException
	{
		// Token: 0x060000C8 RID: 200 RVA: 0x000097FC File Offset: 0x000087FC
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
			return new global::custom_exception.CCustomException(ErrorID, "RegistryAccess", ClassName + ", " + FunctionName, Trace);
		}
	}
}
