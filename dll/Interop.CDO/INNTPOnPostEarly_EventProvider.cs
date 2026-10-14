using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace CDO
{
	// Token: 0x02000079 RID: 121
	internal sealed class INNTPOnPostEarly_EventProvider : global::CDO.INNTPOnPostEarly_Event, global::System.IDisposable
	{
		// Token: 0x060003B5 RID: 949 RVA: 0x000024D8 File Offset: 0x000014D8
		private void Init()
		{
			global::System.Runtime.InteropServices.ComTypes.IConnectionPoint connectionPoint = null;
			global::System.Guid guid = new global::System.Guid(new byte[]
			{
				51,
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

		// Token: 0x060003B6 RID: 950 RVA: 0x000025EC File Offset: 0x000015EC
		public void add_OnPostEarly(global::CDO.INNTPOnPostEarly_OnPostEarlyEventHandler A_1)
		{
			lock (this)
			{
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				global::CDO.INNTPOnPostEarly_SinkHelper inntponPostEarly_SinkHelper = new global::CDO.INNTPOnPostEarly_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)inntponPostEarly_SinkHelper, out dwCookie);
				inntponPostEarly_SinkHelper.m_dwCookie = dwCookie;
				inntponPostEarly_SinkHelper.m_OnPostEarlyDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)inntponPostEarly_SinkHelper);
			}
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x0000267C File Offset: 0x0000167C
		public void remove_OnPostEarly(global::CDO.INNTPOnPostEarly_OnPostEarlyEventHandler A_1)
		{
			lock (this)
			{
				if (this.m_aEventSinkHelpers != null)
				{
					int count = this.m_aEventSinkHelpers.Count;
					int num = 0;
					if (0 < count)
					{
						global::CDO.INNTPOnPostEarly_SinkHelper inntponPostEarly_SinkHelper;
						for (;;)
						{
							inntponPostEarly_SinkHelper = (global::CDO.INNTPOnPostEarly_SinkHelper)this.m_aEventSinkHelpers[num];
							if (inntponPostEarly_SinkHelper.m_OnPostEarlyDelegate != null && ((inntponPostEarly_SinkHelper.m_OnPostEarlyDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
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
						this.m_ConnectionPoint.Unadvise(inntponPostEarly_SinkHelper.m_dwCookie);
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

		// Token: 0x060003B8 RID: 952 RVA: 0x0000278C File Offset: 0x0000178C
		public INNTPOnPostEarly_EventProvider(object A_1)
		{
			this.m_ConnectionPointContainer = (global::System.Runtime.InteropServices.ComTypes.IConnectionPointContainer)A_1;
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x000027B4 File Offset: 0x000017B4
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
								global::CDO.INNTPOnPostEarly_SinkHelper inntponPostEarly_SinkHelper = (global::CDO.INNTPOnPostEarly_SinkHelper)this.m_aEventSinkHelpers[num];
								this.m_ConnectionPoint.Unadvise(inntponPostEarly_SinkHelper.m_dwCookie);
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

		// Token: 0x060003BA RID: 954 RVA: 0x00002878 File Offset: 0x00001878
		public void Dispose()
		{
			this.Finalize();
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x04000280 RID: 640
		private global::System.Runtime.InteropServices.ComTypes.IConnectionPointContainer m_ConnectionPointContainer;

		// Token: 0x04000281 RID: 641
		private global::System.Collections.ArrayList m_aEventSinkHelpers;

		// Token: 0x04000282 RID: 642
		private global::System.Runtime.InteropServices.ComTypes.IConnectionPoint m_ConnectionPoint;
	}
}
