using System;
using Motorola.Common.Communication.CommonUtil;

namespace Motorola.Common.Communication
{
	// Token: 0x02000014 RID: 20
	public class IteratedProgressIndicator : global::Motorola.Common.Communication.IProgressIndicator
	{
		// Token: 0x060000DD RID: 221 RVA: 0x0000226F File Offset: 0x0000046F
		public IteratedProgressIndicator(global::Motorola.Common.Communication.IProgressIndicator parentProgress, double progressRate = 1.0)
		{
			this.parent = parentProgress;
			this.progressRate = progressRate;
			this.currentPercent = 0.0;
			this.currentStatus = ((parentProgress == null) ? global::Motorola.Common.Communication.CommonUtil.ProgressStatus.None : parentProgress.CurrentStatus);
		}

		// Token: 0x060000DE RID: 222 RVA: 0x000022A6 File Offset: 0x000004A6
		private IteratedProgressIndicator()
		{
		}

		// Token: 0x060000DF RID: 223 RVA: 0x000022AE File Offset: 0x000004AE
		public void StartRecord()
		{
			if (this.parent != null)
			{
				this.parent.StartRecord();
			}
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x000022C3 File Offset: 0x000004C3
		public void StopRecord()
		{
			if (this.parent != null)
			{
				this.parent.StopRecord();
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x000022D8 File Offset: 0x000004D8
		public global::Motorola.Common.Communication.CommonUtil.ProgressStatus CurrentStatus
		{
			get
			{
				return this.currentStatus;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000E2 RID: 226 RVA: 0x000022E0 File Offset: 0x000004E0
		public double CurrentProgress
		{
			get
			{
				return this.currentPercent;
			}
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x000022E8 File Offset: 0x000004E8
		public void SetCurrentScope(int start, int end)
		{
			if (this.parent != null)
			{
				this.parent.SetCurrentScope(start, end);
			}
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00002300 File Offset: 0x00000500
		public void UpdateProgress(double percent)
		{
			double increasePercent = percent - this.currentPercent;
			this.currentPercent = percent;
			this.UpdateParent(increasePercent);
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00002324 File Offset: 0x00000524
		public void UpdateProgress(double percent, global::Motorola.Common.Communication.CommonUtil.ProgressStatus processStatus)
		{
			double increasePercent = percent - this.currentPercent;
			this.currentPercent = percent;
			this.currentStatus = processStatus;
			this.UpdateParent(increasePercent);
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x0000234F File Offset: 0x0000054F
		public void IncreaseProcess(double increasePercent)
		{
			this.currentPercent += increasePercent;
			this.UpdateParent(increasePercent);
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00002366 File Offset: 0x00000566
		public void IncreaseProcess(double increasePercent, global::Motorola.Common.Communication.CommonUtil.ProgressStatus processStatus)
		{
			this.currentPercent += increasePercent;
			this.currentStatus = processStatus;
			this.UpdateParent(increasePercent);
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00002384 File Offset: 0x00000584
		public void Reset()
		{
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00002386 File Offset: 0x00000586
		private void UpdateParent(double increasePercent)
		{
			if (this.parent != null)
			{
				this.parent.IncreaseProcess(increasePercent * this.progressRate);
			}
		}

		// Token: 0x04000010 RID: 16
		private global::Motorola.Common.Communication.CommonUtil.ProgressStatus currentStatus;

		// Token: 0x04000011 RID: 17
		private double currentPercent;

		// Token: 0x04000012 RID: 18
		private global::Motorola.Common.Communication.IProgressIndicator parent;

		// Token: 0x04000013 RID: 19
		private double progressRate;
	}
}
