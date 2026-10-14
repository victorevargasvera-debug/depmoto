using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace CDO
{
	// Token: 0x0200007D RID: 125
	internal sealed class INNTPOnPost_EventProvider : global::CDO.INNTPOnPost_Event, global::System.IDisposable
	{
		// Token: 0x060003C5 RID: 965 RVA: 0x00002D20 File Offset: 0x00001D20
		private void Init()
		{
			global::System.Runtime.InteropServices.ComTypes.IConnectionPoint connectionPoint = null;
			global::System.Guid guid = new global::System.Guid(new byte[]
			{
				39,
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

		// Token: 0x060003C6 RID: 966 RVA: 0x00002E34 File Offset: 0x00001E34
		public void add_OnPost(global::CDO.INNTPOnPost_OnPostEventHandler A_1)
		{
			lock (this)
			{
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				global::CDO.INNTPOnPost_SinkHelper inntponPost_SinkHelper = new global::CDO.INNTPOnPost_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)inntponPost_SinkHelper, out dwCookie);
				inntponPost_SinkHelper.m_dwCookie = dwCookie;
				inntponPost_SinkHelper.m_OnPostDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)inntponPost_SinkHelper);
			}
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x00002EC4 File Offset: 0x00001EC4
		public void remove_OnPost(global::CDO.INNTPOnPost_OnPostEventHandler A_1)
		{
			lock (this)
			{
				if (this.m_aEventSinkHelpers != null)
				{
					int count = this.m_aEventSinkHelpers.Count;
					int num = 0;
					if (0 < count)
					{
						global::CDO.INNTPOnPost_SinkHelper inntponPost_SinkHelper;
						for (;;)
						{
							inntponPost_SinkHelper = (global::CDO.INNTPOnPost_SinkHelper)this.m_aEventSinkHelpers[num];
							if (inntponPost_SinkHelper.m_OnPostDelegate != null && ((inntponPost_SinkHelper.m_OnPostDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
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
						this.m_ConnectionPoint.Unadvise(inntponPost_SinkHelper.m_dwCookie);
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

		// Token: 0x060003C8 RID: 968 RVA: 0x00002FD4 File Offset: 0x00001FD4
		public INNTPOnPost_EventProvider(object A_1)
		{
			this.m_ConnectionPointContainer = (global::System.Runtime.InteropServices.ComTypes.IConnectionPointContainer)A_1;
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x00002FFC File Offset: 0x00001FFC
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
								global::CDO.INNTPOnPost_SinkHelper inntponPost_SinkHelper = (global::CDO.INNTPOnPost_SinkHelper)this.m_aEventSinkHelpers[num];
								this.m_ConnectionPoint.Unadvise(inntponPost_SinkHelper.m_dwCookie);
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

		// Token: 0x060003CA RID: 970 RVA: 0x000030C0 File Offset: 0x000020C0
		public void Dispose()
		{
			this.Finalize();
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x0400028A RID: 650
		private global::System.Runtime.InteropServices.ComTypes.IConnectionPointContainer m_ConnectionPointContainer;

		// Token: 0x0400028B RID: 651
		private global::System.Collections.ArrayList m_aEventSinkHelpers;

		// Token: 0x0400028C RID: 652
		private global::System.Runtime.InteropServices.ComTypes.IConnectionPoint m_ConnectionPoint;
	}
}
