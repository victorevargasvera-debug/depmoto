using System;
using System.Threading;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.IshHandler;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication
{
	// Token: 0x0200000B RID: 11
	internal class IOControllerFlash : global::Motorola.Common.Communication.IshHandler.IOController
	{
		// Token: 0x0600006D RID: 109 RVA: 0x000048D5 File Offset: 0x00002AD5
		public IOControllerFlash(global::Motorola.Common.Communication.IMessageExecutor rcmpWrapper, int maxPacketSize) : base(rcmpWrapper, maxPacketSize, false)
		{
			this.m_RcmpWrapper = rcmpWrapper;
		}

		// Token: 0x0600006E RID: 110 RVA: 0x000048E8 File Offset: 0x00002AE8
		private void EraseFlash(uint startAddress, uint endAddress)
		{
			global::Motorola.Common.Communication.RcmpEraseFlash rcmpEraseFlash = new global::Motorola.Common.Communication.RcmpEraseFlash(startAddress, endAddress);
			this.m_RcmpWrapper.SendAndReceiveMessage(rcmpEraseFlash);
			if (rcmpEraseFlash.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateDevice_Astro_EraseFlashFailed);
			}
		}

		// Token: 0x0600006F RID: 111 RVA: 0x0000491C File Offset: 0x00002B1C
		private void WriteMemory(uint addressStart, ushort byteCount, byte[] byteData)
		{
			global::Motorola.Common.Communication.RcmpWriteMemory rcmpWriteMemory = new global::Motorola.Common.Communication.RcmpWriteMemory(addressStart, byteCount, byteData);
			this.m_RcmpWrapper.SendAndReceiveMessage(rcmpWriteMemory);
			if (rcmpWriteMemory.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateDevice_Astro_WriteMemoryFailed);
			}
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00004954 File Offset: 0x00002B54
		public global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult RadioUpdateControl(byte action, ref byte value)
		{
			global::Motorola.Common.Communication.XcmpRadioUpdateControl xcmpRadioUpdateControl = new global::Motorola.Common.Communication.XcmpRadioUpdateControl((global::Motorola.Common.Communication.UpdateControlAction)action);
			this.m_RcmpWrapper.SendAndReceiveMessage(xcmpRadioUpdateControl);
			value = xcmpRadioUpdateControl.Value;
			return (global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult)xcmpRadioUpdateControl.ReplyResult;
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00004984 File Offset: 0x00002B84
		private global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult RadioUpdateControl(byte action, byte type, ref byte value)
		{
			global::Motorola.Common.Communication.XcmpRadioUpdateControl xcmpRadioUpdateControl = new global::Motorola.Common.Communication.XcmpRadioUpdateControl((global::Motorola.Common.Communication.UpdateControlAction)action, type);
			this.m_RcmpWrapper.SendAndReceiveMessage(xcmpRadioUpdateControl);
			value = xcmpRadioUpdateControl.Value;
			return (global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult)xcmpRadioUpdateControl.ReplyResult;
		}

		// Token: 0x06000072 RID: 114 RVA: 0x000049B4 File Offset: 0x00002BB4
		public global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult UnlockSection(string sectionA, string sectionB, uint radioActive)
		{
			string text = sectionB;
			if (radioActive == 2U)
			{
				text = sectionA;
			}
			global::Motorola.Common.Communication.XcmpPsdtAccess xcmpPsdtAccess = new global::Motorola.Common.Communication.XcmpPsdtAccess(global::Motorola.Common.Communication.PsdtAccessAction.Unlock, text, text);
			this.m_RcmpWrapper.SendAndReceiveMessage(xcmpPsdtAccess);
			return (global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult)xcmpPsdtAccess.ReplyResult;
		}

		// Token: 0x06000073 RID: 115 RVA: 0x000049E8 File Offset: 0x00002BE8
		public global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult CopyActiveToInactive(string sectionA, string sectionB, uint radioActive)
		{
			string psdtSrcSectionId = sectionA;
			string text = sectionB;
			if (radioActive == 2U)
			{
				psdtSrcSectionId = sectionB;
				text = sectionA;
			}
			global::Motorola.Common.Communication.XcmpPsdtAccess xcmpPsdtAccess = new global::Motorola.Common.Communication.XcmpPsdtAccess(global::Motorola.Common.Communication.PsdtAccessAction.Erase, text, text);
			this.m_RcmpWrapper.SendAndReceiveMessage(xcmpPsdtAccess);
			global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult replyResult = (global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult)xcmpPsdtAccess.ReplyResult;
			if (replyResult == global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult.Success)
			{
				global::Motorola.Common.Communication.XcmpPsdtAccess xcmpPsdtAccess2 = new global::Motorola.Common.Communication.XcmpPsdtAccess(global::Motorola.Common.Communication.PsdtAccessAction.Copy, psdtSrcSectionId, text);
				this.m_RcmpWrapper.SendAndReceiveMessage(xcmpPsdtAccess2);
				replyResult = (global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult)xcmpPsdtAccess2.ReplyResult;
			}
			return replyResult;
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00004A44 File Offset: 0x00002C44
		public void PollBackgroundEraser(global::Motorola.Common.Communication.IOControllerFlash.ProgressCallback progressReport)
		{
			byte action = 3;
			byte b = 0;
			int num = 0;
			for (;;)
			{
				global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult sequenceManagerResult = this.RadioUpdateControl(action, ref b);
				if (sequenceManagerResult == global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult.Success && b != 100)
				{
					if (progressReport != null)
					{
						double progress = (double)b;
						progressReport(progress);
					}
					num++;
					if (num > 500)
					{
						break;
					}
					global::System.Threading.Thread.Sleep(1000);
				}
				if (sequenceManagerResult != global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult.Success)
				{
					goto Block_5;
				}
				if (sequenceManagerResult != global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult.Success || b == 100)
				{
					return;
				}
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Astro_BackgroundEraseTimeout);
			Block_5:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateDevice_Astro_BackgroundEraserPollFailed);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00004AB8 File Offset: 0x00002CB8
		public byte GetActivePartition(byte activePartitionType)
		{
			byte result = 0;
			global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult sequenceManagerResult = this.RadioUpdateControl(activePartitionType, ref result);
			if (sequenceManagerResult != global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult.Success)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateDevice_Astro_GetActivePartitionFailed);
			}
			return result;
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00004AE0 File Offset: 0x00002CE0
		public global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult StartDecompression()
		{
			byte action = 11;
			byte type = 1;
			byte b = 0;
			return this.RadioUpdateControl(action, type, ref b);
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00004B00 File Offset: 0x00002D00
		public void FlashComponent(string srecData, bool compressed, int maxDataPayload, global::Motorola.Common.Communication.IOControllerFlash.ProgressCallback progressReport)
		{
			if (string.IsNullOrEmpty(srecData))
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgument);
			}
			int num = 0;
			using (global::Motorola.Common.Communication.Srecord srecord = new global::Motorola.Common.Communication.Srecord())
			{
				srecord.LoadData(srecData, maxDataPayload, true);
				if (!compressed)
				{
					this.EraseFlash(srecord.AddressLow, srecord.AddressHigh);
				}
				byte[] array = new byte[4];
				for (int i = 0; i < srecord.DataRecords.Count; i++)
				{
					global::Motorola.Common.Communication.SrecData srecData2 = srecord.DataRecords[i];
					if (srecData2.Type == global::Motorola.Common.Communication.SrecType.S3)
					{
						num += (int)srecData2.DataLen;
						if (progressReport != null)
						{
							progressReport((double)num / (double)srecord.MaxDataSize);
						}
						uint num2 = global::System.Convert.ToUInt32(srecData2.Address);
						if (num2 == srecord.AddressLow)
						{
							byte[] data = srecData2.GetData();
							global::System.Array.Copy(data, array, array.Length);
							byte[] array2 = new byte[srecData2.DataLen - 4U];
							global::System.Array.Copy(data, 4L, array2, 0L, (long)((ulong)(srecData2.DataLen - 4U)));
							this.WriteMemory(num2 + 4U, (ushort)array2.Length, array2);
						}
						else
						{
							this.WriteMemory(num2, (ushort)srecData2.DataLen, srecData2.GetData());
						}
					}
				}
				this.WriteMemory(srecord.AddressLow, 4, array);
			}
		}

		// Token: 0x0400004B RID: 75
		private const int constFirmwareActiveA = 1;

		// Token: 0x0400004C RID: 76
		private const int constFirmwareActiveB = 2;

		// Token: 0x0400004D RID: 77
		private global::Motorola.Common.Communication.IMessageExecutor m_RcmpWrapper;

		// Token: 0x0200000C RID: 12
		// (Invoke) Token: 0x06000079 RID: 121
		public delegate void ProgressCallback(double progress);
	}
}
