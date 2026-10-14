using System;
using System.Linq;
using Motorola.Common.Communication;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.Rcmp;
using Motorola.Common.CustomException;

namespace SwitchOverManager
{
	// Token: 0x02000003 RID: 3
	public class SwitchOverManager
	{
		// Token: 0x06000003 RID: 3 RVA: 0x000020FF File Offset: 0x000002FF
		private SwitchOverManager()
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000004 RID: 4 RVA: 0x00002107 File Offset: 0x00000307
		public static global::SwitchOverManager.SwitchOverManager Instance
		{
			get
			{
				return global::SwitchOverManager.SwitchOverManager.switchOverManager;
			}
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002110 File Offset: 0x00000310
		public void SwitchOver(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, ushort sessionID, uint delayTime, global::Motorola.Common.Communication.CommonUtil.SwitchOverOption option)
		{
			if (deviceInfo == null || deviceInfo.ConnectionInfo == null || string.IsNullOrEmpty(deviceInfo.ConnectionInfo.UniqueAddress))
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
			}
			if (sessionID == 0)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgument);
			}
			using (global::Motorola.Common.Communication.CommunicationPipe.UdpCommPipe udpCommPipe = new global::Motorola.Common.Communication.CommunicationPipe.UdpCommPipe(4010, global::SwitchOverManager.SwitchOverConstants.GetIPAddress(deviceInfo.ConnectionInfo.UniqueAddress), 25000))
			{
				udpCommPipe.OpenPort(0);
				ushort action = (ushort)((global::Motorola.Common.Communication.CommonUtil.SwitchOverOption)32 | option);
				global::Motorola.Common.Communication.Rcmp.XcmpComponentSession xcmpComponentSession = new global::Motorola.Common.Communication.Rcmp.XcmpComponentSession(action, sessionID, delayTime);
				byte[] sendBuffer = new byte[20];
				int length = xcmpComponentSession.BuildCommandMessage(sendBuffer);
				this.DoSwitchOver(udpCommPipe, sendBuffer, length);
			}
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000021BC File Offset: 0x000003BC
		private void DoSwitchOver(global::Motorola.Common.Communication.CommunicationPipe.UdpCommPipe udpCommPipe, byte[] sendBuffer, int length)
		{
			int num = 0;
			for (int i = 0; i < 2; i++)
			{
				try
				{
					udpCommPipe.SendData(sendBuffer, 0, length);
					global::Motorola.Common.Communication.Rcmp.XcmpComponentSession xcmpComponentSession = null;
					byte[] array = udpCommPipe.ReceiveDataFrom(25000);
					ushort num2 = global::System.BitConverter.ToUInt16(global::System.BitConverter.IsLittleEndian ? array.Take(2).Reverse<byte>().ToArray<byte>() : array.Take(2).ToArray<byte>(), 0);
					ushort num3 = num2;
					if (num3 != 271)
					{
						if (num3 == 33039)
						{
							xcmpComponentSession = new global::Motorola.Common.Communication.Rcmp.XcmpComponentSession(0, 0);
							xcmpComponentSession.DecodeReplyMessage(array, 0, array.Length);
							global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Receive switchover reply id[{0}] result[{1}] action[{2}]", new object[]
							{
								xcmpComponentSession.ReplySessionId,
								xcmpComponentSession.ReplyResult,
								xcmpComponentSession.CompletedActions
							});
							if (xcmpComponentSession.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
							{
								num = 600;
							}
						}
					}
					else
					{
						xcmpComponentSession = global::Motorola.Common.Communication.Rcmp.XcmpComponentSession.DecodeCommandMessage(array, 0, array.Length);
						global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Receive switchover completed message id[{0}] action: [{1}]", new object[]
						{
							xcmpComponentSession.SessionID,
							xcmpComponentSession.Action
						});
						if ((xcmpComponentSession.Action & 256) != 256)
						{
							num = 601;
						}
					}
					if (xcmpComponentSession != null)
					{
						break;
					}
				}
				catch (global::Motorola.Common.CustomException.CommonException ex)
				{
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Receive switchover ack Error: [{0}]", new object[]
					{
						ex.ToString()
					});
				}
				if (i == 1)
				{
					num = 602;
					break;
				}
			}
			if (num != 0)
			{
				throw new global::Motorola.Common.CustomException.CommonException((global::Motorola.Common.CustomException.CommonErrorCode)num);
			}
		}

		// Token: 0x04000004 RID: 4
		private static global::SwitchOverManager.SwitchOverManager switchOverManager = new global::SwitchOverManager.SwitchOverManager();
	}
}
