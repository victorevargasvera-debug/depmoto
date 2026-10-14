using System;
using custom_exception;

namespace Controller
{
	// Token: 0x0200000C RID: 12
	public class CCustomExceptionHandler : global::custom_exception.CCustomException
	{
		// Token: 0x06000117 RID: 279 RVA: 0x000153D8 File Offset: 0x000143D8
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
			return new global::custom_exception.CCustomException(ErrorID, "CoreController", ClassName + ", " + FunctionName, Trace);
		}
	}
}
