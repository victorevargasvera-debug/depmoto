using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using fxpcommunication;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.Pba;
using Motorola.Common.Communication.PCRRemoteProgramming;
using Motorola.Common.Communication.Rcmp;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.SequenceManager
{
	// Token: 0x02000045 RID: 69
	public class PCRRPSequenceManager : global::Motorola.Common.Communication.SequenceManager.PcrDeviceUpdateBootSequencer
	{
		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000217 RID: 535 RVA: 0x0001254C File Offset: 0x0001074C
		// (set) Token: 0x06000218 RID: 536 RVA: 0x00012564 File Offset: 0x00010764
		private global::Motorola.Common.Communication.SequenceManager.PCRRPRcmpMessageExecutor MessageExecutor
		{
			get
			{
				return this._messageExecutor;
			}
			set
			{
				this._messageExecutor = value;
			}
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00012570 File Offset: 0x00010770
		public PCRRPSequenceManager(global::Motorola.Common.Communication.SequenceManager.PCRRPRcmpMessageExecutor messageExecutor, int maxDataPayload) : base(messageExecutor, maxDataPayload)
		{
			this.MessageExecutor = messageExecutor;
			this.maxDataPayload = maxDataPayload;
			this.m_maxDataPayload = 9568256;
			this.BootOperations = this.newPCRRPOperations(messageExecutor, this.m_maxDataPayload);
		}

		// Token: 0x0600021A RID: 538 RVA: 0x000125E7 File Offset: 0x000107E7
		public PCRRPSequenceManager(global::Motorola.Common.Communication.SequenceManager.PCRRPRcmpMessageExecutor messageExecutor, int maxDataPayload, global::fxpcommunication.FxpCommunication rpFeatureEnable) : this(messageExecutor, maxDataPayload)
		{
			this.featureEnable = rpFeatureEnable;
		}

		// Token: 0x0600021B RID: 539 RVA: 0x000125FC File Offset: 0x000107FC
		public bool ValidateRemotePassword(string username, string password)
		{
			bool flag = false;
			try
			{
				global::Motorola.Common.Communication.PCRRemoteProgramming.RPAuthenticationRequest msg = new global::Motorola.Common.Communication.PCRRemoteProgramming.RPAuthenticationRequest(this.IsInRPMode);
				this.MessageExecutor.SendAndReceiveMessage(msg);
				global::Motorola.Common.Communication.PCRRemoteProgramming.RPAuthenticationMessage rpauthenticationMessage = new global::Motorola.Common.Communication.PCRRemoteProgramming.RPAuthenticationMessage(username, password, this.IsInRPMode);
				this.MessageExecutor.SendAndReceiveMessage(rpauthenticationMessage);
				flag = rpauthenticationMessage.PASS;
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(ex.Message, new object[0]);
			}
			if (flag)
			{
				this.rpUserName = username;
				this.rpPassword = password;
			}
			return flag;
		}

		// Token: 0x0600021C RID: 540 RVA: 0x0001269C File Offset: 0x0001089C
		public void AssembleRPCommPipeForNormalOps()
		{
			global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe communicationPipe = null;
			try
			{
				communicationPipe = new global::Motorola.Common.Communication.CommunicationPipe.NLCommPipe(this.MessageExecutor.CommPipe, global::Motorola.Common.Communication.CommunicationPipe.Constants.NLOptions.XNL_TRANSPORT, 100, 100, 400, 50);
				try
				{
					communicationPipe.OpenPort(global::Motorola.Common.Communication.PCRRemoteProgramming.PCRRPConstants.RPOpenPortTimeout);
				}
				catch (global::System.Exception ex)
				{
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("RP: AssembleRPCommPipeForUpdateOps() Failed..{0} ", new object[]
					{
						ex.Message
					});
					throw;
				}
				this.MessageExecutor.CommPipe = communicationPipe;
			}
			catch (global::System.Exception)
			{
				if (communicationPipe != null)
				{
					(communicationPipe as global::Motorola.Common.Communication.CommunicationPipe.NLCommPipe).Dispose();
				}
				throw;
			}
			finally
			{
			}
		}

		// Token: 0x0600021D RID: 541 RVA: 0x0001275C File Offset: 0x0001095C
		private void AssembleRPCommPipeForUpdateOps()
		{
			if (!this.legacyUpdate)
			{
				global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe communicationPipe = null;
				try
				{
					communicationPipe = new global::Motorola.Common.Communication.CommunicationPipe.NLCommPipe(this.MessageExecutor.CommPipe, global::Motorola.Common.Communication.CommunicationPipe.Constants.NLOptions.RNL_TRANSPORT, 100, 100, 400, 50);
					try
					{
						communicationPipe.OpenPort(global::Motorola.Common.Communication.PCRRemoteProgramming.PCRRPConstants.RPOpenPortTimeout);
					}
					catch (global::System.Exception ex)
					{
						global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("RP: AssembleRPCommPipeForUpdateOps() Failed..{0} ", new object[]
						{
							ex.Message
						});
						throw;
					}
					this.MessageExecutor.CommPipe = communicationPipe;
					this.MessageExecutor.ListenOnBroadcastMessage();
					try
					{
						this.rxBrickAddr = this.BootOperations.DiscoverRemoteDevice();
						this.IsDualDevice = true;
					}
					catch (global::System.Exception)
					{
						global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("RP: Issue for discovering the remote device.", new object[0]);
						throw;
					}
					if (this.IsDualDevice)
					{
						this.BootOperations.BootDuplicateSetup();
						(this.BootOperations as global::Motorola.Common.Communication.SequenceManager.PCRRPOperations).EnableDecompression();
						this.BootOperations.BootDuplicateDisable();
					}
					else
					{
						(this.BootOperations as global::Motorola.Common.Communication.SequenceManager.PCRRPOperations).EnableDecompression();
					}
				}
				catch
				{
					if (communicationPipe != null)
					{
						(communicationPipe as global::Motorola.Common.Communication.CommunicationPipe.NLCommPipe).Dispose();
					}
					throw;
				}
				finally
				{
				}
			}
			else
			{
				global::Motorola.Common.Communication.CommunicationPipe.P2PCommPipe p2PCommPipe = this.MessageExecutor.CommPipe as global::Motorola.Common.Communication.CommunicationPipe.P2PCommPipe;
			}
		}

		// Token: 0x0600021E RID: 542 RVA: 0x0001290C File Offset: 0x00010B0C
		public override void UpdateDevice(global::Motorola.Common.Communication.Pba.PbaObject pbaObject, ushort sessionID)
		{
			this.SwitchRemoteDeviceToRPMode();
			base.UpdateDevice(pbaObject, sessionID);
		}

		// Token: 0x0600021F RID: 543 RVA: 0x00012920 File Offset: 0x00010B20
		public override global::Motorola.Common.Communication.Pba.UpdateDeviceData ReadImage(global::Motorola.Common.Communication.Pba.UpdateDeviceData images)
		{
			this.SwitchRemoteDeviceToRPMode();
			return this.ReadImageInternal(images);
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00012940 File Offset: 0x00010B40
		private global::Motorola.Common.Communication.Pba.UpdateDeviceData ReadImageInternal(global::Motorola.Common.Communication.Pba.UpdateDeviceData images)
		{
			if (images == null)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgument);
			}
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage> memoryImages = images.MemoryImages;
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage>();
			int num = 100 / memoryImages.Count<global::Motorola.Common.Communication.Pba.RadioImage>();
			int num2 = 0;
			int num3 = num;
			foreach (global::Motorola.Common.Communication.Pba.RadioImage radioImage in memoryImages)
			{
				global::Motorola.Common.Communication.Pba.PcrMemoryImage pcrMemoryImage = (global::Motorola.Common.Communication.Pba.PcrMemoryImage)radioImage;
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("RP: Reading Image {0}", new object[]
				{
					pcrMemoryImage.FileType.ToString()
				});
				if (pcrMemoryImage.FileType == global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.PSDT)
				{
					string filePath = pcrMemoryImage.FilePath;
					if (pcrMemoryImage.RemoteImage)
					{
						this.BootOperations.RemoteConnect(this.rxBrickAddr);
					}
					if (base.ProgressIndicator != null)
					{
						base.ProgressIndicator.SetCurrentScope(num2, num3);
					}
					this.ReadPSDT(pcrMemoryImage);
					if (base.ProgressIndicator != null)
					{
						num2 += num;
						num3 += num;
					}
					if (pcrMemoryImage.RemoteImage)
					{
						this.BootOperations.RemoteDisconnect();
					}
				}
				else if (!pcrMemoryImage.RemoteImage)
				{
					int startAddress = pcrMemoryImage.StartAddress;
					int endAddress = pcrMemoryImage.EndAddress;
					string filePath = pcrMemoryImage.FilePath;
					if (base.ProgressIndicator != null)
					{
						base.ProgressIndicator.SetCurrentScope(num2, num3);
					}
					this.ReadMemory(global::Motorola.Common.Communication.SequenceManager.PCRRPSequenceManager.GetPartitionIDFromImage(pcrMemoryImage), startAddress, endAddress, filePath, base.ProgressIndicator);
					if (base.ProgressIndicator != null)
					{
						num2 += num;
						num3 += num;
					}
				}
				else
				{
					list.Add(pcrMemoryImage);
				}
			}
			if (list.Count != 0)
			{
				try
				{
					this.BootOperations.RemoteConnect(this.rxBrickAddr);
					foreach (global::Motorola.Common.Communication.Pba.RadioImage radioImage2 in list)
					{
						global::Motorola.Common.Communication.Pba.PcrMemoryImage pcrMemoryImage2 = (global::Motorola.Common.Communication.Pba.PcrMemoryImage)radioImage2;
						int startAddress = pcrMemoryImage2.StartAddress;
						int endAddress = pcrMemoryImage2.EndAddress;
						string filePath = pcrMemoryImage2.FilePath;
						if (base.ProgressIndicator != null)
						{
							base.ProgressIndicator.SetCurrentScope(num2, num3);
						}
						this.ReadMemory(global::Motorola.Common.Communication.SequenceManager.PCRRPSequenceManager.GetPartitionIDFromImage(pcrMemoryImage2), startAddress, endAddress, filePath, base.ProgressIndicator);
						if (base.ProgressIndicator != null)
						{
							num2 += num;
							num3 += num;
						}
					}
					this.BootOperations.RemoteDisconnect();
				}
				catch (global::Motorola.Common.CustomException.CommonException)
				{
					throw;
				}
			}
			if (base.ProgressIndicator != null)
			{
				base.ProgressIndicator.SetCurrentScope(0, 100);
				base.ProgressIndicator.UpdateProgress(0.9, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ReadingBootData);
				base.ProgressIndicator.UpdateProgress(1.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ReadingBootDataDone);
			}
			return images;
		}

		// Token: 0x06000221 RID: 545 RVA: 0x00012CB8 File Offset: 0x00010EB8
		protected override void ReadMemory(string fileID, int startAddress, int endAddress, string filePath, global::Motorola.Common.Communication.IProgressIndicator ProgressIndicator)
		{
			try
			{
				if (!this.legacyUpdate)
				{
					(this.BootOperations as global::Motorola.Common.Communication.SequenceManager.PCRRPOperations).ReadMemory(fileID, startAddress, endAddress, filePath, ProgressIndicator);
				}
			}
			catch (global::System.Exception)
			{
				throw;
			}
		}

		// Token: 0x06000222 RID: 546 RVA: 0x00012D0C File Offset: 0x00010F0C
		protected override void UpgradeFWCP(global::Motorola.Common.Communication.Pba.PbaObject updateData)
		{
			global::Motorola.Common.Communication.Pba.UpdateDeviceData updateData2 = updateData.UpdateData;
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage> memoryImages = updateData2.MemoryImages;
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
			global::System.Collections.Generic.List<string> list2 = new global::System.Collections.Generic.List<string>();
			global::System.Collections.Generic.List<string> list3 = new global::System.Collections.Generic.List<string>();
			global::System.Collections.Generic.List<string> list4 = new global::System.Collections.Generic.List<string>();
			global::System.Collections.ArrayList arrayList = new global::System.Collections.ArrayList();
			global::System.Collections.ArrayList arrayList2 = new global::System.Collections.ArrayList();
			global::System.Collections.ArrayList arrayList3 = new global::System.Collections.ArrayList();
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.SequenceManager.RamDataObjectInfo> list5 = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.SequenceManager.RamDataObjectInfo>();
			int num = 0;
			global::Motorola.Common.Communication.SequenceManager.ProgressInfoObject progressInfoObject = new global::Motorola.Common.Communication.SequenceManager.ProgressInfoObject();
			progressInfoObject.percentPerOperation = 100 / memoryImages.Count<global::Motorola.Common.Communication.Pba.RadioImage>();
			foreach (global::Motorola.Common.Communication.Pba.RadioImage radioImage in memoryImages)
			{
				global::Motorola.Common.Communication.Pba.PcrMemoryImage pcrMemoryImage = (global::Motorola.Common.Communication.Pba.PcrMemoryImage)radioImage;
				if (string.IsNullOrEmpty(pcrMemoryImage.FilePath))
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgument);
				}
				string filePath = pcrMemoryImage.FilePath;
				if (!this.IsDualDevice)
				{
					list.Add(filePath);
				}
				if (this.IsDualDevice)
				{
					if (pcrMemoryImage.FileType == global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.SEC || pcrMemoryImage.FileType == global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.TUNE || pcrMemoryImage.FileType == global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.UCL)
					{
						if (pcrMemoryImage.RemoteImage)
						{
							list3.Add(filePath);
						}
						else
						{
							list4.Add(filePath);
							num++;
						}
					}
					else
					{
						list2.Add(filePath);
					}
				}
			}
			if (this.IsDualDevice)
			{
				bool dualBrick = false;
				if (list3.Count != 0 && list4.Count != 0)
				{
					global::System.Collections.Generic.List<global::Motorola.Common.Communication.SequenceManager.RamDataObjectInfo> list6 = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.SequenceManager.RamDataObjectInfo>();
					global::System.Collections.Generic.List<global::Motorola.Common.Communication.SequenceManager.RamDataObjectInfo> collection = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.SequenceManager.RamDataObjectInfo>();
					global::System.Collections.ArrayList c = new global::System.Collections.ArrayList();
					global::System.Collections.ArrayList c2 = new global::System.Collections.ArrayList();
					global::System.Collections.ArrayList c3 = new global::System.Collections.ArrayList();
					global::System.Collections.ArrayList arrayList4 = new global::System.Collections.ArrayList();
					global::System.Collections.ArrayList arrayList5 = new global::System.Collections.ArrayList();
					global::System.Collections.ArrayList arrayList6 = new global::System.Collections.ArrayList();
					if (base.ProgressIndicator != null)
					{
						progressInfoObject.endScope += progressInfoObject.percentPerOperation * list4.Count<string>();
					}
					this.BootOperations.WriteFiles(list4, ref c, ref c2, ref c3, ref collection, dualBrick, 0, progressInfoObject, base.ProgressIndicator);
					this.BootOperations.RemoteConnect(this.rxBrickAddr);
					if (base.ProgressIndicator != null)
					{
						progressInfoObject.startScope = progressInfoObject.endScope;
						progressInfoObject.endScope += progressInfoObject.percentPerOperation * list3.Count<string>();
					}
					this.BootOperations.WriteFiles(list3, ref arrayList4, ref arrayList5, ref arrayList6, ref list6, dualBrick, 0, progressInfoObject, base.ProgressIndicator);
					this.BootOperations.RemoteDisconnect();
					list5.AddRange(collection);
					arrayList.AddRange(c);
					arrayList2.AddRange(c2);
					arrayList3.AddRange(c3);
				}
				if (list2.Count != 0)
				{
					global::System.Collections.ArrayList c4 = new global::System.Collections.ArrayList();
					global::System.Collections.ArrayList c5 = new global::System.Collections.ArrayList();
					global::System.Collections.ArrayList c6 = new global::System.Collections.ArrayList();
					this.BootOperations.BootDuplicateSetup();
					if (list3.Count != 0 || list4.Count != 0)
					{
						dualBrick = true;
					}
					if (base.ProgressIndicator != null)
					{
						progressInfoObject.startScope = progressInfoObject.endScope;
						progressInfoObject.endScope += progressInfoObject.percentPerOperation * list2.Count<string>();
					}
					this.BootOperations.WriteFiles(list2, ref c4, ref c5, ref c6, ref list5, dualBrick, num, progressInfoObject, base.ProgressIndicator);
					arrayList.AddRange(c4);
					arrayList2.AddRange(c5);
					arrayList3.AddRange(c6);
					this.BootOperations.BootDuplicateDisable();
				}
			}
			if (!this.IsDualDevice)
			{
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.SequenceManager.RamDataObjectInfo> list7 = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.SequenceManager.RamDataObjectInfo>();
				bool dualBrick = false;
				if (base.ProgressIndicator != null)
				{
					progressInfoObject.endScope += progressInfoObject.percentPerOperation * list.Count<string>();
				}
				this.BootOperations.WriteFiles(list, ref arrayList, ref arrayList2, ref arrayList3, ref list7, dualBrick, 0, progressInfoObject, base.ProgressIndicator);
			}
			if (base.ProgressIndicator != null)
			{
				base.ProgressIndicator.SetCurrentScope(0, 100);
				base.ProgressIndicator.UpdateProgress(1.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WriteSoftwareDone);
			}
			uint[] ramAddressArray = global::Motorola.Common.Communication.SequenceManager.RamDataObjectInfo.ConvertToUintArray(arrayList);
			uint[] flashAddressArray = global::Motorola.Common.Communication.SequenceManager.RamDataObjectInfo.ConvertToUintArray(arrayList2);
			uint[] payloadSizeArray = global::Motorola.Common.Communication.SequenceManager.RamDataObjectInfo.ConvertToUintArray(arrayList3);
			if (this.IsDualDevice)
			{
				this.BootOperations.BootDuplicateSetup();
				this.BootOperations.BootCommit(ramAddressArray, flashAddressArray, payloadSizeArray, global::Motorola.Common.Communication.Rcmp.BootCommitFunctionType.CommitToFlash, base.ProgressIndicator);
				this.BootOperations.BootDuplicateDisable();
			}
			else
			{
				this.BootOperations.BootCommit(ramAddressArray, flashAddressArray, payloadSizeArray, global::Motorola.Common.Communication.Rcmp.BootCommitFunctionType.CommitToFlash, base.ProgressIndicator);
			}
			this.BootOperations.ResetRadioNormal();
			if (base.ProgressIndicator != null)
			{
				base.ProgressIndicator.UpdateProgress(1.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.BootCommittingDone);
			}
		}

		// Token: 0x06000223 RID: 547 RVA: 0x00013210 File Offset: 0x00011410
		public override void CloseSession(ushort sessionID, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation, bool pendingDeploy)
		{
			try
			{
				try
				{
					base.CloseSession(sessionID, operation, pendingDeploy);
				}
				finally
				{
					this.MessageExecutor.CommPipe.ClosePort();
				}
			}
			finally
			{
				this.IsInRPMode = false;
				this.rpUserName = string.Empty;
				this.rpPassword = string.Empty;
			}
		}

		// Token: 0x06000224 RID: 548 RVA: 0x00013284 File Offset: 0x00011484
		protected static string GetPartitionIDFromImage(global::Motorola.Common.Communication.Pba.RadioImage image)
		{
			string result = string.Empty;
			global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType fileType = image.FileType;
			if (fileType != global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.CPG_APP)
			{
				switch (fileType)
				{
				case global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.PSDT:
					result = "PSDX";
					break;
				case global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.SEC:
					result = "SECX";
					break;
				case global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.TUNE:
					result = "TUNX";
					break;
				case global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.UCL:
					result = "UCLX";
					break;
				}
			}
			else
			{
				result = "CPGX";
			}
			return result;
		}

		// Token: 0x06000225 RID: 549 RVA: 0x000132F0 File Offset: 0x000114F0
		protected bool SwitchRemoteDeviceToRPMode()
		{
			return this.SwitchRemoteDeviceToRPMode(false, null);
		}

		// Token: 0x06000226 RID: 550 RVA: 0x0001330C File Offset: 0x0001150C
		protected bool SwitchRemoteDeviceToRPMode(bool forceNewPassword, string pcrNewPassword)
		{
			bool result;
			if (this.IsInRPMode)
			{
				result = true;
			}
			else
			{
				bool flag = true;
				try
				{
					base.IOController.EnterProgramMode(7, null);
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("RP: Device Switch to RP Mode.. ", new object[0]);
				}
				catch (global::System.Exception ex)
				{
					flag = false;
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("RP: Failed to enter RP Mode.<{0}> ", new object[]
					{
						ex.Message
					});
				}
				global::Motorola.Common.Communication.CommunicationPipe.NLCommPipe nlcommPipe = this.MessageExecutor.CommPipe as global::Motorola.Common.Communication.CommunicationPipe.NLCommPipe;
				global::Motorola.Common.Communication.CommunicationPipe.P2PCommPipe p2PCommPipe = nlcommPipe.LowerPipe as global::Motorola.Common.Communication.CommunicationPipe.P2PCommPipe;
				int localPortNum = p2PCommPipe.LocalPortNum;
				global::Motorola.Common.Communication.PCRRemoteProgramming.TCPPortManager.Instance.Reserve(localPortNum);
				global::Motorola.Common.Communication.CommunicationPipe.P2PCommPipe p2PCommPipe2 = null;
				try
				{
					nlcommPipe.ClosePort();
					p2PCommPipe.ClosePort();
					p2PCommPipe2 = new global::Motorola.Common.Communication.CommunicationPipe.P2PCommPipe(this.newTcpListenerCommPipe(global::System.Net.IPAddress.Any, localPortNum), p2PCommPipe.AuthenticationInfo, p2PCommPipe.RemoteIPAddress, p2PCommPipe.TargetPeerID, global::Motorola.Common.Communication.PCRRemoteProgramming.PCRRPConstants.RPReceiveTimeout, true);
					p2PCommPipe2.OpenPort(global::Motorola.Common.Communication.PCRRemoteProgramming.PCRRPConstants.RPOpenPortTimeout);
				}
				catch (global::System.Exception)
				{
					flag = false;
					throw;
				}
				finally
				{
					global::Motorola.Common.Communication.PCRRemoteProgramming.TCPPortManager.Instance.Unreserve(localPortNum);
				}
				this.MessageExecutor.CommPipe = p2PCommPipe2;
				bool flag2;
				if (forceNewPassword)
				{
					flag2 = this.ValidateRemotePassword(this.rpUserName, pcrNewPassword);
				}
				else
				{
					flag2 = this.ValidateRemotePassword(this.rpUserName, this.rpPassword);
				}
				if (flag2)
				{
					p2PCommPipe2.Validated = true;
					this.AssembleRPCommPipeForUpdateOps();
				}
				this.IsInRPMode = flag;
				result = flag;
			}
			return result;
		}

		// Token: 0x06000227 RID: 551 RVA: 0x000134BC File Offset: 0x000116BC
		private global::Motorola.Common.Communication.CommunicationPipe.TcpListenerCommPipe newTcpListenerCommPipe(global::System.Net.IPAddress ipAddress, int portNumber)
		{
			return new global::Motorola.Common.Communication.CommunicationPipe.TcpListenerCommPipe(ipAddress, portNumber);
		}

		// Token: 0x06000228 RID: 552 RVA: 0x000134D8 File Offset: 0x000116D8
		private global::Motorola.Common.Communication.SequenceManager.PCRRPOperations newPCRRPOperations(global::Motorola.Common.Communication.SequenceManager.PcrRcmpMessageExecutor msgExecutor, int maxDataPayload)
		{
			return new global::Motorola.Common.Communication.SequenceManager.PCRRPOperations(msgExecutor, maxDataPayload);
		}

		// Token: 0x0400016B RID: 363
		private global::Motorola.Common.Communication.SequenceManager.PCRRPRcmpMessageExecutor _messageExecutor = null;

		// Token: 0x0400016C RID: 364
		private int maxDataPayload;

		// Token: 0x0400016D RID: 365
		private bool IsInRPMode = false;

		// Token: 0x0400016E RID: 366
		private string rpUserName = string.Empty;

		// Token: 0x0400016F RID: 367
		private string rpPassword = string.Empty;

		// Token: 0x04000170 RID: 368
		protected ushort rxBrickAddr = 0;

		// Token: 0x04000171 RID: 369
		private bool legacyUpdate = false;
	}
}
