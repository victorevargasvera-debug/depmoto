using System;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.TetraUtility
{
	// Token: 0x02000002 RID: 2
	[global::System.Serializable]
	public sealed class CCustomException : global::System.Exception
	{
		// Token: 0x06000001 RID: 1 RVA: 0x000020D0 File Offset: 0x000002D0
		public CCustomException()
		{
		}

		// Token: 0x06000002 RID: 2 RVA: 0x000020E3 File Offset: 0x000002E3
		public CCustomException(string errorID)
		{
			this.ErrorID = errorID;
		}

		// Token: 0x06000003 RID: 3 RVA: 0x000020FD File Offset: 0x000002FD
		public CCustomException(string errorID, string message) : base(message)
		{
			this.ErrorID = errorID;
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002118 File Offset: 0x00000318
		public CCustomException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x06000005 RID: 5 RVA: 0x0000212D File Offset: 0x0000032D
		public CCustomException(string errorID, string message, global::System.Exception innerException) : base(message, innerException)
		{
			this.ErrorID = errorID;
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002149 File Offset: 0x00000349
		public CCustomException(string errorID, string message, global::System.Exception innerException, object infoToAdd) : base(message, innerException)
		{
			this.ErrorID = errorID;
			this.tag = infoToAdd;
		}

		// Token: 0x06000007 RID: 7 RVA: 0x0000216D File Offset: 0x0000036D
		public CCustomException(string errorID, string message, object infoToAdd) : base(message)
		{
			this.ErrorID = errorID;
			this.tag = infoToAdd;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x0000218F File Offset: 0x0000038F
		private CCustomException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000009 RID: 9 RVA: 0x000021A4 File Offset: 0x000003A4
		// (set) Token: 0x0600000A RID: 10 RVA: 0x000021AC File Offset: 0x000003AC
		public string ErrorID
		{
			get
			{
				return this.errorID;
			}
			set
			{
				this.errorID = value;
				if (!global::Motorola.Common.Communication.TetraUtility.CCustomException.IsLegalErrorID(value))
				{
					this.errorID = "ST0000" + this.errorID;
				}
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000B RID: 11 RVA: 0x000021D3 File Offset: 0x000003D3
		public string ErrorNum
		{
			get
			{
				return this.ErrorID.Substring(0, global::Motorola.Common.Communication.TetraUtility.CCustomException.CodeLen);
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000C RID: 12 RVA: 0x000021E6 File Offset: 0x000003E6
		public string ErrorCode
		{
			get
			{
				return this.errorID.Substring(global::Motorola.Common.Communication.TetraUtility.CCustomException.CodeLen, this.errorID.Length - global::Motorola.Common.Communication.TetraUtility.CCustomException.CodeLen);
			}
		}

		// Token: 0x0600000D RID: 13 RVA: 0x0000220C File Offset: 0x0000040C
		public static bool IsLegalErrorID(string errorID)
		{
			uint num;
			return errorID.Length >= global::Motorola.Common.Communication.TetraUtility.CCustomException.CodeLen && uint.TryParse(errorID.Substring(2, global::Motorola.Common.Communication.TetraUtility.CCustomException.CodeLen - 2), out num);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002240 File Offset: 0x00000440
		public static string GetErrorCode(string errorID)
		{
			if (global::Motorola.Common.Communication.TetraUtility.CCustomException.IsLegalErrorID(errorID))
			{
				return errorID.Substring(0, global::Motorola.Common.Communication.TetraUtility.CCustomException.CodeLen);
			}
			return "ST0000";
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000F RID: 15 RVA: 0x0000225C File Offset: 0x0000045C
		public char PlatFormSection
		{
			get
			{
				return this.ErrorID.ToCharArray()[this.ErrorID.Length - global::Motorola.Common.Communication.TetraUtility.CCustomException.CodeLen];
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000010 RID: 16 RVA: 0x0000227B File Offset: 0x0000047B
		public char ComponentSection
		{
			get
			{
				return this.ErrorID.ToCharArray()[this.ErrorID.Length - 4];
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000011 RID: 17 RVA: 0x00002296 File Offset: 0x00000496
		public string InitialSection
		{
			get
			{
				return this.ErrorID.Substring(this.ErrorID.Length - global::Motorola.Common.Communication.TetraUtility.CCustomException.CodeLen, 2);
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000012 RID: 18 RVA: 0x000022B5 File Offset: 0x000004B5
		public string ErrorSection
		{
			get
			{
				return this.ErrorID.Substring(this.ErrorID.Length - 3, 3);
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000013 RID: 19 RVA: 0x000022D0 File Offset: 0x000004D0
		// (set) Token: 0x06000014 RID: 20 RVA: 0x000022D8 File Offset: 0x000004D8
		public object Tag
		{
			get
			{
				return this.tag;
			}
			set
			{
				this.tag = value;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000015 RID: 21 RVA: 0x000022E1 File Offset: 0x000004E1
		private static int CodeLen
		{
			get
			{
				return "ST0000".Length;
			}
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000022ED File Offset: 0x000004ED
		public override void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			base.GetObjectData(info, context);
		}

		// Token: 0x04000001 RID: 1
		public const string UnAssignedCode = "ST0000";

		// Token: 0x04000002 RID: 2
		public const string ErrorUnAssigned00000 = "ST0000_UnAssigned";

		// Token: 0x04000003 RID: 3
		private const int ErrorIdPrefixLen = 2;

		// Token: 0x04000004 RID: 4
		public const string PlatFormCode = "0";

		// Token: 0x04000005 RID: 5
		public const string AppCode = "1";

		// Token: 0x04000006 RID: 6
		private string errorID = string.Empty;

		// Token: 0x04000007 RID: 7
		private object tag;
	}
}
