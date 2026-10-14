using System;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using SHDocVw;

namespace AxSHDocVw
{
	// Token: 0x02000002 RID: 2
	[global::System.ComponentModel.DefaultProperty("Name")]
	[global::System.Windows.Forms.AxHost.ClsidAttribute("{8856f961-340a-11d0-a96b-00c04fd705a2}")]
	[global::System.ComponentModel.DesignTimeVisible(true)]
	public class AxWebBrowser : global::System.Windows.Forms.AxHost
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00001050
		public AxWebBrowser() : base("8856f961-340a-11d0-a96b-00c04fd705a2")
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000002 RID: 2 RVA: 0x00002068 File Offset: 0x00001068
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.Runtime.InteropServices.DispId(200)]
		public virtual object Application
		{
			get
			{
				if (this.ocx == null)
				{
					throw new global::System.Windows.Forms.AxHost.InvalidActiveXStateException("Application", global::System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet);
				}
				return this.ocx.Application;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000003 RID: 3 RVA: 0x00002094 File Offset: 0x00001094
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.Runtime.InteropServices.DispId(201)]
		public virtual object CtlParent
		{
			get
			{
				if (this.ocx == null)
				{
					throw new global::System.Windows.Forms.AxHost.InvalidActiveXStateException("CtlParent", global::System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet);
				}
				return this.ocx.Parent;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000004 RID: 4 RVA: 0x000020C0 File Offset: 0x000010C0
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.Runtime.InteropServices.DispId(202)]
		public virtual object CtlContainer
		{
			get
			{
				if (this.ocx == null)
				{
					throw new global::System.Windows.Forms.AxHost.InvalidActiveXStateException("CtlContainer", global::System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet);
				}
				return this.ocx.Container;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000005 RID: 5 RVA: 0x000020EC File Offset: 0x000010EC
		[global::System.Runtime.InteropServices.DispId(203)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public virtual object Document
		{
			get
			{
				if (this.ocx == null)
				{
					throw new global::System.Windows.Forms.AxHost.InvalidActiveXStateException("Document", global::System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet);
				}
				return this.ocx.Document;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000006 RID: 6 RVA: 0x00002118 File Offset: 0x00001118
		[global::System.Runtime.InteropServices.DispId(204)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public virtual bool TopLevelContainer
		{
			get
			{
				if (this.ocx == null)
				{
					throw new global::System.Windows.Forms.AxHost.InvalidActiveXStateException("TopLevelContainer", global::System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet);
				}
				return this.ocx.TopLevelContainer;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000007 RID: 7 RVA: 0x00002144 File Offset: 0x00001144
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.Runtime.InteropServices.DispId(205)]
		public virtual string Type
		{
			get
			{
				if (this.ocx == null)
				{
					throw new global::System.Windows.Forms.AxHost.InvalidActiveXStateException("Type", global::System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet);
				}
				return this.ocx.Type;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000008 RID: 8 RVA: 0x00002170 File Offset: 0x00001170
		// (set) Token: 0x06000009 RID: 9 RVA: 0x0000219C File Offset: 0x0000119C
		[global::System.Runtime.InteropServices.DispId(206)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public virtual int CtlLeft
		{
			get
			{
				if (this.ocx == null)
				{
					throw new global::System.Windows.Forms.AxHost.InvalidActiveXStateException("CtlLeft", global::System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet);
				}
				return this.ocx.Left;
			}
			set
			{
				if (this.ocx == null)
				{
					throw new global::System.Windows.Forms.AxHost.InvalidActiveXStateException("CtlLeft", global::System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertySet);
				}
				this.ocx.Left = value;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600000A RID: 10 RVA: 0x000021CC File Offset: 0x000011CC
		// (set) Token: 0x0600000B RID: 11 RVA: 0x000021F8 File Offset: 0x000011F8
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.Runtime.InteropServices.DispId(207)]
		public virtual int CtlTop
		{
			get
			{
				if (this.ocx == null)
				{
					throw new global::System.Windows.Forms.AxHost.InvalidActiveXStateException("CtlTop", global::System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet);
				}
				return this.ocx.Top;
			}
			set
			{
				if (this.ocx == null)
				{
					throw new global::System.Windows.Forms.AxHost.InvalidActiveXStateException("CtlTop", global::System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertySet);
				}
				this.ocx.Top = value;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600000C RID: 12 RVA: 0x00002228 File Offset: 0x00001228
		// (set) Token: 0x0600000D RID: 13 RVA: 0x00002254 File Offset: 0x00001254
		[global::System.Runtime.InteropServices.DispId(208)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public virtual int CtlWidth
		{
			get
			{
				if (this.ocx == null)
				{
					throw new global::System.Windows.Forms.AxHost.InvalidActiveXStateException("CtlWidth", global::System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet);
				}
				return this.ocx.Width;
			}
			set
			{
				if (this.ocx == null)
				{
					throw new global::System.Windows.Forms.AxHost.InvalidActiveXStateException("CtlWidth", global::System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertySet);
				}
				this.ocx.Width = value;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600000E RID: 14 RVA: 0x00002284 File Offset: 0x00001284
		// (set) Token: 0x0600000F RID: 15 RVA: 0x000022B0 File Offset: 0x000012B0
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.Runtime.InteropServices.DispId(209)]
		public virtual int CtlHeight
		{
			get
			{
				if (this.ocx == null)
				{
					throw new global::System.Windows.Forms.AxHost.InvalidActiveXStateException("CtlHeight", global::System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet);
				}
				return this.ocx.Height;
			}
			set
			{
				if (this.ocx == null)
				{
					throw new global::System.Windows.Forms.AxHost.InvalidActiveXStateException("CtlHeight", global::System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertySet);
				}
				this.ocx.Height = value;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000010 RID: 16 RVA: 0x000022E0 File Offset: 0x000012E0
		[global::System.Runtime.InteropServices.DispId(210)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public virtual string LocationName
		{
			get
			{
				if (this.ocx == null)
				{
					throw new global::System.Windows.Forms.AxHost.InvalidActiveXStateException("LocationName", global::System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet);
				}
				return this.ocx.LocationName;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000011 RID: 17 RVA: 0x0000230C File Offset: 0x0000130C
		[global::System.Runtime.InteropServices.DispId(211)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public virtual string LocationURL
		{
			get
			{
				if (this.ocx == null)
				{
					throw new global::System.Windows.Forms.AxHost.InvalidActiveXStateException("LocationURL", global::System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet);
				}
				return this.ocx.LocationURL;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000012 RID: 18 RVA: 0x00002338 File Offset: 0x00001338
		[global::System.Runtime.InteropServices.DispId(212)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public virtual bool Busy
		{
			get
			{
				if (this.ocx == null)
				{
					throw new global::System.Windows.Forms.AxHost.InvalidActiveXStateException("Busy", global::System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet);
				}
				return this.ocx.Busy;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000013 RID: 19 RVA: 0x00002364 File Offset: 0x00001364
		[global::System.ComponentModel.Browsable(true)]
		[global::System.Runtime.InteropServices.DispId(0)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public new virtual string Name
		{
			get
			{
				if (this.ocx == null)
				{
					throw new global::System.Windows.Forms.AxHost.InvalidActiveXStateException("Name", global::System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet);
				}
				return this.ocx.Name;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000014 RID: 20 RVA: 0x00002390 File Offset: 0x00001390
		[global::System.Runtime.InteropServices.DispId(-515)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.Runtime.InteropServices.ComAliasName("System.Int32")]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public virtual int HWND
		{
			get
			{
				if (this.ocx == null)
				{
					throw new global::System.Windows.Forms.AxHost.InvalidActiveXStateException("HWND", global::System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet);
				}
				return this.ocx.HWND;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000015 RID: 21 RVA: 0x000023BC File Offset: 0x000013BC
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.Runtime.InteropServices.DispId(400)]
		public virtual string FullName
		{
			get
			{
				if (this.ocx == null)
				{
					throw new global::System.Windows.Forms.AxHost.InvalidActiveXStateException("FullName", global::System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet);
				}
				return this.ocx.FullName;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000016 RID: 22 RVA: 0x000023E8 File Offset: 0x000013E8
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.Runtime.InteropServices.DispId(401)]
		public virtual string Path
		{
			get
			{
				if (this.ocx == null)
				{
					throw new global::System.Windows.Forms.AxHost.InvalidActiveXStateException("Path", global::System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet);
				}
				return this.ocx.Path;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000017 RID: 23 RVA: 0x00002414 File Offset: 0x00001414
		// (set) Token: 0x06000018 RID: 24 RVA: 0x00002440 File Offset: 0x00001440
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.Runtime.InteropServices.DispId(402)]
		public virtual bool CtlVisible
		{
			get
			{
				if (this.ocx == null)
				{
					throw new global::System.Windows.Forms.AxHost.InvalidActiveXStateException("CtlVisible", global::System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet);
				}
				return this.ocx.Visible;
			}
			set
			{
				if (this.ocx == null)
				{
					throw new global::System.Windows.Forms.AxHost.InvalidActiveXStateException("CtlVisible", global::System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertySet);
				}
				this.ocx.Visible = value;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000019 RID: 25 RVA: 0x00002470 File Offset: 0x00001470
		// (set) Token: 0x0600001A RID: 26 RVA: 0x0000249C File Offset: 0x0000149C
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.Runtime.InteropServices.DispId(403)]
		public virtual bool StatusBar
		{
			get
			{
				if (this.ocx == null)
				{
					throw new global::System.Windows.Forms.AxHost.InvalidActiveXStateException("StatusBar", global::System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet);
				}
				return this.ocx.StatusBar;
			}
			set
			{
				if (this.ocx == null)
				{
					throw new global::System.Windows.Forms.AxHost.InvalidActiveXStateException("StatusBar", global::System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertySet);
				}
				this.ocx.StatusBar = value;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600001B RID: 27 RVA: 0x000024CC File Offset: 0x000014CC
		// (set) Token: 0x0600001C RID: 28 RVA: 0x000024F8 File Offset: 0x000014F8
		[global::System.Runtime.InteropServices.DispId(404)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public virtual string StatusText
		{
			get
			{
				if (this.ocx == null)
				{
					throw new global::System.Windows.Forms.AxHost.InvalidActiveXStateException("StatusText", global::System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet);
				}
				return this.ocx.StatusText;
			}
			set
			{
				if (this.ocx == null)
				{
					throw new global::System.Windows.Forms.AxHost.InvalidActiveXStateException("StatusText", global::System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertySet);
				}
				this.ocx.StatusText = value;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600001D RID: 29 RVA: 0x00002528 File Offset: 0x00001528
		// (set) Token: 0x0600001E RID: 30 RVA: 0x00002554 File Offset: 0x00001554
		[global::System.Runtime.InteropServices.DispId(405)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public virtual int ToolBar
		{
			get
			{
				if (this.ocx == null)
				{
					throw new global::System.Windows.Forms.AxHost.InvalidActiveXStateException("ToolBar", global::System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet);
				}
				return this.ocx.ToolBar;
			}
			set
			{
				if (this.ocx == null)
				{
					throw new global::System.Windows.Forms.AxHost.InvalidActiveXStateException("ToolBar", global::System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertySet);
				}
				this.ocx.ToolBar = value;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600001F RID: 31 RVA: 0x00002584 File Offset: 0x00001584
		// (set) Token: 0x06000020 RID: 32 RVA: 0x000025B0 File Offset: 0x000015B0
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.Runtime.InteropServices.DispId(406)]
		public virtual bool MenuBar
		{
			get
			{
				if (this.ocx == null)
				{
					throw new global::System.Windows.Forms.AxHost.InvalidActiveXStateException("MenuBar", global::System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet);
				}
				return this.ocx.MenuBar;
			}
			set
			{
				if (this.ocx == null)
				{
					throw new global::System.Windows.Forms.AxHost.InvalidActiveXStateException("MenuBar", global::System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertySet);
				}
				this.ocx.MenuBar = value;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000021 RID: 33 RVA: 0x000025E0 File Offset: 0x000015E0
		// (set) Token: 0x06000022 RID: 34 RVA: 0x0000260C File Offset: 0x0000160C
		[global::System.Runtime.InteropServices.DispId(407)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public virtual bool FullScreen
		{
			get
			{
				if (this.ocx == null)
				{
					throw new global::System.Windows.Forms.AxHost.InvalidActiveXStateException("FullScreen", global::System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet);
				}
				return this.ocx.FullScreen;
			}
			set
			{
				if (this.ocx == null)
				{
					throw new global::System.Windows.Forms.AxHost.InvalidActiveXStateException("FullScreen", global::System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertySet);
				}
				this.ocx.FullScreen = value;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000023 RID: 35 RVA: 0x0000263C File Offset: 0x0000163C
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(global::System.ComponentModel.BindableSupport.Yes)]
		[global::System.Runtime.InteropServices.DispId(-525)]
		public virtual global::SHDocVw.tagREADYSTATE ReadyState
		{
			get
			{
				if (this.ocx == null)
				{
					throw new global::System.Windows.Forms.AxHost.InvalidActiveXStateException("ReadyState", global::System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet);
				}
				return this.ocx.ReadyState;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000024 RID: 36 RVA: 0x00002668 File Offset: 0x00001668
		// (set) Token: 0x06000025 RID: 37 RVA: 0x00002694 File Offset: 0x00001694
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.Runtime.InteropServices.DispId(550)]
		public virtual bool Offline
		{
			get
			{
				if (this.ocx == null)
				{
					throw new global::System.Windows.Forms.AxHost.InvalidActiveXStateException("Offline", global::System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet);
				}
				return this.ocx.Offline;
			}
			set
			{
				if (this.ocx == null)
				{
					throw new global::System.Windows.Forms.AxHost.InvalidActiveXStateException("Offline", global::System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertySet);
				}
				this.ocx.Offline = value;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000026 RID: 38 RVA: 0x000026C4 File Offset: 0x000016C4
		// (set) Token: 0x06000027 RID: 39 RVA: 0x000026F0 File Offset: 0x000016F0
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.Runtime.InteropServices.DispId(551)]
		public virtual bool Silent
		{
			get
			{
				if (this.ocx == null)
				{
					throw new global::System.Windows.Forms.AxHost.InvalidActiveXStateException("Silent", global::System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet);
				}
				return this.ocx.Silent;
			}
			set
			{
				if (this.ocx == null)
				{
					throw new global::System.Windows.Forms.AxHost.InvalidActiveXStateException("Silent", global::System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertySet);
				}
				this.ocx.Silent = value;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000028 RID: 40 RVA: 0x00002720 File Offset: 0x00001720
		// (set) Token: 0x06000029 RID: 41 RVA: 0x0000274C File Offset: 0x0000174C
		[global::System.Runtime.InteropServices.DispId(552)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public virtual bool RegisterAsBrowser
		{
			get
			{
				if (this.ocx == null)
				{
					throw new global::System.Windows.Forms.AxHost.InvalidActiveXStateException("RegisterAsBrowser", global::System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet);
				}
				return this.ocx.RegisterAsBrowser;
			}
			set
			{
				if (this.ocx == null)
				{
					throw new global::System.Windows.Forms.AxHost.InvalidActiveXStateException("RegisterAsBrowser", global::System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertySet);
				}
				this.ocx.RegisterAsBrowser = value;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600002A RID: 42 RVA: 0x0000277C File Offset: 0x0000177C
		// (set) Token: 0x0600002B RID: 43 RVA: 0x000027A8 File Offset: 0x000017A8
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.Runtime.InteropServices.DispId(553)]
		public virtual bool RegisterAsDropTarget
		{
			get
			{
				if (this.ocx == null)
				{
					throw new global::System.Windows.Forms.AxHost.InvalidActiveXStateException("RegisterAsDropTarget", global::System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet);
				}
				return this.ocx.RegisterAsDropTarget;
			}
			set
			{
				if (this.ocx == null)
				{
					throw new global::System.Windows.Forms.AxHost.InvalidActiveXStateException("RegisterAsDropTarget", global::System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertySet);
				}
				this.ocx.RegisterAsDropTarget = value;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600002C RID: 44 RVA: 0x000027D8 File Offset: 0x000017D8
		// (set) Token: 0x0600002D RID: 45 RVA: 0x00002804 File Offset: 0x00001804
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.Runtime.InteropServices.DispId(554)]
		public virtual bool TheaterMode
		{
			get
			{
				if (this.ocx == null)
				{
					throw new global::System.Windows.Forms.AxHost.InvalidActiveXStateException("TheaterMode", global::System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet);
				}
				return this.ocx.TheaterMode;
			}
			set
			{
				if (this.ocx == null)
				{
					throw new global::System.Windows.Forms.AxHost.InvalidActiveXStateException("TheaterMode", global::System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertySet);
				}
				this.ocx.TheaterMode = value;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600002E RID: 46 RVA: 0x00002834 File Offset: 0x00001834
		// (set) Token: 0x0600002F RID: 47 RVA: 0x00002860 File Offset: 0x00001860
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.Runtime.InteropServices.DispId(555)]
		public virtual bool AddressBar
		{
			get
			{
				if (this.ocx == null)
				{
					throw new global::System.Windows.Forms.AxHost.InvalidActiveXStateException("AddressBar", global::System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet);
				}
				return this.ocx.AddressBar;
			}
			set
			{
				if (this.ocx == null)
				{
					throw new global::System.Windows.Forms.AxHost.InvalidActiveXStateException("AddressBar", global::System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertySet);
				}
				this.ocx.AddressBar = value;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000030 RID: 48 RVA: 0x00002890 File Offset: 0x00001890
		// (set) Token: 0x06000031 RID: 49 RVA: 0x000028BC File Offset: 0x000018BC
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.Runtime.InteropServices.DispId(556)]
		public virtual bool Resizable
		{
			get
			{
				if (this.ocx == null)
				{
					throw new global::System.Windows.Forms.AxHost.InvalidActiveXStateException("Resizable", global::System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet);
				}
				return this.ocx.Resizable;
			}
			set
			{
				if (this.ocx == null)
				{
					throw new global::System.Windows.Forms.AxHost.InvalidActiveXStateException("Resizable", global::System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertySet);
				}
				this.ocx.Resizable = value;
			}
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000032 RID: 50 RVA: 0x000028EC File Offset: 0x000018EC
		// (remove) Token: 0x06000033 RID: 51 RVA: 0x00002910 File Offset: 0x00001910
		public event global::AxSHDocVw.DWebBrowserEvents2_PrivacyImpactedStateChangeEventHandler PrivacyImpactedStateChange;

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000034 RID: 52 RVA: 0x00002934 File Offset: 0x00001934
		// (remove) Token: 0x06000035 RID: 53 RVA: 0x00002958 File Offset: 0x00001958
		public event global::AxSHDocVw.DWebBrowserEvents2_UpdatePageStatusEventHandler UpdatePageStatus;

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000036 RID: 54 RVA: 0x0000297C File Offset: 0x0000197C
		// (remove) Token: 0x06000037 RID: 55 RVA: 0x000029A0 File Offset: 0x000019A0
		public event global::AxSHDocVw.DWebBrowserEvents2_PrintTemplateTeardownEventHandler PrintTemplateTeardown;

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06000038 RID: 56 RVA: 0x000029C4 File Offset: 0x000019C4
		// (remove) Token: 0x06000039 RID: 57 RVA: 0x000029E8 File Offset: 0x000019E8
		public event global::AxSHDocVw.DWebBrowserEvents2_PrintTemplateInstantiationEventHandler PrintTemplateInstantiation;

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x0600003A RID: 58 RVA: 0x00002A0C File Offset: 0x00001A0C
		// (remove) Token: 0x0600003B RID: 59 RVA: 0x00002A30 File Offset: 0x00001A30
		public event global::AxSHDocVw.DWebBrowserEvents2_NavigateErrorEventHandler NavigateError;

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x0600003C RID: 60 RVA: 0x00002A54 File Offset: 0x00001A54
		// (remove) Token: 0x0600003D RID: 61 RVA: 0x00002A78 File Offset: 0x00001A78
		public event global::AxSHDocVw.DWebBrowserEvents2_FileDownloadEventHandler FileDownload;

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x0600003E RID: 62 RVA: 0x00002A9C File Offset: 0x00001A9C
		// (remove) Token: 0x0600003F RID: 63 RVA: 0x00002AC0 File Offset: 0x00001AC0
		public event global::AxSHDocVw.DWebBrowserEvents2_SetSecureLockIconEventHandler SetSecureLockIcon;

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x06000040 RID: 64 RVA: 0x00002AE4 File Offset: 0x00001AE4
		// (remove) Token: 0x06000041 RID: 65 RVA: 0x00002B08 File Offset: 0x00001B08
		public event global::AxSHDocVw.DWebBrowserEvents2_ClientToHostWindowEventHandler ClientToHostWindow;

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x06000042 RID: 66 RVA: 0x00002B2C File Offset: 0x00001B2C
		// (remove) Token: 0x06000043 RID: 67 RVA: 0x00002B50 File Offset: 0x00001B50
		public event global::AxSHDocVw.DWebBrowserEvents2_WindowClosingEventHandler WindowClosing;

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x06000044 RID: 68 RVA: 0x00002B74 File Offset: 0x00001B74
		// (remove) Token: 0x06000045 RID: 69 RVA: 0x00002B98 File Offset: 0x00001B98
		public event global::AxSHDocVw.DWebBrowserEvents2_WindowSetHeightEventHandler WindowSetHeight;

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x06000046 RID: 70 RVA: 0x00002BBC File Offset: 0x00001BBC
		// (remove) Token: 0x06000047 RID: 71 RVA: 0x00002BE0 File Offset: 0x00001BE0
		public event global::AxSHDocVw.DWebBrowserEvents2_WindowSetWidthEventHandler WindowSetWidth;

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x06000048 RID: 72 RVA: 0x00002C04 File Offset: 0x00001C04
		// (remove) Token: 0x06000049 RID: 73 RVA: 0x00002C28 File Offset: 0x00001C28
		public event global::AxSHDocVw.DWebBrowserEvents2_WindowSetTopEventHandler WindowSetTop;

		// Token: 0x1400000D RID: 13
		// (add) Token: 0x0600004A RID: 74 RVA: 0x00002C4C File Offset: 0x00001C4C
		// (remove) Token: 0x0600004B RID: 75 RVA: 0x00002C70 File Offset: 0x00001C70
		public event global::AxSHDocVw.DWebBrowserEvents2_WindowSetLeftEventHandler WindowSetLeft;

		// Token: 0x1400000E RID: 14
		// (add) Token: 0x0600004C RID: 76 RVA: 0x00002C94 File Offset: 0x00001C94
		// (remove) Token: 0x0600004D RID: 77 RVA: 0x00002CB8 File Offset: 0x00001CB8
		public event global::AxSHDocVw.DWebBrowserEvents2_WindowSetResizableEventHandler WindowSetResizable;

		// Token: 0x1400000F RID: 15
		// (add) Token: 0x0600004E RID: 78 RVA: 0x00002CDC File Offset: 0x00001CDC
		// (remove) Token: 0x0600004F RID: 79 RVA: 0x00002D00 File Offset: 0x00001D00
		public event global::AxSHDocVw.DWebBrowserEvents2_OnTheaterModeEventHandler OnTheaterMode;

		// Token: 0x14000010 RID: 16
		// (add) Token: 0x06000050 RID: 80 RVA: 0x00002D24 File Offset: 0x00001D24
		// (remove) Token: 0x06000051 RID: 81 RVA: 0x00002D48 File Offset: 0x00001D48
		public event global::AxSHDocVw.DWebBrowserEvents2_OnFullScreenEventHandler OnFullScreen;

		// Token: 0x14000011 RID: 17
		// (add) Token: 0x06000052 RID: 82 RVA: 0x00002D6C File Offset: 0x00001D6C
		// (remove) Token: 0x06000053 RID: 83 RVA: 0x00002D90 File Offset: 0x00001D90
		public event global::AxSHDocVw.DWebBrowserEvents2_OnStatusBarEventHandler OnStatusBar;

		// Token: 0x14000012 RID: 18
		// (add) Token: 0x06000054 RID: 84 RVA: 0x00002DB4 File Offset: 0x00001DB4
		// (remove) Token: 0x06000055 RID: 85 RVA: 0x00002DD8 File Offset: 0x00001DD8
		public event global::AxSHDocVw.DWebBrowserEvents2_OnMenuBarEventHandler OnMenuBar;

		// Token: 0x14000013 RID: 19
		// (add) Token: 0x06000056 RID: 86 RVA: 0x00002DFC File Offset: 0x00001DFC
		// (remove) Token: 0x06000057 RID: 87 RVA: 0x00002E20 File Offset: 0x00001E20
		public event global::AxSHDocVw.DWebBrowserEvents2_OnToolBarEventHandler OnToolBar;

		// Token: 0x14000014 RID: 20
		// (add) Token: 0x06000058 RID: 88 RVA: 0x00002E44 File Offset: 0x00001E44
		// (remove) Token: 0x06000059 RID: 89 RVA: 0x00002E68 File Offset: 0x00001E68
		public event global::AxSHDocVw.DWebBrowserEvents2_OnVisibleEventHandler OnVisible;

		// Token: 0x14000015 RID: 21
		// (add) Token: 0x0600005A RID: 90 RVA: 0x00002E8C File Offset: 0x00001E8C
		// (remove) Token: 0x0600005B RID: 91 RVA: 0x00002EB0 File Offset: 0x00001EB0
		public event global::System.EventHandler OnQuit;

		// Token: 0x14000016 RID: 22
		// (add) Token: 0x0600005C RID: 92 RVA: 0x00002ED4 File Offset: 0x00001ED4
		// (remove) Token: 0x0600005D RID: 93 RVA: 0x00002EF8 File Offset: 0x00001EF8
		public event global::AxSHDocVw.DWebBrowserEvents2_DocumentCompleteEventHandler DocumentComplete;

		// Token: 0x14000017 RID: 23
		// (add) Token: 0x0600005E RID: 94 RVA: 0x00002F1C File Offset: 0x00001F1C
		// (remove) Token: 0x0600005F RID: 95 RVA: 0x00002F40 File Offset: 0x00001F40
		public event global::AxSHDocVw.DWebBrowserEvents2_NavigateComplete2EventHandler NavigateComplete2;

		// Token: 0x14000018 RID: 24
		// (add) Token: 0x06000060 RID: 96 RVA: 0x00002F64 File Offset: 0x00001F64
		// (remove) Token: 0x06000061 RID: 97 RVA: 0x00002F88 File Offset: 0x00001F88
		public event global::AxSHDocVw.DWebBrowserEvents2_NewWindow2EventHandler NewWindow2;

		// Token: 0x14000019 RID: 25
		// (add) Token: 0x06000062 RID: 98 RVA: 0x00002FAC File Offset: 0x00001FAC
		// (remove) Token: 0x06000063 RID: 99 RVA: 0x00002FD0 File Offset: 0x00001FD0
		public event global::AxSHDocVw.DWebBrowserEvents2_BeforeNavigate2EventHandler BeforeNavigate2;

		// Token: 0x1400001A RID: 26
		// (add) Token: 0x06000064 RID: 100 RVA: 0x00002FF4 File Offset: 0x00001FF4
		// (remove) Token: 0x06000065 RID: 101 RVA: 0x00003018 File Offset: 0x00002018
		public event global::AxSHDocVw.DWebBrowserEvents2_PropertyChangeEventHandler PropertyChange;

		// Token: 0x1400001B RID: 27
		// (add) Token: 0x06000066 RID: 102 RVA: 0x0000303C File Offset: 0x0000203C
		// (remove) Token: 0x06000067 RID: 103 RVA: 0x00003060 File Offset: 0x00002060
		public event global::AxSHDocVw.DWebBrowserEvents2_TitleChangeEventHandler TitleChange;

		// Token: 0x1400001C RID: 28
		// (add) Token: 0x06000068 RID: 104 RVA: 0x00003084 File Offset: 0x00002084
		// (remove) Token: 0x06000069 RID: 105 RVA: 0x000030A8 File Offset: 0x000020A8
		public event global::System.EventHandler DownloadComplete;

		// Token: 0x1400001D RID: 29
		// (add) Token: 0x0600006A RID: 106 RVA: 0x000030CC File Offset: 0x000020CC
		// (remove) Token: 0x0600006B RID: 107 RVA: 0x000030F0 File Offset: 0x000020F0
		public event global::System.EventHandler DownloadBegin;

		// Token: 0x1400001E RID: 30
		// (add) Token: 0x0600006C RID: 108 RVA: 0x00003114 File Offset: 0x00002114
		// (remove) Token: 0x0600006D RID: 109 RVA: 0x00003138 File Offset: 0x00002138
		public event global::AxSHDocVw.DWebBrowserEvents2_CommandStateChangeEventHandler CommandStateChange;

		// Token: 0x1400001F RID: 31
		// (add) Token: 0x0600006E RID: 110 RVA: 0x0000315C File Offset: 0x0000215C
		// (remove) Token: 0x0600006F RID: 111 RVA: 0x00003180 File Offset: 0x00002180
		public event global::AxSHDocVw.DWebBrowserEvents2_ProgressChangeEventHandler ProgressChange;

		// Token: 0x14000020 RID: 32
		// (add) Token: 0x06000070 RID: 112 RVA: 0x000031A4 File Offset: 0x000021A4
		// (remove) Token: 0x06000071 RID: 113 RVA: 0x000031C8 File Offset: 0x000021C8
		public event global::AxSHDocVw.DWebBrowserEvents2_StatusTextChangeEventHandler StatusTextChange;

		// Token: 0x06000072 RID: 114 RVA: 0x000031EC File Offset: 0x000021EC
		public virtual void ShowBrowserBar(ref object pvaClsid)
		{
			if (this.ocx == null)
			{
				throw new global::System.Windows.Forms.AxHost.InvalidActiveXStateException("ShowBrowserBar", global::System.Windows.Forms.AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			object[] array = new object[]
			{
				pvaClsid,
				global::System.Reflection.Missing.Value,
				global::System.Reflection.Missing.Value
			};
			global::System.Type typeFromHandle = typeof(global::SHDocVw.IWebBrowser2);
			global::System.Reflection.MethodInfo method = typeFromHandle.GetMethod("ShowBrowserBar");
			method.Invoke(this.ocx, array);
			pvaClsid = array[0];
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00003258 File Offset: 0x00002258
		public virtual void ShowBrowserBar(ref object pvaClsid, ref object pvarShow, ref object pvarSize)
		{
			if (this.ocx == null)
			{
				throw new global::System.Windows.Forms.AxHost.InvalidActiveXStateException("ShowBrowserBar", global::System.Windows.Forms.AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.ShowBrowserBar(ref pvaClsid, ref pvarShow, ref pvarSize);
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00003288 File Offset: 0x00002288
		public virtual void ExecWB(global::SHDocVw.OLECMDID cmdID, global::SHDocVw.OLECMDEXECOPT cmdexecopt)
		{
			if (this.ocx == null)
			{
				throw new global::System.Windows.Forms.AxHost.InvalidActiveXStateException("ExecWB", global::System.Windows.Forms.AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			object[] parameters = new object[]
			{
				cmdID,
				cmdexecopt,
				global::System.Reflection.Missing.Value,
				global::System.Reflection.Missing.Value
			};
			global::System.Type typeFromHandle = typeof(global::SHDocVw.IWebBrowser2);
			global::System.Reflection.MethodInfo method = typeFromHandle.GetMethod("ExecWB");
			method.Invoke(this.ocx, parameters);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x000032FC File Offset: 0x000022FC
		public virtual void ExecWB(global::SHDocVw.OLECMDID cmdID, global::SHDocVw.OLECMDEXECOPT cmdexecopt, ref object pvaIn, ref object pvaOut)
		{
			if (this.ocx == null)
			{
				throw new global::System.Windows.Forms.AxHost.InvalidActiveXStateException("ExecWB", global::System.Windows.Forms.AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.ExecWB(cmdID, cmdexecopt, ref pvaIn, ref pvaOut);
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00003330 File Offset: 0x00002330
		public virtual global::SHDocVw.OLECMDF QueryStatusWB(global::SHDocVw.OLECMDID cmdID)
		{
			if (this.ocx == null)
			{
				throw new global::System.Windows.Forms.AxHost.InvalidActiveXStateException("QueryStatusWB", global::System.Windows.Forms.AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.QueryStatusWB(cmdID);
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00003360 File Offset: 0x00002360
		public virtual void Navigate2(ref object uRL)
		{
			if (this.ocx == null)
			{
				throw new global::System.Windows.Forms.AxHost.InvalidActiveXStateException("Navigate2", global::System.Windows.Forms.AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			object[] array = new object[]
			{
				uRL,
				global::System.Reflection.Missing.Value,
				global::System.Reflection.Missing.Value,
				global::System.Reflection.Missing.Value,
				global::System.Reflection.Missing.Value
			};
			global::System.Type typeFromHandle = typeof(global::SHDocVw.IWebBrowser2);
			global::System.Reflection.MethodInfo method = typeFromHandle.GetMethod("Navigate2");
			method.Invoke(this.ocx, array);
			uRL = array[0];
		}

		// Token: 0x06000078 RID: 120 RVA: 0x000033DC File Offset: 0x000023DC
		public virtual void Navigate2(ref object uRL, ref object flags, ref object targetFrameName, ref object postData, ref object headers)
		{
			if (this.ocx == null)
			{
				throw new global::System.Windows.Forms.AxHost.InvalidActiveXStateException("Navigate2", global::System.Windows.Forms.AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.Navigate2(ref uRL, ref flags, ref targetFrameName, ref postData, ref headers);
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00003410 File Offset: 0x00002410
		public virtual object GetProperty(string property)
		{
			if (this.ocx == null)
			{
				throw new global::System.Windows.Forms.AxHost.InvalidActiveXStateException("GetProperty", global::System.Windows.Forms.AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.GetProperty(property);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00003440 File Offset: 0x00002440
		public virtual void PutProperty(string property, object vtValue)
		{
			if (this.ocx == null)
			{
				throw new global::System.Windows.Forms.AxHost.InvalidActiveXStateException("PutProperty", global::System.Windows.Forms.AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.PutProperty(property, vtValue);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00003470 File Offset: 0x00002470
		public virtual void ClientToWindow(ref int pcx, ref int pcy)
		{
			if (this.ocx == null)
			{
				throw new global::System.Windows.Forms.AxHost.InvalidActiveXStateException("ClientToWindow", global::System.Windows.Forms.AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.ClientToWindow(ref pcx, ref pcy);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x000034A0 File Offset: 0x000024A0
		public virtual void Quit()
		{
			if (this.ocx == null)
			{
				throw new global::System.Windows.Forms.AxHost.InvalidActiveXStateException("Quit", global::System.Windows.Forms.AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.Quit();
		}

		// Token: 0x0600007D RID: 125 RVA: 0x000034CC File Offset: 0x000024CC
		public virtual void Stop()
		{
			if (this.ocx == null)
			{
				throw new global::System.Windows.Forms.AxHost.InvalidActiveXStateException("Stop", global::System.Windows.Forms.AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.Stop();
		}

		// Token: 0x0600007E RID: 126 RVA: 0x000034F8 File Offset: 0x000024F8
		public virtual void Refresh2()
		{
			if (this.ocx == null)
			{
				throw new global::System.Windows.Forms.AxHost.InvalidActiveXStateException("Refresh2", global::System.Windows.Forms.AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			object[] parameters = new object[]
			{
				global::System.Reflection.Missing.Value
			};
			global::System.Type typeFromHandle = typeof(global::SHDocVw.IWebBrowser2);
			global::System.Reflection.MethodInfo method = typeFromHandle.GetMethod("Refresh2");
			method.Invoke(this.ocx, parameters);
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00003550 File Offset: 0x00002550
		public virtual void Refresh2(ref object level)
		{
			if (this.ocx == null)
			{
				throw new global::System.Windows.Forms.AxHost.InvalidActiveXStateException("Refresh2", global::System.Windows.Forms.AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.Refresh2(ref level);
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00003580 File Offset: 0x00002580
		public virtual void CtlRefresh()
		{
			if (this.ocx == null)
			{
				throw new global::System.Windows.Forms.AxHost.InvalidActiveXStateException("CtlRefresh", global::System.Windows.Forms.AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.Refresh();
		}

		// Token: 0x06000081 RID: 129 RVA: 0x000035AC File Offset: 0x000025AC
		public virtual void Navigate(string uRL)
		{
			if (this.ocx == null)
			{
				throw new global::System.Windows.Forms.AxHost.InvalidActiveXStateException("Navigate", global::System.Windows.Forms.AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			object[] parameters = new object[]
			{
				uRL,
				global::System.Reflection.Missing.Value,
				global::System.Reflection.Missing.Value,
				global::System.Reflection.Missing.Value,
				global::System.Reflection.Missing.Value
			};
			global::System.Type typeFromHandle = typeof(global::SHDocVw.IWebBrowser2);
			global::System.Reflection.MethodInfo method = typeFromHandle.GetMethod("Navigate");
			method.Invoke(this.ocx, parameters);
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00003620 File Offset: 0x00002620
		public virtual void Navigate(string uRL, ref object flags, ref object targetFrameName, ref object postData, ref object headers)
		{
			if (this.ocx == null)
			{
				throw new global::System.Windows.Forms.AxHost.InvalidActiveXStateException("Navigate", global::System.Windows.Forms.AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.Navigate(uRL, ref flags, ref targetFrameName, ref postData, ref headers);
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00003654 File Offset: 0x00002654
		public virtual void GoSearch()
		{
			if (this.ocx == null)
			{
				throw new global::System.Windows.Forms.AxHost.InvalidActiveXStateException("GoSearch", global::System.Windows.Forms.AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.GoSearch();
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00003680 File Offset: 0x00002680
		public virtual void GoHome()
		{
			if (this.ocx == null)
			{
				throw new global::System.Windows.Forms.AxHost.InvalidActiveXStateException("GoHome", global::System.Windows.Forms.AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.GoHome();
		}

		// Token: 0x06000085 RID: 133 RVA: 0x000036AC File Offset: 0x000026AC
		public virtual void GoForward()
		{
			if (this.ocx == null)
			{
				throw new global::System.Windows.Forms.AxHost.InvalidActiveXStateException("GoForward", global::System.Windows.Forms.AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.GoForward();
		}

		// Token: 0x06000086 RID: 134 RVA: 0x000036D8 File Offset: 0x000026D8
		public virtual void GoBack()
		{
			if (this.ocx == null)
			{
				throw new global::System.Windows.Forms.AxHost.InvalidActiveXStateException("GoBack", global::System.Windows.Forms.AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.GoBack();
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00003704 File Offset: 0x00002704
		protected override void CreateSink()
		{
			try
			{
				this.eventMulticaster = new global::AxSHDocVw.AxWebBrowserEventMulticaster(this);
				this.cookie = new global::System.Windows.Forms.AxHost.ConnectionPointCookie(this.ocx, this.eventMulticaster, typeof(global::SHDocVw.DWebBrowserEvents2));
			}
			catch (global::System.Exception)
			{
			}
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00003760 File Offset: 0x00002760
		protected override void DetachSink()
		{
			try
			{
				this.cookie.Disconnect();
			}
			catch (global::System.Exception)
			{
			}
		}

		// Token: 0x06000089 RID: 137 RVA: 0x0000379C File Offset: 0x0000279C
		protected override void AttachInterfaces()
		{
			try
			{
				this.ocx = (global::SHDocVw.IWebBrowser2)base.GetOcx();
			}
			catch (global::System.Exception)
			{
			}
		}

		// Token: 0x0600008A RID: 138 RVA: 0x000037DC File Offset: 0x000027DC
		internal void RaiseOnPrivacyImpactedStateChange(object sender, global::AxSHDocVw.DWebBrowserEvents2_PrivacyImpactedStateChangeEvent e)
		{
			if (this.PrivacyImpactedStateChange != null)
			{
				this.PrivacyImpactedStateChange(sender, e);
			}
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00003800 File Offset: 0x00002800
		internal void RaiseOnUpdatePageStatus(object sender, global::AxSHDocVw.DWebBrowserEvents2_UpdatePageStatusEvent e)
		{
			if (this.UpdatePageStatus != null)
			{
				this.UpdatePageStatus(sender, e);
			}
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00003824 File Offset: 0x00002824
		internal void RaiseOnPrintTemplateTeardown(object sender, global::AxSHDocVw.DWebBrowserEvents2_PrintTemplateTeardownEvent e)
		{
			if (this.PrintTemplateTeardown != null)
			{
				this.PrintTemplateTeardown(sender, e);
			}
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00003848 File Offset: 0x00002848
		internal void RaiseOnPrintTemplateInstantiation(object sender, global::AxSHDocVw.DWebBrowserEvents2_PrintTemplateInstantiationEvent e)
		{
			if (this.PrintTemplateInstantiation != null)
			{
				this.PrintTemplateInstantiation(sender, e);
			}
		}

		// Token: 0x0600008E RID: 142 RVA: 0x0000386C File Offset: 0x0000286C
		internal void RaiseOnNavigateError(object sender, global::AxSHDocVw.DWebBrowserEvents2_NavigateErrorEvent e)
		{
			if (this.NavigateError != null)
			{
				this.NavigateError(sender, e);
			}
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00003890 File Offset: 0x00002890
		internal void RaiseOnFileDownload(object sender, global::AxSHDocVw.DWebBrowserEvents2_FileDownloadEvent e)
		{
			if (this.FileDownload != null)
			{
				this.FileDownload(sender, e);
			}
		}

		// Token: 0x06000090 RID: 144 RVA: 0x000038B4 File Offset: 0x000028B4
		internal void RaiseOnSetSecureLockIcon(object sender, global::AxSHDocVw.DWebBrowserEvents2_SetSecureLockIconEvent e)
		{
			if (this.SetSecureLockIcon != null)
			{
				this.SetSecureLockIcon(sender, e);
			}
		}

		// Token: 0x06000091 RID: 145 RVA: 0x000038D8 File Offset: 0x000028D8
		internal void RaiseOnClientToHostWindow(object sender, global::AxSHDocVw.DWebBrowserEvents2_ClientToHostWindowEvent e)
		{
			if (this.ClientToHostWindow != null)
			{
				this.ClientToHostWindow(sender, e);
			}
		}

		// Token: 0x06000092 RID: 146 RVA: 0x000038FC File Offset: 0x000028FC
		internal void RaiseOnWindowClosing(object sender, global::AxSHDocVw.DWebBrowserEvents2_WindowClosingEvent e)
		{
			if (this.WindowClosing != null)
			{
				this.WindowClosing(sender, e);
			}
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00003920 File Offset: 0x00002920
		internal void RaiseOnWindowSetHeight(object sender, global::AxSHDocVw.DWebBrowserEvents2_WindowSetHeightEvent e)
		{
			if (this.WindowSetHeight != null)
			{
				this.WindowSetHeight(sender, e);
			}
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00003944 File Offset: 0x00002944
		internal void RaiseOnWindowSetWidth(object sender, global::AxSHDocVw.DWebBrowserEvents2_WindowSetWidthEvent e)
		{
			if (this.WindowSetWidth != null)
			{
				this.WindowSetWidth(sender, e);
			}
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00003968 File Offset: 0x00002968
		internal void RaiseOnWindowSetTop(object sender, global::AxSHDocVw.DWebBrowserEvents2_WindowSetTopEvent e)
		{
			if (this.WindowSetTop != null)
			{
				this.WindowSetTop(sender, e);
			}
		}

		// Token: 0x06000096 RID: 150 RVA: 0x0000398C File Offset: 0x0000298C
		internal void RaiseOnWindowSetLeft(object sender, global::AxSHDocVw.DWebBrowserEvents2_WindowSetLeftEvent e)
		{
			if (this.WindowSetLeft != null)
			{
				this.WindowSetLeft(sender, e);
			}
		}

		// Token: 0x06000097 RID: 151 RVA: 0x000039B0 File Offset: 0x000029B0
		internal void RaiseOnWindowSetResizable(object sender, global::AxSHDocVw.DWebBrowserEvents2_WindowSetResizableEvent e)
		{
			if (this.WindowSetResizable != null)
			{
				this.WindowSetResizable(sender, e);
			}
		}

		// Token: 0x06000098 RID: 152 RVA: 0x000039D4 File Offset: 0x000029D4
		internal void RaiseOnOnTheaterMode(object sender, global::AxSHDocVw.DWebBrowserEvents2_OnTheaterModeEvent e)
		{
			if (this.OnTheaterMode != null)
			{
				this.OnTheaterMode(sender, e);
			}
		}

		// Token: 0x06000099 RID: 153 RVA: 0x000039F8 File Offset: 0x000029F8
		internal void RaiseOnOnFullScreen(object sender, global::AxSHDocVw.DWebBrowserEvents2_OnFullScreenEvent e)
		{
			if (this.OnFullScreen != null)
			{
				this.OnFullScreen(sender, e);
			}
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00003A1C File Offset: 0x00002A1C
		internal void RaiseOnOnStatusBar(object sender, global::AxSHDocVw.DWebBrowserEvents2_OnStatusBarEvent e)
		{
			if (this.OnStatusBar != null)
			{
				this.OnStatusBar(sender, e);
			}
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00003A40 File Offset: 0x00002A40
		internal void RaiseOnOnMenuBar(object sender, global::AxSHDocVw.DWebBrowserEvents2_OnMenuBarEvent e)
		{
			if (this.OnMenuBar != null)
			{
				this.OnMenuBar(sender, e);
			}
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00003A64 File Offset: 0x00002A64
		internal void RaiseOnOnToolBar(object sender, global::AxSHDocVw.DWebBrowserEvents2_OnToolBarEvent e)
		{
			if (this.OnToolBar != null)
			{
				this.OnToolBar(sender, e);
			}
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00003A88 File Offset: 0x00002A88
		internal void RaiseOnOnVisible(object sender, global::AxSHDocVw.DWebBrowserEvents2_OnVisibleEvent e)
		{
			if (this.OnVisible != null)
			{
				this.OnVisible(sender, e);
			}
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00003AAC File Offset: 0x00002AAC
		internal void RaiseOnOnQuit(object sender, global::System.EventArgs e)
		{
			if (this.OnQuit != null)
			{
				this.OnQuit(sender, e);
			}
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00003AD0 File Offset: 0x00002AD0
		internal void RaiseOnDocumentComplete(object sender, global::AxSHDocVw.DWebBrowserEvents2_DocumentCompleteEvent e)
		{
			if (this.DocumentComplete != null)
			{
				this.DocumentComplete(sender, e);
			}
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00003AF4 File Offset: 0x00002AF4
		internal void RaiseOnNavigateComplete2(object sender, global::AxSHDocVw.DWebBrowserEvents2_NavigateComplete2Event e)
		{
			if (this.NavigateComplete2 != null)
			{
				this.NavigateComplete2(sender, e);
			}
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00003B18 File Offset: 0x00002B18
		internal void RaiseOnNewWindow2(object sender, global::AxSHDocVw.DWebBrowserEvents2_NewWindow2Event e)
		{
			if (this.NewWindow2 != null)
			{
				this.NewWindow2(sender, e);
			}
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00003B3C File Offset: 0x00002B3C
		internal void RaiseOnBeforeNavigate2(object sender, global::AxSHDocVw.DWebBrowserEvents2_BeforeNavigate2Event e)
		{
			if (this.BeforeNavigate2 != null)
			{
				this.BeforeNavigate2(sender, e);
			}
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00003B60 File Offset: 0x00002B60
		internal void RaiseOnPropertyChange(object sender, global::AxSHDocVw.DWebBrowserEvents2_PropertyChangeEvent e)
		{
			if (this.PropertyChange != null)
			{
				this.PropertyChange(sender, e);
			}
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00003B84 File Offset: 0x00002B84
		internal void RaiseOnTitleChange(object sender, global::AxSHDocVw.DWebBrowserEvents2_TitleChangeEvent e)
		{
			if (this.TitleChange != null)
			{
				this.TitleChange(sender, e);
			}
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00003BA8 File Offset: 0x00002BA8
		internal void RaiseOnDownloadComplete(object sender, global::System.EventArgs e)
		{
			if (this.DownloadComplete != null)
			{
				this.DownloadComplete(sender, e);
			}
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00003BCC File Offset: 0x00002BCC
		internal void RaiseOnDownloadBegin(object sender, global::System.EventArgs e)
		{
			if (this.DownloadBegin != null)
			{
				this.DownloadBegin(sender, e);
			}
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00003BF0 File Offset: 0x00002BF0
		internal void RaiseOnCommandStateChange(object sender, global::AxSHDocVw.DWebBrowserEvents2_CommandStateChangeEvent e)
		{
			if (this.CommandStateChange != null)
			{
				this.CommandStateChange(sender, e);
			}
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00003C14 File Offset: 0x00002C14
		internal void RaiseOnProgressChange(object sender, global::AxSHDocVw.DWebBrowserEvents2_ProgressChangeEvent e)
		{
			if (this.ProgressChange != null)
			{
				this.ProgressChange(sender, e);
			}
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00003C38 File Offset: 0x00002C38
		internal void RaiseOnStatusTextChange(object sender, global::AxSHDocVw.DWebBrowserEvents2_StatusTextChangeEvent e)
		{
			if (this.StatusTextChange != null)
			{
				this.StatusTextChange(sender, e);
			}
		}

		// Token: 0x04000001 RID: 1
		private global::SHDocVw.IWebBrowser2 ocx;

		// Token: 0x04000002 RID: 2
		private global::AxSHDocVw.AxWebBrowserEventMulticaster eventMulticaster;

		// Token: 0x04000003 RID: 3
		private global::System.Windows.Forms.AxHost.ConnectionPointCookie cookie;
	}
}
