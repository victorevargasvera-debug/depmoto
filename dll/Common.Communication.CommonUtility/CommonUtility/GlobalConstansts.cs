using System;
using System.IO;

namespace Motorola.Common.Communication.CommonUtility
{
	// Token: 0x02000011 RID: 17
	public static class GlobalConstansts
	{
		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600004E RID: 78 RVA: 0x000034B4 File Offset: 0x000016B4
		public static string StorageFolder
		{
			get
			{
				return global::System.IO.Path.Combine(global::Motorola.Common.Communication.CommonUtility.GlobalConstansts.LogFilePath, "Storage");
			}
		}

		// Token: 0x04000040 RID: 64
		public const string ASTRO_VirtualRadio_PID = "99999";

		// Token: 0x04000041 RID: 65
		public const string PCR_VirtualRadio_PID = "99998";

		// Token: 0x04000042 RID: 66
		public const string Tetra_VirtualRadio_PID = "99997";

		// Token: 0x04000043 RID: 67
		public const string PBB_VirtualRadio_PID = "_PBB_VirtualDevice";

		// Token: 0x04000044 RID: 68
		public const string ProgramName = "Motorola Device Communication";

		// Token: 0x04000045 RID: 69
		public static string LogFilePath = global::System.Environment.GetFolderPath(global::System.Environment.SpecialFolder.CommonApplicationData) + "\\Motorola\\CommonCPS\\Motorola Device Communication";
	}
}
