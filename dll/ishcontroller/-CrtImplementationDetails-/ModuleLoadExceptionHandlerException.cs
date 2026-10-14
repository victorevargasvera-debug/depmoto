using System;
using System.Runtime.Serialization;
using System.Security;

namespace <CrtImplementationDetails>
{
	// Token: 0x02000098 RID: 152
	[global::System.Serializable]
	internal class ModuleLoadExceptionHandlerException : global::<CrtImplementationDetails>.ModuleLoadException
	{
		// Token: 0x0600019E RID: 414 RVA: 0x00005678 File Offset: 0x00004A78
		protected ModuleLoadExceptionHandlerException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			this.NestedException = (global::System.Exception)info.GetValue("NestedException", typeof(global::System.Exception));
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00005C84 File Offset: 0x00005084
		public ModuleLoadExceptionHandlerException(string message, global::System.Exception innerException, global::System.Exception nestedException) : base(message, innerException)
		{
			this.NestedException = nestedException;
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x060001A0 RID: 416 RVA: 0x0000557C File Offset: 0x0000497C
		// (set) Token: 0x060001A1 RID: 417 RVA: 0x00005590 File Offset: 0x00004990
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

		// Token: 0x060001A2 RID: 418 RVA: 0x000055A4 File Offset: 0x000049A4
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

		// Token: 0x060001A3 RID: 419 RVA: 0x00005648 File Offset: 0x00004A48
		[global::System.Security.SecurityCritical]
		public override void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			base.GetObjectData(info, context);
			info.AddValue("NestedException", this.NestedException, typeof(global::System.Exception));
		}

		// Token: 0x040000D4 RID: 212
		private const string formatString = "\n{0}: {1}\n--- Start of primary exception ---\n{2}\n--- End of primary exception ---\n\n--- Start of nested exception ---\n{3}\n--- End of nested exception ---\n";

		// Token: 0x040000D5 RID: 213
		private global::System.Exception <backing_store>NestedException;
	}
}
