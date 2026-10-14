using System;
using Motorola.Common.Communication.CommonUtil;

namespace Motorola.Common.Communication
{
	// Token: 0x0200000F RID: 15
	public interface IProgressIndicator
	{
		// Token: 0x060000AD RID: 173
		void StartRecord();

		// Token: 0x060000AE RID: 174
		void StopRecord();

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060000AF RID: 175
		global::Motorola.Common.Communication.CommonUtil.ProgressStatus CurrentStatus { get; }

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060000B0 RID: 176
		double CurrentProgress { get; }

		// Token: 0x060000B1 RID: 177
		void SetCurrentScope(int start, int end);

		// Token: 0x060000B2 RID: 178
		void UpdateProgress(double percent);

		// Token: 0x060000B3 RID: 179
		void UpdateProgress(double percent, global::Motorola.Common.Communication.CommonUtil.ProgressStatus processStatus);

		// Token: 0x060000B4 RID: 180
		void IncreaseProcess(double increasePercent);

		// Token: 0x060000B5 RID: 181
		void IncreaseProcess(double increasePercent, global::Motorola.Common.Communication.CommonUtil.ProgressStatus processStatus);

		// Token: 0x060000B6 RID: 182
		void Reset();
	}
}
