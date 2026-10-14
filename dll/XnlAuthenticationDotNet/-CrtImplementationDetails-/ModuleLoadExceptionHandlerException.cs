using System;
using System.Runtime.Serialization;
using System.Security;

namespace <CrtImplementationDetails>
{
	// Token: 0x020000D9 RID: 217
	[global::System.Serializable]
	internal class ModuleLoadExceptionHandlerException : global::<CrtImplementationDetails>.ModuleLoadException
	{
		// Token: 0x06000063 RID: 99 RVA: 0x00001B88 File Offset: 0x00000F88
		protected ModuleLoadExceptionHandlerException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			this.NestedException = (global::System.Exception)info.GetValue("NestedException", typeof(global::System.Exception));
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00002240 File Offset: 0x00001640
		public ModuleLoadExceptionHandlerException(string message, global::System.Exception innerException, global::System.Exception nestedException) : base(message, innerException)
		{
			this.NestedException = nestedException;
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000065 RID: 101 RVA: 0x00001A8C File Offset: 0x00000E8C
		// (set) Token: 0x06000066 RID: 102 RVA: 0x00001AA0 File Offset: 0x00000EA0
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

		// Token: 0x06000067 RID: 103 RVA: 0x00001AB4 File Offset: 0x00000EB4
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

		// Token: 0x06000068 RID: 104 RVA: 0x00001B58 File Offset: 0x00000F58
		[global::System.Security.SecurityCritical]
		public override void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			base.GetObjectData(info, context);
			info.AddValue("NestedException", this.NestedException, typeof(global::System.Exception));
		}

		// Token: 0x040000F8 RID: 248
		private const string formatString = "\n{0}: {1}\n--- Start of primary exception ---\n{2}\n--- End of primary exception ---\n\n--- Start of nested exception ---\n{3}\n--- End of nested exception ---\n";

		// Token: 0x040000F9 RID: 249
		private global::System.Exception <backing_store>NestedException;
	}
}
