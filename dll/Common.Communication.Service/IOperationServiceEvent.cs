using System;
using System.ServiceModel;
using Motorola.Common.Communication.CommonUtil;

namespace Motorola.Common.Communication.Service
{
	// Token: 0x0200000D RID: 13
	public interface IOperationServiceEvent
	{
		// Token: 0x06000207 RID: 519
		[global::System.ServiceModel.OperationContract(IsOneWay = true)]
		void OnProgress(int percentComplete, global::Motorola.Common.Communication.CommonUtil.ProgressStatus status);
	}
}
