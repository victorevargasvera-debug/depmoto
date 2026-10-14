using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.LogUtility;

namespace Motorola.Common.Communication.TetraUtility
{
	// Token: 0x0200007F RID: 127
	public static class TetraUtil
	{
		// Token: 0x060002F4 RID: 756 RVA: 0x0000E884 File Offset: 0x0000CA84
		public static uint CalculateCpSize(global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<ushort, byte[]>> blockList)
		{
			uint num = 0U;
			foreach (global::System.Collections.Generic.KeyValuePair<ushort, byte[]> keyValuePair in blockList)
			{
				num += (uint)keyValuePair.Value.Length;
			}
			return num;
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x0000E8DC File Offset: 0x0000CADC
		public static global::Motorola.Common.Communication.TetraUtility.MemMapRecord GetMemMapConfig(string mapID)
		{
			global::Motorola.Common.Communication.TetraUtility.MemMapRecord memMapRecord = null;
			foreach (global::Motorola.Common.Communication.TetraUtility.MemMapRecord memMapRecord2 in global::Motorola.Common.Communication.TetraUtility.CommConfigManager.Instance.MemMapConfigTable.RecordsList)
			{
				if (memMapRecord2.MemMapID == mapID)
				{
					memMapRecord = memMapRecord2;
					break;
				}
			}
			if (memMapRecord == null)
			{
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter.ToString(), string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "mapID={0}", new object[]
				{
					mapID
				}));
			}
			return memMapRecord;
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x0000E978 File Offset: 0x0000CB78
		public static global::Motorola.Common.Communication.TetraUtility.FDIVersionMapRecord GetFDIVersionMapRecordByCPVer(string hexCpVer, string modelNumber)
		{
			global::Motorola.Common.Communication.TetraUtility.FDIVersionMapRecord fdiversionMapRecord = null;
			foreach (global::Motorola.Common.Communication.TetraUtility.FDIVersionMapRecord fdiversionMapRecord2 in global::Motorola.Common.Communication.TetraUtility.CommConfigManager.Instance.FdiVersionMapConfigTable.RecordsList)
			{
				if (!string.IsNullOrEmpty(hexCpVer))
				{
					string[] array = fdiversionMapRecord2.CPRange.Split(new char[]
					{
						'-'
					});
					string text;
					string hexVersion;
					if (array.Length == 1)
					{
						text = array[0];
						hexVersion = text;
					}
					else
					{
						if (array.Length != 2)
						{
							throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter.ToString(), string.Format("CPRange={0}", fdiversionMapRecord2.CPRange));
						}
						text = array[0];
						hexVersion = array[1];
					}
					if (global::Motorola.Common.Communication.TetraUtility.CPVersion.Compare(hexCpVer, text) >= 0 && global::Motorola.Common.Communication.TetraUtility.CPVersion.Compare(hexCpVer, hexVersion) <= 0 && fdiversionMapRecord2.ModelNumber.Equals(modelNumber))
					{
						fdiversionMapRecord = fdiversionMapRecord2;
						break;
					}
				}
			}
			if (fdiversionMapRecord == null)
			{
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter.ToString(), string.Format("cpVer={0},extModelType={1}", hexCpVer, modelNumber));
			}
			return fdiversionMapRecord;
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x0000EA8C File Offset: 0x0000CC8C
		public static global::Motorola.Common.Communication.TetraUtility.HwIDRecord GetHwIDConfig(uint hwID)
		{
			global::Motorola.Common.Communication.TetraUtility.HwIDRecord result = null;
			foreach (global::Motorola.Common.Communication.TetraUtility.HwIDRecord hwIDRecord in global::Motorola.Common.Communication.TetraUtility.CommConfigManager.Instance.HwIDTable.RecordsList)
			{
				if (hwIDRecord.HwID == hwID)
				{
					result = hwIDRecord;
					break;
				}
			}
			return result;
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x0000EAF4 File Offset: 0x0000CCF4
		public static global::Motorola.Common.Communication.TetraUtility.CPUTypeRecord GetCpuTypeConfig(uint hwID)
		{
			global::Motorola.Common.Communication.TetraUtility.HwIDRecord hwIDConfig = global::Motorola.Common.Communication.TetraUtility.TetraUtil.GetHwIDConfig(hwID);
			if (hwIDConfig == null)
			{
				return null;
			}
			global::Motorola.Common.Communication.TetraUtility.CPUTypeRecord result = null;
			foreach (global::Motorola.Common.Communication.TetraUtility.CPUTypeRecord cputypeRecord in global::Motorola.Common.Communication.TetraUtility.CommConfigManager.Instance.CpuTypeConfigTable.RecordsList)
			{
				if (cputypeRecord.CPUType == hwIDConfig.CPUType)
				{
					result = cputypeRecord;
					break;
				}
			}
			return result;
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x0000EB6C File Offset: 0x0000CD6C
		public static global::Motorola.Common.Communication.TetraUtility.FlashTypeRecord GetRadioFlashTypeConfig(uint vid, uint pid)
		{
			global::Motorola.Common.Communication.TetraUtility.FlashTypeRecord flashTypeRecord = null;
			foreach (global::Motorola.Common.Communication.TetraUtility.FlashTypeRecord flashTypeRecord2 in global::Motorola.Common.Communication.TetraUtility.CommConfigManager.Instance.FlashTypeConfigTable.RecordsList)
			{
				if (flashTypeRecord2.FlashID == pid && flashTypeRecord2.VenderID == vid)
				{
					flashTypeRecord = flashTypeRecord2;
					break;
				}
			}
			if (flashTypeRecord == null)
			{
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter.ToString(), string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "venderID={0},flashID={1}", new object[]
				{
					vid,
					pid
				}));
			}
			return flashTypeRecord;
		}

		// Token: 0x060002FA RID: 762 RVA: 0x0000EC18 File Offset: 0x0000CE18
		public static uint GetReleaseIDPointer(string cpVer, string commonModelNumber)
		{
			if (string.IsNullOrEmpty(cpVer) || string.IsNullOrEmpty(commonModelNumber))
			{
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter.ToString(), string.Format("cpVer={0},commonModelNumber={1}", cpVer, commonModelNumber));
			}
			global::Motorola.Common.Communication.TetraUtility.MemMapVersionMapRecord memMapVersionMapRecord = global::Motorola.Common.Communication.TetraUtility.TetraUtil.GetMemMapVersionMapRecord(cpVer, commonModelNumber);
			global::Motorola.Common.Communication.TetraUtility.MemMapRecord memMapConfig = global::Motorola.Common.Communication.TetraUtility.TetraUtil.GetMemMapConfig(memMapVersionMapRecord.MemMapID);
			if (!memMapConfig.MapDefinition.ContainsKey(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.MEM_MAP_RELEASEID_SECTION) || memMapConfig.MapDefinition[global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.MEM_MAP_RELEASEID_SECTION].Count != 1)
			{
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter.ToString(), string.Format("memory map {0} has the wrong ReleaseID section definition", memMapConfig.MemMapID));
			}
			return global::System.Convert.ToUInt32(memMapConfig.MapDefinition[global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.MEM_MAP_RELEASEID_SECTION][0].Address);
		}

		// Token: 0x060002FB RID: 763 RVA: 0x0000ECD4 File Offset: 0x0000CED4
		public static byte[] InitGemstoneCPHead(uint cpBodyLength, ushort extType, uint cpVersion)
		{
			byte[] array = new byte[global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.GEMSTONE_CP_HEAD_SIZE];
			byte[] bytes = global::System.BitConverter.GetBytes(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.CP_SECTION_ID);
			global::System.Array.Copy(bytes, 0, array, (int)global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.CP_SECTION_ID_OFFSET, bytes.Length);
			bytes = global::System.BitConverter.GetBytes(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.GEMSTONE_CP_HEAD_SIZE + cpBodyLength);
			global::System.Array.Copy(bytes, 0, array, (int)global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.CP_IMAGE_SIZE_OFFSET, bytes.Length);
			bytes = global::System.Text.Encoding.ASCII.GetBytes(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.CP_HEAD_SIGNATURE);
			global::System.Array.Copy(bytes, 0, array, (int)global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.CP_IMAGE_VERSION_ID_OFFSET, bytes.Length);
			bytes = global::System.BitConverter.GetBytes(extType);
			global::System.Array.Copy(bytes, 0, array, (int)global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.CP_MODEL_TYPE_OFFSET, bytes.Length);
			bytes = global::System.BitConverter.GetBytes(cpVersion);
			global::System.Array.Copy(bytes, 0, array, (int)global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.CP_VERSION_OFFSET, bytes.Length);
			return array;
		}

		// Token: 0x060002FC RID: 764 RVA: 0x0000ED74 File Offset: 0x0000CF74
		public static string ConvertByteArray2HexString(byte[] byteArr)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			foreach (byte b in byteArr)
			{
				stringBuilder.AppendFormat("{0:X2}", b);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x060002FD RID: 765 RVA: 0x0000EDE0 File Offset: 0x0000CFE0
		public static byte[] ConvertHexString2ByteArray(string hex)
		{
			return (from x in global::System.Linq.Enumerable.Range(0, hex.Length)
			where 0 == x % 2
			select global::System.Convert.ToByte(hex.Substring(x, 2), 16)).ToArray<byte>();
		}

		// Token: 0x060002FE RID: 766 RVA: 0x0000EE44 File Offset: 0x0000D044
		public static bool CheckFPExisting(string commonModelNumber, string cpVersion)
		{
			global::Motorola.Common.Communication.TetraUtility.TetraRadioModelInfo model = global::Motorola.Common.Communication.TetraUtility.CommConfigManager.Instance.GetModel(commonModelNumber);
			if (model != null)
			{
				try
				{
					bool result = false;
					if (bool.TryParse(model.FlashPackSupport, out result))
					{
						return result;
					}
					throw new global::System.NotImplementedException("parse model.FlashPackSupport");
				}
				catch
				{
					if (global::Motorola.Common.Communication.TetraUtility.TetraUtil.InVersionRange(cpVersion, model.FlashPackSupport.ToString()))
					{
						return true;
					}
					return false;
				}
				return false;
			}
			return false;
		}

		// Token: 0x060002FF RID: 767 RVA: 0x0000EEB0 File Offset: 0x0000D0B0
		public static bool CheckFPExisting(uint modelType, string cpVersion)
		{
			global::Motorola.Common.Communication.TetraUtility.TetraRadioModelInfo model = global::Motorola.Common.Communication.TetraUtility.CommConfigManager.Instance.GetModel((int)modelType);
			if (model != null)
			{
				try
				{
					bool result = false;
					if (bool.TryParse(model.FlashPackSupport, out result))
					{
						return result;
					}
					throw new global::System.NotImplementedException("parse model.FlashPackSupport");
				}
				catch
				{
					if (global::Motorola.Common.Communication.TetraUtility.TetraUtil.InVersionRange(cpVersion, model.FlashPackSupport.ToString()))
					{
						return true;
					}
					return false;
				}
				return false;
			}
			return false;
		}

		// Token: 0x06000300 RID: 768 RVA: 0x0000EF54 File Offset: 0x0000D154
		public static global::Motorola.Common.Communication.TetraUtility.ReleaseIDType GetReleaseIDType(string cpVer, string commonModelNumber)
		{
			if (string.IsNullOrEmpty(cpVer) || string.IsNullOrEmpty(commonModelNumber))
			{
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter.ToString(), string.Format("cpVer={0},commonModelNumber={1}", cpVer, commonModelNumber));
			}
			global::Motorola.Common.Communication.TetraUtility.TetraRadioModelInfo model = global::Motorola.Common.Communication.TetraUtility.CommConfigManager.Instance.GetModel(commonModelNumber);
			int modelType = model.ModelType;
			global::Motorola.Common.Communication.TetraUtility.ReleaseIDTypeRecord releaseIDTypeRecord = global::Motorola.Common.Communication.TetraUtility.CommConfigManager.Instance.ReleaseIDTypeTable.RecordsList.Find((global::Motorola.Common.Communication.TetraUtility.ReleaseIDTypeRecord it) => global::Motorola.Common.Communication.TetraUtility.TetraUtil.InVersionRange(cpVer.ToString(), it.CPRange) & global::Motorola.Common.Communication.TetraUtility.TetraUtil.InModelList(modelType.ToString(), it.Model));
			if (releaseIDTypeRecord != null)
			{
				return releaseIDTypeRecord.ReleaseIDType;
			}
			return global::Motorola.Common.Communication.TetraUtility.ReleaseIDType.ReleaseIDNone;
		}

		// Token: 0x06000301 RID: 769 RVA: 0x0000EFEC File Offset: 0x0000D1EC
		public static bool IsGemstonePlatform(global::Motorola.Common.Communication.TetraUtility.TetraRadioModelInfo modelInfo)
		{
			bool result = false;
			if (modelInfo == null)
			{
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0008_RH_CommErrOperationMode.ToString());
			}
			string productLine = modelInfo.ProductLine;
			for (int i = 0; i < global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.GEMSTONE_PLATFORM_PRODUCT_LIST.Length; i++)
			{
				if (string.Equals(productLine, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.GEMSTONE_PLATFORM_PRODUCT_LIST[i], global::System.StringComparison.OrdinalIgnoreCase))
				{
					result = true;
					break;
				}
			}
			return result;
		}

		// Token: 0x06000302 RID: 770 RVA: 0x0000F040 File Offset: 0x0000D240
		public static bool IsMilan2Radio(global::Motorola.Common.Communication.TetraUtility.TetraRadioModelInfo modelInfo)
		{
			bool result = false;
			if (modelInfo == null)
			{
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0008_RH_CommErrOperationMode.ToString());
			}
			string productLine = modelInfo.ProductLine;
			for (int i = 0; i < global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.MILAN2_RADIO_PRODUCT_LIST.Length; i++)
			{
				if (string.Equals(productLine, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.MILAN2_RADIO_PRODUCT_LIST[i], global::System.StringComparison.OrdinalIgnoreCase))
				{
					result = true;
					break;
				}
			}
			return result;
		}

		// Token: 0x06000303 RID: 771 RVA: 0x0000F094 File Offset: 0x0000D294
		public static global::Motorola.Common.Communication.TetraUtility.MemMapVersionMapRecord GetMemMapVersionMapRecord(string hexCpVer, string commonModelNumber)
		{
			global::Motorola.Common.Communication.TetraUtility.MemMapVersionMapRecord memMapVersionMapRecord = null;
			foreach (global::Motorola.Common.Communication.TetraUtility.MemMapVersionMapRecord memMapVersionMapRecord2 in global::Motorola.Common.Communication.TetraUtility.CommConfigManager.Instance.MemMapVersionMapConfigTable.RecordsList)
			{
				if (!string.IsNullOrEmpty(hexCpVer))
				{
					string[] array = memMapVersionMapRecord2.CPRange.Split(new char[]
					{
						'-'
					});
					string text;
					string hexVersion;
					if (array.Length == 1)
					{
						text = array[0];
						hexVersion = text;
					}
					else
					{
						if (array.Length != 2)
						{
							throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter.ToString(), string.Format("CPRange={0}", memMapVersionMapRecord2.CPRange));
						}
						text = array[0];
						hexVersion = array[1];
					}
					if (global::Motorola.Common.Communication.TetraUtility.CPVersion.Compare(hexCpVer, text) < 0 || global::Motorola.Common.Communication.TetraUtility.CPVersion.Compare(hexCpVer, hexVersion) > 0)
					{
						continue;
					}
				}
				if (memMapVersionMapRecord2.ModelNumber.Equals(commonModelNumber))
				{
					memMapVersionMapRecord = memMapVersionMapRecord2;
					break;
				}
			}
			if (memMapVersionMapRecord == null)
			{
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter.ToString(), string.Format("cpVer={0},extModelType={1}", hexCpVer, commonModelNumber));
			}
			return memMapVersionMapRecord;
		}

		// Token: 0x06000304 RID: 772 RVA: 0x0000F1A4 File Offset: 0x0000D3A4
		public static bool InVersionRange(string version, string versionRange)
		{
			object cache = global::Motorola.Common.Communication.TetraUtility.TetraUtil.queryCacher.GetCache("{0}_{1}_{2}", new object[]
			{
				"InVersionRange",
				version,
				versionRange
			});
			if (cache != null)
			{
				return (bool)cache;
			}
			bool flag = global::Motorola.Common.Communication.TetraUtility.TetraUtil.CheckVersionRange(version, versionRange);
			global::Motorola.Common.Communication.TetraUtility.TetraUtil.queryCacher.DoCache(flag, "{0}_{1}_{2}", new object[]
			{
				"InVersionRange",
				version,
				versionRange
			});
			return flag;
		}

		// Token: 0x06000305 RID: 773 RVA: 0x0000F21C File Offset: 0x0000D41C
		public static bool InModelList(string modelType, string modelListString)
		{
			bool flag = false;
			object cache = global::Motorola.Common.Communication.TetraUtility.TetraUtil.queryCacher.GetCache("{0}_{1}_{2}", new object[]
			{
				"InModelList",
				modelType,
				modelListString
			});
			if (cache != null)
			{
				return (bool)cache;
			}
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.TetraUtility.TetraProductGroupInfo> productLineRecordList = global::Motorola.Common.Communication.TetraUtility.CommConfigManager.Instance.GetProductLineRecordList(modelListString);
			foreach (global::Motorola.Common.Communication.TetraUtility.TetraProductGroupInfo tetraProductGroupInfo in productLineRecordList)
			{
				if (tetraProductGroupInfo != null)
				{
					string[] array = tetraProductGroupInfo.ModelList.Split(new char[]
					{
						','
					});
					global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
					foreach (string text in array)
					{
						if (!string.IsNullOrWhiteSpace(text))
						{
							list.Add(text.Trim());
						}
					}
					if (list.Contains(modelType))
					{
						flag = true;
						break;
					}
				}
			}
			global::Motorola.Common.Communication.TetraUtility.TetraUtil.queryCacher.DoCache(flag, "{0}_{1}_{2}", new object[]
			{
				"InModelList",
				modelType,
				modelListString
			});
			return flag;
		}

		// Token: 0x06000306 RID: 774 RVA: 0x0000F348 File Offset: 0x0000D548
		public static bool CheckVersionRange(string version, string versionRange)
		{
			if (string.IsNullOrEmpty(versionRange))
			{
				return false;
			}
			string[] array = versionRange.Split(new char[]
			{
				','
			}, global::System.StringSplitOptions.RemoveEmptyEntries);
			string[] array2 = array;
			int i = 0;
			while (i < array2.Length)
			{
				string text = array2[i];
				string[] array3 = text.Split(new char[]
				{
					'-'
				}, global::System.StringSplitOptions.RemoveEmptyEntries);
				string hexVersion2;
				string hexVersion;
				if (array3.Length == 1)
				{
					hexVersion = (hexVersion2 = array3[0]);
					goto IL_6E;
				}
				if (array3.Length == 2)
				{
					hexVersion2 = array3[0];
					hexVersion = array3[1];
					goto IL_6E;
				}
				IL_88:
				i++;
				continue;
				IL_6E:
				if (global::Motorola.Common.Communication.TetraUtility.CPVersion.Compare(version, hexVersion2) >= 0 && global::Motorola.Common.Communication.TetraUtility.CPVersion.Compare(version, hexVersion) <= 0)
				{
					return true;
				}
				goto IL_88;
			}
			return false;
		}

		// Token: 0x06000307 RID: 775 RVA: 0x0000F3F0 File Offset: 0x0000D5F0
		public static global::Motorola.Common.Communication.TetraUtility.CPUType GetCpuTypeViaHwId(uint hwID)
		{
			foreach (global::Motorola.Common.Communication.TetraUtility.HwIDRecord hwIDRecord in global::Motorola.Common.Communication.TetraUtility.CommConfigManager.Instance.HwIDTable.RecordsList)
			{
				if (hwIDRecord.HwID == hwID)
				{
					return hwIDRecord.CPUType;
				}
			}
			return global::Motorola.Common.Communication.TetraUtility.CPUType.UNKNOWN;
		}

		// Token: 0x06000308 RID: 776 RVA: 0x0000F45C File Offset: 0x0000D65C
		public static global::Motorola.Common.Communication.CommonUtil.GemstoneRadioType GetGemstoneRadioType(uint hwID)
		{
			global::Motorola.Common.Communication.CommonUtil.GemstoneRadioType result = global::Motorola.Common.Communication.CommonUtil.GemstoneRadioType.UNKNOWN;
			foreach (global::Motorola.Common.Communication.TetraUtility.HwIDRecord hwIDRecord in global::Motorola.Common.Communication.TetraUtility.CommConfigManager.Instance.HwIDTable.RecordsList)
			{
				if (hwIDRecord.HwID == hwID)
				{
					result = hwIDRecord.ProductType;
					break;
				}
			}
			return result;
		}

		// Token: 0x06000309 RID: 777 RVA: 0x0000F4C8 File Offset: 0x0000D6C8
		public static uint GetIoControlCode(uint DeviceType, uint Function, uint Method, uint Access)
		{
			return DeviceType << 16 | Access << 14 | Function << 2 | Method;
		}

		// Token: 0x0600030A RID: 778 RVA: 0x0000F4E8 File Offset: 0x0000D6E8
		public static global::System.Collections.Generic.List<char> GetDriveNameByUnitMask(uint Mask)
		{
			global::System.Collections.Generic.List<char> list = new global::System.Collections.Generic.List<char>();
			for (int i = 0; i < 25; i++)
			{
				uint num = (uint)global::System.Math.Pow(2.0, (double)i);
				if ((num & Mask) == num)
				{
					list.Add((char)(65 + i));
				}
			}
			return list;
		}

		// Token: 0x0600030B RID: 779 RVA: 0x0000F52C File Offset: 0x0000D72C
		public static bool EjectMassStorageDevice(string driveLetter, int retryCount)
		{
			global::System.IntPtr zero = global::System.IntPtr.Zero;
			global::Motorola.Common.Communication.TetraUtility.WinAPIWrapper winAPIWrapper = new global::Motorola.Common.Communication.TetraUtility.WinAPIWrapper();
			bool flag = false;
			if (!winAPIWrapper.Wrapper_OpenVolume(driveLetter.Substring(0, 1), ref zero))
			{
				return false;
			}
			while (!winAPIWrapper.Wrapper_LockVolume(zero))
			{
				global::System.Threading.Thread.Sleep(2000);
				if (retryCount-- <= 0)
				{
					break;
				}
			}
			if (winAPIWrapper.Wrapper_DismountVolume(zero) && winAPIWrapper.Wrapper_PreventRemovalOfVolume(zero, false) && winAPIWrapper.Wrapper_AutoEjectVolume(zero))
			{
				flag = true;
			}
			return winAPIWrapper.WrapperCloseHandle(zero) && flag;
		}

		// Token: 0x0600030C RID: 780 RVA: 0x0000F5A4 File Offset: 0x0000D7A4
		public static bool IsAragornMassStorageDisk(string driveLetter)
		{
			try
			{
				lock (global::Motorola.Common.Communication.TetraUtility.TetraUtil._diskQueryLocker)
				{
					global::System.Management.ManagementClass managementClass2;
					global::System.Management.ManagementClass managementClass = managementClass2 = new global::System.Management.ManagementClass("Win32_Diskdrive");
					try
					{
						global::System.Management.ManagementObjectCollection instances = managementClass.GetInstances();
						foreach (global::System.Management.ManagementBaseObject managementBaseObject in instances)
						{
							global::System.Management.ManagementObject managementObject = (global::System.Management.ManagementObject)managementBaseObject;
							object value = managementObject.Properties["PNPDeviceID"].Value;
							if (value != null && value.ToString().ToUpper(global::System.Globalization.CultureInfo.InvariantCulture).Contains(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.MASS_STORAGE_PNP_STRING))
							{
								foreach (global::System.Management.ManagementBaseObject managementBaseObject2 in managementObject.GetRelated("Win32_DiskPartition"))
								{
									global::System.Management.ManagementObject managementObject2 = (global::System.Management.ManagementObject)managementBaseObject2;
									foreach (global::System.Management.ManagementBaseObject managementBaseObject3 in managementObject2.GetRelated("Win32_LogicalDisk"))
									{
										if (managementBaseObject3["Name"] != null && managementBaseObject3["Name"].ToString().Substring(0, 1) == driveLetter.Substring(0, 1))
										{
											return true;
										}
									}
								}
							}
						}
					}
					finally
					{
						if (managementClass2 != null)
						{
							((global::System.IDisposable)managementClass2).Dispose();
						}
					}
				}
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("Got exception in IsAragornMassStorageDisk: " + ex.Message);
				return true;
			}
			return false;
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x0600030D RID: 781 RVA: 0x0000F7D8 File Offset: 0x0000D9D8
		// (set) Token: 0x0600030E RID: 782 RVA: 0x0000F818 File Offset: 0x0000DA18
		public static bool NeedCheckUSBAck
		{
			get
			{
				bool needCheckUsbAck;
				lock (global::Motorola.Common.Communication.TetraUtility.TetraUtil._locker)
				{
					needCheckUsbAck = global::Motorola.Common.Communication.TetraUtility.TetraUtil._needCheckUsbAck;
				}
				return needCheckUsbAck;
			}
			set
			{
				lock (global::Motorola.Common.Communication.TetraUtility.TetraUtil._locker)
				{
					global::Motorola.Common.Communication.TetraUtility.TetraUtil._needCheckUsbAck = value;
				}
			}
		}

		// Token: 0x040003E1 RID: 993
		private static global::Motorola.Common.Communication.TetraUtility.QueryCacher queryCacher = new global::Motorola.Common.Communication.TetraUtility.QueryCacher(20);

		// Token: 0x040003E2 RID: 994
		private static bool _needCheckUsbAck = false;

		// Token: 0x040003E3 RID: 995
		private static object _locker = new object();

		// Token: 0x040003E4 RID: 996
		private static object _diskQueryLocker = new object();
	}
}
