using System;
using System.Collections;
using System.Runtime.InteropServices;

namespace SHDocVw
{
	// Token: 0x02000073 RID: 115
	internal sealed class _SearchAssistantEvents_EventProvider : global::SHDocVw._SearchAssistantEvents_Event, global::System.IDisposable
	{
		// Token: 0x06000641 RID: 1601 RVA: 0x00005128 File Offset: 0x00004128
		private void Init()
		{
			global::System.Runtime.InteropServices.UCOMIConnectionPoint ucomiconnectionPoint = null;
			global::System.Guid guid = new global::System.Guid(new byte[]
			{
				218,
				253,
				17,
				22,
				91,
				68,
				210,
				17,
				133,
				222,
				0,
				192,
				79,
				163,
				92,
				137
			});
			this.m_ConnectionPointContainer.FindConnectionPoint(ref guid, out ucomiconnectionPoint);
			this.m_ConnectionPoint = (global::System.Runtime.InteropServices.UCOMIConnectionPoint)ucomiconnectionPoint;
			this.m_aEventSinkHelpers = new global::System.Collections.ArrayList();
		}

		// Token: 0x06000642 RID: 1602 RVA: 0x0000523C File Offset: 0x0000423C
		public void add_OnNewSearch(global::SHDocVw._SearchAssistantEvents_OnNewSearchEventHandler A_1)
		{
			lock (this)
			{
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				global::SHDocVw._SearchAssistantEvents_SinkHelper searchAssistantEvents_SinkHelper = new global::SHDocVw._SearchAssistantEvents_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)searchAssistantEvents_SinkHelper, out dwCookie);
				searchAssistantEvents_SinkHelper.m_dwCookie = dwCookie;
				searchAssistantEvents_SinkHelper.m_OnNewSearchDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)searchAssistantEvents_SinkHelper);
			}
		}

		// Token: 0x06000643 RID: 1603 RVA: 0x000052CC File Offset: 0x000042CC
		public void remove_OnNewSearch(global::SHDocVw._SearchAssistantEvents_OnNewSearchEventHandler A_1)
		{
			lock (this)
			{
				int count = this.m_aEventSinkHelpers.Count;
				int num = 0;
				if (0 < count)
				{
					global::SHDocVw._SearchAssistantEvents_SinkHelper searchAssistantEvents_SinkHelper;
					for (;;)
					{
						searchAssistantEvents_SinkHelper = (global::SHDocVw._SearchAssistantEvents_SinkHelper)this.m_aEventSinkHelpers[num];
						if (searchAssistantEvents_SinkHelper.m_OnNewSearchDelegate != null && ((searchAssistantEvents_SinkHelper.m_OnNewSearchDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
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
					this.m_ConnectionPoint.Unadvise(searchAssistantEvents_SinkHelper.m_dwCookie);
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

		// Token: 0x06000644 RID: 1604 RVA: 0x000053CC File Offset: 0x000043CC
		public void add_OnNextMenuSelect(global::SHDocVw._SearchAssistantEvents_OnNextMenuSelectEventHandler A_1)
		{
			lock (this)
			{
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				global::SHDocVw._SearchAssistantEvents_SinkHelper searchAssistantEvents_SinkHelper = new global::SHDocVw._SearchAssistantEvents_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)searchAssistantEvents_SinkHelper, out dwCookie);
				searchAssistantEvents_SinkHelper.m_dwCookie = dwCookie;
				searchAssistantEvents_SinkHelper.m_OnNextMenuSelectDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)searchAssistantEvents_SinkHelper);
			}
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x0000545C File Offset: 0x0000445C
		public void remove_OnNextMenuSelect(global::SHDocVw._SearchAssistantEvents_OnNextMenuSelectEventHandler A_1)
		{
			lock (this)
			{
				int count = this.m_aEventSinkHelpers.Count;
				int num = 0;
				if (0 < count)
				{
					global::SHDocVw._SearchAssistantEvents_SinkHelper searchAssistantEvents_SinkHelper;
					for (;;)
					{
						searchAssistantEvents_SinkHelper = (global::SHDocVw._SearchAssistantEvents_SinkHelper)this.m_aEventSinkHelpers[num];
						if (searchAssistantEvents_SinkHelper.m_OnNextMenuSelectDelegate != null && ((searchAssistantEvents_SinkHelper.m_OnNextMenuSelectDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
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
					this.m_ConnectionPoint.Unadvise(searchAssistantEvents_SinkHelper.m_dwCookie);
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

		// Token: 0x06000646 RID: 1606 RVA: 0x0000555C File Offset: 0x0000455C
		public _SearchAssistantEvents_EventProvider(object A_1)
		{
			this.m_ConnectionPointContainer = (global::System.Runtime.InteropServices.UCOMIConnectionPointContainer)A_1;
		}

		// Token: 0x06000647 RID: 1607 RVA: 0x00005584 File Offset: 0x00004584
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
								global::SHDocVw._SearchAssistantEvents_SinkHelper searchAssistantEvents_SinkHelper = (global::SHDocVw._SearchAssistantEvents_SinkHelper)this.m_aEventSinkHelpers[num];
								this.m_ConnectionPoint.Unadvise(searchAssistantEvents_SinkHelper.m_dwCookie);
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

		// Token: 0x06000648 RID: 1608 RVA: 0x00005648 File Offset: 0x00004648
		public void Dispose()
		{
			this.Finalize();
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x04000083 RID: 131
		private global::System.Runtime.InteropServices.UCOMIConnectionPointContainer m_ConnectionPointContainer;

		// Token: 0x04000084 RID: 132
		private global::System.Collections.ArrayList m_aEventSinkHelpers;

		// Token: 0x04000085 RID: 133
		private global::System.Runtime.InteropServices.UCOMIConnectionPoint m_ConnectionPoint;
	}
}
