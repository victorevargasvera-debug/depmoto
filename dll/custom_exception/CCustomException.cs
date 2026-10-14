using System;
using System.Collections;
using System.ComponentModel;
using System.Runtime.Serialization;
using Motorola.Common.CustomException;

namespace custom_exception
{
	// Token: 0x02000003 RID: 3
	[global::System.Serializable]
	public class CCustomException : global::System.Exception, global::System.Runtime.Serialization.ISerializable
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000004 RID: 4 RVA: 0x0000211C File Offset: 0x0000111C
		// (set) Token: 0x06000005 RID: 5 RVA: 0x00002160 File Offset: 0x00001160
		public string ReplaceMessage
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
				return this.replaceMessage;
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
				this.replaceMessage = value;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000006 RID: 6 RVA: 0x000021A4 File Offset: 0x000011A4
		// (set) Token: 0x06000007 RID: 7 RVA: 0x000021E8 File Offset: 0x000011E8
		public bool IsReplaceMessageResource
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
				return this.isReplaceMessageResource;
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
				this.isReplaceMessageResource = value;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000008 RID: 8 RVA: 0x0000222C File Offset: 0x0000122C
		// (set) Token: 0x06000009 RID: 9 RVA: 0x00002270 File Offset: 0x00001270
		[global::System.ComponentModel.Description("Specifies the Error ID for the exception.")]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Category("Customization")]
		[global::System.ComponentModel.DefaultValue(0)]
		public uint ErrorID
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
				return this.errorID;
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
				this.errorID = value;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000A RID: 10 RVA: 0x000022B4 File Offset: 0x000012B4
		// (set) Token: 0x0600000B RID: 11 RVA: 0x000022F8 File Offset: 0x000012F8
		[global::System.ComponentModel.Category("Customization")]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Description("Specifies the Exceptions.")]
		public global::System.Collections.ArrayList ExceptionList
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
				return this.alExceptions;
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
				this.alExceptions = value;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600000C RID: 12 RVA: 0x0000233C File Offset: 0x0000133C
		// (set) Token: 0x0600000D RID: 13 RVA: 0x00002380 File Offset: 0x00001380
		[global::System.ComponentModel.DefaultValue(0)]
		[global::System.ComponentModel.Category("Customization")]
		[global::System.ComponentModel.Description("Specifies the count of updates done before the exception.")]
		[global::System.ComponentModel.Bindable(true)]
		public uint pBarCount
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
				return this.pBarUpdates;
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
				this.pBarUpdates = value;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600000E RID: 14 RVA: 0x000023C4 File Offset: 0x000013C4
		// (set) Token: 0x0600000F RID: 15 RVA: 0x00002408 File Offset: 0x00001408
		[global::System.ComponentModel.DefaultValue("")]
		[global::System.ComponentModel.Description("Specifies the Message for the exception.")]
		[global::System.ComponentModel.Category("Customization")]
		[global::System.ComponentModel.Bindable(true)]
		public string serialNumber
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
				return this.serialNo;
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
				this.serialNo = value;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000010 RID: 16 RVA: 0x0000244C File Offset: 0x0000144C
		// (set) Token: 0x06000011 RID: 17 RVA: 0x00002490 File Offset: 0x00001490
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DefaultValue("")]
		[global::System.ComponentModel.Description("Specifies the block that caused the exception.")]
		[global::System.ComponentModel.Category("Customization")]
		public string BlockToSelect
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
				return this.blockToSelect;
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
				this.blockToSelect = value;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000012 RID: 18 RVA: 0x000024D4 File Offset: 0x000014D4
		// (set) Token: 0x06000013 RID: 19 RVA: 0x00002518 File Offset: 0x00001518
		[global::System.ComponentModel.DefaultValue("")]
		[global::System.ComponentModel.Description("Specifies the Message for the exception.")]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Category("Customization")]
		public string exMessage
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
				return this.message;
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
				this.message = value;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000014 RID: 20 RVA: 0x0000255C File Offset: 0x0000155C
		// (set) Token: 0x06000015 RID: 21 RVA: 0x000025A0 File Offset: 0x000015A0
		[global::System.ComponentModel.Description("Specifies the StackTrace for the exception.")]
		[global::System.ComponentModel.Category("Customization")]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DefaultValue("")]
		public string exStackTrace
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
				return this.stackTrace;
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
				this.stackTrace = value;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000016 RID: 22 RVA: 0x000025E4 File Offset: 0x000015E4
		// (set) Token: 0x06000017 RID: 23 RVA: 0x00002628 File Offset: 0x00001628
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Category("Customization")]
		[global::System.ComponentModel.DefaultValue("")]
		[global::System.ComponentModel.Description("Specifies the Source for the exception.")]
		public string exSource
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
				return this.source;
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
				this.source = value;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000018 RID: 24 RVA: 0x0000266C File Offset: 0x0000166C
		// (set) Token: 0x06000019 RID: 25 RVA: 0x000026B0 File Offset: 0x000016B0
		[global::System.ComponentModel.Description("Specifies the ListID of Block for the exception.")]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DefaultValue(0)]
		[global::System.ComponentModel.Category("Customization")]
		public uint ListID
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
				return this.listID;
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
				this.listID = value;
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000026F4 File Offset: 0x000016F4
		public CCustomException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			this.errorID = info.GetUInt32("ErrorID1");
			this.message = info.GetString("Message1");
			this.stackTrace = info.GetString("StackTrace1");
			this.source = info.GetString("Source1");
			this.serialNo = info.GetString("SerialNo1");
			this.pBarUpdates = info.GetUInt32("PBarUpdates1");
			this.alExceptions = (global::System.Collections.ArrayList)info.GetValue("AlExceptions1", typeof(global::System.Collections.ArrayList));
			this.listID = info.GetUInt32("listID1");
			this.isReplaceMessageResource = true;
			this.AddErrorMessage();
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000027C0 File Offset: 0x000017C0
		public override void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
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
			info.AddValue("ErrorID1", this.errorID);
			info.AddValue("Message1", this.message);
			info.AddValue("StackTrace1", this.stackTrace);
			info.AddValue("Source1", this.source);
			info.AddValue("SerialNo1", this.serialNo);
			info.AddValue("PBarUpdates1", this.pBarUpdates);
			info.AddValue("AlExceptions1", this.alExceptions, typeof(global::System.Collections.ArrayList));
			info.AddValue("listID1", this.listID);
			base.GetObjectData(info, context);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002898 File Offset: 0x00001898
		public CCustomException() : this(0U, string.Empty, string.Empty, string.Empty, string.Empty, 0U)
		{
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000028C4 File Offset: 0x000018C4
		public CCustomException(uint uErrorId, string _source, string _message, string trace) : this(uErrorId, _source, _message, trace, string.Empty, 0U)
		{
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000028E4 File Offset: 0x000018E4
		public CCustomException(uint uErrorId, string _source, string _message, string trace, string block, uint listID)
		{
			this.errorID = uErrorId;
			this.source = _source;
			this.message = _message;
			this.stackTrace = trace;
			this.blockToSelect = block;
			this.alExceptions = new global::System.Collections.ArrayList();
			this.listID = listID;
			this.isReplaceMessageResource = true;
			this.AddErrorMessage();
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002950 File Offset: 0x00001950
		public static void RemoveErrorID(global::System.Exception ex, ref string s)
		{
			int num = 0;
			int num2;
			string text;
			for (;;)
			{
				switch (num)
				{
				case 1:
					goto IL_50;
				case 2:
					goto IL_DB;
				case 3:
					if (num2 != -1)
					{
						num = 2;
						continue;
					}
					s = 2690.ToString();
					num = 1;
					continue;
				case 4:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						if (false)
						{
						}
						text = ex.Source;
						num2 = text.IndexOf("|", 0, global::System.StringComparison.Ordinal);
						break;
					}
					if (true)
					{
					}
					num = 3;
					continue;
				}
				if (ex.Source == null)
				{
					break;
				}
				num = 4;
			}
			IL_50:
			return;
			IL_DB:
			s = text.Substring(0, num2);
			text = text.Substring(num2 + 1, text.Length - (num2 + 1));
			ex.Source = text;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002A40 File Offset: 0x00001A40
		public static bool CheckErrorIDExsists(global::System.Exception ex)
		{
			int num = 0;
			for (;;)
			{
				switch (num)
				{
				case 1:
				{
					int num2;
					if (num2 != -1)
					{
						num = 3;
						continue;
					}
					goto IL_69;
				}
				case 2:
				{
					string text = ex.Source;
					int num2 = text.IndexOf("|", 0, global::System.StringComparison.Ordinal);
					num = 1;
					continue;
				}
				case 3:
					goto IL_67;
				}
				if (ex.Source == null)
				{
					goto IL_69;
				}
				num = 2;
			}
			return true;
			IL_67:
			return true;
			IL_69:
			switch ((1 == 1) ? 1 : 0)
			{
			case 0:
			case 2:
				return true;
			default:
				if (false)
				{
				}
				if (true)
				{
				}
				return false;
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002ADC File Offset: 0x00001ADC
		public static void ParseException(global::System.Exception ex, ref uint uError, ref string sSource, ref string sMessage, ref string sStackTrace)
		{
			switch (0)
			{
			default:
			{
				int num = 8;
				global::System.Collections.ArrayList arrayList2;
				for (;;)
				{
					global::System.Exception ex2;
					global::System.Collections.ArrayList arrayList;
					switch (num)
					{
					case 0:
					{
						if (ex2 == null)
						{
							num = 6;
							continue;
						}
						string value = ex2.StackTrace.ToString();
						arrayList.Add(value);
						ex2 = ex2.InnerException;
						num = 1;
						continue;
					}
					case 1:
						goto IL_187;
					case 2:
					{
						string text;
						if (text.Length <= 0)
						{
							num = 7;
							continue;
						}
						int num2 = text.IndexOf("|", 0, global::System.StringComparison.Ordinal);
						num = 18;
						continue;
					}
					case 3:
						goto IL_315;
					case 4:
						sStackTrace += global::System.Environment.NewLine;
						num = 14;
						continue;
					case 5:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1C6;
						default:
						{
							if (false)
							{
							}
							if (true)
							{
							}
							global::custom_exception.CCustomException ex3 = (global::custom_exception.CCustomException)ex;
							string text = ex3.message;
							arrayList2 = new global::System.Collections.ArrayList();
							num = 16;
							continue;
						}
						}
						break;
					case 6:
					{
						int count = arrayList.Count;
						int num3 = count - 1;
						num = 12;
						continue;
					}
					case 7:
						goto IL_2F1;
					case 9:
						goto IL_187;
					case 10:
						if (arrayList2.Count >= 4)
						{
							num = 3;
							continue;
						}
						return;
					case 11:
						goto IL_133;
					case 12:
						goto IL_133;
					case 13:
					{
						string text;
						int num2;
						arrayList2.Add(text.Substring(0, num2));
						text = text.Substring(num2 + 1, text.Length - (num2 + 1));
						num = 15;
						continue;
					}
					case 14:
						goto IL_1C6;
					case 15:
						goto IL_205;
					case 16:
						goto IL_205;
					case 17:
					{
						int num3;
						if (num3 < 0)
						{
							num = 4;
							continue;
						}
						sStackTrace += global::System.Environment.NewLine;
						sStackTrace += (string)arrayList[num3];
						num3--;
						num = 11;
						continue;
					}
					case 18:
					{
						int num2;
						if (num2 != -1)
						{
							num = 13;
							continue;
						}
						goto IL_2F1;
					}
					}
					if (ex.GetType().FullName.Equals(global::custom_exception.CCustomException.CLASS_NAME))
					{
						num = 5;
						continue;
					}
					string empty = string.Empty;
					global::custom_exception.CCustomException.RemoveErrorID(ex, ref empty);
					uError = global::System.Convert.ToUInt32(empty);
					sSource = ex.Source;
					sMessage = ex.Message;
					sStackTrace = string.Empty;
					arrayList = new global::System.Collections.ArrayList();
					ex2 = ex;
					num = 9;
					continue;
					IL_133:
					num = 17;
					continue;
					IL_187:
					num = 0;
					continue;
					IL_205:
					num = 2;
					continue;
					IL_2F1:
					num = 10;
				}
				IL_1C6:
				return;
				IL_315:
				uError = global::System.Convert.ToUInt32(arrayList2[0]);
				sSource = arrayList2[1].ToString();
				sMessage = arrayList2[2].ToString();
				sStackTrace = arrayList2[3].ToString();
				return;
			}
			}
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002E04 File Offset: 0x00001E04
		public static string MapErrorIdToString(int ErrorID)
		{
			string result;
			for (;;)
			{
				result = null;
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
							goto IL_78;
						default:
							goto IL_66;
						}
						break;
					case 1:
						goto IL_78;
					case 2:
						if (true)
						{
						}
						if (ErrorID >= 8192)
						{
							num = 1;
							continue;
						}
						result = ((global::custom_exception.CCustomException.HRESULT)ErrorID).ToString();
						num = 0;
						continue;
					case 3:
						return result;
					}
					break;
					IL_78:
					result = ((global::Motorola.Common.CustomException.CommonErrorCode)(ErrorID - 8192)).ToString();
					num = 3;
				}
			}
			IL_66:
			if (false)
			{
			}
			return result;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002EAC File Offset: 0x00001EAC
		public static uint GetErrorID(global::System.Exception ex)
		{
			int num = 3;
			string text;
			int num2;
			for (;;)
			{
				switch (num)
				{
				case 0:
					goto IL_9F;
				case 1:
					goto IL_90;
				case 2:
					text = ex.Source;
					num2 = text.IndexOf("|", 0, global::System.StringComparison.Ordinal);
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_90;
					default:
						if (false)
						{
						}
						if (true)
						{
						}
						num = 1;
						continue;
					}
					break;
				}
				if (ex.Source != null)
				{
					num = 2;
					continue;
				}
				return 0U;
				IL_90:
				if (num2 == -1)
				{
					break;
				}
				num = 0;
			}
			return 0U;
			IL_9F:
			return global::System.Convert.ToUInt32(text.Substring(0, num2));
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002F5C File Offset: 0x00001F5C
		public static void Rethrow(global::System.Exception ex)
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
			global::System.Exception ex2 = new global::System.Exception(ex.Message, ex);
			ex2.Source = ex.Source;
			global::custom_exception.CCustomException.AddOtherErrorMessage(ex);
			throw ex2;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002FB8 File Offset: 0x00001FB8
		public global::System.Exception ThrowException()
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
			return new global::System.Exception(string.Concat(new string[]
			{
				global::System.Convert.ToString(this.errorID),
				"|",
				this.source,
				"|",
				this.message,
				"|",
				this.stackTrace
			}))
			{
				Source = this.source
			};
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00003054 File Offset: 0x00002054
		public static bool IsInternalID(uint ErrorID)
		{
			for (;;)
			{
				if (true)
				{
				}
				if (ErrorID < 4096U)
				{
					return false;
				}
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_30;
				}
			}
			IL_30:
			if (false)
			{
			}
			return true;
		}

		// Token: 0x06000027 RID: 39 RVA: 0x0000309C File Offset: 0x0000209C
		public void AddErrorMessage()
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
			global::custom_exception.CCustomException.Log.b(string.Empty, this, null);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000030E8 File Offset: 0x000020E8
		public void AddErrorMessage(string message)
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
			global::custom_exception.CCustomException.Log.b(message, this, null);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00003130 File Offset: 0x00002130
		public void AddErrorMessage(global::System.Exception innerException)
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
			global::custom_exception.CCustomException.Log.b(string.Empty, this, innerException);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x0000317C File Offset: 0x0000217C
		public void AddErrorMessage(string message, global::System.Exception innerException)
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
			global::custom_exception.CCustomException.Log.b(message, this, innerException);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000031C4 File Offset: 0x000021C4
		public static void AddOtherErrorMessage(string message)
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
			global::custom_exception.CCustomException.Log.b(message, null, null);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x0000320C File Offset: 0x0000220C
		public static void AddOtherErrorMessage(string message, bool writeFileImmediately)
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
			global::custom_exception.CCustomException.Log.b(message, null, null, writeFileImmediately);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00003258 File Offset: 0x00002258
		public static void AddOtherErrorMessage(global::System.Exception ex)
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
			global::custom_exception.CCustomException.Log.b(string.Empty, ex, null);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000032A4 File Offset: 0x000022A4
		public static void AddOtherErrorMessage(string message, global::System.Exception ex)
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
			global::custom_exception.CCustomException.Log.b(message, ex, null);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000032EC File Offset: 0x000022EC
		public static void AddOtherErrorMessage(string message, global::System.Exception ex, bool writeFileImmediately)
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
			global::custom_exception.CCustomException.Log.b(message, ex, null, writeFileImmediately);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00003338 File Offset: 0x00002338
		// Note: this type is marked as 'beforefieldinit'.
		static CCustomException()
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
			global::custom_exception.CCustomException.CLASS_NAME = "custom_exception.CCustomException";
			global::custom_exception.CCustomException.Log = new global::custom_exception.a();
		}

		// Token: 0x04000003 RID: 3
		internal static readonly string CLASS_NAME;

		// Token: 0x04000004 RID: 4
		private uint errorID;

		// Token: 0x04000005 RID: 5
		private string message;

		// Token: 0x04000006 RID: 6
		private string stackTrace;

		// Token: 0x04000007 RID: 7
		private string source;

		// Token: 0x04000008 RID: 8
		private string serialNo;

		// Token: 0x04000009 RID: 9
		private uint pBarUpdates;

		// Token: 0x0400000A RID: 10
		private global::System.Collections.ArrayList alExceptions;

		// Token: 0x0400000B RID: 11
		private static global::custom_exception.a Log;

		// Token: 0x0400000C RID: 12
		private uint listID;

		// Token: 0x0400000D RID: 13
		private string blockToSelect;

		// Token: 0x0400000E RID: 14
		private string replaceMessage;

		// Token: 0x0400000F RID: 15
		private bool isReplaceMessageResource = true;

		// Token: 0x04000010 RID: 16
		public global::custom_exception.ErrorInfo ErrorInformance = new global::custom_exception.ErrorInfo();

		// Token: 0x02000004 RID: 4
		public enum HRESULT
		{
			// Token: 0x04000012 RID: 18
			S_OK,
			// Token: 0x04000013 RID: 19
			S_FALSE,
			// Token: 0x04000014 RID: 20
			LOCKFAILURE = 593,
			// Token: 0x04000015 RID: 21
			READFAILURE,
			// Token: 0x04000016 RID: 22
			CONNECTFAILURE,
			// Token: 0x04000017 RID: 23
			CLOSEFAILURE,
			// Token: 0x04000018 RID: 24
			SENDFAILURE,
			// Token: 0x04000019 RID: 25
			OSCOMMFAILURE,
			// Token: 0x0400001A RID: 26
			CCC_TIMEOUT,
			// Token: 0x0400001B RID: 27
			DEVICENOTPRESENT,
			// Token: 0x0400001C RID: 28
			OUTOFMEMORY,
			// Token: 0x0400001D RID: 29
			NONETWORKADAPTERS,
			// Token: 0x0400001E RID: 30
			ADAPTERBUFFEROVERFLOW,
			// Token: 0x0400001F RID: 31
			INVALIDADAPTERPARAMETER,
			// Token: 0x04000020 RID: 32
			ADAPTERNOTSUPPORTED,
			// Token: 0x04000021 RID: 33
			PROTOCOLNOTPRESENT,
			// Token: 0x04000022 RID: 34
			INVALIDARGUMENT,
			// Token: 0x04000023 RID: 35
			PORTINUSE,
			// Token: 0x04000024 RID: 36
			ADDPROTOCOLFAILURE,
			// Token: 0x04000025 RID: 37
			GENERICFAILURE,
			// Token: 0x04000026 RID: 38
			SOCKETINVALID,
			// Token: 0x04000027 RID: 39
			UNKNOWNIPHELPERERROR,
			// Token: 0x04000028 RID: 40
			NODATA,
			// Token: 0x04000029 RID: 41
			COPYNOTALLOWED,
			// Token: 0x0400002A RID: 42
			ASSINGNOTALLOWED,
			// Token: 0x0400002B RID: 43
			METHODNOTIMPLEMENT,
			// Token: 0x0400002C RID: 44
			SOCKETISCLOSED,
			// Token: 0x0400002D RID: 45
			SSLWRITEFAILURE,
			// Token: 0x0400002E RID: 46
			SSLREADFAILURE,
			// Token: 0x0400002F RID: 47
			BIOWRITEFAILURE,
			// Token: 0x04000030 RID: 48
			BIOREADFAILURE,
			// Token: 0x04000031 RID: 49
			SSLINITERROR,
			// Token: 0x04000032 RID: 50
			SSLSETUPERROR,
			// Token: 0x04000033 RID: 51
			SSLHANDSHAKEERROR,
			// Token: 0x04000034 RID: 52
			XCMP_ERROR_RESULT_FAILURE = 657,
			// Token: 0x04000035 RID: 53
			XCMP_ERROR_RESULT_INCORRECT_MODE,
			// Token: 0x04000036 RID: 54
			XCMP_ERROR_RESULT_UNPACK_REPLY_FAILURE,
			// Token: 0x04000037 RID: 55
			XCMP_ERROR_RESULT_OPCODE_NOT_SUPPORTED,
			// Token: 0x04000038 RID: 56
			XCMP_ERROR_RESULT_INVALID_PARAMETER,
			// Token: 0x04000039 RID: 57
			XCMP_ERROR_RESULT_SECURITY_LOCKED,
			// Token: 0x0400003A RID: 58
			XCMP_ERROR_RESULT_SOFTPOT_OPERATION_NOT_SUPPORTED,
			// Token: 0x0400003B RID: 59
			XCMP_ERROR_RESULT_SOFTPOT_TYPE_NOT_SUPPORTED,
			// Token: 0x0400003C RID: 60
			XCMP_ERROR_RESULT_SOFTPOT_VALUE_OUT_OF_RANGE,
			// Token: 0x0400003D RID: 61
			XCMP_ERROR_RESULT_FLASH_WRITE_FAILURE,
			// Token: 0x0400003E RID: 62
			XCMP_ERROR_RESULT_ISH_ITEM_NOT_FOUND,
			// Token: 0x0400003F RID: 63
			XCMP_ERROR_RESULT_ISH_OFFSET_OUT_OF_RANGE,
			// Token: 0x04000040 RID: 64
			XCMP_ERROR_RESULT_ISH_INSUFFICIENT_PARTITION_SPACE,
			// Token: 0x04000041 RID: 65
			XCMP_ERROR_RESULT_ISH_PARTITION_DOES_NOT_EXIST,
			// Token: 0x04000042 RID: 66
			XCMP_ERROR_RESULT_ISH_PARTITION_READ_ONLY,
			// Token: 0x04000043 RID: 67
			XCMP_ERROR_RESULT_ISH_REORG_NEEDED,
			// Token: 0x04000044 RID: 68
			XCMP_ERROR_RESULT_BUFFER_SIZE_NOT_ENOUGH,
			// Token: 0x04000045 RID: 69
			XCMP_ERROR_RESULT_REPLY_TOO_BIG,
			// Token: 0x04000046 RID: 70
			XCMP_GENERICFAILURE,
			// Token: 0x04000047 RID: 71
			XCMP_OUTOFMEMORY,
			// Token: 0x04000048 RID: 72
			XCMP_UNPACK_FAILURE,
			// Token: 0x04000049 RID: 73
			XCMP_NO_DATA_TO_SEND,
			// Token: 0x0400004A RID: 74
			XCMP_MIX_BUNDLE_SINGLE,
			// Token: 0x0400004B RID: 75
			XCMP_BUNDLE_SIZE_NOT_ENOUGH,
			// Token: 0x0400004C RID: 76
			RAI_NOT_INITIALIZED = 689,
			// Token: 0x0400004D RID: 77
			RAI_ALREADY_INITIALIZED,
			// Token: 0x0400004E RID: 78
			RAI_CLOSE_NOT_REQUIRED,
			// Token: 0x0400004F RID: 79
			RAI_INVALID_PDU_LENGTH,
			// Token: 0x04000050 RID: 80
			RAI_UNABLE_TO_SWITCH_MODE,
			// Token: 0x04000051 RID: 81
			RAI_GENERICFAILURE,
			// Token: 0x04000052 RID: 82
			RAI_OUTOFMEMORY,
			// Token: 0x04000053 RID: 83
			RCI_NOT_INITIALIZED = 737,
			// Token: 0x04000054 RID: 84
			RCI_ALREADY_INITIALIZED,
			// Token: 0x04000055 RID: 85
			RCI_READ_ISH_TYPE_SET_FAILED,
			// Token: 0x04000056 RID: 86
			RCI_READ_ISH_ID_SET_FAILED,
			// Token: 0x04000057 RID: 87
			RCI_READ_ISH_ITEM_FAILED,
			// Token: 0x04000058 RID: 88
			RCI_CLOSE_NOT_REQUIRED,
			// Token: 0x04000059 RID: 89
			RCI_GENERICFAILURE,
			// Token: 0x0400005A RID: 90
			RCI_OUTOFMEMORY,
			// Token: 0x0400005B RID: 91
			RCI_TRANSFER_DATA_FAILURE,
			// Token: 0x0400005C RID: 92
			XNL_CLOSE_NOT_REQUIRED = 785,
			// Token: 0x0400005D RID: 93
			XNL_NOT_INITIALIZED,
			// Token: 0x0400005E RID: 94
			XNL_MUTEX_FAILURE,
			// Token: 0x0400005F RID: 95
			XNL_OS_FAILURE,
			// Token: 0x04000060 RID: 96
			XNL_SEND_MESSAGE_FAILURE,
			// Token: 0x04000061 RID: 97
			XNL_RECV_MESSAGE_FAILURE,
			// Token: 0x04000062 RID: 98
			XNL_INVALID_DATA,
			// Token: 0x04000063 RID: 99
			XNL_CONNECT_FAILURE,
			// Token: 0x04000064 RID: 100
			XNL_ALREADY_CONNECTED,
			// Token: 0x04000065 RID: 101
			XNL_NOT_DUAL_BOARD,
			// Token: 0x04000066 RID: 102
			XNL_INVALID_ARGUMENT,
			// Token: 0x04000067 RID: 103
			XNL_GENERICFAILURE,
			// Token: 0x04000068 RID: 104
			XNL_OUTOFMEMORY,
			// Token: 0x04000069 RID: 105
			XNL_RADIO_TYPE_MISMATCH,
			// Token: 0x0400006A RID: 106
			XNL_COPYNOTALLOWED,
			// Token: 0x0400006B RID: 107
			XNL_ASSINGNOTALLOWED,
			// Token: 0x0400006C RID: 108
			XNL_CONNECTION_ABORT,
			// Token: 0x0400006D RID: 109
			RTI_NOT_INITIALIZED = 833,
			// Token: 0x0400006E RID: 110
			RTI_ALREADY_INITIALIZED,
			// Token: 0x0400006F RID: 111
			RTI_CLOSE_NOT_REQUIRED,
			// Token: 0x04000070 RID: 112
			RTI_NO_SYNC_DETECTED,
			// Token: 0x04000071 RID: 113
			RTI_INVALID_PRODUCT,
			// Token: 0x04000072 RID: 114
			RTI_INVALID_SOFTPOT,
			// Token: 0x04000073 RID: 115
			RTI_INVALID_TESTPATTERN,
			// Token: 0x04000074 RID: 116
			RTI_P1LP_INVALIDARG,
			// Token: 0x04000075 RID: 117
			RTI_GENERICFAILURE,
			// Token: 0x04000076 RID: 118
			RTI_OUTOFMEMORY,
			// Token: 0x04000077 RID: 119
			RTI_P2LP_INVALIDARG,
			// Token: 0x04000078 RID: 120
			RTI_INVALID_FREQ,
			// Token: 0x04000079 RID: 121
			RTI_INVALID_BIAS1,
			// Token: 0x0400007A RID: 122
			RTI_REPEATER_LOCKED_OR_DISABLED,
			// Token: 0x0400007B RID: 123
			INVALID_PRODUCT = 1025,
			// Token: 0x0400007C RID: 124
			INVALID_MODELNUM,
			// Token: 0x0400007D RID: 125
			INVALID_CPVER,
			// Token: 0x0400007E RID: 126
			SERIALNUM_NOTMATCH,
			// Token: 0x0400007F RID: 127
			SERIALNUM_MATCH,
			// Token: 0x04000080 RID: 128
			MODEL_NOTMATCH,
			// Token: 0x04000081 RID: 129
			INVALID_PASSWORD,
			// Token: 0x04000082 RID: 130
			INVALID_TAGNAME,
			// Token: 0x04000083 RID: 131
			NOTHISATTRIBUTE,
			// Token: 0x04000084 RID: 132
			NOTFOUNDINTYPEXML,
			// Token: 0x04000085 RID: 133
			WRONGINTYPEXML,
			// Token: 0x04000086 RID: 134
			NOTFOUNDINPACKXML,
			// Token: 0x04000087 RID: 135
			WRONGINPACKXML,
			// Token: 0x04000088 RID: 136
			LOADRANGEVALIDXMLERROR,
			// Token: 0x04000089 RID: 137
			RANGEVALIDXMLFORMATERROR,
			// Token: 0x0400008A RID: 138
			LOADVALIDAVAILXMLERROR,
			// Token: 0x0400008B RID: 139
			AVAILXMLFORMATERROR,
			// Token: 0x0400008C RID: 140
			NULLDATA,
			// Token: 0x0400008D RID: 141
			WRONGTYPENAME,
			// Token: 0x0400008E RID: 142
			LACKLISTLETID,
			// Token: 0x0400008F RID: 143
			WRONGCODEPLUG,
			// Token: 0x04000090 RID: 144
			WRONGDEVICEDATA,
			// Token: 0x04000091 RID: 145
			EXCEPTIONINDEVICEINFO,
			// Token: 0x04000092 RID: 146
			CORRUPTCPFILE,
			// Token: 0x04000093 RID: 147
			NOAVAIABLE_FIELD,
			// Token: 0x04000094 RID: 148
			NO_SPACE_TO_ADD,
			// Token: 0x04000095 RID: 149
			NO_MORE_ITEMS_TO_BE_DELETED,
			// Token: 0x04000096 RID: 150
			UNKOWN_ISH_TYPE,
			// Token: 0x04000097 RID: 151
			GENERAL_EXCEPTION,
			// Token: 0x04000098 RID: 152
			INVALID_ISH_TYPE,
			// Token: 0x04000099 RID: 153
			WRONG_RETURN_VALUE_FROM_FLD,
			// Token: 0x0400009A RID: 154
			UNEXPECTED_CONV_STR,
			// Token: 0x0400009B RID: 155
			INVALID_REGIONID,
			// Token: 0x0400009C RID: 156
			UNDEFINEDCOMBINETYPE,
			// Token: 0x0400009D RID: 157
			PRODUCTNAMENOTFOUND,
			// Token: 0x0400009E RID: 158
			NODENOTFOUND,
			// Token: 0x0400009F RID: 159
			INVALIDATTRIBUTENAME,
			// Token: 0x040000A0 RID: 160
			INVALIDGUICHOICE,
			// Token: 0x040000A1 RID: 161
			INVALIDFIELDID,
			// Token: 0x040000A2 RID: 162
			INVALIDFIELDVALUE,
			// Token: 0x040000A3 RID: 163
			UNDEFINEDRANGETYPE,
			// Token: 0x040000A4 RID: 164
			INVALIDRANGEFIXED,
			// Token: 0x040000A5 RID: 165
			DEFAULTNOTFOUND,
			// Token: 0x040000A6 RID: 166
			TAGNAMENOTFOUND,
			// Token: 0x040000A7 RID: 167
			RANGENOTDEFINED,
			// Token: 0x040000A8 RID: 168
			RANGETAGMISSING,
			// Token: 0x040000A9 RID: 169
			OFFSETLENGTHNOTDEFINED,
			// Token: 0x040000AA RID: 170
			XMLFILENOTFOUND,
			// Token: 0x040000AB RID: 171
			HEXOUTOFRANGE,
			// Token: 0x040000AC RID: 172
			INVALIDLISTID,
			// Token: 0x040000AD RID: 173
			INVALIDPARAMETER,
			// Token: 0x040000AE RID: 174
			INVALIDLISTLETID,
			// Token: 0x040000AF RID: 175
			INVALIDLISTLETLNK,
			// Token: 0x040000B0 RID: 176
			LASTLISTLETNOTFOUND,
			// Token: 0x040000B1 RID: 177
			INVALIDISHID,
			// Token: 0x040000B2 RID: 178
			INVALIDTYPE,
			// Token: 0x040000B3 RID: 179
			INSUFFICIENTISHID,
			// Token: 0x040000B4 RID: 180
			LISTIDMISSING,
			// Token: 0x040000B5 RID: 181
			LISTLETIDMISSING,
			// Token: 0x040000B6 RID: 182
			INVALIDRANGE,
			// Token: 0x040000B7 RID: 183
			WRONGARRAYLISTFORMAT,
			// Token: 0x040000B8 RID: 184
			DEPENDENCYFAILED,
			// Token: 0x040000B9 RID: 185
			ATTRDPDFAILED,
			// Token: 0x040000BA RID: 186
			VALUEDPDFAILED,
			// Token: 0x040000BB RID: 187
			VALUEOUTOFRANGE,
			// Token: 0x040000BC RID: 188
			DELETE_ITEM_FAILED,
			// Token: 0x040000BD RID: 189
			NEW_OPR_FAILED,
			// Token: 0x040000BE RID: 190
			INVALID_XML_CONTENT,
			// Token: 0x040000BF RID: 191
			INVALIDMERGEXMLFORMAT,
			// Token: 0x040000C0 RID: 192
			NOTINHASHTABLE,
			// Token: 0x040000C1 RID: 193
			DATATABLENOTEXIST,
			// Token: 0x040000C2 RID: 194
			DATATABLEEXISTS,
			// Token: 0x040000C3 RID: 195
			INVALID_BLK_SIZE,
			// Token: 0x040000C4 RID: 196
			INVALID_HEX_STRING,
			// Token: 0x040000C5 RID: 197
			FILE_NOT_FOUND,
			// Token: 0x040000C6 RID: 198
			SYS_UNKNOWN_ERROR,
			// Token: 0x040000C7 RID: 199
			INVALID_DISLIST_XML,
			// Token: 0x040000C8 RID: 200
			INVALID_DATA_CONVERT,
			// Token: 0x040000C9 RID: 201
			CREATE_XML_ELEMENT_FAILED,
			// Token: 0x040000CA RID: 202
			INVALID_ARRAY_LENGTH,
			// Token: 0x040000CB RID: 203
			INVALID_COMBINED_ISH,
			// Token: 0x040000CC RID: 204
			INVALID_GUI_DATA,
			// Token: 0x040000CD RID: 205
			INVALID_OCTAL_NUMBER,
			// Token: 0x040000CE RID: 206
			NULL_STRING,
			// Token: 0x040000CF RID: 207
			ALIAS_FIELD_MISSED,
			// Token: 0x040000D0 RID: 208
			INVALID_PASTE_TARGET_POS,
			// Token: 0x040000D1 RID: 209
			INVALID_XML_FORMAT,
			// Token: 0x040000D2 RID: 210
			INVALID_LANGUAGE_FILE,
			// Token: 0x040000D3 RID: 211
			TRY_TO_DEL_ALL_LANG_PKG,
			// Token: 0x040000D4 RID: 212
			INVALID_RADIO_LANGUAGE_INFO,
			// Token: 0x040000D5 RID: 213
			INEXISTENT_FILE,
			// Token: 0x040000D6 RID: 214
			NO_PERMISSION,
			// Token: 0x040000D7 RID: 215
			READ_FILE_FAILED,
			// Token: 0x040000D8 RID: 216
			WRITE_FILE_FAILED,
			// Token: 0x040000D9 RID: 217
			READONLY_FILE,
			// Token: 0x040000DA RID: 218
			OCCUPIED_BY_OTHERS,
			// Token: 0x040000DB RID: 219
			INSUFFICIENT_DISK_OR_WRITE_PROTECT,
			// Token: 0x040000DC RID: 220
			WRITE_DEVICE_FAILED,
			// Token: 0x040000DD RID: 221
			CLONE_DEVICE_FAILED,
			// Token: 0x040000DE RID: 222
			READ_DEVICE_FAILED,
			// Token: 0x040000DF RID: 223
			ADD_ITEM_FAILED,
			// Token: 0x040000E0 RID: 224
			RETRIEVE_ITEM_FAILED,
			// Token: 0x040000E1 RID: 225
			MODIFY_ITEM_FAILED,
			// Token: 0x040000E2 RID: 226
			GET_DOC_FAILED,
			// Token: 0x040000E3 RID: 227
			PASSWORD_CHECK_FAILED,
			// Token: 0x040000E4 RID: 228
			RETRIEVE_RANGE_FAILED,
			// Token: 0x040000E5 RID: 229
			GET_AVAIL_FAILED,
			// Token: 0x040000E6 RID: 230
			MOVE_FAILED,
			// Token: 0x040000E7 RID: 231
			PASTE_FAILED,
			// Token: 0x040000E8 RID: 232
			GET_PRODNAME_FAILED,
			// Token: 0x040000E9 RID: 233
			GET_UPDATEINFO_FAILED,
			// Token: 0x040000EA RID: 234
			CMP_SERIALNUM_FAILED,
			// Token: 0x040000EB RID: 235
			CMP_MODELNUM_FAILED,
			// Token: 0x040000EC RID: 236
			GET_LANGPACK_FAILED,
			// Token: 0x040000ED RID: 237
			READ_LANGPACK_FAILED,
			// Token: 0x040000EE RID: 238
			WRITE_LANGPACK_FAILED,
			// Token: 0x040000EF RID: 239
			DEL_LANGPACK_FAILED,
			// Token: 0x040000F0 RID: 240
			CHK_LANGPACK_ADD_FAILED,
			// Token: 0x040000F1 RID: 241
			NO_SPACE_TO_ADD_CHANNEL,
			// Token: 0x040000F2 RID: 242
			NO_SPACE_TO_ADD_CHANNEL_IN_FOLDER,
			// Token: 0x040000F3 RID: 243
			LOADMODELINFOXMLERROR,
			// Token: 0x040000F4 RID: 244
			GET_IMAGEREF_FAILED,
			// Token: 0x040000F5 RID: 245
			IMAGENOTFOUND,
			// Token: 0x040000F6 RID: 246
			WRONG_ISH_TYPESET_DATA,
			// Token: 0x040000F7 RID: 247
			DECRYPTFILEFAILED,
			// Token: 0x040000F8 RID: 248
			ENCRYPTFILEFAILED,
			// Token: 0x040000F9 RID: 249
			INVALID_PARAMETER,
			// Token: 0x040000FA RID: 250
			BADFIELDVALUE,
			// Token: 0x040000FB RID: 251
			LOW_BATTERY,
			// Token: 0x040000FC RID: 252
			LANGPACK_NOT_SUPPORTED,
			// Token: 0x040000FD RID: 253
			INVALID_ARGUMENT,
			// Token: 0x040000FE RID: 254
			UNDO_FAILED,
			// Token: 0x040000FF RID: 255
			INVALID_UNDO_LVLS,
			// Token: 0x04000100 RID: 256
			INVALID_REDO_LVLS,
			// Token: 0x04000101 RID: 257
			REDO_FAILED,
			// Token: 0x04000102 RID: 258
			UNMATCHEDSERIALNUM_FORLANGUAGEPACK,
			// Token: 0x04000103 RID: 259
			AUTO_RESET_FAILURE,
			// Token: 0x04000104 RID: 260
			BLANKBOARD_SERIALNUM,
			// Token: 0x04000105 RID: 261
			INVALID_PREDEFINED_VERSION,
			// Token: 0x04000106 RID: 262
			INVALID_PSDT_VERS_FORMAT,
			// Token: 0x04000107 RID: 263
			ENDUPDATES_FAILED,
			// Token: 0x04000108 RID: 264
			GETMEMPERCENT_FAILED,
			// Token: 0x04000109 RID: 265
			NO_MEMORY_TO_ADD,
			// Token: 0x0400010A RID: 266
			INSUFFICIENT_CP_MEMORY,
			// Token: 0x0400010B RID: 267
			NO_SPACE_TO_ADD_ALLCALL,
			// Token: 0x0400010C RID: 268
			CREATE_MULTISITEARCHIVE_FAILED,
			// Token: 0x0400010D RID: 269
			INVALID_MULTISITEARCHIVE,
			// Token: 0x0400010E RID: 270
			RADIOID_MUSTBEUNIQUE,
			// Token: 0x0400010F RID: 271
			WRITEOPERATION_IS_INVALID,
			// Token: 0x04000110 RID: 272
			INVALID_MODELTYPE,
			// Token: 0x04000111 RID: 273
			MULTISITEARCHIVE_OPENFILEERROR,
			// Token: 0x04000112 RID: 274
			MULTISITESYS_INVALIDCPVERSION,
			// Token: 0x04000113 RID: 275
			NO_DUPLICATE_ID,
			// Token: 0x04000114 RID: 276
			INVALID_ENHPRVCY_KEYVALUE,
			// Token: 0x04000115 RID: 277
			NO_SPACE_TO_ADD_CAPPLUS_CHNNL,
			// Token: 0x04000116 RID: 278
			SEARCH_VALUES_FAILED,
			// Token: 0x04000117 RID: 279
			FILE_SUCCESSFULL,
			// Token: 0x04000118 RID: 280
			INVALID_NETWORK,
			// Token: 0x04000119 RID: 281
			ACCESSORYIP_CONFLICT,
			// Token: 0x0400011A RID: 282
			CANNOT_DELETE_ALL_CHANNELS,
			// Token: 0x0400011B RID: 283
			INVALID_PERSONALITY_TYPE,
			// Token: 0x0400011C RID: 284
			INVALID_FEATURE_GRP,
			// Token: 0x0400011D RID: 285
			INVALID_FEATURE_GRP_DEFINITION,
			// Token: 0x0400011E RID: 286
			UNMATCH_SERIALNUM_FEATURE_ENDISABLE,
			// Token: 0x0400011F RID: 287
			ENABLEFEATURE_FREEFEATURE,
			// Token: 0x04000120 RID: 288
			DISABLEFEATURE_FREEFEATURE,
			// Token: 0x04000121 RID: 289
			ENABLEFEATURE_INVALIDREGION,
			// Token: 0x04000122 RID: 290
			ENABLEFEATURE_INVALIDMODEL,
			// Token: 0x04000123 RID: 291
			ENABLEFEATURE_INVALIDVERSION,
			// Token: 0x04000124 RID: 292
			DISABLEFEATURE_INVALIDREGION,
			// Token: 0x04000125 RID: 293
			DISABLEFEATURE_INVALIDMODEL,
			// Token: 0x04000126 RID: 294
			DISABLEFEATURE_INVALIDVERSION,
			// Token: 0x04000127 RID: 295
			ENABLEFEATURE_ENABLEDFEATURE,
			// Token: 0x04000128 RID: 296
			DISABLEFEATURE_SOMEFEATURES_DISBLED,
			// Token: 0x04000129 RID: 297
			FEATURE_ALREADY_DISABLED,
			// Token: 0x0400012A RID: 298
			ENABLEFEATURE_DEPENDENCY_ERROR,
			// Token: 0x0400012B RID: 299
			ENABLEFEATURE_FEATDESC_DPD_ERROR,
			// Token: 0x0400012C RID: 300
			DISABLEFEATURE_DEPENDENCY_ERROR,
			// Token: 0x0400012D RID: 301
			DISABLEFEATURE_FEATDESC_DPD_ERROR,
			// Token: 0x0400012E RID: 302
			CFS_FEATDESC_DPDNCY_ERROR,
			// Token: 0x0400012F RID: 303
			CFSFEATURES_DISABLED_IN_RADIO,
			// Token: 0x04000130 RID: 304
			GET_REGION_FAILED,
			// Token: 0x04000131 RID: 305
			ENABLEFEATURE_VALIDATEAVAIL_FAILED,
			// Token: 0x04000132 RID: 306
			DISABLEFEATURE_VALIDATEAVAIL_FAILED,
			// Token: 0x04000133 RID: 307
			INVALID_MODEL,
			// Token: 0x04000134 RID: 308
			SERIAL_NUMBERS_RXTXBOARD_NOTMATCH,
			// Token: 0x04000135 RID: 309
			CFS_NOTSUPPORTED_IN_VERSION,
			// Token: 0x04000136 RID: 310
			MODEL_NOTSUPPORTED_IN_FEATGRP,
			// Token: 0x04000137 RID: 311
			ITEMTYPE_NOTAPPLICABLE,
			// Token: 0x04000138 RID: 312
			VALUE_NOT_SUPPORTED_BY_CFS,
			// Token: 0x04000139 RID: 313
			ADD_SYSTEM_KEY_PROTECTED_ITEM_FAILED,
			// Token: 0x0400013A RID: 314
			DEL_SYSTEM_KEY_PROTECTED_ITEM_FAILED,
			// Token: 0x0400013B RID: 315
			CLONE_SYSTEM_KEY_PROTECTED_ITEM_FAILED,
			// Token: 0x0400013C RID: 316
			UNABLE_WRITE_BANDIT_FREQ,
			// Token: 0x0400013D RID: 317
			UNABLE_CLONE_BANDIT_FREQ,
			// Token: 0x0400013E RID: 318
			AUTOCORRECT_ERROR,
			// Token: 0x0400013F RID: 319
			EEPROM_CORRUPT,
			// Token: 0x04000140 RID: 320
			NO_SPACE_TO_ADD_TALKGROUP_SCAN_CNV_PER,
			// Token: 0x04000141 RID: 321
			CANNOT_DELETE_ALL_SCAN_LISTS,
			// Token: 0x04000142 RID: 322
			CFS_APP_FEATURE_DISABLED_NPSPAC_WRITE,
			// Token: 0x04000143 RID: 323
			CFS_APP_FEATURE_DISABLED_NPSPAC_CLONE,
			// Token: 0x04000144 RID: 324
			INVALID_RCI_IOCONTROL_REPLY,
			// Token: 0x04000145 RID: 325
			INVALID_NETWORK_REST_CHANNEL_IP,
			// Token: 0x04000146 RID: 326
			UDP_PORT_MATCHED,
			// Token: 0x04000147 RID: 327
			CHECK_RP_FIELDS_FAILED,
			// Token: 0x04000148 RID: 328
			REST_CHANNEL_IP_ETHERNET_IP_DIFFERENT,
			// Token: 0x04000149 RID: 329
			REST_CHANNEL_IP_ACCESSORY_IP_DIFFERENT,
			// Token: 0x0400014A RID: 330
			FEATGRP_NOTSUPPORTED_BY_PRODUCT,
			// Token: 0x0400014B RID: 331
			CFS_APP_25KHZ_NOT_ACTIVE_WITH_25KHZ_BANDWIDTH,
			// Token: 0x0400014C RID: 332
			CFS_UPGRADE_FROM_NOT_FREE_OR_ENABLED,
			// Token: 0x0400014D RID: 333
			NO_SPACE_TO_ADD_CAPPLUS_CHNNL_LINKED,
			// Token: 0x0400014E RID: 334
			INVALID_RASKEY_KEYVALUE,
			// Token: 0x0400014F RID: 335
			AR_AR_LANG_PACK_NOT_SUPPORTED,
			// Token: 0x04000150 RID: 336
			NO_DUPLICATE_ALIAS,
			// Token: 0x04000151 RID: 337
			INVALID_IP_OCTET,
			// Token: 0x04000152 RID: 338
			WARNING_SAVEAS_TEMPLATE_CLOSING,
			// Token: 0x04000153 RID: 339
			EN_US_LANG_PACK_NOT_SUPPORTED,
			// Token: 0x04000154 RID: 340
			INVALID_ANALOG_CFS_WITH_DIGITAL_FW,
			// Token: 0x04000155 RID: 341
			RADIO_NEED_UPGRADE,
			// Token: 0x04000156 RID: 342
			INVALID_RASKEY_VALUE_READ_FROM_RADIO,
			// Token: 0x04000157 RID: 343
			DIGITAL_SATELLITE_RECEIVER_MUST_BE_PEER,
			// Token: 0x04000158 RID: 344
			NOT_DIGITAL_SATELLITE_RECEIVER,
			// Token: 0x04000159 RID: 345
			FAIL_TO_VALIDATE_PASSWORD,
			// Token: 0x0400015A RID: 346
			INVALID_NORMAL_CHANNLE_COUNT,
			// Token: 0x0400015B RID: 347
			INVALID_NETWORK_PROFILE,
			// Token: 0x0400015C RID: 348
			UNABLE_BACKWARD_TO_LOW_VERSION,
			// Token: 0x0400015D RID: 349
			CHECK_MAC_ADDRESS_FIX_FAILED,
			// Token: 0x0400015E RID: 350
			APPLY_MAC_ADDRESS_FIX_FAILED,
			// Token: 0x0400015F RID: 351
			TTSRULESET_COMPRESSED_TOO_LARGE,
			// Token: 0x04000160 RID: 352
			CHECK_ITEM_NUM_FAILED,
			// Token: 0x04000161 RID: 353
			RADIO_IP_CONFLICTS_WITH_CAI_AND_RADIO_ID,
			// Token: 0x04000162 RID: 354
			TONGA_RADIO_NAME_TOO_LONG,
			// Token: 0x04000163 RID: 355
			OTAR_TEK_ID_HIDDEN_STRING,
			// Token: 0x04000164 RID: 356
			OTAR_UKEK_HIDDEN_STRING_BUT_NOT_TEK,
			// Token: 0x04000165 RID: 357
			OTAR_UKEK_DEFINED_BUT_NOT_TEK,
			// Token: 0x04000166 RID: 358
			CFS_APP_FEATURE_DISABLED_SPAINFREQ_WRITE,
			// Token: 0x04000167 RID: 359
			WIFI_PASSWORD_IS_BLANK_BUT_NETWORK_IS_ENCRYPTED,
			// Token: 0x04000168 RID: 360
			WIFI_IP_CONFLICTS_WITH_RADIO_IP,
			// Token: 0x04000169 RID: 361
			NO_SIGNAL_INJECTED = 1281,
			// Token: 0x0400016A RID: 362
			INVALID_RANGE_FORMAT_SERIALNO,
			// Token: 0x0400016B RID: 363
			SERIALNUM_NOT_MATCH,
			// Token: 0x0400016C RID: 364
			TUNER_BLANKBOARD_SERIALNUM,
			// Token: 0x0400016D RID: 365
			CYPHER_SINGLEBOARD_CONFIGURATION,
			// Token: 0x0400016E RID: 366
			CYPHERBOARDCONFIGURATION_NOT_MATCH,
			// Token: 0x0400016F RID: 367
			RX_BLANKBOARD_SERIALNUM_TX_SERIALNUM_MATCH,
			// Token: 0x04000170 RID: 368
			RX_BLANKBOARD_SERIALNUM_TX_SERIALNUM_NOT_MATCH,
			// Token: 0x04000171 RID: 369
			TX_BLANKBOARD_SERIALNUM_RX_SERIALNUM_MATCH,
			// Token: 0x04000172 RID: 370
			TX_BLANKBOARD_SERIALNUM_RX_SERIALNUM_NOT_MATCH,
			// Token: 0x04000173 RID: 371
			CMP_CYPHERBOARDCONFIGURATION_FAILED,
			// Token: 0x04000174 RID: 372
			VALIDATE_SERIALUM_FAILED,
			// Token: 0x04000175 RID: 373
			NON_ANALOG_PERSONALITY,
			// Token: 0x04000176 RID: 374
			NON_DIGITAL_PERSONALITY,
			// Token: 0x04000177 RID: 375
			TUNER_RX_BLANKBOARD_SERIALNUM,
			// Token: 0x04000178 RID: 376
			TUNER_TX_BLANKBOARD_SERIALNUM,
			// Token: 0x04000179 RID: 377
			INVALID_VCBADC,
			// Token: 0x0400017A RID: 378
			INVALID_TX_POWER,
			// Token: 0x0400017B RID: 379
			INVALID_RX_FEG_RSSI,
			// Token: 0x0400017C RID: 380
			INVALID_BANDIT_PA,
			// Token: 0x0400017D RID: 381
			RESUME_PABIAS_FAILED,
			// Token: 0x0400017E RID: 382
			REPEATOR_IN_LOCKED_OR_DISABLED,
			// Token: 0x0400017F RID: 383
			WIRELINE_BOARD_NOT_AVAILABLE,
			// Token: 0x04000180 RID: 384
			INVALID_RDAC_SLOPE,
			// Token: 0x04000181 RID: 385
			INVALID_DCA,
			// Token: 0x04000182 RID: 386
			INVALID_DCA_SOFTPOT,
			// Token: 0x04000183 RID: 387
			INVALID_DCA_SOFTPOT_LARGE,
			// Token: 0x04000184 RID: 388
			INVALID_DCA_SOFTPOT_MOBILE,
			// Token: 0x04000185 RID: 389
			INVALID_DCA_COMPENSATED_NUMBER,
			// Token: 0x04000186 RID: 390
			INVALID_TX_REFOSC_SOFTPOT,
			// Token: 0x04000187 RID: 391
			REPEATER_INVALID_MODE,
			// Token: 0x04000188 RID: 392
			INVALID_SPUR_FREQUENCY_RANGE,
			// Token: 0x04000189 RID: 393
			INVALID_AES_KEYVALUE,
			// Token: 0x0400018A RID: 394
			INVALID_DCA_SOFTPOT_LARGE_8900,
			// Token: 0x0400018B RID: 395
			INVALID_PWM_SPUR_FREQUENCY_RANGE,
			// Token: 0x0400018C RID: 396
			INVALID_PWM_SPUR_FREQUENCY_RANGE_ZREO,
			// Token: 0x0400018D RID: 397
			INVALID_SERIAL_NUMBER_WRITE,
			// Token: 0x0400018E RID: 398
			INVALID_CALL_TYPE,
			// Token: 0x0400018F RID: 399
			INVALID_DUALSLOT_BER_CONFIGURATION,
			// Token: 0x04000190 RID: 400
			INVALID_DUALSLOT_TXRX_FREQ_DELTA,
			// Token: 0x04000191 RID: 401
			INVALID_DUALSLOT_NONESLOT_CONFIGURATION,
			// Token: 0x04000192 RID: 402
			INVALID_DUALSLOTBER_REQUEST,
			// Token: 0x04000193 RID: 403
			MTR2000_ARCHIIVE_WRITE_PROMPT,
			// Token: 0x04000194 RID: 404
			S_NOT_OPEN = 1361,
			// Token: 0x04000195 RID: 405
			S_INVALID_PARAMETER,
			// Token: 0x04000196 RID: 406
			S_MARSHAL_BUFFER_FAIL,
			// Token: 0x04000197 RID: 407
			S_NOT_FOUND_DB,
			// Token: 0x04000198 RID: 408
			S_NOT_MATRIX_DATABASE,
			// Token: 0x04000199 RID: 409
			S_ALLOC_MEM_FAIL,
			// Token: 0x0400019A RID: 410
			S_NOT_FOUND_EVENTSOURCE,
			// Token: 0x0400019B RID: 411
			S_INEXISTENT_REGISTRY_PATH,
			// Token: 0x0400019C RID: 412
			S_INEXISTENT_REGISTRY_VALUE,
			// Token: 0x0400019D RID: 413
			S_UNCOMPATIBLE_REGISTRY_VALUE,
			// Token: 0x0400019E RID: 414
			S_NOT_FOUND_COMMUNICATION,
			// Token: 0x0400019F RID: 415
			S_NOT_MATRIX_ARCHIVE_FILE,
			// Token: 0x040001A0 RID: 416
			S_CREATE_DATABASE_FAILED,
			// Token: 0x040001A1 RID: 417
			S_CREATE_REGKEY_FAILED,
			// Token: 0x040001A2 RID: 418
			S_VERIFY_CUSTOMER_REGKEY_FAILED,
			// Token: 0x040001A3 RID: 419
			E_ADAPTERP_INVALIDARAMETER,
			// Token: 0x040001A4 RID: 420
			E_ADAPTER_OUTOFMEMORY,
			// Token: 0x040001A5 RID: 421
			IPNOTFOUND,
			// Token: 0x040001A6 RID: 422
			S_EMPTY_FEATURES,
			// Token: 0x040001A7 RID: 423
			S_INVALID_PRODUCT,
			// Token: 0x040001A8 RID: 424
			INVALID_PRODUCT_ARCHIVE,
			// Token: 0x040001A9 RID: 425
			S_NOT_RDAC_DATABASE,
			// Token: 0x040001AA RID: 426
			CPSERV_RETURN_EMPTY_CHOICE = 1617,
			// Token: 0x040001AB RID: 427
			NOT_RETREIVE_DATA,
			// Token: 0x040001AC RID: 428
			NOT_EXTRACT_DATA,
			// Token: 0x040001AD RID: 429
			FAIL_TO_FORMAT,
			// Token: 0x040001AE RID: 430
			FAIL_READ_TREEXML,
			// Token: 0x040001AF RID: 431
			FAIL_CREATE_ARRAYLIST,
			// Token: 0x040001B0 RID: 432
			NOT_GET_VALUE,
			// Token: 0x040001B1 RID: 433
			UNKNOWN_VALUE,
			// Token: 0x040001B2 RID: 434
			FAIL_CONVERT_TO_XMLDOC,
			// Token: 0x040001B3 RID: 435
			FAIL_CREATE_XMLDOC,
			// Token: 0x040001B4 RID: 436
			NOT_FIND_SPECCONTROL,
			// Token: 0x040001B5 RID: 437
			FAIL_GET_TEXT_FROMRES,
			// Token: 0x040001B6 RID: 438
			INVALID_VALUE_TOSELECT,
			// Token: 0x040001B7 RID: 439
			NOT_GET_CLASS_TYPE,
			// Token: 0x040001B8 RID: 440
			FAIL_CREATE_TREENODE,
			// Token: 0x040001B9 RID: 441
			FAIL_ADD_CHILD,
			// Token: 0x040001BA RID: 442
			PANNEL_IS_NULL,
			// Token: 0x040001BB RID: 443
			UNKNOWN_ERROR,
			// Token: 0x040001BC RID: 444
			NOT_CREATE_CHILD_INSTANCE,
			// Token: 0x040001BD RID: 445
			CONTROL_HAVE_NO_FIELDID,
			// Token: 0x040001BE RID: 446
			INVALID_ITEM_SELECTED,
			// Token: 0x040001BF RID: 447
			SERIAL_NUM_NO_MATCH,
			// Token: 0x040001C0 RID: 448
			MODEL_NUM_NO_MATCH,
			// Token: 0x040001C1 RID: 449
			MSG_QUEST_WRITE_DEVICE,
			// Token: 0x040001C2 RID: 450
			MSG_QUEST_CLONE_DEVICE,
			// Token: 0x040001C3 RID: 451
			CAN_NOT_SAVE,
			// Token: 0x040001C4 RID: 452
			CAN_NOT_OPEN_DOC,
			// Token: 0x040001C5 RID: 453
			MSG_QUEST_CLOSE_DOC,
			// Token: 0x040001C6 RID: 454
			UNABLE_CLONE,
			// Token: 0x040001C7 RID: 455
			FAIL_TO_CREATE_INS,
			// Token: 0x040001C8 RID: 456
			RECMNUITEM_NULL,
			// Token: 0x040001C9 RID: 457
			RECMNUITEM_PARENT_NULL,
			// Token: 0x040001CA RID: 458
			FILENAME_NULL,
			// Token: 0x040001CB RID: 459
			FILENAME_LEGH_ZERO,
			// Token: 0x040001CC RID: 460
			NUM_OUTOF_RANGE,
			// Token: 0x040001CD RID: 461
			REGKEYNAME_NULL,
			// Token: 0x040001CE RID: 462
			FAIL_ADD_CP_ITEM,
			// Token: 0x040001CF RID: 463
			FAIL_GET_IMAGE,
			// Token: 0x040001D0 RID: 464
			FAIL_ADD_EXCEED_LIMITAION,
			// Token: 0x040001D1 RID: 465
			FAIL_DELETE_EXCEED_LIMITAION,
			// Token: 0x040001D2 RID: 466
			FAIL_GET_TYPE,
			// Token: 0x040001D3 RID: 467
			FAIL_GET_RANGE,
			// Token: 0x040001D4 RID: 468
			FAIL_GET_TREENODE,
			// Token: 0x040001D5 RID: 469
			DELETE_ITEMS_LV,
			// Token: 0x040001D6 RID: 470
			RESELECT_LIST_ITEM,
			// Token: 0x040001D7 RID: 471
			VALIDATE_PASSWD_FAILED,
			// Token: 0x040001D8 RID: 472
			FAIL_TO_GET_MULTIPLE_NODES,
			// Token: 0x040001D9 RID: 473
			REOPEN_OPENED_MODIFIED_FILE,
			// Token: 0x040001DA RID: 474
			FAIL_POP_LISTVIEW,
			// Token: 0x040001DB RID: 475
			FAIL_MAP_CONTTROL_EVENT,
			// Token: 0x040001DC RID: 476
			FAIL_SELECT_IP_ADDRESS,
			// Token: 0x040001DD RID: 477
			ALIAS_LEN_LIMITATION,
			// Token: 0x040001DE RID: 478
			COMMON_PASTE_TIP,
			// Token: 0x040001DF RID: 479
			WRITE_DEVICE_SUCCESSFULL,
			// Token: 0x040001E0 RID: 480
			CLONE_DEVICE_SUCCESSFULL,
			// Token: 0x040001E1 RID: 481
			LANGUAGE_PACK_FAILED,
			// Token: 0x040001E2 RID: 482
			SRCDES_NOT_MATCH,
			// Token: 0x040001E3 RID: 483
			NOT_ENOUGH_MEMORY,
			// Token: 0x040001E4 RID: 484
			FAIL_TO_CREATE_PROGRESSBAR,
			// Token: 0x040001E5 RID: 485
			LANGUAGE_PACK_TO_RADIO_FAILED,
			// Token: 0x040001E6 RID: 486
			DEL_LANGUAGE_PACK_FROM_RADIO_FAILED,
			// Token: 0x040001E7 RID: 487
			FAIL_LOAD_HELP_XML,
			// Token: 0x040001E8 RID: 488
			FAIL_LOAD_HELP_XSL,
			// Token: 0x040001E9 RID: 489
			FAIL_TRANSFORM,
			// Token: 0x040001EA RID: 490
			INVALID_TRANSFORM_PARAM,
			// Token: 0x040001EB RID: 491
			FAIL_BROWSER_NAVIGATE,
			// Token: 0x040001EC RID: 492
			FAIL_SET_CONTENT,
			// Token: 0x040001ED RID: 493
			HELP_NULL_DATA,
			// Token: 0x040001EE RID: 494
			FAIL_FILE_NOT_FOUND_XML,
			// Token: 0x040001EF RID: 495
			FAIL_FILE_NOT_FOUND_XSL,
			// Token: 0x040001F0 RID: 496
			NO_DEVICE_CONNECTED,
			// Token: 0x040001F1 RID: 497
			FAILED_TOLOAD_AVAILMEME,
			// Token: 0x040001F2 RID: 498
			LOADLANGPACK_SUCCESS,
			// Token: 0x040001F3 RID: 499
			DELETELANGPACK_SUCCESS,
			// Token: 0x040001F4 RID: 500
			UNABLE_TOCLOSE_APP,
			// Token: 0x040001F5 RID: 501
			BROWSER_DOC_NULL,
			// Token: 0x040001F6 RID: 502
			FAIL_TOINIT_MENU,
			// Token: 0x040001F7 RID: 503
			FAIL_TOMAP_MENUEVENT,
			// Token: 0x040001F8 RID: 504
			FAIL_TOCHANGE_VIEW,
			// Token: 0x040001F9 RID: 505
			FAIL_TOSHOWHIDE_HELPPANE,
			// Token: 0x040001FA RID: 506
			FAIL_CREATE_CHILDFRAME,
			// Token: 0x040001FB RID: 507
			FAIL_READ_DEVICE,
			// Token: 0x040001FC RID: 508
			FAIL_TOGET_MENUTAG,
			// Token: 0x040001FD RID: 509
			FAIL_TOCREATE_DIALOG,
			// Token: 0x040001FE RID: 510
			FAIL_TODISPLAY_CONTEXMENU,
			// Token: 0x040001FF RID: 511
			FAIL_TOPOPULATE_TREE,
			// Token: 0x04000200 RID: 512
			FAIL_TORESET_MENU,
			// Token: 0x04000201 RID: 513
			FAIL_TODELETE_FROMTREE,
			// Token: 0x04000202 RID: 514
			FAIL_TOSORT_BYPOS,
			// Token: 0x04000203 RID: 515
			FAIL_TOSORT_BYNAME,
			// Token: 0x04000204 RID: 516
			FAIL_TOSORT_BYTYPE,
			// Token: 0x04000205 RID: 517
			FAIL_COPYTO_CLIPBRD,
			// Token: 0x04000206 RID: 518
			FAIL_PASTEFROM_CLIPBRD,
			// Token: 0x04000207 RID: 519
			FAIL_TORENAME,
			// Token: 0x04000208 RID: 520
			FAIL_TOGET_DEFAULTNAME,
			// Token: 0x04000209 RID: 521
			FAIL_TOINIT_CONFIGVIEW,
			// Token: 0x0400020A RID: 522
			FAIL_TOLOAD_DATA,
			// Token: 0x0400020B RID: 523
			FAIL_TOLOAD_CHOICES,
			// Token: 0x0400020C RID: 524
			FAIL_TOSET_PRIORITY,
			// Token: 0x0400020D RID: 525
			FAIL_TOCOPY_RXTX,
			// Token: 0x0400020E RID: 526
			FAIL_TOSAVE_FIELDVAL,
			// Token: 0x0400020F RID: 527
			FAIL_TOGET_FIELDVAL,
			// Token: 0x04000210 RID: 528
			FAIL_TORESET_FIELDS,
			// Token: 0x04000211 RID: 529
			FAIL_TODEL_FROMLIST,
			// Token: 0x04000212 RID: 530
			FAIL_TOLOAD_FIELDVAL,
			// Token: 0x04000213 RID: 531
			FAIL_FILE_NOTEXISTS,
			// Token: 0x04000214 RID: 532
			FAIL_CLICK_INITIALIZE,
			// Token: 0x04000215 RID: 533
			FAIL_INVFILENAME,
			// Token: 0x04000216 RID: 534
			FAIL_TOGETLANG,
			// Token: 0x04000217 RID: 535
			FAIL_TOGET_LANGCHOICES,
			// Token: 0x04000218 RID: 536
			FAIL_TOSAVE_REGISTRY,
			// Token: 0x04000219 RID: 537
			FAIL_TOLOAD_FROMREGISTRY,
			// Token: 0x0400021A RID: 538
			FAIL_TO_CREATE_REPDLG,
			// Token: 0x0400021B RID: 539
			FAIL_TOMAP_REPDLG,
			// Token: 0x0400021C RID: 540
			FAIL_NO_REPORTLANG,
			// Token: 0x0400021D RID: 541
			FAIL_TO_LOAD_REPORTS,
			// Token: 0x0400021E RID: 542
			FAIL_TO_DISPLAY_REP,
			// Token: 0x0400021F RID: 543
			FAIL_REPORT_INFO_EMPTY,
			// Token: 0x04000220 RID: 544
			FAIL_TO_GET_REPORT_INFO,
			// Token: 0x04000221 RID: 545
			FAIL_REPORT_INFO_INVALID,
			// Token: 0x04000222 RID: 546
			NOT_GET_REPORT_VALUE,
			// Token: 0x04000223 RID: 547
			FAIL_TO_UPDATE_REP_VIEW,
			// Token: 0x04000224 RID: 548
			FAIL_TOLOAD_SOUNDFILE,
			// Token: 0x04000225 RID: 549
			FAIL_TOPLAY_SOUND,
			// Token: 0x04000226 RID: 550
			INVALID_SOUND_TYPE,
			// Token: 0x04000227 RID: 551
			FAIL_TOREDRAW_MENU,
			// Token: 0x04000228 RID: 552
			FAIL_TOSET_MENUSIZE,
			// Token: 0x04000229 RID: 553
			LANGUAGE_CHANGED,
			// Token: 0x0400022A RID: 554
			FAIL_TOUPDATE_PBAR,
			// Token: 0x0400022B RID: 555
			FAIL_WRITE_DEVICE,
			// Token: 0x0400022C RID: 556
			FAIL_CLONE_DEVICE,
			// Token: 0x0400022D RID: 557
			DUPLICATE_ALIAS,
			// Token: 0x0400022E RID: 558
			FAIL_OPENARC_INUSE,
			// Token: 0x0400022F RID: 559
			FAIL_HANDLE_MULTINST,
			// Token: 0x04000230 RID: 560
			FAIL_HANDLE_MULTINST_SERIALIZATION,
			// Token: 0x04000231 RID: 561
			FAIL_FILE_OPENBYDIFPROC,
			// Token: 0x04000232 RID: 562
			FAILED_UPDATE_ALLVIEW,
			// Token: 0x04000233 RID: 563
			FAIL_DECRYPT_FILE,
			// Token: 0x04000234 RID: 564
			CODEPLUG_CORRUPTED_OUTOFRANGE,
			// Token: 0x04000235 RID: 565
			CLONE_MODEL_NUM_NO_MATCH,
			// Token: 0x04000236 RID: 566
			FAIL_SET_INDEX,
			// Token: 0x04000237 RID: 567
			FAIL_TO_DETACH,
			// Token: 0x04000238 RID: 568
			VIEW_DIR_NOT_FOUND,
			// Token: 0x04000239 RID: 569
			VIEW_NAME_ALREADY_EXISTS,
			// Token: 0x0400023A RID: 570
			FAIL_TO_LOAD_CUSTOM_NAME_CONTROLS,
			// Token: 0x0400023B RID: 571
			FAIL_TO_VALIDATE_NAME,
			// Token: 0x0400023C RID: 572
			FAIL_DUPLICATE_NAME,
			// Token: 0x0400023D RID: 573
			FAIL_LOAD_CUSTOM_DIALOG_CONTROLS,
			// Token: 0x0400023E RID: 574
			FAIL_LOAD_CUSTOM_LIST_BOX,
			// Token: 0x0400023F RID: 575
			FAIL_FIND_CUSTOM_FILES,
			// Token: 0x04000240 RID: 576
			FAIL_DELETE_CUSTOM_VIEW,
			// Token: 0x04000241 RID: 577
			FAIL_MODIFY_CUSTOM_VIEW,
			// Token: 0x04000242 RID: 578
			FAIL_ADD_CUSTOM_VIEW,
			// Token: 0x04000243 RID: 579
			RECMNUITEM_VIEW_NULL,
			// Token: 0x04000244 RID: 580
			RECMNUITEM_PARENT_VIEW_NULL,
			// Token: 0x04000245 RID: 581
			FILENAME_VIEW_NULL,
			// Token: 0x04000246 RID: 582
			FILENAME_LEGH_VIEW_ZERO,
			// Token: 0x04000247 RID: 583
			FAIL_TOPOPULATE_VIEW_TREE,
			// Token: 0x04000248 RID: 584
			FAIL_TOLOADCONFIG_VIEW,
			// Token: 0x04000249 RID: 585
			FAIL_TO_ADD_ITEMS,
			// Token: 0x0400024A RID: 586
			FAIL_TO_REMOVE_ITEMS,
			// Token: 0x0400024B RID: 587
			FAIL_TO_REMOVE_DUPLICATES,
			// Token: 0x0400024C RID: 588
			FAIL_TO_ENCRYPT_FILE,
			// Token: 0x0400024D RID: 589
			NULL_DATA,
			// Token: 0x0400024E RID: 590
			FAIL_TO_LOAD_LEFT_VIEW,
			// Token: 0x0400024F RID: 591
			FILE_READ_ONLY,
			// Token: 0x04000250 RID: 592
			FILE_IN_USE,
			// Token: 0x04000251 RID: 593
			INSUFFICIENT_DISK_WRITE_PROTECTED,
			// Token: 0x04000252 RID: 594
			FAIL_TO_WRITE_VIEW,
			// Token: 0x04000253 RID: 595
			FAIL_TO_POPULATE_XMLDOC,
			// Token: 0x04000254 RID: 596
			FAIL_TO_LOAD_VIEW_XML,
			// Token: 0x04000255 RID: 597
			FAIL_TO_DEVICEUPDATE,
			// Token: 0x04000256 RID: 598
			CHARACTER_NOT_ALLOWED,
			// Token: 0x04000257 RID: 599
			VIEWS_DIR_NOT_PRESENT,
			// Token: 0x04000258 RID: 600
			VIEW_CURRENTLY_IN_USE,
			// Token: 0x04000259 RID: 601
			DEVICE_UPDATE_SUCCSESFUL,
			// Token: 0x0400025A RID: 602
			FAILED_COPYRX_NOFIELD,
			// Token: 0x0400025B RID: 603
			MAX_CHARACTER_REACHED,
			// Token: 0x0400025C RID: 604
			FAIL_TO_REOCVERDEVICE,
			// Token: 0x0400025D RID: 605
			DEVICE_UPDATE_NOTNEEDED,
			// Token: 0x0400025E RID: 606
			DEVICE_RECOVER_SUCCSESFUL,
			// Token: 0x0400025F RID: 607
			NO_PACKAGE_AVAILABLE,
			// Token: 0x04000260 RID: 608
			FAIL_OPENCON_3TIMES,
			// Token: 0x04000261 RID: 609
			DEVICE_CORRECTION_NEEDED,
			// Token: 0x04000262 RID: 610
			FAIL_ADD_EXCEED_LIMITAION_ALLSYSCALL,
			// Token: 0x04000263 RID: 611
			FAIL_TO_FINALIZE,
			// Token: 0x04000264 RID: 612
			FAIL_TO_FINALIZE_RETRY3TIMES,
			// Token: 0x04000265 RID: 613
			FAIL_APPLICATION_BUSY,
			// Token: 0x04000266 RID: 614
			RECOVER_DEVICE_WARNING,
			// Token: 0x04000267 RID: 615
			FAIL_CREATE_CONTROL,
			// Token: 0x04000268 RID: 616
			FAIL_DELETE_CONTROL,
			// Token: 0x04000269 RID: 617
			FAIL_SHOW_HELP,
			// Token: 0x0400026A RID: 618
			FAIL_CUT_EXCEED_LIMITAION,
			// Token: 0x0400026B RID: 619
			FAIL_TOFIND_INCURARCH,
			// Token: 0x0400026C RID: 620
			SEARCHCONTENT_EMPTY,
			// Token: 0x0400026D RID: 621
			FAIL_TOSELECT_TREENODE,
			// Token: 0x0400026E RID: 622
			FAIL_INVALID_STRING,
			// Token: 0x0400026F RID: 623
			FAIL_TO_SET_FONT,
			// Token: 0x04000270 RID: 624
			FAIL_INVALID_RANGE,
			// Token: 0x04000271 RID: 625
			FAIL_TO_FIND_CHANNEL,
			// Token: 0x04000272 RID: 626
			GPS_UPDATE_SUCCSESFUL,
			// Token: 0x04000273 RID: 627
			DELETE_ITEMS_LP,
			// Token: 0x04000274 RID: 628
			DELETE_ITEMS_GRID,
			// Token: 0x04000275 RID: 629
			DELETE_ITEMS_CV,
			// Token: 0x04000276 RID: 630
			FAIL_TO_GPSUPDATE,
			// Token: 0x04000277 RID: 631
			FAIL_MULTISITE_ARCHIVE_EXISTVALID,
			// Token: 0x04000278 RID: 632
			MULTISITE_VALUECHANGED,
			// Token: 0x04000279 RID: 633
			MULTISITE_WRITESUCESS,
			// Token: 0x0400027A RID: 634
			FAIL_MULTISITE_ARCHIVE_NOTEXIST,
			// Token: 0x0400027B RID: 635
			FAIL_MULTISITE_ARCHIVE_INVALID,
			// Token: 0x0400027C RID: 636
			FAIL_MULTISITE_OPENFILE,
			// Token: 0x0400027D RID: 637
			NO_DEVICE_CONNECTED_CLONE,
			// Token: 0x0400027E RID: 638
			FAIL_TO_SEARCH_VALUES,
			// Token: 0x0400027F RID: 639
			CAPACITY_PLUS_REPEATER_MODE_MESSAGE,
			// Token: 0x04000280 RID: 640
			INVALID_CHANNEL_TYPE_PASTING,
			// Token: 0x04000281 RID: 641
			MSG_QUEST_CLOSE_DOC_ENCRYPTION_CHANGE,
			// Token: 0x04000282 RID: 642
			MSG_QUEST_SAVE_ENCRYPTION_CHANGE,
			// Token: 0x04000283 RID: 643
			CFS_INVALID_MENU_ITEM,
			// Token: 0x04000284 RID: 644
			SIGNATUREVERIFICATIONFAILED,
			// Token: 0x04000285 RID: 645
			INVALIDPUBLICKEY,
			// Token: 0x04000286 RID: 646
			FAIL_TO_SIGN,
			// Token: 0x04000287 RID: 647
			SIGNATUREALREADYEXISTS,
			// Token: 0x04000288 RID: 648
			COVERAGE_TYPE_CHANGED,
			// Token: 0x04000289 RID: 649
			PASTE_ITEMS_PASSED,
			// Token: 0x0400028A RID: 650
			INVALID_SYSKEY_DIRECTORY,
			// Token: 0x0400028B RID: 651
			FAIL_TO_APPLY_RESTRICTION,
			// Token: 0x0400028C RID: 652
			FAIL_TO_APPLY_RULE,
			// Token: 0x0400028D RID: 653
			FAIL_TO_CHECK_COMMON,
			// Token: 0x0400028E RID: 654
			FAIL_TO_OPEN_FIELDINFO,
			// Token: 0x0400028F RID: 655
			FAIL_TO_APPLY_GUI_DEPENDENCY,
			// Token: 0x04000290 RID: 656
			FAIL_TO_PASTE_CUT_ITEM,
			// Token: 0x04000291 RID: 657
			CONVERT_DEVICE_WARNING,
			// Token: 0x04000292 RID: 658
			DEVICE_CONVERT_SUCCSESFUL,
			// Token: 0x04000293 RID: 659
			SAME_SYSTEM_EXISTS,
			// Token: 0x04000294 RID: 660
			SAME_CPS_PORT_EXISTS,
			// Token: 0x04000295 RID: 661
			FAIL_ADD_SYSTEM,
			// Token: 0x04000296 RID: 662
			FAIL_DEL_SYSTEM,
			// Token: 0x04000297 RID: 663
			MAX_SYSTEM_REACHED,
			// Token: 0x04000298 RID: 664
			INVALID_DB_PARAM,
			// Token: 0x04000299 RID: 665
			FAIL_LOAD_SYSTEM,
			// Token: 0x0400029A RID: 666
			SAME_SYSTEM_NAME,
			// Token: 0x0400029B RID: 667
			FAIL_UPDATE_SYSTEM,
			// Token: 0x0400029C RID: 668
			FAIL_SAVE_SYSTEM,
			// Token: 0x0400029D RID: 669
			REMOTE_CONNECT_TIMEOUT,
			// Token: 0x0400029E RID: 670
			REMOTE_COMMAND_NOT_SUPPORTED,
			// Token: 0x0400029F RID: 671
			REMOTE_SERVICE_NOT_SUPPORTED,
			// Token: 0x040002A0 RID: 672
			REMOTE_OPERATION_BUSY,
			// Token: 0x040002A1 RID: 673
			REMOTE_RECONNECT_TIMEOUT,
			// Token: 0x040002A2 RID: 674
			MSG_QUEST_UPGRADE_FPGA,
			// Token: 0x040002A3 RID: 675
			FPGA_UPGRADE_NOTNEEDED,
			// Token: 0x040002A4 RID: 676
			FPGA_IMAGE_UNCOMPATIBLE,
			// Token: 0x040002A5 RID: 677
			FPGA_INFO_GET_FAILED,
			// Token: 0x040002A6 RID: 678
			MASTER_WRITE_DISCONNECT_QUEST,
			// Token: 0x040002A7 RID: 679
			REMOTE_UPDATE_SUCCESSFUL,
			// Token: 0x040002A8 RID: 680
			FPGA_REVERT_SUCCSESFUL,
			// Token: 0x040002A9 RID: 681
			FPGA_REVERT_WARNING,
			// Token: 0x040002AA RID: 682
			ARCHIVE_NOT_FOR_REMOTE_WRITE,
			// Token: 0x040002AB RID: 683
			ARCHIVE_NO_MATCH_LOCAL_AND_REMOTE_WRITE,
			// Token: 0x040002AC RID: 684
			DISABLE_REMOTE_WRITE,
			// Token: 0x040002AD RID: 685
			LE_FIELDS_CHANGED_REMOTE_WRITE,
			// Token: 0x040002AE RID: 686
			DISABLE_AND_LE_FIELDS_CHANGED_REMOTE_WRITE,
			// Token: 0x040002AF RID: 687
			MANDATORY_LOCAL_UPGRADE,
			// Token: 0x040002B0 RID: 688
			MASTER_UPDATE_DISCONNECT_QUEST,
			// Token: 0x040002B1 RID: 689
			NOT_ENOUGH_MEMORY_FOR_UPDATE,
			// Token: 0x040002B2 RID: 690
			FAIL_DELETE_EXCEED_LIMITAION_ZONECHANNEL,
			// Token: 0x040002B3 RID: 691
			FAIL_CUT_EXCEED_LIMITAION_ZONECHANNEL,
			// Token: 0x040002B4 RID: 692
			FAIL_TOINIT_TOOLBAR,
			// Token: 0x040002B5 RID: 693
			IMAGE_FORMAT_INVALID,
			// Token: 0x040002B6 RID: 694
			WELCOME_IMAGE_INVALID,
			// Token: 0x040002B7 RID: 695
			CFSFEATURES_DISABLED_CONVERT,
			// Token: 0x040002B8 RID: 696
			NO_RPROG_DEVICE_CONNECTED,
			// Token: 0x040002B9 RID: 697
			INVALID_IP_ADDRESS_FORMAT,
			// Token: 0x040002BA RID: 698
			BT_MODE_MESSAGE,
			// Token: 0x040002BB RID: 699
			FAIL_ADD_EXCEED_SERVER_LIMITAION,
			// Token: 0x040002BC RID: 700
			COMMON_PASTE_TO_SERVER_ARCHIVE_WARNING,
			// Token: 0x040002BD RID: 701
			AR_AR_LANG_PACK_NOT_SUPPORTED_ON_TARGET,
			// Token: 0x040002BE RID: 702
			DEVICE_CORRECTION_NEEDED_NO_25KHZ,
			// Token: 0x040002BF RID: 703
			LOAD_DELETE_LP_FAILED_SERIAL_NUM_MISMATCH,
			// Token: 0x040002C0 RID: 704
			WRITE_DEVICE_SUCCESSFUL_NEED_AUTOCORRECT,
			// Token: 0x040002C1 RID: 705
			FAIL_CLONE_DEVICE_NOT_ALL,
			// Token: 0x040002C2 RID: 706
			DOWNGRADE_NOT_SUPPORTED,
			// Token: 0x040002C3 RID: 707
			VOTING_MODE_WARNING_MESSAGE,
			// Token: 0x040002C4 RID: 708
			FAIL_TO_RENAME_INVALID_ALIAS,
			// Token: 0x040002C5 RID: 709
			VALIDATE_PASSWD_FAILED_RADIO_LOCKED,
			// Token: 0x040002C6 RID: 710
			TTS_LANGUAGE_PACK_TO_RADIO_FAILED,
			// Token: 0x040002C7 RID: 711
			DEL_TTS_LANGUAGE_PACK_FROM_RADIO_FAILED,
			// Token: 0x040002C8 RID: 712
			ANDROS_VOTING_MODE_WARNING_MESSAGE,
			// Token: 0x040002C9 RID: 713
			MULTISITE_CLONESUCESS,
			// Token: 0x040002CA RID: 714
			DEVICE_UPGRADE_TIMEOUT,
			// Token: 0x040002CB RID: 715
			RECONNECT_RRP_FAIL,
			// Token: 0x040002CC RID: 716
			RECONNECT_USB_FAIL,
			// Token: 0x040002CD RID: 717
			NO_VA_CAPABLE_DEVICE_CONNECTED = 1921,
			// Token: 0x040002CE RID: 718
			VA_DEVICE_FILE_ALREADY_EXIST,
			// Token: 0x040002CF RID: 719
			VA_FILE_ALREADY_EXISTS,
			// Token: 0x040002D0 RID: 720
			VA_NOT_ENOUGH_SIZE,
			// Token: 0x040002D1 RID: 721
			VA_FILE_CANNOT_WRITE,
			// Token: 0x040002D2 RID: 722
			VA_FILE_NOT_EXIST,
			// Token: 0x040002D3 RID: 723
			COMM_GETSIZE_ERROR,
			// Token: 0x040002D4 RID: 724
			COMM_UPLOAD_ERROR,
			// Token: 0x040002D5 RID: 725
			COMM_DOWNLOAD_ERROR,
			// Token: 0x040002D6 RID: 726
			COMM_LIST_ERROR,
			// Token: 0x040002D7 RID: 727
			COMM_DELETE_ERROR,
			// Token: 0x040002D8 RID: 728
			VA_RADIO_NOT_MATCH,
			// Token: 0x040002D9 RID: 729
			VA_INVALID_XML_CONFIG,
			// Token: 0x040002DA RID: 730
			VA_FOLDER_NOT_EXIST,
			// Token: 0x040002DB RID: 731
			VA_INVALID_FILENAME_FORMAT,
			// Token: 0x040002DC RID: 732
			VA_FILENAME_TOO_LONG,
			// Token: 0x040002DD RID: 733
			VA_SOUND_TOO_LONG,
			// Token: 0x040002DE RID: 734
			VA_CANNOT_ACCESS_FILE,
			// Token: 0x040002DF RID: 735
			VA_INVALID_WAV_FORMAT,
			// Token: 0x040002E0 RID: 736
			VA_INVALID_MVA_FORMAT,
			// Token: 0x040002E1 RID: 737
			VA_UNSUPPORTED_FILE_EXT,
			// Token: 0x040002E2 RID: 738
			VA_FILENAME_DECODE_ERROR,
			// Token: 0x040002E3 RID: 739
			VA_FILENAME_ENCODE_ERROR,
			// Token: 0x040002E4 RID: 740
			VA_OUTOFMEMORY,
			// Token: 0x040002E5 RID: 741
			VA_INFO_TO_ADD_IN_ERROR,
			// Token: 0x040002E6 RID: 742
			VA_OVERRIDE_FILE,
			// Token: 0x040002E7 RID: 743
			FAIL_TODO_INITIALZETUNINGSCR = 2129,
			// Token: 0x040002E8 RID: 744
			MSG_QUEST_CHANGE_SCREEN_PROG_SOFTPOT,
			// Token: 0x040002E9 RID: 745
			MSG_BER_SYNC_TERMINATED,
			// Token: 0x040002EA RID: 746
			FAIL_TOREAD_RSSI,
			// Token: 0x040002EB RID: 747
			FAIL_TO_UPDATE_MODIFIED_VALUES,
			// Token: 0x040002EC RID: 748
			FAIL_TO_TEST_RX_BER,
			// Token: 0x040002ED RID: 749
			FAIL_TO_PERFORM_LQC_START,
			// Token: 0x040002EE RID: 750
			FAIL_TO_PERFORM_RFT_START,
			// Token: 0x040002EF RID: 751
			FAIL_TO_PERFORM_FEG_AUTOTUNE,
			// Token: 0x040002F0 RID: 752
			FAIL_TO_PERFORM_RX_REF_OSC_AUTOWARP,
			// Token: 0x040002F1 RID: 753
			MSG_AUTO_WARP_SUCCESSFULL,
			// Token: 0x040002F2 RID: 754
			MSG_QUEST_CONFIRM_PROG_SERIALNO,
			// Token: 0x040002F3 RID: 755
			MSG_QUEST_CONFIRM_COPY_OTHER_BOARD_SERIALNO,
			// Token: 0x040002F4 RID: 756
			WRITE_DEVICEINFOCONFIG_FAILED,
			// Token: 0x040002F5 RID: 757
			TUNER_XNL_SEND_MESSAGE_FAILURE,
			// Token: 0x040002F6 RID: 758
			TUNER_PROTOCOLNOTPRESENT,
			// Token: 0x040002F7 RID: 759
			MSG_QUEST_CONFIRM_PABIAS_TUNING,
			// Token: 0x040002F8 RID: 760
			MSG_CONFIRM_TUNE_VERIFY_PABIAS,
			// Token: 0x040002F9 RID: 761
			MSG_QUEST_CONFIRM_KNM_TUNING,
			// Token: 0x040002FA RID: 762
			BANDIT_INCORRECT_CODES,
			// Token: 0x040002FB RID: 763
			INVALID_FREQUENCY,
			// Token: 0x040002FC RID: 764
			MSG_QUEST_CONFIRM_RDAC_TUNING,
			// Token: 0x040002FD RID: 765
			MSG_QUEST_CONFIRM_DCA_PROTABLE_TUNING,
			// Token: 0x040002FE RID: 766
			MSG_QUEST_CONFIRM_DCA_MOBILE_TUNING,
			// Token: 0x040002FF RID: 767
			MSG_QUEST_CONFIRM_FEGA_TUNING,
			// Token: 0x04000300 RID: 768
			MSG_QUEST_CONFIRM_PROG_TX_VCBPWRHI_FOR_LINEAR,
			// Token: 0x04000301 RID: 769
			MSG_QUEST_CEC_TESTING,
			// Token: 0x04000302 RID: 770
			FAIL_TO_PERFORM_CEC_TESTING,
			// Token: 0x04000303 RID: 771
			MSG_QUEST_CONFIRM_CEC_TESTING,
			// Token: 0x04000304 RID: 772
			MSG_QUEST_CONFIRM_DCA_F3_RETUNING,
			// Token: 0x04000305 RID: 773
			MSG_QUEST_CONFIRM_MOD_BALANCE_RETUNING,
			// Token: 0x04000306 RID: 774
			FAIL_TO_CREATE_XUL_INSTANCE = 2230,
			// Token: 0x04000307 RID: 775
			FAIL_TO_INITIALIZE_XUL,
			// Token: 0x04000308 RID: 776
			FAIL_TO_LOAD_XML,
			// Token: 0x04000309 RID: 777
			FAIL_TO_LOAD_DOCUMENT,
			// Token: 0x0400030A RID: 778
			FAIL_TO_CREATE_CPANELTEMPLATE,
			// Token: 0x0400030B RID: 779
			FAIL_TO_CREATE_LABEL,
			// Token: 0x0400030C RID: 780
			FAIL_TO_CREATE_BUTTON,
			// Token: 0x0400030D RID: 781
			FAIL_TO_CREATE_GRID,
			// Token: 0x0400030E RID: 782
			FAIL_TO_CREATE_LISTBOX,
			// Token: 0x0400030F RID: 783
			FAIL_TO_CREATE_EDITBOX,
			// Token: 0x04000310 RID: 784
			FAIL_TO_CREATE_SPINEDIT,
			// Token: 0x04000311 RID: 785
			FAIL_TO_CREATE_CHECKBOX,
			// Token: 0x04000312 RID: 786
			FAIL_TO_CREATE_COMBOBOX,
			// Token: 0x04000313 RID: 787
			FAIL_TO_RETRIEVE_DATA_FROM_RESOURCE,
			// Token: 0x04000314 RID: 788
			FAIL_TO_PROCESS_FILE,
			// Token: 0x04000315 RID: 789
			FAIL_TO_PROCESS_CONTROLS,
			// Token: 0x04000316 RID: 790
			FAIL_TO_HANDLE_VBOX,
			// Token: 0x04000317 RID: 791
			FAIL_TO_HANDLE_HBOX,
			// Token: 0x04000318 RID: 792
			FAIL_TO_HANDLE_GRID,
			// Token: 0x04000319 RID: 793
			FAIL_TO_HANDLE_CONTROLS,
			// Token: 0x0400031A RID: 794
			INCORRECT_FILE_FORMAT,
			// Token: 0x0400031B RID: 795
			TAG_NOT_SUPPORTED,
			// Token: 0x0400031C RID: 796
			TYPE_NOT_SUPPORTED,
			// Token: 0x0400031D RID: 797
			CONTROL_NOT_SUPPORTED,
			// Token: 0x0400031E RID: 798
			CANNOT_FIND_FILE,
			// Token: 0x0400031F RID: 799
			TREE_NODE_NOT_FOUND,
			// Token: 0x04000320 RID: 800
			PANEL_NOT_FOUND_FOR_TREE_NODE,
			// Token: 0x04000321 RID: 801
			CANNOT_CREATE_AN_INSTANCE,
			// Token: 0x04000322 RID: 802
			INVALID_DATACONVERT,
			// Token: 0x04000323 RID: 803
			FAIL_TO_CREATE_INSTANCE,
			// Token: 0x04000324 RID: 804
			GRID_CONTROLS_NOT_FOUND,
			// Token: 0x04000325 RID: 805
			FAIL_TO_PROCESS_PANELS,
			// Token: 0x04000326 RID: 806
			FAIL_TO_CREATE_ADDRESS,
			// Token: 0x04000327 RID: 807
			FAIL_TO_CREATE_RXTXSPINEDIT,
			// Token: 0x04000328 RID: 808
			PAINT_PANEL_FAILED,
			// Token: 0x04000329 RID: 809
			FAIL_TO_GET_PROGRAMMABLE_IDS,
			// Token: 0x0400032A RID: 810
			FAIL_TO_GET_GRID_CONTROLS,
			// Token: 0x0400032B RID: 811
			CONTROL_CREATION_FAILED,
			// Token: 0x0400032C RID: 812
			CONTROL_VISIBILITY_FAILED,
			// Token: 0x0400032D RID: 813
			VBOX_CONTROL_LAYOUT_FAILED,
			// Token: 0x0400032E RID: 814
			HBOX_CONTROL_LAYOUT_FAILED,
			// Token: 0x0400032F RID: 815
			RETRIEVE_FROM_CP_FAILED,
			// Token: 0x04000330 RID: 816
			FAILED_TO_GET_IDS,
			// Token: 0x04000331 RID: 817
			FAIL_TO_CREATE_PICTUREBOX,
			// Token: 0x04000332 RID: 818
			NULL_PASSED_IN,
			// Token: 0x04000333 RID: 819
			INCOMPATIBLE_FILE,
			// Token: 0x04000334 RID: 820
			INCOMPATIBLE_VIEW_FILE,
			// Token: 0x04000335 RID: 821
			FAIL_TO_PROCESS_CUSTOM_VIEW,
			// Token: 0x04000336 RID: 822
			FAIL_GET_EXPERT_TREE_VIEW,
			// Token: 0x04000337 RID: 823
			FAIL_TO_GET_CONTROL_IDS,
			// Token: 0x04000338 RID: 824
			FAIL_TO_GET_VIEW_VERSION,
			// Token: 0x04000339 RID: 825
			FAILED_TO_GET_CUSTOM_IDS,
			// Token: 0x0400033A RID: 826
			FAILED_TO_GET_EXPERT_VIEW,
			// Token: 0x0400033B RID: 827
			VIEW_FILE_NOT_FOUND,
			// Token: 0x0400033C RID: 828
			FAIL_TO_CREATE_SLIDERSPINEDIT,
			// Token: 0x0400033D RID: 829
			VALID_NODE_FAILED,
			// Token: 0x0400033E RID: 830
			SYS_KEY_NOT_LOADED,
			// Token: 0x0400033F RID: 831
			FILE_NOT_SELECTED,
			// Token: 0x04000340 RID: 832
			FPGA_UPGRADE_NOT_SUPPORT,
			// Token: 0x04000341 RID: 833
			RECOVER_FPGA_WARNING,
			// Token: 0x04000342 RID: 834
			FAIL_TO_CREATE_CHECKLISTBOX,
			// Token: 0x04000343 RID: 835
			FAIL_TO_CREATE_IMAGEBOX,
			// Token: 0x04000344 RID: 836
			FAIL_TO_CREATE_LINKLABEL,
			// Token: 0x04000345 RID: 837
			FAIL_REPORTS_PATH = 2305,
			// Token: 0x04000346 RID: 838
			FAIL_REPORTS_RESOURCE,
			// Token: 0x04000347 RID: 839
			FAIL_TO_CREATE_REP_INSTANCE,
			// Token: 0x04000348 RID: 840
			FAIL_TO_CREATE_REPVIEW,
			// Token: 0x04000349 RID: 841
			FAIL_TO_LOAD_SOURCE,
			// Token: 0x0400034A RID: 842
			FAIL_TO_INIT_REPORTS,
			// Token: 0x0400034B RID: 843
			FAIL_TO_GET_INFO,
			// Token: 0x0400034C RID: 844
			FAIL_TO_FIND_INFO,
			// Token: 0x0400034D RID: 845
			FAIL_TO_DISPLAY,
			// Token: 0x0400034E RID: 846
			FAIL_TO_GENERATE,
			// Token: 0x0400034F RID: 847
			FAIL_TO_MAP_REPEVNT,
			// Token: 0x04000350 RID: 848
			FAIL_TO_NAVIGATE,
			// Token: 0x04000351 RID: 849
			FAIL_TO_SAVEAS,
			// Token: 0x04000352 RID: 850
			FAIL_TO_WRITE,
			// Token: 0x04000353 RID: 851
			FAIL_TO_WRITE_HTML,
			// Token: 0x04000354 RID: 852
			FAIL_TO_LOAD_IMAGES,
			// Token: 0x04000355 RID: 853
			FAIL_TO_EMAIL,
			// Token: 0x04000356 RID: 854
			FAIL_TO_PRINT,
			// Token: 0x04000357 RID: 855
			FAIL_TO_PREVIEW,
			// Token: 0x04000358 RID: 856
			FAIL_TO_TRANSFORM,
			// Token: 0x04000359 RID: 857
			FAIL_TO_SET_REPORT,
			// Token: 0x0400035A RID: 858
			FAIL_CONTENT_EMPTY,
			// Token: 0x0400035B RID: 859
			FAIL_REPORT_NOTEXIST,
			// Token: 0x0400035C RID: 860
			FAIL_REPORT_UNKNOWN,
			// Token: 0x0400035D RID: 861
			FAIL_VIEW_NOTFOUND,
			// Token: 0x0400035E RID: 862
			FAIL_INFO_INVALID,
			// Token: 0x0400035F RID: 863
			FAIL_XSL_INVALID,
			// Token: 0x04000360 RID: 864
			FAIL_APPEND_DEALER,
			// Token: 0x04000361 RID: 865
			FAIL_HTML_ACCESS,
			// Token: 0x04000362 RID: 866
			FAIL_IMAGE_ACCESS,
			// Token: 0x04000363 RID: 867
			FAIL_IMAGE_NOTEXIST,
			// Token: 0x04000364 RID: 868
			FAIL_MAPI_SEND,
			// Token: 0x04000365 RID: 869
			FAIL_MAPI_ATTACH,
			// Token: 0x04000366 RID: 870
			FAIL_MAPI_RECIP,
			// Token: 0x04000367 RID: 871
			FAIL_MAPI_DEALLOC,
			// Token: 0x04000368 RID: 872
			FAIL_MAPI_FROM,
			// Token: 0x04000369 RID: 873
			FAIL_INVALID_PARAM,
			// Token: 0x0400036A RID: 874
			FAIL_GET_RESOURCE,
			// Token: 0x0400036B RID: 875
			FAIL_INVALID_FLOAT,
			// Token: 0x0400036C RID: 876
			FAIL_TO_CONSTRUCT_SECURE = 2385,
			// Token: 0x0400036D RID: 877
			FAIL_TO_CONSTRUCT_ENCODE,
			// Token: 0x0400036E RID: 878
			FAIL_TO_CONSTRUCT_DECODE,
			// Token: 0x0400036F RID: 879
			NULL_REFERENCE_PASSED,
			// Token: 0x04000370 RID: 880
			FAIL_TO_ENCRYPT,
			// Token: 0x04000371 RID: 881
			FAIL_TO_DECRYPT,
			// Token: 0x04000372 RID: 882
			INCORRECT_BOM_DETECTED,
			// Token: 0x04000373 RID: 883
			FILE_DOES_NOT_EXSIST,
			// Token: 0x04000374 RID: 884
			FAIL_TO_ENCRYPT_COMPRESS,
			// Token: 0x04000375 RID: 885
			FAIL_TO_DECRYPT_DECOMPRESS,
			// Token: 0x04000376 RID: 886
			NOT_CREATE_CONTRL = 2465,
			// Token: 0x04000377 RID: 887
			FAIL_MSGBOX_RESIZE,
			// Token: 0x04000378 RID: 888
			FAIL_TO_CENTER_BUTTONS,
			// Token: 0x04000379 RID: 889
			FAIL_LOAD_STRING_FROM_RESFILE,
			// Token: 0x0400037A RID: 890
			EXCHANGE_COMM_NOT_OPEN = 2505,
			// Token: 0x0400037B RID: 891
			EXCHANGE_COMM_FAILED,
			// Token: 0x0400037C RID: 892
			EXCHANGE_COMM_ERROR,
			// Token: 0x0400037D RID: 893
			EXCHANGE_DS_COMM_ERROR,
			// Token: 0x0400037E RID: 894
			EXCHANGE_INVALID_ARGUMENT,
			// Token: 0x0400037F RID: 895
			EXCHANGE_INVALID_XML_INPUT,
			// Token: 0x04000380 RID: 896
			EXCHANGE_NO_LCNS,
			// Token: 0x04000381 RID: 897
			EXCHANGE_FEATURE_FAILED,
			// Token: 0x04000382 RID: 898
			EXCHANGE_INVALID_FEATURE,
			// Token: 0x04000383 RID: 899
			EXCHANGE_DEVICE_NOT_SUPPORT,
			// Token: 0x04000384 RID: 900
			EXCHANGE_ACKSN_ERROR,
			// Token: 0x04000385 RID: 901
			EXCHANGE_DCACK_ERROR,
			// Token: 0x04000386 RID: 902
			EXCHANGE_FSREQACK_ERROR,
			// Token: 0x04000387 RID: 903
			EXCHANGE_FCACK_ERROR,
			// Token: 0x04000388 RID: 904
			EXCHANGE_LULACK_ERROR,
			// Token: 0x04000389 RID: 905
			EXCHANGE_TOMSG_ERROR,
			// Token: 0x0400038A RID: 906
			EXCHANGE_ACKPRS_ERROR,
			// Token: 0x0400038B RID: 907
			EXCHANGE_ACKDERAND_ERROR,
			// Token: 0x0400038C RID: 908
			EXCHANGE_EN_ERROR,
			// Token: 0x0400038D RID: 909
			EXCHANGE_DE_ERROR,
			// Token: 0x0400038E RID: 910
			EXCHANGE_DUP_MSG,
			// Token: 0x0400038F RID: 911
			FAIL_TOCHANGE_FILECTRLTEXT = 2545,
			// Token: 0x04000390 RID: 912
			FAIL_TOSHOW_FILEOPENDLG,
			// Token: 0x04000391 RID: 913
			FAIL_TOSHOW_FILESAVEDLG,
			// Token: 0x04000392 RID: 914
			FILE_NAME_TOOLONG,
			// Token: 0x04000393 RID: 915
			FAIL_READONLY_FILE,
			// Token: 0x04000394 RID: 916
			OVERWRITE_FAILED,
			// Token: 0x04000395 RID: 917
			FAIL_SPACE_NOTENOUGH,
			// Token: 0x04000396 RID: 918
			FAIL_GET_FREESPACE,
			// Token: 0x04000397 RID: 919
			FAIL_TOLOAD_RESFILE = 2625,
			// Token: 0x04000398 RID: 920
			FAIL_TOLOAD_IMAGERES,
			// Token: 0x04000399 RID: 921
			FILE_DOESNOT_EXIST,
			// Token: 0x0400039A RID: 922
			FAIL_CUSTOM_CONTEXT,
			// Token: 0x0400039B RID: 923
			CUSTOM_CONTEXT_ERROR = 2688,
			// Token: 0x0400039C RID: 924
			UNKNOWN,
			// Token: 0x0400039D RID: 925
			UNHANDLED_EXCEPTION,
			// Token: 0x0400039E RID: 926
			FZI_FZAP_OPEN_PORT_FAILED = 2817,
			// Token: 0x0400039F RID: 927
			FZI_FZAP_ALREADY_OPENED,
			// Token: 0x040003A0 RID: 928
			FZI_FZAP_NOT_OPENED,
			// Token: 0x040003A1 RID: 929
			FZI_FZAP_INIT_FAILED,
			// Token: 0x040003A2 RID: 930
			FZI_FZAP_PORT_ALREADY_CLOSED,
			// Token: 0x040003A3 RID: 931
			FZI_FZAP_CLOSE_PORT_FAILED,
			// Token: 0x040003A4 RID: 932
			FZI_INVALID_BOOTLOAD_FILE,
			// Token: 0x040003A5 RID: 933
			FZI_FZAP_BOOTLOAD_FAILED,
			// Token: 0x040003A6 RID: 934
			FZI_FZAP_UNLOCK_FAILED,
			// Token: 0x040003A7 RID: 935
			FZI_FZAP_ERASE_FAILED,
			// Token: 0x040003A8 RID: 936
			FZI_FZAP_FLASHWITHLOAD_FAILED,
			// Token: 0x040003A9 RID: 937
			FZI_FZAP_INVALID_FLASH_FILE,
			// Token: 0x040003AA RID: 938
			FZI_FZAP_INVALID_FLASH_SRECREP,
			// Token: 0x040003AB RID: 939
			FZI_FZAP_PLATFORM_TYPE_FAILED,
			// Token: 0x040003AC RID: 940
			FZI_FZAP_PREFLASH_FAILED,
			// Token: 0x040003AD RID: 941
			FZI_FZAP_POSTFLASH_FAILED,
			// Token: 0x040003AE RID: 942
			FZI_FZAP_WRITEMEMORY_FAILED,
			// Token: 0x040003AF RID: 943
			FZI_FZAP_READWITHLOAD_FAILED,
			// Token: 0x040003B0 RID: 944
			FZI_FZAP_BOOTCOMMIT_FAILED,
			// Token: 0x040003B1 RID: 945
			FZI_FZAP_BUFFWITHLOAD_FAILED,
			// Token: 0x040003B2 RID: 946
			FZI_FZAP_WRITERAMDLOADER_FAILED,
			// Token: 0x040003B3 RID: 947
			FZI_FZAP_READMEMORY_FAILED,
			// Token: 0x040003B4 RID: 948
			FZI_FZAP_SAVE_FILE_FAILED,
			// Token: 0x040003B5 RID: 949
			FZI_FZAP_RESET_RADIO_FAILED,
			// Token: 0x040003B6 RID: 950
			FZI_FZAP_RAMDLVER_FAILURE,
			// Token: 0x040003B7 RID: 951
			FZI_FZAP_BOOTLOADERVER_FAILURE,
			// Token: 0x040003B8 RID: 952
			FZI_FZAP_IO_CONTROL_FAILED,
			// Token: 0x040003B9 RID: 953
			FZI_FZAP_RECV_BUFF_EMPTY_FAILURE,
			// Token: 0x040003BA RID: 954
			FZI_FZAP_INVALID_SREC_FILE,
			// Token: 0x040003BB RID: 955
			FZI_FZAP_FILE_NOT_EXIST,
			// Token: 0x040003BC RID: 956
			FZI_FZAP_MUTEX_FAILURE,
			// Token: 0x040003BD RID: 957
			FZI_FZAP_OS_FAILURE,
			// Token: 0x040003BE RID: 958
			FZI_NO_REPLY,
			// Token: 0x040003BF RID: 959
			FZI_REMOTECONNECTFAILURE,
			// Token: 0x040003C0 RID: 960
			FZI_REMOTEDISCONNECTFAILURE,
			// Token: 0x040003C1 RID: 961
			FZI_FZAP_REMOTEDUPLICATE_FAILED,
			// Token: 0x040003C2 RID: 962
			FZI_FZAP_PSDT_ACCESS_FAILED,
			// Token: 0x040003C3 RID: 963
			FZI_FZAP_OPCODE_NOT_SUPPORTED,
			// Token: 0x040003C4 RID: 964
			FZI_FZAP_WRITE_FPGAIMAGE_FAILED,
			// Token: 0x040003C5 RID: 965
			FZI_FZAP_RECONFIGURE_FAILED,
			// Token: 0x040003C6 RID: 966
			FZI_FZAP_FILE_ACCESS_FAILED,
			// Token: 0x040003C7 RID: 967
			FZI_FZAP_FTL_ACCESS_FAILED,
			// Token: 0x040003C8 RID: 968
			FZI_FZAP_NAND_ACCESS_FAILED,
			// Token: 0x040003C9 RID: 969
			FZI_FZAP_TRANSFER_DATA_FAILED,
			// Token: 0x040003CA RID: 970
			OUT_OF_MEMORY = 2897,
			// Token: 0x040003CB RID: 971
			FZOPENFAILED,
			// Token: 0x040003CC RID: 972
			FZCLOSEFAILED,
			// Token: 0x040003CD RID: 973
			FZWRITEMEMORYFAILED,
			// Token: 0x040003CE RID: 974
			FZWRITEFILESFAILED,
			// Token: 0x040003CF RID: 975
			FZREADMEMORYFAILED,
			// Token: 0x040003D0 RID: 976
			FZREADPSDTFAILED,
			// Token: 0x040003D1 RID: 977
			FZREADSNFAILED,
			// Token: 0x040003D2 RID: 978
			FZRESETRADIOFAILED,
			// Token: 0x040003D3 RID: 979
			FZENTERREMOTEMODEFAILED,
			// Token: 0x040003D4 RID: 980
			FZEXITREMOTEMODEFAILED,
			// Token: 0x040003D5 RID: 981
			INVALIDINPUT,
			// Token: 0x040003D6 RID: 982
			CPFILEMISSING,
			// Token: 0x040003D7 RID: 983
			RAMDLOADERMISSING,
			// Token: 0x040003D8 RID: 984
			STRUCTFILEMISSING,
			// Token: 0x040003D9 RID: 985
			UPDATECODEPLUGFAILED,
			// Token: 0x040003DA RID: 986
			UPDATEFIRMWAREFAILED,
			// Token: 0x040003DB RID: 987
			GETAVAILPACKAGEFAILED,
			// Token: 0x040003DC RID: 988
			RETRIEVEUPDATEINFOFAILED,
			// Token: 0x040003DD RID: 989
			RECOVERDEVICEFAILED,
			// Token: 0x040003DE RID: 990
			CHECKUPDATEINFOFAILED,
			// Token: 0x040003DF RID: 991
			UPDATEDEVICEFAILED,
			// Token: 0x040003E0 RID: 992
			FWFILEMISSING,
			// Token: 0x040003E1 RID: 993
			PRESERVECODEPLUGFAILED,
			// Token: 0x040003E2 RID: 994
			PUTFILEINTOISHFAILED,
			// Token: 0x040003E3 RID: 995
			PROCESSPSDTSECTIONFAILED,
			// Token: 0x040003E4 RID: 996
			CREATESTRUCTURETREEFAILED,
			// Token: 0x040003E5 RID: 997
			UPDATEBLOCKFAILED,
			// Token: 0x040003E6 RID: 998
			UPDATEFIELDFAILED,
			// Token: 0x040003E7 RID: 999
			WRITEXMLTOISHFAILED,
			// Token: 0x040003E8 RID: 1000
			CVTHEXSTRINGTOBYTEFAILED,
			// Token: 0x040003E9 RID: 1001
			NULL_XML_NODE,
			// Token: 0x040003EA RID: 1002
			UPDATECPSTRUCTFAILED,
			// Token: 0x040003EB RID: 1003
			UPDATEBLOCKSTRUCTFAILED,
			// Token: 0x040003EC RID: 1004
			UPDATEFIELDSTRUCTFAILED,
			// Token: 0x040003ED RID: 1005
			PAK_FILE_CORRUPTED,
			// Token: 0x040003EE RID: 1006
			STRUCT_FILE_CORRUPT,
			// Token: 0x040003EF RID: 1007
			PAKFILECORRUPT,
			// Token: 0x040003F0 RID: 1008
			SRECFILEMISSING,
			// Token: 0x040003F1 RID: 1009
			FZAP_DRIVER_ERROR,
			// Token: 0x040003F2 RID: 1010
			PSDTMISSING,
			// Token: 0x040003F3 RID: 1011
			BOOTLOADERMISSING,
			// Token: 0x040003F4 RID: 1012
			FIELDMOVEMISSING,
			// Token: 0x040003F5 RID: 1013
			UPDATEPSDTFAILED,
			// Token: 0x040003F6 RID: 1014
			UPDATERXCODEPLUGFAILED,
			// Token: 0x040003F7 RID: 1015
			STORECODEPLUGFAILED,
			// Token: 0x040003F8 RID: 1016
			FZBUFFWRITEFILESFAILED,
			// Token: 0x040003F9 RID: 1017
			FZBOOTDUPLICATEFAILED,
			// Token: 0x040003FA RID: 1018
			FZBOOTCOMMITFAILED,
			// Token: 0x040003FB RID: 1019
			FZRAMDOWNLOADFAILED,
			// Token: 0x040003FC RID: 1020
			DUPLICATESERIAL,
			// Token: 0x040003FD RID: 1021
			DIFFERENTSERIAL,
			// Token: 0x040003FE RID: 1022
			UNABLETOREADSERIALNUMBER,
			// Token: 0x040003FF RID: 1023
			UNABLE_TO_UPDATE_DEFAULT,
			// Token: 0x04000400 RID: 1024
			UNABLE_TO_ENABLE_LEG_CFS,
			// Token: 0x04000401 RID: 1025
			SERIAL_NUM_PRESERVATION_FAILED,
			// Token: 0x04000402 RID: 1026
			SERIAL_NUM_UPDATE_FAILED,
			// Token: 0x04000403 RID: 1027
			PRESERVEPARTITIONFAILED,
			// Token: 0x04000404 RID: 1028
			PROCESSPARTITIONFAILED,
			// Token: 0x04000405 RID: 1029
			ADDRESSRETRIEVEFAILED,
			// Token: 0x04000406 RID: 1030
			FPGA_FILE_CORRUPTED,
			// Token: 0x04000407 RID: 1031
			CHECKFPGAINFOFAILED,
			// Token: 0x04000408 RID: 1032
			FZBOOTCOMMITEXFAILED,
			// Token: 0x04000409 RID: 1033
			FZRECONFIGUREFPGAFAILED,
			// Token: 0x0400040A RID: 1034
			UPDATEFPGAFAILED,
			// Token: 0x0400040B RID: 1035
			FAIL_TO_GET_FPGA_INFO,
			// Token: 0x0400040C RID: 1036
			FAILED_TO_READ_MEMORY,
			// Token: 0x0400040D RID: 1037
			FAILED_TO_WRITE_FILE,
			// Token: 0x0400040E RID: 1038
			FAILED_TO_READ_PSDT,
			// Token: 0x0400040F RID: 1039
			APP_UTILITIESMISSING,
			// Token: 0x04000410 RID: 1040
			PARTITIONTABLEMISSING,
			// Token: 0x04000411 RID: 1041
			RFSMISSING,
			// Token: 0x04000412 RID: 1042
			KERNELMISSING,
			// Token: 0x04000413 RID: 1043
			L3BOOTLOADERMISSING,
			// Token: 0x04000414 RID: 1044
			CONFIGURATIONMISSING,
			// Token: 0x04000415 RID: 1045
			BLUETOOTHGPSMISSING,
			// Token: 0x04000416 RID: 1046
			CONTROLHEADMISSING,
			// Token: 0x04000417 RID: 1047
			DATAIMAGEMISSING,
			// Token: 0x04000418 RID: 1048
			FILECHANGELISTMISSING,
			// Token: 0x04000419 RID: 1049
			GLOBALMARKERMISSING,
			// Token: 0x0400041A RID: 1050
			FAILED_TO_RESET_FPGA,
			// Token: 0x0400041B RID: 1051
			FAILED_TO_ERASE_FPGA,
			// Token: 0x0400041C RID: 1052
			FAILED_TO_READ_CODEPLUG,
			// Token: 0x0400041D RID: 1053
			MAC_ADDRESS_UPDATE_FAILED,
			// Token: 0x0400041E RID: 1054
			SCRIPTFILEMISSING,
			// Token: 0x0400041F RID: 1055
			TUNINGVERSIONWRONG,
			// Token: 0x04000420 RID: 1056
			PSMARKERFILEMISSING,
			// Token: 0x04000421 RID: 1057
			NO_SIGNALS_CAPTURED = 3073,
			// Token: 0x04000422 RID: 1058
			ARCHIVE_MAXSIZE_REACHED,
			// Token: 0x04000423 RID: 1059
			FAIL_TO_READ_ERRORLOG,
			// Token: 0x04000424 RID: 1060
			FAIL_TO_TRACE_SIGNALS,
			// Token: 0x04000425 RID: 1061
			MSG_LISTEN_TERMINATED,
			// Token: 0x04000426 RID: 1062
			FAIL_TO_EXIT_ATMODE,
			// Token: 0x04000427 RID: 1063
			CYPHER_DUALBOARD_DETECTED,
			// Token: 0x04000428 RID: 1064
			FAIL_TO_CREATE_CONTROL_REGION = 3153,
			// Token: 0x04000429 RID: 1065
			GUI_FAIL_TO_DISPLAY_SPLASH,
			// Token: 0x0400042A RID: 1066
			GUI_FAIL_TO_CALC_CTRL_GRAPHICS_PATH,
			// Token: 0x0400042B RID: 1067
			WRITE_IME_TYPE_SUCCESSFULL,
			// Token: 0x0400042C RID: 1068
			LAI_INVALID_PARAMETER = 3201,
			// Token: 0x0400042D RID: 1069
			LAI_UNABLE_TO_LDAP_SSLINIT,
			// Token: 0x0400042E RID: 1070
			LAI_INVALID_LOGIN,
			// Token: 0x0400042F RID: 1071
			LAI_UNABLE_TO_CLOSE_LDAP,
			// Token: 0x04000430 RID: 1072
			LAI_UNABLE_TO_LDAP_SET_OPTION,
			// Token: 0x04000431 RID: 1073
			LAI_UNABLE_TO_LDAP_GET_OPTION,
			// Token: 0x04000432 RID: 1074
			LAI_UNABLE_TO_LDAP_CONNECT,
			// Token: 0x04000433 RID: 1075
			LAI_UNABLE_TO_LDAP_BIND_S,
			// Token: 0x04000434 RID: 1076
			LIC_LM_NOCONFFILE = 3281,
			// Token: 0x04000435 RID: 1077
			LIC_BADFILE,
			// Token: 0x04000436 RID: 1078
			LIC_NOSERVER,
			// Token: 0x04000437 RID: 1079
			LIC_MAXUSERS,
			// Token: 0x04000438 RID: 1080
			LIC_NOFEATURE,
			// Token: 0x04000439 RID: 1081
			LIC_NOSERVICE,
			// Token: 0x0400043A RID: 1082
			LIC_NOSOCKET,
			// Token: 0x0400043B RID: 1083
			LIC_BADCODE,
			// Token: 0x0400043C RID: 1084
			LIC_NOTTHISHOST,
			// Token: 0x0400043D RID: 1085
			LIC_LONGGONE,
			// Token: 0x0400043E RID: 1086
			LIC_BADDATE,
			// Token: 0x0400043F RID: 1087
			LIC_BADCOMM,
			// Token: 0x04000440 RID: 1088
			LIC_NO_SERVER_IN_FILE,
			// Token: 0x04000441 RID: 1089
			LIC_BADHOST,
			// Token: 0x04000442 RID: 1090
			LIC_CANTCONNECT,
			// Token: 0x04000443 RID: 1091
			LIC_CANTREAD,
			// Token: 0x04000444 RID: 1092
			LIC_CANTWRITE,
			// Token: 0x04000445 RID: 1093
			LIC_NOSERVSUPP,
			// Token: 0x04000446 RID: 1094
			LIC_SELECTERR,
			// Token: 0x04000447 RID: 1095
			LIC_SERVBUSY,
			// Token: 0x04000448 RID: 1096
			LIC_OLDVER,
			// Token: 0x04000449 RID: 1097
			LIC_CHECKINBAD,
			// Token: 0x0400044A RID: 1098
			LIC_BUSYNEWSERV,
			// Token: 0x0400044B RID: 1099
			LIC_USERSQUEUED,
			// Token: 0x0400044C RID: 1100
			LIC_SERVLONGGONE,
			// Token: 0x0400044D RID: 1101
			LIC_TOOMANY,
			// Token: 0x0400044E RID: 1102
			LIC_CANTREADKMEM,
			// Token: 0x0400044F RID: 1103
			LIC_CANTREADVMUNIX,
			// Token: 0x04000450 RID: 1104
			LIC_CANTFINDETHER,
			// Token: 0x04000451 RID: 1105
			LIC_NOREADLIC,
			// Token: 0x04000452 RID: 1106
			LIC_TOOEARLY,
			// Token: 0x04000453 RID: 1107
			LIC_NOSUCHATTR,
			// Token: 0x04000454 RID: 1108
			LIC_BADHANDSHAKE,
			// Token: 0x04000455 RID: 1109
			LIC_CLOCKBAD,
			// Token: 0x04000456 RID: 1110
			LIC_FEATQUEUE,
			// Token: 0x04000457 RID: 1111
			LIC_FEATCORRUPT,
			// Token: 0x04000458 RID: 1112
			LIC_BADFEATPARAM,
			// Token: 0x04000459 RID: 1113
			LIC_FEATEXCLUDE,
			// Token: 0x0400045A RID: 1114
			LIC_FEATNOTINCLUDE,
			// Token: 0x0400045B RID: 1115
			LIC_CANTMALLOC,
			// Token: 0x0400045C RID: 1116
			LIC_NEVERCHECKOUT,
			// Token: 0x0400045D RID: 1117
			LIC_BADPARAM,
			// Token: 0x0400045E RID: 1118
			LIC_NOKEYDATA,
			// Token: 0x0400045F RID: 1119
			LIC_BADKEYDATA,
			// Token: 0x04000460 RID: 1120
			LIC_FUNCNOTAVAIL,
			// Token: 0x04000461 RID: 1121
			LIC_DEMOKIT,
			// Token: 0x04000462 RID: 1122
			LIC_NOCLOCKCHECK,
			// Token: 0x04000463 RID: 1123
			LIC_BADPLATFORM,
			// Token: 0x04000464 RID: 1124
			LIC_DATE_TOOBIG,
			// Token: 0x04000465 RID: 1125
			LIC_EXPIREDKEYS,
			// Token: 0x04000466 RID: 1126
			LIC_NOFLEXLMINIT,
			// Token: 0x04000467 RID: 1127
			LIC_NOSERVRESP,
			// Token: 0x04000468 RID: 1128
			LIC_CHECKOUTFILTERED,
			// Token: 0x04000469 RID: 1129
			LIC_NOFEATSET,
			// Token: 0x0400046A RID: 1130
			LIC_BADFEATSET,
			// Token: 0x0400046B RID: 1131
			LIC_CANTCOMPUTEFEATSET,
			// Token: 0x0400046C RID: 1132
			LIC_SOCKETFAIL,
			// Token: 0x0400046D RID: 1133
			LIC_SETSOCKFAIL,
			// Token: 0x0400046E RID: 1134
			LIC_BADCHECKSUM,
			// Token: 0x0400046F RID: 1135
			LIC_SERVBADCHECKSUM,
			// Token: 0x04000470 RID: 1136
			LIC_SERVNOREADLIC,
			// Token: 0x04000471 RID: 1137
			LIC_NONETWORK,
			// Token: 0x04000472 RID: 1138
			LIC_NOTLICADMIN,
			// Token: 0x04000473 RID: 1139
			LIC_REMOVETOOSOON,
			// Token: 0x04000474 RID: 1140
			LIC_BADVENDORDATA,
			// Token: 0x04000475 RID: 1141
			LIC_LIBRARYMISMATCH,
			// Token: 0x04000476 RID: 1142
			LIC_NONETOBORROW,
			// Token: 0x04000477 RID: 1143
			LIC_NOBORROWSUPP,
			// Token: 0x04000478 RID: 1144
			LIC_LM_NOTONSERVER,
			// Token: 0x04000479 RID: 1145
			LIC_LM_BORROWLOCKED,
			// Token: 0x0400047A RID: 1146
			LIC_BAD_TZ,
			// Token: 0x0400047B RID: 1147
			LIC_OLDVENDORDATA,
			// Token: 0x0400047C RID: 1148
			LIC_LOCALFILTER,
			// Token: 0x0400047D RID: 1149
			LIC_LM_ENDPATH,
			// Token: 0x0400047E RID: 1150
			LIC_LM_VMS_SETIMR_FAILED,
			// Token: 0x0400047F RID: 1151
			LIC_LM_INTERNAL_ERROR,
			// Token: 0x04000480 RID: 1152
			LIC_LM_BAD_VERSION,
			// Token: 0x04000481 RID: 1153
			LIC_LM_NOADMINAPI,
			// Token: 0x04000482 RID: 1154
			LIC_LM_NOFILEOPS,
			// Token: 0x04000483 RID: 1155
			LIC_LM_NODATAFILE,
			// Token: 0x04000484 RID: 1156
			LIC_LM_NOFILEVSEND,
			// Token: 0x04000485 RID: 1157
			LIC_LM_BADPKG,
			// Token: 0x04000486 RID: 1158
			LIC_LM_SERVOLDVER,
			// Token: 0x04000487 RID: 1159
			LIC_LM_USERBASED,
			// Token: 0x04000488 RID: 1160
			LIC_LM_NOSERVCAP,
			// Token: 0x04000489 RID: 1161
			LIC_LM_OBJECTUSED,
			// Token: 0x0400048A RID: 1162
			LIC_LM_MAXLIMIT,
			// Token: 0x0400048B RID: 1163
			LIC_LM_BADSYSDATE,
			// Token: 0x0400048C RID: 1164
			LIC_LM_PLATNOTLIC,
			// Token: 0x0400048D RID: 1165
			LIC_LM_FUTURE_FILE,
			// Token: 0x0400048E RID: 1166
			LIC_LM_DEFAULT_SEEDS,
			// Token: 0x0400048F RID: 1167
			LIC_LM_SERVER_REMOVED,
			// Token: 0x04000490 RID: 1168
			LIC_LM_POOL,
			// Token: 0x04000491 RID: 1169
			LIC_LM_LGEN_VER,
			// Token: 0x04000492 RID: 1170
			LIC_LM_NOT_THIS_HOST,
			// Token: 0x04000493 RID: 1171
			LIC_LM_HOSTDOWN,
			// Token: 0x04000494 RID: 1172
			LIC_LM_VENDOR_DOWN,
			// Token: 0x04000495 RID: 1173
			LIC_LM_CANT_DECIMAL,
			// Token: 0x04000496 RID: 1174
			LIC_LM_BADDECFILE,
			// Token: 0x04000497 RID: 1175
			LIC_LM_REMOVE_LINGER,
			// Token: 0x04000498 RID: 1176
			LIC_LM_RESVFOROTHERS,
			// Token: 0x04000499 RID: 1177
			LIC_LM_BORROW_ERROR,
			// Token: 0x0400049A RID: 1178
			LIC_LM_TSOK_ERR,
			// Token: 0x0400049B RID: 1179
			LIC_LM_BORROW_TOOLONG,
			// Token: 0x0400049C RID: 1180
			LIC_LM_UNBORROWED_ALREADY,
			// Token: 0x0400049D RID: 1181
			LIC_LM_SERVER_MAXED_OUT,
			// Token: 0x0400049E RID: 1182
			LIC_LM_NOBORROWCOMP,
			// Token: 0x0400049F RID: 1183
			LIC_LM_BORROW_METEREMPTY,
			// Token: 0x040004A0 RID: 1184
			LIC_LM_NOBORROWMETER,
			// Token: 0x040004A1 RID: 1185
			LIC_LM_NODONGLE,
			// Token: 0x040004A2 RID: 1186
			LIC_LM_NORESLINK,
			// Token: 0x040004A3 RID: 1187
			LIC_LM_NODONGLEDRIVER,
			// Token: 0x040004A4 RID: 1188
			LIC_LM_FLEXLOCK2CKOUT,
			// Token: 0x040004A5 RID: 1189
			LIC_LM_SIGN_REQ,
			// Token: 0x040004A6 RID: 1190
			LIC_LM_PUBKEY_ERR,
			// Token: 0x040004A7 RID: 1191
			LIC_LM_NOTRLSUPPORT,
			// Token: 0x040004A8 RID: 1192
			LIC_LM_BORROW_LINGER_ERR,
			// Token: 0x040004A9 RID: 1193
			LIC_LM_BORROW_EXPIRED,
			// Token: 0x040004AA RID: 1194
			LIC_LM_MUST_BE_LOCAL,
			// Token: 0x040004AB RID: 1195
			LIC_LM_BORROW_DOWN,
			// Token: 0x040004AC RID: 1196
			LIC_LM_FLOATOK_ONEHOSTID,
			// Token: 0x040004AD RID: 1197
			LIC_LM_BORROW_DELETE_ERR,
			// Token: 0x040004AE RID: 1198
			LIC_LM_BORROW_RETURN_EARLY_ERR,
			// Token: 0x040004AF RID: 1199
			LIC_LM_BORROW_RETURN_SERVER_ERR,
			// Token: 0x040004B0 RID: 1200
			LIC_LM_CANT_CHECKOUT_JUST_PACKAGE,
			// Token: 0x040004B1 RID: 1201
			LIC_LM_COMPOSITEID_INIT_ERR,
			// Token: 0x040004B2 RID: 1202
			LIC_LM_COMPOSITEID_ITEM_ERR,
			// Token: 0x040004B3 RID: 1203
			LIC_LM_BORROW_MATCH_ERR,
			// Token: 0x040004B4 RID: 1204
			LIC_LM_NULLPOINTER,
			// Token: 0x040004B5 RID: 1205
			LIC_LM_BADHANDLE,
			// Token: 0x040004B6 RID: 1206
			LIC_LM_EMPTYSTRING,
			// Token: 0x040004B7 RID: 1207
			LIC_LM_BADMEMORYACCESS,
			// Token: 0x040004B8 RID: 1208
			LIC_LM_NOTSUPPORTED,
			// Token: 0x040004B9 RID: 1209
			LIC_LM_NULL_JOB_HANDLE,
			// Token: 0x040004BA RID: 1210
			LIC_LM_EVENTLOG_INIT_ERR,
			// Token: 0x040004BB RID: 1211
			LIC_LM_EVENTLOG_DISABLED,
			// Token: 0x040004BC RID: 1212
			LIC_LM_EVENTLOG_WRITE_ERR,
			// Token: 0x040004BD RID: 1213
			LIC_LM_BADINDEX,
			// Token: 0x040004BE RID: 1214
			LIC_LM_TIMEOUT,
			// Token: 0x040004BF RID: 1215
			LIC_LM_BADCOMMAND,
			// Token: 0x040004C0 RID: 1216
			LIC_LM_SOCKET_BROKEN_PIPE,
			// Token: 0x040004C1 RID: 1217
			LIC_LM_INVALID_SIGNATURE,
			// Token: 0x040004C2 RID: 1218
			LIC_LM_UNCOUNTED_NOT_SUPPORTED,
			// Token: 0x040004C3 RID: 1219
			LIC_LM_REDUNDANT_SIGNATURES,
			// Token: 0x040004C4 RID: 1220
			LIC_LM_BADCODE_V71_LK,
			// Token: 0x040004C5 RID: 1221
			LIC_LM_BADCODE_V71_SIGN,
			// Token: 0x040004C6 RID: 1222
			LIC_LM_BADCODE_V80_LK,
			// Token: 0x040004C7 RID: 1223
			LIC_LM_BADCODE_V80_SIGN,
			// Token: 0x040004C8 RID: 1224
			LIC_LM_BADCODE_V81_LK,
			// Token: 0x040004C9 RID: 1225
			LIC_LM_BADCODE_V81_SIGN,
			// Token: 0x040004CA RID: 1226
			LIC_LM_BADCODE_V81_SIGN2,
			// Token: 0x040004CB RID: 1227
			LIC_LM_BADCODE_V84_LK,
			// Token: 0x040004CC RID: 1228
			LIC_LM_BADCODE_V84_SIGN,
			// Token: 0x040004CD RID: 1229
			LIC_LM_BADCODE_V84_SIGN2,
			// Token: 0x040004CE RID: 1230
			LIC_LM_LK_REQ,
			// Token: 0x040004CF RID: 1231
			LIC_LM_BADAUTH,
			// Token: 0x040004D0 RID: 1232
			LIC_LM_REPAIR_NEEDED,
			// Token: 0x040004D1 RID: 1233
			LIC_LM_TS_OPEN,
			// Token: 0x040004D2 RID: 1234
			LIC_LM_BAD_FULFILLMENT,
			// Token: 0x040004D3 RID: 1235
			LIC_LM_BAD_ACTREQ,
			// Token: 0x040004D4 RID: 1236
			LIC_LM_TS_NO_FULFILL_MATCH,
			// Token: 0x040004D5 RID: 1237
			LIC_LM_BAD_ACT_RESP,
			// Token: 0x040004D6 RID: 1238
			LIC_LM_CANTRETURN,
			// Token: 0x040004D7 RID: 1239
			LIC_LM_RETURNEXCEEDSMAX,
			// Token: 0x040004D8 RID: 1240
			LIC_LM_NO_REPAIRS_LEFT,
			// Token: 0x040004D9 RID: 1241
			LIC_LM_NOT_ALLOWED,
			// Token: 0x040004DA RID: 1242
			LIC_LM_ENTLEXCLUDE,
			// Token: 0x040004DB RID: 1243
			LIC_LM_ENTLNOTINCLUDE,
			// Token: 0x040004DC RID: 1244
			LIC_LM_ACTIVATION,
			// Token: 0x040004DD RID: 1245
			LIC_LM_TS_BADDATE,
			// Token: 0x040004DE RID: 1246
			LIC_FLEX_NOFEATURE,
			// Token: 0x040004DF RID: 1247
			LIC_FLEX_AUTH_NOT_FOUND,
			// Token: 0x040004E0 RID: 1248
			LIC_FLEX_INVALID_PARAM,
			// Token: 0x040004E1 RID: 1249
			LIC_INVALID_PARAM,
			// Token: 0x040004E2 RID: 1250
			LIC_FEATURE_NOT_FOUND,
			// Token: 0x040004E3 RID: 1251
			LIC_FAILED_CREATE_DIALOG,
			// Token: 0x040004E4 RID: 1252
			LIC_FAILED_GEN_AUTH,
			// Token: 0x040004E5 RID: 1253
			LIC_FAILED_COPY,
			// Token: 0x040004E6 RID: 1254
			LIC_FAILED_VALIDATE,
			// Token: 0x040004E7 RID: 1255
			SFC_LM_TS_BASE_ERROR = 3541,
			// Token: 0x040004E8 RID: 1256
			SFC_LM_TS_BADPARAM,
			// Token: 0x040004E9 RID: 1257
			SFC_LM_TS_CANTMALLOC,
			// Token: 0x040004EA RID: 1258
			SFC_LM_TS_OPEN_ERROR,
			// Token: 0x040004EB RID: 1259
			SFC_LM_TS_CLOSE_ERROR,
			// Token: 0x040004EC RID: 1260
			SFC_LM_TS_INIT,
			// Token: 0x040004ED RID: 1261
			SFC_LM_TS_ACT_GEN_REQ,
			// Token: 0x040004EE RID: 1262
			SFC_LM_TS_RETURN_GEN_REQ,
			// Token: 0x040004EF RID: 1263
			SFC_LM_TS_REPAIR_GEN_REQ,
			// Token: 0x040004F0 RID: 1264
			SFC_LM_TS_RESERVED_9,
			// Token: 0x040004F1 RID: 1265
			SFC_LM_TS_DELETE,
			// Token: 0x040004F2 RID: 1266
			SFC_LM_TS_CANT_FIND,
			// Token: 0x040004F3 RID: 1267
			SFC_LM_TS_INTERNAL_ERROR,
			// Token: 0x040004F4 RID: 1268
			SFC_LM_TS_RESERVED_13,
			// Token: 0x040004F5 RID: 1269
			SFC_LM_TS_INVALID_INDEX,
			// Token: 0x040004F6 RID: 1270
			SFC_LM_TS_RESERVED_15,
			// Token: 0x040004F7 RID: 1271
			SFC_LM_TS_NO_ASR_FOUND,
			// Token: 0x040004F8 RID: 1272
			SFC_LM_TS_UPDATING_TS,
			// Token: 0x040004F9 RID: 1273
			SFC_LM_TS_SEND_RECEIVE,
			// Token: 0x040004FA RID: 1274
			SFC_LM_TS_PROCESS_RESP,
			// Token: 0x040004FB RID: 1275
			SFC_LM_TS_UNKNOWN_RESP,
			// Token: 0x040004FC RID: 1276
			SFC_LM_TS_ASR_LOAD_ONCE,
			// Token: 0x040004FD RID: 1277
			SFC_LM_TS_RESERVED_22,
			// Token: 0x040004FE RID: 1278
			SFC_LM_TS_SHORT_CODE_PENDING,
			// Token: 0x040004FF RID: 1279
			SFC_LM_TS_SHORT_CODE_ACT_CREATE,
			// Token: 0x04000500 RID: 1280
			SFC_LM_TS_SHORT_CODE_REPAIR_CREATE,
			// Token: 0x04000501 RID: 1281
			SFC_LM_TS_SHORT_CODE_RETURN_CREATE,
			// Token: 0x04000502 RID: 1282
			SFC_LM_TS_SHORT_CODE_CANCEL,
			// Token: 0x04000503 RID: 1283
			SFC_LM_TS_SHORT_CODE_PROCESS,
			// Token: 0x04000504 RID: 1284
			SFC_LM_TS_SHORT_CODE_UNSUPPORTED,
			// Token: 0x04000505 RID: 1285
			SFC_LM_TS_LOAD,
			// Token: 0x04000506 RID: 1286
			SFC_LM_TS_FR_DISABLE,
			// Token: 0x04000507 RID: 1287
			SFC_LM_TS_TIMEDOUT,
			// Token: 0x04000508 RID: 1288
			SFC_LM_TS_INSUFFICIENT_RESOURCE,
			// Token: 0x04000509 RID: 1289
			SFC_LM_TS_INVALID_REQUEST_TYPE,
			// Token: 0x0400050A RID: 1290
			SFC_LM_TS_NO_MATCHING_FULFILLMENT,
			// Token: 0x0400050B RID: 1291
			SFC_LM_TS_INVALID_REQUEST,
			// Token: 0x0400050C RID: 1292
			SFC_LM_TS_RETURN_OUT_OF_CHAIN,
			// Token: 0x0400050D RID: 1293
			SFC_LM_TS_MAX_COUNT_EXCEEDED,
			// Token: 0x0400050E RID: 1294
			SFC_LM_TS_INSUFFICIENT_REPAIR_COUNT,
			// Token: 0x0400050F RID: 1295
			SFC_LM_TS_OPERATIONS,
			// Token: 0x04000510 RID: 1296
			SFC_LM_TS_CONNECTION_FAILED,
			// Token: 0x04000511 RID: 1297
			SFC_LM_TS_SSL_ERROR,
			// Token: 0x04000512 RID: 1298
			SFC_LM_TS_RETURN_INCOMPLETE,
			// Token: 0x04000513 RID: 1299
			SFC_LM_TS_LOCAL_REPAIR,
			// Token: 0x04000514 RID: 1300
			SFC_LM_TS_UNSUPPORTED_REQUEST_VERSION,
			// Token: 0x04000515 RID: 1301
			SFC_LM_TS_UNSUPPORTED,
			// Token: 0x04000516 RID: 1302
			SFC_LM_TS_CONFIGURATION,
			// Token: 0x04000517 RID: 1303
			SFC_LM_TS_NO_PRODUCT_SET,
			// Token: 0x04000518 RID: 1304
			SFC_INTERNERROR_FAILED_CREATE_LICSPEC = 3568,
			// Token: 0x04000519 RID: 1305
			SFC_INTERNERROR_FAILED_POPULATE_TS,
			// Token: 0x0400051A RID: 1306
			SFC_INTERNERROR_INVALID_INDEX,
			// Token: 0x0400051B RID: 1307
			SFC_INTERNERROR_NO_CALLBACK_HANDLER,
			// Token: 0x0400051C RID: 1308
			SFC_FULFILLMENTS_QUERY_FAILED = 3584,
			// Token: 0x0400051D RID: 1309
			SFC_NO_LICENSES_LEFT,
			// Token: 0x0400051E RID: 1310
			SFC_EID_ALREADY_REGISTERED_TO_SERIAL_NUM,
			// Token: 0x0400051F RID: 1311
			SFC_SERVER_FAIL_RESPONSE,
			// Token: 0x04000520 RID: 1312
			SFC_ENTITLEMENTS_QUERY_FAILED,
			// Token: 0x04000521 RID: 1313
			SFC_HAS_REGISTER_IN_TS = 3664,
			// Token: 0x04000522 RID: 1314
			SFC_FAILED_GET_FEATURE,
			// Token: 0x04000523 RID: 1315
			SFC_FAILED_GET_LICENSE,
			// Token: 0x04000524 RID: 1316
			SFC_FAILED_CONNECT,
			// Token: 0x04000525 RID: 1317
			SFC_FAILED_REGISTER,
			// Token: 0x04000526 RID: 1318
			SFC_FAILED_RETURN,
			// Token: 0x04000527 RID: 1319
			SFC_NO_FEATURES_ON_SERVER = 3744,
			// Token: 0x04000528 RID: 1320
			SFC_WRONG_REGION_FEATURE,
			// Token: 0x04000529 RID: 1321
			SFC_ADD_EID_ALREADY_REGISTERED_TO_SERIAL_NUM,
			// Token: 0x0400052A RID: 1322
			SFC_IMPORT_SERIAL_NUM_INVALID_FORMAT,
			// Token: 0x0400052B RID: 1323
			SFC_IMPORT_EID_ALREADY_REGISTERED_TO_SERIAL_NUM,
			// Token: 0x0400052C RID: 1324
			SFC_IMPORT_SERIAL_NUM_ALREADY_IN_LIST,
			// Token: 0x0400052D RID: 1325
			SFC_SERIAL_NUM_ALREADY_IN_LIST,
			// Token: 0x0400052E RID: 1326
			SFC_NEXT_PAGE_NOT_DEFINED,
			// Token: 0x0400052F RID: 1327
			SFC_REGISTERING_DEVICES_FAILED,
			// Token: 0x04000530 RID: 1328
			SFC_ACTIVATING_DEVICE_FAILED,
			// Token: 0x04000531 RID: 1329
			SFC_RETURNING_FEATURES_FAILED,
			// Token: 0x04000532 RID: 1330
			SFC_WIZARDFORM_FAILED,
			// Token: 0x04000533 RID: 1331
			SFC_AID_EID_ALREADY_REGISTERED_TO_SERIAL_NUM_AND_FILTERED,
			// Token: 0x04000534 RID: 1332
			SFC_NO_REGISTERED_FEATURES_IN_PC_FOR_CONNECTED_RADIO,
			// Token: 0x04000535 RID: 1333
			SFC_PRODUCT_NAME_NOT_IN_CPTAGS,
			// Token: 0x04000536 RID: 1334
			SFC_SERIAL_NUMBER_FORMAT_INVALID,
			// Token: 0x04000537 RID: 1335
			SFC_RADIO_WRONG_REGION_FEATURE,
			// Token: 0x04000538 RID: 1336
			SFC_AUTO_RETURN_NOT_SUPPORTED,
			// Token: 0x04000539 RID: 1337
			SFC_APP_FEATURE_ALREADY_REGISTERED,
			// Token: 0x0400053A RID: 1338
			SFC_NOT_APP_FEATURE_EID,
			// Token: 0x0400053B RID: 1339
			SFC_NOT_DEVICE_FEATURE_EID,
			// Token: 0x0400053C RID: 1340
			SFC_WRONG_APPLICATION_FEATURE,
			// Token: 0x0400053D RID: 1341
			SFC_NOT_ENOUGH_AVAILABLE,
			// Token: 0x0400053E RID: 1342
			SFC_AT_LEAST_ONE,
			// Token: 0x0400053F RID: 1343
			SFC_INVALID_EID,
			// Token: 0x04000540 RID: 1344
			SFC_PRODUCT_NAME_IS_CAP_MAX,
			// Token: 0x04000541 RID: 1345
			MORE_THAN_ONE_DEVICE_CONNECTED = 3841,
			// Token: 0x04000542 RID: 1346
			FLASH_DEVICE_SUCCESSFULL,
			// Token: 0x04000543 RID: 1347
			CPS_NOT_INSTALLED,
			// Token: 0x04000544 RID: 1348
			MSG_QUEST_MODELTYPE_UNKNOWN,
			// Token: 0x04000545 RID: 1349
			MODELTYPE_MISMATCH,
			// Token: 0x04000546 RID: 1350
			DEVICE_IN_FLASHMODE,
			// Token: 0x04000547 RID: 1351
			MIGRATION_IN_FLASHMODE,
			// Token: 0x04000548 RID: 1352
			MIGRATION_SAME_PRODUCT,
			// Token: 0x04000549 RID: 1353
			PACKAGE_NOT_SUPPORT,
			// Token: 0x0400054A RID: 1354
			INVALID_UNKILLVALUES,
			// Token: 0x0400054B RID: 1355
			P2PCONTROLLER_NOT_INITIALIZED = 3969,
			// Token: 0x0400054C RID: 1356
			P2PCONTROLLER_ALREADY_INITIALIZED,
			// Token: 0x0400054D RID: 1357
			P2PCONTROLLER_CLOSE_NOT_REQUIRED,
			// Token: 0x0400054E RID: 1358
			P2PCONTROLLER_CALLBACK_FAILED,
			// Token: 0x0400054F RID: 1359
			P2PCONTROLLER_LOCAL_INIT_FAILED,
			// Token: 0x04000550 RID: 1360
			P2PCONTROLLER_START_LE_FAILED,
			// Token: 0x04000551 RID: 1361
			P2PCONTROLLER_OPEN_FAILED,
			// Token: 0x04000552 RID: 1362
			P2PCONTROLLER_STOP_LE_FAILED,
			// Token: 0x04000553 RID: 1363
			P2PCONTROLLER_CLOSE_FAILED,
			// Token: 0x04000554 RID: 1364
			RDAC_NOT_INITIALIZED = 4097,
			// Token: 0x04000555 RID: 1365
			RDAC_ALREADY_INITIALIZED,
			// Token: 0x04000556 RID: 1366
			RDAC_CLOSE_NOT_REQUIRED,
			// Token: 0x04000557 RID: 1367
			RDAC_CALLBACK_FAILED,
			// Token: 0x04000558 RID: 1368
			RDAC_GENERICFAILURE,
			// Token: 0x04000559 RID: 1369
			RDAC_OUTOFMEMORY,
			// Token: 0x0400055A RID: 1370
			RDAC_INVALID_PARAMETER,
			// Token: 0x0400055B RID: 1371
			RDAC_BUNDLE_SIZE_NOT_ENOUGH,
			// Token: 0x0400055C RID: 1372
			RDAC_CP_INITIAL_FAILED = 4145,
			// Token: 0x0400055D RID: 1373
			RDAC_CP_READ_REPEATER_FAILED,
			// Token: 0x0400055E RID: 1374
			RDAC_CP_READ_REPEATERLOG_FAILED,
			// Token: 0x0400055F RID: 1375
			RDAC_CP_WRITE_REPEATER_FAILED,
			// Token: 0x04000560 RID: 1376
			RDAC_CP_WRITE_DIGITAL_VOTING_FAILED,
			// Token: 0x04000561 RID: 1377
			RDAC_CP_RETRIEVE_ITEM_FAILED,
			// Token: 0x04000562 RID: 1378
			RDAC_CP_RETRIEVE_RANGE_FAILED,
			// Token: 0x04000563 RID: 1379
			RDAC_CP_MODIFY_ITEM_FAILED,
			// Token: 0x04000564 RID: 1380
			RDAC_CP_ALARM_HANDLER_FAILED,
			// Token: 0x04000565 RID: 1381
			RDAC_CP_STATE_HANDLER_FAILED,
			// Token: 0x04000566 RID: 1382
			RDAC_CP_MAINDB_NOSTATE,
			// Token: 0x04000567 RID: 1383
			RDAC_CP_WRONGINPACKXML,
			// Token: 0x04000568 RID: 1384
			RDAC_CP_NOTFOUNDINPACKXML,
			// Token: 0x04000569 RID: 1385
			RDAC_CP_NULLDATA,
			// Token: 0x0400056A RID: 1386
			RDAC_CP_MAINDB_EMPTY,
			// Token: 0x0400056B RID: 1387
			RDAC_CP_INVALID_XML_CONTENT,
			// Token: 0x0400056C RID: 1388
			RDAC_CP_UNEXPECTED_CONV_STR,
			// Token: 0x0400056D RID: 1389
			RDAC_CP_WRONG_RETURN_VALUE_FROM_FLD,
			// Token: 0x0400056E RID: 1390
			RDAC_CP_WRONGDEVICEDATA,
			// Token: 0x0400056F RID: 1391
			RDAC_CP_VALUEOUTOFRANGE,
			// Token: 0x04000570 RID: 1392
			RDAC_CP_VALUEDPDFAILED,
			// Token: 0x04000571 RID: 1393
			RDAC_CP_GENERAL_EXCEPTION,
			// Token: 0x04000572 RID: 1394
			RDAC_CP_LISTIDMISSING,
			// Token: 0x04000573 RID: 1395
			RDAC_CP_INVALIDLISTID,
			// Token: 0x04000574 RID: 1396
			RDAC_CP_NODENOTFOUND,
			// Token: 0x04000575 RID: 1397
			RDAC_CP_LOADRANGEVALIDXMLERROR,
			// Token: 0x04000576 RID: 1398
			RDAC_CP_XMLFILENOTFOUND,
			// Token: 0x04000577 RID: 1399
			RDAC_CP_RANGEVALIDXMLFORMATERROR,
			// Token: 0x04000578 RID: 1400
			RDAC_CP_UNDEFINEDRANGETYPE,
			// Token: 0x04000579 RID: 1401
			RDAC_CP_NOTINHASHTABLE,
			// Token: 0x0400057A RID: 1402
			RDAC_CP_OFFSETLENGTHNOTDEFINED,
			// Token: 0x0400057B RID: 1403
			RDAC_CP_RANGETAGMISSING,
			// Token: 0x0400057C RID: 1404
			RDAC_CP_TAGNAMENOTFOUND,
			// Token: 0x0400057D RID: 1405
			RDAC_CP_RANGENOTDEFINED,
			// Token: 0x0400057E RID: 1406
			RDAC_CP_INVALIDFIELDID,
			// Token: 0x0400057F RID: 1407
			RDAC_CP_NOTHISATTRIBUTE,
			// Token: 0x04000580 RID: 1408
			RDAC_CP_INVALIDGUICHOICE,
			// Token: 0x04000581 RID: 1409
			RDAC_CP_HEXOUTOFRANGE,
			// Token: 0x04000582 RID: 1410
			RDAC_CP_INVALID_HEX_STRING,
			// Token: 0x04000583 RID: 1411
			RDAC_CP_RDAC_NULL_STRING,
			// Token: 0x04000584 RID: 1412
			RDAC_CP_INVALID_ARRAY_LENGTH,
			// Token: 0x04000585 RID: 1413
			RDAC_CP_INVALID_OCTAL_NUMBER,
			// Token: 0x04000586 RID: 1414
			RDAC_CP_INVALID_DATA_CONVERT,
			// Token: 0x04000587 RID: 1415
			RDAC_CP_NEW_OPR_FAILED,
			// Token: 0x04000588 RID: 1416
			RDAC_CP_NULL_STRING,
			// Token: 0x04000589 RID: 1417
			RDAC_CP_INVALIDFIELDVALUE,
			// Token: 0x0400058A RID: 1418
			RDAC_CP_CLEARMODIFICATION_FAILED,
			// Token: 0x0400058B RID: 1419
			RDAC_CP_NODATATOWRITE,
			// Token: 0x0400058C RID: 1420
			RDAC_CP_GETFIELDTYPE_FAILED,
			// Token: 0x0400058D RID: 1421
			RDAC_CP_GETRANGE_FAILED,
			// Token: 0x0400058E RID: 1422
			RDAC_CC_CONNECT_FAILED = 4273,
			// Token: 0x0400058F RID: 1423
			RDAC_CC_READ_FAILED,
			// Token: 0x04000590 RID: 1424
			RDAC_CC_DISCONNECT_FAILED,
			// Token: 0x04000591 RID: 1425
			RDAC_CC_IR_READ_FAILED,
			// Token: 0x04000592 RID: 1426
			RDAC_CC_IR_CONNECT_FAILED,
			// Token: 0x04000593 RID: 1427
			RDAC_CC_MODE_FAILED,
			// Token: 0x04000594 RID: 1428
			RDAC_CC_IPPORT_CHANGED_FAILED,
			// Token: 0x04000595 RID: 1429
			RDAC_CC_GATEWAY_CONNECT_FAILED,
			// Token: 0x04000596 RID: 1430
			RDAC_CC_GATEWAY_STATUS_CHANGE_FAILED,
			// Token: 0x04000597 RID: 1431
			RDAC_CC_ALARM_BROADCAST_FAILED,
			// Token: 0x04000598 RID: 1432
			RDAC_CC_STATE_BROADCAST_FAILED,
			// Token: 0x04000599 RID: 1433
			RDAC_CC_DV_BROADCAST_FAILED,
			// Token: 0x0400059A RID: 1434
			RDAC_GUI_APPLICATION_FAILED = 4305,
			// Token: 0x0400059B RID: 1435
			RDAC_GUI_GET_ALARM_FAILED,
			// Token: 0x0400059C RID: 1436
			RDAC_GUI_INVALID_ALARM_PARAM,
			// Token: 0x0400059D RID: 1437
			RDAC_GUI_CREATE_ALARM_FAILED,
			// Token: 0x0400059E RID: 1438
			RDAC_GUI_INVALID_ALARM_LIST,
			// Token: 0x0400059F RID: 1439
			RDAC_GUI_ALARM_STATUS_FAILED,
			// Token: 0x040005A0 RID: 1440
			RDAC_GUI_FAIL_TO_INIT,
			// Token: 0x040005A1 RID: 1441
			RDAC_GUI_INVALID_DIAG_PARAM,
			// Token: 0x040005A2 RID: 1442
			RDAC_GUI_DIAG_CLICK_FAILED,
			// Token: 0x040005A3 RID: 1443
			RDAC_GUI_FAILED_MAP_CONTROL,
			// Token: 0x040005A4 RID: 1444
			RDAC_GUI_FAILED_TOLOAD_VIEWXML,
			// Token: 0x040005A5 RID: 1445
			RDAC_GUI_NO_DEVICE_CONNECTED,
			// Token: 0x040005A6 RID: 1446
			RDAC_GUI_FAIL_CONVERT_TO_XMLDOC,
			// Token: 0x040005A7 RID: 1447
			RDAC_GUI_FAIL_TO_CREATE_INS,
			// Token: 0x040005A8 RID: 1448
			RDAC_GUI_FAIL_TO_CONNECT,
			// Token: 0x040005A9 RID: 1449
			RDAC_GUI_FAIL_TO_HANDLE_CONNECT,
			// Token: 0x040005AA RID: 1450
			RDAC_GUI_FAIL_TO_HANDLE_DV_CONNECT,
			// Token: 0x040005AB RID: 1451
			RDAC_GUI_FAIL_TO_HANDLE_GATEWAY_CONNECT,
			// Token: 0x040005AC RID: 1452
			RDAC_GUI_FAIL_TO_HANDLE_DISCONNECT,
			// Token: 0x040005AD RID: 1453
			RDAC_GUI_FAIL_TO_HANDLE_DV_DISCONNECT,
			// Token: 0x040005AE RID: 1454
			RDAC_GUI_FAIL_TO_HANDLE_ALARM,
			// Token: 0x040005AF RID: 1455
			RDAC_GUI_FAIL_TO_HANDLE_STATE,
			// Token: 0x040005B0 RID: 1456
			RDAC_GUI_FAIL_TO_HANDLE_DV_BROADCAST,
			// Token: 0x040005B1 RID: 1457
			RDAC_GUI_FAIL_TO_RETRIEVE,
			// Token: 0x040005B2 RID: 1458
			RDAC_GUI_FAIL_TO_NOTIFY,
			// Token: 0x040005B3 RID: 1459
			RDAC_GUI_CREATE_TABLE_FAILED,
			// Token: 0x040005B4 RID: 1460
			RDAC_GUI_FAIL_INIT_COLUMNS,
			// Token: 0x040005B5 RID: 1461
			RDAC_GUI_FAIL_INIT_ALARMS,
			// Token: 0x040005B6 RID: 1462
			RDAC_GUI_FAIL_HANDLE_CONNECT,
			// Token: 0x040005B7 RID: 1463
			RDAC_GUI_FAIL_HANDLE_DISCONNECT,
			// Token: 0x040005B8 RID: 1464
			RDAC_GUI_FAIL_HANDLE_ALARM,
			// Token: 0x040005B9 RID: 1465
			RDAC_GUI_FAIL_HANDLE_STATE,
			// Token: 0x040005BA RID: 1466
			RDAC_GUI_FAIL_ADD_PEER,
			// Token: 0x040005BB RID: 1467
			RDAC_GUI_FAIL_ADD_DV_PEER,
			// Token: 0x040005BC RID: 1468
			RDAC_GUI_FAIL_UPDATE_PEER,
			// Token: 0x040005BD RID: 1469
			RDAC_GUI_FAIL_UPDATE_DV_PEER,
			// Token: 0x040005BE RID: 1470
			RDAC_GUI_FAIL_SELECTION,
			// Token: 0x040005BF RID: 1471
			RDAC_GUI_FAIL_GET_ROW,
			// Token: 0x040005C0 RID: 1472
			RDAC_GUI_FAIL_GET_DV_ROW,
			// Token: 0x040005C1 RID: 1473
			RDAC_GUI_FAIL_LOAD_DATA,
			// Token: 0x040005C2 RID: 1474
			RDAC_GUI_FAIL_LOAD_DV_DATA,
			// Token: 0x040005C3 RID: 1475
			RDAC_GUI_FAIL_LOAD_ALARM,
			// Token: 0x040005C4 RID: 1476
			RDAC_GUI_FAIL_LOAD_STATE,
			// Token: 0x040005C5 RID: 1477
			RDAC_GUI_FAIL_GET_DATA,
			// Token: 0x040005C6 RID: 1478
			RDAC_GUI_FAIL_GET_DV_DATA,
			// Token: 0x040005C7 RID: 1479
			RDAC_GUI_FAIL_LOAD_RESOURCE,
			// Token: 0x040005C8 RID: 1480
			RDAC_GUI_INVALID_CONTROLLER,
			// Token: 0x040005C9 RID: 1481
			RDAC_GUI_FAIL_GET_RSSI,
			// Token: 0x040005CA RID: 1482
			RDAC_GUI_FAIL_DIAGNOSE_REPEATER,
			// Token: 0x040005CB RID: 1483
			RDAC_GUI_FAIL_CONTROL_SOFTWARE_ALARM,
			// Token: 0x040005CC RID: 1484
			RDAC_GUI_FAIL_GET_DIAGNOSTIC_VALUE_UNIT,
			// Token: 0x040005CD RID: 1485
			RDAC_GUI_FAIL_PEER_CHANGE,
			// Token: 0x040005CE RID: 1486
			RDAC_GUI_FAIL_DV_PEER_CHANGE,
			// Token: 0x040005CF RID: 1487
			RDAC_GUI_FAIL_CLEAE_DV_DATA,
			// Token: 0x040005D0 RID: 1488
			RDAC_GUI_FAIL_TO_RETRIEVE_DV_DATA,
			// Token: 0x040005D1 RID: 1489
			RDAC_GUI_FAIL_TO_SHOW,
			// Token: 0x040005D2 RID: 1490
			RDAC_GUI_FAIL_TO_SET,
			// Token: 0x040005D3 RID: 1491
			RDAC_GUI_FAIL_ACCESS_REG,
			// Token: 0x040005D4 RID: 1492
			RDAC_GUI_FAIL_PERFORM_LAYOUT,
			// Token: 0x040005D5 RID: 1493
			RDAC_GUI_FAIL_HTML_ACCESS,
			// Token: 0x040005D6 RID: 1494
			RDAC_GUI_FAIL_SAVE_LOG,
			// Token: 0x040005D7 RID: 1495
			RDAC_GUI_FAIL_CLEAR_LOG,
			// Token: 0x040005D8 RID: 1496
			RDAC_GUI_FAIL_READ_LOG,
			// Token: 0x040005D9 RID: 1497
			RDAC_GUI_WARN_MODIFIED,
			// Token: 0x040005DA RID: 1498
			RDAC_DV_WARN_MODIFIED,
			// Token: 0x040005DB RID: 1499
			RDAC_DV_WARN_WRITE_UPDATE_RATE,
			// Token: 0x040005DC RID: 1500
			RDAC_GUI_WARN_CLOSE,
			// Token: 0x040005DD RID: 1501
			RDAC_GUI_WARN_REGISTER_MULSYS,
			// Token: 0x040005DE RID: 1502
			RDAC_GUI_WARN_CHECK_ALARM,
			// Token: 0x040005DF RID: 1503
			RDAC_GUI_CONTROL_CLICK_FAILED,
			// Token: 0x040005E0 RID: 1504
			RDAC_GUI_FAIL_WRITE,
			// Token: 0x040005E1 RID: 1505
			RDAC_GUI_FAIL_RESET,
			// Token: 0x040005E2 RID: 1506
			RDAC_GUI_FAIL_RELOAD,
			// Token: 0x040005E3 RID: 1507
			RDAC_GUI_DV_FAIL_WRITE,
			// Token: 0x040005E4 RID: 1508
			RDAC_GUI_DV_FAIL_CANNOT_FOUND_VOTER,
			// Token: 0x040005E5 RID: 1509
			RDAC_GUI_FAIL_CLOSE,
			// Token: 0x040005E6 RID: 1510
			RDAC_GUI_WARN_CONFIGURE,
			// Token: 0x040005E7 RID: 1511
			RDAC_GUI_TIMER_EXPIRED,
			// Token: 0x040005E8 RID: 1512
			RDAC_GUI_FAIL_TO_RETRY,
			// Token: 0x040005E9 RID: 1513
			RDAC_GUI_INVALID_PARAM,
			// Token: 0x040005EA RID: 1514
			RDAC_GUI_WARN_SAVE,
			// Token: 0x040005EB RID: 1515
			RDAC_GUI_FAIL_OPEN_CONTROLLER,
			// Token: 0x040005EC RID: 1516
			RDAC_GUI_FAILED_TOLOAD_RANGEXML,
			// Token: 0x040005ED RID: 1517
			RDAC_GUI_FAIL_HANDLE_MODE,
			// Token: 0x040005EE RID: 1518
			RDAC_GUI_FAIL_HANDLE_GATEWAY_STATUS,
			// Token: 0x040005EF RID: 1519
			RDAC_GUI_FAIL_HANDLE_IP_PORT_CHANGED,
			// Token: 0x040005F0 RID: 1520
			RDAC_GUI_FAIL_GET_SPACE,
			// Token: 0x040005F1 RID: 1521
			RDAC_GUI_FAIL_GET_LOG,
			// Token: 0x040005F2 RID: 1522
			RDAC_GUI_WARN_SPACE,
			// Token: 0x040005F3 RID: 1523
			RDAC_GUI_CONFIRM_DEL_SYS,
			// Token: 0x040005F4 RID: 1524
			RDAC_GUI_CONFIRM_DEL_EMAIL,
			// Token: 0x040005F5 RID: 1525
			RDAC_GUI_SAME_SYS_NAME,
			// Token: 0x040005F6 RID: 1526
			RDAC_GUI_SYS_NAME_RESERVED,
			// Token: 0x040005F7 RID: 1527
			RDAC_GUI_SAME_SYSTEM,
			// Token: 0x040005F8 RID: 1528
			RDAC_GUI_SAME_LOCAL_PORT,
			// Token: 0x040005F9 RID: 1529
			RDAC_GUI_SAME_EMAIL,
			// Token: 0x040005FA RID: 1530
			RDAC_GUI_INVALID_FROM_EMAIL,
			// Token: 0x040005FB RID: 1531
			RDAC_GUI_INVALID_EMAIL,
			// Token: 0x040005FC RID: 1532
			RDAC_GUI_INVALID_SYS,
			// Token: 0x040005FD RID: 1533
			RDAC_GUI_MAX_SYS,
			// Token: 0x040005FE RID: 1534
			RDAC_GUI_MAX_EMAIL,
			// Token: 0x040005FF RID: 1535
			RDAC_GUI_MAX_TARGET_EMAIL,
			// Token: 0x04000600 RID: 1536
			RDAC_GUI_FAIL_LOAD_FROM_SYS,
			// Token: 0x04000601 RID: 1537
			RDAC_GUI_FAIL_UPDATE_SYS,
			// Token: 0x04000602 RID: 1538
			RDAC_GUI_FAIL_ADD_SYS,
			// Token: 0x04000603 RID: 1539
			RDAC_GUI_FAIL_DEL_SYS,
			// Token: 0x04000604 RID: 1540
			RDAC_GUI_FAIL_SAVE_SYS,
			// Token: 0x04000605 RID: 1541
			RDAC_GUI_MAX_CONNECT,
			// Token: 0x04000606 RID: 1542
			RDAC_GUI_SYS_NOT_EXIST,
			// Token: 0x04000607 RID: 1543
			RDAC_GUI_FAIL_SET_TAB_IMAGE,
			// Token: 0x04000608 RID: 1544
			RDAC_GUI_TOO_MANY_LOG,
			// Token: 0x04000609 RID: 1545
			RDAC_GUI_MAX_LOG_REACHED,
			// Token: 0x0400060A RID: 1546
			RDAC_GUI_CONFIRM_DEL_LOG,
			// Token: 0x0400060B RID: 1547
			RDAC_GUI_FAIL_SAVE_SMTP,
			// Token: 0x0400060C RID: 1548
			RDAC_GUI_FAIL_LOAD_SMTP,
			// Token: 0x0400060D RID: 1549
			RDAC_GUI_INVALUED_PARAM_SMTP,
			// Token: 0x0400060E RID: 1550
			RDAC_GUI_FAIL_LOAD_EMAIL_ADDRESS,
			// Token: 0x0400060F RID: 1551
			RDAC_GUI_FAIL_SEND_EMAIL,
			// Token: 0x04000610 RID: 1552
			RDAC_GUI_FAIL_LOAD_SYSTEM_BY_SPECIAL_ID,
			// Token: 0x04000611 RID: 1553
			RDAC_GUI_CONFIRM_TEST_EMAIL,
			// Token: 0x04000612 RID: 1554
			RDAC_GUI_SENT_TEST_EMAIL,
			// Token: 0x04000613 RID: 1555
			RDAC_GUI_FAIL_LOAD_FILTER,
			// Token: 0x04000614 RID: 1556
			RDAC_GUI_FAIL_LOAD_REPEATER_LOG,
			// Token: 0x04000615 RID: 1557
			RDAC_GUI_FAIL_FILTER_TABLE,
			// Token: 0x04000616 RID: 1558
			RDAC_GUI_FAIL_LOAD_CONTROL,
			// Token: 0x04000617 RID: 1559
			RDAC_GUI_FILTER_FAIL_CREATE,
			// Token: 0x04000618 RID: 1560
			RDAC_GUI_MAX_LOG_REACHED_DV,
			// Token: 0x04000619 RID: 1561
			RDAC_GUI_TOO_MANY_LOG_DV,
			// Token: 0x0400061A RID: 1562
			RDAC_SA_FAIL_OPEN_DATABASE,
			// Token: 0x0400061B RID: 1563
			RDAC_SA_FAIL_QUERY_DATABASE,
			// Token: 0x0400061C RID: 1564
			RDAC_SA_FAIL_UPDATE_DATABASE,
			// Token: 0x0400061D RID: 1565
			RDAC_SA_FAIL_DELETE_DATABASE,
			// Token: 0x0400061E RID: 1566
			RDAC_SA_FAIL_INSERT_DATABASE,
			// Token: 0x0400061F RID: 1567
			RDAC_SA_INVALID_PARAMETER,
			// Token: 0x04000620 RID: 1568
			RDAC_SA_EMPTY_QUERY_RESULT,
			// Token: 0x04000621 RID: 1569
			RDAC_SA_FAIL_OPERATE_QUERY_RESULT,
			// Token: 0x04000622 RID: 1570
			RDAC_REMOTE_INVALID_PARAMETERS,
			// Token: 0x04000623 RID: 1571
			RDAC_REMOTE_FAIL_CREATE,
			// Token: 0x04000624 RID: 1572
			RDAC_REMOTE_FAIL_INIT,
			// Token: 0x04000625 RID: 1573
			RDAC_REMOTE_FAIL_SEND,
			// Token: 0x04000626 RID: 1574
			RDAC_REMOTE_FAIL_ACTIVE,
			// Token: 0x04000627 RID: 1575
			RDAC_REMOTE_FAIL_NOTIFY,
			// Token: 0x04000628 RID: 1576
			RDAC_REMOTE_FAIL_METHOD,
			// Token: 0x04000629 RID: 1577
			RDAC_REMOTE_FAIL_CLOSE,
			// Token: 0x0400062A RID: 1578
			RDAC_REMOTE_FAIL_HOOK,
			// Token: 0x0400062B RID: 1579
			RDAC_REMOTE_FAIL_APPLICATION,
			// Token: 0x0400062C RID: 1580
			RDAC_SHARED_FAIL_NOTIFY,
			// Token: 0x0400062D RID: 1581
			RDAC_SHARED_FAIL_METHOD,
			// Token: 0x0400062E RID: 1582
			RDAC_HOST_FAIL_INIT,
			// Token: 0x0400062F RID: 1583
			RDAC_HOST_FAIL_REGISTER,
			// Token: 0x04000630 RID: 1584
			RDAC_HOST_FAIL_UNREGISTER,
			// Token: 0x04000631 RID: 1585
			RDAC_HOST_FAIL_CREATE,
			// Token: 0x04000632 RID: 1586
			RDAC_HOST_FAIL_GENERATE,
			// Token: 0x04000633 RID: 1587
			RDAC_HOST_FAIL_NOTIFY,
			// Token: 0x04000634 RID: 1588
			RDAC_METHOD_NOT_IMPL,
			// Token: 0x04000635 RID: 1589
			RDAC_LOG_FAILED_TO_LOAD_FORM = 4463,
			// Token: 0x04000636 RID: 1590
			RDAC_LOG_FAILED_TO_LOAD_DATA,
			// Token: 0x04000637 RID: 1591
			RDAC_LOG_DATAGRID_CELLVALUENEEDED_FAILED,
			// Token: 0x04000638 RID: 1592
			RDAC_LOG_PRINT_FAILED,
			// Token: 0x04000639 RID: 1593
			RDAC_LOG_PRINT_PREVIEW_FAILED,
			// Token: 0x0400063A RID: 1594
			RDAC_LOG_FILE_ACCESS_FAIL,
			// Token: 0x0400063B RID: 1595
			RDAC_LOG_EMAIL_FAILED,
			// Token: 0x0400063C RID: 1596
			RDAC_LOG_EXPORT_EXCEL_FAILED,
			// Token: 0x0400063D RID: 1597
			RDAC_LOG_SAVEAS_FAILED,
			// Token: 0x0400063E RID: 1598
			RDAC_LOG_SYSTEMLISTCOMBOBO_ERROR,
			// Token: 0x0400063F RID: 1599
			RDAC_LOG_DATECHECKBOX_ERROR,
			// Token: 0x04000640 RID: 1600
			RDAC_LOG_DATAGRIDVIEW_REFRESH_ERROR,
			// Token: 0x04000641 RID: 1601
			RDAC_LOG_STARTDATEPICKER_ERROR,
			// Token: 0x04000642 RID: 1602
			RDAC_LOG_ENDDATEPICKER_ERROR,
			// Token: 0x04000643 RID: 1603
			RDAC_LOG_REFRESH_PICKER_ERROR,
			// Token: 0x04000644 RID: 1604
			RDAC_LOG_TABLELIBRARY_HEADER_ERROR,
			// Token: 0x04000645 RID: 1605
			RDAC_LOG_TABLELIBRARY_GETLOGROW_ERROR,
			// Token: 0x04000646 RID: 1606
			RDAC_LOG_TABLELIBRARY_LOG_HTML_ERROR,
			// Token: 0x04000647 RID: 1607
			RDAC_GUI_PARSE_XML_ERROR,
			// Token: 0x04000648 RID: 1608
			RDAC_LOG_RESOURCE_FILE_FAIL,
			// Token: 0x04000649 RID: 1609
			RDAC_LOG_COLUMN_HEADER_CLICK_FAIL,
			// Token: 0x0400064A RID: 1610
			RDAC_LOG_COLUMN_SORT_FAIL,
			// Token: 0x0400064B RID: 1611
			RDAC_LOG_FAILED_TO_SAVE,
			// Token: 0x0400064C RID: 1612
			RDAC_LOG_FAILED_TO_SET_DATA_CACHE,
			// Token: 0x0400064D RID: 1613
			RDAC_LOG_HTML_CONVERSION_FAILED,
			// Token: 0x0400064E RID: 1614
			RDAC_LOG_PARSE_RESPONSE_ERROR,
			// Token: 0x0400064F RID: 1615
			P2P_OUT_OF_MEMORY = 4532,
			// Token: 0x04000650 RID: 1616
			P2P_LOCAL_INIT_FAILED,
			// Token: 0x04000651 RID: 1617
			P2P_START_LE_FAILED,
			// Token: 0x04000652 RID: 1618
			P2P_STOP_LE_FAILED,
			// Token: 0x04000653 RID: 1619
			P2P_MUTEX_FAILURE,
			// Token: 0x04000654 RID: 1620
			P2P_EVENT_FAILURE,
			// Token: 0x04000655 RID: 1621
			P2P_SEND_MESSAGE_FAILURE,
			// Token: 0x04000656 RID: 1622
			P2P_RECV_MESSAGE_FAILURE,
			// Token: 0x04000657 RID: 1623
			P2P_PORT_IN_USE,
			// Token: 0x04000658 RID: 1624
			P2P_UNSUPPORTED_MESSAGE_UNPACK,
			// Token: 0x04000659 RID: 1625
			P2P_UNSUPPORTED_MESSAGE_SEND,
			// Token: 0x0400065A RID: 1626
			P2P_UNSUPPORTED_MESSAGE_RECV,
			// Token: 0x0400065B RID: 1627
			P2P_FAILED_TO_ADD_AUTH,
			// Token: 0x0400065C RID: 1628
			P2P_FAILED_TO_REMOVE_AUTH,
			// Token: 0x0400065D RID: 1629
			P2P_PROXY_CONNECT_FAILED,
			// Token: 0x0400065E RID: 1630
			P2P_PROXY_INCORRECT_PEER,
			// Token: 0x0400065F RID: 1631
			IP_DNS_ADDRESS_INVALID = 4582,
			// Token: 0x04000660 RID: 1632
			DNS_CONNECT_FAIL,
			// Token: 0x04000661 RID: 1633
			RDAC_DNS_IPADDRESS_INVALID,
			// Token: 0x04000662 RID: 1634
			RCMP_ERROR_RESULT_FAILURE = 4632,
			// Token: 0x04000663 RID: 1635
			RCMP_ERROR_RESULT_INCORRECT_MODE,
			// Token: 0x04000664 RID: 1636
			RCMP_ERROR_RESULT_UNPACK_REPLY_FAILURE,
			// Token: 0x04000665 RID: 1637
			RCMP_ERROR_RESULT_BUSY,
			// Token: 0x04000666 RID: 1638
			RCMP_ERROR_RESULT_OPCODE_NOT_SUPPORTED,
			// Token: 0x04000667 RID: 1639
			RCMP_ERROR_RESULT_INVALID_PARAMETER,
			// Token: 0x04000668 RID: 1640
			RCMP_ERROR_RESULT_SECURITY_LOCKED,
			// Token: 0x04000669 RID: 1641
			RCMP_ERROR_RESULT_SOFTPOT_OPERATION_NOT_SUPPORTED,
			// Token: 0x0400066A RID: 1642
			RCMP_ERROR_RESULT_SOFTPOT_TYPE_NOT_SUPPORTED,
			// Token: 0x0400066B RID: 1643
			RCMP_ERROR_RESULT_SOFTPOT_VALUE_OUT_OF_RANGE,
			// Token: 0x0400066C RID: 1644
			RCMP_ERROR_RESULT_FLASH_WRITE_FAILURE,
			// Token: 0x0400066D RID: 1645
			RCMP_ERROR_RESULT_ISH_ITEM_NOT_FOUND,
			// Token: 0x0400066E RID: 1646
			RCMP_ERROR_RESULT_ISH_OFFSET_OUT_OF_RANGE,
			// Token: 0x0400066F RID: 1647
			RCMP_ERROR_RESULT_ISH_INSUFFICIENT_PARTITION_SPACE,
			// Token: 0x04000670 RID: 1648
			RCMP_ERROR_RESULT_ISH_PARTITION_DOES_NOT_EXIST,
			// Token: 0x04000671 RID: 1649
			RCMP_ERROR_RESULT_ISH_PARTITION_READ_ONLY,
			// Token: 0x04000672 RID: 1650
			RCMP_ERROR_RESULT_ISH_REORG_NEEDED,
			// Token: 0x04000673 RID: 1651
			RCMP_ERROR_RESULT_BUFFER_SIZE_NOT_ENOUGH,
			// Token: 0x04000674 RID: 1652
			RCMP_ERROR_RESULT_REPLY_TOO_BIG,
			// Token: 0x04000675 RID: 1653
			RCMP_GENERICFAILURE,
			// Token: 0x04000676 RID: 1654
			RCMP_OUTOFMEMORY,
			// Token: 0x04000677 RID: 1655
			RCMP_UNPACK_FAILURE,
			// Token: 0x04000678 RID: 1656
			RCMP_MUTEX_ERROR,
			// Token: 0x04000679 RID: 1657
			RCMP_READ_BRDCST_ERROR,
			// Token: 0x0400067A RID: 1658
			RCMP_WRITE_BRDCST_ERROR,
			// Token: 0x0400067B RID: 1659
			RCMP_WRITE_STATUS_BRDCST_ERROR,
			// Token: 0x0400067C RID: 1660
			RCMP_PSDT_STATUS_BRDCST_ERROR,
			// Token: 0x0400067D RID: 1661
			UPDATE_ADAPTER_INVALID_PARAMETER = 4682,
			// Token: 0x0400067E RID: 1662
			UPDATE_ADAPTER_LZMA_DECOMPRESS_ERROR,
			// Token: 0x0400067F RID: 1663
			UPDATE_ADAPTER_LZMA_COMPRESS_ERROR,
			// Token: 0x04000680 RID: 1664
			CPS_RP_LOG_FAILED_TO_LOAD_FORM = 4702,
			// Token: 0x04000681 RID: 1665
			CPS_RP_LOG_FAILED_TO_LOAD_DATA,
			// Token: 0x04000682 RID: 1666
			CPS_RP_LOG_DATAGRID_CELLVALUENEEDED_FAILED,
			// Token: 0x04000683 RID: 1667
			CPS_RP_LOG_PRINT_FAILED,
			// Token: 0x04000684 RID: 1668
			CPS_RP_LOG_PRINT_PREVIEW_FAILED,
			// Token: 0x04000685 RID: 1669
			CPS_RP_LOG_FILE_ACCESS_FAIL,
			// Token: 0x04000686 RID: 1670
			CPS_RP_LOG_EMAIL_FAILED,
			// Token: 0x04000687 RID: 1671
			CPS_RP_LOG_EXPORT_EXCEL_FAILED,
			// Token: 0x04000688 RID: 1672
			CPS_RP_LOG_SAVEAS_FAILED,
			// Token: 0x04000689 RID: 1673
			CPS_RP_LOG_SYSTEMLISTCOMBOBO_ERROR,
			// Token: 0x0400068A RID: 1674
			CPS_RP_LOG_DATECHECKBOX_ERROR,
			// Token: 0x0400068B RID: 1675
			CPS_RP_LOG_DATAGRIDVIEW_REFRESH_ERROR,
			// Token: 0x0400068C RID: 1676
			CPS_RP_LOG_STARTDATEPICKER_ERROR,
			// Token: 0x0400068D RID: 1677
			CPS_RP_LOG_ENDDATEPICKER_ERROR,
			// Token: 0x0400068E RID: 1678
			CPS_RP_LOG_REFRESH_PICKER_ERROR,
			// Token: 0x0400068F RID: 1679
			CPS_RP_LOG_TABLELIBRARY_HEADER_ERROR,
			// Token: 0x04000690 RID: 1680
			CPS_RP_LOG_TABLELIBRARY_GETLOGROW_ERROR,
			// Token: 0x04000691 RID: 1681
			CPS_RP_LOG_TABLELIBRARY_LOG_HTML_ERROR,
			// Token: 0x04000692 RID: 1682
			CPS_RP_GUI_PARSE_XML_ERROR,
			// Token: 0x04000693 RID: 1683
			CPS_RP_LOG_RESOURCE_FILE_FAIL,
			// Token: 0x04000694 RID: 1684
			CPS_RP_LOG_COLUMN_HEADER_CLICK_FAIL,
			// Token: 0x04000695 RID: 1685
			CPS_RP_LOG_COLUMN_SORT_FAIL,
			// Token: 0x04000696 RID: 1686
			CPS_RP_LOG_FAILED_TO_SAVE,
			// Token: 0x04000697 RID: 1687
			CPS_RP_LOG_FAILED_TO_SET_DATA_CACHE,
			// Token: 0x04000698 RID: 1688
			CPS_RP_LOG_HTML_CONVERSION_FAILED,
			// Token: 0x04000699 RID: 1689
			CPS_RP_LOG_PARSE_RESPONSE_ERROR,
			// Token: 0x0400069A RID: 1690
			CPS_RP_GUI_TOO_MANY_LOG,
			// Token: 0x0400069B RID: 1691
			CPS_RP_GUI_MAX_LOG_REACHED,
			// Token: 0x0400069C RID: 1692
			CPS_RP_GUI_CONFIRM_DEL_LOG,
			// Token: 0x0400069D RID: 1693
			CPS_RP_SA_FAIL_OPEN_DATABASE,
			// Token: 0x0400069E RID: 1694
			CPS_RP_SA_FAIL_QUERY_DATABASE,
			// Token: 0x0400069F RID: 1695
			CPS_RP_SA_FAIL_UPDATE_DATABASE,
			// Token: 0x040006A0 RID: 1696
			CPS_RP_SA_FAIL_DELETE_DATABASE,
			// Token: 0x040006A1 RID: 1697
			CPS_RP_SA_FAIL_INSERT_DATABASE,
			// Token: 0x040006A2 RID: 1698
			CPS_RP_SA_INVALID_PARAMETER,
			// Token: 0x040006A3 RID: 1699
			CPS_RP_SA_EMPTY_QUERY_RESULT,
			// Token: 0x040006A4 RID: 1700
			CPS_RP_SA_FAIL_OPERATE_QUERY_RESULT,
			// Token: 0x040006A5 RID: 1701
			CPS_RP_CP_NEW_OPR_FAILED,
			// Token: 0x040006A6 RID: 1702
			RNL_CLOSE_NOT_REQUIRED = 4752,
			// Token: 0x040006A7 RID: 1703
			RNL_NOT_INITIALIZED,
			// Token: 0x040006A8 RID: 1704
			RNL_MUTEX_FAILURE,
			// Token: 0x040006A9 RID: 1705
			RNL_OS_FAILURE,
			// Token: 0x040006AA RID: 1706
			RNL_SEND_MESSAGE_FAILURE,
			// Token: 0x040006AB RID: 1707
			RNL_RECV_MESSAGE_FAILURE,
			// Token: 0x040006AC RID: 1708
			RNL_INVALID_DATA,
			// Token: 0x040006AD RID: 1709
			RNL_CONNECT_FAILURE,
			// Token: 0x040006AE RID: 1710
			RNL_ALREADY_CONNECTED,
			// Token: 0x040006AF RID: 1711
			RNL_INVALID_ARGUMENT,
			// Token: 0x040006B0 RID: 1712
			RNL_GENERICFAILURE,
			// Token: 0x040006B1 RID: 1713
			RNL_OUTOFMEMORY,
			// Token: 0x040006B2 RID: 1714
			RNL_RADIO_TYPE_MISMATCH,
			// Token: 0x040006B3 RID: 1715
			RNL_COPYNOTALLOWED,
			// Token: 0x040006B4 RID: 1716
			RNL_ASSINGNOTALLOWED,
			// Token: 0x040006B5 RID: 1717
			RNL_CONNECTION_ABORT,
			// Token: 0x040006B6 RID: 1718
			FEATUREBIT_NOTINI = 4784,
			// Token: 0x040006B7 RID: 1719
			FEATUREBIT_INVALIDVAL,
			// Token: 0x040006B8 RID: 1720
			DBACCESS_DB_INIT_FAILED = 4832,
			// Token: 0x040006B9 RID: 1721
			DBACCESS_DB_UPGRADE_FAILED,
			// Token: 0x040006BA RID: 1722
			DBACCESS_DB_CREATE_TABLE_FAILED,
			// Token: 0x040006BB RID: 1723
			DBACCESS_DB_OPEN_CONNECTION_FAILED,
			// Token: 0x040006BC RID: 1724
			DBACCESS_DB_CREATION_FAILED,
			// Token: 0x040006BD RID: 1725
			DBACCESS_DB_QUERY_FAILED,
			// Token: 0x040006BE RID: 1726
			DBACCESS_LICENSEDB_INVALID_HOST_ID,
			// Token: 0x040006BF RID: 1727
			DBACCESS_LICENSEDB_HOST_ID_ALREADY_EXISTS,
			// Token: 0x040006C0 RID: 1728
			DBACCESS_LICENSEDB_SET_HOST_ID_FAILED,
			// Token: 0x040006C1 RID: 1729
			DBACCESS_LICENSEDB_UPDATE_DB_FAILED,
			// Token: 0x040006C2 RID: 1730
			DBACCESS_LICENSEDB_DB_INVALID_DATA,
			// Token: 0x040006C3 RID: 1731
			DBACCESS_LICENSEDB_QUERY_DB_FAILED,
			// Token: 0x040006C4 RID: 1732
			DBACCESS_LICENSEDB_GENERIC_ERROR,
			// Token: 0x040006C5 RID: 1733
			MSG_QUEST_BLANK_DEVICE = 4609,
			// Token: 0x040006C6 RID: 1734
			BLANK_DEVICE_SUCCESSFULL,
			// Token: 0x040006C7 RID: 1735
			UNKILL_RADIO_SUCCESSFULL,
			// Token: 0x040006C8 RID: 1736
			LABEL_AND_DEVICE_VALUE_NOT_MATCH = 4865,
			// Token: 0x040006C9 RID: 1737
			RADIOINFOCFG_NOT_FOUND,
			// Token: 0x040006CA RID: 1738
			RADIOLANGCFG_NOT_FOUND,
			// Token: 0x040006CB RID: 1739
			MAPPINGFILE_NOT_FOUND,
			// Token: 0x040006CC RID: 1740
			TANAPA_TO_CONFIGFILE_MAPPING_NOT_FOUND,
			// Token: 0x040006CD RID: 1741
			DUPLICATE_TANAPA_TO_CONFIGFILE_MAPPING_FOUND,
			// Token: 0x040006CE RID: 1742
			DEVICE_NOT_FOUND = 4897,
			// Token: 0x040006CF RID: 1743
			LOG_INSUFFICIENT_DISK,
			// Token: 0x040006D0 RID: 1744
			LOG_DIRECTORY_NOT_FOUND,
			// Token: 0x040006D1 RID: 1745
			USERSETTINGFILE_NOT_FOUND,
			// Token: 0x040006D2 RID: 1746
			INVALID_FILE_PATH_SETTING_NODE,
			// Token: 0x040006D3 RID: 1747
			LANGPACK_NOT_FOUND_IN_RADIO,
			// Token: 0x040006D4 RID: 1748
			CAPACITY_MAX_NOT_SUPPORTED = 4961,
			// Token: 0x040006D5 RID: 1749
			CMDCPS_INVALID_ARGUMENTS = 5376,
			// Token: 0x040006D6 RID: 1750
			CMDCPS_INVALID_PBAFILE,
			// Token: 0x040006D7 RID: 1751
			CMDCPS_TEMPLATE_INVALID,
			// Token: 0x040006D8 RID: 1752
			CMDCPS_CANNOT_READ_PBA,
			// Token: 0x040006D9 RID: 1753
			CMDCPS_CANNOT_GET_FIELD_VALUE,
			// Token: 0x040006DA RID: 1754
			CMDCPS_CANNOT_SET_FIELD_VALUE,
			// Token: 0x040006DB RID: 1755
			CMDCPS_CANNOT_READ_ARCHIVE,
			// Token: 0x040006DC RID: 1756
			CMDCPS_ERROR_CLONE,
			// Token: 0x040006DD RID: 1757
			CMDCPS_CANNOT_GEN_WRITEVALID_FILED,
			// Token: 0x040006DE RID: 1758
			CMDCPS_ERROR_DIFFERENTIAL_WRITE,
			// Token: 0x040006DF RID: 1759
			CMDCPS_UNKNOWN_ERROR,
			// Token: 0x040006E0 RID: 1760
			CMDCPS_CONVERT_WRTIE_TO_FULL_PBA_FAILED,
			// Token: 0x040006E1 RID: 1761
			CMDCPS_DECODE_PBA_FAILED,
			// Token: 0x040006E2 RID: 1762
			CMDCPS_ENCODE_PBA_FAILED,
			// Token: 0x040006E3 RID: 1763
			CMDCPS_CLONE_FAILED,
			// Token: 0x040006E4 RID: 1764
			CMDCPS_READ_ARCHIVE_FAILED,
			// Token: 0x040006E5 RID: 1765
			CMDCPS_READ_PBA_FAILED,
			// Token: 0x040006E6 RID: 1766
			CMDCPS_SAVE_ARCHIVE_FAILED,
			// Token: 0x040006E7 RID: 1767
			CMDCPS_POPULATE_COLUMNS_FAILED,
			// Token: 0x040006E8 RID: 1768
			CMDCPS_ERROR_UNSUPPORTEDMODEL,
			// Token: 0x040006E9 RID: 1769
			CMDCPS_ERROR_UNKNOWN_FW_TYPE,
			// Token: 0x040006EA RID: 1770
			CMDCPS_CANNOT_CLONE_ANALOG_CHANNEL_TO_DIGITAL_ONLY_DEVICE = 5414,
			// Token: 0x040006EB RID: 1771
			COMMON_ERROR = 8192
		}
	}
}
