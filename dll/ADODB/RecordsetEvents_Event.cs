using System;
using System.Runtime.InteropServices;

namespace ADODB
{
	// Token: 0x0200006C RID: 108
	[global::System.Runtime.InteropServices.ComEventInterface(typeof(global::ADODB.RecordsetEvents\u0000), typeof(global::ADODB.RecordsetEvents_EventProvider\u0000))]
	[global::System.Runtime.InteropServices.ComVisible(false)]
	public interface RecordsetEvents_Event
	{
		// Token: 0x1400001E RID: 30
		// (add) Token: 0x06000378 RID: 888
		// (remove) Token: 0x06000379 RID: 889
		event global::ADODB.RecordsetEvents_WillChangeFieldEventHandler WillChangeField;

		// Token: 0x1400001F RID: 31
		// (add) Token: 0x0600037A RID: 890
		// (remove) Token: 0x0600037B RID: 891
		event global::ADODB.RecordsetEvents_FieldChangeCompleteEventHandler FieldChangeComplete;

		// Token: 0x14000020 RID: 32
		// (add) Token: 0x0600037C RID: 892
		// (remove) Token: 0x0600037D RID: 893
		event global::ADODB.RecordsetEvents_WillChangeRecordEventHandler WillChangeRecord;

		// Token: 0x14000021 RID: 33
		// (add) Token: 0x0600037E RID: 894
		// (remove) Token: 0x0600037F RID: 895
		event global::ADODB.RecordsetEvents_RecordChangeCompleteEventHandler RecordChangeComplete;

		// Token: 0x14000022 RID: 34
		// (add) Token: 0x06000380 RID: 896
		// (remove) Token: 0x06000381 RID: 897
		event global::ADODB.RecordsetEvents_WillChangeRecordsetEventHandler WillChangeRecordset;

		// Token: 0x14000023 RID: 35
		// (add) Token: 0x06000382 RID: 898
		// (remove) Token: 0x06000383 RID: 899
		event global::ADODB.RecordsetEvents_RecordsetChangeCompleteEventHandler RecordsetChangeComplete;

		// Token: 0x14000024 RID: 36
		// (add) Token: 0x06000384 RID: 900
		// (remove) Token: 0x06000385 RID: 901
		event global::ADODB.RecordsetEvents_WillMoveEventHandler WillMove;

		// Token: 0x14000025 RID: 37
		// (add) Token: 0x06000386 RID: 902
		// (remove) Token: 0x06000387 RID: 903
		event global::ADODB.RecordsetEvents_MoveCompleteEventHandler MoveComplete;

		// Token: 0x14000026 RID: 38
		// (add) Token: 0x06000388 RID: 904
		// (remove) Token: 0x06000389 RID: 905
		event global::ADODB.RecordsetEvents_EndOfRecordsetEventHandler EndOfRecordset;

		// Token: 0x14000027 RID: 39
		// (add) Token: 0x0600038A RID: 906
		// (remove) Token: 0x0600038B RID: 907
		event global::ADODB.RecordsetEvents_FetchProgressEventHandler FetchProgress;

		// Token: 0x14000028 RID: 40
		// (add) Token: 0x0600038C RID: 908
		// (remove) Token: 0x0600038D RID: 909
		event global::ADODB.RecordsetEvents_FetchCompleteEventHandler FetchComplete;
	}
}
