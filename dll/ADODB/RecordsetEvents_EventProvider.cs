using System;
using System.Collections;
using System.Runtime.InteropServices;

namespace ADODB
{
	// Token: 0x0200007E RID: 126
	internal sealed class RecordsetEvents_EventProvider : global::ADODB.RecordsetEvents_Event, global::System.IDisposable
	{
		// Token: 0x060003D7 RID: 983 RVA: 0x0000273C File Offset: 0x0000173C
		private void Init()
		{
			global::System.Runtime.InteropServices.UCOMIConnectionPoint ucomiconnectionPoint = null;
			global::System.Guid guid = new global::System.Guid(new byte[]
			{
				102,
				2,
				0,
				0,
				0,
				0,
				16,
				0,
				128,
				0,
				0,
				170,
				0,
				109,
				46,
				164
			});
			this.m_ConnectionPointContainer.FindConnectionPoint(ref guid, out ucomiconnectionPoint);
			this.m_ConnectionPoint = (global::System.Runtime.InteropServices.UCOMIConnectionPoint)ucomiconnectionPoint;
			this.m_aEventSinkHelpers = new global::System.Collections.ArrayList();
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x00002850 File Offset: 0x00001850
		public void add_FetchComplete(global::ADODB.RecordsetEvents_FetchCompleteEventHandler A_1)
		{
			lock (this)
			{
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				global::ADODB.RecordsetEvents_SinkHelper recordsetEvents_SinkHelper = new global::ADODB.RecordsetEvents_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)recordsetEvents_SinkHelper, out dwCookie);
				recordsetEvents_SinkHelper.m_dwCookie = dwCookie;
				recordsetEvents_SinkHelper.m_FetchCompleteDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)recordsetEvents_SinkHelper);
			}
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x000028E0 File Offset: 0x000018E0
		public void remove_FetchComplete(global::ADODB.RecordsetEvents_FetchCompleteEventHandler A_1)
		{
			lock (this)
			{
				int count = this.m_aEventSinkHelpers.Count;
				int num = 0;
				if (0 < count)
				{
					global::ADODB.RecordsetEvents_SinkHelper recordsetEvents_SinkHelper;
					for (;;)
					{
						recordsetEvents_SinkHelper = (global::ADODB.RecordsetEvents_SinkHelper)this.m_aEventSinkHelpers[num];
						if (recordsetEvents_SinkHelper.m_FetchCompleteDelegate != null && ((recordsetEvents_SinkHelper.m_FetchCompleteDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
						{
							break;
						}
						num++;
						if (num >= count)
						{
							goto IL_D3;
						}
					}
					this.m_aEventSinkHelpers.RemoveAt(num);
					this.m_ConnectionPoint.Unadvise(recordsetEvents_SinkHelper.m_dwCookie);
					if (count <= 1)
					{
						global::System.Runtime.InteropServices.Marshal.ReleaseComObject(this.m_ConnectionPoint);
						this.m_ConnectionPoint = null;
						this.m_aEventSinkHelpers = null;
					}
				}
				IL_D3:;
			}
		}

		// Token: 0x060003DA RID: 986 RVA: 0x000029E0 File Offset: 0x000019E0
		public void add_FetchProgress(global::ADODB.RecordsetEvents_FetchProgressEventHandler A_1)
		{
			lock (this)
			{
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				global::ADODB.RecordsetEvents_SinkHelper recordsetEvents_SinkHelper = new global::ADODB.RecordsetEvents_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)recordsetEvents_SinkHelper, out dwCookie);
				recordsetEvents_SinkHelper.m_dwCookie = dwCookie;
				recordsetEvents_SinkHelper.m_FetchProgressDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)recordsetEvents_SinkHelper);
			}
		}

		// Token: 0x060003DB RID: 987 RVA: 0x00002A70 File Offset: 0x00001A70
		public void remove_FetchProgress(global::ADODB.RecordsetEvents_FetchProgressEventHandler A_1)
		{
			lock (this)
			{
				int count = this.m_aEventSinkHelpers.Count;
				int num = 0;
				if (0 < count)
				{
					global::ADODB.RecordsetEvents_SinkHelper recordsetEvents_SinkHelper;
					for (;;)
					{
						recordsetEvents_SinkHelper = (global::ADODB.RecordsetEvents_SinkHelper)this.m_aEventSinkHelpers[num];
						if (recordsetEvents_SinkHelper.m_FetchProgressDelegate != null && ((recordsetEvents_SinkHelper.m_FetchProgressDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
						{
							break;
						}
						num++;
						if (num >= count)
						{
							goto IL_D3;
						}
					}
					this.m_aEventSinkHelpers.RemoveAt(num);
					this.m_ConnectionPoint.Unadvise(recordsetEvents_SinkHelper.m_dwCookie);
					if (count <= 1)
					{
						global::System.Runtime.InteropServices.Marshal.ReleaseComObject(this.m_ConnectionPoint);
						this.m_ConnectionPoint = null;
						this.m_aEventSinkHelpers = null;
					}
				}
				IL_D3:;
			}
		}

		// Token: 0x060003DC RID: 988 RVA: 0x00002B70 File Offset: 0x00001B70
		public void add_EndOfRecordset(global::ADODB.RecordsetEvents_EndOfRecordsetEventHandler A_1)
		{
			lock (this)
			{
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				global::ADODB.RecordsetEvents_SinkHelper recordsetEvents_SinkHelper = new global::ADODB.RecordsetEvents_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)recordsetEvents_SinkHelper, out dwCookie);
				recordsetEvents_SinkHelper.m_dwCookie = dwCookie;
				recordsetEvents_SinkHelper.m_EndOfRecordsetDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)recordsetEvents_SinkHelper);
			}
		}

		// Token: 0x060003DD RID: 989 RVA: 0x00002C00 File Offset: 0x00001C00
		public void remove_EndOfRecordset(global::ADODB.RecordsetEvents_EndOfRecordsetEventHandler A_1)
		{
			lock (this)
			{
				int count = this.m_aEventSinkHelpers.Count;
				int num = 0;
				if (0 < count)
				{
					global::ADODB.RecordsetEvents_SinkHelper recordsetEvents_SinkHelper;
					for (;;)
					{
						recordsetEvents_SinkHelper = (global::ADODB.RecordsetEvents_SinkHelper)this.m_aEventSinkHelpers[num];
						if (recordsetEvents_SinkHelper.m_EndOfRecordsetDelegate != null && ((recordsetEvents_SinkHelper.m_EndOfRecordsetDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
						{
							break;
						}
						num++;
						if (num >= count)
						{
							goto IL_D3;
						}
					}
					this.m_aEventSinkHelpers.RemoveAt(num);
					this.m_ConnectionPoint.Unadvise(recordsetEvents_SinkHelper.m_dwCookie);
					if (count <= 1)
					{
						global::System.Runtime.InteropServices.Marshal.ReleaseComObject(this.m_ConnectionPoint);
						this.m_ConnectionPoint = null;
						this.m_aEventSinkHelpers = null;
					}
				}
				IL_D3:;
			}
		}

		// Token: 0x060003DE RID: 990 RVA: 0x00002D00 File Offset: 0x00001D00
		public void add_MoveComplete(global::ADODB.RecordsetEvents_MoveCompleteEventHandler A_1)
		{
			lock (this)
			{
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				global::ADODB.RecordsetEvents_SinkHelper recordsetEvents_SinkHelper = new global::ADODB.RecordsetEvents_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)recordsetEvents_SinkHelper, out dwCookie);
				recordsetEvents_SinkHelper.m_dwCookie = dwCookie;
				recordsetEvents_SinkHelper.m_MoveCompleteDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)recordsetEvents_SinkHelper);
			}
		}

		// Token: 0x060003DF RID: 991 RVA: 0x00002D90 File Offset: 0x00001D90
		public void remove_MoveComplete(global::ADODB.RecordsetEvents_MoveCompleteEventHandler A_1)
		{
			lock (this)
			{
				int count = this.m_aEventSinkHelpers.Count;
				int num = 0;
				if (0 < count)
				{
					global::ADODB.RecordsetEvents_SinkHelper recordsetEvents_SinkHelper;
					for (;;)
					{
						recordsetEvents_SinkHelper = (global::ADODB.RecordsetEvents_SinkHelper)this.m_aEventSinkHelpers[num];
						if (recordsetEvents_SinkHelper.m_MoveCompleteDelegate != null && ((recordsetEvents_SinkHelper.m_MoveCompleteDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
						{
							break;
						}
						num++;
						if (num >= count)
						{
							goto IL_D3;
						}
					}
					this.m_aEventSinkHelpers.RemoveAt(num);
					this.m_ConnectionPoint.Unadvise(recordsetEvents_SinkHelper.m_dwCookie);
					if (count <= 1)
					{
						global::System.Runtime.InteropServices.Marshal.ReleaseComObject(this.m_ConnectionPoint);
						this.m_ConnectionPoint = null;
						this.m_aEventSinkHelpers = null;
					}
				}
				IL_D3:;
			}
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x00002E90 File Offset: 0x00001E90
		public void add_WillMove(global::ADODB.RecordsetEvents_WillMoveEventHandler A_1)
		{
			lock (this)
			{
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				global::ADODB.RecordsetEvents_SinkHelper recordsetEvents_SinkHelper = new global::ADODB.RecordsetEvents_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)recordsetEvents_SinkHelper, out dwCookie);
				recordsetEvents_SinkHelper.m_dwCookie = dwCookie;
				recordsetEvents_SinkHelper.m_WillMoveDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)recordsetEvents_SinkHelper);
			}
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x00002F20 File Offset: 0x00001F20
		public void remove_WillMove(global::ADODB.RecordsetEvents_WillMoveEventHandler A_1)
		{
			lock (this)
			{
				int count = this.m_aEventSinkHelpers.Count;
				int num = 0;
				if (0 < count)
				{
					global::ADODB.RecordsetEvents_SinkHelper recordsetEvents_SinkHelper;
					for (;;)
					{
						recordsetEvents_SinkHelper = (global::ADODB.RecordsetEvents_SinkHelper)this.m_aEventSinkHelpers[num];
						if (recordsetEvents_SinkHelper.m_WillMoveDelegate != null && ((recordsetEvents_SinkHelper.m_WillMoveDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
						{
							break;
						}
						num++;
						if (num >= count)
						{
							goto IL_D3;
						}
					}
					this.m_aEventSinkHelpers.RemoveAt(num);
					this.m_ConnectionPoint.Unadvise(recordsetEvents_SinkHelper.m_dwCookie);
					if (count <= 1)
					{
						global::System.Runtime.InteropServices.Marshal.ReleaseComObject(this.m_ConnectionPoint);
						this.m_ConnectionPoint = null;
						this.m_aEventSinkHelpers = null;
					}
				}
				IL_D3:;
			}
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x00003020 File Offset: 0x00002020
		public void add_RecordsetChangeComplete(global::ADODB.RecordsetEvents_RecordsetChangeCompleteEventHandler A_1)
		{
			lock (this)
			{
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				global::ADODB.RecordsetEvents_SinkHelper recordsetEvents_SinkHelper = new global::ADODB.RecordsetEvents_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)recordsetEvents_SinkHelper, out dwCookie);
				recordsetEvents_SinkHelper.m_dwCookie = dwCookie;
				recordsetEvents_SinkHelper.m_RecordsetChangeCompleteDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)recordsetEvents_SinkHelper);
			}
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x000030B0 File Offset: 0x000020B0
		public void remove_RecordsetChangeComplete(global::ADODB.RecordsetEvents_RecordsetChangeCompleteEventHandler A_1)
		{
			lock (this)
			{
				int count = this.m_aEventSinkHelpers.Count;
				int num = 0;
				if (0 < count)
				{
					global::ADODB.RecordsetEvents_SinkHelper recordsetEvents_SinkHelper;
					for (;;)
					{
						recordsetEvents_SinkHelper = (global::ADODB.RecordsetEvents_SinkHelper)this.m_aEventSinkHelpers[num];
						if (recordsetEvents_SinkHelper.m_RecordsetChangeCompleteDelegate != null && ((recordsetEvents_SinkHelper.m_RecordsetChangeCompleteDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
						{
							break;
						}
						num++;
						if (num >= count)
						{
							goto IL_D3;
						}
					}
					this.m_aEventSinkHelpers.RemoveAt(num);
					this.m_ConnectionPoint.Unadvise(recordsetEvents_SinkHelper.m_dwCookie);
					if (count <= 1)
					{
						global::System.Runtime.InteropServices.Marshal.ReleaseComObject(this.m_ConnectionPoint);
						this.m_ConnectionPoint = null;
						this.m_aEventSinkHelpers = null;
					}
				}
				IL_D3:;
			}
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x000031B0 File Offset: 0x000021B0
		public void add_WillChangeRecordset(global::ADODB.RecordsetEvents_WillChangeRecordsetEventHandler A_1)
		{
			lock (this)
			{
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				global::ADODB.RecordsetEvents_SinkHelper recordsetEvents_SinkHelper = new global::ADODB.RecordsetEvents_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)recordsetEvents_SinkHelper, out dwCookie);
				recordsetEvents_SinkHelper.m_dwCookie = dwCookie;
				recordsetEvents_SinkHelper.m_WillChangeRecordsetDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)recordsetEvents_SinkHelper);
			}
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x00003240 File Offset: 0x00002240
		public void remove_WillChangeRecordset(global::ADODB.RecordsetEvents_WillChangeRecordsetEventHandler A_1)
		{
			lock (this)
			{
				int count = this.m_aEventSinkHelpers.Count;
				int num = 0;
				if (0 < count)
				{
					global::ADODB.RecordsetEvents_SinkHelper recordsetEvents_SinkHelper;
					for (;;)
					{
						recordsetEvents_SinkHelper = (global::ADODB.RecordsetEvents_SinkHelper)this.m_aEventSinkHelpers[num];
						if (recordsetEvents_SinkHelper.m_WillChangeRecordsetDelegate != null && ((recordsetEvents_SinkHelper.m_WillChangeRecordsetDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
						{
							break;
						}
						num++;
						if (num >= count)
						{
							goto IL_D3;
						}
					}
					this.m_aEventSinkHelpers.RemoveAt(num);
					this.m_ConnectionPoint.Unadvise(recordsetEvents_SinkHelper.m_dwCookie);
					if (count <= 1)
					{
						global::System.Runtime.InteropServices.Marshal.ReleaseComObject(this.m_ConnectionPoint);
						this.m_ConnectionPoint = null;
						this.m_aEventSinkHelpers = null;
					}
				}
				IL_D3:;
			}
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x00003340 File Offset: 0x00002340
		public void add_RecordChangeComplete(global::ADODB.RecordsetEvents_RecordChangeCompleteEventHandler A_1)
		{
			lock (this)
			{
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				global::ADODB.RecordsetEvents_SinkHelper recordsetEvents_SinkHelper = new global::ADODB.RecordsetEvents_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)recordsetEvents_SinkHelper, out dwCookie);
				recordsetEvents_SinkHelper.m_dwCookie = dwCookie;
				recordsetEvents_SinkHelper.m_RecordChangeCompleteDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)recordsetEvents_SinkHelper);
			}
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x000033D0 File Offset: 0x000023D0
		public void remove_RecordChangeComplete(global::ADODB.RecordsetEvents_RecordChangeCompleteEventHandler A_1)
		{
			lock (this)
			{
				int count = this.m_aEventSinkHelpers.Count;
				int num = 0;
				if (0 < count)
				{
					global::ADODB.RecordsetEvents_SinkHelper recordsetEvents_SinkHelper;
					for (;;)
					{
						recordsetEvents_SinkHelper = (global::ADODB.RecordsetEvents_SinkHelper)this.m_aEventSinkHelpers[num];
						if (recordsetEvents_SinkHelper.m_RecordChangeCompleteDelegate != null && ((recordsetEvents_SinkHelper.m_RecordChangeCompleteDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
						{
							break;
						}
						num++;
						if (num >= count)
						{
							goto IL_D3;
						}
					}
					this.m_aEventSinkHelpers.RemoveAt(num);
					this.m_ConnectionPoint.Unadvise(recordsetEvents_SinkHelper.m_dwCookie);
					if (count <= 1)
					{
						global::System.Runtime.InteropServices.Marshal.ReleaseComObject(this.m_ConnectionPoint);
						this.m_ConnectionPoint = null;
						this.m_aEventSinkHelpers = null;
					}
				}
				IL_D3:;
			}
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x000034D0 File Offset: 0x000024D0
		public void add_WillChangeRecord(global::ADODB.RecordsetEvents_WillChangeRecordEventHandler A_1)
		{
			lock (this)
			{
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				global::ADODB.RecordsetEvents_SinkHelper recordsetEvents_SinkHelper = new global::ADODB.RecordsetEvents_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)recordsetEvents_SinkHelper, out dwCookie);
				recordsetEvents_SinkHelper.m_dwCookie = dwCookie;
				recordsetEvents_SinkHelper.m_WillChangeRecordDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)recordsetEvents_SinkHelper);
			}
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x00003560 File Offset: 0x00002560
		public void remove_WillChangeRecord(global::ADODB.RecordsetEvents_WillChangeRecordEventHandler A_1)
		{
			lock (this)
			{
				int count = this.m_aEventSinkHelpers.Count;
				int num = 0;
				if (0 < count)
				{
					global::ADODB.RecordsetEvents_SinkHelper recordsetEvents_SinkHelper;
					for (;;)
					{
						recordsetEvents_SinkHelper = (global::ADODB.RecordsetEvents_SinkHelper)this.m_aEventSinkHelpers[num];
						if (recordsetEvents_SinkHelper.m_WillChangeRecordDelegate != null && ((recordsetEvents_SinkHelper.m_WillChangeRecordDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
						{
							break;
						}
						num++;
						if (num >= count)
						{
							goto IL_D3;
						}
					}
					this.m_aEventSinkHelpers.RemoveAt(num);
					this.m_ConnectionPoint.Unadvise(recordsetEvents_SinkHelper.m_dwCookie);
					if (count <= 1)
					{
						global::System.Runtime.InteropServices.Marshal.ReleaseComObject(this.m_ConnectionPoint);
						this.m_ConnectionPoint = null;
						this.m_aEventSinkHelpers = null;
					}
				}
				IL_D3:;
			}
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x00003660 File Offset: 0x00002660
		public void add_FieldChangeComplete(global::ADODB.RecordsetEvents_FieldChangeCompleteEventHandler A_1)
		{
			lock (this)
			{
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				global::ADODB.RecordsetEvents_SinkHelper recordsetEvents_SinkHelper = new global::ADODB.RecordsetEvents_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)recordsetEvents_SinkHelper, out dwCookie);
				recordsetEvents_SinkHelper.m_dwCookie = dwCookie;
				recordsetEvents_SinkHelper.m_FieldChangeCompleteDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)recordsetEvents_SinkHelper);
			}
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x000036F0 File Offset: 0x000026F0
		public void remove_FieldChangeComplete(global::ADODB.RecordsetEvents_FieldChangeCompleteEventHandler A_1)
		{
			lock (this)
			{
				int count = this.m_aEventSinkHelpers.Count;
				int num = 0;
				if (0 < count)
				{
					global::ADODB.RecordsetEvents_SinkHelper recordsetEvents_SinkHelper;
					for (;;)
					{
						recordsetEvents_SinkHelper = (global::ADODB.RecordsetEvents_SinkHelper)this.m_aEventSinkHelpers[num];
						if (recordsetEvents_SinkHelper.m_FieldChangeCompleteDelegate != null && ((recordsetEvents_SinkHelper.m_FieldChangeCompleteDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
						{
							break;
						}
						num++;
						if (num >= count)
						{
							goto IL_D3;
						}
					}
					this.m_aEventSinkHelpers.RemoveAt(num);
					this.m_ConnectionPoint.Unadvise(recordsetEvents_SinkHelper.m_dwCookie);
					if (count <= 1)
					{
						global::System.Runtime.InteropServices.Marshal.ReleaseComObject(this.m_ConnectionPoint);
						this.m_ConnectionPoint = null;
						this.m_aEventSinkHelpers = null;
					}
				}
				IL_D3:;
			}
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x000037F0 File Offset: 0x000027F0
		public void add_WillChangeField(global::ADODB.RecordsetEvents_WillChangeFieldEventHandler A_1)
		{
			lock (this)
			{
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				global::ADODB.RecordsetEvents_SinkHelper recordsetEvents_SinkHelper = new global::ADODB.RecordsetEvents_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)recordsetEvents_SinkHelper, out dwCookie);
				recordsetEvents_SinkHelper.m_dwCookie = dwCookie;
				recordsetEvents_SinkHelper.m_WillChangeFieldDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)recordsetEvents_SinkHelper);
			}
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x00003880 File Offset: 0x00002880
		public void remove_WillChangeField(global::ADODB.RecordsetEvents_WillChangeFieldEventHandler A_1)
		{
			lock (this)
			{
				int count = this.m_aEventSinkHelpers.Count;
				int num = 0;
				if (0 < count)
				{
					global::ADODB.RecordsetEvents_SinkHelper recordsetEvents_SinkHelper;
					for (;;)
					{
						recordsetEvents_SinkHelper = (global::ADODB.RecordsetEvents_SinkHelper)this.m_aEventSinkHelpers[num];
						if (recordsetEvents_SinkHelper.m_WillChangeFieldDelegate != null && ((recordsetEvents_SinkHelper.m_WillChangeFieldDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
						{
							break;
						}
						num++;
						if (num >= count)
						{
							goto IL_D3;
						}
					}
					this.m_aEventSinkHelpers.RemoveAt(num);
					this.m_ConnectionPoint.Unadvise(recordsetEvents_SinkHelper.m_dwCookie);
					if (count <= 1)
					{
						global::System.Runtime.InteropServices.Marshal.ReleaseComObject(this.m_ConnectionPoint);
						this.m_ConnectionPoint = null;
						this.m_aEventSinkHelpers = null;
					}
				}
				IL_D3:;
			}
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x00003980 File Offset: 0x00002980
		public RecordsetEvents_EventProvider(object A_1)
		{
			this.m_ConnectionPointContainer = (global::System.Runtime.InteropServices.UCOMIConnectionPointContainer)A_1;
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x000039A8 File Offset: 0x000029A8
		public override void Finalize()
		{
			lock (this)
			{
				try
				{
					if (this.m_ConnectionPoint != null)
					{
						int count = this.m_aEventSinkHelpers.Count;
						int num = 0;
						if (0 < count)
						{
							do
							{
								global::ADODB.RecordsetEvents_SinkHelper recordsetEvents_SinkHelper = (global::ADODB.RecordsetEvents_SinkHelper)this.m_aEventSinkHelpers[num];
								this.m_ConnectionPoint.Unadvise(recordsetEvents_SinkHelper.m_dwCookie);
								num++;
							}
							while (num < count);
						}
						global::System.Runtime.InteropServices.Marshal.ReleaseComObject(this.m_ConnectionPoint);
					}
				}
				catch (global::System.Exception)
				{
				}
			}
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x00003A6C File Offset: 0x00002A6C
		public void Dispose()
		{
			this.Finalize();
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x040001E9 RID: 489
		private global::System.Runtime.InteropServices.UCOMIConnectionPointContainer m_ConnectionPointContainer;

		// Token: 0x040001EA RID: 490
		private global::System.Collections.ArrayList m_aEventSinkHelpers;

		// Token: 0x040001EB RID: 491
		private global::System.Runtime.InteropServices.UCOMIConnectionPoint m_ConnectionPoint;
	}
}
