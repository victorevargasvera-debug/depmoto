using System;
using System.Runtime.InteropServices;
using OpenSSL.Core;
using OpenSSL.Crypto;

namespace OpenSSL.X509
{
	// Token: 0x02000088 RID: 136
	public class X509Object : global::OpenSSL.Core.Base, global::OpenSSL.Core.IStackable
	{
		// Token: 0x0600058F RID: 1423 RVA: 0x0000A59B File Offset: 0x0000879B
		internal X509Object(global::OpenSSL.Core.IStack stack, global::System.IntPtr ptr) : base(ptr, true)
		{
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000590 RID: 1424 RVA: 0x0000A5A5 File Offset: 0x000087A5
		public global::OpenSSL.X509.X509Certificate Certificate
		{
			get
			{
				if (this.raw.type == 1)
				{
					return new global::OpenSSL.X509.X509Certificate(this.raw.ptr, false);
				}
				return null;
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000591 RID: 1425 RVA: 0x0000A5C8 File Offset: 0x000087C8
		public global::OpenSSL.Crypto.CryptoKey PrivateKey
		{
			get
			{
				if (this.raw.type == 3)
				{
					return new global::OpenSSL.Crypto.CryptoKey(this.raw.ptr, false);
				}
				return null;
			}
		}

		// Token: 0x06000592 RID: 1426 RVA: 0x0000A5EB File Offset: 0x000087EB
		internal override void AddRef()
		{
			global::OpenSSL.Core.Native.X509_OBJECT_up_ref_count(this.ptr);
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x0000A5F8 File Offset: 0x000087F8
		protected override void OnDispose()
		{
		}

		// Token: 0x06000594 RID: 1428 RVA: 0x0000A5FA File Offset: 0x000087FA
		internal override void OnNewHandle(global::System.IntPtr ptr)
		{
			this.raw = (global::OpenSSL.X509.X509Object.X509_OBJECT)global::System.Runtime.InteropServices.Marshal.PtrToStructure(this.ptr, typeof(global::OpenSSL.X509.X509Object.X509_OBJECT));
		}

		// Token: 0x040003F9 RID: 1017
		private const int X509_LU_RETRY = -1;

		// Token: 0x040003FA RID: 1018
		private const int X509_LU_FAIL = 0;

		// Token: 0x040003FB RID: 1019
		private const int X509_LU_X509 = 1;

		// Token: 0x040003FC RID: 1020
		private const int X509_LU_CRL = 2;

		// Token: 0x040003FD RID: 1021
		private const int X509_LU_PKEY = 3;

		// Token: 0x040003FE RID: 1022
		private global::OpenSSL.X509.X509Object.X509_OBJECT raw;

		// Token: 0x02000089 RID: 137
		private struct X509_OBJECT
		{
			// Token: 0x040003FF RID: 1023
			public int type;

			// Token: 0x04000400 RID: 1024
			public global::System.IntPtr ptr;
		}
	}
}
