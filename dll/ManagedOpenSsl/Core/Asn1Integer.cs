using System;

namespace OpenSSL.Core
{
	// Token: 0x0200000D RID: 13
	internal class Asn1Integer : global::OpenSSL.Core.Base
	{
		// Token: 0x06000060 RID: 96 RVA: 0x00002AEB File Offset: 0x00000CEB
		internal Asn1Integer(global::System.IntPtr ptr, bool takeOwnership) : base(ptr, takeOwnership)
		{
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00002AF5 File Offset: 0x00000CF5
		public Asn1Integer() : base(global::OpenSSL.Core.Native.ASN1_INTEGER_new(), true)
		{
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00002B03 File Offset: 0x00000D03
		public Asn1Integer(int value) : this()
		{
			this.Value = value;
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00002B12 File Offset: 0x00000D12
		protected override void OnDispose()
		{
			global::OpenSSL.Core.Native.ASN1_TIME_free(this.ptr);
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000064 RID: 100 RVA: 0x00002B1F File Offset: 0x00000D1F
		// (set) Token: 0x06000065 RID: 101 RVA: 0x00002B2C File Offset: 0x00000D2C
		public int Value
		{
			get
			{
				return global::OpenSSL.Core.Native.ASN1_INTEGER_get(this.ptr);
			}
			set
			{
				global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.ASN1_INTEGER_set(this.ptr, value));
			}
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00002B40 File Offset: 0x00000D40
		public static int ToInt32(global::System.IntPtr ptr)
		{
			return global::OpenSSL.Core.Native.ASN1_INTEGER_get(ptr);
		}
	}
}
