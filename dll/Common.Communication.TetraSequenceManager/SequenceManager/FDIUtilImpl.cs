using System;
using System.Collections.Generic;
using System.Globalization;
using FDISystem;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.TetraUtility;

namespace Motorola.Common.Communication.SequenceManager
{
	// Token: 0x02000004 RID: 4
	public static class FDIUtilImpl
	{
		// Token: 0x0600001B RID: 27 RVA: 0x000023AA File Offset: 0x000005AA
		public static int ValidateFreeSpace()
		{
			return -1;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000023B0 File Offset: 0x000005B0
		public static global::Motorola.Common.Communication.CommonUtil.MemoryImage Pack(global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<ushort, byte[]>> fdiBlockList, uint cpRawSize, uint cpStartAddress, uint blockSize, uint blockNumber, global::Motorola.Common.Communication.TetraUtility.FDIVersion fdiVersion, global::Motorola.Common.Communication.TetraUtility.ByteOrder byteOrder)
		{
			global::Motorola.Common.Communication.CommonUtil.MemoryImage memoryImage = null;
			global::FDISystem.ByteOrder byteOrder2 = global::FDISystem.ByteOrder.LittleEndian;
			global::FDISystem.FDIVersion fdiVersion2 = global::FDISystem.FDIVersion.V5x;
			if (byteOrder == global::Motorola.Common.Communication.TetraUtility.ByteOrder.BigEndian)
			{
				byteOrder2 = global::FDISystem.ByteOrder.BigEndian;
			}
			if (fdiVersion == global::Motorola.Common.Communication.TetraUtility.FDIVersion.V2x)
			{
				fdiVersion2 = global::FDISystem.FDIVersion.V2x;
			}
			if (fdiBlockList.Count == 1 && fdiBlockList[0].Key == global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.GEMSTONE_BLOCK_ID)
			{
				global::Motorola.Common.Communication.CommonUtil.FlashMemoryUnit flashMemoryUnit = new global::Motorola.Common.Communication.CommonUtil.FlashMemoryUnit();
				flashMemoryUnit.ChargeUnit(cpStartAddress.ToString(global::System.Globalization.CultureInfo.InvariantCulture), fdiBlockList[0].Value);
				memoryImage = new global::Motorola.Common.Communication.CommonUtil.MemoryImage();
				memoryImage.AddItem(flashMemoryUnit);
			}
			else
			{
				using (global::FDISystem.IFDI ifdi = global::FDISystem.FDIEntity.CreateFDI(blockNumber, blockSize, 32U, byteOrder2, fdiVersion2))
				{
					using (global::FDISystem.ICodeplugFDIPack codeplugFDIPack = global::FDISystem.CodeplugFDIFactory.CreateCodeplugFDIPack(ifdi))
					{
						codeplugFDIPack.WriteCodeplug(fdiBlockList, cpRawSize);
						global::Motorola.Common.Communication.CommonUtil.FlashMemoryUnit flashMemoryUnit2 = new global::Motorola.Common.Communication.CommonUtil.FlashMemoryUnit();
						flashMemoryUnit2.ChargeUnit(cpStartAddress.ToString(global::System.Globalization.CultureInfo.InvariantCulture), ifdi.FDIRawStream);
						memoryImage = new global::Motorola.Common.Communication.CommonUtil.MemoryImage();
						memoryImage.AddItem(flashMemoryUnit2);
					}
				}
			}
			return memoryImage;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000024B0 File Offset: 0x000006B0
		public static global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<ushort, byte[]>> Unpack(global::Motorola.Common.Communication.CommonUtil.MemoryImage image, global::Motorola.Common.Communication.TetraUtility.FDIVersion fdiVersion, global::Motorola.Common.Communication.TetraUtility.ByteOrder byteOrder)
		{
			global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<ushort, byte[]>> result = null;
			global::FDISystem.ByteOrder byteOrder2 = global::FDISystem.ByteOrder.LittleEndian;
			global::FDISystem.FDIVersion version = global::FDISystem.FDIVersion.V5x;
			if (byteOrder == global::Motorola.Common.Communication.TetraUtility.ByteOrder.BigEndian)
			{
				byteOrder2 = global::FDISystem.ByteOrder.BigEndian;
			}
			if (fdiVersion == global::Motorola.Common.Communication.TetraUtility.FDIVersion.V2x)
			{
				version = global::FDISystem.FDIVersion.V2x;
			}
			using (global::FDISystem.IFDI ifdi = global::FDISystem.FDIEntity.CreateFDI(image[0].Data, version, byteOrder2))
			{
				using (global::FDISystem.ICodeplugFDIPack codeplugFDIPack = global::FDISystem.CodeplugFDIFactory.CreateCodeplugFDIPack(ifdi))
				{
					result = codeplugFDIPack.GetCodeplugBlockDataSet();
				}
			}
			return result;
		}
	}
}
