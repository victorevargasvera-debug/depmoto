using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Motorola.Common.Communication;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Pba;
using Motorola.Common.CustomException;

namespace Common.Communication.Simulator
{
	// Token: 0x02000008 RID: 8
	public class VirtualMotoDevice : global::Motorola.Common.Communication.IMotoDevice, global::Motorola.Common.Communication.CommonUtil.IObservable
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600001D RID: 29 RVA: 0x00002858 File Offset: 0x00000A58
		// (set) Token: 0x0600001E RID: 30 RVA: 0x00002860 File Offset: 0x00000A60
		public global::Motorola.Common.Communication.CommonUtil.DeviceInfo DeviceInfo { get; set; }

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600001F RID: 31 RVA: 0x00002869 File Offset: 0x00000A69
		// (set) Token: 0x06000020 RID: 32 RVA: 0x00002871 File Offset: 0x00000A71
		public global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo ExtendedDeviceInfo { get; set; }

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000021 RID: 33 RVA: 0x0000287A File Offset: 0x00000A7A
		// (set) Token: 0x06000022 RID: 34 RVA: 0x00002882 File Offset: 0x00000A82
		public bool DifferentialWriteCapableRadio { get; set; }

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000023 RID: 35 RVA: 0x0000288B File Offset: 0x00000A8B
		// (set) Token: 0x06000024 RID: 36 RVA: 0x00002893 File Offset: 0x00000A93
		public bool Active { get; set; }

		// Token: 0x06000025 RID: 37 RVA: 0x0000289C File Offset: 0x00000A9C
		public bool UpdateProgrammingStatus(global::Motorola.Common.Communication.CommonUtil.ProgrammingStatus status, ushort sessionID)
		{
			return true;
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000026 RID: 38 RVA: 0x0000289F File Offset: 0x00000A9F
		// (set) Token: 0x06000027 RID: 39 RVA: 0x000028AC File Offset: 0x00000AAC
		public global::Motorola.Common.Communication.CommonUtil.RadioState radioState
		{
			get
			{
				return this.DeviceInfo.RadioState;
			}
			set
			{
				this.DeviceInfo.RadioState = value;
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000028BC File Offset: 0x00000ABC
		public VirtualMotoDevice(global::Motorola.Common.Communication.IRadioProfile radioProf)
		{
			this.vrProf = (radioProf as global::Common.Communication.Simulator.VirtualRadioProfile);
			this.DeviceInfo = this.vrProf.Device.Key;
			this.pbaObject = this.vrProf.Device.Value;
			this.radioState = global::Motorola.Common.Communication.CommonUtil.RadioState.Ready;
			this.DeviceInfo.RadioID = this.vrProf.RadioID;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x0000292A File Offset: 0x00000B2A
		public ushort OpenSession(global::Motorola.Common.Communication.CommonUtil.RadioOperation operationType, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter)
		{
			if (operationType != global::Motorola.Common.Communication.CommonUtil.RadioOperation.Create && operationType != global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read && operationType != global::Motorola.Common.Communication.CommonUtil.RadioOperation.None)
			{
				this.isWriting = true;
			}
			else
			{
				this.isWriting = false;
			}
			this.operatingType = operationType;
			return 0;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002954 File Offset: 0x00000B54
		public void CloseSession(bool pendingDeploy)
		{
			if (this.isWriting)
			{
				global::Motorola.Common.Communication.CommonUtil.SingletonBase<global::Common.Communication.Simulator.VirtualDeviceDetector>.Instance().DetachDevice(this.vrProf);
				global::System.Threading.Thread.Sleep(2000);
				if (this.operatingType == global::Motorola.Common.Communication.CommonUtil.RadioOperation.Flash)
				{
					global::System.Threading.Thread.Sleep(8000);
					global::Motorola.Common.Communication.CommonUtil.SingletonBase<global::Common.Communication.Simulator.VirtualDeviceDetector>.Instance().AttachDevice(new global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.DeviceInfo, global::Motorola.Common.Communication.Pba.PbaObject>(this.DeviceInfo, this.pbaObject), true, true);
					return;
				}
				global::Motorola.Common.Communication.CommonUtil.SingletonBase<global::Common.Communication.Simulator.VirtualDeviceDetector>.Instance().AttachDevice(new global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.DeviceInfo, global::Motorola.Common.Communication.Pba.PbaObject>(this.DeviceInfo, this.pbaObject), true, false);
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000029D5 File Offset: 0x00000BD5
		public void FreeDeviceStatuse(bool closeConnectWithError)
		{
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000029D7 File Offset: 0x00000BD7
		public void Prefetch()
		{
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000029D9 File Offset: 0x00000BD9
		public bool WaitForReady(int timeout)
		{
			return true;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000029DC File Offset: 0x00000BDC
		public void Init(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation, global::Motorola.Common.Communication.IProgressIndicator progressIndicator)
		{
			this.progressIndicator = progressIndicator;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000029E5 File Offset: 0x00000BE5
		public global::Motorola.Common.Communication.CommonUtil.DeviceInfo ReadDeviceInfo()
		{
			return this.DeviceInfo.Copy();
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000029F2 File Offset: 0x00000BF2
		public global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo ReadExtendedDeviceInfo()
		{
			return this.ReadDeviceInfo() as global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000029FF File Offset: 0x00000BFF
		public global::Motorola.Common.Communication.Pba.PbaObject ReadDevice(global::Motorola.Common.Communication.Pba.PbaObject referencePba)
		{
			this.UpdateProcess(global::Common.Communication.Simulator.VRDefinitions.ReadTime);
			return this.pbaObject;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002A14 File Offset: 0x00000C14
		public global::Motorola.Common.Communication.Pba.PbaObject ReadBlocks<T>(global::System.Collections.Generic.ICollection<T> blockList)
		{
			if (blockList != null && blockList.Any<T>())
			{
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader>(blockList.Count);
				try
				{
					foreach (T t in blockList)
					{
						object obj = t;
						list.Add((global::Motorola.Common.Communication.CommonUtil.IshHeader)obj);
					}
				}
				catch (global::System.InvalidCastException systemException)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgumentType, systemException);
				}
				global::Motorola.Common.Communication.Pba.PbaObject pbaObject = new global::Motorola.Common.Communication.Pba.PbaObject();
				using (global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.DataPartition>.Enumerator enumerator2 = this.pbaObject.CodeplugData.DataPartitions.GetEnumerator())
				{
					if (enumerator2.MoveNext())
					{
						global::Motorola.Common.Communication.Pba.DataPartition dataPartition = enumerator2.Current;
						global::Motorola.Common.Communication.Pba.DataPartition dataPartition2 = new global::Motorola.Common.Communication.Pba.DataPartition
						{
							PartitionID = dataPartition.PartitionID,
							PartitionName = dataPartition.PartitionName,
							DataBlocks = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.DataBlock>()
						};
						foreach (global::Motorola.Common.Communication.Pba.DataBlock dataBlock in dataPartition.DataBlocks)
						{
							foreach (global::Motorola.Common.Communication.CommonUtil.IshHeader ishHeader in list)
							{
								if (ishHeader.IshID == dataBlock.BlockID && ishHeader.IshType == dataBlock.BlockType)
								{
									dataPartition2.DataBlocks.Add(dataBlock);
									break;
								}
							}
						}
						pbaObject.CodeplugData.DataPartitions.Add(dataPartition2);
						this.UpdateProcess(global::Common.Communication.Simulator.VRDefinitions.ReadTime);
						return pbaObject;
					}
				}
			}
			return null;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002BF4 File Offset: 0x00000DF4
		public global::Motorola.Common.Communication.Pba.PbaObject WriteDevice(global::Motorola.Common.Communication.Pba.PbaObject writePBA, string pcrNewPassword)
		{
			this.UpdateProcess(global::Common.Communication.Simulator.VRDefinitions.WriteTime);
			global::Motorola.Common.Communication.Pba.LanguagePackData languagePackData = this.pbaObject.LanguagePackData;
			this.pbaObject = writePBA;
			this.pbaObject.ValidationFields.Clear();
			if (writePBA.LanguagePackData == null || writePBA.LanguagePackData.LanguagePacks == null || writePBA.LanguagePackData.LanguagePacks.Count <= 0)
			{
				this.pbaObject.LanguagePackData = languagePackData;
			}
			return this.pbaObject;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002C69 File Offset: 0x00000E69
		public void ForceWriteDevice(global::Motorola.Common.Communication.Pba.PbaObject writePBA)
		{
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002C6B File Offset: 0x00000E6B
		public void UpdateSerialNumber(string serialNumber)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002C72 File Offset: 0x00000E72
		public void CBIProgramme()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002C79 File Offset: 0x00000E79
		public void DeviceControl(global::Motorola.Common.Communication.CommonUtil.DeviceControlInputParams inputParams, ref global::Motorola.Common.Communication.CommonUtil.DeviceControlOutputParams outputParams)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002C80 File Offset: 0x00000E80
		public byte[] ReadUnkillChallengeValue()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002C87 File Offset: 0x00000E87
		public void UnkillRadio(byte[] authenticationValue)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002C8E File Offset: 0x00000E8E
		public void InitDeviceParams()
		{
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002C90 File Offset: 0x00000E90
		public global::Motorola.Common.Communication.Pba.LanguagePackData ReadLanguagePacksInfo()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002C97 File Offset: 0x00000E97
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem> ReadFilesListInDir(global::Motorola.Common.Communication.Pba.FileItem dir)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002C9E File Offset: 0x00000E9E
		public global::Motorola.Common.Communication.Pba.FileItem ReadFile(global::Motorola.Common.Communication.Pba.FileItem file)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002CA5 File Offset: 0x00000EA5
		public void WriteFile(global::Motorola.Common.Communication.Pba.FileItem file)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002CAC File Offset: 0x00000EAC
		public void DeleteFile(global::Motorola.Common.Communication.Pba.FileItem file)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002CB3 File Offset: 0x00000EB3
		public long GetFileOrDirSize(global::Motorola.Common.Communication.Pba.FileItem fileOrDir)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002CBA File Offset: 0x00000EBA
		public void WriteLanguagePacks(global::Motorola.Common.Communication.Pba.LanguagePackData languagePackData)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002CC1 File Offset: 0x00000EC1
		public void DeleteLanguagePacks(global::Motorola.Common.Communication.Pba.LanguagePackData languagePackData)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002CC8 File Offset: 0x00000EC8
		public void UpgradeFlashStrap(global::Motorola.Common.Communication.Pba.PbaObject pbaObject)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002CCF File Offset: 0x00000ECF
		public void EraseRadio(global::System.Collections.Generic.List<string> sections)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002CD6 File Offset: 0x00000ED6
		public void EraseRadioFromTo(uint startAddress, uint size)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002CDD File Offset: 0x00000EDD
		public void UpgradeFDT(string destModel, string destCPVersion, string serialNumber)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002CE4 File Offset: 0x00000EE4
		public global::Motorola.Common.Communication.Pba.UpdateDeviceData ReadImage(global::Motorola.Common.Communication.Pba.UpdateDeviceData updateData)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002CEB File Offset: 0x00000EEB
		public global::Motorola.Common.Communication.CommonUtil.MemoryImage ReadImageByAddress(uint startAddress, uint size)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002CF2 File Offset: 0x00000EF2
		public void WriteImage(global::Motorola.Common.Communication.CommonUtil.MemoryImage image)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002CF9 File Offset: 0x00000EF9
		public void SwitchRadioMode(global::Motorola.Common.Communication.CommonUtil.DeviceMode mode)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002D00 File Offset: 0x00000F00
		public void UpdateRadioDisplay()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002D07 File Offset: 0x00000F07
		public void UpdateDevice(global::Motorola.Common.Communication.Pba.PbaObject updatePBA)
		{
			this.UpdateProcess(global::Common.Communication.Simulator.VRDefinitions.UpgradeTime);
			this.pbaObject = updatePBA;
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002D1B File Offset: 0x00000F1B
		public bool WriteRamdownloader(string filePath)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00002D22 File Offset: 0x00000F22
		public void SendFPGAErase(global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType fileType)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002D29 File Offset: 0x00000F29
		public void SendFPGAReset(global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType fileType)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00002D30 File Offset: 0x00000F30
		public global::Motorola.Common.Communication.CommonUtil.FDTInfo GetFdtInfo(global::Motorola.Common.Communication.CommonUtil.FDTType fdtType)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002D37 File Offset: 0x00000F37
		public void EnableFeature(string fwVersion, string serialNumber, string xmlHashInput, global::System.Collections.Generic.List<byte[]> featureCodeIDs)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002D3E File Offset: 0x00000F3E
		public string ReadHashInputAndValidate(global::Motorola.Common.Communication.Pba.PbaObject pbaObject, global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DataBlockItem> blockList)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002D45 File Offset: 0x00000F45
		public void Register(global::Motorola.Common.Communication.CommonUtil.IObserver anObserver)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002D4C File Offset: 0x00000F4C
		public void UnRegister(global::Motorola.Common.Communication.CommonUtil.IObserver anObserver)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002D53 File Offset: 0x00000F53
		public void SendUpdateIMEType(byte ime)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00002D5A File Offset: 0x00000F5A
		public void SendUpdateDateCode(byte[] datecode, ushort source)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00002D61 File Offset: 0x00000F61
		public global::Motorola.Common.Communication.Pba.LanguagePackData ReadTTSLanguagePacksInfo()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00002D68 File Offset: 0x00000F68
		public void WriteTTSLanguagePacks(global::Motorola.Common.Communication.Pba.LanguagePackData languagePackData)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002D6F File Offset: 0x00000F6F
		public void DeleteTTSLanguagePacks(global::Motorola.Common.Communication.Pba.LanguagePackData languagePackData)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00002D76 File Offset: 0x00000F76
		public void WaitForCancelReading()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00002D7D File Offset: 0x00000F7D
		public global::Motorola.Common.Communication.CommonUtil.PasswordStatus ValidateLocalPassword(string password)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00002D84 File Offset: 0x00000F84
		public void UpdateMACAddress(byte[] macAddress)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00002D8B File Offset: 0x00000F8B
		public void SynPrepareDevice()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002D94 File Offset: 0x00000F94
		private void UpdateProcess(int timer)
		{
			timer = global::System.Math.Max(timer, 1);
			int num = timer;
			while (timer > 0)
			{
				global::System.Threading.Thread.Sleep(1000);
				this.progressIndicator.UpdateProgress((double)(num - timer) / (double)timer);
				timer--;
			}
			this.progressIndicator.UpdateProgress(1.0);
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00002DE8 File Offset: 0x00000FE8
		public byte QueryRadioUpdateStatus()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0400000A RID: 10
		private global::Common.Communication.Simulator.VirtualRadioProfile vrProf;

		// Token: 0x0400000B RID: 11
		private bool isWriting;

		// Token: 0x0400000C RID: 12
		private global::Motorola.Common.Communication.Pba.PbaObject pbaObject;

		// Token: 0x0400000D RID: 13
		private global::Motorola.Common.Communication.IProgressIndicator progressIndicator;

		// Token: 0x0400000E RID: 14
		private global::Motorola.Common.Communication.CommonUtil.RadioOperation operatingType;
	}
}
