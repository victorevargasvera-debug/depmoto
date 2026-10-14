using System;
using System.Runtime.InteropServices;

namespace ADODB
{
	// Token: 0x02000055 RID: 85
	[global::System.Runtime.InteropServices.ComVisible(false)]
	[global::System.Runtime.InteropServices.ComEventInterface(typeof(global::ADODB.ConnectionEvents\u0000), typeof(global::ADODB.ConnectionEvents_EventProvider\u0000))]
	public interface ConnectionEvents_Event
	{
		// Token: 0x1400000A RID: 10
		// (add) Token: 0x06000270 RID: 624
		// (remove) Token: 0x06000271 RID: 625
		event global::ADODB.ConnectionEvents_InfoMessageEventHandler InfoMessage;

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x06000272 RID: 626
		// (remove) Token: 0x06000273 RID: 627
		event global::ADODB.ConnectionEvents_BeginTransCompleteEventHandler BeginTransComplete;

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x06000274 RID: 628
		// (remove) Token: 0x06000275 RID: 629
		event global::ADODB.ConnectionEvents_CommitTransCompleteEventHandler CommitTransComplete;

		// Token: 0x1400000D RID: 13
		// (add) Token: 0x06000276 RID: 630
		// (remove) Token: 0x06000277 RID: 631
		event global::ADODB.ConnectionEvents_RollbackTransCompleteEventHandler RollbackTransComplete;

		// Token: 0x1400000E RID: 14
		// (add) Token: 0x06000278 RID: 632
		// (remove) Token: 0x06000279 RID: 633
		event global::ADODB.ConnectionEvents_WillExecuteEventHandler WillExecute;

		// Token: 0x1400000F RID: 15
		// (add) Token: 0x0600027A RID: 634
		// (remove) Token: 0x0600027B RID: 635
		event global::ADODB.ConnectionEvents_ExecuteCompleteEventHandler ExecuteComplete;

		// Token: 0x14000010 RID: 16
		// (add) Token: 0x0600027C RID: 636
		// (remove) Token: 0x0600027D RID: 637
		event global::ADODB.ConnectionEvents_WillConnectEventHandler WillConnect;

		// Token: 0x14000011 RID: 17
		// (add) Token: 0x0600027E RID: 638
		// (remove) Token: 0x0600027F RID: 639
		event global::ADODB.ConnectionEvents_ConnectCompleteEventHandler ConnectComplete;

		// Token: 0x14000012 RID: 18
		// (add) Token: 0x06000280 RID: 640
		// (remove) Token: 0x06000281 RID: 641
		event global::ADODB.ConnectionEvents_DisconnectEventHandler Disconnect;
	}
}
