using System;
using System.Runtime.Serialization;
using System.Security;

namespace <CrtImplementationDetails>
{
	// Token: 0x02000066 RID: 102
	[global::System.Serializable]
	internal class ModuleLoadExceptionHandlerException : global::<CrtImplementationDetails>.ModuleLoadException
	{
		// Token: 0x06000138 RID: 312 RVA: 0x000060D0 File Offset: 0x000054D0
		protected ModuleLoadExceptionHandlerException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			this.NestedException = (global::System.Exception)info.GetValue("NestedException", typeof(global::System.Exception));
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00006668 File Offset: 0x00005A68
		public ModuleLoadExceptionHandlerException(string message, global::System.Exception innerException, global::System.Exception nestedException) : base(message, innerException)
		{
			this.NestedException = nestedException;
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600013A RID: 314 RVA: 0x00005FD4 File Offset: 0x000053D4
		// (set) Token: 0x0600013B RID: 315 RVA: 0x00005FE8 File Offset: 0x000053E8
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

		// Token: 0x0600013C RID: 316 RVA: 0x00005FFC File Offset: 0x000053FC
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

		// Token: 0x0600013D RID: 317 RVA: 0x000060A0 File Offset: 0x000054A0
		[global::System.Security.SecurityCritical]
		public override void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			base.GetObjectData(info, context);
			info.AddValue("NestedException", this.NestedException, typeof(global::System.Exception));
		}

		// Token: 0x040000BC RID: 188
		private const string formatString = "\n{0}: {1}\n--- Start of primary exception ---\n{2}\n--- End of primary exception ---\n\n--- Start of nested exception ---\n{3}\n--- End of nested exception ---\n";

		// Token: 0x040000BD RID: 189
		private global::System.Exception <backing_store>NestedException;
	}
}
