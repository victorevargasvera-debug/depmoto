using System;
using System.Runtime.InteropServices;

namespace ADODB
{
	// Token: 0x0200007D RID: 125
	[global::System.Runtime.InteropServices.ClassInterface(global::System.Runtime.InteropServices.ClassInterfaceType.None)]
	public sealed class RecordsetEvents_SinkHelper : global::ADODB.RecordsetEvents
	{
		// Token: 0x060003CB RID: 971 RVA: 0x0000241C File Offset: 0x0000141C
		public void FetchComplete(global::ADODB.Error A_1, ref global::ADODB.EventStatusEnum A_2, global::ADODB.Recordset A_3)
		{
			if (this.m_FetchCompleteDelegate != null)
			{
				this.m_FetchCompleteDelegate(A_1, ref A_2, A_3);
				return;
			}
		}

		// Token: 0x060003CC RID: 972 RVA: 0x00002454 File Offset: 0x00001454
		public void FetchProgress(int A_1, int A_2, ref global::ADODB.EventStatusEnum A_3, global::ADODB.Recordset A_4)
		{
			if (this.m_FetchProgressDelegate != null)
			{
				this.m_FetchProgressDelegate(A_1, A_2, ref A_3, A_4);
				return;
			}
		}

		// Token: 0x060003CD RID: 973 RVA: 0x00002490 File Offset: 0x00001490
		public void EndOfRecordset(ref bool A_1, ref global::ADODB.EventStatusEnum A_2, global::ADODB.Recordset A_3)
		{
			if (this.m_EndOfRecordsetDelegate != null)
			{
				this.m_EndOfRecordsetDelegate(ref A_1, ref A_2, A_3);
				return;
			}
		}

		// Token: 0x060003CE RID: 974 RVA: 0x000024C8 File Offset: 0x000014C8
		public void MoveComplete(global::ADODB.EventReasonEnum A_1, global::ADODB.Error A_2, ref global::ADODB.EventStatusEnum A_3, global::ADODB.Recordset A_4)
		{
			if (this.m_MoveCompleteDelegate != null)
			{
				this.m_MoveCompleteDelegate(A_1, A_2, ref A_3, A_4);
				return;
			}
		}

		// Token: 0x060003CF RID: 975 RVA: 0x00002504 File Offset: 0x00001504
		public void WillMove(global::ADODB.EventReasonEnum A_1, ref global::ADODB.EventStatusEnum A_2, global::ADODB.Recordset A_3)
		{
			if (this.m_WillMoveDelegate != null)
			{
				this.m_WillMoveDelegate(A_1, ref A_2, A_3);
				return;
			}
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x0000253C File Offset: 0x0000153C
		public void RecordsetChangeComplete(global::ADODB.EventReasonEnum A_1, global::ADODB.Error A_2, ref global::ADODB.EventStatusEnum A_3, global::ADODB.Recordset A_4)
		{
			if (this.m_RecordsetChangeCompleteDelegate != null)
			{
				this.m_RecordsetChangeCompleteDelegate(A_1, A_2, ref A_3, A_4);
				return;
			}
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x00002578 File Offset: 0x00001578
		public void WillChangeRecordset(global::ADODB.EventReasonEnum A_1, ref global::ADODB.EventStatusEnum A_2, global::ADODB.Recordset A_3)
		{
			if (this.m_WillChangeRecordsetDelegate != null)
			{
				this.m_WillChangeRecordsetDelegate(A_1, ref A_2, A_3);
				return;
			}
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x000025B0 File Offset: 0x000015B0
		public void RecordChangeComplete(global::ADODB.EventReasonEnum A_1, int A_2, global::ADODB.Error A_3, ref global::ADODB.EventStatusEnum A_4, global::ADODB.Recordset A_5)
		{
			if (this.m_RecordChangeCompleteDelegate != null)
			{
				this.m_RecordChangeCompleteDelegate(A_1, A_2, A_3, ref A_4, A_5);
				return;
			}
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x000025F0 File Offset: 0x000015F0
		public void WillChangeRecord(global::ADODB.EventReasonEnum A_1, int A_2, ref global::ADODB.EventStatusEnum A_3, global::ADODB.Recordset A_4)
		{
			if (this.m_WillChangeRecordDelegate != null)
			{
				this.m_WillChangeRecordDelegate(A_1, A_2, ref A_3, A_4);
				return;
			}
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x0000262C File Offset: 0x0000162C
		public void FieldChangeComplete(int A_1, object A_2, global::ADODB.Error A_3, ref global::ADODB.EventStatusEnum A_4, global::ADODB.Recordset A_5)
		{
			if (this.m_FieldChangeCompleteDelegate != null)
			{
				this.m_FieldChangeCompleteDelegate(A_1, A_2, A_3, ref A_4, A_5);
				return;
			}
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x0000266C File Offset: 0x0000166C
		public void WillChangeField(int A_1, object A_2, ref global::ADODB.EventStatusEnum A_3, global::ADODB.Recordset A_4)
		{
			if (this.m_WillChangeFieldDelegate != null)
			{
				this.m_WillChangeFieldDelegate(A_1, A_2, ref A_3, A_4);
				return;
			}
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x000026A8 File Offset: 0x000016A8
		internal RecordsetEvents_SinkHelper()
		{
			this.m_dwCookie = 0;
			this.m_FetchCompleteDelegate = null;
			this.m_FetchProgressDelegate = null;
			this.m_EndOfRecordsetDelegate = null;
			this.m_MoveCompleteDelegate = null;
			this.m_WillMoveDelegate = null;
			this.m_RecordsetChangeCompleteDelegate = null;
			this.m_WillChangeRecordsetDelegate = null;
			this.m_RecordChangeCompleteDelegate = null;
			this.m_WillChangeRecordDelegate = null;
			this.m_FieldChangeCompleteDelegate = null;
			this.m_WillChangeFieldDelegate = null;
		}

		// Token: 0x040001DD RID: 477
		public global::ADODB.RecordsetEvents_FetchCompleteEventHandler m_FetchCompleteDelegate;

		// Token: 0x040001DE RID: 478
		public global::ADODB.RecordsetEvents_FetchProgressEventHandler m_FetchProgressDelegate;

		// Token: 0x040001DF RID: 479
		public global::ADODB.RecordsetEvents_EndOfRecordsetEventHandler m_EndOfRecordsetDelegate;

		// Token: 0x040001E0 RID: 480
		public global::ADODB.RecordsetEvents_MoveCompleteEventHandler m_MoveCompleteDelegate;

		// Token: 0x040001E1 RID: 481
		public global::ADODB.RecordsetEvents_WillMoveEventHandler m_WillMoveDelegate;

		// Token: 0x040001E2 RID: 482
		public global::ADODB.RecordsetEvents_RecordsetChangeCompleteEventHandler m_RecordsetChangeCompleteDelegate;

		// Token: 0x040001E3 RID: 483
		public global::ADODB.RecordsetEvents_WillChangeRecordsetEventHandler m_WillChangeRecordsetDelegate;

		// Token: 0x040001E4 RID: 484
		public global::ADODB.RecordsetEvents_RecordChangeCompleteEventHandler m_RecordChangeCompleteDelegate;

		// Token: 0x040001E5 RID: 485
		public global::ADODB.RecordsetEvents_WillChangeRecordEventHandler m_WillChangeRecordDelegate;

		// Token: 0x040001E6 RID: 486
		public global::ADODB.RecordsetEvents_FieldChangeCompleteEventHandler m_FieldChangeCompleteDelegate;

		// Token: 0x040001E7 RID: 487
		public global::ADODB.RecordsetEvents_WillChangeFieldEventHandler m_WillChangeFieldDelegate;

		// Token: 0x040001E8 RID: 488
		public int m_dwCookie;
	}
}
