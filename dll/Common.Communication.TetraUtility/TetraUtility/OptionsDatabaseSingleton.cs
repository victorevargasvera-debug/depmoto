using System;
using System.IO;

namespace Motorola.Common.Communication.TetraUtility
{
	// Token: 0x0200006D RID: 109
	public static class OptionsDatabaseSingleton
	{
		// Token: 0x06000289 RID: 649 RVA: 0x0000C60C File Offset: 0x0000A80C
		private static global::Motorola.Common.Communication.TetraUtility.IOptionsDatabase InitialDatabase()
		{
			return new global::Motorola.Common.Communication.TetraUtility.OptionsDatabaseImp
			{
				DatabasePath = global::System.IO.Path.Combine(global::Motorola.Common.Communication.TetraUtility.FileSystem.BinDir, "_user_options.dat")
			};
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x0600028A RID: 650 RVA: 0x0000C635 File Offset: 0x0000A835
		public static global::Motorola.Common.Communication.TetraUtility.IOptionsDatabase Instance
		{
			get
			{
				return global::Motorola.Common.Communication.TetraUtility.OptionsDatabaseSingleton._database;
			}
		}

		// Token: 0x040002FC RID: 764
		private static global::Motorola.Common.Communication.TetraUtility.IOptionsDatabase _database = global::Motorola.Common.Communication.TetraUtility.OptionsDatabaseSingleton.InitialDatabase();
	}
}
