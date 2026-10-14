using System;
using System.Collections.Generic;
using System.Linq;
using fxpcommunication;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.Pba;
using Motorola.Common.Communication.PCRRemoteProgramming;

namespace Motorola.Common.Communication.SequenceManager
{
	// Token: 0x02000043 RID: 67
	public class PCRRPFileSequenceManager : global::Motorola.Common.Communication.SequenceManager.PcrDeviceUpdateFileSequencer
	{
		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000206 RID: 518 RVA: 0x00011E88 File Offset: 0x00010088
		// (set) Token: 0x06000207 RID: 519 RVA: 0x00011EA0 File Offset: 0x000100A0
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

		// Token: 0x06000208 RID: 520 RVA: 0x00011EAC File Offset: 0x000100AC
		protected override void UpdateMaxDataTransferSize()
		{
			if (this.isHugeMode)
			{
				base.IOController.MaxDataTransferSize = 65400;
			}
			else
			{
				base.IOController.MaxDataTransferSize = 1000;
			}
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00011EEF File Offset: 0x000100EF
		public PCRRPFileSequenceManager(global::Motorola.Common.Communication.SequenceManager.PCRRPRcmpMessageExecutor messageExecutor, int maxDataPayload) : base(messageExecutor, maxDataPayload)
		{
			this.MessageExecutor = messageExecutor;
			this.maxDataPayload = maxDataPayload;
		}

		// Token: 0x0600020A RID: 522 RVA: 0x00011F2F File Offset: 0x0001012F
		public PCRRPFileSequenceManager(global::Motorola.Common.Communication.SequenceManager.PCRRPRcmpMessageExecutor messageExecutor, int maxDataPayload, global::fxpcommunication.FxpCommunication rpFeatureEnable) : this(messageExecutor, maxDataPayload)
		{
			this.featureEnable = rpFeatureEnable;
			this.isHugeMode = false;
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00011F98 File Offset: 0x00010198
		protected global::Motorola.Common.Communication.Pba.PackedRadioData SyncCodeplug(global::Motorola.Common.Communication.Pba.PbaObject writePba)
		{
			global::Motorola.Common.Communication.CommonUtil.IshItemCollection radioIshItems = new global::Motorola.Common.Communication.CommonUtil.IshItemCollection();
			base.IshHandler.ReadIshPartions(radioIshItems, base.ProductFamily.ReadPartitions.ToArray(), base.ProgressIndicator, null);
			global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplugInIshItemCollection = writePba.GetCodeplugInIshItemCollection();
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader> ishTypeIDPariSetInRadio = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader>();
			radioIshItems.Headers.ToList<global::Motorola.Common.Communication.CommonUtil.IshHeader>().ForEach(delegate(global::Motorola.Common.Communication.CommonUtil.IshHeader header)
			{
				if (header.PartitionNumber == 128)
				{
					ishTypeIDPariSetInRadio.Add(header);
				}
			});
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader> ishItemsToDelete = base.GetIshItemsToDelete(writePba, ishTypeIDPariSetInRadio);
			ishItemsToDelete.ForEach(delegate(global::Motorola.Common.Communication.CommonUtil.IshHeader s)
			{
				radioIshItems.Remove(s);
			});
			foreach (global::Motorola.Common.Communication.CommonUtil.IshHeader ishHeader in codeplugInIshItemCollection.Headers)
			{
				if (ishHeader.PartitionNumber == 128)
				{
					global::Motorola.Common.Communication.CommonUtil.IshItem item = codeplugInIshItemCollection[ishHeader];
					if (radioIshItems.ContainsHeader(ishHeader))
					{
						radioIshItems.Update(ishHeader, item);
					}
					else
					{
						radioIshItems.Add(ishHeader, item);
					}
				}
			}
			global::Motorola.Common.Communication.Pba.PackedRadioData packedRadioData = new global::Motorola.Common.Communication.Pba.PackedRadioData();
			packedRadioData.Initialize(radioIshItems);
			packedRadioData.CPVersion = base.DeviceInfoFetcher.CodeplugVersion;
			return packedRadioData;
		}

		// Token: 0x0600020C RID: 524 RVA: 0x00012118 File Offset: 0x00010318
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

		// Token: 0x0600020D RID: 525 RVA: 0x000121B8 File Offset: 0x000103B8
		public void AssembleRPCommPipeForNormalOps()
		{
			global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe communicationPipe = new global::Motorola.Common.Communication.CommunicationPipe.NLCommPipe(this.MessageExecutor.CommPipe, global::Motorola.Common.Communication.CommunicationPipe.Constants.NLOptions.XNL_TRANSPORT, 100, 100, 400, 50);
			try
			{
				communicationPipe.OpenPort(global::Motorola.Common.Communication.PCRRemoteProgramming.PCRRPConstants.RPOpenPortTimeout);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.Common.Communication.CommunicationPipe.NLCommPipe nlcommPipe = communicationPipe as global::Motorola.Common.Communication.CommunicationPipe.NLCommPipe;
				if (nlcommPipe != null)
				{
					nlcommPipe.Dispose();
				}
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("RP: AssembleRPCommPipeForNormalOps() Failed..{0} ", new object[]
				{
					ex.Message
				});
			}
			this.MessageExecutor.CommPipe = communicationPipe;
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00012254 File Offset: 0x00010454
		private void AssembleRPCommPipeForUpdateOps()
		{
			global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe communicationPipe = new global::Motorola.Common.Communication.CommunicationPipe.NLCommPipe(this.MessageExecutor.CommPipe, global::Motorola.Common.Communication.CommunicationPipe.Constants.NLOptions.RNL_TRANSPORT, 100, 100, 400, 50);
			try
			{
				communicationPipe.OpenPort(global::Motorola.Common.Communication.PCRRemoteProgramming.PCRRPConstants.RPOpenPortTimeout);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.Common.Communication.CommunicationPipe.NLCommPipe nlcommPipe = communicationPipe as global::Motorola.Common.Communication.CommunicationPipe.NLCommPipe;
				if (nlcommPipe != null)
				{
					nlcommPipe.Dispose();
				}
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("RP: AssembleRPCommPipeForUpdateOps() Failed..{0} ", new object[]
				{
					ex.Message
				});
			}
			this.MessageExecutor.CommPipe = communicationPipe;
			this.MessageExecutor.ListenOnBroadcastMessage();
		}

		// Token: 0x0600020F RID: 527 RVA: 0x000122FC File Offset: 0x000104FC
		public override void UpdateDevice(global::Motorola.Common.Communication.Pba.PbaObject pbaObject, ushort sessionID)
		{
			this.SwitchRemoteDeviceToRPMode();
			this.SwitchHugeTransferMode(true);
			try
			{
				base.UpdateDevice(pbaObject, sessionID);
			}
			catch
			{
				throw;
			}
			finally
			{
				this.SwitchHugeTransferMode(false);
			}
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00012358 File Offset: 0x00010558
		public override global::Motorola.Common.Communication.Pba.UpdateDeviceData ReadImage(global::Motorola.Common.Communication.Pba.UpdateDeviceData images)
		{
			this.SwitchRemoteDeviceToRPMode();
			return base.ReadImage(images);
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00012378 File Offset: 0x00010578
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

		// Token: 0x06000212 RID: 530 RVA: 0x000123EC File Offset: 0x000105EC
		private static string GetPartitionIDFromImage(global::Motorola.Common.Communication.Pba.RadioImage image)
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

		// Token: 0x06000213 RID: 531 RVA: 0x00012458 File Offset: 0x00010658
		private void SwitchHugeTransferMode(bool bHugeMode)
		{
			global::Motorola.Common.Communication.CommunicationPipe.NLCommPipe nlcommPipe = this.MessageExecutor.CommPipe as global::Motorola.Common.Communication.CommunicationPipe.NLCommPipe;
			global::Motorola.Common.Communication.CommunicationPipe.P2PCommPipe p2PCommPipe = nlcommPipe.LowerPipe as global::Motorola.Common.Communication.CommunicationPipe.P2PCommPipe;
			p2PCommPipe.IsInHugeMode = bHugeMode;
			this.isHugeMode = bHugeMode;
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00012494 File Offset: 0x00010694
		private bool SwitchRemoteDeviceToRPMode()
		{
			this.IsInRPMode = true;
			return true;
		}

		// Token: 0x04000165 RID: 357
		private global::Motorola.Common.Communication.SequenceManager.PCRRPRcmpMessageExecutor _messageExecutor = null;

		// Token: 0x04000166 RID: 358
		private int maxDataPayload;

		// Token: 0x04000167 RID: 359
		private bool IsInRPMode = false;

		// Token: 0x04000168 RID: 360
		private string rpUserName = string.Empty;

		// Token: 0x04000169 RID: 361
		private string rpPassword = string.Empty;

		// Token: 0x0400016A RID: 362
		private bool isHugeMode;
	}
}
