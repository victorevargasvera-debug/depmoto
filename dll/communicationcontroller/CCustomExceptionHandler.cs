using System;
using custom_exception;

namespace CommunicationController
{
	// Token: 0x02000013 RID: 19
	[global::System.Serializable]
	public class CCustomExceptionHandler : global::custom_exception.CCustomException
	{
		// Token: 0x0600006D RID: 109 RVA: 0x00002A34 File Offset: 0x00001A34
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
			return new global::custom_exception.CCustomException(errorID, "CommunicationController", className + ", " + functionName, trace);
		}
	}
}
