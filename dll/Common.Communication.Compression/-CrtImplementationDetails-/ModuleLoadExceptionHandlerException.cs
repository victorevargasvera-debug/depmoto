using System;
using System.Runtime.Serialization;
using System.Security;

namespace <CrtImplementationDetails>
{
	// Token: 0x02000013 RID: 19
	[global::System.Serializable]
	internal class ModuleLoadExceptionHandlerException : global::<CrtImplementationDetails>.ModuleLoadException
	{
		// Token: 0x06000073 RID: 115 RVA: 0x0000CB18 File Offset: 0x0000BF18
		protected ModuleLoadExceptionHandlerException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			this.NestedException = (global::System.Exception)info.GetValue("NestedException", typeof(global::System.Exception));
		}

		// Token: 0x06000074 RID: 116 RVA: 0x0000D14C File Offset: 0x0000C54C
		public ModuleLoadExceptionHandlerException(string message, global::System.Exception innerException, global::System.Exception nestedException) : base(message, innerException)
		{
			this.NestedException = nestedException;
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000075 RID: 117 RVA: 0x0000CA1C File Offset: 0x0000BE1C
		// (set) Token: 0x06000076 RID: 118 RVA: 0x0000CA30 File Offset: 0x0000BE30
		public global::System.Exception NestedException
		{
			get
			{
				return this.<backing_store>NestedException;
			}
			set
			{
				this.<backing_store>NestedException = value;
			}
		}

		// Token: 0x06000077 RID: 119 RVA: 0x0000CA44 File Offset: 0x0000BE44
		public override string ToString()
		{
			string text;
			if (this.InnerException != null)
			{
				text = this.InnerException.ToString();
			}
			else
			{
				text = string.Empty;
			}
			string text2;
			if (this.NestedException != null)
			{
				text2 = this.NestedException.ToString();
			}
			else
			{
				text2 = string.Empty;
			}
			object[] array = new object[4];
			array[0] = this.GetType();
			string text3;
			if (this.Message != null)
			{
				text3 = this.Message;
			}
			else
			{
				text3 = string.Empty;
			}
			array[1] = text3;
			string text4;
			if (text != null)
			{
				text4 = text;
			}
			else
			{
				text4 = string.Empty;
			}
			array[2] = text4;
			string text5;
			if (text2 != null)
			{
				text5 = text2;
			}
			else
			{
				text5 = string.Empty;
			}
			array[3] = text5;
			return string.Format("\n{0}: {1}\n--- Start of primary exception ---\n{2}\n--- End of primary exception ---\n\n--- Start of nested exception ---\n{3}\n--- End of nested exception ---\n", array);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x0000CAE8 File Offset: 0x0000BEE8
		[global::System.Security.SecurityCritical]
		public override void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			base.GetObjectData(info, context);
			info.AddValue("NestedException", this.NestedException, typeof(global::System.Exception));
		}

		// Token: 0x04000042 RID: 66
		private const string formatString = "\n{0}: {1}\n--- Start of primary exception ---\n{2}\n--- End of primary exception ---\n\n--- Start of nested exception ---\n{3}\n--- End of nested exception ---\n";

		// Token: 0x04000043 RID: 67
		private global::System.Exception <backing_store>NestedException;
	}
}
