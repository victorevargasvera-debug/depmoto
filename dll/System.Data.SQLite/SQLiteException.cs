using System;
using System.Data.Common;
using System.Reflection;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace System.Data.SQLite
{
	// Token: 0x02000038 RID: 56
	[global::System.Serializable]
	public sealed class SQLiteException : global::System.Data.Common.DbException, global::System.Runtime.Serialization.ISerializable
	{
		// Token: 0x060002E8 RID: 744 RVA: 0x0001C7B4 File Offset: 0x0001BBB4
		private SQLiteException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			this._errorCode = (global::System.Data.SQLite.SQLiteErrorCode)info.GetInt32("errorCode");
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x0001C7DC File Offset: 0x0001BBDC
		public SQLiteException(global::System.Data.SQLite.SQLiteErrorCode errorCode, string message) : base(global::System.Data.SQLite.SQLiteException.GetStockErrorMessage(errorCode, message))
		{
			this._errorCode = errorCode;
		}

		// Token: 0x060002EA RID: 746 RVA: 0x0001C800 File Offset: 0x0001BC00
		public SQLiteException(string message) : this(global::System.Data.SQLite.SQLiteErrorCode.Unknown, message)
		{
		}

		// Token: 0x060002EB RID: 747 RVA: 0x0001C818 File Offset: 0x0001BC18
		public SQLiteException()
		{
		}

		// Token: 0x060002EC RID: 748 RVA: 0x0001C82C File Offset: 0x0001BC2C
		public SQLiteException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x060002ED RID: 749 RVA: 0x0001C844 File Offset: 0x0001BC44
		[global::System.Security.Permissions.SecurityPermission(global::System.Security.Permissions.SecurityAction.LinkDemand, Flags = global::System.Security.Permissions.SecurityPermissionFlag.SerializationFormatter)]
		public override void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			if (info != null)
			{
				info.AddValue("errorCode", this._errorCode);
			}
			base.GetObjectData(info, context);
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060002EE RID: 750 RVA: 0x0001C874 File Offset: 0x0001BC74
		public global::System.Data.SQLite.SQLiteErrorCode ResultCode
		{
			get
			{
				return this._errorCode;
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060002EF RID: 751 RVA: 0x0001C888 File Offset: 0x0001BC88
		public override int ErrorCode
		{
			get
			{
				return (int)this._errorCode;
			}
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x0001C89C File Offset: 0x0001BC9C
		private static string GetErrorString(global::System.Data.SQLite.SQLiteErrorCode errorCode)
		{
			global::System.Reflection.BindingFlags invokeAttr = global::System.Reflection.BindingFlags.Static | global::System.Reflection.BindingFlags.NonPublic | global::System.Reflection.BindingFlags.InvokeMethod;
			return typeof(global::System.Data.SQLite.SQLiteBase).InvokeMember("GetErrorString", invokeAttr, null, null, new object[]
			{
				errorCode
			}) as string;
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x0001C8DC File Offset: 0x0001BCDC
		private static string GetStockErrorMessage(global::System.Data.SQLite.SQLiteErrorCode errorCode, string message)
		{
			return string.Format("{0}{1}{2}", global::System.Data.SQLite.SQLiteException.GetErrorString(errorCode), global::System.Environment.NewLine, message).Trim();
		}

		// Token: 0x04000145 RID: 325
		private global::System.Data.SQLite.SQLiteErrorCode _errorCode;
	}
}
