using System;
using custom_exception;

namespace ErrorLogging
{
	// Token: 0x02000008 RID: 8
	public class CCustomExceptionHandler
	{
		// Token: 0x0600000C RID: 12 RVA: 0x00002440 File Offset: 0x00001440
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
			return new global::custom_exception.CCustomException(ErrorID, "ErrorLogging", ClassName + ", " + FunctionName, Trace);
		}
	}
}
