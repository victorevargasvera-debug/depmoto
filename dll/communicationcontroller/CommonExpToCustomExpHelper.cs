using System;
using System.ServiceModel;
using custom_exception;
using Motorola.Common.CustomException;

namespace CommunicationController
{
	// Token: 0x02000006 RID: 6
	public class CommonExpToCustomExpHelper
	{
		// Token: 0x0600000F RID: 15 RVA: 0x00002444 File Offset: 0x00001444
		public static void ConvertCommonExceptionAndThrow(global::System.Exception ex)
		{
			int num = 9;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num = 11;
					continue;
				case 1:
					goto IL_C3;
				case 2:
					goto IL_1DB;
				case 3:
					while (!(ex is global::System.ServiceModel.CommunicationException))
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
							num = 8;
							goto IL_0A;
						}
					}
					if (true)
					{
					}
					num = 0;
					continue;
				case 4:
					goto IL_105;
				case 5:
					goto IL_50;
				case 6:
					goto IL_1B5;
				case 7:
					if (ex is global::Motorola.Common.CustomException.CommonException)
					{
						num = 1;
						continue;
					}
					num = 10;
					continue;
				case 8:
					if (ex is global::System.TimeoutException)
					{
						num = 4;
						continue;
					}
					return;
				case 10:
					if (ex is global::System.ServiceModel.FaultException<global::Motorola.Common.CustomException.CommonExceptionData>)
					{
						num = 2;
						continue;
					}
					num = 3;
					continue;
				case 11:
					if (ex is global::System.ServiceModel.EndpointNotFoundException)
					{
						num = 6;
						continue;
					}
					goto IL_109;
				}
				if (ex is global::custom_exception.CCustomException)
				{
					num = 5;
				}
				else
				{
					num = 7;
				}
			}
			IL_50:
			throw ex;
			IL_C3:
			throw global::CommunicationController.CCustomExceptionHandler.CreateException((uint)(8192 + (ex as global::Motorola.Common.CustomException.CommonException).ErrorCode), string.Empty, string.Empty, ex.StackTrace);
			IL_105:
			throw global::CommunicationController.CCustomExceptionHandler.CreateException(8243U, string.Empty, string.Empty, ex.StackTrace);
			IL_109:
			throw global::CommunicationController.CCustomExceptionHandler.CreateException(8244U, string.Empty, string.Empty, ex.StackTrace);
			IL_1B5:
			throw global::CommunicationController.CCustomExceptionHandler.CreateException(8242U, string.Empty, string.Empty, ex.StackTrace);
			IL_1DB:
			global::System.ServiceModel.FaultException<global::Motorola.Common.CustomException.CommonExceptionData> faultException = ex as global::System.ServiceModel.FaultException<global::Motorola.Common.CustomException.CommonExceptionData>;
			throw global::CommunicationController.CCustomExceptionHandler.CreateException((uint)(8192 + faultException.Detail.ErrorCode), string.Empty, string.Empty, ex.StackTrace);
		}
	}
}
