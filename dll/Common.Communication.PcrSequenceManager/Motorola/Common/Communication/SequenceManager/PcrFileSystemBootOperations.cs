using System;
using System.Threading;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.SequenceManager
{
	// Token: 0x02000031 RID: 49
	public class PcrFileSystemBootOperations
	{
		// Token: 0x06000192 RID: 402 RVA: 0x0000F52C File Offset: 0x0000D72C
		internal PcrFileSystemBootOperations(global::Motorola.Common.Communication.IMessageExecutor rcmpWrapper, int maxDataPayload)
		{
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(rcmpWrapper, global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
			if (maxDataPayload <= 0)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgument);
			}
			this.m_MaxDataPayload = maxDataPayload;
			this.msgExecutor = rcmpWrapper;
			this.BootExecutor = new global::Motorola.Common.Communication.SequenceManager.PcrBootExecutor(rcmpWrapper);
		}

		// Token: 0x06000193 RID: 403 RVA: 0x0000F574 File Offset: 0x0000D774
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
				if (!this.BootExecutor.Unlock())
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.SecurityUnlockFailure);
				}
				result = true;
			}
			else
			{
				result = true;
			}
			return result;
		}

		// Token: 0x06000194 RID: 404 RVA: 0x0000F624 File Offset: 0x0000D824
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

		// Token: 0x06000195 RID: 405 RVA: 0x0000F6F0 File Offset: 0x0000D8F0
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
			global::System.Threading.Thread.Sleep(2000);
			this.msgExecutor.CommPipe.ClosePort();
			global::System.Threading.Thread.Sleep(2000);
			this.msgExecutor.CommPipe.OpenPort(1500);
			if (!this.BootExecutor.isRamDloaderRunning())
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.QueryVersionInfoFailure);
			}
			return true;
		}

		// Token: 0x06000196 RID: 406 RVA: 0x0000F79C File Offset: 0x0000D99C
		private bool WriteSrecToFlash(global::Motorola.Common.Communication.Srecord record, global::Motorola.Common.Communication.IProgressIndicator ProgressIndicator)
		{
			global::Motorola.Common.Communication.SrecDataCollection dataRecords = record.DataRecords;
			int num = 0;
			global::Motorola.Common.Communication.SequenceManager.ProgressInfoObject progressInfoObject = new global::Motorola.Common.Communication.SequenceManager.ProgressInfoObject();
			int num2 = 0;
			if (ProgressIndicator != null)
			{
				foreach (global::Motorola.Common.Communication.SrecData srecData in dataRecords)
				{
					num += (int)srecData.DataLen;
				}
			}
			foreach (global::Motorola.Common.Communication.SrecData srecData in dataRecords)
			{
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
					if (!this.BootExecutor.WriteMemory64KBlocks((int)address, num3, data, progressInfoObject, ProgressIndicator))
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

		// Token: 0x06000197 RID: 407 RVA: 0x0000F994 File Offset: 0x0000DB94
		internal void ResetRadioBoot()
		{
			if (!this.BootExecutor.ResetRadioBoot())
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RadioResetFailure);
			}
		}

		// Token: 0x040000C0 RID: 192
		private int m_MaxDataPayload;

		// Token: 0x040000C1 RID: 193
		private global::Motorola.Common.Communication.SequenceManager.PcrBootExecutor BootExecutor;

		// Token: 0x040000C2 RID: 194
		private global::Motorola.Common.Communication.IMessageExecutor msgExecutor;
	}
}
