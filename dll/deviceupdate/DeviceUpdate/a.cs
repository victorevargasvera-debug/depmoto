using System;
using System.Runtime.InteropServices;

namespace DeviceUpdate
{
	// Token: 0x02000022 RID: 34
	public class a
	{
		// Token: 0x060000FF RID: 255 RVA: 0x0002BE88 File Offset: 0x0002AE88
		public static int a(int A_0)
		{
			int result;
			for (;;)
			{
				result = 0;
				int num = 5;
				for (;;)
				{
					switch (num)
					{
					case 0:
						return result;
					case 1:
						num = 8;
						continue;
					case 2:
						goto IL_C6;
					case 3:
						return result;
					case 4:
						goto IL_11D;
					case 5:
						if (A_0 <= 20)
						{
							num = 13;
							continue;
						}
						num = 6;
						continue;
					case 6:
						if (A_0 != 23)
						{
							num = 11;
							continue;
						}
						result = 2;
						num = 10;
						continue;
					case 7:
						if (true)
						{
						}
						if (A_0 == 30)
						{
							num = 9;
							continue;
						}
						return result;
					case 8:
						if (A_0 != 20)
						{
							num = 12;
							continue;
						}
						result = 2;
						num = 2;
						continue;
					case 9:
						result = 3;
						num = 0;
						continue;
					case 10:
						goto IL_6F;
					case 11:
						num = 7;
						continue;
					case 12:
						num = 3;
						continue;
					case 13:
						num = 14;
						continue;
					case 14:
						if (A_0 != 10)
						{
							num = 1;
							continue;
						}
						result = 1;
						num = 4;
						continue;
					}
					break;
				}
			}
			IL_6F:
			return result;
			IL_C6:
			switch ((1 == 1) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_11D:
				break;
			default:
				if (false)
				{
				}
				break;
			}
			return result;
		}

		// Token: 0x0400012D RID: 301
		public const string a = "USB";

		// Token: 0x0400012E RID: 302
		public const string b = "*";

		// Token: 0x0400012F RID: 303
		public const string c = "*.*";

		// Token: 0x04000130 RID: 304
		public const string d = "FLASH_PACK";

		// Token: 0x04000131 RID: 305
		public const string e = "PACKVERSION";

		// Token: 0x04000132 RID: 306
		public const string f = "MODEL";

		// Token: 0x04000133 RID: 307
		public const string g = "REGION";

		// Token: 0x04000134 RID: 308
		public const string h = "FIRMWARE";

		// Token: 0x04000135 RID: 309
		public const string i = "FTL_APP_SEC_CFS";

		// Token: 0x04000136 RID: 310
		public const string j = "FTL_TUNING";

		// Token: 0x04000137 RID: 311
		public const string k = "FWPRODUCTIONNAME";

		// Token: 0x04000138 RID: 312
		public const string l = "VERSION";

		// Token: 0x04000139 RID: 313
		public const string m = "CPVERSION";

		// Token: 0x0400013A RID: 314
		public const string n = "PARTITION";

		// Token: 0x0400013B RID: 315
		public const string o = "CODEPLUG";

		// Token: 0x0400013C RID: 316
		public const string p = "CPLG";

		// Token: 0x0400013D RID: 317
		public const string q = "SECURITY";

		// Token: 0x0400013E RID: 318
		public const string r = "SECP";

		// Token: 0x0400013F RID: 319
		public const string s = "TUNING";

		// Token: 0x04000140 RID: 320
		public const string t = "UCL";

		// Token: 0x04000141 RID: 321
		public const string u = "TUNE";

		// Token: 0x04000142 RID: 322
		public const string v = "CFS";

		// Token: 0x04000143 RID: 323
		public const string w = "UDP";

		// Token: 0x04000144 RID: 324
		public const string x = "APPLICATION";

		// Token: 0x04000145 RID: 325
		public const string y = "APP";

		// Token: 0x04000146 RID: 326
		public const string z = "STRUCTURE_FILE";

		// Token: 0x04000147 RID: 327
		public const string aa = "RAMDLOADER";

		// Token: 0x04000148 RID: 328
		public const string ab = "BOOTSCRIPT";

		// Token: 0x04000149 RID: 329
		public const string ac = "CPS_BUILD";

		// Token: 0x0400014A RID: 330
		public const string ad = "CREATOR_USERNAME";

		// Token: 0x0400014B RID: 331
		public const string ae = "CREATION_TIME";

		// Token: 0x0400014C RID: 332
		public const string af = "ISH_COMP";

		// Token: 0x0400014D RID: 333
		public const string ag = "<";

		// Token: 0x0400014E RID: 334
		public const string ah = "/>";

		// Token: 0x0400014F RID: 335
		public const string ai = ">";

		// Token: 0x04000150 RID: 336
		public const string aj = "</";

		// Token: 0x04000151 RID: 337
		public const string ak = ", ";

		// Token: 0x04000152 RID: 338
		public const string al = "|";

		// Token: 0x04000153 RID: 339
		public const string am = "TREE_NODE_TYPES";

		// Token: 0x04000154 RID: 340
		public const string an = "TREE_NODE";

		// Token: 0x04000155 RID: 341
		public const string ao = "PARENT_NODE";

		// Token: 0x04000156 RID: 342
		public const string ap = "NONE";

		// Token: 0x04000157 RID: 343
		public const string aq = "TYPE";

		// Token: 0x04000158 RID: 344
		public const string ar = "BAND";

		// Token: 0x04000159 RID: 345
		public const string @as = "ISH_TYPE";

		// Token: 0x0400015A RID: 346
		public const string at = "ISH_ID";

		// Token: 0x0400015B RID: 347
		public const string au = "RATIO";

		// Token: 0x0400015C RID: 348
		public const string av = "BLOCK";

		// Token: 0x0400015D RID: 349
		public const string aw = "1";

		// Token: 0x0400015E RID: 350
		public const string ax = "0";

		// Token: 0x0400015F RID: 351
		public const string ay = "STRING";

		// Token: 0x04000160 RID: 352
		public const string az = "INT";

		// Token: 0x04000161 RID: 353
		public const string a0 = "OCTAL";

		// Token: 0x04000162 RID: 354
		public const string a1 = "HEX";

		// Token: 0x04000163 RID: 355
		public const string a2 = "Y";

		// Token: 0x04000164 RID: 356
		public const string a3 = "N";

		// Token: 0x04000165 RID: 357
		public const string a4 = "UUID";

		// Token: 0x04000166 RID: 358
		public const string a5 = "<Tree>";

		// Token: 0x04000167 RID: 359
		public const string a6 = "</Tree>";

		// Token: 0x04000168 RID: 360
		public const string a7 = "<TreeNode>";

		// Token: 0x04000169 RID: 361
		public const string a8 = "</TreeNode>";

		// Token: 0x0400016A RID: 362
		public const string a9 = "<NodeID>";

		// Token: 0x0400016B RID: 363
		public const string ba = ">";

		// Token: 0x0400016C RID: 364
		public const string bb = "</NodeID>";

		// Token: 0x0400016D RID: 365
		public const string bc = "<NodeParent>";

		// Token: 0x0400016E RID: 366
		public const string bd = "</NodeParent>";

		// Token: 0x0400016F RID: 367
		public const string be = "</CODEPLUG>";

		// Token: 0x04000170 RID: 368
		public const string bf = "CHILD";

		// Token: 0x04000171 RID: 369
		public const string bg = "//";

		// Token: 0x04000172 RID: 370
		public const string bh = "NA";

		// Token: 0x04000173 RID: 371
		public const string bi = "'";

		// Token: 0x04000174 RID: 372
		public const string bj = "HAVNCPSLTDTUNERAIRTRACER";

		// Token: 0x04000175 RID: 373
		public const string bk = "VEDKDJSP";

		// Token: 0x04000176 RID: 374
		public const string bl = ".lmx";

		// Token: 0x04000177 RID: 375
		public const string bm = "*.lmx";

		// Token: 0x04000178 RID: 376
		public const string bn = "*.pak";

		// Token: 0x04000179 RID: 377
		public const string bo = "FlashPack";

		// Token: 0x0400017A RID: 378
		public const int bp = 1024;

		// Token: 0x0400017B RID: 379
		public const long bq = 270532608L;

		// Token: 0x0400017C RID: 380
		public const long br = 69206016L;

		// Token: 0x0400017D RID: 381
		public const long bs = 57344L;

		// Token: 0x0400017E RID: 382
		public const long bt = 0L;

		// Token: 0x0400017F RID: 383
		public const long bu = 0L;

		// Token: 0x04000180 RID: 384
		public const long bv = 201326592L;

		// Token: 0x04000181 RID: 385
		public const ulong bw = 201326592UL;

		// Token: 0x04000182 RID: 386
		public const string bx = "PRESERVE";

		// Token: 0x04000183 RID: 387
		public const string by = "PRESERVE_NO";

		// Token: 0x04000184 RID: 388
		public const string bz = "PRESERVE_YES";

		// Token: 0x04000185 RID: 389
		public const string b0 = "FIELD";

		// Token: 0x04000186 RID: 390
		public const string b1 = "VALUE";

		// Token: 0x04000187 RID: 391
		public const string b2 = "BIT_LENGTH";

		// Token: 0x04000188 RID: 392
		public const string b3 = "8";

		// Token: 0x04000189 RID: 393
		public const string b4 = "16";

		// Token: 0x0400018A RID: 394
		public const string b5 = "32";

		// Token: 0x0400018B RID: 395
		public const string b6 = "NAME";

		// Token: 0x0400018C RID: 396
		public const string b7 = "GROUP";

		// Token: 0x0400018D RID: 397
		public const string b8 = "MIN";

		// Token: 0x0400018E RID: 398
		public const string b9 = "MAX";

		// Token: 0x0400018F RID: 399
		public const string ca = "eqn(sum)";

		// Token: 0x04000190 RID: 400
		public const string cb = "<GROUP>";

		// Token: 0x04000191 RID: 401
		public const string cc = "</GROUP>";

		// Token: 0x04000192 RID: 402
		public const string cd = ".srec";

		// Token: 0x04000193 RID: 403
		public const string ce = ".xml";

		// Token: 0x04000194 RID: 404
		public const string cf = "DeviceUpdate";

		// Token: 0x04000195 RID: 405
		public const int cg = 4;

		// Token: 0x04000196 RID: 406
		public const ushort ch = 4112;

		// Token: 0x04000197 RID: 407
		public const ushort ci = 0;

		// Token: 0x04000198 RID: 408
		public const byte cj = 1;

		// Token: 0x04000199 RID: 409
		public const byte ck = 2;

		// Token: 0x0400019A RID: 410
		public const byte cl = 1;

		// Token: 0x0400019B RID: 411
		public const byte cm = 2;

		// Token: 0x0400019C RID: 412
		public const int cn = 10;

		// Token: 0x0400019D RID: 413
		public const string co = ".fpga";

		// Token: 0x0400019E RID: 414
		public const string cp = "PSDT";

		// Token: 0x0400019F RID: 415
		public const string cq = "BOOTLOADER";

		// Token: 0x040001A0 RID: 416
		public const string cr = "LAST_IMPORTANT_BOOTLOADER";

		// Token: 0x040001A1 RID: 417
		public const string cs = "DUAL";

		// Token: 0x040001A2 RID: 418
		public const string ct = "FILE";

		// Token: 0x040001A3 RID: 419
		public const string cu = "FPGA_IMAGE";

		// Token: 0x040001A4 RID: 420
		public const string cv = ".pak";

		// Token: 0x040001A5 RID: 421
		public const string cw = ".mig";

		// Token: 0x040001A6 RID: 422
		public const string cx = ".gpak";

		// Token: 0x040001A7 RID: 423
		public const string cy = ".";

		// Token: 0x040001A8 RID: 424
		public const string cz = "070000";

		// Token: 0x040001A9 RID: 425
		public const string c0 = "MAX_PACKVERSION";

		// Token: 0x040001AA RID: 426
		public const int c1 = 6;

		// Token: 0x040001AB RID: 427
		public const int c2 = 1;

		// Token: 0x040001AC RID: 428
		public const string c3 = "TEMPLATEVERSION";

		// Token: 0x040001AD RID: 429
		public const double c4 = 11.0;

		// Token: 0x040001AE RID: 430
		public const double c5 = 8.0;

		// Token: 0x040001AF RID: 431
		public const double c6 = 8.0;

		// Token: 0x040001B0 RID: 432
		public const int c7 = 9;

		// Token: 0x040001B1 RID: 433
		public const int c8 = 20;

		// Token: 0x040001B2 RID: 434
		public const int c9 = 1000;

		// Token: 0x040001B3 RID: 435
		public const int da = 10;

		// Token: 0x040001B4 RID: 436
		public const int db = 10000;

		// Token: 0x040001B5 RID: 437
		public const int dc = 4;

		// Token: 0x040001B6 RID: 438
		public const int dd = 5;

		// Token: 0x040001B7 RID: 439
		public const int de = 10;

		// Token: 0x040001B8 RID: 440
		public const int df = 50;

		// Token: 0x040001B9 RID: 441
		public const string dg = "GPS_PACK";

		// Token: 0x040001BA RID: 442
		public const string dh = "All";

		// Token: 0x040001BB RID: 443
		public const string di = "BIT_FIELD";

		// Token: 0x040001BC RID: 444
		public const string dj = "BIT_NUMBER";

		// Token: 0x040001BD RID: 445
		public const string dk = "BIT_MIN";

		// Token: 0x040001BE RID: 446
		public const string dl = "BIT_MAX";

		// Token: 0x040001BF RID: 447
		public const string dm = "\\";

		// Token: 0x040001C0 RID: 448
		public const string dn = "//";

		// Token: 0x040001C1 RID: 449
		public const string @do = "TANAPA";

		// Token: 0x040001C2 RID: 450
		public const string dp = "AUTOCORRECT";

		// Token: 0x040001C3 RID: 451
		public const string dq = "COMPRESS";

		// Token: 0x040001C4 RID: 452
		public const string dr = "ENCODING";

		// Token: 0x040001C5 RID: 453
		public const string ds = "Base64";

		// Token: 0x040001C6 RID: 454
		public const string dt = "FIELDMOVE_FILE";

		// Token: 0x040001C7 RID: 455
		public const string du = "PATH";

		// Token: 0x040001C8 RID: 456
		public const string dv = "MOVE";

		// Token: 0x040001C9 RID: 457
		public const string dw = "SPLIT";

		// Token: 0x040001CA RID: 458
		public const string dx = "MERGE";

		// Token: 0x040001CB RID: 459
		public const string dy = "HASH_PASSWORD";

		// Token: 0x040001CC RID: 460
		public const string dz = "00";

		// Token: 0x040001CD RID: 461
		public const string d0 = "01";

		// Token: 0x040001CE RID: 462
		public const int d1 = 2;

		// Token: 0x040001CF RID: 463
		public const string d2 = "TARGET";

		// Token: 0x040001D0 RID: 464
		public const string d3 = "SOURCEFIELD";

		// Token: 0x040001D1 RID: 465
		public const string d4 = "SIZE";

		// Token: 0x040001D2 RID: 466
		public const string d5 = "SOURCE";

		// Token: 0x040001D3 RID: 467
		public const string d6 = "BITFIELD";

		// Token: 0x040001D4 RID: 468
		public const string d7 = "BITNUM";

		// Token: 0x040001D5 RID: 469
		public const string d8 = "BITLOC";

		// Token: 0x040001D6 RID: 470
		public const string d9 = "OPERATION";

		// Token: 0x040001D7 RID: 471
		public const string ea = "MULTI";

		// Token: 0x040001D8 RID: 472
		public const string eb = "TARGET_ISH_TYPE";

		// Token: 0x040001D9 RID: 473
		public const uint ec = 4112U;

		// Token: 0x040001DA RID: 474
		public const uint ed = 26896U;

		// Token: 0x040001DB RID: 475
		public const uint ee = 4112U;

		// Token: 0x040001DC RID: 476
		public const string ef = "\\Serial Number";

		// Token: 0x040001DD RID: 477
		public const string eg = "\\MAC Address";

		// Token: 0x040001DE RID: 478
		public const string eh = "\\Cypher Unit Serial Number";

		// Token: 0x040001DF RID: 479
		public const string ei = "Radio Security Information Composite Data Block";

		// Token: 0x040001E0 RID: 480
		public const string ej = "30";

		// Token: 0x040001E1 RID: 481
		public const string ek = "5A";

		// Token: 0x040001E2 RID: 482
		public const string el = "00";

		// Token: 0x040001E3 RID: 483
		public const string em = "FF";

		// Token: 0x040001E4 RID: 484
		public const string en = "Radio Security Information Composite Data Block";

		// Token: 0x040001E5 RID: 485
		public const string eo = "Serial Number Character";

		// Token: 0x040001E6 RID: 486
		public const string ep = "Cypher Unit Serial Number Character";

		// Token: 0x040001E7 RID: 487
		public const int eq = 10;

		// Token: 0x040001E8 RID: 488
		public const int er = 6;

		// Token: 0x040001E9 RID: 489
		public const int es = 0;

		// Token: 0x040001EA RID: 490
		public const int et = 9;

		// Token: 0x040001EB RID: 491
		public const int eu = 84;

		// Token: 0x040001EC RID: 492
		public const int ev = 93;

		// Token: 0x040001ED RID: 493
		public const int ew = 104;

		// Token: 0x040001EE RID: 494
		public const int ex = 109;

		// Token: 0x040001EF RID: 495
		public const string ey = "MAC Address";

		// Token: 0x040001F0 RID: 496
		public const string ez = "//*[@Path='%PATH']";

		// Token: 0x040001F1 RID: 497
		public const string e0 = "//Payload[@Path]";

		// Token: 0x040001F2 RID: 498
		public const string e1 = "%PATH";

		// Token: 0x040001F3 RID: 499
		public const string e2 = "APPLICABLE";

		// Token: 0x040001F4 RID: 500
		public const string e3 = "TRUE";

		// Token: 0x040001F5 RID: 501
		public const string e4 = "CONFIGURATION";

		// Token: 0x040001F6 RID: 502
		public const string e5 = "KERNEL";

		// Token: 0x040001F7 RID: 503
		public const string e6 = "ROOT_FILE_SYSTEM";

		// Token: 0x040001F8 RID: 504
		public const string e7 = "L3_BOOTLOADER";

		// Token: 0x040001F9 RID: 505
		public const string e8 = "L2_BOOTLOADER";

		// Token: 0x040001FA RID: 506
		public const string e9 = "PARTITION_TABLE";

		// Token: 0x040001FB RID: 507
		public const string fa = "MBR";

		// Token: 0x040001FC RID: 508
		public const string fb = "APP_UTILITIES";

		// Token: 0x040001FD RID: 509
		public const string fc = "CONTROL_HEAD";

		// Token: 0x040001FE RID: 510
		public const string fd = "GPS";

		// Token: 0x040001FF RID: 511
		public const string fe = "Plain";

		// Token: 0x04000200 RID: 512
		public const string ff = "GLOBAL_MARKER";

		// Token: 0x04000201 RID: 513
		public const string fg = "DATA_IMAGE";

		// Token: 0x04000202 RID: 514
		public const string fh = "FILE_CHANGE_LIST";

		// Token: 0x04000203 RID: 515
		public const string fi = "EXIST";

		// Token: 0x04000204 RID: 516
		public const string fj = "1";

		// Token: 0x04000205 RID: 517
		public const string fk = "FORMAT";

		// Token: 0x04000206 RID: 518
		public const string fl = "PREUPGRADE";

		// Token: 0x04000207 RID: 519
		public const string fm = "PSMARKER";

		// Token: 0x04000208 RID: 520
		public const string fn = "RM_BUILD";

		// Token: 0x04000209 RID: 521
		public const string fo = "//Partition[@Type='RawNAND']/Payload";

		// Token: 0x0400020A RID: 522
		public const string fp = "ID";

		// Token: 0x0400020B RID: 523
		public const string fq = "Start_ID";

		// Token: 0x0400020C RID: 524
		public const string fr = "End_ID";

		// Token: 0x0400020D RID: 525
		public const string fs = "OptionFlags";

		// Token: 0x0400020E RID: 526
		public const string ft = "//Partition[@Type='FTL']/Payload";

		// Token: 0x0400020F RID: 527
		public const string fu = "//Partition[@Type='FileSystem']/Payload";

		// Token: 0x04000210 RID: 528
		public const string fv = "Path";

		// Token: 0x04000211 RID: 529
		public const string fw = "Payload";

		// Token: 0x04000212 RID: 530
		public const string fx = "root";

		// Token: 0x04000213 RID: 531
		public const string fy = "Partition";

		// Token: 0x04000214 RID: 532
		public const string fz = "Type";

		// Token: 0x04000215 RID: 533
		public const string f0 = "FileSystem";

		// Token: 0x04000216 RID: 534
		public const string f1 = "FTL";

		// Token: 0x04000217 RID: 535
		public const string f2 = "MD5_CheckSUM";

		// Token: 0x04000218 RID: 536
		public const int f3 = 1;

		// Token: 0x04000219 RID: 537
		public const int f4 = 0;

		// Token: 0x0400021A RID: 538
		public const int f5 = 0;

		// Token: 0x0400021B RID: 539
		public const string f6 = "MODE";

		// Token: 0x0400021C RID: 540
		public const string f7 = "RECALC";

		// Token: 0x0400021D RID: 541
		public const string f8 = "MULTIPLY";

		// Token: 0x0400021E RID: 542
		public const string f9 = "ADD";

		// Token: 0x0400021F RID: 543
		public const string ga = "SUBTRACT";

		// Token: 0x04000220 RID: 544
		public const string gb = "DIVIDE";

		// Token: 0x04000221 RID: 545
		public const string gc = "EQUALS";

		// Token: 0x04000222 RID: 546
		public const string gd = "CONTAINS";

		// Token: 0x04000223 RID: 547
		public const string ge = "THRESHOLD";

		// Token: 0x04000224 RID: 548
		public const string gf = "UPGRADE";

		// Token: 0x04000225 RID: 549
		public const string gg = "DOWNGRADE";

		// Token: 0x04000226 RID: 550
		public const string gh = "UPGRADEONLY";

		// Token: 0x04000227 RID: 551
		public const string gi = "KCP1";

		// Token: 0x04000228 RID: 552
		public const string gj = "MCP1";

		// Token: 0x04000229 RID: 553
		public const string gk = "PCP";

		// Token: 0x0400022A RID: 554
		public const string gl = "\\Composite Data";

		// Token: 0x0400022B RID: 555
		public const string gm = "Tx Pa Characterization Parameter Mcp";

		// Token: 0x0400022C RID: 556
		public const string gn = "Controller";

		// Token: 0x0400022D RID: 557
		public const string go = "Wireline";

		// Token: 0x0400022E RID: 558
		public const string gp = "CB";

		// Token: 0x0400022F RID: 559
		public const string gq = "CB_LOW";

		// Token: 0x04000230 RID: 560
		public const string gr = "CB_HIGH_LIMIT";

		// Token: 0x04000231 RID: 561
		public const string gs = "CB_HIGH_SLOPE";

		// Token: 0x04000232 RID: 562
		public const string gt = "PC_ATTEN";

		// Token: 0x04000233 RID: 563
		public const string gu = "INCREMENT";

		// Token: 0x04000234 RID: 564
		public const string gv = "106A";

		// Token: 0x04000235 RID: 565
		public const uint gw = 4399U;

		// Token: 0x04000236 RID: 566
		public const uint gx = 6U;

		// Token: 0x04000237 RID: 567
		public const string gy = "Tx Pa Characterization Parameter Mcp";

		// Token: 0x04000238 RID: 568
		public const string gz = "Tx Pa Characterization Parameter Mcp1";

		// Token: 0x04000239 RID: 569
		public const string g0 = "\\Composite Data";

		// Token: 0x0400023A RID: 570
		public const string g1 = "NEW";

		// Token: 0x0400023B RID: 571
		public const string g2 = "LINEAR";

		// Token: 0x0400023C RID: 572
		public const string g3 = "CONSTANT_NUMBER";

		// Token: 0x0400023D RID: 573
		public const int g4 = 32768;

		// Token: 0x0400023E RID: 574
		public const int g5 = 32768;

		// Token: 0x0400023F RID: 575
		public const int g6 = 1;

		// Token: 0x04000240 RID: 576
		public const int g7 = 2;

		// Token: 0x04000241 RID: 577
		public const int g8 = 3;

		// Token: 0x04000242 RID: 578
		public const uint g9 = 16387U;

		// Token: 0x04000243 RID: 579
		public const int ha = 5;

		// Token: 0x04000244 RID: 580
		public const int hb = 23;

		// Token: 0x04000245 RID: 581
		public const int hc = 10;

		// Token: 0x04000246 RID: 582
		public const int hd = 20;

		// Token: 0x04000247 RID: 583
		public const int he = 30;

		// Token: 0x04000248 RID: 584
		public const string hf = "Item Structure Indicator";

		// Token: 0x04000249 RID: 585
		public const uint hg = 1U;

		// Token: 0x0400024A RID: 586
		public const uint hh = 2U;

		// Token: 0x0400024B RID: 587
		public const string hi = "01";

		// Token: 0x0400024C RID: 588
		public const int hj = 1;

		// Token: 0x0400024D RID: 589
		public const int hk = 3;

		// Token: 0x0400024E RID: 590
		public const int hl = 6;

		// Token: 0x0400024F RID: 591
		public const int hm = 1;

		// Token: 0x04000250 RID: 592
		public const int hn = 9;

		// Token: 0x04000251 RID: 593
		public const int ho = 0;

		// Token: 0x04000252 RID: 594
		public const int hp = 19;

		// Token: 0x04000253 RID: 595
		public const int hq = 7;

		// Token: 0x04000254 RID: 596
		public const int hr = 4;

		// Token: 0x04000255 RID: 597
		public const string hs = "\\List Entry Data";

		// Token: 0x04000256 RID: 598
		public const string ht = "List Entry Data ";

		// Token: 0x04000257 RID: 599
		public const string hu = "CPGA";

		// Token: 0x04000258 RID: 600
		public const string hv = "TUNA";

		// Token: 0x04000259 RID: 601
		public const string hw = "SECA";

		// Token: 0x0400025A RID: 602
		public const string hx = "UCLA";

		// Token: 0x0400025B RID: 603
		public const string hy = "PSDX";

		// Token: 0x0400025C RID: 604
		public const string hz = "CPGX";

		// Token: 0x0400025D RID: 605
		public const string h0 = "SECX";

		// Token: 0x0400025E RID: 606
		public const string h1 = "TUNX";

		// Token: 0x0400025F RID: 607
		public const string h2 = "UCLX";

		// Token: 0x04000260 RID: 608
		public const byte h3 = 1;

		// Token: 0x04000261 RID: 609
		public const byte h4 = 2;

		// Token: 0x04000262 RID: 610
		public const byte h5 = 10;

		// Token: 0x04000263 RID: 611
		public const byte h6 = 11;

		// Token: 0x04000264 RID: 612
		public const byte h7 = 16;

		// Token: 0x04000265 RID: 613
		public const byte h8 = 1;

		// Token: 0x04000266 RID: 614
		public const byte h9 = 0;

		// Token: 0x04000267 RID: 615
		public const string ia = "Motorola";

		// Token: 0x04000268 RID: 616
		public const string ib = "MODELS";

		// Token: 0x04000269 RID: 617
		public const string ic = "MODEL";

		// Token: 0x0400026A RID: 618
		public const string id = "MAPING";

		// Token: 0x0400026B RID: 619
		public const string ie = "SrcISHType";

		// Token: 0x0400026C RID: 620
		public const string @if = "SrcPath";

		// Token: 0x0400026D RID: 621
		public const string ig = "TgtISHType";

		// Token: 0x0400026E RID: 622
		public const string ih = "TgtPath";

		// Token: 0x0400026F RID: 623
		public const int ii = 51;

		// Token: 0x04000270 RID: 624
		public const string ij = "B:\\activexx\\codeplug\\tuning_cpg.db";

		// Token: 0x04000271 RID: 625
		public const string ik = "B:\\activexx\\codeplug\\sec_cpg.db";

		// Token: 0x04000272 RID: 626
		public const string il = "B:\\activexx\\codeplug\\app_cpg.db";

		// Token: 0x04000273 RID: 627
		public const string im = "B:\\activexx\\codeplug\\cfs_cpg.db";

		// Token: 0x04000274 RID: 628
		public const string @in = "C:\\upgrade\\codeplug\\";

		// Token: 0x04000275 RID: 629
		public const int io = 50;

		// Token: 0x04000276 RID: 630
		public const int ip = 51;

		// Token: 0x04000277 RID: 631
		public const uint iq = 5392U;

		// Token: 0x04000278 RID: 632
		public const string ir = "0100";

		// Token: 0x04000279 RID: 633
		public const string @is = "0000";

		// Token: 0x0400027A RID: 634
		public const string it = "0100";

		// Token: 0x0400027B RID: 635
		public const string iu = "0000";

		// Token: 0x0400027C RID: 636
		public const string iv = "/opt/pcr/rel/data/tuning/app_tuning/";

		// Token: 0x0400027D RID: 637
		public const string iw = "/opt/pcr/rel/data/codeplug/app_security/";

		// Token: 0x0400027E RID: 638
		public const string ix = "/opt/pcr/rel/data/codeplug/app_codeplug/";

		// Token: 0x0400027F RID: 639
		public const string iy = "/opt/pcr/rel/data/codeplug/app_features/";

		// Token: 0x04000280 RID: 640
		public const ushort iz = 1;

		// Token: 0x04000281 RID: 641
		public const ushort i0 = 4099;

		// Token: 0x04000282 RID: 642
		public const ushort i1 = 4100;

		// Token: 0x04000283 RID: 643
		public const ushort i2 = 4199;

		// Token: 0x04000284 RID: 644
		public const ushort i3 = 4200;

		// Token: 0x04000285 RID: 645
		public const ushort i4 = 4399;

		// Token: 0x04000286 RID: 646
		public const ushort i5 = 4400;

		// Token: 0x04000287 RID: 647
		public const ushort i6 = 4499;

		// Token: 0x04000288 RID: 648
		public const ushort i7 = 4700;

		// Token: 0x04000289 RID: 649
		public const ushort i8 = 4799;

		// Token: 0x0400028A RID: 650
		public const string i9 = ".cpg";

		// Token: 0x0400028B RID: 651
		public const string ja = "/root/";

		// Token: 0x0400028C RID: 652
		public const int jb = 18000;

		// Token: 0x0400028D RID: 653
		public const string jc = "08.00.02";

		// Token: 0x0400028E RID: 654
		public const string jd = "04.00.00";

		// Token: 0x0400028F RID: 655
		public const string je = "06.01.00";

		// Token: 0x04000290 RID: 656
		public const string jf = "pa_firmware";

		// Token: 0x02000023 RID: 35
		// (Invoke) Token: 0x06000102 RID: 258
		public delegate void a([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.I4)] int A_0);
	}
}
