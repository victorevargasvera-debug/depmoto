using System;
using custom_exception;

namespace UpdateController
{
	// Token: 0x02000016 RID: 22
	[global::System.Serializable]
	public class CCustomExceptionHandler : global::custom_exception.CCustomException
	{
		// Token: 0x060000A0 RID: 160 RVA: 0x0001A810 File Offset: 0x00019810
		public static global::custom_exception.CCustomException a(uint A_0, string A_1, string A_2, string A_3)
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
			return new global::custom_exception.CCustomException(A_0, "CommunicationController", A_1 + ", " + A_2, A_3);
		}
	}
}
