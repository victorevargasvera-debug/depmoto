using System;
using System.ServiceModel;
using Motorola.Common.Communication.CommonUtil;

namespace Motorola.Common.Communication.Service
{
	// Token: 0x0200000F RID: 15
	internal class DeviceProgressIndicator : global::Motorola.Common.Communication.IProgressIndicator
	{
		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600020C RID: 524 RVA: 0x000074B6 File Offset: 0x000056B6
		// (set) Token: 0x0600020D RID: 525 RVA: 0x000074BE File Offset: 0x000056BE
		private global::Motorola.Common.Communication.Service.IOperationServiceEvent serviceEvent { get; set; }

		// Token: 0x0600020E RID: 526 RVA: 0x000074C7 File Offset: 0x000056C7
		public void StartRecord()
		{
			this.recording = true;
		}

		// Token: 0x0600020F RID: 527 RVA: 0x000074D0 File Offset: 0x000056D0
		public void StopRecord()
		{
			this.recording = false;
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000210 RID: 528 RVA: 0x000074D9 File Offset: 0x000056D9
		public global::Motorola.Common.Communication.CommonUtil.ProgressStatus CurrentStatus
		{
			get
			{
				return this.currentStatus;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000211 RID: 529 RVA: 0x000074E1 File Offset: 0x000056E1
		public double CurrentProgress
		{
			get
			{
				return this.currentPercent;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000212 RID: 530 RVA: 0x000074EC File Offset: 0x000056EC
		private double ProgressFactor
		{
			get
			{
				return this.currentEndPos - this.currentStartPos;
			}
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00007508 File Offset: 0x00005708
		public DeviceProgressIndicator(global::Motorola.Common.Communication.Service.IOperationServiceEvent serviceEventCallback)
		{
			this.currentPercent = 0.0;
			this.currentStatus = global::Motorola.Common.Communication.CommonUtil.ProgressStatus.None;
			this.serviceEvent = serviceEventCallback;
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00007543 File Offset: 0x00005743
		public DeviceProgressIndicator() : this(global::System.ServiceModel.OperationContext.Current.GetCallbackChannel<global::Motorola.Common.Communication.Service.IOperationServiceEvent>())
		{
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00007558 File Offset: 0x00005758
		public void SetCurrentScope(int start, int end)
		{
			if (start >= end)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Invalid progress scope setting. start={0}, end={1}..", new object[]
				{
					start,
					end
				});
				return;
			}
			if (this.currentEndPos < 1.0 && this.currentEndPos != (double)start)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Incontineous progress scope. currentEndPos={0}, start={1}", new object[]
				{
					this.currentStartPos,
					start
				});
			}
			this.currentStartPos = (double)start / 100.0;
			this.currentEndPos = (double)end / 100.0;
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00007600 File Offset: 0x00005800
		public void UpdateProgress(double percent)
		{
			if (this.recording)
			{
				double num = this.currentStartPos + percent * this.ProgressFactor;
				if ((int)(this.currentPercent * 100.0) != (int)(num * 100.0))
				{
					this.currentPercent = num;
					this.Update();
				}
			}
		}

		// Token: 0x06000217 RID: 535 RVA: 0x00007651 File Offset: 0x00005851
		public void UpdateProgress(double percent, global::Motorola.Common.Communication.CommonUtil.ProgressStatus processStatus)
		{
			if (this.recording)
			{
				this.currentStatus = processStatus;
				this.UpdateProgress(percent);
			}
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00007669 File Offset: 0x00005869
		public void IncreaseProcess(double increasePercent)
		{
			if (this.recording)
			{
				this.currentPercent += increasePercent * this.ProgressFactor;
				this.Update();
			}
		}

		// Token: 0x06000219 RID: 537 RVA: 0x0000768E File Offset: 0x0000588E
		public void IncreaseProcess(double increasePercent, global::Motorola.Common.Communication.CommonUtil.ProgressStatus processStatus)
		{
			if (this.recording)
			{
				this.currentPercent += increasePercent * this.ProgressFactor;
				this.currentStatus = processStatus;
				this.Update();
			}
		}

		// Token: 0x0600021A RID: 538 RVA: 0x000076BA File Offset: 0x000058BA
		public void Reset()
		{
			this.currentStartPos = 0.0;
			this.currentEndPos = 1.0;
			this.currentPercent = 0.0;
		}

		// Token: 0x0600021B RID: 539 RVA: 0x000076EC File Offset: 0x000058EC
		private void Update()
		{
			try
			{
				if (this.serviceEvent != null)
				{
					global::System.Console.ForegroundColor = global::System.ConsoleColor.Red;
					global::System.Console.ResetColor();
					if (this.currentPercent <= this.currentEndPos && this.currentPercent >= this.currentStartPos)
					{
						if (this.currentPercent > 1.0)
						{
							this.currentPercent = 1.0;
						}
						this.serviceEvent.OnProgress((int)(100.0 * this.currentPercent), this.currentStatus);
					}
				}
			}
			catch (global::System.ServiceModel.CommunicationObjectAbortedException)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Client Abort Connection!", new object[0]);
				this.serviceEvent = null;
			}
			catch (global::System.ServiceModel.CommunicationException)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Client Abort Connection!", new object[0]);
				this.serviceEvent = null;
			}
		}

		// Token: 0x0400002E RID: 46
		private double currentPercent;

		// Token: 0x0400002F RID: 47
		private global::Motorola.Common.Communication.CommonUtil.ProgressStatus currentStatus;

		// Token: 0x04000030 RID: 48
		private bool recording = true;

		// Token: 0x04000031 RID: 49
		private double currentStartPos;

		// Token: 0x04000032 RID: 50
		private double currentEndPos = 1.0;
	}
}
