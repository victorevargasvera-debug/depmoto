using System;

namespace Motorola.Common.Communication.TetraUtility
{
	// Token: 0x02000026 RID: 38
	public static class MCCConverter
	{
		// Token: 0x06000134 RID: 308 RVA: 0x00009C68 File Offset: 0x00007E68
		public static string ToString(uint mcc)
		{
			if (mcc <= 480U)
			{
				if (mcc <= 310U)
				{
					switch (mcc)
					{
					case 202U:
						return "GRC";
					case 203U:
					case 205U:
					case 207U:
					case 209U:
					case 210U:
					case 211U:
					case 215U:
					case 217U:
					case 221U:
					case 223U:
					case 224U:
					case 225U:
					case 227U:
					case 229U:
					case 233U:
					case 235U:
					case 236U:
					case 237U:
					case 239U:
					case 241U:
					case 243U:
					case 245U:
					case 249U:
					case 251U:
					case 252U:
					case 253U:
					case 254U:
					case 256U:
					case 258U:
					case 261U:
					case 263U:
					case 264U:
					case 265U:
					case 267U:
					case 269U:
					case 271U:
					case 273U:
					case 275U:
					case 277U:
					case 279U:
					case 281U:
					case 285U:
					case 287U:
					case 289U:
					case 291U:
					case 294U:
						break;
					case 204U:
						return "NLD";
					case 206U:
						return "BEL";
					case 208U:
						return "FRA";
					case 212U:
						return "MCO";
					case 213U:
						return "AND";
					case 214U:
						return "ESP";
					case 216U:
						return "HUN";
					case 218U:
						return "BIH";
					case 219U:
						return "HRV";
					case 220U:
						return "YUG";
					case 222U:
						return "ITA";
					case 226U:
						return "ROM";
					case 228U:
						return "CHE";
					case 230U:
						return "CZE";
					case 231U:
						return "SVK";
					case 232U:
						return "AUT";
					case 234U:
						return "GBR";
					case 238U:
						return "DNK";
					case 240U:
						return "SWE";
					case 242U:
						return "NOR";
					case 244U:
						return "FIN";
					case 246U:
						return "LTU";
					case 247U:
						return "LVA";
					case 248U:
						return "EST";
					case 250U:
						return "RUS";
					case 255U:
						return "UKR";
					case 257U:
						return "BLR";
					case 259U:
						return "MDA";
					case 260U:
						return "POL";
					case 262U:
						return "DEU";
					case 266U:
						return "GIB";
					case 268U:
						return "PRT";
					case 270U:
						return "LUX";
					case 272U:
						return "IRL";
					case 274U:
						return "ISL";
					case 276U:
						return "ALB";
					case 278U:
						return "MLT";
					case 280U:
						return "CYP";
					case 282U:
						return "GEO";
					case 283U:
						return "ARM";
					case 284U:
						return "BGR";
					case 286U:
						return "TUR";
					case 288U:
						return "FRO";
					case 290U:
						return "GRL";
					case 292U:
						return "SMR";
					case 293U:
						return "SVN";
					case 295U:
						return "LI\u0006";
					default:
						if (mcc == 302U)
						{
							return "CAN";
						}
						switch (mcc)
						{
						case 308U:
							return "SPM";
						case 310U:
							return "USA";
						}
						break;
					}
				}
				else
				{
					switch (mcc)
					{
					case 330U:
						return "PRI";
					case 331U:
					case 333U:
					case 335U:
					case 336U:
					case 337U:
					case 339U:
					case 341U:
					case 343U:
					case 345U:
					case 347U:
					case 349U:
					case 351U:
					case 353U:
					case 355U:
					case 357U:
					case 359U:
					case 361U:
					case 367U:
					case 369U:
					case 371U:
					case 373U:
					case 375U:
						break;
					case 332U:
						return "VIR";
					case 334U:
						return "MEX";
					case 338U:
						return "JAM";
					case 340U:
						return "GLP";
					case 342U:
						return "BRB";
					case 344U:
						return "ATG";
					case 346U:
						return "CYM";
					case 348U:
						return "VGB";
					case 350U:
						return "BMU";
					case 352U:
						return "GRD";
					case 354U:
						return "MSR";
					case 356U:
						return "KNA";
					case 358U:
						return "LCA";
					case 360U:
						return "VCT";
					case 362U:
						return "ANT";
					case 363U:
						return "ABW";
					case 364U:
						return "BHS";
					case 365U:
						return "AIA";
					case 366U:
						return "DMA";
					case 368U:
						return "CUB";
					case 370U:
						return "DOM";
					case 372U:
						return "HTI";
					case 374U:
						return "TTO";
					case 376U:
						return "TCA";
					default:
						switch (mcc)
						{
						case 400U:
							return "AZE";
						case 401U:
							return "KAZ";
						case 402U:
						case 403U:
						case 405U:
						case 406U:
						case 407U:
						case 408U:
						case 409U:
						case 411U:
						case 423U:
						case 430U:
						case 431U:
						case 433U:
						case 435U:
						case 439U:
						case 441U:
						case 442U:
						case 443U:
						case 444U:
						case 445U:
						case 446U:
						case 447U:
						case 448U:
						case 449U:
						case 451U:
						case 454U:
						case 458U:
						case 459U:
						case 461U:
						case 462U:
						case 463U:
						case 464U:
						case 465U:
						case 467U:
						case 468U:
						case 469U:
						case 471U:
							break;
						case 404U:
							return "IND";
						case 410U:
							return "PAK";
						case 412U:
							return "AFG";
						case 413U:
							return "LKA";
						case 414U:
							return "MMR";
						case 415U:
							return "LBN";
						case 416U:
							return "JOR";
						case 417U:
							return "SYR";
						case 418U:
							return "IRQ";
						case 419U:
							return "KWT";
						case 420U:
							return "SAU";
						case 421U:
							return "YEM";
						case 422U:
							return "OMN";
						case 424U:
							return "ARE";
						case 425U:
							return "ISR";
						case 426U:
							return "BHR";
						case 427U:
							return "QAT";
						case 428U:
							return "MNG";
						case 429U:
							return "NPL";
						case 432U:
							return "IRN";
						case 434U:
							return "UZB";
						case 436U:
							return "TJK";
						case 437U:
							return "KGZ";
						case 438U:
							return "TKM";
						case 440U:
							return "JPN";
						case 450U:
							return "PRK";
						case 452U:
							return "VNM";
						case 453U:
							return "HKG";
						case 455U:
							return "MAC";
						case 456U:
							return "KHM";
						case 457U:
							return "LAO";
						case 460U:
							return "CHN";
						case 466U:
							return "TWN";
						case 470U:
							return "BGD";
						case 472U:
							return "MDV";
						default:
							if (mcc == 480U)
							{
								return "KOR";
							}
							break;
						}
						break;
					}
				}
			}
			else if (mcc <= 716U)
			{
				if (mcc == 502U)
				{
					return "MYS";
				}
				switch (mcc)
				{
				case 505U:
					return "AUS";
				case 506U:
				case 507U:
				case 508U:
				case 509U:
				case 511U:
				case 512U:
				case 513U:
				case 514U:
				case 516U:
				case 517U:
				case 518U:
				case 519U:
				case 521U:
				case 522U:
				case 523U:
				case 524U:
				case 526U:
				case 527U:
				case 529U:
				case 531U:
				case 532U:
				case 533U:
				case 538U:
				case 551U:
				case 552U:
				case 553U:
				case 554U:
				case 555U:
				case 556U:
				case 557U:
				case 558U:
				case 559U:
				case 560U:
				case 561U:
				case 562U:
				case 563U:
				case 564U:
				case 565U:
				case 566U:
				case 567U:
				case 568U:
				case 569U:
				case 570U:
				case 571U:
				case 572U:
				case 573U:
				case 574U:
				case 575U:
				case 576U:
				case 577U:
				case 578U:
				case 579U:
				case 580U:
				case 581U:
				case 582U:
				case 583U:
				case 584U:
				case 585U:
				case 586U:
				case 587U:
				case 588U:
				case 589U:
				case 590U:
				case 591U:
				case 592U:
				case 593U:
				case 594U:
				case 595U:
				case 596U:
				case 597U:
				case 598U:
				case 599U:
				case 600U:
				case 601U:
				case 644U:
					break;
				case 510U:
					return "IDN";
				case 515U:
					return "PHL";
				case 520U:
					return "THA";
				case 525U:
					return "SGP";
				case 528U:
					return "BRN";
				case 530U:
					return "NZL";
				case 534U:
					return "MNP";
				case 535U:
					return "GUM";
				case 536U:
					return "NRU";
				case 537U:
					return "PNG";
				case 539U:
					return "TON";
				case 540U:
					return "SLB";
				case 541U:
					return "V\u0006T";
				case 542U:
					return "FJI";
				case 543U:
					return "WLF";
				case 544U:
					return "ASM";
				case 545U:
					return "KIR";
				case 546U:
					return "NCL";
				case 547U:
					return "PYF";
				case 548U:
					return "COK";
				case 549U:
					return "WSM";
				case 550U:
					return "FSM";
				case 602U:
					return "EGY";
				case 603U:
					return "DZA";
				case 604U:
					return "MAR";
				case 605U:
					return "TUN";
				case 606U:
					return "LBY";
				case 607U:
					return "GMB";
				case 608U:
					return "SEN";
				case 609U:
					return "MRT";
				case 610U:
					return "MLI";
				case 611U:
					return "GIN";
				case 612U:
					return "CIV";
				case 613U:
					return "BFA";
				case 614U:
					return "NER";
				case 615U:
					return "TGO";
				case 616U:
					return "BEN";
				case 617U:
					return "MUS";
				case 618U:
					return "LBR";
				case 619U:
					return "SLE";
				case 620U:
					return "GHA";
				case 621U:
					return "NGA";
				case 622U:
					return "TCD";
				case 623U:
					return "CAF";
				case 624U:
					return "CMR";
				case 625U:
					return "CPV";
				case 626U:
					return "STP";
				case 627U:
					return "GNQ";
				case 628U:
					return "GAB";
				case 629U:
					return "ZAR";
				case 630U:
					return "COG";
				case 631U:
					return "AGO";
				case 632U:
					return "GNB";
				case 633U:
					return "SYC";
				case 634U:
					return "SDN";
				case 635U:
					return "RWA";
				case 636U:
					return "ETH";
				case 637U:
					return "SOM";
				case 638U:
					return "DJI";
				case 639U:
					return "KEN";
				case 640U:
					return "TZA";
				case 641U:
					return "UGA";
				case 642U:
					return "BDI";
				case 643U:
					return "MOZ";
				case 645U:
					return "ZWB";
				case 646U:
					return "MDG";
				case 647U:
					return "REU";
				case 648U:
					return "ZWE";
				case 649U:
					return "NAM";
				case 650U:
					return "MWI";
				case 651U:
					return "LSO";
				case 652U:
					return "BWA";
				case 653U:
					return "SWZ";
				case 654U:
					return "COM";
				case 655U:
					return "ZAF";
				default:
					switch (mcc)
					{
					case 702U:
						return "BLZ";
					case 704U:
						return "GTM";
					case 706U:
						return "SLV";
					case 708U:
						return "HND";
					case 710U:
						return "NIC";
					case 712U:
						return "CRI";
					case 714U:
						return "PAN";
					case 716U:
						return "PER";
					}
					break;
				}
			}
			else if (mcc <= 740U)
			{
				switch (mcc)
				{
				case 722U:
					return "ARG";
				case 723U:
					break;
				case 724U:
					return "BRA";
				default:
					switch (mcc)
					{
					case 730U:
						return "CHL";
					case 732U:
						return "COL";
					case 734U:
						return "VEN";
					case 736U:
						return "BOL";
					case 738U:
						return "GUY";
					case 740U:
						return "ECU";
					}
					break;
				}
			}
			else
			{
				switch (mcc)
				{
				case 744U:
					return "PRY";
				case 745U:
				case 747U:
					break;
				case 746U:
					return "SUR";
				case 748U:
					return "URY";
				default:
					switch (mcc)
					{
					case 65000U:
						return "UNI";
					case 65001U:
						return "UCS";
					case 65002U:
						return "UN1";
					case 65003U:
						return "UN2";
					}
					break;
				}
			}
			return "ccc";
		}

		// Token: 0x06000135 RID: 309 RVA: 0x0000A8B3 File Offset: 0x00008AB3
		public static uint DecrypteHomeMcc(uint inHomeMcc)
		{
			if (!global::Motorola.Common.Communication.TetraUtility.MCCConverter.IsHomeMccEncrypted(inHomeMcc))
			{
				return inHomeMcc;
			}
			if (inHomeMcc == 412U)
			{
				return global::Motorola.Common.Communication.TetraUtility.MCCConverter.Milan2HomeMcc;
			}
			return 65535U - inHomeMcc;
		}

		// Token: 0x06000136 RID: 310 RVA: 0x0000A8D4 File Offset: 0x00008AD4
		public static bool IsHomeMccEncrypted(uint inHomeMcc)
		{
			return inHomeMcc != global::Motorola.Common.Communication.TetraUtility.MCCConverter.Milan2HomeMcc && inHomeMcc != uint.MaxValue && (inHomeMcc < 65000U || inHomeMcc > 65535U);
		}

		// Token: 0x0400008C RID: 140
		public static readonly uint Milan2HomeMcc = 753U;
	}
}
