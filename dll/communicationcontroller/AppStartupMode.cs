using System;
using System.Configuration;
using System.Linq;

namespace CommunicationController
{
	// Token: 0x02000003 RID: 3
	public class AppStartupMode
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000004 RID: 4 RVA: 0x0000211C File Offset: 0x0000111C
		// (set) Token: 0x06000005 RID: 5 RVA: 0x00002164 File Offset: 0x00001164
		public static bool IsRMCCall
		{
			get
			{
				switch (1 == 1)
				{
				}
				if (true)
				{
				}
				if (false)
				{
				}
				return global::CommunicationController.AppStartupMode.a.b;
			}
			set
			{
				switch (1 == 1)
				{
				}
				if (true)
				{
				}
				if (false)
				{
				}
				global::CommunicationController.AppStartupMode.a.b = value;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000006 RID: 6 RVA: 0x000021AC File Offset: 0x000011AC
		// (set) Token: 0x06000007 RID: 7 RVA: 0x000021F4 File Offset: 0x000011F4
		public static bool IsUpdatecall
		{
			get
			{
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				if (true)
				{
				}
				return global::CommunicationController.AppStartupMode.a.c;
			}
			set
			{
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				if (true)
				{
				}
				global::CommunicationController.AppStartupMode.a.c = value;
			}
		}

		// Token: 0x06000008 RID: 8 RVA: 0x0000223C File Offset: 0x0000123C
		private AppStartupMode()
		{
			this.d = global::CommunicationController.StartUpMode.Standalone;
			global::CommunicationController.StartUpMode startUpMode;
			if (global::System.Configuration.ConfigurationManager.AppSettings.AllKeys.Contains("StartMode") && global::System.Enum.TryParse<global::CommunicationController.StartUpMode>(global::System.Configuration.ConfigurationManager.AppSettings.Get("StartMode"), out startUpMode))
			{
				this.d = startUpMode;
			}
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002294 File Offset: 0x00001294
		static AppStartupMode()
		{
			switch (1 == 1)
			{
			}
			if (true)
			{
			}
			if (false)
			{
			}
			global::CommunicationController.AppStartupMode.a = new global::CommunicationController.AppStartupMode();
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000A RID: 10 RVA: 0x000022DC File Offset: 0x000012DC
		public static global::CommunicationController.StartUpMode AppMode
		{
			get
			{
				switch (1 == 1)
				{
				}
				if (true)
				{
				}
				if (false)
				{
				}
				return global::CommunicationController.AppStartupMode.a.d;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000B RID: 11 RVA: 0x00002324 File Offset: 0x00001324
		// (set) Token: 0x0600000C RID: 12 RVA: 0x0000236C File Offset: 0x0000136C
		public static bool ISSyncVA
		{
			get
			{
				switch (1 == 1)
				{
				}
				if (true)
				{
				}
				if (false)
				{
				}
				return global::CommunicationController.AppStartupMode.a.e;
			}
			set
			{
				switch (1 == 1)
				{
				}
				if (true)
				{
				}
				if (false)
				{
				}
				global::CommunicationController.AppStartupMode.a.e = value;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600000D RID: 13 RVA: 0x000023B4 File Offset: 0x000013B4
		// (set) Token: 0x0600000E RID: 14 RVA: 0x000023FC File Offset: 0x000013FC
		public static bool IsRMWrite
		{
			get
			{
				switch (1 == 1)
				{
				}
				if (true)
				{
				}
				if (false)
				{
				}
				return global::CommunicationController.AppStartupMode.a.f;
			}
			set
			{
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				if (true)
				{
				}
				global::CommunicationController.AppStartupMode.a.f = value;
			}
		}

		// Token: 0x04000003 RID: 3
		private static global::CommunicationController.AppStartupMode a;

		// Token: 0x04000004 RID: 4
		private bool b;

		// Token: 0x04000005 RID: 5
		private bool c;

		// Token: 0x04000006 RID: 6
		private global::CommunicationController.StartUpMode d;

		// Token: 0x04000007 RID: 7
		private bool e;

		// Token: 0x04000008 RID: 8
		private bool f;
	}
}
