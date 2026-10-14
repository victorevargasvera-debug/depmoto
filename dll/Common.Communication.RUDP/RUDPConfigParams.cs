using System;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Xml;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.RUDP
{
	// Token: 0x02000010 RID: 16
	public class RUDPConfigParams
	{
		// Token: 0x060000D6 RID: 214 RVA: 0x00005714 File Offset: 0x00003914
		public void LoadConfig(string configFilePath)
		{
			if (configFilePath == null)
			{
				return;
			}
			try
			{
				using (global::System.IO.FileStream fileStream = new global::System.IO.FileStream(configFilePath, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read))
				{
					global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
					xmlDocument.Load(fileStream);
					global::System.Xml.XmlNodeList xmlNodeList = xmlDocument.SelectNodes("RUDPConfigParameters/ConfigurationParameters/Param");
					foreach (object obj in xmlNodeList)
					{
						global::System.Xml.XmlNode node = (global::System.Xml.XmlNode)obj;
						global::Motorola.Common.Communication.RUDP.RUDPConfigParams.SetValuesFromXml(node, this);
					}
					xmlNodeList = xmlDocument.SelectNodes("RUDPConfigParameters/NegotiationParameters/Param");
					foreach (object obj2 in xmlNodeList)
					{
						global::System.Xml.XmlNode node2 = (global::System.Xml.XmlNode)obj2;
						global::Motorola.Common.Communication.RUDP.RUDPConfigParams.SetValuesFromXml(node2, this.syn_negociate_parameters);
					}
					xmlNodeList = xmlDocument.SelectNodes("RUDPConfigParameters/ConnectivityParameters/Param");
					foreach (object obj3 in xmlNodeList)
					{
						global::System.Xml.XmlNode node3 = (global::System.Xml.XmlNode)obj3;
						global::Motorola.Common.Communication.RUDP.RUDPConfigParams.SetValuesFromXml(node3, this.connectivity_parameters);
					}
				}
			}
			catch (global::System.Exception systemException)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RUDP_InvalidConfigurationFile, systemException);
			}
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x000058C0 File Offset: 0x00003AC0
		private static void SetValuesFromXml(global::System.Xml.XmlNode node, object obj)
		{
			global::System.Reflection.PropertyInfo property = obj.GetType().GetProperty(node.Attributes["name"].Value, global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic);
			if (property.PropertyType == typeof(int))
			{
				int num = int.Parse(node.Attributes["value"].Value, global::System.Globalization.CultureInfo.InvariantCulture);
				int num2 = int.Parse(node.Attributes["minValue"].Value, global::System.Globalization.CultureInfo.InvariantCulture);
				int num3 = int.Parse(node.Attributes["maxValue"].Value, global::System.Globalization.CultureInfo.InvariantCulture);
				int num4 = int.Parse(node.Attributes["default"].Value, global::System.Globalization.CultureInfo.InvariantCulture);
				int num5 = (num >= num2 && num <= num3) ? num : num4;
				property.SetValue(obj, num5, null);
				return;
			}
			if (property.PropertyType == typeof(float))
			{
				float num6 = float.Parse(node.Attributes["value"].Value, global::System.Globalization.CultureInfo.InvariantCulture);
				float num7 = float.Parse(node.Attributes["minValue"].Value, global::System.Globalization.CultureInfo.InvariantCulture);
				float num8 = float.Parse(node.Attributes["maxValue"].Value, global::System.Globalization.CultureInfo.InvariantCulture);
				float num9 = float.Parse(node.Attributes["default"].Value, global::System.Globalization.CultureInfo.InvariantCulture);
				float num10 = (num6 >= num7 && num6 <= num8) ? num6 : num9;
				property.SetValue(obj, num10, null);
				return;
			}
			if (property.PropertyType == typeof(uint))
			{
				uint num11 = uint.Parse(node.Attributes["value"].Value, global::System.Globalization.CultureInfo.InvariantCulture);
				uint num12 = uint.Parse(node.Attributes["minValue"].Value, global::System.Globalization.CultureInfo.InvariantCulture);
				uint num13 = uint.Parse(node.Attributes["maxValue"].Value, global::System.Globalization.CultureInfo.InvariantCulture);
				uint num14 = uint.Parse(node.Attributes["default"].Value, global::System.Globalization.CultureInfo.InvariantCulture);
				uint num15 = (num11 >= num12 && num11 <= num13) ? num11 : num14;
				property.SetValue(obj, num15, null);
				return;
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RUDP_InvalidTypeInConfigurationFile);
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x00005B38 File Offset: 0x00003D38
		// (set) Token: 0x060000D9 RID: 217 RVA: 0x00005B40 File Offset: 0x00003D40
		public global::Motorola.Common.Communication.RUDP.NegotiateParams SynNegociateParameters
		{
			get
			{
				return this.syn_negociate_parameters;
			}
			set
			{
				this.syn_negociate_parameters = value;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000DA RID: 218 RVA: 0x00005B49 File Offset: 0x00003D49
		// (set) Token: 0x060000DB RID: 219 RVA: 0x00005B51 File Offset: 0x00003D51
		public global::Motorola.Common.Communication.RUDP.ConnectivityParams ConnectivityParameters
		{
			get
			{
				return this.connectivity_parameters;
			}
			set
			{
				this.connectivity_parameters = value;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000DC RID: 220 RVA: 0x00005B5A File Offset: 0x00003D5A
		// (set) Token: 0x060000DD RID: 221 RVA: 0x00005B62 File Offset: 0x00003D62
		public int NegotiationAlgorithm
		{
			get
			{
				return this.negotiation_algorithm;
			}
			set
			{
				this.negotiation_algorithm = value;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000DE RID: 222 RVA: 0x00005B6B File Offset: 0x00003D6B
		// (set) Token: 0x060000DF RID: 223 RVA: 0x00005B73 File Offset: 0x00003D73
		public int CloseWaitTimeout
		{
			get
			{
				return this.close_wait_timeout;
			}
			set
			{
				this.close_wait_timeout = value;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x00005B7C File Offset: 0x00003D7C
		// (set) Token: 0x060000E1 RID: 225 RVA: 0x00005B84 File Offset: 0x00003D84
		public int MaxNumberofRetries
		{
			get
			{
				return this.max_number_of_retries;
			}
			set
			{
				this.max_number_of_retries = value;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000E2 RID: 226 RVA: 0x00005B8D File Offset: 0x00003D8D
		// (set) Token: 0x060000E3 RID: 227 RVA: 0x00005B95 File Offset: 0x00003D95
		public int TimeBetweenRetries
		{
			get
			{
				return this.time_between_retries;
			}
			set
			{
				this.time_between_retries = value;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000E4 RID: 228 RVA: 0x00005B9E File Offset: 0x00003D9E
		// (set) Token: 0x060000E5 RID: 229 RVA: 0x00005BA6 File Offset: 0x00003DA6
		public float RetryCurveShape
		{
			get
			{
				return this.retry_curve_shape;
			}
			set
			{
				this.retry_curve_shape = value;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x00005BAF File Offset: 0x00003DAF
		// (set) Token: 0x060000E7 RID: 231 RVA: 0x00005BB7 File Offset: 0x00003DB7
		public int MaxTimeBetweenRetries
		{
			get
			{
				return this.max_time_between_retries;
			}
			set
			{
				this.max_time_between_retries = value;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x00005BC0 File Offset: 0x00003DC0
		// (set) Token: 0x060000E9 RID: 233 RVA: 0x00005BC8 File Offset: 0x00003DC8
		public int InactivityTimeout
		{
			get
			{
				return this.inactivity_timeout;
			}
			set
			{
				this.inactivity_timeout = value;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000EA RID: 234 RVA: 0x00005BD1 File Offset: 0x00003DD1
		// (set) Token: 0x060000EB RID: 235 RVA: 0x00005BD9 File Offset: 0x00003DD9
		public int DelayedAckTimeout
		{
			get
			{
				return this.delayed_ack_timeout;
			}
			set
			{
				this.delayed_ack_timeout = value;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000EC RID: 236 RVA: 0x00005BE2 File Offset: 0x00003DE2
		// (set) Token: 0x060000ED RID: 237 RVA: 0x00005BEA File Offset: 0x00003DEA
		public int CloseProcessingMode
		{
			get
			{
				return this.close_processing_mode;
			}
			set
			{
				this.close_processing_mode = value;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000EE RID: 238 RVA: 0x00005BF3 File Offset: 0x00003DF3
		// (set) Token: 0x060000EF RID: 239 RVA: 0x00005BFB File Offset: 0x00003DFB
		public uint MaxUserTxDataSize
		{
			get
			{
				return this.max_user_tx_data_size;
			}
			set
			{
				this.max_user_tx_data_size = value;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000F0 RID: 240 RVA: 0x00005C04 File Offset: 0x00003E04
		// (set) Token: 0x060000F1 RID: 241 RVA: 0x00005C0C File Offset: 0x00003E0C
		public uint MaxUserRxDataSize
		{
			get
			{
				return this.max_user_rx_data_size;
			}
			set
			{
				this.max_user_rx_data_size = value;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000F2 RID: 242 RVA: 0x00005C15 File Offset: 0x00003E15
		// (set) Token: 0x060000F3 RID: 243 RVA: 0x00005C1D File Offset: 0x00003E1D
		public int MaxIncomingMsgQueueSize
		{
			get
			{
				return this.max_incoming_msg_queue_size;
			}
			set
			{
				this.max_incoming_msg_queue_size = value;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000F4 RID: 244 RVA: 0x00005C26 File Offset: 0x00003E26
		// (set) Token: 0x060000F5 RID: 245 RVA: 0x00005C2E File Offset: 0x00003E2E
		public int MaxOutgoingMsgQueueSize
		{
			get
			{
				return this.max_outgoing_msg_queue_size;
			}
			set
			{
				this.max_outgoing_msg_queue_size = value;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000F6 RID: 246 RVA: 0x00005C37 File Offset: 0x00003E37
		// (set) Token: 0x060000F7 RID: 247 RVA: 0x00005C3F File Offset: 0x00003E3F
		public int ListofValidClientAddresses
		{
			get
			{
				return this.list_of_valid_client_addresses;
			}
			set
			{
				this.list_of_valid_client_addresses = value;
			}
		}

		// Token: 0x0400006B RID: 107
		private global::Motorola.Common.Communication.RUDP.NegotiateParams syn_negociate_parameters = new global::Motorola.Common.Communication.RUDP.NegotiateParams();

		// Token: 0x0400006C RID: 108
		private global::Motorola.Common.Communication.RUDP.ConnectivityParams connectivity_parameters = new global::Motorola.Common.Communication.RUDP.ConnectivityParams();

		// Token: 0x0400006D RID: 109
		private int negotiation_algorithm = 1;

		// Token: 0x0400006E RID: 110
		private int close_wait_timeout = 1000;

		// Token: 0x0400006F RID: 111
		private int max_number_of_retries = 3;

		// Token: 0x04000070 RID: 112
		private int time_between_retries = 3000;

		// Token: 0x04000071 RID: 113
		private float retry_curve_shape = 1f;

		// Token: 0x04000072 RID: 114
		private int max_time_between_retries = 40000;

		// Token: 0x04000073 RID: 115
		private int inactivity_timeout = 25000;

		// Token: 0x04000074 RID: 116
		private int delayed_ack_timeout = 75;

		// Token: 0x04000075 RID: 117
		private int close_processing_mode = 1;

		// Token: 0x04000076 RID: 118
		private uint max_user_tx_data_size = 10000U;

		// Token: 0x04000077 RID: 119
		private uint max_user_rx_data_size = 10000U;

		// Token: 0x04000078 RID: 120
		private int max_incoming_msg_queue_size = 10;

		// Token: 0x04000079 RID: 121
		private int max_outgoing_msg_queue_size = 10;

		// Token: 0x0400007A RID: 122
		private int list_of_valid_client_addresses;
	}
}
