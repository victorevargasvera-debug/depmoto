using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using Motorola.Common.CommonLib;
using Motorola.Common.Communication.CommonFile;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Pba;
using Motorola.Common.Communication.Rcmp;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.IshHandler
{
	// Token: 0x0200000D RID: 13
	public class IOController : global::Motorola.Common.Communication.IshHandler.IRadioCommand
	{
		// Token: 0x060000A5 RID: 165 RVA: 0x00004C80 File Offset: 0x00002E80
		public global::System.IO.MemoryStream FileRead(ushort filePartition, string filePath, global::Motorola.Common.Communication.IProgressIndicator progressIndicator = null)
		{
			if (string.IsNullOrEmpty(filePath))
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
			}
			uint num = uint.MaxValue;
			global::Motorola.Common.Communication.Rcmp.XcmpFileAccess xcmpFileAccess = new global::Motorola.Common.Communication.Rcmp.XcmpFileAccess(filePartition, 0, 0U, 0U, num, (ushort)filePath.Length, filePath);
			this.m_RcmpWrapper.SendAndReceiveMessage(xcmpFileAccess);
			if (xcmpFileAccess.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				if (progressIndicator != null)
				{
					progressIndicator.IncreaseProcess(1.0);
				}
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.FileAccessFailure);
			}
			num = xcmpFileAccess.FileSize;
			global::System.IO.MemoryStream memoryStream = this.DoDataReadTransfer(num, 3, progressIndicator);
			if (memoryStream == null || memoryStream.Length < (long)((ulong)num))
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.FileReadFailure);
			}
			return memoryStream;
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00004D0C File Offset: 0x00002F0C
		public void FileWrite(ushort FilePartition, string FileName, global::System.IO.Stream File, global::Motorola.Common.Communication.IProgressIndicator progressIndicator = null, bool isFileCompressed = false)
		{
			if (string.IsNullOrEmpty(FileName) || File == null)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
			}
			byte transferType = 1;
			uint optionFlag = 2U;
			ushort pathLength = (ushort)FileName.Length;
			uint num = (uint)File.Length;
			uint fileOffset = 0U;
			if (num == 0U)
			{
				transferType = 5;
			}
			global::Motorola.Common.Communication.Rcmp.XcmpFileAccess xcmpFileAccess = new global::Motorola.Common.Communication.Rcmp.XcmpFileAccess(FilePartition, transferType, optionFlag, fileOffset, num, pathLength, FileName);
			this.m_RcmpWrapper.SendAndReceiveMessage(xcmpFileAccess);
			double num2 = 1.0;
			if (progressIndicator != null)
			{
				progressIndicator.IncreaseProcess(0.01);
				num2 -= 0.01;
			}
			global::Motorola.Common.Communication.XcmpTransferData.DataType transferType2 = isFileCompressed ? global::Motorola.Common.Communication.XcmpTransferData.DataType.CompressFile : global::Motorola.Common.Communication.XcmpTransferData.DataType.File;
			if (xcmpFileAccess.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				this.DoDataWriteTransfer(File, progressIndicator, num, transferType2, num2);
				return;
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.FileAccessFailure);
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00004DC8 File Offset: 0x00002FC8
		public void FileCreate(ushort FilePartition, string FileName)
		{
			if (string.IsNullOrEmpty(FileName))
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
			}
			byte transferType = 5;
			uint optionFlag = 0U;
			ushort pathLength = (ushort)FileName.Length;
			uint fileOffset = 0U;
			global::Motorola.Common.Communication.Rcmp.XcmpFileAccess xcmpFileAccess = new global::Motorola.Common.Communication.Rcmp.XcmpFileAccess(FilePartition, transferType, optionFlag, fileOffset, 0U, pathLength, FileName);
			this.m_RcmpWrapper.SendAndReceiveMessage(xcmpFileAccess);
			if (xcmpFileAccess.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.FileAccessFailure);
			}
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00004E2C File Offset: 0x0000302C
		public void FileDelete(ushort FilePartition, string FileName)
		{
			if (string.IsNullOrEmpty(FileName))
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
			}
			byte transferType = 2;
			uint optionFlag = 0U;
			ushort pathLength = (ushort)FileName.Length;
			uint fileOffset = 0U;
			global::Motorola.Common.Communication.Rcmp.XcmpFileAccess xcmpFileAccess = new global::Motorola.Common.Communication.Rcmp.XcmpFileAccess(FilePartition, 4, optionFlag, 0U, 0U, pathLength, FileName);
			this.m_RcmpWrapper.SendAndReceiveMessage(xcmpFileAccess);
			if (xcmpFileAccess.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				global::Motorola.Common.Communication.Rcmp.XcmpFileAccess xcmpFileAccess2 = new global::Motorola.Common.Communication.Rcmp.XcmpFileAccess(FilePartition, transferType, optionFlag, fileOffset, 0U, pathLength, FileName);
				this.m_RcmpWrapper.SendAndReceiveMessage(xcmpFileAccess2);
				if (xcmpFileAccess2.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.FileAccessFailure);
				}
			}
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00004EB4 File Offset: 0x000030B4
		public void FtlWrite(ushort Partition_ID, global::System.IO.MemoryStream Data, uint OptionFlag, uint Start_ID, uint End_ID, global::Motorola.Common.Communication.IProgressIndicator progressIndicator = null)
		{
			if (Data == null)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
			}
			byte transferType = 1;
			global::Motorola.Common.Communication.Rcmp.XcmpFtlAccess xcmpFtlAccess = new global::Motorola.Common.Communication.Rcmp.XcmpFtlAccess(transferType, Partition_ID, OptionFlag, Start_ID, End_ID);
			this.m_RcmpWrapper.SendAndReceiveMessage(xcmpFtlAccess);
			double num = 1.0;
			if (progressIndicator != null)
			{
				progressIndicator.IncreaseProcess(0.01);
				num -= 0.01;
			}
			if (xcmpFtlAccess.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				this.DoDataWriteTransfer(Data, progressIndicator, (uint)Data.Length, global::Motorola.Common.Communication.XcmpTransferData.DataType.FTL, num);
				return;
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.FileAccessFailure);
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00004F38 File Offset: 0x00003138
		public void NandWrite(ushort Partition_ID, global::System.IO.MemoryStream Data, uint OptionFlag, uint Start_ID, uint End_ID, global::Motorola.Common.Communication.IProgressIndicator progressIndicator = null)
		{
			if (Data == null)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
			}
			byte transferType = 1;
			global::Motorola.Common.Communication.Rcmp.XcmpNandAccess xcmpNandAccess = new global::Motorola.Common.Communication.Rcmp.XcmpNandAccess(transferType, Partition_ID, OptionFlag, Start_ID, End_ID);
			this.m_RcmpWrapper.SendAndReceiveMessage(xcmpNandAccess);
			double num = 1.0;
			if (progressIndicator != null)
			{
				progressIndicator.IncreaseProcess(0.01);
				num -= 0.01;
			}
			if (xcmpNandAccess.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				this.DoDataWriteTransfer(Data, progressIndicator, (uint)Data.Length, global::Motorola.Common.Communication.XcmpTransferData.DataType.Nand, num);
				return;
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.FileAccessFailure);
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00004FBC File Offset: 0x000031BC
		public void NandDelete(ushort Partition_ID, uint OptionFlag, uint Start_ID, uint End_ID, global::Motorola.Common.Communication.IProgressIndicator progressIndicator = null)
		{
			byte transferType = 2;
			global::Motorola.Common.Communication.Rcmp.XcmpNandAccess xcmpNandAccess = new global::Motorola.Common.Communication.Rcmp.XcmpNandAccess(transferType, Partition_ID, OptionFlag, Start_ID, End_ID);
			this.m_RcmpWrapper.SendAndReceiveMessage(xcmpNandAccess);
			double num = 1.0;
			if (progressIndicator != null)
			{
				progressIndicator.IncreaseProcess(0.01);
				num -= 0.01;
			}
			if (xcmpNandAccess.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.FileAccessFailure);
			}
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00005020 File Offset: 0x00003220
		private void DoDataWriteTransfer(global::System.IO.Stream DataToWrite, global::Motorola.Common.Communication.IProgressIndicator progressIndicator, uint transferSize, global::Motorola.Common.Communication.XcmpTransferData.DataType transferType, double subProgressRate)
		{
			ushort num = (ushort)(this.MaxDataTransferSize - global::Motorola.Common.Communication.XcmpTransferData.RequestHeaderLength);
			byte[] array = new byte[(transferSize > (uint)num) ? ((uint)num) : transferSize];
			uint num2 = transferSize;
			ushort num3 = 0;
			DataToWrite.Position = 0L;
			try
			{
				while (num2 > 0U)
				{
					uint num4 = (num2 > (uint)num) ? ((uint)num) : num2;
					if ((long)array.Length != (long)((ulong)num4))
					{
						array = new byte[num4];
					}
					DataToWrite.Read(array, 0, array.Length);
					global::Motorola.Common.Communication.XcmpTransferData xcmpTransferData = new global::Motorola.Common.Communication.XcmpTransferData(num3, (byte)transferType, (ushort)array.Length, array);
					this.m_RcmpWrapper.SendAndReceiveMessage(xcmpTransferData);
					if (progressIndicator != null)
					{
						double num5 = num4 / transferSize * 0.99;
						progressIndicator.IncreaseProcess(num5);
						subProgressRate -= num5;
					}
					if (xcmpTransferData.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
					{
						num3 += 1;
						num2 -= (uint)array.Length;
					}
					else
					{
						if (xcmpTransferData.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.TransferComplete)
						{
							throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.FileTransferDataFailure);
						}
						break;
					}
				}
			}
			finally
			{
				if (progressIndicator != null)
				{
					progressIndicator.IncreaseProcess(subProgressRate);
				}
			}
		}

		// Token: 0x060000AD RID: 173 RVA: 0x0000511C File Offset: 0x0000331C
		public long GetFileOrDirSize(ushort PartitionID, string fileOrDirectoryPath)
		{
			if (string.IsNullOrEmpty(fileOrDirectoryPath))
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
			}
			byte transferType = 4;
			uint optionFlag = 0U;
			uint fileOffset = 0U;
			uint maxValue = uint.MaxValue;
			ushort pathLength = (ushort)fileOrDirectoryPath.Length;
			global::Motorola.Common.Communication.Rcmp.XcmpFileAccess xcmpFileAccess = new global::Motorola.Common.Communication.Rcmp.XcmpFileAccess(PartitionID, transferType, optionFlag, fileOffset, maxValue, pathLength, fileOrDirectoryPath);
			this.m_RcmpWrapper.SendAndReceiveMessage(xcmpFileAccess);
			if (xcmpFileAccess.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.FileAccessFailure);
			}
			return (long)((ulong)xcmpFileAccess.FileSize);
		}

		// Token: 0x060000AE RID: 174 RVA: 0x0000518C File Offset: 0x0000338C
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileListItemStruct> ListDirectoryContents(ushort PartitionID, string directoryPath)
		{
			if (string.IsNullOrEmpty(directoryPath))
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
			}
			global::Motorola.Common.Communication.Rcmp.XcmpFileAccess xcmpFileAccess = new global::Motorola.Common.Communication.Rcmp.XcmpFileAccess(PartitionID, 3, 0U, 0U, uint.MaxValue, (ushort)directoryPath.Length, directoryPath);
			this.m_RcmpWrapper.SendAndReceiveMessage(xcmpFileAccess);
			if (xcmpFileAccess.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.FileAccessFailure);
			}
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileListItemStruct> result;
			using (global::System.IO.MemoryStream memoryStream = this.DoDataReadTransfer(xcmpFileAccess.FileSize, 3, null))
			{
				if (memoryStream.Length < (long)((ulong)xcmpFileAccess.FileSize))
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.FileDirectoryListFailure);
				}
				result = global::Motorola.Common.Communication.Pba.FileListItemStruct.ParseTransferData(memoryStream.ToArray());
			}
			return result;
		}

		// Token: 0x060000AF RID: 175 RVA: 0x0000522C File Offset: 0x0000342C
		public void DeleteFilesOrDirectory(ushort PartitionID, global::System.Collections.Generic.List<string> filePaths)
		{
			foreach (string value in filePaths)
			{
				if (string.IsNullOrEmpty(value))
				{
					throw new global::System.ArgumentNullException();
				}
			}
			byte transferType = 2;
			uint optionFlag = 0U;
			uint fileOffset = 0U;
			uint maxValue = uint.MaxValue;
			foreach (string text in filePaths)
			{
				string text2 = text;
				ushort pathLength = (ushort)text2.Length;
				global::Motorola.Common.Communication.Rcmp.XcmpFileAccess fileDelete = new global::Motorola.Common.Communication.Rcmp.XcmpFileAccess(PartitionID, transferType, optionFlag, fileOffset, maxValue, pathLength, text2);
				int num = this.DeleteFiles(fileDelete, text2);
				if (num != 0)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.FileAccessFailure);
				}
			}
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00005308 File Offset: 0x00003508
		public uint GetFreeSpace(ushort PartitionID, string filePath)
		{
			if (string.IsNullOrEmpty(filePath))
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
			}
			byte transferType = 7;
			uint optionFlag = 0U;
			uint fileOffset = 0U;
			uint maxValue = uint.MaxValue;
			ushort pathLength = (ushort)filePath.Length;
			global::Motorola.Common.Communication.Rcmp.XcmpFileAccess xcmpFileAccess = new global::Motorola.Common.Communication.Rcmp.XcmpFileAccess(PartitionID, transferType, optionFlag, fileOffset, maxValue, pathLength, filePath);
			this.m_RcmpWrapper.SendAndReceiveMessage(xcmpFileAccess);
			if (xcmpFileAccess.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.FileAccessFailure);
			}
			return xcmpFileAccess.FileSize;
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00005378 File Offset: 0x00003578
		private int DeleteFiles(global::Motorola.Common.Communication.Rcmp.XcmpFileAccess FileDelete, string path)
		{
			if (global::System.IO.Path.HasExtension(path))
			{
				if (string.Equals(global::System.IO.Path.GetExtension(path), "*.*", global::System.StringComparison.OrdinalIgnoreCase))
				{
					for (uint num = FileDelete.FileSize; num > 1U; num -= 1U)
					{
						this.m_RcmpWrapper.SendAndReceiveMessage(FileDelete);
						if (FileDelete.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
						{
							return -1;
						}
					}
				}
				else
				{
					this.m_RcmpWrapper.SendAndReceiveMessage(FileDelete);
				}
			}
			else
			{
				this.m_RcmpWrapper.SendAndReceiveMessage(FileDelete);
			}
			if (FileDelete.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				return -1;
			}
			return 0;
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x000053F0 File Offset: 0x000035F0
		private global::System.IO.MemoryStream DoDataReadTransfer(uint fileSize, byte transferType, global::Motorola.Common.Communication.IProgressIndicator progressIndicator)
		{
			byte[] buffer = null;
			ushort num = (ushort)(this.MaxDataTransferSize - global::Motorola.Common.Communication.XcmpTransferData.ReplyHeaderLength);
			uint num2 = fileSize;
			ushort num3 = 0;
			double num4 = 1.0;
			ushort num5 = 0;
			try
			{
				using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream())
				{
					while (num2 > 0U)
					{
						ushort length = (num2 < (uint)num) ? ((ushort)num2) : num;
						global::Motorola.Common.Communication.XcmpTransferData xcmpTransferData = new global::Motorola.Common.Communication.XcmpTransferData(num5, transferType, length, null);
						this.m_RcmpWrapper.SendAndReceiveMessage(xcmpTransferData);
						num5 += 1;
						if (progressIndicator != null)
						{
							double num6 = (double)xcmpTransferData.Length / fileSize;
							progressIndicator.IncreaseProcess(num6);
							num4 -= num6;
						}
						if (xcmpTransferData.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success && xcmpTransferData.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.TransferComplete)
						{
							throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.FileTransferDataFailure);
						}
						memoryStream.Write(xcmpTransferData.Data, 0, (int)xcmpTransferData.Length);
						num2 -= (uint)xcmpTransferData.Length;
						num3 += xcmpTransferData.Length;
						if ((uint)num3 >= fileSize)
						{
							num2 = 0U;
						}
						if (xcmpTransferData.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.TransferComplete)
						{
							break;
						}
					}
					buffer = memoryStream.ToArray();
				}
			}
			finally
			{
				if (progressIndicator != null)
				{
					progressIndicator.IncreaseProcess(num4);
				}
			}
			return new global::System.IO.MemoryStream(buffer);
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x00005524 File Offset: 0x00003724
		// (set) Token: 0x060000B4 RID: 180 RVA: 0x0000552C File Offset: 0x0000372C
		public bool IsCommonFileCrcBigEndian { get; private set; }

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x00005535 File Offset: 0x00003735
		// (set) Token: 0x060000B6 RID: 182 RVA: 0x0000553D File Offset: 0x0000373D
		public int MaxDataTransferSize { get; set; }

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x00005546 File Offset: 0x00003746
		// (set) Token: 0x060000B8 RID: 184 RVA: 0x0000554E File Offset: 0x0000374E
		public global::Motorola.Common.Communication.Rcmp.XcmpComponentSession SessionCommandReply
		{
			get
			{
				return this.sessionCommandReply;
			}
			set
			{
				this.sessionCommandReply = value;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x00005557 File Offset: 0x00003757
		// (set) Token: 0x060000BA RID: 186 RVA: 0x0000555F File Offset: 0x0000375F
		public bool RetryDifferentialWriteNotSupported
		{
			get
			{
				return this.retryDifferentialWriteNotSupported;
			}
			set
			{
				this.retryDifferentialWriteNotSupported = value;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x060000BB RID: 187 RVA: 0x00005568 File Offset: 0x00003768
		// (set) Token: 0x060000BC RID: 188 RVA: 0x00005570 File Offset: 0x00003770
		public bool MisMatchedRadioAndRMSessionId
		{
			get
			{
				return this.misMatchedRadioAndRMSessionId;
			}
			set
			{
				this.misMatchedRadioAndRMSessionId = value;
			}
		}

		// Token: 0x060000BD RID: 189 RVA: 0x0000557C File Offset: 0x0000377C
		public IOController(global::Motorola.Common.Communication.IMessageExecutor rcmpWrapper, int maxPacketSize, bool isCommonFileCrcBigEndian)
		{
			if (rcmpWrapper == null)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
			}
			if (maxPacketSize < 0)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentOutOfRange);
			}
			this.m_RcmpWrapper = rcmpWrapper;
			this.m_MaxPacketSize = maxPacketSize;
			this.MaxDataTransferSize = maxPacketSize;
			this.IsCommonFileCrcBigEndian = isCommonFileCrcBigEndian;
			this.retryDifferentialWriteNotSupported = false;
			this.misMatchedRadioAndRMSessionId = false;
		}

		// Token: 0x060000BE RID: 190 RVA: 0x000055D0 File Offset: 0x000037D0
		public void BundleQueryInfo(global::System.Collections.Generic.ICollection<global::Motorola.Common.Communication.RcmpBaseMessage> rcmpMessages)
		{
			global::Motorola.Common.Communication.Rcmp.XcmpSuperBundle xcmpSuperBundle = new global::Motorola.Common.Communication.Rcmp.XcmpSuperBundle(true);
			foreach (global::Motorola.Common.Communication.RcmpBaseMessage rcmpMessage in rcmpMessages)
			{
				xcmpSuperBundle.AddRcmpMessage(rcmpMessage);
			}
			this.m_RcmpWrapper.SendAndReceiveMessage(xcmpSuperBundle);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x0000562C File Offset: 0x0000382C
		public void EnterProgramMode(byte entry, byte[] data = null)
		{
			global::Motorola.Common.Communication.Rcmp.RcmpIshProgramMode rcmpIshProgramMode;
			if (data == null)
			{
				rcmpIshProgramMode = new global::Motorola.Common.Communication.Rcmp.RcmpIshProgramMode(entry);
			}
			else
			{
				if (data.Length > this.m_MaxPacketSize)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.TooLongOptionalData);
				}
				rcmpIshProgramMode = new global::Motorola.Common.Communication.Rcmp.RcmpIshProgramMode(entry, data);
			}
			this.m_RcmpWrapper.SendAndReceiveMessage(rcmpIshProgramMode);
			if (rcmpIshProgramMode.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.EnterProgramModeFailure);
			}
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00005684 File Offset: 0x00003884
		public bool UpdateProgrammingStatus(global::Motorola.Common.Communication.CommonUtil.ProgrammingStatus status, ushort sessionID)
		{
			bool result;
			try
			{
				global::Motorola.Common.Communication.Rcmp.XcmpComponentSession xcmpComponentSession = new global::Motorola.Common.Communication.Rcmp.XcmpComponentSession(2048, sessionID, (uint)((ushort)status));
				this.m_RcmpWrapper.SendAndReceiveMessage(xcmpComponentSession);
				if (xcmpComponentSession.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
				{
					result = true;
				}
				else
				{
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Update radio status failed, error: {0}", new object[]
					{
						xcmpComponentSession.ReplyResult
					});
					result = false;
				}
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(ex.Message, new object[0]);
				result = false;
			}
			return result;
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x0000570C File Offset: 0x0000390C
		public void ResetRadio()
		{
			global::Motorola.Common.Communication.Rcmp.RcmpRadioReset rcmpRadioReset = new global::Motorola.Common.Communication.Rcmp.RcmpRadioReset();
			this.m_RcmpWrapper.SendAndReceiveMessage(rcmpRadioReset);
			if (rcmpRadioReset.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ResetRadioFailure);
			}
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00005740 File Offset: 0x00003940
		public void ExitProgramMode(byte exit, byte[] data = null)
		{
			global::Motorola.Common.Communication.Rcmp.RcmpIshProgramMode rcmpIshProgramMode;
			if (data == null)
			{
				rcmpIshProgramMode = new global::Motorola.Common.Communication.Rcmp.RcmpIshProgramMode(exit);
			}
			else
			{
				if (data.Length > this.m_MaxPacketSize)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.TooLongOptionalData);
				}
				rcmpIshProgramMode = new global::Motorola.Common.Communication.Rcmp.RcmpIshProgramMode(exit, data);
			}
			this.m_RcmpWrapper.SendAndReceiveMessage(rcmpIshProgramMode);
			if (rcmpIshProgramMode.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ExitProgramModeFailure);
			}
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00005798 File Offset: 0x00003998
		public void EnterBootMode()
		{
			global::Motorola.Common.Communication.Rcmp.XcmpEnterBootMode xcmpEnterBootMode = new global::Motorola.Common.Communication.Rcmp.XcmpEnterBootMode();
			this.m_RcmpWrapper.SendAndReceiveMessage(xcmpEnterBootMode);
			if (xcmpEnterBootMode.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.EnterBootModeFailure);
			}
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x000057CC File Offset: 0x000039CC
		public bool IsLowBattery()
		{
			int num = 0;
			bool flag = true;
			while (flag && num < 3)
			{
				byte[] array = this.QueryRadioStatus(global::Motorola.Common.Communication.Rcmp.RadioStatusCondition.LowBattery);
				if (array == null || array.Length != 1)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.QueryRadioStatusFailure);
				}
				flag = (array[0] == 1);
				if (!flag)
				{
					break;
				}
				num++;
				global::System.Threading.Thread.Sleep(2000);
			}
			return flag;
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00005820 File Offset: 0x00003A20
		private byte[] QueryRadioStatus(global::Motorola.Common.Communication.Rcmp.RadioStatusCondition condition)
		{
			global::Motorola.Common.Communication.Rcmp.RcmpRadioStatus rcmpRadioStatus = new global::Motorola.Common.Communication.Rcmp.RcmpRadioStatus(condition);
			this.m_RcmpWrapper.SendAndReceiveMessage(rcmpRadioStatus);
			if (rcmpRadioStatus.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				return rcmpRadioStatus.Status;
			}
			if (rcmpRadioStatus.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.InvalidParameter)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.QueryRadioStatusInvalidParameter);
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.QueryRadioStatusFailure);
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00005870 File Offset: 0x00003A70
		public byte QueryRadioUpdateStatus()
		{
			global::Motorola.Common.Communication.Rcmp.RcmpRadioStatus rcmpRadioStatus = new global::Motorola.Common.Communication.Rcmp.RcmpRadioStatus(global::Motorola.Common.Communication.Rcmp.RadioStatusCondition.RadioUpdateStatus);
			this.m_RcmpWrapper.SendAndReceiveMessage(rcmpRadioStatus);
			if (rcmpRadioStatus.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				if (rcmpRadioStatus.Status == null || rcmpRadioStatus.Status.Length != 1)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.QueryRadioStatusFailure);
				}
				return rcmpRadioStatus.Status[0];
			}
			else
			{
				if (rcmpRadioStatus.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.InvalidParameter)
				{
					return 0;
				}
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.QueryRadioStatusFailure);
			}
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x000058D8 File Offset: 0x00003AD8
		public byte[] QueryRadioSerialNumber()
		{
			global::Motorola.Common.Communication.Rcmp.RcmpReadWriteSerialNumber rcmpReadWriteSerialNumber = new global::Motorola.Common.Communication.Rcmp.RcmpReadWriteSerialNumber(global::Motorola.Common.Communication.Rcmp.SerialNumberOperationType.ReadRadioSerialNumber, null);
			this.m_RcmpWrapper.SendAndReceiveMessage(rcmpReadWriteSerialNumber);
			if (rcmpReadWriteSerialNumber.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.QueryRadioSerialNumberFailure);
			}
			return rcmpReadWriteSerialNumber.SerialRawBytes;
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00005914 File Offset: 0x00003B14
		public byte[] QueryProductSerialNumber()
		{
			global::Motorola.Common.Communication.Rcmp.RcmpReadWriteSerialNumber rcmpReadWriteSerialNumber = new global::Motorola.Common.Communication.Rcmp.RcmpReadWriteSerialNumber(global::Motorola.Common.Communication.Rcmp.SerialNumberOperationType.ReadProductSerialNumber, null);
			this.m_RcmpWrapper.SendAndReceiveMessage(rcmpReadWriteSerialNumber);
			if (rcmpReadWriteSerialNumber.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.QueryRadioSerialNumberFailure);
			}
			return rcmpReadWriteSerialNumber.SerialRawBytes;
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00005950 File Offset: 0x00003B50
		public string QueryRadioModelNumber()
		{
			global::Motorola.Common.Communication.Rcmp.RcmpReadWriteModelNumber rcmpReadWriteModelNumber = new global::Motorola.Common.Communication.Rcmp.RcmpReadWriteModelNumber(0, null);
			this.m_RcmpWrapper.SendAndReceiveMessage(rcmpReadWriteModelNumber);
			if (rcmpReadWriteModelNumber.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.QueryRadioModelNumberFailure);
			}
			return rcmpReadWriteModelNumber.ModelNumber;
		}

		// Token: 0x060000CA RID: 202 RVA: 0x0000598C File Offset: 0x00003B8C
		public uint QueryRadioAvailableMemory()
		{
			global::Motorola.Common.Communication.Rcmp.XcmpCodeplugAttribute xcmpCodeplugAttribute = new global::Motorola.Common.Communication.Rcmp.XcmpCodeplugAttribute(global::Motorola.Common.Communication.Rcmp.CodeplugAttributeOperation.Read, global::Motorola.Common.Communication.Rcmp.CodeplugAttributeType.TotalAllowableMemory, null);
			this.m_RcmpWrapper.SendAndReceiveMessage(xcmpCodeplugAttribute);
			if (xcmpCodeplugAttribute.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.QueryCodeplugAttributeFailure);
			}
			return xcmpCodeplugAttribute.TotalAllowableMemory;
		}

		// Token: 0x060000CB RID: 203 RVA: 0x000059C8 File Offset: 0x00003BC8
		public byte QueryRadioRegion()
		{
			global::Motorola.Common.Communication.Rcmp.XcmpCodeplugAttribute xcmpCodeplugAttribute = new global::Motorola.Common.Communication.Rcmp.XcmpCodeplugAttribute(global::Motorola.Common.Communication.Rcmp.CodeplugAttributeOperation.Read, global::Motorola.Common.Communication.Rcmp.CodeplugAttributeType.RegionalInformation, null);
			this.m_RcmpWrapper.SendAndReceiveMessage(xcmpCodeplugAttribute);
			if (xcmpCodeplugAttribute.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.QueryCodeplugAttributeFailure);
			}
			return xcmpCodeplugAttribute.RegionalInformation;
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00005A04 File Offset: 0x00003C04
		public string QueryRadioTanapaNumberByIsh(byte partition, ushort type, ushort id, ushort length, ushort offset)
		{
			global::Motorola.Common.Communication.Rcmp.RcmpReadIshItem rcmpReadIshItem = new global::Motorola.Common.Communication.Rcmp.RcmpReadIshItem(partition, type, id, length, offset);
			this.m_RcmpWrapper.SendAndReceiveMessage(rcmpReadIshItem);
			if (rcmpReadIshItem.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ReadIshItemFailure);
			}
			return global::System.Text.Encoding.Default.GetString(rcmpReadIshItem.Data);
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00005A50 File Offset: 0x00003C50
		public byte[] QueryBanditEEPROMByIsh(byte partition, ushort type, ushort id, ushort length, ushort offset)
		{
			global::Motorola.Common.Communication.Rcmp.RcmpReadIshItem rcmpReadIshItem = new global::Motorola.Common.Communication.Rcmp.RcmpReadIshItem(partition, type, id, length, offset);
			this.m_RcmpWrapper.SendAndReceiveMessage(rcmpReadIshItem);
			if (rcmpReadIshItem.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ReadIshItemFailure);
			}
			return rcmpReadIshItem.Data;
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00005A90 File Offset: 0x00003C90
		public byte QueryRadioRegionByIsh(byte partition, ushort type, ushort id, ushort offset)
		{
			global::Motorola.Common.Communication.Rcmp.RcmpReadIshItem rcmpReadIshItem = new global::Motorola.Common.Communication.Rcmp.RcmpReadIshItem(partition, type, id, 1, offset);
			this.m_RcmpWrapper.SendAndReceiveMessage(rcmpReadIshItem);
			if (rcmpReadIshItem.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ReadIshItemFailure);
			}
			return rcmpReadIshItem.Data[0];
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00005AD0 File Offset: 0x00003CD0
		public bool Is32MPlatform()
		{
			global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation rcmpVersionInformation = new global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation(global::Motorola.Common.Communication.Rcmp.VersionInfoType.FlashSize);
			this.m_RcmpWrapper.SendAndReceiveMessage(rcmpVersionInformation);
			if (rcmpVersionInformation.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.QueryVersionInfoFailure);
			}
			return rcmpVersionInformation.FlashSizeType == global::Motorola.Common.Communication.Rcmp.FlashSizeType.FlashSize32M;
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00005B10 File Offset: 0x00003D10
		public bool IsDualBoard()
		{
			global::Motorola.Common.Communication.Rcmp.RcmpDiscoverRemoteDevice rcmpDiscoverRemoteDevice = new global::Motorola.Common.Communication.Rcmp.RcmpDiscoverRemoteDevice();
			this.m_RcmpWrapper.SendAndReceiveMessage(rcmpDiscoverRemoteDevice);
			if (rcmpDiscoverRemoteDevice.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				return true;
			}
			if (rcmpDiscoverRemoteDevice.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.OpcodeNotSupported)
			{
				return false;
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RemoteDeviceDiscoveryFailure);
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00005B50 File Offset: 0x00003D50
		public byte QuerySecurityCapability()
		{
			global::Motorola.Common.Communication.Rcmp.XcmpCodeplugAttribute xcmpCodeplugAttribute = new global::Motorola.Common.Communication.Rcmp.XcmpCodeplugAttribute(global::Motorola.Common.Communication.Rcmp.CodeplugAttributeOperation.Read, global::Motorola.Common.Communication.Rcmp.CodeplugAttributeType.CertificateSupportedID, null);
			this.m_RcmpWrapper.SendAndReceiveMessage(xcmpCodeplugAttribute);
			if (xcmpCodeplugAttribute.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				return 0;
			}
			return xcmpCodeplugAttribute.SecurityCapability;
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00005B84 File Offset: 0x00003D84
		public global::Motorola.Common.Communication.CommonUtil.SecureConnectionInfo QueryIPandPort()
		{
			global::Motorola.Common.Communication.CommonUtil.SecureConnectionInfo secureConnectionInfo = new global::Motorola.Common.Communication.CommonUtil.SecureConnectionInfo();
			global::Motorola.Common.Communication.Rcmp.XcmpSecureConnect xcmpSecureConnect = new global::Motorola.Common.Communication.Rcmp.XcmpSecureConnect(global::Motorola.Common.Communication.Rcmp.FuctionOperation.ReadIpandPort);
			this.m_RcmpWrapper.SendAndReceiveMessage(xcmpSecureConnect);
			if (xcmpSecureConnect.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ReadIPAndPortFailure);
			}
			secureConnectionInfo.RadioIP = xcmpSecureConnect.RadioIP;
			secureConnectionInfo.RadioPort = xcmpSecureConnect.RadioPort;
			return secureConnectionInfo;
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00005BD8 File Offset: 0x00003DD8
		public byte[] QueryRemoteSerialNumber()
		{
			global::Motorola.Common.Communication.Rcmp.RcmpReadWriteSerialNumber rcmpReadWriteSerialNumber = new global::Motorola.Common.Communication.Rcmp.RcmpReadWriteSerialNumber(global::Motorola.Common.Communication.Rcmp.SerialNumberOperationType.ReadProductSerialNumber, null);
			try
			{
				ushort deviceId = this.DiscoverRemoteDevice();
				this.RemoteConnect(deviceId);
				this.m_RcmpWrapper.SendAndReceiveMessage(rcmpReadWriteSerialNumber);
				if (rcmpReadWriteSerialNumber.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.QueryRadioSerialNumberFailure);
				}
			}
			catch (global::System.Exception)
			{
				throw;
			}
			finally
			{
				this.RemoteDisconnect();
			}
			return rcmpReadWriteSerialNumber.SerialRawBytes;
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00005C4C File Offset: 0x00003E4C
		public ushort DiscoverRemoteDevice()
		{
			global::Motorola.Common.Communication.Rcmp.RcmpDiscoverRemoteDevice rcmpDiscoverRemoteDevice = new global::Motorola.Common.Communication.Rcmp.RcmpDiscoverRemoteDevice();
			this.m_RcmpWrapper.SendAndReceiveMessage(rcmpDiscoverRemoteDevice);
			if (rcmpDiscoverRemoteDevice.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RemoteDeviceDiscoveryFailure);
			}
			return rcmpDiscoverRemoteDevice.BusID;
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00005C88 File Offset: 0x00003E88
		public bool RemoteConnect(ushort deviceId)
		{
			global::Motorola.Common.Communication.Rcmp.RcmpRemoteConnect rcmpRemoteConnect = new global::Motorola.Common.Communication.Rcmp.RcmpRemoteConnect(deviceId);
			this.m_RcmpWrapper.SendAndReceiveMessage(rcmpRemoteConnect);
			if (rcmpRemoteConnect.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RemoteConnectFailure);
			}
			return true;
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00005CBC File Offset: 0x00003EBC
		public bool RemoteDisconnect()
		{
			global::Motorola.Common.Communication.Rcmp.RcmpRemoteDisconnect rcmpRemoteDisconnect = new global::Motorola.Common.Communication.Rcmp.RcmpRemoteDisconnect();
			this.m_RcmpWrapper.SendAndReceiveMessage(rcmpRemoteDisconnect);
			if (rcmpRemoteDisconnect.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RemoteDisconnectFailure);
			}
			return true;
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00005CF0 File Offset: 0x00003EF0
		public string QueryRepeaterMacAddress()
		{
			global::Motorola.Common.Communication.Rcmp.RcmpReadWriteSerialNumber rcmpReadWriteSerialNumber = new global::Motorola.Common.Communication.Rcmp.RcmpReadWriteSerialNumber(global::Motorola.Common.Communication.Rcmp.SerialNumberOperationType.ReadMACAddress, null);
			this.m_RcmpWrapper.SendAndReceiveMessage(rcmpReadWriteSerialNumber);
			if (rcmpReadWriteSerialNumber.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				return global::System.BitConverter.ToString(rcmpReadWriteSerialNumber.SerialRawBytes);
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.QueryRadioSerialNumberFailure);
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00005D30 File Offset: 0x00003F30
		public string GetMacAddressByPort(global::Motorola.Common.Communication.Rcmp.MacAddressPort port)
		{
			global::Motorola.Common.Communication.Rcmp.XcmpModuleInfo.FunctionType function = global::Motorola.Common.Communication.Rcmp.XcmpModuleInfo.FunctionType.Read;
			global::Motorola.Common.Communication.Rcmp.XcmpModuleInfo.ModuleID modeleID = global::Motorola.Common.Communication.Rcmp.XcmpModuleInfo.ModuleID.Modem;
			global::Motorola.Common.Communication.Rcmp.XcmpModuleInfo.DataType dataType = global::Motorola.Common.Communication.Rcmp.XcmpModuleInfo.DataType.MACAddress;
			byte datasize = 1;
			byte[] dataValue = new byte[1];
			global::Motorola.Common.Communication.Rcmp.XcmpModuleInfo xcmpModuleInfo = new global::Motorola.Common.Communication.Rcmp.XcmpModuleInfo(function, modeleID, dataType, datasize, dataValue);
			this.m_RcmpWrapper.SendAndReceiveMessage(xcmpModuleInfo);
			string result = string.Empty;
			if (port == global::Motorola.Common.Communication.Rcmp.MacAddressPort.PORT1)
			{
				result = xcmpModuleInfo.MacAddressPort1;
			}
			else
			{
				result = xcmpModuleInfo.MacAddressPort2;
			}
			return result;
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00005D78 File Offset: 0x00003F78
		public string GetWLANMacAddress(global::Motorola.Common.Communication.Rcmp.MacAddressPort port)
		{
			global::Motorola.Common.Communication.Rcmp.XcmpModuleInfo.FunctionType function = global::Motorola.Common.Communication.Rcmp.XcmpModuleInfo.FunctionType.Read;
			global::Motorola.Common.Communication.Rcmp.XcmpModuleInfo.ModuleID modeleID = global::Motorola.Common.Communication.Rcmp.XcmpModuleInfo.ModuleID.ExpansionBoard;
			global::Motorola.Common.Communication.Rcmp.XcmpModuleInfo.DataType dataType = global::Motorola.Common.Communication.Rcmp.XcmpModuleInfo.DataType.MACAddress;
			byte datasize = 1;
			byte[] dataValue = new byte[1];
			global::Motorola.Common.Communication.Rcmp.XcmpModuleInfo xcmpModuleInfo = new global::Motorola.Common.Communication.Rcmp.XcmpModuleInfo(function, modeleID, dataType, datasize, dataValue);
			this.m_RcmpWrapper.SendAndReceiveMessage(xcmpModuleInfo);
			string result = string.Empty;
			if (port == global::Motorola.Common.Communication.Rcmp.MacAddressPort.PORT1)
			{
				result = xcmpModuleInfo.WIFIMacAddressPort1;
			}
			else
			{
				result = xcmpModuleInfo.WIFIMacAddressPort2;
			}
			return result;
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00005DC0 File Offset: 0x00003FC0
		public byte[] QueryRadioPhysicalSerialNumber()
		{
			global::Motorola.Common.Communication.Rcmp.RcmpRadioStatus rcmpRadioStatus = new global::Motorola.Common.Communication.Rcmp.RcmpRadioStatus(global::Motorola.Common.Communication.Rcmp.RadioStatusCondition.PhysicalSerialNumber);
			this.m_RcmpWrapper.SendAndReceiveMessage(rcmpRadioStatus);
			if (rcmpRadioStatus.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				return null;
			}
			return rcmpRadioStatus.Status;
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00005DF4 File Offset: 0x00003FF4
		public global::Motorola.Common.Communication.CommonUtil.FPGAStatus QueryFPGAControllerStatus()
		{
			byte[] array = this.QueryRadioStatus(global::Motorola.Common.Communication.Rcmp.RadioStatusCondition.AlternativeImageStatusOfBanditControllerFPGA);
			if (array == null || array.Length != 1)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.QueryRadioStatusFailure);
			}
			return (global::Motorola.Common.Communication.CommonUtil.FPGAStatus)array[0];
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00005E24 File Offset: 0x00004024
		public global::Motorola.Common.Communication.CommonUtil.FPGAStatus QueryFPGAWirelineStatus()
		{
			byte[] array = this.QueryRadioStatus(global::Motorola.Common.Communication.Rcmp.RadioStatusCondition.AlternativeImageStatusOfBanditWirelineFPGA);
			if (array == null || array.Length != 1)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.QueryRadioStatusFailure);
			}
			return (global::Motorola.Common.Communication.CommonUtil.FPGAStatus)array[0];
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00005E54 File Offset: 0x00004054
		public bool IsWirelineAvailable()
		{
			byte[] array = this.QueryRadioStatus(global::Motorola.Common.Communication.Rcmp.RadioStatusCondition.BanditWirelineBoardAvailable);
			if (array == null || array.Length != 1)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.QueryRadioStatusFailure);
			}
			return array[0] == 1;
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00005E84 File Offset: 0x00004084
		public bool IsDspCapabilityEnabled()
		{
			bool isDspCapabilityEnabled;
			try
			{
				global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation rcmpVersionInformation = new global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation(global::Motorola.Common.Communication.Rcmp.VersionInfoType.DspCapability);
				this.m_RcmpWrapper.SendAndReceiveMessage(rcmpVersionInformation);
				if (rcmpVersionInformation.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.QueryVersionInfoFailure);
				}
				isDspCapabilityEnabled = rcmpVersionInformation.IsDspCapabilityEnabled;
			}
			catch
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Query Dsp Capability [{0}] Failure", new object[]
				{
					global::Motorola.Common.Communication.Rcmp.VersionInfoType.DspCapability.ToString()
				});
				throw;
			}
			return isDspCapabilityEnabled;
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00005EFC File Offset: 0x000040FC
		public bool IsDTPCapabilityEnabled()
		{
			bool result;
			try
			{
				global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation rcmpVersionInformation = new global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation(global::Motorola.Common.Communication.Rcmp.VersionInfoType.DTPCapability);
				this.m_RcmpWrapper.SendAndReceiveMessage(rcmpVersionInformation);
				if (rcmpVersionInformation.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.QueryVersionInfoFailure);
				}
				result = rcmpVersionInformation.IsDtpCapabilityEnabled();
			}
			catch
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Query Dtp Capability [{0}] Failure", new object[]
				{
					global::Motorola.Common.Communication.Rcmp.VersionInfoType.DTPCapability.ToString()
				});
				throw;
			}
			return result;
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00005F74 File Offset: 0x00004174
		public string QueryFPGAControllerAlternativeVersion()
		{
			return this.QueryFPGAVersion(global::Motorola.Common.Communication.Rcmp.VersionInfoType.FPGAControllerAlternativeVersion);
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00005F81 File Offset: 0x00004181
		public string QueryFPGAControllerFactoryVersion()
		{
			return this.QueryFPGAVersion(global::Motorola.Common.Communication.Rcmp.VersionInfoType.FPGAControllerFactoryVersion);
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00005F8E File Offset: 0x0000418E
		public string QueryFPGAControllerActiveVersion()
		{
			return this.QueryFPGAVersion(global::Motorola.Common.Communication.Rcmp.VersionInfoType.FPGAControllerActiveVersion);
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00005F9B File Offset: 0x0000419B
		public string QueryFPGAWirelineAlternativeVersion()
		{
			return this.QueryFPGAVersion(global::Motorola.Common.Communication.Rcmp.VersionInfoType.FPGAWirelineAlternativeVersion);
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00005FA8 File Offset: 0x000041A8
		public string QueryFPGAWirelineFactoryVersion()
		{
			return this.QueryFPGAVersion(global::Motorola.Common.Communication.Rcmp.VersionInfoType.FPGAWirelineFactoryVersion);
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00005FB5 File Offset: 0x000041B5
		public string QueryFPGAWirelineActiveVersion()
		{
			return this.QueryFPGAVersion(global::Motorola.Common.Communication.Rcmp.VersionInfoType.FPGAWirelineActiveVersion);
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00005FC4 File Offset: 0x000041C4
		private string QueryFPGAVersion(global::Motorola.Common.Communication.Rcmp.VersionInfoType type)
		{
			string result;
			try
			{
				global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation rcmpVersionInformation = new global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation(type);
				this.m_RcmpWrapper.SendAndReceiveMessage(rcmpVersionInformation);
				if (rcmpVersionInformation.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.QueryVersionInfoFailure);
				}
				result = rcmpVersionInformation.FPGAVersionInformation;
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Query FPGA Version [{0}] Failure {1}", new object[]
				{
					type.ToString(),
					ex.ToString()
				});
				result = string.Empty;
			}
			return result;
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00006048 File Offset: 0x00004248
		public void SendFPGAErase(global::Motorola.Common.Communication.Rcmp.FpgaOperationID fpgaID)
		{
			int num = 0;
			bool flag = false;
			while (!flag && num < 3)
			{
				global::Motorola.Common.Communication.Rcmp.FpgaOperation fpgaOperation = new global::Motorola.Common.Communication.Rcmp.FpgaOperation(global::Motorola.Common.Communication.Rcmp.FPGAOperationType.Erase, fpgaID);
				this.m_RcmpWrapper.SendAndReceiveMessage(fpgaOperation);
				if (fpgaOperation.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.EraseFpgaFailure);
				}
				global::System.Threading.Thread.Sleep(1000);
				int num2 = 0;
				while (!flag && num2 < 3)
				{
					global::Motorola.Common.Communication.Rcmp.FpgaOperation fpgaOperation2 = new global::Motorola.Common.Communication.Rcmp.FpgaOperation(global::Motorola.Common.Communication.Rcmp.FPGAOperationType.EraseStatus, fpgaID);
					this.m_RcmpWrapper.SendAndReceiveMessage(fpgaOperation2);
					if (fpgaOperation2.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
					{
						flag = true;
					}
					else if (fpgaOperation2.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.LockSequenceFailure)
					{
						global::System.Threading.Thread.Sleep(1000);
					}
					else
					{
						num2++;
					}
				}
				num++;
			}
			if (!flag)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.EraseFpgaFailure);
			}
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x000060F8 File Offset: 0x000042F8
		public void SendFPGAReset(global::Motorola.Common.Communication.Rcmp.FpgaOperationID fpgaID)
		{
			global::Motorola.Common.Communication.Rcmp.FpgaOperation fpgaOperation = new global::Motorola.Common.Communication.Rcmp.FpgaOperation(global::Motorola.Common.Communication.Rcmp.FPGAOperationType.Reconfigure, fpgaID);
			this.m_RcmpWrapper.SendAndReceiveMessage(fpgaOperation);
			if (fpgaOperation.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ResetFpgaFailure);
			}
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x0000612C File Offset: 0x0000432C
		public string QueryCodeplugVersion()
		{
			return this.QueryVersion(global::Motorola.Common.Communication.Rcmp.VersionInfoType.CodeplugVersion);
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00006136 File Offset: 0x00004336
		public string QuerySecurityVersion()
		{
			return this.QueryVersion(global::Motorola.Common.Communication.Rcmp.VersionInfoType.SecurityVersion);
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00006140 File Offset: 0x00004340
		public string QuerySoftwareVersion()
		{
			return this.QueryVersion(global::Motorola.Common.Communication.Rcmp.VersionInfoType.HostSoftwareVersion);
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00006149 File Offset: 0x00004349
		public string QueryBootloaderVersion()
		{
			return this.QueryVersion(global::Motorola.Common.Communication.Rcmp.VersionInfoType.FlashBootAppVersion);
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00006153 File Offset: 0x00004353
		public string QueryL3BootloaderVersion()
		{
			return this.QueryVersion(global::Motorola.Common.Communication.Rcmp.VersionInfoType.L3BootloaderVersion);
		}

		// Token: 0x060000EE RID: 238 RVA: 0x0000615D File Offset: 0x0000435D
		public string QueryConfigurationVersion()
		{
			return this.QueryVersion(global::Motorola.Common.Communication.Rcmp.VersionInfoType.ConfigurationVersion);
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00006167 File Offset: 0x00004367
		public string QueryKernelVersion()
		{
			return this.QueryVersion(global::Motorola.Common.Communication.Rcmp.VersionInfoType.KernelVersion);
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00006174 File Offset: 0x00004374
		public byte[] QueryRadioUUID()
		{
			global::Motorola.Common.Communication.Rcmp.RcmpReadUUID rcmpReadUUID = new global::Motorola.Common.Communication.Rcmp.RcmpReadUUID();
			this.m_RcmpWrapper.SendAndReceiveMessage(rcmpReadUUID);
			if (rcmpReadUUID.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.QueryRadioUUIDFailure);
			}
			return rcmpReadUUID.UUID;
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x000061AC File Offset: 0x000043AC
		public string QueryPsdtVersion()
		{
			return this.QueryVersion(global::Motorola.Common.Communication.Rcmp.VersionInfoType.PsdtVersion);
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x000061B8 File Offset: 0x000043B8
		private string QueryVersion(global::Motorola.Common.Communication.Rcmp.VersionInfoType type)
		{
			global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation rcmpVersionInformation = new global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation(type);
			this.m_RcmpWrapper.SendAndReceiveMessage(rcmpVersionInformation);
			if (rcmpVersionInformation.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				return rcmpVersionInformation.VersionInformation;
			}
			if (rcmpVersionInformation.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.InvalidParameter)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidRCMPParameter);
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.QueryVersionInfoFailure);
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00006204 File Offset: 0x00004404
		public uint GetAvailabeSpaceForLanguagePack()
		{
			global::Motorola.Common.Communication.Rcmp.XcmpReadLanguagePackInfo xcmpReadLanguagePackInfo = new global::Motorola.Common.Communication.Rcmp.XcmpReadLanguagePackInfo(global::Motorola.Common.Communication.Rcmp.ReadLanguagePackInfoOperation.AllLanguagePack, null);
			this.m_RcmpWrapper.SendAndReceiveMessage(xcmpReadLanguagePackInfo);
			if (xcmpReadLanguagePackInfo.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ReadLanguagePackInfoFailure);
			}
			return xcmpReadLanguagePackInfo.AvailableSpace;
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00006240 File Offset: 0x00004440
		public void AddLanguagePack(global::Motorola.Common.Communication.Rcmp.LanguagePackControlOperation operation, string languagePackID, byte[] languagePackPayloadUnit, bool bigEndianForPackID)
		{
			if ((operation == global::Motorola.Common.Communication.Rcmp.LanguagePackControlOperation.AddLanguagePackStart && string.IsNullOrEmpty(languagePackID)) || (operation == global::Motorola.Common.Communication.Rcmp.LanguagePackControlOperation.AddLanguagePackUnit && languagePackPayloadUnit == null))
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgument);
			}
			global::Motorola.Common.Communication.Rcmp.XcmpWriteLanguagePack xcmpWriteLanguagePack = new global::Motorola.Common.Communication.Rcmp.XcmpWriteLanguagePack(operation, languagePackID, languagePackPayloadUnit, bigEndianForPackID);
			this.m_RcmpWrapper.SendAndReceiveMessage(xcmpWriteLanguagePack);
			if (xcmpWriteLanguagePack.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.AddLanguagePackFailure);
			}
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00006290 File Offset: 0x00004490
		public void DeleteLanguagePack(string languagePackID, bool bigEndianForPackID)
		{
			int num = 3;
			global::Motorola.Common.Communication.RcmpReplyResult rcmpReplyResult = global::Motorola.Common.Communication.RcmpReplyResult.Failure;
			if (string.IsNullOrEmpty(languagePackID))
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgument);
			}
			while (rcmpReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success && num-- >= 0)
			{
				global::Motorola.Common.Communication.Rcmp.XcmpDeleteLanguagePack xcmpDeleteLanguagePack = new global::Motorola.Common.Communication.Rcmp.XcmpDeleteLanguagePack(languagePackID, bigEndianForPackID);
				this.m_RcmpWrapper.SendAndReceiveMessage(xcmpDeleteLanguagePack);
				rcmpReplyResult = xcmpDeleteLanguagePack.ReplyResult;
			}
			if (rcmpReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.DeleteLanguagePackFailure);
			}
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x000062E4 File Offset: 0x000044E4
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo> ReadLanguagePackInfo()
		{
			uint num;
			return this.ReadLanguagePackInfo(out num);
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x000062FC File Offset: 0x000044FC
		public global::Motorola.Common.Communication.Pba.LanguagePackData ReadLanguagePackData()
		{
			uint availableSpace;
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo> list = this.ReadLanguagePackInfo(out availableSpace);
			global::Motorola.Common.Communication.Pba.LanguagePackData languagePackData = new global::Motorola.Common.Communication.Pba.LanguagePackData();
			languagePackData.AvailableSpace = availableSpace;
			if (list != null)
			{
				foreach (global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo pcrLanguagePackInfo in list)
				{
					if (pcrLanguagePackInfo.Size > 0U)
					{
						languagePackData.LanguagePacks.Add(pcrLanguagePackInfo);
					}
				}
			}
			return languagePackData;
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00006380 File Offset: 0x00004580
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo> ReadLanguagePackInfo(out uint availableSpace)
		{
			global::Motorola.Common.Communication.Rcmp.XcmpReadLanguagePackInfo xcmpReadLanguagePackInfo = new global::Motorola.Common.Communication.Rcmp.XcmpReadLanguagePackInfo(global::Motorola.Common.Communication.Rcmp.ReadLanguagePackInfoOperation.AllLanguagePack, null);
			this.m_RcmpWrapper.SendAndReceiveMessage(xcmpReadLanguagePackInfo);
			if (xcmpReadLanguagePackInfo.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ReadLanguagePackInfoFailure);
			}
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo>(xcmpReadLanguagePackInfo.LanguagePackInfo.Count);
			foreach (global::Motorola.Common.Communication.Rcmp.LanguagePackInfo languagePackInfo in xcmpReadLanguagePackInfo.LanguagePackInfo)
			{
				global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo pcrLanguagePackInfo = new global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo();
				char[] trimChars = new char[]
				{
					'\0',
					' ',
					'\r',
					'\n'
				};
				string text = languagePackInfo.PackID.TrimEnd(trimChars);
				int num = text.IndexOf('\0');
				if (num == -1)
				{
					pcrLanguagePackInfo.PackID = text;
				}
				else
				{
					pcrLanguagePackInfo.PackID = text.Substring(0, num);
				}
				pcrLanguagePackInfo.Name = languagePackInfo.Name;
				pcrLanguagePackInfo.Size = languagePackInfo.Size;
				pcrLanguagePackInfo.MajorVersion = languagePackInfo.MajorVersion;
				pcrLanguagePackInfo.MinorVersion = languagePackInfo.MinorVersion;
				list.Add(pcrLanguagePackInfo);
			}
			availableSpace = xcmpReadLanguagePackInfo.AvailableSpace;
			return list;
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x0000649C File Offset: 0x0000469C
		public void WriteLanguagePack(global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo languagePack, int maxXcmpPacketSize, bool bigEndianForPackID, global::Motorola.Common.Communication.IProgressIndicator progressIndicator)
		{
			try
			{
				if (progressIndicator != null)
				{
					progressIndicator.UpdateProgress(0.0);
				}
				this.AddLanguagePack(global::Motorola.Common.Communication.Rcmp.LanguagePackControlOperation.AddLanguagePackStart, languagePack.PackID, null, bigEndianForPackID);
				double num = 1.0;
				if (progressIndicator != null)
				{
					progressIndicator.IncreaseProcess(0.1);
					num -= 0.1;
				}
				using (global::System.IO.Stream stream = global::Motorola.Common.CommonLib.EnDecryptStreamHelper.Instance.CreateCryptoFlStream(languagePack.PackFilePath, global::System.IO.FileAccess.Read))
				{
					byte[] bytesFromStream = global::Motorola.Common.CommonLib.EnDecryptStreamHelper.Instance.GetBytesFromStream(stream, global::System.Text.Encoding.UTF8);
					int i = bytesFromStream.Length;
					int num2 = 0;
					while (i > 0)
					{
						int num3;
						if (i > maxXcmpPacketSize - 100)
						{
							num3 = maxXcmpPacketSize - 100;
						}
						else
						{
							num3 = i;
						}
						byte[] array = new byte[num3];
						global::System.Array.Copy(bytesFromStream, num2, array, 0, num3);
						this.AddLanguagePack(global::Motorola.Common.Communication.Rcmp.LanguagePackControlOperation.AddLanguagePackUnit, null, array, bigEndianForPackID);
						if (progressIndicator != null)
						{
							progressIndicator.IncreaseProcess(num * (double)num3 / (double)i);
						}
						num2 += num3;
						i -= num3;
					}
				}
				this.AddLanguagePack(global::Motorola.Common.Communication.Rcmp.LanguagePackControlOperation.AddLanguagePackEnd, null, null, bigEndianForPackID);
			}
			finally
			{
				if (progressIndicator != null)
				{
					progressIndicator.UpdateProgress(1.0);
				}
			}
		}

		// Token: 0x060000FA RID: 250 RVA: 0x000065C4 File Offset: 0x000047C4
		private void AddTTSLanguagePack(global::Motorola.Common.Communication.Rcmp.TTSLanguagePackControlOperation operation, string languagePackID, byte[] languagePackPayloadUnit, bool bigEndianForPackID)
		{
			if ((operation == global::Motorola.Common.Communication.Rcmp.TTSLanguagePackControlOperation.AddTTSLanguagePackStart && string.IsNullOrEmpty(languagePackID)) || (operation == global::Motorola.Common.Communication.Rcmp.TTSLanguagePackControlOperation.AddTTSLanguagePackUnit && languagePackPayloadUnit == null))
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgument);
			}
			global::Motorola.Common.Communication.Rcmp.XcmpWriteTTSLanguagePack xcmpWriteTTSLanguagePack = new global::Motorola.Common.Communication.Rcmp.XcmpWriteTTSLanguagePack(operation, languagePackID, languagePackPayloadUnit, bigEndianForPackID);
			this.m_RcmpWrapper.SendAndReceiveMessage(xcmpWriteTTSLanguagePack);
			if (xcmpWriteTTSLanguagePack.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.AddTTSLanguagePackFailure);
			}
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00006618 File Offset: 0x00004818
		public void DeleteTTSLanguagePack(string languagePackID, bool bigEndianForPackID)
		{
			int num = 3;
			global::Motorola.Common.Communication.RcmpReplyResult rcmpReplyResult = global::Motorola.Common.Communication.RcmpReplyResult.Failure;
			while (rcmpReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success && num-- >= 0)
			{
				global::Motorola.Common.Communication.Rcmp.XcmpDeleteTTSLanguagePack xcmpDeleteTTSLanguagePack = new global::Motorola.Common.Communication.Rcmp.XcmpDeleteTTSLanguagePack(languagePackID, bigEndianForPackID);
				this.m_RcmpWrapper.SendAndReceiveMessage(xcmpDeleteTTSLanguagePack);
				rcmpReplyResult = xcmpDeleteTTSLanguagePack.ReplyResult;
			}
			if (rcmpReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.DeleteTTSLanguagePackFailure);
			}
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00006660 File Offset: 0x00004860
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo> ReadTTSLanguagePackInfo()
		{
			uint num;
			return this.ReadTTSLanguagePackInfo(out num);
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00006678 File Offset: 0x00004878
		public global::Motorola.Common.Communication.Pba.LanguagePackData ReadTTSLanguagePackData()
		{
			uint availableSpace;
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo> list = this.ReadTTSLanguagePackInfo(out availableSpace);
			global::Motorola.Common.Communication.Pba.LanguagePackData languagePackData = new global::Motorola.Common.Communication.Pba.LanguagePackData();
			languagePackData.AvailableSpace = availableSpace;
			if (list != null)
			{
				foreach (global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo ttslanguagePackInfo in list)
				{
					if (ttslanguagePackInfo.Size > 0U)
					{
						languagePackData.LanguagePacks.Add(ttslanguagePackInfo);
					}
				}
			}
			return languagePackData;
		}

		// Token: 0x060000FE RID: 254 RVA: 0x000066F8 File Offset: 0x000048F8
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo> ReadTTSLanguagePackInfo(out uint availableSpace)
		{
			global::Motorola.Common.Communication.Rcmp.XcmpReadLanguagePackInfo xcmpReadLanguagePackInfo = new global::Motorola.Common.Communication.Rcmp.XcmpReadLanguagePackInfo(global::Motorola.Common.Communication.Rcmp.ReadLanguagePackInfoOperation.AllTTSLanguagePack, null);
			this.m_RcmpWrapper.SendAndReceiveMessage(xcmpReadLanguagePackInfo);
			if (xcmpReadLanguagePackInfo.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success && xcmpReadLanguagePackInfo.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.BitUnlocked)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ReadTTSLanguagePackInfoFailure);
			}
			if (xcmpReadLanguagePackInfo.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.BitUnlocked)
			{
				availableSpace = 0U;
				return new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo>();
			}
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo>(xcmpReadLanguagePackInfo.LanguagePackInfo.Count);
			foreach (global::Motorola.Common.Communication.Rcmp.LanguagePackInfo languagePackInfo in xcmpReadLanguagePackInfo.LanguagePackInfo)
			{
				global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo ttslanguagePackInfo = new global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo();
				char[] trimChars = new char[]
				{
					'\0',
					' ',
					'\r',
					'\n'
				};
				string text = languagePackInfo.PackID.TrimEnd(trimChars);
				int num = text.IndexOf('\0');
				if (num == -1)
				{
					ttslanguagePackInfo.PackID = text;
				}
				else
				{
					ttslanguagePackInfo.PackID = text.Substring(0, num);
				}
				ttslanguagePackInfo.Name = languagePackInfo.Name;
				ttslanguagePackInfo.Size = languagePackInfo.Size;
				ttslanguagePackInfo.MajorVersion = languagePackInfo.MajorVersion;
				ttslanguagePackInfo.MinorVersion = languagePackInfo.MinorVersion;
				ttslanguagePackInfo.LanguageCode = languagePackInfo.TTSLanguageCode;
				ttslanguagePackInfo.SpeakerName = languagePackInfo.TTSSpeakerName;
				ttslanguagePackInfo.VoiceGender = languagePackInfo.TTSVoiceGender;
				list.Add(ttslanguagePackInfo);
			}
			availableSpace = xcmpReadLanguagePackInfo.AvailableSpace;
			return list;
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00006858 File Offset: 0x00004A58
		public void WriteTTSLanguagePack(global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo languagePack, int maxXcmpPacketSize, bool bigEndianForPackID, global::Motorola.Common.Communication.IProgressIndicator progressIndicator)
		{
			try
			{
				if (progressIndicator != null)
				{
					progressIndicator.UpdateProgress(0.0);
				}
				this.AddTTSLanguagePack(global::Motorola.Common.Communication.Rcmp.TTSLanguagePackControlOperation.AddTTSLanguagePackStart, languagePack.PackID, null, bigEndianForPackID);
				double num = 1.0;
				if (progressIndicator != null)
				{
					progressIndicator.IncreaseProcess(0.1);
					num -= 0.1;
				}
				using (global::System.IO.Stream stream = global::Motorola.Common.CommonLib.EnDecryptStreamHelper.Instance.CreateCryptoFlStream(languagePack.PackFilePath, global::System.IO.FileAccess.Read))
				{
					byte[] bytesFromStream = global::Motorola.Common.CommonLib.EnDecryptStreamHelper.Instance.GetBytesFromStream(stream, global::System.Text.Encoding.UTF8);
					int i = bytesFromStream.Length;
					int num2 = 0;
					while (i > 0)
					{
						int num3;
						if (i > maxXcmpPacketSize - 100)
						{
							num3 = maxXcmpPacketSize - 100;
						}
						else
						{
							num3 = i;
						}
						byte[] array = new byte[num3];
						global::System.Array.Copy(bytesFromStream, num2, array, 0, num3);
						this.AddTTSLanguagePack(global::Motorola.Common.Communication.Rcmp.TTSLanguagePackControlOperation.AddTTSLanguagePackUnit, null, array, bigEndianForPackID);
						if (progressIndicator != null)
						{
							progressIndicator.IncreaseProcess(num * (double)num3 / (double)i);
						}
						num2 += num3;
						i -= num3;
					}
				}
				this.AddTTSLanguagePack(global::Motorola.Common.Communication.Rcmp.TTSLanguagePackControlOperation.AddTTSLanguagePackEnd, null, null, bigEndianForPackID);
			}
			finally
			{
				if (progressIndicator != null)
				{
					progressIndicator.UpdateProgress(1.0);
				}
			}
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00006984 File Offset: 0x00004B84
		public void SyncDateTime()
		{
			global::Motorola.Common.Communication.Rcmp.XcmpDateTime msg = new global::Motorola.Common.Communication.Rcmp.XcmpDateTime(global::System.DateTime.UtcNow);
			this.m_RcmpWrapper.SendAndReceiveMessage(msg);
		}

		// Token: 0x06000101 RID: 257 RVA: 0x000069A8 File Offset: 0x00004BA8
		public void UpdateSerialNumber(byte[] serailNumber)
		{
			global::Motorola.Common.Communication.Rcmp.RcmpReadWriteSerialNumber rcmpReadWriteSerialNumber = new global::Motorola.Common.Communication.Rcmp.RcmpReadWriteSerialNumber(global::Motorola.Common.Communication.Rcmp.SerialNumberOperationType.WriteRadioSerialNumber, serailNumber);
			this.m_RcmpWrapper.SendAndReceiveMessage(rcmpReadWriteSerialNumber);
			if (rcmpReadWriteSerialNumber.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateSerialNumberFailure);
			}
		}

		// Token: 0x06000102 RID: 258 RVA: 0x000069DC File Offset: 0x00004BDC
		public void UnkillRadio(byte[] authenticationValue)
		{
			global::Motorola.Common.Communication.Rcmp.XcmpUnkill xcmpUnkill = new global::Motorola.Common.Communication.Rcmp.XcmpUnkill(global::Motorola.Common.Communication.Rcmp.UnkillFunction.REQUEST_FOR_UNKILL_RADIO, authenticationValue);
			this.m_RcmpWrapper.SendAndReceiveMessage(xcmpUnkill);
			if (xcmpUnkill.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.IncorrectMode || xcmpUnkill.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.OpcodeNotSupported || xcmpUnkill.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.SecurityLocked)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidModeUnkill);
			}
			if (xcmpUnkill.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Failure)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidDerivedKey);
			}
			if (xcmpUnkill.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UnkillRadioFailure);
			}
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00006A4C File Offset: 0x00004C4C
		public byte[] ReadUnkillChallengeValue()
		{
			global::Motorola.Common.Communication.Rcmp.XcmpUnkill xcmpUnkill = new global::Motorola.Common.Communication.Rcmp.XcmpUnkill(global::Motorola.Common.Communication.Rcmp.UnkillFunction.REQUEST_FOR_CHALLENGE_VALUE, null);
			this.m_RcmpWrapper.SendAndReceiveMessage(xcmpUnkill);
			if (xcmpUnkill.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.IncorrectMode || xcmpUnkill.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.OpcodeNotSupported || xcmpUnkill.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.SecurityLocked)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidModeUnkill);
			}
			if (xcmpUnkill.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ReadUnkillChallengeValueFailure);
			}
			return xcmpUnkill.Values;
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00006AAC File Offset: 0x00004CAC
		public void UpdateMACAddress(byte[] macAddress)
		{
			global::Motorola.Common.Communication.Rcmp.RcmpReadWriteSerialNumber rcmpReadWriteSerialNumber = new global::Motorola.Common.Communication.Rcmp.RcmpReadWriteSerialNumber(global::Motorola.Common.Communication.Rcmp.SerialNumberOperationType.WriteMACAddress, macAddress);
			this.m_RcmpWrapper.SendAndReceiveMessage(rcmpReadWriteSerialNumber);
			if (rcmpReadWriteSerialNumber.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateMACAddressFailure);
			}
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00006AE0 File Offset: 0x00004CE0
		public void UnlockISHPartition(byte partition)
		{
			global::Motorola.Common.Communication.Rcmp.RcmpIshUnlockPartition rcmpIshUnlockPartition = new global::Motorola.Common.Communication.Rcmp.RcmpIshUnlockPartition(partition);
			this.m_RcmpWrapper.SendAndReceiveMessage(rcmpIshUnlockPartition);
			if (rcmpIshUnlockPartition.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.SecurityUnlockFailure);
			}
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00006B14 File Offset: 0x00004D14
		public void UpdateProductSerialNumber(byte[] serailNumber)
		{
			global::Motorola.Common.Communication.Rcmp.RcmpReadWriteSerialNumber rcmpReadWriteSerialNumber = new global::Motorola.Common.Communication.Rcmp.RcmpReadWriteSerialNumber(global::Motorola.Common.Communication.Rcmp.SerialNumberOperationType.WriteProductSerialNumber, serailNumber);
			this.m_RcmpWrapper.SendAndReceiveMessage(rcmpReadWriteSerialNumber);
			if (rcmpReadWriteSerialNumber.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateSerialNumberFailure);
			}
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00006B48 File Offset: 0x00004D48
		public void UpdateIMEType(byte ime)
		{
			global::Motorola.Common.Communication.XcmpConnectivityTest xcmpConnectivityTest = new global::Motorola.Common.Communication.XcmpConnectivityTest(global::Motorola.Common.Communication.ConnectFunction.FactoryControlHeadConnectivityTest, 2, new byte[]
			{
				byte.MaxValue,
				ime
			});
			this.m_RcmpWrapper.SendAndReceiveMessage(xcmpConnectivityTest);
			if (xcmpConnectivityTest.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateIMETypeFailure);
			}
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00006B94 File Offset: 0x00004D94
		public void UpdateDateCode(byte[] datecode, ushort source)
		{
			global::Motorola.Common.Communication.RcmpDatecode rcmpDatecode = new global::Motorola.Common.Communication.RcmpDatecode(1, datecode, source);
			this.m_RcmpWrapper.SendAndReceiveMessage(rcmpDatecode);
			if (rcmpDatecode.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateDateCodeFailure);
			}
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00006BCC File Offset: 0x00004DCC
		public void EnterTestMode()
		{
			global::Motorola.Common.Communication.Rcmp.RcmpEnterTestMode rcmpEnterTestMode = new global::Motorola.Common.Communication.Rcmp.RcmpEnterTestMode();
			this.m_RcmpWrapper.SendAndReceiveMessage(rcmpEnterTestMode);
			if (rcmpEnterTestMode.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.EnterTestModeFailure);
			}
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00006C00 File Offset: 0x00004E00
		public void RadioUpdateControl(global::Motorola.Common.Communication.UpdateControlAction action)
		{
			global::Motorola.Common.Communication.XcmpRadioUpdateControl xcmpRadioUpdateControl = new global::Motorola.Common.Communication.XcmpRadioUpdateControl(action);
			this.m_RcmpWrapper.SendAndReceiveMessage(xcmpRadioUpdateControl);
			if (xcmpRadioUpdateControl.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateControlFailure);
			}
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00006C34 File Offset: 0x00004E34
		public global::Motorola.Common.Communication.CommonUtil.PasswordStatus QueryPasswordStatus()
		{
			global::Motorola.Common.Communication.Rcmp.XcmpCodeplugPasswordLock xcmpCodeplugPasswordLock = new global::Motorola.Common.Communication.Rcmp.XcmpCodeplugPasswordLock(global::Motorola.Common.Communication.Rcmp.CodeplugPasswordLockFunction.RequestStatus, null);
			this.m_RcmpWrapper.SendAndReceiveMessage(xcmpCodeplugPasswordLock);
			if (xcmpCodeplugPasswordLock.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				return new global::Motorola.Common.Communication.CommonUtil.PasswordStatus
				{
					AlgorithmID = xcmpCodeplugPasswordLock.AlgorithmID(),
					Policy = (global::Motorola.Common.Communication.CommonUtil.PasswordPolicy)xcmpCodeplugPasswordLock.Policy(),
					Salt = xcmpCodeplugPasswordLock.Salt(),
					ConfigurationLocked = xcmpCodeplugPasswordLock.ConfigurationLocked(),
					RemainingAttempts = xcmpCodeplugPasswordLock.RemainingAttempts()
				};
			}
			if (xcmpCodeplugPasswordLock.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.OpcodeNotSupported || xcmpCodeplugPasswordLock.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.SecurityLocked)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.OpcodeNotSupported);
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.QueryPasswordPolicyFailure);
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00006CC8 File Offset: 0x00004EC8
		public global::Motorola.Common.Communication.CommonUtil.PasswordStatus ValidateLocalPassword(string password)
		{
			global::Motorola.Common.Communication.Rcmp.XcmpCodeplugPasswordLock xcmpCodeplugPasswordLock = new global::Motorola.Common.Communication.Rcmp.XcmpCodeplugPasswordLock(global::Motorola.Common.Communication.Rcmp.CodeplugPasswordLockFunction.VerifyPassword, password);
			this.m_RcmpWrapper.SendAndReceiveMessage(xcmpCodeplugPasswordLock);
			global::Motorola.Common.Communication.CommonUtil.PasswordStatus passwordStatus = new global::Motorola.Common.Communication.CommonUtil.PasswordStatus();
			if (xcmpCodeplugPasswordLock.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				if (xcmpCodeplugPasswordLock.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.BitLocked)
				{
					passwordStatus.IsPasswordValidationSuccess = false;
				}
				else
				{
					if (xcmpCodeplugPasswordLock.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.OpcodeNotSupported || xcmpCodeplugPasswordLock.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.SecurityLocked)
					{
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.OpcodeNotSupported);
					}
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ValidateLocalPasswordFailure);
				}
			}
			else
			{
				passwordStatus.IsPasswordValidationSuccess = true;
			}
			passwordStatus.RemainingAttempts = xcmpCodeplugPasswordLock.RemainingAttempts();
			return passwordStatus;
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00006D44 File Offset: 0x00004F44
		public int CodeplugUpdate(global::Motorola.Common.Communication.UpdateControlAction action, out uint Value)
		{
			Value = 0U;
			int result = 0;
			uint num = 255U;
			global::Motorola.Common.Communication.XcmpRadioUpdateControl xcmpRadioUpdateControl = new global::Motorola.Common.Communication.XcmpRadioUpdateControl(action);
			this.m_RcmpWrapper.SendAndReceiveMessage(xcmpRadioUpdateControl);
			if (xcmpRadioUpdateControl.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				num = (uint)xcmpRadioUpdateControl.Value;
			}
			Value = num;
			return result;
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00006D84 File Offset: 0x00004F84
		public void ReadComponentFile(global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.ComponentType compType, ushort compInstance, out uint numberOfFiles, out string filePath)
		{
			numberOfFiles = 0U;
			filePath = string.Empty;
			global::Motorola.Common.Communication.Rcmp.XcmpComponentRead xcmpComponentRead = new global::Motorola.Common.Communication.Rcmp.XcmpComponentRead((ushort)compType, compInstance, global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.Level.ReadComponentData, 0);
			this.m_RcmpWrapper.SendAndReceiveMessage(xcmpComponentRead);
			if (xcmpComponentRead.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				numberOfFiles = (uint)xcmpComponentRead.NumberOfFiles;
				global::System.Text.Encoding encoding = new global::System.Text.UTF8Encoding(true, true);
				filePath = encoding.GetString(xcmpComponentRead.Information);
				return;
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ComponentReadFileFailure);
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00006DE4 File Offset: 0x00004FE4
		public string ReadComponentVersion(global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.ComponentType compType, ushort compInstance)
		{
			global::Motorola.Common.Communication.Rcmp.XcmpComponentRead xcmpComponentRead = new global::Motorola.Common.Communication.Rcmp.XcmpComponentRead((ushort)compType, compInstance, global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.Level.GetVersion, 0);
			this.m_RcmpWrapper.SendAndReceiveMessage(xcmpComponentRead);
			if (xcmpComponentRead.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				string @string = global::System.Text.Encoding.ASCII.GetString(xcmpComponentRead.Information);
				char[] trimChars = new char[1];
				return @string.TrimEnd(trimChars);
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ComponentReadFileFailure);
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00006E38 File Offset: 0x00005038
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.TypeLevelChangeDiscovery> TypeLevelChangeDiscoveryOfTypes(global::System.Collections.Generic.IEnumerable<ushort> ishTypes, out string radioFilePath, global::Motorola.Common.Communication.IProgressIndicator progressIndicator)
		{
			uint num;
			global::Motorola.Common.Communication.Pba.PbaObject pbaObject = this.ReadComponent(global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.ComponentType.IshCodeplug, 2, global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.Level.GetTypeChanges, global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.ListStructure.ListofIshTypes, ishTypes, out num, out radioFilePath, progressIndicator);
			return pbaObject.CodeplugData.TypeCounters;
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00006E60 File Offset: 0x00005060
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.TypeLevelChangeDiscovery> TypeLevelChangeDiscoveryInPartitions(global::System.Collections.Generic.IEnumerable<ushort> ishPartitions, out string radioFilePath, global::Motorola.Common.Communication.IProgressIndicator progressIndicator)
		{
			uint num;
			global::Motorola.Common.Communication.Pba.PbaObject pbaObject = this.ReadComponent(global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.ComponentType.IshCodeplug, 2, global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.Level.GetTypeChanges, global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.ListStructure.ListofIshPartitions, ishPartitions, out num, out radioFilePath, progressIndicator);
			return pbaObject.CodeplugData.TypeCounters;
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00006E88 File Offset: 0x00005088
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.ItemLevelChangeDiscovery> ItemLevelChangeDiscoveryInPartitions(global::System.Collections.Generic.IEnumerable<ushort> ishPartitions, out string radioFilePath, global::Motorola.Common.Communication.IProgressIndicator progressIndicator)
		{
			uint num;
			global::Motorola.Common.Communication.Pba.PbaObject pbaObject = this.ReadComponent(global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.ComponentType.IshCodeplug, 2, global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.Level.GetItemChanges, global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.ListStructure.ListofIshPartitions, ishPartitions, out num, out radioFilePath, progressIndicator);
			return pbaObject.CodeplugData.IDCounters;
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00006EB0 File Offset: 0x000050B0
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.ItemLevelChangeDiscovery> ItemLevelChangeDiscovery(global::System.Collections.Generic.IEnumerable<global::Motorola.Common.Communication.Rcmp.XcmpComponentTypeIdPair> typeIdPairs, out string radioFilePath, global::Motorola.Common.Communication.IProgressIndicator progressIndicator)
		{
			uint num;
			global::Motorola.Common.Communication.Pba.PbaObject pbaObject = this.ReadComponent(global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.ComponentType.IshCodeplug, 2, global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.Level.GetItemChanges, global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.ListStructure.ListofIshTypeIds, typeIdPairs, out num, out radioFilePath, progressIndicator);
			return pbaObject.CodeplugData.IDCounters;
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00006ED8 File Offset: 0x000050D8
		public global::Motorola.Common.Communication.Pba.PbaObject ReadCodeplugItemsInPartitions(global::System.Collections.Generic.IEnumerable<ushort> partitions, global::Motorola.Common.Communication.IProgressIndicator progressIndicator)
		{
			uint num;
			string text;
			return this.ReadComponent(global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.ComponentType.IshCodeplug, 2, global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.Level.ReadComponentData, global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.ListStructure.ListofIshPartitions, partitions, out num, out text, progressIndicator);
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00006EF8 File Offset: 0x000050F8
		public global::Motorola.Common.Communication.Pba.PbaObject ReadCodeplugItemsByTypes(global::System.Collections.Generic.IEnumerable<ushort> ishTypes, global::Motorola.Common.Communication.IProgressIndicator progressIndicator)
		{
			uint num;
			string text;
			return this.ReadComponent(global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.ComponentType.IshCodeplug, 2, global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.Level.ReadComponentData, global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.ListStructure.ListofIshTypes, ishTypes, out num, out text, progressIndicator);
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00006F2C File Offset: 0x0000512C
		public global::Motorola.Common.Communication.CommonUtil.IshItemCollection ReadItemsByIshHeaders(global::System.Collections.Generic.IEnumerable<global::Motorola.Common.Communication.CommonUtil.IshHeader> ishHeaders, out string radioFilePath, global::Motorola.Common.Communication.IProgressIndicator progressIndicator = null)
		{
			global::System.Collections.Generic.IEnumerable<global::Motorola.Common.Communication.Rcmp.XcmpComponentTypeIdPair> items = from x in ishHeaders
			select new global::Motorola.Common.Communication.Rcmp.XcmpComponentTypeIdPair(x.IshType, x.IshID);
			global::Motorola.Common.Communication.Pba.PbaObject pbaObject = this.ReadCodeplugItems(items, out radioFilePath, progressIndicator);
			return pbaObject.GetCodeplugInIshItemCollection();
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00006F70 File Offset: 0x00005170
		public global::Motorola.Common.Communication.CommonUtil.IshItemCollection ReadDifferetialCodeplugByIshTypes(global::System.Collections.Generic.IEnumerable<ushort> ishTypes, global::Motorola.Common.Communication.IProgressIndicator progressIndicator)
		{
			uint num;
			string text;
			global::Motorola.Common.Communication.Pba.PbaObject pbaObject = this.ReadComponent(global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.ComponentType.IshCodeplug, 2, global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.Level.ReadDifferentialData, global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.ListStructure.ListofIshTypes, ishTypes, out num, out text, progressIndicator);
			return pbaObject.GetCodeplugInIshItemCollection();
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00006F94 File Offset: 0x00005194
		public global::Motorola.Common.Communication.CommonUtil.IshItemCollection ReadDifferetialCodeplugInPartitions(global::System.Collections.Generic.IEnumerable<ushort> partitions, global::Motorola.Common.Communication.IProgressIndicator progressIndicator)
		{
			uint num;
			string text;
			global::Motorola.Common.Communication.Pba.PbaObject pbaObject = this.ReadComponent(global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.ComponentType.IshCodeplug, 2, global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.Level.ReadDifferentialData, global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.ListStructure.ListofIshPartitions, partitions, out num, out text, progressIndicator);
			return pbaObject.GetCodeplugInIshItemCollection();
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00006FB8 File Offset: 0x000051B8
		public global::Motorola.Common.Communication.Pba.PbaObject ReadCodeplugItems(global::System.Collections.Generic.IEnumerable<global::Motorola.Common.Communication.Rcmp.XcmpComponentTypeIdPair> items, out string radioFilePath, global::Motorola.Common.Communication.IProgressIndicator progressIndicator)
		{
			uint num;
			return this.ReadComponent(global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.ComponentType.IshCodeplug, 2, global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.Level.ReadComponentData, global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.ListStructure.ListofIshTypeIds, items, out num, out radioFilePath, progressIndicator);
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00006FD4 File Offset: 0x000051D4
		private global::Motorola.Common.Communication.Pba.PbaObject ReadComponent(global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.ComponentType componentType, ushort componentInstance, global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.Level level, global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.ListStructure listStructure, global::System.Collections.IEnumerable componentItems, out uint numberOfFiles, out string filePath, global::Motorola.Common.Communication.IProgressIndicator progressIndicator)
		{
			uint listItemLength = global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.GetListItemLength(listStructure);
			uint allowedBytesCount = (uint)((this.m_MaxPacketSize - global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.RequestHeaderLength) / (int)listItemLength * (int)listItemLength);
			byte[] componentBuffer = global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.ConvertListItemToBytes(listStructure, componentItems);
			this.ReadComponent(componentType, componentInstance, level, listStructure, componentBuffer, allowedBytesCount, out numberOfFiles, out filePath, new global::Motorola.Common.Communication.IteratedProgressIndicator(progressIndicator, 0.1));
			if (numberOfFiles == 0U)
			{
				return new global::Motorola.Common.Communication.Pba.PbaObject();
			}
			string[] array = new string[6];
			string[] array2 = array;
			int num = 0;
			ushort num2 = (ushort)componentType;
			array2[num] = num2.ToString(global::System.Globalization.CultureInfo.InvariantCulture);
			array[1] = "_";
			array[2] = componentInstance.ToString(global::System.Globalization.CultureInfo.InvariantCulture);
			array[3] = "_";
			array[4] = numberOfFiles.ToString(global::System.Globalization.CultureInfo.InvariantCulture);
			array[5] = ".cmp";
			string text = string.Concat(array);
			string filePath2 = string.IsNullOrEmpty(filePath) ? text : (filePath + "/" + text);
			ushort filePartition = 0;
			byte[] fileData;
			using (global::System.IO.MemoryStream memoryStream = this.FileRead(filePartition, filePath2, new global::Motorola.Common.Communication.IteratedProgressIndicator(progressIndicator, 0.9)))
			{
				fileData = memoryStream.ToArray();
			}
			global::Motorola.Common.Communication.CommonFile.PartitionCommonFile partitionCommonFile = new global::Motorola.Common.Communication.CommonFile.PartitionCommonFile(this.IsCommonFileCrcBigEndian);
			return partitionCommonFile.Deserialize(fileData);
		}

		// Token: 0x0600011B RID: 283 RVA: 0x0000710C File Offset: 0x0000530C
		private void ReadComponent(global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.ComponentType componentType, ushort componentInstance, global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.Level level, global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.ListStructure listStructure, byte[] componentBuffer, uint allowedBytesCount, out uint numberOfFiles, out string filePath, global::Motorola.Common.Communication.IProgressIndicator progressIndicator)
		{
			numberOfFiles = 0U;
			filePath = string.Empty;
			int i = 0;
			while (i < componentBuffer.Length)
			{
				byte b;
				int num;
				if ((long)i + (long)((ulong)allowedBytesCount) < (long)componentBuffer.Length)
				{
					b = ((i == 0) ? 64 : 128);
					num = (int)allowedBytesCount;
				}
				else
				{
					b = ((i == 0) ? 0 : 192);
					num = componentBuffer.Length - i;
				}
				global::Motorola.Common.Communication.Rcmp.XcmpComponentRead xcmpComponentRead = new global::Motorola.Common.Communication.Rcmp.XcmpComponentRead((ushort)componentType, componentInstance, level, (byte)(b + listStructure), (num > 0) ? componentBuffer.Skip(i).Take(num).ToArray<byte>() : null);
				this.m_RcmpWrapper.SendAndReceiveMessage(xcmpComponentRead);
				if (xcmpComponentRead.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ComponentReadFileFailure);
				}
				if (b == 192 || b == 0)
				{
					numberOfFiles = (uint)xcmpComponentRead.NumberOfFiles;
					string @string = global::System.Text.Encoding.UTF8.GetString(xcmpComponentRead.Information);
					char[] trimChars = new char[1];
					filePath = @string.Trim(trimChars);
				}
				i += num;
				if (progressIndicator != null)
				{
					progressIndicator.IncreaseProcess((double)(num / componentBuffer.Length));
				}
			}
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00007204 File Offset: 0x00005404
		public void ComponentSession(ushort actions, ushort sessionID, out ushort performedActions, out ushort currentSessionId)
		{
			global::Motorola.Common.Communication.Rcmp.XcmpComponentSession xcmpComponentSession = new global::Motorola.Common.Communication.Rcmp.XcmpComponentSession(actions, sessionID);
			try
			{
				this.m_RcmpWrapper.SendAndReceiveMessage(xcmpComponentSession);
			}
			catch (global::Motorola.Common.CustomException.CommonException ex)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Exception on session command: " + ex.Message, new object[0]);
				throw;
			}
			catch (global::System.Exception ex2)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Exception on session command: " + ex2.Message, new object[0]);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ComponentSessionFailure);
			}
			ushort num = 1056;
			ushort num2 = 1025;
			ushort num3 = 7;
			if (xcmpComponentSession.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success || (xcmpComponentSession.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Failure && actions == num2))
			{
				performedActions = xcmpComponentSession.CompletedActions;
				currentSessionId = xcmpComponentSession.ReplySessionId;
				this.SessionCommandReply = xcmpComponentSession;
				return;
			}
			if (xcmpComponentSession.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.InvalidParameter && (actions == num3 || actions == num2 || actions == num))
			{
				performedActions = xcmpComponentSession.CompletedActions;
				currentSessionId = xcmpComponentSession.ReplySessionId;
				this.SessionCommandReply = xcmpComponentSession;
				this.RetryDifferentialWriteNotSupported = true;
				return;
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ComponentSessionFailure);
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00007314 File Offset: 0x00005514
		public void ComponentSession(ushort actions, ushort sessionID, ushort previousSessionID, out ushort performedActions, out ushort currentSessionId)
		{
			global::Motorola.Common.Communication.Rcmp.XcmpComponentSession xcmpComponentSession = new global::Motorola.Common.Communication.Rcmp.XcmpComponentSession(actions, sessionID, (uint)previousSessionID);
			this.m_RcmpWrapper.SendAndReceiveMessage(xcmpComponentSession);
			ushort num = 1056;
			ushort num2 = 1025;
			ushort num3 = 7;
			if (xcmpComponentSession.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				performedActions = xcmpComponentSession.CompletedActions;
				currentSessionId = xcmpComponentSession.ReplySessionId;
				this.SessionCommandReply = xcmpComponentSession;
				return;
			}
			if (xcmpComponentSession.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.InvalidParameter && (actions == num3 || actions == num2 || actions == num))
			{
				performedActions = xcmpComponentSession.CompletedActions;
				currentSessionId = xcmpComponentSession.ReplySessionId;
				this.SessionCommandReply = xcmpComponentSession;
				this.RetryDifferentialWriteNotSupported = true;
				return;
			}
			if (xcmpComponentSession.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.BitLocked && (actions == num3 || actions == num2 || actions == num))
			{
				performedActions = xcmpComponentSession.CompletedActions;
				currentSessionId = xcmpComponentSession.ReplySessionId;
				this.SessionCommandReply = xcmpComponentSession;
				this.MisMatchedRadioAndRMSessionId = true;
				return;
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ComponentSessionFailure);
		}

		// Token: 0x0600011E RID: 286 RVA: 0x000073E4 File Offset: 0x000055E4
		public bool StartOtapSession(ushort currentSessionID, ushort previousSessionID, bool isRead)
		{
			ushort num = 7;
			if (!isRead)
			{
				num |= 512;
			}
			global::Motorola.Common.Communication.Rcmp.XcmpComponentSession xcmpComponentSession = new global::Motorola.Common.Communication.Rcmp.XcmpComponentSession(num, currentSessionID, (uint)previousSessionID);
			this.m_RcmpWrapper.SendAndReceiveMessage(xcmpComponentSession);
			if (xcmpComponentSession.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Start Otap session successfully and session matched. Current session id [{0}]; previous session id [{1}].", new object[]
				{
					currentSessionID,
					previousSessionID
				});
				return true;
			}
			if (xcmpComponentSession.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.BitLocked)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Start Otap session successfully and session MIS-matched. Current session id [{0}]; previous session id [{1}].", new object[]
				{
					currentSessionID,
					previousSessionID
				});
				return false;
			}
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Start Otap Session Error. Radio responses [{0}]", new object[]
			{
				xcmpComponentSession.ReplyResult.ToString()
			});
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ComponentSessionFailure);
		}

		// Token: 0x0600011F RID: 287 RVA: 0x000074B4 File Offset: 0x000056B4
		public void CloseOtapSession(ushort currentSessionID, bool isNomal)
		{
			ushort num = 1;
			if (isNomal)
			{
				num |= 4;
			}
			global::Motorola.Common.Communication.Rcmp.XcmpComponentSession xcmpComponentSession = new global::Motorola.Common.Communication.Rcmp.XcmpComponentSession(num, currentSessionID);
			this.m_RcmpWrapper.SendAndReceiveMessage(xcmpComponentSession);
			if (xcmpComponentSession.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Close Otap Session Error. Radio responses [{0}]", new object[]
				{
					xcmpComponentSession.ReplyResult.ToString()
				});
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ComponentSessionFailure);
			}
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Close Otap session id [{0}] successfully.", new object[]
			{
				currentSessionID
			});
		}

		// Token: 0x06000120 RID: 288 RVA: 0x0000753C File Offset: 0x0000573C
		public void CommitOtapSession(ushort currentSessionID)
		{
			ushort action = 24;
			global::Motorola.Common.Communication.Rcmp.XcmpComponentSession xcmpComponentSession = new global::Motorola.Common.Communication.Rcmp.XcmpComponentSession(action, currentSessionID);
			this.m_RcmpWrapper.SendAndReceiveMessage(xcmpComponentSession);
			if (xcmpComponentSession.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Commit Otap Session Error. Radio responses [{0}]", new object[]
				{
					xcmpComponentSession.ReplyResult.ToString()
				});
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ComponentSessionFailure);
			}
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Commit Otap session id [{0}] successfully.", new object[]
			{
				currentSessionID
			});
		}

		// Token: 0x06000121 RID: 289 RVA: 0x000075C0 File Offset: 0x000057C0
		public void CommitWiFiSession(ushort currentSessionID)
		{
			ushort action = 24;
			global::Motorola.Common.Communication.Rcmp.XcmpComponentSession xcmpComponentSession = new global::Motorola.Common.Communication.Rcmp.XcmpComponentSession(action, currentSessionID);
			xcmpComponentSession.ReadTimeout = 120000;
			this.m_RcmpWrapper.SendAndReceiveMessage(xcmpComponentSession);
			if (xcmpComponentSession.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Commit WiFi Session Error. Radio responses [{0}]", new object[]
				{
					xcmpComponentSession.ReplyResult.ToString()
				});
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ComponentSessionFailure);
			}
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Commit WiFi session id [{0}] successfully.", new object[]
			{
				currentSessionID
			});
		}

		// Token: 0x06000122 RID: 290 RVA: 0x0000764C File Offset: 0x0000584C
		public void CreateArchiveSession(ushort currentSessionID)
		{
			ushort action = 1025;
			global::Motorola.Common.Communication.Rcmp.XcmpComponentSession xcmpComponentSession = new global::Motorola.Common.Communication.Rcmp.XcmpComponentSession(action, currentSessionID);
			this.m_RcmpWrapper.SendAndReceiveMessage(xcmpComponentSession);
			if (xcmpComponentSession.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success && xcmpComponentSession.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.OpcodeNotSupported)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Create Archive Session Error. Radio responses [{0}]", new object[]
				{
					xcmpComponentSession.ReplyResult.ToString()
				});
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ComponentSessionFailure);
			}
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Create Archive session id [{0}] successfully.", new object[]
			{
				currentSessionID
			});
		}

		// Token: 0x0400000F RID: 15
		private const int RADIO_STATUS_TIMEOUT = 20;

		// Token: 0x04000010 RID: 16
		private global::Motorola.Common.Communication.IMessageExecutor m_RcmpWrapper;

		// Token: 0x04000011 RID: 17
		private int m_MaxPacketSize;

		// Token: 0x04000012 RID: 18
		private global::Motorola.Common.Communication.Rcmp.XcmpComponentSession sessionCommandReply;

		// Token: 0x04000013 RID: 19
		private bool retryDifferentialWriteNotSupported;

		// Token: 0x04000014 RID: 20
		private bool misMatchedRadioAndRMSessionId;
	}
}
