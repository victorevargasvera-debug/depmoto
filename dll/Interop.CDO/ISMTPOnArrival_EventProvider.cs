using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace CDO
{
	// Token: 0x02000077 RID: 119
	internal sealed class ISMTPOnArrival_EventProvider : global::CDO.ISMTPOnArrival_Event, global::System.IDisposable
	{
		// Token: 0x060003AD RID: 941 RVA: 0x000020B4 File Offset: 0x000010B4
		private void Init()
		{
			global::System.Runtime.InteropServices.ComTypes.IConnectionPoint connectionPoint = null;
			global::System.Guid guid = new global::System.Guid(new byte[]
			{
				38,
				0,
				0,
				205,
				149,
				139,
				209,
				17,
				130,
				219,
				0,
				192,
				79,
				177,
				98,
				93
			});
			this.m_ConnectionPointContainer.FindConnectionPoint(ref guid, out connectionPoint);
			this.m_ConnectionPoint = (global::System.Runtime.InteropServices.ComTypes.IConnectionPoint)connectionPoint;
			this.m_aEventSinkHelpers = new global::System.Collections.ArrayList();
		}

		// Token: 0x060003AE RID: 942 RVA: 0x000021C8 File Offset: 0x000011C8
		public void add_OnArrival(global::CDO.ISMTPOnArrival_OnArrivalEventHandler A_1)
		{
			lock (this)
			{
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				global::CDO.ISMTPOnArrival_SinkHelper ismtponArrival_SinkHelper = new global::CDO.ISMTPOnArrival_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)ismtponArrival_SinkHelper, out dwCookie);
				ismtponArrival_SinkHelper.m_dwCookie = dwCookie;
				ismtponArrival_SinkHelper.m_OnArrivalDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)ismtponArrival_SinkHelper);
			}
		}

		// Token: 0x060003AF RID: 943 RVA: 0x00002258 File Offset: 0x00001258
		public void remove_OnArrival(global::CDO.ISMTPOnArrival_OnArrivalEventHandler A_1)
		{
			lock (this)
			{
				if (this.m_aEventSinkHelpers != null)
				{
					int count = this.m_aEventSinkHelpers.Count;
					int num = 0;
					if (0 < count)
					{
						global::CDO.ISMTPOnArrival_SinkHelper ismtponArrival_SinkHelper;
						for (;;)
						{
							ismtponArrival_SinkHelper = (global::CDO.ISMTPOnArrival_SinkHelper)this.m_aEventSinkHelpers[num];
							if (ismtponArrival_SinkHelper.m_OnArrivalDelegate != null && ((ismtponArrival_SinkHelper.m_OnArrivalDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
							{
								break;
							}
							num++;
							if (num >= count)
							{
								goto IL_E1;
							}
						}
						this.m_aEventSinkHelpers.RemoveAt(num);
						this.m_ConnectionPoint.Unadvise(ismtponArrival_SinkHelper.m_dwCookie);
						if (count <= 1)
						{
							global::System.Runtime.InteropServices.Marshal.ReleaseComObject(this.m_ConnectionPoint);
							this.m_ConnectionPoint = null;
							this.m_aEventSinkHelpers = null;
						}
					}
				}
				IL_E1:;
			}
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x00002368 File Offset: 0x00001368
		public ISMTPOnArrival_EventProvider(object A_1)
		{
			this.m_ConnectionPointContainer = (global::System.Runtime.InteropServices.ComTypes.IConnectionPointContainer)A_1;
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x00002390 File Offset: 0x00001390
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
								global::CDO.ISMTPOnArrival_SinkHelper ismtponArrival_SinkHelper = (global::CDO.ISMTPOnArrival_SinkHelper)this.m_aEventSinkHelpers[num];
								this.m_ConnectionPoint.Unadvise(ismtponArrival_SinkHelper.m_dwCookie);
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

		// Token: 0x060003B2 RID: 946 RVA: 0x00002454 File Offset: 0x00001454
		public void Dispose()
		{
			this.Finalize();
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x0400027B RID: 635
		private global::System.Runtime.InteropServices.ComTypes.IConnectionPointContainer m_ConnectionPointContainer;

		// Token: 0x0400027C RID: 636
		private global::System.Collections.ArrayList m_aEventSinkHelpers;

		// Token: 0x0400027D RID: 637
		private global::System.Runtime.InteropServices.ComTypes.IConnectionPoint m_ConnectionPoint;
	}
}
