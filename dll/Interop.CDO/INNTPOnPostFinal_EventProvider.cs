using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace CDO
{
	// Token: 0x0200007B RID: 123
	internal sealed class INNTPOnPostFinal_EventProvider : global::CDO.INNTPOnPostFinal_Event, global::System.IDisposable
	{
		// Token: 0x060003BD RID: 957 RVA: 0x000028FC File Offset: 0x000018FC
		private void Init()
		{
			global::System.Runtime.InteropServices.ComTypes.IConnectionPoint connectionPoint = null;
			global::System.Guid guid = new global::System.Guid(new byte[]
			{
				40,
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

		// Token: 0x060003BE RID: 958 RVA: 0x00002A10 File Offset: 0x00001A10
		public void add_OnPostFinal(global::CDO.INNTPOnPostFinal_OnPostFinalEventHandler A_1)
		{
			lock (this)
			{
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				global::CDO.INNTPOnPostFinal_SinkHelper inntponPostFinal_SinkHelper = new global::CDO.INNTPOnPostFinal_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)inntponPostFinal_SinkHelper, out dwCookie);
				inntponPostFinal_SinkHelper.m_dwCookie = dwCookie;
				inntponPostFinal_SinkHelper.m_OnPostFinalDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)inntponPostFinal_SinkHelper);
			}
		}

		// Token: 0x060003BF RID: 959 RVA: 0x00002AA0 File Offset: 0x00001AA0
		public void remove_OnPostFinal(global::CDO.INNTPOnPostFinal_OnPostFinalEventHandler A_1)
		{
			lock (this)
			{
				if (this.m_aEventSinkHelpers != null)
				{
					int count = this.m_aEventSinkHelpers.Count;
					int num = 0;
					if (0 < count)
					{
						global::CDO.INNTPOnPostFinal_SinkHelper inntponPostFinal_SinkHelper;
						for (;;)
						{
							inntponPostFinal_SinkHelper = (global::CDO.INNTPOnPostFinal_SinkHelper)this.m_aEventSinkHelpers[num];
							if (inntponPostFinal_SinkHelper.m_OnPostFinalDelegate != null && ((inntponPostFinal_SinkHelper.m_OnPostFinalDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
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
						this.m_ConnectionPoint.Unadvise(inntponPostFinal_SinkHelper.m_dwCookie);
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

		// Token: 0x060003C0 RID: 960 RVA: 0x00002BB0 File Offset: 0x00001BB0
		public INNTPOnPostFinal_EventProvider(object A_1)
		{
			this.m_ConnectionPointContainer = (global::System.Runtime.InteropServices.ComTypes.IConnectionPointContainer)A_1;
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x00002BD8 File Offset: 0x00001BD8
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
								global::CDO.INNTPOnPostFinal_SinkHelper inntponPostFinal_SinkHelper = (global::CDO.INNTPOnPostFinal_SinkHelper)this.m_aEventSinkHelpers[num];
								this.m_ConnectionPoint.Unadvise(inntponPostFinal_SinkHelper.m_dwCookie);
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

		// Token: 0x060003C2 RID: 962 RVA: 0x00002C9C File Offset: 0x00001C9C
		public void Dispose()
		{
			this.Finalize();
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x04000285 RID: 645
		private global::System.Runtime.InteropServices.ComTypes.IConnectionPointContainer m_ConnectionPointContainer;

		// Token: 0x04000286 RID: 646
		private global::System.Collections.ArrayList m_aEventSinkHelpers;

		// Token: 0x04000287 RID: 647
		private global::System.Runtime.InteropServices.ComTypes.IConnectionPoint m_ConnectionPoint;
	}
}
