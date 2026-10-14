using System;
using System.Threading;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Rcmp;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.SequenceManager
{
	// Token: 0x0200002C RID: 44
	internal class PcrBootExecutor
	{
		// Token: 0x06000152 RID: 338 RVA: 0x0000BEA8 File Offset: 0x0000A0A8
		public PcrBootExecutor(global::Motorola.Common.Communication.IMessageExecutor rcmpWrapper)
		{
			if (rcmpWrapper == null)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
			}
			this.m_RcmpWrapper = (global::Motorola.Common.Communication.SequenceManager.PcrRcmpMessageExecutor)rcmpWrapper;
		}

		// Token: 0x06000153 RID: 339 RVA: 0x0000BEE0 File Offset: 0x0000A0E0
		private bool EnterBootMode()
		{
			global::Motorola.Common.Communication.Rcmp.XcmpEnterBootMode xcmpEnterBootMode = new global::Motorola.Common.Communication.Rcmp.XcmpEnterBootMode();
			this.m_RcmpWrapper.SetMessageTimeout(6500);
			this.m_RcmpWrapper.SendAndReceiveMessage(xcmpEnterBootMode);
			if (xcmpEnterBootMode.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.EnterBootModeFailure);
			}
			return true;
		}

		// Token: 0x06000154 RID: 340 RVA: 0x0000BF30 File Offset: 0x0000A130
		public byte[] ReadMemory64KBlocks(int startAddress, int endAddress, global::Motorola.Common.Communication.IProgressIndicator ProgressIndicator)
		{
			if (endAddress <= startAddress)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgument);
			}
			int num = endAddress - startAddress + 1;
			int i = num;
			byte[] array = new byte[num];
			int num2 = 0;
			int num3 = 65536;
			int num4 = startAddress;
			byte[] result;
			try
			{
				while (i > 0)
				{
					if (i < 65536)
					{
						num3 = i;
					}
					byte[] array2 = this.ReadMemory64K(num4, num3);
					if (array2 == null || array2.Length < num3)
					{
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ReadMemoryBlocksFailure);
					}
					if (ProgressIndicator != null)
					{
						double percent = (double)num2 / (double)num;
						ProgressIndicator.UpdateProgress(percent, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ReadingBootData);
					}
					global::System.Array.Copy(array2, 0, array, num2, array2.Length);
					global::System.Array.Clear(array2, 0, array2.Length);
					num2 += num3;
					num4 += num3;
					i -= num3;
				}
				int num5 = num2;
				if (num5 != num)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.IncompleteReadMemoryBlocksOperation);
				}
				if (ProgressIndicator != null)
				{
					ProgressIndicator.UpdateProgress(1.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ReadingBootData);
				}
				result = array;
			}
			catch (global::Motorola.Common.CustomException.CommonException systemException)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ReadMemoryBlocksFailure, systemException);
			}
			return result;
		}

		// Token: 0x06000155 RID: 341 RVA: 0x0000C074 File Offset: 0x0000A274
		private byte[] ReadMemory64K(int startAddress, int numToRead)
		{
			if (numToRead == 0)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgument);
			}
			byte[] array = new byte[numToRead];
			int num = startAddress;
			int num2 = 0;
			int i = numToRead;
			int num3 = 906;
			byte[] result;
			try
			{
				while (i > 0)
				{
					if (i < 906)
					{
						num3 = i;
					}
					global::Motorola.Common.Communication.Rcmp.RcmpReadMemory rcmpReadMemory = new global::Motorola.Common.Communication.Rcmp.RcmpReadMemory((uint)num, (ushort)num3);
					this.m_RcmpWrapper.SetMessageTimeout(11500);
					this.m_RcmpWrapper.SendAndReceiveMessage(rcmpReadMemory);
					if (rcmpReadMemory.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
					{
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ReadMemory64KFailure);
					}
					byte[] byteData = rcmpReadMemory.ByteData;
					global::System.Array.Copy(byteData, 0, array, num2, byteData.Length);
					num += byteData.Length;
					num2 += byteData.Length;
					i -= byteData.Length;
					global::System.Array.Clear(byteData, 0, byteData.Length);
				}
				if (num2 != numToRead)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.IncompleteReadMemory64KOperation);
				}
				result = array;
			}
			catch (global::Motorola.Common.CustomException.CommonException systemException)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ReadMemory64KFailure, systemException);
			}
			return result;
		}

		// Token: 0x06000156 RID: 342 RVA: 0x0000C19C File Offset: 0x0000A39C
		public bool WriteMemory64KBlocks(int startAddress, int numToWrite, byte[] data, global::Motorola.Common.Communication.SequenceManager.ProgressInfoObject progBarData, global::Motorola.Common.Communication.IProgressIndicator ProgressIndicator)
		{
			if (numToWrite == 0 || data == null)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgument);
			}
			int i = numToWrite;
			byte[] array = new byte[data.Length];
			global::System.Array.Copy(data, array, data.Length);
			int num = 0;
			int num2 = startAddress;
			bool result;
			try
			{
				while (i > 0)
				{
					int num3;
					if (i < 65536)
					{
						num3 = i;
					}
					else
					{
						num3 = 65536;
					}
					byte[] array2 = new byte[num3];
					global::System.Array.Clear(array2, 0, array2.Length);
					global::System.Array.Copy(array, num, array2, 0, num3);
					if (!this.WriteMemory64K(num2, num3, array2))
					{
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.WriteMemoryBlocksFailure);
					}
					num += num3;
					num2 += num3;
					i -= num3;
					if (ProgressIndicator != null && progBarData != null)
					{
						double num4 = (double)num / (double)numToWrite;
						double num5 = (double)progBarData.startScope + (double)(progBarData.endScope - progBarData.startScope) * num4;
						ProgressIndicator.UpdateProgress(num5 / 100.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WritingBootData);
					}
				}
				int num6 = num;
				if (numToWrite != num6)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.IncompleteWriteMemoryBlocksOperation);
				}
				result = true;
			}
			catch (global::Motorola.Common.CustomException.CommonException systemException)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.WriteMemoryBlocksFailure, systemException);
			}
			return result;
		}

		// Token: 0x06000157 RID: 343 RVA: 0x0000C300 File Offset: 0x0000A500
		private bool WriteMemory64K(int startAddr, int lengthToWrite, byte[] blockData)
		{
			if (lengthToWrite == 0 || blockData == null)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgument);
			}
			byte[] array = new byte[blockData.Length];
			global::System.Array.Copy(blockData, array, blockData.Length);
			int num = startAddr;
			int num2 = 0;
			int i = lengthToWrite;
			int num3 = 907;
			int num4 = 0;
			bool result;
			try
			{
				while (i > 0)
				{
					if (i < 907)
					{
						num3 = i;
					}
					byte[] array2 = new byte[num3];
					global::System.Array.Copy(array, num2, array2, 0, num3);
					global::Motorola.Common.Communication.RcmpWriteMemory rcmpWriteMemory = new global::Motorola.Common.Communication.RcmpWriteMemory((uint)num, (ushort)num3, array2);
					this.m_RcmpWrapper.SetMessageTimeout(6500);
					this.m_RcmpWrapper.SendAndReceiveMessage(rcmpWriteMemory);
					if (rcmpWriteMemory.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
					{
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.WriteMemory64KFailure);
					}
					num += num3;
					num2 += num3;
					num4 += num3;
					i -= num3;
					global::System.Array.Clear(array2, 0, array2.Length);
				}
				if (num4 != lengthToWrite)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.IncompleteWriteMemory64KOperation);
				}
				result = true;
			}
			catch (global::Motorola.Common.CustomException.CommonException systemException)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.WriteMemory64KFailure, systemException);
			}
			return result;
		}

		// Token: 0x06000158 RID: 344 RVA: 0x0000C440 File Offset: 0x0000A640
		public bool isRamDloaderRunning()
		{
			global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation rcmpVersionInformation = new global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation(global::Motorola.Common.Communication.Rcmp.VersionInfoType.RamdownloaderVersion);
			this.m_RcmpWrapper.SetMessageTimeout(6500);
			this.m_RcmpWrapper.SendAndReceiveMessage(rcmpVersionInformation);
			this.m_RcmpWrapper.SetMessageTimeout(20000);
			bool result;
			if (rcmpVersionInformation.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				string versionInformation = rcmpVersionInformation.VersionInformation;
				result = !string.IsNullOrEmpty(versionInformation);
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000159 RID: 345 RVA: 0x0000C4BC File Offset: 0x0000A6BC
		public bool Unlock()
		{
			byte[] array = this.ReadRadioKey();
			if (array == null)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ReadRadioKeyFailure);
			}
			byte[] encryptedRadioKey = global::Motorola.Common.Communication.SequenceManager.PcrBootExecutor.EncryptKey(array);
			if (!this.UnlockSecurity(encryptedRadioKey))
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.SecurityUnlockFailure);
			}
			return true;
		}

		// Token: 0x0600015A RID: 346 RVA: 0x0000C514 File Offset: 0x0000A714
		private byte[] ReadRadioKey()
		{
			global::Motorola.Common.Communication.Rcmp.RcmpReadRadioKey rcmpReadRadioKey = new global::Motorola.Common.Communication.Rcmp.RcmpReadRadioKey();
			this.m_RcmpWrapper.SetMessageTimeout(2500);
			this.m_RcmpWrapper.SendAndReceiveMessage(rcmpReadRadioKey);
			if (rcmpReadRadioKey.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ReadRadioKeyFailure);
			}
			return rcmpReadRadioKey.RadioKey;
		}

		// Token: 0x0600015B RID: 347 RVA: 0x0000C56C File Offset: 0x0000A76C
		private bool UnlockSecurity(byte[] encryptedRadioKey)
		{
			global::Motorola.Common.Communication.Rcmp.RcmpUnlockSecurity rcmpUnlockSecurity = new global::Motorola.Common.Communication.Rcmp.RcmpUnlockSecurity(encryptedRadioKey);
			this.m_RcmpWrapper.SetMessageTimeout(3500);
			this.m_RcmpWrapper.SendAndReceiveMessage(rcmpUnlockSecurity);
			if (rcmpUnlockSecurity.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.SecurityUnlockFailure);
			}
			return true;
		}

		// Token: 0x0600015C RID: 348 RVA: 0x0000C5C0 File Offset: 0x0000A7C0
		private static byte[] EncryptKey(byte[] radioKey)
		{
			if (radioKey == null)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgument);
			}
			int num = 1374194977;
			byte[] array = new byte[32];
			for (int i = 0; i < 32; i++)
			{
				byte b = radioKey[i];
				for (int j = 7; j > 0; j--)
				{
					int num2 = (num >> 9 & 1) ^ (radioKey[32 - i - 1] >> j & 1);
					num = (num << 1) + num2;
					b ^= (byte)(num2 << j);
				}
				array[i] = b;
			}
			return array;
		}

		// Token: 0x0600015D RID: 349 RVA: 0x0000C65C File Offset: 0x0000A85C
		public bool BootJumpExecution(uint s7Address)
		{
			global::Motorola.Common.Communication.Rcmp.RcmpBootJumpExecution rcmpBootJumpExecution = new global::Motorola.Common.Communication.Rcmp.RcmpBootJumpExecution(s7Address);
			this.m_RcmpWrapper.SetMessageTimeout(6500);
			this.m_RcmpWrapper.SendAndReceiveMessage(rcmpBootJumpExecution);
			if (rcmpBootJumpExecution.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.BootJumpExecutionFailure);
			}
			return true;
		}

		// Token: 0x0600015E RID: 350 RVA: 0x0000C6B0 File Offset: 0x0000A8B0
		public bool EraseFlashMemory(uint startAddress, uint endAddress)
		{
			global::Motorola.Common.Communication.RcmpEraseFlash rcmpEraseFlash = new global::Motorola.Common.Communication.RcmpEraseFlash(startAddress, endAddress);
			uint messageTimeout = (endAddress == startAddress) ? 1233500U : ((endAddress - startAddress) / 64000U * 1200U + 3200U + 1500U);
			this.m_RcmpWrapper.SetMessageTimeout((int)messageTimeout);
			this.m_RcmpWrapper.SendAndReceiveMessage(rcmpEraseFlash);
			if (rcmpEraseFlash.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.EraseFlashFailure);
			}
			return true;
		}

		// Token: 0x0600015F RID: 351 RVA: 0x0000C728 File Offset: 0x0000A928
		public bool BootCommit(uint[] RamAddressArray, uint[] FlashAddressArray, uint[] PayloadSizeArray, global::Motorola.Common.Communication.Rcmp.BootCommitFunctionType FPGAType, global::Motorola.Common.Communication.IProgressIndicator ProgressIndicator)
		{
			byte[] array = new byte[1500];
			byte[] array2 = new byte[1500];
			int num = 6;
			byte[] array3 = new byte[1500];
			byte[] array4 = new byte[1500];
			int i = 0;
			int num2 = 0;
			bool flag = false;
			bool flag2 = true;
			global::System.TimeSpan timeout = new global::System.TimeSpan(0, 0, 0, 0, 1000);
			global::System.TimeSpan timeout2 = new global::System.TimeSpan(0, 0, 0, 0, 5000);
			global::System.TimeSpan t = new global::System.TimeSpan(0, 0, 0, 0, 900000);
			global::System.TimeSpan timeSpan = new global::System.TimeSpan(0, 0, 0, 0, 2700000);
			while (num2 < 3 && !flag)
			{
				flag2 = true;
				global::System.Threading.Thread.Sleep(timeout);
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Boot write commit start on " + num2, new object[0]);
				global::Motorola.Common.Communication.Rcmp.RcmpBootWriteCommit rcmpBootWriteCommit = new global::Motorola.Common.Communication.Rcmp.RcmpBootWriteCommit(FPGAType, RamAddressArray, FlashAddressArray, PayloadSizeArray);
				int length = rcmpBootWriteCommit.BuildCommandMessage(array);
				int num3 = 0;
				try
				{
					this.m_RcmpWrapper.CommPipe.SendData(array, 0, length);
					num3 = this.m_RcmpWrapper.CommPipe.ReceiveData(array2, 0, 60000);
				}
				catch (global::System.Exception ex)
				{
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("RcmpBootWriteCommit CommitToFlash failed " + ex.Message, new object[0]);
					global::System.Threading.Thread.Sleep(timeout2);
					num2++;
					continue;
				}
				if (num3 > 906 + num)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.DataReceivedIsGreaterThanExpected);
				}
				rcmpBootWriteCommit.DecodeReplyMessage(array2, 0, num3);
				if (rcmpBootWriteCommit.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success || num3 == 0)
				{
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Boot write commit failed on " + num2, new object[0]);
					num2++;
				}
				else
				{
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Boot write commit succeeded on " + num2, new object[0]);
					i = 0;
					global::System.DateTime now = global::System.DateTime.Now;
					while (global::System.DateTime.Now - now < t && !flag && flag2)
					{
						global::System.Threading.Thread.Sleep(timeout);
						while (i <= 3)
						{
							global::Motorola.Common.Communication.Rcmp.RcmpBootWriteCommit rcmpBootWriteCommit2 = new global::Motorola.Common.Communication.Rcmp.RcmpBootWriteCommit(global::Motorola.Common.Communication.Rcmp.BootCommitFunctionType.QueryStatus, null, null, null);
							int length2 = rcmpBootWriteCommit2.BuildCommandMessage(array3);
							int num4 = 0;
							try
							{
								this.m_RcmpWrapper.CommPipe.SendData(array3, 0, length2);
								num4 = this.m_RcmpWrapper.CommPipe.ReceiveData(array4, 0, 120000);
							}
							catch (global::System.Exception ex)
							{
								global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("RcmpBootWriteCommit QueryStatus failed " + ex.Message, new object[0]);
								global::System.Threading.Thread.Sleep(timeout2);
								i++;
								break;
							}
							if (num4 == 0)
							{
								i++;
								break;
							}
							rcmpBootWriteCommit2.DecodeReplyMessage(array4, 0, num4);
							if (rcmpBootWriteCommit2.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
							{
								global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Boot write commit QueryStatus return failed on " + num2, new object[0]);
								flag2 = false;
								num2++;
								break;
							}
							i = 0;
							byte status = rcmpBootWriteCommit2.Status;
							if (ProgressIndicator != null)
							{
								double num5 = (double)status;
								ProgressIndicator.UpdateProgress(num5 / 100.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.BootCommitting);
							}
							global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Boot write commit QueryStatus progress= " + (int)status + "%", new object[0]);
							if (status == 100)
							{
								global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Boot write commit QueryStatus Complete.", new object[0]);
								flag = true;
								break;
							}
							global::System.Threading.Thread.Sleep(timeout2);
						}
					}
				}
			}
			return num2 != 3 || i != 3 || flag;
		}

		// Token: 0x06000160 RID: 352 RVA: 0x0000CB34 File Offset: 0x0000AD34
		public bool ResetRadioBoot()
		{
			global::Motorola.Common.Communication.Rcmp.RcmpRadioReset rcmpRadioReset = new global::Motorola.Common.Communication.Rcmp.RcmpRadioReset();
			this.m_RcmpWrapper.SetMessageTimeout(6500);
			this.m_RcmpWrapper.SendAndReceiveMessage(rcmpRadioReset);
			if (rcmpRadioReset.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RadioResetFailure);
			}
			return true;
		}

		// Token: 0x06000161 RID: 353 RVA: 0x0000CB84 File Offset: 0x0000AD84
		public bool ResetRadioNormal()
		{
			global::Motorola.Common.Communication.Rcmp.RcmpRadioReset rcmpRadioReset = new global::Motorola.Common.Communication.Rcmp.RcmpRadioReset();
			this.m_RcmpWrapper.SetMessageTimeout(6500);
			this.m_RcmpWrapper.SendAndReceiveMessage(rcmpRadioReset);
			if (rcmpRadioReset.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RadioResetFailure);
			}
			return true;
		}

		// Token: 0x06000162 RID: 354 RVA: 0x0000CBD4 File Offset: 0x0000ADD4
		public bool RemoteDuplicateSetup(global::Motorola.Common.Communication.Rcmp.RemoteDuplicateFunctionType function)
		{
			global::Motorola.Common.Communication.Rcmp.RcmpRemoteDuplicateSetup rcmpRemoteDuplicateSetup = new global::Motorola.Common.Communication.Rcmp.RcmpRemoteDuplicateSetup(function);
			this.m_RcmpWrapper.SetMessageTimeout(6500);
			this.m_RcmpWrapper.SendAndReceiveMessage(rcmpRemoteDuplicateSetup);
			if (rcmpRemoteDuplicateSetup.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RemoteDuplicateSetupFailure);
			}
			return true;
		}

		// Token: 0x06000163 RID: 355 RVA: 0x0000CC28 File Offset: 0x0000AE28
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

		// Token: 0x06000164 RID: 356 RVA: 0x0000CC70 File Offset: 0x0000AE70
		public bool RemoteConnect(ushort deviceId)
		{
			global::Motorola.Common.Communication.Rcmp.RcmpRemoteConnect rcmpRemoteConnect = new global::Motorola.Common.Communication.Rcmp.RcmpRemoteConnect(deviceId);
			this.m_RcmpWrapper.SetMessageTimeout(6500);
			this.m_RcmpWrapper.SendAndReceiveMessage(rcmpRemoteConnect);
			if (rcmpRemoteConnect.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RemoteConnectFailure);
			}
			return true;
		}

		// Token: 0x06000165 RID: 357 RVA: 0x0000CCC4 File Offset: 0x0000AEC4
		public bool RemoteDisconnect()
		{
			global::Motorola.Common.Communication.Rcmp.RcmpRemoteDisconnect rcmpRemoteDisconnect = new global::Motorola.Common.Communication.Rcmp.RcmpRemoteDisconnect();
			this.m_RcmpWrapper.SetMessageTimeout(6500);
			this.m_RcmpWrapper.SendAndReceiveMessage(rcmpRemoteDisconnect);
			if (rcmpRemoteDisconnect.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RemoteDisconnectFailure);
			}
			return true;
		}

		// Token: 0x06000166 RID: 358 RVA: 0x0000CD14 File Offset: 0x0000AF14
		public uint PsdtAccess(global::Motorola.Common.Communication.PsdtAccessAction action, string psdtSrcSectionId, string psdtTgtSectionId)
		{
			global::Motorola.Common.Communication.XcmpPsdtAccess xcmpPsdtAccess = new global::Motorola.Common.Communication.XcmpPsdtAccess(action, psdtSrcSectionId, psdtTgtSectionId);
			this.m_RcmpWrapper.SetMessageTimeout(6500);
			this.m_RcmpWrapper.SendAndReceiveMessage(xcmpPsdtAccess);
			if (xcmpPsdtAccess.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				return xcmpPsdtAccess.PsdtAddress;
			}
			if (xcmpPsdtAccess.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.OpcodeNotSupported)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.FZI_FZAP_OPCODE_NOT_SUPPORTED);
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.PsdtAccessFailure);
		}

		// Token: 0x06000167 RID: 359 RVA: 0x0000CD8C File Offset: 0x0000AF8C
		public bool ResetFPGABoot(global::Motorola.Common.Communication.Rcmp.FpgaOperationID fpgaID)
		{
			global::Motorola.Common.Communication.Rcmp.FpgaOperation fpgaOperation = new global::Motorola.Common.Communication.Rcmp.FpgaOperation(global::Motorola.Common.Communication.Rcmp.FPGAOperationType.Reconfigure, fpgaID);
			this.m_RcmpWrapper.SetMessageTimeout(6500);
			this.m_RcmpWrapper.SendAndReceiveMessage(fpgaOperation);
			if (fpgaOperation.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ResetFpgaFailure);
			}
			return true;
		}

		// Token: 0x040000AD RID: 173
		private const int NUM_RETRIES = 3;

		// Token: 0x040000AE RID: 174
		private const int OPERATION_COMPLETE = 100;

		// Token: 0x040000AF RID: 175
		private const int MAX_RETRY_TIMEOUT = 900;

		// Token: 0x040000B0 RID: 176
		private const int MAX_BOOTCOMMIT_TIMEOUT = 2700;

		// Token: 0x040000B1 RID: 177
		private const int MS_PER_SEC = 1000;

		// Token: 0x040000B2 RID: 178
		private global::Motorola.Common.Communication.SequenceManager.PcrRcmpMessageExecutor m_RcmpWrapper;
	}
}
