using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Pba;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.CommonFile
{
	// Token: 0x0200000D RID: 13
	[global::System.Serializable]
	public class PartitionCommonFile
	{
		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600001F RID: 31 RVA: 0x00002B9A File Offset: 0x00000D9A
		// (set) Token: 0x06000020 RID: 32 RVA: 0x00002BA2 File Offset: 0x00000DA2
		private byte[] FileData { get; set; }

		// Token: 0x06000021 RID: 33 RVA: 0x00002BAB File Offset: 0x00000DAB
		public PartitionCommonFile(bool isCrcBigEndian)
		{
			this.FileData = null;
			this.IsCrcBigEndian = isCrcBigEndian;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002BC4 File Offset: 0x00000DC4
		public byte[] Serialize(global::Motorola.Common.Communication.CommonFile.CodeplugCommFileHeader fileHeader, global::Motorola.Common.Communication.Pba.PbaObject pbaObject)
		{
			byte[] c = global::Motorola.Common.Communication.CommonFile.PartitionCommonFile.PackHeaderBuffer(fileHeader);
			byte[] c2 = this.PackBodyBuffer(fileHeader, pbaObject);
			global::System.Collections.ArrayList arrayList = new global::System.Collections.ArrayList();
			arrayList.AddRange(c);
			arrayList.AddRange(c2);
			byte[] array = (byte[])arrayList.ToArray(typeof(byte));
			byte[] c3 = global::Motorola.Common.Communication.CommonFile.PartitionCommonFile.PackCrc32Buffer(array);
			global::System.Collections.ArrayList arrayList2 = new global::System.Collections.ArrayList();
			arrayList2.AddRange(array);
			arrayList2.AddRange(c3);
			this.FileData = (byte[])arrayList2.ToArray(typeof(byte));
			return global::Motorola.Common.Communication.CommonFile.CompressFile.Compress(this.FileData);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002C58 File Offset: 0x00000E58
		private global::Motorola.Common.Communication.Pba.PbaObject Deserialize(string ishFilePath)
		{
			global::Motorola.Common.Communication.Pba.PbaObject result = null;
			using (global::System.IO.FileStream fileStream = new global::System.IO.FileStream(ishFilePath, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read))
			{
				byte[] array = new byte[fileStream.Length];
				int i = (int)fileStream.Length;
				int num = 0;
				while (i > 0)
				{
					int num2 = fileStream.Read(array, num, i);
					if (num2 == 0)
					{
						break;
					}
					num += num2;
					i -= num2;
				}
				if (!global::Motorola.Common.Communication.CommonFile.PartitionCommonFile.ValidateFileDataCrc32(array))
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommonFileInvalidCrc32);
				}
				result = this.Deserialize(array);
			}
			return result;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002CE4 File Offset: 0x00000EE4
		public global::Motorola.Common.Communication.Pba.PbaObject Deserialize(byte[] fileData)
		{
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonFile.CompressFrangment> cmpList = global::Motorola.Common.Communication.CommonFile.CompressFile.ConvertToCompressFileArray(fileData);
			byte[] fileData2 = global::Motorola.Common.Communication.CommonFile.CompressFile.Decompress(cmpList);
			if (!global::Motorola.Common.Communication.CommonFile.PartitionCommonFile.ValidateFileDataCrc32(fileData2))
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommonFileInvalidCrc32);
			}
			global::Motorola.Common.Communication.CommonFile.CodeplugCommFileHeader fileHeader = global::Motorola.Common.Communication.CommonFile.PartitionCommonFile.UnPackHeaderBuffer(fileData2);
			return this.UnPackBodyBuffer(fileHeader, fileData2);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002D24 File Offset: 0x00000F24
		private static byte[] PackHeaderBuffer(global::Motorola.Common.Communication.CommonFile.CodeplugCommFileHeader fileHeader)
		{
			byte[] array = new byte[3];
			int num = 0;
			array[num] = fileHeader.HeaderVer;
			num++;
			array[num] = (byte)fileHeader.Level;
			num++;
			array[num] = (byte)fileHeader.FullDelta;
			return array;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002D60 File Offset: 0x00000F60
		private byte[] PackBodyBuffer(global::Motorola.Common.Communication.CommonFile.CodeplugCommFileHeader fileHeader, global::Motorola.Common.Communication.Pba.PbaObject pbaObject)
		{
			byte[] result = null;
			switch (fileHeader.Level)
			{
			case global::Motorola.Common.Communication.CommonFile.InfoLevel.TypeLevelChangeDisc:
				result = global::Motorola.Common.Communication.CommonFile.PartitionCommonFile.PackTypeLevelChangeDiscovery(pbaObject);
				break;
			case global::Motorola.Common.Communication.CommonFile.InfoLevel.ItemLevelChangeDisc:
				result = global::Motorola.Common.Communication.CommonFile.PartitionCommonFile.PackItemLevelChangeDiscovery(pbaObject);
				break;
			case global::Motorola.Common.Communication.CommonFile.InfoLevel.CodeplugData:
				result = this.PackCodeplugData(pbaObject);
				break;
			}
			return result;
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002DA8 File Offset: 0x00000FA8
		private static byte[] PackCrc32Buffer(byte[] headerBody)
		{
			uint crc32CheckSum = global::Motorola.Common.Communication.CommonFile.CheckSumCRC32.GetCRC32CheckSum(headerBody);
			byte[] bytes = global::System.BitConverter.GetBytes(crc32CheckSum);
			if (!global::System.BitConverter.IsLittleEndian)
			{
				global::System.Array.Reverse(bytes);
			}
			return bytes;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002DD4 File Offset: 0x00000FD4
		private static byte[] PackTypeLevelChangeDiscovery(global::Motorola.Common.Communication.Pba.PbaObject pbaObject)
		{
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(pbaObject.CodeplugData.TypeCounters, global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.TypeLevelChangeDiscovery> typeCounters = pbaObject.CodeplugData.TypeCounters;
			int num = typeCounters.Count * 6;
			byte[] array = new byte[num];
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(array))
			{
				foreach (global::Motorola.Common.Communication.Pba.TypeLevelChangeDiscovery typeLevelChangeDiscovery in pbaObject.CodeplugData.TypeCounters)
				{
					if (typeLevelChangeDiscovery != null)
					{
						byte[] bytes = global::System.BitConverter.GetBytes(typeLevelChangeDiscovery.IshType);
						if (!global::System.BitConverter.IsLittleEndian)
						{
							global::System.Array.Reverse(bytes);
						}
						memoryStream.Write(bytes, 0, 2);
						bytes = global::System.BitConverter.GetBytes(typeLevelChangeDiscovery.Counter);
						if (!global::System.BitConverter.IsLittleEndian)
						{
							global::System.Array.Reverse(bytes);
						}
						memoryStream.Write(bytes, 0, 4);
					}
				}
			}
			return array;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002EC8 File Offset: 0x000010C8
		private static byte[] PackItemLevelChangeDiscovery(global::Motorola.Common.Communication.Pba.PbaObject pbaObject)
		{
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(pbaObject.CodeplugData.IDCounters, global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.ItemLevelChangeDiscovery> idcounters = pbaObject.CodeplugData.IDCounters;
			int num = idcounters.Count * 8;
			byte[] array = new byte[num];
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(array))
			{
				foreach (global::Motorola.Common.Communication.Pba.ItemLevelChangeDiscovery itemLevelChangeDiscovery in pbaObject.CodeplugData.IDCounters)
				{
					if (itemLevelChangeDiscovery != null)
					{
						byte[] bytes = global::System.BitConverter.GetBytes(itemLevelChangeDiscovery.IshType);
						if (!global::System.BitConverter.IsLittleEndian)
						{
							global::System.Array.Reverse(bytes);
						}
						memoryStream.Write(bytes, 0, 2);
						bytes = global::System.BitConverter.GetBytes(itemLevelChangeDiscovery.IshID);
						if (!global::System.BitConverter.IsLittleEndian)
						{
							global::System.Array.Reverse(bytes);
						}
						memoryStream.Write(bytes, 0, 2);
						bytes = global::System.BitConverter.GetBytes(itemLevelChangeDiscovery.Counter);
						if (!global::System.BitConverter.IsLittleEndian)
						{
							global::System.Array.Reverse(bytes);
						}
						memoryStream.Write(bytes, 0, 4);
					}
				}
			}
			return array;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002FE4 File Offset: 0x000011E4
		private byte[] PackCodeplugData(global::Motorola.Common.Communication.Pba.PbaObject pbaObject)
		{
			global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplugInIshItemCollection = pbaObject.GetCodeplugInIshItemCollection();
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(codeplugInIshItemCollection, global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.DataPartition> dataPartitions = pbaObject.CodeplugData.DataPartitions;
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(dataPartitions, global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
			int num = 0;
			global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>> list = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>>(codeplugInIshItemCollection.Count);
			foreach (global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> item in codeplugInIshItemCollection)
			{
				num += 6 + item.Value.ItemSize;
				list.Add(item);
			}
			list.Sort(new global::System.Comparison<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>>(global::Motorola.Common.Communication.CommonUtil.IshItemCollection.IshPairCompare));
			num += 4 * dataPartitions.Count;
			byte[] array = new byte[num];
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(array))
			{
				ushort num2 = 0;
				foreach (global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair in list)
				{
					global::Motorola.Common.Communication.CommonUtil.IshHeader key = keyValuePair.Key;
					global::Motorola.Common.Communication.CommonUtil.IshItem value = keyValuePair.Value;
					byte[] bytes;
					if (num2 != (ushort)key.PartitionNumber)
					{
						num2 = (ushort)key.PartitionNumber;
						memoryStream.WriteByte(byte.MaxValue);
						memoryStream.WriteByte(byte.MaxValue);
						bytes = global::System.BitConverter.GetBytes(num2);
						if (!global::System.BitConverter.IsLittleEndian)
						{
							global::System.Array.Reverse(bytes);
						}
						memoryStream.Write(bytes, 0, 2);
					}
					bytes = global::System.BitConverter.GetBytes(key.IshType);
					if (!global::System.BitConverter.IsLittleEndian)
					{
						global::System.Array.Reverse(bytes);
					}
					memoryStream.Write(bytes, 0, 2);
					bytes = global::System.BitConverter.GetBytes(key.IshID);
					if (!global::System.BitConverter.IsLittleEndian)
					{
						global::System.Array.Reverse(bytes);
					}
					memoryStream.Write(bytes, 0, 2);
					bytes = global::System.BitConverter.GetBytes((ushort)value.ItemSize);
					if (!global::System.BitConverter.IsLittleEndian)
					{
						global::System.Array.Reverse(bytes);
					}
					memoryStream.Write(bytes, 0, 2);
					if (value.ItemSize != 0)
					{
						if (!this.IsCrcBigEndian)
						{
							byte b = value.Data[value.Data.Length - 1];
							value.Data[value.Data.Length - 1] = value.Data[value.Data.Length - 2];
							value.Data[value.Data.Length - 2] = b;
						}
						memoryStream.Write(value.Data, 0, value.ItemSize);
					}
				}
			}
			return array;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00003278 File Offset: 0x00001478
		private static bool ValidateFileDataCrc32(byte[] fileData)
		{
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(fileData, global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
			bool result = true;
			int num = fileData.Length - 4;
			if (0 >= num)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommonFileInvalidFileLength);
			}
			byte[] array = new byte[num];
			global::System.Array.Copy(fileData, 0, array, 0, num);
			uint crc32CheckSum = global::Motorola.Common.Communication.CommonFile.CheckSumCRC32.GetCRC32CheckSum(array);
			uint num2 = (uint)fileData[fileData.Length - 4];
			uint num3 = (uint)fileData[fileData.Length - 4 + 1];
			uint num4 = (uint)fileData[fileData.Length - 4 + 2];
			uint num5 = (uint)fileData[fileData.Length - 4 + 3];
			uint num6 = num5 << 24 | num4 << 16 | num3 << 8 | num2;
			if (crc32CheckSum != num6)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00003304 File Offset: 0x00001504
		private static global::Motorola.Common.Communication.CommonFile.CodeplugCommFileHeader UnPackHeaderBuffer(byte[] fileData)
		{
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(fileData, global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
			global::Motorola.Common.Communication.CommonFile.CodeplugCommFileHeader codeplugCommFileHeader = new global::Motorola.Common.Communication.CommonFile.CodeplugCommFileHeader();
			int num = 0;
			codeplugCommFileHeader.HeaderVer = fileData[num];
			if (16 != codeplugCommFileHeader.HeaderVer)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommonFileInvalidCommonFileVersion);
			}
			num++;
			codeplugCommFileHeader.Level = (global::Motorola.Common.Communication.CommonFile.InfoLevel)fileData[num];
			num++;
			codeplugCommFileHeader.FullDelta = (global::Motorola.Common.Communication.CommonFile.FullDeltaCodeplug)fileData[num];
			return codeplugCommFileHeader;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x0000335C File Offset: 0x0000155C
		private global::Motorola.Common.Communication.Pba.PbaObject UnPackBodyBuffer(global::Motorola.Common.Communication.CommonFile.CodeplugCommFileHeader fileHeader, byte[] fileData)
		{
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(fileData, global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
			global::Motorola.Common.Communication.Pba.PbaObject pbaObject = new global::Motorola.Common.Communication.Pba.PbaObject();
			switch (fileHeader.Level)
			{
			case global::Motorola.Common.Communication.CommonFile.InfoLevel.TypeLevelChangeDisc:
				global::Motorola.Common.Communication.CommonFile.PartitionCommonFile.UnPackTypeLevelChangeDiscovery(pbaObject, fileData);
				break;
			case global::Motorola.Common.Communication.CommonFile.InfoLevel.ItemLevelChangeDisc:
				global::Motorola.Common.Communication.CommonFile.PartitionCommonFile.UnPackItemLevelChangeDiscovery(pbaObject, fileData);
				break;
			case global::Motorola.Common.Communication.CommonFile.InfoLevel.CodeplugData:
				this.UnPackCodeplugData(pbaObject, fileData);
				break;
			}
			return pbaObject;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000033B0 File Offset: 0x000015B0
		private static void UnPackTypeLevelChangeDiscovery(global::Motorola.Common.Communication.Pba.PbaObject pbaObject, byte[] fileData)
		{
			int num = fileData.Length - 4;
			if (num <= 3)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommonFileInvalidCodeplugDataLength);
			}
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.TypeLevelChangeDiscovery> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.TypeLevelChangeDiscovery>();
			int i = 3;
			byte ishPartition = 0;
			while (i < num)
			{
				if (i + 2 > num)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommonFileInvalidCodeplugDataLength);
				}
				ushort num2 = global::Motorola.Common.Communication.CommonFile.Utilities.ToUInt16(fileData, i);
				i += 2;
				if (num2 == 65535)
				{
					if (i + 2 > num)
					{
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommonFileInvalidCodeplugDataLength);
					}
					ishPartition = fileData[i];
					i += 2;
				}
				else
				{
					if (i + 4 > num)
					{
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommonFileInvalidCodeplugDataLength);
					}
					global::Motorola.Common.Communication.Pba.TypeLevelChangeDiscovery typeLevelChangeDiscovery = new global::Motorola.Common.Communication.Pba.TypeLevelChangeDiscovery();
					typeLevelChangeDiscovery.IshPartition = ishPartition;
					typeLevelChangeDiscovery.IshType = num2;
					typeLevelChangeDiscovery.Counter = global::Motorola.Common.Communication.CommonFile.Utilities.ToUInt32(fileData, i);
					i += 4;
					list.Add(typeLevelChangeDiscovery);
				}
			}
			pbaObject.CodeplugData.SetTypeCounters(list);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x0000347C File Offset: 0x0000167C
		private static void UnPackItemLevelChangeDiscovery(global::Motorola.Common.Communication.Pba.PbaObject pbaObject, byte[] fileData)
		{
			int num = fileData.Length - 4;
			if (num <= 3)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommonFileInvalidCodeplugDataLength);
			}
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.ItemLevelChangeDiscovery> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.ItemLevelChangeDiscovery>();
			int i = 3;
			byte ishPartition = 0;
			while (i < num)
			{
				if (i + 2 > num)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommonFileInvalidCodeplugDataLength);
				}
				ushort num2 = global::Motorola.Common.Communication.CommonFile.Utilities.ToUInt16(fileData, i);
				i += 2;
				if (num2 == 65535)
				{
					if (i + 2 > num)
					{
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommonFileInvalidCodeplugDataLength);
					}
					ishPartition = fileData[i];
					i += 2;
				}
				else
				{
					global::Motorola.Common.Communication.Pba.ItemLevelChangeDiscovery itemLevelChangeDiscovery = new global::Motorola.Common.Communication.Pba.ItemLevelChangeDiscovery();
					if (i + 2 + 4 > num)
					{
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommonFileInvalidCodeplugDataLength);
					}
					itemLevelChangeDiscovery.IshPartition = ishPartition;
					itemLevelChangeDiscovery.IshType = num2;
					itemLevelChangeDiscovery.IshID = global::Motorola.Common.Communication.CommonFile.Utilities.ToUInt16(fileData, i);
					i += 2;
					itemLevelChangeDiscovery.Counter = global::Motorola.Common.Communication.CommonFile.Utilities.ToUInt32(fileData, i);
					i += 4;
					list.Add(itemLevelChangeDiscovery);
				}
			}
			pbaObject.CodeplugData.SetIDCounters(list);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x0000355C File Offset: 0x0000175C
		private void UnPackCodeplugData(global::Motorola.Common.Communication.Pba.PbaObject pbaObject, byte[] fileData)
		{
			int length = fileData.GetLength(0);
			global::Motorola.Common.Communication.CommonUtil.IshItemCollection ishItemCollection = new global::Motorola.Common.Communication.CommonUtil.IshItemCollection();
			byte b = 0;
			global::Motorola.Common.Communication.CommonUtil.IshItem item;
			for (int i = 3; i < length - 4; i += item.ItemSize)
			{
				if (i + 2 + 2 > length - 4)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommonFileInvalidCodeplugDataLength);
				}
				ushort num;
				ushort num2;
				if (fileData[i] == 255 && fileData[i + 1] == 255)
				{
					i += 2;
					num = (ushort)fileData[i];
					i++;
					num2 = (ushort)fileData[i];
					i++;
					b = (byte)((int)num2 << 8 | (int)num);
					if (i == length - 4 || (fileData[i] == 255 && fileData[i + 1] == 255))
					{
						continue;
					}
				}
				if (i + 2 + 2 + 2 > length - 4)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommonFileInvalidCodeplugDataLength);
				}
				global::Motorola.Common.Communication.CommonUtil.IshHeader headers = default(global::Motorola.Common.Communication.CommonUtil.IshHeader);
				num = (ushort)fileData[i];
				i++;
				num2 = (ushort)fileData[i];
				i++;
				headers.IshType = (ushort)((int)num2 << 8 | (int)num);
				num = (ushort)fileData[i];
				i++;
				num2 = (ushort)fileData[i];
				i++;
				headers.IshID = (ushort)((int)num2 << 8 | (int)num);
				item = default(global::Motorola.Common.Communication.CommonUtil.IshItem);
				num = (ushort)fileData[i];
				i++;
				num2 = (ushort)fileData[i];
				i++;
				item.ItemSize = ((int)num2 << 8 | (int)num);
				if (i + item.ItemSize > length - 4)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommonFileInvalidItemDataLength);
				}
				byte[] array = new byte[item.ItemSize];
				global::System.Array.Copy(fileData, i, array, 0, item.ItemSize);
				item.Data = array;
				if (!this.IsCrcBigEndian)
				{
					byte b2 = item.Data[item.Data.Length - 1];
					item.Data[item.Data.Length - 1] = item.Data[item.Data.Length - 2];
					item.Data[item.Data.Length - 2] = b2;
				}
				if (b != 0)
				{
					headers.PartitionNumber = b;
				}
				ishItemCollection.Add(headers, item);
			}
			pbaObject.SetCodeplug(ishItemCollection);
		}

		// Token: 0x0400002F RID: 47
		private bool IsCrcBigEndian;
	}
}
