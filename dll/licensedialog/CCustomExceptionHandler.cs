using System;
using custom_exception;

namespace licensing
{
	// Token: 0x02000004 RID: 4
	public class CCustomExceptionHandler
	{
		// Token: 0x06000008 RID: 8 RVA: 0x000021BC File Offset: 0x000011BC
		public static global::custom_exception.CCustomException CreateException(uint errorID, string className, string functionName, string trace)
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
			return new global::custom_exception.CCustomException(errorID, "Licensing", className + ", " + functionName, trace);
		}

		// Token: 0x04000003 RID: 3
		private const string a = "Licensing";

		// Token: 0x04000004 RID: 4
		private const string b = ", ";
	}
}
