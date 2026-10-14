using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using Motorola.Common.Communication.CommonFile;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Pba;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.IshHandler
{
	// Token: 0x02000006 RID: 6
	public class CpsOtapDifferentialSequenceHelper : global::Motorola.Common.Communication.ICpsSequenceManagerHelper
	{
		// Token: 0x0600002D RID: 45 RVA: 0x00003244 File Offset: 0x00001444
		public CpsOtapDifferentialSequenceHelper(global::Motorola.Common.Communication.IshHandler.IRadioCommand radioCommand, global::Motorola.Common.Communication.IshHandler.ICpsOtapDifferentialSequenceHelperCallback callback, ushort[] readPartitions, ushort[] writePartitions)
		{
			if (radioCommand == null || callback == null || readPartitions == null || readPartitions.Length == 0 || writePartitions == null || writePartitions.Length == 0)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
			}
			this.radioCommand = radioCommand;
			this.helperCallback = callback;
			this.readPartitions = readPartitions;
			this.writePartitions = writePartitions;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00003294 File Offset: 0x00001494
		public global::Motorola.Common.Communication.Pba.PbaObject ReadDevice(global::Motorola.Common.Communication.Pba.PbaObject referencePba, ushort sessionID)
		{
			double num = 1.0;
			if (this.helperCallback.Progress != null)
			{
				this.helperCallback.Progress.UpdateProgress(0.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ReadingCP);
			}
			if (this.helperCallback.IsLowBattery())
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Pcr_BatteryLevelLow);
			}
			global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo = this.helperCallback.GetDeviceInfo();
			ushort previousSessionID = 0;
			if (referencePba != null && referencePba.CodeplugData != null && string.Equals(deviceInfo.CodeplugVersion, referencePba.CodeplugData.CPVersion, global::System.StringComparison.OrdinalIgnoreCase))
			{
				previousSessionID = referencePba.CodeplugData.ArchiveSessionID;
			}
			bool flag = this.radioCommand.StartOtapSession(sessionID, previousSessionID, true);
			if (this.helperCallback.Progress != null)
			{
				this.helperCallback.Progress.UpdateProgress(0.05, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ReadingCP);
			}
			num -= 0.05;
			global::Motorola.Common.Communication.Pba.PbaObject pbaObject;
			if (flag)
			{
				pbaObject = this.DiffRead(referencePba, new global::Motorola.Common.Communication.IteratedProgressIndicator(this.helperCallback.Progress, num));
			}
			else
			{
				pbaObject = this.FullRead(referencePba, new global::Motorola.Common.Communication.IteratedProgressIndicator(this.helperCallback.Progress, num));
			}
			pbaObject.CodeplugData.CPVersion = deviceInfo.CodeplugVersion;
			pbaObject.CodeplugData.ArchiveSessionID = sessionID;
			if (this.helperCallback.Progress != null)
			{
				this.helperCallback.Progress.UpdateProgress(1.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ReadCPDone);
			}
			return pbaObject;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000033EC File Offset: 0x000015EC
		private global::Motorola.Common.Communication.Pba.PbaObject FullRead(global::Motorola.Common.Communication.Pba.PbaObject referencePba, global::Motorola.Common.Communication.IProgressIndicator subProgess)
		{
			if (this.CanReadByInterestTypes(referencePba))
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Differential OTAP read full codecodeplug by types.", new object[0]);
				return this.radioCommand.ReadCodeplugItemsByTypes(referencePba.InterestTypes.Distinct<ushort>(), subProgess);
			}
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Differential OTAP read full codecodeplug by partitions.", new object[0]);
			return this.radioCommand.ReadCodeplugItemsInPartitions(this.readPartitions, subProgess);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000034C0 File Offset: 0x000016C0
		private global::Motorola.Common.Communication.Pba.PbaObject DiffRead(global::Motorola.Common.Communication.Pba.PbaObject referencePba, global::Motorola.Common.Communication.IProgressIndicator subProgess)
		{
			global::Motorola.Common.Communication.CommonUtil.IshItemCollection ishItemCollection;
			if (this.CanReadByInterestTypes(referencePba))
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Differential OTAP read diff codecodeplug by types.", new object[0]);
				ishItemCollection = this.radioCommand.ReadDifferetialCodeplugByIshTypes(referencePba.InterestTypes.Distinct<ushort>(), subProgess);
			}
			else
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Differential OTAP read diff codecodeplug by partitions.", new object[0]);
				ishItemCollection = this.radioCommand.ReadDifferetialCodeplugInPartitions(this.readPartitions, subProgess);
			}
			global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplugInIshItemCollection = referencePba.GetCodeplugInIshItemCollection();
			using (global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>> enumerator = ishItemCollection.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> ishItem = enumerator.Current;
					global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> ishItem8 = ishItem;
					if (ishItem8.Value.ItemSize == 0)
					{
						global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> ishItem2 = ishItem;
						if (ishItem2.Key.IshID == 65535)
						{
							codeplugInIshItemCollection.RemoveAll(delegate(global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> x)
							{
								byte partitionNumber = x.Key.PartitionNumber;
								global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> ishItem6 = ishItem;
								if (partitionNumber == ishItem6.Key.PartitionNumber)
								{
									ushort ishType = x.Key.IshType;
									global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> ishItem7 = ishItem;
									return ishType == ishItem7.Key.IshType;
								}
								return false;
							});
						}
						else
						{
							global::Motorola.Common.Communication.CommonUtil.IshItemCollection ishItemCollection2 = codeplugInIshItemCollection;
							global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> ishItem3 = ishItem;
							ishItemCollection2.Remove(ishItem3.Key);
						}
					}
					else
					{
						global::Motorola.Common.Communication.CommonUtil.IshItemCollection ishItemCollection3 = codeplugInIshItemCollection;
						global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> ishItem4 = ishItem;
						global::Motorola.Common.Communication.CommonUtil.IshHeader key = ishItem4.Key;
						global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> ishItem5 = ishItem;
						ishItemCollection3.Update(key, ishItem5.Value);
					}
				}
			}
			referencePba.SetCodeplug(codeplugInIshItemCollection);
			return referencePba;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00003618 File Offset: 0x00001818
		private bool CanReadByInterestTypes(global::Motorola.Common.Communication.Pba.PbaObject referencePba)
		{
			if (referencePba == null)
			{
				return false;
			}
			if (referencePba.InterestTypes == null || referencePba.InterestTypes.Count == 0)
			{
				return false;
			}
			if (referencePba.CodeplugData == null)
			{
				return false;
			}
			global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo = this.helperCallback.GetDeviceInfo();
			return !(referencePba.CodeplugData.CPVersion != deviceInfo.CodeplugVersion);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00003674 File Offset: 0x00001874
		public global::Motorola.Common.Communication.Pba.PbaObject WriteDevice(global::Motorola.Common.Communication.Pba.PbaObject pbaObject, ushort sessionID)
		{
			double num = 1.0;
			if (this.helperCallback.Progress != null)
			{
				this.helperCallback.Progress.UpdateProgress(0.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WritingCP);
			}
			if (this.helperCallback.IsLowBattery())
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Pcr_BatteryLevelLow);
			}
			if (pbaObject == null || pbaObject.CodeplugData == null)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
			}
			bool flag = this.radioCommand.StartOtapSession(sessionID, pbaObject.CodeplugData.ArchiveSessionID, false);
			string text = this.WriteValidation(pbaObject);
			if (string.IsNullOrEmpty(text))
			{
				text = this.GetOTAPCPFilePath(pbaObject);
			}
			if (this.helperCallback.Progress != null)
			{
				this.helperCallback.Progress.UpdateProgress(0.05);
			}
			num -= 0.05;
			if (flag)
			{
				if (pbaObject.DifferetialCodeplugData == null)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Pcr_DiffWriteNoChange);
				}
				global::Motorola.Common.Communication.CommonUtil.IshItemCollection ishItemCollection = new global::Motorola.Common.Communication.Pba.PbaObject
				{
					CodeplugData = pbaObject.DifferetialCodeplugData
				}.GetCodeplugInIshItemCollection();
				global::Motorola.Common.Communication.IshHandler.IshItemsWriteFilter ishItemsWriteFilter = new global::Motorola.Common.Communication.IshHandler.IshItemsWriteFilter(this.writePartitions, null);
				ishItemCollection = ishItemsWriteFilter.GetCollectionToWrite(ishItemCollection);
				this.WritePba(ishItemCollection, sessionID, text, true, new global::Motorola.Common.Communication.IteratedProgressIndicator(this.helperCallback.Progress, num));
			}
			else
			{
				this.FullWrite(pbaObject, sessionID, text, new global::Motorola.Common.Communication.IteratedProgressIndicator(this.helperCallback.Progress, num));
			}
			pbaObject.CodeplugData.ArchiveSessionID = sessionID;
			if (this.helperCallback.Progress != null)
			{
				this.helperCallback.Progress.UpdateProgress(1.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WriteCPDone);
			}
			return pbaObject;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00003828 File Offset: 0x00001A28
		private void FullWrite(global::Motorola.Common.Communication.Pba.PbaObject pbaObject, ushort sessionID, string radioFilePath, global::Motorola.Common.Communication.IProgressIndicator subProgress)
		{
			global::Motorola.Common.Communication.CommonUtil.IshItemCollection ishItemCollection = pbaObject.GetCodeplugInIshItemCollection();
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.DataBlockType> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.DataBlockType>();
			if (pbaObject.DeletableTypes != null)
			{
				list.AddRange(pbaObject.DeletableTypes);
			}
			if (pbaObject.IDDeletableTypes != null)
			{
				list.AddRange(pbaObject.IDDeletableTypes);
			}
			if (list.Count > 0)
			{
				global::System.Collections.Generic.IEnumerable<global::Motorola.Common.Communication.Pba.DataBlockType> enumerable = list.Distinct<global::Motorola.Common.Communication.Pba.DataBlockType>();
				global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>> list2 = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>>();
				using (global::System.Collections.Generic.IEnumerator<global::Motorola.Common.Communication.Pba.DataBlockType> enumerator = enumerable.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						global::Motorola.Common.Communication.Pba.DataBlockType typeDeletable = enumerator.Current;
						global::System.Collections.Generic.IEnumerable<global::Motorola.Common.Communication.CommonUtil.IshHeader> source = from x in ishItemCollection.Headers
						where x.IshType == typeDeletable.TypeID && x.PartitionNumber == typeDeletable.PartitionID
						select x;
						if (!source.Any<global::Motorola.Common.Communication.CommonUtil.IshHeader>())
						{
							list2.Add(new global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>(new global::Motorola.Common.Communication.CommonUtil.IshHeader(typeDeletable.PartitionID, typeDeletable.TypeID, ushort.MaxValue), new global::Motorola.Common.Communication.CommonUtil.IshItem(0, null, global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult.Undefined)));
						}
					}
				}
				ishItemCollection.UpdateRange(list2);
			}
			if (subProgress != null)
			{
				subProgress.UpdateProgress(0.0);
			}
			try
			{
				global::Motorola.Common.Communication.IshHandler.IshItemsWriteFilter ishItemsWriteFilter = new global::Motorola.Common.Communication.IshHandler.IshItemsWriteFilter(this.writePartitions, pbaObject.InterestTypes);
				ishItemCollection = ishItemsWriteFilter.GetCollectionToWrite(ishItemCollection);
				this.WritePba(ishItemCollection, sessionID, radioFilePath, false, subProgress);
			}
			finally
			{
				if (subProgress != null)
				{
					subProgress.UpdateProgress(1.0);
				}
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x0000399C File Offset: 0x00001B9C
		private void WritePba(global::Motorola.Common.Communication.CommonUtil.IshItemCollection ishCollection, ushort sessionID, string radioFilePath, bool isDiff, global::Motorola.Common.Communication.IProgressIndicator subProgress)
		{
			global::Motorola.Common.Communication.Pba.PbaObject pbaObject = new global::Motorola.Common.Communication.Pba.PbaObject();
			pbaObject.SetCodeplug(ishCollection);
			global::Motorola.Common.Communication.CommonFile.CodeplugCommFileHeader codeplugCommFileHeader = new global::Motorola.Common.Communication.CommonFile.CodeplugCommFileHeader();
			codeplugCommFileHeader.HeaderVer = 16;
			codeplugCommFileHeader.FullDelta = (isDiff ? global::Motorola.Common.Communication.CommonFile.FullDeltaCodeplug.Delta : global::Motorola.Common.Communication.CommonFile.FullDeltaCodeplug.Full);
			codeplugCommFileHeader.Level = global::Motorola.Common.Communication.CommonFile.InfoLevel.CodeplugData;
			global::Motorola.Common.Communication.CommonFile.PartitionCommonFile partitionCommonFile = new global::Motorola.Common.Communication.CommonFile.PartitionCommonFile(this.radioCommand.IsCommonFileCrcBigEndian);
			byte[] array = partitionCommonFile.Serialize(codeplugCommFileHeader, pbaObject);
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream())
			{
				memoryStream.Write(array, 0, array.Length);
				string text = 1U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "_" + 2.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "_1.cmp";
				string fileName = string.IsNullOrEmpty(radioFilePath) ? text : (radioFilePath + "/" + text);
				this.radioCommand.FileWrite(0, fileName, memoryStream, new global::Motorola.Common.Communication.IteratedProgressIndicator(subProgress, 0.99), false);
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00003A90 File Offset: 0x00001C90
		private string WriteValidation(global::Motorola.Common.Communication.Pba.PbaObject pbaObject)
		{
			global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo = this.helperCallback.GetDeviceInfo();
			if (!string.Equals(deviceInfo.CodeplugVersion, pbaObject.CodeplugData.CPVersion, global::System.StringComparison.OrdinalIgnoreCase))
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ValidateInfosFailure);
			}
			if (pbaObject.ValidationSpecialFields != null && pbaObject.ValidationSpecialFields.Count > 0)
			{
				this.ValidateSpecialFields(pbaObject.ValidationSpecialFields, deviceInfo);
			}
			if (pbaObject.ValidationInfos != null && pbaObject.ValidationInfos.Count > 0)
			{
				global::Motorola.Common.Communication.IshHandler.Validator.ValidateInfos(pbaObject.ValidationInfos, deviceInfo, null);
			}
			string result = null;
			if (pbaObject.ValidationFields != null && pbaObject.ValidationFields.Count<global::Motorola.Common.Communication.Pba.ValidationField>() > 0)
			{
				global::System.Collections.Generic.IEnumerable<global::Motorola.Common.Communication.CommonUtil.IshHeader> validateItemsToRead = global::Motorola.Common.Communication.IshHandler.Validator.GetValidateItemsToRead(pbaObject.ValidationFields);
				if (validateItemsToRead == null)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
				}
				global::Motorola.Common.Communication.CommonUtil.IshItemCollection ishInRadio = this.radioCommand.ReadItemsByIshHeaders(validateItemsToRead, out result, null);
				global::Motorola.Common.Communication.IshHandler.Validator.ValidateFields(pbaObject.ValidationFields, ishInRadio);
			}
			return result;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00003B60 File Offset: 0x00001D60
		private void ValidateSpecialFields(global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.ValidationSpecialField> validationSpecialFields, global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			if (validationSpecialFields == null || !validationSpecialFields.Any<global::Motorola.Common.Communication.Pba.ValidationSpecialField>())
			{
				return;
			}
			foreach (global::Motorola.Common.Communication.Pba.ValidationSpecialField validationSpecialField in validationSpecialFields)
			{
				global::Motorola.Common.Communication.Pba.SpecialValidationMethod specialValidationMethod = validationSpecialField.SpecialValidationMethod;
				if (specialValidationMethod == global::Motorola.Common.Communication.Pba.SpecialValidationMethod.PCRCodeplugPassword && !this.PCRCodeplugPasswordValidation(validationSpecialField.Value, deviceInfo))
				{
					if (((global::Motorola.Common.Communication.CommonUtil.PCRDeviceInfo)deviceInfo).PasswordStatus.RemainingAttempts <= 0)
					{
						global::Motorola.Common.Communication.IshHandler.Validator.ThrowException(validationSpecialField.ErrorToThrow, global::Motorola.Common.CustomException.CommonErrorCode.AstroCruncherPasswordValidationFailsRadioLocked);
					}
					else if (((global::Motorola.Common.Communication.CommonUtil.PCRDeviceInfo)deviceInfo).PasswordStatus.RemainingAttempts <= 3)
					{
						global::Motorola.Common.Communication.IshHandler.Validator.ThrowException(validationSpecialField.ErrorToThrow, global::Motorola.Common.CustomException.CommonErrorCode.AstroCruncherPasswordValidationFailsRemainingAttempt);
					}
					else
					{
						global::Motorola.Common.Communication.IshHandler.Validator.ThrowException(validationSpecialField.ErrorToThrow, global::Motorola.Common.CustomException.CommonErrorCode.AstroCruncherPasswordValidationFails);
					}
				}
			}
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00003C2C File Offset: 0x00001E2C
		private bool PCRCodeplugPasswordValidation(string value, global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			bool result = false;
			string password = string.Empty;
			global::Motorola.Common.Communication.CommonUtil.PCRDeviceInfo pcrdeviceInfo = deviceInfo as global::Motorola.Common.Communication.CommonUtil.PCRDeviceInfo;
			if (pcrdeviceInfo == null)
			{
				return true;
			}
			global::Motorola.Common.Communication.CommonUtil.PasswordStatus passwordStatus = pcrdeviceInfo.PasswordStatus;
			if (passwordStatus.Policy == global::Motorola.Common.Communication.CommonUtil.PasswordPolicy.Enhanced)
			{
				if (!string.IsNullOrEmpty(value) && passwordStatus.RemainingAttempts > 0)
				{
					password = global::Motorola.Common.Communication.IshHandler.CommonSecurity.ComputeHash(value, passwordStatus.Salt, passwordStatus.AlgorithmID);
					global::Motorola.Common.Communication.CommonUtil.PasswordStatus passwordStatus2 = this.radioCommand.ValidateLocalPassword(password);
					if (passwordStatus2 != null)
					{
						passwordStatus.RemainingAttempts = passwordStatus2.RemainingAttempts;
						result = passwordStatus2.IsPasswordValidationSuccess;
					}
				}
			}
			else
			{
				result = true;
			}
			return result;
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00003CC4 File Offset: 0x00001EC4
		private string GetOTAPCPFilePath(global::Motorola.Common.Communication.Pba.PbaObject pbaObject)
		{
			global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplugInIshItemCollection = pbaObject.GetCodeplugInIshItemCollection();
			global::Motorola.Common.Communication.CommonUtil.IshHeader item = codeplugInIshItemCollection.Headers.First((global::Motorola.Common.Communication.CommonUtil.IshHeader s) => s.IshType == 4113);
			global::System.Collections.Generic.IEnumerable<global::Motorola.Common.Communication.CommonUtil.IshHeader> ishHeaders = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader>
			{
				item
			};
			string result;
			this.radioCommand.ReadItemsByIshHeaders(ishHeaders, out result, null);
			return result;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00003D24 File Offset: 0x00001F24
		public void OpenSession(ushort sessionID, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation)
		{
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00003D26 File Offset: 0x00001F26
		public void CloseSession(ushort sessionID, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation, bool pendingDeploy)
		{
			if (operation == global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read)
			{
				this.radioCommand.CloseOtapSession(sessionID, !pendingDeploy);
				return;
			}
			if (operation == global::Motorola.Common.Communication.CommonUtil.RadioOperation.Program && pendingDeploy)
			{
				this.radioCommand.CloseOtapSession(sessionID, false);
			}
		}

		// Token: 0x04000004 RID: 4
		private global::Motorola.Common.Communication.IshHandler.IRadioCommand radioCommand;

		// Token: 0x04000005 RID: 5
		private global::Motorola.Common.Communication.IshHandler.ICpsOtapDifferentialSequenceHelperCallback helperCallback;

		// Token: 0x04000006 RID: 6
		private ushort[] readPartitions;

		// Token: 0x04000007 RID: 7
		private ushort[] writePartitions;
	}
}
