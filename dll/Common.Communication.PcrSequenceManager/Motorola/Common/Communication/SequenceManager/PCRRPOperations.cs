using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Compression;
using Motorola.Common.Communication.PCRRemoteProgramming;
using Motorola.Common.Communication.Rcmp;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.SequenceManager
{
	// Token: 0x02000047 RID: 71
	internal class PCRRPOperations : global::Motorola.Common.Communication.SequenceManager.PcrBootOperations, global::System.IDisposable
	{
		// Token: 0x06000231 RID: 561 RVA: 0x00013B40 File Offset: 0x00011D40
		public PCRRPOperations(global::Motorola.Common.Communication.SequenceManager.PcrRcmpMessageExecutor msgExecutor, int maxDataPayload) : base(msgExecutor, maxDataPayload)
		{
			this.messageExecutor = (msgExecutor as global::Motorola.Common.Communication.SequenceManager.PCRRPRcmpMessageExecutor);
			this.brdcstWaitHandle = new global::System.Threading.AutoResetEvent(false);
		}

		// Token: 0x06000232 RID: 562 RVA: 0x00013B8C File Offset: 0x00011D8C
		public void ReadMemory(string fileID, int startAddress, int endAddress, string filePath, global::Motorola.Common.Communication.IProgressIndicator ProgressIndicator)
		{
			if (endAddress <= startAddress || filePath == null)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgument);
			}
			try
			{
				int num = endAddress - startAddress + 1;
				byte[] array = this._ReadMemory(fileID, startAddress, endAddress, ProgressIndicator);
				if (array == null || (!this.useCompress && array.Length < num))
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.IncompleteReadMemoryOperation);
				}
				byte[] dataArr = null;
				if (this.useCompress)
				{
					uint num2 = 0U;
					global::Motorola.Common.Communication.Compression.LZMAWrapper.DataDecompress(array, out dataArr, ref num2);
				}
				else
				{
					dataArr = array;
				}
				using (global::Motorola.Common.Communication.Srecord srecord = new global::Motorola.Common.Communication.Srecord())
				{
					global::Motorola.Common.Communication.SrecData item = new global::Motorola.Common.Communication.SrecData((uint)num, (uint)startAddress, dataArr, global::Motorola.Common.Communication.SrecType.S3);
					srecord.DataRecords.Add(item);
					global::Motorola.Common.Communication.SequenceManager.PcrBootOperations.WriteRecordsToFile(srecord.DataRecords, filePath);
				}
			}
			catch (global::Motorola.Common.CustomException.CommonException systemException)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ReadMemoryFailure, systemException);
			}
		}

		// Token: 0x06000233 RID: 563 RVA: 0x00013C98 File Offset: 0x00011E98
		private byte[] _ReadMemory(string fileID, int startAddress, int endAddress, global::Motorola.Common.Communication.IProgressIndicator ProgressIndicator)
		{
			this.ResetBroadcastReceiveEnvironment();
			this.messageExecutor.BroadcastDataMessageReceived += this.ReadMemory_BroadcastDataMessageReceived;
			global::Motorola.Common.Communication.Rcmp.RcmpMemoryStreamRead rcmpMemoryStreamRead = new global::Motorola.Common.Communication.Rcmp.RcmpMemoryStreamRead(fileID);
			this.messageExecutor.SendAndReceiveMessage(rcmpMemoryStreamRead);
			if (rcmpMemoryStreamRead.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.PCR_RP_READ_MOMEORY_FAILED);
			}
			if (this.WaitOnBackgroundOperation(ProgressIndicator))
			{
				return this.msReadBroadcast.DataBlock;
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.PCR_RP_READ_MOMEORY_FAILED);
		}

		// Token: 0x06000234 RID: 564 RVA: 0x00013D24 File Offset: 0x00011F24
		private void ReadMemory_BroadcastDataMessageReceived(object sender, global::Motorola.Common.Communication.RnlBrdcstMsgEventArgs e)
		{
			this.msReadBroadcast = new global::Motorola.Common.Communication.RcmpMemoryStreamReadBroadcast("\0\0\0\0");
			byte[] payload = e.packet.payload;
			try
			{
				this.msReadBroadcast.DecodeReplyMessage(e.packet.payload, 0, (int)e.packet.payloadLength);
				this.operationProgress = global::Motorola.Common.Communication.SequenceManager.PCRRPOperations.OPERATION_DONE;
			}
			catch (global::System.Exception)
			{
				this.operationProgress = global::Motorola.Common.Communication.SequenceManager.PCRRPOperations.OPERATION_FAILED;
				throw;
			}
			finally
			{
				this.brdcstWaitHandle.Set();
				this.messageExecutor.BroadcastDataMessageReceived -= this.ReadMemory_BroadcastDataMessageReceived;
			}
		}

		// Token: 0x06000235 RID: 565 RVA: 0x00013E8C File Offset: 0x0001208C
		private bool WaitOnBackgroundOperation(global::Motorola.Common.Communication.IProgressIndicator ProgressIndicator)
		{
			global::Motorola.Common.Communication.SequenceManager.PCRRPOperations.UpdateProgressDelegate updateProgressDelegate = delegate(global::Motorola.Common.Communication.IProgressIndicator progressIndicator)
			{
				while (this.brdcstWaitHandle.WaitOne(global::Motorola.Common.Communication.PCRRemoteProgramming.PCRRPConstants.RPWriteProgressUpdateTimeout))
				{
					this.brdcstWaitHandle.Reset();
					if (this.operationProgress == global::Motorola.Common.Communication.SequenceManager.PCRRPOperations.OPERATION_DONE || this.operationProgress == global::Motorola.Common.Communication.SequenceManager.PCRRPOperations.OPERATION_FAILED)
					{
						IL_93:
						return this.operationProgress == global::Motorola.Common.Communication.SequenceManager.PCRRPOperations.OPERATION_DONE;
					}
					progressIndicator.UpdateProgress((double)this.operationProgress / 100.0);
				}
				this.brdcstWaitHandle.Reset();
				this.operationProgress = global::Motorola.Common.Communication.SequenceManager.PCRRPOperations.OPERATION_FAILED;
				goto IL_93;
			};
			global::System.IAsyncResult asyncResult = updateProgressDelegate.BeginInvoke(ProgressIndicator, null, null);
			asyncResult.AsyncWaitHandle.WaitOne();
			return updateProgressDelegate.EndInvoke(asyncResult);
		}

		// Token: 0x06000236 RID: 566 RVA: 0x00013EC8 File Offset: 0x000120C8
		internal override void WriteFiles(global::System.Collections.Generic.List<string> Imagefilepaths, ref global::System.Collections.ArrayList ramAddressArray, ref global::System.Collections.ArrayList flashAddressArray, ref global::System.Collections.ArrayList payloadSizeArray, ref global::System.Collections.Generic.List<global::Motorola.Common.Communication.SequenceManager.RamDataObjectInfo> repeaterDataObjectsFlashed, bool dualBrick, int fileCount, global::Motorola.Common.Communication.SequenceManager.ProgressInfoObject progressData, global::Motorola.Common.Communication.IProgressIndicator ProgressIndicator)
		{
			foreach (string value in Imagefilepaths)
			{
				if (string.IsNullOrEmpty(value))
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgument);
				}
			}
			int num = progressData.startScope;
			foreach (string fileName in Imagefilepaths)
			{
				ProgressIndicator.SetCurrentScope(num, num + progressData.percentPerOperation);
				ProgressIndicator.UpdateProgress(0.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WriteImage);
				this.WriteFile(fileName, ProgressIndicator);
				num += progressData.percentPerOperation;
			}
		}

		// Token: 0x06000237 RID: 567 RVA: 0x00013FB0 File Offset: 0x000121B0
		private void WriteFile(string fileName, global::Motorola.Common.Communication.IProgressIndicator ProgressIndicator)
		{
			try
			{
				if (!this.legacyUpdate)
				{
					global::Motorola.Common.Communication.Srecord srecord = this.LoadValidateSrecFile(fileName);
					global::Motorola.Common.Communication.SrecDataCollection dataRecords = srecord.DataRecords;
					int num = 0;
					foreach (global::Motorola.Common.Communication.SrecData srecData in dataRecords)
					{
						if (srecData.DataLen > 0U)
						{
							num += (int)(srecData.DataLen + (uint)global::Motorola.Common.Communication.MemoryStreamDataBlock.DataBlockHdrSize);
						}
					}
					uint num2 = 0U;
					int num3 = 0;
					byte[] array = new byte[num];
					foreach (global::Motorola.Common.Communication.SrecData srecData in dataRecords)
					{
						uint address = srecData.Address;
						byte[] data = srecData.GetData();
						if (data == null || srecData.DataLen == 0U)
						{
							if (srecData.Type != global::Motorola.Common.Communication.SrecType.S7 && srecData.Type != global::Motorola.Common.Communication.SrecType.S8 && srecData.Type != global::Motorola.Common.Communication.SrecType.S9)
							{
								throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidSrecordData);
							}
						}
						else
						{
							global::Motorola.Common.Communication.MemoryStreamDataBlock memoryStreamDataBlock = new global::Motorola.Common.Communication.MemoryStreamDataBlock(address, srecData.DataLen, data);
							int num4 = memoryStreamDataBlock.Pack(array, num3);
							num3 += num4;
							num2 += 1U;
						}
					}
					if (this.useCompress)
					{
						int num5 = 65536;
						int num6 = num / 20 * 21 + num5;
						byte[] array2 = new byte[num6];
						uint count = (uint)num6;
						global::Motorola.Common.Communication.Compression.LZMAWrapper.DataCompress(array, array2, ref count, num5);
						this._WriteMemory("FILE", num2, array2.Take((int)count).ToArray<byte>(), ProgressIndicator);
					}
					else
					{
						this._WriteMemory("FILE", num2, array, ProgressIndicator);
					}
					ProgressIndicator.UpdateProgress(1.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WriteImage);
				}
			}
			catch (global::System.Exception)
			{
				throw;
			}
		}

		// Token: 0x06000238 RID: 568 RVA: 0x000141FC File Offset: 0x000123FC
		private void _WriteMemory(string fileID, uint numOfDataBlk, byte[] Data, global::Motorola.Common.Communication.IProgressIndicator ProgressIndicator)
		{
			this.ResetBroadcastReceiveEnvironment();
			this.messageExecutor.BroadcastDataMessageReceived += this.WriteMemory_BroadcastStatusMessageReceived;
			global::Motorola.Common.Communication.Rcmp.RcmpMemoryStreamWrite rcmpMemoryStreamWrite = new global::Motorola.Common.Communication.Rcmp.RcmpMemoryStreamWrite(fileID, (uint)Data.Length);
			this.messageExecutor.SendAndReceiveMessage(rcmpMemoryStreamWrite);
			if (rcmpMemoryStreamWrite.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				global::Motorola.Common.Communication.RcmpMemoryStreamWriteBroadcast rcmpMemoryStreamWriteBroadcast = new global::Motorola.Common.Communication.RcmpMemoryStreamWriteBroadcast(fileID, numOfDataBlk, Data);
				rcmpMemoryStreamWriteBroadcast.hasReply = false;
				this.messageExecutor.SendAndReceiveMessage(rcmpMemoryStreamWriteBroadcast);
				if (rcmpMemoryStreamWriteBroadcast.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
				{
					if (this.WaitOnBackgroundOperation(ProgressIndicator))
					{
						global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("RP-Write File Done. ", new object[0]);
					}
				}
			}
		}

		// Token: 0x06000239 RID: 569 RVA: 0x000142AC File Offset: 0x000124AC
		private void WriteMemory_BroadcastStatusMessageReceived(object sender, global::Motorola.Common.Communication.RnlBrdcstMsgEventArgs e)
		{
			this.msWriteStatusBroadcast = new global::Motorola.Common.Communication.RcmpMemoryStreamStatusBroadcast("FILE");
			byte[] payload = e.packet.payload;
			try
			{
				this.msWriteStatusBroadcast.DecodeReplyMessage(e.packet.payload, 0, (int)e.packet.payloadLength);
				if (this.msWriteStatusBroadcast.Status == global::Motorola.Common.Communication.MemoryStreamStatus.Success && this.msWriteStatusBroadcast.Progress == 100 && this.msWriteStatusBroadcast.FILEID == "FILE")
				{
					this.operationProgress = global::Motorola.Common.Communication.SequenceManager.PCRRPOperations.OPERATION_DONE;
				}
				else if (this.msWriteStatusBroadcast.Status == global::Motorola.Common.Communication.MemoryStreamStatus.Flash_failed || this.msWriteStatusBroadcast.Status == global::Motorola.Common.Communication.MemoryStreamStatus.Transfer_failed)
				{
					this.operationProgress = global::Motorola.Common.Communication.SequenceManager.PCRRPOperations.OPERATION_FAILED;
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("RP: Broadcast writing...status={0}, progress={1}.", new object[]
					{
						this.msWriteStatusBroadcast.Status.ToString(),
						this.msWriteStatusBroadcast.Progress
					});
				}
				else
				{
					if (this.msWriteStatusBroadcast.Status == global::Motorola.Common.Communication.MemoryStreamStatus.Transfer_in_progress)
					{
						this.operationProgress = (int)((double)this.msWriteStatusBroadcast.Progress * (1.0 - global::Motorola.Common.Communication.RcmpMemoryStreamStatusBroadcast.FLASH_PROGRESS_PROPORTION));
					}
					else if (this.msWriteStatusBroadcast.Status == global::Motorola.Common.Communication.MemoryStreamStatus.Flash_in_progress)
					{
						this.operationProgress = (int)(100.0 * (1.0 - global::Motorola.Common.Communication.RcmpMemoryStreamStatusBroadcast.FLASH_PROGRESS_PROPORTION)) + (int)((double)this.msWriteStatusBroadcast.Progress * global::Motorola.Common.Communication.RcmpMemoryStreamStatusBroadcast.FLASH_PROGRESS_PROPORTION);
					}
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("RP: Broadcast writing...status={0}, progress={1}, whole_progress={2}.", new object[]
					{
						this.msWriteStatusBroadcast.Status.ToString(),
						this.msWriteStatusBroadcast.Progress,
						this.operationProgress
					});
				}
			}
			catch (global::System.Exception)
			{
				this.operationProgress = global::Motorola.Common.Communication.SequenceManager.PCRRPOperations.OPERATION_FAILED;
				throw;
			}
			finally
			{
				this.brdcstWaitHandle.Set();
				if (this.operationProgress == global::Motorola.Common.Communication.SequenceManager.PCRRPOperations.OPERATION_DONE || this.operationProgress == global::Motorola.Common.Communication.SequenceManager.PCRRPOperations.OPERATION_FAILED)
				{
					this.messageExecutor.BroadcastDataMessageReceived -= this.WriteMemory_BroadcastStatusMessageReceived;
				}
			}
		}

		// Token: 0x0600023A RID: 570 RVA: 0x00014538 File Offset: 0x00012738
		private void ResetBroadcastReceiveEnvironment()
		{
			this.operationProgress = 0;
			this.brdcstWaitHandle.Reset();
			this.msWriteStatusBroadcast = null;
			this.msReadBroadcast = null;
		}

		// Token: 0x0600023B RID: 571 RVA: 0x0001455C File Offset: 0x0001275C
		protected override global::Motorola.Common.Communication.Srecord LoadValidateSrecFile(string srecFile)
		{
			if (string.IsNullOrEmpty(srecFile))
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidSrecordFile);
			}
			global::Motorola.Common.Communication.Srecord result = null;
			global::Motorola.Common.Communication.Srecord srecord = null;
			try
			{
				global::System.IO.FileInfo fileInfo = new global::System.IO.FileInfo(srecFile);
				srecord = new global::Motorola.Common.Communication.Srecord();
				srecord.LoadSrecordData(srecFile, (int)fileInfo.Length, false);
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

		// Token: 0x0600023C RID: 572 RVA: 0x0001460C File Offset: 0x0001280C
		internal override void RemoteConnect(ushort deviceID)
		{
			uint failure = (uint)global::Motorola.Common.Communication.PCRRemoteProgramming.PCRRPConstants.FAILURE;
			try
			{
				if (!this.legacyUpdate)
				{
					base.RemoteConnect(deviceID);
				}
			}
			catch (global::Motorola.Common.CustomException.CommonException)
			{
				throw;
			}
		}

		// Token: 0x0600023D RID: 573 RVA: 0x00014654 File Offset: 0x00012854
		internal override void RemoteDisconnect()
		{
			uint failure = (uint)global::Motorola.Common.Communication.PCRRemoteProgramming.PCRRPConstants.FAILURE;
			try
			{
				if (!this.legacyUpdate)
				{
					base.RemoteDisconnect();
				}
			}
			catch (global::Motorola.Common.CustomException.CommonException)
			{
				throw;
			}
		}

		// Token: 0x0600023E RID: 574 RVA: 0x0001469C File Offset: 0x0001289C
		internal override ushort DiscoverRemoteDevice()
		{
			uint failure = (uint)global::Motorola.Common.Communication.PCRRemoteProgramming.PCRRPConstants.FAILURE;
			ushort result;
			try
			{
				ushort num = 0;
				if (this.legacyUpdate)
				{
					if ((ulong)failure == (ulong)((long)global::Motorola.Common.Communication.PCRRemoteProgramming.PCRRPConstants.SUCCESS))
					{
					}
					result = num;
				}
				else
				{
					result = base.DiscoverRemoteDevice();
				}
			}
			catch (global::Motorola.Common.CustomException.CommonException)
			{
				throw;
			}
			return result;
		}

		// Token: 0x0600023F RID: 575 RVA: 0x000146F8 File Offset: 0x000128F8
		internal override void BootDuplicateSetup()
		{
			try
			{
				if (!this.legacyUpdate)
				{
					base.BootDuplicateSetup();
				}
			}
			catch (global::Motorola.Common.CustomException.CommonException)
			{
				throw;
			}
		}

		// Token: 0x06000240 RID: 576 RVA: 0x0001473C File Offset: 0x0001293C
		internal override void BootDuplicateDisable()
		{
			try
			{
				if (!this.legacyUpdate)
				{
					base.BootDuplicateDisable();
				}
			}
			catch (global::Motorola.Common.CustomException.CommonException)
			{
				throw;
			}
		}

		// Token: 0x06000241 RID: 577 RVA: 0x00014780 File Offset: 0x00012980
		internal override void BootCommit(uint[] RamAddressArray, uint[] FlashAddressArray, uint[] PayloadSizeArray, global::Motorola.Common.Communication.Rcmp.BootCommitFunctionType FPGAType, global::Motorola.Common.Communication.IProgressIndicator ProgressIndicator)
		{
			try
			{
				if (!this.legacyUpdate)
				{
					global::Motorola.Common.Communication.XcmpRadioUpdateControl xcmpRadioUpdateControl = new global::Motorola.Common.Communication.XcmpRadioUpdateControl(global::Motorola.Common.Communication.UpdateControlAction.CommitUpdate, 0);
					this.messageExecutor.SendAndReceiveMessage(xcmpRadioUpdateControl);
					if (xcmpRadioUpdateControl.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
					{
					}
				}
			}
			catch (global::System.Exception)
			{
				throw;
			}
		}

		// Token: 0x06000242 RID: 578 RVA: 0x000147E4 File Offset: 0x000129E4
		internal override void ResetRadioNormal()
		{
			try
			{
				if (!this.legacyUpdate)
				{
					base.ResetRadioNormal();
				}
			}
			catch (global::System.Exception)
			{
				throw;
			}
		}

		// Token: 0x06000243 RID: 579 RVA: 0x00014828 File Offset: 0x00012A28
		public void EnableDecompression()
		{
			byte type = 1;
			global::Motorola.Common.Communication.XcmpRadioUpdateControl xcmpRadioUpdateControl = new global::Motorola.Common.Communication.XcmpRadioUpdateControl(global::Motorola.Common.Communication.UpdateControlAction.SetDecomp, type);
			this.messageExecutor.SendAndReceiveMessage(xcmpRadioUpdateControl);
			if (xcmpRadioUpdateControl.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
			}
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00014860 File Offset: 0x00012A60
		private void DisableDecompression()
		{
			byte type = 0;
			global::Motorola.Common.Communication.XcmpRadioUpdateControl xcmpRadioUpdateControl = new global::Motorola.Common.Communication.XcmpRadioUpdateControl(global::Motorola.Common.Communication.UpdateControlAction.SetDecomp, type);
			this.messageExecutor.SendAndReceiveMessage(xcmpRadioUpdateControl);
			if (xcmpRadioUpdateControl.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
			}
		}

		// Token: 0x06000245 RID: 581 RVA: 0x00014898 File Offset: 0x00012A98
		protected virtual void Dispose(bool disposing)
		{
			if (!this.m_IsDisposed)
			{
				if (disposing)
				{
					if (this.brdcstWaitHandle != null)
					{
						this.brdcstWaitHandle.Close();
						this.brdcstWaitHandle.Dispose();
					}
				}
				this.m_IsDisposed = true;
			}
		}

		// Token: 0x06000246 RID: 582 RVA: 0x000148EA File Offset: 0x00012AEA
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x04000174 RID: 372
		private static readonly int OPERATION_DONE = 10000;

		// Token: 0x04000175 RID: 373
		private static readonly int OPERATION_FAILED = -1;

		// Token: 0x04000176 RID: 374
		private global::Motorola.Common.Communication.SequenceManager.PCRRPRcmpMessageExecutor messageExecutor = null;

		// Token: 0x04000177 RID: 375
		private global::System.Threading.AutoResetEvent brdcstWaitHandle;

		// Token: 0x04000178 RID: 376
		private int operationProgress = 0;

		// Token: 0x04000179 RID: 377
		private global::Motorola.Common.Communication.RcmpMemoryStreamReadBroadcast msReadBroadcast;

		// Token: 0x0400017A RID: 378
		private global::Motorola.Common.Communication.RcmpMemoryStreamStatusBroadcast msWriteStatusBroadcast;

		// Token: 0x0400017B RID: 379
		private bool legacyUpdate = false;

		// Token: 0x0400017C RID: 380
		private bool useCompress = true;

		// Token: 0x0400017D RID: 381
		private bool m_IsDisposed;

		// Token: 0x02000048 RID: 72
		// (Invoke) Token: 0x0600024A RID: 586
		private delegate bool UpdateProgressDelegate(global::Motorola.Common.Communication.IProgressIndicator ProgressIndicator);
	}
}
