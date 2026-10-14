using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading;
using Motorola.Common.CommonLib;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Pba;
using Motorola.Common.Communication.Rcmp;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.SequenceManager
{
	// Token: 0x0200002D RID: 45
	public class PcrBootOperations
	{
		// Token: 0x06000168 RID: 360 RVA: 0x0000CDE0 File Offset: 0x0000AFE0
		internal PcrBootOperations(global::Motorola.Common.Communication.IMessageExecutor rcmpWrapper, int maxDataPayload)
		{
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(rcmpWrapper, global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
			if (maxDataPayload <= 0)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgument);
			}
			this.m_MaxDataPayload = maxDataPayload;
			this.BootExecutor = new global::Motorola.Common.Communication.SequenceManager.PcrBootExecutor(rcmpWrapper);
		}

		// Token: 0x06000169 RID: 361 RVA: 0x0000CE24 File Offset: 0x0000B024
		internal bool WriteRamDownloader(string RamDloaderFile, global::Motorola.Common.Communication.IProgressIndicator ProgressIndicator)
		{
			if (string.IsNullOrEmpty(RamDloaderFile))
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgument);
			}
			global::Motorola.Common.Communication.Srecord srecord = this.LoadValidateSrecFile(RamDloaderFile);
			global::Motorola.Common.Communication.SrecDataCollection dataRecords = srecord.DataRecords;
			int index = dataRecords.Count - 1;
			bool result;
			if (!this.BootExecutor.isRamDloaderRunning())
			{
				global::Motorola.Common.Communication.SrecData srecData = dataRecords[index];
				uint address = srecData.Address;
				if (!this.BootLoad(srecord, address, ProgressIndicator))
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.BootLoadFailure);
				}
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Bootload Done", new object[0]);
				if (!this.BootExecutor.Unlock())
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.SecurityUnlockFailure);
				}
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Unlock Done", new object[0]);
				result = true;
			}
			else
			{
				result = true;
			}
			return result;
		}

		// Token: 0x0600016A RID: 362 RVA: 0x0000CF04 File Offset: 0x0000B104
		internal void ReadMemory(int startAddress, int endAddress, string s19FilePath, global::Motorola.Common.Communication.IProgressIndicator ProgressIndicator)
		{
			if (endAddress <= startAddress || s19FilePath == null)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgument);
			}
			string empty = string.Empty;
			try
			{
				int num = endAddress - startAddress + 1;
				byte[] array = this.BootExecutor.ReadMemory64KBlocks(startAddress, endAddress, ProgressIndicator);
				if (array == null || array.Length < num)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.IncompleteReadMemoryOperation);
				}
				using (global::Motorola.Common.Communication.Srecord srecord = new global::Motorola.Common.Communication.Srecord())
				{
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Created Srecord: " + srecord.GetHashCode(), new object[0]);
					global::Motorola.Common.Communication.SrecData item = new global::Motorola.Common.Communication.SrecData((uint)num, (uint)startAddress, array, global::Motorola.Common.Communication.SrecType.S3);
					srecord.DataRecords.Add(item);
					global::Motorola.Common.Communication.SequenceManager.PcrBootOperations.WriteRecordsToFile(srecord.DataRecords, s19FilePath);
				}
			}
			catch (global::Motorola.Common.CustomException.CommonException systemException)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ReadMemoryFailure, systemException);
			}
		}

		// Token: 0x0600016B RID: 363 RVA: 0x0000D008 File Offset: 0x0000B208
		internal string ReadMemoryChecksum(int startAddress, int endAddress, string s19FilePath, global::Motorola.Common.Communication.IProgressIndicator ProgressIndicator)
		{
			if (endAddress <= startAddress || s19FilePath == null)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgument);
			}
			string empty = string.Empty;
			string md;
			try
			{
				int num = endAddress - startAddress + 1;
				byte[] array = this.BootExecutor.ReadMemory64KBlocks(startAddress, endAddress, ProgressIndicator);
				if (array == null || array.Length < num)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.IncompleteReadMemoryOperation);
				}
				using (global::Motorola.Common.Communication.Srecord srecord = new global::Motorola.Common.Communication.Srecord())
				{
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Created Srecord: " + srecord.GetHashCode(), new object[0]);
					global::Motorola.Common.Communication.SrecData item = new global::Motorola.Common.Communication.SrecData((uint)num, (uint)startAddress, array, global::Motorola.Common.Communication.SrecType.S3);
					srecord.DataRecords.Add(item);
					global::Motorola.Common.Communication.SequenceManager.PcrBootOperations.WriteRecordsToFile(srecord.DataRecords, s19FilePath);
				}
				md = global::Motorola.Common.Communication.SequenceManager.PcrFileSystemUpdateFile.GetMd5(array);
			}
			catch (global::Motorola.Common.CustomException.CommonException systemException)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ReadMemoryFailure, systemException);
			}
			return md;
		}

		// Token: 0x0600016C RID: 364 RVA: 0x0000D118 File Offset: 0x0000B318
		internal string ReadGenerateChecksum(int startAddress, int endAddress, global::Motorola.Common.Communication.IProgressIndicator ProgressIndicator)
		{
			if (endAddress <= startAddress)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgument);
			}
			string empty = string.Empty;
			string md;
			try
			{
				int num = endAddress - startAddress + 1;
				byte[] array = this.BootExecutor.ReadMemory64KBlocks(startAddress, endAddress, ProgressIndicator);
				if (array == null || array.Length < num)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.IncompleteReadMemoryOperation);
				}
				md = global::Motorola.Common.Communication.SequenceManager.PcrFileSystemUpdateFile.GetMd5(array);
			}
			catch (global::Motorola.Common.CustomException.CommonException systemException)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ReadMemoryFailure, systemException);
			}
			return md;
		}

		// Token: 0x0600016D RID: 365 RVA: 0x0000D1A4 File Offset: 0x0000B3A4
		private bool FlashFilesToRam(global::System.Collections.Generic.List<string> SrecFilesToFlash, string RamDldrFile, global::Motorola.Common.Communication.IProgressIndicator ProgressIndicator)
		{
			foreach (string value in SrecFilesToFlash)
			{
				if (string.IsNullOrEmpty(value))
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgument);
				}
			}
			if (string.IsNullOrEmpty(RamDldrFile))
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgument);
			}
			bool result;
			try
			{
				int num = 0;
				uint num2 = 4U;
				if (!this.WriteRamDownloader(RamDldrFile, null))
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.WriteRamDownloaderFailure);
				}
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.SequenceManager.RamDataObjectInfo> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.SequenceManager.RamDataObjectInfo>();
				global::System.Collections.ArrayList arrayList = new global::System.Collections.ArrayList();
				global::System.Collections.ArrayList arrayList2 = new global::System.Collections.ArrayList();
				global::System.Collections.ArrayList arrayList3 = new global::System.Collections.ArrayList();
				foreach (string srecFileToFlash in SrecFilesToFlash)
				{
					uint ramStartAddress;
					if (num == 0)
					{
						ramStartAddress = 270532608U;
					}
					else
					{
						int index = list.Count - 1;
						uint ramAddress = list[index].RamAddress;
						uint numBytes = (uint)list[index].NumBytes;
						ramStartAddress = ramAddress + numBytes + num2;
					}
					global::System.Collections.Generic.List<global::Motorola.Common.Communication.SequenceManager.RamDataObjectInfo> list2 = this.WriteSrecToRam(srecFileToFlash, ramStartAddress, ProgressIndicator);
					foreach (global::Motorola.Common.Communication.SequenceManager.RamDataObjectInfo ramDataObjectInfo in list2)
					{
						arrayList.Add(ramDataObjectInfo.RamAddress);
						arrayList2.Add(ramDataObjectInfo.FlashAddress);
						arrayList3.Add((uint)ramDataObjectInfo.NumBytes);
					}
					uint[] ramAddressArray = global::Motorola.Common.Communication.SequenceManager.RamDataObjectInfo.ConvertToUintArray(arrayList);
					uint[] flashAddressArray = global::Motorola.Common.Communication.SequenceManager.RamDataObjectInfo.ConvertToUintArray(arrayList2);
					uint[] payloadSizeArray = global::Motorola.Common.Communication.SequenceManager.RamDataObjectInfo.ConvertToUintArray(arrayList3);
					if (!this.BootExecutor.BootCommit(ramAddressArray, flashAddressArray, payloadSizeArray, global::Motorola.Common.Communication.Rcmp.BootCommitFunctionType.CommitToFlash, null))
					{
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.BootCommitFailure);
					}
					list.AddRange(list2);
					list2.Clear();
					num++;
				}
				result = true;
			}
			catch (global::Motorola.Common.CustomException.CommonException systemException)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.FlashFilesToRamFailure, systemException);
			}
			return result;
		}

		// Token: 0x0600016E RID: 366 RVA: 0x0000D438 File Offset: 0x0000B638
		internal virtual void WriteFiles(global::System.Collections.Generic.List<string> Imagefilepaths, ref global::System.Collections.ArrayList ramAddressArray, ref global::System.Collections.ArrayList flashAddressArray, ref global::System.Collections.ArrayList payloadSizeArray, ref global::System.Collections.Generic.List<global::Motorola.Common.Communication.SequenceManager.RamDataObjectInfo> repeaterDataObjectsFlashed, bool dualBrick, int fileCount, global::Motorola.Common.Communication.SequenceManager.ProgressInfoObject progressData, global::Motorola.Common.Communication.IProgressIndicator ProgressIndicator)
		{
			foreach (string value in Imagefilepaths)
			{
				if (string.IsNullOrEmpty(value))
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgument);
				}
			}
			try
			{
				int num = 0;
				uint num2 = 4U;
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.SequenceManager.RamDataObjectInfo> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.SequenceManager.RamDataObjectInfo>();
				int num3 = progressData.startScope;
				int num4 = num3 + (progressData.endScope - progressData.startScope) / Imagefilepaths.Count<string>();
				global::Motorola.Common.Communication.SequenceManager.ProgressInfoObject progressInfoObject = new global::Motorola.Common.Communication.SequenceManager.ProgressInfoObject();
				foreach (string srecFileToFlash in Imagefilepaths)
				{
					if (dualBrick)
					{
						if (repeaterDataObjectsFlashed != null)
						{
							num = fileCount;
							list = repeaterDataObjectsFlashed;
							dualBrick = false;
						}
					}
					uint ramStartAddress;
					if (num == 0)
					{
						ramStartAddress = 270532608U;
					}
					else
					{
						int index = list.Count - 1;
						uint ramAddress = list[index].RamAddress;
						uint numBytes = (uint)list[index].NumBytes;
						ramStartAddress = ramAddress + numBytes + num2;
					}
					if (ProgressIndicator != null && progressData != null)
					{
						ProgressIndicator.SetCurrentScope(num3, num4);
						progressInfoObject.startScope = num3;
						progressInfoObject.endScope = num4;
					}
					global::System.Collections.Generic.List<global::Motorola.Common.Communication.SequenceManager.RamDataObjectInfo> list2 = this.WriteSrecToRam(srecFileToFlash, ramStartAddress, ProgressIndicator);
					if (ProgressIndicator != null && progressData != null)
					{
						num3 += progressData.percentPerOperation;
						num4 += progressData.percentPerOperation;
					}
					foreach (global::Motorola.Common.Communication.SequenceManager.RamDataObjectInfo ramDataObjectInfo in list2)
					{
						ramAddressArray.Add(ramDataObjectInfo.RamAddress);
						flashAddressArray.Add(ramDataObjectInfo.FlashAddress);
						payloadSizeArray.Add((uint)ramDataObjectInfo.NumBytes);
					}
					list.AddRange(list2);
					repeaterDataObjectsFlashed = list;
					list2.Clear();
					num++;
				}
			}
			catch (global::Motorola.Common.CustomException.CommonException systemException)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.FlashFilesToRamFailure, systemException);
			}
		}

		// Token: 0x0600016F RID: 367 RVA: 0x0000D6F0 File Offset: 0x0000B8F0
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.SequenceManager.RamDataObjectInfo> WriteSrecToRam(string SrecFileToFlash, uint RamStartAddress, global::Motorola.Common.Communication.IProgressIndicator ProgressIndicator)
		{
			global::Motorola.Common.Communication.Srecord srecord = this.LoadValidateSrecFile(SrecFileToFlash);
			global::Motorola.Common.Communication.SrecDataCollection dataRecords = srecord.DataRecords;
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.SequenceManager.RamDataObjectInfo> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.SequenceManager.RamDataObjectInfo>();
			global::System.Collections.ArrayList arrayList = new global::System.Collections.ArrayList();
			global::System.Collections.ArrayList arrayList2 = new global::System.Collections.ArrayList();
			global::System.Collections.ArrayList arrayList3 = new global::System.Collections.ArrayList();
			uint num = 4U;
			int num2 = 0;
			int num3 = 0;
			global::Motorola.Common.Communication.SequenceManager.ProgressInfoObject progressInfoObject = new global::Motorola.Common.Communication.SequenceManager.ProgressInfoObject();
			int num4 = 0;
			if (ProgressIndicator != null)
			{
				for (int i = 0; i < dataRecords.Count; i++)
				{
					global::Motorola.Common.Communication.SrecData srecData = dataRecords[i];
					num3 += (int)srecData.DataLen;
				}
			}
			for (int j = 0; j < dataRecords.Count; j++)
			{
				global::Motorola.Common.Communication.SrecData srecData = dataRecords[j];
				uint address = srecData.Address;
				byte[] data = srecData.GetData();
				if (data == null || srecData.DataLen == 0U)
				{
					if (srecData.Type != global::Motorola.Common.Communication.SrecType.S7 && srecData.Type != global::Motorola.Common.Communication.SrecType.S8 && srecData.Type != global::Motorola.Common.Communication.SrecType.S9)
					{
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidSrecordData);
					}
				}
				if (srecData.Type == global::Motorola.Common.Communication.SrecType.S3)
				{
					int num5 = data.Length;
					uint num6;
					if (num2 == 0)
					{
						num6 = RamStartAddress;
					}
					else
					{
						uint num7 = (uint)arrayList[num2 - 1];
						uint num8 = (uint)arrayList3[num2 - 1];
						num6 = num7 + num8 + num;
					}
					arrayList3.Add((uint)num5);
					arrayList2.Add(address);
					arrayList.Add(num6);
					global::Motorola.Common.Communication.SequenceManager.RamDataObjectInfo ramDataObjectInfo = new global::Motorola.Common.Communication.SequenceManager.RamDataObjectInfo(num6, num5, address);
					if (ProgressIndicator != null)
					{
						double num9 = (double)num5 / (double)num3;
						int num10 = (int)(100.0 * num9);
						progressInfoObject.startScope = num4;
						progressInfoObject.endScope = num4 + num10;
					}
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Start to write RAM: " + dataRecords.Count, new object[0]);
					bool flag = this.BootExecutor.WriteMemory64KBlocks((int)ramDataObjectInfo.RamAddress, ramDataObjectInfo.NumBytes, data, progressInfoObject, ProgressIndicator);
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("End to write RAM: " + dataRecords.Count, new object[0]);
					if (!flag)
					{
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.WriteMemoryBlocksFailure);
					}
					if (ProgressIndicator != null)
					{
						num4 = progressInfoObject.endScope;
					}
					list.Add(ramDataObjectInfo);
					num2++;
				}
				if (j == dataRecords.Count - 1)
				{
					if (data != null)
					{
						global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.CommonUtil.UtilityMethods.ToHexString(data, 0, data.Length, true), new object[0]);
					}
				}
			}
			return list;
		}

		// Token: 0x06000170 RID: 368 RVA: 0x0000D9E0 File Offset: 0x0000BBE0
		private bool WriteSrecToFlash(global::Motorola.Common.Communication.Srecord record, global::Motorola.Common.Communication.IProgressIndicator ProgressIndicator)
		{
			global::Motorola.Common.Communication.SrecDataCollection dataRecords = record.DataRecords;
			int num = 0;
			global::Motorola.Common.Communication.SequenceManager.ProgressInfoObject progressInfoObject = new global::Motorola.Common.Communication.SequenceManager.ProgressInfoObject();
			int num2 = 0;
			if (ProgressIndicator != null)
			{
				for (int i = 0; i < dataRecords.Count; i++)
				{
					global::Motorola.Common.Communication.SrecData srecData = dataRecords[i];
					num += (int)srecData.DataLen;
				}
			}
			for (int j = 0; j < dataRecords.Count; j++)
			{
				global::Motorola.Common.Communication.SrecData srecData = dataRecords[j];
				uint address = srecData.Address;
				byte[] data = srecData.GetData();
				int num3 = 0;
				if (data != null)
				{
					if (data.Length > 0)
					{
						num3 = data.Length;
					}
				}
				if (data == null)
				{
					if (srecData.Type != global::Motorola.Common.Communication.SrecType.S7 && srecData.Type != global::Motorola.Common.Communication.SrecType.S8 && srecData.Type != global::Motorola.Common.Communication.SrecType.S9)
					{
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidSrecordData);
					}
				}
				if (srecData.Type == global::Motorola.Common.Communication.SrecType.S3)
				{
					if (ProgressIndicator != null)
					{
						double num4 = (double)num3 / (double)num;
						int num5 = (int)(100.0 * num4);
						progressInfoObject.startScope = num2;
						progressInfoObject.endScope = num2 + num5;
					}
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Start to write Flash: " + dataRecords.Count, new object[0]);
					bool flag = this.BootExecutor.WriteMemory64KBlocks((int)address, num3, data, progressInfoObject, ProgressIndicator);
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("End to write Flash: " + dataRecords.Count, new object[0]);
					if (!flag)
					{
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.WriteMemoryBlocksFailure);
					}
					if (ProgressIndicator != null)
					{
						num2 = progressInfoObject.endScope;
					}
				}
			}
			return true;
		}

		// Token: 0x06000171 RID: 369 RVA: 0x0000DBD0 File Offset: 0x0000BDD0
		private bool EraseWriteSrecToFlash(string Filepath, global::Motorola.Common.Communication.IProgressIndicator ProgressIndicator)
		{
			if (string.IsNullOrEmpty(Filepath))
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgument);
			}
			global::Motorola.Common.Communication.Srecord srecord = this.LoadValidateSrecFile(Filepath);
			global::Motorola.Common.Communication.SrecDataCollection dataRecords = srecord.DataRecords;
			for (int i = 0; i < dataRecords.Count; i++)
			{
				global::Motorola.Common.Communication.SrecData srecData = dataRecords[i];
				uint address = srecData.Address;
				byte[] data = srecData.GetData();
				if (data == null || srecData.DataLen <= 0U)
				{
					if (srecData.Type != global::Motorola.Common.Communication.SrecType.S7)
					{
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidSrecordData);
					}
				}
				int num = data.Length;
				uint endAddress = address + (uint)num - 1U;
				if (num > 0)
				{
					if (!this.BootExecutor.EraseFlashMemory(address, endAddress))
					{
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.EraseFlashFailure);
					}
				}
			}
			foreach (global::Motorola.Common.Communication.SrecData srecData in dataRecords)
			{
				global::Motorola.Common.Communication.SrecData srecData;
				uint address = srecData.Address;
				byte[] data = srecData.GetData();
				if (srecData.Type == global::Motorola.Common.Communication.SrecType.S7)
				{
				}
				int num = data.Length;
				if (srecData.Type == global::Motorola.Common.Communication.SrecType.S3)
				{
					if (!this.BootExecutor.WriteMemory64KBlocks((int)address, num, data, null, ProgressIndicator))
					{
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.WriteMemoryBlocksFailure);
					}
				}
			}
			return true;
		}

		// Token: 0x06000172 RID: 370 RVA: 0x0000DD7C File Offset: 0x0000BF7C
		internal void PsdtAccess(global::Motorola.Common.Communication.PsdtAccessAction function, string partitionName, string partID2, ref uint Address)
		{
			try
			{
				if (string.IsNullOrEmpty(partitionName))
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgument);
				}
				if (partID2 == null)
				{
					byte[] array = new byte[4];
					byte[] bytes = array;
					partID2 = global::System.Text.Encoding.ASCII.GetString(bytes);
				}
				uint num = this.BootExecutor.PsdtAccess(function, partitionName, partID2);
				Address = num;
			}
			catch (global::Motorola.Common.CustomException.CommonException)
			{
				throw;
			}
		}

		// Token: 0x06000173 RID: 371 RVA: 0x0000DDF0 File Offset: 0x0000BFF0
		internal virtual void BootDuplicateSetup()
		{
			try
			{
				this.BootExecutor.RemoteDuplicateSetup(global::Motorola.Common.Communication.Rcmp.RemoteDuplicateFunctionType.Enable);
			}
			catch (global::Motorola.Common.CustomException.CommonException)
			{
				throw;
			}
		}

		// Token: 0x06000174 RID: 372 RVA: 0x0000DE24 File Offset: 0x0000C024
		internal virtual void BootDuplicateDisable()
		{
			try
			{
				this.BootExecutor.RemoteDuplicateSetup(global::Motorola.Common.Communication.Rcmp.RemoteDuplicateFunctionType.Disable);
			}
			catch (global::Motorola.Common.CustomException.CommonException)
			{
				throw;
			}
		}

		// Token: 0x06000175 RID: 373 RVA: 0x0000DE58 File Offset: 0x0000C058
		internal virtual void BootCommit(uint[] RamAddressArray, uint[] FlashAddressArray, uint[] PayloadSizeArray, global::Motorola.Common.Communication.Rcmp.BootCommitFunctionType FPGAType, global::Motorola.Common.Communication.IProgressIndicator ProgressIndicator)
		{
			if (!this.BootExecutor.BootCommit(RamAddressArray, FlashAddressArray, PayloadSizeArray, FPGAType, ProgressIndicator))
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.BootCommitFailure);
			}
		}

		// Token: 0x06000176 RID: 374 RVA: 0x0000DE8C File Offset: 0x0000C08C
		private void ResetRadioBoot()
		{
			if (!this.BootExecutor.ResetRadioBoot())
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RadioResetFailure);
			}
		}

		// Token: 0x06000177 RID: 375 RVA: 0x0000DEB8 File Offset: 0x0000C0B8
		internal virtual void ResetRadioNormal()
		{
			if (!this.BootExecutor.ResetRadioNormal())
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RadioResetFailure);
			}
		}

		// Token: 0x06000178 RID: 376 RVA: 0x0000DEE4 File Offset: 0x0000C0E4
		internal virtual void RemoteConnect(ushort deviceID)
		{
			try
			{
				this.BootExecutor.RemoteConnect(deviceID);
			}
			catch (global::Motorola.Common.CustomException.CommonException)
			{
				throw;
			}
		}

		// Token: 0x06000179 RID: 377 RVA: 0x0000DF18 File Offset: 0x0000C118
		internal virtual void RemoteDisconnect()
		{
			try
			{
				this.BootExecutor.RemoteDisconnect();
			}
			catch (global::Motorola.Common.CustomException.CommonException)
			{
				throw;
			}
		}

		// Token: 0x0600017A RID: 378 RVA: 0x0000DF4C File Offset: 0x0000C14C
		internal virtual ushort DiscoverRemoteDevice()
		{
			ushort result;
			try
			{
				ushort num = this.BootExecutor.DiscoverRemoteDevice();
				result = num;
			}
			catch (global::Motorola.Common.CustomException.CommonException)
			{
				throw;
			}
			return result;
		}

		// Token: 0x0600017B RID: 379 RVA: 0x0000DF84 File Offset: 0x0000C184
		protected virtual global::Motorola.Common.Communication.Srecord LoadValidateSrecFile(string srecFile)
		{
			if (string.IsNullOrEmpty(srecFile))
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidSrecordFile);
			}
			global::Motorola.Common.Communication.Srecord result = null;
			global::Motorola.Common.Communication.Srecord srecord = null;
			try
			{
				srecord = new global::Motorola.Common.Communication.Srecord();
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Created Srecord: " + srecord.GetHashCode(), new object[0]);
				srecord.LoadSrecordData(srecFile, this.m_MaxDataPayload, false);
				global::Motorola.Common.Communication.SrecDataCollection dataRecords = srecord.DataRecords;
				int count = dataRecords.Count;
				if (dataRecords == null || count == 0)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidSrecordFile);
				}
				result = srecord;
				srecord = null;
			}
			finally
			{
				if (srecord != null)
				{
					srecord.Dispose();
				}
			}
			return result;
		}

		// Token: 0x0600017C RID: 380 RVA: 0x0000E050 File Offset: 0x0000C250
		private bool BootLoad(global::Motorola.Common.Communication.Srecord record, uint s7Address, global::Motorola.Common.Communication.IProgressIndicator ProgressIndicator)
		{
			if (!this.WriteSrecToFlash(record, ProgressIndicator))
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.WriteRamDownloaderFailure);
			}
			if (!this.BootExecutor.BootJumpExecution(s7Address))
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RamDownloaderExecutionFailure);
			}
			bool result = false;
			int num = 3;
			global::System.Threading.Thread.Sleep(3000);
			while (num-- > 0)
			{
				global::System.Threading.Thread.Sleep(2000);
				try
				{
					result = this.BootExecutor.isRamDloaderRunning();
					break;
				}
				catch (global::System.Exception ex)
				{
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("QueryVersionInfoFailure on Query Ram downloader status: " + ex.Message, new object[0]);
				}
			}
			return result;
		}

		// Token: 0x0600017D RID: 381 RVA: 0x0000E118 File Offset: 0x0000C318
		protected static void WriteRecordsToFile(global::Motorola.Common.Communication.SrecDataCollection dataRecords, string filepath)
		{
			for (int i = 0; i < dataRecords.Count; i++)
			{
				global::Motorola.Common.Communication.SrecData srecData = dataRecords[i];
				uint num = srecData.Address;
				byte[] data = srecData.GetData();
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.SrecLine> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.SrecLine>();
				int num2 = 37;
				int num3 = 32;
				int j = data.Length;
				int num4 = 0;
				global::System.Collections.Generic.List<string> list2 = new global::System.Collections.Generic.List<string>();
				while (j > 0)
				{
					if (j < num3)
					{
						num2 = j + 4 + 1;
					}
					byte[] array = new byte[num2 - 5];
					global::System.Array.Copy(data, num4, array, 0, array.Length);
					byte b = global::Motorola.Common.Communication.SequenceManager.PcrBootOperations.CalculateChecksum(num2, num, array);
					global::Motorola.Common.Communication.SrecLine srecLine = new global::Motorola.Common.Communication.SrecLine(global::Motorola.Common.Communication.SrecType.S3, (byte)num2, num, array, b);
					list.Add(srecLine);
					global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
					stringBuilder.Append(srecLine.Type.ToString());
					stringBuilder.Append(string.Format("{0:X2}", num2));
					stringBuilder.Append(string.Format("{0:X8}", srecLine.Address));
					for (int k = 0; k < array.Length; k++)
					{
						stringBuilder.Append(string.Format("{0:X2}", (int)array[k]));
					}
					stringBuilder.Append(string.Format("{0:X2}", b));
					list2.Add(stringBuilder.ToString());
					num += (uint)num3;
					j -= num3;
					num4 += num3;
				}
				global::System.IO.File.AppendAllLines(filepath, list2);
				global::System.Security.AccessControl.FileSecurity accessControl = global::System.IO.File.GetAccessControl(filepath);
				global::System.Security.Principal.SecurityIdentifier identity = new global::System.Security.Principal.SecurityIdentifier(global::System.Security.Principal.WellKnownSidType.WorldSid, null);
				accessControl.AddAccessRule(new global::System.Security.AccessControl.FileSystemAccessRule(identity, global::System.Security.AccessControl.FileSystemRights.ReadData | global::System.Security.AccessControl.FileSystemRights.ReadExtendedAttributes | global::System.Security.AccessControl.FileSystemRights.ReadAttributes | global::System.Security.AccessControl.FileSystemRights.Delete | global::System.Security.AccessControl.FileSystemRights.ReadPermissions, global::System.Security.AccessControl.AccessControlType.Allow));
				global::System.IO.File.SetAccessControl(filepath, accessControl);
			}
		}

		// Token: 0x0600017E RID: 382 RVA: 0x0000E2EC File Offset: 0x0000C4EC
		private static byte CalculateChecksum(int recordLen, uint address, byte[] record)
		{
			byte b = 0;
			b += (byte)recordLen;
			b += (byte)(address >> 24);
			b += (byte)(address >> 16);
			b += (byte)(address >> 8);
			b += (byte)address;
			byte[] array = new byte[record.Length];
			global::System.Array.Copy(record, array, record.Length);
			if (array != null)
			{
				for (int i = 0; i < array.Length; i++)
				{
					b += array[i];
				}
			}
			return ~b;
		}

		// Token: 0x0600017F RID: 383 RVA: 0x0000E368 File Offset: 0x0000C568
		internal void WriteFPGAImageFileToFlash(global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage> writeImages, global::Motorola.Common.Communication.IProgressIndicator ProgressIndicator)
		{
			try
			{
				int num = 0;
				global::Motorola.Common.Communication.SequenceManager.ProgressInfoObject progressInfoObject = new global::Motorola.Common.Communication.SequenceManager.ProgressInfoObject();
				int num2 = 0;
				if (ProgressIndicator != null)
				{
					foreach (global::Motorola.Common.Communication.Pba.RadioImage radioImage in writeImages)
					{
						global::Motorola.Common.Communication.Pba.PcrMemoryImage pcrMemoryImage = (global::Motorola.Common.Communication.Pba.PcrMemoryImage)radioImage;
						if (string.IsNullOrEmpty(pcrMemoryImage.FilePath))
						{
							throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgument);
						}
						string filePath = pcrMemoryImage.FilePath;
						using (global::System.IO.FileStream fileStream = new global::System.IO.FileStream(filePath, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read))
						{
							num += (int)fileStream.Length;
						}
					}
				}
				foreach (global::Motorola.Common.Communication.Pba.RadioImage radioImage2 in writeImages)
				{
					global::Motorola.Common.Communication.Pba.PcrMemoryImage pcrMemoryImage = (global::Motorola.Common.Communication.Pba.PcrMemoryImage)radioImage2;
					global::Motorola.Common.Communication.Rcmp.BootCommitFunctionType fpgatype;
					global::Motorola.Common.Communication.Rcmp.FpgaOperationID fpgaOptID;
					if (pcrMemoryImage.FileType == global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.CONTROLLER_FPGA)
					{
						fpgatype = global::Motorola.Common.Communication.Rcmp.BootCommitFunctionType.CommitToControllerFPGA;
						fpgaOptID = global::Motorola.Common.Communication.Rcmp.FpgaOperationID.BanditController;
					}
					else
					{
						if (pcrMemoryImage.FileType != global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.WIRELINE_FPGA)
						{
							throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgument);
						}
						fpgatype = global::Motorola.Common.Communication.Rcmp.BootCommitFunctionType.CommitToWirelineFPGA;
						fpgaOptID = global::Motorola.Common.Communication.Rcmp.FpgaOperationID.BanditWireline;
					}
					string filePath = pcrMemoryImage.FilePath;
					byte[] array = null;
					using (global::System.IO.Stream stream = global::Motorola.Common.CommonLib.EnDecryptStreamHelper.Instance.CreateCryptoFlStream(filePath, global::System.IO.FileAccess.Read))
					{
						array = global::Motorola.Common.CommonLib.EnDecryptStreamHelper.Instance.GetBytesFromStream(stream);
					}
					if (ProgressIndicator != null)
					{
						double num3 = (double)array.Length / (double)num;
						int num4 = (int)(100.0 * num3);
						progressInfoObject.startScope = num2;
						progressInfoObject.endScope = num2 + num4;
					}
					if (!this.BootExecutor.WriteMemory64KBlocks(270532608, array.Length, array, progressInfoObject, ProgressIndicator))
					{
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.WriteMemoryBlocksFailure);
					}
					if (ProgressIndicator != null)
					{
						num2 = progressInfoObject.endScope;
					}
					uint[] ramAddressArray = new uint[]
					{
						270532608U
					};
					uint[] array2 = new uint[1];
					uint[] flashAddressArray = array2;
					uint[] payloadSizeArray = new uint[]
					{
						(uint)array.Length
					};
					this.BootCommit(ramAddressArray, flashAddressArray, payloadSizeArray, fpgatype, ProgressIndicator);
					this.ReconfigureFPGA(fpgaOptID);
				}
				if (ProgressIndicator != null)
				{
					ProgressIndicator.UpdateProgress(1.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.BootCommittingDone);
				}
			}
			catch (global::Motorola.Common.CustomException.CommonException systemException)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.FlashFilesToRamFailure, systemException);
			}
		}

		// Token: 0x06000180 RID: 384 RVA: 0x0000E654 File Offset: 0x0000C854
		private void ReconfigureFPGA(global::Motorola.Common.Communication.Rcmp.FpgaOperationID fpgaOptID)
		{
			this.BootExecutor.ResetFPGABoot(fpgaOptID);
		}

		// Token: 0x040000B3 RID: 179
		private const int SrecFile_recordLen = 37;

		// Token: 0x040000B4 RID: 180
		private int m_MaxDataPayload;

		// Token: 0x040000B5 RID: 181
		private global::Motorola.Common.Communication.SequenceManager.PcrBootExecutor BootExecutor;
	}
}
