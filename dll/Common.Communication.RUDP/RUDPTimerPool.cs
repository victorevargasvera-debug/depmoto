using System;
using Motorola.Common.Communication.CommonUtil;

namespace Motorola.Common.Communication.RUDP
{
	// Token: 0x0200002C RID: 44
	internal class RUDPTimerPool
	{
		// Token: 0x060001CA RID: 458 RVA: 0x0000763E File Offset: 0x0000583E
		public RUDPTimerPool(global::Motorola.Common.Communication.RUDP.RUDPConfigParams configParams, global::Motorola.Common.Communication.RUDP.RUDPFlowControl flowControl, global::Motorola.Common.Communication.RUDP.RUDPTimerController timeController)
		{
			this._configParams = configParams;
			this._flowControl = flowControl;
			this._timeController = timeController;
			this.CreateInactivityTimer();
			this.CreateRetransmissionTimer();
			this.CreateDelayACKTimer();
			this.CreateCloseWaitTimer();
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00007678 File Offset: 0x00005878
		private global::Motorola.Common.Communication.RUDP.RUDPHighAccurateTimer CreateInactivityTimer()
		{
			this.inactivityTimer = new global::Motorola.Common.Communication.RUDP.RUDPHighAccurateTimer("Inactivity Timer", 40000000, new global::Motorola.Common.Communication.RUDP.TimerCallBack(this.InactivityTimerCallback));
			this._timeController.RegisterTimer(this.inactivityTimer);
			this.inactivityTimer.Reset();
			return this.inactivityTimer;
		}

		// Token: 0x060001CC RID: 460 RVA: 0x000076C8 File Offset: 0x000058C8
		private global::Motorola.Common.Communication.RUDP.RUDPHighAccurateTimer CreateRetransmissionTimer()
		{
			this.retransmissionTimer = new global::Motorola.Common.Communication.RUDP.RUDPHighAccurateTimer("Retransmission Timer", 10000, new global::Motorola.Common.Communication.RUDP.TimerCallBack(this._flowControl.RetransmissionTimerCallback));
			this._timeController.RegisterTimer(this.retransmissionTimer);
			this.retransmissionTimer.Start();
			return this.retransmissionTimer;
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00007720 File Offset: 0x00005920
		private global::Motorola.Common.Communication.RUDP.RUDPHighAccurateTimer CreateDelayACKTimer()
		{
			this.delayACKTimer = new global::Motorola.Common.Communication.RUDP.RUDPHighAccurateTimer("Delay ACK Timer", 10000, new global::Motorola.Common.Communication.RUDP.TimerCallBack(this._flowControl.DelayACKTimerCallback));
			this._timeController.RegisterTimer(this.delayACKTimer);
			this.delayACKTimer.Start();
			return this.delayACKTimer;
		}

		// Token: 0x060001CE RID: 462 RVA: 0x00007778 File Offset: 0x00005978
		private global::Motorola.Common.Communication.RUDP.RUDPHighAccurateTimer CreateCloseWaitTimer()
		{
			this.closeWaitTimer = new global::Motorola.Common.Communication.RUDP.RUDPHighAccurateTimer("Close Wait Timer", this._configParams.CloseWaitTimeout * 1000, new global::Motorola.Common.Communication.RUDP.TimerCallBack(this._flowControl.Connection.CloseWaitTimerCallback));
			this._timeController.RegisterTimer(this.closeWaitTimer);
			return this.closeWaitTimer;
		}

		// Token: 0x060001CF RID: 463 RVA: 0x000077D3 File Offset: 0x000059D3
		public void StartCloseWaitTimer()
		{
			this.closeWaitTimer.Interval = this._configParams.CloseWaitTimeout * 1000;
			this.closeWaitTimer.Reset();
			this.closeWaitTimer.Start();
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x00007807 File Offset: 0x00005A07
		public void StartInactivityTimer()
		{
			this.inactivityTimer.Start();
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00007814 File Offset: 0x00005A14
		public void ResetInactivityTimer()
		{
			this.inactivityTimer.Interval = this._configParams.InactivityTimeout * 1000;
			this.inactivityTimer.Reset();
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x0000783D File Offset: 0x00005A3D
		private void InactivityTimerCallback(object state)
		{
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("RUDP Error: Inactivity Timout", new object[0]);
			this.inactivityTimer.Stop();
			this._flowControl.Connection.InactivityTimout();
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x0000786F File Offset: 0x00005A6F
		public void UpdateConfigParams(global::Motorola.Common.Communication.RUDP.RUDPConfigParams configParams)
		{
			this._configParams = configParams;
		}

		// Token: 0x040000EE RID: 238
		private global::Motorola.Common.Communication.RUDP.RUDPConfigParams _configParams;

		// Token: 0x040000EF RID: 239
		private global::Motorola.Common.Communication.RUDP.RUDPFlowControl _flowControl;

		// Token: 0x040000F0 RID: 240
		private global::Motorola.Common.Communication.RUDP.RUDPTimerController _timeController;

		// Token: 0x040000F1 RID: 241
		private global::Motorola.Common.Communication.RUDP.RUDPHighAccurateTimer retransmissionTimer;

		// Token: 0x040000F2 RID: 242
		private global::Motorola.Common.Communication.RUDP.RUDPHighAccurateTimer delayACKTimer;

		// Token: 0x040000F3 RID: 243
		private global::Motorola.Common.Communication.RUDP.RUDPHighAccurateTimer closeWaitTimer;

		// Token: 0x040000F4 RID: 244
		private global::Motorola.Common.Communication.RUDP.RUDPHighAccurateTimer inactivityTimer;
	}
}
