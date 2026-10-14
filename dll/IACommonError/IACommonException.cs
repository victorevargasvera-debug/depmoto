using System;
using System.Reflection;
using System.Runtime.Serialization;

namespace IACustomException
{
	// Token: 0x02000002 RID: 2
	[global::System.Serializable]
	public sealed class IACommonException : global::System.Exception, global::System.Runtime.Serialization.ISerializable
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000001 RID: 1 RVA: 0x000020D0 File Offset: 0x000002D0
		public global::IACustomException.IACommonErrorCode ErrorCode
		{
			get
			{
				return this.errorCode;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000002 RID: 2 RVA: 0x000020D8 File Offset: 0x000002D8
		public global::IACustomException.IACommonExceptionData CommonExceptionData
		{
			get
			{
				return this.commonExceptionData;
			}
		}

		// Token: 0x06000003 RID: 3 RVA: 0x000020E0 File Offset: 0x000002E0
		private IACommonException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06000004 RID: 4 RVA: 0x000020EA File Offset: 0x000002EA
		public IACommonException(global::IACustomException.IACommonErrorCode errorID, global::System.Exception systemException) : base(systemException.Message, systemException)
		{
			this.errorCode = errorID;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002100 File Offset: 0x00000300
		public IACommonException(global::IACustomException.IACommonErrorCode errorID) : base(errorID.ToString())
		{
			this.errorCode = errorID;
		}

		// Token: 0x06000006 RID: 6 RVA: 0x0000211A File Offset: 0x0000031A
		public IACommonException(global::IACustomException.IACommonExceptionData commonExceptionData) : base(commonExceptionData.ErrorCode.ToString())
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
		public IACommonException(string message, global::System.Exception ex) : base(message, ex)
		{
		}

		// Token: 0x06000009 RID: 9 RVA: 0x0000216F File Offset: 0x0000036F
		public IACommonException()
		{
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002177 File Offset: 0x00000377
		public IACommonException(string message) : base(message)
		{
			this.errorCode = global::IACustomException.IACommonErrorCode.GenericError;
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002187 File Offset: 0x00000387
		public IACommonException(global::IACustomException.IACommonErrorCode errorID, string message) : base(message)
		{
			this.errorCode = errorID;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002197 File Offset: 0x00000397
		public IACommonException(global::IACustomException.IACommonErrorCode errorID, string message, global::System.Exception ex) : base(message, ex)
		{
			this.errorCode = errorID;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000021A8 File Offset: 0x000003A8
		public static bool IsError(global::IACustomException.IACommonErrorCode errorCode)
		{
			bool result = true;
			global::System.Type typeFromHandle = typeof(global::IACustomException.IACommonErrorCode);
			string enumName = typeFromHandle.GetEnumName(errorCode);
			global::System.Reflection.MemberInfo[] member = typeFromHandle.GetMember(enumName);
			try
			{
				global::System.Reflection.MemberInfo[] array = member;
				int num = 0;
				if (num < array.Length)
				{
					global::System.Reflection.MemberInfo memberInfo = array[num];
					global::IACustomException.IAErrorCodeAttributes[] array2 = (global::IACustomException.IAErrorCodeAttributes[])memberInfo.GetCustomAttributes(typeof(global::IACustomException.IAErrorCodeAttributes), false);
					if (array2 != null)
					{
						global::IACustomException.IAErrorCodeAttributes[] array3 = array2;
						int num2 = 0;
						if (num2 < array3.Length)
						{
							global::IACustomException.IAErrorCodeAttributes iaerrorCodeAttributes = array3[num2];
							if (iaerrorCodeAttributes.Retriable)
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

		// Token: 0x04000001 RID: 1
		private global::IACustomException.IACommonErrorCode errorCode;

		// Token: 0x04000002 RID: 2
		private global::IACustomException.IACommonExceptionData commonExceptionData;
	}
}
