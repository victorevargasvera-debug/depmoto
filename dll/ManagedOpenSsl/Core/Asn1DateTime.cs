using System;
using System.Globalization;

namespace OpenSSL.Core
{
	// Token: 0x02000003 RID: 3
	internal class Asn1DateTime : global::OpenSSL.Core.Base
	{
		// Token: 0x0600000D RID: 13 RVA: 0x00002210 File Offset: 0x00000410
		internal Asn1DateTime(global::System.IntPtr ptr, bool takeOwnership) : base(ptr, takeOwnership)
		{
		}

		// Token: 0x0600000E RID: 14 RVA: 0x0000221A File Offset: 0x0000041A
		public Asn1DateTime() : base(global::OpenSSL.Core.Native.ASN1_TIME_new(), true)
		{
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002228 File Offset: 0x00000428
		public Asn1DateTime(global::System.DateTime dateTime) : this()
		{
			this.DateTime = dateTime;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002237 File Offset: 0x00000437
		protected override void OnDispose()
		{
			global::OpenSSL.Core.Native.ASN1_TIME_free(this.ptr);
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000011 RID: 17 RVA: 0x00002244 File Offset: 0x00000444
		// (set) Token: 0x06000012 RID: 18 RVA: 0x00002254 File Offset: 0x00000454
		public global::System.DateTime DateTime
		{
			get
			{
				return global::OpenSSL.Core.Asn1DateTime.ToDateTime(this.ptr);
			}
			set
			{
				long t = this.DateTimeToTimeT(value.ToUniversalTime());
				global::OpenSSL.Core.Native.ASN1_TIME_set(this.ptr, t);
			}
		}

		// Token: 0x06000013 RID: 19 RVA: 0x0000227C File Offset: 0x0000047C
		public static global::System.DateTime ToDateTime(global::System.IntPtr ptr)
		{
			return global::OpenSSL.Core.Asn1DateTime.AsnTimeToDateTime(ptr).ToLocalTime();
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002298 File Offset: 0x00000498
		private long DateTimeToTimeT(global::System.DateTime value)
		{
			global::System.DateTime dateTime = new global::System.DateTime(1970, 1, 1, 0, 0, 0, 0);
			return (value.Ticks - dateTime.Ticks) / 10000000L;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000022D0 File Offset: 0x000004D0
		private static global::System.DateTime AsnTimeToDateTime(global::System.IntPtr ptr)
		{
			string s;
			using (global::OpenSSL.Core.BIO bio = global::OpenSSL.Core.BIO.MemoryBuffer())
			{
				global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.ASN1_UTCTIME_print(bio.Handle, ptr));
				s = bio.ReadString();
			}
			string[] formats = new string[]
			{
				"MMM  d HH:mm:ss yyyy G\\MT",
				"MMM dd HH:mm:ss yyyy G\\MT"
			};
			return global::System.DateTime.ParseExact(s, formats, new global::System.Globalization.DateTimeFormatInfo(), global::System.Globalization.DateTimeStyles.AdjustToUniversal | global::System.Globalization.DateTimeStyles.AssumeUniversal);
		}
	}
}
