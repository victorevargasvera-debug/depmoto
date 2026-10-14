using System;
using System.Collections.Generic;
using Motorola.Common.Communication.CommonUtil;

namespace Motorola.Common.Communication.TetraUtility
{
	// Token: 0x0200007A RID: 122
	public class TetraPnPMonitor : global::System.IDisposable
	{
		// Token: 0x060002D0 RID: 720 RVA: 0x0000E409 File Offset: 0x0000C609
		private TetraPnPMonitor()
		{
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x0000E43D File Offset: 0x0000C63D
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x0000E44C File Offset: 0x0000C64C
		private void Dispose(bool disposing)
		{
			if (this._disposed)
			{
				return;
			}
			try
			{
				if (disposing)
				{
					this._massStorageSwitchInfo.Dispose();
				}
			}
			finally
			{
				this._disposed = true;
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060002D3 RID: 723 RVA: 0x0000E48C File Offset: 0x0000C68C
		public static global::Motorola.Common.Communication.TetraUtility.TetraPnPMonitor Instance
		{
			get
			{
				if (global::Motorola.Common.Communication.TetraUtility.TetraPnPMonitor._instance == null)
				{
					global::Motorola.Common.Communication.TetraUtility.TetraPnPMonitor._instance = new global::Motorola.Common.Communication.TetraUtility.TetraPnPMonitor();
					return global::Motorola.Common.Communication.TetraUtility.TetraPnPMonitor._instance;
				}
				return global::Motorola.Common.Communication.TetraUtility.TetraPnPMonitor._instance;
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060002D4 RID: 724 RVA: 0x0000E4AA File Offset: 0x0000C6AA
		public global::Motorola.Common.Communication.TetraUtility.MassStorageSwitchInfo MsSwitchInfo
		{
			get
			{
				return this._massStorageSwitchInfo;
			}
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x0000E4B4 File Offset: 0x0000C6B4
		public void ReceivePnPMsg(global::System.Collections.Generic.List<global::Motorola.Common.Communication.TetraUtility.TetraPnPMsg> msgList)
		{
			if (msgList.Count != 0)
			{
				global::Motorola.Common.Communication.TetraUtility.TetraPnPMsgEventArgs tetraPnPMsgEventArgs = new global::Motorola.Common.Communication.TetraUtility.TetraPnPMsgEventArgs();
				tetraPnPMsgEventArgs.MsgList = msgList;
				if (msgList[0].PnPType == global::Motorola.Common.Communication.TetraUtility.TetraPnPMsg.DevPnPAction.DeviceAttached && !msgList[0].IsOriginalPnP)
				{
					if (this._deviceAttached != null)
					{
						this._deviceAttached.Invok(this, tetraPnPMsgEventArgs);
						return;
					}
				}
				else
				{
					if (msgList[0].PnPType == global::Motorola.Common.Communication.TetraUtility.TetraPnPMsg.DevPnPAction.DeviceAttached && msgList[0].IsOriginalPnP)
					{
						if (this._originalDevChanged == null)
						{
							return;
						}
						if (msgList[0].PID.Equals("9006", global::System.StringComparison.InvariantCultureIgnoreCase) || msgList[0].PID.Equals("9003", global::System.StringComparison.InvariantCultureIgnoreCase))
						{
							this._originalDevChanged.Invok(this, tetraPnPMsgEventArgs);
							return;
						}
						if (!msgList[0].PID.Equals("9013", global::System.StringComparison.InvariantCultureIgnoreCase) && !msgList[0].PID.Equals("9012", global::System.StringComparison.InvariantCultureIgnoreCase))
						{
							return;
						}
						using (global::System.Collections.Generic.List<global::Motorola.Common.Communication.TetraUtility.TetraPnPMsg>.Enumerator enumerator = msgList.GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								global::Motorola.Common.Communication.TetraUtility.TetraPnPMsg tetraPnPMsg = enumerator.Current;
								if (tetraPnPMsg.RadioType == global::Motorola.Common.Communication.CommonUtil.TetraRadioType.DATABOX_PORT2)
								{
									tetraPnPMsgEventArgs.MsgList = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.TetraUtility.TetraPnPMsg>
									{
										tetraPnPMsg
									};
									this._originalDevChanged.Invok(this, tetraPnPMsgEventArgs);
									break;
								}
							}
							return;
						}
					}
					if (this._originalDevChanged != null)
					{
						if (msgList[0].PID.Equals("9006", global::System.StringComparison.InvariantCultureIgnoreCase) || msgList[0].PID.Equals("9003", global::System.StringComparison.InvariantCultureIgnoreCase))
						{
							this._originalDevChanged.Invok(this, tetraPnPMsgEventArgs);
						}
						else if (msgList[0].PID.Equals("9013", global::System.StringComparison.InvariantCultureIgnoreCase) || msgList[0].PID.Equals("9012", global::System.StringComparison.InvariantCultureIgnoreCase))
						{
							foreach (global::Motorola.Common.Communication.TetraUtility.TetraPnPMsg tetraPnPMsg2 in msgList)
							{
								if (tetraPnPMsg2.RadioType == global::Motorola.Common.Communication.CommonUtil.TetraRadioType.DATABOX_PORT2)
								{
									tetraPnPMsgEventArgs.MsgList = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.TetraUtility.TetraPnPMsg>
									{
										tetraPnPMsg2
									};
									this._originalDevChanged.Invok(this, tetraPnPMsgEventArgs);
									break;
								}
							}
						}
					}
					if (this._deviceDetached != null)
					{
						this._deviceDetached.Invok(this, tetraPnPMsgEventArgs);
					}
				}
			}
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x060002D6 RID: 726 RVA: 0x0000E718 File Offset: 0x0000C918
		// (remove) Token: 0x060002D7 RID: 727 RVA: 0x0000E726 File Offset: 0x0000C926
		public event global::System.EventHandler<global::Motorola.Common.Communication.TetraUtility.TetraPnPMsgEventArgs> DeviceDetached
		{
			add
			{
				this._deviceDetached.Add(value);
			}
			remove
			{
				this._deviceDetached.Remove(value);
			}
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x060002D8 RID: 728 RVA: 0x0000E734 File Offset: 0x0000C934
		// (remove) Token: 0x060002D9 RID: 729 RVA: 0x0000E742 File Offset: 0x0000C942
		public event global::System.EventHandler<global::Motorola.Common.Communication.TetraUtility.TetraPnPMsgEventArgs> DeviceAttached
		{
			add
			{
				this._deviceAttached.Add(value);
			}
			remove
			{
				this._deviceAttached.Remove(value);
			}
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x060002DA RID: 730 RVA: 0x0000E750 File Offset: 0x0000C950
		// (remove) Token: 0x060002DB RID: 731 RVA: 0x0000E75E File Offset: 0x0000C95E
		public event global::System.EventHandler<global::Motorola.Common.Communication.TetraUtility.TetraPnPMsgEventArgs> OriginalDevChanged
		{
			add
			{
				this._originalDevChanged.Add(value);
			}
			remove
			{
				this._originalDevChanged.Remove(value);
			}
		}

		// Token: 0x060002DC RID: 732 RVA: 0x0000E76C File Offset: 0x0000C96C
		private void BroadcastMsg(global::System.Collections.Generic.List<global::Motorola.Common.Communication.TetraUtility.TetraPnPMsgEventArgs> msg)
		{
		}

		// Token: 0x040003CA RID: 970
		private global::Motorola.Common.Communication.TetraUtility.WeakEvent<global::Motorola.Common.Communication.TetraUtility.TetraPnPMsgEventArgs> _deviceDetached = new global::Motorola.Common.Communication.TetraUtility.WeakEvent<global::Motorola.Common.Communication.TetraUtility.TetraPnPMsgEventArgs>();

		// Token: 0x040003CB RID: 971
		private global::Motorola.Common.Communication.TetraUtility.WeakEvent<global::Motorola.Common.Communication.TetraUtility.TetraPnPMsgEventArgs> _deviceAttached = new global::Motorola.Common.Communication.TetraUtility.WeakEvent<global::Motorola.Common.Communication.TetraUtility.TetraPnPMsgEventArgs>();

		// Token: 0x040003CC RID: 972
		private global::Motorola.Common.Communication.TetraUtility.WeakEvent<global::Motorola.Common.Communication.TetraUtility.TetraPnPMsgEventArgs> _originalDevChanged = new global::Motorola.Common.Communication.TetraUtility.WeakEvent<global::Motorola.Common.Communication.TetraUtility.TetraPnPMsgEventArgs>();

		// Token: 0x040003CD RID: 973
		private static global::Motorola.Common.Communication.TetraUtility.TetraPnPMonitor _instance;

		// Token: 0x040003CE RID: 974
		private global::Motorola.Common.Communication.TetraUtility.MassStorageSwitchInfo _massStorageSwitchInfo = new global::Motorola.Common.Communication.TetraUtility.MassStorageSwitchInfo();

		// Token: 0x040003CF RID: 975
		private bool _disposed;
	}
}
