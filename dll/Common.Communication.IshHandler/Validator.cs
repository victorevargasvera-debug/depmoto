using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Pba;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.IshHandler
{
	// Token: 0x0200000B RID: 11
	public static class Validator
	{
		// Token: 0x0600009D RID: 157 RVA: 0x000044C8 File Offset: 0x000026C8
		public static global::System.Collections.Generic.IEnumerable<global::Motorola.Common.Communication.CommonUtil.IshHeader> GetValidateItemsToRead(global::System.Collections.Generic.IEnumerable<global::Motorola.Common.Communication.Pba.ValidationField> validationFields)
		{
			if (validationFields == null || !validationFields.Any<global::Motorola.Common.Communication.Pba.ValidationField>())
			{
				return null;
			}
			global::System.Collections.Generic.HashSet<global::Motorola.Common.Communication.CommonUtil.IshHeader> hashSet = new global::System.Collections.Generic.HashSet<global::Motorola.Common.Communication.CommonUtil.IshHeader>();
			foreach (global::Motorola.Common.Communication.Pba.ValidationField validationField in validationFields)
			{
				global::Motorola.Common.Communication.CommonUtil.IshHeader item = new global::Motorola.Common.Communication.CommonUtil.IshHeader(validationField.PartitionID, validationField.BlockType, validationField.BlockID);
				if (!hashSet.Contains(item))
				{
					hashSet.Add(item);
				}
				if (validationField.LengthInBits == 0U || validationField.Content == null || validationField.Content.Length == 0)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgument);
				}
				int num = (int)(validationField.OffsetInBits / 8U);
				int num2 = (int)((validationField.OffsetInBits + validationField.LengthInBits - 1U) / 8U);
				if (num2 - num >= validationField.Content.Length)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgument);
				}
			}
			return hashSet;
		}

		// Token: 0x0600009E RID: 158 RVA: 0x000045A4 File Offset: 0x000027A4
		public static void ValidateFields(global::System.Collections.Generic.IEnumerable<global::Motorola.Common.Communication.Pba.ValidationField> validationFields, global::Motorola.Common.Communication.CommonUtil.IshItemCollection IshInRadio)
		{
			if (validationFields == null || !validationFields.Any<global::Motorola.Common.Communication.Pba.ValidationField>())
			{
				return;
			}
			foreach (global::Motorola.Common.Communication.Pba.ValidationField validationField in validationFields)
			{
				global::Motorola.Common.Communication.CommonUtil.IshHeader ishHeader = new global::Motorola.Common.Communication.CommonUtil.IshHeader(validationField.PartitionID, validationField.BlockType, validationField.BlockID);
				bool flag = IshInRadio.ContainsHeader(ishHeader);
				if (IshInRadio != null && (flag || validationField.AutoFill))
				{
					if (!flag)
					{
						global::Motorola.Common.Communication.IshHandler.Validator.ThrowException(validationField.ErrorToThrow, global::Motorola.Common.CustomException.CommonErrorCode.ValidateFieldsFailure);
					}
					else
					{
						global::Motorola.Common.Communication.CommonUtil.IshItem ishItem = IshInRadio[ishHeader];
						if (!global::Motorola.Common.Communication.IshHandler.Validator.ValidateField(validationField, ishItem))
						{
							global::Motorola.Common.Communication.IshHandler.Validator.ThrowException(validationField.ErrorToThrow, global::Motorola.Common.CustomException.CommonErrorCode.ValidateFieldsFailure);
						}
					}
				}
				else if (!validationField.BypassMissing && !validationField.AutoFill)
				{
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Validate Field Failure: type [{0}] id[{1}] does not exist", new object[]
					{
						validationField.BlockType,
						validationField.BlockID
					});
					global::Motorola.Common.Communication.IshHandler.Validator.ThrowException(validationField.ErrorToThrow, global::Motorola.Common.CustomException.CommonErrorCode.ValidateFieldsFailure);
				}
				else
				{
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteWarning("Validate Field Warning: type [{0}] id[{1}] does not exist. Bypassed", new object[]
					{
						validationField.BlockType,
						validationField.BlockID
					});
				}
			}
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00004708 File Offset: 0x00002908
		public static bool ValidateField(global::Motorola.Common.Communication.Pba.ValidationField validateField, global::Motorola.Common.Communication.CommonUtil.IshItem ishItem)
		{
			if (validateField == null)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgument);
			}
			int num = (int)(validateField.OffsetInBits / 8U);
			int num2 = (int)((validateField.OffsetInBits + validateField.LengthInBits - 1U) / 8U);
			byte[] array2;
			if (num2 + 1 > ishItem.Data.Length)
			{
				if (validateField.AutoFill)
				{
					int num3 = (num2 + 1 > ishItem.Data.Length) ? (num2 + 1) : ishItem.Data.Length;
					byte[] array = new byte[num3];
					for (int i = 0; i < ishItem.Data.Length; i++)
					{
						array[i] = ishItem.Data[i];
					}
					array2 = array.Skip(num).Take(num2 - num + 1).ToArray<byte>();
				}
				else
				{
					if (validateField.BypassMissing)
					{
						global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteWarning("Validate Field Warning: type [{0}] id[{1}] offset[{2}] does not exist. Bypassed", new object[]
						{
							validateField.BlockType,
							validateField.BlockID,
							validateField.OffsetInBits
						});
						return true;
					}
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Validate Field Failure: type [{0}] id[{1}] offset[{2}] does not exist.", new object[]
					{
						validateField.BlockType,
						validateField.BlockID,
						validateField.OffsetInBits
					});
					return false;
				}
			}
			else
			{
				array2 = ishItem.Data.Skip(num).Take(num2 - num + 1).ToArray<byte>();
			}
			int num4 = array2.Length;
			for (int j = 0; j < num4; j++)
			{
				int num5 = 255;
				if (j == 0)
				{
					int num6 = (int)(8U - validateField.OffsetInBits % 8U);
					int num7 = (int)((long)num6 - (long)((ulong)validateField.LengthInBits));
					if (num7 < 0)
					{
						num7 = 0;
					}
					num5 = (1 << num6) - (1 << num7);
				}
				else if (j == num4 - 1)
				{
					int num8 = (int)(7U - (validateField.OffsetInBits + validateField.LengthInBits - 1U) % 8U);
					num5 = 256 - (1 << num8);
				}
				if (((int)validateField.Content[j] & num5) != ((int)array2[j] & num5))
				{
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Validate Field Failure type [{0}] id[{1}] offset[{2}] length[{3}] index [{4}], source [{5}], target [{6}]", new object[]
					{
						validateField.BlockType,
						validateField.BlockID,
						validateField.OffsetInBits,
						validateField.LengthInBits,
						j,
						validateField.Content[j].ToString("X"),
						array2[j].ToString("X")
					});
					return false;
				}
			}
			return true;
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x000049A8 File Offset: 0x00002BA8
		public static void ValidateInfos(global::System.Collections.Generic.IEnumerable<global::Motorola.Common.Communication.Pba.ValidationInfo> validationInfos, global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::System.Collections.IComparer comparator = null)
		{
			if (validationInfos == null || !validationInfos.Any<global::Motorola.Common.Communication.Pba.ValidationInfo>())
			{
				return;
			}
			if (deviceInfo == null)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgument);
			}
			global::Motorola.Common.Communication.IshHandler.ValidationStringComparator validationStringComparator = new global::Motorola.Common.Communication.IshHandler.ValidationStringComparator(comparator);
			foreach (global::Motorola.Common.Communication.Pba.ValidationInfo validationInfo in validationInfos)
			{
				global::System.Reflection.PropertyInfo property = deviceInfo.GetType().GetProperty(validationInfo.ID);
				object value;
				if (property != null)
				{
					value = property.GetValue(deviceInfo, null);
				}
				else
				{
					global::System.Reflection.FieldInfo field = deviceInfo.GetType().GetField(validationInfo.ID);
					if (field == null)
					{
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ValidateInfosNotExist);
					}
					value = field.GetValue(deviceInfo);
				}
				if (value == null)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ValidateInfosFailure);
				}
				string text = value.ToString();
				int num = validationStringComparator.Compare(validationInfo.Value, text);
				bool flag = false;
				if (validationInfo.ValidationMethod == global::Motorola.Common.Communication.Pba.ValidationMethod.Equal)
				{
					flag = (num == 0);
				}
				else if (validationInfo.ValidationMethod == global::Motorola.Common.Communication.Pba.ValidationMethod.Greater)
				{
					flag = (num > 0);
				}
				else if (validationInfo.ValidationMethod == global::Motorola.Common.Communication.Pba.ValidationMethod.Less)
				{
					flag = (num < 0);
				}
				else if (validationInfo.ValidationMethod == global::Motorola.Common.Communication.Pba.ValidationMethod.NotGreater)
				{
					flag = (num == 0 || num < 0);
				}
				else if (validationInfo.ValidationMethod == global::Motorola.Common.Communication.Pba.ValidationMethod.NotLess)
				{
					flag = (num == 0 || num > 0);
				}
				if (!flag)
				{
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Validate Info Failure ID [{0}] Method[{1}] Value[{2}] Value(Radio)[{3}] ", new object[]
					{
						validationInfo.ID,
						validationInfo.ValidationMethod.ToString(),
						validationInfo.Value,
						text
					});
					global::Motorola.Common.Communication.IshHandler.Validator.ThrowException(validationInfo.ErrorToThrow, global::Motorola.Common.CustomException.CommonErrorCode.ValidateInfosFailure);
				}
			}
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00004B60 File Offset: 0x00002D60
		public static void ThrowException(global::Motorola.Common.CustomException.CommonErrorCode toThrow, global::Motorola.Common.CustomException.CommonErrorCode defaultError)
		{
			if (toThrow != global::Motorola.Common.CustomException.CommonErrorCode.None)
			{
				throw new global::Motorola.Common.CustomException.CommonException(toThrow);
			}
			throw new global::Motorola.Common.CustomException.CommonException(defaultError);
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00004B74 File Offset: 0x00002D74
		public static void ValidateAvailableSpace(global::Motorola.Common.Communication.Pba.LanguagePackData lpData, global::Motorola.Common.Communication.Pba.LanguagePackData radioLpInfo)
		{
			if (radioLpInfo == null)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgument);
			}
			uint num = 0U;
			uint num2 = 0U;
			for (int i = 0; i < radioLpInfo.LanguagePacks.Count; i++)
			{
				global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo pcrLanguagePackInfo = radioLpInfo.LanguagePacks[i] as global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo;
				for (int j = 0; j < lpData.LanguagePacks.Count; j++)
				{
					global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo pcrLanguagePackInfo2 = lpData.LanguagePacks[j] as global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo;
					if (pcrLanguagePackInfo.PackID == pcrLanguagePackInfo2.PackID)
					{
						num2 += pcrLanguagePackInfo.Size;
						break;
					}
				}
			}
			for (int k = 0; k < lpData.LanguagePacks.Count; k++)
			{
				num += (lpData.LanguagePacks[k] as global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo).Size;
			}
			if (num > num2 + radioLpInfo.AvailableSpace)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.LanguagePack_PCR_Radio_does_not_have_enough_free_space);
			}
		}
	}
}
