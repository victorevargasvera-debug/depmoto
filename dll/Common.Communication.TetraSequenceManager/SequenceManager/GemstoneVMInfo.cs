using System;
using System.Collections.Generic;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.TetraUtility;

namespace Motorola.Common.Communication.SequenceManager
{
	// Token: 0x0200000D RID: 13
	public static class GemstoneVMInfo
	{
		// Token: 0x06000063 RID: 99 RVA: 0x000037A4 File Offset: 0x000019A4
		public static uint GetReleaseInfoSize(string commonModelNum, string cpVer)
		{
			global::Motorola.Common.Communication.TetraUtility.ReleaseIDType releaseIDType = global::Motorola.Common.Communication.TetraUtility.ReleaseIDType.ReleaseIDNone;
			try
			{
				releaseIDType = global::Motorola.Common.Communication.TetraUtility.TetraUtil.GetReleaseIDType(cpVer, commonModelNum);
			}
			catch
			{
				releaseIDType = global::Motorola.Common.Communication.TetraUtility.ReleaseIDType.ReleaseIDWithFP;
			}
			uint result = 0U;
			if (releaseIDType == global::Motorola.Common.Communication.TetraUtility.ReleaseIDType.ReleaseIDWithFP || releaseIDType == global::Motorola.Common.Communication.TetraUtility.ReleaseIDType.ReleaseIDExtension)
			{
				result = global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.RELEASE_ID_SIZE_WITH_FP;
			}
			else if (releaseIDType == global::Motorola.Common.Communication.TetraUtility.ReleaseIDType.ReleaseIDWithoutFP)
			{
				result = global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.RELEASE_ID_SIZE_WITHOUT_FP;
			}
			return result;
		}

		// Token: 0x06000064 RID: 100 RVA: 0x000037F0 File Offset: 0x000019F0
		public static bool AddressInGemstoneFlashRegion(uint flashAddress)
		{
			foreach (global::Motorola.Common.Communication.SequenceManager.GemstoneFlashRegion gemstoneFlashRegion in global::Motorola.Common.Communication.SequenceManager.GemstoneVMInfo._flashRegions)
			{
				if (flashAddress >= gemstoneFlashRegion.startAddr && flashAddress <= gemstoneFlashRegion.endAddr)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000065 RID: 101 RVA: 0x0000383C File Offset: 0x00001A3C
		public static uint GetRegionStartAddress(uint flashAddress)
		{
			foreach (global::Motorola.Common.Communication.SequenceManager.GemstoneFlashRegion gemstoneFlashRegion in global::Motorola.Common.Communication.SequenceManager.GemstoneVMInfo._flashRegions)
			{
				if (flashAddress >= gemstoneFlashRegion.startAddr && flashAddress <= gemstoneFlashRegion.endAddr)
				{
					uint result;
					if (gemstoneFlashRegion.type == global::Motorola.Common.Communication.CommonUtil.GemstoneFlashType.FLASHPACK_SLOTS)
					{
						uint num = (flashAddress - gemstoneFlashRegion.startAddr) / global::Motorola.Common.Communication.SequenceManager.GemstoneVMInfo.GEMSTONE_FLASHPACK_SLOT_SIZE;
						uint num2 = gemstoneFlashRegion.startAddr + global::Motorola.Common.Communication.SequenceManager.GemstoneVMInfo.GEMSTONE_FLASHPACK_SLOT_SIZE * num;
						result = num2;
					}
					else
					{
						result = gemstoneFlashRegion.startAddr;
					}
					return result;
				}
			}
			return flashAddress & 4278190080U;
		}

		// Token: 0x06000066 RID: 102 RVA: 0x000038C8 File Offset: 0x00001AC8
		public static bool GetGemstoneFlashRegionInfo(uint flashAddress, out uint regionStart, out global::Motorola.Common.Communication.CommonUtil.GemstoneFlashType type)
		{
			regionStart = 0U;
			type = global::Motorola.Common.Communication.CommonUtil.GemstoneFlashType.UNKNOWN;
			foreach (global::Motorola.Common.Communication.SequenceManager.GemstoneFlashRegion gemstoneFlashRegion in global::Motorola.Common.Communication.SequenceManager.GemstoneVMInfo._flashRegions)
			{
				if (flashAddress >= gemstoneFlashRegion.startAddr && flashAddress <= gemstoneFlashRegion.endAddr)
				{
					type = gemstoneFlashRegion.type;
					if (type == global::Motorola.Common.Communication.CommonUtil.GemstoneFlashType.FLASHPACK_SLOTS)
					{
						uint num = (flashAddress - gemstoneFlashRegion.startAddr) / global::Motorola.Common.Communication.SequenceManager.GemstoneVMInfo.GEMSTONE_FLASHPACK_SLOT_SIZE;
						uint num2 = gemstoneFlashRegion.startAddr + global::Motorola.Common.Communication.SequenceManager.GemstoneVMInfo.GEMSTONE_FLASHPACK_SLOT_SIZE * num;
						regionStart = num2;
					}
					else
					{
						regionStart = gemstoneFlashRegion.startAddr;
					}
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00003960 File Offset: 0x00001B60
		public static bool GetRegionStartEndAddByType(global::Motorola.Common.Communication.CommonUtil.GemstoneFlashType type, out uint regionStart, out uint regionEnd)
		{
			bool result = false;
			regionStart = (regionEnd = 0U);
			foreach (global::Motorola.Common.Communication.SequenceManager.GemstoneFlashRegion gemstoneFlashRegion in global::Motorola.Common.Communication.SequenceManager.GemstoneVMInfo._flashRegions)
			{
				if (gemstoneFlashRegion.type == type)
				{
					regionStart = gemstoneFlashRegion.startAddr;
					regionEnd = gemstoneFlashRegion.endAddr;
					result = true;
					break;
				}
			}
			return result;
		}

		// Token: 0x06000068 RID: 104 RVA: 0x000039C0 File Offset: 0x00001BC0
		public static bool JumpToNextRegionStart(uint currentAdd, out uint nextStartAdd)
		{
			int i = 0;
			while (i < global::Motorola.Common.Communication.SequenceManager.GemstoneVMInfo._flashRegions.Length)
			{
				global::Motorola.Common.Communication.SequenceManager.GemstoneFlashRegion gemstoneFlashRegion = global::Motorola.Common.Communication.SequenceManager.GemstoneVMInfo._flashRegions[i];
				if (currentAdd >= gemstoneFlashRegion.startAddr && currentAdd <= gemstoneFlashRegion.endAddr)
				{
					if (gemstoneFlashRegion.type != global::Motorola.Common.Communication.CommonUtil.GemstoneFlashType.FLASHPACK_SLOTS)
					{
						nextStartAdd = global::Motorola.Common.Communication.SequenceManager.GemstoneVMInfo._flashRegions[i + 1].startAddr;
						return true;
					}
					uint num = (currentAdd - gemstoneFlashRegion.startAddr) / global::Motorola.Common.Communication.SequenceManager.GemstoneVMInfo.GEMSTONE_FLASHPACK_SLOT_SIZE;
					if (num + 1U == global::Motorola.Common.Communication.SequenceManager.GemstoneVMInfo.GEMSTONE_FLASHPACK_SLOT_NUM)
					{
						nextStartAdd = uint.MaxValue;
						return false;
					}
					uint num2 = gemstoneFlashRegion.startAddr + global::Motorola.Common.Communication.SequenceManager.GemstoneVMInfo.GEMSTONE_FLASHPACK_SLOT_SIZE * num;
					nextStartAdd = num2 + global::Motorola.Common.Communication.SequenceManager.GemstoneVMInfo.GEMSTONE_FLASHPACK_SLOT_SIZE;
					return true;
				}
				else
				{
					i++;
				}
			}
			nextStartAdd = uint.MaxValue;
			return false;
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00003A6C File Offset: 0x00001C6C
		public static bool GetFlashpackSlotsInAddress(uint startAddr, uint endAddr, global::System.Collections.Generic.List<uint> slotsAddr)
		{
			if (endAddr < startAddr)
			{
				return false;
			}
			foreach (global::Motorola.Common.Communication.SequenceManager.GemstoneFlashRegion gemstoneFlashRegion in global::Motorola.Common.Communication.SequenceManager.GemstoneVMInfo._flashRegions)
			{
				if (gemstoneFlashRegion.type == global::Motorola.Common.Communication.CommonUtil.GemstoneFlashType.FLASHPACK_SLOTS)
				{
					bool result;
					if (startAddr < gemstoneFlashRegion.startAddr || startAddr > gemstoneFlashRegion.endAddr)
					{
						result = false;
					}
					else if (endAddr < gemstoneFlashRegion.startAddr || endAddr > gemstoneFlashRegion.endAddr)
					{
						result = false;
					}
					else
					{
						uint num = (startAddr - gemstoneFlashRegion.startAddr) / global::Motorola.Common.Communication.SequenceManager.GemstoneVMInfo.GEMSTONE_FLASHPACK_SLOT_SIZE;
						uint num2 = (endAddr - gemstoneFlashRegion.startAddr) / global::Motorola.Common.Communication.SequenceManager.GemstoneVMInfo.GEMSTONE_FLASHPACK_SLOT_SIZE;
						for (uint num3 = num; num3 <= num2; num3 += 1U)
						{
							uint item = gemstoneFlashRegion.startAddr + num3 * global::Motorola.Common.Communication.SequenceManager.GemstoneVMInfo.GEMSTONE_FLASHPACK_SLOT_SIZE;
							slotsAddr.Add(item);
						}
						result = true;
					}
					return result;
				}
			}
			return false;
		}

		// Token: 0x04000042 RID: 66
		private static uint GEMSTONE_FLASHPACK_SLOT_SIZE = 8388608U;

		// Token: 0x04000043 RID: 67
		private static uint GEMSTONE_FLASHPACK_SLOT_NUM = 128U;

		// Token: 0x04000044 RID: 68
		public static readonly uint GEMSTONE_BOOT2_REGION_SIZE = 131072U;

		// Token: 0x04000045 RID: 69
		public static readonly uint GEMSTONE_FLASHPACK_REGION_START = 536870912U;

		// Token: 0x04000046 RID: 70
		public static readonly uint GEMSTONE_FLASHPACK_REGION_END = 1610612735U;

		// Token: 0x04000047 RID: 71
		private static global::Motorola.Common.Communication.SequenceManager.GemstoneFlashRegion[] _flashRegions = new global::Motorola.Common.Communication.SequenceManager.GemstoneFlashRegion[]
		{
			new global::Motorola.Common.Communication.SequenceManager.GemstoneFlashRegion(global::Motorola.Common.Communication.CommonUtil.GemstoneFlashType.BOOT2, 16777216U, 33554431U),
			new global::Motorola.Common.Communication.SequenceManager.GemstoneFlashRegion(global::Motorola.Common.Communication.CommonUtil.GemstoneFlashType.RELINF, 50331648U, 67108863U),
			new global::Motorola.Common.Communication.SequenceManager.GemstoneFlashRegion(global::Motorola.Common.Communication.CommonUtil.GemstoneFlashType.BOOT3_1, 67108864U, 75497471U),
			new global::Motorola.Common.Communication.SequenceManager.GemstoneFlashRegion(global::Motorola.Common.Communication.CommonUtil.GemstoneFlashType.BOOT3_2, 75497472U, 83886079U),
			new global::Motorola.Common.Communication.SequenceManager.GemstoneFlashRegion(global::Motorola.Common.Communication.CommonUtil.GemstoneFlashType.SYS_TONES, 83886080U, 100663295U),
			new global::Motorola.Common.Communication.SequenceManager.GemstoneFlashRegion(global::Motorola.Common.Communication.CommonUtil.GemstoneFlashType.RING_TONES, 100663296U, 117440511U),
			new global::Motorola.Common.Communication.SequenceManager.GemstoneFlashRegion(global::Motorola.Common.Communication.CommonUtil.GemstoneFlashType.OTP, 117440512U, 134217727U),
			new global::Motorola.Common.Communication.SequenceManager.GemstoneFlashRegion(global::Motorola.Common.Communication.CommonUtil.GemstoneFlashType.MS_LOGGING_1, 134217728U, 150994943U),
			new global::Motorola.Common.Communication.SequenceManager.GemstoneFlashRegion(global::Motorola.Common.Communication.CommonUtil.GemstoneFlashType.MS_LOGGING_2, 150994944U, 167772159U),
			new global::Motorola.Common.Communication.SequenceManager.GemstoneFlashRegion(global::Motorola.Common.Communication.CommonUtil.GemstoneFlashType.LINUX_KERNEL, 268435456U, 285212671U),
			new global::Motorola.Common.Communication.SequenceManager.GemstoneFlashRegion(global::Motorola.Common.Communication.CommonUtil.GemstoneFlashType.DSP_APP, 285212672U, 301989887U),
			new global::Motorola.Common.Communication.SequenceManager.GemstoneFlashRegion(global::Motorola.Common.Communication.CommonUtil.GemstoneFlashType.LINUX_FS, 301989888U, 318767103U),
			new global::Motorola.Common.Communication.SequenceManager.GemstoneFlashRegion(global::Motorola.Common.Communication.CommonUtil.GemstoneFlashType.ARM_APP, 318767104U, 335544319U),
			new global::Motorola.Common.Communication.SequenceManager.GemstoneFlashRegion(global::Motorola.Common.Communication.CommonUtil.GemstoneFlashType.CODEPLUG, 335544320U, 352321535U),
			new global::Motorola.Common.Communication.SequenceManager.GemstoneFlashRegion(global::Motorola.Common.Communication.CommonUtil.GemstoneFlashType.MACE, 352321536U, 369098751U),
			new global::Motorola.Common.Communication.SequenceManager.GemstoneFlashRegion(global::Motorola.Common.Communication.CommonUtil.GemstoneFlashType.UPSTART_KERNEL1, 369098752U, 377487359U),
			new global::Motorola.Common.Communication.SequenceManager.GemstoneFlashRegion(global::Motorola.Common.Communication.CommonUtil.GemstoneFlashType.UPSTART_KERNEL2, 377487360U, 385875967U),
			new global::Motorola.Common.Communication.SequenceManager.GemstoneFlashRegion(global::Motorola.Common.Communication.CommonUtil.GemstoneFlashType.RESET_LOG, 385875968U, 394264575U),
			new global::Motorola.Common.Communication.SequenceManager.GemstoneFlashRegion(global::Motorola.Common.Communication.CommonUtil.GemstoneFlashType.FLASHPACK_SLOTS, 536870912U, 1610612735U)
		};
	}
}
