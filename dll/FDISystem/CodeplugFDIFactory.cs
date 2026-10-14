using System;
using Motorola.Common.Communication.TetraUtility;

namespace FDISystem
{
	// Token: 0x02000005 RID: 5
	public static class CodeplugFDIFactory
	{
		// Token: 0x060001D0 RID: 464 RVA: 0x00002780 File Offset: 0x00001B80
		public static global::FDISystem.ICodeplugFDIPack CreateCodeplugFDIPack(global::FDISystem.IFDI fdi)
		{
			global::FDISystem.ICodeplugFDIPack result = null;
			try
			{
				global::FDISystem.FDIVersion version = fdi.Version;
				if (version != global::FDISystem.FDIVersion.V2x)
				{
					if (version == global::FDISystem.FDIVersion.V5x)
					{
						result = new global::FDISystem.CodeplugFDIPack<FDISystem::CP_FORMAT_TYPE_V5>((global::FDISystem.FDICore<FDISystem::FDI_TYPE_V5>)fdi);
					}
				}
				else
				{
					result = new global::FDISystem.CodeplugFDIPack<FDISystem::CP_FORMAT_TYPE_V2>((global::FDISystem.FDICore<FDISystem::FDI_TYPE_V2>)fdi);
				}
			}
			catch (global::FDISystem.FDIException ex)
			{
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::FDISystem.FDIException.GetCustomErrorCode(ex.ErrorCode), ex.Message, ex);
			}
			catch (global::System.Exception ex2)
			{
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::FDISystem.FDIException.DotFXExceptionCode, ex2.Message, ex2);
			}
			return result;
		}
	}
}
