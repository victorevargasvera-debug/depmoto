using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Text;

namespace FDISystem
{
	// Token: 0x02000002 RID: 2
	[global::System.Serializable]
	public sealed class FDIException : global::System.Exception, global::System.Runtime.Serialization.ISerializable
	{
		// Token: 0x060001BB RID: 443 RVA: 0x00001430 File Offset: 0x00000830
		private FDIException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			this._errorCode = (global::FDISystem.FDIErrorCodes)info.GetInt32(global::FDISystem.FDIException.ErrorCodeSerializedName);
		}

		// Token: 0x060001BC RID: 444 RVA: 0x000014F4 File Offset: 0x000008F4
		public FDIException(global::FDISystem.FDIErrorCodes errorCode, string errorMessage) : base(errorMessage)
		{
			this._errorCode = errorCode;
		}

		// Token: 0x060001BD RID: 445 RVA: 0x000014D8 File Offset: 0x000008D8
		public FDIException(global::FDISystem.FDIErrorCodes errorCode)
		{
			this._errorCode = errorCode;
		}

		// Token: 0x060001BE RID: 446 RVA: 0x000014BC File Offset: 0x000008BC
		public FDIException(string message, global::System.Exception innerException) : base(message, innerException)
		{
			this._errorCode = global::FDISystem.FDIErrorCodes.Failure;
		}

		// Token: 0x060001BF RID: 447 RVA: 0x000014A0 File Offset: 0x000008A0
		public FDIException(string message) : base(message)
		{
			this._errorCode = global::FDISystem.FDIErrorCodes.Failure;
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00001484 File Offset: 0x00000884
		public FDIException()
		{
			this._errorCode = global::FDISystem.FDIErrorCodes.Failure;
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x060001C1 RID: 449 RVA: 0x00001388 File Offset: 0x00000788
		public global::FDISystem.FDIErrorCodes ErrorCode
		{
			get
			{
				return this._errorCode;
			}
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00001510 File Offset: 0x00000910
		public static string GetCustomErrorCode(global::FDISystem.FDIErrorCodes errorCode)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(6);
			object[] args = new object[0];
			stringBuilder.AppendFormat(global::System.Globalization.CultureInfo.InvariantCulture, global::FDISystem.FDIException.FDI_ERRORID_PREFIX, args);
			byte condition = (errorCode != global::FDISystem.FDIErrorCodes.None) ? 1 : 0;
			global::System.Diagnostics.Debug.Assert(condition != 0);
			if (errorCode == global::FDISystem.FDIErrorCodes.None)
			{
				object[] args2 = new object[0];
				int num = 998;
				stringBuilder.AppendFormat(global::System.Globalization.CultureInfo.InvariantCulture, num.ToString("000"), args2);
				return stringBuilder.ToString();
			}
			string text = ((global::FDISystem.FDIErrorCodes)errorCode).ToString("G");
			char[] separator = new char[]
			{
				','
			};
			global::FDISystem.CustomExceptionCode customExceptionCode = global::FDISystem.CustomExceptionCode.InvalidErrorCode;
			string[] array = text.Split(separator);
			int num2 = 0;
			if (0 < array.Length)
			{
				do
				{
					string value = array[num2];
					global::System.Diagnostics.Debug.Assert(global::System.Enum.IsDefined(typeof(global::FDISystem.CustomExceptionCode), value));
					if (global::System.Enum.IsDefined(typeof(global::FDISystem.CustomExceptionCode), value))
					{
						customExceptionCode = (global::FDISystem.CustomExceptionCode)global::System.Enum.Parse(typeof(global::FDISystem.CustomExceptionCode), value);
					}
					num2++;
				}
				while (num2 < array.Length);
			}
			object[] args3 = new object[0];
			int num3 = (int)customExceptionCode;
			stringBuilder.AppendFormat(global::System.Globalization.CultureInfo.InvariantCulture, num3.ToString("000"), args3);
			object[] args4 = new object[]
			{
				global::FDISystem.FDIException.FDI_COMPONENT_CODE,
				((global::FDISystem.CustomExceptionCode)customExceptionCode).ToString("G")
			};
			stringBuilder.AppendFormat(global::System.Globalization.CultureInfo.InvariantCulture, "_{0}_{1}", args4);
			return stringBuilder.ToString();
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x060001C3 RID: 451 RVA: 0x0000139C File Offset: 0x0000079C
		public static string DotFXExceptionCode
		{
			get
			{
				int num = 999;
				return global::FDISystem.FDIException.FDI_ERRORID_PREFIX + num.ToString("000") + "_" + global::FDISystem.FDIException.FDI_COMPONENT_CODE + "_" + ((global::FDISystem.CustomExceptionCode)global::FDISystem.CustomExceptionCode.DotFXException).ToString("G");
			}
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00001408 File Offset: 0x00000808
		[global::System.Security.Permissions.SecurityPermission(global::System.Security.Permissions.SecurityAction.LinkDemand, Flags = global::System.Security.Permissions.SecurityPermissionFlag.SerializationFormatter)]
		public sealed override void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			base.GetObjectData(info, context);
			info.AddValue(global::FDISystem.FDIException.ErrorCodeSerializedName, (int)this._errorCode);
		}

		// Token: 0x0400003C RID: 60
		private global::FDISystem.FDIErrorCodes _errorCode;

		// Token: 0x0400003D RID: 61
		private static string FDI_ERRORID_PREFIX = "RD4";

		// Token: 0x0400003E RID: 62
		private static string FDI_COMPONENT_CODE = "FDI";

		// Token: 0x0400003F RID: 63
		private static string ErrorCodeSerializedName = "FDIErrorCodes";
	}
}
