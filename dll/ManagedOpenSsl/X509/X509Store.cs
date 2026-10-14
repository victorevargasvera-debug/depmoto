using System;
using System.Runtime.InteropServices;
using OpenSSL.Core;

namespace OpenSSL.X509
{
	// Token: 0x0200008D RID: 141
	public class X509Store : global::OpenSSL.Core.BaseReferenceType
	{
		// Token: 0x060005A9 RID: 1449 RVA: 0x0000A83F File Offset: 0x00008A3F
		public X509Store() : base(global::OpenSSL.Core.Native.ExpectNonNull(global::OpenSSL.Core.Native.X509_STORE_new()), true)
		{
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x0000A85D File Offset: 0x00008A5D
		internal X509Store(global::System.IntPtr ptr, bool takeOwnership) : base(ptr, takeOwnership)
		{
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x0000A872 File Offset: 0x00008A72
		public X509Store(global::OpenSSL.X509.X509Chain chain) : this(chain, true)
		{
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x0000A87C File Offset: 0x00008A7C
		public X509Store(global::OpenSSL.X509.X509Chain chain, bool takeOwnership) : base(global::OpenSSL.Core.Native.ExpectNonNull(global::OpenSSL.Core.Native.X509_STORE_new()), takeOwnership)
		{
			foreach (global::OpenSSL.X509.X509Certificate cert in chain)
			{
				this.AddTrusted(cert);
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x060005AD RID: 1453 RVA: 0x0000A8E0 File Offset: 0x00008AE0
		public global::OpenSSL.Core.Stack<global::OpenSSL.X509.X509Object> Objects
		{
			get
			{
				return new global::OpenSSL.Core.Stack<global::OpenSSL.X509.X509Object>(((global::OpenSSL.X509.X509Store.X509_STORE)global::System.Runtime.InteropServices.Marshal.PtrToStructure(this.ptr, typeof(global::OpenSSL.X509.X509Store.X509_STORE))).objs, false);
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x060005AE RID: 1454 RVA: 0x0000A917 File Offset: 0x00008B17
		// (set) Token: 0x060005AF RID: 1455 RVA: 0x0000A91F File Offset: 0x00008B1F
		public global::OpenSSL.X509.X509Chain Untrusted
		{
			get
			{
				return this.untrusted;
			}
			set
			{
				this.untrusted = value;
			}
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x0000A928 File Offset: 0x00008B28
		public bool Verify(global::OpenSSL.X509.X509Certificate cert, out string error)
		{
			using (global::OpenSSL.X509.X509StoreContext x509StoreContext = new global::OpenSSL.X509.X509StoreContext())
			{
				x509StoreContext.Init(this, cert, this.untrusted);
				if (x509StoreContext.Verify())
				{
					error = "";
					return true;
				}
				error = x509StoreContext.ErrorString;
			}
			return false;
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x0000A984 File Offset: 0x00008B84
		public void AddTrusted(global::OpenSSL.X509.X509Chain chain)
		{
			foreach (global::OpenSSL.X509.X509Certificate cert in chain)
			{
				this.AddTrusted(cert);
			}
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x0000A9CC File Offset: 0x00008BCC
		public void AddTrusted(global::OpenSSL.X509.X509Certificate cert)
		{
			global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.X509_STORE_add_cert(this.ptr, cert.Handle));
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x0000A9E5 File Offset: 0x00008BE5
		public void AddUntrusted(global::OpenSSL.X509.X509Certificate cert)
		{
			this.untrusted.Add(cert);
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x0000A9F3 File Offset: 0x00008BF3
		protected override void OnDispose()
		{
			global::OpenSSL.Core.Native.X509_STORE_free(this.ptr);
			if (this.untrusted != null)
			{
				this.untrusted.Dispose();
				this.untrusted = null;
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x060005B5 RID: 1461 RVA: 0x0000AA1A File Offset: 0x00008C1A
		internal override global::OpenSSL.Core.CryptoLockTypes LockType
		{
			get
			{
				return global::OpenSSL.Core.CryptoLockTypes.CRYPTO_LOCK_X509_STORE;
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x060005B6 RID: 1462 RVA: 0x0000AA1E File Offset: 0x00008C1E
		internal override global::System.Type RawReferenceType
		{
			get
			{
				return typeof(global::OpenSSL.X509.X509Store.X509_STORE);
			}
		}

		// Token: 0x0400040C RID: 1036
		private global::OpenSSL.X509.X509Chain untrusted = new global::OpenSSL.X509.X509Chain();

		// Token: 0x0200008E RID: 142
		private struct X509_STORE
		{
			// Token: 0x0400040D RID: 1037
			public int cache;

			// Token: 0x0400040E RID: 1038
			public global::System.IntPtr objs;

			// Token: 0x0400040F RID: 1039
			public global::System.IntPtr get_cert_methods;

			// Token: 0x04000410 RID: 1040
			private global::System.IntPtr param;

			// Token: 0x04000411 RID: 1041
			public global::System.IntPtr verify;

			// Token: 0x04000412 RID: 1042
			public global::System.IntPtr verify_cb;

			// Token: 0x04000413 RID: 1043
			public global::System.IntPtr get_issuer;

			// Token: 0x04000414 RID: 1044
			public global::System.IntPtr check_issued;

			// Token: 0x04000415 RID: 1045
			public global::System.IntPtr check_revocation;

			// Token: 0x04000416 RID: 1046
			public global::System.IntPtr get_crl;

			// Token: 0x04000417 RID: 1047
			public global::System.IntPtr check_crl;

			// Token: 0x04000418 RID: 1048
			public global::System.IntPtr cert_crl;

			// Token: 0x04000419 RID: 1049
			public global::System.IntPtr lookup_certs;

			// Token: 0x0400041A RID: 1050
			public global::System.IntPtr lookup_crls;

			// Token: 0x0400041B RID: 1051
			public global::System.IntPtr cleanup;

			// Token: 0x0400041C RID: 1052
			public global::System.IntPtr ex_data_sk;

			// Token: 0x0400041D RID: 1053
			public int ex_data_dummy;

			// Token: 0x0400041E RID: 1054
			public int references;
		}
	}
}
