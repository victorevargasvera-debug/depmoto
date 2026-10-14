using System;
using System.Collections;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.TetraSecurity
{
	// Token: 0x02000002 RID: 2
	[global::System.Serializable]
	public class CSecureException : global::System.Exception
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000001 RID: 1 RVA: 0x000020D0 File Offset: 0x000010D0
		// (set) Token: 0x06000002 RID: 2 RVA: 0x000020D8 File Offset: 0x000010D8
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Category("Customization")]
		[global::System.ComponentModel.DefaultValue(0)]
		[global::System.ComponentModel.Description("Specifies the Error ID for the exception.")]
		public uint ErrorID
		{
			get
			{
				return this.errorID;
			}
			set
			{
				this.errorID = value;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000003 RID: 3 RVA: 0x000020E1 File Offset: 0x000010E1
		// (set) Token: 0x06000004 RID: 4 RVA: 0x000020E9 File Offset: 0x000010E9
		[global::System.ComponentModel.Category("Customization")]
		[global::System.ComponentModel.Description("Specifies the Exceptions.")]
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Collections.ArrayList ExceptionList
		{
			get
			{
				return this.alExceptions;
			}
			set
			{
				this.alExceptions = value;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000005 RID: 5 RVA: 0x000020F2 File Offset: 0x000010F2
		// (set) Token: 0x06000006 RID: 6 RVA: 0x000020FA File Offset: 0x000010FA
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Category("Customization")]
		[global::System.ComponentModel.DefaultValue(0)]
		[global::System.ComponentModel.Description("Specifies the count of updates done before the exception.")]
		public uint pBarCount
		{
			get
			{
				return this.pBarUpdates;
			}
			set
			{
				this.pBarUpdates = value;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000007 RID: 7 RVA: 0x00002103 File Offset: 0x00001103
		// (set) Token: 0x06000008 RID: 8 RVA: 0x0000210B File Offset: 0x0000110B
		[global::System.ComponentModel.DefaultValue("")]
		[global::System.ComponentModel.Category("Customization")]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Description("Specifies the Message for the exception.")]
		public string serialNumber
		{
			get
			{
				return this.serialNo;
			}
			set
			{
				this.serialNo = value;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000009 RID: 9 RVA: 0x00002114 File Offset: 0x00001114
		// (set) Token: 0x0600000A RID: 10 RVA: 0x0000211C File Offset: 0x0000111C
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Category("Customization")]
		[global::System.ComponentModel.DefaultValue("")]
		[global::System.ComponentModel.Description("Specifies the Message for the exception.")]
		public string exMessage
		{
			get
			{
				return this.message;
			}
			set
			{
				this.message = value;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000B RID: 11 RVA: 0x00002125 File Offset: 0x00001125
		// (set) Token: 0x0600000C RID: 12 RVA: 0x0000212D File Offset: 0x0000112D
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DefaultValue("")]
		[global::System.ComponentModel.Description("Specifies the StackTrace for the exception.")]
		[global::System.ComponentModel.Category("Customization")]
		public string exStackTrace
		{
			get
			{
				return this.stackTrace;
			}
			set
			{
				this.stackTrace = value;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600000D RID: 13 RVA: 0x00002136 File Offset: 0x00001136
		// (set) Token: 0x0600000E RID: 14 RVA: 0x0000213E File Offset: 0x0000113E
		[global::System.ComponentModel.Description("Specifies the Source for the exception.")]
		[global::System.ComponentModel.DefaultValue("")]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Category("Customization")]
		public string exSource
		{
			get
			{
				return this.source;
			}
			set
			{
				this.source = value;
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002147 File Offset: 0x00001147
		public CSecureException()
		{
			this.errorID = 0U;
			this.message = string.Empty;
			this.stackTrace = string.Empty;
			this.source = string.Empty;
			this.alExceptions = new global::System.Collections.ArrayList();
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002182 File Offset: 0x00001182
		public CSecureException(string message) : base(message)
		{
			this.errorID = 0U;
			this.stackTrace = string.Empty;
			this.source = string.Empty;
			this.alExceptions = new global::System.Collections.ArrayList();
			this.message = message;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000021BA File Offset: 0x000011BA
		public CSecureException(string message, global::System.Exception innerException) : base(message, innerException)
		{
			this.errorID = 0U;
			this.stackTrace = string.Empty;
			this.source = string.Empty;
			this.alExceptions = new global::System.Collections.ArrayList();
			this.message = message;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000021F3 File Offset: 0x000011F3
		public CSecureException(uint uErrorId, string _source, string _message, string trace)
		{
			this.errorID = uErrorId;
			this.source = _source;
			this.message = _message;
			this.stackTrace = trace;
			this.alExceptions = new global::System.Collections.ArrayList();
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002223 File Offset: 0x00001223
		protected CSecureException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002230 File Offset: 0x00001230
		public static void RemoveErrorID(global::System.Exception ex, ref string s)
		{
			if (ex.Source != null)
			{
				string text = ex.Source;
				int num = text.IndexOf("|", 0, global::System.StringComparison.Ordinal);
				if (num != -1)
				{
					s = text.Substring(0, num);
					text = text.Substring(num + 1, text.Length - (num + 1));
					ex.Source = text;
					return;
				}
				s = 2629.ToString();
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002294 File Offset: 0x00001294
		public static bool CheckErrorIDExsists(global::System.Exception ex)
		{
			if (ex.Source != null)
			{
				string text = ex.Source;
				int num = text.IndexOf("|", 0, global::System.StringComparison.Ordinal);
				if (num != -1)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000022C8 File Offset: 0x000012C8
		public static void ParseException(global::System.Exception ex, ref uint uError, ref string sSource, ref string sMessage, ref string sStackTrace)
		{
			if (ex.GetType().FullName.Equals("custom_exception.CCustomException"))
			{
				global::Motorola.Common.Communication.TetraSecurity.CSecureException ex2 = (global::Motorola.Common.Communication.TetraSecurity.CSecureException)ex;
				string text = ex2.message;
				global::System.Collections.ArrayList arrayList = new global::System.Collections.ArrayList();
				while (text.Length > 0)
				{
					int num = text.IndexOf("|", 0, global::System.StringComparison.Ordinal);
					if (num == -1)
					{
						break;
					}
					arrayList.Add(text.Substring(0, num));
					text = text.Substring(num + 1, text.Length - (num + 1));
				}
				if (arrayList.Count >= 4)
				{
					uError = global::System.Convert.ToUInt32(arrayList[0]);
					sSource = arrayList[1].ToString();
					sMessage = arrayList[2].ToString();
					sStackTrace = arrayList[3].ToString();
					return;
				}
			}
			else
			{
				string empty = string.Empty;
				global::Motorola.Common.Communication.TetraSecurity.CSecureException.RemoveErrorID(ex, ref empty);
				uError = global::System.Convert.ToUInt32(empty);
				sSource = ex.Source;
				sMessage = ex.Message;
				sStackTrace = string.Empty;
				global::System.Collections.ArrayList arrayList2 = new global::System.Collections.ArrayList();
				for (global::System.Exception ex3 = ex; ex3 != null; ex3 = ex3.InnerException)
				{
					string value = ex3.StackTrace.ToString();
					arrayList2.Add(value);
				}
				int count = arrayList2.Count;
				for (int i = count - 1; i >= 0; i--)
				{
					sStackTrace += global::System.Environment.NewLine;
					sStackTrace += (string)arrayList2[i];
				}
				sStackTrace += global::System.Environment.NewLine;
			}
		}

		// Token: 0x06000017 RID: 23 RVA: 0x0000243C File Offset: 0x0000143C
		public static string MapErrorIdToString(int ErrorID)
		{
			return ((global::Motorola.Common.Communication.TetraSecurity.CSecureExceptionHRESULT)ErrorID).ToString();
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002458 File Offset: 0x00001458
		public static uint GetErrorID(global::System.Exception ex)
		{
			if (ex.Source == null)
			{
				return 0U;
			}
			string text = ex.Source;
			int num = text.IndexOf("|", 0, global::System.StringComparison.Ordinal);
			if (num != -1)
			{
				return global::System.Convert.ToUInt32(text.Substring(0, num - 1));
			}
			return 0U;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x0000249C File Offset: 0x0000149C
		public static void Rethrow(global::System.Exception ex)
		{
			throw new global::Motorola.Common.Communication.TetraSecurity.CSecureException(ex.Message, ex)
			{
				Source = ex.Source
			};
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000024C3 File Offset: 0x000014C3
		public static bool IsInternalID(uint ErrorID)
		{
			return ErrorID >= 4096U;
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000024D0 File Offset: 0x000014D0
		public override void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			base.GetObjectData(info, context);
		}

		// Token: 0x04000001 RID: 1
		private const string CLASS_NAME = "custom_exception.CCustomException";

		// Token: 0x04000002 RID: 2
		private uint errorID;

		// Token: 0x04000003 RID: 3
		private string message;

		// Token: 0x04000004 RID: 4
		private string stackTrace;

		// Token: 0x04000005 RID: 5
		private string source;

		// Token: 0x04000006 RID: 6
		private string serialNo;

		// Token: 0x04000007 RID: 7
		private uint pBarUpdates;

		// Token: 0x04000008 RID: 8
		private global::System.Collections.ArrayList alExceptions;
	}
}
