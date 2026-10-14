using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Motorola.Common.Communication.CommonUtil;

namespace constants
{
	// Token: 0x02000003 RID: 3
	public class CCPTags
	{
		// Token: 0x06000004 RID: 4 RVA: 0x0000211C File Offset: 0x0000031C
		public static bool IsFeatureValid(string productId, string applicationName)
		{
			int num = 2;
			for (;;)
			{
				switch (num)
				{
				case 0:
					num = 17;
					continue;
				case 1:
					if (!(productId == "AS_RDAC_MULSYS"))
					{
						num = 11;
						continue;
					}
					return true;
				case 3:
					num = 22;
					continue;
				case 4:
					goto IL_147;
				case 5:
					num = 20;
					continue;
				case 6:
					num = 1;
					continue;
				case 7:
					num = 14;
					continue;
				case 8:
					num = 9;
					continue;
				case 9:
					goto IL_EA8;
				case 10:
					global::k.a = new global::System.Collections.Generic.Dictionary<string, int>(226)
					{
						{
							"NA_CAPACITY_PLUS_SUB",
							0
						},
						{
							"EM_CAPACITY_PLUS_SUB",
							1
						},
						{
							"LA_CAPACITY_PLUS_SUB",
							2
						},
						{
							"AS_CAPACITY_PLUS_SUB",
							3
						},
						{
							"NA_CAPACITY_PLUS_REP",
							4
						},
						{
							"LA_CAPACITY_PLUS_REP",
							5
						},
						{
							"EM_CAPACITY_PLUS_REP",
							6
						},
						{
							"AS_CAPACITY_PLUS_REP",
							7
						},
						{
							"LA_CAPACITY_PLUS_BANDIT",
							8
						},
						{
							"EM_CAPACITY_PLUS_BANDIT",
							9
						},
						{
							"AS_CAPACITY_PLUS_BANDIT",
							10
						},
						{
							"NA_IPSITE_CONNECT_SUB",
							11
						},
						{
							"LA_IPSITE_CONNECT_SUB",
							12
						},
						{
							"LA_IPSITE_CONNECT_REP",
							13
						},
						{
							"AS_IPSITE_CONNECT_REP",
							14
						},
						{
							"AS_IPSITE_CONNECT_SUB",
							15
						},
						{
							"LA_IPSITE_CONNECT_BANDIT",
							16
						},
						{
							"AS_IPSITE_CONNECT_BANDIT",
							17
						},
						{
							"NA_DIGITAL_AO_SUB",
							18
						},
						{
							"LA_DIGITAL_AO_SUB",
							19
						},
						{
							"EM_DIGITAL_AO_SUB",
							20
						},
						{
							"AS_DIGITAL_AO_REP",
							21
						},
						{
							"AS_DIGITAL_AO_SUB",
							22
						},
						{
							"NA_DIGITAL_AO_REP",
							23
						},
						{
							"NA_DIGITAL_AO_SUB_PL",
							24
						},
						{
							"LA_DIGITAL_AO_SUB_PL",
							25
						},
						{
							"EM_DIGITAL_AO_SUB_PL",
							26
						},
						{
							"AS_DIGITAL_AO_SUB_PL",
							27
						},
						{
							"NA_ENH_PRIVACY_SUB",
							28
						},
						{
							"LA_ENH_PRIVACY_SUB",
							29
						},
						{
							"EM_ENH_PRIVACY_SUB",
							30
						},
						{
							"AS_ENH_PRIVACY_SUB",
							31
						},
						{
							"NA_TXINTERRUPT_SUB",
							32
						},
						{
							"LA_TXINTERRUPT_SUB",
							33
						},
						{
							"EM_TXINTERRUPT_SUB",
							34
						},
						{
							"AS_TXINTERRUPT_SUB",
							35
						},
						{
							"BANDIT_CAPACITY_PLUS_REP",
							36
						},
						{
							"BANDIT_DMM_REP",
							37
						},
						{
							"NA_DMM_REP",
							38
						},
						{
							"AS_DMM_REP",
							39
						},
						{
							"AS_DMM_BANDIT",
							40
						},
						{
							"NA_DMM_BANDIT",
							41
						},
						{
							"NA_CONNECT_PLUS_SUB",
							42
						},
						{
							"LA_CONNECT_PLUS_SUB",
							43
						},
						{
							"EM_CONNECT_PLUS_SUB",
							44
						},
						{
							"AS_CONNECT_PLUS_SUB",
							45
						},
						{
							"NA_TRBOCPS_RRP",
							46
						},
						{
							"LA_TRBOCPS_RRP",
							47
						},
						{
							"AS_TRBOCPS_RRP",
							48
						},
						{
							"AS_MATRIXTOPHOENIX_SUB",
							49
						},
						{
							"EM_MATRIXTOPHOENIX_SUB",
							50
						},
						{
							"NA_ENHANCEDGPS_REP",
							51
						},
						{
							"NA_ENHANCEDGPS_BANDIT",
							52
						},
						{
							"LA_ENHANCEDGPS_REP",
							53
						},
						{
							"LA_ENHANCEDGPS_BANDIT",
							54
						},
						{
							"NA_TRBOCPS_NPSPAC",
							55
						},
						{
							"EM_TRBOCPS_NONSPAINFREQ",
							56
						},
						{
							"NA_PHONE_REP",
							57
						},
						{
							"NA_PHONE_BANDIT",
							58
						},
						{
							"LA_PHONE_REP",
							59
						},
						{
							"LA_PHONE_BANDIT",
							60
						},
						{
							"AS_PHONE_REP",
							61
						},
						{
							"AS_PHONE_BANDIT",
							62
						},
						{
							"EM_PHONE_REP",
							63
						},
						{
							"EM_PHONE_BANDIT",
							64
						},
						{
							"EM_PHONE_SUB",
							65
						},
						{
							"NA_CONNECT_PLUS_MANDOWN_SUB",
							66
						},
						{
							"LA_CONNECT_PLUS_MANDOWN_SUB",
							67
						},
						{
							"EM_CONNECT_PLUS_MANDOWN_SUB",
							68
						},
						{
							"AS_CONNECT_PLUS_MANDOWN_SUB",
							69
						},
						{
							"NA_TRBOCPS_25KHZ",
							70
						},
						{
							"LA_GPS_SUB",
							71
						},
						{
							"EM_5TONE_SUB",
							72
						},
						{
							"AS_5TONE_SUB",
							73
						},
						{
							"NA_LCP_REP",
							74
						},
						{
							"NA_LCP_BANDIT",
							75
						},
						{
							"LA_LCP_REP",
							76
						},
						{
							"LA_LCP_BANDIT",
							77
						},
						{
							"EM_LCP_REP",
							78
						},
						{
							"EM_LCP_BANDIT",
							79
						},
						{
							"AS_LCP_REP",
							80
						},
						{
							"AS_LCP_BANDIT",
							81
						},
						{
							"NA_LCP_FROM_IPSITE_REP",
							82
						},
						{
							"NA_LCP_FROM_IPSITE_BANDIT",
							83
						},
						{
							"LA_LCP_FROM_IPSITE_REP",
							84
						},
						{
							"LA_LCP_FROM_IPSITE_BANDIT",
							85
						},
						{
							"AS_LCP_FROM_IPSITE_REP",
							86
						},
						{
							"AS_LCP_FROM_IPSITE_BANDIT",
							87
						},
						{
							"NA_LCP_FROM_CAPPLUS_REP",
							88
						},
						{
							"NA_LCP_FROM_CAPPLUS_BANDIT",
							89
						},
						{
							"LA_LCP_FROM_CAPPLUS_REP",
							90
						},
						{
							"LA_LCP_FROM_CAPPLUS_BANDIT",
							91
						},
						{
							"EM_LCP_FROM_CAPPLUS_REP",
							92
						},
						{
							"EM_LCP_FROM_CAPPLUS_BANDIT",
							93
						},
						{
							"AS_LCP_FROM_CAPPLUS_REP",
							94
						},
						{
							"AS_LCP_FROM_CAPPLUS_BANDIT",
							95
						},
						{
							"LA_PHONE_SUB",
							96
						},
						{
							"NA_LCP_SUB",
							97
						},
						{
							"LA_LCP_SUB",
							98
						},
						{
							"EM_LCP_SUB",
							99
						},
						{
							"AS_LCP_SUB",
							100
						},
						{
							"NA_LCP_FROM_IPSITE_SUB",
							101
						},
						{
							"LA_LCP_FROM_IPSITE_SUB",
							102
						},
						{
							"AS_LCP_FROM_IPSITE_SUB",
							103
						},
						{
							"LA_LCP_FROM_CAPPLUS_SUB",
							104
						},
						{
							"EM_LCP_FROM_CAPPLUS_SUB",
							105
						},
						{
							"AS_LCP_FROM_CAPPLUS_SUB",
							106
						},
						{
							"NA_BT_DATASERVICE_SUB",
							107
						},
						{
							"EM_BT_DATASERVICE_SUB",
							108
						},
						{
							"LA_BT_DATASERVICE_SUB",
							109
						},
						{
							"AS_DIG_EMERGENCY_SUB",
							110
						},
						{
							"AS_REMOTE_MONITOR_SUB",
							111
						},
						{
							"AS_RADIO_INHIBIT_SUB",
							112
						},
						{
							"AS_PDT_REP",
							113
						},
						{
							"AS_PDT_BANDIT",
							114
						},
						{
							"AS_PDT_SUB",
							115
						},
						{
							"NA_TRBOCPS_RMSERVER_RM",
							116
						},
						{
							"LA_TRBOCPS_RMSERVER_RM",
							117
						},
						{
							"AS_TRBOCPS_RMSERVER_RM",
							118
						},
						{
							"EM_TRBOCPS_RMSERVER_RM",
							119
						},
						{
							"NA_RAS_REP",
							120
						},
						{
							"NA_RAS_BANDIT",
							121
						},
						{
							"LA_RAS_REP",
							122
						},
						{
							"LA_RAS_BANDIT",
							123
						},
						{
							"NA_WIRELINEVANDDL1_REP",
							124
						},
						{
							"NA_WIRELINEVANDDL1_BANDIT",
							125
						},
						{
							"LA_WIRELINEVANDDL1_REP",
							126
						},
						{
							"LA_WIRELINEVANDDL1_BANDIT",
							127
						},
						{
							"EM_WIRELINEVANDDL1_REP",
							128
						},
						{
							"EM_WIRELINEVANDDL1_BANDIT",
							129
						},
						{
							"AS_WIRELINEVANDDL1_REP",
							130
						},
						{
							"AS_WIRELINEVANDDL1_BANDIT",
							131
						},
						{
							"NA_WIRELINEVANDDL2_REP",
							132
						},
						{
							"NA_WIRELINEVANDDL2_BANDIT",
							133
						},
						{
							"LA_WIRELINEVANDDL2_REP",
							134
						},
						{
							"LA_WIRELINEVANDDL2_BANDIT",
							135
						},
						{
							"EM_WIRELINEVANDDL2_REP",
							136
						},
						{
							"EM_WIRELINEVANDDL2_BANDIT",
							137
						},
						{
							"AS_WIRELINEVANDDL2_REP",
							138
						},
						{
							"AS_WIRELINEVANDDL2_BANDIT",
							139
						},
						{
							"NA_ATEXCSAMANDOWN_SUB",
							140
						},
						{
							"LA_ATEXCSAMANDOWN_SUB",
							141
						},
						{
							"EM_ATEXCSAMANDOWN_SUB",
							142
						},
						{
							"AS_ATEXCSAMANDOWN_SUB",
							143
						},
						{
							"NA_DIGITALVOTING_REP",
							144
						},
						{
							"NA_DIGITALVOTING_BANDIT",
							145
						},
						{
							"LA_DIGITALVOTING_REP",
							146
						},
						{
							"LA_DIGITALVOTING_BANDIT",
							147
						},
						{
							"EM_DIGITALVOTING_REP",
							148
						},
						{
							"EM_DIGITALVOTING_BANDIT",
							149
						},
						{
							"AS_DIGITALVOTING_REP",
							150
						},
						{
							"AS_DIGITALVOTING_BANDIT",
							151
						},
						{
							"NA_AESPRIVACY_SUB",
							152
						},
						{
							"LA_AESPRIVACY_SUB",
							153
						},
						{
							"EM_AESPRIVACY_SUB",
							154
						},
						{
							"AS_AESPRIVACY_SUB",
							155
						},
						{
							"NA_BTPERMDISCOVERABLEMODE_SUB",
							156
						},
						{
							"LA_BTPERMDISCOVERABLEMODE_SUB",
							157
						},
						{
							"EM_BTPERMDISCOVERABLEMODE_SUB",
							158
						},
						{
							"AS_BTPERMDISCOVERABLEMODE_SUB",
							159
						},
						{
							"AS_KEEPALIVE_SUB",
							160
						},
						{
							"AS_EOB_SUB",
							161
						},
						{
							"AS_PHONE_SUB",
							162
						},
						{
							"NA_PHONE_SUB",
							163
						},
						{
							"EM_CBFREQUENCY_SUB",
							164
						},
						{
							"EM_IPSITE_CONNECT_SUB",
							165
						},
						{
							"AS_EOT_SUB",
							166
						},
						{
							"AS_TTS_SUB",
							167
						},
						{
							"EM_TTS_SUB",
							168
						},
						{
							"LA_TTS_SUB",
							169
						},
						{
							"NA_TTS_SUB",
							170
						},
						{
							"AS_MULTIBUTTONPTT_SUB",
							171
						},
						{
							"EM_MULTIBUTTONPTT_SUB",
							172
						},
						{
							"LA_MULTIBUTTONPTT_SUB",
							173
						},
						{
							"NA_MULTIBUTTONPTT_SUB",
							174
						},
						{
							"GLOBAL_LCPEXTENDED_SUB",
							175
						},
						{
							"GLOBAL_LCPEXTENDED_REP",
							176
						},
						{
							"GLOBAL_LCPEXTENDED_BANDIT",
							177
						},
						{
							"GLOBAL_GPSPRIOVERVOICE_SUB",
							178
						},
						{
							"GLOBAL_OTAR_SUB",
							179
						},
						{
							"AS_EXTNOISESUPPRESSOR_SUB",
							180
						},
						{
							"EM_EXTNOISESUPPRESSOR_SUB",
							181
						},
						{
							"LA_EXTNOISESUPPRESSOR_SUB",
							182
						},
						{
							"NA_EXTNOISESUPPRESSOR_SUB",
							183
						},
						{
							"AS_TMSMAXSEND280_SUB",
							184
						},
						{
							"EM_TMSMAXSEND280_SUB",
							185
						},
						{
							"LA_TMSMAXSEND280_SUB",
							186
						},
						{
							"NA_TMSMAXSEND280_SUB",
							187
						},
						{
							"AS_WIFI_SUB",
							188
						},
						{
							"EM_WIFI_SUB",
							189
						},
						{
							"LA_WIFI_SUB",
							190
						},
						{
							"NA_WIFI_SUB",
							191
						},
						{
							"AS_AUTHRADIODISABLE_SUB",
							192
						},
						{
							"EM_AUTHRADIODISABLE_SUB",
							193
						},
						{
							"LA_AUTHRADIODISABLE_SUB",
							194
						},
						{
							"AS_TRANSMITINHIBIT_SUB",
							195
						},
						{
							"EM_TRANSMITINHIBIT_SUB",
							196
						},
						{
							"LA_TRANSMITINHIBIT_SUB",
							197
						},
						{
							"NA_TRANSMITINHIBIT_SUB",
							198
						},
						{
							"NA_DIGITALAUDIO_ALLREP",
							199
						},
						{
							"LA_DIGITALAUDIO_ALLREP",
							200
						},
						{
							"EM_DIGITALAUDIO_ALLREP",
							201
						},
						{
							"AS_DIGITALAUDIO_ALLREP",
							202
						},
						{
							"AS_INDOORLOC_SUB",
							203
						},
						{
							"EM_INDOORLOC_SUB",
							204
						},
						{
							"LA_INDOORLOC_SUB",
							205
						},
						{
							"NA_INDOORLOC_SUB",
							206
						},
						{
							"AS_THIRDPTYDMRLNKCTL_ALLREP",
							207
						},
						{
							"AS_THIRDPTYDMRLNKCTL_SUB",
							208
						},
						{
							"NA_SFR_ALLREP",
							209
						},
						{
							"LA_SFR_ALLREP",
							210
						},
						{
							"EM_SFR_ALLREP",
							211
						},
						{
							"AS_SFR_ALLREP",
							212
						},
						{
							"NA_MUTEMODE_SUB",
							213
						},
						{
							"LA_MUTEMODE_SUB",
							214
						},
						{
							"EM_MUTEMODE_SUB",
							215
						},
						{
							"AS_MUTEMODE_SUB",
							216
						},
						{
							"NA_RXAUDIOLEVELING_SUB",
							217
						},
						{
							"LA_RXAUDIOLEVELING_SUB",
							218
						},
						{
							"EM_RXAUDIOLEVELING_SUB",
							219
						},
						{
							"AS_RXAUDIOLEVELING_SUB",
							220
						},
						{
							"AS_RESPONSEINHIBIT_SUB",
							221
						},
						{
							"LA_RESPONSEINHIBIT_SUB",
							222
						},
						{
							"EM_RESPONSEINHIBIT_SUB",
							223
						},
						{
							"NA_RESPONSEINHIBIT_SUB",
							224
						},
						{
							"GLOBAL_ATPTT_SUB",
							225
						}
					};
					num = 13;
					continue;
				case 11:
					num = 21;
					continue;
				case 12:
					num = 18;
					continue;
				case 13:
					goto IL_E3;
				case 14:
					goto IL_1286;
				case 15:
					num = 16;
					continue;
				case 16:
					if (productId == "EM_RDAC_MULSYS")
					{
						num = 4;
						continue;
					}
					return false;
				case 17:
					if (productId != null)
					{
						num = 12;
						continue;
					}
					return false;
				case 18:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1286;
					default:
						if (false)
						{
						}
						if (global::k.a == null)
						{
							num = 10;
							continue;
						}
						goto IL_E3;
					}
					break;
				case 19:
				{
					int num2;
					if (global::k.a.TryGetValue(productId, out num2))
					{
						if (true)
						{
						}
						num = 3;
						continue;
					}
					return false;
				}
				case 20:
					if (!(productId == "NA_RDAC_MULSYS"))
					{
						num = 6;
						continue;
					}
					return true;
				case 21:
					if (!(productId == "LA_RDAC_MULSYS"))
					{
						num = 15;
						continue;
					}
					return true;
				case 22:
				{
					int num2;
					switch (num2)
					{
					case 0:
					case 1:
					case 2:
					case 3:
					case 4:
					case 5:
					case 6:
					case 7:
					case 8:
					case 9:
					case 10:
					case 11:
					case 12:
					case 13:
					case 14:
					case 15:
					case 16:
					case 17:
					case 18:
					case 19:
					case 20:
					case 21:
					case 22:
					case 23:
					case 24:
					case 25:
					case 26:
					case 27:
					case 28:
					case 29:
					case 30:
					case 31:
					case 32:
					case 33:
					case 34:
					case 35:
					case 36:
					case 37:
					case 38:
					case 39:
					case 40:
					case 41:
					case 42:
					case 43:
					case 44:
					case 45:
					case 46:
					case 47:
					case 48:
					case 49:
					case 50:
					case 51:
					case 52:
					case 53:
					case 54:
					case 55:
					case 56:
					case 57:
					case 58:
					case 59:
					case 60:
					case 61:
					case 62:
					case 63:
					case 64:
					case 65:
					case 66:
					case 67:
					case 68:
					case 69:
					case 70:
					case 71:
					case 72:
					case 73:
					case 74:
					case 75:
					case 76:
					case 77:
					case 78:
					case 79:
					case 80:
					case 81:
					case 82:
					case 83:
					case 84:
					case 85:
					case 86:
					case 87:
					case 88:
					case 89:
					case 90:
					case 91:
					case 92:
					case 93:
					case 94:
					case 95:
					case 96:
					case 97:
					case 98:
					case 99:
					case 100:
					case 101:
					case 102:
					case 103:
					case 104:
					case 105:
					case 106:
					case 107:
					case 108:
					case 109:
					case 110:
					case 111:
					case 112:
					case 113:
					case 114:
					case 115:
					case 116:
					case 117:
					case 118:
					case 119:
					case 120:
					case 121:
					case 122:
					case 123:
					case 124:
					case 125:
					case 126:
					case 127:
					case 128:
					case 129:
					case 130:
					case 131:
					case 132:
					case 133:
					case 134:
					case 135:
					case 136:
					case 137:
					case 138:
					case 139:
					case 140:
					case 141:
					case 142:
					case 143:
					case 144:
					case 145:
					case 146:
					case 147:
					case 148:
					case 149:
					case 150:
					case 151:
					case 152:
					case 153:
					case 154:
					case 155:
					case 156:
					case 157:
					case 158:
					case 159:
					case 160:
					case 161:
					case 162:
					case 163:
					case 164:
					case 165:
					case 166:
					case 167:
					case 168:
					case 169:
					case 170:
					case 171:
					case 172:
					case 173:
					case 174:
					case 175:
					case 176:
					case 177:
					case 178:
					case 179:
					case 180:
					case 181:
					case 182:
					case 183:
					case 184:
					case 185:
					case 186:
					case 187:
					case 188:
					case 189:
					case 190:
					case 191:
					case 192:
					case 193:
					case 194:
					case 195:
					case 196:
					case 197:
					case 198:
					case 199:
					case 200:
					case 201:
					case 202:
					case 203:
					case 204:
					case 205:
					case 206:
					case 207:
					case 208:
					case 209:
					case 210:
					case 211:
					case 212:
					case 213:
					case 214:
					case 215:
					case 216:
					case 217:
					case 218:
					case 219:
					case 220:
					case 221:
					case 222:
					case 223:
					case 224:
					case 225:
						return true;
					default:
						num = 8;
						continue;
					}
					break;
				}
				case 23:
					if (applicationName.Equals("RDAC"))
					{
						num = 7;
						continue;
					}
					return false;
				}
				if (applicationName.Equals("CPS"))
				{
					num = 0;
					continue;
				}
				num = 23;
				continue;
				IL_E3:
				num = 19;
				continue;
				IL_1286:
				if (productId == null)
				{
					return false;
				}
				num = 5;
			}
			IL_147:
			return true;
			IL_EA8:
			return false;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000033C8 File Offset: 0x000015C8
		public static void LoadHashtable()
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
			global::constants.CCPTags.m_hsTagIDs.Add("0", "ID0");
			global::constants.CCPTags.m_hsTagIDs.Add("1", "ID1");
			global::constants.CCPTags.m_hsTagIDs.Add("2", "ID2");
			global::constants.CCPTags.m_hsTagIDs.Add("3", "ID3");
			global::constants.CCPTags.m_hsTagIDs.Add("4", "ID4");
			global::constants.CCPTags.m_hsTagIDs.Add("5", "ID5");
			global::constants.CCPTags.m_hsTagIDs.Add("6", "ID6");
			global::constants.CCPTags.m_hsTagIDs.Add("7", "ID7");
			global::constants.CCPTags.m_hsTagIDs.Add("8", "ID8");
			global::constants.CCPTags.m_hsTagIDs.Add("9", "ID9");
			global::constants.CCPTags.m_hsTagIDs.Add("*", "STAR");
			global::constants.CCPTags.m_hsTagIDs.Add("#", "POUND");
			global::constants.CCPTags.m_hsTagIDs.Add("STR_12PT5KHZ", "0.012500");
			global::constants.CCPTags.m_hsTagIDs.Add("STR_20KHZ", "0.020000");
			global::constants.CCPTags.m_hsTagIDs.Add("STR_25KHZ", "0.025000");
			global::constants.CCPTags.m_hsTagIDs.Add("STR_30KHZ", "0.030000");
			global::constants.CCPTags.m_hsTagIDs.Add(" ", "STR_SPACE");
			global::constants.CCPTags.m_hsTagIDs.Add("'", "STR_QUOTE");
			global::constants.CCPTags.m_hsTagIDs.Add("\"", "STR_DOUBLEQUOTE");
			global::constants.CCPTags.m_hsTagIDs.Add("?", "STR_QUESTIONMARK");
			global::constants.CCPTags.m_hsTagIDs.Add(":", "STR_COLON");
			global::constants.CCPTags.m_hsTagIDs.Add("-", "STR_MINUSSIGN");
			global::constants.CCPTags.m_hsTagIDs.Add(",", "STR_COMMA2");
			global::constants.CCPTags.m_hsTagIDs.Add(".", "STR_PERIOD");
			global::constants.CCPTags.m_hsTagIDs.Add("/", "STR_FORWARDSLASH");
			global::constants.CCPTags.m_hsTagIDs.Add("(", "STR_OPENPARENTTHESIS");
			global::constants.CCPTags.m_hsTagIDs.Add(")", "STR_CLOSEPARENTTHESIS");
			global::constants.CCPTags.m_hsTagIDs.Add("!", "STR_EXCLAMATIONMARK");
			global::constants.CCPTags.m_hsTagIDs.Add("@", "STR_ATSYMBOL");
			global::constants.CCPTags.m_hsTagIDs.Add(string.Empty, "ENDOFSTR");
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00003670 File Offset: 0x00001870
		// Note: this type is marked as 'beforefieldinit'.
		static CCPTags()
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
			global::constants.CCPTags.ReadOperation = false;
			global::constants.CCPTags.AutoCorrect = false;
			global::constants.CCPTags.m_hsTagIDs = new global::System.Collections.Hashtable();
			global::constants.CCPTags.PASSWORD_POLICY_DICTIONARY = new global::System.Collections.Generic.Dictionary<global::Motorola.Common.Communication.CommonUtil.PasswordPolicy, global::System.Collections.Generic.HashSet<global::constants.Operationtype>>
			{
				{
					global::Motorola.Common.Communication.CommonUtil.PasswordPolicy.None,
					new global::System.Collections.Generic.HashSet<global::constants.Operationtype>()
				},
				{
					global::Motorola.Common.Communication.CommonUtil.PasswordPolicy.NA,
					new global::System.Collections.Generic.HashSet<global::constants.Operationtype>
					{
						global::constants.Operationtype.ReadDevice
					}
				},
				{
					global::Motorola.Common.Communication.CommonUtil.PasswordPolicy.Basic,
					new global::System.Collections.Generic.HashSet<global::constants.Operationtype>
					{
						global::constants.Operationtype.ReadDevice
					}
				},
				{
					global::Motorola.Common.Communication.CommonUtil.PasswordPolicy.Enhanced,
					new global::System.Collections.Generic.HashSet<global::constants.Operationtype>
					{
						global::constants.Operationtype.ReadDevice,
						global::constants.Operationtype.WriteDevice,
						global::constants.Operationtype.CloneDevice,
						global::constants.Operationtype.RecoverDevice,
						global::constants.Operationtype.ConvertDevice
					}
				}
			};
			global::constants.CCPTags.LIMITED_MODELS = new global::System.Collections.Generic.List<string>
			{
				"M28QPN9KD2AN",
				"M28QPN9RD2AN",
				"H56RDN9KD1AN",
				"H56RDN9RD1AN"
			};
		}

		// Token: 0x04000003 RID: 3
		public const string RADIO_SECURITY_INFO_CMP_TYPE = "RADIO_SECURITY_INFO_CMP_TYPE";

		// Token: 0x04000004 RID: 4
		public const string RS_SERIALNUM = "RS_SERIALNUM";

		// Token: 0x04000005 RID: 5
		public const string RS_DEVICESERIALNUM = "RS_DEVICESERIALNUM";

		// Token: 0x04000006 RID: 6
		public const string RS_MODELNUM = "RS_MODELNUM";

		// Token: 0x04000007 RID: 7
		public const string RS_MAJSECVERS = "RS_MAJSECVERS";

		// Token: 0x04000008 RID: 8
		public const string RS_MIDSECVERS = "RS_MIDSECVERS";

		// Token: 0x04000009 RID: 9
		public const string RS_MINSECVERS = "RS_MINSECVERS";

		// Token: 0x0400000A RID: 10
		public const string RS_SECVERS = "RS_SECVERS";

		// Token: 0x0400000B RID: 11
		public const string RAI_APVN = "RAI_APVN";

		// Token: 0x0400000C RID: 12
		public const string RS_ORGPROGYEAR = "RS_ORGPROGYEAR";

		// Token: 0x0400000D RID: 13
		public const string RS_ORGPROGMONTH = "RS_ORGPROGMONTH";

		// Token: 0x0400000E RID: 14
		public const string RS_ORGPROGDAY = "RS_ORGPROGDAY";

		// Token: 0x0400000F RID: 15
		public const string RS_ORGPROGHOUR = "RS_ORGPROGHOUR";

		// Token: 0x04000010 RID: 16
		public const string RS_ORGPROGMINUTES = "RS_ORGPROGMINUTES";

		// Token: 0x04000011 RID: 17
		public const string RS_ORGPROGSOURCE = "RS_ORGPROGSOURCE";

		// Token: 0x04000012 RID: 18
		public const string RS_ORGMAJSECVERS = "RS_ORGMAJSECVERS";

		// Token: 0x04000013 RID: 19
		public const string RS_ORGMINSECVERS = "RS_ORGMINSECVERS";

		// Token: 0x04000014 RID: 20
		public const string RS_ORGMAJAPPVERS = "RS_ORGMAJAPPVERS";

		// Token: 0x04000015 RID: 21
		public const string RS_ORGMINAPPVERS = "RS_ORGMINAPPVERS";

		// Token: 0x04000016 RID: 22
		public const string RS_BANDSEL = "RS_BANDSEL";

		// Token: 0x04000017 RID: 23
		public const string RS_BANDMINFREQ = "RS_BANDMINFREQ";

		// Token: 0x04000018 RID: 24
		public const string RS_BANDFREQRGN1 = "RS_BANDFREQRGN1";

		// Token: 0x04000019 RID: 25
		public const string RS_BANDFREQRGN2 = "RS_BANDFREQRGN2";

		// Token: 0x0400001A RID: 26
		public const string RS_BANDMAXFREQ = "RS_BANDMAXFREQ";

		// Token: 0x0400001B RID: 27
		public const string RS_CPPARTNUM = "RS_CPPARTNUM";

		// Token: 0x0400001C RID: 28
		public const string RS_TANAPANUM = "RS_TANAPANUM";

		// Token: 0x0400001D RID: 29
		public const string RS_MINTXPWR = "RS_MINTXPWR";

		// Token: 0x0400001E RID: 30
		public const string RS_MAXTXPWR = "RS_MAXTXPWR";

		// Token: 0x0400001F RID: 31
		public const string RS_MINTXPWR2 = "RS_MINTXPWR2";

		// Token: 0x04000020 RID: 32
		public const string RS_MAXTXPWR2 = "RS_MAXTXPWR2";

		// Token: 0x04000021 RID: 33
		public const string RS_MINIMUMTXPOWER3 = "RS_MINIMUMTXPOWER3";

		// Token: 0x04000022 RID: 34
		public const string RS_MAXIMUMTXPOWER3 = "RS_MAXIMUMTXPOWER3";

		// Token: 0x04000023 RID: 35
		public const string RS_RGNID = "RS_RGNID";

		// Token: 0x04000024 RID: 36
		public const string RS_BANDFREQRGN = "RS_BANDFREQRGN";

		// Token: 0x04000025 RID: 37
		public const string RS_TXPWRRGN = "RS_TXPWRRGN";

		// Token: 0x04000026 RID: 38
		public const string RS_MULTITXPWRRGN = "RS_MULTITXPWRRGN";

		// Token: 0x04000027 RID: 39
		public const string RS_MULTITXFREQRGN = "RS_MULTITXFREQRGN";

		// Token: 0x04000028 RID: 40
		public const string RS_MULTIRXFREQRGN = "RS_MULTIRXFREQRGN";

		// Token: 0x04000029 RID: 41
		public const string RS_SINGLERXFREQRGN = "RS_SINGLERXFREQRGN";

		// Token: 0x0400002A RID: 42
		public const string RS_SINGLETXFREQRGN = "RS_SINGLETXFREQRGN";

		// Token: 0x0400002B RID: 43
		public const string RS_MFID = "RS_MFID";

		// Token: 0x0400002C RID: 44
		public const string RS_RPTBRDTYPE = "RS_RPTBRDTYPE";

		// Token: 0x0400002D RID: 45
		public const string RS_PRODUCTID = "RS_PRODUCTID";

		// Token: 0x0400002E RID: 46
		public const string RS_CONNECTIONTYPE = "RS_CONNECTIONTYPE";

		// Token: 0x0400002F RID: 47
		public const string RS_TCBF15 = "RS_TCBF15";

		// Token: 0x04000030 RID: 48
		public const string RS_TCBF14 = "RS_TCBF14";

		// Token: 0x04000031 RID: 49
		public const string RS_TCBF13 = "RS_TCBF13";

		// Token: 0x04000032 RID: 50
		public const string RS_TCBF12 = "RS_TCBF12";

		// Token: 0x04000033 RID: 51
		public const string RS_TCBF11 = "RS_TCBF11";

		// Token: 0x04000034 RID: 52
		public const string RS_TCBF10 = "RS_TCBF10";

		// Token: 0x04000035 RID: 53
		public const string RS_TCBF9 = "RS_TCBF9";

		// Token: 0x04000036 RID: 54
		public const string RS_TCBF8 = "RS_TCBF8";

		// Token: 0x04000037 RID: 55
		public const string RS_TCBF7 = "RS_TCBF7";

		// Token: 0x04000038 RID: 56
		public const string RS_TCBF6 = "RS_TCBF6";

		// Token: 0x04000039 RID: 57
		public const string RS_TCBF5 = "RS_TCBF5";

		// Token: 0x0400003A RID: 58
		public const string RS_TCBF4 = "RS_TCBF4";

		// Token: 0x0400003B RID: 59
		public const string RS_TCBF3 = "RS_TCBF3";

		// Token: 0x0400003C RID: 60
		public const string RS_TCBF2 = "RS_TCBF2";

		// Token: 0x0400003D RID: 61
		public const string RS_TCBF1 = "RS_TCBF1";

		// Token: 0x0400003E RID: 62
		public const string RS_TCBF0 = "RS_TCBF0";

		// Token: 0x0400003F RID: 63
		public const string RS_CYPHERSERIALNUM = "RS_CYPHERSERIALNUM";

		// Token: 0x04000040 RID: 64
		public const string RS_ORGPROGDATE = "RS_ORGPROGDATE";

		// Token: 0x04000041 RID: 65
		public const string RS_BANDMINFREQ2 = "RS_BANDMINFREQ2";

		// Token: 0x04000042 RID: 66
		public const string RS_BANDMAXFREQ2 = "RS_BANDMAXFREQ2";

		// Token: 0x04000043 RID: 67
		public const string RS_BANDMINFREQ3 = "RS_BANDMINFREQ3";

		// Token: 0x04000044 RID: 68
		public const string RS_BANDMAXFREQ3 = "RS_BANDMAXFREQ3";

		// Token: 0x04000045 RID: 69
		public const string RS_BANDMINFREQ4 = "RS_BANDMINFREQ4";

		// Token: 0x04000046 RID: 70
		public const string RS_BANDMAXFREQ4 = "RS_BANDMAXFREQ4";

		// Token: 0x04000047 RID: 71
		public const string RS_RXFREQRGN = "RS_RXFREQRGN";

		// Token: 0x04000048 RID: 72
		public const string RS_TXFREQRGN = "RS_TXFREQRGN";

		// Token: 0x04000049 RID: 73
		public const string CFS_FLASHID = "CFS_FLASHID";

		// Token: 0x0400004A RID: 74
		public const string CFS_PROCID = "CFS_PROCID";

		// Token: 0x0400004B RID: 75
		public const string FD_FLASHID = "FD_FLASHID";

		// Token: 0x0400004C RID: 76
		public const string RS_PROCID = "RS_PROCID";

		// Token: 0x0400004D RID: 77
		public const string FEAT_DESCR_CMP_TYPE = "FEAT_DESCR_CMP_TYPE";

		// Token: 0x0400004E RID: 78
		public const string FD_MAXZNCHQTY = "FD_MAXZNCHQTY";

		// Token: 0x0400004F RID: 79
		public const string FD_CONVCAPBL = "FD_CONVCAPBL";

		// Token: 0x04000050 RID: 80
		public const string FD_LTRCAPBL = "FD_LTRCAPBL";

		// Token: 0x04000051 RID: 81
		public const string FD_MDCCONV = "FD_MDCCONV";

		// Token: 0x04000052 RID: 82
		public const string FD_MDCLTR = "FD_MDCLTR";

		// Token: 0x04000053 RID: 83
		public const string FD_DTMFCAPBL = "FD_DTMFCAPBL";

		// Token: 0x04000054 RID: 84
		public const string FD_MDCSTATUS = "FD_MDCSTATUS";

		// Token: 0x04000055 RID: 85
		public const string FD_MDCMSG = "FD_MDCMSG";

		// Token: 0x04000056 RID: 86
		public const string FD_MDCRTT = "FD_MDCRTT";

		// Token: 0x04000057 RID: 87
		public const string FD_DISPTYPE = "FD_DISPTYPE";

		// Token: 0x04000058 RID: 88
		public const string FD_LANGSET = "FD_LANGSET";

		// Token: 0x04000059 RID: 89
		public const string FD_CHARSIZE = "FD_CHARSIZE";

		// Token: 0x0400005A RID: 90
		public const string FD_SCANPRIOTYPE = "FD_SCANPRIOTYPE";

		// Token: 0x0400005B RID: 91
		public const string FD_CAOPERTYPE = "FD_CAOPERTYPE";

		// Token: 0x0400005C RID: 92
		public const string FD_CAWVOICEOPERTYPE = "FD_CAWVOICEOPERTYPE";

		// Token: 0x0400005D RID: 93
		public const string FD_SCOPERTYPE = "FD_SCOPERTYPE";

		// Token: 0x0400005E RID: 94
		public const string FD_SELINHOPERTYPE = "FD_SELINHOPERTYPE";

		// Token: 0x0400005F RID: 95
		public const string FD_EMEROPERTYPE = "FD_EMEROPERTYPE";

		// Token: 0x04000060 RID: 96
		public const string FD_PTTIDOPERTYPE = "FD_PTTIDOPERTYPE";

		// Token: 0x04000061 RID: 97
		public const string FD_REMMONOPERTYPE = "FD_REMMONOPERTYPE";

		// Token: 0x04000062 RID: 98
		public const string FD_RADCHKOPERTYPE = "FD_RADCHKOPERTYPE";

		// Token: 0x04000063 RID: 99
		public const string FD_RPTACCOPERTYPE = "FD_RPTACCOPERTYPE";

		// Token: 0x04000064 RID: 100
		public const string FD_EDITMODE = "FD_EDITMODE";

		// Token: 0x04000065 RID: 101
		public const string FD_MAXLTRPERQTY = "FD_MAXLTRPERQTY";

		// Token: 0x04000066 RID: 102
		public const string FD_MAXCONVPERQTY = "FD_MAXCONVPERQTY";

		// Token: 0x04000067 RID: 103
		public const string FD_MODELTYPE = "FD_MODELTYPE";

		// Token: 0x04000068 RID: 104
		public const string FD_RADTYPE = "FD_RADTYPE";

		// Token: 0x04000069 RID: 105
		public const string FD_FLSHCODECHAR = "FD_FLSHCODECHAR";

		// Token: 0x0400006A RID: 106
		public const string FD_PRVCPB = "FD_PRVCPB";

		// Token: 0x0400006B RID: 107
		public const string FD_GPSCPB = "FD_GPSCPB";

		// Token: 0x0400006C RID: 108
		public const string GPS_GPSBITCHK = "GPS_GPSBITCHK";

		// Token: 0x0400006D RID: 109
		public const string FD_20KHZBWCPB = "FD_20KHZBWCPB";

		// Token: 0x0400006E RID: 110
		public const string FD_OBCPB = "FD_OBCPB";

		// Token: 0x0400006F RID: 111
		public const string FD_ENHPRVCPB = "FD_ENHPRVCPB";

		// Token: 0x04000070 RID: 112
		public const string FD_CAPPLUSCPB = "FD_CAPPLUSCPB";

		// Token: 0x04000071 RID: 113
		public const string FD_ANALOGSQUELCH = "FD_ANALOGSQUELCH";

		// Token: 0x04000072 RID: 114
		public const string RS_LCDLEDDISCONF = "RS_LCDLEDDISCONF";

		// Token: 0x04000073 RID: 115
		public const string CNV_RAD_CMP_TYPE = "CNV_RAD_CMP_TYPE";

		// Token: 0x04000074 RID: 116
		public const string CR_MONTYPE = "CR_MONTYPE";

		// Token: 0x04000075 RID: 117
		public const string CR_TXINTIME = "CR_TXINTIME";

		// Token: 0x04000076 RID: 118
		public const string CR_TONESEN = "CR_TONESEN";

		// Token: 0x04000077 RID: 119
		public const string CR_LIGHTSEN = "CR_LIGHTSEN";

		// Token: 0x04000078 RID: 120
		public const string CNV_PER_CMP_TYPE_GRP = "CNV_PER_CMP_TYPE_GRP";

		// Token: 0x04000079 RID: 121
		public const string CNV_PER_CMP_TYPE = "CNV_PER_CMP_TYPE";

		// Token: 0x0400007A RID: 122
		public const string CP_SPKRSTATE = "CP_SPKRSTATE";

		// Token: 0x0400007B RID: 123
		public const string CP_RXONLYEN = "CP_RXONLYEN";

		// Token: 0x0400007C RID: 124
		public const string CP_REVBURST = "CP_REVBURST";

		// Token: 0x0400007D RID: 125
		public const string CP_TOCEN = "CP_TOCEN";

		// Token: 0x0400007E RID: 126
		public const string CP_UTOSCANEN = "CP_UTOSCANEN";

		// Token: 0x0400007F RID: 127
		public const string CP_BUSYLEDEN = "CP_BUSYLEDEN";

		// Token: 0x04000080 RID: 128
		public const string CP_RXSIGSQL = "CP_RXSIGSQL";

		// Token: 0x04000081 RID: 129
		public const string CP_TXINHXPLEN = "CP_TXINHXPLEN";

		// Token: 0x04000082 RID: 130
		public const string CP_MYCALLADCRTR = "CP_MYCALLADCRTR";

		// Token: 0x04000083 RID: 131
		public const string CP_UNMUTETYPE = "CP_UNMUTETYPE";

		// Token: 0x04000084 RID: 132
		public const string CP_PERSTYPE = "CP_PERSTYPE";

		// Token: 0x04000085 RID: 133
		public const string CP_PERSTYPERADWIDE = "CP_PERSTYPERADWIDE";

		// Token: 0x04000086 RID: 134
		public const string CP_TXREFFREQ = "CP_TXREFFREQ";

		// Token: 0x04000087 RID: 135
		public const string CP_RXREFFREQ = "CP_RXREFFREQ";

		// Token: 0x04000088 RID: 136
		public const string CP_BATTSAVEREN = "CP_BATTSAVEREN";

		// Token: 0x04000089 RID: 137
		public const string CP_ALLSYSCALLEN = "CP_ALLSYSCALLEN";

		// Token: 0x0400008A RID: 138
		public const string CP_TALKAROUNDEN = "CP_TALKAROUNDEN";

		// Token: 0x0400008B RID: 139
		public const string CP_SLTASSGMNT = "CP_SLTASSGMNT";

		// Token: 0x0400008C RID: 140
		public const string CP_CALLSETPRO = "CP_CALLSETPRO";

		// Token: 0x0400008D RID: 141
		public const string CP_TOT = "CP_TOT";

		// Token: 0x0400008E RID: 142
		public const string CP_VOICEPRIVACYEN = "CP_VOICEPRIVACYEN";

		// Token: 0x0400008F RID: 143
		public const string CP_EMPHASEL = "CP_EMPHASEL";

		// Token: 0x04000090 RID: 144
		public const string CP_RXUMUTEINHDLYSEL = "CP_RXUMUTEINHDLYSEL";

		// Token: 0x04000091 RID: 145
		public const string CP_TOTWRN = "CP_TOTWRN";

		// Token: 0x04000092 RID: 146
		public const string CP_SQCHSET = "CP_SQCHSET";

		// Token: 0x04000093 RID: 147
		public const string CP_SQUELCHPLUS = "CP_SQUELCHPLUS";

		// Token: 0x04000094 RID: 148
		public const string CP_OPBEN = "CP_OPBEN";

		// Token: 0x04000095 RID: 149
		public const string CP_SCANPERSLISTIT = "CP_SCANPERSLISTIT";

		// Token: 0x04000096 RID: 150
		public const string CP_SCANPERSLISTITTYPE = "CP_SCANPERSLISTITTYPE";

		// Token: 0x04000097 RID: 151
		public const string CP_SCANPERSLISTITID = "CP_SCANPERSLISTITID";

		// Token: 0x04000098 RID: 152
		public const string CP_COMPSTATE = "CP_COMPSTATE";

		// Token: 0x04000099 RID: 153
		public const string CP_CHASSGNTYPE = "CP_CHASSGNTYPE";

		// Token: 0x0400009A RID: 154
		public const string CP_TXPWR = "CP_TXPWR";

		// Token: 0x0400009B RID: 155
		public const string CP_SQCHCONT = "CP_SQCHCONT";

		// Token: 0x0400009C RID: 156
		public const string CP_SYNCMODE = "CP_SYNCMODE";

		// Token: 0x0400009D RID: 157
		public const string CP_ADVRFAGC = "CP_ADVRFAGC";

		// Token: 0x0400009E RID: 158
		public const string CP_RXUNMUTE = "CP_RXUNMUTE";

		// Token: 0x0400009F RID: 159
		public const string CP_RXSIGTY = "CP_RXSIGTY";

		// Token: 0x040000A0 RID: 160
		public const string CP_SCANREMCARSQCH = "CP_SCANREMCARSQCH";

		// Token: 0x040000A1 RID: 161
		public const string CP_TXSIGSYSIT = "CP_TXSIGSYSIT";

		// Token: 0x040000A2 RID: 162
		public const string CP_TXSIGSYSITTYPE = "CP_TXSIGSYSITTYPE";

		// Token: 0x040000A3 RID: 163
		public const string CP_TXSIGSYSITID = "CP_TXSIGSYSITID";

		// Token: 0x040000A4 RID: 164
		public const string CP_RXSIGSYSIT = "CP_RXSIGSYSIT";

		// Token: 0x040000A5 RID: 165
		public const string CP_RXSIGSYSITTYPE = "CP_RXSIGSYSITTYPE";

		// Token: 0x040000A6 RID: 166
		public const string CP_RXSIGSYSITID = "CP_RXSIGSYSITID";

		// Token: 0x040000A7 RID: 167
		public const string CP_EMSYSIT = "CP_EMSYSIT";

		// Token: 0x040000A8 RID: 168
		public const string CP_EMSYSITTYPE = "CP_EMSYSITTYPE";

		// Token: 0x040000A9 RID: 169
		public const string CP_EMSYSITID = "CP_EMSYSITID";

		// Token: 0x040000AA RID: 170
		public const string CP_TGLISTIT = "CP_TGLISTIT";

		// Token: 0x040000AB RID: 171
		public const string CP_TGLISTITTYPE = "CP_TGLISTITTYPE";

		// Token: 0x040000AC RID: 172
		public const string CP_TGLISTITID = "CP_TGLISTITID";

		// Token: 0x040000AD RID: 173
		public const string CP_CHNLBWDTH = "CP_CHNLBWDTH";

		// Token: 0x040000AE RID: 174
		public const string CP_PLDEV = "CP_PLDEV";

		// Token: 0x040000AF RID: 175
		public const string CP_TXDEV = "CP_TXDEV";

		// Token: 0x040000B0 RID: 176
		public const string CP_TXFREQ = "CP_TXFREQ";

		// Token: 0x040000B1 RID: 177
		public const string CP_RXFREQ = "CP_RXFREQ";

		// Token: 0x040000B2 RID: 178
		public const string CP_TXSQCHTY = "CP_TXSQCHTY";

		// Token: 0x040000B3 RID: 179
		public const string CP_TXTDPLCD = "CP_TXTDPLCD";

		// Token: 0x040000B4 RID: 180
		public const string CP_TXDPLCDINDEX = "CP_TXDPLCDINDEX";

		// Token: 0x040000B5 RID: 181
		public const string CP_XSQCHTY = "CP_XSQCHTY";

		// Token: 0x040000B6 RID: 182
		public const string CP_RXDPLCD = "CP_RXDPLCD";

		// Token: 0x040000B7 RID: 183
		public const string CP_RXDPLCDINDEX = "CP_RXDPLCDINDEX";

		// Token: 0x040000B8 RID: 184
		public const string CP_USELD = "CP_USELD";

		// Token: 0x040000B9 RID: 185
		public const string CP_TXDPLINV = "CP_TXDPLINV";

		// Token: 0x040000BA RID: 186
		public const string CP_RXDPLINV = "CP_RXDPLINV";

		// Token: 0x040000BB RID: 187
		public const string CP_VOXSTATE = "CP_VOXSTATE";

		// Token: 0x040000BC RID: 188
		public const string CP_EMACKEN = "CP_EMACKEN";

		// Token: 0x040000BD RID: 189
		public const string CP_EMACKALERTEN = "CP_EMACKALERTEN";

		// Token: 0x040000BE RID: 190
		public const string CP_EMALRMINDEN = "CP_EMALRMINDEN";

		// Token: 0x040000BF RID: 191
		public const string CP_EMCALINDEN = "CP_EMCALINDEN";

		// Token: 0x040000C0 RID: 192
		public const string CP_TXTTPLFREQ = "CP_TXTTPLFREQ";

		// Token: 0x040000C1 RID: 193
		public const string CP_TXTPLCODE = "CP_TXTPLCODE";

		// Token: 0x040000C2 RID: 194
		public const string CP_RXTPLFREQ = "CP_RXTPLFREQ";

		// Token: 0x040000C3 RID: 195
		public const string CP_RXTPLCODE = "CP_RXTPLCODE";

		// Token: 0x040000C4 RID: 196
		public const string CP_RXTPLFREQINDEX = "CP_RXTPLFREQINDEX";

		// Token: 0x040000C5 RID: 197
		public const string CP_TXTPLFREQINDEX = "CP_TXTPLFREQINDEX";

		// Token: 0x040000C6 RID: 198
		public const string CP_PLREQDATA = "CP_PLREQDATA";

		// Token: 0x040000C7 RID: 199
		public const string CP_VOICELMT = "CP_VOICELMT";

		// Token: 0x040000C8 RID: 200
		public const string CP_DATALMT = "CP_DATALMT";

		// Token: 0x040000C9 RID: 201
		public const string CP_EMGCYSEQ = "CP_EMGCYSEQ";

		// Token: 0x040000CA RID: 202
		public const string CP_CNVPERSALIAS = "CP_CNVPERSALIAS";

		// Token: 0x040000CB RID: 203
		public const string CP_UKPPERS = "CP_UKPPERS";

		// Token: 0x040000CC RID: 204
		public const string CP_UKPPERSTYPE = "CP_UKPPERSTYPE";

		// Token: 0x040000CD RID: 205
		public const string CP_UKPPERSID = "CP_UKPPERSID";

		// Token: 0x040000CE RID: 206
		public const string CP_TOTREKEYDELAY = "CP_TOTREKEYDELAY";

		// Token: 0x040000CF RID: 207
		public const string CP_DATABCL = "CP_DATABCL";

		// Token: 0x040000D0 RID: 208
		public const string CP_AFCEN = "CP_AFCEN";

		// Token: 0x040000D1 RID: 209
		public const string CP_PRSEN = "CP_PRSEN";

		// Token: 0x040000D2 RID: 210
		public const string CP_ARSEN = "CP_ARSEN";

		// Token: 0x040000D3 RID: 211
		public const string CP_OPTRUNKMODE = "CP_OPTRUNKMODE";

		// Token: 0x040000D4 RID: 212
		public const string CP_PLRXMDCDTEN = "CP_PLRXMDCDTEN";

		// Token: 0x040000D5 RID: 213
		public const string CP_COLORCODE = "CP_COLORCODE";

		// Token: 0x040000D6 RID: 214
		public const string CP_GPSRVRTPERSIT = "CP_GPSRVRTPERSIT";

		// Token: 0x040000D7 RID: 215
		public const string CP_GPSRVRTPERSITTYPE = "CP_GPSRVRTPERSITTYPE";

		// Token: 0x040000D8 RID: 216
		public const string CP_GPSRVRTPERSITID = "CP_GPSRVRTPERSITID";

		// Token: 0x040000D9 RID: 217
		public const string CP_BANDIT_VHF_FREQ = "CP_BANDIT_VHF_FREQ";

		// Token: 0x040000DA RID: 218
		public const string CP_DIGSYSITEM = "CP_DIGSYSITEM";

		// Token: 0x040000DB RID: 219
		public const string CP_CPCOLITEM = "CP_CPCOLITEM";

		// Token: 0x040000DC RID: 220
		public const string CP_ASTROTGLSTITEM = "CP_ASTROTGLSTITEM";

		// Token: 0x040000DD RID: 221
		public const string CP_ASTROTGTXTLSTITEM = "CP_ASTROTGTXTLSTITEM";

		// Token: 0x040000DE RID: 222
		public const string CP_SINGLETONESYSITEM = "CP_SINGLETONESYSITEM";

		// Token: 0x040000DF RID: 223
		public const string CP_ANHOTITEM = "CP_ANHOTITEM";

		// Token: 0x040000E0 RID: 224
		public const string CP_DIGHOTLSTITEM = "CP_DIGHOTLSTITEM";

		// Token: 0x040000E1 RID: 225
		public const string CP_SECKMFPLITEM = "CP_SECKMFPLITEM";

		// Token: 0x040000E2 RID: 226
		public const string ZCPALELL_CAVFDLITEM = "ZCPALELL_CAVFDLITEM";

		// Token: 0x040000E3 RID: 227
		public const string ZCPALELL_RPITEM = "ZCPALELL_RPITEM";

		// Token: 0x040000E4 RID: 228
		public const string CP_MPT1327ENABLE = "CP_MPT1327ENABLE";

		// Token: 0x040000E5 RID: 229
		public const string RAD_APP_INFO_CMP_TYPE = "RAD_APP_INFO_CMP_TYPE";

		// Token: 0x040000E6 RID: 230
		public const string RI_LPGYEAR = "RI_LPGYEAR";

		// Token: 0x040000E7 RID: 231
		public const string RI_LPGMONTH = "RI_LPGMONTH";

		// Token: 0x040000E8 RID: 232
		public const string RI_LPGDAY = "RI_LPGDAY";

		// Token: 0x040000E9 RID: 233
		public const string RI_LPGHOUR = "RI_LPGHOUR";

		// Token: 0x040000EA RID: 234
		public const string RI_LPGMINUTES = "RI_LPGMINUTES";

		// Token: 0x040000EB RID: 235
		public const string RI_LPGSOURCE = "RI_LPGSOURCE";

		// Token: 0x040000EC RID: 236
		public const string RI_MAJAPPVERS = "RI_MAJAPPVERS";

		// Token: 0x040000ED RID: 237
		public const string RI_MIDAPPVERS = "RI_MIDAPPVERS";

		// Token: 0x040000EE RID: 238
		public const string RI_MINAPPVERS = "RI_MINAPPVERS";

		// Token: 0x040000EF RID: 239
		public const string RI_NUMRADIORST = "RI_NUMRADIORST";

		// Token: 0x040000F0 RID: 240
		public const string RI_LPGDATE = "RI_LPGDATE";

		// Token: 0x040000F1 RID: 241
		public const string RI_APPVERS = "RI_APPVERS";

		// Token: 0x040000F2 RID: 242
		public const string RAD_CFG_CMP_TYPE = "RAD_CFG_CMP_TYPE";

		// Token: 0x040000F3 RID: 243
		public const string RC_DTMFHTM = "RC_DTMFHTM";

		// Token: 0x040000F4 RID: 244
		public const string RC_KEYUNLOCKTMR = "RC_KEYUNLOCKTMR";

		// Token: 0x040000F5 RID: 245
		public const string RC_ZNCHSEL = "RC_ZNCHSEL";

		// Token: 0x040000F6 RID: 246
		public const string RC_LOWBATTXCHIRP = "RC_LOWBATTXCHIRP";

		// Token: 0x040000F7 RID: 247
		public const string RC_TXLOWBATTLED = "RC_TXLOWBATTLED";

		// Token: 0x040000F8 RID: 248
		public const string RC_ALLRNGTONEEN = "RC_ALLRNGTONEEN";

		// Token: 0x040000F9 RID: 249
		public const string RC_KPCHIRPEN = "RC_KPCHIRPEN";

		// Token: 0x040000FA RID: 250
		public const string RC_TPTEN = "RC_TPTEN";

		// Token: 0x040000FB RID: 251
		public const string RC_ESCALRTEN = "RC_ESCALRTEN";

		// Token: 0x040000FC RID: 252
		public const string RC_OORIND = "RC_OORIND";

		// Token: 0x040000FD RID: 253
		public const string RC_STALRTONE = "RC_STALRTONE";

		// Token: 0x040000FE RID: 254
		public const string RC_RXALRT = "RC_RXALRT";

		// Token: 0x040000FF RID: 255
		public const string RC_RXAUDIOPINEN = "RC_RXAUDIOPINEN";

		// Token: 0x04000100 RID: 256
		public const string RC_AVCRSPCURV = "RC_AVCRSPCURV";

		// Token: 0x04000101 RID: 257
		public const string RC_LBATCHIRPINT = "RC_LBATCHIRPINT";

		// Token: 0x04000102 RID: 258
		public const string RC_TXLED = "RC_TXLED";

		// Token: 0x04000103 RID: 259
		public const string RC_VOLADJTONEEN = "RC_VOLADJTONEEN";

		// Token: 0x04000104 RID: 260
		public const string RC_BATINFODEN = "RC_BATINFODEN";

		// Token: 0x04000105 RID: 261
		public const string RC_PHNCALLTONEEN = "RC_PHNCALLTONEEN";

		// Token: 0x04000106 RID: 262
		public const string RC_PRVCALLTONEEN = "RC_PRVCALLTONEEN";

		// Token: 0x04000107 RID: 263
		public const string RC_VOLINCLEVEL = "RC_VOLINCLEVEL";

		// Token: 0x04000108 RID: 264
		public const string RC_SHRTKEYDUR = "RC_SHRTKEYDUR";

		// Token: 0x04000109 RID: 265
		public const string RC_LONGKEYDUR = "RC_LONGKEYDUR";

		// Token: 0x0400010A RID: 266
		public const string RC_NEXTKEYDUR = "RC_NEXTKEYDUR";

		// Token: 0x0400010B RID: 267
		public const string RC_DELSLOWRATE = "RC_DELSLOWRATE";

		// Token: 0x0400010C RID: 268
		public const string RC_DELSLOWCNT = "RC_DELSLOWCNT";

		// Token: 0x0400010D RID: 269
		public const string RC_OORINDINT = "RC_OORINDINT";

		// Token: 0x0400010E RID: 270
		public const string RC_GRPCALLTB = "RC_GRPCALLTB";

		// Token: 0x0400010F RID: 271
		public const string RC_PRIVCALLTB = "RC_PRIVCALLTB";

		// Token: 0x04000110 RID: 272
		public const string RC_SIT = "RC_SIT";

		// Token: 0x04000111 RID: 273
		public const string RC_GRPCALLHT = "RC_GRPCALLHT";

		// Token: 0x04000112 RID: 274
		public const string RC_PRVTCALLHT = "RC_PRVTCALLHT";

		// Token: 0x04000113 RID: 275
		public const string RC_EMERCALLHT = "RC_EMERCALLHT";

		// Token: 0x04000114 RID: 276
		public const string RC_ACTMICSRC = "RC_ACTMICSRC";

		// Token: 0x04000115 RID: 277
		public const string RC_MICOHDISPLEN = "RC_MICOHDISPLEN";

		// Token: 0x04000116 RID: 278
		public const string RC_EXTPASTAT = "RC_EXTPASTAT";

		// Token: 0x04000117 RID: 279
		public const string RC_INTPASTAT = "RC_INTPASTAT";

		// Token: 0x04000118 RID: 280
		public const string RC_EXTSWBX = "RC_EXTSWBX";

		// Token: 0x04000119 RID: 281
		public const string RC_RINGTMR = "RC_RINGTMR";

		// Token: 0x0400011A RID: 282
		public const string RC_OFFSETRINGTMR = "RC_OFFSETRINGTMR";

		// Token: 0x0400011B RID: 283
		public const string RC_BATTINDUPT = "RC_BATTINDUPT";

		// Token: 0x0400011C RID: 284
		public const string RC_MINVOL = "RC_MINVOL";

		// Token: 0x0400011D RID: 285
		public const string RC_MAXVOL = "RC_MAXVOL";

		// Token: 0x0400011E RID: 286
		public const string RC_MINVOLLVL = "RC_MINVOLLVL";

		// Token: 0x0400011F RID: 287
		public const string RC_MAXVOLLVL = "RC_MAXVOLLVL";

		// Token: 0x04000120 RID: 288
		public const string RC_SMRTLOWBATT = "RC_SMRTLOWBATT";

		// Token: 0x04000121 RID: 289
		public const string RC_ALRTONEVOLOFF = "RC_ALRTONEVOLOFF";

		// Token: 0x04000122 RID: 290
		public const string RC_RSSIDISBAR = "RC_RSSIDISBAR";

		// Token: 0x04000123 RID: 291
		public const string RC_SYNTHOOLINDIC = "RC_SYNTHOOLINDIC";

		// Token: 0x04000124 RID: 292
		public const string RC_INTANLGFX = "RC_INTANLGFX";

		// Token: 0x04000125 RID: 293
		public const string RC_INTANLGFXDEF = "RC_INTANLGFXDEF";

		// Token: 0x04000126 RID: 294
		public const string RC_INTANLGFX_M = "RC_INTANLGFX_M";

		// Token: 0x04000127 RID: 295
		public const string RP_EXTMICANAGC = "RP_EXTMICANAGC";

		// Token: 0x04000128 RID: 296
		public const string RC_EXTANLGFX = "RC_EXTANLGFX";

		// Token: 0x04000129 RID: 297
		public const string RC_EXTANLGFXDEF = "RC_EXTANLGFXDEF";

		// Token: 0x0400012A RID: 298
		public const string RC_EXTANLGFX_M = "RC_EXTANLGFX_M";

		// Token: 0x0400012B RID: 299
		public const string RC_EXTANLGFX_BANDIT = "RC_EXTANLGFX_BANDIT";

		// Token: 0x0400012C RID: 300
		public const string RC_IXTDIGFX = "RC_IXTDIGFX";

		// Token: 0x0400012D RID: 301
		public const string RC_EXTDIGFX = "RC_EXTDIGFX";

		// Token: 0x0400012E RID: 302
		public const string RC_IXTDIGFX_M = "RC_IXTDIGFX_M";

		// Token: 0x0400012F RID: 303
		public const string RC_EXTDIGFX_M = "RC_EXTDIGFX_M";

		// Token: 0x04000130 RID: 304
		public const string RC_WELCOMETEXT = "RC_WELCOMETEXT";

		// Token: 0x04000131 RID: 305
		public const string RC_LANGSELECT = "RC_LANGSELECT";

		// Token: 0x04000132 RID: 306
		public const string RC_PRIVCALRTRNUM = "RC_PRIVCALRTRNUM";

		// Token: 0x04000133 RID: 307
		public const string RC_VOLPRIVACYKEY = "RC_VOLPRIVACYKEY";

		// Token: 0x04000134 RID: 308
		public const string RC_CPPASSWORD = "RC_CPPASSWORD";

		// Token: 0x04000135 RID: 309
		public const string CS_ARCHIVEPASSWD = "CS_ARCHIVEPASSWD";

		// Token: 0x04000136 RID: 310
		public const string RC_MINVOXACTHRESHOLD = "RC_MINVOXACTHRESHOLD";

		// Token: 0x04000137 RID: 311
		public const string RC_MINVOXDEACTHRESHOLD = "RC_MINVOXDEACTHRESHOLD";

		// Token: 0x04000138 RID: 312
		public const string RC_ATTACKTIME = "RC_ATTACKTIME";

		// Token: 0x04000139 RID: 313
		public const string RC_RELEASETIME = "RC_RELEASETIME";

		// Token: 0x0400013A RID: 314
		public const string RC_TXLOWPWR = "RC_TXLOWPWR";

		// Token: 0x0400013B RID: 315
		public const string RC_TXHGHPWR = "RC_TXHGHPWR";

		// Token: 0x0400013C RID: 316
		public const string RC_TXLOWPWR1 = "RC_TXLOWPWR1";

		// Token: 0x0400013D RID: 317
		public const string RC_TXHGHPWR1 = "RC_TXHGHPWR1";

		// Token: 0x0400013E RID: 318
		public const string RC_TXLOWPWR2 = "RC_TXLOWPWR2";

		// Token: 0x0400013F RID: 319
		public const string RC_TXHGHPWR2 = "RC_TXHGHPWR2";

		// Token: 0x04000140 RID: 320
		public const string RC_TXLOWPWR_TONGA = "RC_TXLOWPWR_TONGA";

		// Token: 0x04000141 RID: 321
		public const string RC_TXHGHPWR_TONGA = "RC_TXHGHPWR_TONGA";

		// Token: 0x04000142 RID: 322
		public const string RC_TXLOWPWR2_TONGA = "RC_TXLOWPWR2_TONGA";

		// Token: 0x04000143 RID: 323
		public const string RC_TXHGHPWR2_TONGA = "RC_TXHGHPWR2_TONGA";

		// Token: 0x04000144 RID: 324
		public const string RC_TXLOWPWR_TONGAPLUS = "RC_TXLOWPWR_TONGAPLUS";

		// Token: 0x04000145 RID: 325
		public const string RC_TXLOWPWR_TONGAPLUS_CHOICE = "RC_TXLOWPWR_TONGAPLUS_CHOICE";

		// Token: 0x04000146 RID: 326
		public const string RC_TXHGHPWR_TONGAPLUS = "RC_TXHGHPWR_TONGAPLUS";

		// Token: 0x04000147 RID: 327
		public const string RC_TXHGHPWR_TONGAPLUS_CHOICE = "RC_TXHGHPWR_TONGAPLUS_CHOICE";

		// Token: 0x04000148 RID: 328
		public const string RC_TXLOWPWR2_TONGAPLUS = "RC_TXLOWPWR2_TONGAPLUS";

		// Token: 0x04000149 RID: 329
		public const string RC_TXLOWPWR2_TONGAPLUS_CHOICE = "RC_TXLOWPWR2_TONGAPLUS_CHOICE";

		// Token: 0x0400014A RID: 330
		public const string RC_TXHGHPWR2_TONGAPLUS = "RC_TXHGHPWR2_TONGAPLUS";

		// Token: 0x0400014B RID: 331
		public const string RC_TXHGHPWR2_TONGAPLUS_CHOICE = "RC_TXHGHPWR2_TONGAPLUS_CHOICE";

		// Token: 0x0400014C RID: 332
		public const string RC_DMTPL = "RC_DMTPL";

		// Token: 0x0400014D RID: 333
		public const string RC_RADIOALIAS = "RC_RADIOALIAS";

		// Token: 0x0400014E RID: 334
		public const string RC_RADIOAPPROVALTYPE = "RC_RADIOAPPROVALTYPE";

		// Token: 0x0400014F RID: 335
		public const string RC_EMERCHANCHGDELTMR = "RC_EMERCHANCHGDELTMR";

		// Token: 0x04000150 RID: 336
		public const string RC_DROPOUTDELAYTMR = "RC_DROPOUTDELAYTMR";

		// Token: 0x04000151 RID: 337
		public const string RC_SUBSCRIBERID = "RC_SUBSCRIBERID";

		// Token: 0x04000152 RID: 338
		public const string RC_BATACCYPWR = "RC_BATACCYPWR";

		// Token: 0x04000153 RID: 339
		public const string RC_RSSIDISBAR6 = "RC_RSSIDISBAR6";

		// Token: 0x04000154 RID: 340
		public const string RC_MICGAIN = "RC_MICGAIN";

		// Token: 0x04000155 RID: 341
		public const string RC_EXTNCARXEQUEN = "RC_EXTNCARXEQUEN";

		// Token: 0x04000156 RID: 342
		public const string RC_MICGAINOFFSET = "RC_MICGAINOFFSET";

		// Token: 0x04000157 RID: 343
		public const string RC_BASESTATIONADDR = "RC_BASESTATIONADDR";

		// Token: 0x04000158 RID: 344
		public const string RC_FSTPTHRLV = "RC_FSTPTHRLV";

		// Token: 0x04000159 RID: 345
		public const string RC_SNDPTHRLVL = "RC_SNDPTHRLVL";

		// Token: 0x0400015A RID: 346
		public const string RC_ADJFSTPTHRLVL = "RC_ADJFSTPTHRLVL";

		// Token: 0x0400015B RID: 347
		public const string RC_CACHATDTFITHR = "RC_CACHATDTFITHR";

		// Token: 0x0400015C RID: 348
		public const string RC_TCAPCNTLMT = "RC_TCAPCNTLMT";

		// Token: 0x0400015D RID: 349
		public const string RC_PCENDEEN = "RC_PCENDEEN";

		// Token: 0x0400015E RID: 350
		public const string RC_INTMICMIDYR = "RC_INTMICMIDYR";

		// Token: 0x0400015F RID: 351
		public const string RC_INTMICMADYR = "RC_INTMICMADYR";

		// Token: 0x04000160 RID: 352
		public const string RC_EXTCMICMIDYR = "RC_EXTCMICMIDYR";

		// Token: 0x04000161 RID: 353
		public const string RC_EXTCMICMADYR = "RC_EXTCMICMADYR";

		// Token: 0x04000162 RID: 354
		public const string RC_EXTNCMICMIDYR = "RC_EXTNCMICMIDYR";

		// Token: 0x04000163 RID: 355
		public const string RC_EXTNCMICMADYR = "RC_EXTNCMICMADYR";

		// Token: 0x04000164 RID: 356
		public const string RC_MICATCKRATE = "RC_MICATCKRATE";

		// Token: 0x04000165 RID: 357
		public const string RC_MICDECAYRATE = "RC_MICDECAYRATE";

		// Token: 0x04000166 RID: 358
		public const string RC_AMICREFPL = "RC_AMICREFPL";

		// Token: 0x04000167 RID: 359
		public const string RC_DMICREFPL = "RC_DMICREFPL";

		// Token: 0x04000168 RID: 360
		public const string RC_NSPPREN = "RC_NSPPREN";

		// Token: 0x04000169 RID: 361
		public const string RC_VOXSENT = "RC_VOXSENT";

		// Token: 0x0400016A RID: 362
		public const string RC_AVOXSTBUFSIZE = "RC_AVOXSTBUFSIZE";

		// Token: 0x0400016B RID: 363
		public const string RC_DVOXSTBUFSIZE = "RC_DVOXSTBUFSIZE";

		// Token: 0x0400016C RID: 364
		public const string RC_INTTRIEQUEN = "RC_INTTRIEQUEN";

		// Token: 0x0400016D RID: 365
		public const string RC_INTTRIEQUB1INFO = "RC_INTTRIEQUB1INFO";

		// Token: 0x0400016E RID: 366
		public const string RC_INTTRIEQUB2INFO = "RC_INTTRIEQUB2INFO";

		// Token: 0x0400016F RID: 367
		public const string RC_INTTRIEQUB3INFO = "RC_INTTRIEQUB3INFO";

		// Token: 0x04000170 RID: 368
		public const string RC_EXTCTRIEQUEN = "RC_EXTCTRIEQUEN";

		// Token: 0x04000171 RID: 369
		public const string RC_EXTCTRIEQUB1INFO = "RC_EXTCTRIEQUB1INFO";

		// Token: 0x04000172 RID: 370
		public const string RC_EXTCTRIEQUB2INFO = "RC_EXTCTRIEQUB2INFO";

		// Token: 0x04000173 RID: 371
		public const string RC_EXTCTRIEQUB3INFO = "RC_EXTCTRIEQUB3INFO";

		// Token: 0x04000174 RID: 372
		public const string RC_EXTNCTRIEQUB1INFO = "RC_EXTNCTRIEQUB1INFO";

		// Token: 0x04000175 RID: 373
		public const string RC_EXTNCTRIEQUB2INFO = "RC_EXTNCTRIEQUB2INFO";

		// Token: 0x04000176 RID: 374
		public const string RC_EXTNCTRIEQUB3INFO = "RC_EXTNCTRIEQUB3INFO";

		// Token: 0x04000177 RID: 375
		public const string RC_EXTNCDTXEQUFL = "RC_EXTNCDTXEQUFL";

		// Token: 0x04000178 RID: 376
		public const string RC_INTARXEQUFL = "RC_INTARXEQUFL";

		// Token: 0x04000179 RID: 377
		public const string RC_EXTCARXEQUFL = "RC_EXTCARXEQUFL";

		// Token: 0x0400017A RID: 378
		public const string RC_EXTNCARXEQUFL = "RC_EXTNCARXEQUFL";

		// Token: 0x0400017B RID: 379
		public const string RC_INTDRXEQUFL = "RC_INTDRXEQUFL";

		// Token: 0x0400017C RID: 380
		public const string RC_EXTCDRXEQUFL = "RC_EXTCDRXEQUFL";

		// Token: 0x0400017D RID: 381
		public const string RC_EXTNCDRXEQUFL = "RC_EXTNCDRXEQUFL";

		// Token: 0x0400017E RID: 382
		public const string RC_EXTCATXEQUFL = "RC_EXTCATXEQUFL";

		// Token: 0x0400017F RID: 383
		public const string RC_PCENEN = "RC_PCENEN";

		// Token: 0x04000180 RID: 384
		public const string RC_PCDEEN = "RC_PCDEEN";

		// Token: 0x04000181 RID: 385
		public const string RC_ARSRGATT = "RC_ARSRGATT";

		// Token: 0x04000182 RID: 386
		public const string RC_ARSDERGDLTMR = "RC_ARSDERGDLTMR";

		// Token: 0x04000183 RID: 387
		public const string RC_ARSEN = "RC_ARSEN";

		// Token: 0x04000184 RID: 388
		public const string RC_LRRPEN = "RC_LRRPEN";

		// Token: 0x04000185 RID: 389
		public const string RC_SDPDFRDTMR = "RC_SDPDFRDTMR";

		// Token: 0x04000186 RID: 390
		public const string RC_CAHLDOFFTMR = "RC_CAHLDOFFTMR";

		// Token: 0x04000187 RID: 391
		public const string RC_PDAWTMR = "RC_PDAWTMR";

		// Token: 0x04000188 RID: 392
		public const string RC_CTXTRNTMR = "RC_CTXTRNTMR";

		// Token: 0x04000189 RID: 393
		public const string RC_QUDWTMR = "RC_QUDWTMR";

		// Token: 0x0400018A RID: 394
		public const string RC_ARPCDEPTH = "RC_ARPCDEPTH";

		// Token: 0x0400018B RID: 395
		public const string RC_ARPCTM = "RC_ARPCTM";

		// Token: 0x0400018C RID: 396
		public const string RC_CAIDATAREGEN = "RC_CAIDATAREGEN";

		// Token: 0x0400018D RID: 397
		public const string RC_TMSACKWTMR = "RC_TMSACKWTMR";

		// Token: 0x0400018E RID: 398
		public const string RC_ARSRETMR = "RC_ARSRETMR";

		// Token: 0x0400018F RID: 399
		public const string RC_VPRKEYID = "RC_VPRKEYID";

		// Token: 0x04000190 RID: 400
		public const string RC_NOPOLRETINDCLL = "RC_NOPOLRETINDCLL";

		// Token: 0x04000191 RID: 401
		public const string RC_FPRESETEN = "RC_FPRESETEN";

		// Token: 0x04000192 RID: 402
		public const string RC_DMBATTSVROPEN = "RC_DMBATTSVROPEN";

		// Token: 0x04000193 RID: 403
		public const string RC_TXTMSGTONE = "RC_TXTMSGTONE";

		// Token: 0x04000194 RID: 404
		public const string RC_CALLALERTTONE = "RC_CALLALERTTONE";

		// Token: 0x04000195 RID: 405
		public const string RC_BATTSVRCKTM = "RC_BATTSVRCKTM";

		// Token: 0x04000196 RID: 406
		public const string RC_TXPRECRIDLETM = "RC_TXPRECRIDLETM";

		// Token: 0x04000197 RID: 407
		public const string RC_BATTSVRSLPTM = "RC_BATTSVRSLPTM";

		// Token: 0x04000198 RID: 408
		public const string RC_BATTSVRWAKETM = "RC_BATTSVRWAKETM";

		// Token: 0x04000199 RID: 409
		public const string RC_BRCFDATAHANFTMR = "RC_BRCFDATAHANFTMR";

		// Token: 0x0400019A RID: 410
		public const string RC_TELACKWTMR = "RC_TELACKWTMR";

		// Token: 0x0400019B RID: 411
		public const string RC_EMRGSQNCENMBR = "RC_EMRGSQNCENMBR";

		// Token: 0x0400019C RID: 412
		public const string RC_VPOPT = "RC_VPOPT";

		// Token: 0x0400019D RID: 413
		public const string RC_XNLIPPORT = "RC_XNLIPPORT";

		// Token: 0x0400019E RID: 414
		public const string RC_EMSHRTKEYDUR = "RC_EMSHRTKEYDUR";

		// Token: 0x0400019F RID: 415
		public const string RC_BTFTCK = "RC_BTFTCK";

		// Token: 0x040001A0 RID: 416
		public const string RC_BTCTRCODE = "RC_BTCTRCODE";

		// Token: 0x040001A1 RID: 417
		public const string RC_BTMYNAME = "RC_BTMYNAME";

		// Token: 0x040001A2 RID: 418
		public const string RC_BTRCONNTO = "RC_BTRCONNTO";

		// Token: 0x040001A3 RID: 419
		public const string RC_BTANAMICGAIN = "RC_BTANAMICGAIN";

		// Token: 0x040001A4 RID: 420
		public const string RC_BTDIGMICGAIN = "RC_BTDIGMICGAIN";

		// Token: 0x040001A5 RID: 421
		public const string RC_BTOFFHKOPT = "RC_BTOFFHKOPT";

		// Token: 0x040001A6 RID: 422
		public const string RC_BTRPTTADRT = "RC_BTRPTTADRT";

		// Token: 0x040001A7 RID: 423
		public const string RC_BTPPFXPINHSP = "RC_BTPPFXPINHSP";

		// Token: 0x040001A8 RID: 424
		public const string RC_BTPPFXPINSPP = "RC_BTPPFXPINSPP";

		// Token: 0x040001A9 RID: 425
		public const string RC_BTINQDUR = "RC_BTINQDUR";

		// Token: 0x040001AA RID: 426
		public const string RC_BTCONNRSPTO = "RC_BTCONNRSPTO";

		// Token: 0x040001AB RID: 427
		public const string RC_BTSTS = "RC_BTSTS";

		// Token: 0x040001AC RID: 428
		public const string RC_BTSPKFXGAIN = "RC_BTSPKFXGAIN";

		// Token: 0x040001AD RID: 429
		public const string RC_BTDVCDBERSPO = "RC_BTDVCDBERSPO";

		// Token: 0x040001AE RID: 430
		public const string RC_25KHZBDCAP = "RC_25KHZBDCAP";

		// Token: 0x040001AF RID: 431
		public const string RC_EXTNCDRXEQUEN = "RC_EXTNCDRXEQUEN";

		// Token: 0x040001B0 RID: 432
		public const string RC_EXTCDRXEQUEN = "RC_EXTCDRXEQUEN";

		// Token: 0x040001B1 RID: 433
		public const string RC_INTDRXEQUEN = "RC_INTDRXEQUEN";

		// Token: 0x040001B2 RID: 434
		public const string RC_INTATXEQUEN = "RC_INTATXEQUEN";

		// Token: 0x040001B3 RID: 435
		public const string RC_EXTCATXEQUEN = "RC_EXTCATXEQUEN";

		// Token: 0x040001B4 RID: 436
		public const string RC_EXTNCATXEQUEN = "RC_EXTNCATXEQUEN";

		// Token: 0x040001B5 RID: 437
		public const string RC_INTDTXEQUEN = "RC_INTDTXEQUEN";

		// Token: 0x040001B6 RID: 438
		public const string RC_EXTCDTXEQUEN = "RC_EXTCDTXEQUEN";

		// Token: 0x040001B7 RID: 439
		public const string RC_EXTNCDTXEQUEN = "RC_EXTNCDTXEQUEN";

		// Token: 0x040001B8 RID: 440
		public const string RC_INTARXEQUEN = "RC_INTARXEQUEN";

		// Token: 0x040001B9 RID: 441
		public const string RC_EXTCARXEQUEN = "RC_EXTCARXEQUEN";

		// Token: 0x040001BA RID: 442
		public const string RC_TOTPRETIME = "RC_TOTPRETIME";

		// Token: 0x040001BB RID: 443
		public const string RC_TRNSMTRETRY = "RC_TRNSMTRETRY";

		// Token: 0x040001BC RID: 444
		public const string RC_DISABLEALLT = "RC_DISABLEALLT";

		// Token: 0x040001BD RID: 445
		public const string RC_EXTMICGAIN = "RC_EXTMICGAIN";

		// Token: 0x040001BE RID: 446
		public const string RC_DISENLED = "RC_DISENLED";

		// Token: 0x040001BF RID: 447
		public const string RC_CHCGCLKTNEN = "RC_CHCGCLKTNEN";

		// Token: 0x040001C0 RID: 448
		public const string RC_RDINHIBITPERSIT = "RC_RDINHIBITPERSIT";

		// Token: 0x040001C1 RID: 449
		public const string RC_RDINHIBITPERSITID = "RC_RDINHIBITPERSITID";

		// Token: 0x040001C2 RID: 450
		public const string RC_RDINHIBITPERSITTYPE = "RC_RDINHIBITPERSITTYPE";

		// Token: 0x040001C3 RID: 451
		public const string RC_RDINHIBITSTATE = "RC_RDINHIBITSTATE";

		// Token: 0x040001C4 RID: 452
		public const string RC_INTMICAGCEN = "RC_INTMICAGCEN";

		// Token: 0x040001C5 RID: 453
		public const string RP_EXTMICANAGC_MOBRPTR = "RP_EXTMICANAGC_MOBRPTR";

		// Token: 0x040001C6 RID: 454
		public const string RC_INTMICAGCEN_MOBRPTR = "RC_INTMICAGCEN_MOBRPTR";

		// Token: 0x040001C7 RID: 455
		public const string RC_DGTLMICAGCEN = "RC_DGTLMICAGCEN";

		// Token: 0x040001C8 RID: 456
		public const string RC_INTDGTLFXDEF = "RC_INTDGTLFXDEF";

		// Token: 0x040001C9 RID: 457
		public const string RC_EXTDGTLFXDEF = "RC_EXTDGTLFXDEF";

		// Token: 0x040001CA RID: 458
		public const string RC_ANLGTPTEN = "RC_ANLGTPTEN";

		// Token: 0x040001CB RID: 459
		public const string RC_GUITPT = "RC_GUITPT";

		// Token: 0x040001CC RID: 460
		public const string RC_DIGCFIENABLE = "RC_DIGCFIENABLE";

		// Token: 0x040001CD RID: 461
		public const string RC_DTMFTONEEN = "RC_DTMFTONEEN";

		// Token: 0x040001CE RID: 462
		public const string RC_DTMFACTDUR = "RC_DTMFACTDUR";

		// Token: 0x040001CF RID: 463
		public const string RC_LIMTXPOW = "RC_LIMTXPOW";

		// Token: 0x040001D0 RID: 464
		public const string RC_BTPHWADDRHSP = "RC_BTPHWADDRHSP";

		// Token: 0x040001D1 RID: 465
		public const string RC_BTPHWADDRHSP0 = "RC_BTPHWADDRHSP0";

		// Token: 0x040001D2 RID: 466
		public const string RC_BTPHWADDRHSP1 = "RC_BTPHWADDRHSP1";

		// Token: 0x040001D3 RID: 467
		public const string RC_BTPHWADDRHSP2 = "RC_BTPHWADDRHSP2";

		// Token: 0x040001D4 RID: 468
		public const string RC_BTPHWADDRHSP3 = "RC_BTPHWADDRHSP3";

		// Token: 0x040001D5 RID: 469
		public const string RC_BTPHWADDRHSP4 = "RC_BTPHWADDRHSP4";

		// Token: 0x040001D6 RID: 470
		public const string RC_BTPHWADDRHSP5 = "RC_BTPHWADDRHSP5";

		// Token: 0x040001D7 RID: 471
		public const string RC_BTPHWADDRSPP = "RC_BTPHWADDRSPP";

		// Token: 0x040001D8 RID: 472
		public const string RC_BTPHWADDRSPP0 = "RC_BTPHWADDRSPP0";

		// Token: 0x040001D9 RID: 473
		public const string RC_BTPHWADDRSPP1 = "RC_BTPHWADDRSPP1";

		// Token: 0x040001DA RID: 474
		public const string RC_BTPHWADDRSPP2 = "RC_BTPHWADDRSPP2";

		// Token: 0x040001DB RID: 475
		public const string RC_BTPHWADDRSPP3 = "RC_BTPHWADDRSPP3";

		// Token: 0x040001DC RID: 476
		public const string RC_BTPHWADDRSPP4 = "RC_BTPHWADDRSPP4";

		// Token: 0x040001DD RID: 477
		public const string RC_BTPHWADDRSPP5 = "RC_BTPHWADDRSPP5";

		// Token: 0x040001DE RID: 478
		public const string RC_BTHWADDRSPPPTT = "RC_BTHWADDRSPPPTT";

		// Token: 0x040001DF RID: 479
		public const string RC_BTHWADDRSPPPTT0 = "RC_BTHWADDRSPPPTT0";

		// Token: 0x040001E0 RID: 480
		public const string RC_BTHWADDRSPPPTT1 = "RC_BTHWADDRSPPPTT1";

		// Token: 0x040001E1 RID: 481
		public const string RC_BTHWADDRSPPPTT2 = "RC_BTHWADDRSPPPTT2";

		// Token: 0x040001E2 RID: 482
		public const string RC_BTHWADDRSPPPTT3 = "RC_BTHWADDRSPPPTT3";

		// Token: 0x040001E3 RID: 483
		public const string RC_BTHWADDRSPPPTT4 = "RC_BTHWADDRSPPPTT4";

		// Token: 0x040001E4 RID: 484
		public const string RC_BTHWADDRSPPPTT5 = "RC_BTHWADDRSPPPTT5";

		// Token: 0x040001E5 RID: 485
		public const string NODATAROUT = "NODATAROUT";

		// Token: 0x040001E6 RID: 486
		public const string DATAROUTIP = "DATAROUTIP";

		// Token: 0x040001E7 RID: 487
		public const string DATAROUTOB = "DATAROUTOB";

		// Token: 0x040001E8 RID: 488
		public const string NETSET_DTRTDEST = "NETSET_DTRTDEST";

		// Token: 0x040001E9 RID: 489
		public const string NETSET_DTRTDESTNETTYPE = "NETSET_DTRTDESTNETTYPE";

		// Token: 0x040001EA RID: 490
		public const string NETSET_BTDTRTUDP = "NETSET_BTDTRTUDP";

		// Token: 0x040001EB RID: 491
		public const string NETSET_BTDTRTIPADDR = "NETSET_BTDTRTIPADDR";

		// Token: 0x040001EC RID: 492
		public const string NETSET_BTDTRTIPADDR0 = "NETSET_BTDTRTIPADDR0";

		// Token: 0x040001ED RID: 493
		public const string NETSET_BTDTRTIPADDR1 = "NETSET_BTDTRTIPADDR1";

		// Token: 0x040001EE RID: 494
		public const string NETSET_BTDTRTIPADDR2 = "NETSET_BTDTRTIPADDR2";

		// Token: 0x040001EF RID: 495
		public const string NETSET_BTDTRTIPADDR3 = "NETSET_BTDTRTIPADDR3";

		// Token: 0x040001F0 RID: 496
		public const string NETSET_USBINDTRTDEST = "NETSET_USBINDTRTDEST";

		// Token: 0x040001F1 RID: 497
		public const string NETSET_USBINDTRTDESTNETTYPE = "NETSET_USBINDTRTDESTNETTYPE";

		// Token: 0x040001F2 RID: 498
		public const string NETSET_USBINDTRTIPADDR = "NETSET_USBINDTRTIPADDR";

		// Token: 0x040001F3 RID: 499
		public const string NETSET_USBINDTRTIPADDR0 = "NETSET_USBINDTRTIPADDR0";

		// Token: 0x040001F4 RID: 500
		public const string NETSET_USBINDTRTIPADDR1 = "NETSET_USBINDTRTIPADDR1";

		// Token: 0x040001F5 RID: 501
		public const string NETSET_USBINDTRTIPADDR2 = "NETSET_USBINDTRTIPADDR2";

		// Token: 0x040001F6 RID: 502
		public const string NETSET_USBINDTRTIPADDR3 = "NETSET_USBINDTRTIPADDR3";

		// Token: 0x040001F7 RID: 503
		public const string NETSET_USBINDTRTUDP = "NETSET_USBINDTRTUDP";

		// Token: 0x040001F8 RID: 504
		public const string NETSET_BTLKIPADDR = "NETSET_BTLKIPADDR";

		// Token: 0x040001F9 RID: 505
		public const string NETSET_BTLKIPADDR0 = "NETSET_BTLKIPADDR0";

		// Token: 0x040001FA RID: 506
		public const string NETSET_BTLKIPADDR1 = "NETSET_BTLKIPADDR1";

		// Token: 0x040001FB RID: 507
		public const string NETSET_BTLKIPADDR2 = "NETSET_BTLKIPADDR2";

		// Token: 0x040001FC RID: 508
		public const string NETSET_BTLKIPADDR3 = "NETSET_BTLKIPADDR3";

		// Token: 0x040001FD RID: 509
		public const string NETSET_BTRMIPADDR = "NETSET_BTRMIPADDR";

		// Token: 0x040001FE RID: 510
		public const string NETSET_BTRMIPADDR0 = "NETSET_BTRMIPADDR0";

		// Token: 0x040001FF RID: 511
		public const string NETSET_BTRMIPADDR1 = "NETSET_BTRMIPADDR1";

		// Token: 0x04000200 RID: 512
		public const string NETSET_BTRMIPADDR2 = "NETSET_BTRMIPADDR2";

		// Token: 0x04000201 RID: 513
		public const string NETSET_BTRMIPADDR3 = "NETSET_BTRMIPADDR3";

		// Token: 0x04000202 RID: 514
		public const string CAI = "CAI";

		// Token: 0x04000203 RID: 515
		public const string PCBT = "PCBT";

		// Token: 0x04000204 RID: 516
		public const string PCUSB = "PCUSB";

		// Token: 0x04000205 RID: 517
		public const string BLUETOOTH = "BLUETOOTH";

		// Token: 0x04000206 RID: 518
		public const string VIAUSB = "VIAUSB";

		// Token: 0x04000207 RID: 519
		public const string VIABLUETOOTH = "VIABLUETOOTH";

		// Token: 0x04000208 RID: 520
		public const string VIANONIP = "VIANONIP";

		// Token: 0x04000209 RID: 521
		public const string RAD_DYN_CMP_TYPE = "RAD_DYN_CMP_TYPE";

		// Token: 0x0400020A RID: 522
		public const string RD_WELCOMESCRNEN = "RD_WELCOMESCRNEN";

		// Token: 0x0400020B RID: 523
		public const string RD_ESCALERTSTATE = "RD_ESCALERTSTATE";

		// Token: 0x0400020C RID: 524
		public const string RD_TXINHIBITEN = "RD_TXINHIBITEN";

		// Token: 0x0400020D RID: 525
		public const string RD_LASTSCAN = "RD_LASTSCAN";

		// Token: 0x0400020E RID: 526
		public const string RD_KEYPADLOCK = "RD_KEYPADLOCK";

		// Token: 0x0400020F RID: 527
		public const string RD_ALRTONEINH = "RD_ALRTONEINH";

		// Token: 0x04000210 RID: 528
		public const string RD_STKYMONITOR = "RD_STKYMONITOR";

		// Token: 0x04000211 RID: 529
		public const string RD_LASTBLSEL = "RD_LASTBLSEL";

		// Token: 0x04000212 RID: 530
		public const string RC_CURVOL = "RC_CURVOL";

		// Token: 0x04000213 RID: 531
		public const string RD_LASTSELPERSIT = "RD_LASTSELPERSIT";

		// Token: 0x04000214 RID: 532
		public const string RD_LASTSELPERSITTYPE = "RD_LASTSELPERSITTYPE";

		// Token: 0x04000215 RID: 533
		public const string RD_LASTSELPERSITID = "RD_LASTSELPERSITID";

		// Token: 0x04000216 RID: 534
		public const string RD_LASTPRIVID = "RD_LASTPRIVID";

		// Token: 0x04000217 RID: 535
		public const string RD_OPBRDFEATSTT = "RD_OPBRDFEATSTT";

		// Token: 0x04000218 RID: 536
		public const string RD_LASTEXALARMSTA = "RD_LASTEXALARMSTA";

		// Token: 0x04000219 RID: 537
		public const string RD_EMRGSQNCENMBR = "RD_EMRGSQNCENMBR";

		// Token: 0x0400021A RID: 538
		public const string RD_LASTPRIVPERSIT = "RD_LASTPRIVPERSIT";

		// Token: 0x0400021B RID: 539
		public const string RD_LASTPRIVPERSITTYPE = "RD_LASTPRIVPERSITTYPE";

		// Token: 0x0400021C RID: 540
		public const string RD_LASTPRIVPERSITID = "RD_LASTPRIVPERSITID";

		// Token: 0x0400021D RID: 541
		public const string RD_LASTACTCHIT = "RD_LASTACTCHIT";

		// Token: 0x0400021E RID: 542
		public const string RD_LASTACTCHITTYPE = "RD_LASTACTCHITTYPE";

		// Token: 0x0400021F RID: 543
		public const string RD_LASTACTCHITID = "RD_LASTACTCHITID";

		// Token: 0x04000220 RID: 544
		public const string RD_MICGAIN = "RD_MICGAIN";

		// Token: 0x04000221 RID: 545
		public const string RD_GPSECEFX = "RD_GPSECEFX";

		// Token: 0x04000222 RID: 546
		public const string RD_GPSECEFY = "RD_GPSECEFY";

		// Token: 0x04000223 RID: 547
		public const string RD_GPSECEFZ = "RD_GPSECEFZ";

		// Token: 0x04000224 RID: 548
		public const string RD_GPCLKOFST = "RD_GPCLKOFST";

		// Token: 0x04000225 RID: 549
		public const string RD_GPSTOW = "RD_GPSTOW";

		// Token: 0x04000226 RID: 550
		public const string RD_GPSCHNLS = "RD_GPSCHNLS";

		// Token: 0x04000227 RID: 551
		public const string RD_GPSWEEKNUM = "RD_GPSWEEKNUM";

		// Token: 0x04000228 RID: 552
		public const string RAD_DISPLAY_CMP_TYPE = "RAD_DISPLAY_CMP_TYPE";

		// Token: 0x04000229 RID: 553
		public const string RDIS_AUTOLITEEN = "RDIS_AUTOLITEEN";

		// Token: 0x0400022A RID: 554
		public const string RDIS_SLOWSCR = "RDIS_SLOWSCR";

		// Token: 0x0400022B RID: 555
		public const string RDIS_FASTSCR = "RDIS_FASTSCR";

		// Token: 0x0400022C RID: 556
		public const string RDIS_SLOWSCOUNT = "RDIS_SLOWSCOUNT";

		// Token: 0x0400022D RID: 557
		public const string RDIS_ALTMRDIS = "RDIS_ALTMRDIS";

		// Token: 0x0400022E RID: 558
		public const string RDIS_TMPMSGDISTMR = "RDIS_TMPMSGDISTMR";

		// Token: 0x0400022F RID: 559
		public const string RDIS_DISLIGHTMR = "RDIS_DISLIGHTMR";

		// Token: 0x04000230 RID: 560
		public const string RDIS_BACKLIGHTONRXOTAEVENT = "RDIS_BACKLIGHTONRXOTAEVENT";

		// Token: 0x04000231 RID: 561
		public const string ZN_PER_ASGN_PREFIX = "ZN_PER_ASGN";

		// Token: 0x04000232 RID: 562
		public const string ZN_PER_ASGN_DLT_TYPE = "ZN_PER_ASGN_DLT_TYPE";

		// Token: 0x04000233 RID: 563
		public const string ZN_PER_ASGN_DLH_TYPE = "ZN_PER_ASGN_DLH_TYPE";

		// Token: 0x04000234 RID: 564
		public const string ZN_PER_ASGN_DLL_TYPE = "ZN_PER_ASGN_DLL_TYPE";

		// Token: 0x04000235 RID: 565
		public const string ZP_LSTCTG = "ZP_LSTCTG";

		// Token: 0x04000236 RID: 566
		public const string ZP_LEDSZ = "ZP_LEDSZ";

		// Token: 0x04000237 RID: 567
		public const string ZP_LEQMAX = "ZP_LEQMAX";

		// Token: 0x04000238 RID: 568
		public const string ZP_LLEQMAX = "ZP_LLEQMAX";

		// Token: 0x04000239 RID: 569
		public const string ZN_PER_ASGN_DLH_TYPE_FTLLISHTYPE = "ZN_PER_ASGN_DLH_TYPE_FTLLISHTYPE";

		// Token: 0x0400023A RID: 570
		public const string ZN_PER_ASGN_DLH_TYPE_FTLLISHID = "ZN_PER_ASGN_DLH_TYPE_FTLLISHID";

		// Token: 0x0400023B RID: 571
		public const string ZP_LLEQ = "ZP_LLEQ";

		// Token: 0x0400023C RID: 572
		public const string ZP_ZONEALIAS = "ZP_ZONEALIAS";

		// Token: 0x0400023D RID: 573
		public const string ZN_PER_ASGN_DLL_TYPE_NTLLISHTYPE = "ZN_PER_ASGN_DLL_TYPE_NTLLISHTYPE";

		// Token: 0x0400023E RID: 574
		public const string ZN_PER_ASGN_DLL_TYPE_NTLLISHID = "ZN_PER_ASGN_DLL_TYPE_NTLLISHID";

		// Token: 0x0400023F RID: 575
		public const string ZP_PERSIT = "ZP_PERSIT";

		// Token: 0x04000240 RID: 576
		public const string ZP_PERSITTYPE = "ZP_PERSITTYPE";

		// Token: 0x04000241 RID: 577
		public const string ZP_PERSITID = "ZP_PERSITID";

		// Token: 0x04000242 RID: 578
		public const string ZP_ZONETYPE = "ZP_ZONETYPE";

		// Token: 0x04000243 RID: 579
		public const string ZP_CBZONE = "ZP_CBZONE";

		// Token: 0x04000244 RID: 580
		public const string ZP_ZI = "ZP_ZI";

		// Token: 0x04000245 RID: 581
		public const string GPS_CONFIG_CMP_TYPE = "GPS_CONFIG_CMP_TYPE";

		// Token: 0x04000246 RID: 582
		public const string GPS_PERUPDINTERVAL = "GPS_PERUPDINTERVAL";

		// Token: 0x04000247 RID: 583
		public const string GPS_LOCUPDDEST = "GPS_LOCUPDDEST";

		// Token: 0x04000248 RID: 584
		public const string GPS_LOCUPDDEST0 = "GPS_LOCUPDDEST0";

		// Token: 0x04000249 RID: 585
		public const string GPS_LOCUPDDEST1 = "GPS_LOCUPDDEST1";

		// Token: 0x0400024A RID: 586
		public const string GPS_LOCUPDDEST2 = "GPS_LOCUPDDEST2";

		// Token: 0x0400024B RID: 587
		public const string GPS_LOCUPDDEST3 = "GPS_LOCUPDDEST3";

		// Token: 0x0400024C RID: 588
		public const string GPS_GPSEN = "GPS_GPSEN";

		// Token: 0x0400024D RID: 589
		public const string GPS_WAITFORACKTMR = "GPS_WAITFORACKTMR";

		// Token: 0x0400024E RID: 590
		public const string GPS_RDTHOT = "GPS_RDTHOT";

		// Token: 0x0400024F RID: 591
		public const string GPSMSG_RHOT = "GPSMSG_RHOT";

		// Token: 0x04000250 RID: 592
		public const string GPS_GPSSTATE = "GPS_GPSSTATE";

		// Token: 0x04000251 RID: 593
		public const string GPS_GLONASSSTATE = "GPS_GLONASSSTATE";

		// Token: 0x04000252 RID: 594
		public const string NA_DMM_BANDIT = "NA_DMM_BANDIT";

		// Token: 0x04000253 RID: 595
		public const string LA_CAPACITY_PLUS_BANDIT = "LA_CAPACITY_PLUS_BANDIT";

		// Token: 0x04000254 RID: 596
		public const string LA_IPSITE_CONNECT_BANDIT = "LA_IPSITE_CONNECT_BANDIT";

		// Token: 0x04000255 RID: 597
		public const string EM_CAPACITY_PLUS_BANDIT = "EM_CAPACITY_PLUS_BANDIT";

		// Token: 0x04000256 RID: 598
		public const string AS_IPSITE_CONNECT_BANDIT = "AS_IPSITE_CONNECT_BANDIT";

		// Token: 0x04000257 RID: 599
		public const string AS_CAPACITY_PLUS_BANDIT = "AS_CAPACITY_PLUS_BANDIT";

		// Token: 0x04000258 RID: 600
		public const string AS_DMM_BANDIT = "AS_DMM_BANDIT";

		// Token: 0x04000259 RID: 601
		public const string BASE_REPEATER_CMP_TYPE = "BASE_REPEATER_CMP_TYPE";

		// Token: 0x0400025A RID: 602
		public const string BR_CWIDEN = "BR_CWIDEN";

		// Token: 0x0400025B RID: 603
		public const string BR_PTTINTEN = "BR_PTTINTEN";

		// Token: 0x0400025C RID: 604
		public const string BR_PLSTRIPEN = "BR_PLSTRIPEN";

		// Token: 0x0400025D RID: 605
		public const string BR_CWIDTXOPT = "BR_CWIDTXOPT";

		// Token: 0x0400025E RID: 606
		public const string BR_CWIDTONEFREQSEL = "BR_CWIDTONEFREQSEL";

		// Token: 0x0400025F RID: 607
		public const string BR_CWIDTXINT = "BR_CWIDTXINT";

		// Token: 0x04000260 RID: 608
		public const string BR_CWID = "BR_CWID";

		// Token: 0x04000261 RID: 609
		public const string BR_OCTONEEN = "BR_OCTONEEN";

		// Token: 0x04000262 RID: 610
		public const string BR_AUDMODE = "BR_AUDMODE";

		// Token: 0x04000263 RID: 611
		public const string BR_CWIDT2TMR = "BR_CWIDT2TMR";

		// Token: 0x04000264 RID: 612
		public const string BR_TWINDOW = "BR_TWINDOW";

		// Token: 0x04000265 RID: 613
		public const string BR_POSTDKTMR = "BR_POSTDKTMR";

		// Token: 0x04000266 RID: 614
		public const string BR_CWIDT3TMR = "BR_CWIDT3TMR";

		// Token: 0x04000267 RID: 615
		public const string BR_CWIDDEV = "BR_CWIDDEV";

		// Token: 0x04000268 RID: 616
		public const string BR_RPTRAUDIOTYPE = "BR_RPTRAUDIOTYPE";

		// Token: 0x04000269 RID: 617
		public const string BR_RPTGNMTPLFTR = "BR_RPTGNMTPLFTR";

		// Token: 0x0400026A RID: 618
		public const string BR_CWIDRATE = "BR_CWIDRATE";

		// Token: 0x0400026B RID: 619
		public const string BR_MJRALRTCNT = "BR_MJRALRTCNT";

		// Token: 0x0400026C RID: 620
		public const string BR_CAPPLUSBEACONDUR = "BR_CAPPLUSBEACONDUR";

		// Token: 0x0400026D RID: 621
		public const string BR_CYPHERCAPPLUSBEACONINTERVAL = "BR_CYPHERCAPPLUSBEACONINTERVAL";

		// Token: 0x0400026E RID: 622
		public const string BR_WL2W4WMODE = "BR_WL2W4WMODE";

		// Token: 0x0400026F RID: 623
		public const string BR_WLREMCONMODE = "BR_WLREMCONMODE";

		// Token: 0x04000270 RID: 624
		public const string BR_WL2REMOTECONTROLMODE = "BR_WL2REMOTECONTROLMODE";

		// Token: 0x04000271 RID: 625
		public const string BR_WLRVRTCI = "BR_WLRVRTCI";

		// Token: 0x04000272 RID: 626
		public const string BR_WLRVRTCIID = "BR_WLRVRTCIID";

		// Token: 0x04000273 RID: 627
		public const string BR_WL2REVERTCHANNELITEMNAME_ITEM = "BR_WL2REVERTCHANNELITEMNAME_ITEM";

		// Token: 0x04000274 RID: 628
		public const string BR_WL2REVERTCHANNELITEMNAME_ITEMID = "BR_WL2REVERTCHANNELITEMNAME_ITEMID";

		// Token: 0x04000275 RID: 629
		public const string BR_WLSTATUSTONE = "BR_WLSTATUSTONE";

		// Token: 0x04000276 RID: 630
		public const string BR_WLRXGUARDTONE = "BR_WLRXGUARDTONE";

		// Token: 0x04000277 RID: 631
		public const string DC = "DC";

		// Token: 0x04000278 RID: 632
		public const string TRC_15FREQUENCE = "TRC_15FREQUENCE";

		// Token: 0x04000279 RID: 633
		public const string TRC_7FREQUENCE = "TRC_7FREQUENCE";

		// Token: 0x0400027A RID: 634
		public const string TRC_FREQUENCE = "TRC_FREQUENCE";

		// Token: 0x0400027B RID: 635
		public const string STR_2WIRE = "STR_2WIRE";

		// Token: 0x0400027C RID: 636
		public const string STR_4WIRE = "STR_4WIRE";

		// Token: 0x0400027D RID: 637
		public const string BR_WLSQHYSTER = "BR_WLSQHYSTER";

		// Token: 0x0400027E RID: 638
		public const string BR_WLTXGUARDTONE = "BR_WLTXGUARDTONE";

		// Token: 0x0400027F RID: 639
		public const string BR_WLHLGTALCMODE = "BR_WLHLGTALCMODE";

		// Token: 0x04000280 RID: 640
		public const string BR_WLMONITORMODE = "BR_WLMONITORMODE";

		// Token: 0x04000281 RID: 641
		public const string BR_WLREPFBTIMER = "BR_WLREPFBTIMER";

		// Token: 0x04000282 RID: 642
		public const string BR_WLPTTDROPOUTTIMER = "BR_WLPTTDROPOUTTIMER";

		// Token: 0x04000283 RID: 643
		public const string BR_WLLINEIMPE = "BR_WLLINEIMPE";

		// Token: 0x04000284 RID: 644
		public const string BR_WLRXSQMODE = "BR_WLRXSQMODE";

		// Token: 0x04000285 RID: 645
		public const string BR_WLRVTCHLNUM = "BR_WLRVTCHLNUM";

		// Token: 0x04000286 RID: 646
		public const string BR_WL2REVERTCHANNELNUMBER = "BR_WL2REVERTCHANNELNUMBER";

		// Token: 0x04000287 RID: 647
		public const string BR_WLTRC7TONEFREQ1FUNCTIONSELECTION = "BR_WLTRC7TONEFREQ1FUNCTIONSELECTION";

		// Token: 0x04000288 RID: 648
		public const string BR_WLTRC7TONEFREQ2FUNCTIONSELECTION = "BR_WLTRC7TONEFREQ2FUNCTIONSELECTION";

		// Token: 0x04000289 RID: 649
		public const string BR_WLTRC7TONEFREQ3FUNCTIONSELECTION = "BR_WLTRC7TONEFREQ3FUNCTIONSELECTION";

		// Token: 0x0400028A RID: 650
		public const string BR_WLTRC7TONEFREQ4FUNCTIONSELECTION = "BR_WLTRC7TONEFREQ4FUNCTIONSELECTION";

		// Token: 0x0400028B RID: 651
		public const string BR_WLTRC7TONEFREQ5FUNCTIONSELECTION = "BR_WLTRC7TONEFREQ5FUNCTIONSELECTION";

		// Token: 0x0400028C RID: 652
		public const string BR_WLTRC7TONEFREQ6FUNCTIONSELECTION = "BR_WLTRC7TONEFREQ6FUNCTIONSELECTION";

		// Token: 0x0400028D RID: 653
		public const string BR_WLTRC7TONEFREQ7FUNCTIONSELECTION = "BR_WLTRC7TONEFREQ7FUNCTIONSELECTION";

		// Token: 0x0400028E RID: 654
		public const string BR_WLTRC7TONEFREQ8FUNCTIONSELECTION = "BR_WLTRC7TONEFREQ8FUNCTIONSELECTION";

		// Token: 0x0400028F RID: 655
		public const string BR_WLTRC7TONEFREQ9FUNCTIONSELECTION = "BR_WLTRC7TONEFREQ9FUNCTIONSELECTION";

		// Token: 0x04000290 RID: 656
		public const string BR_WLTRC7TONEFREQ10FUNCTIONSELECTION = "BR_WLTRC7TONEFREQ10FUNCTIONSELECTION";

		// Token: 0x04000291 RID: 657
		public const string BR_WLTRC7TONEFREQ11FUNCTIONSELECTION = "BR_WLTRC7TONEFREQ11FUNCTIONSELECTION";

		// Token: 0x04000292 RID: 658
		public const string BR_WLTRC7TONEFREQ12FUNCTIONSELECTION = "BR_WLTRC7TONEFREQ12FUNCTIONSELECTION";

		// Token: 0x04000293 RID: 659
		public const string BR_WLTRC7TONEFREQ13FUNCTIONSELECTION = "BR_WLTRC7TONEFREQ13FUNCTIONSELECTION";

		// Token: 0x04000294 RID: 660
		public const string BR_WLTRC7TONEFREQ14FUNCTIONSELECTION = "BR_WLTRC7TONEFREQ14FUNCTIONSELECTION";

		// Token: 0x04000295 RID: 661
		public const string BR_WLTRC7TONEFREQ15FUNCTIONSELECTION = "BR_WLTRC7TONEFREQ15FUNCTIONSELECTION";

		// Token: 0x04000296 RID: 662
		public const string BR_WLTRC7TONEFREQ16FUNCTIONSELECTION = "BR_WLTRC7TONEFREQ16FUNCTIONSELECTION";

		// Token: 0x04000297 RID: 663
		public const string BR_EPRCRPDTREC2 = "BR_EPRCRPDTREC2";

		// Token: 0x04000298 RID: 664
		public const string HIGHIMPEDANCE = "HIGHIMPEDANCE";

		// Token: 0x04000299 RID: 665
		public const string STR800900CP = "STR800900CP";

		// Token: 0x0400029A RID: 666
		public const double DOULE_KHZ5 = 0.005;

		// Token: 0x0400029B RID: 667
		public const double DOUBLE_KHZ6PT25 = 0.00625;

		// Token: 0x0400029C RID: 668
		public const double DOUBLE_kHZ2PT5 = 0.0025;

		// Token: 0x0400029D RID: 669
		public const string CS_WLFPGAVER = "CS_WLFPGAVER";

		// Token: 0x0400029E RID: 670
		public const string CS_CTRLFPGAVER = "CS_CTRLFPGAVER";

		// Token: 0x0400029F RID: 671
		public const string SURC_HWLSPRSSNSTV = "SURC_HWLSPRSSNSTV";

		// Token: 0x040002A0 RID: 672
		public const string SURC_CMP_TYPE = "SURC_CMP_TYPE";

		// Token: 0x040002A1 RID: 673
		public const string SCAN_RAD_CMP_TYPE = "SCAN_RAD_CMP_TYPE";

		// Token: 0x040002A2 RID: 674
		public const string SC_NUIDELEN = "SC_NUIDELEN";

		// Token: 0x040002A3 RID: 675
		public const string SC_PSCANALERTEN = "SC_PSCANALERTEN";

		// Token: 0x040002A4 RID: 676
		public const string SC_PSDEFSIGEN = "SC_PSDEFSIGEN";

		// Token: 0x040002A5 RID: 677
		public const string SC_NUMPRISAM = "SC_NUMPRISAM";

		// Token: 0x040002A6 RID: 678
		public const string SC_OHSUSPSCAN = "SC_OHSUSPSCAN";

		// Token: 0x040002A7 RID: 679
		public const string SC_HANGTIME = "SC_HANGTIME";

		// Token: 0x040002A8 RID: 680
		public const string SC_RADSCANMONHT = "SC_RADSCANMONHT";

		// Token: 0x040002A9 RID: 681
		public const string SC_RADDTCSQ = "SC_RADDTCSQ";

		// Token: 0x040002AA RID: 682
		public const string SC_USERINITSCANRT = "SC_USERINITSCANRT";

		// Token: 0x040002AB RID: 683
		public const string SC_HANGTIME_DIGITAL = "SC_HANGTIME_DIGITAL";

		// Token: 0x040002AC RID: 684
		public const string SC_ALGHANGTIME = "SC_ALGHANGTIME";

		// Token: 0x040002AD RID: 685
		public const string SCAN_PER_DLT_TYPE = "SCAN_PER_DLT_TYPE";

		// Token: 0x040002AE RID: 686
		public const string SCAN_PER_DLH_TYPE = "SCAN_PER_DLH_TYPE";

		// Token: 0x040002AF RID: 687
		public const string SCAN_PER_DLL_TYPE = "SCAN_PER_DLL_TYPE";

		// Token: 0x040002B0 RID: 688
		public const string SP_LSTCTG = "SP_LSTCTG";

		// Token: 0x040002B1 RID: 689
		public const string SP_LEDSZ = "SP_LEDSZ";

		// Token: 0x040002B2 RID: 690
		public const string SP_LEQMAX = "SP_LEQMAX";

		// Token: 0x040002B3 RID: 691
		public const string SP_LLEQMAX = "SP_LLEQMAX";

		// Token: 0x040002B4 RID: 692
		public const string SP_ATACKSC = "SP_ATACKSC";

		// Token: 0x040002B5 RID: 693
		public const string SCAN_PER_DLH_TYPE_FTLLISHTYPE = "SCAN_PER_DLH_TYPE_FTLLISHTYPE";

		// Token: 0x040002B6 RID: 694
		public const string SCAN_PER_DLH_TYPE_FTLLISHID = "SCAN_PER_DLH_TYPE_FTLLISHID";

		// Token: 0x040002B7 RID: 695
		public const string SP_PR1USERPROGEN = "SP_PR1USERPROGEN";

		// Token: 0x040002B8 RID: 696
		public const string SP_PR2USERPROGEN = "SP_PR2USERPROGEN";

		// Token: 0x040002B9 RID: 697
		public const string SP_NONPRIUSERPRGEN = "SP_NONPRIUSERPRGEN";

		// Token: 0x040002BA RID: 698
		public const string SP_SCNLISTYPE = "SP_SCNLISTYPE";

		// Token: 0x040002BB RID: 699
		public const string SP_TLKSCNEN = "SP_TLKSCNEN";

		// Token: 0x040002BC RID: 700
		public const string SP_PLLOCKCHMARKEN = "SP_PLLOCKCHMARKEN";

		// Token: 0x040002BD RID: 701
		public const string SP_SCPLTYPE = "SP_SCPLTYPE";

		// Token: 0x040002BE RID: 702
		public const string SC_SCANSIGHT = "SC_SCANSIGHT";

		// Token: 0x040002BF RID: 703
		public const string SP_SCHSKIPCYCLE = "SP_SCHSKIPCYCLE";

		// Token: 0x040002C0 RID: 704
		public const string SCAN_PER_DLL_TYPE_NTLLISHTYPE = "SCAN_PER_DLL_TYPE_NTLLISHTYPE";

		// Token: 0x040002C1 RID: 705
		public const string SCAN_PER_DLL_TYPE_NTLLISHID = "SCAN_PER_DLL_TYPE_NTLLISHID";

		// Token: 0x040002C2 RID: 706
		public const string SP_LLEQ = "SP_LLEQ";

		// Token: 0x040002C3 RID: 707
		public const string SP_SCANLISTALIAS = "SP_SCANLISTALIAS";

		// Token: 0x040002C4 RID: 708
		public const string SP_CNVPERCOMP = "SP_CNVPERCOMP";

		// Token: 0x040002C5 RID: 709
		public const string SP_CNVPERCOMPTYPE = "SP_CNVPERCOMPTYPE";

		// Token: 0x040002C6 RID: 710
		public const string SP_CNVPERCOMPID = "SP_CNVPERCOMPID";

		// Token: 0x040002C7 RID: 711
		public const string SP_PR1MEM = "SP_PR1MEM";

		// Token: 0x040002C8 RID: 712
		public const string SP_PR1MEMTYPE = "SP_PR1MEMTYPE";

		// Token: 0x040002C9 RID: 713
		public const string SP_PR1MEMID = "SP_PR1MEMID";

		// Token: 0x040002CA RID: 714
		public const string SP_PR2MEM = "SP_PR2MEM";

		// Token: 0x040002CB RID: 715
		public const string SP_PR2MEMTYPE = "SP_PR2MEMTYPE";

		// Token: 0x040002CC RID: 716
		public const string SP_PR2MEMID = "SP_PR2MEMID";

		// Token: 0x040002CD RID: 717
		public const string SP_DSGTXMEM = "SP_DSGTXMEM";

		// Token: 0x040002CE RID: 718
		public const string SP_DSGTXMEMTYPE = "SP_DSGTXMEMTYPE";

		// Token: 0x040002CF RID: 719
		public const string SP_DSGTXMEMID = "SP_DSGTXMEMID";

		// Token: 0x040002D0 RID: 720
		public const string SCAN_RAD_TBPRIOSAMP = "SCAN_RAD_TBPRIOSAMP";

		// Token: 0x040002D1 RID: 721
		public const string ANALOG_UCL_DLT_TYPE = "ANALOG_UCL_DLT_TYPE";

		// Token: 0x040002D2 RID: 722
		public const string ANALOG_UCL_DLH_TYPE = "ANALOG_UCL_DLH_TYPE";

		// Token: 0x040002D3 RID: 723
		public const string ANALOG_UCL_DLL_TYPE = "ANALOG_UCL_DLL_TYPE";

		// Token: 0x040002D4 RID: 724
		public const string AU_LSTCTG = "AU_LSTCTG";

		// Token: 0x040002D5 RID: 725
		public const string AU_LEDSZ = "AU_LEDSZ";

		// Token: 0x040002D6 RID: 726
		public const string AU_LEQMAX = "AU_LEQMAX";

		// Token: 0x040002D7 RID: 727
		public const string AU_LLEQMAX = "AU_LLEQMAX";

		// Token: 0x040002D8 RID: 728
		public const string ANALOG_UCL_DLH_TYPE_FTLLISHTYPE = "ANALOG_UCL_DLH_TYPE_FTLLISHTYPE";

		// Token: 0x040002D9 RID: 729
		public const string ANALOG_UCL_DLH_TYPE_FTLLISHID = "ANALOG_UCL_DLH_TYPE_FTLLISHID";

		// Token: 0x040002DA RID: 730
		public const string ANALOG_UCL_DLL_TYPE_NTLLISHTYPE = "ANALOG_UCL_DLL_TYPE_NTLLISHTYPE";

		// Token: 0x040002DB RID: 731
		public const string ANALOG_UCL_DLL_TYPE_NTLLISHID = "ANALOG_UCL_DLL_TYPE_NTLLISHID";

		// Token: 0x040002DC RID: 732
		public const string AU_LLEQ = "AU_LLEQ";

		// Token: 0x040002DD RID: 733
		public const string AU_ALPHNUMSRCHEN = "AU_ALPHNUMSRCHEN";

		// Token: 0x040002DE RID: 734
		public const string AU_CALLTYPE = "AU_CALLTYPE";

		// Token: 0x040002DF RID: 735
		public const string AU_CALLLSTID = "AU_CALLLSTID";

		// Token: 0x040002E0 RID: 736
		public const string AU_CALLALIAS = "AU_CALLALIAS";

		// Token: 0x040002E1 RID: 737
		public const string AU_MDCSYS = "AU_MDCSYS";

		// Token: 0x040002E2 RID: 738
		public const string AU_MDCSYSTYPE = "AU_MDCSYSTYPE";

		// Token: 0x040002E3 RID: 739
		public const string AU_MDCSYSID = "AU_MDCSYSID";

		// Token: 0x040002E4 RID: 740
		public const string AU_RVRTPERS = "AU_RVRTPERS";

		// Token: 0x040002E5 RID: 741
		public const string AU_RVRTPERSTYPE = "AU_RVRTPERSTYPE";

		// Token: 0x040002E6 RID: 742
		public const string AU_RVRTPERSID = "AU_RVRTPERSID";

		// Token: 0x040002E7 RID: 743
		public const string DIGITAL_UCL_DLT_TYPE = "DIGITAL_UCL_DLT_TYPE";

		// Token: 0x040002E8 RID: 744
		public const string DIGITAL_UCL_DLH_TYPE = "DIGITAL_UCL_DLH_TYPE";

		// Token: 0x040002E9 RID: 745
		public const string DIGITAL_UCL_DLL_TYPE = "DIGITAL_UCL_DLL_TYPE";

		// Token: 0x040002EA RID: 746
		public const string DU_LSTCTG = "DU_LSTCTG";

		// Token: 0x040002EB RID: 747
		public const string DU_LEDSZ = "DU_LEDSZ";

		// Token: 0x040002EC RID: 748
		public const string DU_LEQMAX = "DU_LEQMAX";

		// Token: 0x040002ED RID: 749
		public const string DU_LLEQMAX = "DU_LLEQMAX";

		// Token: 0x040002EE RID: 750
		public const string DIGITAL_UCL_DLH_TYPE_FTLLISHTYPE = "DIGITAL_UCL_DLH_TYPE_FTLLISHTYPE";

		// Token: 0x040002EF RID: 751
		public const string DIGITAL_UCL_DLH_TYPE_FTLLISHID = "DIGITAL_UCL_DLH_TYPE_FTLLISHID";

		// Token: 0x040002F0 RID: 752
		public const string DIGITAL_UCL_DLL_TYPE_NTLLISHTYPE = "DIGITAL_UCL_DLL_TYPE_NTLLISHTYPE";

		// Token: 0x040002F1 RID: 753
		public const string DIGITAL_UCL_DLL_TYPE_NTLLISHID = "DIGITAL_UCL_DLL_TYPE_NTLLISHID";

		// Token: 0x040002F2 RID: 754
		public const string DU_LLEQ = "DU_LLEQ";

		// Token: 0x040002F3 RID: 755
		public const string DU_ALPHNUMSRCHEN = "DU_ALPHNUMSRCHEN";

		// Token: 0x040002F4 RID: 756
		public const string DU_CALLTYPE = "DU_CALLTYPE";

		// Token: 0x040002F5 RID: 757
		public const string DU_CALLTYPEPART1 = "DU_CALLTYPEPART1";

		// Token: 0x040002F6 RID: 758
		public const string DU_CALLTYPEPART2 = "DU_CALLTYPEPART2";

		// Token: 0x040002F7 RID: 759
		public const string DU_CALLLSTID = "DU_CALLLSTID";

		// Token: 0x040002F8 RID: 760
		public const string DU_CALLALIAS = "DU_CALLALIAS";

		// Token: 0x040002F9 RID: 761
		public const string DU_RINGTYPE = "DU_RINGTYPE";

		// Token: 0x040002FA RID: 762
		public const string DU_RVRTPERS = "DU_RVRTPERS";

		// Token: 0x040002FB RID: 763
		public const string DU_RVRTPERSTYPE = "DU_RVRTPERSTYPE";

		// Token: 0x040002FC RID: 764
		public const string DU_RVRTPERSID = "DU_RVRTPERSID";

		// Token: 0x040002FD RID: 765
		public const string DU_UKPOTCFLG = "DU_UKPOTCFLG";

		// Token: 0x040002FE RID: 766
		public const string DU_CALLPRCDTNEN = "DU_CALLPRCDTNEN";

		// Token: 0x040002FF RID: 767
		public const string DU_TXTMSGALTTNTP = "DU_TXTMSGALTTNTP";

		// Token: 0x04000300 RID: 768
		public const string DU_CONNECTTYPE = "DU_CONNECTTYPE";

		// Token: 0x04000301 RID: 769
		public const string DU_ROUTETYPE = "DU_ROUTETYPE";

		// Token: 0x04000302 RID: 770
		public const string ONE_TCH_CALL_CMP_TYPE = "ONE_TCH_CALL_CMP_TYPE";

		// Token: 0x04000303 RID: 771
		public const string OTC_CALLTYPE = "OTC_CALLTYPE";

		// Token: 0x04000304 RID: 772
		public const string OTC_STTMSGONETCHIN = "OTC_STTMSGONETCHIN";

		// Token: 0x04000305 RID: 773
		public const string OTC_UCLITEM = "OTC_UCLITEM";

		// Token: 0x04000306 RID: 774
		public const string OTC_UCLITEMTYPE = "OTC_UCLITEMTYPE";

		// Token: 0x04000307 RID: 775
		public const string OTC_UCLITEMID = "OTC_UCLITEMID";

		// Token: 0x04000308 RID: 776
		public const string OTC_TXTMSGITEM = "OTC_TXTMSGITEM";

		// Token: 0x04000309 RID: 777
		public const string OTC_TXTMSGITEMTYPE = "OTC_TXTMSGITEMTYPE";

		// Token: 0x0400030A RID: 778
		public const string OTC_TXTMSGITEMID = "OTC_TXTMSGITEMID";

		// Token: 0x0400030B RID: 779
		public const string RADIO_PCNV_BTN_CMP_TYPE = "RADIO_PCNV_BTN_CMP_TYPE";

		// Token: 0x0400030C RID: 780
		public const string CBP_TOPBTNBCO = "CBP_TOPBTNBCO";

		// Token: 0x0400030D RID: 781
		public const string CBP_TOPBTNSHORT = "CBP_TOPBTNSHORT";

		// Token: 0x0400030E RID: 782
		public const string CBP_TOPBTNLONG = "CBP_TOPBTNLONG";

		// Token: 0x0400030F RID: 783
		public const string CBP_TOPBTNSHORT_PORT = "CBP_TOPBTNSHORT_PORT";

		// Token: 0x04000310 RID: 784
		public const string CBP_TOPBTNLONG_PORT = "CBP_TOPBTNLONG_PORT";

		// Token: 0x04000311 RID: 785
		public const string CBP_S1BTNBCO = "CBP_S1BTNBCO";

		// Token: 0x04000312 RID: 786
		public const string CBP_S1BTNSHORT = "CBP_S1BTNSHORT";

		// Token: 0x04000313 RID: 787
		public const string CBP_S1BTNLONG = "CBP_S1BTNLONG";

		// Token: 0x04000314 RID: 788
		public const string CBP_S2BTNBCO = "CBP_S2BTNBCO";

		// Token: 0x04000315 RID: 789
		public const string CBP_S2BTNSHORT = "CBP_S2BTNSHORT";

		// Token: 0x04000316 RID: 790
		public const string CBP_S2BTNLONG = "CBP_S2BTNLONG";

		// Token: 0x04000317 RID: 791
		public const string CBP_S3BTNBCO = "CBP_S3BTNBCO";

		// Token: 0x04000318 RID: 792
		public const string CBP_S3BTNSHORT = "CBP_S3BTNSHORT";

		// Token: 0x04000319 RID: 793
		public const string CBP_S3BTNLONG = "CBP_S3BTNLONG";

		// Token: 0x0400031A RID: 794
		public const string CBP_F1BTNBCO = "CBP_F1BTNBCO";

		// Token: 0x0400031B RID: 795
		public const string CBP_F1BTNSHORT = "CBP_F1BTNSHORT";

		// Token: 0x0400031C RID: 796
		public const string CBP_F1BTNLONG = "CBP_F1BTNLONG";

		// Token: 0x0400031D RID: 797
		public const string CBP_F2BTNBCO = "CBP_F2BTNBCO";

		// Token: 0x0400031E RID: 798
		public const string CBP_F2BTNSHORT = "CBP_F2BTNSHORT";

		// Token: 0x0400031F RID: 799
		public const string CBP_F2BTNLONG = "CBP_F2BTNLONG";

		// Token: 0x04000320 RID: 800
		public const string CBP_F1BTNSHORT_PORT = "CBP_F1BTNSHORT_PORT";

		// Token: 0x04000321 RID: 801
		public const string CBP_F1BTNLONG_PORT = "CBP_F1BTNLONG_PORT";

		// Token: 0x04000322 RID: 802
		public const string CBP_F2BTNSHORT_PORT = "CBP_F2BTNSHORT_PORT";

		// Token: 0x04000323 RID: 803
		public const string CBP_F2BTNLONG_PORT = "CBP_F2BTNLONG_PORT";

		// Token: 0x04000324 RID: 804
		public const string CBP_ACCYPLUSBTNBCO = "CBP_ACCYPLUSBTNBCO";

		// Token: 0x04000325 RID: 805
		public const string CBP_ACCYPLUSBTNSHORT = "CBP_ACCYPLUSBTNSHORT";

		// Token: 0x04000326 RID: 806
		public const string CBP_ACCYPLUSBTNLONG = "CBP_ACCYPLUSBTNLONG";

		// Token: 0x04000327 RID: 807
		public const string CBP_ACCYMINUSBTNBCO = "CBP_ACCYMINUSBTNBCO";

		// Token: 0x04000328 RID: 808
		public const string CBP_ACCYMINUSBTNSHORT = "CBP_ACCYMINUSBTNSHORT";

		// Token: 0x04000329 RID: 809
		public const string CBP_ACCYMINUSBTNLONG = "CBP_ACCYMINUSBTNLONG";

		// Token: 0x0400032A RID: 810
		public const string CBP_ACCYP1BTNBCO = "CBP_ACCYP1BTNBCO";

		// Token: 0x0400032B RID: 811
		public const string CBP_ACCYP1BTNSHORT = "CBP_ACCYP1BTNSHORT";

		// Token: 0x0400032C RID: 812
		public const string CBP_ACCYP1BTNLONG = "CBP_ACCYP1BTNLONG";

		// Token: 0x0400032D RID: 813
		public const string CBP_ACCYP2BTNBCO = "CBP_ACCYP2BTNBCO";

		// Token: 0x0400032E RID: 814
		public const string CBP_ACCYP2BTNSHORT = "CBP_ACCYP2BTNSHORT";

		// Token: 0x0400032F RID: 815
		public const string CBP_ACCYP2BTNLONG = "CBP_ACCYP2BTNLONG";

		// Token: 0x04000330 RID: 816
		public const string CBP_ACCYP3BTNBCO = "CBP_ACCYP3BTNBCO";

		// Token: 0x04000331 RID: 817
		public const string CBP_ACCYP3BTNSHORT = "CBP_ACCYP3BTNSHORT";

		// Token: 0x04000332 RID: 818
		public const string CBP_ACCYP3BTNLONG = "CBP_ACCYP3BTNLONG";

		// Token: 0x04000333 RID: 819
		public const string CBP_ACCYP4BTNBCO = "CBP_ACCYP4BTNBCO";

		// Token: 0x04000334 RID: 820
		public const string CBP_ACCYP4BTNSHORT = "CBP_ACCYP4BTNSHORT";

		// Token: 0x04000335 RID: 821
		public const string CBP_ACCYP4BTNLONG = "CBP_ACCYP4BTNLONG";

		// Token: 0x04000336 RID: 822
		public const string CBP_ACCYORGBTNBCO = "CBP_ACCYORGBTNBCO";

		// Token: 0x04000337 RID: 823
		public const string CBP_ACCYORGBTNSHORT = "CBP_ACCYORGBTNSHORT";

		// Token: 0x04000338 RID: 824
		public const string CBP_ACCYORGBTNLONG = "CBP_ACCYORGBTNLONG";

		// Token: 0x04000339 RID: 825
		public const string CBP_ACCY1DOTBTNLONG = "CBP_ACCY1DOTBTNLONG";

		// Token: 0x0400033A RID: 826
		public const string CBP_ACCY1DOTBTNSHORT = "CBP_ACCY1DOTBTNSHORT";

		// Token: 0x0400033B RID: 827
		public const string CBP_ACCY2DOTBTNLONG = "CBP_ACCY2DOTBTNLONG";

		// Token: 0x0400033C RID: 828
		public const string CBP_ACCY2DOTBTNSHORT = "CBP_ACCY2DOTBTNSHORT";

		// Token: 0x0400033D RID: 829
		public const string CBP_ACCYNODOTBTNLONG = "CBP_ACCYNODOTBTNLONG";

		// Token: 0x0400033E RID: 830
		public const string CBP_ACCYNODOTBTNSHORT = "CBP_ACCYNODOTBTNSHORT";

		// Token: 0x0400033F RID: 831
		public const string RADIO_MCNV_BTN_CMP_TYPE = "RADIO_MCNV_BTN_CMP_TYPE";

		// Token: 0x04000340 RID: 832
		public const string CBM_CMP_TYPE = "CBM_CMP_TYPE";

		// Token: 0x04000341 RID: 833
		public const string CBM_P1BTNBCO = "CBM_P1BTNBCO";

		// Token: 0x04000342 RID: 834
		public const string CBM_P1BTNSHORT = "CBM_P1BTNSHORT";

		// Token: 0x04000343 RID: 835
		public const string CBM_P1BTNLONG = "CBM_P1BTNLONG";

		// Token: 0x04000344 RID: 836
		public const string CBM_P2BTNBCO = "CBM_P2BTNBCO";

		// Token: 0x04000345 RID: 837
		public const string CBM_P2BTNSHORT = "CBM_P2BTNSHORT";

		// Token: 0x04000346 RID: 838
		public const string CBM_P2BTNLONG = "CBM_P2BTNLONG";

		// Token: 0x04000347 RID: 839
		public const string CBM_P3BTNBCO = "CBM_P3BTNBCO";

		// Token: 0x04000348 RID: 840
		public const string CBM_P3BTNSHORT = "CBM_P3BTNSHORT";

		// Token: 0x04000349 RID: 841
		public const string CBM_P3BTNLONG = "CBM_P3BTNLONG";

		// Token: 0x0400034A RID: 842
		public const string CBM_P4BTNBCO = "CBM_P4BTNBCO";

		// Token: 0x0400034B RID: 843
		public const string CBM_P4BTNSHORT = "CBM_P4BTNSHORT";

		// Token: 0x0400034C RID: 844
		public const string CBM_P4BTNLONG = "CBM_P4BTNLONG";

		// Token: 0x0400034D RID: 845
		public const string CBM_ACCYPLUSBTNBCO = "CBM_ACCYPLUSBTNBCO";

		// Token: 0x0400034E RID: 846
		public const string CBM_ACCYPLUSBTNSHORT = "CBM_ACCYPLUSBTNSHORT";

		// Token: 0x0400034F RID: 847
		public const string CBM_ACCYPLUSBTNLONG = "CBM_ACCYPLUSBTNLONG";

		// Token: 0x04000350 RID: 848
		public const string CBM_ACCYMINUSBTNBCO = "CBM_ACCYMINUSBTNBCO";

		// Token: 0x04000351 RID: 849
		public const string CBM_ACCYMINUSBTNSHORT = "CBM_ACCYMINUSBTNSHORT";

		// Token: 0x04000352 RID: 850
		public const string CBM_ACCYMINUSBTNLONG = "CBM_ACCYMINUSBTNLONG";

		// Token: 0x04000353 RID: 851
		public const string CBM_ACCYP1BTNBCO = "CBM_ACCYP1BTNBCO";

		// Token: 0x04000354 RID: 852
		public const string CBM_ACCYP1BTNSHORT = "CBM_ACCYP1BTNSHORT";

		// Token: 0x04000355 RID: 853
		public const string CBM_ACCYP1BTNLONG = "CBM_ACCYP1BTNLONG";

		// Token: 0x04000356 RID: 854
		public const string CBM_ACCYP2BTNBCO = "CBM_ACCYP2BTNBCO";

		// Token: 0x04000357 RID: 855
		public const string CBM_ACCYP2BTNSHORT = "CBM_ACCYP2BTNSHORT";

		// Token: 0x04000358 RID: 856
		public const string CBM_ACCYP2BTNLONG = "CBM_ACCYP2BTNLONG";

		// Token: 0x04000359 RID: 857
		public const string CBM_ACCYP3BTNBCO = "CBM_ACCYP3BTNBCO";

		// Token: 0x0400035A RID: 858
		public const string CBM_ACCYP3BTNSHORT = "CBM_ACCYP3BTNSHORT";

		// Token: 0x0400035B RID: 859
		public const string CBM_ACCYP3BTNLONG = "CBM_ACCYP3BTNLONG";

		// Token: 0x0400035C RID: 860
		public const string CBM_ACCYP4BTNBCO = "CBM_ACCYP4BTNBCO";

		// Token: 0x0400035D RID: 861
		public const string CBM_ACCYP4BTNSHORT = "CBM_ACCYP4BTNSHORT";

		// Token: 0x0400035E RID: 862
		public const string CBM_ACCYP4BTNLONG = "CBM_ACCYP4BTNLONG";

		// Token: 0x0400035F RID: 863
		public const string CBM_ACCYNODOTBTNBCO = "CBM_ACCYNODOTBTNBCO";

		// Token: 0x04000360 RID: 864
		public const string CBM_ACCYNODOTBTNSHORT = "CBM_ACCYNODOTBTNSHORT";

		// Token: 0x04000361 RID: 865
		public const string CBM_ACCYNODOTBTNLONG = "CBM_ACCYNODOTBTNLONG";

		// Token: 0x04000362 RID: 866
		public const string CBM_ACCY1DOTBTNBCO = "CBM_ACCY1DOTBTNBCO";

		// Token: 0x04000363 RID: 867
		public const string CBM_ACCY1DOTBTNSHORT = "CBM_ACCY1DOTBTNSHORT";

		// Token: 0x04000364 RID: 868
		public const string CBM_ACCY1DOTBTNLONG = "CBM_ACCY1DOTBTNLONG";

		// Token: 0x04000365 RID: 869
		public const string CBM_ACCY2DOTBTNBCO = "CBM_ACCY2DOTBTNBCO";

		// Token: 0x04000366 RID: 870
		public const string CBM_ACCY2DOTBTNSHORT = "CBM_ACCY2DOTBTNSHORT";

		// Token: 0x04000367 RID: 871
		public const string CBM_ACCY2DOTBTNLONG = "CBM_ACCY2DOTBTNLONG";

		// Token: 0x04000368 RID: 872
		public const string CBM_ACCYNODOTBTNSHORT_TAHITI = "CBM_ACCYNODOTBTNSHORT_TAHITI";

		// Token: 0x04000369 RID: 873
		public const string CBM_ACCYNODOTBTNLONG_TAHITI = "CBM_ACCYNODOTBTNLONG_TAHITI";

		// Token: 0x0400036A RID: 874
		public const string CBM_ACCY1DOTBTNSHORT_TAHITI = "CBM_ACCY1DOTBTNSHORT_TAHITI";

		// Token: 0x0400036B RID: 875
		public const string CBM_ACCY1DOTBTNLONG_TAHITI = "CBM_ACCY1DOTBTNLONG_TAHITI";

		// Token: 0x0400036C RID: 876
		public const string CBM_ACCY2DOTBTNSHORT_TAHITI = "CBM_ACCY2DOTBTNSHORT_TAHITI";

		// Token: 0x0400036D RID: 877
		public const string CBM_ACCY2DOTBTNLONG_TAHITI = "CBM_ACCY2DOTBTNLONG_TAHITI";

		// Token: 0x0400036E RID: 878
		public const string TRK_BTN_P_CMP_TYPE = "TRK_BTN_P_CMP_TYPE";

		// Token: 0x0400036F RID: 879
		public const string TBP_TOPBTNBCO = "TBP_TOPBTNBCO";

		// Token: 0x04000370 RID: 880
		public const string TBP_TOPBTNSHORT = "TBP_TOPBTNSHORT";

		// Token: 0x04000371 RID: 881
		public const string TBP_TOPBTNLONG = "TBP_TOPBTNLONG";

		// Token: 0x04000372 RID: 882
		public const string TBP_S1BTNBCO = "TBP_S1BTNBCO";

		// Token: 0x04000373 RID: 883
		public const string TBP_S1BTNSHORT = "TBP_S1BTNSHORT";

		// Token: 0x04000374 RID: 884
		public const string TBP_S1BTNLONG = "TBP_S1BTNLONG";

		// Token: 0x04000375 RID: 885
		public const string TBP_S2BTNBCO = "TBP_S2BTNBCO";

		// Token: 0x04000376 RID: 886
		public const string TBP_S2BTNSHORT = "TBP_S2BTNSHORT";

		// Token: 0x04000377 RID: 887
		public const string TBP_S2BTNLONG = "TBP_S2BTNLONG";

		// Token: 0x04000378 RID: 888
		public const string TBP_S3BTNBCO = "TBP_S3BTNBCO";

		// Token: 0x04000379 RID: 889
		public const string TBP_S3BTNSHORT = "TBP_S3BTNSHORT";

		// Token: 0x0400037A RID: 890
		public const string TBP_S3BTNLONG = "TBP_S3BTNLONG";

		// Token: 0x0400037B RID: 891
		public const string TBP_F1BTNBCO = "TBP_F1BTNBCO";

		// Token: 0x0400037C RID: 892
		public const string TBP_F1BTNSHORT = "TBP_F1BTNSHORT";

		// Token: 0x0400037D RID: 893
		public const string TBP_F1BTNLONG = "TBP_F1BTNLONG";

		// Token: 0x0400037E RID: 894
		public const string TBP_F2BTNBCO = "TBP_F2BTNBCO";

		// Token: 0x0400037F RID: 895
		public const string TBP_F2BTNSHORT = "TBP_F2BTNSHORT";

		// Token: 0x04000380 RID: 896
		public const string TBP_F2BTNLONG = "TBP_F2BTNLONG";

		// Token: 0x04000381 RID: 897
		public const string TBP_ACCYPLUSBTNBCO = "TBP_ACCYPLUSBTNBCO";

		// Token: 0x04000382 RID: 898
		public const string TBP_ACCYPLUSBTNSHORT = "TBP_ACCYPLUSBTNSHORT";

		// Token: 0x04000383 RID: 899
		public const string TBP_ACCYPLUSBTNLONG = "TBP_ACCYPLUSBTNLONG";

		// Token: 0x04000384 RID: 900
		public const string TBP_ACCYMINUSBTNBCO = "TBP_ACCYMINUSBTNBCO";

		// Token: 0x04000385 RID: 901
		public const string TBP_ACCYMINUSBTNSHORT = "TBP_ACCYMINUSBTNSHORT";

		// Token: 0x04000386 RID: 902
		public const string TBP_ACCYMINUSBTNLONG = "TBP_ACCYMINUSBTNLONG";

		// Token: 0x04000387 RID: 903
		public const string TBP_ACCYP1BTNBCO = "TBP_ACCYP1BTNBCO";

		// Token: 0x04000388 RID: 904
		public const string TBP_ACCYP1BTNSHORT = "TBP_ACCYP1BTNSHORT";

		// Token: 0x04000389 RID: 905
		public const string TBP_ACCYP1BTNLONG = "TBP_ACCYP1BTNLONG";

		// Token: 0x0400038A RID: 906
		public const string TBP_ACCYP2BTNBCO = "TBP_ACCYP2BTNBCO";

		// Token: 0x0400038B RID: 907
		public const string TBP_ACCYP2BTNSHORT = "TBP_ACCYP2BTNSHORT";

		// Token: 0x0400038C RID: 908
		public const string TBP_ACCYP2BTNLONG = "TBP_ACCYP2BTNLONG";

		// Token: 0x0400038D RID: 909
		public const string TBP_ACCYP3BTNBCO = "TBP_ACCYP3BTNBCO";

		// Token: 0x0400038E RID: 910
		public const string TBP_ACCYP3BTNSHORT = "TBP_ACCYP3BTNSHORT";

		// Token: 0x0400038F RID: 911
		public const string TBP_ACCYP3BTNLONG = "TBP_ACCYP3BTNLONG";

		// Token: 0x04000390 RID: 912
		public const string TBP_ACCYP4BTNBCO = "TBP_ACCYP4BTNBCO";

		// Token: 0x04000391 RID: 913
		public const string TBP_ACCYP4BTNSHORT = "TBP_ACCYP4BTNSHORT";

		// Token: 0x04000392 RID: 914
		public const string TBP_ACCYP4BTNLONG = "TBP_ACCYP4BTNLONG";

		// Token: 0x04000393 RID: 915
		public const string TBP_ACCYORGBTNBCO = "TBP_ACCYORGBTNBCO";

		// Token: 0x04000394 RID: 916
		public const string TBP_ACCYORGBTNSHORT = "TBP_ACCYORGBTNSHORT";

		// Token: 0x04000395 RID: 917
		public const string TBP_ACCYORGBTNLONG = "TBP_ACCYORGBTNLONG";

		// Token: 0x04000396 RID: 918
		public const string TBP_ACCY1DOTBTNLONG = "TBP_ACCY1DOTBTNLONG";

		// Token: 0x04000397 RID: 919
		public const string TBP_ACCY1DOTBTNSHORT = "TBP_ACCY1DOTBTNSHORT";

		// Token: 0x04000398 RID: 920
		public const string TBP_ACCY2DOTBTNLONG = "TBP_ACCY2DOTBTNLONG";

		// Token: 0x04000399 RID: 921
		public const string TBP_ACCY2DOTBTNSHORT = "TBP_ACCY2DOTBTNSHORT";

		// Token: 0x0400039A RID: 922
		public const string TBP_ACCYNODOTBTNLONG = "TBP_ACCYNODOTBTNLONG";

		// Token: 0x0400039B RID: 923
		public const string TBP_ACCYNODOTBTNSHORT = "TBP_ACCYNODOTBTNSHORT";

		// Token: 0x0400039C RID: 924
		public const string TRK_BTN_M_CMP_TYPE = "TRK_BTN_M_CMP_TYPE";

		// Token: 0x0400039D RID: 925
		public const string TBM_P1BTNBCO = "TBM_P1BTNBCO";

		// Token: 0x0400039E RID: 926
		public const string TBM_P1BTNSHORT = "TBM_P1BTNSHORT";

		// Token: 0x0400039F RID: 927
		public const string TBM_P1BTNLONG = "TBM_P1BTNLONG";

		// Token: 0x040003A0 RID: 928
		public const string TBM_P2BTNBCO = "TBM_P2BTNBCO";

		// Token: 0x040003A1 RID: 929
		public const string TBM_P2BTNSHORT = "TBM_P2BTNSHORT";

		// Token: 0x040003A2 RID: 930
		public const string TBM_P2BTNLONG = "TBM_P2BTNLONG";

		// Token: 0x040003A3 RID: 931
		public const string TBM_P3BTNBCO = "TBM_P3BTNBCO";

		// Token: 0x040003A4 RID: 932
		public const string TBM_P3BTNSHORT = "TBM_P3BTNSHORT";

		// Token: 0x040003A5 RID: 933
		public const string TBM_P3BTNLONG = "TBM_P3BTNLONG";

		// Token: 0x040003A6 RID: 934
		public const string TBM_P4BTNBCO = "TBM_P4BTNBCO";

		// Token: 0x040003A7 RID: 935
		public const string TBM_P4BTNSHORT = "TBM_P4BTNSHORT";

		// Token: 0x040003A8 RID: 936
		public const string TBM_P4BTNLONG = "TBM_P4BTNLONG";

		// Token: 0x040003A9 RID: 937
		public const string TBM_ACCYPLUSBTNBCO = "TBM_ACCYPLUSBTNBCO";

		// Token: 0x040003AA RID: 938
		public const string TBM_ACCYPLUSBTNSHORT = "TBM_ACCYPLUSBTNSHORT";

		// Token: 0x040003AB RID: 939
		public const string TBM_ACCYPLUSBTNLONG = "TBM_ACCYPLUSBTNLONG";

		// Token: 0x040003AC RID: 940
		public const string TBM_ACCYMINUSBTNBCO = "TBM_ACCYMINUSBTNBCO";

		// Token: 0x040003AD RID: 941
		public const string TBM_ACCYMINUSBTNSHORT = "TBM_ACCYMINUSBTNSHORT";

		// Token: 0x040003AE RID: 942
		public const string TBM_ACCYMINUSBTNLONG = "TBM_ACCYMINUSBTNLONG";

		// Token: 0x040003AF RID: 943
		public const string TBM_ACCYP1BTNBCO = "TBM_ACCYP1BTNBCO";

		// Token: 0x040003B0 RID: 944
		public const string TBM_ACCYP1BTNSHORT = "TBM_ACCYP1BTNSHORT";

		// Token: 0x040003B1 RID: 945
		public const string TBM_ACCYP1BTNLONG = "TBM_ACCYP1BTNLONG";

		// Token: 0x040003B2 RID: 946
		public const string TBM_ACCYP2BTNBCO = "TBM_ACCYP2BTNBCO";

		// Token: 0x040003B3 RID: 947
		public const string TBM_ACCYP2BTNSHORT = "TBM_ACCYP2BTNSHORT";

		// Token: 0x040003B4 RID: 948
		public const string TBM_ACCYP2BTNLONG = "TBM_ACCYP2BTNLONG";

		// Token: 0x040003B5 RID: 949
		public const string TBM_ACCYP3BTNBCO = "TBM_ACCYP3BTNBCO";

		// Token: 0x040003B6 RID: 950
		public const string TBM_ACCYP3BTNSHORT = "TBM_ACCYP3BTNSHORT";

		// Token: 0x040003B7 RID: 951
		public const string TBM_ACCYP3BTNLONG = "TBM_ACCYP3BTNLONG";

		// Token: 0x040003B8 RID: 952
		public const string TBM_ACCYP4BTNBCO = "TBM_ACCYP4BTNBCO";

		// Token: 0x040003B9 RID: 953
		public const string TBM_ACCYP4BTNSHORT = "TBM_ACCYP4BTNSHORT";

		// Token: 0x040003BA RID: 954
		public const string TBM_ACCYP4BTNLONG = "TBM_ACCYP4BTNLONG";

		// Token: 0x040003BB RID: 955
		public const string TBM_ACCYNODOTBTNBCO = "TBM_ACCYNODOTBTNBCO";

		// Token: 0x040003BC RID: 956
		public const string TBM_ACCYNODOTBTNSHORT = "TBM_ACCYNODOTBTNSHORT";

		// Token: 0x040003BD RID: 957
		public const string TBM_ACCYNODOTBTNLONG = "TBM_ACCYNODOTBTNLONG";

		// Token: 0x040003BE RID: 958
		public const string TBM_ACCY1DOTBTNBCO = "TBM_ACCY1DOTBTNBCO";

		// Token: 0x040003BF RID: 959
		public const string TBM_ACCY1DOTBTNSHORT = "TBM_ACCY1DOTBTNSHORT";

		// Token: 0x040003C0 RID: 960
		public const string TBM_ACCY1DOTBTNLONG = "TBM_ACCY1DOTBTNLONG";

		// Token: 0x040003C1 RID: 961
		public const string TBM_ACCY2DOTBTNBCO = "TBM_ACCY2DOTBTNBCO";

		// Token: 0x040003C2 RID: 962
		public const string TBM_ACCY2DOTBTNSHORT = "TBM_ACCY2DOTBTNSHORT";

		// Token: 0x040003C3 RID: 963
		public const string TBM_ACCY2DOTBTNLONG = "TBM_ACCY2DOTBTNLONG";

		// Token: 0x040003C4 RID: 964
		public const string LONG = "LONG";

		// Token: 0x040003C5 RID: 965
		public const string RADIO_GLB_BTN_CMP_TYPE = "RADIO_GLB_BTN_CMP_TYPE";

		// Token: 0x040003C6 RID: 966
		public const string GLB_PWRBTNBC = "GLB_PWRBTNBC";

		// Token: 0x040003C7 RID: 967
		public const string GLB_PWRBTNCPV = "GLB_PWRBTNCPV";

		// Token: 0x040003C8 RID: 968
		public const string GLB_PTTBTNBCO = "GLB_PTTBTNBCO";

		// Token: 0x040003C9 RID: 969
		public const string GLB_PTTBTNCPV = "GLB_PTTBTNCPV";

		// Token: 0x040003CA RID: 970
		public const string GLB_VOLBTNBCO = "GLB_VOLBTNBCO";

		// Token: 0x040003CB RID: 971
		public const string GLB_VOLBTNCPV = "GLB_VOLBTNCPV";

		// Token: 0x040003CC RID: 972
		public const string GLB_ROTARYBTNBCO = "GLB_ROTARYBTNBCO";

		// Token: 0x040003CD RID: 973
		public const string GLB_ROTARYBTNCPV = "GLB_ROTARYBTNCPV";

		// Token: 0x040003CE RID: 974
		public const string GLB_HUBBCO = "GLB_HUBBCO";

		// Token: 0x040003CF RID: 975
		public const string GLB_HUBCPV = "GLB_HUBCPV";

		// Token: 0x040003D0 RID: 976
		public const string GLB_IGNITBCO = "GLB_IGNITBCO";

		// Token: 0x040003D1 RID: 977
		public const string GLB_IGNITCPV = "GLB_IGNITCPV";

		// Token: 0x040003D2 RID: 978
		public const string GLB_CHUPBTNBCO = "GLB_CHUPBTNBCO";

		// Token: 0x040003D3 RID: 979
		public const string GLB_CHUPBTNCPV = "GLB_CHUPBTNCPV";

		// Token: 0x040003D4 RID: 980
		public const string GLB_CHDOWNBTNBCO = "GLB_CHDOWNBTNBCO";

		// Token: 0x040003D5 RID: 981
		public const string GLB_CHDOWNCPV = "GLB_CHDOWNCPV";

		// Token: 0x040003D6 RID: 982
		public const string GLB_LNAVBTNBCO = "GLB_LNAVBTNBCO";

		// Token: 0x040003D7 RID: 983
		public const string GLB_LNAVBTNCPV = "GLB_LNAVBTNCPV";

		// Token: 0x040003D8 RID: 984
		public const string GLB_RNAVBTNBCO = "GLB_RNAVBTNBCO";

		// Token: 0x040003D9 RID: 985
		public const string GLB_RNAVBTNCPV = "GLB_RNAVBTNCPV";

		// Token: 0x040003DA RID: 986
		public const string GLB_OKBTNBCO = "GLB_OKBTNBCO";

		// Token: 0x040003DB RID: 987
		public const string GLB_OKBTNCPV = "GLB_OKBTNCPV";

		// Token: 0x040003DC RID: 988
		public const string GLB_MENUBTNBCO = "GLB_MENUBTNBCO";

		// Token: 0x040003DD RID: 989
		public const string GLB_MENUBTNCPV = "GLB_MENUBTNCPV";

		// Token: 0x040003DE RID: 990
		public const string GLB_BACKBTNBCO = "GLB_BACKBTNBCO";

		// Token: 0x040003DF RID: 991
		public const string GLB_BACKBTNCPV = "GLB_BACKBTNCPV";

		// Token: 0x040003E0 RID: 992
		public const string GLB_KP0BCO = "GLB_KP0BCO";

		// Token: 0x040003E1 RID: 993
		public const string GLB_KP0CPV = "GLB_KP0CPV";

		// Token: 0x040003E2 RID: 994
		public const string GLB_KP1BCO = "GLB_KP1BCO";

		// Token: 0x040003E3 RID: 995
		public const string GLB_KP1CPV = "GLB_KP1CPV";

		// Token: 0x040003E4 RID: 996
		public const string GLB_KP2BCO = "GLB_KP2BCO";

		// Token: 0x040003E5 RID: 997
		public const string GLB_KP2CPV = "GLB_KP2CPV";

		// Token: 0x040003E6 RID: 998
		public const string GLB_KP3BCO = "GLB_KP3BCO";

		// Token: 0x040003E7 RID: 999
		public const string GLB_KP3CPV = "GLB_KP3CPV";

		// Token: 0x040003E8 RID: 1000
		public const string GLB_KP4BCO = "GLB_KP4BCO";

		// Token: 0x040003E9 RID: 1001
		public const string GLB_KP4CPV = "GLB_KP4CPV";

		// Token: 0x040003EA RID: 1002
		public const string GLB_KP5BCO = "GLB_KP5BCO";

		// Token: 0x040003EB RID: 1003
		public const string GLB_KP5CPV = "GLB_KP5CPV";

		// Token: 0x040003EC RID: 1004
		public const string GLB_KP6BC = "GLB_KP6BC";

		// Token: 0x040003ED RID: 1005
		public const string GLB_KP6CPV = "GLB_KP6CPV";

		// Token: 0x040003EE RID: 1006
		public const string GLB_KP7BCO = "GLB_KP7BCO";

		// Token: 0x040003EF RID: 1007
		public const string GLB_KP7CPV = "GLB_KP7CPV";

		// Token: 0x040003F0 RID: 1008
		public const string GLB_KP8BCO = "GLB_KP8BCO";

		// Token: 0x040003F1 RID: 1009
		public const string GLB_KP8CPV = "GLB_KP8CPV";

		// Token: 0x040003F2 RID: 1010
		public const string GLB_KP9BCO = "GLB_KP9BCO";

		// Token: 0x040003F3 RID: 1011
		public const string GLB_KP9CPV = "GLB_KP9CPV";

		// Token: 0x040003F4 RID: 1012
		public const string GLB_KPASTBCO = "GLB_KPASTBCO";

		// Token: 0x040003F5 RID: 1013
		public const string GLB_KPASTCPV = "GLB_KPASTCPV";

		// Token: 0x040003F6 RID: 1014
		public const string GLB_KPPNTBCO = "GLB_KPPNTBCO";

		// Token: 0x040003F7 RID: 1015
		public const string GLB_KPPNTCPV = "GLB_KPPNTCPV";

		// Token: 0x040003F8 RID: 1016
		public const string GLB_EMGFTSWTBCO = "GLB_EMGFTSWTBCO";

		// Token: 0x040003F9 RID: 1017
		public const string GLB_EMGFTSWTCPV = "GLB_EMGFTSWTCPV";

		// Token: 0x040003FA RID: 1018
		public const string RAD_MENU_CMP_TYPE = "RAD_MENU_CMP_TYPE";

		// Token: 0x040003FB RID: 1019
		public const string MENU_HANGTMR = "MENU_HANGTMR";

		// Token: 0x040003FC RID: 1020
		public const string MENU_HANGTM = "MENU_HANGTM";

		// Token: 0x040003FD RID: 1021
		public const string MENU_FIRITEMTONEEN = "MENU_FIRITEMTONEEN";

		// Token: 0x040003FE RID: 1022
		public const string MENU_RESELEN = "MENU_RESELEN";

		// Token: 0x040003FF RID: 1023
		public const string MENU_LASTSELMM = "MENU_LASTSELMM";

		// Token: 0x04000400 RID: 1024
		public const string MENU_CONTACTS = "MENU_CONTACTS";

		// Token: 0x04000401 RID: 1025
		public const string MENU_SCAN = "MENU_SCAN";

		// Token: 0x04000402 RID: 1026
		public const string MENU_ZONE = "MENU_ZONE";

		// Token: 0x04000403 RID: 1027
		public const string MENU_MSG = "MENU_MSG";

		// Token: 0x04000404 RID: 1028
		public const string MENU_SETTING = "MENU_SETTING";

		// Token: 0x04000405 RID: 1029
		public const string MENU_CALLLOG = "MENU_CALLLOG";

		// Token: 0x04000406 RID: 1030
		public const string MENU_VIEWNUMSUB = "MENU_VIEWNUMSUB";

		// Token: 0x04000407 RID: 1031
		public const string MENU_EDITNASUB = "MENU_EDITNASUB";

		// Token: 0x04000408 RID: 1032
		public const string MENU_EDITNUMSUB = "MENU_EDITNUMSUB";

		// Token: 0x04000409 RID: 1033
		public const string MENU_RSTYLESUB = "MENU_RSTYLESUB";

		// Token: 0x0400040A RID: 1034
		public const string MENU_DELSUB = "MENU_DELSUB";

		// Token: 0x0400040B RID: 1035
		public const string MENU_CHPOSSUB = "MENU_CHPOSSUB";

		// Token: 0x0400040C RID: 1036
		public const string MENU_NEWCTTSUB = "MENU_NEWCTTSUB";

		// Token: 0x0400040D RID: 1037
		public const string MENU_MDIALSUB = "MENU_MDIALSUB";

		// Token: 0x0400040E RID: 1038
		public const string MENU_PCMANDIAL = "MENU_PCMANDIAL";

		// Token: 0x0400040F RID: 1039
		public const string MENU_GCMANDIAL = "MENU_GCMANDIAL";

		// Token: 0x04000410 RID: 1040
		public const string MENU_SCANONOFFSUB = "MENU_SCANONOFFSUB";

		// Token: 0x04000411 RID: 1041
		public const string MENU_EDITLSTSUB = "MENU_EDITLSTSUB";

		// Token: 0x04000412 RID: 1042
		public const string MENU_NEWLSTSUB = "MENU_NEWLSTSUB";

		// Token: 0x04000413 RID: 1043
		public const string MENU_NEWMEMSUB = "MENU_NEWMEMSUB";

		// Token: 0x04000414 RID: 1044
		public const string MENU_RESTORESUB = "MENU_RESTORESUB";

		// Token: 0x04000415 RID: 1045
		public const string MENU_VIEWLSTSUB = "MENU_VIEWLSTSUB";

		// Token: 0x04000416 RID: 1046
		public const string MENU_PRISUB = "MENU_PRISUB";

		// Token: 0x04000417 RID: 1047
		public const string MENU_WRITESUB = "MENU_WRITESUB";

		// Token: 0x04000418 RID: 1048
		public const string MENU_QTEXTSUB = "MENU_QTEXTSUB";

		// Token: 0x04000419 RID: 1049
		public const string MENU_MISSEDSUB = "MENU_MISSEDSUB";

		// Token: 0x0400041A RID: 1050
		public const string MENU_INSUB = "MENU_INSUB";

		// Token: 0x0400041B RID: 1051
		public const string MENU_OUTSUB = "MENU_OUTSUB";

		// Token: 0x0400041C RID: 1052
		public const string MENU_RSSUB = "MENU_RSSUB";

		// Token: 0x0400041D RID: 1053
		public const string MENU_COMPSUB = "MENU_COMPSUB";

		// Token: 0x0400041E RID: 1054
		public const string MENU_OBSUB = "MENU_OBSUB";

		// Token: 0x0400041F RID: 1055
		public const string MENU_POWERSUB = "MENU_POWERSUB";

		// Token: 0x04000420 RID: 1056
		public const string MENU_AUTOBLSUB = "MENU_AUTOBLSUB";

		// Token: 0x04000421 RID: 1057
		public const string MENU_SQUSUB = "MENU_SQUSUB";

		// Token: 0x04000422 RID: 1058
		public const string MENU_WELSCRSUB = "MENU_WELSCRSUB";

		// Token: 0x04000423 RID: 1059
		public const string MENU_KPLOCKSUB = "MENU_KPLOCKSUB";

		// Token: 0x04000424 RID: 1060
		public const string MENU_LANSUB = "MENU_LANSUB";

		// Token: 0x04000425 RID: 1061
		public const string MENU_LEDINDSUB = "MENU_LEDINDSUB";

		// Token: 0x04000426 RID: 1062
		public const string MENU_VOXSUB = "MENU_VOXSUB";

		// Token: 0x04000427 RID: 1063
		public const string MENU_VOPSUB = "MENU_VOPSUB";

		// Token: 0x04000428 RID: 1064
		public const string MENU_ACCVLSUB = "MENU_ACCVLSUB";

		// Token: 0x04000429 RID: 1065
		public const string MENU_TONEALTSUB = "MENU_TONEALTSUB";

		// Token: 0x0400042A RID: 1066
		public const string MENU_ALLTONESUB = "MENU_ALLTONESUB";

		// Token: 0x0400042B RID: 1067
		public const string MENU_TPTSUB = "MENU_TPTSUB";

		// Token: 0x0400042C RID: 1068
		public const string MENU_CALLRINGSUB = "MENU_CALLRINGSUB";

		// Token: 0x0400042D RID: 1069
		public const string MENU_KPTONESUB = "MENU_KPTONESUB";

		// Token: 0x0400042E RID: 1070
		public const string MENU_MYNUMSUB = "MENU_MYNUMSUB";

		// Token: 0x0400042F RID: 1071
		public const string MENU_RADINFOSUB = "MENU_RADINFOSUB";

		// Token: 0x04000430 RID: 1072
		public const string MENU_BATINFOSUB = "MENU_BATINFOSUB";

		// Token: 0x04000431 RID: 1073
		public const string MENU_FWVERSUB = "MENU_FWVERSUB";

		// Token: 0x04000432 RID: 1074
		public const string MENU_SWVERSUB = "MENU_SWVERSUB";

		// Token: 0x04000433 RID: 1075
		public const string MENU_UTILITIES = "MENU_UTILITIES";

		// Token: 0x04000434 RID: 1076
		public const string MENU_CALLALTSUB = "MENU_CALLALTSUB";

		// Token: 0x04000435 RID: 1077
		public const string MENU_EDITENTRY = "MENU_EDITENTRY";

		// Token: 0x04000436 RID: 1078
		public const string MENU_RADDISSUB = "MENU_RADDISSUB";

		// Token: 0x04000437 RID: 1079
		public const string MENU_RADENSUB = "MENU_RADENSUB";

		// Token: 0x04000438 RID: 1080
		public const string MENU_RADCHKSUB = "MENU_RADCHKSUB";

		// Token: 0x04000439 RID: 1081
		public const string MENU_ANSWSUB = "MENU_ANSWSUB";

		// Token: 0x0400043A RID: 1082
		public const string MENU_GPSSTATESUB = "MENU_GPSSTATESUB";

		// Token: 0x0400043B RID: 1083
		public const string MENU_TKRNDSUB = "MENU_TKRNDSUB";

		// Token: 0x0400043C RID: 1084
		public const string MENU_RMTMOTSUB = "MENU_RMTMOTSUB";

		// Token: 0x0400043D RID: 1085
		public const string MENU_HORNLGTSUB = "MENU_HORNLGTSUB";

		// Token: 0x0400043E RID: 1086
		public const string MENU_PRSVC = "MENU_PRSVC";

		// Token: 0x0400043F RID: 1087
		public const string MENU_MSGSUB = "MENU_MSGSUB";

		// Token: 0x04000440 RID: 1088
		public const string MENU_STATUSSUB = "MENU_STATUSSUB";

		// Token: 0x04000441 RID: 1089
		public const string MENU_MESSAGE = "MENU_MESSAGE";

		// Token: 0x04000442 RID: 1090
		public const string MENU_JBTKTMMNAME = "MENU_JBTKTMMNAME";

		// Token: 0x04000443 RID: 1091
		public const string MENU_JBTKTSTLBNAME = "MENU_JBTKTSTLBNAME";

		// Token: 0x04000444 RID: 1092
		public const string MENU_TXTMSGALTSUB = "MENU_TXTMSGALTSUB";

		// Token: 0x04000445 RID: 1093
		public const string MENU_5TSUIDSUB = "MENU_5TSUIDSUB";

		// Token: 0x04000446 RID: 1094
		public const string MENU_QCKDLSUB = "MENU_QCKDLSUB";

		// Token: 0x04000447 RID: 1095
		public const string MENU_EDZONESUB = "MENU_EDZONESUB";

		// Token: 0x04000448 RID: 1096
		public const string MENU_MICGAINSUB = "MENU_MICGAINSUB";

		// Token: 0x04000449 RID: 1097
		public const string TXT_MSG_CMP_TYPE = "TXT_MSG_CMP_TYPE";

		// Token: 0x0400044A RID: 1098
		public const string CTMSG_TXTMSGEN = "CTMSG_TXTMSGEN";

		// Token: 0x0400044B RID: 1099
		public const string CTMSG_OWRTOLDMSG = "CTMSG_OWRTOLDMSG";

		// Token: 0x0400044C RID: 1100
		public const string CTMSG_OWRTOLDDRAFTMSG = "CTMSG_OWRTOLDDRAFTMSG";

		// Token: 0x0400044D RID: 1101
		public const string CTMSG_MSGRTRYCNTR = "CTMSG_MSGRTRYCNTR";

		// Token: 0x0400044E RID: 1102
		public const string CTMSG_UNREADMSGICON = "CTMSG_UNREADMSGICON";

		// Token: 0x0400044F RID: 1103
		public const string CTMSG_SCANPREAMBLEDUR = "CTMSG_SCANPREAMBLEDUR";

		// Token: 0x04000450 RID: 1104
		public const string CTMSG_TXTMSGID = "CTMSG_TXTMSGID";

		// Token: 0x04000451 RID: 1105
		public const string CTMSG_WAITACKTMR = "CTMSG_WAITACKTMR";

		// Token: 0x04000452 RID: 1106
		public const string CTMSG_MESSAGEMAXSENTLENGTH = "CTMSG_MESSAGEMAXSENTLENGTH";

		// Token: 0x04000453 RID: 1107
		public const string QCK_TXT_MSG_DLT_TYPE = "QCK_TXT_MSG_DLT_TYPE";

		// Token: 0x04000454 RID: 1108
		public const string QCK_TXT_MSG_DLH_TYPE = "QCK_TXT_MSG_DLH_TYPE";

		// Token: 0x04000455 RID: 1109
		public const string QCK_TXT_MSG_DLL_TYPE = "QCK_TXT_MSG_DLL_TYPE";

		// Token: 0x04000456 RID: 1110
		public const string QTMSG_LSTCTG = "QTMSG_LSTCTG";

		// Token: 0x04000457 RID: 1111
		public const string QTMSG_LEDSZ = "QTMSG_LEDSZ";

		// Token: 0x04000458 RID: 1112
		public const string QTMSG_LEQMAX = "QTMSG_LEQMAX";

		// Token: 0x04000459 RID: 1113
		public const string QTMSG_LLEQMAX = "QTMSG_LLEQMAX";

		// Token: 0x0400045A RID: 1114
		public const string QCK_TXT_MSG_DLH_TYPE_FTLLISHTYPE = "QCK_TXT_MSG_DLH_TYPE_FTLLISHTYPE";

		// Token: 0x0400045B RID: 1115
		public const string QCK_TXT_MSG_DLH_TYPE_FTLLISHID = "QCK_TXT_MSG_DLH_TYPE_FTLLISHID";

		// Token: 0x0400045C RID: 1116
		public const string QCK_TXT_MSG_DLH_TYPE_NTLLISHTYPE = "QCK_TXT_MSG_DLH_TYPE_NTLLISHTYPE";

		// Token: 0x0400045D RID: 1117
		public const string QCK_TXT_MSG_DLH_TYPE_NTLLISHID = "QCK_TXT_MSG_DLH_TYPE_NTLLISHID";

		// Token: 0x0400045E RID: 1118
		public const string QTMSG_LLEQ = "QTMSG_LLEQ";

		// Token: 0x0400045F RID: 1119
		public const string QTMSG_QCKTXTMSG = "QTMSG_QCKTXTMSG";

		// Token: 0x04000460 RID: 1120
		public const string QTMSG_QCKTXTEDITFLD = "QTMSG_QCKTXTEDITFLD";

		// Token: 0x04000461 RID: 1121
		public const string QTMSG_EDTFLDOFFSET = "QTMSG_EDTFLDOFFSET";

		// Token: 0x04000462 RID: 1122
		public const string QTMSG_EDTFLDLGTH = "QTMSG_EDTFLDLGTH";

		// Token: 0x04000463 RID: 1123
		public const string BTN_ADDTEXTMSG = "BTN_ADDTEXTMSG";

		// Token: 0x04000464 RID: 1124
		public const string BTN_DELTEXTMSG = "BTN_DELTEXTMSG";

		// Token: 0x04000465 RID: 1125
		public const string GCAI_MAP_CONNECTOR_CMP_TYPE = "GCAI_MAP_CONNECTOR_CMP_TYPE";

		// Token: 0x04000466 RID: 1126
		public const string GPIO = "GPIO";

		// Token: 0x04000467 RID: 1127
		public const string AC_GPIO = "AC_GPIO";

		// Token: 0x04000468 RID: 1128
		public const string AC_GPIO1 = "AC_GPIO1";

		// Token: 0x04000469 RID: 1129
		public const string AC_GPIO2 = "AC_GPIO2";

		// Token: 0x0400046A RID: 1130
		public const string AC_GPIO3 = "AC_GPIO3";

		// Token: 0x0400046B RID: 1131
		public const string AC_GPIO4 = "AC_GPIO4";

		// Token: 0x0400046C RID: 1132
		public const string AC_GPIO5 = "AC_GPIO5";

		// Token: 0x0400046D RID: 1133
		public const string AC_GPIO6 = "AC_GPIO6";

		// Token: 0x0400046E RID: 1134
		public const string AC_GPIO7 = "AC_GPIO7";

		// Token: 0x0400046F RID: 1135
		public const string AC_GPIO8 = "AC_GPIO8";

		// Token: 0x04000470 RID: 1136
		public const string AC_GPIO10 = "AC_GPIO10";

		// Token: 0x04000471 RID: 1137
		public const string AC_IGNSNSETYPE = "AC_IGNSNSETYPE";

		// Token: 0x04000472 RID: 1138
		public const string AC_IGNSSATPRDNTM = "AC_IGNSSATPRDNTM";

		// Token: 0x04000473 RID: 1139
		public const string AC_DATPTTOVRVO = "AC_DATPTTOVRVO";

		// Token: 0x04000474 RID: 1140
		public const string AC_RXAUDTYP = "AC_RXAUDTYP";

		// Token: 0x04000475 RID: 1141
		public const string AC_DATPTTAUDSRC = "AC_DATPTTAUDSRC";

		// Token: 0x04000476 RID: 1142
		public const string AC_HNDSETEN = "AC_HNDSETEN";

		// Token: 0x04000477 RID: 1143
		public const string AC_GPIO1FS = "AC_GPIO1FS";

		// Token: 0x04000478 RID: 1144
		public const string AC_GPIO1AL = "AC_GPIO1AL";

		// Token: 0x04000479 RID: 1145
		public const string AC_GPIO1DB = "AC_GPIO1DB";

		// Token: 0x0400047A RID: 1146
		public const string AC_GPIO2FS = "AC_GPIO2FS";

		// Token: 0x0400047B RID: 1147
		public const string AC_GPIO2AL = "AC_GPIO2AL";

		// Token: 0x0400047C RID: 1148
		public const string AC_GPIO2DB = "AC_GPIO2DB";

		// Token: 0x0400047D RID: 1149
		public const string AC_GPIO3FS = "AC_GPIO3FS";

		// Token: 0x0400047E RID: 1150
		public const string AC_GPIO3AL = "AC_GPIO3AL";

		// Token: 0x0400047F RID: 1151
		public const string AC_GPIO3DB = "AC_GPIO3DB";

		// Token: 0x04000480 RID: 1152
		public const string AC_GPIO4FS = "AC_GPIO4FS";

		// Token: 0x04000481 RID: 1153
		public const string AC_GPIO4AL = "AC_GPIO4AL";

		// Token: 0x04000482 RID: 1154
		public const string AC_GPIO4DB = "AC_GPIO4DB";

		// Token: 0x04000483 RID: 1155
		public const string AC_GPIO5FS = "AC_GPIO5FS";

		// Token: 0x04000484 RID: 1156
		public const string AC_GPIO5AL = "AC_GPIO5AL";

		// Token: 0x04000485 RID: 1157
		public const string AC_GPIO5DB = "AC_GPIO5DB";

		// Token: 0x04000486 RID: 1158
		public const string AC_GPIO6FS = "AC_GPIO6FS";

		// Token: 0x04000487 RID: 1159
		public const string AC_GPIO6AL = "AC_GPIO6AL";

		// Token: 0x04000488 RID: 1160
		public const string AC_GPIO6DB = "AC_GPIO6DB";

		// Token: 0x04000489 RID: 1161
		public const string AC_GPIO7FS = "AC_GPIO7FS";

		// Token: 0x0400048A RID: 1162
		public const string AC_GPIO7AL = "AC_GPIO7AL";

		// Token: 0x0400048B RID: 1163
		public const string AC_GPIO7DB = "AC_GPIO7DB";

		// Token: 0x0400048C RID: 1164
		public const string AC_GPIO8FS = "AC_GPIO8FS";

		// Token: 0x0400048D RID: 1165
		public const string AC_GPIO8AL = "AC_GPIO8AL";

		// Token: 0x0400048E RID: 1166
		public const string AC_GPIO8DB = "AC_GPIO8DB";

		// Token: 0x0400048F RID: 1167
		public const string AC_GPIO10FS = "AC_GPIO10FS";

		// Token: 0x04000490 RID: 1168
		public const string AC_GPIO10AL = "AC_GPIO10AL";

		// Token: 0x04000491 RID: 1169
		public const string AC_GPIO10DB = "AC_GPIO10DB";

		// Token: 0x04000492 RID: 1170
		public const string AC_GPIO9FS = "AC_GPIO9FS";

		// Token: 0x04000493 RID: 1171
		public const string AC_GPIO9AL = "AC_GPIO9AL";

		// Token: 0x04000494 RID: 1172
		public const string AC_GPIO9DB = "AC_GPIO9DB";

		// Token: 0x04000495 RID: 1173
		public const string AC_GPIO11FS = "AC_GPIO11FS";

		// Token: 0x04000496 RID: 1174
		public const string AC_GPIO11AL = "AC_GPIO11AL";

		// Token: 0x04000497 RID: 1175
		public const string AC_GPIO11DB = "AC_GPIO11DB";

		// Token: 0x04000498 RID: 1176
		public const string AC_GPIO12FS = "AC_GPIO12FS";

		// Token: 0x04000499 RID: 1177
		public const string AC_GPIO12AL = "AC_GPIO12AL";

		// Token: 0x0400049A RID: 1178
		public const string AC_GPIO12DB = "AC_GPIO12DB";

		// Token: 0x0400049B RID: 1179
		public const string AC_ACCPKGID = "AC_ACCPKGID";

		// Token: 0x0400049C RID: 1180
		public const string AC_DBDURATION = "AC_DBDURATION";

		// Token: 0x0400049D RID: 1181
		public const string AC_HLEN = "AC_HLEN";

		// Token: 0x0400049E RID: 1182
		public const string AC_EXTALRMCONF = "AC_EXTALRMCONF";

		// Token: 0x0400049F RID: 1183
		public const string AC_HLDELAYTMR = "AC_HLDELAYTMR";

		// Token: 0x040004A0 RID: 1184
		public const string AC_HLDUR = "AC_HLDUR";

		// Token: 0x040004A1 RID: 1185
		public const string AC_HLCONFIG = "AC_HLCONFIG";

		// Token: 0x040004A2 RID: 1186
		public const string BR_ACCAUDIOEMPS = "BR_ACCAUDIOEMPS";

		// Token: 0x040004A3 RID: 1187
		public const string AC_GPIO1FS_MOBRPTR = "AC_GPIO1FS_MOBRPTR";

		// Token: 0x040004A4 RID: 1188
		public const string AC_GPIO1FS_PORT = "AC_GPIO1FS_PORT";

		// Token: 0x040004A5 RID: 1189
		public const string AC_GPIO2FS_MOBRPTR = "AC_GPIO2FS_MOBRPTR";

		// Token: 0x040004A6 RID: 1190
		public const string AC_GPIO2FS_PORT = "AC_GPIO2FS_PORT";

		// Token: 0x040004A7 RID: 1191
		public const string AC_GPIO3FS_MOBRPTR = "AC_GPIO3FS_MOBRPTR";

		// Token: 0x040004A8 RID: 1192
		public const string AC_GPIO3FS_PORT = "AC_GPIO3FS_PORT";

		// Token: 0x040004A9 RID: 1193
		public const string AC_GPIO4FS_PORT = "AC_GPIO4FS_PORT";

		// Token: 0x040004AA RID: 1194
		public const string AC_GPIO6FS_MOBRPTR = "AC_GPIO6FS_MOBRPTR";

		// Token: 0x040004AB RID: 1195
		public const string AC_GPIO7FS_MOBRPTR = "AC_GPIO7FS_MOBRPTR";

		// Token: 0x040004AC RID: 1196
		public const string AC_GPIO8FS_MOBRPTR = "AC_GPIO8FS_MOBRPTR";

		// Token: 0x040004AD RID: 1197
		public const string AC_GPIO10FS_MOBRPTR = "AC_GPIO10FS_MOBRPTR";

		// Token: 0x040004AE RID: 1198
		public const string AC_GPIO1AL_MOBRPTR = "AC_GPIO1AL_MOBRPTR";

		// Token: 0x040004AF RID: 1199
		public const string AC_GPIO1AL_PORT = "AC_GPIO1AL_PORT";

		// Token: 0x040004B0 RID: 1200
		public const string AC_GPIO1DB_MOBRPTR = "AC_GPIO1DB_MOBRPTR";

		// Token: 0x040004B1 RID: 1201
		public const string AC_GPIO1DB_PORT = "AC_GPIO1DB_PORT";

		// Token: 0x040004B2 RID: 1202
		public const string AC_GPIO2AL_PORT = "AC_GPIO2AL_PORT";

		// Token: 0x040004B3 RID: 1203
		public const string AC_GPIO2DB_PORT = "AC_GPIO2DB_PORT";

		// Token: 0x040004B4 RID: 1204
		public const string AC_GPIO3AL_MOBRPTR = "AC_GPIO3AL_MOBRPTR";

		// Token: 0x040004B5 RID: 1205
		public const string AC_GPIO3AL_PORT = "AC_GPIO3AL_PORT";

		// Token: 0x040004B6 RID: 1206
		public const string AC_GPIO3DB_MOBRPTR = "AC_GPIO3DB_MOBRPTR";

		// Token: 0x040004B7 RID: 1207
		public const string AC_GPIO3DB_PORT = "AC_GPIO3DB_PORT";

		// Token: 0x040004B8 RID: 1208
		public const string AC_GPIO1FS_TAHITI = "AC_GPIO1FS_TAHITI";

		// Token: 0x040004B9 RID: 1209
		public const string AC_GPIO1AL_TAHITI = "AC_GPIO1AL_TAHITI";

		// Token: 0x040004BA RID: 1210
		public const string AC_GPIO1DB_TAHITI = "AC_GPIO1DB_TAHITI";

		// Token: 0x040004BB RID: 1211
		public const string AC_GPIO3FS_TAHITI = "AC_GPIO3FS_TAHITI";

		// Token: 0x040004BC RID: 1212
		public const string AC_GPIO3AL_TAHITI = "AC_GPIO3AL_TAHITI";

		// Token: 0x040004BD RID: 1213
		public const string AC_GPIO3DB_TAHITI = "AC_GPIO3DB_TAHITI";

		// Token: 0x040004BE RID: 1214
		public const string AC_GPIO4FS_TAHITI = "AC_GPIO4FS_TAHITI";

		// Token: 0x040004BF RID: 1215
		public const string AC_GPIO4AL_TAHITI = "AC_GPIO4AL_TAHITI";

		// Token: 0x040004C0 RID: 1216
		public const string AC_GPIO4DB_TAHITI = "AC_GPIO4DB_TAHITI";

		// Token: 0x040004C1 RID: 1217
		public const string AC_GPIO7FS_TAHITI = "AC_GPIO7FS_TAHITI";

		// Token: 0x040004C2 RID: 1218
		public const string AC_GPIO7AL_TAHITI = "AC_GPIO7AL_TAHITI";

		// Token: 0x040004C3 RID: 1219
		public const string AC_GPIO7DB_TAHITI = "AC_GPIO7DB_TAHITI";

		// Token: 0x040004C4 RID: 1220
		public const string AC_GPIO8FS_TAHITI = "AC_GPIO8FS_TAHITI";

		// Token: 0x040004C5 RID: 1221
		public const string AC_GPIO8AL_TAHITI = "AC_GPIO8AL_TAHITI";

		// Token: 0x040004C6 RID: 1222
		public const string AC_GPIO8DB_TAHITI = "AC_GPIO8DB_TAHITI";

		// Token: 0x040004C7 RID: 1223
		public const string AC_GPIO2FS_TAHITI = "AC_GPIO2FS_TAHITI";

		// Token: 0x040004C8 RID: 1224
		public const string AC_GPIO2AL_TAHITI = "AC_GPIO2AL_TAHITI";

		// Token: 0x040004C9 RID: 1225
		public const string AC_GPIO2DB_TAHITI = "AC_GPIO2DB_TAHITI";

		// Token: 0x040004CA RID: 1226
		public const string ENABLEGPSREPORT = "ENABLEGPSREPORT";

		// Token: 0x040004CB RID: 1227
		public const string GPIOENABLEGPSREPORT = "GPIOENABLEGPSREPORT";

		// Token: 0x040004CC RID: 1228
		public const string AC_GPIO1_ENABLEGPSREPORT_MOB = "AC_GPIO1_ENABLEGPSREPORT_MOB";

		// Token: 0x040004CD RID: 1229
		public const string AC_GPIO1_ENABLEGPSREPORT_PORT = "AC_GPIO1_ENABLEGPSREPORT_PORT";

		// Token: 0x040004CE RID: 1230
		public const string AC_GPIO2_ENABLEGPSREPORT_MOB = "AC_GPIO2_ENABLEGPSREPORT_MOB";

		// Token: 0x040004CF RID: 1231
		public const string AC_GPIO2_ENABLEGPSREPORT_PORT = "AC_GPIO2_ENABLEGPSREPORT_PORT";

		// Token: 0x040004D0 RID: 1232
		public const string AC_GPIO3_ENABLEGPSREPORT_MOB = "AC_GPIO3_ENABLEGPSREPORT_MOB";

		// Token: 0x040004D1 RID: 1233
		public const string AC_GPIO3_ENABLEGPSREPORT_PORT = "AC_GPIO3_ENABLEGPSREPORT_PORT";

		// Token: 0x040004D2 RID: 1234
		public const string AC_GPIO4_ENABLEGPSREPORT_MOB = "AC_GPIO4_ENABLEGPSREPORT_MOB";

		// Token: 0x040004D3 RID: 1235
		public const string AC_GPIO4_ENABLEGPSREPORT_PORT = "AC_GPIO4_ENABLEGPSREPORT_PORT";

		// Token: 0x040004D4 RID: 1236
		public const string AC_GPIO6_ENABLEGPSREPORT_MOB = "AC_GPIO6_ENABLEGPSREPORT_MOB";

		// Token: 0x040004D5 RID: 1237
		public const string AC_GPIO7_ENABLEGPSREPORT_MOB = "AC_GPIO7_ENABLEGPSREPORT_MOB";

		// Token: 0x040004D6 RID: 1238
		public const string AC_GPIO8_ENABLEGPSREPORT_MOB = "AC_GPIO8_ENABLEGPSREPORT_MOB";

		// Token: 0x040004D7 RID: 1239
		public const string AC_GPIO10_ENABLEGPSREPORT_MOB = "AC_GPIO10_ENABLEGPSREPORT_MOB";

		// Token: 0x040004D8 RID: 1240
		public const string BR_EXTTXCTRLMODE = "BR_EXTTXCTRLMODE";

		// Token: 0x040004D9 RID: 1241
		public const string BR_CALLPREEPTNPRY = "BR_CALLPREEPTNPRY";

		// Token: 0x040004DA RID: 1242
		public const string ACCESSORY_CONNECTOR_CMP_TYPE = "ACCESSORY_CONNECTOR_CMP_TYPE";

		// Token: 0x040004DB RID: 1243
		public const string ACCY_VOLCTRLEN = "ACCY_VOLCTRLEN";

		// Token: 0x040004DC RID: 1244
		public const string ACCY_VOLFDBKEN = "ACCY_VOLFDBKEN";

		// Token: 0x040004DD RID: 1245
		public const string ACCY_VOXGAIN = "ACCY_VOXGAIN";

		// Token: 0x040004DE RID: 1246
		public const string ACCY_PWRUPDEL = "ACCY_PWRUPDEL";

		// Token: 0x040004DF RID: 1247
		public const string ACCY_NUMENT = "ACCY_NUMENT";

		// Token: 0x040004E0 RID: 1248
		public const string ACCY_VNDRID = "ACCY_VNDRID";

		// Token: 0x040004E1 RID: 1249
		public const string ACCY_PRDTID = "ACCY_PRDTID";

		// Token: 0x040004E2 RID: 1250
		public const string ACCY_SOFTCONIDR = "ACCY_SOFTCONIDR";

		// Token: 0x040004E3 RID: 1251
		public const string ACCY_DATARVTCHNL = "ACCY_DATARVTCHNL";

		// Token: 0x040004E4 RID: 1252
		public const string ACCY_DATARVTCHNLTYPE = "ACCY_DATARVTCHNLTYPE";

		// Token: 0x040004E5 RID: 1253
		public const string ACCY_DATARVTCHNLID = "ACCY_DATARVTCHNLID";

		// Token: 0x040004E6 RID: 1254
		public const string ACCY_PREDATARVTCHNL = "ACCY_PREDATARVTCHNL";

		// Token: 0x040004E7 RID: 1255
		public const string ACCY_PREDATARVTCHNLTYPE = "ACCY_PREDATARVTCHNLTYPE";

		// Token: 0x040004E8 RID: 1256
		public const string ACCY_PREDATARVTCHNLID = "ACCY_PREDATARVTCHNLID";

		// Token: 0x040004E9 RID: 1257
		public const string MDC_SYS_CMP_TYPE = "MDC_SYS_CMP_TYPE";

		// Token: 0x040004EA RID: 1258
		public const string MDCSYS_DOSCRTTYPE = "MDCSYS_DOSCRTTYPE";

		// Token: 0x040004EB RID: 1259
		public const string MDCSYS_DOSEN = "MDCSYS_DOSEN";

		// Token: 0x040004EC RID: 1260
		public const string MDCSYS_PTTSTTYPE = "MDCSYS_PTTSTTYPE";

		// Token: 0x040004ED RID: 1261
		public const string MDCSYS_PTTIDTYPE = "MDCSYS_PTTIDTYPE";

		// Token: 0x040004EE RID: 1262
		public const string MDCSYS_MDCCAENC = "MDCSYS_MDCCAENC";

		// Token: 0x040004EF RID: 1263
		public const string MDCSYS_MDCCADEC = "MDCSYS_MDCCADEC";

		// Token: 0x040004F0 RID: 1264
		public const string MDCSYS_DOSAUTOMUTEDUR = "MDCSYS_DOSAUTOMUTEDUR";

		// Token: 0x040004F1 RID: 1265
		public const string MDCSYS_PRMID = "MDCSYS_PRMID";

		// Token: 0x040004F2 RID: 1266
		public const string MDCSYS_GRPID = "MDCSYS_GRPID";

		// Token: 0x040004F3 RID: 1267
		public const string MDCSYS_DOSCOASTDRT = "MDCSYS_DOSCOASTDRT";

		// Token: 0x040004F4 RID: 1268
		public const string MDCSYS_LTDPTCTIME = "MDCSYS_LTDPTCTIME";

		// Token: 0x040004F5 RID: 1269
		public const string MDCSYS_EMGCYTYPE = "MDCSYS_EMGCYTYPE";

		// Token: 0x040004F6 RID: 1270
		public const string MDCSYS_EMGCYATYPE = "MDCSYS_EMGCYATYPE";

		// Token: 0x040004F7 RID: 1271
		public const string MDCSYS_EMHOTMICTXDUR = "MDCSYS_EMHOTMICTXDUR";

		// Token: 0x040004F8 RID: 1272
		public const string MDCSYS_EMHOTMICCLCNT = "MDCSYS_EMHOTMICCLCNT";

		// Token: 0x040004F9 RID: 1273
		public const string MDCSYS_EMHOTMICRXDUR = "MDCSYS_EMHOTMICRXDUR";

		// Token: 0x040004FA RID: 1274
		public const string MDCSYS_MDCEMGCYADECEN = "MDCSYS_MDCEMGCYADECEN";

		// Token: 0x040004FB RID: 1275
		public const string MDCSYS_EMGCYLMTPTIME = "MDCSYS_EMGCYLMTPTIME";

		// Token: 0x040004FC RID: 1276
		public const string MDCSYS_DOSFIXRETRYTIME = "MDCSYS_DOSFIXRETRYTIME";

		// Token: 0x040004FD RID: 1277
		public const string MDCSYS_MDCEMGCYPERS = "MDCSYS_MDCEMGCYPERS";

		// Token: 0x040004FE RID: 1278
		public const string MDCSYS_MDCEMGCYPERSTYPE = "MDCSYS_MDCEMGCYPERSTYPE";

		// Token: 0x040004FF RID: 1279
		public const string MDCSYS_MDCEMGCYPERSID = "MDCSYS_MDCEMGCYPERSID";

		// Token: 0x04000500 RID: 1280
		public const string MDCSYS_PLTRET = "MDCSYS_PLTRET";

		// Token: 0x04000501 RID: 1281
		public const string MDCSYS_IMPLTRET = "MDCSYS_IMPLTRET";

		// Token: 0x04000502 RID: 1282
		public const string MDCSYS_EMGCYPTTID = "MDCSYS_EMGCYPTTID";

		// Token: 0x04000503 RID: 1283
		public const string MDCSYS_MDCSYSALIAS = "MDCSYS_MDCSYSALIAS";

		// Token: 0x04000504 RID: 1284
		public const string MDCSYS_SDPREAMBLE = "MDCSYS_SDPREAMBLE";

		// Token: 0x04000505 RID: 1285
		public const string MDCSYS_EMPTTIDEN = "MDCSYS_EMPTTIDEN";

		// Token: 0x04000506 RID: 1286
		public const string MDCSYS_EMGCYPTTSTEN = "MDCSYS_EMGCYPTTSTEN";

		// Token: 0x04000507 RID: 1287
		public const string MDCSYS_RMDECEN = "MDCSYS_RMDECEN";

		// Token: 0x04000508 RID: 1288
		public const string MDCSYS_EMGRM = "MDCSYS_EMGRM";

		// Token: 0x04000509 RID: 1289
		public const string RX_TG_LIST_DLT_TYPE = "RX_TG_LIST_DLT_TYPE";

		// Token: 0x0400050A RID: 1290
		public const string RX_TG_LIST_DLH_TYPE = "RX_TG_LIST_DLH_TYPE";

		// Token: 0x0400050B RID: 1291
		public const string RX_TG_LIST_DLL_TYPE = "RX_TG_LIST_DLL_TYPE";

		// Token: 0x0400050C RID: 1292
		public const string RXTG_LSTCTG = "RXTG_LSTCTG";

		// Token: 0x0400050D RID: 1293
		public const string RXTG_LEDSZ = "RXTG_LEDSZ";

		// Token: 0x0400050E RID: 1294
		public const string RXTG_LEQMAX = "RXTG_LEQMAX";

		// Token: 0x0400050F RID: 1295
		public const string RX_TG_LIST_DLH_TYPE_FTLLISHTYPE = "RX_TG_LIST_DLH_TYPE_FTLLISHTYPE";

		// Token: 0x04000510 RID: 1296
		public const string RX_TG_LIST_DLH_TYPE_FTLLISHID = "RX_TG_LIST_DLH_TYPE_FTLLISHID";

		// Token: 0x04000511 RID: 1297
		public const string RX_TG_LIST_DLL_TYPE_NTLLISHTYPE = "RX_TG_LIST_DLL_TYPE_NTLLISHTYPE";

		// Token: 0x04000512 RID: 1298
		public const string RX_TG_LIST_DLL_TYPE_NTLLISHID = "RX_TG_LIST_DLL_TYPE_NTLLISHID";

		// Token: 0x04000513 RID: 1299
		public const string RXTG_LLEQ = "RXTG_LLEQ";

		// Token: 0x04000514 RID: 1300
		public const string RXTG_DGUCLCOMP = "RXTG_DGUCLCOMP";

		// Token: 0x04000515 RID: 1301
		public const string RXTG_DGUCLCOMPTYPE = "RXTG_DGUCLCOMPTYPE";

		// Token: 0x04000516 RID: 1302
		public const string RXTG_DGUCLCOMPID = "RXTG_DGUCLCOMPID";

		// Token: 0x04000517 RID: 1303
		public const string RXTG_RXTGLISTALIAS = "RXTG_RXTGLISTALIAS";

		// Token: 0x04000518 RID: 1304
		public const string DIGITAL_SIG_SYS_CMP_TYPE = "DIGITAL_SIG_SYS_CMP_TYPE";

		// Token: 0x04000519 RID: 1305
		public const string DSS_RMOTENCEN = "DSS_RMOTENCEN";

		// Token: 0x0400051A RID: 1306
		public const string DSS_RMOTDECEN = "DSS_RMOTDECEN";

		// Token: 0x0400051B RID: 1307
		public const string DSS_EMRMOTEN = "DSS_EMRMOTEN";

		// Token: 0x0400051C RID: 1308
		public const string DSS_RMOTMUL = "DSS_RMOTMUL";

		// Token: 0x0400051D RID: 1309
		public const string DSS_RMOTTXTMR = "DSS_RMOTTXTMR";

		// Token: 0x0400051E RID: 1310
		public const string DSS_RDCHKEN = "DSS_RDCHKEN";

		// Token: 0x0400051F RID: 1311
		public const string DSS_RDDISENCEN = "DSS_RDDISENCEN";

		// Token: 0x04000520 RID: 1312
		public const string DSS_RDDISDECEN = "DSS_RDDISDECEN";

		// Token: 0x04000521 RID: 1313
		public const string DSS_RDINHIBITSTATE = "DSS_RDINHIBITSTATE";

		// Token: 0x04000522 RID: 1314
		public const string DSS_RDENENCEN = "DSS_RDENENCEN";

		// Token: 0x04000523 RID: 1315
		public const string DSS_RDINHIBITPERSITTYPE = "DSS_RDINHIBITPERSITTYPE";

		// Token: 0x04000524 RID: 1316
		public const string DSS_RDINHIBITPERSITID = "DSS_RDINHIBITPERSITID";

		// Token: 0x04000525 RID: 1317
		public const string DSS_RDINHIBITPERSIT = "DSS_RDINHIBITPERSIT";

		// Token: 0x04000526 RID: 1318
		public const string DSS_CALRTENCEN = "DSS_CALRTENCEN";

		// Token: 0x04000527 RID: 1319
		public const string DSS_NETID = "DSS_NETID";

		// Token: 0x04000528 RID: 1320
		public const string DSS_RDSUBMASK = "DSS_RDSUBMASK";

		// Token: 0x04000529 RID: 1321
		public const string DSS_RDIPADDR = "DSS_RDIPADDR";

		// Token: 0x0400052A RID: 1322
		public const string DSS_ACCESUBMASK = "DSS_ACCESUBMASK";

		// Token: 0x0400052B RID: 1323
		public const string DSS_ACCEIPADDR = "DSS_ACCEIPADDR";

		// Token: 0x0400052C RID: 1324
		public const string DSS_ROUTIPADDR = "DSS_ROUTIPADDR";

		// Token: 0x0400052D RID: 1325
		public const string DSS_LNKCTLEMBCNT = "DSS_LNKCTLEMBCNT";

		// Token: 0x0400052E RID: 1326
		public const string DSS_ALIAS = "DSS_ALIAS";

		// Token: 0x0400052F RID: 1327
		public const string DSS_RFMONTIME = "DSS_RFMONTIME";

		// Token: 0x04000530 RID: 1328
		public const string DSS_RFMONTHOLDLEV = "DSS_RFMONTHOLDLEV";

		// Token: 0x04000531 RID: 1329
		public const string DSS_TXCOLCODTOT = "DSS_TXCOLCODTOT";

		// Token: 0x04000532 RID: 1330
		public const string DSS_TXSYNCSRCHTOT = "DSS_TXSYNCSRCHTOT";

		// Token: 0x04000533 RID: 1331
		public const string DSS_TXSYNCWAKETOT = "DSS_TXSYNCWAKETOT";

		// Token: 0x04000534 RID: 1332
		public const string DSS_TXLIMPATTIME = "DSS_TXLIMPATTIME";

		// Token: 0x04000535 RID: 1333
		public const string DSS_IDLESRCHTOT = "DSS_IDLESRCHTOT";

		// Token: 0x04000536 RID: 1334
		public const string DSS_CHNLBZCNT = "DSS_CHNLBZCNT";

		// Token: 0x04000537 RID: 1335
		public const string DSS_TXWAKEMSGLMT = "DSS_TXWAKEMSGLMT";

		// Token: 0x04000538 RID: 1336
		public const string DSS_CCODNSLOTTOT = "DSS_CCODNSLOTTOT";

		// Token: 0x04000539 RID: 1337
		public const string DSS_COLORCODE = "DSS_COLORCODE";

		// Token: 0x0400053A RID: 1338
		public const string DSS_TXLONGRANDRGN = "DSS_TXLONGRANDRGN";

		// Token: 0x0400053B RID: 1339
		public const string DSS_TXACKRANDRNG = "DSS_TXACKRANDRNG";

		// Token: 0x0400053C RID: 1340
		public const string DSS_TCWAKETHLMT = "DSS_TCWAKETHLMT";

		// Token: 0x0400053D RID: 1341
		public const string DSS_TAPTIME = "DSS_TAPTIME";

		// Token: 0x0400053E RID: 1342
		public const string DSS_RPTERPTIME = "DSS_RPTERPTIME";

		// Token: 0x0400053F RID: 1343
		public const string DSS_PRVTC2NDSSQUENTPTIME = "DSS_PRVTC2NDSSQUENTPTIME";

		// Token: 0x04000540 RID: 1344
		public const string DSS_RMOTDUR = "DSS_RMOTDUR";

		// Token: 0x04000541 RID: 1345
		public const string DSS_PKEYID = "DSS_PKEYID";

		// Token: 0x04000542 RID: 1346
		public const string DSS_PKEY = "DSS_PKEYID";

		// Token: 0x04000543 RID: 1347
		public const string NETSET_CMP_TYPE = "NETSET_CMP_TYPE";

		// Token: 0x04000544 RID: 1348
		public const string NETSET_CAINETID = "NETSET_CAINETID";

		// Token: 0x04000545 RID: 1349
		public const string NETSET_RDSUBMASK = "NETSET_RDSUBMASK";

		// Token: 0x04000546 RID: 1350
		public const string NETSET_RDSUBMASK0 = "NETSET_RDSUBMASK0";

		// Token: 0x04000547 RID: 1351
		public const string NETSET_RDSUBMASK1 = "NETSET_RDSUBMASK1";

		// Token: 0x04000548 RID: 1352
		public const string NETSET_RDSUBMASK2 = "NETSET_RDSUBMASK2";

		// Token: 0x04000549 RID: 1353
		public const string NETSET_RDSUBMASK3 = "NETSET_RDSUBMASK3";

		// Token: 0x0400054A RID: 1354
		public const string NETSET_RDIPADDR = "NETSET_RDIPADDR";

		// Token: 0x0400054B RID: 1355
		public const string NETSET_RDIPADDR0 = "NETSET_RDIPADDR0";

		// Token: 0x0400054C RID: 1356
		public const string NETSET_RDIPADDR1 = "NETSET_RDIPADDR1";

		// Token: 0x0400054D RID: 1357
		public const string NETSET_RDIPADDR2 = "NETSET_RDIPADDR2";

		// Token: 0x0400054E RID: 1358
		public const string NETSET_RDIPADDR3 = "NETSET_RDIPADDR3";

		// Token: 0x0400054F RID: 1359
		public const string ERS_CALLMONAPP1IP = "ERS_CALLMONAPP1IP";

		// Token: 0x04000550 RID: 1360
		public const string ERS_CALLMONAPP2IP = "ERS_CALLMONAPP2IP";

		// Token: 0x04000551 RID: 1361
		public const string ERS_CALLMONAPP3IP = "ERS_CALLMONAPP3IP";

		// Token: 0x04000552 RID: 1362
		public const string NETSET_ACCESUBMASK = "NETSET_ACCESUBMASK";

		// Token: 0x04000553 RID: 1363
		public const string NETSET_ACCESUBMASK0 = "NETSET_ACCESUBMASK0";

		// Token: 0x04000554 RID: 1364
		public const string NETSET_ACCESUBMASK1 = "NETSET_ACCESUBMASK1";

		// Token: 0x04000555 RID: 1365
		public const string NETSET_ACCESUBMASK2 = "NETSET_ACCESUBMASK2";

		// Token: 0x04000556 RID: 1366
		public const string NETSET_ACCESUBMASK3 = "NETSET_ACCESUBMASK3";

		// Token: 0x04000557 RID: 1367
		public const string NETSET_ACCEIPADDR = "NETSET_ACCEIPADDR";

		// Token: 0x04000558 RID: 1368
		public const string NETSET_ACCEIPADDR0 = "NETSET_ACCEIPADDR0";

		// Token: 0x04000559 RID: 1369
		public const string NETSET_ACCEIPADDR1 = "NETSET_ACCEIPADDR1";

		// Token: 0x0400055A RID: 1370
		public const string NETSET_ACCEIPADDR2 = "NETSET_ACCEIPADDR2";

		// Token: 0x0400055B RID: 1371
		public const string NETSET_ACCEIPADDR3 = "NETSET_ACCEIPADDR3";

		// Token: 0x0400055C RID: 1372
		public const string NETSET_ROUTIPADDR = "NETSET_ROUTIPADDR";

		// Token: 0x0400055D RID: 1373
		public const string NETSET_ROUTIPADDR0 = "NETSET_ROUTIPADDR0";

		// Token: 0x0400055E RID: 1374
		public const string NETSET_ROUTIPADDR1 = "NETSET_ROUTIPADDR1";

		// Token: 0x0400055F RID: 1375
		public const string NETSET_ROUTIPADDR2 = "NETSET_ROUTIPADDR2";

		// Token: 0x04000560 RID: 1376
		public const string NETSET_ROUTIPADDR3 = "NETSET_ROUTIPADDR3";

		// Token: 0x04000561 RID: 1377
		public const string NETSET_CAIGRPNETID = "NETSET_CAIGRPNETID";

		// Token: 0x04000562 RID: 1378
		public const string NETSET_TMSGWIPADDR = "NETSET_TMSGWIPADDR";

		// Token: 0x04000563 RID: 1379
		public const string NETSET_TMSGWIPADDR0 = "NETSET_TMSGWIPADDR0";

		// Token: 0x04000564 RID: 1380
		public const string NETSET_TMSGWIPADDR1 = "NETSET_TMSGWIPADDR1";

		// Token: 0x04000565 RID: 1381
		public const string NETSET_TMSGWIPADDR2 = "NETSET_TMSGWIPADDR2";

		// Token: 0x04000566 RID: 1382
		public const string NETSET_TMSGWIPADDR3 = "NETSET_TMSGWIPADDR3";

		// Token: 0x04000567 RID: 1383
		public const string NETSET_ARSSVRIPADDR = "NETSET_ARSSVRIPADDR";

		// Token: 0x04000568 RID: 1384
		public const string NETSET_ARSSVRIPADDR0 = "NETSET_ARSSVRIPADDR0";

		// Token: 0x04000569 RID: 1385
		public const string NETSET_ARSSVRIPADDR1 = "NETSET_ARSSVRIPADDR1";

		// Token: 0x0400056A RID: 1386
		public const string NETSET_ARSSVRIPADDR2 = "NETSET_ARSSVRIPADDR2";

		// Token: 0x0400056B RID: 1387
		public const string NETSET_ARSSVRIPADDR3 = "NETSET_ARSSVRIPADDR3";

		// Token: 0x0400056C RID: 1388
		public const string NETSET_PCFWFLG = "NETSET_PCFWFLG";

		// Token: 0x0400056D RID: 1389
		public const string NETSET_PCFWFLGPLUS = "NETSET_PCFWFLGPLUS";

		// Token: 0x0400056E RID: 1390
		public const string NETSET_ARSEN = "NETSET_ARSEN";

		// Token: 0x0400056F RID: 1391
		public const string NETSET_MAXTXPDUSZ = "NETSET_MAXTXPDUSZ";

		// Token: 0x04000570 RID: 1392
		public const string NETSET_TMEXTUDPPORT = "NETSET_TMEXTUDPPORT";

		// Token: 0x04000571 RID: 1393
		public const string NETSET_TELEXTUDPPORT = "NETSET_TELEXTUDPPORT";

		// Token: 0x04000572 RID: 1394
		public const string NETSET_ARSEXTUDPPORT = "NETSET_ARSEXTUDPPORT";

		// Token: 0x04000573 RID: 1395
		public const string NETSET_PROGUDPSRCDSTPORT1 = "NETSET_PROGUDPSRCDSTPORT1";

		// Token: 0x04000574 RID: 1396
		public const string NETSET_PROGUDPSRCDSTPORT2 = "NETSET_PROGUDPSRCDSTPORT2";

		// Token: 0x04000575 RID: 1397
		public const string NETSET_PROGUDPSRCDSTPORT3 = "NETSET_PROGUDPSRCDSTPORT3";

		// Token: 0x04000576 RID: 1398
		public const string NETSET_ATDTCP = "NETSET_ATDTCP";

		// Token: 0x04000577 RID: 1399
		public const string NETSET_GPSTCP = "NETSET_GPSTCP";

		// Token: 0x04000578 RID: 1400
		public const string NETSET_AIRTUDP = "NETSET_AIRTUDP";

		// Token: 0x04000579 RID: 1401
		public const string NETSET_LRRPUDP = "NETSET_LRRPUDP";

		// Token: 0x0400057A RID: 1402
		public const string NETSET_OPBDPUDP = "NETSET_OPBDPUDP";

		// Token: 0x0400057B RID: 1403
		public const string NETSET_APPREGSVCUDP = "NETSET_APPREGSVCUDP";

		// Token: 0x0400057C RID: 1404
		public const string NETSET_OPBLRRPUDP = "NETSET_OPBLRRPUDP";

		// Token: 0x0400057D RID: 1405
		public const string NETSET_OPBTLMUDP = "NETSET_OPBTLMUDP";

		// Token: 0x0400057E RID: 1406
		public const string NETSET_OPBTXTMSGUDP = "NETSET_OPBTXTMSGUDP";

		// Token: 0x0400057F RID: 1407
		public const string NETSET_TLMUDP = "NETSET_TLMUDP";

		// Token: 0x04000580 RID: 1408
		public const string NETSET_TXTMSGUDP = "NETSET_TXTMSGUDP";

		// Token: 0x04000581 RID: 1409
		public const string NETSET_TMSRADIOID = "NETSET_TMSRADIOID";

		// Token: 0x04000582 RID: 1410
		public const string NETSET_ARSRADIOID = "NETSET_ARSRADIOID";

		// Token: 0x04000583 RID: 1411
		public const string NETSET_DTRTDESTRADIOID = "NETSET_DTRTDESTRADIOID";

		// Token: 0x04000584 RID: 1412
		public const string NETSET_USBINDTRTDESTRADIOID = "NETSET_USBINDTRTDESTRADIOID";

		// Token: 0x04000585 RID: 1413
		public const string NETSET_SYSTEMTYPEFORDATAMODEM = "NETSET_SYSTEMTYPEFORDATAMODEM";

		// Token: 0x04000586 RID: 1414
		public const string NETSET_WINDOWSIZEFORDATAMODEM = "NETSET_WINDOWSIZEFORDATAMODEM";

		// Token: 0x04000587 RID: 1415
		public const string PRIVACY_SERVICE_CMP_TYPE = "PRIVACY_SERVICE_CMP_TYPE";

		// Token: 0x04000588 RID: 1416
		public const string PRISVC_PKEYID = "PRISVC_PKEYID";

		// Token: 0x04000589 RID: 1417
		public const string PRISVC_PKEY = "PRISVC_PKEY";

		// Token: 0x0400058A RID: 1418
		public const string PRISVC_PKEYIND = "PRISVC_PKEYIND";

		// Token: 0x0400058B RID: 1419
		public const string PRISVC_PKEYALIAS = "PRISVC_PKEYALIAS";

		// Token: 0x0400058C RID: 1420
		public const string DIGITAL_ESS_CMP_TYPE = "DIGITAL_ESS_CMP_TYPE";

		// Token: 0x0400058D RID: 1421
		public const string DESS_EMRMOTEN = "DESS_EMRMOTEN";

		// Token: 0x0400058E RID: 1422
		public const string DESS_EMGCYALRMTYPE = "DESS_EMGCYALRMTYPE";

		// Token: 0x0400058F RID: 1423
		public const string DESS_EMALRTSEL = "DESS_EMALRTSEL";

		// Token: 0x04000590 RID: 1424
		public const string DESS_EMHOTMICDUR = "DESS_EMHOTMICDUR";

		// Token: 0x04000591 RID: 1425
		public const string DESS_EMHOTMICTXDUR = "DESS_EMHOTMICTXDUR";

		// Token: 0x04000592 RID: 1426
		public const string DESS_EMHOTMICCLCNT = "DESS_EMHOTMICCLCNT";

		// Token: 0x04000593 RID: 1427
		public const string DESS_EMHOTMICRXDUR = "DESS_EMHOTMICRXDUR";

		// Token: 0x04000594 RID: 1428
		public const string DESS_DIGITEMRVRTPERSITTYPE = "DESS_DIGITEMRVRTPERSITTYPE";

		// Token: 0x04000595 RID: 1429
		public const string DESS_DIGITEMRVRTPERSITID = "DESS_DIGITEMRVRTPERSITID";

		// Token: 0x04000596 RID: 1430
		public const string DESS_DIGITEMRVRTPERSIT = "DESS_DIGITEMRVRTPERSIT";

		// Token: 0x04000597 RID: 1431
		public const string DESS_POLITERETRYNUM = "DESS_POLITERETRYNUM";

		// Token: 0x04000598 RID: 1432
		public const string DESS_IMPOLITERETRYNUM = "DESS_IMPOLITERETRYNUM";

		// Token: 0x04000599 RID: 1433
		public const string DESS_ALIAS = "DESS_ALIAS";

		// Token: 0x0400059A RID: 1434
		public const string DESS_EMERINT = "DESS_EMERINT";

		// Token: 0x0400059B RID: 1435
		public const string TEL_CMP_TYPE_GRP = "TEL_CMP_TYPE_GRP";

		// Token: 0x0400059C RID: 1436
		public const string TEL_CMP_TYPE = "TEL_CMP_TYPE";

		// Token: 0x0400059D RID: 1437
		public const string TEL_DESC = "TEL_DESC";

		// Token: 0x0400059E RID: 1438
		public const string TEL_DUCLITEMTYPE = "TEL_DUCLITEMTYPE";

		// Token: 0x0400059F RID: 1439
		public const string TEL_DUCLITEMID = "TEL_DUCLITEMID";

		// Token: 0x040005A0 RID: 1440
		public const string TEL_DUCLITEM = "TEL_DUCLITEM";

		// Token: 0x040005A1 RID: 1441
		public const string TEL_QTXTMSGITEMTYPE = "TEL_QTXTMSGITEMTYPE";

		// Token: 0x040005A2 RID: 1442
		public const string TEL_QTXTMSGITEMID = "TEL_QTXTMSGITEMID";

		// Token: 0x040005A3 RID: 1443
		public const string TEL_QTXTMSGITEM = "TEL_QTXTMSGITEM";

		// Token: 0x040005A4 RID: 1444
		public const string TEL_TGTVIO = "TEL_TGTVIO";

		// Token: 0x040005A5 RID: 1445
		public const string TEL_IOCONFIG = "TEL_IOCONFIG";

		// Token: 0x040005A6 RID: 1446
		public const string TEL_PULWIDTH = "TEL_PULWIDTH";

		// Token: 0x040005A7 RID: 1447
		public const string JOBTICKET_STATUS_CMP_TYPE = "JOBTICKET_STATUS_CMP_TYPE";

		// Token: 0x040005A8 RID: 1448
		public const string JOBTICKET_STATUS_CMP_TYPE_GRP = "JOBTICKET_STATUS_CMP_TYPE_GRP";

		// Token: 0x040005A9 RID: 1449
		public const string JOBTICKET_DLH_TYPE_GRP = "JOBTICKET_DLH_TYPE_GRP";

		// Token: 0x040005AA RID: 1450
		public const string JOBTICKET_DLH_TYPE = "JOBTICKET_DLH_TYPE";

		// Token: 0x040005AB RID: 1451
		public const string JOBTICKET_DLL_TYPE = "JOBTICKET_DLL_TYPE";

		// Token: 0x040005AC RID: 1452
		public const string JTLDLL_JBSTSOPTITEMID = "JTLDLL_JBSTSOPTITEMID";

		// Token: 0x040005AD RID: 1453
		public const string JTLDLL_JBSTSOPTITEMTYPE = "JTLDLL_JBSTSOPTITEMTYPE";

		// Token: 0x040005AE RID: 1454
		public const string JTLDLL_JBSTSOPTITEMTYPEVALUE = "3972";

		// Token: 0x040005AF RID: 1455
		public const string JTSO_ACTSTSNUM = "JTSO_ACTSTSNUM";

		// Token: 0x040005B0 RID: 1456
		public const string JTSO_STSOPTFLDNAME = "JTSO_STSOPTFLDNAME";

		// Token: 0x040005B1 RID: 1457
		public const string JTSO_ACTRSPTXT = "JTSO_ACTRSPTXT";

		// Token: 0x040005B2 RID: 1458
		public const string JTLDLH_LSTNWJBNUM = "JTLDLH_LSTNWJBNUM";

		// Token: 0x040005B3 RID: 1459
		public const string JOBTICKET_DLH_TYPE_FTLLISHID = "JOBTICKET_DLH_TYPE_FTLLISHID";

		// Token: 0x040005B4 RID: 1460
		public const string JOBTICKET_DLH_TYPE_FTLLISHTYPE = "JOBTICKET_DLH_TYPE_FTLLISHTYPE";

		// Token: 0x040005B5 RID: 1461
		public const string ACTIONLIST_CMP_TYPE_GRP = "ACTIONLIST_CMP_TYPE_GRP";

		// Token: 0x040005B6 RID: 1462
		public const string ACTIONLIST_CMP_TYPE = "ACTIONLIST_CMP_TYPE";

		// Token: 0x040005B7 RID: 1463
		public const string ALSF_CPV = "ALSF_CPV";

		// Token: 0x040005B8 RID: 1464
		public const string ALSF_INDX = "ALSF_INDX";

		// Token: 0x040005B9 RID: 1465
		public const string TEL_MODETYPE = "TEL_MODETYPE";

		// Token: 0x040005BA RID: 1466
		public const string TEL_OTTRPITTYPE = "TEL_OTTRPITTYPE";

		// Token: 0x040005BB RID: 1467
		public const string TEL_OTTRPITID = "TEL_OTTRPITID";

		// Token: 0x040005BC RID: 1468
		public const string TEL_OTTRPIT = "TEL_OTTRPIT";

		// Token: 0x040005BD RID: 1469
		public const string MTST_MTSTHMACAUTHKY = "MTST_MTSTHMACAUTHKY";

		// Token: 0x040005BE RID: 1470
		public const string MTST_MTSTDHCPEN = "MTST_MTSTDHCPEN";

		// Token: 0x040005BF RID: 1471
		public const string MTST_MTSTETHNTIP = "MTST_MTSTETHNTIP";

		// Token: 0x040005C0 RID: 1472
		public const string MTST_MTSTETHNTIP0 = "MTST_MTSTETHNTIP0";

		// Token: 0x040005C1 RID: 1473
		public const string MTST_MTSTETHNTIP1 = "MTST_MTSTETHNTIP1";

		// Token: 0x040005C2 RID: 1474
		public const string MTST_MTSTETHNTIP2 = "MTST_MTSTETHNTIP2";

		// Token: 0x040005C3 RID: 1475
		public const string MTST_MTSTETHNTIP3 = "MTST_MTSTETHNTIP3";

		// Token: 0x040005C4 RID: 1476
		public const string MTST_MTSTSUBMASK = "MTST_MTSTSUBMASK";

		// Token: 0x040005C5 RID: 1477
		public const string MTST_MTSTSUBMASK0 = "MTST_MTSTSUBMASK0";

		// Token: 0x040005C6 RID: 1478
		public const string MTST_MTSTSUBMASK1 = "MTST_MTSTSUBMASK1";

		// Token: 0x040005C7 RID: 1479
		public const string MTST_MTSTSUBMASK2 = "MTST_MTSTSUBMASK2";

		// Token: 0x040005C8 RID: 1480
		public const string MTST_MTSTSUBMASK3 = "MTST_MTSTSUBMASK3";

		// Token: 0x040005C9 RID: 1481
		public const string MTST_MTSTGTWYIP = "MTST_MTSTGTWYIP";

		// Token: 0x040005CA RID: 1482
		public const string MTST_MTSTGTWYIP0 = "MTST_MTSTGTWYIP0";

		// Token: 0x040005CB RID: 1483
		public const string MTST_MTSTGTWYIP1 = "MTST_MTSTGTWYIP1";

		// Token: 0x040005CC RID: 1484
		public const string MTST_MTSTGTWYIP2 = "MTST_MTSTGTWYIP2";

		// Token: 0x040005CD RID: 1485
		public const string MTST_MTSTGTWYIP3 = "MTST_MTSTGTWYIP3";

		// Token: 0x040005CE RID: 1486
		public const string MTST_DHCPCLNTIPADDR = "MTST_DHCPCLNTIPADDR";

		// Token: 0x040005CF RID: 1487
		public const string MTST_MTSTPRKPALVINTVL = "MTST_MTSTPRKPALVINTVL";

		// Token: 0x040005D0 RID: 1488
		public const string MTST_MTSTHMACAUTHEN = "MTST_MTSTHMACAUTHEN";

		// Token: 0x040005D1 RID: 1489
		public const string MTST_MTSTSTKEN = "MTST_MTSTSTKEN";

		// Token: 0x040005D2 RID: 1490
		public const string MTST_MTSTITMDRYUDPPTNMBR = "MTST_MTSTITMDRYUDPPTNMBR";

		// Token: 0x040005D3 RID: 1491
		public const string MTST_MTSTITMDRYETHNTIP = "MTST_MTSTITMDRYETHNTIP";

		// Token: 0x040005D4 RID: 1492
		public const string MTST_MTSTITMDRYETHNTIP0 = "MTST_MTSTITMDRYETHNTIP0";

		// Token: 0x040005D5 RID: 1493
		public const string MTST_MTSTITMDRYETHNTIP1 = "MTST_MTSTITMDRYETHNTIP1";

		// Token: 0x040005D6 RID: 1494
		public const string MTST_MTSTITMDRYETHNTIP2 = "MTST_MTSTITMDRYETHNTIP2";

		// Token: 0x040005D7 RID: 1495
		public const string MTST_MTSTITMDRYETHNTIP3 = "MTST_MTSTITMDRYETHNTIP3";

		// Token: 0x040005D8 RID: 1496
		public const string MTST_MTSTITRMDRYEN = "MTST_MTSTITRMDRYEN";

		// Token: 0x040005D9 RID: 1497
		public const string MTST_MTSTUDPPT = "MTST_MTSTUDPPT";

		// Token: 0x040005DA RID: 1498
		public const string MTST_MTSTHMACAUTHKY_MTB = "MTST_MTSTHMACAUTHKY_MTB";

		// Token: 0x040005DB RID: 1499
		public const string MTST_MTSTETHNTIP_MTB = "MTST_MTSTETHNTIP_MTB";

		// Token: 0x040005DC RID: 1500
		public const string MTST_MTSTETHNTIP0_MTB = "MTST_MTSTETHNTIP0_MTB";

		// Token: 0x040005DD RID: 1501
		public const string MTST_MTSTETHNTIP1_MTB = "MTST_MTSTETHNTIP1_MTB";

		// Token: 0x040005DE RID: 1502
		public const string MTST_MTSTETHNTIP2_MTB = "MTST_MTSTETHNTIP2_MTB";

		// Token: 0x040005DF RID: 1503
		public const string MTST_MTSTETHNTIP3_MTB = "MTST_MTSTETHNTIP3_MTB";

		// Token: 0x040005E0 RID: 1504
		public const string MTST_MTSTUDPPT_MTB = "MTST_MTSTUDPPT_MTB";

		// Token: 0x040005E1 RID: 1505
		public const string MTST_MTSTITMDRYETHNTIP_MTB = "MTST_MTSTITMDRYETHNTIP_MTB";

		// Token: 0x040005E2 RID: 1506
		public const string MTST_MTSTITMDRYETHNTIP0_MTB = "MTST_MTSTITMDRYETHNTIP0_MTB";

		// Token: 0x040005E3 RID: 1507
		public const string MTST_MTSTITMDRYETHNTIP1_MTB = "MTST_MTSTITMDRYETHNTIP1_MTB";

		// Token: 0x040005E4 RID: 1508
		public const string MTST_MTSTITMDRYETHNTIP2_MTB = "MTST_MTSTITMDRYETHNTIP2_MTB";

		// Token: 0x040005E5 RID: 1509
		public const string MTST_MTSTITMDRYETHNTIP3_MTB = "MTST_MTSTITMDRYETHNTIP3_MTB";

		// Token: 0x040005E6 RID: 1510
		public const string MTST_MTSTITMDRYUDPPTNMBR_MTB = "MTST_MTSTITMDRYUDPPTNMBR_MTB";

		// Token: 0x040005E7 RID: 1511
		public const string MTST_MTSTPRKPALVINTVL_MTB = "MTST_MTSTPRKPALVINTVL_MTB";

		// Token: 0x040005E8 RID: 1512
		public const string MTST_CMP_TYPE = "MTST_CMP_TYPE";

		// Token: 0x040005E9 RID: 1513
		public const string MTST_CMP_TYPE_PARENT = "MTST_CMP_TYPE_PARENT";

		// Token: 0x040005EA RID: 1514
		public const string NCSB_RTC_SOURCE1 = "NCSB_RTC_SOURCE1";

		// Token: 0x040005EB RID: 1515
		public const string NCSB_RTC_SOURCE2 = "NCSB_RTC_SOURCE2";

		// Token: 0x040005EC RID: 1516
		public const string NCSB_RTC_REFRESH_INTERVAL1 = "NCSB_RTC_REFRESH_INTERVAL1";

		// Token: 0x040005ED RID: 1517
		public const string NCSB_RTC_REFRESH_INTERVAL2 = "NCSB_RTC_REFRESH_INTERVAL2";

		// Token: 0x040005EE RID: 1518
		public const string RC_BEACONDUR = "RC_BEACONDUR";

		// Token: 0x040005EF RID: 1519
		public const string RC_BEACONINT = "RC_BEACONINT";

		// Token: 0x040005F0 RID: 1520
		public const string CP_HOTKEYPAD = "CP_HOTKEYPAD";

		// Token: 0x040005F1 RID: 1521
		public const string RC_IMBCVINDCT = "RC_IMBCVINDCT";

		// Token: 0x040005F2 RID: 1522
		public const string CHOICE_NO_INDICATION = "NOINDICATIONDISABLE";

		// Token: 0x040005F3 RID: 1523
		public const string CHOICE_ALERT_ONLY = "ALERTONLY";

		// Token: 0x040005F4 RID: 1524
		public const string CHOICE_DISPLAY_ONLY = "DISPLAYONLY";

		// Token: 0x040005F5 RID: 1525
		public const string CHOICE_ALERT_DISPLAY = "ALERTDISPLAY";

		// Token: 0x040005F6 RID: 1526
		public const string CHOICE_SMARTZONE = "SMARTZONE";

		// Token: 0x040005F7 RID: 1527
		public const string CHOICE_SMARTNET = "SMARTNET";

		// Token: 0x040005F8 RID: 1528
		public const string CHOICE_CONV_SCAN = "CONVENTIONALSCAN";

		// Token: 0x040005F9 RID: 1529
		public const string CHOICE_PRIORITY_SCAN = "PRIORITYSCAN";

		// Token: 0x040005FA RID: 1530
		public const string CHOICE_TALKGROUP_SCAN = "TALKGROUPSCAN";

		// Token: 0x040005FB RID: 1531
		public const string CHOICE_AUTO = "AUTO";

		// Token: 0x040005FC RID: 1532
		public const string RC_PHDLOP = "RC_PHDLOP";

		// Token: 0x040005FD RID: 1533
		public const string RC_DTMFPTM = "RC_DTMFPTM";

		// Token: 0x040005FE RID: 1534
		public const string RC_UNRWIFFILTER = "RC_UNRWIFFILTER";

		// Token: 0x040005FF RID: 1535
		public const string RC_PRVCYSVCTP = "RC_PRVCYSVCTP";

		// Token: 0x04000600 RID: 1536
		public const string CP_ENHCPRVCYIT = "CP_ENHCPRVCYIT";

		// Token: 0x04000601 RID: 1537
		public const string CP_ENHCPRVCYITTYPE = "CP_ENHCPRVCYITTYPE";

		// Token: 0x04000602 RID: 1538
		public const string CP_ENHCPRVCYITID = "CP_ENHCPRVCYITID";

		// Token: 0x04000603 RID: 1539
		public const string CP_MLTSTPSNLTIND = "CP_MLTSTPSNLTIND";

		// Token: 0x04000604 RID: 1540
		public const string CP_PRVTCLSTPOP = "CP_PRVTCLSTPOP";

		// Token: 0x04000605 RID: 1541
		public const string CP_INTRPTMSGDLY = "CP_INTRPTMSGDLY";

		// Token: 0x04000606 RID: 1542
		public const string CP_INTRPTMSGDLY_RPTR = "CP_INTRPTMSGDLY_RPTR";

		// Token: 0x04000607 RID: 1543
		public const string CP_SCNROAMLISTIT = "CP_SCNROAMLISTIT";

		// Token: 0x04000608 RID: 1544
		public const string CP_AUTOSCNRMEN = "CP_AUTOSCNRMEN";

		// Token: 0x04000609 RID: 1545
		public const string CP_STSRCHLSTITID = "CP_STSRCHLSTITID";

		// Token: 0x0400060A RID: 1546
		public const string CP_STSRCHLSTITTYPE = "CP_STSRCHLSTITTYPE";

		// Token: 0x0400060B RID: 1547
		public const string ST_SRCH_DLH_TYPE = "ST_SRCH_DLH_TYPE";

		// Token: 0x0400060C RID: 1548
		public const string ST_SRCH_DLH_TYPE_GRP = "ST_SRCH_DLH_TYPE_GRP";

		// Token: 0x0400060D RID: 1549
		public const string SSP_CNVPERCOMPTYPE = "SSP_CNVPERCOMPTYPE";

		// Token: 0x0400060E RID: 1550
		public const string SSP_CNVPERCOMPID = "SSP_CNVPERCOMPID";

		// Token: 0x0400060F RID: 1551
		public const string SSP_CNVPERCOMP = "SSP_CNVPERCOMP";

		// Token: 0x04000610 RID: 1552
		public const string SSP_RSSITHRFORROAM = "SSP_RSSITHRFORROAM";

		// Token: 0x04000611 RID: 1553
		public const string CP_MLTSTSLTEN = "CP_MLTSTSLTEN";

		// Token: 0x04000612 RID: 1554
		public const string CP_MTSTFCCTP1RSSITHRSHD = "CP_MTSTFCCTP1RSSITHRSHD";

		// Token: 0x04000613 RID: 1555
		public const string CP_MTSTFCCTP1RSSITHRSHD_SUBS = "CP_MTSTFCCTP1RSSITHRSHD_SUBS";

		// Token: 0x04000614 RID: 1556
		public const string ST_SRCH_DLT_TYPE = "ST_SRCH_DLT_TYPE";

		// Token: 0x04000615 RID: 1557
		public const string ST_SRCH_DLL_TYPE = "ST_SRCH_DLL_TYPE";

		// Token: 0x04000616 RID: 1558
		public const string SSP_SCANLISTALIAS = "SSP_SCANLISTALIAS";

		// Token: 0x04000617 RID: 1559
		public const string SSP_ROAMMEMBERS = "SSP_ROAMMEMBERS";

		// Token: 0x04000618 RID: 1560
		public const string ENHPRI_CMP_TYPE = "ENHPRI_CMP_TYPE";

		// Token: 0x04000619 RID: 1561
		public const string ENHPRI_PKEYID = "ENHPRI_PKEYID";

		// Token: 0x0400061A RID: 1562
		public const string ENHPRI_PKEY = "ENHPRI_PKEY";

		// Token: 0x0400061B RID: 1563
		public const string ENHPRI_PKEYALIAS = "ENHPRI_PKEYALIAS";

		// Token: 0x0400061C RID: 1564
		public const string CS_CFS = "CS_CFS";

		// Token: 0x0400061D RID: 1565
		public const string CS_RADIOTYPE = "CS_RADIOTYPE";

		// Token: 0x0400061E RID: 1566
		public const string CS_FWVER = "CS_FWVER";

		// Token: 0x0400061F RID: 1567
		public const string CS_FWTYPE = "CS_FWTYPE";

		// Token: 0x04000620 RID: 1568
		public const string CS_FWID = "CS_FWID";

		// Token: 0x04000621 RID: 1569
		public const string CS_FWDTPEN = "CS_FWDTPEN";

		// Token: 0x04000622 RID: 1570
		public const string CS_PHYSICALSERIALNUM = "CS_PHYSICALSERIALNUM";

		// Token: 0x04000623 RID: 1571
		public const string CS_MACADDRESS = "CS_MACADDRESS";

		// Token: 0x04000624 RID: 1572
		public const string CS_MACADDRESSETH2 = "CS_MACADDRESSETH2";

		// Token: 0x04000625 RID: 1573
		public const string CS_MACADDRESSWIFI = "CS_MACADDRESSWIFI";

		// Token: 0x04000626 RID: 1574
		public const string ACTIVE_ATTRIBUTE = "active";

		// Token: 0x04000627 RID: 1575
		public const string FlashSize = "CS_FLASH_SIZE";

		// Token: 0x04000628 RID: 1576
		public const string DG_SLMEM = "DG_SLMEM";

		// Token: 0x04000629 RID: 1577
		public const string DG_SLAVAIL = "DG_SLAVAIL";

		// Token: 0x0400062A RID: 1578
		public const string DG_CPLUSAVAIL = "DG_CPLUSAVAIL";

		// Token: 0x0400062B RID: 1579
		public const string DG_CPLUSMEM = "DG_CPLUSMEM";

		// Token: 0x0400062C RID: 1580
		public const string DG_DRAVAIL = "DG_DRAVAIL";

		// Token: 0x0400062D RID: 1581
		public const string DG_DRMEM = "DG_DRMEM";

		// Token: 0x0400062E RID: 1582
		public const string DG_RLAVAIL = "DG_RLAVAIL";

		// Token: 0x0400062F RID: 1583
		public const string DG_RLMEM = "DG_RLMEM";

		// Token: 0x04000630 RID: 1584
		public const string SLOT_IDS = "SLOT_IDS";

		// Token: 0x04000631 RID: 1585
		public const string DG_TGAVAIL = "DG_TGAVAIL";

		// Token: 0x04000632 RID: 1586
		public const string DG_TGMEM = "DG_TGMEM";

		// Token: 0x04000633 RID: 1587
		public const string DG_TGCAPPLUSAVAIL = "DG_TGCAPPLUSAVAIL";

		// Token: 0x04000634 RID: 1588
		public const string DG_TGCAPPLUSMEM = "DG_TGCAPPLUSMEM";

		// Token: 0x04000635 RID: 1589
		public const string DRAGCHNLINFO = "DRAGCHNLINFO";

		// Token: 0x04000636 RID: 1590
		public const string DRAGZNINFO = "DRAGZNINFO";

		// Token: 0x04000637 RID: 1591
		public const string CB_BTNSHORT = "CB_BTNSHORT";

		// Token: 0x04000638 RID: 1592
		public const string CB_BTNLONG = "CB_BTNLONG";

		// Token: 0x04000639 RID: 1593
		public const string CB_ACCYBTNSHORT = "CB_ACCYBTNSHORT";

		// Token: 0x0400063A RID: 1594
		public const string CB_ACCYBTNLONG = "CB_ACCYBTNLONG";

		// Token: 0x0400063B RID: 1595
		public const string CP_TRUNKCHANLISTITID = "CP_TRUNKCHANLISTITID";

		// Token: 0x0400063C RID: 1596
		public const string CP_TRUNKCHANLISTIT = "CP_TRUNKCHANLISTIT";

		// Token: 0x0400063D RID: 1597
		public const string CP_TRUNKCHANLISTITTYPE = "CP_TRUNKCHANLISTITTYPE";

		// Token: 0x0400063E RID: 1598
		public const string CP_DATAREVCHANLISTITID = "CP_DATAREVCHANLISTITID";

		// Token: 0x0400063F RID: 1599
		public const string CP_DATAREVCHANLISTIT = "CP_DATAREVCHANLISTIT";

		// Token: 0x04000640 RID: 1600
		public const string DATAREVERT_PERSIT = "DATAREVERT_PERSIT";

		// Token: 0x04000641 RID: 1601
		public const string DATAREVERT_PERSITID = "DATAREVERT_PERSITID";

		// Token: 0x04000642 RID: 1602
		public const string DATAREVERT_PERSITTYPE = "DATAREVERT_PERSITTYPE";

		// Token: 0x04000643 RID: 1603
		public const string DATAREVERT_LISTMEMBERS = "DATAREVERT_LISTMEMBERS";

		// Token: 0x04000644 RID: 1604
		public const string TP_PERSIT = "TP_PERSIT";

		// Token: 0x04000645 RID: 1605
		public const string TP_PERSITID = "TP_PERSITID";

		// Token: 0x04000646 RID: 1606
		public const string TP_PERSITTYPE = "TP_PERSITTYPE";

		// Token: 0x04000647 RID: 1607
		public const string TP_LISTMEMBERS = "TP_LISTMEMBERS";

		// Token: 0x04000648 RID: 1608
		public const string CP_CAPPLUSCONFENA = "CP_CAPPLUSCONFENA";

		// Token: 0x04000649 RID: 1609
		public const string CP_DATAREVEN = "CP_DATAREVEN";

		// Token: 0x0400064A RID: 1610
		public const string TRUNK_PER_LIST_DLT_TYPE = "TRUNK_PER_LIST_DLT_TYPE";

		// Token: 0x0400064B RID: 1611
		public const string TRUNK_PER_LIST_DLH_TYPE = "TRUNK_PER_LIST_DLH_TYPE";

		// Token: 0x0400064C RID: 1612
		public const string TRUNK_PER_LIST_DLL_TYPE = "TRUNK_PER_LIST_DLL_TYPE";

		// Token: 0x0400064D RID: 1613
		public const string TRUNK_PER_LIST_DLH_TYPE_GRP = "TRUNK_PER_LIST_DLH_TYPE_GRP";

		// Token: 0x0400064E RID: 1614
		public const string DATA_REVERT_PER_LIST_DLT_TYPE = "DATA_REVERT_PER_LIST_DLT_TYPE";

		// Token: 0x0400064F RID: 1615
		public const string DATA_REVERT_PER_LIST_DLH_TYPE = "DATA_REVERT_PER_LIST_DLH_TYPE";

		// Token: 0x04000650 RID: 1616
		public const string DATA_REVERT_PER_LIST_DLL_TYPE = "DATA_REVERT_PER_LIST_DLL_TYPE";

		// Token: 0x04000651 RID: 1617
		public const string DATA_REVERT_PER_LIST_DLH_TYPE_GRP = "DATA_REVERT_PER_LIST_DLH_TYPE_GRP";

		// Token: 0x04000652 RID: 1618
		public const string DATAREVERT_TRUNKPERALIAS = "DATAREVERT_TRUNKPERALIAS";

		// Token: 0x04000653 RID: 1619
		public const string TP_TRUNKPERALIAS = "TP_TRUNKPERALIAS";

		// Token: 0x04000654 RID: 1620
		public const string CP_CAPPLUSCHANNUMSLOT1 = "CP_CAPPLUSCHANNUMSLOT1";

		// Token: 0x04000655 RID: 1621
		public const string CP_CAPPLUSCHANNUMSLOT2 = "CP_CAPPLUSCHANNUMSLOT2";

		// Token: 0x04000656 RID: 1622
		public const string RXTG_MODETYPE = "RXTG_MODETYPE";

		// Token: 0x04000657 RID: 1623
		public const string DU_UCLCONTACTMODETYPE = "DU_UCLCONTACTMODETYPE";

		// Token: 0x04000658 RID: 1624
		public const string RXTG_CAPPLUSDGUCLCOMP = "RXTG_CAPPLUSDGUCLCOMP";

		// Token: 0x04000659 RID: 1625
		public const string CAPPLUS_RXTG_UCLCOMP = "CAPPLUS_RXTG_UCLCOMP";

		// Token: 0x0400065A RID: 1626
		public const string RXTG_LISTMEMBERS = "RXTG_LISTMEMBERS";

		// Token: 0x0400065B RID: 1627
		public const string CAPPLUS_RXTG_LISTMEMBERS = "CAPPLUS_RXTG_LISTMEMBERS";

		// Token: 0x0400065C RID: 1628
		public const string CP_CAPPLUSESYSITEM = "CP_CAPPLUSESYSITEM";

		// Token: 0x0400065D RID: 1629
		public const string CP_CAPPLUSESYSITEMTYPE = "CP_CAPPLUSESYSITEMTYPE";

		// Token: 0x0400065E RID: 1630
		public const string CP_CAPPLUSESYSITEMID = "CP_CAPPLUSESYSITEMID";

		// Token: 0x0400065F RID: 1631
		public const string CAPPLUSUCL_CALLLSTID = "CAPPLUSUCL_CALLLSTID";

		// Token: 0x04000660 RID: 1632
		public const string CP_TXCOMPUDPIPHEADEN = "CP_TXCOMPUDPIPHEADEN";

		// Token: 0x04000661 RID: 1633
		public const string CP_CAPPLUSPREFLEV = "CP_CAPPLUSPREFLEV";

		// Token: 0x04000662 RID: 1634
		public const string CP_LOSTAUDTONEINTERVAL = "CP_LOSTAUDTONEINTERVAL";

		// Token: 0x04000663 RID: 1635
		public const string CP_CAPPLUSBEACONINTERVAL = "CP_CAPPLUSBEACONINTERVAL";

		// Token: 0x04000664 RID: 1636
		public const string CP_DEVMEDFORINDDATACALL = "CP_DEVMEDFORINDDATACALL";

		// Token: 0x04000665 RID: 1637
		public const string CP_CAPPLUSUKPCALLITEMID = "CP_CAPPLUSUKPCALLITEMID";

		// Token: 0x04000666 RID: 1638
		public const string CP_CAPPLUSUKPCALLITEM = "CP_CAPPLUSUKPCALLITEM";

		// Token: 0x04000667 RID: 1639
		public const string CP_CAPPLUSTALKGRPLISTITEMID = "CP_CAPPLUSTALKGRPLISTITEMID";

		// Token: 0x04000668 RID: 1640
		public const string CP_CAPPLUSTALKGRPLISTITEM = "CP_CAPPLUSTALKGRPLISTITEM";

		// Token: 0x04000669 RID: 1641
		public const string CAPPLUSESS_CAPPLUSECALLIDITEMID = "CAPPLUSESS_CAPPLUSECALLIDITEMID";

		// Token: 0x0400066A RID: 1642
		public const string CAPPLUSESS_CAPPLUSECALLIDITEM = "CAPPLUSESS_CAPPLUSECALLIDITEM";

		// Token: 0x0400066B RID: 1643
		public const string CAPPLUSESS_CAPPLUSECALLIDITEMTYPE = "CAPPLUSESS_CAPPLUSECALLIDITEMTYPE";

		// Token: 0x0400066C RID: 1644
		public const string CAPPLUSUCL_CALLTYPE = "CAPPLUSUCL_CALLTYPE";

		// Token: 0x0400066D RID: 1645
		public const string CAPPLUSUCL_CALLALIAS = "CAPPLUSUCL_CALLALIAS";

		// Token: 0x0400066E RID: 1646
		public const string CAPPLUSUCL_UKPOTCFLG = "CAPPLUSUCL_UKPOTCFLG";

		// Token: 0x0400066F RID: 1647
		public const string CAPACITY_PLUS_UCL_DLT_TYPE = "CAPACITY_PLUS_UCL_DLT_TYPE";

		// Token: 0x04000670 RID: 1648
		public const string CAPACITY_PLUS_UCL_DLH_TYPE = "CAPACITY_PLUS_UCL_DLH_TYPE";

		// Token: 0x04000671 RID: 1649
		public const string CAPACITY_PLUS_UCL_DLL_TYPE = "CAPACITY_PLUS_UCL_DLL_TYPE";

		// Token: 0x04000672 RID: 1650
		public const string CAPACITY_PLUS_UCL_DLH_TYPE_GRP = "CAPACITY_PLUS_UCL_DLH_TYPE_GRP";

		// Token: 0x04000673 RID: 1651
		public const string CAPPLUS_RXTG_UCLCOMPID = "CAPPLUS_RXTG_UCLCOMPID";

		// Token: 0x04000674 RID: 1652
		public const string CAPPLUS_RXTG_UCLCOMPTYPE = "CAPPLUS_RXTG_UCLCOMPTYPE";

		// Token: 0x04000675 RID: 1653
		public const string CAPPLUS_RXTG_RXTGLISTALIAS = "CAPPLUS_RXTG_RXTGLISTALIAS";

		// Token: 0x04000676 RID: 1654
		public const string CAPPLUS_RX_TG_LIST_DLL_TYPE = "CAPPLUS_RX_TG_LIST_DLL_TYPE";

		// Token: 0x04000677 RID: 1655
		public const string CAPPLUS_RX_TG_LIST_DLT_TYPE = "CAPPLUS_RX_TG_LIST_DLT_TYPE";

		// Token: 0x04000678 RID: 1656
		public const string CAPPLUS_RX_TG_LIST_DLH_TYPE = "CAPPLUS_RX_TG_LIST_DLH_TYPE";

		// Token: 0x04000679 RID: 1657
		public const string CAPPLUS_RX_TG_LIST_DLH_TYPE_GRP = "CAPPLUS_RX_TG_LIST_DLH_TYPE_GRP";

		// Token: 0x0400067A RID: 1658
		public const string CAPACITY_PLUS_ESS_CMP_TYPE = "CAPACITY_PLUS_ESS_CMP_TYPE";

		// Token: 0x0400067B RID: 1659
		public const string CAPACITY_PLUS_ESS_CMP_TYPE_GRP = "CAPACITY_PLUS_ESS_CMP_TYPE_GRP";

		// Token: 0x0400067C RID: 1660
		public const string CAPPLUSUCL_RINGTYPE = "CAPPLUSUCL_RINGTYPE";

		// Token: 0x0400067D RID: 1661
		public const string CAPPLUSUCL_CALLPRCDTNEN = "CAPPLUSUCL_CALLPRCDTNEN";

		// Token: 0x0400067E RID: 1662
		public const string CAPPLUSUCL_TXTMSGALTTNTP = "CAPPLUSUCL_TXTMSGALTTNTP";

		// Token: 0x0400067F RID: 1663
		public const string CAPPLUSESS_EMGCYALRMTYPE = "CAPPLUSESS_EMGCYALRMTYPE";

		// Token: 0x04000680 RID: 1664
		public const string CAPPLUSESS_EMALRTSEL = "CAPPLUSESS_EMALRTSEL";

		// Token: 0x04000681 RID: 1665
		public const string CAPPLUSESS_EMHOTMICDUR = "CAPPLUSESS_EMHOTMICDUR";

		// Token: 0x04000682 RID: 1666
		public const string CAPPLUSESS_EMHOTMICTXDUR = "CAPPLUSESS_EMHOTMICTXDUR";

		// Token: 0x04000683 RID: 1667
		public const string CAPPLUSESS_EMHOTMICCLCNT = "CAPPLUSESS_EMHOTMICCLCNT";

		// Token: 0x04000684 RID: 1668
		public const string CAPPLUSESS_EMHOTMICRXDUR = "CAPPLUSESS_EMHOTMICRXDUR";

		// Token: 0x04000685 RID: 1669
		public const string CAPPLUSESS_POLITERETRYNUM = "CAPPLUSESS_POLITERETRYNUM";

		// Token: 0x04000686 RID: 1670
		public const string CAPPLUSUCL_ROUTETYPE = "CAPPLUSUCL_ROUTETYPE";

		// Token: 0x04000687 RID: 1671
		public const string OPTIONBOARD = "OPTIONBOARD";

		// Token: 0x04000688 RID: 1672
		public const string NONIP_PERIPHERAL = "NONIP_PERIPHERAL";

		// Token: 0x04000689 RID: 1673
		public const string BROADCAST = "BROADCAST";

		// Token: 0x0400068A RID: 1674
		public const string CAPPLUSESS_ALIAS = "CAPPLUSESS_ALIAS";

		// Token: 0x0400068B RID: 1675
		public const string CAPPLUSESS_EMERINT = "CAPPLUSESS_EMERINT";

		// Token: 0x0400068C RID: 1676
		public const string CAPPLUSUCL_CONNECTTYPE = "CAPPLUSUCL_CONNECTTYPE";

		// Token: 0x0400068D RID: 1677
		public const string CP_OBTRUNKMODE = "CP_OBTRUNKMODE";

		// Token: 0x0400068E RID: 1678
		public const string CP_LONEWORKEN = "CP_LONEWORKEN";

		// Token: 0x0400068F RID: 1679
		public const string OTC_CALLMODETYPE = "OTC_CALLMODETYPE";

		// Token: 0x04000690 RID: 1680
		public const string OTC_5TONEBTN = "OTC_5TONEBTN";

		// Token: 0x04000691 RID: 1681
		public const string RC_BATTERYSAVEPREEN = "RC_BATTERYSAVEPREEN";

		// Token: 0x04000692 RID: 1682
		public const string RC_SAVEPLRRPREQ = "RC_SAVEPLRRPREQ";

		// Token: 0x04000693 RID: 1683
		public const string RC_DELPERSISLRRPREQ = "RC_DELPERSISLRRPREQ";

		// Token: 0x04000694 RID: 1684
		public const string OTC_HMREVTITEM = "OTC_HMREVTITEM";

		// Token: 0x04000695 RID: 1685
		public const string OTC_HMREVTITEMTYPE = "OTC_HMREVTITEMTYPE";

		// Token: 0x04000696 RID: 1686
		public const string OTC_HMREVTITEMID = "OTC_HMREVTITEMID";

		// Token: 0x04000697 RID: 1687
		public const string QCII_UCL_DLH_TYPE = "QCII_UCL_DLH_TYPE";

		// Token: 0x04000698 RID: 1688
		public const string QCII_UCL_DLL_TYPE = "QCII_UCL_DLL_TYPE";

		// Token: 0x04000699 RID: 1689
		public const string QCII_UCL_DLT_TYPE = "QCII_UCL_DLT_TYPE";

		// Token: 0x0400069A RID: 1690
		public const string QCII_UCL_DLH_TYPE_GRP = "QCII_UCL_DLH_TYPE_GRP";

		// Token: 0x0400069B RID: 1691
		public const string QU_LSTCTG = "QU_LSTCTG";

		// Token: 0x0400069C RID: 1692
		public const string QU_LEDSZ = "QU_LEDSZ";

		// Token: 0x0400069D RID: 1693
		public const string QU_LEQMAX = "QU_LEQMAX";

		// Token: 0x0400069E RID: 1694
		public const string QU_LLEQMAX = "QU_LLEQMAX";

		// Token: 0x0400069F RID: 1695
		public const string QU_LLEQ = "QU_LLEQ";

		// Token: 0x040006A0 RID: 1696
		public const string QU_ALPHNUMSRCHEN = "QU_ALPHNUMSRCHEN";

		// Token: 0x040006A1 RID: 1697
		public const string QU_CALLFORMAT = "QU_CALLFORMAT";

		// Token: 0x040006A2 RID: 1698
		public const string QU_TONEATXFRE = "QU_TONEATXFRE";

		// Token: 0x040006A3 RID: 1699
		public const string QU_TONEBTXFRE = "QU_TONEBTXFRE";

		// Token: 0x040006A4 RID: 1700
		public const string QU_STRIPPLDPL = "QU_STRIPPLDPL";

		// Token: 0x040006A5 RID: 1701
		public const string QU_RVRTPERS = "QU_RVRTPERS";

		// Token: 0x040006A6 RID: 1702
		public const string QU_RVRTPERSTYPE = "QU_RVRTPERSTYPE";

		// Token: 0x040006A7 RID: 1703
		public const string QU_RVRTPERSID = "QU_RVRTPERSID";

		// Token: 0x040006A8 RID: 1704
		public const string QU_CALLENTRYALIAS = "QU_CALLENTRYALIAS";

		// Token: 0x040006A9 RID: 1705
		public const string QU_QCIISYS = "QU_QCIISYS";

		// Token: 0x040006AA RID: 1706
		public const string QU_QCIISYSTYPE = "QU_QCIISYSTYPE";

		// Token: 0x040006AB RID: 1707
		public const string QU_QCIISYSID = "QU_QCIISYSID";

		// Token: 0x040006AC RID: 1708
		public const string QU_CODEA = "QU_CODEA";

		// Token: 0x040006AD RID: 1709
		public const string QU_CODEB = "QU_CODEB";

		// Token: 0x040006AE RID: 1710
		public const string RC_SECAHTTIMER = "RC_SECAHTTIMER";

		// Token: 0x040006AF RID: 1711
		public const string RC_QCIISELCALLENCODE = "RC_QCIISELCALLENCODE";

		// Token: 0x040006B0 RID: 1712
		public const string RC_SELCALLID = "RC_SELCALLID";

		// Token: 0x040006B1 RID: 1713
		public const string RC_QCIIBASICSELCALL = "RC_QCIIBASICSELCALL";

		// Token: 0x040006B2 RID: 1714
		public const string RC_QCIICALLALERTENCODE = "RC_QCIICALLALERTENCODE";

		// Token: 0x040006B3 RID: 1715
		public const string RC_QCIIAUTORESETTIMER = "RC_QCIIAUTORESETTIMER";

		// Token: 0x040006B4 RID: 1716
		public const string QCII_SYS_CMP_TYPE = "QCII_SYS_CMP_TYPE";

		// Token: 0x040006B5 RID: 1717
		public const string QCII_SYS_CMP_TYPE_GRP = "QCII_SYS_CMP_TYPE_GRP";

		// Token: 0x040006B6 RID: 1718
		public const string QCIISYS_LTONEDURAT = "QCIISYS_LTONEDURAT";

		// Token: 0x040006B7 RID: 1719
		public const string QCIISYS_SYSPRETIME = "QCIISYS_SYSPRETIME";

		// Token: 0x040006B8 RID: 1720
		public const string QCIISYS_PTTSTTYPE = "QCIISYS_PTTSTTYPE";

		// Token: 0x040006B9 RID: 1721
		public const string QCIISYS_TONEARF = "QCIISYS_TONEARF";

		// Token: 0x040006BA RID: 1722
		public const string QCIISYS_TONEBRF = "QCIISYS_TONEBRF";

		// Token: 0x040006BB RID: 1723
		public const string QCIISYS_TONECRF = "QCIISYS_TONECRF";

		// Token: 0x040006BC RID: 1724
		public const string QCIISYS_TONEDRF = "QCIISYS_TONEDRF";

		// Token: 0x040006BD RID: 1725
		public const string QCIISYS_FORMATTYPE = "QCIISYS_FORMATTYPE";

		// Token: 0x040006BE RID: 1726
		public const string QCIISYS_CALLTYPE = "QCIISYS_CALLTYPE";

		// Token: 0x040006BF RID: 1727
		public const string QCIISYS_ARTIMERTYPE = "QCIISYS_ARTIMERTYPE";

		// Token: 0x040006C0 RID: 1728
		public const string QCIISYS_LTDPTCTIME = "QCIISYS_LTDPTCTIME";

		// Token: 0x040006C1 RID: 1729
		public const string QCIISYS_QCIISYSALIAS = "QCIISYS_QCIISYSALIAS";

		// Token: 0x040006C2 RID: 1730
		public const string QCIISYS_CODEA = "QCIISYS_CODEA";

		// Token: 0x040006C3 RID: 1731
		public const string QCIISYS_CODEB = "QCIISYS_CODEB";

		// Token: 0x040006C4 RID: 1732
		public const string QCIISYS_CODEC = "QCIISYS_CODEC";

		// Token: 0x040006C5 RID: 1733
		public const string QCIISYS_CODED = "QCIISYS_CODED";

		// Token: 0x040006C6 RID: 1734
		public const string CP_VOICECALLINT = "CP_VOICECALLINT";

		// Token: 0x040006C7 RID: 1735
		public const string CP_OPONTICH = "CP_OPONTICH";

		// Token: 0x040006C8 RID: 1736
		public const string TRANSMITTER_INTERRUPT = "TRANSMITTER_INTERRUPT";

		// Token: 0x040006C9 RID: 1737
		public const string HOME_REVERT = "HOME_REVERT";

		// Token: 0x040006CA RID: 1738
		public const string CALLFMT_AB = "CALLFMT_AB";

		// Token: 0x040006CB RID: 1739
		public const string CALLFMT_AB_AC = "CALLFMT_AB_AC";

		// Token: 0x040006CC RID: 1740
		public const string CALLFMT_AB_CB = "CALLFMT_AB_CB";

		// Token: 0x040006CD RID: 1741
		public const string CALLFMT_AB_LONG_B = "CALLFMT_AB_LONG_B";

		// Token: 0x040006CE RID: 1742
		public const string CALLFMT_AB_LONG_C = "CALLFMT_AB_LONG_C";

		// Token: 0x040006CF RID: 1743
		public const string CALLFMT_AB_AC_LONG_C = "CALLFMT_AB_AC_LONG_C";

		// Token: 0x040006D0 RID: 1744
		public const string CALLFMT_AB_LONG_B_LONG_C = "CALLFMT_AB_LONG_B_LONG_C";

		// Token: 0x040006D1 RID: 1745
		public const string CALLFMT_AB_AC_LONG_B_LONG_C = "CALLFMT_AB_AC_LONG_B_LONG_C";

		// Token: 0x040006D2 RID: 1746
		public const string CALLFMT_AB_AD_CD = "CALLFMT_AB_AD_CD";

		// Token: 0x040006D3 RID: 1747
		public const string CALLFMT_AB_CD = "CALLFMT_AB_CD";

		// Token: 0x040006D4 RID: 1748
		public const string CALLALRT_WVOICE = "CALLALRT_WVOICE";

		// Token: 0x040006D5 RID: 1749
		public const string SELECTIVE_CALL = "SELECTIVE_CALL";

		// Token: 0x040006D6 RID: 1750
		public const string MANUAL = "MANUAL";

		// Token: 0x040006D7 RID: 1751
		public const string AUTO_RESET_CARR_OVRD = "AUTO_RESET_CARR_OVRD";

		// Token: 0x040006D8 RID: 1752
		public const string AUTO_RESET_WO_CARR_OVRD = "AUTO_RESET_WO_CARR_OVRD";

		// Token: 0x040006D9 RID: 1753
		public const string SDTONE_DISABLE = "SDTONE_DISABLE";

		// Token: 0x040006DA RID: 1754
		public const string TWO_TONE = "TWO_TONE";

		// Token: 0x040006DB RID: 1755
		public const string LONG_TONE = "LONG_TONE";

		// Token: 0x040006DC RID: 1756
		public const string REMOTE_VOICE_DEKEY = "REMOTE_VOICE_DEKEY";

		// Token: 0x040006DD RID: 1757
		public const string AC_GPIO1FS_BANDIT = "AC_GPIO1FS_BANDIT";

		// Token: 0x040006DE RID: 1758
		public const string AC_GPIO1AL_BANDIT = "AC_GPIO1AL_BANDIT";

		// Token: 0x040006DF RID: 1759
		public const string AC_GPIO1DB_BANDIT = "AC_GPIO1DB_BANDIT";

		// Token: 0x040006E0 RID: 1760
		public const string AC_GPIO2FS_BANDIT = "AC_GPIO2FS_BANDIT";

		// Token: 0x040006E1 RID: 1761
		public const string AC_GPIO2AL_BANDIT = "AC_GPIO2AL_BANDIT";

		// Token: 0x040006E2 RID: 1762
		public const string AC_GPIO2DB_BANDIT = "AC_GPIO2DB_BANDIT";

		// Token: 0x040006E3 RID: 1763
		public const string AC_GPIO3FS_BANDIT = "AC_GPIO3FS_BANDIT";

		// Token: 0x040006E4 RID: 1764
		public const string AC_GPIO3AL_BANDIT = "AC_GPIO3AL_BANDIT";

		// Token: 0x040006E5 RID: 1765
		public const string AC_GPIO3DB_BANDIT = "AC_GPIO3DB_BANDIT";

		// Token: 0x040006E6 RID: 1766
		public const string AC_GPIO4FS_BANDIT = "AC_GPIO4FS_BANDIT";

		// Token: 0x040006E7 RID: 1767
		public const string AC_GPIO4AL_BANDIT = "AC_GPIO4AL_BANDIT";

		// Token: 0x040006E8 RID: 1768
		public const string AC_GPIO4DB_BANDIT = "AC_GPIO4DB_BANDIT";

		// Token: 0x040006E9 RID: 1769
		public const string AC_GPIO5FS_BANDIT = "AC_GPIO5FS_BANDIT";

		// Token: 0x040006EA RID: 1770
		public const string AC_GPIO5AL_BANDIT = "AC_GPIO5AL_BANDIT";

		// Token: 0x040006EB RID: 1771
		public const string AC_GPIO5DB_BANDIT = "AC_GPIO5DB_BANDIT";

		// Token: 0x040006EC RID: 1772
		public const string AC_GPIO6FS_BANDIT = "AC_GPIO6FS_BANDIT";

		// Token: 0x040006ED RID: 1773
		public const string AC_GPIO6AL_BANDIT = "AC_GPIO6AL_BANDIT";

		// Token: 0x040006EE RID: 1774
		public const string AC_GPIO6DB_BANDIT = "AC_GPIO6DB_BANDIT";

		// Token: 0x040006EF RID: 1775
		public const string AC_GPIO7FS_BANDIT = "AC_GPIO7FS_BANDIT";

		// Token: 0x040006F0 RID: 1776
		public const string AC_GPIO7AL_BANDIT = "AC_GPIO7AL_BANDIT";

		// Token: 0x040006F1 RID: 1777
		public const string AC_GPIO7DB_BANDIT = "AC_GPIO7DB_BANDIT";

		// Token: 0x040006F2 RID: 1778
		public const string AC_GPIO8FS_BANDIT = "AC_GPIO8FS_BANDIT";

		// Token: 0x040006F3 RID: 1779
		public const string AC_GPIO8AL_BANDIT = "AC_GPIO8AL_BANDIT";

		// Token: 0x040006F4 RID: 1780
		public const string AC_GPIO8DB_BANDIT = "AC_GPIO8DB_BANDIT";

		// Token: 0x040006F5 RID: 1781
		public const string AC_GPIO9FS_BANDIT = "AC_GPIO9FS_BANDIT";

		// Token: 0x040006F6 RID: 1782
		public const string AC_GPIO9AL_BANDIT = "AC_GPIO9AL_BANDIT";

		// Token: 0x040006F7 RID: 1783
		public const string AC_GPIO9DB_BANDIT = "AC_GPIO9DB_BANDIT";

		// Token: 0x040006F8 RID: 1784
		public const string AC_GPIO10FS_BANDIT = "AC_GPIO10FS_BANDIT";

		// Token: 0x040006F9 RID: 1785
		public const string AC_GPIO10AL_BANDIT = "AC_GPIO10AL_BANDIT";

		// Token: 0x040006FA RID: 1786
		public const string AC_GPIO10DB_BANDIT = "AC_GPIO10DB_BANDIT";

		// Token: 0x040006FB RID: 1787
		public const string AC_GPIO1FS_BAHAMA = "AC_GPIO1FS_BAHAMA";

		// Token: 0x040006FC RID: 1788
		public const string AC_GPIO2FS_BAHAMA = "AC_GPIO2FS_BAHAMA";

		// Token: 0x040006FD RID: 1789
		public const string AC_GPIO3FS_BAHAMA = "AC_GPIO3FS_BAHAMA";

		// Token: 0x040006FE RID: 1790
		public const string AC_GPIO4FS_BAHAMA = "AC_GPIO4FS_BAHAMA";

		// Token: 0x040006FF RID: 1791
		public const string AC_GPIO5FS_BAHAMA = "AC_GPIO5FS_BAHAMA";

		// Token: 0x04000700 RID: 1792
		public const string AC_GPIO6FS_BAHAMA = "AC_GPIO6FS_BAHAMA";

		// Token: 0x04000701 RID: 1793
		public const string AC_GPIO7FS_BAHAMA = "AC_GPIO7FS_BAHAMA";

		// Token: 0x04000702 RID: 1794
		public const string AC_GPIO8FS_BAHAMA = "AC_GPIO8FS_BAHAMA";

		// Token: 0x04000703 RID: 1795
		public const string AC_GPIO9FS_BAHAMA = "AC_GPIO9FS_BAHAMA";

		// Token: 0x04000704 RID: 1796
		public const string AC_GPIO10FS_BAHAMA = "AC_GPIO10FS_BAHAMA";

		// Token: 0x04000705 RID: 1797
		public const string AC_GPIO11FS_BAHAMA = "AC_GPIO11FS_BAHAMA";

		// Token: 0x04000706 RID: 1798
		public const string AC_GPIO12FS_BAHAMA = "AC_GPIO12FS_BAHAMA";

		// Token: 0x04000707 RID: 1799
		public const string AC_GPIO1AL_BAHAMA = "AC_GPIO1AL_BAHAMA";

		// Token: 0x04000708 RID: 1800
		public const string AC_GPIO2AL_BAHAMA = "AC_GPIO2AL_BAHAMA";

		// Token: 0x04000709 RID: 1801
		public const string AC_GPIO3AL_BAHAMA = "AC_GPIO3AL_BAHAMA";

		// Token: 0x0400070A RID: 1802
		public const string AC_GPIO4AL_BAHAMA = "AC_GPIO4AL_BAHAMA";

		// Token: 0x0400070B RID: 1803
		public const string AC_GPIO5AL_BAHAMA = "AC_GPIO5AL_BAHAMA";

		// Token: 0x0400070C RID: 1804
		public const string AC_GPIO6AL_BAHAMA = "AC_GPIO6AL_BAHAMA";

		// Token: 0x0400070D RID: 1805
		public const string AC_GPIO7AL_BAHAMA = "AC_GPIO7AL_BAHAMA";

		// Token: 0x0400070E RID: 1806
		public const string AC_GPIO8AL_BAHAMA = "AC_GPIO8AL_BAHAMA";

		// Token: 0x0400070F RID: 1807
		public const string AC_GPIO9AL_BAHAMA = "AC_GPIO9AL_BAHAMA";

		// Token: 0x04000710 RID: 1808
		public const string AC_GPIO10AL_BAHAMA = "AC_GPIO10AL_BAHAMA";

		// Token: 0x04000711 RID: 1809
		public const string AC_GPIO11AL_BAHAMA = "AC_GPIO11AL_BAHAMA";

		// Token: 0x04000712 RID: 1810
		public const string AC_GPIO12AL_BAHAMA = "AC_GPIO12AL_BAHAMA";

		// Token: 0x04000713 RID: 1811
		public const string AC_GPIO1DB_BAHAMA = "AC_GPIO1DB_BAHAMA";

		// Token: 0x04000714 RID: 1812
		public const string AC_GPIO2DB_BAHAMA = "AC_GPIO2DB_BAHAMA";

		// Token: 0x04000715 RID: 1813
		public const string AC_GPIO3DB_BAHAMA = "AC_GPIO3DB_BAHAMA";

		// Token: 0x04000716 RID: 1814
		public const string AC_GPIO4DB_BAHAMA = "AC_GPIO4DB_BAHAMA";

		// Token: 0x04000717 RID: 1815
		public const string AC_GPIO5DB_BAHAMA = "AC_GPIO5DB_BAHAMA";

		// Token: 0x04000718 RID: 1816
		public const string AC_GPIO6DB_BAHAMA = "AC_GPIO6DB_BAHAMA";

		// Token: 0x04000719 RID: 1817
		public const string AC_GPIO7DB_BAHAMA = "AC_GPIO7DB_BAHAMA";

		// Token: 0x0400071A RID: 1818
		public const string AC_GPIO8DB_BAHAMA = "AC_GPIO8DB_BAHAMA";

		// Token: 0x0400071B RID: 1819
		public const string AC_GPIO9DB_BAHAMA = "AC_GPIO9DB_BAHAMA";

		// Token: 0x0400071C RID: 1820
		public const string AC_GPIO10DB_BAHAMA = "AC_GPIO10DB_BAHAMA";

		// Token: 0x0400071D RID: 1821
		public const string AC_GPIO11DB_BAHAMA = "AC_GPIO11DB_BAHAMA";

		// Token: 0x0400071E RID: 1822
		public const string AC_GPIO12DB_BAHAMA = "AC_GPIO12DB_BAHAMA";

		// Token: 0x0400071F RID: 1823
		public const string PSUAPP_DCSYSNOM = "PSUAPP_DCSYSNOM";

		// Token: 0x04000720 RID: 1824
		public const string VOLT12 = "VOLT12";

		// Token: 0x04000721 RID: 1825
		public const string VOLT24 = "VOLT24";

		// Token: 0x04000722 RID: 1826
		public const string PSUAPP_OUTPUT_CHARGER_VOLTAGE_0 = "PSUAPP_OUTPUT_CHARGER_VOLTAGE_0";

		// Token: 0x04000723 RID: 1827
		public const string PSUAPP_OUTPUT_CHARGER_VOLTAGE_1 = "PSUAPP_OUTPUT_CHARGER_VOLTAGE_1";

		// Token: 0x04000724 RID: 1828
		public const string NTP = "NTP";

		// Token: 0x04000725 RID: 1829
		public const string REPEATERTYPE = "REPEATERTYPE";

		// Token: 0x04000726 RID: 1830
		public const string REPTRTYPE = "RepeaterType";

		// Token: 0x04000727 RID: 1831
		public const string CP_SCHGPSEN = "CP_SCHGPSEN";

		// Token: 0x04000728 RID: 1832
		public const string CP_SCHGPSWDSZ = "CP_SCHGPSWDSZ";

		// Token: 0x04000729 RID: 1833
		public const string CP_SCHGPSWDSZ_GUI = "CP_SCHGPSWDSZ_GUI";

		// Token: 0x0400072A RID: 1834
		public const string CP_SCHGPSSCHDLSLTEN = "CP_SCHGPSSCHDLSLTEN";

		// Token: 0x0400072B RID: 1835
		public const string CP_S1SCHGPSSCHDLSLTEN = "CP_S1SCHGPSSCHDLSLTEN";

		// Token: 0x0400072C RID: 1836
		public const string CP_S2SCHGPSSCHDLSLTEN = "CP_S2SCHGPSSCHDLSLTEN";

		// Token: 0x0400072D RID: 1837
		public const string CP_SCHGPSSLTEN = "CP_SCHGPSSLTEN";

		// Token: 0x0400072E RID: 1838
		public const string CP_S1SCHGPSSLTEN = "CP_S1SCHGPSSLTEN";

		// Token: 0x0400072F RID: 1839
		public const string CP_S2SCHGPSSLTEN = "CP_S2SCHGPSSLTEN";

		// Token: 0x04000730 RID: 1840
		public const string CP_S1SCHGPSWDSZ = "CP_S1SCHGPSWDSZ";

		// Token: 0x04000731 RID: 1841
		public const string CP_S1SCHGPSWDSZ_GUI = "CP_S1SCHGPSWDSZ_GUI";

		// Token: 0x04000732 RID: 1842
		public const string CP_S2SCHGPSWDSZ = "CP_S2SCHGPSWDSZ";

		// Token: 0x04000733 RID: 1843
		public const string CP_S2SCHGPSWDSZ_GUI = "CP_S2SCHGPSWDSZ_GUI";

		// Token: 0x04000734 RID: 1844
		public const string CP_S1SCHGPSPRWDRSV = "CP_S1SCHGPSPRWDRSV";

		// Token: 0x04000735 RID: 1845
		public const string CP_S2SCHGPSPRWDRSV = "CP_S2SCHGPSPRWDRSV";

		// Token: 0x04000736 RID: 1846
		public const string CP_TRTEN = "CP_TRTEN";

		// Token: 0x04000737 RID: 1847
		public const string DATAREVERT_SCHGPSWDSZ = "DATAREVERT_SCHGPSWDSZ";

		// Token: 0x04000738 RID: 1848
		public const string DATAREVERT_SCHGPSWDSZ_GUI = "DATAREVERT_SCHGPSWDSZ_GUI";

		// Token: 0x04000739 RID: 1849
		public const string DATAREVERT_RESERVED = "DATAREVERT_RESERVED";

		// Token: 0x0400073A RID: 1850
		public const string DATAREVERT_RESERVED0 = "DATAREVERT_RESERVED0";

		// Token: 0x0400073B RID: 1851
		public const string SURC_CALLALTTNDUR = "SURC_CALLALTTNDUR";

		// Token: 0x0400073C RID: 1852
		public const string SURC_TXTMSGALTTNDUR = "SURC_TXTMSGALTTNDUR";

		// Token: 0x0400073D RID: 1853
		public const string PSWD_PSWDDATA = "PSWD_PSWDDATA";

		// Token: 0x0400073E RID: 1854
		public const string PSWD_RADIOLCEN = "PSWD_RADIOLCEN";

		// Token: 0x0400073F RID: 1855
		public const string RC_FPPPWD = "RC_FPPPWD";

		// Token: 0x04000740 RID: 1856
		public const string RC_FPPMDSET = "RC_FPPMDSET";

		// Token: 0x04000741 RID: 1857
		public const string DEALERMODE = "DEALERMODE";

		// Token: 0x04000742 RID: 1858
		public const string CP_PGK_CMP_TYPE = "CP_PGK_CMP_TYPE";

		// Token: 0x04000743 RID: 1859
		public const string CP_PGK_CMP_TYPE_GRP = "CP_PGK_CMP_TYPE_GRP";

		// Token: 0x04000744 RID: 1860
		public const string PGK_UCLITEMTYPE = "PGK_UCLITEMTYPE";

		// Token: 0x04000745 RID: 1861
		public const string PGK_UCLITEMID = "PGK_UCLITEMID";

		// Token: 0x04000746 RID: 1862
		public const string PGK_UCLITEM = "PGK_UCLITEM";

		// Token: 0x04000747 RID: 1863
		public const string PGK_KYMDTY = "PGK_KYMDTY";

		// Token: 0x04000748 RID: 1864
		public const string RMT_PRGRM_CMP_TYPE = "RMT_PRGRM_CMP_TYPE";

		// Token: 0x04000749 RID: 1865
		public const string RMPG_FEATUREEN = "RMPG_FEATUREEN";

		// Token: 0x0400074A RID: 1866
		public const string RMPG_USERNAME = "RMPG_USERNAME";

		// Token: 0x0400074B RID: 1867
		public const string RMPG_USERPSWD = "RMPG_USERPSWD";

		// Token: 0x0400074C RID: 1868
		public const string BR_CAPPLUSRSTCHIP = "BR_CAPPLUSRSTCHIP";

		// Token: 0x0400074D RID: 1869
		public const string BR_CAPPLUSRSTCHUDPPT = "BR_CAPPLUSRSTCHUDPPT";

		// Token: 0x0400074E RID: 1870
		public const string CP_PHONESYSIT = "CP_PHONESYSIT";

		// Token: 0x0400074F RID: 1871
		public const string CP_PHONESYSITTYPE = "CP_PHONESYSITTYPE";

		// Token: 0x04000750 RID: 1872
		public const string CP_PHONESYSITID = "CP_PHONESYSITID";

		// Token: 0x04000751 RID: 1873
		public const string DVSLELL_DGTDUR = "DVSLELL_DGTDUR";

		// Token: 0x04000752 RID: 1874
		public const string DVSLELL_INITDL = "DVSLELL_INITDL";

		// Token: 0x04000753 RID: 1875
		public const string DVSLELL_DGTDUR_REPEATER = "DVSLELL_DGTDUR_REPEATER";

		// Token: 0x04000754 RID: 1876
		public const string DVSLELL_ITDGTDL = "DVSLELL_ITDGTDL";

		// Token: 0x04000755 RID: 1877
		public const string DVSLELL_ITDGTDL_REPEATER = "DVSLELL_ITDGTDL_REPEATER";

		// Token: 0x04000756 RID: 1878
		public const string DTMFCLELL_DEACCCODE_REPEATER = "DTMFCLELL_DEACCCODE_REPEATER";

		// Token: 0x04000757 RID: 1879
		public const string DTPSYS_PACODECON = "DTPSYS_PACODECON";

		// Token: 0x04000758 RID: 1880
		public const string DTPSYS_PDACODECON = "DTPSYS_PDACODECON";

		// Token: 0x04000759 RID: 1881
		public const string PHONE_UCL_DLH_TYPE = "PHONE_UCL_DLH_TYPE";

		// Token: 0x0400075A RID: 1882
		public const string PHONE_UCL_DLL_TYPE = "PHONE_UCL_DLL_TYPE";

		// Token: 0x0400075B RID: 1883
		public const string PHONE_UCL_DLT_TYPE = "PHONE_UCL_DLT_TYPE";

		// Token: 0x0400075C RID: 1884
		public const string BASE_REPEATER_DPP_CMP_TYPE = "BASE_REPEATER_DPP_CMP_TYPE";

		// Token: 0x0400075D RID: 1885
		public const string PHONE_UCL_DLH_TYPE_GRP = "PHONE_UCL_DLH_TYPE_GRP";

		// Token: 0x0400075E RID: 1886
		public const string PU_CALLALIAS = "PU_CALLALIAS";

		// Token: 0x0400075F RID: 1887
		public const string PU_OTCF = "PU_OTCF";

		// Token: 0x04000760 RID: 1888
		public const string PU_CALLTYPE = "PU_CALLTYPE";

		// Token: 0x04000761 RID: 1889
		public const string CP_PHONEGWEN = "CP_PHONEGWEN";

		// Token: 0x04000762 RID: 1890
		public const string BR_ANLGRXOLEN = "BR_ANLGRXOLEN";

		// Token: 0x04000763 RID: 1891
		public const string CP_ARSPLUS = "CP_ARSPLUS";

		// Token: 0x04000764 RID: 1892
		public const string ARS_SYSTEM_CHANGE = "ARS_SYSTEM_CHANGE";

		// Token: 0x04000765 RID: 1893
		public const string ARS_SYS_SITE_CHANGE = "ARS_SYS_SITE_CHANGE";

		// Token: 0x04000766 RID: 1894
		public const string CP_RGSTONRMG = "CP_RGSTONRMG";

		// Token: 0x04000767 RID: 1895
		public const string CP_625EDMEN = "CP_625EDMEN";

		// Token: 0x04000768 RID: 1896
		public const string CP_625EDMPRFLD = "CP_625EDMPRFLD";

		// Token: 0x04000769 RID: 1897
		public const string LINKEDCAPPLUSSYSTEM = "LinkedCapPlusSystem";

		// Token: 0x0400076A RID: 1898
		public const string LINKEDCAPPLUSVOICE = "LinkedCapPlusVoice";

		// Token: 0x0400076B RID: 1899
		public const string LINKEDCAPPLUSDATA = "LinkedCapPlusData";

		// Token: 0x0400076C RID: 1900
		public const string LINKEDCAPPLUSSYSCONV = "LINKEDCAPPLUSSYSCONV";

		// Token: 0x0400076D RID: 1901
		public const string LINKEDCAPPLUSVOICECONV = "LINKEDCAPPLUSVOICECONV";

		// Token: 0x0400076E RID: 1902
		public const string LINKEDCAPPLUSDATACONV = "LINKEDCAPPLUSDATACONV";

		// Token: 0x0400076F RID: 1903
		public const string LINKEDCAPPLUSSYSTEMCONV = "LINKEDCAPPLUSSYSTEM";

		// Token: 0x04000770 RID: 1904
		public const string LINKEDCAPPLUSTRUNKED = "LINKEDCAPPLUSTRUNKED";

		// Token: 0x04000771 RID: 1905
		public const string LINKEDCAPPLUSDATAREVERT = "LINKEDCAPPLUSDATAREVERT";

		// Token: 0x04000772 RID: 1906
		public const string CP_LCPSTLSTIT = "CP_LCPSTLSTIT";

		// Token: 0x04000773 RID: 1907
		public const string CP_LCPSTLSTITTYPE = "CP_LCPSTLSTITTYPE";

		// Token: 0x04000774 RID: 1908
		public const string CP_LCPSTLSTITID = "CP_LCPSTLSTITID";

		// Token: 0x04000775 RID: 1909
		public const string CP_LCPALATRM = "CP_LCPALATRM";

		// Token: 0x04000776 RID: 1910
		public const string CP_LCPRPTDRWACEN = "CP_LCPRPTDRWACEN";

		// Token: 0x04000777 RID: 1911
		public const string LCPSTLST_GDSRRITHSHD = "LCPSTLST_GDSRRITHSHD";

		// Token: 0x04000778 RID: 1912
		public const string LCPSTLST_VCLSTIT = "LCPSTLST_VCLSTIT";

		// Token: 0x04000779 RID: 1913
		public const string LCPSTLST_VCLSTITTYPE = "LCPSTLST_VCLSTITTYPE";

		// Token: 0x0400077A RID: 1914
		public const string LCPSTLST_VCLSTITID = "LCPSTLST_VCLSTITID";

		// Token: 0x0400077B RID: 1915
		public const string LCPSTLST_DTLSTIT = "LCPSTLST_DTLSTIT";

		// Token: 0x0400077C RID: 1916
		public const string LCPSTLST_DTLSTITTYPE = "LCPSTLST_DTLSTITTYPE";

		// Token: 0x0400077D RID: 1917
		public const string LCPSTLST_DTLSTITID = "LCPSTLST_DTLSTITID";

		// Token: 0x0400077E RID: 1918
		public const string LCPSTLST_RXGRPLSTIT = "LCPSTLST_RXGRPLSTIT";

		// Token: 0x0400077F RID: 1919
		public const string LCPSTLST_RXGRPLSTITTYPE = "LCPSTLST_RXGRPLSTITTYPE";

		// Token: 0x04000780 RID: 1920
		public const string LCPSTLST_RXGRPLSTITID = "LCPSTLST_RXGRPLSTITID";

		// Token: 0x04000781 RID: 1921
		public const string LCP_STLST_DLT_TYPE = "LCP_STLST_DLT_TYPE";

		// Token: 0x04000782 RID: 1922
		public const string LCP_STLST_DLH_TYPE = "LCP_STLST_DLH_TYPE";

		// Token: 0x04000783 RID: 1923
		public const string LCP_STLST_DLL_TYPE = "LCP_STLST_DLL_TYPE";

		// Token: 0x04000784 RID: 1924
		public const string LCPSTLST_ALIAS = "LCPSTLST_ALIAS";

		// Token: 0x04000785 RID: 1925
		public const string LCPSTLST_SITEALIAS = "LCPSTLST_SITEALIAS";

		// Token: 0x04000786 RID: 1926
		public const string LCPSTLST_SITEID = "LCPSTLST_SITEID";

		// Token: 0x04000787 RID: 1927
		public const string LCPSTLST_VAFLIT = "LCPSTLST_VAFLIT";

		// Token: 0x04000788 RID: 1928
		public const string LCP_RPTR_NBST_CMP_TYPE = "LCP_RPTR_NBST_CMP_TYPE";

		// Token: 0x04000789 RID: 1929
		public const string LRNS_LCPRPTRSTID = "LRNS_LCPRPTRSTID";

		// Token: 0x0400078A RID: 1930
		public const string LRNS_LCPRPTNBSTID = "LRNS_LCPRPTNBSTID";

		// Token: 0x0400078B RID: 1931
		public const string BR_LCPRPTRAWATEN = "BR_LCPRPTRAWATEN";

		// Token: 0x0400078C RID: 1932
		public const string BR_MNOS = "BR_MNOS";

		// Token: 0x0400078D RID: 1933
		public const string BR_MNOTR = "BR_MNOTR";

		// Token: 0x0400078E RID: 1934
		public const string STR_STR_3 = "STR_3";

		// Token: 0x0400078F RID: 1935
		public const string STR_STR_5 = "STR_5";

		// Token: 0x04000790 RID: 1936
		public const string STR_STR_15 = "STR_15";

		// Token: 0x04000791 RID: 1937
		public const string STR_STR_20 = "STR_20";

		// Token: 0x04000792 RID: 1938
		public const string LRWAT_TGID = "LRWAT_TGID";

		// Token: 0x04000793 RID: 1939
		public const string LCP_RPTR_WATG_CMP_TYPE = "LCP_RPTR_WATG_CMP_TYPE";

		// Token: 0x04000794 RID: 1940
		public const string LRNS_LCPRPTNBSTID1 = "LRNS_LCPRPTNBSTID1";

		// Token: 0x04000795 RID: 1941
		public const string LRNS_LCPRPTNBSTID2 = "LRNS_LCPRPTNBSTID2";

		// Token: 0x04000796 RID: 1942
		public const string LRNS_LCPRPTNBSTID3 = "LRNS_LCPRPTNBSTID3";

		// Token: 0x04000797 RID: 1943
		public const string LRNS_LCPRPTNBSTID4 = "LRNS_LCPRPTNBSTID4";

		// Token: 0x04000798 RID: 1944
		public const string LRNS_LCPRPTNBSTID5 = "LRNS_LCPRPTNBSTID5";

		// Token: 0x04000799 RID: 1945
		public const string LRNS_LCPRPTNBSTID6 = "LRNS_LCPRPTNBSTID6";

		// Token: 0x0400079A RID: 1946
		public const string LRNS_LCPRPTRRSVCHQTY = "LRNS_LCPRPTRRSVCHQTY";

		// Token: 0x0400079B RID: 1947
		public const string OC_OTAPCTMKEY = "OC_OTAPCTMKEY";

		// Token: 0x0400079C RID: 1948
		public const string OC_OTAPAUTHKEYID = "OC_OTAPAUTHKEYID";

		// Token: 0x0400079D RID: 1949
		public const string OC_OTAPCTMKYALS = "OC_OTAPCTMKYALS";

		// Token: 0x0400079E RID: 1950
		public const string OC_ARSMNTID = "OC_ARSMNTID";

		// Token: 0x0400079F RID: 1951
		public const string OC_ARSMNTIPADDR = "OC_ARSMNTIPADDR";

		// Token: 0x040007A0 RID: 1952
		public const string MDCSYS_MDCEMRSKYRVT = "MDCSYS_MDCEMRSKYRVT";

		// Token: 0x040007A1 RID: 1953
		public const string MDCSYS_MDCEMRSTKRVTALT = "MDCSYS_MDCEMRSTKRVTALT";

		// Token: 0x040007A2 RID: 1954
		public const string CP_ARTSMODETYPE = "CP_ARTSMODETYPE";

		// Token: 0x040007A3 RID: 1955
		public const string TX = "TX";

		// Token: 0x040007A4 RID: 1956
		public const string RX = "RX";

		// Token: 0x040007A5 RID: 1957
		public const string TXRX = "TXRX";

		// Token: 0x040007A6 RID: 1958
		public const string CP_ARTSTXPRD = "CP_ARTSTXPRD";

		// Token: 0x040007A7 RID: 1959
		public const string SURC_ARTSADBIDCTP = "SURC_ARTSADBIDCTP";

		// Token: 0x040007A8 RID: 1960
		public const string SURC_ARTSVSIDCTEN = "SURC_ARTSVSIDCTEN";

		// Token: 0x040007A9 RID: 1961
		public const string OC_OTAPCFGMDFDT = "OC_OTAPCFGMDFDT";

		// Token: 0x040007AA RID: 1962
		public const string CP_SARQ_WT = "CP_SARQ_WT";

		// Token: 0x040007AB RID: 1963
		public const string CTMSG_SARQACKWAITTIMER = "CTMSG_SARQACKWAITTIMER";

		// Token: 0x040007AC RID: 1964
		public const string CP_CSBKDATAENABLE = "CP_CSBKDATAENABLE";

		// Token: 0x040007AD RID: 1965
		public const string NETSET_XCMPSERVERIPADDRESS3 = "NETSET_XCMPSERVERIPADDRESS3";

		// Token: 0x040007AE RID: 1966
		public const string NETSET_XCMPSERVERIPADDRESS2 = "NETSET_XCMPSERVERIPADDRESS2";

		// Token: 0x040007AF RID: 1967
		public const string NETSET_XCMPSERVERIPADDRESS1 = "NETSET_XCMPSERVERIPADDRESS1";

		// Token: 0x040007B0 RID: 1968
		public const string NETSET_XCMPSERVERIPADDRESS0 = "NETSET_XCMPSERVERIPADDRESS0";

		// Token: 0x040007B1 RID: 1969
		public const string NETSET_XCMPSERVERIPADDRESS = "NETSET_XCMPSERVERIPADDRESS";

		// Token: 0x040007B2 RID: 1970
		public const string NETSET_XCMPSERVERID = "NETSET_XCMPSERVERID";

		// Token: 0x040007B3 RID: 1971
		public const string FLEXIBLECAPPLUSRXTGDLL_LEDITEM = "FLEXIBLECAPPLUSRXTGDLL_LEDITEM";

		// Token: 0x040007B4 RID: 1972
		public const string CAPPLUS_FLEX_RXTG_LISTMEMBERS = "CAPPLUS_FLEX_RXTG_LISTMEMBERS";

		// Token: 0x040007B5 RID: 1973
		public const string FLEXIBLE_CAPPLUS_RX_TG_DLT_TYPE = "FLEXIBLE_CAPPLUS_RX_TG_DLT_TYPE";

		// Token: 0x040007B6 RID: 1974
		public const string FLEXIBLE_CAPPLUS_RX_TG_DLL_TYPE = "FLEXIBLE_CAPPLUS_RX_TG_DLL_TYPE";

		// Token: 0x040007B7 RID: 1975
		public const string FLEXIBLE_CAPPLUS_RX_TG_DLH_TYPE = "FLEXIBLE_CAPPLUS_RX_TG_DLH_TYPE";

		// Token: 0x040007B8 RID: 1976
		public const string FLEXIBLE_CAPPLUS_RX_TG_DLH_TYPE_GRP = "FLEXIBLE_CAPPLUS_RX_TG_DLH_TYPE_GRP";

		// Token: 0x040007B9 RID: 1977
		public const string FLEXIBLECAPPLUSRXTGDLL_LEDITEMID = "FLEXIBLECAPPLUSRXTGDLL_LEDITEMID";

		// Token: 0x040007BA RID: 1978
		public const string FLEXIBLECAPPLUSRXTGDLL_LEDITEMTYPE = "FLEXIBLECAPPLUSRXTGDLL_LEDITEMTYPE";

		// Token: 0x040007BB RID: 1979
		public const string SURC_BTPERMANENTDISCOVERABLEENABLE = "SURC_BTPERMANENTDISCOVERABLEENABLE";

		// Token: 0x040007BC RID: 1980
		public const string GPS_LOCATIONREPEATERLATITUDE = "GPS_LOCATIONREPEATERLATITUDE";

		// Token: 0x040007BD RID: 1981
		public const string GPS_LOCATIONREPEATERLONGITUDE = "GPS_LOCATIONREPEATERLONGITUDE";

		// Token: 0x040007BE RID: 1982
		public const string CP_SYSTEMCONTROLLERMODE = "CP_SYSTEMCONTROLLERMODE";

		// Token: 0x040007BF RID: 1983
		public const string CP_DIGITALORANALOGBSI = "CP_DIGITALORANALOGBSI";

		// Token: 0x040007C0 RID: 1984
		public const string ANALOGBSI = "ANALOGBSI";

		// Token: 0x040007C1 RID: 1985
		public const string BR_RASALIAS = "BR_RASALIAS";

		// Token: 0x040007C2 RID: 1986
		public const string SURC_DELETEALLJOBTICKETS = "SURC_DELETEALLJOBTICKETS";

		// Token: 0x040007C3 RID: 1987
		public const string NETWORK = "NETWORK";

		// Token: 0x040007C4 RID: 1988
		public const string SURC_DATACAPABILITY = "SURC_DATACAPABILITY";

		// Token: 0x040007C5 RID: 1989
		public const string SURC_VOICEONLY = "SURC_VOICEONLY";

		// Token: 0x040007C6 RID: 1990
		public const string USER_DIGITAL_UCL_DLL_TYPE = "USER_DIGITAL_UCL_DLL_TYPE";

		// Token: 0x040007C7 RID: 1991
		public const string USER_CAPACITY_PLUS_UCL_DLL_TYPE = "USER_CAPACITY_PLUS_UCL_DLL_TYPE";

		// Token: 0x040007C8 RID: 1992
		public const string USER_UCL_GLB_PHONE_NUMBER_DLL_TYPE = "USER_UCL_GLB_PHONE_NUMBER_DLL_TYPE";

		// Token: 0x040007C9 RID: 1993
		public const string USERDEFINED = "USERDEFINED";

		// Token: 0x040007CA RID: 1994
		public const string JTTDLL_TEMPALTEITEMTYPE = "JTTDLL_TEMPALTEITEMTYPE";

		// Token: 0x040007CB RID: 1995
		public const string STR_TEXT = "TEXT";

		// Token: 0x040007CC RID: 1996
		public const string OPTION_LIST = "OPTION_LIST";

		// Token: 0x040007CD RID: 1997
		public const string NUMERIC = "NUMERIC";

		// Token: 0x040007CE RID: 1998
		public const string JOBTICKET_TEMPLATE_DLT_TYPE = "JOBTICKET_TEMPLATE_DLT_TYPE";

		// Token: 0x040007CF RID: 1999
		public const string JOBTICKET_TEMPLATE_DLH_TYPE = "JOBTICKET_TEMPLATE_DLH_TYPE";

		// Token: 0x040007D0 RID: 2000
		public const string JOBTICKET_TEMPLATE_DLH_TYPE_GRP = "JOBTICKET_TEMPLATE_DLH_TYPE_GRP";

		// Token: 0x040007D1 RID: 2001
		public const string JOBTICKET_TEMPLATE_DLL_TYPE = "JOBTICKET_TEMPLATE_DLL_TYPE";

		// Token: 0x040007D2 RID: 2002
		public const string JOBTICKET_TEMPLATE_OPTION_LIST_DLT_TYPE = "JOBTICKET_TEMPLATE_OPTION_LIST_DLT_TYPE";

		// Token: 0x040007D3 RID: 2003
		public const string JOBTICKET_TEMPLATE_OPTION_LIST_DLH_TYPE = "JOBTICKET_TEMPLATE_OPTION_LIST_DLH_TYPE";

		// Token: 0x040007D4 RID: 2004
		public const string JOBTICKET_TEMPLATE_OPTION_LIST_DLH_TYPE_GRP = "JOBTICKET_TEMPLATE_OPTION_LIST_DLH_TYPE_GRP";

		// Token: 0x040007D5 RID: 2005
		public const string JOBTICKET_TEMPLATE_OPTION_LIST_DLL_TYPE = "JOBTICKET_TEMPLATE_OPTION_LIST_DLL_TYPE";

		// Token: 0x040007D6 RID: 2006
		public const int MIN_JOBTICKET_TEMPLATE_ITEMS = 1;

		// Token: 0x040007D7 RID: 2007
		public const string JTTDLH_TEMPLATENAME = "JTTDLH_TEMPLATENAME";

		// Token: 0x040007D8 RID: 2008
		public const string JTTDLH_TEMPLATETAG = "JTTDLH_TEMPLATETAG";

		// Token: 0x040007D9 RID: 2009
		public const string JTTDLL_ITEMTAG = "JTTDLL_ITEMTAG";

		// Token: 0x040007DA RID: 2010
		public const string JTTDLL_OPTIONLISTIT = "JTTDLL_OPTIONLISTIT";

		// Token: 0x040007DB RID: 2011
		public const string JTTDLL_OPTIONLISTITID = "JTTDLL_OPTIONLISTITID";

		// Token: 0x040007DC RID: 2012
		public const string JTTDLL_ITEMLENGTHFORTEXT = "JTTDLL_ITEMLENGTHFORTEXT";

		// Token: 0x040007DD RID: 2013
		public const string JTTDLL_ITEMLENGTHFORTEXTHIGH = "JTTDLL_ITEMLENGTHFORTEXTHIGH";

		// Token: 0x040007DE RID: 2014
		public const string JTTDLL_ITEMLENGTHFORTEXT_GUI = "JTTDLL_ITEMLENGTHFORTEXT_GUI";

		// Token: 0x040007DF RID: 2015
		public const string JTTDLL_ORIGINALTEXT = "JTTDLL_ORIGINALTEXT";

		// Token: 0x040007E0 RID: 2016
		public const string JTTDLL_ORIGINALTEXTPART2 = "JTTDLL_ORIGINALTEXTPART2";

		// Token: 0x040007E1 RID: 2017
		public const string JTTDLL_ORIGINALTEXT_GUI = "JTTDLL_ORIGINALTEXT_GUI";

		// Token: 0x040007E2 RID: 2018
		public const string JTTOLDLH_OPTIONLISTNAME = "JTTOLDLH_OPTIONLISTNAME";

		// Token: 0x040007E3 RID: 2019
		public const string JTTDLL_ITEMNAME = "JTTDLL_ITEMNAME";

		// Token: 0x040007E4 RID: 2020
		public const string JTTOLDLL_OPTIONINDEX = "JTTOLDLL_OPTIONINDEX";

		// Token: 0x040007E5 RID: 2021
		public const string JTTOLDLL_OPTIONNAME = "JTTOLDLL_OPTIONNAME";

		// Token: 0x040007E6 RID: 2022
		public const int MAX_NUMERIC_JTTOLDLL_OPTIONINDEX = 99999;

		// Token: 0x040007E7 RID: 2023
		public const string JTTOLDLH_LISTCATEGORY = "JTTOLDLH_LISTCATEGORY";

		// Token: 0x040007E8 RID: 2024
		public const string JTTOLDLH_LEDSIZE = "JTTOLDLH_LEDSIZE";

		// Token: 0x040007E9 RID: 2025
		public const string JTTOLDLH_LEQMAX = "JTTOLDLH_LEQMAX";

		// Token: 0x040007EA RID: 2026
		public const string JTTOLDLH_LLEQMAX = "JTTOLDLH_LLEQMAX";

		// Token: 0x040007EB RID: 2027
		public const string JOBTICKET_TEMPLATE_OPTION_LIST_DLH_TYPE_FTLLISHTYPE = "JOBTICKET_TEMPLATE_OPTION_LIST_DLH_TYPE_FTLLISHTYPE";

		// Token: 0x040007EC RID: 2028
		public const string JOBTICKET_TEMPLATE_OPTION_LIST_DLH_TYPE_FTLLISHID = "JOBTICKET_TEMPLATE_OPTION_LIST_DLH_TYPE_FTLLISHID";

		// Token: 0x040007ED RID: 2029
		public const string JTTDLH_LISTCATEGORY = "JTTDLH_LISTCATEGORY";

		// Token: 0x040007EE RID: 2030
		public const string JTTDLH_LEDSIZE = "JTTDLH_LEDSIZE";

		// Token: 0x040007EF RID: 2031
		public const string JTTDLH_LEQMAX = "JTTDLH_LEQMAX";

		// Token: 0x040007F0 RID: 2032
		public const string JTTDLH_LLEQMAX = "JTTDLH_LLEQMAX";

		// Token: 0x040007F1 RID: 2033
		public const string JOBTICKET_TEMPLATE_DLH_TYPE_FTLLISHTYPE = "JOBTICKET_TEMPLATE_DLH_TYPE_FTLLISHTYPE";

		// Token: 0x040007F2 RID: 2034
		public const string JOBTICKET_TEMPLATE_DLH_TYPE_FTLLISHID = "JOBTICKET_TEMPLATE_DLH_TYPE_FTLLISHID";

		// Token: 0x040007F3 RID: 2035
		public const string JTTDLH_RESERVED = "JTTDLH_RESERVED";

		// Token: 0x040007F4 RID: 2036
		public const string RC_CONTROLSTATIONMODE = "RC_CONTROLSTATIONMODE";

		// Token: 0x040007F5 RID: 2037
		public const string RC_CODEPLUGPASSWORDPOLICY = "RC_CODEPLUGPASSWORDPOLICY";

		// Token: 0x040007F6 RID: 2038
		public const string RC_CURRENTCODEPLUGPASSWORDHASH = "RC_CURRENTCODEPLUGPASSWORDHASH";

		// Token: 0x040007F7 RID: 2039
		public const string BASIC_PASSWORD_POLICY = "BASIC_PASSWORD_POLICY";

		// Token: 0x040007F8 RID: 2040
		public const string ENHANCED_PASSWORD_POLICY = "ENHANCED_PASSWORD_POLICY";

		// Token: 0x040007F9 RID: 2041
		public const string SURC_DELETEOPTIONBOARDUNIQUEIDENTIFIER = "SURC_DELETEOPTIONBOARDUNIQUEIDENTIFIER";

		// Token: 0x040007FA RID: 2042
		public const string CP_DMR3SYSTEMITEM = "CP_DMR3SYSTEMITEM";

		// Token: 0x040007FB RID: 2043
		public const string CP_DMR3SYSTEMITEMTYPE = "CP_DMR3SYSTEMITEMTYPE";

		// Token: 0x040007FC RID: 2044
		public const string CP_DMR3SYSTEMITEMID = "CP_DMR3SYSTEMITEMID";

		// Token: 0x040007FD RID: 2045
		public const string DMR3_FLEXIBLE_CHANNEL_DLH_TYPE = "DMR3_FLEXIBLE_CHANNEL_DLH_TYPE";

		// Token: 0x040007FE RID: 2046
		public const string DMR3_FLEXIBLE_CHANNEL_DLL_TYPE = "DMR3_FLEXIBLE_CHANNEL_DLL_TYPE";

		// Token: 0x040007FF RID: 2047
		public const string FLXCHANPLANLISTDLH_LIST_ALIAS = "FLXCHANPLANLISTDLH_LIST_ALIAS";

		// Token: 0x04000800 RID: 2048
		public const string DMR3_FLEXIBLE_CHANNEL_DLT_TYPE = "DMR3_FLEXIBLE_CHANNEL_DLT_TYPE";

		// Token: 0x04000801 RID: 2049
		public const string DMR3ESCB_DMR3_EMER_SYS_ALIAS = "DMR3ESCB_DMR3_EMER_SYS_ALIAS";

		// Token: 0x04000802 RID: 2050
		public const string FLEXIBLEDMR3RXTGDLL_LEDITEM = "FLEXIBLEDMR3RXTGDLL_LEDITEM";

		// Token: 0x04000803 RID: 2051
		public const string DMR3_FLEX_RXTG_LISTMEMBERS = "DMR3_FLEX_RXTG_LISTMEMBERS";

		// Token: 0x04000804 RID: 2052
		public const string FLEXIBLE_DMR3_RX_TG_DLT_TYPE = "FLEXIBLE_DMR3_RX_TG_DLT_TYPE";

		// Token: 0x04000805 RID: 2053
		public const string FLEXIBLE_DMR3_RX_TG_DLL_TYPE = "FLEXIBLE_DMR3_RX_TG_DLL_TYPE";

		// Token: 0x04000806 RID: 2054
		public const string FLEXIBLE_DMR3_RX_TG_DLH_TYPE = "FLEXIBLE_DMR3_RX_TG_DLH_TYPE";

		// Token: 0x04000807 RID: 2055
		public const string FLEXIBLE_DMR3_RX_TG_DLH_TYPE_GRP = "FLEXIBLE_DMR3_RX_TG_DLH_TYPE_GRP";

		// Token: 0x04000808 RID: 2056
		public const string FLEXIBLEDMR3RXTGDLL_LEDITEMID = "FLEXIBLEDMR3RXTGDLL_LEDITEMID";

		// Token: 0x04000809 RID: 2057
		public const string FLEXIBLEDMR3RXTGDLL_LEDITEMTYPE = "FLEXIBLEDMR3RXTGDLL_LEDITEMTYPE";

		// Token: 0x0400080A RID: 2058
		public const string RC_PASSWORDTHRESHOLD = "RC_PASSWORDTHRESHOLD";

		// Token: 0x0400080B RID: 2059
		public const string CP_TXCOMPUDPIPHEADENPLUS = "CP_TXCOMPUDPIPHEADENPLUS";

		// Token: 0x0400080C RID: 2060
		public const string MSI = "MSI";

		// Token: 0x0400080D RID: 2061
		public const string DMR = "DMR";

		// Token: 0x0400080E RID: 2062
		public const string MBPTTCHANSELECTION_CMP_TYPE = "MBPTTCHANSELECTION_CMP_TYPE";

		// Token: 0x0400080F RID: 2063
		public const string MBPTTCHANSELECTION_ITEM = "MBPTTCHANSELECTION_ITEM";

		// Token: 0x04000810 RID: 2064
		public const string MBPTTCHANSELECTION_ITEM1 = "MBPTTCHANSELECTION_ITEM1";

		// Token: 0x04000811 RID: 2065
		public const string MBPTTCHANSELECTION_ITEM1TYPE = "MBPTTCHANSELECTION_ITEM1TYPE";

		// Token: 0x04000812 RID: 2066
		public const string MBPTTCHANSELECTION_ITEM1ID = "MBPTTCHANSELECTION_ITEM1ID";

		// Token: 0x04000813 RID: 2067
		public const string MBPTTCHANSELECTION_ITEM2 = "MBPTTCHANSELECTION_ITEM2";

		// Token: 0x04000814 RID: 2068
		public const string MBPTTCHANSELECTION_ITEM2TYPE = "MBPTTCHANSELECTION_ITEM2TYPE";

		// Token: 0x04000815 RID: 2069
		public const string MBPTTCHANSELECTION_ITEM2ID = "MBPTTCHANSELECTION_ITEM2ID";

		// Token: 0x04000816 RID: 2070
		public const string MBPTTCHANSELECTION_ITEM3 = "MBPTTCHANSELECTION_ITEM3";

		// Token: 0x04000817 RID: 2071
		public const string MBPTTCHANSELECTION_ITEM3TYPE = "MBPTTCHANSELECTION_ITEM3TYPE";

		// Token: 0x04000818 RID: 2072
		public const string MBPTTCHANSELECTION_ITEM3ID = "MBPTTCHANSELECTION_ITEM3ID";

		// Token: 0x04000819 RID: 2073
		public const string MBPTTCHANSELECTION_ITEM4 = "MBPTTCHANSELECTION_ITEM4";

		// Token: 0x0400081A RID: 2074
		public const string MBPTTCHANSELECTION_ITEM4TYPE = "MBPTTCHANSELECTION_ITEM4TYPE";

		// Token: 0x0400081B RID: 2075
		public const string MBPTTCHANSELECTION_ITEM4ID = "MBPTTCHANSELECTION_ITEM4ID";

		// Token: 0x0400081C RID: 2076
		public const string MBPTTCHANSELECTION_ITEM5 = "MBPTTCHANSELECTION_ITEM5";

		// Token: 0x0400081D RID: 2077
		public const string MBPTTCHANSELECTION_ITEM5TYPE = "MBPTTCHANSELECTION_ITEM5TYPE";

		// Token: 0x0400081E RID: 2078
		public const string MBPTTCHANSELECTION_ITEM5ID = "MBPTTCHANSELECTION_ITEM5ID";

		// Token: 0x0400081F RID: 2079
		public const string MBPTTCHANSELECTION_ITEM6 = "MBPTTCHANSELECTION_ITEM6";

		// Token: 0x04000820 RID: 2080
		public const string MBPTTCHANSELECTION_ITEM6TYPE = "MBPTTCHANSELECTION_ITEM6TYPE";

		// Token: 0x04000821 RID: 2081
		public const string MBPTTCHANSELECTION_ITEM6ID = "MBPTTCHANSELECTION_ITEM6ID";

		// Token: 0x04000822 RID: 2082
		public const string MBPTTCHANSELECTION_ITEM7 = "MBPTTCHANSELECTION_ITEM7";

		// Token: 0x04000823 RID: 2083
		public const string MBPTTCHANSELECTION_ITEM7TYPE = "MBPTTCHANSELECTION_ITEM7TYPE";

		// Token: 0x04000824 RID: 2084
		public const string MBPTTCHANSELECTION_ITEM7ID = "MBPTTCHANSELECTION_ITEM7ID";

		// Token: 0x04000825 RID: 2085
		public const string NETSET_BMAID = "NETSET_BMAID";

		// Token: 0x04000826 RID: 2086
		public const string NETSET_BMAIPADDRESS = "NETSET_BMAIPADDRESS";

		// Token: 0x04000827 RID: 2087
		public const string NETSET_BMASERVERPORT = "NETSET_BMASERVERPORT";

		// Token: 0x04000828 RID: 2088
		public const string GNSSCFGCMPBLK_PREFIX = "GNSSCFGCMPBLK_";

		// Token: 0x04000829 RID: 2089
		public const string GNSSCFGCMPBLK_CMP_TYPE = "GNSSCFGCMPBLK_CMP_TYPE";

		// Token: 0x0400082A RID: 2090
		public const string GNSSCFGCMPBLK_USERSELECTION = "GNSSCFGCMPBLK_USERSELECTION";

		// Token: 0x0400082B RID: 2091
		public const string GPS = "GPS";

		// Token: 0x0400082C RID: 2092
		public const string GLONASS = "GLONASS";

		// Token: 0x0400082D RID: 2093
		public const string BEIDOU = "BEIDOU";

		// Token: 0x0400082E RID: 2094
		public const string GALILEO = "GALILEO";

		// Token: 0x0400082F RID: 2095
		public const string QZSS = "QZSS";

		// Token: 0x04000830 RID: 2096
		public const string GNSSCFGCMPBLK_GNSSCOMBINATION = "GNSSCFGCMPBLK_GNSSCOMBINATION";

		// Token: 0x04000831 RID: 2097
		public const string REPLACE = "REPLACE";

		// Token: 0x04000832 RID: 2098
		public const string CP_TEXTMESSAGETYPE = "CP_TEXTMESSAGETYPE";

		// Token: 0x04000833 RID: 2099
		public const string VAC_VASTS = "VAC_VASTS";

		// Token: 0x04000834 RID: 2100
		public const string VAC_VASTS_GUI = "VAC_VASTS_GUI";

		// Token: 0x04000835 RID: 2101
		public const string VAC_ANNOUNCEMENTBUTTONSTATE = "VAC_ANNOUNCEMENTBUTTONSTATE";

		// Token: 0x04000836 RID: 2102
		public const string VAC_TTSLANGPACK = "VAC_TTSLANGPACK";

		// Token: 0x04000837 RID: 2103
		public const string VAC_TTSLANGPACK_SPEAKERNAME = "VAC_TTSLANGPACK_SPEAKERNAME";

		// Token: 0x04000838 RID: 2104
		public const string VAC_TTSLANGPACK_VERSION = "VAC_TTSLANGPACK_VERSION";

		// Token: 0x04000839 RID: 2105
		public const string VAC_TTSLANGPACK_GENDER = "VAC_TTSLANGPACK_GENDER";

		// Token: 0x0400083A RID: 2106
		public const string VAC_TTSLANGPACK_ID = "VAC_TTSLANGPACK_ID";

		// Token: 0x0400083B RID: 2107
		public const string VAC_TTSLANGPACK_NAME = "VAC_TTSLANGPACK_NAME";

		// Token: 0x0400083C RID: 2108
		public const string VAC_TTSLANGPACK_TYPE = "VAC_TTSLANGPACK_TYPE";

		// Token: 0x0400083D RID: 2109
		public const string VAC_TTSLANGPACK_TYPE_GRP = "VAC_TTSLANGPACK_TYPE_GRP";

		// Token: 0x0400083E RID: 2110
		public const string VAC_TTSLANGPACK_NOTINSTALLED_ATTR = "NotInstalled";

		// Token: 0x0400083F RID: 2111
		public const string TTSLANGPACK = "TTSLANGPACK";

		// Token: 0x04000840 RID: 2112
		public const string TTSLANGPACKPREFIX = "TTSLANGPACK_";

		// Token: 0x04000841 RID: 2113
		public const string TTSLANGPACK_DONOTCHANGE = "TTSLANGPACK_DONOTCHANGE";

		// Token: 0x04000842 RID: 2114
		public const string SPEAKERNAME = "SpeakerName";

		// Token: 0x04000843 RID: 2115
		public const string LANGCODE = "LangCode";

		// Token: 0x04000844 RID: 2116
		public const string VOICEGENDER = "Gender";

		// Token: 0x04000845 RID: 2117
		public const string VAC_TTSJTS = "VAC_TTSJTS";

		// Token: 0x04000846 RID: 2118
		public const string VAC_TTSCHAN = "VAC_TTSCHAN";

		// Token: 0x04000847 RID: 2119
		public const string VAC_TTSPB = "VAC_TTSPB";

		// Token: 0x04000848 RID: 2120
		public const string VAC_TTSTM = "VAC_TTSTM";

		// Token: 0x04000849 RID: 2121
		public const string VAC_TTSZONE = "VAC_TTSZONE";

		// Token: 0x0400084A RID: 2122
		public const string TTSRULE_CMP_TYPE_GRP = "TTSRULE_CMP_TYPE_GRP";

		// Token: 0x0400084B RID: 2123
		public const string TTSRULE_CMP_TYPE = "TTSRULE_CMP_TYPE";

		// Token: 0x0400084C RID: 2124
		public const string TTSRULE_KEY = "TTSRULE_KEY";

		// Token: 0x0400084D RID: 2125
		public const string TTSRULE_VALUE = "TTSRULE_VALUE";

		// Token: 0x0400084E RID: 2126
		public const string TTSRULESET_CMP_TYPE_GRP = "TTSRULESET_CMP_TYPE_GRP";

		// Token: 0x0400084F RID: 2127
		public const string TTSRULESET_CMP_TYPE = "TTSRULESET_CMP_TYPE";

		// Token: 0x04000850 RID: 2128
		public const string TTSRULESET_COMPRESSEDDATALENGTH = "TTSRULESET_COMPRESSEDDATALENGTH";

		// Token: 0x04000851 RID: 2129
		public const string TTSRULESET_RULESET = "TTSRULESET_RULESET";

		// Token: 0x04000852 RID: 2130
		public const string BTN_ADDTTSRULE = "BTN_ADDTTSRULE";

		// Token: 0x04000853 RID: 2131
		public const string BTN_DELTTSRULE = "BTN_DELTTSRULE";

		// Token: 0x04000854 RID: 2132
		public const string VOICE_ANNOUNCEMENT = "VOICE_ANNOUNCEMENT";

		// Token: 0x04000855 RID: 2133
		public const string TEXT_TO_SPEECH = "TEXT_TO_SPEECH";

		// Token: 0x04000856 RID: 2134
		public const string REPLAYTTSMSG = "REPLAYTTSMSG";

		// Token: 0x04000857 RID: 2135
		public const string SURC_LOGINCAPABILITY = "SURC_LOGINCAPABILITY";

		// Token: 0x04000858 RID: 2136
		public const string SURC_SECURESIGNINID = "SURC_SECURESIGNINID";

		// Token: 0x04000859 RID: 2137
		public const string RC_BTENABLE = "RC_BTENABLE";

		// Token: 0x0400085A RID: 2138
		public const string SURC_PROHIBITTONEONINTERRUPT = "SURC_PROHIBITTONEONINTERRUPT";

		// Token: 0x0400085B RID: 2139
		public const string CP_LOCATIONDATADELIVERYMODE = "CP_LOCATIONDATADELIVERYMODE";

		// Token: 0x0400085C RID: 2140
		public const string DESS_EMERGENCYGROUPIT = "DESS_EMERGENCYGROUPIT";

		// Token: 0x0400085D RID: 2141
		public const string DESS_EMERGENCYGROUPITID = "DESS_EMERGENCYGROUPITID";

		// Token: 0x0400085E RID: 2142
		public const string DESS_EMERGENCYGROUPITTYPE = "DESS_EMERGENCYGROUPITTYPE";

		// Token: 0x0400085F RID: 2143
		public const string RC_HOMECHANNELIT = "RC_HOMECHANNELIT";

		// Token: 0x04000860 RID: 2144
		public const string RC_HOMECHANNELITID = "RC_HOMECHANNELITID";

		// Token: 0x04000861 RID: 2145
		public const string RC_HOMECHANNELITTYPE = "RC_HOMECHANNELITTYPE";

		// Token: 0x04000862 RID: 2146
		public const string LCPSTLST_GPSONREVERTCHANNELONLY = "LCPSTLST_GPSONREVERTCHANNELONLY";

		// Token: 0x04000863 RID: 2147
		public const string CP_DUALSLOTDATAOPERATION = "CP_DUALSLOTDATAOPERATION";

		// Token: 0x04000864 RID: 2148
		public const string GPS_ON_OPPOSITE_SLOT = "GPS_ON_OPPOSITE_SLOT";

		// Token: 0x04000865 RID: 2149
		public const string CP_PERSITEROAMINGRSSITHRESHOLD = "CP_PERSITEROAMINGRSSITHRESHOLD";

		// Token: 0x04000866 RID: 2150
		public const string SSP_PERSITEROAMINGRSSITHRESHOLDENABLE = "SSP_PERSITEROAMINGRSSITHRESHOLDENABLE";

		// Token: 0x04000867 RID: 2151
		public const string LCPSTLST_LCPPERSITERSSITHRESHOLD = "LCPSTLST_LCPPERSITERSSITHRESHOLD";

		// Token: 0x04000868 RID: 2152
		public const string LCPSTLST_LCPPERSITERSSITHRESHOLDENABLE = "LCPSTLST_LCPPERSITERSSITHRESHOLDENABLE";

		// Token: 0x04000869 RID: 2153
		public const string SURC_EMERGENCYSEARCHTONECONTROL = "SURC_EMERGENCYSEARCHTONECONTROL";

		// Token: 0x0400086A RID: 2154
		public const string SURC_EMERGENCYSEARCHTONESPEAKERSELECT = "SURC_EMERGENCYSEARCHTONESPEAKERSELECT";

		// Token: 0x0400086B RID: 2155
		public const string SURC_EMERGENCYSEARCHTONEVOLUME = "SURC_EMERGENCYSEARCHTONEVOLUME";

		// Token: 0x0400086C RID: 2156
		public const string LCPSTLST_LSTHMST = "LCPSTLST_LSTHMST";

		// Token: 0x0400086D RID: 2157
		public const string BR_LCPRPTRSLFSTID = "BR_LCPRPTRSLFSTID";

		// Token: 0x0400086E RID: 2158
		public const string STR_16 = "16";

		// Token: 0x0400086F RID: 2159
		public const string STR_17 = "17";

		// Token: 0x04000870 RID: 2160
		public const string STR_18 = "18";

		// Token: 0x04000871 RID: 2161
		public const string STR_19 = "19";

		// Token: 0x04000872 RID: 2162
		public const string RC_TXHGHPWR_TONGA_CHOICE = "RC_TXHGHPWR_TONGA_CHOICE";

		// Token: 0x04000873 RID: 2163
		public const int MAX_NUMERIC_CALLALIAS = 999;

		// Token: 0x04000874 RID: 2164
		public const string RC_OTARUKEK = "RC_OTARUKEK";

		// Token: 0x04000875 RID: 2165
		public const string RC_OTARUKEKID = "RC_OTARUKEKID";

		// Token: 0x04000876 RID: 2166
		public const string OTAR_HIDDEN_STRING = "****************************************************************";

		// Token: 0x04000877 RID: 2167
		public const string OTAR_HIDDEN_STRING_FOUR_CHAR = "****";

		// Token: 0x04000878 RID: 2168
		public const string ZP_PERZONEOTARENABLE = "ZP_PERZONEOTARENABLE";

		// Token: 0x04000879 RID: 2169
		public const string OPC_CMP_TYPE = "OPC_CMP_TYPE";

		// Token: 0x0400087A RID: 2170
		public const string OPC_OTARTEKCKR = "OPC_OTARTEKCKR";

		// Token: 0x0400087B RID: 2171
		public const string OPC_OTARACTIVETEKKID = "OPC_OTARACTIVETEKKID";

		// Token: 0x0400087C RID: 2172
		public const string OPC_OTARACTIVETEK = "OPC_OTARACTIVETEK";

		// Token: 0x0400087D RID: 2173
		public const string OPC_OTARTEKALIAS = "OPC_OTARTEKALIAS";

		// Token: 0x0400087E RID: 2174
		public const uint MIN_NUMERIC_OPC_OTARACTIVETEKKID = 1U;

		// Token: 0x0400087F RID: 2175
		public const uint MAX_NUMERIC_OPC_OTARACTIVETEKKID = 255U;

		// Token: 0x04000880 RID: 2176
		public const string MIN_OPC_OTARACTIVETEKKID = "1";

		// Token: 0x04000881 RID: 2177
		public const string MIN_OPC_OTARACTIVETEKKID_PADDED = "0001";

		// Token: 0x04000882 RID: 2178
		public const string MAX_OPC_OTARACTIVETEKKID = "FF";

		// Token: 0x04000883 RID: 2179
		public const int OPC_OTARACTIVETEKKID_PAD_LENGTH = 4;

		// Token: 0x04000884 RID: 2180
		public const int OTAR_TEK_UKEK_VALUE_PAD_LENGTH = 64;

		// Token: 0x04000885 RID: 2181
		public const string CP_EMERGENCY_CALL_DECODE_TONE_ENABLE = "CP_EMERGENCY_CALL_DECODE_TONE_ENABLE";

		// Token: 0x04000886 RID: 2182
		public const string NETSET_KMFRADIOID = "NETSET_KMFRADIOID";

		// Token: 0x04000887 RID: 2183
		public const string NETSET_KMFRADIOIPADDRESS = "NETSET_KMFRADIOIPADDRESS";

		// Token: 0x04000888 RID: 2184
		public const string CP_PERCHANNELOTARENABLE = "CP_PERCHANNELOTARENABLE";

		// Token: 0x04000889 RID: 2185
		public const string WIFINETWORK_DLL_TYPE = "WIFINETWORK_DLL_TYPE";

		// Token: 0x0400088A RID: 2186
		public const string RC_WIFICHIPPRESENT = "RC_WIFICHIPPRESENT";

		// Token: 0x0400088B RID: 2187
		public const string SURC_WIFIENABLE = "SURC_WIFIENABLE";

		// Token: 0x0400088C RID: 2188
		public const string SURC_WIFIREGULATORYREGION = "SURC_WIFIREGULATORYREGION";

		// Token: 0x0400088D RID: 2189
		public const string NETSET_WIFIDNSSDFEATURE = "NETSET_WIFIDNSSDFEATURE";

		// Token: 0x0400088E RID: 2190
		public const string BTN_ADDWIFI = "BTN_ADDWIFI";

		// Token: 0x0400088F RID: 2191
		public const string BTN_DELWIFI = "BTN_DELWIFI";

		// Token: 0x04000890 RID: 2192
		public const string WIFILISTDLL_SSID_PREFIX = "MOTOTRBO";

		// Token: 0x04000891 RID: 2193
		public const string WIFILISTDLL_SSID = "WIFILISTDLL_SSID";

		// Token: 0x04000892 RID: 2194
		public const int WIFILISTDLL_SSID_MAX_BYTES = 32;

		// Token: 0x04000893 RID: 2195
		public const string WIFILISTDLL_SECURITYTYPE = "WIFILISTDLL_SECURITYTYPE";

		// Token: 0x04000894 RID: 2196
		public const string OPEN = "OPEN";

		// Token: 0x04000895 RID: 2197
		public const string WEP = "WEP";

		// Token: 0x04000896 RID: 2198
		public const string WPA_PSK = "WPA-PSK";

		// Token: 0x04000897 RID: 2199
		public const string WIFILISTDLL_PASSWORD = "WIFILISTDLL_PASSWORD";

		// Token: 0x04000898 RID: 2200
		public const string TOGGLEWIFIONOFF = "TOGGLEWIFIONOFF";

		// Token: 0x04000899 RID: 2201
		public const string WIFISTATUSANNOUNCEMENT = "WIFISTATUSANNOUNCEMENT";

		// Token: 0x0400089A RID: 2202
		public const string NETSET_BLUETOOTHDNSSDFEATURE = "NETSET_BLUETOOTHDNSSDFEATURE";

		// Token: 0x0400089B RID: 2203
		public const string NETSET_USBDNSSDFEATURE = "NETSET_USBDNSSDFEATURE";

		// Token: 0x0400089C RID: 2204
		public const string WNC_ENABLE80211D = "WNC_ENABLE80211D";

		// Token: 0x0400089D RID: 2205
		public const string WNC_DHCPCLIENTENABLE = "WNC_DHCPCLIENTENABLE";

		// Token: 0x0400089E RID: 2206
		public const string WNC_STATICIPADDRESS = "WNC_STATICIPADDRESS";

		// Token: 0x0400089F RID: 2207
		public const string WNC_STATICIPADDRESS0 = "WNC_STATICIPADDRESS0";

		// Token: 0x040008A0 RID: 2208
		public const string WNC_STATICIPADDRESS1 = "WNC_STATICIPADDRESS1";

		// Token: 0x040008A1 RID: 2209
		public const string WNC_STATICIPADDRESS2 = "WNC_STATICIPADDRESS2";

		// Token: 0x040008A2 RID: 2210
		public const string WNC_DEFAULTGATEWAY = "WNC_DEFAULTGATEWAY";

		// Token: 0x040008A3 RID: 2211
		public const string WNC_SUBNETMASK = "WNC_SUBNETMASK";

		// Token: 0x040008A4 RID: 2212
		public const string WNC_PRIMARYDNSSERVER = "WNC_PRIMARYDNSSERVER";

		// Token: 0x040008A5 RID: 2213
		public const string WNC_SECONDARYDNSSERVER = "WNC_SECONDARYDNSSERVER";

		// Token: 0x040008A6 RID: 2214
		public const string CP_OTARMODE = "CP_OTARMODE";

		// Token: 0x040008A7 RID: 2215
		public const string CP_AHOYDISABLE = "CP_AHOYDISABLE";

		// Token: 0x040008A8 RID: 2216
		public const string AHOY_DISABLED = "AHOY_DISABLED";

		// Token: 0x040008A9 RID: 2217
		public const string CP_OTARCKR_GUI = "CP_OTARCKR_GUI";

		// Token: 0x040008AA RID: 2218
		public const string CP_OTARCKR = "CP_OTARCKR";

		// Token: 0x040008AB RID: 2219
		public const string VAC_TTSSPEEDRATE = "VAC_TTSSPEEDRATE";

		// Token: 0x040008AC RID: 2220
		public const string VAC_TEXTTOSPEECHSPEEDRATECHANGE = "VAC_TEXTTOSPEECHSPEEDRATECHANGE";

		// Token: 0x040008AD RID: 2221
		public const string RS_WIFIMACADDRESS = "RS_WIFIMACADDRESS";

		// Token: 0x040008AE RID: 2222
		public const string RS_WIFIMACADDRESS0 = "RS_WIFIMACADDRESS0";

		// Token: 0x040008AF RID: 2223
		public const string RS_WIFIMACADDRESS1 = "RS_WIFIMACADDRESS1";

		// Token: 0x040008B0 RID: 2224
		public const string RS_WIFIMACADDRESS2 = "RS_WIFIMACADDRESS2";

		// Token: 0x040008B1 RID: 2225
		public const string RS_WIFIMACADDRESS3 = "RS_WIFIMACADDRESS3";

		// Token: 0x040008B2 RID: 2226
		public const string RS_WIFIMACADDRESS4 = "RS_WIFIMACADDRESS4";

		// Token: 0x040008B3 RID: 2227
		public const string RS_WIFIMACADDRESS5 = "RS_WIFIMACADDRESS5";

		// Token: 0x040008B4 RID: 2228
		public const string DSS_AUTHENTICATEDRADIOINHIBITUNINHIBIT = "DSS_AUTHENTICATEDRADIOINHIBITUNINHIBIT";

		// Token: 0x040008B5 RID: 2229
		public const string DSS_AUTHENTICATEDREMOTEMONITOR = "DSS_AUTHENTICATEDREMOTEMONITOR";

		// Token: 0x040008B6 RID: 2230
		public const string DSS_AUTHENTICATIONPASSPHRASE = "DSS_AUTHENTICATIONPASSPHRASE";

		// Token: 0x040008B7 RID: 2231
		public const string USER = "USER";

		// Token: 0x040008B8 RID: 2232
		public const string MENU_WIFI = "MENU_WIFI";

		// Token: 0x040008B9 RID: 2233
		public const string CP_ANALOGVOICESCRAMBLINGENABLE = "CP_ANALOGVOICESCRAMBLINGENABLE";

		// Token: 0x040008BA RID: 2234
		public const string ID_LOCAL = "ID_LOCAL";

		// Token: 0x040008BB RID: 2235
		public const string CP_TELEMETRYVIOGPOLEVEL = "CP_TELEMETRYVIO{0}GPOLEVEL";

		// Token: 0x040008BC RID: 2236
		public const string BRPC_DPPPRECFGEN = "BRPC_DPPPRECFGEN";

		// Token: 0x040008BD RID: 2237
		public const string BRPC_DPPPRECFGCALLTYPE = "BRPC_DPPPRECFGCALLTYPE";

		// Token: 0x040008BE RID: 2238
		public const string BRPC_DPPPRECFGCALLID = "BRPC_DPPPRECFGCALLID";

		// Token: 0x040008BF RID: 2239
		public const string BRPC_PHONEALLCALLEN = "BRPC_PHONEALLCALLEN";

		// Token: 0x040008C0 RID: 2240
		public const string RC_FORCEDRESTCHANNELROTATIONTIME = "RC_FORCEDRESTCHANNELROTATIONTIME";

		// Token: 0x040008C1 RID: 2241
		public const string OTC_DMR3STATUSMESSAGELISTENTRYITEM = "OTC_DMR3STATUSMESSAGELISTENTRYITEM";

		// Token: 0x040008C2 RID: 2242
		public const string CP_SFRENABLE = "CP_SFRENABLE";

		// Token: 0x040008C3 RID: 2243
		public const string CP_SFRINBOUNDCOLORCODE = "CP_SFRINBOUNDCOLORCODE";

		// Token: 0x040008C4 RID: 2244
		public const string CP_SFROUTBOUNDCOLORCODE = "CP_SFROUTBOUNDCOLORCODE";

		// Token: 0x040008C5 RID: 2245
		public const string SFR_DISABLED = "SFR_DISABLED";

		// Token: 0x040008C6 RID: 2246
		public const string SFR_ENHANCED = "SFR_ENHANCED";

		// Token: 0x040008C7 RID: 2247
		public const string RC_FIXEDPRIVACYKEYDECRYPTIONENABLE = "RC_FIXEDPRIVACYKEYDECRYPTIONENABLE";

		// Token: 0x040008C8 RID: 2248
		public const string RC_IGNORERXCLEARVOICEANDPACKETDATAENABLE = "RC_IGNORERXCLEARVOICEANDPACKETDATAENABLE";

		// Token: 0x040008C9 RID: 2249
		public const string CP_FIXEDPRIVACYKEYDECRYPTIONENABLE = "CP_FIXEDPRIVACYKEYDECRYPTIONENABLE";

		// Token: 0x040008CA RID: 2250
		public const string CP_IGNORERXCLEARVOICEANDPACKETDATAENABLE = "CP_IGNORERXCLEARVOICEANDPACKETDATAENABLE";

		// Token: 0x040008CB RID: 2251
		public const int RRP_RECONNECT_TRYTIMES = 10;

		// Token: 0x040008CC RID: 2252
		public const int ADITIONAL_DEVUPDCOUNT = 3;

		// Token: 0x040008CD RID: 2253
		public const int TRYTIMES_PER_BAR = 50;

		// Token: 0x040008CE RID: 2254
		public const string SURC_RESERVED = "SURC_RESERVED";

		// Token: 0x040008CF RID: 2255
		public const string VA_RESERVED = "VA_RESERVED";

		// Token: 0x040008D0 RID: 2256
		public const string GRPSUFFIX = "_GRP";

		// Token: 0x040008D1 RID: 2257
		public const string MTBSUFFIX = "_MTB";

		// Token: 0x040008D2 RID: 2258
		public const string POOLSUFFIX = "_POOL";

		// Token: 0x040008D3 RID: 2259
		public const string PORTSUFFIX = "_PORT";

		// Token: 0x040008D4 RID: 2260
		public const string MOBRPTRSUFFIX = "_MOBRPTR";

		// Token: 0x040008D5 RID: 2261
		public const string BANDITSUFFIX = "_BANDIT";

		// Token: 0x040008D6 RID: 2262
		public const string BAHAMASUFFIX = "_BAHAMA";

		// Token: 0x040008D7 RID: 2263
		public const string TAHITISUFFIX = "_TAHITI";

		// Token: 0x040008D8 RID: 2264
		public const string BLANKSPACE = " ";

		// Token: 0x040008D9 RID: 2265
		public const string SINGLESLASH = "/";

		// Token: 0x040008DA RID: 2266
		public const string DOUBLESLASH = "//";

		// Token: 0x040008DB RID: 2267
		public const string DOTDOUBLESLASH = ".//";

		// Token: 0x040008DC RID: 2268
		public const string DOUBLE_QUOTATION_MARKS = "\"";

		// Token: 0x040008DD RID: 2269
		public const string RETURN = "\n";

		// Token: 0x040008DE RID: 2270
		public const string CRGRETURN = "\r";

		// Token: 0x040008DF RID: 2271
		public const string LISTLETID = "ListLetID";

		// Token: 0x040008E0 RID: 2272
		public const string LISTID = "ListID";

		// Token: 0x040008E1 RID: 2273
		public const string APPLICABLE = "Applicable";

		// Token: 0x040008E2 RID: 2274
		public const string DELETEALLROW = "DeleteAllRow";

		// Token: 0x040008E3 RID: 2275
		public const string ENABLED = "Enabled";

		// Token: 0x040008E4 RID: 2276
		public const string GUI_SUFFIX = "_GUI";

		// Token: 0x040008E5 RID: 2277
		public const string WITHFWDTP = "WITHFWDTP";

		// Token: 0x040008E6 RID: 2278
		public const string NONEFWDTP = "NONEFWDTP";

		// Token: 0x040008E7 RID: 2279
		public const string DISABLED = "Disabled";

		// Token: 0x040008E8 RID: 2280
		public const string ANALOG = "Analog";

		// Token: 0x040008E9 RID: 2281
		public const string DIGITAL = "Digital";

		// Token: 0x040008EA RID: 2282
		public const string CALL = "Call";

		// Token: 0x040008EB RID: 2283
		public const string CAPACITY_PLUS = "Capacity Plus";

		// Token: 0x040008EC RID: 2284
		public const string CAPPLUSSYSTEM = "CapPlusSystem";

		// Token: 0x040008ED RID: 2285
		public const string CAPPLUSVOICE = "CapPlusVoice";

		// Token: 0x040008EE RID: 2286
		public const string CAPPLUSDATA = "CapPlusData";

		// Token: 0x040008EF RID: 2287
		public const string DMM = "DMM";

		// Token: 0x040008F0 RID: 2288
		public const string PIPE = "|";

		// Token: 0x040008F1 RID: 2289
		public const string ALIASATTR = "Alias";

		// Token: 0x040008F2 RID: 2290
		public const string STAR = "*";

		// Token: 0x040008F3 RID: 2291
		public const char STAR_AS_CHAR = '*';

		// Token: 0x040008F4 RID: 2292
		public const string POUND = "#";

		// Token: 0x040008F5 RID: 2293
		public const string LEFTBRACKET = "[";

		// Token: 0x040008F6 RID: 2294
		public const string RGHTBRACKET = "]";

		// Token: 0x040008F7 RID: 2295
		public const string CONVERSION = "CONVERSION";

		// Token: 0x040008F8 RID: 2296
		public const string RANGE = "RANGE";

		// Token: 0x040008F9 RID: 2297
		public const string SUB_RANGE = "SUB_RANGE";

		// Token: 0x040008FA RID: 2298
		public const string OFFSET = "OFFSET";

		// Token: 0x040008FB RID: 2299
		public const string LENGTH = "LENGTH";

		// Token: 0x040008FC RID: 2300
		public const string ALLOWEDCHAR = "ALLOWEDCHAR";

		// Token: 0x040008FD RID: 2301
		public const string TYPE = "type";

		// Token: 0x040008FE RID: 2302
		public const string LOWERALIAS = "alias";

		// Token: 0x040008FF RID: 2303
		public const string UPPERTYPE = "TYPE";

		// Token: 0x04000900 RID: 2304
		public const string GUITYPE = "guiType";

		// Token: 0x04000901 RID: 2305
		public const string VALUE = "value";

		// Token: 0x04000902 RID: 2306
		public const string CHOICE = "choice";

		// Token: 0x04000903 RID: 2307
		public const string SPECIAL = "special";

		// Token: 0x04000904 RID: 2308
		public const string MIN = "Min";

		// Token: 0x04000905 RID: 2309
		public const string MAX = "Max";

		// Token: 0x04000906 RID: 2310
		public const string DOT = ".";

		// Token: 0x04000907 RID: 2311
		public const string STEPSIZE = "StepSize";

		// Token: 0x04000908 RID: 2312
		public const string REGION = "REGION";

		// Token: 0x04000909 RID: 2313
		public const string MODEL = "MODEL";

		// Token: 0x0400090A RID: 2314
		public const string CPVER = "CPVER";

		// Token: 0x0400090B RID: 2315
		public const string FREQ_TYPE = "FREQ_TYPE";

		// Token: 0x0400090C RID: 2316
		public const string DEFAULT_TAG = "DEFAULT";

		// Token: 0x0400090D RID: 2317
		public const string ALL = "All";

		// Token: 0x0400090E RID: 2318
		public const string SLASHVALID = "/VALID";

		// Token: 0x0400090F RID: 2319
		public const string RANGE_DEFAULT = "RANGE_DEFAULT";

		// Token: 0x04000910 RID: 2320
		public const string FIXED = "fixed";

		// Token: 0x04000911 RID: 2321
		public const string DEFAULT = "Default";

		// Token: 0x04000912 RID: 2322
		public const string PROPERTY = "property";

		// Token: 0x04000913 RID: 2323
		public const string INVISIBLE_ZONE = "invisible_zone";

		// Token: 0x04000914 RID: 2324
		public const string TRUE = "true";

		// Token: 0x04000915 RID: 2325
		public const string FALSE = "false";

		// Token: 0x04000916 RID: 2326
		public const string CP = "CP";

		// Token: 0x04000917 RID: 2327
		public const string SHIFT = "Shift";

		// Token: 0x04000918 RID: 2328
		public const string LTD_CODEPLUG_DATASET = "LTD_CODEPLUG_DATASET";

		// Token: 0x04000919 RID: 2329
		public const string LTD_CODEPLUG = "LTD_CODEPLUG";

		// Token: 0x0400091A RID: 2330
		public const string LTD_MULTISITE_CODEPLUG = "LTD_MULTISITE_CODEPLUG";

		// Token: 0x0400091B RID: 2331
		public const string ID = "ID";

		// Token: 0x0400091C RID: 2332
		public const string IMAGE = "IMAGE";

		// Token: 0x0400091D RID: 2333
		public const string IMAGE_INFO = "IMAGE_INFO";

		// Token: 0x0400091E RID: 2334
		public const string FILENAME = "FILENAME";

		// Token: 0x0400091F RID: 2335
		public const string BAND = "BAND";

		// Token: 0x04000920 RID: 2336
		public const string CPSPROGVERS = "CPSProgVers";

		// Token: 0x04000921 RID: 2337
		public const string RANGECHANGE = "RangeChange";

		// Token: 0x04000922 RID: 2338
		public const string APPCHANGE = "AppChange";

		// Token: 0x04000923 RID: 2339
		public const string PREVID = "PrevID";

		// Token: 0x04000924 RID: 2340
		public const string BLOCKSIZE = "BLOCKSIZE";

		// Token: 0x04000925 RID: 2341
		public const string ASSCTYPE = "AsscType";

		// Token: 0x04000926 RID: 2342
		public const string ITEMTYPE = "ItemType";

		// Token: 0x04000927 RID: 2343
		public const string DYNMEM = "DYNMEM";

		// Token: 0x04000928 RID: 2344
		public const string VARIED = "varied";

		// Token: 0x04000929 RID: 2345
		public const string DPDNCY = "dpdncy";

		// Token: 0x0400092A RID: 2346
		public const string ITEM = "item";

		// Token: 0x0400092B RID: 2347
		public const string ENTIRE = "entire";

		// Token: 0x0400092C RID: 2348
		public const string DPDNTFLD = "DPDNTFLD";

		// Token: 0x0400092D RID: 2349
		public const string DPDNTFLD_ACTIVE = "DPDNTFLD_ACTIVE";

		// Token: 0x0400092E RID: 2350
		public const string DPDNTFLDVAL = "DPDNTFLDVAL";

		// Token: 0x0400092F RID: 2351
		public const string FIELDID = "FieldID";

		// Token: 0x04000930 RID: 2352
		public const string RELATION = "RELATION";

		// Token: 0x04000931 RID: 2353
		public const string FEATENBLE = "FeatEnble";

		// Token: 0x04000932 RID: 2354
		public const string VALID = "VALID";

		// Token: 0x04000933 RID: 2355
		public const string PRESERVE = "Preserve";

		// Token: 0x04000934 RID: 2356
		public const string COMBINE = "combine";

		// Token: 0x04000935 RID: 2357
		public const string POWERLEVEL = "PowerLevel";

		// Token: 0x04000936 RID: 2358
		public const string PWRLVL = "PWRLVL";

		// Token: 0x04000937 RID: 2359
		public const string MODEL_BKWDCOMPAT = "MODEL_BKWDCOMPAT";

		// Token: 0x04000938 RID: 2360
		public const string COMBINEDISH = "COMBINEDISH";

		// Token: 0x04000939 RID: 2361
		public const string COMBINEDCHOICE = "COMBINEDCHOICE";

		// Token: 0x0400093A RID: 2362
		public const string COMBINEDMULTIISH = "CombinedMultiISH";

		// Token: 0x0400093B RID: 2363
		public const string STR_MLTSITERPTRTYPE = "MltsiteRptrType";

		// Token: 0x0400093C RID: 2364
		public const int VERSLENGTH = 4;

		// Token: 0x0400093D RID: 2365
		public const string POOL = "Pool";

		// Token: 0x0400093E RID: 2366
		public const string IDENTICAL = "IDENTICAL";

		// Token: 0x0400093F RID: 2367
		public const string REQUIRED_LENGTH = "REQUIRED_LENGTH";

		// Token: 0x04000940 RID: 2368
		public const string MIN_LENGTH = "MIN_LENGTH";

		// Token: 0x04000941 RID: 2369
		public const string TAG = "Tag";

		// Token: 0x04000942 RID: 2370
		public const string HEX = "HEX";

		// Token: 0x04000943 RID: 2371
		public const string BMSB_PERSONALITY_TYPE = "BMSB_PERSONALITY_TYPE";

		// Token: 0x04000944 RID: 2372
		public const string BMSB_MULTISITE_STACK_ENABLE = "BMSB_MULTISITE_STACK_ENABLE";

		// Token: 0x04000945 RID: 2373
		public const string BMSB_MULTISITE_INTERMEDIARY_ENABLE = "BMSB_MULTISITE_INTERMEDIARY_ENABLE";

		// Token: 0x04000946 RID: 2374
		public const string BMSB_MULTISITE_SETTINGS_ALIAS = "BMSB_MULTISITE_SETTINGS_ALIAS";

		// Token: 0x04000947 RID: 2375
		public const string BMSB_HMAC_AUTHENTICATION_KEY = "BMSB_HMAC_AUTHENTICATION_KEY";

		// Token: 0x04000948 RID: 2376
		public const string BMSB_MULTISITE_HMAC_AUTHENTICATION_ENABLE = "BMSB_MULTISITE_HMAC_AUTHENTICATION_ENABLE";

		// Token: 0x04000949 RID: 2377
		public const string BMSB_MULTISITE_UDP_PORT = "BMSB_MULTISITE_UDP_PORT";

		// Token: 0x0400094A RID: 2378
		public const string BMSB_BAHAMAIPSCBEACONDURATION = "BMSB_BAHAMAIPSCBEACONDURATION";

		// Token: 0x0400094B RID: 2379
		public const string BMSB_IPSCBEACONINTERVAL = "BMSB_IPSCBEACONINTERVAL";

		// Token: 0x0400094C RID: 2380
		public const string BMSB_CAPACITYPLUSBEACONDURATION = "BMSB_CAPACITYPLUSBEACONDURATION";

		// Token: 0x0400094D RID: 2381
		public const string BMSB_CAPACITYPLUSBEACONINTERVAL = "BMSB_CAPACITYPLUSBEACONINTERVAL";

		// Token: 0x0400094E RID: 2382
		public const string BMSB_CAPACITY_PLUS_REST_CHANNEL_IP = "BMSB_CAPACITY_PLUS_REST_CHANNEL_IP";

		// Token: 0x0400094F RID: 2383
		public const string BMSB_CAPACITY_PLUS_REST_CHANNEL_UDP_PORT = "BMSB_CAPACITY_PLUS_REST_CHANNEL_UDP_PORT";

		// Token: 0x04000950 RID: 2384
		public const string BMSB_MULTISITE_INTERMEDIARY_ETHERNET_IP = "BMSB_MULTISITE_INTERMEDIARY_ETHERNET_IP";

		// Token: 0x04000951 RID: 2385
		public const string BMSB_MULTISITE_INTERMEDIARY_UDP_PORT_NUMBER = "BMSB_MULTISITE_INTERMEDIARY_UDP_PORT_NUMBER";

		// Token: 0x04000952 RID: 2386
		public const string BMSB_MULTISITE_PEER_KEEP_ALIVE_INTERVAL = "BMSB_MULTISITE_PEER_KEEP_ALIVE_INTERVAL";

		// Token: 0x04000953 RID: 2387
		public const string NCSB_DHCP_NTP_ENABLE1 = "NCSB_DHCP_NTP_ENABLE1";

		// Token: 0x04000954 RID: 2388
		public const string NCSB_DNSNTPENABLE1 = "NCSB_DNSNTPENABLE1";

		// Token: 0x04000955 RID: 2389
		public const string NCSB_DHCP_ENABLE1 = "NCSB_DHCP_ENABLE1";

		// Token: 0x04000956 RID: 2390
		public const string NCSB_ETHERNET_IP = "NCSB_ETHERNET_IP";

		// Token: 0x04000957 RID: 2391
		public const string NCSB_ETHERNET_IP0 = "NCSB_ETHERNET_IP0";

		// Token: 0x04000958 RID: 2392
		public const string NCSB_ETHERNET_IP1 = "NCSB_ETHERNET_IP1";

		// Token: 0x04000959 RID: 2393
		public const string NCSB_ETHERNET_IP2 = "NCSB_ETHERNET_IP2";

		// Token: 0x0400095A RID: 2394
		public const string NCSB_ETHERNET_IP3 = "NCSB_ETHERNET_IP3";

		// Token: 0x0400095B RID: 2395
		public const string NCSB_STATIC_GATEWAY_IP = "NCSB_STATIC_GATEWAY_IP";

		// Token: 0x0400095C RID: 2396
		public const string NCSB_STATIC_GATEWAY_IP0 = "NCSB_STATIC_GATEWAY_IP0";

		// Token: 0x0400095D RID: 2397
		public const string NCSB_STATIC_GATEWAY_IP1 = "NCSB_STATIC_GATEWAY_IP1";

		// Token: 0x0400095E RID: 2398
		public const string NCSB_STATIC_GATEWAY_IP2 = "NCSB_STATIC_GATEWAY_IP2";

		// Token: 0x0400095F RID: 2399
		public const string NCSB_STATIC_GATEWAY_IP3 = "NCSB_STATIC_GATEWAY_IP3";

		// Token: 0x04000960 RID: 2400
		public const string NCSB_STATIC_SUBNET_MASK = "NCSB_STATIC_SUBNET_MASK";

		// Token: 0x04000961 RID: 2401
		public const string NCSB_STATIC_SUBNET_MASK0 = "NCSB_STATIC_SUBNET_MASK0";

		// Token: 0x04000962 RID: 2402
		public const string NCSB_STATIC_SUBNET_MASK1 = "NCSB_STATIC_SUBNET_MASK1";

		// Token: 0x04000963 RID: 2403
		public const string NCSB_STATIC_SUBNET_MASK2 = "NCSB_STATIC_SUBNET_MASK2";

		// Token: 0x04000964 RID: 2404
		public const string NCSB_STATIC_SUBNET_MASK3 = "NCSB_STATIC_SUBNET_MASK3";

		// Token: 0x04000965 RID: 2405
		public const string NCSB_STATIC_PRIMARY_DNS_SERVER_IP = "NCSB_STATIC_PRIMARY_DNS_SERVER_IP";

		// Token: 0x04000966 RID: 2406
		public const string NCSB_STATIC_SECONDARY_DNS_SERVER_IP = "NCSB_STATIC_SECONDARY_DNS_SERVER_IP";

		// Token: 0x04000967 RID: 2407
		public const string NCSB_STATIC_NTP_SERVER_IP = "NCSB_STATIC_NTP_SERVER_IP";

		// Token: 0x04000968 RID: 2408
		public const string PSUAPP_DC_PRIMARY_SOURCE = "PSUAPP_DC_PRIMARY_SOURCE";

		// Token: 0x04000969 RID: 2409
		public const string PSUAPP_CHARGER_ENABLE = "PSUAPP_CHARGER_ENABLE";

		// Token: 0x0400096A RID: 2410
		public const string PSUAPP_OUTPUT_CHARGER_VOLTAGE = "PSUAPP_OUTPUT_CHARGER_VOLTAGE";

		// Token: 0x0400096B RID: 2411
		public const string RC_DCONLYMODE = "RC_DCONLYMODE";

		// Token: 0x0400096C RID: 2412
		public const string ACBK_REFCLKTYPE = "ACBK_REFCLKTYPE";

		// Token: 0x0400096D RID: 2413
		public const string ACBK_EXTCLKFREQ = "ACBK_EXTCLKFREQ";

		// Token: 0x0400096E RID: 2414
		public const string AC_TXAUDIOPRIORITY = "AC_TXAUDIOPRIORITY";

		// Token: 0x0400096F RID: 2415
		public const string AC_WL1TXAUDIOPRIORITY = "AC_WL1TXAUDIOPRIORITY";

		// Token: 0x04000970 RID: 2416
		public const string AC_FPTXAUDIOPRIORITY = "AC_FPTXAUDIOPRIORITY";

		// Token: 0x04000971 RID: 2417
		public const string AC_REPEATAUDIOPRIORITY = "AC_REPEATAUDIOPRIORITY";

		// Token: 0x04000972 RID: 2418
		public const string NET_CFG_SET_CMP_TYPE_GRP = "NET_CFG_SET_CMP_TYPE_GRP";

		// Token: 0x04000973 RID: 2419
		public const string NET_CFG_SET_CMP_TYPE = "NET_CFG_SET_CMP_TYPE";

		// Token: 0x04000974 RID: 2420
		public const string NCSB_NETWORKCONFIGURATIONSETTINGSALIAS = "NCSB_NETWORKCONFIGURATIONSETTINGSALIAS";

		// Token: 0x04000975 RID: 2421
		public const string RC_NCSISH = "RC_NCSISH";

		// Token: 0x04000976 RID: 2422
		public const string RC_NCSISHTYPE = "RC_NCSISHTYPE";

		// Token: 0x04000977 RID: 2423
		public const string RC_NCSISHID = "RC_NCSISHID";

		// Token: 0x04000978 RID: 2424
		public const string DNS_ADDR_CMP_TYPE_PARENT = "DNS_ADDR_CMP_TYPE_PARENT";

		// Token: 0x04000979 RID: 2425
		public const string DNS_ADDR_CMP_TYPE = "DNS_ADDR_CMP_TYPE";

		// Token: 0x0400097A RID: 2426
		public const string DNSAB_DNSADDRESSOCTETS = "DNSAB_DNSADDRESSOCTETS";

		// Token: 0x0400097B RID: 2427
		public const string DNSAB_DNSADDRESSLENGTH = "DNSAB_DNSADDRESSLENGTH";

		// Token: 0x0400097C RID: 2428
		public const string NCSB_NTPSERVERDNSISH = "NCSB_NTPSERVERDNSISH";

		// Token: 0x0400097D RID: 2429
		public const string NCSB_NTPSERVERDNSISH1 = "NCSB_NTPSERVERDNSISH1";

		// Token: 0x0400097E RID: 2430
		public const string NCSB_NTPSERVERDNSISHID = "NCSB_NTPSERVERDNSISHID";

		// Token: 0x0400097F RID: 2431
		public const string NCSB_NTPSERVERDNSISH1ID = "NCSB_NTPSERVERDNSISH1ID";

		// Token: 0x04000980 RID: 2432
		public const string NCSB_NTPSERVERDNSISHTYPE = "NCSB_NTPSERVERDNSISHTYPE";

		// Token: 0x04000981 RID: 2433
		public const string NCSB_NTPSERVERDNSISH1TYPE = "NCSB_NTPSERVERDNSISH1TYPE";

		// Token: 0x04000982 RID: 2434
		public const string BMSB_INTERMDIARYDNSISH = "BMSB_INTERMDIARYDNSISH";

		// Token: 0x04000983 RID: 2435
		public const string BMSB_INTERMDIARYDNSISHID = "BMSB_INTERMDIARYDNSISHID";

		// Token: 0x04000984 RID: 2436
		public const string BMSB_INTERMDIARYDNSISHTYPE = "BMSB_INTERMDIARYDNSISHTYPE";

		// Token: 0x04000985 RID: 2437
		public const string BMSB_INTERMEDIARYDNSADDRESSINGENABLE = "BMSB_INTERMEDIARYDNSADDRESSINGENABLE";

		// Token: 0x04000986 RID: 2438
		public const string DNSREGULAR = "^([a-zA-Z0-9]([a-zA-Z0-9\\-]{0,61}[a-zA-Z0-9])?\\.){1,126}([a-zA-Z0-9]([a-zA-Z0-9\\-]{0,61}[a-zA-Z0-9])?)$";

		// Token: 0x04000987 RID: 2439
		public const string LASTLABELALLNUMERICREGULAR = "\\.([0-9])+$";

		// Token: 0x04000988 RID: 2440
		public const string EXTERNALONLY = "EXTERNALONLY";

		// Token: 0x04000989 RID: 2441
		public const string INTERNALFALLBACK = "INTERNALFALLBACK";

		// Token: 0x0400098A RID: 2442
		public const string BRDA_MICROPHONECALLTYPE = "BRDA_MICROPHONECALLTYPE";

		// Token: 0x0400098B RID: 2443
		public const string BRDA_MICROPHONECALLTARGETID = "BRDA_MICROPHONECALLTARGETID";

		// Token: 0x0400098C RID: 2444
		public const string ALLCALL = "ALLCALL";

		// Token: 0x0400098D RID: 2445
		public const string RANGECHOICE = "RANGE[@type='choice']";

		// Token: 0x0400098E RID: 2446
		public const string RANGEVALUE = "RANGE[@type='value']";

		// Token: 0x0400098F RID: 2447
		public const string RANGECOMBINE = "RANGE[@type='combine']";

		// Token: 0x04000990 RID: 2448
		public const string XPATH_ONETOUCHCALL = "//APP_PARTITION/ONE_TCH_CALL_CMP_TYPE_GRP/ONE_TCH_CALL_CMP_TYPE/OTC_UCLITEM";

		// Token: 0x04000991 RID: 2449
		public const string XPATH_POSITION = "position()";

		// Token: 0x04000992 RID: 2450
		public const string XPATH_LISTLETID_FORMAT = "//{0}[@ListID={1} and @ListLetID={2}]";

		// Token: 0x04000993 RID: 2451
		public const string LESSTHAN = "<";

		// Token: 0x04000994 RID: 2452
		public const string CFSFIELD_ATTRIB = "CFSField";

		// Token: 0x04000995 RID: 2453
		public const string CFSFEATURE = "CFSFEATURE";

		// Token: 0x04000996 RID: 2454
		public const string CFS_FIELDID = "CFS_FIELDID";

		// Token: 0x04000997 RID: 2455
		public const string DPDNCYTYPE = "DPDNCYTYPE";

		// Token: 0x04000998 RID: 2456
		public const string CFSCHOICE = "Choice";

		// Token: 0x04000999 RID: 2457
		public const string HIDE = "Hide";

		// Token: 0x0400099A RID: 2458
		public const string RESET = "Reset";

		// Token: 0x0400099B RID: 2459
		public const string CFSCHILD = "CFSChild";

		// Token: 0x0400099C RID: 2460
		public const string CFSPARENT = "CFSParent";

		// Token: 0x0400099D RID: 2461
		public const string REP_SUFFIX = "_REP";

		// Token: 0x0400099E RID: 2462
		public const string SUB_SUFFIX = "_SUB";

		// Token: 0x0400099F RID: 2463
		public const string COM_SUFFIX = "_COM";

		// Token: 0x040009A0 RID: 2464
		public const string BANDIT_SUFFIX = "_BANDIT";

		// Token: 0x040009A1 RID: 2465
		public const string SUB_PA_SUFFIX = "_SUB_PA";

		// Token: 0x040009A2 RID: 2466
		public const string SUB_PL_SUFFIX = "_SUB_PL";

		// Token: 0x040009A3 RID: 2467
		public const string ALLREP_SUFFIX = "_ALLREP";

		// Token: 0x040009A4 RID: 2468
		public const string DIGITAL_AO_SUB_SUFFIX = "DIGITAL_AO_SUB";

		// Token: 0x040009A5 RID: 2469
		public const string CONNECT_PLUS_MANDOWN_SUB_SUFFIX = "_CONNECT_PLUS_MANDOWN_SUB";

		// Token: 0x040009A6 RID: 2470
		public const string FIVETONE_SUB_SUFFIX = "_5TONE_SUB";

		// Token: 0x040009A7 RID: 2471
		public const string GPS_SUB_SUFFIX = "_GPS_SUB";

		// Token: 0x040009A8 RID: 2472
		public const string BT_DATASERVICE_SUB_SUFFIX = "BT_DATASERVICE_SUB";

		// Token: 0x040009A9 RID: 2473
		public const string DIG_EMERGENCY_SUB_SUFFIX = "DIG_EMERGENCY_SUB";

		// Token: 0x040009AA RID: 2474
		public const string REMOTE_MONITOR_SUB_SUFFIX = "REMOTE_MONITOR_SUB";

		// Token: 0x040009AB RID: 2475
		public const string RADIO_INHIBIT_SUB_SUFFIX = "RADIO_INHIBIT_SUB";

		// Token: 0x040009AC RID: 2476
		public const string NA_CAPACITY_PLUS_REP = "NA_CAPACITY_PLUS_REP";

		// Token: 0x040009AD RID: 2477
		public const string LA_CAPACITY_PLUS_REP = "LA_CAPACITY_PLUS_REP";

		// Token: 0x040009AE RID: 2478
		public const string EM_CAPACITY_PLUS_REP = "EM_CAPACITY_PLUS_REP";

		// Token: 0x040009AF RID: 2479
		public const string AS_CAPACITY_PLUS_REP = "AS_CAPACITY_PLUS_REP";

		// Token: 0x040009B0 RID: 2480
		public const string AS_CAPACITY_PLUS_SUB = "AS_CAPACITY_PLUS_SUB";

		// Token: 0x040009B1 RID: 2481
		public const string LA_IPSITE_CONNECT_REP = "LA_IPSITE_CONNECT_REP";

		// Token: 0x040009B2 RID: 2482
		public const string AS_IPSITE_CONNECT_REP = "AS_IPSITE_CONNECT_REP";

		// Token: 0x040009B3 RID: 2483
		public const string AS_IPSITE_CONNECT_SUB = "AS_IPSITE_CONNECT_SUB";

		// Token: 0x040009B4 RID: 2484
		public const string NA_DIGITAL_AO_SUB = "NA_DIGITAL_AO_SUB";

		// Token: 0x040009B5 RID: 2485
		public const string LA_DIGITAL_AO_SUB = "LA_DIGITAL_AO_SUB";

		// Token: 0x040009B6 RID: 2486
		public const string EM_DIGITAL_AO_SUB = "EM_DIGITAL_AO_SUB";

		// Token: 0x040009B7 RID: 2487
		public const string AS_DIGITAL_AO_REP = "AS_DIGITAL_AO_REP";

		// Token: 0x040009B8 RID: 2488
		public const string AS_DIGITAL_AO_SUB = "AS_DIGITAL_AO_SUB";

		// Token: 0x040009B9 RID: 2489
		public const string NA_DIGITAL_AO_SUB_PL = "NA_DIGITAL_AO_SUB_PL";

		// Token: 0x040009BA RID: 2490
		public const string LA_DIGITAL_AO_SUB_PL = "LA_DIGITAL_AO_SUB_PL";

		// Token: 0x040009BB RID: 2491
		public const string EM_DIGITAL_AO_SUB_PL = "EM_DIGITAL_AO_SUB_PL";

		// Token: 0x040009BC RID: 2492
		public const string AS_DIGITAL_AO_SUB_PL = "AS_DIGITAL_AO_SUB_PL";

		// Token: 0x040009BD RID: 2493
		public const string LA_IPSITE_CONNECT_SUB = "LA_IPSITE_CONNECT_SUB";

		// Token: 0x040009BE RID: 2494
		public const string LA_CAPACITY_PLUS_SUB = "LA_CAPACITY_PLUS_SUB";

		// Token: 0x040009BF RID: 2495
		public const string AS_ENH_PRIVACY_SUB = "AS_ENH_PRIVACY_SUB";

		// Token: 0x040009C0 RID: 2496
		public const string NA_DIGITAL_AO_REP = "NA_DIGITAL_AO_REP";

		// Token: 0x040009C1 RID: 2497
		public const string AS_TXINTERRUPT_SUB = "AS_TXINTERRUPT_SUB";

		// Token: 0x040009C2 RID: 2498
		public const string BANDIT_CAPACITY_PLUS_REP = "BANDIT_CAPACITY_PLUS_REP";

		// Token: 0x040009C3 RID: 2499
		public const string BANDIT_DMM_REP = "BANDIT_DMM_REP";

		// Token: 0x040009C4 RID: 2500
		public const string NA_DMM_REP = "NA_DMM_REP";

		// Token: 0x040009C5 RID: 2501
		public const string AS_DMM_REP = "AS_DMM_REP";

		// Token: 0x040009C6 RID: 2502
		public const string NA_CONNECT_PLUS_SUB = "NA_CONNECT_PLUS_SUB";

		// Token: 0x040009C7 RID: 2503
		public const string LA_CONNECT_PLUS_SUB = "LA_CONNECT_PLUS_SUB";

		// Token: 0x040009C8 RID: 2504
		public const string EM_CONNECT_PLUS_SUB = "EM_CONNECT_PLUS_SUB";

		// Token: 0x040009C9 RID: 2505
		public const string AS_CONNECT_PLUS_SUB = "AS_CONNECT_PLUS_SUB";

		// Token: 0x040009CA RID: 2506
		public const string RXTXFLAT = "RXTXFLAT";

		// Token: 0x040009CB RID: 2507
		public const string RXTXFILTER = "RXTXFILTER";

		// Token: 0x040009CC RID: 2508
		public const string RXFLATONLY = "RXFLATONLY";

		// Token: 0x040009CD RID: 2509
		public const string TXFLATONLY = "TXFLATONLY";

		// Token: 0x040009CE RID: 2510
		public const string CP_HCS = "CP_HCS";

		// Token: 0x040009CF RID: 2511
		public const string COMPANDING = "COMPANDING";

		// Token: 0x040009D0 RID: 2512
		public const string FLUTTERFIGHTER = "FLUTTERFIGHTER";

		// Token: 0x040009D1 RID: 2513
		public const string HEARCLEAR = "HEARCLEAR";

		// Token: 0x040009D2 RID: 2514
		public const string TRBOCPS_RRP = "TRBOCPS_RRP";

		// Token: 0x040009D3 RID: 2515
		public const string NA_TRBOCPS_RRP = "NA_TRBOCPS_RRP";

		// Token: 0x040009D4 RID: 2516
		public const string LA_TRBOCPS_RRP = "LA_TRBOCPS_RRP";

		// Token: 0x040009D5 RID: 2517
		public const string AS_TRBOCPS_RRP = "AS_TRBOCPS_RRP";

		// Token: 0x040009D6 RID: 2518
		public const string AS_MATRIXTOPHOENIX_SUB = "AS_MATRIXTOPHOENIX_SUB";

		// Token: 0x040009D7 RID: 2519
		public const string EM_MATRIXTOPHOENIX_SUB = "EM_MATRIXTOPHOENIX_SUB";

		// Token: 0x040009D8 RID: 2520
		public const string NA_ENHANCEDGPS_REP = "NA_ENHANCEDGPS_REP";

		// Token: 0x040009D9 RID: 2521
		public const string NA_ENHANCEDGPS_BANDIT = "NA_ENHANCEDGPS_BANDIT";

		// Token: 0x040009DA RID: 2522
		public const string LA_ENHANCEDGPS_REP = "LA_ENHANCEDGPS_REP";

		// Token: 0x040009DB RID: 2523
		public const string LA_ENHANCEDGPS_BANDIT = "LA_ENHANCEDGPS_BANDIT";

		// Token: 0x040009DC RID: 2524
		public const string NA_PHONE_BANDIT = "NA_PHONE_BANDIT";

		// Token: 0x040009DD RID: 2525
		public const string NA_PHONE_REP = "NA_PHONE_REP";

		// Token: 0x040009DE RID: 2526
		public const string LA_PHONE_BANDIT = "LA_PHONE_BANDIT";

		// Token: 0x040009DF RID: 2527
		public const string LA_PHONE_REP = "LA_PHONE_REP";

		// Token: 0x040009E0 RID: 2528
		public const string AS_PHONE_BANDIT = "AS_PHONE_BANDIT";

		// Token: 0x040009E1 RID: 2529
		public const string AS_PHONE_REP = "AS_PHONE_REP";

		// Token: 0x040009E2 RID: 2530
		public const string EM_PHONE_BANDIT = "EM_PHONE_BANDIT";

		// Token: 0x040009E3 RID: 2531
		public const string EM_PHONE_REP = "EM_PHONE_REP";

		// Token: 0x040009E4 RID: 2532
		public const string NA_CONNECT_PLUS_MANDOWN_SUB = "NA_CONNECT_PLUS_MANDOWN_SUB";

		// Token: 0x040009E5 RID: 2533
		public const string LA_CONNECT_PLUS_MANDOWN_SUB = "LA_CONNECT_PLUS_MANDOWN_SUB";

		// Token: 0x040009E6 RID: 2534
		public const string EM_CONNECT_PLUS_MANDOWN_SUB = "EM_CONNECT_PLUS_MANDOWN_SUB";

		// Token: 0x040009E7 RID: 2535
		public const string AS_CONNECT_PLUS_MANDOWN_SUB = "AS_CONNECT_PLUS_MANDOWN_SUB";

		// Token: 0x040009E8 RID: 2536
		public const string NA_LCP_REP = "NA_LCP_REP";

		// Token: 0x040009E9 RID: 2537
		public const string NA_LCP_BANDIT = "NA_LCP_BANDIT";

		// Token: 0x040009EA RID: 2538
		public const string LA_LCP_REP = "LA_LCP_REP";

		// Token: 0x040009EB RID: 2539
		public const string LA_LCP_BANDIT = "LA_LCP_BANDIT";

		// Token: 0x040009EC RID: 2540
		public const string EM_LCP_REP = "EM_LCP_REP";

		// Token: 0x040009ED RID: 2541
		public const string EM_LCP_BANDIT = "EM_LCP_BANDIT";

		// Token: 0x040009EE RID: 2542
		public const string AS_LCP_REP = "AS_LCP_REP";

		// Token: 0x040009EF RID: 2543
		public const string AS_LCP_BANDIT = "AS_LCP_BANDIT";

		// Token: 0x040009F0 RID: 2544
		public const string NA_LCP_FROM_IPSITE_REP = "NA_LCP_FROM_IPSITE_REP";

		// Token: 0x040009F1 RID: 2545
		public const string NA_LCP_FROM_IPSITE_BANDIT = "NA_LCP_FROM_IPSITE_BANDIT";

		// Token: 0x040009F2 RID: 2546
		public const string LA_LCP_FROM_IPSITE_REP = "LA_LCP_FROM_IPSITE_REP";

		// Token: 0x040009F3 RID: 2547
		public const string LA_LCP_FROM_IPSITE_BANDIT = "LA_LCP_FROM_IPSITE_BANDIT";

		// Token: 0x040009F4 RID: 2548
		public const string AS_LCP_FROM_IPSITE_REP = "AS_LCP_FROM_IPSITE_REP";

		// Token: 0x040009F5 RID: 2549
		public const string AS_LCP_FROM_IPSITE_BANDIT = "AS_LCP_FROM_IPSITE_BANDIT";

		// Token: 0x040009F6 RID: 2550
		public const string NA_LCP_FROM_CAPPLUS_REP = "NA_LCP_FROM_CAPPLUS_REP";

		// Token: 0x040009F7 RID: 2551
		public const string NA_LCP_FROM_CAPPLUS_BANDIT = "NA_LCP_FROM_CAPPLUS_BANDIT";

		// Token: 0x040009F8 RID: 2552
		public const string LA_LCP_FROM_CAPPLUS_REP = "LA_LCP_FROM_CAPPLUS_REP";

		// Token: 0x040009F9 RID: 2553
		public const string LA_LCP_FROM_CAPPLUS_BANDIT = "LA_LCP_FROM_CAPPLUS_BANDIT";

		// Token: 0x040009FA RID: 2554
		public const string EM_LCP_FROM_CAPPLUS_REP = "EM_LCP_FROM_CAPPLUS_REP";

		// Token: 0x040009FB RID: 2555
		public const string EM_LCP_FROM_CAPPLUS_BANDIT = "EM_LCP_FROM_CAPPLUS_BANDIT";

		// Token: 0x040009FC RID: 2556
		public const string AS_LCP_FROM_CAPPLUS_REP = "AS_LCP_FROM_CAPPLUS_REP";

		// Token: 0x040009FD RID: 2557
		public const string AS_LCP_FROM_CAPPLUS_BANDIT = "AS_LCP_FROM_CAPPLUS_BANDIT";

		// Token: 0x040009FE RID: 2558
		public const string NA_RAS_REP = "NA_RAS_REP";

		// Token: 0x040009FF RID: 2559
		public const string NA_RAS_BANDIT = "NA_RAS_BANDIT";

		// Token: 0x04000A00 RID: 2560
		public const string LA_RAS_REP = "LA_RAS_REP";

		// Token: 0x04000A01 RID: 2561
		public const string LA_RAS_BANDIT = "LA_RAS_BANDIT";

		// Token: 0x04000A02 RID: 2562
		public const string NA_WIRELINEVANDDL1_REP = "NA_WIRELINEVANDDL1_REP";

		// Token: 0x04000A03 RID: 2563
		public const string NA_WIRELINEVANDDL1_BANDIT = "NA_WIRELINEVANDDL1_BANDIT";

		// Token: 0x04000A04 RID: 2564
		public const string LA_WIRELINEVANDDL1_REP = "LA_WIRELINEVANDDL1_REP";

		// Token: 0x04000A05 RID: 2565
		public const string LA_WIRELINEVANDDL1_BANDIT = "LA_WIRELINEVANDDL1_BANDIT";

		// Token: 0x04000A06 RID: 2566
		public const string EM_WIRELINEVANDDL1_REP = "EM_WIRELINEVANDDL1_REP";

		// Token: 0x04000A07 RID: 2567
		public const string EM_WIRELINEVANDDL1_BANDIT = "EM_WIRELINEVANDDL1_BANDIT";

		// Token: 0x04000A08 RID: 2568
		public const string AS_WIRELINEVANDDL1_REP = "AS_WIRELINEVANDDL1_REP";

		// Token: 0x04000A09 RID: 2569
		public const string AS_WIRELINEVANDDL1_BANDIT = "AS_WIRELINEVANDDL1_BANDIT";

		// Token: 0x04000A0A RID: 2570
		public const string NA_WIRELINEVANDDL2_REP = "NA_WIRELINEVANDDL2_REP";

		// Token: 0x04000A0B RID: 2571
		public const string NA_WIRELINEVANDDL2_BANDIT = "NA_WIRELINEVANDDL2_BANDIT";

		// Token: 0x04000A0C RID: 2572
		public const string LA_WIRELINEVANDDL2_REP = "LA_WIRELINEVANDDL2_REP";

		// Token: 0x04000A0D RID: 2573
		public const string LA_WIRELINEVANDDL2_BANDIT = "LA_WIRELINEVANDDL2_BANDIT";

		// Token: 0x04000A0E RID: 2574
		public const string EM_WIRELINEVANDDL2_REP = "EM_WIRELINEVANDDL2_REP";

		// Token: 0x04000A0F RID: 2575
		public const string EM_WIRELINEVANDDL2_BANDIT = "EM_WIRELINEVANDDL2_BANDIT";

		// Token: 0x04000A10 RID: 2576
		public const string AS_WIRELINEVANDDL2_REP = "AS_WIRELINEVANDDL2_REP";

		// Token: 0x04000A11 RID: 2577
		public const string AS_WIRELINEVANDDL2_BANDIT = "AS_WIRELINEVANDDL2_BANDIT";

		// Token: 0x04000A12 RID: 2578
		public const string NA_ATEXCSAMANDOWN_SUB = "NA_ATEXCSAMANDOWN_SUB";

		// Token: 0x04000A13 RID: 2579
		public const string EM_PHONE_SUB = "EM_PHONE_SUB";

		// Token: 0x04000A14 RID: 2580
		public const string NA_DIGITALVOTING_REP = "NA_DIGITALVOTING_REP";

		// Token: 0x04000A15 RID: 2581
		public const string NA_DIGITALVOTING_BANDIT = "NA_DIGITALVOTING_BANDIT";

		// Token: 0x04000A16 RID: 2582
		public const string LA_DIGITALVOTING_REP = "LA_DIGITALVOTING_REP";

		// Token: 0x04000A17 RID: 2583
		public const string LA_DIGITALVOTING_BANDIT = "LA_DIGITALVOTING_BANDIT";

		// Token: 0x04000A18 RID: 2584
		public const string EM_DIGITALVOTING_REP = "EM_DIGITALVOTING_REP";

		// Token: 0x04000A19 RID: 2585
		public const string EM_DIGITALVOTING_BANDIT = "EM_DIGITALVOTING_BANDIT";

		// Token: 0x04000A1A RID: 2586
		public const string AS_DIGITALVOTING_REP = "AS_DIGITALVOTING_REP";

		// Token: 0x04000A1B RID: 2587
		public const string AS_DIGITALVOTING_BANDIT = "AS_DIGITALVOTING_BANDIT";

		// Token: 0x04000A1C RID: 2588
		public const string AS_KEEPALIVE_SUB = "AS_KEEPALIVE_SUB";

		// Token: 0x04000A1D RID: 2589
		public const string NA_IPSITE_CONNECT_SUB = "NA_IPSITE_CONNECT_SUB";

		// Token: 0x04000A1E RID: 2590
		public const string EM_IPSITE_CONNECT_SUB = "EM_IPSITE_CONNECT_SUB";

		// Token: 0x04000A1F RID: 2591
		public const string NA_CAPACITY_PLUS_SUB = "NA_CAPACITY_PLUS_SUB";

		// Token: 0x04000A20 RID: 2592
		public const string EM_CAPACITY_PLUS_SUB = "EM_CAPACITY_PLUS_SUB";

		// Token: 0x04000A21 RID: 2593
		public const string NA_ENH_PRIVACY_SUB = "NA_ENH_PRIVACY_SUB";

		// Token: 0x04000A22 RID: 2594
		public const string LA_ENH_PRIVACY_SUB = "LA_ENH_PRIVACY_SUB";

		// Token: 0x04000A23 RID: 2595
		public const string EM_ENH_PRIVACY_SUB = "EM_ENH_PRIVACY_SUB";

		// Token: 0x04000A24 RID: 2596
		public const string NA_TXINTERRUPT_SUB = "NA_TXINTERRUPT_SUB";

		// Token: 0x04000A25 RID: 2597
		public const string LA_TXINTERRUPT_SUB = "LA_TXINTERRUPT_SUB";

		// Token: 0x04000A26 RID: 2598
		public const string EM_TXINTERRUPT_SUB = "EM_TXINTERRUPT_SUB";

		// Token: 0x04000A27 RID: 2599
		public const string NA_5TONE_SUB = "NA_5TONE_SUB";

		// Token: 0x04000A28 RID: 2600
		public const string LA_5TONE_SUB = "LA_5TONE_SUB";

		// Token: 0x04000A29 RID: 2601
		public const string EM_5TONE_SUB = "EM_5TONE_SUB";

		// Token: 0x04000A2A RID: 2602
		public const string AS_5TONE_SUB = "AS_5TONE_SUB";

		// Token: 0x04000A2B RID: 2603
		public const string NA_GPS_SUB = "NA_GPS_SUB";

		// Token: 0x04000A2C RID: 2604
		public const string LA_GPS_SUB = "LA_GPS_SUB";

		// Token: 0x04000A2D RID: 2605
		public const string EM_GPS_SUB = "EM_GPS_SUB";

		// Token: 0x04000A2E RID: 2606
		public const string AS_GPS_SUB = "AS_GPS_SUB";

		// Token: 0x04000A2F RID: 2607
		public const string LA_PHONE_SUB = "LA_PHONE_SUB";

		// Token: 0x04000A30 RID: 2608
		public const string NA_LCP_SUB = "NA_LCP_SUB";

		// Token: 0x04000A31 RID: 2609
		public const string LA_LCP_SUB = "LA_LCP_SUB";

		// Token: 0x04000A32 RID: 2610
		public const string EM_LCP_SUB = "EM_LCP_SUB";

		// Token: 0x04000A33 RID: 2611
		public const string AS_LCP_SUB = "AS_LCP_SUB";

		// Token: 0x04000A34 RID: 2612
		public const string NA_LCP_FROM_IPSITE_SUB = "NA_LCP_FROM_IPSITE_SUB";

		// Token: 0x04000A35 RID: 2613
		public const string LA_LCP_FROM_IPSITE_SUB = "LA_LCP_FROM_IPSITE_SUB";

		// Token: 0x04000A36 RID: 2614
		public const string AS_LCP_FROM_IPSITE_SUB = "AS_LCP_FROM_IPSITE_SUB";

		// Token: 0x04000A37 RID: 2615
		public const string LA_LCP_FROM_CAPPLUS_SUB = "LA_LCP_FROM_CAPPLUS_SUB";

		// Token: 0x04000A38 RID: 2616
		public const string EM_LCP_FROM_CAPPLUS_SUB = "EM_LCP_FROM_CAPPLUS_SUB";

		// Token: 0x04000A39 RID: 2617
		public const string AS_LCP_FROM_CAPPLUS_SUB = "AS_LCP_FROM_CAPPLUS_SUB";

		// Token: 0x04000A3A RID: 2618
		public const string NA_BT_DATASERVICE_SUB = "NA_BT_DATASERVICE_SUB";

		// Token: 0x04000A3B RID: 2619
		public const string EM_BT_DATASERVICE_SUB = "EM_BT_DATASERVICE_SUB";

		// Token: 0x04000A3C RID: 2620
		public const string LA_BT_DATASERVICE_SUB = "LA_BT_DATASERVICE_SUB";

		// Token: 0x04000A3D RID: 2621
		public const string AS_DIG_EMERGENCY_SUB = "AS_DIG_EMERGENCY_SUB";

		// Token: 0x04000A3E RID: 2622
		public const string AS_REMOTE_MONITOR_SUB = "AS_REMOTE_MONITOR_SUB";

		// Token: 0x04000A3F RID: 2623
		public const string AS_RADIO_INHIBIT_SUB = "AS_RADIO_INHIBIT_SUB";

		// Token: 0x04000A40 RID: 2624
		public const string AS_PDT_SUB = "AS_PDT_SUB";

		// Token: 0x04000A41 RID: 2625
		public const string AS_PDT_REP = "AS_PDT_REP";

		// Token: 0x04000A42 RID: 2626
		public const string AS_PDT_BANDIT = "AS_PDT_BANDIT";

		// Token: 0x04000A43 RID: 2627
		public const string NA_TRBOCPS_RMSERVER_RM = "NA_TRBOCPS_RMSERVER_RM";

		// Token: 0x04000A44 RID: 2628
		public const string LA_TRBOCPS_RMSERVER_RM = "LA_TRBOCPS_RMSERVER_RM";

		// Token: 0x04000A45 RID: 2629
		public const string AS_TRBOCPS_RMSERVER_RM = "AS_TRBOCPS_RMSERVER_RM";

		// Token: 0x04000A46 RID: 2630
		public const string EM_TRBOCPS_RMSERVER_RM = "EM_TRBOCPS_RMSERVER_RM";

		// Token: 0x04000A47 RID: 2631
		public const string NA_AESPRIVACY_SUB = "NA_AESPRIVACY_SUB";

		// Token: 0x04000A48 RID: 2632
		public const string LA_AESPRIVACY_SUB = "LA_AESPRIVACY_SUB";

		// Token: 0x04000A49 RID: 2633
		public const string EM_AESPRIVACY_SUB = "EM_AESPRIVACY_SUB";

		// Token: 0x04000A4A RID: 2634
		public const string AS_AESPRIVACY_SUB = "AS_AESPRIVACY_SUB";

		// Token: 0x04000A4B RID: 2635
		public const string NA_BTPERMDISCOVERABLEMODE_SUB = "NA_BTPERMDISCOVERABLEMODE_SUB";

		// Token: 0x04000A4C RID: 2636
		public const string LA_BTPERMDISCOVERABLEMODE_SUB = "LA_BTPERMDISCOVERABLEMODE_SUB";

		// Token: 0x04000A4D RID: 2637
		public const string EM_BTPERMDISCOVERABLEMODE_SUB = "EM_BTPERMDISCOVERABLEMODE_SUB";

		// Token: 0x04000A4E RID: 2638
		public const string AS_BTPERMDISCOVERABLEMODE_SUB = "AS_BTPERMDISCOVERABLEMODE_SUB";

		// Token: 0x04000A4F RID: 2639
		public const string AS_EOB_SUB = "AS_EOB_SUB";

		// Token: 0x04000A50 RID: 2640
		public const string AS_PHONE_SUB = "AS_PHONE_SUB";

		// Token: 0x04000A51 RID: 2641
		public const string NA_PHONE_SUB = "NA_PHONE_SUB";

		// Token: 0x04000A52 RID: 2642
		public const string EM_CBFREQUENCY_SUB = "EM_CBFREQUENCY_SUB";

		// Token: 0x04000A53 RID: 2643
		public const string AS_EOT_SUB = "AS_EOT_SUB";

		// Token: 0x04000A54 RID: 2644
		public const string AS_TTS_SUB = "AS_TTS_SUB";

		// Token: 0x04000A55 RID: 2645
		public const string EM_TTS_SUB = "EM_TTS_SUB";

		// Token: 0x04000A56 RID: 2646
		public const string LA_TTS_SUB = "LA_TTS_SUB";

		// Token: 0x04000A57 RID: 2647
		public const string NA_TTS_SUB = "NA_TTS_SUB";

		// Token: 0x04000A58 RID: 2648
		public const string AS_MULTIBUTTONPTT_SUB = "AS_MULTIBUTTONPTT_SUB";

		// Token: 0x04000A59 RID: 2649
		public const string EM_MULTIBUTTONPTT_SUB = "EM_MULTIBUTTONPTT_SUB";

		// Token: 0x04000A5A RID: 2650
		public const string LA_MULTIBUTTONPTT_SUB = "LA_MULTIBUTTONPTT_SUB";

		// Token: 0x04000A5B RID: 2651
		public const string NA_MULTIBUTTONPTT_SUB = "NA_MULTIBUTTONPTT_SUB";

		// Token: 0x04000A5C RID: 2652
		public const string GLOBAL_FEATURE_PREFIX = "GLOBAL_";

		// Token: 0x04000A5D RID: 2653
		public const string GLOBAL_LCPEXTENDED_SUB = "GLOBAL_LCPEXTENDED_SUB";

		// Token: 0x04000A5E RID: 2654
		public const string GLOBAL_LCPEXTENDED_REP = "GLOBAL_LCPEXTENDED_REP";

		// Token: 0x04000A5F RID: 2655
		public const string GLOBAL_LCPEXTENDED_BANDIT = "GLOBAL_LCPEXTENDED_BANDIT";

		// Token: 0x04000A60 RID: 2656
		public const string GLOBAL_GPSPRIOVERVOICE_SUB = "GLOBAL_GPSPRIOVERVOICE_SUB";

		// Token: 0x04000A61 RID: 2657
		public const string GLOBAL_OTAR_SUB = "GLOBAL_OTAR_SUB";

		// Token: 0x04000A62 RID: 2658
		public const string AS_EXTNOISESUPPRESSOR_SUB = "AS_EXTNOISESUPPRESSOR_SUB";

		// Token: 0x04000A63 RID: 2659
		public const string EM_EXTNOISESUPPRESSOR_SUB = "EM_EXTNOISESUPPRESSOR_SUB";

		// Token: 0x04000A64 RID: 2660
		public const string LA_EXTNOISESUPPRESSOR_SUB = "LA_EXTNOISESUPPRESSOR_SUB";

		// Token: 0x04000A65 RID: 2661
		public const string NA_EXTNOISESUPPRESSOR_SUB = "NA_EXTNOISESUPPRESSOR_SUB";

		// Token: 0x04000A66 RID: 2662
		public const string AS_TMSMAXSEND280_SUB = "AS_TMSMAXSEND280_SUB";

		// Token: 0x04000A67 RID: 2663
		public const string EM_TMSMAXSEND280_SUB = "EM_TMSMAXSEND280_SUB";

		// Token: 0x04000A68 RID: 2664
		public const string LA_TMSMAXSEND280_SUB = "LA_TMSMAXSEND280_SUB";

		// Token: 0x04000A69 RID: 2665
		public const string NA_TMSMAXSEND280_SUB = "NA_TMSMAXSEND280_SUB";

		// Token: 0x04000A6A RID: 2666
		public const string AS_WIFI_SUB = "AS_WIFI_SUB";

		// Token: 0x04000A6B RID: 2667
		public const string EM_WIFI_SUB = "EM_WIFI_SUB";

		// Token: 0x04000A6C RID: 2668
		public const string LA_WIFI_SUB = "LA_WIFI_SUB";

		// Token: 0x04000A6D RID: 2669
		public const string NA_WIFI_SUB = "NA_WIFI_SUB";

		// Token: 0x04000A6E RID: 2670
		public const string AS_ATEXCSAMANDOWN_SUB = "AS_ATEXCSAMANDOWN_SUB";

		// Token: 0x04000A6F RID: 2671
		public const string EM_ATEXCSAMANDOWN_SUB = "EM_ATEXCSAMANDOWN_SUB";

		// Token: 0x04000A70 RID: 2672
		public const string LA_ATEXCSAMANDOWN_SUB = "LA_ATEXCSAMANDOWN_SUB";

		// Token: 0x04000A71 RID: 2673
		public const string AS_AUTHRADIODISABLE_SUB = "AS_AUTHRADIODISABLE_SUB";

		// Token: 0x04000A72 RID: 2674
		public const string EM_AUTHRADIODISABLE_SUB = "EM_AUTHRADIODISABLE_SUB";

		// Token: 0x04000A73 RID: 2675
		public const string LA_AUTHRADIODISABLE_SUB = "LA_AUTHRADIODISABLE_SUB";

		// Token: 0x04000A74 RID: 2676
		public const string AS_TRANSMITINHIBIT_SUB = "AS_TRANSMITINHIBIT_SUB";

		// Token: 0x04000A75 RID: 2677
		public const string EM_TRANSMITINHIBIT_SUB = "EM_TRANSMITINHIBIT_SUB";

		// Token: 0x04000A76 RID: 2678
		public const string LA_TRANSMITINHIBIT_SUB = "LA_TRANSMITINHIBIT_SUB";

		// Token: 0x04000A77 RID: 2679
		public const string NA_TRANSMITINHIBIT_SUB = "NA_TRANSMITINHIBIT_SUB";

		// Token: 0x04000A78 RID: 2680
		public const string NA_MUTEMODE_SUB = "NA_MUTEMODE_SUB";

		// Token: 0x04000A79 RID: 2681
		public const string LA_MUTEMODE_SUB = "LA_MUTEMODE_SUB";

		// Token: 0x04000A7A RID: 2682
		public const string EM_MUTEMODE_SUB = "EM_MUTEMODE_SUB";

		// Token: 0x04000A7B RID: 2683
		public const string AS_MUTEMODE_SUB = "AS_MUTEMODE_SUB";

		// Token: 0x04000A7C RID: 2684
		public const string NA_RXAUDIOLEVELING_SUB = "NA_RXAUDIOLEVELING_SUB";

		// Token: 0x04000A7D RID: 2685
		public const string LA_RXAUDIOLEVELING_SUB = "LA_RXAUDIOLEVELING_SUB";

		// Token: 0x04000A7E RID: 2686
		public const string EM_RXAUDIOLEVELING_SUB = "EM_RXAUDIOLEVELING_SUB";

		// Token: 0x04000A7F RID: 2687
		public const string AS_RXAUDIOLEVELING_SUB = "AS_RXAUDIOLEVELING_SUB";

		// Token: 0x04000A80 RID: 2688
		public const string NA_INDOORLOC_SUB = "NA_INDOORLOC_SUB";

		// Token: 0x04000A81 RID: 2689
		public const string AS_INDOORLOC_SUB = "AS_INDOORLOC_SUB";

		// Token: 0x04000A82 RID: 2690
		public const string EM_INDOORLOC_SUB = "EM_INDOORLOC_SUB";

		// Token: 0x04000A83 RID: 2691
		public const string LA_INDOORLOC_SUB = "LA_INDOORLOC_SUB";

		// Token: 0x04000A84 RID: 2692
		public const string NA_SFR_ALLREP = "NA_SFR_ALLREP";

		// Token: 0x04000A85 RID: 2693
		public const string LA_SFR_ALLREP = "LA_SFR_ALLREP";

		// Token: 0x04000A86 RID: 2694
		public const string EM_SFR_ALLREP = "EM_SFR_ALLREP";

		// Token: 0x04000A87 RID: 2695
		public const string AS_SFR_ALLREP = "AS_SFR_ALLREP";

		// Token: 0x04000A88 RID: 2696
		public const string AS_RESPONSEINHIBIT_SUB = "AS_RESPONSEINHIBIT_SUB";

		// Token: 0x04000A89 RID: 2697
		public const string EM_RESPONSEINHIBIT_SUB = "EM_RESPONSEINHIBIT_SUB";

		// Token: 0x04000A8A RID: 2698
		public const string LA_RESPONSEINHIBIT_SUB = "LA_RESPONSEINHIBIT_SUB";

		// Token: 0x04000A8B RID: 2699
		public const string NA_RESPONSEINHIBIT_SUB = "NA_RESPONSEINHIBIT_SUB";

		// Token: 0x04000A8C RID: 2700
		public const string GLOBAL_ATPTT_SUB = "GLOBAL_ATPTT_SUB";

		// Token: 0x04000A8D RID: 2701
		public const string AS_THIRDPTYDMRLNKCTL_SUB = "AS_THIRDPTYDMRLNKCTL_SUB";

		// Token: 0x04000A8E RID: 2702
		public const string AS_THIRDPTYDMRLNKCTL_ALLREP = "AS_THIRDPTYDMRLNKCTL_ALLREP";

		// Token: 0x04000A8F RID: 2703
		public const string NA_DIGITALAUDIO_ALLREP = "NA_DIGITALAUDIO_ALLREP";

		// Token: 0x04000A90 RID: 2704
		public const string LA_DIGITALAUDIO_ALLREP = "LA_DIGITALAUDIO_ALLREP";

		// Token: 0x04000A91 RID: 2705
		public const string EM_DIGITALAUDIO_ALLREP = "EM_DIGITALAUDIO_ALLREP";

		// Token: 0x04000A92 RID: 2706
		public const string AS_DIGITALAUDIO_ALLREP = "AS_DIGITALAUDIO_ALLREP";

		// Token: 0x04000A93 RID: 2707
		public const string CFS_CAPPLUS = "CFS_CAPPLUS";

		// Token: 0x04000A94 RID: 2708
		public const string CFS_IPSITECON = "CFS_IPSITECON";

		// Token: 0x04000A95 RID: 2709
		public const string CFS_ENHPRIVACY = "CFS_ENHPRIVACY";

		// Token: 0x04000A96 RID: 2710
		public const string CFS_DIGITAL = "CFS_DIGITAL";

		// Token: 0x04000A97 RID: 2711
		public const string CFS_TRANSINT = "CFS_TRANSINT";

		// Token: 0x04000A98 RID: 2712
		public const string CFS_DMM = "CFS_DMM";

		// Token: 0x04000A99 RID: 2713
		public const string CFS_NEPTUNE = "CFS_NEPTUNE";

		// Token: 0x04000A9A RID: 2714
		public const string CFS_ENHGPS = "CFS_ENHGPS";

		// Token: 0x04000A9B RID: 2715
		public const string CFS_GPSEN = "CFS_GPSEN";

		// Token: 0x04000A9C RID: 2716
		public const string CFS_MTRTOPHNFWCVT = "CFS_MTRTOPHNFWCVT";

		// Token: 0x04000A9D RID: 2717
		public const string CFS_DGTLPHNPTC = "CFS_DGTLPHNPTC";

		// Token: 0x04000A9E RID: 2718
		public const string CFS_5TONE = "CFS_5TONE";

		// Token: 0x04000A9F RID: 2719
		public const string CFS_CONNECT_PLUS_MANDOWN = "CFS_CONNECT_PLUS_MANDOWN";

		// Token: 0x04000AA0 RID: 2720
		public const string CFS_LCP = "CFS_LCP";

		// Token: 0x04000AA1 RID: 2721
		public const string CFS_OTAP = "CFS_OTAP";

		// Token: 0x04000AA2 RID: 2722
		public const string CFS_BTDATASERVICE = "CFS_BTDATASERVICE";

		// Token: 0x04000AA3 RID: 2723
		public const string CFS_DGTEMGR = "CFS_DGTEMGR";

		// Token: 0x04000AA4 RID: 2724
		public const string CFS_RMTMNT = "CFS_RMTMNT";

		// Token: 0x04000AA5 RID: 2725
		public const string CFS_RDIHBT = "CFS_RDIHBT";

		// Token: 0x04000AA6 RID: 2726
		public const string CFS_PDT = "CFS_PDT";

		// Token: 0x04000AA7 RID: 2727
		public const string CFS_RAS = "CFS_RAS";

		// Token: 0x04000AA8 RID: 2728
		public const string CFS_WIRELINEVANDDL1 = "CFS_WIRELINEVANDDL1";

		// Token: 0x04000AA9 RID: 2729
		public const string CFS_WIRELINEVANDDL2 = "CFS_WIRELINEVANDDL2";

		// Token: 0x04000AAA RID: 2730
		public const string CFS_ATEXCSAMANDOWN = "CFS_ATEXCSAMANDOWN";

		// Token: 0x04000AAB RID: 2731
		public const string CFS_DIGITALVOTING = "CFS_DIGITALVOTING";

		// Token: 0x04000AAC RID: 2732
		public const string CFS_BTPERMANENTDISCOVERABLEMODE = "CFS_BTPERMANENTDISCOVERABLEMODE";

		// Token: 0x04000AAD RID: 2733
		public const string CFS_AESPRIVACY = "CFS_AESPRIVACY";

		// Token: 0x04000AAE RID: 2734
		public const string CFS_EOB = "CFS_EOB";

		// Token: 0x04000AAF RID: 2735
		public const string CFS_KEEPALIVE = "CFS_KEEPALIVE";

		// Token: 0x04000AB0 RID: 2736
		public const string CFS_SATELLITERECEIVER = "CFS_SATELLITERECEIVER";

		// Token: 0x04000AB1 RID: 2737
		public const string CFS_CBFREQUENCY = "CFS_CBFREQUENCY";

		// Token: 0x04000AB2 RID: 2738
		public const string CP_CBCHANNEL = "CP_CBCHANNEL";

		// Token: 0x04000AB3 RID: 2739
		public const string CFS_EOT = "CFS_EOT";

		// Token: 0x04000AB4 RID: 2740
		public const string CFS_TTS = "CFS_TTS";

		// Token: 0x04000AB5 RID: 2741
		public const string CFS_MULTIBUTTONPTT = "CFS_MULTIBUTTONPTT";

		// Token: 0x04000AB6 RID: 2742
		public const string CFS_LCPEXTENDED = "CFS_LCPEXTENDED";

		// Token: 0x04000AB7 RID: 2743
		public const string CFS_GPSPRIORITYOVERVOICE = "CFS_GPSPRIORITYOVERVOICE";

		// Token: 0x04000AB8 RID: 2744
		public const string CFS_OTAR = "CFS_OTAR";

		// Token: 0x04000AB9 RID: 2745
		public const string CFS_NOISESUPPRESSORFORSINCPLUS = "CFS_NOISESUPPRESSORFORSINCPLUS";

		// Token: 0x04000ABA RID: 2746
		public const string CFS_TMSMAXSEND280 = "CFS_TMSMAXSEND280";

		// Token: 0x04000ABB RID: 2747
		public const string CFS_WIFI = "CFS_WIFI";

		// Token: 0x04000ABC RID: 2748
		public const string CFS_AUTHRADIODISABLE = "CFS_AUTHRADIODISABLE";

		// Token: 0x04000ABD RID: 2749
		public const string CFS_TRANSMITINHIBIT = "CFS_TRANSMITINHIBIT";

		// Token: 0x04000ABE RID: 2750
		public const string CFS_INDOORLOCATION = "CFS_INDOORLOCATION";

		// Token: 0x04000ABF RID: 2751
		public const string CFS_THIRDPTYDMRLNKCTL = "CFS_THIRDPTYDMRLNKCTL";

		// Token: 0x04000AC0 RID: 2752
		public const string CFS_MUTEMODE = "CFS_MUTEMODE";

		// Token: 0x04000AC1 RID: 2753
		public const string CFS_RXAUDIOLEVELING = "CFS_RXAUDIOLEVELING";

		// Token: 0x04000AC2 RID: 2754
		public const string CFS_RESPONSEINHIBIT = "CFS_RESPONSEINHIBIT";

		// Token: 0x04000AC3 RID: 2755
		public const string CFS_DIGITALAUDIO = "CFS_DIGITALAUDIO";

		// Token: 0x04000AC4 RID: 2756
		public const string CFS_SINGLEFREQUENCYREPEATER = "CFS_SINGLEFREQUENCYREPEATER";

		// Token: 0x04000AC5 RID: 2757
		public const string CFS_ATPTT = "CFS_ATPTT";

		// Token: 0x04000AC6 RID: 2758
		public const string NA_TRBOCPS_NPSPAC = "NA_TRBOCPS_NPSPAC";

		// Token: 0x04000AC7 RID: 2759
		public const string NA_TRBOCPS_25KHZ = "NA_TRBOCPS_25KHZ";

		// Token: 0x04000AC8 RID: 2760
		public const string EM_TRBOCPS_NONSPAINFREQ = "EM_TRBOCPS_NONSPAINFREQ";

		// Token: 0x04000AC9 RID: 2761
		public const string LTD_CFS_CMP_TYPE = "LTD_CFS_CMP_TYPE";

		// Token: 0x04000ACA RID: 2762
		public const string LTD_CFS_CMP_TYPE_GRP = "LTD_CFS_CMP_TYPE_GRP";

		// Token: 0x04000ACB RID: 2763
		public const string NO_INTEGRITYCHECK = "NO_INTEGRITYCHECK";

		// Token: 0x04000ACC RID: 2764
		public const string LTD_CFS_LIST = "LTD_CFS_LIST";

		// Token: 0x04000ACD RID: 2765
		public const string CONTROL = "Control";

		// Token: 0x04000ACE RID: 2766
		public const string LIST = "List";

		// Token: 0x04000ACF RID: 2767
		public const string UPDATES = "UPDATES";

		// Token: 0x04000AD0 RID: 2768
		public const string DELETED = "DELETED";

		// Token: 0x04000AD1 RID: 2769
		public const string UNDOS = "UNDOS";

		// Token: 0x04000AD2 RID: 2770
		public const string TYPEID = "TypeID";

		// Token: 0x04000AD3 RID: 2771
		public const string TRKSYSID = "TRKSYSID";

		// Token: 0x04000AD4 RID: 2772
		public const string TGTYPEID = "TGTYPEID";

		// Token: 0x04000AD5 RID: 2773
		public const string NULL = "NULL";

		// Token: 0x04000AD6 RID: 2774
		public const string STR_ = "STR_";

		// Token: 0x04000AD7 RID: 2775
		public const string STR_0 = "0";

		// Token: 0x04000AD8 RID: 2776
		public const string STR_1 = "1";

		// Token: 0x04000AD9 RID: 2777
		public const string STR_2 = "2";

		// Token: 0x04000ADA RID: 2778
		public const string STR_3 = "3";

		// Token: 0x04000ADB RID: 2779
		public const string STR_4 = "4";

		// Token: 0x04000ADC RID: 2780
		public const string STR_5 = "5";

		// Token: 0x04000ADD RID: 2781
		public const string STR_6 = "6";

		// Token: 0x04000ADE RID: 2782
		public const string STR_7 = "7";

		// Token: 0x04000ADF RID: 2783
		public const string STR_8 = "8";

		// Token: 0x04000AE0 RID: 2784
		public const string STR_10 = "10";

		// Token: 0x04000AE1 RID: 2785
		public const string STR_12 = "12";

		// Token: 0x04000AE2 RID: 2786
		public const string STR_127 = "127";

		// Token: 0x04000AE3 RID: 2787
		public const string STR_NEG1 = "-1";

		// Token: 0x04000AE4 RID: 2788
		public const string STR_NEG6 = "-6";

		// Token: 0x04000AE5 RID: 2789
		public const string STR_255 = "255";

		// Token: 0x04000AE6 RID: 2790
		public const string STR_250 = "250";

		// Token: 0x04000AE7 RID: 2791
		public const string STR_NEG_128 = "-128";

		// Token: 0x04000AE8 RID: 2792
		public const string STR_0_STR = "STR_0";

		// Token: 0x04000AE9 RID: 2793
		public const string CMP_TYPE = "CMP_TYPE";

		// Token: 0x04000AEA RID: 2794
		public const string DLT_TYPE = "DLT_TYPE";

		// Token: 0x04000AEB RID: 2795
		public const string DLH_TYPE = "DLH_TYPE";

		// Token: 0x04000AEC RID: 2796
		public const string DLL_TYPE = "DLL_TYPE";

		// Token: 0x04000AED RID: 2797
		public const string ELT_TYPE = "ELT_TYPE";

		// Token: 0x04000AEE RID: 2798
		public const string ELH_TYPE = "ELH_TYPE";

		// Token: 0x04000AEF RID: 2799
		public const string ELL_TYPE = "ELL_TYPE";

		// Token: 0x04000AF0 RID: 2800
		public const string NEO = "Neo";

		// Token: 0x04000AF1 RID: 2801
		public const string MORPHEUS = "Morpheus";

		// Token: 0x04000AF2 RID: 2802
		public const string CYPHER = "Cypher";

		// Token: 0x04000AF3 RID: 2803
		public const string BAHAMA = "Bahama";

		// Token: 0x04000AF4 RID: 2804
		public const string ABACO = "Abaco";

		// Token: 0x04000AF5 RID: 2805
		public const string ANDROS = "Andros";

		// Token: 0x04000AF6 RID: 2806
		public const string NEOP = "NeoP";

		// Token: 0x04000AF7 RID: 2807
		public const string MORPHEUSP = "MorpheusP";

		// Token: 0x04000AF8 RID: 2808
		public const string NEO_CSA = "Neo_CSA";

		// Token: 0x04000AF9 RID: 2809
		public const string LP = "LP";

		// Token: 0x04000AFA RID: 2810
		public const string HP = "HP";

		// Token: 0x04000AFB RID: 2811
		public const string STR_CONCATWDASH = "ConcatWDash";

		// Token: 0x04000AFC RID: 2812
		public const string STR_CONCATWSLASH = "ConcatWSlash";

		// Token: 0x04000AFD RID: 2813
		public const string STR_CONCATWDOT = "ConcatWDot";

		// Token: 0x04000AFE RID: 2814
		public const string STR_CONCATWCOLON = "ConcatWColon";

		// Token: 0x04000AFF RID: 2815
		public const string STR_MODELDEPENDENT = "STR_MODELDEPENDENT";

		// Token: 0x04000B00 RID: 2816
		public const string STR_DERIVEDFLD = "STR_DERIVEDFLD";

		// Token: 0x04000B01 RID: 2817
		public const string STR_CONCAT = "Concat";

		// Token: 0x04000B02 RID: 2818
		public const string BELIZE = "Belize";

		// Token: 0x04000B03 RID: 2819
		public const string BELIZEP = "BelizeP";

		// Token: 0x04000B04 RID: 2820
		public const string BELIZELK = "BelizeLK";

		// Token: 0x04000B05 RID: 2821
		public const string BALI = "Bali";

		// Token: 0x04000B06 RID: 2822
		public const string BALIP = "BaliP";

		// Token: 0x04000B07 RID: 2823
		public const string ANDORRA = "Andorra";

		// Token: 0x04000B08 RID: 2824
		public const string ANDORRAP = "AndorraP";

		// Token: 0x04000B09 RID: 2825
		public const string MALTA = "Malta";

		// Token: 0x04000B0A RID: 2826
		public const string TIMORP = "TimorP";

		// Token: 0x04000B0B RID: 2827
		public const string TAHITI = "Tahiti";

		// Token: 0x04000B0C RID: 2828
		public const string TAHITIP = "TahitiP";

		// Token: 0x04000B0D RID: 2829
		public const string TAHITIPLUS = "TahitiPlus";

		// Token: 0x04000B0E RID: 2830
		public const string BERMUDA = "Bermuda";

		// Token: 0x04000B0F RID: 2831
		public const string BERMUDALK = "BermudaLK";

		// Token: 0x04000B10 RID: 2832
		public const string BERMUDAP = "BermudaP";

		// Token: 0x04000B11 RID: 2833
		public const string TONGA = "Tonga";

		// Token: 0x04000B12 RID: 2834
		public const string TONGAP = "TongaP";

		// Token: 0x04000B13 RID: 2835
		public const string TONGAPLUS = "TongaPlus";

		// Token: 0x04000B14 RID: 2836
		public const string Tuner_SubModel = "Tuner_SubModel";

		// Token: 0x04000B15 RID: 2837
		public const string Tuner_SubFreqType = "Tuner_SubFreqType";

		// Token: 0x04000B16 RID: 2838
		public const string BANDIT_CYPHER = "Bandit_Cypher";

		// Token: 0x04000B17 RID: 2839
		public const string BANDIT_REPEATER = "BANDIT_REPEATER";

		// Token: 0x04000B18 RID: 2840
		public const string BANDIT = "Bandit";

		// Token: 0x04000B19 RID: 2841
		public const string BANDIT_UNDERSCORE = "BANDIT_";

		// Token: 0x04000B1A RID: 2842
		public const string FPGA_RECOVER_MIN_CPVERSION = "08.00.00";

		// Token: 0x04000B1B RID: 2843
		public const int FLAG_DEVICEUPDATE = 1;

		// Token: 0x04000B1C RID: 2844
		public const int FLAG_DEVICERECOVER = 2;

		// Token: 0x04000B1D RID: 2845
		public const int FLAG_DEVICECONVERT = 4;

		// Token: 0x04000B1E RID: 2846
		public const int FLAG_FPGAUPGRADE = 8;

		// Token: 0x04000B1F RID: 2847
		public const int FLAG_FPGAREVERT = 16;

		// Token: 0x04000B20 RID: 2848
		public const byte FPGA_CONTROLLER = 2;

		// Token: 0x04000B21 RID: 2849
		public const byte FPGA_WIRELINE = 3;

		// Token: 0x04000B22 RID: 2850
		public const string RESKIN = "Reskin";

		// Token: 0x04000B23 RID: 2851
		public const string PORTABLETYPE = "PORTABLETYPE";

		// Token: 0x04000B24 RID: 2852
		public const string PRTBLTYPE = "PortableType";

		// Token: 0x04000B25 RID: 2853
		public const string STDMODEL = "STD";

		// Token: 0x04000B26 RID: 2854
		public const string SUBMODELTAG = "SUBMODEL";

		// Token: 0x04000B27 RID: 2855
		public const string SUBMODEL = "SubModel";

		// Token: 0x04000B28 RID: 2856
		public const string HWTYPE = "HWTYPE";

		// Token: 0x04000B29 RID: 2857
		public const string LEGACY = "LEGACY";

		// Token: 0x04000B2A RID: 2858
		public const string CFS = "CFS";

		// Token: 0x04000B2B RID: 2859
		public const string CFS_NA_NPSPAC = "CFS_NA_NPSPAC";

		// Token: 0x04000B2C RID: 2860
		public const string DMR3_SITE_DLT_TYPE = "DMR3_SITE_DLT_TYPE";

		// Token: 0x04000B2D RID: 2861
		public const string DMR3_SITE_DLH_TYPE = "DMR3_SITE_DLH_TYPE";

		// Token: 0x04000B2E RID: 2862
		public const string DMR3_SITE_DLL_TYPE = "DMR3_SITE_DLL_TYPE";

		// Token: 0x04000B2F RID: 2863
		public const string SLIST_SITE_ALIAS = "SLIST_SITE_ALIAS";

		// Token: 0x04000B30 RID: 2864
		public const string SITELIST_SITELISTALIAS = "SITELIST_SITELISTALIAS";

		// Token: 0x04000B31 RID: 2865
		public const string DMR3_CONTROL_CHANNEL_DLT_TYPE = "DMR3_CONTROL_CHANNEL_DLT_TYPE";

		// Token: 0x04000B32 RID: 2866
		public const string DMR3_CONTROL_CHANNEL_DLH_TYPE = "DMR3_CONTROL_CHANNEL_DLH_TYPE";

		// Token: 0x04000B33 RID: 2867
		public const string DMR3_CONTROL_CHANNEL_DLL_TYPE = "DMR3_CONTROL_CHANNEL_DLL_TYPE";

		// Token: 0x04000B34 RID: 2868
		public const string CCLISTDLH_LIST_ALIAS = "CCLISTDLH_LIST_ALIAS";

		// Token: 0x04000B35 RID: 2869
		public const string CCLDLL_SLOTNUMBER = "CCLDLL_SLOTNUMBER";

		// Token: 0x04000B36 RID: 2870
		public const string CCLDLL_COLORCODE = "CCLDLL_COLORCODE";

		// Token: 0x04000B37 RID: 2871
		public const string CCLDLL_TXFREQUENCY = "CCLDLL_TXFREQUENCY";

		// Token: 0x04000B38 RID: 2872
		public const string CCLDLL_RXFREQUENCY = "CCLDLL_RXFREQUENCY";

		// Token: 0x04000B39 RID: 2873
		public const string DMR3_PERFERRED_SITE_DLT_TYPE = "DMR3_PERFERRED_SITE_DLT_TYPE";

		// Token: 0x04000B3A RID: 2874
		public const string DMR3_PERFERRED_SITE_DLH_TYPE = "DMR3_PERFERRED_SITE_DLH_TYPE";

		// Token: 0x04000B3B RID: 2875
		public const string DMR3_PERFERRED_SITE_DLL_TYPE = "DMR3_PERFERRED_SITE_DLL_TYPE";

		// Token: 0x04000B3C RID: 2876
		public const string PREFERSITELISTDLH_LISTALIAS = "PREFERSITELISTDLH_LISTALIAS";

		// Token: 0x04000B3D RID: 2877
		public const string DMR3_REVERT_CHN_DLT_TYPE = "DMR3_REVERT_CHN_DLT_TYPE";

		// Token: 0x04000B3E RID: 2878
		public const string RCLISTDLH_LIST_ALIAS = "RCLISTDLH_LIST_ALIAS";

		// Token: 0x04000B3F RID: 2879
		public const string DMR3_REVERT_CHN_DLH_TYPE = "DMR3_REVERT_CHN_DLH_TYPE";

		// Token: 0x04000B40 RID: 2880
		public const string DMR3_REVERT_CHN_DLL_TYPE = "DMR3_REVERT_CHN_DLL_TYPE";

		// Token: 0x04000B41 RID: 2881
		public const int CNV_PER_MAX_IN_TLKGROUPSCAN = 10;

		// Token: 0x04000B42 RID: 2882
		public const string ALIAS = "ALIAS";

		// Token: 0x04000B43 RID: 2883
		public const string CNVPERID = "CnvPerID";

		// Token: 0x04000B44 RID: 2884
		public const int ALIAS_MAX_LEN = 16;

		// Token: 0x04000B45 RID: 2885
		public const int TONGA_ALIAS_MAX_LEN = 12;

		// Token: 0x04000B46 RID: 2886
		public const int TONGA_CALL_ALIAS_MAX_LEN = 4;

		// Token: 0x04000B47 RID: 2887
		public const int JOBTICKET_TEMPLATE_ALIAS_MAX_LEN = 32;

		// Token: 0x04000B48 RID: 2888
		public const int NOT_APPLICABLE = -1;

		// Token: 0x04000B49 RID: 2889
		public const int ISHID0 = 0;

		// Token: 0x04000B4A RID: 2890
		public const ushort UNDOREDOLEVEL = 1;

		// Token: 0x04000B4B RID: 2891
		public const string TLMTRYVIO = "TLMTRYVIO";

		// Token: 0x04000B4C RID: 2892
		public const string CPSERVICES = "Codeplug Services";

		// Token: 0x04000B4D RID: 2893
		public const string COMMASPACE = ", ";

		// Token: 0x04000B4E RID: 2894
		public const string TEMPLATEVERSION = "TEMPLATEVERSION";

		// Token: 0x04000B4F RID: 2895
		public const string VERSION1 = "1";

		// Token: 0x04000B50 RID: 2896
		public const string VERSION2 = "2";

		// Token: 0x04000B51 RID: 2897
		public const string VERSION3 = "3";

		// Token: 0x04000B52 RID: 2898
		public const string VERSION4 = "4";

		// Token: 0x04000B53 RID: 2899
		public const string VERSION_1 = "1";

		// Token: 0x04000B54 RID: 2900
		public const string VERSION_2 = "2";

		// Token: 0x04000B55 RID: 2901
		public const string STR_01 = "01";

		// Token: 0x04000B56 RID: 2902
		public const string MULTISITE = "MULTISITE";

		// Token: 0x04000B57 RID: 2903
		public const string MULTISITE_SYSTEM = "MULTISITE_SYSTEM";

		// Token: 0x04000B58 RID: 2904
		public const string MULTISITE_CONTROLLER = "MULTISITE_CONTROLLER";

		// Token: 0x04000B59 RID: 2905
		public const string MULTISITE_PEER = "MULTISITE_PEER";

		// Token: 0x04000B5A RID: 2906
		public const string MULTISITE_SYS_CMP_TYPE = "MULTISITE_SYS_CMP_TYPE";

		// Token: 0x04000B5B RID: 2907
		public const string MULTISITE_CNTRLLR_CMP_TYPE = "MULTISITE_CNTRLLR_CMP_TYPE";

		// Token: 0x04000B5C RID: 2908
		public const string MULTISITE_PEER_CMP_TYPE = "MULTISITE_PEER_CMP_TYPE";

		// Token: 0x04000B5D RID: 2909
		public const string MULTISITE_PEER_CMP_TYPE_GRP = "MULTISITE_PEER_CMP_TYPE_GRP";

		// Token: 0x04000B5E RID: 2910
		public const string CONTROLLER_ALIAS = "Master";

		// Token: 0x04000B5F RID: 2911
		public const string NEW = "New";

		// Token: 0x04000B60 RID: 2912
		public const string LIMITED = "Limited";

		// Token: 0x04000B61 RID: 2913
		public const string CHANNEL_POOL = "Channel Pool";

		// Token: 0x04000B62 RID: 2914
		public const int POOL_LEQMAX = 160;

		// Token: 0x04000B63 RID: 2915
		public const int POOL_PLAIN_LEQMAX = 64;

		// Token: 0x04000B64 RID: 2916
		public const string T3000A = "T3000A";

		// Token: 0x04000B65 RID: 2917
		public const string CONTROLLER = "Controller";

		// Token: 0x04000B66 RID: 2918
		public const string WIRELINE = "Wireline";

		// Token: 0x04000B67 RID: 2919
		public const ushort ITEMNUM_REMOVEALL = 65535;

		// Token: 0x04000B68 RID: 2920
		public const string MTST_CNTRLLERARCHIVE = "MTST_CNTRLLERARCHIVE";

		// Token: 0x04000B69 RID: 2921
		public const string BTN_ARCHBROWSE = "BTN_ARCHBROWSE";

		// Token: 0x04000B6A RID: 2922
		public const string MTST_REPEATERTYPE = "MTST_REPEATERTYPE";

		// Token: 0x04000B6B RID: 2923
		public const string RESULT_NOUPDATES = "RESULT_NOUPDATES";

		// Token: 0x04000B6C RID: 2924
		public const string RESULT_FILENOTEXIST = "RESULT_FILENOTEXIST";

		// Token: 0x04000B6D RID: 2925
		public const string RESULT_FILENOTVALID = "RESULT_FILENOTVALID";

		// Token: 0x04000B6E RID: 2926
		public const string RESULT_VALUECHANGED = "RESULT_VALUECHANGED";

		// Token: 0x04000B6F RID: 2927
		public const string RESULT_OPENFILE_ERROR = "RESULT_OPENFILE_ERROR";

		// Token: 0x04000B70 RID: 2928
		public const string RESULT_CFS_FIELD_INVALID = "RESULT_CFS_FIELD_INVALID";

		// Token: 0x04000B71 RID: 2929
		public const string LBL_PREVPROGSFT_TUNING_RX_FEF_SOFTPOT = "LBL_PREVPROGSFT_TUNING_RX_FEF_SOFTPOT";

		// Token: 0x04000B72 RID: 2930
		public const string LBL_TUNING_RX_FEF_SOFTPOT = "LBL_TUNING_RX_FEF_SOFTPOT";

		// Token: 0x04000B73 RID: 2931
		public const string LBL_HIPWR_TUNING_TX_MOBILEPWR = "LBL_HIPWR_TUNING_TX_MOBILEPWR";

		// Token: 0x04000B74 RID: 2932
		public const string LBL_LOWPWR_TUNING_TX_MOBILEPWR = "LBL_LOWPWR_TUNING_TX_MOBILEPWR";

		// Token: 0x04000B75 RID: 2933
		public const string LBL_P1LP_TUNING_TX_MOBILEPWR = "LBL_P1LP_TUNING_TX_MOBILEPWR";

		// Token: 0x04000B76 RID: 2934
		public const string LBL_P1PWR_TUNING_TX_MOBILEPWR = "LBL_P1PWR_TUNING_TX_MOBILEPWR";

		// Token: 0x04000B77 RID: 2935
		public const string LBL_P2LP_TUNING_TX_MOBILEPWR = "LBL_P2LP_TUNING_TX_MOBILEPWR";

		// Token: 0x04000B78 RID: 2936
		public const string LBL_P2PWR_TUNING_TX_MOBILEPWR = "LBL_P2PWR_TUNING_TX_MOBILEPWR";

		// Token: 0x04000B79 RID: 2937
		public const string LBL_TUNING_TX_MOBILEPWR_TUNINGFREQ = "LBL_TUNING_TX_MOBILEPWR_TUNINGFREQ";

		// Token: 0x04000B7A RID: 2938
		public const string LBL_TUNING_TX_MODBAL_SOFTPOT = "LBL_TUNING_TX_MODBAL_SOFTPOT";

		// Token: 0x04000B7B RID: 2939
		public const string LBL_TUNING_TX_MODBAL_TUNINGFREQ = "LBL_TUNING_TX_MODBAL_TUNINGFREQ";

		// Token: 0x04000B7C RID: 2940
		public const string LBL_TUNING_TX_PABIAS1_SOFTPOT = "LBL_TUNING_TX_PABIAS1_SOFTPOT";

		// Token: 0x04000B7D RID: 2941
		public const string FLD_TUNING_TX_PABIAS1_AMBIENT_TEMP = "FLD_TUNING_TX_PABIAS1_AMBIENT_TEMP";

		// Token: 0x04000B7E RID: 2942
		public const string LBL_P4PWR_TUNING_TX_MOBILEPWR = "LBL_P4PWR_TUNING_TX_MOBILEPWR";

		// Token: 0x04000B7F RID: 2943
		public const string LBL_TUNING_TX_PABIAS1_TUNINGFREQ = "LBL_TUNING_TX_PABIAS1_TUNINGFREQ";

		// Token: 0x04000B80 RID: 2944
		public const string LBL_TUNING_TX_PABIAS2_SOFTPOT = "LBL_TUNING_TX_PABIAS2_SOFTPOT";

		// Token: 0x04000B81 RID: 2945
		public const string LBL_TUNING_TX_PABIAS2_TUNINGFREQ = "LBL_TUNING_TX_PABIAS2_TUNINGFREQ";

		// Token: 0x04000B82 RID: 2946
		public const string LBL_TUNING_TX_PWRHI_SOFTPOT = "LBL_TUNING_TX_PWRHI_SOFTPOT";

		// Token: 0x04000B83 RID: 2947
		public const string LBL_TUNING_TX_PWRHI_TUNINGFREQ = "LBL_TUNING_TX_PWRHI_TUNINGFREQ";

		// Token: 0x04000B84 RID: 2948
		public const string LBL_TUNING_TX_PWRLOW_SOFTPOT = "LBL_TUNING_TX_PWRLOW_SOFTPOT";

		// Token: 0x04000B85 RID: 2949
		public const string LBL_TUNING_TX_PWRLOW_TUNINGFREQ = "LBL_TUNING_TX_PWRLOW_TUNINGFREQ";

		// Token: 0x04000B86 RID: 2950
		public const string LBL_TUNING_TX_REFOSC_SOFTPOT = "LBL_TUNING_TX_REFOSC_SOFTPOT";

		// Token: 0x04000B87 RID: 2951
		public const string LBL_TUNING_TX_REFOSC_TUNINGFREQ = "LBL_TUNING_TX_REFOSC_TUNINGFREQ";

		// Token: 0x04000B88 RID: 2952
		public const string LBL_TUNING_TX_VCBPWRHI_SOFTPOT = "LBL_TUNING_TX_VCBPWRHI_SOFTPOT";

		// Token: 0x04000B89 RID: 2953
		public const string LBL_P3PWR_TUNING_TX_MOBILEPWR = "LBL_P3PWR_TUNING_TX_MOBILEPWR";

		// Token: 0x04000B8A RID: 2954
		public const string LBL_PREVPROGSFT_TUNING_TX_MODBAL_SOFTPOT = "LBL_PREVPROGSFT_TUNING_TX_MODBAL_SOFTPOT";

		// Token: 0x04000B8B RID: 2955
		public const string LBL_TUNING_RX_FEF_TUNINGFREQ = "LBL_TUNING_RX_FEF_TUNINGFREQ";

		// Token: 0x04000B8C RID: 2956
		public const string LBL_PREVPROGSFT_TUNING_TX_REFOSC_SOFTPOT = "LBL_PREVPROGSFT_TUNING_TX_REFOSC_SOFTPOT";

		// Token: 0x04000B8D RID: 2957
		public const string LBL_TUNING_TX_VCBPWRHI_VOLTAGEPOINT = "LBL_TUNING_TX_VCBPWRHI_VOLTAGEPOINT";

		// Token: 0x04000B8E RID: 2958
		public const string LBL_TUNING_TX_VCBPWRHI_TUNINGVOLTAGE = "LBL_TUNING_TX_VCBPWRHI_TUNINGVOLTAGE";

		// Token: 0x04000B8F RID: 2959
		public const string LBL_TUNING_RX_RATVOL_TUNINGFREQ = "LBL_TUNING_RX_RATVOL_TUNINGFREQ";

		// Token: 0x04000B90 RID: 2960
		public const string LBL_TUNING_RX_RATVOL_SOFTPOT = "LBL_TUNING_RX_RATVOL_SOFTPOT";

		// Token: 0x04000B91 RID: 2961
		public const string LBL_PREVPROGSFT_TUNING_TX_PABIAS1_SOFTPOT = "LBL_PREVPROGSFT_TUNING_TX_PABIAS1_SOFTPOT";

		// Token: 0x04000B92 RID: 2962
		public const string LBL_PREVPROGSFT_TUNING_RX_RATVOL_SOFTPOT = "LBL_PREVPROGSFT_TUNING_RX_RATVOL_SOFTPOT";

		// Token: 0x04000B93 RID: 2963
		public const string LBL_PREVPROGSFT_TUNING_TX_PWRLOW_SOFTPOT = "LBL_PREVPROGSFT_TUNING_TX_PWRLOW_SOFTPOT";

		// Token: 0x04000B94 RID: 2964
		public const string LBL_TUNING_RX_REFOSC_TUNINGFREQ = "LBL_TUNING_RX_REFOSC_TUNINGFREQ";

		// Token: 0x04000B95 RID: 2965
		public const string LBL_PREVPROGSFT_TUNING_TX_PWRHI_SOFTPOT = "LBL_PREVPROGSFT_TUNING_TX_PWRHI_SOFTPOT";

		// Token: 0x04000B96 RID: 2966
		public const string LBL_TUNING_RX_REFOSC_SOFTPOT = "LBL_TUNING_RX_REFOSC_SOFTPOT";

		// Token: 0x04000B97 RID: 2967
		public const string LBL_PREVPROGSFT_TUNING_RX_REFOSC_SOFTPOT = "LBL_PREVPROGSFT_TUNING_RX_REFOSC_SOFTPOT";

		// Token: 0x04000B98 RID: 2968
		public const string FLD_TUNING_RX_RATVOL_MINIMUM_SOFTPOT00 = "FLD_TUNING_RX_RATVOL_MINIMUM_SOFTPOT00";

		// Token: 0x04000B99 RID: 2969
		public const string STR_TTR_ENABLE = "STR_TTR_ENABLE";

		// Token: 0x04000B9A RID: 2970
		public const string STR_TTR_DISABLE = "STR_TTR_DISABLE";

		// Token: 0x04000B9B RID: 2971
		public const string STR_BER_DETECTED = "Detected";

		// Token: 0x04000B9C RID: 2972
		public const string STR_BER_UNDETECTED = "Undetected";

		// Token: 0x04000B9D RID: 2973
		public const string STR_BER_UNDETECTED_COUNT = "???";

		// Token: 0x04000B9E RID: 2974
		public const string STR_BER_UNDETECTED_BER_PERCENT = "?.??%";

		// Token: 0x04000B9F RID: 2975
		public const int ID31 = 31;

		// Token: 0x04000BA0 RID: 2976
		public const int ID227 = 227;

		// Token: 0x04000BA1 RID: 2977
		public const int ID252 = 252;

		// Token: 0x04000BA2 RID: 2978
		public const int ID805 = 805;

		// Token: 0x04000BA3 RID: 2979
		public const int ID826 = 826;

		// Token: 0x04000BA4 RID: 2980
		public const int ID966 = 966;

		// Token: 0x04000BA5 RID: 2981
		public const int ID985 = 985;

		// Token: 0x04000BA6 RID: 2982
		public const int ID1354 = 1354;

		// Token: 0x04000BA7 RID: 2983
		public const int ID1365 = 1365;

		// Token: 0x04000BA8 RID: 2984
		public const int ID1449 = 1449;

		// Token: 0x04000BA9 RID: 2985
		public const int ID1462 = 1462;

		// Token: 0x04000BAA RID: 2986
		public const int ID1647 = 1647;

		// Token: 0x04000BAB RID: 2987
		public const int ID1648 = 1648;

		// Token: 0x04000BAC RID: 2988
		public const int ID1676 = 1676;

		// Token: 0x04000BAD RID: 2989
		public const int ID1683 = 1683;

		// Token: 0x04000BAE RID: 2990
		public const int ID6182 = 6182;

		// Token: 0x04000BAF RID: 2991
		public const int ID6201 = 6201;

		// Token: 0x04000BB0 RID: 2992
		public const int ID6341 = 6341;

		// Token: 0x04000BB1 RID: 2993
		public const int ID6362 = 6362;

		// Token: 0x04000BB2 RID: 2994
		public const int ID6915 = 6915;

		// Token: 0x04000BB3 RID: 2995
		public const int ID6940 = 6940;

		// Token: 0x04000BB4 RID: 2996
		public const int ID7136 = 7136;

		// Token: 0x04000BB5 RID: 2997
		public const int ID7167 = 7167;

		// Token: 0x04000BB6 RID: 2998
		public const int ID7532 = 7532;

		// Token: 0x04000BB7 RID: 2999
		public const int ID7539 = 7539;

		// Token: 0x04000BB8 RID: 3000
		public const int ID7567 = 7567;

		// Token: 0x04000BB9 RID: 3001
		public const int ID7568 = 7568;

		// Token: 0x04000BBA RID: 3002
		public const int ID7753 = 7753;

		// Token: 0x04000BBB RID: 3003
		public const int ID7766 = 7766;

		// Token: 0x04000BBC RID: 3004
		public const int ID7850 = 7850;

		// Token: 0x04000BBD RID: 3005
		public const int ID7861 = 7861;

		// Token: 0x04000BBE RID: 3006
		public const int ID10315 = 10315;

		// Token: 0x04000BBF RID: 3007
		public const int ID10324 = 10324;

		// Token: 0x04000BC0 RID: 3008
		public const int ID10408 = 10408;

		// Token: 0x04000BC1 RID: 3009
		public const int ID10423 = 10423;

		// Token: 0x04000BC2 RID: 3010
		public const int ID11118 = 11118;

		// Token: 0x04000BC3 RID: 3011
		public const int ID11121 = 11121;

		// Token: 0x04000BC4 RID: 3012
		public const int ID11149 = 11149;

		// Token: 0x04000BC5 RID: 3013
		public const int ID11154 = 11154;

		// Token: 0x04000BC6 RID: 3014
		public const int ID11521 = 11521;

		// Token: 0x04000BC7 RID: 3015
		public const int ID11550 = 11550;

		// Token: 0x04000BC8 RID: 3016
		public const int ID11746 = 11746;

		// Token: 0x04000BC9 RID: 3017
		public const int ID11773 = 11773;

		// Token: 0x04000BCA RID: 3018
		public const int ID11812 = 11812;

		// Token: 0x04000BCB RID: 3019
		public const int ID11835 = 11835;

		// Token: 0x04000BCC RID: 3020
		public const int ID11975 = 11975;

		// Token: 0x04000BCD RID: 3021
		public const int ID11992 = 11992;

		// Token: 0x04000BCE RID: 3022
		public const int ID12397 = 12397;

		// Token: 0x04000BCF RID: 3023
		public const int ID12402 = 12402;

		// Token: 0x04000BD0 RID: 3024
		public const int ID12430 = 12430;

		// Token: 0x04000BD1 RID: 3025
		public const int ID12433 = 12433;

		// Token: 0x04000BD2 RID: 3026
		public const int ID13128 = 13128;

		// Token: 0x04000BD3 RID: 3027
		public const int ID13143 = 13143;

		// Token: 0x04000BD4 RID: 3028
		public const int ID13227 = 13227;

		// Token: 0x04000BD5 RID: 3029
		public const int ID13236 = 13236;

		// Token: 0x04000BD6 RID: 3030
		public const int ID13607 = 13607;

		// Token: 0x04000BD7 RID: 3031
		public const int ID13624 = 13624;

		// Token: 0x04000BD8 RID: 3032
		public const int ID13764 = 13764;

		// Token: 0x04000BD9 RID: 3033
		public const int ID13787 = 13787;

		// Token: 0x04000BDA RID: 3034
		public const int ID13826 = 13826;

		// Token: 0x04000BDB RID: 3035
		public const int ID13853 = 13853;

		// Token: 0x04000BDC RID: 3036
		public const int ID14049 = 14049;

		// Token: 0x04000BDD RID: 3037
		public const int ID14078 = 14078;

		// Token: 0x04000BDE RID: 3038
		public const int ID18731 = 18731;

		// Token: 0x04000BDF RID: 3039
		public const int ID18740 = 18740;

		// Token: 0x04000BE0 RID: 3040
		public const int ID18888 = 18888;

		// Token: 0x04000BE1 RID: 3041
		public const int ID18903 = 18903;

		// Token: 0x04000BE2 RID: 3042
		public const int ID18958 = 18958;

		// Token: 0x04000BE3 RID: 3043
		public const int ID18961 = 18961;

		// Token: 0x04000BE4 RID: 3044
		public const int ID19181 = 19181;

		// Token: 0x04000BE5 RID: 3045
		public const int ID19186 = 19186;

		// Token: 0x04000BE6 RID: 3046
		public const int ID19553 = 19553;

		// Token: 0x04000BE7 RID: 3047
		public const int ID19582 = 19582;

		// Token: 0x04000BE8 RID: 3048
		public const int ID19586 = 19586;

		// Token: 0x04000BE9 RID: 3049
		public const int ID19613 = 19613;

		// Token: 0x04000BEA RID: 3050
		public const int ID20292 = 20292;

		// Token: 0x04000BEB RID: 3051
		public const int ID20315 = 20315;

		// Token: 0x04000BEC RID: 3052
		public const int ID20391 = 20391;

		// Token: 0x04000BED RID: 3053
		public const int ID20408 = 20408;

		// Token: 0x04000BEE RID: 3054
		public const int ID20749 = 20749;

		// Token: 0x04000BEF RID: 3055
		public const int ID20754 = 20754;

		// Token: 0x04000BF0 RID: 3056
		public const int ID20974 = 20974;

		// Token: 0x04000BF1 RID: 3057
		public const int ID20977 = 20977;

		// Token: 0x04000BF2 RID: 3058
		public const int ID21032 = 21032;

		// Token: 0x04000BF3 RID: 3059
		public const int ID21047 = 21047;

		// Token: 0x04000BF4 RID: 3060
		public const int ID21195 = 21195;

		// Token: 0x04000BF5 RID: 3061
		public const int ID21204 = 21204;

		// Token: 0x04000BF6 RID: 3062
		public const int ID21575 = 21575;

		// Token: 0x04000BF7 RID: 3063
		public const int ID21592 = 21592;

		// Token: 0x04000BF8 RID: 3064
		public const int ID21668 = 21668;

		// Token: 0x04000BF9 RID: 3065
		public const int ID21691 = 21691;

		// Token: 0x04000BFA RID: 3066
		public const int ID22370 = 22370;

		// Token: 0x04000BFB RID: 3067
		public const int ID22397 = 22397;

		// Token: 0x04000BFC RID: 3068
		public const int ID22401 = 22401;

		// Token: 0x04000BFD RID: 3069
		public const int ID22430 = 22430;

		// Token: 0x04000BFE RID: 3070
		public const int ID24928 = 24928;

		// Token: 0x04000BFF RID: 3071
		public const int ID24959 = 24959;

		// Token: 0x04000C00 RID: 3072
		public const int ID24963 = 24963;

		// Token: 0x04000C01 RID: 3073
		public const int ID24988 = 24988;

		// Token: 0x04000C02 RID: 3074
		public const int ID25157 = 25157;

		// Token: 0x04000C03 RID: 3075
		public const int ID25178 = 25178;

		// Token: 0x04000C04 RID: 3076
		public const int ID25254 = 25254;

		// Token: 0x04000C05 RID: 3077
		public const int ID25273 = 25273;

		// Token: 0x04000C06 RID: 3078
		public const int ID25642 = 25642;

		// Token: 0x04000C07 RID: 3079
		public const int ID25653 = 25653;

		// Token: 0x04000C08 RID: 3080
		public const int ID25801 = 25801;

		// Token: 0x04000C09 RID: 3081
		public const int ID25814 = 25814;

		// Token: 0x04000C0A RID: 3082
		public const int ID26383 = 26383;

		// Token: 0x04000C0B RID: 3083
		public const int ID26384 = 26384;

		// Token: 0x04000C0C RID: 3084
		public const int ID26604 = 26604;

		// Token: 0x04000C0D RID: 3085
		public const int ID26611 = 26611;

		// Token: 0x04000C0E RID: 3086
		public const int ID31046 = 31046;

		// Token: 0x04000C0F RID: 3087
		public const int ID31065 = 31065;

		// Token: 0x04000C10 RID: 3088
		public const int ID31141 = 31141;

		// Token: 0x04000C11 RID: 3089
		public const int ID31162 = 31162;

		// Token: 0x04000C12 RID: 3090
		public const int ID31331 = 31331;

		// Token: 0x04000C13 RID: 3091
		public const int ID31356 = 31356;

		// Token: 0x04000C14 RID: 3092
		public const int ID31360 = 31360;

		// Token: 0x04000C15 RID: 3093
		public const int ID31391 = 31391;

		// Token: 0x04000C16 RID: 3094
		public const int ID31756 = 31756;

		// Token: 0x04000C17 RID: 3095
		public const int ID31763 = 31763;

		// Token: 0x04000C18 RID: 3096
		public const int ID31983 = 31983;

		// Token: 0x04000C19 RID: 3097
		public const int ID31984 = 31984;

		// Token: 0x04000C1A RID: 3098
		public const int ID32553 = 32553;

		// Token: 0x04000C1B RID: 3099
		public const int ID32566 = 32566;

		// Token: 0x04000C1C RID: 3100
		public const int ID32714 = 32714;

		// Token: 0x04000C1D RID: 3101
		public const int ID32725 = 32725;

		// Token: 0x04000C1E RID: 3102
		public const int ID35149 = 35149;

		// Token: 0x04000C1F RID: 3103
		public const int ID35154 = 35154;

		// Token: 0x04000C20 RID: 3104
		public const int ID35246 = 35246;

		// Token: 0x04000C21 RID: 3105
		public const int ID35249 = 35249;

		// Token: 0x04000C22 RID: 3106
		public const int ID35432 = 35432;

		// Token: 0x04000C23 RID: 3107
		public const int ID35447 = 35447;

		// Token: 0x04000C24 RID: 3108
		public const int ID35467 = 35467;

		// Token: 0x04000C25 RID: 3109
		public const int ID35476 = 35476;

		// Token: 0x04000C26 RID: 3110
		public const int ID35847 = 35847;

		// Token: 0x04000C27 RID: 3111
		public const int ID35864 = 35864;

		// Token: 0x04000C28 RID: 3112
		public const int ID36068 = 36068;

		// Token: 0x04000C29 RID: 3113
		public const int ID36091 = 36091;

		// Token: 0x04000C2A RID: 3114
		public const int ID36642 = 36642;

		// Token: 0x04000C2B RID: 3115
		public const int ID36669 = 36669;

		// Token: 0x04000C2C RID: 3116
		public const int ID36801 = 36801;

		// Token: 0x04000C2D RID: 3117
		public const int ID36830 = 36830;

		// Token: 0x04000C2E RID: 3118
		public const int ID37227 = 37227;

		// Token: 0x04000C2F RID: 3119
		public const int ID37236 = 37236;

		// Token: 0x04000C30 RID: 3120
		public const int ID37256 = 37256;

		// Token: 0x04000C31 RID: 3121
		public const int ID37271 = 37271;

		// Token: 0x04000C32 RID: 3122
		public const int ID37454 = 37454;

		// Token: 0x04000C33 RID: 3123
		public const int ID37457 = 37457;

		// Token: 0x04000C34 RID: 3124
		public const int ID37549 = 37549;

		// Token: 0x04000C35 RID: 3125
		public const int ID37554 = 37554;

		// Token: 0x04000C36 RID: 3126
		public const int ID37921 = 37921;

		// Token: 0x04000C37 RID: 3127
		public const int ID37950 = 37950;

		// Token: 0x04000C38 RID: 3128
		public const int ID38082 = 38082;

		// Token: 0x04000C39 RID: 3129
		public const int ID38109 = 38109;

		// Token: 0x04000C3A RID: 3130
		public const int ID38660 = 38660;

		// Token: 0x04000C3B RID: 3131
		public const int ID38683 = 38683;

		// Token: 0x04000C3C RID: 3132
		public const int ID38887 = 38887;

		// Token: 0x04000C3D RID: 3133
		public const int ID38904 = 38904;

		// Token: 0x04000C3E RID: 3134
		public const int ID41222 = 41222;

		// Token: 0x04000C3F RID: 3135
		public const int ID41241 = 41241;

		// Token: 0x04000C40 RID: 3136
		public const int ID41445 = 41445;

		// Token: 0x04000C41 RID: 3137
		public const int ID41466 = 41466;

		// Token: 0x04000C42 RID: 3138
		public const int ID41507 = 41507;

		// Token: 0x04000C43 RID: 3139
		public const int ID41532 = 41532;

		// Token: 0x04000C44 RID: 3140
		public const int ID41664 = 41664;

		// Token: 0x04000C45 RID: 3141
		public const int ID41695 = 41695;

		// Token: 0x04000C46 RID: 3142
		public const int ID42060 = 42060;

		// Token: 0x04000C47 RID: 3143
		public const int ID42067 = 42067;

		// Token: 0x04000C48 RID: 3144
		public const int ID42159 = 42159;

		// Token: 0x04000C49 RID: 3145
		public const int ID42160 = 42160;

		// Token: 0x04000C4A RID: 3146
		public const int ID42857 = 42857;

		// Token: 0x04000C4B RID: 3147
		public const int ID42870 = 42870;

		// Token: 0x04000C4C RID: 3148
		public const int ID42890 = 42890;

		// Token: 0x04000C4D RID: 3149
		public const int ID42901 = 42901;

		// Token: 0x04000C4E RID: 3150
		public const int ID47392 = 47392;

		// Token: 0x04000C4F RID: 3151
		public const int ID47423 = 47423;

		// Token: 0x04000C50 RID: 3152
		public const int ID47555 = 47555;

		// Token: 0x04000C51 RID: 3153
		public const int ID47580 = 47580;

		// Token: 0x04000C52 RID: 3154
		public const int ID47621 = 47621;

		// Token: 0x04000C53 RID: 3155
		public const int ID47642 = 47642;

		// Token: 0x04000C54 RID: 3156
		public const int ID47846 = 47846;

		// Token: 0x04000C55 RID: 3157
		public const int ID47865 = 47865;

		// Token: 0x04000C56 RID: 3158
		public const int ID48234 = 48234;

		// Token: 0x04000C57 RID: 3159
		public const int ID48245 = 48245;

		// Token: 0x04000C58 RID: 3160
		public const int ID48265 = 48265;

		// Token: 0x04000C59 RID: 3161
		public const int ID48278 = 48278;

		// Token: 0x04000C5A RID: 3162
		public const int ID48975 = 48975;

		// Token: 0x04000C5B RID: 3163
		public const int ID48976 = 48976;

		// Token: 0x04000C5C RID: 3164
		public const int ID49068 = 49068;

		// Token: 0x04000C5D RID: 3165
		public const int ID49075 = 49075;

		// Token: 0x04000C5E RID: 3166
		public const int ID49254 = 49254;

		// Token: 0x04000C5F RID: 3167
		public const int ID49273 = 49273;

		// Token: 0x04000C60 RID: 3168
		public const int ID49285 = 49285;

		// Token: 0x04000C61 RID: 3169
		public const int ID49306 = 49306;

		// Token: 0x04000C62 RID: 3170
		public const int ID49987 = 49987;

		// Token: 0x04000C63 RID: 3171
		public const int ID50012 = 50012;

		// Token: 0x04000C64 RID: 3172
		public const int ID50080 = 50080;

		// Token: 0x04000C65 RID: 3173
		public const int ID50111 = 50111;

		// Token: 0x04000C66 RID: 3174
		public const int ID50476 = 50476;

		// Token: 0x04000C67 RID: 3175
		public const int ID50483 = 50483;

		// Token: 0x04000C68 RID: 3176
		public const int ID50639 = 50639;

		// Token: 0x04000C69 RID: 3177
		public const int ID50640 = 50640;

		// Token: 0x04000C6A RID: 3178
		public const int ID50697 = 50697;

		// Token: 0x04000C6B RID: 3179
		public const int ID50710 = 50710;

		// Token: 0x04000C6C RID: 3180
		public const int ID50922 = 50922;

		// Token: 0x04000C6D RID: 3181
		public const int ID50933 = 50933;

		// Token: 0x04000C6E RID: 3182
		public const int ID55360 = 55360;

		// Token: 0x04000C6F RID: 3183
		public const int ID55391 = 55391;

		// Token: 0x04000C70 RID: 3184
		public const int ID55459 = 55459;

		// Token: 0x04000C71 RID: 3185
		public const int ID55484 = 55484;

		// Token: 0x04000C72 RID: 3186
		public const int ID56165 = 56165;

		// Token: 0x04000C73 RID: 3187
		public const int ID56186 = 56186;

		// Token: 0x04000C74 RID: 3188
		public const int ID56198 = 56198;

		// Token: 0x04000C75 RID: 3189
		public const int ID56217 = 56217;

		// Token: 0x04000C76 RID: 3190
		public const int ID56586 = 56586;

		// Token: 0x04000C77 RID: 3191
		public const int ID56597 = 56597;

		// Token: 0x04000C78 RID: 3192
		public const int ID56809 = 56809;

		// Token: 0x04000C79 RID: 3193
		public const int ID56822 = 56822;

		// Token: 0x04000C7A RID: 3194
		public const int ID56879 = 56879;

		// Token: 0x04000C7B RID: 3195
		public const int ID56880 = 56880;

		// Token: 0x04000C7C RID: 3196
		public const int ID57036 = 57036;

		// Token: 0x04000C7D RID: 3197
		public const int ID57043 = 57043;

		// Token: 0x04000C7E RID: 3198
		public const int ID59437 = 59437;

		// Token: 0x04000C7F RID: 3199
		public const int ID59442 = 59442;

		// Token: 0x04000C80 RID: 3200
		public const int ID59598 = 59598;

		// Token: 0x04000C81 RID: 3201
		public const int ID59601 = 59601;

		// Token: 0x04000C82 RID: 3202
		public const int ID60168 = 60168;

		// Token: 0x04000C83 RID: 3203
		public const int ID60183 = 60183;

		// Token: 0x04000C84 RID: 3204
		public const int ID60395 = 60395;

		// Token: 0x04000C85 RID: 3205
		public const int ID60404 = 60404;

		// Token: 0x04000C86 RID: 3206
		public const int ID60775 = 60775;

		// Token: 0x04000C87 RID: 3207
		public const int ID60792 = 60792;

		// Token: 0x04000C88 RID: 3208
		public const int ID60804 = 60804;

		// Token: 0x04000C89 RID: 3209
		public const int ID60827 = 60827;

		// Token: 0x04000C8A RID: 3210
		public const int ID60994 = 60994;

		// Token: 0x04000C8B RID: 3211
		public const int ID61021 = 61021;

		// Token: 0x04000C8C RID: 3212
		public const int ID61089 = 61089;

		// Token: 0x04000C8D RID: 3213
		public const int ID61118 = 61118;

		// Token: 0x04000C8E RID: 3214
		public const int ID61451 = 61451;

		// Token: 0x04000C8F RID: 3215
		public const int ID61460 = 61460;

		// Token: 0x04000C90 RID: 3216
		public const int ID61672 = 61672;

		// Token: 0x04000C91 RID: 3217
		public const int ID61687 = 61687;

		// Token: 0x04000C92 RID: 3218
		public const int ID62254 = 62254;

		// Token: 0x04000C93 RID: 3219
		public const int ID62257 = 62257;

		// Token: 0x04000C94 RID: 3220
		public const int ID62413 = 62413;

		// Token: 0x04000C95 RID: 3221
		public const int ID62418 = 62418;

		// Token: 0x04000C96 RID: 3222
		public const int ID62785 = 62785;

		// Token: 0x04000C97 RID: 3223
		public const int ID62814 = 62814;

		// Token: 0x04000C98 RID: 3224
		public const int ID62882 = 62882;

		// Token: 0x04000C99 RID: 3225
		public const int ID62909 = 62909;

		// Token: 0x04000C9A RID: 3226
		public const int ID63076 = 63076;

		// Token: 0x04000C9B RID: 3227
		public const int ID63099 = 63099;

		// Token: 0x04000C9C RID: 3228
		public const int ID63111 = 63111;

		// Token: 0x04000C9D RID: 3229
		public const int ID63128 = 63128;

		// Token: 0x04000C9E RID: 3230
		public const int ID65535 = 65535;

		// Token: 0x04000C9F RID: 3231
		public const string STR31 = "31";

		// Token: 0x04000CA0 RID: 3232
		public const string STR227 = "227";

		// Token: 0x04000CA1 RID: 3233
		public const string STR252 = "252";

		// Token: 0x04000CA2 RID: 3234
		public const string STR805 = "805";

		// Token: 0x04000CA3 RID: 3235
		public const string STR826 = "826";

		// Token: 0x04000CA4 RID: 3236
		public const string STR966 = "966";

		// Token: 0x04000CA5 RID: 3237
		public const string STR985 = "985";

		// Token: 0x04000CA6 RID: 3238
		public const string STR1354 = "1354";

		// Token: 0x04000CA7 RID: 3239
		public const string STR1365 = "1365";

		// Token: 0x04000CA8 RID: 3240
		public const string STR1449 = "1449";

		// Token: 0x04000CA9 RID: 3241
		public const string STR1462 = "1462";

		// Token: 0x04000CAA RID: 3242
		public const string STR1647 = "1647";

		// Token: 0x04000CAB RID: 3243
		public const string STR1648 = "1648";

		// Token: 0x04000CAC RID: 3244
		public const string STR1676 = "1676";

		// Token: 0x04000CAD RID: 3245
		public const string STR1683 = "1683";

		// Token: 0x04000CAE RID: 3246
		public const string STR6182 = "6182";

		// Token: 0x04000CAF RID: 3247
		public const string STR6201 = "6201";

		// Token: 0x04000CB0 RID: 3248
		public const string STR6341 = "6341";

		// Token: 0x04000CB1 RID: 3249
		public const string STR6362 = "6362";

		// Token: 0x04000CB2 RID: 3250
		public const string STR6915 = "6915";

		// Token: 0x04000CB3 RID: 3251
		public const string STR6940 = "6940";

		// Token: 0x04000CB4 RID: 3252
		public const string STR7136 = "7136";

		// Token: 0x04000CB5 RID: 3253
		public const string STR7167 = "7167";

		// Token: 0x04000CB6 RID: 3254
		public const string STR7532 = "7532";

		// Token: 0x04000CB7 RID: 3255
		public const string STR7539 = "7539";

		// Token: 0x04000CB8 RID: 3256
		public const string STR7567 = "7567";

		// Token: 0x04000CB9 RID: 3257
		public const string STR7568 = "7568";

		// Token: 0x04000CBA RID: 3258
		public const string STR7753 = "7753";

		// Token: 0x04000CBB RID: 3259
		public const string STR7766 = "7766";

		// Token: 0x04000CBC RID: 3260
		public const string STR7850 = "7850";

		// Token: 0x04000CBD RID: 3261
		public const string STR7861 = "7861";

		// Token: 0x04000CBE RID: 3262
		public const string STR10315 = "10315";

		// Token: 0x04000CBF RID: 3263
		public const string STR10324 = "10324";

		// Token: 0x04000CC0 RID: 3264
		public const string STR10408 = "10408";

		// Token: 0x04000CC1 RID: 3265
		public const string STR10423 = "10423";

		// Token: 0x04000CC2 RID: 3266
		public const string STR11118 = "11118";

		// Token: 0x04000CC3 RID: 3267
		public const string STR11121 = "11121";

		// Token: 0x04000CC4 RID: 3268
		public const string STR11149 = "11149";

		// Token: 0x04000CC5 RID: 3269
		public const string STR11154 = "11154";

		// Token: 0x04000CC6 RID: 3270
		public const string STR11521 = "11521";

		// Token: 0x04000CC7 RID: 3271
		public const string STR11550 = "11550";

		// Token: 0x04000CC8 RID: 3272
		public const string STR11746 = "11746";

		// Token: 0x04000CC9 RID: 3273
		public const string STR11773 = "11773";

		// Token: 0x04000CCA RID: 3274
		public const string STR11812 = "11812";

		// Token: 0x04000CCB RID: 3275
		public const string STR11835 = "11835";

		// Token: 0x04000CCC RID: 3276
		public const string STR11975 = "11975";

		// Token: 0x04000CCD RID: 3277
		public const string STR11992 = "11992";

		// Token: 0x04000CCE RID: 3278
		public const string STR12397 = "12397";

		// Token: 0x04000CCF RID: 3279
		public const string STR12402 = "12402";

		// Token: 0x04000CD0 RID: 3280
		public const string STR12430 = "12430";

		// Token: 0x04000CD1 RID: 3281
		public const string STR12433 = "12433";

		// Token: 0x04000CD2 RID: 3282
		public const string STR13128 = "13128";

		// Token: 0x04000CD3 RID: 3283
		public const string STR13143 = "13143";

		// Token: 0x04000CD4 RID: 3284
		public const string STR13227 = "13227";

		// Token: 0x04000CD5 RID: 3285
		public const string STR13236 = "13236";

		// Token: 0x04000CD6 RID: 3286
		public const string STR13607 = "13607";

		// Token: 0x04000CD7 RID: 3287
		public const string STR13624 = "13624";

		// Token: 0x04000CD8 RID: 3288
		public const string STR13764 = "13764";

		// Token: 0x04000CD9 RID: 3289
		public const string STR13787 = "13787";

		// Token: 0x04000CDA RID: 3290
		public const string STR13826 = "13826";

		// Token: 0x04000CDB RID: 3291
		public const string STR13853 = "13853";

		// Token: 0x04000CDC RID: 3292
		public const string STR14049 = "14049";

		// Token: 0x04000CDD RID: 3293
		public const string STR14078 = "14078";

		// Token: 0x04000CDE RID: 3294
		public const string STR18731 = "18731";

		// Token: 0x04000CDF RID: 3295
		public const string STR18740 = "18740";

		// Token: 0x04000CE0 RID: 3296
		public const string STR18888 = "18888";

		// Token: 0x04000CE1 RID: 3297
		public const string STR18903 = "18903";

		// Token: 0x04000CE2 RID: 3298
		public const string STR18958 = "18958";

		// Token: 0x04000CE3 RID: 3299
		public const string STR18961 = "18961";

		// Token: 0x04000CE4 RID: 3300
		public const string STR19181 = "19181";

		// Token: 0x04000CE5 RID: 3301
		public const string STR19186 = "19186";

		// Token: 0x04000CE6 RID: 3302
		public const string STR19553 = "19553";

		// Token: 0x04000CE7 RID: 3303
		public const string STR19582 = "19582";

		// Token: 0x04000CE8 RID: 3304
		public const string STR19586 = "19586";

		// Token: 0x04000CE9 RID: 3305
		public const string STR19613 = "19613";

		// Token: 0x04000CEA RID: 3306
		public const string STR20292 = "20292";

		// Token: 0x04000CEB RID: 3307
		public const string STR20315 = "20315";

		// Token: 0x04000CEC RID: 3308
		public const string STR20391 = "20391";

		// Token: 0x04000CED RID: 3309
		public const string STR20408 = "20408";

		// Token: 0x04000CEE RID: 3310
		public const string STR20749 = "20749";

		// Token: 0x04000CEF RID: 3311
		public const string STR20754 = "20754";

		// Token: 0x04000CF0 RID: 3312
		public const string STR20974 = "20974";

		// Token: 0x04000CF1 RID: 3313
		public const string STR20977 = "20977";

		// Token: 0x04000CF2 RID: 3314
		public const string STR21032 = "21032";

		// Token: 0x04000CF3 RID: 3315
		public const string STR21047 = "21047";

		// Token: 0x04000CF4 RID: 3316
		public const string STR21195 = "21195";

		// Token: 0x04000CF5 RID: 3317
		public const string STR21204 = "21204";

		// Token: 0x04000CF6 RID: 3318
		public const string STR21575 = "21575";

		// Token: 0x04000CF7 RID: 3319
		public const string STR21592 = "21592";

		// Token: 0x04000CF8 RID: 3320
		public const string STR21668 = "21668";

		// Token: 0x04000CF9 RID: 3321
		public const string STR21691 = "21691";

		// Token: 0x04000CFA RID: 3322
		public const string STR22370 = "22370";

		// Token: 0x04000CFB RID: 3323
		public const string STR22397 = "22397";

		// Token: 0x04000CFC RID: 3324
		public const string STR22401 = "22401";

		// Token: 0x04000CFD RID: 3325
		public const string STR22430 = "22430";

		// Token: 0x04000CFE RID: 3326
		public const string STR24928 = "24928";

		// Token: 0x04000CFF RID: 3327
		public const string STR24959 = "24959";

		// Token: 0x04000D00 RID: 3328
		public const string STR24963 = "24963";

		// Token: 0x04000D01 RID: 3329
		public const string STR24988 = "24988";

		// Token: 0x04000D02 RID: 3330
		public const string STR25157 = "25157";

		// Token: 0x04000D03 RID: 3331
		public const string STR25178 = "25178";

		// Token: 0x04000D04 RID: 3332
		public const string STR25254 = "25254";

		// Token: 0x04000D05 RID: 3333
		public const string STR25273 = "25273";

		// Token: 0x04000D06 RID: 3334
		public const string STR25642 = "25642";

		// Token: 0x04000D07 RID: 3335
		public const string STR25653 = "25653";

		// Token: 0x04000D08 RID: 3336
		public const string STR25801 = "25801";

		// Token: 0x04000D09 RID: 3337
		public const string STR25814 = "25814";

		// Token: 0x04000D0A RID: 3338
		public const string STR26383 = "26383";

		// Token: 0x04000D0B RID: 3339
		public const string STR26384 = "26384";

		// Token: 0x04000D0C RID: 3340
		public const string STR26604 = "26604";

		// Token: 0x04000D0D RID: 3341
		public const string STR26611 = "26611";

		// Token: 0x04000D0E RID: 3342
		public const string STR31046 = "31046";

		// Token: 0x04000D0F RID: 3343
		public const string STR31065 = "31065";

		// Token: 0x04000D10 RID: 3344
		public const string STR31141 = "31141";

		// Token: 0x04000D11 RID: 3345
		public const string STR31162 = "31162";

		// Token: 0x04000D12 RID: 3346
		public const string STR31331 = "31331";

		// Token: 0x04000D13 RID: 3347
		public const string STR31356 = "31356";

		// Token: 0x04000D14 RID: 3348
		public const string STR31360 = "31360";

		// Token: 0x04000D15 RID: 3349
		public const string STR31391 = "31391";

		// Token: 0x04000D16 RID: 3350
		public const string STR31756 = "31756";

		// Token: 0x04000D17 RID: 3351
		public const string STR31763 = "31763";

		// Token: 0x04000D18 RID: 3352
		public const string STR31983 = "31983";

		// Token: 0x04000D19 RID: 3353
		public const string STR31984 = "31984";

		// Token: 0x04000D1A RID: 3354
		public const string STR32553 = "32553";

		// Token: 0x04000D1B RID: 3355
		public const string STR32566 = "32566";

		// Token: 0x04000D1C RID: 3356
		public const string STR32714 = "32714";

		// Token: 0x04000D1D RID: 3357
		public const string STR32725 = "32725";

		// Token: 0x04000D1E RID: 3358
		public const string STR35149 = "35149";

		// Token: 0x04000D1F RID: 3359
		public const string STR35154 = "35154";

		// Token: 0x04000D20 RID: 3360
		public const string STR35246 = "35246";

		// Token: 0x04000D21 RID: 3361
		public const string STR35249 = "35249";

		// Token: 0x04000D22 RID: 3362
		public const string STR35432 = "35432";

		// Token: 0x04000D23 RID: 3363
		public const string STR35447 = "35447";

		// Token: 0x04000D24 RID: 3364
		public const string STR35467 = "35467";

		// Token: 0x04000D25 RID: 3365
		public const string STR35476 = "35476";

		// Token: 0x04000D26 RID: 3366
		public const string STR35847 = "35847";

		// Token: 0x04000D27 RID: 3367
		public const string STR35864 = "35864";

		// Token: 0x04000D28 RID: 3368
		public const string STR36068 = "36068";

		// Token: 0x04000D29 RID: 3369
		public const string STR36091 = "36091";

		// Token: 0x04000D2A RID: 3370
		public const string STR36642 = "36642";

		// Token: 0x04000D2B RID: 3371
		public const string STR36669 = "36669";

		// Token: 0x04000D2C RID: 3372
		public const string STR36801 = "36801";

		// Token: 0x04000D2D RID: 3373
		public const string STR36830 = "36830";

		// Token: 0x04000D2E RID: 3374
		public const string STR37227 = "37227";

		// Token: 0x04000D2F RID: 3375
		public const string STR37236 = "37236";

		// Token: 0x04000D30 RID: 3376
		public const string STR37256 = "37256";

		// Token: 0x04000D31 RID: 3377
		public const string STR37271 = "37271";

		// Token: 0x04000D32 RID: 3378
		public const string STR37454 = "37454";

		// Token: 0x04000D33 RID: 3379
		public const string STR37457 = "37457";

		// Token: 0x04000D34 RID: 3380
		public const string STR37549 = "37549";

		// Token: 0x04000D35 RID: 3381
		public const string STR37554 = "37554";

		// Token: 0x04000D36 RID: 3382
		public const string STR37921 = "37921";

		// Token: 0x04000D37 RID: 3383
		public const string STR37950 = "37950";

		// Token: 0x04000D38 RID: 3384
		public const string STR38082 = "38082";

		// Token: 0x04000D39 RID: 3385
		public const string STR38109 = "38109";

		// Token: 0x04000D3A RID: 3386
		public const string STR38660 = "38660";

		// Token: 0x04000D3B RID: 3387
		public const string STR38683 = "38683";

		// Token: 0x04000D3C RID: 3388
		public const string STR38887 = "38887";

		// Token: 0x04000D3D RID: 3389
		public const string STR38904 = "38904";

		// Token: 0x04000D3E RID: 3390
		public const string STR41222 = "41222";

		// Token: 0x04000D3F RID: 3391
		public const string STR41241 = "41241";

		// Token: 0x04000D40 RID: 3392
		public const string STR41445 = "41445";

		// Token: 0x04000D41 RID: 3393
		public const string STR41466 = "41466";

		// Token: 0x04000D42 RID: 3394
		public const string STR41507 = "41507";

		// Token: 0x04000D43 RID: 3395
		public const string STR41532 = "41532";

		// Token: 0x04000D44 RID: 3396
		public const string STR41664 = "41664";

		// Token: 0x04000D45 RID: 3397
		public const string STR41695 = "41695";

		// Token: 0x04000D46 RID: 3398
		public const string STR42060 = "42060";

		// Token: 0x04000D47 RID: 3399
		public const string STR42067 = "42067";

		// Token: 0x04000D48 RID: 3400
		public const string STR42159 = "42159";

		// Token: 0x04000D49 RID: 3401
		public const string STR42160 = "42160";

		// Token: 0x04000D4A RID: 3402
		public const string STR42857 = "42857";

		// Token: 0x04000D4B RID: 3403
		public const string STR42870 = "42870";

		// Token: 0x04000D4C RID: 3404
		public const string STR42890 = "42890";

		// Token: 0x04000D4D RID: 3405
		public const string STR42901 = "42901";

		// Token: 0x04000D4E RID: 3406
		public const string STR47392 = "47392";

		// Token: 0x04000D4F RID: 3407
		public const string STR47423 = "47423";

		// Token: 0x04000D50 RID: 3408
		public const string STR47555 = "47555";

		// Token: 0x04000D51 RID: 3409
		public const string STR47580 = "47580";

		// Token: 0x04000D52 RID: 3410
		public const string STR47621 = "47621";

		// Token: 0x04000D53 RID: 3411
		public const string STR47642 = "47642";

		// Token: 0x04000D54 RID: 3412
		public const string STR47846 = "47846";

		// Token: 0x04000D55 RID: 3413
		public const string STR47865 = "47865";

		// Token: 0x04000D56 RID: 3414
		public const string STR48234 = "48234";

		// Token: 0x04000D57 RID: 3415
		public const string STR48245 = "48245";

		// Token: 0x04000D58 RID: 3416
		public const string STR48265 = "48265";

		// Token: 0x04000D59 RID: 3417
		public const string STR48278 = "48278";

		// Token: 0x04000D5A RID: 3418
		public const string STR48975 = "48975";

		// Token: 0x04000D5B RID: 3419
		public const string STR48976 = "48976";

		// Token: 0x04000D5C RID: 3420
		public const string STR49068 = "49068";

		// Token: 0x04000D5D RID: 3421
		public const string STR49075 = "49075";

		// Token: 0x04000D5E RID: 3422
		public const string STR49254 = "49254";

		// Token: 0x04000D5F RID: 3423
		public const string STR49273 = "49273";

		// Token: 0x04000D60 RID: 3424
		public const string STR49285 = "49285";

		// Token: 0x04000D61 RID: 3425
		public const string STR49306 = "49306";

		// Token: 0x04000D62 RID: 3426
		public const string STR49987 = "49987";

		// Token: 0x04000D63 RID: 3427
		public const string STR50012 = "50012";

		// Token: 0x04000D64 RID: 3428
		public const string STR50080 = "50080";

		// Token: 0x04000D65 RID: 3429
		public const string STR50111 = "50111";

		// Token: 0x04000D66 RID: 3430
		public const string STR50476 = "50476";

		// Token: 0x04000D67 RID: 3431
		public const string STR50483 = "50483";

		// Token: 0x04000D68 RID: 3432
		public const string STR50639 = "50639";

		// Token: 0x04000D69 RID: 3433
		public const string STR50640 = "50640";

		// Token: 0x04000D6A RID: 3434
		public const string STR50697 = "50697";

		// Token: 0x04000D6B RID: 3435
		public const string STR50710 = "50710";

		// Token: 0x04000D6C RID: 3436
		public const string STR50922 = "50922";

		// Token: 0x04000D6D RID: 3437
		public const string STR50933 = "50933";

		// Token: 0x04000D6E RID: 3438
		public const string STR55360 = "55360";

		// Token: 0x04000D6F RID: 3439
		public const string STR55391 = "55391";

		// Token: 0x04000D70 RID: 3440
		public const string STR55459 = "55459";

		// Token: 0x04000D71 RID: 3441
		public const string STR55484 = "55484";

		// Token: 0x04000D72 RID: 3442
		public const string STR56165 = "56165";

		// Token: 0x04000D73 RID: 3443
		public const string STR56186 = "56186";

		// Token: 0x04000D74 RID: 3444
		public const string STR56198 = "56198";

		// Token: 0x04000D75 RID: 3445
		public const string STR56217 = "56217";

		// Token: 0x04000D76 RID: 3446
		public const string STR56586 = "56586";

		// Token: 0x04000D77 RID: 3447
		public const string STR56597 = "56597";

		// Token: 0x04000D78 RID: 3448
		public const string STR56809 = "56809";

		// Token: 0x04000D79 RID: 3449
		public const string STR56822 = "56822";

		// Token: 0x04000D7A RID: 3450
		public const string STR56879 = "56879";

		// Token: 0x04000D7B RID: 3451
		public const string STR56880 = "56880";

		// Token: 0x04000D7C RID: 3452
		public const string STR57036 = "57036";

		// Token: 0x04000D7D RID: 3453
		public const string STR57043 = "57043";

		// Token: 0x04000D7E RID: 3454
		public const string STR59437 = "59437";

		// Token: 0x04000D7F RID: 3455
		public const string STR59442 = "59442";

		// Token: 0x04000D80 RID: 3456
		public const string STR59598 = "59598";

		// Token: 0x04000D81 RID: 3457
		public const string STR59601 = "59601";

		// Token: 0x04000D82 RID: 3458
		public const string STR60168 = "60168";

		// Token: 0x04000D83 RID: 3459
		public const string STR60183 = "60183";

		// Token: 0x04000D84 RID: 3460
		public const string STR60404 = "60404";

		// Token: 0x04000D85 RID: 3461
		public const string STR60775 = "60775";

		// Token: 0x04000D86 RID: 3462
		public const string STR60792 = "60792";

		// Token: 0x04000D87 RID: 3463
		public const string STR60804 = "60804";

		// Token: 0x04000D88 RID: 3464
		public const string STR60827 = "60827";

		// Token: 0x04000D89 RID: 3465
		public const string STR60994 = "60994";

		// Token: 0x04000D8A RID: 3466
		public const string STR61021 = "61021";

		// Token: 0x04000D8B RID: 3467
		public const string STR61089 = "61089";

		// Token: 0x04000D8C RID: 3468
		public const string STR61118 = "61118";

		// Token: 0x04000D8D RID: 3469
		public const string STR61451 = "61451";

		// Token: 0x04000D8E RID: 3470
		public const string STR61460 = "61460";

		// Token: 0x04000D8F RID: 3471
		public const string STR61672 = "61672";

		// Token: 0x04000D90 RID: 3472
		public const string STR61687 = "61687";

		// Token: 0x04000D91 RID: 3473
		public const string STR62254 = "62254";

		// Token: 0x04000D92 RID: 3474
		public const string STR62257 = "62257";

		// Token: 0x04000D93 RID: 3475
		public const string STR62413 = "62413";

		// Token: 0x04000D94 RID: 3476
		public const string STR62418 = "62418";

		// Token: 0x04000D95 RID: 3477
		public const string STR62785 = "62785";

		// Token: 0x04000D96 RID: 3478
		public const string STR62814 = "62814";

		// Token: 0x04000D97 RID: 3479
		public const string STR62882 = "62882";

		// Token: 0x04000D98 RID: 3480
		public const string STR62909 = "62909";

		// Token: 0x04000D99 RID: 3481
		public const string STR63076 = "63076";

		// Token: 0x04000D9A RID: 3482
		public const string STR63099 = "63099";

		// Token: 0x04000D9B RID: 3483
		public const string STR63111 = "63111";

		// Token: 0x04000D9C RID: 3484
		public const string STR63128 = "63128";

		// Token: 0x04000D9D RID: 3485
		public const string STR65535 = "65535";

		// Token: 0x04000D9E RID: 3486
		public const string STR7936 = "7936";

		// Token: 0x04000D9F RID: 3487
		public const string STR58112 = "58112";

		// Token: 0x04000DA0 RID: 3488
		public const string STR64512 = "64512";

		// Token: 0x04000DA1 RID: 3489
		public const string STR9475 = "9475";

		// Token: 0x04000DA2 RID: 3490
		public const string STR14851 = "14851";

		// Token: 0x04000DA3 RID: 3491
		public const string STR50691 = "50691";

		// Token: 0x04000DA4 RID: 3492
		public const string STR55555 = "55555";

		// Token: 0x04000DA5 RID: 3493
		public const string STR18949 = "18949";

		// Token: 0x04000DA6 RID: 3494
		public const string STR21765 = "21765";

		// Token: 0x04000DA7 RID: 3495
		public const string STR43269 = "43269";

		// Token: 0x04000DA8 RID: 3496
		public const string STR46597 = "46597";

		// Token: 0x04000DA9 RID: 3497
		public const string STR28422 = "28422";

		// Token: 0x04000DAA RID: 3498
		public const string STR28678 = "28678";

		// Token: 0x04000DAB RID: 3499
		public const string STR35846 = "35846";

		// Token: 0x04000DAC RID: 3500
		public const string STR37638 = "37638";

		// Token: 0x04000DAD RID: 3501
		public const string STR9752 = "9752";

		// Token: 0x04000DAE RID: 3502
		public const string STR14616 = "14616";

		// Token: 0x04000DAF RID: 3503
		public const string STR50456 = "50456";

		// Token: 0x04000DB0 RID: 3504
		public const string STR55832 = "55832";

		// Token: 0x04000DB1 RID: 3505
		public const string STR795 = "795";

		// Token: 0x04000DB2 RID: 3506
		public const string STR7195 = "7195";

		// Token: 0x04000DB3 RID: 3507
		public const string STR57371 = "57371";

		// Token: 0x04000DB4 RID: 3508
		public const string STR65307 = "65307";

		// Token: 0x04000DB5 RID: 3509
		public const string STR27677 = "27677";

		// Token: 0x04000DB6 RID: 3510
		public const string STR29469 = "29469";

		// Token: 0x04000DB7 RID: 3511
		public const string STR36637 = "36637";

		// Token: 0x04000DB8 RID: 3512
		public const string STR36893 = "36893";

		// Token: 0x04000DB9 RID: 3513
		public const string STR18718 = "18718";

		// Token: 0x04000DBA RID: 3514
		public const string STR22046 = "22046";

		// Token: 0x04000DBB RID: 3515
		public const string STR43550 = "43550";

		// Token: 0x04000DBC RID: 3516
		public const string STR46366 = "46366";

		// Token: 0x04000DBD RID: 3517
		public const string STR19240 = "19240";

		// Token: 0x04000DBE RID: 3518
		public const string STR21544 = "21544";

		// Token: 0x04000DBF RID: 3519
		public const string STR43048 = "43048";

		// Token: 0x04000DC0 RID: 3520
		public const string STR46888 = "46888";

		// Token: 0x04000DC1 RID: 3521
		public const string STR28203 = "28203";

		// Token: 0x04000DC2 RID: 3522
		public const string STR28971 = "28971";

		// Token: 0x04000DC3 RID: 3523
		public const string STR36139 = "36139";

		// Token: 0x04000DC4 RID: 3524
		public const string STR37419 = "37419";

		// Token: 0x04000DC5 RID: 3525
		public const string STR301 = "301";

		// Token: 0x04000DC6 RID: 3526
		public const string STR7725 = "7725";

		// Token: 0x04000DC7 RID: 3527
		public const string STR57901 = "57901";

		// Token: 0x04000DC8 RID: 3528
		public const string STR64813 = "64813";

		// Token: 0x04000DC9 RID: 3529
		public const string STR9262 = "9262";

		// Token: 0x04000DCA RID: 3530
		public const string STR15150 = "15150";

		// Token: 0x04000DCB RID: 3531
		public const string STR50990 = "50990";

		// Token: 0x04000DCC RID: 3532
		public const string STR55342 = "55342";

		// Token: 0x04000DCD RID: 3533
		public const string STR27952 = "27952";

		// Token: 0x04000DCE RID: 3534
		public const string STR29232 = "29232";

		// Token: 0x04000DCF RID: 3535
		public const string STR36400 = "36400";

		// Token: 0x04000DD0 RID: 3536
		public const string STR37168 = "37168";

		// Token: 0x04000DD1 RID: 3537
		public const string STR18483 = "18483";

		// Token: 0x04000DD2 RID: 3538
		public const string STR22323 = "22323";

		// Token: 0x04000DD3 RID: 3539
		public const string STR43827 = "43827";

		// Token: 0x04000DD4 RID: 3540
		public const string STR46131 = "46131";

		// Token: 0x04000DD5 RID: 3541
		public const string STR10037 = "10037";

		// Token: 0x04000DD6 RID: 3542
		public const string STR14389 = "14389";

		// Token: 0x04000DD7 RID: 3543
		public const string STR50229 = "50229";

		// Token: 0x04000DD8 RID: 3544
		public const string STR56117 = "56117";

		// Token: 0x04000DD9 RID: 3545
		public const string STR566 = "566";

		// Token: 0x04000DDA RID: 3546
		public const string STR7478 = "7478";

		// Token: 0x04000DDB RID: 3547
		public const string STR57654 = "57654";

		// Token: 0x04000DDC RID: 3548
		public const string STR65078 = "65078";

		// Token: 0x04000DDD RID: 3549
		public const string STR11081 = "11081";

		// Token: 0x04000DDE RID: 3550
		public const string STR13385 = "13385";

		// Token: 0x04000DDF RID: 3551
		public const string STR51273 = "51273";

		// Token: 0x04000DE0 RID: 3552
		public const string STR55113 = "55113";

		// Token: 0x04000DE1 RID: 3553
		public const string STR3658 = "3658";

		// Token: 0x04000DE2 RID: 3554
		public const string STR4426 = "4426";

		// Token: 0x04000DE3 RID: 3555
		public const string STR60746 = "60746";

		// Token: 0x04000DE4 RID: 3556
		public const string STR62026 = "62026";

		// Token: 0x04000DE5 RID: 3557
		public const string STR24908 = "24908";

		// Token: 0x04000DE6 RID: 3558
		public const string STR32332 = "32332";

		// Token: 0x04000DE7 RID: 3559
		public const string STR33356 = "33356";

		// Token: 0x04000DE8 RID: 3560
		public const string STR40268 = "40268";

		// Token: 0x04000DE9 RID: 3561
		public const string STR17487 = "17487";

		// Token: 0x04000DEA RID: 3562
		public const string STR23375 = "23375";

		// Token: 0x04000DEB RID: 3563
		public const string STR42831 = "42831";

		// Token: 0x04000DEC RID: 3564
		public const string STR47183 = "47183";

		// Token: 0x04000DED RID: 3565
		public const string STR3409 = "3409";

		// Token: 0x04000DEE RID: 3566
		public const string STR4689 = "4689";

		// Token: 0x04000DEF RID: 3567
		public const string STR61009 = "61009";

		// Token: 0x04000DF0 RID: 3568
		public const string STR61777 = "61777";

		// Token: 0x04000DF1 RID: 3569
		public const string STR10322 = "10322";

		// Token: 0x04000DF2 RID: 3570
		public const string STR14162 = "14162";

		// Token: 0x04000DF3 RID: 3571
		public const string STR52050 = "52050";

		// Token: 0x04000DF4 RID: 3572
		public const string STR54354 = "54354";

		// Token: 0x04000DF5 RID: 3573
		public const string STR18260 = "18260";

		// Token: 0x04000DF6 RID: 3574
		public const string STR22612 = "22612";

		// Token: 0x04000DF7 RID: 3575
		public const string STR42068 = "42068";

		// Token: 0x04000DF8 RID: 3576
		public const string STR47956 = "47956";

		// Token: 0x04000DF9 RID: 3577
		public const string STR25175 = "25175";

		// Token: 0x04000DFA RID: 3578
		public const string STR32087 = "32087";

		// Token: 0x04000DFB RID: 3579
		public const string STR33111 = "33111";

		// Token: 0x04000DFC RID: 3580
		public const string STR40535 = "40535";

		// Token: 0x04000DFD RID: 3581
		public const string STR24673 = "24673";

		// Token: 0x04000DFE RID: 3582
		public const string STR32609 = "32609";

		// Token: 0x04000DFF RID: 3583
		public const string STR33633 = "33633";

		// Token: 0x04000E00 RID: 3584
		public const string STR40033 = "40033";

		// Token: 0x04000E01 RID: 3585
		public const string STR17762 = "17762";

		// Token: 0x04000E02 RID: 3586
		public const string STR23138 = "23138";

		// Token: 0x04000E03 RID: 3587
		public const string STR42594 = "42594";

		// Token: 0x04000E04 RID: 3588
		public const string STR47458 = "47458";

		// Token: 0x04000E05 RID: 3589
		public const string STR10852 = "10852";

		// Token: 0x04000E06 RID: 3590
		public const string STR13668 = "13668";

		// Token: 0x04000E07 RID: 3591
		public const string STR51556 = "51556";

		// Token: 0x04000E08 RID: 3592
		public const string STR54884 = "54884";

		// Token: 0x04000E09 RID: 3593
		public const string STR3943 = "3943";

		// Token: 0x04000E0A RID: 3594
		public const string STR4199 = "4199";

		// Token: 0x04000E0B RID: 3595
		public const string STR60519 = "60519";

		// Token: 0x04000E0C RID: 3596
		public const string STR62311 = "62311";

		// Token: 0x04000E0D RID: 3597
		public const string STR18041 = "18041";

		// Token: 0x04000E0E RID: 3598
		public const string STR22905 = "22905";

		// Token: 0x04000E0F RID: 3599
		public const string STR42361 = "42361";

		// Token: 0x04000E10 RID: 3600
		public const string STR47737 = "47737";

		// Token: 0x04000E11 RID: 3601
		public const string STR25466 = "25466";

		// Token: 0x04000E12 RID: 3602
		public const string STR31866 = "31866";

		// Token: 0x04000E13 RID: 3603
		public const string STR32890 = "32890";

		// Token: 0x04000E14 RID: 3604
		public const string STR40826 = "40826";

		// Token: 0x04000E15 RID: 3605
		public const string STR3196 = "3196";

		// Token: 0x04000E16 RID: 3606
		public const string STR4988 = "4988";

		// Token: 0x04000E17 RID: 3607
		public const string STR61308 = "61308";

		// Token: 0x04000E18 RID: 3608
		public const string STR61564 = "61564";

		// Token: 0x04000E19 RID: 3609
		public const string STR10623 = "10623";

		// Token: 0x04000E1A RID: 3610
		public const string STR13951 = "13951";

		// Token: 0x04000E1B RID: 3611
		public const string STR51839 = "51839";

		// Token: 0x04000E1C RID: 3612
		public const string STR54655 = "54655";

		// Token: 0x04000E1D RID: 3613
		public const string STR19849 = "19849";

		// Token: 0x04000E1E RID: 3614
		public const string STR21129 = "21129";

		// Token: 0x04000E1F RID: 3615
		public const string STR44681 = "44681";

		// Token: 0x04000E20 RID: 3616
		public const string STR45449 = "45449";

		// Token: 0x04000E21 RID: 3617
		public const string STR26762 = "26762";

		// Token: 0x04000E22 RID: 3618
		public const string STR30602 = "30602";

		// Token: 0x04000E23 RID: 3619
		public const string STR35722 = "35722";

		// Token: 0x04000E24 RID: 3620
		public const string STR38026 = "38026";

		// Token: 0x04000E25 RID: 3621
		public const string STR1932 = "1932";

		// Token: 0x04000E26 RID: 3622
		public const string STR6284 = "6284";

		// Token: 0x04000E27 RID: 3623
		public const string STR58508 = "58508";

		// Token: 0x04000E28 RID: 3624
		public const string STR64396 = "64396";

		// Token: 0x04000E29 RID: 3625
		public const string STR8847 = "8847";

		// Token: 0x04000E2A RID: 3626
		public const string STR15759 = "15759";

		// Token: 0x04000E2B RID: 3627
		public const string STR49551 = "49551";

		// Token: 0x04000E2C RID: 3628
		public const string STR56975 = "56975";

		// Token: 0x04000E2D RID: 3629
		public const string STR27537 = "27537";

		// Token: 0x04000E2E RID: 3630
		public const string STR29841 = "29841";

		// Token: 0x04000E2F RID: 3631
		public const string STR34961 = "34961";

		// Token: 0x04000E30 RID: 3632
		public const string STR38801 = "38801";

		// Token: 0x04000E31 RID: 3633
		public const string STR20114 = "20114";

		// Token: 0x04000E32 RID: 3634
		public const string STR20882 = "20882";

		// Token: 0x04000E33 RID: 3635
		public const string STR44434 = "44434";

		// Token: 0x04000E34 RID: 3636
		public const string STR45714 = "45714";

		// Token: 0x04000E35 RID: 3637
		public const string STR8596 = "8596";

		// Token: 0x04000E36 RID: 3638
		public const string STR16020 = "16020";

		// Token: 0x04000E37 RID: 3639
		public const string STR49812 = "49812";

		// Token: 0x04000E38 RID: 3640
		public const string STR56724 = "56724";

		// Token: 0x04000E39 RID: 3641
		public const string STR1175 = "1175";

		// Token: 0x04000E3A RID: 3642
		public const string STR7063 = "7063";

		// Token: 0x04000E3B RID: 3643
		public const string STR59287 = "59287";

		// Token: 0x04000E3C RID: 3644
		public const string STR63639 = "63639";

		// Token: 0x04000E3D RID: 3645
		public const string STR1697 = "1697";

		// Token: 0x04000E3E RID: 3646
		public const string STR6561 = "6561";

		// Token: 0x04000E3F RID: 3647
		public const string STR58785 = "58785";

		// Token: 0x04000E40 RID: 3648
		public const string STR64161 = "64161";

		// Token: 0x04000E41 RID: 3649
		public const string STR9122 = "9122";

		// Token: 0x04000E42 RID: 3650
		public const string STR15522 = "15522";

		// Token: 0x04000E43 RID: 3651
		public const string STR49314 = "49314";

		// Token: 0x04000E44 RID: 3652
		public const string STR57250 = "57250";

		// Token: 0x04000E45 RID: 3653
		public const string STR19620 = "19620";

		// Token: 0x04000E46 RID: 3654
		public const string STR21412 = "21412";

		// Token: 0x04000E47 RID: 3655
		public const string STR44964 = "44964";

		// Token: 0x04000E48 RID: 3656
		public const string STR45220 = "45220";

		// Token: 0x04000E49 RID: 3657
		public const string STR27047 = "27047";

		// Token: 0x04000E4A RID: 3658
		public const string STR30375 = "30375";

		// Token: 0x04000E4B RID: 3659
		public const string STR35495 = "35495";

		// Token: 0x04000E4C RID: 3660
		public const string STR38311 = "38311";

		// Token: 0x04000E4D RID: 3661
		public const string STR8377 = "8377";

		// Token: 0x04000E4E RID: 3662
		public const string STR16313 = "16313";

		// Token: 0x04000E4F RID: 3663
		public const string STR50105 = "50105";

		// Token: 0x04000E50 RID: 3664
		public const string STR56505 = "56505";

		// Token: 0x04000E51 RID: 3665
		public const string STR1466 = "1466";

		// Token: 0x04000E52 RID: 3666
		public const string STR6842 = "6842";

		// Token: 0x04000E53 RID: 3667
		public const string STR59066 = "59066";

		// Token: 0x04000E54 RID: 3668
		public const string STR63930 = "63930";

		// Token: 0x04000E55 RID: 3669
		public const string STR27324 = "27324";

		// Token: 0x04000E56 RID: 3670
		public const string STR30140 = "30140";

		// Token: 0x04000E57 RID: 3671
		public const string STR35260 = "35260";

		// Token: 0x04000E58 RID: 3672
		public const string STR38588 = "38588";

		// Token: 0x04000E59 RID: 3673
		public const string STR20415 = "20415";

		// Token: 0x04000E5A RID: 3674
		public const string STR20671 = "20671";

		// Token: 0x04000E5B RID: 3675
		public const string STR44223 = "44223";

		// Token: 0x04000E5C RID: 3676
		public const string STR46015 = "46015";

		// Token: 0x04000E5D RID: 3677
		public const string STR26304 = "26304";

		// Token: 0x04000E5E RID: 3678
		public const string STR31168 = "31168";

		// Token: 0x04000E5F RID: 3679
		public const string STR34240 = "34240";

		// Token: 0x04000E60 RID: 3680
		public const string STR39616 = "39616";

		// Token: 0x04000E61 RID: 3681
		public const string STR17347 = "17347";

		// Token: 0x04000E62 RID: 3682
		public const string STR23747 = "23747";

		// Token: 0x04000E63 RID: 3683
		public const string STR41155 = "41155";

		// Token: 0x04000E64 RID: 3684
		public const string STR49091 = "49091";

		// Token: 0x04000E65 RID: 3685
		public const string STR11461 = "11461";

		// Token: 0x04000E66 RID: 3686
		public const string STR13253 = "13253";

		// Token: 0x04000E67 RID: 3687
		public const string STR53189 = "53189";

		// Token: 0x04000E68 RID: 3688
		public const string STR53445 = "53445";

		// Token: 0x04000E69 RID: 3689
		public const string STR2502 = "2502";

		// Token: 0x04000E6A RID: 3690
		public const string STR5830 = "5830";

		// Token: 0x04000E6B RID: 3691
		public const string STR60102 = "60102";

		// Token: 0x04000E6C RID: 3692
		public const string STR62918 = "62918";

		// Token: 0x04000E6D RID: 3693
		public const string STR34000 = "34000";

		// Token: 0x04000E6E RID: 3694
		public const string STR34271 = "34271";

		// Token: 0x04000E6F RID: 3695
		public const string STR35539 = "35539";

		// Token: 0x04000E70 RID: 3696
		public const string STR35804 = "35804";

		// Token: 0x04000E71 RID: 3697
		public const string STR46805 = "46805";

		// Token: 0x04000E72 RID: 3698
		public const string STR47066 = "47066";

		// Token: 0x04000E73 RID: 3699
		public const string STR47318 = "47318";

		// Token: 0x04000E74 RID: 3700
		public const string STR47577 = "47577";

		// Token: 0x04000E75 RID: 3701
		public const string STR53466 = "53466";

		// Token: 0x04000E76 RID: 3702
		public const string STR53717 = "53717";

		// Token: 0x04000E77 RID: 3703
		public const string STR57049 = "57049";

		// Token: 0x04000E78 RID: 3704
		public const string STR57302 = "57302";

		// Token: 0x04000E79 RID: 3705
		public const string STR58079 = "58079";

		// Token: 0x04000E7A RID: 3706
		public const string STR58320 = "58320";

		// Token: 0x04000E7B RID: 3707
		public const string STR60636 = "60636";

		// Token: 0x04000E7C RID: 3708
		public const string STR60883 = "60883";

		// Token: 0x04000E7D RID: 3709
		public const string STR11752 = "11752";

		// Token: 0x04000E7E RID: 3710
		public const string STR13032 = "13032";

		// Token: 0x04000E7F RID: 3711
		public const string STR52968 = "52968";

		// Token: 0x04000E80 RID: 3712
		public const string STR53736 = "53736";

		// Token: 0x04000E81 RID: 3713
		public const string STR2283 = "2283";

		// Token: 0x04000E82 RID: 3714
		public const string STR6123 = "6123";

		// Token: 0x04000E83 RID: 3715
		public const string STR60395 = "60395";

		// Token: 0x04000E84 RID: 3716
		public const string STR62699 = "62699";

		// Token: 0x04000E85 RID: 3717
		public const string STR26605 = "26605";

		// Token: 0x04000E86 RID: 3718
		public const string STR30957 = "30957";

		// Token: 0x04000E87 RID: 3719
		public const string STR34029 = "34029";

		// Token: 0x04000E88 RID: 3720
		public const string STR39917 = "39917";

		// Token: 0x04000E89 RID: 3721
		public const string STR17134 = "17134";

		// Token: 0x04000E8A RID: 3722
		public const string STR24046 = "24046";

		// Token: 0x04000E8B RID: 3723
		public const string STR41454 = "41454";

		// Token: 0x04000E8C RID: 3724
		public const string STR48878 = "48878";

		// Token: 0x04000E8D RID: 3725
		public const string STR3056 = "3056";

		// Token: 0x04000E8E RID: 3726
		public const string STR5360 = "5360";

		// Token: 0x04000E8F RID: 3727
		public const string STR59632 = "59632";

		// Token: 0x04000E90 RID: 3728
		public const string STR63472 = "63472";

		// Token: 0x04000E91 RID: 3729
		public const string STR12019 = "12019";

		// Token: 0x04000E92 RID: 3730
		public const string STR127872 = "12787";

		// Token: 0x04000E93 RID: 3731
		public const string STR52723 = "52723";

		// Token: 0x04000E94 RID: 3732
		public const string STR54003 = "54003";

		// Token: 0x04000E95 RID: 3733
		public const string STR16885 = "16885";

		// Token: 0x04000E96 RID: 3734
		public const string STR24309 = "24309";

		// Token: 0x04000E97 RID: 3735
		public const string STR41717 = "41717";

		// Token: 0x04000E98 RID: 3736
		public const string STR48629 = "48629";

		// Token: 0x04000E99 RID: 3737
		public const string STR25846 = "25846";

		// Token: 0x04000E9A RID: 3738
		public const string STR31734 = "31734";

		// Token: 0x04000E9B RID: 3739
		public const string STR34806 = "34806";

		// Token: 0x04000E9C RID: 3740
		public const string STR39158 = "39158";

		// Token: 0x04000E9D RID: 3741
		public const string SORTTYPE = "SortType";

		// Token: 0x04000E9E RID: 3742
		public const string SORTTYPEVALUE = "SORTTYPEVALUE";

		// Token: 0x04000E9F RID: 3743
		public const string NONESTR = "None";

		// Token: 0x04000EA0 RID: 3744
		public const string POSITION = "Position";

		// Token: 0x04000EA1 RID: 3745
		public const string MDC_SYS_CMP_TYPE_GRP = "MDC_SYS_CMP_TYPE_GRP";

		// Token: 0x04000EA2 RID: 3746
		public const string DIGITAL_ESS_CMP_TYPE_GRP = "DIGITAL_ESS_CMP_TYPE_GRP";

		// Token: 0x04000EA3 RID: 3747
		public const string RX_TG_LIST_DLH_TYPE_GRP = "RX_TG_LIST_DLH_TYPE_GRP";

		// Token: 0x04000EA4 RID: 3748
		public const string SCAN_PER_DLH_TYPE_GRP = "SCAN_PER_DLH_TYPE_GRP";

		// Token: 0x04000EA5 RID: 3749
		public const string ANALOG_UCL_DLH_TYPE_GRP = "ANALOG_UCL_DLH_TYPE_GRP";

		// Token: 0x04000EA6 RID: 3750
		public const string DIGITAL_UCL_DLH_TYPE_GRP = "DIGITAL_UCL_DLH_TYPE_GRP";

		// Token: 0x04000EA7 RID: 3751
		public const string ZN_PER_ASGN_DLH_TYPE_GRP = "ZN_PER_ASGN_DLH_TYPE_GRP";

		// Token: 0x04000EA8 RID: 3752
		public const char CHAR_ZERO = '0';

		// Token: 0x04000EA9 RID: 3753
		public const string CHAR_QUESTION = "?";

		// Token: 0x04000EAA RID: 3754
		public const string CHAR_COLON = ":";

		// Token: 0x04000EAB RID: 3755
		public const string CHAR_PLUS = "+";

		// Token: 0x04000EAC RID: 3756
		public const string CHAR_MINUS = "-";

		// Token: 0x04000EAD RID: 3757
		public const string CHAR_OPENPARENTH = "(";

		// Token: 0x04000EAE RID: 3758
		public const string CHAR_CLOSEPARENTH = ")";

		// Token: 0x04000EAF RID: 3759
		public const string CHAR_EXCLMTN = "!";

		// Token: 0x04000EB0 RID: 3760
		public const string UNDERSCORE = "_";

		// Token: 0x04000EB1 RID: 3761
		public const string DASH = "-";

		// Token: 0x04000EB2 RID: 3762
		public const string DOLLARSIGN = "$";

		// Token: 0x04000EB3 RID: 3763
		public const string BLANKSERIALNUM = "0000000000";

		// Token: 0x04000EB4 RID: 3764
		public const string FACTORY = "FACTORY";

		// Token: 0x04000EB5 RID: 3765
		public const string DEPOTTOOL = "DEPOTTOOL";

		// Token: 0x04000EB6 RID: 3766
		public const string CPS = "CPS";

		// Token: 0x04000EB7 RID: 3767
		public const string FIELDTOOL = "FIELDTOOL";

		// Token: 0x04000EB8 RID: 3768
		public const string TUNER = "TUNER";

		// Token: 0x04000EB9 RID: 3769
		public const string VHF = "VHF";

		// Token: 0x04000EBA RID: 3770
		public const string UHF = "UHF";

		// Token: 0x04000EBB RID: 3771
		public const string UHFWB = "UHFWB";

		// Token: 0x04000EBC RID: 3772
		public const string UHF480 = "UHF480";

		// Token: 0x04000EBD RID: 3773
		public const string FREQ_220 = "220";

		// Token: 0x04000EBE RID: 3774
		public const string STR200 = "STR200";

		// Token: 0x04000EBF RID: 3775
		public const string STR300 = "STR300";

		// Token: 0x04000EC0 RID: 3776
		public const string STR700 = "STR700";

		// Token: 0x04000EC1 RID: 3777
		public const string STR800 = "STR800";

		// Token: 0x04000EC2 RID: 3778
		public const string STR900 = "STR900";

		// Token: 0x04000EC3 RID: 3779
		public const string STR500 = "STR500";

		// Token: 0x04000EC4 RID: 3780
		public const string STR750 = "STR750";

		// Token: 0x04000EC5 RID: 3781
		public const string STR1500 = "STR1500";

		// Token: 0x04000EC6 RID: 3782
		public const string LOW = "LOW";

		// Token: 0x04000EC7 RID: 3783
		public const string DUAL = "DUAL";

		// Token: 0x04000EC8 RID: 3784
		public const string STR900ISM = "STR900ISM";

		// Token: 0x04000EC9 RID: 3785
		public const string SUPERTANAPA = "SUPERTANAPA";

		// Token: 0x04000ECA RID: 3786
		public const string CULTURE = "CULTURE";

		// Token: 0x04000ECB RID: 3787
		public const string LANGPACKID_INFO = "LANGPACKID_INFO_";

		// Token: 0x04000ECC RID: 3788
		public const string NA = "NA";

		// Token: 0x04000ECD RID: 3789
		public const string LANGPACKID_INFO_NA = "LANGPACKID_INFO_NA";

		// Token: 0x04000ECE RID: 3790
		public const string LA = "LA";

		// Token: 0x04000ECF RID: 3791
		public const string LANGPACKID_INFO_LA = "LANGPACKID_INFO_LA";

		// Token: 0x04000ED0 RID: 3792
		public const string EMEA = "EMEA";

		// Token: 0x04000ED1 RID: 3793
		public const string LANGPACKID_INFO_EMEA = "LANGPACKID_INFO_EMEA";

		// Token: 0x04000ED2 RID: 3794
		public const string AS = "AS";

		// Token: 0x04000ED3 RID: 3795
		public const string LANGPACKID_INFO_AS = "LANGPACKID_INFO_AS";

		// Token: 0x04000ED4 RID: 3796
		public const string FEDERAL = "FEDERAL";

		// Token: 0x04000ED5 RID: 3797
		public const string CPSUNPROGMMBLE = "CPSUNPROGMMBLE";

		// Token: 0x04000ED6 RID: 3798
		public const string NONE = "NONE";

		// Token: 0x04000ED7 RID: 3799
		public const string TWOLINEDISP = "TWOLINEDISP";

		// Token: 0x04000ED8 RID: 3800
		public const string TWOSEVENSEGLED = "TWOSEVENSEGLED";

		// Token: 0x04000ED9 RID: 3801
		public const string FULLGRAPHIC = "FULLGRAPHIC";

		// Token: 0x04000EDA RID: 3802
		public const string GROUP1 = "GROUP1";

		// Token: 0x04000EDB RID: 3803
		public const string GROUP2 = "GROUP2";

		// Token: 0x04000EDC RID: 3804
		public const string ASCII = "ASCII";

		// Token: 0x04000EDD RID: 3805
		public const string UNICODE = "UNICODE";

		// Token: 0x04000EDE RID: 3806
		public const string SINGLE = "SINGLE";

		// Token: 0x04000EDF RID: 3807
		public const string DECODEONLY = "DECODEONLY";

		// Token: 0x04000EE0 RID: 3808
		public const string ENCODEONLY = "ENCODEONLY";

		// Token: 0x04000EE1 RID: 3809
		public const string DECODEENCODE = "DECODEENCODE";

		// Token: 0x04000EE2 RID: 3810
		public const string AUTOONLY = "AUTOONLY";

		// Token: 0x04000EE3 RID: 3811
		public const string MANUALONLY = "MANUALONLY";

		// Token: 0x04000EE4 RID: 3812
		public const string MANUALAUTO = "MANUALAUTO";

		// Token: 0x04000EE5 RID: 3813
		public const string MIDTIER = "MIDTIER";

		// Token: 0x04000EE6 RID: 3814
		public const string LOWTIER = "LOWTIER";

		// Token: 0x04000EE7 RID: 3815
		public const string HIGHTIER = "HIGHTIER";

		// Token: 0x04000EE8 RID: 3816
		public const string PORTABLE = "PORTABLE";

		// Token: 0x04000EE9 RID: 3817
		public const string PORTABLELK = "PORTABLELK";

		// Token: 0x04000EEA RID: 3818
		public const string REPEATER = "REPEATER";

		// Token: 0x04000EEB RID: 3819
		public const string MOBILE = "MOBILE";

		// Token: 0x04000EEC RID: 3820
		public const string UHFB1 = "UHFB1";

		// Token: 0x04000EED RID: 3821
		public const string UHFB2 = "UHFB2";

		// Token: 0x04000EEE RID: 3822
		public const string UHFDASHB1 = "UHF-B1";

		// Token: 0x04000EEF RID: 3823
		public const string UHFDASHB2 = "UHF-B2";

		// Token: 0x04000EF0 RID: 3824
		public const string UHFB2_TICC = "UHFB2_TICC";

		// Token: 0x04000EF1 RID: 3825
		public const string STR800900 = "8/900";

		// Token: 0x04000EF2 RID: 3826
		public const short nUHF = 0;

		// Token: 0x04000EF3 RID: 3827
		public const short nVHF = 1;

		// Token: 0x04000EF4 RID: 3828
		public const short nUHFB2 = 2;

		// Token: 0x04000EF5 RID: 3829
		public const short nUHFB2_TICC = 3;

		// Token: 0x04000EF6 RID: 3830
		public const short nP800_900 = 4;

		// Token: 0x04000EF7 RID: 3831
		public const short nP350 = 5;

		// Token: 0x04000EF8 RID: 3832
		public const short nP300 = 6;

		// Token: 0x04000EF9 RID: 3833
		public const short nNA_FREQ = 254;

		// Token: 0x04000EFA RID: 3834
		public const short nINVALID_FREQ = 255;

		// Token: 0x04000EFB RID: 3835
		public const string ZONESEL = "ZONESEL";

		// Token: 0x04000EFC RID: 3836
		public const string CHANNELSEL = "CHANNELSEL";

		// Token: 0x04000EFD RID: 3837
		public const string DISABLE = "DISABLE";

		// Token: 0x04000EFE RID: 3838
		public const string ALERTONLY = "ALERTONLY";

		// Token: 0x04000EFF RID: 3839
		public const string DISPLAYONLY = "DISPLAYONLY";

		// Token: 0x04000F00 RID: 3840
		public const string ALRTDISPLAY = "ALRTDISPLAY";

		// Token: 0x04000F01 RID: 3841
		public const string SILENT = "SILENT";

		// Token: 0x04000F02 RID: 3842
		public const string SILENTWTHVCE = "SILENTWTHVCE";

		// Token: 0x04000F03 RID: 3843
		public const string RING = "RING";

		// Token: 0x04000F04 RID: 3844
		public const string OFF = "OFF";

		// Token: 0x04000F05 RID: 3845
		public const string ON = "ON";

		// Token: 0x04000F06 RID: 3846
		public const string STR_0DB = "STR_0DB";

		// Token: 0x04000F07 RID: 3847
		public const string STR_3DB = "STR_3DB";

		// Token: 0x04000F08 RID: 3848
		public const string STR_6DB = "STR_6DB";

		// Token: 0x04000F09 RID: 3849
		public const string STR_9DB = "STR_9DB";

		// Token: 0x04000F0A RID: 3850
		public const string STR_12DB = "STR_12DB";

		// Token: 0x04000F0B RID: 3851
		public const string STR_NEG12DB = "STR_NEG12DB";

		// Token: 0x04000F0C RID: 3852
		public const string STR_NEG9DB = "STR_NEG9DB";

		// Token: 0x04000F0D RID: 3853
		public const string STR_NEG6DB = "STR_NEG6DB";

		// Token: 0x04000F0E RID: 3854
		public const string STR_NEG3DB = "STR_NEG3DB";

		// Token: 0x04000F0F RID: 3855
		public const string ENGLISH = "ENGLISH";

		// Token: 0x04000F10 RID: 3856
		public const string FRENCH = "FRENCH";

		// Token: 0x04000F11 RID: 3857
		public const string PORTUGUESE = "PORTUGUESE";

		// Token: 0x04000F12 RID: 3858
		public const string SPANISH = "SPANISH";

		// Token: 0x04000F13 RID: 3859
		public const string CHINESE = "CHINESE";

		// Token: 0x04000F14 RID: 3860
		public const string MEDIUM = "MEDIUM";

		// Token: 0x04000F15 RID: 3861
		public const string HIGH = "HIGH";

		// Token: 0x04000F16 RID: 3862
		public const string OPENSQUELCH = "OPENSQUELCH";

		// Token: 0x04000F17 RID: 3863
		public const string NONSTNDRD = "NONSTNDRD";

		// Token: 0x04000F18 RID: 3864
		public const string STANDARD = "STANDARD";

		// Token: 0x04000F19 RID: 3865
		public const string AND = "AND";

		// Token: 0x04000F1A RID: 3866
		public const string OR = "OR";

		// Token: 0x04000F1B RID: 3867
		public const string WRONGPL = "WRONGPL";

		// Token: 0x04000F1C RID: 3868
		public const string BSYCARRIER = "BSYCARRIER";

		// Token: 0x04000F1D RID: 3869
		public const string MTCHCLRCD = "MTCHCLRCD";

		// Token: 0x04000F1E RID: 3870
		public const string PASTTPLDPLLOCKOUT = "PASTTPLDPLLOCKOUT";

		// Token: 0x04000F1F RID: 3871
		public const string CARRIERGONETIMEREXPIRED = "CARRIERGONETIMEREXPIRED";

		// Token: 0x04000F20 RID: 3872
		public const string TPLDPLNOTDETECTED = "TPLDPLNOTDETECTED";

		// Token: 0x04000F21 RID: 3873
		public const string NOTPLDPLORPASTTPLDPL = "NOTPLDPLORPASTTPLDPL";

		// Token: 0x04000F22 RID: 3874
		public const string CHNLFREEORNOTPLDPLBUTPASTTPLDPL = "CHNLFREEORNOTPLDPLBUTPASTTPLDPL";

		// Token: 0x04000F23 RID: 3875
		public const string TONE = "TONE";

		// Token: 0x04000F24 RID: 3876
		public const string PL = "PL";

		// Token: 0x04000F25 RID: 3877
		public const string PLTONE = "PLTONE";

		// Token: 0x04000F26 RID: 3878
		public const string CP_SQUELCHMODE = "CP_SQUELCHMODE";

		// Token: 0x04000F27 RID: 3879
		public const string STDUNMUTESTDMUTE = "STDUNMUTESTDMUTE";

		// Token: 0x04000F28 RID: 3880
		public const string ANDUNMUTESTDMUTE = "ANDUNMUTESTDMUTE";

		// Token: 0x04000F29 RID: 3881
		public const string ANDUNMUTEORMUTE = "ANDUNMUTEORMUTE";

		// Token: 0x04000F2A RID: 3882
		public const string ANLGCONV = "ANLGCONV";

		// Token: 0x04000F2B RID: 3883
		public const string SELECT5 = "SELECT5";

		// Token: 0x04000F2C RID: 3884
		public const string DGTLCONV6PT25 = "DGTLCONV6PT25";

		// Token: 0x04000F2D RID: 3885
		public const string DGTLCONV12PT5 = "DGTLCONV12PT5";

		// Token: 0x04000F2E RID: 3886
		public const string STR_4PT2MHZ = "STR_4PT2MHZ";

		// Token: 0x04000F2F RID: 3887
		public const string STR_8PT4MHZ = "STR_8PT4MHZ";

		// Token: 0x04000F30 RID: 3888
		public const string STR_2PT1MHZ = "STR_2PT1MHZ";

		// Token: 0x04000F31 RID: 3889
		public const string STR_5PT6MHZ = "STR_5PT6MHZ";

		// Token: 0x04000F32 RID: 3890
		public const string STR_3PT36MHZ = "STR_3PT36MHZ";

		// Token: 0x04000F33 RID: 3891
		public const string SLOT1 = "SLOT1";

		// Token: 0x04000F34 RID: 3892
		public const string SLOT2 = "SLOT2";

		// Token: 0x04000F35 RID: 3893
		public const string OACSU = "OACSU";

		// Token: 0x04000F36 RID: 3894
		public const string FOACSU = "FOACSU";

		// Token: 0x04000F37 RID: 3895
		public const string DEEMPHSIS = "DEEMPHSIS";

		// Token: 0x04000F38 RID: 3896
		public const string PREEMPHSIS = "PREEMPHSIS";

		// Token: 0x04000F39 RID: 3897
		public const string DEEMPHPREEMPH = "DEEMPHPREEMPH";

		// Token: 0x04000F3A RID: 3898
		public const string STR_0MS = "STR_0MS";

		// Token: 0x04000F3B RID: 3899
		public const string STR_100MS = "STR_100MS";

		// Token: 0x04000F3C RID: 3900
		public const string STR_200MS = "STR_200MS";

		// Token: 0x04000F3D RID: 3901
		public const string STR_300MS = "STR_300MS";

		// Token: 0x04000F3E RID: 3902
		public const string STR_400MS = "STR_400MS";

		// Token: 0x04000F3F RID: 3903
		public const string STR_500MS = "STR_500MS";

		// Token: 0x04000F40 RID: 3904
		public const string STR_1000MS = "STR_1000MS";

		// Token: 0x04000F41 RID: 3905
		public const string STR_2150MS = "STR_2150MS";

		// Token: 0x04000F42 RID: 3906
		public const string STR_60 = "STR_60";

		// Token: 0x04000F43 RID: 3907
		public const string STR_90 = "STR_90";

		// Token: 0x04000F44 RID: 3908
		public const string STR_300 = "STR_300";

		// Token: 0x04000F45 RID: 3909
		public const string STR_500 = "STR_500";

		// Token: 0x04000F46 RID: 3910
		public const string STR_750 = "STR_750";

		// Token: 0x04000F47 RID: 3911
		public const string STR_1500 = "STR_1500";

		// Token: 0x04000F48 RID: 3912
		public const string NORMAL = "NORMAL";

		// Token: 0x04000F49 RID: 3913
		public const string TIGHT = "TIGHT";

		// Token: 0x04000F4A RID: 3914
		public const string SPECIFIC = "SPECIFIC";

		// Token: 0x04000F4B RID: 3915
		public const string DOMESTIC = "DOMESTIC";

		// Token: 0x04000F4C RID: 3916
		public const string INTRNTIONL = "INTRNTIONL";

		// Token: 0x04000F4D RID: 3917
		public const string LOWPWR = "LOWPWR";

		// Token: 0x04000F4E RID: 3918
		public const string HIGHPWR = "HIGHPWR";

		// Token: 0x04000F4F RID: 3919
		public const string SYNCHRNOUS = "SYNCHRNOUS";

		// Token: 0x04000F50 RID: 3920
		public const string ASYNCHRNOUS = "ASYNCHRNOUS";

		// Token: 0x04000F51 RID: 3921
		public const string ENHANCED = "ENHANCED";

		// Token: 0x04000F52 RID: 3922
		public const string NOSQCHNORMSQCH = "NOSQCHNORMSQCH";

		// Token: 0x04000F53 RID: 3923
		public const string DATAORSQCHORSELSQCH = "DATAORSQCHORSELSQCH";

		// Token: 0x04000F54 RID: 3924
		public const string DATAANDSQUELCH = "DATAANDSQUELCH";

		// Token: 0x04000F55 RID: 3925
		public const string DGTLCARRSQCH = "DGTLCARRSQCH";

		// Token: 0x04000F56 RID: 3926
		public const string NONLTD = "NONLTD";

		// Token: 0x04000F57 RID: 3927
		public const string LTD = "LTD";

		// Token: 0x04000F58 RID: 3928
		public const string STR_12PT5KHZ = "STR_12PT5KHZ";

		// Token: 0x04000F59 RID: 3929
		public const string STR_20KHZ = "STR_20KHZ";

		// Token: 0x04000F5A RID: 3930
		public const string STR_25KHZ = "STR_25KHZ";

		// Token: 0x04000F5B RID: 3931
		public const string STR_30KHZ = "STR_30KHZ";

		// Token: 0x04000F5C RID: 3932
		public const string STR_12PT5_15_KHZ = "STR_12PT5_15_KHZ";

		// Token: 0x04000F5D RID: 3933
		public const string STR_25_30_KHZ = "STR_25_30_KHZ";

		// Token: 0x04000F5E RID: 3934
		public const string ID4 = "ID4";

		// Token: 0x04000F5F RID: 3935
		public const string ID5 = "ID5";

		// Token: 0x04000F60 RID: 3936
		public const string ID2PT5 = "ID2PT5";

		// Token: 0x04000F61 RID: 3937
		public const string CSQ = "CSQ";

		// Token: 0x04000F62 RID: 3938
		public const string TPL = "TPL";

		// Token: 0x04000F63 RID: 3939
		public const string DPL = "DPL";

		// Token: 0x04000F64 RID: 3940
		public const string STR_XZ = "STR_XZ";

		// Token: 0x04000F65 RID: 3941
		public const string STR_WZ = "STR_WZ";

		// Token: 0x04000F66 RID: 3942
		public const string STR_XA = "STR_XA";

		// Token: 0x04000F67 RID: 3943
		public const string STR_WA = "STR_WA";

		// Token: 0x04000F68 RID: 3944
		public const string STR_XB = "STR_XB";

		// Token: 0x04000F69 RID: 3945
		public const string STR_WB = "STR_WB";

		// Token: 0x04000F6A RID: 3946
		public const string STR_YZ = "STR_YZ";

		// Token: 0x04000F6B RID: 3947
		public const string STR_YA = "STR_YA";

		// Token: 0x04000F6C RID: 3948
		public const string STR_YB = "STR_YB";

		// Token: 0x04000F6D RID: 3949
		public const string STR_ZZ = "STR_ZZ";

		// Token: 0x04000F6E RID: 3950
		public const string STR_ZA = "STR_ZA";

		// Token: 0x04000F6F RID: 3951
		public const string STR_ZB = "STR_ZB";

		// Token: 0x04000F70 RID: 3952
		public const string STR_1Z = "STR_1Z";

		// Token: 0x04000F71 RID: 3953
		public const string STR_1A = "STR_1A";

		// Token: 0x04000F72 RID: 3954
		public const string STR_1B = "STR_1B";

		// Token: 0x04000F73 RID: 3955
		public const string STR_2Z = "STR_2Z";

		// Token: 0x04000F74 RID: 3956
		public const string STR_2A = "STR_2A";

		// Token: 0x04000F75 RID: 3957
		public const string STR_2B = "STR_2B";

		// Token: 0x04000F76 RID: 3958
		public const string STR_3Z = "STR_3Z";

		// Token: 0x04000F77 RID: 3959
		public const string STR_3A = "STR_3A";

		// Token: 0x04000F78 RID: 3960
		public const string STR_3B = "STR_3B";

		// Token: 0x04000F79 RID: 3961
		public const string STR_4Z = "STR_4Z";

		// Token: 0x04000F7A RID: 3962
		public const string STR_4A = "STR_4A";

		// Token: 0x04000F7B RID: 3963
		public const string STR_4B = "STR_4B";

		// Token: 0x04000F7C RID: 3964
		public const string STR_5Z = "STR_5Z";

		// Token: 0x04000F7D RID: 3965
		public const string STR_5A = "STR_5A";

		// Token: 0x04000F7E RID: 3966
		public const string STR_5B = "STR_5B";

		// Token: 0x04000F7F RID: 3967
		public const string STR_6Z = "STR_6Z";

		// Token: 0x04000F80 RID: 3968
		public const string STR_6A = "STR_6A";

		// Token: 0x04000F81 RID: 3969
		public const string STR_6B = "STR_6B";

		// Token: 0x04000F82 RID: 3970
		public const string STR_7Z = "STR_7Z";

		// Token: 0x04000F83 RID: 3971
		public const string STR_7A = "STR_7A";

		// Token: 0x04000F84 RID: 3972
		public const string STR_M1 = "STR_M1";

		// Token: 0x04000F85 RID: 3973
		public const string STR_8Z = "STR_8Z";

		// Token: 0x04000F86 RID: 3974
		public const string STR_M2 = "STR_M2";

		// Token: 0x04000F87 RID: 3975
		public const string STR_M3 = "STR_M3";

		// Token: 0x04000F88 RID: 3976
		public const string STR_M4 = "STR_M4";

		// Token: 0x04000F89 RID: 3977
		public const string STR_9Z = "STR_9Z";

		// Token: 0x04000F8A RID: 3978
		public const string STR_M5 = "STR_M5";

		// Token: 0x04000F8B RID: 3979
		public const string STR_M6 = "STR_M6";

		// Token: 0x04000F8C RID: 3980
		public const string STR_M7 = "STR_M7";

		// Token: 0x04000F8D RID: 3981
		public const string STR_0Z = "STR_0Z";

		// Token: 0x04000F8E RID: 3982
		public const string ONBUSYCARRIER = "ONBUSYCARRIER";

		// Token: 0x04000F8F RID: 3983
		public const string ONMATCHINGCOLORCODE = "ONMATCHINGCOLORCODE";

		// Token: 0x04000F90 RID: 3984
		public const string STR_ONE = "STR_ONE";

		// Token: 0x04000F91 RID: 3985
		public const string STR_TWO = "STR_TWO";

		// Token: 0x04000F92 RID: 3986
		public const string STR_DISABLED = "STR_DISABLED";

		// Token: 0x04000F93 RID: 3987
		public const string STR_NONE = "STR_NONE";

		// Token: 0x04000F94 RID: 3988
		public const string SUSPALLSCAN = "SUSPALLSCAN";

		// Token: 0x04000F95 RID: 3989
		public const string SUSPNONPRIORSCAN = "SUSPNONPRIORSCAN";

		// Token: 0x04000F96 RID: 3990
		public const string DGTLCONV = "DGTLCONV";

		// Token: 0x04000F97 RID: 3991
		public const string NONPRIORCHAN = "NONPRIORCHAN";

		// Token: 0x04000F98 RID: 3992
		public const string PRIORCHAN = "PRIORCHAN";

		// Token: 0x04000F99 RID: 3993
		public const string PRIORNONPRIORCHAN = "PRIORNONPRIORCHAN";

		// Token: 0x04000F9A RID: 3994
		public const string SELECTED = "SELECTED";

		// Token: 0x04000F9B RID: 3995
		public const string MDCPRIVCALL = "MDCPRIVCALL";

		// Token: 0x04000F9C RID: 3996
		public const string MDCGPCALL = "MDCGPCALL";

		// Token: 0x04000F9D RID: 3997
		public const string ANLGALLSYSCALL = "ANLGALLSYSCALL";

		// Token: 0x04000F9E RID: 3998
		public const string GRPCALL = "GRPCALL";

		// Token: 0x04000F9F RID: 3999
		public const string PRIVCALL = "PRIVCALL";

		// Token: 0x04000FA0 RID: 4000
		public const string SITECALL = "SITECALL";

		// Token: 0x04000FA1 RID: 4001
		public const string MULTISITECALL = "MULTISITECALL";

		// Token: 0x04000FA2 RID: 4002
		public const string PHONE = "PHONE";

		// Token: 0x04000FA3 RID: 4003
		public const string MESSAGE = "MESSAGE";

		// Token: 0x04000FA4 RID: 4004
		public const string MESSAGE_TRUNKING = "MESSAGE_TRUNKING";

		// Token: 0x04000FA5 RID: 4005
		public const string STATUS = "STATUS";

		// Token: 0x04000FA6 RID: 4006
		public const string DGTLALLSYSCALL = "DGTLALLSYSCALL";

		// Token: 0x04000FA7 RID: 4007
		public const string DISPATCHER = "DISPATCHER";

		// Token: 0x04000FA8 RID: 4008
		public const string PC = "PC";

		// Token: 0x04000FA9 RID: 4009
		public const string STR_15 = "15";

		// Token: 0x04000FAA RID: 4010
		public const string STR_20 = "20";

		// Token: 0x04000FAB RID: 4011
		public const string STR_9 = "9";

		// Token: 0x04000FAC RID: 4012
		public const string CAPPLUSDISPATCHER = "CAPPLUSDISPATCHER";

		// Token: 0x04000FAD RID: 4013
		public const string CAPPLUSPC = "CAPPLUSPC";

		// Token: 0x04000FAE RID: 4014
		public const string CAPPLUSPCBT = "CAPPLUSPCBT";

		// Token: 0x04000FAF RID: 4015
		public const string GENERAL = "GENERAL";

		// Token: 0x04000FB0 RID: 4016
		public const string INCOMINGEMERGENCY = "INCOMINGEMERGENCY";

		// Token: 0x04000FB1 RID: 4017
		public const string PRIORITY = "PRIORITY";

		// Token: 0x04000FB2 RID: 4018
		public const string EMERGENCYEXIT = "EMERGENCYEXIT";

		// Token: 0x04000FB3 RID: 4019
		public const string STUN = "STUN";

		// Token: 0x04000FB4 RID: 4020
		public const string UNSTUN = "UNSTUN";

		// Token: 0x04000FB5 RID: 4021
		public const string CLEARDOWN = "CLEARDOWN";

		// Token: 0x04000FB6 RID: 4022
		public const string SILENTINTERROGATE = "SILENTINTERROGATE";

		// Token: 0x04000FB7 RID: 4023
		public const string ACK1RINGING = "ACK1RINGING";

		// Token: 0x04000FB8 RID: 4024
		public const string ACK1AUTHORISATION = "ACK1AUTHORISATION";

		// Token: 0x04000FB9 RID: 4025
		public const string ACK1 = "Ack1";

		// Token: 0x04000FBA RID: 4026
		public const string CS_CSTY = "CS_CSTY";

		// Token: 0x04000FBB RID: 4027
		public const string CS_MDCPRIID = "CS_MDCPRIID";

		// Token: 0x04000FBC RID: 4028
		public const string CS_PTTIDTYPE = "CS_PTTIDTYPE";

		// Token: 0x04000FBD RID: 4029
		public const string CS_PTTSTTYPE = "CS_PTTSTTYPE";

		// Token: 0x04000FBE RID: 4030
		public const string CS_SYSGRPNUM = "CS_SYSGRPNUM";

		// Token: 0x04000FBF RID: 4031
		public const string CS_SYSPREMDC = "CS_SYSPREMDC";

		// Token: 0x04000FC0 RID: 4032
		public const string CS_MDCNUMPRESYS = "CS_MDCNUMPRESYS";

		// Token: 0x04000FC1 RID: 4033
		public const string CS_MDCDOSEN = "CS_MDCDOSEN";

		// Token: 0x04000FC2 RID: 4034
		public const string CS_MDCDIS1200DOS = "CS_MDCDIS1200DOS";

		// Token: 0x04000FC3 RID: 4035
		public const string CS_MDCDOSCSTTM = "CS_MDCDOSCSTTM";

		// Token: 0x04000FC4 RID: 4036
		public const string CP_RXUNMINHDELAYSEL = "CP_RXUNMINHDELAYSEL";

		// Token: 0x04000FC5 RID: 4037
		public const string PHONESYS = "PHONESYS";

		// Token: 0x04000FC6 RID: 4038
		public const string MDCSYS = "MDCSYS";

		// Token: 0x04000FC7 RID: 4039
		public const string LONGANDSHORT = "LONGANDSHORT";

		// Token: 0x04000FC8 RID: 4040
		public const string STR_1800HZ = "STR_1800HZ";

		// Token: 0x04000FC9 RID: 4041
		public const string INT_500 = "500";

		// Token: 0x04000FCA RID: 4042
		public const string INT_275 = "275";

		// Token: 0x04000FCB RID: 4043
		public const string STR_0001 = "0001";

		// Token: 0x04000FCC RID: 4044
		public const string CNV_SYS_CMP_TYPE_PHOENIX = "CNV_SYS_CMP_TYPE_PHOENIX";

		// Token: 0x04000FCD RID: 4045
		public const string CP_ALGSIGTY = "CP_ALGSIGTY";

		// Token: 0x04000FCE RID: 4046
		public const string CP_PTTID = "CP_PTTID";

		// Token: 0x04000FCF RID: 4047
		public const string CP_RMDCDEM = "CP_RMDCDEM";

		// Token: 0x04000FD0 RID: 4048
		public const string IPOL = "IPOL";

		// Token: 0x04000FD1 RID: 4049
		public const string FD_MDCPTTID = "FD_MDCPTTID";

		// Token: 0x04000FD2 RID: 4050
		public const string RINGER1 = "RINGER1";

		// Token: 0x04000FD3 RID: 4051
		public const string RINGER2 = "RINGER2";

		// Token: 0x04000FD4 RID: 4052
		public const string RINGER3 = "RINGER3";

		// Token: 0x04000FD5 RID: 4053
		public const string RINGER4 = "RINGER4";

		// Token: 0x04000FD6 RID: 4054
		public const string RINGER5 = "RINGER5";

		// Token: 0x04000FD7 RID: 4055
		public const string RINGER6 = "RINGER6";

		// Token: 0x04000FD8 RID: 4056
		public const string RINGER7 = "RINGER7";

		// Token: 0x04000FD9 RID: 4057
		public const string RINGER8 = "RINGER8";

		// Token: 0x04000FDA RID: 4058
		public const string RINGER9 = "RINGER9";

		// Token: 0x04000FDB RID: 4059
		public const string RINGER10 = "RINGER10";

		// Token: 0x04000FDC RID: 4060
		public const string NOSTYLE = "NOSTYLE";

		// Token: 0x04000FDD RID: 4061
		public const string CALLALERT = "CALLALERT ";

		// Token: 0x04000FDE RID: 4062
		public const string TGLBCKLGHTONOFF = "TGLBCKLGHTONOFF";

		// Token: 0x04000FDF RID: 4063
		public const string TGLMNTRONOFF = "TGLMNTRONOFF";

		// Token: 0x04000FE0 RID: 4064
		public const string TGLRPTRTLKARD = "TGLRPTRTLKARD";

		// Token: 0x04000FE1 RID: 4065
		public const string TGLSCANONOFF = "TGLSCANONOFF";

		// Token: 0x04000FE2 RID: 4066
		public const string TGLHILOWPWR = "TGLHILOWPWR";

		// Token: 0x04000FE3 RID: 4067
		public const string TGLAUXCTLTGL = "TGLAUXCTLTGL";

		// Token: 0x04000FE4 RID: 4068
		public const string HRNLGTTGL = "HRNLGTTGL";

		// Token: 0x04000FE5 RID: 4069
		public const string UNASSIGNED = "UNASSIGNED";

		// Token: 0x04000FE6 RID: 4070
		public const string EMERGENCYON = "EMERGENCYON";

		// Token: 0x04000FE7 RID: 4071
		public const string TGLTGHTNORMSQLCH = "TGLTGHTNORMSQLCH";

		// Token: 0x04000FE8 RID: 4072
		public const string TGLOPTNBDONOFF = "TGLOPTNBDONOFF";

		// Token: 0x04000FE9 RID: 4073
		public const string QUCKTEXT = "QUCKTEXT";

		// Token: 0x04000FEA RID: 4074
		public const string REMTEMNTR = "REMTEMNTR";

		// Token: 0x04000FEB RID: 4075
		public const string RADIOCHCK = "RADIOCHCK";

		// Token: 0x04000FEC RID: 4076
		public const string RADIOENABLE = "RADIOENABLE";

		// Token: 0x04000FED RID: 4077
		public const string RADIODISABLED = "RADIODISABLED";

		// Token: 0x04000FEE RID: 4078
		public const string UCL = "UCL";

		// Token: 0x04000FEF RID: 4079
		public const string ZONESCROLL = "ZONESCROLL";

		// Token: 0x04000FF0 RID: 4080
		public const string MANUALDIALGRP = "MANUALDIALGRP";

		// Token: 0x04000FF1 RID: 4081
		public const string MANUALDIALPRVTE = "MANUALDIALPRVTE";

		// Token: 0x04000FF2 RID: 4082
		public const string AUTOVOLCNTRLTGL = "AUTOVOLCNTRLTGL";

		// Token: 0x04000FF3 RID: 4083
		public const string ONETCHCALL1 = "ONETCHCALL1";

		// Token: 0x04000FF4 RID: 4084
		public const string ONETCHCALL2 = "ONETCHCALL2";

		// Token: 0x04000FF5 RID: 4085
		public const string ONETCHCALL3 = "ONETCHCALL3";

		// Token: 0x04000FF6 RID: 4086
		public const string ONETCHCALL4 = "ONETCHCALL4";

		// Token: 0x04000FF7 RID: 4087
		public const string ONETCHCALL5 = "ONETCHCALL5";

		// Token: 0x04000FF8 RID: 4088
		public const string ONETCHCALL6 = "ONETCHCALL6";

		// Token: 0x04000FF9 RID: 4089
		public const string NUISANCEDEL = "NUISANCEDEL";

		// Token: 0x04000FFA RID: 4090
		public const string KYPDLOCK = "KYPDLOCK";

		// Token: 0x04000FFB RID: 4091
		public const string EMERGENCYOFF = "EMERGENCYOFF";

		// Token: 0x04000FFC RID: 4092
		public const string PERMMNTR = "PERMMNTR";

		// Token: 0x04000FFD RID: 4093
		public const string VLMEUP = "VLMEUP";

		// Token: 0x04000FFE RID: 4094
		public const string VLMEDOWN = "VLMEDOWN";

		// Token: 0x04000FFF RID: 4095
		public const string TGLVLMENRMLLOW = "TGLVLMENRMLLOW";

		// Token: 0x04001000 RID: 4096
		public const string TGLTLMENORMLHI = "TGLTLMENORMLHI";

		// Token: 0x04001001 RID: 4097
		public const string CHANNELUP = "CHANNELUP";

		// Token: 0x04001002 RID: 4098
		public const string CHANNELDOWN = "CHANNELDOWN";

		// Token: 0x04001003 RID: 4099
		public const string GPSONOFF = "GPSONOFF";

		// Token: 0x04001004 RID: 4100
		public const string BLUTTHCNN = "BLUTTHCNN";

		// Token: 0x04001005 RID: 4101
		public const string BLUTTHDCNN = "BLUTTHDCNN";

		// Token: 0x04001006 RID: 4102
		public const string BLUTTHHEADAUDSWCH = "BLUTTHHEADAUDSWCH";

		// Token: 0x04001007 RID: 4103
		public const string BLUTTHDISCTOG = "BLUTTHDISCTOG";

		// Token: 0x04001008 RID: 4104
		public const string VLMEUPRAMP = "VLMEUPRAMP";

		// Token: 0x04001009 RID: 4105
		public const string VLMEDWNRAMP = "VLMEDWNRAMP";

		// Token: 0x0400100A RID: 4106
		public const string TGAPAVCECALL = "TGAPAVCECALL";

		// Token: 0x0400100B RID: 4107
		public const string TGLINTRNLPAONOFF = "TGLINTRNLPAONOFF";

		// Token: 0x0400100C RID: 4108
		public const string TGLEXTNLPAONONFF = "TGLEXTNLPAONONFF";

		// Token: 0x0400100D RID: 4109
		public const string TGLPAVCEANN = "TGLPAVCEANN";

		// Token: 0x0400100E RID: 4110
		public const string POSPERSPOSUP = "POSPERSPOSUP";

		// Token: 0x0400100F RID: 4111
		public const string POSPERSPOSDOWN = "POSPERSPOSDOWN";

		// Token: 0x04001010 RID: 4112
		public const string TXBOARD = "TXBOARD";

		// Token: 0x04001011 RID: 4113
		public const string RXBOARD = "RXBOARD";

		// Token: 0x04001012 RID: 4114
		public const string LASTFREECH = "LASTFREECH";

		// Token: 0x04001013 RID: 4115
		public const string LASTACTIVECH = "LASTACTIVECH";

		// Token: 0x04001014 RID: 4116
		public const string LASTVOTEDCHANNEL = "LASTVOTEDCHANNEL";

		// Token: 0x04001015 RID: 4117
		public const string LASTSELECTEDCHANNEL = "LASTSELECTEDCHANNEL";

		// Token: 0x04001016 RID: 4118
		public const string EXTMICPTT = "EXTMICPTT";

		// Token: 0x04001017 RID: 4119
		public const string ACPWRFAILURE = "ACPWRFAILURE";

		// Token: 0x04001018 RID: 4120
		public const string DATAPTT = "DATAPTT";

		// Token: 0x04001019 RID: 4121
		public const string DSBLEIGNOFF = "DSBLEIGNOFF";

		// Token: 0x0400101A RID: 4122
		public const string SLT5DECOPCTRL = "SLT5DECOPCTRL";

		// Token: 0x0400101B RID: 4123
		public const string CALL1 = "CALL1";

		// Token: 0x0400101C RID: 4124
		public const string CALL2 = "CALL2";

		// Token: 0x0400101D RID: 4125
		public const string CALL3 = "CALL3";

		// Token: 0x0400101E RID: 4126
		public const string CALL4 = "CALL4";

		// Token: 0x0400101F RID: 4127
		public const string CALL5 = "CALL5";

		// Token: 0x04001020 RID: 4128
		public const string CALL6 = "CALL6";

		// Token: 0x04001021 RID: 4129
		public const string SELCALL1 = "SELCALL1";

		// Token: 0x04001022 RID: 4130
		public const string SELCALL2 = "SELCALL2";

		// Token: 0x04001023 RID: 4131
		public const string SELCALL3 = "SELCALL3";

		// Token: 0x04001024 RID: 4132
		public const string SELCALL4 = "SELCALL4";

		// Token: 0x04001025 RID: 4133
		public const string SELCALL5 = "SELCALL5";

		// Token: 0x04001026 RID: 4134
		public const string SELCALL6 = "SELCALL6";

		// Token: 0x04001027 RID: 4135
		public const string TXPLINHBT = "TXPLINHBT";

		// Token: 0x04001028 RID: 4136
		public const string TOCREVBRSTDSBLE = "TOCREVBRSTDSBLE";

		// Token: 0x04001029 RID: 4137
		public const string TXAUDIOMUTE = "TXAUDIOMUTE";

		// Token: 0x0400102A RID: 4138
		public const string RXAUDIOMUTE = "RXAUDIOMUTE";

		// Token: 0x0400102B RID: 4139
		public const string EXTMICOFFHOOK = "EXTMICOFFHOOK";

		// Token: 0x0400102C RID: 4140
		public const string MONITOR = "MONITOR";

		// Token: 0x0400102D RID: 4141
		public const string CHANNELSEL1 = "CHANNELSEL1";

		// Token: 0x0400102E RID: 4142
		public const string CHANNELSEL2 = "CHANNELSEL2";

		// Token: 0x0400102F RID: 4143
		public const string CHANNELSEL3 = "CHANNELSEL3";

		// Token: 0x04001030 RID: 4144
		public const string CHANNELSEL4 = "CHANNELSEL4";

		// Token: 0x04001031 RID: 4145
		public const string CHANNELSEL5 = "CHANNELSEL5";

		// Token: 0x04001032 RID: 4146
		public const string CHANNELSEL6 = "CHANNELSEL6";

		// Token: 0x04001033 RID: 4147
		public const string REQSTSEND = "REQSTSEND";

		// Token: 0x04001034 RID: 4148
		public const string EXTRNALCALLBTN1 = "EXTRNALCALLBTN1";

		// Token: 0x04001035 RID: 4149
		public const string EXTRNALCALLBTN2 = "EXTRNALCALLBTN2";

		// Token: 0x04001036 RID: 4150
		public const string EMRGNCYINPUT = "EMRGNCYINPUT";

		// Token: 0x04001037 RID: 4151
		public const string PASWITCH = "PASWITCH";

		// Token: 0x04001038 RID: 4152
		public const string DATAREVERT = "DATAREVERT";

		// Token: 0x04001039 RID: 4153
		public const string EXTEMRGSWTCH = "EXTEMRGSWTCH";

		// Token: 0x0400103A RID: 4154
		public const string IGNTIONSENSE = "IGNTIONSENSE";

		// Token: 0x0400103B RID: 4155
		public const string EXTALRMHRNLGTS = "EXTALRMHRNLGTS";

		// Token: 0x0400103C RID: 4156
		public const string VIPOPENCLLCTR = "VIPOPENCLLCTR";

		// Token: 0x0400103D RID: 4157
		public const string TLMTRYVIO1 = "TLMTRYVIO1";

		// Token: 0x0400103E RID: 4158
		public const string TLMTRYVIO2 = "TLMTRYVIO2";

		// Token: 0x0400103F RID: 4159
		public const string TLMTRYVIO3 = "TLMTRYVIO3";

		// Token: 0x04001040 RID: 4160
		public const string TLMTRYVIO4 = "TLMTRYVIO4";

		// Token: 0x04001041 RID: 4161
		public const string TLMTRYVIO5 = "TLMTRYVIO5";

		// Token: 0x04001042 RID: 4162
		public const string GENERICINPUT1 = "GENERICINPUT1";

		// Token: 0x04001043 RID: 4163
		public const string GENERICINPUT2 = "GENERICINPUT2";

		// Token: 0x04001044 RID: 4164
		public const string GENERICINPUT3 = "GENERICINPUT3";

		// Token: 0x04001045 RID: 4165
		public const string GENERICINPUT4 = "GENERICINPUT4";

		// Token: 0x04001046 RID: 4166
		public const string GENERICINPUT5 = "GENERICINPUT5";

		// Token: 0x04001047 RID: 4167
		public const string GENERICINPUT6 = "GENERICINPUT6";

		// Token: 0x04001048 RID: 4168
		public const string GENERICOUTPUT1 = "GENERICOUTPUT1";

		// Token: 0x04001049 RID: 4169
		public const string GENERICOUTPUT2 = "GENERICOUTPUT2";

		// Token: 0x0400104A RID: 4170
		public const string GENERICOUTPUT3 = "GENERICOUTPUT3";

		// Token: 0x0400104B RID: 4171
		public const string GENERICOUTPUT4 = "GENERICOUTPUT4";

		// Token: 0x0400104C RID: 4172
		public const string GENERICOUTPUT5 = "GENERICOUTPUT5";

		// Token: 0x0400104D RID: 4173
		public const string GENERICOUTPUT6 = "GENERICOUTPUT6";

		// Token: 0x0400104E RID: 4174
		public const string WIRELINEMUTEOUTPUT = "WIRELINEMUTEOUTPUT";

		// Token: 0x0400104F RID: 4175
		public const string WIRELINEMUTEINPUT = "WIRELINEMUTEINPUT";

		// Token: 0x04001050 RID: 4176
		public const string WIRELINEEXTERNALPTT = "WIRELINEEXTERNALPTT";

		// Token: 0x04001051 RID: 4177
		public const string WIRELINEEXTERNALCOR = "WIRELINEEXTERNALCOR";

		// Token: 0x04001052 RID: 4178
		public const string RESPONSEINHIBIT = "RESPONSEINHIBIT";

		// Token: 0x04001053 RID: 4179
		public const string CSQDETECT = "CSQDETECT";

		// Token: 0x04001054 RID: 4180
		public const string PLTLKGRPDETECT = "PLTLKGRPDETECT";

		// Token: 0x04001055 RID: 4181
		public const string CLEARTOSEND = "CLEARTOSEND";

		// Token: 0x04001056 RID: 4182
		public const string CHNNLACTVTY = "CHNNLACTVTY";

		// Token: 0x04001057 RID: 4183
		public const string ANTENNARELAY = "ANTENNARELAY";

		// Token: 0x04001058 RID: 4184
		public const string AUXCNTRL1 = "AUXCNTRL1";

		// Token: 0x04001059 RID: 4185
		public const string AUXCNTRL2 = "AUXCNTRL2";

		// Token: 0x0400105A RID: 4186
		public const string INPUT = "INPUT";

		// Token: 0x0400105B RID: 4187
		public const string OUTPUT = "OUTPUT";

		// Token: 0x0400105C RID: 4188
		public const string FLLWIGNTNONLY = "FLLWIGNTNONLY";

		// Token: 0x0400105D RID: 4189
		public const string ONOFFIGNTN = "ONOFFIGNTN";

		// Token: 0x0400105E RID: 4190
		public const string PTTDISABLED = "PTTDISABLED";

		// Token: 0x0400105F RID: 4191
		public const string DEEMPHSZDAUDIO = "DEEMPHSZDAUDIO";

		// Token: 0x04001060 RID: 4192
		public const string FLATAUDIO = "FLATAUDIO";

		// Token: 0x04001061 RID: 4193
		public const string EXTMICAUDIO = "EXTMICAUDIO";

		// Token: 0x04001062 RID: 4194
		public const string FLATTXAUDIO = "FLATTXAUDIO";

		// Token: 0x04001063 RID: 4195
		public const string EXTMICFLATTX = "EXTMICFLATTX";

		// Token: 0x04001064 RID: 4196
		public const string ONLYWBRACTIVITY = "ONLYWBRACTIVITY";

		// Token: 0x04001065 RID: 4197
		public const string ALWAYS = "ALWAYS";

		// Token: 0x04001066 RID: 4198
		public const string FOLLOW_ADMIT_CRITERIA = "FOLLOW_ADMIT_CRITERIA";

		// Token: 0x04001067 RID: 4199
		public const string EIA = "EIA";

		// Token: 0x04001068 RID: 4200
		public const string FLAT = "FLAT";

		// Token: 0x04001069 RID: 4201
		public const string TGPRIVSRVCEONOFF = "TGPRIVSRVCEONOFF";

		// Token: 0x0400106A RID: 4202
		public const string FALSECHOICE = "FALSE";

		// Token: 0x0400106B RID: 4203
		public const string TRUECHOICE = "TRUE";

		// Token: 0x0400106C RID: 4204
		public const string FILTEREDSQUELCH = "FILTEREDSQUELCH";

		// Token: 0x0400106D RID: 4205
		public const string IPADDRESS0 = "0.0.0.0";

		// Token: 0x0400106E RID: 4206
		public const string TGOPTBOARD1 = "TGOPTBOARD1";

		// Token: 0x0400106F RID: 4207
		public const string TGOPTBOARD2 = "TGOPTBOARD2";

		// Token: 0x04001070 RID: 4208
		public const string TGOPTBOARD3 = "TGOPTBOARD3";

		// Token: 0x04001071 RID: 4209
		public const string TGOPTBOARD4 = "TGOPTBOARD4";

		// Token: 0x04001072 RID: 4210
		public const string TGOPTBOARD5 = "TGOPTBOARD5";

		// Token: 0x04001073 RID: 4211
		public const string TGOPTBOARD6 = "TGOPTBOARD6";

		// Token: 0x04001074 RID: 4212
		public const string TGPRVSERVONOFF = "TGPRVSERVONOFF";

		// Token: 0x04001075 RID: 4213
		public const string STATUSLST = "STATUSLST";

		// Token: 0x04001076 RID: 4214
		public const string PHNPATCH = "PHNPATCH";

		// Token: 0x04001077 RID: 4215
		public const string PUBLCADDRSWBOX = "PUBLCADDRSWBOX";

		// Token: 0x04001078 RID: 4216
		public const string PUBLCADDRRAD = "PUBLCADDRRAD";

		// Token: 0x04001079 RID: 4217
		public const string REMOTE = "REMOTE";

		// Token: 0x0400107A RID: 4218
		public const string PAGINGENCDR = "PAGINGENCDR";

		// Token: 0x0400107B RID: 4219
		public const string CHANNSTEERING = "CHANNSTEERING";

		// Token: 0x0400107C RID: 4220
		public const string CESDATATERMNL = "CESDATATERMNL";

		// Token: 0x0400107D RID: 4221
		public const string PERMEXTALRM = "PERMEXTALRM";

		// Token: 0x0400107E RID: 4222
		public const string ALRMREARM = "ALRMREARM";

		// Token: 0x0400107F RID: 4223
		public const string NONPERMMANREARM = "NONPERMMANREARM";

		// Token: 0x04001080 RID: 4224
		public const string DCCHANNLSTEER = "DCCHANNLSTEER";

		// Token: 0x04001081 RID: 4225
		public const string TONECHANNLSTEER = "TONECHANNLSTEER";

		// Token: 0x04001082 RID: 4226
		public const string ACCSSRYMIC = "ACCSSRYMIC";

		// Token: 0x04001083 RID: 4227
		public const string CNTRLHEAD = "CNTRLHEAD";

		// Token: 0x04001084 RID: 4228
		public const string INTRNLMIC = "INTRNLMIC";

		// Token: 0x04001085 RID: 4229
		public const string FRONTACCSSRYMIC = "FRONTACCSSRYMIC";

		// Token: 0x04001086 RID: 4230
		public const string REARACCSSRYMIC = "REARACCSSRYMIC";

		// Token: 0x04001087 RID: 4231
		public const string VIO = "VIO";

		// Token: 0x04001088 RID: 4232
		public const string VIO1 = "VIO1";

		// Token: 0x04001089 RID: 4233
		public const string VIO2 = "VIO2";

		// Token: 0x0400108A RID: 4234
		public const string VIO3 = "VIO3";

		// Token: 0x0400108B RID: 4235
		public const string VIO4 = "VIO4";

		// Token: 0x0400108C RID: 4236
		public const string VIO5 = "VIO5";

		// Token: 0x0400108D RID: 4237
		public const string NOCONFIG = "NOCONFIG";

		// Token: 0x0400108E RID: 4238
		public const string PINVOLTHIGH = "PINVOLTHIGH";

		// Token: 0x0400108F RID: 4239
		public const string PINVOLTLOW = "PINVOLTLOW";

		// Token: 0x04001090 RID: 4240
		public const string TGLVOLTLVL = "TGLVOLTLVL";

		// Token: 0x04001091 RID: 4241
		public const string PULSE = "PULSE";

		// Token: 0x04001092 RID: 4242
		public const string ANNCVIOSSTAT = "ANNCVIOSSTAT";

		// Token: 0x04001093 RID: 4243
		public const string ANNCSTATTXT = "ANNCSTATTXT";

		// Token: 0x04001094 RID: 4244
		public const string NOCPBLTY = "NOCPBLTY";

		// Token: 0x04001095 RID: 4245
		public const string CPBLESETPINVLT = "CPBLESETPINVLT";

		// Token: 0x04001096 RID: 4246
		public const string CPBLETGLPINVLT = "CPBLETGLPINVLT";

		// Token: 0x04001097 RID: 4247
		public const string CPBLEMAKEPULSE = "CPBLEMAKEPULSE";

		// Token: 0x04001098 RID: 4248
		public const string QUERYSTATUS = "QUERYSTATUS";

		// Token: 0x04001099 RID: 4249
		public const string BASICPRVCY = "BASICPRVCY";

		// Token: 0x0400109A RID: 4250
		public const string ENHPRVCY = "ENHPRVCY";

		// Token: 0x0400109B RID: 4251
		public const string FFFF = "FFFF";

		// Token: 0x0400109C RID: 4252
		public const string FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF = "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF";

		// Token: 0x0400109D RID: 4253
		public const string FFFFFFFFFF = "FFFFFFFFFF";

		// Token: 0x0400109E RID: 4254
		public const string VOXLEVEL2 = "VOXLEVEL2";

		// Token: 0x0400109F RID: 4255
		public const string MULTISITESLOT1 = "MULTISITESLOT1";

		// Token: 0x040010A0 RID: 4256
		public const string MULTISITESLOT2 = "MULTISITESLOT2";

		// Token: 0x040010A1 RID: 4257
		public const string SLOT1AND2 = "SLOT1AND2";

		// Token: 0x040010A2 RID: 4258
		public const string SLOT1AND2WITHPRECONF1 = "SLOT1AND2WITHPRECONF1";

		// Token: 0x040010A3 RID: 4259
		public const string SLOT1AND2WITHPRECONF2 = "SLOT1AND2WITHPRECONF2";

		// Token: 0x040010A4 RID: 4260
		public const string REPEATERDISABLE = "REPEATERDISABLE";

		// Token: 0x040010A5 RID: 4261
		public const string REPEATERRESET = "REPEATERRESET";

		// Token: 0x040010A6 RID: 4262
		public const string RPTTXPWLEVCHANGE = "RPTTXPWLEVCHANGE";

		// Token: 0x040010A7 RID: 4263
		public const string RPTMAJALARM = "RPTMAJALARM";

		// Token: 0x040010A8 RID: 4264
		public const string RPTMINALARM = "RPTMINALARM";

		// Token: 0x040010A9 RID: 4265
		public const string EXTPTT = "EXTPTT";

		// Token: 0x040010AA RID: 4266
		public const string RPTKDWN = "RPTKDWN";

		// Token: 0x040010AB RID: 4267
		public const string NFLKNOCKDOWN = "NFLKNOCKDOWN";

		// Token: 0x040010AC RID: 4268
		public const string FCCTYPE2MONTR = "FCCTYPE2MONTR";

		// Token: 0x040010AD RID: 4269
		public const string SINGLESITE = "SINGLESITE";

		// Token: 0x040010AE RID: 4270
		public const string MSCONTROLLER = "MSCONTROLLER";

		// Token: 0x040010AF RID: 4271
		public const string MSPEER = "MSPEER";

		// Token: 0x040010B0 RID: 4272
		public const string DGTLCONVCAPPLUSVOICE = "DGTLCONVCAPPLUSVOICE";

		// Token: 0x040010B1 RID: 4273
		public const string DGTLCONVCAPPLUSDATA = "DGTLCONVCAPPLUSDATA";

		// Token: 0x040010B2 RID: 4274
		public const string DGTLCONVCAPPLUS = "DGTLCONVCAPPLUS";

		// Token: 0x040010B3 RID: 4275
		public const string DGTLCONVCAPPLUSSYSTEM = "DGTLCONVCAPPLUSSYSTEM";

		// Token: 0x040010B4 RID: 4276
		public const string CAPPLUSSYSCONV = "CAPPLUSSYSCONV";

		// Token: 0x040010B5 RID: 4277
		public const string CAPPLUSVOICECONV = "CAPPLUSVOICECONV";

		// Token: 0x040010B6 RID: 4278
		public const string CAPPLUSDATACONV = "CAPPLUSDATACONV";

		// Token: 0x040010B7 RID: 4279
		public const string CAPPLUSDGTLALLSYSCALL = "CAPPLUSDGTLALLSYSCALL";

		// Token: 0x040010B8 RID: 4280
		public const string CAPPLUSGRPCALL = "CAPPLUSGRPCALL";

		// Token: 0x040010B9 RID: 4281
		public const string CAPPLUSPRIVCALL = "CAPPLUSPRIVCALL";

		// Token: 0x040010BA RID: 4282
		public const string PHONECALLMODE = "PHONECALLMODE";

		// Token: 0x040010BB RID: 4283
		public const string COR = "COR";

		// Token: 0x040010BC RID: 4284
		public const string FREE = "FREE";

		// Token: 0x040010BD RID: 4285
		public const string CFS_ENABLED = "CFS_ENABLED";

		// Token: 0x040010BE RID: 4286
		public const string CFS_DISABLED = "CFS_DISABLED";

		// Token: 0x040010BF RID: 4287
		public const string CFS_FREE = "CFS_FREE";

		// Token: 0x040010C0 RID: 4288
		public const string CFS_PENDINGACTIVE = "CFS_PENDINGACTIVE";

		// Token: 0x040010C1 RID: 4289
		public const string EVERYPTT = "EVERYPTT";

		// Token: 0x040010C2 RID: 4290
		public const string ONCEONLY = "ONCEONLY";

		// Token: 0x040010C3 RID: 4291
		public const string PERIODIC = "PERIODIC";

		// Token: 0x040010C4 RID: 4292
		public const string SMARTPTT = "SMARTPTT";

		// Token: 0x040010C5 RID: 4293
		public const string CUMULATIVE = "CUMULATIVE";

		// Token: 0x040010C6 RID: 4294
		public const string FILTERSA = "FILTERSA";

		// Token: 0x040010C7 RID: 4295
		public const string FIlTERUA = "FIlTERUA";

		// Token: 0x040010C8 RID: 4296
		public const string FLATUA = "FLATUA";

		// Token: 0x040010C9 RID: 4297
		public const string FLATSA = "FLATSA";

		// Token: 0x040010CA RID: 4298
		public const string STR_1200HZOR1800HZ = "STR_1200HZOR1800HZ";

		// Token: 0x040010CB RID: 4299
		public const string STR_1200HZAND1800HZ = "STR_1200HZAND1800HZ";

		// Token: 0x040010CC RID: 4300
		public const string SHORT = "SHORT";

		// Token: 0x040010CD RID: 4301
		public const string POSTONLY = "POSTONLY";

		// Token: 0x040010CE RID: 4302
		public const string PREANDPOST = "PREANDPOST";

		// Token: 0x040010CF RID: 4303
		public const string PREONLY = "PREONLY";

		// Token: 0x040010D0 RID: 4304
		public const string PRE = "PRE";

		// Token: 0x040010D1 RID: 4305
		public const string EMERALRONLY = "EMERALRONLY";

		// Token: 0x040010D2 RID: 4306
		public const string EMERCALRANDCALL = "EMERCALRANDCALL";

		// Token: 0x040010D3 RID: 4307
		public const string EMERCALRWITHVOICE = "EMERCALRWITHVOICE";

		// Token: 0x040010D4 RID: 4308
		public const string REGULAR = "REGULAR";

		// Token: 0x040010D5 RID: 4309
		public const string STR_12PT5KHZAT800M = "STR_12PT5KHZAT800M";

		// Token: 0x040010D6 RID: 4310
		public const string STR_12PT5KHZAT900M = "STR_12PT5KHZAT900M";

		// Token: 0x040010D7 RID: 4311
		public const string STR_20KHZAT800M = "STR_20KHZAT800M";

		// Token: 0x040010D8 RID: 4312
		public const string STR_25KHZAT800M = "STR_25KHZAT800M";

		// Token: 0x040010D9 RID: 4313
		public const string CHANNELBANDWIDTH_12_5 = "CHANNELBANDWIDTH_12_5";

		// Token: 0x040010DA RID: 4314
		public const string CHANNELBANDWIDTH_25 = "CHANNELBANDWIDTH_25";

		// Token: 0x040010DB RID: 4315
		public const string YES = "YES";

		// Token: 0x040010DC RID: 4316
		public const string NO = "NO";

		// Token: 0x040010DD RID: 4317
		public const string CONTACTS = "CONTACTS";

		// Token: 0x040010DE RID: 4318
		public const string SCANNING = "SCANNING";

		// Token: 0x040010DF RID: 4319
		public const string ZONE = "Zone";

		// Token: 0x040010E0 RID: 4320
		public const string MESSAGES = "MESSAGES";

		// Token: 0x040010E1 RID: 4321
		public const string CALLLOG = "CALLLOG";

		// Token: 0x040010E2 RID: 4322
		public const string SETTINGS = "SETTINGS";

		// Token: 0x040010E3 RID: 4323
		public const string QUIK_CALLII = "Quik-Call II";

		// Token: 0x040010E4 RID: 4324
		public const string PRICALL = "PRICALL";

		// Token: 0x040010E5 RID: 4325
		public const string CALLALRT = "CALLALRT";

		// Token: 0x040010E6 RID: 4326
		public const string QUICKTXT = "QUICKTXT";

		// Token: 0x040010E7 RID: 4327
		public const string UART = "UART";

		// Token: 0x040010E8 RID: 4328
		public const string USB = "USB";

		// Token: 0x040010E9 RID: 4329
		public const string INTERNALRELAY = "INTERNALRELAY";

		// Token: 0x040010EA RID: 4330
		public const string ONCORRCTPL = "ONCORRCTPL";

		// Token: 0x040010EB RID: 4331
		public const string ONCHNNLFREE = "ONCHNNLFREE";

		// Token: 0x040010EC RID: 4332
		public const string TURNOFF = "TURNOFF";

		// Token: 0x040010ED RID: 4333
		public const string TONE1 = "TONE1";

		// Token: 0x040010EE RID: 4334
		public const string TONE2 = "TONE2";

		// Token: 0x040010EF RID: 4335
		public const string TONE3 = "TONE3";

		// Token: 0x040010F0 RID: 4336
		public const string TONE4 = "TONE4";

		// Token: 0x040010F1 RID: 4337
		public const string TONE5 = "TONE5";

		// Token: 0x040010F2 RID: 4338
		public const string TONE6 = "TONE6";

		// Token: 0x040010F3 RID: 4339
		public const string TONE7 = "TONE7";

		// Token: 0x040010F4 RID: 4340
		public const string TONE8 = "TONE8";

		// Token: 0x040010F5 RID: 4341
		public const string TONE9 = "TONE9";

		// Token: 0x040010F6 RID: 4342
		public const string TONE10 = "TONE10";

		// Token: 0x040010F7 RID: 4343
		public const string DIGITALCHOICE = "DIGITALCHOICE";

		// Token: 0x040010F8 RID: 4344
		public const string ANALOGCHOICE = "ANALOGCHOICE";

		// Token: 0x040010F9 RID: 4345
		public const string ANALOGANDDIGITAL = "ANALOGANDDIGITAL";

		// Token: 0x040010FA RID: 4346
		public const string RELEASE13 = "0300";

		// Token: 0x040010FB RID: 4347
		public const string RELEASE14 = "0400";

		// Token: 0x040010FC RID: 4348
		public const string RELEASE15 = "0500";

		// Token: 0x040010FD RID: 4349
		public const string RELEASE15A = "0501";

		// Token: 0x040010FE RID: 4350
		public const string RELEASE17 = "0800";

		// Token: 0x040010FF RID: 4351
		public const string Paradise2_3a = "0601";

		// Token: 0x04001100 RID: 4352
		public const string RELEASE21 = "1100";

		// Token: 0x04001101 RID: 4353
		public const string MATRIX_UUID = "D105ADD323864E539B513A65076458D3";

		// Token: 0x04001102 RID: 4354
		public const string PHOENIX_UUID = "06CE7B7163C0456A845A6E13421F0AE4";

		// Token: 0x04001103 RID: 4355
		public const string GEMSTONE_UUID = "0C78E1B906C54D3A8F264CE5C4F0B9DF";

		// Token: 0x04001104 RID: 4356
		public const string ANDORRA_UUID = "0571AFE244664F999A96B020E82DC69C";

		// Token: 0x04001105 RID: 4357
		public const string MALTA_UUID = "9F6C2442C375421981A8987115FC9ADE";

		// Token: 0x04001106 RID: 4358
		public const string REUNION_UUID = "106F58B631044D63B41F0C0D7720758D";

		// Token: 0x04001107 RID: 4359
		public const string TIMOR_UUID = "0C0D6EE58204FBDEBB8860C631AB465A";

		// Token: 0x04001108 RID: 4360
		public const string TAHITI_UUID = "C4FC39D8DEF24B779D1CB719AF26A269";

		// Token: 0x04001109 RID: 4361
		public const string TAHITIPLUS_UUID = "C52A3D4953FE469D8E11F05B143E8C56";

		// Token: 0x0400110A RID: 4362
		public const string TONGA_UUID = "1EC82E1A4AE2B4F1A8AC27E8039CB7E4";

		// Token: 0x0400110B RID: 4363
		public const string BAHAMA_UUID = "AF5DAB63F4FC4926BB9000A6F18AF3DC";

		// Token: 0x0400110C RID: 4364
		public const string TONGAPLUS_UUID = "EBCCE9BF33B14896B5C2E7E3AA19AF0F";

		// Token: 0x0400110D RID: 4365
		public const string MATRIX_CPVERS0500 = "0500";

		// Token: 0x0400110E RID: 4366
		public const string MATRIX_CPVERS0601 = "0601";

		// Token: 0x0400110F RID: 4367
		public const string MATRIX_CPVERS1100 = "1100";

		// Token: 0x04001110 RID: 4368
		public const string MATRIX_CPVERS1301 = "1301";

		// Token: 0x04001111 RID: 4369
		public const string MATRIX_CPVERS1700 = "1700";

		// Token: 0x04001112 RID: 4370
		public const string PHOENIX_CPVERS0100 = "0100";

		// Token: 0x04001113 RID: 4371
		public const string PHOENIX_CPVERS0200 = "0200";

		// Token: 0x04001114 RID: 4372
		public const string PHOENIX_CPVERS0201 = "0201";

		// Token: 0x04001115 RID: 4373
		public const string PHOENIX_CPVERS0205 = "0205";

		// Token: 0x04001116 RID: 4374
		public const string PHOENIX_CPVERS0206 = "0206";

		// Token: 0x04001117 RID: 4375
		public const string PARADISE_CPVERS0200 = "0200";

		// Token: 0x04001118 RID: 4376
		public const string PARADISE_CPVERS0700 = "0700";

		// Token: 0x04001119 RID: 4377
		public const string PARADISE_CPVERS0900 = "0900";

		// Token: 0x0400111A RID: 4378
		public const string PARADISE_CPVERS1001 = "1001";

		// Token: 0x0400111B RID: 4379
		public const string PARADISE_CPVERS1002 = "1002";

		// Token: 0x0400111C RID: 4380
		public const string PARADISE_CPVERS1100 = "1100";

		// Token: 0x0400111D RID: 4381
		public const string PARADISELIGHT_CPVERS0800 = "0800";

		// Token: 0x0400111E RID: 4382
		public const string PARADISELIGHT_CPVERS0801 = "0801";

		// Token: 0x0400111F RID: 4383
		public const string STR_COMMA = ",";

		// Token: 0x04001120 RID: 4384
		public const string IVTCOMMA = "'";

		// Token: 0x04001121 RID: 4385
		public const string SQABRACKET1 = "[";

		// Token: 0x04001122 RID: 4386
		public const string SQABRACKET2 = "]";

		// Token: 0x04001123 RID: 4387
		public const string EQA = "=";

		// Token: 0x04001124 RID: 4388
		public const string DBLCOMMA = "\"";

		// Token: 0x04001125 RID: 4389
		public const string AT = "@";

		// Token: 0x04001126 RID: 4390
		public const string ANDOPERATOR = " and ";

		// Token: 0x04001127 RID: 4391
		public const string OROPERATOR = " or ";

		// Token: 0x04001128 RID: 4392
		public const string GREATERTHAN = ">";

		// Token: 0x04001129 RID: 4393
		public const string STR_ALL = "All";

		// Token: 0x0400112A RID: 4394
		public const string STR_VERSION = "VERSION";

		// Token: 0x0400112B RID: 4395
		public const string STR_NULL = "NULL";

		// Token: 0x0400112C RID: 4396
		public const string STR_LISTID = "ListID";

		// Token: 0x0400112D RID: 4397
		public const string STR_LISTLETID = "ListLetID";

		// Token: 0x0400112E RID: 4398
		public const string STR_ZERO = "0";

		// Token: 0x0400112F RID: 4399
		public const string UPDATESTAG = "<UPDATES></UPDATES>";

		// Token: 0x04001130 RID: 4400
		public const string EMPTYSTR = "";

		// Token: 0x04001131 RID: 4401
		public const string ENDOFSTR = "ENDOFSTR";

		// Token: 0x04001132 RID: 4402
		public const string STR_CPVER = "CPVER";

		// Token: 0x04001133 RID: 4403
		public const string STR_VAR = "VAR";

		// Token: 0x04001134 RID: 4404
		public const string BACKLIGHT = "BACKLIGHT";

		// Token: 0x04001135 RID: 4405
		public const string FIRST_PARAMETER_IN_STRING_FORMAT = "{0}";

		// Token: 0x04001136 RID: 4406
		public const string STR_STATUS = "Status";

		// Token: 0x04001137 RID: 4407
		public const string STR_ACTION = "Action";

		// Token: 0x04001138 RID: 4408
		public const string DESCENDANT = "descendant::";

		// Token: 0x04001139 RID: 4409
		public const string CHILD = "child::";

		// Token: 0x0400113A RID: 4410
		public const string NODE = "node()";

		// Token: 0x0400113B RID: 4411
		public const string NAME = "name()";

		// Token: 0x0400113C RID: 4412
		public const string TEXT = "text()";

		// Token: 0x0400113D RID: 4413
		public const string CONTAINSNAME = "contains(name(), ";

		// Token: 0x0400113E RID: 4414
		public const string XPATHAND = "and ";

		// Token: 0x0400113F RID: 4415
		public const string XPATHOR = "or ";

		// Token: 0x04001140 RID: 4416
		public const string ANDNOT = "and not(";

		// Token: 0x04001141 RID: 4417
		public const string NOT = "not(";

		// Token: 0x04001142 RID: 4418
		public const string GRANDPANAME = "name(parent::*/parent::*)";

		// Token: 0x04001143 RID: 4419
		public const string FIELD_FILTER = "//FIELD[contains(@PRODUCT,'%1')]";

		// Token: 0x04001144 RID: 4420
		public const string FIELD_FILTER_REPLACE = "%1";

		// Token: 0x04001145 RID: 4421
		public const string FIELD_NO_PRODUCT = "//FIELD[not(@PRODUCT)]";

		// Token: 0x04001146 RID: 4422
		public const string UNPACKPACKXML = "\\packunpack.lmx";

		// Token: 0x04001147 RID: 4423
		public const string TYPEIDXML = "\\typeid.lmx";

		// Token: 0x04001148 RID: 4424
		public const string MODELINFOFILENAME = "\\modelinfo.lmx";

		// Token: 0x04001149 RID: 4425
		public const string FILETYPE_MTB = ".mtb";

		// Token: 0x0400114A RID: 4426
		public const string STR_A = "A";

		// Token: 0x0400114B RID: 4427
		public const string STR_B = "B";

		// Token: 0x0400114C RID: 4428
		public const string STR_C = "C";

		// Token: 0x0400114D RID: 4429
		public const string STR_D = "D";

		// Token: 0x0400114E RID: 4430
		public const string STR_E = "E";

		// Token: 0x0400114F RID: 4431
		public const string STR_F = "F";

		// Token: 0x04001150 RID: 4432
		public const string PHOENIX_UNPACKPACKXML = "\\trunking3600_packunpack.lmx";

		// Token: 0x04001151 RID: 4433
		public const string PHOENIX_TYPEIDXML = "\\trunking3600_typeid.lmx";

		// Token: 0x04001152 RID: 4434
		public const string BAHAMA_TYPEID = "\\ngr_typeid.lmx";

		// Token: 0x04001153 RID: 4435
		public const string BAHAMA_PACKUNPACK = "\\ngr_packunpack.lmx";

		// Token: 0x04001154 RID: 4436
		public const string HEXPREFIX = "0x";

		// Token: 0x04001155 RID: 4437
		public const char CHAR_COMMA = ',';

		// Token: 0x04001156 RID: 4438
		public const char CHAR_SPACE = ' ';

		// Token: 0x04001157 RID: 4439
		public const char CHAR_DOT = '.';

		// Token: 0x04001158 RID: 4440
		public const char CHAR_A_UPPER = 'A';

		// Token: 0x04001159 RID: 4441
		public const char CHAR_B_UPPER = 'B';

		// Token: 0x0400115A RID: 4442
		public const char CHAR_C_UPPER = 'C';

		// Token: 0x0400115B RID: 4443
		public const char CHAR_D_UPPER = 'D';

		// Token: 0x0400115C RID: 4444
		public const char CHAR_E_UPPER = 'E';

		// Token: 0x0400115D RID: 4445
		public const char CHAR_F_UPPER = 'F';

		// Token: 0x0400115E RID: 4446
		public const char CHAR_A_LOWER = 'a';

		// Token: 0x0400115F RID: 4447
		public const char CHAR_B_LOWER = 'b';

		// Token: 0x04001160 RID: 4448
		public const char CHAR_C_LOWER = 'c';

		// Token: 0x04001161 RID: 4449
		public const char CHAR_D_LOWER = 'd';

		// Token: 0x04001162 RID: 4450
		public const char CHAR_E_LOWER = 'e';

		// Token: 0x04001163 RID: 4451
		public const char CHAR_F_LOWER = 'f';

		// Token: 0x04001164 RID: 4452
		public const char CHAR_X_UPPER = 'X';

		// Token: 0x04001165 RID: 4453
		public const char CHAR_X_LOWER = 'x';

		// Token: 0x04001166 RID: 4454
		public const char CHAR_0 = '0';

		// Token: 0x04001167 RID: 4455
		public const char CHAR_TILDA = '~';

		// Token: 0x04001168 RID: 4456
		public const int INT_ZERO = 0;

		// Token: 0x04001169 RID: 4457
		public const int INT_NEGATIVE_ONE = -1;

		// Token: 0x0400116A RID: 4458
		public const int INT_NEGATIVE_TWO = -2;

		// Token: 0x0400116B RID: 4459
		public const int BLK_MAX_LEN = 2048;

		// Token: 0x0400116C RID: 4460
		public const int POFFSET = 0;

		// Token: 0x0400116D RID: 4461
		public const int PPARTITIONLEN = 1;

		// Token: 0x0400116E RID: 4462
		public const int PITEMCOUNTLEN = 4;

		// Token: 0x0400116F RID: 4463
		public const int PTYPELEN = 2;

		// Token: 0x04001170 RID: 4464
		public const int PIDLEN = 2;

		// Token: 0x04001171 RID: 4465
		public const int PDATALEN = 2;

		// Token: 0x04001172 RID: 4466
		public const int DECIMAL = 10;

		// Token: 0x04001173 RID: 4467
		public const int OCTAL = 8;

		// Token: 0x04001174 RID: 4468
		public const int UINT_256 = 256;

		// Token: 0x04001175 RID: 4469
		public const int UINT_2 = 2;

		// Token: 0x04001176 RID: 4470
		public const byte SECURITYREGION = 129;

		// Token: 0x04001177 RID: 4471
		public const byte TUNEREGION = 130;

		// Token: 0x04001178 RID: 4472
		public const byte CFSREGION = 135;

		// Token: 0x04001179 RID: 4473
		public const ushort RADIO = 0;

		// Token: 0x0400117A RID: 4474
		public const ushort ARCHIVE = 1;

		// Token: 0x0400117B RID: 4475
		public const ushort NOUPDATE = 0;

		// Token: 0x0400117C RID: 4476
		public const ushort VERSUPDATE = 1;

		// Token: 0x0400117D RID: 4477
		public const ushort CFSVALUES_DIFFER = 2;

		// Token: 0x0400117E RID: 4478
		public const ushort UPGRADE = 1;

		// Token: 0x0400117F RID: 4479
		public const ushort DOWNGRADE = 2;

		// Token: 0x04001180 RID: 4480
		public const string ARCHIVE_TAG = "ARCHIVE";

		// Token: 0x04001181 RID: 4481
		public const string RADIO_TAG = "RADIO";

		// Token: 0x04001182 RID: 4482
		public const string TYPE_TAG = "TYPE";

		// Token: 0x04001183 RID: 4483
		public const string COPYRIGHT_TAG = "COPYRIGHT";

		// Token: 0x04001184 RID: 4484
		public const string COPYRIGHT_MOTOROLA = "Copyright (c) 2016 Motorola Solutions, Inc. All Rights Reserved.";

		// Token: 0x04001185 RID: 4485
		public const string ARCHIVE_START_TAG = "<ARCHIVE TYPE=";

		// Token: 0x04001186 RID: 4486
		public const string ARCHIVE_END_TAG = "</ARCHIVE>";

		// Token: 0x04001187 RID: 4487
		public const string ARCHIVE_VERSION = "1";

		// Token: 0x04001188 RID: 4488
		public const int WESTERNANSI = 1252;

		// Token: 0x04001189 RID: 4489
		public const string ENCODING = "ENCODING";

		// Token: 0x0400118A RID: 4490
		public const string BASE64 = "Base64";

		// Token: 0x0400118B RID: 4491
		public const string LANGPATH = "";

		// Token: 0x0400118C RID: 4492
		public const string LANGFILEEXT = ".pack";

		// Token: 0x0400118D RID: 4493
		public const string LANGEXTFILTER = "*.pack";

		// Token: 0x0400118E RID: 4494
		public const string COMMONLANGEXTFILTER = "*.clpak";

		// Token: 0x0400118F RID: 4495
		public const string MALTALANGEXTFILTER = "*.dpak";

		// Token: 0x04001190 RID: 4496
		public const string TTSLANGEXTFILTER = "*.ttspack";

		// Token: 0x04001191 RID: 4497
		public const int AVAIL_SPACE = 4;

		// Token: 0x04001192 RID: 4498
		public const int PKG_NUM = 1;

		// Token: 0x04001193 RID: 4499
		public const int STRUCT_SIZE = 1;

		// Token: 0x04001194 RID: 4500
		public const int ORDERING_LEN = 4;

		// Token: 0x04001195 RID: 4501
		public const int LANGID_LEN = 16;

		// Token: 0x04001196 RID: 4502
		public const int MAJVER_LEN = 4;

		// Token: 0x04001197 RID: 4503
		public const int MINVER_LEN = 4;

		// Token: 0x04001198 RID: 4504
		public const int TINYVER_LEN = 4;

		// Token: 0x04001199 RID: 4505
		public const int SIZE_LEN = 4;

		// Token: 0x0400119A RID: 4506
		public const int NAME_LEN = 100;

		// Token: 0x0400119B RID: 4507
		public const int COMMON_NAME_LEN = 160;

		// Token: 0x0400119C RID: 4508
		public const int TTS_LANGCODE_LEN = 4;

		// Token: 0x0400119D RID: 4509
		public const int TTS_NUANCE_VERSION_LEN = 75;

		// Token: 0x0400119E RID: 4510
		public const int TTS_SPEAKERNAME_LEN = 40;

		// Token: 0x0400119F RID: 4511
		public const int TTS_VOICEGENDER_LEN = 1;

		// Token: 0x040011A0 RID: 4512
		public const int HEADER_SIZE = 128;

		// Token: 0x040011A1 RID: 4513
		public const int COMMOON_HEADER_SIZE = 236;

		// Token: 0x040011A2 RID: 4514
		public const int TTS_HEADER_SIZE = 0;

		// Token: 0x040011A3 RID: 4515
		public const int RAD_H_SIZE = 29;

		// Token: 0x040011A4 RID: 4516
		public const string CS_LANGPACK_PARTITION = "CS_LANGPACK_PARTITION";

		// Token: 0x040011A5 RID: 4517
		public const string CS_TTSLANGPACK_PARTITION = "CS_TTSLANGPACK_PARTITION";

		// Token: 0x040011A6 RID: 4518
		public const string CS_LANGPACK_TYPE_GRP = "CS_LANGPACK_TYPE_GRP";

		// Token: 0x040011A7 RID: 4519
		public const string CS_TTSLANGPACK_TYPE_GRP = "CS_TTSLANGPACK_TYPE_GRP";

		// Token: 0x040011A8 RID: 4520
		public const string CS_LANGPACK_TYPE = "CS_LANGPACK_TYPE";

		// Token: 0x040011A9 RID: 4521
		public const string CS_TTSLANGPACK_TYPE = "CS_TTSLANGPACK_TYPE";

		// Token: 0x040011AA RID: 4522
		public const string CS_LANGPACK_ID = "CS_LANGPACK_ID";

		// Token: 0x040011AB RID: 4523
		public const string CS_LANGPACK_VER = "CS_LANGPACK_VER";

		// Token: 0x040011AC RID: 4524
		public const string CS_LANGPACK_SIZE = "CS_LANGPACK_SIZE";

		// Token: 0x040011AD RID: 4525
		public const string CS_LANGPACK_NAME = "CS_LANGPACK_NAME";

		// Token: 0x040011AE RID: 4526
		public const string CS_TTSLANGPACK_ID = "CS_TTSLANGPACK_ID";

		// Token: 0x040011AF RID: 4527
		public const string CS_TTSLANGPACK_VER = "CS_TTSLANGPACK_VER";

		// Token: 0x040011B0 RID: 4528
		public const string CS_TTSLANGPACK_SIZE = "CS_TTSLANGPACK_SIZE";

		// Token: 0x040011B1 RID: 4529
		public const string CS_TTSLANGPACK_NAME = "CS_TTSLANGPACK_NAME";

		// Token: 0x040011B2 RID: 4530
		public const string CS_TTSLANGPACK_CODE = "CS_TTSLANGPACK_CODE";

		// Token: 0x040011B3 RID: 4531
		public const string CS_TTSLANGPACK_NUANCEVER = "CS_TTSLANGPACK_NUANCEVER";

		// Token: 0x040011B4 RID: 4532
		public const string CS_TTSLANGPACK_SPEAKERNAME = "CS_TTSLANGPACK_SPEAKERNAME";

		// Token: 0x040011B5 RID: 4533
		public const string CS_TTSLANGPACK_VOICEGENDER = "CS_TTSLANGPACK_VOICEGENDER";

		// Token: 0x040011B6 RID: 4534
		public const string CS_AVAIL_MEMORY = "CS_AVAIL_MEMORY";

		// Token: 0x040011B7 RID: 4535
		public const string CS_EN_US_LANG_ID = "en-us";

		// Token: 0x040011B8 RID: 4536
		public const string CS_EN_US_LANG_NAME = "English";

		// Token: 0x040011B9 RID: 4537
		public const string CS_AR_AR_LANG_ID = "ar-ar";

		// Token: 0x040011BA RID: 4538
		public const string CS_LANGPACK = "CS_LANGPACK";

		// Token: 0x040011BB RID: 4539
		public const string CS_INFO_TYPE = "CS_INFO_TYPE";

		// Token: 0x040011BC RID: 4540
		public const string APP_PARTITION = "APP_PARTITION";

		// Token: 0x040011BD RID: 4541
		public const string SECURITY_PARTITION = "SECURITY_PARTITION";

		// Token: 0x040011BE RID: 4542
		public const string RAI_LPDATE_COMBINE = "RI_LPGDATE";

		// Token: 0x040011BF RID: 4543
		public const string RAI_LPDY = "RAI_LPDY";

		// Token: 0x040011C0 RID: 4544
		public const string RAI_LPDM = "RAI_LPDM";

		// Token: 0x040011C1 RID: 4545
		public const string RAI_LPDD = "RAI_LPDD";

		// Token: 0x040011C2 RID: 4546
		public const string RAI_LPDH = "RAI_LPDH";

		// Token: 0x040011C3 RID: 4547
		public const string RAI_LPDMIN = "RAI_LPDMIN";

		// Token: 0x040011C4 RID: 4548
		public const string RAI_LPS = "RAI_LPS";

		// Token: 0x040011C5 RID: 4549
		public const string RAI_LTDATE_COMBINE = "RAI_LTDATE";

		// Token: 0x040011C6 RID: 4550
		public const string RAI_LTDD = "RAI_LTDD";

		// Token: 0x040011C7 RID: 4551
		public const string RAI_LTDH = "RAI_LTDH";

		// Token: 0x040011C8 RID: 4552
		public const string RAI_LTDM = "RAI_LTDM";

		// Token: 0x040011C9 RID: 4553
		public const string RAI_LTDMIN = "RAI_LTDMIN";

		// Token: 0x040011CA RID: 4554
		public const string RAI_LTDY = "RAI_LTDY";

		// Token: 0x040011CB RID: 4555
		public const string RAI_LTS = "RAI_LTS";

		// Token: 0x040011CC RID: 4556
		public const string RAI_LTDATE = "RAI_LTDATE";

		// Token: 0x040011CD RID: 4557
		public const string ZN_CHAN_PER_ASGN_DLT_TYPE = "ZN_CHAN_PER_ASGN_DLT_TYPE";

		// Token: 0x040011CE RID: 4558
		public const string ADDOPERATION = "Add";

		// Token: 0x040011CF RID: 4559
		public const string PASTE_MULTIINSTANCE = "PASTE_MULTIINSTANCE";

		// Token: 0x040011D0 RID: 4560
		public const string PASTE_SINGLEINSTANCE = "PASTE_SINGLEINSTANCE";

		// Token: 0x040011D1 RID: 4561
		public const string MODIFYOPERATION = "Modify";

		// Token: 0x040011D2 RID: 4562
		public const string STR_SPACE = "STR_SPACE";

		// Token: 0x040011D3 RID: 4563
		public const string STR_QUOTE = "STR_QUOTE";

		// Token: 0x040011D4 RID: 4564
		public const string STR_DOUBLEQUOTE = "STR_DOUBLEQUOTE";

		// Token: 0x040011D5 RID: 4565
		public const string STR_QUESTIONMARK = "STR_QUESTIONMARK";

		// Token: 0x040011D6 RID: 4566
		public const string STR_EQUALSIGN = "STR_EQUALSIGN";

		// Token: 0x040011D7 RID: 4567
		public const string STR_COLON = "STR_COLON";

		// Token: 0x040011D8 RID: 4568
		public const string STR_PLUSSIGN = "STR_PLUSSIGN";

		// Token: 0x040011D9 RID: 4569
		public const string STR_MINUSSIGN = "STR_MINUSSIGN";

		// Token: 0x040011DA RID: 4570
		public const string STR_COMMA2 = "STR_COMMA2";

		// Token: 0x040011DB RID: 4571
		public const string STR_PERIOD = "STR_PERIOD";

		// Token: 0x040011DC RID: 4572
		public const string STR_FORWARDSLASH = "STR_FORWARDSLASH";

		// Token: 0x040011DD RID: 4573
		public const string STR_OPENPARENTTHESIS = "STR_OPENPARENTTHESIS";

		// Token: 0x040011DE RID: 4574
		public const string STR_CLOSEPARENTTHESIS = "STR_CLOSEPARENTTHESIS";

		// Token: 0x040011DF RID: 4575
		public const string STR_EXCLAMATIONMARK = "STR_EXCLAMATIONMARK";

		// Token: 0x040011E0 RID: 4576
		public const string STR_ATSYMBOL = "STR_ATSYMBOL";

		// Token: 0x040011E1 RID: 4577
		public const string Infinite = "Infinite";

		// Token: 0x040011E2 RID: 4578
		public const string MUTED = "MUTED";

		// Token: 0x040011E3 RID: 4579
		public const string STR_DOUBLEHYPHEN = "--";

		// Token: 0x040011E4 RID: 4580
		public const char PLUS_CHAR = '+';

		// Token: 0x040011E5 RID: 4581
		public const int ProgDlgStep = 10;

		// Token: 0x040011E6 RID: 4582
		public const string STR_LTD_CP_AVAILABILITY = "LTD_CP_AVAILABILITY";

		// Token: 0x040011E7 RID: 4583
		public const string FLD_TUNING_TX_PWRLOW_MAX_SOFTPOT = "FLD_TUNING_TX_PWRLOW_MAX_SOFTPOT";

		// Token: 0x040011E8 RID: 4584
		public const string P350 = "350";

		// Token: 0x040011E9 RID: 4585
		public const string P300 = "300";

		// Token: 0x040011EA RID: 4586
		public const string WB = "WB";

		// Token: 0x040011EB RID: 4587
		public const ushort WRITE_SERIAL_NUMBER = 3;

		// Token: 0x040011EC RID: 4588
		public const ushort WRITE_SERIAL_NUMBER_REPEQTER = 5;

		// Token: 0x040011ED RID: 4589
		public const ushort WRITE_DATETIME = 13;

		// Token: 0x040011EE RID: 4590
		public const string REUNION_TYPE = "REUNION";

		// Token: 0x040011EF RID: 4591
		public const string LBL_TUNING_TX_PWRHI_CQST_INFO = "LBL_TUNING_TX_PWRHI_CQST_INFO";

		// Token: 0x040011F0 RID: 4592
		public const string RELEASE2_4 = "0704";

		// Token: 0x040011F1 RID: 4593
		public const string RELEASE2_2B = "0403";

		// Token: 0x040011F2 RID: 4594
		public const string TUNING_TX_AUDIOLEVEL = "TUNING_TX_AUDIOLEVEL";

		// Token: 0x040011F3 RID: 4595
		public const string FLD_TUNING_TX_AUDIOLEVEL_TUNINGFREQ = "FLD_TUNING_TX_AUDIOLEVEL_TUNINGFREQ";

		// Token: 0x040011F4 RID: 4596
		public const string FLD_TUNING_TX_AUDIOLEVEL_TUNINGFREQ00 = "FLD_TUNING_TX_AUDIOLEVEL_TUNINGFREQ00";

		// Token: 0x040011F5 RID: 4597
		public const string FLD_PREVPROGSFT_TUNING_TX_AUDIOLEVEL_SOFTPOT = "FLD_PREVPROGSFT_TUNING_TX_AUDIOLEVEL_SOFTPOT";

		// Token: 0x040011F6 RID: 4598
		public const string FLD_PREVPROGSFT_TUNING_TX_AUDIOLEVEL_SOFTPOT00 = "FLD_PREVPROGSFT_TUNING_TX_AUDIOLEVEL_SOFTPOT00";

		// Token: 0x040011F7 RID: 4599
		public const string FLD_TUNING_TX_AUDIOLEVEL_SOFTPOT = "FLD_TUNING_TX_AUDIOLEVEL_SOFTPOT";

		// Token: 0x040011F8 RID: 4600
		public const string FLD_TUNING_TX_AUDIOLEVEL_SOFTPOT00 = "FLD_TUNING_TX_AUDIOLEVEL_SOFTPOT00";

		// Token: 0x040011F9 RID: 4601
		public const string TUNING_TX_VGS = "TUNING_TX_VGS";

		// Token: 0x040011FA RID: 4602
		public const string FLD_TUNING_TX_VGS_TUNINGFREQ = "FLD_TUNING_TX_VGS_TUNINGFREQ";

		// Token: 0x040011FB RID: 4603
		public const string FLD_TUNING_TX_VGS_TUNINGFREQ00 = "FLD_TUNING_TX_VGS_TUNINGFREQ00";

		// Token: 0x040011FC RID: 4604
		public const string FLD_PREVPROGSFT_TUNING_TX_VGS_SOFTPOT = "FLD_PREVPROGSFT_TUNING_TX_VGS_SOFTPOT";

		// Token: 0x040011FD RID: 4605
		public const string FLD_PREVPROGSFT_TUNING_TX_VGS_SOFTPOT00 = "FLD_PREVPROGSFT_TUNING_TX_VGS_SOFTPOT00";

		// Token: 0x040011FE RID: 4606
		public const string FLD_TUNING_TX_VGS_SOFTPOT = "FLD_TUNING_TX_VGS_SOFTPOT";

		// Token: 0x040011FF RID: 4607
		public const string FLD_TUNING_TX_VGS_SOFTPOT00 = "FLD_TUNING_TX_VGS_SOFTPOT00";

		// Token: 0x04001200 RID: 4608
		public const string FLD_TUNING_TX_VGS_VOLTAGE_VALUE = "FLD_TUNING_TX_VGS_VOLTAGE_VALUE";

		// Token: 0x04001201 RID: 4609
		public const string MODELS_SUPPORT_P2LP = "MODELS_SUPPORT_P2LP";

		// Token: 0x04001202 RID: 4610
		public const string ENHANCED_MALTA_INTRODUCED = "ENHANCED_MALTA_INTRODUCED";

		// Token: 0x04001203 RID: 4611
		public const string IS_FEF_SUPPORTED_FOR_MOTO2_SINCE23A = "IS_FEF_SUPPORTED_FOR_MOTO2_SINCE23A";

		// Token: 0x04001204 RID: 4612
		public const string CS_GOBVERSION = "CS_GOBVERSION";

		// Token: 0x04001205 RID: 4613
		public const ushort UPPER_LIMIT_FOR_DCA_VERIFICATION = 100;

		// Token: 0x04001206 RID: 4614
		public const string P800_900 = "800/900";

		// Token: 0x04001207 RID: 4615
		public const string PHOENIX800_RX_MIN_FREQ = "PHOENIX800_RX_MIN_FREQ";

		// Token: 0x04001208 RID: 4616
		public const string PHOENIX800_RX_MAX_FREQ = "PHOENIX800_RX_MAX_FREQ";

		// Token: 0x04001209 RID: 4617
		public const string PHOENIX900_RX_MIN_FREQ = "PHOENIX900_RX_MIN_FREQ";

		// Token: 0x0400120A RID: 4618
		public const string PHOENIX900_RX_MAX_FREQ = "PHOENIX900_RX_MAX_FREQ";

		// Token: 0x0400120B RID: 4619
		public const string PHOENIX800_TX_MIN_FREQ = "PHOENIX800_TX_MIN_FREQ";

		// Token: 0x0400120C RID: 4620
		public const string PHOENIX800_TX_MAX_FREQ = "PHOENIX800_TX_MAX_FREQ";

		// Token: 0x0400120D RID: 4621
		public const string PHOENIX900_TX_MIN_FREQ = "PHOENIX900_TX_MIN_FREQ";

		// Token: 0x0400120E RID: 4622
		public const string PHOENIX900_TX_MAX_FREQ = "PHOENIX900_TX_MAX_FREQ";

		// Token: 0x0400120F RID: 4623
		public const string UUID = "UUID";

		// Token: 0x04001210 RID: 4624
		public const string PRODUCT_NAME_TUNER = "MOTOTRBO Tuner";

		// Token: 0x04001211 RID: 4625
		public const string NOTAPPLICABLE = "NA";

		// Token: 0x04001212 RID: 4626
		public const string MENUITEM_PTT_TOGGLE = "mnuPTTToggle";

		// Token: 0x04001213 RID: 4627
		public const string MINVHF = "136.000000";

		// Token: 0x04001214 RID: 4628
		public const string MAXVHF = "174.000000";

		// Token: 0x04001215 RID: 4629
		public const string MINUHF = "400.000000";

		// Token: 0x04001216 RID: 4630
		public const string MAXUHF = "470.000000";

		// Token: 0x04001217 RID: 4631
		public const string GEMSTONE_TYPEID = "trbo_typeid.lmx";

		// Token: 0x04001218 RID: 4632
		public const string GEMSTONE_PACKUNPACK = "trbo_packunpack.lmx";

		// Token: 0x04001219 RID: 4633
		public const string FLD_TUNING_SETTINGS_REPEATER_ISDUALBOARD = "FLD_TUNING_SETTINGS_REPEATER_ISDUALBOARD";

		// Token: 0x0400121A RID: 4634
		public const string FLD_TUNING_SETTINGS_REPEATER_TGTBOARD = "FLD_TUNING_SETTINGS_REPEATER_TGTBOARD";

		// Token: 0x0400121B RID: 4635
		public const string RADIO_TUNING_FREQ_CMP_TYPE = "RADIO_TUNING_FREQ_CMP_TYPE";

		// Token: 0x0400121C RID: 4636
		public const string RADIO_TUNING_SOFTPOT_CMP_TYPE = "RADIO_TUNING_SOFTPOT_CMP_TYPE";

		// Token: 0x0400121D RID: 4637
		public const string RADIO_TUNING_BERTESTING_CMP_TYPE = "RADIO_TUNING_BERTESTING_CMP_TYPE";

		// Token: 0x0400121E RID: 4638
		public const string RADIO_TUNING_TX_BER_CMP_TYPE = "RADIO_TUNING_TX_BER_CMP_TYPE";

		// Token: 0x0400121F RID: 4639
		public const string RADIO_TUNING_SETTINGS_TYPE_CMP_TYPE = "RADIO_TUNING_SETTINGS_TYPE_CMP_TYPE";

		// Token: 0x04001220 RID: 4640
		public const string RADIO_TUNING_RX_BER_TESTING_REPORT_CMP_TYPE_GRP = "RADIO_TUNING_RX_BER_TESTING_REPORT_CMP_TYPE_GRP";

		// Token: 0x04001221 RID: 4641
		public const string RADIO_TUNING_RX_BER_TESTING_REPORT_CMP_TYPE = "RADIO_TUNING_RX_BER_TESTING_REPORT_CMP_TYPE";

		// Token: 0x04001222 RID: 4642
		public const string RADIO_TUNING_SINADTEST_CMP_TYPE = "RADIO_TUNING_SINADTEST_CMP_TYPE";

		// Token: 0x04001223 RID: 4643
		public const string RADIO_TUNING_DATESTING_CMP_TYPE = "RADIO_TUNING_DATESTING_CMP_TYPE";

		// Token: 0x04001224 RID: 4644
		public const string TUNING_RX_DCA = "TUNING_RX_DCA";

		// Token: 0x04001225 RID: 4645
		public const string TOPOLOGY = "TOPOLOGY";

		// Token: 0x04001226 RID: 4646
		public const string FLD_TUNING_RX_DCA_TUNINGFREQ01 = "FLD_TUNING_RX_DCA_TUNINGFREQ01";

		// Token: 0x04001227 RID: 4647
		public const string FLD_TUNING_RX_DCA_SOFTPOT = "FLD_TUNING_RX_DCA_SOFTPOT";

		// Token: 0x04001228 RID: 4648
		public const string FLD_TUNING_RX_DCA_SOFTPOT00 = "FLD_TUNING_RX_DCA_SOFTPOT00";

		// Token: 0x04001229 RID: 4649
		public const string FLD_TUNING_RX_DCA_SOFTPOT01 = "FLD_TUNING_RX_DCA_SOFTPOT01";

		// Token: 0x0400122A RID: 4650
		public const string FLD_TUNING_RX_DCA_SOFTPOT02 = "FLD_TUNING_RX_DCA_SOFTPOT02";

		// Token: 0x0400122B RID: 4651
		public const string FLD_TUNING_RX_DCA_SOFTPOT03 = "FLD_TUNING_RX_DCA_SOFTPOT03";

		// Token: 0x0400122C RID: 4652
		public const string FLD_TUNING_RX_DCA_SOFTPOT04 = "FLD_TUNING_RX_DCA_SOFTPOT04";

		// Token: 0x0400122D RID: 4653
		public const string FLD_TUNING_RX_DCA_FIRST_SOFTPOT = "FLD_TUNING_RX_DCA_FIRST_SOFTPOT";

		// Token: 0x0400122E RID: 4654
		public const string FLD_TUNING_RX_DCA_FIRST_SOFTPOT00 = "FLD_TUNING_RX_DCA_FIRST_SOFTPOT00";

		// Token: 0x0400122F RID: 4655
		public const string FLD_TUNING_RX_DCA_FIRST_SOFTPOT01 = "FLD_TUNING_RX_DCA_FIRST_SOFTPOT01";

		// Token: 0x04001230 RID: 4656
		public const string FLD_TUNING_RX_DCA_FIRST_SOFTPOT02 = "FLD_TUNING_RX_DCA_FIRST_SOFTPOT02";

		// Token: 0x04001231 RID: 4657
		public const string FLD_TUNING_RX_DCA_FIRST_SOFTPOT03 = "FLD_TUNING_RX_DCA_FIRST_SOFTPOT03";

		// Token: 0x04001232 RID: 4658
		public const string FLD_TUNING_RX_DCA_FIRST_SOFTPOT04 = "FLD_TUNING_RX_DCA_FIRST_SOFTPOT04";

		// Token: 0x04001233 RID: 4659
		public const string FLD_TUNING_RX_DCA_FIRST_SOFTPOT05 = "FLD_TUNING_RX_DCA_FIRST_SOFTPOT05";

		// Token: 0x04001234 RID: 4660
		public const string FLD_TUNING_RX_DCA_SECOND_SOFTPOT = "FLD_TUNING_RX_DCA_SECOND_SOFTPOT";

		// Token: 0x04001235 RID: 4661
		public const string FLD_TUNING_RX_DCA_SECOND_SOFTPOT00 = "FLD_TUNING_RX_DCA_SECOND_SOFTPOT00";

		// Token: 0x04001236 RID: 4662
		public const string FLD_TUNING_RX_DCA_SECOND_SOFTPOT01 = "FLD_TUNING_RX_DCA_SECOND_SOFTPOT01";

		// Token: 0x04001237 RID: 4663
		public const string FLD_TUNING_RX_DCA_SECOND_SOFTPOT02 = "FLD_TUNING_RX_DCA_SECOND_SOFTPOT02";

		// Token: 0x04001238 RID: 4664
		public const string FLD_TUNING_RX_DCA_SECOND_SOFTPOT03 = "FLD_TUNING_RX_DCA_SECOND_SOFTPOT03";

		// Token: 0x04001239 RID: 4665
		public const string FLD_TUNING_RX_DCA_SECOND_SOFTPOT04 = "FLD_TUNING_RX_DCA_SECOND_SOFTPOT04";

		// Token: 0x0400123A RID: 4666
		public const string FLD_TUNING_RX_DCA_SECOND_SOFTPOT05 = "FLD_TUNING_RX_DCA_SECOND_SOFTPOT05";

		// Token: 0x0400123B RID: 4667
		public const string FLD_TUNING_RX_DCA_AMPLITUDE_ERROR = "FLD_TUNING_RX_DCA_AMPLITUDE_ERROR";

		// Token: 0x0400123C RID: 4668
		public const string FLD_TUNING_RX_DCA_AMPLITUDE_ERROR00 = "FLD_TUNING_RX_DCA_AMPLITUDE_ERROR00";

		// Token: 0x0400123D RID: 4669
		public const string FLD_TUNING_RX_DCA_AMPLITUDE_ERROR01 = "FLD_TUNING_RX_DCA_AMPLITUDE_ERROR01";

		// Token: 0x0400123E RID: 4670
		public const string FLD_TUNING_RX_DCA_AMPLITUDE_ERROR02 = "FLD_TUNING_RX_DCA_AMPLITUDE_ERROR02";

		// Token: 0x0400123F RID: 4671
		public const string FLD_TUNING_RX_DCA_AMPLITUDE_ERROR03 = "FLD_TUNING_RX_DCA_AMPLITUDE_ERROR03";

		// Token: 0x04001240 RID: 4672
		public const string FLD_TUNING_RX_DCA_AMPLITUDE_ERROR04 = "FLD_TUNING_RX_DCA_AMPLITUDE_ERROR04";

		// Token: 0x04001241 RID: 4673
		public const string FLD_TUNING_RX_DCA_PHASE_ERROR = "FLD_TUNING_RX_DCA_PHASE_ERROR";

		// Token: 0x04001242 RID: 4674
		public const string FLD_TUNING_RX_DCA_PHASE_ERROR00 = "FLD_TUNING_RX_DCA_PHASE_ERROR00";

		// Token: 0x04001243 RID: 4675
		public const string FLD_TUNING_RX_DCA_PHASE_ERROR01 = "FLD_TUNING_RX_DCA_PHASE_ERROR01";

		// Token: 0x04001244 RID: 4676
		public const string FLD_TUNING_RX_DCA_PHASE_ERROR02 = "FLD_TUNING_RX_DCA_PHASE_ERROR02";

		// Token: 0x04001245 RID: 4677
		public const string FLD_TUNING_RX_DCA_PHASE_ERROR03 = "FLD_TUNING_RX_DCA_PHASE_ERROR03";

		// Token: 0x04001246 RID: 4678
		public const string FLD_TUNING_RX_DCA_PHASE_ERROR04 = "FLD_TUNING_RX_DCA_PHASE_ERROR04";

		// Token: 0x04001247 RID: 4679
		public const string FLD_TUNING_RX_DCA_SBS = "FLD_TUNING_RX_DCA_SBS";

		// Token: 0x04001248 RID: 4680
		public const string FLD_TUNING_RX_DCA_SBS00 = "FLD_TUNING_RX_DCA_SBS00";

		// Token: 0x04001249 RID: 4681
		public const string FLD_TUNING_RX_DCA_SBS01 = "FLD_TUNING_RX_DCA_SBS01";

		// Token: 0x0400124A RID: 4682
		public const string FLD_TUNING_RX_DCA_SBS02 = "FLD_TUNING_RX_DCA_SBS02";

		// Token: 0x0400124B RID: 4683
		public const string FLD_TUNING_RX_DCA_SBS03 = "FLD_TUNING_RX_DCA_SBS03";

		// Token: 0x0400124C RID: 4684
		public const string FLD_TUNING_RX_DCA_SBS04 = "FLD_TUNING_RX_DCA_SBS04";

		// Token: 0x0400124D RID: 4685
		public const string FLD_NEW_TUNING_RX_DCA_SBS = "FLD_NEW_TUNING_RX_DCA_SBS";

		// Token: 0x0400124E RID: 4686
		public const string FLD_NEW_TUNING_RX_DCA_SBS00 = "FLD_NEW_TUNING_RX_DCA_SBS00";

		// Token: 0x0400124F RID: 4687
		public const string FLD_NEW_TUNING_RX_DCA_SBS01 = "FLD_NEW_TUNING_RX_DCA_SBS01";

		// Token: 0x04001250 RID: 4688
		public const string FLD_NEW_TUNING_RX_DCA_SBS02 = "FLD_NEW_TUNING_RX_DCA_SBS02";

		// Token: 0x04001251 RID: 4689
		public const string FLD_NEW_TUNING_RX_DCA_SBS03 = "FLD_NEW_TUNING_RX_DCA_SBS03";

		// Token: 0x04001252 RID: 4690
		public const string FLD_NEW_TUNING_RX_DCA_SBS04 = "FLD_NEW_TUNING_RX_DCA_SBS04";

		// Token: 0x04001253 RID: 4691
		public const string FLD_NEW_TUNING_RX_DCA_FIRST_SBS = "FLD_NEW_TUNING_RX_DCA_FIRST_SBS";

		// Token: 0x04001254 RID: 4692
		public const string FLD_NEW_TUNING_RX_DCA_FIRST_SBS00 = "FLD_NEW_TUNING_RX_DCA_FIRST_SBS00";

		// Token: 0x04001255 RID: 4693
		public const string FLD_NEW_TUNING_RX_DCA_FIRST_SBS01 = "FLD_NEW_TUNING_RX_DCA_FIRST_SBS01";

		// Token: 0x04001256 RID: 4694
		public const string FLD_NEW_TUNING_RX_DCA_FIRST_SBS02 = "FLD_NEW_TUNING_RX_DCA_FIRST_SBS02";

		// Token: 0x04001257 RID: 4695
		public const string FLD_NEW_TUNING_RX_DCA_FIRST_SBS03 = "FLD_NEW_TUNING_RX_DCA_FIRST_SBS03";

		// Token: 0x04001258 RID: 4696
		public const string FLD_NEW_TUNING_RX_DCA_FIRST_SBS04 = "FLD_NEW_TUNING_RX_DCA_FIRST_SBS04";

		// Token: 0x04001259 RID: 4697
		public const string FLD_NEW_TUNING_RX_DCA_SECOND_SBS = "FLD_NEW_TUNING_RX_DCA_SECOND_SBS";

		// Token: 0x0400125A RID: 4698
		public const string FLD_NEW_TUNING_RX_DCA_SECOND_SBS00 = "FLD_NEW_TUNING_RX_DCA_SECOND_SBS00";

		// Token: 0x0400125B RID: 4699
		public const string FLD_NEW_TUNING_RX_DCA_SECOND_SBS01 = "FLD_NEW_TUNING_RX_DCA_SECOND_SBS01";

		// Token: 0x0400125C RID: 4700
		public const string FLD_NEW_TUNING_RX_DCA_SECOND_SBS02 = "FLD_NEW_TUNING_RX_DCA_SECOND_SBS02";

		// Token: 0x0400125D RID: 4701
		public const string FLD_NEW_TUNING_RX_DCA_SECOND_SBS03 = "FLD_NEW_TUNING_RX_DCA_SECOND_SBS03";

		// Token: 0x0400125E RID: 4702
		public const string FLD_NEW_TUNING_RX_DCA_SECOND_SBS04 = "FLD_NEW_TUNING_RX_DCA_SECOND_SBS04";

		// Token: 0x0400125F RID: 4703
		public const string FLD_TUNING_RX_DCA_COMPENSATED_SBS = "FLD_TUNING_RX_DCA_COMPENSATED_SBS";

		// Token: 0x04001260 RID: 4704
		public const string FLD_TUNING_RX_DCA_COMPENSATED_SBS00 = "FLD_TUNING_RX_DCA_COMPENSATED_SBS00";

		// Token: 0x04001261 RID: 4705
		public const string FLD_TUNING_RX_DCA_COMPENSATED_SBS01 = "FLD_TUNING_RX_DCA_COMPENSATED_SBS01";

		// Token: 0x04001262 RID: 4706
		public const string FLD_TUNING_RX_DCA_COMPENSATED_SBS02 = "FLD_TUNING_RX_DCA_COMPENSATED_SBS02";

		// Token: 0x04001263 RID: 4707
		public const string FLD_TUNING_RX_DCA_COMPENSATED_SBS03 = "FLD_TUNING_RX_DCA_COMPENSATED_SBS03";

		// Token: 0x04001264 RID: 4708
		public const string FLD_TUNING_RX_DCA_COMPENSATED_SBS04 = "FLD_TUNING_RX_DCA_COMPENSATED_SBS04";

		// Token: 0x04001265 RID: 4709
		public const string BTN_TUNING_RX_DCA_BUTTON = "BTN_TUNING_RX_DCA_BUTTON";

		// Token: 0x04001266 RID: 4710
		public const string BTN_TUNING_RX_DCA_BUTTON00 = "BTN_TUNING_RX_DCA_BUTTON00";

		// Token: 0x04001267 RID: 4711
		public const string BTN_TUNING_RX_DCA_BUTTON01 = "BTN_TUNING_RX_DCA_BUTTON01";

		// Token: 0x04001268 RID: 4712
		public const string BTN_TUNING_RX_DCA_BUTTON02 = "BTN_TUNING_RX_DCA_BUTTON02";

		// Token: 0x04001269 RID: 4713
		public const string BTN_TUNING_RX_DCA_BUTTON03 = "BTN_TUNING_RX_DCA_BUTTON03";

		// Token: 0x0400126A RID: 4714
		public const string BTN_TUNING_RX_DCA_BUTTON04 = "BTN_TUNING_RX_DCA_BUTTON04";

		// Token: 0x0400126B RID: 4715
		public const string BTN_TUNING_RX_DCA_BUTTON05 = "BTN_TUNING_RX_DCA_BUTTON05";

		// Token: 0x0400126C RID: 4716
		public const string FLD_TUNING_RX_DCA_TUNINGFREQ = "FLD_TUNING_RX_DCA_TUNINGFREQ";

		// Token: 0x0400126D RID: 4717
		public const string FLD_PREVPROGSFT_TUNING_RX_DCA_SOFTPOT = "FLD_PREVPROGSFT_TUNING_RX_DCA_SOFTPOT";

		// Token: 0x0400126E RID: 4718
		public const string FLD_PREVPROGSFT_TUNING_RX_DCA_PHASE_ERROR = "FLD_PREVPROGSFT_TUNING_RX_DCA_PHASE_ERROR";

		// Token: 0x0400126F RID: 4719
		public const string FLD_PREVPROGSFT_TUNING_RX_DCA_AMPLITUDE_ERROR = "FLD_PREVPROGSFT_TUNING_RX_DCA_AMPLITUDE_ERROR";

		// Token: 0x04001270 RID: 4720
		public const string FLD_PREVPROGSFT_TUNING_RX_DCA_SBS = "FLD_PREVPROGSFT_TUNING_RX_DCA_SBS";

		// Token: 0x04001271 RID: 4721
		public const string FLD_NEW_TUNING_RX_DCA_PHASE_ERROR = "FLD_NEW_TUNING_RX_DCA_PHASE_ERROR";

		// Token: 0x04001272 RID: 4722
		public const string FLD_NEW_TUNING_RX_DCA_PHASE_ERROR00 = "FLD_NEW_TUNING_RX_DCA_PHASE_ERROR00";

		// Token: 0x04001273 RID: 4723
		public const string FLD_NEW_TUNING_RX_DCA_PHASE_ERROR01 = "FLD_NEW_TUNING_RX_DCA_PHASE_ERROR01";

		// Token: 0x04001274 RID: 4724
		public const string FLD_NEW_TUNING_RX_DCA_PHASE_ERROR02 = "FLD_NEW_TUNING_RX_DCA_PHASE_ERROR02";

		// Token: 0x04001275 RID: 4725
		public const string FLD_NEW_TUNING_RX_DCA_PHASE_ERROR03 = "FLD_NEW_TUNING_RX_DCA_PHASE_ERROR03";

		// Token: 0x04001276 RID: 4726
		public const string FLD_NEW_TUNING_RX_DCA_PHASE_ERROR04 = "FLD_NEW_TUNING_RX_DCA_PHASE_ERROR04";

		// Token: 0x04001277 RID: 4727
		public const string FLD_NEW_TUNING_RX_DCA_PHASE_ERROR05 = "FLD_NEW_TUNING_RX_DCA_PHASE_ERROR05";

		// Token: 0x04001278 RID: 4728
		public const string FLD_NEW_TUNING_RX_DCA_FIRST_PHASE_ERROR = "FLD_NEW_TUNING_RX_DCA_FIRST_PHASE_ERROR";

		// Token: 0x04001279 RID: 4729
		public const string FLD_NEW_TUNING_RX_DCA_FIRST_PHASE_ERROR00 = "FLD_NEW_TUNING_RX_DCA_FIRST_PHASE_ERROR00";

		// Token: 0x0400127A RID: 4730
		public const string FLD_NEW_TUNING_RX_DCA_FIRST_PHASE_ERROR01 = "FLD_NEW_TUNING_RX_DCA_FIRST_PHASE_ERROR01";

		// Token: 0x0400127B RID: 4731
		public const string FLD_NEW_TUNING_RX_DCA_FIRST_PHASE_ERROR02 = "FLD_NEW_TUNING_RX_DCA_FIRST_PHASE_ERROR02";

		// Token: 0x0400127C RID: 4732
		public const string FLD_NEW_TUNING_RX_DCA_FIRST_PHASE_ERROR03 = "FLD_NEW_TUNING_RX_DCA_FIRST_PHASE_ERROR03";

		// Token: 0x0400127D RID: 4733
		public const string FLD_NEW_TUNING_RX_DCA_FIRST_PHASE_ERROR04 = "FLD_NEW_TUNING_RX_DCA_FIRST_PHASE_ERROR04";

		// Token: 0x0400127E RID: 4734
		public const string FLD_NEW_TUNING_RX_DCA_FIRST_PHASE_ERROR05 = "FLD_NEW_TUNING_RX_DCA_FIRST_PHASE_ERROR05";

		// Token: 0x0400127F RID: 4735
		public const string FLD_NEW_TUNING_RX_DCA_SECOND_PHASE_ERROR = "FLD_NEW_TUNING_RX_DCA_SECOND_PHASE_ERROR";

		// Token: 0x04001280 RID: 4736
		public const string FLD_NEW_TUNING_RX_DCA_SECOND_PHASE_ERROR00 = "FLD_NEW_TUNING_RX_DCA_SECOND_PHASE_ERROR00";

		// Token: 0x04001281 RID: 4737
		public const string FLD_NEW_TUNING_RX_DCA_SECOND_PHASE_ERROR01 = "FLD_NEW_TUNING_RX_DCA_SECOND_PHASE_ERROR01";

		// Token: 0x04001282 RID: 4738
		public const string FLD_NEW_TUNING_RX_DCA_SECOND_PHASE_ERROR02 = "FLD_NEW_TUNING_RX_DCA_SECOND_PHASE_ERROR02";

		// Token: 0x04001283 RID: 4739
		public const string FLD_NEW_TUNING_RX_DCA_SECOND_PHASE_ERROR03 = "FLD_NEW_TUNING_RX_DCA_SECOND_PHASE_ERROR03";

		// Token: 0x04001284 RID: 4740
		public const string FLD_NEW_TUNING_RX_DCA_SECOND_PHASE_ERROR04 = "FLD_NEW_TUNING_RX_DCA_SECOND_PHASE_ERROR04";

		// Token: 0x04001285 RID: 4741
		public const string FLD_NEW_TUNING_RX_DCA_SECOND_PHASE_ERROR05 = "FLD_NEW_TUNING_RX_DCA_SECOND_PHASE_ERROR05";

		// Token: 0x04001286 RID: 4742
		public const string FLD_NEW_TUNING_RX_DCA_FIRST_AMPLITUDE_ERROR = "FLD_NEW_TUNING_RX_DCA_FIRST_AMPLITUDE_ERROR";

		// Token: 0x04001287 RID: 4743
		public const string FLD_NEW_TUNING_RX_DCA_FIRST_AMPLITUDE_ERROR00 = "FLD_NEW_TUNING_RX_DCA_FIRST_AMPLITUDE_ERROR00";

		// Token: 0x04001288 RID: 4744
		public const string FLD_NEW_TUNING_RX_DCA_FIRST_AMPLITUDE_ERROR01 = "FLD_NEW_TUNING_RX_DCA_FIRST_AMPLITUDE_ERROR01";

		// Token: 0x04001289 RID: 4745
		public const string FLD_NEW_TUNING_RX_DCA_FIRST_AMPLITUDE_ERROR02 = "FLD_NEW_TUNING_RX_DCA_FIRST_AMPLITUDE_ERROR02";

		// Token: 0x0400128A RID: 4746
		public const string FLD_NEW_TUNING_RX_DCA_FIRST_AMPLITUDE_ERROR03 = "FLD_NEW_TUNING_RX_DCA_FIRST_AMPLITUDE_ERROR03";

		// Token: 0x0400128B RID: 4747
		public const string FLD_NEW_TUNING_RX_DCA_FIRST_AMPLITUDE_ERROR04 = "FLD_NEW_TUNING_RX_DCA_FIRST_AMPLITUDE_ERROR04";

		// Token: 0x0400128C RID: 4748
		public const string FLD_NEW_TUNING_RX_DCA_FIRST_AMPLITUDE_ERROR05 = "FLD_NEW_TUNING_RX_DCA_FIRST_AMPLITUDE_ERROR05";

		// Token: 0x0400128D RID: 4749
		public const string FLD_NEW_TUNING_RX_DCA_SECOND_AMPLITUDE_ERROR = "FLD_NEW_TUNING_RX_DCA_SECOND_AMPLITUDE_ERROR";

		// Token: 0x0400128E RID: 4750
		public const string FLD_NEW_TUNING_RX_DCA_SECOND_AMPLITUDE_ERROR00 = "FLD_NEW_TUNING_RX_DCA_SECOND_AMPLITUDE_ERROR00";

		// Token: 0x0400128F RID: 4751
		public const string FLD_NEW_TUNING_RX_DCA_SECOND_AMPLITUDE_ERROR01 = "FLD_NEW_TUNING_RX_DCA_SECOND_AMPLITUDE_ERROR01";

		// Token: 0x04001290 RID: 4752
		public const string FLD_NEW_TUNING_RX_DCA_SECOND_AMPLITUDE_ERROR02 = "FLD_NEW_TUNING_RX_DCA_SECOND_AMPLITUDE_ERROR02";

		// Token: 0x04001291 RID: 4753
		public const string FLD_NEW_TUNING_RX_DCA_SECOND_AMPLITUDE_ERROR03 = "FLD_NEW_TUNING_RX_DCA_SECOND_AMPLITUDE_ERROR03";

		// Token: 0x04001292 RID: 4754
		public const string FLD_NEW_TUNING_RX_DCA_SECOND_AMPLITUDE_ERROR04 = "FLD_NEW_TUNING_RX_DCA_SECOND_AMPLITUDE_ERROR04";

		// Token: 0x04001293 RID: 4755
		public const string FLD_NEW_TUNING_RX_DCA_SECOND_AMPLITUDE_ERROR05 = "FLD_NEW_TUNING_RX_DCA_SECOND_AMPLITUDE_ERROR05";

		// Token: 0x04001294 RID: 4756
		public const string FLD_NEW_TUNING_RX_DCA_AMPLITUDE_ERROR = "FLD_NEW_TUNING_RX_DCA_AMPLITUDE_ERROR";

		// Token: 0x04001295 RID: 4757
		public const string FLD_NEW_TUNING_RX_DCA_AMPLITUDE_ERROR00 = "FLD_NEW_TUNING_RX_DCA_AMPLITUDE_ERROR00";

		// Token: 0x04001296 RID: 4758
		public const string FLD_NEW_TUNING_RX_DCA_AMPLITUDE_ERROR01 = "FLD_NEW_TUNING_RX_DCA_AMPLITUDE_ERROR01";

		// Token: 0x04001297 RID: 4759
		public const string FLD_NEW_TUNING_RX_DCA_AMPLITUDE_ERROR02 = "FLD_NEW_TUNING_RX_DCA_AMPLITUDE_ERROR02";

		// Token: 0x04001298 RID: 4760
		public const string FLD_NEW_TUNING_RX_DCA_AMPLITUDE_ERROR03 = "FLD_NEW_TUNING_RX_DCA_AMPLITUDE_ERROR03";

		// Token: 0x04001299 RID: 4761
		public const string FLD_NEW_TUNING_RX_DCA_AMPLITUDE_ERROR04 = "FLD_NEW_TUNING_RX_DCA_AMPLITUDE_ERROR04";

		// Token: 0x0400129A RID: 4762
		public const string FLD_NEW_TUNING_RX_DCA_AMPLITUDE_ERROR05 = "FLD_NEW_TUNING_RX_DCA_AMPLITUDE_ERROR05";

		// Token: 0x0400129B RID: 4763
		public const string FLD_TUNING_RX_CROSS_DCA_PHASE_ERROR_1A00 = "FLD_TUNING_RX_CROSS_DCA_PHASE_ERROR_1A00";

		// Token: 0x0400129C RID: 4764
		public const string FLD_TUNING_RX_CROSS_DCA_PHASE_ERROR_1B00 = "FLD_TUNING_RX_CROSS_DCA_PHASE_ERROR_1B00";

		// Token: 0x0400129D RID: 4765
		public const string FLD_TUNING_RX_CROSS_DCA_PHASE_ERROR_1C00 = "FLD_TUNING_RX_CROSS_DCA_PHASE_ERROR_1C00";

		// Token: 0x0400129E RID: 4766
		public const string FLD_TUNING_RX_CROSS_DCA_PHASE_ERROR_1D00 = "FLD_TUNING_RX_CROSS_DCA_PHASE_ERROR_1D00";

		// Token: 0x0400129F RID: 4767
		public const string FLD_TUNING_RX_CROSS_DCA_PHASE_ERROR_3A00 = "FLD_TUNING_RX_CROSS_DCA_PHASE_ERROR_3A00";

		// Token: 0x040012A0 RID: 4768
		public const string FLD_TUNING_RX_CROSS_DCA_PHASE_ERROR_3B00 = "FLD_TUNING_RX_CROSS_DCA_PHASE_ERROR_3B00";

		// Token: 0x040012A1 RID: 4769
		public const string FLD_TUNING_RX_CROSS_DCA_PHASE_ERROR_3C00 = "FLD_TUNING_RX_CROSS_DCA_PHASE_ERROR_3C00";

		// Token: 0x040012A2 RID: 4770
		public const string FLD_TUNING_RX_CROSS_DCA_PHASE_ERROR_3D00 = "FLD_TUNING_RX_CROSS_DCA_PHASE_ERROR_3D00";

		// Token: 0x040012A3 RID: 4771
		public const string BTN_TUNING_RX_CROSS_DCA_AUTOTUNE = "BTN_TUNING_RX_CROSS_DCA_AUTOTUNE";

		// Token: 0x040012A4 RID: 4772
		public const string FLD_TUNING_RX_CROSS_DCA_SOFTPOT = "FLD_TUNING_RX_CROSS_DCA_SOFTPOT";

		// Token: 0x040012A5 RID: 4773
		public const string RELEASE2_0_5 = "0200";

		// Token: 0x040012A6 RID: 4774
		public const string TUNING_RX_CROSS_DCA = "TUNING_RX_CROSS_DCA";

		// Token: 0x040012A7 RID: 4775
		public const string FLD_TUNING_RX_DCA_TUNINGFREQ00 = "FLD_TUNING_RX_DCA_TUNINGFREQ00";

		// Token: 0x040012A8 RID: 4776
		public const string FLD_TUNING_RX_DCA_TUNINGFREQ02 = "FLD_TUNING_RX_DCA_TUNINGFREQ02";

		// Token: 0x040012A9 RID: 4777
		public const string FLD_TUNING_RX_DCA_TUNINGFREQ03 = "FLD_TUNING_RX_DCA_TUNINGFREQ03";

		// Token: 0x040012AA RID: 4778
		public const string FLD_TUNING_RX_DCA_TUNINGFREQ04 = "FLD_TUNING_RX_DCA_TUNINGFREQ04";

		// Token: 0x040012AB RID: 4779
		public const string FLD_TUNING_RX_DCA_TUNINGFREQ05 = "FLD_TUNING_RX_DCA_TUNINGFREQ05";

		// Token: 0x040012AC RID: 4780
		public const string RADIO_TUNING_BANDITPWR_CMP_TYPE = "RADIO_TUNING_BANDITPWR_CMP_TYPE";

		// Token: 0x040012AD RID: 4781
		public const string FLD_TUNING_TX_BANDITPWR_STICKER_CODE = "FLD_TUNING_TX_BANDITPWR_STICKER_CODE";

		// Token: 0x040012AE RID: 4782
		public const string FLD_TUNING_TX_BANDITPWR_STICKER_CODE1 = "FLD_TUNING_TX_BANDITPWR_STICKER_CODE1";

		// Token: 0x040012AF RID: 4783
		public const string FLD_TUNING_TX_BANDITPWR_STICKER_CODE2 = "FLD_TUNING_TX_BANDITPWR_STICKER_CODE2";

		// Token: 0x040012B0 RID: 4784
		public const string FLD_TUNING_TX_BANDITPWR_STICKER_CODE3 = "FLD_TUNING_TX_BANDITPWR_STICKER_CODE3";

		// Token: 0x040012B1 RID: 4785
		public const string FLD_TUNING_TX_BANDITPWR_STICKER_CODE4 = "FLD_TUNING_TX_BANDITPWR_STICKER_CODE4";

		// Token: 0x040012B2 RID: 4786
		public const string TUNING_RX_DCA_800 = "TUNING_RX_DCA_800";

		// Token: 0x040012B3 RID: 4787
		public const string FLD_TUNING_RX_DCA_800_TUNINGFREQ = "FLD_TUNING_RX_DCA_800_TUNINGFREQ";

		// Token: 0x040012B4 RID: 4788
		public const string FLD_TUNING_RX_DCA_800_TUNINGFREQ00 = "FLD_TUNING_RX_DCA_800_TUNINGFREQ00";

		// Token: 0x040012B5 RID: 4789
		public const string FLD_TUNING_RX_DCA_800_TUNINGFREQ01 = "FLD_TUNING_RX_DCA_800_TUNINGFREQ01";

		// Token: 0x040012B6 RID: 4790
		public const string FLD_TUNING_RX_DCA_800_TUNINGFREQ02 = "FLD_TUNING_RX_DCA_800_TUNINGFREQ02";

		// Token: 0x040012B7 RID: 4791
		public const string FLD_TUNING_RX_DCA_800_SOFTPOT = "FLD_TUNING_RX_DCA_800_SOFTPOT";

		// Token: 0x040012B8 RID: 4792
		public const string FLD_TUNING_RX_DCA_800_AMPLITUDE_ERROR = "FLD_TUNING_RX_DCA_800_AMPLITUDE_ERROR";

		// Token: 0x040012B9 RID: 4793
		public const string FLD_TUNING_RX_DCA_800_PHASE_ERROR = "FLD_TUNING_RX_DCA_800_PHASE_ERROR";

		// Token: 0x040012BA RID: 4794
		public const string FLD_TUNING_RX_DCA_800_SBS = "FLD_TUNING_RX_DCA_800_SBS";

		// Token: 0x040012BB RID: 4795
		public const string FLD_NEW_TUNING_RX_DCA_800_SBS = "FLD_NEW_TUNING_RX_DCA_800_SBS";

		// Token: 0x040012BC RID: 4796
		public const string FLD_NEW_TUNING_RX_DCA_800_FIRST_SBS = "FLD_NEW_TUNING_RX_DCA_800_FIRST_SBS";

		// Token: 0x040012BD RID: 4797
		public const string FLD_NEW_TUNING_RX_DCA_800_SECOND_SBS = "FLD_NEW_TUNING_RX_DCA_800_SECOND_SBS";

		// Token: 0x040012BE RID: 4798
		public const string FLD_TUNING_RX_DCA_800_COMPENSATED_SBS = "FLD_TUNING_RX_DCA_800_COMPENSATED_SBS";

		// Token: 0x040012BF RID: 4799
		public const string BTN_TUNING_RX_DCA_800_BUTTON = "BTN_TUNING_RX_DCA_800_BUTTON";

		// Token: 0x040012C0 RID: 4800
		public const string BTN_TUNING_RX_DCA_800_BUTTON00 = "BTN_TUNING_RX_DCA_800_BUTTON00";

		// Token: 0x040012C1 RID: 4801
		public const string BTN_TUNING_RX_DCA_800_BUTTON01 = "BTN_TUNING_RX_DCA_800_BUTTON01";

		// Token: 0x040012C2 RID: 4802
		public const string BTN_TUNING_RX_DCA_800_BUTTON02 = "BTN_TUNING_RX_DCA_800_BUTTON02";

		// Token: 0x040012C3 RID: 4803
		public const string FLD_NEW_TUNING_RX_DCA_800_PHASE_ERROR = "FLD_NEW_TUNING_RX_DCA_800_PHASE_ERROR";

		// Token: 0x040012C4 RID: 4804
		public const string FLD_NEW_TUNING_RX_DCA_800_FIRST_PHASE_ERROR = "FLD_NEW_TUNING_RX_DCA_800_FIRST_PHASE_ERROR";

		// Token: 0x040012C5 RID: 4805
		public const string FLD_NEW_TUNING_RX_DCA_800_SECOND_PHASE_ERROR = "FLD_NEW_TUNING_RX_DCA_800_SECOND_PHASE_ERROR";

		// Token: 0x040012C6 RID: 4806
		public const string FLD_NEW_TUNING_RX_DCA_800_FIRST_AMPLITUDE_ERROR = "FLD_NEW_TUNING_RX_DCA_800_FIRST_AMPLITUDE_ERROR";

		// Token: 0x040012C7 RID: 4807
		public const string FLD_NEW_TUNING_RX_DCA_800_SECOND_AMPLITUDE_ERROR = "FLD_NEW_TUNING_RX_DCA_800_SECOND_AMPLITUDE_ERROR";

		// Token: 0x040012C8 RID: 4808
		public const string FLD_NEW_TUNING_RX_DCA_800_AMPLITUDE_ERROR = "FLD_NEW_TUNING_RX_DCA_800_AMPLITUDE_ERROR";

		// Token: 0x040012C9 RID: 4809
		public const string FLD_TUNING_RX_CROSS_DCA_800_PHASE_ERROR_1A00 = "FLD_TUNING_RX_CROSS_DCA_800_PHASE_ERROR_1A00";

		// Token: 0x040012CA RID: 4810
		public const string FLD_TUNING_RX_CROSS_DCA_800_PHASE_ERROR_1B00 = "FLD_TUNING_RX_CROSS_DCA_800_PHASE_ERROR_1B00";

		// Token: 0x040012CB RID: 4811
		public const string FLD_TUNING_RX_CROSS_DCA_800_PHASE_ERROR_1C00 = "FLD_TUNING_RX_CROSS_DCA_800_PHASE_ERROR_1C00";

		// Token: 0x040012CC RID: 4812
		public const string FLD_TUNING_RX_CROSS_DCA_800_PHASE_ERROR_1D00 = "FLD_TUNING_RX_CROSS_DCA_800_PHASE_ERROR_1D00";

		// Token: 0x040012CD RID: 4813
		public const string FLD_TUNING_RX_CROSS_DCA_800_PHASE_ERROR_3A00 = "FLD_TUNING_RX_CROSS_DCA_800_PHASE_ERROR_3A00";

		// Token: 0x040012CE RID: 4814
		public const string FLD_TUNING_RX_CROSS_DCA_800_PHASE_ERROR_3B00 = "FLD_TUNING_RX_CROSS_DCA_800_PHASE_ERROR_3B00";

		// Token: 0x040012CF RID: 4815
		public const string FLD_TUNING_RX_CROSS_DCA_800_PHASE_ERROR_3C00 = "FLD_TUNING_RX_CROSS_DCA_800_PHASE_ERROR_3C00";

		// Token: 0x040012D0 RID: 4816
		public const string FLD_TUNING_RX_CROSS_DCA_800_PHASE_ERROR_3D00 = "FLD_TUNING_RX_CROSS_DCA_800_PHASE_ERROR_3D00";

		// Token: 0x040012D1 RID: 4817
		public const string BTN_TUNING_RX_CROSS_DCA_800_AUTOTUNE = "BTN_TUNING_RX_CROSS_DCA_800_AUTOTUNE";

		// Token: 0x040012D2 RID: 4818
		public const string FLD_TUNING_RX_CROSS_DCA_800_SOFTPOT = "FLD_TUNING_RX_CROSS_DCA_800_SOFTPOT";

		// Token: 0x040012D3 RID: 4819
		public const string TUNING_RX_CROSS_DCA_800 = "TUNING_RX_CROSS_DCA_800";

		// Token: 0x040012D4 RID: 4820
		public const string TUNING_RX_DCA_900 = "TUNING_RX_DCA_900";

		// Token: 0x040012D5 RID: 4821
		public const string FLD_TUNING_RX_DCA_900_TUNINGFREQ = "FLD_TUNING_RX_DCA_900_TUNINGFREQ";

		// Token: 0x040012D6 RID: 4822
		public const string FLD_TUNING_RX_DCA_900_TUNINGFREQ00 = "FLD_TUNING_RX_DCA_900_TUNINGFREQ00";

		// Token: 0x040012D7 RID: 4823
		public const string FLD_TUNING_RX_DCA_900_TUNINGFREQ01 = "FLD_TUNING_RX_DCA_900_TUNINGFREQ01";

		// Token: 0x040012D8 RID: 4824
		public const string FLD_TUNING_RX_DCA_900_TUNINGFREQ02 = "FLD_TUNING_RX_DCA_900_TUNINGFREQ02";

		// Token: 0x040012D9 RID: 4825
		public const string FLD_TUNING_RX_DCA_900_SOFTPOT = "FLD_TUNING_RX_DCA_900_SOFTPOT";

		// Token: 0x040012DA RID: 4826
		public const string FLD_TUNING_RX_DCA_900_AMPLITUDE_ERROR = "FLD_TUNING_RX_DCA_900_AMPLITUDE_ERROR";

		// Token: 0x040012DB RID: 4827
		public const string FLD_TUNING_RX_DCA_900_PHASE_ERROR = "FLD_TUNING_RX_DCA_900_PHASE_ERROR";

		// Token: 0x040012DC RID: 4828
		public const string FLD_TUNING_RX_DCA_900_SBS = "FLD_TUNING_RX_DCA_900_SBS";

		// Token: 0x040012DD RID: 4829
		public const string FLD_NEW_TUNING_RX_DCA_900_SBS = "FLD_NEW_TUNING_RX_DCA_900_SBS";

		// Token: 0x040012DE RID: 4830
		public const string FLD_NEW_TUNING_RX_DCA_900_FIRST_SBS = "FLD_NEW_TUNING_RX_DCA_900_FIRST_SBS";

		// Token: 0x040012DF RID: 4831
		public const string FLD_NEW_TUNING_RX_DCA_900_SECOND_SBS = "FLD_NEW_TUNING_RX_DCA_900_SECOND_SBS";

		// Token: 0x040012E0 RID: 4832
		public const string FLD_TUNING_RX_DCA_900_COMPENSATED_SBS = "FLD_TUNING_RX_DCA_900_COMPENSATED_SBS";

		// Token: 0x040012E1 RID: 4833
		public const string BTN_TUNING_RX_DCA_900_BUTTON = "BTN_TUNING_RX_DCA_900_BUTTON";

		// Token: 0x040012E2 RID: 4834
		public const string BTN_TUNING_RX_DCA_900_BUTTON00 = "BTN_TUNING_RX_DCA_900_BUTTON00";

		// Token: 0x040012E3 RID: 4835
		public const string BTN_TUNING_RX_DCA_900_BUTTON01 = "BTN_TUNING_RX_DCA_900_BUTTON01";

		// Token: 0x040012E4 RID: 4836
		public const string BTN_TUNING_RX_DCA_900_BUTTON02 = "BTN_TUNING_RX_DCA_900_BUTTON02";

		// Token: 0x040012E5 RID: 4837
		public const string FLD_NEW_TUNING_RX_DCA_900_PHASE_ERROR = "FLD_NEW_TUNING_RX_DCA_900_PHASE_ERROR";

		// Token: 0x040012E6 RID: 4838
		public const string FLD_NEW_TUNING_RX_DCA_900_FIRST_PHASE_ERROR = "FLD_NEW_TUNING_RX_DCA_900_FIRST_PHASE_ERROR";

		// Token: 0x040012E7 RID: 4839
		public const string FLD_NEW_TUNING_RX_DCA_900_SECOND_PHASE_ERROR = "FLD_NEW_TUNING_RX_DCA_900_SECOND_PHASE_ERROR";

		// Token: 0x040012E8 RID: 4840
		public const string FLD_NEW_TUNING_RX_DCA_900_FIRST_AMPLITUDE_ERROR = "FLD_NEW_TUNING_RX_DCA_900_FIRST_AMPLITUDE_ERROR";

		// Token: 0x040012E9 RID: 4841
		public const string FLD_NEW_TUNING_RX_DCA_900_SECOND_AMPLITUDE_ERROR = "FLD_NEW_TUNING_RX_DCA_900_SECOND_AMPLITUDE_ERROR";

		// Token: 0x040012EA RID: 4842
		public const string FLD_NEW_TUNING_RX_DCA_900_AMPLITUDE_ERROR = "FLD_NEW_TUNING_RX_DCA_900_AMPLITUDE_ERROR";

		// Token: 0x040012EB RID: 4843
		public const string FLD_TUNING_RX_CROSS_DCA_900_PHASE_ERROR_1A00 = "FLD_TUNING_RX_CROSS_DCA_900_PHASE_ERROR_1A00";

		// Token: 0x040012EC RID: 4844
		public const string FLD_TUNING_RX_CROSS_DCA_900_PHASE_ERROR_1B00 = "FLD_TUNING_RX_CROSS_DCA_900_PHASE_ERROR_1B00";

		// Token: 0x040012ED RID: 4845
		public const string FLD_TUNING_RX_CROSS_DCA_900_PHASE_ERROR_1C00 = "FLD_TUNING_RX_CROSS_DCA_900_PHASE_ERROR_1C00";

		// Token: 0x040012EE RID: 4846
		public const string FLD_TUNING_RX_CROSS_DCA_900_PHASE_ERROR_1D00 = "FLD_TUNING_RX_CROSS_DCA_900_PHASE_ERROR_1D00";

		// Token: 0x040012EF RID: 4847
		public const string FLD_TUNING_RX_CROSS_DCA_900_PHASE_ERROR_3A00 = "FLD_TUNING_RX_CROSS_DCA_900_PHASE_ERROR_3A00";

		// Token: 0x040012F0 RID: 4848
		public const string FLD_TUNING_RX_CROSS_DCA_900_PHASE_ERROR_3B00 = "FLD_TUNING_RX_CROSS_DCA_900_PHASE_ERROR_3B00";

		// Token: 0x040012F1 RID: 4849
		public const string FLD_TUNING_RX_CROSS_DCA_900_PHASE_ERROR_3C00 = "FLD_TUNING_RX_CROSS_DCA_900_PHASE_ERROR_3C00";

		// Token: 0x040012F2 RID: 4850
		public const string FLD_TUNING_RX_CROSS_DCA_900_PHASE_ERROR_3D00 = "FLD_TUNING_RX_CROSS_DCA_900_PHASE_ERROR_3D00";

		// Token: 0x040012F3 RID: 4851
		public const string BTN_TUNING_RX_CROSS_DCA_900_AUTOTUNE = "BTN_TUNING_RX_CROSS_DCA_900_AUTOTUNE";

		// Token: 0x040012F4 RID: 4852
		public const string FLD_TUNING_RX_CROSS_DCA_900_SOFTPOT = "FLD_TUNING_RX_CROSS_DCA_900_SOFTPOT";

		// Token: 0x040012F5 RID: 4853
		public const string TUNING_RX_CROSS_DCA_900 = "TUNING_RX_CROSS_DCA_900";

		// Token: 0x040012F6 RID: 4854
		public const string TUNING_TX_SPUR = "TUNING_TX_SPUR";

		// Token: 0x040012F7 RID: 4855
		public const string FLD_TUNING_TX_SPUR_TOGGLE = "FLD_TUNING_TX_SPUR_TOGGLE";

		// Token: 0x040012F8 RID: 4856
		public const string FLD_TUNING_TX_SPUR_TUNINGFREQ = "FLD_TUNING_TX_SPUR_TUNINGFREQ";

		// Token: 0x040012F9 RID: 4857
		public const string FLD_PREVPROGSFT_TUNING_TX_SPUR_SOFTPOT = "FLD_PREVPROGSFT_TUNING_TX_SPUR_SOFTPOT";

		// Token: 0x040012FA RID: 4858
		public const string FLD_PREVPROGSFT_TUNING_TX_SPUR_SOFTPOT_LAYOUT = "FLD_PREVPROGSFT_TUNING_TX_SPUR_SOFTPOT_LAYOUT";

		// Token: 0x040012FB RID: 4859
		public const string FLD_TUNING_TX_SPUR_SOFTPOT = "FLD_TUNING_TX_SPUR_SOFTPOT";

		// Token: 0x040012FC RID: 4860
		public const string FLD_TUNING_TX_SPUR_DELAY_SELECT = "FLD_TUNING_TX_SPUR_DELAY_SELECT";

		// Token: 0x040012FD RID: 4861
		public const string FLD_TUNING_TX_SPUR_POLARITY_SELECT = "FLD_TUNING_TX_SPUR_POLARITY_SELECT";

		// Token: 0x040012FE RID: 4862
		public const string FLD_TUNING_TX_SPUR_DIVIDER_SELECT = "FLD_TUNING_TX_SPUR_DIVIDER_SELECT";

		// Token: 0x040012FF RID: 4863
		public const string FLD_TUNING_TX_SPUR_JITTER_EN = "FLD_TUNING_TX_SPUR_JITTER_EN";

		// Token: 0x04001300 RID: 4864
		public const string FLD_TUNING_TX_SPUR_REF_CLK_DIV_EN = "FLD_TUNING_TX_SPUR_REF_CLK_DIV_EN";

		// Token: 0x04001301 RID: 4865
		public const string FLD_TUNING_TX_SPUR_HBLB_DELAY = "FLD_TUNING_TX_SPUR_HBLB_DELAY";

		// Token: 0x04001302 RID: 4866
		public const string FLD_TUNING_TX_SPUR = "FLD_TUNING_TX_SPUR";

		// Token: 0x04001303 RID: 4867
		public const string FLD_TUNING_TX_SPUR_TUNINGFREQ00 = "FLD_TUNING_TX_SPUR_TUNINGFREQ00";

		// Token: 0x04001304 RID: 4868
		public const string RS_BANDIT_MTR2000_BAND = "RS_BANDIT_MTR2000_BAND";

		// Token: 0x04001305 RID: 4869
		public const string RS_BANDIT_MTR2000_VERSION = "RS_BANDIT_MTR2000_VERSION";

		// Token: 0x04001306 RID: 4870
		public const string RS_BANDIT_MTR2000_CCB = "RS_BANDIT_MTR2000_CCB";

		// Token: 0x04001307 RID: 4871
		public const string RS_BANDIT_MTR2000_CCA = "RS_BANDIT_MTR2000_CCA";

		// Token: 0x04001308 RID: 4872
		public const string RS_BANDIT_MTR2000_CCC = "RS_BANDIT_MTR2000_CCC";

		// Token: 0x04001309 RID: 4873
		public const string RS_BANDIT_MTR2000_CCE = "RS_BANDIT_MTR2000_CCE";

		// Token: 0x0400130A RID: 4874
		public const string RS_BANDIT_MTR2000_CCG = "RS_BANDIT_MTR2000_CCG";

		// Token: 0x0400130B RID: 4875
		public const string RS_BANDIT_MTR2000_CCH = "RS_BANDIT_MTR2000_CCH";

		// Token: 0x0400130C RID: 4876
		public const string RS_BANDIT_MTR2000_CCK = "RS_BANDIT_MTR2000_CCK";

		// Token: 0x0400130D RID: 4877
		public const string RS_BANDIT_MTR2000_CRC = "RS_BANDIT_MTR2000_CRC";

		// Token: 0x0400130E RID: 4878
		public const string TUNING_RX_WLLEVEL = "TUNING_RX_WLLEVEL";

		// Token: 0x0400130F RID: 4879
		public const string FLD_TUNING_RX_WLLEVEL_TUNINGFREQ = "FLD_TUNING_RX_WLLEVEL_TUNINGFREQ";

		// Token: 0x04001310 RID: 4880
		public const string FLD_TUNING_RX_WLLEVEL_TUNINGFREQ00 = "FLD_TUNING_RX_WLLEVEL_TUNINGFREQ00";

		// Token: 0x04001311 RID: 4881
		public const string FLD_TUNING_RX_WLLEVEL_SOFTPOT = "FLD_TUNING_RX_WLLEVEL_SOFTPOT";

		// Token: 0x04001312 RID: 4882
		public const string FLD_TUNING_RX_WLLEVEL_SOFTPOT00 = "FLD_TUNING_RX_WLLEVEL_SOFTPOT00";

		// Token: 0x04001313 RID: 4883
		public const string FLD_PREVPROGSFT_TUNING_RX_WLLEVEL_SOFTPOT = "FLD_PREVPROGSFT_TUNING_RX_WLLEVEL_SOFTPOT";

		// Token: 0x04001314 RID: 4884
		public const string FLD_PREVPROGSFT_TUNING_RX_WLLEVEL_SOFTPOT00 = "FLD_PREVPROGSFT_TUNING_RX_WLLEVEL_SOFTPOT00";

		// Token: 0x04001315 RID: 4885
		public const string LBL_TUNING_RX_WLLEVEL_TUNINGFREQ = "LBL_TUNING_RX_WLLEVEL_TUNINGFREQ";

		// Token: 0x04001316 RID: 4886
		public const string LBL_PREVPROGSFT_TUNING_RX_WLLEVEL_SOFTPOT = "LBL_PREVPROGSFT_TUNING_RX_WLLEVEL_SOFTPOT";

		// Token: 0x04001317 RID: 4887
		public const string LBL_TUNING_RX_WLLEVEL_SOFTPOT = "LBL_TUNING_RX_WLLEVEL_SOFTPOT";

		// Token: 0x04001318 RID: 4888
		public const string TUNING_RX_WLEQUATION400HZ = "TUNING_RX_WLEQUATION400HZ";

		// Token: 0x04001319 RID: 4889
		public const string FLD_TUNING_RX_WLEQUATION400HZ_TUNINGFREQ = "FLD_TUNING_RX_WLEQUATION400HZ_TUNINGFREQ";

		// Token: 0x0400131A RID: 4890
		public const string FLD_TUNING_RX_WLEQUATION400HZ_TUNINGFREQ00 = "FLD_TUNING_RX_WLEQUATION400HZ_TUNINGFREQ00";

		// Token: 0x0400131B RID: 4891
		public const string FLD_TUNING_RX_WLEQUATION400HZ_SOFTPOT = "FLD_TUNING_RX_WLEQUATION400HZ_SOFTPOT";

		// Token: 0x0400131C RID: 4892
		public const string FLD_TUNING_RX_WLEQUATION400HZ_SOFTPOT00 = "FLD_TUNING_RX_WLEQUATION400HZ_SOFTPOT00";

		// Token: 0x0400131D RID: 4893
		public const string FLD_PREVPROGSFT_TUNING_RX_WLEQUATION400HZ_SOFTPOT = "FLD_PREVPROGSFT_TUNING_RX_WLEQUATION400HZ_SOFTPOT";

		// Token: 0x0400131E RID: 4894
		public const string FLD_PREVPROGSFT_TUNING_RX_WLEQUATION400HZ_SOFTPOT00 = "FLD_PREVPROGSFT_TUNING_RX_WLEQUATION400HZ_SOFTPOT00";

		// Token: 0x0400131F RID: 4895
		public const string LBL_TUNING_RX_WLEQUATION400HZ_TUNINGFREQ = "LBL_TUNING_RX_WLEQUATION400HZ_TUNINGFREQ";

		// Token: 0x04001320 RID: 4896
		public const string LBL_PREVPROGSFT_TUNING_RX_WLEQUATION400HZ_SOFTPOT = "LBL_PREVPROGSFT_TUNING_RX_WLEQUATION400HZ_SOFTPOT";

		// Token: 0x04001321 RID: 4897
		public const string LBL_TUNING_RX_WLEQUATION400HZ_SOFTPOT = "LBL_TUNING_RX_WLEQUATION400HZ_SOFTPOT";

		// Token: 0x04001322 RID: 4898
		public const string TUNING_RX_WLEQUATION2800HZ = "TUNING_RX_WLEQUATION2800HZ";

		// Token: 0x04001323 RID: 4899
		public const string FLD_TUNING_RX_WLEQUATION2800HZ_TUNINGFREQ = "FLD_TUNING_RX_WLEQUATION2800HZ_TUNINGFREQ";

		// Token: 0x04001324 RID: 4900
		public const string FLD_TUNING_RX_WLEQUATION2800HZ_TUNINGFREQ00 = "FLD_TUNING_RX_WLEQUATION2800HZ_TUNINGFREQ00";

		// Token: 0x04001325 RID: 4901
		public const string FLD_TUNING_RX_WLEQUATION2800HZ_SOFTPOT = "FLD_TUNING_RX_WLEQUATION2800HZ_SOFTPOT";

		// Token: 0x04001326 RID: 4902
		public const string FLD_TUNING_RX_WLEQUATION2800HZ_SOFTPOT00 = "FLD_TUNING_RX_WLEQUATION2800HZ_SOFTPOT00";

		// Token: 0x04001327 RID: 4903
		public const string FLD_PREVPROGSFT_TUNING_RX_WLEQUATION2800HZ_SOFTPOT = "FLD_PREVPROGSFT_TUNING_RX_WLEQUATION2800HZ_SOFTPOT";

		// Token: 0x04001328 RID: 4904
		public const string FLD_PREVPROGSFT_TUNING_RX_WLEQUATION2800HZ_SOFTPOT00 = "FLD_PREVPROGSFT_TUNING_RX_WLEQUATION2800HZ_SOFTPOT00";

		// Token: 0x04001329 RID: 4905
		public const string LBL_TUNING_RX_WLEQUATION2800HZ_TUNINGFREQ = "LBL_TUNING_RX_WLEQUATION2800HZ_TUNINGFREQ";

		// Token: 0x0400132A RID: 4906
		public const string LBL_PREVPROGSFT_TUNING_RX_WLEQUATION2800HZ_SOFTPOT = "LBL_PREVPROGSFT_TUNING_RX_WLEQUATION2800HZ_SOFTPOT";

		// Token: 0x0400132B RID: 4907
		public const string LBL_TUNING_RX_WLEQUATION2800HZ_SOFTPOT = "LBL_TUNING_RX_WLEQUATION2800HZ_SOFTPOT";

		// Token: 0x0400132C RID: 4908
		public const string TUNING_RX_WLSTATUSTONE = "TUNING_RX_WLSTATUSTONE";

		// Token: 0x0400132D RID: 4909
		public const string FLD_TUNING_RX_WLSTATUSTONE_TUNINGFREQ = "FLD_TUNING_RX_WLSTATUSTONE_TUNINGFREQ";

		// Token: 0x0400132E RID: 4910
		public const string FLD_TUNING_RX_WLSTATUSTONE_TUNINGFREQ00 = "FLD_TUNING_RX_WLSTATUSTONE_TUNINGFREQ00";

		// Token: 0x0400132F RID: 4911
		public const string FLD_TUNING_RX_WLSTATUSTONE_SOFTPOT = "FLD_TUNING_RX_WLSTATUSTONE_SOFTPOT";

		// Token: 0x04001330 RID: 4912
		public const string FLD_TUNING_RX_WLSTATUSTONE_SOFTPOT00 = "FLD_TUNING_RX_WLSTATUSTONE_SOFTPOT00";

		// Token: 0x04001331 RID: 4913
		public const string FLD_PREVPROGSFT_TUNING_RX_WLSTATUSTONE_SOFTPOT = "FLD_PREVPROGSFT_TUNING_RX_WLSTATUSTONE_SOFTPOT";

		// Token: 0x04001332 RID: 4914
		public const string FLD_PREVPROGSFT_TUNING_RX_WLSTATUSTONE_SOFTPOT00 = "FLD_PREVPROGSFT_TUNING_RX_WLSTATUSTONE_SOFTPOT00";

		// Token: 0x04001333 RID: 4915
		public const string LBL_TUNING_RX_WLSTATUSTONE_TUNINGFREQ = "LBL_TUNING_RX_WLSTATUSTONE_TUNINGFREQ";

		// Token: 0x04001334 RID: 4916
		public const string LBL_PREVPROGSFT_TUNING_RX_WLSTATUSTONE_SOFTPOT = "LBL_PREVPROGSFT_TUNING_RX_WLSTATUSTONE_SOFTPOT";

		// Token: 0x04001335 RID: 4917
		public const string LBL_TUNING_RX_WLSTATUSTONE_SOFTPOT = "LBL_TUNING_RX_WLSTATUSTONE_SOFTPOT";

		// Token: 0x04001336 RID: 4918
		public const string TUNING_TX_WLLEVEL = "TUNING_TX_WLLEVEL";

		// Token: 0x04001337 RID: 4919
		public const string FLD_TUNING_TX_WLLEVEL_TUNINGFREQ = "FLD_TUNING_TX_WLLEVEL_TUNINGFREQ";

		// Token: 0x04001338 RID: 4920
		public const string FLD_TUNING_TX_WLLEVEL_TUNINGFREQ00 = "FLD_TUNING_TX_WLLEVEL_TUNINGFREQ00";

		// Token: 0x04001339 RID: 4921
		public const string FLD_TUNING_TX_WLLEVEL_SOFTPOT = "FLD_TUNING_TX_WLLEVEL_SOFTPOT";

		// Token: 0x0400133A RID: 4922
		public const string FLD_TUNING_TX_WLLEVEL_SOFTPOT00 = "FLD_TUNING_TX_WLLEVEL_SOFTPOT00";

		// Token: 0x0400133B RID: 4923
		public const string FLD_PREVPROGSFT_TUNING_TX_WLLEVEL_SOFTPOT = "FLD_PREVPROGSFT_TUNING_TX_WLLEVEL_SOFTPOT";

		// Token: 0x0400133C RID: 4924
		public const string FLD_PREVPROGSFT_TUNING_TX_WLLEVEL_SOFTPOT00 = "FLD_PREVPROGSFT_TUNING_TX_WLLEVEL_SOFTPOT00";

		// Token: 0x0400133D RID: 4925
		public const string LBL_TUNING_TX_WLLEVEL_TUNINGFREQ = "LBL_TUNING_TX_WLLEVEL_TUNINGFREQ";

		// Token: 0x0400133E RID: 4926
		public const string LBL_PREVPROGSFT_TUNING_TX_WLLEVEL_SOFTPOT = "LBL_PREVPROGSFT_TUNING_TX_WLLEVEL_SOFTPOT";

		// Token: 0x0400133F RID: 4927
		public const string LBL_TUNING_TX_WLLEVEL_SOFTPOT = "LBL_TUNING_TX_WLLEVEL_SOFTPOT";

		// Token: 0x04001340 RID: 4928
		public const string TUNING_TX_SQUELCHLEVEL = "TUNING_TX_SQUELCHLEVEL";

		// Token: 0x04001341 RID: 4929
		public const string FLD_TUNING_TX_SQUELCHLEVEL_TUNINGFREQ = "FLD_TUNING_TX_SQUELCHLEVEL_TUNINGFREQ";

		// Token: 0x04001342 RID: 4930
		public const string FLD_TUNING_TX_SQUELCHLEVEL_TUNINGFREQ00 = "FLD_TUNING_TX_SQUELCHLEVEL_TUNINGFREQ00";

		// Token: 0x04001343 RID: 4931
		public const string FLD_TUNING_TX_SQUELCHLEVEL_SOFTPOT = "FLD_TUNING_TX_SQUELCHLEVEL_SOFTPOT";

		// Token: 0x04001344 RID: 4932
		public const string FLD_TUNING_TX_SQUELCHLEVEL_SOFTPOT00 = "FLD_TUNING_TX_SQUELCHLEVEL_SOFTPOT00";

		// Token: 0x04001345 RID: 4933
		public const string FLD_PREVPROGSFT_TUNING_TX_SQUELCHLEVEL_SOFTPOT = "FLD_PREVPROGSFT_TUNING_TX_SQUELCHLEVEL_SOFTPOT";

		// Token: 0x04001346 RID: 4934
		public const string FLD_PREVPROGSFT_TUNING_TX_SQUELCHLEVEL_SOFTPOT00 = "FLD_PREVPROGSFT_TUNING_TX_SQUELCHLEVEL_SOFTPOT00";

		// Token: 0x04001347 RID: 4935
		public const string LBL_TUNING_TX_SQUELCHLEVEL_TUNINGFREQ = "LBL_TUNING_TX_SQUELCHLEVEL_TUNINGFREQ";

		// Token: 0x04001348 RID: 4936
		public const string LBL_PREVPROGSFT_TUNING_TX_SQUELCHLEVEL_SOFTPOT = "LBL_PREVPROGSFT_TUNING_TX_SQUELCHLEVEL_SOFTPOT";

		// Token: 0x04001349 RID: 4937
		public const string LBL_TUNING_TX_SQUELCHLEVEL_SOFTPOT = "LBL_TUNING_TX_SQUELCHLEVEL_SOFTPOT";

		// Token: 0x0400134A RID: 4938
		public const string LEGACY_DCA_CENTER_PLACEHOLDER = "               ";

		// Token: 0x0400134B RID: 4939
		public const string DCA_PLACEHOLDER = "      ";

		// Token: 0x0400134C RID: 4940
		public const string DEVICE_INFO = "DEVICE_INFO";

		// Token: 0x0400134D RID: 4941
		public const string RS_SERIALNUM_RX_BOARD = "RS_SERIALNUM_RX_BOARD";

		// Token: 0x0400134E RID: 4942
		public const string TUNING_RX = "TUNING_RX";

		// Token: 0x0400134F RID: 4943
		public const string TUNING_TX = "TUNING_TX";

		// Token: 0x04001350 RID: 4944
		public const string TUNING_RX_FEF = "TUNING_RX_FEF";

		// Token: 0x04001351 RID: 4945
		public const string FLD_TUNING_RX_FEF_TUNINGFREQ = "FLD_TUNING_RX_FEF_TUNINGFREQ";

		// Token: 0x04001352 RID: 4946
		public const string FLD_TUNING_RX_FEF_TUNINGFREQ00 = "FLD_TUNING_RX_FEF_TUNINGFREQ00";

		// Token: 0x04001353 RID: 4947
		public const string FLD_TUNING_RX_FEF_RSSI = "FLD_TUNING_RX_FEF_RSSI";

		// Token: 0x04001354 RID: 4948
		public const string CBO_TUNING_RX_AUDIO = "CBO_TUNING_RX_AUDIO";

		// Token: 0x04001355 RID: 4949
		public const string FLD_TUNING_RX_FEF_SOFTPOT = "FLD_TUNING_RX_FEF_SOFTPOT";

		// Token: 0x04001356 RID: 4950
		public const string FLD_TUNING_RX_FEF_SOFTPOT00 = "FLD_TUNING_RX_FEF_SOFTPOT00";

		// Token: 0x04001357 RID: 4951
		public const string FLD_TUNING_RX_FEF_SOFTPOT01 = "FLD_TUNING_RX_FEF_SOFTPOT01";

		// Token: 0x04001358 RID: 4952
		public const string FLD_TUNING_RX_FEF_SOFTPOT02 = "FLD_TUNING_RX_FEF_SOFTPOT02";

		// Token: 0x04001359 RID: 4953
		public const string FLD_TUNING_RX_FEF_SOFTPOT03 = "FLD_TUNING_RX_FEF_SOFTPOT03";

		// Token: 0x0400135A RID: 4954
		public const string FLD_TUNING_RX_FEF_SOFTPOT04 = "FLD_TUNING_RX_FEF_SOFTPOT04";

		// Token: 0x0400135B RID: 4955
		public const string FLD_TUNING_RX_FEF_SOFTPOT05 = "FLD_TUNING_RX_FEF_SOFTPOT05";

		// Token: 0x0400135C RID: 4956
		public const string FLD_TUNING_RX_FEF_SOFTPOT06 = "FLD_TUNING_RX_FEF_SOFTPOT06";

		// Token: 0x0400135D RID: 4957
		public const string FLD_TUNING_RX_FEF_SOFTPOT07 = "FLD_TUNING_RX_FEF_SOFTPOT07";

		// Token: 0x0400135E RID: 4958
		public const string FLD_TUNING_RX_FEF_SOFTPOT08 = "FLD_TUNING_RX_FEF_SOFTPOT08";

		// Token: 0x0400135F RID: 4959
		public const string FLD_TUNING_RX_FEF_SOFTPOT09 = "FLD_TUNING_RX_FEF_SOFTPOT09";

		// Token: 0x04001360 RID: 4960
		public const string FLD_TUNING_RX_FEF_SOFTPOT10 = "FLD_TUNING_RX_FEF_SOFTPOT10";

		// Token: 0x04001361 RID: 4961
		public const string FLD_PREVPROGSFT_TUNING_RX_FEF_SOFTPOT = "FLD_PREVPROGSFT_TUNING_RX_FEF_SOFTPOT";

		// Token: 0x04001362 RID: 4962
		public const string FLD_PREVPROGSFT_TUNING_RX_FEF_SOFTPOT00 = "FLD_PREVPROGSFT_TUNING_RX_FEF_SOFTPOT00";

		// Token: 0x04001363 RID: 4963
		public const string FLD_PREVPROGSFT_TUNING_RX_FEF_SOFTPOT01 = "FLD_PREVPROGSFT_TUNING_RX_FEF_SOFTPOT01";

		// Token: 0x04001364 RID: 4964
		public const string FLD_PREVPROGSFT_TUNING_RX_FEF_SOFTPOT02 = "FLD_PREVPROGSFT_TUNING_RX_FEF_SOFTPOT02";

		// Token: 0x04001365 RID: 4965
		public const string FLD_PREVPROGSFT_TUNING_RX_FEF_SOFTPOT03 = "FLD_PREVPROGSFT_TUNING_RX_FEF_SOFTPOT03";

		// Token: 0x04001366 RID: 4966
		public const string FLD_PREVPROGSFT_TUNING_RX_FEF_SOFTPOT04 = "FLD_PREVPROGSFT_TUNING_RX_FEF_SOFTPOT04";

		// Token: 0x04001367 RID: 4967
		public const string FLD_PREVPROGSFT_TUNING_RX_FEF_SOFTPOT05 = "FLD_PREVPROGSFT_TUNING_RX_FEF_SOFTPOT05";

		// Token: 0x04001368 RID: 4968
		public const string FLD_PREVPROGSFT_TUNING_RX_FEF_SOFTPOT06 = "FLD_PREVPROGSFT_TUNING_RX_FEF_SOFTPOT06";

		// Token: 0x04001369 RID: 4969
		public const string FLD_PREVPROGSFT_TUNING_RX_FEF_SOFTPOT07 = "FLD_PREVPROGSFT_TUNING_RX_FEF_SOFTPOT07";

		// Token: 0x0400136A RID: 4970
		public const string FLD_PREVPROGSFT_TUNING_RX_FEF_SOFTPOT08 = "FLD_PREVPROGSFT_TUNING_RX_FEF_SOFTPOT08";

		// Token: 0x0400136B RID: 4971
		public const string FLD_PREVPROGSFT_TUNING_RX_FEF_SOFTPOT09 = "FLD_PREVPROGSFT_TUNING_RX_FEF_SOFTPOT09";

		// Token: 0x0400136C RID: 4972
		public const string FLD_PREVPROGSFT_TUNING_RX_FEF_SOFTPOT10 = "FLD_PREVPROGSFT_TUNING_RX_FEF_SOFTPOT10";

		// Token: 0x0400136D RID: 4973
		public const string TUNING_TX_BANDITPWR = "TUNING_TX_BANDITPWR";

		// Token: 0x0400136E RID: 4974
		public const string STR_00 = "00";

		// Token: 0x0400136F RID: 4975
		public const short MAX_FREQ_NUMBER9 = 9;

		// Token: 0x04001370 RID: 4976
		public const short MAX_FREQ_NUMBER7 = 7;

		// Token: 0x04001371 RID: 4977
		public const string BTN_TUNING_RX_FEF_SOFTPOT = "BTN_TUNING_RX_FEF_SOFTPOT";

		// Token: 0x04001372 RID: 4978
		public const string BTN_TUNING_RX_FEF_SOFTPOT00 = "BTN_TUNING_RX_FEF_SOFTPOT00";

		// Token: 0x04001373 RID: 4979
		public const string BTN_TUNING_RX_FEF_SOFTPOT01 = "BTN_TUNING_RX_FEF_SOFTPOT01";

		// Token: 0x04001374 RID: 4980
		public const string BTN_TUNING_RX_FEF_SOFTPOT02 = "BTN_TUNING_RX_FEF_SOFTPOT02";

		// Token: 0x04001375 RID: 4981
		public const string BTN_TUNING_RX_FEF_SOFTPOT03 = "BTN_TUNING_RX_FEF_SOFTPOT03";

		// Token: 0x04001376 RID: 4982
		public const string BTN_TUNING_RX_FEF_SOFTPOT04 = "BTN_TUNING_RX_FEF_SOFTPOT04";

		// Token: 0x04001377 RID: 4983
		public const string BTN_TUNING_RX_FEF_SOFTPOT05 = "BTN_TUNING_RX_FEF_SOFTPOT05";

		// Token: 0x04001378 RID: 4984
		public const string BTN_TUNING_RX_FEF_SOFTPOT06 = "BTN_TUNING_RX_FEF_SOFTPOT06";

		// Token: 0x04001379 RID: 4985
		public const string BTN_TUNING_RX_FEF_SOFTPOT07 = "BTN_TUNING_RX_FEF_SOFTPOT07";

		// Token: 0x0400137A RID: 4986
		public const string BTN_TUNING_RX_FEF_SOFTPOT08 = "BTN_TUNING_RX_FEF_SOFTPOT08";

		// Token: 0x0400137B RID: 4987
		public const string BTN_TUNING_RX_FEF_SOFTPOT09 = "BTN_TUNING_RX_FEF_SOFTPOT09";

		// Token: 0x0400137C RID: 4988
		public const string BTN_TUNING_RX_FEF_SOFTPOT10 = "BTN_TUNING_RX_FEF_SOFTPOT10";

		// Token: 0x0400137D RID: 4989
		public const string FLD_TUNING_RX_FEF_NOMINAL_DAC = "FLD_TUNING_RX_FEF_NOMINAL_DAC";

		// Token: 0x0400137E RID: 4990
		public const string CBO_TUNING_RX_BER_BAND = "CBO_TUNING_RX_BER_BAND";

		// Token: 0x0400137F RID: 4991
		public const string CBO_TUNING_RX_LQC_BAND = "CBO_TUNING_RX_LQC_BAND";

		// Token: 0x04001380 RID: 4992
		public const string CBO_TUNING_RX_RFT_BAND = "CBO_TUNING_RX_RFT_BAND";

		// Token: 0x04001381 RID: 4993
		public const string CBO_TUNING_TX_BER_BAND = "CBO_TUNING_TX_BER_BAND";

		// Token: 0x04001382 RID: 4994
		public const string CBO_TUNING_RX_DA_BAND = "CBO_TUNING_RX_DA_BAND";

		// Token: 0x04001383 RID: 4995
		public const string CBO_TUNING_RX_SINADTEST_BAND = "CBO_TUNING_RX_SINADTEST_BAND";

		// Token: 0x04001384 RID: 4996
		public const string CBO_TUNING_TX_SINADTEST_BAND = "CBO_TUNING_TX_SINADTEST_BAND";

		// Token: 0x04001385 RID: 4997
		public const string CHANNELBANDWIDTH_800 = "CHANNELBANDWIDTH_800";

		// Token: 0x04001386 RID: 4998
		public const string CHANNELBANDWIDTH_FRI1 = "CHANNELBANDWIDTH_FRI1";

		// Token: 0x04001387 RID: 4999
		public const string TUNING_RX_RATVOL = "TUNING_RX_RATVOL";

		// Token: 0x04001388 RID: 5000
		public const string FLD_TUNING_RX_RATVOL_TUNINGFREQ = "FLD_TUNING_RX_RATVOL_TUNINGFREQ";

		// Token: 0x04001389 RID: 5001
		public const string FLD_TUNING_RX_RATVOL_TUNINGFREQ00 = "FLD_TUNING_RX_RATVOL_TUNINGFREQ00";

		// Token: 0x0400138A RID: 5002
		public const string FLD_TUNING_RX_RATVOL_SOFTPOT = "FLD_TUNING_RX_RATVOL_SOFTPOT";

		// Token: 0x0400138B RID: 5003
		public const string FLD_TUNING_RX_RATVOL_SOFTPOT00 = "FLD_TUNING_RX_RATVOL_SOFTPOT00";

		// Token: 0x0400138C RID: 5004
		public const string FLD_PREVPROGSFT_TUNING_RX_RATVOL_SOFTPOT = "FLD_PREVPROGSFT_TUNING_RX_RATVOL_SOFTPOT";

		// Token: 0x0400138D RID: 5005
		public const string TUNING_TX_REFOSC = "TUNING_TX_REFOSC";

		// Token: 0x0400138E RID: 5006
		public const string FLD_TUNING_TX_REFOSC_TUNINGFREQ = "FLD_TUNING_TX_REFOSC_TUNINGFREQ";

		// Token: 0x0400138F RID: 5007
		public const string FLD_TUNING_TX_REFOSC_TUNINGFREQ00 = "FLD_TUNING_TX_REFOSC_TUNINGFREQ00";

		// Token: 0x04001390 RID: 5008
		public const string FLD_TUNING_TX_REFOSC_SOFTPOT = "FLD_TUNING_TX_REFOSC_SOFTPOT";

		// Token: 0x04001391 RID: 5009
		public const string FLD_TUNING_TX_REFOSC_SOFTPOT00 = "FLD_TUNING_TX_REFOSC_SOFTPOT00";

		// Token: 0x04001392 RID: 5010
		public const string FLD_TUNING_TX_REFOSC_TUNINGFREQ_GEMSTONE = "FLD_TUNING_TX_REFOSC_TUNINGFREQ_GEMSTONE";

		// Token: 0x04001393 RID: 5011
		public const string FLD_TUNING_TX_REFOSC_MEASURED_FREQ = "FLD_TUNING_TX_REFOSC_MEASURED_FREQ";

		// Token: 0x04001394 RID: 5012
		public const string FLD_PREVPROGSFT_TUNING_TX_REFOSC_SOFTPOT = "FLD_PREVPROGSFT_TUNING_TX_REFOSC_SOFTPOT";

		// Token: 0x04001395 RID: 5013
		public const string FLD_TUNING_TX_VCBPWRHI_TUNINGVOLTAGE = "FLD_TUNING_TX_VCBPWRHI_TUNINGVOLTAGE";

		// Token: 0x04001396 RID: 5014
		public const string TUNING_TX_PWRHI = "TUNING_TX_PWRHI";

		// Token: 0x04001397 RID: 5015
		public const string FLD_TUNING_TX_PWRHI_TUNINGFREQ = "FLD_TUNING_TX_PWRHI_TUNINGFREQ";

		// Token: 0x04001398 RID: 5016
		public const string FLD_TUNING_TX_PWRHI_TUNINGFREQ00 = "FLD_TUNING_TX_PWRHI_TUNINGFREQ00";

		// Token: 0x04001399 RID: 5017
		public const string FLD_TUNING_TX_PWRHI_SOFTPOT = "FLD_TUNING_TX_PWRHI_SOFTPOT";

		// Token: 0x0400139A RID: 5018
		public const string FLD_TUNING_TX_PWRHI_SOFTPOT00 = "FLD_TUNING_TX_PWRHI_SOFTPOT00";

		// Token: 0x0400139B RID: 5019
		public const string FLD_PREVPROGSFT_TUNING_TX_PWRHI_SOFTPOT = "FLD_PREVPROGSFT_TUNING_TX_PWRHI_SOFTPOT";

		// Token: 0x0400139C RID: 5020
		public const string CBO_TUNING_TX_PWRHI_OPTION = "CBO_TUNING_TX_PWRHI_OPTION";

		// Token: 0x0400139D RID: 5021
		public const string TUNING_TX_PWRLOW = "TUNING_TX_PWRLOW";

		// Token: 0x0400139E RID: 5022
		public const string FLD_TUNING_TX_PWRLOW_TUNINGFREQ = "FLD_TUNING_TX_PWRLOW_TUNINGFREQ";

		// Token: 0x0400139F RID: 5023
		public const string FLD_TUNING_TX_PWRLOW_TUNINGFREQ00 = "FLD_TUNING_TX_PWRLOW_TUNINGFREQ00";

		// Token: 0x040013A0 RID: 5024
		public const string TUNING_TX_PWRMID_INTERNAL2W = "TUNING_TX_PWRMID_INTERNAL2W";

		// Token: 0x040013A1 RID: 5025
		public const string TUNING_TX_PWRMID = "TUNING_TX_PWRMID";

		// Token: 0x040013A2 RID: 5026
		public const string FLD_TUNING_TX_PWRMID_TUNINGFREQ = "FLD_TUNING_TX_PWRMID_TUNINGFREQ";

		// Token: 0x040013A3 RID: 5027
		public const string FLD_TUNING_TX_PWRMID_SOFTPOT = "FLD_TUNING_TX_PWRMID_SOFTPOT";

		// Token: 0x040013A4 RID: 5028
		public const string FLD_PREVPROGSFT_TUNING_TX_PWRMID_SOFTPOT = "FLD_PREVPROGSFT_TUNING_TX_PWRMID_SOFTPOT";

		// Token: 0x040013A5 RID: 5029
		public const string FLD_TUNING_TX_PWRMID_TUNINGFREQ00 = "FLD_TUNING_TX_PWRMID_TUNINGFREQ00";

		// Token: 0x040013A6 RID: 5030
		public const string FLD_TUNING_TX_PWRMID_SOFTPOT00 = "FLD_TUNING_TX_PWRMID_SOFTPOT00";

		// Token: 0x040013A7 RID: 5031
		public const string FLD_TUNING_TX_PWRLOW_SOFTPOT = "FLD_TUNING_TX_PWRLOW_SOFTPOT";

		// Token: 0x040013A8 RID: 5032
		public const string FLD_TUNING_TX_PWRLOW_SOFTPOT00 = "FLD_TUNING_TX_PWRLOW_SOFTPOT00";

		// Token: 0x040013A9 RID: 5033
		public const string FLD_PREVPROGSFT_TUNING_TX_PWRLOW_SOFTPOT = "FLD_PREVPROGSFT_TUNING_TX_PWRLOW_SOFTPOT";

		// Token: 0x040013AA RID: 5034
		public const string TUNING_TX_PWR05LOW = "TUNING_TX_PWR05LOW";

		// Token: 0x040013AB RID: 5035
		public const string FLD_TUNING_TX_PWR05LOW_TUNINGFREQ = "FLD_TUNING_TX_PWR05LOW_TUNINGFREQ";

		// Token: 0x040013AC RID: 5036
		public const string FLD_TUNING_TX_PWR05LOW_SOFTPOT = "FLD_TUNING_TX_PWR05LOW_SOFTPOT";

		// Token: 0x040013AD RID: 5037
		public const string FLD_PREVPROGSFT_TUNING_TX_PWR05LOW_SOFTPOT = "FLD_PREVPROGSFT_TUNING_TX_PWR05LOW_SOFTPOT";

		// Token: 0x040013AE RID: 5038
		public const string FLD_TUNING_TX_PWR05LOW_SOFTPOT00 = "FLD_TUNING_TX_PWR05LOW_SOFTPOT00";

		// Token: 0x040013AF RID: 5039
		public const string FLD_TUNING_TX_PWR05LOW_TUNINGFREQ00 = "FLD_TUNING_TX_PWR05LOW_TUNINGFREQ00";

		// Token: 0x040013B0 RID: 5040
		public const string TUNING_TX_MODBAL = "TUNING_TX_MODBAL";

		// Token: 0x040013B1 RID: 5041
		public const string TUNING_TX_MODBAL_DUPLEX = "TUNING_TX_MODBAL_DUPLEX";

		// Token: 0x040013B2 RID: 5042
		public const string FLD_TUNING_TX_MODBAL_TUNINGFREQ = "FLD_TUNING_TX_MODBAL_TUNINGFREQ";

		// Token: 0x040013B3 RID: 5043
		public const string FLD_TUNING_TX_MODBAL_TUNINGFREQ00 = "FLD_TUNING_TX_MODBAL_TUNINGFREQ00";

		// Token: 0x040013B4 RID: 5044
		public const string FLD_TUNING_TX_MODBAL_SOFTPOT = "FLD_TUNING_TX_MODBAL_SOFTPOT";

		// Token: 0x040013B5 RID: 5045
		public const string FLD_TUNING_TX_MODBAL_SOFTPOT00 = "FLD_TUNING_TX_MODBAL_SOFTPOT00";

		// Token: 0x040013B6 RID: 5046
		public const string FLD_PREVPROGSFT_TUNING_TX_MODBAL_SOFTPOT = "FLD_PREVPROGSFT_TUNING_TX_MODBAL_SOFTPOT";

		// Token: 0x040013B7 RID: 5047
		public const string CBO_TUNING_TX_MODBAL_TONE = "CBO_TUNING_TX_MODBAL_TONE";

		// Token: 0x040013B8 RID: 5048
		public const string FLD_TUNING_TX_MODBAL_SOFTPOT07 = "FLD_TUNING_TX_MODBAL_SOFTPOT07";

		// Token: 0x040013B9 RID: 5049
		public const string TUNING_RX_BER = "TUNING_RX_BER";

		// Token: 0x040013BA RID: 5050
		public const string FLD_TUNING_RX_BER_TUNINGFREQ = "FLD_TUNING_RX_BER_TUNINGFREQ";

		// Token: 0x040013BB RID: 5051
		public const string FLD_TUNING_RX_BER_INTEGRATIONTIME = "FLD_TUNING_RX_BER_INTEGRATIONTIME";

		// Token: 0x040013BC RID: 5052
		public const string FLD_TUNING_RX_BER_NOOFSUPERFRAMES = "FLD_TUNING_RX_BER_NOOFSUPERFRAMES";

		// Token: 0x040013BD RID: 5053
		public const string FLD_TUNING_RX_BER_NOOFSAMPLES = "FLD_TUNING_RX_BER_NOOFSAMPLES";

		// Token: 0x040013BE RID: 5054
		public const string CBO_TUNING_RX_BER_MODTYPE = "CBO_TUNING_RX_BER_MODTYPE";

		// Token: 0x040013BF RID: 5055
		public const string CBO_TUNING_RX_BER_TESTPATTERN = "CBO_TUNING_RX_BER_TESTPATTERN";

		// Token: 0x040013C0 RID: 5056
		public const string CBO_TUNING_RX_BER_CONTOPER = "CBO_TUNING_RX_BER_CONTOPER";

		// Token: 0x040013C1 RID: 5057
		public const string CBO_TUNING_RX_BER_AUDIO = "CBO_TUNING_RX_BER_AUDIO";

		// Token: 0x040013C2 RID: 5058
		public const string FLD_TUNING_RX_NOOFBITERRORS = "FLD_TUNING_RX_NOOFBITERRORS";

		// Token: 0x040013C3 RID: 5059
		public const string FLD_TUNING_RX_PERCENTAGEOFBITERRORS = "FLD_TUNING_RX_PERCENTAGEOFBITERRORS";

		// Token: 0x040013C4 RID: 5060
		public const string FLD_TUNING_RX_BER_TESTING_REPORT_NOOFBITERRORS = "FLD_TUNING_RX_BER_TESTING_REPORT_NOOFBITERRORS";

		// Token: 0x040013C5 RID: 5061
		public const string FLD_TUNING_RX_BER_TESTING_REPORT_PERCENTAGEOFBITERRORS = "FLD_TUNING_RX_BER_TESTING_REPORT_PERCENTAGEOFBITERRORS";

		// Token: 0x040013C6 RID: 5062
		public const string FLD_TUNING_RX_CURRENTSAMPLECOUNT = "FLD_TUNING_RX_CURRENTSAMPLECOUNT";

		// Token: 0x040013C7 RID: 5063
		public const string FLD_TUNING_RX_ACCBERCOUNT = "FLD_TUNING_RX_ACCBERCOUNT";

		// Token: 0x040013C8 RID: 5064
		public const string FLD_TUNING_RX_ACCBERPERCENTAGE = "FLD_TUNING_RX_ACCBERPERCENTAGE";

		// Token: 0x040013C9 RID: 5065
		public const string FLD_TUNING_RX_ACCFRAMEFAILURECOUNT = "FLD_TUNING_RX_ACCFRAMEFAILURECOUNT";

		// Token: 0x040013CA RID: 5066
		public const string FLD_TUNING_RX_ACCFRAMEFAILUREPERCENTAGE = "FLD_TUNING_RX_ACCFRAMEFAILUREPERCENTAGE";

		// Token: 0x040013CB RID: 5067
		public const string FLD_TUNING_RX_BERTAG = "FLD_TUNING_RX_BERTAG";

		// Token: 0x040013CC RID: 5068
		public const string FLD_TUNING_RX_BERSLOT = "FLD_TUNING_RX_BERSLOT";

		// Token: 0x040013CD RID: 5069
		public const string FLD_TUNING_RX_BERSYNCSTATUS = "FLD_TUNING_RX_BERSYNCSTATUS";

		// Token: 0x040013CE RID: 5070
		public const string BERNONCONTINUOUS = "BERNONCONTINUOUS";

		// Token: 0x040013CF RID: 5071
		public const string BTN_TUNING_RX_BER_STARTSTOP = "BTN_TUNING_RX_BER_STARTSTOP";

		// Token: 0x040013D0 RID: 5072
		public const string LBL_TUNING_RX_BER_SYNCSTATUS = "LBL_TUNING_RX_BER_SYNCSTATUS";

		// Token: 0x040013D1 RID: 5073
		public const string RX_BER_RESULT_SYNC_DETECTED = "RX_BER_RESULT_SYNC_DETECTED";

		// Token: 0x040013D2 RID: 5074
		public const string RX_BER_RESULT_SYNC_NOT_DETECTED = "RX_BER_RESULT_SYNC_NOT_DETECTED";

		// Token: 0x040013D3 RID: 5075
		public const string RX_BER_O153_TESTPATTERN = "RX_DGTL_TESTPATTERN_LTDF2_O153_SUPERFRAME";

		// Token: 0x040013D4 RID: 5076
		public const string RX_BER_CONTINUOUS = "BERCONTINUOUS";

		// Token: 0x040013D5 RID: 5077
		public const string RX_BER_NONCONTINUOUS = "BERNONCONTINUOUS";

		// Token: 0x040013D6 RID: 5078
		public const string RX_BER_MUTE = "BERMUTE";

		// Token: 0x040013D7 RID: 5079
		public const string RX_BER_UNMUTE = "BERUNMUTE";

		// Token: 0x040013D8 RID: 5080
		public const string RX_BER_DATAGRIDVIEW_TYPE = "RX_BER_DATAGRIDVIEW_TYPE";

		// Token: 0x040013D9 RID: 5081
		public const string RX_BER_TAG = "RX_BER_TAG";

		// Token: 0x040013DA RID: 5082
		public const string RX_BIT_ERROR_COUNT = "RX_BIT_ERROR_COUNT";

		// Token: 0x040013DB RID: 5083
		public const string RX_SYNC_STATUS = "RX_SYNC_STATUS";

		// Token: 0x040013DC RID: 5084
		public const string RX_FRAME_BIT_ERROR_PERCENT = "RX_FRAME_BIT_ERROR_PERCENT";

		// Token: 0x040013DD RID: 5085
		public const string CBO_TUNING_RX_BER_DUALSLOT = "CBO_TUNING_RX_BER_DUALSLOT";

		// Token: 0x040013DE RID: 5086
		public const string FLD_TUNING_RX_CURRENTSAMPLECOUNT_SLOT2 = "FLD_TUNING_RX_CURRENTSAMPLECOUNT_SLOT2";

		// Token: 0x040013DF RID: 5087
		public const string FLD_TUNING_RX_ACCFRAMEFAILURECOUNT_SLOT2 = "FLD_TUNING_RX_ACCFRAMEFAILURECOUNT_SLOT2";

		// Token: 0x040013E0 RID: 5088
		public const string FLD_TUNING_RX_ACCBERCOUNT_SLOT2 = "FLD_TUNING_RX_ACCBERCOUNT_SLOT2";

		// Token: 0x040013E1 RID: 5089
		public const string FLD_TUNING_RX_ACCBERPERCENTAGE_SLOT2 = "FLD_TUNING_RX_ACCBERPERCENTAGE_SLOT2";

		// Token: 0x040013E2 RID: 5090
		public const string FLD_TUNING_RX_ACCFRAMEFAILUREPERCENTAGE_SLOT2 = "FLD_TUNING_RX_ACCFRAMEFAILUREPERCENTAGE_SLOT2";

		// Token: 0x040013E3 RID: 5091
		public const string DUALSLOT_NONE = "DUALSLOT_NONE";

		// Token: 0x040013E4 RID: 5092
		public const string DUALSLOT_SLOT1 = "DUALSLOT_SLOT1";

		// Token: 0x040013E5 RID: 5093
		public const string DUALSLOT_SLOT2 = "DUALSLOT_SLOT2";

		// Token: 0x040013E6 RID: 5094
		public const string DUALSLOT_BOTH = "DUALSLOT_BOTH";

		// Token: 0x040013E7 RID: 5095
		public const string TUNING_DUALSLOTBER = "TUNING_DUALSLOTBER";

		// Token: 0x040013E8 RID: 5096
		public const string BTN_TUNING_TX_BER_STARTSTOP = "BTN_TUNING_TX_BER_STARTSTOP";

		// Token: 0x040013E9 RID: 5097
		public const string CBO_TUNING_TX_BER_TESTPATTERN_DUALSLOT = "CBO_TUNING_TX_BER_TESTPATTERN_DUALSLOT";

		// Token: 0x040013EA RID: 5098
		public const string CBO_TUNING_TX_BER_DUALSLOT = "CBO_TUNING_TX_BER_DUALSLOT";

		// Token: 0x040013EB RID: 5099
		public const string CBO_TUNING_RX_BER_TESTPATTERN_DUALSLOT = "CBO_TUNING_RX_BER_TESTPATTERN_DUALSLOT";

		// Token: 0x040013EC RID: 5100
		public const string RX_BER_SLOT = "RX_BER_SLOT";

		// Token: 0x040013ED RID: 5101
		public const string TUNING_TX_BER = "TUNING_TX_BER";

		// Token: 0x040013EE RID: 5102
		public const string FLD_TUNING_TX_BER_TUNINGFREQ = "FLD_TUNING_TX_BER_TUNINGFREQ";

		// Token: 0x040013EF RID: 5103
		public const string CBO_TUNING_TX_BER_TESTPATTERN = "CBO_TUNING_TX_BER_TESTPATTERN";

		// Token: 0x040013F0 RID: 5104
		public const string CBO_TUNING_TX_BER_PWRLEVEL = "CBO_TUNING_TX_BER_PWRLEVEL";

		// Token: 0x040013F1 RID: 5105
		public const string TUNING_TX_PABIAS = "TUNING_TX_PABIAS";

		// Token: 0x040013F2 RID: 5106
		public const string TUNING_TX_PABIAS1 = "TUNING_TX_PABIAS1";

		// Token: 0x040013F3 RID: 5107
		public const string FLD_TUNING_TX_PABIAS1_TUNINGFREQ = "FLD_TUNING_TX_PABIAS1_TUNINGFREQ";

		// Token: 0x040013F4 RID: 5108
		public const string FLD_TUNING_TX_PABIAS1_TUNINGFREQ00 = "FLD_TUNING_TX_PABIAS1_TUNINGFREQ00";

		// Token: 0x040013F5 RID: 5109
		public const string FLD_TUNING_TX_PABIAS1_TUNINGFREQ01 = "FLD_TUNING_TX_PABIAS1_TUNINGFREQ01";

		// Token: 0x040013F6 RID: 5110
		public const string FLD_TUNING_TX_PABIAS1_SOFTPOT = "FLD_TUNING_TX_PABIAS1_SOFTPOT";

		// Token: 0x040013F7 RID: 5111
		public const string FLD_TUNING_TX_PABIAS1_SOFTPOT00 = "FLD_TUNING_TX_PABIAS1_SOFTPOT00";

		// Token: 0x040013F8 RID: 5112
		public const string FLD_TUNING_TX_PABIAS1_SOFTPOT01 = "FLD_TUNING_TX_PABIAS1_SOFTPOT01";

		// Token: 0x040013F9 RID: 5113
		public const string FLD_PREVPROGSFT_TUNING_TX_PABIAS1_SOFTPOT = "FLD_PREVPROGSFT_TUNING_TX_PABIAS1_SOFTPOT";

		// Token: 0x040013FA RID: 5114
		public const string TUNING_TX_PABIAS2 = "TUNING_TX_PABIAS2";

		// Token: 0x040013FB RID: 5115
		public const string FLD_TUNING_TX_PABIAS2_TUNINGFREQ = "FLD_TUNING_TX_PABIAS2_TUNINGFREQ";

		// Token: 0x040013FC RID: 5116
		public const string FLD_TUNING_TX_PABIAS2_TUNINGFREQ00 = "FLD_TUNING_TX_PABIAS2_TUNINGFREQ00";

		// Token: 0x040013FD RID: 5117
		public const string FLD_TUNING_TX_PABIAS2_SOFTPOT = "FLD_TUNING_TX_PABIAS2_SOFTPOT";

		// Token: 0x040013FE RID: 5118
		public const string FLD_TUNING_TX_PABIAS2_SOFTPOT00 = "FLD_TUNING_TX_PABIAS2_SOFTPOT00";

		// Token: 0x040013FF RID: 5119
		public const string FLD_PREVPROGSFT_TUNING_TX_PABIAS2_SOFTPOT = "FLD_PREVPROGSFT_TUNING_TX_PABIAS2_SOFTPOT";

		// Token: 0x04001400 RID: 5120
		public const string TUNING_TX_MOBILEPWR = "TUNING_TX_MOBILEPWR";

		// Token: 0x04001401 RID: 5121
		public const string FLD_TUNING_TX_MOBILEPWR_TUNINGFREQ = "FLD_TUNING_TX_MOBILEPWR_TUNINGFREQ";

		// Token: 0x04001402 RID: 5122
		public const string FLD_TUNING_TX_MOBILEPWR_TUNINGFREQ00 = "FLD_TUNING_TX_MOBILEPWR_TUNINGFREQ00";

		// Token: 0x04001403 RID: 5123
		public const string FLD_TUNING_TX_MOBILEPWR_LOWPWR = "FLD_TUNING_TX_MOBILEPWR_LOWPWR";

		// Token: 0x04001404 RID: 5124
		public const string FLD_TUNING_TX_MOBILEPWR_LOWPWR00 = "FLD_TUNING_TX_MOBILEPWR_LOWPWR00";

		// Token: 0x04001405 RID: 5125
		public const string FLD_TUNING_TX_MOBILEPWR_LOWPWR01 = "FLD_TUNING_TX_MOBILEPWR_LOWPWR01";

		// Token: 0x04001406 RID: 5126
		public const string FLD_TUNING_TX_MOBILEPWR_LOWPWR02 = "FLD_TUNING_TX_MOBILEPWR_LOWPWR02";

		// Token: 0x04001407 RID: 5127
		public const string FLD_TUNING_TX_MOBILEPWR_LOWPWR03 = "FLD_TUNING_TX_MOBILEPWR_LOWPWR03";

		// Token: 0x04001408 RID: 5128
		public const string FLD_TUNING_TX_MOBILEPWR_LOWPWR04 = "FLD_TUNING_TX_MOBILEPWR_LOWPWR04";

		// Token: 0x04001409 RID: 5129
		public const string FLD_TUNING_TX_MOBILEPWR_LOWPWR05 = "FLD_TUNING_TX_MOBILEPWR_LOWPWR05";

		// Token: 0x0400140A RID: 5130
		public const string FLD_TUNING_TX_MOBILEPWR_LOWPWR06 = "FLD_TUNING_TX_MOBILEPWR_LOWPWR06";

		// Token: 0x0400140B RID: 5131
		public const string FLD_TUNING_TX_MOBILEPWR_LOWPWR07 = "FLD_TUNING_TX_MOBILEPWR_LOWPWR07";

		// Token: 0x0400140C RID: 5132
		public const string FLD_TUNING_TX_MOBILEPWR_P1LP = "FLD_TUNING_TX_MOBILEPWR_P1LP";

		// Token: 0x0400140D RID: 5133
		public const string FLD_TUNING_TX_MOBILEPWR_P1LP00 = "FLD_TUNING_TX_MOBILEPWR_P1LP00";

		// Token: 0x0400140E RID: 5134
		public const string FLD_TUNING_TX_MOBILEPWR_P1LP01 = "FLD_TUNING_TX_MOBILEPWR_P1LP01";

		// Token: 0x0400140F RID: 5135
		public const string FLD_TUNING_TX_MOBILEPWR_P1LP02 = "FLD_TUNING_TX_MOBILEPWR_P1LP02";

		// Token: 0x04001410 RID: 5136
		public const string FLD_TUNING_TX_MOBILEPWR_P1LP03 = "FLD_TUNING_TX_MOBILEPWR_P1LP03";

		// Token: 0x04001411 RID: 5137
		public const string FLD_TUNING_TX_MOBILEPWR_P1LP04 = "FLD_TUNING_TX_MOBILEPWR_P1LP04";

		// Token: 0x04001412 RID: 5138
		public const string FLD_TUNING_TX_MOBILEPWR_P1LP05 = "FLD_TUNING_TX_MOBILEPWR_P1LP05";

		// Token: 0x04001413 RID: 5139
		public const string FLD_TUNING_TX_MOBILEPWR_P1LP06 = "FLD_TUNING_TX_MOBILEPWR_P1LP06";

		// Token: 0x04001414 RID: 5140
		public const string FLD_TUNING_TX_MOBILEPWR_P1LP07 = "FLD_TUNING_TX_MOBILEPWR_P1LP07";

		// Token: 0x04001415 RID: 5141
		public const string FLD_TUNING_TX_MOBILEPWR_HIPWR = "FLD_TUNING_TX_MOBILEPWR_HIPWR";

		// Token: 0x04001416 RID: 5142
		public const string FLD_TUNING_TX_MOBILEPWR_HIPWR00 = "FLD_TUNING_TX_MOBILEPWR_HIPWR00";

		// Token: 0x04001417 RID: 5143
		public const string FLD_TUNING_TX_MOBILEPWR_HIPWR01 = "FLD_TUNING_TX_MOBILEPWR_HIPWR01";

		// Token: 0x04001418 RID: 5144
		public const string FLD_TUNING_TX_MOBILEPWR_HIPWR02 = "FLD_TUNING_TX_MOBILEPWR_HIPWR02";

		// Token: 0x04001419 RID: 5145
		public const string FLD_TUNING_TX_MOBILEPWR_HIPWR03 = "FLD_TUNING_TX_MOBILEPWR_HIPWR03";

		// Token: 0x0400141A RID: 5146
		public const string FLD_TUNING_TX_MOBILEPWR_HIPWR04 = "FLD_TUNING_TX_MOBILEPWR_HIPWR04";

		// Token: 0x0400141B RID: 5147
		public const string FLD_TUNING_TX_MOBILEPWR_HIPWR05 = "FLD_TUNING_TX_MOBILEPWR_HIPWR05";

		// Token: 0x0400141C RID: 5148
		public const string FLD_TUNING_TX_MOBILEPWR_HIPWR06 = "FLD_TUNING_TX_MOBILEPWR_HIPWR06";

		// Token: 0x0400141D RID: 5149
		public const string FLD_TUNING_TX_MOBILEPWR_HIPWR07 = "FLD_TUNING_TX_MOBILEPWR_HIPWR07";

		// Token: 0x0400141E RID: 5150
		public const string FLD_TUNING_TX_MOBILEPWR_P1PWR = "FLD_TUNING_TX_MOBILEPWR_P1PWR";

		// Token: 0x0400141F RID: 5151
		public const string FLD_TUNING_TX_MOBILEPWR_P1PWR00 = "FLD_TUNING_TX_MOBILEPWR_P1PWR00";

		// Token: 0x04001420 RID: 5152
		public const string FLD_TUNING_TX_MOBILEPWR_P1PWR01 = "FLD_TUNING_TX_MOBILEPWR_P1PWR01";

		// Token: 0x04001421 RID: 5153
		public const string FLD_TUNING_TX_MOBILEPWR_P1PWR02 = "FLD_TUNING_TX_MOBILEPWR_P1PWR02";

		// Token: 0x04001422 RID: 5154
		public const string FLD_TUNING_TX_MOBILEPWR_P1PWR03 = "FLD_TUNING_TX_MOBILEPWR_P1PWR03";

		// Token: 0x04001423 RID: 5155
		public const string FLD_TUNING_TX_MOBILEPWR_P1PWR04 = "FLD_TUNING_TX_MOBILEPWR_P1PWR04";

		// Token: 0x04001424 RID: 5156
		public const string FLD_TUNING_TX_MOBILEPWR_P1PWR05 = "FLD_TUNING_TX_MOBILEPWR_P1PWR05";

		// Token: 0x04001425 RID: 5157
		public const string FLD_TUNING_TX_MOBILEPWR_P1PWR06 = "FLD_TUNING_TX_MOBILEPWR_P1PWR06";

		// Token: 0x04001426 RID: 5158
		public const string FLD_TUNING_TX_MOBILEPWR_P1PWR07 = "FLD_TUNING_TX_MOBILEPWR_P1PWR07";

		// Token: 0x04001427 RID: 5159
		public const string FLD_TUNING_TX_MOBILEPWR_P1PWR08 = "FLD_TUNING_TX_MOBILEPWR_P1PWR08";

		// Token: 0x04001428 RID: 5160
		public const string FLD_TUNING_TX_MOBILEPWR_P2LP = "FLD_TUNING_TX_MOBILEPWR_P2LP";

		// Token: 0x04001429 RID: 5161
		public const string FLD_TUNING_TX_MOBILEPWR_P2LP00 = "FLD_TUNING_TX_MOBILEPWR_P2LP00";

		// Token: 0x0400142A RID: 5162
		public const string FLD_TUNING_TX_MOBILEPWR_P2LP01 = "FLD_TUNING_TX_MOBILEPWR_P2LP01";

		// Token: 0x0400142B RID: 5163
		public const string FLD_TUNING_TX_MOBILEPWR_P2LP02 = "FLD_TUNING_TX_MOBILEPWR_P2LP02";

		// Token: 0x0400142C RID: 5164
		public const string FLD_TUNING_TX_MOBILEPWR_P2LP03 = "FLD_TUNING_TX_MOBILEPWR_P2LP03";

		// Token: 0x0400142D RID: 5165
		public const string FLD_TUNING_TX_MOBILEPWR_P2LP04 = "FLD_TUNING_TX_MOBILEPWR_P2LP04";

		// Token: 0x0400142E RID: 5166
		public const string FLD_TUNING_TX_MOBILEPWR_P2LP05 = "FLD_TUNING_TX_MOBILEPWR_P2LP05";

		// Token: 0x0400142F RID: 5167
		public const string FLD_TUNING_TX_MOBILEPWR_P2LP06 = "FLD_TUNING_TX_MOBILEPWR_P2LP06";

		// Token: 0x04001430 RID: 5168
		public const string FLD_TUNING_TX_MOBILEPWR_P2LP07 = "FLD_TUNING_TX_MOBILEPWR_P2LP07";

		// Token: 0x04001431 RID: 5169
		public const string FLD_TUNING_TX_MOBILEPWR_P2LP08 = "FLD_TUNING_TX_MOBILEPWR_P2LP08";

		// Token: 0x04001432 RID: 5170
		public const string FLD_TUNING_TX_MOBILEPWR_P2PWR = "FLD_TUNING_TX_MOBILEPWR_P2PWR";

		// Token: 0x04001433 RID: 5171
		public const string FLD_TUNING_TX_MOBILEPWR_P2PWR00 = "FLD_TUNING_TX_MOBILEPWR_P2PWR00";

		// Token: 0x04001434 RID: 5172
		public const string FLD_TUNING_TX_MOBILEPWR_P2PWR01 = "FLD_TUNING_TX_MOBILEPWR_P2PWR01";

		// Token: 0x04001435 RID: 5173
		public const string FLD_TUNING_TX_MOBILEPWR_P2PWR02 = "FLD_TUNING_TX_MOBILEPWR_P2PWR02";

		// Token: 0x04001436 RID: 5174
		public const string FLD_TUNING_TX_MOBILEPWR_P2PWR03 = "FLD_TUNING_TX_MOBILEPWR_P2PWR03";

		// Token: 0x04001437 RID: 5175
		public const string FLD_TUNING_TX_MOBILEPWR_P2PWR04 = "FLD_TUNING_TX_MOBILEPWR_P2PWR04";

		// Token: 0x04001438 RID: 5176
		public const string FLD_TUNING_TX_MOBILEPWR_P2PWR05 = "FLD_TUNING_TX_MOBILEPWR_P2PWR05";

		// Token: 0x04001439 RID: 5177
		public const string FLD_TUNING_TX_MOBILEPWR_P2PWR06 = "FLD_TUNING_TX_MOBILEPWR_P2PWR06";

		// Token: 0x0400143A RID: 5178
		public const string FLD_TUNING_TX_MOBILEPWR_P2PWR07 = "FLD_TUNING_TX_MOBILEPWR_P2PWR07";

		// Token: 0x0400143B RID: 5179
		public const string FLD_TUNING_TX_MOBILEPWR_P2PWR08 = "FLD_TUNING_TX_MOBILEPWR_P2PWR08";

		// Token: 0x0400143C RID: 5180
		public const string FLD_TUNING_TX_MOBILEPWR_P3PWR = "FLD_TUNING_TX_MOBILEPWR_P3PWR";

		// Token: 0x0400143D RID: 5181
		public const string FLD_TUNING_TX_MOBILEPWR_P3PWR00 = "FLD_TUNING_TX_MOBILEPWR_P3PWR00";

		// Token: 0x0400143E RID: 5182
		public const string FLD_TUNING_TX_MOBILEPWR_P3PWR01 = "FLD_TUNING_TX_MOBILEPWR_P3PWR01";

		// Token: 0x0400143F RID: 5183
		public const string FLD_TUNING_TX_MOBILEPWR_P3PWR02 = "FLD_TUNING_TX_MOBILEPWR_P3PWR02";

		// Token: 0x04001440 RID: 5184
		public const string FLD_TUNING_TX_MOBILEPWR_P3PWR03 = "FLD_TUNING_TX_MOBILEPWR_P3PWR03";

		// Token: 0x04001441 RID: 5185
		public const string FLD_TUNING_TX_MOBILEPWR_P3PWR04 = "FLD_TUNING_TX_MOBILEPWR_P3PWR04";

		// Token: 0x04001442 RID: 5186
		public const string FLD_TUNING_TX_MOBILEPWR_P3PWR05 = "FLD_TUNING_TX_MOBILEPWR_P3PWR05";

		// Token: 0x04001443 RID: 5187
		public const string FLD_TUNING_TX_MOBILEPWR_P3PWR06 = "FLD_TUNING_TX_MOBILEPWR_P3PWR06";

		// Token: 0x04001444 RID: 5188
		public const string FLD_TUNING_TX_MOBILEPWR_P3PWR07 = "FLD_TUNING_TX_MOBILEPWR_P3PWR07";

		// Token: 0x04001445 RID: 5189
		public const string FLD_TUNING_TX_MOBILEPWR_P3PWR08 = "FLD_TUNING_TX_MOBILEPWR_P3PWR08";

		// Token: 0x04001446 RID: 5190
		public const string FLD_TUNING_TX_MOBILEPWR_P4PWR = "FLD_TUNING_TX_MOBILEPWR_P4PWR";

		// Token: 0x04001447 RID: 5191
		public const string FLD_TUNING_TX_MOBILEPWR_P4PWR00 = "FLD_TUNING_TX_MOBILEPWR_P4PWR00";

		// Token: 0x04001448 RID: 5192
		public const string FLD_TUNING_TX_MOBILEPWR_P4PWR01 = "FLD_TUNING_TX_MOBILEPWR_P4PWR01";

		// Token: 0x04001449 RID: 5193
		public const string FLD_TUNING_TX_MOBILEPWR_P4PWR02 = "FLD_TUNING_TX_MOBILEPWR_P4PWR02";

		// Token: 0x0400144A RID: 5194
		public const string FLD_TUNING_TX_MOBILEPWR_P4PWR03 = "FLD_TUNING_TX_MOBILEPWR_P4PWR03";

		// Token: 0x0400144B RID: 5195
		public const string FLD_TUNING_TX_MOBILEPWR_P4PWR04 = "FLD_TUNING_TX_MOBILEPWR_P4PWR04";

		// Token: 0x0400144C RID: 5196
		public const string FLD_TUNING_TX_MOBILEPWR_P4PWR05 = "FLD_TUNING_TX_MOBILEPWR_P4PWR05";

		// Token: 0x0400144D RID: 5197
		public const string FLD_TUNING_TX_MOBILEPWR_P4PWR06 = "FLD_TUNING_TX_MOBILEPWR_P4PWR06";

		// Token: 0x0400144E RID: 5198
		public const string FLD_TUNING_TX_MOBILEPWR_P4PWR07 = "FLD_TUNING_TX_MOBILEPWR_P4PWR07";

		// Token: 0x0400144F RID: 5199
		public const string FLD_TUNING_TX_MOBILEPWR_P4PWR08 = "FLD_TUNING_TX_MOBILEPWR_P4PWR08";

		// Token: 0x04001450 RID: 5200
		public const string FLD_TUNING_TX_MOBILEPWR_DAC1 = "FLD_TUNING_TX_MOBILEPWR_DAC1";

		// Token: 0x04001451 RID: 5201
		public const string FLD_TUNING_TX_MOBILEPWR_DAC2 = "FLD_TUNING_TX_MOBILEPWR_DAC2";

		// Token: 0x04001452 RID: 5202
		public const string FLD_TUNING_TX_MOBILEPWR_DAC1_FREQ = "FLD_TUNING_TX_MOBILEPWR_DAC1_FREQ";

		// Token: 0x04001453 RID: 5203
		public const string FLD_TUNING_TX_MOBILEPWR_DAC2_FREQ = "FLD_TUNING_TX_MOBILEPWR_DAC2_FREQ";

		// Token: 0x04001454 RID: 5204
		public const string FLD_TUNING_TX_MOBILEPWR_DAC3_FREQ = "FLD_TUNING_TX_MOBILEPWR_DAC3_FREQ";

		// Token: 0x04001455 RID: 5205
		public const string FLD_TUNING_TX_MOBILEPWR_DAC4_FREQ = "FLD_TUNING_TX_MOBILEPWR_DAC4_FREQ";

		// Token: 0x04001456 RID: 5206
		public const string TUNING_RX_LQC = "TUNING_RX_LQC";

		// Token: 0x04001457 RID: 5207
		public const string RADIO_TUNING_LQC_CMP_TYPE = "RADIO_TUNING_LQC_CMP_TYPE";

		// Token: 0x04001458 RID: 5208
		public const string FLD_TUNING_RX_LQC_TUNINGFREQ = "FLD_TUNING_RX_LQC_TUNINGFREQ";

		// Token: 0x04001459 RID: 5209
		public const string CBO_TUNING_RX_LQC_TESTPATTERN = "CBO_TUNING_RX_LQC_TESTPATTERN";

		// Token: 0x0400145A RID: 5210
		public const string CBO_TUNING_RX_LQC_OPERATION = "CBO_TUNING_RX_LQC_OPERATION";

		// Token: 0x0400145B RID: 5211
		public const string FLD_TUNING_RX_FRAMECOUNT = "FLD_TUNING_RX_FRAMECOUNT";

		// Token: 0x0400145C RID: 5212
		public const string FLD_TUNING_RX_FRAMEERRORCOUNT = "FLD_TUNING_RX_FRAMEERRORCOUNT";

		// Token: 0x0400145D RID: 5213
		public const string FLD_TUNING_RX_SYNCERRORCOUNT = "FLD_TUNING_RX_SYNCERRORCOUNT";

		// Token: 0x0400145E RID: 5214
		public const string BTN_TUNING_RX_LQC_START = "BTN_TUNING_RX_LQC_START";

		// Token: 0x0400145F RID: 5215
		public const string RADIO_TUNING_RFT_CMP_TYPE = "RADIO_TUNING_RFT_CMP_TYPE";

		// Token: 0x04001460 RID: 5216
		public const string TUNING_RX_RFT = "TUNING_RX_RFT";

		// Token: 0x04001461 RID: 5217
		public const string FLD_TUNING_RX_RFT_TUNINGFREQ = "FLD_TUNING_RX_RFT_TUNINGFREQ";

		// Token: 0x04001462 RID: 5218
		public const string CBO_TUNING_RX_RFT_TESTPATTERN = "CBO_TUNING_RX_RFT_TESTPATTERN";

		// Token: 0x04001463 RID: 5219
		public const string CBO_TUNING_RX_RFT_INTERVAL = "CBO_TUNING_RX_RFT_INTERVAL";

		// Token: 0x04001464 RID: 5220
		public const string FLD_TUNING_RX_RFT_BER = "FLD_TUNING_RX_RFT_BER";

		// Token: 0x04001465 RID: 5221
		public const string FLD_TUNING_RX_RFT_RSSI = "FLD_TUNING_RX_RFT_RSSI";

		// Token: 0x04001466 RID: 5222
		public const string BTN_TUNING_RX_RFT_START = "BTN_TUNING_RX_RFT_START";

		// Token: 0x04001467 RID: 5223
		public const string TUNING_RX_FEG = "TUNING_RX_FEG";

		// Token: 0x04001468 RID: 5224
		public const string TUNING_RX_FEG1 = "TUNING_RX_FEG1";

		// Token: 0x04001469 RID: 5225
		public const string FLD_TUNING_RX_FEG_TUNINGFREQ = "FLD_TUNING_RX_FEG_TUNINGFREQ";

		// Token: 0x0400146A RID: 5226
		public const string FLD_TUNING_RX_FEG_TUNINGFREQ00 = "FLD_TUNING_RX_FEG_TUNINGFREQ00";

		// Token: 0x0400146B RID: 5227
		public const string FLD_TUNING_RX_FEG_TUNINGFREQ01 = "FLD_TUNING_RX_FEG_TUNINGFREQ01";

		// Token: 0x0400146C RID: 5228
		public const string FLD_TUNING_RX_FEG_SOFTPOT = "FLD_TUNING_RX_FEG_SOFTPOT";

		// Token: 0x0400146D RID: 5229
		public const string FLD_TUNING_RX_FEG_SOFTPOT00 = "FLD_TUNING_RX_FEG_SOFTPOT00";

		// Token: 0x0400146E RID: 5230
		public const string FLD_TUNING_RX_FEG_SOFTPOT01 = "FLD_TUNING_RX_FEG_SOFTPOT01";

		// Token: 0x0400146F RID: 5231
		public const string FLD_PREVPROGSFT_TUNING_RX_FEG_SOFTPOT = "FLD_PREVPROGSFT_TUNING_RX_FEG_SOFTPOT";

		// Token: 0x04001470 RID: 5232
		public const string FLD_TUNING_RX_FEGRSSIINTERNAL = "FLD_TUNING_RX_FEGRSSIINTERNAL";

		// Token: 0x04001471 RID: 5233
		public const string FLD_TUNING_RX_FEG_SOFTPOTDB00 = "FLD_TUNING_RX_FEG_SOFTPOTDB00";

		// Token: 0x04001472 RID: 5234
		public const string FLD_TUNING_RX_FEG_SOFTPOTDB = "FLD_TUNING_RX_FEG_SOFTPOTDB";

		// Token: 0x04001473 RID: 5235
		public const string FLD_TUNING_RX_FEGRSSI1 = "FLD_TUNING_RX_FEGRSSI1";

		// Token: 0x04001474 RID: 5236
		public const string FLD_TUNING_RX_FEGRSSI2 = "FLD_TUNING_RX_FEGRSSI2";

		// Token: 0x04001475 RID: 5237
		public const string FLD_TUNING_RX_FEGRSSI3 = "FLD_TUNING_RX_FEGRSSI3";

		// Token: 0x04001476 RID: 5238
		public const string FLD_TUNING_RX_FEGRSSI4 = "FLD_TUNING_RX_FEGRSSI4";

		// Token: 0x04001477 RID: 5239
		public const string FLD_TUNING_RX_FEGATTN1 = "FLD_TUNING_RX_FEGATTN1";

		// Token: 0x04001478 RID: 5240
		public const string FLD_TUNING_RX_FEGATTN2 = "FLD_TUNING_RX_FEGATTN2";

		// Token: 0x04001479 RID: 5241
		public const string FLD_TUNING_RX_FEG_INTERNAL_ATTEN = "FLD_TUNING_RX_FEG_INTERNAL_ATTEN";

		// Token: 0x0400147A RID: 5242
		public const string FLD_TUNING_RX_FEGATTN100 = "FLD_TUNING_RX_FEGATTN100";

		// Token: 0x0400147B RID: 5243
		public const string FLD_TUNING_RX_FEGATTN1_DB = "FLD_TUNING_RX_FEGATTN1_DB";

		// Token: 0x0400147C RID: 5244
		public const string FLD_TUNING_RX_FEGATTN2_DB = "FLD_TUNING_RX_FEGATTN2_DB";

		// Token: 0x0400147D RID: 5245
		public const string FLD_TUNING_RX_FEG_INTERNAL_ATTEN_DB = "FLD_TUNING_RX_FEG_INTERNAL_ATTEN_DB";

		// Token: 0x0400147E RID: 5246
		public const string BTN_TUNING_RX_FEG_AUTOTUNE = "BTN_TUNING_RX_FEG_AUTOTUNE";

		// Token: 0x0400147F RID: 5247
		public const string BTN_TUNING_RX_FEG_AUTOTUNE00 = "BTN_TUNING_RX_FEG_AUTOTUNE00";

		// Token: 0x04001480 RID: 5248
		public const string BTN_TUNING_RX_FEG_AUTOTUNE01 = "BTN_TUNING_RX_FEG_AUTOTUNE01";

		// Token: 0x04001481 RID: 5249
		public const string TUNING_RX_FEG2 = "TUNING_RX_FEG2";

		// Token: 0x04001482 RID: 5250
		public const string FLD_TUNING_RX_FEG1_RSSI = "FLD_TUNING_RX_FEG1_RSSI";

		// Token: 0x04001483 RID: 5251
		public const string FLD_TUNING_RX_FEG2_RSSI = "FLD_TUNING_RX_FEG2_RSSI";

		// Token: 0x04001484 RID: 5252
		public const string TUNING_RX_NGRFEG = "TUNING_RX_NGRFEG";

		// Token: 0x04001485 RID: 5253
		public const string FLD_TUNING_RX_NGRFEG_TUNINGFREQ = "FLD_TUNING_RX_NGRFEG_TUNINGFREQ";

		// Token: 0x04001486 RID: 5254
		public const string FLD_TUNING_RX_NGRFEG_TUNINGFREQ00 = "FLD_TUNING_RX_NGRFEG_TUNINGFREQ00";

		// Token: 0x04001487 RID: 5255
		public const string FLD_TUNING_RX_NGRFEG_ATTEN = "FLD_TUNING_RX_NGRFEG_ATTEN";

		// Token: 0x04001488 RID: 5256
		public const string FLD_TUNING_RX_NGRFEG_INTERNALATTEN = "FLD_TUNING_RX_NGRFEG_INTERNALATTEN";

		// Token: 0x04001489 RID: 5257
		public const string BTN_TUNING_RX_NGRFEG_AUTOTUNE = "BTN_TUNING_RX_NGRFEG_AUTOTUNE";

		// Token: 0x0400148A RID: 5258
		public const string BTN_TUNING_RX_NGRFEG_AUTOTUNE00 = "BTN_TUNING_RX_NGRFEG_AUTOTUNE00";

		// Token: 0x0400148B RID: 5259
		public const string BTN_TUNING_RX_NGRFEG_AUTOTUNE01 = "BTN_TUNING_RX_NGRFEG_AUTOTUNE01";

		// Token: 0x0400148C RID: 5260
		public const string FLD_TUNING_RX_NGRFEG_RSSI = "FLD_TUNING_RX_NGRFEG_RSSI";

		// Token: 0x0400148D RID: 5261
		public const string FLD_TUNING_RX_NGRFEG_RSSI00 = "FLD_TUNING_RX_NGRFEG_RSSI00";

		// Token: 0x0400148E RID: 5262
		public const string FLD_TUNING_RX_NGRFEG_12K = "FLD_TUNING_RX_NGRFEG_12K";

		// Token: 0x0400148F RID: 5263
		public const string FLD_TUNING_RX_NGRFEG_12K_SOFTPOT = "FLD_TUNING_RX_NGRFEG_12K_SOFTPOT";

		// Token: 0x04001490 RID: 5264
		public const string FLD_TUNING_RX_NGRFEG_12K_SOFTPOTDB = "FLD_TUNING_RX_NGRFEG_12K_SOFTPOTDB";

		// Token: 0x04001491 RID: 5265
		public const string FLD_TUNING_RX_NGRFEG_12K_RSSI = "FLD_TUNING_RX_NGRFEG_12K_RSSI";

		// Token: 0x04001492 RID: 5266
		public const string FLD_TUNING_RX_NGRFEG_25K = "FLD_TUNING_RX_NGRFEG_25K";

		// Token: 0x04001493 RID: 5267
		public const string FLD_TUNING_RX_NGRFEG_25K_SOFTPOT = "FLD_TUNING_RX_NGRFEG_25K_SOFTPOT";

		// Token: 0x04001494 RID: 5268
		public const string FLD_TUNING_RX_NGRFEG_25K_SOFTPOTDB = "FLD_TUNING_RX_NGRFEG_25K_SOFTPOTDB";

		// Token: 0x04001495 RID: 5269
		public const string FLD_TUNING_RX_NGRFEG_25K_RSSI = "FLD_TUNING_RX_NGRFEG_25K_RSSI";

		// Token: 0x04001496 RID: 5270
		public const string FLD_TUNING_RX_NGRFEG_ATTEN_SOFTPOT = "FLD_TUNING_RX_NGRFEG_ATTEN_SOFTPOT";

		// Token: 0x04001497 RID: 5271
		public const string FLD_TUNING_RX_NGRFEG_ATTEN_SOFTPOTDB = "FLD_TUNING_RX_NGRFEG_ATTEN_SOFTPOTDB";

		// Token: 0x04001498 RID: 5272
		public const string FLD_TUNING_RX_NGRFEG_ATTEN_RSSI = "FLD_TUNING_RX_NGRFEG_ATTEN_RSSI";

		// Token: 0x04001499 RID: 5273
		public const string FLD_TUNING_RX_NGRFEG_INTERNALATTEN_SOFTPOT = "FLD_TUNING_RX_NGRFEG_INTERNALATTEN_SOFTPOT";

		// Token: 0x0400149A RID: 5274
		public const string FLD_TUNING_RX_NGRFEG_INTERNALATTEN_SOFTPOTDB = "FLD_TUNING_RX_NGRFEG_INTERNALATTEN_SOFTPOTDB";

		// Token: 0x0400149B RID: 5275
		public const string FLD_TUNING_RX_NGRFEG_INTERNALATTEN_RSSI = "FLD_TUNING_RX_NGRFEG_INTERNALATTEN_RSSI";

		// Token: 0x0400149C RID: 5276
		public const string TUNING_RX_DA = "TUNING_RX_DA";

		// Token: 0x0400149D RID: 5277
		public const string FLD_TUNING_RX_DA_TUNINGFREQ = "FLD_TUNING_RX_DA_TUNINGFREQ";

		// Token: 0x0400149E RID: 5278
		public const string CBO_TUNING_RX_DA_TESTPATTERN = "CBO_TUNING_RX_DA_TESTPATTERN";

		// Token: 0x0400149F RID: 5279
		public const string CBO_TUNING_RX_DA_AUDIO = "CBO_TUNING_RX_DA_AUDIO";

		// Token: 0x040014A0 RID: 5280
		public const string TUNING_RX_REFOSC = "TUNING_RX_REFOSC";

		// Token: 0x040014A1 RID: 5281
		public const string FLD_TUNING_RX_REFOSC_TUNINGFREQ = "FLD_TUNING_RX_REFOSC_TUNINGFREQ";

		// Token: 0x040014A2 RID: 5282
		public const string FLD_TUNING_RX_REFOSC_TUNINGFREQ00 = "FLD_TUNING_RX_REFOSC_TUNINGFREQ00";

		// Token: 0x040014A3 RID: 5283
		public const string FLD_TUNING_RX_REFOSC_SOFTPOT = "FLD_TUNING_RX_REFOSC_SOFTPOT";

		// Token: 0x040014A4 RID: 5284
		public const string FLD_TUNING_RX_REFOSC_SOFTPOT00 = "FLD_TUNING_RX_REFOSC_SOFTPOT00";

		// Token: 0x040014A5 RID: 5285
		public const string FLD_PREVPROGSFT_TUNING_RX_REFOSC_SOFTPOT = "FLD_PREVPROGSFT_TUNING_RX_REFOSC_SOFTPOT";

		// Token: 0x040014A6 RID: 5286
		public const string FLD_TUNING_RX_REFOSC_FREQERR = "FLD_TUNING_RX_REFOSC_FREQERR";

		// Token: 0x040014A7 RID: 5287
		public const string FLD_TUNING_RX_REFOSC_FREQERR00 = "FLD_TUNING_RX_REFOSC_FREQERR00";

		// Token: 0x040014A8 RID: 5288
		public const string BTN_TUNING_RX_REFOSC_AUTOWARP = "BTN_TUNING_RX_REFOSC_AUTOWARP";

		// Token: 0x040014A9 RID: 5289
		public const string BTN_CEC_TESTING = "BTN_CEC_TESTING";

		// Token: 0x040014AA RID: 5290
		public const string TUNING_TX_SINADTEST = "TUNING_TX_SINADTEST";

		// Token: 0x040014AB RID: 5291
		public const string FLD_TUNING_RX_SINADTEST_TUNINGFREQ = "FLD_TUNING_RX_SINADTEST_TUNINGFREQ";

		// Token: 0x040014AC RID: 5292
		public const string CBO_TUNING_RX_SINADTEST_DIGITALMODETESTPATTERN = "CBO_TUNING_RX_SINADTEST_DIGITALMODETESTPATTERN";

		// Token: 0x040014AD RID: 5293
		public const string FLD_TUNING_TX_SINADTEST_TUNINGFREQ = "FLD_TUNING_TX_SINADTEST_TUNINGFREQ";

		// Token: 0x040014AE RID: 5294
		public const string CBO_TUNING_TX_SINADTEST_CHANNELBANDWIDTH = "CBO_TUNING_TX_SINADTEST_CHANNELBANDWIDTH";

		// Token: 0x040014AF RID: 5295
		public const string CBO_TUNING_TX_SINADTEST_DIGITALMODETESTPATTERN = "CBO_TUNING_TX_SINADTEST_DIGITALMODETESTPATTERN";

		// Token: 0x040014B0 RID: 5296
		public const string CBO_TUNING_TX_SINADTEST_PWRLEVEL = "CBO_TUNING_TX_SINADTEST_PWRLEVEL";

		// Token: 0x040014B1 RID: 5297
		public const string CBO_TUNING_TX_BER_TTR = "CBO_TUNING_TX_BER_TTR";

		// Token: 0x040014B2 RID: 5298
		public const string NO_TESTPATTERN = "NO_TESTPATTERN";

		// Token: 0x040014B3 RID: 5299
		public const string TUNING_TX_RDAC = "TUNING_TX_RDAC";

		// Token: 0x040014B4 RID: 5300
		public const string FLD_TUNING_TX_RDAC_TUNINGFREQ = "FLD_TUNING_TX_RDAC_TUNINGFREQ";

		// Token: 0x040014B5 RID: 5301
		public const string FLD_TUNING_TX_RDAC_TUNINGFREQ00 = "FLD_TUNING_TX_RDAC_TUNINGFREQ00";

		// Token: 0x040014B6 RID: 5302
		public const string FLD_TUNING_TX_RDAC_DAC = "FLD_TUNING_TX_RDAC_DAC";

		// Token: 0x040014B7 RID: 5303
		public const string FLD_TUNING_TX_RDAC = "FLD_TUNING_TX_RDAC";

		// Token: 0x040014B8 RID: 5304
		public const string FLD_TUNING_TX_RDAC_P1PWR = "FLD_TUNING_TX_RDAC_P1PWR";

		// Token: 0x040014B9 RID: 5305
		public const string FLD_TUNING_TX_RDAC_P1PWR00 = "FLD_TUNING_TX_RDAC_P1PWR00";

		// Token: 0x040014BA RID: 5306
		public const string FLD_TUNING_TX_RDAC_P1PWR01 = "FLD_TUNING_TX_RDAC_P1PWR01";

		// Token: 0x040014BB RID: 5307
		public const string FLD_TUNING_TX_RDAC_P1PWR02 = "FLD_TUNING_TX_RDAC_P1PWR02";

		// Token: 0x040014BC RID: 5308
		public const string FLD_TUNING_TX_RDAC_P1PWR03 = "FLD_TUNING_TX_RDAC_P1PWR03";

		// Token: 0x040014BD RID: 5309
		public const string FLD_TUNING_TX_RDAC_P1PWR04 = "FLD_TUNING_TX_RDAC_P1PWR04";

		// Token: 0x040014BE RID: 5310
		public const string FLD_TUNING_TX_RDAC_P1PWR05 = "FLD_TUNING_TX_RDAC_P1PWR05";

		// Token: 0x040014BF RID: 5311
		public const string FLD_TUNING_TX_RDAC_P1PWR06 = "FLD_TUNING_TX_RDAC_P1PWR06";

		// Token: 0x040014C0 RID: 5312
		public const string FLD_TUNING_TX_RDAC_P1PWR07 = "FLD_TUNING_TX_RDAC_P1PWR07";

		// Token: 0x040014C1 RID: 5313
		public const string FLD_TUNING_TX_RDAC_P1PWR08 = "FLD_TUNING_TX_RDAC_P1PWR08";

		// Token: 0x040014C2 RID: 5314
		public const string FLD_TUNING_TX_RDAC_P2PWR = "FLD_TUNING_TX_RDAC_P2PWR";

		// Token: 0x040014C3 RID: 5315
		public const string FLD_TUNING_TX_RDAC_P2PWR00 = "FLD_TUNING_TX_RDAC_P2PWR00";

		// Token: 0x040014C4 RID: 5316
		public const string FLD_TUNING_TX_RDAC_P2PWR01 = "FLD_TUNING_TX_RDAC_P2PWR01";

		// Token: 0x040014C5 RID: 5317
		public const string FLD_TUNING_TX_RDAC_P2PWR02 = "FLD_TUNING_TX_RDAC_P2PWR02";

		// Token: 0x040014C6 RID: 5318
		public const string FLD_TUNING_TX_RDAC_P2PWR03 = "FLD_TUNING_TX_RDAC_P2PWR03";

		// Token: 0x040014C7 RID: 5319
		public const string FLD_TUNING_TX_RDAC_P2PWR04 = "FLD_TUNING_TX_RDAC_P2PWR04";

		// Token: 0x040014C8 RID: 5320
		public const string FLD_TUNING_TX_RDAC_P2PWR05 = "FLD_TUNING_TX_RDAC_P2PWR05";

		// Token: 0x040014C9 RID: 5321
		public const string FLD_TUNING_TX_RDAC_P2PWR06 = "FLD_TUNING_TX_RDAC_P2PWR06";

		// Token: 0x040014CA RID: 5322
		public const string FLD_TUNING_TX_RDAC_P2PWR07 = "FLD_TUNING_TX_RDAC_P2PWR07";

		// Token: 0x040014CB RID: 5323
		public const string FLD_TUNING_TX_RDAC_P2PWR08 = "FLD_TUNING_TX_RDAC_P2PWR08";

		// Token: 0x040014CC RID: 5324
		public const string FLD_TUNING_TX_RDAC_P3PWR = "FLD_TUNING_TX_RDAC_P3PWR";

		// Token: 0x040014CD RID: 5325
		public const string FLD_TUNING_TX_RDAC_P3PWR00 = "FLD_TUNING_TX_RDAC_P3PWR00";

		// Token: 0x040014CE RID: 5326
		public const string FLD_TUNING_TX_RDAC_P3PWR01 = "FLD_TUNING_TX_RDAC_P3PWR01";

		// Token: 0x040014CF RID: 5327
		public const string FLD_TUNING_TX_RDAC_P3PWR02 = "FLD_TUNING_TX_RDAC_P3PWR02";

		// Token: 0x040014D0 RID: 5328
		public const string FLD_TUNING_TX_RDAC_P3PWR03 = "FLD_TUNING_TX_RDAC_P3PWR03";

		// Token: 0x040014D1 RID: 5329
		public const string FLD_TUNING_TX_RDAC_P3PWR04 = "FLD_TUNING_TX_RDAC_P3PWR04";

		// Token: 0x040014D2 RID: 5330
		public const string FLD_TUNING_TX_RDAC_P3PWR05 = "FLD_TUNING_TX_RDAC_P3PWR05";

		// Token: 0x040014D3 RID: 5331
		public const string FLD_TUNING_TX_RDAC_P3PWR06 = "FLD_TUNING_TX_RDAC_P3PWR06";

		// Token: 0x040014D4 RID: 5332
		public const string FLD_TUNING_TX_RDAC_P3PWR07 = "FLD_TUNING_TX_RDAC_P3PWR07";

		// Token: 0x040014D5 RID: 5333
		public const string FLD_TUNING_TX_RDAC_P3PWR08 = "FLD_TUNING_TX_RDAC_P3PWR08";

		// Token: 0x040014D6 RID: 5334
		public const string FLD_TUNING_TX_RDAC_P4PWR = "FLD_TUNING_TX_RDAC_P4PWR";

		// Token: 0x040014D7 RID: 5335
		public const string FLD_TUNING_TX_RDAC_P4PWR00 = "FLD_TUNING_TX_RDAC_P4PWR00";

		// Token: 0x040014D8 RID: 5336
		public const string FLD_TUNING_TX_RDAC_P4PWR01 = "FLD_TUNING_TX_RDAC_P4PWR01";

		// Token: 0x040014D9 RID: 5337
		public const string FLD_TUNING_TX_RDAC_P4PWR02 = "FLD_TUNING_TX_RDAC_P4PWR02";

		// Token: 0x040014DA RID: 5338
		public const string FLD_TUNING_TX_RDAC_P4PWR03 = "FLD_TUNING_TX_RDAC_P4PWR03";

		// Token: 0x040014DB RID: 5339
		public const string FLD_TUNING_TX_RDAC_P4PWR04 = "FLD_TUNING_TX_RDAC_P4PWR04";

		// Token: 0x040014DC RID: 5340
		public const string FLD_TUNING_TX_RDAC_P4PWR05 = "FLD_TUNING_TX_RDAC_P4PWR05";

		// Token: 0x040014DD RID: 5341
		public const string FLD_TUNING_TX_RDAC_P4PWR06 = "FLD_TUNING_TX_RDAC_P4PWR06";

		// Token: 0x040014DE RID: 5342
		public const string FLD_TUNING_TX_RDAC_P4PWR07 = "FLD_TUNING_TX_RDAC_P4PWR07";

		// Token: 0x040014DF RID: 5343
		public const string FLD_TUNING_TX_RDAC_P4PWR08 = "FLD_TUNING_TX_RDAC_P4PWR08";

		// Token: 0x040014E0 RID: 5344
		public const string TUNING_TX_MODLIMIT = "TUNING_TX_MODLIMIT";

		// Token: 0x040014E1 RID: 5345
		public const string FLD_TUNING_TX_MODLIMIT_TUNINGFREQ = "FLD_TUNING_TX_MODLIMIT_TUNINGFREQ";

		// Token: 0x040014E2 RID: 5346
		public const string FLD_TUNING_TX_MODLIMIT_SOFTPOT = "FLD_TUNING_TX_MODLIMIT_SOFTPOT";

		// Token: 0x040014E3 RID: 5347
		public const string FLD_PREVPROGSFT_TUNING_TX_MODLIMIT_SOFTPOT = "FLD_PREVPROGSFT_TUNING_TX_MODLIMIT_SOFTPOT";

		// Token: 0x040014E4 RID: 5348
		public const string LBL_TUNING_TX_MODLIMIT_SOFTPOT = "LBL_TUNING_TX_MODLIMIT_SOFTPOT";

		// Token: 0x040014E5 RID: 5349
		public const string LBL_TUNING_TX_MODLIMIT_TUNINGFREQ = "LBL_TUNING_TX_MODLIMIT_TUNINGFREQ";

		// Token: 0x040014E6 RID: 5350
		public const string LBL_PREVPROGSFT_TUNING_TX_MODLIMIT_SOFTPOT = "LBL_PREVPROGSFT_TUNING_TX_MODLIMIT_SOFTPOT";

		// Token: 0x040014E7 RID: 5351
		public const string FLD_TUNING_TX_MODLIMIT_SOFTPOT00 = "FLD_TUNING_TX_MODLIMIT_SOFTPOT00";

		// Token: 0x040014E8 RID: 5352
		public const string FLD_TUNING_TX_MODLIMIT_TUNINGFREQ00 = "FLD_TUNING_TX_MODLIMIT_TUNINGFREQ00";

		// Token: 0x040014E9 RID: 5353
		public const string VHF_LP_TX_VCBPWRHI_CBTARGETSLOPE = "50";

		// Token: 0x040014EA RID: 5354
		public const string VHF_LP_TX_VCBPWRHI_CBTARGETSLOPE_COS = "2";

		// Token: 0x040014EB RID: 5355
		public const string VHF_HP_TX_VCBPWRHI_CBTARGETSLOPE = "50";

		// Token: 0x040014EC RID: 5356
		public const string UHF_LP_TX_VCBPWRHI_CBTARGETSLOPE = "2";

		// Token: 0x040014ED RID: 5357
		public const string UHF_HP_TX_VCBPWRHI_CBTARGETSLOPE = "2";

		// Token: 0x040014EE RID: 5358
		public const string UHFB2_TX_VCBPWRHI_CBTARGETSLOPE = "50";

		// Token: 0x040014EF RID: 5359
		public const string UHFB2_TX_VCBPWRHI_CBTARGETSLOPE_COS = "2";

		// Token: 0x040014F0 RID: 5360
		public const string P800_900_TX_VCBPWRHI_CBTARGETSLOPE = "50";

		// Token: 0x040014F1 RID: 5361
		public const string VHF_LP_TX_VCBPWRHI_CBTARGETLIMIT = "2";

		// Token: 0x040014F2 RID: 5362
		public const string VHF_LP_TX_VCBPWRHI_CBTARGETLIMIT_COS = "50";

		// Token: 0x040014F3 RID: 5363
		public const string VHF_HP_TX_VCBPWRHI_CBTARGETLIMIT = "2";

		// Token: 0x040014F4 RID: 5364
		public const string UHF_LP_TX_VCBPWRHI_CBTARGETLIMIT = "40";

		// Token: 0x040014F5 RID: 5365
		public const string UHF_HP_TX_VCBPWRHI_CBTARGETLIMIT = "40";

		// Token: 0x040014F6 RID: 5366
		public const string UHFB2_HP_TX_VCBPWRHI_CBTARGETLIMIT = "2";

		// Token: 0x040014F7 RID: 5367
		public const string UHFB2_HP_TX_VCBPWRHI_CBTARGETLIMIT_COS = "50";

		// Token: 0x040014F8 RID: 5368
		public const string P800_900_HP_TX_VCBPWRHI_CBTARGETLIMIT = "2";

		// Token: 0x040014F9 RID: 5369
		public const string VHF_LP_TX_VCBPWRHI_MAX_POWER = "44.39";

		// Token: 0x040014FA RID: 5370
		public const string VHF_HP_TX_VCBPWRHI_MAX_POWER = "46.99";

		// Token: 0x040014FB RID: 5371
		public const string UHF_LP_TX_VCBPWRHI_MAX_POWER = "44.39";

		// Token: 0x040014FC RID: 5372
		public const string UHF_HP_TX_VCBPWRHI_MAX_POWER = "46.43";

		// Token: 0x040014FD RID: 5373
		public const string UHFB2_HP_TX_VCBPWRHI_MAX_POWER = "46.43";

		// Token: 0x040014FE RID: 5374
		public const string P800_900_TX_VCBPWRHI_MAX_POWER = "44.77";

		// Token: 0x040014FF RID: 5375
		public const string P350_TX_VCBPWRHI_MAX_POWER = "46.43";

		// Token: 0x04001500 RID: 5376
		public const string FLD_TUNING_TX_MOBILEPWR_KCP = "FLD_TUNING_TX_MOBILEPWR_KCP";

		// Token: 0x04001501 RID: 5377
		public const string FLD_TUNING_TX_MOBILEPWR_MCP = "FLD_TUNING_TX_MOBILEPWR_MCP";

		// Token: 0x04001502 RID: 5378
		public const string FLD_TUNING_TX_MOBILEPWR_MCP1 = "FLD_TUNING_TX_MOBILEPWR_MCP1";

		// Token: 0x04001503 RID: 5379
		public const string FLD_TUNING_TX_MOBILEPWR_MCP100 = "FLD_TUNING_TX_MOBILEPWR_MCP100";

		// Token: 0x04001504 RID: 5380
		public const string FLD_TUNING_TX_MOBILEPWR_MCP101 = "FLD_TUNING_TX_MOBILEPWR_MCP101";

		// Token: 0x04001505 RID: 5381
		public const string FLD_TUNING_TX_MOBILEPWR_MCP102 = "FLD_TUNING_TX_MOBILEPWR_MCP102";

		// Token: 0x04001506 RID: 5382
		public const string FLD_TUNING_TX_MOBILEPWR_MCP103 = "FLD_TUNING_TX_MOBILEPWR_MCP103";

		// Token: 0x04001507 RID: 5383
		public const string FLD_TUNING_TX_MOBILEPWR_MCP104 = "FLD_TUNING_TX_MOBILEPWR_MCP104";

		// Token: 0x04001508 RID: 5384
		public const string FLD_TUNING_TX_MOBILEPWR_MCP105 = "FLD_TUNING_TX_MOBILEPWR_MCP105";

		// Token: 0x04001509 RID: 5385
		public const string FLD_TUNING_TX_MOBILEPWR_MCP106 = "FLD_TUNING_TX_MOBILEPWR_MCP106";

		// Token: 0x0400150A RID: 5386
		public const string FLD_TUNING_TX_MOBILEPWR_MCP107 = "FLD_TUNING_TX_MOBILEPWR_MCP107";

		// Token: 0x0400150B RID: 5387
		public const string FLD_TUNING_TX_MOBILEPWR_MCP108 = "FLD_TUNING_TX_MOBILEPWR_MCP108";

		// Token: 0x0400150C RID: 5388
		public const string FLD_TUNING_TX_MOBILEPWR_MCP2 = "FLD_TUNING_TX_MOBILEPWR_MCP2";

		// Token: 0x0400150D RID: 5389
		public const string FLD_TUNING_TX_MOBILEPWR_MCP200 = "FLD_TUNING_TX_MOBILEPWR_MCP200";

		// Token: 0x0400150E RID: 5390
		public const string FLD_TUNING_TX_MOBILEPWR_MCP201 = "FLD_TUNING_TX_MOBILEPWR_MCP201";

		// Token: 0x0400150F RID: 5391
		public const string FLD_TUNING_TX_MOBILEPWR_MCP202 = "FLD_TUNING_TX_MOBILEPWR_MCP202";

		// Token: 0x04001510 RID: 5392
		public const string FLD_TUNING_TX_MOBILEPWR_MCP203 = "FLD_TUNING_TX_MOBILEPWR_MCP203";

		// Token: 0x04001511 RID: 5393
		public const string FLD_TUNING_TX_MOBILEPWR_MCP204 = "FLD_TUNING_TX_MOBILEPWR_MCP204";

		// Token: 0x04001512 RID: 5394
		public const string FLD_TUNING_TX_MOBILEPWR_MCP205 = "FLD_TUNING_TX_MOBILEPWR_MCP205";

		// Token: 0x04001513 RID: 5395
		public const string FLD_TUNING_TX_MOBILEPWR_MCP206 = "FLD_TUNING_TX_MOBILEPWR_MCP206";

		// Token: 0x04001514 RID: 5396
		public const string FLD_TUNING_TX_MOBILEPWR_MCP207 = "FLD_TUNING_TX_MOBILEPWR_MCP207";

		// Token: 0x04001515 RID: 5397
		public const string FLD_TUNING_TX_MOBILEPWR_MCP208 = "FLD_TUNING_TX_MOBILEPWR_MCP208";

		// Token: 0x04001516 RID: 5398
		public const string FLD_TUNING_TX_MOBILEPWR_PCATTNOFFSET = "FLD_TUNING_TX_MOBILEPWR_PCATTNOFFSET";

		// Token: 0x04001517 RID: 5399
		public const string TUNING_TX_VCBPWRHI = "TUNING_TX_VCBPWRHI";

		// Token: 0x04001518 RID: 5400
		public const string FLD_TUNING_TX_VCBPWRHI_SOFTPOT00 = "FLD_TUNING_TX_VCBPWRHI_SOFTPOT00";

		// Token: 0x04001519 RID: 5401
		public const string BTN_TUNING_TX_VCBPWRHI_SOFTPOT00 = "BTN_TUNING_TX_VCBPWRHI_SOFTPOT00";

		// Token: 0x0400151A RID: 5402
		public const string FLD_TUNING_TX_VCBPWRHI_SOFTPOT01 = "FLD_TUNING_TX_VCBPWRHI_SOFTPOT01";

		// Token: 0x0400151B RID: 5403
		public const string BTN_TUNING_TX_VCBPWRHI_SOFTPOT01 = "BTN_TUNING_TX_VCBPWRHI_SOFTPOT01";

		// Token: 0x0400151C RID: 5404
		public const string FLD_TUNING_TX_VCBPWRHI_TUNINGVOLTAGE00 = "FLD_TUNING_TX_VCBPWRHI_TUNINGVOLTAGE00";

		// Token: 0x0400151D RID: 5405
		public const string FLD_TUNING_TX_VCBPWRHI_TUNINGVOLTAGE01 = "FLD_TUNING_TX_VCBPWRHI_TUNINGVOLTAGE01";

		// Token: 0x0400151E RID: 5406
		public const string FLD_TUNING_TX_VCBPWRHI_CBTARGETSLOPE = "FLD_TUNING_TX_VCBPWRHI_CBTARGETSLOPE";

		// Token: 0x0400151F RID: 5407
		public const string FLD_TUNING_TX_VCBPWRHI_MAX_POWER = "FLD_TUNING_TX_VCBPWRHI_MAX_POWER";

		// Token: 0x04001520 RID: 5408
		public const string FLD_TUNING_TX_VCBPWRHI_CBLIMIT = "FLD_TUNING_TX_VCBPWRHI_CBLIMIT";

		// Token: 0x04001521 RID: 5409
		public const string FLD_TUNING_TX_VCBPWRHI_CBTARGETLIMIT = "FLD_TUNING_TX_VCBPWRHI_CBTARGETLIMIT";

		// Token: 0x04001522 RID: 5410
		public const string FLD_TUNING_TX_VCBPWRLOW_BATTERY = "FLD_TUNING_TX_VCBPWRLOW_BATTERY";

		// Token: 0x04001523 RID: 5411
		public const string FLD_TUNING_TX_VCBPWRLOW_CB = "FLD_TUNING_TX_VCBPWRLOW_CB";

		// Token: 0x04001524 RID: 5412
		public const string FLD_TUNING_TX_VCBPWRHI_CBHIGHSLOPE = "FLD_TUNING_TX_VCBPWRHI_CBHIGHSLOPE";

		// Token: 0x04001525 RID: 5413
		public const string FLD_PREVPROGSFT_TUNING_TX_VCBPWRHI_SOFTPOT00 = "FLD_PREVPROGSFT_TUNING_TX_VCBPWRHI_SOFTPOT00";

		// Token: 0x04001526 RID: 5414
		public const string FLD_PREVPROGSFT_TUNING_TX_VCBPWRHI_SOFTPOT01 = "FLD_PREVPROGSFT_TUNING_TX_VCBPWRHI_SOFTPOT01";

		// Token: 0x04001527 RID: 5415
		public const string FLD_TUNING_TX_VCBPWRHI_SOFTPOT = "FLD_TUNING_TX_VCBPWRHI_SOFTPOT";

		// Token: 0x04001528 RID: 5416
		public const string FLD_PREVPROGSFT_TUNING_TX_VCBPWRHI_SOFTPOT = "FLD_PREVPROGSFT_TUNING_TX_VCBPWRHI_SOFTPOT";

		// Token: 0x04001529 RID: 5417
		public const string Tuner_SubType = "Tuner_SubType";

		// Token: 0x0400152A RID: 5418
		public const string COS = "COS";

		// Token: 0x0400152B RID: 5419
		public const string TICC = "TICC";

		// Token: 0x0400152C RID: 5420
		public const string TUNING_TX_PWMSPUR = "TUNING_TX_PWMSPUR";

		// Token: 0x0400152D RID: 5421
		public const int TX_PWMSPUR_PWM_DEFAULT = 406779;

		// Token: 0x0400152E RID: 5422
		public const int MAXIMUM_SUPPORTED_PWMSPUR = 32;

		// Token: 0x0400152F RID: 5423
		public const string FLD_TUNING_TX_PWMSPUR_LOW_TUNINGFREQ = "FLD_TUNING_TX_PWMSPUR_LOW_TUNINGFREQ";

		// Token: 0x04001530 RID: 5424
		public const string FLD_TUNING_TX_PWMSPUR_LOW_TUNINGFREQ00 = "FLD_TUNING_TX_PWMSPUR_LOW_TUNINGFREQ00";

		// Token: 0x04001531 RID: 5425
		public const string FLD_TUNING_TX_PWMSPUR_HIGH_TUNINGFREQ = "FLD_TUNING_TX_PWMSPUR_HIGH_TUNINGFREQ";

		// Token: 0x04001532 RID: 5426
		public const string FLD_TUNING_TX_PWMSPUR_PWM_TUNINGFREQ = "FLD_TUNING_TX_PWMSPUR_PWM_TUNINGFREQ";

		// Token: 0x04001533 RID: 5427
		public const string FLD_TUNING_TX_PWMSPUR_PWM_TUNINGFREQ00 = "FLD_TUNING_TX_PWMSPUR_PWM_TUNINGFREQ00";

		// Token: 0x04001534 RID: 5428
		public const string FLD_TUNING_TX_PWMSPUR_PWM_TUNINGFREQ01 = "FLD_TUNING_TX_PWMSPUR_PWM_TUNINGFREQ01";

		// Token: 0x04001535 RID: 5429
		public const string FLD_TUNING_TX_PWMSPUR_PWM_TUNINGFREQ02 = "FLD_TUNING_TX_PWMSPUR_PWM_TUNINGFREQ02";

		// Token: 0x04001536 RID: 5430
		public const string FLD_TUNING_TX_PWMSPUR_PWM_TUNINGFREQ03 = "FLD_TUNING_TX_PWMSPUR_PWM_TUNINGFREQ03";

		// Token: 0x04001537 RID: 5431
		public const string FLD_TUNING_TX_PWMSPUR_PWM_TUNINGFREQ04 = "FLD_TUNING_TX_PWMSPUR_PWM_TUNINGFREQ04";

		// Token: 0x04001538 RID: 5432
		public const string FLD_TUNING_TX_PWMSPUR_PWM_TUNINGFREQ05 = "FLD_TUNING_TX_PWMSPUR_PWM_TUNINGFREQ05";

		// Token: 0x04001539 RID: 5433
		public const string FLD_TUNING_TX_PWMSPUR_PWM_TUNINGFREQ06 = "FLD_TUNING_TX_PWMSPUR_PWM_TUNINGFREQ06";

		// Token: 0x0400153A RID: 5434
		public const string FLD_TUNING_TX_PWMSPUR_PWM_TUNINGFREQ07 = "FLD_TUNING_TX_PWMSPUR_PWM_TUNINGFREQ07";

		// Token: 0x0400153B RID: 5435
		public const string FLD_TUNING_TX_PWMSPUR_PWM_TUNINGFREQ08 = "FLD_TUNING_TX_PWMSPUR_PWM_TUNINGFREQ08";

		// Token: 0x0400153C RID: 5436
		public const string FLD_TUNING_TX_PWMSPUR_PWM_TUNINGFREQ09 = "FLD_TUNING_TX_PWMSPUR_PWM_TUNINGFREQ09";

		// Token: 0x0400153D RID: 5437
		public const string FLD_TUNING_TX_PWMSPUR_PWM_TUNINGFREQ10 = "FLD_TUNING_TX_PWMSPUR_PWM_TUNINGFREQ10";

		// Token: 0x0400153E RID: 5438
		public const string FLD_TUNING_TX_PWMSPUR_PWM_TUNINGFREQ11 = "FLD_TUNING_TX_PWMSPUR_PWM_TUNINGFREQ11";

		// Token: 0x0400153F RID: 5439
		public const string FLD_TUNING_TX_PWMSPUR_PWM_TUNINGFREQ12 = "FLD_TUNING_TX_PWMSPUR_PWM_TUNINGFREQ12";

		// Token: 0x04001540 RID: 5440
		public const string FLD_TUNING_TX_PWMSPUR_PWM_TUNINGFREQ13 = "FLD_TUNING_TX_PWMSPUR_PWM_TUNINGFREQ13";

		// Token: 0x04001541 RID: 5441
		public const string FLD_TUNING_TX_PWMSPUR_PWM_TUNINGFREQ14 = "FLD_TUNING_TX_PWMSPUR_PWM_TUNINGFREQ14";

		// Token: 0x04001542 RID: 5442
		public const string FLD_TUNING_TX_PWMSPUR_PWM_TUNINGFREQ15 = "FLD_TUNING_TX_PWMSPUR_PWM_TUNINGFREQ15";

		// Token: 0x04001543 RID: 5443
		public const string FLD_TUNING_TX_PWMSPUR_PWM_TUNINGFREQ16 = "FLD_TUNING_TX_PWMSPUR_PWM_TUNINGFREQ16";

		// Token: 0x04001544 RID: 5444
		public const string FLD_TUNING_TX_PWMSPUR_PWM_TUNINGFREQ17 = "FLD_TUNING_TX_PWMSPUR_PWM_TUNINGFREQ17";

		// Token: 0x04001545 RID: 5445
		public const string FLD_TUNING_TX_PWMSPUR_PWM_TUNINGFREQ18 = "FLD_TUNING_TX_PWMSPUR_PWM_TUNINGFREQ18";

		// Token: 0x04001546 RID: 5446
		public const string FLD_TUNING_TX_PWMSPUR_PWM_TUNINGFREQ19 = "FLD_TUNING_TX_PWMSPUR_PWM_TUNINGFREQ19";

		// Token: 0x04001547 RID: 5447
		public const string FLD_TUNING_TX_PWMSPUR_PWM_TUNINGFREQ20 = "FLD_TUNING_TX_PWMSPUR_PWM_TUNINGFREQ20";

		// Token: 0x04001548 RID: 5448
		public const string FLD_TUNING_TX_PWMSPUR_PWM_TUNINGFREQ21 = "FLD_TUNING_TX_PWMSPUR_PWM_TUNINGFREQ21";

		// Token: 0x04001549 RID: 5449
		public const string FLD_TUNING_TX_PWMSPUR_PWM_TUNINGFREQ22 = "FLD_TUNING_TX_PWMSPUR_PWM_TUNINGFREQ22";

		// Token: 0x0400154A RID: 5450
		public const string FLD_TUNING_TX_PWMSPUR_PWM_TUNINGFREQ23 = "FLD_TUNING_TX_PWMSPUR_PWM_TUNINGFREQ23";

		// Token: 0x0400154B RID: 5451
		public const string FLD_TUNING_TX_PWMSPUR_PWM_TUNINGFREQ24 = "FLD_TUNING_TX_PWMSPUR_PWM_TUNINGFREQ24";

		// Token: 0x0400154C RID: 5452
		public const string FLD_TUNING_TX_PWMSPUR_PWM_TUNINGFREQ25 = "FLD_TUNING_TX_PWMSPUR_PWM_TUNINGFREQ25";

		// Token: 0x0400154D RID: 5453
		public const string FLD_TUNING_TX_PWMSPUR_PWM_TUNINGFREQ26 = "FLD_TUNING_TX_PWMSPUR_PWM_TUNINGFREQ26";

		// Token: 0x0400154E RID: 5454
		public const string FLD_TUNING_TX_PWMSPUR_PWM_TUNINGFREQ27 = "FLD_TUNING_TX_PWMSPUR_PWM_TUNINGFREQ27";

		// Token: 0x0400154F RID: 5455
		public const string FLD_TUNING_TX_PWMSPUR_PWM_TUNINGFREQ28 = "FLD_TUNING_TX_PWMSPUR_PWM_TUNINGFREQ28";

		// Token: 0x04001550 RID: 5456
		public const string FLD_TUNING_TX_PWMSPUR_PWM_TUNINGFREQ29 = "FLD_TUNING_TX_PWMSPUR_PWM_TUNINGFREQ29";

		// Token: 0x04001551 RID: 5457
		public const string FLD_TUNING_TX_PWMSPUR_PWM_TUNINGFREQ30 = "FLD_TUNING_TX_PWMSPUR_PWM_TUNINGFREQ30";

		// Token: 0x04001552 RID: 5458
		public const string FLD_TUNING_TX_PWMSPUR_PWM_TUNINGFREQ31 = "FLD_TUNING_TX_PWMSPUR_PWM_TUNINGFREQ31";

		// Token: 0x04001553 RID: 5459
		public const string FLD_TUNING_TX_PWMSPUR_TAG = "FLD_TUNING_TX_PWMSPUR_TAG";

		// Token: 0x04001554 RID: 5460
		public const string PRODUCT_NAME_AIRTRACER = "MOTOTRBO AirTracer";

		// Token: 0x04001555 RID: 5461
		public const string CS_CPVER = "CS_CPVER";

		// Token: 0x04001556 RID: 5462
		public const string CS_FBVER = "CS_FBVER";

		// Token: 0x04001557 RID: 5463
		public const string CS_SERIALNUM = "CS_SERIALNUM";

		// Token: 0x04001558 RID: 5464
		public const string CS_PRGCPSIZE = "CS_PRGCPSIZE";

		// Token: 0x04001559 RID: 5465
		public const string RC_CRNTUSDCPSZ = "RC_CRNTUSDCPSZ";

		// Token: 0x0400155A RID: 5466
		public const string CS_MAXCPSIZE = "CS_MAXCPSIZE";

		// Token: 0x0400155B RID: 5467
		public const string RC_TTLALLWBCPSZ = "RC_TTLALLWBCPSZ";

		// Token: 0x0400155C RID: 5468
		public const string RC_EMERALMTYPE = "RC_EMERALMTYPE";

		// Token: 0x0400155D RID: 5469
		public const string RC_EMERSLALM = "RC_EMERSLALM";

		// Token: 0x0400155E RID: 5470
		public const string RC_SLTEMERUNM = "RC_SLTEMERUNM";

		// Token: 0x0400155F RID: 5471
		public const string TRKPAGTGFLELH_FSAGSFPEN = "TRKPAGTGFLELH_FSAGSFPEN";

		// Token: 0x04001560 RID: 5472
		public const string BTN_READERRORLOG = "m_btnReadErrorLog";

		// Token: 0x04001561 RID: 5473
		public const string BTN_STARTTRACE = "m_btnTrace";

		// Token: 0x04001562 RID: 5474
		public const string F2_SIGNALS = "F2_SIGNALS";

		// Token: 0x04001563 RID: 5475
		public const string F2_SIGNALS_TYPE = "F2_SIGNALS_TYPE";

		// Token: 0x04001564 RID: 5476
		public const string F2_SIGNALS_TYPE_GRP = "F2_SIGNALS_TYPE_GRP";

		// Token: 0x04001565 RID: 5477
		public const string ERRORLOG_DLH_TYPE = "ERRORLOG_DLH_TYPE";

		// Token: 0x04001566 RID: 5478
		public const string ERRORLOG_DLL_TYPE = "ERRORLOG_DLL_TYPE";

		// Token: 0x04001567 RID: 5479
		public const string ARCHIVE_END = "</F2_SIGNALS></LTD_CODEPLUG>";

		// Token: 0x04001568 RID: 5480
		public const string ARCHIVE_BEGIN_DELET = " /></LTD_CODEPLUG>";

		// Token: 0x04001569 RID: 5481
		public const string TEMP_FILE_NAME = "temp~1";

		// Token: 0x0400156A RID: 5482
		public const string FLD_TRACELOG_DATE = "FLD_TRACELOG_DATE";

		// Token: 0x0400156B RID: 5483
		public const string FLD_TRACELOG_TIME = "FLD_TRACELOG_TIME";

		// Token: 0x0400156C RID: 5484
		public const string FLD_TRACELOG_PACKET = "FLD_TRACELOG_PACKET";

		// Token: 0x0400156D RID: 5485
		public const string PRODUCT_NAME_SERIALNUMBLANKER = "PRODUCT_NAME_SERIALNUMBLANKER";

		// Token: 0x0400156E RID: 5486
		public const string PRODUCT_NAME_VERSIONCHECKER = "PRODUCT_NAME_VERSIONCHECKER";

		// Token: 0x0400156F RID: 5487
		public const string QUERY_ALL_LANGPACK = "QUERY_ALL_LANGPACK";

		// Token: 0x04001570 RID: 5488
		public const string QUERY_DEFAULT_LANGPACK = "QUERY_DEFAULT_LANGPACK";

		// Token: 0x04001571 RID: 5489
		public const string DEFAULT_UNDERSCORE = "DEFAULT_";

		// Token: 0x04001572 RID: 5490
		public const string DEFAULT_RADIO_LANGUAGE_INFO = "DEFAULT_RADIO_LANGUAGE_INFO";

		// Token: 0x04001573 RID: 5491
		public const string USER_SERIALNUM = "USER_SERIALNUM";

		// Token: 0x04001574 RID: 5492
		public const string USER_BRICKSERIALNUM = "USER_BRICKSERIALNUM";

		// Token: 0x04001575 RID: 5493
		public const string USER_TANAPANUM = "USER_TANAPANUM";

		// Token: 0x04001576 RID: 5494
		public const string USER_RGNTANAPANUM = "USER_RGNTANAPANUM";

		// Token: 0x04001577 RID: 5495
		public const string USER_RGNID = "USER_RGNID";

		// Token: 0x04001578 RID: 5496
		public const string NA_MODELNUM = "NA_MODELNUM";

		// Token: 0x04001579 RID: 5497
		public const string CF_BLVER = "CF_BLVER";

		// Token: 0x0400157A RID: 5498
		public const string CF_CPVER = "CF_CPVER";

		// Token: 0x0400157B RID: 5499
		public const string CF_FWVER = "CF_FWVER";

		// Token: 0x0400157C RID: 5500
		public const string CF_LANGPACK = "CF_LANGPACK";

		// Token: 0x0400157D RID: 5501
		public const string CF_PSDTVER = "CF_PSDTVER";

		// Token: 0x0400157E RID: 5502
		public const string CF_LANGPACK_TYPE_GRP_COUNT = "CF_LANGPACK_TYPE_GRP_COUNT";

		// Token: 0x0400157F RID: 5503
		public const string CF_LANGPACK_TYPE_GRP = "CF_LANGPACK_TYPE_GRP";

		// Token: 0x04001580 RID: 5504
		public const string CF_LANGPACK_TYPE = "CF_LANGPACK_TYPE";

		// Token: 0x04001581 RID: 5505
		public const string CF_LANGPACK_ID = "CF_LANGPACK_ID";

		// Token: 0x04001582 RID: 5506
		public const string CF_LANGPACK_VER = "CF_LANGPACK_VER";

		// Token: 0x04001583 RID: 5507
		public const string CF_SECCPVER = "CF_SECCPVER";

		// Token: 0x04001584 RID: 5508
		public const string CF_TUNECPVER = "CF_TUNECPVER";

		// Token: 0x04001585 RID: 5509
		public const string CS_BLVER = "CS_BLVER";

		// Token: 0x04001586 RID: 5510
		public const string CS_BRICKSERIALNUM = "CS_BRICKSERIALNUM";

		// Token: 0x04001587 RID: 5511
		public const string CS_PSDTVER = "CS_PSDTVER";

		// Token: 0x04001588 RID: 5512
		public const string CS_LANGPACK_TYPE_GRP_COUNT = "CS_LANGPACK_TYPE_GRP_COUNT";

		// Token: 0x04001589 RID: 5513
		public const string CS_SECCPVER = "CS_SECCPVER";

		// Token: 0x0400158A RID: 5514
		public const string CS_TUNECPVER = "CS_TUNECPVER";

		// Token: 0x0400158B RID: 5515
		public const string RX_UNDERSCORE = "RX_";

		// Token: 0x0400158C RID: 5516
		public const string RX_RS_TANAPANUM = "RX_RS_TANAPANUM";

		// Token: 0x0400158D RID: 5517
		public const string RX_RS_RGNID = "RX_RS_RGNID";

		// Token: 0x0400158E RID: 5518
		public const string RX_CS_SERIALNUM = "RX_CS_SERIALNUM";

		// Token: 0x0400158F RID: 5519
		public const string RX_RS_MODELNUM = "RX_RS_MODELNUM";

		// Token: 0x04001590 RID: 5520
		public const string RX_CS_CPVER = "RX_CS_CPVER";

		// Token: 0x04001591 RID: 5521
		public const string RX_CS_FWVER = "RX_CS_FWVER";

		// Token: 0x04001592 RID: 5522
		public const string RX_CS_BLVER = "RX_CS_BLVER";

		// Token: 0x04001593 RID: 5523
		public const string RX_CS_BRICKSERIALNUM = "RX_CS_BRICKSERIALNUM";

		// Token: 0x04001594 RID: 5524
		public const string RX_CS_PSDTVER = "RX_CS_PSDTVER";

		// Token: 0x04001595 RID: 5525
		public const string RX_CS_SECCPVER = "RX_CS_SECCPVER";

		// Token: 0x04001596 RID: 5526
		public const string RX_CS_TUNECPVER = "RX_CS_TUNECPVER";

		// Token: 0x04001597 RID: 5527
		public const string RESULT_MODELNUM = "RESULT_MODELNUM";

		// Token: 0x04001598 RID: 5528
		public const string RESULT_SERIALNUM = "RESULT_SERIALNUM";

		// Token: 0x04001599 RID: 5529
		public const string RESULT_TANAPANUM = "RESULT_TANAPANUM";

		// Token: 0x0400159A RID: 5530
		public const string RESULT_RGNID = "RESULT_RGNID";

		// Token: 0x0400159B RID: 5531
		public const string RESULT_CPVER = "RESULT_CPVER";

		// Token: 0x0400159C RID: 5532
		public const string RESULT_FWVER = "RESULT_FWVER";

		// Token: 0x0400159D RID: 5533
		public const string RESULT_BLVER = "RESULT_BLVER";

		// Token: 0x0400159E RID: 5534
		public const string RESULT_BRICKSERIALNUM = "RESULT_BRICKSERIALNUM";

		// Token: 0x0400159F RID: 5535
		public const string RESULT_LANGPACK = "RESULT_LANGPACK";

		// Token: 0x040015A0 RID: 5536
		public const string RESULT_PSDTVER = "RESULT_PSDTVER";

		// Token: 0x040015A1 RID: 5537
		public const string RESULT_LANGPACK_ID = "RESULT_LANGPACK_ID";

		// Token: 0x040015A2 RID: 5538
		public const string RESULT_LANGPACK_VER = "RESULT_LANGPACK_VER";

		// Token: 0x040015A3 RID: 5539
		public const string DEFAULT_RESULT_LANGPACK = "DEFAULT_RESULT_LANGPACK";

		// Token: 0x040015A4 RID: 5540
		public const string RESULTS_SUMMARY = "RESULTS_SUMMARY";

		// Token: 0x040015A5 RID: 5541
		public const string RESULT_SECCPVER = "RESULT_SECCPVER";

		// Token: 0x040015A6 RID: 5542
		public const string RESULT_TUNECPVER = "RESULT_TUNECPVER";

		// Token: 0x040015A7 RID: 5543
		public const string SETTANAPANUMVAL = "SETTANAPANUMVAL";

		// Token: 0x040015A8 RID: 5544
		public const string LOG_FOLDER_LOC = "LOG_FOLDER_LOC";

		// Token: 0x040015A9 RID: 5545
		public const string MAPPING_FILE_LOC = "MAPPING_FILE_LOC";

		// Token: 0x040015AA RID: 5546
		public const string FILE_PATH_SETTING_NODE = "/FILE_PATH_SETTING/";

		// Token: 0x040015AB RID: 5547
		public const string FLOW_CTRL_FOLDER_LOC = "FLOW_CTRL_FOLDER_LOC";

		// Token: 0x040015AC RID: 5548
		public const string RESULTS_FLOWCTRL = "RESULTS_FLOWCTRL";

		// Token: 0x040015AD RID: 5549
		public const string LBL_ERROR_MESSAGE = "LBL_ERROR_MESSAGE";

		// Token: 0x040015AE RID: 5550
		public const string LBL_SECCPVER = "LBL_SECCPVER";

		// Token: 0x040015AF RID: 5551
		public const string LBL_TUNECPVER = "LBL_TUNECPVER";

		// Token: 0x040015B0 RID: 5552
		public const string RESULT_TRUE = "RESULT_TRUE";

		// Token: 0x040015B1 RID: 5553
		public const string RESULT_FALSE = "RESULT_FALSE";

		// Token: 0x040015B2 RID: 5554
		public const string LBL_CPVER = "LBL_CPVER";

		// Token: 0x040015B3 RID: 5555
		public const string LBL_RXCPVER = "LBL_RXCPVER";

		// Token: 0x040015B4 RID: 5556
		public const string LBL_MODELNUM = "LBL_MODELNUM";

		// Token: 0x040015B5 RID: 5557
		public const string LBL_RXMODELNUM = "LBL_RXMODELNUM";

		// Token: 0x040015B6 RID: 5558
		public const string LBL_RXBRICKSERIALNUM = "LBL_RXBRICKSERIALNUM";

		// Token: 0x040015B7 RID: 5559
		public const string LBL_DEVICESERIALNUM = "LBL_DEVICESERIALNUM";

		// Token: 0x040015B8 RID: 5560
		public const string LBL_RXDEVICESERIALNUM = "LBL_RXDEVICESERIALNUM";

		// Token: 0x040015B9 RID: 5561
		public const string LBL_DEVICETANAPANUM = "LBL_DEVICETANAPANUM";

		// Token: 0x040015BA RID: 5562
		public const string LBL_RXDEVICETANAPANUM = "LBL_RXDEVICETANAPANUM";

		// Token: 0x040015BB RID: 5563
		public const string LBL_FWVER = "LBL_FWVER";

		// Token: 0x040015BC RID: 5564
		public const string LBL_RXFWVER = "LBL_RXFWVER";

		// Token: 0x040015BD RID: 5565
		public const string LBL_BOOTLOADER = "LBL_BOOTLOADER";

		// Token: 0x040015BE RID: 5566
		public const string LBL_RXBOOTLOADER = "LBL_RXBOOTLOADER";

		// Token: 0x040015BF RID: 5567
		public const string LBL_PSDT = "LBL_PSDT";

		// Token: 0x040015C0 RID: 5568
		public const string LBL_RXPSDT = "LBL_RXPSDT";

		// Token: 0x040015C1 RID: 5569
		public const string LBL_FREQUENCYRANGE = "LBL_FREQUENCYRANGE";

		// Token: 0x040015C2 RID: 5570
		public const string LBL_RXFREQUENCYRANGE = "LBL_RXFREQUENCYRANGE";

		// Token: 0x040015C3 RID: 5571
		public const string LBL_LASTPROGRAMMEDSOURCE = "LBL_LASTPROGRAMMEDSOURCE";

		// Token: 0x040015C4 RID: 5572
		public const string LBL_RXLASTPROGRAMMEDSOURCE = "LBL_RXLASTPROGRAMMEDSOURCE";

		// Token: 0x040015C5 RID: 5573
		public const string LBL_LASTPROGRAMMEDDATETIME = "LBL_LASTPROGRAMMEDDATETIME";

		// Token: 0x040015C6 RID: 5574
		public const string LBL_RXLASTPROGRAMMEDDATETIME = "LBL_RXLASTPROGRAMMEDDATETIME";

		// Token: 0x040015C7 RID: 5575
		public const string LBL_REGION = "LBL_REGION";

		// Token: 0x040015C8 RID: 5576
		public const string LBL_RXREGION = "LBL_RXREGION";

		// Token: 0x040015C9 RID: 5577
		public const string LBL_TXBRICKSERIALNUM = "LBL_TXBRICKSERIALNUM";

		// Token: 0x040015CA RID: 5578
		public const string LBL_MODELTYPE = "LBL_MODELTYPE";

		// Token: 0x040015CB RID: 5579
		public const string LBL_TXBOARD = "LBL_TXBOARD";

		// Token: 0x040015CC RID: 5580
		public const string LBL_RXBOARD = "LBL_RXBOARD";

		// Token: 0x040015CD RID: 5581
		public const string LBL_SINGLEMODELTYPE = "LBL_SINGLEMODELTYPE";

		// Token: 0x040015CE RID: 5582
		public const string S_MIGRATION = "Migration";

		// Token: 0x040015CF RID: 5583
		public const string S_UPGRADE = "Upgrade";

		// Token: 0x040015D0 RID: 5584
		public const string PRODUCT_NAME_DEPOTTOOL = "MOTOTRBO Depot Tool";

		// Token: 0x040015D1 RID: 5585
		public const string BANDIT_T3000A = "T3000A";

		// Token: 0x040015D2 RID: 5586
		public const string BANDIT_T2003A = "T2003A";

		// Token: 0x040015D3 RID: 5587
		public const string FUNKWERK = "HK2036A";

		// Token: 0x040015D4 RID: 5588
		public const string ANDROS_T8319A = "T8319A";

		// Token: 0x040015D5 RID: 5589
		public const string BTN_DT_WRITE = "BTN_DT_WRITE";

		// Token: 0x040015D6 RID: 5590
		public const string BTN_DT_BLANK = "BTN_DT_BLANK";

		// Token: 0x040015D7 RID: 5591
		public const string BTN_DT_FLASH = "BTN_DT_FLASH";

		// Token: 0x040015D8 RID: 5592
		public const string BTN_DT_WRITE_KEYPAD_TYPE = "BTN_DT_WRITE_KEYPAD_TYPE";

		// Token: 0x040015D9 RID: 5593
		public const string OPERATION_UNKILL = "OPERATION_UNKILL";

		// Token: 0x040015DA RID: 5594
		public const string QueryChangeValueForUnkill = "QueryChangeValueForUnkill";

		// Token: 0x040015DB RID: 5595
		public const string PICBOX_DT_UNKILL = "PICBOX_DT_UNKILL";

		// Token: 0x040015DC RID: 5596
		public const string CYPHERRXBOARD = "CypherRxBoard";

		// Token: 0x040015DD RID: 5597
		public const string FREQ800 = "800";

		// Token: 0x040015DE RID: 5598
		public const string FREQ900 = "900";

		// Token: 0x040015DF RID: 5599
		public const string CHANNEL_CONTROL = "CHANNEL_CONTROL";

		// Token: 0x040015E0 RID: 5600
		public const string KNOCKDOWN_CONTROL = "KNOCKDOWN_CONTROL";

		// Token: 0x040015E1 RID: 5601
		public const string KNOCKDOWN = "KNOCKDOWN";

		// Token: 0x040015E2 RID: 5602
		public const string CONDITION = "Condition";

		// Token: 0x040015E3 RID: 5603
		public const string CONDITION_VALUE = "Condition_Value";

		// Token: 0x040015E4 RID: 5604
		public const string SUB_TYPE = "SUB_TYPE";

		// Token: 0x040015E5 RID: 5605
		public const string Parameter = "Parameter";

		// Token: 0x040015E6 RID: 5606
		public const string WRITE = "WRITE";

		// Token: 0x040015E7 RID: 5607
		public const string ELEMENT = "element";

		// Token: 0x040015E8 RID: 5608
		public const string MAINDATAROOTTAG = "<RDAC_MAIN_DATASET></RDAC_MAIN_DATASET>";

		// Token: 0x040015E9 RID: 5609
		public const string LOGDATAROOTTAG = "<RDAC_LOG_DATASET></RDAC_LOG_DATASET>";

		// Token: 0x040015EA RID: 5610
		public const string CHANNELALIAS = "CHANNELALIAS";

		// Token: 0x040015EB RID: 5611
		public const string NA_RDAC_MULSYS = "NA_RDAC_MULSYS";

		// Token: 0x040015EC RID: 5612
		public const string AS_RDAC_MULSYS = "AS_RDAC_MULSYS";

		// Token: 0x040015ED RID: 5613
		public const string LA_RDAC_MULSYS = "LA_RDAC_MULSYS";

		// Token: 0x040015EE RID: 5614
		public const string EM_RDAC_MULSYS = "EM_RDAC_MULSYS";

		// Token: 0x040015EF RID: 5615
		public const string RDAC = "RDAC";

		// Token: 0x040015F0 RID: 5616
		public const string PRODUCT_NAME_RDAC = "MOTOTRBO RDAC";

		// Token: 0x040015F1 RID: 5617
		public const string PRODUCT_NAME_CPS = "MOTOTRBO CPS";

		// Token: 0x040015F2 RID: 5618
		public const string VOTING_ENABLE_STATUS = "VOTING_ENABLE_STATUS";

		// Token: 0x040015F3 RID: 5619
		public const string VOTING_STATUS_UPDATE_RATE = "VOTING_STATUS_UPDATE_RATE";

		// Token: 0x040015F4 RID: 5620
		public const string SET_VOTING_STATUS_UPDATE_RATE = "SET_VOTING_STATUS_UPDATE_RATE";

		// Token: 0x040015F5 RID: 5621
		public const string ENABLE_REPEATER_VOTING = "ENABLE_REPEATER_VOTING";

		// Token: 0x040015F6 RID: 5622
		public const string DISABLE_REPEATER_VOTING = "DISABLE_REPEATER_VOTING";

		// Token: 0x040015F7 RID: 5623
		public const string FORCE_VOTE_SETTING = "FORCE_VOTE_SETTING";

		// Token: 0x040015F8 RID: 5624
		public const string FORCE_VOTE_PEER_ID = "FORCE_VOTE_PEER_ID";

		// Token: 0x040015F9 RID: 5625
		public const string FORCE_VOTE = "FORCE_VOTE";

		// Token: 0x040015FA RID: 5626
		public const string CANCEL_FORCE_VOTE = "CANCEL_FORCE_VOTE";

		// Token: 0x040015FB RID: 5627
		public const string NOT_FORCE_VOTE = "NOT_FORCE_VOTE";

		// Token: 0x040015FC RID: 5628
		public const string DIAGNOSTICS = "DIAGNOSTICS";

		// Token: 0x040015FD RID: 5629
		public const string ESTIMATED_ASYMMETRY_VALUE = "ESTIMATED_ASYMMETRY_VALUE";

		// Token: 0x040015FE RID: 5630
		public const string ESTIMATED_ASYMMETRY = "ESTIMATED_ASYMMETRY";

		// Token: 0x040015FF RID: 5631
		public const string SLOT1_BURST_ARRIVE_LATE = "SLOT1_BURST_ARRIVE_LATE";

		// Token: 0x04001600 RID: 5632
		public const string BURST_ARRIVE_LATE = "BURST_ARRIVE_LATE";

		// Token: 0x04001601 RID: 5633
		public const string RECEIVER_PEER_ID = "RECEIVER_PEER_ID";

		// Token: 0x04001602 RID: 5634
		public const string SLOT1_VOTED = "SLOT1_VOTED";

		// Token: 0x04001603 RID: 5635
		public const string SYNC_STATUS = "SYNC_STATUS";

		// Token: 0x04001604 RID: 5636
		public const string TXPOWER_CONTROL = "TXPOWER_CONTROL";

		// Token: 0x04001605 RID: 5637
		public const string STRING_NOT_APPLICABLE = "NOT_APPLICABLE";

		// Token: 0x04001606 RID: 5638
		public const string External_Battery_Voltage = "External_Battery_Voltage";

		// Token: 0x04001607 RID: 5639
		public const string PA_Voltage = "PA_Voltage";

		// Token: 0x04001608 RID: 5640
		public const string PSU_Voltage = "PSU_Voltage";

		// Token: 0x04001609 RID: 5641
		public const string AC_Voltage = "AC_Voltage";

		// Token: 0x0400160A RID: 5642
		public const string DC_Current = "DC_Current";

		// Token: 0x0400160B RID: 5643
		public const string RSSI_Slot1 = "RSSI_Slot1";

		// Token: 0x0400160C RID: 5644
		public const string RSSI_Slot2 = "RSSI_Slot2";

		// Token: 0x0400160D RID: 5645
		public const string Modem_Temp = "Modem_Temp";

		// Token: 0x0400160E RID: 5646
		public const string Modem_Current = "Modem_Current";

		// Token: 0x0400160F RID: 5647
		public const string Modem_Voltage = "Modem_Voltage";

		// Token: 0x04001610 RID: 5648
		public const string Control_Voltage = "Control_Voltage";

		// Token: 0x04001611 RID: 5649
		public const string PA_Current1 = "PA_Current1";

		// Token: 0x04001612 RID: 5650
		public const string PA_Current2 = "PA_Current2";

		// Token: 0x04001613 RID: 5651
		public const string PA_Current3 = "PA_Current3";

		// Token: 0x04001614 RID: 5652
		public const string PA_Current4 = "PA_Current4";

		// Token: 0x04001615 RID: 5653
		public const string PA_Temperature = "PA_Temperature";

		// Token: 0x04001616 RID: 5654
		public const string Output_Power = "Output_Power";

		// Token: 0x04001617 RID: 5655
		public const string VSWR = "VSWR";

		// Token: 0x04001618 RID: 5656
		public const string Transmit_Frequency = "Transmit_Frequency";

		// Token: 0x04001619 RID: 5657
		public const string Transmit_Power = "Transmit_Power";

		// Token: 0x0400161A RID: 5658
		public const string External_Battery_Charging_Voltage = "External_Battery_Charging_Voltage";

		// Token: 0x0400161B RID: 5659
		public const string External_Battery_Charging_Current = "External_Battery_Charging_Current";

		// Token: 0x0400161C RID: 5660
		public const string Exciter_Current_Sense = "Exciter_Current_Sense";

		// Token: 0x0400161D RID: 5661
		public const char STR_DOT = '.';

		// Token: 0x0400161E RID: 5662
		public const string PHOENIX_MOBILE = "PHOENIX_MOBILE";

		// Token: 0x0400161F RID: 5663
		public const string PHOENIX_MORPHEUS = "Phoenix_Morpheus";

		// Token: 0x04001620 RID: 5664
		public const string PHOENIX_MORPHEUSP = "Phoenix_MorpheusP";

		// Token: 0x04001621 RID: 5665
		public const string PHOENIX_PORTABLE = "PHOENIX_PORTABLE";

		// Token: 0x04001622 RID: 5666
		public const string PHOENIX_NEO = "Phoenix_Neo";

		// Token: 0x04001623 RID: 5667
		public const string PHOENIX_NEOP = "Phoenix_NeoP";

		// Token: 0x04001624 RID: 5668
		public const string PHOENIX_REPEATER = "PHOENIX_REPEATER";

		// Token: 0x04001625 RID: 5669
		public const string PHOENIX_CYPHER = "Phoenix_Cypher";

		// Token: 0x04001626 RID: 5670
		public const string UNKNOWN = "UNKNOWN";

		// Token: 0x04001627 RID: 5671
		public const string MATRIX = "MATRIX";

		// Token: 0x04001628 RID: 5672
		public const string GEMSTONE = "GEMSTONE";

		// Token: 0x04001629 RID: 5673
		public const string PARADISE_LIGHT = "PARADISE_LIGHT";

		// Token: 0x0400162A RID: 5674
		public const string MALTA_TYPE = "MALTA";

		// Token: 0x0400162B RID: 5675
		public const string TIMOR_TYPE = "TIMOR";

		// Token: 0x0400162C RID: 5676
		public const string BERMUDA_TYPE = "BERMUDA";

		// Token: 0x0400162D RID: 5677
		public const string TAHITI_TYPE = "TAHITI";

		// Token: 0x0400162E RID: 5678
		public const string TAHITIPLUS_TYPE = "TAHITIPLUS";

		// Token: 0x0400162F RID: 5679
		public const string BAHAMA_TYPE = "BAHAMA";

		// Token: 0x04001630 RID: 5680
		public const string PHOENIX = "PHOENIX";

		// Token: 0x04001631 RID: 5681
		public const string PHOENIX_PREFIX = "PHOENIX_";

		// Token: 0x04001632 RID: 5682
		public const string FLAG_PHOENIX = "...PHOENIX";

		// Token: 0x04001633 RID: 5683
		public const int FLAGPRODUCT_LENGTH = 20;

		// Token: 0x04001634 RID: 5684
		public const string FLAG_GEMSTONE = "...GEMSTONE";

		// Token: 0x04001635 RID: 5685
		public const string FLAG_BAHAMA = "...BAHAMA";

		// Token: 0x04001636 RID: 5686
		public const string CHOICE_700800 = "STR_700800";

		// Token: 0x04001637 RID: 5687
		public const string CHOICE_900 = "STR_900";

		// Token: 0x04001638 RID: 5688
		public const string CHOICE_PRIMARYONLY = "PRIMARYONLY";

		// Token: 0x04001639 RID: 5689
		public const string CHOICE_PRIMARYSECONDARY = "PRIMARYSECONDARY";

		// Token: 0x0400163A RID: 5690
		public const string CHOICE_PERPERSONALITY = "PERPERSONALITY";

		// Token: 0x0400163B RID: 5691
		public const string CHOICE_PERTALKGROUP = "PERTALKGROUP";

		// Token: 0x0400163C RID: 5692
		public const string CHOICE_DISABLED = "DISABLED";

		// Token: 0x0400163D RID: 5693
		public const int MAX_CONTROL_CHANNEL_SMARTZONE = 128;

		// Token: 0x0400163E RID: 5694
		public const int MAX_CONTROL_CHANNEL_SMARTNET = 8;

		// Token: 0x0400163F RID: 5695
		public const double MIN_FREQ_AT_800M = 806.0;

		// Token: 0x04001640 RID: 5696
		public const double MAX_FREQ_AT_800M = 870.0;

		// Token: 0x04001641 RID: 5697
		public const double MIN_FREQ_AT_900M = 896.0;

		// Token: 0x04001642 RID: 5698
		public const double MAX_FREQ_AT_900M = 941.0;

		// Token: 0x04001643 RID: 5699
		public const string BAND800 = "800";

		// Token: 0x04001644 RID: 5700
		public const string BAND900 = "900";

		// Token: 0x04001645 RID: 5701
		public const string ATTR_BAND = "band";

		// Token: 0x04001646 RID: 5702
		public const string TYPE_ATG = "ATG";

		// Token: 0x04001647 RID: 5703
		public const string TYPE_DYN = "DYN";

		// Token: 0x04001648 RID: 5704
		public const string SR_SUSPALLSCAN = "SR_SUSPALLSCAN";

		// Token: 0x04001649 RID: 5705
		public const string SR_SCASRCHTM = "SR_SCASRCHTM";

		// Token: 0x0400164A RID: 5706
		public const string SR_FSATM = "SR_FSATM";

		// Token: 0x0400164B RID: 5707
		public const string TRKS_RPTOFFSET = "TRKS_RPTOFFSET";

		// Token: 0x0400164C RID: 5708
		public const string REPEATER_OFFSET_900M = "39";

		// Token: 0x0400164D RID: 5709
		public const string REPEATER_OFFSET_800M = "45";

		// Token: 0x0400164E RID: 5710
		public const string REPEATER_OFFSET_NON_8900M = "3";

		// Token: 0x0400164F RID: 5711
		public const string TRKR_MINFRONTPORCH_ENABLE = "83";

		// Token: 0x04001650 RID: 5712
		public const string TRKR_MINFRONTPORCH_DISABLE_PORTABLE = "10";

		// Token: 0x04001651 RID: 5713
		public const string TRKR_MINFRONTPORCH_DISABLE_MOBILE = "11";

		// Token: 0x04001652 RID: 5714
		public const string TRK_RAD_CMP_TYPE_GRP = "TRK_RAD_CMP_TYPE_GRP";

		// Token: 0x04001653 RID: 5715
		public const string TRK_RAD_CMP_TYPE = "TRK_RAD_CMP_TYPE";

		// Token: 0x04001654 RID: 5716
		public const string TRKR_MINFRONTPORCH = "TRKR_MINFRONTPORCH";

		// Token: 0x04001655 RID: 5717
		public const string TRKR_MINFRONTPORCH_CB = "TRKR_MINFRONTPORCH_CB";

		// Token: 0x04001656 RID: 5718
		public const string TRK_SYS_CMP_TYPE = "TRK_SYS_CMP_TYPE";

		// Token: 0x04001657 RID: 5719
		public const string TRK_SYS_CMP_TYPE_GRP = "TRK_SYS_CMP_TYPE_GRP";

		// Token: 0x04001658 RID: 5720
		public const string TRKS_TRKSYSALIAS = "TRKS_TRKSYSALIAS";

		// Token: 0x04001659 RID: 5721
		public const string TRKS_CVRGTY = "TRKS_CVRGTY";

		// Token: 0x0400165A RID: 5722
		public const string TRKS_TRKSTAIND = "TRKS_TRKSTAIND";

		// Token: 0x0400165B RID: 5723
		public const string TRKS_RMEN = "TRKS_RMEN";

		// Token: 0x0400165C RID: 5724
		public const string TRKS_RMBASETM = "TRKS_RMBASETM";

		// Token: 0x0400165D RID: 5725
		public const string TRKS_BDSEL = "TRKS_BDSEL";

		// Token: 0x0400165E RID: 5726
		public const string TRKS_TRKCHANBANDW = "TRKS_TRKCHANBANDW";

		// Token: 0x0400165F RID: 5727
		public const string TRKS_SPLCHAN = "TRKS_SPLCHAN";

		// Token: 0x04001660 RID: 5728
		public const string TRKS_HMINDID = "TRKS_HMINDID";

		// Token: 0x04001661 RID: 5729
		public const string TRKS_CHANASSTY = "TRKS_CHANASSTY";

		// Token: 0x04001662 RID: 5730
		public const string TRKS_DYNRG = "TRKS_DYNRG";

		// Token: 0x04001663 RID: 5731
		public const string TRK_SYS_CC_DLL_TYPE = "TRK_SYS_CC_DLL_TYPE";

		// Token: 0x04001664 RID: 5732
		public const string TRK_SYS_CC_DLH_TYPE = "TRK_SYS_CC_DLH_TYPE";

		// Token: 0x04001665 RID: 5733
		public const string TRK_SYS_CC_DLT_TYPE = "TRK_SYS_CC_DLT_TYPE";

		// Token: 0x04001666 RID: 5734
		public const string TRKS_TSCCLITEM = "TRKS_TSCCLITEM";

		// Token: 0x04001667 RID: 5735
		public const string TRK_SYS_MSG_ALS_DLL_TYPE = "TRK_SYS_MSG_ALS_DLL_TYPE";

		// Token: 0x04001668 RID: 5736
		public const string TRK_SYS_MSG_ALS_DLH_TYPE = "TRK_SYS_MSG_ALS_DLH_TYPE";

		// Token: 0x04001669 RID: 5737
		public const string TRK_SYS_MSG_ALS_DLT_TYPE = "TRK_SYS_MSG_ALS_DLT_TYPE";

		// Token: 0x0400166A RID: 5738
		public const string TRKSMA_TRKSYSMSGALSALIAS = "TRKSMA_TRKSYSMSGALSALIAS";

		// Token: 0x0400166B RID: 5739
		public const string TRKS_TSMALITEM = "TRKS_TSMALITEM";

		// Token: 0x0400166C RID: 5740
		public const string TRK_SYS_STS_ALS_DLL_TYPE = "TRK_SYS_STS_ALS_DLL_TYPE";

		// Token: 0x0400166D RID: 5741
		public const string TRK_SYS_STS_ALS_DLH_TYPE = "TRK_SYS_STS_ALS_DLH_TYPE";

		// Token: 0x0400166E RID: 5742
		public const string TRK_SYS_STS_ALS_DLT_TYPE = "TRK_SYS_STS_ALS_DLT_TYPE";

		// Token: 0x0400166F RID: 5743
		public const string TRKSSTSA_TRKSYSSTSALSALIAS = "TRKSSTSA_TRKSYSSTSALSALIAS";

		// Token: 0x04001670 RID: 5744
		public const string TRKS_TSSALITEM = "TRKS_TSSALITEM";

		// Token: 0x04001671 RID: 5745
		public const string TRK_SYS_SITE_ALS_DLL_TYPE = "TRK_SYS_SITE_ALS_DLL_TYPE";

		// Token: 0x04001672 RID: 5746
		public const string TRK_SYS_SITE_ALS_DLH_TYPE = "TRK_SYS_SITE_ALS_DLH_TYPE";

		// Token: 0x04001673 RID: 5747
		public const string TRK_SYS_SITE_ALS_DLT_TYPE = "TRK_SYS_SITE_ALS_DLT_TYPE";

		// Token: 0x04001674 RID: 5748
		public const string TRKSSITEA_TRKSYSSITEALSALIAS = "TRKSSITEA_TRKSYSSITEALSALIAS";

		// Token: 0x04001675 RID: 5749
		public const string TRKS_TSSITEALITEM = "TRKS_TSSITEALITEM";

		// Token: 0x04001676 RID: 5750
		public const string TRKS_DTPROITEM = "TRKS_DTPROITEM";

		// Token: 0x04001677 RID: 5751
		public const string TRKS_TSACILITEM = "TRKS_TSACILITEM";

		// Token: 0x04001678 RID: 5752
		public const string TRKS_TSIIOCALITEM = "TRKS_TSIIOCALITEM";

		// Token: 0x04001679 RID: 5753
		public const string TRKS_TSSATLITEM = "TRKS_TSSATLITEM";

		// Token: 0x0400167A RID: 5754
		public const string TRKS_TSSATLITEMID = "TRKS_TSSATLITEMID";

		// Token: 0x0400167B RID: 5755
		public const string TRKS_TSMATLITEM = "TRKS_TSMATLITEM";

		// Token: 0x0400167C RID: 5756
		public const string TRKS_TSMATLITEMID = "TRKS_TSMATLITEMID";

		// Token: 0x0400167D RID: 5757
		public const string TRKS_TSSITEATLITEM = "TRKS_TSSITEATLITEM";

		// Token: 0x0400167E RID: 5758
		public const string TRKS_TSSITEATLITEMID = "TRKS_TSSITEATLITEMID";

		// Token: 0x0400167F RID: 5759
		public const string TRKS_SKMFPROLITEM = "TRKS_SKMFPROLITEM";

		// Token: 0x04001680 RID: 5760
		public const string TRKS_DYNTGPER = "TRKS_DYNTGPER";

		// Token: 0x04001681 RID: 5761
		public const string TRKS_ATGTGPER = "TRKS_ATGTGPER";

		// Token: 0x04001682 RID: 5762
		public const string SP_TRKSYS = "SP_TRKSYS";

		// Token: 0x04001683 RID: 5763
		public const string TRKSZE_AFFHOTM = "TRKSZE_AFFHOTM";

		// Token: 0x04001684 RID: 5764
		public const string TRKSZE_RSSIPATHR = "TRKSZE_RSSIPATHR";

		// Token: 0x04001685 RID: 5765
		public const string TRKSZE_RSSIAGTHR = "TRKSZE_RSSIAGTHR";

		// Token: 0x04001686 RID: 5766
		public const string TRKSZE_RSSIGVTHR = "TRKSZE_RSSIGVTHR";

		// Token: 0x04001687 RID: 5767
		public const string TRKSZE_RSSIVETHR = "TRKSZE_RSSIVETHR";

		// Token: 0x04001688 RID: 5768
		public const string TRKSZE_FLTCONSK1 = "TRKSZE_FLTCONSK1";

		// Token: 0x04001689 RID: 5769
		public const string TRKSZE_FLTCONSK2 = "TRKSZE_FLTCONSK2";

		// Token: 0x0400168A RID: 5770
		public const string TRKSZE_FLTCONSK3 = "TRKSZE_FLTCONSK3";

		// Token: 0x0400168B RID: 5771
		public const string TRKSZE_FLTTHRCONST1 = "TRKSZE_FLTTHRCONST1";

		// Token: 0x0400168C RID: 5772
		public const string TRKSZE_FLTTHRCONST2 = "TRKSZE_FLTTHRCONST2";

		// Token: 0x0400168D RID: 5773
		public const string TRKSZE_FLTTHRCONST3 = "TRKSZE_FLTTHRCONST3";

		// Token: 0x0400168E RID: 5774
		public const string TRKSZE_FSCCSTM = "TRKSZE_FSCCSTM";

		// Token: 0x0400168F RID: 5775
		public const string TRKSZE_FSCCSIND = "TRKSZE_FSCCSIND";

		// Token: 0x04001690 RID: 5776
		public const string TRKEP_EMERTY = "TRKEP_EMERTY";

		// Token: 0x04001691 RID: 5777
		public const string TRKEP_EMERATTXMD = "TRKEP_EMERATTXMD";

		// Token: 0x04001692 RID: 5778
		public const string TRKEP_EMERRTCNT = "TRKEP_EMERRTCNT";

		// Token: 0x04001693 RID: 5779
		public const string TRKEP_TACEMER = "TRKEP_TACEMER";

		// Token: 0x04001694 RID: 5780
		public const string TRKEP_EMERCONACKREQ = "TRKEP_EMERCONACKREQ";

		// Token: 0x04001695 RID: 5781
		public const string TRKEP_DEFPTTID = "TRKEP_DEFPTTID";

		// Token: 0x04001696 RID: 5782
		public const string TRKEP_EMERHOTMICEN = "TRKEP_EMERHOTMICEN";

		// Token: 0x04001697 RID: 5783
		public const string TRKEP_HMTMTXPER = "TRKEP_HMTMTXPER";

		// Token: 0x04001698 RID: 5784
		public const string TRKP_DEFTGIDNUM = "TRKP_DEFTGIDNUM";

		// Token: 0x04001699 RID: 5785
		public const string NOEMERGENCY = "NOEMERGENCY";

		// Token: 0x0400169A RID: 5786
		public const string ALARMONLY = "ALARMONLY";

		// Token: 0x0400169B RID: 5787
		public const string CALLONLY = "CALLONLY";

		// Token: 0x0400169C RID: 5788
		public const string ALARMCALL = "ALARMCALL";

		// Token: 0x0400169D RID: 5789
		public const string RC_STIS = "RC_STIS";

		// Token: 0x0400169E RID: 5790
		public const string PRW_TPTEN = "PRW_TPTEN";

		// Token: 0x0400169F RID: 5791
		public const string PRW_RDINHBCHID = "PRW_RDINHBCHID";

		// Token: 0x040016A0 RID: 5792
		public const string PRW_RDINHBZNID = "PRW_RDINHBZNID";

		// Token: 0x040016A1 RID: 5793
		public const string TRKP_TPT = "TRKP_TPT";

		// Token: 0x040016A2 RID: 5794
		public const string CP_TXINHQUKKOVRDEN = "CP_TXINHQUKKOVRDEN";

		// Token: 0x040016A3 RID: 5795
		public const string TRKR_ISWWINADJ = "TRKR_ISWWINADJ";

		// Token: 0x040016A4 RID: 5796
		public const string TRKS_HMSYSID = "TRKS_HMSYSID";

		// Token: 0x040016A5 RID: 5797
		public const string TRKS_DEFRCMADDR = "TRKS_DEFRCMADDR";

		// Token: 0x040016A6 RID: 5798
		public const string TRKS_PPSPT = "TRKS_PPSPT";

		// Token: 0x040016A7 RID: 5799
		public const string TRKS_AFFTYPE = "TRKS_AFFTYPE";

		// Token: 0x040016A8 RID: 5800
		public const string TRKS_FSCT = "TRKS_FSCT";

		// Token: 0x040016A9 RID: 5801
		public const string TRKS_CTC = "TRKS_CTC";

		// Token: 0x040016AA RID: 5802
		public const string TRKPAGTGFLELH_FSTY = "TRKPAGTGFLELH_FSTY";

		// Token: 0x040016AB RID: 5803
		public const string TRKPAGTGFLELH_FSAGEN = "TRKPAGTGFLELH_FSAGEN";

		// Token: 0x040016AC RID: 5804
		public const string TRKPAGTGFLELH_AGIDNUM = "TRKPAGTGFLELH_AGIDNUM";

		// Token: 0x040016AD RID: 5805
		public const string TRKPAGTGFLELH_AGIDNUM_NONE_VALUE_STR = "4095";

		// Token: 0x040016AE RID: 5806
		public const string TRKPAGTGFLELL_FSTGPSEN = "TRKPAGTGFLELL_FSTGPSEN";

		// Token: 0x040016AF RID: 5807
		public const string TRKPAGTGFLELH_FSAGPSEN = "TRKPAGTGFLELH_FSAGPSEN";

		// Token: 0x040016B0 RID: 5808
		public const string TRKPAGTGFLELH_FSPERSFPEN = "TRKPAGTGFLELH_FSPERSFPEN";

		// Token: 0x040016B1 RID: 5809
		public const string CPCOLELL_DIRTXFREQ = "CPCOLELL_DIRTXFREQ";

		// Token: 0x040016B2 RID: 5810
		public const string TRKAASDLELL_RXFREQ = "TRKAASDLELL_RXFREQ";

		// Token: 0x040016B3 RID: 5811
		public const string TRKAASDLELL_TXFREQ = "TRKAASDLELL_TXFREQ";

		// Token: 0x040016B4 RID: 5812
		public const string TRKABCCDLELL_RXFREQ = "TRKABCCDLELL_RXFREQ";

		// Token: 0x040016B5 RID: 5813
		public const string TRKABCCDLELL_TXFREQ = "TRKABCCDLELL_TXFREQ";

		// Token: 0x040016B6 RID: 5814
		public const string TRKIIASDLELL_RXFREQ = "TRKIIASDLELL_RXFREQ";

		// Token: 0x040016B7 RID: 5815
		public const string TRKIIASDLELL_TXFREQ = "TRKIIASDLELL_TXFREQ";

		// Token: 0x040016B8 RID: 5816
		public const string TRKIIBCCDLELL_RXFREQ = "TRKIIBCCDLELL_RXFREQ";

		// Token: 0x040016B9 RID: 5817
		public const string TRKIIBCCDLELL_TXFREQ = "TRKIIBCCDLELL_TXFREQ";

		// Token: 0x040016BA RID: 5818
		public const string TRKSD_DYNFSRXFREQ = "TRKSD_DYNFSRXFREQ";

		// Token: 0x040016BB RID: 5819
		public const string TRKSD_DYNFSTXFREQ = "TRKSD_DYNFSTXFREQ";

		// Token: 0x040016BC RID: 5820
		public const string TRKPAGTGFLELL_FSTGEN = "TRKPAGTGFLELL_FSTGEN";

		// Token: 0x040016BD RID: 5821
		public const string TRKPAGTGFLELL_FSTGSFPEN = "TRKPAGTGFLELL_FSTGSFPEN";

		// Token: 0x040016BE RID: 5822
		public const string TRKPAGTGFLELL_FSTGPRIRXFREQ = "TRKPAGTGFLELL_FSTGPRIRXFREQ";

		// Token: 0x040016BF RID: 5823
		public const string TRKPAGTGFLELL_FSTGPRITXFREQ = "TRKPAGTGFLELL_FSTGPRITXFREQ";

		// Token: 0x040016C0 RID: 5824
		public const string TRKPAGTGFLELL_FSTGSECRXFREQ = "TRKPAGTGFLELL_FSTGSECRXFREQ";

		// Token: 0x040016C1 RID: 5825
		public const string TRKPAGTGFLELL_FSTGSECTXFREQ = "TRKPAGTGFLELL_FSTGSECTXFREQ";

		// Token: 0x040016C2 RID: 5826
		public const string TRKPAGTGFLELL_TGIDNUM = "TRKPAGTGFLELL_TGIDNUM";

		// Token: 0x040016C3 RID: 5827
		public const string TRKPAGTGFLELL_TGIDNUMDEC = "TRKPAGTGFLELL_TGIDNUMDEC";

		// Token: 0x040016C4 RID: 5828
		public const string TRKPAGTGFLELH_FSPERPRIRXFREQ = "TRKPAGTGFLELH_FSPERPRIRXFREQ";

		// Token: 0x040016C5 RID: 5829
		public const string TRKPAGTGFLELH_FSPERPRITXFREQ = "TRKPAGTGFLELH_FSPERPRITXFREQ";

		// Token: 0x040016C6 RID: 5830
		public const string TRKPAGTGFLELH_FSPERSECRXFREQ = "TRKPAGTGFLELH_FSPERSECRXFREQ";

		// Token: 0x040016C7 RID: 5831
		public const string TRKPAGTGFLELH_FSPERSECTXFREQ = "TRKPAGTGFLELH_FSPERSECTXFREQ";

		// Token: 0x040016C8 RID: 5832
		public const string TRKPAGTGFLELH_FSAGPRIRXFREQ = "TRKPAGTGFLELH_FSAGPRIRXFREQ";

		// Token: 0x040016C9 RID: 5833
		public const string TRKPAGTGFLELH_FSAGPRITXFREQ = "TRKPAGTGFLELH_FSAGPRITXFREQ";

		// Token: 0x040016CA RID: 5834
		public const string TRKPAGTGFLELH_FSAGSECRXFREQ = "TRKPAGTGFLELH_FSAGSECRXFREQ";

		// Token: 0x040016CB RID: 5835
		public const string TRKPAGTGFLELH_FSAGSECTXFREQ = "TRKPAGTGFLELH_FSAGSECTXFREQ";

		// Token: 0x040016CC RID: 5836
		public const string UCL_TRK_T2_ID_DLT_TYPE = "UCL_TRK_T2_ID_DLT_TYPE";

		// Token: 0x040016CD RID: 5837
		public const string UCL_TRK_T2_ID_DLH_TYPE_GRP = "UCL_TRK_T2_ID_DLH_TYPE_GRP";

		// Token: 0x040016CE RID: 5838
		public const string UCL_TRK_T2_ID_DLH_TYPE = "UCL_TRK_T2_ID_DLH_TYPE";

		// Token: 0x040016CF RID: 5839
		public const string UCL_TRK_T2_ID_DLL_TYPE = "UCL_TRK_T2_ID_DLL_TYPE";

		// Token: 0x040016D0 RID: 5840
		public const string PHNUCLELL_ONETCHCLFLG = "PHNUCLELL_ONETCHCLFLG";

		// Token: 0x040016D1 RID: 5841
		public const string TIIUCLELL_ONETCHCLFLG = "TIIUCLELL_ONETCHCLFLG";

		// Token: 0x040016D2 RID: 5842
		public const string TIIUCLELL_CALLALIAS = "TIIUCLELL_CALLALIAS";

		// Token: 0x040016D3 RID: 5843
		public const string TIIUCLELL_CALLTYPE = "TIIUCLELL_CALLTYPE";

		// Token: 0x040016D4 RID: 5844
		public const string TIIUCLELL_CALLID = "TIIUCLELL_CALLID";

		// Token: 0x040016D5 RID: 5845
		public const string UCL_GLB_PHONE_NUMBER_DLT_TYPE = "UCL_GLB_PHONE_NUMBER_DLT_TYPE";

		// Token: 0x040016D6 RID: 5846
		public const string UCL_GLB_PHONE_NUMBER_DLH_TYPE_GRP = "UCL_GLB_PHONE_NUMBER_DLH_TYPE_GRP";

		// Token: 0x040016D7 RID: 5847
		public const string UCL_GLB_PHONE_NUMBER_DLH_TYPE = "UCL_GLB_PHONE_NUMBER_DLH_TYPE";

		// Token: 0x040016D8 RID: 5848
		public const string UCL_GLB_PHONE_NUMBER_DLL_TYPE = "UCL_GLB_PHONE_NUMBER_DLL_TYPE";

		// Token: 0x040016D9 RID: 5849
		public const string PHNUCLELL_CALLALIAS = "PHNUCLELL_CALLALIAS";

		// Token: 0x040016DA RID: 5850
		public const string UCL_GLB_PHONE_NUMBER_DLH_TYPE_FTLLISHTYPE = "UCL_GLB_PHONE_NUMBER_DLH_TYPE_FTLLISHTYPE";

		// Token: 0x040016DB RID: 5851
		public const string INDOOR_LOCATION_DLT_TYPE = "INDOOR_LOCATION_DLT_TYPE";

		// Token: 0x040016DC RID: 5852
		public const string INDOOR_LOCATION_DLH_TYPE = "INDOOR_LOCATION_DLH_TYPE";

		// Token: 0x040016DD RID: 5853
		public const string INDOOR_LOCATION_DLL_TYPE = "INDOOR_LOCATION_DLL_TYPE";

		// Token: 0x040016DE RID: 5854
		public const string BTN_ADDILANCHOR = "BTN_ADDILANCHOR";

		// Token: 0x040016DF RID: 5855
		public const string BTN_DELILANCHOR = "BTN_DELILANCHOR";

		// Token: 0x040016E0 RID: 5856
		public const string INDOORLOCATIONDLH_INDOORLOCATIONENABLE = "INDOORLOCATIONDLH_INDOORLOCATIONENABLE";

		// Token: 0x040016E1 RID: 5857
		public const string INDOORLOCATIONDLH_INDOORLOCATIONSTATE = "INDOORLOCATIONDLH_INDOORLOCATIONSTATE";

		// Token: 0x040016E2 RID: 5858
		public const string INDOORLOCATIONDLH_SCANINTERVALONTIME = "INDOORLOCATIONDLH_SCANINTERVALONTIME";

		// Token: 0x040016E3 RID: 5859
		public const string INDOORLOCATIONDLH_SCANINTERVALOFFTIME = "INDOORLOCATIONDLH_SCANINTERVALOFFTIME";

		// Token: 0x040016E4 RID: 5860
		public const string INDOORLOCATIONDLH_BTLEAGGRESSIVESCAN = "INDOORLOCATIONDLH_BTLEAGGRESSIVESCAN";

		// Token: 0x040016E5 RID: 5861
		public const string INDOORLOCATIONDLH_SHOWBEACONALIAS = "INDOORLOCATIONDLH_SHOWBEACONALIAS";

		// Token: 0x040016E6 RID: 5862
		public const string INDOOR_LOCATION_DLH_TYPE_GRP = "INDOOR_LOCATION_DLH_TYPE_GRP";

		// Token: 0x040016E7 RID: 5863
		public const string ILANCHORDLL_ANCHORUUID = "ILANCHORDLL_ANCHORUUID";

		// Token: 0x040016E8 RID: 5864
		public const string ILANCHORDLL_ANCHORALIAS = "ILANCHORDLL_ANCHORALIAS";

		// Token: 0x040016E9 RID: 5865
		public const string STR_ANCHOR = "Anchor";

		// Token: 0x040016EA RID: 5866
		public const int UUIDLength = 32;

		// Token: 0x040016EB RID: 5867
		public const string TRK_CNV_PER_CMP_TYPE_GRP = "TRK_CNV_PER_CMP_TYPE_GRP";

		// Token: 0x040016EC RID: 5868
		public const string TRK_PER_CMP_TYPE_GRP = "TRK_PER_CMP_TYPE_GRP";

		// Token: 0x040016ED RID: 5869
		public const string TRK_PER_CMP_TYPE = "TRK_PER_CMP_TYPE";

		// Token: 0x040016EE RID: 5870
		public const string TRKP_TRKPERALIAS = "TRKP_TRKPERALIAS";

		// Token: 0x040016EF RID: 5871
		public const string TRKP_SLITEM = "TRKP_SLITEM";

		// Token: 0x040016F0 RID: 5872
		public const string TRKP_SLITEMID = "TRKP_SLITEMID";

		// Token: 0x040016F1 RID: 5873
		public const string TRKP_SLITEMTYPE = "TRKP_SLITEMTYPE";

		// Token: 0x040016F2 RID: 5874
		public const string TRKP_TSITEM = "TRKP_TSITEM";

		// Token: 0x040016F3 RID: 5875
		public const string TRKP_TSITEMID = "TRKP_TSITEMID";

		// Token: 0x040016F4 RID: 5876
		public const string TRKP_TSITEMTYPE = "TRKP_TSITEMTYPE";

		// Token: 0x040016F5 RID: 5877
		public const string TRKP_TPPSSLITEM = "TRKP_TPPSSLITEM";

		// Token: 0x040016F6 RID: 5878
		public const string TRKP_TPPSSLITEMID = "TRKP_TPPSSLITEMID";

		// Token: 0x040016F7 RID: 5879
		public const string TRKP_TPAGTGFLITEM = "TRKP_TPAGTGFLITEM";

		// Token: 0x040016F8 RID: 5880
		public const string TRKP_TPAGTGFLITEMID = "TRKP_TPAGTGFLITEMID";

		// Token: 0x040016F9 RID: 5881
		public const string TRKP_TPTGATLITEM = "TRKP_TPTGATLITEM";

		// Token: 0x040016FA RID: 5882
		public const string TRKP_AUTOSCAN = "TRKP_AUTOSCAN";

		// Token: 0x040016FB RID: 5883
		public const string TRKP_TRKEPITEM = "TRKP_TRKEPITEM";

		// Token: 0x040016FC RID: 5884
		public const string TRKP_HCLITEM = "TRKP_HCLITEM";

		// Token: 0x040016FD RID: 5885
		public const string TRKP_TGLSTEN = "TRKP_TGLSTEN";

		// Token: 0x040016FE RID: 5886
		public const string TRKP_TGLSTENID = "TRKP_TGLSTENID";

		// Token: 0x040016FF RID: 5887
		public const string SHADOW_HMINDID = "SHADOW_HMINDID";

		// Token: 0x04001700 RID: 5888
		public const string TRKSCCLELL_RXFREQ = "TRKSCCLELL_RXFREQ";

		// Token: 0x04001701 RID: 5889
		public const string TRKSCCLELL_TXFREQ = "TRKSCCLELL_TXFREQ";

		// Token: 0x04001702 RID: 5890
		public const string TRK_PER_PREF_SITE_DLH_TYPE_GRP = "TRK_PER_PREF_SITE_DLH_TYPE_GRP";

		// Token: 0x04001703 RID: 5891
		public const string TRK_PER_PREF_SITE_DLT_TYPE = "TRK_PER_PREF_SITE_DLT_TYPE";

		// Token: 0x04001704 RID: 5892
		public const string TRK_PER_PREF_SITE_DLH_TYPE = "TRK_PER_PREF_SITE_DLH_TYPE";

		// Token: 0x04001705 RID: 5893
		public const string TRK_PER_PREF_SITE_DLL_TYPE = "TRK_PER_PREF_SITE_DLL_TYPE";

		// Token: 0x04001706 RID: 5894
		public const string ALIAS_PREFERED_SITE_LIST = "TRKPPS_TRKPERPREFSITEALIAS";

		// Token: 0x04001707 RID: 5895
		public const string TRKPPS_TRKPERPREFSITEALIAS = "TRKPPS_TRKPERPREFSITEALIAS";

		// Token: 0x04001708 RID: 5896
		public const string TRKPPSLELL_STID = "TRKPPSLELL_STID";

		// Token: 0x04001709 RID: 5897
		public const string TRK_PER_AG_TG_FS_DLH_TYPE_GRP = "TRK_PER_AG_TG_FS_DLH_TYPE_GRP";

		// Token: 0x0400170A RID: 5898
		public const string TRK_PER_AG_TG_FS_DLT_TYPE = "TRK_PER_AG_TG_FS_DLT_TYPE";

		// Token: 0x0400170B RID: 5899
		public const string TRK_PER_AG_TG_FS_DLH_TYPE = "TRK_PER_AG_TG_FS_DLH_TYPE";

		// Token: 0x0400170C RID: 5900
		public const string TRK_PER_AG_TG_FS_DLL_TYPE = "TRK_PER_AG_TG_FS_DLL_TYPE";

		// Token: 0x0400170D RID: 5901
		public const string ALIAS_TALKGROUP_LIST = "TRKPAGTGFLELL_TRKPERAGTGFSALIAS";

		// Token: 0x0400170E RID: 5902
		public const string TRKPAGTGFLELL_TRKPERAGTGFSALIAS = "TRKPAGTGFLELL_TRKPERAGTGFSALIAS";

		// Token: 0x0400170F RID: 5903
		public const string TRKPAGTGF_TRKPERAGTGFSALIAS = "TRKPAGTGF_TRKPERAGTGFSALIAS";

		// Token: 0x04001710 RID: 5904
		public const string ALIAS_TRK_AG_TG_DLL = "TRKPAGTGFLELL_TRKPERAGTGFSALIAS";

		// Token: 0x04001711 RID: 5905
		public const string ALIAS_TRK_SYS_SITE_DLL = "TRKSSITEA_TRKSYSSITEALSALIAS";

		// Token: 0x04001712 RID: 5906
		public const string ALIAS_TRK_SYS_MSG_DLL = "TRKSMA_TRKSYSMSGALSALIAS";

		// Token: 0x04001713 RID: 5907
		public const string ALIAS_TRK_SYS_STS_DLL = "TRKSSTSA_TRKSYSSTSALSALIAS";

		// Token: 0x04001714 RID: 5908
		public const string TRKSMALELL_MSGANUM = "TRKSMALELL_MSGANUM";

		// Token: 0x04001715 RID: 5909
		public const string TRKSSTSALELL_STSANUM = "TRKSSTSALELL_STSANUM";

		// Token: 0x04001716 RID: 5910
		public const string ATGLELH_SKMFPLITEM = "ATGLELH_SKMFPLITEM";

		// Token: 0x04001717 RID: 5911
		public const string CP_OTLITEM = "CP_OTLITEM";

		// Token: 0x04001718 RID: 5912
		public const string TRKS_OTLITEM = "TRKS_OTLITEM";

		// Token: 0x04001719 RID: 5913
		public const string RP_CSTMAUDINTMICNOIREDPROITEM = "RP_CSTMAUDINTMICNOIREDPROITEM";

		// Token: 0x0400171A RID: 5914
		public const string RP_CSTMAUDEXTMICNOIREDPROITEM = "RP_CSTMAUDEXTMICNOIREDPROITEM";

		// Token: 0x0400171B RID: 5915
		public const string SCANLSTELH_TRKSYSITEM = "SCANLSTELH_TRKSYSITEM";

		// Token: 0x0400171C RID: 5916
		public const string TXPLCELL_TXPWRLMT = "TXPLCELL_TXPWRLMT";

		// Token: 0x0400171D RID: 5917
		public const string SCANLSTELH_SLTY = "SCANLSTELH_SLTY";

		// Token: 0x0400171E RID: 5918
		public const string SP_SCLSTTYPE = "SP_SCLSTTYPE";

		// Token: 0x0400171F RID: 5919
		public const string CONVENTIONALSCAN = "CONVENTIONALSCAN";

		// Token: 0x04001720 RID: 5920
		public const string TALKGROUPSCAN = "TALKGROUPSCAN";

		// Token: 0x04001721 RID: 5921
		public const string PRIORITYSCAN = "PRIORITYSCAN";

		// Token: 0x04001722 RID: 5922
		public const string CONVSCAN = "CONVSCAN";

		// Token: 0x04001723 RID: 5923
		public const string CONVVOTESCAN = "CONVVOTESCAN";

		// Token: 0x04001724 RID: 5924
		public const string SC_FSTVTRSSITHD = "SC_FSTVTRSSITHD";

		// Token: 0x04001725 RID: 5925
		public const string SC_STVTRSSITHD = "SC_STVTRSSITHD";

		// Token: 0x04001726 RID: 5926
		public const string CP_ANSYSITEM = "CP_ANSYSITEM";

		// Token: 0x04001727 RID: 5927
		public const string CP_ANSYSITEMTYPE = "CP_ANSYSITEMTYPE";

		// Token: 0x04001728 RID: 5928
		public const string CP_ANSYSITEMID = "CP_ANSYSITEMID";

		// Token: 0x04001729 RID: 5929
		public const string CP_MDCSYSITEM = "CP_MDCSYSITEM";

		// Token: 0x0400172A RID: 5930
		public const string CP_MDCSYSITEMTYPE = "CP_MDCSYSITEMTYPE";

		// Token: 0x0400172B RID: 5931
		public const string CP_MDCSYSITEMID = "CP_MDCSYSITEMID";

		// Token: 0x0400172C RID: 5932
		public const string TRKS_PHONESYS = "TRKS_PHONESYS";

		// Token: 0x0400172D RID: 5933
		public const string TRKS_PHONESYSTYPE = "TRKS_PHONESYSTYPE";

		// Token: 0x0400172E RID: 5934
		public const string TRKS_PHONESYSID = "TRKS_PHONESYSID";

		// Token: 0x0400172F RID: 5935
		public const string CNV_SYS_CMP_TYPE = "CNV_SYS_CMP_TYPE";

		// Token: 0x04001730 RID: 5936
		public const string CNV_SYS_CMP_TYPE_GRP = "CNV_SYS_CMP_TYPE_GRP";

		// Token: 0x04001731 RID: 5937
		public const string ALIAS_PHONE_SYSTEM = "CS_CNVSYSALIAS";

		// Token: 0x04001732 RID: 5938
		public const string CS_CNVSYSALIAS = "CS_CNVSYSALIAS";

		// Token: 0x04001733 RID: 5939
		public const string CS_CONVEMERPROCITEM = "CS_CONVEMERPROCITEM";

		// Token: 0x04001734 RID: 5940
		public const string CS_DTPROCITEM = "CS_DTPROCITEM";

		// Token: 0x04001735 RID: 5941
		public const string CS_CONVSYSQCIITLSTITEM = "CS_CONVSYSQCIITLSTITEM";

		// Token: 0x04001736 RID: 5942
		public const string PHNUCLELL_CALLID = "PHNUCLELL_CALLID";

		// Token: 0x04001737 RID: 5943
		public const string DTMFCLELL_ACCCODE = "DTMFCLELL_ACCCODE";

		// Token: 0x04001738 RID: 5944
		public const string DTMFCLELL_DEACCCODE = "DTMFCLELL_DEACCCODE";

		// Token: 0x04001739 RID: 5945
		public const string MDC = "MDC";

		// Token: 0x0400173A RID: 5946
		public const string DTMF = "DTMF";

		// Token: 0x0400173B RID: 5947
		public const int ARCHIVE_LTD = 0;

		// Token: 0x0400173C RID: 5948
		public const int ARCHIVE_PHOENIX = 1;

		// Token: 0x0400173D RID: 5949
		public const int ARCHIVE_GEMSTONE = 2;

		// Token: 0x0400173E RID: 5950
		public const string STRMATRIXARCHIVEEXTENSION = ".ctb";

		// Token: 0x0400173F RID: 5951
		public const string STRPHOENIXARCHIVEEXTENSION = ".ptb";

		// Token: 0x04001740 RID: 5952
		public const string STRGEMSTONEARCHIVEEXTENSION = ".gtb";

		// Token: 0x04001741 RID: 5953
		public const int DB_TYPE_UNKNOWN = 0;

		// Token: 0x04001742 RID: 5954
		public const int DB_TYPE_MATRIX = 1;

		// Token: 0x04001743 RID: 5955
		public const int DB_TYPE_PHOENIX = 2;

		// Token: 0x04001744 RID: 5956
		public const int DB_TYPE_GEMSTONE = 3;

		// Token: 0x04001745 RID: 5957
		public const int DB_TYPE_MALTA = 4;

		// Token: 0x04001746 RID: 5958
		public const int DB_TYPE_PARADISELITE = 5;

		// Token: 0x04001747 RID: 5959
		public const int DB_TYPE_BAHAMA = 6;

		// Token: 0x04001748 RID: 5960
		public const byte PHOENIX_APP = 128;

		// Token: 0x04001749 RID: 5961
		public const byte PHOENIX_SEC = 129;

		// Token: 0x0400174A RID: 5962
		public const byte PHOENIX_UCL = 147;

		// Token: 0x0400174B RID: 5963
		public const string CLEAR = "clear";

		// Token: 0x0400174C RID: 5964
		public const string UCL_PARTITION = "UCL_PARTITION";

		// Token: 0x0400174D RID: 5965
		public const string SUB_TABLES = "SUB_TABLES";

		// Token: 0x0400174E RID: 5966
		public const string OVERWRITE_ATTR = "Overwrite";

		// Token: 0x0400174F RID: 5967
		public const string KEY = "HAVNCPSLTDTUNERAIRTRACER";

		// Token: 0x04001750 RID: 5968
		public const string IV = "VEDKDJSP";

		// Token: 0x04001751 RID: 5969
		public const string FREQTYPE = "FreqType";

		// Token: 0x04001752 RID: 5970
		public const string PRODUCT = "Product";

		// Token: 0x04001753 RID: 5971
		public const string S5AUTOACK_TELEGRAMITEM = "S5AUTOACK_TELEGRAMITEM";

		// Token: 0x04001754 RID: 5972
		public const string S5CLDLL_5TTELEGRAM = "S5CLDLL_5TTELEGRAM";

		// Token: 0x04001755 RID: 5973
		public const string CP_PTTKEYUPMODE = "CP_PTTKEYUPMODE";

		// Token: 0x04001756 RID: 5974
		public const string CP_AUTHORISATION = "CP_AUTHORISATION";

		// Token: 0x04001757 RID: 5975
		public const string CP_AUTORESETDEAUTHOR = "CP_AUTORESETDEAUTHOR";

		// Token: 0x04001758 RID: 5976
		public const string CP_CTOTRESETDURATION = "CP_CTOTRESETDURATION";

		// Token: 0x04001759 RID: 5977
		public const string CP_CTOTTYPE = "CP_CTOTTYPE";

		// Token: 0x0400175A RID: 5978
		public const string CP_ENCODEHOLDTIME = "CP_ENCODEHOLDTIME";

		// Token: 0x0400175B RID: 5979
		public const string CP_TXADMITCRIANOTAPPLYINAUTORESET = "CP_TXADMITCRIANOTAPPLYINAUTORESET";

		// Token: 0x0400175C RID: 5980
		public const string RC_SINGLESTATUSLIST = "RC_SINGLESTATUSLIST";

		// Token: 0x0400175D RID: 5981
		public const string SLT_5_ENCODER_STATUS_DLH_TYPE = "SLT_5_ENCODER_STATUS_DLH_TYPE";

		// Token: 0x0400175E RID: 5982
		public const string CP_RPTACID = "CP_RPTACID";

		// Token: 0x0400175F RID: 5983
		public const string MDCSYS_RACTYPE = "MDCSYS_RACTYPE";

		// Token: 0x04001760 RID: 5984
		public const string MDCSYS_REPACPRETM = "MDCSYS_REPACPRETM";

		// Token: 0x04001761 RID: 5985
		public const string AUTO = "AUTO";

		// Token: 0x04001762 RID: 5986
		public const string S5ENCSEQ_SSITEM = "S5ENCSEQ_SSITEM";

		// Token: 0x04001763 RID: 5987
		public const string S5DECODER_SIGNALSYSITEM = "S5DECODER_SIGNALSYSITEM";

		// Token: 0x04001764 RID: 5988
		public const string S5ENCTELEGRAM_ENCSEQ1ITEM = "S5ENCTELEGRAM_ENCSEQ1ITEM";

		// Token: 0x04001765 RID: 5989
		public const string S5ENCTELEGRAM_ENCSEQ2ITEM = "S5ENCTELEGRAM_ENCSEQ2ITEM";

		// Token: 0x04001766 RID: 5990
		public const string S5ENCTELEGRAM_ENCSEQ3ITEM = "S5ENCTELEGRAM_ENCSEQ3ITEM";

		// Token: 0x04001767 RID: 5991
		public const string S5ENCTELEGRAM_ENCSEQ1ITEMTYPE = "S5ENCTELEGRAM_ENCSEQ1ITEMTYPE";

		// Token: 0x04001768 RID: 5992
		public const string S5ENCTELEGRAM_ENCSEQ2ITEMTYPE = "S5ENCTELEGRAM_ENCSEQ2ITEMTYPE";

		// Token: 0x04001769 RID: 5993
		public const string S5ENCTELEGRAM_ENCSEQ3ITEMTYPE = "S5ENCTELEGRAM_ENCSEQ3ITEMTYPE";

		// Token: 0x0400176A RID: 5994
		public const string S5ENCTELEGRAM_ENCSEQ1ITEMID = "S5ENCTELEGRAM_ENCSEQ1ITEMID";

		// Token: 0x0400176B RID: 5995
		public const string S5ENCTELEGRAM_ENCSEQ2ITEMID = "S5ENCTELEGRAM_ENCSEQ2ITEMID";

		// Token: 0x0400176C RID: 5996
		public const string S5ENCTELEGRAM_ENCSEQ3ITEMID = "S5ENCTELEGRAM_ENCSEQ3ITEMID";

		// Token: 0x0400176D RID: 5997
		public const string CP_PTTKEYUPTELITEM = "CP_PTTKEYUPTELITEM";

		// Token: 0x0400176E RID: 5998
		public const string CP_PTTKEYUPTELITEMID = "CP_PTTKEYUPTELITEMID";

		// Token: 0x0400176F RID: 5999
		public const string CP_PTTKEYUPTELITEMTYPE = "CP_PTTKEYUPTELITEMTYPE";

		// Token: 0x04001770 RID: 6000
		public const string CP_RADIOIDTEL = "CP_RADIOIDTEL";

		// Token: 0x04001771 RID: 6001
		public const string CP_RADIOIDTELID = "CP_RADIOIDTELID";

		// Token: 0x04001772 RID: 6002
		public const string CP_RADIOIDTELTYPE = "CP_RADIOIDTELTYPE";

		// Token: 0x04001773 RID: 6003
		public const string CP_REPEATERACCESSANDRADIOIDTEL = "CP_REPEATERACCESSANDRADIOIDTEL";

		// Token: 0x04001774 RID: 6004
		public const string CP_REPEATERACCESSANDRADIOIDTELID = "CP_REPEATERACCESSANDRADIOIDTELID";

		// Token: 0x04001775 RID: 6005
		public const string CP_REPEATERACCESSANDRADIOIDTELTYPE = "CP_REPEATERACCESSANDRADIOIDTELTYPE";

		// Token: 0x04001776 RID: 6006
		public const string S5DECODER_AUTOACKITEM = "S5DECODER_AUTOACKITEM";

		// Token: 0x04001777 RID: 6007
		public const string S5DECODER_AUTOACKITEMTYPE = "S5DECODER_AUTOACKITEMTYPE";

		// Token: 0x04001778 RID: 6008
		public const string S5DECODER_AUTOACKITEMID = "S5DECODER_AUTOACKITEMID";

		// Token: 0x04001779 RID: 6009
		public const string S5DECODER_CALLFWACKITEM = "S5DECODER_CALLFWACKITEM";

		// Token: 0x0400177A RID: 6010
		public const string S5DECODER_MATCHENCTELETYPEITEM = "S5DECODER_MATCHENCTELETYPEITEM";

		// Token: 0x0400177B RID: 6011
		public const string CP_PTTDEKEYTEL = "CP_PTTDEKEYTEL";

		// Token: 0x0400177C RID: 6012
		public const string CP_DISCONTEL = "CP_DISCONTEL";

		// Token: 0x0400177D RID: 6013
		public const string CP_CALLBUTTON1KEYUPTEL = "CP_CALLBUTTON1KEYUPTEL";

		// Token: 0x0400177E RID: 6014
		public const string CP_CALLBUTTON2KEYUPTEL = "CP_CALLBUTTON2KEYUPTEL";

		// Token: 0x0400177F RID: 6015
		public const string CP_CALLBUTTON3KEYUPTEL = "CP_CALLBUTTON3KEYUPTEL";

		// Token: 0x04001780 RID: 6016
		public const string CP_CALLBUTTON4KEYUPTEL = "CP_CALLBUTTON4KEYUPTEL";

		// Token: 0x04001781 RID: 6017
		public const string CP_CALLBUTTON5KEYUPTEL = "CP_CALLBUTTON5KEYUPTEL";

		// Token: 0x04001782 RID: 6018
		public const string CP_CALLBUTTON6KEYUPTEL = "CP_CALLBUTTON6KEYUPTEL";

		// Token: 0x04001783 RID: 6019
		public const string S5AUTOACK_RVTCHNLITEM = "S5AUTOACK_RVTCHNLITEM";

		// Token: 0x04001784 RID: 6020
		public const string S5AUTOACK_RVTCHNLITEMID = "S5AUTOACK_RVTCHNLITEMID";

		// Token: 0x04001785 RID: 6021
		public const string S5AUTOACK_RVTCHNLITEMTYPE = "S5AUTOACK_RVTCHNLITEMTYPE";

		// Token: 0x04001786 RID: 6022
		public const string RC_EMERGENCYENCODETEL = "RC_EMERGENCYENCODETEL";

		// Token: 0x04001787 RID: 6023
		public const string RC_POWERUPAUTOTELGRAM = "RC_POWERUPAUTOTELGRAM";

		// Token: 0x04001788 RID: 6024
		public const string RC_POWERDOWNAUTOTELGRAM = "RC_POWERDOWNAUTOTELGRAM";

		// Token: 0x04001789 RID: 6025
		public const string RC_EMERGENCYREVERTCHAN = "RC_EMERGENCYREVERTCHAN";

		// Token: 0x0400178A RID: 6026
		public const string RC_EMERGENCYREVERTCHANID = "RC_EMERGENCYREVERTCHANID";

		// Token: 0x0400178B RID: 6027
		public const string RC_EMERGENCYREVERTCHANTYPE = "RC_EMERGENCYREVERTCHANTYPE";

		// Token: 0x0400178C RID: 6028
		public const string RC_POWERUPAUTOTELGRAMREVERTCHAN = "RC_POWERUPAUTOTELGRAMREVERTCHAN";

		// Token: 0x0400178D RID: 6029
		public const string RC_POWERUPAUTOTELGRAMREVERTCHANID = "RC_POWERUPAUTOTELGRAMREVERTCHANID";

		// Token: 0x0400178E RID: 6030
		public const string RC_POWERUPAUTOTELGRAMREVERTCHANTYPE = "RC_POWERUPAUTOTELGRAMREVERTCHANTYPE";

		// Token: 0x0400178F RID: 6031
		public const string RC_POWERDOWNAUTOTELGRAMREVERTCHAN = "RC_POWERDOWNAUTOTELGRAMREVERTCHAN";

		// Token: 0x04001790 RID: 6032
		public const string RC_POWERDOWNAUTOTELGRAMREVERTCHANID = "RC_POWERDOWNAUTOTELGRAMREVERTCHANID";

		// Token: 0x04001791 RID: 6033
		public const string RC_POWERDOWNAUTOTELGRAMREVERTCHANTYPE = "RC_POWERDOWNAUTOTELGRAMREVERTCHANTYPE";

		// Token: 0x04001792 RID: 6034
		public const string OTC_STSMSGIDX = "OTC_STSMSGIDX";

		// Token: 0x04001793 RID: 6035
		public const string MDCSTSLST_MDCSYSASITEM = "MDCSTSLST_MDCSYSASITEM";

		// Token: 0x04001794 RID: 6036
		public const string MDCMSGLST_MDCSYSASITEM = "MDCMSGLST_MDCSYSASITEM";

		// Token: 0x04001795 RID: 6037
		public const string MDCSTSLST_RVTPERITEM = "MDCSTSLST_RVTPERITEM";

		// Token: 0x04001796 RID: 6038
		public const string MDCSTSLST_RVTPERITEMID = "MDCSTSLST_RVTPERITEMID";

		// Token: 0x04001797 RID: 6039
		public const string MDCSTSLST_RVTPERITEMTYPE = "MDCSTSLST_RVTPERITEMTYPE";

		// Token: 0x04001798 RID: 6040
		public const string MDCMSGLST_RVTPERITEM = "MDCMSGLST_RVTPERITEM";

		// Token: 0x04001799 RID: 6041
		public const string MDCMSGLST_RVTPERITEMID = "MDCMSGLST_RVTPERITEMID";

		// Token: 0x0400179A RID: 6042
		public const string MDCMSGLST_RVTPERITEMTYPE = "MDCMSGLST_RVTPERITEMTYPE";

		// Token: 0x0400179B RID: 6043
		public const string RC_DSGPWRUPCHANITEM = "RC_DSGPWRUPCHANITEM";

		// Token: 0x0400179C RID: 6044
		public const string RC_DSGPWRUPCHANITEMTYPE = "RC_DSGPWRUPCHANITEMTYPE";

		// Token: 0x0400179D RID: 6045
		public const string RC_DSGPWRUPCHANITEMID = "RC_DSGPWRUPCHANITEMID";

		// Token: 0x0400179E RID: 6046
		public const string S5DECODER_S1GRPEN = "S5DECODER_S1GRPEN";

		// Token: 0x0400179F RID: 6047
		public const string S5DECODER_S2GRPEN = "S5DECODER_S2GRPEN";

		// Token: 0x040017A0 RID: 6048
		public const string S5DECODER_S3GRPEN = "S5DECODER_S3GRPEN";

		// Token: 0x040017A1 RID: 6049
		public const string RC_ADDRESSMANULAGENLOCKOUTDIGIT = "RC_ADDRESSMANULAGENLOCKOUTDIGIT";

		// Token: 0x040017A2 RID: 6050
		public const string RC_ADDRESSMANUALPOSLOCKOUTDIGIT = "RC_ADDRESSMANUALPOSLOCKOUTDIGIT";

		// Token: 0x040017A3 RID: 6051
		public const string RC_ADDRESSMANUALDIALPOSDIGITLOCKOUT = "RC_ADDRESSMANUALDIALPOSDIGITLOCKOUT";

		// Token: 0x040017A4 RID: 6052
		public const string RC_ADDRESSMANUALDIALPOSGROUPDIGITLOCKOUT = "RC_ADDRESSMANUALDIALPOSGROUPDIGITLOCKOUT";

		// Token: 0x040017A5 RID: 6053
		public const string RC_STATUSMANUNALGENERALLOCKOUTDIGIT = "RC_STATUSMANUNALGENERALLOCKOUTDIGIT";

		// Token: 0x040017A6 RID: 6054
		public const string RC_STATUSMANUNALPOSLOCKOUTDIGIT = "RC_STATUSMANUNALPOSLOCKOUTDIGIT";

		// Token: 0x040017A7 RID: 6055
		public const string RC_STATUSMANDIALPOSDIGITLOCKOUT = "RC_STATUSMANDIALPOSDIGITLOCKOUT";

		// Token: 0x040017A8 RID: 6056
		public const string RC_STATUSMANDIALPOSGROUPDIGITLOCKOUT = "RC_STATUSMANDIALPOSGROUPDIGITLOCKOUT";

		// Token: 0x040017A9 RID: 6057
		public const string GRPEN = "GRPEN";

		// Token: 0x040017AA RID: 6058
		public const string P = "P";

		// Token: 0x040017AB RID: 6059
		public const string CP_SELECT5CHAN = "CP_SELECT5CHAN";

		// Token: 0x040017AC RID: 6060
		public const string ADDRESSSEND = "ADDRESSSEND";

		// Token: 0x040017AD RID: 6061
		public const string CP_SEL5DECODEREN = "CP_SEL5DECODEREN";

		// Token: 0x040017AE RID: 6062
		public const string GENERAL_SET = "GENERAL_SET";

		// Token: 0x040017AF RID: 6063
		public const string SLT_5_USER_DEFINED_SIGNAL_STD_CMP_TYPE_GRP = "SLT_5_USER_DEFINED_SIGNAL_STD_CMP_TYPE_GRP";

		// Token: 0x040017B0 RID: 6064
		public const string SLT_5_USER_DEFINED_SIGNAL_STD_CMP_TYPE = "SLT_5_USER_DEFINED_SIGNAL_STD_CMP_TYPE";

		// Token: 0x040017B1 RID: 6065
		public const string SLT_5_SIGNAL_SYS_CMP_TYPE_GRP = "SLT_5_SIGNAL_SYS_CMP_TYPE_GRP";

		// Token: 0x040017B2 RID: 6066
		public const string SLT_5_SIGNAL_SYS_CMP_TYPE = "SLT_5_SIGNAL_SYS_CMP_TYPE";

		// Token: 0x040017B3 RID: 6067
		public const string S5SS_SYSALIAS = "S5SS_SYSALIAS";

		// Token: 0x040017B4 RID: 6068
		public const string SLT_5_ENCODER_STATUS_DLT_TYPE = "SLT_5_ENCODER_STATUS_DLT_TYPE";

		// Token: 0x040017B5 RID: 6069
		public const string SLT_5_ENCODER_STATUS_DLL_TYPE = "SLT_5_ENCODER_STATUS_DLL_TYPE";

		// Token: 0x040017B6 RID: 6070
		public const string S5ENCSTSLDLL_5TSTSA = "S5ENCSTSLDLL_5TSTSA";

		// Token: 0x040017B7 RID: 6071
		public const string SLT_5_ENCODER_SEQU_CMP_TYPE_GRP = "SLT_5_ENCODER_SEQU_CMP_TYPE_GRP";

		// Token: 0x040017B8 RID: 6072
		public const string SLT_5_ENCODER_SEQU_CMP_TYPE = "SLT_5_ENCODER_SEQU_CMP_TYPE";

		// Token: 0x040017B9 RID: 6073
		public const string S5ENCSEQ_SYSALIAS = "S5ENCSEQ_SYSALIAS";

		// Token: 0x040017BA RID: 6074
		public const string SLT_5_ENCODER_TELG_CMP_TYPE_GRP = "SLT_5_ENCODER_TELG_CMP_TYPE_GRP";

		// Token: 0x040017BB RID: 6075
		public const string SLT_5_ENCODER_TELG_CMP_TYPE = "SLT_5_ENCODER_TELG_CMP_TYPE";

		// Token: 0x040017BC RID: 6076
		public const string S5ENCTELEGRAM_SYSALIAS = "S5ENCTELEGRAM_SYSALIAS";

		// Token: 0x040017BD RID: 6077
		public const string SLT_5_DECODER_CMP_TYPE_GRP = "SLT_5_DECODER_CMP_TYPE_GRP";

		// Token: 0x040017BE RID: 6078
		public const string SLT_5_DECODER_CMP_TYPE = "SLT_5_DECODER_CMP_TYPE";

		// Token: 0x040017BF RID: 6079
		public const string S5DECODER_SYSALIAS = "S5DECODER_SYSALIAS";

		// Token: 0x040017C0 RID: 6080
		public const string SLT_5_AUTO_ACK_CMP_TYPE_GRP = "SLT_5_AUTO_ACK_CMP_TYPE_GRP";

		// Token: 0x040017C1 RID: 6081
		public const string SLT_5_AUTO_ACK_CMP_TYPE = "SLT_5_AUTO_ACK_CMP_TYPE";

		// Token: 0x040017C2 RID: 6082
		public const string S5AUTOACK_SYSALIAS = "S5AUTOACK_SYSALIAS";

		// Token: 0x040017C3 RID: 6083
		public const string SLT_5_DECODER_STATUS_DLT_TYPE = "SLT_5_DECODER_STATUS_DLT_TYPE";

		// Token: 0x040017C4 RID: 6084
		public const string SLT_5_DECODER_STATUS_DLL_TYPE = "SLT_5_DECODER_STATUS_DLL_TYPE";

		// Token: 0x040017C5 RID: 6085
		public const string S5DECSTSLDLL_5TSTSA = "S5DECSTSLDLL_5TSTSA";

		// Token: 0x040017C6 RID: 6086
		public const string SLT_5_CALL_DLH_TYPE_GRP = "SLT_5_CALL_DLH_TYPE_GRP";

		// Token: 0x040017C7 RID: 6087
		public const string SLT_5_CALL_DLT_TYPE = "SLT_5_CALL_DLT_TYPE";

		// Token: 0x040017C8 RID: 6088
		public const string SLT_5_CALL_DLH_TYPE = "SLT_5_CALL_DLH_TYPE";

		// Token: 0x040017C9 RID: 6089
		public const string SLT_5_CALL_DLL_TYPE = "SLT_5_CALL_DLL_TYPE";

		// Token: 0x040017CA RID: 6090
		public const string S5CLDLL_5TCALLA = "S5CLDLL_5TCALLA";

		// Token: 0x040017CB RID: 6091
		public const string MDC_MESSAGE_CMP_TYPE = "MDC_MESSAGE_CMP_TYPE";

		// Token: 0x040017CC RID: 6092
		public const string MDCMSGLST_MSGA = "MDCMSGLST_MSGA";

		// Token: 0x040017CD RID: 6093
		public const string MDC_STATUS_CMP_TYPE = "MDC_STATUS_CMP_TYPE";

		// Token: 0x040017CE RID: 6094
		public const string MDCSTSLST_STSA = "MDCSTSLST_STSA";

		// Token: 0x040017CF RID: 6095
		public const string RC_5TONEEMEERGENCYALARMTYPE = "RC_5TONEEMEERGENCYALARMTYPE";

		// Token: 0x040017D0 RID: 6096
		public const string RC_5TONEEMERGENCYALLOWONSWITCH = "RC_5TONEEMERGENCYALLOWONSWITCH";

		// Token: 0x040017D1 RID: 6097
		public const string RC_5TONEEMERGENCYTONEDURATIONTX = "RC_5TONEEMERGENCYTONEDURATIONTX";

		// Token: 0x040017D2 RID: 6098
		public const string RC_ADDRESSMANUALDIALRANGE1EN = "RC_ADDRESSMANUALDIALRANGE1EN";

		// Token: 0x040017D3 RID: 6099
		public const string RC_ADDRESSMANUALDIALRANGE1MAX = "RC_ADDRESSMANUALDIALRANGE1MAX";

		// Token: 0x040017D4 RID: 6100
		public const string RC_ADDRESSMANUALDIALRANGE1MIN = "RC_ADDRESSMANUALDIALRANGE1MIN";

		// Token: 0x040017D5 RID: 6101
		public const string RC_ADDRESSMANUALDIALRANGE2EN = "RC_ADDRESSMANUALDIALRANGE2EN";

		// Token: 0x040017D6 RID: 6102
		public const string RC_ADDRESSMANUALDIALRANGE2MAX = "RC_ADDRESSMANUALDIALRANGE2MAX";

		// Token: 0x040017D7 RID: 6103
		public const string RC_ADDRESSMANUALDIALRANGE2MIN = "RC_ADDRESSMANUALDIALRANGE2MIN";

		// Token: 0x040017D8 RID: 6104
		public const string RC_ADDRESSMANUALDIALRANGE3EN = "RC_ADDRESSMANUALDIALRANGE3EN";

		// Token: 0x040017D9 RID: 6105
		public const string RC_ADDRESSMANUALDIALRANGE3MAX = "RC_ADDRESSMANUALDIALRANGE3MAX";

		// Token: 0x040017DA RID: 6106
		public const string RC_ADDRESSMANUALDIALRANGE3MIN = "RC_ADDRESSMANUALDIALRANGE3MIN";

		// Token: 0x040017DB RID: 6107
		public const string RC_EMERGENCYCYCLECNT = "RC_EMERGENCYCYCLECNT";

		// Token: 0x040017DC RID: 6108
		public const string RC_EMERGENCYCYCLERXTIME = "RC_EMERGENCYCYCLERXTIME";

		// Token: 0x040017DD RID: 6109
		public const string RC_EMERGENCYCYCLETXTIME = "RC_EMERGENCYCYCLETXTIME";

		// Token: 0x040017DE RID: 6110
		public const string RC_STATUSMANDIALRANGE1EN = "RC_STATUSMANDIALRANGE1EN";

		// Token: 0x040017DF RID: 6111
		public const string RC_STATUSMANUALDIALRANGE1MAX = "RC_STATUSMANUALDIALRANGE1MAX";

		// Token: 0x040017E0 RID: 6112
		public const string RC_STATUSMANUALDIALRANGE1MIN = "RC_STATUSMANUALDIALRANGE1MIN";

		// Token: 0x040017E1 RID: 6113
		public const string RC_STATUSMANDIALRANGE2EN = "RC_STATUSMANDIALRANGE2EN";

		// Token: 0x040017E2 RID: 6114
		public const string RC_STATUSMANUALDIALRANGE2MAX = "RC_STATUSMANUALDIALRANGE2MAX";

		// Token: 0x040017E3 RID: 6115
		public const string RC_STATUSMANUALDIALRANGE2MIN = "RC_STATUSMANUALDIALRANGE2MIN";

		// Token: 0x040017E4 RID: 6116
		public const string RC_STATUSMANDIALRANGE3EN = "RC_STATUSMANDIALRANGE3EN";

		// Token: 0x040017E5 RID: 6117
		public const string RC_STATUSMANUALDIALRANGE3MAX = "RC_STATUSMANUALDIALRANGE3MAX";

		// Token: 0x040017E6 RID: 6118
		public const string RC_STATUSMANUALDIALRANGE3MIN = "RC_STATUSMANUALDIALRANGE3MIN";

		// Token: 0x040017E7 RID: 6119
		public const string S5SS_ENCSGLTONE1FREQ = "S5SS_ENCSGLTONE1FREQ";

		// Token: 0x040017E8 RID: 6120
		public const string S5SS_ENCSGLTONE1DUR = "S5SS_ENCSGLTONE1DUR";

		// Token: 0x040017E9 RID: 6121
		public const string S5SS_ENCSGLTONE2FREQ = "S5SS_ENCSGLTONE2FREQ";

		// Token: 0x040017EA RID: 6122
		public const string S5SS_ENCSGLTONE2DUR = "S5SS_ENCSGLTONE2DUR";

		// Token: 0x040017EB RID: 6123
		public const string S5SS_DECSGLTONE1EN = "S5SS_DECSGLTONE1EN";

		// Token: 0x040017EC RID: 6124
		public const string S5SS_DECSGLTONE1FREQ = "S5SS_DECSGLTONE1FREQ";

		// Token: 0x040017ED RID: 6125
		public const string S5SS_DECSGLTONE1MAXDUR = "S5SS_DECSGLTONE1MAXDUR";

		// Token: 0x040017EE RID: 6126
		public const string S5SS_DECSGLTONE1MINDUR = "S5SS_DECSGLTONE1MINDUR";

		// Token: 0x040017EF RID: 6127
		public const string S5SS_DECSGLTONE2EN = "S5SS_DECSGLTONE2EN";

		// Token: 0x040017F0 RID: 6128
		public const string S5SS_DECSGLTONE2FREQ = "S5SS_DECSGLTONE2FREQ";

		// Token: 0x040017F1 RID: 6129
		public const string S5SS_DECSGLTONE2MAXDUR = "S5SS_DECSGLTONE2MAXDUR";

		// Token: 0x040017F2 RID: 6130
		public const string S5SS_DECSGLTONE2MINDUR = "S5SS_DECSGLTONE2MINDUR";

		// Token: 0x040017F3 RID: 6131
		public const string S5SS_GRPTONE = "S5SS_GRPTONE";

		// Token: 0x040017F4 RID: 6132
		public const string S5SS_RPTTONE = "S5SS_RPTTONE";

		// Token: 0x040017F5 RID: 6133
		public const string S5USRDEFSIGSTD_DECMAXDUR = "S5USRDEFSIGSTD_DECMAXDUR";

		// Token: 0x040017F6 RID: 6134
		public const string S5USRDEFSIGSTD_DECMINDUR = "S5USRDEFSIGSTD_DECMINDUR";

		// Token: 0x040017F7 RID: 6135
		public const string S5ENCSEQ_PRETIME = "S5ENCSEQ_PRETIME";

		// Token: 0x040017F8 RID: 6136
		public const string S5ENCSEQ_EXTFSTTDUR = "S5ENCSEQ_EXTFSTTDUR";

		// Token: 0x040017F9 RID: 6137
		public const string S5DECODER_DECTYPE = "S5DECODER_DECTYPE";

		// Token: 0x040017FA RID: 6138
		public const string S5DECODER_AUTORSTSTART = "S5DECODER_AUTORSTSTART";

		// Token: 0x040017FB RID: 6139
		public const string S5DECODER_CALLBK = "S5DECODER_CALLBK";

		// Token: 0x040017FC RID: 6140
		public const string S5DECODER_CALLANSST = "S5DECODER_CALLANSST";

		// Token: 0x040017FD RID: 6141
		public const string S5DECODER_EXTALM = "S5DECODER_EXTALM";

		// Token: 0x040017FE RID: 6142
		public const string S5ENCSTSLDLL_5TSTSNUM = "S5ENCSTSLDLL_5TSTSNUM";

		// Token: 0x040017FF RID: 6143
		public const string S5DECSTSLDLL_5TSTSNUM = "S5DECSTSLDLL_5TSTSNUM";

		// Token: 0x04001800 RID: 6144
		public const string S5CLDLL_5TCALLADD = "S5CLDLL_5TCALLADD";

		// Token: 0x04001801 RID: 6145
		public const string S5ENCSEQ_SEQ = "S5ENCSEQ_SEQ";

		// Token: 0x04001802 RID: 6146
		public const string S5DECODER_DECSEQ = "S5DECODER_DECSEQ";

		// Token: 0x04001803 RID: 6147
		public const string S5DECODER_DECSEQ1 = "S5DECODER_DECSEQ1";

		// Token: 0x04001804 RID: 6148
		public const string S5DECODER_DECSEQ2 = "S5DECODER_DECSEQ2";

		// Token: 0x04001805 RID: 6149
		public const string S5DECODER_DECSEQ3 = "S5DECODER_DECSEQ3";

		// Token: 0x04001806 RID: 6150
		public const string RC_SEL5RADIOID = "RC_SEL5RADIOID";

		// Token: 0x04001807 RID: 6151
		public const string RC_SEL5RADIOID0 = "RC_SEL5RADIOID0";

		// Token: 0x04001808 RID: 6152
		public const string RC_SEL5RADIOID1 = "RC_SEL5RADIOID1";

		// Token: 0x04001809 RID: 6153
		public const string RC_SEL5RADIOID2 = "RC_SEL5RADIOID2";

		// Token: 0x0400180A RID: 6154
		public const string RC_SEL5RADIOID3 = "RC_SEL5RADIOID3";

		// Token: 0x0400180B RID: 6155
		public const string RC_SEL5RADIOID4 = "RC_SEL5RADIOID4";

		// Token: 0x0400180C RID: 6156
		public const string RC_SEL5RADIOID5 = "RC_SEL5RADIOID5";

		// Token: 0x0400180D RID: 6157
		public const string RC_SEL5RADIOID6 = "RC_SEL5RADIOID6";

		// Token: 0x0400180E RID: 6158
		public const string RC_SEL5RADIOID7 = "RC_SEL5RADIOID7";

		// Token: 0x0400180F RID: 6159
		public const string RC_PWRUPBPFLNM = "RC_PWRUPBPFLNM";

		// Token: 0x04001810 RID: 6160
		public const string FILE_DATA_BLOCK = "FILE_DATA";

		// Token: 0x04001811 RID: 6161
		public const string FILE_DATA = "data";

		// Token: 0x04001812 RID: 6162
		public const string FILE_NAME = "Name";

		// Token: 0x04001813 RID: 6163
		public const string FILE_TYPE = "Type";

		// Token: 0x04001814 RID: 6164
		public const string PIXELFORMAT = "PixelFormat";

		// Token: 0x04001815 RID: 6165
		public const string FORMAT1BPPINDEXED = "Format1bppIndexed";

		// Token: 0x04001816 RID: 6166
		public const string FORMAT8BPPINDEXED = "Format8bppIndexed";

		// Token: 0x04001817 RID: 6167
		public const string FORMAT16BPPRGB565 = "Format16bppRgb565";

		// Token: 0x04001818 RID: 6168
		public const string WELCOMBMPPATH = "/opt/pcr/rel/data/mmi/";

		// Token: 0x04001819 RID: 6169
		public const string WELCOMBMPNAME = "welcome_bitmap";

		// Token: 0x0400181A RID: 6170
		public const string MDCMODE = "MDCMODE";

		// Token: 0x0400181B RID: 6171
		public const string VA_MVA_DEFAULT_EXT = ".mva";

		// Token: 0x0400181C RID: 6172
		public const string WAV_DEFAULT_EXT = ".wav";

		// Token: 0x0400181D RID: 6173
		public const int VA_NO_FILE_CONFIG = 65535;

		// Token: 0x0400181E RID: 6174
		public const string VAC_VAVFP = "VAC_VAVFP";

		// Token: 0x0400181F RID: 6175
		public const string VAC_SGVFMAXALEN = "VAC_SGVFMAXALEN";

		// Token: 0x04001820 RID: 6176
		public const string VAC_ALLVFMAXALEN = "VAC_ALLVFMAXALEN";

		// Token: 0x04001821 RID: 6177
		public const string CP_CVFNLITEM = "CP_CVFNLITEM";

		// Token: 0x04001822 RID: 6178
		public const string ZP_ZVFNLITEM = "ZP_ZVFNLITEM";

		// Token: 0x04001823 RID: 6179
		public const string VA_FILENAME_LIST_DLH_TYPE = "VA_FILENAME_LIST_DLH_TYPE";

		// Token: 0x04001824 RID: 6180
		public const string VA_FILENAME_LIST_DLT_TYPE = "VA_FILENAME_LIST_DLT_TYPE";

		// Token: 0x04001825 RID: 6181
		public const string VA_FILENAME_LIST_DLL_TYPE = "VA_FILENAME_LIST_DLL_TYPE";

		// Token: 0x04001826 RID: 6182
		public const string VAVFNLDLL_VAFLKCNT = "VAVFNLDLL_VAFLKCNT";

		// Token: 0x04001827 RID: 6183
		public const string VAVFNLDLL_VAVFN = "VAVFNLDLL_VAVFN";

		// Token: 0x04001828 RID: 6184
		public const string BTN_VASELECTALL = "BTN_VASELECTALL";

		// Token: 0x04001829 RID: 6185
		public const string BTN_VASELECTNONE = "BTN_VASELECTNONE";

		// Token: 0x0400182A RID: 6186
		public const string VOICE_ANNOUNCEMENT_CMP_TYPE = "VOICE_ANNOUNCEMENT_CMP_TYPE";

		// Token: 0x0400182B RID: 6187
		public const string VA_INTELLIGENTAUDIOON = "VA_INTELLIGENTAUDIOON";

		// Token: 0x0400182C RID: 6188
		public const string VA_INTELLIGENTAUDIOOFF = "VA_INTELLIGENTAUDIOOFF";

		// Token: 0x0400182D RID: 6189
		public const string VA_ALLALERTTONESON = "VA_ALLALERTTONESON";

		// Token: 0x0400182E RID: 6190
		public const string VA_ALLALERTTONESOFF = "VA_ALLALERTTONESOFF";

		// Token: 0x0400182F RID: 6191
		public const string VA_BACKLIGHTAUTOON = "VA_BACKLIGHTAUTOON";

		// Token: 0x04001830 RID: 6192
		public const string VA_BACKLIGHTAUTOOFF = "VA_BACKLIGHTAUTOOFF";

		// Token: 0x04001831 RID: 6193
		public const string VA_BATTERYINDICATORLOW = "VA_BATTERYINDICATORLOW";

		// Token: 0x04001832 RID: 6194
		public const string VA_BATTERYINDICATORMEDIUM = "VA_BATTERYINDICATORMEDIUM";

		// Token: 0x04001833 RID: 6195
		public const string VA_BATTERYINDICATORHIGH = "VA_BATTERYINDICATORHIGH";

		// Token: 0x04001834 RID: 6196
		public const string VA_BRIGHTNESS = "VA_BRIGHTNESS";

		// Token: 0x04001835 RID: 6197
		public const string VA_BRIGHTNESSLEVEL1 = "VA_BRIGHTNESSLEVEL1";

		// Token: 0x04001836 RID: 6198
		public const string VA_BRIGHTNESSLEVEL2 = "VA_BRIGHTNESSLEVEL2";

		// Token: 0x04001837 RID: 6199
		public const string VA_BRIGHTNESSLEVEL3 = "VA_BRIGHTNESSLEVEL3";

		// Token: 0x04001838 RID: 6200
		public const string VA_BRIGHTNESSLEVEL4 = "VA_BRIGHTNESSLEVEL4";

		// Token: 0x04001839 RID: 6201
		public const string VA_BLUETOOTHCONNECT = "VA_BLUETOOTHCONNECT";

		// Token: 0x0400183A RID: 6202
		public const string VA_BLUETOOTHCONNECTTYPE = "VA_BLUETOOTHCONNECTTYPE";

		// Token: 0x0400183B RID: 6203
		public const string VA_BLUETOOTHCONNECTID = "VA_BLUETOOTHCONNECTID";

		// Token: 0x0400183C RID: 6204
		public const string VA_BLUETOOTHDISCONNECT = "VA_BLUETOOTHDISCONNECT";

		// Token: 0x0400183D RID: 6205
		public const string VA_BLUETOOTHDISCONNECTTYPE = "VA_BLUETOOTHDISCONNECTTYPE";

		// Token: 0x0400183E RID: 6206
		public const string VA_BLUETOOTHDISCONNECTID = "VA_BLUETOOTHDISCONNECTID";

		// Token: 0x0400183F RID: 6207
		public const string VA_ROUTEAUDIOTOBLUETOOTH = "VA_ROUTEAUDIOTOBLUETOOTH";

		// Token: 0x04001840 RID: 6208
		public const string VA_ROUTEAUDIOTOBLUETOOTHTYPE = "VA_ROUTEAUDIOTOBLUETOOTHTYPE";

		// Token: 0x04001841 RID: 6209
		public const string VA_ROUTEAUDIOTOBLUETOOTHID = "VA_ROUTEAUDIOTOBLUETOOTHID";

		// Token: 0x04001842 RID: 6210
		public const string VA_ROUTEAUDIOTOSPEAKER = "VA_ROUTEAUDIOTOSPEAKER";

		// Token: 0x04001843 RID: 6211
		public const string VA_ROUTEAUDIOTOSPEAKERTYPE = "VA_ROUTEAUDIOTOSPEAKERTYPE";

		// Token: 0x04001844 RID: 6212
		public const string VA_ROUTEAUDIOTOSPEAKERID = "VA_ROUTEAUDIOTOSPEAKERID";

		// Token: 0x04001845 RID: 6213
		public const string VA_CALLFORWARDINGSET = "VA_CALLFORWARDINGSET";

		// Token: 0x04001846 RID: 6214
		public const string VA_CALLFORWARDINGCLEAR = "VA_CALLFORWARDINGCLEAR";

		// Token: 0x04001847 RID: 6215
		public const string VA_CALLALERT = "VA_CALLALERT";

		// Token: 0x04001848 RID: 6216
		public const string VA_CALLLOG = "VA_CALLLOG";

		// Token: 0x04001849 RID: 6217
		public const string VA_CONTACTS = "VA_CONTACTS";

		// Token: 0x0400184A RID: 6218
		public const string VA_DAYMODE = "VA_DAYMODE";

		// Token: 0x0400184B RID: 6219
		public const string VA_NIGHTMODE = "VA_NIGHTMODE";

		// Token: 0x0400184C RID: 6220
		public const string VA_EMERGENCYOFF = "VA_EMERGENCYOFF";

		// Token: 0x0400184D RID: 6221
		public const string VA_EMERGENCYON = "VA_EMERGENCYON";

		// Token: 0x0400184E RID: 6222
		public const string VA_EXTERNALPUBLICADDRESSON = "VA_EXTERNALPUBLICADDRESSON";

		// Token: 0x0400184F RID: 6223
		public const string VA_EXTERNALPUBLICADDRESSOFF = "VA_EXTERNALPUBLICADDRESSOFF";

		// Token: 0x04001850 RID: 6224
		public const string VA_HIGHPOWER = "VA_HIGHPOWER";

		// Token: 0x04001851 RID: 6225
		public const string VA_LOWPOWER = "VA_LOWPOWER";

		// Token: 0x04001852 RID: 6226
		public const string VA_HORNLIGHTSON = "VA_HORNLIGHTSON";

		// Token: 0x04001853 RID: 6227
		public const string VA_HORNLIGHTSOFF = "VA_HORNLIGHTSOFF";

		// Token: 0x04001854 RID: 6228
		public const string VA_INTERNALPUBLICADDRESSON = "VA_INTERNALPUBLICADDRESSON";

		// Token: 0x04001855 RID: 6229
		public const string VA_INTERNALPUBLICADDRESSOFF = "VA_INTERNALPUBLICADDRESSOFF";

		// Token: 0x04001856 RID: 6230
		public const string VA_KEYPADLOCKON = "VA_KEYPADLOCKON";

		// Token: 0x04001857 RID: 6231
		public const string VA_KEYPADLOCKOFF = "VA_KEYPADLOCKOFF";

		// Token: 0x04001858 RID: 6232
		public const string VA_MANUALDIALFORPRIVATECALL = "VA_MANUALDIALFORPRIVATECALL";

		// Token: 0x04001859 RID: 6233
		public const string VA_MANUALSITEROAM = "VA_MANUALSITEROAM";

		// Token: 0x0400185A RID: 6234
		public const string VA_MANUALSITEROAMID = "VA_MANUALSITEROAMID";

		// Token: 0x0400185B RID: 6235
		public const string VA_MANUALSITEROAMTYPE = "VA_MANUALSITEROAMTYPE";

		// Token: 0x0400185C RID: 6236
		public const string VA_MICROPHONEAGCON = "VA_MICROPHONEAGCON";

		// Token: 0x0400185D RID: 6237
		public const string VA_MICROPHONEAGCOFF = "VA_MICROPHONEAGCOFF";

		// Token: 0x0400185E RID: 6238
		public const string VA_MONITOR = "VA_MONITOR";

		// Token: 0x0400185F RID: 6239
		public const string VA_NUISANCEDELETE = "VA_NUISANCEDELETE";

		// Token: 0x04001860 RID: 6240
		public const string VA_PERMANENTMONITORON = "VA_PERMANENTMONITORON";

		// Token: 0x04001861 RID: 6241
		public const string VA_PERMANENTMONITOROFF = "VA_PERMANENTMONITOROFF";

		// Token: 0x04001862 RID: 6242
		public const string VA_PRIVACYON = "VA_PRIVACYON";

		// Token: 0x04001863 RID: 6243
		public const string VA_PRIVACYONTYPE = "VA_PRIVACYONTYPE";

		// Token: 0x04001864 RID: 6244
		public const string VA_PRIVACYONID = "VA_PRIVACYONID";

		// Token: 0x04001865 RID: 6245
		public const string VA_PRIVACYOFF = "VA_PRIVACYOFF";

		// Token: 0x04001866 RID: 6246
		public const string VA_PRIVACYOFFTYPE = "VA_PRIVACYOFFTYPE";

		// Token: 0x04001867 RID: 6247
		public const string VA_PRIVACYOFFID = "VA_PRIVACYOFFID";

		// Token: 0x04001868 RID: 6248
		public const string VA_RADIOCHECK = "VA_RADIOCHECK";

		// Token: 0x04001869 RID: 6249
		public const string VA_RADIODISABLE = "VA_RADIODISABLE";

		// Token: 0x0400186A RID: 6250
		public const string VA_RADIOENABLE = "VA_RADIOENABLE";

		// Token: 0x0400186B RID: 6251
		public const string VA_REMOTEMONITOR = "VA_REMOTEMONITOR";

		// Token: 0x0400186C RID: 6252
		public const string VA_REPEATERMODE = "VA_REPEATERMODE";

		// Token: 0x0400186D RID: 6253
		public const string VA_TALKAROUNDMODE = "VA_TALKAROUNDMODE";

		// Token: 0x0400186E RID: 6254
		public const string VA_SCANON = "VA_SCANON";

		// Token: 0x0400186F RID: 6255
		public const string VA_SCANOFF = "VA_SCANOFF";

		// Token: 0x04001870 RID: 6256
		public const string VA_SITELOCKON = "VA_SITELOCKON";

		// Token: 0x04001871 RID: 6257
		public const string VA_SITELOCKONID = "VA_SITELOCKONID";

		// Token: 0x04001872 RID: 6258
		public const string VA_SITELOCKONTYPE = "VA_SITELOCKONTYPE";

		// Token: 0x04001873 RID: 6259
		public const string VA_SITELOCKOFF = "VA_SITELOCKOFF";

		// Token: 0x04001874 RID: 6260
		public const string VA_SITELOCKOFFID = "VA_SITELOCKOFFID";

		// Token: 0x04001875 RID: 6261
		public const string VA_SITELOCKOFFTYPE = "VA_SITELOCKOFFTYPE";

		// Token: 0x04001876 RID: 6262
		public const string VA_TEXTMESSAGE = "VA_TEXTMESSAGE";

		// Token: 0x04001877 RID: 6263
		public const string VA_TIGHTSQUELCH = "VA_TIGHTSQUELCH";

		// Token: 0x04001878 RID: 6264
		public const string VA_NORMALSQUELCH = "VA_NORMALSQUELCH";

		// Token: 0x04001879 RID: 6265
		public const string VA_STATUSLIST = "VA_STATUSLIST";

		// Token: 0x0400187A RID: 6266
		public const string VA_TXINTERRUPTREMOTEDEKEY = "VA_TXINTERRUPTREMOTEDEKEY";

		// Token: 0x0400187B RID: 6267
		public const string VA_VOXON = "VA_VOXON";

		// Token: 0x0400187C RID: 6268
		public const string VA_VOXOFF = "VA_VOXOFF";

		// Token: 0x0400187D RID: 6269
		public const string VA_VOICEANNOUNCEMENTON = "VA_VOICEANNOUNCEMENTON";

		// Token: 0x0400187E RID: 6270
		public const string VA_VOICEANNOUNCEMENTOFF = "VA_VOICEANNOUNCEMENTOFF";

		// Token: 0x0400187F RID: 6271
		public const string VA_ONETOUCHHOMEREVERT = "VA_ONETOUCHHOMEREVERT";

		// Token: 0x04001880 RID: 6272
		public const string VA_ONETOUCHPRIVATECALL = "VA_ONETOUCHPRIVATECALL";

		// Token: 0x04001881 RID: 6273
		public const string VA_ONETOUCHGROUPCALL = "VA_ONETOUCHGROUPCALL";

		// Token: 0x04001882 RID: 6274
		public const string VA_ONETOUCHCALLALERTSENDING = "VA_ONETOUCHCALLALERTSENDING";

		// Token: 0x04001883 RID: 6275
		public const string VA_ONETOUCHTEXTMESSAGESENDING = "VA_ONETOUCHTEXTMESSAGESENDING";

		// Token: 0x04001884 RID: 6276
		public const string VA_ONETOUCHTEXTMESSAGESENDINGTYPE = "VA_ONETOUCHTEXTMESSAGESENDINGTYPE";

		// Token: 0x04001885 RID: 6277
		public const string VA_ONETOUCHTEXTMESSAGESENDINGID = "VA_ONETOUCHTEXTMESSAGESENDINGID";

		// Token: 0x04001886 RID: 6278
		public const string VA_ONETOUCHSTATUSSENDING = "VA_ONETOUCHSTATUSSENDING";

		// Token: 0x04001887 RID: 6279
		public const string VA_ONETOUCHMESSAGESENDING = "VA_ONETOUCHMESSAGESENDING";

		// Token: 0x04001888 RID: 6280
		public const string VA_ONETOUCHTELEGRAMSENDING = "VA_ONETOUCHTELEGRAMSENDING";

		// Token: 0x04001889 RID: 6281
		public const string VA_TELEMETRYBUTTON1 = "VA_TELEMETRYBUTTON1";

		// Token: 0x0400188A RID: 6282
		public const string VA_TELEMETRYBUTTON2 = "VA_TELEMETRYBUTTON2";

		// Token: 0x0400188B RID: 6283
		public const string VA_TELEMETRYBUTTON3 = "VA_TELEMETRYBUTTON3";

		// Token: 0x0400188C RID: 6284
		public const string VA_OPTIONBOARDFEATURE1 = "VA_OPTIONBOARDFEATURE1";

		// Token: 0x0400188D RID: 6285
		public const string VA_OPTIONBOARDFEATURE1TYPE = "VA_OPTIONBOARDFEATURE1TYPE";

		// Token: 0x0400188E RID: 6286
		public const string VA_OPTIONBOARDFEATURE1ID = "VA_OPTIONBOARDFEATURE1ID";

		// Token: 0x0400188F RID: 6287
		public const string VA_OPTIONBOARDFEATURE2 = "VA_OPTIONBOARDFEATURE2";

		// Token: 0x04001890 RID: 6288
		public const string VA_OPTIONBOARDFEATURE2TYPE = "VA_OPTIONBOARDFEATURE2TYPE";

		// Token: 0x04001891 RID: 6289
		public const string VA_OPTIONBOARDFEATURE2ID = "VA_OPTIONBOARDFEATURE2ID";

		// Token: 0x04001892 RID: 6290
		public const string VA_OPTIONBOARDFEATURE3 = "VA_OPTIONBOARDFEATURE3";

		// Token: 0x04001893 RID: 6291
		public const string VA_OPTIONBOARDFEATURE3TYPE = "VA_OPTIONBOARDFEATURE3TYPE";

		// Token: 0x04001894 RID: 6292
		public const string VA_OPTIONBOARDFEATURE3ID = "VA_OPTIONBOARDFEATURE3ID";

		// Token: 0x04001895 RID: 6293
		public const string VA_OPTIONBOARDFEATURE4 = "VA_OPTIONBOARDFEATURE4";

		// Token: 0x04001896 RID: 6294
		public const string VA_OPTIONBOARDFEATURE4TYPE = "VA_OPTIONBOARDFEATURE4TYPE";

		// Token: 0x04001897 RID: 6295
		public const string VA_OPTIONBOARDFEATURE4ID = "VA_OPTIONBOARDFEATURE4ID";

		// Token: 0x04001898 RID: 6296
		public const string VA_OPTIONBOARDFEATURE5 = "VA_OPTIONBOARDFEATURE5";

		// Token: 0x04001899 RID: 6297
		public const string VA_OPTIONBOARDFEATURE5TYPE = "VA_OPTIONBOARDFEATURE5TYPE";

		// Token: 0x0400189A RID: 6298
		public const string VA_OPTIONBOARDFEATURE5ID = "VA_OPTIONBOARDFEATURE5ID";

		// Token: 0x0400189B RID: 6299
		public const string VA_OPTIONBOARDFEATURE6 = "VA_OPTIONBOARDFEATURE6";

		// Token: 0x0400189C RID: 6300
		public const string VA_OPTIONBOARDFEATURE6TYPE = "VA_OPTIONBOARDFEATURE6TYPE";

		// Token: 0x0400189D RID: 6301
		public const string VA_OPTIONBOARDFEATURE6ID = "VA_OPTIONBOARDFEATURE6ID";

		// Token: 0x0400189E RID: 6302
		public const string VA_OPTIONBOARDFEATURE7 = "VA_OPTIONBOARDFEATURE7";

		// Token: 0x0400189F RID: 6303
		public const string VA_OPTIONBOARDFEATURE7TYPE = "VA_OPTIONBOARDFEATURE7TYPE";

		// Token: 0x040018A0 RID: 6304
		public const string VA_OPTIONBOARDFEATURE7ID = "VA_OPTIONBOARDFEATURE7ID";

		// Token: 0x040018A1 RID: 6305
		public const string VA_OPTIONBOARDFEATURE8 = "VA_OPTIONBOARDFEATURE8";

		// Token: 0x040018A2 RID: 6306
		public const string VA_OPTIONBOARDFEATURE8TYPE = "VA_OPTIONBOARDFEATURE8TYPE";

		// Token: 0x040018A3 RID: 6307
		public const string VA_OPTIONBOARDFEATURE8ID = "VA_OPTIONBOARDFEATURE8ID";

		// Token: 0x040018A4 RID: 6308
		public const string VA_OPTIONBOARDFEATURE9 = "VA_OPTIONBOARDFEATURE9";

		// Token: 0x040018A5 RID: 6309
		public const string VA_OPTIONBOARDFEATURE9TYPE = "VA_OPTIONBOARDFEATURE9TYPE";

		// Token: 0x040018A6 RID: 6310
		public const string VA_OPTIONBOARDFEATURE9ID = "VA_OPTIONBOARDFEATURE9ID";

		// Token: 0x040018A7 RID: 6311
		public const string VA_OPTIONBOARDFEATURE10 = "VA_OPTIONBOARDFEATURE10";

		// Token: 0x040018A8 RID: 6312
		public const string VA_OPTIONBOARDFEATURE10TYPE = "VA_OPTIONBOARDFEATURE10TYPE";

		// Token: 0x040018A9 RID: 6313
		public const string VA_OPTIONBOARDFEATURE10ID = "VA_OPTIONBOARDFEATURE10ID";

		// Token: 0x040018AA RID: 6314
		public const string VA_OPTIONBOARDFEATURE11 = "VA_OPTIONBOARDFEATURE11";

		// Token: 0x040018AB RID: 6315
		public const string VA_OPTIONBOARDFEATURE11TYPE = "VA_OPTIONBOARDFEATURE11TYPE";

		// Token: 0x040018AC RID: 6316
		public const string VA_OPTIONBOARDFEATURE11ID = "VA_OPTIONBOARDFEATURE11ID";

		// Token: 0x040018AD RID: 6317
		public const string VA_OPTIONBOARDFEATURE12 = "VA_OPTIONBOARDFEATURE12";

		// Token: 0x040018AE RID: 6318
		public const string VA_OPTIONBOARDFEATURE12TYPE = "VA_OPTIONBOARDFEATURE12TYPE";

		// Token: 0x040018AF RID: 6319
		public const string VA_OPTIONBOARDFEATURE12ID = "VA_OPTIONBOARDFEATURE12ID";

		// Token: 0x040018B0 RID: 6320
		public const string VA_OPTIONBOARDFEATURE13 = "VA_OPTIONBOARDFEATURE13";

		// Token: 0x040018B1 RID: 6321
		public const string VA_OPTIONBOARDFEATURE13TYPE = "VA_OPTIONBOARDFEATURE13TYPE";

		// Token: 0x040018B2 RID: 6322
		public const string VA_OPTIONBOARDFEATURE13ID = "VA_OPTIONBOARDFEATURE13ID";

		// Token: 0x040018B3 RID: 6323
		public const string VA_OPTIONBOARDFEATURE14 = "VA_OPTIONBOARDFEATURE14";

		// Token: 0x040018B4 RID: 6324
		public const string VA_OPTIONBOARDFEATURE14TYPE = "VA_OPTIONBOARDFEATURE14TYPE";

		// Token: 0x040018B5 RID: 6325
		public const string VA_OPTIONBOARDFEATURE14ID = "VA_OPTIONBOARDFEATURE14ID";

		// Token: 0x040018B6 RID: 6326
		public const string VA_OPTIONBOARDFEATURE15 = "VA_OPTIONBOARDFEATURE15";

		// Token: 0x040018B7 RID: 6327
		public const string VA_OPTIONBOARDFEATURE15TYPE = "VA_OPTIONBOARDFEATURE15TYPE";

		// Token: 0x040018B8 RID: 6328
		public const string VA_OPTIONBOARDFEATURE15ID = "VA_OPTIONBOARDFEATURE15ID";

		// Token: 0x040018B9 RID: 6329
		public const string VA_RADIOALIASDISPLAY = "VA_RADIOALIASDISPLAY";

		// Token: 0x040018BA RID: 6330
		public const string VA_JOBTICKETS = "VA_JOBTICKETS";

		// Token: 0x040018BB RID: 6331
		public const string VA_ACTIONLIST = "VA_ACTIONLIST";

		// Token: 0x040018BC RID: 6332
		public const string VA_GPSON = "VA_GPSON";

		// Token: 0x040018BD RID: 6333
		public const string VA_GPSONTYPE = "VA_GPSONTYPE";

		// Token: 0x040018BE RID: 6334
		public const string VA_GPSONID = "VA_GPSONID";

		// Token: 0x040018BF RID: 6335
		public const string VA_GPSOFF = "VA_GPSOFF";

		// Token: 0x040018C0 RID: 6336
		public const string VA_GPSOFFTYPE = "VA_GPSOFFTYPE";

		// Token: 0x040018C1 RID: 6337
		public const string VA_GPSOFFID = "VA_GPSOFFID";

		// Token: 0x040018C2 RID: 6338
		public const string VA_RINGTONESTYLE = "VA_RINGTONESTYLE";

		// Token: 0x040018C3 RID: 6339
		public const string VA_NOTIFICATIONS = "VA_NOTIFICATIONS";

		// Token: 0x040018C4 RID: 6340
		public const string VA_PHONEENTRYLIST = "VA_PHONEENTRYLIST";

		// Token: 0x040018C5 RID: 6341
		public const string VA_PHONEENTRYLISTTYPE = "VA_PHONEENTRYLISTTYPE";

		// Token: 0x040018C6 RID: 6342
		public const string VA_PHONEENTRYLISTID = "VA_PHONEENTRYLISTID";

		// Token: 0x040018C7 RID: 6343
		public const string VA_PHONEMANUALDIAL = "VA_PHONEMANUALDIAL";

		// Token: 0x040018C8 RID: 6344
		public const string VA_PHONEMANUALDIALTYPE = "VA_PHONEMANUALDIALTYPE";

		// Token: 0x040018C9 RID: 6345
		public const string VA_PHONEMANUALDIALID = "VA_PHONEMANUALDIALID";

		// Token: 0x040018CA RID: 6346
		public const string VA_PHONEEXIT = "VA_PHONEEXIT";

		// Token: 0x040018CB RID: 6347
		public const string VA_PHONEEXITTYPE = "VA_PHONEEXITTYPE";

		// Token: 0x040018CC RID: 6348
		public const string VA_PHONEEXITID = "VA_PHONEEXITID";

		// Token: 0x040018CD RID: 6349
		public const string VA_BLUETOOTHDISCOVERABLEON = "VA_BLUETOOTHDISCOVERABLEON";

		// Token: 0x040018CE RID: 6350
		public const string VA_BLUETOOTHDISCOVERABLEONTYPE = "VA_BLUETOOTHDISCOVERABLEONTYPE";

		// Token: 0x040018CF RID: 6351
		public const string VA_BLUETOOTHDISCOVERABLEONID = "VA_BLUETOOTHDISCOVERABLEONID";

		// Token: 0x040018D0 RID: 6352
		public const string VA_BLUETOOTHDISCOVERABLEOFF = "VA_BLUETOOTHDISCOVERABLEOFF";

		// Token: 0x040018D1 RID: 6353
		public const string VA_BLUETOOTHDISCOVERABLEOFFTYPE = "VA_BLUETOOTHDISCOVERABLEOFFTYPE";

		// Token: 0x040018D2 RID: 6354
		public const string VA_BLUETOOTHDISCOVERABLEOFFID = "VA_BLUETOOTHDISCOVERABLEOFFID";

		// Token: 0x040018D3 RID: 6355
		public const string VA_ONETOUCHPHONECALL = "VA_ONETOUCHPHONECALL";

		// Token: 0x040018D4 RID: 6356
		public const string VA_ONETOUCHPHONECALLTYPE = "VA_ONETOUCHPHONECALLTYPE";

		// Token: 0x040018D5 RID: 6357
		public const string VA_ONETOUCHPHONECALLID = "VA_ONETOUCHPHONECALLID";

		// Token: 0x040018D6 RID: 6358
		public const string VA_MANDOWNON = "VA_MANDOWNON";

		// Token: 0x040018D7 RID: 6359
		public const string VA_MANDOWNONTYPE = "VA_MANDOWNONTYPE";

		// Token: 0x040018D8 RID: 6360
		public const string VA_VA_MANDOWNONID = "VA_MANDOWNONID";

		// Token: 0x040018D9 RID: 6361
		public const string VA_MANDOWNOFF = "VA_MANDOWNOFF";

		// Token: 0x040018DA RID: 6362
		public const string VA_MANDOWNOFFTYPE = "VA_MANDOWNOFFTYPE";

		// Token: 0x040018DB RID: 6363
		public const string VA_VA_MANDOWNOFFID = "VA_MANDOWNOFFID";

		// Token: 0x040018DC RID: 6364
		public const string VA_DYNAMICDISTORTIONCONTROLON = "VA_DYNAMICDISTORTIONCONTROLON";

		// Token: 0x040018DD RID: 6365
		public const string VA_DYNAMICDISTORTIONCONTROLOFF = "VA_DYNAMICDISTORTIONCONTROLOFF";

		// Token: 0x040018DE RID: 6366
		public const string VA_HOWLINGSUPPRESSORON = "VA_HOWLINGSUPPRESSORON";

		// Token: 0x040018DF RID: 6367
		public const string VA_HOWLINGSUPPRESSOROFF = "VA_HOWLINGSUPPRESSOROFF";

		// Token: 0x040018E0 RID: 6368
		public const string VA_ANALOGVOICESCRAMBLINGON = "VA_ANALOGVOICESCRAMBLINGON";

		// Token: 0x040018E1 RID: 6369
		public const string VA_ANALOGVOICESCRAMBLINGOFF = "VA_ANALOGVOICESCRAMBLINGOFF";

		// Token: 0x040018E2 RID: 6370
		public const string VA_ANALOGVOICESCRAMBLING3PT39KHZ = "VA_ANALOGVOICESCRAMBLING3PT39KHZ";

		// Token: 0x040018E3 RID: 6371
		public const string VA_ANALOGVOICESCRAMBLING3PT29KHZ = "VA_ANALOGVOICESCRAMBLING3PT29KHZ";

		// Token: 0x040018E4 RID: 6372
		public const string VA_FLEXIBLERXLISTON = "VA_FLEXIBLERXLISTON";

		// Token: 0x040018E5 RID: 6373
		public const string VA_FLEXIBLERXLISTOFF = "VA_FLEXIBLERXLISTOFF";

		// Token: 0x040018E6 RID: 6374
		public const string VA_BATTERYLILONSELECTED = "VA_BATTERYLILONSELECTED";

		// Token: 0x040018E7 RID: 6375
		public const string VA_BATTERYNIMHSELECTED = "VA_BATTERYNIMHSELECTED";

		// Token: 0x040018E8 RID: 6376
		public const string VA_BATTERYINVALIDSELECTED = "VA_BATTERYINVALIDSELECTED";

		// Token: 0x040018E9 RID: 6377
		public const string VA_CHARGERINVALIDSELECTED = "VA_CHARGERINVALIDSELECTED";

		// Token: 0x040018EA RID: 6378
		public const string VA_BATTERYCHARGERINVALIDSELECTED = "VA_BATTERYCHARGERINVALIDSELECTED";

		// Token: 0x040018EB RID: 6379
		public const string VA_CHARGINGERRORSELECTED = "VA_CHARGINGERRORSELECTED";

		// Token: 0x040018EC RID: 6380
		public const string VA_EXTERNALAUDIOON = "VA_EXTERNALAUDIOON";

		// Token: 0x040018ED RID: 6381
		public const string VA_EXTERNALAUDIOOFF = "VA_EXTERNALAUDIOOFF";

		// Token: 0x040018EE RID: 6382
		public const string VA_TRILLENHANCEON = "VA_TRILLENHANCEON";

		// Token: 0x040018EF RID: 6383
		public const string VA_TRILLENHANCEOFF = "VA_TRILLENHANCEOFF";

		// Token: 0x040018F0 RID: 6384
		public const string VA_HOMECHANNELREMINDERSILENCED = "VA_HOMECHANNELREMINDERSILENCED";

		// Token: 0x040018F1 RID: 6385
		public const string VA_NEWHOMECHANNEL = "VA_NEWHOMECHANNEL";

		// Token: 0x040018F2 RID: 6386
		public const string VA_NONHOMECHANNEL = "VA_NONHOMECHANNEL";

		// Token: 0x040018F3 RID: 6387
		public const string VA_REKEY = "VA_REKEY";

		// Token: 0x040018F4 RID: 6388
		public const string VA_WIFION = "VA_WIFION";

		// Token: 0x040018F5 RID: 6389
		public const string VA_WIFIOFF = "VA_WIFIOFF";

		// Token: 0x040018F6 RID: 6390
		public const string VA_WIFIENABLED = "VA_WIFIENABLED";

		// Token: 0x040018F7 RID: 6391
		public const string VA_WIFIDISABLED = "VA_WIFIDISABLED";

		// Token: 0x040018F8 RID: 6392
		public const string VA_WIFICONNECTED = "VA_WIFICONNECTED";

		// Token: 0x040018F9 RID: 6393
		public const string VA_VIBRATESTYLE = "VA_VIBRATESTYLE";

		// Token: 0x040018FA RID: 6394
		public const string VA_WRONGBATTERY = "VA_WRONGBATTERY";

		// Token: 0x040018FB RID: 6395
		public const string VA_TRANSMITINHIBITON = "VA_TRANSMITINHIBITON";

		// Token: 0x040018FC RID: 6396
		public const string VA_TRANSMITINHIBITOFF = "VA_TRANSMITINHIBITOFF";

		// Token: 0x040018FD RID: 6397
		public const string VA_RINGTONESTYLESILENT = "VA_RINGTONESTYLESILENT";

		// Token: 0x040018FE RID: 6398
		public const string VA_INDOORLOCATIONOFF = "VA_INDOORLOCATIONOFF";

		// Token: 0x040018FF RID: 6399
		public const string VA_INDOORLOCATIONON = "VA_INDOORLOCATIONON";

		// Token: 0x04001900 RID: 6400
		public const string VA_GLOVEMODEON = "VA_GLOVEMODEON";

		// Token: 0x04001901 RID: 6401
		public const string VA_GLOVEMODEOFF = "VA_GLOVEMODEOFF";

		// Token: 0x04001902 RID: 6402
		public const string VA_CANCEL = "VA_CANCEL";

		// Token: 0x04001903 RID: 6403
		public const string VA_RESPONSEINHIBITON = "VA_RESPONSEINHIBITON";

		// Token: 0x04001904 RID: 6404
		public const string VA_RESPONSEINHIBITOFF = "VA_RESPONSEINHIBITOFF";

		// Token: 0x04001905 RID: 6405
		public const string SUBTYPE = "Subtype";

		// Token: 0x04001906 RID: 6406
		public const string HASSUBTYPE = "HasSubtype";

		// Token: 0x04001907 RID: 6407
		public const string SUBNAME = "SUBNAME";

		// Token: 0x04001908 RID: 6408
		public const string RASSUIDRG_CMP_TYPE = "RASSUIDRG_CMP_TYPE";

		// Token: 0x04001909 RID: 6409
		public const string RASDATA_CMP_TYPE = "RASDATA_CMP_TYPE";

		// Token: 0x0400190A RID: 6410
		public const string RASDATA_RASALIAS = "RASDATA_RASALIAS";

		// Token: 0x0400190B RID: 6411
		public const string CP_RASDATAITEM = "CP_RASDATAITEM";

		// Token: 0x0400190C RID: 6412
		public const string CP_RASDATAITEMID = "CP_RASDATAITEMID";

		// Token: 0x0400190D RID: 6413
		public const string CP_RASDATAITEMTYPE = "CP_RASDATAITEMTYPE";

		// Token: 0x0400190E RID: 6414
		public const string RASKEY_HIDDEN_SYMBOL_VALUE = "0";

		// Token: 0x0400190F RID: 6415
		public const string RASDATA_RASKEY = "RASDATA_RASKEY";

		// Token: 0x04001910 RID: 6416
		public const string BR_RASKEY = "BR_RASKEY";

		// Token: 0x04001911 RID: 6417
		public const string BR_RASMODE = "BR_RASMODE";

		// Token: 0x04001912 RID: 6418
		public const string STR_ENABLED = "STR_ENABLED";

		// Token: 0x04001913 RID: 6419
		public const string STR_MIGRATION = "STR_MIGRATION";

		// Token: 0x04001914 RID: 6420
		public const string BR_RASSUIDRANGECHECK = "BR_RASSUIDRANGECHECK";

		// Token: 0x04001915 RID: 6421
		public const string BR_DCTXPWER = "BR_DCTXPWER";

		// Token: 0x04001916 RID: 6422
		public const string BR_DCTXPWER1 = "BR_DCTXPWER1";

		// Token: 0x04001917 RID: 6423
		public const string BR_DCTXPWER2 = "BR_DCTXPWER2";

		// Token: 0x04001918 RID: 6424
		public const string BR_DCTXPWER12V = "BR_DCTXPWER12V";

		// Token: 0x04001919 RID: 6425
		public const string BR_DCTXPOWER3 = "BR_DCTXPOWER3";

		// Token: 0x0400191A RID: 6426
		public const string CP_S1SCF = "CP_S1SCF";

		// Token: 0x0400191B RID: 6427
		public const string CP_S2SCF = "CP_S2SCF";

		// Token: 0x0400191C RID: 6428
		public const string MDP_CMP_TYPE = "MDP_CMP_TYPE";

		// Token: 0x0400191D RID: 6429
		public const string MDP_CMP_TYPE_GRP = "MDP_CMP_TYPE_GRP";

		// Token: 0x0400191E RID: 6430
		public const string MDP_CMP_TYPE_PARENT = "MDP_CMP_TYPE_PARENT";

		// Token: 0x0400191F RID: 6431
		public const string MDP_PROFILEALIAS = "MDP_PROFILEALIAS";

		// Token: 0x04001920 RID: 6432
		public const string CP_MANDOWNPROFILEITEM = "CP_MANDOWNPROFILEITEM";

		// Token: 0x04001921 RID: 6433
		public const string CP_MANDOWNPROFILEITEMID = "CP_MANDOWNPROFILEITEMID";

		// Token: 0x04001922 RID: 6434
		public const string CP_MANDOWNPROFILEITEMTYPE = "CP_MANDOWNPROFILEITEMTYPE";

		// Token: 0x04001923 RID: 6435
		public const string STR_AUTO = "STR_AUTO";

		// Token: 0x04001924 RID: 6436
		public const string CP_SQUELCHLEVELSETTING = "CP_SQUELCHLEVELSETTING";

		// Token: 0x04001925 RID: 6437
		public const string CP_REPEATERSQUELCHSETTING = "CP_REPEATERSQUELCHSETTING";

		// Token: 0x04001926 RID: 6438
		public const string BRPC_RINGTONELEVEL = "BRPC_RINGTONELEVEL";

		// Token: 0x04001927 RID: 6439
		public const string BRPC_DTPBTLV = "BRPC_DTPBTLV";

		// Token: 0x04001928 RID: 6440
		public const string BRPC_DTPTIDRTLV = "BRPC_DTPTIDRTLV";

		// Token: 0x04001929 RID: 6441
		public const string ATEX = "ATEX";

		// Token: 0x0400192A RID: 6442
		public const string ATEX_M1 = "ATEX_M1";

		// Token: 0x0400192B RID: 6443
		public const string CSA = "CSA";

		// Token: 0x0400192C RID: 6444
		public const string REFRESH = "REFRESH";

		// Token: 0x0400192D RID: 6445
		public const string REUNION = "Reunion";

		// Token: 0x0400192E RID: 6446
		public const string ThreeButtonMOR = "ThreeButtonMOR";

		// Token: 0x0400192F RID: 6447
		public const string FourButtonMOR = "FourButtonMOR";

		// Token: 0x04001930 RID: 6448
		public const string CBZONE = "CBZONE";

		// Token: 0x04001931 RID: 6449
		public const string LMTSYS = "LMTSYS";

		// Token: 0x04001932 RID: 6450
		public const string PARADISE22_CODEPLUG_VERSION = "04.00.00";

		// Token: 0x04001933 RID: 6451
		public const string PARADISE22A_CODEPLUG_VERSION = "04.01.00";

		// Token: 0x04001934 RID: 6452
		public const string RD_RESERVED = "RD_RESERVED";

		// Token: 0x04001935 RID: 6453
		public const string RD_MANDOWNVOLUMELEVEL = "RD_MANDOWNVOLUMELEVEL";

		// Token: 0x04001936 RID: 6454
		public const string S5ENCTELEGRAM_ACK = "S5ENCTELEGRAM_ACK";

		// Token: 0x04001937 RID: 6455
		public const string ACKWITHVOICE = "ACKWITHVOICE";

		// Token: 0x04001938 RID: 6456
		public const string MENU_QKDLSUB = "MENU_QKDLSUB";

		// Token: 0x04001939 RID: 6457
		public const string FWTYPE_ANALOG = "FWTYPE_ANALOG";

		// Token: 0x0400193A RID: 6458
		public const string FWTYPE_ANALOG_AND_DIGITAL = "FWTYPE_ANALOG_AND_DIGITAL";

		// Token: 0x0400193B RID: 6459
		public const string BR_DVE = "BR_DVE";

		// Token: 0x0400193C RID: 6460
		public const string BR_DVSR = "BR_DVSR";

		// Token: 0x0400193D RID: 6461
		public const string BR_VOTINGMODE = "BR_VOTINGMODE";

		// Token: 0x0400193E RID: 6462
		public const string NORMAL_REPEATER = "NORMAL_REPEATER";

		// Token: 0x0400193F RID: 6463
		public const string DIGITAL_VOTER = "DIGITAL_VOTER";

		// Token: 0x04001940 RID: 6464
		public const string ANALOG_SATELLITE_RECEIVER = "ANALOG_SATELLITE_RECEIVER";

		// Token: 0x04001941 RID: 6465
		public const string DIGITAL_SATELLITE_RECEIVER = "DIGITAL_SATELLITE_RECEIVER";

		// Token: 0x04001942 RID: 6466
		public const string BR_VRPID = "BR_VRPID";

		// Token: 0x04001943 RID: 6467
		public const string BR_VSF = "BR_VSF";

		// Token: 0x04001944 RID: 6468
		public const int DIGITAL_FIRMWARE_TYPE = 1;

		// Token: 0x04001945 RID: 6469
		public const int ANALOG_FIRMWARE_TYPE = 2;

		// Token: 0x04001946 RID: 6470
		public const string CP_AESPRVCYIT = "CP_AESPRVCYIT";

		// Token: 0x04001947 RID: 6471
		public const string CP_AESPRVCYITID = "CP_AESPRVCYITID";

		// Token: 0x04001948 RID: 6472
		public const string CP_AESPRVCYITTYPE = "CP_AESPRVCYITTYPE";

		// Token: 0x04001949 RID: 6473
		public const string AESPRI_CMP_TYPE = "AESPRI_CMP_TYPE";

		// Token: 0x0400194A RID: 6474
		public const string AESPRI_PKEYID = "AESPRI_PKEYID";

		// Token: 0x0400194B RID: 6475
		public const string AESPRI_PKEY = "AESPRI_PKEY";

		// Token: 0x0400194C RID: 6476
		public const string AESPRI_PKEYALIAS = "AESPRI_PKEYALIAS";

		// Token: 0x0400194D RID: 6477
		public const string AESKEY_HIDDEN_SYMBOL_VALUE = "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF";

		// Token: 0x0400194E RID: 6478
		public const string SURC_DELETEALLTEXTMESSAGES = "SURC_DELETEALLTEXTMESSAGES";

		// Token: 0x0400194F RID: 6479
		public const string DMR3 = "DMR3";

		// Token: 0x04001950 RID: 6480
		public const string DMR3_SYS_CMP_TYPE = "DMR3_SYS_CMP_TYPE";

		// Token: 0x04001951 RID: 6481
		public const string DMR3_SYS_CMP_TYPE_GRP = "DMR3_SYS_CMP_TYPE_GRP";

		// Token: 0x04001952 RID: 6482
		public const string DMR3SYS_SYSTEM_ALIAS = "DMR3SYS_SYSTEM_ALIAS";

		// Token: 0x04001953 RID: 6483
		public const string DMR3SYS_DMR3SITELISTITEM = "DMR3SYS_DMR3SITELISTITEM";

		// Token: 0x04001954 RID: 6484
		public const string DMR3SYS_DMR3SITELISTITEMID = "DMR3SYS_DMR3SITELISTITEMID";

		// Token: 0x04001955 RID: 6485
		public const string DMR3SYS_DMR3_FLEXIBLE_CHANNEL_PLAN_ISH_ITEM = "DMR3SYS_DMR3_FLEXIBLE_CHANNEL_PLAN_ISH_ITEM";

		// Token: 0x04001956 RID: 6486
		public const string DMR3SYS_DMR3_FLEXIBLE_CHANNEL_PLAN_ISH_ITEMID = "DMR3SYS_DMR3_FLEXIBLE_CHANNEL_PLAN_ISH_ITEMID";

		// Token: 0x04001957 RID: 6487
		public const string DMR3SYS_SUBSCRIBERID = "DMR3SYS_SUBSCRIBERID";

		// Token: 0x04001958 RID: 6488
		public const string DMR3SYS_DMR3PREFERREDSITEITEM = "DMR3SYS_DMR3PREFERREDSITEITEM";

		// Token: 0x04001959 RID: 6489
		public const string DMR3SYS_DMR3PREFERREDSITEITEMID = "DMR3SYS_DMR3PREFERREDSITEITEMID";

		// Token: 0x0400195A RID: 6490
		public const string DMR3_EMERGENCY_SYS_CMP_TYPE = "DMR3_EMERGENCY_SYS_CMP_TYPE";

		// Token: 0x0400195B RID: 6491
		public const string DMR3_EMERGENCY_SYS_CMP_TYPE_GRP = "DMR3_EMERGENCY_SYS_CMP_TYPE_GRP";

		// Token: 0x0400195C RID: 6492
		public const string DMR3ESCB_EMERGENCY_CALL_ID_ITEM = "DMR3ESCB_EMERGENCY_CALL_ID_ITEM";

		// Token: 0x0400195D RID: 6493
		public const string DMR3ESCB_EMERGENCY_CALL_ID_ITEMID = "DMR3ESCB_EMERGENCY_CALL_ID_ITEMID";

		// Token: 0x0400195E RID: 6494
		public const string SLIST_REVERT_CHANNEL_ISH_ITEM = "SLIST_REVERT_CHANNEL_ISH_ITEM";

		// Token: 0x0400195F RID: 6495
		public const string SLIST_REVERT_CHANNEL_ISH_ITEMID = "SLIST_REVERT_CHANNEL_ISH_ITEMID";

		// Token: 0x04001960 RID: 6496
		public const string SLIST_CCISHITEM = "SLIST_CCISHITEM";

		// Token: 0x04001961 RID: 6497
		public const string SLIST_CCISHITEMID = "SLIST_CCISHITEMID";

		// Token: 0x04001962 RID: 6498
		public const string SLIST_VAFILEITEM = "SLIST_VAFILEITEM";

		// Token: 0x04001963 RID: 6499
		public const string SLIST_VAFILEITEMID = "SLIST_VAFILEITEMID";

		// Token: 0x04001964 RID: 6500
		public const string RCLISTDLL_TXFREQUENCY = "RCLISTDLL_TXFREQUENCY";

		// Token: 0x04001965 RID: 6501
		public const string RCLISTDLL_RXFREQUENCY = "RCLISTDLL_RXFREQUENCY";

		// Token: 0x04001966 RID: 6502
		public const string FLXCHANPLANLISTDLL_DMR3SITEDLLITEM = "FLXCHANPLANLISTDLL_DMR3SITEDLLITEM";

		// Token: 0x04001967 RID: 6503
		public const string FLXCHANPLANLISTDLL_DMR3SITEDLLITEMID = "FLXCHANPLANLISTDLL_DMR3SITEDLLITEMID";

		// Token: 0x04001968 RID: 6504
		public const int NUMBER_OF_CB_CHANNELS = 80;

		// Token: 0x04001969 RID: 6505
		public const int NUMBER_OF_CB_ZONES = 1;

		// Token: 0x0400196A RID: 6506
		public const string CBZONE_NAME = "CB Zone";

		// Token: 0x0400196B RID: 6507
		public static bool ReadOperation;

		// Token: 0x0400196C RID: 6508
		public static bool AutoCorrect;

		// Token: 0x0400196D RID: 6509
		public static global::System.Collections.Hashtable m_hsTagIDs;

		// Token: 0x0400196E RID: 6510
		public static readonly global::System.Collections.Generic.Dictionary<global::Motorola.Common.Communication.CommonUtil.PasswordPolicy, global::System.Collections.Generic.HashSet<global::constants.Operationtype>> PASSWORD_POLICY_DICTIONARY;

		// Token: 0x0400196F RID: 6511
		public static readonly global::System.Collections.Generic.List<string> LIMITED_MODELS;

		// Token: 0x02000005 RID: 5
		public enum RemoteProgrammingCheck
		{
			// Token: 0x04001972 RID: 6514
			NO_CHANGE,
			// Token: 0x04001973 RID: 6515
			REMOTE_PRGRM_DISABLED,
			// Token: 0x04001974 RID: 6516
			LINK_ESTABLISHMENT_CHANGED,
			// Token: 0x04001975 RID: 6517
			RP_DISABLED_AND_LE_CHANGED
		}

		// Token: 0x02000006 RID: 6
		// (Invoke) Token: 0x06000009 RID: 9
		[global::System.Runtime.InteropServices.UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public delegate void SetProgressBar([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.I4)] int iPercentage);

		// Token: 0x02000007 RID: 7
		public enum PcrPartition : byte
		{
			// Token: 0x04001977 RID: 6519
			Application = 128,
			// Token: 0x04001978 RID: 6520
			Security,
			// Token: 0x04001979 RID: 6521
			Tune,
			// Token: 0x0400197A RID: 6522
			Cfs = 135,
			// Token: 0x0400197B RID: 6523
			Ucl = 147
		}
	}
}
