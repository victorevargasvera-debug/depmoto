using System;
using System.Text;
using OpenSSL.Core;

namespace OpenSSL.X509
{
	// Token: 0x02000028 RID: 40
	public class Configuration : global::OpenSSL.Core.Base
	{
		// Token: 0x060000AF RID: 175 RVA: 0x00003E06 File Offset: 0x00002006
		private Configuration() : base(global::OpenSSL.Core.Native.NCONF_new(global::System.IntPtr.Zero), true)
		{
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00003E19 File Offset: 0x00002019
		public Configuration(string filename) : this()
		{
			this.Load(filename);
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00003E28 File Offset: 0x00002028
		public void Load(string filename)
		{
			int num = 0;
			global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.NCONF_load(this.ptr, filename, ref num));
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00003E4C File Offset: 0x0000204C
		public void ApplyExtensions(string section, global::OpenSSL.X509.X509Certificate issuer, global::OpenSSL.X509.X509Certificate subject, global::OpenSSL.X509.X509Request request)
		{
			using (global::OpenSSL.X509.X509V3Context x509V3Context = new global::OpenSSL.X509.X509V3Context(issuer, subject, request))
			{
				x509V3Context.SetConfiguration(this);
				global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.X509V3_EXT_add_nconf(this.ptr, x509V3Context.Handle, global::System.Text.Encoding.ASCII.GetBytes(section), subject.Handle));
			}
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00003EB0 File Offset: 0x000020B0
		protected override void OnDispose()
		{
			global::OpenSSL.Core.Native.NCONF_free(this.ptr);
		}
	}
}
