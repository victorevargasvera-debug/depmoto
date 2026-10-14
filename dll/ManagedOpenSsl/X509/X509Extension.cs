using System;
using System.Runtime.InteropServices;
using OpenSSL.Core;

namespace OpenSSL.X509
{
	// Token: 0x02000084 RID: 132
	public class X509Extension : global::OpenSSL.Core.BaseValueType, global::OpenSSL.Core.IStackable
	{
		// Token: 0x0600054A RID: 1354 RVA: 0x00009FA3 File Offset: 0x000081A3
		public X509Extension() : base(global::OpenSSL.Core.Native.ExpectNonNull(global::OpenSSL.Core.Native.X509_EXTENSION_new()), true)
		{
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x00009FB6 File Offset: 0x000081B6
		internal X509Extension(global::OpenSSL.Core.IStack stack, global::System.IntPtr ptr) : base(ptr, true)
		{
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x00009FC0 File Offset: 0x000081C0
		public X509Extension(global::OpenSSL.X509.X509Certificate issuer, global::OpenSSL.X509.X509Certificate subject, string name, bool critical, string value) : base(global::System.IntPtr.Zero, true)
		{
			using (global::OpenSSL.X509.X509V3Context x509V3Context = new global::OpenSSL.X509.X509V3Context(issuer, subject, null))
			{
				this.ptr = global::OpenSSL.Core.Native.ExpectNonNull(global::OpenSSL.Core.Native.X509V3_EXT_conf_nid(global::System.IntPtr.Zero, x509V3Context.Handle, global::OpenSSL.Core.Native.TextToNID(name), value));
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x0600054D RID: 1357 RVA: 0x0000A024 File Offset: 0x00008224
		public string Name
		{
			get
			{
				return global::System.Runtime.InteropServices.Marshal.PtrToStringAnsi(global::OpenSSL.Core.Native.OBJ_nid2ln(this.NID));
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x0600054E RID: 1358 RVA: 0x0000A038 File Offset: 0x00008238
		public int NID
		{
			get
			{
				global::System.IntPtr intPtr = global::OpenSSL.Core.Native.X509_EXTENSION_get_object(this.ptr);
				if (intPtr != global::System.IntPtr.Zero)
				{
					return global::OpenSSL.Core.Native.OBJ_obj2nid(intPtr);
				}
				return 0;
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x0600054F RID: 1359 RVA: 0x0000A068 File Offset: 0x00008268
		public bool IsCritical
		{
			get
			{
				int num = global::OpenSSL.Core.Native.X509_EXTENSION_get_critical(this.ptr);
				return num == 1;
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x06000550 RID: 1360 RVA: 0x0000A088 File Offset: 0x00008288
		public byte[] Data
		{
			get
			{
				byte[] data;
				using (global::OpenSSL.Core.Asn1String asn1String = new global::OpenSSL.Core.Asn1String(global::OpenSSL.Core.Native.X509_EXTENSION_get_data(this.ptr), false))
				{
					data = asn1String.Data;
				}
				return data;
			}
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x0000A0CC File Offset: 0x000082CC
		protected override void OnDispose()
		{
			global::OpenSSL.Core.Native.X509_EXTENSION_free(this.ptr);
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x0000A0D9 File Offset: 0x000082D9
		public override void Print(global::OpenSSL.Core.BIO bio)
		{
			global::OpenSSL.Core.Native.X509V3_EXT_print(bio.Handle, this.ptr, 0U, 0);
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x0000A0EF File Offset: 0x000082EF
		internal override global::System.IntPtr DuplicateHandle()
		{
			return global::OpenSSL.Core.Native.X509_EXTENSION_dup(this.ptr);
		}
	}
}
