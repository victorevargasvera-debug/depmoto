using System;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x02000DEC RID: 3564
	[global::System.Runtime.InteropServices.ClassInterface(global::System.Runtime.InteropServices.ClassInterfaceType.None)]
	internal sealed class HTMLMapEvents2_SinkHelper : global::mshtml.HTMLMapEvents2
	{
		// Token: 0x060183DE RID: 99294 RVA: 0x0008B2CC File Offset: 0x0008A2CC
		public bool onmousewheel(global::mshtml.IHTMLEventObj A_1)
		{
			return this.m_onmousewheelDelegate != null && this.m_onmousewheelDelegate(A_1);
		}

		// Token: 0x060183DF RID: 99295 RVA: 0x0008B2FC File Offset: 0x0008A2FC
		public void onresizeend(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_onresizeendDelegate != null)
			{
				this.m_onresizeendDelegate(A_1);
				return;
			}
		}

		// Token: 0x060183E0 RID: 99296 RVA: 0x0008B32C File Offset: 0x0008A32C
		public bool onresizestart(global::mshtml.IHTMLEventObj A_1)
		{
			return this.m_onresizestartDelegate != null && this.m_onresizestartDelegate(A_1);
		}

		// Token: 0x060183E1 RID: 99297 RVA: 0x0008B35C File Offset: 0x0008A35C
		public void onmoveend(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_onmoveendDelegate != null)
			{
				this.m_onmoveendDelegate(A_1);
				return;
			}
		}

		// Token: 0x060183E2 RID: 99298 RVA: 0x0008B38C File Offset: 0x0008A38C
		public bool onmovestart(global::mshtml.IHTMLEventObj A_1)
		{
			return this.m_onmovestartDelegate != null && this.m_onmovestartDelegate(A_1);
		}

		// Token: 0x060183E3 RID: 99299 RVA: 0x0008B3BC File Offset: 0x0008A3BC
		public bool oncontrolselect(global::mshtml.IHTMLEventObj A_1)
		{
			return this.m_oncontrolselectDelegate != null && this.m_oncontrolselectDelegate(A_1);
		}

		// Token: 0x060183E4 RID: 99300 RVA: 0x0008B3EC File Offset: 0x0008A3EC
		public void onmove(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_onmoveDelegate != null)
			{
				this.m_onmoveDelegate(A_1);
				return;
			}
		}

		// Token: 0x060183E5 RID: 99301 RVA: 0x0008B41C File Offset: 0x0008A41C
		public void onfocusout(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_onfocusoutDelegate != null)
			{
				this.m_onfocusoutDelegate(A_1);
				return;
			}
		}

		// Token: 0x060183E6 RID: 99302 RVA: 0x0008B44C File Offset: 0x0008A44C
		public void onfocusin(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_onfocusinDelegate != null)
			{
				this.m_onfocusinDelegate(A_1);
				return;
			}
		}

		// Token: 0x060183E7 RID: 99303 RVA: 0x0008B47C File Offset: 0x0008A47C
		public bool onbeforeactivate(global::mshtml.IHTMLEventObj A_1)
		{
			return this.m_onbeforeactivateDelegate != null && this.m_onbeforeactivateDelegate(A_1);
		}

		// Token: 0x060183E8 RID: 99304 RVA: 0x0008B4AC File Offset: 0x0008A4AC
		public bool onbeforedeactivate(global::mshtml.IHTMLEventObj A_1)
		{
			return this.m_onbeforedeactivateDelegate != null && this.m_onbeforedeactivateDelegate(A_1);
		}

		// Token: 0x060183E9 RID: 99305 RVA: 0x0008B4DC File Offset: 0x0008A4DC
		public void ondeactivate(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_ondeactivateDelegate != null)
			{
				this.m_ondeactivateDelegate(A_1);
				return;
			}
		}

		// Token: 0x060183EA RID: 99306 RVA: 0x0008B50C File Offset: 0x0008A50C
		public void onactivate(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_onactivateDelegate != null)
			{
				this.m_onactivateDelegate(A_1);
				return;
			}
		}

		// Token: 0x060183EB RID: 99307 RVA: 0x0008B53C File Offset: 0x0008A53C
		public void onmouseleave(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_onmouseleaveDelegate != null)
			{
				this.m_onmouseleaveDelegate(A_1);
				return;
			}
		}

		// Token: 0x060183EC RID: 99308 RVA: 0x0008B56C File Offset: 0x0008A56C
		public void onmouseenter(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_onmouseenterDelegate != null)
			{
				this.m_onmouseenterDelegate(A_1);
				return;
			}
		}

		// Token: 0x060183ED RID: 99309 RVA: 0x0008B59C File Offset: 0x0008A59C
		public void onpage(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_onpageDelegate != null)
			{
				this.m_onpageDelegate(A_1);
				return;
			}
		}

		// Token: 0x060183EE RID: 99310 RVA: 0x0008B5CC File Offset: 0x0008A5CC
		public void onlayoutcomplete(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_onlayoutcompleteDelegate != null)
			{
				this.m_onlayoutcompleteDelegate(A_1);
				return;
			}
		}

		// Token: 0x060183EF RID: 99311 RVA: 0x0008B5FC File Offset: 0x0008A5FC
		public void onreadystatechange(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_onreadystatechangeDelegate != null)
			{
				this.m_onreadystatechangeDelegate(A_1);
				return;
			}
		}

		// Token: 0x060183F0 RID: 99312 RVA: 0x0008B62C File Offset: 0x0008A62C
		public void oncellchange(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_oncellchangeDelegate != null)
			{
				this.m_oncellchangeDelegate(A_1);
				return;
			}
		}

		// Token: 0x060183F1 RID: 99313 RVA: 0x0008B65C File Offset: 0x0008A65C
		public void onrowsinserted(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_onrowsinsertedDelegate != null)
			{
				this.m_onrowsinsertedDelegate(A_1);
				return;
			}
		}

		// Token: 0x060183F2 RID: 99314 RVA: 0x0008B68C File Offset: 0x0008A68C
		public void onrowsdelete(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_onrowsdeleteDelegate != null)
			{
				this.m_onrowsdeleteDelegate(A_1);
				return;
			}
		}

		// Token: 0x060183F3 RID: 99315 RVA: 0x0008B6BC File Offset: 0x0008A6BC
		public bool oncontextmenu(global::mshtml.IHTMLEventObj A_1)
		{
			return this.m_oncontextmenuDelegate != null && this.m_oncontextmenuDelegate(A_1);
		}

		// Token: 0x060183F4 RID: 99316 RVA: 0x0008B6EC File Offset: 0x0008A6EC
		public bool onpaste(global::mshtml.IHTMLEventObj A_1)
		{
			return this.m_onpasteDelegate != null && this.m_onpasteDelegate(A_1);
		}

		// Token: 0x060183F5 RID: 99317 RVA: 0x0008B71C File Offset: 0x0008A71C
		public bool onbeforepaste(global::mshtml.IHTMLEventObj A_1)
		{
			return this.m_onbeforepasteDelegate != null && this.m_onbeforepasteDelegate(A_1);
		}

		// Token: 0x060183F6 RID: 99318 RVA: 0x0008B74C File Offset: 0x0008A74C
		public bool oncopy(global::mshtml.IHTMLEventObj A_1)
		{
			return this.m_oncopyDelegate != null && this.m_oncopyDelegate(A_1);
		}

		// Token: 0x060183F7 RID: 99319 RVA: 0x0008B77C File Offset: 0x0008A77C
		public bool onbeforecopy(global::mshtml.IHTMLEventObj A_1)
		{
			return this.m_onbeforecopyDelegate != null && this.m_onbeforecopyDelegate(A_1);
		}

		// Token: 0x060183F8 RID: 99320 RVA: 0x0008B7AC File Offset: 0x0008A7AC
		public bool oncut(global::mshtml.IHTMLEventObj A_1)
		{
			return this.m_oncutDelegate != null && this.m_oncutDelegate(A_1);
		}

		// Token: 0x060183F9 RID: 99321 RVA: 0x0008B7DC File Offset: 0x0008A7DC
		public bool onbeforecut(global::mshtml.IHTMLEventObj A_1)
		{
			return this.m_onbeforecutDelegate != null && this.m_onbeforecutDelegate(A_1);
		}

		// Token: 0x060183FA RID: 99322 RVA: 0x0008B80C File Offset: 0x0008A80C
		public bool ondrop(global::mshtml.IHTMLEventObj A_1)
		{
			return this.m_ondropDelegate != null && this.m_ondropDelegate(A_1);
		}

		// Token: 0x060183FB RID: 99323 RVA: 0x0008B83C File Offset: 0x0008A83C
		public void ondragleave(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_ondragleaveDelegate != null)
			{
				this.m_ondragleaveDelegate(A_1);
				return;
			}
		}

		// Token: 0x060183FC RID: 99324 RVA: 0x0008B86C File Offset: 0x0008A86C
		public bool ondragover(global::mshtml.IHTMLEventObj A_1)
		{
			return this.m_ondragoverDelegate != null && this.m_ondragoverDelegate(A_1);
		}

		// Token: 0x060183FD RID: 99325 RVA: 0x0008B89C File Offset: 0x0008A89C
		public bool ondragenter(global::mshtml.IHTMLEventObj A_1)
		{
			return this.m_ondragenterDelegate != null && this.m_ondragenterDelegate(A_1);
		}

		// Token: 0x060183FE RID: 99326 RVA: 0x0008B8CC File Offset: 0x0008A8CC
		public void ondragend(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_ondragendDelegate != null)
			{
				this.m_ondragendDelegate(A_1);
				return;
			}
		}

		// Token: 0x060183FF RID: 99327 RVA: 0x0008B8FC File Offset: 0x0008A8FC
		public bool ondrag(global::mshtml.IHTMLEventObj A_1)
		{
			return this.m_ondragDelegate != null && this.m_ondragDelegate(A_1);
		}

		// Token: 0x06018400 RID: 99328 RVA: 0x0008B92C File Offset: 0x0008A92C
		public void onresize(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_onresizeDelegate != null)
			{
				this.m_onresizeDelegate(A_1);
				return;
			}
		}

		// Token: 0x06018401 RID: 99329 RVA: 0x0008B95C File Offset: 0x0008A95C
		public void onblur(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_onblurDelegate != null)
			{
				this.m_onblurDelegate(A_1);
				return;
			}
		}

		// Token: 0x06018402 RID: 99330 RVA: 0x0008B98C File Offset: 0x0008A98C
		public void onfocus(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_onfocusDelegate != null)
			{
				this.m_onfocusDelegate(A_1);
				return;
			}
		}

		// Token: 0x06018403 RID: 99331 RVA: 0x0008B9BC File Offset: 0x0008A9BC
		public void onscroll(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_onscrollDelegate != null)
			{
				this.m_onscrollDelegate(A_1);
				return;
			}
		}

		// Token: 0x06018404 RID: 99332 RVA: 0x0008B9EC File Offset: 0x0008A9EC
		public void onpropertychange(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_onpropertychangeDelegate != null)
			{
				this.m_onpropertychangeDelegate(A_1);
				return;
			}
		}

		// Token: 0x06018405 RID: 99333 RVA: 0x0008BA1C File Offset: 0x0008AA1C
		public void onlosecapture(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_onlosecaptureDelegate != null)
			{
				this.m_onlosecaptureDelegate(A_1);
				return;
			}
		}

		// Token: 0x06018406 RID: 99334 RVA: 0x0008BA4C File Offset: 0x0008AA4C
		public void ondatasetcomplete(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_ondatasetcompleteDelegate != null)
			{
				this.m_ondatasetcompleteDelegate(A_1);
				return;
			}
		}

		// Token: 0x06018407 RID: 99335 RVA: 0x0008BA7C File Offset: 0x0008AA7C
		public void ondataavailable(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_ondataavailableDelegate != null)
			{
				this.m_ondataavailableDelegate(A_1);
				return;
			}
		}

		// Token: 0x06018408 RID: 99336 RVA: 0x0008BAAC File Offset: 0x0008AAAC
		public void ondatasetchanged(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_ondatasetchangedDelegate != null)
			{
				this.m_ondatasetchangedDelegate(A_1);
				return;
			}
		}

		// Token: 0x06018409 RID: 99337 RVA: 0x0008BADC File Offset: 0x0008AADC
		public void onrowenter(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_onrowenterDelegate != null)
			{
				this.m_onrowenterDelegate(A_1);
				return;
			}
		}

		// Token: 0x0601840A RID: 99338 RVA: 0x0008BB0C File Offset: 0x0008AB0C
		public bool onrowexit(global::mshtml.IHTMLEventObj A_1)
		{
			return this.m_onrowexitDelegate != null && this.m_onrowexitDelegate(A_1);
		}

		// Token: 0x0601840B RID: 99339 RVA: 0x0008BB3C File Offset: 0x0008AB3C
		public bool onerrorupdate(global::mshtml.IHTMLEventObj A_1)
		{
			return this.m_onerrorupdateDelegate != null && this.m_onerrorupdateDelegate(A_1);
		}

		// Token: 0x0601840C RID: 99340 RVA: 0x0008BB6C File Offset: 0x0008AB6C
		public void onafterupdate(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_onafterupdateDelegate != null)
			{
				this.m_onafterupdateDelegate(A_1);
				return;
			}
		}

		// Token: 0x0601840D RID: 99341 RVA: 0x0008BB9C File Offset: 0x0008AB9C
		public bool onbeforeupdate(global::mshtml.IHTMLEventObj A_1)
		{
			return this.m_onbeforeupdateDelegate != null && this.m_onbeforeupdateDelegate(A_1);
		}

		// Token: 0x0601840E RID: 99342 RVA: 0x0008BBCC File Offset: 0x0008ABCC
		public bool ondragstart(global::mshtml.IHTMLEventObj A_1)
		{
			return this.m_ondragstartDelegate != null && this.m_ondragstartDelegate(A_1);
		}

		// Token: 0x0601840F RID: 99343 RVA: 0x0008BBFC File Offset: 0x0008ABFC
		public void onfilterchange(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_onfilterchangeDelegate != null)
			{
				this.m_onfilterchangeDelegate(A_1);
				return;
			}
		}

		// Token: 0x06018410 RID: 99344 RVA: 0x0008BC2C File Offset: 0x0008AC2C
		public bool onselectstart(global::mshtml.IHTMLEventObj A_1)
		{
			return this.m_onselectstartDelegate != null && this.m_onselectstartDelegate(A_1);
		}

		// Token: 0x06018411 RID: 99345 RVA: 0x0008BC5C File Offset: 0x0008AC5C
		public void onmouseup(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_onmouseupDelegate != null)
			{
				this.m_onmouseupDelegate(A_1);
				return;
			}
		}

		// Token: 0x06018412 RID: 99346 RVA: 0x0008BC8C File Offset: 0x0008AC8C
		public void onmousedown(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_onmousedownDelegate != null)
			{
				this.m_onmousedownDelegate(A_1);
				return;
			}
		}

		// Token: 0x06018413 RID: 99347 RVA: 0x0008BCBC File Offset: 0x0008ACBC
		public void onmousemove(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_onmousemoveDelegate != null)
			{
				this.m_onmousemoveDelegate(A_1);
				return;
			}
		}

		// Token: 0x06018414 RID: 99348 RVA: 0x0008BCEC File Offset: 0x0008ACEC
		public void onmouseover(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_onmouseoverDelegate != null)
			{
				this.m_onmouseoverDelegate(A_1);
				return;
			}
		}

		// Token: 0x06018415 RID: 99349 RVA: 0x0008BD1C File Offset: 0x0008AD1C
		public void onmouseout(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_onmouseoutDelegate != null)
			{
				this.m_onmouseoutDelegate(A_1);
				return;
			}
		}

		// Token: 0x06018416 RID: 99350 RVA: 0x0008BD4C File Offset: 0x0008AD4C
		public void onkeyup(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_onkeyupDelegate != null)
			{
				this.m_onkeyupDelegate(A_1);
				return;
			}
		}

		// Token: 0x06018417 RID: 99351 RVA: 0x0008BD7C File Offset: 0x0008AD7C
		public void onkeydown(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_onkeydownDelegate != null)
			{
				this.m_onkeydownDelegate(A_1);
				return;
			}
		}

		// Token: 0x06018418 RID: 99352 RVA: 0x0008BDAC File Offset: 0x0008ADAC
		public bool onkeypress(global::mshtml.IHTMLEventObj A_1)
		{
			return this.m_onkeypressDelegate != null && this.m_onkeypressDelegate(A_1);
		}

		// Token: 0x06018419 RID: 99353 RVA: 0x0008BDDC File Offset: 0x0008ADDC
		public bool ondblclick(global::mshtml.IHTMLEventObj A_1)
		{
			return this.m_ondblclickDelegate != null && this.m_ondblclickDelegate(A_1);
		}

		// Token: 0x0601841A RID: 99354 RVA: 0x0008BE0C File Offset: 0x0008AE0C
		public bool onclick(global::mshtml.IHTMLEventObj A_1)
		{
			return this.m_onclickDelegate != null && this.m_onclickDelegate(A_1);
		}

		// Token: 0x0601841B RID: 99355 RVA: 0x0008BE3C File Offset: 0x0008AE3C
		public bool onhelp(global::mshtml.IHTMLEventObj A_1)
		{
			return this.m_onhelpDelegate != null && this.m_onhelpDelegate(A_1);
		}

		// Token: 0x0601841C RID: 99356 RVA: 0x0008BE6C File Offset: 0x0008AE6C
		internal HTMLMapEvents2_SinkHelper()
		{
			this.m_dwCookie = 0;
			this.m_onmousewheelDelegate = null;
			this.m_onresizeendDelegate = null;
			this.m_onresizestartDelegate = null;
			this.m_onmoveendDelegate = null;
			this.m_onmovestartDelegate = null;
			this.m_oncontrolselectDelegate = null;
			this.m_onmoveDelegate = null;
			this.m_onfocusoutDelegate = null;
			this.m_onfocusinDelegate = null;
			this.m_onbeforeactivateDelegate = null;
			this.m_onbeforedeactivateDelegate = null;
			this.m_ondeactivateDelegate = null;
			this.m_onactivateDelegate = null;
			this.m_onmouseleaveDelegate = null;
			this.m_onmouseenterDelegate = null;
			this.m_onpageDelegate = null;
			this.m_onlayoutcompleteDelegate = null;
			this.m_onreadystatechangeDelegate = null;
			this.m_oncellchangeDelegate = null;
			this.m_onrowsinsertedDelegate = null;
			this.m_onrowsdeleteDelegate = null;
			this.m_oncontextmenuDelegate = null;
			this.m_onpasteDelegate = null;
			this.m_onbeforepasteDelegate = null;
			this.m_oncopyDelegate = null;
			this.m_onbeforecopyDelegate = null;
			this.m_oncutDelegate = null;
			this.m_onbeforecutDelegate = null;
			this.m_ondropDelegate = null;
			this.m_ondragleaveDelegate = null;
			this.m_ondragoverDelegate = null;
			this.m_ondragenterDelegate = null;
			this.m_ondragendDelegate = null;
			this.m_ondragDelegate = null;
			this.m_onresizeDelegate = null;
			this.m_onblurDelegate = null;
			this.m_onfocusDelegate = null;
			this.m_onscrollDelegate = null;
			this.m_onpropertychangeDelegate = null;
			this.m_onlosecaptureDelegate = null;
			this.m_ondatasetcompleteDelegate = null;
			this.m_ondataavailableDelegate = null;
			this.m_ondatasetchangedDelegate = null;
			this.m_onrowenterDelegate = null;
			this.m_onrowexitDelegate = null;
			this.m_onerrorupdateDelegate = null;
			this.m_onafterupdateDelegate = null;
			this.m_onbeforeupdateDelegate = null;
			this.m_ondragstartDelegate = null;
			this.m_onfilterchangeDelegate = null;
			this.m_onselectstartDelegate = null;
			this.m_onmouseupDelegate = null;
			this.m_onmousedownDelegate = null;
			this.m_onmousemoveDelegate = null;
			this.m_onmouseoverDelegate = null;
			this.m_onmouseoutDelegate = null;
			this.m_onkeyupDelegate = null;
			this.m_onkeydownDelegate = null;
			this.m_onkeypressDelegate = null;
			this.m_ondblclickDelegate = null;
			this.m_onclickDelegate = null;
			this.m_onhelpDelegate = null;
		}

		// Token: 0x040009F5 RID: 2549
		public global::mshtml.HTMLMapEvents2_onmousewheelEventHandler m_onmousewheelDelegate;

		// Token: 0x040009F6 RID: 2550
		public global::mshtml.HTMLMapEvents2_onresizeendEventHandler m_onresizeendDelegate;

		// Token: 0x040009F7 RID: 2551
		public global::mshtml.HTMLMapEvents2_onresizestartEventHandler m_onresizestartDelegate;

		// Token: 0x040009F8 RID: 2552
		public global::mshtml.HTMLMapEvents2_onmoveendEventHandler m_onmoveendDelegate;

		// Token: 0x040009F9 RID: 2553
		public global::mshtml.HTMLMapEvents2_onmovestartEventHandler m_onmovestartDelegate;

		// Token: 0x040009FA RID: 2554
		public global::mshtml.HTMLMapEvents2_oncontrolselectEventHandler m_oncontrolselectDelegate;

		// Token: 0x040009FB RID: 2555
		public global::mshtml.HTMLMapEvents2_onmoveEventHandler m_onmoveDelegate;

		// Token: 0x040009FC RID: 2556
		public global::mshtml.HTMLMapEvents2_onfocusoutEventHandler m_onfocusoutDelegate;

		// Token: 0x040009FD RID: 2557
		public global::mshtml.HTMLMapEvents2_onfocusinEventHandler m_onfocusinDelegate;

		// Token: 0x040009FE RID: 2558
		public global::mshtml.HTMLMapEvents2_onbeforeactivateEventHandler m_onbeforeactivateDelegate;

		// Token: 0x040009FF RID: 2559
		public global::mshtml.HTMLMapEvents2_onbeforedeactivateEventHandler m_onbeforedeactivateDelegate;

		// Token: 0x04000A00 RID: 2560
		public global::mshtml.HTMLMapEvents2_ondeactivateEventHandler m_ondeactivateDelegate;

		// Token: 0x04000A01 RID: 2561
		public global::mshtml.HTMLMapEvents2_onactivateEventHandler m_onactivateDelegate;

		// Token: 0x04000A02 RID: 2562
		public global::mshtml.HTMLMapEvents2_onmouseleaveEventHandler m_onmouseleaveDelegate;

		// Token: 0x04000A03 RID: 2563
		public global::mshtml.HTMLMapEvents2_onmouseenterEventHandler m_onmouseenterDelegate;

		// Token: 0x04000A04 RID: 2564
		public global::mshtml.HTMLMapEvents2_onpageEventHandler m_onpageDelegate;

		// Token: 0x04000A05 RID: 2565
		public global::mshtml.HTMLMapEvents2_onlayoutcompleteEventHandler m_onlayoutcompleteDelegate;

		// Token: 0x04000A06 RID: 2566
		public global::mshtml.HTMLMapEvents2_onreadystatechangeEventHandler m_onreadystatechangeDelegate;

		// Token: 0x04000A07 RID: 2567
		public global::mshtml.HTMLMapEvents2_oncellchangeEventHandler m_oncellchangeDelegate;

		// Token: 0x04000A08 RID: 2568
		public global::mshtml.HTMLMapEvents2_onrowsinsertedEventHandler m_onrowsinsertedDelegate;

		// Token: 0x04000A09 RID: 2569
		public global::mshtml.HTMLMapEvents2_onrowsdeleteEventHandler m_onrowsdeleteDelegate;

		// Token: 0x04000A0A RID: 2570
		public global::mshtml.HTMLMapEvents2_oncontextmenuEventHandler m_oncontextmenuDelegate;

		// Token: 0x04000A0B RID: 2571
		public global::mshtml.HTMLMapEvents2_onpasteEventHandler m_onpasteDelegate;

		// Token: 0x04000A0C RID: 2572
		public global::mshtml.HTMLMapEvents2_onbeforepasteEventHandler m_onbeforepasteDelegate;

		// Token: 0x04000A0D RID: 2573
		public global::mshtml.HTMLMapEvents2_oncopyEventHandler m_oncopyDelegate;

		// Token: 0x04000A0E RID: 2574
		public global::mshtml.HTMLMapEvents2_onbeforecopyEventHandler m_onbeforecopyDelegate;

		// Token: 0x04000A0F RID: 2575
		public global::mshtml.HTMLMapEvents2_oncutEventHandler m_oncutDelegate;

		// Token: 0x04000A10 RID: 2576
		public global::mshtml.HTMLMapEvents2_onbeforecutEventHandler m_onbeforecutDelegate;

		// Token: 0x04000A11 RID: 2577
		public global::mshtml.HTMLMapEvents2_ondropEventHandler m_ondropDelegate;

		// Token: 0x04000A12 RID: 2578
		public global::mshtml.HTMLMapEvents2_ondragleaveEventHandler m_ondragleaveDelegate;

		// Token: 0x04000A13 RID: 2579
		public global::mshtml.HTMLMapEvents2_ondragoverEventHandler m_ondragoverDelegate;

		// Token: 0x04000A14 RID: 2580
		public global::mshtml.HTMLMapEvents2_ondragenterEventHandler m_ondragenterDelegate;

		// Token: 0x04000A15 RID: 2581
		public global::mshtml.HTMLMapEvents2_ondragendEventHandler m_ondragendDelegate;

		// Token: 0x04000A16 RID: 2582
		public global::mshtml.HTMLMapEvents2_ondragEventHandler m_ondragDelegate;

		// Token: 0x04000A17 RID: 2583
		public global::mshtml.HTMLMapEvents2_onresizeEventHandler m_onresizeDelegate;

		// Token: 0x04000A18 RID: 2584
		public global::mshtml.HTMLMapEvents2_onblurEventHandler m_onblurDelegate;

		// Token: 0x04000A19 RID: 2585
		public global::mshtml.HTMLMapEvents2_onfocusEventHandler m_onfocusDelegate;

		// Token: 0x04000A1A RID: 2586
		public global::mshtml.HTMLMapEvents2_onscrollEventHandler m_onscrollDelegate;

		// Token: 0x04000A1B RID: 2587
		public global::mshtml.HTMLMapEvents2_onpropertychangeEventHandler m_onpropertychangeDelegate;

		// Token: 0x04000A1C RID: 2588
		public global::mshtml.HTMLMapEvents2_onlosecaptureEventHandler m_onlosecaptureDelegate;

		// Token: 0x04000A1D RID: 2589
		public global::mshtml.HTMLMapEvents2_ondatasetcompleteEventHandler m_ondatasetcompleteDelegate;

		// Token: 0x04000A1E RID: 2590
		public global::mshtml.HTMLMapEvents2_ondataavailableEventHandler m_ondataavailableDelegate;

		// Token: 0x04000A1F RID: 2591
		public global::mshtml.HTMLMapEvents2_ondatasetchangedEventHandler m_ondatasetchangedDelegate;

		// Token: 0x04000A20 RID: 2592
		public global::mshtml.HTMLMapEvents2_onrowenterEventHandler m_onrowenterDelegate;

		// Token: 0x04000A21 RID: 2593
		public global::mshtml.HTMLMapEvents2_onrowexitEventHandler m_onrowexitDelegate;

		// Token: 0x04000A22 RID: 2594
		public global::mshtml.HTMLMapEvents2_onerrorupdateEventHandler m_onerrorupdateDelegate;

		// Token: 0x04000A23 RID: 2595
		public global::mshtml.HTMLMapEvents2_onafterupdateEventHandler m_onafterupdateDelegate;

		// Token: 0x04000A24 RID: 2596
		public global::mshtml.HTMLMapEvents2_onbeforeupdateEventHandler m_onbeforeupdateDelegate;

		// Token: 0x04000A25 RID: 2597
		public global::mshtml.HTMLMapEvents2_ondragstartEventHandler m_ondragstartDelegate;

		// Token: 0x04000A26 RID: 2598
		public global::mshtml.HTMLMapEvents2_onfilterchangeEventHandler m_onfilterchangeDelegate;

		// Token: 0x04000A27 RID: 2599
		public global::mshtml.HTMLMapEvents2_onselectstartEventHandler m_onselectstartDelegate;

		// Token: 0x04000A28 RID: 2600
		public global::mshtml.HTMLMapEvents2_onmouseupEventHandler m_onmouseupDelegate;

		// Token: 0x04000A29 RID: 2601
		public global::mshtml.HTMLMapEvents2_onmousedownEventHandler m_onmousedownDelegate;

		// Token: 0x04000A2A RID: 2602
		public global::mshtml.HTMLMapEvents2_onmousemoveEventHandler m_onmousemoveDelegate;

		// Token: 0x04000A2B RID: 2603
		public global::mshtml.HTMLMapEvents2_onmouseoverEventHandler m_onmouseoverDelegate;

		// Token: 0x04000A2C RID: 2604
		public global::mshtml.HTMLMapEvents2_onmouseoutEventHandler m_onmouseoutDelegate;

		// Token: 0x04000A2D RID: 2605
		public global::mshtml.HTMLMapEvents2_onkeyupEventHandler m_onkeyupDelegate;

		// Token: 0x04000A2E RID: 2606
		public global::mshtml.HTMLMapEvents2_onkeydownEventHandler m_onkeydownDelegate;

		// Token: 0x04000A2F RID: 2607
		public global::mshtml.HTMLMapEvents2_onkeypressEventHandler m_onkeypressDelegate;

		// Token: 0x04000A30 RID: 2608
		public global::mshtml.HTMLMapEvents2_ondblclickEventHandler m_ondblclickDelegate;

		// Token: 0x04000A31 RID: 2609
		public global::mshtml.HTMLMapEvents2_onclickEventHandler m_onclickDelegate;

		// Token: 0x04000A32 RID: 2610
		public global::mshtml.HTMLMapEvents2_onhelpEventHandler m_onhelpDelegate;

		// Token: 0x04000A33 RID: 2611
		public int m_dwCookie;
	}
}
