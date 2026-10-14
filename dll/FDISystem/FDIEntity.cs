using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Motorola.Common.Communication.TetraUtility;

namespace FDISystem
{
	// Token: 0x0200000A RID: 10
	public static class FDIEntity
	{
		// Token: 0x0600025D RID: 605 RVA: 0x0000B90C File Offset: 0x0000AD0C
		public static global::FDISystem.IFDI CreateFDI(byte[] fdiStream, global::FDISystem.FDIVersion version, global::FDISystem.ByteOrder byteOrder)
		{
			global::FDISystem.IFDI result;
			try
			{
				if (version != global::FDISystem.FDIVersion.V2x)
				{
					if (version != global::FDISystem.FDIVersion.V5x)
					{
						result = null;
					}
					else
					{
						result = new global::FDISystem.FDICore<FDISystem::FDI_TYPE_V5>(fdiStream, byteOrder);
					}
				}
				else
				{
					result = new global::FDISystem.FDICore<FDISystem::FDI_TYPE_V2>(fdiStream, byteOrder);
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

		// Token: 0x0600025E RID: 606 RVA: 0x00008C88 File Offset: 0x00008088
		public static global::FDISystem.IFDI CreateFDI(uint nBlock, uint blockSize, uint granularity, global::FDISystem.ByteOrder byteOrder, global::FDISystem.FDIVersion fdiVersion)
		{
			global::FDISystem.IFDI result;
			try
			{
				global::FDISystem.IFDI ifdi = null;
				if (fdiVersion != global::FDISystem.FDIVersion.V2x)
				{
					if (fdiVersion == global::FDISystem.FDIVersion.V5x)
					{
						ifdi = new global::FDISystem.FDICore<FDISystem::FDI_TYPE_V5>(nBlock, blockSize, granularity, byteOrder);
					}
				}
				else
				{
					ifdi = new global::FDISystem.FDICore<FDISystem::FDI_TYPE_V2>(nBlock, blockSize, granularity, byteOrder);
				}
				result = ifdi;
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

		// Token: 0x0600025F RID: 607 RVA: 0x00008B40 File Offset: 0x00007F40
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
		public static bool IsFDIDataBlock(byte[] blockHeaderBuffer, global::FDISystem.FDIVersion version, global::FDISystem.ByteOrder byteOrder)
		{
			byte result2;
			try
			{
				byte condition = (blockHeaderBuffer.Length == (int)global::FDISystem.FDIEntity.GetMaxFDIBlockHeaderSize()) ? 1 : 0;
				global::System.Diagnostics.Debug.Assert(condition != 0);
				if (version != global::FDISystem.FDIVersion.V2x)
				{
					if (version != global::FDISystem.FDIVersion.V5x)
					{
						return false;
					}
				}
				ref byte blockHeaderBuffer2 = ref blockHeaderBuffer[blockHeaderBuffer.Length - 16];
				try
				{
					if (version == global::FDISystem.FDIVersion.V2x)
					{
						goto IL_72;
					}
					if (version == global::FDISystem.FDIVersion.V5x)
					{
						goto IL_5A;
					}
				}
				catch
				{
					blockHeaderBuffer2 = 0;
					throw;
				}
				blockHeaderBuffer2 = 0;
				return false;
				IL_5A:
				bool result;
				try
				{
					result = global::FDISystem.FDICore<FDISystem::FDI_TYPE_V5>.IsDataBlock(ref blockHeaderBuffer2, 16U, byteOrder);
				}
				catch
				{
					blockHeaderBuffer2 = 0;
					throw;
				}
				blockHeaderBuffer2 = 0;
				return result;
				IL_72:
				bool flag;
				try
				{
					flag = global::FDISystem.FDICore<FDISystem::FDI_TYPE_V2>.IsDataBlock(ref blockHeaderBuffer2, 16U, byteOrder);
				}
				catch
				{
					blockHeaderBuffer2 = 0;
					throw;
				}
				blockHeaderBuffer2 = 0;
				result2 = (flag ? 1 : 0);
			}
			catch (global::FDISystem.FDIException ex)
			{
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::FDISystem.FDIException.GetCustomErrorCode(ex.ErrorCode), ex.Message, ex);
			}
			catch (global::System.Exception ex2)
			{
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::FDISystem.FDIException.DotFXExceptionCode, ex2.Message, ex2);
			}
			return result2 != 0;
		}

		// Token: 0x06000260 RID: 608 RVA: 0x0000298C File Offset: 0x00001D8C
		public static uint GetMaxFDIBlockHeaderSize()
		{
			return global::System.Math.Max(16U, 16U);
		}
	}
}
