using System;
using System.IO;
using System.Reflection;

namespace Common.Communication.Simulator
{
	// Token: 0x0200000E RID: 14
	public static class VRDefinitions
	{
		// Token: 0x0400001F RID: 31
		public static readonly string VirtualDeviceFolderName = "VirtualRadios";

		// Token: 0x04000020 RID: 32
		public static readonly string BaseFolder = global::System.IO.Path.GetDirectoryName(global::System.Reflection.Assembly.GetEntryAssembly().Location);

		// Token: 0x04000021 RID: 33
		public static readonly int WriteTime = 6;

		// Token: 0x04000022 RID: 34
		public static readonly int ReadTime = 3;

		// Token: 0x04000023 RID: 35
		public static readonly int UpgradeTime = 48;

		// Token: 0x04000024 RID: 36
		public static string VirtualDeviceFolder = global::System.IO.Path.Combine(global::Common.Communication.Simulator.VRDefinitions.BaseFolder, global::Common.Communication.Simulator.VRDefinitions.VirtualDeviceFolderName);

		// Token: 0x04000025 RID: 37
		public static readonly string UTBaseFolder = global::System.IO.Path.GetDirectoryName(global::System.Reflection.Assembly.GetExecutingAssembly().Location);
	}
}
