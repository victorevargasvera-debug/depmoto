using System;

namespace Motorola.Common.Communication.SequenceManager
{
	// Token: 0x0200003F RID: 63
	internal static class PcrConstants
	{
		// Token: 0x04000128 RID: 296
		public const string AndorraUUID = "0571AFE244664F999A96B020E82DC69C";

		// Token: 0x04000129 RID: 297
		public const string TimorUUID = "0C0D6EE58204FBDEBB8860C631AB465A";

		// Token: 0x0400012A RID: 298
		public const string TahitiUUID = "C4FC39D8DEF24B779D1CB719AF26A269";

		// Token: 0x0400012B RID: 299
		public const string TahitiPlusUUID = "C52A3D4953FE469D8E11F05B143E8C56";

		// Token: 0x0400012C RID: 300
		public const string BahamaUUID = "AF5DAB63F4FC4926BB9000A6F18AF3DC";

		// Token: 0x0400012D RID: 301
		public const string TongaPlusUUID = "EBCCE9BF33B14896B5C2E7E3AA19AF0F";

		// Token: 0x0400012E RID: 302
		public const int MaxXcmpPacketSize = 1000;

		// Token: 0x0400012F RID: 303
		public const int MaxDataTransferSizeForParadise20 = 968;

		// Token: 0x04000130 RID: 304
		public const int MaxDataTransferSizeForParadise21 = 1446;

		// Token: 0x04000131 RID: 305
		public const string Paradise205CodeplugVersion = "020000";

		// Token: 0x04000132 RID: 306
		public const string Paradise21CodeplugVersion = "030000";

		// Token: 0x04000133 RID: 307
		public const string Paradise23CodeplugVersion = "060000";

		// Token: 0x04000134 RID: 308
		public const string Paradise23ACodeplugVersion_No_PasswordStatus_Max_Limit = "060106";

		// Token: 0x04000135 RID: 309
		private const int ReorgIshPartitionTimeout = 90000;

		// Token: 0x04000136 RID: 310
		public const int BOOTJUMPEXECUTION_TIMEOUT_CONSTANT = 6500;

		// Token: 0x04000137 RID: 311
		public const int READRADIODKEY_TIMEOUT_CONSTANT = 2500;

		// Token: 0x04000138 RID: 312
		public const int UNLOCKSECURITY_TIMEOUT_CONSTANT = 3500;

		// Token: 0x04000139 RID: 313
		public const int VERSIONINFORMATION_TIMEOUT_CONSTANT = 6500;

		// Token: 0x0400013A RID: 314
		public const int READMEMORY_TIMEOUT_CONSTANT = 11500;

		// Token: 0x0400013B RID: 315
		public const int WRITEMEMORY_TIMEOUT_CONSTANT = 6500;

		// Token: 0x0400013C RID: 316
		public const int WRITEFTL_TIMEOUT_CONSTANT = 20000;

		// Token: 0x0400013D RID: 317
		public const int BOOTCOMMIT_WRITE_TIMEOUT_CONSTANT = 60000;

		// Token: 0x0400013E RID: 318
		public const int BOOTCOMMIT_QUERYSTATUS_TIMEOUT_CONSTANT = 120000;

		// Token: 0x0400013F RID: 319
		public const int RESETRADIO_TIMEOUT_CONSTANT = 6500;

		// Token: 0x04000140 RID: 320
		public const int ENTERBOOTMODE_TIMEOUT_CONSTANT = 6500;

		// Token: 0x04000141 RID: 321
		public const int REMOTEDUPLICATESETUP_TIMEOUT_CONSTANT = 6500;

		// Token: 0x04000142 RID: 322
		public const int REMOTECONNECT_TIMEOUT_CONSTANT = 6500;

		// Token: 0x04000143 RID: 323
		public const int REMOTEDISCONNECT_TIMEOUT_CONSTANT = 6500;

		// Token: 0x04000144 RID: 324
		public const int READPSDT_TIMEOUT_CONSTANT = 6500;

		// Token: 0x04000145 RID: 325
		public const int ERASE_TIMEOUT_PER_64K = 1200;

		// Token: 0x04000146 RID: 326
		public const int ERASE_TIMEOUT_CONSTANT = 3200;

		// Token: 0x04000147 RID: 327
		public const int CONST_TIMEOUT_TIME = 1500;

		// Token: 0x04000148 RID: 328
		private const int WRITE_TIMEOUT_CONSTANT = 250;

		// Token: 0x04000149 RID: 329
		public const int FLASHZAP_64K_BLOCK_SIZE = 65536;

		// Token: 0x0400014A RID: 330
		public const int MAX_READ_PACKET_SIZE = 906;

		// Token: 0x0400014B RID: 331
		public const int MAX_WRITE_PACKET_SIZE = 907;

		// Token: 0x0400014C RID: 332
		public const int MaxTxPacketSize = 1500;

		// Token: 0x0400014D RID: 333
		public const int MaxRxPacketSize = 1500;

		// Token: 0x0400014E RID: 334
		public const int MAX_DATA_OBJECT_SIZE = 9568256;

		// Token: 0x0400014F RID: 335
		public const int SEED = 1374194977;

		// Token: 0x04000150 RID: 336
		public const int KEY_SIZE = 32;

		// Token: 0x04000151 RID: 337
		public const long PSDT_START_ADDRESS = 201383936L;

		// Token: 0x04000152 RID: 338
		public const long PSDT_END_ADDRESS = 201392127L;

		// Token: 0x04000153 RID: 339
		public const ulong VIR_MEM_BASE_ADDRESS = 201326592UL;

		// Token: 0x04000154 RID: 340
		public const string ACTIVE_PSDT = "PSDX";

		// Token: 0x04000155 RID: 341
		private const string ACTIVE_SECA = "SECX";

		// Token: 0x04000156 RID: 342
		public const uint RAM_START_ADDRESS = 270532608U;

		// Token: 0x04000157 RID: 343
		public const ushort RegionInIshType = 4112;

		// Token: 0x04000158 RID: 344
		public const ushort RegionInIshID = 0;

		// Token: 0x04000159 RID: 345
		public const ushort RegionFieldOffset = 78;

		// Token: 0x0400015A RID: 346
		public const ushort TanapaNumberIshType = 4112;

		// Token: 0x0400015B RID: 347
		public const ushort TanapaNumberIshID = 0;

		// Token: 0x0400015C RID: 348
		public const ushort TanapaNumberFieldOffset = 64;

		// Token: 0x0400015D RID: 349
		public const ushort TanapaNumberFieldLength = 10;

		// Token: 0x0400015E RID: 350
		public const string BadCMSSHostID = "0";

		// Token: 0x0400015F RID: 351
		public static ushort[] OtapReadPartitions = new ushort[]
		{
			128,
			135,
			129
		};

		// Token: 0x04000160 RID: 352
		public static ushort[] OtapWritePartitions = new ushort[]
		{
			128
		};
	}
}
