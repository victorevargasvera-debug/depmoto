using System;
using System.Runtime.InteropServices;

namespace IshHandler
{
	// Token: 0x02000010 RID: 16
	internal class e
	{
		// Token: 0x0600006C RID: 108
		[global::System.Runtime.InteropServices.DllImport("IshController.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern void initByteToWrite(global::System.IntPtr A_0, ulong A_1);

		// Token: 0x0600006D RID: 109
		[global::System.Runtime.InteropServices.DllImport("IshController.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr GetIshMemoryData(global::System.IntPtr A_0);

		// Token: 0x0600006E RID: 110
		[global::System.Runtime.InteropServices.DllImport("IshController.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern void ReleaseIshMemory(global::System.IntPtr A_0);

		// Token: 0x0600006F RID: 111
		[global::System.Runtime.InteropServices.DllImport("IshController.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern void copyByteToBuff(global::System.IntPtr A_0, ref byte A_1, int A_2);

		// Token: 0x06000070 RID: 112
		[global::System.Runtime.InteropServices.DllImport("IshController.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "CreateMemory")]
		public static extern global::System.IntPtr a();

		// Token: 0x06000071 RID: 113
		[global::System.Runtime.InteropServices.DllImport("IshController.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr OpenIsh();

		// Token: 0x06000072 RID: 114
		[global::System.Runtime.InteropServices.DllImport("IshController.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr Close_Ish(global::System.IntPtr A_0);

		// Token: 0x06000073 RID: 115
		[global::System.Runtime.InteropServices.DllImport("IshController.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern void ReadISH(global::System.IntPtr A_0, ushort A_1, ushort A_2, out global::System.IntPtr A_3, out ulong A_4);

		// Token: 0x06000074 RID: 116
		[global::System.Runtime.InteropServices.DllImport("IshController.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern void WriteISH(global::System.IntPtr A_0, global::System.IntPtr A_1, ushort A_2, ushort A_3, ulong A_4);

		// Token: 0x06000075 RID: 117
		[global::System.Runtime.InteropServices.DllImport("IshController.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern bool TerminateISH(global::System.IntPtr A_0);

		// Token: 0x06000076 RID: 118
		[global::System.Runtime.InteropServices.DllImport("IshController.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "ReadVitualMemory")]
		public static extern void a(global::System.IntPtr A_0, uint A_1, uint A_2, out global::System.IntPtr A_3);

		// Token: 0x06000077 RID: 119
		[global::System.Runtime.InteropServices.DllImport("IshController.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "EraseVirtualMemory")]
		public static extern void a(global::System.IntPtr A_0, uint A_1, uint A_2);

		// Token: 0x06000078 RID: 120
		[global::System.Runtime.InteropServices.DllImport("IshController.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern uint initVirtualFlashMemory(global::System.IntPtr A_0);

		// Token: 0x06000079 RID: 121
		[global::System.Runtime.InteropServices.DllImport("IshController.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern void initDefaultISHHeaderPartition(global::System.IntPtr A_0, uint A_1);

		// Token: 0x0600007A RID: 122
		[global::System.Runtime.InteropServices.DllImport("IshController.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, CharSet = global::System.Runtime.InteropServices.CharSet.Unicode)]
		public static extern void ReadAllIsh(global::System.IntPtr A_0, string A_1);

		// Token: 0x0600007B RID: 123
		[global::System.Runtime.InteropServices.DllImport("IshController.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, CharSet = global::System.Runtime.InteropServices.CharSet.Unicode)]
		public static extern bool get_psdt_location(global::System.IntPtr A_0, string A_1, out uint A_2, out uint A_3);

		// Token: 0x0600007C RID: 124
		[global::System.Runtime.InteropServices.DllImport("IshController.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern void WriteAllISH();

		// Token: 0x0600007D RID: 125
		[global::System.Runtime.InteropServices.DllImport("IshController.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern void read_psdt(global::System.IntPtr A_0, global::IshHandler.a A_1, out ulong A_2, out ulong A_3, out ulong A_4, out ulong A_5, out ulong A_6, out ulong A_7, out ulong A_8, out ulong A_9, ulong A_10);

		// Token: 0x0600007E RID: 126
		[global::System.Runtime.InteropServices.DllImport("IshController.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, CharSet = global::System.Runtime.InteropServices.CharSet.Unicode)]
		public static extern void read_partition(global::System.IntPtr A_0, global::IshHandler.a A_1, out ulong A_2, out ulong A_3, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.AnsiBStr)] string A_4, ulong A_5);

		// Token: 0x0600007F RID: 127
		[global::System.Runtime.InteropServices.DllImport("IshController.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, CharSet = global::System.Runtime.InteropServices.CharSet.Unicode)]
		public static extern bool is_in_section(global::System.IntPtr A_0, uint A_1, string A_2);

		// Token: 0x06000080 RID: 128 RVA: 0x000172F0 File Offset: 0x000162F0
		public static bool a(global::System.IntPtr A_0, uint A_1)
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
			return false;
		}

		// Token: 0x06000081 RID: 129
		[global::System.Runtime.InteropServices.DllImport("IshController.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, CharSet = global::System.Runtime.InteropServices.CharSet.Unicode)]
		public static extern long WriteIshToSrec(global::System.IntPtr A_0, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.AnsiBStr)] string A_1, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.AnsiBStr)] string A_2);

		// Token: 0x06000082 RID: 130
		[global::System.Runtime.InteropServices.DllImport("IshController.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, CharSet = global::System.Runtime.InteropServices.CharSet.Unicode)]
		public static extern bool GetCheckSum(global::System.IntPtr A_0, out uint A_1, ulong A_2);

		// Token: 0x06000083 RID: 131
		[global::System.Runtime.InteropServices.DllImport("IshController.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, CharSet = global::System.Runtime.InteropServices.CharSet.Unicode)]
		public static extern void PutPSDTInMemory(global::System.IntPtr A_0, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.AnsiBStr)] string A_1, uint A_2);

		// Token: 0x06000084 RID: 132
		[global::System.Runtime.InteropServices.DllImport("IshController.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, CharSet = global::System.Runtime.InteropServices.CharSet.Unicode)]
		public static extern void PutCodeplugInMemory(global::System.IntPtr A_0, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.AnsiBStr)] string A_1, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.AnsiBStr)] string A_2, int A_3);

		// Token: 0x06000085 RID: 133
		[global::System.Runtime.InteropServices.DllImport("IshController.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern void SetBlockISHVersion(global::System.IntPtr A_0, ulong A_1, ulong A_2, int A_3);

		// Token: 0x06000086 RID: 134
		[global::System.Runtime.InteropServices.DllImport("IshController.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern void EraseCodeplugVirtualMemory(global::System.IntPtr A_0);

		// Token: 0x06000087 RID: 135
		[global::System.Runtime.InteropServices.DllImport("IshController.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern void BuildDefaultISHHeaders(global::System.IntPtr A_0);
	}
}
