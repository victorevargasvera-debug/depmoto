using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace Motorola.Common.Communication.TetraUtility
{
	// Token: 0x02000073 RID: 115
	public static class TetraCommConstants
	{
		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060002C4 RID: 708 RVA: 0x0000DC3C File Offset: 0x0000BE3C
		public static string[] GEMSTONE_PLATFORM_PRODUCT_LIST
		{
			get
			{
				return global::Motorola.Common.Communication.TetraUtility.TetraCommConstants._GEMSTONE_PLATFORM_PRODUCT_LIST;
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060002C5 RID: 709 RVA: 0x0000DC43 File Offset: 0x0000BE43
		public static string[] FRODO_RADIO_PRODUCT_LIST
		{
			get
			{
				return global::Motorola.Common.Communication.TetraUtility.TetraCommConstants._FRODO_RADIO_PRODUCT_LIST;
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060002C6 RID: 710 RVA: 0x0000DC4A File Offset: 0x0000BE4A
		public static string[] GemstoneBMP_RADIO_PRODUCT_LIST
		{
			get
			{
				return global::Motorola.Common.Communication.TetraUtility.TetraCommConstants._GemstoneBMP_RADIO_PRODUCT_LIST;
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060002C7 RID: 711 RVA: 0x0000DC51 File Offset: 0x0000BE51
		public static string CommConfigDir
		{
			get
			{
				return global::System.IO.Path.Combine(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.MetaDataDir + "\\", global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMMUNICATION_COMM_CONFIG_METADATA_FOLDER);
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060002C8 RID: 712 RVA: 0x0000DC6C File Offset: 0x0000BE6C
		public static string CommKernelDir
		{
			get
			{
				return global::System.IO.Path.Combine(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.MetaDataDir + "\\", global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMMUNICATION_COMM_KERNEL_METADATA_FOLDER);
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060002C9 RID: 713 RVA: 0x0000DC87 File Offset: 0x0000BE87
		public static string ModelTableDir
		{
			get
			{
				return global::System.IO.Path.Combine(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.MetaDataDir + "\\", global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMMUNICATION_COMM_MODEL_TABLE_METADATA_FOLDER);
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060002CA RID: 714 RVA: 0x0000DCA4 File Offset: 0x0000BEA4
		public static string FlashRegionBackupDir
		{
			get
			{
				return global::System.IO.Path.GetFullPath(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.BinDir + "\\" + global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMMUNICATION_FLASH_REGION_BACKUP_FOLDER);
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060002CB RID: 715 RVA: 0x0000DCCC File Offset: 0x0000BECC
		public static string BinDir
		{
			get
			{
				if (string.IsNullOrEmpty(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants._binDir))
				{
					global::System.Reflection.Assembly assembly = global::System.Reflection.Assembly.GetEntryAssembly();
					if (assembly == null)
					{
						assembly = global::System.Reflection.Assembly.GetCallingAssembly();
					}
					if (assembly == null)
					{
						assembly = global::System.Reflection.Assembly.GetExecutingAssembly();
					}
					if (assembly != null)
					{
						global::Motorola.Common.Communication.TetraUtility.TetraCommConstants._binDir = global::System.IO.Path.GetDirectoryName(assembly.Location);
					}
					else
					{
						global::Motorola.Common.Communication.TetraUtility.TetraCommConstants._binDir = global::System.Diagnostics.Process.GetCurrentProcess().StartInfo.WorkingDirectory;
					}
				}
				return global::Motorola.Common.Communication.TetraUtility.TetraCommConstants._binDir;
			}
		}

		// Token: 0x060002CC RID: 716 RVA: 0x0000DD40 File Offset: 0x0000BF40
		public static bool IsCPSInTestMode()
		{
			bool result = false;
			string text = string.Empty;
			text = global::Motorola.Common.Communication.TetraUtility.OptionsDatabaseSingleton.Instance.GetValue(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.OPTIONS_CPS_WORK_MODE_SECTION, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.OPT_CURRENT_WORK_MODE);
			if (!string.IsNullOrEmpty(text) && text.Equals(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.CPS_TEST_MODE, global::System.StringComparison.InvariantCultureIgnoreCase))
			{
				result = true;
			}
			return result;
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060002CD RID: 717 RVA: 0x0000DD84 File Offset: 0x0000BF84
		private static string MetaDataDir
		{
			get
			{
				return global::System.IO.Path.GetFullPath(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.BinDir + "\\" + global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMMUNICATION_METADATA_FOLDER);
			}
		}

		// Token: 0x04000320 RID: 800
		public static readonly uint MAX_READ_SIZE = 8192U;

		// Token: 0x04000321 RID: 801
		public static readonly uint MAX_WRITE_SIZE = 8192U;

		// Token: 0x04000322 RID: 802
		public static readonly uint MAX_ERASE_SIZE = 4194304U;

		// Token: 0x04000323 RID: 803
		public static readonly uint MAX_COMPRESS_WRITE_SIZE = global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.MAX_WRITE_SIZE * 2U;

		// Token: 0x04000324 RID: 804
		public static readonly uint MAX_SPLIT_WRITE_SIZE = 63U;

		// Token: 0x04000325 RID: 805
		public static readonly uint DEFAULT_TIMEOUT = 20000U;

		// Token: 0x04000326 RID: 806
		public static readonly string COMM_LOGGER_NAME = "Communication_Logger";

		// Token: 0x04000327 RID: 807
		public static readonly string SBEP_PERFORMANCE_LOGGER_NAME = "SBEP_Performance_Logger";

		// Token: 0x04000328 RID: 808
		public static readonly string RP_PERFORMANCE_LOGGER_NAME = "RP_Performance_Logger";

		// Token: 0x04000329 RID: 809
		public static readonly string OPT_HWID_VALUE = "OPT_HWID_VALUE";

		// Token: 0x0400032A RID: 810
		public static readonly string OPT_FORCE_HWID = "OPT_FORCE_HWID";

		// Token: 0x0400032B RID: 811
		public static readonly string OPTIONS_SERVICE_SECTION = "OPTIONS_SERVICE_SECTION";

		// Token: 0x0400032C RID: 812
		public static readonly string COMMUNICATION_METADATA_FOLDER = "comm_metadata";

		// Token: 0x0400032D RID: 813
		public static readonly string COMMUNICATION_COMM_CONFIG_METADATA_FOLDER = "comm_config";

		// Token: 0x0400032E RID: 814
		public static readonly string COMMUNICATION_COMM_KERNEL_METADATA_FOLDER = "comm_kernel";

		// Token: 0x0400032F RID: 815
		public static readonly string COMMUNICATION_COMM_MODEL_TABLE_METADATA_FOLDER = "model_table";

		// Token: 0x04000330 RID: 816
		public static readonly string COMMUNICATION_FLASH_REGION_BACKUP_FOLDER = "flash_region_backup";

		// Token: 0x04000331 RID: 817
		public static readonly string RADIO_OPERATION_PERFORMANCE_LOGGER_NAME = "Radio_Operation_Performance_Logger";

		// Token: 0x04000332 RID: 818
		public static readonly int FDI_CP_WORD_SIZE_PTR = 13;

		// Token: 0x04000333 RID: 819
		public static readonly int FDI_CP_DWORD_SIZE_PTR = 21;

		// Token: 0x04000334 RID: 820
		public static readonly int FDI_CP_HOME_MCC_OFFSET = 32;

		// Token: 0x04000335 RID: 821
		public static readonly int FDI_CP_HOME_MNC_OFFSET = 34;

		// Token: 0x04000336 RID: 822
		public static readonly int FDI_CP_STRUCT_VER_OFFSET = 36;

		// Token: 0x04000337 RID: 823
		public static readonly int FDI_CP_DEFAULT_VER_OFFSET = 38;

		// Token: 0x04000338 RID: 824
		public static readonly int FDI_CP_MODEL_TYPE_OFFSET = 40;

		// Token: 0x04000339 RID: 825
		public static readonly int FDI_CP_MODEL_NUM_OFFSET = 41;

		// Token: 0x0400033A RID: 826
		public static readonly int FDI_CP_SERIAL_NUM_OFFSET = 58;

		// Token: 0x0400033B RID: 827
		public static readonly int FDI_CP_RADIO_VER_OFFSET = 0;

		// Token: 0x0400033C RID: 828
		public static readonly int FDI_CP_HW_ID_OFFSET = 72;

		// Token: 0x0400033D RID: 829
		public static readonly int FDI_CP_ISSI_OFFSET = global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.FDI_CP_HW_ID_OFFSET + 4;

		// Token: 0x0400033E RID: 830
		public static readonly int FDI_CP_TEI_OFFSET = global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.FDI_CP_ISSI_OFFSET + 14;

		// Token: 0x0400033F RID: 831
		public static readonly int FDI_CP_RPP_OFFSET = 440;

		// Token: 0x04000340 RID: 832
		public static readonly int FDI_CP_RPP_OFFSET_MILAN2 = 274;

		// Token: 0x04000341 RID: 833
		public static readonly ushort CP_RPP_SIZE = 100;

		// Token: 0x04000342 RID: 834
		public static readonly string FDI_ROOT_BLOCK_ID = "RT";

		// Token: 0x04000343 RID: 835
		public static readonly int BAUDRATE_9600 = 9600;

		// Token: 0x04000344 RID: 836
		public static readonly int DOWNLOAD_KERNEL_RESET_TIMEOUT = 120000;

		// Token: 0x04000345 RID: 837
		public static readonly int RP_RESET_TIMEOUT = 120000;

		// Token: 0x04000346 RID: 838
		public static readonly string MEM_MAP_CP_SECTION = "CODEPLUG";

		// Token: 0x04000347 RID: 839
		public static readonly string MEM_MAP_FW_SECTION = "FIRMWARE";

		// Token: 0x04000348 RID: 840
		public static readonly string MEM_MAP_KEY_SECTION = "KEY";

		// Token: 0x04000349 RID: 841
		public static readonly string MEM_MAP_FLASH_STRAP_SECTION = "FLASHTRAP";

		// Token: 0x0400034A RID: 842
		public static readonly string MEM_MAP_FDT_SECTION = "FDT";

		// Token: 0x0400034B RID: 843
		public static readonly string MEM_MAP_RELEASEID_SECTION = "RELEASEIDPTR";

		// Token: 0x0400034C RID: 844
		public static readonly string MEM_MAP_FLASHPACK_SECTION = "FLASHPACKS";

		// Token: 0x0400034D RID: 845
		public static readonly string OMAP_KERNEL_NAME = "NEW_OMAP_KERNEL.s19";

		// Token: 0x0400034E RID: 846
		public static readonly string PATRIOT_RF_KERNEL_NAME = "NEW_KRNL_PATRIOT.s19";

		// Token: 0x0400034F RID: 847
		public static readonly string PATRIOT_KERNEL_NAME = "KRNL_PATRIOT.s19";

		// Token: 0x04000350 RID: 848
		public static readonly string PATRIOT_MINI_KERNEL_NAME = "MINI_KERNEL.s19";

		// Token: 0x04000351 RID: 849
		public static readonly int SOFTWARE_NAME_LENGTH = 10;

		// Token: 0x04000352 RID: 850
		public static readonly int SOFTWARE_NAME_WITH_DOT_LENGTH = 12;

		// Token: 0x04000353 RID: 851
		public static readonly int PRODUCT_LINE_NAME_LENGTH = 3;

		// Token: 0x04000354 RID: 852
		public static readonly int SOFTWARE_E2E_TYPE_LENGTH = 3;

		// Token: 0x04000355 RID: 853
		public static readonly int SOFTWARE_VERSION_LENGTH = 4;

		// Token: 0x04000356 RID: 854
		public static readonly string SOFTWARE_VERSION_PATTERN = "(?<release_type>[a-zA-Z]{1})(?<platform_id>\\d{2})\\.?(?<e2e_type>\\d{1})(?<tea_type>\\d{1})\\d{1}\\.?(?<sw_version>\\d{4})";

		// Token: 0x04000357 RID: 855
		public static readonly string SOFTWARE_VERSION_RELEASE_TYPE_GROUP = "release_type";

		// Token: 0x04000358 RID: 856
		public static readonly string SOFTWARE_VERSION_PLATFORM_ID_GROUP = "platform_id";

		// Token: 0x04000359 RID: 857
		public static readonly string SOFTWARE_VERSION_E2E_TYPE_GROUP = "e2e_type";

		// Token: 0x0400035A RID: 858
		public static readonly string SOFTWARE_VERSION_TEA_TYPE_GROUP = "tea_type";

		// Token: 0x0400035B RID: 859
		public static readonly string SOFTWARE_VERSION_VERSION_GROUP = "sw_version";

		// Token: 0x0400035C RID: 860
		public static readonly string SUPPORT_FDT_OPERATION = "true";

		// Token: 0x0400035D RID: 861
		public static readonly string MEM_REGION_ENTIRE = "Entire Flash";

		// Token: 0x0400035E RID: 862
		public static readonly string MEM_REGION_CODEPLUG = "Codeplug";

		// Token: 0x0400035F RID: 863
		public static readonly string MEM_REGION_SOFTWARE = "Software";

		// Token: 0x04000360 RID: 864
		public static readonly string MEM_REGION_FLASH_RANGE = "Flash Range";

		// Token: 0x04000361 RID: 865
		public static readonly string MEM_REGION_CP_ONLY = "Codeplug Area Only";

		// Token: 0x04000362 RID: 866
		public static readonly uint GEMSTONE_CP_HEAD_SIZE = 32U;

		// Token: 0x04000363 RID: 867
		public static readonly uint CP_SECTION_ID = 217461104U;

		// Token: 0x04000364 RID: 868
		public static readonly uint CP_SECTION_ID_OFFSET = 0U;

		// Token: 0x04000365 RID: 869
		public static readonly uint CP_IMAGE_SIZE_OFFSET = 4U;

		// Token: 0x04000366 RID: 870
		public static readonly uint CP_IMAGE_VERSION_ID_OFFSET = 16U;

		// Token: 0x04000367 RID: 871
		public static readonly uint CP_MODEL_TYPE_OFFSET = 26U;

		// Token: 0x04000368 RID: 872
		public static readonly uint CP_VERSION_OFFSET = 28U;

		// Token: 0x04000369 RID: 873
		public static readonly string CP_HEAD_SIGNATURE = "HDCODEPLUG";

		// Token: 0x0400036A RID: 874
		public static readonly ushort GEMSTONE_BLOCK_ID = 18240;

		// Token: 0x0400036B RID: 875
		private static readonly string[] _GEMSTONE_PLATFORM_PRODUCT_LIST = new string[]
		{
			"FRODO",
			"FREON_PORTABLE"
		};

		// Token: 0x0400036C RID: 876
		private static readonly string[] _FRODO_RADIO_PRODUCT_LIST = new string[]
		{
			"FRODO",
			"FREON_PORTABLE"
		};

		// Token: 0x0400036D RID: 877
		private static readonly string[] _GemstoneBMP_RADIO_PRODUCT_LIST = new string[]
		{
			"FREON_PORTABLE"
		};

		// Token: 0x0400036E RID: 878
		public static readonly string[] MILAN2_RADIO_PRODUCT_LIST = new string[]
		{
			"MILAN2"
		};

		// Token: 0x0400036F RID: 879
		public static readonly int MIN_WAIT_TIME = 3000;

		// Token: 0x04000370 RID: 880
		public static readonly uint FLASHPACK_IMAGE_HEADER_SIZE = 32U;

		// Token: 0x04000371 RID: 881
		public static readonly uint FLASHPACK_IMAGE_ID = 217461248U;

		// Token: 0x04000372 RID: 882
		public static readonly uint FLASHPACK_IMAGE_VERSION_ID = 0U;

		// Token: 0x04000373 RID: 883
		public static readonly uint SECTION_ID_OFFSET = 0U;

		// Token: 0x04000374 RID: 884
		public static readonly uint FLASHPACK_IMAGE_SIZE_OFFSET = 4U;

		// Token: 0x04000375 RID: 885
		public static readonly int FLASHPACK_SLOTS_NUMBER = 128;

		// Token: 0x04000376 RID: 886
		public static readonly uint FLASHPACK_START_ADDRESS = 536870912U;

		// Token: 0x04000377 RID: 887
		public static readonly uint FLASHPACK_END_ADDRESS = 1610612735U;

		// Token: 0x04000378 RID: 888
		public static readonly uint FLASHPACK_SLOT_SIZE = 8388608U;

		// Token: 0x04000379 RID: 889
		public static readonly uint LocalLanguagePackSize = 131072U;

		// Token: 0x0400037A RID: 890
		public static readonly int SHORT_WAIT_TIME_OUT = 2500;

		// Token: 0x0400037B RID: 891
		public static readonly string FLASHPACK_LOGGER_NAME = "GemstoneBMP_flashpack_Logger";

		// Token: 0x0400037C RID: 892
		public static readonly uint RELEASE_ID_SIZE_WITH_FP = 264U;

		// Token: 0x0400037D RID: 893
		public static readonly uint RELEASE_ID_SIZE_WITHOUT_FP = 113U;

		// Token: 0x0400037E RID: 894
		private static string _binDir = string.Empty;

		// Token: 0x0400037F RID: 895
		public static readonly uint CP_STATIC_ADDRESS = 917504U;

		// Token: 0x04000380 RID: 896
		public static readonly int EBO_INTEL = 0;

		// Token: 0x04000381 RID: 897
		public static readonly int EBO_MOTOROLA = 3;

		// Token: 0x04000382 RID: 898
		public static readonly ushort ROOT_BLOCK_CACHE_SIZE = 1024;

		// Token: 0x04000383 RID: 899
		public static readonly uint SERIAL_NUMBER_LENGTH = 11U;

		// Token: 0x04000384 RID: 900
		public static readonly int CHECK_WCF_LIVE_MILLISECONDS = 7200000;

		// Token: 0x04000385 RID: 901
		public static readonly string RP_CH_PREFIX = "CH";

		// Token: 0x04000386 RID: 902
		public static readonly uint GEMSTONE_KERNEL_HEADER = 32U;

		// Token: 0x04000387 RID: 903
		public static readonly uint FRODO_RADIO_CP_START_ADDRESS = 335544320U;

		// Token: 0x04000388 RID: 904
		public static readonly uint FRODO_IMAGE_HEADER_SIZE = 32U;

		// Token: 0x04000389 RID: 905
		public static readonly uint FRODO_REGION_LENGTH_OFFSET = 4U;

		// Token: 0x0400038A RID: 906
		public static readonly int CP_VERSION_STRING_LENGTH = 4;

		// Token: 0x0400038B RID: 907
		public static readonly int BAUD_RATE_SBEP = 115200;

		// Token: 0x0400038C RID: 908
		public static readonly int BAUD_RATE_MINIKERNEL = 9600;

		// Token: 0x0400038D RID: 909
		public static readonly int BAUD_RATE_KERNEL = 19200;

		// Token: 0x0400038E RID: 910
		public static readonly int BAUD_RATE_14400 = 14400;

		// Token: 0x0400038F RID: 911
		public static readonly int BAUD_RATE_57600 = 57600;

		// Token: 0x04000390 RID: 912
		public static readonly uint GEMSTONE_RADIO_CP_START_ADDRESS = 335544320U;

		// Token: 0x04000391 RID: 913
		public static readonly uint GEMSTONE_IMAGE_HEADER_SIZE = 32U;

		// Token: 0x04000392 RID: 914
		public static readonly uint GEMSTONE_REGION_LENGTH_OFFSET = 4U;

		// Token: 0x04000393 RID: 915
		public static readonly string RADIO_DEFAULT_LANGUAGE = "BRITISH ENGLISH";

		// Token: 0x04000394 RID: 916
		public static readonly string MASS_STORAGE_LOCATION_PREFIX = "MASS_STORAGE_";

		// Token: 0x04000395 RID: 917
		public static readonly string MASS_STORAGE_PNP_STRING = "MTP6000_STORAGE";

		// Token: 0x04000396 RID: 918
		public static readonly string OPTIONS_CPS_WORK_MODE_SECTION = "OPTIONS_CPS_WORK_MODE_SECTION";

		// Token: 0x04000397 RID: 919
		public static readonly string OPT_CURRENT_WORK_MODE = "OPT_CURRENT_WORK_MODE";

		// Token: 0x04000398 RID: 920
		public static readonly string CPS_NORMAL_MODE = "Normal Mode";

		// Token: 0x04000399 RID: 921
		public static readonly string CPS_TEST_MODE = "Test Mode";

		// Token: 0x0400039A RID: 922
		public static readonly int RP_RETRY_TIMES = 20;

		// Token: 0x0400039B RID: 923
		public static readonly int FUK_MAX_DATA_TRANS_SIZE = 64;
	}
}
