using System;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x02000DEA RID: 3562
	[global::System.Runtime.InteropServices.ClassInterface(global::System.Runtime.InteropServices.ClassInterfaceType.None)]
	internal sealed class HTMLAnchorEvents2_SinkHelper : global::mshtml.HTMLAnchorEvents2
	{
		// Token: 0x0601831F RID: 99103 RVA: 0x0008458C File Offset: 0x0008358C
		public bool onmousewheel(global::mshtml.IHTMLEventObj A_1)
		{
			return this.m_onmousewheelDelegate != null && this.m_onmousewheelDelegate(A_1);
		}

		// Token: 0x06018320 RID: 99104 RVA: 0x000845BC File Offset: 0x000835BC
		public void onresizeend(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_onresizeendDelegate != null)
			{
				this.m_onresizeendDelegate(A_1);
				return;
			}
		}

		// Token: 0x06018321 RID: 99105 RVA: 0x000845EC File Offset: 0x000835EC
		public bool onresizestart(global::mshtml.IHTMLEventObj A_1)
		{
			return this.m_onresizestartDelegate != null && this.m_onresizestartDelegate(A_1);
		}

		// Token: 0x06018322 RID: 99106 RVA: 0x0008461C File Offset: 0x0008361C
		public void onmoveend(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_onmoveendDelegate != null)
			{
				this.m_onmoveendDelegate(A_1);
				return;
			}
		}

		// Token: 0x06018323 RID: 99107 RVA: 0x0008464C File Offset: 0x0008364C
		public bool onmovestart(global::mshtml.IHTMLEventObj A_1)
		{
			return this.m_onmovestartDelegate != null && this.m_onmovestartDelegate(A_1);
		}

		// Token: 0x06018324 RID: 99108 RVA: 0x0008467C File Offset: 0x0008367C
		public bool oncontrolselect(global::mshtml.IHTMLEventObj A_1)
		{
			return this.m_oncontrolselectDelegate != null && this.m_oncontrolselectDelegate(A_1);
		}

		// Token: 0x06018325 RID: 99109 RVA: 0x000846AC File Offset: 0x000836AC
		public void onmove(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_onmoveDelegate != null)
			{
				this.m_onmoveDelegate(A_1);
				return;
			}
		}

		// Token: 0x06018326 RID: 99110 RVA: 0x000846DC File Offset: 0x000836DC
		public void onfocusout(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_onfocusoutDelegate != null)
			{
				this.m_onfocusoutDelegate(A_1);
				return;
			}
		}

		// Token: 0x06018327 RID: 99111 RVA: 0x0008470C File Offset: 0x0008370C
		public void onfocusin(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_onfocusinDelegate != null)
			{
				this.m_onfocusinDelegate(A_1);
				return;
			}
		}

		// Token: 0x06018328 RID: 99112 RVA: 0x0008473C File Offset: 0x0008373C
		public bool onbeforeactivate(global::mshtml.IHTMLEventObj A_1)
		{
			return this.m_onbeforeactivateDelegate != null && this.m_onbeforeactivateDelegate(A_1);
		}

		// Token: 0x06018329 RID: 99113 RVA: 0x0008476C File Offset: 0x0008376C
		public bool onbeforedeactivate(global::mshtml.IHTMLEventObj A_1)
		{
			return this.m_onbeforedeactivateDelegate != null && this.m_onbeforedeactivateDelegate(A_1);
		}

		// Token: 0x0601832A RID: 99114 RVA: 0x0008479C File Offset: 0x0008379C
		public void ondeactivate(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_ondeactivateDelegate != null)
			{
				this.m_ondeactivateDelegate(A_1);
				return;
			}
		}

		// Token: 0x0601832B RID: 99115 RVA: 0x000847CC File Offset: 0x000837CC
		public void onactivate(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_onactivateDelegate != null)
			{
				this.m_onactivateDelegate(A_1);
				return;
			}
		}

		// Token: 0x0601832C RID: 99116 RVA: 0x000847FC File Offset: 0x000837FC
		public void onmouseleave(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_onmouseleaveDelegate != null)
			{
				this.m_onmouseleaveDelegate(A_1);
				return;
			}
		}

		// Token: 0x0601832D RID: 99117 RVA: 0x0008482C File Offset: 0x0008382C
		public void onmouseenter(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_onmouseenterDelegate != null)
			{
				this.m_onmouseenterDelegate(A_1);
				return;
			}
		}

		// Token: 0x0601832E RID: 99118 RVA: 0x0008485C File Offset: 0x0008385C
		public void onpage(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_onpageDelegate != null)
			{
				this.m_onpageDelegate(A_1);
				return;
			}
		}

		// Token: 0x0601832F RID: 99119 RVA: 0x0008488C File Offset: 0x0008388C
		public void onlayoutcomplete(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_onlayoutcompleteDelegate != null)
			{
				this.m_onlayoutcompleteDelegate(A_1);
				return;
			}
		}

		// Token: 0x06018330 RID: 99120 RVA: 0x000848BC File Offset: 0x000838BC
		public void onreadystatechange(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_onreadystatechangeDelegate != null)
			{
				this.m_onreadystatechangeDelegate(A_1);
				return;
			}
		}

		// Token: 0x06018331 RID: 99121 RVA: 0x000848EC File Offset: 0x000838EC
		public void oncellchange(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_oncellchangeDelegate != null)
			{
				this.m_oncellchangeDelegate(A_1);
				return;
			}
		}

		// Token: 0x06018332 RID: 99122 RVA: 0x0008491C File Offset: 0x0008391C
		public void onrowsinserted(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_onrowsinsertedDelegate != null)
			{
				this.m_onrowsinsertedDelegate(A_1);
				return;
			}
		}

		// Token: 0x06018333 RID: 99123 RVA: 0x0008494C File Offset: 0x0008394C
		public void onrowsdelete(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_onrowsdeleteDelegate != null)
			{
				this.m_onrowsdeleteDelegate(A_1);
				return;
			}
		}

		// Token: 0x06018334 RID: 99124 RVA: 0x0008497C File Offset: 0x0008397C
		public bool oncontextmenu(global::mshtml.IHTMLEventObj A_1)
		{
			return this.m_oncontextmenuDelegate != null && this.m_oncontextmenuDelegate(A_1);
		}

		// Token: 0x06018335 RID: 99125 RVA: 0x000849AC File Offset: 0x000839AC
		public bool onpaste(global::mshtml.IHTMLEventObj A_1)
		{
			return this.m_onpasteDelegate != null && this.m_onpasteDelegate(A_1);
		}

		// Token: 0x06018336 RID: 99126 RVA: 0x000849DC File Offset: 0x000839DC
		public bool onbeforepaste(global::mshtml.IHTMLEventObj A_1)
		{
			return this.m_onbeforepasteDelegate != null && this.m_onbeforepasteDelegate(A_1);
		}

		// Token: 0x06018337 RID: 99127 RVA: 0x00084A0C File Offset: 0x00083A0C
		public bool oncopy(global::mshtml.IHTMLEventObj A_1)
		{
			return this.m_oncopyDelegate != null && this.m_oncopyDelegate(A_1);
		}

		// Token: 0x06018338 RID: 99128 RVA: 0x00084A3C File Offset: 0x00083A3C
		public bool onbeforecopy(global::mshtml.IHTMLEventObj A_1)
		{
			return this.m_onbeforecopyDelegate != null && this.m_onbeforecopyDelegate(A_1);
		}

		// Token: 0x06018339 RID: 99129 RVA: 0x00084A6C File Offset: 0x00083A6C
		public bool oncut(global::mshtml.IHTMLEventObj A_1)
		{
			return this.m_oncutDelegate != null && this.m_oncutDelegate(A_1);
		}

		// Token: 0x0601833A RID: 99130 RVA: 0x00084A9C File Offset: 0x00083A9C
		public bool onbeforecut(global::mshtml.IHTMLEventObj A_1)
		{
			return this.m_onbeforecutDelegate != null && this.m_onbeforecutDelegate(A_1);
		}

		// Token: 0x0601833B RID: 99131 RVA: 0x00084ACC File Offset: 0x00083ACC
		public bool ondrop(global::mshtml.IHTMLEventObj A_1)
		{
			return this.m_ondropDelegate != null && this.m_ondropDelegate(A_1);
		}

		// Token: 0x0601833C RID: 99132 RVA: 0x00084AFC File Offset: 0x00083AFC
		public void ondragleave(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_ondragleaveDelegate != null)
			{
				this.m_ondragleaveDelegate(A_1);
				return;
			}
		}

		// Token: 0x0601833D RID: 99133 RVA: 0x00084B2C File Offset: 0x00083B2C
		public bool ondragover(global::mshtml.IHTMLEventObj A_1)
		{
			return this.m_ondragoverDelegate != null && this.m_ondragoverDelegate(A_1);
		}

		// Token: 0x0601833E RID: 99134 RVA: 0x00084B5C File Offset: 0x00083B5C
		public bool ondragenter(global::mshtml.IHTMLEventObj A_1)
		{
			return this.m_ondragenterDelegate != null && this.m_ondragenterDelegate(A_1);
		}

		// Token: 0x0601833F RID: 99135 RVA: 0x00084B8C File Offset: 0x00083B8C
		public void ondragend(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_ondragendDelegate != null)
			{
				this.m_ondragendDelegate(A_1);
				return;
			}
		}

		// Token: 0x06018340 RID: 99136 RVA: 0x00084BBC File Offset: 0x00083BBC
		public bool ondrag(global::mshtml.IHTMLEventObj A_1)
		{
			return this.m_ondragDelegate != null && this.m_ondragDelegate(A_1);
		}

		// Token: 0x06018341 RID: 99137 RVA: 0x00084BEC File Offset: 0x00083BEC
		public void onresize(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_onresizeDelegate != null)
			{
				this.m_onresizeDelegate(A_1);
				return;
			}
		}

		// Token: 0x06018342 RID: 99138 RVA: 0x00084C1C File Offset: 0x00083C1C
		public void onblur(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_onblurDelegate != null)
			{
				this.m_onblurDelegate(A_1);
				return;
			}
		}

		// Token: 0x06018343 RID: 99139 RVA: 0x00084C4C File Offset: 0x00083C4C
		public void onfocus(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_onfocusDelegate != null)
			{
				this.m_onfocusDelegate(A_1);
				return;
			}
		}

		// Token: 0x06018344 RID: 99140 RVA: 0x00084C7C File Offset: 0x00083C7C
		public void onscroll(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_onscrollDelegate != null)
			{
				this.m_onscrollDelegate(A_1);
				return;
			}
		}

		// Token: 0x06018345 RID: 99141 RVA: 0x00084CAC File Offset: 0x00083CAC
		public void onpropertychange(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_onpropertychangeDelegate != null)
			{
				this.m_onpropertychangeDelegate(A_1);
				return;
			}
		}

		// Token: 0x06018346 RID: 99142 RVA: 0x00084CDC File Offset: 0x00083CDC
		public void onlosecapture(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_onlosecaptureDelegate != null)
			{
				this.m_onlosecaptureDelegate(A_1);
				return;
			}
		}

		// Token: 0x06018347 RID: 99143 RVA: 0x00084D0C File Offset: 0x00083D0C
		public void ondatasetcomplete(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_ondatasetcompleteDelegate != null)
			{
				this.m_ondatasetcompleteDelegate(A_1);
				return;
			}
		}

		// Token: 0x06018348 RID: 99144 RVA: 0x00084D3C File Offset: 0x00083D3C
		public void ondataavailable(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_ondataavailableDelegate != null)
			{
				this.m_ondataavailableDelegate(A_1);
				return;
			}
		}

		// Token: 0x06018349 RID: 99145 RVA: 0x00084D6C File Offset: 0x00083D6C
		public void ondatasetchanged(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_ondatasetchangedDelegate != null)
			{
				this.m_ondatasetchangedDelegate(A_1);
				return;
			}
		}

		// Token: 0x0601834A RID: 99146 RVA: 0x00084D9C File Offset: 0x00083D9C
		public void onrowenter(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_onrowenterDelegate != null)
			{
				this.m_onrowenterDelegate(A_1);
				return;
			}
		}

		// Token: 0x0601834B RID: 99147 RVA: 0x00084DCC File Offset: 0x00083DCC
		public bool onrowexit(global::mshtml.IHTMLEventObj A_1)
		{
			return this.m_onrowexitDelegate != null && this.m_onrowexitDelegate(A_1);
		}

		// Token: 0x0601834C RID: 99148 RVA: 0x00084DFC File Offset: 0x00083DFC
		public bool onerrorupdate(global::mshtml.IHTMLEventObj A_1)
		{
			return this.m_onerrorupdateDelegate != null && this.m_onerrorupdateDelegate(A_1);
		}

		// Token: 0x0601834D RID: 99149 RVA: 0x00084E2C File Offset: 0x00083E2C
		public void onafterupdate(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_onafterupdateDelegate != null)
			{
				this.m_onafterupdateDelegate(A_1);
				return;
			}
		}

		// Token: 0x0601834E RID: 99150 RVA: 0x00084E5C File Offset: 0x00083E5C
		public bool onbeforeupdate(global::mshtml.IHTMLEventObj A_1)
		{
			return this.m_onbeforeupdateDelegate != null && this.m_onbeforeupdateDelegate(A_1);
		}

		// Token: 0x0601834F RID: 99151 RVA: 0x00084E8C File Offset: 0x00083E8C
		public bool ondragstart(global::mshtml.IHTMLEventObj A_1)
		{
			return this.m_ondragstartDelegate != null && this.m_ondragstartDelegate(A_1);
		}

		// Token: 0x06018350 RID: 99152 RVA: 0x00084EBC File Offset: 0x00083EBC
		public void onfilterchange(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_onfilterchangeDelegate != null)
			{
				this.m_onfilterchangeDelegate(A_1);
				return;
			}
		}

		// Token: 0x06018351 RID: 99153 RVA: 0x00084EEC File Offset: 0x00083EEC
		public bool onselectstart(global::mshtml.IHTMLEventObj A_1)
		{
			return this.m_onselectstartDelegate != null && this.m_onselectstartDelegate(A_1);
		}

		// Token: 0x06018352 RID: 99154 RVA: 0x00084F1C File Offset: 0x00083F1C
		public void onmouseup(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_onmouseupDelegate != null)
			{
				this.m_onmouseupDelegate(A_1);
				return;
			}
		}

		// Token: 0x06018353 RID: 99155 RVA: 0x00084F4C File Offset: 0x00083F4C
		public void onmousedown(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_onmousedownDelegate != null)
			{
				this.m_onmousedownDelegate(A_1);
				return;
			}
		}

		// Token: 0x06018354 RID: 99156 RVA: 0x00084F7C File Offset: 0x00083F7C
		public void onmousemove(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_onmousemoveDelegate != null)
			{
				this.m_onmousemoveDelegate(A_1);
				return;
			}
		}

		// Token: 0x06018355 RID: 99157 RVA: 0x00084FAC File Offset: 0x00083FAC
		public void onmouseover(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_onmouseoverDelegate != null)
			{
				this.m_onmouseoverDelegate(A_1);
				return;
			}
		}

		// Token: 0x06018356 RID: 99158 RVA: 0x00084FDC File Offset: 0x00083FDC
		public void onmouseout(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_onmouseoutDelegate != null)
			{
				this.m_onmouseoutDelegate(A_1);
				return;
			}
		}

		// Token: 0x06018357 RID: 99159 RVA: 0x0008500C File Offset: 0x0008400C
		public void onkeyup(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_onkeyupDelegate != null)
			{
				this.m_onkeyupDelegate(A_1);
				return;
			}
		}

		// Token: 0x06018358 RID: 99160 RVA: 0x0008503C File Offset: 0x0008403C
		public void onkeydown(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_onkeydownDelegate != null)
			{
				this.m_onkeydownDelegate(A_1);
				return;
			}
		}

		// Token: 0x06018359 RID: 99161 RVA: 0x0008506C File Offset: 0x0008406C
		public bool onkeypress(global::mshtml.IHTMLEventObj A_1)
		{
			return this.m_onkeypressDelegate != null && this.m_onkeypressDelegate(A_1);
		}

		// Token: 0x0601835A RID: 99162 RVA: 0x0008509C File Offset: 0x0008409C
		public bool ondblclick(global::mshtml.IHTMLEventObj A_1)
		{
			return this.m_ondblclickDelegate != null && this.m_ondblclickDelegate(A_1);
		}

		// Token: 0x0601835B RID: 99163 RVA: 0x000850CC File Offset: 0x000840CC
		public bool onclick(global::mshtml.IHTMLEventObj A_1)
		{
			return this.m_onclickDelegate != null && this.m_onclickDelegate(A_1);
		}

		// Token: 0x0601835C RID: 99164 RVA: 0x000850FC File Offset: 0x000840FC
		public bool onhelp(global::mshtml.IHTMLEventObj A_1)
		{
			return this.m_onhelpDelegate != null && this.m_onhelpDelegate(A_1);
		}

		// Token: 0x0601835D RID: 99165 RVA: 0x0008512C File Offset: 0x0008412C
		internal HTMLAnchorEvents2_SinkHelper()
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

		// Token: 0x040009B3 RID: 2483
		public global::mshtml.HTMLAnchorEvents2_onmousewheelEventHandler m_onmousewheelDelegate;

		// Token: 0x040009B4 RID: 2484
		public global::mshtml.HTMLAnchorEvents2_onresizeendEventHandler m_onresizeendDelegate;

		// Token: 0x040009B5 RID: 2485
		public global::mshtml.HTMLAnchorEvents2_onresizestartEventHandler m_onresizestartDelegate;

		// Token: 0x040009B6 RID: 2486
		public global::mshtml.HTMLAnchorEvents2_onmoveendEventHandler m_onmoveendDelegate;

		// Token: 0x040009B7 RID: 2487
		public global::mshtml.HTMLAnchorEvents2_onmovestartEventHandler m_onmovestartDelegate;

		// Token: 0x040009B8 RID: 2488
		public global::mshtml.HTMLAnchorEvents2_oncontrolselectEventHandler m_oncontrolselectDelegate;

		// Token: 0x040009B9 RID: 2489
		public global::mshtml.HTMLAnchorEvents2_onmoveEventHandler m_onmoveDelegate;

		// Token: 0x040009BA RID: 2490
		public global::mshtml.HTMLAnchorEvents2_onfocusoutEventHandler m_onfocusoutDelegate;

		// Token: 0x040009BB RID: 2491
		public global::mshtml.HTMLAnchorEvents2_onfocusinEventHandler m_onfocusinDelegate;

		// Token: 0x040009BC RID: 2492
		public global::mshtml.HTMLAnchorEvents2_onbeforeactivateEventHandler m_onbeforeactivateDelegate;

		// Token: 0x040009BD RID: 2493
		public global::mshtml.HTMLAnchorEvents2_onbeforedeactivateEventHandler m_onbeforedeactivateDelegate;

		// Token: 0x040009BE RID: 2494
		public global::mshtml.HTMLAnchorEvents2_ondeactivateEventHandler m_ondeactivateDelegate;

		// Token: 0x040009BF RID: 2495
		public global::mshtml.HTMLAnchorEvents2_onactivateEventHandler m_onactivateDelegate;

		// Token: 0x040009C0 RID: 2496
		public global::mshtml.HTMLAnchorEvents2_onmouseleaveEventHandler m_onmouseleaveDelegate;

		// Token: 0x040009C1 RID: 2497
		public global::mshtml.HTMLAnchorEvents2_onmouseenterEventHandler m_onmouseenterDelegate;

		// Token: 0x040009C2 RID: 2498
		public global::mshtml.HTMLAnchorEvents2_onpageEventHandler m_onpageDelegate;

		// Token: 0x040009C3 RID: 2499
		public global::mshtml.HTMLAnchorEvents2_onlayoutcompleteEventHandler m_onlayoutcompleteDelegate;

		// Token: 0x040009C4 RID: 2500
		public global::mshtml.HTMLAnchorEvents2_onreadystatechangeEventHandler m_onreadystatechangeDelegate;

		// Token: 0x040009C5 RID: 2501
		public global::mshtml.HTMLAnchorEvents2_oncellchangeEventHandler m_oncellchangeDelegate;

		// Token: 0x040009C6 RID: 2502
		public global::mshtml.HTMLAnchorEvents2_onrowsinsertedEventHandler m_onrowsinsertedDelegate;

		// Token: 0x040009C7 RID: 2503
		public global::mshtml.HTMLAnchorEvents2_onrowsdeleteEventHandler m_onrowsdeleteDelegate;

		// Token: 0x040009C8 RID: 2504
		public global::mshtml.HTMLAnchorEvents2_oncontextmenuEventHandler m_oncontextmenuDelegate;

		// Token: 0x040009C9 RID: 2505
		public global::mshtml.HTMLAnchorEvents2_onpasteEventHandler m_onpasteDelegate;

		// Token: 0x040009CA RID: 2506
		public global::mshtml.HTMLAnchorEvents2_onbeforepasteEventHandler m_onbeforepasteDelegate;

		// Token: 0x040009CB RID: 2507
		public global::mshtml.HTMLAnchorEvents2_oncopyEventHandler m_oncopyDelegate;

		// Token: 0x040009CC RID: 2508
		public global::mshtml.HTMLAnchorEvents2_onbeforecopyEventHandler m_onbeforecopyDelegate;

		// Token: 0x040009CD RID: 2509
		public global::mshtml.HTMLAnchorEvents2_oncutEventHandler m_oncutDelegate;

		// Token: 0x040009CE RID: 2510
		public global::mshtml.HTMLAnchorEvents2_onbeforecutEventHandler m_onbeforecutDelegate;

		// Token: 0x040009CF RID: 2511
		public global::mshtml.HTMLAnchorEvents2_ondropEventHandler m_ondropDelegate;

		// Token: 0x040009D0 RID: 2512
		public global::mshtml.HTMLAnchorEvents2_ondragleaveEventHandler m_ondragleaveDelegate;

		// Token: 0x040009D1 RID: 2513
		public global::mshtml.HTMLAnchorEvents2_ondragoverEventHandler m_ondragoverDelegate;

		// Token: 0x040009D2 RID: 2514
		public global::mshtml.HTMLAnchorEvents2_ondragenterEventHandler m_ondragenterDelegate;

		// Token: 0x040009D3 RID: 2515
		public global::mshtml.HTMLAnchorEvents2_ondragendEventHandler m_ondragendDelegate;

		// Token: 0x040009D4 RID: 2516
		public global::mshtml.HTMLAnchorEvents2_ondragEventHandler m_ondragDelegate;

		// Token: 0x040009D5 RID: 2517
		public global::mshtml.HTMLAnchorEvents2_onresizeEventHandler m_onresizeDelegate;

		// Token: 0x040009D6 RID: 2518
		public global::mshtml.HTMLAnchorEvents2_onblurEventHandler m_onblurDelegate;

		// Token: 0x040009D7 RID: 2519
		public global::mshtml.HTMLAnchorEvents2_onfocusEventHandler m_onfocusDelegate;

		// Token: 0x040009D8 RID: 2520
		public global::mshtml.HTMLAnchorEvents2_onscrollEventHandler m_onscrollDelegate;

		// Token: 0x040009D9 RID: 2521
		public global::mshtml.HTMLAnchorEvents2_onpropertychangeEventHandler m_onpropertychangeDelegate;

		// Token: 0x040009DA RID: 2522
		public global::mshtml.HTMLAnchorEvents2_onlosecaptureEventHandler m_onlosecaptureDelegate;

		// Token: 0x040009DB RID: 2523
		public global::mshtml.HTMLAnchorEvents2_ondatasetcompleteEventHandler m_ondatasetcompleteDelegate;

		// Token: 0x040009DC RID: 2524
		public global::mshtml.HTMLAnchorEvents2_ondataavailableEventHandler m_ondataavailableDelegate;

		// Token: 0x040009DD RID: 2525
		public global::mshtml.HTMLAnchorEvents2_ondatasetchangedEventHandler m_ondatasetchangedDelegate;

		// Token: 0x040009DE RID: 2526
		public global::mshtml.HTMLAnchorEvents2_onrowenterEventHandler m_onrowenterDelegate;

		// Token: 0x040009DF RID: 2527
		public global::mshtml.HTMLAnchorEvents2_onrowexitEventHandler m_onrowexitDelegate;

		// Token: 0x040009E0 RID: 2528
		public global::mshtml.HTMLAnchorEvents2_onerrorupdateEventHandler m_onerrorupdateDelegate;

		// Token: 0x040009E1 RID: 2529
		public global::mshtml.HTMLAnchorEvents2_onafterupdateEventHandler m_onafterupdateDelegate;

		// Token: 0x040009E2 RID: 2530
		public global::mshtml.HTMLAnchorEvents2_onbeforeupdateEventHandler m_onbeforeupdateDelegate;

		// Token: 0x040009E3 RID: 2531
		public global::mshtml.HTMLAnchorEvents2_ondragstartEventHandler m_ondragstartDelegate;

		// Token: 0x040009E4 RID: 2532
		public global::mshtml.HTMLAnchorEvents2_onfilterchangeEventHandler m_onfilterchangeDelegate;

		// Token: 0x040009E5 RID: 2533
		public global::mshtml.HTMLAnchorEvents2_onselectstartEventHandler m_onselectstartDelegate;

		// Token: 0x040009E6 RID: 2534
		public global::mshtml.HTMLAnchorEvents2_onmouseupEventHandler m_onmouseupDelegate;

		// Token: 0x040009E7 RID: 2535
		public global::mshtml.HTMLAnchorEvents2_onmousedownEventHandler m_onmousedownDelegate;

		// Token: 0x040009E8 RID: 2536
		public global::mshtml.HTMLAnchorEvents2_onmousemoveEventHandler m_onmousemoveDelegate;

		// Token: 0x040009E9 RID: 2537
		public global::mshtml.HTMLAnchorEvents2_onmouseoverEventHandler m_onmouseoverDelegate;

		// Token: 0x040009EA RID: 2538
		public global::mshtml.HTMLAnchorEvents2_onmouseoutEventHandler m_onmouseoutDelegate;

		// Token: 0x040009EB RID: 2539
		public global::mshtml.HTMLAnchorEvents2_onkeyupEventHandler m_onkeyupDelegate;

		// Token: 0x040009EC RID: 2540
		public global::mshtml.HTMLAnchorEvents2_onkeydownEventHandler m_onkeydownDelegate;

		// Token: 0x040009ED RID: 2541
		public global::mshtml.HTMLAnchorEvents2_onkeypressEventHandler m_onkeypressDelegate;

		// Token: 0x040009EE RID: 2542
		public global::mshtml.HTMLAnchorEvents2_ondblclickEventHandler m_ondblclickDelegate;

		// Token: 0x040009EF RID: 2543
		public global::mshtml.HTMLAnchorEvents2_onclickEventHandler m_onclickDelegate;

		// Token: 0x040009F0 RID: 2544
		public global::mshtml.HTMLAnchorEvents2_onhelpEventHandler m_onhelpDelegate;

		// Token: 0x040009F1 RID: 2545
		public int m_dwCookie;
	}
}
