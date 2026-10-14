using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace Motorola.Common.Communication.Properties
{
	// Token: 0x02000017 RID: 23
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x17000015 RID: 21
		// (get) Token: 0x060000F4 RID: 244 RVA: 0x000089A9 File Offset: 0x00006BA9
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x04000082 RID: 130
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
