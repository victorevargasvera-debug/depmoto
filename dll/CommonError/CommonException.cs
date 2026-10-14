using System;
using System.Reflection;
using System.Runtime.Serialization;

namespace Motorola.Common.CustomException
{
	// Token: 0x02000002 RID: 2
	[global::System.Serializable]
	public sealed class CommonException : global::System.Exception, global::System.Runtime.Serialization.ISerializable
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000001 RID: 1 RVA: 0x000020D0 File Offset: 0x000002D0
		public global::Motorola.Common.CustomException.CommonErrorCode ErrorCode
		{
			get
			{
				return this.errorCode;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000002 RID: 2 RVA: 0x000020D8 File Offset: 0x000002D8
		public global::Motorola.Common.CustomException.CommonExceptionData CommonExceptionData
		{
			get
			{
				return this.commonExceptionData;
			}
		}

		// Token: 0x06000003 RID: 3 RVA: 0x000020E0 File Offset: 0x000002E0
		private CommonException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06000004 RID: 4 RVA: 0x000020EA File Offset: 0x000002EA
		public CommonException(global::Motorola.Common.CustomException.CommonErrorCode errorID, global::System.Exception systemException) : base(systemException.Message, systemException)
		{
			this.errorCode = errorID;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002100 File Offset: 0x00000300
		public CommonException(global::Motorola.Common.CustomException.CommonErrorCode errorID) : base(errorID.ToString())
		{
			this.errorCode = errorID;
		}

		// Token: 0x06000006 RID: 6 RVA: 0x0000211A File Offset: 0x0000031A
		public CommonException(global::Motorola.Common.CustomException.CommonExceptionData commonExceptionData) : base(commonExceptionData.ErrorCode.ToString())
		{
			this.errorCode = commonExceptionData.ErrorCode;
			this.commonExceptionData = commonExceptionData;
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002145 File Offset: 0x00000345
		public override void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			info.AddValue("ErrorID1", this.errorCode);
			base.GetObjectData(info, context);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002165 File Offset: 0x00000365
		public CommonException(string message, global::System.Exception ex) : base(message, ex)
		{
		}

		// Token: 0x06000009 RID: 9 RVA: 0x0000216F File Offset: 0x0000036F
		public CommonException()
		{
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002177 File Offset: 0x00000377
		public CommonException(string message) : base(message)
		{
			this.errorCode = global::Motorola.Common.CustomException.CommonErrorCode.GenericError;
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002187 File Offset: 0x00000387
		public CommonException(global::Motorola.Common.CustomException.CommonErrorCode errorID, string message) : base(message)
		{
			this.errorCode = errorID;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002197 File Offset: 0x00000397
		public CommonException(global::Motorola.Common.CustomException.CommonErrorCode errorID, string message, global::System.Exception ex) : base(message, ex)
		{
			this.errorCode = errorID;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000021A8 File Offset: 0x000003A8
		public static bool IsError(global::Motorola.Common.CustomException.CommonErrorCode errorCode)
		{
			bool result = true;
			global::System.Type typeFromHandle = typeof(global::Motorola.Common.CustomException.CommonErrorCode);
			string enumName = typeFromHandle.GetEnumName(errorCode);
			global::System.Reflection.MemberInfo[] member = typeFromHandle.GetMember(enumName);
			try
			{
				global::System.Reflection.MemberInfo[] array = member;
				int num = 0;
				if (num < array.Length)
				{
					global::System.Reflection.MemberInfo memberInfo = array[num];
					global::Motorola.Common.CustomException.ErrorCodeAttributes[] array2 = (global::Motorola.Common.CustomException.ErrorCodeAttributes[])memberInfo.GetCustomAttributes(typeof(global::Motorola.Common.CustomException.ErrorCodeAttributes), false);
					if (array2 != null)
					{
						global::Motorola.Common.CustomException.ErrorCodeAttributes[] array3 = array2;
						int num2 = 0;
						if (num2 < array3.Length)
						{
							global::Motorola.Common.CustomException.ErrorCodeAttributes errorCodeAttributes = array3[num2];
							if (errorCodeAttributes.Retriable)
							{
								result = false;
							}
						}
					}
				}
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002248 File Offset: 0x00000448
		public static bool IsDBMigrationFatalError(global::Motorola.Common.CustomException.CommonErrorCode errorCode)
		{
			global::System.Type typeFromHandle = typeof(global::Motorola.Common.CustomException.CommonErrorCode);
			global::System.Reflection.MemberInfo[] member = typeFromHandle.GetMember(errorCode.ToString());
			if (member != null && member.Length > 0)
			{
				object[] customAttributes = member[0].GetCustomAttributes(typeof(global::Motorola.Common.CustomException.DBMigrationErrorAttribute), false);
				if (customAttributes != null && customAttributes.Length > 0)
				{
					return ((global::Motorola.Common.CustomException.DBMigrationErrorAttribute)customAttributes[0]).IsFatal;
				}
			}
			return false;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000022A8 File Offset: 0x000004A8
		public static bool IsBatchOpJobFatalError(global::Motorola.Common.CustomException.CommonErrorCode errorCode)
		{
			global::System.Type typeFromHandle = typeof(global::Motorola.Common.CustomException.CommonErrorCode);
			global::System.Reflection.MemberInfo[] member = typeFromHandle.GetMember(errorCode.ToString());
			if (member != null && member.Length > 0)
			{
				object[] customAttributes = member[0].GetCustomAttributes(typeof(global::Motorola.Common.CustomException.BatchOperationErrorAttribute), false);
				if (customAttributes != null && customAttributes.Length > 0)
				{
					return ((global::Motorola.Common.CustomException.BatchOperationErrorAttribute)customAttributes[0]).IsFatal;
				}
			}
			return false;
		}

		// Token: 0x04000001 RID: 1
		private global::Motorola.Common.CustomException.CommonErrorCode errorCode;

		// Token: 0x04000002 RID: 2
		private global::Motorola.Common.CustomException.CommonExceptionData commonExceptionData;
	}
}
