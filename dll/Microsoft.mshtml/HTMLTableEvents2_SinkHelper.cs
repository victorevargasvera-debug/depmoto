using System;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x02000DF0 RID: 3568
	[global::System.Runtime.InteropServices.ClassInterface(global::System.Runtime.InteropServices.ClassInterfaceType.None)]
	internal sealed class HTMLTableEvents2_SinkHelper : global::mshtml.HTMLTableEvents2
	{
		// Token: 0x0601856E RID: 99694 RVA: 0x00099698 File Offset: 0x00098698
		public bool onmousewheel(global::mshtml.IHTMLEventObj A_1)
		{
			return this.m_onmousewheelDelegate != null && this.m_onmousewheelDelegate(A_1);
		}

		// Token: 0x0601856F RID: 99695 RVA: 0x000996C8 File Offset: 0x000986C8
		public void onresizeend(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_onresizeendDelegate != null)
			{
				this.m_onresizeendDelegate(A_1);
				return;
			}
		}

		// Token: 0x06018570 RID: 99696 RVA: 0x000996F8 File Offset: 0x000986F8
		public bool onresizestart(global::mshtml.IHTMLEventObj A_1)
		{
			return this.m_onresizestartDelegate != null && this.m_onresizestartDelegate(A_1);
		}

		// Token: 0x06018571 RID: 99697 RVA: 0x00099728 File Offset: 0x00098728
		public void onmoveend(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_onmoveendDelegate != null)
			{
				this.m_onmoveendDelegate(A_1);
				return;
			}
		}

		// Token: 0x06018572 RID: 99698 RVA: 0x00099758 File Offset: 0x00098758
		public bool onmovestart(global::mshtml.IHTMLEventObj A_1)
		{
			return this.m_onmovestartDelegate != null && this.m_onmovestartDelegate(A_1);
		}

		// Token: 0x06018573 RID: 99699 RVA: 0x00099788 File Offset: 0x00098788
		public bool oncontrolselect(global::mshtml.IHTMLEventObj A_1)
		{
			return this.m_oncontrolselectDelegate != null && this.m_oncontrolselectDelegate(A_1);
		}

		// Token: 0x06018574 RID: 99700 RVA: 0x000997B8 File Offset: 0x000987B8
		public void onmove(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_onmoveDelegate != null)
			{
				this.m_onmoveDelegate(A_1);
				return;
			}
		}

		// Token: 0x06018575 RID: 99701 RVA: 0x000997E8 File Offset: 0x000987E8
		public void onfocusout(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_onfocusoutDelegate != null)
			{
				this.m_onfocusoutDelegate(A_1);
				return;
			}
		}

		// Token: 0x06018576 RID: 99702 RVA: 0x00099818 File Offset: 0x00098818
		public void onfocusin(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_onfocusinDelegate != null)
			{
				this.m_onfocusinDelegate(A_1);
				return;
			}
		}

		// Token: 0x06018577 RID: 99703 RVA: 0x00099848 File Offset: 0x00098848
		public bool onbeforeactivate(global::mshtml.IHTMLEventObj A_1)
		{
			return this.m_onbeforeactivateDelegate != null && this.m_onbeforeactivateDelegate(A_1);
		}

		// Token: 0x06018578 RID: 99704 RVA: 0x00099878 File Offset: 0x00098878
		public bool onbeforedeactivate(global::mshtml.IHTMLEventObj A_1)
		{
			return this.m_onbeforedeactivateDelegate != null && this.m_onbeforedeactivateDelegate(A_1);
		}

		// Token: 0x06018579 RID: 99705 RVA: 0x000998A8 File Offset: 0x000988A8
		public void ondeactivate(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_ondeactivateDelegate != null)
			{
				this.m_ondeactivateDelegate(A_1);
				return;
			}
		}

		// Token: 0x0601857A RID: 99706 RVA: 0x000998D8 File Offset: 0x000988D8
		public void onactivate(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_onactivateDelegate != null)
			{
				this.m_onactivateDelegate(A_1);
				return;
			}
		}

		// Token: 0x0601857B RID: 99707 RVA: 0x00099908 File Offset: 0x00098908
		public void onmouseleave(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_onmouseleaveDelegate != null)
			{
				this.m_onmouseleaveDelegate(A_1);
				return;
			}
		}

		// Token: 0x0601857C RID: 99708 RVA: 0x00099938 File Offset: 0x00098938
		public void onmouseenter(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_onmouseenterDelegate != null)
			{
				this.m_onmouseenterDelegate(A_1);
				return;
			}
		}

		// Token: 0x0601857D RID: 99709 RVA: 0x00099968 File Offset: 0x00098968
		public void onpage(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_onpageDelegate != null)
			{
				this.m_onpageDelegate(A_1);
				return;
			}
		}

		// Token: 0x0601857E RID: 99710 RVA: 0x00099998 File Offset: 0x00098998
		public void onlayoutcomplete(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_onlayoutcompleteDelegate != null)
			{
				this.m_onlayoutcompleteDelegate(A_1);
				return;
			}
		}

		// Token: 0x0601857F RID: 99711 RVA: 0x000999C8 File Offset: 0x000989C8
		public void onreadystatechange(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_onreadystatechangeDelegate != null)
			{
				this.m_onreadystatechangeDelegate(A_1);
				return;
			}
		}

		// Token: 0x06018580 RID: 99712 RVA: 0x000999F8 File Offset: 0x000989F8
		public void oncellchange(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_oncellchangeDelegate != null)
			{
				this.m_oncellchangeDelegate(A_1);
				return;
			}
		}

		// Token: 0x06018581 RID: 99713 RVA: 0x00099A28 File Offset: 0x00098A28
		public void onrowsinserted(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_onrowsinsertedDelegate != null)
			{
				this.m_onrowsinsertedDelegate(A_1);
				return;
			}
		}

		// Token: 0x06018582 RID: 99714 RVA: 0x00099A58 File Offset: 0x00098A58
		public void onrowsdelete(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_onrowsdeleteDelegate != null)
			{
				this.m_onrowsdeleteDelegate(A_1);
				return;
			}
		}

		// Token: 0x06018583 RID: 99715 RVA: 0x00099A88 File Offset: 0x00098A88
		public bool oncontextmenu(global::mshtml.IHTMLEventObj A_1)
		{
			return this.m_oncontextmenuDelegate != null && this.m_oncontextmenuDelegate(A_1);
		}

		// Token: 0x06018584 RID: 99716 RVA: 0x00099AB8 File Offset: 0x00098AB8
		public bool onpaste(global::mshtml.IHTMLEventObj A_1)
		{
			return this.m_onpasteDelegate != null && this.m_onpasteDelegate(A_1);
		}

		// Token: 0x06018585 RID: 99717 RVA: 0x00099AE8 File Offset: 0x00098AE8
		public bool onbeforepaste(global::mshtml.IHTMLEventObj A_1)
		{
			return this.m_onbeforepasteDelegate != null && this.m_onbeforepasteDelegate(A_1);
		}

		// Token: 0x06018586 RID: 99718 RVA: 0x00099B18 File Offset: 0x00098B18
		public bool oncopy(global::mshtml.IHTMLEventObj A_1)
		{
			return this.m_oncopyDelegate != null && this.m_oncopyDelegate(A_1);
		}

		// Token: 0x06018587 RID: 99719 RVA: 0x00099B48 File Offset: 0x00098B48
		public bool onbeforecopy(global::mshtml.IHTMLEventObj A_1)
		{
			return this.m_onbeforecopyDelegate != null && this.m_onbeforecopyDelegate(A_1);
		}

		// Token: 0x06018588 RID: 99720 RVA: 0x00099B78 File Offset: 0x00098B78
		public bool oncut(global::mshtml.IHTMLEventObj A_1)
		{
			return this.m_oncutDelegate != null && this.m_oncutDelegate(A_1);
		}

		// Token: 0x06018589 RID: 99721 RVA: 0x00099BA8 File Offset: 0x00098BA8
		public bool onbeforecut(global::mshtml.IHTMLEventObj A_1)
		{
			return this.m_onbeforecutDelegate != null && this.m_onbeforecutDelegate(A_1);
		}

		// Token: 0x0601858A RID: 99722 RVA: 0x00099BD8 File Offset: 0x00098BD8
		public bool ondrop(global::mshtml.IHTMLEventObj A_1)
		{
			return this.m_ondropDelegate != null && this.m_ondropDelegate(A_1);
		}

		// Token: 0x0601858B RID: 99723 RVA: 0x00099C08 File Offset: 0x00098C08
		public void ondragleave(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_ondragleaveDelegate != null)
			{
				this.m_ondragleaveDelegate(A_1);
				return;
			}
		}

		// Token: 0x0601858C RID: 99724 RVA: 0x00099C38 File Offset: 0x00098C38
		public bool ondragover(global::mshtml.IHTMLEventObj A_1)
		{
			return this.m_ondragoverDelegate != null && this.m_ondragoverDelegate(A_1);
		}

		// Token: 0x0601858D RID: 99725 RVA: 0x00099C68 File Offset: 0x00098C68
		public bool ondragenter(global::mshtml.IHTMLEventObj A_1)
		{
			return this.m_ondragenterDelegate != null && this.m_ondragenterDelegate(A_1);
		}

		// Token: 0x0601858E RID: 99726 RVA: 0x00099C98 File Offset: 0x00098C98
		public void ondragend(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_ondragendDelegate != null)
			{
				this.m_ondragendDelegate(A_1);
				return;
			}
		}

		// Token: 0x0601858F RID: 99727 RVA: 0x00099CC8 File Offset: 0x00098CC8
		public bool ondrag(global::mshtml.IHTMLEventObj A_1)
		{
			return this.m_ondragDelegate != null && this.m_ondragDelegate(A_1);
		}

		// Token: 0x06018590 RID: 99728 RVA: 0x00099CF8 File Offset: 0x00098CF8
		public void onresize(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_onresizeDelegate != null)
			{
				this.m_onresizeDelegate(A_1);
				return;
			}
		}

		// Token: 0x06018591 RID: 99729 RVA: 0x00099D28 File Offset: 0x00098D28
		public void onblur(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_onblurDelegate != null)
			{
				this.m_onblurDelegate(A_1);
				return;
			}
		}

		// Token: 0x06018592 RID: 99730 RVA: 0x00099D58 File Offset: 0x00098D58
		public void onfocus(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_onfocusDelegate != null)
			{
				this.m_onfocusDelegate(A_1);
				return;
			}
		}

		// Token: 0x06018593 RID: 99731 RVA: 0x00099D88 File Offset: 0x00098D88
		public void onscroll(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_onscrollDelegate != null)
			{
				this.m_onscrollDelegate(A_1);
				return;
			}
		}

		// Token: 0x06018594 RID: 99732 RVA: 0x00099DB8 File Offset: 0x00098DB8
		public void onpropertychange(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_onpropertychangeDelegate != null)
			{
				this.m_onpropertychangeDelegate(A_1);
				return;
			}
		}

		// Token: 0x06018595 RID: 99733 RVA: 0x00099DE8 File Offset: 0x00098DE8
		public void onlosecapture(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_onlosecaptureDelegate != null)
			{
				this.m_onlosecaptureDelegate(A_1);
				return;
			}
		}

		// Token: 0x06018596 RID: 99734 RVA: 0x00099E18 File Offset: 0x00098E18
		public void ondatasetcomplete(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_ondatasetcompleteDelegate != null)
			{
				this.m_ondatasetcompleteDelegate(A_1);
				return;
			}
		}

		// Token: 0x06018597 RID: 99735 RVA: 0x00099E48 File Offset: 0x00098E48
		public void ondataavailable(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_ondataavailableDelegate != null)
			{
				this.m_ondataavailableDelegate(A_1);
				return;
			}
		}

		// Token: 0x06018598 RID: 99736 RVA: 0x00099E78 File Offset: 0x00098E78
		public void ondatasetchanged(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_ondatasetchangedDelegate != null)
			{
				this.m_ondatasetchangedDelegate(A_1);
				return;
			}
		}

		// Token: 0x06018599 RID: 99737 RVA: 0x00099EA8 File Offset: 0x00098EA8
		public void onrowenter(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_onrowenterDelegate != null)
			{
				this.m_onrowenterDelegate(A_1);
				return;
			}
		}

		// Token: 0x0601859A RID: 99738 RVA: 0x00099ED8 File Offset: 0x00098ED8
		public bool onrowexit(global::mshtml.IHTMLEventObj A_1)
		{
			return this.m_onrowexitDelegate != null && this.m_onrowexitDelegate(A_1);
		}

		// Token: 0x0601859B RID: 99739 RVA: 0x00099F08 File Offset: 0x00098F08
		public bool onerrorupdate(global::mshtml.IHTMLEventObj A_1)
		{
			return this.m_onerrorupdateDelegate != null && this.m_onerrorupdateDelegate(A_1);
		}

		// Token: 0x0601859C RID: 99740 RVA: 0x00099F38 File Offset: 0x00098F38
		public void onafterupdate(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_onafterupdateDelegate != null)
			{
				this.m_onafterupdateDelegate(A_1);
				return;
			}
		}

		// Token: 0x0601859D RID: 99741 RVA: 0x00099F68 File Offset: 0x00098F68
		public bool onbeforeupdate(global::mshtml.IHTMLEventObj A_1)
		{
			return this.m_onbeforeupdateDelegate != null && this.m_onbeforeupdateDelegate(A_1);
		}

		// Token: 0x0601859E RID: 99742 RVA: 0x00099F98 File Offset: 0x00098F98
		public bool ondragstart(global::mshtml.IHTMLEventObj A_1)
		{
			return this.m_ondragstartDelegate != null && this.m_ondragstartDelegate(A_1);
		}

		// Token: 0x0601859F RID: 99743 RVA: 0x00099FC8 File Offset: 0x00098FC8
		public void onfilterchange(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_onfilterchangeDelegate != null)
			{
				this.m_onfilterchangeDelegate(A_1);
				return;
			}
		}

		// Token: 0x060185A0 RID: 99744 RVA: 0x00099FF8 File Offset: 0x00098FF8
		public bool onselectstart(global::mshtml.IHTMLEventObj A_1)
		{
			return this.m_onselectstartDelegate != null && this.m_onselectstartDelegate(A_1);
		}

		// Token: 0x060185A1 RID: 99745 RVA: 0x0009A028 File Offset: 0x00099028
		public void onmouseup(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_onmouseupDelegate != null)
			{
				this.m_onmouseupDelegate(A_1);
				return;
			}
		}

		// Token: 0x060185A2 RID: 99746 RVA: 0x0009A058 File Offset: 0x00099058
		public void onmousedown(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_onmousedownDelegate != null)
			{
				this.m_onmousedownDelegate(A_1);
				return;
			}
		}

		// Token: 0x060185A3 RID: 99747 RVA: 0x0009A088 File Offset: 0x00099088
		public void onmousemove(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_onmousemoveDelegate != null)
			{
				this.m_onmousemoveDelegate(A_1);
				return;
			}
		}

		// Token: 0x060185A4 RID: 99748 RVA: 0x0009A0B8 File Offset: 0x000990B8
		public void onmouseover(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_onmouseoverDelegate != null)
			{
				this.m_onmouseoverDelegate(A_1);
				return;
			}
		}

		// Token: 0x060185A5 RID: 99749 RVA: 0x0009A0E8 File Offset: 0x000990E8
		public void onmouseout(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_onmouseoutDelegate != null)
			{
				this.m_onmouseoutDelegate(A_1);
				return;
			}
		}

		// Token: 0x060185A6 RID: 99750 RVA: 0x0009A118 File Offset: 0x00099118
		public void onkeyup(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_onkeyupDelegate != null)
			{
				this.m_onkeyupDelegate(A_1);
				return;
			}
		}

		// Token: 0x060185A7 RID: 99751 RVA: 0x0009A148 File Offset: 0x00099148
		public void onkeydown(global::mshtml.IHTMLEventObj A_1)
		{
			if (this.m_onkeydownDelegate != null)
			{
				this.m_onkeydownDelegate(A_1);
				return;
			}
		}

		// Token: 0x060185A8 RID: 99752 RVA: 0x0009A178 File Offset: 0x00099178
		public bool onkeypress(global::mshtml.IHTMLEventObj A_1)
		{
			return this.m_onkeypressDelegate != null && this.m_onkeypressDelegate(A_1);
		}

		// Token: 0x060185A9 RID: 99753 RVA: 0x0009A1A8 File Offset: 0x000991A8
		public bool ondblclick(global::mshtml.IHTMLEventObj A_1)
		{
			return this.m_ondblclickDelegate != null && this.m_ondblclickDelegate(A_1);
		}

		// Token: 0x060185AA RID: 99754 RVA: 0x0009A1D8 File Offset: 0x000991D8
		public bool onclick(global::mshtml.IHTMLEventObj A_1)
		{
			return this.m_onclickDelegate != null && this.m_onclickDelegate(A_1);
		}

		// Token: 0x060185AB RID: 99755 RVA: 0x0009A208 File Offset: 0x00099208
		public bool onhelp(global::mshtml.IHTMLEventObj A_1)
		{
			return this.m_onhelpDelegate != null && this.m_onhelpDelegate(A_1);
		}

		// Token: 0x060185AC RID: 99756 RVA: 0x0009A238 File Offset: 0x00099238
		internal HTMLTableEvents2_SinkHelper()
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

		// Token: 0x04000A7F RID: 2687
		public global::mshtml.HTMLTableEvents2_onmousewheelEventHandler m_onmousewheelDelegate;

		// Token: 0x04000A80 RID: 2688
		public global::mshtml.HTMLTableEvents2_onresizeendEventHandler m_onresizeendDelegate;

		// Token: 0x04000A81 RID: 2689
		public global::mshtml.HTMLTableEvents2_onresizestartEventHandler m_onresizestartDelegate;

		// Token: 0x04000A82 RID: 2690
		public global::mshtml.HTMLTableEvents2_onmoveendEventHandler m_onmoveendDelegate;

		// Token: 0x04000A83 RID: 2691
		public global::mshtml.HTMLTableEvents2_onmovestartEventHandler m_onmovestartDelegate;

		// Token: 0x04000A84 RID: 2692
		public global::mshtml.HTMLTableEvents2_oncontrolselectEventHandler m_oncontrolselectDelegate;

		// Token: 0x04000A85 RID: 2693
		public global::mshtml.HTMLTableEvents2_onmoveEventHandler m_onmoveDelegate;

		// Token: 0x04000A86 RID: 2694
		public global::mshtml.HTMLTableEvents2_onfocusoutEventHandler m_onfocusoutDelegate;

		// Token: 0x04000A87 RID: 2695
		public global::mshtml.HTMLTableEvents2_onfocusinEventHandler m_onfocusinDelegate;

		// Token: 0x04000A88 RID: 2696
		public global::mshtml.HTMLTableEvents2_onbeforeactivateEventHandler m_onbeforeactivateDelegate;

		// Token: 0x04000A89 RID: 2697
		public global::mshtml.HTMLTableEvents2_onbeforedeactivateEventHandler m_onbeforedeactivateDelegate;

		// Token: 0x04000A8A RID: 2698
		public global::mshtml.HTMLTableEvents2_ondeactivateEventHandler m_ondeactivateDelegate;

		// Token: 0x04000A8B RID: 2699
		public global::mshtml.HTMLTableEvents2_onactivateEventHandler m_onactivateDelegate;

		// Token: 0x04000A8C RID: 2700
		public global::mshtml.HTMLTableEvents2_onmouseleaveEventHandler m_onmouseleaveDelegate;

		// Token: 0x04000A8D RID: 2701
		public global::mshtml.HTMLTableEvents2_onmouseenterEventHandler m_onmouseenterDelegate;

		// Token: 0x04000A8E RID: 2702
		public global::mshtml.HTMLTableEvents2_onpageEventHandler m_onpageDelegate;

		// Token: 0x04000A8F RID: 2703
		public global::mshtml.HTMLTableEvents2_onlayoutcompleteEventHandler m_onlayoutcompleteDelegate;

		// Token: 0x04000A90 RID: 2704
		public global::mshtml.HTMLTableEvents2_onreadystatechangeEventHandler m_onreadystatechangeDelegate;

		// Token: 0x04000A91 RID: 2705
		public global::mshtml.HTMLTableEvents2_oncellchangeEventHandler m_oncellchangeDelegate;

		// Token: 0x04000A92 RID: 2706
		public global::mshtml.HTMLTableEvents2_onrowsinsertedEventHandler m_onrowsinsertedDelegate;

		// Token: 0x04000A93 RID: 2707
		public global::mshtml.HTMLTableEvents2_onrowsdeleteEventHandler m_onrowsdeleteDelegate;

		// Token: 0x04000A94 RID: 2708
		public global::mshtml.HTMLTableEvents2_oncontextmenuEventHandler m_oncontextmenuDelegate;

		// Token: 0x04000A95 RID: 2709
		public global::mshtml.HTMLTableEvents2_onpasteEventHandler m_onpasteDelegate;

		// Token: 0x04000A96 RID: 2710
		public global::mshtml.HTMLTableEvents2_onbeforepasteEventHandler m_onbeforepasteDelegate;

		// Token: 0x04000A97 RID: 2711
		public global::mshtml.HTMLTableEvents2_oncopyEventHandler m_oncopyDelegate;

		// Token: 0x04000A98 RID: 2712
		public global::mshtml.HTMLTableEvents2_onbeforecopyEventHandler m_onbeforecopyDelegate;

		// Token: 0x04000A99 RID: 2713
		public global::mshtml.HTMLTableEvents2_oncutEventHandler m_oncutDelegate;

		// Token: 0x04000A9A RID: 2714
		public global::mshtml.HTMLTableEvents2_onbeforecutEventHandler m_onbeforecutDelegate;

		// Token: 0x04000A9B RID: 2715
		public global::mshtml.HTMLTableEvents2_ondropEventHandler m_ondropDelegate;

		// Token: 0x04000A9C RID: 2716
		public global::mshtml.HTMLTableEvents2_ondragleaveEventHandler m_ondragleaveDelegate;

		// Token: 0x04000A9D RID: 2717
		public global::mshtml.HTMLTableEvents2_ondragoverEventHandler m_ondragoverDelegate;

		// Token: 0x04000A9E RID: 2718
		public global::mshtml.HTMLTableEvents2_ondragenterEventHandler m_ondragenterDelegate;

		// Token: 0x04000A9F RID: 2719
		public global::mshtml.HTMLTableEvents2_ondragendEventHandler m_ondragendDelegate;

		// Token: 0x04000AA0 RID: 2720
		public global::mshtml.HTMLTableEvents2_ondragEventHandler m_ondragDelegate;

		// Token: 0x04000AA1 RID: 2721
		public global::mshtml.HTMLTableEvents2_onresizeEventHandler m_onresizeDelegate;

		// Token: 0x04000AA2 RID: 2722
		public global::mshtml.HTMLTableEvents2_onblurEventHandler m_onblurDelegate;

		// Token: 0x04000AA3 RID: 2723
		public global::mshtml.HTMLTableEvents2_onfocusEventHandler m_onfocusDelegate;

		// Token: 0x04000AA4 RID: 2724
		public global::mshtml.HTMLTableEvents2_onscrollEventHandler m_onscrollDelegate;

		// Token: 0x04000AA5 RID: 2725
		public global::mshtml.HTMLTableEvents2_onpropertychangeEventHandler m_onpropertychangeDelegate;

		// Token: 0x04000AA6 RID: 2726
		public global::mshtml.HTMLTableEvents2_onlosecaptureEventHandler m_onlosecaptureDelegate;

		// Token: 0x04000AA7 RID: 2727
		public global::mshtml.HTMLTableEvents2_ondatasetcompleteEventHandler m_ondatasetcompleteDelegate;

		// Token: 0x04000AA8 RID: 2728
		public global::mshtml.HTMLTableEvents2_ondataavailableEventHandler m_ondataavailableDelegate;

		// Token: 0x04000AA9 RID: 2729
		public global::mshtml.HTMLTableEvents2_ondatasetchangedEventHandler m_ondatasetchangedDelegate;

		// Token: 0x04000AAA RID: 2730
		public global::mshtml.HTMLTableEvents2_onrowenterEventHandler m_onrowenterDelegate;

		// Token: 0x04000AAB RID: 2731
		public global::mshtml.HTMLTableEvents2_onrowexitEventHandler m_onrowexitDelegate;

		// Token: 0x04000AAC RID: 2732
		public global::mshtml.HTMLTableEvents2_onerrorupdateEventHandler m_onerrorupdateDelegate;

		// Token: 0x04000AAD RID: 2733
		public global::mshtml.HTMLTableEvents2_onafterupdateEventHandler m_onafterupdateDelegate;

		// Token: 0x04000AAE RID: 2734
		public global::mshtml.HTMLTableEvents2_onbeforeupdateEventHandler m_onbeforeupdateDelegate;

		// Token: 0x04000AAF RID: 2735
		public global::mshtml.HTMLTableEvents2_ondragstartEventHandler m_ondragstartDelegate;

		// Token: 0x04000AB0 RID: 2736
		public global::mshtml.HTMLTableEvents2_onfilterchangeEventHandler m_onfilterchangeDelegate;

		// Token: 0x04000AB1 RID: 2737
		public global::mshtml.HTMLTableEvents2_onselectstartEventHandler m_onselectstartDelegate;

		// Token: 0x04000AB2 RID: 2738
		public global::mshtml.HTMLTableEvents2_onmouseupEventHandler m_onmouseupDelegate;

		// Token: 0x04000AB3 RID: 2739
		public global::mshtml.HTMLTableEvents2_onmousedownEventHandler m_onmousedownDelegate;

		// Token: 0x04000AB4 RID: 2740
		public global::mshtml.HTMLTableEvents2_onmousemoveEventHandler m_onmousemoveDelegate;

		// Token: 0x04000AB5 RID: 2741
		public global::mshtml.HTMLTableEvents2_onmouseoverEventHandler m_onmouseoverDelegate;

		// Token: 0x04000AB6 RID: 2742
		public global::mshtml.HTMLTableEvents2_onmouseoutEventHandler m_onmouseoutDelegate;

		// Token: 0x04000AB7 RID: 2743
		public global::mshtml.HTMLTableEvents2_onkeyupEventHandler m_onkeyupDelegate;

		// Token: 0x04000AB8 RID: 2744
		public global::mshtml.HTMLTableEvents2_onkeydownEventHandler m_onkeydownDelegate;

		// Token: 0x04000AB9 RID: 2745
		public global::mshtml.HTMLTableEvents2_onkeypressEventHandler m_onkeypressDelegate;

		// Token: 0x04000ABA RID: 2746
		public global::mshtml.HTMLTableEvents2_ondblclickEventHandler m_ondblclickDelegate;

		// Token: 0x04000ABB RID: 2747
		public global::mshtml.HTMLTableEvents2_onclickEventHandler m_onclickDelegate;

		// Token: 0x04000ABC RID: 2748
		public global::mshtml.HTMLTableEvents2_onhelpEventHandler m_onhelpDelegate;

		// Token: 0x04000ABD RID: 2749
		public int m_dwCookie;
	}
}
