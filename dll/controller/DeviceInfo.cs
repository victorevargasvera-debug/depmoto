using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml;
using custom_exception;
using DeviceUpdate;

namespace Controller
{
	// Token: 0x02000008 RID: 8
	public class DeviceInfo
	{
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600006B RID: 107 RVA: 0x0000C320 File Offset: 0x0000B320
		// (set) Token: 0x0600006C RID: 108 RVA: 0x0000C364 File Offset: 0x0000B364
		public bool IsGemstone
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
				return this.al;
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
				this.al = value;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600006D RID: 109 RVA: 0x0000C3A8 File Offset: 0x0000B3A8
		// (set) Token: 0x0600006E RID: 110 RVA: 0x0000C3EC File Offset: 0x0000B3EC
		public bool IsBahama
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
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
				return this.c4;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
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
				this.c4 = value;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600006F RID: 111 RVA: 0x0000C430 File Offset: 0x0000B430
		// (set) Token: 0x06000070 RID: 112 RVA: 0x0000C474 File Offset: 0x0000B474
		public string RadioType
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
				return this.am;
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
				this.am = value;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000071 RID: 113 RVA: 0x0000C4B8 File Offset: 0x0000B4B8
		// (set) Token: 0x06000072 RID: 114 RVA: 0x0000C4FC File Offset: 0x0000B4FC
		public bool ScriptCompressed
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
				return this.an;
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
				this.an = value;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000073 RID: 115 RVA: 0x0000C540 File Offset: 0x0000B540
		public global::System.Collections.Generic.List<string> ScriptFiles
		{
			get
			{
				int num = 1;
				for (;;)
				{
					switch (num)
					{
					case 0:
						goto IL_6F;
					case 2:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							if (false)
							{
							}
							this.ao = new global::System.Collections.Generic.List<string>();
							num = 0;
							continue;
						}
						break;
					}
					if (true)
					{
					}
					if (this.ao != null)
					{
						break;
					}
					num = 2;
				}
				IL_6F:
				return this.ao;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000074 RID: 116 RVA: 0x0000C5C4 File Offset: 0x0000B5C4
		// (set) Token: 0x06000075 RID: 117 RVA: 0x0000C608 File Offset: 0x0000B608
		public bool IsDspCapability
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
				return this.ap;
			}
			set
			{
				if (true)
				{
				}
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				this.ap = value;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000076 RID: 118 RVA: 0x0000C64C File Offset: 0x0000B64C
		// (set) Token: 0x06000077 RID: 119 RVA: 0x0000C690 File Offset: 0x0000B690
		public bool IsDigitalModel
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
				return this.aq;
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
				this.aq = value;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000078 RID: 120 RVA: 0x0000C6D4 File Offset: 0x0000B6D4
		// (set) Token: 0x06000079 RID: 121 RVA: 0x0000C718 File Offset: 0x0000B718
		public bool IsBootmode
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
				return this.ar;
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
				this.ar = value;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600007A RID: 122 RVA: 0x0000C75C File Offset: 0x0000B75C
		// (set) Token: 0x0600007B RID: 123 RVA: 0x0000C7A0 File Offset: 0x0000B7A0
		public string ConfigVersion
		{
			get
			{
				if (true)
				{
				}
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				return this.@as;
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
				this.@as = value;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600007C RID: 124 RVA: 0x0000C7E4 File Offset: 0x0000B7E4
		// (set) Token: 0x0600007D RID: 125 RVA: 0x0000C828 File Offset: 0x0000B828
		public bool UpdateConfiguration
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
				return this.at;
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
				this.at = value;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600007E RID: 126 RVA: 0x0000C86C File Offset: 0x0000B86C
		// (set) Token: 0x0600007F RID: 127 RVA: 0x0000C8B0 File Offset: 0x0000B8B0
		public bool ConfigurationCompressed
		{
			get
			{
				if (true)
				{
				}
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				return this.au;
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
				this.au = value;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000080 RID: 128 RVA: 0x0000C8F4 File Offset: 0x0000B8F4
		public string ConfigurationFile
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
				return this.av;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000081 RID: 129 RVA: 0x0000C938 File Offset: 0x0000B938
		// (set) Token: 0x06000082 RID: 130 RVA: 0x0000C97C File Offset: 0x0000B97C
		public string L3BootloaderVersion
		{
			get
			{
				if (true)
				{
				}
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				return this.aw;
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
				this.aw = value;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000083 RID: 131 RVA: 0x0000C9C0 File Offset: 0x0000B9C0
		// (set) Token: 0x06000084 RID: 132 RVA: 0x0000CA04 File Offset: 0x0000BA04
		public bool UpdateL3Bootloader
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
				return this.ax;
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
				this.ax = value;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000085 RID: 133 RVA: 0x0000CA48 File Offset: 0x0000BA48
		// (set) Token: 0x06000086 RID: 134 RVA: 0x0000CA8C File Offset: 0x0000BA8C
		public bool L3BootloaderCompressed
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
				return this.ay;
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
				this.ay = value;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000087 RID: 135 RVA: 0x0000CAD0 File Offset: 0x0000BAD0
		public string L3BootloaderFile
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
				return this.az;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000088 RID: 136 RVA: 0x0000CB14 File Offset: 0x0000BB14
		// (set) Token: 0x06000089 RID: 137 RVA: 0x0000CB58 File Offset: 0x0000BB58
		public string KernelVersion
		{
			get
			{
				if (true)
				{
				}
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				return this.a0;
			}
			set
			{
				if (true)
				{
				}
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				this.a0 = value;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600008A RID: 138 RVA: 0x0000CB9C File Offset: 0x0000BB9C
		// (set) Token: 0x0600008B RID: 139 RVA: 0x0000CBE0 File Offset: 0x0000BBE0
		public bool KernelCompressed
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
				return this.a1;
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
				this.a1 = value;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600008C RID: 140 RVA: 0x0000CC24 File Offset: 0x0000BC24
		// (set) Token: 0x0600008D RID: 141 RVA: 0x0000CC68 File Offset: 0x0000BC68
		public bool UpdateKernel
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
				return this.a2;
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
				this.a2 = value;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600008E RID: 142 RVA: 0x0000CCAC File Offset: 0x0000BCAC
		public string KernelFile
		{
			get
			{
				if (true)
				{
				}
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				return this.a3;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600008F RID: 143 RVA: 0x0000CCF0 File Offset: 0x0000BCF0
		// (set) Token: 0x06000090 RID: 144 RVA: 0x0000CD34 File Offset: 0x0000BD34
		public bool NeedPreUpgrade
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
				return this.a4;
			}
			set
			{
				if (true)
				{
				}
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				this.a4 = value;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000091 RID: 145 RVA: 0x0000CD78 File Offset: 0x0000BD78
		public string PreUpgradeFile
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
				return this.a5;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000092 RID: 146 RVA: 0x0000CDBC File Offset: 0x0000BDBC
		// (set) Token: 0x06000093 RID: 147 RVA: 0x0000CE00 File Offset: 0x0000BE00
		public bool PreUpgradeCompressed
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
				return this.a6;
			}
			set
			{
				if (true)
				{
				}
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				this.a6 = value;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000094 RID: 148 RVA: 0x0000CE44 File Offset: 0x0000BE44
		public global::DeviceUpdate.c.a PreUpgradeFileType
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
				return this.a7;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000095 RID: 149 RVA: 0x0000CE88 File Offset: 0x0000BE88
		// (set) Token: 0x06000096 RID: 150 RVA: 0x0000CECC File Offset: 0x0000BECC
		public bool App_UtilitiesCompressed
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
				return this.a8;
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
				this.a8 = value;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000097 RID: 151 RVA: 0x0000CF10 File Offset: 0x0000BF10
		public string App_UtilitiesFile
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
				return this.a9;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000098 RID: 152 RVA: 0x0000CF54 File Offset: 0x0000BF54
		// (set) Token: 0x06000099 RID: 153 RVA: 0x0000CF98 File Offset: 0x0000BF98
		public bool Control_HeadCompressed
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
				return this.ba;
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
				this.ba = value;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600009A RID: 154 RVA: 0x0000CFDC File Offset: 0x0000BFDC
		public string Control_HeadFile
		{
			get
			{
				if (true)
				{
				}
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				return this.bb;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600009B RID: 155 RVA: 0x0000D020 File Offset: 0x0000C020
		// (set) Token: 0x0600009C RID: 156 RVA: 0x0000D064 File Offset: 0x0000C064
		public bool File_Change_ListCompressed
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
				return this.bc;
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
				this.bc = value;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600009D RID: 157 RVA: 0x0000D0A8 File Offset: 0x0000C0A8
		public string File_Change_ListFile
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
				return this.bd;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600009E RID: 158 RVA: 0x0000D0EC File Offset: 0x0000C0EC
		// (set) Token: 0x0600009F RID: 159 RVA: 0x0000D130 File Offset: 0x0000C130
		public bool Global_MarkerCompressed
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
				return this.be;
			}
			set
			{
				if (true)
				{
				}
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				this.be = value;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x0000D174 File Offset: 0x0000C174
		public string Global_MarkerFile
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
				return this.bf;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x0000D1B8 File Offset: 0x0000C1B8
		// (set) Token: 0x060000A2 RID: 162 RVA: 0x0000D1FC File Offset: 0x0000C1FC
		public bool Data_ImageCompressed
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
				return this.bg;
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
				this.bg = value;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x0000D240 File Offset: 0x0000C240
		public string Data_ImageFile
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
				return this.bh;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x0000D284 File Offset: 0x0000C284
		public string PSMarkerFile
		{
			get
			{
				if (true)
				{
				}
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				return this.bi;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x0000D2C8 File Offset: 0x0000C2C8
		public bool PSMarkerCompressed
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
				return this.bj;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x0000D30C File Offset: 0x0000C30C
		public bool UpdatePSMarker
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
				return this.bk;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x0000D350 File Offset: 0x0000C350
		public global::System.Collections.Generic.List<string> FruFiles
		{
			get
			{
				if (true)
				{
				}
				int num = 2;
				for (;;)
				{
					switch (num)
					{
					case 0:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_71;
						default:
							if (false)
							{
							}
							this.bl = new global::System.Collections.Generic.List<string>();
							num = 1;
							continue;
						}
						break;
					case 1:
						goto IL_6F;
					}
					if (this.bl != null)
					{
						break;
					}
					num = 0;
				}
				IL_6F:
				IL_71:
				return this.bl;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x0000D3D4 File Offset: 0x0000C3D4
		// (set) Token: 0x060000A9 RID: 169 RVA: 0x0000D418 File Offset: 0x0000C418
		public bool PartitionTableCompressed
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
				return this.bm;
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
				this.bm = value;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000AA RID: 170 RVA: 0x0000D45C File Offset: 0x0000C45C
		public string PartitionTableFile
		{
			get
			{
				if (true)
				{
				}
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				return this.bn;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000AB RID: 171 RVA: 0x0000D4A0 File Offset: 0x0000C4A0
		// (set) Token: 0x060000AC RID: 172 RVA: 0x0000D4E4 File Offset: 0x0000C4E4
		public bool RFSCompressed
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
				return this.bo;
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
				this.bo = value;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000AD RID: 173 RVA: 0x0000D528 File Offset: 0x0000C528
		public string RfsFile
		{
			get
			{
				if (true)
				{
				}
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				return this.bp;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000AE RID: 174 RVA: 0x0000D56C File Offset: 0x0000C56C
		public string CfsSrec
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
				return this.bq;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000AF RID: 175 RVA: 0x0000D5B0 File Offset: 0x0000C5B0
		public string UdpSrec
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
				return this.br;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x0000D5F4 File Offset: 0x0000C5F4
		public string FtlAppSecCfsSrec
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
				return this.bs;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x0000D638 File Offset: 0x0000C638
		public string FtlTunSrec
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
				return this.bt;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x0000D67C File Offset: 0x0000C67C
		// (set) Token: 0x060000B3 RID: 179 RVA: 0x0000D6C0 File Offset: 0x0000C6C0
		public string DeviceUUID
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
				return this.bu;
			}
			set
			{
				if (true)
				{
				}
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				this.bu = value;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x0000D704 File Offset: 0x0000C704
		// (set) Token: 0x060000B5 RID: 181 RVA: 0x0000D748 File Offset: 0x0000C748
		public string strIp
		{
			get
			{
				if (true)
				{
				}
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				return this.bv;
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
				this.bv = value;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x0000D78C File Offset: 0x0000C78C
		// (set) Token: 0x060000B7 RID: 183 RVA: 0x0000D7D0 File Offset: 0x0000C7D0
		public string SelectedPak
		{
			get
			{
				if (true)
				{
				}
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				return this.bw;
			}
			set
			{
				if (true)
				{
				}
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				this.bw = value;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x0000D814 File Offset: 0x0000C814
		// (set) Token: 0x060000B9 RID: 185 RVA: 0x0000D858 File Offset: 0x0000C858
		public string strSerialNo
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
				return this.bx;
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
				this.bx = value;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000BA RID: 186 RVA: 0x0000D89C File Offset: 0x0000C89C
		// (set) Token: 0x060000BB RID: 187 RVA: 0x0000D8E0 File Offset: 0x0000C8E0
		public string strModelNo
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
				return this.by;
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
				this.by = value;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000BC RID: 188 RVA: 0x0000D924 File Offset: 0x0000C924
		// (set) Token: 0x060000BD RID: 189 RVA: 0x0000D968 File Offset: 0x0000C968
		public string Path
		{
			get
			{
				if (true)
				{
				}
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				return this.bz;
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
				this.bz = value;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000BE RID: 190 RVA: 0x0000D9AC File Offset: 0x0000C9AC
		// (set) Token: 0x060000BF RID: 191 RVA: 0x0000D9F0 File Offset: 0x0000C9F0
		public object objFZ
		{
			get
			{
				if (true)
				{
				}
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				return this.b0;
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
				this.b0 = value;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x0000DA34 File Offset: 0x0000CA34
		// (set) Token: 0x060000C1 RID: 193 RVA: 0x0000DA78 File Offset: 0x0000CA78
		public string BootLoader
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
				return this.b1;
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
				this.b1 = value;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x0000DABC File Offset: 0x0000CABC
		// (set) Token: 0x060000C3 RID: 195 RVA: 0x0000DB00 File Offset: 0x0000CB00
		public bool isDualBoard
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
				return this.b2;
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
				this.b2 = value;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x0000DB44 File Offset: 0x0000CB44
		// (set) Token: 0x060000C5 RID: 197 RVA: 0x0000DB88 File Offset: 0x0000CB88
		public string PSDTVersion
		{
			get
			{
				if (true)
				{
				}
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				return this.b3;
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
				this.b3 = value;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x0000DBCC File Offset: 0x0000CBCC
		public string RDLFile
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
				return this.b4;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000C7 RID: 199 RVA: 0x0000DC10 File Offset: 0x0000CC10
		public string PSDTFile
		{
			get
			{
				if (true)
				{
				}
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				return this.b5;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x0000DC54 File Offset: 0x0000CC54
		public string FieldMoveFile
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
				return this.b6;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x0000DC98 File Offset: 0x0000CC98
		public bool FWCompressed
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
				return this.b7;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000CA RID: 202 RVA: 0x0000DCDC File Offset: 0x0000CCDC
		public bool CPCompressed
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
				return this.b8;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000CB RID: 203 RVA: 0x0000DD20 File Offset: 0x0000CD20
		public bool StructFileCompressed
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
				return this.b9;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000CC RID: 204 RVA: 0x0000DD64 File Offset: 0x0000CD64
		public bool BLCompressed
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
				return this.ca;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000CD RID: 205 RVA: 0x0000DDA8 File Offset: 0x0000CDA8
		public bool PSDTCompressed
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
				return this.cb;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000CE RID: 206 RVA: 0x0000DDEC File Offset: 0x0000CDEC
		public bool RDLCompressed
		{
			get
			{
				if (true)
				{
				}
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				return this.cc;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000CF RID: 207 RVA: 0x0000DE30 File Offset: 0x0000CE30
		public bool FieldMoveCompressed
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
				return this.cd;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x0000DE74 File Offset: 0x0000CE74
		// (set) Token: 0x060000D1 RID: 209 RVA: 0x0000DEB8 File Offset: 0x0000CEB8
		public int SourceIshComp
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
				return this.ce;
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
				this.ce = value;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x0000DEFC File Offset: 0x0000CEFC
		// (set) Token: 0x060000D3 RID: 211 RVA: 0x0000DF40 File Offset: 0x0000CF40
		public string pakUUID
		{
			get
			{
				if (true)
				{
				}
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				return this.cf;
			}
			set
			{
				if (true)
				{
				}
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				this.cf = value;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x0000DF84 File Offset: 0x0000CF84
		// (set) Token: 0x060000D5 RID: 213 RVA: 0x0000DFC8 File Offset: 0x0000CFC8
		public int IshComp
		{
			get
			{
				if (true)
				{
				}
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				return this.cg;
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
				this.cg = value;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x0000E00C File Offset: 0x0000D00C
		public string FWFile1
		{
			get
			{
				if (true)
				{
				}
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				return this.ci;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x0000E050 File Offset: 0x0000D050
		public string FWFile2
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
				return this.cj;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x0000E094 File Offset: 0x0000D094
		public string AppSrec
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
				return this.ck;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x0000E0D8 File Offset: 0x0000D0D8
		public string SecSrec
		{
			get
			{
				if (true)
				{
				}
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				return this.cl;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060000DA RID: 218 RVA: 0x0000E11C File Offset: 0x0000D11C
		public string TuneSrec
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
				return this.cm;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060000DB RID: 219 RVA: 0x0000E160 File Offset: 0x0000D160
		public string UclSrec
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
				return this.cn;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060000DC RID: 220 RVA: 0x0000E1A4 File Offset: 0x0000D1A4
		// (set) Token: 0x060000DD RID: 221 RVA: 0x0000E1E8 File Offset: 0x0000D1E8
		public bool UpdatePSDT
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
				return this.co;
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
				this.co = value;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060000DE RID: 222 RVA: 0x0000E22C File Offset: 0x0000D22C
		// (set) Token: 0x060000DF RID: 223 RVA: 0x0000E270 File Offset: 0x0000D270
		public bool UpdateBL
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
				return this.cp;
			}
			set
			{
				if (true)
				{
				}
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				this.cp = value;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x0000E2B4 File Offset: 0x0000D2B4
		// (set) Token: 0x060000E1 RID: 225 RVA: 0x0000E2F8 File Offset: 0x0000D2F8
		public bool UpdateCP
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
				return this.cq;
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
				this.cq = value;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060000E2 RID: 226 RVA: 0x0000E33C File Offset: 0x0000D33C
		// (set) Token: 0x060000E3 RID: 227 RVA: 0x0000E380 File Offset: 0x0000D380
		public bool UpdateFW
		{
			get
			{
				if (true)
				{
				}
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				return this.cr;
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
				this.cr = value;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060000E4 RID: 228 RVA: 0x0000E3C4 File Offset: 0x0000D3C4
		// (set) Token: 0x060000E5 RID: 229 RVA: 0x0000E408 File Offset: 0x0000D408
		public bool AutoCorrect
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
				return this.cs;
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
				this.cs = value;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x0000E44C File Offset: 0x0000D44C
		// (set) Token: 0x060000E7 RID: 231 RVA: 0x0000E490 File Offset: 0x0000D490
		public string TargetCPVer
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
				return this.ct;
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
				this.ct = value;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x0000E4D4 File Offset: 0x0000D4D4
		// (set) Token: 0x060000E9 RID: 233 RVA: 0x0000E518 File Offset: 0x0000D518
		public string CPVersion
		{
			get
			{
				if (true)
				{
				}
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				return this.cu;
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
				this.cu = value;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060000EA RID: 234 RVA: 0x0000E55C File Offset: 0x0000D55C
		public string SourceStructFile
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
				return this.cv;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060000EB RID: 235 RVA: 0x0000E5A0 File Offset: 0x0000D5A0
		public string TargetStructFile
		{
			get
			{
				if (true)
				{
				}
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				return this.cw;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060000EC RID: 236 RVA: 0x0000E5E4 File Offset: 0x0000D5E4
		public string BLFile
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
				return this.cx;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060000ED RID: 237 RVA: 0x0000E628 File Offset: 0x0000D628
		// (set) Token: 0x060000EE RID: 238 RVA: 0x0000E66C File Offset: 0x0000D66C
		public string FWVersion
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
				return this.cy;
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
				this.cy = value;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060000EF RID: 239 RVA: 0x0000E6B0 File Offset: 0x0000D6B0
		// (set) Token: 0x060000F0 RID: 240 RVA: 0x0000E6F4 File Offset: 0x0000D6F4
		public string ProductType
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
				return this.cz;
			}
			set
			{
				if (true)
				{
				}
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				this.cz = value;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x0000E738 File Offset: 0x0000D738
		// (set) Token: 0x060000F2 RID: 242 RVA: 0x0000E77C File Offset: 0x0000D77C
		public bool IsDTPCfsEnable
		{
			get
			{
				if (true)
				{
				}
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				return this.c0;
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
				this.c0 = value;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x0000E7C0 File Offset: 0x0000D7C0
		// (set) Token: 0x060000F4 RID: 244 RVA: 0x0000E804 File Offset: 0x0000D804
		public bool IsDTACfsEnable
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
				return this.c1;
			}
			set
			{
				if (true)
				{
				}
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				this.c1 = value;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x0000E848 File Offset: 0x0000D848
		// (set) Token: 0x060000F6 RID: 246 RVA: 0x0000E88C File Offset: 0x0000D88C
		public bool IsDTPCapability
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
				return this.c2;
			}
			set
			{
				if (true)
				{
				}
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				this.c2 = value;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x0000E8D0 File Offset: 0x0000D8D0
		// (set) Token: 0x060000F8 RID: 248 RVA: 0x0000E914 File Offset: 0x0000D914
		public string FreqType
		{
			get
			{
				if (true)
				{
				}
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				return this.c3;
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
				this.c3 = value;
			}
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x0000E958 File Offset: 0x0000D958
		public DeviceInfo()
		{
			this.al = false;
			this.IsBahama = false;
			this.ar = false;
			this.a8 = false;
			this.a9 = string.Empty;
			this.ck = string.Empty;
			this.bs = string.Empty;
			this.bt = string.Empty;
			this.cs = false;
			this.ca = false;
			this.cx = string.Empty;
			this.b1 = string.Empty;
			this.bq = string.Empty;
			this.br = string.Empty;
			this.au = false;
			this.av = string.Empty;
			this.@as = string.Empty;
			this.ba = false;
			this.bb = string.Empty;
			this.b8 = false;
			this.cu = string.Empty;
			this.cy = string.Empty;
			this.bu = string.Empty;
			this.b2 = false;
			this.cd = false;
			this.b6 = string.Empty;
			this.ch = null;
			this.b7 = false;
			this.ci = string.Empty;
			this.cj = string.Empty;
			this.bv = string.Empty;
			this.cg = 0;
			this.a1 = false;
			this.a3 = string.Empty;
			this.a0 = string.Empty;
			this.ay = false;
			this.az = string.Empty;
			this.aw = string.Empty;
			this.b0 = null;
			this.cf = string.Empty;
			this.bm = false;
			this.bn = string.Empty;
			this.cb = false;
			this.b5 = string.Empty;
			this.b3 = string.Empty;
			this.cc = false;
			this.b4 = string.Empty;
			this.bo = false;
			this.bp = string.Empty;
			this.cl = string.Empty;
			this.bw = string.Empty;
			this.bx = string.Empty;
			this.ce = 0;
			this.cv = string.Empty;
			this.b9 = false;
			this.ct = string.Empty;
			this.cw = string.Empty;
			this.cm = string.Empty;
			this.cn = string.Empty;
			this.cp = false;
			this.at = false;
			this.cq = false;
			this.cr = false;
			this.a2 = false;
			this.ax = false;
			this.co = false;
			this.bz = string.Empty;
			this.be = false;
			this.bf = string.Empty;
			this.bg = false;
			this.bh = string.Empty;
			this.bc = false;
			this.bd = string.Empty;
			this.a4 = false;
			this.a6 = false;
			this.aq = false;
			this.ap = true;
		}

		// Token: 0x060000FA RID: 250 RVA: 0x0000EC28 File Offset: 0x0000DC28
		public void CheckUpdateInfo(global::System.Collections.ArrayList packages, bool isConvert, global::DeviceUpdate.e AvPak)
		{
			switch (0)
			{
			default:
			{
				global::Controller.PackageInfo packageInfo;
				string text2;
				for (;;)
				{
					string text = AvPak.g;
					int num = 18;
					for (;;)
					{
						decimal d;
						int num2;
						switch (num)
						{
						case 0:
							try
							{
								num = 2;
								for (;;)
								{
									switch (num)
									{
									case 1:
										goto IL_166;
									case 3:
										num = 1;
										continue;
									case 4:
									{
										global::System.Collections.Generic.List<global::Controller.PackageInfo>.Enumerator enumerator;
										if (!enumerator.MoveNext())
										{
											num = 3;
											continue;
										}
										global::Controller.PackageInfo value = enumerator.Current;
										packages.Add(value);
										num = 0;
										continue;
									}
									}
									IL_140:
									num = 4;
									continue;
									goto IL_140;
								}
								IL_166:
								goto IL_3AA;
							}
							finally
							{
								global::System.Collections.Generic.List<global::Controller.PackageInfo>.Enumerator enumerator;
								((global::System.IDisposable)enumerator).Dispose();
							}
							goto IL_179;
						case 1:
							if (!(d >= 7m))
							{
								num = 16;
								continue;
							}
							goto IL_3D5;
						case 2:
							goto IL_2CB;
						case 3:
							goto IL_A5;
						case 4:
							goto IL_D3;
						case 5:
							goto IL_3D5;
						case 6:
							goto IL_2CB;
						case 7:
							goto IL_311;
						case 8:
							if (d == 6m)
							{
								num = 9;
								continue;
							}
							goto IL_41E;
						case 9:
							goto IL_2C9;
						case 10:
							goto IL_229;
						case 11:
							this.bu = this.ConvertPackageProductNameToUUID(AvPak.o);
							num = 7;
							continue;
						case 12:
							if (!(packageInfo.FilePath == text))
							{
								num = 17;
								continue;
							}
							goto IL_D3;
						case 13:
							this.ch = new global::System.Collections.ArrayList();
							num = 10;
							continue;
						case 14:
							if (string.IsNullOrEmpty(this.bu))
							{
								num = 11;
								continue;
							}
							goto IL_179;
						case 15:
							if (num2 >= packages.Count)
							{
								num = 4;
								continue;
							}
							packageInfo = (packages[num2] as global::Controller.PackageInfo);
							num = 12;
							continue;
						case 16:
							num = 21;
							continue;
						case 17:
							num2++;
							num = 6;
							continue;
						case 18:
						{
							if (string.IsNullOrEmpty(text))
							{
								num = 3;
								continue;
							}
							global::System.Collections.Generic.List<global::Controller.PackageInfo> list = global::Controller.PackageInfo.ConvertToPackageInfoList(new global::System.Collections.ArrayList
							{
								AvPak
							});
							packageInfo = null;
							num = 22;
							continue;
						}
						case 19:
							if (this.ch == null)
							{
								num = 13;
								continue;
							}
							goto IL_229;
						case 20:
						{
							packages = new global::System.Collections.ArrayList();
							global::System.Collections.Generic.List<global::Controller.PackageInfo> list;
							global::System.Collections.Generic.List<global::Controller.PackageInfo>.Enumerator enumerator = list.GetEnumerator();
							num = 0;
							continue;
						}
						case 21:
							if (AvPak.f != null)
							{
								num = 5;
								continue;
							}
							num = 8;
							continue;
						case 22:
							if (packages != null)
							{
								goto IL_3AA;
							}
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_3AA;
							default:
								if (false)
								{
								}
								num = 20;
								continue;
							}
							break;
						}
						break;
						IL_D3:
						num = 19;
						continue;
						IL_229:
						this.cq = false;
						this.co = false;
						this.cp = false;
						this.cr = false;
						this.cs = true;
						this.ce = 0;
						text2 = global::System.IO.Path.ChangeExtension(text, ".lmx");
						d = decimal.Parse(AvPak.e, global::System.Globalization.NumberStyles.AllowDecimalPoint);
						num = 1;
						continue;
						IL_2CB:
						num = 15;
						continue;
						IL_3AA:
						num2 = 0;
						num = 2;
						continue;
						IL_3D5:
						num = 14;
					}
				}
				IL_A5:
				global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(2908U, base.GetType().ToString(), "CheckUpdateInfo", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
				throw ex;
				IL_179:
				if (true)
				{
				}
				this.a(packageInfo, text2, 1, isConvert, AvPak);
				global::System.IO.DirectoryInfo parent = global::System.IO.Directory.GetParent(text2);
				string str = AvPak.a;
				text2 = global::System.IO.Path.Combine(parent.Parent.FullName, str + ".lmx");
				this.a(packageInfo, text2, 2, isConvert, AvPak);
				return;
				IL_2C9:
				this.a(null, text2, 3, isConvert, AvPak);
				return;
				IL_311:
				goto IL_179;
				IL_41E:
				global::custom_exception.CCustomException ex2 = new global::custom_exception.CCustomException(2908U, base.GetType().ToString(), "CheckUpdateInfo", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
				throw ex2;
			}
			}
		}

		// Token: 0x060000FB RID: 251 RVA: 0x0000F090 File Offset: 0x0000E090
		private void a(global::Controller.PackageInfo A_0, string A_1, int A_2, bool A_3, global::DeviceUpdate.e A_4)
		{
			try
			{
				switch (0)
				{
				default:
				{
					int num = 0;
					for (;;)
					{
						switch (num)
						{
						case 1:
						{
							bool a_;
							bool a_2;
							try
							{
								for (;;)
								{
									string text = null;
									double num2 = 0.0;
									num = 137;
									for (;;)
									{
										global::System.Collections.ArrayList arrayList;
										global::System.Collections.ArrayList arrayList2;
										global::System.Xml.XmlTextReader xmlTextReader;
										string attribute;
										string text2;
										string text3;
										bool flag;
										int num3;
										string item;
										string value2;
										string attribute14;
										switch (num)
										{
										case 0:
											num = 274;
											continue;
										case 1:
											goto IL_245E;
										case 2:
											arrayList.Add("FORMAT");
											arrayList2.Add("FTL");
											num = 144;
											continue;
										case 3:
											if (!string.IsNullOrEmpty(A_4.w))
											{
												num = 236;
												continue;
											}
											goto IL_245E;
										case 4:
											if (xmlTextReader.Name.Equals("STRUCTURE_FILE"))
											{
												num = 242;
												continue;
											}
											num = 15;
											continue;
										case 5:
											this.ce = global::System.Convert.ToInt32(attribute, global::System.Globalization.CultureInfo.InvariantCulture);
											num = 56;
											continue;
										case 6:
										{
											if (this.bu == "AF5DAB63F4FC4926BB9000A6F18AF3DC")
											{
												num = 249;
												continue;
											}
											string attribute2 = xmlTextReader.GetAttribute("MODE");
											xmlTextReader.Read();
											num = 29;
											continue;
										}
										case 7:
											goto IL_D08;
										case 8:
										{
											string attribute2;
											if (this.a(attribute2))
											{
												num = 261;
												continue;
											}
											goto IL_13C6;
										}
										case 9:
											text2 = xmlTextReader.GetAttribute("COMPRESS");
											num = 27;
											continue;
										case 10:
											if ((A_2 & 1) == 1)
											{
												num = 151;
												continue;
											}
											goto IL_245E;
										case 11:
											num = 345;
											continue;
										case 12:
											if (string.IsNullOrEmpty(xmlTextReader.Value))
											{
												num = 243;
												continue;
											}
											this.cw = this.c(xmlTextReader.Value, text3);
											a_ = true;
											num = 53;
											continue;
										case 13:
											num = 312;
											continue;
										case 14:
										{
											string attribute3;
											if (attribute3.Equals("N"))
											{
												num = 170;
												continue;
											}
											this.cs = true;
											num = 183;
											continue;
										}
										case 15:
											if (xmlTextReader.HasAttributes)
											{
												num = 118;
												continue;
											}
											goto IL_1839;
										case 16:
											num = 14;
											continue;
										case 17:
											goto IL_16D8;
										case 18:
											if (!this.ar)
											{
												num = 217;
												continue;
											}
											goto IL_1808;
										case 19:
											goto IL_17A8;
										case 20:
											goto IL_12EC;
										case 21:
											goto IL_899;
										case 22:
											text2 = xmlTextReader.GetAttribute("COMPRESS");
											num = 126;
											continue;
										case 23:
											if ((A_2 & 1) == 1)
											{
												num = 167;
												continue;
											}
											goto IL_245E;
										case 24:
											this.a1 = true;
											num = 116;
											continue;
										case 25:
											flag = true;
											num = 98;
											continue;
										case 26:
											if (global::Controller.DeviceInfo.isParadiseLightRadio(this.DeviceUUID))
											{
												num = 152;
												continue;
											}
											goto IL_1D19;
										case 27:
											if (text2 == "Y")
											{
												num = 204;
												continue;
											}
											goto IL_1981;
										case 28:
										{
											string attribute4 = xmlTextReader.GetAttribute("PARTITION");
											string attribute5 = xmlTextReader.GetAttribute("VERSION");
											string attribute6 = xmlTextReader.GetAttribute("CPVERSION");
											num = 343;
											continue;
										}
										case 29:
											if (num3 == 0)
											{
												num = 225;
												continue;
											}
											num = 57;
											continue;
										case 30:
										{
											string attribute7;
											if (attribute7.Equals("pa_firmware", global::System.StringComparison.Ordinal))
											{
												num = 301;
												continue;
											}
											goto IL_1B3E;
										}
										case 31:
											goto IL_13DD;
										case 32:
											goto IL_29FC;
										case 33:
											num = 1;
											continue;
										case 34:
											this.cr = true;
											num = 66;
											continue;
										case 35:
											goto IL_1010;
										case 36:
											num = 108;
											continue;
										case 37:
											goto IL_10FD;
										case 38:
											if ((A_2 & 2) == 2)
											{
												num = 145;
												continue;
											}
											goto IL_245E;
										case 39:
											num = 26;
											continue;
										case 40:
											this.ay = true;
											num = 21;
											continue;
										case 41:
											num = 264;
											continue;
										case 42:
											if (global::Controller.DeviceInfo.isParadiseLightRadio(this.DeviceUUID))
											{
												num = 347;
												continue;
											}
											goto IL_26FF;
										case 43:
											this.cp = true;
											num = 139;
											continue;
										case 44:
											goto IL_1FFC;
										case 45:
											goto IL_165F;
										case 46:
											this.DeviceUUID = this.ConvertPackageProductNameToUUID(A_4.o);
											num = 127;
											continue;
										case 47:
											if (xmlTextReader.Name.Equals("BOOTSCRIPT"))
											{
												num = 33;
												continue;
											}
											num = 172;
											continue;
										case 48:
											if (text2 == "Y")
											{
												num = 317;
												continue;
											}
											goto IL_191E;
										case 49:
											goto IL_2CE6;
										case 50:
											goto IL_245E;
										case 51:
											if (!string.IsNullOrEmpty(this.cu))
											{
												num = 339;
												continue;
											}
											goto IL_10FD;
										case 52:
											goto IL_245E;
										case 53:
											if (!string.IsNullOrEmpty(this.cu))
											{
												num = 327;
												continue;
											}
											goto IL_2CE6;
										case 54:
											goto IL_D08;
										case 55:
											goto IL_D08;
										case 56:
											goto IL_2623;
										case 57:
											if (num3 == 1)
											{
												num = 149;
												continue;
											}
											goto IL_2659;
										case 58:
											if (!flag)
											{
												num = 25;
												continue;
											}
											item = string.Empty;
											num = 262;
											continue;
										case 59:
										{
											string attribute2;
											if (this.a(attribute2))
											{
												num = 251;
												continue;
											}
											goto IL_1010;
										}
										case 60:
											this.ci = (string.IsNullOrEmpty(this.ci) ? this.cj : this.ci);
											num = 277;
											continue;
										case 61:
										{
											xmlTextReader.Read();
											string value = xmlTextReader.Value;
											num = 119;
											continue;
										}
										case 62:
											text2 = xmlTextReader.GetAttribute("COMPRESS");
											num = 212;
											continue;
										case 63:
											if ((A_2 & 2) == 2)
											{
												num = 197;
												continue;
											}
											goto IL_245E;
										case 64:
											goto IL_188C;
										case 65:
											if ((A_2 & 2) == 2)
											{
												num = 295;
												continue;
											}
											goto IL_245E;
										case 66:
											goto IL_26FF;
										case 67:
											num = 93;
											continue;
										case 68:
											num = 189;
											continue;
										case 69:
											goto IL_2087;
										case 70:
											num = 260;
											continue;
										case 71:
											if ((A_2 & 2) == 2)
											{
												num = 22;
												continue;
											}
											goto IL_245E;
										case 72:
											this.cj = this.c(xmlTextReader.Value, text3);
											num = 192;
											continue;
										case 73:
											if ((A_2 & 2) == 2)
											{
												num = 259;
												continue;
											}
											goto IL_245E;
										case 74:
											this.co = true;
											num = 82;
											continue;
										case 75:
										{
											string attribute8;
											if (this.b(attribute8, this.@as))
											{
												num = 304;
												continue;
											}
											goto IL_EB3;
										}
										case 76:
											num = 311;
											continue;
										case 77:
											goto IL_245E;
										case 78:
											if (num2.CompareTo(11.0) < 0)
											{
												num = 131;
												continue;
											}
											text3 = xmlTextReader.GetAttribute("ENCODING");
											text2 = xmlTextReader.GetAttribute("COMPRESS");
											num = 329;
											continue;
										case 79:
											if ((A_2 & 2) == 2)
											{
												num = 9;
												continue;
											}
											goto IL_245E;
										case 80:
											goto IL_1C26;
										case 81:
											goto IL_245E;
										case 82:
											goto IL_84A;
										case 83:
											this.be = true;
											num = 184;
											continue;
										case 84:
										{
											string attribute3 = xmlTextReader.GetAttribute("AUTOCORRECT");
											num = 291;
											continue;
										}
										case 85:
											goto IL_6B9;
										case 86:
											if (string.IsNullOrEmpty(A_4.x))
											{
												num = 208;
												continue;
											}
											value2 = A_4.x;
											num = 64;
											continue;
										case 87:
											if ((A_2 & 2) == 2)
											{
												num = 226;
												continue;
											}
											goto IL_245E;
										case 88:
											goto IL_2E77;
										case 89:
											num = 94;
											continue;
										case 90:
											goto IL_1981;
										case 91:
											this.cd = true;
											num = 337;
											continue;
										case 92:
											if (!string.IsNullOrEmpty(xmlTextReader.Name))
											{
												num = 115;
												continue;
											}
											goto IL_245E;
										case 93:
										{
											string attribute9;
											string value3;
											if (attribute9.Equals(value3, global::System.StringComparison.OrdinalIgnoreCase))
											{
												num = 322;
												continue;
											}
											goto IL_2659;
										}
										case 94:
										{
											string name;
											if (name == "FILE")
											{
												num = 36;
												continue;
											}
											goto IL_1808;
										}
										case 95:
											num = 3;
											continue;
										case 96:
										{
											int num4;
											switch (num4)
											{
											case 0:
												xmlTextReader.Read();
												this.ck = this.c(xmlTextReader.Value, text3);
												num = 128;
												continue;
											case 1:
												xmlTextReader.Read();
												this.cl = this.c(xmlTextReader.Value, text3);
												num = 133;
												continue;
											case 2:
												xmlTextReader.Read();
												this.cm = this.c(xmlTextReader.Value, text3);
												num = 54;
												continue;
											case 3:
												xmlTextReader.Read();
												this.cn = this.c(xmlTextReader.Value, text3);
												num = 55;
												continue;
											case 4:
												xmlTextReader.Read();
												this.bq = this.c(xmlTextReader.Value, text3);
												num = 7;
												continue;
											case 5:
												xmlTextReader.Read();
												this.br = this.c(xmlTextReader.Value, text3);
												num = 263;
												continue;
											case 6:
												xmlTextReader.Read();
												this.bs = this.c(xmlTextReader.Value, text3);
												num = 222;
												continue;
											case 7:
												xmlTextReader.Read();
												this.bt = this.c(xmlTextReader.Value, text3);
												num = 307;
												continue;
											default:
												num = 70;
												continue;
											}
											break;
										}
										case 97:
											num = 266;
											continue;
										case 98:
											goto IL_2659;
										case 99:
											if (this.a7 == global::DeviceUpdate.c.a.f)
											{
												num = 141;
												continue;
											}
											goto IL_1FFC;
										case 100:
										{
											string attribute10;
											if (!this.b(attribute10, this.a0))
											{
												num = 111;
												continue;
											}
											goto IL_17A8;
										}
										case 101:
											this.an = true;
											num = 45;
											continue;
										case 102:
											if ((A_2 & 2) == 2)
											{
												num = 176;
												continue;
											}
											goto IL_245E;
										case 103:
											if (this.a4)
											{
												num = 299;
												continue;
											}
											goto IL_1FFC;
										case 104:
											goto IL_1C26;
										case 105:
										{
											string name2;
											int num5;
											if (global::e.a.TryGetValue(name2, out num5))
											{
												num = 110;
												continue;
											}
											goto IL_245E;
										}
										case 106:
											goto IL_FBA;
										case 107:
											if (text2 == "Y")
											{
												num = 83;
												continue;
											}
											goto IL_6FA;
										case 108:
											if (xmlTextReader.HasAttributes)
											{
												num = 28;
												continue;
											}
											goto IL_1808;
										case 109:
											text2 = xmlTextReader.GetAttribute("COMPRESS");
											num = 107;
											continue;
										case 110:
											num = 273;
											continue;
										case 111:
											this.a2 = true;
											num = 19;
											continue;
										case 112:
											if (xmlTextReader.NodeType.Equals(global::System.Xml.XmlNodeType.Element))
											{
												num = 0;
												continue;
											}
											goto IL_1808;
										case 113:
											if (text2 == "Y")
											{
												num = 338;
												continue;
											}
											goto IL_16D8;
										case 114:
											if (global::e.a == null)
											{
												num = 201;
												continue;
											}
											goto IL_28F7;
										case 115:
											num = 174;
											continue;
										case 116:
											goto IL_1B02;
										case 117:
											xmlTextReader.Read();
											num = 12;
											continue;
										case 118:
										{
											string attribute11 = xmlTextReader.GetAttribute("VERSION");
											num = 148;
											continue;
										}
										case 119:
											goto IL_245E;
										case 120:
											num = 52;
											continue;
										case 121:
											goto IL_245E;
										case 122:
											num = 350;
											continue;
										case 123:
											this.bc = true;
											num = 293;
											continue;
										case 124:
										{
											string attribute11;
											if (attribute11 == this.ct)
											{
												num = 117;
												continue;
											}
											goto IL_1839;
										}
										case 125:
											goto IL_FBA;
										case 126:
											if (text2 == "Y")
											{
												num = 101;
												continue;
											}
											this.an = false;
											num = 279;
											continue;
										case 127:
											goto IL_245E;
										case 128:
											goto IL_D08;
										case 129:
											xmlTextReader.Read();
											this.ScriptFiles.Add(this.c(xmlTextReader.Value, text3));
											num = 276;
											continue;
										case 130:
											if (text2 == "Y")
											{
												num = 331;
												continue;
											}
											goto IL_13DD;
										case 131:
											goto IL_15FA;
										case 132:
											goto IL_245E;
										case 133:
											goto IL_D08;
										case 134:
											goto IL_245E;
										case 135:
											goto IL_188C;
										case 136:
											goto IL_217E;
										case 137:
											goto IL_245E;
										case 138:
											this.ax = true;
											num = 153;
											continue;
										case 139:
											goto IL_1430;
										case 140:
											goto IL_2D62;
										case 141:
											goto IL_EB3;
										case 142:
											goto IL_1C3F;
										case 143:
											if (string.IsNullOrEmpty(this.ci))
											{
												num = 234;
												continue;
											}
											num = 219;
											continue;
										case 144:
											goto IL_2794;
										case 145:
											value2 = string.Empty;
											num = 86;
											continue;
										case 146:
											if (this.IsDspCapability != this.aq)
											{
												num = 302;
												continue;
											}
											goto IL_26FF;
										case 147:
											goto IL_2941;
										case 148:
										{
											string attribute11;
											if (attribute11 == this.cu)
											{
												num = 84;
												continue;
											}
											num = 124;
											continue;
										}
										case 149:
											num = 8;
											continue;
										case 150:
											if ((A_2 & 2) == 2)
											{
												num = 39;
												continue;
											}
											goto IL_245E;
										case 151:
											text2 = xmlTextReader.GetAttribute("COMPRESS");
											num = 196;
											continue;
										case 152:
											this.aq = global::Controller.DeviceInfo.b(A_4.j);
											num = 297;
											continue;
										case 153:
											goto IL_12B2;
										case 154:
											if (global::Controller.DeviceInfo.isParadiseLightRadio(this.DeviceUUID))
											{
												num = 286;
												continue;
											}
											goto IL_245E;
										case 155:
											goto IL_1C7B;
										case 156:
											if (xmlTextReader.Name.Equals("PREUPGRADE"))
											{
												num = 120;
												continue;
											}
											num = 112;
											continue;
										case 157:
											goto IL_26FF;
										case 158:
											goto IL_245E;
										case 159:
											if (text2 == "Y")
											{
												num = 244;
												continue;
											}
											goto IL_1C7B;
										case 160:
											if ((A_2 & 1) == 1)
											{
												num = 61;
												continue;
											}
											goto IL_245E;
										case 161:
											goto IL_245E;
										case 162:
											this.b2 = true;
											num = 290;
											continue;
										case 163:
											if (string.IsNullOrEmpty(this.DeviceUUID))
											{
												num = 46;
												continue;
											}
											goto IL_245E;
										case 164:
										{
											string attribute12 = xmlTextReader.GetAttribute("VERSION");
											num = 269;
											continue;
										}
										case 165:
											goto IL_23D2;
										case 166:
										{
											string attribute13;
											if (!this.b(attribute13, this.b3))
											{
												num = 74;
												continue;
											}
											goto IL_84A;
										}
										case 167:
											text2 = xmlTextReader.GetAttribute("COMPRESS");
											num = 268;
											continue;
										case 168:
											num = 181;
											continue;
										case 169:
											goto IL_245E;
										case 170:
											this.cs = false;
											num = 140;
											continue;
										case 171:
											goto IL_14C6;
										case 172:
											if (xmlTextReader.NodeType.Equals(global::System.Xml.XmlNodeType.Element))
											{
												num = 265;
												continue;
											}
											goto IL_2213;
										case 173:
											if (this.cy != attribute14)
											{
												num = 34;
												continue;
											}
											num = 42;
											continue;
										case 174:
											if (xmlTextReader.NodeType.Equals(global::System.Xml.XmlNodeType.Element))
											{
												num = 207;
												continue;
											}
											goto IL_245E;
										case 175:
										{
											string name3;
											if ((name3 = xmlTextReader.Name) != null)
											{
												num = 13;
												continue;
											}
											goto IL_2659;
										}
										case 176:
											this.bb = string.Empty;
											num = 213;
											continue;
										case 177:
											this.bi = this.c(xmlTextReader.Value, text3);
											this.bk = true;
											num = 314;
											continue;
										case 178:
											num = 341;
											continue;
										case 179:
											goto IL_191E;
										case 180:
											goto IL_245E;
										case 181:
										{
											string attribute5;
											if (!this.b(this.@as, attribute5))
											{
												num = 313;
												continue;
											}
											goto IL_1808;
										}
										case 182:
											if (xmlTextReader.NodeType.Equals(global::System.Xml.XmlNodeType.Element))
											{
												num = 253;
												continue;
											}
											goto IL_2659;
										case 183:
											goto IL_2D62;
										case 184:
											goto IL_6FA;
										case 185:
											goto IL_245E;
										case 186:
											goto IL_245E;
										case 187:
											goto IL_245E;
										case 188:
											if ((A_2 & 2) == 2)
											{
												num = 218;
												continue;
											}
											goto IL_245E;
										case 189:
										{
											string attribute15;
											if ((attribute15 = xmlTextReader.GetAttribute("PARTITION")) != null)
											{
												num = 11;
												continue;
											}
											goto IL_D08;
										}
										case 190:
										{
											string attribute16 = xmlTextReader.GetAttribute("VERSION");
											num = 296;
											continue;
										}
										case 191:
											if (text2 == "Y")
											{
												num = 198;
												continue;
											}
											goto IL_14C6;
										case 192:
											goto IL_2659;
										case 193:
											goto IL_245E;
										case 194:
											goto IL_2659;
										case 195:
											if (text2 == "Y")
											{
												num = 123;
												continue;
											}
											goto IL_2DC2;
										case 196:
											if (text2 == "Y")
											{
												num = 91;
												continue;
											}
											goto IL_1590;
										case 197:
											text2 = xmlTextReader.GetAttribute("COMPRESS");
											num = 223;
											continue;
										case 198:
											this.ba = true;
											num = 171;
											continue;
										case 199:
										{
											string attribute17 = xmlTextReader.GetAttribute("DUAL");
											num = 283;
											continue;
										}
										case 200:
											if (!xmlTextReader.Read())
											{
												num = 122;
												continue;
											}
											num = 92;
											continue;
										case 201:
											global::e.a = new global::System.Collections.Generic.Dictionary<string, int>(27)
											{
												{
													"FLASH_PACK",
													0
												},
												{
													"TANAPA",
													1
												},
												{
													"MODEL",
													2
												},
												{
													"CODEPLUG",
													3
												},
												{
													"STRUCTURE_FILE",
													4
												},
												{
													"FIELDMOVE_FILE",
													5
												},
												{
													"ISH_COMP",
													6
												},
												{
													"UUID",
													7
												},
												{
													"L2_BOOTLOADER",
													8
												},
												{
													"BOOTLOADER",
													9
												},
												{
													"RAMDLOADER",
													10
												},
												{
													"PSDT",
													11
												},
												{
													"FIRMWARE",
													12
												},
												{
													"CONFIGURATION",
													13
												},
												{
													"L3_BOOTLOADER",
													14
												},
												{
													"KERNEL",
													15
												},
												{
													"MBR",
													16
												},
												{
													"PARTITION_TABLE",
													17
												},
												{
													"ROOT_FILE_SYSTEM",
													18
												},
												{
													"BOOTSCRIPT",
													19
												},
												{
													"APP_UTILITIES",
													20
												},
												{
													"CONTROL_HEAD",
													21
												},
												{
													"PREUPGRADE",
													22
												},
												{
													"FILE_CHANGE_LIST",
													23
												},
												{
													"DATA_IMAGE",
													24
												},
												{
													"GLOBAL_MARKER",
													25
												},
												{
													"PSMARKER",
													26
												}
											};
											num = 235;
											continue;
										case 202:
											num = 193;
											continue;
										case 203:
											goto IL_10CA;
										case 204:
											this.cc = true;
											num = 90;
											continue;
										case 205:
											if (string.IsNullOrEmpty(xmlTextReader.Value))
											{
												num = 216;
												continue;
											}
											this.cv = this.c(xmlTextReader.Value, text3);
											a_2 = true;
											num = 51;
											continue;
										case 206:
											if ((A_2 & 2) == 2)
											{
												num = 164;
												continue;
											}
											goto IL_245E;
										case 207:
											num = 325;
											continue;
										case 208:
											value2 = "Plain";
											num = 135;
											continue;
										case 209:
											goto IL_10CA;
										case 210:
											text2 = xmlTextReader.GetAttribute("COMPRESS");
											num = 319;
											continue;
										case 211:
											goto IL_2794;
										case 212:
											if (text2 == "Y")
											{
												num = 229;
												continue;
											}
											goto IL_2340;
										case 213:
											if (!string.IsNullOrEmpty(A_4.w))
											{
												num = 285;
												continue;
											}
											goto IL_245E;
										case 214:
											goto IL_2487;
										case 215:
											goto IL_2659;
										case 216:
											a_2 = false;
											num = 284;
											continue;
										case 217:
											this.a7 = global::DeviceUpdate.c.a.f;
											this.a4 = true;
											num = 32;
											continue;
										case 218:
										{
											string attribute8 = xmlTextReader.GetAttribute("VERSION");
											num = 75;
											continue;
										}
										case 219:
											if (string.IsNullOrEmpty(this.cj))
											{
												num = 72;
												continue;
											}
											num = 58;
											continue;
										case 220:
											this.ca = true;
											num = 20;
											continue;
										case 221:
											global::e.b = new global::System.Collections.Generic.Dictionary<string, int>(8)
											{
												{
													"APP",
													0
												},
												{
													"SECURITY",
													1
												},
												{
													"TUNING",
													2
												},
												{
													"UCL",
													3
												},
												{
													"CFS",
													4
												},
												{
													"UDP",
													5
												},
												{
													"FTL_APP_SEC_CFS",
													6
												},
												{
													"FTL_TUNING",
													7
												}
											};
											num = 245;
											continue;
										case 222:
											goto IL_D08;
										case 223:
											if (text2 == "Y")
											{
												num = 305;
												continue;
											}
											goto IL_1C3F;
										case 224:
											if (this.cu == this.ct)
											{
												num = 49;
												continue;
											}
											goto IL_1C26;
										case 225:
											num = 59;
											continue;
										case 226:
											text2 = xmlTextReader.GetAttribute("COMPRESS");
											num = 310;
											continue;
										case 227:
											if ((A_2 & 2) == 2)
											{
												num = 109;
												continue;
											}
											goto IL_245E;
										case 228:
											num = 30;
											continue;
										case 229:
											this.bj = true;
											num = 321;
											continue;
										case 230:
											goto IL_245E;
										case 231:
											if (this.ar)
											{
												num = 2;
												continue;
											}
											arrayList.Add("FORMAT");
											arrayList2.Add("FileSystem");
											num = 211;
											continue;
										case 232:
											goto IL_2A2A;
										case 233:
											goto IL_2659;
										case 234:
											this.ci = this.c(xmlTextReader.Value, text3);
											num = 328;
											continue;
										case 235:
											goto IL_28F7;
										case 236:
											text2 = xmlTextReader.GetAttribute("COMPRESS");
											num = 195;
											continue;
										case 237:
											if (xmlTextReader.Name.Equals("CODEPLUG"))
											{
												num = 202;
												continue;
											}
											num = 308;
											continue;
										case 238:
											if (text2 == "Y")
											{
												num = 220;
												continue;
											}
											goto IL_12EC;
										case 239:
										{
											string name4;
											if ((name4 = xmlTextReader.Name) != null)
											{
												num = 76;
												continue;
											}
											goto IL_2213;
										}
										case 240:
											if ((A_2 & 2) == 2)
											{
												num = 210;
												continue;
											}
											goto IL_245E;
										case 241:
											if (A_4.ab)
											{
												num = 177;
												continue;
											}
											goto IL_245E;
										case 242:
											num = 230;
											continue;
										case 243:
											a_ = false;
											num = 80;
											continue;
										case 244:
											this.bg = true;
											num = 155;
											continue;
										case 245:
											goto IL_111C;
										case 246:
										{
											string attribute6;
											string text4;
											if (text4.Equals(attribute6, global::System.StringComparison.InvariantCulture))
											{
												num = 168;
												continue;
											}
											goto IL_29FC;
										}
										case 247:
											num = 6;
											continue;
										case 248:
											if (text2 == "Y")
											{
												num = 282;
												continue;
											}
											goto IL_2A2A;
										case 249:
										{
											string attribute7 = xmlTextReader.GetAttribute("TYPE");
											string attribute9 = xmlTextReader.GetAttribute("BAND");
											xmlTextReader.Read();
											num = 143;
											continue;
										}
										case 250:
											goto IL_2659;
										case 251:
											this.ci = this.c(xmlTextReader.Value, text3);
											num = 35;
											continue;
										case 252:
											this.a6 = true;
											num = 136;
											continue;
										case 253:
											num = 175;
											continue;
										case 254:
											xmlTextReader.GetAttribute("VERSION");
											xmlTextReader.Read();
											this.b4 = this.c(xmlTextReader.Value, text3);
											num = 121;
											continue;
										case 255:
											num = 114;
											continue;
										case 256:
											num = 96;
											continue;
										case 257:
											goto IL_2E77;
										case 258:
											if (!string.IsNullOrEmpty(attribute))
											{
												num = 5;
												continue;
											}
											this.ce = 0;
											num = 292;
											continue;
										case 259:
											num = 78;
											continue;
										case 260:
											goto IL_D08;
										case 261:
											this.cj = this.c(xmlTextReader.Value, text3);
											num = 271;
											continue;
										case 262:
										{
											string attribute7;
											if (!string.IsNullOrEmpty(attribute7))
											{
												num = 228;
												continue;
											}
											goto IL_1B3E;
										}
										case 263:
											goto IL_D08;
										case 264:
											goto IL_245E;
										case 265:
											num = 239;
											continue;
										case 266:
											goto IL_245E;
										case 267:
										{
											string value3;
											if (!string.IsNullOrEmpty(value3))
											{
												num = 67;
												continue;
											}
											goto IL_2659;
										}
										case 268:
											if (text2 == "Y")
											{
												num = 323;
												continue;
											}
											goto IL_2087;
										case 269:
										{
											string attribute12;
											if (this.aw != attribute12)
											{
												num = 138;
												continue;
											}
											goto IL_12B2;
										}
										case 270:
											xmlTextReader.Read();
											this.cg = global::System.Convert.ToInt32(xmlTextReader.Value, global::System.Globalization.CultureInfo.InvariantCulture);
											num = 134;
											continue;
										case 271:
											goto IL_13C6;
										case 272:
											goto IL_2487;
										case 273:
										{
											int num5;
											switch (num5)
											{
											case 0:
											{
												string attribute18 = xmlTextReader.GetAttribute("TEMPLATEVERSION");
												num2 = double.Parse(attribute18, global::System.Globalization.CultureInfo.InvariantCulture);
												num = 187;
												continue;
											}
											case 1:
												num = 318;
												continue;
											case 2:
												num = 160;
												continue;
											case 3:
												num = 306;
												continue;
											case 4:
												num = 23;
												continue;
											case 5:
												num = 10;
												continue;
											case 6:
												num = 334;
												continue;
											case 7:
												xmlTextReader.Read();
												this.pakUUID = xmlTextReader.Value;
												num = 163;
												continue;
											case 8:
											case 9:
												num = 333;
												continue;
											case 10:
												num = 79;
												continue;
											case 11:
												num = 65;
												continue;
											case 12:
												num = 150;
												continue;
											case 13:
												num = 188;
												continue;
											case 14:
												num = 206;
												continue;
											case 15:
												num = 294;
												continue;
											case 16:
											case 17:
												num = 63;
												continue;
											case 18:
												num = 87;
												continue;
											case 19:
												num = 71;
												continue;
											case 20:
												num = 240;
												continue;
											case 21:
												num = 102;
												continue;
											case 22:
												num = 73;
												continue;
											case 23:
												num = 303;
												continue;
											case 24:
												num = 38;
												continue;
											case 25:
												num = 227;
												continue;
											case 26:
												num = 287;
												continue;
											default:
												num = 41;
												continue;
											}
											break;
										}
										case 274:
										{
											string name;
											if ((name = xmlTextReader.Name) != null)
											{
												num = 89;
												continue;
											}
											goto IL_1808;
										}
										case 275:
											if (text2 == "Y")
											{
												num = 40;
												continue;
											}
											goto IL_899;
										case 276:
											goto IL_2213;
										case 277:
											goto IL_245E;
										case 278:
											num = 154;
											continue;
										case 279:
											goto IL_165F;
										case 280:
											if (this.cu == this.ct)
											{
												num = 37;
												continue;
											}
											goto IL_6B9;
										case 281:
											goto IL_1945;
										case 282:
											this.cb = true;
											num = 232;
											continue;
										case 283:
										{
											string attribute17;
											if (attribute17 == "Y")
											{
												num = 162;
												continue;
											}
											goto IL_268A;
										}
										case 284:
											goto IL_6B9;
										case 285:
											text2 = xmlTextReader.GetAttribute("COMPRESS");
											num = 191;
											continue;
										case 286:
											num = 60;
											continue;
										case 287:
											if ((A_2 & 2) == 2)
											{
												num = 62;
												continue;
											}
											goto IL_245E;
										case 288:
											goto IL_245E;
										case 289:
											goto IL_23D2;
										case 290:
											goto IL_268A;
										case 291:
										{
											string attribute3;
											if (!string.IsNullOrEmpty(attribute3))
											{
												num = 16;
												continue;
											}
											goto IL_2D62;
										}
										case 292:
											goto IL_2623;
										case 293:
											goto IL_2DC2;
										case 294:
											if ((A_2 & 2) == 2)
											{
												num = 340;
												continue;
											}
											goto IL_245E;
										case 295:
										{
											string attribute13 = xmlTextReader.GetAttribute("VERSION");
											num = 166;
											continue;
										}
										case 296:
										{
											string attribute16;
											if (attribute16 != this.b1)
											{
												num = 43;
												continue;
											}
											goto IL_1430;
										}
										case 297:
											goto IL_1D19;
										case 298:
											goto IL_2893;
										case 299:
											num = 99;
											continue;
										case 300:
											this.bo = true;
											num = 281;
											continue;
										case 301:
										{
											string value3 = this.a(A_4.j, A_4.i, this.DeviceUUID);
											num = 267;
											continue;
										}
										case 302:
											this.cr = true;
											num = 157;
											continue;
										case 303:
											if ((A_2 & 2) == 2)
											{
												num = 95;
												continue;
											}
											goto IL_245E;
										case 304:
											num = 103;
											continue;
										case 305:
											this.bm = true;
											num = 142;
											continue;
										case 306:
											if ((A_2 & 1) == 1)
											{
												num = 320;
												continue;
											}
											goto IL_245E;
										case 307:
											goto IL_D08;
										case 308:
											if (xmlTextReader.NodeType.Equals(global::System.Xml.XmlNodeType.Element))
											{
												num = 68;
												continue;
											}
											goto IL_D08;
										case 309:
											goto IL_1808;
										case 310:
											if (text2 == "Y")
											{
												num = 300;
												continue;
											}
											goto IL_1945;
										case 311:
										{
											string name4;
											if (name4 == "FILE")
											{
												num = 129;
												continue;
											}
											goto IL_2213;
										}
										case 312:
										{
											string name3;
											if (name3 == "FILE")
											{
												num = 247;
												continue;
											}
											goto IL_2659;
										}
										case 313:
											num = 18;
											continue;
										case 314:
											goto IL_245E;
										case 315:
											goto IL_1839;
										case 316:
											goto IL_245E;
										case 317:
											this.b8 = true;
											num = 179;
											continue;
										case 318:
											if ((A_2 & 1) == 1)
											{
												num = 199;
												continue;
											}
											goto IL_245E;
										case 319:
											if (text2 == "Y")
											{
												num = 346;
												continue;
											}
											goto IL_2893;
										case 320:
											this.ct = xmlTextReader.GetAttribute("VERSION");
											this.cq = true;
											text2 = xmlTextReader.GetAttribute("COMPRESS");
											num = 48;
											continue;
										case 321:
											goto IL_2340;
										case 322:
											item = this.c(xmlTextReader.Value, text3);
											this.FruFiles.Add(item);
											num = 233;
											continue;
										case 323:
											this.b9 = true;
											num = 69;
											continue;
										case 324:
											goto IL_245E;
										case 325:
										{
											string name2;
											if ((name2 = xmlTextReader.Name) != null)
											{
												num = 255;
												continue;
											}
											goto IL_245E;
										}
										case 326:
											if (xmlTextReader.Name.Equals("FIRMWARE"))
											{
												num = 278;
												continue;
											}
											num = 182;
											continue;
										case 327:
											num = 224;
											continue;
										case 328:
											goto IL_2659;
										case 329:
											if (text2 == "Y")
											{
												num = 252;
												continue;
											}
											goto IL_217E;
										case 330:
											goto IL_1839;
										case 331:
											this.b7 = true;
											num = 31;
											continue;
										case 332:
											goto IL_2941;
										case 333:
											if ((A_2 & 2) == 2)
											{
												num = 190;
												continue;
											}
											goto IL_245E;
										case 334:
											if ((A_2 & 1) == 1)
											{
												num = 270;
												continue;
											}
											goto IL_245E;
										case 335:
											if (xmlTextReader.Name.Equals("RAMDLOADER"))
											{
												num = 97;
												continue;
											}
											num = 344;
											continue;
										case 336:
										{
											string text4 = this.cu.Replace(".", string.Empty);
											text4 = text4.Substring(0, 4);
											num = 246;
											continue;
										}
										case 337:
											goto IL_1590;
										case 338:
											this.au = true;
											num = 17;
											continue;
										case 339:
											num = 280;
											continue;
										case 340:
										{
											string attribute10 = xmlTextReader.GetAttribute("VERSION");
											num = 100;
											continue;
										}
										case 341:
										{
											string attribute4;
											if (attribute4.Equals("CONFIGURATION"))
											{
												num = 336;
												continue;
											}
											goto IL_29FC;
										}
										case 342:
										{
											int num4;
											string attribute15;
											if (global::e.b.TryGetValue(attribute15, out num4))
											{
												num = 256;
												continue;
											}
											goto IL_D08;
										}
										case 343:
											if (!this.IsBootmode)
											{
												num = 178;
												continue;
											}
											goto IL_29FC;
										case 344:
											if (xmlTextReader.HasAttributes)
											{
												num = 254;
												continue;
											}
											xmlTextReader.Read();
											num = 106;
											continue;
										case 345:
											if (global::e.b == null)
											{
												num = 221;
												continue;
											}
											goto IL_111C;
										case 346:
											this.a8 = true;
											num = 298;
											continue;
										case 347:
											num = 146;
											continue;
										case 348:
											goto IL_245E;
										case 349:
											if (text2 == "Y")
											{
												num = 24;
												continue;
											}
											goto IL_1B02;
										case 350:
											goto IL_2F44;
										}
										break;
										IL_6B9:
										xmlTextReader.Read();
										num = 330;
										continue;
										IL_6FA:
										text3 = xmlTextReader.GetAttribute("ENCODING");
										xmlTextReader.Read();
										this.bf = this.a(xmlTextReader, "GLOBAL_MARKER", null, null, text3);
										num = 50;
										continue;
										IL_84A:
										text2 = xmlTextReader.GetAttribute("COMPRESS");
										num = 248;
										continue;
										IL_899:
										text3 = xmlTextReader.GetAttribute("ENCODING");
										xmlTextReader.Read();
										this.az = this.c(xmlTextReader.Value, text3);
										num = 316;
										continue;
										IL_D08:
										xmlTextReader.Read();
										num = 272;
										continue;
										IL_EB3:
										this.at = true;
										num = 44;
										continue;
										IL_FBA:
										num = 335;
										continue;
										IL_1010:
										num3++;
										num = 215;
										continue;
										IL_10CA:
										num = 326;
										continue;
										IL_10FD:
										this.cw = this.cv;
										a_ = true;
										num = 85;
										continue;
										IL_111C:
										num = 342;
										continue;
										IL_12B2:
										text2 = xmlTextReader.GetAttribute("COMPRESS");
										num = 275;
										continue;
										IL_12EC:
										text3 = xmlTextReader.GetAttribute("ENCODING");
										xmlTextReader.Read();
										this.cx = this.c(xmlTextReader.Value, text3);
										num = 180;
										continue;
										IL_13C6:
										num3++;
										num = 250;
										continue;
										IL_13DD:
										text3 = xmlTextReader.GetAttribute("ENCODING");
										num3 = 0;
										flag = false;
										xmlTextReader.Read();
										num = 209;
										continue;
										IL_1430:
										text2 = xmlTextReader.GetAttribute("COMPRESS");
										num = 238;
										continue;
										IL_14C6:
										text3 = xmlTextReader.GetAttribute("ENCODING");
										xmlTextReader.Read();
										this.bb = this.a(xmlTextReader, "CONTROL_HEAD", new global::System.Collections.ArrayList
										{
											"TYPE"
										}, new global::System.Collections.ArrayList
										{
											A_4.w
										}, text3);
										num = 288;
										continue;
										IL_1590:
										text3 = xmlTextReader.GetAttribute("ENCODING");
										xmlTextReader.Read();
										this.b6 = this.c(xmlTextReader.Value, text3);
										num = 169;
										continue;
										IL_165F:
										text3 = xmlTextReader.GetAttribute("ENCODING");
										xmlTextReader.Read();
										num = 165;
										continue;
										IL_16D8:
										text3 = xmlTextReader.GetAttribute("ENCODING");
										xmlTextReader.Read();
										this.av = this.c(xmlTextReader.Value, text3);
										num = 348;
										continue;
										IL_17A8:
										text2 = xmlTextReader.GetAttribute("COMPRESS");
										num = 349;
										continue;
										IL_1808:
										xmlTextReader.Read();
										num = 257;
										continue;
										IL_1839:
										xmlTextReader.Read();
										num = 147;
										continue;
										IL_188C:
										text2 = xmlTextReader.GetAttribute("COMPRESS");
										num = 159;
										continue;
										IL_191E:
										text3 = xmlTextReader.GetAttribute("ENCODING");
										xmlTextReader.Read();
										num = 214;
										continue;
										IL_1945:
										text3 = xmlTextReader.GetAttribute("ENCODING");
										xmlTextReader.Read();
										this.bp = this.c(xmlTextReader.Value, text3);
										num = 132;
										continue;
										IL_1981:
										text3 = xmlTextReader.GetAttribute("ENCODING");
										xmlTextReader.Read();
										num = 125;
										continue;
										IL_1B02:
										text3 = xmlTextReader.GetAttribute("ENCODING");
										xmlTextReader.Read();
										this.a3 = this.c(xmlTextReader.Value, text3);
										num = 185;
										continue;
										IL_1B3E:
										item = this.c(xmlTextReader.Value, text3);
										this.FruFiles.Add(item);
										num = 194;
										continue;
										IL_1C26:
										xmlTextReader.Read();
										num = 315;
										continue;
										IL_1C3F:
										text3 = xmlTextReader.GetAttribute("ENCODING");
										xmlTextReader.Read();
										this.bn = this.c(xmlTextReader.Value, text3);
										num = 81;
										continue;
										IL_1C7B:
										text3 = xmlTextReader.GetAttribute("ENCODING");
										xmlTextReader.Read();
										arrayList = new global::System.Collections.ArrayList();
										arrayList2 = new global::System.Collections.ArrayList();
										arrayList.Add("TYPE");
										arrayList2.Add(value2);
										num = 231;
										continue;
										IL_1D19:
										xmlTextReader.GetAttribute("FWPRODUCTIONNAME");
										attribute14 = xmlTextReader.GetAttribute("VERSION");
										num = 173;
										continue;
										IL_1FFC:
										text2 = xmlTextReader.GetAttribute("COMPRESS");
										num = 113;
										continue;
										IL_2087:
										text3 = xmlTextReader.GetAttribute("ENCODING");
										xmlTextReader.Read();
										num = 332;
										continue;
										IL_217E:
										xmlTextReader.Read();
										num = 88;
										continue;
										IL_2213:
										xmlTextReader.Read();
										num = 289;
										continue;
										IL_2340:
										text3 = xmlTextReader.GetAttribute("ENCODING");
										xmlTextReader.Read();
										num = 241;
										continue;
										IL_23D2:
										num = 47;
										continue;
										IL_245E:
										num = 200;
										continue;
										IL_2487:
										num = 237;
										continue;
										IL_2623:
										xmlTextReader.Read();
										num = 205;
										continue;
										IL_2659:
										xmlTextReader.Read();
										num = 203;
										continue;
										IL_268A:
										xmlTextReader.Read();
										xmlTextReader.Value.Trim();
										num = 186;
										continue;
										IL_26FF:
										text2 = xmlTextReader.GetAttribute("COMPRESS");
										num = 130;
										continue;
										IL_2794:
										this.bh = this.a(xmlTextReader, "DATA_IMAGE", arrayList, arrayList2, text3);
										num = 158;
										continue;
										IL_2893:
										text3 = xmlTextReader.GetAttribute("ENCODING");
										xmlTextReader.Read();
										this.a9 = this.a(xmlTextReader, "APP_UTILITIES", null, null, text3);
										num = 324;
										continue;
										IL_28F7:
										num = 105;
										continue;
										IL_2941:
										num = 4;
										continue;
										IL_29FC:
										xmlTextReader.Read();
										this.a5 = this.c(xmlTextReader.Value, text3);
										num = 309;
										continue;
										IL_2A2A:
										text3 = xmlTextReader.GetAttribute("ENCODING");
										xmlTextReader.Read();
										this.b5 = this.c(xmlTextReader.Value, text3);
										num = 77;
										continue;
										IL_2CE6:
										this.cv = this.cw;
										a_2 = true;
										num = 104;
										continue;
										IL_2D62:
										attribute = xmlTextReader.GetAttribute("ISH_COMP");
										num = 258;
										continue;
										IL_2DC2:
										text3 = xmlTextReader.GetAttribute("ENCODING");
										xmlTextReader.Read();
										this.bd = this.a(xmlTextReader, "FILE_CHANGE_LIST", new global::System.Collections.ArrayList
										{
											"TYPE"
										}, new global::System.Collections.ArrayList
										{
											A_4.w
										}, text3);
										num = 161;
										continue;
										IL_2E77:
										num = 156;
									}
								}
								IL_15FA:
								global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(2932U, base.GetType().ToString(), "CheckUpdateInfoType", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
								throw ex;
								IL_2F44:;
							}
							finally
							{
								num = 1;
								for (;;)
								{
									global::System.Xml.XmlTextReader xmlTextReader;
									switch (num)
									{
									case 0:
										((global::System.IDisposable)xmlTextReader).Dispose();
										num = 2;
										continue;
									case 2:
										goto IL_2F83;
									}
									if (xmlTextReader == null)
									{
										break;
									}
									num = 0;
								}
								IL_2F83:;
							}
							this.a(A_2, this.DeviceUUID, this.ar, a_2, a_, A_4.w);
							num = 3;
							continue;
						}
						case 2:
							goto IL_41;
						case 3:
							goto IL_2FAE;
						}
						if (!global::System.IO.File.Exists(A_1))
						{
							num = 2;
						}
						else
						{
							bool a_ = false;
							bool a_2 = false;
							string text2 = string.Empty;
							string text3 = string.Empty;
							string text = string.Empty;
							this.a(A_1, ref text);
							string empty = string.Empty;
							global::System.Xml.XmlTextReader xmlTextReader = new global::System.Xml.XmlTextReader(new global::System.IO.StringReader(text));
							num = 1;
						}
					}
					IL_41:
					global::custom_exception.CCustomException ex2 = new global::custom_exception.CCustomException(2908U, base.GetType().ToString(), "CheckUpdateInfoType", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
					throw ex2;
					IL_2FAE:
					break;
				}
				}
			}
			catch (global::custom_exception.CCustomException ex3)
			{
				throw ex3;
			}
			catch (global::System.Exception ex4)
			{
				if (global::custom_exception.CCustomException.CheckErrorIDExsists(ex4))
				{
					goto IL_2FF7;
				}
				IL_2FC0:
				if (true)
				{
				}
				ex4.Source = 2917U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex4.Source;
				IL_2FF7:
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_2FC0;
				default:
					if (false)
					{
					}
					throw ex4;
				}
			}
		}

		// Token: 0x060000FC RID: 252 RVA: 0x0001210C File Offset: 0x0001110C
		public string ConvertPackageProductNameToUUID(string productName)
		{
			string result;
			for (;;)
			{
				result = string.Empty;
				int num = 31;
				for (;;)
				{
					switch (num)
					{
					case 0:
						goto IL_1F6;
					case 1:
						result = "1EC82E1A4AE2B4F1A8AC27E8039CB7E4";
						num = 25;
						continue;
					case 2:
						return result;
					case 3:
						result = "9F6C2442C375421981A8987115FC9ADE";
						num = 0;
						continue;
					case 4:
						result = "0C78E1B906C54D3A8F264CE5C4F0B9DF";
						num = 21;
						continue;
					case 5:
						return result;
					case 6:
						goto IL_3B5;
					case 7:
						goto IL_1CA;
					case 8:
						return result;
					case 9:
						if (productName.StartsWith("Bahama"))
						{
							num = 27;
							continue;
						}
						num = 32;
						continue;
					case 10:
						if (productName.StartsWith("ParaRefresh"))
						{
							num = 14;
							continue;
						}
						goto IL_1FB;
					case 11:
						if (true)
						{
						}
						result = "C4FC39D8DEF24B779D1CB719AF26A269";
						num = 24;
						continue;
					case 12:
						goto IL_15A;
					case 13:
						if (productName.StartsWith("Phoenix"))
						{
							num = 29;
							continue;
						}
						num = 22;
						continue;
					case 14:
						result = "0C78E1B906C54D3A8F264CE5C4F0B9DF";
						num = 12;
						continue;
					case 15:
						if (productName.StartsWith("Bandit"))
						{
							num = 6;
							continue;
						}
						num = 13;
						continue;
					case 16:
						return result;
					case 17:
						result = "C52A3D4953FE469D8E11F05B143E8C56";
						num = 18;
						continue;
					case 18:
						return result;
					case 19:
						if (productName.StartsWith("ParaRefresh_ton"))
						{
							num = 28;
							continue;
						}
						num = 10;
						continue;
					case 20:
						result = "9F6C2442C375421981A8987115FC9ADE";
						num = 7;
						continue;
					case 21:
						goto IL_1E0;
					case 22:
						if (productName.StartsWith("Malta"))
						{
							num = 3;
							continue;
						}
						num = 26;
						continue;
					case 23:
						if (productName.StartsWith("Paradise"))
						{
							num = 4;
							continue;
						}
						num = 9;
						continue;
					case 24:
						return result;
					case 25:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1FB;
						default:
							goto IL_1AE;
						}
						break;
					case 26:
						if (productName.StartsWith("ParaLight"))
						{
							num = 11;
							continue;
						}
						num = 33;
						continue;
					case 27:
						result = "AF5DAB63F4FC4926BB9000A6F18AF3DC";
						num = 5;
						continue;
					case 28:
						result = "EBCCE9BF33B14896B5C2E7E3AA19AF0F";
						num = 8;
						continue;
					case 29:
						result = "06CE7B7163C0456A845A6E13421F0AE4";
						num = 16;
						continue;
					case 30:
						num = 15;
						continue;
					case 31:
						if (!productName.StartsWith("Matrix"))
						{
							num = 30;
							continue;
						}
						goto IL_3B5;
					case 32:
						if (productName.StartsWith("Tonga"))
						{
							num = 1;
							continue;
						}
						num = 19;
						continue;
					case 33:
						if (productName.StartsWith("PLightPlus"))
						{
							num = 17;
							continue;
						}
						num = 23;
						continue;
					case 34:
						if (productName.StartsWith("MalRefresh"))
						{
							num = 20;
							continue;
						}
						goto IL_220;
					}
					break;
					IL_1FB:
					num = 34;
					continue;
					IL_3B5:
					result = "D105ADD323864E539B513A65076458D3";
					num = 2;
				}
			}
			IL_15A:
			return result;
			IL_1AE:
			if (false)
			{
			}
			IL_1CA:
			IL_1E0:
			IL_1F6:
			return result;
			IL_220:
			global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(2908U, base.GetType().ToString(), "ConvertPackageProductNameToUUID", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
			throw ex;
		}

		// Token: 0x060000FD RID: 253 RVA: 0x000124F8 File Offset: 0x000114F8
		private string a(global::System.Xml.XmlTextReader A_0, string A_1, global::System.Collections.ArrayList A_2, global::System.Collections.ArrayList A_3, string A_4)
		{
			switch (0)
			{
			default:
			{
				string result;
				for (;;)
				{
					result = string.Empty;
					int num = 26;
					for (;;)
					{
						bool flag;
						switch (num)
						{
						case 0:
						{
							string name;
							if ((name = A_0.Name) != null)
							{
								num = 9;
								continue;
							}
							goto IL_162;
						}
						case 1:
							if (A_0.Name.Equals(A_1))
							{
								num = 18;
								continue;
							}
							num = 13;
							continue;
						case 2:
							goto IL_C6;
						case 3:
						{
							if (true)
							{
							}
							flag = true;
							int count = A_2.Count;
							int num2 = 0;
							num = 5;
							continue;
						}
						case 4:
							num = 10;
							continue;
						case 5:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_1C3;
							default:
								if (false)
								{
								}
								goto IL_A2;
							}
							break;
						case 6:
							goto IL_1C3;
						case 7:
							if (A_2 != null)
							{
								num = 12;
								continue;
							}
							goto IL_F6;
						case 8:
							goto IL_145;
						case 9:
							num = 28;
							continue;
						case 10:
							if (A_0.HasAttributes)
							{
								num = 3;
								continue;
							}
							goto IL_162;
						case 11:
							goto IL_162;
						case 12:
							num = 6;
							continue;
						case 13:
							if (A_0.NodeType.Equals(global::System.Xml.XmlNodeType.Element))
							{
								num = 21;
								continue;
							}
							goto IL_162;
						case 14:
							num = 7;
							continue;
						case 15:
							goto IL_204;
						case 16:
							A_0.Read();
							result = this.c(A_0.Value, A_4);
							num = 11;
							continue;
						case 17:
							goto IL_162;
						case 18:
							return result;
						case 19:
							goto IL_145;
						case 20:
							goto IL_A2;
						case 21:
							num = 0;
							continue;
						case 22:
						{
							int num2;
							string attribute;
							if (!attribute.Equals(A_3[num2].ToString()))
							{
								num = 2;
								continue;
							}
							num2++;
							num = 20;
							continue;
						}
						case 23:
						{
							int count;
							int num2;
							if (num2 >= count)
							{
								num = 8;
								continue;
							}
							string attribute = A_0.GetAttribute(A_2[num2].ToString());
							num = 27;
							continue;
						}
						case 24:
							num = 22;
							continue;
						case 25:
							if (flag)
							{
								num = 16;
								continue;
							}
							goto IL_162;
						case 26:
							goto IL_204;
						case 27:
						{
							string attribute;
							if (!string.IsNullOrEmpty(attribute))
							{
								num = 24;
								continue;
							}
							goto IL_C6;
						}
						case 28:
						{
							string name;
							if (name == "FILE")
							{
								num = 14;
								continue;
							}
							goto IL_162;
						}
						}
						break;
						IL_A2:
						num = 23;
						continue;
						IL_C6:
						flag = false;
						num = 19;
						continue;
						IL_F6:
						A_0.Read();
						result = this.c(A_0.Value, A_4);
						num = 17;
						continue;
						IL_1C3:
						if (A_2.Count > 0)
						{
							num = 4;
							continue;
						}
						goto IL_F6;
						IL_145:
						num = 25;
						continue;
						IL_162:
						A_0.Read();
						num = 15;
						continue;
						IL_204:
						num = 1;
					}
				}
				return result;
			}
			}
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00012858 File Offset: 0x00011858
		private void a(int A_0, string A_1, bool A_2, bool A_3, bool A_4, string A_5)
		{
			switch (0)
			{
			default:
			{
				int num = 20;
				for (;;)
				{
					int num2;
					switch (num)
					{
					case 0:
						if (!global::System.IO.File.Exists(this.bf))
						{
							num = 68;
							continue;
						}
						goto IL_A6F;
					case 1:
						goto IL_90A;
					case 2:
						if (!(this.bu == "C4FC39D8DEF24B779D1CB719AF26A269"))
						{
							num = 110;
							continue;
						}
						goto IL_894;
					case 3:
						if (!(this.bu == "0C78E1B906C54D3A8F264CE5C4F0B9DF"))
						{
							num = 6;
							continue;
						}
						goto IL_894;
					case 4:
						num = 67;
						continue;
					case 5:
						if (!global::Controller.DeviceInfo.isGemstoneRadio(A_1))
						{
							num = 28;
							continue;
						}
						goto IL_C41;
					case 6:
						num = 46;
						continue;
					case 7:
						num = 10;
						continue;
					case 8:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_4E6;
						default:
							if (false)
							{
							}
							num = 65;
							continue;
						}
						break;
					case 9:
						goto IL_C81;
					case 10:
						if (!(this.bu == "0C0D6EE58204FBDEBB8860C631AB465A"))
						{
							num = 34;
							continue;
						}
						goto IL_894;
					case 11:
						num = 114;
						continue;
					case 12:
						num = 60;
						continue;
					case 13:
						num = 75;
						continue;
					case 14:
						if ((A_0 & 2) == 2)
						{
							num = 98;
							continue;
						}
						return;
					case 15:
						if (global::Controller.DeviceInfo.isGemstoneRadio(A_1))
						{
							num = 1;
							continue;
						}
						goto IL_96A;
					case 16:
						if (!global::System.IO.File.Exists(this.bn))
						{
							num = 99;
							continue;
						}
						num = 119;
						continue;
					case 17:
						goto IL_E99;
					case 18:
						if (!global::System.IO.File.Exists(this.a9))
						{
							num = 118;
							continue;
						}
						num = 16;
						continue;
					case 19:
						if (!global::System.IO.File.Exists(this.PSDTFile))
						{
							num = 126;
							continue;
						}
						num = 78;
						continue;
					case 21:
						num = 0;
						continue;
					case 22:
						num = 54;
						continue;
					case 23:
						if (!global::System.IO.File.Exists(this.bq))
						{
							num = 77;
							continue;
						}
						goto IL_96A;
					case 24:
						num = 89;
						continue;
					case 25:
						num = 105;
						continue;
					case 26:
						if (A_2)
						{
							num = 120;
							continue;
						}
						goto IL_D9B;
					case 27:
						goto IL_A97;
					case 28:
						num = 115;
						continue;
					case 29:
						goto IL_F45;
					case 30:
						num = 42;
						continue;
					case 31:
						if (A_2)
						{
							num = 45;
							continue;
						}
						goto IL_727;
					case 32:
						switch (num2)
						{
						case -1:
							goto IL_5CA;
						case 0:
						case 1:
							goto IL_9C5;
						default:
							num = 111;
							continue;
						}
						break;
					case 33:
						goto IL_105E;
					case 34:
						num = 2;
						continue;
					case 35:
						if (global::Controller.DeviceInfo.isGemstoneRadio(A_1))
						{
							num = 59;
							continue;
						}
						goto IL_EFA;
					case 36:
						if (!global::System.IO.File.Exists(this.az))
						{
							num = 82;
							continue;
						}
						num = 116;
						continue;
					case 37:
						num = 93;
						continue;
					case 38:
						if (!(this.bu == "106F58B631044D63B41F0C0D7720758D"))
						{
							num = 7;
							continue;
						}
						goto IL_894;
					case 39:
						if (!(this.bu == "1EC82E1A4AE2B4F1A8AC27E8039CB7E4"))
						{
							num = 22;
							continue;
						}
						goto IL_894;
					case 40:
						if (this.bk)
						{
							num = 11;
							continue;
						}
						return;
					case 41:
						goto IL_10B6;
					case 42:
						if (this.pakUUID == "06CE7B7163C0456A845A6E13421F0AE4")
						{
							num = 95;
							continue;
						}
						goto IL_80C;
					case 43:
						if (!string.IsNullOrEmpty(A_5))
						{
							num = 44;
							continue;
						}
						goto IL_A6F;
					case 44:
						num = 73;
						continue;
					case 45:
						goto IL_BEC;
					case 46:
						if (!(this.bu == "0571AFE244664F999A96B020E82DC69C"))
						{
							if (true)
							{
							}
							num = 37;
							continue;
						}
						goto IL_894;
					case 47:
						goto IL_894;
					case 48:
						goto IL_33C;
					case 49:
						if (global::Controller.DeviceInfo.isGemstoneRadio(A_1))
						{
							num = 84;
							continue;
						}
						num = 122;
						continue;
					case 50:
						goto IL_40A;
					case 51:
						if (!(this.bu == "C52A3D4953FE469D8E11F05B143E8C56"))
						{
							goto IL_4E6;
						}
						goto IL_894;
					case 52:
						num = 5;
						continue;
					case 53:
						if (!A_2)
						{
							num = 81;
							continue;
						}
						goto IL_AF6;
					case 54:
						if (this.bu == "EBCCE9BF33B14896B5C2E7E3AA19AF0F")
						{
							num = 47;
							continue;
						}
						goto IL_5CA;
					case 55:
						num = 39;
						continue;
					case 56:
						num = 104;
						continue;
					case 57:
						if (!global::System.IO.File.Exists(this.a3))
						{
							num = 48;
							continue;
						}
						num = 36;
						continue;
					case 58:
						num = 38;
						continue;
					case 59:
						num = 90;
						continue;
					case 60:
						if (global::System.IO.File.Exists(this.cl))
						{
							num = 4;
							continue;
						}
						goto IL_DC5;
					case 61:
						num = 35;
						continue;
					case 62:
					{
						if (!global::System.IO.File.Exists(this.az))
						{
							num = 9;
							continue;
						}
						global::System.Collections.Generic.List<string>.Enumerator enumerator = this.ScriptFiles.GetEnumerator();
						num = 50;
						continue;
					}
					case 63:
						if (!global::System.IO.File.Exists(this.RDLFile))
						{
							num = 109;
							continue;
						}
						goto IL_727;
					case 64:
						if (A_4)
						{
							num = 79;
							continue;
						}
						goto IL_56F;
					case 65:
						if (!global::System.IO.File.Exists(this.a5))
						{
							num = 17;
							continue;
						}
						goto IL_525;
					case 66:
						num = 62;
						continue;
					case 67:
						if (!global::System.IO.File.Exists(this.cm))
						{
							num = 103;
							continue;
						}
						num = 112;
						continue;
					case 68:
						goto IL_807;
					case 69:
						goto IL_5CA;
					case 70:
						num = 106;
						continue;
					case 71:
						if (global::Controller.DeviceInfo.isGemstoneRadio(A_1))
						{
							num = 85;
							continue;
						}
						goto IL_D9B;
					case 72:
						goto IL_56D;
					case 73:
						if (!global::System.IO.File.Exists(this.bb))
						{
							num = 41;
							continue;
						}
						num = 97;
						continue;
					case 74:
						goto IL_65B;
					case 75:
						if (!global::Controller.DeviceInfo.isGemstoneRadio(A_1))
						{
							num = 124;
							continue;
						}
						goto IL_ACE;
					case 76:
						if (!A_3)
						{
							num = 72;
							continue;
						}
						goto IL_AF6;
					case 77:
						num = 15;
						continue;
					case 78:
						if (!global::System.IO.File.Exists(this.BLFile))
						{
							num = 52;
							continue;
						}
						goto IL_B1C;
					case 79:
						num = 76;
						continue;
					case 80:
						if (A_2)
						{
							num = 21;
							continue;
						}
						goto IL_A6F;
					case 81:
						num = 64;
						continue;
					case 82:
						goto IL_261;
					case 83:
						if (global::System.IO.File.Exists(this.ck))
						{
							num = 12;
							continue;
						}
						goto IL_DC5;
					case 84:
						num = 18;
						continue;
					case 85:
						num = 26;
						continue;
					case 86:
						goto IL_B9B;
					case 87:
						if (!global::System.IO.File.Exists(this.bt))
						{
							num = 100;
							continue;
						}
						goto IL_EFA;
					case 88:
						if (global::System.IO.File.Exists(this.FWFile1))
						{
							num = 56;
							continue;
						}
						goto IL_BA0;
					case 89:
						if (!global::System.IO.File.Exists(this.bd))
						{
							num = 74;
							continue;
						}
						goto IL_A4F;
					case 90:
						if (A_2)
						{
							num = 102;
							continue;
						}
						goto IL_EFA;
					case 91:
						num = 3;
						continue;
					case 92:
						if (this.a4)
						{
							num = 8;
							continue;
						}
						goto IL_525;
					case 93:
						if (!(this.bu == "9F6C2442C375421981A8987115FC9ADE"))
						{
							num = 58;
							continue;
						}
						goto IL_894;
					case 94:
						num = 31;
						continue;
					case 95:
						goto IL_D96;
					case 96:
						if (!global::System.IO.File.Exists(this.FieldMoveFile))
						{
							num = 70;
							continue;
						}
						goto IL_EFA;
					case 97:
						if (A_2)
						{
							num = 24;
							continue;
						}
						goto IL_A4F;
					case 98:
						num = 63;
						continue;
					case 99:
						goto IL_5C5;
					case 100:
						goto IL_861;
					case 101:
						if (global::System.IO.File.Exists(this.bs))
						{
							num = 113;
							continue;
						}
						goto IL_F7C;
					case 102:
						goto IL_772;
					case 103:
						goto IL_FD0;
					case 104:
						if (!global::System.IO.File.Exists(this.FWFile2))
						{
							num = 13;
							continue;
						}
						goto IL_ACE;
					case 105:
						if (global::Controller.DeviceInfo.isGemstoneRadio(A_1))
						{
							num = 94;
							continue;
						}
						goto IL_727;
					case 106:
						if (global::Controller.DeviceInfo.isGemstoneRadio(A_1))
						{
							num = 61;
							continue;
						}
						goto IL_1060;
					case 107:
						num = 71;
						continue;
					case 108:
						if (!global::System.IO.File.Exists(this.bh))
						{
							num = 27;
							continue;
						}
						num = 40;
						continue;
					case 109:
						num = 123;
						continue;
					case 110:
						num = 51;
						continue;
					case 111:
						num = 69;
						continue;
					case 112:
						if (!global::System.IO.File.Exists(this.cn))
						{
							num = 30;
							continue;
						}
						goto IL_80C;
					case 113:
						num = 87;
						continue;
					case 114:
						if (!global::System.IO.File.Exists(this.bi))
						{
							num = 125;
							continue;
						}
						return;
					case 115:
						if (!(this.bu == "AF5DAB63F4FC4926BB9000A6F18AF3DC"))
						{
							num = 33;
							continue;
						}
						goto IL_C41;
					case 116:
						if (!global::System.IO.File.Exists(this.av))
						{
							num = 86;
							continue;
						}
						num = 92;
						continue;
					case 117:
						if (!global::System.IO.File.Exists(this.br))
						{
							num = 91;
							continue;
						}
						goto IL_5CA;
					case 118:
						goto IL_D64;
					case 119:
						if (!global::System.IO.File.Exists(this.bp))
						{
							num = 29;
							continue;
						}
						num = 57;
						continue;
					case 120:
						num = 101;
						continue;
					case 121:
						goto IL_B1C;
					case 122:
						if (this.bu == "AF5DAB63F4FC4926BB9000A6F18AF3DC")
						{
							num = 66;
							continue;
						}
						return;
					case 123:
						if (global::Controller.DeviceInfo.isGemstoneRadio(A_1))
						{
							num = 25;
							continue;
						}
						goto IL_C13;
					case 124:
						goto IL_38C;
					case 125:
						goto IL_11F5;
					case 126:
						goto IL_74F;
					}
					if ((A_0 & 1) == 1)
					{
						num = 107;
						continue;
					}
					goto IL_AF6;
					IL_4E6:
					num = 55;
					continue;
					IL_525:
					num = 43;
					continue;
					IL_5CA:
					num = 96;
					continue;
					IL_727:
					num = 19;
					continue;
					IL_80C:
					num = 23;
					continue;
					IL_894:
					global::System.Version version = new global::System.Version(this.ct);
					global::System.Version value = new global::System.Version("06.01.00");
					num2 = version.CompareTo(value);
					num = 32;
					continue;
					IL_96A:
					num = 117;
					continue;
					IL_A4F:
					num = 80;
					continue;
					IL_A6F:
					num = 108;
					continue;
					IL_ACE:
					num = 49;
					continue;
					IL_AF6:
					num = 14;
					continue;
					IL_B1C:
					num = 88;
					continue;
					IL_C41:
					this.cp = false;
					num = 121;
					continue;
					IL_D9B:
					num = 83;
					continue;
					IL_EFA:
					num = 53;
				}
				IL_261:
				global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(2970U, base.GetType().ToString(), "verifyPackageFiles", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
				throw ex;
				IL_33C:
				global::custom_exception.CCustomException ex2 = new global::custom_exception.CCustomException(2969U, base.GetType().ToString(), "verifyPackageFiles", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
				throw ex2;
				IL_38C:
				goto IL_BA0;
				IL_40A:
				try
				{
					num = 5;
					for (;;)
					{
						switch (num)
						{
						case 0:
							num = 2;
							continue;
						case 1:
							goto IL_117E;
						case 2:
							goto IL_118C;
						case 3:
						{
							global::System.Collections.Generic.List<string>.Enumerator enumerator;
							if (!enumerator.MoveNext())
							{
								num = 0;
								continue;
							}
							string path = enumerator.Current;
							num = 4;
							continue;
						}
						case 4:
						{
							string path;
							if (!global::System.IO.File.Exists(path))
							{
								num = 1;
								continue;
							}
							break;
						}
						}
						IL_113A:
						num = 3;
						continue;
						goto IL_113A;
					}
					IL_117E:
					global::custom_exception.CCustomException ex3 = new global::custom_exception.CCustomException(2981U, base.GetType().ToString(), "CheckUpdateInfoType", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
					throw ex3;
					IL_118C:
					return;
				}
				finally
				{
					global::System.Collections.Generic.List<string>.Enumerator enumerator;
					((global::System.IDisposable)enumerator).Dispose();
				}
				goto IL_119F;
				IL_56D:
				IL_56F:
				global::custom_exception.CCustomException ex4 = new global::custom_exception.CCustomException(2911U, base.GetType().ToString(), "verifyPackageFiles", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
				throw ex4;
				IL_5C5:
				global::custom_exception.CCustomException ex5 = new global::custom_exception.CCustomException(2967U, base.GetType().ToString(), "verifyPackageFiles", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
				throw ex5;
				IL_65B:
				global::custom_exception.CCustomException ex6 = new global::custom_exception.CCustomException(2975U, base.GetType().ToString(), "verifyPackageFiles", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
				throw ex6;
				IL_74F:
				global::custom_exception.CCustomException ex7 = new global::custom_exception.CCustomException(2937U, base.GetType().ToString(), "verifyPackageFiles", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
				throw ex7;
				IL_772:
				goto IL_1060;
				IL_807:
				global::custom_exception.CCustomException ex8 = new global::custom_exception.CCustomException(2976U, base.GetType().ToString(), "verifyPackageFiles", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
				throw ex8;
				IL_861:
				goto IL_F7C;
				IL_90A:
				global::custom_exception.CCustomException ex9 = new global::custom_exception.CCustomException(2909U, base.GetType().ToString(), "verifyPackageFiles", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
				throw ex9;
				IL_9C5:
				global::custom_exception.CCustomException ex10 = new global::custom_exception.CCustomException(2909U, base.GetType().ToString(), "CheckUpdateInfoType", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
				throw ex10;
				IL_A97:
				global::custom_exception.CCustomException ex11 = new global::custom_exception.CCustomException(2974U, base.GetType().ToString(), "verifyPackageFiles", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
				throw ex11;
				IL_B9B:
				global::custom_exception.CCustomException ex12 = new global::custom_exception.CCustomException(2971U, base.GetType().ToString(), "verifyPackageFiles", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
				throw ex12;
				IL_BA0:
				global::custom_exception.CCustomException ex13 = new global::custom_exception.CCustomException(2919U, base.GetType().ToString(), "verifyPackageFiles", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
				throw ex13;
				IL_BEC:
				IL_C13:
				global::custom_exception.CCustomException ex14 = new global::custom_exception.CCustomException(2910U, base.GetType().ToString(), "verifyPackageFiles", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
				throw ex14;
				IL_C81:
				goto IL_119F;
				IL_D64:
				global::custom_exception.CCustomException ex15 = new global::custom_exception.CCustomException(2966U, base.GetType().ToString(), "verifyPackageFiles", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
				throw ex15;
				IL_D96:
				global::custom_exception.CCustomException ex16 = new global::custom_exception.CCustomException(2909U, base.GetType().ToString(), "verifyPackageFiles", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
				throw ex16;
				IL_DC5:
				global::custom_exception.CCustomException ex17 = new global::custom_exception.CCustomException(2909U, base.GetType().ToString(), "verifyPackageFiles", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
				throw ex17;
				IL_E99:
				global::custom_exception.CCustomException ex18 = new global::custom_exception.CCustomException(2971U, base.GetType().ToString(), "CheckUpdateInfoType", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
				throw ex18;
				IL_F45:
				global::custom_exception.CCustomException ex19 = new global::custom_exception.CCustomException(2968U, base.GetType().ToString(), "verifyPackageFiles", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
				throw ex19;
				IL_F7C:
				global::custom_exception.CCustomException ex20 = new global::custom_exception.CCustomException(2909U, base.GetType().ToString(), "verifyPackageFiles", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
				throw ex20;
				IL_FD0:
				goto IL_DC5;
				IL_105E:
				global::custom_exception.CCustomException ex21 = new global::custom_exception.CCustomException(2938U, base.GetType().ToString(), "verifyPackageFiles", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
				throw ex21;
				IL_1060:
				global::custom_exception.CCustomException ex22 = new global::custom_exception.CCustomException(2939U, base.GetType().ToString(), "verifyPackageFiles", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
				throw ex22;
				IL_10B6:
				global::custom_exception.CCustomException ex23 = new global::custom_exception.CCustomException(2973U, base.GetType().ToString(), "verifyPackageFiles", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
				throw ex23;
				IL_119F:
				global::custom_exception.CCustomException ex24 = new global::custom_exception.CCustomException(2970U, base.GetType().ToString(), "CheckUpdateInfoType", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
				throw ex24;
				IL_11F5:
				global::custom_exception.CCustomException ex25 = new global::custom_exception.CCustomException(2983U, base.GetType().ToString(), "verifyPackageFiles", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
				throw ex25;
			}
			}
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00013A98 File Offset: 0x00012A98
		public static bool isGemstoneRadio(string UUID)
		{
			int num = 11;
			for (;;)
			{
				switch (num)
				{
				case 0:
					num = 12;
					continue;
				case 1:
					num = 8;
					continue;
				case 2:
					if (!(UUID == "C52A3D4953FE469D8E11F05B143E8C56"))
					{
						num = 1;
						continue;
					}
					return true;
				case 3:
					num = 13;
					continue;
				case 4:
					num = 10;
					continue;
				case 5:
					num = 6;
					continue;
				case 6:
					if (!(UUID == "9F6C2442C375421981A8987115FC9ADE"))
					{
						num = 4;
						continue;
					}
					return true;
				case 7:
					goto IL_129;
				case 8:
					if (!(UUID == "EBCCE9BF33B14896B5C2E7E3AA19AF0F"))
					{
						num = 3;
						continue;
					}
					return true;
				case 9:
					num = 2;
					continue;
				case 10:
					if (true)
					{
					}
					if (!(UUID == "106F58B631044D63B41F0C0D7720758D"))
					{
						num = 9;
						continue;
					}
					return true;
				case 12:
					if (UUID == "0571AFE244664F999A96B020E82DC69C")
					{
						return true;
					}
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						if (false)
						{
						}
						num = 5;
						continue;
					}
					break;
				case 13:
					if (global::Controller.DeviceInfo.isParadiseLightRadio(UUID))
					{
						num = 7;
						continue;
					}
					return false;
				}
				IL_48:
				if (!(UUID == "0C78E1B906C54D3A8F264CE5C4F0B9DF"))
				{
					num = 0;
					continue;
				}
				break;
				goto IL_48;
			}
			return true;
			IL_129:
			return true;
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00013C10 File Offset: 0x00012C10
		public static bool isBahamaRadio(string UUID)
		{
			switch ((1 == 1) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				if (true)
				{
				}
				if (false)
				{
				}
				if (UUID == "AF5DAB63F4FC4926BB9000A6F18AF3DC")
				{
					return true;
				}
				break;
			}
			return false;
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00013C60 File Offset: 0x00012C60
		public static bool isParadiseLightRadio(string UUID)
		{
			if (true)
			{
			}
			int num = 1;
			for (;;)
			{
				switch (num)
				{
				case 0:
					if (UUID == "C4FC39D8DEF24B779D1CB719AF26A269")
					{
						return true;
					}
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_51;
					default:
						if (false)
						{
						}
						num = 2;
						continue;
					}
					break;
				case 2:
					num = 5;
					continue;
				case 3:
					goto IL_66;
				case 4:
					num = 0;
					continue;
				case 5:
					goto IL_51;
				}
				if (!(UUID == "0C0D6EE58204FBDEBB8860C631AB465A"))
				{
					num = 4;
					continue;
				}
				break;
				IL_51:
				if (!(UUID == "1EC82E1A4AE2B4F1A8AC27E8039CB7E4"))
				{
					return false;
				}
				num = 3;
			}
			return true;
			IL_66:
			return true;
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00013D20 File Offset: 0x00012D20
		private static bool b(string A_0)
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
			return !A_0[8].Equals('C');
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00013D70 File Offset: 0x00012D70
		private bool a(string A_0)
		{
			bool result;
			for (;;)
			{
				result = true;
				int num = 7;
				for (;;)
				{
					switch (num)
					{
					case 0:
						result = !this.aq;
						num = 3;
						continue;
					case 1:
						if (string.Compare(A_0, "Analog", true) == 0)
						{
							num = 0;
							continue;
						}
						return result;
					case 2:
						result = this.aq;
						num = 5;
						continue;
					case 3:
						return result;
					case 4:
						num = 6;
						continue;
					case 5:
						return result;
					case 6:
						if (true)
						{
						}
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							if (false)
							{
							}
							if (string.Compare(A_0, "Digital", true) == 0)
							{
								num = 2;
								continue;
							}
							num = 1;
							continue;
						}
						break;
					case 7:
						if (!string.IsNullOrEmpty(A_0))
						{
							num = 4;
							continue;
						}
						return result;
					}
					break;
				}
			}
			return result;
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00013E64 File Offset: 0x00012E64
		private string d(string A_0, string A_1)
		{
			if (true)
			{
			}
			switch ((1 == 1) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_3C;
			}
			if (false)
			{
			}
			switch (0)
			{
			default:
			{
				IL_3C:
				global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>> dictionary = new global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>>();
				dictionary.Add("UHF-B1", new global::System.Collections.Generic.List<string>());
				dictionary["UHF-B1"].Add("T8319A_PMUE4886AA");
				dictionary.Add("VHF", new global::System.Collections.Generic.List<string>());
				dictionary["VHF"].Add("T8319A_PMUD3360AA");
				string result = string.Empty;
				using (global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>>.KeyCollection.Enumerator enumerator = dictionary.Keys.GetEnumerator())
				{
					int num = 0;
					for (;;)
					{
						switch (num)
						{
						case 1:
						{
							if (!enumerator.MoveNext())
							{
								num = 5;
								continue;
							}
							string text = enumerator.Current;
							num = 2;
							continue;
						}
						case 2:
						{
							string text;
							if (dictionary[text].Contains(A_0 + "_" + A_1))
							{
								num = 3;
								continue;
							}
							break;
						}
						case 3:
						{
							string text;
							result = text;
							num = 4;
							continue;
						}
						case 4:
							goto IL_133;
						case 5:
							goto IL_133;
						case 6:
							goto IL_13F;
						}
						IL_106:
						num = 1;
						continue;
						goto IL_106;
						IL_133:
						num = 6;
					}
					IL_13F:;
				}
				return result;
			}
			}
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00013FD4 File Offset: 0x00012FD4
		private string a(string A_0, string A_1, string A_2)
		{
			switch (0)
			{
			default:
			{
				string result;
				for (;;)
				{
					result = string.Empty;
					int num = 21;
					for (;;)
					{
						switch (num)
						{
						case 0:
							if (A_0.Length == 12)
							{
								if (true)
								{
								}
								num = 19;
								continue;
							}
							num = 2;
							continue;
						case 1:
							num = 20;
							continue;
						case 2:
							if (A_0.Length == 6)
							{
								num = 1;
								continue;
							}
							goto IL_194;
						case 3:
							return result;
						case 4:
							goto IL_13F;
						case 5:
							return result;
						case 6:
							goto IL_13A;
						case 7:
							this.c3 = this.d(A_0, A_1);
							num = 4;
							continue;
						case 8:
							if (this.bu == "AF5DAB63F4FC4926BB9000A6F18AF3DC")
							{
								num = 9;
								continue;
							}
							return result;
						case 9:
							num = 0;
							continue;
						case 10:
							num = 12;
							continue;
						case 11:
						{
							char c;
							switch (c)
							{
							case 'P':
								result = "350";
								num = 18;
								continue;
							case 'Q':
								result = "UHF-B1";
								num = 3;
								continue;
							default:
								num = 15;
								continue;
							}
							break;
						}
						case 12:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_FA;
							default:
							{
								if (false)
								{
								}
								string text;
								if (text == "UHFB1")
								{
									num = 16;
									continue;
								}
								goto IL_206;
							}
							}
							break;
						case 13:
							return result;
						case 14:
							return result;
						case 15:
							num = 5;
							continue;
						case 16:
							result = "UHF-B1";
							num = 6;
							continue;
						case 17:
							num = 11;
							continue;
						case 18:
							return result;
						case 19:
						{
							char c = A_0[3];
							goto IL_FA;
						}
						case 20:
						{
							string text;
							if ((text = this.c3) != null)
							{
								num = 10;
								continue;
							}
							goto IL_206;
						}
						case 21:
							if (string.IsNullOrEmpty(this.c3))
							{
								num = 7;
								continue;
							}
							goto IL_13F;
						case 22:
						{
							char c;
							switch (c)
							{
							case 'J':
								result = "VHF";
								num = 14;
								continue;
							case 'K':
								result = "300";
								num = 23;
								continue;
							default:
								num = 17;
								continue;
							}
							break;
						}
						case 23:
							goto IL_ED;
						}
						break;
						IL_FA:
						num = 22;
						continue;
						IL_13F:
						num = 8;
						continue;
						IL_206:
						result = this.c3;
						num = 13;
					}
				}
				IL_ED:
				IL_13A:
				return result;
				IL_194:
				global::custom_exception.CCustomException ex = global::Controller.CCustomExceptionHandler.CreateException(1026U, base.GetType().ToString(), "GetRadioType", global::System.Environment.StackTrace.ToString(global::System.Globalization.NumberFormatInfo.InvariantInfo));
				throw ex;
			}
			}
		}

		// Token: 0x06000106 RID: 262 RVA: 0x000142C8 File Offset: 0x000132C8
		private void a(string A_0, ref string A_1)
		{
			try
			{
				switch (0)
				{
				default:
				{
					for (;;)
					{
						global::d.a(A_0, ref A_1, false, global::d.c.c);
						global::d.b b = global::d.a(global::d.a.b, ref A_1);
						int num = 0;
						for (;;)
						{
							switch (num)
							{
							case 0:
								if (b != global::d.b.c)
								{
									num = 1;
									continue;
								}
								global::System.GC.Collect();
								num = 2;
								continue;
							case 1:
								goto IL_4A;
							case 2:
								goto IL_86;
							}
							break;
						}
					}
					IL_4A:
					global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(1835U, base.GetType().ToString(), "RetrieveUpdateInfo", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
					throw ex;
					IL_86:
					break;
				}
				}
			}
			catch (global::custom_exception.CCustomException ex2)
			{
				throw ex2;
			}
			catch (global::System.Exception ex3)
			{
				if (global::custom_exception.CCustomException.CheckErrorIDExsists(ex3))
				{
					goto IL_C1;
				}
				IL_96:
				ex3.Source = 2915U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex3.Source;
				IL_C1:
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_96;
				default:
					if (true)
					{
					}
					if (false)
					{
					}
					throw ex3;
				}
			}
		}

		// Token: 0x06000107 RID: 263 RVA: 0x000143E4 File Offset: 0x000133E4
		private void a(ref string A_0)
		{
			try
			{
				switch (0)
				{
				default:
				{
					for (;;)
					{
						global::d.a(this.SelectedPak, ref A_0, false, global::d.c.c);
						global::d.b b = global::d.a(global::d.a.b, ref A_0);
						int num = 2;
						for (;;)
						{
							IL_10:
							switch (num)
							{
							case 0:
								goto IL_4F;
							case 1:
								goto IL_AA;
							case 2:
								while (b == global::d.b.c)
								{
									global::System.GC.Collect();
									switch ((1 == 1) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
										if (false)
										{
										}
										num = 1;
										goto IL_10;
									}
								}
								num = 0;
								continue;
							}
							break;
						}
					}
					IL_4F:
					global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(1835U, base.GetType().ToString(), "RetrieveUpdateInfo", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
					throw ex;
					IL_AA:
					break;
				}
				}
			}
			catch (global::custom_exception.CCustomException ex2)
			{
				throw ex2;
			}
			catch (global::System.Exception ex3)
			{
				if (!global::custom_exception.CCustomException.CheckErrorIDExsists(ex3))
				{
					ex3.Source = 2915U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex3.Source;
				}
				throw ex3;
			}
			if (true)
			{
			}
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00014508 File Offset: 0x00013508
		private string c(string A_0, string A_1)
		{
			string tempFileName;
			for (;;)
			{
				if (true)
				{
				}
				int num;
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_55:
					num = 1;
					break;
				default:
					if (false)
					{
					}
					tempFileName = global::System.IO.Path.GetTempFileName();
					num = 2;
					break;
				}
				for (;;)
				{
					global::System.IO.TextWriter textWriter;
					switch (num)
					{
					case 0:
						goto IL_107;
					case 1:
						global::System.IO.File.Delete(tempFileName);
						num = 0;
						continue;
					case 2:
						if (global::System.IO.File.Exists(tempFileName))
						{
							goto IL_55;
						}
						goto IL_107;
					case 3:
						try
						{
							num = 1;
							for (;;)
							{
								switch (num)
								{
								case 0:
									goto IL_BC;
								case 2:
								{
									byte[] bytes = global::System.Convert.FromBase64String(A_0);
									A_0 = global::System.Text.Encoding.GetEncoding(1252).GetString(bytes);
									num = 0;
									continue;
								}
								case 3:
									goto IL_CB;
								}
								if (A_1 == "Base64")
								{
									num = 2;
									continue;
								}
								IL_BC:
								textWriter.Write(A_0);
								num = 3;
							}
							IL_CB:
							goto IL_146;
						}
						finally
						{
							num = 1;
							for (;;)
							{
								switch (num)
								{
								case 0:
									goto IL_104;
								case 2:
									((global::System.IDisposable)textWriter).Dispose();
									num = 0;
									continue;
								}
								if (textWriter == null)
								{
									break;
								}
								num = 2;
							}
							IL_104:;
						}
						goto IL_107;
					}
					break;
					IL_107:
					textWriter = new global::System.IO.StreamWriter(tempFileName, false, global::System.Text.Encoding.GetEncoding(1252));
					num = 3;
				}
			}
			IL_146:
			this.ch.Add(tempFileName);
			return tempFileName;
		}

		// Token: 0x06000109 RID: 265 RVA: 0x0001467C File Offset: 0x0001367C
		public void CleanUpTempFiles()
		{
			for (;;)
			{
				string path = string.Empty;
				int num = 0;
				for (;;)
				{
					int num2;
					switch (num)
					{
					case 0:
						if (this.ch == null)
						{
							num = 8;
							continue;
						}
						num2 = 0;
						num = 1;
						continue;
					case 1:
						goto IL_B1;
					case 2:
						if (global::System.IO.File.Exists(path))
						{
							num = 3;
							continue;
						}
						goto IL_4F;
					case 3:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_106;
						default:
							if (false)
							{
							}
							global::System.IO.File.Delete(path);
							num = 5;
							continue;
						}
						break;
					case 4:
						goto IL_D5;
					case 5:
						goto IL_4F;
					case 6:
						if (num2 >= this.ch.Count)
						{
							num = 4;
							continue;
						}
						path = this.ch[num2].ToString();
						if (true)
						{
						}
						num = 2;
						continue;
					case 7:
						goto IL_B1;
					case 8:
						return;
					}
					break;
					IL_4F:
					num2++;
					num = 7;
					continue;
					IL_B1:
					num = 6;
				}
			}
			return;
			IL_D5:
			IL_106:
			this.ch = null;
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00014798 File Offset: 0x00013798
		private bool b(string A_0, string A_1)
		{
			for (;;)
			{
				IL_00:
				if (true)
				{
				}
				int num = 1;
				for (;;)
				{
					switch (num)
					{
					case 0:
						goto IL_7A;
					case 2:
						num = 3;
						continue;
					case 3:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							if (false)
							{
							}
							if (string.IsNullOrEmpty(A_1))
							{
								num = 0;
								continue;
							}
							goto IL_7C;
						}
						break;
					}
					if (string.IsNullOrEmpty(A_0))
					{
						return false;
					}
					num = 2;
				}
			}
			return false;
			IL_7A:
			return false;
			IL_7C:
			A_0 = A_0.Replace(".", "");
			A_1 = A_1.Replace(".", "");
			return A_0 == A_1;
		}

		// Token: 0x0600010B RID: 267 RVA: 0x0001484C File Offset: 0x0001384C
		private int a(string A_0, string A_1)
		{
			switch (0)
			{
			default:
			{
				for (;;)
				{
					for (;;)
					{
						int num = 3;
						for (;;)
						{
							switch (num)
							{
							case 0:
								num = 1;
								continue;
							case 1:
								if (!string.IsNullOrEmpty(A_1))
								{
									if (true)
									{
									}
									num = 6;
									continue;
								}
								goto IL_F6;
							case 2:
								if (!A_1.StartsWith("R"))
								{
									num = 7;
									continue;
								}
								goto IL_122;
							case 3:
								if (string.IsNullOrEmpty(A_0))
								{
									goto IL_F6;
								}
								switch ((1 == 1) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									if (false)
									{
									}
									num = 0;
									continue;
								}
								break;
							case 4:
								if (A_0.StartsWith("R"))
								{
									num = 5;
									continue;
								}
								goto IL_F6;
							case 5:
								num = 2;
								continue;
							case 6:
								num = 4;
								continue;
							case 7:
								goto IL_A3;
							}
							break;
						}
					}
				}
				IL_A3:
				IL_F6:
				global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(2934U, base.GetType().ToString(), "CompareReleaseVersions", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
				throw ex;
				IL_122:
				string strA = A_0.Replace(".", "").Substring(1);
				string strB = A_1.Replace(".", "").Substring(1);
				return string.Compare(strA, strB, global::System.StringComparison.Ordinal);
			}
			}
		}

		// Token: 0x04000033 RID: 51
		private const int a = 12;

		// Token: 0x04000034 RID: 52
		private const int b = 3;

		// Token: 0x04000035 RID: 53
		private const int c = 6;

		// Token: 0x04000036 RID: 54
		private const char d = 'J';

		// Token: 0x04000037 RID: 55
		private const char e = 'Q';

		// Token: 0x04000038 RID: 56
		private const char f = 'P';

		// Token: 0x04000039 RID: 57
		private const char g = 'K';

		// Token: 0x0400003A RID: 58
		private const string h = "UHF-B1";

		// Token: 0x0400003B RID: 59
		private const string i = "VHF";

		// Token: 0x0400003C RID: 60
		private const string j = "300";

		// Token: 0x0400003D RID: 61
		private const string k = "350";

		// Token: 0x0400003E RID: 62
		private const char l = 'C';

		// Token: 0x0400003F RID: 63
		private const int m = 8;

		// Token: 0x04000040 RID: 64
		internal const string n = "portable";

		// Token: 0x04000041 RID: 65
		internal const string o = "mobile";

		// Token: 0x04000042 RID: 66
		internal const string p = "repeater";

		// Token: 0x04000043 RID: 67
		internal const string q = "andorra";

		// Token: 0x04000044 RID: 68
		internal const string r = "bali";

		// Token: 0x04000045 RID: 69
		internal const string s = "belize";

		// Token: 0x04000046 RID: 70
		internal const string t = "malta";

		// Token: 0x04000047 RID: 71
		internal const string u = "bel atex";

		// Token: 0x04000048 RID: 72
		internal const string v = "bel csa";

		// Token: 0x04000049 RID: 73
		internal const string w = "timor";

		// Token: 0x0400004A RID: 74
		internal const string x = "tahiti";

		// Token: 0x0400004B RID: 75
		internal const string y = "tah plus";

		// Token: 0x0400004C RID: 76
		internal const string z = "Matrix";

		// Token: 0x0400004D RID: 77
		internal const string aa = "Bandit";

		// Token: 0x0400004E RID: 78
		internal const string ab = "Phoenix";

		// Token: 0x0400004F RID: 79
		internal const string ac = "Paradise";

		// Token: 0x04000050 RID: 80
		internal const string ad = "Malta";

		// Token: 0x04000051 RID: 81
		internal const string ae = "ParaLight";

		// Token: 0x04000052 RID: 82
		internal const string af = "PLightPlus";

		// Token: 0x04000053 RID: 83
		internal const string ag = "Bahama";

		// Token: 0x04000054 RID: 84
		internal const string ah = "Tonga";

		// Token: 0x04000055 RID: 85
		internal const string ai = "ParaRefresh";

		// Token: 0x04000056 RID: 86
		internal const string aj = "MalRefresh";

		// Token: 0x04000057 RID: 87
		internal const string ak = "ParaRefresh_ton";

		// Token: 0x04000058 RID: 88
		private bool al;

		// Token: 0x04000059 RID: 89
		private string am;

		// Token: 0x0400005A RID: 90
		private bool an;

		// Token: 0x0400005B RID: 91
		private global::System.Collections.Generic.List<string> ao;

		// Token: 0x0400005C RID: 92
		private bool ap;

		// Token: 0x0400005D RID: 93
		private bool aq;

		// Token: 0x0400005E RID: 94
		private bool ar;

		// Token: 0x0400005F RID: 95
		private string @as;

		// Token: 0x04000060 RID: 96
		private bool at;

		// Token: 0x04000061 RID: 97
		private bool au;

		// Token: 0x04000062 RID: 98
		private string av;

		// Token: 0x04000063 RID: 99
		private string aw;

		// Token: 0x04000064 RID: 100
		private bool ax;

		// Token: 0x04000065 RID: 101
		private bool ay;

		// Token: 0x04000066 RID: 102
		private string az;

		// Token: 0x04000067 RID: 103
		private string a0;

		// Token: 0x04000068 RID: 104
		private bool a1;

		// Token: 0x04000069 RID: 105
		private bool a2;

		// Token: 0x0400006A RID: 106
		private string a3;

		// Token: 0x0400006B RID: 107
		private bool a4;

		// Token: 0x0400006C RID: 108
		private string a5;

		// Token: 0x0400006D RID: 109
		private bool a6;

		// Token: 0x0400006E RID: 110
		private global::DeviceUpdate.c.a a7;

		// Token: 0x0400006F RID: 111
		private bool a8;

		// Token: 0x04000070 RID: 112
		private string a9;

		// Token: 0x04000071 RID: 113
		private bool ba;

		// Token: 0x04000072 RID: 114
		private string bb;

		// Token: 0x04000073 RID: 115
		private bool bc;

		// Token: 0x04000074 RID: 116
		private string bd;

		// Token: 0x04000075 RID: 117
		private bool be;

		// Token: 0x04000076 RID: 118
		private string bf;

		// Token: 0x04000077 RID: 119
		private bool bg;

		// Token: 0x04000078 RID: 120
		private string bh;

		// Token: 0x04000079 RID: 121
		private string bi;

		// Token: 0x0400007A RID: 122
		private bool bj;

		// Token: 0x0400007B RID: 123
		private bool bk;

		// Token: 0x0400007C RID: 124
		private global::System.Collections.Generic.List<string> bl;

		// Token: 0x0400007D RID: 125
		private bool bm;

		// Token: 0x0400007E RID: 126
		private string bn;

		// Token: 0x0400007F RID: 127
		private bool bo;

		// Token: 0x04000080 RID: 128
		private string bp;

		// Token: 0x04000081 RID: 129
		private string bq;

		// Token: 0x04000082 RID: 130
		private string br;

		// Token: 0x04000083 RID: 131
		private string bs;

		// Token: 0x04000084 RID: 132
		private string bt;

		// Token: 0x04000085 RID: 133
		private string bu;

		// Token: 0x04000086 RID: 134
		private string bv;

		// Token: 0x04000087 RID: 135
		private string bw;

		// Token: 0x04000088 RID: 136
		private string bx;

		// Token: 0x04000089 RID: 137
		private string by;

		// Token: 0x0400008A RID: 138
		private string bz;

		// Token: 0x0400008B RID: 139
		private object b0;

		// Token: 0x0400008C RID: 140
		private string b1;

		// Token: 0x0400008D RID: 141
		private bool b2;

		// Token: 0x0400008E RID: 142
		private string b3;

		// Token: 0x0400008F RID: 143
		private string b4;

		// Token: 0x04000090 RID: 144
		private string b5;

		// Token: 0x04000091 RID: 145
		private string b6;

		// Token: 0x04000092 RID: 146
		private bool b7;

		// Token: 0x04000093 RID: 147
		private bool b8;

		// Token: 0x04000094 RID: 148
		private bool b9;

		// Token: 0x04000095 RID: 149
		private bool ca;

		// Token: 0x04000096 RID: 150
		private bool cb;

		// Token: 0x04000097 RID: 151
		private bool cc;

		// Token: 0x04000098 RID: 152
		private bool cd;

		// Token: 0x04000099 RID: 153
		private int ce;

		// Token: 0x0400009A RID: 154
		private string cf;

		// Token: 0x0400009B RID: 155
		private int cg;

		// Token: 0x0400009C RID: 156
		private global::System.Collections.ArrayList ch;

		// Token: 0x0400009D RID: 157
		private string ci;

		// Token: 0x0400009E RID: 158
		private string cj;

		// Token: 0x0400009F RID: 159
		private string ck;

		// Token: 0x040000A0 RID: 160
		private string cl;

		// Token: 0x040000A1 RID: 161
		private string cm;

		// Token: 0x040000A2 RID: 162
		private string cn;

		// Token: 0x040000A3 RID: 163
		private bool co;

		// Token: 0x040000A4 RID: 164
		private bool cp;

		// Token: 0x040000A5 RID: 165
		private bool cq;

		// Token: 0x040000A6 RID: 166
		private bool cr;

		// Token: 0x040000A7 RID: 167
		private bool cs;

		// Token: 0x040000A8 RID: 168
		private string ct;

		// Token: 0x040000A9 RID: 169
		private string cu;

		// Token: 0x040000AA RID: 170
		private string cv;

		// Token: 0x040000AB RID: 171
		private string cw;

		// Token: 0x040000AC RID: 172
		private string cx;

		// Token: 0x040000AD RID: 173
		private string cy;

		// Token: 0x040000AE RID: 174
		private string cz;

		// Token: 0x040000AF RID: 175
		private bool c0;

		// Token: 0x040000B0 RID: 176
		private bool c1;

		// Token: 0x040000B1 RID: 177
		private bool c2;

		// Token: 0x040000B2 RID: 178
		private string c3;

		// Token: 0x040000B3 RID: 179
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool c4;

		// Token: 0x02000009 RID: 9
		private enum a
		{
			// Token: 0x040000B5 RID: 181
			a,
			// Token: 0x040000B6 RID: 182
			b,
			// Token: 0x040000B7 RID: 183
			c,
			// Token: 0x040000B8 RID: 184
			d,
			// Token: 0x040000B9 RID: 185
			e,
			// Token: 0x040000BA RID: 186
			f,
			// Token: 0x040000BB RID: 187
			g,
			// Token: 0x040000BC RID: 188
			h,
			// Token: 0x040000BD RID: 189
			i
		}
	}
}
