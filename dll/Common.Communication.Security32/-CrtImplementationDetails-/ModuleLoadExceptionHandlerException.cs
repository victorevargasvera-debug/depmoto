using System;
using System.Runtime.Serialization;
using System.Security;

namespace <CrtImplementationDetails>
{
	// Token: 0x0200002D RID: 45
	[global::System.Serializable]
	internal class ModuleLoadExceptionHandlerException : global::<CrtImplementationDetails>.ModuleLoadException
	{
		// Token: 0x060000E2 RID: 226 RVA: 0x00021E24 File Offset: 0x00021224
		protected ModuleLoadExceptionHandlerException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			this.NestedException = (global::System.Exception)info.GetValue("NestedException", typeof(global::System.Exception));
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x0002240C File Offset: 0x0002180C
		public ModuleLoadExceptionHandlerException(string message, global::System.Exception innerException, global::System.Exception nestedException) : base(message, innerException)
		{
			this.NestedException = nestedException;
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x060000E4 RID: 228 RVA: 0x00021D28 File Offset: 0x00021128
		// (set) Token: 0x060000E5 RID: 229 RVA: 0x00021D3C File Offset: 0x0002113C
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

		// Token: 0x060000E6 RID: 230 RVA: 0x00021D50 File Offset: 0x00021150
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

		// Token: 0x060000E7 RID: 231 RVA: 0x00021DF4 File Offset: 0x000211F4
		[global::System.Security.SecurityCritical]
		public override void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			base.GetObjectData(info, context);
			info.AddValue("NestedException", this.NestedException, typeof(global::System.Exception));
		}

		// Token: 0x04000088 RID: 136
		private const string formatString = "\n{0}: {1}\n--- Start of primary exception ---\n{2}\n--- End of primary exception ---\n\n--- Start of nested exception ---\n{3}\n--- End of nested exception ---\n";

		// Token: 0x04000089 RID: 137
		private global::System.Exception <backing_store>NestedException;
	}
}
